namespace Terrasoft.Configuration.Imap
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.ServiceModel;
	using System.ServiceModel.Web;
	using System.ServiceModel.Activation;
	using global::Common.Logging;
	using Terrasoft.Core;
	using Terrasoft.Core.DB;
	using Terrasoft.Mail;
	using Terrasoft.Web.Common;

	#region Class: ImapUtilitiesService

	[ServiceContract]
	[AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Required)]
	public class ImapUtilitiesService : BaseService
	{
		#region Fields: Private

		/// <summary>
		/// <see cref="ILog"/> implementation instance.
		/// </summary>
		private static readonly ILog _log = LogManager.GetLogger("Imap");

		#endregion

		#region Struct: Public

		public struct MailBox {
			public Guid Id;
			public string UserName;
		}
		
		public struct MailFolder {
			public string Id;
			public string Name;
			public string ParentId;
			public string Path;
		}
		
		#endregion

		#region Methods: Private

		private ImapClient GetImapClientByMailboxId(string mailboxId, out string mailboxName) {
			mailboxName = string.Empty;
			var mailbox = new Terrasoft.Configuration.MailboxSyncSettings(UserConnection);
			if(!mailbox.FetchFromDB(new Guid(mailboxId))) {
				return null;
			}
			mailboxName = mailbox.GetTypedColumnValue<string>("UserName");
			var mailServerUId = mailbox.GetTypedColumnValue<Guid>("MailServerId");
			var currentMailServer = new Terrasoft.Configuration.MailServer(UserConnection);
			if(!currentMailServer.FetchFromDB(mailServerUId) || !currentMailServer.GetTypedColumnValue<bool>("AllowEmailDownloading")) {
				return null;
			}
			var imapServerCredentials = new MailCredentials {
				Host = currentMailServer.GetTypedColumnValue<string>("Address"),
				Port = currentMailServer.GetTypedColumnValue<int>("Port"),
				UseSsl = currentMailServer.GetTypedColumnValue<bool>("UseSSL"),
				UserName = mailbox.GetTypedColumnValue<string>("UserName"),
				UserPassword = mailbox.GetTypedColumnValue<string>("UserPassword"),
				StartTls = currentMailServer.GetTypedColumnValue<bool>("IsStartTls"),
				SenderEmailAddress = mailbox.GetTypedColumnValue<string>("SenderEmailAddress"),
			};
			SynchronizationErrorHelper helper = SynchronizationErrorHelper.GetInstance(UserConnection);
			ImapClient imapClient;
			try {
				imapClient = new ImapClient(imapServerCredentials, MailSynchronizer.GetImapErrorMessages(UserConnection), UserConnection, true);
			} catch (Exception ex) {
				helper.ProcessSynchronizationError(imapServerCredentials.SenderEmailAddress, ex, true);
				throw;
			}
			return imapClient;
		}
		
		private ImapClient GetImapClient(string mailServerUId, string mailboxName, string mailboxPassword) {
			var currentMailServer = new Terrasoft.Configuration.MailServer(UserConnection);
			if(!currentMailServer.FetchFromDB(mailServerUId) || !currentMailServer.GetTypedColumnValue<bool>("AllowEmailDownloading")) {
				return null;
			}
			var imapServerCredentials = new MailCredentials{
						Host = currentMailServer.GetTypedColumnValue<string>("Address"),
						Port = currentMailServer.GetTypedColumnValue<int>("Port"),
						UseSsl = currentMailServer.GetTypedColumnValue<bool>("UseSSL"),
						StartTls = currentMailServer.GetTypedColumnValue<bool>("IsStartTls"),
						UserName = mailboxName,
						UserPassword = mailboxPassword
					};
			ImapClient imapClient;
			SynchronizationErrorHelper helper = SynchronizationErrorHelper.GetInstance(UserConnection);
			try {
				imapClient  = new ImapClient(imapServerCredentials, MailSynchronizer.GetImapErrorMessages(UserConnection), UserConnection, true);
			} catch (Exception ex) {
				helper.ProcessSynchronizationError(mailboxName, ex, true);
				throw;
			}
			return imapClient;
		}
		
		#endregion
		
		#region Methods: Protected
		
		/// <summary>
		/// Returns imap folders collection.
		/// </summary>
		/// <param name="mailboxId">Mailbox sync settings Id.</param>
		/// <param name="mailServerId">Mail server Id.</param>
		/// <param name="mailboxName">Mailbox name.</param>
		/// <param name="mailboxPassword">Mailbox password.</param>
		/// <returns>Imap folders collection.</returns>
		protected virtual ImapFolderCollection GetImapFolders(string mailboxId, string mailServerId,
				string mailboxName, string mailboxPassword) {
			try {
				var imapClient = !string.IsNullOrEmpty(mailboxId)
					? GetImapClientByMailboxId(mailboxId, out mailboxName)
					: GetImapClient(mailServerId, mailboxName, mailboxPassword);
				var folders = imapClient.TryGetFoldersCollection();
				if (folders == null) {
					return null;
				}
				return new ImapFolderCollection(folders);
			} catch (Exception e) {
				_log.ErrorFormat("GetImapFolders method error for {0} mailbox.", e, mailboxName);
			}
			return null;
		}

		/// <summary>
		/// Returns <see cref="MailFolder"/> list with root node.
		/// </summary>
		/// <param name="mailboxName">Mailbox name.</param>
		/// <returns>Imap folders collection.</returns>
		/// <remarks>
		/// Root node is virtual folder, which does not exists and can't be selected wor syncronization.
		/// </remarks>
		protected List<MailFolder> GetMailFoldersWithRootNode(string mailboxName) {
			var result = new List<MailFolder>();
			var rootId = Guid.NewGuid().ToString();
			result.Add(new MailFolder() { 
				Id = rootId,
				Name = mailboxName,
				ParentId = string.Empty,
				Path = mailboxName
			});
			return result;
		}

		/// <summary>
		/// Creates <see cref="MailFolder"/> from <see cref="MailBee.ImapMail.Folder"/>.
		/// </summary>
		/// <param name="folder">Imap folder.</param>
		/// <param name="folders">MailFolder list.</param>
		/// <param name="mailboxName">Mailbox name.</param>
		/// <returns>New MailFolder.</returns>
		/// <remarks>
		/// Parent folder id is detected in folder list using folder path.
		/// </remarks>
		protected MailFolder CreateNewMailFolder(ImapFolder folder, List<MailFolder> folders, string mailboxName){
			string parentName = folder.Name;
			if (folder.NestingLevel > 0) {
				string oldValue = folder.Delimiter + folder.ShortName;
				var path = parentName.Split(new string[] { folder.Delimiter }, StringSplitOptions.None);
				parentName = path[path.Length - 2];
			} else {
				parentName = mailboxName;
			}
			var parentItem = folders.Where(item => item.Name == parentName).FirstOrDefault();
			var parentId = parentItem.Id;
			return new MailFolder() {
				Id = Guid.NewGuid().ToString(),
				Name = folder.ShortName, 
				ParentId = parentId,
				Path = folder.RawName
			};
		}

		#endregion
		
		#region Methods: Public

		[OperationContract]
		[WebInvoke(Method = "POST", UriTemplate = "GetMailboxes", ResponseFormat = WebMessageFormat.Json)]
		public List<MailBox> GetMailboxes() {
			var sel = new Select(UserConnection)
				.Column("MailboxSyncSettings", "Id")
				.Column("MailboxSyncSettings", "MailboxName")
				.From("MailboxSyncSettings")
				.Where("SysAdminUnitId").IsEqual(Column.Parameter(UserConnection.CurrentUser.Id))
				.GroupBy("MailboxSyncSettings", "Id").GroupBy("MailboxSyncSettings", "MailboxName") as Select;
				var records = new List<MailBox>();
				using (var dbExecutor = UserConnection.EnsureDBConnection()) {
					using (var reader = sel.ExecuteReader(dbExecutor)) {
						while(reader.Read()) {
							records.Add(new MailBox{ 
								Id = UserConnection.DBTypeConverter.DBValueToGuid(reader[0]),
								UserName = reader.GetString(1) 
							});
						}
						return records;
					}
				}
		}

		[OperationContract]
		[WebInvoke(UriTemplate = "GetMailboxFolders", ResponseFormat = WebMessageFormat.Json,
			BodyStyle = WebMessageBodyStyle.WrappedRequest)]
		public List<MailFolder> GetMailboxFolders(string mailboxId, string mailServerId, string mailboxName,
				string mailboxPassword) {
			var result = GetMailFoldersWithRootNode(mailboxName);
			var folders = GetImapFolders(mailboxId, mailServerId, mailboxName, mailboxPassword);
			if (folders != null) {
				foreach (var folder in folders) {
					var newMailFolder = CreateNewMailFolder(folder, result, mailboxName);
					result.Add(newMailFolder);
				}
			}
			return result;
		}
		
		#endregion
	}

	#endregion

}

