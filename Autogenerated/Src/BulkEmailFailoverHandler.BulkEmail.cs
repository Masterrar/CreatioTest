namespace Terrasoft.Configuration
{
	using System;
	using System.Collections.Generic;
	using System.Data;
	using System.Linq;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Scheduler;
	using SysSettingsCore = Terrasoft.Core.Configuration.SysSettings;

	#region Class: BulkEmailFailoverHandler

	/// <summary>
	/// Provides methods to get broken bulk emails and cleanup its status.
	/// </summary>
	public class BulkEmailFailoverHandler : IFailoverHandler
	{

		#region Constants: Private

		private const string UpdateLogPattern = "Id: {0}, StatusId: {1}, SendStartDate: {2}";

		#endregion

		#region Methods: Private

		private Select CreateBulkEmailsSelect(UserConnection userConnection) {
			var select = new Select(userConnection)
				.Column("BulkEmail", "Id")
				.Column("BulkEmail", "CategoryId")
				.Column("BulkEmail", "SendStartDate")
				.Column("BulkEmail", "StatusId")
				.Column("BulkEmail", "LaunchOptionId")
				.From("BulkEmail")
				.LeftOuterJoin("Campaign").On("Campaign", "Id").IsEqual("BulkEmail", "CampaignId")
				.Where("BulkEmail", "StatusId").In(Column.Parameters(MarketingConsts.BulkEmailStatusStartsId,
					MarketingConsts.BulkEmailStatusLaunchedId))
				.And("Campaign", "CampaignSchemaUId").IsNull() as Select;
			select.SpecifyNoLockHints();
			return select;
		}

		#endregion

		#region Methods: Public

		/// <summary>
		/// Gets the broken bulk emails list.
		/// </summary>
		/// <param name="userConnection">The user connection.</param>
		/// <returns>List of <see cref="BulkEmail"/>.</returns>
		public virtual List<BulkEmail> GetBrokenBulkEmails(UserConnection userConnection) {
			var preparingToSendTimeOut = (int)SysSettingsCore.GetValue(userConnection, "PreparingToSendTimeoutPeriod");
			var sendingInProgressTimeOut = (int)SysSettingsCore.GetValue(userConnection, "SendingInProgressTimeoutPeriod");
			Select bulkEmailSelect = CreateBulkEmailsSelect(userConnection);
			DateTime currentDate = DateTime.UtcNow;
			var resultList = new List<BulkEmail>();
			using (DBExecutor dbExecutor = userConnection.EnsureDBConnection()) {
				using (IDataReader dr = bulkEmailSelect.ExecuteReader(dbExecutor)) {
					while (dr.Read()) {
						var sendStartDate = (DateTime)dr["SendStartDate"];
						Guid statusId = userConnection.DBTypeConverter.DBValueToGuid(dr["StatusId"]);
						Guid launchOptionId = userConnection.DBTypeConverter.DBValueToGuid(dr["LaunchOptionId"]);
						int emailTimeout = statusId == MarketingConsts.BulkEmailStatusStartsId
							? preparingToSendTimeOut
							: sendingInProgressTimeOut;
						if (currentDate <= sendStartDate.AddMinutes(emailTimeout)) {
							continue;
						}
						var bulkEmail = new BulkEmail(userConnection) {
							Id = userConnection.DBTypeConverter.DBValueToGuid(dr["Id"]),
							CategoryId = userConnection.DBTypeConverter.DBValueToGuid(dr["CategoryId"]),
							SendStartDate = sendStartDate,
							StatusId = statusId,
							LaunchOptionId = launchOptionId
						};
						resultList.Add(bulkEmail);
					}
				}
			}
			return resultList;
		}

		/// <summary>
		/// Cleans up status of bulk emails.
		/// </summary>
		/// <param name="userConnection">The user connection.</param>
		/// <param name="bulkEmails">The bulk emails list.</param>
		public virtual void CleanUpStatus(UserConnection userConnection, IEnumerable<BulkEmail> bulkEmails) {
			foreach (BulkEmail bulkEmail in bulkEmails) {
				Guid bulkEmailStatusId = bulkEmail.CategoryId == MarketingConsts.MassmailingBulkEmailCategoryId
					? MarketingConsts.BulkEmailStatusStartPlanedId
					: MarketingConsts.BulkEmailStatusActiveId;
				try {
					var update = new Update(userConnection, "BulkEmail")
						.Set("StatusId", Column.Parameter(bulkEmailStatusId))
						.Where("Id").IsEqual(Column.Parameter(bulkEmail.Id))
						.And("StatusId").IsEqual(Column.Parameter(bulkEmail.StatusId)) as Update;
					if (bulkEmail.LaunchOptionId == MarketingConsts.BulkEmailManaulLaunchOptionId) {
						update
							.Set("LaunchOptionId", Column.Parameter(MarketingConsts.BulkEmailScheduledaunchOptionId))
							.Set("StartDate", Column.Parameter(DateTime.UtcNow));
					}
					update.WithHints(new RowLockHint());
					var affectedRecords = update.Execute();
					if (affectedRecords > 0) {
						MailingUtilities.Log.InfoFormat("[EmailFailoverHandler.CleanUpStatus]: Email status updated. " +
							UpdateLogPattern, bulkEmail.Id, bulkEmailStatusId, bulkEmail.SendStartDate);
					}
				} catch (Exception e) {
					MailingUtilities.Log.ErrorFormat("[EmailFailoverHandler.CleanUpStatus]: Unable to set status. " +
						UpdateLogPattern, e, bulkEmail.Id, bulkEmailStatusId, bulkEmail.SendStartDate);
				}
			}
		}

		/// <summary>
		/// Processes the bulk emails to find out and reset broken ones.
		/// <param name="userConnection">The user connection.</param>
		/// <param name="parameters">Job parameters.</param>
		/// </summary>
		public void Execute(UserConnection userConnection, IDictionary<string, object> parameters) {
			IEnumerable<BulkEmail> emails = GetBrokenBulkEmails(userConnection);
			CleanUpStatus(userConnection, emails);
		}

		/// <summary>
		/// Creates job to monitor fails.
		/// <param name="userConnection">The user connection.</param>
		/// </summary>
		public void CreateJob(UserConnection userConnection) {
			SysUserInfo currentUser = userConnection.CurrentUser;
			int periodInMinutes = (int)SysSettingsCore.GetValue(userConnection, "BulkEmailFailoverJobInterval");
			string jobGroupName = "Mailing";
			bool isSystemUser = true;
			var misfirePolicy = AppSchedulerMisfireInstruction.RescheduleNowWithRemainingRepeatCount;
			AppScheduler.ScheduleMinutelyJob<BulkEmailFailoverHandler>(jobGroupName, userConnection.Workspace.Name,
				currentUser.Name, periodInMinutes, null, isSystemUser, misfirePolicy);
		}

		#endregion

	}

	#endregion

}
