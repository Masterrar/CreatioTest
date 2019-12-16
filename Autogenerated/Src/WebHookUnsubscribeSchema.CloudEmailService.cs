namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: WebHookUnsubscribeSchema

	/// <exclude/>
	public class WebHookUnsubscribeSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public WebHookUnsubscribeSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public WebHookUnsubscribeSchema(WebHookUnsubscribeSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("b1ddfecd-6e11-4638-88ce-8129d7b2cfcd");
			Name = "WebHookUnsubscribe";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("457f57e6-ba32-4a54-a8b9-9eba8360aae2");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,83,77,111,219,48,12,61,167,64,255,131,224,93,36,44,48,176,107,139,29,218,52,75,130,110,65,134,52,232,89,150,152,84,168,45,185,148,148,205,40,246,223,39,249,11,86,186,157,98,62,146,143,79,143,140,230,21,216,154,11,32,79,128,200,173,57,186,124,97,244,81,157,60,114,167,140,190,190,122,191,190,154,121,171,244,137,236,27,235,160,186,29,227,133,65,72,163,252,225,62,0,1,250,132,112,10,221,100,81,114,107,111,200,65,91,95,88,129,170,128,54,93,251,162,84,130,136,152,157,38,201,13,185,231,22,158,161,88,27,243,26,10,223,219,242,145,110,135,166,6,116,10,2,231,174,229,232,242,61,159,117,24,149,44,43,174,202,59,41,17,2,123,148,63,155,157,192,221,182,31,182,255,248,211,19,131,150,29,119,140,167,163,126,128,123,49,242,223,115,204,57,152,165,36,12,3,87,224,86,104,124,253,8,13,101,253,68,4,231,81,147,34,60,39,79,243,159,19,129,83,53,151,244,103,163,36,89,115,45,203,193,18,122,176,128,97,65,26,68,220,14,241,73,56,204,62,115,36,193,211,61,148,1,255,233,1,27,242,149,104,248,69,58,132,94,116,181,61,179,176,247,210,87,154,118,63,241,10,172,163,95,216,144,253,134,166,162,89,64,29,23,110,97,170,202,107,37,218,19,201,134,146,231,23,64,24,107,54,50,99,249,198,46,223,60,47,71,48,155,103,17,239,27,238,180,140,153,9,215,83,83,195,164,96,104,239,53,237,56,134,123,117,128,52,62,102,229,149,164,31,186,91,221,54,111,45,222,72,198,146,89,91,95,21,128,19,93,31,136,167,171,97,140,112,219,123,214,95,79,98,106,190,175,65,168,99,179,53,223,141,120,93,43,237,44,101,93,97,212,119,168,37,119,112,97,246,156,140,86,12,202,246,224,104,246,96,182,198,133,229,182,243,179,57,73,182,224,208,3,75,93,30,162,229,111,21,158,75,83,97,44,192,32,124,24,206,254,127,236,17,157,197,191,106,130,6,240,47,63,11,208,198,20,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b1ddfecd-6e11-4638-88ce-8129d7b2cfcd"));
		}

		#endregion

	}

	#endregion

}

