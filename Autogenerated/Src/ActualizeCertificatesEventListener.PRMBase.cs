namespace Terrasoft.Configuration
{

	using System;
	using Terrasoft.Core;
	using Terrasoft.Core.Scheduler;
	using Terrasoft.Web.Common;
	using Quartz.Impl.Triggers;
	using Quartz;

	public class ActualizeCertificatesEventListener : AppEventListenerBase
	{
		#region Constants: Private

		private const string JOB = "Job";
		private const string JOB_GROUP = "JobGroup";
		private const string TRIGGER = "Trigger";
		private const string DEF_CRON_TRIGGER = "0 0 4 ? * *";
		private const string CLASS_NAME = "CertificatesActualizationJob";
		private const string SYS_SETTING_CRON_TRIGGER = "ActualizeCertificatesByCronTrigger";

		#endregion

		#region Fields: Private

		private string _cronTigger;
		private UserConnection _userConnection;

		#endregion

		#region Properties: Protected

		protected UserConnection UserConnection {
			get {
				return _userConnection;
			}
			set {
				if(_userConnection == null) {
					_userConnection = value;
				}
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeData(AppEventContext context) {
			SetUserConnection(context);
			SetCronTrigger();
		}

		private void SetUserConnection(AppEventContext context) {
			var appConection = context.Application["AppConnection"] as AppConnection;
			UserConnection = appConection.SystemUserConnection;
		}

		private void SetCronTrigger() {
			_cronTigger = Terrasoft.Core.Configuration.SysSettings.GetValue<string>(UserConnection,
				SYS_SETTING_CRON_TRIGGER, DEF_CRON_TRIGGER);
		}

		private string GetProcessJobName() {
			return String.Concat(CLASS_NAME, JOB);
		}

		private string GetProcessJobGroupName() {
			return String.Concat(CLASS_NAME, JOB_GROUP);
		}

		private string GetProcessTriggerName() {
			return String.Concat(CLASS_NAME, TRIGGER);
		}

		#endregion

		#region Methods : Public

		/// <summary>
		/// Creates and schedules a job for certificates actualization.
		/// </summary>
		/// <param name="context">Execution context.</param>
		public override void OnAppStart(AppEventContext context) {
			InitializeData(context);
			string processJob = GetProcessJobName();
			string processJobGroup = GetProcessJobGroupName();
			string processTrigger = GetProcessTriggerName();
			IJobDetail job = AppScheduler.CreateClassJob(CLASS_NAME, processJobGroup,
				UserConnection.Workspace.Name, UserConnection.CurrentUser.Name);
			ITrigger trigger = new CronTriggerImpl(processTrigger, processJobGroup, _cronTigger);
			if (AppScheduler.DoesJobExist(processJob, processJobGroup)) {
				AppScheduler.RemoveJob(processJob, processJobGroup);
			}
			AppScheduler.Instance.ScheduleJob(job, trigger); 
		}

		#endregion

	}
}



