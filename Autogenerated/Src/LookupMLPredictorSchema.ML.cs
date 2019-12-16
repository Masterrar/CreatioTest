﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: LookupMLPredictorSchema

	/// <exclude/>
	public class LookupMLPredictorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public LookupMLPredictorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public LookupMLPredictorSchema(LookupMLPredictorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("d33381f2-8dc6-4f47-984a-cfcaba4b8e3f");
			Name = "LookupMLPredictor";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("33c09d4f-db5e-4d77-bac6-f1fd801beedb");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,237,89,221,115,219,54,18,127,86,103,250,63,160,234,67,232,25,29,221,222,163,45,105,198,113,236,156,166,82,207,173,157,188,118,96,17,146,112,161,72,5,32,157,240,92,255,239,183,139,5,72,240,83,114,110,122,79,247,226,196,224,98,177,159,191,253,112,194,247,66,31,248,90,176,7,161,20,215,233,38,11,175,211,100,35,183,185,226,153,76,147,112,181,252,254,187,231,239,191,27,229,90,38,91,118,95,232,76,236,47,27,191,195,149,56,22,107,164,215,225,123,145,8,37,215,45,154,165,76,62,87,135,219,56,125,228,241,197,197,117,186,223,195,43,203,116,187,133,227,234,187,47,14,82,116,127,81,162,239,60,188,73,50,153,73,161,123,9,110,249,58,75,85,15,197,106,25,46,146,76,168,13,152,6,9,128,228,71,37,182,160,32,187,142,185,214,23,108,153,166,159,242,195,106,121,167,68,36,145,147,33,58,63,63,103,83,157,239,247,92,21,115,251,187,165,208,44,54,87,216,70,138,56,98,79,60,206,5,123,44,152,64,65,11,58,213,161,227,113,238,49,57,228,143,177,92,179,53,62,220,245,238,232,217,188,221,148,112,197,15,11,48,60,125,59,40,249,196,51,97,153,128,191,242,125,82,18,140,28,135,146,197,157,74,15,66,161,253,46,216,157,121,222,18,88,89,116,166,208,96,119,60,219,177,103,182,21,217,37,211,248,227,165,147,236,42,150,92,119,210,253,40,146,136,158,164,3,123,222,60,46,53,131,0,203,26,34,149,154,225,55,247,226,63,228,118,119,47,183,137,220,200,53,79,32,188,103,108,140,103,227,203,225,7,110,141,23,46,80,255,12,2,90,68,238,13,251,43,83,130,71,105,18,23,236,131,22,10,196,73,40,236,217,31,121,237,247,75,95,50,157,65,42,173,171,171,11,136,118,246,71,12,63,102,224,206,237,138,39,124,43,20,36,78,134,105,32,84,48,94,45,199,103,71,36,237,243,80,51,2,205,1,176,214,44,85,104,123,205,178,157,96,251,52,18,49,147,81,200,222,22,44,18,27,158,199,25,147,137,132,207,16,146,203,148,71,43,164,120,199,51,206,246,34,219,165,81,88,50,63,111,114,159,154,88,46,127,125,240,249,87,183,42,34,27,28,239,115,25,49,243,204,34,114,193,81,154,204,11,146,87,105,4,49,96,252,253,151,171,86,61,132,9,12,217,171,78,212,213,94,252,80,41,253,58,101,15,148,248,24,3,16,114,79,18,100,200,85,204,98,153,124,130,248,252,34,33,35,141,136,127,149,254,221,239,15,41,111,115,242,158,168,63,128,176,223,164,56,25,222,123,94,36,252,49,6,157,55,49,223,158,174,195,170,193,70,51,174,132,227,53,164,198,99,154,198,116,251,174,188,124,99,69,24,8,223,65,44,83,57,66,248,41,41,188,0,15,74,30,203,127,11,16,152,37,226,75,21,130,233,198,100,192,84,11,64,65,37,54,179,113,171,72,140,207,231,4,253,67,118,58,112,197,247,44,129,150,96,54,174,195,217,120,142,158,199,51,132,89,123,24,78,207,205,13,223,70,173,135,131,6,78,214,249,158,177,103,83,6,26,232,9,184,216,1,167,71,236,185,50,177,108,176,219,56,161,94,29,222,145,191,64,223,41,133,227,132,165,143,255,2,238,115,12,178,202,161,139,228,144,103,152,27,193,13,213,101,42,207,19,35,230,104,41,117,54,173,21,207,185,37,160,67,172,135,240,193,169,245,196,21,160,190,198,4,156,25,151,245,75,17,156,25,29,71,244,234,253,122,39,246,156,105,250,103,102,223,8,233,152,8,55,208,195,240,245,142,5,53,113,152,52,63,146,33,169,140,88,107,243,5,88,211,27,225,173,76,34,98,79,119,222,22,120,43,64,118,33,254,207,138,55,34,113,109,247,82,10,6,38,164,107,31,241,60,32,230,238,10,89,32,188,138,34,98,103,186,129,9,177,176,52,47,230,167,18,89,174,18,107,49,223,229,206,137,214,37,136,97,15,92,65,198,209,65,96,1,134,84,249,21,226,119,66,128,75,210,45,162,9,123,165,227,186,189,208,136,210,208,167,242,138,184,67,248,183,5,138,18,84,82,89,101,209,252,159,115,161,10,27,20,62,155,223,240,220,94,177,228,134,52,132,160,198,100,53,223,73,228,112,161,63,74,45,1,126,128,15,0,137,24,140,139,189,139,143,87,132,6,189,12,126,35,218,192,242,168,197,131,127,6,87,232,110,136,218,250,158,45,133,242,117,37,174,238,57,16,204,134,34,157,235,82,38,185,97,129,147,169,140,87,107,15,203,227,207,63,173,176,246,110,120,149,20,38,216,216,108,110,82,194,72,132,215,61,1,207,202,23,70,0,106,153,76,156,9,173,208,163,166,254,254,221,142,184,37,242,247,101,84,54,194,101,82,134,227,89,87,108,83,132,34,68,155,158,21,111,252,110,18,97,206,140,211,43,136,10,6,176,108,77,12,10,68,48,31,133,248,65,254,34,48,224,222,30,96,152,130,94,65,92,199,105,30,221,36,48,117,9,148,249,234,110,1,4,77,153,189,136,213,101,245,190,82,91,27,185,94,9,131,195,124,15,10,6,227,138,112,60,241,106,190,199,138,132,57,194,134,136,128,5,253,199,94,95,172,150,150,37,244,191,95,11,40,184,248,115,70,35,15,77,116,198,5,211,6,225,60,168,201,63,169,100,176,140,7,204,191,238,56,213,40,122,30,199,116,57,131,92,182,161,212,71,108,4,13,237,3,69,208,108,5,39,117,207,217,232,98,192,197,100,205,215,181,56,80,203,83,198,44,206,15,225,141,82,169,186,77,213,158,131,197,234,210,179,13,151,177,107,8,5,210,93,176,231,159,94,192,160,128,142,34,92,9,173,1,176,186,226,184,83,133,87,86,224,218,244,212,217,207,220,243,39,65,157,123,173,21,75,34,150,31,34,72,8,237,128,129,74,13,128,128,215,249,73,205,118,48,205,193,44,165,203,33,47,59,181,181,161,52,164,150,198,214,47,191,147,105,209,83,61,210,116,193,254,50,124,35,51,197,137,80,3,209,98,60,55,240,99,251,52,250,234,144,104,144,145,209,253,94,224,110,5,252,156,39,235,241,28,127,146,127,77,95,28,87,213,120,163,210,189,111,164,24,66,154,101,41,123,52,253,40,14,175,128,177,246,113,179,109,40,13,182,216,176,233,122,142,241,60,61,95,207,217,223,140,113,61,211,66,143,73,79,124,145,113,76,252,98,227,223,122,11,88,14,201,79,82,101,57,143,217,83,10,69,24,29,93,129,151,110,244,85,67,184,103,109,109,123,47,91,228,155,182,181,95,209,44,211,197,77,2,232,161,176,37,239,102,57,97,221,47,181,236,236,99,103,213,241,30,129,172,70,207,60,105,54,12,62,154,130,81,84,23,110,149,173,51,208,163,229,212,60,168,189,111,121,152,251,97,221,180,22,84,0,75,218,232,98,227,188,86,53,77,175,54,113,86,182,140,187,236,99,194,193,223,166,124,180,221,95,133,128,88,163,91,70,100,63,16,73,137,89,125,124,90,55,131,186,80,47,76,196,90,28,227,226,82,243,86,42,157,253,83,189,163,209,55,112,13,184,139,167,176,190,23,154,181,118,69,53,76,68,197,122,30,108,40,103,0,121,145,108,82,135,199,191,166,62,58,217,12,138,132,205,17,76,223,55,0,200,111,8,161,149,88,167,10,50,52,130,195,159,95,222,140,109,88,143,106,157,127,72,189,109,175,51,171,142,27,129,220,87,163,37,28,132,142,105,153,91,2,190,121,254,59,200,116,154,116,175,18,110,210,29,70,161,47,121,71,123,232,231,123,115,18,194,140,233,24,90,154,16,97,153,187,171,245,89,197,39,14,189,15,164,13,230,58,142,18,221,49,96,101,111,240,135,164,12,54,28,2,246,236,117,69,243,216,6,224,1,151,213,8,232,49,204,63,118,27,18,225,22,7,157,85,225,254,169,101,112,79,104,65,101,173,220,215,181,202,17,197,146,158,67,129,192,33,195,20,8,72,10,186,32,190,2,122,83,213,198,237,102,209,20,101,122,238,174,123,59,2,87,29,204,62,229,65,21,181,149,20,196,167,135,104,102,138,179,130,250,144,252,95,142,100,227,213,210,60,56,254,182,137,172,222,14,95,247,141,75,99,196,242,20,106,209,254,161,56,136,176,106,133,199,181,201,206,191,208,192,237,94,194,214,2,202,215,196,254,65,97,118,124,32,113,150,173,48,220,221,61,134,109,180,68,75,82,232,36,210,28,188,255,88,32,56,204,8,51,198,77,206,174,179,52,89,225,195,82,207,54,205,223,43,160,237,34,47,47,167,24,54,243,1,19,120,107,198,65,62,212,79,248,131,193,117,107,190,107,109,108,7,57,98,180,206,251,189,232,86,221,51,103,157,202,236,63,244,24,2,230,218,38,183,240,230,51,36,143,54,169,17,222,236,15,89,113,214,239,38,76,45,225,176,130,240,60,146,218,110,77,107,169,106,214,172,232,207,76,113,24,9,35,86,136,236,116,63,218,243,114,11,49,180,211,45,255,28,134,189,48,34,7,246,50,174,120,35,188,217,22,213,134,34,149,158,83,65,173,90,182,212,123,110,203,204,46,15,6,123,110,55,165,251,3,66,85,0,135,239,74,220,30,214,54,43,196,197,156,219,142,223,108,74,64,77,50,45,126,160,63,143,237,249,161,13,159,255,31,50,154,67,70,189,134,152,9,195,70,212,85,18,97,237,181,3,235,241,165,32,133,116,199,50,197,34,3,107,123,211,125,251,31,77,33,172,14,195,21,184,215,132,178,69,171,99,197,233,150,202,109,69,66,64,136,27,190,222,5,159,68,97,219,217,185,223,211,213,137,113,117,75,83,143,191,82,116,203,51,187,250,115,156,194,95,132,91,151,143,40,178,189,111,230,167,93,178,157,213,154,190,170,108,181,215,187,158,11,171,149,110,215,26,243,178,187,217,53,53,220,143,218,225,246,118,82,207,30,106,137,143,247,188,40,84,79,235,121,226,198,14,148,239,249,99,132,155,150,251,149,254,134,5,86,115,175,216,177,130,50,187,215,238,235,20,155,88,162,58,9,160,151,206,97,168,0,178,159,250,235,211,93,251,111,137,195,174,97,182,159,196,82,181,3,59,158,48,39,53,171,151,95,183,154,187,9,103,230,78,141,218,222,157,116,44,14,6,122,126,58,173,31,194,217,127,0,134,159,220,76,132,35,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d33381f2-8dc6-4f47-984a-cfcaba4b8e3f"));
		}

		#endregion

	}

	#endregion

}
