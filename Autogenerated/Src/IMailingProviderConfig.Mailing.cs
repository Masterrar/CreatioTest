namespace Terrasoft.Configuration
{

	#region Interface: IMailingProviderConfig

	/// <summary>
	/// Provides config of the mailing provider.
	/// </summary>
	public interface IMailingProviderConfig
	{

		#region Properties: Public

		/// <summary>
		/// Instance of the <see cref="IMailingTemplateFactory"/>.
		/// </summary>
		IMailingTemplateFactory TemplateFactory {
			get;
			set;
		}

		/// <summary>
		/// Instance of the <see cref="IMailingAudienceDataSourceFactory"/>.
		/// </summary>
		IMailingAudienceDataSourceFactory AudienceDataSourceFactory { 
			get;
			set;
		}

		#endregion

	}

	#endregion

}

