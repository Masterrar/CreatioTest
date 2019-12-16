namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CaseLanguageIteratorSchema

	/// <exclude/>
	public class CaseLanguageIteratorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CaseLanguageIteratorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CaseLanguageIteratorSchema(CaseLanguageIteratorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("2765b5d5-b370-4bb8-88bf-c51f5ee29ecf");
			Name = "CaseLanguageIterator";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("33bac096-c819-4c57-86af-fe71bbb0cb56");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,82,77,107,195,48,12,61,167,208,255,32,178,75,11,37,185,247,235,208,238,82,216,96,108,235,105,236,224,122,74,48,56,118,240,7,91,55,242,223,39,187,105,155,118,97,99,135,16,36,189,247,244,36,75,177,10,109,205,56,194,51,26,195,172,46,92,182,214,170,16,165,55,204,9,173,134,131,175,225,32,241,86,168,242,2,98,112,54,28,80,229,198,96,73,48,88,75,102,237,20,214,204,226,29,83,165,103,37,110,28,146,134,54,17,151,231,57,204,173,175,42,102,246,203,54,62,2,160,160,79,10,235,66,147,221,30,56,137,128,108,85,108,118,100,231,29,122,237,119,82,112,224,161,107,111,83,152,194,170,215,75,18,230,57,219,214,202,58,227,57,149,200,253,67,84,141,126,127,24,62,56,86,194,9,38,197,39,90,80,248,14,130,216,76,209,246,116,65,96,68,224,6,139,69,218,103,40,205,151,25,156,132,243,107,229,121,205,12,171,64,209,123,44,82,111,209,144,51,133,60,60,65,186,220,82,12,252,148,200,230,121,68,71,114,187,137,190,150,163,237,133,14,92,202,142,3,59,153,194,142,152,163,171,18,196,37,37,71,193,71,47,105,224,69,28,121,211,77,190,188,182,200,36,148,110,177,96,94,58,210,113,140,187,46,238,202,201,4,226,138,210,241,228,76,190,103,66,174,244,199,47,172,46,154,90,61,249,186,214,198,253,139,19,236,253,141,110,102,225,215,132,59,136,183,130,234,237,112,46,49,110,14,119,127,145,108,190,1,127,207,157,190,72,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("2765b5d5-b370-4bb8-88bf-c51f5ee29ecf"));
		}

		#endregion

	}

	#endregion

}

