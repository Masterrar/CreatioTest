﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: MandrillUtilitiesSchema

	/// <exclude/>
	public class MandrillUtilitiesSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public MandrillUtilitiesSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public MandrillUtilitiesSchema(MandrillUtilitiesSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f6bbc90f-57b4-4b9d-a227-adeac0275e36");
			Name = "MandrillUtilities";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("48513af2-42ae-4933-a664-64fbd4224266");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,237,28,105,115,219,182,242,179,58,211,255,128,50,31,74,165,10,157,246,53,109,199,87,106,203,118,163,87,59,113,45,187,153,121,142,219,161,41,200,226,11,69,178,0,233,68,77,253,223,223,226,34,1,222,84,156,244,152,215,195,34,193,221,197,98,177,23,206,208,93,98,26,187,30,70,231,152,16,151,70,243,196,25,71,225,220,191,73,137,155,248,81,232,156,184,225,140,248,65,48,197,228,214,247,240,167,159,188,251,244,147,65,74,253,240,6,169,79,91,89,137,78,100,185,140,194,250,47,206,191,105,221,103,173,246,106,0,130,235,202,157,131,253,218,79,135,97,226,39,62,166,181,0,83,111,129,103,105,128,73,21,196,243,212,119,164,8,78,162,25,14,156,195,183,9,14,41,240,168,17,156,174,104,130,151,197,119,231,192,77,220,82,225,56,10,2,236,177,70,82,231,7,28,98,226,123,101,68,226,190,129,87,103,178,116,111,224,183,244,125,242,162,162,136,9,56,38,152,82,67,126,242,243,177,31,254,86,42,60,199,111,147,202,66,231,12,223,164,129,75,14,223,42,130,165,198,130,80,188,148,248,201,202,25,147,85,156,68,55,196,141,23,171,28,234,167,212,37,201,239,249,251,77,16,93,187,193,230,166,212,130,227,232,70,181,12,254,123,64,240,13,84,130,198,129,75,233,102,166,95,23,137,31,240,174,251,244,19,0,218,216,216,64,219,52,93,46,93,178,218,149,239,15,228,63,217,131,122,66,250,163,246,85,145,222,139,125,71,209,220,208,136,198,233,117,224,123,136,38,160,134,30,242,24,63,85,236,12,222,113,150,50,198,143,124,28,204,128,243,83,226,223,186,9,22,31,99,241,130,60,16,95,130,252,48,65,7,152,122,196,143,89,231,159,175,98,60,77,8,200,224,24,135,55,201,2,237,160,175,158,60,222,170,195,156,166,215,255,5,173,25,187,117,200,79,30,23,145,101,27,8,118,103,81,24,172,208,4,100,142,126,13,224,207,14,130,71,104,149,123,131,9,232,96,194,58,3,19,219,82,13,181,134,157,72,189,193,215,207,162,232,245,113,7,138,47,5,40,109,165,124,114,240,4,253,186,156,61,1,138,240,8,186,133,1,202,110,195,2,117,197,111,209,179,100,25,60,3,201,144,192,15,95,211,83,151,80,76,196,151,29,20,226,55,2,202,254,222,218,118,95,93,95,254,178,123,245,240,233,171,235,5,193,243,87,244,225,14,252,111,161,47,16,171,100,240,189,101,63,221,180,224,207,246,197,217,241,46,60,191,122,101,89,127,92,254,98,89,87,195,135,67,120,252,92,255,244,57,124,249,156,125,248,124,200,137,238,218,151,191,108,95,61,132,111,246,211,207,182,55,220,225,54,127,7,0,120,217,109,23,173,232,87,97,84,232,87,170,191,137,102,76,253,101,28,96,81,148,73,230,1,6,65,115,93,52,21,243,148,68,32,16,166,180,160,156,92,183,197,247,162,49,105,214,132,12,123,98,230,163,122,209,201,48,117,147,41,216,12,215,13,246,255,59,46,204,27,156,200,167,1,193,73,74,66,174,130,91,188,228,142,253,189,251,40,12,189,204,117,181,150,175,92,159,123,177,87,240,64,90,105,55,246,140,14,55,94,106,57,213,181,162,204,107,157,46,156,224,100,17,213,122,41,201,142,32,141,192,134,207,240,210,15,103,240,242,204,165,11,251,192,231,49,11,218,176,45,64,70,40,226,46,105,23,205,178,79,67,201,232,173,75,24,33,165,176,28,126,63,245,131,25,248,132,161,96,120,14,145,215,245,22,200,22,84,208,173,27,164,24,92,157,70,205,249,153,149,81,69,116,0,20,157,189,56,134,214,217,28,122,168,53,93,137,230,200,15,112,230,167,153,39,2,47,194,249,63,12,189,136,53,198,185,8,125,120,194,236,219,254,42,193,212,102,100,207,35,193,164,61,28,10,170,119,77,194,57,39,105,232,65,177,196,145,165,52,74,137,135,71,220,93,7,220,45,43,206,37,111,182,128,112,164,207,222,85,80,162,117,79,37,1,16,154,132,3,159,47,72,219,143,71,38,236,166,4,217,234,213,235,221,204,223,140,161,5,149,174,209,104,94,18,187,196,93,162,16,18,203,29,43,5,215,11,9,93,40,18,29,107,183,108,38,149,37,206,246,6,167,82,77,148,198,207,225,151,19,171,98,173,17,151,63,227,4,19,90,193,76,25,85,244,24,173,228,187,186,110,133,81,54,112,166,15,135,111,33,91,98,10,3,90,63,3,159,236,65,194,73,176,125,97,136,9,153,82,27,41,117,19,237,30,137,224,52,224,156,82,244,35,94,113,243,56,117,125,82,180,200,203,43,148,183,215,176,201,56,51,73,147,145,82,205,188,202,162,169,50,18,25,97,102,171,229,90,6,52,118,94,250,201,226,84,125,177,51,24,7,88,30,229,40,194,186,13,27,6,220,83,215,123,13,73,4,171,29,88,53,217,130,36,255,48,132,172,17,44,131,167,160,26,236,150,110,103,64,70,202,219,54,140,185,73,233,117,45,52,116,244,79,213,120,204,134,46,43,69,108,132,74,202,87,197,126,51,201,89,158,130,74,186,61,12,16,6,74,75,87,230,160,149,77,44,122,142,34,73,211,50,110,35,127,134,68,138,151,5,27,91,168,81,139,101,240,49,221,10,9,249,100,134,162,181,45,55,30,157,103,80,41,203,82,170,154,85,9,201,151,124,146,100,85,186,168,88,50,107,151,42,171,232,139,196,28,112,4,51,14,4,87,166,37,7,62,141,3,119,5,163,189,116,25,114,85,23,104,48,38,196,231,62,104,55,35,154,189,148,84,125,156,18,2,4,153,24,88,164,146,175,10,94,5,209,31,82,16,160,196,76,92,47,153,204,154,41,101,96,91,153,75,128,33,198,204,151,178,97,173,110,136,243,210,194,229,207,192,218,75,33,178,16,107,100,114,32,190,222,141,80,6,39,63,181,3,78,121,80,3,184,76,244,99,54,0,162,78,246,46,32,68,197,149,20,140,97,18,80,146,221,83,1,185,162,162,183,167,92,65,0,84,246,159,120,119,46,114,242,194,67,25,189,190,128,148,2,4,86,202,146,50,105,202,14,242,231,200,254,76,224,56,19,250,60,13,130,23,228,112,25,39,43,91,211,213,97,238,60,51,101,146,56,71,17,89,186,137,109,189,123,124,135,94,89,239,190,188,123,101,161,119,95,221,89,42,24,40,134,10,196,13,165,31,162,167,133,182,201,15,194,3,163,77,211,70,114,210,109,10,157,67,234,141,209,29,58,111,126,193,186,156,35,156,120,139,35,18,45,15,246,237,54,141,131,127,45,38,88,104,48,23,249,29,130,62,156,187,1,197,185,208,138,244,167,56,57,192,115,141,79,106,27,76,105,204,130,160,139,185,156,232,129,81,211,80,93,57,128,172,179,234,104,52,15,218,135,42,104,149,216,215,120,135,33,52,164,173,115,31,207,94,132,210,128,148,19,232,136,175,140,165,104,126,29,209,51,248,53,241,133,197,114,244,142,86,221,145,176,192,102,130,88,79,46,90,7,3,129,178,6,183,54,172,198,213,116,68,215,180,186,107,133,166,199,226,34,45,249,172,126,204,235,52,164,153,107,96,117,180,220,219,191,125,98,245,94,89,80,169,31,118,171,89,200,223,26,50,183,138,185,4,163,250,203,23,215,52,10,32,97,182,173,111,157,239,156,199,232,15,4,161,188,118,214,62,179,169,124,16,92,72,176,172,225,85,199,76,172,219,232,196,72,186,120,66,82,18,144,114,213,127,165,220,231,61,179,191,238,65,167,148,39,22,162,133,33,191,78,17,163,49,128,25,228,218,131,216,255,163,199,223,50,122,84,197,130,178,217,245,143,5,204,168,28,158,67,190,159,243,63,19,179,33,48,186,80,139,93,40,154,163,100,129,209,60,98,179,128,104,238,7,108,218,96,221,32,48,1,21,112,67,15,43,170,219,20,99,228,17,60,223,177,10,139,123,166,19,179,54,118,155,157,59,193,94,68,102,204,167,95,132,254,111,108,70,114,198,226,35,36,96,196,108,65,51,25,1,35,58,226,162,3,53,153,130,183,4,30,174,232,93,136,202,153,68,41,228,90,226,106,206,74,147,222,68,87,161,159,82,76,86,71,156,200,36,193,75,16,30,58,146,36,243,142,45,204,125,245,140,87,98,57,208,152,177,61,226,18,57,164,191,137,186,42,227,85,19,155,40,163,33,153,237,54,165,192,227,137,234,126,249,90,232,70,21,223,204,126,40,204,242,182,183,72,49,84,228,32,175,188,84,111,161,202,17,74,136,202,207,186,45,80,168,137,153,155,223,253,88,159,164,233,106,128,16,197,84,154,83,88,142,105,155,60,69,18,168,126,130,244,122,149,224,203,43,164,150,175,179,249,244,132,40,209,74,136,153,155,184,50,60,243,18,54,115,47,39,211,31,34,234,255,142,163,185,237,45,92,50,188,18,206,75,174,84,239,167,243,57,24,236,126,16,121,175,199,81,188,146,51,254,99,128,220,3,173,92,217,195,17,122,60,226,212,179,7,199,136,146,98,9,219,62,193,203,136,172,32,138,98,144,75,148,38,113,154,72,118,244,47,118,62,52,149,120,63,252,199,143,37,22,151,191,192,201,75,109,65,107,132,180,21,124,182,217,32,91,209,151,253,157,209,29,48,50,206,75,226,131,153,53,176,45,225,198,65,68,179,180,41,211,83,81,39,200,65,202,64,126,190,203,71,202,189,52,171,160,103,125,116,139,49,158,41,87,73,65,239,75,189,14,192,186,164,130,105,234,164,68,90,213,195,126,216,218,193,28,164,67,71,8,184,211,136,170,169,182,199,91,106,242,130,119,134,198,28,7,213,39,44,254,228,110,248,16,29,32,5,92,209,1,173,166,34,164,92,52,148,156,118,209,84,214,53,93,229,115,174,193,121,232,62,231,155,175,175,148,33,177,133,29,182,110,15,159,31,125,153,91,23,47,224,134,119,6,207,54,35,192,213,130,61,20,237,243,205,194,15,48,178,57,210,46,122,156,215,62,144,230,41,84,43,163,193,0,51,228,158,117,221,253,3,124,66,135,149,186,188,194,70,165,148,65,38,87,156,108,9,184,66,57,149,46,176,245,98,16,184,166,201,28,202,88,125,226,139,202,25,49,142,210,39,80,155,226,202,246,46,117,149,27,175,207,42,152,102,7,145,245,147,90,185,141,74,58,74,98,44,12,67,25,251,161,210,124,120,17,7,82,65,123,163,79,208,230,152,92,185,57,81,161,230,26,53,179,23,88,133,114,241,156,131,175,145,43,213,42,178,185,163,12,50,50,191,110,35,74,121,65,239,22,82,117,54,20,175,94,61,211,18,241,108,139,139,220,185,114,152,97,86,13,97,202,93,218,153,243,166,238,230,233,46,219,40,145,6,175,15,25,244,25,166,49,12,191,177,157,44,124,138,138,172,161,172,121,74,13,232,27,63,97,43,199,165,15,3,207,133,81,65,145,0,184,37,223,123,189,105,58,165,19,151,188,198,73,62,240,47,49,195,145,240,76,205,236,212,144,126,17,227,176,47,101,134,211,74,248,153,75,102,191,94,71,41,12,71,251,210,103,168,251,28,179,165,142,41,140,156,214,172,131,161,118,171,35,118,151,189,137,3,78,27,89,28,206,122,147,5,228,22,178,23,33,77,175,251,210,229,72,45,132,207,48,155,13,233,75,89,96,181,234,202,1,158,179,129,112,208,151,188,194,203,200,207,240,220,77,131,34,155,249,244,205,251,228,143,247,237,244,152,51,233,239,240,78,32,188,186,55,120,202,145,255,114,62,79,231,142,99,150,92,158,81,104,168,131,142,235,8,211,236,109,33,45,158,195,168,66,233,230,189,234,180,81,3,179,215,123,179,113,147,114,238,248,250,123,145,102,207,103,214,115,159,206,207,160,124,15,142,234,239,102,236,105,213,38,187,26,107,87,205,134,246,77,5,234,95,199,214,75,188,33,209,186,42,83,207,75,133,42,148,112,157,73,120,235,6,126,111,45,150,104,166,162,149,169,255,148,226,180,191,137,8,172,54,218,247,235,64,202,244,223,219,125,124,40,3,65,82,137,250,111,128,253,56,137,126,5,127,77,234,94,206,156,163,25,174,212,127,246,225,99,230,248,149,12,56,50,177,239,155,214,87,19,19,185,252,154,153,124,53,201,60,8,175,153,188,87,147,205,227,86,223,124,189,134,30,0,246,77,209,107,40,1,70,239,172,188,154,20,135,236,159,136,87,19,83,142,102,157,220,187,154,162,2,174,118,48,201,130,68,111,248,28,131,244,206,99,151,38,135,111,61,204,87,115,115,75,80,39,138,216,63,22,24,83,24,37,200,69,64,204,7,85,148,71,30,230,17,65,56,76,151,40,97,8,37,174,173,181,167,130,215,119,94,31,37,97,255,120,190,235,3,231,234,107,248,134,46,233,121,111,77,111,203,200,123,153,116,215,36,124,13,15,214,150,119,247,114,98,173,169,118,187,247,233,103,219,92,85,192,174,45,212,199,158,13,54,255,44,147,254,224,105,249,71,48,233,143,145,146,87,171,140,132,93,35,11,175,166,39,64,215,74,188,187,187,134,78,185,118,171,99,232,111,33,208,47,157,77,164,204,99,63,3,209,52,121,79,108,237,120,160,15,8,75,250,222,233,84,38,223,16,153,9,102,251,124,87,168,223,228,16,216,198,196,189,14,48,148,105,187,96,70,178,110,86,234,138,141,130,82,247,140,211,83,62,219,159,226,135,26,98,166,162,2,139,169,89,244,26,219,12,176,183,155,208,27,171,59,143,139,179,99,99,96,252,64,27,40,163,125,208,147,111,190,238,188,17,139,4,218,134,217,10,233,182,237,158,189,230,213,29,232,203,123,130,131,154,57,137,102,106,75,127,137,197,40,235,100,114,114,88,216,153,210,239,28,210,113,228,206,216,125,11,120,143,10,134,212,62,20,104,242,136,173,140,170,197,175,188,5,70,177,98,37,91,51,204,192,216,250,87,26,200,84,82,129,25,133,9,89,41,53,96,90,66,240,111,41,166,108,129,218,150,171,97,207,113,226,60,75,146,24,194,201,153,248,56,212,190,228,165,234,192,60,240,172,22,111,5,65,97,216,117,20,197,215,161,172,215,225,199,90,228,68,136,34,35,215,209,229,226,40,193,30,246,111,177,124,219,201,42,208,81,203,75,234,198,34,60,85,184,229,69,120,181,42,173,234,44,95,138,129,145,207,255,238,84,221,152,129,29,118,186,68,18,51,56,213,120,25,112,2,98,63,163,96,101,36,104,58,103,238,27,113,236,38,95,104,55,250,114,28,133,183,152,176,85,114,161,39,249,41,96,32,146,175,157,243,5,74,219,15,147,161,252,82,88,142,31,112,86,153,171,245,38,225,60,66,236,80,178,7,228,205,98,38,80,94,194,214,156,103,108,239,216,48,27,81,56,71,62,161,201,11,114,32,220,179,13,216,224,146,228,153,161,201,1,218,217,41,182,200,97,83,34,57,7,154,46,138,218,63,19,74,137,158,138,119,231,68,1,108,106,202,154,239,36,144,13,43,236,37,144,165,236,188,144,94,46,55,17,32,207,101,1,250,221,58,201,143,250,69,165,135,146,193,119,245,103,75,145,152,157,227,101,28,228,131,30,69,166,197,249,8,92,222,61,90,106,133,26,208,75,67,160,12,176,249,252,48,104,129,98,113,234,255,142,149,107,42,112,63,66,199,62,77,182,121,167,239,34,131,61,165,248,98,207,10,139,181,185,237,240,27,95,246,166,227,201,164,238,144,252,24,114,249,196,46,212,166,29,113,51,170,98,122,199,180,69,59,160,197,211,12,81,173,22,211,10,161,81,152,117,88,205,247,64,50,253,69,111,174,133,9,132,249,113,230,247,37,197,146,150,123,34,229,69,97,2,105,86,213,69,6,154,180,186,91,201,163,7,133,216,143,166,207,246,190,236,106,11,236,44,210,88,112,100,236,32,41,238,248,204,235,106,214,112,35,207,80,36,74,180,186,236,55,225,247,36,129,202,241,51,150,242,0,188,248,116,121,133,52,182,149,182,24,55,78,32,122,221,233,34,10,89,151,74,209,42,200,14,232,181,186,128,162,152,159,169,45,66,12,107,95,110,19,226,167,27,89,7,136,139,58,228,45,82,167,36,186,245,121,253,67,190,191,51,149,205,226,192,154,18,93,156,31,125,167,116,72,57,125,237,210,138,235,242,157,21,3,209,208,204,81,171,244,222,79,100,200,194,218,69,23,25,163,67,24,56,128,61,123,216,182,30,89,234,84,143,126,6,160,95,234,153,235,6,202,31,75,103,181,144,238,206,185,22,244,208,81,174,156,92,213,109,38,221,97,39,29,107,240,227,247,173,247,38,44,170,106,60,255,210,188,105,50,138,2,244,51,27,93,41,189,215,142,30,203,107,20,154,141,64,173,130,232,182,99,128,129,159,102,239,173,157,12,74,71,145,11,105,193,34,187,92,9,205,33,195,146,82,36,120,174,4,153,44,3,121,134,123,99,183,115,143,230,72,187,226,23,177,34,148,48,35,104,187,211,131,226,243,232,56,122,131,9,12,65,1,255,128,93,44,177,132,145,38,69,16,150,248,119,196,248,69,73,132,2,6,134,216,168,184,190,243,142,192,55,207,180,102,54,246,80,197,185,101,241,187,139,248,221,83,230,117,84,89,247,101,205,29,137,62,46,182,2,76,152,239,96,85,103,230,234,107,17,61,81,123,108,95,130,149,252,220,9,79,192,150,252,47,248,185,218,91,179,28,14,8,190,38,103,89,219,248,204,162,62,251,238,76,83,207,131,136,157,103,214,178,161,140,220,5,9,128,63,1,247,3,137,210,152,94,126,117,229,104,183,33,8,66,69,17,104,89,122,78,69,62,57,18,206,46,237,107,205,65,205,161,145,56,138,177,114,88,67,69,22,109,75,208,161,115,78,124,109,188,193,120,81,213,76,19,151,36,148,93,101,98,131,138,38,241,230,198,134,53,68,127,252,129,234,0,40,135,208,88,215,228,144,93,63,145,229,238,66,194,202,243,26,18,250,82,74,104,132,190,183,182,197,149,98,5,191,60,18,87,153,189,136,197,45,130,147,155,16,250,150,11,110,75,151,91,126,233,69,39,129,168,235,2,10,66,225,164,232,165,108,246,149,236,9,9,92,232,3,109,163,176,114,63,28,187,131,139,17,78,138,162,180,116,166,137,187,26,230,168,30,49,86,217,17,167,162,223,161,202,231,32,49,98,92,206,158,116,158,23,53,61,143,148,114,173,131,40,157,184,234,180,189,64,222,65,197,94,205,203,162,10,251,139,229,173,18,236,254,59,35,53,200,82,73,57,210,211,210,0,105,150,162,31,120,125,140,200,5,63,12,203,119,206,179,58,181,67,230,178,138,82,146,32,177,244,142,42,92,40,37,74,11,133,234,146,169,9,132,20,50,7,85,222,52,239,51,107,189,184,209,8,142,165,225,92,69,240,108,186,181,209,87,92,20,46,85,227,66,150,130,7,89,178,66,243,234,46,57,228,200,206,52,199,46,165,241,130,100,22,149,111,22,239,141,219,40,54,121,223,165,126,163,95,187,196,244,108,231,95,7,135,211,38,137,136,11,44,117,250,155,101,217,240,206,126,239,219,194,180,199,158,131,239,242,170,68,91,220,87,18,22,152,35,84,72,38,171,213,170,154,112,229,102,248,150,97,249,90,138,100,154,186,24,222,9,199,56,208,83,125,148,38,243,239,164,241,154,67,0,1,11,190,164,114,56,193,45,56,123,145,179,106,53,176,138,150,228,37,153,97,250,35,102,7,223,117,26,134,7,98,76,229,94,71,107,149,121,64,142,141,227,25,181,189,224,38,34,16,25,213,244,30,68,20,80,64,208,213,186,145,144,138,154,6,178,35,152,146,236,109,85,65,176,195,63,108,74,206,143,23,152,240,147,64,135,227,253,74,200,83,119,198,197,187,131,228,19,135,62,253,113,60,253,86,194,107,167,194,206,35,217,187,236,74,1,163,233,178,131,11,179,162,19,209,174,115,226,134,20,242,172,37,194,2,61,34,146,255,156,15,49,65,123,168,190,235,211,163,82,39,248,85,82,242,179,147,145,60,242,67,55,224,167,33,108,131,195,236,196,89,86,82,152,104,172,136,201,53,51,152,178,254,181,70,125,247,100,255,31,201,13,244,241,5,157,156,65,223,200,240,207,119,6,255,32,95,32,59,87,155,250,103,235,11,134,233,116,116,11,51,220,236,22,14,112,163,91,200,208,27,220,130,36,161,185,5,89,210,238,22,84,191,54,184,131,14,57,33,148,253,15,119,11,77,101,93,94,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f6bbc90f-57b4-4b9d-a227-adeac0275e36"));
		}

		#endregion

	}

	#endregion

}

