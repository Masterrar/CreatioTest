namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ColumnValueResultSchema

	/// <exclude/>
	public class ColumnValueResultSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ColumnValueResultSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ColumnValueResultSchema(ColumnValueResultSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("3673988a-b579-40b7-b4e0-255d21d4b2d7");
			Name = "ColumnValueResult";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6c038aa0-46cd-4697-bc93-5c682e364aef");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,83,201,78,195,48,16,61,167,82,255,97,20,46,112,73,238,116,185,68,21,234,173,2,202,221,117,38,193,40,177,141,151,66,169,250,239,216,206,86,218,82,184,68,246,44,239,189,121,227,112,82,163,150,132,34,60,163,82,68,139,194,36,153,224,5,43,173,34,134,9,158,100,164,150,132,149,92,143,71,251,241,40,178,154,241,18,158,118,218,96,61,25,143,92,228,70,97,233,10,33,171,136,214,247,144,137,202,214,252,133,84,22,31,81,219,202,132,162,52,77,97,170,109,93,19,181,155,183,247,38,13,162,0,26,122,96,235,155,128,113,131,74,42,116,95,40,132,2,79,88,97,91,147,116,88,233,17,152,180,155,138,81,160,94,192,37,254,104,31,52,12,74,5,215,70,89,106,132,114,130,87,161,187,169,56,149,25,2,75,206,12,35,21,251,66,151,67,167,68,97,49,139,207,120,226,116,238,180,107,67,56,197,164,7,75,79,209,166,146,40,82,3,119,198,207,226,102,168,245,50,143,231,107,206,222,253,244,57,114,195,10,230,134,119,198,152,215,126,240,105,26,26,3,78,59,240,153,132,219,7,203,114,232,65,239,192,111,44,138,178,46,0,179,33,57,241,169,67,107,12,242,188,241,230,167,81,43,37,36,42,195,240,63,54,45,156,110,179,235,118,233,24,126,49,161,21,31,164,14,202,246,80,162,153,128,84,108,75,12,130,246,151,195,21,182,236,232,201,92,39,18,155,55,164,6,130,77,29,205,159,240,110,114,138,58,188,117,252,164,40,253,175,0,204,47,68,137,15,126,157,112,209,55,12,167,11,188,39,166,55,209,159,193,195,55,49,172,232,101,159,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("3673988a-b579-40b7-b4e0-255d21d4b2d7"));
		}

		#endregion

	}

	#endregion

}

