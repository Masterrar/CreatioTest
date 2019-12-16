namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: BulkDuplicatesGroupResponseSchema

	/// <exclude/>
	public class BulkDuplicatesGroupResponseSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public BulkDuplicatesGroupResponseSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public BulkDuplicatesGroupResponseSchema(BulkDuplicatesGroupResponseSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("eb44fa4e-3083-461b-a753-81b61ff52720");
			Name = "BulkDuplicatesGroupResponse";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("3066e968-6ad0-45b5-bf2b-b9af469e0d31");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,146,49,111,194,48,16,133,231,32,241,31,78,176,180,75,178,3,101,40,84,136,129,86,130,110,85,7,39,185,68,110,29,39,242,217,170,210,138,255,222,139,83,160,2,2,237,18,157,237,119,79,239,190,139,22,5,82,37,18,132,103,52,70,80,153,217,112,86,234,76,230,206,8,43,75,221,239,125,245,123,129,35,169,115,216,212,100,177,24,31,157,89,175,20,38,141,152,194,167,248,141,203,85,153,162,58,209,173,157,182,178,192,112,131,70,10,37,63,189,63,171,88,55,52,152,243,1,102,74,16,141,224,222,169,247,7,22,219,122,166,36,106,59,119,149,146,137,176,72,11,83,186,202,183,188,204,133,21,28,213,26,145,216,87,190,168,92,204,34,72,26,139,107,14,48,130,139,254,65,51,116,16,69,17,76,200,21,133,48,245,116,119,177,76,185,65,102,18,13,148,25,228,141,62,220,139,163,223,106,159,112,133,69,140,230,230,145,57,195,29,12,188,126,153,14,110,155,196,187,200,26,63,96,225,100,10,139,246,181,121,242,1,130,28,237,216,23,244,83,108,253,236,237,119,136,58,109,185,117,49,60,154,107,205,171,230,37,225,31,249,117,116,51,187,78,223,11,220,14,127,201,158,27,253,23,28,157,114,59,216,78,174,236,124,218,226,165,203,116,207,178,221,126,3,97,195,154,158,39,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("eb44fa4e-3083-461b-a753-81b61ff52720"));
		}

		#endregion

	}

	#endregion

}

