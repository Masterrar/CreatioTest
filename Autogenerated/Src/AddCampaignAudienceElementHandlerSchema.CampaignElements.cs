namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: AddCampaignAudienceElementHandlerSchema

	/// <exclude/>
	public class AddCampaignAudienceElementHandlerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public AddCampaignAudienceElementHandlerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public AddCampaignAudienceElementHandlerSchema(AddCampaignAudienceElementHandlerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("b67a7d9d-3115-49bd-b36e-75efab9107b4");
			Name = "AddCampaignAudienceElementHandler";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d0bba11f-3986-4819-81ab-1d3ddbfc1f48");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,85,81,111,218,48,16,126,166,82,255,195,141,189,4,9,37,218,107,7,72,12,65,87,137,149,106,84,237,195,180,7,55,185,128,181,196,102,182,67,199,170,254,247,157,177,29,18,68,169,38,241,146,243,221,119,223,221,119,119,8,86,162,222,176,20,225,30,149,98,90,230,38,158,72,145,243,85,165,152,225,82,92,94,188,92,94,116,42,205,197,10,150,59,109,176,164,247,162,192,212,62,234,248,26,5,42,158,126,62,246,153,115,241,251,96,108,98,43,140,199,198,40,254,84,25,212,111,186,76,88,185,97,124,37,222,117,136,167,91,20,230,43,19,89,129,234,224,109,125,130,203,50,93,99,201,96,8,237,192,246,51,133,82,112,146,36,48,208,85,89,50,181,27,249,111,106,135,97,92,104,40,209,172,101,166,33,151,10,74,178,88,171,205,53,206,50,24,87,25,71,65,109,196,2,75,34,164,129,11,72,67,170,128,156,52,160,55,213,83,193,83,208,200,10,204,32,45,152,214,22,41,176,10,128,83,135,231,11,132,43,248,194,52,158,119,234,195,205,66,4,151,7,86,240,140,25,164,140,47,251,18,59,31,21,174,72,59,91,151,54,170,74,141,84,250,10,238,246,116,156,135,167,246,46,155,168,7,118,56,58,29,108,153,111,105,166,168,219,215,104,238,119,27,140,122,177,53,88,105,58,175,158,1,138,204,145,104,51,250,230,26,76,100,148,52,52,97,152,185,247,99,85,246,134,239,104,42,69,170,152,53,66,193,181,1,153,147,19,34,164,10,243,97,183,65,254,142,41,195,83,190,97,194,120,254,221,100,84,139,3,236,88,186,184,206,153,28,39,29,108,152,98,37,8,42,104,216,213,251,193,233,142,66,30,112,6,82,94,27,70,128,241,32,217,187,31,162,149,227,60,154,123,190,169,20,196,214,224,57,50,131,36,68,237,165,9,157,1,185,165,133,224,25,194,205,84,84,37,42,246,84,224,224,204,112,140,172,32,71,54,29,157,216,19,87,69,144,214,37,247,198,120,86,200,231,16,27,47,114,171,239,224,108,167,71,81,239,255,148,111,140,225,73,217,195,60,235,55,214,78,30,214,14,182,206,151,18,196,176,68,166,168,6,187,189,69,134,74,195,51,55,107,16,210,106,144,113,119,204,78,235,254,99,161,40,32,250,212,251,217,216,141,173,228,25,44,234,237,170,55,97,203,212,129,203,240,116,203,91,237,118,237,233,240,28,162,15,181,230,99,177,139,122,1,210,75,224,252,94,235,44,161,142,33,204,37,203,102,238,235,70,228,50,10,48,30,122,178,198,244,151,127,159,254,161,201,67,161,177,118,234,7,32,239,221,128,126,164,14,221,202,25,47,12,29,158,33,204,184,8,105,154,47,81,59,158,78,138,189,137,244,175,162,217,202,159,129,121,250,119,185,55,83,187,170,58,117,227,90,244,161,235,144,29,240,36,72,242,200,148,189,176,93,143,253,168,184,193,135,90,212,86,177,253,83,172,251,129,71,31,142,238,161,15,159,227,22,139,216,167,57,55,169,100,165,223,63,237,112,108,177,46,7,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateFolderWithNoConditionWarningLocalizableString());
			LocalizableStrings.Add(CreateFolderNotFoundErrorLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateFolderWithNoConditionWarningLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("7244310a-84bf-404b-baa6-2bae953fbbc1"),
				Name = "FolderWithNoConditionWarning",
				CreatedInPackageId = new Guid("d0bba11f-3986-4819-81ab-1d3ddbfc1f48"),
				CreatedInSchemaUId = new Guid("b67a7d9d-3115-49bd-b36e-75efab9107b4"),
				ModifiedInSchemaUId = new Guid("b67a7d9d-3115-49bd-b36e-75efab9107b4")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateFolderNotFoundErrorLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("f6c3f61f-5296-4d52-bc90-ce76168b921f"),
				Name = "FolderNotFoundError",
				CreatedInPackageId = new Guid("d0bba11f-3986-4819-81ab-1d3ddbfc1f48"),
				CreatedInSchemaUId = new Guid("b67a7d9d-3115-49bd-b36e-75efab9107b4"),
				ModifiedInSchemaUId = new Guid("b67a7d9d-3115-49bd-b36e-75efab9107b4")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b67a7d9d-3115-49bd-b36e-75efab9107b4"));
		}

		#endregion

	}

	#endregion

}

