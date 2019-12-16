namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SentSinceAndDraftsSyncStrategySchema

	/// <exclude/>
	public class SentSinceAndDraftsSyncStrategySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SentSinceAndDraftsSyncStrategySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SentSinceAndDraftsSyncStrategySchema(SentSinceAndDraftsSyncStrategySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("b6a52f3c-de2d-4d94-bc45-c093e0898f55");
			Name = "SentSinceAndDraftsSyncStrategy";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("50cc600a-f6aa-433b-8a0a-6a453519907c");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,84,193,110,219,48,12,61,167,64,255,129,240,46,29,144,197,59,167,141,129,45,241,161,192,26,116,112,242,1,138,77,123,194,108,201,160,232,161,70,144,127,31,237,56,169,146,165,222,205,162,30,31,223,35,41,27,85,161,171,85,138,176,65,34,229,108,206,179,23,165,203,251,187,253,253,221,164,113,218,20,222,205,210,154,92,23,13,41,214,214,60,222,4,16,126,20,159,197,134,53,107,116,2,16,200,39,194,66,88,96,89,42,231,230,144,160,225,68,155,20,191,153,108,69,42,103,151,180,38,77,88,106,97,209,246,25,97,24,194,147,107,170,74,81,27,157,207,136,144,18,230,139,224,217,79,8,194,8,116,85,151,88,9,175,210,108,205,20,50,44,245,31,36,204,32,39,91,249,169,43,201,249,174,28,102,103,21,87,92,179,83,185,240,186,62,161,28,127,187,211,121,220,6,52,82,3,216,130,195,18,83,6,85,150,96,44,127,17,101,200,114,35,179,112,170,64,55,29,216,92,199,36,96,195,144,9,193,187,10,175,106,221,236,74,157,66,218,181,241,127,229,231,48,238,84,232,246,125,171,207,211,121,37,91,35,113,59,239,190,88,52,99,118,4,92,15,99,112,175,40,253,5,248,86,147,56,233,242,25,101,8,131,244,127,59,56,169,79,164,96,101,50,164,51,113,203,212,237,206,214,56,17,246,226,138,35,231,207,6,169,133,69,4,193,118,189,138,127,196,155,120,5,73,188,222,36,207,235,101,12,251,175,135,224,113,16,142,38,59,106,191,52,34,171,43,204,77,202,150,100,219,94,251,166,141,56,89,18,138,106,231,47,201,120,111,251,133,147,18,74,0,31,152,237,35,181,34,85,129,145,103,183,8,100,27,72,116,25,233,128,72,12,162,173,156,33,61,7,102,79,97,143,190,157,220,181,39,65,102,105,150,11,34,79,103,247,124,119,246,45,241,239,125,113,62,235,176,60,227,214,30,182,23,58,225,82,246,20,250,119,221,130,47,232,115,71,62,153,195,78,86,237,225,26,127,1,132,238,63,51,57,220,28,222,49,234,7,15,127,1,201,29,104,93,176,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b6a52f3c-de2d-4d94-bc45-c093e0898f55"));
		}

		#endregion

	}

	#endregion

}

