namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: GoogleOAuthClientSchema

	/// <exclude/>
	public class GoogleOAuthClientSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public GoogleOAuthClientSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public GoogleOAuthClientSchema(GoogleOAuthClientSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("d3c16520-2979-4ffd-92ac-fac71311fb0b");
			Name = "GoogleOAuthClient";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("50cc600a-f6aa-433b-8a0a-6a453519907c");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,82,77,107,195,48,12,61,55,144,255,32,114,234,96,216,247,54,13,148,30,202,96,99,208,110,236,236,186,106,102,72,236,224,143,142,50,246,223,167,184,105,151,126,14,98,18,73,239,61,73,47,14,78,233,18,150,59,231,177,30,167,73,232,133,108,137,118,171,36,190,152,53,86,247,106,108,42,189,218,10,175,140,190,11,251,192,213,177,254,134,214,10,103,54,158,205,140,197,43,233,165,145,74,84,236,117,26,252,39,149,211,68,139,26,93,35,36,158,112,245,70,149,193,198,222,105,242,157,38,3,206,57,228,46,212,181,176,187,162,139,23,216,88,116,168,189,3,161,97,110,76,89,33,68,101,144,149,162,60,59,16,121,143,217,132,85,165,36,33,132,115,29,41,114,102,145,2,35,232,69,4,111,155,95,116,143,9,154,210,121,27,164,55,150,29,65,252,28,149,55,194,138,26,218,53,39,89,112,104,159,77,169,116,86,228,60,22,34,174,27,233,98,152,33,233,183,246,29,105,143,240,78,159,212,88,163,108,189,137,149,191,240,1,90,181,193,8,86,194,225,176,199,58,135,197,165,126,90,251,111,236,182,64,31,172,38,95,105,22,26,68,73,65,91,194,134,14,197,183,172,190,229,128,221,139,21,185,67,4,105,113,51,201,174,95,8,246,20,95,211,126,211,140,23,160,200,104,161,37,178,156,31,180,162,109,214,120,218,8,215,96,182,164,167,214,8,87,4,96,142,254,36,49,252,199,195,104,206,96,223,8,52,126,245,255,203,169,208,25,115,220,185,218,30,122,126,1,62,106,129,34,132,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d3c16520-2979-4ffd-92ac-fac71311fb0b"));
		}

		#endregion

	}

	#endregion

}

