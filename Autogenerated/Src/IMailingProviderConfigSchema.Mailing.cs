namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IMailingProviderConfigSchema

	/// <exclude/>
	public class IMailingProviderConfigSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IMailingProviderConfigSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IMailingProviderConfigSchema(IMailingProviderConfigSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("6ab8d5ed-b75b-496a-b8f0-ba3fbf460468");
			Name = "IMailingProviderConfig";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("5d774dd3-3f0d-4e5d-9409-9a3b17d3417e");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,165,81,65,106,195,48,16,60,219,224,63,44,201,221,190,167,105,160,180,20,124,40,4,154,15,108,229,149,43,176,36,179,146,10,193,244,239,85,37,59,164,1,151,66,111,59,179,51,179,35,100,80,147,27,81,16,156,136,25,157,149,190,126,180,70,170,62,48,122,101,77,85,78,85,89,149,197,150,169,143,16,90,227,137,101,52,236,160,125,65,53,40,211,31,217,126,168,142,56,251,146,186,105,26,216,187,160,53,242,249,48,227,89,230,64,36,29,88,9,254,157,64,231,16,24,231,148,122,177,55,87,254,49,188,13,74,128,90,142,175,222,46,114,219,75,221,184,31,137,189,34,183,131,99,10,201,251,219,130,137,104,141,243,104,98,250,92,109,239,136,64,48,201,251,205,114,239,68,122,28,208,211,51,10,111,249,188,105,14,245,37,238,186,112,177,98,128,91,60,125,139,139,158,252,93,26,220,60,124,254,175,230,67,232,20,69,201,19,122,124,181,129,197,223,11,175,90,97,125,51,193,175,175,216,146,233,242,127,36,156,217,159,100,228,190,0,61,175,39,69,139,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("6ab8d5ed-b75b-496a-b8f0-ba3fbf460468"));
		}

		#endregion

	}

	#endregion

}

