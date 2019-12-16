﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CampaignBaseCrudObjectElementSchema

	/// <exclude/>
	public class CampaignBaseCrudObjectElementSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CampaignBaseCrudObjectElementSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CampaignBaseCrudObjectElementSchema(CampaignBaseCrudObjectElementSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("0dd28763-79b1-489d-8d59-c59428fa9c10");
			Name = "CampaignBaseCrudObjectElement";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d0bba11f-3986-4819-81ab-1d3ddbfc1f48");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,221,88,91,111,219,54,20,126,118,129,254,135,51,239,161,14,96,203,73,150,52,119,15,137,47,129,135,53,13,226,180,125,40,134,129,145,142,109,174,186,149,164,18,120,89,254,251,14,73,201,146,108,75,73,177,14,3,246,16,37,162,14,63,158,203,119,46,76,200,2,148,49,115,17,110,81,8,38,163,169,114,250,81,56,229,179,68,48,197,163,240,245,171,199,215,175,26,137,228,225,12,38,11,169,48,56,89,121,39,121,223,71,87,11,75,231,18,67,20,220,93,147,249,149,135,95,243,197,43,124,80,36,173,15,251,69,70,97,229,7,103,66,96,204,231,127,26,85,114,177,162,174,65,80,245,69,96,213,186,211,103,65,204,248,76,111,36,145,31,5,206,8,31,250,62,147,242,24,178,143,23,76,98,95,36,222,251,187,63,200,188,161,143,1,134,202,108,232,118,187,112,42,147,32,96,98,209,75,223,179,93,32,221,57,6,12,208,202,131,138,32,22,209,61,247,16,238,8,16,250,55,31,6,16,197,104,221,43,129,206,141,204,1,50,5,154,70,2,36,106,143,162,7,132,192,213,34,195,76,66,254,53,65,8,41,104,240,192,213,28,100,140,46,159,114,18,116,35,63,9,66,184,103,126,130,210,201,116,236,22,148,252,60,64,73,250,189,139,60,188,22,90,1,181,104,93,105,164,51,104,14,205,49,250,173,217,38,209,198,7,201,102,120,187,136,245,199,124,219,114,213,185,138,212,71,46,249,157,143,109,120,135,138,101,128,41,94,14,87,252,176,245,219,51,90,244,141,13,31,141,9,223,69,143,34,224,154,38,113,114,231,115,23,216,157,84,130,185,10,92,29,253,250,224,67,78,142,137,137,72,186,222,134,241,72,176,153,254,115,178,8,221,185,136,66,226,44,105,69,199,60,26,198,228,28,163,152,43,22,42,226,217,181,224,247,76,105,153,134,254,137,237,43,69,146,36,128,148,210,188,221,236,201,149,144,157,84,110,175,114,192,154,183,79,82,45,49,244,172,162,27,180,22,50,113,85,36,180,230,198,117,86,100,53,23,204,194,0,167,44,241,149,85,70,152,109,134,215,167,18,73,67,129,211,179,102,173,163,155,221,158,179,4,47,146,56,139,90,237,238,214,22,232,162,213,104,164,239,41,129,54,134,206,208,232,92,82,212,110,153,252,2,127,213,72,77,80,74,114,6,122,198,223,79,53,230,247,191,187,217,102,37,102,130,5,38,251,207,154,50,74,132,139,205,222,216,208,137,234,119,52,253,166,99,78,187,6,237,229,62,173,79,12,171,206,150,241,122,227,24,212,156,203,150,93,107,67,152,248,190,125,166,113,249,31,185,110,13,220,227,174,186,141,110,240,142,135,94,179,55,224,166,47,146,42,186,15,8,179,186,210,32,228,27,224,158,172,7,165,191,117,105,49,251,154,189,107,243,6,110,185,225,252,59,17,109,67,110,194,233,101,194,189,54,232,103,15,138,118,182,109,216,75,157,213,41,231,17,20,77,216,162,58,170,123,225,146,33,37,176,21,209,52,147,151,213,142,18,217,110,115,242,53,147,144,141,223,221,66,69,211,227,3,137,234,95,68,169,123,42,124,203,97,2,173,161,233,233,78,177,14,18,77,241,193,108,90,10,139,9,42,69,181,84,166,154,144,153,161,105,24,55,40,35,159,128,233,20,189,137,236,69,191,79,86,21,235,172,92,21,110,217,20,121,218,42,214,144,170,170,59,226,232,123,197,70,81,153,53,19,91,238,5,198,2,37,57,207,204,22,154,215,203,65,98,109,62,216,84,91,211,22,146,54,143,53,127,86,52,137,205,26,109,158,96,204,232,162,243,122,101,12,170,208,232,179,110,234,186,248,46,103,133,230,227,209,225,238,197,112,119,111,212,217,31,13,183,59,123,251,251,231,157,163,221,139,195,206,224,224,98,103,116,126,112,120,180,189,251,246,169,105,90,124,150,7,107,205,20,30,97,134,234,132,220,67,143,186,114,180,106,70,201,141,255,208,144,183,7,123,135,219,164,122,167,191,253,211,176,179,119,184,179,221,57,218,233,191,237,28,142,250,251,71,163,163,253,253,131,139,131,21,67,198,195,48,9,232,40,26,45,78,179,4,203,83,183,192,228,94,169,245,167,212,37,147,225,172,7,63,88,119,56,99,121,69,53,249,189,248,52,231,10,39,250,18,208,90,11,121,90,209,127,46,37,18,77,98,229,84,58,125,185,94,189,202,51,142,33,7,113,134,65,172,22,207,64,181,108,18,53,164,53,235,91,211,223,196,240,63,74,248,52,193,137,20,243,200,102,120,164,12,207,106,168,120,131,204,147,102,202,29,48,197,50,10,218,235,133,62,159,87,230,245,90,63,17,4,133,162,220,1,213,28,139,93,80,159,113,99,197,186,61,80,122,254,41,53,152,76,97,136,200,72,161,111,55,247,17,247,224,60,142,253,69,166,163,9,69,43,71,2,123,110,86,211,117,11,112,54,108,72,165,210,224,210,61,199,157,67,186,232,244,19,161,155,131,25,226,179,248,184,250,90,181,121,80,62,182,18,229,246,145,66,93,162,178,101,211,158,154,158,71,106,209,247,47,39,5,232,170,33,58,3,223,68,188,111,56,195,179,179,242,241,250,167,167,23,244,136,156,66,207,205,228,159,4,165,185,132,128,124,13,94,206,160,151,114,230,65,111,127,158,51,159,172,216,70,206,216,26,86,38,140,145,207,226,223,202,17,192,158,87,226,74,89,54,21,176,174,178,47,86,194,250,122,51,33,218,5,162,208,220,97,93,223,178,5,113,171,18,171,138,1,237,245,162,83,1,90,215,99,110,80,37,34,148,192,11,158,77,47,246,174,105,49,249,164,71,15,230,47,255,181,160,111,45,16,176,144,110,195,34,3,83,115,102,174,93,138,17,28,248,209,140,48,168,70,200,229,181,20,115,56,10,141,226,46,143,245,117,180,142,6,194,42,88,53,48,143,179,50,93,188,3,191,179,106,217,121,57,3,40,118,178,154,77,160,211,38,127,93,94,231,44,76,86,124,87,58,195,6,156,214,117,97,146,76,199,197,49,13,152,31,198,94,221,252,101,87,203,139,79,127,3,241,41,166,3,41,19,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("0dd28763-79b1-489d-8d59-c59428fa9c10"));
		}

		#endregion

	}

	#endregion

}

