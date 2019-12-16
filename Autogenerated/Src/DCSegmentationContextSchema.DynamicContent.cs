﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: DCSegmentationContextSchema

	/// <exclude/>
	public class DCSegmentationContextSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public DCSegmentationContextSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public DCSegmentationContextSchema(DCSegmentationContextSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("a05c2795-d9c4-4291-a385-04644e22aa30");
			Name = "DCSegmentationContext";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("41c9b305-ccaa-4408-abc9-8158dd3fa84a");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,213,89,75,111,219,56,16,62,187,64,255,3,225,94,98,192,176,239,155,196,64,98,39,69,14,205,118,107,183,123,166,165,177,77,84,18,181,36,149,212,91,236,127,223,33,37,202,34,77,75,178,211,195,238,165,136,200,121,207,199,121,184,25,77,65,230,52,2,178,2,33,168,228,27,53,153,243,108,195,182,133,160,138,241,108,178,216,103,52,101,17,30,42,200,212,251,119,63,223,191,27,20,146,101,91,178,220,75,5,233,117,253,61,231,105,202,179,195,119,63,137,147,79,60,134,68,134,217,4,156,58,159,44,238,241,10,47,63,8,216,162,84,50,79,168,148,191,145,197,124,9,219,20,229,26,93,70,199,15,101,8,167,211,41,185,145,69,154,82,177,159,85,223,95,32,23,32,145,90,18,181,3,18,149,228,100,195,5,97,153,84,52,139,64,18,190,65,62,192,91,1,155,219,161,171,96,169,208,41,216,238,239,169,132,225,116,54,177,122,166,13,69,121,177,78,88,68,34,109,224,41,251,6,63,141,141,7,111,56,170,23,69,164,184,64,167,62,27,9,37,133,239,134,57,88,178,52,79,140,253,150,203,248,16,21,82,241,20,93,97,138,209,132,253,93,198,191,150,50,245,197,220,228,84,208,148,96,122,224,118,88,72,16,104,70,6,145,230,26,206,238,178,58,38,94,72,190,186,148,24,134,155,169,145,100,4,87,238,7,29,191,114,89,137,171,115,68,52,216,6,3,143,232,214,35,211,16,25,252,211,18,157,185,0,76,146,36,212,245,160,202,246,152,32,6,208,92,136,77,204,40,145,108,155,97,48,209,84,166,246,68,54,172,238,27,58,124,22,121,130,42,219,130,182,152,175,44,21,6,12,145,184,1,1,154,76,27,177,21,188,200,181,193,49,89,39,60,250,46,157,136,118,166,106,94,8,148,165,46,203,215,145,244,50,16,79,241,112,246,20,235,191,55,12,132,150,104,34,85,7,106,140,47,136,42,178,163,47,64,20,39,107,176,145,131,184,63,28,14,65,49,85,129,216,64,142,73,43,80,198,228,99,193,98,98,13,181,184,177,178,16,49,86,208,117,111,64,13,150,188,16,17,60,84,50,145,200,138,111,94,223,21,49,51,89,187,37,89,145,36,191,24,138,25,161,86,254,255,1,134,210,9,201,112,246,71,1,98,79,94,153,218,33,86,18,38,149,214,205,106,12,201,190,144,57,165,40,97,84,26,223,168,254,171,130,164,185,34,138,174,19,152,190,48,120,237,35,105,206,147,34,197,119,179,194,30,160,207,141,168,140,60,45,172,184,200,16,244,23,245,200,197,35,75,20,8,79,166,43,79,59,77,243,60,217,147,141,33,38,235,125,187,10,69,197,22,212,74,251,230,11,46,175,74,191,181,92,44,252,2,240,28,219,91,145,152,192,59,8,234,245,224,87,70,102,48,56,86,95,229,136,6,75,85,47,159,22,237,194,17,224,248,254,233,185,210,43,182,30,226,35,46,226,115,165,235,230,47,64,191,130,152,148,18,124,69,23,150,173,37,36,88,83,136,251,50,198,152,29,161,71,154,6,142,199,166,168,12,156,139,210,122,143,218,3,88,125,219,192,70,125,22,74,164,171,40,152,141,154,63,20,204,206,226,122,84,24,93,231,29,34,243,110,111,155,113,56,81,160,93,25,147,175,129,122,109,43,245,178,17,166,154,179,252,108,234,246,226,232,81,214,231,37,203,234,16,92,237,239,225,203,85,221,140,83,163,97,52,143,75,134,47,161,176,35,71,48,29,150,229,56,23,134,227,248,184,217,133,62,64,22,151,51,165,59,96,126,22,60,7,161,24,244,26,47,203,170,85,55,163,191,116,97,159,212,224,222,241,34,137,77,15,163,44,171,10,103,245,184,170,226,95,149,61,83,167,79,116,175,234,129,85,50,61,16,253,36,232,220,53,150,48,252,167,173,189,118,245,130,86,213,21,232,155,208,188,72,175,238,181,136,156,140,38,100,89,172,43,135,76,167,171,66,36,155,13,56,136,198,106,149,56,199,214,6,146,103,205,115,189,124,69,84,61,109,158,185,122,72,115,181,191,26,62,14,237,11,159,152,147,209,117,119,238,15,213,189,213,46,51,135,121,147,211,219,147,103,167,161,26,87,189,130,227,22,132,243,18,250,92,53,139,3,146,55,2,55,41,215,172,11,172,168,222,109,95,51,206,28,30,250,67,198,175,126,189,115,116,98,228,232,165,186,89,69,207,77,68,141,63,235,254,101,38,4,43,245,185,182,28,102,145,183,25,19,238,2,231,91,227,205,45,214,40,170,204,92,115,129,89,129,78,115,198,35,110,110,26,218,128,224,182,97,6,165,206,50,231,15,86,245,208,241,107,204,49,63,36,29,111,195,173,38,121,163,137,247,25,176,235,84,7,254,4,106,199,99,221,126,5,123,65,159,202,219,188,252,32,47,28,11,233,55,172,135,49,126,89,183,255,196,110,186,128,28,5,98,87,196,214,125,229,15,99,147,249,14,162,239,53,201,254,25,119,210,171,97,189,225,141,174,93,234,251,114,169,107,101,170,136,142,120,63,154,221,176,131,183,36,58,226,189,83,136,180,117,129,139,112,7,255,129,240,72,70,245,120,186,36,88,178,138,191,119,78,186,70,34,155,26,137,43,187,157,164,72,6,16,219,221,253,220,197,29,126,68,144,27,12,149,216,188,19,219,66,51,106,127,126,23,166,79,63,88,18,189,208,8,254,42,201,235,14,176,248,100,6,219,102,87,1,44,230,146,48,105,126,141,32,122,43,211,140,184,201,212,226,155,88,118,64,134,205,192,206,91,205,29,167,198,88,55,24,67,243,127,153,158,166,51,87,67,151,194,102,214,125,73,33,62,239,165,142,142,86,137,22,101,230,183,130,209,233,77,33,196,26,162,115,181,122,109,244,180,126,127,190,27,29,237,21,33,222,198,181,111,123,179,56,183,217,238,236,193,163,150,237,35,36,36,72,120,144,114,220,38,194,66,2,27,249,168,243,151,178,174,7,166,255,79,224,252,95,105,255,11,175,108,105,44,47,19,244,166,151,246,182,23,99,17,114,26,180,150,162,181,118,150,167,238,33,158,253,11,252,134,229,197,89,26,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a05c2795-d9c4-4291-a385-04644e22aa30"));
		}

		#endregion

	}

	#endregion

}

