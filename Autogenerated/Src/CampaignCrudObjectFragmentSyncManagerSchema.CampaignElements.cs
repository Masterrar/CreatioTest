﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CampaignCrudObjectFragmentSyncManagerSchema

	/// <exclude/>
	public class CampaignCrudObjectFragmentSyncManagerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CampaignCrudObjectFragmentSyncManagerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CampaignCrudObjectFragmentSyncManagerSchema(CampaignCrudObjectFragmentSyncManagerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("3906c394-78ea-4a2f-b701-9f3efd43e09f");
			Name = "CampaignCrudObjectFragmentSyncManager";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d0bba11f-3986-4819-81ab-1d3ddbfc1f48");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,237,88,77,111,227,54,16,61,107,129,253,15,132,123,168,140,46,228,246,186,137,3,108,156,236,86,69,243,81,219,193,158,105,106,108,179,145,72,45,73,37,113,23,249,239,29,138,146,37,58,178,226,100,183,64,11,244,98,155,95,111,30,223,12,135,28,11,154,129,206,41,3,50,7,165,168,150,75,19,77,164,88,242,85,161,168,225,82,188,125,243,245,237,155,160,208,92,172,200,108,163,13,100,71,219,118,123,137,130,125,253,209,217,41,14,225,224,15,10,86,136,72,38,41,213,250,61,153,208,44,167,124,37,38,170,72,174,22,127,2,51,31,21,93,101,32,204,108,35,216,5,21,116,5,170,92,56,26,141,200,177,46,178,140,170,205,73,213,62,3,205,20,95,128,38,26,103,175,149,20,252,47,80,196,172,169,33,92,147,123,169,110,33,33,247,220,172,9,171,12,145,156,42,195,25,207,169,48,186,130,89,74,69,238,215,156,173,73,44,184,225,52,173,89,197,184,211,56,177,80,219,229,26,63,104,74,32,5,75,146,196,73,84,115,27,181,200,229,197,34,229,140,104,160,41,18,96,118,175,135,109,149,52,146,156,82,13,157,98,4,95,75,65,26,41,165,208,70,21,204,72,133,138,94,151,166,221,140,138,198,65,150,195,79,5,79,182,251,140,147,119,196,239,40,165,24,90,212,224,61,89,32,183,176,61,183,99,154,13,153,224,177,162,10,34,113,108,125,234,23,96,214,50,177,172,21,191,163,6,236,88,73,220,53,9,71,137,111,242,4,127,206,10,157,35,8,70,214,117,203,129,225,141,6,133,251,23,184,39,139,87,120,205,33,41,57,4,119,84,145,162,68,33,99,242,9,76,31,226,31,5,168,77,184,131,115,84,194,40,48,133,18,21,82,116,254,0,172,48,16,186,193,106,159,79,121,199,226,90,201,149,2,173,191,23,239,110,196,239,195,251,78,162,203,207,48,184,81,158,230,68,37,83,72,203,60,240,2,222,73,9,226,120,247,0,246,208,118,8,175,226,139,88,134,178,151,200,220,79,247,27,89,54,209,240,242,24,176,107,115,37,25,186,219,238,171,192,230,184,255,72,116,210,220,129,248,105,220,31,158,125,113,228,67,117,237,119,134,154,48,99,165,60,127,224,218,248,4,231,114,10,248,139,99,246,217,70,193,92,94,200,59,112,203,194,182,91,180,67,26,19,1,247,21,108,216,38,58,151,214,77,110,160,98,233,150,224,165,147,22,153,208,209,36,5,170,66,111,172,252,25,84,51,194,1,203,193,200,124,240,142,12,48,19,38,138,167,233,150,224,77,156,12,134,254,244,58,151,182,88,92,229,115,186,72,225,18,111,81,4,233,152,208,129,82,126,69,101,230,14,127,30,14,163,15,58,28,124,166,26,67,162,153,251,65,36,207,155,155,25,200,39,50,203,109,20,226,210,40,214,231,95,10,154,250,22,240,118,128,97,13,27,163,91,213,111,146,119,238,229,60,163,60,157,83,181,130,182,29,199,175,18,170,194,9,162,171,3,212,136,219,156,90,82,247,171,212,80,124,226,146,29,78,153,242,248,216,54,162,223,236,51,219,235,225,198,234,105,145,222,86,74,120,214,22,224,91,195,54,130,78,125,107,142,194,22,98,218,105,161,253,194,216,149,153,251,70,176,189,43,228,193,65,232,174,227,6,207,134,84,5,136,18,72,149,248,212,221,126,108,159,119,150,102,57,202,181,220,92,202,223,37,187,253,149,219,4,225,167,4,55,175,63,21,216,208,254,63,29,28,144,14,126,233,73,7,195,232,82,162,36,81,41,164,14,15,144,33,242,111,153,109,36,236,177,92,15,127,84,50,123,38,63,180,119,105,69,107,162,236,243,26,20,56,37,247,235,120,248,241,252,47,36,174,111,61,47,7,60,144,165,193,53,144,184,241,221,106,168,236,152,150,232,186,62,38,114,73,100,14,174,130,195,146,69,213,199,203,213,71,107,122,7,196,72,178,0,146,225,105,75,236,43,69,226,16,52,240,0,132,41,88,142,7,147,44,199,29,43,195,114,79,232,193,232,132,24,171,89,180,93,51,218,229,116,236,182,172,79,170,76,240,197,62,165,162,227,81,221,237,146,69,181,55,130,68,148,226,73,59,111,92,53,91,120,54,83,140,75,184,224,181,15,143,163,127,163,182,174,124,173,146,1,89,166,116,245,79,170,109,141,188,78,241,87,231,247,62,213,221,35,85,215,111,78,251,191,66,103,33,255,35,209,6,39,190,35,248,234,199,3,139,111,118,221,248,164,6,195,228,130,157,214,33,186,113,94,55,30,58,140,24,69,133,166,101,214,236,83,28,151,209,140,8,204,26,227,129,255,108,30,156,196,152,85,169,96,96,195,165,229,114,63,37,163,167,209,67,37,204,83,63,186,231,58,46,111,253,193,145,120,84,159,247,174,45,33,98,97,64,161,67,91,85,205,225,245,135,181,221,190,95,154,135,127,245,95,79,88,150,80,11,87,4,73,133,23,180,15,22,157,11,93,40,56,59,109,186,194,97,109,33,104,22,70,51,131,102,230,141,240,117,222,12,140,218,212,211,131,78,58,219,170,232,249,58,38,8,102,62,66,83,222,238,153,223,87,17,31,188,100,91,148,238,89,209,146,1,31,244,25,239,212,225,17,227,213,176,53,9,207,31,24,228,109,71,121,0,83,153,166,11,202,110,187,32,2,131,140,238,107,188,242,235,209,187,156,246,122,187,251,174,114,189,126,39,246,253,13,201,70,198,115,85,20,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("3906c394-78ea-4a2f-b701-9f3efd43e09f"));
		}

		#endregion

	}

	#endregion

}
