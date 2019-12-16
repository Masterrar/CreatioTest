namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ScheduleMailingStateSchema

	/// <exclude/>
	public class ScheduleMailingStateSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ScheduleMailingStateSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ScheduleMailingStateSchema(ScheduleMailingStateSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("196c6b02-4784-4c5a-9831-b4fc6e589e4f");
			Name = "ScheduleMailingState";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b39fd9cb-6840-4142-8022-7c9d0489d323");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,77,206,61,10,131,64,16,5,224,90,193,59,76,169,141,7,72,202,96,145,34,41,98,46,176,89,159,186,176,127,184,179,209,16,188,123,86,65,72,49,3,3,239,155,25,43,12,130,23,18,244,196,52,137,224,122,174,47,206,246,106,136,147,96,229,108,145,127,139,60,243,241,165,149,36,169,69,8,212,202,17,93,212,184,9,165,149,29,90,22,12,58,209,255,152,200,198,14,231,222,105,185,234,112,100,30,233,166,179,1,212,44,144,145,177,155,178,162,221,100,60,78,110,38,139,153,218,79,96,152,250,238,248,106,188,134,129,101,116,205,34,225,183,215,202,234,188,229,215,212,82,173,63,255,50,106,185,203,0,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("196c6b02-4784-4c5a-9831-b4fc6e589e4f"));
		}

		#endregion

	}

	#endregion

}

