namespace Terrasoft.Configuration
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using Quartz;
	using Quartz.Impl.Matchers;
	using global::Common.Logging;
	using Terrasoft.Core;
	using Terrasoft.Core.Scheduler;
	using Terrasoft.Web.Common;
	using CoreCampaignConsts = Core.Campaign.CampaignConstants;

	#region Class: CampaignQueueMonitoringJobDispatcher

	/// <summary>
	/// Provides methods to handle broken campaign queue monitoring.
	/// </summary>
	public class CampaignQueueMonitoringJobDispatcher : AppEventListenerBase, IJobExecutor
	{

		#region Properties: Public

		/// <summary>
		/// An instance of the <see cref="UserConnection"/> class.
		/// </summary>
		public UserConnection UserConnection { get; set; }

		/// <summary>
		/// Logger.
		/// </summary>
		private ILog _logger;
		public ILog Logger {
			get => _logger ?? (_logger = LogManager.GetLogger(CoreCampaignConsts.CampaignLoggerName));
			set => _logger = value;
		}

		/// <summary>
		/// An instance of <see cref="CampaignQueueMonitoring"/> class.
		/// </summary>
		private CampaignQueueMonitoring _queueMonitoring;
		public CampaignQueueMonitoring QueueMonitoring {
			get => _queueMonitoring ?? (_queueMonitoring = new CampaignQueueMonitoring(UserConnection));
			set => _queueMonitoring = value;
		}

		/// <summary>
		/// An instance of <see cref="CampaignHelper"/> class.
		/// </summary>
		private CampaignHelper _campaignHelper;
		public CampaignHelper CampaignHelper {
			get => _campaignHelper ?? (_campaignHelper = new CampaignHelper(UserConnection));
			set => _campaignHelper = value;
		}

		/// <summary>
		/// An instance of <see cref="IScheduler"/>.
		/// </summary>
		private IScheduler _scheduler;
		public IScheduler Scheduler {
			get => _scheduler ?? AppScheduler.Instance;
			set => _scheduler = value;
		}

		#endregion

		#region Methods: Private

		private UserConnection GetUserConnection(AppEventContext context) {
			if (UserConnection == null) {
				var appConection = context.Application["AppConnection"] as AppConnection;
				UserConnection = appConection.SystemUserConnection;
			}
			return UserConnection;
		}

		private IEnumerable<JobKey> GetMonitoringJobs() {
			var groupMatcher = GroupMatcher<JobKey>.GroupContains(CampaignConsts.CampaignJobGroupName);
			var jobKeys = Scheduler.GetJobKeys(groupMatcher);
			var monitoringJobs = jobKeys.Where(x => x.Name.Contains(GetType().Name));
			return monitoringJobs;
		}

		private void TryUnscheduleJob(TriggerKey triggerKey) {
			try {
				Scheduler.PauseTrigger(triggerKey);
				Scheduler.UnscheduleJob(triggerKey);
			} catch (Exception ex) {
				var message = $"{nameof(CampaignQueueMonitoringJobDispatcher)} failed to unschedule job.";
				Logger.Error(message, ex);
			}
		}

		private void TryScheduleJob() {
			try {
				var userName = UserConnection.CurrentUser.Name;
				var workspaceName = UserConnection.Workspace.Name;
				AppScheduler.ScheduleMinutelyJob<CampaignQueueMonitoringJobDispatcher>(
					CampaignConsts.CampaignJobGroupName, workspaceName, userName, periodInMinutes: 1,
					isSystemUser: true);
			} catch (Exception ex) {
				var className = nameof(CampaignQueueMonitoringJobDispatcher);
				var message = CampaignHelper.GetLczStringValue(className, "CreateJobError");
				Logger.Error(message, ex);
			}
		}

		private void TryProcessBlockedTriggers() {
			try {
				foreach (var jobKey in GetMonitoringJobs()) {
					var jobTriggers = Scheduler.GetTriggersOfJob(jobKey);
					foreach (var trigger in jobTriggers) {
						var state = Scheduler.GetTriggerState(trigger.Key);
						if (state == TriggerState.Blocked) {
							TryUnscheduleJob(trigger.Key);
						}
					}
				}
			} catch (Exception ex) {
				var message = $"{nameof(CampaignQueueMonitoringJobDispatcher)} failed to process blocked triggers.";
				Logger.Error(message, ex);
			}
		}

		#endregion

		#region Methods: Public

		/// <summary>
		/// Schedules minutely job for campaign queue monitoring and tries to reschedule blocked triggers.
		/// </summary>
		/// <param name="context">Instance of <see cref="AppEventContext"/>.</param>
		public override void OnAppStart(AppEventContext context) {
			GetUserConnection(context);
			TryProcessBlockedTriggers();
			TryScheduleJob();
		}

		/// <summary>
		/// Processes campaign queue monitoring.
		/// </summary>
		/// <param name="userConnection">The user connection.</param>
		/// <param name="parameters">Job parameters.</param>
		public void Execute(UserConnection userConnection, IDictionary<string, object> parameters) {
			try {
				UserConnection = userConnection;
				QueueMonitoring.Run();
			} catch (Exception ex) {
				var className = nameof(CampaignQueueMonitoringJobDispatcher);
				var message = CampaignHelper.GetLczStringValue(className, "ExecutionException");
				Logger.Error(message, ex);
				throw;
			}
		}

		#endregion

	}

	#endregion

}
