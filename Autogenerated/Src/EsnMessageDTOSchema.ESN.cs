namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: EsnMessageDTOSchema

	/// <exclude/>
	public class EsnMessageDTOSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public EsnMessageDTOSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public EsnMessageDTOSchema(EsnMessageDTOSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("6c636fc5-728b-4126-9e55-9608ee750af1");
			Name = "EsnMessageDTO";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b66b5ae8-46e0-4931-ad78-c2c1ba5fd6ea");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,205,149,193,78,219,64,16,134,207,70,226,29,86,112,9,23,231,14,234,1,76,84,85,34,33,34,1,14,17,135,137,61,113,87,177,119,173,221,89,42,55,234,187,119,215,9,198,54,118,186,229,210,94,44,101,255,127,190,157,153,140,199,2,114,212,5,196,200,150,168,20,104,185,161,48,146,98,195,83,163,128,184,20,225,100,49,59,61,217,157,158,4,70,115,145,178,69,169,9,243,171,206,239,240,193,8,226,57,134,11,84,28,50,254,179,138,125,119,189,195,103,134,59,211,43,143,113,42,19,204,194,91,32,176,55,146,130,152,108,128,13,57,87,152,218,104,22,101,160,245,37,155,104,49,69,173,33,197,219,229,125,101,40,204,58,227,49,139,157,222,144,111,64,239,45,193,174,178,5,43,199,158,98,190,70,53,154,217,66,217,23,118,54,177,121,82,249,45,57,187,120,113,150,3,234,171,225,9,123,147,216,142,165,72,87,76,187,199,175,97,212,225,218,54,73,147,114,5,31,180,46,42,216,227,206,81,36,251,34,91,5,55,42,126,64,72,58,85,175,154,157,114,87,142,199,171,41,18,36,246,120,89,22,56,34,251,144,155,209,135,134,92,84,9,118,155,214,190,129,141,199,151,67,173,12,234,4,231,74,22,168,136,163,77,114,94,241,134,187,211,219,98,255,230,70,50,207,81,80,36,237,96,181,65,92,16,107,170,222,68,133,64,152,220,148,109,220,157,148,91,83,68,50,51,185,120,130,204,32,171,141,127,73,190,23,189,163,80,171,190,184,59,208,116,29,187,23,104,128,216,52,248,66,255,237,220,31,207,106,17,127,199,28,30,143,36,87,59,62,3,118,103,189,201,118,77,222,127,16,223,226,192,96,214,146,63,75,108,231,10,95,57,254,112,106,155,184,46,9,87,47,172,227,241,69,207,65,97,55,199,143,211,190,119,249,191,150,153,84,253,99,238,148,62,76,115,217,121,239,191,103,197,9,255,180,0,187,43,173,19,196,222,214,87,95,33,199,102,238,147,211,246,31,125,84,236,201,111,5,44,97,20,218,7,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("6c636fc5-728b-4126-9e55-9608ee750af1"));
		}

		#endregion

	}

	#endregion

}

