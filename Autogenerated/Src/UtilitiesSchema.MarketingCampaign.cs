﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: UtilitiesSchema

	/// <exclude/>
	public class UtilitiesSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public UtilitiesSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public UtilitiesSchema(UtilitiesSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("6501047e-99ba-4b64-a8a7-e8a246c360a7");
			Name = "Utilities";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("8ff9fe4f-03be-4db5-b64a-71abfee30f54");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,205,89,91,111,219,58,18,126,206,1,206,127,32,124,30,86,70,2,37,221,151,197,54,177,23,105,46,7,1,146,180,167,113,119,31,138,34,160,37,218,230,86,183,67,82,73,189,139,252,247,157,225,77,148,108,217,74,183,123,1,138,198,162,56,195,185,126,51,67,21,52,103,178,162,9,35,51,38,4,149,229,66,197,23,101,177,224,203,90,80,197,203,34,190,163,226,43,83,188,88,198,159,20,207,184,226,76,254,252,211,63,127,254,233,160,150,176,72,30,214,82,177,252,180,243,28,207,216,55,181,185,184,18,140,166,176,176,241,230,162,204,50,150,224,121,50,254,149,21,76,240,100,99,207,37,167,203,162,148,138,39,114,227,221,45,47,126,111,22,67,85,4,235,91,143,47,223,193,43,120,249,139,96,75,56,153,92,100,84,202,183,228,166,144,76,168,119,53,207,82,38,244,134,227,227,99,114,38,235,60,167,98,61,181,207,31,89,37,152,100,133,146,36,175,51,197,171,140,17,81,62,19,174,169,201,239,53,19,107,50,55,76,72,130,156,99,199,233,56,96,85,213,243,140,39,102,67,247,228,3,180,114,35,29,216,70,81,56,239,45,249,32,248,19,85,76,203,118,144,224,58,28,171,200,157,145,99,109,216,124,44,159,229,45,207,185,34,19,242,230,228,228,196,232,122,240,11,43,82,195,209,62,91,246,215,156,101,105,151,119,101,30,8,186,173,44,178,53,249,4,156,65,144,194,248,138,60,214,173,231,211,30,170,7,37,192,252,86,47,242,168,109,227,158,38,164,96,207,237,29,209,184,143,145,212,219,200,35,47,32,14,105,198,255,161,67,212,16,3,39,243,58,190,202,43,181,222,199,226,137,102,53,147,215,165,200,169,26,194,0,13,252,152,148,117,161,152,216,99,74,237,41,81,39,170,20,104,80,237,97,179,163,27,72,122,225,6,148,145,218,10,92,123,24,114,177,92,16,181,98,77,216,108,198,141,89,169,168,160,57,41,32,135,39,163,182,43,70,83,116,21,73,26,95,57,230,241,217,177,38,219,206,5,45,251,87,52,205,104,122,99,140,236,44,6,50,105,199,237,166,223,52,235,104,58,99,121,149,161,13,23,165,0,49,170,90,17,77,194,192,148,178,197,206,102,67,43,15,162,78,204,181,245,60,114,226,121,193,253,202,166,40,99,162,51,234,160,19,182,224,248,141,56,198,93,61,81,230,79,178,219,182,70,210,230,162,222,253,178,59,114,238,152,90,149,233,144,160,185,250,198,146,90,49,233,240,6,188,3,232,35,137,42,9,216,183,39,102,172,121,159,74,158,58,6,198,212,145,179,12,95,144,200,69,57,153,146,19,183,110,1,52,122,162,130,164,115,67,91,98,242,118,76,25,95,21,178,22,236,242,93,179,20,141,61,147,131,134,52,182,231,71,45,52,136,103,165,49,22,16,25,235,162,197,240,143,23,106,66,78,236,155,54,229,69,198,168,65,14,71,244,178,195,124,231,105,42,53,92,63,115,181,34,73,45,4,32,121,24,149,3,147,174,161,24,77,63,248,223,46,127,225,128,109,225,173,237,239,65,58,210,239,129,102,254,119,48,216,231,47,129,20,91,189,50,153,4,110,105,219,224,188,170,32,176,162,173,129,235,44,67,88,38,217,78,242,17,249,116,127,243,254,158,156,223,222,146,81,104,80,239,132,195,67,27,250,91,200,77,200,71,91,178,226,40,212,236,116,171,98,61,21,204,171,219,9,218,129,206,254,200,84,45,10,73,30,126,187,181,16,182,195,187,194,108,158,250,205,214,139,110,61,240,163,197,153,95,153,250,13,55,186,200,181,194,218,183,134,199,132,244,197,185,209,193,112,183,101,48,190,145,247,117,150,189,23,186,14,69,154,112,76,254,210,170,78,228,173,229,124,72,70,167,35,135,45,109,100,177,70,233,128,77,167,219,9,154,186,158,78,7,82,89,81,128,25,82,235,173,107,146,27,148,194,40,135,206,241,43,93,50,226,155,196,11,154,87,148,47,139,93,205,14,212,33,229,123,158,224,124,236,119,190,15,13,239,232,87,128,194,132,102,25,10,101,74,204,162,46,12,186,63,175,56,244,102,73,9,57,158,40,194,116,8,225,58,236,108,246,112,32,157,51,178,162,58,136,29,95,128,184,162,206,231,16,156,176,153,125,75,88,165,91,84,191,189,124,130,87,43,104,45,134,226,133,59,112,52,189,118,71,3,98,27,153,246,84,102,170,160,209,173,148,188,192,116,25,77,239,189,92,246,69,155,151,87,109,55,83,197,115,86,214,192,110,6,63,8,252,2,107,49,224,3,129,245,106,94,208,14,67,250,98,223,208,50,127,99,112,179,97,147,137,75,173,235,29,36,91,211,79,135,209,188,44,51,50,19,107,139,13,103,179,105,132,140,224,175,151,225,72,119,111,45,3,154,37,171,254,145,214,220,0,176,61,210,101,49,182,44,17,110,229,216,70,159,194,159,179,73,155,19,172,29,30,122,132,66,203,185,106,103,56,1,157,147,195,101,187,207,119,232,18,153,171,115,16,190,42,89,121,98,132,70,56,172,125,86,83,73,15,204,44,21,63,100,140,85,145,213,195,179,127,9,107,231,139,69,24,43,76,1,208,210,2,157,5,133,138,16,118,39,255,133,12,99,97,138,61,83,24,82,222,252,241,132,72,6,253,106,218,164,23,102,28,75,217,171,178,107,127,102,181,195,103,134,229,65,172,223,23,215,148,103,208,186,116,227,199,153,220,26,171,189,57,194,29,71,40,59,252,119,50,254,95,26,17,67,0,53,214,198,252,207,26,112,131,12,207,68,0,121,48,254,11,193,201,46,233,214,31,44,135,245,107,39,43,137,241,236,249,104,84,226,133,15,12,228,146,178,140,194,100,205,212,51,3,164,226,208,57,208,13,108,122,157,139,13,22,116,148,48,139,161,56,46,18,176,7,150,170,172,158,117,190,186,249,213,62,187,20,215,156,42,90,52,108,241,97,66,220,207,248,90,148,185,101,28,117,142,182,44,252,25,241,131,162,77,187,99,226,36,66,232,232,65,29,147,213,160,152,199,155,46,184,180,192,99,171,72,45,197,61,174,32,40,53,98,93,101,180,146,44,133,57,33,84,50,192,40,181,130,222,169,31,147,6,245,108,159,238,238,48,142,92,147,104,218,202,161,241,108,169,32,146,46,44,125,226,47,154,224,76,6,249,38,216,98,50,218,114,199,21,207,214,21,75,45,217,232,120,186,59,108,237,65,247,240,0,209,79,243,102,132,55,47,250,139,222,69,75,49,173,239,206,114,135,81,249,80,231,24,195,106,197,37,185,185,130,14,5,114,96,158,65,92,7,34,195,134,169,59,93,250,153,56,144,211,15,23,24,230,117,222,12,86,144,100,140,66,176,68,29,118,222,7,144,144,142,177,119,54,114,56,156,120,117,161,39,142,194,179,194,41,194,6,40,80,156,238,143,130,28,90,44,152,106,81,61,178,128,248,36,151,239,16,237,114,141,164,128,116,76,55,195,16,151,28,175,80,94,131,117,154,231,166,195,244,242,110,103,255,152,155,22,72,224,2,178,146,93,82,69,1,233,236,147,85,149,163,48,160,82,163,85,63,188,233,113,242,82,148,213,12,73,35,235,105,175,222,81,247,210,174,123,129,162,27,168,80,154,22,208,85,13,194,9,150,126,16,101,194,82,172,124,93,46,35,37,171,71,148,226,189,112,186,104,121,220,4,41,171,248,111,48,107,251,33,57,10,28,112,212,72,219,187,155,75,199,22,183,7,210,194,96,244,6,166,161,147,134,210,93,45,140,191,47,190,254,79,3,232,71,58,221,121,184,97,16,80,118,61,171,251,195,253,182,4,18,152,134,148,36,151,232,122,219,141,212,5,255,166,91,19,16,59,175,134,90,54,181,28,108,3,0,124,18,195,188,23,69,245,62,170,58,231,97,191,144,211,221,227,3,194,159,21,221,9,62,43,103,142,67,228,149,113,50,117,250,65,156,13,198,145,123,25,63,212,115,37,104,162,34,76,25,71,27,189,249,243,159,176,65,132,127,227,241,24,102,127,69,51,91,90,135,91,181,163,25,216,196,177,31,28,175,142,120,180,215,92,61,86,190,212,0,133,71,238,178,168,55,153,149,221,27,115,86,122,139,184,225,75,175,119,76,218,103,186,248,60,77,93,123,210,208,238,184,86,29,114,253,17,214,184,33,223,122,20,238,247,149,112,224,119,157,78,33,221,188,233,240,95,158,96,67,65,51,243,146,219,39,255,113,168,192,188,12,152,56,46,205,181,121,179,195,221,42,206,62,127,33,84,44,155,66,253,8,188,248,18,102,7,20,74,2,184,227,91,95,158,13,187,238,55,147,86,143,49,37,109,22,167,29,42,253,161,228,201,222,143,135,226,225,11,125,111,238,68,89,50,213,237,90,61,97,171,85,12,185,104,224,211,74,70,51,148,221,43,166,239,18,91,146,197,238,230,42,194,125,77,95,106,14,113,151,152,91,58,210,127,239,27,217,37,215,192,9,129,112,38,237,197,103,199,119,83,255,37,201,89,239,7,126,74,210,23,191,204,124,80,50,145,227,203,201,118,160,176,134,13,131,212,95,98,122,57,109,23,48,64,183,104,87,74,126,199,221,222,71,32,144,192,219,170,100,79,242,186,220,52,179,129,190,203,199,18,44,177,28,175,168,132,41,17,70,68,154,161,107,214,48,202,34,31,63,51,227,152,92,214,89,138,115,178,96,85,70,161,177,105,88,224,81,101,49,24,91,11,221,6,184,94,30,159,246,92,230,65,210,141,166,231,73,82,130,191,20,127,98,221,1,167,239,179,129,179,134,171,248,133,46,217,61,201,238,189,247,25,183,125,177,62,236,56,44,210,20,123,11,145,185,187,224,5,12,76,57,126,43,193,81,220,7,7,204,164,48,48,208,64,29,59,206,80,193,92,99,19,90,215,92,125,232,61,67,45,12,82,142,166,26,62,122,109,179,5,21,252,44,211,81,58,156,101,188,149,98,205,190,129,74,55,204,24,190,200,245,149,31,28,44,131,63,200,215,169,58,36,152,182,142,143,219,203,50,226,46,206,99,65,196,116,42,110,39,78,226,230,235,230,206,214,4,76,43,48,36,10,22,132,2,206,234,175,64,29,227,56,243,237,174,27,181,173,111,122,195,75,252,203,191,0,92,146,15,228,212,34,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("6501047e-99ba-4b64-a8a7-e8a246c360a7"));
		}

		#endregion

	}

	#endregion

}
