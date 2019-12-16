﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: BulkEmailSplitServiceSchema

	/// <exclude/>
	public class BulkEmailSplitServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public BulkEmailSplitServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public BulkEmailSplitServiceSchema(BulkEmailSplitServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("77633c26-d003-47e1-979b-4e2acd5f84c2");
			Name = "BulkEmailSplitService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b7874c9a-6e65-41ca-b21f-5fb1f6a22855");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,213,88,91,111,219,54,20,126,118,129,254,7,214,123,145,1,79,217,115,210,120,112,110,69,134,185,77,35,103,121,8,134,129,145,142,99,162,212,165,36,229,214,11,242,223,119,120,145,68,201,242,37,216,5,216,75,98,145,60,247,239,124,135,82,70,83,144,5,141,129,204,65,8,42,243,133,10,207,243,108,193,158,74,65,21,203,179,183,111,158,223,190,25,148,146,101,79,36,90,75,5,233,73,231,57,188,45,51,197,82,8,35,16,140,114,246,167,145,219,56,133,187,43,22,195,44,79,128,239,220,12,167,177,98,171,253,74,194,123,120,108,14,248,238,11,216,182,30,94,156,109,221,186,196,40,20,3,217,119,0,77,225,161,52,53,46,225,254,15,2,158,208,63,114,206,169,148,199,36,42,56,83,115,144,202,249,103,206,28,29,29,145,247,178,76,83,42,214,19,183,65,84,78,82,154,209,39,252,181,4,34,181,220,143,10,5,101,248,254,168,58,139,178,15,238,60,150,66,9,26,171,223,245,218,84,22,31,65,161,27,5,38,231,145,161,232,250,22,190,150,76,64,10,153,146,129,255,160,51,68,78,201,30,17,125,42,116,11,201,72,27,41,202,71,206,98,18,235,184,200,89,201,191,92,166,148,113,19,95,21,194,49,57,163,18,234,72,7,207,38,218,58,37,87,12,120,130,57,185,17,186,136,54,21,131,194,62,144,59,9,2,99,202,32,214,229,37,127,148,173,231,19,167,9,178,196,42,107,107,190,17,121,1,66,151,8,181,27,63,237,126,43,209,213,194,117,38,21,205,208,221,124,129,155,0,36,22,176,56,29,182,67,250,13,225,154,80,149,139,225,209,36,172,85,249,133,168,18,178,69,174,169,124,179,116,58,33,25,124,219,38,17,180,83,48,218,19,243,12,212,50,223,154,206,85,206,18,18,129,106,240,167,168,42,101,240,161,196,117,89,45,94,39,99,98,87,204,238,117,50,34,186,167,7,131,21,21,228,177,229,38,66,102,211,247,30,151,81,152,45,72,208,22,14,175,64,197,203,43,145,167,23,103,129,103,125,84,217,27,116,206,71,26,154,188,76,51,204,78,9,193,48,114,254,13,199,141,171,39,253,146,116,5,129,219,123,209,127,95,92,98,108,181,76,94,238,10,76,56,212,161,108,75,74,163,217,153,28,147,11,148,155,35,163,105,47,132,210,79,189,25,187,140,62,187,124,25,234,88,71,241,18,82,250,185,4,177,238,164,44,244,15,204,76,255,139,49,105,192,56,116,161,248,170,67,172,184,70,161,209,103,211,20,94,203,41,255,70,215,50,2,142,138,209,184,18,37,244,136,78,147,100,202,185,53,103,69,101,208,103,226,138,113,5,66,234,243,65,39,207,122,251,92,0,198,110,15,221,51,181,188,161,2,199,133,150,8,236,162,33,22,193,100,158,205,215,5,50,232,215,146,114,140,171,134,163,46,164,143,131,147,205,36,74,140,162,101,244,3,40,155,45,116,156,219,244,29,0,64,137,244,140,99,136,76,200,79,53,218,22,200,234,52,94,146,160,101,144,176,204,179,94,31,110,34,223,5,203,13,176,84,248,52,222,212,112,33,239,78,107,16,133,51,102,21,53,166,118,216,250,149,150,89,188,252,84,232,56,141,197,25,21,95,64,225,52,194,248,245,152,104,90,19,171,155,148,28,146,150,68,237,207,238,120,172,155,182,207,28,194,43,193,23,251,255,165,233,173,129,151,101,175,241,94,14,101,174,125,84,29,169,188,144,222,44,220,194,196,102,165,208,16,36,25,194,240,116,232,65,107,56,185,203,216,215,18,88,130,99,141,45,24,136,14,135,225,120,53,162,141,38,1,170,20,153,156,220,226,253,7,83,11,120,162,90,210,103,30,62,225,172,49,151,16,127,6,15,30,240,38,112,157,173,242,47,16,216,0,17,190,195,155,79,209,28,115,121,39,216,28,210,130,107,0,224,234,244,145,102,73,158,249,205,112,150,39,235,72,173,185,222,71,69,51,144,18,169,160,94,13,239,5,45,10,72,198,38,235,122,46,163,216,85,46,82,170,90,2,118,41,252,5,251,110,76,42,255,119,159,51,195,189,127,152,185,73,94,233,33,93,191,55,136,211,39,67,1,178,228,253,99,163,163,55,240,186,95,26,254,178,29,107,69,45,163,117,27,221,66,49,180,232,13,174,16,232,182,205,131,33,150,124,84,109,235,137,19,248,100,234,214,239,151,32,52,220,61,152,140,144,66,13,75,5,142,81,107,74,107,15,44,215,11,225,52,75,188,254,215,210,31,115,181,69,193,246,78,53,242,166,235,110,56,205,32,105,44,80,233,34,111,114,19,187,172,120,57,10,47,191,67,92,42,136,98,202,169,120,207,50,53,9,60,18,140,55,152,207,2,217,21,199,155,146,131,238,76,108,141,195,61,1,104,223,141,243,227,30,110,179,70,122,174,34,7,90,48,128,105,155,113,58,109,16,97,84,198,49,162,186,53,243,170,45,87,31,220,123,149,129,74,73,55,87,47,59,184,202,242,51,252,247,116,213,210,84,19,248,196,76,27,188,226,114,227,215,1,98,120,251,64,244,14,39,215,82,191,136,224,207,173,162,255,58,65,154,142,248,223,209,99,219,235,158,91,165,84,66,191,60,214,69,194,91,67,158,115,226,101,191,67,160,86,239,43,41,116,101,95,40,48,253,183,21,5,111,190,139,132,238,23,180,216,173,97,142,119,93,45,85,155,121,76,226,138,239,114,134,102,54,100,220,214,73,151,123,140,160,207,62,155,247,106,67,30,158,63,53,177,204,197,26,153,21,67,246,210,152,151,170,35,57,234,50,94,86,114,254,79,241,93,139,176,199,110,34,180,237,135,243,28,27,121,133,23,98,202,181,219,65,117,197,109,189,110,105,50,111,138,79,172,166,159,15,226,42,71,55,232,128,19,59,62,72,172,229,250,97,212,220,121,225,170,235,190,133,119,221,102,43,66,243,179,75,170,13,8,250,239,139,118,181,179,184,231,243,74,213,15,155,159,89,234,118,215,156,168,191,176,244,246,83,231,91,11,150,147,250,28,182,255,27,72,109,229,249,111,124,161,176,67,93,139,185,57,214,63,71,140,123,51,72,31,65,248,36,101,56,165,42,206,51,121,2,117,130,87,6,252,179,107,122,185,78,125,157,37,199,103,21,1,28,106,171,15,151,175,51,108,154,168,134,88,143,93,31,53,61,64,194,149,191,0,99,69,21,33,223,20,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateEmptyTemplateExistMessageLocalizableString());
			LocalizableStrings.Add(CreateStartTesteEmailAlreadyRunMessageLocalizableString());
			LocalizableStrings.Add(CreatePingFailedMessageLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateEmptyTemplateExistMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("2a828866-e9ee-45d5-a536-8125f02c4cd2"),
				Name = "EmptyTemplateExistMessage",
				CreatedInPackageId = new Guid("b7874c9a-6e65-41ca-b21f-5fb1f6a22855"),
				CreatedInSchemaUId = new Guid("77633c26-d003-47e1-979b-4e2acd5f84c2"),
				ModifiedInSchemaUId = new Guid("77633c26-d003-47e1-979b-4e2acd5f84c2")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateStartTesteEmailAlreadyRunMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("2b00a764-842e-4454-a992-e769b82fe861"),
				Name = "StartTesteEmailAlreadyRunMessage",
				CreatedInPackageId = new Guid("b7874c9a-6e65-41ca-b21f-5fb1f6a22855"),
				CreatedInSchemaUId = new Guid("77633c26-d003-47e1-979b-4e2acd5f84c2"),
				ModifiedInSchemaUId = new Guid("77633c26-d003-47e1-979b-4e2acd5f84c2")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreatePingFailedMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("31d5eb7a-edda-426c-a014-eaefeead5ca8"),
				Name = "PingFailedMessage",
				CreatedInPackageId = new Guid("76758615-8d8d-4dd0-bea5-ea3f93c49bbf"),
				CreatedInSchemaUId = new Guid("77633c26-d003-47e1-979b-4e2acd5f84c2"),
				ModifiedInSchemaUId = new Guid("77633c26-d003-47e1-979b-4e2acd5f84c2")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("77633c26-d003-47e1-979b-4e2acd5f84c2"));
		}

		#endregion

	}

	#endregion

}
