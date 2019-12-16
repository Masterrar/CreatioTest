namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ColumnValuesIteratorSchema

	/// <exclude/>
	public class ColumnValuesIteratorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ColumnValuesIteratorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ColumnValuesIteratorSchema(ColumnValuesIteratorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f924bc20-2aaa-439a-84e8-9d39b2eb7fb7");
			Name = "ColumnValuesIterator";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6c038aa0-46cd-4697-bc93-5c682e364aef");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,84,75,139,219,48,16,62,59,144,255,48,164,151,236,197,190,55,15,40,217,82,2,93,40,109,233,93,43,143,29,129,44,25,73,206,54,13,249,239,29,235,225,245,110,19,239,246,98,236,209,60,190,199,200,138,53,104,91,198,17,126,162,49,204,234,202,229,59,173,42,81,119,134,57,161,85,190,99,77,203,68,173,236,124,118,158,207,178,206,10,85,195,143,147,117,216,80,166,148,200,251,52,155,127,65,133,70,240,213,124,70,89,31,12,214,20,133,157,100,214,126,4,202,235,26,245,139,201,14,237,222,33,117,214,198,231,21,69,1,107,219,53,13,51,167,109,252,14,9,104,225,241,68,103,136,192,13,86,155,197,181,30,159,37,54,168,220,162,216,230,169,89,49,234,214,118,143,82,112,224,61,136,27,24,178,179,199,49,0,254,102,116,139,198,9,36,212,244,238,136,29,150,33,229,53,86,31,136,8,44,240,65,10,168,180,1,17,72,228,67,225,24,87,214,166,206,240,85,88,183,158,160,182,125,158,112,134,26,221,10,108,255,184,192,6,20,62,189,93,190,188,91,69,130,168,202,192,241,37,97,50,219,58,211,113,170,233,41,123,197,38,248,222,99,197,58,233,136,238,80,6,79,7,193,15,32,148,112,130,73,241,7,35,121,58,121,22,229,150,16,193,161,107,12,150,119,208,239,91,150,237,169,177,167,145,101,151,105,46,15,232,14,186,124,167,115,251,1,111,57,54,79,87,128,73,241,209,246,37,23,226,170,77,122,122,20,198,117,76,194,81,139,18,2,250,72,37,117,201,63,149,229,178,247,111,76,252,30,45,93,32,143,136,200,7,194,255,86,60,48,110,180,47,248,142,173,164,139,59,149,75,78,9,95,96,175,86,188,91,206,183,182,130,244,230,72,119,12,25,45,66,148,15,42,163,155,255,147,208,71,90,102,88,3,138,254,75,155,5,109,153,195,223,110,177,221,133,23,127,181,218,48,172,255,13,37,167,242,117,225,203,198,59,229,213,143,192,150,215,22,44,245,140,67,146,71,52,194,211,88,30,153,25,184,8,53,220,195,148,151,197,179,60,205,72,125,130,25,151,219,2,135,232,203,224,229,47,236,112,243,128,137,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f924bc20-2aaa-439a-84e8-9d39b2eb7fb7"));
		}

		#endregion

	}

	#endregion

}

