namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CampaignElementBrokenDataExceptionSchema

	/// <exclude/>
	public class CampaignElementBrokenDataExceptionSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CampaignElementBrokenDataExceptionSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CampaignElementBrokenDataExceptionSchema(CampaignElementBrokenDataExceptionSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("244e9e83-75da-48e7-886d-ea2dfe372f7f");
			Name = "CampaignElementBrokenDataException";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d0bba11f-3986-4819-81ab-1d3ddbfc1f48");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,146,193,110,194,48,12,134,207,32,241,14,86,119,217,46,237,157,1,135,49,14,187,77,26,47,224,166,110,177,214,36,85,146,138,49,196,187,207,77,3,99,92,216,209,191,236,223,159,255,196,160,38,223,161,34,216,146,115,232,109,29,242,181,53,53,55,189,195,192,214,228,107,212,29,114,99,54,45,105,50,193,207,166,199,217,116,210,123,54,13,124,28,124,32,253,60,155,138,242,224,168,145,126,88,183,232,253,28,110,198,94,156,253,36,243,138,1,55,95,138,186,193,57,78,21,69,1,11,223,107,141,238,176,74,245,165,3,216,84,172,48,80,5,101,156,7,235,68,83,214,120,150,197,38,64,37,134,162,128,74,219,128,198,117,249,217,186,184,242,238,250,178,101,5,106,0,252,7,31,204,225,138,117,114,140,188,191,103,10,68,112,189,10,214,201,181,239,209,122,236,184,61,41,10,111,134,3,99,203,223,228,1,193,208,94,168,125,64,35,193,219,26,194,142,100,132,8,148,163,122,153,221,103,203,138,85,186,99,207,97,7,231,45,8,190,35,197,53,75,98,242,156,146,150,188,174,199,134,242,11,88,113,75,182,232,208,161,6,35,31,97,153,165,246,108,181,21,162,84,8,29,74,210,228,149,227,82,240,7,216,104,158,47,138,56,27,173,82,184,247,209,31,37,182,225,239,36,247,39,137,185,68,79,143,151,250,8,167,20,53,153,106,76,59,214,163,250,87,60,253,0,65,86,41,137,192,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("244e9e83-75da-48e7-886d-ea2dfe372f7f"));
		}

		#endregion

	}

	#endregion

}

