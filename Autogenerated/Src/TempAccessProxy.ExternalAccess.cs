namespace Terrasoft.Configuration.ExternalAccessPackage
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Threading.Tasks;
	using RestSharp;
	using Terrasoft.Common;
	using Terrasoft.Core.Factories;
	using Terrasoft.Services;

	#region Interface: ITempAccessProxy

	/// <summary>
	/// Proxy for TempAccess service Api.
	/// </summary>
	public interface ITempAccessProxy
	{

		#region Methods: Public

		/// <summary>
		/// Grants the access.
		/// </summary>
		/// <param name="resourceName">Name of the resource.</param>
		/// <param name="reason">The reason.</param>
		/// <param name="expirationDate">The expiration date.</param>
		/// <param name="GrantorSysAdminUnitId">The grantor system admin unit id.</param>
		/// <param name="GranteeClientIds">The grantee client ids.</param>
		void GrantAccess(string resourceName, string reason, DateTime expirationDate, Guid GrantorSysAdminUnitId,
			string[] GranteeClientIds);

		/// <summary>
		/// Enumerate granted access list.
		/// </summary>
		/// <param name="customerIds">The customer ids (Access grantors).</param>
		List<(string AccessId, string Url, string Description, DateTime ExpirationDate, string CustomerId)>
			GetAccessList(string[] customerIds);

		/// <summary>
		/// Request access token.
		/// </summary>
		/// <param name="accessId">Access id.</param>
		string GetAccessToken(string accessId);

		#endregion

	}

	#endregion

	#region Interface: ITempAccessDeactivator

	/// <summary>
	/// Proxy for TempAccess deactivation Api.
	/// </summary>
	public interface ITempAccessDeactivator
	{

		#region Methods: Public

		/// <summary>Deactivates the specified access ids.</summary>
		/// <param name="accessIds">The access ids.</param>
		/// <returns>Affected access count.</returns>
		int Deactivate(string[] accessIds);

		#endregion

	}

	#endregion

	#region Class: TempAccessProxy

	/// <summary>
	/// Default proxy for TempAccess service Api.
	/// </summary>
	/// <seealso cref="Terrasoft.Configuration.ExternalAccessPackage.ITempAccessProxy" />
	[DefaultBinding(typeof(ITempAccessProxy))]
	[DefaultBinding(typeof(ITempAccessDeactivator))]
	public class TempAccessProxy : ITempAccessProxy, ITempAccessDeactivator
	{

		#region Constants: Public

		public const string RegisterAccessScopes = "register_own_resource IdentityServerApi";
		public const string ListAccessScopes = "get_resource_list IdentityServerApi";
		public const int RegistrationTimeoutMs = 20000;
		public const string RegisterAccessMethod = "OwnedResources/register";
		public const string ListAccessMethod = "OwnedResources/list";
		public const string RemoveAccessesMethod = "OwnedResources/delete";

		#endregion

		#region Fields: Private

		private readonly string _serverUrl;
		private readonly string _clientId;
		private readonly string _clientSecret;

		#endregion

		#region Constructors: Public

		/// <summary>
		/// Initializes a new instance of the <see cref="TempAccessProxy"/> class.
		/// </summary>
		/// <param name="serverUrl">The identity server URL.</param>
		/// <param name="clientId">The application client id.</param>
		/// <param name="clientSecret">The client secret.</param>
		public TempAccessProxy(string serverUrl, string clientId, string clientSecret) {
			serverUrl.CheckArgumentNullOrWhiteSpace(nameof(serverUrl));
			clientId.CheckArgumentNullOrWhiteSpace(nameof(clientId));
			_serverUrl = serverUrl;
			_clientId = clientId;
			_clientSecret = clientSecret;
		}

		#endregion

		#region Properties: Public

		private IRestClient _restClient;

		/// <summary>
		/// Gets or sets the rest client for Api calls.
		/// </summary>
		/// <value>
		/// The rest client.
		/// </value>
		public IRestClient RestClient {
			get {
				if (_restClient == null) {
					_restClient = new RestClient {
						BaseUrl = _serverUrl
					};
					_restClient.AddDefaultHeader("Content-Type", "application/json");
				}
				return _restClient;
			}
			set => _restClient = value;
		}

		#endregion

		#region Methods: Private

		private static void HandleRestClientError(IRestResponse response) {
			if (response.ErrorException != null) {
				throw response.ErrorException;
			}
			if (response.ResponseStatus != ResponseStatus.Completed && response.ErrorMessage.IsNotNullOrEmpty()) {
				var message = $"[{response.ResponseStatus}]: {response.ErrorMessage}";
				throw new ApiServerConnectivityException(message);
			}
			bool isErrorStatusCode = (int)response.StatusCode >= 300;
			if (isErrorStatusCode) {
				throw new ApiServerException($"{response.StatusCode} {response.Content}");
			}
		}

		private string RequestAccessToken(string scopes) {
			var serverAddress = new ConstructorArgument("serverAddress", _serverUrl);
			var identityClient = ClassFactory.Get<IIdentityClient>(serverAddress);
			Task<string> resultTask;
			string token;
			try {
				resultTask =
					identityClient.RequestClientCredentialsTokenAsync(_clientId, _clientSecret, scopes);
				resultTask.ConfigureAwait(false);
				resultTask.Wait(RegistrationTimeoutMs);
			} catch(Exception ex) {
				throw new ApiServerException($"IdentityServer auth failed with {ex.ToString()}");
			};
			if (!resultTask.IsCompleted) {
				throw new ApiServerConnectivityException("IdentityServer busy or unaccessable.");
			}
			token = resultTask.Result;
			return token;
		}

		#endregion

		#region Methods: Public

		/// <summary>
		/// Grants the access.
		/// </summary>
		/// <param name="resourceName">Name of the resource.</param>
		/// <param name="reason">The reason.</param>
		/// <param name="expirationDate">The expiration date.</param>
		/// <param name="grantorSysAdminUnitId">The grantor system admin unit id.</param>
		/// <param name="granteeClientIds">The grantee client ids.</param>
		public void GrantAccess(string resourceName, string reason, DateTime expirationDate, Guid grantorSysAdminUnitId,
				string[] granteeClientIds) {
			resourceName.CheckArgumentNullOrWhiteSpace(nameof(resourceName));
			string token = RequestAccessToken(RegisterAccessScopes);
			var apiResource = new {
				Name = resourceName,
				DisplayName = reason,
				Properties = new {
					ExpirationDate = expirationDate.ToUniversalTime().ToString("o"),
					SysAdminUnitId = grantorSysAdminUnitId.ToString(),
					Type = "TempAccess"
				}
			};
			var data = new {
				ResourceInfo = apiResource,
				granteeClientIds
			};
			var request = new RestRequest {
				Method = Method.POST,
				RequestFormat = DataFormat.Json
			};
			request.AddBody(data);
			request.Resource = RegisterAccessMethod;
			request.AddHeader("Authorization", $"Bearer {token}");
			IRestResponse response = RestClient.Post(request);
			HandleRestClientError(response);
		}

		/// <summary>
		/// Enumerate granted access list.
		/// </summary>
		/// <param name="customerIds">The customer ids (Access grantors).</param>
		public List<(string AccessId, string Url, string Description, DateTime ExpirationDate, string CustomerId)>
				GetAccessList(string[] customerIds) {
			customerIds.CheckArgumentNullOrEmpty(nameof(customerIds));
			string token = RequestAccessToken(ListAccessScopes);
			var data = new {
				Type = "TempAccess",
				CustomerIds = customerIds
			};
			var request = new RestRequest {
				Method = Method.POST,
				RequestFormat = DataFormat.Json
			};
			request.AddBody(data);
			request.Resource = ListAccessMethod;
			request.AddHeader("Authorization", $"Bearer {token}");
			IRestResponse<List<ClientResources>> response = RestClient.Post<List<ClientResources>>(request);
			HandleRestClientError(response);
			List<ClientResources> resources = response.Data;
			var result = resources.SelectMany(clientInfo => clientInfo.Resources.Select(item => (
				AccessId: item.Name,
				Url: clientInfo.ClientUri,
				Description: item.DisplayName,
				item.ExpirationDate,
				clientInfo.CustomerId
			))).ToList();
			return result;
		}

		/// <summary>
		/// Request access token.
		/// </summary>
		/// <param name="accessId">The access id.</param>
		/// <returns></returns>
		public string GetAccessToken(string accessId) {
			return RequestAccessToken(accessId);
		}

		/// <summary>Deactivates the specified access list.</summary>
		/// <param name="accessIds">The access ids.</param>
		/// <returns>Affected access count.</returns>
		public int Deactivate(string[] accessIds) {
			string token = RequestAccessToken(RegisterAccessScopes);
			var data = new {
				Resources = accessIds
			};
			var request = new RestRequest {
				Method = Method.POST,
				RequestFormat = DataFormat.Json
			};
			request.AddBody(data);
			request.Resource = RemoveAccessesMethod;
			request.AddHeader("Authorization", $"Bearer {token}");
			IRestResponse response = RestClient.Post(request);
			HandleRestClientError(response);
			var parsedResponse = Newtonsoft.Json.Linq.JObject.Parse(response.Content);
			int affectedRecords = parsedResponse.Value<int>("affectedResourceCount");
			return affectedRecords;
		}

		#endregion

	}

	#endregion

}

