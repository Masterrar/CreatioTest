namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CampaignAddLandingAudienceFlowElementSchema

	/// <exclude/>
	public class CampaignAddLandingAudienceFlowElementSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CampaignAddLandingAudienceFlowElementSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CampaignAddLandingAudienceFlowElementSchema(CampaignAddLandingAudienceFlowElementSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("96686031-a67a-4d43-b6a1-db7f65c9f6a9");
			Name = "CampaignAddLandingAudienceFlowElement";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d0bba11f-3986-4819-81ab-1d3ddbfc1f48");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,83,219,106,219,64,16,125,86,32,255,48,164,47,9,4,233,61,142,13,137,115,161,208,148,22,55,31,48,217,29,201,11,210,174,178,23,187,198,244,223,59,218,149,20,181,56,169,251,34,164,185,156,57,103,206,72,99,67,174,69,65,240,131,172,69,103,74,159,47,141,46,85,21,44,122,101,244,233,201,254,244,36,11,78,233,10,86,59,231,169,153,141,223,211,22,75,249,221,45,167,56,249,201,82,197,157,176,172,209,185,43,88,98,211,162,170,244,141,148,95,80,75,110,188,9,82,145,22,244,80,155,237,125,77,13,105,31,27,139,162,128,107,23,154,6,237,110,209,127,223,255,36,17,60,190,212,4,40,37,244,8,128,61,4,80,234,207,135,246,98,210,223,134,151,90,9,16,29,143,227,104,192,21,220,162,163,177,246,16,209,108,31,201,142,50,191,89,211,146,245,138,88,43,191,123,18,158,100,42,249,91,80,12,240,122,61,10,255,89,130,48,117,104,52,104,246,0,176,86,232,0,61,24,171,42,165,177,6,199,210,132,7,111,162,240,81,176,210,32,122,122,249,56,99,170,58,107,7,18,96,54,236,144,146,4,206,219,104,160,9,86,208,42,2,143,52,150,145,197,215,142,196,30,42,242,51,158,204,143,95,189,74,210,50,9,253,64,117,220,243,7,146,159,181,122,13,76,93,242,2,85,169,200,130,41,7,43,223,19,145,188,123,12,106,52,157,55,246,31,4,159,200,175,141,60,210,147,59,42,149,38,199,9,34,16,150,202,249,217,224,253,247,64,118,119,86,44,160,52,54,58,161,105,11,45,178,116,161,90,212,222,29,225,72,140,88,242,193,106,183,152,204,72,78,116,224,175,221,20,216,174,149,88,67,95,200,231,17,29,114,227,228,233,160,235,98,192,123,199,242,132,13,143,52,56,237,82,228,252,2,186,63,58,203,54,104,251,27,123,50,146,106,152,15,123,238,235,163,112,94,222,134,209,108,206,56,171,183,226,243,209,146,75,120,118,100,185,69,115,142,247,126,49,139,224,255,186,180,249,116,116,126,160,34,193,36,141,135,106,19,116,172,58,124,8,41,250,103,144,99,191,1,97,0,239,32,241,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("96686031-a67a-4d43-b6a1-db7f65c9f6a9"));
		}

		#endregion

	}

	#endregion

}

