﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ForecastNotificationProviderSchema

	/// <exclude/>
	public class ForecastNotificationProviderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ForecastNotificationProviderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ForecastNotificationProviderSchema(ForecastNotificationProviderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("3dcbc99d-70ca-41f0-b08a-1d7398a45a96");
			Name = "ForecastNotificationProvider";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("0db428d0-fc38-40d1-af3f-5cbb75ee95a9");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,237,88,73,111,227,54,20,62,123,128,249,15,132,123,177,1,67,185,199,153,0,182,179,192,69,22,195,75,123,24,4,5,35,61,39,44,180,13,73,165,112,7,243,223,135,171,68,106,139,147,153,22,40,208,147,173,199,183,124,111,229,147,82,156,0,203,113,8,104,11,148,98,150,237,121,176,200,210,61,121,42,40,230,36,75,63,126,248,250,241,195,160,96,36,125,242,88,40,4,23,243,105,121,180,57,48,14,137,160,199,49,132,82,142,5,215,144,2,37,225,180,67,188,157,158,36,89,90,215,218,176,114,129,57,110,16,111,72,250,165,15,143,56,19,167,191,80,120,18,79,104,17,99,198,78,209,149,0,18,98,198,239,50,78,246,36,84,30,175,104,246,66,34,160,138,63,47,30,99,18,162,80,178,247,114,163,83,52,199,12,218,142,38,104,233,146,133,214,175,74,119,9,230,138,64,28,9,52,43,74,94,48,7,125,152,235,7,20,10,236,28,49,78,165,91,215,235,251,221,234,143,187,217,237,37,250,132,134,174,214,225,180,83,200,178,91,248,195,169,49,15,105,164,17,248,112,22,82,152,22,33,207,168,4,165,34,96,48,233,104,244,197,97,116,65,84,188,49,61,156,105,251,19,148,61,254,41,146,112,142,114,76,69,185,113,160,108,44,181,13,78,209,163,8,217,200,33,35,89,108,131,111,199,91,219,49,160,2,111,170,147,140,10,239,209,179,82,59,242,44,117,69,66,152,201,129,114,2,181,56,156,156,156,160,51,86,36,137,240,242,220,18,174,105,86,228,40,21,174,4,37,207,137,203,100,252,177,169,84,236,10,197,224,9,184,249,55,160,192,11,154,58,137,86,121,149,64,75,180,173,214,203,58,60,26,192,157,96,236,180,223,110,185,43,78,183,192,159,179,206,10,182,14,3,159,103,209,161,173,64,244,239,57,138,202,35,209,184,69,146,254,134,227,2,108,85,12,94,48,69,143,66,195,22,146,60,150,138,63,33,63,253,98,228,240,155,44,196,49,249,27,63,198,176,81,90,71,195,190,2,26,78,208,112,238,232,28,142,167,158,45,97,163,29,212,231,225,5,176,144,146,92,53,223,131,150,50,18,218,157,64,216,77,48,31,185,144,39,74,169,177,97,66,45,41,83,183,236,27,97,219,18,30,195,143,197,141,75,21,63,59,112,91,87,169,27,57,101,173,39,116,155,66,77,132,5,246,162,103,165,252,240,121,200,39,90,181,31,64,69,154,190,173,76,51,46,236,67,100,35,110,30,81,246,34,238,34,225,30,122,201,72,132,102,81,164,113,179,209,6,228,61,130,152,250,177,129,213,79,186,111,2,205,57,26,174,33,33,105,36,28,144,17,90,70,195,113,48,99,35,245,167,143,113,65,65,184,23,205,15,165,132,71,233,19,117,235,80,139,122,148,62,209,90,30,180,116,157,120,132,130,18,244,101,42,146,161,16,251,21,221,30,223,95,51,146,110,101,193,29,19,223,165,40,86,42,37,170,186,20,70,239,251,16,45,217,229,151,2,199,142,128,73,73,83,165,216,23,102,145,80,179,75,73,171,90,209,43,28,215,213,122,66,62,211,43,238,123,11,193,50,221,103,178,205,215,16,102,52,170,159,188,191,239,205,0,49,67,201,142,223,14,153,169,43,98,59,177,156,61,189,66,215,133,200,37,73,240,19,44,35,33,228,58,176,227,36,38,242,254,148,19,70,132,107,41,185,230,135,77,248,12,9,150,23,80,237,2,159,56,91,138,223,228,41,252,133,26,161,177,158,14,182,6,176,2,62,209,180,185,246,91,186,111,40,203,18,163,65,107,232,182,106,197,129,52,35,253,233,240,248,115,85,225,15,99,79,186,114,201,91,181,12,207,45,48,102,109,191,106,194,85,238,150,216,49,178,46,191,171,71,109,27,6,157,250,175,239,246,183,77,205,230,38,232,247,243,6,184,157,151,55,132,241,51,91,166,161,38,218,108,153,199,64,140,87,61,24,167,77,178,55,253,90,206,189,17,215,114,94,31,98,45,44,181,89,85,147,47,211,217,122,108,42,169,214,231,181,152,84,23,184,238,236,53,176,34,230,255,165,123,252,223,220,182,82,183,185,163,158,229,65,150,117,37,22,86,133,210,35,227,150,211,195,143,108,120,239,223,110,164,36,84,131,230,245,249,82,137,49,119,182,116,90,173,42,214,17,173,198,114,103,56,77,41,191,107,133,125,243,202,38,49,229,89,46,222,124,244,48,91,201,255,242,125,254,31,152,229,54,218,221,115,186,10,172,51,14,117,200,129,18,89,217,176,50,96,21,232,96,99,201,35,255,118,170,249,95,186,238,23,245,164,166,182,119,122,152,141,72,52,153,2,46,238,80,77,41,3,165,174,221,176,160,84,248,89,110,30,205,46,93,104,14,73,13,74,54,215,81,101,70,103,195,88,216,181,188,69,255,191,224,214,22,220,154,148,184,120,117,105,73,41,125,111,104,99,206,69,82,19,113,39,164,72,46,231,194,38,83,70,205,162,84,5,215,62,105,13,131,224,66,92,175,36,149,197,96,116,94,209,44,113,161,183,172,184,63,107,107,86,218,212,234,126,200,33,184,129,61,191,47,184,252,202,229,196,160,4,218,180,116,96,110,35,54,22,234,42,136,187,163,108,182,7,241,157,246,251,50,226,74,185,208,126,127,6,10,245,174,96,107,192,174,102,157,242,96,101,191,116,141,246,56,102,48,182,58,102,105,84,211,48,43,196,210,69,151,189,58,234,189,223,163,206,239,190,55,107,196,204,140,6,127,232,85,164,190,47,83,107,197,205,188,89,216,241,129,74,81,180,118,118,238,38,35,56,59,177,100,103,86,46,47,211,34,1,42,183,143,179,198,27,213,185,28,157,94,66,203,201,105,191,177,213,206,165,20,27,141,187,118,98,67,115,73,223,190,3,119,187,25,155,63,23,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateBodyTemplateLocalizableString());
			LocalizableStrings.Add(CreateTitleTemplateLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateBodyTemplateLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("49329916-54bf-497e-8dbc-278d7d292151"),
				Name = "BodyTemplate",
				CreatedInPackageId = new Guid("74635cde-1ca7-4f8a-932a-278c27cd4512"),
				CreatedInSchemaUId = new Guid("3dcbc99d-70ca-41f0-b08a-1d7398a45a96"),
				ModifiedInSchemaUId = new Guid("3dcbc99d-70ca-41f0-b08a-1d7398a45a96")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateTitleTemplateLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("d2787d49-bc16-4e5e-ad98-f14f1729ee81"),
				Name = "TitleTemplate",
				CreatedInPackageId = new Guid("74635cde-1ca7-4f8a-932a-278c27cd4512"),
				CreatedInSchemaUId = new Guid("3dcbc99d-70ca-41f0-b08a-1d7398a45a96"),
				ModifiedInSchemaUId = new Guid("3dcbc99d-70ca-41f0-b08a-1d7398a45a96")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("3dcbc99d-70ca-41f0-b08a-1d7398a45a96"));
		}

		#endregion

	}

	#endregion

}
