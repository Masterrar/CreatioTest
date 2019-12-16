namespace Terrasoft.Configuration
{
	using System;
	using System.Collections.Generic;
	using System.Data;
	using Terrasoft.Core.Campaign;
	using Terrasoft.Core.DB;

	#region Class: BulkEmailCampaignElement

	/// <summary>
	/// Executable bulk email element in campaign.
	/// </summary>
	public class BulkEmailCampaignElement : CampaignFlowElement
	{

		#region Constants: Private

		private const string CampaignParticipantEmailTargetTableName = "CmpgnPrtcpntEmailTarget";
		private const string CampaignParticipantEmailTargetOpTableName = "CmpgnPrtcpntEmailTargetOp";

		#endregion

		#region Properties: Protected

		private BulkEmailAudienceDataSource _bulkEmailAudienceDataSource;

		/// <summary>
		/// Bulk email audience data source.
		/// </summary>
		protected BulkEmailAudienceDataSource BulkEmailAudienceDataSource {
			get => _bulkEmailAudienceDataSource ??
					(_bulkEmailAudienceDataSource = new BulkEmailAudienceDataSource(UserConnection, BulkEmailId, 200,
						SessionUId));
			set => _bulkEmailAudienceDataSource = value;
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Unique identifier of bulk email.
		/// </summary>
		public Guid BulkEmailId { get; set; }

		/// <summary>
		/// Unique identifier of mailing session.
		/// </summary>
		public Guid SessionUId { get; internal set; }

		#endregion

		#region Methods: Private

		private bool IsRecurringCampaignEnabled() => UserConnection.GetIsFeatureEnabled("RecurringCampaigns");

		private string GetCampaignParticipantEmailTargetTableName() => SessionId.Equals(default(Guid))
				? CampaignParticipantEmailTargetTableName
				: CampaignParticipantEmailTargetOpTableName;


		private Select GetRecipientSelect(Select audienceSelect) {
			var select = new Select(audienceSelect);
			select.Columns.Clear();
			select
				.Column("Contact", "RId").As("ContactRId")
				.Column("Contact", "Email").As("EmailAddress")
				.InnerJoin("Contact")
					.On("Contact", "Id").IsEqual(CampaignParticipantTable, "ContactId");
			select.SpecifyNoLockHints();
			return select;
		}

		private Select GetMandrillIdtoCampaignParticipantIdRelationSelect(Select recipientsSelect) {
			var select = new Select(recipientsSelect);
			select.Columns.Clear();
			select.Column("mr", "UId")
				.Column(CampaignParticipantTable, "Id")
				.InnerJoin("MandrillRecipient").As("mr")
					.On("mr", "ContactRId").IsEqual("Contact", "RId")
					.And("mr", "SessionUId").IsEqual(Column.Parameter(SessionUId));
			select.SpecifyNoLockHints();
			return select;
		}

		private void IncreaseRecipientCount(Guid bulkEmailId, int count) {
			var update = new Update(UserConnection, "BulkEmail")
				.Set("RecipientCount",
					QueryColumnExpression.Add(Column.SourceColumn("RecipientCount"), Column.Parameter(count)))
				.Where("Id").IsEqual(Column.Parameter(bulkEmailId));
			update.Execute();
		}

		private void SetParticipantsErrorStatus(Select audienceSelect, Exception ex) {
			try {
				SetParticipantsStatus(audienceSelect, CampaignConstants.CampaignParticipantErrorStatusId);
			} catch (Exception e) {
				throw new AggregateException(new List<Exception> { ex, e });
			}
		}

		private void AddRecipientsToCampaignEmailTarget(Select recipientsSelect) {
			var recipientsToParticipantsRelationSelect =
				GetMandrillIdtoCampaignParticipantIdRelationSelect(recipientsSelect);
			var tableName = GetCampaignParticipantEmailTargetTableName();
			var insertSelect = new InsertSelect(UserConnection)
				.Into(tableName)
				.Set("MandrillRecipientUId", "CampaignParticipantId")
				.FromSelect(recipientsToParticipantsRelationSelect);
			insertSelect.Execute();
		}

		private int InternalExecute(Select audienceSelect) {
			var recipientSelect = GetRecipientSelect(audienceSelect);
			var count = BulkEmailAudienceDataSource.Add(recipientSelect, BulkEmailId, SessionUId);
			if (count > 0) {
				IncreaseRecipientCount(BulkEmailId, count);
				if (IsRecurringCampaignEnabled()) {
					AddRecipientsToCampaignEmailTarget(recipientSelect);
				}
				MailingSchedulerUtilities.CreateCampaignBulkEmailJob(UserConnection, BulkEmailId, SessionUId);
				return SetItemCompleted(audienceSelect);
			}
			return 0;
		}

		#endregion

		#region Methods: Protected

		/// <summary>
		/// Executes current flow element for selected audience.
		/// </summary>
		/// <param name="audieceQuery">Query for item audience to be processed.</param>
		protected override int SingleExecute(Query audieceQuery) {
			SessionUId = Guid.NewGuid();
			using (var dbExecutor = UserConnection.EnsureDBConnection()) {
				dbExecutor.StartTransaction(IsolationLevel.ReadCommitted);
				try {
					var result = InternalExecute((Select)audieceQuery);
					dbExecutor.CommitTransaction();
					return result;
				} catch (Exception ex) {
					dbExecutor.RollbackTransaction();
					if (!SessionId.Equals(default(Guid))) {
						SetParticipantsErrorStatus((Select)audieceQuery, ex);
					}
					throw;
				}
			}
		}

		#endregion

	}

	#endregion

}

