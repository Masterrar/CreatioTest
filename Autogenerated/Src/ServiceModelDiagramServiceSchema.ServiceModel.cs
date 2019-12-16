﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ServiceModelDiagramServiceSchema

	/// <exclude/>
	public class ServiceModelDiagramServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ServiceModelDiagramServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ServiceModelDiagramServiceSchema(ServiceModelDiagramServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("301d84c0-554d-4891-b443-d01ee67136fb");
			Name = "ServiceModelDiagramService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("2acda023-1ff7-4efb-a488-cbf6ac347a40");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,237,92,91,115,219,54,22,126,86,103,250,31,80,229,133,154,149,233,75,108,183,245,117,108,89,202,170,83,167,89,219,155,60,120,58,59,180,4,219,220,82,164,194,139,83,53,227,255,190,0,9,128,184,19,148,148,76,102,235,76,38,145,8,224,220,112,112,206,193,7,80,113,48,131,217,60,152,64,112,3,211,52,200,146,251,220,31,36,241,125,248,80,164,65,30,38,177,127,13,211,167,112,2,47,147,41,140,190,255,238,243,247,223,117,138,44,140,31,192,245,34,203,225,236,80,250,238,95,4,121,160,60,28,36,81,4,39,152,92,230,191,129,49,76,195,137,210,135,231,99,109,244,63,192,59,123,135,51,196,234,169,148,190,238,199,171,55,155,241,45,132,130,142,234,175,97,252,81,79,34,133,166,231,254,48,206,195,60,132,153,177,195,197,185,194,232,170,64,131,102,16,171,17,6,81,248,23,21,30,245,187,37,170,161,89,201,211,96,146,255,142,159,157,101,243,183,48,71,154,204,81,207,187,48,10,243,197,21,252,88,132,41,156,193,56,207,60,254,11,182,9,56,6,13,67,112,47,159,60,152,246,48,147,121,113,23,133,19,48,137,130,44,3,188,125,47,194,224,33,13,102,228,81,231,115,41,102,231,85,10,31,144,208,224,93,154,204,97,138,13,112,128,62,227,121,128,85,135,121,245,5,252,59,131,41,82,38,174,28,2,252,167,16,190,99,211,116,54,55,55,193,81,86,204,102,65,186,56,161,15,94,73,127,248,7,62,27,181,201,15,51,176,148,190,98,159,238,116,30,96,78,62,117,82,152,23,169,34,25,56,61,173,154,59,158,220,114,12,60,145,102,239,159,121,62,199,51,6,255,68,147,94,164,41,50,49,154,220,44,67,109,183,93,177,111,247,247,94,169,116,231,25,255,251,76,172,9,227,105,101,80,209,186,151,48,127,76,166,216,180,229,236,84,141,86,115,1,213,96,236,195,134,220,102,176,99,249,100,30,160,73,7,49,10,24,199,93,136,125,124,113,61,121,132,179,224,45,122,210,61,49,51,17,190,248,71,155,37,29,3,217,168,116,198,241,180,166,215,138,86,53,113,217,137,218,215,162,242,209,38,29,134,233,220,254,134,188,183,92,126,252,130,235,220,162,240,48,142,159,146,63,160,87,77,1,154,243,238,187,223,174,111,186,125,128,87,13,204,242,81,146,206,130,28,61,71,93,47,209,84,7,15,176,122,228,255,146,37,113,31,156,39,211,197,117,190,136,160,208,133,61,245,63,164,193,124,14,167,125,204,238,10,5,101,20,44,161,157,102,185,76,233,58,53,175,80,74,12,188,129,57,223,235,10,70,165,162,217,99,56,39,35,198,241,125,226,101,121,138,67,147,60,199,125,240,166,8,167,128,205,81,143,44,151,167,32,5,41,101,113,12,98,248,201,65,22,143,248,124,158,46,234,85,87,53,249,151,65,24,15,43,46,136,30,249,132,37,243,37,5,72,19,225,32,45,193,190,70,129,90,118,110,197,117,38,65,62,121,4,222,240,207,9,156,151,203,25,246,20,153,234,198,99,0,249,193,36,86,208,142,135,14,107,120,128,35,170,184,130,111,113,218,20,28,206,49,250,178,185,61,0,66,218,150,155,73,144,214,71,105,78,16,53,150,200,177,151,126,246,235,238,66,172,168,116,185,132,179,59,152,122,216,236,120,165,204,234,41,237,86,94,75,21,228,166,23,240,19,79,38,0,69,229,202,218,157,140,126,122,166,170,72,230,125,118,50,37,207,79,54,10,26,149,229,1,74,134,82,230,98,121,100,130,59,0,178,62,176,189,199,40,121,215,14,134,53,165,79,187,135,230,145,100,114,212,193,92,131,195,120,126,253,190,15,225,39,74,229,253,39,77,7,27,61,42,179,153,160,174,135,139,134,49,29,168,149,175,110,182,209,186,128,115,52,211,48,158,44,6,168,237,33,73,23,168,156,44,102,49,37,167,182,183,163,118,5,159,96,154,193,38,162,164,155,68,27,249,75,142,124,43,133,193,52,137,163,69,21,34,217,96,72,7,143,167,36,50,226,118,175,59,220,30,92,236,236,15,46,54,246,119,47,70,27,187,219,195,189,141,159,119,246,127,220,216,217,219,221,219,218,250,105,120,177,179,181,215,237,57,112,66,110,28,21,22,70,187,195,189,225,222,96,239,124,99,244,122,119,123,99,247,167,215,251,27,103,163,221,225,198,143,163,253,237,157,225,246,104,235,245,207,23,37,35,237,138,98,11,99,20,194,104,170,172,10,91,168,112,72,188,166,248,65,21,254,53,204,242,163,228,238,191,40,156,159,240,75,38,35,26,242,237,30,211,193,73,40,73,146,53,201,72,157,217,46,160,209,200,198,194,89,118,1,135,2,186,57,140,43,6,49,198,115,59,119,109,45,141,195,118,245,129,124,111,44,169,191,84,77,77,178,244,179,75,118,43,255,239,3,206,47,54,90,37,62,106,168,187,36,137,192,56,35,137,26,213,107,196,121,57,227,0,201,46,67,169,84,1,199,199,250,44,161,213,202,205,165,218,100,121,209,83,90,165,250,112,42,101,248,42,80,77,29,50,186,93,42,176,148,56,120,99,33,9,68,50,65,217,99,61,66,45,39,154,178,137,210,138,169,184,198,138,34,107,246,131,237,230,55,43,225,21,89,90,226,244,85,219,202,102,125,181,114,197,57,97,9,81,231,142,92,186,92,139,7,172,44,110,190,152,67,179,15,220,144,214,213,237,202,11,104,76,7,237,12,77,203,96,148,30,138,204,96,110,169,79,217,97,173,186,172,91,155,129,221,125,148,94,107,214,104,189,202,96,247,177,43,82,245,88,251,180,172,87,141,114,251,107,215,131,116,89,131,34,58,199,106,37,245,148,109,2,200,150,51,147,4,47,203,67,110,59,122,194,237,27,232,144,21,23,188,6,140,107,23,235,233,246,194,89,133,177,60,98,137,141,188,184,31,79,139,73,158,164,173,54,31,82,86,110,95,222,27,240,206,38,164,147,199,35,85,26,161,17,213,20,198,209,42,146,51,171,136,200,113,88,92,200,64,184,78,185,241,11,167,196,198,106,61,201,13,118,180,126,13,53,187,27,94,88,242,160,149,255,81,189,159,18,164,216,40,140,162,82,115,166,31,70,25,9,124,119,19,220,69,112,152,125,36,219,44,94,215,127,21,48,93,72,251,6,159,239,112,25,196,193,3,76,251,74,89,69,247,11,152,15,158,47,1,14,144,24,251,103,211,105,213,238,117,171,164,237,115,181,57,166,64,139,36,87,42,85,98,244,105,101,37,147,19,115,172,64,180,114,13,127,56,155,231,11,205,8,45,100,210,48,6,39,131,54,253,203,160,107,30,0,170,17,225,61,240,126,208,236,138,216,12,119,44,90,54,154,78,180,89,199,170,190,133,24,67,144,244,228,20,203,88,72,225,190,6,50,170,193,44,116,202,206,34,161,103,110,73,148,110,172,161,240,6,230,149,139,43,176,56,67,191,203,41,161,4,208,90,42,162,168,39,109,76,69,134,66,36,193,28,176,142,68,208,247,1,138,251,71,213,196,159,120,226,10,162,252,216,246,192,74,3,239,36,78,60,117,5,241,82,219,29,73,46,55,237,252,112,36,61,241,140,206,247,15,208,197,53,199,161,68,91,0,220,156,169,107,252,209,64,191,170,200,218,208,150,156,211,64,151,84,72,109,8,203,238,42,82,38,190,113,29,60,193,107,136,79,249,225,84,115,70,147,121,227,105,31,104,167,109,9,12,192,112,166,105,42,55,141,57,71,201,209,220,174,209,116,2,169,219,234,137,71,145,42,217,12,6,233,228,145,130,231,37,70,72,233,215,228,48,242,100,218,164,3,35,27,241,200,179,173,97,196,179,79,17,214,20,234,186,250,228,173,6,237,75,61,188,178,16,169,237,134,226,139,0,138,106,84,215,229,244,108,213,124,110,60,113,224,19,59,97,86,13,21,2,176,14,174,59,213,29,241,28,88,113,57,142,201,152,172,168,58,54,103,98,100,55,8,163,145,247,45,139,166,109,137,225,181,234,87,37,138,166,58,33,51,220,64,154,36,243,234,220,217,235,126,222,122,246,197,114,165,111,178,107,143,103,202,246,67,11,138,102,52,240,229,206,96,240,8,85,13,145,34,57,159,89,130,48,25,121,195,32,24,35,15,49,124,59,51,208,156,80,245,150,168,238,192,183,94,222,173,88,221,73,86,212,44,62,236,205,75,215,123,110,228,151,172,0,221,136,47,83,19,186,81,182,87,137,247,97,148,227,16,218,24,240,244,39,211,7,154,64,72,152,240,66,142,74,46,25,22,214,35,218,241,205,131,20,34,219,86,157,62,132,249,227,59,156,201,32,30,225,141,136,124,51,148,221,194,44,137,203,85,51,252,88,4,81,95,145,189,44,96,249,229,83,117,104,56,37,214,85,30,196,115,59,167,78,135,194,164,243,129,245,60,250,43,91,197,38,74,159,75,202,130,189,82,146,139,25,66,195,157,86,242,57,223,227,11,110,77,26,7,63,200,123,6,67,71,127,144,20,248,42,207,49,216,170,251,214,23,103,68,105,232,186,32,222,91,74,172,161,249,37,146,183,121,222,86,159,48,202,161,99,213,165,175,83,213,191,73,206,210,52,88,120,189,94,79,93,218,144,229,240,136,29,156,242,226,178,125,96,221,67,62,87,37,68,239,19,164,25,190,8,85,57,201,36,73,167,32,140,85,6,245,28,150,181,4,222,74,84,189,45,91,9,169,38,242,117,59,20,78,27,90,9,114,16,152,161,196,232,243,24,24,219,161,90,228,161,59,84,165,180,42,101,234,177,137,18,246,119,19,17,231,71,19,112,40,46,101,159,219,218,90,152,139,91,91,161,252,242,249,218,207,82,122,140,157,236,109,43,91,180,198,167,122,176,147,38,94,105,188,116,77,210,80,123,157,186,24,221,84,3,86,202,83,82,7,237,73,41,197,159,104,206,198,226,132,233,175,129,14,26,141,237,10,29,40,76,218,205,169,59,134,160,48,98,96,130,51,19,59,152,160,48,168,81,5,103,14,118,84,129,197,255,70,92,129,173,64,140,47,212,203,209,132,51,224,196,35,102,28,62,194,75,1,214,154,163,86,69,44,154,174,97,255,93,1,11,247,187,218,118,188,66,144,126,85,152,226,169,190,191,104,173,156,181,87,40,15,172,55,44,185,210,44,227,15,108,214,84,161,175,19,100,121,50,99,42,52,181,91,133,231,47,184,158,119,145,212,236,186,236,121,119,121,4,133,103,189,18,122,34,232,96,69,78,206,80,22,186,43,114,104,215,150,224,35,88,207,113,54,10,227,32,234,106,104,173,27,133,17,204,241,130,192,172,19,129,249,214,1,152,85,207,215,28,151,197,186,32,24,19,253,245,96,48,38,234,107,0,97,76,164,215,132,194,240,97,242,76,8,147,103,52,128,124,185,157,42,5,58,172,184,203,23,223,40,255,63,34,27,212,178,171,67,27,14,121,244,43,96,25,47,80,198,114,80,134,124,245,228,5,195,120,193,48,220,48,12,123,126,127,1,49,94,64,140,175,13,98,124,27,208,197,87,195,20,180,147,167,64,11,149,221,69,128,225,158,205,97,153,9,101,252,1,53,179,215,199,180,247,35,26,107,25,190,0,162,111,161,233,171,7,73,20,84,62,240,220,121,56,66,123,227,195,70,183,126,5,238,64,102,35,85,142,216,97,175,130,248,1,122,10,84,195,155,82,208,72,41,63,5,34,134,251,41,60,53,189,66,140,44,89,41,112,137,21,162,0,97,102,135,3,206,43,132,149,26,166,5,226,120,243,120,156,113,111,86,19,51,49,146,202,91,111,186,91,187,218,27,202,229,77,221,198,208,38,254,104,64,159,190,40,164,74,196,220,190,66,235,45,29,216,101,54,33,236,213,247,26,181,151,23,121,95,212,14,107,113,33,218,253,85,58,253,117,104,213,39,52,147,235,30,73,161,241,118,186,43,222,219,232,105,141,65,119,41,13,229,208,75,95,122,42,95,52,229,162,156,33,244,210,31,126,48,93,143,175,103,88,250,101,151,101,126,71,162,162,107,114,154,22,94,96,72,107,43,100,82,241,205,89,105,10,37,126,77,142,240,55,119,37,233,117,230,66,114,5,141,167,85,142,101,240,55,245,165,102,221,203,218,77,71,223,22,255,99,69,108,253,198,132,166,129,29,59,8,61,132,93,114,136,226,34,183,71,246,213,119,145,112,157,140,146,105,93,171,202,175,250,244,56,188,4,255,168,149,202,153,14,21,43,33,185,14,207,244,5,44,233,182,84,86,22,61,74,104,89,34,222,74,149,141,114,50,102,59,24,115,89,66,124,33,37,16,247,151,167,159,66,164,208,31,153,104,35,101,65,233,41,139,33,0,136,29,165,110,64,124,198,217,148,72,192,47,79,246,174,143,232,38,214,202,25,84,216,156,173,128,6,18,124,167,121,175,238,216,88,205,235,126,188,163,175,150,239,66,193,78,223,111,80,94,126,51,179,209,252,114,135,27,151,134,159,191,145,30,163,167,232,239,255,0,44,115,113,16,230,79,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("301d84c0-554d-4891-b443-d01ee67136fb"));
		}

		#endregion

	}

	#endregion

}

