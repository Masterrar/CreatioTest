namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ProjectUtilitiesServiceSchema

	/// <exclude/>
	public class ProjectUtilitiesServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ProjectUtilitiesServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ProjectUtilitiesServiceSchema(ProjectUtilitiesServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("9b47c1bf-4868-454f-a509-c1a14ee81229");
			Name = "ProjectUtilitiesService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("c746724b-ad7f-4327-918b-435a466c9305");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,85,81,79,219,48,16,126,14,18,255,225,212,189,164,18,74,223,7,173,4,104,32,166,117,67,148,142,7,132,38,55,185,182,30,137,157,217,14,44,67,253,239,59,219,73,19,218,164,219,75,36,219,223,221,125,254,252,221,69,176,12,117,206,98,132,123,84,138,105,185,52,209,165,20,75,190,42,20,51,92,138,227,163,183,227,163,160,208,92,172,96,86,106,131,217,233,206,58,154,161,122,225,49,78,101,130,233,193,195,232,60,54,252,197,165,61,140,123,192,69,3,104,19,83,24,93,177,216,72,197,81,119,33,40,144,80,89,230,10,208,249,7,133,43,170,6,151,41,211,250,35,92,202,188,188,85,242,39,198,230,142,174,45,133,70,7,27,141,70,112,166,139,44,99,170,156,84,107,139,5,153,163,151,1,84,133,135,216,166,138,234,160,81,43,42,47,22,41,143,61,160,171,20,88,2,45,105,171,43,55,76,2,43,245,30,25,207,70,33,51,152,64,238,83,2,79,80,24,190,228,168,182,33,109,42,53,151,235,130,39,117,108,197,230,38,129,55,88,161,57,5,109,63,27,66,111,188,86,40,18,47,87,151,116,85,244,220,240,148,27,82,191,34,223,200,199,197,26,21,55,137,140,97,52,233,209,180,10,130,87,110,214,80,212,169,32,67,179,150,137,134,165,84,117,29,176,215,51,101,167,206,143,85,26,18,211,40,114,195,147,221,59,215,249,87,52,244,246,57,105,187,176,153,203,59,252,85,112,133,25,165,210,97,123,97,77,6,99,248,71,136,69,69,213,70,50,124,218,125,224,30,65,232,145,47,152,198,173,60,254,77,107,49,175,56,166,137,83,211,246,129,87,47,200,253,130,44,198,18,41,210,18,190,176,63,229,89,149,223,250,104,202,4,91,161,154,192,143,184,89,121,131,239,190,90,243,108,100,41,163,10,219,43,182,158,99,238,17,221,254,106,224,209,65,71,245,92,59,28,130,187,104,208,166,72,26,11,124,237,189,78,232,2,2,10,29,79,188,205,124,111,151,209,53,154,3,1,129,77,218,34,124,174,86,133,125,177,112,80,104,84,116,32,40,142,52,24,156,192,252,221,198,112,56,180,67,163,242,123,175,116,83,111,199,255,82,141,102,68,221,146,206,212,44,77,65,23,11,169,18,46,236,155,190,74,245,172,123,20,117,59,57,83,44,3,65,99,120,60,200,235,14,29,76,110,247,250,252,108,228,160,46,242,241,91,61,151,218,61,16,60,210,248,187,17,47,242,25,195,185,226,247,152,229,169,229,48,134,65,107,26,61,16,205,153,83,174,80,72,18,213,227,231,74,170,140,25,2,83,146,41,106,77,138,251,173,232,179,150,226,196,73,127,33,147,114,102,202,20,223,193,182,187,209,131,98,121,142,137,109,26,212,198,245,76,237,155,174,121,216,199,42,116,99,107,171,70,109,173,174,20,219,177,236,173,214,5,241,193,193,172,136,99,226,75,64,42,131,110,111,227,220,16,24,85,214,160,58,93,180,55,51,199,239,154,47,250,206,210,130,80,125,23,104,184,251,18,27,136,153,137,215,16,126,250,29,99,238,126,40,56,220,43,218,80,92,178,84,227,233,206,113,19,59,134,234,112,227,190,10,169,104,243,139,234,243,120,199,156,223,192,95,210,199,3,0,1,8,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateNoRightsToCopyProjectLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateNoRightsToCopyProjectLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("df1db353-f52f-401e-a2a5-76847c4bb6fe"),
				Name = "NoRightsToCopyProject",
				CreatedInPackageId = new Guid("c746724b-ad7f-4327-918b-435a466c9305"),
				CreatedInSchemaUId = new Guid("9b47c1bf-4868-454f-a509-c1a14ee81229"),
				ModifiedInSchemaUId = new Guid("9b47c1bf-4868-454f-a509-c1a14ee81229")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("9b47c1bf-4868-454f-a509-c1a14ee81229"));
		}

		#endregion

	}

	#endregion

}

