namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CampaignEnumsSchema

	/// <exclude/>
	public class CampaignEnumsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CampaignEnumsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CampaignEnumsSchema(CampaignEnumsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("0c552018-5652-4db5-88b4-c7082c75a44f");
			Name = "CampaignEnums";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d0bba11f-3986-4819-81ab-1d3ddbfc1f48");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,146,207,78,195,48,12,198,207,155,180,119,176,198,129,11,90,129,35,98,147,208,254,0,39,14,219,30,192,75,221,53,82,154,132,196,97,170,208,222,157,172,101,101,131,117,187,112,179,235,175,246,47,246,167,177,32,111,81,16,44,200,57,244,38,227,193,216,232,76,174,131,67,150,70,247,186,159,189,110,175,219,185,114,180,142,41,76,117,40,30,96,206,100,199,166,176,138,152,210,168,79,101,173,141,194,36,73,224,209,135,162,64,87,142,190,243,70,1,156,35,131,140,153,64,38,31,83,2,207,49,4,147,129,69,199,82,72,139,154,253,53,160,96,249,177,171,146,5,97,234,73,96,157,177,228,184,132,204,56,16,193,57,210,12,236,80,251,170,253,96,63,63,57,0,176,97,165,164,0,138,224,173,220,157,248,200,206,31,244,234,195,51,177,63,66,171,102,111,114,41,242,227,118,63,112,210,195,194,5,26,52,61,15,113,58,75,79,205,63,111,90,149,48,132,219,155,106,117,255,9,48,67,229,207,16,188,106,241,139,225,238,34,3,42,117,204,177,145,156,155,192,128,186,140,39,218,159,120,133,62,178,196,224,52,92,11,211,147,222,65,220,199,112,91,251,141,116,90,91,238,132,253,154,203,161,154,211,123,32,45,104,166,204,102,66,10,203,165,150,220,106,196,74,1,33,74,234,45,62,122,34,16,142,178,97,191,165,231,84,81,17,77,214,79,70,23,205,117,153,234,140,205,106,50,169,33,197,210,183,236,104,18,75,151,220,210,244,137,151,113,109,141,94,118,181,221,205,91,214,189,253,2,61,145,59,198,23,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("0c552018-5652-4db5-88b4-c7082c75a44f"));
		}

		#endregion

	}

	#endregion

}

