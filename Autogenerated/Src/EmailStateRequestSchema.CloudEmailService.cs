namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: EmailStateRequestSchema

	/// <exclude/>
	public class EmailStateRequestSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public EmailStateRequestSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public EmailStateRequestSchema(EmailStateRequestSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e71e3e74-ee53-49b0-8b08-eff380e4bbfa");
			Name = "EmailStateRequest";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b39fd9cb-6840-4142-8022-7c9d0489d323");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,181,146,193,78,195,48,12,134,207,157,196,59,88,227,2,151,246,206,128,29,198,52,237,0,154,214,221,16,135,172,117,187,136,54,41,142,139,52,38,222,29,55,217,166,109,2,132,64,156,18,59,246,175,239,119,108,84,141,174,81,25,194,2,137,148,179,5,199,35,107,10,93,182,164,88,91,115,214,219,156,245,162,214,105,83,66,186,118,140,245,224,36,142,231,173,97,93,99,156,34,105,85,233,55,223,39,85,82,119,78,88,74,0,163,74,57,119,5,227,90,233,42,101,197,56,199,151,22,29,251,162,36,73,224,218,181,117,173,104,125,187,141,231,216,16,58,52,236,128,66,41,216,2,120,133,128,157,6,184,78,4,28,210,171,206,48,222,137,36,7,42,143,119,138,149,88,97,82,25,63,73,162,105,151,149,206,32,235,80,62,35,137,54,158,102,207,60,35,219,32,177,70,1,159,249,222,240,126,138,235,19,19,20,82,75,66,36,103,64,156,230,192,22,178,21,102,207,241,190,239,144,48,32,222,99,189,68,186,120,144,143,128,27,232,251,222,105,222,191,236,144,119,204,147,86,231,195,192,44,170,221,135,68,81,137,60,240,23,183,189,188,255,20,79,102,71,12,121,55,192,237,76,197,167,182,57,20,190,194,112,48,224,126,131,239,181,37,143,199,6,186,204,66,118,100,8,233,174,224,207,54,208,228,255,100,66,148,191,179,48,14,207,95,26,128,237,30,137,76,88,37,31,7,95,199,73,201,125,0,198,57,178,115,129,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e71e3e74-ee53-49b0-8b08-eff380e4bbfa"));
		}

		#endregion

	}

	#endregion

}

