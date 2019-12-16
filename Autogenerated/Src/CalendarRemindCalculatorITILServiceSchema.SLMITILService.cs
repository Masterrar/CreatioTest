namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CalendarRemindCalculatorITILServiceSchema

	/// <exclude/>
	public class CalendarRemindCalculatorITILServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CalendarRemindCalculatorITILServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CalendarRemindCalculatorITILServiceSchema(CalendarRemindCalculatorITILServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("67ff7e01-713e-4dfe-9885-71eb157ffd86");
			Name = "CalendarRemindCalculatorITILService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,82,77,107,194,64,16,61,71,240,63,12,122,137,32,254,0,197,83,40,37,208,130,84,123,42,61,172,155,49,93,72,54,97,63,20,209,252,247,206,238,198,154,88,132,92,2,111,102,222,188,55,47,107,181,144,57,108,207,218,96,185,26,143,172,135,59,84,138,233,234,96,22,73,165,144,202,227,145,100,37,234,154,113,236,53,229,65,228,86,49,35,42,57,30,93,220,92,52,85,152,19,132,164,96,90,47,33,97,5,202,140,169,15,44,133,204,8,113,91,48,83,169,116,151,190,109,81,29,5,71,79,171,237,190,16,28,184,99,13,33,193,243,213,180,141,172,68,119,39,149,212,70,89,78,45,50,180,81,226,200,76,16,141,234,0,134,8,198,159,26,21,173,146,200,221,185,96,123,112,230,182,69,75,216,51,141,241,67,11,188,155,38,40,78,73,39,248,106,113,107,242,29,205,79,149,57,127,62,136,214,94,8,69,27,74,152,15,74,37,81,72,247,164,116,48,147,28,7,219,159,195,171,21,25,112,114,159,102,173,225,232,200,148,175,188,72,35,204,25,214,144,163,73,254,112,252,184,33,144,231,32,241,244,245,13,23,152,180,202,41,189,172,52,155,204,97,66,209,87,138,168,1,181,237,13,227,134,10,208,204,86,94,85,28,226,174,232,26,164,45,10,184,94,59,86,22,61,170,155,113,238,23,47,101,77,140,254,228,93,178,63,118,187,49,82,104,172,146,94,36,232,55,254,123,43,227,105,208,219,248,247,199,193,5,69,145,117,78,105,86,79,158,65,91,235,150,154,95,23,43,252,33,151,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("67ff7e01-713e-4dfe-9885-71eb157ffd86"));
		}

		#endregion

	}

	#endregion

}

