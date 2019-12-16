namespace Terrasoft.Configuration.ForecastV2
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using Terrasoft.Common;

	#region Class: ForecastExtensions

	/// <summary>
	/// Utilities extensions for forecasts.
	/// </summary>
	public static class ForecastExtensions
	{

		#region Methods: Public

		/// <summary>
		/// Gets periods by ids.
		/// If period ids are empty - returns periods for current year by period type.
		/// </summary>
		/// <param name="periodRepository">Periods repository.</param>
		/// <param name="periodIds">Periods identifiers.</param>
		/// <param name="periodTypeId">Period type identifier.</param>
		/// <returns></returns>
		public static IEnumerable<Period> GetForecastPeriods(this IPeriodRepository periodRepository, 
				IEnumerable<Guid> periodIds, Guid periodTypeId) {
			if (periodIds.IsNullOrEmpty()) {
				return periodRepository.GetPeriods(periodTypeId, DateTime.UtcNow.Year);
			}
			return periodRepository.GetPeriods(periodIds); 
		}

		#endregion

	}

	#endregion

}
