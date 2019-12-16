namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: DevExpressReportParametersConfiguratorSchema

	/// <exclude/>
	public class DevExpressReportParametersConfiguratorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public DevExpressReportParametersConfiguratorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public DevExpressReportParametersConfiguratorSchema(DevExpressReportParametersConfiguratorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("708ab0c5-586e-4ce4-adb4-06e137393fca");
			Name = "DevExpressReportParametersConfigurator";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("72ee322a-d034-4f96-8457-df052341cb21");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,205,84,201,110,219,48,16,61,43,64,254,97,234,2,129,4,24,68,207,113,221,67,98,187,112,139,4,65,237,244,18,228,192,74,35,155,0,77,170,92,140,184,142,255,61,164,86,75,117,17,249,214,139,168,153,225,123,124,179,144,130,110,80,103,52,70,88,162,82,84,203,212,144,91,41,82,182,178,138,26,38,197,229,197,254,242,34,176,154,137,85,107,203,102,35,5,249,166,165,24,157,12,43,252,151,159,204,104,108,164,98,168,79,237,184,183,140,44,80,109,89,140,119,50,65,78,38,212,80,39,200,40,135,234,5,152,190,24,20,218,41,247,252,14,240,81,225,202,89,48,23,6,85,234,50,189,134,249,4,183,211,151,76,161,214,63,48,147,202,60,80,229,234,224,226,186,201,93,170,28,158,217,95,156,197,192,42,116,127,112,176,207,9,106,1,119,104,214,50,209,215,240,144,83,22,193,173,100,9,84,56,108,168,194,71,141,202,249,5,198,190,11,96,91,230,208,67,131,165,148,92,147,174,156,191,28,160,242,101,8,133,249,21,5,230,10,91,109,134,248,216,138,70,165,116,20,73,161,62,183,15,69,65,219,206,42,189,91,78,181,75,238,140,210,62,77,48,165,150,155,27,38,18,215,212,208,236,50,148,105,216,179,192,209,16,238,157,27,198,48,232,7,24,68,207,77,63,99,175,182,167,88,56,99,98,122,53,189,212,240,159,246,30,246,249,9,44,133,176,64,147,70,154,187,193,86,24,24,143,225,19,188,190,182,129,164,91,25,191,77,88,206,43,198,64,161,177,42,127,48,2,63,75,238,155,186,7,129,198,107,8,183,84,65,86,33,221,109,123,135,186,166,60,169,242,169,102,34,223,113,247,12,31,10,29,112,117,5,173,136,15,12,102,140,123,204,160,166,12,222,227,35,63,41,183,126,240,26,119,238,41,18,11,14,128,92,99,205,230,21,118,54,86,130,154,35,3,159,127,90,40,113,196,254,93,117,189,116,125,103,148,179,63,248,185,20,249,165,203,68,150,114,97,148,191,60,81,52,58,230,66,253,123,86,211,149,196,228,198,50,158,76,171,72,216,46,241,84,24,102,118,139,120,141,27,250,56,79,134,157,177,107,232,207,41,249,81,134,253,203,218,104,175,207,60,148,63,229,122,104,70,232,208,251,165,114,190,55,132,44,172,84,238,6,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("708ab0c5-586e-4ce4-adb4-06e137393fca"));
		}

		#endregion

	}

	#endregion

}

