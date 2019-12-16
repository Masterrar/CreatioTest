namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: BulkDeduplicationInfoSchema

	/// <exclude/>
	public class BulkDeduplicationInfoSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public BulkDeduplicationInfoSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public BulkDeduplicationInfoSchema(BulkDeduplicationInfoSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e14ddd74-99f1-4f32-b2b4-b4a8b303f9e2");
			Name = "BulkDeduplicationInfo";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("3066e968-6ad0-45b5-bf2b-b9af469e0d31");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,145,61,79,195,64,12,134,231,68,202,127,176,218,5,150,100,167,192,208,86,72,29,96,104,187,33,134,75,226,68,39,114,119,145,237,27,10,234,127,231,114,9,85,129,10,169,203,201,31,175,237,231,108,171,12,114,175,42,132,61,18,41,118,141,228,43,103,27,221,122,82,162,157,205,215,88,251,190,211,85,244,178,244,51,75,179,52,241,172,109,11,187,3,11,154,124,235,173,104,131,249,14,73,171,78,127,68,229,34,234,230,132,109,112,96,213,41,230,59,88,250,238,253,71,191,141,109,92,20,22,69,1,247,236,141,81,116,120,156,252,65,13,245,185,28,116,212,143,234,226,76,254,186,86,162,2,183,144,170,228,45,4,122,95,134,34,168,134,185,151,199,194,248,147,63,147,99,96,79,30,65,55,191,166,91,39,192,162,72,176,134,18,27,71,152,159,58,156,211,140,56,207,104,74,164,155,151,176,97,120,128,153,230,39,77,44,97,89,179,219,129,240,27,177,116,174,131,205,41,57,96,37,73,210,162,44,162,193,147,113,188,154,86,51,144,183,54,28,234,42,202,237,88,115,17,114,202,253,207,56,190,115,180,245,120,252,224,100,233,241,11,193,1,158,28,105,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e14ddd74-99f1-4f32-b2b4-b4a8b303f9e2"));
		}

		#endregion

	}

	#endregion

}

