namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CampaignFireTimeConfigSchema

	/// <exclude/>
	public class CampaignFireTimeConfigSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CampaignFireTimeConfigSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CampaignFireTimeConfigSchema(CampaignFireTimeConfigSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("b9223c62-28e8-4dfe-acbc-1c6c34636529");
			Name = "CampaignFireTimeConfig";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6c038aa0-46cd-4697-bc93-5c682e364aef");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,82,203,106,195,48,16,60,59,144,127,88,146,187,125,111,218,64,73,147,210,158,2,201,15,200,242,218,86,176,37,163,149,73,76,232,191,119,45,63,112,83,18,74,47,66,59,26,205,206,62,180,40,145,42,33,17,142,104,173,32,147,186,112,99,116,170,178,218,10,167,140,158,207,174,243,89,80,147,210,25,28,26,114,88,174,198,120,250,197,98,184,17,101,37,84,166,195,173,174,75,98,26,19,151,22,51,86,129,77,33,136,158,96,160,236,148,197,163,42,177,75,229,153,81,20,193,51,213,101,41,108,179,238,99,255,11,92,46,28,72,163,157,80,154,160,18,150,61,59,180,4,169,177,64,50,199,164,46,16,52,94,152,213,235,195,201,196,225,32,26,77,84,171,58,46,148,4,233,133,239,185,9,174,222,209,104,126,111,77,133,214,41,228,10,246,94,160,123,191,181,236,129,79,19,3,57,97,29,56,150,12,225,67,115,164,185,193,38,101,50,34,72,139,233,203,226,77,56,159,115,17,173,195,81,107,234,116,176,58,16,193,31,237,48,130,32,67,183,242,23,234,47,95,15,12,29,28,79,18,179,198,183,107,226,224,222,244,118,133,57,191,163,70,254,101,236,8,183,232,129,123,93,138,241,109,106,125,4,33,235,110,72,192,230,168,173,154,151,166,34,72,176,66,157,48,160,121,160,138,231,216,53,181,121,92,253,144,190,75,189,189,160,172,219,173,28,107,250,141,252,163,67,175,178,85,232,246,44,65,36,105,85,204,254,207,109,124,106,199,153,155,186,72,32,49,12,41,151,131,24,247,236,239,230,219,29,77,250,68,183,241,99,203,75,110,91,183,136,62,238,208,159,32,99,223,135,238,108,200,201,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b9223c62-28e8-4dfe-acbc-1c6c34636529"));
		}

		#endregion

	}

	#endregion

}

