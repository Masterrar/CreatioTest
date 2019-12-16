namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: EventTargetQueryBuilderSchema

	/// <exclude/>
	public class EventTargetQueryBuilderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public EventTargetQueryBuilderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public EventTargetQueryBuilderSchema(EventTargetQueryBuilderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("19e0016e-fde3-48ed-b80b-08c0f0fbf75d");
			Name = "EventTargetQueryBuilder";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("2d3388aa-34bb-4643-8688-b4b8f5148234");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,144,65,79,195,48,12,133,207,171,212,255,96,141,11,92,214,251,24,28,86,1,66,66,8,164,73,156,221,196,45,145,210,164,56,9,83,53,237,191,147,54,101,116,72,187,197,246,151,231,247,108,176,37,215,161,32,216,17,51,58,91,251,85,105,77,173,154,192,232,149,53,121,118,200,179,60,91,92,49,53,177,132,82,163,115,107,120,248,38,227,119,200,13,249,247,64,220,111,131,210,146,120,68,139,162,128,141,11,109,139,220,223,79,117,212,20,76,158,224,107,160,161,74,56,212,150,1,181,134,61,85,195,187,117,176,87,254,115,174,14,190,239,104,245,171,90,204,100,187,80,105,37,192,17,106,146,32,6,95,151,108,193,26,94,208,72,101,154,232,195,163,56,27,110,102,159,6,221,148,247,47,176,53,206,115,16,222,114,204,253,54,46,77,196,100,224,194,206,235,155,184,181,66,71,241,113,24,240,197,7,85,143,49,227,179,44,173,14,173,121,141,167,135,59,88,62,145,161,120,107,146,167,249,242,118,228,39,175,255,249,83,59,97,199,201,46,25,153,28,143,117,234,158,55,143,63,176,133,6,86,237,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("19e0016e-fde3-48ed-b80b-08c0f0fbf75d"));
		}

		#endregion

	}

	#endregion

}

