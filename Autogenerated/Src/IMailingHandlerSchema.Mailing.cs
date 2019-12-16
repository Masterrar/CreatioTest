namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IMailingHandlerSchema

	/// <exclude/>
	public class IMailingHandlerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IMailingHandlerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IMailingHandlerSchema(IMailingHandlerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e6d073d5-261f-4fd0-a166-ab3452299b92");
			Name = "IMailingHandler";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("0a66fb70-43c4-43cd-a81c-f036ca2264c0");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,146,193,106,195,48,12,134,207,13,228,29,68,123,217,46,201,189,237,122,233,101,57,20,74,217,30,64,139,149,196,16,219,65,118,2,165,236,221,231,218,77,72,86,24,236,104,233,255,63,253,18,214,168,200,118,88,18,124,16,51,90,83,185,236,104,116,37,235,158,209,73,163,211,228,150,38,171,222,74,93,47,36,76,187,52,241,157,13,83,237,101,80,104,71,92,121,208,22,138,19,202,214,235,223,81,139,150,56,200,242,60,135,189,237,149,66,190,30,30,239,51,155,65,10,178,32,71,47,84,134,193,53,4,42,18,160,137,136,108,36,228,51,68,215,127,181,178,156,153,159,230,174,110,97,246,148,241,68,174,49,194,110,225,28,172,177,249,59,89,40,28,153,208,133,100,214,161,246,108,83,133,92,179,60,207,129,98,165,67,70,5,218,223,245,109,221,91,98,127,77,77,229,253,148,235,67,49,195,221,123,80,78,205,108,159,7,103,0,13,70,138,71,134,209,242,242,185,96,193,18,253,186,251,99,153,11,41,51,252,123,153,144,33,90,167,12,227,152,13,105,17,111,26,222,223,241,39,44,138,190,246,3,208,161,231,13,92,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e6d073d5-261f-4fd0-a166-ab3452299b92"));
		}

		#endregion

	}

	#endregion

}

