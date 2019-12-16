﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: AdministrationServiceSchema

	/// <exclude/>
	public class AdministrationServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public AdministrationServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public AdministrationServiceSchema(AdministrationServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("260546d8-c216-4a8a-9485-5c95fe4484cf");
			Name = "AdministrationService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("69d1b189-4578-43dc-961e-a0b2ba1c7b4a");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,213,90,91,115,219,182,18,126,86,103,250,31,112,228,23,106,70,165,167,47,125,136,45,119,28,95,82,117,226,216,199,151,250,193,227,201,208,34,34,177,161,72,6,0,29,171,157,252,247,179,139,27,1,144,148,228,38,241,244,248,193,34,128,197,98,119,177,251,237,2,100,145,44,41,175,146,25,37,215,148,177,132,151,31,68,124,84,22,31,178,121,205,18,145,149,197,143,63,252,253,227,15,131,154,103,197,156,92,173,184,160,203,189,160,13,244,121,78,103,72,204,227,55,180,160,44,155,181,104,142,19,145,180,58,175,232,172,102,153,88,117,12,176,199,108,70,207,202,148,230,107,7,227,91,250,176,158,224,16,4,123,148,154,52,116,174,170,203,101,223,8,163,125,253,241,241,235,222,161,147,66,100,34,163,188,151,224,52,153,137,146,245,80,128,58,107,100,194,209,223,132,168,226,195,7,46,88,162,76,14,132,64,186,195,232,28,90,228,40,79,56,127,69,14,211,101,86,100,72,132,52,218,32,146,240,78,55,96,147,37,139,123,236,59,228,213,59,42,96,225,10,232,31,178,28,246,228,146,126,170,51,70,151,180,16,60,114,27,104,86,50,33,27,166,32,85,172,59,210,17,46,82,213,15,121,54,35,85,194,68,150,228,100,134,130,246,201,57,248,91,202,106,181,186,96,101,69,25,154,245,21,185,144,124,212,120,197,112,111,41,185,225,148,129,66,133,242,66,242,190,246,218,202,66,131,221,221,93,178,207,235,229,50,97,171,3,211,177,19,252,185,29,177,157,181,235,78,211,138,4,107,6,77,12,154,193,96,78,133,126,26,48,42,106,214,18,141,252,250,43,137,194,190,9,193,77,198,13,162,79,224,52,53,99,96,81,240,106,206,97,244,110,232,175,52,188,39,9,15,86,31,237,201,53,191,200,255,188,145,161,189,208,99,146,215,212,161,254,162,237,78,139,84,153,222,223,7,152,11,123,85,163,3,135,59,161,140,210,185,159,209,72,9,240,101,11,210,192,140,190,192,154,79,135,30,173,13,223,168,202,25,21,139,50,69,45,148,15,249,14,5,98,97,232,189,161,66,155,125,154,70,111,234,44,37,92,53,47,233,172,100,233,52,53,18,105,122,110,136,65,164,162,206,115,101,217,43,138,240,72,230,14,51,221,53,81,251,82,208,207,68,245,4,250,143,212,248,0,33,182,94,22,209,208,50,24,218,161,83,86,46,97,96,197,113,170,30,111,70,111,23,148,209,104,136,19,226,41,63,249,84,39,121,164,152,197,23,9,3,240,23,148,69,161,82,35,116,41,37,208,158,241,227,64,244,248,228,9,192,91,208,75,154,164,192,33,154,34,192,171,6,73,237,227,136,76,14,140,243,185,182,105,40,32,97,8,37,207,31,232,138,251,202,144,7,158,166,218,63,245,175,14,36,203,238,121,155,237,184,108,63,30,144,0,14,72,71,95,31,58,200,158,10,77,75,10,48,239,100,200,180,85,135,7,1,188,236,196,251,187,146,80,206,187,59,7,132,147,161,224,34,243,224,14,48,127,90,60,150,31,105,164,148,0,235,13,47,206,175,174,135,99,114,195,178,107,186,172,114,116,88,232,133,60,1,17,5,13,227,4,99,242,186,76,87,87,98,149,227,56,48,58,131,129,100,78,109,111,124,203,146,170,162,233,88,26,22,209,154,114,113,90,178,101,34,188,9,170,43,254,157,151,197,152,92,66,189,0,48,64,215,211,73,200,55,161,158,21,130,132,210,69,58,100,88,16,73,126,0,64,166,53,69,194,73,49,207,10,26,31,45,232,236,227,81,82,104,255,179,86,139,134,208,121,150,20,32,134,143,44,198,127,178,15,36,250,15,198,112,124,205,86,224,251,156,70,102,237,49,41,107,65,100,124,87,56,144,58,145,224,195,247,79,63,123,208,218,142,122,15,49,2,102,141,28,106,34,4,228,59,0,137,115,118,187,200,192,46,88,133,69,150,215,134,165,31,19,38,65,79,47,166,20,103,32,128,44,0,84,141,177,194,224,218,159,222,180,200,14,34,45,75,155,3,196,117,5,41,219,145,195,139,186,159,221,104,251,122,151,133,152,207,0,11,232,5,200,252,25,140,244,47,112,217,237,81,1,127,188,120,38,173,7,252,27,19,143,196,180,182,133,15,220,162,119,240,180,1,62,90,243,42,99,210,131,64,140,80,153,78,78,106,187,249,65,72,171,184,144,46,85,73,139,173,219,34,54,140,159,102,180,66,159,25,123,130,24,80,221,223,53,75,59,248,161,227,44,244,22,3,33,198,68,99,67,104,116,15,178,243,163,154,143,206,174,54,31,60,65,71,226,201,178,82,199,144,193,64,176,149,137,60,195,39,110,173,236,163,212,216,138,96,114,21,153,37,98,182,32,81,75,107,66,159,108,96,119,201,67,159,98,221,112,163,93,71,95,107,194,183,141,70,56,42,65,121,144,253,165,0,244,166,200,196,180,184,44,115,250,255,21,149,94,215,80,240,234,125,175,94,126,94,111,185,175,105,175,11,85,227,173,215,172,166,227,32,4,72,139,147,13,67,114,154,228,156,118,123,251,67,89,230,164,79,230,232,187,231,73,204,44,73,207,234,88,214,98,173,10,201,133,166,112,40,155,209,180,102,97,209,62,222,96,117,85,93,250,44,212,210,125,203,66,169,58,251,8,2,99,132,129,8,45,213,141,202,192,242,70,224,81,20,14,138,206,148,70,47,70,121,157,163,171,69,189,75,105,123,129,157,39,19,200,185,78,210,86,147,109,244,66,197,173,230,154,21,225,184,155,151,73,106,251,129,39,63,74,102,139,208,62,163,142,200,86,188,191,109,56,99,101,189,200,242,180,145,230,176,72,81,20,126,84,214,133,24,170,96,221,54,178,201,118,81,173,1,224,27,69,118,87,4,185,77,178,197,216,78,207,81,191,21,252,77,106,36,97,87,211,114,88,111,155,193,225,25,206,239,232,92,83,155,141,187,229,238,146,201,149,126,67,158,246,106,13,18,154,97,135,252,228,231,218,206,37,122,44,65,52,247,128,131,101,217,102,107,153,58,82,116,194,221,113,38,163,2,204,167,15,127,80,141,63,252,9,161,114,64,54,120,112,100,211,125,99,96,19,158,138,197,221,61,153,179,178,174,184,170,204,3,102,145,55,177,65,9,138,87,120,171,43,136,220,101,242,223,154,66,61,160,96,239,36,236,15,2,59,118,9,116,61,13,96,232,2,130,1,217,214,18,241,5,203,208,133,100,67,31,208,167,252,48,255,156,172,184,185,44,32,130,153,203,154,246,252,211,44,135,163,60,143,15,211,52,106,143,30,49,10,168,160,104,110,51,177,176,103,127,30,169,78,121,145,199,50,8,203,235,85,5,40,136,23,5,42,152,7,195,59,125,185,160,16,242,149,110,189,154,166,247,241,157,171,28,244,224,32,18,221,199,83,44,230,149,241,71,189,74,127,71,161,93,193,112,84,94,47,128,72,173,155,220,56,164,140,81,59,35,179,218,210,230,134,91,57,7,160,61,214,106,45,137,193,199,194,9,221,224,239,37,35,244,173,254,40,136,236,9,12,201,165,169,134,41,120,132,160,233,84,208,37,111,204,220,166,83,215,98,18,236,173,224,177,236,240,143,117,47,147,126,254,237,117,228,150,217,198,254,244,98,95,128,188,125,120,27,57,125,99,159,200,111,186,105,97,180,38,111,181,150,123,153,20,181,85,110,234,44,173,215,88,92,183,199,93,90,117,230,17,139,248,29,64,191,38,81,40,128,79,12,109,251,98,182,3,48,58,175,106,237,29,173,123,57,123,200,253,182,161,145,39,122,143,202,239,49,116,23,238,198,120,244,221,35,246,50,216,201,56,193,85,112,55,48,26,170,65,60,45,218,23,196,91,128,230,57,155,39,112,152,72,244,9,192,27,124,239,14,2,10,168,55,92,13,255,227,140,233,12,58,45,170,90,140,198,70,152,193,63,145,228,152,226,59,38,124,11,213,146,163,25,250,238,82,52,249,223,23,65,247,127,247,245,175,105,178,108,45,142,157,95,183,242,47,45,158,167,117,161,82,87,174,239,10,54,113,215,169,39,8,185,134,94,149,3,24,122,50,54,155,181,135,87,2,95,30,22,115,121,92,195,250,2,223,177,124,5,191,179,228,9,60,66,44,54,112,154,194,99,38,15,139,78,5,162,105,127,203,32,77,178,217,34,155,37,185,34,63,151,247,60,156,148,250,87,229,247,94,186,72,69,158,62,84,234,42,80,153,93,31,119,17,64,244,142,168,160,247,71,61,32,208,116,106,5,220,30,124,153,216,90,90,58,136,196,72,152,170,167,24,91,88,21,97,230,26,147,2,200,190,94,161,8,142,21,149,38,95,246,26,92,5,120,76,51,89,54,113,189,117,77,207,196,88,40,54,219,234,41,111,9,247,244,21,94,48,63,126,75,63,136,147,167,138,169,139,106,109,102,167,124,110,198,66,176,236,227,216,251,126,204,205,27,224,255,167,101,158,66,53,156,110,239,235,230,69,193,167,252,154,62,137,53,87,24,96,86,169,194,149,162,140,194,188,100,223,203,141,141,245,156,130,178,178,219,227,90,195,202,230,212,164,122,82,181,49,68,60,231,52,30,183,14,219,21,165,204,41,64,250,220,188,225,204,198,65,27,0,133,160,136,153,202,191,190,165,240,110,66,120,182,232,78,162,121,113,193,109,26,121,182,212,38,49,189,184,200,42,249,60,91,94,153,200,94,92,216,48,171,249,98,255,242,18,2,53,48,227,47,238,161,81,143,28,248,46,211,23,2,1,34,207,184,57,111,190,133,199,253,224,132,137,195,86,66,228,224,95,144,216,119,134,8,101,17,64,150,188,41,45,25,73,31,236,99,11,217,78,10,94,51,122,252,186,233,138,70,158,182,154,157,251,253,0,83,63,19,135,113,240,185,129,6,210,177,3,121,154,171,97,59,248,12,233,141,226,165,173,252,202,0,231,153,133,27,154,129,124,229,155,225,33,150,117,126,141,128,227,7,170,130,223,51,115,172,149,178,212,118,170,187,92,253,227,93,236,74,234,235,242,16,220,124,165,237,44,199,155,47,21,218,31,39,72,10,135,96,253,55,93,64,252,63,209,247,34,84,197,39,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("260546d8-c216-4a8a-9485-5c95fe4484cf"));
		}

		#endregion

	}

	#endregion

}

