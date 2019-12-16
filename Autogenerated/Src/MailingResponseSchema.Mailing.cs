namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: MailingResponseSchema

	/// <exclude/>
	public class MailingResponseSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public MailingResponseSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public MailingResponseSchema(MailingResponseSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("d3aa9b5b-0ffb-4cd9-a76c-7a7c5b382b5e");
			Name = "MailingResponse";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6e206974-7c3f-4704-9c49-6b38b2d992b2");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,146,79,107,195,48,12,197,207,41,244,59,8,122,79,238,237,216,97,221,40,131,21,74,179,219,216,193,113,212,204,44,142,131,45,143,181,165,223,125,178,147,148,236,95,97,59,69,121,145,222,251,217,74,35,52,186,86,72,132,71,180,86,56,179,163,116,105,154,157,170,188,21,164,76,3,199,233,36,241,78,53,21,228,123,71,168,23,95,222,211,173,111,72,105,76,115,180,74,212,234,16,199,184,139,251,102,22,171,224,177,172,133,115,115,88,11,85,243,224,150,19,77,227,48,182,100,89,6,87,206,107,45,236,254,26,122,97,99,205,155,42,209,65,107,77,139,150,20,151,102,7,244,130,80,248,250,21,80,179,19,56,108,202,192,97,163,31,31,33,29,252,178,193,144,133,167,91,65,130,143,68,86,72,122,102,161,245,69,173,36,200,192,244,29,41,57,70,172,51,250,230,76,48,135,77,156,236,190,127,226,30,4,182,241,53,5,212,158,45,61,183,142,145,58,166,53,234,2,109,32,26,144,10,99,106,200,189,148,200,100,225,222,147,164,66,90,196,194,245,197,233,66,252,205,232,110,72,144,119,127,139,95,121,85,66,30,7,239,203,255,228,175,144,120,79,150,15,207,79,124,151,216,134,95,225,23,136,62,244,110,104,27,85,71,8,177,193,102,1,125,94,223,237,200,134,141,111,81,171,120,191,15,242,144,71,105,105,74,252,105,110,198,123,232,54,201,111,157,54,150,166,147,211,7,37,174,147,121,2,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d3aa9b5b-0ffb-4cd9-a76c-7a7c5b382b5e"));
		}

		#endregion

	}

	#endregion

}

