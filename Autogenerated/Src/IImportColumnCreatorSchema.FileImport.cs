namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IImportColumnCreatorSchema

	/// <exclude/>
	public class IImportColumnCreatorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IImportColumnCreatorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IImportColumnCreatorSchema(IImportColumnCreatorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("bde3734a-5b98-4e46-be3f-8b884e2800c8");
			Name = "IImportColumnCreator";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,181,144,177,138,195,48,16,68,107,27,252,15,139,171,187,198,250,128,56,110,12,7,238,82,132,244,27,179,62,4,150,100,86,82,17,66,254,61,146,156,228,196,157,175,12,168,218,121,163,157,89,141,138,236,130,35,193,145,152,209,154,201,53,189,209,147,252,246,140,78,26,221,124,201,153,6,181,24,118,85,121,173,202,98,241,231,89,142,32,181,35,158,162,113,88,213,222,204,94,233,158,9,157,225,192,69,182,16,66,64,107,189,82,200,151,238,57,72,12,129,76,54,24,147,175,121,209,226,55,222,46,200,168,64,135,164,251,122,76,222,117,215,33,206,41,196,176,117,23,182,16,65,80,167,125,221,111,51,162,107,69,250,234,231,103,38,231,89,219,46,51,231,101,146,229,201,68,83,46,62,106,228,163,143,237,205,176,29,250,115,87,149,239,185,81,162,79,56,123,170,255,171,182,170,239,57,201,227,24,127,214,65,22,44,150,47,110,85,25,222,29,154,109,222,146,131,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("bde3734a-5b98-4e46-be3f-8b884e2800c8"));
		}

		#endregion

	}

	#endregion

}

