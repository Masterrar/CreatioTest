namespace Terrasoft.Configuration {
	using System;
	using System.Collections.Generic;
	using System.Globalization;
	using System.Linq;
	using System.Text.RegularExpressions;
	using System.Threading;
	using System.Threading.Tasks;
	using Terrasoft.Configuration.CES;
	using Terrasoft.Configuration.CESModels;
	using DynamicContent;
	using DynamicContent.Models;
	using Terrasoft.Common;
	using Terrasoft.Configuration.Mailing;
	using Terrasoft.Configuration.Marketing.Utilities;
	using Terrasoft.Core;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Factories;
	using Utils;

	#region Class: CESMaillingProvider

	/// <summary>
	/// Class for work with cloud email service.
	/// </summary>
	public class CESMaillingProvider : ISessionedMailingProvider, IConfigurableMailingProvider, ITestMessageProvider {

		#region Constants: Private

		private const int MassMailingRecipientsLimit = 20000;

		private const int MailingServicePingAttemptsCount = 3;

		private const int MailingServicePingTimeout = 10000;

		private const int ThreadFactor = 2;

		private const int MaxThreadCount = 8;

		private const string MassMailingTag = "mass_mailing";

		private const string TriggeredEmailTag = "triggered_email";

		private const int MailingMaxTemplateSize = 5242880;

		private const string SelectForInsertMassMailing = "SELECT '{0}','{1}','{2}','{3}','{4}'";

		private const string SelectForInsertMassMailingOracle = "SELECT '{{{0}}}','{1}','{2}','{3}','{4}' FROM dual";

		#endregion

		#region Fields: Private

		private IMailingAudienceDataSource _audienceDataSource;

		private Guid _mailingSessionId = Guid.Empty;

		private bool? _isDcBulkEmail = null;

		private BulkEmailRecipientValidator _recipientsValidator;

		#endregion

		#region Constructors: Public

		/// <summary>
		/// Initializes a new instance of the <see cref="CESMaillingProvider"/> class.
		/// </summary>
		public CESMaillingProvider() {
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="CESMaillingProvider"/> class.
		/// Instance of the provider will be configured by calling Configure method.
		/// </summary>
		/// <param name="userConnection">Current user connection.</param>
		public CESMaillingProvider(UserConnection userConnection) {
			UserConnection = userConnection;
			_isDCFeatureEnabled = UserConnection.GetIsFeatureEnabled("BulkEmailDynamicContentBuilder");
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="CESMaillingProvider"/> class.
		/// Use this constructor to initialize instnce by provider config parameter.
		/// </summary>
		/// <param name="userConnection">Current user connection.</param>
		/// <param name="configFactory">The configuration factory, instance of the <see cref="IMailingProviderConfigFactory"/></param>
		public CESMaillingProvider(UserConnection userConnection, IMailingProviderConfigFactory configFactory)
			: this(userConnection) {
			if (configFactory == null) {
				return;
			}
			IMailingProviderConfig providerConfig = configFactory.CreateInstance(userConnection);
			if (providerConfig is CESMailingProviderConfig) {
				var cesConfig = (CESMailingProviderConfig)providerConfig;
				_serviceApi = cesConfig.ServiceApi;
			}
		}

		#endregion

		#region Properties: Private

		private int BatchSendThreadCount {
			get {
				int threadCount = Math.Min(Environment.ProcessorCount * ThreadFactor, MaxThreadCount);
				return threadCount;
			}
		}

		private BpmonlineCloudEngine _cloudEngine;
		private BpmonlineCloudEngine CloudEngine {
			get {
				if (_cloudEngine == null) {
					_cloudEngine = ClassFactory.Get<BpmonlineCloudEngine>(
						new ConstructorArgument("userConnection", UserConnection));
				}
				return _cloudEngine;
			}
		}

		#endregion

		#region Properties: Protected

		protected ICESApi _serviceApi;
		protected ICESApi ServiceApi {
			get {
				if (_serviceApi == null) {
					_serviceApi = CloudEngine.ServiceApi;
				}
				return _serviceApi;
			}
		}

		protected Guid[] AvailableForExecutionStatuses {
			get {
				return new Guid[] {
					MailingConsts.BulkEmailStatusErrorId,
					MailingConsts.BulkEmailStatusStoppedId,
					MailingConsts.BulkEmailStatusPlannedId,
					MailingConsts.BulkEmailStatusStartPlanedId,
					MailingConsts.BulkEmailStatusActiveId
				};
			}
		}

		protected CESMailingTemplateFactory TemplateFactory {
			get;
			set;
		}

		protected IMailingAudienceDataSourceFactory AudienceDataSourceFactory {
			get;
			set;
		}

		protected string SelectForInsertTemplate {
			get {
				switch(UserConnection.DBEngine.DBEngineType) {
					case DBEngineType.Oracle: {
						return SelectForInsertMassMailingOracle;
					}
					case DBEngineType.MSSql:
					case DBEngineType.PostgreSql: {
						return SelectForInsertMassMailing;
					}
					default:
						return string.Empty;
				}
			}
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Instance of current user connection.
		/// </summary>
		public UserConnection UserConnection {
			get;
			set;
		}

		private BulkEmailEventLogger _bulkEmailEventLogger;

		/// <summary>
		/// Instance of BulkEmailEventLogger. 
		/// </summary>
		public BulkEmailEventLogger BulkEmailEventLogger =>
			_bulkEmailEventLogger ?? (_bulkEmailEventLogger = new BulkEmailEventLogger(UserConnection));

		private BulkEmailMacroParser _bulkEmailMacroParser;
		private readonly bool _isDCFeatureEnabled;

		public BulkEmailMacroParser BulkEmailMacroParser {
			get => _bulkEmailMacroParser ?? (_bulkEmailMacroParser = GetMacroParser());
			set => _bulkEmailMacroParser = value;
		}
		
		public BulkEmailValidator Validator { get; set; }

		#endregion

		#region Methods: Private

		private BulkEmailMacroParser GetMacroParser() {
			var macrosHelper = ClassFactory.Get<MacrosHelperV2>();
			macrosHelper.UserConnection = UserConnection;
			var bulkEmailMacroParser = ClassFactory.Get<BulkEmailMacroParser>(
				new ConstructorArgument("macrosHelper", macrosHelper));
			return bulkEmailMacroParser;
		}

		private CESMacrosHelper GetMacrosHelper(Guid contactId, Guid bulkEmailId) {
			return ClassFactory.Get<CESMacrosHelper>(
					new ConstructorArgument("userConnection", UserConnection),
					new ConstructorArgument("contactId", contactId),
					new ConstructorArgument("bulkEmailId", bulkEmailId));
		}

		private BulkEmailMacroComposer GetMacroComposer(Guid contactId, Guid bulkEmailId) {
			var bulkEmailMacroComposer = ClassFactory.Get<BulkEmailMacroComposer>(
				new ConstructorArgument("userConnection", UserConnection),
				new ConstructorArgument("contactId", contactId),
				new ConstructorArgument("bulkEmailId", bulkEmailId));
			bulkEmailMacroComposer.AudienceDataSource = _audienceDataSource;
			bulkEmailMacroComposer.MacrosHelper.UserConnection = UserConnection;
			return bulkEmailMacroComposer;
		}

		private string GetLczStringValue(string lczName) {
			string localizableStringName = string.Format("LocalizableStrings.{0}.Value", lczName);
			var localizableString = new LocalizableString(
				UserConnection.Workspace.ResourceStorage, "CESMaillingProvider", localizableStringName);
			string value = localizableString.Value;
			if (value == null) {
				value = localizableString.GetCultureValue(GeneralResourceStorage.DefCulture, false);
			}
			return value;
		}

		private bool GetCanExecuteBulkEmail(Guid statusId) {
			return AvailableForExecutionStatuses.Contains(statusId);
		}

		private IEnumerable<EmailAddress> GetEmailMesageTo(IEnumerable<IMessageRecipientInfo> recipients,
				CESMacrosHelper macrosHelper, IMailingTemplate template) {
			var validRecipients = GetValidRecipient(recipients);
			var personalMergeVars = GetMergeVars(macrosHelper, template, validRecipients);
			IEnumerable<EmailAddress> recipientEmailAddress = GetRecipientEmailAddress(personalMergeVars);
			return recipientEmailAddress;
		}

		private IEnumerable<EmailAddress> CreateEmailAddresses(IEnumerable<IMessageRecipientInfo> recipients) {
			var emailAddresses = new List<EmailAddress>();
			foreach (var recipient in recipients) {
				var emailAddress = new EmailAddress(recipient.Id, recipient.EmailAddress);
				var dcRecipient = recipient as IDCRecipientInfo;
				if (dcRecipient != null) {
					emailAddress.replica_id = dcRecipient.ReplicaId;
				}
				if (recipient is IExpirationInfo expirationInfo) {
					emailAddress.expiration_date = expirationInfo.ExpirationDate;
				}
				if (recipient is IDCRecipientInfo macrosInfo) {
					emailAddress.rcpt_merge_var = CreateRecipientMergeVar(recipient.EmailAddress, macrosInfo.Macros);
				}
				emailAddresses.Add(emailAddress);
			}
			return emailAddresses;
		}

		private rcpt_merge_var CreateRecipientMergeVar(string recipientEmailAddress, Dictionary<string, string> macros) {
			return new rcpt_merge_var {
				rcpt = recipientEmailAddress,
				vars = macros.Select(x => new merge_var {
					name = x.Key,
					content = x.Value
				}).ToList()
			};
		}

		private void PrepareRecipients(IMessageInfo messageInfo, CESMacrosHelper macrosHelper,
				EmailMessage emailMessage, IMailingTemplate template) {
			IEnumerable<EmailAddress> recipientEmailAddress =
				GetEmailMesageTo(messageInfo.Recipients, macrosHelper, template);
			emailMessage.to = recipientEmailAddress;
		}

		private List<string> GetBulkEmailCategoryTags(BulkEmail bulkEmail) {
			var tags = new List<string>();
			Guid categoryId = bulkEmail.CategoryId;
			if (categoryId == MailingConsts.MassmailingBulkEmailCategoryId) {
				tags.Add(MassMailingTag);
			} else if (categoryId == MailingConsts.TriggeredEmailBulkEmailCategoryId) {
				tags.Add(TriggeredEmailTag);
			}
			return tags;
		}

		private EmailMessage InitEmailMessage(IMessageInfo messageInfo) {
			var instantMessageInfo = messageInfo as InstantMessageInfo;
			BulkEmail bulkEmail = instantMessageInfo.BulkEmail;
			CESMacrosHelper macrosHelper = GetMacrosHelper(bulkEmail.OwnerId, bulkEmail.Id);
			IMailingTemplate template = CreateTemplate(bulkEmail, macrosHelper);
			try {
				var message = new EmailMessage {
					subject = template.TemplateSubject,
					from_email = bulkEmail.SenderEmail,
					from_name = bulkEmail.SenderName,
					html = bulkEmail.TemplateBody,
					track_clicks = true,
					track_opens = true,
					inline_css = true,
					important = true
				};
				var bulkEmailId = bulkEmail.GetTypedColumnValue<Guid>("Id");
				PrepareRecipients(messageInfo, macrosHelper, message, template);
				MailingUtilities.Log.InfoFormat("CESMaillingProvider.GetRecipients. Bulk email with Id={0} "
					+ "executed successfully", bulkEmailId);
				message.tags = GetBulkEmailCategoryTags(bulkEmail);
				message.html = template.Content;
				message.images = template.InlineImages.ToCESImage();
				List<merge_var> globalMergeVars = macrosHelper.GetGlobalMergeVars(template.MacrosCollection);
				if (globalMergeVars.Any()) {
					message.InitGlobalVariable();
					message.global_merge_vars.AddRange(globalMergeVars);
				}
				return message;
			} catch (Exception e) {
				MailingUtilities.Log.ErrorFormat(
					"[CESMaillingProvider.InitEmailMessage]: Error while init message for BulkEmail with Id: {0}",
					e, bulkEmail.Id);
				throw;
			}
		}

		private EmailMessage InitEmailMessage(SendMessageData messageData, CESMacrosHelper macrosHelper,
				IMailingTemplate template) {
			BulkEmail bulkEmail = messageData.BulkEmail;
			string senderEmail;
			string senderName;
			if (template is IMailingTemplateWithHeaders templateReplica) {
				senderEmail = templateReplica.SenderEmail;
				senderName = templateReplica.SenderName;
			} else {
				senderEmail = bulkEmail.SenderEmail;
				senderName = bulkEmail.SenderName;
			}
			var message = new EmailMessage {
				subject = template.TemplateSubject,
				from_email = senderEmail,
				from_name = senderName,
				track_clicks = true,
				track_opens = true,
				images = messageData.Images,
				inline_css = true
			};
			List<merge_var> globalMergeVars = macrosHelper.GetGlobalMergeVars(template.MacrosCollection);
			if (globalMergeVars.Any()) {
				message.InitGlobalVariable();
				message.global_merge_vars.AddRange(globalMergeVars);
			}
			message.tags = GetBulkEmailCategoryTags(bulkEmail);
			return message;
		}

		private EmailMessage InitDCEmailMessage(SendMessageData messageData) {
			BulkEmail bulkEmail = messageData.BulkEmail;
			var message = new EmailMessage {
				track_clicks = true,
				track_opens = true,
				images = messageData.Images,
				inline_css = true
			};
			message.tags = GetBulkEmailCategoryTags(bulkEmail);
			return message;
		}

		private bool IsDynamicBulkEmail(Guid bulkEmailId) {
			if (!_isDcBulkEmail.HasValue) {
				var templateReadOptions = new DCRepositoryReadOptions<DCTemplateModel, DCReplicaModel> {
					TemplateReadOptions = DCTemplateReadOption.ExcludeReplicaHtmlContent
				};
				_isDcBulkEmail = GetDcTemplateModel(bulkEmailId, templateReadOptions) != null;
			}
			if (!_isDCFeatureEnabled && _isDcBulkEmail.Value) {
				throw new InvalidOperationException("Dynamic email can't be processed by static mailing kernel. " +
					"Enable the feature BulkEmailDynamicContentBuilder for processing dynamic emails.");
			}
			return _isDCFeatureEnabled && _isDcBulkEmail.Value;
		}

		private DCTemplateModel GetDcTemplateModel(Guid bulkEmailId,
				DCRepositoryReadOptions<DCTemplateModel, DCReplicaModel> templateReadOptions) {
			var templateRepository = new DCTemplateRepository<DCTemplateModel>(UserConnection);
			var template = templateRepository.ReadByRecordId(bulkEmailId, templateReadOptions);
			return template;
		}

		private void InitBulkEmailCounters(Guid bulkEmailId, int bulkEmailRId, bool isResend) {
			int recipientCount = 0;
			try {
				recipientCount = BulkEmailQueryHelper.GetRecipientsInQueueCount(bulkEmailId, UserConnection);
				if (isResend) {
					ActualizeRecipientsBeforeSend(bulkEmailRId);
				} else {
					BulkEmailQueryHelper.UpdateBulkEmail(bulkEmailId, UserConnection,
						new KeyValuePair<string, object>("InQueueCount", recipientCount),
						new KeyValuePair<string, object>("RecipientCount", recipientCount),
						new KeyValuePair<string, object>("NotDeliveredCount", 0),
						new KeyValuePair<string, object>("TemplateNotFoundCount", 0),
						new KeyValuePair<string, object>("CanceledCount", 0));
				}
			} catch (Exception e) {
				MailingUtilities.Log.ErrorFormat(
					"[CESMaillingProvider.InitBulkEmailCounters]: Error while init BulkEmail counters with Id: {0},"
					+ " isResent={1}, recipientsCount={2}", e, bulkEmailId, isResend, recipientCount);
				throw;
			}
		}

		private void SetInvalidBulkEmailCounters(Guid bulkEmailId, int invalidAddresseeCount) {
			QueryColumnExpression actualInvalidAdresseeExpression
				= MailingDbUtilities.GetAddCountColumnExpression("InvalidAddresseeCount", invalidAddresseeCount);
			BulkEmailQueryHelper.UpdateBulkEmail(bulkEmailId, UserConnection,
				new KeyValuePair<string, object>("SendDueDate", Column.Const(null)),
				new KeyValuePair<string, object>("InvalidAddresseeCount", actualInvalidAdresseeExpression));

		}

		private int GetMailingStartTs(BulkEmail bulkEmail) {
			bool isTriggeredCategory = (bulkEmail.CategoryId == MailingConsts.TriggeredEmailBulkEmailCategoryId);
			return isTriggeredCategory ? Utilities.ConvertDateTimeToTimestamp(bulkEmail.StartDate) : 0;
		}

		private void PerformWaitBeforeSend(BulkEmail bulkEmail) {
			int sendDelayInSeconds
				= (int)Core.Configuration.SysSettings.GetValue(UserConnection, "MandrillMailingDelayInSeconds");
			bool isTriggeredCategory = (bulkEmail.CategoryId == MailingConsts.TriggeredEmailBulkEmailCategoryId);
			if (!isTriggeredCategory) {
				Thread.Sleep(sendDelayInSeconds * 1000);
			}
		}

		private void SetBulkEmailStatus(BulkEmail bulkEmail, Guid statusId) {
			Guid bulkEmailId = Guid.Empty;
			bool doUpdateStatus = _mailingSessionId.Equals(Guid.Empty);
			try {
				bulkEmailId = bulkEmail.Id;
				if (doUpdateStatus) {
					var bulkEmailStatusUpdate =
						new Update(UserConnection, "BulkEmail").Set("StatusId", Column.Parameter(statusId))
							.Where("Id").IsEqual(Column.Parameter(bulkEmailId)) as Update;
					bulkEmailStatusUpdate.WithHints(new RowLockHint());
					bulkEmailStatusUpdate.Execute();
				}
				bulkEmail.StatusId = statusId;
				if (bulkEmail.SplitTestId != Guid.Empty) {
					SetBulkEmailSplitStatus(bulkEmail.SplitTestId, statusId);
				}
				MailingUtilities.Log.InfoFormat(
					"BulkEmail with Id: {0} set to {1} status.", bulkEmailId, statusId);
			} catch (Exception e) {
				MailingUtilities.Log.ErrorFormat(
					"[CESMaillingProvider.SetBulkEmailStatus]: Error while saving BulkEmail with Id: {0}",
					e, bulkEmailId);
				BulkEmailEventLogger.LogError(bulkEmailId, DateTime.UtcNow,
					GetLczStringValue("BulkEmailStatusUpdateEvent"), e, GetLczStringValue("SaveErrorMsg"),
					UserConnection.CurrentUser.ContactId);
				throw;
			}
		}

		private void SetBulkEmailSplitStatus(Guid splitTestId, Guid bulkEmailStatusId) {
			try {
				var bulkEmailSplit = new BulkEmailSplit(UserConnection);
				if (!bulkEmailSplit.FetchFromDB(splitTestId)) {
					MailingUtilities.Log.ErrorFormat(
						"[CESMaillingProvider.SetBulkEmailSplitStatus]: Failed to fetch BulkEmailSplit from DB." +
						"Id: {0}", splitTestId);
					return;
				}
				if (bulkEmailStatusId == MailingConsts.BulkEmailStatusStartsId &&
						bulkEmailSplit.StatusId == MailingConsts.BulkEmailSplitStatusStartPlanedId) {
					bulkEmailSplit.SetColumnValue("StatusId", MailingConsts.BulkEmailSplitStatusLaunchedId);
				}
				if (bulkEmailStatusId == MailingConsts.BulkEmailStatusFinishedId) {
					var selectCount = new Select(UserConnection)
						.Column(Func.Count("Id"))
						.From("BulkEmail")
						.Where("SplitTestId").IsEqual(Column.Parameter(splitTestId))
							.And("StatusId").IsNotEqual(Column.Parameter(MailingConsts.BulkEmailStatusFinishedId)) as Select;
					var count = selectCount.ExecuteScalar<int>();
					if (count == 0) {
						bulkEmailSplit.SetColumnValue("StatusId", MailingConsts.BulkEmailSplitStatusFinishedId);
						string tableName = string.Format("ST_{0}", splitTestId.ToBase36());
						Utilities.DropTable(tableName, UserConnection, true);
					}
				}
				bulkEmailSplit.Save();
			} catch (Exception e) {
				MailingUtilities.Log.ErrorFormat(
					"[CESMaillingProvider.SetBulkEmailSplitStatus]: Error while saving BulkEmailSplit with Id: {0}",
					e, splitTestId);
			}
		}

		private void SetBulkEmailErrorStatus(BulkEmail bulkEmail) {
			Guid status;
			try {
				if (MailingConsts.TriggeredEmailBulkEmailCategoryId.Equals(bulkEmail.CategoryId)) {
					status = MailingConsts.BulkEmailStatusActiveId;
				} else if (MailingConsts.MassmailingBulkEmailCategoryId.Equals(bulkEmail.CategoryId)) {
					status = MailingConsts.BulkEmailStatusErrorId;
				} else {
					throw new ArgumentException(string.Format("Unknown BulkEmail category: {0}.", bulkEmail.CategoryId));
				}
				SetBulkEmailStatus(bulkEmail, status);
			} catch (Exception e) {
				MailingUtilities.Log.ErrorFormat(
					"[CESMaillingProvider.SetBulkEmailErrorStatus]: "
					+ "Update Error Status: BulkEmail: {0} fails.", e, bulkEmail.Id);
				BulkEmailEventLogger.LogError(bulkEmail.Id, DateTime.UtcNow,
					GetLczStringValue("BulkEmailStatusUpdateEvent"), e,
					GetLczStringValue("SetBulkEmailErrorStatusErrorMsg"), UserConnection.CurrentUser.ContactId);
				throw;
			}
		}

		private int SetBulkEmailBreakingStatus(Guid bulkEmailId) {
			var startOperationDate = DateTime.UtcNow;
			int result = 0;
			try {
				var bulkEmailUpdate = new Update(UserConnection, "BulkEmail")
					.Set("StatusId", Column.Parameter(MailingConsts.BulkEmailStatusStoppedId))
					.Set("StartDate", Column.Const(null))
					.Where("Id").IsEqual(Column.Parameter(bulkEmailId))
					.And("StatusId").IsEqual(
						new QueryParameter(MailingConsts.BulkEmailStatusWaitingBeforeSendId)
					);
				result = bulkEmailUpdate.Execute();
				BulkEmailEventLogger.LogInfo(bulkEmailId, startOperationDate,
					GetLczStringValue("MailingStoppedManually"), GetLczStringValue("MailingStoppedManuallyDescription"),
					UserConnection.CurrentUser.ContactId);
			} catch (System.Data.SqlClient.SqlException e) {
				MailingUtilities.Log.ErrorFormat(
					"[CESMaillingProvider.SetBulkEmailBreakingStatus]: "
					+ "Update Breaking Status: BulkEmail: {0} fails.", e, bulkEmailId);
				BulkEmailEventLogger.LogError(bulkEmailId, DateTime.UtcNow,
					GetLczStringValue("BulkEmailStatusUpdateEvent"), e, GetLczStringValue("StateUpdateErrorMsg"),
					UserConnection.CurrentUser.ContactId);
			}
			return result;
		}

		private void SetBulkEmailCompletedStatus(BulkEmail bulkEmail) {
			Guid status;
			if (MailingConsts.TriggeredEmailBulkEmailCategoryId.Equals(bulkEmail.CategoryId)) {
				status = MailingConsts.BulkEmailStatusActiveId;
			} else if (MailingConsts.MassmailingBulkEmailCategoryId.Equals(bulkEmail.CategoryId)) {
				status = MailingConsts.BulkEmailStatusFinishedId;
			} else {
				throw new ArgumentException(string.Format("Unknown BulkEmail category: {0}.", bulkEmail.CategoryId));
			}
			SetBulkEmailStatus(bulkEmail, status);
		}

		private BulkEmail GetBulkEmailFromDB(Guid bulkEmailId) {
			var bulkEmail = new BulkEmail(UserConnection);
			var fetchBulkEmailResult = bulkEmail.FetchFromDB("Id", bulkEmailId, new[] {
								"Id", "Owner", "Name", "TemplateBody", "UseUtm", "StartDate", "Category",
								"Domains", "UtmSource", "UtmMedium", "UtmCampaign", "UtmTerm", "UtmContent", "TemplateSubject",
								"SenderName", "SenderEmail"
						});
			if (!fetchBulkEmailResult) {
				MailingUtilities.Log.WarnFormat(
					"[CESMaillingProvider.GetBulkEmailFromDB]: FetchFromDB BulkEmail: {0} fails.", bulkEmailId);
				throw new Exception(
					$"[CESMaillingProvider.GetBulkEmailFromDB]: FetchFromDB BulkEmail: {bulkEmailId} fails.");
			}
			return bulkEmail;
		}

		private IEnumerable<IMessageRecipientInfo> GetValidRecipient(IEnumerable<IMessageRecipientInfo> recipientsBatch) {
			var validRecipients = recipientsBatch.Where(item =>
				item.InitialResponseCode == (int)MailingResponseCode.PostedProvider);
			return validRecipients;
		}

		private IEnumerable<EmailAddress> GetRecipientEmailAddress(
				Dictionary<IMessageRecipientInfo, rcpt_merge_var> recipientsBatch) {
			var emailAddresses = new List<EmailAddress>();
			foreach (var recipientPair in recipientsBatch) {
				var recipientInfo = recipientPair.Key;
				var emailAddress = new EmailAddress(recipientInfo.Id, recipientInfo.EmailAddress);
				var expirationInfo = recipientInfo as IExpirationInfo;
				if (expirationInfo != null) {
					emailAddress.expiration_date = expirationInfo.ExpirationDate;
				}
				emailAddress.rcpt_merge_var = recipientPair.Value;
				emailAddresses.Add(emailAddress);
			}
			return emailAddresses;
		}

		private TypedCounter<MailingResponseCode> CreateResultsCounter() {
			var resultsCounter = new TypedCounter<MailingResponseCode>();
			resultsCounter.Register("InvalidAddressee", MailingResponseCode.Invalid);
			resultsCounter.Register("BlankEmail", MailingResponseCode.CanceledBlankEmail);
			resultsCounter.Register("DoNotUseEmail", MailingResponseCode.CanceledDoNotUseEmail);
			resultsCounter.Register("IncorrectEmail", MailingResponseCode.CanceledIncorrectEmail);
			resultsCounter.Register("UnreachableEmail", MailingResponseCode.CanceledInvalidEmail);
			resultsCounter.Register("CommunicationLimit", MailingResponseCode.CanceledCommunicationLimit);
			resultsCounter.Register("TemplateNotFound", MailingResponseCode.CanceledTemplateNotFound);
			resultsCounter.Register("SendersDomainNotVerified", MailingResponseCode.CanceledSendersDomainNotVerified);
			resultsCounter.Register("SendersNameNotValid", MailingResponseCode.CanceledSendersNameNotValid);
			resultsCounter.Register("DuplicateEmail", MailingResponseCode.Duplicated);
			return resultsCounter;
		}

		private int GetInitialResponseCodeByContactRId(int contactRId) {
			var responseCase = new QueryCase();
			var trueValue = 1;
			MailingDbUtilities.AddWhenCondition(
				responseCase, "Contact", "IsNonActualEmail", QueryConditionType.Equal, trueValue,
				(int)MailingResponseCode.CanceledInvalidEmail);
			MailingDbUtilities.AddWhenCondition(
				responseCase, "Contact", "DoNotUseEmail", QueryConditionType.Equal, trueValue,
				(int)MailingResponseCode.CanceledDoNotUseEmail);
			responseCase.ElseExpression =
				new QueryColumnExpression(Column.Parameter((int)MailingResponseCode.PostedProvider));
			var select = new Select(UserConnection)
				.Column(responseCase).As("InitialResponseCode")
				.From("Contact")
				.Where("RId").IsEqual(Column.Const(contactRId)) as Select;
			return select.ExecuteScalar<int>();
		}

		private void PrepareInitialResponses(IEnumerable<IMessageRecipientInfo> recipients) {
			foreach (IMessageRecipientInfo recipient in recipients) {
				if (string.IsNullOrEmpty(recipient.EmailAddress)) {
					recipient.InitialResponseCode = (int)MailingResponseCode.CanceledBlankEmail;
				} else if (!MailingUtilities.ValidateEmail(recipient.EmailAddress)) {
					recipient.InitialResponseCode = (int)MailingResponseCode.CanceledIncorrectEmail;
				} else {
					recipient.InitialResponseCode = GetInitialResponseCodeByContactRId(recipient.ContactRId);
				}
			}
		}

		private void RegisterSenderDomain(string senderEmail) {
			try {
				var domain = new Regex("^.*@").Replace(senderEmail, "");
				CloudEngine.RegisterSenderDomain(domain);
			} catch (Exception e) {
				MailingUtilities.Log.ErrorFormat(
					"[CESMaillingProvider.RegisterSenderDomain]: Error while registering domain for email: {0}",
					e, senderEmail);
			}
		}

		private void InitializeAudienceDataSource(Guid bulkEmailId) {
			if (_mailingSessionId.Equals(Guid.Empty)) {
				_audienceDataSource = AudienceDataSourceFactory.CreateInstance(UserConnection, bulkEmailId,
					MassMailingRecipientsLimit);
			} else {
				var sessionedFactory = AudienceDataSourceFactory as IMailingAudienceSessionedDataSourceFactory;
				_audienceDataSource = sessionedFactory.CreateSessionedInstance(UserConnection, bulkEmailId,
					MassMailingRecipientsLimit, _mailingSessionId);
			}
			var dcAudienceDataSource = (IDCAudienceDataSource)_audienceDataSource;
			if (_isDcBulkEmail.HasValue && dcAudienceDataSource != null) {
				dcAudienceDataSource.IsDCBulkEmail = _isDcBulkEmail.Value;
			}
		}

		private void SafePutSessionIdToBulkEmailInProgress(Guid sessionId, Guid bulkEmailId) {
			var insertSelect = new InsertSelect(UserConnection)
				.Into("BulkEmailInProgress")
				.Set("SessionId", "BulkEmailId", "CreatedOn")
				.FromSelect(new Select(UserConnection)
					.Column(Column.Parameter(sessionId))
					.Column(Column.Parameter(bulkEmailId))
					.Column(Column.Parameter(DateTime.UtcNow))
					.From(new Select(UserConnection)
						.Column(Func.Count("SessionId")).As("Cnt")
						.From("BulkEmailInProgress")
						.Where("SessionId").IsEqual(Column.Parameter(sessionId))).As("Condition")
				.Where("Condition", "Cnt").IsEqual(Column.Const(0)));
			insertSelect.Execute();
		}

		private void DeleteSessionIdFromBulkEmailInProgress(Guid sessionId) {
			var delete = new Delete(UserConnection)
				.From("BulkEmailInProgress")
				.Where("SessionId").IsEqual(Column.Parameter(sessionId));
			delete.Execute();
		}

		private void LogRecipientState(List<IMessageRecipientInfo> recipients, Guid bulkEmailId, int batchId,
				DateTime startDate) {
			if (!recipients.Any()) {
				return;
			}
			var validCount = recipients.Count(x => x.InitialResponseCode == (int)MailingResponseCode.PostedProvider);
			var incorrectEmailCount =
				recipients.Count(x => x.InitialResponseCode == (int)MailingResponseCode.CanceledIncorrectEmail);
			var blankEmailCount =
				recipients.Count(x => x.InitialResponseCode == (int)MailingResponseCode.CanceledBlankEmail);
			var invalidEmailCount =
				recipients.Count(x => x.InitialResponseCode == (int)MailingResponseCode.CanceledInvalidEmail);
			var unsubCount = recipients.Count(x => x.InitialResponseCode == (int)MailingResponseCode.Unsub);
			var duplicatedCount = recipients.Count(x => x.InitialResponseCode == (int)MailingResponseCode.Duplicated);
			var noTemplateCount = 
				recipients.Count(x => x.InitialResponseCode == (int)MailingResponseCode.CanceledTemplateNotFound);
			var senderDomainNotVerifiedCount = 
				recipients.Count(x => x.InitialResponseCode == (int)MailingResponseCode.CanceledSendersDomainNotVerified);
			var senderNameNotValidCount = 
				recipients.Count(x => x.InitialResponseCode == (int)MailingResponseCode.CanceledSendersNameNotValid);
			BulkEmailEventLogger.LogInfo(bulkEmailId, startDate, GetLczStringValue("PrepareBatch"),
				GetLczStringValue("PrepareBatchDescription"), UserConnection.CurrentUser.ContactId, batchId,
				recipients.Count, validCount, incorrectEmailCount, blankEmailCount, invalidEmailCount, unsubCount,
				duplicatedCount, noTemplateCount, senderDomainNotVerifiedCount, senderNameNotValidCount);
		}

		private bool PingProvider(Guid emailId) {
			DateTime startPingTime = DateTime.UtcNow;
			try {
				object pingResult;
				var result = Utilities.TryExecute(ServiceApi.Ping, MailingServicePingAttemptsCount,
					MailingServicePingTimeout, out pingResult);
				BulkEmailEventLogger.LogInfo(emailId, startPingTime, GetLczStringValue("PingCes"),
					GetLczStringValue("PingCesDescription"), UserConnection.CurrentUser.ContactId);
				return result;
			} catch (Exception e) {
				BulkEmailEventLogger.LogError(emailId, startPingTime, GetLczStringValue("PingCes"), e,
					GetLczStringValue("PingCesDescription"), UserConnection.CurrentUser.ContactId);
				return false;
			}
		}

		private IEnumerable<DCReplicaModel> GetReplicasByMasks(DCTemplateModel template,
				IEnumerable<int> replicaMasks = null) {
			var replicas = template.Replicas;
			if (replicaMasks != null && replicaMasks.Any()) {
				replicas = replicas.Where(x => replicaMasks.Contains(x.Mask));
			}
			return replicas;
		}

		private void OverrideFromEmailHeader(EmailMessage emailMessage, CESMailingTemplate cesTemplate,
				IEnumerable<merge_var> recipientMergeVars) {
			if (cesTemplate.TrackedAliases.TryGetValue(MailingConsts.FromNameMacroKey, out var fromNameMacroName)) {
				var fromNameMacroValue = recipientMergeVars.FirstOrDefault(x => x.name == fromNameMacroName)
					.content;
				emailMessage.from_name = fromNameMacroValue;
			}
			if (cesTemplate.TrackedAliases.TryGetValue(MailingConsts.FromEmailMacroKey, out var fromEmailMacroName)) {
				var fromEmailMacroValue = recipientMergeVars.FirstOrDefault(x => x.name == fromEmailMacroName)
					.content;
				emailMessage.from_email = fromEmailMacroValue;
			}
		}

		#endregion

		#region Methods: Protected

		protected virtual void InitTemplateFactory() {
			if (TemplateFactory == null) {
				TemplateFactory = new CESMailingTemplateFactory();
			}
		}

		protected virtual void InitAudienceDataSourceFactory() {
			if (AudienceDataSourceFactory == null) {
				AudienceDataSourceFactory = new BulkEmailAudienceDataSourceFactory();
			}
		}

		protected IMailingTemplate CreateTemplate(BulkEmail bulkEmail, CESMacrosHelper macrosHelper) {
			var template = TemplateFactory.CreateInstance(UserConnection, bulkEmail, BulkEmailMacroParser);
			template.Init();
			return template;
		}

		protected IEnumerable<IMailingTemplate> CreateTemplates(BulkEmail bulkEmail, BulkEmailMacroParser macroParser,
				IEnumerable<DCReplicaModel> replicasToProcess) {
			if (replicasToProcess == null) {
				var templateCollection = new List<IMailingTemplate>();
				var mailingTemplate = TemplateFactory.CreateInstance(UserConnection, bulkEmail, macroParser);
				mailingTemplate.Init();
				templateCollection.Add(mailingTemplate);
				return templateCollection;
			} else {
				return TemplateFactory.CreateInstances(UserConnection, bulkEmail, replicasToProcess, macroParser);
			}
		}

		protected IEnumerable<IMailingTemplate> CreateTemplates(BulkEmail bulkEmail, BulkEmailMacroParser macroParser,
				IEnumerable<int> replicaMasksToProcess = null) {
			var templateRepository = new DCTemplateRepository<DCTemplateModel>(UserConnection);
			var templateReadOptions = new DCRepositoryReadOptions<DCTemplateModel, DCReplicaModel> {
				TemplateReadOptions = DCTemplateReadOption.None
			};
			DCTemplateModel template = templateRepository.ReadByRecordId(bulkEmail.Id, templateReadOptions);
			IEnumerable<DCReplicaModel> replicas = null;
			if (template != null) {
				replicas = GetReplicasByMasks(template, replicaMasksToProcess);
			}
			return CreateTemplates(bulkEmail, macroParser, replicas);
		}

		protected void ActualizeRecipientsBeforeSend(int bulkEmailRId) {
			try {
				var update = new Update(UserConnection, "MandrillRecipient")
					.Set("IsSent", Column.Const(true))
				.Where().Exists(new Select(UserConnection).Column("Id")
					.From("MandrillSentMessage")
					.Where("BulkEmailRId").IsEqual("MandrillRecipient", "BulkEmailRId")
					.And("ContactRId").IsEqual("MandrillRecipient", "ContactRId")
				).And("BulkEmailRId").IsEqual(Column.Parameter(bulkEmailRId))
				.And("IsSent").IsEqual(Column.Const(false)) as Update;
				update.Execute();
			} catch (Exception e) {
				MailingUtilities.Log.ErrorFormat("[CESMaillingProvider.ActualizeRecipientsBeforeSend]: "
					+ "Update of BulkEmail: {0} fails.", e, bulkEmailRId);
				throw;
			}
		}
		
		protected void SaveTemplate(IMailingTemplate template, BulkEmail bulkEmail) {
			if (!Validator.ValidateTemplateSize(template, out var templateSize)) {
				throw new Exception(string.Format("Template {0} have size {1} more than {2}.", template.Name,
					MailingMaxTemplateSize));
			}
			IEnumerable<image> images = template.InlineImages.ToCESImage();
			string checksum = string.Empty;
			string replicaId = null;
			string senderEmail;
			string senderName;
			if (template is IMailingTemplateWithHeaders templateReplica) {
				checksum = templateReplica.Checksum;
				replicaId = templateReplica.ReplicaId.ToString();
				senderEmail = templateReplica.SenderEmail;
				senderName = templateReplica.SenderName;
			} else {
				senderEmail = bulkEmail.SenderEmail;
				senderName = bulkEmail.SenderName;
			}
			Utilities.RetryOnFailure(() => ServiceApi.AddTemplate(
				template.Name,
				senderEmail,
				senderName,
				template.TemplateSubject,
				template.Content,
				string.Empty,
				bulkEmail.Id,
				images,
				checksum,
				replicaId));
		}

		protected Action CreateDCSendAction(BulkEmail bulkEmail, CultureInfo culture, DateTime startSendingTime) {
			bool isResend = (bulkEmail.StatusId == MailingConsts.BulkEmailStatusStoppedId ||
				bulkEmail.StatusId == MailingConsts.BulkEmailStatusErrorId);
			return () => {
				PerformWaitBeforeSend(bulkEmail);
				Guid currentBulkEmailStatus = BulkEmailQueryHelper.GetBulkEmailStatus(bulkEmail.Id, UserConnection);
				if (currentBulkEmailStatus == MailingConsts.BulkEmailStatusStoppedId) {
					MailingUtilities.Log.InfoFormat("[CESMaillingProvider.ExecuteSendMessageTask]: Break iterations. " +
						"BulkEmail.Id {0} has status 'Stopped'.", bulkEmail.Id);
					return;
				}
				InitializeAudienceDataSource(bulkEmail.Id);
				if (bulkEmail.CategoryId.Equals(MailingConsts.TriggeredEmailBulkEmailCategoryId)
							&& _audienceDataSource.IsEmpty()) {
					SetBulkEmailStatus(bulkEmail, MailingConsts.BulkEmailStatusActiveId);
					MailingUtilities.Log.InfoFormat(
						"[CESMailingProvider.SendMessage]: BulkEmail with Id: {0} is empty.", bulkEmail.Id);
					return;
				}
				MailingUtilities.Log.InfoFormat("[CESMaillingProvider.CreateSendAction]: Start action for send. " +
					"BulkEmail.Id: {0}, isResend: {1}", bulkEmail.Id, isResend);
				Thread.CurrentThread.CurrentCulture = culture;
				var messageData = CreateSendMessageData(bulkEmail);
				List<IMailingTemplate> templateReplicas;
				try {
					ResolveRecipientsReplica(bulkEmail);
					templateReplicas = CreateTemplates(bulkEmail, BulkEmailMacroParser).ToList();
					foreach (var template in templateReplicas) {
						SaveTemplate(template, bulkEmail);
						messageData.TemplateName = template.Name;
					}
					PrepareRecipientsMacros(bulkEmail, templateReplicas);
				} catch (Exception e) {
					SetBulkEmailErrorStatus(bulkEmail);
					MailingUtilities.Log.ErrorFormat("[CESMaillingProvider.ExecuteSendMessage]: "
						+ "Error while saving template. BulkEmailId {0}.", e, bulkEmail.Id);
					BulkEmailEventLogger.LogError(bulkEmail.Id, DateTime.UtcNow,
						GetLczStringValue("BatchSendEvent"), e,
						GetLczStringValue("TemplateSaveErrorMsg"), UserConnection.CurrentUser.ContactId);
					CreateReminding(bulkEmail, "CESTemplateFailsMsg");
					return;
				}
				ExecuteSendMessage(messageData, null, startSendingTime, isResend, templateReplicas);
			};
		}

		private bool IsRecipientsSelectQueryEmpty(Select select) {
			var execSelect = new Select(UserConnection)
				.Column(Func.Count("RecipientUId"))
				.From(select.Top(1)).As("IsRecipientsSelectQueryEmpty");
			var bulkEmailAudienceCount = execSelect.ExecuteScalar<int>();
			return bulkEmailAudienceCount == 0;
		}

		private void ResolveRecipientsReplica(BulkEmail bulkEmail) {
			var dcDataSource = _audienceDataSource as IDCAudienceDataSource;
			_audienceDataSource.PageNumber = 0;
			var dcStrategyResolver = new DCStrategyResolver(UserConnection);
			var templateRepository = new DCTemplateRepository<DCTemplateModel>(UserConnection);
			var repositoryOptions = new DCRepositoryReadOptions<DCTemplateModel, DCReplicaModel> {
				TemplateReadOptions = DCTemplateReadOption.None
			};
			var template = templateRepository.ReadByRecordId(bulkEmail.Id, repositoryOptions);
			if (template == null) {
				throw new NullReferenceException($"Template for BulkEmail with id {bulkEmail.Id} not found");
			}
			while (true) {
				_audienceDataSource.PageNumber++;
				var audienceSelect = dcDataSource.GetRecipientsIdsSelectQuery(Guid.Empty);
				var isAudienceSelectEmpty = IsRecipientsSelectQueryEmpty(audienceSelect);
				if (isAudienceSelectEmpty) {
					break;
				}
				var segmentationContext = new DCSegmentationContext(UserConnection);
				segmentationContext.Template = template;
				segmentationContext.SourceAudience = dcDataSource.GetRecipientsIdsSelectQuery(Guid.Empty);
				segmentationContext.SourceAlias = "MandrillDeliveryPackage";
				segmentationContext.EntityIdSourceColumn = "RecipientUId";
				segmentationContext.SourceColumnForFilter = "ContactId";
				segmentationContext.TargetTable = "BulkEmailRecipientReplica";
				segmentationContext.EntityIdTargetColumn = "RecipientId";
				segmentationContext.ReplicaIdTargetColumn = "DCReplicaId";
				segmentationContext.RecordIdTargetColumn = "BulkEmailId";
				dcStrategyResolver.SegmentAudience(segmentationContext);
			}
		}

		private void PrepareRecipientsMacros(BulkEmail bulkEmail, List<IMailingTemplate> templateReplicas) {
			var macroComposer = GetMacroComposer(bulkEmail.OwnerId, bulkEmail.Id);
			foreach (var replica in templateReplicas) {
				var mailingTemplateReplica = replica as IMailingTemplateReplica;
				if (mailingTemplateReplica != null) {
					macroComposer.TrackedAliases = (mailingTemplateReplica as CESMailingTemplate)?.TrackedAliases;
					macroComposer.PrepareMacros(mailingTemplateReplica.ReplicaId, replica.MacrosCollection);
				}
			}
		}

		private SendMessageData CreateSendMessageData(BulkEmail bulkEmail) {
			DateTime startDateUtc = TimeZoneInfo.ConvertTimeToUtc(bulkEmail.StartDate,
				UserConnection.CurrentUser.TimeZone);
			var messageData = new SendMessageData() {
				UserConnection = UserConnection,
				BulkEmail = bulkEmail,
				BulkEmailStartDate = startDateUtc,
				SessionId = Guid.NewGuid()
			};
			return messageData;
		}

		protected void CreateReminding(Entity entity, string lczStringName, params object[] parameters) {
			CreateReminding(entity, lczStringName, GetLczStringValue("RemindingMsgCaption"), parameters);
		}

		protected void CreateReminding(Entity entity, string lczStringName, string caption,
				params object[] parameters) {
			string description = string.Empty;
			if (parameters.Any()) {
				description = string.Format(GetLczStringValue(lczStringName), parameters);
			} else {
				description = GetLczStringValue(lczStringName);
			}
			MailingUtilities.CreateReminding(UserConnection, entity, description, caption);
		}

		protected void ExecuteSendMessagePostProcessing(SendMessageData sendMessageData,
				List<TypedCounter<MailingResponseCode>> sendResults, SendMessageTaskData sendMessageTaskData) {
			BulkEmail bulkEmail = sendMessageData.BulkEmail;
			Guid sessionId = sendMessageData.SessionId;
			int blankEmailCount = sendResults.Sum("BlankEmail");
			int doNotUseEmailCount = sendResults.Sum("DoNotUseEmail");
			int incorrectEmailCount = sendResults.Sum("IncorrectEmail");
			int unreachableEmailCount = sendResults.Sum("UnreachableEmail");
			int communicationLimitCount = sendResults.Sum("CommunicationLimit");
			int duplicateEmailCount = sendResults.Sum("DuplicateEmail");
			int templateNotFoundCount= sendResults.Sum("TemplateNotFound");
			int sendersDomainNotVerifiedCount = sendResults.Sum("SendersDomainNotVerified");
			int sendersNameNotValidCount = sendResults.Sum("SendersNameNotValid");
			int invalidAddresseeCount = sendResults.Sum("InvalidAddressee");
			if (sendMessageTaskData.IsBreaking) {
				SetBulkEmailStatus(bulkEmail, MailingConsts.BulkEmailStatusStoppedId);
				BulkEmailEventLogger.LogInfo(bulkEmail.Id, DateTime.UtcNow,
					GetLczStringValue("MailingStoppedManually"), GetLczStringValue("MailingStoppedManuallyDescription"),
					UserConnection.CurrentUser.ContactId);
				SetInvalidBulkEmailCounters(bulkEmail.Id, invalidAddresseeCount);
				CreateReminding(bulkEmail, "CESStoppedMailingMsg");
				MailingUtilities.Log.InfoFormat("BulkEmail with Id: {0} Was stopped manually.", bulkEmail.Id);
				return;
			}
			BulkEmailQueryHelper.UpdateBulkEmail(bulkEmail.Id, UserConnection,
				new KeyValuePair<string, object>("SendDueDate", DateTime.UtcNow),
				new KeyValuePair<string, object>("BlankEmailCount", blankEmailCount),
				new KeyValuePair<string, object>("DoNotUseEmailCount", doNotUseEmailCount),
				new KeyValuePair<string, object>("IncorrectEmailCount", incorrectEmailCount),
				new KeyValuePair<string, object>("UnreachableEmailCount", unreachableEmailCount),
				new KeyValuePair<string, object>("CommunicationLimitCount", communicationLimitCount),
				new KeyValuePair<string, object>("DuplicateEmailCount", duplicateEmailCount),
				new KeyValuePair<string, object>("TemplateNotFoundCount", templateNotFoundCount),
				new KeyValuePair<string, object>("SendersDomainNotVerifiedCount", sendersDomainNotVerifiedCount),
				new KeyValuePair<string, object>("SendersNameNotValidCount", sendersNameNotValidCount),
				new KeyValuePair<string, object>("InvalidAddresseeCount", invalidAddresseeCount));
			MailingUtilities.Log.InfoFormat(
				"[CESMaillingProvider.ExecuteSendMessage]: Finished: BulkEmail.Id: {0}, SessionId: {1}",
				bulkEmail.Id, sessionId);
			if (sendMessageTaskData.ProcessedGroupsCounter == 0) {
				SetBulkEmailErrorStatus(bulkEmail);
				CreateReminding(bulkEmail, "CESNoRecipientsMsg");
				MailingUtilities.Log.InfoFormat("BulkEmail with Id: {0} Has no recipients.", bulkEmail.Id);
			}
		}

		[Obsolete("7.13.4|Use ExecuteSendMessageTask(SendMessageData sourceData)")]
		protected void ExecuteSendMessageTask(SendMessageData sourceData, string subject) {
			ExecuteSendMessageTask(sourceData);
		}

		protected void ExecuteSendMessageTask(SendMessageData sourceData) {
			BulkEmail bulkEmail = sourceData.BulkEmail;
			int bulkEmailRId = sourceData.BulkEmailRId;
			Guid sessionId = sourceData.SessionId;
			CultureInfo culture = Thread.CurrentThread.CurrentCulture;
			List<Action> actions = new List<Action>();
			var sendMessageTaskData = new SendMessageTaskData();
			var sendResults = new List<TypedCounter<MailingResponseCode>>();
			_audienceDataSource.PageNumber = 0;
			if (UserConnection.GetIsFeatureEnabled("FromEmailFromNameMacros")) {
				var validationBuilder = new BulkEmailRecipientValidatorBuilder(ServiceApi);
				_recipientsValidator = new BulkEmailRecipientValidator(validationBuilder);
			}
			while (sendMessageTaskData.HasDataToProceed) {
				_audienceDataSource.PageNumber++;
				sendMessageTaskData.BatchId = _audienceDataSource.PageNumber;
				MailingUtilities.Log.InfoFormat("[CESMaillingProvider.ExecuteSendMessageTask]: Set BatchId - {0}. " +
					"BulkEmail.Id {1}, Session {2}.", sendMessageTaskData.BatchId, bulkEmail.Id, sessionId);
				SendMessageData messageData = sourceData.Clone();
				messageData.BulkEmail = sourceData.BulkEmail;
				EmailMessage email = InitDCEmailMessage(messageData);
				messageData.BatchId = sendMessageTaskData.BatchId;
				messageData.BatchLength = MassMailingRecipientsLimit;
				List<IMessageRecipientInfo> recipients;
				int nextBatchLength = 0;
				try {
					email.InitRecipientVariable();
					DateTime startGetRecipientTime = DateTime.UtcNow;
					recipients = GetRecipients();
					if (_recipientsValidator != null) {
						_recipientsValidator.Validate(recipients);
					}
					LogRecipientState(recipients, messageData.BulkEmail.Id, messageData.BatchId, startGetRecipientTime);
					var validRecipients = GetValidRecipient(recipients);
					IEnumerable<EmailAddress> recipientEmailAddress = CreateEmailAddresses(validRecipients);
					email.to = recipientEmailAddress;
					nextBatchLength = recipients.Count;
					MailingUtilities.Log.InfoFormat("[CESMaillingProvider.ExecuteSendMessageTask]: Prepared {0} " +
						"recipients. BulkEmail.Id {1}, BatchId {2}, SessionId: {3}", nextBatchLength,
						bulkEmail.Id, sendMessageTaskData.BatchId, sessionId);
				} catch (System.Data.SqlClient.SqlException e) {
					MailingUtilities.Log.ErrorFormat(
						"[CESMaillingProvider.GetRecipients]: Group processing fails. BulkEmailRId: {0}, " +
						"SessionId: {1}. GroupId: {2}.",
						e, messageData.BulkEmailRId, messageData.SessionId, messageData.BatchId);
					BulkEmailEventLogger.LogError(messageData.BulkEmail.Id, DateTime.UtcNow,
						GetLczStringValue("AudienceAddEvent"), e, GetLczStringValue("BatchProcessingErrorMsg"),
						UserConnection.CurrentUser.ContactId, messageData.BatchId);
					sendMessageTaskData.RetryMessageProcessing();
					if (!sendMessageTaskData.HasDataToProceed) {
						MailingUtilities.Log.InfoFormat(
							"[CESMaillingProvider.ExecuteSendMessage]: Terminated. Failed groups limit reached. " +
							"BulkEmail.Id: {0}, SessionId: {1}", bulkEmailRId, sessionId);
					}
					continue;
				} catch (Exception exception) {
					MailingUtilities.Log.ErrorFormat(
						"[CESMaillingProvider.GetRecipients]: Group processing fails. BulkEmailRId: {0}, " +
						"SessionId: {1}. GroupId: {2}.",
						exception, messageData.BulkEmailRId, messageData.SessionId, messageData.BatchId);
					BulkEmailEventLogger.LogError(messageData.BulkEmail.Id, DateTime.UtcNow,
						GetLczStringValue("AudienceAddEvent"), exception, GetLczStringValue("BatchProcessingErrorMsg"),
						UserConnection.CurrentUser.ContactId, messageData.BatchId);
					throw;
				}
				sendMessageTaskData.LastFailedGroupId = 0;
				sendMessageTaskData.CheckMessageCanProceed(nextBatchLength);
				if (sendMessageTaskData.HasDataToProceed) {
					messageData.MailingStartTS = GetMailingStartTs(bulkEmail);
					MailingUtilities.Log.InfoFormat("[CESMaillingProvider.ExecuteSendMessageTask]: Has data to " +
						"proceed and start new thread. BulkEmail.Id {0}, BatchId {1}, SessionId: {2}",
						bulkEmail.Id, sendMessageTaskData.BatchId, sessionId);
					actions.Add(() => {
						try {
							Thread.CurrentThread.CurrentCulture = culture;
							TypedCounter<MailingResponseCode> resultsCounter = CreateResultsCounter();
							messageData.EmailMessage = email;
							bool sentResult = true;
							if (email.to.Any()) {
								sentResult = SendBatch(messageData, recipients.Count);
							}
							if (!sentResult) {
								recipients
									.Where(x => x.InitialResponseCode == (int)BulkEmailResponseCode.Sent)
									.ForEach(y =>
										y.InitialResponseCode = (int)MailingResponseCode.RequestFailed);
							}
							UpdateSendEmailIterationResult(messageData, recipients, resultsCounter);
							sendResults.Add(resultsCounter);
						} catch (Exception e) {
							MailingUtilities.Log.ErrorFormat(
								"[CESMaillingProvider.ExecuteSendMessageTask]: Error occurs when sends batch."
								+ " BulkEmailRId: {0}, SessionId: {1}. GroupId: {2}.", e,
								messageData.BulkEmailRId, messageData.SessionId, messageData.BatchId);
						}
					});
				} else {
					MailingUtilities.Log.InfoFormat("[CESMaillingProvider.ExecuteSendMessageTask]: Has no data to " +
						"proceed and BatchSendThreadPool released. BulkEmail.Id {0}, BatchId {1}, SessionId: {2}",
						bulkEmail.Id, sendMessageTaskData.BatchId, sessionId);
				}
			}
			BulkEmailQueryHelper.ResetBulkEmailCounters(sourceData.BulkEmailRId, UserConnection);
			Parallel.ForEach(actions, new ParallelOptions { MaxDegreeOfParallelism = BatchSendThreadCount },
				action => action());
			ExecuteSendMessagePostProcessing(sourceData, sendResults, sendMessageTaskData);
		}

		protected bool ExecuteSendMessage(IMessageInfo messageInfo) {
			var instatntMessageInfo = messageInfo as InstantMessageInfo;
			var bulkEmail = instatntMessageInfo.BulkEmail;
			RegisterSenderDomain(bulkEmail.SenderEmail);
			var emailMessage = InitEmailMessage(messageInfo);
			try {
				ServiceApi.SendMessage(emailMessage, bulkEmail.Id);
				HandleEmailResult(messageInfo.MessageRId, messageInfo.Recipients);
			} catch (Exception e) {
				MailingUtilities.Log.ErrorFormat("[ExecuteSendMessage]: Error while sending message", e);
				BulkEmailEventLogger.LogError(bulkEmail.Id, DateTime.UtcNow, GetLczStringValue("BatchSendEvent"), e,
					GetLczStringValue("SendToCloudErrorMsg"), UserConnection.CurrentUser.ContactId);
				return false;
			} finally {
				emailMessage = null;
			}
			return true;
		}

		protected void ExecuteSendMessage(SendMessageData messageData, CESMacrosHelper macrosHelper,
			DateTime startSendingTime, bool isResend = false, List<IMailingTemplate> templateReplicas = null) {
			Guid sessionId = messageData.SessionId;
			BulkEmail bulkEmail = messageData.BulkEmail;
			int bulkEmailRId = messageData.BulkEmailRId;
			MailingUtilities.Log.InfoFormat("[CESMaillingProvider.ExecuteSendMessage]: Start: "
				+ "BulkEmail.Id: {0}, SessionId: {1}", bulkEmail.Id, sessionId);
			try {
				ActiveContactsValidationResult validationResult =
					ActiveContactsHelper.ValidatePermissionEditBulkEmail(UserConnection);
				if (validationResult.Code == ActiveContactsValidationResult.Error) {
					SetBulkEmailErrorStatus(bulkEmail);
					CreateReminding(bulkEmail, validationResult.Message);
					MailingUtilities.Log.ErrorFormat(
						"[CESMaillingProvider.ExecuteSendMessage]: License check failed. SessionId: {0}.", sessionId);
					BulkEmailEventLogger.LogError(bulkEmail.Id, DateTime.UtcNow, GetLczStringValue("BatchSendEvent"),
						GetLczStringValue("LicenceErrorMsg"), UserConnection.CurrentUser.ContactId);
					return;
				}
				if (!PingProvider(bulkEmail.Id)) {
					SetBulkEmailErrorStatus(bulkEmail);
					CreateReminding(bulkEmail, "CESPingFailsMsg");
					MailingUtilities.Log.ErrorFormat("[CESMaillingProvider.ExecuteSendMessage]: CESApi.Ping Fails. SessionId: {0}.",
						sessionId);
					BulkEmailEventLogger.LogError(bulkEmail.Id, DateTime.UtcNow, GetLczStringValue("BatchSendEvent"),
						GetLczStringValue("CloudUnreachableMsg"), UserConnection.CurrentUser.ContactId);
					return;
				}
				SetBulkEmailStatus(bulkEmail, MailingConsts.BulkEmailStatusLaunchedId);
				InitBulkEmailCounters(bulkEmail.Id, bulkEmailRId, isResend);
				BulkEmailEventLogger.LogInfo(bulkEmail.Id, startSendingTime,
					GetLczStringValue("StartSendingEmail"), GetLczStringValue("StartSendingEmailDescription"),
					UserConnection.CurrentUser.ContactId);
				ExecuteSendMessageTask(messageData);
				SetBulkEmailCompletedStatus(bulkEmail);
				CreateReminding(bulkEmail, "CESMassMailingFinishedMsg");
				BulkEmailEventLogger.LogInfo(bulkEmail.Id, startSendingTime,
					GetLczStringValue("EmailSent"), GetLczStringValue("EmailSentDescription"),
					UserConnection.CurrentUser.ContactId);
			} catch (Exception e) {
				MailingUtilities.Log.ErrorFormat(
					"[CESMaillingProvider.ExecuteSendMessage]: Error when execute send message for BulkEmail with Id: {0},"
					+ " isResent={1}", e, bulkEmail.Id, isResend);
				BulkEmailEventLogger.LogError(messageData.BulkEmail.Id, DateTime.UtcNow,
					GetLczStringValue("BatchSendEvent"), e, GetLczStringValue("ExecuteSendMessageErrorMsg"),
					UserConnection.CurrentUser.ContactId);
				throw;
			}
		}

		[Obsolete("Inherit Terrasoft.Configuration.EmailCommunicationRestrictionRepository" +
			" to customize restriction rules")]
		protected void PrepareCommunicationLimitRules(BulkEmail bulkEmail) {
			bool isFeatureEnabled = UserConnection.GetIsFeatureEnabled("EmailCommunicationRestriction");
			if (isFeatureEnabled) {
				return;
			}
			if (!MailingConsts.MassmailingBulkEmailCategoryId.Equals(bulkEmail.CategoryId)) {
				return;
			}
			var esq = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "BulkEmailCountLimit");
			esq.AddColumn("Id");
			EntityCollection esqCollection = esq.GetEntityCollection(UserConnection);
			if (esqCollection.Count > 0) {
				try {
					MailingDbUtilities.ExecuteStoredProcedure(UserConnection, "tsp_SetBECLimit",
						new KeyValuePair<string, object>("BulkEmailId", bulkEmail.Id)
					);
				} catch (Exception e) {
					MailingUtilities.Log.ErrorFormat(
						"[CESMaillingProvider.ExecuteSendMessage]: Failed to set communication limit.BulkEmailId: {0}.",
						bulkEmail.Id);
					BulkEmailEventLogger.LogError(bulkEmail.Id, DateTime.UtcNow, GetLczStringValue("BatchSendEvent"),
						e, GetLczStringValue("CommunicationLimitErrorMsg"), UserConnection.CurrentUser.ContactId);
				}
			}
		}

		protected List<IMessageRecipientInfo> GetRecipients() {
			return _audienceDataSource.GetAudience();
		}

		protected Dictionary<IMessageRecipientInfo, rcpt_merge_var> GetMergeVars(CESMacrosHelper macrosHelper,
				IMailingTemplate template, IEnumerable<IMessageRecipientInfo> recipientsBatch) {
			Select recipientSelect = _audienceDataSource.GetRecipientsSelectQuery();
			Dictionary<Guid, IMessageRecipientInfo> contactCollection = recipientsBatch.GroupBy(p => p.ContactId)
				.Select(p => p.First()).ToDictionary(p => p.ContactId, p => p);
			var contactIdSelect = new Select(UserConnection).Column("ContactId").From(recipientSelect).As("IdSubSelect");
			return macrosHelper.GetRecipientMergeVars(contactIdSelect, contactCollection, template.MacrosCollection);
		}

		protected void PrepareTestRecipient(Guid contactId, string emailRecipient, CESMacrosHelper macrosHelper,
				EmailMessage emailMessage, IMailingTemplate template) {
			string emailSplitRegexPattern = @"[;,\s]\s*";
			var emailAddresses = emailRecipient == null
				? Enumerable.Empty<EmailAddress>()
				: Regex.Split(emailRecipient, emailSplitRegexPattern)
					.Where(x => x.IsNotNullOrWhiteSpace())
					.Select(x => new EmailAddress(Guid.NewGuid(), x.Trim()));
			if (!contactId.Equals(Guid.Empty)) {
				emailMessage.InitRecipientVariable();
				foreach (EmailAddress emailAddress in emailAddresses) {
					rcpt_merge_var mergeVars =
						macrosHelper.GetPersonalMergeVars(contactId, emailAddress.email, template.MacrosCollection);
					emailMessage.merge_vars.Add(mergeVars);
				}
			}
			emailMessage.to = emailAddresses;
			var cesTemplate = template as CESMailingTemplate;
			var recipientMergeVars = emailMessage.merge_vars.FirstOrDefault()?.vars;
			if (cesTemplate == null || recipientMergeVars == null) {
				return;
			}
			OverrideFromEmailHeader(emailMessage, cesTemplate, recipientMergeVars);
		}

		protected void HandleEmailResult(int bulkEmailRId, IEnumerable<IMessageRecipientInfo> recipients) {
			string sentMessageInsertTemplate = "INSERT INTO \"MandrillSentMessage\" (\"MandrillId\", \"BulkEmailRId\", " +
				"\"ContactRId\", \"ResponseCode\", \"MailingStartTS\")";
			InsertInitialResponses(recipients, bulkEmailRId, sentMessageInsertTemplate);
			string messageResponseInsertTemplate = "INSERT INTO \"MandrillMessageResponse\" (\"MandrillId\", " +
				"\"BulkEmailRId\", \"ContactRId\", \"ResponseCode\", \"TimeStamp\")";
			InsertInitialResponses(recipients, bulkEmailRId, messageResponseInsertTemplate);
		}

		protected void UpdateResultCounter(IEnumerable<IMessageRecipientInfo> recipients,
				TypedCounter<MailingResponseCode> resultsCounter) {
			foreach (IMessageRecipientInfo recipient in recipients) {
				resultsCounter.Count((MailingResponseCode)recipient.InitialResponseCode);
			}
		}

		protected void InsertInitialResponses(
				IEnumerable<IMessageRecipientInfo> recipients, int bulkEmailRId, string insertTemplate) {
			InsertBuilder initialStatusInsertBuilder = new InsertBuilder(UserConnection,
				insertTemplate, SelectForInsertTemplate);
			int mailingStartTS = Utilities.ConvertDateTimeToTimestamp(DateTime.UtcNow);
			foreach (IMessageRecipientInfo recipient in recipients) {
				string recipientId = recipient.Id.ToString().ToUpper();
				initialStatusInsertBuilder.InsertRow(recipientId, bulkEmailRId,
					recipient.ContactRId, recipient.InitialResponseCode, mailingStartTS);
			}
			initialStatusInsertBuilder.ExecuteInsert();
		}

		protected bool SendBatch(SendMessageData messageData, int recipientCount) {
			MailingUtilities.Log.InfoFormat("[CESMaillingProvider.SendBatch]: Start: BulkEmailId: {0}. GroupId {1}.",
					messageData.BulkEmail.Id, messageData.BatchId);
			bool sendResult = false;
			try {
				DateTime startSendingTime = DateTime.UtcNow;
				Utilities.RetryOnFailure(() => ServiceApi.SendTemplate(messageData.EmailMessage,
					messageData.TemplateName, null, messageData.BulkEmail.Id));
				sendResult = true;
				BulkEmailEventLogger.LogInfo(messageData.BulkEmail.Id, startSendingTime,
					GetLczStringValue("SentBatchStatus"), GetLczStringValue("SentBatchStatusDescription"),
					UserConnection.CurrentUser.ContactId, messageData.BatchId);
			} catch (Exception e) {
				MailingUtilities.Log.ErrorFormat(
					"[CESMaillingProvider.SendBatch]: Error while sending BulkEmail with Id: {0}. "
					+ "SessionId: {1}. GroupId {2}.", e, messageData.BulkEmail.Id, messageData.SessionId,
					messageData.BatchId);
				BulkEmailEventLogger.LogError(messageData.BulkEmail.Id, DateTime.UtcNow,
					GetLczStringValue("BatchSendEvent"), e, GetLczStringValue("BatchSendErrorMsg"),
					UserConnection.CurrentUser.ContactId, messageData.BulkEmail);
				sendResult = false;
			}
			return sendResult;
		}

		protected void UpdateSendEmailIterationResult(SendMessageData messageData, IEnumerable<IMessageRecipientInfo> recipients,
				TypedCounter<MailingResponseCode> resultsCounter) {
			try {
				HandleEmailResult(messageData.BulkEmailRId, recipients);
				UpdateResultCounter(recipients, resultsCounter);
			} catch (Exception e) {
				MailingUtilities.Log.ErrorFormat(
					"[CESMaillingProvider.SendBatch]: Error while handling result of BulkEmail with Id: {0}",
					e, messageData.BulkEmail.Id);
				BulkEmailEventLogger.LogError(messageData.BulkEmail.Id, DateTime.UtcNow,
					GetLczStringValue("BatchSendEvent"), e, GetLczStringValue("HandleResultErrorMsg"),
					UserConnection.CurrentUser.ContactId);
			} finally {
				messageData.EmailMessage = null;
			}
			MailingUtilities.Log.InfoFormat("[CESMaillingProvider.SendBatch]: Success: BulkEmailId: {0}. GroupId {1}.",
				messageData.BulkEmail.Id, messageData.BatchId);
		}

		protected bool ValidateBulkEmail(Guid bulkEmailId, BulkEmail bulkEmail, MailingResponse response) {
			if (!bulkEmail.FetchFromDB(bulkEmailId)) {
				MailingUtilities.Log.InfoFormat("Can't access record with Id: {0}.", bulkEmailId);
				return false;
			}
			if (!GetCanExecuteBulkEmail(bulkEmail.StatusId)) {
				MailingUtilities.Log.InfoFormat("BulkEmail with Id: {0} is already in process.", bulkEmailId);
				response.StatusId = bulkEmail.StatusId;
				return false;
			}
			if (bulkEmail.SegmentsStatusId == MailingConsts.SegmentStatusUpdatingId) {
				MailingUtilities.Log.InfoFormat(
					"BulkEmail with Id: {0} can't get started. Segment status is 'Updating'.", bulkEmailId);
				return false;
			}
			return true;
		}

		protected void AddContactToBulkEmailAudience(IMessageInfo messageInfo) {
			foreach (IMessageRecipientInfo recipientInfo in messageInfo.Recipients) {
				var insert = new Insert(UserConnection)
				.Into("MandrillRecipient")
				.Set("BulkEmailRId", Column.Parameter(messageInfo.MessageRId))
				.Set("ContactRId", Column.Parameter(recipientInfo.ContactRId))
				.Set("EmailAddress", Column.Parameter(recipientInfo.EmailAddress))
				.Set("UId", Column.Parameter(recipientInfo.Id))
				.Set("IsSent", Column.Const(true))
				.Set("Timestamp", Column.Parameter(messageInfo.MailingStartTS));
				insert.Execute();
			}
		}

		#endregion

		#region Methods: Public

		/// <summary>
		/// Configures properties of current instance.
		/// </summary>
		public virtual void Configure() {
			Validator = new BulkEmailValidator(UserConnection, ServiceApi);
			InitTemplateFactory();
			InitAudienceDataSourceFactory();
		}

		/// <summary>
		/// Breaks process of sending.
		/// </summary>
		/// <param name="bulkEmailId">Unique identifier of the bulk email.</param>
		/// <returns>Returns status of bulk email.</returns>
		public MailingResponse BreakMailing(Guid bulkEmailId) {
			var bulkEmail = new BulkEmail(UserConnection);
			var response = new MailingResponse() {
				Success = false,
				StatusId = Guid.Empty
			};
			if (!bulkEmail.FetchFromDB(bulkEmailId)) {
				MailingUtilities.Log.InfoFormat("Cannot access record with Id: {0}.", bulkEmailId);
				return response;
			}
			if (SetBulkEmailBreakingStatus(bulkEmail.Id) > 0) {
				response.Success = true;
				response.StatusId = MailingConsts.BulkEmailStatusBreakingId;
				return response;
			}
			response.Success = true;
			response.StatusId = bulkEmail.StatusId;
			return response;
		}

		/// <summary>
		/// Starts sending of the bulk email with the sessionId.
		/// </summary>
		/// <param name="bulkEmailId">Unique identifier of the bulk email.</param>
		/// <param name="sessionId">Guid identifier of the current trigger mailing session</param>
		/// <param name="isDelayedStart">Delay sending.</param>
		/// <returns>Returns status of bulk email.</returns>
		public MailingResponse SendMessage(Guid bulkEmailId, Guid sessionId, bool isDelayedStart = false,
				string applicationUrl = "") {
			_mailingSessionId = sessionId;
			SafePutSessionIdToBulkEmailInProgress(sessionId, bulkEmailId);
			MailingResponse response = SendMessage(bulkEmailId, isDelayedStart, applicationUrl);
			DeleteSessionIdFromBulkEmailInProgress(sessionId);
			return response;
		}

		/// <summary>
		/// Starts sending of the bulk email.
		/// </summary>
		/// <param name="bulkEmailId">Unique identifier of the bulk email.</param>
		/// <param name="isDelayedStart">Delay sending.</param>
		/// <returns>Returns status of bulk email.</returns>
		public MailingResponse SendMessage(Guid bulkEmailId, bool isDelayedStart = false,
				string applicationUrl = "") {
			DateTime startSendingTime = DateTime.UtcNow;
			var bulkEmail = GetBulkEmailFromDB(bulkEmailId);
			var response = new MailingResponse() {
				Success = false,
				StatusId = MailingConsts.BulkEmailStatusErrorId
			};
			if (!ValidateBulkEmail(bulkEmailId, bulkEmail, response)) {
				return response;
			}
			RegisterSenderDomain(bulkEmail.SenderEmail);
			if (bulkEmail.StartDate != DateTime.MinValue && !isDelayedStart) {
				BulkEmailEventLogger.LogInfo(bulkEmail.Id, startSendingTime,
					GetLczStringValue("StartSendingEmail"), GetLczStringValue("StartSendingScheduledEmailDescription"),
					UserConnection.CurrentUser.ContactId, bulkEmail.StartDate.ToString("yyyy-MM-dd HH:mm:ss\" GMT\"zzz"));
				SetBulkEmailStatus(bulkEmail, MailingConsts.BulkEmailStatusStartPlanedId);
			} else {
				CultureInfo culture = Thread.CurrentThread.CurrentCulture;
				BulkEmailQueryHelper.UpdateBulkEmail(bulkEmail.Id, UserConnection,
					new KeyValuePair<string, object>("SendStartDate", DateTime.UtcNow));
				var sendAction = CreateDCSendAction(bulkEmail, culture, startSendingTime);
				SetBulkEmailStatus(bulkEmail, MailingConsts.BulkEmailStatusWaitingBeforeSendId);
				if (bulkEmail.CategoryId == MailingConsts.MassmailingBulkEmailCategoryId
						&& bulkEmail.LaunchOptionId == MailingConsts.BulkEmailManaulLaunchOptionId) {
					BulkEmailQueryHelper.UpdateBulkEmail(bulkEmail.Id, UserConnection,
						new KeyValuePair<string, object>("StartDate", DateTime.UtcNow));
					Task.Factory.StartNew(sendAction);
				} else {
					try {
						sendAction();
					} catch (Exception e) {
						MailingUtilities.Log.ErrorFormat("[CESMailingProvider.SendMessage]: BulkEmail with " +
							"Id: {0} sendAction execution error", e, bulkEmail.Id);
						BulkEmailEventLogger.LogError(bulkEmail.Id, DateTime.UtcNow,
							GetLczStringValue("BatchSendEvent"), e, GetLczStringValue("SendEmailErroMsg"),
							UserConnection.CurrentUser.ContactId);
						return response;
					}
				}
			}
			response.Success = true;
			response.StatusId = bulkEmail.StatusId;
			return response;
		}

		/// <summary>
		/// Starts sending of the message.
		/// </summary>
		/// <param name="messageInfo">Object that holds information about message.</param>
		/// <returns>Status of message.</returns>
		public MailingResponse SendMessage(IMessageInfo messageInfo) {
			messageInfo.PrepareMessage(UserConnection);
			if (!messageInfo.Validate()) {
				return new MailingResponse {
					StatusId = MailingConsts.BulkEmailStatusErrorId,
					Success = false
				};
			}
			bool sendMessageResult = false;
			try {
				PrepareInitialResponses(messageInfo.Recipients);
				sendMessageResult = ExecuteSendMessage(messageInfo);
			} catch (Exception e) {
				MailingUtilities.Log.ErrorFormat("[CESMailingProvider.SendMessage]: "
					+ "Error occurred while send message", e);
				return new MailingResponse {
					StatusId = MailingConsts.BulkEmailStatusErrorId,
					Success = false
				};
			}
			AddContactToBulkEmailAudience(messageInfo);
			messageInfo.UpdateMessageInfo(UserConnection, !sendMessageResult);
			return new MailingResponse {
				StatusId = MailingConsts.BulkEmailStatusFinishedId,
				Success = true
			};
		}

		/// <summary>
		/// Sends test email.
		/// </summary>
		/// <param name="bulkEmailId">Unique identifier of the bulk email.</param>
		/// <param name="contactId">Unique identifier of the contact from audience.</param>
		/// <param name="emailRecipient">Email address of the recipient.</param>
		/// <returns>Returns result of successful sending.</returns>
		public bool SendTestMessage(Guid bulkEmailId, Guid contactId, string emailRecipient) {
			var result = SendDCTestMessage(new SendTestMessageData {
				ContactId = contactId,
				EmailRecipients = emailRecipient,
				BulkEmailId = bulkEmailId
			});
			return result.Success;
		}

		/// <summary>
		/// Sends test bulk email message with dynamic content. Sends all replicas if 
		/// <see cref="SendTestMessageData.ReplicaMasks"/> property of the parameter <paramref name="data"/>
		/// is null or empty, or chosen replicas in another case.
		/// </summary>
		/// <param name="data">Data required for test message sending.</param>
		/// <returns>Results of successful sending for each replica.</returns>
		public SendTestMessageResult SendDCTestMessage(SendTestMessageData data) {
			if (!PingProvider(data.BulkEmailId)) {
				BulkEmailEventLogger.LogInfo(data.BulkEmailId, DateTime.UtcNow, GetLczStringValue("PingCes"),
					GetLczStringValue("PingCesDescription"), UserConnection.CurrentUser.ContactId);
				return new SendTestMessageResult {
					Success = false
				};
			}
			var executor = new ImmediateEmailExecutor(UserConnection) {
				TemplateFactory = TemplateFactory,
				CloudEngine = CloudEngine,
				ServiceApi = ServiceApi,
				Validator = Validator,
				BulkEmailMacroParser = BulkEmailMacroParser,
				TemplateRepository = new DCTemplateRepository<DCTemplateModel>(UserConnection)
			};
			return executor.Send(data);
		}

		/// <summary>
		/// Validates message.
		/// </summary>
		/// <param name="messageId">Unique identifier of the message.</param>
		/// <returns>Validation result.</returns>
		public ConfigurationServiceResponse ValidateMessage(Guid messageId) {
			return ValidateMessages(new[] { messageId });
		}

		/// <summary>
		/// Validates messages.
		/// </summary>
		/// <param name="messageIds">Unique identifiers of the message.</param>
		/// <returns>Validation result.</returns>
		public ConfigurationServiceResponse ValidateMessages(Guid[] messageIds) {
			return Validator.ValidateMessages(messageIds);
		}

		/// <summary>
		/// Validates status of bulk emails.
		/// </summary>
		/// <param name="bulkEmailIds">Unique identifiers of the message.</param>
		/// <returns>Validation result.</returns>
		public ConfigurationServiceResponse ValidateDraftStatus(Guid[] bulkEmailIds) {
			return Validator.ValidateDraftStatus(bulkEmailIds);
		}

		/// <summary>
		/// Ping provider's service.
		/// </summary>
		public bool PingProvider() {
			try {
				ServiceApi.Ping();
				return true;
			} catch (Exception) {
				return false;
			}
		}

		#endregion
	}

	#endregion

}
