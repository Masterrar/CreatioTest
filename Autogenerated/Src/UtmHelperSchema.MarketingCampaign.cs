﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: UtmHelperSchema

	/// <exclude/>
	public class UtmHelperSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public UtmHelperSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public UtmHelperSchema(UtmHelperSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("3e02aad0-4fd4-4d2f-85a6-43398aa0ca6e");
			Name = "UtmHelper";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("bc5da875-f48b-48a1-a687-7137717191f8");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,181,26,105,79,27,73,246,179,71,154,255,80,105,70,208,29,76,67,102,165,149,54,96,35,66,152,44,154,92,19,96,87,90,227,160,198,46,236,86,250,112,170,170,73,88,226,255,62,175,238,170,62,108,51,218,29,69,137,187,234,93,245,238,87,53,69,146,99,186,72,38,24,93,98,66,18,90,222,177,248,180,44,238,210,89,69,18,150,150,69,252,46,41,166,36,205,178,11,76,238,211,9,254,249,167,199,159,127,234,85,52,45,102,232,226,129,50,156,31,214,190,1,63,203,240,132,35,211,248,13,46,48,73,39,13,152,183,105,241,181,177,120,137,191,179,248,19,158,85,89,66,206,190,47,8,166,148,19,1,56,128,220,34,120,6,95,232,52,75,40,125,137,174,88,254,58,97,137,216,90,84,183,89,58,65,19,190,99,55,122,92,80,189,119,91,150,25,186,162,24,118,209,35,154,97,118,136,40,255,107,233,192,80,70,184,48,175,203,60,73,11,186,14,12,40,93,148,21,1,205,173,7,124,135,167,105,181,150,49,0,158,38,249,34,73,103,197,6,160,96,175,141,40,150,5,195,5,91,7,121,137,243,69,150,48,124,90,78,155,7,90,186,90,166,12,252,66,43,27,168,223,99,194,240,180,93,235,10,86,109,106,232,203,82,45,132,108,158,82,244,170,202,190,156,129,202,51,116,171,127,245,181,88,204,17,43,66,130,116,143,96,86,145,2,21,248,155,33,44,55,122,202,190,3,75,40,150,75,125,185,175,45,235,2,168,53,5,97,141,234,17,209,171,22,74,89,180,6,37,87,45,148,49,103,13,78,175,91,72,97,205,26,20,95,115,104,41,67,214,73,201,101,5,231,153,113,224,169,79,0,44,121,204,245,172,77,183,48,4,183,136,171,142,24,251,39,206,22,152,136,205,253,253,125,116,68,171,60,79,200,195,80,125,11,64,116,87,18,244,173,36,95,208,183,148,205,57,22,98,201,140,198,26,103,223,65,170,135,170,166,207,221,134,139,102,36,128,184,103,73,193,64,138,143,36,189,135,51,200,253,9,95,215,222,241,49,97,12,147,2,114,201,23,56,108,16,30,37,163,207,195,241,243,227,209,231,189,241,156,224,187,235,107,250,124,48,186,14,174,119,198,81,120,124,148,1,220,112,244,89,124,239,70,161,222,224,56,187,209,241,48,56,236,102,241,49,33,44,201,207,21,43,161,202,0,40,130,136,132,13,53,91,206,174,198,86,114,187,190,62,222,226,28,143,143,190,86,152,60,220,72,218,67,88,150,251,124,243,24,118,239,72,50,203,193,152,55,233,116,184,101,4,229,59,96,166,161,144,115,24,173,18,83,58,179,17,112,244,249,229,120,247,229,254,190,32,49,21,123,195,81,178,247,223,147,189,255,28,236,253,99,108,127,238,221,140,31,95,244,255,254,98,233,46,197,227,199,131,254,50,10,1,125,21,79,48,226,219,228,22,103,220,2,163,227,237,113,88,177,252,134,138,112,249,193,127,78,148,175,139,143,92,4,136,248,9,184,242,199,68,122,112,52,208,92,106,78,217,234,19,194,141,228,182,118,169,118,217,68,160,156,79,141,136,60,120,110,48,95,188,33,233,116,45,207,119,152,205,203,105,221,11,235,161,32,99,129,96,0,160,72,42,26,101,41,101,177,1,222,175,67,31,45,18,146,228,168,128,250,59,8,36,10,13,134,23,82,124,17,71,106,49,156,226,44,205,83,200,177,114,121,167,191,131,32,222,118,14,119,162,163,125,65,196,210,148,169,145,14,223,2,111,84,222,105,18,71,251,122,67,232,139,148,12,202,51,208,83,233,153,67,31,41,159,68,111,48,147,94,196,87,67,165,78,69,71,103,224,251,132,160,133,212,48,168,84,194,196,191,149,36,79,88,24,124,126,60,88,254,18,244,125,151,140,14,13,34,84,245,42,227,105,44,188,35,101,174,181,5,127,20,147,248,98,145,165,44,132,244,62,26,67,37,130,227,246,249,97,209,50,146,41,174,215,67,80,153,120,131,129,160,85,192,223,161,65,97,147,57,6,61,9,252,248,146,164,121,24,245,181,128,125,9,245,97,33,251,145,243,89,81,18,124,154,80,108,200,1,189,180,96,37,202,57,29,41,174,229,244,109,142,9,118,183,160,187,169,120,22,30,160,23,13,121,28,176,209,193,56,126,67,202,106,65,71,202,186,193,56,254,87,146,85,56,138,47,75,161,91,165,19,85,206,164,90,116,122,238,116,178,79,210,144,72,24,30,220,141,104,143,231,57,184,34,153,244,17,8,171,61,157,130,55,242,63,40,162,193,80,148,82,141,47,82,120,167,131,185,126,42,64,48,136,66,181,16,107,252,77,73,12,158,6,241,249,145,99,75,114,161,46,231,92,28,237,107,10,184,82,144,77,127,179,233,102,0,158,183,109,179,204,224,241,133,252,212,25,104,240,248,235,50,80,133,146,179,104,212,117,189,232,149,113,189,168,107,182,50,91,122,23,62,83,146,156,211,247,85,150,125,32,103,249,130,61,132,26,158,87,239,72,159,162,103,228,223,133,28,180,173,243,223,32,64,187,200,69,144,180,151,155,113,80,165,127,21,19,149,91,61,62,10,205,101,165,124,80,227,255,143,188,176,132,188,60,75,88,73,30,140,67,109,234,144,166,197,249,116,62,13,134,182,67,132,207,255,183,79,190,114,88,187,206,9,57,2,185,98,117,59,104,71,241,217,245,208,33,11,40,194,126,30,216,216,6,91,206,127,168,246,15,242,214,13,168,200,11,226,215,147,11,147,199,96,171,97,3,23,199,109,58,235,136,171,49,245,217,53,214,158,123,66,43,252,58,42,5,173,110,233,132,164,183,248,93,50,33,37,61,201,82,200,247,230,16,142,56,168,190,96,213,209,233,102,79,85,245,26,199,123,157,138,73,25,88,170,18,172,103,31,81,138,121,191,73,33,211,125,194,160,210,9,14,189,82,173,140,211,58,44,245,229,196,91,201,241,7,213,156,84,165,54,181,74,240,215,42,37,98,134,147,187,232,252,172,168,114,76,146,219,12,27,110,93,106,117,155,130,249,3,52,243,188,205,230,51,22,31,208,186,79,167,221,30,194,19,39,147,121,40,170,184,172,160,162,201,134,134,192,47,239,254,233,156,214,191,187,194,155,196,200,101,203,228,148,96,56,152,242,204,55,116,113,150,50,245,188,240,82,63,251,53,91,235,191,172,165,37,174,208,123,74,121,244,127,231,109,216,160,118,142,76,136,92,107,158,187,207,160,250,141,33,58,64,63,126,160,103,210,160,135,30,43,147,177,206,167,155,177,116,211,210,166,156,91,43,81,221,115,34,95,176,43,235,50,194,89,64,48,46,10,191,96,98,162,181,13,158,255,184,122,127,113,245,234,101,160,49,181,59,40,215,76,4,26,248,194,58,239,19,229,210,39,46,112,173,15,0,68,155,64,140,24,171,131,220,192,252,139,254,146,165,81,255,3,228,91,240,65,49,161,99,235,237,237,22,115,56,34,240,114,156,22,134,161,74,239,158,191,213,19,139,163,80,25,239,210,168,83,95,116,238,224,78,247,185,218,3,36,76,183,225,15,205,137,195,214,198,247,32,130,115,171,19,133,207,116,219,126,82,60,168,22,28,13,134,155,181,194,241,217,215,42,201,116,231,222,71,178,32,158,150,208,104,145,148,150,69,252,129,76,211,34,201,220,144,118,180,89,215,199,29,208,90,165,90,55,148,213,7,218,114,114,182,85,186,179,108,116,97,115,155,113,177,223,241,67,104,243,137,45,232,27,88,220,24,140,163,190,198,64,46,163,13,171,181,209,238,183,93,73,108,98,203,58,55,103,144,177,226,174,236,43,172,58,116,229,16,215,25,170,239,26,52,206,227,26,222,189,248,168,37,91,157,45,56,230,233,60,41,102,13,99,138,86,184,37,176,108,104,159,23,20,19,246,135,21,7,82,211,157,43,94,191,81,229,162,90,156,43,38,110,44,123,14,246,52,110,85,23,151,86,13,215,131,222,237,117,124,141,203,49,81,221,120,213,38,33,24,127,142,97,230,129,41,231,241,111,102,208,233,245,86,153,69,92,96,105,123,24,12,247,36,155,80,113,238,173,26,180,86,225,225,194,192,27,61,57,97,118,50,157,118,132,128,213,66,100,3,171,62,205,88,74,155,247,210,166,194,95,105,3,160,150,32,64,87,159,222,110,218,65,59,186,108,52,195,146,210,147,90,98,191,179,92,129,56,45,223,151,236,156,251,169,68,117,189,206,59,111,103,79,223,218,240,54,59,241,149,221,237,125,153,78,81,123,184,52,83,72,163,77,213,33,215,57,9,59,200,54,231,250,73,169,25,35,219,16,35,38,58,106,29,177,139,28,95,240,224,160,255,134,121,50,12,142,131,8,29,35,111,23,58,1,121,154,23,125,111,227,45,46,102,48,130,238,241,188,250,210,221,81,190,186,68,24,82,91,187,180,222,244,39,221,121,185,233,5,165,115,37,218,234,228,39,139,5,208,160,98,22,119,230,99,86,34,54,199,72,92,137,154,17,226,105,23,71,234,201,132,127,240,91,71,159,65,188,210,77,253,65,31,254,226,4,184,60,38,217,255,197,89,207,62,66,106,138,137,220,18,18,90,52,168,90,28,175,41,165,246,235,51,79,49,246,126,204,59,161,23,4,222,219,151,189,88,112,223,102,184,83,233,222,223,187,246,234,163,250,61,131,242,204,191,50,146,121,53,163,246,52,36,110,131,220,53,233,114,109,3,38,64,251,183,194,2,87,61,156,41,167,110,222,130,52,175,247,196,181,222,161,47,153,95,147,37,90,215,13,140,119,251,34,233,172,152,158,189,89,180,101,148,54,211,115,67,19,106,201,123,58,52,121,162,101,90,238,52,131,119,177,227,22,182,217,12,162,23,184,133,77,211,40,126,225,164,34,132,191,235,89,188,136,247,213,106,57,214,167,48,187,49,52,163,14,176,170,170,145,45,125,43,46,243,242,242,30,55,242,130,184,157,175,72,182,105,42,0,208,96,120,5,240,157,145,36,55,215,134,138,148,7,212,251,27,72,112,69,82,61,11,2,3,237,216,176,10,159,169,189,137,133,133,248,146,60,200,39,152,16,32,251,8,150,126,79,139,105,124,114,75,203,172,98,96,213,178,98,28,203,86,10,125,229,70,50,247,50,212,45,76,60,37,3,105,81,187,12,183,139,206,82,180,142,244,100,14,109,63,229,239,27,252,206,116,128,118,182,119,14,27,60,47,228,131,177,248,237,84,153,131,62,20,20,23,122,52,150,48,31,173,205,6,78,77,113,11,84,100,31,85,16,151,65,188,172,24,57,150,122,242,18,64,122,136,144,102,16,135,59,43,96,27,215,66,29,106,253,4,83,138,167,127,40,69,169,74,43,48,252,187,29,247,116,70,90,62,213,215,228,55,218,3,37,251,91,110,45,110,191,199,224,51,41,234,70,114,159,9,2,103,126,237,173,65,49,111,7,193,38,12,228,157,254,83,200,235,251,249,77,168,171,103,141,96,229,120,169,39,153,86,39,245,109,230,208,169,25,115,119,96,188,195,167,220,132,243,101,174,191,95,60,73,138,134,71,217,112,216,173,185,91,219,227,5,196,233,7,146,206,248,133,129,98,171,147,164,160,211,175,145,136,220,169,160,214,93,53,255,231,8,88,249,19,177,171,248,203,43,37,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("3e02aad0-4fd4-4d2f-85a6-43398aa0ca6e"));
		}

		#endregion

	}

	#endregion

}
