﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CampaignSignalFragmentSyncManagerSchema

	/// <exclude/>
	public class CampaignSignalFragmentSyncManagerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CampaignSignalFragmentSyncManagerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CampaignSignalFragmentSyncManagerSchema(CampaignSignalFragmentSyncManagerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f640b49a-c5da-4d1a-b93b-a51f180dd679");
			Name = "CampaignSignalFragmentSyncManager";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d0bba11f-3986-4819-81ab-1d3ddbfc1f48");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,237,88,75,111,219,56,16,62,171,64,255,3,225,189,200,64,32,119,175,77,28,32,113,210,174,22,155,199,218,14,122,88,236,129,150,198,54,17,137,84,73,42,169,91,228,191,239,80,212,139,182,44,231,177,11,236,161,1,2,91,36,103,230,227,55,195,143,30,113,154,130,202,104,4,100,14,82,82,37,150,58,152,8,190,100,171,92,82,205,4,127,255,238,199,251,119,94,174,24,95,145,217,70,105,72,143,235,231,182,137,132,125,227,193,197,121,51,101,6,38,52,205,40,91,113,140,163,180,34,227,98,48,168,70,3,103,154,114,173,208,26,237,127,145,176,66,60,100,146,80,165,62,146,106,213,12,255,105,242,73,210,85,10,92,207,54,60,186,162,156,174,64,22,70,163,209,136,156,168,60,77,169,220,156,150,207,23,160,34,201,22,160,136,194,213,107,41,56,251,14,146,232,53,213,132,41,242,40,228,61,196,228,145,233,53,137,202,32,36,163,82,179,136,101,6,78,233,102,41,36,121,92,179,104,77,66,206,52,163,73,133,40,68,142,194,216,184,170,205,85,1,146,64,2,6,36,9,227,160,194,54,106,129,203,242,69,194,34,162,128,38,8,32,50,251,60,188,77,210,80,113,78,21,116,18,225,253,40,200,104,40,52,204,202,60,210,66,34,147,183,69,88,187,162,132,112,48,170,255,57,103,113,189,191,48,62,34,238,64,65,193,208,120,244,62,146,5,226,242,219,107,183,150,17,83,97,222,83,137,17,120,108,97,186,152,175,64,175,69,108,224,74,246,64,53,148,120,237,3,97,200,234,149,120,128,219,86,158,252,59,5,18,183,202,33,50,133,76,114,231,177,140,234,61,80,73,190,230,32,55,88,135,159,65,111,59,249,211,76,249,91,166,199,133,165,4,157,75,110,141,131,203,111,16,229,26,124,59,247,228,162,123,16,200,205,5,102,95,195,172,41,185,24,61,106,26,189,4,104,92,248,176,72,119,253,245,96,181,134,175,66,57,133,164,16,130,127,13,102,237,240,141,120,103,184,38,210,38,198,53,60,182,114,54,23,83,192,111,12,43,182,14,53,23,38,177,214,194,111,67,85,214,201,152,112,120,44,61,250,237,252,207,133,129,110,39,74,108,214,4,165,45,201,83,174,130,73,2,84,250,206,92,241,213,43,87,248,131,40,3,45,178,193,17,25,224,233,137,37,75,146,26,224,93,24,15,134,59,203,205,82,51,17,156,41,127,80,157,197,22,170,93,35,251,17,20,7,219,255,48,180,150,95,168,194,148,53,107,207,120,236,119,120,187,201,230,116,145,192,53,222,4,24,119,166,33,155,136,52,51,252,27,8,161,186,252,154,211,196,141,128,226,1,195,202,109,136,185,147,191,11,198,187,156,95,166,148,37,115,42,87,208,142,99,241,149,188,148,126,188,224,166,211,131,11,47,108,99,106,49,219,207,82,47,196,29,84,14,162,50,29,229,89,117,194,31,4,219,50,170,60,154,28,148,46,103,154,234,92,181,38,189,109,178,209,49,58,210,40,183,187,215,102,208,17,189,254,170,241,170,173,220,119,228,105,167,12,183,40,72,165,75,1,62,35,222,187,125,220,247,86,117,19,245,60,79,238,203,114,112,162,45,192,141,134,207,232,116,234,70,179,16,106,23,211,222,228,154,123,101,59,171,108,43,171,108,208,81,77,237,74,178,151,211,118,230,10,51,220,168,144,177,107,108,81,155,49,71,37,102,25,146,178,220,92,139,63,68,116,255,27,51,215,146,123,125,216,117,253,250,102,78,241,79,141,115,20,232,215,30,141,27,6,215,2,25,192,219,131,225,65,241,159,177,235,192,189,218,234,156,239,137,92,77,127,146,34,61,32,122,109,57,48,28,53,245,244,101,13,18,44,113,251,105,123,254,113,251,169,198,47,86,227,94,49,70,148,59,50,92,212,210,95,127,151,71,11,255,222,32,203,71,47,243,17,242,91,41,86,18,148,170,28,148,246,79,195,55,11,206,51,126,114,11,141,54,16,219,249,237,166,170,24,152,22,222,85,37,54,98,73,68,6,182,133,196,206,71,86,34,101,219,172,53,125,0,162,5,89,0,73,81,179,98,243,251,93,224,20,52,238,1,72,36,97,57,30,76,210,12,153,144,58,202,156,250,29,140,78,137,54,217,13,106,155,209,54,166,19,187,101,117,90,74,169,253,169,126,50,170,134,173,218,150,123,35,8,68,74,22,183,133,247,166,217,194,65,189,29,23,238,188,87,252,28,61,254,63,210,106,27,224,82,94,201,50,161,171,255,146,104,19,228,117,100,191,230,110,236,35,252,44,142,85,113,81,118,246,254,134,221,174,137,146,51,84,102,130,18,131,114,132,141,142,106,210,83,83,55,95,3,199,97,147,29,213,100,114,79,44,198,137,150,148,43,90,92,74,125,244,103,70,161,8,71,149,26,15,220,126,106,112,26,22,111,81,34,48,181,211,202,191,123,227,97,218,49,93,133,155,221,164,78,68,206,139,210,107,189,47,137,29,168,135,83,109,26,244,144,163,134,98,118,91,205,224,243,123,74,26,199,16,183,239,111,139,106,76,62,88,117,179,175,151,252,162,253,92,216,190,81,72,156,118,61,6,151,92,229,18,46,206,155,33,127,88,133,241,26,195,0,85,86,234,121,195,126,37,162,158,150,155,90,255,247,98,218,121,21,209,217,228,122,158,97,162,181,174,105,181,247,172,239,235,206,159,109,82,191,118,216,99,209,98,1,27,193,148,117,210,240,132,53,171,163,53,241,47,191,69,144,181,147,229,56,152,138,36,89,208,232,190,203,133,167,17,209,99,229,175,248,120,106,95,84,221,236,246,92,92,118,212,29,196,177,127,0,206,155,41,147,227,20,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f640b49a-c5da-4d1a-b93b-a51f180dd679"));
		}

		#endregion

	}

	#endregion

}

