namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IImportLoggerSchema

	/// <exclude/>
	public class IImportLoggerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IImportLoggerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IImportLoggerSchema(IImportLoggerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("0b874d1d-c36b-481a-b709-ada9ef850f84");
			Name = "IImportLogger";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,189,82,81,75,195,48,16,126,222,96,255,225,216,94,38,72,251,174,115,32,163,98,193,193,64,255,64,214,94,99,164,201,149,75,90,28,178,255,110,154,216,137,211,129,34,236,229,32,119,223,221,247,125,151,51,66,163,109,68,129,240,132,204,194,82,229,146,21,153,74,201,150,133,83,100,146,59,85,99,174,27,98,55,25,191,77,198,163,166,221,214,170,0,101,28,114,213,55,230,177,250,64,82,34,123,128,7,249,56,154,49,74,223,15,107,116,207,84,218,43,216,132,198,88,76,211,20,22,182,213,90,240,110,57,36,238,133,41,107,180,224,133,16,39,7,88,122,140,91,52,130,133,6,227,165,223,76,45,154,18,121,186,92,164,33,251,51,8,59,52,238,150,165,253,138,235,72,149,31,172,89,207,57,167,237,11,22,14,226,204,75,88,81,221,106,179,97,42,208,218,128,200,134,65,112,24,121,113,253,27,75,175,5,54,97,157,103,182,53,240,30,91,139,127,150,25,167,220,238,81,116,248,47,119,202,84,196,58,156,11,248,115,178,66,226,153,125,230,94,193,58,50,127,115,250,89,250,171,191,126,49,22,106,146,39,220,4,1,61,200,223,254,124,152,52,243,188,241,244,195,123,223,199,253,59,50,161,169,171,103,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("0b874d1d-c36b-481a-b709-ada9ef850f84"));
		}

		#endregion

	}

	#endregion

}

