namespace Terrasoft.Configuration.ML
{
	using System;
	using System.Collections.Generic;

	#region Interface: IMLBatchPredictor

	/// <summary>
	/// Defines methods for batch prediction.
	/// </summary>
	public interface IMLBatchPredictor
	{

		#region Methods: Public

		/// <summary>
		/// Predicts data by the specified machine learning model.
		/// </summary>
		/// <param name="modelConfig">Machine learning model configuration.</param>
		/// <param name="chunkPredictedHandler">Handler on each chunk predicted event. Invokes with dictionary where
		/// key is entity identifier and value is predicted result for that entity.</param>
		/// <exception cref="AggregateException">When at least one of chunk failed to predict.</exception>
		void Predict(MLModelConfig modelConfig, Action<Dictionary<Guid, object>> chunkPredictedHandler);

		/// <summary>
		/// Saves the predicted data to entities.
		/// </summary>
		/// <param name="modelConfig">Machine learning model configuration.</param>
		/// <param name="predictedData">Dictionary where key is entity identifier and value is predicted
		/// result for that entity.</param>
		void SavePredictedData(MLModelConfig modelConfig, Dictionary<Guid, object> predictedData);

		#endregion

	}

	#endregion

}

