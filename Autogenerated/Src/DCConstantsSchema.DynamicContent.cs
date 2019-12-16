namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: DCConstantsSchema

	/// <exclude/>
	public class DCConstantsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public DCConstantsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public DCConstantsSchema(DCConstantsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("b71266ae-26dd-4d4b-bb2e-0ecca246e43c");
			Name = "DCConstants";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("ad993b20-8db8-48d6-9762-5a83fb4975c6");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,93,145,193,110,194,48,12,134,207,32,241,14,22,187,108,135,182,176,149,49,193,54,137,182,48,237,134,52,94,192,180,46,68,106,211,42,113,135,42,196,187,47,73,25,2,78,145,127,59,255,255,57,145,88,146,174,49,37,216,144,82,168,171,156,253,184,146,185,216,53,10,89,84,210,79,90,137,165,72,141,200,36,121,208,63,14,250,189,70,11,185,131,159,86,51,149,243,65,223,40,15,138,118,102,26,226,2,181,158,65,18,155,121,205,40,89,187,118,16,4,240,174,155,178,68,213,126,158,107,235,136,66,106,72,207,163,240,139,69,67,26,242,74,65,214,165,218,158,141,133,92,85,165,45,44,152,227,130,76,164,246,68,37,72,251,255,17,193,85,70,221,108,11,227,96,172,217,26,89,176,91,174,222,209,177,93,216,215,170,170,73,177,241,155,193,218,93,238,250,247,240,78,72,226,5,179,18,219,134,9,114,81,48,41,224,182,38,16,25,28,246,34,221,67,70,58,53,125,179,143,38,84,86,64,70,67,163,236,211,161,238,150,245,47,254,215,228,119,232,138,48,171,100,209,194,87,99,220,175,130,87,46,119,99,98,191,51,248,0,73,7,55,242,56,76,150,139,101,148,132,19,111,25,143,87,94,184,154,68,94,52,138,98,111,57,125,13,167,163,201,248,237,249,37,28,62,205,207,235,147,204,186,23,112,245,169,251,207,27,241,244,7,240,98,81,111,39,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b71266ae-26dd-4d4b-bb2e-0ecca246e43c"));
		}

		#endregion

	}

	#endregion

}

