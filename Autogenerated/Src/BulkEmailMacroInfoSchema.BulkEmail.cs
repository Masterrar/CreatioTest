namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: BulkEmailMacroInfoSchema

	/// <exclude/>
	public class BulkEmailMacroInfoSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public BulkEmailMacroInfoSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public BulkEmailMacroInfoSchema(BulkEmailMacroInfoSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("dd908fae-7593-41a7-85f2-5a9b52456b8d");
			Name = "BulkEmailMacroInfo";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("7b5cce97-2e1e-4b17-90ca-f9813022e3eb");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,144,79,107,195,48,12,197,207,45,244,59,8,122,79,118,222,198,160,43,59,236,80,90,178,178,187,234,42,153,169,255,4,73,41,27,165,223,125,142,211,140,50,198,232,69,88,178,127,239,61,43,160,39,105,209,16,108,137,25,37,214,90,44,99,168,109,211,49,170,141,97,54,61,205,166,147,178,44,225,81,58,239,145,191,158,46,125,69,45,147,80,80,1,253,32,216,163,34,152,24,148,209,40,212,145,97,215,185,3,144,71,235,192,163,225,8,71,116,29,129,224,209,134,166,24,85,203,43,217,182,219,57,107,192,56,20,129,231,132,191,244,244,170,135,95,67,29,211,139,20,38,213,201,156,169,73,225,96,195,177,37,86,75,114,15,155,12,15,247,191,243,230,65,214,17,64,103,81,192,217,3,193,106,177,172,214,111,119,197,15,114,29,102,76,35,202,41,47,44,50,118,130,134,244,1,164,47,231,127,188,214,108,27,27,112,252,185,210,103,218,9,71,159,78,190,117,168,116,147,103,78,188,237,217,91,125,43,146,206,233,101,211,177,30,236,111,242,122,207,200,31,62,115,10,251,97,221,185,79,211,243,55,114,27,143,70,54,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("dd908fae-7593-41a7-85f2-5a9b52456b8d"));
		}

		#endregion

	}

	#endregion

}

