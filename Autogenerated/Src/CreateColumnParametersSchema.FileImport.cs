namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CreateColumnParametersSchema

	/// <exclude/>
	public class CreateColumnParametersSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CreateColumnParametersSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CreateColumnParametersSchema(CreateColumnParametersSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("505dc12a-1491-4df1-92bd-08b61339d4ff");
			Name = "CreateColumnParameters";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,144,77,107,195,48,12,134,207,45,244,63,8,118,79,238,235,216,37,219,74,111,129,118,187,107,137,146,25,252,145,201,242,32,148,253,247,41,206,90,178,143,130,109,36,241,62,239,107,228,209,81,28,176,33,56,18,51,198,208,73,81,5,223,153,62,49,138,9,190,120,50,150,246,110,8,44,155,245,105,179,94,165,104,124,15,135,49,10,185,237,165,95,210,76,197,163,23,35,134,162,10,84,50,164,87,107,26,104,44,198,8,21,19,10,85,193,38,231,107,100,205,23,226,168,170,201,124,117,195,212,107,42,212,28,6,226,201,226,22,234,140,103,167,179,85,246,31,15,205,27,57,252,217,156,160,39,217,66,156,158,207,43,196,28,254,223,232,26,61,47,96,22,189,160,77,4,203,250,15,53,221,178,44,225,46,38,231,144,199,251,243,224,1,5,225,35,67,50,14,4,201,155,119,173,77,75,250,151,206,16,23,23,180,92,178,223,223,216,37,211,102,143,156,123,84,135,231,125,251,59,62,175,145,124,59,111,82,59,157,233,249,2,188,149,56,160,234,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("505dc12a-1491-4df1-92bd-08b61339d4ff"));
		}

		#endregion

	}

	#endregion

}

