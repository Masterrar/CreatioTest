namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CampaignLandingFlowElementSchema

	/// <exclude/>
	public class CampaignLandingFlowElementSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CampaignLandingFlowElementSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CampaignLandingFlowElementSchema(CampaignLandingFlowElementSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("b28fe371-60dc-4a3a-8c22-fb58a012ed20");
			Name = "CampaignLandingFlowElement";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d0bba11f-3986-4819-81ab-1d3ddbfc1f48");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,147,219,110,26,49,16,134,175,137,148,119,24,209,27,144,34,239,125,72,144,40,77,35,164,70,162,10,125,0,179,158,93,44,121,237,237,216,38,165,168,239,222,89,239,1,200,233,6,105,103,230,255,231,155,241,96,101,133,190,150,57,194,6,137,164,119,69,16,75,103,11,93,70,146,65,59,123,125,117,188,190,26,69,175,109,9,207,7,31,176,154,13,223,231,18,66,177,148,85,45,117,105,63,44,248,246,149,83,156,252,66,88,178,53,44,141,244,254,22,122,221,15,105,21,171,190,27,247,242,96,176,66,27,82,117,150,101,112,231,99,85,73,58,204,187,239,135,63,152,199,32,183,6,193,180,42,168,101,137,128,173,14,194,78,6,40,180,9,72,30,100,84,26,45,143,168,34,66,112,131,130,11,117,208,232,69,223,36,59,235,82,199,173,209,57,228,13,226,39,132,112,194,191,224,30,29,19,251,48,234,154,92,141,212,116,187,133,117,178,110,243,175,135,75,129,205,14,33,90,253,155,113,181,106,40,11,141,4,174,0,9,121,36,106,218,190,224,22,10,71,149,24,76,206,225,123,250,199,168,21,116,208,43,5,71,40,49,204,192,55,63,255,58,62,180,170,69,188,228,125,194,176,115,170,129,37,23,48,15,168,252,39,192,124,49,65,106,235,25,207,7,87,129,113,37,119,103,62,46,69,132,156,176,184,31,47,154,103,200,241,103,68,58,140,179,57,104,203,219,151,70,255,77,119,246,193,32,41,66,24,34,89,63,95,245,10,84,231,198,131,35,191,109,244,8,146,57,186,55,25,222,94,220,101,189,75,218,79,63,21,184,61,223,40,111,25,146,11,60,98,88,116,146,20,152,76,161,185,255,209,104,47,137,23,103,88,244,228,20,26,184,239,247,154,102,207,67,170,230,101,237,217,139,4,219,60,159,138,39,195,19,220,192,47,143,196,18,203,57,158,122,58,27,204,107,201,231,145,235,90,218,224,91,45,247,216,74,143,226,45,83,171,122,171,16,11,171,38,253,61,174,79,233,77,243,79,185,129,113,199,186,82,227,169,88,217,201,217,60,162,75,181,62,93,131,118,99,239,144,165,244,251,23,212,70,47,131,28,251,15,41,215,254,75,104,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b28fe371-60dc-4a3a-8c22-fb58a012ed20"));
		}

		#endregion

	}

	#endregion

}

