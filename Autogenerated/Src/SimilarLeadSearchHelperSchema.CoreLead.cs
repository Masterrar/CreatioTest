﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SimilarLeadSearchHelperSchema

	/// <exclude/>
	public class SimilarLeadSearchHelperSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SimilarLeadSearchHelperSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SimilarLeadSearchHelperSchema(SimilarLeadSearchHelperSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("c99d36c3-7d33-4c15-89ba-167443093862");
			Name = "SimilarLeadSearchHelper";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("555d4b37-c88a-4293-9442-4a20aed79dca");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,221,90,91,79,220,70,20,126,222,74,253,15,83,247,161,70,90,153,60,23,88,137,46,144,174,26,34,194,146,166,82,20,69,131,125,22,166,245,101,153,177,137,86,17,255,189,103,110,222,241,21,179,44,144,228,5,180,158,51,231,126,190,51,62,158,148,38,32,150,52,4,114,1,156,83,145,45,242,96,154,165,11,118,85,112,154,179,44,37,95,127,254,105,84,8,150,94,145,249,74,228,144,236,213,126,35,121,28,67,40,105,69,240,26,82,224,44,108,208,188,97,233,77,227,225,63,73,188,126,230,138,231,208,245,60,56,78,115,150,51,16,72,128,36,191,114,184,146,58,78,99,42,196,239,100,206,18,22,83,254,6,104,52,7,202,195,235,63,33,94,2,87,164,187,187,187,100,95,20,73,66,249,106,98,126,207,146,101,12,9,164,57,17,138,156,100,11,18,21,203,152,133,52,7,17,216,93,187,206,182,101,113,137,203,36,148,2,187,228,73,151,33,105,169,221,9,131,56,66,245,206,56,187,69,198,122,113,169,127,144,247,2,56,58,60,213,30,36,159,139,202,239,189,42,241,17,88,245,112,77,139,36,159,163,230,67,179,237,87,72,35,173,67,85,161,83,200,175,179,78,141,222,48,145,239,191,46,88,52,33,175,33,151,198,137,119,5,141,217,130,65,164,220,191,154,69,194,119,168,98,36,193,71,99,34,114,46,67,38,194,107,72,232,91,204,172,29,149,61,163,145,67,28,102,105,78,195,28,233,201,1,73,225,139,35,206,223,217,83,212,108,65,124,195,19,131,94,96,120,38,228,149,101,53,50,66,64,105,130,185,87,36,169,20,133,220,244,74,112,146,241,132,230,190,87,42,253,245,213,157,55,118,181,210,98,70,183,148,43,221,143,197,141,209,69,155,55,87,148,239,10,224,43,191,22,143,192,165,56,165,41,189,2,62,38,158,116,146,103,217,26,150,1,58,87,102,141,226,163,245,12,102,226,48,254,66,87,98,14,178,98,80,104,206,11,168,109,59,140,34,77,237,215,77,180,2,178,203,127,113,247,199,79,132,93,165,88,19,145,202,191,156,230,133,117,105,73,240,149,200,53,84,95,228,34,56,98,226,198,186,228,253,44,26,187,107,111,179,124,150,230,192,1,11,83,45,106,73,35,135,100,142,249,37,204,94,114,87,83,250,132,197,184,91,72,229,125,251,108,202,1,211,73,175,124,96,249,245,25,229,104,132,36,243,245,195,105,150,44,41,103,34,75,47,86,75,144,58,28,75,5,209,159,58,116,43,109,148,103,149,105,152,187,83,119,121,183,26,51,129,236,223,22,113,172,73,154,190,109,56,87,67,130,206,83,155,141,58,110,62,139,200,193,132,248,154,116,135,69,59,193,69,118,136,48,181,242,135,43,52,220,47,214,41,179,72,102,177,213,202,58,101,65,99,177,214,94,166,116,89,97,88,8,210,87,70,127,41,26,235,249,216,26,110,48,187,158,225,150,147,41,179,91,26,23,208,87,101,88,92,74,177,174,100,173,212,123,93,53,235,80,189,25,157,106,140,210,191,165,186,210,3,166,30,254,150,170,24,164,168,169,181,35,35,32,129,196,6,224,78,253,229,144,23,60,117,32,71,45,222,85,225,238,54,195,112,150,69,39,78,120,150,156,210,60,188,70,35,253,6,30,16,16,55,99,139,251,26,107,177,139,41,122,34,218,158,34,23,139,92,58,54,74,136,93,146,238,236,216,21,28,59,14,213,138,143,22,152,254,20,37,249,127,193,74,121,227,140,50,190,175,3,210,161,85,112,94,196,48,33,28,255,18,150,214,229,151,160,10,21,224,145,212,1,202,112,157,121,215,217,36,78,88,170,107,82,203,159,106,111,11,95,174,154,202,105,233,3,198,238,115,8,51,222,211,11,218,93,45,185,94,100,70,146,227,52,100,99,90,86,219,234,16,158,114,111,43,67,231,97,201,168,53,61,182,216,74,58,178,82,229,96,151,11,6,111,173,25,101,246,85,19,97,221,67,141,32,175,98,185,226,132,246,130,11,45,117,59,199,54,7,170,205,157,252,130,126,66,60,46,83,16,117,57,202,194,66,29,199,76,197,234,8,169,76,23,196,64,195,65,235,129,199,128,42,242,168,4,87,109,85,226,198,247,248,171,34,62,46,15,116,219,145,221,235,241,206,195,81,171,44,89,108,70,140,113,183,103,67,99,29,61,110,115,95,139,48,211,212,30,32,73,229,230,90,76,221,77,29,50,196,212,181,170,231,72,89,158,35,189,90,182,57,77,68,38,231,57,77,175,180,103,29,214,101,223,170,227,138,179,23,79,64,57,75,177,223,212,219,197,72,97,213,77,45,217,77,227,236,105,67,141,250,152,173,143,129,85,69,130,115,72,178,91,240,235,50,218,250,85,117,103,91,207,234,70,223,195,48,148,39,230,103,64,95,35,169,3,125,155,171,63,32,250,54,141,124,34,244,53,130,158,9,125,169,150,230,150,246,118,0,176,211,95,189,232,251,92,224,107,204,126,24,36,218,200,172,81,177,197,123,47,9,190,135,174,85,131,192,183,150,108,163,181,95,106,224,187,102,221,9,190,206,222,161,224,107,184,62,4,124,75,69,134,130,175,217,176,109,240,85,190,125,122,228,253,206,80,178,189,242,158,24,195,196,179,29,223,26,1,221,176,160,69,179,152,7,38,230,128,49,95,150,163,43,33,178,137,108,126,146,91,198,115,172,137,142,23,218,222,87,41,231,165,54,89,39,162,204,170,86,102,54,29,45,109,48,207,10,30,194,188,28,202,225,102,237,145,26,221,17,72,216,208,174,172,16,219,51,226,94,169,135,59,130,176,149,117,196,84,10,81,190,26,242,158,108,181,172,112,250,88,138,250,212,103,161,226,96,83,177,50,49,241,228,127,59,197,106,55,66,135,187,85,248,113,66,89,188,185,232,34,185,4,222,43,124,154,37,73,145,154,116,181,148,18,115,103,178,50,37,42,5,103,148,11,240,43,132,146,192,76,6,149,134,88,158,61,70,252,33,135,249,32,206,174,179,20,54,182,69,19,62,135,69,31,50,254,159,210,181,223,170,211,236,146,197,240,189,24,229,104,219,111,214,7,184,20,44,223,220,164,103,137,16,92,246,27,49,197,31,27,91,48,85,135,162,94,11,176,239,113,16,162,175,114,213,183,11,254,8,45,244,254,13,20,41,209,243,184,6,137,208,28,42,154,246,98,183,84,79,60,15,108,20,109,111,125,47,222,40,236,121,246,25,26,133,21,181,253,70,97,57,191,72,163,48,194,127,160,70,177,45,139,190,169,70,177,45,163,190,137,70,177,181,8,189,88,163,48,22,188,124,163,232,81,228,101,26,69,245,61,245,197,27,132,67,252,77,191,70,148,131,254,182,32,43,35,122,114,236,177,173,169,28,116,109,34,252,113,173,73,239,222,72,240,86,218,73,133,201,70,106,108,3,255,93,30,27,41,241,88,180,182,251,55,18,254,100,40,123,175,224,167,197,214,251,196,171,115,49,118,163,141,229,91,6,131,21,216,18,164,119,13,149,84,91,229,69,152,103,92,78,150,212,117,56,77,81,191,97,167,30,56,228,65,73,180,91,167,218,95,202,59,48,36,69,155,14,188,234,240,207,155,204,144,3,77,67,144,183,243,246,5,0,9,57,44,14,188,234,197,57,111,119,18,236,239,42,54,237,92,91,134,114,157,172,91,174,217,213,249,155,123,128,29,55,0,253,218,173,190,250,60,179,237,30,95,139,130,182,53,214,230,161,24,203,198,45,65,73,213,194,1,73,219,175,7,62,96,120,120,95,136,207,128,47,50,158,8,123,137,82,205,102,205,180,146,112,51,129,31,24,251,245,37,61,111,162,243,92,45,244,135,86,79,80,189,137,140,194,111,130,224,41,240,166,0,194,34,153,240,11,6,188,185,91,231,189,152,172,175,65,201,12,104,108,20,184,211,146,58,65,239,254,0,96,134,179,126,227,34,228,152,108,229,171,128,28,125,11,167,252,157,67,193,250,126,100,157,85,215,253,156,202,80,253,142,64,44,208,246,166,128,242,115,208,80,1,229,39,232,129,2,244,215,132,161,220,245,55,150,42,107,23,203,134,141,201,205,179,106,242,171,103,255,3,199,100,98,179,17,45,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c99d36c3-7d33-4c15-89ba-167443093862"));
		}

		#endregion

	}

	#endregion

}
