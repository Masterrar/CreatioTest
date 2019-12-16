namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ForecastCalculatorExecutorSchema

	/// <exclude/>
	public class ForecastCalculatorExecutorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ForecastCalculatorExecutorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ForecastCalculatorExecutorSchema(ForecastCalculatorExecutorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("78b866b1-074a-46c1-ad48-6fd542b834df");
			Name = "ForecastCalculatorExecutor";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("e0b9d996-6f7e-4520-a678-da960c79be39");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,181,86,75,111,211,64,16,62,7,137,255,176,50,23,71,138,28,137,35,36,65,37,180,149,17,133,168,105,185,32,132,54,246,36,89,100,123,173,221,117,33,84,253,239,204,62,252,218,56,45,72,112,73,236,245,204,247,205,123,182,160,57,200,146,38,64,110,64,8,42,249,86,69,75,94,108,217,174,18,84,49,94,68,23,92,64,66,165,250,252,242,249,179,251,231,207,70,149,100,197,142,124,132,31,138,23,70,252,189,228,197,235,230,195,250,32,21,228,254,59,98,102,25,36,26,80,70,151,80,128,96,73,43,211,165,22,112,234,60,58,47,20,83,12,228,73,129,11,154,40,46,172,4,202,188,16,176,67,66,178,204,168,148,175,72,237,200,146,102,73,149,81,148,60,255,9,73,133,255,70,122,58,157,146,153,172,242,156,138,195,194,189,91,1,144,100,235,116,73,194,179,42,47,36,73,28,136,198,255,206,55,81,13,48,245,16,102,18,128,102,146,147,68,192,118,30,120,6,199,239,249,166,54,34,32,83,173,84,86,155,140,37,36,209,54,63,98,50,121,69,186,202,168,120,111,188,104,156,190,2,181,231,41,186,189,18,236,142,42,176,95,75,251,66,226,99,100,114,9,234,248,52,188,149,32,176,32,10,155,60,82,245,94,39,68,42,161,19,161,14,37,140,137,46,143,209,72,128,170,132,139,186,205,200,1,83,174,102,3,156,139,80,43,78,140,218,168,128,31,4,161,17,177,210,74,103,98,87,229,80,168,48,232,115,6,19,207,136,241,88,23,196,232,161,239,161,51,12,137,63,112,76,22,251,69,55,25,172,205,225,31,250,84,96,107,120,62,245,37,163,65,112,60,188,65,167,194,113,244,17,1,38,14,230,205,27,7,27,157,231,165,58,12,89,124,199,89,74,150,2,240,249,26,114,86,164,127,96,234,101,133,58,117,113,198,105,109,238,29,21,68,212,24,183,138,101,166,111,200,252,56,41,215,71,82,139,208,198,211,128,200,61,128,186,134,146,75,166,85,134,16,154,180,174,251,178,139,240,159,164,181,53,3,201,61,115,52,191,97,13,59,33,176,90,38,48,160,7,198,97,157,236,33,167,183,113,138,0,94,2,207,59,2,87,180,160,59,16,26,51,198,137,245,246,160,211,23,6,61,239,130,113,132,56,173,93,223,146,74,8,100,113,89,82,24,150,33,154,101,43,21,53,98,45,74,98,230,45,170,233,80,53,9,177,83,56,244,124,168,51,60,58,171,176,191,133,97,27,180,194,53,85,215,170,199,228,214,213,230,59,56,185,54,152,238,227,59,144,137,96,165,169,192,249,112,75,249,133,25,52,126,116,148,131,177,3,92,241,178,42,111,152,202,64,39,213,246,5,6,58,167,42,252,75,244,22,169,1,31,153,42,49,221,55,54,39,15,109,168,113,217,73,204,178,139,181,11,101,235,111,87,252,74,238,150,123,138,156,89,211,26,209,138,75,117,101,33,142,109,186,45,83,108,221,186,94,36,22,180,222,140,40,114,7,66,69,107,92,121,218,43,248,100,2,29,58,75,234,42,63,238,214,200,31,5,62,161,45,155,222,240,123,1,69,106,231,255,169,101,96,182,139,253,232,47,188,254,198,195,165,70,120,9,238,18,208,200,79,125,133,89,73,5,205,205,148,155,251,45,189,184,217,131,233,5,109,107,221,12,179,169,209,24,6,48,207,160,64,72,171,220,190,247,244,220,146,52,19,211,89,252,212,164,140,223,49,243,132,182,207,108,197,77,8,55,169,88,116,88,186,3,180,45,11,44,151,80,15,148,113,43,248,165,25,12,113,26,124,109,11,12,35,198,120,26,167,122,216,118,165,87,245,121,240,149,80,73,62,48,169,102,26,114,209,170,50,137,46,216,235,146,246,69,147,110,56,207,122,164,113,95,166,203,220,119,24,173,91,118,174,40,254,72,178,106,108,75,66,143,181,153,47,127,5,23,157,149,101,231,173,133,243,25,31,204,239,208,237,195,230,226,51,205,42,88,218,59,86,231,227,252,196,229,228,49,35,221,52,104,180,244,10,146,209,39,159,70,239,106,51,42,94,31,37,126,165,3,47,221,172,232,178,219,15,157,165,51,105,243,238,112,30,115,39,170,31,33,236,83,57,221,161,240,160,96,142,143,255,51,52,23,93,10,47,44,167,232,159,114,229,169,25,230,239,237,225,57,102,79,251,135,15,191,1,90,103,13,250,186,12,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateRemindingDescriptionLocalizableString());
			LocalizableStrings.Add(CreateRemindingPopupTitleLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateRemindingDescriptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("3dc542fe-c7a2-4fc5-8293-409463b43fb1"),
				Name = "RemindingDescription",
				CreatedInPackageId = new Guid("e0b9d996-6f7e-4520-a678-da960c79be39"),
				CreatedInSchemaUId = new Guid("78b866b1-074a-46c1-ad48-6fd542b834df"),
				ModifiedInSchemaUId = new Guid("78b866b1-074a-46c1-ad48-6fd542b834df")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateRemindingPopupTitleLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("b59a49a0-9b2d-4398-ae38-f62389e28068"),
				Name = "RemindingPopupTitle",
				CreatedInPackageId = new Guid("e0b9d996-6f7e-4520-a678-da960c79be39"),
				CreatedInSchemaUId = new Guid("78b866b1-074a-46c1-ad48-6fd542b834df"),
				ModifiedInSchemaUId = new Guid("78b866b1-074a-46c1-ad48-6fd542b834df")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("78b866b1-074a-46c1-ad48-6fd542b834df"));
		}

		#endregion

	}

	#endregion

}

