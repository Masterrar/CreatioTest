namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CampaignNextFireTimeResponseSchema

	/// <exclude/>
	public class CampaignNextFireTimeResponseSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CampaignNextFireTimeResponseSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CampaignNextFireTimeResponseSchema(CampaignNextFireTimeResponseSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("33b2b06a-b8c5-4d45-827a-16cf4cc3cdd4");
			Name = "CampaignNextFireTimeResponse";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6c038aa0-46cd-4697-bc93-5c682e364aef");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,146,77,111,194,48,12,134,207,32,241,31,44,118,25,210,68,239,99,112,97,154,180,195,16,2,180,195,166,29,210,224,150,76,77,82,57,137,54,134,248,239,115,211,150,175,105,226,150,56,206,235,199,126,109,132,70,87,10,137,176,66,34,225,108,230,135,83,107,50,149,7,18,94,89,211,235,238,122,221,78,112,202,228,176,220,58,143,122,116,113,31,46,130,241,74,227,112,137,164,68,161,126,226,191,99,214,169,176,214,255,189,16,114,156,95,110,8,115,254,14,211,66,56,119,15,83,161,75,161,114,51,195,111,255,164,8,87,92,104,193,196,214,56,140,249,73,146,192,131,11,90,11,218,78,154,59,55,224,73,72,15,153,37,160,38,27,68,106,131,7,217,8,130,97,69,200,88,18,34,124,43,149,156,104,189,63,10,47,90,177,15,14,148,33,45,148,4,89,177,93,65,235,236,34,222,161,159,57,217,18,201,43,228,166,230,81,166,126,191,228,143,129,165,167,106,62,132,37,211,163,241,113,162,96,51,206,68,4,73,152,141,251,204,22,75,246,147,9,124,109,148,220,128,50,178,8,107,116,124,224,198,117,253,233,106,215,177,224,106,163,220,101,57,183,177,161,88,67,138,96,83,47,148,193,53,100,100,245,17,250,15,74,53,174,87,81,4,92,109,203,227,58,224,173,77,63,81,250,59,168,114,222,172,193,103,230,27,48,119,43,85,217,36,45,17,39,65,41,40,238,134,50,60,102,197,48,7,198,51,107,106,111,94,80,167,72,183,51,94,98,24,67,223,156,56,209,31,84,134,181,142,185,122,160,167,86,65,181,215,157,78,142,126,20,15,174,57,236,27,223,208,172,107,235,226,189,142,158,7,247,191,25,4,71,56,61,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("33b2b06a-b8c5-4d45-827a-16cf4cc3cdd4"));
		}

		#endregion

	}

	#endregion

}

