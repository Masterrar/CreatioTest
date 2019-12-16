namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IImportEntitiesChunksDataProviderSchema

	/// <exclude/>
	public class IImportEntitiesChunksDataProviderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IImportEntitiesChunksDataProviderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IImportEntitiesChunksDataProviderSchema(IImportEntitiesChunksDataProviderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("2a8003b9-4985-421c-aeb6-96632952b722");
			Name = "IImportEntitiesChunksDataProvider";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,165,83,65,110,194,48,16,60,131,196,31,86,112,105,37,148,220,75,200,133,82,148,67,37,4,253,128,227,108,192,106,98,71,107,27,138,16,127,175,237,0,74,57,144,67,143,30,207,204,206,142,19,201,106,212,13,227,8,95,72,196,180,42,77,180,80,178,20,59,75,204,8,37,163,15,81,97,86,55,138,204,104,120,30,13,7,86,11,185,131,237,73,27,172,103,15,103,39,173,42,228,94,167,163,21,74,36,193,29,199,177,38,132,59,135,66,38,13,82,233,230,189,65,214,186,46,165,17,70,160,94,236,173,252,214,239,204,176,53,169,131,40,144,130,48,142,99,72,180,173,107,70,167,244,122,110,133,80,56,46,52,87,50,148,138,28,17,17,56,97,57,31,247,175,19,133,201,167,48,215,143,29,67,156,70,183,137,113,103,100,99,243,74,112,16,183,232,253,201,239,203,221,205,111,55,73,139,123,40,220,37,15,33,210,20,206,97,239,123,99,159,104,246,170,208,45,248,216,70,0,182,236,128,46,157,43,160,14,59,2,203,149,53,190,25,142,58,188,14,169,35,16,106,91,153,232,238,210,221,112,0,7,37,138,96,180,110,85,88,108,212,241,101,101,29,202,125,182,172,152,250,2,188,83,38,11,252,153,66,174,84,5,218,114,207,134,57,24,178,248,58,123,146,114,131,134,132,11,202,213,245,11,129,163,48,251,222,220,250,121,240,108,41,109,141,196,242,10,147,110,244,77,16,165,176,66,211,133,245,159,149,122,242,214,234,223,189,134,90,91,167,254,24,19,148,69,251,232,238,116,105,127,155,14,116,249,5,95,199,77,66,172,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("2a8003b9-4985-421c-aeb6-96632952b722"));
		}

		#endregion

	}

	#endregion

}

