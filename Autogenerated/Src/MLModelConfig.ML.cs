namespace Terrasoft.Configuration.ML
{
	using System;
	using System.Collections.Generic;
	using Newtonsoft.Json;
	using ServiceStack.Common;
	using Terrasoft.ML.Interfaces;
	using Terrasoft.Nui.ServiceModel.DataContract;

	#region Class: MLModelConfig

	/// <summary>
	/// Machine learning model configuration.
	/// </summary>
	public class MLModelConfig
	{

		#region Class: MLColumnExpression

		/// <summary>
		/// Extension to <see cref="Terrasoft.Nui.ServiceModel.DataContract.ColumnExpression"/> with ML model
		/// additional properties.
		/// </summary>
		/// <seealso cref="Terrasoft.Nui.ServiceModel.DataContract.ColumnExpression" />
		public class MLColumnExpression : ColumnExpression
		{

			#region Properties: Public

			/// <summary>
			/// Gets or sets the customized caption of the column.
			/// </summary>
			public string Caption { get; set; }

			#endregion

		}

		#endregion


		#region Fields: Private

		private ModelSchemaMetadata _modelSchemaMetaData;

		#endregion

		#region Properties: Public

		/// <summary>
		/// Gets or sets the identifier of the model configuration.
		/// </summary>
		/// <value>
		/// The identifier.
		/// </value>
		public Guid Id { get; set; }

		/// <summary>
		/// Gets or sets the meta data of the model's inputs and outputs.
		/// </summary>
		/// <value>
		/// The meta data.
		/// </value>
		public string MetaData { get; set; }

		/// <summary>
		/// Gets or sets the train session identifier.
		/// </summary>
		/// <value>
		/// The train session identifier.
		/// </value>
		public Guid TrainSessionId { get; set; }

		/// <summary>
		/// Gets or sets the machine learning service URL for the current model configuration.
		/// </summary>
		/// <value>
		/// The service URL.
		/// </value>
		public string ServiceUrl { get; set; }

		/// <summary>
		/// Gets or sets the machine learning service training endpoint.
		/// </summary>
		/// <value>
		/// The training endpoint.
		/// </value>
		public string TrainingEndpoint { get; set; }

		/// <summary>
		/// Gets or sets the machine learning service prediction endpoint.
		/// </summary>
		/// <value>
		/// The prediction endpoint.
		/// </value>
		public string PredictionEndpoint { get; set; }

		/// <summary>
		/// Gets or sets the training set query expression. The expression should be a valid C# code, that returns
		/// <see cref="Terrasoft.Core.DB.Select"/> instance.
		/// </summary>
		/// <value>
		/// The training set query.
		/// </value>
		public string TrainingSetQuery { get; set; }

		/// <summary>
		/// Gets or sets batch prediction filter query expression. The expression should be a valid C# code, that
		/// returns <see cref="Terrasoft.Core.DB.Select"/> instance.
		/// </summary>
		/// <value>
		/// The batch prediction filter query.
		/// </value>
		public string BatchPredictionQuery { get; set; }

		/// <summary>
		/// Gets or sets the metric threshold.
		/// </summary>
		/// <value>
		/// The metric threshold.
		/// </value>
		public double MetricThreshold { get; set; }

		/// <summary>
		/// Gets or sets the state of the model.
		/// </summary>
		/// <value>
		/// The state of the model.
		/// </value>
		public TrainSessionState CurrentState { get; set; }

		/// <summary>
		/// Gets or sets problem type.
		/// </summary>
		public Guid ProblemType { get; set; }

		/// <summary>
		/// Gets or sets model instance identifier.
		/// </summary>
		public Guid ModelInstanceUId { get; set; }

		/// <summary>
		/// Gets or sets entity schema that used for training and prediction.
		/// </summary>
		public Guid EntitySchemaId { get; set; }

		/// <summary>
		/// Gets or sets last batch prediction date.
		/// </summary>
		public DateTime BatchPredictedOn { get; set; }

		/// <summary>
		/// Gets or sets the name of the training target column.
		/// </summary>
		public string TrainingTargetColumnName { get; set; }

		/// <summary>
		/// Minimum number of records for training.
		/// </summary>
		public int TrainingMinimumRecordsCount { get; set; }

		/// <summary>
		/// Gets or sets column identifiers of the training query.
		/// </summary>
		public IList<Guid> ColumnUIds { get; set; }

		/// <summary>
		/// Gets or sets column expressions of the training query.
		/// </summary>
		public IEnumerable<MLColumnExpression> ColumnExpressions { get; set; }

		/// <summary>
		/// Gets or sets serialized filters of the training query.
		/// </summary>
		public byte[] TrainingFilterData { get; set; }

		/// <summary>
		/// Gets or sets the name of the predicted result column.
		/// </summary>
		/// <value>
		/// The name of the predicted result column.
		/// </value>
		public string PredictedResultColumnName { get; set; }

		/// <summary>
		/// Gets or sets serialized filters of the training output query column.
		/// </summary>
		public byte[] TrainingOutputFilterData { get; set; }

		/// <summary>
		/// Gets or sets serialized filters of the batch prediction query.
		/// </summary>
		public byte[] BatchPredictionFilterData { get; set; }

		#endregion

		#region Methods: Public

		/// <summary>
		/// Gets the deserialized from MetaData property model schema.
		/// </summary>
		/// <returns>Metadata object.</returns>
		public ModelSchemaMetadata GetModelSchemaMetadata() {
			if (MetaData.IsNullOrEmpty()) {
				return new ModelSchemaMetadata();
			}
			if (_modelSchemaMetaData == null) {
				try {
					_modelSchemaMetaData = JsonConvert.DeserializeObject<ModelSchemaMetadata>(MetaData);
				} catch (Exception) {
					_modelSchemaMetaData = new ModelSchemaMetadata();
				}
			}
			return _modelSchemaMetaData;
		}

		#endregion

	}

	#endregion

}

