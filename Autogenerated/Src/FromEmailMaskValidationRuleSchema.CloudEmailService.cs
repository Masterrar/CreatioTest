namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: FromEmailMaskValidationRuleSchema

	/// <exclude/>
	public class FromEmailMaskValidationRuleSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public FromEmailMaskValidationRuleSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public FromEmailMaskValidationRuleSchema(FromEmailMaskValidationRuleSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("c4a873c4-bfd7-48e3-ac0b-3c4de968c246");
			Name = "FromEmailMaskValidationRule";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("bbfdb6d8-67aa-4e5b-af46-39321e13789f");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,83,75,111,219,48,12,62,167,64,255,3,219,1,69,2,12,242,189,77,122,88,182,21,193,150,97,72,183,220,25,155,78,132,200,146,39,202,25,130,34,255,125,180,108,107,153,15,187,200,22,31,223,67,162,44,86,196,53,230,4,63,200,123,100,87,6,181,116,182,212,251,198,99,208,206,194,237,205,219,237,205,164,97,109,247,240,122,230,64,149,20,24,67,121,155,101,245,66,150,188,206,159,198,53,95,181,253,37,65,9,191,243,180,111,129,150,6,153,31,1,62,123,87,125,170,80,155,53,242,113,139,70,23,145,104,211,24,138,245,89,150,193,156,155,170,66,127,126,238,247,27,170,61,49,217,192,16,14,4,121,11,5,191,117,56,116,139,151,94,6,87,194,41,193,65,233,60,80,75,195,80,10,35,84,152,123,199,176,59,203,31,31,213,64,148,93,49,213,205,206,232,188,71,255,143,76,120,132,15,200,52,10,10,192,91,52,144,28,175,41,28,92,33,158,191,123,23,228,192,168,232,242,99,135,49,208,163,81,231,80,188,22,212,27,232,244,183,209,43,77,98,70,37,172,108,12,54,175,209,99,5,86,110,119,113,239,41,215,181,150,195,187,127,222,12,191,237,97,237,26,115,236,24,212,60,139,13,177,191,30,196,130,59,201,76,232,130,224,228,116,1,43,27,200,91,52,131,208,233,106,77,204,184,167,4,186,178,165,131,196,54,131,118,112,38,147,19,250,246,94,26,74,234,97,1,47,20,162,135,237,144,72,32,211,4,240,30,214,82,44,51,37,3,201,129,213,191,238,191,208,121,246,20,9,116,9,211,17,193,221,2,108,99,12,60,60,192,93,15,242,51,200,39,104,98,53,24,136,165,163,78,21,5,169,191,218,102,131,141,73,210,165,86,86,128,208,108,228,229,136,50,90,58,57,162,5,76,181,120,238,201,174,83,106,137,54,39,67,197,107,188,83,254,232,132,200,126,115,97,43,15,167,212,84,116,46,46,237,122,233,7,72,42,187,25,138,251,46,122,29,188,252,1,198,89,71,146,184,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c4a873c4-bfd7-48e3-ac0b-3c4de968c246"));
		}

		#endregion

	}

	#endregion

}

