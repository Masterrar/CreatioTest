namespace Terrasoft.Configuration.FileImport {
	using Quartz;
	using Quartz.Impl.Triggers;
	using Terrasoft.Core;
	using Terrasoft.Core.Factories;
	using Terrasoft.Web.Common;

	#region  Class: FileImportAppEventListener

	public class FileImportAppEventListener : IAppEventListener {

		#region Constants: Private

		private const string FileImportTriggerName = "RestarFileImportTrigger";
		private const string JobGroupName = "RestartFileImport";

		#endregion

		#region Fields: Private

		private readonly IAppSchedulerWraper _schedulerWraper = ClassFactory.Get<IAppSchedulerWraper>();
		private AppEventContext _appEventContext;
		private UserConnection _userConnection;

		#endregion

		#region Properties: Private

		private UserConnection UserConnection => _userConnection ?? 
		(_userConnection = (_appEventContext?.Application["AppConnection"] as AppConnection)?.SystemUserConnection);

		#endregion

		#region Constructors: Public

		/// <summary>
		/// Default class constructor, executes automatically by bpm'online app on start.
		/// </summary>
		public FileImportAppEventListener() { }

		/// <summary>
		/// Setups instance of <see cref="FileImportAppEventListener"/> with custom user connection.
		/// </summary>
		/// <param name="userConnection">User connection.</param>
		public FileImportAppEventListener(UserConnection userConnection) {
			_userConnection = userConnection;
		}

		#endregion

		#region Methods: Private

		private void RestartUncompletedImport() {
			string className = JobGroupName;
			if (_schedulerWraper.DoesJobExist(className, JobGroupName)) {
				_schedulerWraper.RemoveJob(className, JobGroupName);
			}
			IJobDetail job = _schedulerWraper.CreateClassJob<FileImportBackGroundProcessor>(className, JobGroupName,
							UserConnection, null, true);
			ITrigger trigger = new SimpleTriggerImpl(FileImportTriggerName, JobGroupName);
			_schedulerWraper.Instance.ScheduleJob(job, trigger);
		}

		#endregion

		#region Methods: Public

		public void OnAppEnd(AppEventContext context) { }

		/// <summary>
		/// Start import who not been ended.
		/// </summary>
		/// <param name="context">Application event context.</param>
		public void OnAppStart(AppEventContext context) {
			_appEventContext = context;
			if (!UserConnection.GetIsFeatureEnabled("UsePersistentFileImport")) {
				return;
			}
			RestartUncompletedImport();
		}

		public void OnSessionEnd(AppEventContext context) { }

		public void OnSessionStart(AppEventContext context) { }

		#endregion

	}

	#endregion

}

