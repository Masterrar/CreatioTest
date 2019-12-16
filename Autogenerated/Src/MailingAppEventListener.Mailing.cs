namespace Terrasoft.Configuration
{
	using Terrasoft.Core;
	using Terrasoft.Web.Common;

	#region Class: ExchangeAppEventListener

	/// <summary>
	/// Represents methods to initialize package.
	/// </summary>
	public class MailingAppEventListener : IAppEventListener
	{

		#region Fields: Private

		private UserConnection _userConnection;

		#endregion

		#region Constructors: Public

		/// <summary>
		/// Default constructor.
		/// </summary>
		public MailingAppEventListener() {
		}

		/// <summary>
		/// Instantiates class with defined user connection.
		/// </summary>
		/// <param name="userConnection"></param>
		public MailingAppEventListener(UserConnection userConnection)
				: this() {
			_userConnection = userConnection;
		}

		#endregion

		#region Methods: Private

		private UserConnection GetUserConnection(AppEventContext context) {
			if (_userConnection == null) {
				var appConection = context.Application["AppConnection"] as AppConnection;
				_userConnection = appConection.SystemUserConnection;
			}
			return _userConnection;
		}

		#endregion

		#region Methods: Public

		/// <summary>
		/// Binds packages <see cref="ClassFactory"/> items.
		/// </summary>
		/// <param name="context">Instance of <see cref="AppEventContext"/>.</param>
		public void OnAppStart(AppEventContext context) {
			var userConnection = GetUserConnection(context);
			MailingHandlersUtilities.EnableActiveProviderHandlers(userConnection);
		}

		/// <summary>
		/// OnAppEnd empty handler.
		/// </summary>
		/// <param name="context">Instance of <see cref="AppEventContext"/>.</param>
		public void OnAppEnd(AppEventContext context) {
			//Do nothing for this package yet.
		}

		/// <summary>
		/// OnSessionStart empty handler.
		/// </summary>
		/// <param name="context">Instance of <see cref="AppEventContext"/>.</param>
		public void OnSessionStart(AppEventContext context) {
			//Do nothing for this package yet.
		}

		/// <summary>
		/// OnSessionEnd empty handler.
		/// </summary>
		/// <param name="context">Instance of <see cref="AppEventContext"/>.</param>
		public void OnSessionEnd(AppEventContext context) {
			//Do nothing for this package yet.
		}

		#endregion

	}

	#endregion

}

