namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CampaignCreateLeadProcessHelperSchema

	/// <exclude/>
	public class CampaignCreateLeadProcessHelperSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CampaignCreateLeadProcessHelperSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CampaignCreateLeadProcessHelperSchema(CampaignCreateLeadProcessHelperSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("7c1f6025-2ed1-42c2-928b-a879e96e8221");
			Name = "CampaignCreateLeadProcessHelper";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("2def6958-6e0c-463c-8c46-5a65b8967369");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,84,223,111,155,64,12,126,206,164,253,15,22,125,73,36,4,123,47,69,154,178,173,99,171,170,74,233,182,199,233,2,78,118,27,220,33,223,209,42,138,248,223,103,56,126,133,210,45,18,226,240,125,254,108,127,182,163,68,129,166,20,41,194,35,18,9,163,15,54,216,106,117,144,199,138,132,149,90,193,249,237,155,85,101,164,58,194,238,100,44,22,215,179,111,134,231,57,166,13,214,4,183,168,144,100,58,98,166,172,132,175,217,131,93,250,11,179,42,71,98,4,99,202,106,159,203,20,140,229,20,82,72,115,97,12,108,69,81,10,121,84,91,66,97,241,14,69,246,64,58,69,99,62,99,94,34,181,121,174,154,167,36,249,196,8,72,57,33,203,28,212,196,235,189,27,191,150,65,211,23,189,191,231,234,31,132,181,72,10,110,192,91,0,253,60,191,171,189,235,158,58,12,67,136,76,85,20,130,78,113,111,184,234,127,48,123,119,7,24,44,48,187,15,6,206,112,78,26,149,130,68,1,138,19,188,241,42,131,196,77,81,78,101,47,126,17,241,106,209,18,68,97,203,178,76,154,115,145,59,139,101,146,121,113,146,181,126,224,77,88,188,127,187,91,65,71,180,137,58,232,177,255,147,204,58,18,232,152,155,175,241,60,77,115,20,99,26,238,114,0,158,180,204,192,245,125,218,162,245,183,11,93,224,82,38,31,110,43,118,27,203,244,33,249,168,170,2,73,236,115,140,190,226,233,187,200,43,110,191,164,168,65,58,124,28,195,82,101,27,55,94,171,110,154,204,73,165,221,248,240,220,56,99,240,73,83,33,236,250,191,147,230,2,5,247,248,220,188,215,155,77,59,94,171,15,178,141,196,67,16,57,66,31,244,254,55,135,143,161,213,5,217,215,112,52,133,207,240,58,118,221,103,186,58,131,119,55,182,216,159,8,1,181,63,64,30,151,218,232,47,106,0,117,235,85,187,116,223,151,229,176,180,195,250,38,69,129,153,228,54,117,171,201,133,175,39,90,249,227,138,121,147,243,139,141,230,75,151,224,101,71,131,31,154,254,180,127,86,129,99,155,93,111,43,34,84,182,153,138,14,48,10,231,68,110,42,224,167,254,11,124,86,32,192,246,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("7c1f6025-2ed1-42c2-928b-a879e96e8221"));
		}

		#endregion

	}

	#endregion

}

