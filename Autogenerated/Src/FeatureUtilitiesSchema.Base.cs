﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: FeatureUtilitiesSchema

	/// <exclude/>
	public class FeatureUtilitiesSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public FeatureUtilitiesSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public FeatureUtilitiesSchema(FeatureUtilitiesSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("9b7777f7-6aed-492d-97d7-7b0eb68de435");
			Name = "FeatureUtilities";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("2e3e95a4-2024-4552-b820-30e9633c8933");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,237,90,91,143,219,182,18,126,118,129,254,7,198,231,69,6,12,109,114,30,147,181,129,141,119,55,112,155,52,105,156,180,15,65,80,112,37,106,87,173,76,57,164,180,27,55,240,127,239,12,73,137,164,110,214,110,111,57,192,121,73,86,228,112,56,156,203,55,195,161,57,221,50,185,163,17,35,239,152,16,84,230,73,17,174,114,158,164,215,165,160,69,154,243,111,191,249,242,237,55,147,82,166,252,154,108,246,178,96,219,103,141,111,160,207,50,22,33,177,12,95,48,206,68,26,181,104,94,166,252,147,29,116,247,18,172,111,60,60,127,222,59,117,193,139,180,72,153,236,37,216,20,154,51,204,255,71,176,107,16,142,92,240,114,251,148,92,50,90,148,130,109,10,90,48,169,230,79,78,78,200,169,44,183,91,42,246,75,243,109,168,136,84,100,97,69,117,226,144,237,202,171,44,141,8,3,174,30,83,152,66,149,181,216,122,124,227,84,210,171,140,197,97,77,233,178,158,156,155,105,178,32,143,231,74,200,97,118,140,15,113,187,224,21,179,39,163,152,193,161,225,104,242,166,159,161,165,0,166,255,133,161,131,214,52,227,177,86,182,167,248,85,70,165,172,53,255,190,72,51,101,187,94,229,191,17,249,109,26,51,73,202,138,148,108,89,113,147,199,146,36,185,32,119,185,248,141,220,165,197,13,73,52,199,65,251,160,5,225,191,8,101,232,16,1,109,133,71,170,101,5,47,46,40,47,64,222,55,34,189,85,246,196,249,157,254,32,17,206,3,83,129,62,103,216,201,21,141,110,216,11,145,151,187,31,32,158,64,37,83,111,230,151,47,143,15,211,103,247,224,178,134,144,113,184,172,57,8,75,179,244,119,160,70,94,191,124,121,162,248,41,185,125,149,215,231,120,165,21,214,56,69,167,221,223,50,216,132,75,2,6,45,72,158,0,1,3,9,5,75,22,83,215,175,215,60,201,167,39,75,146,130,112,218,16,197,13,35,167,59,42,232,22,136,9,135,163,47,166,198,36,235,24,72,123,188,71,141,168,101,173,53,203,117,204,32,178,147,148,9,148,4,55,48,147,225,233,137,90,50,200,65,78,151,22,140,144,65,146,151,60,182,110,50,200,67,133,58,44,47,183,28,173,56,93,42,91,26,41,212,36,152,13,103,135,217,208,120,155,242,247,96,177,62,86,138,128,148,64,209,203,79,104,139,44,125,20,82,6,2,226,106,214,117,40,227,229,47,129,226,180,105,180,37,121,193,10,15,246,112,52,120,81,166,181,106,214,241,156,40,72,221,59,250,171,212,54,199,141,38,198,89,27,90,154,87,78,220,113,236,25,81,56,56,209,242,146,32,17,249,182,98,74,82,203,95,17,77,238,110,152,176,214,6,175,69,127,209,204,126,162,89,9,81,181,176,210,234,37,146,161,168,132,179,59,210,60,179,217,122,50,89,229,49,6,100,197,23,52,241,110,191,99,177,195,248,84,159,96,25,76,145,118,58,155,155,149,138,215,145,165,41,47,150,65,67,37,150,193,94,158,85,90,89,199,71,56,161,53,150,65,151,22,53,183,195,44,124,151,163,121,131,153,66,146,195,64,64,175,50,70,133,36,17,226,73,35,140,200,213,190,21,178,17,30,123,124,180,202,188,20,17,248,244,123,9,65,10,64,198,181,187,12,71,133,218,163,246,103,252,242,232,27,110,124,155,131,107,170,83,152,21,10,26,131,226,38,149,4,183,93,213,187,18,45,77,237,134,200,185,242,187,91,42,20,88,125,207,246,160,124,77,16,94,230,98,75,139,160,27,115,231,106,253,220,48,13,87,165,16,0,71,184,99,184,142,181,222,39,102,110,195,164,132,253,213,250,240,103,72,70,47,243,136,102,248,9,187,4,51,152,47,94,139,183,108,155,223,50,101,224,192,72,50,39,188,204,178,227,54,172,64,185,142,23,11,140,95,167,9,59,129,203,74,61,140,91,10,139,44,74,61,223,99,40,62,196,222,91,202,233,53,28,106,81,217,80,163,218,6,172,180,165,175,244,36,198,223,90,101,249,8,118,194,24,11,170,68,55,53,70,70,86,76,173,4,78,134,103,184,18,64,196,52,195,64,179,55,228,105,66,2,77,30,94,178,34,186,185,4,164,59,127,30,32,48,157,167,74,110,48,133,193,153,57,201,175,126,133,195,44,43,136,250,162,113,71,251,222,65,141,29,102,213,153,42,240,52,220,219,176,168,5,56,184,64,139,202,12,47,182,187,98,239,122,89,151,198,47,62,23,130,70,149,214,215,113,48,94,217,85,136,180,130,84,17,89,45,214,144,109,77,210,178,179,179,196,28,161,94,53,112,2,5,18,27,154,48,8,181,26,103,221,60,208,119,154,102,226,3,16,215,105,109,78,174,242,60,195,210,230,44,203,112,177,116,93,75,42,31,186,183,103,117,138,230,249,153,252,4,76,209,87,92,142,63,150,76,128,151,169,191,13,49,16,134,103,113,12,178,105,18,237,5,210,36,132,201,186,181,252,50,205,10,38,84,49,105,142,171,71,96,59,228,165,253,89,15,33,130,189,193,88,102,240,33,3,61,184,202,183,16,223,169,204,57,166,171,240,226,83,73,51,147,220,234,128,153,91,77,58,98,234,245,18,197,13,188,173,157,128,121,212,161,231,225,67,72,90,254,101,7,152,76,221,244,60,29,198,252,214,153,106,73,102,110,252,41,107,126,134,28,253,54,191,147,70,70,240,136,102,97,213,129,29,213,34,184,187,150,224,141,80,234,60,174,85,226,97,145,118,136,1,40,154,24,164,128,160,56,103,137,3,20,181,159,56,20,206,116,48,245,203,149,163,26,233,102,82,67,73,135,99,76,236,49,81,135,154,131,167,64,240,8,6,32,66,2,21,111,160,99,39,100,176,98,172,25,212,202,105,16,245,201,163,131,110,174,195,188,18,167,181,150,222,178,192,149,231,48,246,138,165,110,154,247,72,230,250,54,241,63,144,199,181,230,241,34,85,223,194,188,44,238,93,177,17,71,27,55,141,135,164,240,200,250,155,5,91,199,9,109,216,120,148,11,93,88,53,242,102,0,66,205,60,43,87,173,149,102,224,70,205,59,252,177,130,81,95,127,142,227,187,98,140,248,53,146,175,91,136,70,93,177,87,51,85,61,46,171,163,225,146,212,63,159,3,62,150,213,7,79,212,143,4,76,135,54,85,163,177,10,168,166,122,157,169,166,62,205,229,108,65,130,141,250,107,134,25,78,255,89,33,22,220,104,118,193,19,115,193,153,132,58,112,251,50,230,156,248,193,108,150,133,88,107,245,102,89,67,179,6,223,19,223,229,41,119,10,189,240,181,243,5,204,1,178,102,225,90,170,28,113,92,6,164,110,51,247,32,148,191,205,179,106,159,142,9,224,229,142,226,152,101,58,25,33,73,3,175,43,113,126,198,123,180,119,50,125,173,173,57,106,53,135,117,178,212,229,87,189,241,25,143,199,200,235,169,171,205,210,247,219,74,182,215,34,102,226,249,254,156,201,104,180,153,173,207,223,234,54,128,241,172,240,226,51,139,202,130,109,192,199,169,208,55,113,67,220,239,209,11,205,196,171,53,237,200,152,251,24,205,50,31,198,229,95,14,214,21,194,190,52,253,56,167,125,213,15,190,29,247,12,84,73,171,245,51,128,200,46,8,15,22,165,189,245,175,53,222,212,175,89,171,208,86,221,176,238,41,237,165,214,218,78,87,197,148,82,14,241,135,78,231,121,106,62,62,134,93,46,228,48,244,28,177,167,108,253,211,21,242,49,25,63,180,131,236,105,27,17,188,161,143,161,95,180,154,58,166,179,78,115,147,133,237,233,141,44,74,113,21,120,92,153,21,198,11,122,220,171,82,158,87,184,153,98,21,234,53,187,177,45,216,108,210,71,97,116,21,57,162,43,103,106,182,250,174,54,188,184,217,151,11,157,156,167,146,158,62,28,62,117,21,52,229,242,123,182,55,48,88,55,14,33,66,139,148,87,88,97,18,219,196,172,67,7,49,173,34,167,162,244,110,225,154,114,52,174,164,216,180,164,87,121,89,184,16,3,120,195,99,236,223,165,226,129,104,227,52,243,253,160,87,173,124,115,87,237,199,32,236,165,98,157,130,190,163,165,235,151,108,8,158,220,198,116,179,39,173,219,209,227,112,201,115,202,22,211,96,236,181,250,158,8,102,218,46,106,177,113,168,181,60,203,238,232,94,110,170,50,167,16,149,175,12,0,219,120,56,68,104,18,233,78,89,170,155,226,85,30,99,103,45,126,205,177,200,104,3,218,223,2,162,200,180,209,164,190,63,99,23,196,66,44,36,254,12,84,169,18,182,158,51,23,232,165,115,127,30,143,77,46,50,156,101,89,144,144,197,146,36,32,33,121,180,232,239,192,57,152,225,117,188,48,160,23,238,227,132,247,46,49,153,168,150,88,47,215,121,77,103,174,13,99,160,82,251,147,93,186,186,47,202,218,165,142,255,141,228,224,121,172,101,100,95,156,128,79,231,67,84,191,14,28,35,205,73,19,206,237,22,147,134,71,134,206,187,9,160,239,179,234,47,199,50,225,89,84,148,248,164,202,188,235,170,223,74,241,224,222,89,92,207,31,220,220,240,16,244,223,176,162,209,21,248,215,175,254,173,39,209,233,242,7,240,97,95,200,225,199,88,219,215,155,46,215,9,137,89,146,114,22,19,42,21,72,154,252,125,151,66,154,187,98,164,220,197,240,25,171,7,101,204,124,37,174,243,222,134,188,68,162,187,190,15,235,50,184,173,94,109,185,102,191,23,31,233,104,38,235,148,227,183,138,97,182,213,49,175,182,113,122,216,131,61,233,138,222,233,63,155,222,179,219,14,61,254,196,167,42,211,250,39,27,0,92,105,65,226,28,210,50,207,11,221,39,83,9,90,254,223,193,30,228,96,218,132,95,177,147,97,170,114,214,44,156,87,31,91,107,155,139,129,190,197,104,98,83,182,234,127,55,186,21,165,87,25,80,187,175,32,135,127,216,231,107,119,254,170,28,153,171,159,121,84,244,248,53,76,31,59,201,178,94,230,12,134,71,28,212,183,233,104,215,52,31,220,253,229,134,179,235,215,241,146,250,232,111,122,74,125,240,203,136,195,244,8,165,42,192,230,74,191,71,40,221,106,105,238,217,160,177,174,231,81,162,59,66,110,88,244,155,196,190,109,133,166,195,63,12,252,231,31,20,214,45,209,72,146,209,235,193,187,163,194,79,244,52,105,246,48,191,103,124,200,227,66,226,190,40,117,188,72,107,192,234,125,144,54,235,22,29,239,10,70,40,23,197,26,15,71,93,191,145,60,252,1,203,219,159,142,129,43,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("9b7777f7-6aed-492d-97d7-7b0eb68de435"));
		}

		#endregion

	}

	#endregion

}

