namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CESMailingProviderConfigFactorySchema

	/// <exclude/>
	public class CESMailingProviderConfigFactorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CESMailingProviderConfigFactorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CESMailingProviderConfigFactorySchema(CESMailingProviderConfigFactorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("21e2f7e7-ec6e-4ec1-a3d8-235df40381e1");
			Name = "CESMailingProviderConfigFactory";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("bc5abc6e-45a7-497f-b7c0-68ae441d38e3");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,82,95,75,195,48,16,127,222,192,239,112,204,151,9,210,190,207,173,160,69,101,15,130,248,231,3,196,236,90,3,107,82,46,201,68,196,239,238,53,201,182,118,110,8,190,180,228,242,187,223,159,203,105,209,160,109,133,68,120,65,34,97,77,229,178,210,232,74,213,158,132,83,70,159,141,191,206,198,35,111,149,174,7,16,194,171,19,245,236,78,72,103,72,161,101,4,99,206,9,107,38,130,114,45,172,157,65,121,251,252,32,212,154,251,30,201,108,212,10,41,234,197,174,207,208,146,231,57,204,173,111,26,65,159,69,58,39,180,133,6,221,187,89,89,168,12,129,36,100,151,108,65,105,235,132,150,44,10,166,2,247,142,220,143,216,221,87,139,201,242,168,224,36,47,178,173,86,222,19,107,253,219,90,73,144,157,221,191,220,194,12,142,147,239,210,140,190,66,162,221,20,30,162,251,25,60,6,153,120,121,152,55,20,202,46,27,231,73,209,240,72,176,83,238,82,180,223,217,98,165,21,36,26,208,252,244,139,137,183,161,73,163,236,94,123,82,44,123,106,61,165,215,33,140,249,231,121,160,217,179,18,58,79,218,22,79,241,255,95,223,243,124,75,212,49,167,199,56,62,228,52,162,173,229,233,208,36,12,163,93,64,183,200,163,209,70,16,160,174,149,198,107,170,45,44,64,227,7,48,204,58,242,221,155,113,213,55,168,221,244,112,52,151,135,132,87,59,62,185,54,126,117,27,72,153,48,44,122,90,128,236,30,221,252,166,109,140,102,251,88,238,113,197,116,111,162,207,20,131,37,87,39,198,52,77,13,17,156,61,35,109,148,196,235,86,113,95,207,74,239,34,226,195,39,78,55,9,133,250,119,218,80,212,171,184,164,225,28,171,195,34,215,126,0,236,249,107,76,49,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("21e2f7e7-ec6e-4ec1-a3d8-235df40381e1"));
		}

		#endregion

	}

	#endregion

}

