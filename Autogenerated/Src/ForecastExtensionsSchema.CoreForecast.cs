namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ForecastExtensionsSchema

	/// <exclude/>
	public class ForecastExtensionsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ForecastExtensionsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ForecastExtensionsSchema(ForecastExtensionsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("37600005-73d0-4dab-84da-b6cf0e99d1be");
			Name = "ForecastExtensions";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("e0b9d996-6f7e-4520-a678-da960c79be39");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,83,77,111,219,48,12,61,187,64,255,3,209,94,18,32,179,129,30,151,44,151,46,11,12,108,109,176,165,3,118,84,108,58,21,96,73,30,41,99,53,130,252,247,73,242,71,156,100,24,122,176,97,61,242,61,62,146,178,22,10,185,18,25,194,22,137,4,155,194,198,143,70,23,114,95,147,176,210,232,248,139,33,204,4,219,159,15,183,55,135,219,155,168,102,169,247,240,163,97,139,106,126,113,118,212,178,196,204,243,56,94,163,70,146,217,85,206,87,169,127,159,192,113,89,165,140,118,17,23,187,39,220,59,17,120,44,5,243,71,232,61,172,222,44,106,246,234,33,43,73,18,88,112,173,148,160,102,217,157,95,172,44,165,149,200,128,67,50,20,134,252,19,52,56,238,153,201,136,90,213,187,82,102,192,214,53,157,65,230,203,254,179,106,116,8,149,7,131,223,208,190,154,220,89,220,4,129,54,120,233,43,0,107,180,12,149,155,136,75,135,93,3,50,15,78,66,44,45,186,136,71,65,16,2,170,202,54,240,1,8,109,77,250,68,244,157,100,53,17,106,11,13,10,242,74,29,213,54,21,14,138,103,205,181,72,37,72,40,208,110,225,159,238,90,202,119,172,12,75,107,168,185,91,110,186,2,52,96,241,34,9,148,255,41,164,57,159,168,50,119,174,100,33,145,248,61,220,173,243,155,230,61,61,216,31,73,92,43,116,163,88,46,146,254,203,135,206,23,151,174,116,173,144,196,174,196,69,171,187,244,131,239,55,217,57,157,216,87,201,144,110,46,134,0,151,83,153,129,175,16,69,99,213,117,45,157,230,208,253,12,60,0,227,142,166,112,8,52,89,192,100,200,139,83,126,170,203,242,153,86,126,177,147,105,159,20,181,189,92,149,118,127,207,224,118,44,62,131,207,194,226,86,42,140,95,108,246,100,254,196,191,220,45,152,206,131,216,49,188,223,173,232,108,77,231,161,197,99,119,169,81,231,237,189,14,231,22,61,7,143,127,1,67,108,111,212,49,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("37600005-73d0-4dab-84da-b6cf0e99d1be"));
		}

		#endregion

	}

	#endregion

}

