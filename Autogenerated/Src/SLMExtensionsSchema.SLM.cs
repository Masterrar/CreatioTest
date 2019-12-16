namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SLMExtensionsSchema

	/// <exclude/>
	public class SLMExtensionsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SLMExtensionsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SLMExtensionsSchema(SLMExtensionsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("7e7af41a-b3ac-4f70-b275-48bf9b53119e");
			Name = "SLMExtensions";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b11d550e-0087-4f53-ae17-fb00d41102cf");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,189,83,193,110,219,48,12,61,187,64,255,129,232,46,105,15,246,189,73,115,201,6,180,192,2,12,168,183,157,85,155,137,133,218,146,33,74,237,130,34,255,62,74,178,236,37,233,90,244,210,163,248,222,227,123,164,105,37,58,164,94,84,8,37,26,35,72,111,108,190,210,106,35,183,206,8,43,181,202,239,191,175,191,253,177,168,136,31,116,126,246,114,126,150,57,146,106,251,63,193,252,61,66,190,18,45,170,90,24,154,168,169,84,202,14,127,42,105,225,230,125,117,158,200,220,134,27,125,49,184,101,28,86,173,32,130,107,56,202,205,140,162,40,96,65,174,235,132,217,45,135,247,125,143,149,220,200,202,211,1,61,223,155,64,135,182,209,53,229,73,85,252,35,235,221,67,203,2,178,156,167,130,42,216,29,153,101,47,193,112,204,180,142,237,56,213,143,32,142,232,113,158,80,224,97,159,208,88,130,202,25,195,105,192,242,148,96,209,116,96,53,216,6,161,210,12,80,175,85,237,55,55,193,207,210,54,208,73,229,44,198,170,227,221,228,163,81,113,236,180,232,133,17,29,40,190,128,155,11,223,225,98,185,74,158,252,90,20,1,159,232,6,173,51,138,150,101,114,204,23,69,170,121,210,225,94,60,171,244,177,134,129,74,189,14,209,104,102,27,73,19,236,27,93,130,191,170,44,123,18,6,120,52,215,250,239,175,240,121,100,205,46,231,129,16,193,241,4,238,106,230,133,36,83,37,18,137,151,81,53,48,11,96,185,235,49,89,100,149,32,60,57,183,252,86,59,115,29,9,201,196,171,184,253,9,53,142,49,63,36,255,18,173,195,20,38,62,174,70,41,111,128,44,13,66,186,83,222,44,233,31,12,138,199,249,91,209,126,107,243,200,31,250,3,9,7,197,103,7,253,42,118,159,186,194,83,216,87,25,228,32,175,165,174,113,35,216,232,48,227,96,248,10,127,63,92,156,63,240,225,42,3,176,31,126,109,54,142,127,119,120,199,234,97,113,255,23,31,83,2,130,93,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("7e7af41a-b3ac-4f70-b275-48bf9b53119e"));
		}

		#endregion

	}

	#endregion

}

