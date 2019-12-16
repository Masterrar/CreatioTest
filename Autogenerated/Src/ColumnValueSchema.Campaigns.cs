namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ColumnValueSchema

	/// <exclude/>
	public class ColumnValueSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ColumnValueSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ColumnValueSchema(ColumnValueSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("3acab525-0700-4166-92ec-120c1b6f08ac");
			Name = "ColumnValue";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6c038aa0-46cd-4697-bc93-5c682e364aef");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,84,205,110,219,48,12,62,167,64,223,129,104,239,241,125,73,115,152,135,181,5,86,160,192,220,221,25,155,182,181,90,146,39,81,219,130,180,239,62,73,182,211,38,89,140,20,201,37,129,72,126,127,180,101,133,146,108,139,57,65,70,198,160,213,37,79,83,173,74,81,57,131,44,180,154,166,40,91,20,149,178,151,23,235,203,139,137,179,66,85,240,125,101,153,228,108,115,126,15,54,228,235,190,115,109,168,242,4,144,54,104,237,39,72,117,227,164,250,129,141,163,216,78,146,4,230,214,73,137,102,181,232,207,94,153,81,40,11,66,149,218,200,104,0,112,169,29,195,239,0,4,95,5,82,44,120,5,121,228,155,14,76,201,59,170,214,45,27,145,67,30,132,183,117,39,235,168,189,241,246,104,116,75,134,5,121,131,143,17,213,245,119,205,197,194,147,18,191,188,7,81,4,7,165,32,3,186,220,119,179,111,103,240,115,235,68,209,219,121,186,47,96,13,21,241,12,108,248,121,29,145,141,214,131,148,165,134,114,166,226,40,49,189,252,233,135,123,240,177,82,95,27,172,128,181,95,127,33,114,100,2,174,113,88,125,141,22,36,230,70,219,113,225,165,214,13,220,161,125,136,179,31,211,159,91,34,200,13,149,55,87,95,144,49,130,179,85,75,87,201,226,131,187,222,130,239,156,142,117,147,214,148,63,91,248,83,19,215,254,97,119,178,253,54,10,207,8,28,216,132,5,166,191,124,192,78,172,24,98,103,148,93,100,198,35,61,221,97,146,121,50,204,238,110,244,222,102,126,160,123,123,224,102,177,19,201,227,67,123,171,56,59,71,52,207,72,153,144,116,114,188,13,209,88,196,97,232,64,204,233,219,196,89,194,85,254,66,158,28,44,146,140,133,10,215,254,112,160,111,90,63,187,54,160,38,47,47,123,221,7,215,176,24,25,9,6,2,255,249,31,124,48,127,242,110,34,201,216,110,62,251,63,66,53,242,90,247,19,255,11,120,77,170,232,190,227,241,220,93,229,237,226,235,63,132,8,184,52,224,6,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("3acab525-0700-4166-92ec-120c1b6f08ac"));
		}

		#endregion

	}

	#endregion

}

