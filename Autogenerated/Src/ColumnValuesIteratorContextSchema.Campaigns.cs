namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ColumnValuesIteratorContextSchema

	/// <exclude/>
	public class ColumnValuesIteratorContextSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ColumnValuesIteratorContextSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ColumnValuesIteratorContextSchema(ColumnValuesIteratorContextSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("6c11e73b-d8b2-4159-8639-b9b25cb1fe29");
			Name = "ColumnValuesIteratorContext";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6c038aa0-46cd-4697-bc93-5c682e364aef");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,147,205,78,235,48,16,133,215,32,241,14,35,216,128,132,146,253,109,201,166,72,8,9,4,2,238,93,176,115,157,73,176,228,159,200,99,83,122,171,190,59,19,39,13,105,85,85,101,83,101,156,51,39,223,241,76,173,48,72,141,144,8,111,232,189,32,87,133,108,230,108,165,234,232,69,80,206,102,51,97,26,161,106,75,103,167,171,179,211,147,72,202,214,240,186,164,128,102,178,83,115,167,214,40,219,54,202,238,208,162,87,242,71,51,254,128,199,193,151,5,44,185,240,88,115,27,204,180,32,250,3,108,20,141,253,39,116,68,186,15,200,40,206,51,86,192,175,144,228,121,158,195,148,162,49,194,47,139,190,238,223,195,226,67,201,15,144,92,9,101,9,148,109,98,128,70,120,78,202,78,4,149,243,220,139,8,210,99,117,115,190,239,83,231,121,1,194,150,224,145,162,14,220,226,157,1,20,108,139,26,13,218,144,109,24,242,17,68,19,231,90,73,144,109,132,195,9,78,86,41,197,144,250,217,187,6,125,80,200,209,159,147,75,247,126,55,102,151,179,191,56,8,202,32,252,119,22,179,65,59,198,217,240,188,177,236,157,85,247,182,114,67,241,84,85,132,1,86,80,99,152,0,181,63,107,184,217,210,102,127,131,156,28,226,24,134,13,174,2,35,164,119,4,198,149,168,233,48,208,131,162,48,125,108,245,233,122,30,219,150,2,210,1,117,23,182,225,106,145,44,46,246,119,92,94,29,79,39,211,52,224,179,115,239,54,100,161,180,134,57,242,130,16,223,61,150,252,0,60,90,21,150,71,224,143,198,91,108,205,122,47,250,88,253,27,236,97,255,120,101,187,245,75,124,125,156,195,152,183,42,217,240,233,244,46,170,242,122,76,249,146,124,11,120,233,253,119,152,143,104,29,82,92,160,45,187,45,78,245,186,251,55,111,29,174,191,1,110,124,156,29,101,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("6c11e73b-d8b2-4159-8639-b9b25cb1fe29"));
		}

		#endregion

	}

	#endregion

}

