namespace Terrasoft.Configuration.ML
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using global::Common.Logging;
	using Common;
	using Core;
	using Core.Factories;
	using Terrasoft.Core.DB;
	using Terrasoft.ML.Interfaces;

	#region Class: MLEntityPredictor

	/// <summary>
	/// Predicts entity values using machine learning models.
	/// </summary>
	public class MLEntityPredictor
	{

		#region Delegates: Private

		private delegate void SavePredictionHandler<in T>(Guid modelId, Guid modelInstanceId, Guid entityId, T result);

		private delegate Dictionary<MLModelConfig, T> PredictHandler<T>(IList<MLModelConfig> models, Guid entityId);

		#endregion

		#region Fields: Private

		private static readonly ILog _log = LogManager.GetLogger("ML");
		private readonly UserConnection _userConnection;

		#endregion

		#region Constructors: Public

		/// <summary>
		/// Initializes a new instance of the <see cref="MLEntityPredictor"/> class.
		/// </summary>
		/// <param name="userConnection">The user connection.</param>
		public MLEntityPredictor(UserConnection userConnection) => _userConnection = userConnection;

		#endregion

		#region Properties: Private

		private IMLDataLoader _dataLoader;
		private IMLDataLoader DataLoader => _dataLoader ?? (_dataLoader = InitDataLoader());

		private MLPredictionSaver _predictionSaver;
		private MLPredictionSaver PredictionSaver => _predictionSaver ?? (_predictionSaver = InitPredictionSaver());

		#endregion

		#region Properties: Public

		/// <summary>
		/// Gets the entity schema identifier, which models refers to.
		/// </summary>
		public Guid ModelRootSchemaUId { get; private set; }

		/// <summary>
		/// Gets or sets a value indicating whether to use administrative rights while saving predictions.
		/// </summary>
		public bool UseAdminRights { get; set; } = true;

		#endregion

		#region Methods: Private

		private static void SavePredictions<T>(Guid entityId, Dictionary<MLModelConfig, T> predictedValues,
				SavePredictionHandler<T> savePrediction) {
			if (predictedValues.IsNullOrEmpty()) {
				return;
			}
			foreach (KeyValuePair<MLModelConfig, T> prediction in predictedValues) {
				savePrediction(prediction.Key.Id, prediction.Key.ModelInstanceUId, entityId, prediction.Value);
			}
		}

		private static Dictionary<MLModelConfig, T> PredictEntityValues<T>(IEnumerable<MLModelConfig> models,
				Guid entityId,
				Func<MLModelConfig, bool> isModelReady,
				PredictHandler<T> predict) {
			var readyModels = models.Where(isModelReady).ToList();
			if (!readyModels.Any()) {
				_log.Error($"No ready models found for prediction entity with id '{entityId}'");
				return new Dictionary<MLModelConfig, T>();
			}
			var predictedValues = predict(readyModels, entityId) ?? new Dictionary<MLModelConfig, T>();
			return predictedValues;
		}

		private IMLDataLoader InitDataLoader() {
			ConstructorArgument userConnectionArg = new ConstructorArgument("userConnection", _userConnection);
			var config = new MLDataLoaderConfig {
				MinRecordsCount = 1,
				ChunkSize = 500,
				MaxRecordsCount = -1
			};
			ConstructorArgument configArg = new ConstructorArgument("config", config);
			return ClassFactory.Get<IMLDataLoader>(userConnectionArg, configArg);
		}

		private MLPredictionSaver InitPredictionSaver() {
			ConstructorArgument userConnectionArg = new ConstructorArgument("userConnection", _userConnection);
			var predictionSaver = ClassFactory.Get<MLPredictionSaver>(userConnectionArg);
			predictionSaver.UseAdminRights = UseAdminRights;
			return predictionSaver;
		}

		private bool IsBaseModelPropertiesFullfilled(MLModelConfig model) {
			if (model.ModelInstanceUId.IsEmpty()) {
				_log.InfoFormat("Loaded model '{0}' disabled for predictions or not trained yet", model.Id);
				return false;
			}
			if (model.ServiceUrl.IsNullOrEmpty()) {
				_log.WarnFormat("Loaded model '{0}' is incorrect, because ServiceUrl is empty", model.Id);
				return false;
			}
			if (model.EntitySchemaId.IsEmpty()) {
				_log.WarnFormat("Loaded model '{0}' is incorrect, because RootSchemaUId is empty", model.Id);
				return false;
			}
			var prevRootSchemaUId = ModelRootSchemaUId;
			if (prevRootSchemaUId.IsNotEmpty() && prevRootSchemaUId != model.EntitySchemaId) {
				ModelRootSchemaUId = Guid.Empty;
				throw new InvalidObjectStateException("Prediction can't be made, because models have different " +
					$"RootSchemaUId: {prevRootSchemaUId} and { model.EntitySchemaId }");
			}
			if (model.PredictedResultColumnName.IsNullOrEmpty()) {
				_log.WarnFormat("Loaded model '{0}' is incorrect, because PredictedResultColumnName is empty",
					model.Id);
				return false;
			}
			ModelRootSchemaUId = model.EntitySchemaId;
			return true;
		}

		private bool IsModelReadyForClassification(MLModelConfig model) {
			if (!IsBaseModelPropertiesFullfilled(model)) {
				return false;
			}
			return true;
		}

		private IList<MLModelConfig> LoadModels(List<Guid> modelIds) {
			modelIds.CheckArgumentNullOrEmpty(nameof(modelIds));
			var loader = ClassFactory.Get<IMLModelLoader>();
			return loader.LoadEnabledModels(_userConnection, modelIds);
		}

		private bool TryGetMLProxy(MLModelConfig model, out IMLServiceProxy proxy) {
			var apiKey = BpmonlineCloudEngine.GetAPIKey(_userConnection);
			var serviceUrlArg = new ConstructorArgument("serviceUrl", model.ServiceUrl);
			var apiKeyArg = new ConstructorArgument("apiKey", apiKey);
			proxy = null;
			try {
				proxy = ClassFactory.Get<IMLServiceProxy>(serviceUrlArg, apiKeyArg);
				return true;
			} catch (IncorrectConfigurationException ex) {
				_log.WarnFormat("Can\'t call ML proxy because of ", ex);
				return false;
			}
		}

		private bool TryLoadData(MLModelConfig modelConfig, string query, Guid entityId,
				out Dictionary<string, object> data) {
			var modelQueryAssembler = ClassFactory.Get<IMLModelQueryBuilder>(
				new ConstructorArgument("userConnection", _userConnection));
			Select select = modelQueryAssembler.BuildSelect(modelConfig.EntitySchemaId, query,
				modelConfig.ColumnExpressions);
			IMLModelValidator modelValidator = ClassFactory.Get<IMLModelValidator>();
			modelValidator.CheckInputColumns(select, modelConfig.GetModelSchemaMetadata());
			data = DataLoader.LoadDataForPrediction(select, entityId);
			return !data.IsNullOrEmpty();
		}

		private Dictionary<MLModelConfig, List<ClassificationResult>> Classify(IList<MLModelConfig> models,
				Guid entityId) {
			var predictionResults = new Dictionary<MLModelConfig, List<ClassificationResult>>();
			foreach (var model in models) {
				if (!TryLoadData(model, model.TrainingSetQuery, entityId, out var data) || 
						!TryGetMLProxy(model, out var proxy)) {
					continue;
				}
				List<ClassificationResult> classificationResults = proxy.Classify(model.ModelInstanceUId, data);
				if (classificationResults.IsNullOrEmpty()) {
					continue;
				}
				predictionResults[model] = classificationResults;
			}
			return predictionResults;
		}

		private Dictionary<MLModelConfig, double> Score(IList<MLModelConfig> models, Guid entityId) {
			var predictionResults = new Dictionary<MLModelConfig, double>();
			foreach (var model in models) {
				if (!TryLoadData(model, model.BatchPredictionQuery, entityId, out var data) ||
						!TryGetMLProxy(model, out var proxy)) {
					continue;
				}
				ScoringOutput scoreValue = proxy.Score(model, data, false);
				predictionResults[model] = scoreValue.Score;
			}
			return predictionResults;
		}

		private Dictionary<MLModelConfig, ScoringOutput> ScoreAndExplain(IList<MLModelConfig> models, Guid entityId) {
			var predictionResults = new Dictionary<MLModelConfig, ScoringOutput>();
			foreach (var model in models) {
				if (!TryLoadData(model, model.BatchPredictionQuery, entityId, out var data) ||
						!TryGetMLProxy(model, out var proxy)) {
					continue;
				}
				ScoringOutput scoreValue = proxy.Score(model, data, true);
				predictionResults[model] = scoreValue;
			}
			return predictionResults;
		}

		private Dictionary<MLModelConfig, double> Regress(IList<MLModelConfig> models, Guid entityId) {
			var predictionResults = new Dictionary<MLModelConfig, double>();
			foreach (var model in models) {
				if (!TryLoadData(model, model.BatchPredictionQuery, entityId, out var data) || 
						!TryGetMLProxy(model, out var proxy)) {
					continue;
				}
				var wrappedData = new List<Dictionary<string, object>> { data };
				double regressionValue = proxy.Regress(model.ModelInstanceUId, wrappedData).FirstOrDefault();
				predictionResults[model] = regressionValue;
			}
			return predictionResults;
		}

		private Dictionary<MLModelConfig, List<ClassificationResult>> ClassifyEntityValues(IList<MLModelConfig> models,
				Guid entityId) {
			return PredictEntityValues(models, entityId,
				IsModelReadyForClassification,
				Classify);
		}

		private Dictionary<MLModelConfig, double> ScoreEntityValues(IList<MLModelConfig> models, Guid entityId) {
			return PredictEntityValues(models, entityId,
				IsBaseModelPropertiesFullfilled,
				Score);
		}

		private Dictionary<MLModelConfig, double> RegressEntityValues(IList<MLModelConfig> models, Guid entityId) {
			return PredictEntityValues(models, entityId,
				IsBaseModelPropertiesFullfilled,
				Regress);
		}

		private void SaveEntityValues(Guid entityId,
				Dictionary<MLModelConfig, List<ClassificationResult>> predictedValues) {
			var connectionArg = new ConstructorArgument("userConnection", _userConnection);
			var filter = ClassFactory.Get<MLBasePredictedValueFilter>(connectionArg);
			PredictionSaver.SaveEntityPredictedValues(ModelRootSchemaUId, entityId, predictedValues,
				filter.OnSetupPredictedValue);
			_log.Debug($"Classification for entity {entityId} completed. {predictedValues.Count} results predicted " +
				"and saved.");
		}

		private void SaveEntityValues(Guid entityId, Dictionary<MLModelConfig, double> predictedValues,
			Func<Guid, Guid, Dictionary<MLModelConfig, double>, bool> saveEntityPredictedValues) {
			saveEntityPredictedValues(ModelRootSchemaUId, entityId, predictedValues);
			_log.Debug($"Prediction for entity {entityId} completed. {predictedValues.Count} results predicted " +
				"and saved.");
		}

		#endregion

		#region Methods: Public

		/// <summary>
		/// Predicts the entity value and saves result in entity. Uses problem type of the specified ML model.
		/// </summary>
		/// <param name="modelId">The machine learning model identifier.</param>
		/// <param name="entityId">The entity identifier.</param>
		/// <returns>Predicted value.</returns>
		/// <exception cref="UnsupportedTypeException">Problem type is not supported for current operation.</exception>
		public virtual double PredictEntityValueAndSaveResult(Guid modelId, Guid entityId) {
			_log.Debug($"Predicting entity value for model {modelId} with entityId {entityId}");
			entityId.CheckArgumentEmpty(nameof(entityId));
			if (modelId.IsEmpty()) {
				_log.Warn("Model id should not be empty. Nothing to do.");
				return default(double);
			}
			_userConnection.LicHelper.CheckHasOperationLicense(MLConsts.LicOperationCode);
			var models = LoadModels(new List<Guid> {modelId});
			if (models.IsNullOrEmpty()) {
				_log.Warn($"No models found with id {modelId}");
				return default(double);
			}
			var model = models.First();
			if (model.ProblemType == new Guid(MLConsts.ScoringProblemType)) {
				var result = ScoreEntityValues(models, entityId);
				SavePredictions(entityId, result, PredictionSaver.SavePrediction);
				SaveEntityValues(entityId, result, PredictionSaver.SaveEntityScoredValues);
				return result.Values.FirstOrDefault();
			}
			if (model.ProblemType == new Guid(MLConsts.RegressionProblemType)) {
				var result = RegressEntityValues(models, entityId);
				SavePredictions(entityId, result, PredictionSaver.SavePrediction);
				SaveEntityValues(entityId, result, PredictionSaver.SaveEntityRegressionValues);
				return result.Values.FirstOrDefault();
			}
			if (model.ProblemType == new Guid(MLConsts.ClassificationProblemType)) {
				var result = ClassifyEntityValues(models, entityId);
				SavePredictions(entityId, result, PredictionSaver.SavePrediction);
				SaveEntityValues(entityId, result);
				return result.Values.FirstOrDefault()?.First().Probability ?? default(double);
			}
			throw new UnsupportedTypeException(
				$"Prediction for problem type {model.ProblemType} is not supported. Model Id = {modelId}");
		}

		/// <summary>
		/// Scores the entity value and gives explanation of the result.
		/// </summary>
		/// <param name="modelId">The machine learning model identifier.</param>
		/// <param name="entityId">The entity identifier.</param>
		/// <returns>Predicted score with explanations.</returns>
		/// <exception cref="UnsupportedTypeException">Problem type is not supported for current operation.</exception>
		public ScoringOutput ScoreAndExplain(Guid modelId, Guid entityId) {
			_log.Debug($"Scoring value for model {modelId} with entityId {entityId} with explanation");
			entityId.CheckArgumentEmpty(nameof(entityId));
			if (modelId.IsEmpty()) {
				_log.Warn("Model id should not be empty. Nothing to do.");
				return null;
			}
			_userConnection.LicHelper.CheckHasOperationLicense(MLConsts.LicOperationCode);
			var models = LoadModels(new List<Guid> {modelId});
			if (models.IsNullOrEmpty()) {
				_log.Warn($"No models found with id {modelId}");
				return null;
			}
			var model = models.First();
			if (model.ProblemType != new Guid(MLConsts.ScoringProblemType)) {
				throw new UnsupportedTypeException($"Problem type of model {modelId} is {model.ProblemType}, " +
					$"but should be {MLConsts.ScoringProblemType}");
			}
			Dictionary<MLModelConfig, ScoringOutput> result = PredictEntityValues(models, entityId,
				IsBaseModelPropertiesFullfilled,
				ScoreAndExplain);
			return result.Values.FirstOrDefault();
		}

		/// <summary>
		/// Classifies the entity values.
		/// </summary>
		/// <param name="modelIds">The machine learning model identifiers. All models should target the same entity
		/// schema.</param>
		/// <param name="entityId">The entity identifier.</param>
		/// <returns>Predicted results (key is the target field value, value is the list of predicted results).
		/// </returns>
		/// <exception cref="InvalidObjectStateException">Not all models target the same entity schema.</exception>
		public virtual Dictionary<MLModelConfig, List<ClassificationResult>> ClassifyEntityValues(List<Guid> modelIds,
				Guid entityId) {
			entityId.CheckArgumentEmpty(nameof(entityId));
			_userConnection.LicHelper.CheckHasOperationLicense(MLConsts.LicOperationCode);
			var models = LoadModels(modelIds);
			var result = ClassifyEntityValues(models, entityId);
			SavePredictions(entityId, result, PredictionSaver.SavePrediction);
			return result;
		}

		/// <summary>
		/// Scores the entity values.
		/// </summary>
		/// <param name="modelIds">The scoring ML model identifiers. All models should target the same entity
		/// schema.</param>
		/// <param name="entityId">The entity identifier.</param>
		/// <returns>Scores results (key is the target field value, value is the scored result).
		/// </returns>
		/// <exception cref="InvalidObjectStateException">Not all models target the same entity schema.</exception>
		public virtual Dictionary<MLModelConfig, double> ScoreEntityValues(List<Guid> modelIds, Guid entityId) {
			entityId.CheckArgumentEmpty(nameof(entityId));
			_userConnection.LicHelper.CheckHasOperationLicense(MLConsts.LicOperationCode);
			IList<MLModelConfig> models = LoadModels(modelIds);
			var predictedValues = ScoreEntityValues(models, entityId);
			SavePredictions(entityId, predictedValues, PredictionSaver.SavePrediction);
			return predictedValues;
		}

		#endregion

	}

	#endregion

}

