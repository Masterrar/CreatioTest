namespace Terrasoft.Configuration.CESModels
{
	using System.Collections.Generic;
	using Newtonsoft.Json;

	#region Class: CloudSenderDomainsInfo

	/// <summary>
	/// Represents response of the service for retrieving domains for sending email.
	/// </summary>
	public class CloudSenderDomainsInfo
	{

		#region Properties: Public

		/// <summary>
		/// Gets or sets the domains and it's options.
		/// </summary>
		/// <seealso cref="SenderDomain"/>
		[JsonProperty("domains")]
		public List<CloudSenderDomain> Domains { get; set; }

		/// <summary>
		/// Gets or sets the default dkim. Contains value if provider sets single key for all domains.
		/// </summary>
		[JsonProperty("defaultDKIMKey")]
		public string DefaultDKIMKey { get; set; }

		/// <summary>
		/// Gets or sets the default dkim. Contains value if provider sets single key for all domains.
		/// </summary>
		[JsonProperty("dkimRecord")]
		public string DKIMRecord { get; set; }

		/// <summary>
		/// Gets or sets the SPF value.
		/// </summary>
		[JsonProperty("spfValue")]
		public string SpfValue { get; set; }

		/// <summary>
		/// Gets or sets the SPF value.
		/// </summary>
		[JsonProperty("dmarkValue")]
		public string DmarkValue { get; set; }

		/// <summary>
		/// Domain validation record.
		/// </summary>
		[JsonProperty("domainValidationRecord")]
		public string DomainValidationRecord { get; set; }

		/// <summary>
		/// Response status.
		/// </summary>
		[JsonProperty("status")]
		public string Status { get; set; }

		/// <summary>
		/// Response code.
		/// </summary>
		[JsonProperty("code")]
		public int Code { get; set; }

		/// <summary>
		/// Response message.
		/// </summary>
		[JsonProperty("message")]
		public string Message { get; set; }

		#endregion

	}

	#endregion

}

