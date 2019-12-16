﻿namespace Terrasoft.Configuration.CESModels
{

	using System.Runtime.Serialization;

	#region Class: AddSenderDomainsInfoRequest

	/// <summary>
	/// Class for request to add new sender domain.
	/// </summary>
	/// <seealso cref="Terrasoft.Configuration.CESModels.BaseServiceRequest" />
	[DataContract]
	public class AddSenderDomainsInfoRequest : BaseServiceRequest
	{

		#region Properties: Public

		/// <summary>
		/// Gets or sets the domain.
		/// </summary>
		/// <value>
		/// The domain.
		/// </value>
		[DataMember(Name = "domain")]
		public string Domain { get; set; }

		#endregion

	}

	#endregion

}

