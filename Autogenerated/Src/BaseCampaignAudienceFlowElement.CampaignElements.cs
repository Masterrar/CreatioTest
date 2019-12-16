namespace Terrasoft.Configuration
{
	using System;
	using Terrasoft.Core.Campaign;
	using Terrasoft.Core.DB;

	#region Class: BaseCampaignAudienceFlowElement

	/// <summary>
	/// Base campaign flow element which contains logic for add contacts to campaign audience.
	/// </summary>
	public abstract class BaseCampaignAudienceFlowElement : CampaignFlowElement
	{

		#region Methods: Private

		private Select GetSelectExceptExistingContacts(Select audienceSelect) {
			Select existingSelect = GetExistingAudienceSelect();
			var schemaName = audienceSelect.SourceExpression.SchemaName;
			if (audienceSelect.HasCondition) {
				var condition = audienceSelect.Condition.CloneMe().WrapBlock();
				audienceSelect.Condition.Clear();
				audienceSelect.Where(condition);
				audienceSelect.And(schemaName, SourceSelectContactIdColumnName).Not().In(existingSelect);
			} else {
				audienceSelect.Where(schemaName, SourceSelectContactIdColumnName).Not().In(existingSelect);
			}
			return audienceSelect;
		}

		private InsertSelect GetQueryForInsertInCampaignParticipants(Query audienceQuery) {
			ExtendSelectColumnsForInsert(audienceQuery as Select);
			InsertSelect audienceInsert = new InsertSelect(UserConnection).Into(CampaignParticipantTable)
				.Set("ContactId", "CampaignId", "CampaignItemId", "StepModifiedOn",
					"StepCompletedOn", "StatusId", "StepCompleted")
				.FromSelect(audienceQuery);
			return audienceInsert;
		}

		private void ExtendSelectColumnsForInsert(Select audienceSelect) {
			audienceSelect.Columns.Clear();
			var schemaName = audienceSelect.SourceExpression.SchemaName;
			audienceSelect.Column(schemaName, SourceSelectContactIdColumnName).As("ContactId");
			audienceSelect.Column(Column.Parameter(CampaignId)).As("CampaignId");
			audienceSelect.Column(Column.Parameter(CampaignItemId)).As("CampaignItemId");
			audienceSelect.Column(Column.Parameter(DateTime.UtcNow)).As("StepModifiedOn");
			audienceSelect.Column(Column.Parameter(ScheduledDate)).As("StepCompletedOn");
			audienceSelect.Column(Column.Parameter(
				CampaignConstants.CampaignParticipantParticipatingStatusId)).As("StatusId");
			audienceSelect.Column(Column.Parameter(true)).As("StepCompleted");
		}

		#endregion

		#region Methods: Protected

		/// <summary>
		/// Returns <see cref="Select"/> which represents contact ids to add in campaign.
		/// </summary>
		/// <returns>Select of contact ids.</returns>
		protected abstract Select GetContactsSelect();

		/// <summary>
		/// Builds <see cref="Select"/> which represents contact ids of campaign participants
		/// which still exist in campaign.
		/// </summary>
		/// <returns>Select of contact ids.</returns>
		protected virtual Select GetExistingAudienceSelect() {
			var select =
				new Select(UserConnection)
					.Column(CampaignParticipantTable, "ContactId")
					.From(CampaignParticipantTable)
					.Where(CampaignParticipantTable, "CampaignId").IsEqual(Column.Parameter(CampaignId))
				as Select;
			select.SpecifyNoLockHints();
			return select;
		}

		/// <summary>
		/// Defines <see cref="AudienceQuery"/> for add new participants in campaign.
		/// </summary>
		/// <returns><see cref="Select"/> query which returns contacts for add in campaign.</returns>
		protected override Query GetAudienceQuery() {
			Select contactsSelect = GetContactsSelect();
			return GetSelectExceptExistingContacts(contactsSelect);
		}

		/// <summary>
		/// Adds new participants from <paramref name="audienceQuery"/> to campaign participants.
		/// </summary>
		/// <param name="audienceQuery">Query for item audience to be processed.</param>
		/// <returns>Number of processed participants.</returns>
		protected virtual int AddParticipants(Query audienceQuery) {
			var audienceInsert = GetQueryForInsertInCampaignParticipants(audienceQuery);
			return audienceInsert.Execute();
		}

		/// <summary>
		/// Executes current flow element for selected audience.
		/// </summary>
		/// <param name="audienceQuery">Query for item audience to be processed.</param>
		/// <returns>Number of processed participants.</returns>
		protected override int SingleExecute(Query audienceQuery) => AddParticipants(audienceQuery);

		#endregion

	}

	#endregion

}

