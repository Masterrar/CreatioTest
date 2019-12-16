namespace Terrasoft.Configuration.Enrichment
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Net;
	using System.Runtime.Serialization;
	using System.ServiceModel;
	using System.ServiceModel.Activation;
	using System.ServiceModel.Web;
	using System.Threading.Tasks;
	using Core.Configuration;
	using Core.DB;
	using Core.Entities;
	using Core.Factories;
	using EnrichmentDto;
	using RestSharp;
	using Terrasoft.Common;
	using Terrasoft.Web.Http.Abstractions;
	using Web.Common;

	#region Class: EnrichmentService

	/// <summary>
	/// Enrichment cloud service proxy.
	/// </summary>
	[ServiceContract]
	[AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Required)]
	public class EnrichmentService : BaseService, System.Web.SessionState.IReadOnlySessionState
	{

		#region Constants: Private

		private const string CompanyNameParameter = "companyName";
		private const string ApiKeyParameter = "key";
		private const string SuggestCompaniesMethodName = "suggest";
		private const string SearchMethodName = "search";
		private const string AccountEnrichedDataSchemaName = "AccountEnrichedData";

		#endregion

		#region Fields: Private

		private readonly List<string> _socialDomainList = new List<string> {
			"facebook.com",
			"twitter.com",
			"linkedin.com",
			"plus.google.com",
			"youtube.com",
			"instagram.com",
			"slideshare.net",
			"pinterest.com"
		};
		private BpmonlineCloudEngine _cloudEngine;
		private IRestClient _restClient;

		#endregion

		#region Properties: Private

		private BpmonlineCloudEngine CloudEngine {
			get {
				if (_cloudEngine == null) {
					_cloudEngine = ClassFactory.Get<BpmonlineCloudEngine>(new ConstructorArgument("userConnection",
						UserConnection));
				}
				return _cloudEngine;
			}
		}

		#endregion

		#region Constructors: Public

		public EnrichmentService() {
			Initialize();
		}

		#endregion

		#region Methods: Private

		private void Initialize() {
			ServicePointManager.UseNagleAlgorithm = false;
			if (!ClassFactory.TryGet("EnrichmentServiceRestClient", out _restClient)) {
				_restClient = new RestClient();
			}
		}

		private bool IsSocialLink(string url) {
			try {
				var uriBuilder = new UriBuilder(url);
				string domain = uriBuilder.Host;
				bool result = _socialDomainList.Any(domain.Contains);
				return result;
			} catch(Exception) {
				return false;
			}
		}

		private bool SetupAccountData(Guid accountId, SearchInfoRequest targetRequest) {
			var schema = UserConnection.EntitySchemaManager.GetInstanceByName("Account");
			var esq = new EntitySchemaQuery(schema);
			var accountColumn = esq.AddColumn("Name");
			var mainContactEmailColumn = esq.AddColumn("PrimaryContact.Email");
			var numberColumn = esq.AddColumn("[AccountCommunication:Account:Id].Number");
			var commTypeColumn =  esq.AddColumn("[AccountCommunication:Account:Id].CommunicationType");
			var accountIdFilter = esq.CreateFilterWithParameters(FilterComparisonType.Equal, "Id", accountId);
			esq.Filters.Add(accountIdFilter);
			var commTypeGroup = new EntitySchemaQueryFilterCollection(esq, LogicalOperationStrict.Or);
			commTypeGroup.Add(esq.CreateIsNullFilter("[AccountCommunication:Account:Id].CommunicationType"));
			var commTypeFilter = esq.CreateFilterWithParameters(FilterComparisonType.Equal,
				"[AccountCommunication:Account:Id].CommunicationType",
				CommunicationTypeConsts.WebId, CommunicationTypeConsts.EmailId);
			commTypeGroup.Add(commTypeFilter);
			esq.Filters.Add(commTypeGroup);
			var list = esq.GetEntityCollection(UserConnection);
			string accountName = string.Empty;
			string primaryContactEmail = string.Empty;
			var urls = new List<string>();
			var emails = new List<string>();
			var webCommunicationTypeId = new Guid(CommunicationTypeConsts.WebId);
			foreach (var item in list) {
				if (string.IsNullOrEmpty(accountName)) {
					accountName = item.GetTypedColumnValue<string>(accountColumn.Name);
				}
				if (string.IsNullOrEmpty(primaryContactEmail)) {
					primaryContactEmail = item.GetTypedColumnValue<string>(mainContactEmailColumn.Name);
				}
				var value = item.GetTypedColumnValue<string>(numberColumn.Name);
				if (string.IsNullOrEmpty(value)) {
					continue;
				}
				if (item.GetTypedColumnValue<Guid>(commTypeColumn.Name + "Id") == webCommunicationTypeId) {
					if (!IsSocialLink(value)) {
						urls.Add(value);
					}
				} else {
					emails.Add(value);
				}
			}
			if (urls.Count == 0 && emails.Count == 0 && primaryContactEmail.IsNotNullOrEmpty()) {
				emails.Add(primaryContactEmail);
			}
			targetRequest.Name = accountName;
			targetRequest.Urls = urls;
			targetRequest.Emails = emails;
			return targetRequest.Urls.Count > 0 || targetRequest.Emails.Count > 0;
		}

		private void ClearPreviousSearchData(Guid accountId) {
			var delete = (Delete)new Delete(UserConnection)
				.From(AccountEnrichedDataSchemaName)
				.Where("AccountId").IsEqual(new QueryParameter(accountId));
			delete.Execute();
		}

		private bool UpdateEnrichedData(Guid accountId, IList<CommunicationInfo> data) {
			data.CheckArgumentNull(nameof(data));
			ClearPreviousSearchData(accountId);
			DateTime date = UserConnection.CurrentUser.GetCurrentDateTime();
			foreach (var info in data) {
				EntitySchema enrichedSchema =
					UserConnection.EntitySchemaManager.GetInstanceByName(AccountEnrichedDataSchemaName);
				Entity entity = enrichedSchema.CreateEntity(UserConnection);
				entity.SetDefColumnValues();
				entity.SetColumnValue("SearchDate", date);
				entity.SetColumnValue("CategoryTag", info.Type);
				entity.SetColumnValue("Value", info.Value);
				entity.SetColumnValue("AccountId", accountId);
				entity.Save();
			}
			return data.Count > 0;
		}

		private SearchInfoRequest PrepareEnrichmentRequest() {
			string serviceUrl;
			string apiKey;
			GetRequiredParameters(out serviceUrl, out apiKey);
			_restClient.BaseUrl = serviceUrl;
			_restClient.AddDefaultHeader("ApiKey", apiKey);
			int maxSocialLinksCount = SysSettings.GetValue(UserConnection, "EnrichmentSocialLinksLimit", 3);
			int maxPhoneNumbersCount = SysSettings.GetValue(UserConnection, "EnrichmentPhoneNumbersLimit", 3);
			int maxEmailsCount = SysSettings.GetValue(UserConnection, "EnrichmentEmailsLimit", 3);
			var requestBody = new SearchInfoRequest {
				ApiKey = apiKey,
				Config = new SearchInfoConfiguration {
					MaxSocialLinksCount = maxSocialLinksCount,
					MaxPhoneNumberCount = maxPhoneNumbersCount,
					MaxEmailsCount = maxEmailsCount
				}
			};
			return requestBody;
		}

		private bool EnrichAccountData(Guid accountId, SearchInfoRequest requestBody) {
			var request = new RestRequest {
				Method = Method.POST,
				RequestFormat = DataFormat.Json
			};
			request.JsonSerializer = new NewtonsoftBasedSerializer();
			request.AddBody(requestBody);
			request.Resource = SearchMethodName;
			IRestResponse response;
			try {
				response = _restClient.Post(request);
			} catch (Exception ex) {
				throw new HttpException((int)HttpStatusCode.InternalServerError, ex.Message);
			}
			HandleRestClientError(response);
			SearchInfoResponse responseInfo =
				ServiceStack.Text.JsonSerializer.DeserializeFromString<SearchInfoResponse>(response.Content);
			if (responseInfo.Status == "error") {
				throw new HttpException((int)HttpStatusCode.InternalServerError, responseInfo.Message);
			}
			if (responseInfo.CommunicationInfo == null) {
				var message = $"CommunicationInfo is null. StatusCode = '{response.StatusCode}' " +
					$"ResponseStatus = '{response.ResponseStatus}' ErrorMessage = '{response.ErrorMessage}' " +
					$"Content: {response.Content}";
				throw new HttpException((int)HttpStatusCode.InternalServerError, message);
			}
			bool result = UpdateEnrichedData(accountId, responseInfo.CommunicationInfo);
			return result;
		}

		private static void HandleRestClientError(IRestResponse response) {
			if (response.ErrorException != null) {
				throw response.ErrorException;
			}
			if (response.ResponseStatus != ResponseStatus.Completed && response.ErrorMessage.IsNotNullOrEmpty()) {
				var message = $"[{response.ResponseStatus}]: {response.ErrorMessage}";
				throw new HttpException((int)HttpStatusCode.InternalServerError, message);
			}
			bool isErrorStatusCode = (int)response.StatusCode >= 300;
			if (isErrorStatusCode) {
				throw new HttpException((int)HttpStatusCode.InternalServerError,
					$"[{response.StatusCode}] {response.Content}" );
			}
		}

		#endregion

		private void GetRequiredParameters(out string serviceUrl, out string apiKey) {
			serviceUrl = SysSettings.GetValue(UserConnection, "AccountEnrichmentServiceUrl", string.Empty);
			if (serviceUrl.IsNullOrEmpty()) {
				throw new HttpException((int)HttpStatusCode.InternalServerError,
					"Enrichment account service url not set");
			}
			apiKey = BpmonlineCloudEngine.GetAPIKey(UserConnection);
			if (apiKey.IsNullOrEmpty()) {
				throw new HttpException((int)HttpStatusCode.InternalServerError, "Cloud service api key not set");
			}
			
		}

		#region Methods: Public

		/// <summary>
		/// Gets companies list by partial name.
		/// </summary>
		/// <param name="name">Partial company name.</param>
		/// <returns>Collection of companies info.</returns>
		[OperationContract]
		[WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Wrapped,
			ResponseFormat = WebMessageFormat.Json)]
		public async Task<List<ShortCompanyInfo>> SuggestCompanies(string name) {
			string serviceUrl;
			string apiKey;
			GetRequiredParameters(out serviceUrl, out apiKey);
			_restClient.BaseUrl = serviceUrl;
			_restClient.AddDefaultHeader("ApiKey", apiKey);
			var request = new RestRequest {
				Method = Method.POST,
				RequestFormat = DataFormat.Json
			};
			request.AddParameter(ApiKeyParameter, apiKey);
			request.AddParameter(CompanyNameParameter, name);
			request.Resource = SuggestCompaniesMethodName;
			IRestResponse response;
			try {
				response = await _restClient.ExecutePostTaskAsync(request).ConfigureAwait(false);
			} catch (Exception ex) {
				throw new HttpException((int)HttpStatusCode.InternalServerError, ex.Message);
			}
			var responseInfo = ServiceStack.Text.JsonSerializer.DeserializeFromString<CloudRestResponse>(response.Content);
			if (responseInfo.CompaniesInfo == null) {
				throw new HttpException((int)HttpStatusCode.InternalServerError, response.Content);
			}
			return responseInfo.CompaniesInfo;
		}

		/// <summary>
		/// Does data enrichment for account.
		/// </summary>
		/// <param name="accountId">Target account id for enrichment process.</param>
		/// <returns>Collection of found info.</returns>
		[OperationContract]
		[WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Wrapped,
			ResponseFormat = WebMessageFormat.Json)]
		public SearchAccountInfoResult SearchAccountInfo(Guid accountId) {
			bool success = false;
			SearchInfoRequest requestBody = PrepareEnrichmentRequest();
			var enoughDataToRequest = SetupAccountData(accountId, requestBody);
			if (enoughDataToRequest) {
				success = EnrichAccountData(accountId, requestBody);
			}
			var result = new SearchAccountInfoResult {
				IsSuccessSearch = success,
				IsEnoughDataForEnrichment = enoughDataToRequest
			};
			return result;
		}

		#endregion

	}

	#endregion

	#region Class: SearchAccountInfoResult

	/// <summary>
	/// Represents response of company autocomplete service.
	/// </summary>
	[DataContract]
	public class SearchAccountInfoResult
	{

		#region Properties: Public

		/// <summary>
		/// Returns true if any new information where found.
		/// </summary>
		[DataMember(Name = "isSuccessSearch")]
		public bool IsSuccessSearch {
			get;
			set;
		}

		/// <summary>
		/// Returns true if enrichment is impossible due to lack of data.
		/// </summary>
		[DataMember(Name = "isEnoughDataForEnrichment")]
		public bool IsEnoughDataForEnrichment {
			get;
			set;
		}

		#endregion

	}

	#endregion

}
