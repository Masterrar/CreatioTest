namespace Terrasoft.Core.Process.Configuration
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Serialization;
	using Terrasoft.Configuration.ML;
	using Terrasoft.Core.Factories;
	using Terrasoft.Nui.ServiceModel.DataContract;

	#region Class: MLDataPredictionUserTask

	/// <summary>
	/// Partial class, that implements user task runtime behaviour.
	/// </summary>
	public partial class MLDataPredictionUserTask
	{

		#region Class: FilterEditConverter

		/// <summary>
		/// Provides methods for convertion from process filters to regular NUI filters by resolving
		/// process parameters.
		/// </summary>
		private class FilterEditConverter : ProcessDataContractFilterConverter
		{

			#region Constructors: Public

			/// <summary>
			/// Initializes a new instance of <see cref="FilterEditConverter"/>.
			/// </summary>
			/// <param name="userConnection">User connection</param>
			public FilterEditConverter(UserConnection userConnection) : base(userConnection) {
			}

			#endregion

			#region Methods: Public

			/// <summary>
			/// Converts serialized process filters to regular NUI <see cref="Filters"/>
			/// by resolving given process parameters.
			/// </summary>
			/// <param name="process">Process activity to obtain parameters.</param>
			/// <param name="processFilters">Serialized process filters.</param>
			/// <returns>Serialized NUI filters.</returns>
			public string Convert(Process process, string processFilters) {
				Filters filters = ConvertFilters(processFilters);
				InitializeFilters(filters, process);
				string serializedFilters = JsonConvert.SerializeObject(filters, new JsonSerializerSettings {
					NullValueHandling = NullValueHandling.Ignore,
					ContractResolver = new CamelCasePropertyNamesContractResolver()
				});
				return serializedFilters;
			}

			#endregion

		}

		#endregion

		#region Methods: Protected

		/// <summary>
		/// Executes current flow element.
		/// </summary>
		/// <returns><c>true</c>, if element was successfully executed and conditions for moving to the next step were
		/// satisfied. Otherwise - <c>false</c>.</returns>
		protected override bool InternalExecute(ProcessExecutingContext context) {
			if (IsBatchPrediction) {
				var batchPredictionJob = ClassFactory.Get<IMLBatchPredictionJob>();
				var converter = new FilterEditConverter(UserConnection);
				var filterEditData = converter.Convert(Owner, PredictionFilterData);
				batchPredictionJob.ProcessModel(UserConnection, MLModelId, filterEditData);
			} else {
				var constructorArgument = new ConstructorArgument("userConnection", UserConnection);
				var predictor = ClassFactory.Get<MLEntityPredictor>(constructorArgument);
				predictor.UseAdminRights = GlobalAppSettings.FeatureUseAdminRightsInEmbeddedLogic;
				predictor.PredictEntityValueAndSaveResult(MLModelId, RecordId);
			}
			return true;
		}

		#endregion

	}

	#endregion

}

