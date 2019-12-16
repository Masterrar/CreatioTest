namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CaseTimeZoneMacrosConverterSchema

	/// <exclude/>
	public class CaseTimeZoneMacrosConverterSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CaseTimeZoneMacrosConverterSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CaseTimeZoneMacrosConverterSchema(CaseTimeZoneMacrosConverterSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("def50b48-4f91-4a9d-ab1b-2977e4e375ae");
			Name = "CaseTimeZoneMacrosConverter";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("33bac096-c819-4c57-86af-fe71bbb0cb56");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,83,77,111,155,64,16,61,19,41,255,97,68,46,88,178,224,238,96,164,214,109,35,14,169,162,124,92,122,219,44,131,179,146,217,69,179,75,42,55,202,127,207,236,2,54,184,169,123,178,103,120,243,222,155,143,213,162,65,219,10,137,240,136,68,194,154,218,165,27,163,107,181,237,72,56,101,244,229,197,219,229,69,212,89,165,183,240,176,183,14,155,235,67,60,45,33,252,87,62,253,33,164,51,164,208,50,130,49,87,132,91,38,134,205,78,88,187,130,141,176,248,168,26,252,101,52,222,10,73,198,178,254,43,146,67,10,240,44,203,32,183,93,211,8,218,23,67,124,143,45,161,69,237,44,200,17,12,181,33,248,38,92,32,131,198,51,73,180,160,116,80,0,6,43,183,79,71,194,108,194,216,118,207,59,37,65,122,63,231,236,172,224,235,57,175,209,91,240,123,236,207,104,235,168,243,189,115,155,119,65,164,71,156,182,20,18,165,86,78,137,157,250,195,166,53,254,102,227,214,9,205,139,49,53,131,17,65,18,214,235,248,140,191,56,43,250,38,210,131,72,118,170,146,183,130,68,3,154,215,190,142,59,139,196,213,26,165,223,116,92,60,113,236,7,58,36,210,60,11,232,207,139,173,124,193,70,252,228,255,113,241,61,12,23,250,84,248,62,171,29,6,124,198,122,242,52,179,2,115,103,75,224,65,250,195,58,106,46,60,111,180,130,103,230,76,254,66,31,97,224,175,55,122,31,54,131,186,234,151,51,223,212,45,186,23,83,249,37,145,113,76,130,85,255,189,29,67,48,108,147,84,197,175,100,240,95,234,218,192,13,186,49,78,110,58,85,13,71,118,143,210,80,85,86,131,120,84,142,32,166,127,101,18,202,253,36,10,104,135,16,214,253,91,232,223,201,62,101,218,124,58,171,177,172,72,2,93,228,175,99,114,92,95,104,219,53,172,156,156,238,115,9,243,169,46,150,255,169,151,44,90,86,92,119,210,71,40,91,92,135,31,66,215,145,62,120,79,167,51,232,33,159,15,187,207,206,147,239,31,205,32,65,250,126,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("def50b48-4f91-4a9d-ab1b-2977e4e375ae"));
		}

		#endregion

	}

	#endregion

}

