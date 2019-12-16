namespace Terrasoft.Configuration.ML
{
	using System.Collections.Generic;
	using Terrasoft.Core;
	using Terrasoft.Core.Factories;

	#region Class: MLBatchRegressor

	/// <summary>
	/// Regression implementetation for ML batch prediction.
	/// </summary>
	/// <seealso cref="Terrasoft.Configuration.ML.MLBatchNumericPredictor" />
	[DefaultBinding(typeof(IMLBatchPredictor), Name = MLConsts.RegressionProblemType)]
	public class MLBatchRegressor : MLBatchNumericPredictor
	{

		#region Constructors: Public

		/// <summary>
		/// Initializes a new instance of the <see cref="MLBatchRegressor"/> class.
		/// </summary>
		/// <param name="userConnection">The user connection.</param>
		public MLBatchRegressor(UserConnection userConnection) : base(userConnection) {
		}

		#endregion

		#region Methods: Protected

		/// <summary>
		/// Predicts numeric value for the specified model.
		/// </summary>
		/// <param name="model">The model.</param>
		/// <param name="dataForPrediction">The data for prediction.</param>
		/// <param name="proxy">The proxy.</param>
		/// <returns>
		/// Numeric value result.
		/// </returns>
		protected override List<double> Predict(MLModelConfig model,
				IList<Dictionary<string, object>> dataForPrediction, IMLServiceProxy proxy) {
			List<double> predictionResults = proxy.Regress(model.ModelInstanceUId, dataForPrediction);
			return predictionResults;
		}

		#endregion

	}

	#endregion

}

