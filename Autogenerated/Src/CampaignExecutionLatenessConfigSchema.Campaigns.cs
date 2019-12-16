namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CampaignExecutionLatenessConfigSchema

	/// <exclude/>
	public class CampaignExecutionLatenessConfigSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CampaignExecutionLatenessConfigSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CampaignExecutionLatenessConfigSchema(CampaignExecutionLatenessConfigSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("363990ca-c5bf-49b2-9d2c-6f6312c3cdc6");
			Name = "CampaignExecutionLatenessConfig";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6c038aa0-46cd-4697-bc93-5c682e364aef");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,146,81,107,194,48,16,199,159,43,248,29,14,125,111,223,167,243,165,200,16,54,16,244,11,156,241,90,3,73,90,114,233,54,145,125,247,37,105,163,78,88,7,123,8,228,46,255,252,238,127,185,24,212,196,45,10,130,61,89,139,220,84,46,47,27,83,201,186,179,232,100,99,166,147,203,116,146,117,44,77,13,187,51,59,210,139,135,216,235,149,34,17,196,156,191,144,33,43,197,77,115,143,181,148,151,168,91,148,181,241,2,47,153,91,170,253,53,40,21,50,63,65,58,92,127,146,232,2,239,21,157,231,49,247,142,226,149,162,40,96,201,157,214,104,207,171,33,142,215,193,157,208,129,104,140,67,105,24,196,192,2,53,48,160,69,235,155,117,100,57,79,156,226,14,212,118,7,37,5,136,200,250,211,73,118,137,110,174,29,108,109,211,146,117,146,124,27,219,72,10,167,97,61,26,142,137,132,131,119,84,29,229,176,49,236,208,248,41,52,149,23,19,129,176,84,61,207,246,82,211,174,69,51,43,86,249,149,117,111,58,185,78,194,43,56,36,32,76,46,203,106,114,139,184,225,97,243,213,91,31,55,230,206,45,141,215,252,245,141,110,144,127,24,184,125,166,240,22,90,114,37,45,29,129,20,105,50,142,225,67,186,19,184,208,157,31,245,81,6,225,184,205,205,218,116,154,44,30,20,45,147,229,157,56,145,198,117,207,92,193,219,80,37,60,90,153,168,235,84,113,188,137,57,153,99,255,7,98,220,103,127,38,125,238,27,93,150,119,99,103,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("363990ca-c5bf-49b2-9d2c-6f6312c3cdc6"));
		}

		#endregion

	}

	#endregion

}

