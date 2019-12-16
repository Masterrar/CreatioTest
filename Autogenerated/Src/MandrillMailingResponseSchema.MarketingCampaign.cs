namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: MandrillMailingResponseSchema

	/// <exclude/>
	public class MandrillMailingResponseSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public MandrillMailingResponseSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public MandrillMailingResponseSchema(MandrillMailingResponseSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("300c4950-cc6e-4d74-b555-e972ea0b4444");
			Name = "MandrillMailingResponse";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("aa578739-72a4-4d6e-8c15-4350e99d075d");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,144,79,75,196,64,12,197,207,21,252,14,129,189,183,119,119,241,178,130,120,40,44,91,111,226,33,157,77,235,192,252,41,51,25,113,21,191,187,233,180,93,87,65,197,219,228,205,123,201,47,113,104,41,14,168,8,238,41,4,140,190,227,114,235,93,167,251,20,144,181,119,101,141,238,16,180,49,13,133,103,45,190,183,203,139,34,69,237,122,104,142,145,201,174,191,213,229,62,57,214,150,74,9,104,52,250,53,183,17,151,248,86,129,122,41,96,107,48,198,43,88,90,215,168,141,52,216,11,137,119,145,178,181,170,42,216,196,100,45,134,227,181,252,36,195,224,59,224,39,58,197,32,206,72,118,202,151,155,106,9,72,131,135,27,100,148,85,56,160,226,71,17,134,212,26,173,64,141,179,127,26,61,110,39,214,19,232,46,248,129,2,107,18,218,93,206,79,255,95,232,22,225,147,114,6,2,122,33,149,242,21,79,161,115,196,137,177,38,219,82,24,9,23,196,214,123,3,77,82,138,132,116,188,119,81,244,196,235,252,136,243,227,253,23,144,121,41,136,140,156,226,255,102,223,38,125,128,38,7,239,14,127,12,95,145,28,49,31,74,170,73,59,151,68,249,0,244,35,18,158,95,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("300c4950-cc6e-4d74-b555-e972ea0b4444"));
		}

		#endregion

	}

	#endregion

}

