namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: EmailIndicatorSchema

	/// <exclude/>
	public class EmailIndicatorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public EmailIndicatorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public EmailIndicatorSchema(EmailIndicatorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("8e8d82a0-a320-4f28-97ed-a3ba83092051");
			Name = "EmailIndicator";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b39fd9cb-6840-4142-8022-7c9d0489d323");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,165,147,77,111,19,49,16,134,207,169,212,255,48,218,94,224,178,185,211,82,9,182,40,138,4,168,106,16,23,196,97,226,157,36,86,189,246,202,51,139,84,42,254,59,99,239,102,201,71,37,2,57,101,231,227,157,121,222,216,246,216,16,183,104,8,190,80,140,200,97,37,101,21,252,202,174,187,136,98,131,191,188,120,190,188,152,116,108,253,26,22,79,44,212,92,31,196,218,239,28,153,212,204,229,140,60,69,107,142,122,30,58,47,182,161,114,161,85,116,246,103,158,173,93,218,119,21,105,173,1,84,14,153,223,192,135,6,173,155,251,218,26,148,16,115,199,116,58,133,27,238,154,6,227,211,237,16,63,80,27,137,201,11,3,37,5,72,12,221,210,17,216,173,180,220,42,167,59,210,111,119,40,168,6,37,162,145,239,154,104,85,100,13,152,180,252,104,247,228,57,239,31,17,239,99,104,41,138,37,229,188,207,194,190,126,8,152,19,51,82,182,16,129,211,239,72,5,6,219,228,189,28,117,187,120,61,223,39,106,150,20,95,125,214,179,129,183,80,12,138,226,117,226,221,2,179,196,244,247,86,125,13,210,33,77,38,107,146,235,252,193,195,199,175,83,249,150,228,205,70,203,143,240,3,93,71,255,64,55,42,247,249,172,23,120,63,14,61,23,79,15,171,67,215,179,65,88,129,108,14,14,250,68,216,126,78,21,244,54,30,227,190,203,197,175,121,199,185,192,44,40,39,147,230,76,246,54,134,21,122,48,122,77,209,122,30,108,23,225,177,72,243,11,125,168,33,22,59,179,254,72,95,242,156,81,94,188,60,139,12,121,174,85,103,89,146,211,249,29,111,13,231,23,201,0,181,173,193,7,129,6,197,108,254,235,192,242,164,121,253,81,119,236,91,72,153,155,89,103,235,219,225,213,230,158,191,152,185,34,95,247,79,57,199,125,118,63,169,185,223,91,66,81,157,20,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("8e8d82a0-a320-4f28-97ed-a3ba83092051"));
		}

		#endregion

	}

	#endregion

}

