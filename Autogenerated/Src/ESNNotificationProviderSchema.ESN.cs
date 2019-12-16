﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ESNNotificationProviderSchema

	/// <exclude/>
	public class ESNNotificationProviderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ESNNotificationProviderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ESNNotificationProviderSchema(ESNNotificationProviderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("06f786d5-2d59-471a-90d9-3161d2a00d99");
			Name = "ESNNotificationProvider";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("457dd3cb-b18f-4592-8a4e-b806b9afb442");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,237,27,201,110,227,54,244,236,1,230,31,4,247,162,96,12,165,203,45,201,4,200,14,23,217,16,59,237,161,51,24,40,18,157,168,213,226,146,148,3,183,152,127,47,119,145,20,37,209,142,231,82,12,10,180,17,249,54,62,190,149,207,45,227,2,160,101,156,128,96,14,32,140,81,181,192,209,89,85,46,178,231,26,198,56,171,202,247,239,254,125,255,110,84,163,172,124,14,102,107,132,65,113,104,125,19,248,60,7,9,5,70,209,21,40,1,204,146,6,70,39,11,65,215,122,116,126,234,222,42,138,170,36,59,100,239,7,8,158,9,139,224,162,172,139,131,224,98,118,123,91,225,108,145,37,76,202,121,134,115,192,192,150,245,83,158,37,1,32,80,29,64,35,122,160,209,117,246,23,72,131,143,193,143,19,250,69,25,129,18,179,149,159,216,202,13,249,36,56,108,229,103,182,114,11,94,111,0,66,241,51,32,75,191,144,149,175,92,46,80,166,92,52,67,204,179,60,70,168,37,231,61,172,86,89,10,160,46,106,66,33,187,0,131,131,224,52,70,192,181,53,9,166,250,178,60,152,18,128,92,7,142,75,76,132,184,135,217,42,198,92,63,163,37,255,8,18,186,31,32,12,169,202,175,30,238,30,239,191,220,158,220,92,144,179,141,45,89,198,135,157,120,26,198,152,95,147,173,15,37,207,101,6,242,180,75,24,65,238,11,166,87,164,46,227,176,19,68,221,78,55,72,115,93,221,48,204,8,156,219,41,249,184,137,19,88,161,14,236,162,111,251,169,74,215,231,100,225,98,69,228,28,208,11,187,39,88,39,184,130,84,59,204,38,132,114,184,125,116,88,70,120,158,49,159,139,225,250,136,243,157,4,213,211,159,196,17,143,131,101,12,137,95,99,0,209,30,37,52,58,8,158,136,17,133,218,114,192,108,101,52,3,120,198,112,127,139,243,26,132,123,236,52,95,189,216,63,34,0,137,236,37,247,252,160,54,62,13,182,214,150,7,235,46,93,17,230,75,0,113,6,44,77,237,239,239,7,71,168,46,10,162,140,99,185,112,5,171,122,25,148,228,196,145,130,217,215,129,196,1,165,11,48,112,46,219,51,192,226,175,17,4,184,134,165,230,32,76,78,42,168,146,214,201,93,57,176,183,0,183,4,176,147,191,155,115,151,158,110,0,126,169,134,156,237,10,96,101,163,161,88,91,209,187,144,55,68,119,231,196,208,131,84,254,241,145,90,235,138,220,64,52,175,228,110,200,113,184,112,171,24,50,104,2,41,145,8,40,191,231,80,115,42,13,28,115,194,14,240,198,201,4,184,208,5,151,53,186,172,96,17,227,208,116,182,9,35,52,97,84,77,107,110,29,158,165,3,121,112,188,94,2,122,1,242,236,84,178,140,36,55,34,89,232,74,35,123,52,13,69,247,49,36,246,77,113,171,133,27,108,210,80,230,103,64,175,25,78,94,130,144,18,151,204,70,9,113,19,103,182,138,84,44,60,224,144,82,7,174,72,217,71,135,69,58,39,141,38,6,246,225,171,128,235,164,97,134,227,62,58,77,84,118,18,178,130,246,104,148,130,69,92,231,216,2,22,22,112,81,44,241,186,237,21,242,170,103,128,150,37,244,170,103,245,19,255,8,245,251,69,124,255,99,80,130,87,1,108,69,181,189,232,60,67,56,43,41,34,151,128,22,59,117,81,134,99,82,251,156,164,69,86,62,150,25,30,79,130,241,52,29,239,69,39,200,220,160,139,22,158,157,91,9,234,25,4,68,220,244,174,20,20,180,111,11,153,72,134,227,4,79,203,69,69,17,169,89,153,56,167,107,190,214,143,119,255,82,225,74,9,172,190,250,37,157,19,59,182,152,206,133,105,251,162,158,48,165,106,200,114,193,214,109,149,100,113,46,12,193,80,174,88,115,72,219,194,185,32,38,137,215,10,179,249,108,95,228,44,121,1,69,108,29,142,47,26,199,187,132,85,209,190,65,185,251,107,149,149,33,253,23,61,89,116,13,22,248,174,198,180,76,179,100,19,240,163,232,206,109,14,6,52,147,127,138,46,254,174,227,188,67,49,195,236,213,9,13,214,29,26,227,160,143,22,99,93,73,143,94,92,133,205,13,30,247,238,149,116,12,38,55,137,218,119,192,41,241,81,113,184,198,15,13,94,22,21,227,48,134,235,74,239,216,232,84,220,235,52,191,26,58,167,242,80,231,89,165,107,122,9,225,114,175,33,246,20,200,228,220,225,164,141,4,65,244,251,11,128,192,73,110,138,30,64,172,147,227,238,68,51,34,47,49,195,69,156,35,176,167,72,157,148,105,91,243,212,255,87,160,143,10,169,140,109,34,131,186,37,187,97,247,57,13,155,11,98,36,34,191,89,97,52,75,86,78,89,85,89,26,216,165,171,200,41,86,78,38,137,197,204,38,164,57,198,215,85,18,231,217,63,241,83,14,68,153,99,203,39,11,71,118,105,6,193,177,40,33,172,156,187,43,62,138,160,201,199,104,123,119,194,168,161,104,114,146,45,249,78,152,48,98,138,126,83,121,238,128,254,185,34,166,201,95,236,142,254,92,17,83,244,141,26,119,7,44,78,117,122,99,103,161,124,85,19,75,159,195,53,171,113,233,135,179,71,160,117,20,4,136,148,104,68,42,10,165,23,101,236,91,146,224,125,2,233,81,107,44,48,204,170,158,175,245,151,236,84,108,87,223,203,255,123,28,164,106,139,7,18,230,159,170,217,21,116,18,89,94,209,174,195,137,240,135,86,130,125,62,116,224,242,50,107,24,95,148,99,38,13,173,155,50,90,48,37,215,158,1,142,85,157,212,195,79,43,166,76,102,133,114,221,46,84,233,138,214,65,115,16,67,110,72,4,87,80,161,118,118,214,108,132,230,5,154,186,249,16,140,201,63,31,116,241,233,210,167,49,93,212,169,147,213,79,28,84,42,70,218,192,200,179,197,173,48,113,3,144,74,163,17,159,65,69,26,85,72,12,94,235,3,232,83,154,213,8,136,77,36,59,4,126,43,90,195,96,156,177,187,83,208,75,68,69,140,87,9,186,19,34,219,217,90,210,178,12,115,146,166,252,150,80,40,5,228,4,165,41,179,47,171,146,53,249,88,181,145,111,127,210,34,226,223,157,116,161,202,166,196,163,81,105,145,240,107,85,90,104,77,103,210,223,168,56,17,125,219,148,22,178,94,179,111,216,173,168,132,168,35,14,115,244,109,114,218,166,161,117,55,173,118,199,199,66,89,97,74,179,141,143,133,118,148,238,221,109,145,187,3,84,37,93,159,230,7,132,55,222,204,105,213,77,221,253,1,36,21,76,237,157,55,103,26,249,244,51,16,184,245,28,161,197,153,150,56,234,185,136,21,56,60,80,241,71,44,245,198,52,225,0,52,79,242,125,150,49,59,132,21,192,211,130,105,142,192,27,217,190,75,98,233,131,159,37,190,52,58,95,2,202,72,45,10,141,5,246,232,75,51,211,207,2,91,221,189,175,0,141,177,40,9,244,160,232,75,198,10,164,138,22,123,72,22,199,96,127,243,7,42,207,176,207,91,34,154,92,46,179,156,118,64,46,239,242,201,30,101,154,49,247,232,35,48,156,92,219,227,8,147,21,105,133,100,162,186,206,16,62,146,254,145,240,69,105,178,226,51,34,146,133,99,229,165,230,178,209,196,117,239,211,196,211,135,173,133,48,19,66,37,15,199,94,147,32,58,54,101,10,112,108,219,177,199,185,235,220,107,194,181,99,179,51,32,91,215,208,84,199,60,138,61,176,58,122,251,216,197,94,190,211,30,23,164,182,222,60,223,151,90,148,82,245,98,251,125,214,6,157,250,115,72,26,187,240,169,184,157,200,155,21,251,6,215,109,42,125,74,96,201,205,173,7,85,69,82,109,24,178,121,198,144,104,91,244,8,20,181,208,162,167,71,192,108,33,250,119,22,20,9,52,185,98,56,61,52,104,104,211,212,160,221,227,6,141,140,156,94,249,116,103,236,138,171,101,189,20,243,131,123,250,55,1,143,55,79,211,59,107,156,90,9,93,216,96,59,81,203,123,232,78,192,141,202,29,105,86,25,141,150,218,196,72,5,102,244,25,2,220,11,213,48,21,69,51,185,28,246,77,242,48,40,150,57,155,222,153,145,98,98,145,237,13,135,77,179,199,14,149,1,100,53,124,236,93,35,145,79,190,237,183,148,179,26,66,162,30,186,26,169,151,97,253,132,131,67,35,171,246,118,189,158,202,130,125,163,1,209,105,83,232,27,43,222,4,252,39,76,219,76,151,190,79,150,108,68,239,201,210,168,61,103,252,62,107,250,6,179,166,254,25,204,255,127,254,226,53,126,107,81,82,193,242,109,131,24,111,186,45,99,33,40,36,34,11,33,111,235,60,15,21,2,105,190,170,242,132,172,8,245,15,69,229,141,227,242,14,34,243,27,99,243,118,209,121,139,248,252,166,8,253,230,24,221,23,113,53,3,112,198,234,46,92,142,231,17,179,183,139,218,142,184,61,20,185,183,136,221,187,142,222,155,136,192,79,238,80,169,37,92,135,214,7,100,106,174,213,71,178,86,102,233,231,189,69,134,217,40,199,236,38,203,108,157,103,118,154,105,118,154,107,118,157,109,190,93,190,241,202,56,146,168,145,119,90,63,28,48,230,160,222,173,65,235,29,123,131,129,140,179,246,239,155,222,120,211,221,112,50,51,4,184,221,240,101,8,118,155,217,202,16,205,237,198,39,122,193,46,30,89,101,45,232,152,254,57,139,203,111,59,17,225,100,220,191,116,105,79,221,157,191,102,126,96,208,200,104,204,59,126,212,204,86,56,117,116,172,139,21,29,237,203,101,173,113,159,210,31,210,2,72,39,73,71,173,217,204,49,237,227,141,163,169,54,94,254,46,219,218,167,88,168,247,199,228,237,255,107,131,172,252,7,181,6,166,4,7,51,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateTitleCommentedLocalizableString());
			LocalizableStrings.Add(CreateTitleMentionedLocalizableString());
			LocalizableStrings.Add(CreateTitleNewMessageLocalizableString());
			LocalizableStrings.Add(CreateTitleLikedLocalizableString());
			LocalizableStrings.Add(CreateDateMacrosLocalizableString());
			LocalizableStrings.Add(CreateTimeMacrosLocalizableString());
			LocalizableStrings.Add(CreateBodyDateEventLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateTitleCommentedLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("a4c23e04-0b50-43f3-b76b-771eb96b9624"),
				Name = "TitleCommented",
				CreatedInPackageId = new Guid("457dd3cb-b18f-4592-8a4e-b806b9afb442"),
				CreatedInSchemaUId = new Guid("06f786d5-2d59-471a-90d9-3161d2a00d99"),
				ModifiedInSchemaUId = new Guid("06f786d5-2d59-471a-90d9-3161d2a00d99")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateTitleMentionedLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("f58112ae-7e20-4df2-89e1-168f093e1194"),
				Name = "TitleMentioned",
				CreatedInPackageId = new Guid("457dd3cb-b18f-4592-8a4e-b806b9afb442"),
				CreatedInSchemaUId = new Guid("06f786d5-2d59-471a-90d9-3161d2a00d99"),
				ModifiedInSchemaUId = new Guid("06f786d5-2d59-471a-90d9-3161d2a00d99")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateTitleNewMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("c7e0233a-0405-4626-a0c6-91a072a844c4"),
				Name = "TitleNewMessage",
				CreatedInPackageId = new Guid("b66b5ae8-46e0-4931-ad78-c2c1ba5fd6ea"),
				CreatedInSchemaUId = new Guid("06f786d5-2d59-471a-90d9-3161d2a00d99"),
				ModifiedInSchemaUId = new Guid("06f786d5-2d59-471a-90d9-3161d2a00d99")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateTitleLikedLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("5394e241-89ba-469a-838f-7401b63777fa"),
				Name = "TitleLiked",
				CreatedInPackageId = new Guid("457dd3cb-b18f-4592-8a4e-b806b9afb442"),
				CreatedInSchemaUId = new Guid("06f786d5-2d59-471a-90d9-3161d2a00d99"),
				ModifiedInSchemaUId = new Guid("06f786d5-2d59-471a-90d9-3161d2a00d99")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateDateMacrosLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("e8a0fbc2-5967-4fd3-bfcc-9a5d6dd8723a"),
				Name = "DateMacros",
				CreatedInPackageId = new Guid("b64b9f5a-5c5e-4bde-8ab1-00fea20b44ec"),
				CreatedInSchemaUId = new Guid("06f786d5-2d59-471a-90d9-3161d2a00d99"),
				ModifiedInSchemaUId = new Guid("06f786d5-2d59-471a-90d9-3161d2a00d99")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateTimeMacrosLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("49ebe819-0c0e-4089-8f8c-ef286817f3d7"),
				Name = "TimeMacros",
				CreatedInPackageId = new Guid("b64b9f5a-5c5e-4bde-8ab1-00fea20b44ec"),
				CreatedInSchemaUId = new Guid("06f786d5-2d59-471a-90d9-3161d2a00d99"),
				ModifiedInSchemaUId = new Guid("06f786d5-2d59-471a-90d9-3161d2a00d99")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateBodyDateEventLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("f14b9ccf-a609-4579-8183-711688d7a400"),
				Name = "BodyDateEvent",
				CreatedInPackageId = new Guid("b64b9f5a-5c5e-4bde-8ab1-00fea20b44ec"),
				CreatedInSchemaUId = new Guid("06f786d5-2d59-471a-90d9-3161d2a00d99"),
				ModifiedInSchemaUId = new Guid("06f786d5-2d59-471a-90d9-3161d2a00d99")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("06f786d5-2d59-471a-90d9-3161d2a00d99"));
		}

		#endregion

	}

	#endregion

}
