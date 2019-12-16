﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: MLDataLoaderSchema

	/// <exclude/>
	public class MLDataLoaderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public MLDataLoaderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public MLDataLoaderSchema(MLDataLoaderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("161679eb-f695-4fd4-b32c-102e652cd2b1");
			Name = "MLDataLoader";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("73704ec6-562c-4400-8a4a-17477a18625f");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,221,27,89,111,219,70,250,89,5,250,31,166,218,34,161,16,45,157,60,20,5,98,75,133,175,4,106,237,56,107,187,45,22,65,80,208,228,200,154,134,135,60,36,109,171,169,255,251,126,223,28,156,131,164,36,167,217,22,173,95,44,13,231,187,239,25,42,143,50,90,46,163,152,146,75,202,121,84,22,243,42,60,44,242,57,187,174,121,84,177,34,15,79,79,190,252,226,227,151,95,12,234,146,229,215,228,98,85,86,52,219,245,190,3,72,154,210,24,247,151,225,107,154,83,206,226,214,158,163,168,138,90,139,39,44,191,49,139,135,69,150,21,185,255,61,252,190,116,23,57,117,191,133,71,7,222,194,113,94,177,138,209,210,91,126,21,197,85,193,157,245,55,244,174,2,174,81,110,151,140,247,0,181,114,75,121,69,185,13,92,179,240,130,242,91,22,211,211,34,161,105,120,124,95,209,188,68,53,192,38,216,246,47,78,175,225,27,153,229,0,56,7,53,191,36,179,211,19,212,196,73,17,37,148,139,77,59,59,59,100,175,172,179,44,226,171,169,250,142,143,75,146,192,70,50,47,56,201,162,120,193,114,74,82,26,241,28,40,135,26,108,199,130,91,214,87,41,139,9,211,180,124,82,131,143,130,92,139,158,69,176,90,80,73,244,106,69,226,69,157,127,40,199,132,222,211,184,174,80,220,107,118,75,115,178,136,242,36,165,156,128,88,20,216,10,27,148,59,62,206,189,101,196,163,140,228,224,99,147,97,73,209,67,134,211,75,32,177,87,82,74,98,78,231,147,225,133,92,222,153,146,155,154,242,149,144,54,5,94,144,30,114,18,238,237,8,44,221,72,139,252,16,185,20,18,38,195,233,190,112,65,144,34,170,20,219,180,212,124,146,18,188,50,74,217,111,52,145,34,10,249,4,45,88,153,243,34,107,164,191,138,74,106,137,229,209,231,180,170,121,94,78,223,212,217,21,170,97,174,113,240,226,174,4,118,245,115,4,0,91,8,205,162,25,2,41,42,145,138,24,19,201,236,94,89,113,144,117,74,28,81,70,187,219,155,10,53,182,228,52,97,2,223,95,106,14,138,97,183,154,37,18,173,252,70,88,130,31,230,140,242,54,176,214,213,145,100,30,184,29,147,187,5,229,84,136,247,129,2,180,148,20,192,211,68,80,25,139,239,183,81,90,83,231,225,211,82,46,122,22,48,152,149,166,199,164,184,250,21,100,156,54,134,121,85,240,183,141,254,124,43,189,174,89,66,180,92,159,110,150,127,98,64,125,106,20,221,22,160,210,173,148,175,66,100,118,194,202,106,175,223,146,211,142,232,25,60,200,4,76,243,68,230,96,39,31,31,166,81,89,190,36,118,126,148,85,175,55,33,59,69,145,8,97,40,22,3,161,223,211,19,169,12,161,6,190,46,57,199,72,184,147,174,206,206,154,197,183,188,88,66,189,129,98,245,146,188,21,192,107,124,239,53,173,192,46,28,20,87,73,23,44,33,207,97,106,194,207,245,18,249,178,204,181,206,195,68,12,53,95,47,61,84,18,156,28,209,121,84,167,149,137,194,23,207,159,63,39,156,198,5,79,74,11,187,65,102,106,19,17,134,186,64,164,31,201,53,173,118,129,231,93,242,64,38,2,201,186,0,107,9,153,177,156,101,117,166,9,147,184,168,243,234,113,194,109,66,209,41,193,41,203,207,229,254,67,220,174,228,32,70,144,199,73,17,221,183,89,24,147,40,77,139,59,136,169,170,80,6,124,164,96,93,88,59,44,247,237,55,31,54,138,27,221,175,21,247,219,111,140,225,188,120,123,108,16,246,134,31,68,195,45,20,146,146,64,107,2,121,69,197,17,198,30,203,150,41,205,32,67,139,200,44,181,167,90,25,209,105,131,48,49,54,29,82,103,164,74,242,148,70,105,89,40,12,253,189,113,232,34,39,59,136,225,157,210,242,1,203,49,237,6,213,106,73,139,121,224,108,29,141,222,175,203,10,164,213,40,250,249,1,56,41,171,40,175,48,61,112,118,27,85,84,62,95,202,47,96,112,120,78,100,166,196,29,40,222,127,176,34,64,175,94,103,249,27,200,95,96,187,33,20,235,110,211,53,132,94,97,117,237,163,194,105,148,20,121,186,34,63,150,34,149,229,114,10,32,191,212,206,247,221,78,152,118,26,36,191,196,242,255,132,228,244,174,99,67,48,234,67,37,26,240,99,168,167,85,249,166,144,253,6,249,37,107,47,110,144,86,168,149,215,56,39,108,147,120,103,57,204,25,162,171,68,215,68,158,153,48,75,76,59,28,209,247,67,97,246,109,203,189,171,80,89,246,113,13,13,173,22,157,210,174,92,203,166,25,120,70,114,81,142,8,142,121,131,129,103,58,48,69,135,45,7,150,158,246,249,117,141,1,232,237,131,101,101,198,142,189,129,47,207,216,119,25,105,232,65,151,9,1,173,200,29,114,156,91,193,196,89,237,117,58,192,52,104,177,36,209,62,252,45,77,218,66,32,131,101,56,117,155,19,224,178,233,70,48,248,151,188,136,105,89,254,49,239,24,119,69,171,164,255,56,199,49,17,46,63,252,131,220,169,47,167,56,173,92,87,22,157,137,196,44,14,9,96,100,168,48,115,221,120,43,187,235,247,183,22,38,83,41,175,143,135,124,247,29,9,218,171,29,42,104,17,153,6,163,209,134,236,121,74,171,69,209,91,44,74,172,209,49,17,253,255,126,146,156,113,240,164,131,213,172,162,25,116,22,80,42,69,1,247,103,128,183,209,53,141,174,82,42,151,207,150,170,202,203,255,99,130,62,121,94,220,17,224,190,130,255,218,23,213,243,176,155,70,120,136,7,41,170,150,12,160,139,16,243,76,96,109,134,14,205,124,102,185,226,198,65,167,73,13,84,141,189,49,197,117,63,101,81,9,58,181,144,132,199,247,160,197,18,207,134,194,139,162,230,49,181,182,74,62,6,86,121,54,187,33,76,112,1,176,129,81,228,195,131,21,86,239,64,107,200,39,172,196,26,72,192,80,51,227,111,83,187,228,12,165,26,194,137,214,227,59,127,247,123,155,199,183,122,252,209,18,154,5,25,162,238,174,192,71,54,150,228,52,163,218,88,224,19,141,141,2,201,253,216,214,225,184,69,78,97,120,176,130,208,115,182,110,157,190,130,206,204,209,165,231,116,61,38,213,38,239,68,106,206,64,149,201,80,233,202,111,228,94,165,242,13,102,86,192,33,242,120,176,18,116,91,10,28,97,24,219,27,3,169,73,106,240,77,166,132,174,113,57,50,105,123,4,121,242,196,134,17,107,225,172,124,83,167,233,25,63,206,150,213,74,102,0,32,36,143,88,20,11,187,143,85,191,239,201,159,65,251,70,127,45,219,110,136,19,54,39,129,6,6,239,5,97,253,200,206,128,4,100,33,192,253,181,58,94,177,212,68,146,2,26,133,188,168,176,158,85,17,107,56,185,99,213,2,166,56,212,235,211,143,62,237,135,167,33,153,85,36,171,161,71,31,74,98,131,103,100,136,72,177,244,1,12,171,112,60,131,130,147,96,254,57,59,63,58,62,39,7,255,197,6,3,214,194,161,10,157,106,193,33,249,97,200,205,114,136,41,150,92,114,96,225,130,86,66,73,199,247,49,21,177,21,40,17,236,120,217,218,134,34,95,159,211,101,10,19,211,43,150,226,169,199,207,32,155,154,41,196,120,96,194,118,221,241,217,120,93,154,99,137,249,162,13,208,68,143,194,238,230,109,245,244,178,88,6,47,70,225,207,120,108,24,216,88,148,211,171,140,211,241,196,246,5,201,26,120,251,241,77,29,165,129,124,20,154,20,214,28,1,142,186,52,101,171,104,6,237,1,71,5,157,208,121,245,125,193,252,146,230,9,39,118,40,238,127,133,207,24,184,248,95,60,184,132,201,17,189,82,127,14,5,114,205,236,171,130,31,67,225,234,3,51,80,200,201,89,221,228,75,143,121,197,157,169,244,114,65,152,41,80,33,96,252,29,74,110,255,145,170,117,46,230,134,18,6,153,253,208,11,52,23,14,188,185,159,70,224,248,176,1,196,234,177,117,27,168,92,223,239,112,194,110,29,216,194,27,130,157,186,236,205,119,18,223,44,241,159,245,228,62,249,213,66,225,42,108,115,8,173,75,132,221,167,1,86,58,116,17,109,74,138,61,57,49,127,106,82,226,199,231,15,42,207,132,196,160,126,73,62,190,120,120,108,38,147,228,209,247,179,168,210,121,173,79,38,149,113,6,45,117,66,249,84,241,135,182,185,73,47,233,125,5,197,205,241,45,39,99,232,46,170,155,142,227,85,54,92,111,178,184,128,14,90,206,21,113,100,201,69,210,248,55,108,117,132,65,148,198,79,138,24,199,81,209,4,203,77,176,1,82,77,69,85,176,180,54,168,110,192,243,253,240,231,130,127,16,151,189,225,57,45,69,6,188,128,110,95,168,207,29,100,199,14,27,42,219,250,102,119,13,161,89,26,235,35,156,208,59,54,92,51,128,133,226,195,202,76,92,0,199,150,12,183,184,133,171,59,113,29,66,251,94,209,89,82,202,239,65,19,66,250,190,79,21,45,85,141,120,81,84,103,34,151,252,8,233,92,233,88,92,24,175,46,226,5,205,162,211,40,7,138,92,149,45,119,109,226,39,148,176,3,82,74,122,27,113,242,107,89,228,138,186,52,9,36,101,188,76,62,162,13,119,123,173,75,100,52,4,16,168,56,12,99,161,130,158,6,45,113,148,66,109,250,42,71,170,47,147,46,9,208,223,103,234,60,227,96,5,26,8,92,125,72,164,51,27,171,240,117,73,84,140,67,180,188,241,100,178,196,12,15,106,150,38,199,122,75,96,115,20,2,129,190,140,140,218,146,123,1,86,249,117,139,137,160,67,160,177,35,116,104,7,206,224,199,146,238,39,25,203,207,217,245,162,194,232,157,71,105,73,101,136,75,178,13,201,176,29,216,208,12,252,196,74,6,81,5,144,21,175,169,15,162,69,198,202,99,148,162,4,82,206,201,180,91,10,196,56,19,54,224,77,85,144,178,173,173,84,46,154,222,172,2,156,64,28,40,70,58,123,49,199,218,77,185,153,11,8,116,188,207,220,163,161,89,203,250,74,113,50,105,197,170,69,152,116,57,226,159,208,227,93,104,246,130,134,209,238,38,111,139,203,124,124,116,137,121,216,187,145,220,182,174,107,101,46,104,252,65,159,109,225,248,21,168,219,94,97,150,161,210,141,67,161,11,198,189,204,213,245,29,164,136,155,43,184,73,147,174,155,107,57,179,45,243,46,126,38,125,185,221,2,241,174,198,44,16,247,201,186,81,216,235,99,214,117,79,77,219,228,233,213,114,63,60,209,248,9,143,27,54,28,82,12,103,201,137,222,10,21,80,152,197,96,89,58,199,80,141,183,43,84,111,123,158,170,60,116,210,197,66,155,47,21,123,216,173,59,10,176,245,161,246,216,71,85,146,5,107,197,137,144,177,124,114,196,184,204,43,216,33,128,139,237,151,49,21,183,83,35,59,29,138,44,172,142,216,186,36,83,199,111,65,143,54,198,198,179,252,131,187,134,62,100,77,94,86,110,146,116,209,153,99,147,203,66,35,9,20,87,10,238,170,40,82,178,136,74,229,81,78,126,70,55,172,138,42,74,61,71,124,110,129,66,170,53,46,124,194,50,134,27,124,119,159,106,16,249,178,87,112,116,112,44,94,129,40,56,73,174,154,143,93,29,65,89,115,122,116,96,150,2,225,106,63,64,63,30,10,98,20,198,72,237,27,119,11,6,5,38,176,132,121,242,132,4,95,117,112,248,251,239,29,114,237,249,108,27,204,3,71,65,162,244,169,94,91,75,52,19,167,167,84,92,56,38,40,138,107,136,80,10,73,229,142,192,8,109,209,16,46,147,232,180,167,167,55,253,93,151,1,248,107,246,132,152,143,130,132,155,71,104,49,238,26,203,236,62,199,183,170,172,148,129,163,66,75,11,207,38,14,2,131,25,134,153,78,157,121,105,10,84,206,221,29,141,35,91,162,90,51,10,116,172,199,121,81,95,47,212,59,44,98,88,1,157,154,57,165,1,26,124,61,188,196,186,245,84,158,18,81,1,102,222,17,82,151,251,248,82,1,52,32,41,228,29,124,173,12,70,35,143,199,135,241,144,60,179,145,146,195,154,115,200,245,176,181,37,226,195,208,104,247,193,86,134,171,102,8,10,91,60,156,214,88,94,211,54,104,79,168,41,164,29,190,10,10,109,235,125,218,138,49,155,122,107,34,26,182,230,154,50,148,192,2,22,85,77,21,189,83,57,37,132,50,121,119,200,238,93,19,180,60,236,157,163,152,127,147,23,239,27,28,170,114,131,229,103,137,117,64,142,55,231,239,191,131,20,165,70,174,145,163,18,53,28,185,135,167,2,197,168,219,161,140,227,12,145,31,10,69,58,178,39,232,72,57,168,60,86,164,136,143,204,146,46,81,157,170,31,52,98,154,157,237,194,35,245,166,130,23,219,68,197,106,3,162,79,232,155,44,142,147,112,79,126,127,3,163,116,3,216,127,205,163,43,119,115,147,163,111,112,26,216,71,87,133,70,9,15,237,83,206,150,55,118,117,120,27,95,52,235,233,255,180,73,69,187,33,244,142,123,244,116,190,1,167,246,156,254,227,67,69,228,79,40,70,29,117,129,203,127,141,246,183,168,9,170,164,73,200,16,119,6,126,197,96,166,113,217,124,212,55,16,119,116,36,16,128,162,146,195,191,61,197,89,168,14,160,209,164,132,61,123,102,135,87,51,221,192,14,245,194,139,2,130,158,82,28,137,49,67,98,128,60,189,107,246,190,119,54,203,198,83,132,73,208,108,233,8,62,99,125,49,21,34,202,45,156,211,64,245,78,118,103,185,46,49,118,116,55,133,214,164,179,13,47,22,235,65,67,106,6,7,119,117,166,36,79,38,212,91,238,120,32,33,79,27,228,64,22,88,232,197,17,93,89,0,105,122,201,50,218,188,23,223,220,13,185,9,200,144,232,63,57,63,203,205,59,160,155,196,147,74,252,212,55,67,149,248,179,99,40,179,148,35,194,61,121,220,130,230,157,90,23,119,166,60,168,187,187,240,48,66,82,102,179,61,226,166,192,134,3,180,95,26,10,193,40,84,3,166,114,132,68,21,163,73,67,80,187,143,154,112,245,117,212,148,124,21,168,205,239,228,218,123,188,20,58,58,192,170,50,26,53,80,10,189,1,67,27,153,48,56,116,175,22,67,235,124,148,232,204,239,145,105,28,123,4,233,214,232,87,112,131,4,196,155,196,135,234,138,214,89,20,8,53,111,0,140,22,10,58,61,3,149,182,213,251,19,230,173,130,77,175,99,253,197,191,98,32,127,195,159,49,232,133,238,159,51,24,112,123,191,122,123,232,150,241,170,134,150,245,147,127,229,176,233,212,3,181,83,204,117,253,251,67,199,30,42,211,54,108,106,254,172,209,101,218,147,100,173,220,231,178,191,249,93,178,63,225,167,26,159,234,115,159,252,91,13,189,240,57,127,179,177,214,205,62,239,79,56,172,86,237,209,231,76,110,167,182,241,46,92,51,208,220,127,187,7,168,235,28,115,36,143,73,130,63,232,98,255,200,12,184,77,218,235,120,215,241,255,255,179,147,230,190,110,125,142,233,238,117,182,203,50,91,188,95,15,107,255,3,188,203,109,243,214,57,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateRecordCountExceedsLimitMessageLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateRecordCountExceedsLimitMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("40d28b75-270e-4a45-888a-daec75ddf005"),
				Name = "RecordCountExceedsLimitMessage",
				CreatedInPackageId = new Guid("33c09d4f-db5e-4d77-bac6-f1fd801beedb"),
				CreatedInSchemaUId = new Guid("161679eb-f695-4fd4-b32c-102e652cd2b1"),
				ModifiedInSchemaUId = new Guid("161679eb-f695-4fd4-b32c-102e652cd2b1")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("161679eb-f695-4fd4-b32c-102e652cd2b1"));
		}

		#endregion

	}

	#endregion

}

