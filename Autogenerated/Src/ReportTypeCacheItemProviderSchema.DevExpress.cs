namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ReportTypeCacheItemProviderSchema

	/// <exclude/>
	public class ReportTypeCacheItemProviderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ReportTypeCacheItemProviderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ReportTypeCacheItemProviderSchema(ReportTypeCacheItemProviderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("efec3a04-01c8-443e-8370-5dc6fc5cb55b");
			Name = "ReportTypeCacheItemProvider";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("c726ce12-f9a0-470f-b11e-69aaf7648b50");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,82,205,74,195,64,16,62,167,208,119,24,240,146,64,201,3,180,120,177,85,232,65,40,90,189,136,135,53,153,164,139,233,110,152,221,141,150,210,119,119,54,73,213,46,49,30,103,248,254,246,155,85,98,143,166,22,25,194,22,137,132,209,133,77,151,90,21,178,116,36,172,212,106,58,57,78,39,145,51,82,149,240,120,48,22,247,139,239,249,55,133,240,175,125,122,39,50,171,73,162,25,66,108,181,174,76,186,194,230,246,179,38,52,230,1,107,77,76,20,217,14,211,110,216,30,106,108,103,230,179,194,21,97,201,193,96,89,9,99,230,16,96,214,156,112,67,186,145,57,82,11,127,89,97,33,92,101,111,164,202,217,58,182,140,212,69,188,30,225,37,201,43,19,107,247,86,201,12,50,111,51,230,2,115,24,19,99,165,99,27,228,39,184,86,198,146,243,165,112,254,77,107,211,33,122,203,17,181,248,201,32,177,128,194,204,95,7,220,197,152,128,63,86,20,5,160,235,0,230,239,16,157,250,80,168,242,46,215,101,72,54,172,145,44,95,141,35,146,108,132,197,62,99,55,64,224,17,140,71,40,209,46,224,31,147,123,180,59,157,15,151,48,212,41,44,9,217,59,230,250,252,47,122,199,195,12,60,0,26,81,57,60,191,158,208,58,82,160,240,99,168,201,160,193,153,87,57,51,163,103,175,195,125,181,122,237,234,52,82,86,183,189,92,242,238,11,35,215,22,76,84,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("efec3a04-01c8-443e-8370-5dc6fc5cb55b"));
		}

		#endregion

	}

	#endregion

}

