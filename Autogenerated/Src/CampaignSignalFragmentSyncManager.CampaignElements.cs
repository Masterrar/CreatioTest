namespace Terrasoft.Configuration
{
	using System;
	using Terrasoft.Core;
	using Terrasoft.Core.DB;
	using CoreCampaignConsts = Core.Campaign.CampaignConstants;

	#region Class: CampaignSignalFragmentSyncManager

	/// <summary>
	/// Describes synchronizer that is worked with campaign participants
	/// for which InitialCampaignItemId is campaign signal element Id.
	/// </summary>
	public sealed class CampaignSignalFragmentSyncManager : CampaignBaseFragmentSyncManager
	{

		#region Constructors: Public

		public CampaignSignalFragmentSyncManager(Guid campaignId, Guid campaignItemId)
			: base(campaignId, campaignItemId) {
		}

		#endregion

		#region Methods: Private

		private int MoveParticipants(UserConnection userConnection) {
			var query = GetMoveParticipantsQuery(userConnection);
			return query.Execute();
		}

		private void DeleteSynchronizedContacts(UserConnection userConnection) {
			var delete = GetDeleteSynchronizedQuery(userConnection);
			delete.Execute();
		}

		private void DeleteSynchronizedRelations(UserConnection userConnection) {
			var delete = GetDeleteSynchronizedRelationsQuery(userConnection);
			delete.Execute();
		}

		private Select GetNewParticipantToRecipientRelationsToMoveSelect() {
			var select = new Select(ParticipantsToSyncSelect);
			select.Columns.Clear();
			select
				.Column("cpetop", "MandrillRecipientUId")
				.Column("cp", "Id").As("CampaignParticipantId")
				.Column(Column.Const(0)).As("WasUsed")
				.And(CampaignParticipantOpTableName, "StepCompleted").IsEqual(Column.Const(true))
				.InnerJoin(CampaignParticipantEmailTargetOpTableName).As("cpetop")
					.On(CampaignParticipantOpTableName, "Id").IsEqual("cpetop", "CampaignParticipantId")
				.InnerJoin(CampaignParticipantTableName).As("cp")
					.On("cp", "ContactId").IsEqual(CampaignParticipantOpTableName, "ContactId")
					.And("cp", "StatusId")
						.IsEqual(Column.Parameter(CoreCampaignConsts.CampaignParticipantParticipatingStatusId))
				.InnerJoin(MandrillRecipientTableName).As("mr")
					.On("mr", "UId").IsEqual("cpetop", "MandrillRecipientUId")
				.InnerJoin(BulkEmailTableName).As("be")
					.On("be", "RId").IsEqual("mr", "BulkEmailRId")
				.InnerJoin(CampaignItemTableName).As("ci")
					.On("ci", "Id").IsEqual("cp", "CampaignItemId")
					.And("ci", "RecordId").IsEqual("be", "Id");
			select.SpecifyNoLockHints();
			return select;
		}

		private Select GetUsedNewParticipantToRecipientRelationsToMoveSelect() {
			var select = new Select(ParticipantsToSyncSelect);
			select.Columns.Clear();
			select
				.Column("cpetop", "MandrillRecipientUId")
				.Column("cp", "Id").As("CampaignParticipantId")
				.Column(Column.Const(1)).As("WasUsed")
				.And().Not().Exists(new Select(ParticipantsToSyncSelect.UserConnection)
					.Column(Column.Const(1))
					.From(CampaignParticipantEmailTargetTableName, "cpet")
					.Where("cpet", "MandrillRecipientUId").IsEqual("cpetop", "MandrillRecipientUId"))
				.InnerJoin(CampaignParticipantEmailTargetOpTableName).As("cpetop")
					.On(CampaignParticipantOpTableName, "Id").IsEqual("cpetop", "CampaignParticipantId")
				.InnerJoin(CampaignParticipantTableName).As("cp")
					.On("cp", "ContactId").IsEqual(CampaignParticipantOpTableName, "ContactId")
				.And("cp", "StatusId")
					.In(Column.Parameters(new[] {
						CoreCampaignConsts.CampaignParticipantParticipatingStatusId,
						CoreCampaignConsts.CampaignParticipantInProgressStatusId
					}));
			select.SpecifyNoLockHints();
			return select;
		}

		#endregion

		#region Methods: Protected

		/// <summary>
		/// Returns select of operational relations that have to be moved into the
		/// <see cref="CmpgnPrtcpntEmailTarget"/> table.
		/// </summary>
		/// <returns>Select query.</returns>
		protected override Select GetOperationalRecipientRelationsToMoveSelect() =>
			GetNewParticipantToRecipientRelationsToMoveSelect();

		/// <summary>
		/// Returns select of operational relations that have to be moved into the
		/// <see cref="CmpgnPrtcpntEmailTarget"/> table with WasUsed flag.
		/// </summary>
		/// <returns>Select query.</returns>
		protected override Select GetUsedOperationalRecipientRelationsToMoveSelect() =>
			GetUsedNewParticipantToRecipientRelationsToMoveSelect();

		/// <summary>
		/// Adds new campaign participants to campaign participant table and actualizes relations.
		/// Then removes operation campaign participants in transaction.
		/// </summary>
		/// <param name="userConnection">Instance of <see cref="UserConnection"/>.</param>
		/// <returns>Count of synchronized participants.</returns>
		protected override int InternalSynchronize(UserConnection userConnection) {
			var addedParticipantsCount = 0;
			using (var dbExecutor = userConnection.EnsureDBConnection()) {
				dbExecutor.StartTransaction();
				try {
					addedParticipantsCount = MoveParticipants(userConnection);
					SyncParticipantRelations(userConnection);
					DeleteSynchronizedRelations(userConnection);
					DeleteSynchronizedContacts(userConnection);
					dbExecutor.CommitTransaction();
				} catch (Exception) {
					dbExecutor.RollbackTransaction();
					throw;
				}
			}
			return addedParticipantsCount;
		}

		#endregion

	}

	#endregion

}

