namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IColumnValuesDataProviderSchema

	/// <exclude/>
	public class IColumnValuesDataProviderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IColumnValuesDataProviderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IColumnValuesDataProviderSchema(IColumnValuesDataProviderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("dfb11423-d9d9-4b8b-a6d5-9ac36baac940");
			Name = "IColumnValuesDataProvider";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,213,147,207,74,195,64,16,198,207,13,228,29,150,158,20,74,242,0,214,94,42,150,220,138,173,222,199,238,36,44,100,255,48,179,27,136,226,187,187,73,154,130,161,168,20,68,133,61,236,238,55,51,251,125,63,88,3,26,217,193,1,197,30,137,128,109,233,179,181,53,165,170,2,129,87,214,100,247,170,198,66,59,75,62,77,94,211,100,22,88,153,74,236,90,246,168,111,210,36,222,184,240,92,171,131,80,198,35,149,221,168,98,109,235,160,205,19,212,1,249,14,60,108,201,54,74,34,197,226,110,196,44,207,115,177,228,160,53,80,187,26,47,118,208,160,112,100,15,200,140,82,52,93,183,140,83,5,123,75,80,97,118,234,204,167,173,75,7,4,90,152,24,230,118,206,177,63,26,47,228,124,181,204,123,225,124,157,140,198,122,139,251,214,225,227,151,229,140,164,160,86,47,40,135,92,31,203,27,171,100,159,96,59,6,24,170,174,54,33,10,39,75,11,209,159,167,79,47,98,70,234,176,78,31,185,30,8,127,2,172,199,196,194,219,17,221,191,35,54,136,123,123,36,247,147,196,30,208,7,50,124,6,90,73,86,255,34,54,26,140,69,97,220,117,210,49,226,6,253,69,140,190,133,98,242,225,254,60,137,139,254,215,145,196,91,154,196,245,14,183,65,67,207,243,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("dfb11423-d9d9-4b8b-a6d5-9ac36baac940"));
		}

		#endregion

	}

	#endregion

}

