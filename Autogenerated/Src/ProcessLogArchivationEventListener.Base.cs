namespace Terrasoft.Configuration
{

	using System.Collections.Generic;
	using Terrasoft.Core;
	using Terrasoft.Core.Scheduler;
	using Terrasoft.Web.Common;
	using Quartz;

	#region Class: ProcessLogArchivationEventListener

	public class ProcessLogArchivationEventListener : IAppEventListener
	{

		#region Constants: Private

		private const string ProcessLogArchivingFrequency = "ProcessLogArchivingFrequencyMinutes";
		private const int DefaultFrequency = 5;

		#endregion

		#region Methods: Protected

		protected IJobDetail CreateJob(UserConnection userConnection) {
			return AppScheduler.CreateClassJob<ProcessLogArchivingJob>("ProcessLogArchivingJobGroup",
				userConnection.Workspace.Name, userConnection.CurrentUser.Name, null, true);
		}

		protected ITrigger GetJobTrigger(UserConnection userConnection) {
			int frequency = GetArchivingFrequencySysSetting(userConnection);
			return TriggerBuilder.Create()
				.WithSimpleSchedule(s => s.WithIntervalInMinutes(frequency).RepeatForever())
				.StartNow()
				.Build();
		}

		protected virtual int GetArchivingFrequencySysSetting(UserConnection userConnection) {
			return Terrasoft.Core.Configuration.SysSettings.GetValue(userConnection,
				ProcessLogArchivingFrequency, DefaultFrequency);
		}

		protected virtual UserConnection GetUserConnection(AppEventContext context) {
			var appConnection = context.Application["AppConnection"] as AppConnection;
			return appConnection.SystemUserConnection;
		}

		#endregion

		#region Custom: IAppEventListener members

		public void OnAppStart(AppEventContext context) {
			UserConnection userConnection = GetUserConnection(context);
			IJobDetail job = CreateJob(userConnection);
			if (AppScheduler.DoesJobExist(job.Key.Name, job.Key.Group)) {
				AppScheduler.RemoveJob(job.Key.Name, job.Key.Group);
			}
			AppScheduler.Instance.ScheduleJob(job, GetJobTrigger(userConnection));
		}

		public void OnAppEnd(AppEventContext context) {
		}

		public void OnSessionStart(AppEventContext context) {
		}

		public void OnSessionEnd(AppEventContext context) {
		}

		#endregion

	}

	#endregion

	#region Class: ProcessLogArchivingJob

	public class ProcessLogArchivingJob : IJobExecutor
	{

		#region Methods: Protected

		protected virtual IEntityArchiver GetArchiver(UserConnection userConnection) {
			return new SysProcessLogArchiver(userConnection.EnsureDBConnection());
		}

		#endregion

		#region Custom: IJobExecutor members

		public void Execute(UserConnection userConnection, IDictionary<string, object> parameters) {
			var archiver = GetArchiver(userConnection);
			archiver.Archive();
		}

		#endregion

	}

	#endregion	

}

