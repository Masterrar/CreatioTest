namespace Terrasoft.Configuration
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text.RegularExpressions;
	using Terrasoft.Common;
	using Terrasoft.Configuration.CES;
	using Terrasoft.Configuration.CESModels;
	using Terrasoft.Configuration.DynamicContent;
	using Terrasoft.Configuration.DynamicContent.Models;
	using Terrasoft.Configuration.Mailing;
	using Terrasoft.Configuration.Marketing.Utilities;
	using Terrasoft.Configuration.Utils;
	using Terrasoft.Core;
	using Terrasoft.Core.Factories;

	#region Class: BulkEmailValidator

	/// <summary>
	/// Provides methods to validate bulkemail before sending.
	/// </summary>
	public class BulkEmailValidator
	{

		#region Constants: Private

		private const string MacroRegexPattern = "^(\\[\\#.+\\#\\])$";

		private const int MailingMaxTemplateSize = 5242880;

		#endregion

		#region Fields: Private

		private readonly ICESApi _serviceApi;

		private BulkEmailEventLogger _bulkEmailEventLogger;

		private BulkEmailMacroParser _bulkEmailMacroParser;

		private CESMailingTemplateFactory _templateFactory;

		#endregion

		#region Constructors: Public

		public BulkEmailValidator(UserConnection userConnection, ICESApi cesApi) {
			_serviceApi = cesApi;
			UserConnection = userConnection;
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Gets the template factory.
		/// </summary>
		/// <value>
		/// The template factory.
		/// </value>
		public CESMailingTemplateFactory TemplateFactory =>
			_templateFactory ?? (_templateFactory = new CESMailingTemplateFactory());

		/// <summary>
		/// Gets the bulk email event logger.
		/// </summary>
		/// <value>
		/// The bulk email event logger.
		/// </value>
		public BulkEmailEventLogger BulkEmailEventLogger =>
			_bulkEmailEventLogger ?? (_bulkEmailEventLogger = new BulkEmailEventLogger(UserConnection));

		/// <summary>
		/// Gets or sets the bulk email macro parser.
		/// </summary>
		/// <value>
		/// The bulk email macro parser.
		/// </value>
		public BulkEmailMacroParser BulkEmailMacroParser {
			get => _bulkEmailMacroParser ?? (_bulkEmailMacroParser = GetMacroParser());
			set => _bulkEmailMacroParser = value;
		}

		/// <summary>
		/// Gets or sets the user connection.
		/// </summary>
		/// <value>
		/// The user connection.
		/// </value>
		public UserConnection UserConnection { get; set; }

		#endregion

		#region Methods: Private

		private void AddBulkEmailEventLogMessage(Guid bulkEmailId, string lczEvent, string lczDescription,
			params object[] parameters) {
			var messageTemplate = GetLczStringValue(lczDescription);
			var message = parameters == null || parameters.Length < 1 ? messageTemplate
				: string.Format(messageTemplate, parameters);
			BulkEmailEventLogger.LogError(bulkEmailId, DateTime.UtcNow, GetLczStringValue(lczEvent), message,
				UserConnection.CurrentUser.ContactId);
		}

		private double ConvertBytesToMegabytes(int sizeInBytes) {
			return Math.Round(sizeInBytes / 1024f / 1024f, 2);
		}

		private BulkEmail GetBulkEmailFromDB(Guid bulkEmailId) {
			var bulkEmail = new BulkEmail(UserConnection);
			var fetchBulkEmailResult = bulkEmail.FetchFromDB("Id", bulkEmailId,
				new[] {
					"Id",
					"Owner",
					"Name",
					"TemplateBody",
					"UseUtm",
					"StartDate",
					"Category",
					"Domains",
					"UtmSource",
					"UtmMedium",
					"UtmCampaign",
					"UtmTerm",
					"UtmContent",
					"TemplateSubject",
					"SenderName",
					"SenderEmail"
				});
			if (fetchBulkEmailResult) {
				return bulkEmail;
			}
			MailingUtilities.Log.WarnFormat(
				"[CESMaillingProvider.GetBulkEmailFromDB]: FetchFromDB BulkEmail: {0} fails.", bulkEmailId);
			throw new Exception(
				$"[CESMaillingProvider.GetBulkEmailFromDB]: FetchFromDB BulkEmail: {bulkEmailId} fails.");
		}

		private DCTemplateModel GetDcTemplateModel(Guid bulkEmailId,
			DCRepositoryReadOptions<DCTemplateModel, DCReplicaModel> templateReadOptions) {
			var templateRepository = new DCTemplateRepository<DCTemplateModel>(UserConnection);
			var template = templateRepository.ReadByRecordId(bulkEmailId, templateReadOptions);
			return template;
		}

		private string GetEmailValidationExceptionMessage(IEnumerable<string> itemList, string lczPattern) {
			var emails = string.Join(", ", itemList);
			var message = itemList.Count() == 1 ? GetLczStringValue(string.Format(lczPattern, "Singular"))
				: GetLczStringValue(string.Format(lczPattern, "Plural"));
			return string.Format(message, emails);
		}

		private string GetLczStringValue(string lczName) {
			var localizableStringName = $"LocalizableStrings.{lczName}.Value";
			var localizableString = new LocalizableString(UserConnection.Workspace.ResourceStorage,
				"CESMaillingProvider", localizableStringName);
			var value = localizableString.Value ??
				localizableString.GetCultureValue(GeneralResourceStorage.DefCulture, false);
			return value;
		}

		private BulkEmailMacroParser GetMacroParser() {
			var macrosHelper = ClassFactory.Get<MacrosHelperV2>();
			macrosHelper.UserConnection = UserConnection;
			var bulkEmailMacroParser = ClassFactory.Get<BulkEmailMacroParser>(
				new ConstructorArgument("macrosHelper", macrosHelper));
			return bulkEmailMacroParser;
		}

		private Dictionary<string, int> GetOversizedTemplates(BulkEmail bulkEmail) {
			var templateCollection = new List<IMailingTemplate>();
			var invalidTemplateNames = new Dictionary<string, int>();
			var templateReplicas = TemplateFactory.CreateDCTemplates(UserConnection, bulkEmail, BulkEmailMacroParser);
			templateCollection.AddRange(templateReplicas);
			foreach (var mailingTemplate in templateCollection) {
				if (ValidateTemplateSize(mailingTemplate, out var templateSize)) {
					continue;
				}
				var templateName = string.Concat("\"", bulkEmail.Name, "\"");
				invalidTemplateNames.Add(templateName, templateSize);
				return invalidTemplateNames;
			}
			return invalidTemplateNames;
		}

		private string GetStatusValidationExceptionMessage(string lczPattern, IEnumerable<string> bulkEmails) {
			var emails = string.Join(", ", bulkEmails.Select(x => $"\"{x}\""));
			var lczName = bulkEmails.Count() == 1 ? string.Format(lczPattern, "Singular")
				: string.Format(lczPattern, "Plural");
			var message = GetLczStringValue(lczName);
			return string.Format(message, emails);
		}

		private string GetTemplatelValidationExceptionMessage(string lczPattern, Dictionary<string, int> bulkEmails) {
			var emails = string.Join(", ", bulkEmails.Keys);
			string message, result;
			var maxSizeInMegabytes = ConvertBytesToMegabytes(MailingMaxTemplateSize);
			if (bulkEmails.Count == 1) {
				var templateSizeInMegabytes = ConvertBytesToMegabytes(bulkEmails.Values.FirstOrDefault());
				message = GetLczStringValue(string.Format(lczPattern, "Singular"));
				result = string.Format(message, templateSizeInMegabytes, maxSizeInMegabytes);
			} else {
				message = GetLczStringValue(string.Format(lczPattern, "Plural"));
				result = string.Format(message, emails, maxSizeInMegabytes);
			}
			return result;
		}

		private int GetTemplateSize(IMailingTemplate template) {
			var images = template.InlineImages.ToCESImage().ToList();
			var templateSize = CESUtilities.GetTemplateSize(template.Content, images);
			return templateSize;
		}

		private string ValidateDefaultSenderByMacro() {
			var defaultEspEmail = Core.Configuration.SysSettings.GetValue(UserConnection, "DefaultESPEmail") as string;
			if (string.IsNullOrEmpty(defaultEspEmail)) {
				var message = GetLczStringValue("SenderEmailValidationDefaultESPEmailEmpty");
				return message;
			}
			var result = _serviceApi.ValidateSender(new[] { defaultEspEmail });
			if (result.ValidatedEmailsList.Any()) {
				var messageTemplate = GetLczStringValue("SenderEmailValidationDefaultESPEmailNotApproved");
				var message = string.Format(messageTemplate, defaultEspEmail);
				return message;
			}
			if (result.WrongEmailsList.Any()) {
				var messageTemplate = GetLczStringValue("SenderEmailValidationDefaultESPEmailWrong");
				var message = string.Format(messageTemplate, defaultEspEmail);
				return message;
			}
			return string.Empty;
		}

		private string ValidateSender(IEnumerable<Guid> bulkEmailIds) {
			var exceptionMessage = string.Empty;
			var bulkEmailQueryHelper = new BulkEmailQueryHelper();
			var senderEmails = bulkEmailQueryHelper.GetBulkEmailsSenderEmail(bulkEmailIds, UserConnection);
			if (senderEmails.Any(x => Regex.IsMatch(x, MacroRegexPattern))) {
				var message = ValidateDefaultSenderByMacro();
				if (!string.IsNullOrEmpty(message)) {
					exceptionMessage += message;
					exceptionMessage += '\n';
				}
			}
			var valuableSenderEmails = senderEmails.Where(x => !Regex.IsMatch(x, MacroRegexPattern));
			if (!valuableSenderEmails.Any()) {
				return exceptionMessage;
			}
			var result = _serviceApi.ValidateSender(valuableSenderEmails);
			if (result.ValidatedEmailsList.Any()) {
				exceptionMessage += GetEmailValidationExceptionMessage(result.ValidatedEmailsList,
					"SenderEmailValidation{0}Warning");
				exceptionMessage += '\n';
			}
			return exceptionMessage;
		}

		private string ValidateTemplateSize(IEnumerable<Guid> messageIds) {
			var result = string.Empty;
			var invalidTemplates = new Dictionary<string, int>();
			foreach (var messageId in messageIds) {
				var bulkEmail = GetBulkEmailFromDB(messageId);
				var oversizedTemplates = GetOversizedTemplates(bulkEmail);
				invalidTemplates.AddRange(oversizedTemplates);
			}
			if (invalidTemplates.Any()) {
				result = GetTemplatelValidationExceptionMessage("TemplateSizeValidation{0}Warning", invalidTemplates);
			}
			return result;
		}

		#endregion

		#region Methods: Public

		/// <summary>
		/// Validates the bulk email to not be in draft status.
		/// </summary>
		/// <param name="bulkEmailIds">The bulk email ids.</param>
		/// /// <returns>Instance of <see cref="ConfigurationServiceResponse"/></returns>
		public ConfigurationServiceResponse ValidateDraftStatus(Guid[] bulkEmailIds) {
			var response = new ConfigurationServiceResponse();
			if (!bulkEmailIds.Any()) {
				return response;
			}
			var draftEmails = new List<string>();
			foreach (var messageId in bulkEmailIds) {
				var status = BulkEmailQueryHelper.GetBulkEmailStatus(messageId, UserConnection);
				if (status == MarketingConsts.BulkEmailStatusDraftId) {
					var bulkEmailName = BulkEmailQueryHelper.GetBulkEmailName(messageId, UserConnection);
					draftEmails.Add(bulkEmailName);
				}
			}
			if (!draftEmails.Any()) {
				return response;
			}
			var message = GetStatusValidationExceptionMessage("TemplateStatusValidation{0}Error", draftEmails);
			response.Exception = new Exception(message);
			return response;
		}

		/// <summary>
		/// Validates the bulk emails by identiers before sending.
		/// </summary>
		/// <param name="messageIds">The message ids.</param>
		/// <returns>Instance of <see cref="ConfigurationServiceResponse"/>.</returns>
		public ConfigurationServiceResponse ValidateMessages(Guid[] messageIds) {
			var response = new ConfigurationServiceResponse();
			if (!messageIds.Any()) {
				return response;
			}
			var exceptionMessage = string.Empty;
			try {
				exceptionMessage = ValidateSender(messageIds);
				exceptionMessage += ValidateTemplateSize(messageIds);
			} catch (Exception e) {
				MailingUtilities.Log.ErrorFormat("[ValidateMessages]: Error while validating message", e);
				foreach (var messageId in messageIds) {
					BulkEmailEventLogger.LogError(messageId, DateTime.UtcNow, GetLczStringValue("ValidateMessageEvent"),
						e, GetLczStringValue("ValidateEmailErrorMsg"), UserConnection.CurrentUser.ContactId);
				}
				exceptionMessage += GetLczStringValue("DefaultEmailValidationException");
			}
			if (!string.IsNullOrEmpty(exceptionMessage)) {
				response.Exception = new Exception(exceptionMessage);
			}
			return response;
		}

		/// <summary>
		/// Validates the size of the template.
		/// </summary>
		/// <param name="template">The template.</param>
		/// <param name="templateSize">Result size of the template.</param>
		/// <returns></returns>
		public bool ValidateTemplateSize(IMailingTemplate template, out int templateSize) {
			templateSize = GetTemplateSize(template);
			return templateSize <= MailingMaxTemplateSize;
		}

		/// <summary>
		/// Validates the test message.
		/// </summary>
		/// <param name="bulkEmailId">The bulk email identifier.</param>
		/// <param name="contactId">The contact identifier.</param>
		/// <param name="template">The template.</param>
		/// <param name="emailMessage">The email message.</param>
		/// <returns></returns>
		public bool ValidateTestMessage(Guid bulkEmailId, Guid contactId, IMailingTemplate template,
			EmailMessage emailMessage) {
			var validationResult = true;
			if (contactId.IsNotEmpty() && !emailMessage.to.Any()) {
				MailingUtilities.Log.InfoFormat("[SendTestMessage]: Can't find contact by id {0}", contactId);
				AddBulkEmailEventLogMessage(bulkEmailId, "TestEmailSending", "TestEmailSendingCommonError");
				validationResult = false;
			}
			var fromEmailMacrosText = MailingConsts.FromEmailMacroKey;
			var fromNameMacrosText = MailingConsts.FromNameMacroKey;
			if (template is CESMailingTemplate cesTemplate) {
				if (cesTemplate.TrackedAliases.TryGetValue(MailingConsts.FromEmailMacroKey, out var fromEmailMacroName)) {
					fromEmailMacrosText = cesTemplate.MacrosCollection.First(x => x.Alias == fromEmailMacroName)
						.MacrosText;
				}
				if (cesTemplate.TrackedAliases.TryGetValue(MailingConsts.FromNameMacroKey, out var fromNameMacrosName)) {
					fromNameMacrosText = cesTemplate.MacrosCollection.First(x => x.Alias == fromNameMacrosName)
						.MacrosText;
				}
			}
			if (string.IsNullOrEmpty(emailMessage.from_email)) {
				MailingUtilities.Log.InfoFormat("[SendTestMessage]: FromEmail value can't be empty");
				validationResult = false;
				AddBulkEmailEventLogMessage(bulkEmailId, "TestEmailSending", "TestEmailSendingSenderEmailEmpty",
					fromEmailMacrosText);
			} else if (!MailingUtilities.ValidateEmail(emailMessage.from_email)) {
				MailingUtilities.Log.InfoFormat("[SendTestMessage]: FromEmail value is not an email: ",
					emailMessage.from_email);
				validationResult = false;
				AddBulkEmailEventLogMessage(bulkEmailId, "TestEmailSending", "TestEmailSendingSenderEmailWrong",
					fromEmailMacrosText, emailMessage.from_email);
			}
			if (!string.IsNullOrEmpty(emailMessage.from_name)) {
				return validationResult;
			}
			MailingUtilities.Log.InfoFormat("[SendTestMessage]: FromEmail value can't be empty");
			AddBulkEmailEventLogMessage(bulkEmailId, "TestEmailSending", "TestEmailSendingSenderNameEmpty",
				fromNameMacrosText);
			return false;
		}

		#endregion

	}

	#endregion

}

