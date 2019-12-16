﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: InvokableMacrosHelperServiceSchema

	/// <exclude/>
	public class InvokableMacrosHelperServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public InvokableMacrosHelperServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public InvokableMacrosHelperServiceSchema(InvokableMacrosHelperServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("5a8d4b76-2842-47b3-95c9-6814c9fbe9c6");
			Name = "InvokableMacrosHelperService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("42d0e60b-8c79-4301-a0b9-ee86b6242c08");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,237,88,73,111,219,70,20,62,43,64,254,195,128,189,80,128,65,223,99,83,65,226,42,137,91,59,49,44,165,6,26,20,197,136,124,178,167,229,162,204,12,29,171,134,255,123,223,108,228,112,209,214,248,212,246,98,88,51,111,127,223,91,56,5,205,65,172,104,2,100,14,156,83,81,46,101,116,86,22,75,118,91,113,42,89,89,188,124,241,248,242,197,168,18,172,184,37,179,181,144,144,159,116,126,71,23,172,248,218,59,156,1,191,103,9,92,150,41,100,91,47,163,55,137,100,247,90,215,118,186,27,88,52,4,190,181,121,238,179,250,55,28,162,105,33,153,100,32,134,8,80,98,195,142,247,63,112,184,69,51,200,89,70,133,120,69,206,139,251,242,79,186,200,224,146,38,188,20,31,32,91,1,183,38,105,250,227,227,99,114,42,170,60,167,124,61,177,191,13,45,185,211,196,68,24,106,242,237,142,37,119,164,18,32,144,1,128,36,28,150,113,48,168,32,56,158,68,78,246,177,39,252,139,213,140,217,145,156,38,242,55,117,246,70,172,62,130,68,31,86,24,192,5,203,152,92,95,195,215,138,113,200,161,144,34,244,127,168,40,146,152,236,96,81,84,145,61,72,199,74,201,170,90,100,44,33,137,10,202,214,152,144,87,228,45,21,80,71,104,244,168,163,180,35,172,202,31,202,10,224,134,184,27,83,125,112,13,43,14,66,153,71,18,71,110,99,42,36,102,89,144,148,74,74,150,37,39,185,137,255,138,151,9,8,149,239,168,150,234,71,115,132,4,18,18,9,233,176,99,158,85,35,231,71,237,200,21,47,209,107,133,170,87,228,74,71,199,18,244,140,215,39,115,200,87,25,149,64,36,60,200,168,33,108,217,227,194,44,36,55,32,53,60,115,100,33,143,228,22,228,9,130,9,255,60,237,163,72,84,139,63,208,185,3,117,205,12,215,222,234,116,105,173,17,228,201,29,228,148,20,216,74,246,212,104,56,103,154,239,35,178,29,168,146,176,20,177,192,150,12,248,46,133,239,43,150,90,174,243,116,111,53,23,180,184,173,232,45,28,170,200,241,253,19,85,137,42,188,253,194,231,120,206,84,69,119,20,25,160,66,145,26,172,154,3,123,222,61,174,11,179,44,132,164,88,93,8,103,174,122,49,108,169,197,105,78,89,134,80,182,80,3,147,145,46,6,134,10,78,75,86,5,44,100,13,4,37,172,198,95,131,135,152,4,173,171,224,100,163,136,51,213,114,90,156,234,36,56,217,238,242,166,18,118,42,148,140,57,203,225,215,178,104,58,194,61,114,96,227,249,61,113,255,158,108,140,146,226,39,18,5,144,191,80,2,169,57,54,5,199,228,119,155,86,119,222,156,60,234,92,99,246,73,60,241,140,34,175,95,147,208,251,25,147,2,190,109,19,29,126,198,49,133,191,10,44,126,140,205,81,39,164,227,241,201,30,24,186,4,121,87,166,26,65,182,177,154,251,47,159,22,162,204,64,66,24,160,26,242,30,228,53,46,28,152,64,184,97,242,238,3,45,210,12,82,99,16,182,113,134,137,5,154,70,129,158,60,94,147,30,24,55,78,142,47,243,179,234,248,62,109,104,81,162,90,175,3,211,145,131,142,109,147,71,58,142,246,12,58,173,233,200,84,54,135,164,228,233,121,106,127,102,77,161,199,36,133,37,173,50,25,170,155,113,45,60,243,139,20,115,80,101,217,216,166,236,158,114,20,104,173,55,233,217,226,95,104,226,175,185,114,143,204,114,14,78,100,236,10,237,164,34,113,231,224,201,72,53,92,211,7,137,121,133,180,41,11,2,253,35,227,133,225,147,124,109,189,25,177,37,9,155,128,68,231,226,99,41,167,249,74,174,195,177,243,120,52,26,22,87,123,62,96,192,163,223,78,99,63,228,214,244,209,83,163,191,155,54,18,199,93,24,215,166,248,88,64,193,189,194,194,245,7,239,18,248,81,205,95,188,116,232,12,27,16,180,225,228,167,122,220,182,173,163,203,207,95,132,184,157,123,215,97,91,104,31,136,181,250,141,33,117,202,45,4,237,18,4,169,155,236,59,12,112,245,240,93,186,29,176,163,121,219,117,223,187,46,169,181,207,163,238,154,222,231,72,212,189,146,203,43,43,239,137,36,84,226,74,24,78,31,18,88,105,144,55,89,175,57,155,203,152,12,24,226,196,46,105,38,156,92,253,151,131,172,120,81,215,173,223,19,15,110,83,3,173,47,220,180,128,54,27,239,191,169,125,12,180,101,188,175,93,141,252,253,215,112,168,42,111,238,47,118,244,155,239,110,55,67,170,156,211,79,67,29,16,205,0,72,109,235,168,179,218,36,239,25,250,79,99,147,219,104,59,157,200,42,24,245,141,127,214,214,212,181,195,107,20,214,130,33,75,159,189,93,245,209,50,243,7,122,223,10,191,161,29,102,225,127,186,169,221,51,46,43,154,145,69,89,102,100,24,230,251,55,47,171,113,115,106,250,147,251,176,245,211,91,230,7,55,115,68,145,104,50,209,124,200,212,31,231,253,237,92,159,172,40,167,185,254,192,137,131,238,124,12,38,211,254,103,208,233,177,102,25,150,224,230,105,48,185,214,255,249,95,154,91,25,125,196,5,19,253,60,224,92,232,51,154,96,139,201,213,6,119,79,143,29,133,89,213,17,245,250,33,206,127,99,26,125,185,129,133,206,47,132,38,202,234,27,235,234,211,108,30,28,17,245,80,4,66,190,43,121,78,85,189,34,233,37,42,194,134,99,142,162,159,132,250,160,120,91,166,235,153,92,103,208,34,169,79,163,27,78,87,43,176,203,133,27,92,219,133,218,15,4,243,221,180,99,236,182,151,156,13,123,190,214,221,217,245,7,166,84,7,199,59,134,250,192,132,109,106,195,22,113,235,169,39,30,106,232,221,7,154,216,26,22,233,169,103,137,250,117,180,193,199,81,253,28,18,215,174,154,150,208,250,208,219,167,120,114,252,236,97,110,251,213,150,147,37,47,243,6,145,123,214,19,55,48,10,38,238,37,209,30,252,143,232,13,136,190,84,129,119,179,189,5,239,65,70,237,146,11,170,191,70,230,74,134,138,13,66,229,29,134,167,196,157,198,238,73,253,155,206,59,129,183,87,38,134,238,103,166,103,118,159,83,141,238,179,154,38,116,217,53,64,52,243,120,195,75,144,85,98,219,171,108,175,138,70,156,39,188,150,236,4,169,34,110,107,59,79,61,187,101,119,154,91,216,170,158,177,198,244,157,149,89,149,23,191,208,172,130,83,83,114,147,48,80,73,14,60,33,162,55,231,247,147,99,171,57,232,196,209,244,134,193,229,252,121,90,71,219,220,205,221,99,32,75,3,253,163,29,91,75,113,209,126,251,216,47,30,62,83,48,54,29,169,89,253,219,216,83,146,206,197,59,160,88,235,48,45,84,136,82,253,192,100,2,245,38,77,153,34,163,217,149,106,31,128,75,181,8,154,13,124,112,183,223,97,166,154,12,158,145,56,185,155,221,112,159,73,208,44,66,3,251,215,97,188,3,171,144,61,107,111,71,79,127,3,152,118,239,93,221,27,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5a8d4b76-2842-47b3-95c9-6814c9fbe9c6"));
		}

		#endregion

	}

	#endregion

}
