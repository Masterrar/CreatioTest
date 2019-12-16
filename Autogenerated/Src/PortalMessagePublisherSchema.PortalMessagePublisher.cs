namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: PortalMessagePublisherSchema

	/// <exclude/>
	public class PortalMessagePublisherSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public PortalMessagePublisherSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public PortalMessagePublisherSchema(PortalMessagePublisherSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("6244c208-b197-4059-8d43-d8de62679b3c");
			Name = "PortalMessagePublisher";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("4b8eb560-035d-46d4-af40-51e85d9668c1");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,80,193,106,195,48,12,61,39,144,127,16,221,165,131,210,15,72,183,29,214,110,59,109,20,186,125,128,234,170,169,193,113,138,100,31,66,232,191,79,118,10,35,235,6,6,251,61,63,189,39,41,138,245,13,236,122,9,212,46,215,157,115,100,130,237,188,44,223,200,19,91,179,170,202,152,37,159,196,140,210,29,131,170,152,148,174,74,143,45,201,25,13,77,62,253,209,54,145,49,185,84,229,80,149,133,158,59,166,70,49,172,29,138,212,176,237,56,160,123,39,17,108,104,27,247,206,202,137,56,89,22,231,132,12,152,36,252,71,7,53,60,163,208,109,121,49,100,139,159,52,157,35,112,52,161,99,205,204,198,163,224,26,242,183,253,252,75,136,181,212,143,155,128,56,129,11,216,216,252,64,238,31,212,93,87,179,128,241,126,2,242,193,134,254,213,146,59,200,6,3,222,167,176,162,134,189,182,59,255,237,115,35,134,33,203,95,50,191,51,39,106,241,67,55,12,143,48,155,116,58,91,37,221,229,58,43,249,195,56,110,198,35,59,37,47,223,247,153,241,37,228,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("6244c208-b197-4059-8d43-d8de62679b3c"));
		}

		#endregion

	}

	#endregion

}

