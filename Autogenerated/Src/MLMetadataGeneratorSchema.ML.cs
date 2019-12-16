﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: MLMetadataGeneratorSchema

	/// <exclude/>
	public class MLMetadataGeneratorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public MLMetadataGeneratorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public MLMetadataGeneratorSchema(MLMetadataGeneratorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("da1fafd2-deac-4a0e-9d03-510a2ec0d5d6");
			Name = "MLMetadataGenerator";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("cad98641-0ee5-4173-9c03-6ef86b0857c5");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,237,27,105,111,219,56,246,115,6,152,255,192,104,23,93,27,19,40,51,95,19,91,65,154,163,112,145,163,219,164,51,31,22,139,130,145,104,91,83,29,174,72,37,245,102,252,223,247,241,146,72,138,146,147,54,221,221,1,22,40,90,139,124,143,239,224,59,73,182,192,57,161,43,28,19,116,75,170,10,211,114,206,194,147,178,152,167,139,186,194,44,45,139,240,242,226,199,31,30,127,252,97,167,166,105,177,64,55,107,202,72,126,232,124,3,74,150,145,152,195,211,240,13,41,72,149,198,29,152,139,180,248,220,14,158,148,121,94,22,238,119,248,150,218,131,21,9,207,10,150,178,148,208,118,248,138,60,48,160,196,121,229,240,206,202,166,32,128,126,250,186,119,234,28,199,172,172,228,210,0,243,151,138,44,64,2,52,43,24,169,230,160,147,3,52,187,188,184,36,12,39,152,97,33,22,6,120,1,187,191,191,143,38,180,206,115,92,173,35,245,173,32,8,69,184,72,208,61,206,210,68,124,93,94,160,188,76,72,134,114,181,20,186,91,35,74,184,194,208,231,154,84,235,80,47,184,111,172,184,170,239,178,52,70,169,102,166,135,151,157,71,193,79,195,60,128,44,203,132,30,160,119,2,95,78,186,220,58,236,178,37,105,120,11,27,248,125,23,97,178,194,21,206,81,1,38,51,13,36,255,65,116,11,184,242,119,56,217,23,0,126,248,85,69,18,50,79,11,146,104,33,36,110,59,222,178,48,184,80,89,179,85,205,192,224,234,188,184,130,145,32,226,127,163,114,46,196,144,179,40,22,211,195,11,205,211,44,147,203,208,89,49,47,131,104,86,36,105,44,20,146,206,81,202,16,93,150,117,150,160,59,130,56,40,48,152,2,88,149,11,183,64,248,14,72,33,130,227,165,34,134,42,194,192,150,238,1,110,94,149,185,38,201,153,138,203,170,2,47,43,97,125,48,66,26,47,73,142,67,52,11,73,8,187,66,96,190,34,243,105,112,201,109,228,70,76,74,182,194,19,188,226,180,130,253,104,175,221,197,1,248,247,100,78,42,82,196,68,142,10,237,236,71,136,176,184,171,9,224,182,174,10,26,105,43,72,132,209,230,164,90,240,157,176,204,21,144,53,52,71,55,232,234,173,108,108,73,15,140,110,164,121,75,203,216,67,20,84,3,162,119,141,0,77,81,16,8,233,118,20,140,187,191,18,2,221,149,101,134,156,45,131,169,57,206,40,25,31,42,31,32,69,34,221,64,124,111,164,87,219,131,218,79,78,50,76,193,75,254,123,254,253,143,83,50,199,117,198,94,167,194,44,70,108,189,34,229,124,228,243,242,241,248,159,109,64,136,57,227,62,190,81,95,184,114,67,4,196,119,202,112,193,120,144,168,210,123,144,65,206,175,228,7,152,43,204,235,45,251,80,124,42,202,135,226,22,184,227,59,49,153,160,90,142,160,40,10,14,123,209,174,234,156,39,1,141,166,62,7,16,94,195,254,18,220,208,81,159,3,8,167,48,114,155,230,68,99,232,239,1,148,91,242,133,105,112,254,59,240,219,77,163,168,243,148,100,73,159,150,64,133,12,182,163,34,56,41,139,108,141,78,83,145,255,96,119,39,156,134,182,249,8,125,228,59,123,137,87,43,206,194,20,21,228,161,31,246,81,120,194,35,82,198,240,166,78,147,241,30,10,46,202,242,83,189,10,208,102,207,158,151,104,0,209,72,230,66,64,250,128,105,115,55,92,136,164,4,187,34,91,128,230,89,137,183,46,68,226,52,199,217,22,40,238,199,0,98,110,183,11,162,119,18,192,172,77,222,112,176,141,181,189,141,246,69,120,248,152,46,10,200,235,134,201,210,45,59,44,92,161,170,121,25,240,148,148,57,43,160,18,1,191,255,23,143,1,98,39,83,225,74,113,147,127,204,248,220,245,69,30,141,133,255,62,53,203,118,5,10,34,72,78,148,48,196,74,52,137,35,96,158,76,246,227,168,241,74,174,67,138,30,202,226,111,12,129,134,19,14,71,190,196,68,100,18,43,13,168,120,226,97,83,108,18,234,210,110,226,173,178,83,143,190,1,196,187,9,59,42,26,247,238,68,91,183,248,156,77,212,128,107,51,217,161,247,132,150,217,61,49,199,70,127,231,209,86,254,62,251,2,201,134,82,190,52,105,126,74,67,219,49,220,79,122,208,158,69,32,66,12,131,75,28,103,41,166,132,106,97,233,67,202,32,217,143,218,213,194,150,6,23,83,3,238,196,128,134,188,172,112,176,240,166,172,171,152,200,41,65,227,64,35,238,152,92,168,58,1,20,122,14,25,66,142,93,207,149,160,134,72,54,179,135,158,149,148,194,84,153,50,85,11,31,133,42,147,134,124,253,215,138,215,95,113,86,19,158,118,77,57,59,28,55,100,100,93,160,150,86,131,155,167,105,161,190,147,53,194,129,90,106,235,166,80,141,113,107,8,12,226,188,33,114,68,194,81,139,113,141,226,50,236,51,30,31,158,161,163,138,178,17,68,36,47,23,122,249,45,50,159,215,133,144,81,139,12,158,108,82,213,211,40,165,232,120,177,0,199,16,165,166,88,175,153,195,237,132,30,107,12,111,80,60,15,162,97,192,61,102,180,177,213,86,212,89,166,166,18,89,189,28,244,1,108,12,159,119,82,166,202,198,138,73,91,71,127,86,23,246,155,151,11,38,36,220,230,187,127,6,199,113,54,109,187,235,92,87,170,220,125,105,31,178,249,210,179,18,245,37,212,45,42,4,77,204,99,64,98,94,68,77,195,13,197,154,80,122,161,143,7,214,144,42,145,58,195,162,4,51,70,181,84,70,33,117,104,97,200,114,167,3,111,84,85,13,188,227,168,13,172,145,160,29,111,247,187,118,7,254,201,30,110,186,129,216,18,79,154,107,90,196,184,105,252,180,62,239,113,5,141,99,185,34,21,91,171,234,189,155,193,44,19,131,53,208,52,226,75,133,78,86,67,211,169,73,225,40,20,51,173,76,60,34,239,142,44,106,16,140,121,84,27,163,87,175,172,82,62,188,173,214,224,65,98,1,11,99,143,183,176,90,28,3,97,220,24,136,210,168,49,103,104,180,79,223,79,209,180,199,252,255,195,241,180,147,147,132,185,242,50,254,52,157,207,237,84,166,237,87,131,224,11,82,44,216,114,24,136,188,195,21,27,0,25,90,163,223,173,4,234,73,93,85,164,96,186,231,216,194,199,113,146,12,83,49,123,23,139,76,89,196,120,72,4,8,161,114,15,6,96,110,171,52,31,152,254,176,2,115,28,102,79,183,140,54,107,56,35,52,118,68,143,213,168,63,228,58,169,64,3,27,153,213,151,2,122,35,241,214,194,167,135,141,227,110,121,35,248,105,208,6,104,206,232,21,120,184,77,46,21,99,154,22,143,65,224,8,241,39,91,90,8,69,126,45,72,236,240,196,70,233,41,178,120,208,241,44,30,74,182,174,171,179,124,197,214,163,49,250,227,15,63,15,83,51,86,244,22,131,126,14,223,147,85,134,99,146,131,221,63,183,24,244,240,98,217,18,166,142,145,195,48,211,31,106,169,135,37,41,250,163,170,137,16,242,245,132,90,154,144,221,27,104,29,11,233,196,217,23,200,112,86,10,243,52,104,223,51,236,114,123,49,199,45,157,117,218,54,1,132,142,142,148,162,66,97,77,82,117,158,60,220,73,82,114,216,204,79,29,242,39,101,13,165,14,152,225,47,157,12,103,130,9,254,154,78,202,147,241,154,230,225,185,69,69,91,91,127,79,181,243,24,240,13,61,185,165,79,174,45,46,46,58,178,14,88,15,122,75,38,93,37,109,239,202,159,162,188,190,96,249,156,174,243,37,10,7,95,79,106,240,208,109,201,156,201,27,160,40,58,13,48,192,131,173,96,199,247,139,237,64,55,117,254,180,106,193,143,126,137,191,108,167,113,153,246,180,47,126,163,254,154,206,253,219,35,220,214,141,117,219,71,235,202,167,217,105,213,11,242,92,113,92,45,106,158,104,120,226,25,241,243,77,126,130,45,161,21,219,162,173,105,47,175,32,1,150,76,102,63,97,142,82,61,94,199,30,243,130,223,116,142,102,145,80,172,98,101,82,73,204,148,230,18,23,120,65,42,68,104,206,219,11,201,244,7,74,42,40,214,10,162,84,222,133,63,108,3,131,195,26,85,39,253,23,41,101,19,47,243,17,122,212,132,58,114,169,76,27,202,82,81,41,41,124,91,166,80,75,73,53,143,126,135,15,46,51,255,183,179,192,56,252,109,73,42,50,242,169,114,236,196,35,151,113,69,250,182,108,13,96,228,2,113,194,238,88,216,38,26,119,166,101,99,79,55,210,158,5,65,247,226,40,114,166,142,212,95,175,197,57,228,192,106,227,161,136,119,95,166,9,58,94,173,178,245,187,206,173,227,200,119,135,169,111,239,6,110,43,205,12,188,219,157,54,77,237,183,101,202,200,13,127,89,49,114,115,170,153,250,222,94,223,253,206,189,38,174,41,43,115,190,16,111,132,36,4,171,214,77,240,179,166,193,182,20,94,8,221,16,229,237,103,135,83,69,4,138,46,17,105,207,244,21,64,195,11,183,218,28,84,10,118,12,235,253,53,56,17,36,218,59,204,37,108,230,67,85,130,30,228,165,247,1,122,60,43,238,83,24,225,62,28,94,145,135,11,32,184,121,236,210,222,4,42,8,177,101,85,62,8,55,56,23,75,52,76,140,20,225,177,91,87,216,114,90,133,141,186,248,15,100,233,194,185,151,3,173,118,155,251,234,107,249,8,0,180,196,95,135,156,18,240,99,121,107,51,49,246,93,2,69,35,185,10,216,251,141,216,245,209,248,89,76,165,5,32,83,131,169,22,120,38,166,90,246,68,40,48,24,16,243,145,66,144,192,192,178,139,175,60,153,149,159,136,240,146,93,241,75,22,83,19,30,47,163,145,186,37,10,198,99,229,93,58,70,128,5,230,28,103,72,13,146,11,1,106,234,96,12,31,156,97,29,44,91,229,58,156,202,207,173,217,68,120,227,37,127,93,240,68,31,236,209,22,174,89,217,60,89,80,26,54,234,179,84,51,231,176,219,6,234,82,219,134,99,45,45,4,249,2,164,65,11,51,80,137,184,207,146,251,224,232,84,40,76,4,33,21,48,63,20,220,176,7,128,79,83,10,189,214,90,6,46,71,189,220,204,20,103,187,83,117,222,164,204,198,98,39,60,78,18,109,177,98,161,195,45,64,38,81,211,174,185,160,56,73,82,17,225,51,45,170,71,187,202,254,248,204,194,154,1,185,36,237,93,155,56,228,44,134,33,81,121,80,66,35,104,239,40,77,1,175,239,113,177,0,10,54,55,67,161,125,118,86,240,154,140,23,31,30,19,1,231,20,131,146,127,231,37,202,55,20,173,58,97,218,167,219,106,167,245,229,90,36,194,157,203,148,222,75,245,158,69,117,98,118,127,175,158,44,201,74,30,250,2,245,221,41,9,161,73,48,65,149,68,131,167,17,18,222,41,20,165,49,120,213,44,156,85,148,108,230,45,174,251,166,103,200,127,77,159,108,147,76,112,130,249,181,52,55,12,254,138,42,198,89,182,70,9,97,164,202,33,127,136,62,157,39,27,163,142,27,209,49,228,157,159,55,33,10,208,79,200,147,127,208,79,82,254,0,181,15,153,196,155,27,64,251,69,39,34,145,174,61,151,213,86,46,84,23,232,179,158,8,162,252,32,85,166,47,163,66,232,59,128,113,131,176,141,33,92,192,13,174,156,65,139,190,234,169,35,244,115,123,158,211,102,211,95,213,211,163,54,159,42,139,146,105,86,103,87,93,200,136,194,113,4,57,10,254,88,84,198,186,28,211,101,58,184,206,205,231,140,159,12,242,20,96,221,231,250,98,187,176,147,115,251,77,214,150,176,254,98,222,232,184,33,72,126,134,227,165,225,135,102,153,195,89,178,94,148,189,164,7,42,53,117,158,227,153,100,61,246,228,156,137,122,204,132,27,150,195,186,105,48,214,242,234,56,225,213,43,55,175,29,245,46,213,24,86,15,159,102,94,212,103,127,61,116,219,181,204,10,87,35,181,7,39,13,17,223,5,181,55,74,249,229,213,47,35,221,35,82,175,76,26,184,185,55,146,195,71,122,188,43,161,197,236,110,171,90,115,28,72,203,87,89,246,161,171,73,215,243,28,211,225,193,5,145,155,101,251,157,21,161,183,191,158,249,186,87,191,252,197,98,243,84,241,235,158,255,42,252,151,122,4,12,126,128,222,222,92,95,169,238,227,255,111,130,255,167,223,4,235,183,100,223,233,105,240,183,188,13,86,174,249,172,36,227,121,28,65,205,231,16,86,35,225,20,124,170,249,124,68,138,65,151,231,61,164,47,177,141,243,120,180,113,23,110,66,165,155,232,196,99,45,193,231,200,93,186,211,76,216,33,172,137,82,186,229,29,170,25,205,5,188,49,185,237,35,242,118,195,28,93,52,91,169,8,55,197,85,115,52,214,237,68,117,81,210,52,241,146,19,73,83,146,238,59,213,105,203,140,222,3,17,209,247,116,187,156,97,150,156,142,66,91,110,183,156,222,241,87,137,194,18,96,19,130,89,18,180,181,159,226,200,110,138,91,17,124,157,110,187,191,142,181,55,91,235,86,99,198,161,150,143,107,115,43,187,5,191,70,201,187,58,20,209,64,213,161,80,177,79,229,123,122,249,31,106,214,188,142,156,240,183,232,22,80,164,203,93,27,87,158,13,11,1,21,227,125,116,85,3,166,71,7,242,162,239,229,63,140,253,27,241,191,14,207,237,52,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("da1fafd2-deac-4a0e-9d03-510a2ec0d5d6"));
		}

		#endregion

	}

	#endregion

}

