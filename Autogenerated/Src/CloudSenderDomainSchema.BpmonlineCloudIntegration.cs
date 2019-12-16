namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CloudSenderDomainSchema

	/// <exclude/>
	public class CloudSenderDomainSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CloudSenderDomainSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CloudSenderDomainSchema(CloudSenderDomainSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e61dae9a-2655-48a6-bc4a-42efa1e9c942");
			Name = "CloudSenderDomain";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("5f5fe385-d25b-4c17-9585-cfaff007abaf");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,146,193,78,195,48,12,134,207,171,212,119,176,180,123,123,103,136,75,153,56,76,72,19,229,5,178,198,45,17,109,82,217,9,82,53,241,238,184,201,134,6,236,80,16,39,43,127,108,255,159,19,91,53,32,143,170,65,120,70,34,197,174,245,69,229,108,107,186,64,202,27,103,139,106,91,63,58,141,61,231,217,49,207,242,108,181,38,236,228,2,170,94,49,223,72,112,65,215,104,53,210,189,27,148,177,49,169,44,75,184,229,48,12,138,166,187,211,249,9,71,66,70,235,25,140,109,29,13,209,0,212,193,5,15,58,214,130,200,32,41,218,216,14,252,11,2,138,218,115,113,238,88,94,180,28,195,161,55,13,52,51,198,53,138,85,194,253,228,221,147,27,145,188,65,129,222,199,218,116,255,29,53,10,15,40,148,145,69,226,12,114,226,83,90,203,12,17,232,39,209,25,137,61,205,252,9,4,142,208,161,223,204,157,54,240,254,27,203,55,36,211,154,38,189,210,43,78,139,76,119,56,253,221,145,189,242,65,164,246,98,228,69,174,117,42,252,159,81,101,17,29,45,178,221,206,153,215,92,215,178,9,233,219,227,57,169,95,69,209,62,0,2,64,31,28,253,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e61dae9a-2655-48a6-bc4a-42efa1e9c942"));
		}

		#endregion

	}

	#endregion

}

