namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: EventTrackingResultSchema

	/// <exclude/>
	public class EventTrackingResultSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public EventTrackingResultSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public EventTrackingResultSchema(EventTrackingResultSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("994af77d-fdfe-407e-9278-b280ee07b73c");
			Name = "EventTrackingResult";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("47949cd8-6780-414e-8fda-4fa996b6db3c");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,144,221,106,195,48,12,70,175,19,200,59,24,122,59,202,182,238,7,6,187,200,214,20,202,96,133,181,123,0,207,81,82,211,88,54,178,92,8,163,239,62,197,29,108,23,189,147,190,115,248,16,66,237,32,6,109,64,237,128,72,71,223,241,252,213,99,103,251,68,154,173,199,121,115,4,228,29,105,115,176,216,127,64,76,3,87,229,119,85,86,101,49,35,232,69,81,13,38,247,164,46,138,98,133,244,53,88,163,64,164,203,78,33,109,69,177,57,168,103,117,125,53,141,117,176,111,48,190,123,94,249,132,173,196,55,57,94,99,39,23,50,37,195,137,64,240,18,194,224,71,152,140,219,108,108,120,15,212,16,121,146,104,241,175,171,30,8,116,59,126,198,44,223,253,214,25,79,4,134,95,130,171,19,239,69,19,118,159,217,118,140,91,96,150,35,215,177,113,129,39,242,144,201,210,59,109,241,47,125,148,240,116,254,6,96,123,126,200,180,158,126,0,59,218,177,225,90,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("994af77d-fdfe-407e-9278-b280ee07b73c"));
		}

		#endregion

	}

	#endregion

}

