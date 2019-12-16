﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: GlobalSearchServiceSchema

	/// <exclude/>
	public class GlobalSearchServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public GlobalSearchServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public GlobalSearchServiceSchema(GlobalSearchServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("5a3357c6-df2f-45c6-8cb3-943cc980aa69");
			Name = "GlobalSearchService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6f142301-7a5f-41f6-815b-40f61aa5d442");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,221,25,219,114,219,184,245,89,59,179,255,128,85,102,118,168,137,74,39,219,55,219,146,171,200,118,162,76,34,187,150,210,60,100,58,26,74,132,100,110,40,82,1,64,199,106,214,255,222,115,0,144,4,72,144,150,211,77,167,211,60,196,34,120,112,238,119,38,193,150,242,93,176,162,100,78,25,11,120,186,22,254,56,77,214,209,38,99,129,136,210,196,127,29,167,203,32,158,209,128,173,110,127,254,233,219,207,63,117,50,30,37,27,50,219,115,65,183,39,149,103,184,28,199,116,133,55,185,255,154,38,148,69,171,26,204,187,40,249,82,59,156,82,81,59,155,81,118,23,173,232,251,52,164,113,235,75,127,4,36,239,36,195,237,112,31,233,178,6,48,191,101,52,8,225,160,249,141,63,15,248,103,94,123,15,216,0,61,231,64,118,38,2,65,75,128,113,202,168,127,25,172,68,202,34,106,92,220,72,109,30,31,143,211,237,22,148,251,46,221,108,44,194,83,250,85,128,234,208,12,111,185,41,204,13,229,98,118,27,176,93,121,116,136,197,206,69,250,180,11,111,104,188,163,172,188,131,34,42,102,93,120,204,155,174,247,211,44,178,245,127,30,136,0,136,11,6,170,113,93,120,159,38,17,234,204,212,137,155,220,35,160,200,247,27,33,118,254,104,201,37,53,244,200,18,240,130,177,148,77,146,117,74,6,150,90,192,106,38,191,57,171,126,1,15,40,0,201,51,70,55,128,144,140,227,128,243,99,98,242,165,175,75,176,163,163,35,114,202,179,237,54,96,251,161,126,86,176,132,75,96,248,35,161,201,142,165,247,123,63,191,114,100,220,249,164,17,230,172,252,19,207,70,124,7,241,2,118,217,129,5,151,81,28,137,253,13,253,146,69,140,110,105,34,184,103,62,160,32,32,229,35,87,16,202,215,7,97,15,137,236,178,101,28,173,200,10,69,116,73,72,142,201,171,128,83,253,212,39,147,27,136,149,171,36,222,155,17,1,120,190,73,85,20,42,187,140,104,28,130,206,174,25,6,172,210,83,103,167,30,200,228,61,21,144,49,110,232,46,101,130,50,178,216,218,207,3,165,113,21,88,123,72,48,226,180,114,101,232,245,78,44,140,24,56,227,56,2,25,201,130,21,191,45,152,186,255,147,197,198,25,19,197,21,14,194,129,114,48,61,164,32,50,153,64,36,147,69,12,255,13,8,252,124,31,36,193,134,50,100,16,67,156,50,175,107,18,233,246,78,180,82,104,18,42,189,216,74,186,102,41,80,20,144,58,26,20,229,96,217,122,192,60,221,233,108,168,208,191,58,209,154,120,14,161,200,96,64,146,44,142,123,57,92,199,9,84,87,123,157,129,161,151,208,175,144,248,18,136,183,12,1,71,108,147,161,111,121,221,12,220,28,94,36,170,48,116,251,154,84,231,131,117,222,83,150,235,116,30,212,31,70,69,198,146,70,83,40,176,7,91,47,64,91,230,103,211,81,63,176,184,174,15,141,220,83,23,122,50,242,237,172,8,57,126,70,133,128,183,88,201,196,63,130,56,163,158,205,113,159,88,102,5,66,221,94,51,111,17,184,32,70,24,56,225,60,218,210,52,19,205,108,1,108,143,124,55,83,152,101,181,240,127,207,40,219,107,114,109,204,153,113,98,252,116,251,81,25,71,185,255,144,95,127,37,191,88,78,50,103,123,96,208,246,123,205,83,137,191,219,39,168,6,3,97,207,240,68,147,12,65,231,50,25,35,185,14,7,85,165,62,184,221,168,18,252,150,22,14,139,195,84,128,134,105,168,64,170,185,221,145,220,87,202,38,41,35,183,42,142,34,136,141,32,129,212,121,202,41,37,43,70,215,3,75,63,227,252,130,114,243,238,209,208,47,72,153,53,193,153,6,42,151,237,184,169,188,212,185,76,11,68,238,34,38,50,224,187,13,93,219,187,38,55,110,99,129,156,157,41,88,162,254,121,173,192,3,237,19,26,184,53,29,85,238,62,33,47,145,106,66,114,4,140,211,238,134,61,85,77,212,222,30,5,113,244,47,105,200,194,246,143,88,212,117,157,44,126,135,94,176,124,174,88,207,121,229,173,117,163,217,66,54,102,48,10,24,162,114,166,98,207,69,197,59,88,65,99,20,61,142,101,18,35,34,253,76,19,103,48,152,96,115,132,106,11,129,170,247,214,46,59,78,156,249,12,251,68,108,175,232,61,180,128,25,99,152,95,126,41,243,154,227,53,116,74,124,7,30,69,115,184,50,107,105,197,182,93,242,85,26,58,143,184,206,16,52,148,220,57,243,86,77,6,127,154,38,244,240,20,6,237,209,109,218,216,112,97,70,213,233,19,0,232,46,96,84,63,122,19,101,109,253,40,235,136,78,108,230,81,63,47,185,98,191,163,82,11,207,64,165,211,139,249,108,62,154,158,143,110,206,127,91,188,144,188,150,185,219,71,87,194,162,172,28,235,3,139,188,153,196,225,95,166,108,27,64,92,126,123,241,240,237,229,195,209,66,145,59,83,127,22,72,97,16,174,249,226,11,18,94,136,91,154,44,214,84,64,59,165,27,138,106,213,207,121,243,39,124,10,54,186,98,23,219,157,216,123,138,211,179,252,165,60,132,102,150,219,60,28,1,19,144,17,36,176,116,243,103,52,230,180,89,148,63,69,132,31,39,129,20,32,9,163,181,164,115,23,48,232,93,149,217,203,210,154,59,130,118,101,229,57,240,94,253,240,95,95,204,181,162,53,160,34,4,0,216,111,168,7,57,181,106,168,183,213,52,98,31,40,15,86,142,172,121,241,71,97,248,42,13,247,94,221,207,116,162,105,201,243,254,104,183,3,9,199,48,191,128,101,128,8,247,52,218,94,78,68,6,148,62,60,113,52,65,104,205,34,178,161,172,200,169,47,63,240,38,74,71,250,53,211,63,250,198,44,73,141,169,210,204,10,168,238,72,29,151,32,144,106,81,241,229,237,66,237,156,195,240,0,176,57,9,53,125,234,243,62,81,96,242,108,172,102,187,2,48,231,14,103,175,140,251,243,84,121,165,215,51,149,253,106,183,205,67,91,203,194,237,71,157,240,107,96,154,193,89,182,90,1,47,0,182,6,37,211,190,193,143,150,29,101,53,41,42,119,83,88,208,9,180,47,128,1,239,160,187,242,11,159,184,90,254,14,6,245,114,80,109,55,28,171,148,10,60,219,195,255,214,181,229,61,38,224,241,249,108,97,234,12,94,188,44,94,200,172,156,8,56,251,237,33,87,166,140,105,137,9,142,255,138,81,131,34,248,133,142,245,115,97,130,66,225,26,89,223,18,175,103,59,156,173,93,151,223,221,165,81,8,51,75,225,92,83,168,26,151,44,221,122,117,27,44,171,39,224,127,179,10,12,229,21,16,35,183,60,146,206,77,143,133,30,75,76,41,68,83,248,38,18,19,76,4,53,226,114,159,227,191,3,64,175,231,79,194,19,235,238,36,9,233,61,138,113,129,79,56,162,227,37,40,248,186,153,171,178,233,23,143,89,44,124,160,137,14,252,46,66,220,218,74,254,101,148,132,18,173,119,79,6,195,34,255,125,201,48,218,239,129,131,126,149,235,190,78,204,114,241,193,34,176,142,63,73,128,195,40,72,196,24,232,100,140,78,54,9,12,90,99,136,253,220,112,117,57,115,139,128,18,234,74,243,229,155,231,237,66,63,39,47,93,166,95,166,105,140,169,6,89,126,151,6,225,13,93,165,44,228,56,0,130,79,225,239,113,154,161,131,29,224,10,185,241,240,110,112,23,68,113,176,140,233,77,137,196,101,193,98,128,59,35,47,160,132,52,88,88,94,183,156,218,137,255,212,100,185,81,218,55,1,31,229,183,11,45,41,169,15,108,57,80,64,145,138,32,190,4,66,161,193,65,174,129,74,228,25,232,114,113,255,248,163,197,144,142,55,51,72,79,32,159,147,234,33,118,69,7,186,134,220,113,88,72,255,167,122,80,175,88,163,98,28,14,103,57,155,195,181,176,17,110,54,156,139,59,183,133,92,202,178,43,235,197,61,93,101,130,94,167,69,71,226,153,221,73,94,212,181,68,184,153,63,181,16,12,137,128,51,93,130,149,211,10,80,160,174,94,250,157,209,195,25,244,16,217,136,239,147,85,222,58,244,235,253,119,190,165,66,68,254,199,32,18,94,62,4,145,85,0,173,28,241,46,238,87,116,39,39,29,122,95,12,6,197,2,191,82,164,229,42,49,227,39,229,56,66,239,73,196,243,245,70,129,171,156,48,212,5,45,131,11,165,143,119,195,171,76,71,44,84,80,123,141,234,171,31,94,209,126,168,21,42,249,166,253,206,108,45,204,134,171,56,247,139,85,75,177,178,35,216,29,147,146,253,43,232,200,164,206,148,254,104,88,42,5,66,207,147,86,48,102,44,169,204,9,207,129,123,79,145,118,180,68,169,194,31,38,172,198,95,19,246,112,14,37,174,31,198,159,14,69,121,96,48,89,186,93,173,103,181,122,126,187,185,235,84,188,115,160,253,51,223,217,154,109,21,182,179,247,121,83,164,169,158,88,195,43,51,155,30,205,146,126,37,45,174,106,189,153,18,30,31,99,229,103,137,150,85,195,77,150,232,207,108,58,103,54,44,16,228,9,244,4,193,150,36,193,150,14,186,114,38,83,221,66,119,168,147,174,106,48,78,143,36,156,251,26,87,203,162,11,152,57,196,126,10,71,221,97,190,68,208,175,8,149,239,36,124,59,46,35,9,3,22,89,83,211,53,160,137,213,166,67,189,230,237,56,112,222,235,14,231,240,63,89,71,49,122,88,43,248,26,74,94,119,120,25,49,158,23,12,168,29,208,195,144,53,120,147,86,96,13,129,178,33,31,230,157,59,86,4,107,9,86,173,31,214,6,236,244,40,191,143,8,63,149,169,194,248,196,213,249,244,145,46,161,83,131,140,235,21,131,104,247,250,106,54,135,230,188,58,127,2,168,246,66,115,10,37,56,74,206,196,62,166,22,72,113,234,127,100,1,140,140,97,63,31,234,37,167,237,72,229,151,177,252,211,152,245,177,65,207,38,196,240,162,98,55,82,115,145,90,125,182,214,40,40,105,87,129,172,85,207,249,194,108,237,118,192,210,52,147,199,39,197,161,179,216,2,200,95,84,215,121,88,247,111,213,204,3,26,21,11,254,235,109,4,154,246,92,61,143,163,195,57,184,97,232,91,109,76,81,23,156,204,155,223,136,112,45,172,215,41,112,157,154,144,158,109,163,186,113,44,195,104,117,247,165,45,242,236,106,47,80,42,155,51,167,108,184,133,209,151,221,139,4,192,227,232,124,236,21,134,236,15,26,166,125,44,167,141,21,8,199,159,152,66,14,41,11,43,138,64,237,108,94,91,121,84,38,241,34,121,219,155,156,114,128,247,76,132,149,74,36,233,241,154,3,153,139,128,115,202,237,85,192,105,117,182,29,150,210,235,209,219,212,76,235,68,233,248,212,249,223,169,196,143,42,173,81,237,125,247,134,200,220,17,117,21,15,232,69,40,35,116,94,20,183,129,229,55,86,147,235,174,220,20,42,117,116,53,192,67,245,179,107,139,86,20,173,66,45,231,250,171,36,246,1,85,205,207,211,244,115,169,2,180,253,142,165,184,54,130,78,144,27,230,183,66,246,26,64,16,166,106,245,154,97,139,30,188,33,235,57,104,1,71,0,107,56,75,227,40,92,58,136,43,225,57,80,187,219,194,134,81,122,20,134,55,65,2,73,209,197,35,66,84,204,225,100,213,152,202,201,112,224,26,244,154,232,55,111,113,230,193,103,106,78,129,189,98,251,146,251,177,107,67,229,72,237,181,245,147,107,207,100,11,169,115,236,243,231,142,70,177,49,108,234,67,170,217,72,186,191,207,82,65,130,205,6,122,74,233,184,156,44,247,170,96,255,111,183,136,206,118,43,6,219,96,119,232,106,187,70,165,140,255,95,157,215,39,197,255,49,209,0,215,168,40,168,107,204,67,181,34,163,90,161,188,235,106,213,192,254,175,89,154,1,233,153,6,123,82,219,102,110,71,193,141,10,63,111,109,66,70,5,224,83,27,145,158,185,61,111,232,53,220,108,244,161,129,212,183,191,191,217,248,243,122,141,239,46,128,214,247,101,221,65,140,12,137,15,238,34,140,128,120,180,149,192,164,119,234,10,165,33,217,160,243,240,230,178,229,32,227,185,56,182,63,16,52,234,69,145,179,210,90,101,62,86,167,246,225,195,191,1,23,112,211,215,213,43,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5a3357c6-df2f-45c6-8cb3-943cc980aa69"));
		}

		#endregion

	}

	#endregion

}

