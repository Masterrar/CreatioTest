namespace Terrasoft.Configuration.MandrillService
{
	using System;
	using System.Collections.Generic;
	using System.IO;
	using System.Linq;
	using System.Net;
	using System.ServiceModel;
	using System.ServiceModel.Activation;
	using System.ServiceModel.Web;
	using System.Web.Script.Serialization;
	using Terrasoft.Core;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Web.Common;
	using Terrasoft.Web.Http.Abstractions;

	#region Class: MandrillWebhookService

	/// <summary>
	/// ############ ##### ####### ### ########### Webhook.
	/// </summary>
	[ServiceContract]
	[AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Required)]
	public class MandrillWebhookService : BaseService
	{

		#region Constants

		/// <summary>##### ### ###### API Mandrill.</summary>
		private const string MandrillApiUrl = "https://mandrillapp.com/api/1.0";

		/// <summary>##### ##### ###### ### ########### Webhook.</summary>
		private const string GeneralError = "General error.";

		/// <summary>##### ########### ####### Mandrill.</summary>
		private const string WebHookWebService = "/ServiceModel/MandrillService.svc/HandleWebHookEvents";

		#endregion

		#region Fields

		private string error;

		#endregion

		#region Properties

		public string Error {
			get {
				return string.IsNullOrEmpty(error) ? GeneralError : error;
			}
			set {
				error = value;
			}
		}

		#endregion

		#region Methods: Private

		private static HttpWebRequest PrepareRequest(string url) {
			var cookieContainer = new CookieContainer();
			var request = (HttpWebRequest)WebRequest.Create(url);
			request.CookieContainer = cookieContainer;
			request.Method = "POST";
			request.Accept = "*/*";
			request.ContentType = "application/json";
			request.KeepAlive = true;
			return request;
		}

		private static string ExecRequest(HttpWebRequest request, string body) {
			try {
				using (var writer = new StreamWriter(request.GetRequestStream())) {
					writer.Write(body);
					writer.Close();
				}
				using (var response = (HttpWebResponse)request.GetResponse()) {
					if (response.StatusCode != HttpStatusCode.OK) {
						return null;
					}
					using (var reader = new StreamReader(response.GetResponseStream())) {
						string objText = reader.ReadToEnd();
						return objText;
					}
				}
			}
			catch (WebException ex) {
				using (var reader = new StreamReader(ex.Response.GetResponseStream())) {
					string objText = reader.ReadToEnd();
					return objText;
				}
			}
			catch (Exception ex) {
				MandrillUtilities.Log.
					InfoFormat("MandrillWebhookService.ExecRequest: Mandrill API request error {0}.",
					ex.Message);
				return null;
			}
		}

		private string GetMandrillApiKey() {
			UserConnection userConnection = AppConnection.SystemUserConnection;
			var apiKey = (string)Terrasoft.Core.Configuration.SysSettings.GetValue(userConnection, "mandrillApiKey");
			return apiKey;
		}

		private static T ConvertToWebhookResponse<T>(string dynamicObject, out WebhookApiResponseError error)
			where T : class, new() {
			error = null;
			var serializer = new JavaScriptSerializer();
			try {
				var dynamicResult = serializer.Deserialize<WebhookApiResponseError>(dynamicObject);
				if (!string.IsNullOrEmpty(dynamicResult.status)) {
					error = dynamicResult;
					return null;
				}
			}
			catch {
			}
			try {
				var dynamicResult = serializer.Deserialize<T>(dynamicObject);
				return dynamicResult;
			} 
			catch {
				MandrillUtilities.Log.
					InfoFormat("MandrillWebhookService.ConvertToWebhookResponse: can't convert response to {0}.", 
					typeof(T).ToString());
			}
			return null;
		}

		private WebhookApiResponse GetCurrentWebhook() {
			UserConnection userConnection = AppConnection.SystemUserConnection;
			var result = new WebhookApiResponse();
			var esq = new EntitySchemaQuery(userConnection.EntitySchemaManager, "MandrillWebhook");
			esq.PrimaryQueryColumn.IsAlwaysSelect = true;
			esq.AddColumn("WebhookId");
			esq.AddColumn("AuthKey");
			esq.AddColumn("WebhookURL");
			EntityCollection webhooks = esq.GetEntityCollection(userConnection);
			foreach (Entity webhook in webhooks) {
				var webhookId = webhook.GetTypedColumnValue<int>("WebhookId");
				var authKey = webhook.GetTypedColumnValue<string>("AuthKey");
				var webhookUrl = webhook.GetTypedColumnValue<string>("WebhookURL");
				result.auth_key = authKey;
				result.id = webhookId;
				result.url = webhookUrl;
				return result;
			}
			return result;
		}

		private bool SetCurrentWebhook(WebhookApiResponse webhook) {
			UserConnection userConnection = AppConnection.SystemUserConnection;
			EntitySchema schema = userConnection.EntitySchemaManager.FindInstanceByName("MandrillWebhook");
			Entity entity = schema.CreateEntity(userConnection);
			entity.SetDefColumnValues();
			entity.SetColumnValue("WebhookId", webhook.id);
			entity.SetColumnValue("AuthKey", webhook.auth_key);
			entity.SetColumnValue("WebhookURL", webhook.url);
			entity.SetColumnValue("Name", string.Format("{0}", webhook.id));
			return entity.Save();
		}

		private void RemoveCurrentWebhook() {
			UserConnection userConnection = AppConnection.SystemUserConnection;
			(new Delete(userConnection).From("MandrillWebhook")).Execute();
		}

		private WebhookResponse InfoWebhook(int id) {
			string apiKey = GetMandrillApiKey();
			string requestUrl = string.Format("{0}{1}", MandrillApiUrl, "/webhooks/info.json");
			var requestBobyObject = new WebhookApiInfoRequest {
				key = apiKey,
				id = id
			};
			string requestBodyJson = new JavaScriptSerializer().Serialize(requestBobyObject);
			HttpWebRequest request = PrepareRequest(requestUrl);
			string response = ExecRequest(request, requestBodyJson);
			WebhookApiResponseError requestError = null;
			var requestResult = ConvertToWebhookResponse<WebhookApiResponse>(response, out requestError);
			var result = new WebhookResponse {
				Webhook = new List<WebhookApiResponse>()
			};
			if (requestError != null || requestResult == null) {
				if (requestError != null) {
					Error = requestError.message;
					MandrillUtilities.Log.InfoFormat("MandrillWebhookService.InfoWebhook error: {0}; {1}.", 
						requestError.name, requestError.message);
				}
				return result;
			}
			result.Success = true;
			result.Webhook.Add(requestResult);
			return result;
		}

		private WebhookResponse ListWebhook() {
			string apiKey = GetMandrillApiKey();
			string requestUrl = string.Format("{0}{1}", MandrillApiUrl, "/webhooks/list.json");
			var requestBobyObject = new WebhookApiListRequest {
				key = apiKey
			};
			string requestBodyJson = new JavaScriptSerializer().Serialize(requestBobyObject);
			HttpWebRequest request = PrepareRequest(requestUrl);
			string response = ExecRequest(request, requestBodyJson);
			WebhookApiResponseError requestError = null;
			var requestResult = ConvertToWebhookResponse<List<WebhookApiResponse>>(response, out requestError);
			var result = new WebhookResponse();
			if (requestError != null || requestResult == null) {
				if (requestError != null) {
					Error = requestError.message;
					MandrillUtilities.Log.InfoFormat("MandrillWebhookService.ListWebhook error: {0}; {1}.", 
						requestError.name, requestError.message);
				}
				return result;
			}
			result.Success = true;
			result.Webhook = requestResult;
			return result;
		}

		private WebhookResponse AddWebhook(string url, string description) {
			string apiKey = GetMandrillApiKey();
			string requestUrl = string.Format("{0}{1}", MandrillApiUrl, "/webhooks/add.json");
			var requestBodyObject = new WebhookApiAddRequest {
				key = apiKey,
				url = url,
				description = description,
				events = new string[] {}
			};
			string requestBodyJson = new JavaScriptSerializer().Serialize(requestBodyObject);
			HttpWebRequest request = PrepareRequest(requestUrl);
			string response = ExecRequest(request, requestBodyJson);
			WebhookApiResponseError requestError = null;
			var requestResult = ConvertToWebhookResponse<WebhookApiResponse>(response, out requestError);
			var result = new WebhookResponse {
				Webhook = new List<WebhookApiResponse>()
			};
			if (requestError != null || requestResult == null) {
				if (requestError != null) {
					Error = requestError.message;
					MandrillUtilities.Log.InfoFormat("AddWebhook error: {0}; {1}", requestError.name, 
						requestError.message);
				}
				return result;
			}
			result.Success = true;
			result.Webhook.Add(requestResult);
			return result;
		}

		private WebhookResponse DeleteWebhook(int id) {
			string apiKey = GetMandrillApiKey();
			string requestUrl = string.Format("{0}{1}", MandrillApiUrl, "/webhooks/delete.json");
			var requestBobyObject = new WebhookApiInfoRequest {
				key = apiKey,
				id = id
			};
			string requestBodyJson = new JavaScriptSerializer().Serialize(requestBobyObject);
			HttpWebRequest request = PrepareRequest(requestUrl);
			string response = ExecRequest(request, requestBodyJson);
			WebhookApiResponseError requestError = null;
			var requestResult = ConvertToWebhookResponse<WebhookApiResponse>(response, out requestError);
			var result = new WebhookResponse {
				Webhook = new List<WebhookApiResponse>()
			};
			if (requestError != null || requestResult == null) {
				if (requestError != null) {
					Error = requestError.message;
					MandrillUtilities.Log.InfoFormat("MandrillWebhookService.DeleteWebhook error: {0}; {1}.",
						requestError.name, requestError.message);
				}
				return result;
			}
			result.Success = true;
			result.Webhook.Add(requestResult);
			return result;
		}

		#endregion

		#region Methods: Public

		/// <summary>
		/// ##### ######### ######## ############# webhook'#, # # ####### 
		/// ########## ### ## ########## ############ ##### ##### API Mandrill.
		/// </summary>
		/// <returns>###### ######### ########### ### ###, # ######## ######.</returns>
		[OperationContract]
		[WebInvoke(Method = "POST", UriTemplate = "SubmitWebhook", BodyStyle = WebMessageBodyStyle.Wrapped,
			RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
		public WebhookResult SubmitWebhook() {
			var result = new WebhookResult();
			WebhookApiResponse currentWebhook = GetCurrentWebhook();
			//List webhooks registered on Mandrill account.
			WebhookResponse listWebhooks = ListWebhook();
			UserConnection userConnection = AppConnection.SystemUserConnection;
			string webhooksApplicationUrl = 
				(string)Terrasoft.Core.Configuration.SysSettings.GetValue(userConnection, "WebhooksApplicationUrl");
			string webhookUrl = !string.IsNullOrEmpty(webhooksApplicationUrl) 
				? webhooksApplicationUrl
				: string.Format(
					"{0}{1}", WebUtilities.GetBaseApplicationUrl(HttpContext.Current.Request), WebHookWebService);
			string previousWebhookUrl = currentWebhook.url;
			currentWebhook.url = webhookUrl;
			if (!listWebhooks.Success) {
				result.ErrorDescription = Error;
				return result;
			}
			if (listWebhooks.Webhook.Any(
					x => (x.id == currentWebhook.id) && (x.auth_key == currentWebhook.auth_key) 
						&& (x.url == currentWebhook.url))) {
				result.Success = true;
				return result;
			}
			//Remove webhooks that's already registered on the same url.
			foreach (WebhookApiResponse item in listWebhooks.Webhook) {
				if ((item.url != currentWebhook.url) && (item.url != previousWebhookUrl)) {
					continue;
				}
				if (!DeleteWebhook(item.id).Success) {
					result.ErrorDescription = Error;
					return result;
				}
			}
			//Register new webhooks.
			WebhookResponse newWebhook = AddWebhook(webhookUrl, string.Empty);
			if (!newWebhook.Success) {
				result.ErrorDescription = Error;
				return result;
			}
			//Remove old webhooks from DB.
			RemoveCurrentWebhook();
			//Save new webhooks to DB.
			bool isSaved = SetCurrentWebhook(newWebhook.Webhook[0]);
			if (!isSaved) {
				result.ErrorDescription = Error;
				return result;
			}
			result.Success = true;
			return result;
		}

		#endregion
	}

	#endregion

	#region Class: MandrillWebhooksObjects

	public class WebhookApiInfoRequest {
		public string key {
			get;
			set;
		}
		public int id {
			get;
			set;
		}
	}
	
	public class WebhookApiListRequest {
		public string key {
			get;
			set;
		}
	}

	public class WebhookApiAddRequest {
		public string key {
			get;
			set;
		}
		public string url {
			get;
			set;
		}
		public string description {
			get;
			set;
		}
		public string[] events {
			get;
			set;
		}
	}

	public class WebhookApiResponse {
		public int id {
			get;
			set;
		}
		public string url {
			get;
			set;
		}
		public string description {
			get;
			set;
		}
		public string auth_key {
			get;
			set;
		}
		public string[] events {
			get;
			set;
		}
		public string created_at {
			get;
			set;
		}
		public string last_sent_at {
			get;
			set;
		}
		public string batches_sent {
			get;
			set;
		}
		public string events_sent {
			get;
			set;
		}
		public string last_error {
			get;
			set;
		}
	}

	public class WebhookApiResponseError {
		public string status {
			get;
			set;
		}
		public int code {
			get;
			set;
		}
		public string name {
			get;
			set;
		}
		public string message {
			get;
			set;
		}
	}

	public class WebhookResponse {
		public bool Success {
			get;
			set;
		}
		public List<WebhookApiResponse> Webhook {
			get;
			set;
		}
	}

	public class WebhookResult {
		public bool Success {
			get;
			set;
		}
		public string ErrorDescription {
			get;
			set;
		}
	}

	#endregion
}

