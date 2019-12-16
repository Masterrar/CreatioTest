namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ExcelCellFormatSchema

	/// <exclude/>
	public class ExcelCellFormatSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ExcelCellFormatSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ExcelCellFormatSchema(ExcelCellFormatSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("5521b4a2-bdcb-488d-b088-5f4a850b95ea");
			Name = "ExcelCellFormat";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,146,91,75,195,64,16,133,159,83,232,127,24,240,165,133,144,164,23,47,168,21,180,173,84,16,5,91,69,16,31,182,233,36,93,220,75,216,11,180,74,255,187,187,73,11,69,105,171,15,9,76,230,124,39,135,195,8,194,81,23,36,69,152,160,82,68,203,204,68,125,41,50,154,91,69,12,149,34,26,46,10,169,204,68,14,23,41,178,122,237,171,94,171,215,2,171,169,200,97,32,83,203,81,152,91,169,56,49,209,99,129,226,149,179,104,92,40,36,51,61,71,52,23,165,250,72,97,238,172,96,40,44,63,135,210,168,143,140,85,88,169,136,227,24,46,181,229,156,168,229,213,122,46,117,224,30,6,89,169,4,116,124,180,81,199,91,242,194,78,25,77,203,253,111,251,192,69,14,130,183,242,251,131,229,83,84,213,166,145,17,166,177,249,238,183,55,82,50,232,65,43,220,33,53,202,98,8,237,164,245,236,222,157,138,25,16,131,142,105,31,96,60,145,132,208,160,194,52,71,82,209,79,41,12,97,215,140,230,194,119,247,66,152,69,29,61,209,124,110,214,190,152,82,78,124,156,206,46,235,173,228,35,87,53,42,39,238,238,207,209,250,119,142,59,97,156,237,241,222,12,33,36,206,183,155,84,196,216,40,127,22,61,56,57,212,99,242,163,199,9,229,190,203,211,63,252,108,131,221,75,249,97,11,7,157,185,105,85,221,25,138,89,117,106,126,92,125,3,198,157,27,148,220,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5521b4a2-bdcb-488d-b088-5f4a850b95ea"));
		}

		#endregion

	}

	#endregion

}

