namespace Terrasoft.Configuration
{
	using System;
	using System.Linq;
	using Terrasoft.Common;
	using Terrasoft.Configuration.CampaignElements;
	using Terrasoft.Core.Campaign;
	using Terrasoft.Core.DB;

	#region Class: AddCampaignAudienceElement

	/// <summary>
	/// Executable campaign element which add contacts to campaign audience.
	/// </summary>
	public class AddCampaignAudienceElement : BaseCampaignAudienceFlowElement
	{

		#region Constants: Private

		private const string ContactTableName = "Contact";

		#endregion

		#region Proerties: Private

		private bool UseCampaignBatchedQueries => UserConnection.GetIsFeatureEnabled("CampaignBatchedQueries");

		/// <summary>
		/// Size of a single batch to split queries while using CampaignBatchedQueries feature.
		/// </summary>
		private int _campaignElementAudienceQueryBatchSize = int.MinValue;
		private int CampaignElementAudienceQueryBatchSize {
			get {
				if (_campaignElementAudienceQueryBatchSize < 0) {
					var value = Core.Configuration.SysSettings.GetValue(UserConnection,
						"CampaignElementAudienceQueryBatchSize", 500);
					_campaignElementAudienceQueryBatchSize = Math.Max(value, 0);
				}
				return _campaignElementAudienceQueryBatchSize;
			}
		}

		#endregion

		#region Properties: Protected

		/// <summary>
		/// ContactId column name alias in origin select for add audience in campaign.
		/// </summary>
		protected override string SourceSelectContactIdColumnName { get; set; }

		#endregion

		#region Properties: Public

		/// <summary>
		/// Root folder schema name.
		/// </summary>
		public string FolderSchemaName => nameof(ContactFolder);

		/// <summary>
		/// Defines if element can do recurring add from folder.
		/// </summary>
		public bool IsRecurring { get; set; }

		/// <summary>
		/// Number of days before participant will be added next time.
		/// </summary>
		public int RecurringFrequencyInDays { get; set; }

		/// <summary>
		/// Unique identifier of the folder.
		/// </summary>
		public Guid FolderRecordId { get; set; }

		private FolderHelper _folderHelper;

		/// <summary>
		/// An instance of the <see cref="FolderHelper"/>. Is using for Mock purposes.
		/// </summary>
		public FolderHelper FolderHelper {
			get => _folderHelper ?? (_folderHelper = new FolderHelper());
			set => _folderHelper = value;
		}

		#endregion

		#region Methods: Private

		private Select GetCurrentItemRecurringContactIdsSelect(Guid campaignItemId, int recurringFrequency) {
			var selectCurrentContacts = new Select(UserConnection)
				.Distinct()
				.Column("ContactId")
				.From("CampaignParticipant")
				.Where("CampaignItemId").IsEqual(Column.Parameter(campaignItemId))
					.And("CreatedOn").IsGreater(Column.Parameter(DateTime.UtcNow.AddDays(-recurringFrequency)))
				as Select;
			selectCurrentContacts.SpecifyNoLockHints();
			return selectCurrentContacts;
		}

		private void AddSuspendingQueryConditions(Query suspendingQuery, Select currentAddAudienceSelect,
				Guid currentParticipantsStatus, int recurringFrequency) {
			suspendingQuery
				.Where("CampaignId").IsEqual(Column.Parameter(CampaignId))
					.And("StatusId").IsEqual(Column.Parameter(currentParticipantsStatus))
					.And("CreatedOn").IsLess(Column.Parameter(DateTime.UtcNow.AddDays(-recurringFrequency)))
					.And("ContactId").In(currentAddAudienceSelect);
		}

		private void SuspendingParticipantsWithoutBatches(Select currentAddAudienceSelect,
				Guid currentParticipantsStatus, Guid newParticipantsStatus, int recurringFrequency) {
			var updateToSuspendingStatus = new Update(UserConnection, CampaignParticipantTable)
				.Set("StatusId", Column.Parameter(newParticipantsStatus));
			AddSuspendingQueryConditions(updateToSuspendingStatus, currentAddAudienceSelect, currentParticipantsStatus,
				recurringFrequency);
			updateToSuspendingStatus.WithHints(new RowLockHint());
			updateToSuspendingStatus.Execute();
		}

		private void SuspendingParticipantsWithBatches(Select currentAddAudienceSelect, Guid currentParticipantsStatus,
				Guid newParticipantsStatus, int recurringFrequency) {
			var campaignParticipantsSelect = new Select(UserConnection)
				.Column("Id")
				.From(CampaignParticipantTable);
			AddSuspendingQueryConditions(campaignParticipantsSelect, currentAddAudienceSelect,
				currentParticipantsStatus, recurringFrequency);
			campaignParticipantsSelect.SpecifyNoLockHints();
			var campaignParticipantIds = campaignParticipantsSelect
				.ExecuteEnumerable(r => r.GetColumnValue<Guid>("Id")).ToList();
			int participantsCount = campaignParticipantIds.Count;
			int batchSize = CampaignElementAudienceQueryBatchSize;
			int processedCount = 0;
			while (processedCount < participantsCount) {
				var batch = campaignParticipantIds.GetRange(processedCount,
					Math.Min(batchSize, campaignParticipantIds.Count - processedCount));
				var updateToSuspendingStatus = new Update(UserConnection, CampaignParticipantTable)
					.Set("StatusId", Column.Parameter(newParticipantsStatus))
					.Where("Id").In(Column.Parameters(batch)) as Update;
				updateToSuspendingStatus.WithHints(new RowLockHint());
				updateToSuspendingStatus.Execute();
				processedCount += batchSize;
			}
		}

		private void SuspendingParticipants(Select currentAddAudienceSelect, Guid currentParticipantsStatus,
				Guid newParticipantsStatus, int recurringFrequency) {
			if (UseCampaignBatchedQueries) {
				SuspendingParticipantsWithBatches(currentAddAudienceSelect, currentParticipantsStatus,
					newParticipantsStatus, recurringFrequency);
			} else {
				SuspendingParticipantsWithoutBatches(currentAddAudienceSelect, currentParticipantsStatus,
					newParticipantsStatus, recurringFrequency);
			}
		}

		#endregion

		#region Methods: Protected

		/// <summary>
		/// Returns <see cref="Select"/> from ContactFolder with id = <see cref="FolderRecordId"/>
		/// which represents contact ids to add in campaign.
		/// </summary>
		/// <returns>Select of contact ids.</returns>
		protected override Select GetContactsSelect() {
			Select folderSelect = FolderHelper.GetFolderSelectV2(ContactTableName, FolderSchemaName, FolderRecordId,
				UserConnection);
			if (folderSelect != null) {
				SourceSelectContactIdColumnName = folderSelect.SourceExpression.SchemaName == "Contact" ? "Id" : "ContactId";
				return folderSelect;
			}
			string errorMessage = new LocalizableString(UserConnection.Workspace.ResourceStorage,
				"AddCampaignAudienceElement", "LocalizableStrings.DeletedContactFolderMessage.Value");
			throw new CampaignElementBrokenDataException(string.Format(errorMessage, Caption ?? Name));

		}

		/// <summary>
		/// Builds <see cref="Select"/> which represents contact ids of campaign participants
		/// which still exist in campaign.
		/// Add more conditions for Select query when <see cref="IsRecurring"/> is <see cref="true"/>.
		/// </summary>
		/// <returns>Select of contact ids.</returns>
		protected override Select GetExistingAudienceSelect() {
			var select = base.GetExistingAudienceSelect();
			if (RecurringFrequencyInDays > 0 && IsRecurring
				&& UserConnection.GetIsFeatureEnabled("RecurringCampaigns")) {
				select.And("CreatedOn")
					.IsGreaterOrEqual(Column.Parameter(DateTime.UtcNow.AddDays(-RecurringFrequencyInDays)));
			}
			select.SpecifyNoLockHints();
			return select;
		}

		/// <summary>
		/// Suspending duplicated participants in campaign participants.
		/// </summary>
		protected virtual void SuspendingParticipants() {
			var currentAddAudienceSelect = GetCurrentItemRecurringContactIdsSelect(CampaignItemId, 
				RecurringFrequencyInDays);
			SuspendingParticipants(currentAddAudienceSelect,
				CampaignConstants.CampaignParticipantParticipatingStatusId,
				CampaignConstants.CampaignParticipantSuspendedStatusId, RecurringFrequencyInDays);
			SuspendingParticipants(currentAddAudienceSelect,
				CampaignConstants.CampaignParticipantInProgressStatusId,
				CampaignConstants.CampaignParticipantSuspendingStatusId, RecurringFrequencyInDays);
		}

		#endregion

		#region Methods: Protected

		/// <summary>
		/// Executes current flow element for selected audience.
		/// </summary>
		/// <param name="audienceQuery">Query for item audience to be processed.</param>
		/// <returns>Number of processed participants.</returns>
		protected override int SingleExecute(Query audienceQuery) {
			using (DBExecutor dbExecutor = UserConnection.EnsureDBConnection()) {
				dbExecutor.StartTransaction();
				try {
					var processedAmount = AddParticipants(audienceQuery);
					if (processedAmount > 0) {
						if (IsRecurring && UserConnection.GetIsFeatureEnabled("RecurringCampaigns")) {
							SuspendingParticipants();
						}
					}
					dbExecutor.CommitTransaction();
					return processedAmount;
				} catch {
					dbExecutor.RollbackTransaction();
					throw;
				}
			}
		}

		#endregion

	}

	#endregion

}

