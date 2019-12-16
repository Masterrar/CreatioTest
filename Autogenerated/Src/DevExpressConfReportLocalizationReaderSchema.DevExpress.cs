namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: DevExpressConfReportLocalizationReaderSchema

	/// <exclude/>
	public class DevExpressConfReportLocalizationReaderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public DevExpressConfReportLocalizationReaderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public DevExpressConfReportLocalizationReaderSchema(DevExpressConfReportLocalizationReaderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("b09d9e73-d556-4a54-a201-d4168e35ab48");
			Name = "DevExpressConfReportLocalizationReader";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("bcd7b40a-afa2-4631-8983-51d02c873b88");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,147,193,110,219,48,12,134,207,46,208,119,32,178,139,3,4,126,128,118,9,48,184,93,81,160,29,178,52,235,206,154,205,58,2,108,201,161,164,44,94,176,119,31,101,185,176,227,54,107,78,54,233,159,228,239,79,162,18,21,154,90,100,8,107,36,18,70,191,216,36,213,234,69,22,142,132,149,90,93,94,28,46,47,34,103,164,42,224,169,49,22,171,235,81,156,60,72,181,125,147,76,117,89,98,230,59,152,228,14,21,146,204,122,205,112,22,225,169,124,114,171,172,180,18,205,123,130,181,214,165,73,110,112,119,187,175,9,141,89,97,173,201,38,15,58,19,165,252,211,90,231,50,46,252,68,88,112,0,105,41,140,185,130,190,194,255,102,168,26,22,173,80,228,72,109,101,237,126,149,50,131,204,23,158,89,7,87,112,63,246,244,94,247,232,208,78,232,205,49,38,75,46,179,154,216,227,178,29,28,20,157,137,243,198,199,63,12,18,11,84,32,15,238,40,156,130,63,202,40,26,137,230,35,153,167,29,253,237,252,161,202,131,197,99,191,75,210,53,146,63,27,118,75,114,39,44,118,118,67,0,163,25,163,240,0,5,218,107,248,96,200,35,218,141,206,79,240,144,109,39,65,205,103,6,199,87,99,6,225,185,0,143,98,136,38,190,115,50,7,106,145,173,177,170,75,246,119,159,191,194,216,9,2,52,91,166,160,240,55,180,55,174,121,202,54,88,137,239,14,169,25,17,77,134,130,71,161,68,129,52,131,73,56,143,21,26,237,40,67,51,153,182,12,35,238,155,124,201,115,94,5,87,169,120,242,141,119,237,196,167,103,81,186,163,111,95,101,105,145,140,215,196,62,78,9,217,118,200,254,148,118,179,20,196,221,188,36,14,201,84,87,181,32,105,180,90,55,53,175,206,214,137,146,157,141,47,227,100,246,150,68,55,54,252,90,191,183,144,245,175,115,207,136,247,216,142,69,35,62,93,43,66,235,104,216,128,215,181,63,177,120,15,243,5,236,125,59,239,181,131,208,34,232,14,115,241,10,107,6,231,104,59,122,211,255,220,220,144,61,78,114,238,31,147,44,107,150,255,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b09d9e73-d556-4a54-a201-d4168e35ab48"));
		}

		#endregion

	}

	#endregion

}

