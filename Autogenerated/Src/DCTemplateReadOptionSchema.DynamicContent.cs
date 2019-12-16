namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: DCTemplateReadOptionSchema

	/// <exclude/>
	public class DCTemplateReadOptionSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public DCTemplateReadOptionSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public DCTemplateReadOptionSchema(DCTemplateReadOptionSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f88a83ea-c4fe-4ac2-870c-f6abbd2f69d5");
			Name = "DCTemplateReadOption";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("ad993b20-8db8-48d6-9762-5a83fb4975c6");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,144,75,107,195,64,12,132,207,54,248,63,8,114,45,118,147,99,219,20,74,146,146,83,10,105,122,42,61,40,182,108,22,246,197,74,11,49,33,255,189,235,71,33,135,222,118,52,163,111,197,88,52,196,30,107,130,19,133,128,236,90,41,55,206,182,170,139,1,69,57,91,110,123,139,70,213,105,40,100,165,200,175,69,158,69,86,182,131,207,158,133,204,115,145,167,201,34,80,151,210,176,179,209,60,193,118,115,34,227,53,10,29,9,155,15,63,128,198,88,85,85,240,194,209,24,12,253,235,172,39,155,129,210,42,180,46,64,72,59,12,50,19,74,248,98,98,64,134,86,99,199,229,31,165,186,195,124,191,15,214,79,122,249,120,214,170,158,88,255,95,145,93,199,75,178,131,179,4,107,120,124,24,196,238,82,235,216,208,155,72,80,231,40,233,191,53,44,239,157,35,249,196,197,189,24,61,55,145,18,171,145,116,155,10,32,219,76,29,12,242,246,11,110,193,244,64,88,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f88a83ea-c4fe-4ac2-870c-f6abbd2f69d5"));
		}

		#endregion

	}

	#endregion

}

