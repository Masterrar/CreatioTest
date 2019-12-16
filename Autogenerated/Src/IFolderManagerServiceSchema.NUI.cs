namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IFolderManagerServiceSchema

	/// <exclude/>
	public class IFolderManagerServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IFolderManagerServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IFolderManagerServiceSchema(IFolderManagerServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("c540fd1a-0f99-4be3-b6a9-232ced714c13");
			Name = "IFolderManagerService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("be1f674b-cdb4-46e4-8c46-23cae20b9205");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,181,83,81,107,194,48,16,126,174,224,127,8,250,162,80,250,3,148,189,76,182,209,129,83,172,195,7,241,33,54,215,26,150,38,93,146,58,202,240,191,239,218,180,138,162,194,96,131,188,228,187,251,238,190,251,46,145,52,3,147,211,24,200,18,180,166,70,37,54,152,40,153,240,180,208,212,114,37,131,103,37,24,232,41,149,52,5,29,129,222,243,24,186,157,239,110,199,43,12,151,41,137,74,99,33,27,95,220,131,38,115,170,24,136,187,193,96,5,91,76,192,148,190,134,20,59,146,80,90,208,9,106,26,145,240,122,119,15,207,186,185,161,90,171,105,108,7,111,56,10,121,32,189,107,148,222,112,131,148,188,216,10,30,19,222,214,191,89,190,154,238,40,103,10,118,167,152,25,145,121,77,175,165,122,235,89,14,206,160,182,255,166,134,113,152,80,238,213,7,12,28,173,18,52,159,69,203,158,79,222,53,95,66,150,11,106,107,153,200,219,131,182,78,1,134,31,21,43,35,91,138,42,136,85,166,96,12,138,58,162,193,74,211,60,7,230,147,170,143,183,128,207,2,12,178,117,70,237,25,195,65,193,171,81,210,39,11,92,174,146,6,238,231,213,230,120,123,197,25,57,83,53,120,41,16,146,240,229,174,33,54,175,145,156,106,144,246,4,26,171,171,229,34,198,109,25,197,59,200,104,181,140,225,248,175,188,10,101,44,10,6,79,85,3,14,38,148,191,117,173,177,203,255,47,239,206,190,76,243,142,90,62,185,161,126,208,216,102,84,161,99,56,217,118,244,147,161,72,46,93,201,83,180,30,225,204,241,137,18,69,38,171,96,91,186,110,85,54,219,74,46,247,148,112,129,31,192,56,205,237,146,250,32,153,123,240,120,59,184,255,120,132,240,205,29,126,0,66,16,89,146,42,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c540fd1a-0f99-4be3-b6a9-232ced714c13"));
		}

		#endregion

	}

	#endregion

}

