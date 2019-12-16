namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: JunkFilterConstsSchema

	/// <exclude/>
	public class JunkFilterConstsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public JunkFilterConstsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public JunkFilterConstsSchema(JunkFilterConstsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("2a61b393-d894-421c-9a81-38a44ebfda70");
			Name = "JunkFilterConsts";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("59955e0a-90db-4796-8f0c-f9403b7d622f");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,145,61,107,195,48,16,134,231,26,252,31,132,39,155,128,233,220,18,8,228,131,144,161,4,26,186,148,14,87,249,18,68,228,147,57,73,131,9,254,239,61,229,3,226,193,208,245,209,251,188,58,157,8,90,244,29,104,84,7,100,6,239,142,161,94,58,58,154,83,100,8,198,81,158,93,242,236,165,139,191,214,104,229,131,48,173,180,5,239,213,46,210,121,99,108,64,22,193,7,47,177,20,125,100,117,130,98,176,161,147,90,183,96,236,161,239,112,233,26,84,115,85,92,65,241,62,149,95,57,57,167,103,225,70,166,141,53,5,238,71,55,36,48,157,223,34,52,200,123,118,29,114,232,191,192,70,244,123,8,242,26,18,123,81,148,151,215,161,250,158,191,253,148,245,172,26,213,220,151,192,82,224,200,246,227,145,159,43,22,101,93,205,254,163,126,34,53,105,139,54,182,244,33,31,146,198,191,177,171,61,228,217,240,7,105,10,254,7,168,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("2a61b393-d894-421c-9a81-38a44ebfda70"));
		}

		#endregion

	}

	#endregion

}

