﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SenderObtainingServiceSchema

	/// <exclude/>
	public class SenderObtainingServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SenderObtainingServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SenderObtainingServiceSchema(SenderObtainingServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("5bf1c040-6f5b-435c-9b08-854bd766f820");
			Name = "SenderObtainingService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("33bac096-c819-4c57-86af-fe71bbb0cb56");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,85,193,78,227,48,16,61,23,137,127,152,205,94,90,169,74,239,64,43,1,203,34,86,42,32,194,138,3,218,131,235,76,139,181,137,157,181,29,32,139,250,239,59,142,157,52,161,20,216,11,194,227,55,207,111,230,205,164,146,229,104,10,198,17,110,81,107,102,212,210,198,167,74,46,197,170,212,204,10,37,247,247,94,246,247,6,165,17,114,5,73,101,44,230,135,175,206,132,207,50,228,14,108,226,115,148,168,5,223,194,220,148,210,138,28,227,132,110,89,38,254,214,220,91,40,186,125,20,28,231,42,197,236,221,203,248,152,222,123,252,152,36,190,195,197,6,64,7,18,155,231,117,18,69,191,106,92,17,3,156,102,204,152,3,72,80,166,168,175,22,150,9,73,240,192,83,35,39,147,9,28,153,50,207,153,174,102,225,28,238,97,169,52,152,58,21,114,38,178,133,122,6,213,112,196,77,238,164,147,124,31,50,169,207,86,51,110,127,185,216,177,41,46,209,146,186,130,170,90,136,76,216,234,6,255,148,66,99,142,210,154,97,247,224,74,131,41,124,144,226,80,113,8,164,35,247,72,81,46,50,193,129,187,114,119,84,11,7,112,194,12,182,181,15,94,234,250,63,215,170,27,26,37,26,2,223,178,173,158,213,129,27,44,52,26,39,239,117,207,82,102,25,112,106,9,81,162,142,91,134,110,231,6,247,223,8,213,237,219,103,106,106,100,81,109,189,209,222,82,61,112,213,14,222,80,30,252,238,233,149,180,57,241,6,222,147,233,117,206,49,95,160,30,94,18,144,220,138,230,62,209,29,163,218,142,86,188,177,218,141,103,7,0,47,176,66,123,72,61,162,63,107,135,93,7,31,72,132,183,162,239,203,28,237,131,74,201,153,235,154,242,29,7,124,119,182,218,191,168,128,185,157,162,33,2,141,92,20,194,153,52,6,78,211,224,109,225,22,152,76,41,96,113,165,116,213,58,244,211,160,161,103,16,89,102,20,112,141,203,105,116,230,104,187,110,160,190,211,172,40,80,71,147,217,14,111,235,72,193,52,203,235,222,78,163,141,140,104,86,19,246,132,25,116,88,139,41,60,9,251,64,199,92,112,149,41,25,31,77,106,146,183,57,67,37,23,105,52,59,237,86,70,156,174,114,145,186,127,150,130,6,240,125,154,208,132,13,79,8,124,134,72,163,45,181,52,179,118,46,67,1,91,235,64,169,13,182,30,254,43,234,95,61,185,189,13,184,167,207,218,133,124,84,191,113,232,167,192,13,219,245,85,114,27,141,193,173,63,26,251,93,233,156,89,138,19,116,142,198,176,21,250,80,252,195,40,57,134,19,149,86,137,173,50,236,65,218,104,236,189,75,199,245,208,54,178,223,39,29,117,183,243,131,189,244,23,30,20,150,96,24,118,162,235,248,121,41,82,104,13,108,206,173,19,35,240,219,251,200,52,60,249,97,35,113,18,159,96,247,52,14,105,120,53,117,83,250,223,175,209,97,203,208,248,224,25,130,170,164,146,60,65,107,73,153,121,59,213,210,8,120,25,93,150,240,9,8,170,232,71,210,38,101,81,40,109,29,239,9,85,219,219,184,77,133,157,226,60,253,192,207,67,173,233,131,166,6,21,131,164,228,156,220,161,231,191,248,158,198,23,230,178,204,178,43,125,150,23,182,26,118,36,142,198,33,103,222,147,221,65,4,192,218,171,89,59,129,252,1,134,103,207,28,11,215,5,192,198,133,255,81,10,27,141,75,250,136,224,24,54,132,83,64,104,158,219,253,29,244,209,126,112,253,15,169,241,150,123,220,8,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5bf1c040-6f5b-435c-9b08-854bd766f820"));
		}

		#endregion

	}

	#endregion

}
