﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: EsnCenterSchema

	/// <exclude/>
	public class EsnCenterSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public EsnCenterSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public EsnCenterSchema(EsnCenterSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("7a1d3f1e-6629-4619-bf6b-57a5f51ad865");
			Name = "EsnCenter";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b66b5ae8-46e0-4931-ad78-c2c1ba5fd6ea");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,237,89,91,111,219,54,20,126,86,129,254,7,206,125,177,1,67,121,207,109,200,197,233,12,52,77,208,36,43,176,97,40,20,137,142,185,72,162,71,82,201,220,34,255,125,135,55,137,164,100,91,110,182,97,109,246,18,91,244,185,159,239,92,168,148,73,129,249,34,73,49,186,198,140,37,156,206,68,124,66,203,25,185,171,88,34,8,45,227,201,213,251,215,175,190,188,126,21,85,156,148,119,232,106,201,5,46,246,130,103,224,201,115,156,74,6,30,191,197,37,102,36,109,209,188,35,229,31,173,195,43,156,86,140,136,101,243,131,107,72,81,208,178,251,23,134,87,157,199,147,82,16,65,48,95,73,112,150,164,130,178,21,20,239,43,2,70,177,7,146,226,115,154,225,60,62,77,68,2,33,17,12,184,128,1,88,222,48,124,7,158,34,116,146,39,156,239,162,9,47,79,112,41,48,83,191,238,236,236,160,125,82,206,33,6,34,163,41,218,57,132,195,95,79,241,44,169,114,113,76,202,12,244,13,197,114,129,233,108,56,173,89,71,163,223,128,108,81,221,230,36,69,169,148,219,136,69,187,104,234,232,136,100,54,106,35,192,52,46,146,82,128,29,151,140,60,36,2,43,43,162,133,126,64,12,39,25,45,243,165,18,241,142,220,227,15,120,65,57,129,0,44,209,167,220,123,222,91,201,119,142,57,79,238,128,52,201,192,156,79,133,251,216,131,43,83,1,119,248,244,193,106,78,139,138,73,121,71,74,140,62,225,240,72,39,34,122,131,203,76,199,193,60,187,65,97,149,84,34,227,162,162,106,194,162,35,92,135,115,216,17,22,28,158,140,59,130,128,131,131,177,148,30,69,93,126,227,214,209,184,203,203,150,147,35,164,50,29,5,105,66,7,109,11,247,52,161,151,24,77,119,222,202,85,20,230,33,32,116,146,19,181,35,175,137,91,217,136,162,167,245,41,57,199,98,78,179,85,40,125,71,233,125,181,128,46,82,21,229,207,73,94,97,244,22,139,203,132,65,142,134,170,158,33,43,234,195,198,228,33,97,104,161,126,159,102,210,36,245,35,180,30,113,13,149,149,57,130,246,223,86,36,59,28,14,46,13,241,96,164,61,99,88,84,172,116,100,28,32,73,25,79,138,133,88,234,92,254,136,202,42,207,245,247,93,84,226,199,14,51,191,32,253,121,80,75,138,175,233,149,96,178,200,71,232,201,141,204,90,95,79,0,255,2,103,199,203,110,119,141,181,43,108,208,38,158,18,190,200,147,165,181,103,77,72,184,178,15,130,82,107,125,15,115,96,48,50,24,134,12,21,9,91,78,11,128,67,15,105,38,192,181,44,151,125,48,234,10,44,68,86,155,224,29,238,110,103,178,175,198,152,254,85,206,75,80,40,246,167,45,129,76,5,204,60,156,233,223,85,223,231,85,33,141,58,180,7,90,7,58,189,190,64,51,40,52,6,195,22,90,19,142,107,134,157,144,99,31,112,148,20,168,132,132,28,12,180,27,131,195,169,234,241,48,165,233,12,116,96,140,82,134,103,7,131,21,131,79,127,89,14,96,244,196,251,59,74,94,35,94,35,137,247,17,25,172,1,177,233,148,224,140,17,109,101,105,116,155,104,160,7,194,68,149,228,168,33,55,97,104,14,66,144,31,28,42,104,59,28,26,211,110,109,155,124,59,169,212,57,191,162,41,73,114,211,189,122,54,131,128,199,194,231,134,99,214,83,130,38,181,140,114,63,128,174,217,147,215,3,158,39,64,150,161,39,194,225,110,85,171,211,104,60,33,110,97,108,107,145,95,84,170,26,246,54,195,219,204,147,127,10,230,207,128,51,32,74,78,62,147,233,45,144,235,115,53,0,110,206,86,99,56,224,237,15,101,56,208,211,184,79,247,146,180,13,124,138,2,152,78,104,85,138,245,252,164,20,138,185,161,175,101,88,12,128,0,111,32,25,7,61,170,139,82,83,193,166,12,133,68,62,227,12,214,100,124,77,10,60,92,163,220,210,52,136,187,40,7,35,35,89,135,179,39,96,45,241,192,99,190,74,231,184,72,90,69,180,58,136,33,155,21,7,87,149,251,75,134,31,8,126,148,235,127,35,237,12,246,119,205,228,85,102,64,15,83,239,135,3,103,121,144,3,175,49,231,120,41,48,95,197,104,25,118,21,123,219,185,155,173,2,84,243,212,142,37,92,28,169,123,218,179,51,232,138,170,147,40,219,119,111,20,214,196,214,58,83,52,61,147,103,168,45,179,94,240,180,83,102,115,116,145,219,167,143,241,58,22,40,147,207,164,68,55,34,69,2,28,70,159,105,185,170,159,53,13,68,219,182,34,172,246,139,146,45,191,4,203,157,253,93,2,65,185,42,93,143,107,65,67,203,54,70,242,239,47,96,207,180,156,209,24,44,28,109,183,183,56,215,161,206,203,170,189,36,77,39,101,85,96,150,220,230,120,191,25,205,135,210,61,19,123,121,196,207,40,147,211,112,40,145,135,42,53,23,199,30,175,130,164,29,18,211,140,203,94,169,113,30,220,108,100,190,165,40,37,246,120,105,148,240,161,21,234,136,128,184,200,23,14,195,112,179,24,237,61,207,177,143,115,42,31,109,255,214,78,213,122,215,90,30,178,54,92,207,50,86,89,32,25,60,147,108,72,218,246,133,183,250,248,40,203,36,123,59,138,189,212,223,82,154,163,155,242,57,6,156,130,247,2,63,195,134,32,95,254,124,61,68,242,217,76,52,174,141,227,182,239,25,251,176,25,23,109,115,117,5,146,25,26,182,175,186,241,73,162,116,233,94,106,189,119,100,91,177,35,43,199,150,178,127,17,143,61,3,215,192,162,113,202,92,82,159,212,95,49,103,244,81,45,23,181,125,127,166,120,33,91,239,208,220,163,160,6,139,68,12,205,244,208,215,196,84,182,13,25,51,179,37,6,215,133,193,216,206,154,104,112,122,28,120,94,43,136,79,42,38,123,169,44,203,159,18,254,158,138,15,228,110,46,100,209,95,220,254,14,214,67,251,69,254,62,13,195,192,237,71,107,51,219,222,150,156,199,255,70,46,187,86,191,142,252,182,171,254,165,228,176,71,117,250,81,95,159,86,237,145,47,232,66,249,193,17,213,159,255,98,217,250,66,26,236,89,75,254,175,225,62,249,63,195,205,88,236,206,172,124,253,123,225,103,87,190,226,51,9,225,176,214,169,128,16,46,58,116,12,77,168,37,71,35,72,69,207,48,118,43,53,217,191,162,204,94,124,28,51,98,123,108,98,236,240,219,13,215,165,14,127,54,92,23,179,25,199,66,174,118,1,125,243,131,243,234,73,121,192,149,94,189,242,154,187,76,224,84,109,154,243,10,64,243,103,212,58,229,70,239,140,209,226,244,22,228,116,0,220,77,77,160,198,200,140,224,74,143,147,116,142,134,142,76,185,27,251,226,235,98,138,66,107,189,24,24,166,13,183,139,48,6,214,20,229,22,110,110,138,235,164,181,174,138,109,25,238,157,170,183,40,231,82,101,150,151,45,91,81,160,187,171,33,69,145,13,174,92,223,186,186,139,29,52,163,218,45,101,67,205,102,48,186,30,164,142,190,232,22,8,239,107,89,79,230,139,249,52,31,174,6,157,117,173,103,168,46,188,253,52,185,122,180,216,39,244,56,39,57,110,25,191,191,94,162,247,30,223,178,246,238,90,106,232,92,82,46,156,190,244,17,8,113,19,98,43,84,94,200,54,143,28,157,163,96,13,144,172,177,147,105,247,120,178,121,12,233,127,197,196,174,153,174,77,47,100,192,212,169,50,59,116,112,41,27,163,142,212,165,154,116,155,212,89,233,14,171,155,58,247,120,187,212,89,193,142,197,174,121,223,75,22,251,93,37,39,25,169,177,220,35,143,29,37,232,76,33,243,10,182,115,176,25,33,71,121,174,59,57,215,196,206,130,190,23,138,59,170,196,156,50,119,26,76,182,123,153,191,183,1,104,210,121,137,136,109,218,195,56,180,110,51,232,220,24,123,142,248,26,12,201,119,3,192,190,240,243,218,136,169,196,254,109,68,226,197,28,127,13,252,106,125,14,252,204,153,3,63,79,193,223,15,191,45,90,220,56,180,174,31,252,130,102,106,225,231,106,120,137,240,211,175,194,158,245,126,227,27,110,127,218,123,133,192,142,235,248,87,52,58,63,156,158,209,47,16,86,94,95,219,0,171,166,13,125,251,109,109,19,172,182,110,96,126,56,61,163,191,35,88,185,255,40,50,103,238,17,156,252,5,176,89,139,59,30,42,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("7a1d3f1e-6629-4619-bf6b-57a5f51ad865"));
		}

		#endregion

	}

	#endregion

}
