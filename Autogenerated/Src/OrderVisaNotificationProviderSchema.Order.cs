﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: OrderVisaNotificationProviderSchema

	/// <exclude/>
	public class OrderVisaNotificationProviderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public OrderVisaNotificationProviderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public OrderVisaNotificationProviderSchema(OrderVisaNotificationProviderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("d7ed1775-3874-4e65-8859-caee2336bd5e");
			Name = "OrderVisaNotificationProvider";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("2a4b8a43-1fe2-457d-94c6-a637032531ed");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,237,26,107,111,219,54,240,115,10,244,63,16,222,23,25,48,148,237,107,147,6,176,243,130,135,38,206,98,167,251,80,4,133,34,49,9,7,61,92,146,74,231,5,249,239,59,62,69,234,101,101,77,58,108,232,39,91,199,123,243,120,119,60,41,143,50,204,214,81,140,209,10,83,26,177,226,150,135,135,69,126,75,238,74,26,113,82,228,111,223,60,190,125,179,83,50,146,223,121,40,20,135,71,179,61,187,180,220,48,142,51,128,167,41,142,5,29,11,79,113,142,41,137,247,58,200,235,180,93,120,225,113,206,9,39,152,1,2,160,252,68,241,29,176,71,135,105,196,216,59,180,160,9,166,31,9,139,206,11,78,110,73,44,117,190,160,197,3,1,184,36,88,151,55,41,137,81,44,240,251,209,209,59,52,139,24,110,91,154,160,185,11,6,182,143,146,121,165,14,88,204,163,156,131,74,23,148,60,68,28,171,245,181,122,64,177,88,71,140,83,97,224,233,229,226,234,226,243,249,244,236,24,189,71,35,161,206,104,175,19,217,160,73,213,123,240,172,105,203,248,30,103,209,57,108,172,37,219,34,66,226,180,144,141,246,180,145,56,79,148,157,190,209,39,4,167,73,151,197,20,71,73,145,167,27,116,90,146,4,125,102,27,54,77,50,146,95,229,132,111,97,43,125,73,203,152,23,84,48,151,251,167,121,171,189,236,221,197,224,136,200,0,140,232,102,95,217,55,65,197,205,31,16,149,7,104,29,81,176,143,99,202,198,130,221,206,59,116,3,27,30,56,96,244,40,23,60,117,193,31,129,48,98,204,239,9,11,43,228,79,35,23,107,158,140,174,165,139,159,158,161,235,21,195,20,204,205,213,153,65,165,247,232,233,88,91,82,122,62,245,59,18,196,172,49,21,103,199,119,227,238,238,46,218,103,101,150,129,143,14,12,224,148,22,229,26,229,96,91,104,113,118,93,36,109,144,137,97,137,174,188,117,135,185,254,183,67,49,47,105,238,68,184,116,137,80,212,106,219,42,221,158,193,193,10,200,72,237,146,223,46,185,203,79,103,152,223,23,157,129,188,196,34,165,161,83,204,151,238,118,231,151,69,138,213,90,96,194,230,33,162,136,41,244,247,40,199,95,53,109,109,155,213,190,238,136,100,89,102,121,48,90,250,81,212,183,44,100,58,40,39,180,200,106,244,82,45,139,240,251,61,166,184,41,33,156,179,227,47,101,148,6,74,70,120,97,98,58,240,2,127,60,70,17,211,54,40,111,106,247,178,10,244,228,59,235,183,18,211,205,33,4,172,240,151,125,240,28,244,197,162,40,31,57,88,123,22,9,242,83,66,132,179,78,8,101,220,195,52,43,129,255,184,218,172,49,216,117,94,166,169,145,182,243,1,223,242,227,63,215,20,51,38,246,217,227,34,12,175,214,164,143,196,54,105,7,78,144,5,24,119,63,41,237,172,250,225,52,73,192,191,249,28,138,87,224,235,59,233,17,212,146,167,39,170,8,44,190,230,74,220,184,46,233,56,101,248,37,236,240,54,209,178,111,219,71,115,202,49,63,130,199,64,63,38,240,159,147,12,187,219,41,96,103,81,76,11,6,122,249,129,14,45,0,255,80,196,81,74,254,138,110,224,176,72,38,193,168,55,37,10,141,143,44,203,145,19,18,96,97,153,138,80,0,1,15,144,214,194,85,33,16,87,160,79,96,21,243,44,84,20,128,167,37,87,170,142,251,109,158,21,201,166,173,142,168,223,3,148,216,37,229,255,143,81,90,98,230,122,229,6,56,172,112,182,78,5,227,151,242,203,204,97,234,122,38,47,179,27,72,157,239,59,244,250,52,90,17,14,177,112,189,231,109,154,112,92,15,141,240,173,75,18,197,113,81,230,188,135,98,170,48,92,34,56,22,60,138,251,136,14,21,134,33,114,2,13,136,76,248,25,117,199,13,117,52,185,114,33,80,40,250,240,164,160,89,196,131,209,227,207,79,19,244,248,203,19,120,79,19,76,140,78,154,23,185,69,129,162,214,201,99,65,143,179,53,223,4,26,127,108,147,73,135,68,205,206,169,54,221,60,141,232,109,60,53,216,229,105,130,170,97,163,27,105,19,29,10,19,233,192,73,171,147,252,35,34,168,221,179,48,160,68,22,28,162,24,39,230,236,232,71,84,192,153,164,16,169,78,189,20,221,116,173,66,106,177,91,107,163,172,108,45,169,178,118,112,27,194,31,10,104,54,33,49,171,32,99,129,86,70,21,44,163,132,236,72,161,208,205,179,232,78,132,153,123,222,174,56,73,229,117,35,84,5,95,226,204,54,149,6,53,133,39,109,141,183,246,177,146,234,151,243,246,244,47,139,242,148,5,163,102,253,111,39,88,200,142,150,60,96,77,231,60,15,33,95,242,136,151,204,74,173,30,7,41,203,14,163,60,6,219,172,210,14,96,8,3,175,216,41,5,122,91,160,70,151,82,187,176,140,21,19,95,78,171,42,158,26,231,242,172,104,13,84,138,220,74,99,53,150,54,72,167,119,184,205,35,147,201,84,17,170,191,181,30,207,164,78,161,149,212,93,162,26,104,29,219,228,76,31,219,64,255,153,243,186,29,215,96,96,78,142,166,148,255,109,119,177,229,104,254,90,144,124,37,138,94,199,209,244,142,204,28,14,25,21,20,13,157,195,69,231,230,152,214,182,227,220,8,168,179,99,162,67,92,148,92,139,169,60,46,4,184,187,210,100,237,177,213,152,221,140,237,230,72,198,206,6,110,97,172,49,135,186,87,102,62,221,137,246,36,191,79,215,232,150,228,81,154,110,212,201,199,172,47,11,158,40,84,233,75,141,94,207,218,110,190,211,151,142,173,137,7,228,5,96,122,51,192,88,80,83,110,108,156,58,205,147,33,57,169,243,118,115,27,65,35,61,30,234,201,169,76,168,194,210,19,146,10,242,54,127,118,179,241,38,70,243,252,182,16,37,241,18,199,5,77,234,43,223,214,107,114,145,186,94,172,201,148,137,176,222,101,202,138,73,212,65,175,32,225,138,110,192,185,112,115,235,234,238,76,110,184,158,160,162,228,134,131,223,130,136,94,160,225,42,221,31,173,180,105,210,196,137,130,205,84,23,100,218,244,14,255,104,100,173,0,224,107,217,26,46,135,138,27,185,32,228,11,107,58,141,240,82,253,245,216,227,224,77,205,250,24,56,249,245,90,115,56,131,43,155,209,110,171,18,174,232,165,63,156,218,74,91,171,174,150,143,156,225,104,221,229,127,231,158,59,184,31,220,54,87,186,148,187,204,80,238,108,113,199,128,71,66,84,84,176,3,55,36,194,253,93,3,118,6,65,243,99,232,118,49,21,209,189,223,56,108,7,34,64,92,32,171,247,160,245,117,65,197,2,63,57,40,65,126,102,88,98,110,186,203,15,132,241,125,115,80,99,5,52,82,244,163,152,18,168,182,110,175,9,214,77,71,203,202,145,115,248,188,5,91,161,90,214,108,145,105,89,243,251,149,22,4,183,1,104,89,110,175,242,53,255,84,55,104,149,231,46,229,5,252,63,116,147,230,110,242,123,221,148,42,47,238,110,208,38,61,25,196,14,151,255,111,247,125,65,132,171,92,60,44,5,87,164,108,72,250,117,83,111,69,74,108,101,216,90,188,124,63,254,152,75,188,230,92,66,240,91,23,235,114,173,11,219,133,248,15,206,142,108,250,246,155,2,43,194,107,14,132,240,225,29,128,9,192,238,202,94,197,153,59,10,86,227,126,74,68,66,192,23,90,105,169,124,184,52,224,192,111,118,124,31,241,202,63,94,38,152,212,216,246,38,221,106,222,98,222,148,214,102,46,166,109,237,120,123,161,226,185,251,221,134,210,127,174,252,113,22,229,224,68,42,102,222,251,174,159,14,80,33,178,160,11,106,166,79,119,85,51,10,225,114,145,8,110,179,141,28,174,212,47,122,222,84,80,138,56,140,214,92,13,193,27,18,67,189,230,244,172,223,97,202,243,138,23,170,234,109,138,251,210,196,127,179,82,203,163,118,251,159,241,6,170,123,38,53,4,239,144,98,8,225,100,145,63,11,125,182,25,202,255,172,72,192,141,195,5,24,252,225,18,160,86,199,208,139,139,110,78,124,179,192,158,61,130,243,209,237,94,57,147,34,51,237,26,54,95,155,166,105,241,21,39,171,226,8,118,239,174,101,96,212,78,104,176,19,49,61,29,42,237,121,179,63,104,126,135,251,117,169,202,228,243,167,138,131,226,168,200,50,220,28,142,253,152,21,190,228,172,80,222,242,101,143,208,240,155,120,223,58,96,84,171,11,94,157,135,160,30,52,108,116,115,126,67,7,13,255,247,70,158,154,236,8,50,7,201,69,177,212,128,206,215,23,106,253,123,140,54,93,25,93,165,191,57,124,119,191,30,16,60,22,195,102,248,70,179,38,47,245,2,186,227,3,134,198,152,212,127,121,109,245,144,67,211,182,23,219,134,221,112,5,122,132,191,216,240,247,53,166,191,58,176,250,102,171,181,45,201,3,173,77,119,27,208,251,141,201,214,175,75,94,224,251,18,235,176,238,201,238,55,77,140,95,108,100,220,241,33,140,223,114,245,12,206,20,212,5,62,253,13,157,55,228,117,123,41,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateBodyTemplateLocalizableString());
			LocalizableStrings.Add(CreateTitleTemplateLocalizableString());
			LocalizableStrings.Add(CreateDateMacrosLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateBodyTemplateLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("55671414-7004-4655-bd33-f33694187f1b"),
				Name = "BodyTemplate",
				CreatedInPackageId = new Guid("f47b7eb4-25f2-40e9-8029-0cf09a9ad463"),
				CreatedInSchemaUId = new Guid("d7ed1775-3874-4e65-8859-caee2336bd5e"),
				ModifiedInSchemaUId = new Guid("d7ed1775-3874-4e65-8859-caee2336bd5e")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateTitleTemplateLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("698137bc-ada1-4693-9f2d-ead1f73c1dd1"),
				Name = "TitleTemplate",
				CreatedInPackageId = new Guid("f47b7eb4-25f2-40e9-8029-0cf09a9ad463"),
				CreatedInSchemaUId = new Guid("d7ed1775-3874-4e65-8859-caee2336bd5e"),
				ModifiedInSchemaUId = new Guid("d7ed1775-3874-4e65-8859-caee2336bd5e")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateDateMacrosLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("2fcf728c-3ce9-43be-a65e-d4baccb54593"),
				Name = "DateMacros",
				CreatedInPackageId = new Guid("6e7e08a6-1dd2-4d95-aa5c-0c8e6a3dc851"),
				CreatedInSchemaUId = new Guid("d7ed1775-3874-4e65-8859-caee2336bd5e"),
				ModifiedInSchemaUId = new Guid("d7ed1775-3874-4e65-8859-caee2336bd5e")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d7ed1775-3874-4e65-8859-caee2336bd5e"));
		}

		#endregion

	}

	#endregion

}
