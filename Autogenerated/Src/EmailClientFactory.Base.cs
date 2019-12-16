namespace Terrasoft.Mail.Sender {
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Factories;

	#region Class: EmailClientFactory

	/// <summary>
	/// Email client factory implementation.
	/// </summary>
	[DefaultBinding(typeof(IEmailClientFactory))]
	public class EmailClientFactory : IEmailClientFactory {

		#region Fileds: Private

		protected readonly UserConnection UserConnection;

		#endregion

		#region Constructors: Public

		/// <summary>############## ##### ######### ###### <see cref="EmailClientFactory"/>.</summary>
		/// <param name="userConnection">######### ################# ###########.</param>
		public EmailClientFactory(UserConnection userConnection) {
			UserConnection = userConnection;
		}

		#endregion

		#region Methdos: Protected

		/// <summary>Returns certain <see cref="IEmailClient"/> class instance.</summary>
		/// <returns>Certain <see cref="IEmailClient"/> class instance.</returns>
		protected IEmailClient GetCertainEmailClient() {
			if (UserConnection.GetIsFeatureEnabled("EmailIntegrationV2")) {
				return ClassFactory.Get<IEmailClient>(new ConstructorArgument("userConnection", UserConnection));
			}
			return null;
		}

		/// <summary>Returns certain <see cref="IEmailClient"/> class instance.</summary>
 	 	/// <param name="credentials">An instance of the user credentials.</param>
 	 	/// <returns>Certain <see cref="IEmailClient"/> class instance.</returns>
 	 	protected IEmailClient GetCertainEmailClient(Credentials credentials) {
			if (UserConnection.GetIsFeatureEnabled("EmailIntegrationV2")) {
				return ClassFactory.Get<IEmailClient>(
					new ConstructorArgument("userConnection", UserConnection),
					new ConstructorArgument("credentials", credentials)
				);
			}
			return null;
		}
		#endregion

		#region Methdos: Public

		/// <summary>
		/// ########## ###### ######### #######, ########### ######### <see cref="IEmailClient"/>
		/// ## ########## ######### ###### ###########.</summary>
		/// <param name="senderEmailAddress">######## ##### ###########.</param>
		/// <returns>######### ######### <see cref="IEmailClient"/>.</returns>
		public virtual IEmailClient CreateEmailClient(string senderEmailAddress) {
			IEmailClient emailClient = GetCertainEmailClient();
			if (emailClient != null) {
				return emailClient;
			}
			emailClient = new SmtpClient(UserConnection);
			return emailClient;
		}

		/// <summary>
		/// Returns email client type for specified email.</summary>
		/// <param name="senderEmailAddress">Sender email.</param>
		/// <returns><see cref="IEmailClient"/> instance.</returns>
		/// <param name="ignoreRights">Flag that indicates whether to ignore rights.</param>
		public virtual IEmailClient CreateEmailClient(string senderEmailAddress, bool ignoreRights) {
			IEmailClient emailClient = GetCertainEmailClient();
			if (emailClient != null) {
				return emailClient;
			}
			emailClient = new SmtpClient(UserConnection);
			return emailClient;
		}

		/// <summary>
		/// ########## ###### ######### #######, ########### ######### <see cref="IEmailClient"/>
		/// ## ######### ########## ###########.</summary>
		/// <param name="credentials">######### ###########.</param>
		/// <returns>######### ######### <see cref="IEmailClient"/>.</returns>
		public virtual IEmailClient CreateEmailClient(Credentials credentials) {
			IEmailClient emailClient = GetCertainEmailClient(credentials);
			if (emailClient != null) {
				return emailClient;
			}
			emailClient = new SmtpClient(UserConnection, credentials);
			return emailClient;
		}

		#endregion

	}

	#endregion

}
