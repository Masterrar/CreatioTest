namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: WebHookRecipientStatisticsSchema

	/// <exclude/>
	public class WebHookRecipientStatisticsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public WebHookRecipientStatisticsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public WebHookRecipientStatisticsSchema(WebHookRecipientStatisticsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("c3b27763-2441-4674-8d5c-c63f7ac8c316");
			Name = "WebHookRecipientStatistics";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("457f57e6-ba32-4a54-a8b9-9eba8360aae2");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,83,77,111,219,48,12,61,187,64,255,131,144,94,28,108,240,15,104,177,75,220,32,13,134,96,65,147,96,103,69,102,93,34,178,100,72,84,182,162,232,127,31,253,149,84,169,129,229,38,145,239,145,212,227,147,145,21,248,90,42,16,91,112,78,122,251,66,89,110,205,11,150,193,73,66,107,110,111,222,111,111,146,224,209,148,98,243,230,9,170,135,139,59,227,181,6,213,128,125,182,0,3,14,213,25,147,91,7,241,45,123,156,113,128,67,119,14,74,38,137,92,75,239,239,197,51,40,172,17,12,109,136,59,123,66,229,91,88,29,246,26,149,80,13,106,12,36,238,197,76,122,248,13,251,39,107,15,76,120,111,105,167,242,107,103,107,112,132,192,61,214,109,173,46,223,215,93,4,44,206,101,119,203,66,52,15,78,146,18,232,161,61,248,254,240,241,149,54,175,36,234,107,25,158,92,35,193,51,235,205,74,65,110,11,184,142,136,134,196,175,26,140,191,30,158,243,225,240,63,252,29,152,162,211,40,22,108,5,244,106,139,113,181,236,145,109,130,60,121,255,154,5,208,194,217,80,255,132,183,116,218,247,115,64,193,25,177,231,165,100,113,254,91,36,116,182,181,155,182,74,58,29,121,198,169,211,209,178,210,79,210,20,122,216,113,186,243,224,216,165,166,115,157,8,209,117,24,67,91,158,143,176,2,182,74,85,139,31,162,103,239,8,53,54,118,104,134,155,215,86,189,110,25,148,206,143,60,213,163,36,232,134,73,12,252,17,75,222,147,163,244,162,126,155,78,178,165,33,155,78,86,60,152,67,173,87,224,189,44,97,216,238,100,64,109,128,206,160,101,49,249,206,127,64,135,202,100,107,233,248,239,17,184,244,179,38,211,136,247,217,43,227,204,115,62,102,182,126,25,163,180,137,24,219,153,101,12,220,101,98,244,118,80,116,140,112,146,59,230,204,130,62,244,127,101,140,213,167,78,156,249,95,80,129,32,182,197,133,91,187,104,28,252,248,7,60,38,8,14,206,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c3b27763-2441-4674-8d5c-c63f7ac8c316"));
		}

		#endregion

	}

	#endregion

}

