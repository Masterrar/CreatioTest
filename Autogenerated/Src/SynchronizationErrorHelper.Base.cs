﻿namespace Terrasoft.Configuration
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using IntegrationApi.Interfaces;
	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using Terrasoft.Common;
	using Terrasoft.Common.Json;
	using Terrasoft.Core;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Factories;
	using Terrasoft.Mail;
	using Terrasoft.Messaging.Common;

	#region Class: SynchronizationErrorHelper

	[DefaultBinding(typeof(ISynchronizationErrorHelper))]
	public class SynchronizationErrorHelper : ISynchronizationErrorHelper
	{

		#region Fields: Private

		/// <summary>
		/// <see cref="EntitySchemaManager"/> instance.
		/// </summary>
		private EntitySchemaManager _schemaManager;

		/// <summary>
		/// Synchronization error handler cache name.
		/// </summary>
		private readonly string _errorHandlersCacheName = "SynchronizationHandlers";

		#endregion

		#region Constructors: Public

		/// <summary>
		/// Constructor. Sets reference to <see cref="Terrasoft.Core.UserConnection"/> instance.
		/// </summary>
		/// <param name="userConnection"><see cref="Terrasoft.Core.UserConnection"/> instance.</param>
		public SynchronizationErrorHelper(UserConnection userConnection) {
			UserConnection = userConnection;
			_schemaManager = userConnection.EntitySchemaManager;
		}

		#endregion

		#region Properties: Protected

		/// <summary>
		/// <see cref="UserConnection"/> instance.
		/// </summary>
		protected UserConnection UserConnection { get; set; }

		#endregion

		#region Method: Private
		/// <summary>
		/// Update synchronization error code and corresponding message to the <see cref="MailboxSyncSettings"/> entity.
		/// </summary>
		/// <param name="mailbox"><see cref="Terrasoft.Core.Entities.Entity"/> instance of <see cref="MailboxSyncSettings"/> entity.</param>
		private void UpdateErrorCode(Entity mailbox) {
			Guid? errorCodeValue = mailbox.GetTypedColumnValue<Guid>("ErrorCodeId") == Guid.Empty
				? (Guid?) null
				: mailbox.GetTypedColumnValue<Guid>("ErrorCodeId");
			var guidDataValueType = new GuidDataValueType(UserConnection.DataValueTypeManager);
			Update update = new Update(UserConnection, mailbox.SchemaName)
							.Set("ErrorCodeId", Column.Parameter(errorCodeValue, guidDataValueType))
							.Set("RetryCounter", Column.Parameter(mailbox.GetTypedColumnValue<int>("RetryCounter")))
							.Set("SynchronizationStopped", Column.Parameter(mailbox.GetTypedColumnValue<bool>("SynchronizationStopped")))
							.Where("Id").IsEqual(Column.Parameter(mailbox.PrimaryColumnValue)) as Update;
			update.Execute();
		}

		#endregion

		#region Methods: Protected

		/// <summary>
		/// Gets <see cref="IMsgChannel"/> instance for <paramref name="sysAdminUnitId"/>.
		/// </summary>
		/// <param name="sysAdminUnitId"><see cref="SysAdminUnit"/> instance unique identifier.</param>
		/// <returns><see cref="IMsgChannel"/> instance.</returns>
		protected virtual IMsgChannel GetMessageChannel(Guid sysAdminUnitId) {
			return MsgChannelManager.Instance.FindItemByUId(sysAdminUnitId);
		}

		/// <summary>
		/// Returns <see cref="SyncErrorMessage"/> instance filtered by <paramref name="errorCode"/>.z
		/// </summary>
		/// <param name="errorCode"><see cref="SyncErrorMessage.Code"/> column value.</param>
		/// <returns><see cref="SyncErrorMessage"/> instance.</returns>
		protected Entity GetSyncErrorMessageByCode(Guid errorCodeId) {
			EntitySchema syncErrorMessageSchema = _schemaManager.GetInstanceByName("SyncErrorMessage");
			Entity syncErrorMessage = syncErrorMessageSchema.CreateEntity(UserConnection);
			if (syncErrorMessage.FetchFromDB(errorCodeId, false)) {
				return syncErrorMessage;
			}
			return null;
		}

		/// <summary>
		/// Creates json message with error info.
		/// </summary>
		/// <param name="mailbox"><see cref="MailboxSyncSettings"/> instance.</param>
		/// <returns>Json string.</returns>
		protected virtual string GetErrorMessage(Entity mailbox) {
			Guid? errorCodeId = mailbox.GetColumnValue("ErrorCodeId") as Guid?;
			Guid mailboxId = mailbox.PrimaryColumnValue;
			string mailboxName = mailbox.GetTypedColumnValue<string>("SenderEmailAddress");
			JObject message = new JObject();
			message["MailboxId"] = mailboxId.ToString();
			if (errorCodeId.HasValue) {
				Entity syncErrorMessage = GetSyncErrorMessageByCode(errorCodeId.Value);
				if (syncErrorMessage != null) {
					string userText = syncErrorMessage.GetTypedColumnValue<string>("UserMessage");
					message["UserMessage"] = userText;
				}
			}
			return Json.FormatJsonString(Json.Serialize(message), Formatting.Indented);
		}

		/// <summary>
		/// Retrieves <see cref="SysAdminUnit"/> identifiers list.
		/// </summary>
		/// <param name="mailbox"><see cref="MailboxSyncSettings"/> instance.</param>
		/// <returns><see cref="SysAdminUnit"/> identifiers list.</returns>
		protected virtual IEnumerable<Guid> GetMailboxOwners(Entity mailbox) {
			return ContactUtilities.GetUsersByEmails(UserConnection, new List<string> {
				mailbox.GetTypedColumnValue<string>("SenderEmailAddress")
			}).Select(kvp => kvp.Key);
		}

		/// <summary>
		/// Sends error notification to users.
		/// </summary>
		/// <param name="mailbox"><see cref="MailboxSyncSettings"/> instance.</param>
		protected virtual void SendErrorNotification(Entity mailbox) {
			string message = GetErrorMessage(mailbox);
			if (message.IsNullOrEmpty()) {
				return;
			}
			foreach (Guid subscriberId in GetMailboxOwners(mailbox)) {
				IMsgChannel channel = GetMessageChannel(subscriberId);
				if (channel == null) {
					continue;
				}
				var simpleMessage = new SimpleMessage();
				simpleMessage.Body = message;
				simpleMessage.Id = channel.Id;
				simpleMessage.Header.Sender = "SynchronizationError";
				channel.PostMessage(simpleMessage);
			}
		}

		/// <summary>
		/// Returns mailbox synchronization setting for the specific sender email address.
		/// </summary>
		/// <param name="senderEmailAddress">Sender email address.</param>
		/// <returns><see cref="Terrasoft.Core.Entities.Entity"/> instance of <see cref="MailboxSyncSettings"/> entity type.</returns>
		protected virtual Entity GetMailboxSynSettingEntity(string senderEmailAddress) {
			EntitySchema entitySchema = _schemaManager.GetInstanceByName("MailboxSyncSettings");
			Entity mailbox = entitySchema.CreateEntity(UserConnection);
			return mailbox.FetchFromDB("SenderEmailAddress", senderEmailAddress, false) ? mailbox : null;
		}

		/// <summary>
		/// Returns synchronization error handler by error code.
		/// </summary>
		/// <param name="errorCodeId">Specific error code identifier.</param>
		/// <returns><see cref="Terrasoft.Core.Entities.Entity"/> instance of <see cref="MailboxSyncSettings"/> entity type.</returns>
		protected virtual EntityCollection GetSyncErrorHandlers() {
			EntitySchemaQuery esq = new EntitySchemaQuery(_schemaManager, "SyncErrorHandler");
			esq.CacheItemName = _errorHandlersCacheName;
			esq.AddColumn("ExceptionClass");
			esq.AddColumn("MessageFilter");
			esq.AddColumn("RetryCount");
			esq.AddColumn("ErrorCode");
			EntityCollection handlers = esq.GetEntityCollection(UserConnection);
			return handlers;
		}

		/// <summary>
		/// Writes synchronization error code and corresponding message to the <see cref="MailboxSyncSettings"/> entity.
		/// </summary>
		/// <param name="mailbox"><see cref="Terrasoft.Core.Entities.Entity"/> instance of <see cref="MailboxSyncSettings"/> entity.</param>
		/// <param name="errorCodeId">Error code.</param>
		/// <param name="errorMessage">Error message.</param>
		protected virtual void WriteErrorCode(Entity mailbox, Guid? errorCodeId, bool synchronizationStopped = false) {
			mailbox.SetColumnValue("ErrorCodeId", errorCodeId);
			mailbox.SetColumnValue("RetryCounter", 0);
			mailbox.SetColumnValue("SynchronizationStopped", synchronizationStopped);
			UpdateErrorCode(mailbox);
			SendSynchronizationStatus(mailbox);
		}

		/// <summary>
		/// Updates the counter of retry synchronization attempts.
		/// </summary>
		/// <param name="mailbox"><see cref="Terrasoft.Core.Entities.Entity"/> instance of <see cref="MailboxSyncSettings"/> entity.</param>
		/// <param name="counter">New counter value.</param>
		protected virtual void UpdateRetryCounter(Entity mailbox, int counter) {
			mailbox.SetColumnValue("RetryCounter", counter);
			mailbox.Save();
		}

		/// <summary>
		/// Returns mail server type identifier for the specific server.
		/// </summary>
		/// <param name="serverId">Mail server identifier.</param>
		/// <returns><see cref="System.Guid"/> instance.</returns>
		protected virtual Guid GetServerTypeId (Guid serverId) {
			EntitySchema schema = _schemaManager.GetInstanceByName("MailServer");
			Entity server = schema.CreateEntity(UserConnection);
			if (server.FetchFromDB(serverId, false)) {
				return server.GetTypedColumnValue<Guid>("TypeId");
			} else {
				return Guid.Empty;
			}
		}

		/// <summary>
		/// Stops synchronization process for the specific sender email.
		/// </summary>
		/// <param name="senderEmailAddress">Sender email address.</param>
		/// <param name="serverTypeId">Mail server type identifier.</param>
		protected virtual void StopSyncProcess(string senderEmailAddress, Guid serverTypeId) {
			var parameters = new Dictionary<string, object> {
						{ "SenderEmailAddress", senderEmailAddress },
						{ "CurrentUserId", UserConnection.CurrentUser.Id }
					};
			MailSynchronizer.RemoveSyncJob(UserConnection, parameters);
		}

		#endregion

		#region Methods: Public

		/// <summary>
		/// Returns <see cref="Terrasoft.Configuration.SynchronizationErrorHelper"/> instance.
		/// </summary>
		/// <param name="userConnection"><see cref="Terrasoft.Core.UserConnection"/> instance.</param>
		/// <returns>Return new <see cref="Terrasoft.Configuration.SynchronizationErrorHelper"/> instance.</returns>
		public static SynchronizationErrorHelper GetInstance(UserConnection userConnection) {
			ConstructorArgument argument = new ConstructorArgument("userConnection", userConnection);
			return ClassFactory.Get<SynchronizationErrorHelper>(argument);
		}

		/// <summary>
		/// Sends error notification to mailbox owners.
		/// </summary>
		/// <param name="mailbox"><see cref="MailboxSyncSettings"/> instance.</param>
		public void SendSynchronizationStatus(Entity mailbox) {
			SendErrorNotification(mailbox);
		}

		/// <summary>
		/// Processes synchronization error.
		/// </summary>
		/// <param name="senderEmailAddress">Specific sender email address.</param>
		/// <param name="syncExeption">An <see cref="Exception"/> occurred during synchronization.</param>
		/// <param name="ignoreMaxRetryCount">Ignore RetryCount option.</param>
		public virtual void ProcessSynchronizationError(string senderEmailAddress, Exception syncExeption, bool ignoreMaxRetryCount = false) {
			string exceptionClassName = syncExeption.GetType().ToString();
			string exceptionMessage = syncExeption.Message;
			ProcessSynchronizationError(senderEmailAddress, exceptionClassName, exceptionMessage, ignoreMaxRetryCount);
		}

		/// <summary>
		/// Processes synchronization error.
		/// </summary>
		/// <param name="senderEmailAddress">Specific sender email address.</param>
		/// <param name="exceptionClassName">Exception classname.</param>
		/// <param name="exceptionMessage">Exception message.</param>
		/// <param name="ignoreMaxRetryCount">Ignore RetryCount option.</param>
		public virtual void ProcessSynchronizationError (string senderEmailAddress, string exceptionClassName,
				string exceptionMessage, bool ignoreMaxRetryCount = false) {
			EntityCollection handlers = GetSyncErrorHandlers();
			IEnumerable<Entity> filteredHandlers = handlers
				.Where(h => h.GetTypedColumnValue<string>("ExceptionClass").IsNotNullOrEmpty()
						&& exceptionClassName.EndsWith(h.GetTypedColumnValue<string>("ExceptionClass"), StringComparison.InvariantCultureIgnoreCase));
			Entity errorHandler = filteredHandlers
				.FirstOrDefault(h => h.GetTypedColumnValue<string>("MessageFilter").IsNotNullOrEmpty()
						&& exceptionMessage.Contains(h.GetTypedColumnValue<string>("MessageFilter")));
			if (errorHandler == null) {
				errorHandler = filteredHandlers
					.FirstOrDefault(h => h.GetTypedColumnValue<string>("MessageFilter").IsNullOrEmpty());
			}
			var mailbox = GetMailboxSynSettingEntity(senderEmailAddress);
			if (mailbox == null) {
				return;
			}
			if (errorHandler != null) {
				int maxRetryCount = errorHandler.GetTypedColumnValue<int>("RetryCount");
				Guid? currentErrorCodeId = mailbox.GetColumnValue("ErrorCodeId") as Guid?;
				Guid errorCodeId = errorHandler.GetTypedColumnValue<Guid>("ErrorCodeId");
				if (currentErrorCodeId.HasValue && currentErrorCodeId.Value.Equals(errorCodeId)) {
					return;
				}
				int attemptNumber = mailbox.GetTypedColumnValue<int>("RetryCounter");
				Guid serverId = mailbox.GetTypedColumnValue<Guid>("MailServerId");
				Guid serverTypeId = GetServerTypeId(serverId);
				if (!ignoreMaxRetryCount && maxRetryCount > -1 && attemptNumber < maxRetryCount) {
					UpdateRetryCounter(mailbox, ++attemptNumber);
					return;
				}
				var stopped = false;
				if (maxRetryCount > -1 && (ignoreMaxRetryCount || attemptNumber >= maxRetryCount)) {
					stopped = true;
					StopSyncProcess(senderEmailAddress, serverTypeId);
				}
				WriteErrorCode(mailbox, errorCodeId, stopped);
			}
		}

		/// <summary>
		/// Clears synchronization error information.
		/// </summary>
		/// <param name="senderEmailAddress">Specific sender email address.</param>
		public virtual void CleanUpSynchronizationError (string senderEmailAddress) {
			EntitySchema entitySchema = _schemaManager.GetInstanceByName("MailboxSyncSettings");
			Entity mailbox = entitySchema.CreateEntity(UserConnection);
			if (mailbox.FetchFromDB("SenderEmailAddress", senderEmailAddress, false)) {
				object actualErroCode = mailbox.GetColumnValue("ErrorCodeId");
				Guid? errorCodeId = actualErroCode as Guid?;
				if (errorCodeId.HasValue) {
					WriteErrorCode(mailbox, null);
				}
			}
		}

		#endregion

	}

	#endregion

}

