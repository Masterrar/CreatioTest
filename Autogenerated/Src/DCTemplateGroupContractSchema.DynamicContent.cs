namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: DCTemplateGroupContractSchema

	/// <exclude/>
	public class DCTemplateGroupContractSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public DCTemplateGroupContractSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public DCTemplateGroupContractSchema(DCTemplateGroupContractSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("2a052ae9-b9e1-450f-b270-7e2a8392c61d");
			Name = "DCTemplateGroupContract";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("e81fdc99-2bd3-4785-b2cd-a2accfc6f9a3");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,83,193,110,226,48,16,61,83,169,255,48,75,47,32,173,146,59,52,244,0,82,197,129,221,170,237,158,86,61,152,120,66,188,74,156,212,30,151,178,136,127,223,177,67,32,69,160,229,146,137,39,51,111,222,27,191,104,81,162,173,69,138,240,138,198,8,91,101,20,77,43,157,169,149,51,130,84,165,163,217,70,139,82,165,156,36,212,20,205,4,9,255,110,68,74,183,55,219,219,155,158,179,74,175,224,101,99,9,203,241,201,57,122,118,154,84,137,209,11,26,37,10,245,55,96,30,171,174,28,186,168,36,22,150,219,184,241,206,224,138,75,96,90,8,107,71,48,155,190,98,89,23,130,240,209,84,174,62,82,227,210,56,142,225,222,186,178,20,102,51,217,159,67,27,80,5,6,107,131,150,209,65,178,36,72,247,141,144,85,134,155,16,33,53,152,37,253,19,252,126,60,1,238,81,180,137,218,1,113,103,194,239,238,122,222,56,81,187,101,161,82,72,195,212,139,92,123,219,192,247,160,237,201,84,53,26,82,200,2,159,2,66,243,253,84,80,72,252,210,234,221,33,40,233,121,101,10,77,116,40,237,82,107,184,45,176,92,162,241,204,90,106,143,78,73,152,75,216,194,10,105,12,214,63,118,87,140,211,18,63,97,173,40,87,26,40,71,160,189,180,255,79,31,204,237,51,190,59,101,80,66,2,100,28,14,187,132,20,95,201,60,160,159,161,116,135,90,54,75,250,186,177,5,82,94,201,107,214,245,243,131,61,199,203,178,128,159,53,151,42,242,119,255,225,215,205,134,100,99,92,190,252,96,67,239,0,218,212,71,157,211,166,219,130,118,69,225,1,124,188,176,133,144,169,133,17,37,176,193,49,233,183,182,235,79,218,73,71,39,86,203,63,200,97,157,171,52,111,57,162,140,238,227,0,48,233,172,204,18,255,54,233,81,144,119,143,32,54,242,57,1,131,11,54,60,12,30,66,18,192,123,7,38,223,146,32,42,36,123,15,160,113,125,22,25,182,77,69,111,238,47,182,237,142,252,41,1,137,153,112,5,13,188,223,134,240,16,124,23,253,192,181,143,131,33,140,186,245,223,91,156,96,131,46,148,79,52,31,119,77,24,5,102,227,179,238,104,60,243,53,185,251,7,45,171,114,86,242,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("2a052ae9-b9e1-450f-b270-7e2a8392c61d"));
		}

		#endregion

	}

	#endregion

}

