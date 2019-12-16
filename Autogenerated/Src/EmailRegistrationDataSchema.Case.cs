namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: EmailRegistrationDataSchema

	/// <exclude/>
	public class EmailRegistrationDataSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public EmailRegistrationDataSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public EmailRegistrationDataSchema(EmailRegistrationDataSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("472ffed7-d0b2-439a-902c-a1ccb20b2456");
			Name = "EmailRegistrationData";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("c3c90037-274c-4793-841e-197eb228d3cd");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,165,83,209,106,131,80,12,125,182,208,127,8,246,101,131,81,223,215,42,140,110,140,62,12,202,182,31,200,52,74,160,94,229,222,107,65,74,255,125,241,106,91,219,186,33,219,155,137,57,57,39,201,185,10,115,50,37,198,4,159,164,53,154,34,181,243,85,161,82,206,42,141,150,11,53,157,236,167,19,175,50,172,50,248,168,141,165,124,49,157,72,102,166,41,147,223,176,218,162,49,143,240,146,35,111,223,37,101,108,139,123,70,139,82,22,4,1,44,77,149,231,168,235,168,139,165,191,69,86,164,33,45,52,80,131,4,81,97,48,35,51,63,98,130,30,168,172,190,182,28,67,220,80,253,200,212,200,60,169,218,232,162,36,109,153,68,218,198,161,157,232,27,57,46,177,78,72,89,78,89,4,21,41,196,154,208,82,2,79,177,229,29,219,122,126,194,245,37,29,53,189,86,124,46,93,39,222,30,50,178,11,40,53,239,164,11,24,9,188,195,104,110,55,219,91,187,138,102,172,17,220,195,156,48,158,179,68,45,225,95,168,55,14,217,97,214,9,252,111,246,227,222,99,52,52,130,124,37,101,103,206,254,204,51,82,73,107,131,38,238,187,66,140,39,166,169,98,91,232,81,190,144,106,84,242,52,68,221,210,16,53,18,211,208,31,52,160,31,68,96,235,178,167,92,246,138,57,40,121,95,161,143,49,219,214,32,126,116,57,245,201,101,203,192,1,162,65,60,223,224,110,206,245,43,190,188,188,212,117,179,159,44,112,211,115,232,26,131,235,184,115,55,58,143,253,208,30,141,143,31,87,130,238,193,189,94,239,252,144,32,236,161,23,238,167,75,114,23,92,123,47,188,110,233,202,6,28,209,229,250,169,195,55,92,225,13,173,5,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("472ffed7-d0b2-439a-902c-a1ccb20b2456"));
		}

		#endregion

	}

	#endregion

}

