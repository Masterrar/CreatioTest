namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: PortalMessageFileCleanerSchema

	/// <exclude/>
	public class PortalMessageFileCleanerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public PortalMessageFileCleanerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public PortalMessageFileCleanerSchema(PortalMessageFileCleanerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("58b34129-eda1-43f6-b441-329cc91b3415");
			Name = "PortalMessageFileCleaner";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("c85d2d65-6230-4aeb-9934-bfac9785d42f");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,84,77,111,219,48,12,61,187,64,255,3,225,93,28,160,179,119,110,19,23,171,219,12,57,20,40,176,14,59,14,138,77,167,2,100,201,163,164,102,89,209,255,62,218,78,178,216,249,104,142,34,31,31,31,31,105,107,81,161,173,69,142,240,140,68,194,154,210,197,153,209,165,92,120,18,78,26,125,121,241,118,121,17,120,43,245,2,190,175,172,195,234,102,251,222,45,33,60,22,143,239,239,56,197,201,79,132,11,102,132,76,9,107,175,225,201,144,19,234,17,173,21,11,156,74,133,153,66,161,145,90,108,237,231,74,230,144,55,208,19,200,224,173,69,111,169,167,18,85,209,112,147,124,21,14,187,100,221,61,128,80,20,70,171,21,252,176,72,60,164,198,188,153,16,126,249,222,251,102,77,137,186,232,88,251,45,24,104,29,249,220,25,106,26,181,58,59,68,146,36,48,182,190,170,4,173,210,77,96,166,165,147,66,201,191,104,65,227,18,36,87,11,205,126,155,146,193,136,144,19,150,147,240,216,136,97,146,198,91,238,100,72,62,174,5,137,10,52,47,113,18,246,167,8,211,102,74,200,183,129,120,156,180,232,182,120,109,239,177,174,209,192,161,62,245,8,154,147,8,130,129,111,48,129,61,35,131,224,253,180,155,143,232,94,76,113,142,145,247,168,208,177,137,117,171,25,170,78,52,148,172,26,230,43,88,200,87,212,32,11,212,78,150,146,39,103,127,15,64,207,53,179,30,58,51,43,194,116,246,33,251,174,199,45,39,161,243,164,109,250,76,30,175,64,150,157,222,165,176,80,180,243,20,87,96,220,11,210,82,90,132,207,80,10,101,27,150,77,217,206,174,230,198,168,181,9,123,107,139,190,121,89,192,1,205,155,85,117,124,237,1,118,20,209,96,121,163,22,22,196,83,50,85,180,127,141,225,58,31,196,63,89,44,70,33,219,177,9,5,241,204,62,252,246,66,69,153,81,190,210,241,83,99,1,247,160,232,144,162,45,211,87,93,68,97,198,31,37,187,112,183,58,143,112,160,58,206,60,17,239,164,57,215,230,183,229,68,238,254,183,136,31,254,96,238,121,214,17,164,240,5,110,129,63,91,132,235,206,228,19,199,217,69,251,193,247,127,167,26,48,111,41,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("58b34129-eda1-43f6-b441-329cc91b3415"));
		}

		#endregion

	}

	#endregion

}

