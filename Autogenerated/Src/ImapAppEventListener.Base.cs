namespace Terrasoft.Configuration
{
	using IntegrationApi.Email;
	using IntegrationApi.Interfaces;
	using Terrasoft.Core.Factories;
	using Terrasoft.Mail;
	using Terrasoft.Web.Common;

	#region Class: ImapAppEventListener

	public class ImapAppEventListener: IAppEventListener
	{
		#region Methods: Public

		public void OnAppStart(AppEventContext context) {
#if !NETSTANDARD2_0 // TODO CRM-42546
			ClassFactory.Bind<ISyncStrategy, DateBasedSyncStrategy>("DateBasedSyncStrategy");
			ClassFactory.Bind<ISyncStrategy, FlagBasedSinceDateSyncStrategy>("FlagBasedSinceDateSyncStrategy");
			ClassFactory.Bind<ISyncStrategy, UidBasedSyncStrategy>("UidBasedSyncStrategy");
			ClassFactory.Bind<ISyncStrategy, UidBasedSinceSyncStrategy>("UidBasedSinceSyncStrategy");
			ClassFactory.Bind<ISyncStrategy, SentSinceAndDraftsSyncStrategy>("SentSinceAndDraftsSyncStrategy");
#endif
			ClassFactory.Bind<IEmailProvider, EmailProvider>();
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
}
