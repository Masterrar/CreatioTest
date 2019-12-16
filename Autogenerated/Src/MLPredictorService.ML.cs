namespace Terrasoft.Configuration.ML
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Runtime.Serialization;
	using System.ServiceModel;
	using System.ServiceModel.Activation;
	using System.ServiceModel.Web;
	using global::Common.Logging;
	using Terrasoft.Common;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Factories;
	using Terrasoft.ML.Interfaces;
	using Terrasoft.Nui.ServiceModel.DataContract;
	using Terrasoft.Web.Common;
	using EntitySchema = Terrasoft.Core.Entities.EntitySchema;

	#region Class: MLPredictorService

	/// <summary>
	/// Web methods for machine learning prediction.
	/// </summary>
	/// <seealso cref="Terrasoft.Web.Common.BaseService" />
	[ServiceContract]
	[AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Required)]
	public class MLPredictorService : BaseService
	{

		#region Enum: ScoreEntityExitCode

		/// <summary>
		/// Serves as detailed exit code from <see cref="ScoreEntity(Guid, Guid, Guid)"/> service method.
		/// </summary>
		public enum ScoreEntityExitCode
		{
			/// <summary>
			/// This exit code is returned when entity is successfully scored.
			/// </summary>
			Ok,

			/// <summary>
			/// This exit code is returned when there are no active scoring models for entity.
			/// </summary>
			NoActiveModels

		}

		#endregion

		#region Class: ScoreEntityResult

		/// <summary>
		/// Response for Score entity service method.
		/// </summary>
		[DataContract]
		public class ScoreEntityResult
		{

			#region Constructors: Public

			/// <summary>
			/// Initializes a new instance of the <see cref="ScoreEntityResult"/> class.
			/// </summary>
			/// <param name="exitCode">The exit code.</param>
			public ScoreEntityResult(ScoreEntityExitCode exitCode) => ExitCode = exitCode;

			/// <summary>
			/// Initializes a new instance of the <see cref="ScoreEntityResult"/> class.
			/// </summary>
			/// <param name="predictedScore">The predicted score.</param>
			public ScoreEntityResult(double predictedScore) => PredictedScore = predictedScore;

			#endregion

			#region Properties: Public

			/// <summary>
			/// Gets or sets the predicted score.
			/// </summary>
			/// <value>The predicted score.</value>
			[DataMember(Name = "predictedScore")]
			public double PredictedScore { get; set; }

			/// <summary>
			/// Gets or sets the exit code of the service method.
			/// </summary>
			/// <value>The exit code.</value>
			[DataMember(Name = "exitCode")]
			public ScoreEntityExitCode ExitCode { get; set; } = ScoreEntityExitCode.Ok;

			#endregion

		}

		#endregion

		/// <summary>
		/// Result of scoring with explanation of model's columns contributions to this result.
		/// </summary>
		[DataContract]
		public class ExplainedScoreResult
		{

			#region Properties: Public

			/// <summary>
			/// Initializes a new instance of the <see cref="ExplainedScoreResult"/> class.
			/// </summary>
			/// <param name="exitCode">The exit code.</param>
			public ExplainedScoreResult(ScoreEntityExitCode exitCode) => ExitCode = exitCode;

			/// <summary>
			/// Gets or sets the predicted score.
			/// </summary>
			[DataMember(Name = "score")]
			public double Score { get; set; }

			/// <summary>
			/// Gets or sets the contributions that caused this score value.
			/// </summary>
			[DataMember(Name = "contributions")]
			public List<LocalizedFeatureWeight> Contributions { get; set; }

			/// <summary>
			/// Gets or sets the exit code of the service method.
			/// </summary>
			/// <value>The exit code.</value>
			[DataMember(Name = "exitCode")]
			public ScoreEntityExitCode ExitCode { get; set; }

			#endregion

		}

		#region Constants: Private

		private const string GenderModelId = "A2EF27C5-4921-4707-9A8A-5E299427CA59";
		private const string HighSignificance = "High";

		#endregion

		#region Fields: Private

		private static readonly ILog _log = LogManager.GetLogger("ML");

		#endregion

		#region Methods: Private

		private LookupColumnValue GetGenderLookupValue(ClassificationResult highlySignificantItem) {
			EntitySchema genderSchema = UserConnection.EntitySchemaManager.GetInstanceByName("Gender");
			Entity genderEntity = genderSchema.CreateEntity(UserConnection);
			if (!genderEntity.FetchPrimaryInfoFromDB(genderSchema.PrimaryColumn, highlySignificantItem.Value)) {
				return null;
			}
			return new LookupColumnValue {
				Value = highlySignificantItem.Value,
				DisplayValue = genderEntity.PrimaryDisplayColumnValue
			};
		}

		private Guid GetBestScoringModelForSchema(Guid entitySchemaUId, Guid entitySchemaTargetColumnUId) {
			var scoringProblem = new Guid(MLConsts.ScoringProblemType);
			var select = (Select)new Select(UserConnection).Top(1)
					.Column("Id")
				.From("MLModel")
				.Where("PredictionEnabled").IsEqual(Column.Parameter(true))
					.And("RootSchemaUId").IsEqual(Column.Parameter(entitySchemaUId))
					.And("MLProblemTypeId").IsEqual(Column.Parameter(scoringProblem))
					.And()
						.OpenBlock("TargetColumnUId").IsEqual(Column.Parameter(entitySchemaTargetColumnUId))
						.Or("PredictedResultColumnUId").IsEqual(Column.Parameter(entitySchemaTargetColumnUId))
						.CloseBlock()
					.And(Func.Len("ModelInstanceUId")).IsGreater(Column.Const(0))
				.OrderByDesc("InstanceMetric");
			return select.ExecuteScalar<Guid>();
		}

		#endregion

		#region Methods: Public

		/// <summary>
		/// Performs scoring for given entity, if there are available active models for given field and schema.
		/// </summary>
		/// <param name="entitySchemaUId">Entity schema id.</param>
		/// <param name="entitySchemaTargetColumnUId">Target field for scoring.</param>
		/// <param name="entityId">Entity id.</param>
		/// <returns>Detailed operation <see cref="ScoreEntityExitCode"/> and predicted score.</returns>
		[OperationContract]
		[WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Wrapped,
			RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
		[return: MessageParameter(Name = "result")]
		public ScoreEntityResult ScoreEntity(Guid entitySchemaUId, Guid entitySchemaTargetColumnUId, Guid entityId) {
			Guid modelId = GetBestScoringModelForSchema(entitySchemaUId, entitySchemaTargetColumnUId);
			if (modelId.IsEmpty()) {
				_log.WarnFormat("There are no active scoring models for field '{0}' in '{1}' entity",
					entitySchemaTargetColumnUId, entityId);
				return new ScoreEntityResult(ScoreEntityExitCode.NoActiveModels);
			}
			double predictedScore;
			try {
				var connectionArg = new ConstructorArgument("userConnection", UserConnection);
				var predictor = ClassFactory.Get<MLEntityPredictor>(connectionArg);
				predictedScore = predictor.PredictEntityValueAndSaveResult(modelId, entityId);
			} catch (Exception ex) {
				string message = $"Failed to evaluate score for entity '{entityId}' with model '{modelId}'";
				_log.Error(message, ex);
				throw;
			}
			return new ScoreEntityResult(predictedScore);
		}

		/// <summary>
		/// Performs scoring for given entity, if there are available active models for given field and schema. Also
		/// provides explanation of this scoring result.
		/// </summary>
		/// <param name="entitySchemaUId">Entity schema id.</param>
		/// <param name="entitySchemaTargetColumnUId">Target field for scoring.</param>
		/// <param name="entityId">Entity id.</param>
		/// <returns>Detailed operation <see cref="ScoreEntityExitCode"/>, predicted score and contribution of model
		/// column values to this score.</returns>
		[OperationContract]
		[WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Wrapped,
			RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
		[return: MessageParameter(Name = "result")]
		public ExplainedScoreResult ScoreAndExplain(Guid entitySchemaUId, Guid entitySchemaTargetColumnUId,
				Guid entityId) {
			var connectionArg = new ConstructorArgument("userConnection", UserConnection);
			var predictor = ClassFactory.Get<MLEntityPredictor>(connectionArg);
			Guid modelId = GetBestScoringModelForSchema(entitySchemaUId, entitySchemaTargetColumnUId);
			if (modelId.IsEmpty()) {
				_log.WarnFormat("There are no active scoring models for field '{0}' in '{1}' entity",
					entitySchemaTargetColumnUId, entityId);
				return new ExplainedScoreResult(ScoreEntityExitCode.NoActiveModels);
			}
			ScoringOutput scoringOutput = predictor.ScoreAndExplain(modelId, entityId);
			List<LocalizedFeatureWeight> contributions = scoringOutput.Contributions
				.Select(featureContribution => new LocalizedFeatureWeight(featureContribution)).ToList();
			MLModelExplanationUtils.LocalizeFeatures(UserConnection, contributions, modelId, true);
			return new ExplainedScoreResult(ScoreEntityExitCode.Ok) {
				Score = scoringOutput.Score,
				Contributions = contributions
			};
		}

		#endregion

	}

	#endregion

}

