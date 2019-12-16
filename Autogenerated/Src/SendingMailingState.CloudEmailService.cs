namespace Terrasoft.Configuration
{
	using System;
	using System.Collections.Generic;
	using System.Data.SqlClient;
	using System.Linq;
	using System.Threading;
	using Terrasoft.Common;
	using Terrasoft.Configuration.CES;
	using Terrasoft.Configuration.CESModels;
	using Terrasoft.Configuration.DynamicContent;
	using Terrasoft.Configuration.DynamicContent.Models;
	using Terrasoft.Configuration.Mailing;
	using Terrasoft.Configuration.Marketing.Utilities;
	using Terrasoft.Configuration.Utils;
	using Terrasoft.Core;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Factories;

	#region Class: SendingMailingState

	public class SendingMailingState : MailingState
	{

		#region Constants: Private

		private const int MailingServicePingAttemptsCount = 3;

		private const int MailingServicePingTimeout = 10000;

		private const int MassMailingRecipientsLimit = 20000;

		private const string MassMailingTag = "mass_mailing";

		private const string SelectForInsertMassMailing = "SELECT '{0}','{1}','{2}','{3}','{4}'";

		private const string SelectForInsertMassMailingOracle = "SELECT '{{{0}}}','{1}','{2}','{3}','{4}' FROM dual";

		private const string TriggeredEmailTag = "triggered_email";

		#endregion

		#region Fields: Private

		private IMailingAudienceDataSource _audienceDataSource;

		#endregion

		#region Properties: Protected

		protected string SelectForInsertTemplate {
			get {
				switch (UserConnection.DBEngine.DBEngineType) {
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

		protected UserConnection UserConnection { get; set; }

		#endregion

		#region Properties: Public

		public DCTemplateRepository<DCTemplateModel> TemplateRepository { get; set; }

		public ICESApi ServiceApi { get; set; }

		public CESMailingTemplateFactory TemplateFactory { get; set; }

		public BulkEmailValidator Validator { get; set; }

		public BulkEmailMacroParser BulkEmailMacroParser { get; set; }

		public IMailingAudienceDataSourceFactory AudienceDataSourceFactory { get; set; }

		public BulkEmailEventLogger BulkEmailEventLogger { get; set; }

		public BulkEmailRecipientValidator RecipientsValidator { get; set; }

		#endregion

		#region Methods: Private

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

		private rcpt_merge_var
			CreateRecipientMergeVar(string recipientEmailAddress, Dictionary<string, string> macros) {
			return new rcpt_merge_var {
				rcpt = recipientEmailAddress,
				vars = macros.Select(x => new merge_var {
					name = x.Key,
					content = x.Value
				}).ToList()
			};
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

		private SendMessageData CreateSendMessageData(BulkEmail bulkEmail) {
			var startDateUtc = TimeZoneInfo.ConvertTimeToUtc(bulkEmail.StartDate, UserConnection.CurrentUser.TimeZone);
			var messageData = new SendMessageData {
				UserConnection = UserConnection,
				BulkEmail = bulkEmail,
				BulkEmailStartDate = startDateUtc,
				SessionId = Context.SessionId
			};
			return messageData;
		}

		private void ExecuteSendMessageTask(SendMessageData sourceData) {
			var bulkEmail = sourceData.BulkEmail;
			var bulkEmailRId = sourceData.BulkEmailRId;
			var sessionId = sourceData.SessionId;
			var culture = Thread.CurrentThread.CurrentCulture;
			var sendMessageTaskData = new SendMessageTaskData();
			var sendResults = new List<TypedCounter<MailingResponseCode>>();
			_audienceDataSource.PageNumber = 0;
			while (sendMessageTaskData.HasDataToProceed) {
				_audienceDataSource.PageNumber++;
				sendMessageTaskData.BatchId = _audienceDataSource.PageNumber;
				MailingUtilities.Log.InfoFormat(
					"[CESMaillingProvider.ExecuteSendMessageTask]: Set BatchId - {0}. " +
					"BulkEmail.Id {1}, Session {2}.", sendMessageTaskData.BatchId, bulkEmail.Id, sessionId);
				var messageData = sourceData.Clone();
				messageData.BulkEmail = sourceData.BulkEmail;
				var email = InitDCEmailMessage(messageData);
				messageData.BatchId = sendMessageTaskData.BatchId;
				messageData.BatchLength = MassMailingRecipientsLimit;
				List<IMessageRecipientInfo> recipients;
				var nextBatchLength = 0;
				try {
					email.InitRecipientVariable();
					var startGetRecipientTime = DateTime.UtcNow;
					recipients = GetRecipients();
					RecipientsValidator.Validate(recipients);
					LogRecipientState(recipients, messageData.BulkEmail.Id, messageData.BatchId, startGetRecipientTime);
					var validRecipients = GetValidRecipient(recipients);
					var recipientEmailAddress = CreateEmailAddresses(validRecipients);
					email.to = recipientEmailAddress;
					nextBatchLength = recipients.Count;
					MailingUtilities.Log.InfoFormat(
						"[CESMaillingProvider.ExecuteSendMessageTask]: Prepared {0} " +
						"recipients. BulkEmail.Id {1}, BatchId {2}, SessionId: {3}", nextBatchLength, bulkEmail.Id,
						sendMessageTaskData.BatchId, sessionId);
				} catch (SqlException e) {
					MailingUtilities.Log.ErrorFormat(
						"[CESMaillingProvider.GetRecipients]: Group processing fails. BulkEmailRId: {0}, " +
						"SessionId: {1}. GroupId: {2}.", e, messageData.BulkEmailRId, messageData.SessionId,
						messageData.BatchId);
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
						"SessionId: {1}. GroupId: {2}.", exception, messageData.BulkEmailRId, messageData.SessionId,
						messageData.BatchId);
					BulkEmailEventLogger.LogError(messageData.BulkEmail.Id, DateTime.UtcNow,
						GetLczStringValue("AudienceAddEvent"), exception, GetLczStringValue("BatchProcessingErrorMsg"),
						UserConnection.CurrentUser.ContactId, messageData.BatchId);
					throw;
				}
				sendMessageTaskData.LastFailedGroupId = 0;
				sendMessageTaskData.CheckMessageCanProceed(nextBatchLength);
				BulkEmailQueryHelper.ResetBulkEmailCounters(sourceData.BulkEmailRId, UserConnection);
				if (sendMessageTaskData.HasDataToProceed) {
					messageData.MailingStartTS = GetMailingStartTs(bulkEmail);
					MailingUtilities.Log.InfoFormat(
						"[CESMaillingProvider.ExecuteSendMessageTask]: Has data to " +
						"proceed and start new thread. BulkEmail.Id {0}, BatchId {1}, SessionId: {2}", bulkEmail.Id,
						sendMessageTaskData.BatchId, sessionId);
					try {
						Thread.CurrentThread.CurrentCulture = culture;
						var resultsCounter = CreateResultsCounter();
						messageData.EmailMessage = email;
						var sentResult = true;
						if (email.to.Any()) {
							sentResult = SendBatch(messageData);
						}
						if (!sentResult) {
							recipients.Where(x => x.InitialResponseCode == (int)BulkEmailResponseCode.Sent).ForEach(y =>
								y.InitialResponseCode = (int)MailingResponseCode.RequestFailed);
						}
						UpdateSendEmailIterationResult(messageData, recipients, resultsCounter);
						sendResults.Add(resultsCounter);
					} catch (Exception e) {
						MailingUtilities.Log.ErrorFormat(
							"[CESMaillingProvider.ExecuteSendMessageTask]: Error occurs when sends batch." +
							" BulkEmailRId: {0}, SessionId: {1}. GroupId: {2}.", e, messageData.BulkEmailRId,
							messageData.SessionId, messageData.BatchId);
					}
				} else {
					MailingUtilities.Log.InfoFormat(
						"[CESMaillingProvider.ExecuteSendMessageTask]: Has no data to " +
						"proceed and BatchSendThreadPool released. BulkEmail.Id {0}, BatchId {1}, SessionId: {2}",
						bulkEmail.Id, sendMessageTaskData.BatchId, sessionId);
				}
			}
			ExecuteSendMessagePostProcessing(sourceData, sendResults, sendMessageTaskData);
		}

		private List<string> GetBulkEmailCategoryTags(BulkEmail bulkEmail) {
			var tags = new List<string>();
			var categoryId = bulkEmail.CategoryId;
			if (categoryId == MailingConsts.MassmailingBulkEmailCategoryId) {
				tags.Add(MassMailingTag);
			} else if (categoryId == MailingConsts.TriggeredEmailBulkEmailCategoryId) {
				tags.Add(TriggeredEmailTag);
			}
			return tags;
		}

		private BulkEmailMacroParser GetMacroParser() {
			var macrosHelper = ClassFactory.Get<MacrosHelperV2>();
			macrosHelper.UserConnection = UserConnection;
			var bulkEmailMacroParser = ClassFactory.Get<BulkEmailMacroParser>(
				new ConstructorArgument("macrosHelper", macrosHelper));
			return bulkEmailMacroParser;
		}

		private int GetMailingStartTs(BulkEmail bulkEmail) {
			var isTriggeredCategory = bulkEmail.CategoryId == MailingConsts.TriggeredEmailBulkEmailCategoryId;
			return isTriggeredCategory ? Utilities.ConvertDateTimeToTimestamp(bulkEmail.StartDate) : 0;
		}

		private List<IMessageRecipientInfo> GetRecipients() {
			return _audienceDataSource.GetAudience();
		}

		private IEnumerable<IMessageRecipientInfo>
			GetValidRecipient(IEnumerable<IMessageRecipientInfo> recipientsBatch) {
			var validRecipients = recipientsBatch.Where(item =>
				item.InitialResponseCode == (int)MailingResponseCode.PostedProvider);
			return validRecipients;
		}

		private void HandleEmailResult(int bulkEmailRId, IEnumerable<IMessageRecipientInfo> recipients) {
			var sentMessageInsertTemplate = "INSERT INTO \"MandrillSentMessage\" (\"MandrillId\", \"BulkEmailRId\", " +
				"\"ContactRId\", \"ResponseCode\", \"MailingStartTS\")";
			InsertInitialResponses(recipients, bulkEmailRId, sentMessageInsertTemplate);
			var messageResponseInsertTemplate = "INSERT INTO \"MandrillMessageResponse\" (\"MandrillId\", " +
				"\"BulkEmailRId\", \"ContactRId\", \"ResponseCode\", \"TimeStamp\")";
			InsertInitialResponses(recipients, bulkEmailRId, messageResponseInsertTemplate);
		}

		private void InitBulkEmailCounters(Guid bulkEmailId, bool isResend) {
			var recipientCount = 0;
			try {
				recipientCount = BulkEmailQueryHelper.GetRecipientsInQueueCount(bulkEmailId, UserConnection);
				BulkEmailQueryHelper.UpdateBulkEmail(bulkEmailId, UserConnection,
					new KeyValuePair<string, object>("InQueueCount", recipientCount),
					new KeyValuePair<string, object>("RecipientCount", recipientCount),
					new KeyValuePair<string, object>("NotDeliveredCount", 0),
					new KeyValuePair<string, object>("TemplateNotFoundCount", 0),
					new KeyValuePair<string, object>("CanceledCount", 0));
			} catch (Exception e) {
				MailingUtilities.Log.ErrorFormat(
					"[CESMaillingProvider.InitBulkEmailCounters]: Error while init BulkEmail counters with Id: {0}," +
					" isResent={1}, recipientsCount={2}", e, bulkEmailId, isResend, recipientCount);
				throw;
			}
		}

		private EmailMessage InitDCEmailMessage(SendMessageData messageData) {
			var bulkEmail = messageData.BulkEmail;
			var message = new EmailMessage {
				track_clicks = true,
				track_opens = true,
				images = messageData.Images,
				inline_css = true
			};
			message.tags = GetBulkEmailCategoryTags(bulkEmail);
			return message;
		}

		private void InitializeAudienceDataSource(Guid bulkEmailId) {
			_audienceDataSource = AudienceDataSourceFactory.CreateInstance(UserConnection, bulkEmailId,
				MassMailingRecipientsLimit);
		}

		private void InsertInitialResponses(IEnumerable<IMessageRecipientInfo> recipients, int bulkEmailRId,
			string insertTemplate) {
			var initialStatusInsertBuilder = new InsertBuilder(UserConnection, insertTemplate, SelectForInsertTemplate);
			var mailingStartTS = Utilities.ConvertDateTimeToTimestamp(DateTime.UtcNow);
			foreach (var recipient in recipients) {
				var recipientId = recipient.Id.ToString().ToUpper();
				initialStatusInsertBuilder.InsertRow(recipientId, bulkEmailRId, recipient.ContactRId,
					recipient.InitialResponseCode, mailingStartTS);
			}
			initialStatusInsertBuilder.ExecuteInsert();
		}

		private void LogRecipientState(List<IMessageRecipientInfo> recipients, Guid bulkEmailId, int batchId,
			DateTime startDate) {
			if (!recipients.Any()) {
				return;
			}
			var validCount = recipients.Count(x => x.InitialResponseCode == (int)MailingResponseCode.PostedProvider);
			var incorrectEmailCount = recipients.Count(x =>
				x.InitialResponseCode == (int)MailingResponseCode.CanceledIncorrectEmail);
			var blankEmailCount =
				recipients.Count(x => x.InitialResponseCode == (int)MailingResponseCode.CanceledBlankEmail);
			var invalidEmailCount =
				recipients.Count(x => x.InitialResponseCode == (int)MailingResponseCode.CanceledInvalidEmail);
			var unsubCount = recipients.Count(x => x.InitialResponseCode == (int)MailingResponseCode.Unsub);
			var duplicatedCount = recipients.Count(x => x.InitialResponseCode == (int)MailingResponseCode.Duplicated);
			var noTemplateCount = recipients.Count(x =>
				x.InitialResponseCode == (int)MailingResponseCode.CanceledTemplateNotFound);
			var senderDomainNotVerifiedCount = recipients.Count(x =>
				x.InitialResponseCode == (int)MailingResponseCode.CanceledSendersDomainNotVerified);
			var senderNameNotValidCount = recipients.Count(x =>
				x.InitialResponseCode == (int)MailingResponseCode.CanceledSendersNameNotValid);
			BulkEmailEventLogger.LogInfo(bulkEmailId, startDate, GetLczStringValue("PrepareBatch"),
				GetLczStringValue("PrepareBatchDescription"), UserConnection.CurrentUser.ContactId, batchId,
				recipients.Count, validCount, incorrectEmailCount, blankEmailCount, invalidEmailCount, unsubCount,
				duplicatedCount, noTemplateCount, senderDomainNotVerifiedCount, senderNameNotValidCount);
		}

		private bool PingProvider(Guid emailId) {
			var startPingTime = DateTime.UtcNow;
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

		private bool SendBatch(SendMessageData messageData) {
			MailingUtilities.Log.InfoFormat("[CESMaillingProvider.SendBatch]: Start: BulkEmailId: {0}. GroupId {1}.",
				messageData.BulkEmail.Id, messageData.BatchId);
			var sendResult = false;
			try {
				var startSendingTime = DateTime.UtcNow;
				Utilities.RetryOnFailure(() => ServiceApi.SendTemplate(messageData.EmailMessage,
					messageData.TemplateName, null, messageData.BulkEmail.Id));
				sendResult = true;
				BulkEmailEventLogger.LogInfo(messageData.BulkEmail.Id, startSendingTime,
					GetLczStringValue("SentBatchStatus"), GetLczStringValue("SentBatchStatusDescription"),
					UserConnection.CurrentUser.ContactId, messageData.BatchId);
			} catch (Exception e) {
				MailingUtilities.Log.ErrorFormat(
					"[CESMaillingProvider.SendBatch]: Error while sending BulkEmail with Id: {0}. " +
					"SessionId: {1}. GroupId {2}.", e, messageData.BulkEmail.Id, messageData.SessionId,
					messageData.BatchId);
				BulkEmailEventLogger.LogError(messageData.BulkEmail.Id, DateTime.UtcNow,
					GetLczStringValue("BatchSendEvent"), e, GetLczStringValue("BatchSendErrorMsg"),
					UserConnection.CurrentUser.ContactId, messageData.BulkEmail);
				sendResult = false;
			}
			return sendResult;
		}

		private void SetInvalidBulkEmailCounters(Guid bulkEmailId, int invalidAddresseeCount) {
			var actualInvalidAdresseeExpression =
				MailingDbUtilities.GetAddCountColumnExpression("InvalidAddresseeCount", invalidAddresseeCount);
			BulkEmailQueryHelper.UpdateBulkEmail(bulkEmailId, UserConnection,
				new KeyValuePair<string, object>("SendDueDate", Column.Const(null)),
				new KeyValuePair<string, object>("InvalidAddresseeCount", actualInvalidAdresseeExpression));
		}

		private void UpdateResultCounter(IEnumerable<IMessageRecipientInfo> recipients,
			TypedCounter<MailingResponseCode> resultsCounter) {
			foreach (var recipient in recipients) {
				resultsCounter.Count((MailingResponseCode)recipient.InitialResponseCode);
			}
		}

		private void UpdateSendEmailIterationResult(SendMessageData messageData,
			IEnumerable<IMessageRecipientInfo> recipients, TypedCounter<MailingResponseCode> resultsCounter) {
			try {
				HandleEmailResult(messageData.BulkEmailRId, recipients);
				UpdateResultCounter(recipients, resultsCounter);
			} catch (Exception e) {
				MailingUtilities.Log.ErrorFormat(
					"[CESMaillingProvider.SendBatch]: Error while handling result of BulkEmail with Id: {0}", e,
					messageData.BulkEmail.Id);
				BulkEmailEventLogger.LogError(messageData.BulkEmail.Id, DateTime.UtcNow,
					GetLczStringValue("BatchSendEvent"), e, GetLczStringValue("HandleResultErrorMsg"),
					UserConnection.CurrentUser.ContactId);
			} finally {
				messageData.EmailMessage = null;
			}
			MailingUtilities.Log.InfoFormat("[CESMaillingProvider.SendBatch]: Success: BulkEmailId: {0}. GroupId {1}.",
				messageData.BulkEmail.Id, messageData.BatchId);
		}

		#endregion

		#region Methods: Protected

		protected void ExecuteSendMessagePostProcessing(SendMessageData sendMessageData,
			List<TypedCounter<MailingResponseCode>> sendResults, SendMessageTaskData sendMessageTaskData) {
			var bulkEmail = sendMessageData.BulkEmail;
			var sessionId = sendMessageData.SessionId;
			var blankEmailCount = sendResults.Sum("BlankEmail");
			var doNotUseEmailCount = sendResults.Sum("DoNotUseEmail");
			var incorrectEmailCount = sendResults.Sum("IncorrectEmail");
			var unreachableEmailCount = sendResults.Sum("UnreachableEmail");
			var communicationLimitCount = sendResults.Sum("CommunicationLimit");
			var duplicateEmailCount = sendResults.Sum("DuplicateEmail");
			var templateNotFoundCount = sendResults.Sum("TemplateNotFound");
			var sendersDomainNotVerifiedCount = sendResults.Sum("SendersDomainNotVerified");
			var sendersNameNotValidCount = sendResults.Sum("SendersNameNotValid");
			var invalidAddresseeCount = sendResults.Sum("InvalidAddressee");
			if (sendMessageTaskData.IsBreaking) {
				SetBulkEmailStatus(bulkEmail.Id, MailingConsts.BulkEmailStatusStoppedId);
				BulkEmailEventLogger.LogInfo(bulkEmail.Id, DateTime.UtcNow, GetLczStringValue("MailingStoppedManually"),
					GetLczStringValue("MailingStoppedManuallyDescription"), UserConnection.CurrentUser.ContactId);
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
				"[CESMaillingProvider.ExecuteSendMessage]: Finished: BulkEmail.Id: {0}, SessionId: {1}", bulkEmail.Id,
				sessionId);
			if (sendMessageTaskData.ProcessedGroupsCounter == 0) {
				SetBulkEmailStatus(bulkEmail.Id, MailingConsts.BulkEmailStatusErrorId);
				CreateReminding(bulkEmail, "CESNoRecipientsMsg");
				MailingUtilities.Log.InfoFormat("BulkEmail with Id: {0} Has no recipients.", bulkEmail.Id);
			}
		}

		#endregion

		#region Methods: Public

		public override MailingResponse ExecuteState() {
			var startSendingTime = DateTime.UtcNow;
			var bulkEmail = (BulkEmail)Context.BulkEmailEntity;
			MailingUtilities.Log.InfoFormat(
				"[CESMaillingProvider.ExecuteSendMessage]: Start: " + "BulkEmail.Id: {0}, SessionId: {1}", bulkEmail.Id,
				Context.SessionId);
			try {
				var validationResult = ActiveContactsHelper.ValidatePermissionEditBulkEmail(UserConnection);
				if (validationResult.Code == ActiveContactsValidationResult.Error) {
					MailingUtilities.Log.ErrorFormat(
						"[CESMaillingProvider.ExecuteSendMessage]: License check failed. SessionId: {0}.",
						Context.SessionId);
					BulkEmailEventLogger.LogError(bulkEmail.Id, DateTime.UtcNow, GetLczStringValue("BatchSendEvent"),
						GetLczStringValue("LicenceErrorMsg"), UserConnection.CurrentUser.ContactId);
					return new MailingResponse {
						Success = false,
						StatusId = MailingConsts.BulkEmailStatusErrorId,
						RemindingLczStringCode = validationResult.Message
					};
				}
				if (!PingProvider(bulkEmail.Id)) {
					MailingUtilities.Log.ErrorFormat(
						"[CESMaillingProvider.ExecuteSendMessage]: CESApi.Ping Fails. SessionId: {0}.",
						Context.SessionId);
					BulkEmailEventLogger.LogError(bulkEmail.Id, DateTime.UtcNow, GetLczStringValue("BatchSendEvent"),
						GetLczStringValue("CloudUnreachableMsg"), UserConnection.CurrentUser.ContactId);
					return new MailingResponse {
						Success = false,
						StatusId = MailingConsts.BulkEmailStatusErrorId,
						RemindingLczStringCode = "CESPingFailsMsg"
					};
				}
				SetBulkEmailStatus(bulkEmail.Id, MailingConsts.BulkEmailStatusLaunchedId);
				InitBulkEmailCounters(bulkEmail.Id, false);
				BulkEmailEventLogger.LogInfo(bulkEmail.Id, startSendingTime, GetLczStringValue("StartSendingEmail"),
					GetLczStringValue("StartSendingEmailDescription"), UserConnection.CurrentUser.ContactId);
				var messageData = CreateSendMessageData(bulkEmail);
				ExecuteSendMessageTask(messageData);
				BulkEmailEventLogger.LogInfo(bulkEmail.Id, startSendingTime, GetLczStringValue("EmailSent"),
					GetLczStringValue("EmailSentDescription"), UserConnection.CurrentUser.ContactId);
			} catch (Exception e) {
				MailingUtilities.Log.ErrorFormat(
					"[CESMaillingProvider.ExecuteSendMessage]: Error when execute send message for BulkEmail with Id: {0},",
					e, bulkEmail.Id);
				BulkEmailEventLogger.LogError(bulkEmail.Id, DateTime.UtcNow, GetLczStringValue("BatchSendEvent"), e,
					GetLczStringValue("ExecuteSendMessageErrorMsg"), UserConnection.CurrentUser.ContactId);
				return new MailingResponse {
					Success = false,
					StatusId = MailingConsts.BulkEmailStatusErrorId,
					RemindingLczStringCode = "ExecuteSendMessageErrorMsg"
				};
			}
			return new MailingResponse {
				Success = true,
				StatusId = MailingConsts.BulkEmailStatusFinishedId,
				RemindingLczStringCode = "CESMassMailingFinishedMsg"
			};
		}

		public override void Initialize() {
			base.Initialize();
			UserConnection = Context.UserConnection;
			TemplateRepository = new DCTemplateRepository<DCTemplateModel>(UserConnection);
			TemplateFactory = new CESMailingTemplateFactory();
			ServiceApi = Context.ServiceApi;
			Validator = new BulkEmailValidator(UserConnection, ServiceApi);
			BulkEmailEventLogger = new BulkEmailEventLogger(UserConnection);
			AudienceDataSourceFactory = new BulkEmailAudienceDataSourceFactory();
			BulkEmailMacroParser = GetMacroParser();
			InitializeAudienceDataSource(Context.BulkEmailEntity.PrimaryColumnValue);
			var validationBuilder = new BulkEmailRecipientValidatorBuilder(ServiceApi);
			RecipientsValidator = new BulkEmailRecipientValidator(validationBuilder);
		}

		#endregion

	}

	#endregion

}

