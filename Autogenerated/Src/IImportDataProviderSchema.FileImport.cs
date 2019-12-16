namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IImportDataProviderSchema

	/// <exclude/>
	public class IImportDataProviderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IImportDataProviderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IImportDataProviderSchema(IImportDataProviderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("a7e3537c-3593-48ac-b8b2-83b46b5726f0");
			Name = "IImportDataProvider";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,165,147,193,78,227,48,16,134,207,32,241,14,163,114,233,74,40,185,67,8,90,117,151,42,7,36,36,178,15,224,196,211,214,108,98,71,30,123,171,10,241,238,140,237,38,91,34,224,194,209,147,249,253,255,223,140,163,69,143,52,136,22,161,70,107,5,153,141,203,86,70,111,212,214,91,225,148,209,217,189,234,176,234,7,99,221,197,249,203,197,249,153,39,165,183,240,116,32,135,253,205,236,204,210,174,195,54,232,40,91,163,70,171,90,238,225,174,75,139,91,174,66,165,29,218,13,251,93,195,163,111,58,213,198,175,121,158,67,65,190,239,133,61,148,199,115,242,4,41,156,128,193,154,127,74,162,205,198,222,124,214,92,184,195,128,131,176,162,7,205,68,183,139,122,81,214,92,2,69,32,244,1,218,78,16,101,69,62,181,5,225,16,3,128,26,35,65,149,60,87,59,175,255,254,98,223,199,163,109,81,151,176,223,161,229,33,93,167,171,88,253,18,147,79,96,15,232,118,70,82,42,206,121,98,97,141,14,104,192,86,109,20,74,80,255,241,178,73,146,207,53,197,41,83,146,60,33,17,27,86,114,81,30,71,68,169,2,149,100,194,137,46,233,45,58,111,53,149,193,60,38,135,48,2,48,205,51,175,41,76,100,108,8,138,234,183,246,61,90,209,116,24,144,89,179,92,123,53,102,157,140,127,220,124,65,249,83,202,239,81,134,94,138,43,160,137,48,62,130,54,214,62,71,92,25,175,29,88,179,39,94,150,129,6,81,243,110,9,173,67,57,3,229,149,135,160,203,25,240,137,245,151,140,127,6,238,196,239,97,70,154,15,0,63,231,187,239,196,246,10,246,130,2,35,248,152,65,222,189,7,107,140,233,142,241,150,117,186,112,36,185,68,45,211,91,141,231,215,244,91,190,43,190,190,1,43,66,74,67,14,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a7e3537c-3593-48ac-b8b2-83b46b5726f0"));
		}

		#endregion

	}

	#endregion

}

