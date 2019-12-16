namespace Terrasoft.Configuration.ML
{
	using System;
	using System.Collections.Generic;
	using Common;
	using Core;
	using Core.DB;
	using Core.Factories;
	using global::Common.Logging;

	public abstract class MLBatchNumericPredictor: IMLBatchPredictor
	{

		#region Fields: Private

		private static readonly ILog _log = LogManager.GetLogger("ML");
		private readonly int _predictionChunkSize = 500;
		private readonly UserConnection _userConnection;
		private readonly MLPredictionSaver _predictionSaver;

		#endregion

		#region Constructors: Public

		/// <summary>
		/// Initializes a new instance of the <see cref="MLBatchNumericPredictor"/> class.
		/// </summary>
		/// <param name="userConnection">The user connection.</param>
		public MLBatchNumericPredictor(UserConnection userConnection) {
			_userConnection = userConnection;
			ConstructorArgument userConnectionArg = new ConstructorArgument("userConnection", _userConnection);
			_predictionSaver = ClassFactory.Get<MLPredictionSaver>(userConnectionArg);
		}

		#endregion

		#region Properties: Private

		private IMLDataLoader _dataLoader;
		private IMLDataLoader DataLoader => _dataLoader ?? (_dataLoader = InitDataLoader());

		#endregion

		#region Methods: Private

		private IMLDataLoader InitDataLoader() {
			ConstructorArgument userConnectionArg = new ConstructorArgument("userConnection", _userConnection);
			var config = new MLDataLoaderConfig {
				ChunkSize = _predictionChunkSize,
				MaxRecordsCount = -1
			};
			ConstructorArgument configArg = new ConstructorArgument("config", config);
			return ClassFactory.Get<IMLDataLoader>(userConnectionArg, configArg);
		}

		private List<double> Predict(MLModelConfig model,
				IList<Dictionary<string, object>> dataForPrediction) {
			var apiKey = BpmonlineCloudEngine.GetAPIKey(_userConnection);
			var serviceUrlArg = new ConstructorArgument("serviceUrl", model.ServiceUrl);
			var apiKeyArg = new ConstructorArgument("apiKey", apiKey);
			IMLServiceProxy proxy;
			try {
				proxy = ClassFactory.Get<IMLServiceProxy>(serviceUrlArg, apiKeyArg);
			} catch (IncorrectConfigurationException ex) {
				_log.WarnFormat($"Can't predict value for model {model.Id}", ex);
				throw;
			}
			var predictionResults = Predict(model, dataForPrediction, proxy);
			return predictionResults;
		}

		private void UpdateEntityTargetColumn(string entitySchemaName, string targetFieldName, Guid entityId,
				double value) {
			var query = new Update(_userConnection, entitySchemaName)
				.Set(targetFieldName, Column.Parameter(FormatValueForSaving(value)))
				.Where("Id").IsEqual(Column.Parameter(entityId));
			query.Execute();
		}

		private void LogPredictedValue(Guid modelId, Guid modelInstanceUId, Guid entityId, double value) {
			_predictionSaver.SavePrediction(modelId, modelInstanceUId, entityId, value);
		}

		private void UpdateEntitiesTargetColumn(MLModelConfig model, Dictionary<Guid, object> predictedData) {
			if (predictedData.IsNullOrEmpty()) {
				return;
			}
			var entitySchema = _userConnection.EntitySchemaManager.GetInstanceByUId(model.EntitySchemaId);
			var entitySchemaName = entitySchema.Name;
			foreach (KeyValuePair<Guid, object> prediction in predictedData) {
				Guid entityId = prediction.Key;
				double value = Convert.ToDouble(prediction.Value);
				UpdateEntityTargetColumn(entitySchemaName, model.PredictedResultColumnName, entityId, value);
			}
		}

		#endregion

		#region Methods: Protected

		/// <summary>
		/// Predicts numeric value for the specified model.
		/// </summary>
		/// <param name="model">The model.</param>
		/// <param name="dataForPrediction">The data for prediction.</param>
		/// <param name="proxy">The proxy.</param>
		/// <returns>Numeric value result.</returns>
		protected abstract List<double> Predict(MLModelConfig model,
			IList<Dictionary<string, object>> dataForPrediction, IMLServiceProxy proxy);

		/// <summary>
		/// Formats the result value for saving.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns>Formatted value.</returns>
		protected virtual object FormatValueForSaving(double value) {
			return value;
		}

		#endregion

		#region Methods: Public

		/// <summary>
		/// Predicts data by the specified machine learning model.
		/// </summary>
		/// <param name="modelConfig">Machine learning model configuration.</param>
		/// <param name="chunkPredictedHandler">Handler on each chunk predicted event. Invokes with dictionary where
		/// key is entity identifier and value is predicted result for that entity.</param>
		/// <exception cref="AggregateException">When at least one of chunk failed to predict.</exception>
		public void Predict(MLModelConfig modelConfig, Action<Dictionary<Guid, object>> chunkPredictedHandler) {
			var parameters = new Dictionary<string, object> {
				{ "BatchPredictedOn", modelConfig.BatchPredictedOn }
			};
			int chunkNumber = 0;
			var exceptions = new List<Exception>();
			var modelQueryAssembler = ClassFactory.Get<IMLModelQueryBuilder>(
				new ConstructorArgument("userConnection", _userConnection));
			Select select = modelQueryAssembler.BuildSelect(modelConfig.EntitySchemaId,
				modelConfig.BatchPredictionQuery, modelConfig.ColumnExpressions, modelConfig.BatchPredictionFilterData,
				parameters);
			DataLoader.LoadDataForPrediction(select, dataForPrediction => {
				chunkNumber++;
				if (dataForPrediction.Count == 0) {
					return;
				}
				IList<double> predictedValues;
				try {
					predictedValues = Predict(modelConfig, dataForPrediction);
				} catch (Exception ex) {
					_log.Warn($"Batch predict for chunk #{chunkNumber} failed - skipping. ModelId = {modelConfig.Id}",
						ex);
					exceptions.Add(ex);
					return;
				}
				var results = new Dictionary<Guid, object>();
				for (int i = 0; i < dataForPrediction.Count; i++) {
					Dictionary<string, object> record = dataForPrediction[i];
					if (record.TryGetValue("Id", out object id) && Guid.TryParse(id.ToString(), out Guid recordId)) {
						results.Add(recordId, predictedValues[i]);
						LogPredictedValue(modelConfig.Id, modelConfig.ModelInstanceUId, recordId, predictedValues[i]);
					} else {
						exceptions.Add(new Exception("Rowset contains a record without Id"));
					}
				}
				chunkPredictedHandler(results);
			});
			if (!exceptions.IsNullOrEmpty()) {
				throw new AggregateException(exceptions);
			}
		}
			
		/// <summary>
		/// Saves the predicted data to entities.
		/// </summary>
		/// <param name="modelConfig">Machine learning model configuration.</param>
		/// <param name="predictedData">Dictionary where key is entity identifier and value is predicted
		/// result for that entity.</param>
		public void SavePredictedData(MLModelConfig modelConfig, Dictionary<Guid, object> predictedData) {
			if (predictedData.IsNullOrEmpty()) {
				_log.Info("MLBatchNumericPredictor.SavePredictedData: predictedData is empty. " +
					$"Model {modelConfig.Id}");
				return;
			}
			UpdateEntitiesTargetColumn(modelConfig, predictedData);
		}

		#endregion

	}
}

