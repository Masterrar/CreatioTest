﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: FileImporterSchema

	/// <exclude/>
	public class FileImporterSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public FileImporterSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public FileImporterSchema(FileImporterSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("1bd89e09-c2b8-41e4-8c4f-fa8ab4fd104f");
			Name = "FileImporter";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("39b49a3d-3e30-4c01-a6cc-3961eeed3fd5");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,197,91,221,143,219,54,18,127,222,2,253,31,184,62,160,144,17,159,246,250,112,40,144,205,58,216,207,196,104,54,27,172,157,246,161,40,2,173,69,123,117,145,37,133,164,118,235,75,242,191,223,240,75,34,41,82,242,54,238,245,37,137,201,225,112,230,199,225,124,81,41,146,13,166,85,178,196,104,129,9,73,104,185,98,241,121,89,172,178,117,77,18,150,149,69,124,149,229,120,182,169,74,194,190,255,238,243,247,223,29,212,52,43,214,232,188,36,248,184,249,53,223,82,134,55,238,111,96,148,231,120,201,185,208,248,21,46,48,201,150,29,154,55,89,241,169,29,52,133,216,108,202,194,63,67,176,45,99,144,234,178,96,25,203,48,13,18,92,37,75,86,146,62,138,57,147,154,194,252,63,8,94,195,110,8,157,231,9,165,207,81,139,12,38,130,224,232,232,8,189,160,245,102,147,144,237,84,253,62,45,80,86,80,150,20,0,113,185,66,236,62,163,104,201,215,35,248,7,1,236,1,156,236,46,199,104,85,18,148,9,110,92,138,4,173,128,123,172,153,30,25,92,127,187,192,171,164,206,217,89,86,164,64,26,177,109,133,203,85,52,51,197,25,79,208,91,56,89,116,130,10,248,11,102,173,201,241,239,192,166,170,239,242,108,169,100,49,167,209,115,116,150,80,108,14,77,208,204,86,246,224,179,80,184,133,228,42,195,121,10,152,188,35,217,67,194,176,156,173,228,15,131,251,34,89,95,39,69,178,134,93,62,172,60,163,199,230,50,224,197,117,150,52,250,40,95,97,198,101,252,80,133,39,135,153,204,251,152,204,187,76,206,239,179,60,245,203,177,12,77,13,49,152,135,25,52,18,8,136,113,145,74,148,109,200,223,145,178,194,132,147,59,168,239,182,160,100,112,51,113,42,73,92,195,21,3,10,57,101,148,8,43,225,208,90,72,23,55,235,76,219,4,133,21,227,222,211,235,155,59,153,246,30,46,122,249,146,239,115,112,16,245,82,129,225,227,199,190,125,162,247,20,19,240,34,133,116,80,19,240,104,121,189,41,40,32,179,196,148,150,112,75,142,123,192,17,7,250,103,161,9,155,83,120,134,195,18,180,53,3,148,48,141,132,36,184,195,55,2,18,178,22,250,13,214,50,239,177,150,249,128,181,204,119,178,150,249,160,181,72,138,104,31,214,177,35,20,97,95,17,158,9,88,71,7,132,48,77,208,58,230,251,176,14,30,1,52,30,44,89,163,141,116,247,131,88,120,35,135,119,144,35,224,139,40,134,242,222,105,169,183,143,165,163,114,163,96,200,191,94,62,192,73,115,223,42,2,171,138,128,50,200,98,62,37,9,94,39,69,154,99,242,194,0,121,59,79,30,240,37,33,37,17,20,167,100,77,167,200,59,127,252,68,174,144,30,132,89,194,228,32,63,121,202,234,144,93,17,187,147,195,242,21,171,242,26,168,1,95,191,96,96,112,215,152,172,241,32,167,51,12,9,19,118,76,149,227,212,178,13,145,60,21,69,156,246,156,75,58,200,237,116,5,247,167,87,208,0,197,128,189,129,105,82,70,106,158,192,58,86,39,110,84,86,220,67,194,205,210,18,114,60,130,87,39,35,55,169,27,29,77,195,14,140,96,200,39,168,157,186,66,158,9,148,24,43,126,22,47,116,52,13,92,102,49,82,37,36,217,136,92,244,100,84,91,215,106,52,229,215,12,45,155,129,248,197,145,160,158,26,168,154,91,57,215,18,217,236,198,242,178,63,71,119,160,109,228,204,161,207,232,107,159,215,22,74,91,58,135,212,53,160,123,154,178,166,114,29,226,101,178,188,199,162,224,24,34,116,156,239,0,121,133,101,136,31,226,186,27,89,133,231,187,144,125,88,122,233,158,124,162,80,123,156,55,184,160,22,162,137,60,233,153,10,68,167,235,53,220,139,4,102,78,211,164,98,194,164,108,144,38,189,105,167,198,72,177,13,39,98,26,165,0,187,185,102,55,31,96,215,228,255,138,178,207,114,39,166,222,29,197,192,174,197,218,129,132,88,107,120,220,67,60,111,137,231,38,113,95,86,185,180,249,246,165,24,141,178,130,246,107,191,127,187,198,236,190,12,214,148,15,101,150,162,89,145,49,55,17,137,228,222,239,184,197,97,216,138,162,170,249,167,70,202,37,153,193,31,220,116,98,249,15,28,181,75,186,153,78,124,154,166,99,83,129,142,72,50,58,92,149,132,123,241,62,121,38,86,56,81,9,146,252,161,69,53,199,98,206,92,89,157,28,233,164,101,134,174,242,60,120,8,4,219,65,209,67,162,175,4,120,56,131,46,86,250,233,13,15,90,194,95,146,188,230,61,4,75,134,171,172,72,207,219,233,72,146,170,221,14,178,21,138,172,197,144,95,213,121,222,48,63,0,71,207,178,162,198,138,254,171,252,203,146,50,197,20,72,68,103,135,139,42,217,197,23,237,104,43,171,16,22,75,244,28,57,193,40,237,115,112,161,50,182,209,210,187,186,171,30,138,65,25,159,219,179,230,194,7,62,168,118,131,85,29,187,225,200,253,98,208,68,6,223,137,185,109,35,14,71,211,230,234,194,233,226,169,1,21,75,37,48,162,133,5,201,222,156,113,35,61,60,65,234,247,205,221,127,0,10,49,26,191,197,143,6,207,22,84,109,1,184,193,180,123,244,13,22,141,216,29,185,227,203,79,117,146,211,200,96,58,70,95,190,88,192,206,232,207,120,107,8,209,209,172,81,205,167,34,120,199,77,162,77,153,203,121,182,229,34,69,221,163,19,146,198,23,9,75,132,28,11,158,213,100,20,45,240,31,204,26,180,240,176,14,214,210,108,81,206,25,71,51,26,199,11,184,153,209,216,61,8,45,97,47,116,19,139,233,216,186,28,95,61,174,230,77,70,153,149,166,78,17,232,44,50,103,199,247,70,179,203,162,222,128,87,187,203,177,179,66,23,166,224,133,58,52,82,214,41,250,136,183,142,127,32,152,213,164,104,22,75,73,227,87,164,172,171,179,109,100,94,65,94,147,185,87,242,54,121,132,99,142,12,182,42,238,1,64,188,87,172,14,84,176,227,235,141,159,112,127,8,101,81,179,96,81,114,20,34,175,43,166,226,76,66,152,24,85,72,84,103,144,175,111,4,209,109,249,72,207,203,186,96,90,85,197,101,35,73,23,120,83,229,156,185,44,25,223,148,203,36,207,254,203,49,83,22,96,59,152,248,215,146,124,20,173,245,248,22,211,178,38,75,17,191,129,209,4,217,201,164,202,17,14,70,29,150,52,30,16,95,203,20,11,75,26,41,195,81,71,36,197,143,193,168,54,9,139,28,45,38,29,165,77,28,189,249,177,44,104,168,206,63,80,165,61,27,194,188,248,219,53,255,167,16,239,7,179,71,172,171,35,39,123,52,67,173,148,167,91,133,70,165,240,108,72,110,52,241,212,169,77,237,133,154,125,244,153,223,20,30,134,45,213,32,72,115,216,84,91,12,186,19,21,40,162,220,111,72,75,222,17,163,93,212,191,41,186,5,125,212,211,0,232,234,218,37,126,9,41,198,67,249,17,71,252,157,98,130,158,160,55,24,96,150,138,154,81,155,199,38,169,42,110,127,61,42,75,67,165,83,181,152,7,124,130,105,157,51,40,2,245,92,71,111,189,147,114,32,215,114,155,93,210,62,30,215,72,89,50,25,45,222,207,82,158,232,182,137,208,173,57,117,220,172,208,250,156,120,146,166,150,74,30,175,92,14,164,142,47,184,52,102,85,123,137,123,195,153,42,53,207,182,176,99,100,137,54,110,89,83,49,118,222,136,97,110,213,132,188,95,161,218,215,97,5,28,103,147,109,137,220,233,22,127,170,51,130,55,176,146,135,54,29,142,77,169,36,31,151,240,180,170,160,90,19,39,243,6,140,1,18,143,31,126,176,89,191,23,78,165,151,105,75,34,30,1,19,193,5,29,42,6,175,19,122,129,87,50,209,104,152,27,147,162,205,161,41,12,84,140,200,206,65,81,167,164,194,8,96,188,109,147,248,115,141,10,114,134,236,164,82,197,21,137,164,153,132,194,66,51,143,104,206,72,171,108,31,156,33,99,81,50,240,244,57,78,219,195,179,14,83,237,101,142,181,103,119,104,106,24,159,130,66,61,50,181,185,141,22,202,100,26,139,164,199,148,12,119,78,137,11,231,202,107,199,88,35,225,178,22,10,217,198,77,190,196,238,73,249,40,66,164,178,38,205,237,114,83,169,228,143,94,254,177,196,21,23,220,199,79,237,102,230,61,59,212,136,221,7,173,93,59,96,109,187,185,124,128,72,150,165,186,148,19,100,187,56,150,128,75,234,20,99,34,154,59,249,89,135,72,69,30,35,91,244,16,241,74,112,136,17,79,37,135,104,110,138,64,243,49,226,7,56,212,186,108,82,100,133,104,155,77,216,222,178,51,45,15,88,119,212,251,226,10,87,52,227,89,17,239,70,218,15,42,187,38,28,173,32,163,169,249,16,97,8,104,7,89,109,14,15,25,97,112,151,218,194,222,77,173,119,11,57,109,178,11,168,128,215,255,185,249,221,61,15,78,159,25,25,56,95,210,174,119,238,35,39,174,140,118,0,127,100,58,233,235,114,241,152,99,245,54,172,173,26,251,11,54,134,120,21,99,173,119,118,247,51,20,65,148,119,133,12,33,131,253,53,71,68,197,34,216,63,235,72,100,109,52,156,182,136,27,249,55,91,150,207,43,236,213,180,60,110,220,176,41,219,123,27,162,27,199,21,42,46,61,212,19,179,102,60,110,91,74,78,185,1,76,69,237,53,54,121,44,74,150,228,45,201,63,145,135,127,108,84,43,82,23,151,243,20,253,171,45,222,13,14,111,75,214,245,83,207,78,92,201,204,150,78,147,0,171,162,207,247,126,101,180,44,212,84,24,48,179,242,116,235,47,221,55,208,251,91,249,189,126,23,115,75,17,95,147,96,184,46,73,184,95,55,202,18,85,199,127,75,97,210,88,182,44,77,66,81,101,48,162,116,138,148,192,138,63,95,169,244,87,104,251,135,34,244,12,25,13,62,97,118,193,8,45,217,19,26,165,238,182,234,218,94,86,246,123,6,196,83,96,63,169,68,239,18,239,73,125,121,45,196,189,252,171,140,193,119,165,189,78,165,175,88,215,43,247,170,246,30,155,20,97,157,229,147,185,219,165,48,30,216,7,155,20,56,221,159,173,171,135,3,42,90,31,127,137,169,123,191,226,232,168,63,100,240,94,250,65,24,14,246,81,8,133,159,87,229,107,121,103,58,50,211,19,247,165,82,69,209,183,101,241,14,2,50,164,36,32,115,104,3,247,243,27,25,238,92,142,177,233,6,120,48,15,53,5,173,206,168,203,101,208,114,20,101,211,221,146,237,250,255,115,158,232,43,12,119,121,236,244,61,146,118,51,236,0,176,209,14,215,10,76,242,111,78,161,61,165,238,14,200,244,196,102,110,166,195,241,89,101,126,183,59,246,20,245,39,11,250,67,51,234,171,146,249,184,93,30,183,13,27,153,140,123,146,226,227,142,159,176,94,94,228,244,227,61,199,55,114,222,104,218,19,19,239,43,55,68,125,94,206,107,130,67,231,185,145,145,109,91,242,119,30,186,187,133,165,156,31,247,102,212,61,13,235,38,177,118,234,2,11,2,123,78,191,165,232,46,74,176,37,209,157,239,205,191,117,127,189,147,126,219,15,244,2,135,113,144,3,132,62,143,206,102,248,107,84,126,162,77,53,101,123,115,172,150,92,214,100,179,68,202,49,7,24,192,193,186,187,56,147,26,157,70,185,190,246,206,179,103,186,56,65,203,132,241,119,253,155,154,221,172,174,241,166,4,33,116,239,15,25,111,172,162,105,232,46,242,82,14,20,116,205,214,187,88,155,27,121,27,244,219,157,225,126,56,120,121,17,254,38,76,195,246,226,125,126,226,8,173,178,34,201,243,173,15,149,174,101,183,152,52,119,253,22,142,2,76,213,119,77,125,175,206,125,13,210,89,1,219,130,52,209,171,58,211,31,61,55,42,234,115,227,31,53,197,14,189,75,106,52,181,90,175,45,74,105,215,151,7,150,170,134,109,79,35,212,96,225,82,237,220,105,150,31,176,245,245,153,103,158,220,234,183,155,59,90,230,176,95,52,250,41,254,241,223,241,143,232,11,90,220,99,72,71,57,95,254,5,66,138,43,130,193,242,113,26,143,196,255,208,209,223,202,221,149,101,46,34,220,109,242,248,244,32,103,62,90,221,227,229,71,176,163,154,191,239,188,5,199,30,169,255,29,100,172,106,130,14,239,172,28,58,207,88,252,40,232,21,228,125,53,193,151,5,127,167,78,163,209,235,108,125,143,41,155,87,24,167,173,226,163,182,165,164,146,46,70,244,183,28,95,219,13,76,233,146,2,182,115,194,173,124,49,31,98,245,212,46,171,98,99,239,197,191,254,128,187,243,0,230,77,226,110,66,177,40,47,206,172,16,231,182,185,60,6,164,198,204,33,24,249,31,184,168,128,230,116,55,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateMergedImportEntitiesInfoMessageTemplateLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateMergedImportEntitiesInfoMessageTemplateLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("ab238f52-4eb2-4917-81b8-f24e157bffb9"),
				Name = "MergedImportEntitiesInfoMessageTemplate",
				CreatedInPackageId = new Guid("1a247561-b87d-48fb-9e13-b6a8baa960d3"),
				CreatedInSchemaUId = new Guid("1bd89e09-c2b8-41e4-8c4f-fa8ab4fd104f"),
				ModifiedInSchemaUId = new Guid("1bd89e09-c2b8-41e4-8c4f-fa8ab4fd104f")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("1bd89e09-c2b8-41e4-8c4f-fa8ab4fd104f"));
		}

		#endregion

	}

	#endregion

}

