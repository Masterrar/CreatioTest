namespace Terrasoft.Configuration
{
	using System;
	using System.Data;
	using System.Collections.Generic;
	using System.Text.RegularExpressions;
	using Terrasoft.Core;
	using Terrasoft.Core.DB;
	using Mandrill;
	using System.Linq;
	using global::Common.Logging;
	using Terrasoft.Configuration.MandrillService;

	#region Class: SendEmailHandler

	public class SendEmailHandler
	{

		#region Fields: Private

		private UserConnection _userConnection;

		private MandrillApi _mandrillApi;

		private static readonly ILog _log = LogManager.GetLogger("SendEmailHandler");

		private static bool _isMetadataInitialized;

		#endregion

		#region Constants: Private

		/// <summary>
		/// ####### ### ############ ##### ####### ######## Mandrill.
		/// </summary>
		private const string MandrillTemplateNamePattern = "{0}({1})";

		/// <summary>
		/// ############ ###### ############ ####### # ######.
		/// </summary>
		private const int MandrillMaxTemplateSize = 14999999;

		/// <summary>
		/// Custom metadata field for bulk email Mandrill.
		/// </summary>
		private const string BulkEmailMetadataValue = "bulk_email_id";

		#endregion

		#region Properties: Private

		private MandrillApi ServiceApi {
			get {
				return _mandrillApi ?? (_mandrillApi = new MandrillApi(MandrillApiKey));
			}
		}

		private string MandrillApiKey {
			get {
				return (string)Terrasoft.Core.Configuration.SysSettings.GetValue(_userConnection, "mandrillApiKey");
			}
		}

		/// <summary>
		/// ######.
		/// </summary>
		public static ILog Log {
			get {
				return _log;
			}
		}

		#endregion

		#region Constructors

		public SendEmailHandler(UserConnection userConnection) {
			_userConnection = userConnection;
		}

		#endregion

		#region Methods: Private

		/// <summary>
		/// ########## ######## # ######### Email ########.
		/// </summary>
		/// <param name="messageInfo">###### ### ######## ######</param>
		/// <returns>######### ########## ######## # ######### Email ########</returns>
		private int AddContactToBulkEmailAudience(IMessageInfo messageInfo) {
			var recipientInfo = messageInfo.Recipients.FirstOrDefault() as BulkEmailRecipientInfo;
			var insert = new Insert(_userConnection)
				.Into("MandrillRecipient")
				.Set("BulkEmailRId", Column.Parameter(messageInfo.MessageRId))
				.Set("ContactRId", Column.Parameter(recipientInfo.ContactRId))
				.Set("EmailAddress", Column.Parameter(recipientInfo.EmailAddress))
				.Set("IsSent", Column.Const(true))
				.Set("Timestamp", Column.Parameter(messageInfo.MailingStartTS));
			return insert.Execute();
		}

		private int AddContactToMandrillSentMessage(IMessageInfo messageInfo, Mandrill.EmailResult emailResult) {
			if (emailResult == null) {
				return 0;
			}
			EmailResultStatus emailResultStatus = emailResult.Status;
			BulkEmailResponseCode response;
			try {
				response = emailResultStatus.GetBulkEmailResponseCode();
			} catch (InvalidCastException) {
				return 0;
			}
			Guid mandrillId;
			if (!Guid.TryParse(emailResult.Id, out mandrillId)) {
				return 0;
			}
			var recipientInfo = messageInfo.Recipients.FirstOrDefault() as BulkEmailRecipientInfo;
			var insert = new Insert(_userConnection)
				.Into("MandrillSentMessage")
				.Set("MandrillId", Column.Parameter(mandrillId))
				.Set("BulkEmailRId", Column.Parameter(messageInfo.MessageRId))
				.Set("ContactRId", Column.Parameter(recipientInfo.ContactRId))
				.Set("ResponseCode", Column.Parameter((int)response))
				.Set("MailingStartTS", Column.Parameter(messageInfo.MailingStartTS));
			return insert.Execute();
		}

		/// <summary>
		/// ########## ######## ######.
		/// </summary>
		/// <param name="messageInfo">###### ### ######## ######</param>
		/// <returns>######### ######## ######</returns>
		private bool ExecuteSendMessage(IMessageInfo messageInfo) {
			var instatntMessageInfo = messageInfo as InstantMessageInfo;
			var bulkEmail = instatntMessageInfo.BulkEmail;
			InitializeCustomMetadata();
			var emailMessage = InitEmailMessage(messageInfo);
			List<EmailResult> emailResults;
			try {
				emailResults = ServiceApi.SendMessageAsync(emailMessage).Result;
			} catch (Exception e) {
				Log.InfoFormat("[ExecuteSendMessage]: Error while sending message");
				return false;
			} finally {
				emailMessage = null;
			}
			EmailResult emailResult = emailResults.FirstOrDefault();
			AddContactToMandrillSentMessage(messageInfo, emailResult);
			return (emailResult.Status != EmailResultStatus.Invalid);
		}

		private void InitializeCustomMetadata() {
			try {
				if (ServiceApi.ListCustomMetadata().All(x => x.name != BulkEmailMetadataValue)) {
					ServiceApi.AddCustomMetadata(BulkEmailMetadataValue);
				}
				_isMetadataInitialized = true;
			} catch (Exception e) {
				Log.ErrorFormat(
					"[InitializeCustomMetadata]: Error while handling getting custom metadata field", e);
			}
		}

		/// <summary>
		/// Initalizes email data.
		/// </summary>
		/// <param name="bulkEmail">Email instance.</param>
		/// <param name="messageInfo">Data nexessary for email sending.</param>
		private EmailMessage InitEmailMessage(IMessageInfo messageInfo) {
			var instantMessageInfo = messageInfo as InstantMessageInfo;
			BulkEmail bulkEmail = instantMessageInfo.BulkEmail;
			var messageImages = new List<image>();
			var message = new EmailMessage {
				subject = bulkEmail.TemplateSubject,
				from_email = bulkEmail.SenderEmail,
				from_name = bulkEmail.SenderName,
				html = bulkEmail.TemplateBody,
				track_clicks = true,
				track_opens = true,
				images = messageImages,
				inline_css = true,
				important = true
			};
			var macrosHelper = new MarketingMacrosHelper(_userConnection);
			string templateCode = GetTemplate(bulkEmail, messageInfo, messageImages, macrosHelper);
			var bulkEmailId = bulkEmail.GetTypedColumnValue<Guid>("Id");
			PrepareRecipient(messageInfo, macrosHelper, message, bulkEmailId);
			message.html = templateCode;
			if (_isMetadataInitialized) {
				message.AddMetadata(BulkEmailMetadataValue, messageInfo.MessageId.ToString("N"));
			}
			if (macrosHelper.GlobalMergeVars.Any()) {
				message.InitGlobalVariable();
				message.global_merge_vars.AddRange(macrosHelper.GlobalMergeVars);
			}
			return message;
		}

		private void PrepareRecipient(IMessageInfo messageInfo, MarketingMacrosHelper macrosHelper,
				EmailMessage emailMessage, Guid bulkEmailId) {
			var recipientInfo = messageInfo.Recipients.FirstOrDefault() as BulkEmailRecipientInfo;
			var emailAddress = new EmailAddress(recipientInfo.EmailAddress);
			emailMessage.InitRecipientVariable();
			var merge = macrosHelper.GetRecipientMacros(recipientInfo.Id, recipientInfo.EmailAddress, bulkEmailId);
			emailMessage.merge_vars.Add(merge);
			emailMessage.to = new EmailAddress[] { emailAddress };
		}

		private string GetTemplate(BulkEmail bulkEmail, IMessageInfo messageInfo, List<image> messageImages,
				MarketingMacrosHelper macrosHelper) {
			string templateBodyWithMacros = macrosHelper.SetTemplateBody(bulkEmail.TemplateBody,
						bulkEmail.OwnerId, bulkEmail.Id, messageInfo.ApplicationUrl);
			string templateCode = InlineimagesProcessing(templateBodyWithMacros, messageImages, messageInfo.ApplicationUrl);
			if (string.IsNullOrEmpty(templateCode)) {
				return string.Empty;
			}
			templateCode = UtmHelper.GetTemplateCodeWithUtmLabel(bulkEmail.ConvertToUtmData(templateCode),
					messageInfo.MessageRId, macrosHelper.UnsubscribeMacrosAliases);
			int templateSize = MandrillUtilities.GetTemplateSize(templateCode, messageImages);
			return templateSize > MandrillMaxTemplateSize ? string.Empty : templateCode;
		}

		private rcpt_merge_var GetContactPersonalMacroses(Dictionary<int, string> macrosColumnsIndex, string address,
				IDataReader reader, MarketingMacrosHelper macrosHelper) {
			var rcptMergeVar = new rcpt_merge_var();
			if (macrosColumnsIndex.Count <= 0) {
				return rcptMergeVar;
			}
			rcptMergeVar.rcpt = address;
			foreach (var macros in macrosColumnsIndex) {
				rcptMergeVar.vars.Add(new merge_var() {
					name = macros.Value,
					content = (reader[macros.Key] == System.DBNull.Value)
						? string.Empty
						: reader[macros.Key].ToString()
				});
			}
			return rcptMergeVar;
		}

		private static string InlineimagesProcessing(string body, List<image> massageImages, string applicationUrl) {
			string resultString = body;
			Regex regexForImgTag = new Regex(@"<img.*?>", RegexOptions.Multiline | RegexOptions.IgnoreCase);
			Match regexForImgTagMatchResult = regexForImgTag.Match(resultString);
			const string terrasoftSrc = "./terrasoft.axd?";
			const string base64Src = "data:image";
			const string cidPrefix = "IMG";
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
						System.Web.HttpUtility.HtmlDecode(currentImgSrcAddress.TrimStart('.')));
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
					if (massageImages.All(x => x.content != massageImage.content)) {
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

		/// <summary>
		/// Updates Email data (audience count, last sending time).
		/// </summary>
		/// <param name="bulkEmailId">Unique Id of Email</param>
		/// <param name="dateIn">Time of Email Sending</param>
		/// <param name="isError">Flag whether error during sending occured</param>
		private void UpdateBulkEmailData(Guid bulkEmailId, DateTime dateIn, bool isError = false) {
			var count = 1;
			var update = new Update(_userConnection, "BulkEmail")
				.Set("StartDate", Column.Parameter(dateIn))
				.Set("SendStartDate", Column.Parameter(dateIn))
				.Set("SendDueDate", Column.Parameter(dateIn))
				.Set("RecipientCount", QueryColumnExpression.Add(new QueryColumnExpression("RecipientCount"),
					Column.Parameter(count)));
			if (isError) {
				update.Set("CommonErrorCount", QueryColumnExpression.Add(new QueryColumnExpression("CommonErrorCount"),
					Column.Parameter(count)));
			}
			update.Where("Id").IsEqual(Column.Parameter(bulkEmailId));
			(update as Update).Execute();
		}

		#endregion

		#region Methods: Public

		/// <summary>
		/// Sending of instant trigger message.
		/// </summary>
		/// <param name="messageInfo">Object that holds information about message.</param>
		public void Send(IMessageInfo messageInfo) {
			messageInfo.PrepareMessage(_userConnection);
			if (!messageInfo.Validate()) {
				return;
			}
			bool sendMessageResult = false;
			try {
				sendMessageResult = ExecuteSendMessage(messageInfo);
			} catch (Exception e) {
				Log.ErrorFormat("[Send]: {0} Error while sending message instant message with Id {1}", 
					e, messageInfo.MessageId);
			}
			AddContactToBulkEmailAudience(messageInfo);
			UpdateBulkEmailData(messageInfo.MessageId, messageInfo.SendDate, !sendMessageResult);
		}

		#endregion

	}

	#endregion
}

