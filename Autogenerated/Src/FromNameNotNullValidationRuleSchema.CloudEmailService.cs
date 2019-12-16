namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: FromNameNotNullValidationRuleSchema

	/// <exclude/>
	public class FromNameNotNullValidationRuleSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public FromNameNotNullValidationRuleSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public FromNameNotNullValidationRuleSchema(FromNameNotNullValidationRuleSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("6d5308f5-73b6-4136-a80d-c0e6af1a6d50");
			Name = "FromNameNotNullValidationRule";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("bbfdb6d8-67aa-4e5b-af46-39321e13789f");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,83,75,111,219,48,12,62,167,64,255,3,215,1,69,10,12,242,189,141,123,88,176,21,193,150,96,72,135,222,25,155,78,132,201,146,39,202,25,140,34,255,125,148,252,88,146,195,46,134,244,73,252,30,20,109,177,38,110,176,32,248,73,222,35,187,42,168,165,179,149,222,183,30,131,118,22,110,111,222,111,111,102,45,107,187,135,215,142,3,213,114,193,24,42,226,41,171,23,178,228,117,241,116,125,231,187,182,191,5,20,248,163,167,125,36,90,26,100,126,4,248,234,93,189,17,217,141,11,155,214,152,55,52,186,76,82,219,214,80,170,200,178,12,22,220,214,53,250,238,121,216,111,169,241,196,100,3,67,56,16,20,145,12,254,232,112,0,47,101,12,174,130,227,196,4,149,243,96,69,3,42,17,131,26,11,239,24,118,29,80,221,132,78,141,18,217,153,70,211,238,140,46,6,222,255,90,132,71,248,140,76,87,160,80,188,39,243,83,222,53,133,131,43,37,241,15,239,130,180,139,202,254,252,58,93,2,6,54,234,211,73,206,146,206,19,68,112,52,181,142,105,212,196,148,93,83,45,26,244,88,167,226,252,206,83,161,27,45,109,187,123,222,142,203,216,171,93,107,126,73,55,80,27,181,200,82,65,170,111,70,171,224,142,50,15,186,36,56,58,93,194,202,6,242,22,199,78,208,124,181,38,102,220,211,68,186,178,149,131,73,237,1,226,208,204,102,71,244,241,89,90,26,205,67,14,47,20,82,132,183,17,159,56,230,83,253,39,88,139,53,25,39,153,69,14,172,46,178,127,163,238,225,41,209,235,10,230,151,244,31,114,176,242,98,112,127,127,169,171,146,154,250,39,12,121,14,28,188,72,168,47,113,40,70,199,179,201,131,90,89,29,52,154,173,252,32,226,130,150,174,140,246,231,90,226,13,238,206,143,212,18,109,65,134,202,215,244,120,60,204,79,234,88,239,246,20,191,167,97,72,228,82,63,39,105,223,163,151,224,233,47,43,177,177,1,156,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("6d5308f5-73b6-4136-a80d-c0e6af1a6d50"));
		}

		#endregion

	}

	#endregion

}

