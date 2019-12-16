﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SendingMailingStateSchema

	/// <exclude/>
	public class SendingMailingStateSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SendingMailingStateSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SendingMailingStateSchema(SendingMailingStateSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("aab8c7b4-900b-432a-b80a-d3517da0b687");
			Name = "SendingMailingState";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b39fd9cb-6840-4142-8022-7c9d0489d323");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,221,28,107,115,219,198,241,51,51,211,255,112,97,62,4,156,176,24,217,233,39,57,114,199,166,100,135,19,201,81,69,218,153,105,221,209,64,224,137,66,13,2,12,30,178,21,141,254,123,247,222,111,0,212,35,105,154,15,142,8,236,237,237,237,237,237,251,80,36,27,92,111,147,20,163,37,174,170,164,46,47,155,120,86,22,151,217,186,173,146,38,43,139,191,124,117,251,151,175,70,109,157,21,107,180,184,169,27,188,121,97,253,6,248,60,199,41,1,174,227,183,184,192,85,150,58,48,135,73,147,196,139,95,243,89,158,225,162,113,94,31,103,197,175,206,195,229,85,133,147,21,60,80,111,116,34,55,155,178,240,191,209,200,143,103,71,139,65,64,39,229,10,231,117,63,232,225,77,145,108,178,20,30,54,198,66,134,193,199,67,167,57,73,178,60,184,114,19,176,250,132,27,128,136,223,55,48,164,201,240,0,236,4,52,0,86,225,208,243,248,240,117,240,213,155,36,109,202,138,205,13,48,223,84,120,13,243,160,89,158,212,245,62,90,224,130,108,35,95,211,162,73,26,76,193,182,237,69,158,165,40,37,80,62,32,180,143,204,49,163,91,58,78,225,7,145,107,146,162,129,57,78,171,236,90,224,29,109,217,15,148,146,247,40,43,26,137,7,87,215,89,138,79,225,207,87,13,200,216,182,169,103,101,11,239,15,208,247,47,134,143,93,102,27,92,182,100,212,179,61,248,175,99,100,93,243,209,103,56,205,182,68,246,235,227,108,147,145,161,207,131,67,235,166,34,60,214,70,47,147,53,140,24,111,224,201,249,134,61,26,119,13,93,96,114,34,223,148,213,188,168,113,213,104,152,8,154,197,209,241,209,108,137,190,189,221,187,251,118,250,237,237,51,250,239,115,250,239,247,244,223,191,221,125,123,79,244,63,87,73,154,99,99,146,91,152,230,46,60,17,122,115,246,243,9,90,181,73,222,57,229,178,202,214,107,92,225,213,17,89,63,231,71,35,30,158,99,242,84,32,248,6,68,137,73,136,41,46,111,50,156,175,66,178,50,231,43,120,213,174,96,155,82,76,52,214,162,108,43,80,141,231,137,243,172,103,166,211,170,220,2,99,224,64,144,217,202,6,184,133,87,98,62,254,51,192,204,37,72,101,78,8,34,122,119,52,90,227,134,255,53,170,63,103,77,122,133,162,247,0,6,146,95,48,157,11,199,242,168,88,103,5,150,127,44,111,182,120,34,6,141,210,164,198,72,127,21,179,61,218,151,16,163,10,55,109,85,244,238,234,11,14,127,23,196,124,178,0,21,191,31,124,125,90,214,205,186,194,4,102,135,201,237,105,87,248,50,105,243,102,223,66,192,184,25,31,193,153,190,225,67,216,8,250,239,157,205,124,147,137,246,207,91,4,124,127,129,106,242,207,221,14,91,77,21,26,159,138,41,183,195,153,216,208,51,188,45,235,12,212,228,205,15,234,33,181,7,47,145,11,227,35,129,163,156,131,185,122,181,205,16,87,72,228,207,48,48,49,109,92,135,240,57,152,174,190,65,246,239,48,142,215,109,254,137,30,187,15,73,158,173,18,128,70,234,175,1,195,78,146,180,42,79,147,10,120,236,127,216,177,214,224,169,20,100,135,223,12,160,236,232,26,52,242,113,73,148,136,255,225,0,28,82,179,43,158,40,101,223,201,167,144,72,157,224,230,170,12,43,170,163,162,221,224,42,185,200,241,15,148,128,87,43,192,82,215,47,209,12,252,165,6,235,207,112,29,233,224,243,19,120,150,172,177,164,111,94,92,150,47,81,37,201,21,106,227,58,169,16,54,240,128,186,45,240,103,116,156,213,141,57,107,52,97,167,237,18,252,128,132,168,39,50,86,98,4,51,232,65,239,224,231,216,117,196,145,28,22,207,87,83,133,36,214,129,248,220,20,223,42,149,203,2,116,138,130,164,70,243,195,153,177,100,62,42,187,68,145,62,234,107,160,162,205,115,165,59,117,18,227,10,111,97,223,147,243,108,5,232,181,97,241,25,123,49,95,25,106,135,98,215,248,0,84,28,125,217,102,204,3,35,68,32,108,252,12,204,170,128,206,87,100,247,15,172,97,177,66,10,39,0,247,145,96,49,2,109,200,41,172,59,230,175,210,109,115,14,242,179,198,231,132,201,7,92,200,36,150,19,242,234,67,82,69,254,13,154,106,51,196,244,200,203,61,227,52,154,98,22,195,95,17,118,119,152,1,115,85,111,14,121,97,232,119,118,70,76,170,233,216,16,221,220,10,75,242,77,234,15,51,106,16,18,80,218,12,112,202,13,205,75,190,48,193,54,78,26,145,98,139,101,156,173,228,169,46,151,198,60,82,138,201,73,96,136,99,102,17,163,47,232,224,37,69,235,96,28,65,100,65,4,226,75,252,19,190,153,10,171,203,2,13,250,24,148,79,139,57,179,39,241,178,36,135,55,154,48,126,250,184,70,140,244,138,250,195,184,250,65,250,173,245,22,252,48,60,3,67,245,82,110,126,13,6,184,230,144,145,174,52,42,227,21,63,214,189,120,133,14,49,71,195,193,90,3,197,48,195,120,94,92,19,69,42,246,28,143,167,200,131,39,230,96,125,216,94,231,73,193,116,119,0,207,44,1,131,146,227,149,2,236,67,121,88,190,43,27,112,34,134,96,53,96,251,87,158,150,21,8,77,51,4,179,9,220,135,250,125,65,53,54,177,12,195,144,83,230,14,66,77,162,243,182,0,165,72,14,15,13,120,122,144,187,3,250,166,16,238,11,240,242,13,188,92,245,76,96,131,247,161,39,225,40,174,234,195,18,150,91,192,160,15,184,202,46,51,220,55,77,104,216,192,233,222,193,137,38,163,8,163,135,205,164,143,232,21,210,150,26,170,166,115,187,37,144,66,71,53,155,137,213,167,62,8,69,220,193,32,206,24,87,22,214,211,72,250,77,232,66,252,165,43,16,136,231,171,134,88,178,247,77,10,234,131,68,218,255,44,11,76,237,7,56,232,215,36,66,130,103,203,18,222,71,18,67,188,16,195,166,150,43,31,207,90,56,17,5,57,111,85,44,176,241,149,145,249,54,26,193,76,91,217,203,224,218,214,138,16,14,172,121,184,254,85,171,59,80,235,179,223,73,98,1,72,95,47,135,91,192,228,196,186,19,63,131,230,141,190,52,177,124,166,105,111,177,51,218,18,124,219,114,93,130,199,114,244,5,167,173,177,25,203,164,254,20,217,107,173,169,3,77,254,212,247,228,66,91,148,130,136,229,122,94,184,144,103,148,122,31,240,153,240,147,232,110,107,75,213,128,229,106,21,100,10,194,215,86,132,99,44,45,40,246,213,252,53,99,80,250,4,198,130,253,219,44,222,68,19,115,32,183,115,186,235,219,107,202,164,45,243,36,13,226,83,152,236,93,187,185,160,150,113,143,193,125,190,202,114,140,34,15,161,241,143,73,77,254,191,44,33,198,76,49,28,72,33,139,221,184,191,251,142,123,88,62,156,175,147,38,189,162,252,238,70,194,81,240,37,202,220,98,12,113,81,76,14,35,68,234,155,164,137,184,215,49,254,23,143,51,9,48,80,123,157,129,110,138,253,66,247,111,146,16,108,144,32,228,175,232,118,239,46,70,99,244,157,192,37,69,5,28,127,116,251,236,110,138,184,60,160,219,231,119,49,168,173,142,117,77,149,8,210,176,65,10,152,30,41,152,103,94,147,187,89,14,202,65,108,224,72,3,139,95,15,58,2,42,174,1,176,121,145,53,135,51,22,235,50,76,145,134,209,59,137,220,155,142,21,134,198,29,227,98,221,92,193,216,112,210,145,15,165,130,220,27,10,106,43,42,64,3,153,115,112,217,29,53,36,204,214,195,134,152,172,90,139,136,171,140,184,23,146,165,74,197,191,197,10,140,168,101,64,74,180,32,249,51,6,85,248,174,252,44,134,40,146,0,70,31,86,43,180,158,128,59,230,127,225,72,139,63,5,60,72,177,28,66,115,203,26,208,20,121,55,158,138,147,103,183,166,254,245,24,43,166,142,211,153,181,142,15,198,67,31,149,70,36,173,199,11,50,12,179,98,125,107,30,137,136,109,77,83,134,226,15,1,231,110,180,162,42,166,90,79,64,14,212,11,187,42,134,83,8,178,147,10,175,136,78,208,84,194,104,172,209,129,92,253,32,14,14,232,7,169,44,230,171,125,116,251,253,29,168,11,107,85,150,138,16,83,116,42,21,71,141,220,161,52,161,201,216,197,175,249,209,151,20,111,169,83,160,165,93,189,12,58,170,170,178,26,196,33,67,206,129,49,111,171,178,221,162,45,177,3,53,45,192,92,194,8,157,23,103,116,189,123,176,126,157,109,58,47,158,129,150,165,104,232,47,166,73,113,64,216,207,108,97,151,136,36,191,60,71,65,202,155,47,149,70,24,64,215,31,133,143,151,165,1,228,92,192,141,227,244,183,5,13,188,105,80,27,141,69,218,15,36,152,78,50,158,208,213,120,32,41,113,167,146,115,148,134,147,122,13,3,4,250,14,143,145,248,95,73,218,4,206,190,92,176,79,120,206,48,104,71,254,80,77,175,116,22,73,206,124,189,147,217,31,126,236,6,159,59,16,173,37,174,54,89,65,28,254,24,189,129,17,112,250,214,68,76,106,148,211,74,21,13,18,201,75,77,176,76,35,205,5,207,20,182,241,212,240,6,61,103,72,21,18,128,201,89,209,98,251,108,105,7,75,252,245,167,59,96,130,240,255,175,131,166,86,245,7,29,184,230,170,146,30,194,93,216,219,61,78,234,134,201,52,223,24,205,119,241,193,207,174,112,250,137,63,132,64,155,31,192,200,178,32,130,10,201,211,127,180,184,186,249,17,231,91,26,110,215,184,145,111,120,168,80,71,129,80,200,14,87,5,106,162,28,118,211,13,58,183,84,213,28,162,229,5,115,55,140,103,181,10,157,39,79,108,210,129,98,180,34,158,54,184,31,250,201,217,178,5,160,164,88,49,15,138,6,89,13,11,231,44,27,191,167,219,248,103,150,170,121,110,168,154,251,155,116,195,153,29,13,136,50,129,175,169,30,111,142,2,41,80,127,210,244,133,239,124,235,209,2,73,245,107,161,133,12,75,27,134,9,94,55,85,171,166,38,18,35,252,188,248,85,113,19,77,52,187,49,50,198,145,77,162,124,240,5,36,74,45,75,11,197,71,234,248,52,127,236,151,43,92,97,150,166,254,66,221,255,44,201,245,144,24,29,28,160,40,43,154,137,86,49,211,242,77,64,76,51,137,65,198,142,192,204,68,55,128,70,78,50,186,241,227,99,232,124,201,171,51,252,107,139,197,145,247,172,232,253,118,197,83,82,148,144,57,236,4,205,56,178,5,234,236,208,42,78,245,212,218,83,133,88,203,18,208,202,69,0,206,103,209,250,172,186,207,148,237,122,246,40,14,84,166,105,91,213,232,243,21,46,104,96,89,163,11,66,77,108,216,115,159,161,123,136,247,40,49,251,141,91,167,114,191,19,126,0,206,107,220,109,240,31,71,63,21,101,175,138,162,52,146,209,76,21,156,150,101,14,82,145,227,164,198,187,171,43,49,131,157,171,216,41,2,97,153,64,250,175,187,56,210,106,161,57,157,202,250,76,245,204,150,119,206,137,47,137,72,115,6,162,242,245,86,55,112,240,118,93,86,55,203,100,93,247,229,118,27,128,209,147,105,28,159,158,118,75,57,58,106,169,21,123,102,242,49,3,37,154,73,7,61,16,169,108,218,17,86,199,36,7,178,97,79,28,74,231,202,104,18,130,232,185,53,91,173,68,205,145,201,95,223,92,102,103,210,160,233,156,102,38,95,149,147,64,251,182,194,219,65,65,13,188,252,105,148,228,88,57,145,121,39,196,26,145,110,59,222,34,65,188,224,31,78,180,247,31,158,203,221,208,135,197,61,201,111,79,2,88,39,206,51,169,111,17,47,249,17,38,242,65,121,91,181,100,192,171,106,221,110,72,134,100,172,147,52,158,26,11,155,152,197,10,31,25,62,94,146,38,61,215,55,234,17,227,172,150,251,39,54,57,32,172,247,16,22,99,25,190,153,254,142,148,6,228,5,17,225,205,47,75,242,47,56,83,155,173,175,52,50,65,251,220,249,245,29,238,64,66,208,74,184,153,213,110,95,10,25,6,136,144,33,242,170,146,254,134,20,58,133,155,33,219,169,147,133,42,78,125,215,220,28,156,5,204,29,153,172,193,27,233,132,144,31,157,62,141,207,9,33,186,23,175,132,229,49,5,211,162,34,88,175,249,17,108,14,47,203,114,223,132,136,170,25,80,223,187,179,167,166,253,15,20,222,234,57,60,64,227,249,187,197,209,217,18,205,223,45,127,70,31,199,39,64,71,5,166,116,161,134,124,28,163,72,189,152,175,62,194,81,252,56,214,141,63,121,34,237,232,248,227,152,199,116,103,2,86,231,22,123,98,6,44,31,199,147,49,227,26,35,207,218,128,218,72,214,218,73,134,192,210,220,146,159,64,55,148,5,39,230,48,31,27,244,69,219,12,25,194,6,114,124,23,228,248,62,128,3,157,171,243,30,72,42,112,100,6,55,106,125,219,194,43,137,159,150,87,136,227,147,213,36,202,45,86,102,231,7,167,72,52,84,243,56,91,139,170,28,16,111,0,109,104,156,121,1,175,90,76,7,68,6,33,254,184,217,139,145,121,253,242,85,23,30,225,154,17,27,244,19,190,161,25,141,211,36,171,100,247,79,121,241,31,128,124,73,26,51,20,101,227,169,181,252,201,112,60,103,198,192,135,96,122,87,54,135,56,207,174,169,185,224,200,246,118,24,111,183,72,220,7,135,234,231,16,99,165,51,213,17,2,13,13,128,252,174,189,87,116,101,244,195,234,171,25,192,40,113,67,41,135,66,159,179,230,10,137,128,71,171,65,10,17,111,14,168,3,175,142,27,197,127,192,146,14,120,106,158,13,113,44,156,61,20,213,50,149,180,186,243,156,67,35,248,247,84,15,237,98,189,30,188,7,170,245,222,240,204,209,132,122,247,165,152,95,184,172,85,146,126,58,79,243,44,253,84,243,140,195,84,127,83,110,113,97,189,200,54,48,190,182,38,159,211,135,2,162,128,253,195,231,105,45,70,50,150,112,191,147,141,138,121,176,16,140,53,236,4,150,217,12,209,169,231,64,147,102,191,97,183,113,216,81,119,130,173,30,63,7,72,11,118,30,199,44,227,51,167,151,83,0,173,165,98,12,161,17,7,32,84,179,237,210,216,94,203,176,147,87,48,69,142,91,65,9,226,77,145,153,105,60,116,31,152,77,75,106,167,109,205,40,121,221,102,249,74,246,252,25,207,28,14,152,136,167,161,59,16,186,209,182,83,154,131,188,96,43,207,125,223,86,101,249,152,134,165,122,99,114,188,44,89,238,59,34,13,150,239,183,91,45,181,23,230,81,204,126,157,149,159,35,13,181,109,201,213,60,202,115,16,154,88,163,193,245,78,167,22,183,140,232,178,131,42,158,70,96,15,253,206,59,149,60,183,122,62,172,165,96,138,92,127,130,202,31,79,114,80,250,196,150,169,206,40,177,21,52,29,169,37,30,205,36,39,59,255,250,74,165,215,47,220,13,187,152,61,36,105,57,216,193,103,167,66,239,191,236,156,150,17,189,251,220,157,173,158,84,253,203,158,85,62,191,229,123,61,112,237,193,214,88,182,126,213,34,250,164,179,123,122,81,201,252,109,81,183,23,143,189,219,239,9,82,109,146,149,108,144,124,236,153,156,214,75,218,124,83,10,109,248,164,242,20,232,143,21,173,112,184,114,90,90,159,148,156,158,62,90,69,150,222,255,250,123,80,228,233,183,13,21,97,137,250,51,99,141,90,117,169,122,234,166,188,249,133,38,35,100,177,180,7,238,16,215,105,149,81,127,154,20,102,135,21,86,13,125,235,156,205,169,166,52,167,62,149,54,181,117,204,212,61,248,83,237,44,242,121,172,115,51,181,37,123,218,41,104,211,208,126,123,205,20,141,82,79,181,32,129,185,118,216,116,235,100,51,154,184,211,27,106,66,211,98,88,22,233,160,45,19,147,54,23,29,81,170,242,103,248,38,203,234,134,91,213,72,93,215,139,79,105,208,36,146,30,129,59,201,194,212,187,96,252,250,49,132,93,173,78,137,19,3,251,228,17,27,178,40,176,249,229,145,164,45,113,173,234,246,97,152,123,136,161,160,214,104,47,31,16,43,118,183,60,220,107,121,8,255,30,43,188,76,242,26,135,163,63,42,178,170,50,59,32,216,235,43,136,249,163,101,57,5,233,195,37,76,218,87,113,49,15,132,101,165,143,150,253,68,185,106,167,174,72,111,39,53,156,12,141,9,218,161,146,7,145,127,4,160,179,33,84,173,151,118,88,253,92,144,106,111,91,225,40,154,16,179,171,29,51,90,174,227,42,198,104,134,209,35,93,177,245,250,123,105,12,19,34,59,228,78,96,184,41,84,36,56,70,198,58,181,210,124,231,113,12,51,213,230,71,135,136,146,228,44,171,79,82,167,158,200,103,63,148,41,208,28,249,67,27,115,158,48,203,163,203,173,158,217,169,25,139,180,228,142,158,211,49,26,203,3,245,236,190,114,182,35,227,78,143,86,71,49,251,145,59,180,66,237,86,180,165,97,64,31,36,133,115,26,178,238,177,237,118,251,80,232,148,27,37,77,5,20,140,45,23,184,225,206,253,144,108,116,70,195,118,243,110,32,243,10,52,19,15,228,183,73,46,175,16,50,168,163,47,219,138,223,42,56,48,196,243,240,66,9,40,169,101,173,152,155,49,43,243,118,83,168,81,238,157,68,145,242,244,211,99,185,138,15,75,79,247,231,97,201,62,31,182,100,175,200,93,73,70,124,76,107,144,17,189,226,60,25,140,41,180,204,30,174,78,194,233,3,182,94,38,7,162,29,106,183,172,21,165,189,255,182,170,213,141,195,69,98,167,236,143,117,151,142,133,19,145,103,182,73,103,70,102,18,182,251,26,75,130,125,73,29,206,0,227,197,142,73,191,251,178,78,51,217,110,129,50,220,223,234,94,109,240,137,64,111,191,213,31,96,92,174,200,42,217,245,112,170,218,202,203,128,157,25,107,78,100,208,83,248,159,51,9,108,19,217,54,220,207,42,200,173,185,204,138,36,207,165,120,116,52,53,18,253,163,219,134,71,112,99,219,148,52,58,61,161,35,59,252,131,29,129,111,253,4,46,97,90,109,90,206,117,76,243,55,163,127,224,61,68,179,207,203,115,219,209,219,251,21,186,245,105,18,226,171,37,25,87,57,45,112,207,125,78,39,77,169,211,27,47,218,141,113,77,95,79,191,233,183,231,131,99,205,251,248,189,41,90,103,188,117,237,222,200,49,154,183,230,131,40,156,235,245,122,155,155,115,221,61,136,198,115,149,222,151,140,236,97,135,121,243,91,67,208,248,138,190,62,20,206,125,123,39,21,231,102,235,130,200,130,183,235,93,164,190,4,95,8,159,113,125,222,205,75,155,62,140,127,219,173,239,76,76,84,191,161,175,61,115,94,191,134,77,254,4,135,79,26,162,133,86,176,100,145,150,214,139,69,148,140,217,16,102,193,46,154,114,11,39,187,223,88,152,201,69,175,125,240,105,124,217,104,67,167,57,73,138,150,104,237,206,20,143,127,200,3,242,33,93,46,190,185,162,46,87,90,126,208,101,147,209,0,80,13,157,162,49,88,12,73,47,165,158,26,182,23,29,174,130,110,112,252,38,30,253,146,212,16,149,83,172,104,195,217,16,91,119,15,204,156,143,110,230,118,115,253,227,71,243,253,237,18,232,96,52,175,77,13,61,118,210,190,195,81,29,58,58,27,176,185,138,124,151,160,196,209,226,99,111,174,122,56,74,91,93,11,164,94,125,63,28,173,171,190,5,226,128,13,216,129,171,174,238,39,108,117,159,14,71,25,106,1,242,90,137,225,104,67,234,94,160,239,180,31,59,79,227,88,12,53,131,91,61,120,112,28,236,215,81,92,15,244,169,26,54,249,14,151,53,223,100,69,86,95,225,213,190,113,229,160,247,2,166,186,21,101,223,35,8,89,54,238,149,242,139,115,234,54,211,1,218,123,36,83,71,3,14,165,49,123,212,249,187,82,53,198,60,134,50,231,215,62,180,226,151,95,147,235,33,123,191,251,239,126,255,177,188,198,85,5,251,105,127,107,71,6,3,180,127,194,169,72,13,72,132,219,62,186,106,91,159,136,175,198,40,231,161,104,50,241,89,204,71,151,73,94,69,24,163,239,208,110,215,130,149,84,58,159,185,153,120,107,4,215,236,147,14,50,49,66,154,176,192,54,94,99,238,99,136,235,10,226,211,15,167,228,106,51,197,120,180,210,122,4,163,240,157,75,123,134,88,212,135,205,121,62,216,96,84,152,31,237,114,178,151,205,199,89,138,137,224,164,228,142,42,189,158,76,110,30,233,220,221,83,49,110,152,165,125,249,135,221,125,74,39,219,32,72,240,192,210,69,164,88,75,54,236,228,58,234,159,217,179,15,148,224,253,136,167,3,68,30,90,146,195,91,158,86,200,190,148,225,87,76,114,156,212,73,114,49,252,26,162,35,44,124,179,248,64,222,208,168,127,140,241,107,163,38,109,168,155,167,21,30,246,201,88,90,120,166,151,252,235,63,157,228,204,242,178,93,105,78,218,159,94,122,136,85,35,251,65,183,131,172,198,47,54,15,51,178,199,73,91,144,175,55,40,38,248,27,253,77,148,116,229,247,136,64,157,154,165,183,14,169,1,241,116,68,87,109,211,134,126,64,224,233,126,251,201,255,137,58,231,110,124,224,235,105,158,219,211,143,205,44,182,149,198,225,232,130,186,63,115,158,48,185,238,85,72,34,203,142,201,199,61,232,123,234,163,203,150,244,203,178,10,164,218,167,82,83,97,127,236,253,228,90,170,179,95,196,93,237,125,141,221,0,109,21,80,86,247,212,85,97,85,213,177,40,174,172,60,213,222,14,194,21,221,218,197,129,161,84,139,24,72,18,222,169,98,181,214,122,49,80,146,109,126,5,215,114,216,173,235,2,210,71,191,72,106,28,235,207,217,210,157,43,178,194,140,250,174,202,122,190,247,206,218,230,7,125,46,222,239,191,218,223,115,103,8,131,223,127,23,116,107,95,145,215,63,55,41,30,50,32,245,25,115,134,85,238,136,124,225,180,248,43,20,29,109,146,54,58,237,149,127,145,225,175,189,91,152,130,128,145,77,142,121,83,217,190,72,205,128,59,111,141,4,162,45,8,161,179,77,82,221,176,226,59,213,14,90,74,90,249,142,230,189,9,237,35,25,246,103,229,197,101,10,135,179,190,207,205,247,98,139,28,10,186,74,93,236,169,249,16,158,253,23,212,25,250,34,63,104,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("aab8c7b4-900b-432a-b80a-d3517da0b687"));
		}

		#endregion

	}

	#endregion

}

