﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: PortalMessageFilesReaderSchema

	/// <exclude/>
	public class PortalMessageFilesReaderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public PortalMessageFilesReaderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public PortalMessageFilesReaderSchema(PortalMessageFilesReaderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e2a13f64-5f0b-4ba8-9fe6-cc948f4afcaa");
			Name = "PortalMessageFilesReader";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("c85d2d65-6230-4aeb-9934-bfac9785d42f");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,88,219,110,219,56,16,125,118,129,254,3,215,5,10,9,8,228,247,38,118,145,196,105,234,69,82,123,115,233,62,22,140,52,142,137,74,148,74,82,77,221,109,254,125,135,23,201,162,46,177,243,148,136,156,115,230,194,153,225,208,156,102,32,11,26,3,185,3,33,168,204,215,42,58,207,249,154,61,150,130,42,150,243,183,111,254,123,251,102,84,74,198,31,201,237,86,42,200,142,91,223,40,159,166,16,107,97,25,93,2,7,193,226,142,204,156,42,186,91,108,234,202,178,156,247,239,52,172,136,110,216,227,70,201,91,16,63,89,12,253,226,98,112,61,154,159,245,109,125,41,89,228,24,175,243,4,82,99,36,170,85,130,198,10,1,8,121,39,224,17,213,19,114,158,82,41,63,144,85,46,20,77,175,65,74,250,8,159,88,10,242,6,104,2,194,8,79,38,19,114,34,203,44,163,98,59,115,223,6,71,214,185,32,2,5,181,126,75,65,28,7,89,107,146,168,66,79,26,240,162,124,72,89,76,98,195,48,164,152,124,32,139,206,94,101,211,72,31,93,237,3,122,38,21,229,74,187,33,216,79,170,128,24,179,71,133,251,210,22,230,60,221,18,169,132,182,244,91,209,38,62,77,25,149,100,74,198,69,182,30,31,191,14,187,72,106,116,199,224,69,50,182,241,30,189,3,158,88,123,221,183,51,126,37,242,2,132,98,96,172,207,21,230,27,36,149,249,238,147,220,75,16,232,37,183,201,72,74,239,243,53,10,76,228,253,224,216,4,252,12,41,74,145,111,162,241,101,227,96,15,203,147,242,62,166,250,72,71,35,15,73,62,126,36,129,191,50,37,28,158,60,100,224,187,17,134,123,28,49,199,44,202,88,229,162,229,74,59,63,205,194,130,51,197,104,202,126,195,96,142,69,53,120,210,70,159,20,84,208,140,112,236,34,211,177,111,232,120,214,58,14,212,13,64,98,1,235,233,248,198,22,131,47,177,44,76,15,25,79,102,209,201,196,16,207,26,161,29,178,46,120,241,212,67,98,106,96,164,54,76,70,254,22,198,186,147,33,163,209,243,203,209,189,6,181,201,147,93,9,249,73,114,11,186,17,146,75,80,93,107,237,94,224,234,195,43,143,69,82,153,41,64,149,130,155,28,112,242,45,119,140,212,72,183,220,50,227,193,64,133,30,145,49,86,84,24,157,202,30,9,87,135,7,51,157,99,105,99,113,157,109,53,229,43,65,75,126,56,228,11,86,177,60,92,252,110,91,192,107,44,250,10,66,234,172,60,220,30,204,233,182,244,120,173,198,245,150,14,239,88,35,180,41,189,210,69,166,165,47,184,98,170,39,122,222,246,109,188,129,140,222,55,164,62,137,60,11,186,173,18,33,3,54,87,192,43,88,171,101,169,64,252,157,51,222,98,112,86,163,230,74,122,89,27,98,82,102,33,47,126,148,52,125,33,46,43,63,115,199,3,106,171,192,56,141,24,184,134,198,253,199,90,27,226,66,222,80,244,239,6,4,188,198,192,154,203,6,62,50,29,50,184,44,89,18,173,168,144,16,180,139,49,172,84,157,242,164,138,206,103,150,192,146,91,238,33,202,53,77,37,132,33,193,91,206,86,111,179,163,84,61,226,33,207,83,114,190,129,248,251,98,109,90,23,229,186,145,153,30,97,140,34,224,103,196,17,105,172,234,207,188,84,150,37,182,80,61,182,84,13,132,173,73,208,194,147,191,166,36,129,53,45,83,235,116,88,201,142,126,82,65,164,17,211,233,219,233,135,81,51,53,175,41,199,224,8,28,240,212,194,204,17,49,156,109,145,189,173,45,140,52,215,177,85,208,48,16,217,155,183,154,230,113,158,91,232,13,196,185,72,140,72,176,179,233,168,118,59,180,148,207,4,48,198,149,3,62,63,222,122,78,241,115,179,153,54,132,250,206,163,83,97,243,187,37,177,253,203,219,194,229,96,161,73,220,224,37,204,159,158,198,221,75,232,12,198,211,152,58,164,137,128,201,158,175,52,45,225,68,31,205,236,133,126,125,100,25,234,118,188,135,200,239,219,62,120,201,7,193,246,122,218,193,117,7,119,96,151,35,123,112,182,17,86,16,221,211,15,192,216,214,239,64,186,5,32,166,125,137,234,229,171,60,255,126,95,24,116,224,226,239,64,174,189,15,234,98,92,161,34,255,18,120,238,75,7,173,162,44,44,116,175,13,7,229,131,199,232,242,96,206,100,145,210,173,97,217,31,31,255,146,113,30,227,0,162,71,177,69,134,118,85,60,22,17,93,100,133,218,86,129,121,81,133,203,21,239,50,237,13,203,10,181,208,135,20,108,95,115,147,154,137,143,219,112,75,129,155,236,42,9,225,125,86,209,209,141,135,37,23,191,10,129,113,181,199,166,35,245,79,9,98,107,205,219,237,237,25,114,108,193,55,201,162,234,157,49,88,75,199,181,17,248,182,82,38,18,43,61,110,130,170,39,112,99,74,189,24,160,170,171,74,20,111,3,223,171,168,222,10,119,204,133,23,48,108,170,9,83,59,79,87,3,187,46,61,174,250,204,234,218,234,142,88,223,188,94,44,155,209,112,50,75,129,167,143,189,0,223,226,206,132,198,74,224,1,236,206,156,9,123,11,220,98,78,197,10,47,241,24,71,98,116,186,153,36,94,219,235,203,144,96,32,12,157,16,222,228,79,231,121,201,213,81,139,167,54,35,250,2,191,84,248,186,17,125,223,219,7,211,215,13,226,36,107,63,199,15,121,240,180,39,141,217,202,39,43,57,251,81,2,14,14,120,135,173,25,86,95,243,89,211,97,243,35,50,158,217,74,170,201,114,87,81,221,87,212,192,187,201,40,176,7,36,103,250,103,13,202,56,38,210,19,83,27,178,234,241,154,196,245,239,56,77,37,86,84,87,143,251,173,228,6,100,129,234,192,234,171,20,52,94,106,139,11,94,102,32,244,33,158,244,93,134,179,254,7,210,192,211,232,136,28,220,82,170,16,77,251,26,83,11,214,168,212,182,37,238,21,215,189,130,154,239,184,246,204,24,221,229,149,198,32,239,232,176,1,182,133,119,197,164,234,143,75,224,16,246,135,170,96,126,118,241,11,226,18,31,242,36,121,208,255,246,77,104,178,20,48,63,219,45,5,187,241,206,209,116,47,41,228,25,112,58,178,26,221,47,72,129,85,187,99,52,190,248,67,151,153,121,221,184,55,122,218,32,19,113,87,115,164,165,130,144,188,127,79,130,160,9,250,243,103,112,254,125,241,150,234,188,148,92,111,211,109,104,47,204,200,155,209,185,57,53,135,13,223,70,182,246,79,147,36,24,24,255,220,21,31,86,238,218,49,211,253,241,102,78,67,53,212,172,220,154,223,191,158,255,7,54,67,119,18,138,21,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e2a13f64-5f0b-4ba8-9fe6-cc948f4afcaa"));
		}

		#endregion

	}

	#endregion

}
