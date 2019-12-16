namespace Terrasoft.Configuration 
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text.RegularExpressions;
	using Terrasoft.Configuration.Utils;
	using Terrasoft.Core;
	using Terrasoft.Core.DB;
	using Terrasoft.Common;
	using Terrasoft.Core.Factories;
	using CoreSysSettings = Terrasoft.Core.Configuration.SysSettings;
	using HttpUtility = System.Web.HttpUtility;

	#region Class: BulkEmailMacroComposer

	/// <summary>
	/// Provides methods to build macros and its values for mailing recipients.
	/// </summary>
	public class BulkEmailMacroComposer
	{

		#region Constants: Private

		private const string _unsubscribeMacrosName = "UNSUB_URL";
		private const string _useDefaultUnsubscriptionMacrosName = "USE_DEFAULT_UNSUB";
		private const string _globalMacrosSchemaBulkEmail = "BulkEmail";
		private const string _joinColumnName = "Id";
		private const string _personalMacrosSchema = "Contact";

		#endregion

		#region Fields: Private

		private static readonly Regex UrlEncodedMacrosAliasRegex = new Regex("^Url.*$");
		private readonly Guid _globalMacrosContactId;
		private MacrosHelperV2 _macrosHelper;
		private BulkEmailRecipientMacroRepository _recipientMacroRepository;

		#endregion

		#region Fields: Protected

		protected readonly Guid BulkEmailId;
		protected readonly UserConnection UserConnection;

		#endregion

		#region Constructors: Public

		/// <summary>
		/// Creates instance of BulkEmailMacroComposer class, to prepare global and personal macroses.
		/// </summary>
		/// <param name="userConnection">Instance of user connection.</param>
		/// <param name="contactId">Unique identifier of the contact that will be used for 
		/// initializing collection of global macroses.</param>
		/// <param name="bulkEmailId">Unique identifier of the bulk email that will be used for 
		/// initializing collection of global macros.</param>
		public BulkEmailMacroComposer(UserConnection userConnection, Guid contactId, Guid bulkEmailId) {
			UserConnection = userConnection;
			_globalMacrosContactId = contactId;
			BulkEmailId = bulkEmailId;
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Gets or sets the macros helper.
		/// </summary>
		public virtual MacrosHelperV2 MacrosHelper {
			get => _macrosHelper ?? (_macrosHelper = ClassFactory.Get<MacrosHelperV2>());
			set => _macrosHelper = value;
		}

		/// <summary>
		/// Gets or sets the audience data source.
		/// </summary>
		public IMailingAudienceDataSource AudienceDataSource { get; set; }

		/// <summary>
		/// Gets or sets the recipient macro repository.
		/// </summary>
		public BulkEmailRecipientMacroRepository RecipientMacroRepository {
			get => _recipientMacroRepository
				?? (_recipientMacroRepository = new BulkEmailRecipientMacroRepository(UserConnection));
			set => _recipientMacroRepository = value;
		}

		private Dictionary<string, string> _trackedAliases = null;
		/// <summary>
		/// Gets or sets aliases of tracked macros.
		/// </summary>
		public Dictionary<string, string> TrackedAliases {
			get => _trackedAliases
				?? (_trackedAliases = new Dictionary<string, string>());
			set => _trackedAliases = value;
		}

		#endregion

		#region Methods: Private

		private KeyValuePair<string, string> GetUnsubscribeMacrosValue() {
			var unsubscribeLink = (string)CoreSysSettings.GetValue(UserConnection, "RedirectUnsuscribersTo");
			return new KeyValuePair<string, string>(_unsubscribeMacrosName, unsubscribeLink);
		}

		private KeyValuePair<string, string> GetUseDefaultUnsubscriptionMacrosValue() {
			var unsubFromAllMailings =
				CoreSysSettings.GetValue(UserConnection, "UnsubscribeFromAllMailings").ToString();
			return new KeyValuePair<string, string>(_useDefaultUnsubscriptionMacrosName, unsubFromAllMailings);
		}

		private Dictionary<string, string> GetGlobalMacrosValues(IEnumerable<MacrosInfo> macrosCollection,
			Dictionary<Guid, object> arguments) {
			var result = new Dictionary<string, string>();
			var macros = macrosCollection.Where(m => m.IsGlobal && arguments.ContainsKey(m.ParentId));
			if (!macros.Any()) {
				return result;
			}
			result = MacrosHelper.GetMacrosValues(macros, arguments);
			return result;
		}

		private Dictionary<object, Dictionary<string, string>> GetPersonalMacrosValues(Select select,
			IEnumerable<MacrosInfo> macrosCollection) {
			var personalMacros = macrosCollection.Where(m => !m.IsGlobal);
			var arguments = CreateMacrosWorkerParameters(select);
			return MacrosHelper.GetMacrosValuesCollection(personalMacros, arguments);
		}

		private string EncodeUrlLikeMacro(string macrosName, string macrosContent) {
			if (UrlEncodedMacrosAliasRegex.IsMatch(macrosName)) {
				macrosContent = HttpUtility.UrlPathEncode(macrosContent);
			}
			return macrosContent;
		}

		private Dictionary<Guid, object> CreateMacrosWorkerParameters(Select select) {
			var result = new Dictionary<Guid, object>();
			var argValue = new Dictionary<string, object> {
				{"SubSelect", select},
				{"JoinColumnName", _joinColumnName},
				{"SchemaName", _personalMacrosSchema}
			};
			result.Add(Guid.Empty, argValue);
			result.Add(MailingConsts.EmailTemplateMacrosParentContactId, argValue);
			return result;
		}

		private BulkEmailMacroInfo PrepareMacroValue(string macroAlias, string value,
			IEnumerable<MacrosInfo> macrosCollection) {
			var macro = macrosCollection.FirstOrDefault(x => x.Alias == macroAlias);
			return new BulkEmailMacroInfo {
				Alias = macro?.Alias ?? macroAlias,
				Value = EncodeUrlLikeMacro(macroAlias, value),
				MacroText = macro?.MacrosText ?? macroAlias
			};
		}

		private Dictionary<Guid, IEnumerable<BulkEmailMacroInfo>> GetRecipientMacrosSet(Dictionary<Guid, Guid> recipientsIds,
			Dictionary<object, Dictionary<string, string>> personalMacrosValues,
			Dictionary<string, string> globalMacrosValues, IEnumerable<MacrosInfo> macrosCollection) {
			var personalMergeVars =
				new Dictionary<Guid, IEnumerable<BulkEmailMacroInfo>>();
			foreach (var recipient in recipientsIds) {
				IEnumerable<BulkEmailMacroInfo> allMacrosValues = Enumerable.Empty<BulkEmailMacroInfo>();
				if (personalMacrosValues.ContainsKey(recipient.Value)) {
					var recipientMacrosValues = personalMacrosValues[recipient.Value];
					recipientMacrosValues[BulkEmailHyperlinkHelper.ContactIdMacrosName] = recipient.Value.ToString();
					recipientMacrosValues[BulkEmailHyperlinkHelper.BulkEmailRecipientIdName] = recipient.Key.ToString();
					SetTrackedRecipientMacrosValues(recipientMacrosValues);
					SetTrackedRecipientMacrosValues(globalMacrosValues);
					allMacrosValues = recipientMacrosValues.Concat(globalMacrosValues)
						.Select(kvp => PrepareMacroValue(kvp.Key, kvp.Value, macrosCollection));
				}
				personalMergeVars.Add(recipient.Key, allMacrosValues);
			}
			return personalMergeVars;
		}

		private void SetTrackedRecipientMacrosValues(Dictionary<string, string> macroValues) {
			foreach (var trackedItem in TrackedAliases) {
				if (macroValues.TryGetValue(trackedItem.Value, out var macroValue)) {
					macroValues[trackedItem.Key] = macroValue;
				}
			}
		}

		private IEnumerable<KeyValuePair<string, string>> GetUnsubscribeMacrosValues() {
			var unsubDictionary = new Dictionary<string, string>();
			var unsubMacrosValue = GetUnsubscribeMacrosValue();
			var unsubFromAllMailingsMacrosValue = GetUseDefaultUnsubscriptionMacrosValue();
			unsubDictionary.Add(unsubMacrosValue.Key, unsubMacrosValue.Value);
			unsubDictionary.Add(unsubFromAllMailingsMacrosValue.Key, unsubFromAllMailingsMacrosValue.Value);
			return unsubDictionary;
		}

		private IEnumerable<KeyValuePair<string, string>> GetBulkEmailMacrosValues(
			IEnumerable<MacrosInfo> macrosCollection) {
			return GetGlobalMacrosValues(macrosCollection, new Dictionary<Guid, object> {
				{Guid.Empty, new KeyValuePair<string, Guid>(_globalMacrosSchemaBulkEmail, BulkEmailId)}
			});
		}

		private IEnumerable<KeyValuePair<string, string>> GetSenderMacrosValues(IEnumerable<MacrosInfo> macrosCollection) {
			return GetGlobalMacrosValues(macrosCollection, new Dictionary<Guid, object> {
				{MailingConsts.EmailTemplateMacrosParentGlobalId, _globalMacrosContactId}
			});
		}

		public Dictionary<string, string> GetCommonMacrosValues(IEnumerable<MacrosInfo> macrosCollection) {
			var globalMacrosValues = new Dictionary<string, string>();
			var senderMacrosValues = GetSenderMacrosValues(macrosCollection);
			globalMacrosValues.AddRange(senderMacrosValues);
			var bulkEmailMacrosValues = GetBulkEmailMacrosValues(macrosCollection);
			globalMacrosValues.AddRange(bulkEmailMacrosValues);
			var unsubscribeMacrosValues = GetUnsubscribeMacrosValues();
			globalMacrosValues.AddRange(unsubscribeMacrosValues);
			return globalMacrosValues;
		}

		private bool CanPrepareMacros(IEnumerable<MacrosInfo> macrosCollection) {
			if (AudienceDataSource == null) {
				throw new ArgumentException("Property AudienceDataSource should be set");
			}
			var dcDataSource = AudienceDataSource as IDCAudienceDataSource;
			if (dcDataSource == null) {
				throw new ArgumentException(
					"Type of AudienceDataSource property should implements IDCAudienceDataSource");
			}
			return macrosCollection.Any() && !AudienceDataSource.IsEmpty();
		}

		#endregion

		#region Methods: Protected

		protected virtual Dictionary<Guid, IEnumerable<BulkEmailMacroInfo>> GetMacrosValues(
			IEnumerable<MacrosInfo> macrosCollection, Select recipientsIdsSelect,
			Dictionary<Guid, Guid> recipientsIds, Dictionary<string, string> globalMacrosValues) {
			var personalMacrosResult = GetPersonalMacrosValues(recipientsIdsSelect, macrosCollection);
			var recipientMacrosSet =
				GetRecipientMacrosSet(recipientsIds, personalMacrosResult, globalMacrosValues, macrosCollection);
			return recipientMacrosSet;
		}

		#endregion

		#region Methods: Public
		
		public virtual  Dictionary<string, string> GetContactMacrosValues(Guid contactId,
			IEnumerable<MacrosInfo> macrosCollection) {
			var personalMacros = macrosCollection.Where(m => !m.IsGlobal);
			var arguments = new Dictionary<Guid, Object>();
			arguments.Add(Guid.Empty, new KeyValuePair<string, Guid>(_personalMacrosSchema, contactId));
			arguments.Add(MailingConsts.EmailTemplateMacrosParentContactId, contactId);
			return MacrosHelper.GetMacrosValues(personalMacros, arguments);
		}

		/// <summary>
		/// Returns personal macros of the contacts.
		/// </summary>
		/// <param name="replicaId"></param>
		/// <param name="macrosCollection">Collection of macros.</param>
		/// <exception cref="ArgumentException">When AudienceDataSource property is not set.</exception>
		/// <exception cref="ArgumentException">When type of AudienceDataSource property does not implement
		/// IDCAudienceDataSource.</exception>
		/// <returns>The recipients macros.</returns>
		public virtual void PrepareMacros(Guid replicaId, IEnumerable<MacrosInfo> macrosCollection) {
			if (!CanPrepareMacros(macrosCollection)) {
				return;
			}
			var dcDataSource = AudienceDataSource as IDCAudienceDataSource;
			var commonMacrosValues = GetCommonMacrosValues(macrosCollection);
			AudienceDataSource.PageNumber = 0;
			while (true) {
				AudienceDataSource.PageNumber++;
				var recipientsIds = dcDataSource.GetAudienceIdentifiers(replicaId);
				if (!recipientsIds.Any()) {
					break;
				}
				var contactsIdsSelect = dcDataSource.GetContactsIdsSelectQuery(replicaId);
				var personalMergeVars = GetMacrosValues(macrosCollection, contactsIdsSelect, recipientsIds,
					commonMacrosValues);
				RecipientMacroRepository.Save(BulkEmailId, personalMergeVars);
			}
		}

		#endregion
	}

	#endregion
}
