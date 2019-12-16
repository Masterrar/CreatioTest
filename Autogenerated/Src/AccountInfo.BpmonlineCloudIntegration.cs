namespace Terrasoft.Configuration.CESModels
{
	using Newtonsoft.Json;

	#region Class: AccountInfo

	/// <summary>
	/// Class for information about account status and its services.
	/// </summary>
	public class AccountInfo
	{

		#region Properties: Public

		/// <summary>
		/// Gets or sets the API key.
		/// </summary>
		/// <value>
		/// The API key.
		/// </value>
		public string ApiKey { get; set; }

		/// <summary>
		/// Gets or sets the name of the account.
		/// </summary>
		/// <value>
		/// The name of the account.
		/// </value>
		public string AccountName { get; set; }

		/// <summary>
		/// Gets or sets the web hook application domain.
		/// </summary>
		/// <value>
		/// The web hook application domain.
		/// </value>
		public string WebHookAppDomain { get; set; }

		/// <summary>
		/// Gets or sets the array of services.
		/// </summary>
		/// <value>
		/// The services.
		/// </value>
		public Service[] Services { get; set; }

		/// <summary>
		/// Gets or sets the response status.
		/// </summary>
		/// <value>
		/// "ok" if request succeed; otherwise "error"
		/// </value>
		public string Status { get; set; }

		/// <summary>
		/// Gets or sets the response code.
		/// </summary>
		/// <value>
		/// The code.
		/// </value>
		public int Code { get; set; }

		/// <summary>
		/// Gets or sets the response message.
		/// </summary>
		/// <value>
		/// The message.
		/// </value>
		public string Message { get; set; }

		/// <summary>
		/// Gets or sets the integration status.
		/// </summary>
		/// <value>
		/// The integration status.
		/// </value>
		public InegrationStatusInfo IntegrationStatus { get; set; }

		#endregion

	}

	#endregion

	#region Class: InegrationStatusInfo

	/// <summary>
	/// Class for indicating status of integration.
	/// </summary>
	public class InegrationStatusInfo
	{

		#region Properties: Public

		/// <summary>
		/// Gets or sets a value indicating whether account has a valid authentication key.
		/// </summary>
		/// <value>
		/// <c>true</c> if this account has a valid authentication key; otherwise, <c>false</c>.
		/// </value>
		[JsonProperty("isValidAuthKey")]
		public bool IsValidAuthKey { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether this account has a valid web hook application domain.
		/// </summary>
		/// <value>
		/// <c>true</c> if this account has a  valid web hook application domain; otherwise, <c>false</c>.
		/// </value>
		[JsonProperty("isValidWebHookAppDomain")]
		public bool IsValidWebHookAppDomain { get; set; }

		#endregion

	}

	#endregion

	#region Class: Service

	/// <summary>
	/// Class for information about service settings and status.
	/// </summary>
	public class Service
	{

		#region Properties: Public

		/// <summary>
		/// Gets or sets the name of the service.
		/// </summary>
		/// <value>
		/// The name of the service.
		/// </value>
		public string ServiceName { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether this instance is active.
		/// </summary>
		/// <value>
		///	<c>true</c> if this service is active; otherwise, <c>false</c>.
		/// </value>
		public bool IsActive { get; set; }

		/// <summary>
		/// Gets or sets the service settings.
		/// </summary>
		/// <value>
		/// The settings.
		/// </value>
		public Settings Settings { get; set; }

		/// <summary>
		/// Gets or sets the user settings.
		/// </summary>
		/// <value>
		/// The user settings.
		/// </value>
		public UserSettings UserSettings { get; set; }

		#endregion

	}

	#endregion

	#region Class: Settings

	/// <summary>
	/// Class for predefined account settings.
	/// </summary>
	public class Settings
	{

		#region Properties: Public

		/// <summary>
		/// Gets or sets the email provider name.
		/// </summary>
		/// <value>
		/// The provider name.
		/// </value>
		[JsonProperty("provider")]
		public string Provider { get; set; }

		#endregion

	}

	#endregion

	#region Class: UserSettings

	/// <summary>
	/// Class for user settings.
	/// </summary>
	public class UserSettings
	{

		#region Properties: Public

		/// <summary>
		/// Gets or sets the web hooks url.
		/// </summary>
		/// <value>
		/// The web hooks url.
		/// </value>
		[JsonProperty("webhooks")]
		public string Webhooks { get; set; }

		#endregion

	}

	#endregion

}

