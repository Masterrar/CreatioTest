namespace Terrasoft.Configuration.MandrillService
{
	using Mandrill;
	using Mandrill.Models;
	using System;
	using System.Collections.Generic;
	using System.Collections.Specialized;
	using System.Data;
	using System.Globalization;
	using System.IO;
	using System.Linq;
	using System.Security.Cryptography;
	using System.ServiceModel;
	using System.ServiceModel.Activation;
	using System.ServiceModel.Web;
	using System.Text;
	using System.Text.RegularExpressions;
	using System.Threading;
	using System.Threading.Tasks;
	using Terrasoft.Common;
	using Terrasoft.Configuration.Marketing.Utilities;
	using Terrasoft.Core;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Factories;
	using Terrasoft.Web.Http.Abstractions;
	using HttpUtility = System.Web.HttpUtility;

	#region Class: MandrillService

	///<summary>Class for work with Mandrill.</summary>
	[ServiceContract]
	[AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Required)]
	public class MandrillService : IMailingProvider
	{

		#region Class: Internal

		internal class InitialStatusesPackage
		{

			public Guid BulkEmailId { get; set; }

			public string EmailAddress { get; set; }

			public Guid? MandrillId { get; set; }

			public Guid EmailResponseId { get; set; }

		}

		internal class SearchRequestInMandrill
		{

			public SearchRequestInMandrill(Guid sessionId, Guid bulkEmailId,
				List<string> emailsList) {
				BulkEmailId = bulkEmailId;
				EmailsList = emailsList;
				SessionId = sessionId;
			}

			public Guid SessionId { get; private set; }

			public Guid BulkEmailId { get; private set; }

			public List<string> EmailsList { get; private set; }

		}

		internal class SearchResponseFromMandrill
		{

			public SearchResponseFromMandrill(Guid bulkEmailId, List<string> emailsList) {
				SearchResults = new List<SearchResult>();
				EmailsList = emailsList;
				Failed = false;
				BulkEmailId = bulkEmailId;
			}

			public bool Failed { get; set; }

			public List<SearchResult> SearchResults { get; set; }

			public List<string> EmailsList { get; protected set; }

			public Guid BulkEmailId { get; protected set; }

		}

		internal class EmailsListWithoutMandrillIdResponse
		{

			public EmailsListWithoutMandrillIdResponse() {
				EmailsList = new List<string>();
			}

			public Guid BulkEmailId { get; set; }

			public List<string> EmailsList { get; set; }

		}

		internal class UpdateTargetAudienceData
		{

			public UpdateTargetAudienceData(UserConnection userConnection, string schemaName, Guid recordId,
					bool isSetCampaignFirstStep = false) {
				RecordId = recordId;
				SchemaName = schemaName;
				UserConnection = userConnection;
				IsSetCampaignFirstStep = isSetCampaignFirstStep;
			}

			public UserConnection UserConnection { get; private set; }

			public Guid RecordId { get; private set; }

			public string SchemaName { get; private set; }

			public bool IsSetCampaignFirstStep { get; private set; }

		}

		internal class SendMessageData
		{

			public SendMessageData(UserConnection userConnection, BulkEmail bulkEmail, string applicationUrl) {
				BulkEmail = bulkEmail;
				ApplicationUrl = applicationUrl;
				UserConnection = userConnection;
			}

			public UserConnection UserConnection { get; private set; }

			public BulkEmail BulkEmail { get; private set; }

			public string ApplicationUrl { get; private set; }

		}

		internal class SendBatchData
		{

			public SendBatchData(UserConnection userConnection, Guid sessionId, int batchId,
					int bulkEmailRId, int mailingStartTS, string templateName, EmailMessage emailMessage,
					Dictionary<string, int> emailContactCollection) {
				BulkEmailRId = bulkEmailRId;
				TemplateName = templateName;
				UserConnection = userConnection;
				SessionId = sessionId;
				BatchId = batchId;
				EmailMessage = emailMessage;
				EmailContactCollection = emailContactCollection;
				MailingStartTS = mailingStartTS;
			}

			public Guid SessionId { get; private set; }

			public UserConnection UserConnection { get; private set; }

			public int BatchId { get; private set; }

			public int BulkEmailRId { get; private set; }

			public string TemplateName { get; private set; }

			public EmailMessage EmailMessage { get; set; }

			public Dictionary<string, int> EmailContactCollection { get; private set; }

			public int MailingStartTS { get; private set; }

		}

		internal class PrepareRecipientsInfo
		{

			public Guid SessionId { get; set; }

			public int BulkEmailRId { get; set; }

			public Guid BulkEmailId { get; set; }

			public DateTime BulkEmailStartDate { get; set; }

			public Guid BulkEmailCategoryId { get; set; }

			public int BatchLength { get; set; }

			public int BatchId { get; set; }

			public string ApplicationUrl { get; set; }

			public int GetLowPackageEdge() {
				return (BatchId - 1) * BatchLength + 1;
			}

			public int GetHighPackageEdge() {
				return BatchId * BatchLength;
			}

		}

		#endregion

		#region Constants: Private

		/// <summary>
		/// Recipient count in Mandrill mailing.
		/// </summary>
		private const int MassMailingRecipientsLimit = 20000;

		/// <summary>
		/// Pattern of name of Mandrill mailing template.
		/// </summary>
		private const string MandrillTemplateNamePattern = "{0}({1})";

		/// <summary>
		/// Custom metadata field for bulk email Mandrill.
		/// </summary>
		private const string BulkEmailMetadataValue = "bulk_email_id";

		/// <summary>
		/// Maximal size of Mandrill mailing template, bytes.
		/// </summary>
		private const int MandrillMaxTemplateSize = 14999999;

		/// <summary>
		/// Count of chars in Int32.
		/// </summary>
		private const int IntLength = 10;

		private const int MandrillServicePingAttemptsCount = 3;

		private const int MandrillServicePingTimeout = 10000;

		private const int StreamReaderBufferSize = 65536;

		private const int ThreadFactor = 2;

		#endregion

		#region Fields: Private

		private UserConnection _userConnection;

		private static Semaphore _batchSendThreadPool;

		private static bool _isAnonymousAuthentication = false;

		private static bool _isMetadataInitialized;

		private MandrillApi _mandrillApi;

		#endregion

		#region Constructors: Public

		public MandrillService() {}
		
		/// <summary>
		/// Constructor of MandrillService.
		/// </summary>
		/// <param name="userConnection">Instance for user connection.</param>
		/// <param name="configFactory">Instance of mailing provider configuration factory.</param>
		public MandrillService(UserConnection userConnection, IMailingProviderConfigFactory configFactory = null) {
			UserConnection = userConnection;
		}

		#endregion

		#region Properties: Private

		private Semaphore BatchSendThreadPool {
			get {
				if (_batchSendThreadPool == null) {
					int threadCount = Environment.ProcessorCount * ThreadFactor;
					_batchSendThreadPool = new Semaphore(threadCount, threadCount);
				}
				return _batchSendThreadPool;
			}
		}

		private MandrillApi ServiceApi {
			get {
				if (_mandrillApi == null) {
					_mandrillApi = new MandrillApi(MandrillApiKey);
				}
				return _mandrillApi;
			}
		}

		private string MandrillApiKey => (string)Terrasoft.Core.Configuration.SysSettings
			.GetValue(UserConnection, "mandrillApiKey");

		#endregion

		#region Properties: Public

		public UserConnection UserConnection {
			get {
				if (_userConnection != null) {
					return _userConnection;
				}
				_userConnection = HttpContext.Current.Session["UserConnection"] as UserConnection;
				if (_userConnection != null) {
					return _userConnection;
				}
				if (_isAnonymousAuthentication) {
					var appConnection = (AppConnection)HttpContext.Current.Application["AppConnection"];
					_userConnection = appConnection.SystemUserConnection;
				}
				return _userConnection;
			}
			set => _userConnection = value;
		}

		#endregion

		#region Methods: Private

		private void Authenticate() {
			if (UserConnection == null) {
				throw new System.Security.Authentication.AuthenticationException();
			}
		}

		private void InitializeCustomMetadata() {
			try {
				if (!ServiceApi.ListCustomMetadata().Any(x => x.name == BulkEmailMetadataValue)) {
					ServiceApi.AddCustomMetadata(BulkEmailMetadataValue);
				}
				_isMetadataInitialized = true;
			} catch (Exception e) {
				MandrillUtilities.Log.ErrorFormat(
					"[MandrillService.InitializeCustomMetadata]: Error while handling getting custom metadata field",
					e);
			}
		}

		private void CreateReminding(Entity entity, string lczStringName, params object[] parameters) {
			CreateReminding(entity, lczStringName, GetLczStringValue("RemindingMsgCaption"), parameters);
		}

		private void CreateReminding(Entity entity, string lczStringName, string caption,
				params object[] parameters) {
			string description = string.Empty;
			description = parameters.Any()
				? string.Format(GetLczStringValue(lczStringName), parameters)
				: GetLczStringValue(lczStringName);
			MandrillUtilities.CreateReminding(UserConnection, entity, description, caption);
		}

		private void UpdateBulkEmailCommonErrorCount(int bulkEmailRId, int incCommonErrorCount) {
			try {
				var bulkEmailUpdate = new Update(UserConnection, "BulkEmail")
					.Set("CommonErrorCount", QueryColumnExpression.Add(new QueryColumnExpression("CommonErrorCount"),
						Column.Parameter(incCommonErrorCount)))
					.Where("RId").IsEqual(Column.Parameter(bulkEmailRId)) as Update;
				bulkEmailUpdate.Execute();
			} catch (System.Data.SqlClient.SqlException e) {
				MandrillUtilities.Log.ErrorFormat("[MandrillService.UpdateBulkEmailCommonErrorCount]: " +
					"Update CommonErrorCount: {0} of BulkEmail: {1} fails.", e, incCommonErrorCount, bulkEmailRId);
			}
		}

		private int SetBulkEmailBreakingStatus(Guid bulkEmailId) {
			int result = 0;
			try {
				var bulkEmailUpdate = new Update(UserConnection, "BulkEmail")
					.Set("StatusId", Column.Parameter(MarketingConsts.BulkEmailStatusStoppedId))
					.Set("StartDate", Column.Const(null))
					.Where("Id").IsEqual(Column.Parameter(bulkEmailId))
					.And("StatusId").In(
						new QueryParameter(MarketingConsts.BulkEmailStatusStartsId),
						new QueryParameter(MarketingConsts.BulkEmailStatusLaunchedId)
					) as Update;
				result = bulkEmailUpdate.Execute();
			} catch (System.Data.SqlClient.SqlException e) {
				MandrillUtilities.Log.ErrorFormat(
					"[MandrillService.SetBulkEmailBreakingStatus]: "
					+ "Update Breaking Status: BulkEmail: {0} fails.", e, bulkEmailId);
			}
			return result;
		}

		private void SendBatch(SendBatchData data, TypedCounter<BulkEmailResponseCode> resultsCounter) {
			MandrillUtilities.Log.InfoFormat("[MandrillService.SendBatch]: Start: SessionId: {0}. GroupId {1}.",
				data.SessionId, data.BatchId);
			UserConnection = data.UserConnection;
			var emailResults = new List<Mandrill.EmailResult>();
			bool sendFailed = false;
			try {
				emailResults = ServiceApi.SendMessageAsync(data.EmailMessage, data.TemplateName, null).Result;
			} catch (Exception e) {
				BatchSendThreadPool.Release();
				MandrillUtilities.Log.ErrorFormat(
					"[MandrillService.SendBatch]: Error while sanding BulkEmail with RId: {0}. "
					+ "SessionId: {1}. GroupId {2}.", e, data.BulkEmailRId, data.SessionId, data.BatchId);
				sendFailed = true;
				UpdateBulkEmailCommonErrorCount(data.BulkEmailRId, data.EmailMessage.to.Count());
			} finally {
				data.EmailMessage = null;
			}
			if (sendFailed) {
				return;
			}
			try {
				HandleMandrillEmailResult(
					data.BulkEmailRId, data.MailingStartTS, emailResults, data.EmailContactCollection, resultsCounter);
			} catch (Exception e) {
				MandrillUtilities.Log.ErrorFormat(
						"[MandrillService.SendBatch]: Error while handling result of BulkEmail with RId: {0}",
						e, data.BulkEmailRId);
			} finally {
				emailResults.Clear();
				data.EmailContactCollection.Clear();
				BatchSendThreadPool.Release();
			}
			MandrillUtilities.Log.InfoFormat("[MandrillService.SendBatch]: Success: SessionId: {0}. GroupId {1}.",
					data.SessionId, data.BatchId);
		}

		private void HandleMandrillEmailResult(int bulkEmailRId, int mailingStartTS, IEnumerable<EmailResult> emailResults,
				Dictionary<string, int> emailContactCollection, TypedCounter<BulkEmailResponseCode> resultsCounter) {
			InsertBuilder initialStatusInsertBuilder = new InsertBuilder(UserConnection,
				"INSERT INTO \"MandrillSentMessage\" (\"MandrillId\", \"BulkEmailRId\", \"ContactRId\", "
				+ "\"ResponseCode\", \"MailingStartTS\")VALUES", "('{0}','{1}','{2}','{3}','{4}')");
			foreach (EmailResult emailResult in emailResults) {
				EmailResultStatus emailResultStatus = emailResult.Status;
				BulkEmailResponseCode response;
				if (emailResult.Email == null) {
					continue;
				}
				try {
					response = emailResultStatus.GetBulkEmailResponseCode();
				} catch (InvalidCastException) {
					MandrillUtilities.Log.InfoFormat(
						"[MandrillService.HandleMandrillEmailResult]: EmailResult {0} ignored. " +
						"Unsupported status {1}.", emailResult.Email, emailResult.Status);
					continue;
				}
				Guid mandrillId = Guid.Empty;
				if (!Guid.TryParse(emailResult.Id, out mandrillId)) {
					MandrillUtilities.Log.InfoFormat(
						"[MandrillService.HandleMandrillEmailResult]: EmailResult {0} ignored. " +
						"Incorrect Id {1}.", emailResult.Email, emailResult.Id);
					continue;
				}
				if (!emailContactCollection.TryGetValue(emailResult.Email, out int contactRId)) {
					MandrillUtilities.Log.InfoFormat(
						"[MandrillService.HandleMandrillEmailResult]: EmailResult {0} ignored. An unknown email.",
						emailResult.Email);
					continue;
				}
				initialStatusInsertBuilder.InsertRow(mandrillId, bulkEmailRId, contactRId, (int)response, mailingStartTS);
				resultsCounter.Count(response);
			}
			initialStatusInsertBuilder.ExecuteInsert();
		}

		private string EscapeSingleQuote(string stringToCheck) {
			return stringToCheck.Replace("'", "''");
		}

		private int GetBulkEmailRId(Guid bulkEmailId) {
			var select = new Select(UserConnection)
				.Column("RId")
				.From("BulkEmail")
				.Where("Id").IsEqual(Column.Parameter(bulkEmailId)) as Select;
			return select.ExecuteScalar<int>();
		}

		private int GetBulkEmailSentMessageCount(int bulkEmailRId) {
			var select = new Select(UserConnection)
				.Column(Func.Count("Id"))
				.From("MandrillRecipient")
				.Where("IsSent").IsEqual(Column.Const(true))
				.And("BulkEmailRId").IsEqual(Column.Parameter(bulkEmailRId)) as Select;
			return select.ExecuteScalar<int>();
		}

		private void SetBulkEmailErrorStatus(BulkEmail bulkEmail) {
			Guid status;
			if (MarketingConsts.TriggeredEmailBulkEmailCategoryId.Equals(bulkEmail.CategoryId)) {
				status = MarketingConsts.BulkEmailStatusActiveId;
			} else if (MarketingConsts.MassmailingBulkEmailCategoryId.Equals(bulkEmail.CategoryId)) {
				status = MarketingConsts.BulkEmailStatusErrorId;
			} else {
				throw new ArgumentException(string.Format("Unknown BulkEmail category: {0}.", bulkEmail.CategoryId));
			}
			SetBulkEmailStatus(bulkEmail, status);
		}

		private void SetBulkEmailCompletedStatus(BulkEmail bulkEmail) {
			Guid status;
			if (MarketingConsts.TriggeredEmailBulkEmailCategoryId.Equals(bulkEmail.CategoryId)) {
				status = MarketingConsts.BulkEmailStatusActiveId;
			} else if (MarketingConsts.MassmailingBulkEmailCategoryId.Equals(bulkEmail.CategoryId)) {
				status = MarketingConsts.BulkEmailStatusFinishedId;
			} else {
				throw new ArgumentException(string.Format("Unknown BulkEmail category: {0}.", bulkEmail.CategoryId));
			}
			SetBulkEmailStatus(bulkEmail, status);
		}

		private void PrepareCommunicationLimitRules(BulkEmail bulkEmail) {
			if (!MarketingConsts.MassmailingBulkEmailCategoryId.Equals(bulkEmail.CategoryId)) {
				return;
			}
			var esq = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "BulkEmailCountLimit");
			esq.AddColumn("Id");
			EntityCollection esqCollection = esq.GetEntityCollection(UserConnection);
			if (esqCollection.Count > 0) {
				try {
					MandrillUtilities.ExecuteStoredProcedure(UserConnection, "tsp_SetBECLimit",
					new KeyValuePair<string, object>("BulkEmailId", bulkEmail.Id));
				} catch (Exception e) {
					MandrillUtilities.Log.ErrorFormat(
					"[MandrillService.ExecuteSendMessage]: Failed to set communication limit.BulkEmailId: {0}.", bulkEmail.Id);
				}
			}
		}

		private void ExecuteSendMessage(SendMessageData messageData, bool isResend = false) {
			Guid sessionId = Guid.NewGuid();
			UserConnection = messageData.UserConnection;
			BulkEmail bulkEmail = messageData.BulkEmail;
			MandrillUtilities.Log.InfoFormat(
				"[MandrillService.ExecuteSendMessage]: Start: BulkEmail.Id: {0}, SessionId: {1}",
				bulkEmail.Id, sessionId);
			int bulkEmailRId = GetBulkEmailRId(bulkEmail.Id);
			ActiveContactsValidationResult validationResult =
				ActiveContactsHelper.ValidatePermissionEditBulkEmail(UserConnection);
			if (validationResult.Code == ActiveContactsValidationResult.Error) {
				SetBulkEmailErrorStatus(bulkEmail);
				CreateReminding(bulkEmail, validationResult.Message);
				MailingUtilities.Log.ErrorFormat(
					"[MandrillService.ExecuteSendMessage]: License check failed. SessionId: {0}.", sessionId);
				return;
			}
			object pingResult;
			if (!Utilities.TryExecute(
					ServiceApi.Ping, MandrillServicePingAttemptsCount, MandrillServicePingTimeout, out pingResult)) {
				SetBulkEmailErrorStatus(bulkEmail);
				CreateReminding(bulkEmail, "MandrillPingFailsMsg");
				MandrillUtilities.Log.ErrorFormat(
					"[MandrillService.ExecuteSendMessage]: MandrillApi.Ping Fails. SessionId: {0}.", sessionId);
				return;
			}
			InitializeCustomMetadata();
			var messageImages = new List<image>();
			var macrosHelper = new MarketingMacrosHelper(UserConnection);
			string templateName =
				SaveTemplate(bulkEmail, messageImages, messageData.ApplicationUrl, macrosHelper);
			if (string.IsNullOrEmpty(templateName)) {
				SetBulkEmailErrorStatus(bulkEmail);
				CreateReminding(bulkEmail, "MandrillTemplateFailsMsg");
				MandrillUtilities.Log.InfoFormat(
					"[MandrillService.ExecuteSendMessage]: Error while saving template. SessionId: {0}.", sessionId);
				return;
			}
			int previousSentCounter = 0;
			int recipientCount = GetInQueueCount(bulkEmail.Id);
			SetBulkEmailStatus(bulkEmail, MarketingConsts.BulkEmailStatusLaunchedId);
			if (isResend) {
				ActualizeRecipientsBeforeSend(bulkEmailRId);
				GetBulkEmailSentMessageCount(bulkEmailRId);
				UpdateBulkEmail(bulkEmail.Id, new KeyValuePair<string, object>("SendStartDate", DateTime.UtcNow));
			} else {
				UpdateBulkEmail(bulkEmail.Id,
					new KeyValuePair<string, object>("SendStartDate", DateTime.UtcNow),
					new KeyValuePair<string, object>("InQueueCount", recipientCount),
					new KeyValuePair<string, object>("RecipientCount", recipientCount),
					new KeyValuePair<string, object>("NotDeliveredCount", 0),
					new KeyValuePair<string, object>("DeliveredCount", 0),
					new KeyValuePair<string, object>("CanceledCount", 0)
				);
			}
			PrepareCommunicationLimitRules(bulkEmail);
			CultureInfo culture = Thread.CurrentThread.CurrentCulture;
			List<Task> tasks = new List<Task>();
			int processedGroupsCounter = 0;
			bool hasDataToProceed = true;
			int lastFailedGroupId = 0;
			int failedGroupAttemptsCounter = 0;
			const int groupProcessingAttemptsLimit = 10;
			const int failedGroupsLimit = 100;
			int sentRecipientCounter = 0;
			int failedGroupsCounter = 0;
			int batchId = 0;
			var sendResults = new List<TypedCounter<BulkEmailResponseCode>>();
			bool isBreaking = false;
			int sendDelayInSeconds = (int)Terrasoft.Core.Configuration.SysSettings.GetValue(UserConnection,
					"MandrillMailingDelayInSeconds");
			DateTime startDateUtc = TimeZoneInfo.ConvertTimeToUtc(bulkEmail.StartDate,
				UserConnection.CurrentUser.TimeZone);
			PrepareRecipientsInfo prepareRecipientsInfo = new PrepareRecipientsInfo() {
				SessionId = sessionId,
				BulkEmailRId = bulkEmailRId,
				BulkEmailId = bulkEmail.Id,
				BulkEmailStartDate = startDateUtc,
				BulkEmailCategoryId = bulkEmail.CategoryId,
				BatchLength = MassMailingRecipientsLimit,
				ApplicationUrl = messageData.ApplicationUrl
			};
			bool isTriggeredCategory = (bulkEmail.CategoryId == MarketingConsts.TriggeredEmailBulkEmailCategoryId);
			int mailingStartTS = isTriggeredCategory ? Utilities.ConvertDateTimeToTimestamp(bulkEmail.StartDate) : 0;
			if (!isTriggeredCategory) {
				Thread.Sleep(sendDelayInSeconds * 1000);
			}
			while (hasDataToProceed) {
				BatchSendThreadPool.WaitOne();
				Guid currentBulkEmailStatus = GetBulkEmailStatus(bulkEmail.Id);
				if (currentBulkEmailStatus == MarketingConsts.BulkEmailStatusStoppedId) {
					isBreaking = true;
					BatchSendThreadPool.Release();
					break;
				}
				++batchId;
				EmailMessage message = InitEmailMessage(bulkEmail, messageImages, macrosHelper);
				Dictionary<string, int> emailContactCollection;
				prepareRecipientsInfo.BatchId = batchId;
				int nextBatchLength = PrepareRecipients(prepareRecipientsInfo, macrosHelper, message,
					out emailContactCollection);
				if (nextBatchLength < 0) {
					if (lastFailedGroupId == batchId) {
						failedGroupAttemptsCounter++;
						if (failedGroupAttemptsCounter == groupProcessingAttemptsLimit) {
							failedGroupAttemptsCounter = 0;
							lastFailedGroupId = 0;
						}
					} else {
						lastFailedGroupId = batchId;
						failedGroupAttemptsCounter = 0;
						failedGroupsCounter++;
					}
					if (failedGroupsCounter == failedGroupsLimit) {
						MandrillUtilities.Log.InfoFormat(
							"[MandrillService.ExecuteSendMessage]: Terminated. Failed groups limit reached. " +
							"BulkEmail.Id: {0}, SessionId: {1}", bulkEmailRId, sessionId);
						hasDataToProceed = false;
					} else {
						hasDataToProceed = true;
					}
					BatchSendThreadPool.Release();
					continue;
				} else {
					lastFailedGroupId = 0;
				}
				hasDataToProceed = (nextBatchLength > 0);
				processedGroupsCounter = processedGroupsCounter + (hasDataToProceed ? 1 : 0);
				if (hasDataToProceed) {
					sentRecipientCounter += nextBatchLength;
					tasks.Add(
						Task.Factory.StartNew(() => {
							Thread.CurrentThread.CurrentCulture = culture;
							var resultsCounter = new TypedCounter<BulkEmailResponseCode>();
							resultsCounter.Register("InvalidAddressee", BulkEmailResponseCode.Invalid);
							resultsCounter.Register("Sent", BulkEmailResponseCode.Sent);
							SendBatch(new SendBatchData(UserConnection, sessionId, batchId, bulkEmailRId, mailingStartTS, templateName,
								message, emailContactCollection), resultsCounter);
							sendResults.Add(resultsCounter);
						}));
				} else {
					BatchSendThreadPool.Release();
				}
			}
			Task.WaitAll(tasks.ToArray());
			int sentCount = sendResults.Sum("Sent");
			int invalidAddresseeCount = sendResults.Sum("InvalidAddressee");
			QueryColumnExpression sentExpression = GetIsNotEmptyCountColumnExpression(sentCount, "SendCount");
			QueryColumnExpression invalidAdreseeExpression = GetIsNotEmptyCountColumnExpression(invalidAddresseeCount,
				"InvalidAddresseeCount");
			if (isBreaking) {
				SetBulkEmailStatus(bulkEmail, MarketingConsts.BulkEmailStatusStoppedId);
				QueryColumnExpression actualInvalidAdresseeExpression = GetAddCountColumnExpression(
					"InvalidAddresseeCount", invalidAddresseeCount);
				QueryColumnExpression actualSentExpression = GetAddCountColumnExpression("SendCount", sentCount);
				UpdateBulkEmail(bulkEmail.Id,
					new KeyValuePair<string, object>("SendStartDate", Column.Const(null)),
					new KeyValuePair<string, object>("SendDueDate", Column.Const(null)),
					new KeyValuePair<string, object>("InvalidAddresseeCount", actualInvalidAdresseeExpression),
					new KeyValuePair<string, object>("SendCount", actualSentExpression));
				CreateReminding(bulkEmail, "MandrillStoppedMailingMsg");
				MandrillUtilities.Log.InfoFormat("BulkEmail with Id: {0} Was stopped manually.", bulkEmail.Id);
				return;
			}
			UpdateBulkEmail(bulkEmail.Id,
				new KeyValuePair<string, object>("SendDueDate", DateTime.UtcNow),
				new KeyValuePair<string, object>("CanceledCount", recipientCount - sentRecipientCounter),
				new KeyValuePair<string, object>("InvalidAddresseeCount", invalidAddresseeCount),
				new KeyValuePair<string, object>("SendCount", sentExpression));
			MandrillUtilities.Log.InfoFormat(
				"[MandrillService.ExecuteSendMessage]: Finished: BulkEmail.Id: {0}, SessionId: {1}",
				bulkEmail.Id, sessionId);
			if (processedGroupsCounter == 0) {
				SetBulkEmailErrorStatus(bulkEmail);
				CreateReminding(bulkEmail, "MandrillNoRecipientsMsg");
				MandrillUtilities.Log.InfoFormat("BulkEmail with Id: {0} Has no recipients.", bulkEmail.Id);
				return;
			}
			SetBulkEmailCompletedStatus(bulkEmail);
			CreateReminding(bulkEmail, "MandrillMassMailingFinishedMsg");
		}

		private QueryColumnExpression GetIsNotEmptyCountColumnExpression(int value, string columnName) {
			QueryCase queryCase = new QueryCase();
			QueryCondition queryCondition = new QueryCondition(QueryConditionType.Equal) {
				LeftExpression = new QueryColumnExpression(columnName)
			};
			queryCondition.RightExpressions.Add(Column.Const(0));
			queryCase.AddWhenItem(queryCondition, Column.Parameter(value));
			queryCase.ElseExpression = new QueryColumnExpression(columnName);
			return new QueryColumnExpression(queryCase);
		}

		private QueryColumnExpression GetAddCountColumnExpression(string columnName, int value) {
			return QueryColumnExpression.Add(new QueryColumnExpression(columnName),
				new QueryColumnExpression(new QueryParameter(value)));
		}

		private EmailsListWithoutMandrillIdResponse GetEmailsListWithoutMandrillId() {
			var response = new EmailsListWithoutMandrillIdResponse();
			var selectQuery = new Select(UserConnection)
				.Top(100)
				.Column("d", "Id").Column("BulkEmailId").Column("EmailAddress")
				.From("BulkEmailTarget").As("d")
				.InnerJoin("BulkEmailResponse").As("r").On("r", "Id").IsEqual("d", "BulkEmailResponseId")
				.Where("BulkEmailId")
					.In(new Select(UserConnection).Top(1).Column("Id")
						.From("BulkEmail").As("b")
					.Where("b", "StatusId").IsEqual(Column.Parameter(
							MarketingConsts.BulkEmailStatusFinishedId))
					.And().Exists(new Select(UserConnection).Column("t", "Id")
						.From("BulkEmailTarget").As("t")
						.InnerJoin("BulkEmailResponse").As("rr").On("rr", "Id")
							.IsEqual("t", "BulkEmailResponseId")
						.Where("t", "MandrillId").IsNull()
						.And("BulkEmailId").IsEqual("b", "Id")
						.And("rr", "IsFinalState").IsEqual(Column.Const(false))
					)
				)
				.And("d", "MandrillId").IsNull()
				.And("r", "IsFinalState").IsEqual(Column.Const(false))
				.And().Not()
					.Exists(new Select(UserConnection)
						.Column("EmailAddress")
					.From("OPPEmailInitialStatus").As("oop")
					.Where("d", "BulkEmailId").IsEqual("oop", "BulkEmailId")
					.And("d", "EmailAddress").IsEqual("oop", "EmailAddress")
				) as Select;
			using (DBExecutor dbExecutor = UserConnection.EnsureDBConnection()) {
				using (IDataReader reader = selectQuery.ExecuteReader(dbExecutor)) {
					while (reader.Read()) {
						int idColumnIndex = reader.GetOrdinal("BulkEmailId");
						int emailColumnIndex = reader.GetOrdinal("EmailAddress");
						response.BulkEmailId = reader.GetGuid(idColumnIndex);
						string address = reader.GetString(emailColumnIndex);
						response.EmailsList.Add(address);
					}
				}
			}
			return response;
		}

		private SearchResponseFromMandrill GetMandrillSearchResult(SearchRequestInMandrill data) {
			var bulkEmailId = data.BulkEmailId;
			var searchResponse = new SearchResponseFromMandrill(bulkEmailId, data.EmailsList);
			MandrillUtilities.Log.InfoFormat(
				"[MandrillService.GetMandrillSearchResult]: Start: SessionId: {0}. BulkEmailId: {1}.",
				data.SessionId, bulkEmailId);
			if ((data.EmailsList == null) || (data.EmailsList.Count == 0)) {
				return searchResponse;
			}
			var emailList = data.EmailsList.Aggregate("", (current, user) => current + (user + " OR "));
			emailList = emailList.Substring(0, emailList.Length - 3);
			var query = string.Format("u_{0}:{1} AND email:{2}", BulkEmailMetadataValue, bulkEmailId.ToString("N"),
				emailList);
			var searchRequest = new Search {
				limit = "1000",
				query = query,
			};
			try {
				searchResponse.SearchResults = ServiceApi.Search(searchRequest);
			} catch (Exception e) {
				MandrillUtilities.Log.ErrorFormat(
					"[MandrillService.GetMandrillSearchResult]: Error while sanding Search request."
					+ "SessionId: {1}. BulkEmailId: {2}.", e, data.SessionId, bulkEmailId);
				searchResponse.Failed = true;
			}
			MandrillUtilities.Log.InfoFormat(
				"[MandrillService.GetMandrillSearchResult]: Success: SessionId: {0}. BulkEmailId {1}.",
				data.SessionId, bulkEmailId);
			return searchResponse;
		}

		private List<InitialStatusesPackage> AnalyzeSearchResult(SearchResponseFromMandrill data) {
			var response = new List<InitialStatusesPackage>();
			if (data.Failed) {
				response.AddRange(data.EmailsList.Select(sender => new InitialStatusesPackage {
					BulkEmailId = data.BulkEmailId,
					EmailAddress = sender,
					EmailResponseId = MarketingConsts.BulkEmailResponseRequestFailedId,
					MandrillId = null
				}));
				return response;
			}
			foreach (SearchResult target in data.SearchResults) {
				data.EmailsList.Remove(target.email);
				EmailResultStatus emailResultStatus = ((EmailResultStatus)target.state);
				Guid responseId = emailResultStatus.GetBulkEmailResponse();
				if (responseId == Guid.Empty) {
					MandrillUtilities.Log.InfoFormat(
						"[MandrillService.AnalyzeSearchResult]: EmailResult {0} ignored. " +
						"Unsupported status {1}.", data.BulkEmailId, target.state);
				}
				if (!Guid.TryParse(target._id, out Guid mandrillId)) {
					MandrillUtilities.Log.InfoFormat(
						"[MandrillService.AnalyzeSearchResult]: EmailResult {0} ignored. " +
						"Incorrect Id {1}.", data.BulkEmailId, target._id);
				}
				if (responseId == Guid.Empty || mandrillId == Guid.Empty) {
					response.Add(new InitialStatusesPackage {
						BulkEmailId = data.BulkEmailId,
						EmailAddress = target.email,
						EmailResponseId = MarketingConsts.BulkEmailResponseRequestFailedId,
						MandrillId = null
					});
				} else {
					response.Add(new InitialStatusesPackage {
						BulkEmailId = data.BulkEmailId,
						EmailAddress = target.email,
						EmailResponseId = ((EmailResultStatus)target.state).GetBulkEmailResponse(),
						MandrillId = mandrillId
					});
				}
			}
			response.AddRange(data.EmailsList.Select(email => new InitialStatusesPackage {
				BulkEmailId = data.BulkEmailId,
				EmailAddress = email,
				EmailResponseId = MarketingConsts.BulkEmailResponseRequestFailedId,
				MandrillId = null
			}));
			return response;
		}

		private void SaveInitialStatuses(List<InitialStatusesPackage> data) {
			var initialStatusInsertBuilder = new InsertBuilder(UserConnection,
				"INSERT INTO OPPEmailInitialStatus (\"MandrillId\", \"BulkEmailId\", \"EmailAddress\", " +
				"\"EmailResponseId\")VALUES", "('{0}','{1}','{2}','{3}')");
			foreach (var oppStatuses in data) {
				if (oppStatuses.MandrillId == null || oppStatuses.MandrillId == Guid.Empty) {
					var updateQuery = new Update(UserConnection, "BulkEmailTarget")
						.Set("BulkEmailResponseId", Column.Parameter(oppStatuses.EmailResponseId))
						.Set("ModifiedById", Column.Parameter(MarketingConsts.MandrillUserId))
						.Set("ModifiedOn", Column.Parameter(DateTime.UtcNow))
						.Where("BulkEmailId").IsEqual(Column.Parameter(oppStatuses.BulkEmailId))
						.And("EmailAddress").IsEqual(Column.Parameter(oppStatuses.EmailAddress));
					updateQuery.Execute();
				} else {
					initialStatusInsertBuilder.InsertRow(oppStatuses.MandrillId, oppStatuses.BulkEmailId,
						EscapeSingleQuote(oppStatuses.EmailAddress), oppStatuses.EmailResponseId);
				}
			}
			initialStatusInsertBuilder.ExecuteInsert();
		}

		private bool CanExecuteBulkEmail(Guid statusId) {
			return (statusId == MarketingConsts.BulkEmailStatusErrorId ||
					statusId == MarketingConsts.BulkEmailStatusStoppedId ||
					statusId == MarketingConsts.BulkEmailStatusPlannedId ||
					statusId == MarketingConsts.BulkEmailStatusStartPlanedId ||
					statusId == MarketingConsts.BulkEmailStatusActiveId);
		}

		private void ActualizeRecipientsBeforeSend(int bulkEmailRId) {
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
			} catch (System.Data.SqlClient.SqlException e) {
				MandrillUtilities.Log.ErrorFormat(
					"[MandrillService.ActualizeRecipientsBeforeSend]: "
					+ "Update of BulkEmail: {0} fails.", e, bulkEmailRId);
			}
		}

		private Select AddRestrictionsToRecipientsBatchSelect(Select select,
				PrepareRecipientsInfo prepareRecipientsInfo) {
			select = select.Where("Contact", "Email").Not().IsNull()
				.And("Contact", "Email").IsNotEqual(Column.Const(string.Empty))
				.And("Contact", "IsNonActualEmail").IsEqual(Column.Const(false))
				.And("Contact", "DoNotUseEmail").IsEqual(Column.Const(false))
				.And("MandrillRecipient", "BulkEmailRId").IsEqual(Column.Parameter(prepareRecipientsInfo.BulkEmailRId))
				.And("MandrillRecipient", "IsSent").IsEqual(Column.Const(false)) as Select;
			if (prepareRecipientsInfo.BulkEmailCategoryId.Equals(MarketingConsts.TriggeredEmailBulkEmailCategoryId)) {
				int timeStamp = Utilities.ConvertDateTimeToTimestamp(prepareRecipientsInfo.BulkEmailStartDate);
				select = select.And("MandrillRecipient", "Timestamp").IsEqual(Column.Parameter(timeStamp)) as Select;
			}
			return select;
		}

		private Select GetRecipientsBatchSelectWithoutPageable(PrepareRecipientsInfo prepareRecipientsInfo) {
			var recipientSelect = new Select(UserConnection)
				.Column("MandrillRecipient", "ContactRId").As("ContactRId")
				.Column("MandrillRecipient", "EmailAddress").As("EmailAddress")
				.Column("Contact", "Id").As("ContactId")
				.From("MandrillRecipient")
				.InnerJoin("Contact").On("MandrillRecipient", "ContactRId").IsEqual("Contact", "RId") as Select;
			recipientSelect = AddRestrictionsToRecipientsBatchSelect(recipientSelect, prepareRecipientsInfo);
			HintsHelper.SpecifyNoLockHints(recipientSelect, true);
			return recipientSelect;
		}

		private Select GetRecipientsBatchSelectWithPageable(PrepareRecipientsInfo prepareRecipientsInfo) {
			var innerRecipientSelect = new Select(UserConnection)
				.Column("MandrillRecipient", "ContactRId").As("ContactRId")
				.Column("MandrillRecipient", "EmailAddress").As("EmailAddress")
				.Column("Contact", "Id").As("ContactId")
				.Column(Column.SqlText("(ROW_NUMBER() OVER (ORDER BY \"MandrillRecipient\".\"Id\"))")).As("RowNum")
				.From("MandrillRecipient")
				.InnerJoin("Contact").On("MandrillRecipient", "ContactRId").IsEqual("Contact", "RId") as Select;
			innerRecipientSelect = AddRestrictionsToRecipientsBatchSelect(innerRecipientSelect, prepareRecipientsInfo);
			int lowPackageEdge = prepareRecipientsInfo.GetLowPackageEdge();
			int highPackageEdge = prepareRecipientsInfo.GetHighPackageEdge();
			var recipientSelect = new Select(UserConnection)
				.Column("MandrillDeliveryPackage", "ContactRId")
				.Column("MandrillDeliveryPackage", "EmailAddress")
				.Column("MandrillDeliveryPackage", "ContactId")
				.From(innerRecipientSelect)
				.As("MandrillDeliveryPackage")
				.Where("RowNum").IsBetween(Column.Parameter(lowPackageEdge))
					.And(Column.Parameter(highPackageEdge)) as Select;
			HintsHelper.SpecifyNoLockHints(recipientSelect, true);
			return recipientSelect;
		}

		private Select GetRecipientsBatchSelect(PrepareRecipientsInfo prepareRecipientsInfo,
				MarketingMacrosHelper macrosHelper, bool usePageable = true) {
			return usePageable
				? GetRecipientsBatchSelectWithPageable(prepareRecipientsInfo)
				: GetRecipientsBatchSelectWithoutPageable(prepareRecipientsInfo);
		}

		private Dictionary<Guid, string> GetRecipents(Select select, ref Dictionary<string, int> emailContactCollection,
			ref List<EmailAddress> recipientsList) {
			var result = new Dictionary<Guid, string>();
			using (DBExecutor dbExecutor = UserConnection.EnsureDBConnection()) {
				using (IDataReader reader = select.ExecuteReader(dbExecutor)) {
					int emailColumnIndex = reader.GetOrdinal("EmailAddress");
					int contactRIdColumnIndex = reader.GetOrdinal("ContactRId");
					int contactIdColumnIndex = reader.GetOrdinal("ContactId");
					while (reader.Read()) {
						string address = reader.GetString(emailColumnIndex);
						int contactRId = reader.GetInt32(contactRIdColumnIndex);
						Guid contactId = reader.GetGuid(contactIdColumnIndex);
						emailContactCollection[address] = contactRId;
						var emailAddress = new EmailAddress(address);
						if (!result.ContainsKey(contactId)) {
 	 	 	 				recipientsList.Add(emailAddress);
 	 	 	 				result.Add(contactId, address);
 	 	 	 			}

					}
				}
			}
			return result;
		}

		private int PrepareRecipients(PrepareRecipientsInfo prepareRecipientsInfo, MarketingMacrosHelper macrosHelper,
				EmailMessage emailMessage, out Dictionary<string, int> emailContactCollection) {
			const int errorValue = -1;
			emailContactCollection = new Dictionary<string, int>();
			int recipientsCounter = 0;
			var recipientsList = new List<EmailAddress>();
			emailMessage.InitRecipientVariable();
			Select recipientSelect = GetRecipientsBatchSelect(prepareRecipientsInfo, macrosHelper);
			try {
				Dictionary<Guid, string> contactCollection = GetRecipents(recipientSelect, ref emailContactCollection,
					ref recipientsList);
				recipientsCounter = contactCollection.Count;
				var select = new Select(UserConnection).Column("ContactId").From(recipientSelect)
					.As("IdSubSelect") as Select;
				var result = macrosHelper.GetRecipientsMacrosCollection(select, contactCollection,
					prepareRecipientsInfo.BulkEmailRId);
				foreach (var merge_var in result) {
					emailMessage.merge_vars.Add(merge_var);
				}
			} catch (System.Data.SqlClient.SqlException e) {
				MandrillUtilities.Log.ErrorFormat(
					"[MandrillService.PrepareRecipients]: Group processing fails. SessionId: {0}. GroupId: {1}.",
					e, prepareRecipientsInfo.SessionId, prepareRecipientsInfo.BatchId);
				return errorValue;
			}
			emailMessage.to = recipientsList;
			return recipientsCounter;
		}

		private Guid GetBulkEmailStatus(Guid bulkEmailId) {
			var select = new Select(UserConnection)
				.Column("StatusId")
			.From("BulkEmail")
			.Where("Id").IsEqual(Column.Parameter(bulkEmailId)) as Select;
			return select.ExecuteScalar<Guid>();
		}

		private void SetBulkEmailStatus(BulkEmail bulkEmail, Guid statusId) {
			Guid bulkEmailId = Guid.Empty;
			try {
				bulkEmailId = bulkEmail.Id;
				bulkEmail.SetColumnValue("StatusId", statusId);
				bulkEmail.Save();
				if (bulkEmail.SplitTestId != Guid.Empty) {
					SetBulkEmailSplitStatus(bulkEmail.SplitTestId, statusId);
				}
				MandrillUtilities.Log.InfoFormat(
					"BulkEmail with Id: {0} set to {1} status.", bulkEmailId, statusId);
			} catch (Exception e) {
				MandrillUtilities.Log.ErrorFormat(
					"[MandrillService.SetBulkEmailStatus]: Error while saving BulkEmail with Id: {0}",
					e, bulkEmailId);
			}
		}

		private void SetBulkEmailSplitStatus(Guid splitTestId, Guid bulkEmailStatusId) {
			try {
				var bulkEmailSplit = new BulkEmailSplit(UserConnection);
				if (!bulkEmailSplit.FetchFromDB(splitTestId)) {
					MandrillUtilities.Log.ErrorFormat(
						"[MandrillService.SetBulkEmailSplitStatus]: Failed to fetch BulkEmailSplit from DB." +
						"Id: {0}", splitTestId);
					return;
				}
				if (bulkEmailStatusId == MarketingConsts.BulkEmailStatusStartsId &&
						bulkEmailSplit.StatusId == MarketingConsts.BulkEmailSplitStatusStartPlanedId) {
					bulkEmailSplit.SetColumnValue("StatusId", MarketingConsts.BulkEmailSplitStatusLaunchedId);
				}
				if (bulkEmailStatusId == MarketingConsts.BulkEmailStatusFinishedId) {
					var selectCount = new Select(UserConnection)
						.Column(Func.Count("Id"))
						.From("BulkEmail")
						.Where("SplitTestId").IsEqual(Column.Parameter(splitTestId))
							.And("StatusId").IsNotEqual(Column.Parameter(MarketingConsts.BulkEmailStatusFinishedId)) as Select;
					var count = selectCount.ExecuteScalar<int>();
					if (count == 0) {
						bulkEmailSplit.SetColumnValue("StatusId", MarketingConsts.BulkEmailSplitStatusFinishedId);
						string tableName = string.Format("ST_{0}", splitTestId.ToBase36());
						Utilities.DropTable(tableName, UserConnection, true);
					}
				}
				bulkEmailSplit.Save();
			} catch (Exception e) {
				MandrillUtilities.Log.ErrorFormat(
					"[MandrillService.SetBulkEmailSplitStatus]: Error while saving BulkEmailSplit with Id: {0}",
					e, splitTestId);
			}
		}

		private int GetInQueueCount(Guid bulkEmailId) {
			Select countSelect = new Select(UserConnection)
				.Column(Func.Count("Id"))
				.From("VwMandrillRecipient")
				.Where("BulkEmailId").IsEqual(Column.Parameter(bulkEmailId)) as Select;
			HintsHelper.SpecifyNoLockHints(countSelect, true);
			return countSelect.ExecuteScalar<int>();
		}

		private string SaveTemplate(BulkEmail bulkEmail, List<image> messageImages, string applicationUrl,
				MarketingMacrosHelper macrosHelper) {
			string templateName =
				string.Format(MandrillTemplateNamePattern, bulkEmail.TemplateSubject, bulkEmail.Id.ToString("N"));
			bool templateExist = true;
			try {
				ServiceApi.TemplateInfo(templateName);
			} catch {
				templateExist = false;
			}
			string templateBodyWithMacros = macrosHelper.SetTemplateBody(bulkEmail.TemplateBody, bulkEmail.OwnerId, bulkEmail.Id, applicationUrl);
			string templateCode = InlineimagesProcessing(templateBodyWithMacros, messageImages, applicationUrl);
			if (string.IsNullOrEmpty(templateCode)) {
				return string.Empty;
			}
			templateCode = UtmHelper.GetTemplateCodeWithUtmLabel(bulkEmail.ConvertToUtmData(templateCode),
					GetBulkEmailRId(bulkEmail.Id), macrosHelper.UnsubscribeMacrosAliases);
			int templateSize = MandrillUtilities.GetTemplateSize(templateCode, messageImages);
			if (templateSize > MandrillMaxTemplateSize) {
				MandrillUtilities.Log.ErrorFormat(
					string.Format("[MandrillService.SaveTemplate]: Template {0} have size more than {1}."),
					templateName, MandrillMaxTemplateSize);
				return string.Empty;
			}
			try {
				if (!templateExist) {
					ServiceApi.AddTemplate(templateName, string.Empty, string.Empty, bulkEmail.TemplateSubject,
						templateCode, string.Empty, true);
				} else {
					ServiceApi.UpdateTemplate(templateName, string.Empty, string.Empty, bulkEmail.TemplateSubject,
						templateCode, string.Empty, true, null);
				}
			} catch {
				templateName = string.Empty;
			}
			return templateName;
		}

		private string GetLczStringValue(string lczName) {
			string localizableStringName = string.Format("LocalizableStrings.{0}.Value", lczName);
			var localizableString = new LocalizableString(
				UserConnection.Workspace.ResourceStorage, "MandrillService", localizableStringName);
			return localizableString.Value ?? localizableString
				.GetCultureValue(GeneralResourceStorage.DefCulture, false);
		}

		private string GetMandrillPayload(HttpRequest request, NameValueCollection rawPostData) {
			var appUrl = request.Url.ToString();
			var sb = new StringBuilder(appUrl);
			rawPostData.AllKeys.OrderBy(x => x).BulkEmail(x => sb.Append(x).Append(rawPostData[x]));
			return sb.ToString();
		}

		private bool IsRequestAuthenticate(string key, HttpRequest request, NameValueCollection rawPostData) {
			if (request.Headers.AllKeys.Contains("X-Mandrill-Signature") &&
				request.Headers["X-Mandrill-Signature"] == "6639391572") {
				return true;
			}
			if (string.IsNullOrEmpty(key)) {
				MandrillUtilities.Log.ErrorFormat("[MandrillService.IsRequestAuthenticate]: The AuthKey is empty.");
				return false;
			}
			if (!request.Headers.AllKeys.Contains("X-Mandrill-Signature")) {
				MandrillUtilities.Log.ErrorFormat(
					"[MandrillService.IsRequestAuthenticate]: The header X-Mandrill-Signature not found.");
				return false;
			}
			string data = GetMandrillPayload(request, rawPostData);
			using (var hashAlg = new HMACSHA1(Encoding.UTF8.GetBytes(key))) {
				var hash = hashAlg.ComputeHash(Encoding.UTF8.GetBytes(data));
				string signature = request.Headers["X-Mandrill-Signature"];
				return (signature == Convert.ToBase64String(hash));
			}
		}

		private string GetMandrillAuthKey() {
			var result = string.Empty;
			var esq = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "MandrillWebhook");
			esq.AddColumn("AuthKey");
			EntityCollection mandrillWebhooks = esq.GetEntityCollection(UserConnection);
			foreach (Entity mandrillWebhook in mandrillWebhooks) {
				return mandrillWebhook.GetTypedColumnValue<string>("AuthKey");
			}
			return result;
		}

		private static string InlineimagesProcessing(string body, List<image> massageImages, string applicationUrl) {
			string resultString = body;
			var regexForImgTag = new Regex(@"<img.*?>", RegexOptions.Multiline | RegexOptions.IgnoreCase);
			Match regexForImgTagMatchResult = regexForImgTag.Match(resultString);
			string terrasoftSrc = "./terrasoft.axd?";
			string base64Src = "data:image";
			string cidPrefix = "IMG";
			int cidCounter = 0;
			bool isImageReady = false;
			string base64Data = string.Empty;
			string mimeType = string.Empty;
			string currentCid = string.Empty;
			while (regexForImgTagMatchResult.Success) {
				var currentImgTagString = regexForImgTagMatchResult.Value;
				if (string.IsNullOrEmpty(currentImgTagString)) {
					break;
				}
				Regex regexForImgSrc = new Regex("src=\".*?\"", RegexOptions.Multiline | RegexOptions.IgnoreCase);
				Match regexForImgSrcMatchResult = regexForImgSrc.Match(currentImgTagString);
				var currentImgSrcString = regexForImgSrcMatchResult.Value;
				if (string.IsNullOrEmpty(currentImgSrcString)) {
					break;
				}
				var currentImgSrcAddress = currentImgSrcString.Replace("\"", string.Empty);
				currentImgSrcAddress = currentImgSrcAddress.Replace("src=", string.Empty);
				if (currentImgSrcAddress.StartsWith(terrasoftSrc, StringComparison.OrdinalIgnoreCase)) {
					string fullImageUrl = string.Format("{0}/0/{1}", applicationUrl,
						HttpUtility.HtmlDecode(currentImgSrcAddress.TrimStart('.')));
					MandrillUtilities.LoadImageAsBase64(fullImageUrl, out base64Data, out mimeType);
					if (!string.IsNullOrEmpty(base64Data) && !string.IsNullOrEmpty(mimeType)) {
						isImageReady = true;
					}
				} else if (currentImgSrcAddress.StartsWith(base64Src, StringComparison.OrdinalIgnoreCase)) {
					const string mimeTypeSearchPattern = @"(?<=^data:)image/[a-z]+";
					mimeType = (new Regex(mimeTypeSearchPattern, RegexOptions.Singleline))
						.Match(currentImgSrcAddress).Value;
					if (!string.IsNullOrEmpty(mimeType)) {
						base64Data = currentImgSrcAddress.Replace(string.Format("data:{0};base64,", mimeType),
							string.Empty);
						isImageReady = true;
					}
				}
				if (isImageReady) {
					cidCounter++;
					currentCid = string.Format("{0}{1}", cidPrefix, cidCounter);
					var massageImage = new image() {
						name = currentCid,
						type = mimeType,
						content = base64Data
					};
					if (!massageImages.Any(x => x.content == massageImage.content)) {
						massageImages.Add(massageImage);
					}
					resultString = resultString.Replace(currentImgSrcAddress, string.Format("cid:{0}", currentCid));
					isImageReady = false;
					mimeType = string.Empty;
					base64Data = string.Empty;
				}
				regexForImgTagMatchResult = regexForImgTagMatchResult.NextMatch();
			}
			return resultString;
		}

		private EmailMessage InitEmailMessage(BulkEmail bulkEmail, List<image> messageImages,
			MarketingMacrosHelper macrosHelper, bool addBulkEmailIdentifier = true) {
			var message = new EmailMessage();
			message.subject = bulkEmail.TemplateSubject;
			message.from_email = bulkEmail.SenderEmail;
			message.from_name = bulkEmail.SenderName;
			message.track_clicks = true;
			message.track_opens = true;
			message.images = messageImages;
			message.inline_css = true;
			if (_isMetadataInitialized && addBulkEmailIdentifier) {
				message.AddMetadata("bulk_email_id", bulkEmail.Id.ToString("N"));
			}
			if (macrosHelper.GlobalMergeVars.Any()) {
				message.InitGlobalVariable();
				message.global_merge_vars.AddRange(macrosHelper.GlobalMergeVars);
			}
			return message;
		}

		private void PrepareTestRecipient(Guid contactId, string emailRecipient, MarketingMacrosHelper macrosHelper,
					EmailMessage emailMessage, string applicationUrl, Guid bulkEmailId) {
			var emailAddress = new EmailAddress(emailRecipient);
			if (contactId.Equals(Guid.Empty)) {
				emailMessage.to = new EmailAddress[] { emailAddress };
				return;
			}
			emailMessage.InitRecipientVariable();
			var merge = macrosHelper.GetRecipientMacros(contactId, emailRecipient, bulkEmailId);
			emailMessage.merge_vars.Add(merge);
			emailMessage.to = new EmailAddress[] { emailAddress };
			if (!emailMessage.to.Any()) {
				emailMessage.to = new EmailAddress[] { };
			}
		}

		private void UpdateBulkEmail(Guid bulkEmailId, params KeyValuePair<string, object>[] parameters) {
			if (!parameters.Any()) {
				return;
			}
			var update = new Update(UserConnection, "BulkEmail");
			foreach (KeyValuePair<string, object> parameter in parameters) {
				var expressionParameter = parameter.Value as QueryColumnExpression;
				if (expressionParameter != null) {
					update.Set(parameter.Key, expressionParameter);
				} else {
					update.Set(parameter.Key, Column.Parameter(parameter.Value));
				}
			}
			update = update.Where("Id").IsEqual(Column.Parameter(bulkEmailId)) as Update;
			update.Execute();
		}

		private string GetUnsubscribeKey() {
			string key = HttpContext.Current.Request.QueryString["key"];
			return (String.IsNullOrEmpty(key) || key.Length <= IntLength)
				? String.Empty
				: key;
		}

		private Guid GetBulkEmailIdByRId(int bulkEmailRId) {
			var select = new Select(UserConnection)
				.Column("Id")
				.From("BulkEmail")
				.Where("RId").IsEqual(Column.Parameter(bulkEmailRId)) as Select;
			return select.ExecuteScalar<Guid>();
		}

		private bool UnsubscribeUser(string email, int bulkEmailRId) {
			var result = false;
			try {
				bool unsubscribeFromAllMailings = (bool)Terrasoft.Core.Configuration.SysSettings.GetValue(
					UserConnection, "UnsubscribeFromAllMailings");
				if (unsubscribeFromAllMailings) {
					var insert = new InsertSelect(UserConnection)
						.Into("MandrillUnsubscribeEmail")
						.Set("BulkEmailRId", "ContactRId", "Email")
						.FromSelect(
							new Select(UserConnection)
								.Column(Column.Parameter(bulkEmailRId)).As("BulkEmailRId")
								.Column("ContactRId").As("ContactRId")
								.Column(Column.Parameter(email)).As("Email")
								.From("MandrillRecipient")
								.Where("BulkEmailRId").IsEqual(Column.Parameter(bulkEmailRId))
								.And("EmailAddress").IsEqual(Column.Parameter(email)) as Select
						);
					insert.Execute();
				}
				result = true;
			} catch (Exception e) {
				MandrillUtilities.Log.ErrorFormat(
					"[MandrillService.UnsubscribeRecipient]: UnsubscribeUser method is failed for email=" +
					"{0}. {1}", email, e);
			}
			return result;
		}

#if !NETSTANDARD2_0
		private System.ServiceModel.Channels.Message GetRedirection(bool unsubscriptionIsSuccessful,
				string email = "") {
			string redirectUrl = (string)Terrasoft.Core.Configuration.SysSettings.GetValue(UserConnection,
				"RedirectUnsuscribersTo");
			WebOperationContext currentContext = WebOperationContext.Current;
			string redirectHtmlPage = string.Empty;
			if (string.IsNullOrEmpty(redirectUrl)) {
				MandrillUtilities.Log.InfoFormat("System setting with code 'RedirectUnsuscribersTo' is empty.");
				string redirectHtmlPageWithoutSysSettingLcz =
					$"RedirectHtmlPageWithoutSysSetting{unsubscriptionIsSuccessful}";
				string redirectHtmlPageWithSysSetting = GetLczStringValue(redirectHtmlPageWithoutSysSettingLcz);
				redirectHtmlPage = redirectHtmlPageWithSysSetting.Replace("[#email#]", email);
			} else {
				redirectUrl = $"{redirectUrl}?success={unsubscriptionIsSuccessful}&email={email}";
				string redirectHtmlPageWithoutSysSetting = GetLczStringValue("RedirectHtmlPageWithSysSetting");
				redirectHtmlPage = string.Format(redirectHtmlPageWithoutSysSetting, redirectUrl);

				currentContext.OutgoingResponse.Location = redirectUrl;
				currentContext.OutgoingResponse.StatusCode = System.Net.HttpStatusCode.Redirect;
			}
			System.ServiceModel.Channels.Message redirect =
				currentContext.CreateTextResponse(redirectHtmlPage, "text/html; charset = utf-8", Encoding.UTF8);
			return redirect;
		}
#endif

		private void ActualizeBulkEmailAudienceFromCampaign(Guid campaignId, Guid bulkEmailId) {
			try {
				var campaignStepsHandler = new CampaignStepsHandler(UserConnection);
				campaignStepsHandler.ActualizeStepsByCampaign(campaignId);
				Guid stepId = GetCampaignStepIdByRecordId(campaignId, bulkEmailId, UserConnection);
				AddContactsToBulkEmailFromCampaign(campaignId, bulkEmailId, stepId);
				SetCampaignTargetsCurrentStep(campaignId, stepId, UserConnection);
			} catch (System.Data.SqlClient.SqlException e) {
				MandrillUtilities.Log.ErrorFormat(
					"[MandrillService.ActualizeBulkEmailAudienceFromCampaign]: "
					+ "Actualize BulkEmail: {0} audience from campaign: {1} fails.", e, bulkEmailId, campaignId);
				throw e;
			}
		}

		private int GetBulkEmailStartDate(int bulkEmailRId) {
			var select = new Select(UserConnection)
				.Column("StartDate")
				.From("BulkEmail")
				.Where("RId").IsEqual(Column.Parameter(bulkEmailRId)) as Select;
			var startDate = select.ExecuteScalar<DateTime>();
			return Utilities.ConvertDateTimeToTimestamp(startDate);
		}

		private Select GetSelectContactsCampaignForBulkEmail(Guid campaignId, Guid bulkEmailId, Guid stepId) {
			int bulkEmailRId = GetBulkEmailRId(bulkEmailId);
			int unixTimestamp = GetBulkEmailStartDate(bulkEmailRId);
			var unsubscribeSubSelect = new Select(UserConnection)
				.Column(Column.Const(1))
				.From("BulkEmailSubscription")
				.Where("ContactId").IsEqual("main", "ContactId")
				.And("BulkEmailSubsStatusId").IsEqual(Column.Parameter(MarketingConsts.BulkEmailContactUnsubscribed))
				.And("BulkEmailTypeId").In(
					new Select(UserConnection)
					.Column("TypeId")
					.From("BulkEmail")
					.Where("Id").IsEqual(Column.Parameter(bulkEmailId))) as Select;
			unsubscribeSubSelect.SpecifyNoLockHints(true);
			var existedRecipientsQuery = new Select(UserConnection)
				.Column(Column.Const(1))
				.From("MandrillRecipient").As("MR")
				.Where("MR", "BulkEmailRId").IsEqual("main", "BulkEmailRId")
				.And("MR", "EmailAddress").IsEqual("main", "EmailAddress") as Select;
			existedRecipientsQuery.SpecifyNoLockHints(true);
			var mainQuery = new Select(UserConnection)
				.Column("main", "BulkEmailRId")
				.Column("main", "ContactRId")
				.Column("main", "EmailAddress")
				.Column(Column.Const(unixTimestamp)).As("Timestamp")
				.From(new Select(UserConnection)
					.Column(Column.Const(bulkEmailRId)).As("BulkEmailRId")
					.Column("C", "Id").As("ContactId")
					.Column("C", "RId").As("ContactRId")
					.Column("C", "Email").As("EmailAddress")
					.Column(Column.Const(unixTimestamp)).As("Timestamp")
					.From("CampaignTarget").As("CT")
					.InnerJoin("Contact").As("C").On("CT", "ContactId").IsEqual("C", "Id")
					.Where("CT", "CampaignId").IsEqual(Column.Parameter(campaignId))
					.And("CT", "NextStepId").IsEqual(Column.Parameter(stepId))
					.And("C", "DoNotUseMail").IsEqual(Column.Const(false))
					.And("C", "IsNonActualEmail").IsEqual(Column.Const(false))
					.And("C", "Email").Not().IsNull()
					.And("C", "Email").IsNotEqual(Column.Const(string.Empty)) as Select).As("main")
				.Where().Not().Exists(existedRecipientsQuery)
				.And().Not().Exists(unsubscribeSubSelect) as Select;
			mainQuery.SpecifyNoLockHints(true);
			return mainQuery;
		}

		private InsertSelect GetInsertSelectContactsBulkEmailFromCampaign(Select select) {
			var insertSelect = new InsertSelect(UserConnection)
				.Into("MandrillRecipient")
				.Set("BulkEmailRId", "ContactRId", "EmailAddress", "Timestamp")
				.FromSelect(select);
			return insertSelect;
		}

		private void AddContactsToBulkEmailFromCampaign(Guid campaignId, Guid bulkEmailId, Guid stepId) {
			Select select = GetSelectContactsCampaignForBulkEmail(campaignId, bulkEmailId, stepId);
			ExecuteInsertSelect(select, GetInsertSelectContactsBulkEmailFromCampaign, UserConnection);
		}

		private int GetBulkEmailRIdByMandrillId(Guid mandrillId) {
			var select = new Select(UserConnection)
				.Column("BulkEmailRId")
				.From("MandrillSentMessage")
				.Where("MandrillId").IsEqual(Column.Parameter(mandrillId)) as Select;
			return select.ExecuteScalar<int>();
		}

		private string GetRequestMethod() {
#if !NETSTANDARD2_0
			return WebOperationContext.Current.IncomingRequest.Method;
#else
			return HttpContext.Current.Request.HttpMethod;
#endif
		}

		#endregion

		#region Methods: Public

		/// <summary>
		/// Validates message.
		/// </summary>
		/// <param name="messageId">Unique identifier of the message.</param>
		/// <returns>Validation result.</returns>
		public ConfigurationServiceResponse ValidateMessage(Guid messageId) {
			return new ConfigurationServiceResponse();
		}

		/// <summary>
		/// Validates messages.
		/// </summary>
		/// <param name="messageIds">Unique identifiers of the message.</param>
		/// <returns>Validation result.</returns>
		public ConfigurationServiceResponse ValidateMessages(Guid[] messageIds) {
			return new ConfigurationServiceResponse();
		}

		public ConfigurationServiceResponse ValidateDraftStatus(Guid[] messageIds) {
			return new ConfigurationServiceResponse();
		}

		/// <summary>
		/// Sets up current Campaign step by stepId.
		/// </summary>
		/// <typeparam name="campaignId">Uniqueidentifier of Campaign.</typeparam>
		/// <typeparam name="stepId">Uniqueidentifier of objectlinked with Campaign step.</typeparam>
		public static void SetCampaignTargetsCurrentStep(Guid campaignId, Guid stepId, UserConnection userConnection) {
			try {
				var updateCampaignTarget = new Update(userConnection, "CampaignTarget")
					.Set("CurrentStepId", Column.Parameter(stepId))
					.Set("NextStepId", Column.Const(null))
					.Set("ModifiedOn", Column.Parameter(DateTime.UtcNow))
					.Where("CampaignId").IsEqual(Column.Parameter(campaignId))
					.And("NextStepId").IsEqual(Column.Parameter(stepId)) as Update;
				updateCampaignTarget.Execute();
			} catch (System.Data.SqlClient.SqlException e) {
				MandrillUtilities.Log.ErrorFormat(
					"[MandrillService.SetCampaignTargetsCurrentStep]: "
					+ "Set CurrentStepId: {0} to Campaign: {1} fails.", e, stepId, campaignId);
				throw e;
			}
		}

		/// <summary>
		/// Returns Uniqueidentifier of Campaign step.
		/// </summary>
		/// <param name="campaignId">Uniqueidentifier of Campaign.</param>
		/// <param name="recordId">Uniqueidentifier of objectlinked with Campaign step.</param>
		/// <returns>Uniqueidentifier of Campaign step.</returns>
		public static Guid GetCampaignStepIdByRecordId(Guid campaignId, Guid recordId, UserConnection userConnection) {
			var selectCampaignStep = new Select(userConnection)
				.Column("Id")
				.From("CampaignStep")
				.Where("CampaignId").IsEqual(Column.Parameter(campaignId))
				.And("RecordId").IsEqual(Column.Parameter(recordId)) as Select;
			return selectCampaignStep.ExecuteScalar<Guid>();
		}

		/// <summary>
		/// Bulk insert operation.
		/// </summary>
		/// <param name="select">Query to fetch data.</param>
		/// <returns>Amount of added records.</returns>
		public static int ExecuteInsertSelect(Select select, Func<Select, InsertSelect> getInsertSelect,
				UserConnection userConnection) {
			const int packageSize = 10000;

			var execSelect = new Select(userConnection)
				.Top(packageSize)
				.Column(Column.Asterisk("ResultSelect"))
				.From(select).As("ResultSelect");

			var iterateInsertedCount = 0;
			var insertedCount = 0;
			do {
				var insertSelect = getInsertSelect(execSelect);
				using (var dbExecutor = userConnection.EnsureDBConnection()) {
					dbExecutor.StartTransaction(System.Data.IsolationLevel.ReadUncommitted);
					try {
						iterateInsertedCount = insertSelect.Execute(dbExecutor);
					} catch {
						dbExecutor.RollbackTransaction();
						throw;
					}
					insertedCount += iterateInsertedCount;
					dbExecutor.CommitTransaction();
				}
			} while (iterateInsertedCount == packageSize);
			return insertedCount;
		}

		/// <summary>
		/// Returns email address list from Mandrill Blacklist.
		/// </summary>
		/// <param name="email">Optional email address for search.</param>
		/// <returns><see cref="List" />.</returns>
		public List<RejectInfo> ListRejects(string email = "") {
			return ServiceApi.ListRejects(email);
		}

		/// <summary>
		/// Creates Task for update split test emil target in Scheduler.
		/// </summary>
		/// <param name="schemaName">Schema name.</param>
		/// <param name="recordId">Uniqueidentifier of Schema record.</param>
		[OperationContract]
		[WebInvoke(Method = "POST", UriTemplate = "UpdateSplitTestAudience", BodyStyle = WebMessageBodyStyle.Wrapped,
			RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
		public void UpdateSplitTestAudience(Guid recordId) {
			Authenticate();
			var bulkEmailAudienceHelper = ClassFactory.Get<BulkEmailAudienceHelper>();
			bulkEmailAudienceHelper.UpdateSplitTestAudience(UserConnection, recordId);
		}

		/// <summary>
		/// Creates Task for update campaign target in Scheduler.
		/// </summary>
		/// <param name="schemaName">Schema name.</param>
		/// <param name="recordId">Uniqueidentifier of Schema record.</param>
		/// <param name="isSetCampaignFirstStep">Is it need to set up first step.</param>
		[OperationContract]
		[WebInvoke(Method = "POST", UriTemplate = "UpdateTargetAudience", BodyStyle = WebMessageBodyStyle.Wrapped,
			RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
		public void UpdateTargetAudience(string schemaName, Guid recordId, bool isSetCampaignFirstStep = false) {
			Authenticate();
			var bulkEmailAudienceHelper = ClassFactory.Get<BulkEmailAudienceHelper>();
			bulkEmailAudienceHelper.UpdateTargetAudience(UserConnection, schemaName, recordId, isSetCampaignFirstStep);
		}

		/// <summary>
		/// Executes Email update statistcs process.
		/// </summary>
		/// <param name="id">Email uniqueidentifier.</param>
		[OperationContract]
		[WebInvoke(Method = "POST", UriTemplate = "UpdateStatistic", BodyStyle = WebMessageBodyStyle.Wrapped,
			RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
		public void UpdateStatistic(Guid id) {
			Authenticate();
			var bulkEmailAudienceHelper = ClassFactory.Get<BulkEmailAudienceHelper>();
			bulkEmailAudienceHelper.UpdateStatistic(UserConnection, id);
		}

		/// <summary>
		/// Stop Email sending.
		/// </summary>
		/// <param name="id">Email uniqueidentifier.</param>
		/// <returns>Returns Email state.</returns>
		[OperationContract]
		[WebInvoke(Method = "POST", UriTemplate = "BreakMailing", BodyStyle = WebMessageBodyStyle.Wrapped,
			RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
		public MailingResponse BreakMailing(Guid bulkEmailId) {
			var bulkEmail = new BulkEmail(UserConnection);
			var response = new MailingResponse() {
				Success = false,
				StatusId = Guid.Empty
			};
			if (!bulkEmail.FetchFromDB(bulkEmailId)) {
				MandrillUtilities.Log.InfoFormat("Can'not access record with Id: {0}.", bulkEmailId);
				return response;
			}
			if (SetBulkEmailBreakingStatus(bulkEmail.Id) > 0) {
				response.Success = true;
				response.StatusId = MarketingConsts.BulkEmailStatusBreakingId;
				return response;
			}
			response.Success = true;
			response.StatusId = bulkEmail.StatusId;
			return response;
		}

		/// <summary>
		/// Sending Email to Mandrill.
		/// </summary>
		/// <param name="id">Email uniqueidentifier.</param>
		/// <param name="isDelayedStart">Parameter that indicates is the delayed Email was executed by Scheduler.</param>
		/// <returns>Returns Email state.</returns>
		[OperationContract]
		[WebInvoke(Method = "POST", UriTemplate = "SendMessage", BodyStyle = WebMessageBodyStyle.Wrapped,
			RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
		public MailingResponse SendMessage(Guid id, bool isDelayedStart = false,
				string applicationUrl = "") {
			Authenticate();
			if (string.IsNullOrEmpty(applicationUrl)) {
				applicationUrl = Terrasoft.Web.Common.WebUtilities.GetParentApplicationUrl(HttpContext.Current.Request);
			}
			var bulkEmail = new BulkEmail(UserConnection);
			var response = new MailingResponse() {
				Success = false,
				StatusId = MarketingConsts.BulkEmailStatusErrorId
			};
			if (!bulkEmail.FetchFromDB(id)) {
				MandrillUtilities.Log.InfoFormat("Can't access record with Id: {0}.", id);
				return response;
			}
			if (!CanExecuteBulkEmail(bulkEmail.StatusId)) {
				MandrillUtilities.Log.InfoFormat("BulkEmail with Id: {0} is already in process.", id);
				response.StatusId = bulkEmail.StatusId;
				return response;
			}
			if (bulkEmail.SegmentsStatusId == MarketingConsts.SegmentStatusUpdatingId) {
				MandrillUtilities.Log.InfoFormat(
					"BulkEmail with Id: {0} can't get started. Segment status is 'Updating'.", id);
				return response;
			}
			if (bulkEmail.StartDate != DateTime.MinValue && !isDelayedStart) {
				SetBulkEmailStatus(bulkEmail, MarketingConsts.BulkEmailStatusStartPlanedId);
			} else {
				bool isResend = (bulkEmail.StatusId == MarketingConsts.BulkEmailStatusStoppedId ||
						bulkEmail.StatusId == MarketingConsts.BulkEmailStatusErrorId);
				SetBulkEmailStatus(bulkEmail, MarketingConsts.BulkEmailStatusStartsId);
				CultureInfo culture = Thread.CurrentThread.CurrentCulture;
				Action sendAction = () => {
					Thread.CurrentThread.CurrentCulture = culture;
					if (bulkEmail.CampaignId != Guid.Empty) {
						ActualizeBulkEmailAudienceFromCampaign(bulkEmail.CampaignId, bulkEmail.Id);
					}
					if (bulkEmail.CategoryId.Equals(MarketingConsts.TriggeredEmailBulkEmailCategoryId)
						&& BulkEmailAudienceIsEmpty(bulkEmail.Id)) {
						SetBulkEmailStatus(bulkEmail, MarketingConsts.BulkEmailStatusActiveId);
						MandrillUtilities.Log.ErrorFormat(
								"[MandrillService.SendMessage]: BulkEmail with Id: {0} is empty.", bulkEmail.Id);
					} else {
						var messageData = new SendMessageData(UserConnection, bulkEmail, applicationUrl);
						ExecuteSendMessage(messageData, isResend);
					}
				};
				if (bulkEmail.CategoryId == MarketingConsts.MassmailingBulkEmailCategoryId
					&& bulkEmail.LaunchOptionId == MarketingConsts.BulkEmailManaulLaunchOptionId) {
					Task.Factory.StartNew(sendAction);
				} else {
					sendAction();
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
			try {
				var args = new ConstructorArgument[] { 
					new ConstructorArgument("userConnection", UserConnection)
				};
				var sendEmailHandler = ClassFactory.Get<SendEmailHandler>(args);
				sendEmailHandler.Send(messageInfo);
				return new MailingResponse {
					Success = true,
					StatusId = MailingConsts.BulkEmailStatusFinishedId
				};
			} catch (Exception e) {
				MandrillUtilities.Log
					.ErrorFormat("[SendMessage]: Exception occured while sending instant email {e}", e);
				return new MailingResponse {
					Success = false,
					StatusId = MailingConsts.BulkEmailStatusErrorId
				};
			}
		}

		/// <summary>
		/// Sending of test Email to Mandrill.
		/// </summary>
		/// <param name="bulkEmailId">Email uniqueidentifier.</param>
		/// <param name="contactId">Contatc uniqueidentifier.</param>
		/// <param name="emailRecipient">email address of recipient for test email.</param>
		/// <returns>Returns boolean: is test email was sent successfully.</returns>
		[OperationContract]
		[WebInvoke(Method = "POST", UriTemplate = "SendTestMessage", BodyStyle = WebMessageBodyStyle.Wrapped,
			RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
		public bool SendTestMessage(Guid bulkEmailId, Guid contactId, string emailRecipient) {
			Authenticate();
			if (!PingProvider()) {
				MandrillUtilities.Log.InfoFormat("[SendTestMessage]: Can't ping Mandrill.");
				return false;
			}
			var bulkEmail = new BulkEmail(UserConnection);
			if (!bulkEmail.FetchFromDB(bulkEmailId)) {
				MandrillUtilities.Log.InfoFormat("[SendTestMessage]: Can't access record with Id: {0}.",
					bulkEmailId);
				return false;
			}
			var messageImages = new List<image>();
			var macrosHelper = new MarketingMacrosHelper(UserConnection);
			string applicationUrl =
				Terrasoft.Web.Common.WebUtilities.GetParentApplicationUrl(HttpContext.Current.Request);
			string templateName = SaveTemplate(bulkEmail, messageImages, applicationUrl, macrosHelper);
			if (string.IsNullOrEmpty(templateName)) {
				MandrillUtilities.Log.InfoFormat("[SendTestMessage]: Can't save template");
				return false;
			}
			var emailMessage = InitEmailMessage(bulkEmail, messageImages, macrosHelper, false);
			PrepareTestRecipient(contactId, emailRecipient, macrosHelper, emailMessage, applicationUrl, bulkEmailId);
			if (!contactId.Equals(Guid.Empty) && !emailMessage.to.Any()) {
				MandrillUtilities.Log.InfoFormat("[SendTestMessage]: Can't find contact by id {0}", contactId);
				return false;
			}
			var emailResults = new List<Mandrill.EmailResult>();
			try {
				emailResults = ServiceApi.SendMessageAsync(emailMessage, templateName, null).Result;
			} catch (Exception e) {
				MandrillUtilities.Log.InfoFormat("[SendTestMessage]: Error while sending message");
				return false;
			} finally {
				emailMessage = null;
			}
			var result = emailResults[0].Status == EmailResultStatus.Sent;
			if (!result) {
				MandrillUtilities.Log.InfoFormat("[SendTestMessage]: Sent email status not equal 'Sent'");
			}
			return result;
		}

		/// <summary>
		/// Processing Mandrill events.
		/// </summary>
		/// <param name="mandrill_events">Mandrill events.</param>
		[OperationContract]
		[WebInvoke(Method = "*", UriTemplate = "HandleWebHookEvents")]
		public void HandleWebHookEvents(Stream mandrill_events) {
			_isAnonymousAuthentication = true;
			MandrillUtilities.WebHookLog.Info("[MandrillService.HandleWebHookEvents]: Started.");
			string method = GetRequestMethod();
			if (method == "HEAD") {
				return;
			}
			if (method != "POST") {
				throw new ArgumentException(method + " method is not supported.");
			}
			var rawPostData = new StringBuilder();
			var buffer = new char[StreamReaderBufferSize];
			using (var streamReader = new StreamReader(mandrill_events)) {
				var readLength = 0;
				while ((readLength = streamReader.ReadBlock(buffer, 0, StreamReaderBufferSize)) > 0) {
					if (readLength < StreamReaderBufferSize) {
						char[] bufferLast = buffer.Take(readLength).ToArray();
						rawPostData.Append(bufferLast);
						bufferLast = null;
					} else {
						rawPostData.Append(buffer);
					}
				}
			}
			buffer = null;
			NameValueCollection queryParameters = HttpUtility.ParseQueryString(rawPostData.ToString(), Encoding.UTF8);
			rawPostData.Clear();
			string webHookEventJson = queryParameters["mandrill_events"];
			if (string.IsNullOrEmpty(webHookEventJson)) {
				var exception = new ArgumentNullException("mandrill_events");
				MandrillUtilities.WebHookLog.Error("[MandrillService.HandleWebHookEvents]: Empty args.", exception);
				return;
			}
			bool enableWebHooksLogging = (bool)Terrasoft.Core.Configuration.SysSettings
				.GetValue(UserConnection, "EnableWebHooksLogging");
			if (enableWebHooksLogging) {
				MandrillUtilities.WebHookLog
					.InfoFormat("[MandrillService.HandleWebHookEvents]: Data: {0}", webHookEventJson);
			}
			string authKey = GetMandrillAuthKey();
			if (!IsRequestAuthenticate(authKey, HttpContext.Current.Request, queryParameters)) {
				MandrillUtilities.WebHookLog.ErrorFormat(
					"[MandrillService.HandleWebHookEvents]: The AuthKey {0} is wrong.", authKey);
				return;
			}
			queryParameters.Clear();
			try {
				byte[] compressedJson = MandrillUtilities.Compress(webHookEventJson);
				var insert = new Insert(UserConnection)
					.Into("RawMandrillEvent")
					.Set("Id", Column.Parameter(Guid.NewGuid()))
					.Set("JsonData", Column.Parameter(compressedJson))
					.Execute();
			} catch (Exception e) {
				MandrillUtilities.WebHookLog.ErrorFormat("[MandrillService.HandleWebHookEvents].", e);
				throw e;
			}
			MandrillUtilities.WebHookLog
				.Info("[MandrillService.HandleWebHookEvents]: Completed successfully. End process.");
		}

		/// <summary>
		/// Checks provider connection.
		/// </summary>
		[OperationContract]
		[WebInvoke(Method = "POST", UriTemplate = "PingProvider", BodyStyle = WebMessageBodyStyle.Wrapped,
			RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
		public bool PingProvider() {
			try {
				ServiceApi.Ping();
				return true;
			} catch {
				return false;
			}
		}

		/// <summary>
		/// Validates key.
		/// </summary>
		[OperationContract]
		[WebInvoke(Method = "POST", UriTemplate = "PingMandrill", BodyStyle = WebMessageBodyStyle.Wrapped,
			RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
		public bool PingMandrill(string apiKey) {
			var mandrillApi = new MandrillApi(apiKey);
			try {
				mandrillApi.Ping();
				return true;
			} catch {
				return false;
			}
		}

#if !NETSTANDARD2_0
		/// <summary>
		/// Unsubscribes users from Email.
		/// </summary>
		/// <param name="key">Unsubscribe key.</param>
		[OperationContract]
		[WebInvoke(Method = "*", UriTemplate = "UnsubscribeRecipient")]
		public System.ServiceModel.Channels.Message UnsubscribeRecipient() {
			_isAnonymousAuthentication = true;
			string method = GetRequestMethod();
			if (method != "GET") {
				MandrillUtilities.Log
					.ErrorFormat("[MandrillService.UnsubscribeRecipient]: {0} method is not supported.", method);
				return GetRedirection(false);
			}
			var request = WebOperationContext.Current.IncomingRequest;
			if (request.UriTemplateMatch == null) {
				MandrillUtilities.Log
					.ErrorFormat("[MandrillService.UnsubscribeRecipient]: Invalid request url.");
				return GetRedirection(false);
			}
			int bulkEmailRId;
			/// Init service params(Native Mandrill Unsubscription)
			string mandrillIdParameter = request.UriTemplateMatch.QueryParameters["md_id"];
			string email = request.UriTemplateMatch.QueryParameters["md_email"];
			if (!string.IsNullOrEmpty(mandrillIdParameter) && !string.IsNullOrEmpty(email)) {
				try {
					Guid.TryParse(mandrillIdParameter, out Guid mandrillId);
					bulkEmailRId = GetBulkEmailRIdByMandrillId(mandrillId);
				} catch {
					MandrillUtilities.Log.ErrorFormat(
						"[MandrillService.UnsubscribeRecipient]: Error while unsubscribing recipient with email:{0}", email);
					return GetRedirection(false);
				}
			} else {
				string dirtyKey = GetUnsubscribeKey();
				string emailRidPattern = UtmHelper.PatternUtmEmailIdLabel;
				string urlQuerySplitter = "?";
				string searchKey = string.Concat(urlQuerySplitter, emailRidPattern);
				string key = dirtyKey.Contains(searchKey)
					? dirtyKey.Split(new [] { searchKey }, StringSplitOptions.RemoveEmptyEntries).FirstOrDefault()
					: dirtyKey;

				string bulkEmailRIdString = key.Substring(0, IntLength);
				if (!int.TryParse(bulkEmailRIdString, out bulkEmailRId)) {
					return GetRedirection(false);
				};
				Guid bulkEmailId = GetBulkEmailIdByRId(bulkEmailRId);
				string emailHash = key.Substring(IntLength);
				try {
					email = MandrillUtilities.StringCrypto.DecryptString(emailHash, bulkEmailId.ToString("N"));
				} catch (Exception e) {
					MandrillUtilities.Log.ErrorFormat(
						"[MandrillService.UnsubscribeRecipient]: Can't decrypt email {0} for BulkEmail {1}.", e, emailHash,
						bulkEmailRId);
					return GetRedirection(false);
				}
			}
			if (!UnsubscribeUser(email, bulkEmailRId)) {
				return GetRedirection(false);
			}
			return GetRedirection(true, email);
		}
#endif

		/// <summary>
		/// Processing emails with empty MandrillId.
		/// </summary>
		public void ActualizeEmptyMandrillIds() {
			try {
				var emptyMandrillIdsList = GetEmailsListWithoutMandrillId();
				var searchResult = GetMandrillSearchResult(new SearchRequestInMandrill(
					Guid.NewGuid(),
					emptyMandrillIdsList.BulkEmailId,
					emptyMandrillIdsList.EmailsList));
				var analyzeResult = AnalyzeSearchResult(searchResult);
				SaveInitialStatuses(analyzeResult);
			} catch (Exception e) {
				MandrillUtilities.Log.ErrorFormat(
					"[MandrillService.ActualizeEmptyMandrillIds]: Error while update empty mandrill id", e);
			}
		}

		/// <summary>
		/// Checks whether email audience is empty.
		/// </summary>
		/// <param name="bulkEmailId">Unique identifier of email.</param>
		/// <returns>Returns true if email doesn't contain audience.</returns>
		public bool BulkEmailAudienceIsEmpty(Guid bulkEmailId) {
			var bulkEmail = new BulkEmail(UserConnection);
			bulkEmail.FetchFromDB(bulkEmailId);
			int bulkEmailRId = GetBulkEmailRId(bulkEmailId);
			DateTime startDateUtc = TimeZoneInfo.ConvertTimeToUtc(bulkEmail.StartDate,
				UserConnection.CurrentUser.TimeZone);
			PrepareRecipientsInfo prepareRecipientsInfo = new PrepareRecipientsInfo() {
				BulkEmailRId = bulkEmailRId,
				BulkEmailId = bulkEmail.Id,
				BulkEmailStartDate = startDateUtc,
				BulkEmailCategoryId = bulkEmail.CategoryId,
				BatchId = 1,
				BatchLength = 1
			};
			Select recipientsBatchSelect = GetRecipientsBatchSelect(prepareRecipientsInfo, macrosHelper: null,
				usePageable: false);
			var execSelect = new Select(UserConnection)
				.Column(Func.Count("ContactRId"))
				.From(recipientsBatchSelect).As("Select");
			int bulkEmailAudienceCount = execSelect.ExecuteScalar<int>();
			return (bulkEmailAudienceCount == 0);
		}

		#endregion
	}

	#endregion

}

