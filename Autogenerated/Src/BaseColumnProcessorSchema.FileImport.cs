﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: BaseColumnProcessorSchema

	/// <exclude/>
	public class BaseColumnProcessorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public BaseColumnProcessorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public BaseColumnProcessorSchema(BaseColumnProcessorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("9a78ff61-e56b-4033-9d63-6f39b2e2a039");
			Name = "BaseColumnProcessor";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("52abf94a-4a51-4e9b-afae-86480a04ff1e");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,221,88,75,111,27,55,16,62,43,64,254,3,187,237,65,2,132,213,61,146,182,72,109,57,21,218,184,133,29,183,199,130,218,29,217,108,246,161,144,92,37,170,225,255,222,225,99,45,114,159,178,99,52,64,47,182,150,59,28,14,191,153,249,102,102,115,154,129,216,209,24,200,7,224,156,138,98,43,195,179,34,223,178,219,146,83,201,138,60,188,96,41,172,179,93,193,229,235,87,247,175,95,141,74,193,242,91,114,125,16,18,178,121,237,25,183,166,41,196,106,159,8,223,65,14,156,197,71,25,247,132,44,43,242,246,55,28,186,214,195,85,46,153,100,32,80,0,69,190,231,112,139,7,145,179,148,10,241,134,252,68,5,224,241,101,150,255,206,139,24,132,40,184,22,155,205,102,100,33,202,44,163,252,16,217,103,35,71,118,149,32,217,224,102,18,43,69,97,181,101,230,236,217,149,155,148,197,132,110,132,228,52,150,70,178,237,68,242,134,172,143,128,121,47,87,156,23,124,234,189,230,64,165,213,32,240,148,123,109,239,241,94,8,162,164,185,196,187,161,10,137,176,66,98,36,118,213,35,137,149,12,65,171,52,90,135,29,220,172,19,20,222,1,151,135,75,116,45,89,146,192,46,7,243,158,173,87,176,5,14,121,12,215,241,29,100,180,69,75,83,34,152,91,123,33,79,140,201,190,253,228,130,65,154,104,235,217,30,47,90,217,174,31,170,131,255,138,27,24,189,199,31,244,22,6,180,107,116,120,25,203,130,55,1,170,251,220,56,93,195,45,8,211,176,98,196,23,91,34,17,27,148,4,116,62,135,237,50,104,113,105,48,139,194,71,157,179,186,210,197,142,114,154,145,28,81,90,6,165,0,142,118,229,38,3,130,232,6,159,21,206,118,33,92,204,180,116,228,59,162,229,204,241,141,167,137,248,138,39,100,25,145,154,196,178,38,51,128,158,245,46,230,210,137,216,121,9,67,64,249,137,100,198,81,29,232,28,47,104,93,221,204,6,235,105,162,104,101,52,186,5,105,127,141,216,150,140,187,35,131,124,183,36,121,153,166,147,74,124,196,65,150,60,239,15,38,37,247,96,254,173,175,64,20,37,199,88,198,232,81,10,133,253,191,172,193,26,254,89,240,143,154,30,195,218,22,171,176,199,72,180,17,62,147,95,139,152,166,236,31,186,73,113,167,130,97,108,207,154,146,214,96,155,218,27,141,130,198,78,17,118,34,24,254,65,211,18,130,137,181,234,68,56,52,26,15,61,94,63,167,146,146,189,82,109,18,165,204,217,39,252,205,18,64,34,222,50,224,131,174,127,100,204,119,37,75,180,62,109,169,165,36,114,79,208,233,115,210,103,67,61,135,134,78,172,229,69,237,209,63,176,43,59,86,123,48,180,171,105,223,242,150,41,1,160,94,25,129,159,105,158,164,192,23,77,175,232,215,111,249,173,136,136,187,60,144,147,239,65,222,21,201,19,201,204,184,248,84,130,50,210,38,88,34,155,211,198,191,44,223,22,60,163,13,154,210,42,76,60,137,200,148,173,234,204,197,172,90,247,61,224,214,62,226,214,184,177,251,70,27,65,28,131,52,171,169,148,241,246,219,12,95,231,9,124,193,148,114,228,109,54,232,55,54,107,174,117,134,214,196,244,95,29,233,243,147,241,36,9,8,201,114,218,19,113,13,108,85,78,200,131,169,142,65,164,91,149,3,17,250,177,137,104,215,70,115,167,218,246,35,224,61,90,94,210,181,222,245,79,113,243,249,81,222,243,184,179,62,94,57,215,36,238,157,173,243,86,13,24,72,19,153,41,121,122,12,185,198,85,225,36,126,129,3,198,201,59,144,107,129,237,137,242,234,57,19,187,148,30,108,168,122,6,182,24,50,169,66,174,234,134,80,155,43,21,226,146,21,49,27,108,31,213,212,20,170,55,158,168,190,74,183,124,77,200,110,61,86,116,115,175,198,221,143,2,227,54,92,93,20,7,179,229,130,229,73,91,174,60,173,76,52,98,216,209,244,24,195,126,40,118,68,239,135,246,99,187,66,87,23,35,117,7,115,134,173,70,227,174,160,113,76,208,1,230,154,212,212,50,233,3,14,29,211,138,91,2,91,90,166,82,53,88,214,73,207,161,157,111,198,30,77,95,181,221,168,203,29,123,198,101,73,83,114,206,116,145,198,171,46,76,203,56,37,197,230,111,148,137,134,2,250,101,25,196,104,83,52,210,99,81,213,122,142,238,219,230,174,105,179,215,177,189,103,111,94,157,131,4,158,177,92,77,41,91,107,188,239,70,194,4,66,170,9,139,36,134,177,158,216,3,124,131,58,85,185,125,17,71,56,178,193,98,22,71,211,103,92,176,43,126,54,69,145,246,80,121,119,225,33,39,69,76,53,102,236,41,71,227,218,142,64,198,221,210,84,216,182,218,142,59,187,22,193,22,82,215,12,210,166,84,201,142,109,71,175,230,161,46,125,225,90,92,22,242,18,231,161,223,248,42,219,201,195,120,242,56,24,117,154,219,169,108,245,9,51,177,173,66,232,50,53,113,6,135,106,202,104,63,99,62,52,91,92,131,42,33,166,157,198,235,97,135,191,199,228,81,108,96,104,71,232,17,239,212,190,22,210,244,241,3,69,16,245,134,177,157,90,125,41,135,140,10,172,13,202,56,183,115,31,91,159,122,231,76,171,193,214,106,116,227,4,170,9,192,142,129,61,51,194,35,147,156,185,202,85,19,235,29,102,133,142,211,165,61,213,56,196,248,197,213,255,99,184,206,247,197,71,24,203,59,38,166,71,131,38,255,177,103,220,194,242,20,196,7,88,218,128,214,216,245,67,112,223,49,34,60,120,47,174,138,207,102,53,152,118,127,151,240,160,26,158,218,156,97,241,185,228,30,211,156,108,160,250,204,2,201,75,55,1,39,51,179,181,64,69,183,226,227,2,127,110,82,168,51,176,25,137,171,242,173,105,248,140,86,72,142,79,36,215,170,222,214,11,102,15,21,121,162,170,211,238,237,185,124,220,91,154,175,231,162,254,236,118,245,107,208,174,163,124,82,211,106,178,69,183,189,177,219,172,34,141,52,27,88,119,231,220,101,122,111,107,229,158,186,219,134,249,229,121,159,46,254,71,227,117,187,99,187,63,155,124,109,3,99,107,199,73,140,234,89,17,87,237,130,103,142,187,107,222,216,212,17,131,53,37,238,135,129,161,81,187,42,125,205,115,45,156,142,50,17,190,77,6,35,184,135,214,205,170,191,136,107,255,2,227,112,194,95,38,27,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateColumnProcessErrorMessageLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateColumnProcessErrorMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("f5c3f411-8079-4921-aed5-e94df64178aa"),
				Name = "ColumnProcessErrorMessage",
				CreatedInPackageId = new Guid("79cdeed7-eef0-4dd8-9765-07d140cf1035"),
				CreatedInSchemaUId = new Guid("9a78ff61-e56b-4033-9d63-6f39b2e2a039"),
				ModifiedInSchemaUId = new Guid("9a78ff61-e56b-4033-9d63-6f39b2e2a039")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("9a78ff61-e56b-4033-9d63-6f39b2e2a039"));
		}

		#endregion

	}

	#endregion

}
