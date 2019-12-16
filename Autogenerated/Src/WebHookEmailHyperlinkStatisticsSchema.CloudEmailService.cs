namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: WebHookEmailHyperlinkStatisticsSchema

	/// <exclude/>
	public class WebHookEmailHyperlinkStatisticsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public WebHookEmailHyperlinkStatisticsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public WebHookEmailHyperlinkStatisticsSchema(WebHookEmailHyperlinkStatisticsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("360ea3e1-2a77-455d-9130-520eefc7c9b3");
			Name = "WebHookEmailHyperlinkStatistics";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("457f57e6-ba32-4a54-a8b9-9eba8360aae2");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,83,193,110,26,49,16,61,19,41,255,96,109,46,94,5,173,122,78,148,67,33,8,80,91,9,133,160,156,205,122,0,11,99,111,237,113,90,20,241,239,29,239,174,73,172,164,201,101,101,143,231,189,153,247,102,214,136,3,248,70,212,192,30,193,57,225,237,6,171,177,53,27,181,13,78,160,178,230,242,226,229,242,98,16,188,50,91,182,60,122,132,195,237,249,62,182,14,242,91,117,63,162,0,133,174,28,108,9,205,198,90,120,127,195,38,7,161,244,236,216,128,211,202,236,151,72,212,30,85,237,219,220,38,172,181,170,89,29,83,255,155,201,110,216,72,120,120,130,245,204,218,61,161,94,90,236,185,208,194,89,194,160,2,170,182,104,9,187,247,158,124,26,148,236,184,231,146,69,69,131,193,22,240,182,61,248,254,112,202,16,30,93,84,213,182,242,147,90,249,2,117,5,70,118,173,100,44,202,32,121,160,234,189,255,10,223,235,248,5,184,179,242,99,17,246,153,102,164,36,164,222,166,128,83,103,67,243,3,142,188,236,249,29,96,112,134,173,201,171,42,127,191,78,250,171,71,187,108,9,218,224,89,224,7,30,156,11,62,91,178,111,38,140,212,105,2,124,229,193,209,166,24,168,227,154,176,144,93,83,55,81,254,46,21,120,32,235,239,88,143,95,161,210,42,142,43,118,57,123,147,194,115,166,225,107,131,195,36,160,236,28,84,27,198,115,242,59,246,45,85,238,141,232,50,79,237,215,192,31,182,106,164,64,120,87,163,24,5,189,207,87,175,40,59,158,106,9,200,139,110,134,99,27,12,22,67,90,117,29,14,166,90,8,71,191,15,130,227,221,115,153,32,79,59,112,192,95,73,231,178,40,171,185,159,252,14,66,243,119,224,164,42,161,191,27,201,139,135,207,49,111,117,151,101,53,249,11,117,32,93,229,39,43,25,77,136,127,102,22,61,253,3,12,47,249,197,1,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("360ea3e1-2a77-455d-9130-520eefc7c9b3"));
		}

		#endregion

	}

	#endregion

}

