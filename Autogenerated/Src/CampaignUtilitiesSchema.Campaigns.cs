namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CampaignUtilitiesSchema

	/// <exclude/>
	public class CampaignUtilitiesSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CampaignUtilitiesSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CampaignUtilitiesSchema(CampaignUtilitiesSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("91f9be1e-5ab9-414b-864c-bdbff6a5ead5");
			Name = "CampaignUtilities";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("99b5f9a8-cf5d-45be-a343-69b2dafeaaa7");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,81,77,107,195,48,12,61,167,208,255,96,154,203,118,73,238,201,182,75,96,99,176,65,161,219,121,168,137,106,12,254,8,178,83,8,35,255,125,114,190,88,74,77,44,172,39,229,189,39,219,130,65,223,66,141,226,11,137,192,187,75,200,42,103,47,74,118,4,65,57,155,85,96,90,80,210,158,144,174,170,198,253,238,119,191,75,58,175,172,20,167,222,7,52,229,154,75,237,206,160,139,162,114,198,240,159,31,78,74,134,99,157,191,148,80,50,159,168,52,120,95,136,133,246,59,40,173,130,66,63,117,181,221,89,171,90,248,192,226,181,168,99,239,221,86,54,193,113,37,125,85,168,27,102,61,146,186,66,192,169,216,78,201,66,70,8,141,179,186,23,239,108,76,252,104,14,207,130,143,159,96,65,34,101,111,24,162,99,164,135,195,205,204,135,199,114,150,67,219,76,138,91,249,35,185,22,41,90,99,11,227,4,83,61,207,115,241,228,59,99,128,250,151,5,72,199,37,230,157,46,169,184,17,205,86,130,252,63,195,246,130,198,81,226,142,143,146,36,18,195,124,74,8,67,71,118,28,179,28,145,33,198,225,238,28,19,186,5,135,63,86,122,189,131,26,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("91f9be1e-5ab9-414b-864c-bdbff6a5ead5"));
		}

		#endregion

	}

	#endregion

}

