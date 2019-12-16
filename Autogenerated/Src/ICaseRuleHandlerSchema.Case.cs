namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ICaseRuleHandlerSchema

	/// <exclude/>
	public class ICaseRuleHandlerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ICaseRuleHandlerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ICaseRuleHandlerSchema(ICaseRuleHandlerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("66c513b1-90ad-4e77-a206-4ecd2c1e8325");
			Name = "ICaseRuleHandler";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("c3c90037-274c-4793-841e-197eb228d3cd");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,80,205,78,195,48,12,62,119,210,222,193,218,9,46,205,3,80,118,153,144,182,43,26,15,96,50,183,68,74,157,202,73,144,170,137,119,199,73,161,130,33,164,92,108,127,95,190,31,198,145,226,132,150,224,76,34,24,67,159,218,67,224,222,13,89,48,185,192,219,205,117,187,105,114,116,60,252,130,8,61,252,179,111,159,56,185,228,40,42,64,33,198,24,232,98,30,71,148,121,255,53,159,56,145,244,69,181,15,2,146,61,69,16,178,232,109,246,85,181,253,38,154,31,204,41,191,122,103,193,173,228,211,1,35,61,43,251,136,124,241,36,138,41,102,155,151,72,162,33,152,108,249,11,110,198,10,105,6,74,37,64,243,81,77,254,113,89,23,26,68,102,152,130,42,174,70,225,173,104,105,234,118,165,153,91,94,55,161,224,8,172,221,62,238,168,180,49,239,246,181,149,185,51,245,86,161,239,193,93,96,177,14,119,203,25,22,244,125,177,166,206,244,125,2,102,36,146,92,161,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("66c513b1-90ad-4e77-a206-4ecd2c1e8325"));
		}

		#endregion

	}

	#endregion

}

