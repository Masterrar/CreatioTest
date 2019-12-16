namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: GoogleSharedOAuthClientSchema

	/// <exclude/>
	public class GoogleSharedOAuthClientSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public GoogleSharedOAuthClientSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public GoogleSharedOAuthClientSchema(GoogleSharedOAuthClientSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("b6e2a4fc-fe7f-4b18-9691-d148df804de7");
			Name = "GoogleSharedOAuthClient";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("79d5e1e4-18af-4001-8dc1-26f09fca92c2");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,82,193,106,194,64,16,61,71,240,31,6,123,177,80,146,187,166,130,120,144,66,75,139,182,31,176,38,99,92,72,118,195,236,110,75,145,254,123,39,155,68,147,84,61,244,100,118,230,189,55,111,230,233,140,84,25,188,35,145,48,122,111,195,149,38,156,143,71,227,145,18,5,154,82,36,216,107,170,189,204,28,9,43,181,26,143,142,227,81,224,6,252,173,78,164,200,195,215,165,179,7,175,19,220,17,102,12,135,85,46,140,153,193,90,235,44,199,237,65,16,166,30,181,202,37,42,203,192,40,138,32,54,174,40,4,125,47,154,247,6,75,66,195,125,3,66,53,92,240,52,72,60,15,246,154,192,120,53,200,234,182,40,203,92,38,222,99,216,202,70,29,221,210,237,184,207,124,246,115,205,14,180,70,251,22,143,126,163,243,74,90,25,75,46,177,154,120,179,55,175,91,35,134,187,248,66,7,30,158,64,209,16,21,151,130,68,1,213,253,31,39,206,32,61,235,76,170,201,34,142,124,195,227,154,21,174,152,159,242,148,42,149,19,249,1,62,248,147,199,43,76,170,179,248,206,249,121,95,73,6,51,216,9,131,211,14,105,128,130,42,239,224,167,57,1,170,180,190,66,255,36,47,104,15,58,173,174,65,218,50,17,211,27,7,217,160,117,164,56,90,182,206,190,171,208,56,205,42,81,126,255,47,237,107,71,165,122,212,34,54,136,144,16,238,31,39,151,255,180,225,147,255,89,118,45,77,162,5,72,206,78,168,4,195,56,106,181,124,18,237,154,160,63,89,79,166,8,23,4,96,141,182,87,152,222,14,164,62,117,80,15,2,133,95,127,163,238,203,13,248,243,235,73,213,213,126,145,107,191,162,45,17,44,8,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b6e2a4fc-fe7f-4b18-9691-d148df804de7"));
		}

		#endregion

	}

	#endregion

}

