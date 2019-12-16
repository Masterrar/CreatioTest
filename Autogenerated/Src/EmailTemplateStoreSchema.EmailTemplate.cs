﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: EmailTemplateStoreSchema

	/// <exclude/>
	public class EmailTemplateStoreSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public EmailTemplateStoreSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public EmailTemplateStoreSchema(EmailTemplateStoreSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("08cae1a8-88d0-4f9d-a3db-aee1edf6b0f2");
			Name = "EmailTemplateStore";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("9fb8de7b-ba51-4bde-a802-902958879110");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,213,87,219,142,219,54,16,125,118,128,252,195,192,121,168,13,24,242,251,238,218,139,198,235,13,12,236,166,69,118,219,62,211,18,101,179,149,40,151,164,118,235,6,254,247,14,111,186,208,242,45,104,147,244,197,176,196,225,112,230,204,225,153,17,39,57,149,27,18,83,120,166,66,16,89,164,42,154,21,60,101,171,82,16,197,10,254,246,205,231,183,111,122,165,100,124,5,79,91,169,104,126,29,60,163,125,150,209,88,27,203,232,3,229,84,176,184,182,153,21,130,182,159,162,57,87,76,49,42,235,215,205,179,243,188,224,225,17,79,84,41,124,146,48,177,30,90,17,70,104,227,13,112,35,110,125,39,232,10,23,96,150,17,41,175,96,158,19,150,61,211,124,147,17,69,159,20,58,48,86,227,241,24,110,100,153,231,68,108,167,238,249,103,81,188,176,132,74,32,75,150,49,181,5,85,192,138,42,200,203,76,177,140,240,85,73,86,20,168,118,8,202,121,148,145,119,54,110,120,219,148,203,140,197,16,235,16,58,34,128,43,88,248,23,15,5,73,168,192,61,26,233,58,120,132,83,17,174,48,1,140,74,33,192,52,49,113,239,5,110,94,252,86,136,63,52,96,50,94,99,120,192,177,174,81,101,220,12,172,183,241,222,32,214,71,128,84,194,32,109,54,126,196,125,136,114,191,21,241,3,38,222,191,62,114,248,29,77,9,34,228,128,65,70,73,13,83,133,151,52,69,4,105,139,132,199,38,23,198,230,252,63,90,199,15,206,239,12,253,232,88,187,87,125,192,239,40,79,44,164,238,217,225,139,160,110,168,208,60,60,15,96,159,99,149,21,242,4,137,156,50,42,170,100,158,215,76,194,11,201,74,92,149,176,177,100,74,96,185,13,33,120,101,106,109,112,128,132,166,140,163,13,145,120,36,165,16,11,154,78,14,164,164,19,238,143,167,39,177,251,80,178,196,199,235,247,46,18,48,244,234,105,58,219,127,61,65,85,41,120,112,199,240,10,171,95,117,10,131,95,36,21,200,66,110,239,246,232,72,21,70,58,13,189,54,208,71,15,135,215,198,255,78,255,238,44,164,7,97,157,17,228,93,18,92,41,208,200,170,237,201,68,141,146,108,193,243,180,206,208,6,32,221,159,221,5,76,48,215,246,8,13,52,40,154,156,14,149,67,33,218,219,223,70,48,124,12,162,221,8,246,162,147,56,51,106,163,15,162,140,81,77,206,137,123,193,81,115,73,198,254,166,192,233,43,48,35,46,40,251,69,218,228,221,190,80,245,225,32,225,204,155,13,17,36,55,114,51,233,151,173,252,250,211,16,171,155,177,177,110,34,180,127,96,64,59,104,59,29,58,212,2,163,73,96,118,14,128,143,84,173,139,196,220,126,3,252,17,240,240,74,212,220,76,69,145,67,178,60,23,20,204,63,97,166,57,246,167,179,234,127,11,11,179,199,94,70,57,125,14,238,192,205,216,175,88,238,91,146,56,230,99,96,222,254,30,195,186,91,14,238,152,1,0,195,185,177,226,57,130,98,249,59,162,50,133,58,18,143,162,245,98,149,223,119,142,73,64,211,168,105,244,72,56,94,121,17,221,51,158,44,28,133,222,111,117,211,24,212,253,195,93,127,23,98,133,219,196,157,16,205,4,197,103,187,28,84,219,109,117,194,228,183,70,247,84,197,107,147,224,251,65,51,139,219,218,251,21,240,50,203,154,117,239,172,228,79,75,69,88,237,217,10,177,220,208,24,239,70,13,208,185,181,165,77,246,46,146,254,116,222,150,49,150,236,215,185,185,63,171,196,185,63,125,168,251,202,97,114,204,59,101,242,18,138,24,189,53,50,13,65,244,35,219,55,234,152,60,75,206,162,20,150,23,79,170,9,62,216,243,222,112,108,171,204,82,24,84,108,159,76,76,1,253,153,189,122,161,131,228,13,14,52,90,141,167,141,55,190,80,4,78,143,0,24,136,132,63,75,42,182,144,178,76,89,113,243,23,250,95,163,76,53,85,124,9,117,14,111,246,20,105,105,80,155,55,190,173,190,48,161,74,188,15,71,10,223,174,245,69,116,114,85,210,93,232,200,1,142,6,159,131,81,180,63,10,207,129,221,168,50,173,102,191,38,219,192,146,99,231,233,112,100,24,49,5,38,60,156,70,148,32,92,102,230,99,67,207,114,12,141,106,164,97,96,235,130,253,243,64,137,199,211,161,63,128,240,164,107,128,220,247,209,40,47,110,255,223,144,107,126,24,184,3,90,21,114,174,86,173,203,88,165,197,36,100,6,106,74,123,46,245,172,122,33,2,240,147,179,16,110,150,69,145,209,116,124,40,98,61,33,145,101,134,163,136,166,99,208,157,34,253,145,101,190,150,163,79,84,22,165,136,205,200,130,14,28,5,123,93,3,212,8,121,25,58,150,81,203,240,99,161,238,139,146,39,115,29,83,100,166,239,190,83,182,158,90,139,226,213,132,247,163,88,149,57,194,56,255,43,166,27,29,207,192,94,154,232,190,16,57,81,131,102,70,45,185,109,137,164,6,170,113,57,190,103,140,60,245,254,11,120,2,174,12,187,26,73,103,235,60,217,215,206,238,56,167,70,246,175,162,70,73,240,89,251,53,164,230,139,213,194,125,51,236,13,54,157,82,17,244,27,173,40,123,181,219,251,72,30,158,156,32,191,251,30,177,72,65,173,169,160,63,72,224,69,163,32,28,54,184,23,23,146,86,176,14,224,150,225,183,32,197,183,233,63,23,49,234,212,72,211,73,177,166,245,237,109,235,140,144,176,71,228,195,190,109,191,220,253,3,194,252,174,42,189,21,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateEmailTemplateNotFoundErrorLocalizableString());
			LocalizableStrings.Add(CreateLanguageNotFoundErrorLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateEmailTemplateNotFoundErrorLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("84220e7f-b369-4535-a1d0-5cf04a3b0f1c"),
				Name = "EmailTemplateNotFoundError",
				CreatedInPackageId = new Guid("9fb8de7b-ba51-4bde-a802-902958879110"),
				CreatedInSchemaUId = new Guid("08cae1a8-88d0-4f9d-a3db-aee1edf6b0f2"),
				ModifiedInSchemaUId = new Guid("08cae1a8-88d0-4f9d-a3db-aee1edf6b0f2")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateLanguageNotFoundErrorLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("22b90fbe-58a9-4b43-9e5b-103f479e92d7"),
				Name = "LanguageNotFoundError",
				CreatedInPackageId = new Guid("9fb8de7b-ba51-4bde-a802-902958879110"),
				CreatedInSchemaUId = new Guid("08cae1a8-88d0-4f9d-a3db-aee1edf6b0f2"),
				ModifiedInSchemaUId = new Guid("08cae1a8-88d0-4f9d-a3db-aee1edf6b0f2")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("08cae1a8-88d0-4f9d-a3db-aee1edf6b0f2"));
		}

		#endregion

	}

	#endregion

}

