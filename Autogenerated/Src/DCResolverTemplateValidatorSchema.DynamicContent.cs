namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: DCResolverTemplateValidatorSchema

	/// <exclude/>
	public class DCResolverTemplateValidatorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public DCResolverTemplateValidatorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public DCResolverTemplateValidatorSchema(DCResolverTemplateValidatorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("787acbf1-2f3a-46bd-87e9-f398e666cb27");
			Name = "DCResolverTemplateValidator";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("4f82e5e2-fdef-4aa4-baf8-be69c75a6ead");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,165,85,77,111,219,48,12,61,187,64,255,3,231,93,98,160,80,176,235,218,164,200,146,174,43,208,2,235,146,173,103,213,161,19,97,182,228,74,114,62,86,244,191,143,146,108,55,113,211,92,122,50,36,82,143,143,31,143,150,188,64,83,242,20,97,134,90,115,163,50,203,198,74,102,98,81,105,110,133,146,108,178,149,188,16,41,93,90,148,246,244,228,249,244,36,170,140,144,11,152,110,141,197,130,220,243,28,83,231,107,216,53,74,212,34,61,239,250,220,10,249,244,122,185,27,170,40,148,60,108,121,159,4,187,83,115,204,205,225,103,26,223,187,103,147,111,100,34,227,103,141,11,66,133,113,206,141,249,10,147,241,47,52,42,95,161,158,97,81,230,220,226,31,158,139,57,183,74,123,247,126,191,15,23,166,42,10,174,183,195,250,92,123,160,33,11,34,164,26,179,65,60,25,55,0,158,96,220,31,66,166,52,24,92,20,196,218,103,2,165,86,41,26,195,26,220,254,14,112,89,61,230,34,133,212,209,58,206,42,122,246,204,218,76,238,208,46,213,156,114,249,169,197,138,92,131,181,12,7,184,21,198,94,76,209,117,105,8,215,104,191,139,220,162,54,189,14,95,176,245,233,12,126,27,212,84,108,25,250,10,213,222,49,129,129,99,27,69,141,255,37,27,89,171,197,99,69,245,184,100,15,75,212,216,219,144,19,108,216,141,9,193,122,73,226,159,68,44,240,104,236,51,85,219,59,33,18,178,56,218,189,228,124,63,151,149,18,243,182,250,211,167,252,195,185,60,123,94,43,238,250,228,152,25,24,236,214,232,21,167,243,240,220,191,19,25,244,62,213,15,217,72,110,41,207,26,49,210,104,43,45,131,219,75,235,220,248,238,151,97,170,42,157,226,213,166,212,52,27,110,224,71,185,224,38,97,19,42,129,144,228,151,208,4,87,146,190,48,132,47,109,8,199,154,244,107,248,2,137,181,196,53,220,170,148,106,243,143,63,230,56,165,150,200,69,167,176,236,65,233,191,94,240,204,141,151,139,58,165,137,34,128,179,0,25,197,71,6,47,62,131,248,77,4,195,126,112,51,17,89,70,109,151,214,19,71,115,181,73,177,116,1,103,184,177,140,0,42,140,147,240,13,21,137,236,82,171,181,231,124,35,87,46,192,125,133,122,75,144,85,74,117,195,22,160,87,39,152,236,84,242,165,158,126,148,243,32,128,247,212,224,5,21,140,93,21,119,101,92,114,205,11,146,49,208,166,193,65,220,244,189,17,241,60,108,32,72,195,10,106,116,76,249,179,22,189,223,133,15,160,93,196,97,83,87,15,188,170,41,176,139,190,247,62,252,120,191,139,241,112,36,65,72,99,185,164,205,173,50,176,75,220,93,68,126,219,237,207,61,229,241,54,2,54,69,174,223,29,239,4,17,119,61,51,176,94,162,4,110,33,71,110,44,216,181,106,165,211,32,47,249,10,97,222,204,4,132,65,3,238,102,131,88,180,97,61,147,122,235,237,9,251,163,114,62,176,32,142,11,249,240,68,249,91,247,195,216,187,126,249,15,40,44,154,93,53,7,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateHasDifferentAliasesExceptionTextLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateHasDifferentAliasesExceptionTextLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("0516f4b9-03c3-4a08-80ae-8affa9b34e2b"),
				Name = "HasDifferentAliasesExceptionText",
				CreatedInPackageId = new Guid("4f82e5e2-fdef-4aa4-baf8-be69c75a6ead"),
				CreatedInSchemaUId = new Guid("787acbf1-2f3a-46bd-87e9-f398e666cb27"),
				ModifiedInSchemaUId = new Guid("787acbf1-2f3a-46bd-87e9-f398e666cb27")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("787acbf1-2f3a-46bd-87e9-f398e666cb27"));
		}

		#endregion

	}

	#endregion

}

