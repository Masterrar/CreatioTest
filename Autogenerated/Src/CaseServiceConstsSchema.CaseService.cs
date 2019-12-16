namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CaseServiceConstsSchema

	/// <exclude/>
	public class CaseServiceConstsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CaseServiceConstsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CaseServiceConstsSchema(CaseServiceConstsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("4c96d0a7-eeac-44d3-afd1-3e92a22d0b77");
			Name = "CaseServiceConsts";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("33bac096-c819-4c57-86af-fe71bbb0cb56");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,181,210,189,106,195,48,20,5,224,57,129,188,131,72,151,118,80,176,44,255,54,116,144,100,187,116,41,33,201,11,168,242,77,16,56,150,107,201,129,80,242,238,181,157,205,20,82,10,221,36,157,203,249,52,220,90,158,192,54,82,1,218,67,219,74,107,14,110,37,76,125,208,199,174,149,78,155,26,125,45,230,139,249,172,179,186,62,162,221,197,58,56,173,199,151,135,22,142,67,46,42,105,237,51,218,116,31,149,86,99,210,140,71,100,93,95,160,144,26,114,36,164,133,29,180,103,173,160,175,183,206,14,189,179,201,104,11,178,52,117,117,65,175,157,46,209,22,172,169,186,225,15,239,198,233,131,86,227,127,246,77,245,86,162,151,113,100,181,145,173,133,199,165,79,195,56,21,41,199,44,163,62,14,66,223,195,9,13,41,142,57,163,140,9,30,82,150,46,159,214,247,192,220,58,125,26,145,45,124,118,96,221,79,150,72,10,78,188,130,96,222,147,56,224,81,128,211,140,132,56,246,139,192,203,243,152,68,49,255,133,197,148,211,103,237,46,125,107,31,234,70,214,110,107,42,216,155,9,71,89,148,164,84,228,152,69,57,193,89,65,8,78,99,194,177,231,145,44,242,242,148,38,34,250,59,39,212,148,19,255,201,113,53,245,56,35,44,102,89,118,223,187,222,150,14,234,242,182,119,195,245,250,13,207,17,185,53,190,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("4c96d0a7-eeac-44d3-afd1-3e92a22d0b77"));
		}

		#endregion

	}

	#endregion

}

