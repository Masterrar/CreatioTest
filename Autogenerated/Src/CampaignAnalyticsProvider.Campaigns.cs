namespace Terrasoft.Configuration
{
	using System;
	using System.Collections.Generic;
	using System.Data;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Campaign;
	using Terrasoft.Core.DB;

	#region Class: ParticipantsAnalyticsProvider

	/// <summary>
	/// Contains logic for calculates analytics for campaign.
	/// </summary>
	public class CampaignAnalyticsProvider
	{

		#region Constructors: Public

		/// <summary>
		/// Constructor which defines user connection.
		/// </summary>
		/// <param name="userConnection">Instance of <see cref="Terrasoft.Core.UserConnection"/></param>
		public CampaignAnalyticsProvider(UserConnection userConnection) {
			UserConnection = userConnection;
		}

		#endregion

		#region Properties: Private

		private UserConnection UserConnection {
			get; set;
		}

		#endregion

		#region Methods: Private

		private Select GetParticipantsAnalyticsSelect(ParticipantsAnalyticsRequest analyticsRequest) {
			var select = new Select(UserConnection)
				.Column("cp", "CampaignItemId")
				.Column("cp", "StepCompleted")
				.Column("cp", "StatusId")
				.Column(Func.Count("cp", "CampaignItemId")).As("Count")
				.From("CampaignParticipant").As("cp")
				.Where("cp", "CampaignId").IsEqual(Column.Parameter(analyticsRequest.CampaignId))
				.GroupBy("cp", "CampaignItemId")
				.GroupBy("cp", "StatusId")
				.GroupBy("cp", "StepCompleted") as Select;
			select.SpecifyNoLockHints();
			if (analyticsRequest.UseTimeFilters) {
				var filterStartDateCondition = select.AddCondition(select.SourceExpression.Alias, "CreatedOn",
					LogicalOperation.And);
				filterStartDateCondition.IsGreaterOrEqual(Column.Parameter(analyticsRequest.FilterStartDate));
				var filterDueDateCondition = select.AddCondition(select.SourceExpression.Alias, "CreatedOn",
					LogicalOperation.And);
				filterDueDateCondition.IsLessOrEqual(Column.Parameter(analyticsRequest.FilterDueDate));
			}
			return select;
		}

		private void SetParticipantsCountValue(ref Dictionary<Guid, ParticipantsAnalyticsItem> items, Guid itemId,
				Guid statusId, bool isStepCompleted, int count) {
			if (!items.TryGetValue(itemId, out var existingItem)) {
				existingItem = new ParticipantsAnalyticsItem {
					ItemId = itemId
				};
				items[itemId] = existingItem;
			}
			if (statusId == CampaignConstants.CampaignParticipantErrorStatusId) {
				existingItem.ErrorParticipantsCount = count;
			} else if (statusId == CampaignConstants.CampaignParticipantInProgressStatusId) {
				existingItem.ProcessingParticipantsCount = count;
			} else if (statusId == CampaignConstants.CampaignParticipantSuspendedStatusId
					|| statusId == CampaignConstants.CampaignParticipantSuspendingStatusId) {
				existingItem.SuspendedParticipantsCount += count;
			} else if (isStepCompleted) {
				existingItem.CompletedParticipantsCount += count;
			} else {
				existingItem.NonCompletedParticipantsCount += count;
			}
		}

		private IEnumerable<ParticipantsAnalyticsItem> GetParticipantsAnalyticsItems(Select analyticsSelect) {
			var analyticsItems = new Dictionary<Guid, ParticipantsAnalyticsItem>();
			using (DBExecutor dbExecutor = UserConnection.EnsureDBConnection()) {
				analyticsSelect.ExecuteReader((IDataReader reader) => {
					var itemId = reader.GetColumnValue<Guid>("CampaignItemId");
					var statusId = reader.GetColumnValue<Guid>("statusId");
					var isStepCompleted = reader.GetColumnValue<bool>("StepCompleted");
					var count = reader.GetColumnValue<int>("Count");
					SetParticipantsCountValue(ref analyticsItems, itemId, statusId, isStepCompleted, count);
				});
			}
			return analyticsItems.Values;
		}

		/// <summary>
		/// Swaps <see cref="ParticipantsAnalyticsRequest.FilterStartDate"/> and 
		/// <see cref="ParticipantsAnalyticsRequest.FilterDueDate"/>
		/// when first greater than second.
		/// </summary>
		/// <param name="request">Instance of <see cref="ParticipantsAnalyticsRequest"/>.</param>
		private void NormalizeFilterDatesOrder(ref ParticipantsAnalyticsRequest request) {
			if (request.FilterStartDate > request.FilterDueDate) {
				var tmpStartDate = request.FilterStartDate;
				request.FilterStartDate = request.FilterDueDate;
				request.FilterDueDate = tmpStartDate;
			}
		}

		#endregion

		#region Methods: Public

		/// <summary>
		/// Calculates campaign participant analytics by <paramref name="analyticsRequest"/>.
		/// Calculates participants count with completed and non completed flags for each campaign item.
		/// </summary>
		/// <param name="analyticsRequest">Instance of <see cref="ParticipantsAnalyticsRequest"/>.
		/// Contains parameters for calculate analytics.</param>
		/// <returns>Returns <see cref="ParticipantsAnalyticsResponse"/> instance.</returns>
		public ParticipantsAnalyticsResponse GetParticipantsAnalytics(ParticipantsAnalyticsRequest analyticsRequest) {
			var response = new ParticipantsAnalyticsResponse {
				CampaignId = analyticsRequest.CampaignId
			};
			NormalizeFilterDatesOrder(ref analyticsRequest);
			var analyticsSelect = GetParticipantsAnalyticsSelect(analyticsRequest);
			response.AnalyticsItems = GetParticipantsAnalyticsItems(analyticsSelect);
			return response;
		}

		#endregion

	}

	#endregion

}
