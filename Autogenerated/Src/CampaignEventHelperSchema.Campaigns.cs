﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CampaignEventHelperSchema

	/// <exclude/>
	public class CampaignEventHelperSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CampaignEventHelperSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CampaignEventHelperSchema(CampaignEventHelperSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("d219c98d-c27f-4e2c-8c0d-955b5c514de1");
			Name = "CampaignEventHelper";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("dd426a46-db99-4691-be2c-979c875b4586");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,229,88,89,111,27,55,16,126,86,128,252,7,66,121,89,161,198,186,125,245,5,216,178,156,8,176,157,212,82,208,135,162,8,152,221,145,68,120,181,148,73,174,109,53,240,127,239,240,218,229,94,178,220,2,5,138,190,72,226,49,195,57,190,185,148,211,53,200,13,77,128,204,65,8,42,249,66,197,99,158,47,216,178,16,84,49,158,199,99,186,222,80,182,204,39,143,144,171,79,144,109,64,188,127,247,227,253,187,65,33,89,190,36,179,173,84,176,62,110,172,145,71,150,65,162,25,200,248,35,228,32,88,210,186,115,73,21,109,109,94,179,252,161,218,12,133,18,208,183,31,95,94,116,31,133,122,220,208,60,21,44,203,102,32,30,89,18,240,90,102,252,59,205,142,142,198,124,189,198,123,215,124,185,196,109,60,199,27,31,4,44,145,152,140,51,42,229,17,233,180,5,94,59,60,60,36,39,178,88,175,169,216,158,185,181,33,33,11,46,200,19,23,247,228,137,169,21,1,77,39,137,90,81,69,10,9,41,97,57,73,28,79,25,123,70,135,1,167,77,241,61,99,9,73,12,179,206,231,7,63,140,8,165,168,87,12,178,20,101,253,34,216,35,85,96,15,55,118,65,4,208,148,231,217,150,124,149,32,208,62,185,245,17,249,86,212,214,199,61,84,83,52,14,249,150,225,199,41,193,159,104,82,186,4,129,14,86,218,106,32,162,97,32,218,112,228,216,124,0,180,188,17,174,46,41,190,39,149,40,18,197,133,150,215,104,234,30,182,90,119,232,27,53,4,175,203,61,34,26,152,131,65,67,29,148,182,165,159,190,245,22,69,6,131,151,221,218,220,128,90,241,150,225,155,200,48,27,119,160,10,145,75,146,148,65,66,248,194,88,121,75,20,39,18,95,240,80,97,41,126,177,5,3,97,240,209,6,136,221,217,80,65,215,36,199,96,62,29,122,64,77,211,225,217,215,156,61,20,16,112,209,15,169,21,148,166,141,79,14,13,109,197,74,88,225,206,198,53,225,138,38,35,169,119,173,144,39,135,158,38,4,205,53,147,234,228,99,193,210,51,130,102,189,211,202,205,249,76,81,161,140,105,165,62,143,244,57,169,4,246,254,11,104,161,188,140,174,202,225,41,224,27,89,191,12,102,160,5,117,55,221,226,148,68,246,215,72,211,216,159,81,3,22,35,67,61,208,185,170,88,231,209,16,13,230,183,174,4,95,59,12,148,123,191,173,64,64,52,28,87,230,29,197,83,57,121,40,104,22,89,22,241,23,109,74,80,136,159,64,39,39,165,77,54,209,229,197,228,25,146,2,49,79,210,239,229,207,211,102,4,198,147,92,22,2,46,47,170,173,104,228,205,227,121,77,117,6,213,150,69,191,10,251,117,90,51,67,108,31,0,123,39,170,30,172,88,13,158,86,44,3,18,89,250,88,223,12,30,26,12,88,238,44,59,77,173,146,211,60,133,103,124,199,17,160,111,63,139,148,229,104,4,99,192,99,79,104,92,235,40,107,215,245,65,212,102,89,81,86,46,143,207,211,242,106,121,254,98,191,237,151,253,180,248,11,176,18,6,108,103,8,34,99,29,127,185,162,9,70,217,2,221,109,194,194,187,141,208,34,101,144,99,89,68,253,121,181,114,209,99,30,250,151,226,49,100,229,76,177,131,143,129,108,141,137,143,199,71,142,254,56,79,20,194,149,253,9,230,222,185,83,75,163,221,11,208,12,201,3,18,58,210,3,67,137,173,135,136,57,198,210,189,49,110,110,84,89,237,111,207,121,102,238,92,108,239,32,225,34,157,166,81,248,136,227,127,208,140,3,239,117,244,215,216,121,107,206,141,240,53,161,59,89,89,161,60,135,166,100,179,74,178,57,21,75,80,114,92,8,129,164,90,206,26,67,203,167,79,180,23,52,150,74,86,152,111,170,174,38,158,61,100,227,140,105,87,224,175,201,115,2,27,147,72,161,12,44,93,123,226,137,16,92,92,113,177,166,42,114,224,30,254,30,20,158,248,117,119,253,113,68,134,142,244,39,50,44,239,91,28,28,145,31,63,191,84,224,53,40,247,138,225,217,47,47,100,65,89,38,227,33,26,45,176,91,144,187,156,237,212,74,240,39,2,199,85,200,237,140,173,82,138,50,86,26,66,116,135,26,58,8,107,31,134,163,35,193,0,181,30,49,30,248,143,132,91,139,137,69,207,30,178,88,45,251,67,119,119,4,236,12,91,183,114,1,225,48,232,42,165,244,5,19,67,213,110,249,103,60,111,68,168,121,111,143,40,107,6,153,171,63,211,28,35,199,113,143,236,131,7,250,189,112,223,191,218,82,173,39,240,118,33,112,140,213,70,129,36,104,112,76,84,186,7,119,90,238,145,241,255,135,56,171,245,125,191,106,155,197,221,61,157,131,204,235,72,121,59,26,31,169,168,160,184,119,207,230,250,46,51,73,148,141,194,40,62,151,174,121,11,90,186,46,138,27,42,238,65,97,47,101,150,50,54,52,119,56,16,227,18,190,100,20,95,77,235,12,253,225,43,140,23,52,147,224,232,166,82,163,249,163,224,197,102,39,13,22,14,152,179,53,196,95,85,114,203,159,28,181,133,114,250,57,255,27,180,55,60,213,8,120,141,184,105,5,31,196,122,212,42,181,247,188,46,182,109,213,135,227,57,150,144,161,67,131,105,140,141,232,213,186,214,86,215,203,174,191,60,111,53,218,150,233,155,219,109,199,229,60,79,61,143,91,120,86,182,251,216,197,195,225,49,164,31,197,183,92,225,231,228,25,123,74,233,107,244,171,232,236,156,41,234,83,69,77,247,201,60,184,228,180,159,24,201,75,16,247,139,93,162,190,228,96,52,159,180,92,226,57,180,189,53,210,181,214,106,100,211,184,13,196,120,182,129,132,45,182,183,252,154,39,247,159,176,19,150,126,228,114,13,183,172,104,222,150,142,25,2,13,51,127,149,143,77,155,221,110,23,246,77,198,86,144,161,77,94,93,9,191,63,223,205,87,186,201,215,117,200,202,215,147,250,194,82,181,119,233,138,106,53,54,76,117,44,100,103,19,94,173,72,246,164,189,41,154,169,129,32,119,130,237,108,149,243,60,114,130,108,133,91,97,34,210,0,40,51,11,46,130,84,17,172,76,176,31,120,96,245,4,116,173,172,215,241,17,106,249,182,255,80,130,63,131,246,237,49,229,142,38,179,7,71,238,127,166,142,209,72,238,253,215,132,237,156,122,254,223,104,181,210,8,77,160,122,90,168,141,199,204,207,174,229,124,16,12,88,131,61,134,182,142,206,204,247,238,229,124,210,53,134,244,206,33,125,131,200,121,150,89,245,130,193,227,159,78,30,181,185,31,53,240,235,246,28,18,204,252,29,72,114,123,225,214,203,95,9,166,113,194,224,22,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d219c98d-c27f-4e2c-8c0d-955b5c514de1"));
		}

		#endregion

	}

	#endregion

}

