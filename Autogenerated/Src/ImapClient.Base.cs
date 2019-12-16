namespace Terrasoft.Mail
{
	using System;
	using System.IO;
	using System.Collections.Generic;
	using System.Globalization;
	using System.Linq;
	using System.Text;
	using System.Threading;
	using global::Common.Logging;
	using MailBee;
	using MailBee.ImapMail;
	using MailBee.Mime;
	using MailBee.Security;
	using Terrasoft.Common;
	using Terrasoft.Configuration;
	using Terrasoft.Configuration.Imap;
	using Terrasoft.Core;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Factories;
	using Terrasoft.Core.Scheduler;
#if !NETSTANDARD2_0 // TODO #CRM-42481
	using Terrasoft.Social.OAuth;
#endif
	using Terrasoft.Core.Configuration;
	using Terrasoft.Configuration.FileUpload;

	#region Struct: MailMessageParticipants

	public struct MailMessageParticipants
	{

		#region Fields: Public

		public Guid SenderContactId;
		public List<Guid> ToContactIds;
		public List<Guid> CcContactIds;
		public List<Guid> BccContactIds;
		public List<Guid> AllParticipantContactIds;

		#endregion

	}

	#endregion

	#region Struct: ImapErrorMessages

	public struct ImapErrorMessages
	{

		#region Fields: Public

		public string LocCanNotConnect;
		public string LocServerNotSupportSslConnection;
		public string LocLoginOrPwdWrong;
		public string LocSyncError;

		#endregion

	}

	#endregion

	#region Class: ImapException

	public class ImapException : Exception
	{

		#region Constructors: Public

		public ImapException(string message)
			: base(message) {
		}

		public ImapException(string message, Exception innerException)
			: base(message, innerException) {
		}

		#endregion

	}

	#endregion

	#region Class: ImapClient

	public class ImapClient : IDisposable
	{
		#region LocalizableStrings

		public LocalizableString LocFileNotLoaded {
			get {
				return new LocalizableString(GetResourceStorage(), "ImapClient",
					"LocalizableStrings.LocFileNotLoaded.Value").ToString();
			}
		}
		public LocalizableString LocLoginOrPwdWrong {
			get {
				return new LocalizableString(GetResourceStorage(), "ImapClient",
					"LocalizableStrings.LocLoginOrPwdWrong.Value").ToString();
			}
		}

		/// <summary>
		/// Invalid OAuth credentials localizable string.
		/// </summary>
		public LocalizableString LocInvalidOAuthCredentials {
			get {
				return new LocalizableString(GetResourceStorage(), "ImapClient",
					"LocalizableStrings.LocInvalidOAuthCredentials.Value").ToString();
			}
		}

		public LocalizableString LocCanNotConnect {
			get {
				return new LocalizableString(GetResourceStorage(), "ImapClient",
					"LocalizableStrings.LocCanNotConnect.Value").ToString();
			}
		}
		public LocalizableString LocCustomFlagsNotSupported {
			get {
				return new LocalizableString(GetResourceStorage(), "ImapClient",
					"LocalizableStrings.LocCustomFlagsNotSupported.Value").ToString();
			}
		}
		public LocalizableString LocServerNotSupportSslConnection {
			get {
				return new LocalizableString(GetResourceStorage(), "ImapClient",
					"LocalizableStrings.LocServerNotSupportSslConnection.Value").ToString();
			}
		}
		public LocalizableString LocSyncError {
			get {
				return new LocalizableString(GetResourceStorage(), "ImapClient",
					"LocalizableStrings.LocSyncError.Value").ToString();
			}
		}

		/// <summary>
		/// Cannot read folder localizable string.
		/// </summary>
		public LocalizableString LocCanNotReadFolder {
			get {
				return new LocalizableString(GetResourceStorage(), "ImapClient",
					"LocalizableStrings.LocCanNotReadFolder.Value").ToString();
			}
		}

		public LocalizableString LocCanNotCreateFolder {
			get {
				return new LocalizableString(GetResourceStorage(), "ImapClient",
					"LocalizableStrings.LocCanNotCreateFolder.Value").ToString();
			}
		}
		public LocalizableString LocNoName {
			get {
				return new LocalizableString(GetResourceStorage(), "ImapClient",
					"LocalizableStrings.LocNoName.Value").ToString();
			}
		}

		#endregion

		#region Fields: Private

		private Imap _client;
		private string _currentMailboxName;
		private string _bpmOnlineFolderFullName = "INBOX";
		private string _syncMemoryLimitToDeallocateSysSetting = "SyncMemoryLimitToDeallocate";
		private readonly string _imapEventsLogging = "ImapEventsLogging";
		/// <summary>
		/// Default memory size limit for deallocation (size specified in MegaBytes)
		/// </summary>
		private decimal _defMaxMemorySize = 100m;
		private decimal _kbSize = 1024m;
		private UserConnection _userConnection;
		private static readonly ILog _log = LogManager.GetLogger("Imap");
		private MailboxFoldersCorrespondence _currentFolder;
		/// <summary>
		/// Default credentials timeout (used when mail server SMTP server timeout equals 0).
		/// </summary>
		private int _defaultCredentialsTimeout = 40000;



		#endregion

		#region Fields: Public

		public static string BPMonlineFolderName = "INBOX";

		#endregion

		#region Properties: Protected

		/// <summary>
		/// Sets or gets current mailbox settings unique identifier.
		/// </summary>
		private Guid _currentMailboxSettingsId = Guid.Empty;
		protected Guid CurrentMailboxSettingsId {
			get {
				if (_currentMailboxSettingsId.IsEmpty()) {
					Select settingsSelect = new Select(_userConnection)
						.Column("Id")
					.From("MailboxSyncSettings")
					.Where("SenderEmailAddress").IsEqual(Column.Parameter(_currentMailboxName)) as Select;
					_currentMailboxSettingsId = settingsSelect.ExecuteScalar<Guid>();
				}
				return _currentMailboxSettingsId;
			}
			set {
				_currentMailboxSettingsId = value;
			}
		}

		/// <summary>
		/// Current mailbox root <see cref="ActivityFolder"/> instance id.
		/// </summary>
		private Guid _rootActivityFolderId;
		protected Guid RootActivityFolderId {
			get {
				if (_rootActivityFolderId.IsEmpty()) {
					var activityFolderSelect =
						new Select(_userConnection).Top(1)
							.Column("Id")
						.From("ActivityFolder")
						.Where("FolderTypeId").IsEqual(Column.Parameter(FolderConsts.MailboxFolderTypeId))
						.And("CreatedById").IsEqual(Column.Parameter(_userConnection.CurrentUser.ContactId))
						.And("Name").IsEqual(Column.Parameter(_currentMailboxName)) as Select;
					_rootActivityFolderId = activityFolderSelect.ExecuteScalar<Guid>();
				}
				return _rootActivityFolderId;
			}
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// <see cref="ISyncStrategy"/> implementation.
		/// </summary>
		public ISyncStrategy Strategy {
			get;
			set;
		}

		private int _synchronizedMessages = 0;
		public int SynchronizedMessages {
			get {
				return _synchronizedMessages;
			}
		}

		public int RemoteChangesCount {
			get;
			private set;
		}

		public int LocalChangesCount {
			get;
			private set;
		}

		private decimal _maxMemorySize = -1;
		public decimal MaxMemorySize {
			get {
				if (_maxMemorySize < 0) {
					_maxMemorySize = Terrasoft.Core.Configuration.SysSettings.GetValue<decimal>(_userConnection,
							_syncMemoryLimitToDeallocateSysSetting, _defMaxMemorySize);
				}
				return _maxMemorySize;
			}
		}

		#endregion

		#region Constructors: Internal

		static ImapClient() {
			MailBee.Global.LicenseKey = "MN110-6DA58BC4A5FCA54AA5BA8059BC03-5DA1";
		}

		/// <summary>
		/// Creates <see cref="ImapClient"/> instance.
		/// </summary>
		/// <param name="credentials"><see cref="MailCredentials"/> instance.</param>
		/// <param name="errorMessages"><see cref="ImapErrorMessages"/> instance.</param>
		/// <param name="userConnection"><see cref="UserConnection"/> instance.</param>
		/// <param name="mailboxSettingsId">Mailbox synchronization settings unique identifier.</param>
		/// <param name="login">Flag indicates if need to login to imap server.</param>
		public ImapClient(MailCredentials credentials, ImapErrorMessages errorMessages, UserConnection userConnection, Guid mailboxSettingsId,
			bool login = true)
			: this(credentials, errorMessages, userConnection, login) {
			CurrentMailboxSettingsId = mailboxSettingsId;
		}

		/// <summary>
		/// Creates <see cref="ImapClient"/> instance.
		/// </summary>
		/// <param name="credentials"><see cref="MailCredentials"/> instance.</param>
		/// <param name="errorMessages"><see cref="ImapErrorMessages"/> instance.</param>
		/// <param name="userConnection"><see cref="UserConnection"/> instance.</param>
		/// <param name="login">Flag indicates if need to login to imap server.</param>
		public ImapClient(MailCredentials credentials, ImapErrorMessages errorMessages, UserConnection userConnection, bool login = true) {
			_userConnection = userConnection;
			_client = CreateImapClient(credentials);
			RemoteChangesCount = 0;
			LocalChangesCount = 0;
			string errorMessage = string.Empty;
			try {
				_currentMailboxName = credentials.SenderEmailAddress;
				if (login) {
					string oauthClassName = GetOAuthClientClassNameBySender(_currentMailboxName);
					if (oauthClassName.IsNotNullOrEmpty()) {
						errorMessage = LocInvalidOAuthCredentials.ToString();
#if !NETSTANDARD2_0 // TODO #CRM-42481
						OAuthClient oauthClient = (OAuthClient)Activator.CreateInstance(Type.GetType("Terrasoft.Configuration." + oauthClassName), credentials.SenderEmailAddress, userConnection);
						string token = oauthClient.GetAccessToken();
#else
						string token = string.Empty;
#endif
						string xoAuthKey = OAuth2.GetXOAuthKeyStatic(credentials.SenderEmailAddress, token);
						_client.Login(credentials.UserName, xoAuthKey, AuthenticationMethods.SaslOAuth2, MailBee.AuthenticationOptions.None, null);
					} else {
						errorMessage = LocLoginOrPwdWrong.ToString();
						_client.Login(credentials.UserName, credentials.UserPassword);
					}
				}
			} catch (Exception ex) {
				throw new ImapException(errorMessage, ex);
			}
		}

		#endregion

		#region Methods: Private

		private IResourceStorage GetResourceStorage() {
			return _userConnection.ResourceStorage;
		}

		private Imap CreateImapClient(MailCredentials credentials) {
			Imap client = new Imap();
			SetImapLogging(client, credentials.SenderEmailAddress);
			if (credentials.StartTls) {
				client.SslMode = SslStartupMode.UseStartTlsIfSupported;
			}
			client.SslProtocol = SecurityProtocol.Auto;
			client.Timeout = credentials.Timeout > 0 ? credentials.Timeout : _defaultCredentialsTimeout;
			try {
				if (credentials.Port > 0) {
					client.Connect(credentials.Host, credentials.Port);
				} else {
					client.Connect(credentials.Host);
				}
			} catch (Exception ex) {
				throw new ImapException(LocCanNotConnect.ToString(), ex);
			}
			if (credentials.UseSsl && !client.IsSslConnection) {
				throw new ImapException(LocServerNotSupportSslConnection);
			}
			return client;
		}

		private void SetImapLogging(Imap client, string email) {
			if (_userConnection.GetIsFeatureEnabled(_imapEventsLogging)) {
				var filenamePath = GetImapEventsLoggingFileName(email);
				if (filenamePath.IsNotNullOrEmpty()) {
					client.Log.Enabled = true;
					client.Log.Filename = filenamePath;
					_log.Info($"[{_currentMailboxName}] | ImapEventsLogging is enabled, path = '{filenamePath}'");
				}
			}
		}

		private string GetImapEventsLoggingFileName(string email) {
			try {
				var tempFolderPath = Environment.GetEnvironmentVariable("TEMP", EnvironmentVariableTarget.Machine);
				var directoryInfo = Directory.CreateDirectory(Path.Combine(tempFolderPath, _imapEventsLogging));
				var defImapEventsLoggingFileName = Path.Combine(directoryInfo.FullName, email + ".log");
				return Core.Configuration.SysSettings.GetValue<string>(_userConnection,
					_imapEventsLogging, defImapEventsLoggingFileName);
			} catch (Exception exp) {
				_log.Info($"[{_currentMailboxName}] | Error when get events logging file name. Message '{exp.Message}'");
				return string.Empty;
			}
		}

		private decimal SyncEnvelope(Envelope envelope, Func<MailMessage, Envelope, bool, string, bool> syncAction,
				string crmFolder, decimal totalSize) {
			try {
				decimal fileSize = (decimal)envelope.Size / _kbSize / _kbSize;
				_log.Info(string.Format("[{0}] - [{1}] | Downloaded message size: {2:0.00} mb", _currentMailboxName,
						crmFolder, fileSize));
				totalSize += fileSize;
				bool leaveMessageUnread = !envelope.Flags.SystemFlags.HasFlag(SystemMessageFlags.Seen);
				using (MailMessage message = _client.DownloadEntireMessage((long)envelope.Uid, true)) {
					var messageInfo = string.Format("[{0}] - [{1}] | FROM: {2} SUBJECT: {3}", _currentMailboxName, crmFolder,
							message.From, message.Subject);
					try {
						_log.Info(messageInfo);
						syncAction(message, envelope, !leaveMessageUnread, crmFolder);
						Strategy.SetMessageSynchronized(_client, message);
					} catch (Exception e) {
						_log.Error(string.Format("{0} - Error on sync action: {1}", messageInfo, e.ToString()));
					}
				}
				totalSize = TryClearMemory(totalSize, crmFolder);
				if (leaveMessageUnread) {
					_client.SetMessageFlags(envelope.Uid.ToString(), true, SystemMessageFlags.Seen, MessageFlagAction.Remove);
				}
				Interlocked.Increment(ref _synchronizedMessages);
			} catch (Exception ex) {
				var messageInfo = string.Format("[{0}] - [{1}] | FROM: {2} SUBJECT: {3}", _currentMailboxName, crmFolder,
					envelope.From, envelope.Subject);
				_log.Error(string.Format("{0} - Error on sync action: {1}", messageInfo, ex.ToString()));
			}
			return totalSize;
		}

		private decimal TryClearMemory(decimal totalSize, string crmFolder) {
			if (totalSize >= MaxMemorySize) {
				_log.Info(string.Format("[{0}] - [{1}] | Messages total size reached {2:0.00}mb. Starting memory deallocation",
							_currentMailboxName, crmFolder, totalSize));
				GC.Collect();
				totalSize = 0;
			}
			return totalSize;
		}

		/// <summary>
		/// Gets current folder mailbox correspondence.
		/// </summary>
		/// <param name="folderPath">Folder path.</param>
		/// <param name="mailBoxId">Unique mailbox identifier in bpm.</param>
		/// <param name="getCurrentMailboxFolderResult">True if obtain successful folder <c>false</c> otherwise.</param>
		/// <returns><see cref="MailboxFoldersCorrespondence"/> instance</returns>
		private MailboxFoldersCorrespondence GetsCurrentMailboxFoldersCorrespondence(string folderPath, string mailBoxId,
				out bool getCurrentMailboxFolderResult) {
			EntitySchema mailboxFoldersCorrespondenceSchema = _userConnection.EntitySchemaManager.GetInstanceByName("MailboxFoldersCorrespondence");
			MailboxFoldersCorrespondence mailboxFoldersCorrespondence =
				mailboxFoldersCorrespondenceSchema.CreateEntity(_userConnection) as MailboxFoldersCorrespondence;
			Select mfcSelect = new Select(_userConnection).Top(1)
				.Column("Id")
				.From("MailboxFoldersCorrespondence")
				.Where("FolderPath").IsEqual(Column.Parameter(folderPath))
					.And("MailboxId").IsEqual(Column.Parameter(new Guid(mailBoxId))) as Select;
			Guid mailboxFolderId = mfcSelect.ExecuteScalar<Guid>();
			if (mailboxFolderId.IsEmpty()) {
				getCurrentMailboxFolderResult = false;
				return null;
			}
			getCurrentMailboxFolderResult = mailboxFoldersCorrespondence.FetchFromDB(mailboxFolderId, false);
			return mailboxFoldersCorrespondence;
		}

		private void SyncMailMessagesInFolder(string crmFolder, string rawName, Func<MailMessage, Envelope, bool, string, bool> syncAction) {
			_log.Info(string.Format("------ [{0}] | Mail synchronization in folder {1} STARTED. ------", _currentMailboxName, rawName));
			bool getCurrentMailboxFoldersResult;
			_currentFolder = GetsCurrentMailboxFoldersCorrespondence(rawName, CurrentMailboxSettingsId.ToString(),
					out getCurrentMailboxFoldersResult);
			if (!getCurrentMailboxFoldersResult) {
				throw new ImapException(LocCanNotReadFolder.ToString());
			}
			MessageIndexCollection msgIndexes = Strategy.GetUnsyncedMsgIndexes(_client, rawName);
			_log.Info(string.Format("[{0}] - [{1}]  Sync query {2} - found {3} unsynchronized messages headers for ActivityFolderId {4}",
				_currentMailboxName, rawName, Strategy.GetUnsyncMsgSearchQuery(), msgIndexes.Count, _currentFolder.ActivityFolderId));
			if (msgIndexes.Count > 0) {
				try {
					var remoteChangesCount = 0;
					decimal totalSize = 0m;
					var msgEnvelopes = _client.DownloadEnvelopes(msgIndexes.ToString(), true);
					_log.Info(string.Format("[{0}] - [{1}] | Load {2} unsynchronized messages", _currentMailboxName, rawName, msgEnvelopes.Count));
					foreach (Envelope envelope in msgEnvelopes) {
						totalSize = SyncEnvelope(envelope, syncAction, crmFolder, totalSize);
						remoteChangesCount++;
					}
					_log.Info(string.Format("[{0}] - [{1}] | Processed {2} messages", _currentMailboxName, rawName, msgEnvelopes.Count));
					RemoteChangesCount = remoteChangesCount;
				} catch (Exception ex) {
					_log.Error(string.Format("[{0}] - [{1}] | Error on folder sync: {2}", _currentMailboxName, rawName, ex.ToString()));
				}
			}
			List<long> messageIndexList = GetMsgIndexesList(msgIndexes);
			messageIndexList.Sort();
			if (_currentFolder != null && messageIndexList.Count > 0) {
				_currentFolder.UId = messageIndexList.Last().ToString();
				_log.Error($"[{_currentMailboxName}] - [{_currentFolder}] | Update folder UId '{_currentFolder.UId}' start." +
					$"ActivityFolderId = '{_currentFolder.ActivityFolderId}'");
				SaveCurrentFolder(_currentFolder);
				_log.Error($"[{_currentMailboxName}] - [{_currentFolder}] | Update folder UId '{_currentFolder.UId}' end." +
					$"ActivityFolderId = '{_currentFolder.ActivityFolderId}'");
			}
			_log.Info(string.Format("------ [{0}] | Mail synchronization in folder {1} COMPLETED. ------", _currentMailboxName, rawName));
		}

		private int GetIndexDraftsFolder(FolderCollection folders) {
			for (int index = 0; index < folders.Count; index++) {
				Folder folder = folders[index];
				if (folder.Flags == FolderFlags.Drafts) {
					return index;
				}
			}
			return -1;
		}

		/// <summary>
		/// Returns true if <paramref name"folder"/> allowed for synchronization.
		/// </summary>
		/// <param name="folder"><see cref="ImapFolder" instance.</param>
		/// <returns>Returns is <paramref name"folder"/> allowed for synchronization.</returns>
		private bool IsFolderAlowedForSync(ImapFolder folder) {
			_log.DebugFormat("[{0}] - [{1}] | folder flags are {2}", _currentMailboxName, folder.Name, folder.Flags);
			return ((folder.Flags & (FolderFlags.AllMail | FolderFlags.Trash | FolderFlags.Spam | FolderFlags.Drafts |
					FolderFlags.Noselect)) == 0);
		}

		/// <summary>
		/// Sync all folders in imap client, which allowed for synchronization.
		/// </summary>
		/// <param name="syncAction">Sync action for <see cref="Envelope"/> instance.</param>
		/// <param name="crmFolders">Crm folders list.</param>
		/// <remarks>
		/// <see cref="ImapClient.IsFolderAlowedForSync"/> method is used to determine folders for synchronization.
		/// </remarks>
		private void SyncAllFolders(Func<MailMessage, Envelope, bool, string, bool> syncAction,
				Dictionary<string, List<Guid>> crmFolders) {
			ImapFolderCollection mailboxFolders = TryGetImapFoldersCollection();
			foreach (ImapFolder mailboxFolder in mailboxFolders) {
				try {
					_log.Info(string.Format("[{0}] - [{1}] [2]| Check if folder is allowed for sync",
						_currentMailboxName, mailboxFolder.Name, mailboxFolder.RawName));
					if (IsFolderAlowedForSync(mailboxFolder)) {
						SelectFolderForSyncronization(mailboxFolder.RawName);
						ActualizeMailboxFoldersCorrespondence(mailboxFolder);
						SyncMailMessagesInFolder(mailboxFolder.ShortName, mailboxFolder.RawName, syncAction);
					}
				} catch (Exception e) {
					_log.Error(string.Format("[{0}] - [{1}] | Folder synchronization error: {2}",
						_currentMailboxName, mailboxFolder.RawName, e.ToString()));
				}
			}
		}

		/// <summary>
		/// Synchronize selected folders in IMAP client.
		/// </summary>
		/// <param name="syncAction">Sync action for <see cref="Envelope"/> instance.</param>
		/// <param name="crmFolders">Crm folders list.</param>
		private void SyncSelectedFolders(Func<MailMessage, Envelope, bool, string, bool> syncAction,
				Dictionary<string, List<Guid>> crmFolders) {
			var realFoldersFromMailbox = TryGetImapFoldersCollection();
			foreach (var crmFolder in crmFolders) {
				foreach (Guid activityFoderId in crmFolder.Value) {
					_log.InfoFormat("[{0}] - try ActivityFolderId = \"{1}\" synchronization",
						_currentMailboxName, activityFoderId);
					var rawName = GetRawNameByFolderId(activityFoderId);
					if (rawName.IsNotNullOrEmpty() && realFoldersFromMailbox.Any(f => f.RawName == rawName)) {
						_log.InfoFormat("[{0}] - ActivityFolderId \"{1}\" raw name is {2}",
							_currentMailboxName, activityFoderId, rawName);
						try {
							SelectFolderForSyncronization(rawName);
							SyncMailMessagesInFolder(crmFolder.Key, rawName, syncAction);
						} catch (Exception e) {
							_log.Error(string.Format("[{0}] - [{1}] | Folder synchronization error: {2}",
									_currentMailboxName, rawName, e.ToString()));
						}
					}
				}
			}
		}

		/// <summary>
		/// Returns id of the <paramref name="folder"/>.
		/// </summary>
		/// <param name="folder"><see cref="ImapFolder"/> instance.</param>
		/// <returns>id of the <paramref name="folder"/>.</returns>
		private Guid GetFolderId(ImapFolder folder) {
			var select = SelectFolderFromDB(folder.RawName) as Select;
			return select.ExecuteScalar<Guid>();
		}

		/// <summary>
		/// Returns <see cref="Query"/> for selecting folder by provided name.
		/// </summary>
		/// <param name="rawName"> folder's name.</param>
		/// <returns><see cref="Query"/> for selecting folder by provided name.</returns>
		private Query SelectFolderFromDB(string rawName) {
			var select =
				new Select(_userConnection).Top(1)
					.Column("Id")
				.From("MailboxFoldersCorrespondence")
				.Where("FolderPath").IsEqual(Column.Parameter(rawName))
				.And("MailboxId").IsEqual(Column.Parameter(CurrentMailboxSettingsId));
			return select;
		}

		/// <summary>
		/// Creates <see cref="ActivityFolder"/> instance for <paramref name="folder"/>.
		/// </summary>
		/// <param name="folder"><see cref="ImapFolder"/> instance.</param>
		/// <returns><see cref="ActivityFolder"/> instance unique identifier.</returns>
		private Guid CreateActivityFolder(ImapFolder folder) {
			EntitySchema schema = _userConnection.EntitySchemaManager.GetInstanceByName("ActivityFolder");
			Entity activityFolder = schema.CreateEntity(_userConnection);
			activityFolder.SetDefColumnValues();
			activityFolder.SetColumnValue("Name", folder.ShortName);
			activityFolder.SetColumnValue("FolderTypeId", FolderConsts.EmailFolderTypeId);
			activityFolder.SetColumnValue("ParentId", RootActivityFolderId);
			activityFolder.Save();
			return activityFolder.PrimaryColumnValue;
		}

		/// <summary>
		/// Creates <see cref="MailboxFoldersCorrespondence"/> instance for <paramref name="folder"/> if needed.
		/// </summary>
		/// <param name="folder"><see cref="ImapFolder"/> instance.</param>
		private void ActualizeMailboxFoldersCorrespondence(ImapFolder folder) {
			Guid folderId = GetFolderId(folder);
			if (folderId.IsEmpty()) {
				Guid activityFolderId = CreateActivityFolder(folder);
				EntitySchema schema = _userConnection.EntitySchemaManager
					.GetInstanceByName("MailboxFoldersCorrespondence");
				Entity correspondence = schema.CreateEntity(_userConnection);
				correspondence.SetDefColumnValues();
				correspondence.SetColumnValue("FolderPath", folder.RawName);
				correspondence.SetColumnValue("UId", "0");
				correspondence.SetColumnValue("MailboxId", CurrentMailboxSettingsId);
				correspondence.SetColumnValue("ActivityFolderId", activityFolderId);
				SaveEntity(correspondence);
			}
		}

		private string GetOAuthClientClassNameBySender(string emailSender) {
			EntitySchemaQuery esq = new EntitySchemaQuery(_userConnection.EntitySchemaManager, "MailboxSyncSettings");
			EntitySchemaQueryColumn column = esq.AddColumn("MailServer.OAuthApplication.ClientClassName");
			esq.Filters.Add(esq.CreateFilterWithParameters(FilterComparisonType.Equal, "SenderEmailAddress", emailSender));
			esq.Filters.Add(esq.CreateIsNotNullFilter("OAuthTokenStorage"));
			Entity mailbox = esq.GetEntityCollection(_userConnection).FirstOrDefault();
			if (mailbox != null) {
				return mailbox.GetTypedColumnValue<string>(column.Name);
			} else {
				return null;
			}
		}

		#endregion

		#region Methods: Protected

		/// <summary>
		/// Saves entity.
		/// </summary>
		/// <param name="entity"><see cref="Entity"/>instance.</param>
		protected virtual void SaveEntity(Entity entity) {
			entity.Save();
		}

		/// <summary>
		/// Gets list mailbox indexes from <paramref name="msgIndexes"/>.
		/// </summary>
		/// <param name="msgIndexes"><see cref="MessageIndexCollection"/> instance.</param>
		/// <returns>List mailbox indexes.</returns>
		protected virtual List<long> GetMsgIndexesList(MessageIndexCollection msgIndexes) {
			return msgIndexes.Cast<long>().ToList();
		}

		/// <summary>
		/// Returns imap folder unique identifier.
		/// </summary>
		/// <returns>Imap folder unique identifier.</returns>
		protected virtual long GetFolderUid() {
			return _client.UidValidity;
		}

		/// <summary>
		/// Gets folder name by <paramref name="activityFolderId"/>.
		/// </summary>
		/// <param name="activityFolderId">Activity folder unique identifier.</param>
		/// <returns>Folder name.</returns>
		protected virtual string GetRawNameByFolderId(Guid activityFolderId) {
			var sel = new Select(_userConnection)
				.Column("FolderPath")
				.From("MailboxFoldersCorrespondence")
				.Where("ActivityFolderId").IsEqual(Column.Parameter(activityFolderId)) as Select;
			List<string> names = new List<string>();
			using (var dbExecutor = _userConnection.EnsureDBConnection()) {
				using (var reader = sel.ExecuteReader(dbExecutor)) {
					if (reader.Read()) {
						int columnOrdinal = reader.GetOrdinal("FolderPath");
						return reader.GetString(columnOrdinal);
					}
				}
			}
			return string.Empty;
		}

		/// <summary>
		/// Saves folder entity.
		/// </summary>
		/// <param name="currentFolder"><see cref="MailboxFoldersCorrespondence"/> instance.</param>
		protected virtual void SaveCurrentFolder(MailboxFoldersCorrespondence currentFolder) {
			currentFolder.Save();
		}

		/// <summary>
		/// Selects the specified folder for read-write access.
		/// </summary>
		/// <param name="rawName">Folder raw name.</param>
		protected virtual void SelectFolderForSyncronization(string rawName) {
			_log.Info(string.Format("[{0}] - [{1}] | Selecting folder for sync in client.", _currentMailboxName, rawName));
			_client.Utf7EncodeFolderNames = false;
			_client.SelectFolder(rawName);
			_client.Utf7EncodeFolderNames = true;
			_log.Info(string.Format("[{0}] - [{1}] | Folder selected for sync in client.", _currentMailboxName, rawName));
		}

		#endregion

		#region Methods: Public

		/// <summary>
		/// Returns <see cref="FolderCollection"/> instance.
		/// </summary>
		/// <remarks>
		/// Draft folders will be filtered.
		/// </remarks>
		public FolderCollection TryGetFoldersCollection() {
			FolderCollection folders = null;
			try {
				folders = _client.DownloadFolders(false);
			} catch (MailBeeException e) {
				throw new ImapException(LocSyncError.ToString(), e);
			}
			int draftsIndex = GetIndexDraftsFolder(folders);
			if (draftsIndex > 0) {
				folders.RemoveAt(draftsIndex);
			}
			return folders;
		}

		/// <summary>
		/// Returns <see cref="ImapFolderCollection"/> instance.
		/// </summary>
		/// <remarks>
		/// Draft folders will be filtered.
		/// </remarks>
		public virtual ImapFolderCollection TryGetImapFoldersCollection() {
			FolderCollection folders = TryGetFoldersCollection();
			var imapfolders = new ImapFolderCollection(folders);
			if (imapfolders != null) {
				_log.Info($"[{_currentMailboxName}] | Folders from mailbox count {imapfolders.Count()}.");
				foreach (ImapFolder folder in imapfolders) {
					_log.Info($"[{_currentMailboxName}] - [{folder.Name}] | RawName = '{folder.RawName}'");
				}
			}
			return imapfolders;
		}

		public bool TryDeleteFolder(string folderName) {
			bool result = true;
			try {
				result = _client.DeleteFolder(folderName);
			} catch (MailBeeImapNegativeResponseException) {
				result = false;
			}
			return result;
		}

		public bool EnsureFolderExists(string folderName) {
			bool result = false;
			try {
				result = _client.ExamineFolder(folderName);
			} catch (MailBeeImapNegativeResponseException) {
				result = false;//_client.CreateFolder(folderName);
			}
			return result;
		}

		public bool CreateFolder(string newFolderPath) {
			bool result = false;
			try {
				result = _client.CreateFolder(newFolderPath);
			} catch (MailBeeImapNegativeResponseException e) {
				return e.OptionalResponse != null && e.OptionalResponse.Equals("ALREADYEXISTS",
						StringComparison.InvariantCultureIgnoreCase) ||
					e.HumanReadable.Equals("Mailbox already exists.", StringComparison.InvariantCultureIgnoreCase);
			}
			return result;
		}

		public void MoveMessageToFolder(string folderName, string messageTitle, string destenationFolder) {
			_client.SelectFolder(folderName);
			MessageIndexCollection uids = _client.Search(true, string.Format("SUBJECT {0}", messageTitle), null);
			if (uids.Count > 0) {
				_client.MoveMessages(uids.ToString(), true, destenationFolder);
			}
		}

		public bool RenameOrCreateFolder(string oldFolderName, string newFolderName) {
			bool result = false;
			try {
				result = _client.RenameFolder(oldFolderName, newFolderName);
			} catch (MailBeeImapNegativeResponseException) {
				result = _client.CreateFolder(newFolderName);
			}
			return result;
		}

		public void EnforceFoldersStructure(IEnumerable<string> folderNames) {
		}

		public bool ValidateCustomFlagsSupport() {
			try {
				_client.SelectFolder(_bpmOnlineFolderFullName);
				var strategy = new FlagBasedSyncStrategy(_userConnection);
				return strategy.ValidateCustomFlagsSuport(_client);
			} catch (MailBeeException e) {
				throw new ImapException(LocSyncError.ToString(), e);
			}
		}

		/// <summary>
		/// Synchronizes email messages.
		/// </summary>
		/// <param name="syncAction">Sync action for <see cref="Envelope"/> instance.</param>
		/// <param name="crmFolders">Specific directories to synchronize.</param>
		/// <param name="loadAll">Defines the need to download all messages.</param>
		public void SyncMailMessages(Func<MailMessage, Envelope, bool, string, bool> syncAction, Dictionary<string, List<Guid>> crmFolders, bool loadAll = true) {
			SynchronizationErrorHelper helper = SynchronizationErrorHelper.GetInstance(_userConnection);
			try {
				if (loadAll) {
					_log.Info(string.Format("[{0}] | Loading emails from all folders", _currentMailboxName));
					SyncAllFolders(syncAction, crmFolders);
				} else {
					_log.Info(string.Format("[{0}] | Loading emails from selected folders", _currentMailboxName));
					SyncSelectedFolders(syncAction, crmFolders);
				}
				helper.CleanUpSynchronizationError(_currentMailboxName);
			} catch (Exception ex) {
				helper.ProcessSynchronizationError(_currentMailboxName, ex);
				if (ex is MailBeeException) {
					throw new ImapException(LocSyncError.ToString(), ex);
				}
				throw ex;
			}
		}

		public void Dispose() {
			if (_client != null) {
				try {
					_client.Disconnect();
				} finally {
					_client = null;
				}
			}
		}

		#endregion

	}

	#endregion

	#region Class: MailSynchronizer

	public class MailSynchronizer : IDisposable
	{

		#region Constants: Private

		private const string JobName = "SyncImap";
		private const string SyncJobGroupName = "IMAP";
		private const string SyncProcessName = "SyncImapMail";
		private const string ActivitySchemaName = "Activity";
		private const string ActivityFolderSchemaName = "ActivityFolder";
		private const string ActivityInFolderSchemaName = "ActivityInFolder";
		private const string ActivityStatusSchemaName = "ActivityStatus";
		private const string EmailSendStatusSchemaName = "EmailSendStatus";
		private const string EmailSubfolderTypeCode = "SubEmail";
		private const string MailBoxFolderTypeCode = "MailBox";
		private const string FileTypeCode = "File";
		private const string EmailActivityTypeCode = "Email";

		/// <summary>
		/// <see cref="FlagBasedSinceDateSyncStrategy"/> class factory binding key.
		/// </summary>
		private const string FlagBasedSinceDateSyncStrategyName = "FlagBasedSinceDateSyncStrategy";

		/// <summary>
		/// <see cref="DateBasedSyncStrategy"/> class factory binding key.
		/// </summary>
		private const string DateBasedSyncStrategyName = "DateBasedSyncStrategy";

		/// <summary>
		/// <see cref="UidBasedSyncStrategy"/> class factory binding key.
		/// </summary>
		private const string UidBasedSyncStrategyName = "UidBasedSyncStrategy";

		#endregion

		#region Fields: Private

		private static readonly Guid IncomingMessageTypeId = new Guid("7f9d1f86-f36b-1410-068c-20cf30b39373");
		private static readonly Guid OutcomingMessageTypeId = new Guid("7f6d3f94-f36b-1410-068c-20cf30b39373");
		private static readonly Guid ActivityCategoryId = new Guid("8038a396-7825-e011-8165-00155d043204");
		private Guid EmailSubfolderTypeId;
		private Guid MailBoxFolderTypeId;
		private Dictionary<MailPriority, Guid> PriorityMapping = new Dictionary<MailPriority, Guid>() {
				{MailPriority.None, new Guid("ab96fa02-7fe6-df11-971b-001d60e938c6")},
				{MailPriority.Normal, new Guid("ab96fa02-7fe6-df11-971b-001d60e938c6")},
				{MailPriority.High, new Guid("d625a9fc-7ee6-df11-971b-001d60e938c6")},
				{MailPriority.Highest, new Guid("d625a9fc-7ee6-df11-971b-001d60e938c6")},
				{MailPriority.Low, new Guid("ac96fa02-7fe6-df11-971b-001d60e938c6")},
				{MailPriority.Lowest, new Guid("ac96fa02-7fe6-df11-971b-001d60e938c6")}
			};
		private Guid FinishedActvityStatusId;
		private Guid SendedEmailStatusId;
		private Guid FileTypeId;
		private Dictionary<string, Guid> ActivityParticipantRoles;
		private Guid EmailActivityTypeId;
		private Guid _currentEmailActivityId;
		private MailCredentials _credentials;
		private MailboxSyncSettings _mailboxSyncSettings;
		private static readonly ILog _log = LogManager.GetLogger("Imap");

		/// <summary>
		/// Current synchronization class factory binding key. 
		/// </summary>
		private string _settingsStrategy;

		#endregion

		#region Fields: Protected

		/// <summary>
		/// Activity folders in bpm.
		/// </summary>
		protected Dictionary<string, List<Guid>> _activityFolders;

		/// <summary>
		/// <see cref="UserConnection"/>
		/// </summary>
		protected UserConnection _userConnection;

		/// <summary>
		/// Flag indicates, if used date base strategy.
		/// </summary>
		protected bool _isDateBasedStrategy;

		/// <summary>
		/// Last synchronization date.
		/// </summary>
		protected DateTime _lastSyncDate;

		/// <summary>
		/// Current synchronization start date.
		/// </summary>
		protected DateTime _startSyncDate;

		/// <summary>
		/// <see cref="ImapClient"/> instance.
		/// </summary>
		protected ImapClient _imapClient;

		#endregion

		#region Constructors: Public

		public MailSynchronizer() {
			LocalChangesCount = 0;
			RemoteChangesCount = 0;
			InitSyncSessionId();
		}

		/// <summary>
		/// Initializes a new instance of the class <see cref="TestMailSynchronizer"/>
		/// </summary>
		/// <param name="userConnection"><see cref="UserConnection"/> instance.</param>
		/// <param name="credentials"><see cref="MailCredentials"/> instance.</param>
		/// <param name="login">Flag indicates the need to log in to the mail server.</param>
		public MailSynchronizer(UserConnection userConnection, MailCredentials credentials, bool login = true) {
			_userConnection = userConnection;
			_credentials = credentials;
			LocalChangesCount = 0;
			RemoteChangesCount = 0;
			if (login) {
				_mailboxSyncSettings = GetMailboxSyncSettings();
			}
			InitMailSynchronizer(userConnection, credentials, login);
			InitSyncSessionId();
		}

		#endregion

		#region Properties: Protected

		/// <summary>
		/// User name not set error message tpl.
		/// </summary>
		protected virtual string LocNoName {
			get {
				return new LocalizableString(_userConnection.ResourceStorage, "ImapClient",
					"LocalizableStrings.LocNoName.Value").ToString();
			}
		}

		/// <summary>
		/// File not loaded error message tpl.
		/// </summary>
		protected virtual string LocFileNotLoaded {
			get {
				return new LocalizableString(_userConnection.ResourceStorage, "ImapClient",
					"LocalizableStrings.LocFileNotLoaded.Value").ToString();
			}
		}

		/// <summary>
		/// <see cref="EmailMessageHelper"/> instance.
		/// </summary>
		private EmailMessageHelper _messageHelper;
		protected virtual EmailMessageHelper MessageHelper {
			get {
				if (_messageHelper == null) {
					var userConnection = new ConstructorArgument("userConnection", _userConnection);
					_messageHelper = ClassFactory.Get<EmailMessageHelper>(userConnection);
				}
				return _messageHelper;
			}
		}

		#endregion

		#region Properties: Public

		public int RemoteChangesCount {
			get;
			private set;
		}

		public int LocalChangesCount {
			get;
			private set;
		}

		/// <summary>
		/// Synchronization session unique identifier.
		/// </summary>
		private string _synsSessionId;
		public string SynsSessionId {
			get {
				return _synsSessionId;
			}
		}

		#endregion

		#region Methods: Private

		#region Custom: Helpers

		/// <summary>
		/// Gets synchronization job name.
		/// </summary>
		/// <param name="userConnection">User connection.</param>
		/// <param name="parameters">Synchronization parameters.</param>
		/// <returns>Synchronization job name.</returns>
		private static string GetSyncJobName(UserConnection userConnection,
				IDictionary<string, object> parameters = null) {
			List<string> syncJobNameParts = new List<string>();
			syncJobNameParts.Add(JobName);
			if (parameters != null) {
				object senderEmailAddress;
				if (parameters.TryGetValue("SenderEmailAddress", out senderEmailAddress)) {
					syncJobNameParts.Add(senderEmailAddress.ToString());
				}
			}
			syncJobNameParts.Add(userConnection.CurrentUser.Id.ToString());
			return string.Join("_", syncJobNameParts);
		}

		private IEnumerable<Guid> GetUsersByContacts(IEnumerable<Guid> contactIds) {
			var result = new List<Guid>();
			object[] contactsArray = contactIds.Select<Guid, object>(id => id).ToArray();
			var entitySchemaManager = _userConnection.GetSchemaManager("EntitySchemaManager") as EntitySchemaManager;
			var sysAdminUnitSchemaQuery = new EntitySchemaQuery(entitySchemaManager, "SysAdminUnit");
			var idQueryColumnName = sysAdminUnitSchemaQuery.AddColumn("Id").Name;
			var filter = sysAdminUnitSchemaQuery.CreateFilterWithParameters(FilterComparisonType.Equal, "Contact", contactsArray);
			sysAdminUnitSchemaQuery.Filters.Add(filter);
			var sysAdminUnits = sysAdminUnitSchemaQuery.GetEntityCollection(_userConnection);
			foreach (var sysAdminUnit in sysAdminUnits) {
				var id = sysAdminUnit.GetTypedColumnValue<Guid>(idQueryColumnName);
				if (!result.Contains(id)) {
					result.Add(id);
				}
			}
			return result;
		}

		private Guid GetUserByContact(Guid contactId) {
			var sysAdminUnit = new Terrasoft.Configuration.SysAdminUnit(_userConnection);
			if (sysAdminUnit.FetchFromDB("Contact", contactId, false)) {
				return sysAdminUnit.Id;
			}
			return Guid.Empty;
		}

		private Guid GetMailboxActivityFolderIdByName(string folderName) {
			Select afSelect = new Select(_userConnection).Top(1)
				.Column("Id")
				.From("ActivityFolder")
				.Where("Name").IsEqual(Column.Parameter(folderName))
					.And("FolderTypeId").IsEqual(Column.Parameter(FolderConsts.MailboxFolderTypeId)) as Select;
			Guid activityFolderId = afSelect.ExecuteScalar<Guid>();
			return activityFolderId;
		}

		/// <summary>
		/// <see cref="ContactUtilities.GetContactEmailDisplayValue"/>
		/// </summary>
		private string GetContactDisplayNameByEmail(string email, out Guid contactId) {
			return ContactUtilities.GetContactEmailDisplayValue(_userConnection, email, out contactId);
		}

		private Guid GetAccountId(string email) {
			var result = Guid.Empty;
			var accountCommunicationSchemaQuery = new EntitySchemaQuery(_userConnection.EntitySchemaManager, "AccountCommunication");
			var accountIdQueryColumnName = accountCommunicationSchemaQuery.AddColumn("Account").Name;
			var filter = accountCommunicationSchemaQuery.CreateFilterWithParameters(FilterComparisonType.Equal, "Number", email);
			accountCommunicationSchemaQuery.Filters.Add(filter);
			var accountCommunications = accountCommunicationSchemaQuery.GetEntityCollection(_userConnection);
			foreach (var accountCommunication in accountCommunications) {
				result = accountCommunication.GetTypedColumnValue<Guid>("AccountId");
			}
			return result;
		}

		private void EnsureEmailRightsGranted(Guid userId) {
			EntitySchema activitySchema = _userConnection.EntitySchemaManager.GetInstanceByName(ActivitySchemaName);
			DBSecurityEngine dbSecurityEngine = _userConnection.DBSecurityEngine;
			SchemaRecordRightLevels messageRights =
				dbSecurityEngine.GetEntitySchemaRecordRightLevel(userId, activitySchema, _currentEmailActivityId);
			if ((messageRights & SchemaRecordRightLevels.CanRead) != SchemaRecordRightLevels.CanRead) {
				messageRights |= SchemaRecordRightLevels.CanRead;
				dbSecurityEngine.SetEntitySchemaRecordRightLevel(userId, activitySchema, _currentEmailActivityId, messageRights);
			}
		}

		private void EnsureActivityInFolder(Guid emailFolderId) {
			EntitySchema activityInFolderSchema = _userConnection.EntitySchemaManager.GetInstanceByName(ActivityInFolderSchemaName);
			Entity activityInFolder = activityInFolderSchema.CreateEntity(_userConnection);
			var conditions = new Dictionary<string, object>() {
				{"Folder", emailFolderId},
				{"Activity", _currentEmailActivityId}
			};
			if (!activityInFolder.FetchFromDB(conditions, false)) {
				activityInFolder.SetDefColumnValues();
				activityInFolder.SetColumnValue("FolderId", emailFolderId);
				activityInFolder.SetColumnValue("ActivityId", _currentEmailActivityId);
				activityInFolder.Save();
			}
		}

		#endregion

		#region Custom: Activity

		/// <summary>
		/// Adds attachments to activity.
		/// </summary>
		/// <param name="userConnection">User connection.</param>
		/// <param name="message">Email message.</param>
		/// <param name="htmlBody">Email body.</param>
		/// <param name="activityFiles">Dictionary of activity files and their content provider methods.</param>
		private void AddAttachmentsToActivity(UserConnection userConnection, MailMessage message, ref string htmlBody,
				Dictionary<Entity, Func<byte[]>> activityFiles) {
			var schema = userConnection.EntitySchemaManager.GetInstanceByName("ActivityFile");
			foreach (Attachment attachment in message.Attachments) {
				Entity file = CreateActivityFile(schema, userConnection);
				file.SetDefColumnValues();
				file.SetColumnValue("ActivityId", _currentEmailActivityId);
				var attName = string.IsNullOrEmpty(attachment.Name) ? attachment.Filename : attachment.Name;
				file.SetColumnValue("Name", string.IsNullOrEmpty(attName) ? LocNoName : ActivityUtils.GetAttachmentName(userConnection, attName));
				file.SetColumnValue("TypeId", FileTypeId);
				file.SetColumnValue("Inline", attachment.IsInline);
				activityFiles.Add(file, attachment.GetData);
				if (attachment.IsInline || (attachment.AsMimePart.PartType == MailBee.Mime.MimePartType.Image && attachment.IsFile)) {
					var url = string.Format("../rest/FileService/GetFile/{0}/{1}", schema.UId, file.PrimaryColumnValue);
					if (!string.IsNullOrEmpty(htmlBody) && !string.IsNullOrEmpty(attachment.ContentID)) {
						htmlBody = htmlBody.Replace("cid:" + attachment.ContentID, url);
					}
				}
			}
		}

		/// <summary>
		/// Saves error text to <paramref name="file"/> ErrorOnUpload column.
		/// </summary>
		/// <param name="file"><see cref="ActivityFile"/> instance.</param>
		/// <param name="errorText">Error text.</param>
		/// <param name="e">The exception that was thrown.</param>
		private void SaveAttachmentUploadError(Entity file, string errorText, Exception e = null) {
			if (e != null) {
				_log.ErrorFormat("[{0}] Attachment {1} ({2}) load error.", e, _mailboxSyncSettings.SenderEmailAddress,
					file.PrimaryColumnValue, file.GetTypedColumnValue<string>("Name"));
			}
			file.SetColumnValue("Uploaded", false);
			file.SetColumnValue("ErrorOnUpload", errorText);
			file.Save();

		}

		/// <summary>
		/// Uploads activity files data.
		/// </summary>
		/// <param name="userConnection">UserConnection instance.</param>
		/// <param name="activityFiles">Dictionary of activity files and their content provider methods.</param>
		private void UploadActivityFilesData(UserConnection userConnection,
				Dictionary<Entity, Func<byte[]>> activityFiles) {
			var fileRepository = ClassFactory.Get<FileRepository>(new ConstructorArgument("userConnection", userConnection));
			foreach (var activityFile in activityFiles) {
				var file = activityFile.Key;
				var getDataMethod = activityFile.Value;
				try {
					var data = getDataMethod();
					if (data != null && data.Length > 0) {
						var fileEntityInfo = new FileEntityUploadInfo("ActivityFile", file.PrimaryColumnValue,
								file.GetTypedColumnValue<string>("Name")) {
							Content = new MemoryStream(data),
							TotalFileLength = data.Length,
						};
						fileRepository.UploadFile(fileEntityInfo, false);
					} else {
						SaveAttachmentUploadError(file, LocFileNotLoaded);
					}
				} catch (Exception e) {
					SaveAttachmentUploadError(file, LocFileNotLoaded, e);
				}
			}
		}

		private void UpdateActivityReadStatusForCurrentUser(Guid activityId) {
			var update = new Update(_userConnection, "ActivityParticipant")
						.Set("ReadMark", Column.Parameter(true)).Where("ActivityId")
				.IsEqual(Column.Parameter(activityId)).And("ParticipantId")
				.IsEqual(Column.Parameter(_userConnection.CurrentUser.ContactId));
			update.Execute();
		}

		#endregion

		#region Custom: Query

		private void QueryCrmFolders(Guid mailBoxFolderId) {
			_activityFolders = new Dictionary<string, List<Guid>>();
			var activityFolderSchemaQuery = new EntitySchemaQuery(_userConnection.EntitySchemaManager, ActivityFolderSchemaName);
			var idQueryColumnName = activityFolderSchemaQuery.AddColumn("Id").Name;
			var nameQueryColumnName = activityFolderSchemaQuery.AddColumn("Name").Name;
			activityFolderSchemaQuery.Filters.Add(
				activityFolderSchemaQuery.CreateFilterWithParameters(FilterComparisonType.Equal, "FolderType", EmailSubfolderTypeId));
			activityFolderSchemaQuery.Filters.Add(
				activityFolderSchemaQuery.CreateFilterWithParameters(FilterComparisonType.Equal, "Parent", mailBoxFolderId));
			var activityFolders = activityFolderSchemaQuery.GetEntityCollection(_userConnection);
			foreach (var activityFolder in activityFolders) {
				var id = activityFolder.GetTypedColumnValue<Guid>(idQueryColumnName);
				var name = activityFolder.GetTypedColumnValue<string>(nameQueryColumnName);
				_log.InfoFormat("[{0}] - Folder \"{1}\", ActivityFolderId = \"{2}\" selected from DB for synchronization",
					_mailboxSyncSettings.SenderEmailAddress, name, id);
				if (_activityFolders.ContainsKey(name)) {
					var idList = _activityFolders[name];
					if (!idList.Contains(id)) {
						idList.Add(id);
					}
				} else {
					var idList = new List<Guid>();
					idList.Add(id);
					_activityFolders.Add(name, idList);
				}
				if (!_activityFolders[name].Contains(mailBoxFolderId)) {
					_activityFolders[name].Add(mailBoxFolderId);
				}
			}
			_log.InfoFormat("[{0}] - Total folders for synchronization count \"{1}\"",
				_mailboxSyncSettings.SenderEmailAddress, _activityFolders.Count);
		}

		#endregion

		/// <summary>
		/// Flag indicates if activity is new.
		/// </summary>
		/// <param name="activity">Activity instance.</param>
		/// <param name="isMessageRead">Message read state.</param>
		/// <param name="folderName"><see cref="ActivityFolder"/> name.</param>
		/// <returns>True if activity is new.</returns>
		private bool IsNewActivity(Entity activity, bool isMessageRead, string folderName) {
			return !IsUpdateActivity(isMessageRead, activity, folderName);
		}

		/// <summary>
		/// Returns true if activity updated.
		/// </summary>
		/// <param name="isMessageRead">Message read state.</param>
		/// <param name="activity">Activity instance.</param>
		/// <param name="folderName"><see cref="ActivityFolder"/> name.</param>
		/// <returns>True, if activity updated.</returns>
		private bool IsUpdateActivity(bool isMessageRead, Entity activity, string folderName) {
			if (_userConnection.GetIsFeatureEnabled("MailboxRightsForEmail")) {
				return IsActivityExist(activity, folderName);
			}
			if (IsActivityExist(activity, folderName)) {
				if (isMessageRead) {
					UpdateActivityReadStatusForCurrentUser(activity.PrimaryColumnValue);
				}
				ActualizeActivityRelations(activity);
				return true;
			}
			return false;
		}

		private void SetCurrentLastSyncDate(string senderEmailAddress) {
			new Update(_userConnection, "MailboxSyncSettings")
				.Set("LastSyncDate", Column.Parameter(_startSyncDate))
				.Set("IsCustomFlagsNotSuported", Column.Parameter(true))
				.Where("SysAdminUnitId").IsEqual(Column.Parameter(_userConnection.CurrentUser.Id))
				.And("SenderEmailAddress").IsEqual(Column.Parameter(senderEmailAddress)).Execute();
			_log.Info(string.Format("[{0}] | Updating LastSyncDate. New value: {1}",
					senderEmailAddress, DateTime.UtcNow.ToString("dd-MMM-yyyy", CultureInfo.InvariantCulture)));
		}

		private void UpdateRightsForOutcomingEmail(Activity activity, MailMessageParticipants participants) {
			var senderId = GetUserByContact(participants.SenderContactId);
			var delete = new Delete(_userConnection)
				.From("SysActivityRight")
				.Where("RecordId")
					.IsEqual(Column.Parameter(activity.Id))
					.And("SysAdminUnitId")
					.IsNotEqual(Column.Parameter(senderId)) as Delete;
			delete.Execute();
		}

		/// <summary>
		/// Returns class factory binding key for <paramref name="mailboxSyncSettings"/>.
		/// </summary>
		/// <param name="mailboxSyncSettings"><see cref="MailboxSyncSettings"/> instance.</param>
		/// <returns>Sync strategy class factory binding key.</returns>
		private string GetStrategyName(MailboxSyncSettings mailboxSyncSettings) {
			string strategyName = string.Empty;
			strategyName = _settingsStrategy.IsNullOrEmpty() ? UidBasedSyncStrategyName : _settingsStrategy;
			_log.Info(string.Format("[{0}] | {1} selected.", mailboxSyncSettings.SenderEmailAddress, strategyName));
			return strategyName;
		}

		/// <summary>
		/// Select custom strategy bind key for current <see cref="MailServer"/>.
		/// </summary>
		/// <param name="mailServerId"><see cref="MailServer"/> unique identifier.</param>
		private void QueryStrategyName(Guid mailServerId) {
			var select = new Select(_userConnection).Top(1)
				.Column("Strategy")
				.From("MailServer")
				.Where("Id").IsEqual(Column.Parameter(mailServerId)) as Select;
			_settingsStrategy = select.ExecuteScalar<string>();
		}

		/// <summary>
		/// Sets <see cref="SyncSessionId"/> property value.
		/// </summary>
		private void InitSyncSessionId() {
			_synsSessionId = string.Format("ImapSyncSession_{0}", Guid.NewGuid());
		}

		#endregion

		#region Methods: Protected

		/// <summary>
		/// Sets email activity type uniqueidentifier.
		/// </summary>
		protected virtual void QueryEmailActivityType() {
			var activityTypeSchemaQuery = new EntitySchemaQuery(_userConnection.EntitySchemaManager, "ActivityType");
			var idQueryColumnName = activityTypeSchemaQuery.AddColumn("Id").Name;
			var filter = activityTypeSchemaQuery.CreateFilterWithParameters(FilterComparisonType.Equal, "Code", EmailActivityTypeCode);
			activityTypeSchemaQuery.Filters.Add(filter);
			var activityTypes = activityTypeSchemaQuery.GetEntityCollection(_userConnection);
			foreach (var activityType in activityTypes) {
				EmailActivityTypeId = activityType.GetTypedColumnValue<Guid>(idQueryColumnName);
			}
		}

		/// <summary>
		/// Adds roles in activity participant collection.
		/// </summary>
		protected virtual void QueryActivityParticipantRoles() {
			ActivityParticipantRoles = new Dictionary<string, Guid>();
			var activityParticipantRoleSchemaQuery = new EntitySchemaQuery(_userConnection.EntitySchemaManager, "ActivityParticipantRole");
			var idQueryColumnName = activityParticipantRoleSchemaQuery.AddColumn("Id").Name;
			var codeQueryColumnName = activityParticipantRoleSchemaQuery.AddColumn("Code").Name;
			var activityParticipantRoles = activityParticipantRoleSchemaQuery.GetEntityCollection(_userConnection);
			foreach (var activityParticipantRole in activityParticipantRoles) {
				var id = activityParticipantRole.GetTypedColumnValue<Guid>(idQueryColumnName);
				var code = activityParticipantRole.GetTypedColumnValue<string>(codeQueryColumnName);
				ActivityParticipantRoles.Add(code, id);
			}
		}

		/// <summary>
		/// Sets file type unique identifier.
		/// </summary>
		protected virtual void QueryFileTypes() {
			FileTypeId = Terrasoft.WebApp.FileConsts.FileTypeUId;
		}

		/// <summary>
		/// Sets sender email status unique identifier.
		/// </summary>
		protected virtual void QueryActivityStatuses() {
			var activityStatusSchemaQuery = new EntitySchemaQuery(_userConnection.EntitySchemaManager, ActivityStatusSchemaName);
			var idQueryColumnName = activityStatusSchemaQuery.AddColumn("Id").Name;
			var filter = activityStatusSchemaQuery.CreateFilterWithParameters(FilterComparisonType.Equal, "Code", "Finished");
			activityStatusSchemaQuery.Filters.Add(filter);
			var activityStatuses = activityStatusSchemaQuery.GetEntityCollection(_userConnection);
			foreach (var activityStatus in activityStatuses) {
				FinishedActvityStatusId = activityStatus.GetTypedColumnValue<Guid>(idQueryColumnName);
				break;
			}
			var emailSendStatusSchemaQuery = new EntitySchemaQuery(_userConnection.EntitySchemaManager, EmailSendStatusSchemaName);
			idQueryColumnName = emailSendStatusSchemaQuery.AddColumn("Id").Name;
			filter = emailSendStatusSchemaQuery.CreateFilterWithParameters(FilterComparisonType.Equal, "Code", "Sended");
			emailSendStatusSchemaQuery.Filters.Add(filter);
			var emailSendStatuses = emailSendStatusSchemaQuery.GetEntityCollection(_userConnection);
			foreach (var emailSendStatus in emailSendStatuses) {
				SendedEmailStatusId = emailSendStatus.GetTypedColumnValue<Guid>(idQueryColumnName);
				break;
			}
		}

		/// <summary>
		/// Sets email folders type unique edentifier.
		/// </summary>
		protected virtual void QueryEmailFolderTypeIds() {
			EmailSubfolderTypeId = FolderConsts.EmailFolderTypeId;
			MailBoxFolderTypeId = FolderConsts.MailboxFolderTypeId;
		}

		/// <summary>
		/// Gets flag indicates if email message is outcoming.
		/// </summary>
		/// <param name="message"><see cref="MailMessage"/> instance.</param>
		/// <returns>True,if email message is outcoming.</returns>
		protected virtual bool GetIsMessageOutcoming(MailMessage message) {
			int lastPointIndex = _credentials.Host.LastIndexOf(".");
			if (lastPointIndex == -1) {
				return false;
			}
			int lastButOnePointIndex = _credentials.Host.Substring(0, lastPointIndex).LastIndexOf(".");
			if (lastButOnePointIndex == -1) {
				return false;
			}
			string hostName = _credentials.Host.Substring(lastButOnePointIndex + 1);
			return message.From.Email == (_credentials.SenderEmailAddress.Contains('@') ?
				_credentials.SenderEmailAddress : string.Concat(_credentials.UserName, "@", hostName));
		}

		/// <summary>
		/// Gets <see cref="MailboxSyncSettings"/> instance by sender email address.
		/// </summary>
		/// <returns><see cref="MailboxSyncSettings"/> instance.</returns>
		protected virtual MailboxSyncSettings GetMailboxSyncSettings() {
			EntitySchema mailboxSynSettingsSchema = _userConnection.EntitySchemaManager.GetInstanceByName("MailboxSyncSettings");
			MailboxSyncSettings syncSettings = (MailboxSyncSettings)mailboxSynSettingsSchema.CreateEntity(_userConnection);
			syncSettings.FetchFromDB("SenderEmailAddress", _credentials.SenderEmailAddress, false);
			if (syncSettings.LastSyncDate != null) {
				syncSettings.LastSyncDate =
					(DateTime)_userConnection.DataValueTypeManager.GetInstanceByName("DateTime").GetValueForLoad(_userConnection,
						syncSettings.LastSyncDate.ToUniversalTime());
			} else {
				syncSettings.LastSyncDate = _userConnection.CurrentUser.GetCurrentDateTime().AddYears(-10);
			}
			QueryStrategyName(syncSettings.GetTypedColumnValue<Guid>("MailServerId"));
			return syncSettings;
		}

		/// <summary>
		/// Sets contacts fields in participants from message.
		/// </summary>
		/// <param name="message"><see cref="MailMessage"/> instance.</param>
		/// <param name="activity"><see cref="Activity"/> instance.</param>
		/// <param name="participants"><see cref="MailMessageParticipants"/> instance.</param>
		protected virtual void SetContactFields(MailMessage message, Activity activity, out MailMessageParticipants participants) {
			participants = new MailMessageParticipants {
				ToContactIds = new List<Guid>(),
				CcContactIds = new List<Guid>(),
				BccContactIds = new List<Guid>(),
				AllParticipantContactIds = new List<Guid>()
			};
			Guid contactId;
			activity.Sender = GetContactDisplayNameByEmail(message.From.Email, out contactId);
			if (contactId != Guid.Empty) {
				participants.AllParticipantContactIds.Add(contactId);
			}
			participants.SenderContactId = contactId;
			var sb = new StringBuilder();
			foreach (EmailAddress mailAddress in message.To) {
				sb.Append(GetContactDisplayNameByEmail(mailAddress.Email, out contactId));
				sb.Append("; ");
				if (!participants.ToContactIds.Contains(contactId)) {
					participants.ToContactIds.Add(contactId);
				}
				if (!participants.AllParticipantContactIds.Contains(contactId)) {
					participants.AllParticipantContactIds.Add(contactId);
				}
			}
			if (sb.Length > 1) {
				sb.Remove(sb.Length - 2, 2);
			}
			activity.Recepient = sb.ToString();
			sb.Clear();
			foreach (EmailAddress mailAddress in message.Cc) {
				sb.Append(GetContactDisplayNameByEmail(mailAddress.Email, out contactId));
				sb.Append("; ");
				if (!participants.CcContactIds.Contains(contactId)) {
					participants.CcContactIds.Add(contactId);
				}
				if (!participants.AllParticipantContactIds.Contains(contactId)) {
					participants.AllParticipantContactIds.Add(contactId);
				}
			}
			if (sb.Length > 1) {
				sb.Remove(sb.Length - 2, 2);
			}
			activity.CopyRecepient = sb.ToString();
			sb.Clear();
			foreach (EmailAddress mailAddress in message.Bcc) {
				sb.Append(GetContactDisplayNameByEmail(mailAddress.Email, out contactId));
				sb.Append("; ");
				if (!participants.BccContactIds.Contains(contactId)) {
					participants.BccContactIds.Add(contactId);
				}
				if (!participants.AllParticipantContactIds.Contains(contactId)) {
					participants.AllParticipantContactIds.Add(contactId);
				}
			}
			if (sb.Length > 1) {
				sb.Remove(sb.Length - 2, 2);
			}
			activity.BlindCopyRecepient = sb.ToString();
		}

		/// <summary>
		/// Sets <see cref="ImapClient"/> instance;
		/// </summary>
		/// <param name="userConnection"><see cref="UserConnection"/> instance.</param>
		/// <param name="credentials"><see cref="MailCredentials"/> instance.</param>
		/// <param name="mailboxSettingsId">Mailbox settings unique identifier.</param>
		/// <param name="login">Try login when imap client created flag.</param>
		protected virtual void SetImapClient(UserConnection userConnection, MailCredentials credentials, Guid mailboxSettingsId, bool login) {
			SynchronizationErrorHelper helper = SynchronizationErrorHelper.GetInstance(userConnection);
			try {
				_imapClient = new ImapClient(credentials, GetImapErrorMessages(userConnection), userConnection, mailboxSettingsId, login);
				if (login) {
					helper.CleanUpSynchronizationError(_mailboxSyncSettings.SenderEmailAddress);
				}
			} catch (Exception ex) {
				helper.ProcessSynchronizationError(_mailboxSyncSettings.SenderEmailAddress, ex);
				_log.ErrorFormat("Error on imapClient creation for {0}", ex, _mailboxSyncSettings.SenderEmailAddress);
			}
		}

		/// <summary>
		/// Initializes synchronizer properties.
		/// </summary>
		/// <param name="userConnection"><see cref="UserConnection"/> instance.</param>
		/// <param name="credentials"><see cref="MailCredentials"/> instance.</param>
		/// <param name="login">Try login when imap client created flag.</param>
		protected virtual void InitMailSynchronizer(UserConnection userConnection, MailCredentials credentials, bool login) {
			Guid mailboxSettingsId = Guid.Empty;
			if (login) {
				mailboxSettingsId = _mailboxSyncSettings.Id;
			}
			SetImapClient(userConnection, credentials, mailboxSettingsId, login);
			QueryEmailFolderTypeIds();
			QueryActivityStatuses();
			QueryFileTypes();
			QueryActivityParticipantRoles();
			QueryEmailActivityType();
		}

		/// <summary>
		/// Ensure provision of rights to e-mail.
		/// </summary>
		protected virtual void EnsureEmailRightsGranted() {
			EnsureEmailRightsGranted(_userConnection.CurrentUser.Id);
		}

		[Obsolete]
		protected virtual bool IsActivityExist(Activity activity, string folderName) {
			return IsActivityExist((Entity)activity, folderName);
		}

		/// <summary>
		/// Checks if activity exists.
		/// </summary>
		/// <param name="activity">Activity instance.</param>
		/// <param name="folderName"><see cref="ActivityFolder"/> name.</param>
		/// <returns>Flag indicates if activity exists.</returns>
		protected virtual bool IsActivityExist(Entity activity, string folderName) {
			List<Guid> emailIds = ActivityUtils.GetExistingEmaisIds(_userConnection,
				activity.GetTypedColumnValue<DateTime>("SendDate"), activity.GetTypedColumnValue<string>("Title"),
				activity.GetTypedColumnValue<string>("Body"), _userConnection.CurrentUser.TimeZone);
			if (_userConnection.GetIsFeatureEnabled("MailboxRightsForEmail")) {
				bool result = emailIds.Any();
				if (result) {
					activity.PrimaryColumnValue = emailIds.FirstOrDefault();
				}
				return result;
			}
			Guid idWithRights = emailIds.FirstOrDefault(id => activity.FetchFromDB(id, false));
			if (!emailIds.IsEmpty() && idWithRights.IsNotEmpty()) {
				_currentEmailActivityId = idWithRights;
				EnsureEmailRightsGranted();
				if (_activityFolders.ContainsKey(folderName)) {
					foreach (var emailFolderId in _activityFolders[folderName]) {
						EnsureActivityInFolder(emailFolderId);
					}
				}
				activity.StoringState = StoringObjectState.Changed;
				return true;
			}
			return false;
		}

		[Obsolete]
		protected virtual void ActualizeActivityRelations(Activity activity) {
			ActualizeActivityRelations((Entity)activity);
		}

		/// <summary>
		/// Calls <see cref="ActivityUtils.SetEmailRelations(UserConnection, Entity)"/> method
		/// for <paramref name="activity"/>.
		/// </summary>
		/// <param name="activity">Activity instance.</param>
		/// <remarks>External dependency relocation.</remarks>
		protected virtual void ActualizeActivityRelations(Entity activity) {
			ActivityUtils.SetEmailRelations(_userConnection, activity);
		}

		/// <summary>
		/// Synchronizes single e-mail message.
		/// </summary>
		/// <param name="message"><see cref="MailBee.ImapMail.MailMessage"/> header instance.</param>
		/// <param name="envelope"><see cref="MailBee.ImapMail.Envelope"/> instance.</param>
		/// <param name="isMessageRead">Message read state.</param>
		/// <param name="folderName"><see cref="ActivityFolder"/> name.</param>
		/// <returns>
		/// True if new Activity was created, false if new Activity wasn't created because the message is duplicated.
		/// </returns>
		public virtual bool SyncAction(MailMessage message, Envelope envelope, bool isMessageRead, string folderName) {
			var folderIds = new List<Guid>();
			if (_activityFolders.ContainsKey(folderName)) {
				folderIds = _activityFolders[folderName];
			}
			_currentEmailActivityId = Guid.NewGuid();
			MailMessageParticipants participants;
			var emailFolderId = folderIds.Count == 0 ? Guid.Empty : folderIds[0];
			Entity activity = CreateActivityByMessage(message, envelope, emailFolderId, out participants);
			if (!IsNewActivity(activity, isMessageRead, folderName)) {
				CreateEmailMessageData(activity, message);
				_log.InfoFormat("Message {0} already exists.", activity.GetTypedColumnValue<string>("Title"));
				return false;
			}
			var activityFiles = new Dictionary<Entity, Func<byte[]>>();
			if (message.HasAttachments) {
				string htmlBodyWithCorrectInlineImgUrls = activity.GetTypedColumnValue<string>("Body");
				AddAttachmentsToActivity(_userConnection, message, ref htmlBodyWithCorrectInlineImgUrls, activityFiles);
				activity.SetColumnValue("Body", htmlBodyWithCorrectInlineImgUrls);
			}
			SaveActivity(activity);
			SaveActivityFiles(activityFiles.Keys.ToList());
			UploadActivityFilesData(_userConnection, activityFiles);
			CreateEmailMessageData(activity, message);
			if (isMessageRead) {
				UpdateActivityReadStatusForCurrentUser(activity.PrimaryColumnValue);
			}

			foreach (var folderId in folderIds) {
				EnsureActivityInFolder(folderId);
			}
			if (participants.AllParticipantContactIds.Count > 0) {
				var userIds = GetUsersByContacts(participants.AllParticipantContactIds);
				foreach (var userId in userIds) {
					EnsureEmailRightsGranted(userId);
				}
			}
			return true;
		}

		[Obsolete]
		protected virtual void SaveActivity(Activity activity) {
			SaveActivity((Entity)activity);
		}

		/// <summary>
		/// Saves activity.
		/// </summary>
		/// <param name="activity"><see cref="Activity"/>instance.</param>
		protected virtual void SaveActivity(Entity activity) {
			activity.Save();
			_log.Info(string.Format("Message {0} saved. Activity Id: {1}.",
				activity.GetTypedColumnValue<string>("Title"), activity.PrimaryColumnValue));
		}

		[Obsolete]
		protected virtual void CreateEmailMessageData(Activity activity, MailMessage message) {
			CreateEmailMessageData((Entity)activity, message);
		}

		/// <summary>
		/// Creates <see cref="EmailMessageData"/> instance for <paramref name="activity"/> in current mailbox.
		/// </summary>
		/// <param name="activity"><see cref="Activity"/> instance.</param>
		/// <param name="message"><see cref="MailMessage"/> instance.</param>
		protected virtual void CreateEmailMessageData(Entity activity, MailMessage message) {
			var ticks = ActivityUtils.GetSendDateTicks(_userConnection, activity);
			Dictionary<string, string> headers = new Dictionary<string, string> {
				{ "MessageId", message.Headers["Message-Id"] },
				{ "InReplyTo", message.Headers["In-Reply-To"] },
				{ "References", message.Headers["References"] },
				{ "SyncSessionId", SynsSessionId },
				{ "ThreadIndex", message.Headers["Thread-Index"] },
				{ "SendDateTicks", ticks.ToString() }
			};
			MessageHelper.CreateEmailMessage(activity, _mailboxSyncSettings.PrimaryColumnValue, headers);
		}

		/// <summary>
		/// Saves activity files.
		/// </summary>
		/// <param name="activityFiles">List activity files.</param>
		protected virtual void SaveActivityFiles(List<Entity> activityFiles) {
			activityFiles.ForEach(file => file.Save());
		}

		/// <summary>
		/// Obsolete. Use <see cref="AutoEmailRelation"/> features.
		/// </summary>
		protected virtual void SetDefValuesFromFolderSettings(Activity activity, Guid emailFolderId) {
		}

		/// <summary>
		/// Creates <see cref="ActivityFile"/> instance.
		/// </summary>
		/// <param name="schema">Entity schema.</param>
		/// <param name="userConnection">User connection.</param>
		/// <returns><see cref="ActivityFile"/> instance.</returns>
		protected virtual ActivityFile CreateActivityFile(EntitySchema schema, UserConnection userConnection) {
			return schema.CreateEntity(userConnection) as ActivityFile;
		}

		/// <summary>
		/// Gets date received property from <paramref name="envelope"/>
		/// </summary>
		/// <param name="envelope"><see cref="Envelope"/> instance.</param>
		/// <returns>Date received property.</returns>
		protected virtual DateTime GetEnvelopeDataReceived(Envelope envelope) {
			return (envelope == null) ? DateTime.MinValue : envelope.DateReceived;
		}

		/// <summary>
		/// Gets date property from <paramref name="envelope"/>
		/// </summary>
		/// <param name="envelope"><see cref="Envelope"/> instance.</param>
		/// <returns>Date received property.</returns>
		protected virtual DateTime GetEnvelopeData(Envelope envelope) {
			return (envelope == null) ? DateTime.MinValue : envelope.Date;
		}

		protected virtual Activity CreateActivityByMessage(MailMessage message, Envelope envelope, Guid emailFolderId, out MailMessageParticipants participants) {
			EntitySchema activitySchema = _userConnection.EntitySchemaManager.GetInstanceByName(ActivitySchemaName);
			Activity activity = activitySchema.CreateEntity(_userConnection) as Activity;
			activity.SetDefColumnValues();
			activity.Id = _currentEmailActivityId;
			SetContactFields(message, activity, out participants);
			activity.Title = ActivityUtils.FixActivityTitle(message.Subject, _userConnection);
			activity.PriorityId = PriorityMapping[message.Priority];
			activity.ActivityCategoryId = ActivityCategoryId;
			activity.HeaderProperties = HeaderPropertiesToString(message.Headers);
			if (message.Priority == MailPriority.None && message.Importance != MailPriority.None) {
				activity.PriorityId = PriorityMapping[message.Importance];
			}
			activity.IsHtmlBody = !string.IsNullOrEmpty(message.BodyHtmlText);
			activity.Body = activity.IsHtmlBody ? message.BodyHtmlText : message.BodyPlainText;
			activity.TypeId = EmailActivityTypeId;
			if (GetIsMessageOutcoming(message)) {
				activity.MessageTypeId = OutcomingMessageTypeId;
				activity.OwnerId = participants.SenderContactId == Guid.Empty ?
					_userConnection.CurrentUser.ContactId : participants.SenderContactId;
			} else {
				activity.MessageTypeId = IncomingMessageTypeId;
				activity.OwnerId = _userConnection.CurrentUser.ContactId;
			}
			activity.AuthorId = _userConnection.CurrentUser.ContactId;
			DateTime sendDate = GetEnvelopeData(envelope);
			if (sendDate.Kind == DateTimeKind.Utc) {
				sendDate = TimeZoneInfo.ConvertTimeFromUtc(sendDate, _userConnection.CurrentUser.TimeZone);
			} else {
				sendDate = TimeZoneInfo.ConvertTimeFromUtc(sendDate.ToUniversalTime(), _userConnection.CurrentUser.TimeZone);
			}
			activity.SendDate = sendDate;
			DateTime dateReceived = GetEnvelopeDataReceived(envelope);
			if (dateReceived.Kind == DateTimeKind.Utc) {
				dateReceived = TimeZoneInfo.ConvertTimeFromUtc(dateReceived, _userConnection.CurrentUser.TimeZone);
			} else {
				dateReceived = TimeZoneInfo.ConvertTimeFromUtc(dateReceived.ToUniversalTime(), _userConnection.CurrentUser.TimeZone);
			}
			activity.StartDate = dateReceived;
			activity.DueDate = dateReceived;
			activity.StatusId = FinishedActvityStatusId;
			activity.EmailSendStatusId = SendedEmailStatusId;
			activity.MailHash = ActivityUtils.GetEmailHash(_userConnection, activity.SendDate, activity.Title, activity.Body,
				_userConnection.CurrentUser.TimeZone);
			return activity;
		}

		/// <summary>
		/// Combines <paramref name="HeaderCollection"/>  items into one string.
		/// </summary>
		/// <remarks>Item format is <c>Name <PropertyName> = <c>Value <Value>;</c></remarks>
		/// <param name="EmailMessage"><see cref="xchange.EmailMessage"/> instance.</param>
		/// <returns>Formated HeaderProperties string.</returns>
		protected virtual string HeaderPropertiesToString(HeaderCollection messageHeaders) {
			var headerProperties = new StringBuilder();
			foreach (Header property in messageHeaders) {
				headerProperties.Append(property.Name + "=" + property.Value + "\n");
			}
			return headerProperties.ToString();
		}

		/// <summary>
		/// Sets <see cref="MailSynchronizer._startSyncDate"/> field value.
		/// </summary>
		/// <remarks>
		/// External dependency realocation.
		/// </remarks>
		protected virtual void SetStartSyncDate() {
			_startSyncDate = DateTime.UtcNow;
		}

		/// <summary>
		/// Sets <see cref="_isDateBasedStrategy"/> field value.
		/// </summary>
		/// <remarks><c>True</c> if strategy <see cref="DateBasedSentSinceSyncStrategy"/> 
		/// or <see cref="DateBasedSyncStrategy"/> class instance, <c>false</c> otherwise.</remarks>
		protected virtual void SetIsDateBasedStrategy() {
			ISyncStrategy strategy = _imapClient.Strategy;
			bool isDateBasedSentSinceSyncStrategy = strategy is DateBasedSentSinceSyncStrategy;
			bool isDateBasedSyncStrategy = strategy is DateBasedSyncStrategy;
			_isDateBasedStrategy = isDateBasedSentSinceSyncStrategy || isDateBasedSyncStrategy;
		}

		/// <summary>
		/// Sends synchronization session finish message.
		/// </summary>
		protected virtual void SendSyncSessionFinished() {
			MessageHelper.SendSyncSessionFinished(SynsSessionId);
		}

		#endregion

		#region Methods: Public

		/// <summary>
		/// Creates synchronization job.
		/// </summary>
		/// <param name="userConnection">User connection.</param>
		/// <param name="periodInMinutes">Synchronization interval.</param>
		/// <param name="parameters">Synchronization parameters.</param>
		public static void CreateSyncJob(UserConnection userConnection, int periodInMinutes,
				IDictionary<string, object> parameters = null) {
			if (periodInMinutes <= 0) {
				throw new ArgumentOutOfRangeException("periodInMinutes");
			}
			RemoveSyncJob(userConnection, parameters);
			string syncJobName = GetSyncJobName(userConnection, parameters);
			_log.ErrorFormat("ScheduleMinutelyJob called: CurrentUser {0}, SyncJobName {1}",
				userConnection.CurrentUser.Name, syncJobName);
			AppScheduler.ScheduleMinutelyJob(syncJobName, SyncJobGroupName, SyncProcessName,
				userConnection.Workspace.Name, userConnection.CurrentUser.Name, periodInMinutes, parameters);
		}

		/// <summary>
		/// Removes synchronization job.
		/// </summary>
		/// <param name="userConnection">User connection.</param>
		/// <param name="parameters">Synchronization parameters.</param>
		public static void RemoveSyncJob(UserConnection userConnection,
				IDictionary<string, object> parameters = null) {
			string[] syncJobNames = new string[] {
				GetSyncJobName(userConnection),
				GetSyncJobName(userConnection, parameters)
			};
			string trace = string.Empty;
			try {
				var stackTrace = new System.Diagnostics.StackTrace(false);
				trace = stackTrace.ToString();
			} catch {
			}
			foreach (string syncJobName in syncJobNames) {
				_log.ErrorFormat("RemoveJob called: CurrentUser {0}, SyncJobName {1}. Trace: {2}",
					userConnection.CurrentUser.Name, syncJobName, trace);
				AppScheduler.RemoveJob(syncJobName, SyncJobGroupName);
			}
		}

		/// <summary>
		/// Check if sync job exists.
		/// </summary>
		/// <param name="userConnection"><see cref="UserConnection"/> instance.</param>
		/// <param name="parameters">Job parameters collection.</param>
		/// <returns><c>True</c> if job exists. Otherwise returns <c>false</c>.</returns>
		public static bool DoesSyncJobExist(UserConnection userConnection, IDictionary<string, object> parameters = null) {
			string syncJobName = GetSyncJobName(userConnection, parameters);
			return AppScheduler.DoesJobExist(syncJobName, SyncJobGroupName);
		}

		/// <summary>
		/// Starts imap mail synchronization session.
		/// </summary>
		public void SyncImapMail() {
			if (_imapClient == null) {
				_log.ErrorFormat(string.Concat("ImapClient SyncImapMail _imapClient is null for {0}. ",
					"Probably was timeout error when trying create connection to IMAP server"),
					_mailboxSyncSettings.SenderEmailAddress);
				return;
			}
			SetStartSyncDate();
			_log.Info(string.Format("-------------------------------------- Sync session for {0} started --------------------------------------",
				_mailboxSyncSettings.SenderEmailAddress));
			var mailBoxActivityFolderId = GetMailboxActivityFolderIdByName(_mailboxSyncSettings.MailboxName);
			_log.InfoFormat("[{0}] - Mailbox name \"{1}\", ActivityFolderId = \"{2}\"",
				_mailboxSyncSettings.SenderEmailAddress, _mailboxSyncSettings.MailboxName, mailBoxActivityFolderId);
			QueryCrmFolders(mailBoxActivityFolderId);
			_imapClient.EnforceFoldersStructure(_activityFolders.Keys);
			if (_mailboxSyncSettings.LoadAllEmailsFromMailBox) {
				_activityFolders = new Dictionary<string, List<Guid>> {
					{
						ImapClient.BPMonlineFolderName, new List<Guid> {
							mailBoxActivityFolderId
						}
					}
				};
			}
			string strategyName = GetStrategyName(_mailboxSyncSettings);
			_imapClient.Strategy = ClassFactory.Get<ISyncStrategy>(strategyName, new ConstructorArgument("userConnection", _userConnection),
				new ConstructorArgument("syncSettings", _mailboxSyncSettings));
			SetIsDateBasedStrategy();
			_imapClient.SyncMailMessages(SyncAction, _activityFolders, _mailboxSyncSettings.LoadAllEmailsFromMailBox);
			if (_isDateBasedStrategy) {
				SetCurrentLastSyncDate(_mailboxSyncSettings.SenderEmailAddress);
			}
			_log.Info(string.Format("-------------------------------------- Sync session for {0} ended --------------------------------------",
					_mailboxSyncSettings.SenderEmailAddress));
			RemoteChangesCount = _imapClient.RemoteChangesCount;
			SendSyncSessionFinished();
		}

		public void ValidateImapServer() {
		}

		public void ValidateImapClient() {
			ValidateImapServer();
		}

		public static ImapErrorMessages GetImapErrorMessages(UserConnection _userConnection) {
			var result = new ImapErrorMessages();
			result.LocCanNotConnect = new LocalizableString(_userConnection.ResourceStorage, "ImapClient",
				"LocalizableStrings.LocCanNotConnect.Value").ToString();
			result.LocServerNotSupportSslConnection = new LocalizableString(_userConnection.ResourceStorage, "ImapClient",
				"LocalizableStrings.LocServerNotSupportSslConnection.Value").ToString();
			result.LocLoginOrPwdWrong = new LocalizableString(_userConnection.ResourceStorage, "ImapClient",
				"LocalizableStrings.LocLoginOrPwdWrong.Value").ToString();
			result.LocSyncError = new LocalizableString(_userConnection.ResourceStorage, "ImapClient",
				"LocalizableStrings.LocSyncError.Value").ToString();
			return result;
		}

		public void StartIdle() {
		}

		public void Dispose() {
			_imapClient?.Dispose();
		}

		public void Init(UserConnection userConnection, MailCredentials credentials, bool login = true) {
			_userConnection = userConnection;
			_credentials = credentials;
			_imapClient = new ImapClient(credentials, GetImapErrorMessages(userConnection), userConnection, _mailboxSyncSettings.Id, login);
			QueryEmailFolderTypeIds();
			QueryActivityStatuses();
			QueryFileTypes();
			QueryActivityParticipantRoles();
			QueryEmailActivityType();
		}

		#endregion

	}

	#endregion
}
