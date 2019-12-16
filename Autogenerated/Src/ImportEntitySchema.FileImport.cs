﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ImportEntitySchema

	/// <exclude/>
	public class ImportEntitySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ImportEntitySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ImportEntitySchema(ImportEntitySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("b8c1a2f0-8dab-44be-9e51-85075a763c4e");
			Name = "ImportEntity";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("52abf94a-4a51-4e9b-afae-86480a04ff1e");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,205,90,91,111,19,59,16,126,14,18,255,193,228,188,108,164,106,251,126,104,130,74,154,162,8,40,81,47,188,160,163,202,73,156,116,15,123,9,182,183,37,64,255,251,25,223,118,109,239,53,5,113,120,129,248,50,227,241,204,55,23,207,54,197,9,97,59,188,34,232,154,80,138,89,182,225,225,52,75,55,209,54,167,152,71,89,26,158,71,49,153,39,187,140,242,231,207,190,63,127,54,200,89,148,110,209,52,75,146,44,125,105,141,41,113,71,225,44,229,17,143,8,43,167,175,246,140,147,196,31,195,121,113,76,86,226,48,22,190,33,41,161,209,170,178,231,93,148,126,169,76,94,230,112,68,66,194,43,32,193,113,244,77,10,92,217,117,77,190,114,152,132,233,191,40,217,194,14,132,166,49,102,236,111,164,174,37,229,220,191,39,9,73,121,38,247,125,42,24,46,99,242,15,76,236,242,101,28,173,208,74,144,213,83,13,190,75,202,242,136,243,136,196,107,56,99,33,73,213,226,167,51,204,49,144,44,9,13,46,64,241,104,140,134,171,44,206,147,244,35,142,115,194,134,35,113,152,57,109,62,75,243,132,80,33,195,137,58,115,90,238,157,32,107,32,85,92,203,157,102,15,243,116,77,190,186,156,243,40,229,232,82,47,189,212,130,147,116,173,100,151,227,71,165,48,107,114,208,169,66,185,225,248,248,24,157,176,60,73,48,221,79,244,248,52,69,81,202,56,78,1,102,217,6,241,187,136,105,93,82,178,163,132,129,10,25,34,146,7,44,98,142,96,125,73,132,9,35,201,158,172,67,195,249,216,98,221,223,76,202,62,117,214,161,209,61,230,68,155,231,34,75,13,75,178,86,10,83,235,232,44,146,248,132,131,79,24,167,32,217,17,82,156,39,232,118,117,23,197,107,11,236,54,93,135,13,111,87,174,17,5,169,175,64,57,241,150,236,195,98,209,214,65,155,208,74,82,116,251,153,236,95,118,222,80,93,7,221,194,88,240,86,195,54,145,46,241,3,250,252,51,98,81,252,240,182,144,204,131,95,187,31,213,202,35,226,20,2,188,3,212,0,213,13,98,245,119,128,66,130,5,205,118,132,10,219,246,16,66,89,23,221,75,131,182,203,112,128,123,35,9,222,193,150,112,52,174,130,6,86,88,205,10,184,191,20,67,238,120,108,145,121,161,44,174,29,176,93,104,141,146,133,13,18,79,58,31,64,150,120,206,82,111,249,166,194,191,148,116,81,151,82,91,252,116,106,187,169,175,81,103,237,213,43,20,120,83,99,148,146,135,22,238,193,104,228,89,194,35,175,92,181,9,110,239,9,191,203,42,161,169,94,49,148,192,6,8,165,165,130,154,204,39,103,118,152,226,4,165,144,26,198,195,156,17,10,121,62,85,121,119,56,185,129,49,90,21,19,225,201,177,220,93,79,172,142,186,90,221,145,4,15,39,218,156,76,14,219,9,215,132,241,40,197,234,72,5,122,164,48,139,172,165,42,15,74,120,78,83,54,153,218,55,61,57,54,211,53,113,76,233,166,180,249,62,184,113,110,140,92,5,24,67,170,59,33,251,130,71,210,174,3,219,69,207,74,89,109,185,71,26,85,247,152,154,108,54,214,130,104,25,252,67,237,115,52,128,54,80,58,225,213,29,10,4,23,204,1,102,203,28,174,21,185,26,58,53,11,204,28,58,208,90,185,34,118,28,9,10,14,33,196,218,163,146,97,40,151,245,153,143,133,216,37,2,116,36,27,163,55,132,95,146,13,161,4,178,183,154,12,106,196,174,63,221,103,23,90,139,162,68,57,114,35,73,168,71,214,46,205,94,89,90,235,171,59,98,104,199,248,83,93,194,224,118,214,27,200,63,137,225,90,100,218,27,194,22,152,86,44,124,70,54,118,118,10,158,100,35,128,213,255,16,185,126,95,0,58,207,232,138,192,37,15,8,65,7,134,152,50,197,8,107,158,67,217,99,159,101,19,41,251,68,27,20,56,52,144,212,242,56,46,2,136,224,105,81,65,188,0,182,182,86,224,54,48,105,204,109,129,73,35,110,236,221,40,180,241,248,30,167,120,75,168,96,50,215,111,129,215,251,155,249,218,22,52,84,91,97,214,156,225,222,177,26,212,219,2,234,17,170,234,96,224,84,1,225,233,218,57,95,134,72,235,72,39,60,106,120,91,203,135,165,243,174,210,17,100,121,154,67,60,21,211,213,240,53,44,35,82,185,87,87,86,247,89,180,22,50,218,218,239,1,88,19,148,244,157,108,252,30,128,181,110,171,17,203,96,109,97,71,184,201,239,85,115,159,208,225,20,215,190,39,31,24,22,14,80,171,62,208,135,180,167,238,107,186,7,50,149,208,125,181,103,57,175,113,152,118,87,105,177,139,122,238,155,20,181,178,30,83,125,173,164,104,60,3,53,27,101,222,124,96,173,137,42,15,53,101,45,171,228,177,119,104,134,198,58,90,45,118,238,84,65,41,60,143,40,227,31,40,36,86,156,199,60,176,158,113,226,49,97,13,117,1,37,223,173,34,128,235,251,201,113,55,248,101,206,181,251,44,15,81,28,163,37,60,201,241,189,234,177,252,241,9,120,214,40,125,155,75,193,197,213,47,200,202,87,176,251,23,102,98,145,85,107,83,88,56,251,146,227,152,5,110,133,171,203,45,145,226,138,196,171,113,177,168,62,156,157,204,83,87,81,248,130,87,50,94,39,28,154,91,56,21,219,201,223,132,19,202,10,211,149,83,237,102,87,38,102,158,201,251,17,45,104,182,34,140,101,116,56,81,22,97,104,103,166,218,25,236,50,198,53,53,60,214,135,147,5,140,119,197,24,109,242,180,1,177,6,73,162,237,86,139,43,221,195,210,225,84,93,106,81,232,194,82,203,81,99,159,199,248,53,51,15,204,139,44,93,0,69,196,56,184,168,190,233,233,118,11,133,4,230,25,69,190,54,142,208,57,200,95,52,34,178,229,191,0,2,243,255,4,185,119,71,110,173,39,242,4,91,234,174,198,149,228,240,58,7,84,17,106,82,131,220,97,160,12,27,45,67,95,102,25,47,80,94,243,104,213,238,28,153,240,199,156,10,211,137,109,149,232,169,3,166,46,214,100,197,106,239,247,42,214,1,68,29,128,187,110,172,24,119,113,165,177,60,162,20,41,180,156,186,20,79,158,247,162,213,153,11,149,140,208,143,31,200,217,59,103,0,133,146,151,47,155,17,78,42,65,102,24,29,139,208,184,98,218,80,168,229,163,181,39,112,42,42,75,37,70,83,82,116,151,171,175,171,70,129,4,169,135,150,23,21,98,79,98,119,191,19,0,149,57,213,235,222,166,26,249,231,178,101,120,186,219,65,221,28,212,109,123,180,2,160,232,96,195,161,64,112,157,41,180,6,35,248,249,46,123,40,1,171,131,164,110,118,247,8,124,180,181,127,221,28,193,68,81,213,24,190,76,168,48,205,241,142,224,113,41,91,224,65,103,136,176,147,141,238,155,3,222,46,192,68,31,232,44,217,65,34,24,57,78,214,238,219,125,221,245,96,127,237,118,216,70,16,150,96,176,171,29,245,239,53,36,198,162,193,106,40,180,26,186,96,225,100,208,242,147,67,159,222,132,210,139,172,52,116,117,227,60,28,68,95,151,103,34,48,194,240,192,183,132,219,45,178,95,6,157,61,163,233,83,196,106,169,141,148,16,154,107,77,175,175,179,167,212,0,38,183,187,228,33,75,6,90,29,138,111,24,222,146,235,253,142,152,24,91,149,171,220,34,63,15,227,120,212,149,2,74,32,134,197,133,158,80,153,21,47,25,201,170,38,50,241,59,241,197,73,120,218,156,147,228,34,227,231,89,158,174,103,95,87,100,39,130,161,211,41,13,69,76,236,174,202,230,41,24,81,126,54,19,117,78,143,79,51,191,182,64,239,95,228,217,141,1,33,180,163,206,126,21,118,109,201,100,7,59,247,67,147,159,150,148,117,252,30,246,47,232,73,53,85,59,58,168,44,188,239,88,7,246,248,219,172,47,82,160,247,14,110,255,226,37,213,47,107,4,163,22,15,214,114,169,238,93,175,94,160,33,228,221,25,248,111,16,1,128,197,107,83,252,175,169,186,197,189,84,97,5,82,154,104,125,66,40,144,143,177,22,156,154,56,212,242,186,118,254,178,66,94,237,74,112,135,251,129,116,210,213,170,219,138,203,15,156,239,166,42,9,190,131,146,186,230,19,107,96,111,29,233,42,220,124,20,6,82,243,83,234,160,245,75,56,84,63,16,4,213,59,84,171,162,167,171,38,74,252,225,164,201,177,52,111,165,129,58,253,104,14,230,254,150,252,122,37,180,190,115,31,166,31,195,192,209,83,83,211,179,230,47,70,96,230,63,223,94,52,65,95,36,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b8c1a2f0-8dab-44be-9e51-85075a763c4e"));
		}

		#endregion

	}

	#endregion

}
