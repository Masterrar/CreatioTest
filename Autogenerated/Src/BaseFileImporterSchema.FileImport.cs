﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: BaseFileImporterSchema

	/// <exclude/>
	public class BaseFileImporterSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public BaseFileImporterSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public BaseFileImporterSchema(BaseFileImporterSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("c2df0a1e-3585-41a5-88e4-f0cff5424625");
			Name = "BaseFileImporter";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,221,26,73,111,219,198,250,172,2,253,15,83,245,66,1,2,125,175,44,5,142,42,55,66,22,7,150,211,28,12,163,160,197,145,204,70,34,153,153,161,19,33,245,127,239,55,27,57,27,41,217,145,219,190,119,177,165,89,190,125,31,229,201,22,211,50,89,98,116,133,9,73,104,177,98,241,180,200,87,217,186,34,9,203,138,60,62,207,54,120,190,45,11,194,126,252,225,219,143,63,244,42,154,229,107,52,45,182,219,34,31,25,223,9,182,191,197,179,156,101,44,195,212,89,62,79,150,172,32,214,250,98,71,25,222,186,223,129,142,205,6,47,57,17,52,254,13,231,152,100,75,239,204,155,44,255,220,44,154,60,0,170,5,179,168,106,118,63,226,219,248,21,99,101,124,118,75,25,73,36,14,56,8,71,203,234,118,147,45,81,162,54,208,114,147,80,138,94,38,20,55,130,192,4,253,130,230,238,26,92,254,38,64,244,126,38,120,13,16,129,223,156,178,36,103,244,23,244,158,100,247,9,195,114,191,148,95,208,146,239,35,64,196,169,19,226,218,45,150,119,120,155,124,152,167,239,73,81,98,194,118,239,64,65,104,140,250,216,222,238,143,90,1,73,122,22,152,82,160,193,7,148,217,219,29,128,174,118,37,14,80,162,150,59,46,94,226,21,38,56,95,226,86,110,252,19,54,184,185,100,66,155,208,175,9,75,0,196,125,150,130,232,255,200,90,247,70,74,254,56,79,165,10,108,125,160,243,12,111,210,54,109,204,193,222,170,109,78,207,214,107,56,159,128,237,156,165,73,201,149,253,199,82,238,0,154,37,200,173,32,54,173,211,4,152,16,182,6,39,235,207,123,104,81,18,1,6,56,57,5,3,67,199,169,60,114,114,114,130,78,105,181,221,38,100,55,209,11,31,40,16,2,82,206,165,71,196,245,193,19,243,100,169,33,137,243,211,250,184,251,245,27,90,99,54,66,15,29,8,149,52,80,169,153,222,139,178,93,128,83,71,126,136,7,146,94,15,104,80,159,122,217,10,69,158,152,209,79,99,148,87,155,205,64,159,234,17,204,42,146,183,40,164,215,123,144,255,124,64,99,52,37,24,148,229,81,24,13,212,213,110,200,2,240,131,182,151,134,225,70,243,198,199,241,196,180,3,244,226,5,103,205,216,70,226,127,44,110,92,139,191,111,240,61,222,196,103,101,9,161,71,68,221,155,193,200,67,214,225,18,29,91,156,152,118,135,1,226,56,150,168,235,8,200,142,199,64,25,183,119,16,137,217,105,7,45,147,72,202,51,199,95,100,252,35,21,191,119,70,214,213,22,98,88,212,175,44,75,236,15,29,211,28,12,247,220,119,21,4,16,92,243,26,12,6,123,188,207,128,124,152,251,73,243,161,40,19,17,29,210,101,177,66,12,2,33,156,196,16,253,8,94,141,251,110,66,232,163,147,73,139,211,136,149,50,33,201,22,229,16,18,199,174,84,38,174,187,159,158,136,211,142,199,185,24,35,199,205,109,168,3,110,12,206,137,177,115,102,244,127,46,131,161,229,180,141,87,14,59,162,151,107,113,58,28,237,23,165,136,69,166,231,91,233,161,37,82,5,34,144,138,62,237,246,252,22,179,187,194,203,108,157,90,92,129,204,246,6,119,79,71,226,51,6,169,208,254,132,75,29,201,192,129,154,117,75,77,226,190,12,173,84,158,111,48,158,158,232,13,43,155,242,83,141,56,36,181,214,90,36,53,253,190,198,104,32,23,38,238,133,171,217,215,37,222,88,48,158,61,74,25,114,26,154,244,13,186,28,236,60,203,83,138,100,165,135,168,168,140,148,53,28,170,30,121,154,87,89,253,137,180,103,177,225,235,196,188,68,235,26,108,50,179,112,87,121,246,185,2,21,167,156,164,85,134,73,187,110,103,33,162,195,26,54,11,93,69,35,103,220,92,120,41,10,197,72,149,147,13,83,67,244,91,149,165,168,38,88,123,226,125,66,52,234,177,163,169,216,68,247,54,201,147,53,176,1,70,49,87,65,236,229,14,224,68,13,68,233,151,43,240,80,112,85,20,113,200,18,63,132,61,133,35,86,145,98,96,22,47,146,214,120,246,185,74,54,52,82,2,144,52,155,244,47,196,49,232,158,64,142,25,5,242,46,72,154,229,201,102,190,206,1,229,20,98,217,192,171,118,228,125,171,196,145,127,213,62,47,145,70,70,129,18,180,45,96,153,6,156,245,64,187,114,155,134,137,244,65,68,229,202,65,38,50,15,68,138,96,4,112,221,251,188,32,75,204,85,230,108,68,194,24,28,210,76,147,104,80,129,89,112,27,243,32,120,151,161,88,227,62,189,247,224,200,84,64,131,231,48,53,40,131,186,79,54,224,93,194,63,159,211,189,221,206,241,233,78,62,245,232,14,107,80,249,45,240,42,111,252,206,47,116,122,180,67,163,169,68,236,135,139,113,91,192,48,225,186,32,45,141,249,64,99,135,212,189,154,252,80,166,34,143,170,116,141,182,73,89,242,8,240,140,137,212,55,5,90,123,162,250,238,20,73,82,31,247,5,136,88,210,171,66,215,91,73,108,87,42,133,138,104,150,67,54,35,201,237,6,159,202,131,242,246,68,35,11,251,154,110,28,235,74,38,190,42,222,100,148,69,221,177,213,3,80,199,65,235,66,138,41,131,128,41,42,174,76,199,198,248,215,102,181,185,215,51,25,144,150,55,225,245,71,61,137,224,52,114,111,231,212,233,3,145,129,32,110,154,244,248,53,222,81,221,43,218,20,153,16,5,35,38,134,134,152,158,121,86,152,25,96,15,35,187,54,65,220,104,164,34,205,152,59,58,217,4,230,52,3,244,215,95,250,154,40,150,189,75,221,51,26,35,9,245,122,135,16,9,188,112,71,142,193,148,40,142,148,159,15,44,118,107,233,233,54,189,254,207,25,51,145,56,174,24,207,233,187,130,189,131,44,119,65,102,219,146,237,34,147,60,104,16,224,98,133,71,14,208,14,128,156,88,63,54,249,23,100,32,49,215,221,112,98,165,99,195,117,27,31,240,204,218,12,44,150,131,78,55,56,33,23,155,244,50,249,98,183,215,145,230,150,203,201,169,110,120,90,164,231,80,35,87,4,207,114,110,233,105,212,127,149,173,239,128,232,69,137,113,218,180,70,253,70,106,237,237,123,204,169,200,129,10,251,8,208,196,79,69,161,36,58,176,71,36,13,87,183,69,177,65,211,59,188,252,52,77,114,160,219,6,201,187,32,40,198,186,171,249,38,190,124,194,187,70,168,192,245,235,250,123,84,186,164,216,231,167,69,149,51,184,212,172,196,98,41,50,78,103,20,236,32,75,157,27,29,98,18,199,129,201,215,54,154,200,65,171,80,152,150,209,46,10,192,24,160,195,202,91,109,251,194,158,186,71,30,70,139,184,127,220,177,72,238,117,139,248,228,154,209,204,112,225,214,93,152,61,71,229,149,91,251,90,60,131,26,126,63,234,108,171,100,15,105,141,45,140,137,69,107,223,223,63,153,116,112,170,235,30,183,2,210,188,213,15,8,29,83,209,142,145,100,43,51,179,175,120,89,177,90,45,183,59,67,22,71,83,76,77,188,208,144,84,70,167,78,252,105,101,107,237,96,251,238,83,188,191,78,217,22,224,131,203,11,175,125,123,114,125,193,227,241,79,102,122,152,83,96,237,128,220,100,132,162,179,52,85,101,107,157,31,111,129,156,79,237,237,94,115,217,78,37,181,87,101,132,65,138,55,117,55,207,129,113,232,50,187,58,166,135,67,195,135,120,32,51,44,52,203,239,48,201,88,90,44,145,225,49,225,217,198,247,69,148,99,116,161,173,181,182,229,198,242,17,80,75,210,239,72,67,189,100,87,55,234,44,199,34,43,234,105,145,172,105,56,139,197,202,107,52,181,107,249,13,173,231,59,131,102,178,121,237,34,188,42,228,228,33,26,220,28,218,186,30,166,215,75,41,54,183,13,250,151,180,59,109,167,34,168,97,187,29,186,196,180,4,7,199,77,117,168,119,254,69,53,135,6,31,225,105,4,191,74,138,130,213,69,170,85,126,198,151,230,86,232,134,42,141,15,156,159,49,188,149,179,51,11,229,32,174,155,231,122,60,37,102,164,65,57,171,64,25,170,150,117,148,86,131,214,75,151,74,155,108,25,37,159,104,194,98,38,243,191,21,153,188,136,244,216,241,216,115,88,234,65,19,182,81,221,201,24,119,221,119,222,112,112,82,105,144,221,145,226,139,156,210,229,247,188,26,190,128,30,83,228,95,62,231,47,249,7,85,11,60,222,20,22,44,33,245,156,244,153,149,175,147,140,81,98,61,179,198,58,58,76,41,96,167,90,8,234,238,31,18,170,89,164,134,38,199,93,114,252,152,177,59,97,130,7,213,151,102,204,49,101,202,7,14,90,164,129,23,28,37,44,175,251,124,188,124,212,171,148,110,184,146,60,69,84,244,95,25,151,90,14,229,233,86,214,163,172,144,15,136,109,191,196,48,4,193,187,34,30,80,34,179,138,38,248,115,5,213,42,184,42,255,241,19,196,120,134,191,178,120,90,17,2,236,190,136,47,229,118,147,26,56,102,30,106,229,250,139,248,28,190,215,69,246,182,93,90,124,119,160,76,74,76,133,174,200,78,14,134,248,206,117,199,47,157,110,134,168,168,160,237,112,51,153,217,170,219,70,105,15,158,4,252,142,31,64,221,232,248,243,93,206,164,197,195,181,85,139,71,252,80,142,94,247,249,42,237,171,42,139,127,233,144,19,236,154,0,237,104,218,246,234,209,158,252,87,214,211,233,56,248,120,234,13,75,172,75,177,250,36,76,71,144,215,196,107,75,33,114,38,231,78,227,130,176,46,110,255,132,82,34,10,233,83,6,244,224,4,224,251,221,106,193,211,58,75,214,255,72,18,55,225,112,156,245,101,248,34,150,219,99,86,195,254,21,92,12,230,128,161,217,239,194,169,137,224,235,56,153,129,103,84,46,164,86,43,21,168,142,81,159,26,129,182,225,23,32,112,4,163,35,89,130,37,216,71,86,241,195,192,84,193,125,234,248,110,89,235,55,145,86,113,107,132,199,144,120,240,205,199,124,226,209,200,158,73,252,98,248,12,9,172,69,220,234,53,144,71,13,249,104,113,36,25,107,128,190,144,47,200,199,187,140,225,5,255,197,179,25,133,229,155,199,113,109,252,92,193,133,251,26,69,19,76,107,18,33,142,6,31,54,204,198,13,83,41,74,49,130,63,114,232,116,52,38,129,169,144,29,214,154,121,68,237,202,47,71,211,159,9,180,221,81,44,212,29,93,201,227,242,168,23,164,20,163,99,139,213,80,23,19,191,194,73,202,91,103,225,82,226,93,201,239,108,158,156,166,59,115,171,37,176,227,167,87,101,35,226,61,71,63,124,252,135,231,32,123,159,156,60,225,30,36,34,191,43,237,122,204,49,165,234,204,84,97,245,225,111,161,125,144,123,120,49,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c2df0a1e-3585-41a5-88e4-f0cff5424625"));
		}

		#endregion

	}

	#endregion

}
