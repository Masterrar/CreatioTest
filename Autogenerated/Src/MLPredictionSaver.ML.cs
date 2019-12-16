namespace Terrasoft.Configuration.ML
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using Common;
	using Core;
	using Core.DB;
	using Core.Entities;
	using global::Common.Logging;
	using Terrasoft.ML.Interfaces;

	#region Class: MLPredictionSaver

	/// <summary>
	/// Provides a base class for saving prediction results.
	/// </summary>
	public class MLPredictionSaver
	{

		#region Constants: Private

		private const string HighSignificance = "High";

		#endregion

		#region Fields: Private

		private static readonly ILog _log = LogManager.GetLogger("ML");

		#endregion

		#region Fields: Protected

		protected readonly UserConnection _userConnection;

		#endregion

		#region Constructors: Public

		/// <summary>
		/// Initializes a new instance of the <see cref="MLPredictionSaver"/> class.
		/// </summary>
		/// <param name="userConnection">The user connection.</param>
		public MLPredictionSaver(UserConnection userConnection) {
			_userConnection = userConnection;
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Gets or sets a value indicating whether to use administrative rights while saving predictions.
		/// </summary>
		public bool UseAdminRights { get; set; } = true;

		#endregion

		#region Methods: Private

		private Entity GetEntity(Guid schemaUId, Guid entityId) {
			var entitySchema = _userConnection.EntitySchemaManager.GetInstanceByUId(schemaUId);
			Entity entity = entitySchema.CreateEntity(_userConnection);
			entity.UseAdminRights = UseAdminRights;
			if (!entity.FetchFromDB(entityId)) {
				_log.Warn($"Entity of schema {schemaUId} was not found by id {entityId}");
				return null;
			}
			return entity;
		}

		#endregion

		#region Methods: Protected

		/// <summary>
		/// Sets the predicted results to entity.
		/// </summary>
		/// <param name="entity">The entity.</param>
		/// <param name="columnValueName">Name of the column value.</param>
		/// <param name="classificationResults">The classification results.</param>
		/// <param name="onSetEntityValue">Function, that will be invoked before setting predicted value to entity.
		/// If it returns <c>false</c>, the value won't be set.</param>
		/// <returns><c>true</c> if the value was set, otherwise - <c>false</c>.</returns>
		protected virtual bool SetPredictedResultsToEntity(Entity entity, string columnValueName,
				List<ClassificationResult> classificationResults,
				Func<Entity, string, ClassificationResult, bool> onSetEntityValue) {
			var columnValue = entity.FindEntityColumnValue(columnValueName);
			ClassificationResult highlySignificantResult =
				classificationResults.FirstOrDefault(result => result.Significance == HighSignificance);
			if (highlySignificantResult == null) {
				return false;
			}
			if (onSetEntityValue != null && !onSetEntityValue(entity, columnValueName, highlySignificantResult)) {
				return false;
			}
			entity.SetColumnValue(columnValue.Column, highlySignificantResult.Value);
			return true;
		}

		/// <summary>
		/// Saves the prediction values to entity.
		/// </summary>
		/// <typeparam name="T">The type of predicted values.</typeparam>
		/// <param name="schemaUId">The entity schema's identifier, which should be saved.</param>
		/// <param name="entityId">The entity identifier.</param>
		/// <param name="predictedValues">The predicted values of entity for the several models.</param>
		/// <param name="valueTransformer">
		/// Optional mapping function, that should be applied to predicted value before saving.
		/// </param>
		/// <returns>
		/// <c>true</c> if the entity was saved, otherwise - <c>false</c>.
		/// </returns>
		protected virtual bool SaveEntityPredictedValues<T>(Guid schemaUId, Guid entityId,
			Dictionary<MLModelConfig, T> predictedValues, Func<T, object> valueTransformer) {
			if (predictedValues.IsNullOrEmpty()) {
				return false;
			}
			Entity entity = GetEntity(schemaUId, entityId);
			if (entity == null) {
				return false;
			}
			foreach (KeyValuePair<MLModelConfig, T> prediction in predictedValues) {
				MLModelConfig model = prediction.Key;
				EntitySchemaColumn column = entity.FindEntityColumnValue(model.PredictedResultColumnName).Column;
				if (valueTransformer != null) {
					object transformedPredictionValue = valueTransformer(prediction.Value);
					entity.SetColumnValue(column, transformedPredictionValue);
				} else {
					entity.SetColumnValue(column, prediction.Value);
				}
			}
			return entity.Save();
		}

		#endregion

		#region Methods: Public

		/// <summary>
		/// Saves the prediction values to entity.
		/// </summary>
		/// <param name="schemaUId">The entity schema's identifier, which should be saved.</param>
		/// <param name="entityId">The entity identifier.</param>
		/// <param name="predictedValues">The predicted values of entity for the several models.</param>
		/// <param name="onSetEntityValue">Function, that will be invoked before setting predicted value to entity.
		/// If it returns <c>false</c>, the value won't be set.</param>
		/// <returns>
		/// <c>true</c> if the entity was saved, otherwise - <c>false</c>.
		/// </returns>
		public virtual bool SaveEntityPredictedValues(Guid schemaUId, Guid entityId,
				Dictionary<MLModelConfig, List<ClassificationResult>> predictedValues,
				Func<Entity, string, ClassificationResult, bool> onSetEntityValue = null) {
			if (predictedValues.IsNullOrEmpty()) {
				return false;
			}
			Entity entity = GetEntity(schemaUId, entityId);
			if (entity == null) {
				return false;
			}
			bool isAnyValueSet = false;
			predictedValues.ForEach(kv => {
				MLModelConfig model = kv.Key;
				List<ClassificationResult> classificationResults = kv.Value;
				isAnyValueSet |= SetPredictedResultsToEntity(entity, model.PredictedResultColumnName,
					classificationResults, onSetEntityValue);
			});
			return isAnyValueSet && entity.Save();
		}

		/// <summary>
		/// Saves the scores to entity.
		/// </summary>
		/// <param name="schemaUId">The entity schema's identifier, which should be saved.</param>
		/// <param name="entityId">The entity identifier.</param>
		/// <param name="scoredValues">The scored values of entity for the several models.</param>
		/// <returns>
		/// <c>true</c> if the entity was saved, otherwise - <c>false</c>.
		/// </returns>
		public virtual bool SaveEntityScoredValues(Guid schemaUId, Guid entityId,
				Dictionary<MLModelConfig, double> scoredValues) {
			return SaveEntityPredictedValues(schemaUId, entityId, scoredValues, score =>(int)(score * 100));
		}

		/// <summary>
		/// Saves the prediction values to entity.
		/// </summary>
		/// <param name="schemaUId">The entity schema's identifier, which should be saved.</param>
		/// <param name="entityId">The entity identifier.</param>
		/// <param name="predictedValues">The predicted values of entity for the several models.</param>
		/// <returns>
		/// <c>true</c> if the entity was saved, otherwise - <c>false</c>.
		/// </returns>
		public virtual bool SaveEntityRegressionValues(Guid schemaUId, Guid entityId,
				Dictionary<MLModelConfig, double> predictedValues) {
			return SaveEntityPredictedValues(schemaUId, entityId, predictedValues, null);
		}

		/// <summary>
		/// Saves the classification results.
		/// </summary>
		/// <param name="modelId">The model identifier.</param>
		/// <param name="modelInstanceId">The model instance identifier.</param>
		/// <param name="entityId">The entity identifier.</param>
		/// <param name="results">Result, returned by ML service.</param>
		public virtual void SavePrediction(Guid modelId, Guid modelInstanceId, Guid entityId,
				List<ClassificationResult> results) {
			Query delete = new Delete(_userConnection)
				.From("MLClassificationResult")
				.Where("Key").IsEqual(Column.Parameter(entityId, "Guid"))
				.And("ModelId").IsEqual(Column.Parameter(modelId, "Guid"));
			delete.Execute();
			foreach (ClassificationResult prediction in results) {
				var query = new Insert(_userConnection)
					.Into("MLClassificationResult")
					.Set("Id", Column.Parameter(Guid.NewGuid()))
					.Set("CreatedOn", new QueryParameter(DateTime.UtcNow))
					.Set("ModifiedOn", new QueryParameter(DateTime.UtcNow))
					.Set("ModelId", new QueryParameter(modelId))
					.Set("ModelInstanceUId", new QueryParameter(modelInstanceId))
					.Set("Key", new QueryParameter(entityId))
					.Set("Value", new QueryParameter(Guid.Parse(prediction.Value)))
					.Set("Probability", new QueryParameter(prediction.Probability))
					.Set("Significance", new QueryParameter(prediction.Significance));
				query.Execute();
			}
		}

		/// <summary>
		/// Saves the numeric prediction result to MLPrediction entity.
		/// </summary>
		/// <param name="modelId">The model identifier.</param>
		/// <param name="modelInstanceId">The model instance identifier.</param>
		/// <param name="entityId">The entity identifier.</param>
		/// <param name="result">Result, returned by ML service.</param>
		public virtual void SavePrediction(Guid modelId, Guid modelInstanceId, Guid entityId, double result) {
			var query = new Insert(_userConnection)
				.Into("MLPrediction")
				.Set("Id", Column.Parameter(Guid.NewGuid()))
				.Set("CreatedOn", new QueryParameter(DateTime.UtcNow))
				.Set("ModifiedOn", new QueryParameter(DateTime.UtcNow))
				.Set("ModelId", new QueryParameter(modelId))
				.Set("ModelInstanceUId", new QueryParameter(modelInstanceId))
				.Set("Key", new QueryParameter(entityId))
				.Set("Probability", new QueryParameter(result));
			query.Execute();
		}

		#endregion

	}

	#endregion

}

