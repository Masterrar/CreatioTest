namespace Terrasoft.Configuration
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using Terrasoft.Common;
	using Terrasoft.Core.DB;

	#region Class: EmailConditionalTransitionFlowElement

	/// <summary>
	/// Email conditional transition process element.
	/// </summary>
	public class EmailConditionalTransitionFlowElement : ConditionalTransitionFlowElement
	{

		#region Properties: Private

		/// <summary>
		/// Collection of responses without click.
		/// </summary>
		private IEnumerable<Guid> ResponsesWithoutClick {
			get => BpmTrackIds.Any() || Hyperlinks.Any()
				? EmailResponses.Where(x => x != MarketingConsts.BulkEmailResponseClickedId)
				: EmailResponses;
		}

		private bool IsRecurringCampaignFeatureEnabled => UserConnection.GetIsFeatureEnabled("RecurringCampaigns");

		#endregion

		#region Properties: Public

		/// <summary>
		/// Unique identifier of bulk email.
		/// </summary>
		public Guid BulkEmailId { get; set; }

		/// <summary>
		/// Collection of selected email response ids.
		/// </summary>
		public IEnumerable<Guid> EmailResponses { get; set; }

		/// <summary>
		/// Collection of selected hyperlink ids.
		/// </summary>
		public IEnumerable<Guid> Hyperlinks { get; set; }

		/// <summary>
		/// Collection of selected hyperlink track ids.
		/// </summary>
		public IEnumerable<int> BpmTrackIds { get; set; }

		#endregion

		#region Methods: Private

		private void ExtendWithResponses() {
			TransitionQuery.CheckArgumentNull("TransitionQuery");
			Query subSelect;
			Query responseSelect = GetSelectByParticipantResponses();
			Select clicksSelect = GetSelectByParticipantClicks();
			if (responseSelect != null && clicksSelect != null) {
				subSelect = responseSelect.Union(clicksSelect);
			} else if (responseSelect != null) {
				subSelect = responseSelect;
			} else if (clicksSelect != null) {
				subSelect = clicksSelect;
			} else {
				subSelect = null;
			}
			if (subSelect != null) {
				if (IsRecurringCampaignFeatureEnabled) {
					TransitionQuery.And("Id").In(subSelect);
				} else {
					TransitionQuery.And("ContactId").In(subSelect);
				}
			}
		}

		private Select GetSelectByParticipantClicks() {
			if (EmailResponses.Contains(MarketingConsts.BulkEmailResponseClickedId)) {
				var clickedQuerySelect = new Select(UserConnection);
				if (!IsRecurringCampaignFeatureEnabled) {
					clickedQuerySelect.Column("ContactId")
						.From("VwBulkEmailClickedLink").As("becl")
						.Where("ContactId").Not().IsNull();
					if (BpmTrackIds.Any()) {
						clickedQuerySelect.And("beh", "BulkEmailId").IsEqual(Column.Parameter(BulkEmailId))
							.And("beh", "BpmTrackId").In(Column.Parameters(BpmTrackIds));
						clickedQuerySelect.InnerJoin("BulkEmailHyperlink").As("beh")
							.On("beh", "Id").IsEqual("becl", "BulkEmailHyperlinkId");
					} else {
						if (Hyperlinks.Any()) {
							clickedQuerySelect.And("becl", "BulkEmailHyperlinkId").In(Column.Parameters(Hyperlinks));
						}
					}
				} else {
					clickedQuerySelect.Column("cpet2", "CampaignParticipantId")
						.From("MandrillClicks").As("mc")
						.InnerJoin("CmpgnPrtcpntEmailTarget").As("cpet2")
							.On("cpet2", "MandrillRecipientUId").IsEqual("mc", "RecipientUId")
						.InnerJoin("BulkEmail").As("be")
							.On("be", "RId").IsEqual("mc", "BulkEmailRId")
						.Where("cpet2", "WasUsed").IsEqual(Column.Parameter(false))
							.And("be", "Id").IsEqual(Column.Parameter(BulkEmailId));
					if (BpmTrackIds.Any()) {
						clickedQuerySelect.And("beh", "BpmTrackId").In(Column.Parameters(BpmTrackIds));
						clickedQuerySelect.InnerJoin("BulkEmailHyperlink").As("beh")
							.On("beh", "RId").IsEqual("mc", "HyperlinkRId");
					} else {
						if (Hyperlinks.Any()) {
							clickedQuerySelect.And("beh", "Id").In(Column.Parameters(Hyperlinks));
							clickedQuerySelect.InnerJoin("BulkEmailHyperlink").As("beh")
								.On("beh", "RId").IsEqual("mc", "HyperlinkRId");
						}
					}
				}
				clickedQuerySelect.SpecifyNoLockHints();
				return clickedQuerySelect;
			}
			return null;
		}

		private Query GetSelectByParticipantResponses() {
			IEnumerable<Guid> emailResponses = ResponsesWithoutClick;
			if (BulkEmailId == default(Guid) || !emailResponses.Any()) {
				return null;
			}
			var responseSelect = new Select(UserConnection)
				.Column("bet", "ContactId")
				.From("BulkEmailTarget").As("bet")
				.Where("bet", "BulkEmailId").IsEqual(Column.Parameter(BulkEmailId))
					.And("bet", "BulkEmailResponseId").In(Column.Parameters(emailResponses)) as Select;
			if (IsRecurringCampaignFeatureEnabled) {
				responseSelect.InnerJoin("CmpgnPrtcpntEmailTarget").As("cpet")
					.On("bet", "MandrillId").IsEqual("cpet", "MandrillRecipientUId")
					.And("cpet", "WasUsed").IsEqual(Column.Parameter(false));
				responseSelect.Columns.Clear();
				responseSelect.Column("cpet", "CampaignParticipantId");
			}
			responseSelect.SpecifyNoLockHints();
			return responseSelect;
		}

		#endregion

		#region Methods: Protected

		/// <summary>
		/// Returns query that includes additional logic.
		/// </summary>
		/// <returns>Base <see cref="Update"/> extended with time and filter conditions.</returns>
		protected override void CreateQuery() {
			base.CreateQuery();
			ExtendWithResponses();
		}

		#endregion

	}

	#endregion

}

