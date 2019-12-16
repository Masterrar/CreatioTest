namespace Terrasoft.Configuration
{
	using System;
	using System.Collections.ObjectModel;
	using System.Runtime.Serialization;

	#region Class: BulkEntityClientDuplicatesGroup

	[DataContract]
	public class BulkEntityClientDuplicatesGroup : EntityClientDuplicatesGroup
	{
		/// <summary>
		/// Identifier of group.
		/// </summary>
		[DataMember(Name = "groupId")]
		public new Guid GroupId
		{
			get;
			set;
		}

	}

	#endregion

	#region Class: BulkDuplicatesGroupResponse

	[DataContract]
	public class BulkDuplicatesGroupResponse : DuplicatesGroupResponse
	{
		/// <summary>
		/// Collection of groups.
		/// </summary>
		[DataMember(Name = "groups")]
		public new Collection<BulkEntityClientDuplicatesGroup> Groups
		{
			get;
			set;
		}
	}

	#endregion

}
