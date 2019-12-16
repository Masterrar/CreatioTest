namespace Terrasoft.Configuration.FileImport
{
	using System;

	public interface IColumnValuesDataProvider
	{
		/// <summary>
		/// Save processed valued in storage.
		/// </summary>
		/// <param name="sessionId"></param>
		/// <param name="dataValueTypeUId"></param>
		/// <param name="serializedValues"></param>
		void SaveProcessedValues(Guid sessionId, Guid dataValueTypeUId, string serializedValues);

		/// <summary>
		/// Save values to process in storage.
		/// </summary>
		/// <param name="sessionId"></param>
		/// <param name="dataValueTypeUId"></param>
		/// <param name="serializedValues"></param>
		void SaveValuesToProcess(Guid sessionId, Guid dataValueTypeUId, string serializedValues);

		/// <summary>
		/// Returns values to process from storage.
		/// </summary>
		/// <param name="sessionId"></param>
		/// <param name="dataValueTypeUId"></param>
		/// <returns></returns>
		string GetValuesToProcess(Guid sessionId, Guid dataValueTypeUId);

		/// <summary>
		/// Returns processed values from storage.
		/// </summary>
		/// <param name="sessionId"></param>
		/// <param name="dataValueTypeUId"></param>
		/// <returns></returns>
		string GetProcessedValues(Guid sessionId, Guid dataValueTypeUId);

	}
}

