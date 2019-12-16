namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CampaignExecutionLatenessEnumSchema

	/// <exclude/>
	public class CampaignExecutionLatenessEnumSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CampaignExecutionLatenessEnumSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CampaignExecutionLatenessEnumSchema(CampaignExecutionLatenessEnumSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("790d2649-25eb-4742-88b0-ff7156873fad");
			Name = "CampaignExecutionLatenessEnum";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6c038aa0-46cd-4697-bc93-5c682e364aef");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,181,147,203,78,196,48,12,69,215,29,169,255,96,137,45,106,121,173,16,131,132,74,119,48,27,102,197,46,147,184,173,165,198,169,146,148,135,16,255,78,250,200,48,18,204,192,2,150,182,174,207,189,118,20,22,26,93,39,36,194,26,173,21,206,84,62,43,12,87,84,247,86,120,50,156,46,222,210,69,186,72,142,44,214,161,132,146,123,125,9,133,208,157,160,154,203,23,148,253,32,187,19,30,25,157,27,181,121,158,195,149,235,181,22,246,245,122,174,111,209,73,75,27,116,208,206,82,168,140,5,57,131,0,35,41,139,128,124,135,208,245,155,150,36,96,48,63,228,157,132,172,201,23,251,177,241,136,214,108,173,179,173,108,215,36,89,25,70,88,194,201,241,184,197,247,156,149,241,13,113,13,141,120,66,216,32,50,104,114,21,89,84,123,161,247,147,32,144,79,15,145,31,140,70,192,22,53,178,119,240,76,190,1,79,161,37,13,43,26,246,252,189,231,236,168,214,97,190,136,227,101,68,47,225,236,80,142,120,78,32,7,181,197,80,89,240,141,96,112,29,74,170,8,21,132,151,244,36,69,251,249,150,67,210,61,97,138,40,94,194,249,191,248,70,128,96,5,238,239,142,24,115,223,176,250,233,158,23,65,255,62,125,19,100,53,253,148,161,12,189,15,137,13,88,198,97,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("790d2649-25eb-4742-88b0-ff7156873fad"));
		}

		#endregion

	}

	#endregion

}

