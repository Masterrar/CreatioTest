namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ICampaignFragmentSyncManagerSchema

	/// <exclude/>
	public class ICampaignFragmentSyncManagerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ICampaignFragmentSyncManagerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ICampaignFragmentSyncManagerSchema(ICampaignFragmentSyncManagerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("5f487be7-70f8-43c3-96b8-4b744c2ea4c4");
			Name = "ICampaignFragmentSyncManager";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d0bba11f-3986-4819-81ab-1d3ddbfc1f48");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,237,84,193,78,35,49,12,61,83,169,255,96,149,11,72,168,115,135,210,75,17,82,15,72,72,44,31,224,102,60,51,145,38,206,96,39,64,65,252,59,153,180,180,29,96,119,47,28,57,69,177,157,231,247,158,147,48,58,210,14,13,193,31,18,65,245,85,152,46,60,87,182,142,130,193,122,30,143,94,199,163,163,168,150,235,65,137,208,197,120,148,50,199,66,117,42,131,37,7,146,42,1,157,195,114,129,174,67,91,243,181,96,237,136,195,221,154,205,13,50,214,36,249,76,81,20,48,211,232,28,202,122,190,221,95,145,26,177,43,82,168,34,155,190,51,182,54,172,161,242,2,102,139,7,29,74,176,198,118,200,65,65,19,106,35,158,237,75,38,10,91,160,208,96,0,171,96,188,115,41,218,159,175,197,199,14,124,181,7,82,211,144,67,160,150,122,126,10,79,54,52,64,15,17,219,47,176,173,175,173,153,126,176,46,14,104,119,113,213,90,3,246,67,249,127,132,31,189,102,241,59,199,110,40,52,190,212,115,184,205,56,155,228,103,107,114,224,110,71,41,217,243,189,25,189,204,167,198,154,102,159,175,182,36,20,26,44,97,69,196,64,207,100,98,160,114,186,107,85,124,238,53,75,176,232,128,211,189,184,156,68,37,73,183,129,41,15,100,50,95,178,6,228,164,52,121,57,83,34,48,66,213,229,228,126,88,86,204,193,180,168,58,157,21,25,236,123,236,189,207,84,46,124,228,48,153,231,165,199,62,204,13,116,14,32,31,189,45,15,189,57,25,242,128,33,251,51,72,92,251,97,193,151,206,167,23,255,48,255,218,75,18,172,191,35,248,235,8,178,67,63,57,135,99,226,114,243,72,242,254,109,243,209,12,130,41,246,14,232,172,123,97,187,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5f487be7-70f8-43c3-96b8-4b744c2ea4c4"));
		}

		#endregion

	}

	#endregion

}

