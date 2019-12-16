namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CESMailingProviderConfigSchema

	/// <exclude/>
	public class CESMailingProviderConfigSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CESMailingProviderConfigSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CESMailingProviderConfigSchema(CESMailingProviderConfigSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("3b30ba11-e71d-45a7-abb8-9df39c11c6f4");
			Name = "CESMailingProviderConfig";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("bc5abc6e-45a7-497f-b7c0-68ae441d38e3");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,82,77,107,195,48,12,61,39,208,255,32,218,123,114,111,187,66,105,55,232,97,80,72,255,128,230,40,153,33,177,141,63,10,37,236,191,207,181,147,210,21,188,49,182,155,244,244,36,189,39,91,96,79,70,33,35,56,145,214,104,100,99,139,157,20,13,111,157,70,203,165,152,229,195,44,207,156,225,162,77,81,138,221,115,181,154,229,158,182,208,212,122,0,88,135,198,44,193,227,175,200,59,223,122,212,242,204,107,210,177,47,112,203,178,132,181,113,125,143,250,178,25,243,145,102,128,5,30,200,6,236,59,65,31,135,128,26,167,20,83,123,121,215,175,220,91,199,89,92,157,220,12,75,56,36,36,101,67,144,117,243,224,235,138,180,229,228,141,28,195,236,88,127,212,29,128,131,48,22,133,191,226,168,120,109,136,128,105,106,158,230,211,190,19,245,170,67,75,47,200,172,212,151,121,185,41,110,227,238,125,76,70,18,125,240,152,95,159,39,203,90,178,171,16,152,49,248,248,155,218,173,171,57,121,202,30,45,86,210,105,246,107,221,201,9,144,174,12,240,191,102,252,55,216,42,254,179,228,200,131,138,244,153,51,186,134,223,95,117,65,162,142,223,36,228,17,253,10,122,236,19,75,8,122,186,92,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("3b30ba11-e71d-45a7-abb8-9df39c11c6f4"));
		}

		#endregion

	}

	#endregion

}

