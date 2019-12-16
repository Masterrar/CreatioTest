﻿namespace Terrasoft.Configuration.CESModels
{

	#region Class: CloudSenderDomain

	/// <summary>
	/// Represents information about domain for sending the emails.
	/// </summary>
	public class CloudSenderDomain
	{

		#region Properties: Public

		/// <summary>
		/// Gets or sets the domain address.
		/// </summary>
		public string Domain { get; set; }

		/// <summary>
		/// Gets or sets the verification key.
		/// </summary>
		public string Key { get; set; }

		/// <summary>
		/// Gets or sets the status of the domain.
		/// </summary>
		public string Status { get; set; }

		/// <summary>
		/// Gets or sets the verification error.
		/// </summary>
		public string Error { get; set; }

		#endregion

	}

	#endregion

}

