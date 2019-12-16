namespace Terrasoft.Configuration
{
	using System;
	using System.Collections.Generic;
	using System.Data;
	using Terrasoft.Core;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Scheduler;
	using CoreSysSettings = Terrasoft.Core.Configuration.SysSettings;

	#region Class: TriggerEmailFailoverHandler

	/// <summary>
	/// Provides methods to handle broken trigger emails.
	/// </summary>
	public class TriggerEmailFailoverHandler : IFailoverHandler
	{

		#region Methods: Private

		/// <summary>
		/// Retrieves all mailing sessions that are in progress.
		/// </summary>
		/// <param name="userConnection">The user connection.</param>
		/// <returns>Dictionary with sessisonId as a key and bulkEmailId as a value</returns>
		private Dictionary<Guid,Guid> GetTriggerEmailInProgress(UserConnection userConnection) {
			var result = new Dictionary<Guid,Guid>();
			var select = new Select(userConnection)
				.Column("SessionId")
				.Column("BulkEmailId")
				.From("BulkEmailInProgress") as Select;
			select.SpecifyNoLockHints();
			using (DBExecutor dbExecutor = userConnection.EnsureDBConnection()) {
				using (IDataReader reader = select.ExecuteReader(dbExecutor)) {
					while (reader.Read()) {
						Guid sessionId = reader.GetGuid(0);
						Guid bulkEmailId = reader.GetGuid(1);
						result.Add(sessionId, bulkEmailId);
					}
				}
			}
			return result;
		}

		/// <summary>
		/// Retrieves all mailing sessions that are broken.
		/// </summary>
		/// <param name="userConnection">The user connection.</param>
		/// <param name="jobGroupName">The name of job group.</param>
		/// <returns>Dictionary with sessisonId as a key and bulkEmailId as a value</returns>
		private Dictionary<Guid, Guid> GetBrokenTriggerEmailSessions(UserConnection userConnection, string jobGroupName) {
			var brokenSessions = new Dictionary<Guid, Guid>();
			Dictionary<Guid, Guid> emailSessions = GetTriggerEmailInProgress(userConnection);
			foreach (var session in emailSessions) {
				string jobName = MailingSchedulerUtilities.GetTriggerEmailJobName(session.Value, session.Key);
				if (MailingSchedulerUtilities.FindJob(jobName, jobGroupName) != null) {
					continue;
				}
				brokenSessions.Add(session.Key, session.Value);
			}
			return brokenSessions;
		}

		private void HandleBrokenTriggerEmailSessions(UserConnection userConnection) {
			string jobGroupName = MailingSchedulerUtilities.BulkEmailJobGroupName;
			Dictionary<Guid, Guid> brokenSessions = GetBrokenTriggerEmailSessions(userConnection, jobGroupName);
			if (brokenSessions.Count <= 0) {
				return;
			}
			MailingUtilities.Log.InfoFormat("[TriggerEmailFailoverHandler.HandleBrokenTriggerEmailSessions]: " +
				"Found {0} broken sessions.", brokenSessions.Count);
			foreach (var session in brokenSessions) {
				MailingSchedulerUtilities.CreateCampaignBulkEmailJob(userConnection, session.Value, session.Key);
				MailingUtilities.Log.InfoFormat("[TriggerEmailFailoverHandler.HandleBrokenTriggerEmailSessions]: " +
					"Job restored for SessionId: {0} BulkEmailId: {1}", session.Key, session.Value);
			}
		}

		#endregion

		#region Methods: Public

		/// <summary>
		/// Creates job to handle broken trigger emails.
		/// <param name="userConnection">The user connection.</param>
		/// </summary>
		public void CreateJob(UserConnection userConnection) {
			var periodInMinutes = (int)CoreSysSettings.GetValue(userConnection, "TriggerEmailFailoverJobInterval");
			if (periodInMinutes <= 0) {
				return;
			}
			string userName = userConnection.CurrentUser.Name;
			string workspaceName = userConnection.Workspace.Name;
			string jobGroupName = MailingSchedulerUtilities.BulkEmailJobGroupName;
			AppScheduler.ScheduleMinutelyJob<TriggerEmailFailoverHandler>(jobGroupName, workspaceName, userName, 
				periodInMinutes, parameters: null, isSystemUser: true, 
				misfireInstruction: AppSchedulerMisfireInstruction.RescheduleNowWithRemainingRepeatCount);
		}

		/// <summary>
		/// Tries to handle a broken trigger emails.
		/// <param name="userConnection">The user connection.</param>
		/// <param name="parameters">Job parameters.</param>
		/// </summary>
		public void Execute(UserConnection userConnection, IDictionary<string, object> parameters) {
			try {
				HandleBrokenTriggerEmailSessions(userConnection);
			} catch (Exception ex) {
				MailingUtilities.Log.Error("[TriggerEmailFailoverHandler.Execute]: " +
					"Unable to handle broken trigger emails.", ex);
			}
		}

		#endregion

	}

	#endregion

}
