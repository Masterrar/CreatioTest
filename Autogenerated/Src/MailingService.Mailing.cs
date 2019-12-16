namespace Terrasoft.Configuration
{
	using System;
	using System.Linq;
	using System.ServiceModel;
	using System.ServiceModel.Web;
	using System.ServiceModel.Activation;
	using System.Text.RegularExpressions;
	using System.Threading;
	using Core;
	using Terrasoft.Common;
	using Terrasoft.Configuration.Mailing;
	using Terrasoft.Web.Common;

	#region Class: MailingService

	[ServiceContract]
	[AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Required)]
	public class MailingService : BaseService
	{

		#region Fileds: Private

		private IMailingProvider _mailingProvider;

		/// <summary>
		/// Regular expresion pattern for splitting email addresses string.
		/// </summary>
		private readonly string _emailSplitRegexPattern = @"[;,\s]\s*";

		#endregion

		#region Constructors: Public

		public MailingService() {
			Init();
			InitProvider();
		}

		public MailingService(UserConnection userConnection) {
			UserConnection = userConnection;
			Init();
			InitProvider();
		}

		public MailingService(UserConnection userConnection, IMailingProvider mailingProvider) {
			UserConnection = userConnection;
			_mailingProvider = mailingProvider;
			Init();
		}

		#endregion

		#region Methods: Private

		private void Init() {
			string userName = UserConnection.CurrentUser.Name;
			Thread.CurrentPrincipal = TerrasoftPrincipal.Create(userName);
		}

		private IMailingProviderConfigFactory CreateConfigFactory(string factoryClassName) {
			if (string.IsNullOrEmpty(factoryClassName)) {
				return null;
			}
			Type factoryType = Type.GetType(factoryClassName);
			if (factoryType == null) {
				return null;
			}
			return Activator.CreateInstance(factoryType) as IMailingProviderConfigFactory;
		}

		private SysMailingProvider GetProvider(Guid providerId) {
			SysMailingProvider provider = new SysMailingProvider(UserConnection);
			if (!provider.FetchFromDB(providerId)) {
				return null;
			}
			return provider;
		}

		private IMailingProvider CreateProviderInstance(Type providerType,
				IMailingProviderConfigFactory configFactory) {
			IMailingProvider mailingProvider = null;
			var configurableConstructor = providerType.GetConstructor(new Type[] {
				typeof(UserConnection),
				typeof(IMailingProviderConfigFactory)
			});
			if (configurableConstructor != null) {
				mailingProvider = Activator.CreateInstance(providerType, UserConnection, configFactory) as IMailingProvider;
			} else {
				var simpleConstructor = providerType.GetConstructor(new Type[] {typeof(UserConnection)});
				if (simpleConstructor != null) {
					mailingProvider = Activator.CreateInstance(providerType, UserConnection) as IMailingProvider;
				} else {
					mailingProvider = Activator.CreateInstance(providerType) as IMailingProvider;
					mailingProvider.UserConnection = UserConnection;
				}
			}
			return mailingProvider;
		}

		private void InitProvider() {
			Guid _providerId = MailingUtilities.GetActiveProviderId(UserConnection);
			SysMailingProvider provider = GetProvider(_providerId);
			if (provider == null) {
				string msg = string.Format("Could not load provider data from DB. Provider UId: {0}", _providerId);
				throw new Exception(msg);
			}
			Type providerType = Type.GetType(provider.ClassName);
			if (providerType != null) {
				IMailingProviderConfigFactory configFactory = CreateConfigFactory(provider.ConfigFactoryClassName);
				_mailingProvider = CreateProviderInstance(providerType, configFactory);
				var configurableProvider = _mailingProvider as IConfigurableMailingProvider;
				if (configurableProvider != null) {
					configurableProvider.Configure();
				}
			} else {
				string msg = string.Format("Could not initiate provider instance. Provider UId: {0}", _providerId);
				throw new Exception(msg);
			}

		}

		private SendTestMessageData CreateSendTestMessageData(SendTestMessageRequest requestData) {
			return new SendTestMessageData {
				BulkEmailId = requestData.BulkEmailId,
				ContactId = requestData.ContactId,
				EmailRecipients = requestData.EmailRecipients,
				ReplicaMasks = requestData.ReplicaMasks
			};
		}

		private SendTestMessageResponse CreateSendTestMessageResponse(bool success, int replicasCount, 
				int sentReplicasCount, string message = null) {
			return new SendTestMessageResponse {
				Success = success,
				ReplicasCount = replicasCount,
				SentReplicasCount = sentReplicasCount,
				Message = message
			};
		}

		#endregion

		#region Methods: Public

		/// <summary>
		/// Breaks process of sending.
		/// </summary>
		/// <param name="messageId">Unique identifier of the message.</param>
		/// <returns>Status of bulk email.</returns>
		[OperationContract]
		[WebInvoke(Method = "POST", UriTemplate = "BreakMailing", BodyStyle = WebMessageBodyStyle.Wrapped,
			RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
		public MailingResponse BreakMailing(Guid messageId) {
			return _mailingProvider.BreakMailing(messageId);
		}

		/// <summary>
		/// Starts sending of the message.
		/// </summary>
		/// <param name="messageId">Unique identifier of the message.</param>
		/// <param name="isDelayedStart">Deelay sending.</param>
		/// <returns>Status of message.</returns>
		[OperationContract]
		[WebInvoke(Method = "POST", UriTemplate = "SendMessage", BodyStyle = WebMessageBodyStyle.Wrapped,
			RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
		public MailingResponse SendMessage(Guid messageId, bool isDelayedStart = false, string applicationUrl = "") {
			return _mailingProvider.SendMessage(messageId, isDelayedStart, applicationUrl);
		}

		/// <summary>
		/// Starts sending the message with the mailing session identifier.
		/// </summary>
		/// <param name="messageId">Unique identifier of the message.</param>
		/// <param name="sessionId">Trigger mailing session identifier.</param>
		/// <param name="isDelayedStart">Deelay sending.</param>
		/// <returns>Status of message.</returns>
		[OperationContract]
		[WebInvoke(Method = "POST", UriTemplate = "SendSessionedMessage", BodyStyle = WebMessageBodyStyle.Wrapped,
			RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
		public MailingResponse SendSessionedMessage(Guid messageId, Guid sessionId, bool isDelayedStart = false, 
				string applicationUrl = "") {
			ISessionedMailingProvider sessionedProvider = _mailingProvider as ISessionedMailingProvider;
			return sessionedProvider.SendMessage(messageId, sessionId, isDelayedStart, applicationUrl);
		}

		/// <summary>
		/// Starts sending of the message.
		/// </summary>
		/// <param name="messageInfo">Object that holds information about message.</param>
		/// <returns>Status of message.</returns>
		public MailingResponse SendMessage(IMessageInfo messageInfo) {
			return _mailingProvider.SendMessage(messageInfo);
		}

		/// <summary>
		/// Sends test email.
		/// </summary>
		/// <param name="messageId">Unique identifier of the message.</param>
		/// <param name="contactId">Unique identifier of the contact from audience.</param>
		/// <param name="emailRecipient">Email address of the recipient.</param>
		/// <returns>Result of successful sending.</returns>
		[OperationContract]
		[WebInvoke(Method = "POST", UriTemplate = "SendTestMessage", BodyStyle = WebMessageBodyStyle.Wrapped,
			RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
		public bool SendTestMessage(Guid messageId, Guid contactId, string emailRecipient) {
			var emailRecipients = emailRecipient == null
				? Enumerable.Empty<string>()
				: Regex.Split(emailRecipient, _emailSplitRegexPattern)
					.Where(x => x.IsNotNullOrWhiteSpace())
					.Select(x => x.Trim());
			return emailRecipients.AsParallel()
				.All(x => _mailingProvider.SendTestMessage(messageId, contactId, x));
		}

		/// <summary>
		/// Sends a test email that may contain dynamic content.
		/// </summary>
		/// <param name="data">Object with data for test message sending.</param>
		/// <returns>Object with information about completion of test message sending.</returns>
		[OperationContract]
		[WebInvoke(Method = "POST", UriTemplate = "SendDCTestMessage", BodyStyle = WebMessageBodyStyle.WrappedRequest,
			RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
		public SendTestMessageResponse SendDCTestMessage(SendTestMessageRequest data) {
			SendTestMessageResponse response;
			if (_mailingProvider is ITestMessageProvider testMessageProvider) {
				SendTestMessageData sendTestMessageData = CreateSendTestMessageData(data);
				SendTestMessageResult result = testMessageProvider.SendDCTestMessage(sendTestMessageData);
				int sentReplicasCount = result.SentReplicaMasks?.Length ?? 0;
				int failedReplicasCount = result.FailedReplicaMasks?.Length ?? 0;
				response = CreateSendTestMessageResponse(result.Success, sentReplicasCount + failedReplicasCount,
					sentReplicasCount);
			} else {
				bool result = SendTestMessage(data.BulkEmailId, data.ContactId, data.EmailRecipients);
				string message = result
					? new LocalizableString(UserConnection.Workspace.ResourceStorage,
						"MailingService", "LocalizableStrings.TestMessageProviderErrorMessage.Value")
					: null;
				response = CreateSendTestMessageResponse(result, 0, 0, message);
			}
			return response;
		}

		/// <summary>
		/// Validates message.
		/// </summary>
		/// <param name="messageId">Unique identifier of the message.</param>
		/// <returns>Validation result.</returns>
		[OperationContract]
		[WebInvoke(Method = "POST", UriTemplate = "ValidateMessage", BodyStyle = WebMessageBodyStyle.Wrapped,
			RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
		public ConfigurationServiceResponse ValidateMessage(Guid messageId) {
			return _mailingProvider.ValidateMessage(messageId);
		}

		/// <summary>
		/// Validates messages.
		/// </summary>
		/// <param name="messageIds">Unique identifiers of the message.</param>
		/// <returns>Validation result.</returns>
		[OperationContract]
		[WebInvoke(Method = "POST", UriTemplate = "ValidateMessages", BodyStyle = WebMessageBodyStyle.Wrapped,
			RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
		public ConfigurationServiceResponse ValidateMessages(Guid[] messageIds) {
			return _mailingProvider.ValidateMessages(messageIds);
		}

		/// <summary>
		/// Validates messages.
		/// </summary>
		/// <param name="messageIds">Unique identifiers of the message.</param>
		/// <returns>Validation result.</returns>
		[OperationContract]
		[WebInvoke(Method = "POST", UriTemplate = "ValidateDraftStatus", BodyStyle = WebMessageBodyStyle.Wrapped,
			RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
		public ConfigurationServiceResponse ValidateDraftStatus(Guid[] messageIds) {
			return _mailingProvider.ValidateDraftStatus(messageIds);
		}

		/// <summary>
		/// Ping provider's service.
		/// </summary>
		/// <returns>Result of ping.</returns>
		[OperationContract]
		[WebInvoke(Method = "POST", UriTemplate = "PingProvider", BodyStyle = WebMessageBodyStyle.Wrapped,
			RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
		public bool PingProvider() {
			return _mailingProvider.PingProvider();
		}

		#endregion

	}

	#endregion

}

