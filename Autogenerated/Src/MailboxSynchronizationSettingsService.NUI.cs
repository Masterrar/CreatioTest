namespace Terrasoft.Configuration.TestService
{
	using System;
	using System.Collections.Generic;
	using System.Runtime.Serialization;
	using System.ServiceModel;
	using System.ServiceModel.Activation;
	using System.ServiceModel.Web;
	using Terrasoft.Common;
	using Terrasoft.Mail;
	using Terrasoft.Web.Common;

	[ServiceContract]
	[AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Required)]
	public class MailboxSynchronizationSettingsService : BaseService
	{

		private IResourceStorage GetResourceStorage() {
			return UserConnection.ResourceStorage;
		}

		public LocalizableString CanNotSendTestMessageCaption {
			get {
				return new LocalizableString(GetResourceStorage(), "MailboxSynchronizationSettingsService",
					"LocalizableStrings.CanNotSendTestMessageCaption.Value").ToString();
			}
		}

		public LocalizableString ConnectToImapServerCaption {
			get {
				return new LocalizableString(GetResourceStorage(), "MailboxSynchronizationSettingsService",
					"LocalizableStrings.ConnectToImapServerCaption.Value").ToString();
			}
		}

		[OperationContract]
		[WebInvoke(Method = "POST", UriTemplate = "GetCanExecuteOperation", BodyStyle = WebMessageBodyStyle.Wrapped,
			RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
		public bool GetCanExecuteOperation(string operation) {
			return UserConnection.DBSecurityEngine.GetCanExecuteOperation(operation);
		}

		[OperationContract]
		[WebInvoke(Method = "POST", UriTemplate = "GetMailProviderSettingsById", BodyStyle = WebMessageBodyStyle.Wrapped,
			RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
		public MailProviderSettings GetMailProviderSettingsById(Guid id) {
			var mailProvider = EmailCollectMailboxUtilities.GetMailProviderByUId(UserConnection, id);
			var mailProviderSettings = new MailProviderSettings() {
				AllowEmailDownloading = mailProvider.GetTypedColumnValue<bool>("AllowEmailDownloading"),
				AllowEmailSending = mailProvider.GetTypedColumnValue<bool>("AllowEmailSending")
			};
			return mailProviderSettings;
		}

		[OperationContract]
		[WebInvoke(Method = "POST", UriTemplate = "CreateBPMOnlineFolder", BodyStyle = WebMessageBodyStyle.Wrapped,
			RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
		public bool CreateBPMOnlineFolder(Guid id, string userName, string userPassword) {
			var currentMailServer = new MailServer(UserConnection);
			if (!currentMailServer.FetchFromDB(id)) {
				return false;
			}
			var imapServerCredentials = new MailCredentials{
				Host = currentMailServer.GetTypedColumnValue<string>("Address"),
				Port = currentMailServer.GetTypedColumnValue<int>("Port"),
				UseSsl = currentMailServer.GetTypedColumnValue<bool>("UseSSL"),
				StartTls = currentMailServer.GetTypedColumnValue<bool>("IsStartTls"),
				UserName = userName,
				UserPassword = userPassword
			};
			var imapClient = new ImapClient(imapServerCredentials, MailSynchronizer.GetImapErrorMessages(UserConnection), UserConnection);
			imapClient.EnsureFolderExists("BPMonline");
			var mailboxFolderTypeId = new Guid("99c2351c-f0f8-e111-9dba-00155d051801");
			var emailFolderTypeId = new Guid("b97a5836-1cd0-e111-90c6-00155d054c03");
			var mailboxFolder = new ActivityFolder(UserConnection);
			if(mailboxFolder.FetchFromDB(
					new Dictionary<string, object>{
						{"FolderType", mailboxFolderTypeId},
						{"Name", imapServerCredentials.UserName}})){
							var activityFolderSchema = UserConnection.EntitySchemaManager.GetInstanceByName("ActivityFolder");
							var bpmonlineFolder = activityFolderSchema.CreateEntity(UserConnection);
							var parentColumn = activityFolderSchema.Columns.GetByName("Parent");
							var folderTypeColumn = activityFolderSchema.Columns.GetByName("FolderType");
							bpmonlineFolder.SetDefColumnValues();
							bpmonlineFolder.SetColumnValue("Name", "BPMonline");
							bpmonlineFolder.SetColumnValue(parentColumn.ColumnValueName, mailboxFolder.PrimaryColumnValue);
							bpmonlineFolder.SetColumnValue(folderTypeColumn.ColumnValueName, emailFolderTypeId);
							bpmonlineFolder.Save();
							return true;
			}
			return false;
		}

		[OperationContract]
		[WebInvoke(Method = "POST", UriTemplate = "CreateDeleteSyncJob", BodyStyle = WebMessageBodyStyle.Wrapped,
			RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
		public string CreateDeleteSyncJob(bool create, int interval) {
			try {
				if (create) {
					MailSynchronizer.CreateSyncJob(UserConnection, interval);
				} else {
					MailSynchronizer.RemoveSyncJob(UserConnection);
				}
			} catch(ImapException e) {
				return e.Message;
			}
			return string.Empty;
		}

		[OperationContract]
		[WebInvoke(Method = "POST", UriTemplate = "DoesSyncJobExist", BodyStyle = WebMessageBodyStyle.Wrapped,
			RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
		public bool DoesSyncJobExist() {
			return MailSynchronizer.DoesSyncJobExist(UserConnection);
		}

		[OperationContract]
		[WebInvoke(Method = "POST", UriTemplate = "IsServerValid", BodyStyle = WebMessageBodyStyle.Wrapped,
			RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
		public IsValidAnswer IsServerValid(Guid id, string userName, string userPassword, bool enableSync, 
				bool sendEmail, string senderEmailAddress, bool isAnonymousAuthentication) {
			var currentMailServer = new MailServer(UserConnection);
			var isValidAnswer = new IsValidAnswer() {
				IsValid = true,
				Message = string.Empty
			};
			if (!currentMailServer.FetchFromDB(id)) {
				isValidAnswer.IsValid = false;
				return isValidAnswer;
			}
			if (currentMailServer.AllowEmailDownloading && enableSync) {
				try {
					var imapServerCredentials = new MailCredentials{
						Host = currentMailServer.Address,
						Port = currentMailServer.Port,
						UseSsl = currentMailServer.UseSSL,
						StartTls = currentMailServer.IsStartTls,
						UserName = userName,
						UserPassword = userPassword
					};
					var mapClient = new ImapClient(imapServerCredentials, MailSynchronizer.GetImapErrorMessages(UserConnection), UserConnection, true);
				} catch(ImapException exception) {
					isValidAnswer.IsValid = false;
					isValidAnswer.Message = ConnectToImapServerCaption.ToString() + exception.Message;
				}
			}
			if (currentMailServer.AllowEmailSending && sendEmail) {
				var smtpServerCredentials = new MailCredentials();
				if (isAnonymousAuthentication) {
					smtpServerCredentials.IsAnonymousAuthentication = true;
				} else {
					smtpServerCredentials.UserName = userName;
					smtpServerCredentials.UserPassword = userPassword;
				}
				smtpServerCredentials.Host = currentMailServer.SMTPServerAddress;
				smtpServerCredentials.Port = currentMailServer.SMTPPort;
				smtpServerCredentials.UseSsl = currentMailServer.UseSSLforSending;
				smtpServerCredentials.StartTls = currentMailServer.IsStartTls;
				smtpServerCredentials.Timeout = currentMailServer.SMTPServerTimeout * 1000;
				smtpServerCredentials.SenderEmailAddress = senderEmailAddress;

				var smtpClient = new SmtpClient(UserConnection, smtpServerCredentials);
				try {
					smtpClient.SendTestMessage();
				} catch(SmtpException ex) {
					if(!string.IsNullOrEmpty(isValidAnswer.Message)) {
						isValidAnswer.Message += Environment.NewLine;
					}
					isValidAnswer.IsValid = false;
					isValidAnswer.Message += CanNotSendTestMessageCaption.ToString() + ex.Message;
				}
			}
			return isValidAnswer;
		}

		[DataContract]
		public class MailProviderSettings {
			
			[DataMember]
			public bool AllowEmailDownloading {
				get;
				set;
			}
			
			[DataMember]
			public bool AllowEmailSending {
				get;
				set;
			}
		}

		[DataContract]
		public class IsValidAnswer {
			
			[DataMember]
			public bool IsValid {
				get;
				set;
			}
			
			[DataMember]
			public string Message {
				get;
				set;
			}
		}
	}
}
