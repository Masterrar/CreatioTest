namespace Terrasoft.Configuration {
	using System;
	using System.Runtime.Serialization;

	#region Class: MailingResponse

	/// <summary> 
	/// Provides properties of the bulk email sending responce .
	/// </summary>
	[DataContract]
	public class MailingResponse
	{

		#region Properties: Public

		/// <summary>
		/// Result of sending.
		/// </summary>
		[DataMember]
		public bool Success {
			get;
			set;
		}

		/// <summary>
		/// Bulk email status.
		/// </summary>
		[DataMember]
		public Guid StatusId {
			get;
			set;
		}

		/// <summary>
		/// Gets or sets exception.
		/// </summary>
		public Exception Exception { get; set; }

		public string RemindingLczStringCode { get; set; }

		#endregion
	}

	#endregion

}
