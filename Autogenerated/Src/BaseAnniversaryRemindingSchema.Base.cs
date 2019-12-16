﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: BaseAnniversaryRemindingSchema

	/// <exclude/>
	public class BaseAnniversaryRemindingSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public BaseAnniversaryRemindingSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public BaseAnniversaryRemindingSchema(BaseAnniversaryRemindingSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("627718f7-94a8-40e7-9791-08a084a92574");
			Name = "BaseAnniversaryReminding";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("e07b3414-0244-4600-8fa5-7c3b4f179d09");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,229,28,107,111,220,184,241,243,30,112,255,129,167,2,87,109,177,167,220,229,250,0,98,123,3,219,107,231,246,154,196,185,172,115,65,81,20,129,188,162,109,53,90,105,35,74,118,22,65,254,123,103,248,150,68,74,218,60,208,2,205,7,71,162,200,225,112,94,156,25,114,54,143,55,148,109,227,53,37,151,180,44,99,86,92,87,209,105,145,95,167,55,117,25,87,105,145,127,251,205,135,111,191,153,212,44,205,111,200,106,199,42,186,57,104,189,67,255,44,163,107,236,204,162,39,52,167,101,186,238,244,89,196,85,220,105,124,154,230,239,76,227,105,81,210,232,60,94,87,69,153,82,102,218,109,196,74,234,107,143,22,39,238,79,155,77,145,123,7,157,229,85,90,137,217,160,203,31,74,122,3,171,32,103,121,189,121,68,22,241,142,241,230,109,125,149,165,107,66,161,85,54,78,144,38,147,85,157,147,35,242,211,12,159,159,21,248,252,144,63,95,214,20,158,127,230,207,175,105,2,207,127,22,237,183,53,60,255,133,63,159,151,41,60,255,149,63,175,226,10,158,255,6,143,31,5,26,52,79,4,38,13,172,78,179,152,177,71,228,36,102,244,56,207,211,59,90,178,184,220,189,164,155,52,79,96,105,188,239,131,7,15,200,33,171,55,27,248,50,151,239,56,128,172,113,48,185,46,74,114,131,28,138,43,74,98,3,132,148,10,10,139,20,148,7,22,24,73,129,248,138,85,37,48,72,66,243,99,130,244,193,149,105,212,65,52,170,56,175,4,61,39,219,50,189,67,12,214,216,76,210,188,34,11,122,29,215,89,165,65,60,77,175,233,11,16,164,2,169,247,243,143,7,189,163,158,23,85,122,189,67,206,232,33,15,15,36,2,77,82,106,132,206,83,154,37,64,204,23,2,166,248,216,38,30,111,248,173,166,64,159,109,89,108,105,137,146,2,211,43,105,143,244,32,155,86,26,207,167,41,171,14,255,78,119,191,199,89,77,95,196,105,121,8,212,131,181,205,136,248,127,62,39,111,222,33,244,23,26,248,104,172,139,10,80,160,73,15,222,167,117,89,82,160,17,91,223,210,77,76,114,208,115,47,190,18,154,196,139,172,248,144,231,48,226,96,196,4,37,93,23,101,66,150,201,32,248,39,117,154,144,151,188,251,18,153,132,239,209,217,102,91,237,250,230,89,21,117,9,230,105,44,124,209,125,153,244,129,188,188,165,132,83,158,20,91,110,182,72,146,114,142,66,167,193,89,22,186,171,230,103,63,147,185,4,93,136,137,204,224,1,86,115,141,41,107,52,134,35,249,109,6,152,37,108,227,50,222,112,222,31,5,53,163,37,116,202,133,236,6,243,87,141,119,208,39,212,208,53,141,14,31,240,81,243,33,58,248,180,63,108,1,110,206,59,37,220,116,78,222,52,155,65,26,154,13,7,162,87,222,85,237,31,126,34,127,18,123,69,99,159,138,96,79,89,209,170,226,54,236,9,173,56,67,90,184,112,107,59,153,16,199,191,0,140,8,189,47,202,234,118,119,118,7,98,205,109,74,186,230,160,197,212,193,204,103,111,166,28,217,143,253,12,53,74,222,178,58,123,152,139,223,154,214,66,146,242,134,86,242,105,82,210,170,46,243,142,89,33,143,31,147,176,211,120,68,114,122,63,98,218,112,42,22,136,43,132,191,204,76,231,0,121,135,96,172,238,123,81,101,88,202,125,66,219,111,137,75,26,39,69,158,237,218,195,223,56,100,206,8,120,171,115,235,213,75,123,151,28,219,164,112,174,235,60,139,111,72,113,237,222,147,213,150,141,143,48,179,52,184,44,190,243,174,91,108,215,87,69,145,145,37,123,34,71,23,249,69,190,130,65,228,3,0,172,14,8,195,63,251,240,135,67,237,89,196,243,122,115,69,75,92,70,5,6,54,1,253,32,87,20,92,14,159,171,65,82,166,189,145,1,14,226,110,223,49,6,7,214,90,177,67,199,15,232,240,40,189,6,61,232,218,148,35,242,163,178,75,61,54,199,163,253,130,195,82,57,180,20,56,113,149,157,172,13,215,210,37,199,180,30,101,242,238,105,185,102,0,39,62,144,55,206,253,180,207,255,88,145,132,102,116,28,241,203,174,107,214,166,191,203,123,115,179,192,1,172,205,5,103,151,30,63,209,205,6,31,214,189,156,112,79,189,15,51,158,184,124,108,233,107,244,235,236,18,99,15,24,123,149,81,105,136,231,68,250,14,134,150,66,119,71,152,215,103,180,186,45,58,126,174,226,235,93,1,254,210,217,123,186,174,43,138,91,11,104,121,168,56,128,106,27,175,111,73,216,183,53,16,219,254,239,64,6,218,59,148,230,231,138,162,207,12,104,243,255,192,245,163,21,250,15,162,57,108,128,137,96,70,185,225,76,116,255,5,218,60,192,89,14,16,237,179,230,252,106,16,74,88,7,98,116,246,174,142,51,22,6,199,235,117,81,231,85,48,53,178,166,103,57,78,18,249,217,114,108,206,211,172,130,39,57,231,180,41,103,56,87,115,99,64,223,99,201,206,105,12,2,72,207,114,100,100,18,6,182,59,241,251,67,123,114,37,42,90,164,153,123,117,54,89,62,18,154,65,76,167,64,0,218,207,233,125,7,64,19,85,91,102,27,2,208,25,221,224,149,66,244,46,46,113,183,5,76,228,231,35,1,28,93,136,165,213,222,162,198,84,162,24,45,243,170,8,3,61,75,160,63,128,207,22,6,48,160,130,184,114,137,78,86,176,170,175,254,77,245,203,142,241,24,125,39,130,146,70,143,211,152,43,6,182,8,192,151,233,134,6,210,201,155,76,26,68,191,220,109,169,24,12,4,93,83,198,208,239,65,210,51,14,16,244,135,150,18,184,12,32,12,138,231,101,177,105,8,158,164,172,84,157,197,21,151,250,208,38,79,195,37,84,228,230,251,241,105,156,67,8,68,81,186,94,130,91,34,73,69,19,177,202,80,83,200,216,106,165,110,50,148,195,184,204,230,10,219,177,227,4,186,190,202,211,74,250,116,43,171,169,205,16,129,58,202,237,119,246,200,232,156,86,235,91,92,233,226,68,243,3,200,161,177,136,52,143,102,228,26,52,137,26,25,150,198,150,183,218,214,21,177,43,211,155,219,138,61,165,119,52,3,228,90,170,178,56,89,1,5,75,88,247,89,126,147,230,20,117,199,230,182,136,21,95,34,8,14,33,108,96,12,152,72,43,161,233,98,227,171,197,72,46,89,98,105,33,20,253,18,51,116,188,66,247,108,44,226,188,138,19,39,51,185,238,56,148,183,161,61,154,117,214,62,176,114,115,177,190,82,138,37,88,216,163,77,152,112,171,55,121,24,24,33,229,50,234,208,175,232,245,45,45,169,253,97,70,92,122,49,141,150,140,91,200,48,96,92,254,125,253,36,216,227,60,105,1,53,42,236,132,165,100,190,23,134,209,124,39,140,222,177,136,160,50,8,206,209,45,163,33,165,2,105,191,137,211,92,19,95,50,112,58,150,9,226,191,232,24,172,73,153,178,183,16,44,217,28,145,246,2,62,107,84,154,156,153,70,64,101,248,123,246,30,236,17,88,110,37,6,22,122,150,211,102,133,108,122,241,16,159,137,190,102,25,145,180,76,40,188,180,12,75,254,31,57,154,43,133,109,64,21,187,177,9,223,69,111,181,121,88,137,65,216,40,66,253,170,66,66,249,191,118,23,154,160,211,220,194,126,106,187,128,142,176,228,251,239,201,119,3,214,209,178,137,110,141,50,251,234,26,228,49,205,149,199,102,252,66,109,30,96,202,176,17,216,34,90,214,114,79,209,15,32,115,203,41,93,112,103,25,248,117,188,174,64,184,92,201,15,22,186,241,234,250,141,202,142,24,131,223,224,194,18,19,230,130,127,68,114,196,178,22,107,165,108,192,60,241,21,77,167,16,69,238,173,29,98,46,108,30,54,212,206,72,20,229,212,28,30,237,26,133,203,241,142,147,126,33,248,59,208,203,30,203,218,219,248,208,212,150,41,176,160,136,92,102,103,31,177,65,63,139,243,248,70,128,93,86,116,115,178,123,181,76,194,206,244,22,208,4,221,74,97,165,7,151,229,183,33,22,219,209,177,93,32,107,125,224,240,35,186,42,0,240,184,59,76,65,93,106,97,184,164,239,171,243,162,132,176,128,84,230,241,72,28,8,136,3,147,29,206,113,232,146,72,51,120,30,26,151,205,202,22,30,151,55,16,113,228,224,133,181,50,132,179,22,153,167,214,114,129,150,25,46,208,224,131,8,92,98,107,136,240,29,73,210,130,147,78,219,160,15,129,81,15,152,74,176,54,194,183,143,13,203,130,179,93,21,201,174,51,217,9,52,126,254,92,51,213,227,76,234,4,124,87,234,209,254,40,135,27,61,48,29,56,227,102,150,44,117,23,97,27,92,68,219,232,122,43,101,164,253,21,109,170,104,5,113,175,37,65,44,236,244,49,14,240,24,177,179,220,229,14,164,5,101,235,50,221,202,172,44,103,116,187,203,139,98,91,111,47,149,8,184,122,156,90,6,74,27,171,206,186,26,218,4,61,145,207,158,78,28,146,98,76,167,143,116,217,161,139,149,254,111,209,80,120,248,208,165,99,12,58,125,29,198,106,112,80,215,89,130,81,154,199,92,223,88,167,147,165,176,93,136,150,71,3,160,140,104,181,251,89,64,164,217,225,90,33,185,29,170,135,232,178,72,226,93,244,15,26,151,51,151,185,138,158,1,159,110,221,159,22,241,174,229,69,171,217,189,174,241,168,205,114,172,119,156,43,48,102,44,58,65,182,63,36,246,13,75,223,28,99,196,89,30,247,119,122,17,19,241,92,223,78,238,3,222,246,188,208,233,242,32,47,252,169,158,157,119,218,235,91,129,124,129,119,229,129,61,245,121,122,99,12,79,211,17,106,4,134,214,236,150,171,101,219,14,100,122,232,206,60,76,38,182,144,72,135,123,28,43,198,202,73,21,151,55,205,16,82,112,251,178,211,222,203,221,118,64,230,136,9,218,164,107,6,5,231,117,190,142,158,197,239,237,248,227,20,184,8,158,236,5,184,13,222,160,205,31,39,12,132,101,58,224,145,225,136,48,131,42,78,20,100,241,141,109,196,84,22,190,142,128,110,0,186,53,196,3,180,155,206,25,13,220,49,212,55,137,35,140,28,2,110,134,216,50,240,201,2,96,129,238,11,210,57,191,101,215,22,191,45,170,26,193,129,229,0,7,197,138,76,168,104,83,161,159,213,109,114,188,192,147,94,208,216,50,220,107,167,154,122,166,212,105,180,158,137,186,42,26,189,66,136,38,47,165,110,8,200,197,226,253,128,208,88,27,193,147,206,204,126,150,219,107,20,128,155,231,153,114,71,19,112,15,156,182,202,181,161,137,21,88,123,153,109,135,196,177,138,157,35,149,150,209,147,29,237,10,198,235,180,186,253,37,205,43,198,93,220,151,197,253,211,98,253,22,27,116,130,193,157,219,49,217,75,63,29,84,31,3,201,145,138,25,193,74,67,79,18,51,185,66,103,102,84,144,195,153,70,51,219,128,117,30,48,214,220,167,172,155,174,7,109,93,58,154,123,237,189,156,143,223,16,51,31,1,146,115,130,199,36,232,182,6,228,145,182,127,65,3,234,154,147,173,7,24,143,29,112,248,73,90,86,183,252,237,224,75,239,104,173,243,23,35,151,253,89,123,105,205,86,86,130,53,184,184,207,165,96,160,241,234,230,245,244,40,39,62,13,131,216,78,162,13,91,9,62,167,165,236,45,56,124,223,61,173,89,85,108,240,17,215,18,6,215,249,155,211,152,85,220,15,46,132,11,13,18,238,218,16,90,2,48,147,188,155,106,69,153,216,243,235,44,192,208,98,180,7,254,170,90,63,47,238,167,138,114,38,6,27,130,176,167,117,230,240,253,217,91,255,60,63,202,177,157,51,146,94,137,208,194,96,140,198,208,68,198,4,137,129,206,51,151,176,35,198,159,125,220,166,119,116,185,141,12,136,170,72,99,181,22,227,147,18,190,146,158,132,206,199,137,216,85,26,231,141,242,64,219,123,222,232,75,116,126,194,118,217,229,217,151,216,41,109,99,222,48,83,110,35,245,89,158,252,30,134,93,172,254,241,216,76,161,188,71,116,194,211,58,214,33,177,0,243,232,19,193,168,253,160,25,59,119,151,230,61,44,116,46,120,12,9,249,104,207,246,232,28,216,61,31,111,224,236,2,213,179,157,247,30,164,59,207,151,165,156,254,90,164,121,136,127,208,98,69,75,32,120,57,115,110,183,202,3,189,200,13,202,109,177,118,141,51,208,76,106,217,118,41,61,67,204,171,199,149,150,232,24,21,106,13,145,134,251,28,128,39,220,44,45,226,157,209,175,65,205,50,116,245,27,140,79,56,121,252,98,98,242,63,236,65,97,226,108,145,94,95,11,50,137,191,194,135,90,52,190,156,189,223,150,176,231,161,203,224,179,240,54,208,221,197,245,107,74,223,54,225,53,26,71,3,20,28,107,132,127,30,143,75,156,21,130,161,175,179,44,180,131,48,173,14,91,154,159,100,16,42,56,90,92,132,64,96,39,180,186,167,212,177,73,119,238,185,78,249,92,46,175,193,66,165,69,26,152,161,11,154,133,33,132,50,83,4,29,173,106,117,47,119,98,26,159,21,249,140,152,215,203,154,218,175,175,105,210,248,122,91,219,175,231,101,106,191,174,226,74,227,119,154,21,140,182,232,83,238,65,42,207,118,217,185,120,248,3,249,105,128,38,62,80,13,18,252,23,240,126,248,217,120,3,175,250,240,182,155,70,26,63,165,167,60,152,84,126,125,175,2,119,46,204,104,115,40,21,79,218,63,55,228,107,165,211,60,156,80,125,228,233,153,115,200,50,135,1,119,113,134,137,114,41,204,122,44,216,108,204,185,203,225,19,23,204,33,168,60,103,175,186,186,2,23,214,53,45,186,191,140,137,120,177,134,62,20,80,62,173,238,54,18,170,232,61,181,215,232,6,221,228,173,160,168,143,183,32,69,149,131,183,62,99,186,15,115,187,160,187,204,197,62,22,115,59,67,52,27,16,155,228,255,131,193,123,241,144,167,199,150,120,215,76,145,190,93,168,48,190,212,192,196,53,242,214,171,220,237,46,202,118,100,131,19,182,230,105,222,231,208,29,36,164,208,127,143,75,228,174,58,41,61,94,80,36,136,132,217,7,43,60,161,236,157,92,148,237,199,139,108,215,112,172,160,47,44,242,92,159,90,16,140,227,151,219,248,13,52,164,25,191,80,39,249,183,188,201,139,18,36,136,109,179,88,16,16,123,84,101,77,197,138,197,194,1,45,60,86,58,206,50,49,159,224,179,166,11,126,150,222,34,63,125,194,119,145,93,22,173,152,116,180,246,104,209,120,90,108,182,113,153,50,145,69,16,14,160,35,189,172,238,93,238,153,170,248,242,136,181,206,9,244,121,255,171,175,52,157,117,91,181,29,54,119,110,111,225,68,250,142,163,41,155,109,167,223,162,203,226,184,44,227,93,216,123,2,232,185,93,229,59,141,27,83,142,99,221,23,31,174,197,145,73,94,38,75,233,0,27,112,63,226,171,152,249,234,9,58,37,105,124,96,48,23,199,178,85,65,168,128,216,40,65,51,87,244,239,192,185,7,154,55,174,173,171,12,243,114,113,130,149,190,113,158,8,108,20,53,222,217,135,178,109,3,224,4,236,52,43,228,3,25,57,74,219,26,219,18,118,138,255,68,188,224,254,230,176,129,88,27,145,131,17,108,221,184,181,141,157,22,17,185,21,138,98,3,30,132,1,99,36,28,61,190,247,82,255,22,26,173,147,96,55,150,209,101,185,211,85,118,102,178,25,41,234,138,67,176,206,135,65,197,108,138,238,66,252,142,247,217,103,188,103,196,129,244,221,86,111,147,124,239,18,204,30,98,75,44,229,38,231,185,79,52,102,211,234,171,7,121,201,161,51,149,127,191,7,251,66,226,44,147,123,170,168,203,94,203,122,90,113,201,197,93,195,41,198,7,115,25,234,139,114,110,94,243,232,46,243,233,22,115,118,212,79,49,69,169,225,86,85,115,216,56,201,12,201,120,104,200,221,96,110,135,233,98,89,118,57,242,30,208,56,241,131,57,214,56,105,252,18,52,206,176,78,48,64,21,24,100,93,118,38,42,69,112,231,237,76,32,152,204,230,207,138,4,246,36,94,245,51,154,31,135,15,212,104,183,113,51,82,170,171,228,37,151,90,181,43,173,52,205,248,250,26,20,51,175,132,129,142,113,225,125,215,100,34,24,213,70,11,58,99,25,94,62,113,18,253,237,48,211,250,101,224,238,203,240,137,190,143,55,219,140,206,59,134,195,42,76,8,208,79,79,215,233,54,198,44,212,225,3,53,102,136,59,170,230,165,9,88,90,205,183,104,147,228,51,95,139,50,15,218,16,154,93,1,2,100,97,201,240,142,143,178,104,104,169,1,8,222,101,54,166,13,27,5,180,30,3,222,129,14,126,9,50,180,79,62,66,142,175,4,109,27,161,225,253,125,168,150,83,248,14,92,41,138,44,105,253,62,132,131,192,255,188,184,98,5,119,55,2,49,9,86,31,38,20,130,182,53,94,94,152,249,126,94,164,225,31,158,102,52,206,105,249,107,113,69,54,53,171,200,21,229,162,151,212,25,77,162,96,250,47,206,73,81,39,103,185,237,23,89,226,56,134,247,84,241,141,44,28,63,76,243,106,238,174,30,111,120,190,12,226,210,84,192,129,5,110,76,141,184,163,66,209,78,31,218,247,3,66,177,140,169,255,154,128,167,186,67,230,10,155,1,231,216,252,132,243,66,76,227,10,128,125,64,57,35,238,40,115,138,41,161,39,220,117,46,125,153,112,23,41,252,117,28,238,107,43,174,20,162,244,46,134,2,14,251,29,139,151,62,227,166,75,3,209,37,195,75,126,189,87,93,74,173,151,22,215,207,88,46,25,79,70,115,254,108,245,220,70,243,171,241,191,61,79,243,246,209,87,21,2,199,212,251,81,184,231,206,137,251,27,48,98,216,115,179,236,160,21,201,217,254,129,40,199,247,248,107,42,242,12,230,173,223,99,129,182,161,95,218,232,24,58,89,160,54,148,159,248,236,67,114,79,54,196,76,36,247,173,70,21,170,109,214,200,87,190,241,52,226,22,161,145,17,43,250,87,96,184,192,237,121,101,172,125,197,169,87,222,246,40,16,7,193,194,245,182,133,75,248,57,88,192,15,14,165,56,244,98,110,25,43,120,245,148,166,164,41,171,10,230,252,87,37,172,223,124,74,237,178,82,70,238,111,105,174,92,188,123,88,30,254,162,196,62,82,169,22,209,190,129,28,242,99,69,47,94,182,156,122,59,241,106,176,49,82,172,145,200,243,157,52,219,162,158,44,232,243,182,28,229,103,71,126,140,15,116,62,209,14,206,71,161,55,160,100,61,215,9,109,116,219,69,250,131,102,235,51,229,107,127,150,171,117,121,59,112,83,221,227,163,118,127,250,12,90,254,3,125,61,136,38,158,78,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("627718f7-94a8-40e7-9791-08a084a92574"));
		}

		#endregion

	}

	#endregion

}
