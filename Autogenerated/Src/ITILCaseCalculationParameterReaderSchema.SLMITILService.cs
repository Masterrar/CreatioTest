namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ITILCaseCalculationParameterReaderSchema

	/// <exclude/>
	public class ITILCaseCalculationParameterReaderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ITILCaseCalculationParameterReaderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ITILCaseCalculationParameterReaderSchema(ITILCaseCalculationParameterReaderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("b6eb7ae2-e22e-4845-925b-505d5771ca69");
			Name = "ITILCaseCalculationParameterReader";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("5be0374d-f3b5-4c63-b887-7fd46e962c93");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,205,84,77,107,219,64,16,61,43,144,255,48,40,23,7,130,116,247,135,160,184,77,48,184,212,52,238,41,244,176,89,141,156,5,105,87,204,238,186,184,37,255,189,179,43,201,145,219,196,161,183,162,131,216,153,121,111,230,189,29,73,139,6,109,43,36,194,22,137,132,53,149,203,150,70,87,106,231,73,56,101,244,229,197,175,203,139,196,91,165,119,112,127,176,14,27,206,215,53,202,144,180,217,29,106,36,37,103,199,154,49,13,225,91,241,236,86,72,103,72,161,229,138,240,36,121,158,195,220,250,166,17,116,40,250,243,173,161,198,66,43,136,135,116,72,22,42,67,176,20,22,63,105,71,135,141,81,218,13,200,124,4,125,248,178,231,102,170,196,239,124,104,253,99,173,36,200,90,88,11,171,237,106,29,240,75,81,75,95,71,125,155,129,253,43,138,18,105,10,231,243,204,24,252,72,174,8,119,156,5,246,202,58,242,65,140,157,194,38,54,139,122,254,18,20,3,43,173,156,18,181,250,137,22,4,104,252,1,138,241,66,179,255,166,2,247,132,12,65,4,73,88,45,210,247,167,77,243,162,83,150,29,59,142,141,24,196,191,79,52,185,134,40,235,249,255,153,61,70,226,221,131,102,220,34,245,22,137,237,214,221,234,165,197,150,59,134,24,200,99,48,155,231,17,241,143,226,191,157,48,195,105,163,235,192,149,76,225,145,57,38,127,164,78,76,187,66,93,118,91,209,159,251,21,249,140,238,201,148,97,59,200,56,6,98,121,198,228,59,116,80,43,235,130,165,81,74,183,244,242,101,248,115,118,17,58,79,218,22,235,243,12,243,124,40,140,62,13,99,129,233,191,27,248,168,162,62,230,158,243,118,243,231,123,3,221,187,8,3,70,251,236,75,205,176,60,201,25,24,161,245,181,131,69,180,49,123,149,100,22,57,186,194,236,67,89,78,210,123,164,189,146,184,225,127,69,182,42,211,27,24,71,56,240,26,196,183,173,33,183,198,61,214,3,102,20,26,131,130,3,253,92,179,55,174,49,196,158,127,3,154,65,84,202,35,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b6eb7ae2-e22e-4845-925b-505d5771ca69"));
		}

		#endregion

	}

	#endregion

}

