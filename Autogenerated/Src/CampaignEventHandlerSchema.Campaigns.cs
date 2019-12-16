﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CampaignEventHandlerSchema

	/// <exclude/>
	public class CampaignEventHandlerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CampaignEventHandlerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CampaignEventHandlerSchema(CampaignEventHandlerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("3abfbe86-86e7-46aa-b930-39ab26ca49a7");
			Name = "CampaignEventHandler";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("bac310da-8f6a-4932-87be-74eb3d9d7067");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,237,92,235,111,219,70,18,255,172,2,253,31,54,58,32,39,1,58,38,253,26,199,14,108,199,78,85,56,113,206,138,91,224,46,135,3,77,174,100,94,41,82,93,146,182,213,32,255,123,103,246,189,203,37,69,199,113,31,192,125,105,172,221,217,217,121,252,118,102,246,193,22,241,154,86,155,56,161,228,3,101,44,174,202,101,29,29,151,197,50,91,53,44,174,179,178,248,246,155,79,223,126,51,106,170,172,88,145,197,182,170,233,122,207,251,13,244,121,78,19,36,174,162,55,180,160,44,75,90,52,103,89,241,75,171,241,3,189,171,77,163,45,192,122,93,22,225,30,70,163,195,186,102,217,85,83,211,170,147,228,56,94,111,226,108,85,68,39,55,180,168,191,143,139,52,167,172,147,250,245,81,103,215,73,81,103,117,54,96,166,78,130,211,56,169,75,54,132,69,180,168,99,86,47,224,175,56,223,77,60,47,106,202,150,224,57,100,12,212,127,99,116,5,46,32,199,121,92,85,47,136,162,179,13,192,233,158,61,123,70,94,86,205,122,29,179,237,129,252,13,30,175,227,172,168,200,154,214,215,101,90,145,101,201,200,26,90,176,21,133,72,36,55,2,140,8,240,135,63,105,74,170,228,154,174,99,146,54,204,161,161,56,101,21,169,185,158,89,147,109,154,171,60,75,72,69,227,28,198,39,40,106,80,82,18,86,224,40,174,232,140,204,207,11,213,121,68,65,82,186,136,111,220,230,195,37,216,134,183,194,156,35,171,227,199,56,207,210,184,118,169,185,217,157,150,211,12,92,144,253,234,147,149,27,167,225,184,220,108,129,255,39,110,86,99,127,88,6,117,12,6,120,65,222,179,236,6,38,19,253,27,241,131,36,216,79,170,154,219,236,36,167,107,163,222,59,88,140,100,159,140,67,170,143,247,58,153,44,184,27,252,193,61,3,20,201,123,208,59,75,178,13,72,251,33,190,202,169,207,194,234,31,239,73,45,105,145,10,69,93,173,223,179,114,67,25,174,20,87,219,171,178,204,201,188,178,76,93,55,213,69,83,144,253,3,45,134,144,63,18,125,243,148,236,239,19,99,98,16,187,138,96,128,203,97,158,14,150,7,220,192,65,39,250,125,244,243,134,55,180,174,8,32,190,194,127,53,140,243,114,181,162,44,34,115,238,79,136,144,229,18,134,82,176,37,163,203,253,241,92,123,233,142,38,13,70,191,51,62,96,252,236,32,210,51,217,216,215,54,233,26,73,254,155,132,59,132,39,197,210,233,28,220,213,142,225,123,52,90,209,26,77,222,53,3,167,25,189,122,69,38,93,20,128,11,30,89,68,56,219,66,160,175,95,118,201,114,48,17,252,70,5,189,21,235,129,53,56,234,144,173,26,132,251,100,220,84,148,65,71,33,210,198,120,70,46,157,134,233,116,202,117,30,85,253,98,131,80,55,113,222,80,78,252,121,168,135,235,107,106,188,140,49,44,109,242,33,142,254,161,188,122,157,65,178,172,97,200,125,220,252,33,91,211,133,154,198,232,226,52,7,93,236,14,12,183,134,221,235,210,56,126,117,187,246,9,247,81,168,111,226,251,196,118,73,39,187,191,128,63,156,113,198,102,78,115,208,31,238,192,96,43,14,11,187,196,29,236,184,196,237,114,93,226,244,245,186,164,107,170,161,62,185,160,27,70,43,76,221,198,27,27,147,1,42,82,109,139,228,154,149,5,36,70,70,234,146,255,118,41,98,204,187,102,244,146,197,43,92,239,213,223,9,85,11,119,168,147,78,229,216,133,61,169,214,48,212,27,116,89,144,77,111,103,216,123,33,210,64,208,12,114,116,29,26,34,153,116,121,178,131,223,48,135,190,166,203,172,160,224,205,134,49,224,65,106,88,170,17,184,185,110,24,148,122,156,7,201,150,36,171,201,109,92,225,82,36,87,188,156,154,241,42,239,178,78,222,149,183,72,80,148,245,14,175,189,134,255,96,32,0,193,197,92,248,195,246,135,38,56,54,253,190,165,173,30,168,0,82,186,140,155,188,158,168,145,83,153,82,94,105,94,145,144,80,182,191,104,207,109,172,105,179,110,27,175,133,189,127,54,180,161,111,227,34,118,146,178,221,186,215,99,246,142,176,21,98,62,38,221,81,203,3,178,35,83,176,49,12,92,135,196,193,170,211,227,98,212,238,26,24,115,60,110,45,35,119,21,106,111,197,142,163,163,88,190,41,179,148,156,102,121,238,149,127,178,102,156,76,165,214,55,49,230,18,220,133,130,28,108,43,213,89,240,22,95,1,9,24,220,182,54,235,98,50,246,88,167,227,22,197,188,128,114,114,5,193,177,82,125,209,41,43,215,102,168,110,254,9,2,46,181,218,103,100,140,12,163,121,117,242,75,19,231,19,193,49,130,194,26,74,109,136,149,19,175,6,230,219,205,237,60,157,78,97,151,37,229,87,246,214,218,69,139,13,77,178,229,246,93,121,86,38,63,127,15,187,180,106,50,109,83,137,90,137,94,208,56,133,137,82,134,238,18,214,26,117,86,222,36,101,88,217,9,49,127,68,31,190,124,211,100,233,65,200,74,123,65,94,243,202,88,43,200,15,119,4,7,174,77,5,167,207,83,133,151,209,40,20,92,94,97,213,160,74,141,20,119,99,216,51,65,249,116,202,1,203,73,29,205,40,152,3,2,9,66,162,201,243,61,3,23,201,64,24,249,94,136,105,9,209,134,140,67,242,182,76,169,193,213,14,236,244,227,197,82,180,13,17,71,163,62,148,184,132,61,64,225,134,106,171,210,7,148,160,230,18,43,144,76,38,65,118,173,29,159,248,89,172,132,18,25,77,209,151,130,90,121,120,52,210,158,109,11,163,220,239,11,36,188,37,197,249,108,227,14,184,97,98,148,112,9,229,7,30,140,48,19,187,144,255,41,171,175,197,186,213,225,72,252,20,221,132,218,63,246,197,204,46,192,34,155,94,198,80,84,72,101,146,163,237,229,60,13,135,10,241,3,186,167,6,217,205,6,143,56,36,162,47,249,15,15,209,51,71,168,8,247,253,26,193,11,90,79,156,94,16,4,98,51,38,38,44,42,243,120,43,236,140,131,38,211,25,217,21,210,142,227,13,215,145,251,101,234,76,51,118,73,65,139,241,110,126,168,235,189,150,76,111,136,21,230,17,182,19,118,139,208,159,98,185,160,253,46,202,91,181,126,116,149,38,9,229,186,153,76,67,96,17,140,201,49,163,240,143,18,65,58,195,206,90,67,156,213,142,21,220,122,176,28,248,210,56,47,66,102,243,202,164,105,112,232,209,54,108,115,15,159,178,106,195,214,136,159,21,38,245,31,239,5,185,94,27,51,182,149,58,248,138,61,190,142,139,21,125,71,239,234,139,166,224,41,67,87,163,133,105,12,250,36,236,61,71,78,110,78,100,126,154,49,206,52,100,78,123,158,123,96,200,18,95,164,221,15,165,21,204,96,227,101,52,209,81,117,151,46,22,55,169,143,23,121,245,12,126,198,119,4,183,193,180,75,123,87,54,7,135,39,5,111,12,218,12,178,53,64,95,105,56,126,144,225,206,197,33,111,120,229,13,181,76,224,20,178,211,38,86,121,19,208,173,102,141,103,8,46,94,151,41,122,151,242,239,101,66,192,30,228,207,135,89,240,184,92,111,114,16,109,56,182,250,237,184,140,243,106,56,162,122,205,184,115,9,63,192,150,110,46,104,91,201,41,97,181,73,30,18,144,90,213,122,64,163,214,132,125,113,117,0,52,54,80,174,61,12,30,138,75,47,58,6,192,22,234,38,202,106,197,101,94,211,117,53,153,159,20,205,154,50,188,230,120,233,230,34,121,7,115,96,54,17,56,96,70,58,54,22,120,66,18,39,215,100,130,42,102,64,74,178,194,29,170,11,84,204,92,66,22,127,71,129,183,119,165,113,19,14,27,187,165,81,216,103,56,159,93,1,41,240,198,97,208,114,114,167,0,3,8,227,173,235,184,163,16,235,71,74,107,94,125,254,47,76,248,97,187,233,22,195,162,137,16,48,140,195,197,48,116,221,42,114,121,200,185,2,58,247,118,46,189,203,170,26,166,116,60,20,244,101,144,114,52,164,60,19,110,236,45,93,190,154,219,6,21,93,109,184,12,181,242,219,152,253,124,88,189,166,78,180,110,27,155,239,249,194,22,195,189,158,211,17,29,22,176,67,154,218,91,203,123,21,191,161,69,162,36,220,149,100,61,123,21,45,83,85,174,172,237,178,116,120,93,26,142,83,221,166,62,76,211,115,22,66,181,50,213,25,8,38,45,93,217,160,134,200,136,71,44,94,101,125,154,151,183,138,32,146,231,25,119,184,165,191,227,72,128,181,135,252,38,214,126,49,135,223,226,201,133,244,132,153,80,145,161,51,253,131,158,34,171,179,56,151,251,218,39,226,120,69,152,91,122,216,146,91,25,215,86,48,40,189,195,213,209,197,56,126,135,74,35,71,159,142,153,163,31,202,172,152,180,204,57,35,130,239,140,108,241,223,237,140,76,240,239,41,111,108,77,212,94,9,56,181,128,100,207,212,39,119,9,221,212,19,35,166,226,167,156,113,105,47,139,182,51,220,176,85,81,12,90,125,32,16,208,231,138,153,57,35,245,230,99,34,140,104,22,230,200,136,16,1,54,47,48,107,247,58,63,228,166,145,61,43,159,1,15,121,42,202,255,122,250,20,154,156,248,134,248,169,168,119,86,160,89,181,93,238,158,224,140,6,196,127,12,133,80,168,104,211,246,24,204,13,25,218,110,210,36,190,221,164,36,61,1,211,128,66,17,135,86,187,35,160,29,51,58,96,38,10,11,208,164,5,226,78,128,13,55,147,98,30,60,226,237,3,151,24,216,97,164,80,93,230,76,56,243,221,162,143,9,58,107,61,97,175,119,244,86,159,33,157,150,204,141,159,193,44,223,163,147,94,9,34,15,243,226,53,157,155,67,170,54,122,46,249,123,20,61,68,157,174,12,27,211,153,24,240,1,211,113,185,201,124,60,41,249,250,84,239,54,120,143,226,95,108,254,214,57,158,150,241,254,167,90,127,236,153,160,100,178,123,143,97,221,200,42,102,214,115,169,234,220,236,148,245,92,122,4,127,88,57,47,150,165,190,155,144,33,167,239,142,56,2,231,38,212,106,105,25,212,85,202,202,220,98,150,104,209,36,9,222,202,64,248,85,45,134,91,106,75,127,92,54,69,77,14,200,115,189,20,206,202,213,33,159,198,221,179,33,177,126,146,8,52,88,221,119,232,59,35,98,11,61,100,106,21,39,197,86,212,142,133,168,206,19,87,31,167,162,20,47,220,142,154,44,79,245,173,230,194,110,11,39,81,202,88,201,48,44,72,214,39,248,219,112,30,57,108,163,195,205,134,22,233,132,15,82,236,194,36,39,197,77,6,74,162,47,35,88,168,103,89,65,189,212,5,70,227,147,61,192,174,238,204,214,222,106,208,78,202,54,190,57,109,17,91,239,123,159,84,7,150,130,126,89,232,159,119,117,30,76,116,91,194,98,171,255,196,10,203,28,97,184,65,192,218,214,126,121,48,24,193,198,37,181,36,54,117,201,78,142,189,26,248,198,126,244,43,9,171,30,199,219,50,59,43,224,4,131,129,32,214,136,51,190,179,86,53,23,243,95,116,39,47,74,102,247,230,116,8,198,254,170,254,151,226,191,97,101,179,57,218,182,237,16,126,21,176,243,65,128,119,197,203,248,63,214,53,111,192,163,88,250,75,194,29,47,2,148,108,238,53,190,123,157,234,176,238,204,169,23,116,93,222,56,1,9,29,206,95,150,56,0,76,60,232,221,31,205,123,78,102,182,223,174,68,199,57,141,217,209,214,45,154,220,243,189,222,162,64,228,52,123,122,45,251,128,154,65,8,214,107,136,61,171,248,27,160,101,72,78,147,205,249,33,103,204,255,158,167,51,235,173,133,115,105,35,31,79,204,32,67,214,175,72,188,230,229,193,190,41,15,106,182,181,147,112,94,174,120,117,227,62,42,58,147,173,42,167,154,197,217,46,142,213,26,156,73,90,33,45,208,105,81,85,135,146,69,8,165,154,231,149,42,118,246,9,158,3,201,148,27,122,134,192,245,83,199,23,102,15,44,132,53,183,97,210,12,206,48,149,201,9,205,43,218,30,170,174,116,96,152,119,245,224,150,0,250,20,213,125,220,28,25,47,73,150,106,133,193,2,168,177,114,17,251,60,52,12,189,211,162,91,230,70,38,188,184,128,210,113,29,227,229,136,30,112,13,129,164,76,146,134,209,148,220,94,83,241,218,29,191,13,16,6,22,95,128,40,212,147,79,207,63,143,149,105,71,244,110,199,62,161,187,226,208,197,142,7,59,249,93,2,47,168,240,156,243,143,199,149,13,32,126,203,164,58,78,148,140,120,192,163,254,118,225,245,215,242,231,3,220,169,190,166,81,195,17,225,255,42,11,19,172,3,199,134,138,230,124,185,228,79,8,189,133,39,145,176,6,203,67,52,22,177,253,44,249,85,148,180,60,253,76,218,223,204,224,43,187,34,41,25,131,84,231,203,34,230,233,122,173,6,73,78,42,33,119,100,19,57,243,80,213,95,139,103,170,122,227,150,49,250,158,178,172,76,251,108,208,57,8,205,241,252,235,217,162,115,158,175,110,142,5,108,118,68,70,146,143,152,196,48,109,4,165,74,181,194,24,202,127,68,10,196,159,62,125,28,155,27,166,143,227,23,31,199,128,207,143,176,51,248,56,198,143,120,184,48,188,217,158,225,227,248,179,198,112,63,124,223,86,43,188,122,44,104,126,89,103,57,255,154,47,122,95,86,181,146,209,223,195,152,207,169,102,40,176,147,69,119,191,98,221,245,173,17,108,12,115,144,192,249,210,78,175,75,241,254,218,253,24,98,29,147,42,190,161,105,199,59,225,127,159,51,44,233,254,241,221,243,231,211,255,112,191,136,135,195,220,45,231,214,7,114,147,64,80,237,123,89,59,36,54,125,41,66,109,185,52,227,22,40,3,17,79,206,52,35,187,163,214,168,134,82,235,182,141,219,251,123,197,251,170,225,225,78,209,159,39,134,124,210,255,192,80,234,214,125,103,100,149,56,161,207,238,158,62,37,79,252,179,124,171,114,52,5,16,230,219,255,149,87,226,91,96,43,145,58,223,251,224,206,192,126,56,225,5,186,153,253,220,95,31,148,180,223,99,233,121,34,151,80,50,115,62,103,137,46,168,170,193,160,189,53,161,102,229,29,179,116,6,168,199,133,185,246,244,159,10,229,12,140,231,97,252,70,135,253,254,239,17,36,130,85,250,11,1,216,19,88,145,170,67,102,13,209,1,41,212,163,108,215,25,143,235,61,45,250,159,201,121,193,16,5,26,87,184,221,232,143,71,223,133,130,145,251,48,206,171,184,31,30,1,120,117,103,5,37,179,214,245,214,74,21,225,110,181,110,117,25,82,46,172,9,82,189,111,35,195,81,197,219,172,5,31,9,170,0,212,113,232,221,125,50,203,165,11,111,238,220,32,182,184,79,8,179,54,229,242,5,187,0,113,251,91,136,29,112,227,251,94,197,162,181,229,29,170,173,51,237,140,152,47,180,20,107,239,121,253,35,45,78,110,236,71,91,153,225,99,249,126,207,207,136,91,45,127,213,229,189,148,255,75,130,254,21,158,21,117,244,54,19,231,116,161,197,174,254,199,6,193,184,221,241,162,239,113,99,44,206,243,231,241,34,2,250,17,157,136,43,228,97,14,116,222,224,122,85,99,232,228,209,179,167,95,74,225,49,35,180,181,110,133,125,67,134,30,2,27,27,223,51,72,150,155,255,99,234,235,97,42,41,55,219,47,72,251,248,63,47,9,2,169,235,209,129,20,189,243,194,255,113,93,138,226,254,222,101,152,183,217,23,173,110,35,180,253,6,142,249,85,201,66,73,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateIncorrectDefaultCampaignFirePeriodLocalizableString());
			LocalizableStrings.Add(CreateIncorrectCampaignTimeZoneOffsetLocalizableString());
			LocalizableStrings.Add(CreateOnExecutionTerminateExceptionLocalizableString());
			LocalizableStrings.Add(CreateOnAfterSaveExceptionLocalizableString());
			LocalizableStrings.Add(CreateOnBeforeSaveExceptionLocalizableString());
			LocalizableStrings.Add(CreateOnCopyExceptionLocalizableString());
			LocalizableStrings.Add(CreateOnStartExceptionLocalizableString());
			LocalizableStrings.Add(CreateOnStopExceptionLocalizableString());
			LocalizableStrings.Add(CreateOnValidateExceptionLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateIncorrectDefaultCampaignFirePeriodLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("a9529a24-935e-47a8-86ab-df088c05d382"),
				Name = "IncorrectDefaultCampaignFirePeriod",
				CreatedInPackageId = new Guid("6c038aa0-46cd-4697-bc93-5c682e364aef"),
				CreatedInSchemaUId = new Guid("3abfbe86-86e7-46aa-b930-39ab26ca49a7"),
				ModifiedInSchemaUId = new Guid("3abfbe86-86e7-46aa-b930-39ab26ca49a7")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateIncorrectCampaignTimeZoneOffsetLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("1c987b1e-f45f-47d5-9a9d-bf9fcc85882f"),
				Name = "IncorrectCampaignTimeZoneOffset",
				CreatedInPackageId = new Guid("6c038aa0-46cd-4697-bc93-5c682e364aef"),
				CreatedInSchemaUId = new Guid("3abfbe86-86e7-46aa-b930-39ab26ca49a7"),
				ModifiedInSchemaUId = new Guid("3abfbe86-86e7-46aa-b930-39ab26ca49a7")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateOnExecutionTerminateExceptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("7ad3207f-f276-4e5a-8b6b-23f73daa821b"),
				Name = "OnExecutionTerminateException",
				CreatedInPackageId = new Guid("6c038aa0-46cd-4697-bc93-5c682e364aef"),
				CreatedInSchemaUId = new Guid("3abfbe86-86e7-46aa-b930-39ab26ca49a7"),
				ModifiedInSchemaUId = new Guid("3abfbe86-86e7-46aa-b930-39ab26ca49a7")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateOnAfterSaveExceptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("ea6dab85-0f5b-4ee3-8935-59630df46a4e"),
				Name = "OnAfterSaveException",
				CreatedInPackageId = new Guid("6c038aa0-46cd-4697-bc93-5c682e364aef"),
				CreatedInSchemaUId = new Guid("3abfbe86-86e7-46aa-b930-39ab26ca49a7"),
				ModifiedInSchemaUId = new Guid("3abfbe86-86e7-46aa-b930-39ab26ca49a7")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateOnBeforeSaveExceptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("9d8594ff-30cc-4580-b935-e7e94937b07b"),
				Name = "OnBeforeSaveException",
				CreatedInPackageId = new Guid("6c038aa0-46cd-4697-bc93-5c682e364aef"),
				CreatedInSchemaUId = new Guid("3abfbe86-86e7-46aa-b930-39ab26ca49a7"),
				ModifiedInSchemaUId = new Guid("3abfbe86-86e7-46aa-b930-39ab26ca49a7")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateOnCopyExceptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("8fed27c5-cbab-4f28-9214-4ed4364a6b82"),
				Name = "OnCopyException",
				CreatedInPackageId = new Guid("6c038aa0-46cd-4697-bc93-5c682e364aef"),
				CreatedInSchemaUId = new Guid("3abfbe86-86e7-46aa-b930-39ab26ca49a7"),
				ModifiedInSchemaUId = new Guid("3abfbe86-86e7-46aa-b930-39ab26ca49a7")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateOnStartExceptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("7a0311b3-03d5-4be4-9599-512b59d3ad19"),
				Name = "OnStartException",
				CreatedInPackageId = new Guid("6c038aa0-46cd-4697-bc93-5c682e364aef"),
				CreatedInSchemaUId = new Guid("3abfbe86-86e7-46aa-b930-39ab26ca49a7"),
				ModifiedInSchemaUId = new Guid("3abfbe86-86e7-46aa-b930-39ab26ca49a7")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateOnStopExceptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("2a99c6c5-0f6c-46b8-b34d-0ecedec16da9"),
				Name = "OnStopException",
				CreatedInPackageId = new Guid("6c038aa0-46cd-4697-bc93-5c682e364aef"),
				CreatedInSchemaUId = new Guid("3abfbe86-86e7-46aa-b930-39ab26ca49a7"),
				ModifiedInSchemaUId = new Guid("3abfbe86-86e7-46aa-b930-39ab26ca49a7")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateOnValidateExceptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("4623eba2-33d7-4992-b448-2dc0f0df96a6"),
				Name = "OnValidateException",
				CreatedInPackageId = new Guid("6c038aa0-46cd-4697-bc93-5c682e364aef"),
				CreatedInSchemaUId = new Guid("3abfbe86-86e7-46aa-b930-39ab26ca49a7"),
				ModifiedInSchemaUId = new Guid("3abfbe86-86e7-46aa-b930-39ab26ca49a7")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("3abfbe86-86e7-46aa-b930-39ab26ca49a7"));
		}

		#endregion

	}

	#endregion

}

