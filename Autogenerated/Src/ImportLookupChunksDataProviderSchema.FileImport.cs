namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ImportLookupChunksDataProviderSchema

	/// <exclude/>
	public class ImportLookupChunksDataProviderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ImportLookupChunksDataProviderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ImportLookupChunksDataProviderSchema(ImportLookupChunksDataProviderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("0d7cf7b7-aeeb-464d-be24-906e65b3ca3f");
			Name = "ImportLookupChunksDataProvider";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,145,65,107,194,64,16,133,207,17,252,15,11,189,196,75,114,175,226,161,17,139,208,130,7,123,42,61,172,201,36,46,198,157,48,59,43,20,241,191,119,146,141,212,72,173,199,125,251,230,205,55,51,86,31,192,53,58,7,181,1,34,237,176,228,36,67,91,154,202,147,102,131,54,89,154,26,86,135,6,137,199,163,211,120,20,121,103,108,53,112,19,76,239,232,201,82,231,140,100,192,137,67,60,79,4,149,100,170,172,214,206,61,171,16,251,134,184,247,77,182,243,118,239,22,154,245,154,240,104,10,160,174,34,77,83,53,51,118,7,100,184,192,92,165,115,17,63,23,80,106,95,243,139,177,133,52,141,249,187,1,44,227,85,200,235,146,174,131,102,87,29,90,125,62,153,124,73,74,227,183,181,201,85,222,178,60,64,81,23,214,199,217,18,124,234,200,127,135,69,235,152,124,187,8,153,121,221,117,13,142,158,224,255,222,241,135,3,146,12,11,121,123,15,229,7,207,137,160,109,181,131,248,86,110,79,21,157,123,18,176,69,128,25,146,189,3,239,176,104,161,8,89,10,161,8,255,127,46,61,106,46,38,133,71,185,178,176,93,47,101,35,55,80,175,192,55,82,220,147,68,4,236,201,222,86,36,97,234,233,125,216,160,14,197,243,15,180,10,164,26,182,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("0d7cf7b7-aeeb-464d-be24-906e65b3ca3f"));
		}

		#endregion

	}

	#endregion

}

