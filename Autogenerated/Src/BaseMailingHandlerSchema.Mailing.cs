namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: BaseMailingHandlerSchema

	/// <exclude/>
	public class BaseMailingHandlerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public BaseMailingHandlerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public BaseMailingHandlerSchema(BaseMailingHandlerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("c034f568-64d4-4b23-8e61-b1ebaf6fc883");
			Name = "BaseMailingHandler";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("0a66fb70-43c4-43cd-a81c-f036ca2264c0");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,84,219,110,219,48,12,125,118,129,254,3,145,189,180,64,97,191,215,105,128,45,195,178,14,232,16,172,235,7,200,50,147,168,144,37,67,151,0,65,208,127,31,45,201,174,157,173,233,250,40,242,144,231,144,60,182,98,13,218,150,113,132,223,104,12,179,122,227,242,165,86,27,177,245,134,57,161,213,229,197,241,242,34,243,86,168,45,60,30,172,195,134,242,82,34,239,146,54,95,161,66,35,120,57,96,198,109,12,190,21,207,31,249,14,107,47,209,16,130,48,159,12,110,169,31,44,37,179,246,22,190,48,139,15,76,72,42,252,206,84,77,176,128,42,138,2,230,214,55,13,51,135,69,122,119,80,104,34,22,118,17,156,247,216,98,4,110,125,37,5,7,86,89,103,24,119,192,59,170,127,48,193,45,220,159,114,103,199,192,63,200,252,38,80,214,164,115,109,196,158,57,140,201,54,62,192,32,171,181,146,7,32,162,78,212,179,174,86,70,251,246,39,173,26,238,96,150,154,207,202,212,19,85,29,219,78,57,214,70,183,104,156,192,192,163,29,109,28,235,158,41,61,95,167,73,92,4,228,104,109,160,234,238,150,101,91,116,221,17,178,151,247,74,127,232,234,127,202,246,194,56,207,228,168,234,117,184,161,20,142,180,5,231,141,154,12,95,194,203,168,229,91,115,63,160,219,233,250,220,208,189,132,175,34,152,144,238,59,143,106,110,64,87,207,132,89,192,10,221,154,25,226,116,104,236,213,147,69,67,166,86,209,180,224,39,207,235,36,59,9,86,94,202,242,67,50,131,175,98,242,212,160,33,176,36,67,56,180,32,148,117,76,209,151,166,55,224,118,56,54,235,223,110,141,145,182,155,1,20,205,113,55,155,170,158,45,238,71,237,186,28,240,33,153,207,139,80,25,26,157,250,126,175,69,157,52,245,45,222,89,80,121,102,184,95,216,232,253,135,135,75,154,250,67,6,73,177,211,32,169,63,203,231,182,29,254,21,121,196,144,231,174,146,91,111,38,6,188,62,115,184,24,157,6,41,246,7,77,184,140,46,0,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c034f568-64d4-4b23-8e61-b1ebaf6fc883"));
		}

		#endregion

	}

	#endregion

}

