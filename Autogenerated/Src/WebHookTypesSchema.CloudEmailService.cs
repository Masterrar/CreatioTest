namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: WebHookTypesSchema

	/// <exclude/>
	public class WebHookTypesSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public WebHookTypesSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public WebHookTypesSchema(WebHookTypesSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("3d2ed00b-c1c2-42d1-a51d-b896bc7b6d83");
			Name = "WebHookTypes";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("457f57e6-ba32-4a54-a8b9-9eba8360aae2");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,83,77,107,220,48,16,61,59,144,255,32,146,139,23,130,127,64,151,94,118,215,77,32,9,132,218,161,135,82,138,44,207,58,34,178,228,142,198,38,38,228,191,87,178,229,245,58,53,189,136,209,124,60,189,121,51,210,188,6,219,112,1,44,7,68,110,205,145,146,189,209,71,89,181,200,73,26,125,121,241,126,121,17,181,86,234,138,101,189,37,168,183,167,251,222,32,204,183,115,0,132,228,176,115,33,23,188,70,168,28,14,219,43,110,237,23,182,227,22,126,64,113,103,204,235,16,110,218,66,73,193,120,97,9,185,32,38,124,218,50,43,122,31,50,79,72,79,104,26,64,146,224,224,158,134,242,49,30,160,50,114,196,45,73,145,118,160,41,239,27,215,155,63,124,31,81,84,1,109,7,195,6,227,35,20,163,236,56,1,59,184,35,151,53,176,223,224,203,253,117,123,6,126,10,167,83,116,198,13,86,132,64,45,106,22,248,63,147,84,210,147,77,110,129,50,126,132,236,143,242,117,241,252,192,102,100,244,49,241,154,128,230,12,246,149,117,92,181,112,150,24,120,95,131,46,71,93,150,34,61,2,189,152,114,93,161,147,216,157,145,37,187,227,186,84,147,218,241,179,5,116,11,160,65,248,233,179,118,113,221,108,23,56,133,49,138,229,216,47,17,14,187,244,13,68,75,6,89,89,76,230,13,251,63,240,216,49,97,63,245,62,151,38,110,160,72,57,114,109,249,144,28,7,189,162,229,187,255,82,253,132,179,55,117,45,87,129,194,196,8,79,10,51,193,73,188,176,56,125,19,208,12,132,97,179,66,237,187,81,170,224,226,117,13,244,145,187,193,235,106,158,127,32,250,96,170,36,69,52,248,205,96,205,41,190,250,25,2,99,59,152,184,253,22,96,109,240,218,228,179,194,191,174,110,216,114,103,2,255,35,87,22,22,75,61,206,169,147,72,45,87,204,77,221,127,84,183,135,183,104,218,230,30,250,120,106,42,32,248,143,146,228,38,27,18,67,39,235,139,54,122,151,206,193,247,23,151,231,245,153,82,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("3d2ed00b-c1c2-42d1-a51d-b896bc7b6d83"));
		}

		#endregion

	}

	#endregion

}

