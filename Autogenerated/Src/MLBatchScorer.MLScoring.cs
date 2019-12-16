namespace Terrasoft.Configuration.ML
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using Core;
	using Terrasoft.Core.Factories;
	using Terrasoft.ML.Interfaces;

	#region Class: MLBatchScorer

	/// <summary>
	/// Scores entities using predictive machine learning model.
	/// </summary>
	[DefaultBinding(typeof(IMLBatchPredictor), Name = MLConsts.ScoringProblemType)]
	public class MLBatchScorer : MLBatchNumericPredictor
	{

		#region Constructors: Public

		/// <summary>
		/// Initializes a new instance of the <see cref="MLBatchScorer"/> class.
		/// </summary>
		/// <param name="userConnection">The user connection.</param>
		public MLBatchScorer(UserConnection userConnection) : base(userConnection) {
		}

		#endregion

		#region Methods: Protected

		/// <summary>
		/// Scores value for the specified model.
		/// </summary>
		/// <param name="model">The model.</param>
		/// <param name="dataForPrediction">The data for prediction.</param>
		/// <param name="proxy">The proxy.</param>
		/// <returns>
		/// Numeric value result.
		/// </returns>
		protected override List<double> Predict(MLModelConfig model,
				IList<Dictionary<string, object>> dataForPrediction, IMLServiceProxy proxy) {
			List<ScoringOutput> predictionResults = proxy.Score(model, dataForPrediction, false);
			List<double> scores = predictionResults.Select(output => output.Score).ToList();
			return scores;
		}

		/// <summary>
		/// Formats the result value for saving.
		/// </summary>
		/// <param name="value">The value.</param>
		/// <returns>
		/// Formatted value.
		/// </returns>
		protected override object FormatValueForSaving(double value) {
			return Convert.ToInt32(value * 100);
		}

		#endregion

	}

	#endregion

}

