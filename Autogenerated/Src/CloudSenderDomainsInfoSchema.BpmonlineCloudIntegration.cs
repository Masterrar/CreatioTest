namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CloudSenderDomainsInfoSchema

	/// <exclude/>
	public class CloudSenderDomainsInfoSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CloudSenderDomainsInfoSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CloudSenderDomainsInfoSchema(CloudSenderDomainsInfoSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f2e8d79a-460e-4a42-b17f-4d076f55b6e6");
			Name = "CloudSenderDomainsInfo";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("5f5fe385-d25b-4c17-9585-cfaff007abaf");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,213,85,177,110,219,48,16,157,19,32,255,112,112,134,166,139,181,215,110,22,187,13,210,212,133,97,23,89,130,14,172,120,82,9,83,164,192,163,92,24,70,255,189,71,82,22,98,87,14,148,14,5,58,17,186,247,120,239,61,146,34,141,168,144,106,145,35,124,69,231,4,217,194,143,103,214,20,170,108,156,240,202,154,241,236,195,122,97,37,106,186,186,220,95,93,94,52,164,76,9,235,29,121,172,152,169,53,230,129,70,227,59,52,232,84,62,233,56,95,240,167,103,32,116,252,68,214,48,192,208,181,195,146,233,48,211,130,232,29,15,182,145,107,52,18,221,220,86,66,25,186,55,133,141,204,44,203,96,74,77,85,9,183,187,109,191,87,88,59,36,52,158,128,199,154,187,35,216,2,252,15,4,66,183,85,28,163,176,142,49,239,20,110,131,9,153,186,198,50,79,148,161,134,92,210,227,131,68,246,76,163,110,190,107,149,67,30,204,157,245,118,177,143,254,186,40,75,103,107,116,94,33,231,89,198,6,9,63,13,16,11,119,200,222,163,23,30,131,239,131,65,97,36,40,255,134,193,58,173,103,215,34,59,237,49,37,68,161,201,66,238,176,120,63,122,110,113,148,69,214,83,88,240,214,215,238,102,212,106,140,222,126,11,96,27,242,179,34,63,253,35,227,45,180,89,97,15,37,250,73,48,58,129,95,175,74,132,133,104,180,7,185,81,213,24,248,48,249,216,111,43,116,131,160,10,168,157,221,42,22,76,51,194,81,209,8,27,220,197,61,18,90,31,150,228,204,10,156,102,75,106,243,135,251,197,3,238,142,35,18,31,3,222,239,249,17,229,191,9,198,42,43,204,173,147,253,161,56,77,130,255,62,208,122,249,49,185,31,230,136,234,226,49,176,123,253,172,91,240,159,185,145,12,108,206,251,153,119,240,96,71,233,228,7,15,74,198,187,143,47,146,176,192,3,253,196,217,143,221,228,151,246,174,151,58,216,231,234,112,245,145,23,190,25,120,156,18,183,127,235,34,244,122,249,156,159,133,97,226,129,121,44,173,140,231,63,72,14,223,156,78,149,223,43,18,229,64,225,150,220,27,123,145,176,62,7,215,124,35,166,219,61,126,167,234,113,145,107,191,1,193,125,46,24,60,7,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f2e8d79a-460e-4a42-b17f-4d076f55b6e6"));
		}

		#endregion

	}

	#endregion

}

