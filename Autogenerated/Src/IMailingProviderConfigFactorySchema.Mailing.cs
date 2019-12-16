namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IMailingProviderConfigFactorySchema

	/// <exclude/>
	public class IMailingProviderConfigFactorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IMailingProviderConfigFactorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IMailingProviderConfigFactorySchema(IMailingProviderConfigFactorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e17ee573-06a4-435b-80a1-7eb5968f81d8");
			Name = "IMailingProviderConfigFactory";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("5d774dd3-3f0d-4e5d-9409-9a3b17d3417e");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,146,65,106,195,48,16,69,215,49,248,14,194,221,180,155,104,159,56,222,4,10,94,4,66,105,15,160,202,35,71,16,75,102,36,23,66,232,221,59,150,228,214,110,3,165,93,25,205,124,253,255,70,99,35,58,112,189,144,192,158,1,81,56,171,252,122,111,141,210,237,128,194,107,107,242,236,154,103,171,193,105,211,46,36,8,219,60,163,206,29,66,75,50,86,27,15,168,200,104,195,234,131,208,103,210,31,209,190,233,6,48,250,61,10,233,45,94,194,37,206,57,43,221,208,117,2,47,85,58,39,181,99,29,248,147,109,28,83,22,153,68,32,10,138,214,198,121,97,164,166,190,85,204,159,128,238,3,140,125,181,43,110,7,22,188,90,79,89,124,22,214,15,175,103,45,201,49,1,255,198,187,186,6,230,207,73,15,145,111,195,142,193,40,54,191,79,20,10,251,145,158,136,19,60,252,21,253,39,123,172,244,2,69,199,12,173,110,87,12,46,92,50,32,199,109,21,85,61,203,154,229,188,44,101,228,95,242,96,243,229,138,224,7,52,174,122,138,223,255,81,151,124,178,25,125,111,235,210,187,76,164,247,75,54,182,156,232,97,155,94,31,76,19,23,16,206,239,241,231,91,20,169,246,1,67,40,91,221,207,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e17ee573-06a4-435b-80a1-7eb5968f81d8"));
		}

		#endregion

	}

	#endregion

}

