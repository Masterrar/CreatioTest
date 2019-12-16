﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: BulkEmailTemplateServiceSchema

	/// <exclude/>
	public class BulkEmailTemplateServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public BulkEmailTemplateServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public BulkEmailTemplateServiceSchema(BulkEmailTemplateServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("87b7cde0-7e69-40e0-b8d0-6dd5413ce751");
			Name = "BulkEmailTemplateService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("4bf8755b-1de0-4c5d-b70c-66ed314a3549");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,237,28,93,111,219,56,242,57,11,236,127,96,221,3,78,1,92,165,183,216,3,22,77,226,67,154,52,123,190,75,218,110,156,94,31,130,96,79,145,152,88,23,217,114,73,57,173,183,200,127,191,225,167,72,138,146,101,197,78,27,96,247,97,107,81,195,225,112,190,103,72,101,26,77,48,157,69,49,70,231,152,144,136,230,215,69,120,152,79,175,211,155,57,137,138,52,159,254,248,195,215,31,127,216,154,211,116,122,131,70,11,90,224,201,174,243,12,240,89,134,99,6,76,195,95,241,20,147,52,174,192,156,164,211,79,149,193,179,249,180,72,39,56,28,193,148,40,75,255,224,11,86,160,224,237,93,26,227,211,60,193,89,227,203,240,35,190,106,6,56,0,42,239,252,171,156,227,47,69,57,104,50,131,224,240,56,138,139,156,164,152,250,33,38,19,19,161,61,183,22,231,27,216,123,209,136,50,252,23,245,227,133,125,150,171,194,251,231,4,223,192,158,208,97,22,81,250,10,189,158,103,183,111,38,81,154,157,227,201,44,139,10,44,121,192,97,119,118,118,208,30,157,79,38,17,89,12,196,243,115,227,63,164,255,143,220,65,253,111,40,166,237,237,24,104,46,228,26,160,59,5,1,110,93,178,177,3,58,123,139,11,160,116,6,60,191,74,179,180,88,156,225,79,243,148,224,9,158,22,52,48,31,152,128,208,62,90,50,133,65,133,114,32,217,102,139,204,230,87,89,26,163,152,109,189,118,231,8,152,18,209,146,15,91,95,57,47,74,198,129,234,22,17,224,127,133,222,19,166,33,130,87,91,51,241,128,98,246,30,165,211,2,253,94,72,204,175,23,5,166,39,233,36,45,128,234,191,255,244,243,79,191,252,242,114,87,98,197,211,68,32,182,87,57,78,113,150,212,45,241,129,98,2,100,76,133,33,161,223,231,214,243,18,204,167,184,24,231,181,168,175,242,60,67,255,1,3,75,224,73,113,230,117,158,44,78,240,244,166,24,7,180,32,76,191,174,96,100,27,49,107,223,218,186,139,8,127,230,187,60,204,193,78,97,151,111,166,113,158,0,100,120,48,58,28,14,193,212,11,246,154,191,13,248,228,93,62,151,224,98,78,166,232,89,224,32,24,236,251,184,39,38,221,219,20,75,138,96,133,147,248,143,17,127,0,250,231,88,145,154,197,127,188,5,199,101,82,155,229,49,119,33,87,25,22,19,24,0,16,45,102,132,199,57,153,68,69,208,59,113,193,104,248,245,229,125,200,177,247,250,26,241,110,61,94,192,57,197,159,81,5,81,192,167,108,217,114,12,63,230,228,150,251,87,208,90,154,207,73,12,208,57,137,110,112,31,245,180,182,142,102,160,231,82,57,25,17,190,173,24,36,221,49,98,129,140,10,156,216,134,0,76,175,81,32,1,129,224,121,150,41,102,109,213,79,7,126,31,206,51,144,30,22,220,230,206,60,202,28,202,195,35,124,45,193,250,232,58,202,168,162,237,222,20,255,157,38,197,145,45,247,123,11,38,91,203,82,197,112,240,235,60,77,144,210,146,97,98,74,24,91,224,163,223,164,32,196,196,81,60,134,247,191,205,49,89,4,142,8,76,128,211,104,10,59,32,125,193,137,158,69,65,79,110,195,93,39,4,163,98,110,142,35,135,88,55,159,76,195,33,61,200,62,71,11,58,194,44,242,1,37,5,81,140,175,76,63,72,18,49,43,232,141,230,87,255,3,248,218,149,12,80,53,44,130,113,155,25,204,162,123,134,154,88,176,64,98,101,46,19,129,224,186,205,177,190,41,0,203,166,45,20,62,225,158,164,180,216,19,38,55,96,34,254,48,165,243,43,26,147,244,10,159,70,49,201,41,87,44,26,152,114,141,133,46,81,32,177,84,64,250,49,45,198,195,36,48,246,51,225,8,56,28,55,64,99,41,19,12,211,79,15,209,12,100,43,133,160,90,179,159,126,90,81,27,24,69,83,48,95,1,201,164,0,40,12,161,49,211,54,133,54,139,8,196,185,183,13,51,222,115,136,208,156,200,32,142,211,172,192,132,50,200,128,61,31,18,12,228,139,81,198,75,152,6,51,24,72,32,6,121,140,37,41,164,24,231,139,25,164,35,159,230,81,6,187,31,38,61,105,29,167,17,185,197,5,176,151,71,71,26,122,248,98,136,247,3,201,64,91,36,65,215,144,224,68,241,152,121,32,45,223,225,244,58,135,16,170,197,173,253,17,163,118,4,158,94,186,35,38,25,169,4,32,127,99,114,248,111,172,66,140,16,52,151,94,153,124,74,86,105,173,46,223,56,114,175,34,97,83,157,57,192,80,66,139,119,4,156,93,4,52,40,13,227,126,85,77,114,28,235,22,164,9,192,47,37,122,233,15,181,10,232,69,24,137,140,231,82,164,220,36,180,38,151,202,18,26,110,223,209,141,118,168,92,93,178,16,42,107,226,10,243,151,222,197,243,175,37,248,125,248,149,145,113,255,252,178,231,115,237,106,170,233,0,90,100,38,121,1,156,197,137,120,239,166,161,124,224,140,227,255,47,69,17,203,211,33,13,224,169,121,233,32,62,131,30,163,97,66,67,141,97,199,69,177,39,104,164,131,189,29,245,75,248,39,185,58,186,75,73,1,154,142,142,82,46,102,152,187,199,98,78,31,25,94,203,245,65,126,103,197,179,120,171,86,10,161,150,144,115,153,96,202,39,234,215,64,201,79,133,115,53,126,242,188,183,129,153,144,168,191,176,178,247,106,34,111,254,178,82,254,38,6,207,152,35,225,10,189,223,187,82,25,12,120,141,65,117,25,249,196,33,194,189,29,62,211,143,200,10,44,141,200,212,191,124,70,249,174,25,61,145,21,131,97,37,212,92,163,142,79,246,226,6,103,117,161,84,38,113,189,102,18,88,50,44,151,84,72,171,19,148,202,54,209,84,91,228,64,154,54,3,79,141,67,91,245,47,222,205,176,80,79,179,54,219,186,128,34,114,56,189,203,111,113,32,116,10,52,186,247,254,221,232,28,18,208,15,36,53,242,134,222,40,186,195,149,69,1,140,37,28,163,98,145,49,32,192,118,138,41,133,16,170,71,195,143,36,154,129,107,18,225,132,21,109,152,22,34,15,183,38,136,33,94,236,246,145,218,68,51,28,175,252,84,233,183,140,31,200,75,191,200,52,13,5,22,100,242,81,71,27,149,111,64,62,53,210,47,153,128,245,67,204,221,130,233,56,192,190,193,204,101,102,178,148,100,25,81,70,243,56,134,205,195,44,158,103,171,192,44,248,33,242,37,167,64,234,137,190,192,27,66,114,210,219,22,190,187,204,46,98,78,56,61,207,25,75,96,62,227,37,164,243,84,246,95,240,158,225,21,197,78,250,40,231,41,235,96,16,248,118,223,144,110,214,36,248,14,111,183,203,106,197,70,240,172,82,181,16,157,150,50,21,67,251,50,232,202,2,111,72,223,2,248,59,242,102,50,131,85,68,45,251,15,155,168,198,96,41,211,103,244,138,11,114,183,186,168,240,244,101,69,105,47,40,5,46,105,90,105,97,55,211,151,56,94,73,37,50,242,142,103,13,69,188,201,155,237,50,37,17,106,23,58,138,180,107,191,45,21,202,174,150,61,234,117,158,231,39,17,185,193,78,229,36,53,115,107,203,215,31,217,65,127,123,249,211,207,219,229,162,60,234,137,181,171,169,146,54,73,32,103,121,190,206,88,59,228,205,155,24,150,100,201,75,96,184,100,197,75,153,13,123,171,157,109,91,214,217,140,153,163,168,211,220,162,169,89,142,78,113,39,36,166,119,19,30,227,34,30,31,147,124,114,244,58,48,220,142,33,171,18,22,210,97,86,100,27,134,166,243,79,27,202,0,9,120,234,110,122,180,109,155,185,245,19,181,23,146,59,232,187,140,80,152,150,163,144,74,220,119,204,166,61,2,110,134,125,203,212,151,79,230,197,80,223,118,111,23,98,244,114,249,236,17,228,90,152,248,113,24,239,90,99,18,186,87,131,74,188,188,52,149,196,192,7,128,129,104,169,52,152,112,89,93,122,44,216,103,179,74,188,128,61,145,104,142,193,119,233,110,129,70,227,40,2,91,203,86,132,26,120,225,144,45,161,213,64,106,47,106,235,199,114,223,96,85,32,198,251,251,142,41,176,157,83,61,71,206,179,5,183,114,94,188,129,116,214,78,13,87,221,208,218,115,66,55,186,107,187,255,78,146,66,139,56,157,86,249,169,14,124,73,95,109,238,230,197,28,60,94,34,84,103,80,15,200,56,118,189,152,165,81,175,156,66,249,177,173,35,164,118,241,1,160,42,47,38,66,153,139,49,40,143,52,3,20,101,25,252,158,129,174,68,20,229,215,130,170,78,117,175,72,86,210,132,117,100,174,83,72,73,106,109,87,235,161,200,169,89,130,87,68,233,148,21,12,20,102,107,122,54,97,173,71,241,153,196,222,222,72,165,121,110,218,86,75,210,76,67,45,71,43,165,154,117,74,229,150,82,48,43,167,105,145,147,69,93,177,85,66,248,83,65,134,54,81,171,243,131,99,22,117,27,22,10,109,114,171,41,152,112,34,82,217,246,93,228,161,232,27,7,148,160,253,1,39,89,190,86,38,175,142,178,72,120,24,205,120,135,94,117,104,233,173,24,103,191,228,224,48,17,67,195,68,216,204,118,120,158,31,16,18,45,2,187,235,196,214,241,112,94,46,121,86,82,171,8,55,138,201,46,6,87,26,8,183,55,75,225,191,3,3,108,34,111,19,246,8,217,96,169,51,195,228,169,88,165,75,246,99,219,230,170,202,187,196,106,43,219,49,119,162,236,18,54,232,183,75,97,107,105,34,243,84,195,210,58,218,74,204,14,202,41,252,198,16,243,39,87,152,48,85,36,56,78,103,41,187,253,128,174,115,72,47,216,193,138,202,158,149,138,182,181,27,82,234,219,128,147,42,22,224,131,127,181,108,180,189,17,241,174,188,32,151,214,209,171,200,220,104,96,59,83,11,243,251,6,242,24,107,69,163,66,237,12,74,218,222,218,67,157,189,5,110,92,23,151,168,148,218,211,178,46,189,190,222,150,156,43,118,103,108,75,245,105,164,197,125,169,51,56,97,113,95,216,81,160,110,57,217,60,227,175,121,26,41,223,175,193,44,41,20,206,194,42,217,134,101,173,54,134,172,149,100,233,244,22,212,156,228,19,109,146,237,77,145,43,90,111,112,62,198,136,40,245,75,101,47,139,25,210,30,197,24,197,4,95,239,219,45,248,127,170,149,165,174,246,118,6,245,214,58,244,35,180,206,173,156,238,115,47,220,25,108,244,12,65,111,128,69,189,205,26,92,211,62,81,13,81,65,35,183,149,172,156,2,81,96,20,118,215,180,168,202,194,10,176,82,163,181,77,76,219,229,247,248,196,157,67,110,71,123,62,98,20,252,64,94,60,218,146,43,67,241,52,103,51,15,200,205,156,221,153,11,122,246,85,50,38,27,219,246,203,138,77,27,111,29,103,228,222,195,215,101,152,236,43,134,132,37,156,170,215,80,28,21,236,26,192,155,47,49,230,137,43,210,119,182,32,121,77,1,246,230,67,193,46,249,165,152,134,39,249,77,200,207,45,100,247,89,110,171,119,81,119,90,82,71,229,229,43,196,241,160,207,227,20,252,62,88,47,75,240,198,166,210,233,99,240,98,76,242,207,254,234,146,139,107,169,175,56,147,233,45,134,8,40,109,132,153,218,188,188,25,33,207,203,245,125,43,14,194,175,71,213,29,100,175,37,46,86,174,222,124,63,205,153,10,105,102,48,172,188,212,231,239,142,201,72,182,238,55,222,51,210,170,173,3,91,253,226,42,200,156,42,196,98,5,39,124,168,243,180,77,43,183,111,87,142,102,223,224,130,221,207,209,23,50,154,20,251,193,241,78,70,107,52,198,81,194,50,189,23,34,236,177,96,214,23,63,57,92,31,81,209,180,233,163,25,193,2,248,207,144,184,60,36,10,174,126,71,241,80,166,94,146,176,192,71,109,77,68,236,22,218,170,41,228,198,34,155,218,83,115,52,19,64,117,41,169,120,205,27,56,218,113,168,174,142,104,203,124,9,141,103,149,173,190,87,54,193,1,244,147,122,93,30,55,241,247,229,163,13,160,206,71,21,4,127,214,32,186,211,10,175,197,111,85,160,126,139,184,108,235,145,63,54,59,190,165,77,128,110,153,103,173,86,125,67,25,81,205,243,87,247,119,10,86,92,155,54,144,109,196,17,30,230,179,69,141,101,62,5,55,232,35,255,219,186,65,139,34,199,13,54,48,251,73,185,193,166,61,42,15,56,226,234,235,117,142,198,160,117,54,243,167,95,105,232,128,43,79,2,246,86,205,171,26,47,181,122,125,131,97,191,134,249,154,109,151,13,59,131,245,251,2,187,103,100,202,119,227,30,193,203,183,178,42,169,179,149,122,118,175,226,14,58,53,235,124,157,135,134,93,24,181,144,188,39,42,1,196,17,143,209,182,107,72,143,188,141,186,192,230,201,246,23,13,229,156,60,137,147,53,113,161,190,110,241,35,235,181,151,6,119,31,71,46,70,123,9,187,4,180,10,251,199,40,226,218,57,44,2,163,43,122,44,255,77,113,49,234,12,58,31,136,54,228,242,117,223,136,178,180,23,88,199,187,250,71,231,239,80,145,243,42,209,165,55,84,179,173,111,67,143,162,34,50,93,130,245,205,102,67,68,253,145,127,168,89,227,101,129,181,224,74,9,162,88,158,152,148,135,23,204,137,49,107,88,154,120,113,202,78,49,59,186,176,124,1,59,211,50,52,14,125,101,165,246,46,91,106,23,53,121,254,37,52,181,205,7,155,200,170,4,101,151,184,167,167,1,141,196,184,159,234,190,39,57,68,25,102,142,45,190,129,168,200,195,136,187,198,121,241,55,82,14,149,15,68,204,71,174,70,132,237,75,46,46,145,114,126,30,98,58,56,136,250,168,182,130,118,0,33,107,80,142,38,82,158,164,110,172,75,28,34,140,61,190,181,54,18,179,94,137,60,146,129,44,39,70,38,20,38,215,218,147,98,114,10,57,185,202,122,244,195,222,108,7,213,88,155,169,214,81,178,94,189,240,144,218,44,142,64,118,212,122,42,173,218,126,68,103,106,163,111,43,21,72,23,148,250,179,91,20,142,131,242,221,255,88,81,90,54,89,232,149,165,167,155,146,216,36,162,183,171,89,15,251,163,27,102,95,181,115,180,85,36,164,73,7,159,174,111,8,181,208,137,14,223,106,190,199,4,132,60,1,79,55,69,233,132,45,149,242,203,105,119,32,10,134,137,119,19,141,178,188,218,131,134,98,156,25,114,29,12,101,197,191,127,219,149,6,131,84,59,129,150,119,32,149,34,78,248,31,209,169,237,33,168,1,209,180,228,87,166,65,139,25,239,203,173,24,68,88,223,231,10,94,211,34,42,152,204,21,11,114,222,80,0,41,58,85,183,167,7,111,82,173,42,56,163,165,227,104,187,172,240,204,110,188,137,160,210,152,183,250,242,22,100,165,69,111,119,232,61,176,102,179,222,62,49,176,128,171,135,7,101,99,223,198,42,251,207,22,70,126,79,198,135,79,93,11,109,248,216,184,141,83,179,157,197,58,93,90,7,87,182,41,207,69,185,188,184,89,172,230,51,228,87,160,134,214,116,114,91,114,253,14,165,162,69,128,208,197,206,142,83,136,71,158,114,116,35,67,42,238,3,73,88,118,158,220,76,68,105,235,223,133,11,55,116,182,198,129,91,7,34,79,219,125,155,91,9,220,157,47,115,221,86,254,252,189,56,238,102,95,188,22,23,187,236,35,241,90,183,91,253,32,204,255,185,152,252,89,243,85,84,7,63,188,156,226,7,249,102,223,30,86,115,5,252,47,161,169,15,41,219,122,35,115,201,78,158,71,125,156,185,210,130,230,199,123,93,22,117,191,187,90,117,241,245,172,46,191,78,251,54,139,243,15,216,214,83,195,121,63,250,107,147,247,56,229,218,76,235,187,62,136,232,152,238,84,137,89,111,197,166,73,142,173,191,112,243,136,202,80,79,18,251,11,13,27,209,140,21,233,120,72,78,212,194,62,59,232,105,237,229,198,54,186,202,67,61,215,48,150,158,39,88,94,95,149,185,0,27,243,221,73,236,16,39,26,168,124,144,18,203,139,155,74,62,43,246,233,132,96,46,46,21,154,181,118,127,248,171,86,13,153,246,60,104,106,88,248,59,21,205,42,89,87,168,52,116,102,234,90,50,141,205,28,235,115,141,245,112,217,250,142,203,86,250,102,166,251,38,117,224,191,110,48,170,219,28,222,14,35,232,150,254,120,102,77,251,110,186,4,219,182,46,103,150,93,185,36,111,223,82,121,240,169,94,133,180,39,121,118,211,242,216,66,51,113,53,10,52,147,216,107,214,134,46,133,209,77,91,238,255,15,91,37,239,205,222,91,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateCommonErrorLocalizableString());
			LocalizableStrings.Add(CreateTooLargeEmailTemplateLocalizableString());
			LocalizableStrings.Add(CreateTemplateSavedSuccessFullyLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateCommonErrorLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("2dfe3dab-c5ec-4a61-a0d0-c5b8b2cfce34"),
				Name = "CommonError",
				CreatedInPackageId = new Guid("4bf8755b-1de0-4c5d-b70c-66ed314a3549"),
				CreatedInSchemaUId = new Guid("87b7cde0-7e69-40e0-b8d0-6dd5413ce751"),
				ModifiedInSchemaUId = new Guid("87b7cde0-7e69-40e0-b8d0-6dd5413ce751")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateTooLargeEmailTemplateLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("36dbe531-89f8-46fb-81f6-dfabaee006f6"),
				Name = "TooLargeEmailTemplate",
				CreatedInPackageId = new Guid("4bf8755b-1de0-4c5d-b70c-66ed314a3549"),
				CreatedInSchemaUId = new Guid("87b7cde0-7e69-40e0-b8d0-6dd5413ce751"),
				ModifiedInSchemaUId = new Guid("87b7cde0-7e69-40e0-b8d0-6dd5413ce751")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateTemplateSavedSuccessFullyLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("b6d6976d-e463-4b21-a037-e00156e9c177"),
				Name = "TemplateSavedSuccessFully",
				CreatedInPackageId = new Guid("4bf8755b-1de0-4c5d-b70c-66ed314a3549"),
				CreatedInSchemaUId = new Guid("87b7cde0-7e69-40e0-b8d0-6dd5413ce751"),
				ModifiedInSchemaUId = new Guid("87b7cde0-7e69-40e0-b8d0-6dd5413ce751")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("87b7cde0-7e69-40e0-b8d0-6dd5413ce751"));
		}

		#endregion

	}

	#endregion

}
