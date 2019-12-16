namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: StatisticEventTypeSchema

	/// <exclude/>
	public class StatisticEventTypeSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public StatisticEventTypeSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public StatisticEventTypeSchema(StatisticEventTypeSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("4f9f834a-d6b3-457b-ba8a-e93406998209");
			Name = "StatisticEventType";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b39fd9cb-6840-4142-8022-7c9d0489d323");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,147,79,75,195,48,24,135,207,43,244,59,132,121,81,144,22,255,30,212,121,209,130,23,47,110,158,68,36,237,222,213,96,147,134,188,137,80,196,239,110,146,174,181,101,165,108,61,38,125,126,191,247,9,77,4,229,128,146,102,64,86,160,20,197,114,163,163,135,82,108,88,110,20,213,172,20,97,240,19,6,51,131,76,228,100,89,161,6,110,191,115,89,10,16,250,185,92,67,113,27,6,22,56,82,144,91,154,36,194,240,27,178,212,54,139,154,101,201,183,197,86,149,4,15,197,113,76,238,208,112,78,85,117,191,93,183,40,209,22,195,168,193,226,14,39,77,90,88,0,108,247,96,245,204,41,238,180,251,141,132,83,86,16,108,66,81,11,118,251,103,111,143,128,153,98,210,29,248,120,14,46,243,209,102,112,126,242,238,32,95,213,142,71,178,32,103,167,254,88,195,147,95,32,99,146,89,199,3,167,171,38,183,107,208,86,246,44,206,247,179,248,44,141,42,170,201,50,117,124,196,233,201,3,61,179,139,61,205,236,79,84,5,19,95,211,229,154,134,49,191,134,233,41,94,142,41,214,151,103,170,94,125,141,70,212,124,253,176,214,213,152,214,171,64,147,186,65,41,28,168,100,254,147,91,135,110,215,130,92,219,173,223,250,61,131,88,215,79,218,45,237,222,31,21,83,160,185,41,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("4f9f834a-d6b3-457b-ba8a-e93406998209"));
		}

		#endregion

	}

	#endregion

}

