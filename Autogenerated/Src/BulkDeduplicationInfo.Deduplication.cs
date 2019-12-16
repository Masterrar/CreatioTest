namespace Terrasoft.Configuration.Deduplication
{

	using System.Runtime.Serialization;

	#region Class: BulkDeduplicationInfo

	/// <summary>
	/// Bulk deduplication info
	/// </summary>
	[DataContract]
	public class BulkDeduplicationInfo {

		/// <summary>
		/// True if deduplication not started before.
		/// </summary>
		[DataMember(Name = "isFirstRun")]
		public bool IsFirstRun {
			get;
			set;
		}

		/// <summary>
		/// True if deduplication is running.
		/// </summary>
		[DataMember(Name = "isRunning")]
		public bool IsRunning {
			get;
			set;
		}

	}

	#endregion
	
}
