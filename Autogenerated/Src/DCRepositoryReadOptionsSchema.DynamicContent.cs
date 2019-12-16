namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: DCRepositoryReadOptionsSchema

	/// <exclude/>
	public class DCRepositoryReadOptionsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public DCRepositoryReadOptionsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public DCRepositoryReadOptionsSchema(DCRepositoryReadOptionsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e1294a92-73db-463a-b908-32d204d88db2");
			Name = "DCRepositoryReadOptions";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("ad993b20-8db8-48d6-9762-5a83fb4975c6");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,146,193,110,194,48,16,68,207,69,226,31,86,233,181,74,4,199,18,114,129,107,11,66,249,129,109,216,4,75,142,109,173,157,86,17,226,223,235,56,9,8,26,164,94,34,121,103,198,59,126,138,194,154,172,193,130,32,39,102,180,186,116,241,70,171,82,84,13,163,19,90,197,219,86,97,45,10,63,116,164,220,124,118,158,207,94,26,43,84,245,207,68,252,161,143,36,237,106,62,243,193,87,166,202,91,96,35,209,218,119,216,110,14,100,180,21,78,115,123,32,60,238,76,119,129,13,214,36,73,32,181,77,93,35,183,217,112,190,185,65,247,86,40,53,3,251,168,5,71,181,145,232,40,30,195,201,67,58,117,173,33,131,140,53,248,130,180,142,242,69,148,229,67,10,138,174,82,156,38,87,211,243,216,50,202,124,19,41,10,156,78,153,230,203,139,189,246,236,141,105,190,120,131,124,153,193,207,137,216,211,95,116,52,198,50,1,217,168,44,7,78,221,190,32,248,13,231,128,232,138,115,207,218,16,59,65,158,233,62,44,239,245,71,134,97,176,27,201,73,172,38,249,193,150,74,108,164,131,111,148,13,129,176,254,14,242,128,152,202,117,116,43,121,123,76,252,169,21,69,201,117,195,29,249,145,198,84,16,254,142,44,156,161,34,183,2,219,125,46,176,158,12,134,141,171,1,2,169,99,207,33,156,47,253,143,118,55,188,252,2,94,232,137,73,231,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e1294a92-73db-463a-b908-32d204d88db2"));
		}

		#endregion

	}

	#endregion

}

