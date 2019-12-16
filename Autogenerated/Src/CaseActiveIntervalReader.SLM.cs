namespace Terrasoft.Configuration
{
	using System;
	using System.Linq;
	using System.Collections.Generic;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities;


	#region Class : CaseActiveIntervalReader

	/// <summary>
	/// Get collection of Active status dates.
	/// </summary>
	public class CaseActiveIntervalReader
	{
		#region Class : CaseData

		/// <summary>
		/// Nested class-container for specific strategy data.
		/// </summary>
		private class CaseData
		{
			public Guid CaseId {
				get;
				set;
			}
			public Boolean SolutionOverdue {
				get;
				set;
			}
		}

		#endregion

		#region Properties : Protected

		/// <summary>
		/// Gets the user connection.
		/// </summary>
		/// <value>
		/// The user connection.
		/// </value>
		protected UserConnection UserConnection {
			get;
			private set;
		}

		#endregion

		#region Fields : Private

		/// <summary>
		/// Specific case data.
		/// </summary>
		private readonly CaseData _caseData;

		#endregion

		#region Constructors : Public

		/// <summary>
		/// Initializes a new instance of the <see cref="CaseActiveIntervalReader"/> class.
		/// </summary>
		/// <param name="userConnection">User connection.</param>
		/// <param name="arguments">The arguments.</param>
		public CaseActiveIntervalReader(UserConnection userConnection, Dictionary<string, object> arguments) {
			UserConnection = userConnection;
			_caseData = arguments.ToObject<CaseData>();
		}

		#endregion

		#region Methods: Private

		/// <summary>
		/// Check uniqueness of case lifecycle status.
		/// </summary>
		/// <param name="source">Caselifecycle collection.</param>
		/// <param name="statusColumnName">Status column name.</param>
		/// <returns>Uniqueness of case lifecycle collection by status.</returns>
		private bool CheckDistinctStatus(EntityCollection source, string statusColumnName) {
			Guid firstElement = source[0].GetTypedColumnValue<Guid>(statusColumnName);
			bool isDistinct = source.All(element =>
					element.GetTypedColumnValue<Guid>(statusColumnName) == firstElement);
			return isDistinct;
		}

		#endregion

		#region Methods : Public

		/// <summary>
		/// Returns time interval collection from CaseLifecycle.
		/// </summary>
		/// <returns>Time interval collection.</returns>
		public virtual IEnumerable<DateTimeInterval> GetActiveIntervals() {
			List<DateTimeInterval> result = new List<DateTimeInterval>();
			if (_caseData.SolutionOverdue) {
				return result;
			}
			var esq = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "CaseLifecycle");
			string startDateColumnName = esq.AddColumn("StartDate").Name;
			string endDateColumnName = esq.AddColumn("EndDate").Name;
			string statusColumnName = esq.AddColumn("Status.Id").Name;

			esq.Filters.Add(esq.CreateFilterWithParameters(FilterComparisonType.NotEqual, "[CaseStatus:Id:Status].IsFinal", true));
			esq.Filters.Add(esq.CreateFilterWithParameters(FilterComparisonType.NotEqual, "[CaseStatus:Id:Status].IsResolved", true));
			esq.Filters.Add(esq.CreateFilterWithParameters(FilterComparisonType.NotEqual, "[CaseStatus:Id:Status].IsPaused", true));
			esq.Filters.Add(esq.CreateFilterWithParameters(FilterComparisonType.Equal, "Case", _caseData.CaseId));
			EntityCollection entityCollection = esq.GetEntityCollection(UserConnection);
			if (entityCollection.Any()) {
				bool isDistinct = CheckDistinctStatus(entityCollection, statusColumnName);
				if (!isDistinct) {
					foreach (Entity interval in entityCollection) {
						DateTimeInterval caseTimeInterval = new DateTimeInterval();
						caseTimeInterval.Start = interval.GetTypedColumnValue<DateTime>(startDateColumnName);
						var endDate = interval.GetTypedColumnValue<DateTime>(endDateColumnName);
						caseTimeInterval.End = endDate == DateTime.MinValue ?
							UserConnection.CurrentUser.GetCurrentDateTime() :
							endDate;
						result.Add(caseTimeInterval);
					}
				}
			}
			return result;
		}

		#endregion
	}

	#endregion
}
