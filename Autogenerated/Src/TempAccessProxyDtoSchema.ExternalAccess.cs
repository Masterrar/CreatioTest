namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: TempAccessProxyDtoSchema

	/// <exclude/>
	public class TempAccessProxyDtoSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public TempAccessProxyDtoSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public TempAccessProxyDtoSchema(TempAccessProxyDtoSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("04544653-713e-4c63-ac57-d9a457053d3c");
			Name = "TempAccessProxyDto";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("f214e3c2-8cc2-4e62-be3f-96a9b4832c80");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,149,205,110,219,48,12,199,207,45,208,119,32,208,75,119,137,239,75,80,96,72,130,34,64,49,4,93,242,0,170,76,123,68,101,201,211,199,208,32,232,187,143,178,19,45,115,227,180,78,118,178,69,243,79,254,40,153,148,22,21,186,90,72,132,21,90,43,156,41,252,104,106,116,65,101,176,194,147,209,163,249,171,71,171,133,250,38,37,58,183,20,242,69,148,120,115,189,189,185,190,10,142,116,9,63,54,206,99,53,238,172,57,138,82,40,99,8,55,122,64,141,150,36,251,176,215,173,197,146,173,48,85,194,185,175,252,32,212,254,9,157,9,150,51,52,46,89,150,193,196,133,170,18,118,115,191,91,183,126,96,247,142,144,163,147,150,234,6,114,175,201,14,68,117,120,86,36,65,198,52,239,179,92,109,155,76,137,102,105,77,141,214,19,50,210,178,81,182,223,187,40,141,225,1,189,3,99,193,197,167,255,137,156,164,129,163,124,148,52,89,87,52,249,45,84,192,180,92,245,200,254,122,237,10,112,222,198,109,109,43,88,228,176,133,18,253,56,230,30,195,219,16,72,205,103,13,166,56,0,30,70,123,82,127,26,251,123,148,158,13,190,219,166,245,211,226,172,237,253,87,119,26,116,109,233,2,206,224,188,169,208,242,129,114,40,42,136,95,239,166,139,217,151,129,216,159,8,211,91,197,78,123,201,127,146,90,108,24,246,49,217,59,204,71,114,126,50,127,173,201,138,103,133,251,126,92,232,194,220,67,234,206,99,232,183,168,243,182,85,155,117,107,237,24,59,147,229,104,154,222,249,146,188,83,33,64,60,199,128,135,94,60,5,161,128,88,254,241,164,233,201,250,127,231,77,66,12,154,126,133,182,53,135,55,243,39,254,167,203,26,55,39,87,43,177,57,3,175,71,217,135,57,107,221,47,163,77,155,138,205,17,198,139,5,214,171,41,228,194,35,220,81,1,66,111,248,214,225,235,176,34,141,249,192,174,62,8,26,3,158,42,106,198,223,87,196,165,204,147,38,154,206,108,139,183,63,44,119,135,96,228,7,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("04544653-713e-4c63-ac57-d9a457053d3c"));
		}

		#endregion

	}

	#endregion

}

