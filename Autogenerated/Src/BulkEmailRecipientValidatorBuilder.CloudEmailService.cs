namespace Terrasoft.Configuration
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using Terrasoft.Configuration.CES;

	#region Class:  BulkEmailRecipientValidatorBuilder

	/// <summary>
	/// Represents a class for building macro validation rules.
	/// </summary>
	public class BulkEmailRecipientValidatorBuilder
	{

		#region Constants: Private

		private const string ActiveDomainStatus = "active";

		#endregion

		#region Fields: Private

		private readonly ICESApi _serviceApi;

		#endregion

		#region Constructors: Public

		/// <summary>
		/// Initializes a new instance of the <see cref="BulkEmailRecipientValidatorBuilder"/> class.
		/// </summary>
		/// <param name="serviceApi">Service for working with api.</param>
		public BulkEmailRecipientValidatorBuilder(ICESApi serviceApi) {
			_serviceApi = serviceApi;
		}

		#endregion

		#region Methods: Private

		private HashSet<string> GetValidDomains() {
			var response = _serviceApi.SenderDomainsInfo();
			var domains = response.Domains
				.Where(x => x.Status == ActiveDomainStatus)
				.Select(x => x.Domain);
			return domains.ToHashSet();
		}

		#endregion

		#region Methods: Public

		/// <summary>
		/// Initializes validation rules.
		/// </summary>
		public List<BaseValidationRule> InitRules() {
			var domains = new Lazy<HashSet<string>>(GetValidDomains);
			var result = new List<BaseValidationRule> {
				new FromNameNotNullValidationRule(),
				new FromEmailMaskValidationRule(),
				new FromEmailDomainValidationRule(domains)
			};
			return result;
		}

		#endregion

	}

	#endregion
}
