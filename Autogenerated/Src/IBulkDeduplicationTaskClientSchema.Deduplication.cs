namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IBulkDeduplicationTaskClientSchema

	/// <exclude/>
	public class IBulkDeduplicationTaskClientSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IBulkDeduplicationTaskClientSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IBulkDeduplicationTaskClientSchema(IBulkDeduplicationTaskClientSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("fef75578-f348-4491-a5ba-51e5ae6801c5");
			Name = "IBulkDeduplicationTaskClient";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("4c53ad23-c903-414d-89cd-b08703861304");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,146,207,78,195,48,12,198,207,155,180,119,176,198,5,36,212,222,97,12,137,109,66,189,32,4,123,129,108,113,75,180,38,169,18,103,218,52,237,221,113,211,118,127,40,136,91,236,124,63,251,179,101,35,52,250,74,172,17,150,232,156,240,54,167,100,102,77,174,138,224,4,41,107,146,57,202,80,149,106,29,163,209,240,48,26,14,130,87,166,128,171,143,69,41,60,169,117,50,183,90,168,31,80,178,20,126,243,56,26,50,121,227,176,224,12,100,134,208,229,220,246,1,178,151,80,110,174,244,181,124,86,42,52,20,153,52,77,97,226,131,214,194,237,167,109,252,238,236,86,73,244,32,192,35,129,205,65,94,86,0,226,18,30,180,48,162,64,205,133,64,35,125,89,233,19,232,10,166,23,21,171,176,98,18,84,103,234,31,79,131,67,244,213,51,22,19,31,72,78,225,150,173,213,30,192,147,160,224,97,181,7,70,21,237,193,240,194,65,24,201,221,36,238,98,152,116,108,150,55,144,180,140,27,75,128,59,229,201,131,67,10,206,112,42,148,229,73,124,53,65,147,169,132,19,58,150,124,26,55,237,222,248,61,158,46,206,173,147,73,26,85,191,67,209,83,195,100,103,123,61,164,245,51,157,247,118,222,206,203,72,167,169,161,222,38,63,163,234,25,94,145,254,248,187,245,188,70,62,178,243,24,247,208,166,78,38,239,154,155,58,54,151,133,70,54,199,85,135,199,111,177,232,77,207,216,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("fef75578-f348-4491-a5ba-51e5ae6801c5"));
		}

		#endregion

	}

	#endregion

}

