namespace Terrasoft.Configuration
{

	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using System;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Reports;

	#region Class: Report1Schema

	/// <exclude/>
	public class Report1Schema : Terrasoft.Reports.ReportSchema
	{

		#region Constructors: Public

		public Report1Schema(ReportSchemaManager reportSchemaManager)
			: base(reportSchemaManager) {
		}

		public Report1Schema(Report1Schema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e529ae9e-7a33-43c5-bf49-71d2560df6ad");
			Name = "Report1";
			ParentSchemaUId = new Guid("2ce1f41f-b577-4786-90a8-905af9595512");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,205,91,219,114,219,200,17,125,119,149,255,1,165,202,3,85,1,40,204,96,6,3,196,151,42,223,228,117,101,157,117,89,214,238,86,178,169,20,72,12,101,198,20,168,2,33,175,189,27,191,236,75,254,34,127,145,255,216,253,163,244,233,1,73,64,32,65,202,146,43,171,11,9,204,244,244,244,229,116,79,207,128,60,58,58,242,238,127,255,250,205,199,11,251,162,152,204,31,222,189,115,68,45,158,119,255,209,98,97,207,71,179,143,199,151,179,217,95,178,115,251,112,122,246,174,124,251,211,135,15,190,247,173,45,23,211,121,241,32,28,242,175,239,61,185,156,85,151,165,125,80,216,203,170,204,102,190,247,234,114,52,155,142,255,108,63,190,153,191,179,197,131,130,120,220,63,234,112,236,204,245,245,124,156,85,196,217,59,90,247,65,50,166,126,109,47,230,101,37,238,31,173,90,86,52,24,55,155,254,196,99,31,150,151,193,235,211,251,71,173,54,71,121,255,168,165,232,221,59,23,44,166,55,158,101,139,133,87,243,247,254,228,189,177,101,153,45,230,147,106,232,218,22,245,187,247,243,221,59,52,157,119,81,78,223,103,149,245,158,218,247,207,62,92,148,118,177,24,126,79,122,47,137,79,95,12,159,218,42,155,206,30,103,69,238,185,203,123,251,142,36,9,179,209,204,122,21,94,197,117,135,189,158,255,232,70,210,197,181,7,63,177,179,153,27,141,171,27,14,151,55,27,30,237,61,252,205,252,226,101,86,158,77,11,182,246,234,238,26,211,63,121,107,199,239,30,207,63,120,227,250,98,127,213,31,207,171,106,126,222,152,191,217,112,29,17,230,69,85,206,103,39,213,71,114,253,202,28,124,251,185,92,190,178,89,110,203,27,177,96,65,110,139,207,201,229,104,59,171,147,143,139,202,158,83,152,45,230,151,229,216,46,86,87,47,179,34,59,179,165,247,143,114,217,181,28,233,66,183,14,218,193,225,50,54,241,83,189,157,46,134,47,138,105,53,69,6,176,79,230,231,23,243,194,22,213,224,176,30,252,233,154,179,175,38,111,206,114,102,171,230,45,126,166,19,111,176,150,212,123,240,192,67,230,59,188,74,134,159,69,85,78,139,179,21,231,19,119,251,96,41,203,27,251,161,26,62,43,198,243,156,154,135,167,111,142,147,225,115,91,57,170,65,97,127,108,228,40,82,239,124,94,224,141,125,65,233,238,180,154,206,72,121,187,24,28,14,79,139,191,78,47,120,196,232,99,101,255,246,119,239,231,72,248,34,74,253,196,15,87,191,138,254,101,100,252,68,251,198,248,66,104,95,152,212,215,177,47,164,47,181,242,99,77,221,169,47,98,26,170,37,13,167,255,144,8,12,53,19,81,26,249,66,41,95,170,16,28,4,13,162,6,186,165,87,17,241,100,24,73,252,105,184,162,87,19,99,26,199,39,165,1,169,240,53,4,136,124,226,38,37,38,73,124,145,16,103,77,215,105,72,132,218,199,36,161,4,133,144,145,31,19,125,72,29,42,246,163,208,135,92,10,130,164,52,220,48,129,132,18,42,245,13,222,136,144,38,36,66,33,137,113,74,162,134,202,167,201,13,169,70,98,8,168,74,66,144,192,146,102,34,85,72,20,86,74,163,7,58,105,140,133,140,52,83,156,56,125,208,76,134,9,121,18,69,150,34,70,66,144,98,116,105,248,10,195,164,32,109,201,26,34,245,105,32,73,72,148,2,13,78,31,137,91,109,184,73,132,198,89,140,134,233,152,85,137,18,159,236,32,67,71,32,195,196,143,35,167,31,36,74,72,18,226,11,67,75,69,183,33,91,76,249,138,219,98,106,130,49,97,126,250,55,210,57,16,226,27,216,54,246,73,63,8,45,53,59,64,152,132,164,34,42,229,220,106,48,131,240,137,22,92,66,215,2,28,36,41,236,159,24,30,204,242,99,10,13,171,9,19,249,152,72,51,27,56,27,150,162,238,80,112,55,28,75,150,134,48,68,41,21,221,18,190,200,68,74,212,64,209,172,45,105,0,183,193,169,44,63,219,207,64,96,80,1,42,196,151,228,53,138,253,34,100,202,136,20,76,160,96,54,120,139,134,199,154,39,37,240,49,120,129,82,193,104,80,9,179,145,161,112,66,71,14,62,161,114,204,98,227,3,124,48,20,180,80,41,59,26,148,240,50,155,152,16,2,217,57,98,48,53,16,197,64,1,192,8,104,44,147,97,61,100,24,173,174,21,107,71,50,1,233,146,12,21,99,38,41,18,198,131,224,59,2,20,172,152,26,135,17,216,30,184,32,187,35,228,72,109,204,146,112,136,65,45,204,4,76,16,194,225,142,68,243,165,8,57,66,217,9,154,113,19,59,37,33,160,0,240,1,22,5,88,2,215,74,177,179,18,154,15,8,86,64,173,72,37,79,68,60,232,149,196,1,8,201,178,136,118,137,44,193,214,161,92,33,234,56,9,235,97,9,232,73,139,20,14,118,110,129,18,192,33,13,103,25,32,40,41,228,208,137,192,71,64,201,212,153,69,2,254,132,98,70,162,84,156,107,4,16,199,192,34,73,29,242,164,142,124,66,61,92,128,127,128,12,145,165,152,103,92,131,139,172,193,64,15,57,104,36,135,122,236,180,76,99,231,210,212,197,42,242,12,166,135,13,16,84,224,9,173,64,22,66,93,205,50,3,130,218,229,10,122,83,177,115,80,108,88,42,8,155,8,206,63,146,124,230,66,147,44,132,6,114,122,234,16,28,11,78,184,176,59,18,132,72,20,83,75,204,194,104,136,144,95,112,133,168,73,128,68,197,62,118,225,107,16,149,46,135,208,180,64,51,241,2,122,18,206,194,194,121,21,110,14,53,27,83,185,252,10,207,167,46,186,144,86,148,96,43,144,33,83,166,174,209,5,158,228,30,186,34,136,131,64,184,124,207,99,72,44,152,33,116,41,88,176,209,33,62,235,143,120,165,180,163,150,195,136,23,39,5,229,34,55,113,193,10,255,161,75,58,227,72,206,188,72,102,192,60,1,151,248,195,255,164,19,249,150,151,43,70,48,132,167,144,71,228,144,224,0,3,194,34,70,178,101,165,169,5,83,176,93,107,204,1,224,33,2,17,142,5,90,133,131,25,247,73,246,147,214,46,241,33,129,70,46,74,37,103,20,193,137,28,246,115,157,8,24,16,210,0,182,27,86,54,54,188,91,84,144,162,84,61,57,240,169,88,32,106,230,165,77,249,46,17,35,255,145,80,88,241,82,94,4,105,17,195,172,202,161,28,202,106,220,18,172,56,171,192,119,36,40,25,5,48,119,9,25,115,196,110,117,78,225,74,9,247,196,17,139,4,38,208,140,205,207,11,177,100,46,78,95,33,181,211,133,36,76,145,104,217,240,81,237,64,233,114,51,176,7,148,243,162,131,117,128,140,133,204,12,152,82,111,194,13,228,10,152,52,114,73,10,25,4,211,32,233,64,24,210,18,72,128,233,217,76,96,110,88,23,120,13,193,8,179,9,78,252,156,59,67,54,9,114,29,233,7,46,100,4,104,75,182,198,18,171,93,44,201,58,65,96,69,117,177,150,0,167,112,58,138,11,200,14,255,35,111,199,169,95,47,193,177,115,57,214,45,158,153,253,204,226,146,240,42,117,34,184,37,89,241,218,47,128,61,178,9,71,170,168,115,130,211,162,94,9,56,22,141,75,92,140,31,50,173,118,126,55,188,70,193,16,72,95,34,137,88,77,89,39,248,58,21,35,7,35,35,224,86,187,192,215,110,1,0,138,208,2,16,82,42,69,233,3,103,242,202,137,212,41,125,70,6,171,136,34,97,233,112,126,131,193,56,91,72,142,12,228,52,196,168,116,105,18,58,164,181,188,28,136,20,93,17,0,151,26,94,135,93,42,114,9,133,139,18,146,165,86,157,107,4,197,234,107,78,142,233,178,208,137,57,54,97,66,24,159,23,186,186,156,9,19,151,58,41,101,212,161,71,246,72,120,141,68,206,134,119,40,180,98,197,139,52,74,49,87,66,74,94,57,149,169,147,124,202,9,223,153,195,184,0,35,181,121,81,114,181,130,144,174,204,19,228,45,76,11,237,176,202,81,126,98,71,213,203,55,92,26,38,174,104,50,28,102,80,21,229,12,103,4,106,141,99,159,139,3,205,196,48,28,88,162,142,67,14,84,174,128,227,46,68,150,170,77,157,186,149,8,18,80,250,138,92,43,140,71,186,193,121,48,146,118,24,192,16,84,100,9,215,90,224,143,100,77,114,166,166,150,211,37,121,46,205,140,91,42,19,87,11,98,17,37,171,27,87,192,16,251,68,186,106,180,206,186,68,150,186,224,22,174,16,224,98,33,118,222,48,174,152,225,86,205,168,228,108,132,112,128,69,64,9,75,33,43,38,145,67,10,165,122,46,190,129,62,168,1,113,34,151,152,34,151,156,56,177,187,232,102,202,180,46,64,99,159,195,33,101,15,50,36,18,84,139,176,33,228,8,93,242,231,34,43,140,24,83,40,28,176,24,3,146,100,1,24,155,235,46,129,1,9,99,148,203,162,208,229,83,70,64,228,170,124,158,149,74,100,4,45,164,64,149,154,212,92,221,190,230,211,33,118,124,188,29,108,110,203,60,108,135,182,236,94,79,108,57,93,157,27,209,70,246,202,86,112,208,222,176,45,55,148,203,159,79,237,219,210,86,151,101,225,93,17,160,49,230,211,198,253,232,251,249,52,247,54,238,95,59,187,92,119,186,212,175,82,235,60,106,208,20,153,89,172,142,76,118,114,105,29,181,116,25,53,207,62,118,242,186,122,114,210,101,231,78,192,118,50,170,143,143,182,140,199,57,216,190,44,136,118,11,23,62,15,219,151,13,136,123,248,200,91,226,19,221,140,207,234,172,107,15,54,203,3,178,13,216,105,29,85,237,195,170,113,46,212,101,215,56,32,186,49,175,171,135,87,183,195,176,125,138,117,19,158,131,65,125,212,179,10,239,151,243,220,206,134,47,78,46,47,48,126,29,255,135,131,70,60,28,30,14,31,91,138,25,116,223,136,223,86,70,71,71,94,235,198,229,142,45,253,141,36,52,172,85,93,12,31,229,249,235,172,56,179,131,61,141,131,83,169,238,9,217,149,68,240,169,227,144,122,218,167,23,83,242,3,149,77,199,91,8,190,178,211,179,183,213,49,17,169,36,29,42,147,202,109,148,120,170,64,100,7,238,246,96,11,213,171,44,207,221,97,221,6,253,94,209,178,80,225,204,174,166,194,179,134,65,232,123,171,63,8,186,77,149,55,25,184,30,232,100,98,115,17,103,129,208,147,113,160,242,201,40,24,37,163,36,152,36,210,24,155,106,90,67,243,109,194,225,224,240,209,108,122,86,156,19,2,136,217,54,241,90,116,200,236,95,219,73,213,131,130,85,238,239,3,194,138,232,139,97,97,149,182,186,112,88,79,190,29,17,107,154,53,40,250,233,150,144,88,181,116,12,191,166,253,2,192,88,51,175,177,145,152,88,219,48,20,129,142,243,36,80,169,82,65,50,150,49,161,132,54,167,70,88,67,123,189,30,17,191,20,60,154,203,121,31,66,154,116,61,126,106,145,245,187,170,69,186,244,86,179,177,99,141,214,136,47,224,179,22,255,218,109,17,109,59,70,137,206,3,173,99,10,233,68,153,32,155,8,75,47,70,132,163,36,54,147,56,236,23,244,75,121,206,101,215,62,159,57,138,30,111,213,4,203,167,183,199,179,121,86,117,13,138,167,18,139,225,171,57,201,201,20,131,56,30,10,165,19,117,236,123,34,26,210,206,68,152,174,49,107,222,75,199,186,219,142,165,106,42,170,224,174,145,113,150,69,223,62,203,15,234,200,110,202,169,167,61,161,69,245,184,86,184,94,132,159,150,217,143,240,6,119,13,40,52,73,65,90,119,124,79,153,120,40,245,86,61,107,184,200,92,103,54,167,216,30,75,49,9,200,72,50,72,38,42,13,84,40,244,72,171,81,76,8,58,216,229,84,200,188,211,175,32,26,162,130,187,174,225,48,102,31,203,113,237,236,239,67,37,247,162,138,182,184,129,21,217,129,81,166,105,65,9,45,155,209,196,180,181,59,194,81,30,141,101,154,6,147,40,83,129,18,233,56,72,133,200,3,43,38,113,166,67,61,25,101,221,5,121,205,229,59,78,96,196,72,60,221,229,51,182,214,78,167,49,213,46,101,29,209,203,203,25,158,6,22,80,185,42,47,109,15,105,203,48,220,180,89,39,71,93,155,102,156,140,117,166,198,38,24,101,214,144,105,180,8,178,112,164,2,51,150,102,164,132,178,121,110,122,217,80,186,2,159,73,190,200,240,239,45,95,60,220,254,80,254,80,100,19,15,111,232,231,119,188,16,9,222,38,117,7,222,60,190,169,27,214,189,76,205,99,178,230,136,3,239,143,109,176,29,244,9,121,77,7,202,189,28,40,247,113,160,220,223,129,178,235,64,185,93,41,185,198,118,40,18,43,69,48,178,210,6,106,164,194,32,17,113,20,200,40,140,117,52,137,77,28,245,224,64,182,28,232,156,183,217,51,75,103,174,252,220,162,64,171,151,47,248,61,243,26,244,94,3,24,93,167,1,37,94,94,115,225,121,107,224,172,113,132,23,207,17,244,169,113,77,23,71,123,185,56,218,199,197,81,215,111,209,118,73,163,165,223,114,59,50,98,172,227,64,83,1,17,40,149,198,65,50,154,200,64,234,196,134,209,40,83,145,181,189,108,106,191,237,55,233,126,230,89,85,231,125,214,89,17,245,24,103,77,115,147,162,194,132,67,157,116,151,218,53,243,165,225,87,45,29,19,172,105,175,179,200,235,100,168,100,223,196,181,15,227,73,172,226,68,71,65,98,13,170,194,145,12,210,112,66,43,76,20,135,99,105,165,210,170,91,204,55,184,212,46,220,40,126,103,3,215,58,170,233,221,197,181,40,169,10,45,115,91,62,153,207,230,229,250,243,41,75,213,185,153,12,48,123,111,203,254,195,161,154,15,142,95,7,131,109,197,171,163,57,153,230,246,112,31,162,33,106,91,239,95,91,107,225,6,37,21,194,135,135,59,206,175,134,199,243,162,218,236,98,244,12,14,190,181,101,158,21,217,129,239,37,40,226,252,77,84,142,211,107,123,118,57,203,202,14,197,243,50,187,120,59,29,47,78,139,105,229,96,235,147,57,240,209,156,195,129,12,213,110,17,87,251,209,86,115,119,199,215,30,117,253,93,78,66,58,18,144,249,111,243,206,180,61,195,231,109,79,94,78,243,124,102,119,236,80,26,7,110,125,176,109,144,93,195,145,34,25,154,94,79,62,158,207,242,91,112,99,91,186,210,246,198,211,113,57,63,127,84,158,141,6,131,1,177,166,80,168,89,135,196,248,16,51,181,90,19,181,177,89,196,26,237,189,146,44,209,212,104,235,64,169,73,255,5,189,124,245,188,118,103,134,106,202,245,56,27,191,251,44,139,74,181,217,166,59,218,119,158,54,223,48,107,118,57,253,14,243,230,231,5,220,174,204,121,75,241,182,65,194,91,13,186,158,214,221,178,180,146,120,95,236,117,70,126,169,68,126,91,65,254,132,46,91,152,222,24,230,237,167,40,59,35,189,77,126,131,96,215,122,115,80,247,183,239,243,36,232,134,241,190,145,217,239,48,228,175,200,121,187,81,191,231,148,255,223,48,190,34,78,43,146,219,125,155,131,249,202,248,47,26,107,245,135,227,123,207,227,51,218,104,239,123,242,7,226,29,71,126,238,41,84,223,65,222,234,89,68,31,81,243,228,187,123,222,247,36,187,224,111,9,145,221,127,253,207,111,191,252,246,239,95,255,251,219,47,221,189,219,246,237,165,99,188,216,12,221,149,205,107,170,1,62,145,229,181,94,58,18,45,97,80,91,188,35,202,43,74,89,217,153,117,17,189,122,78,59,155,217,49,20,89,12,159,219,194,150,211,241,240,197,211,41,183,100,229,199,251,53,217,243,203,41,173,135,238,235,2,15,15,87,159,63,193,152,234,155,209,63,137,195,224,224,15,173,73,14,54,96,183,238,59,125,145,183,149,6,247,193,129,30,217,40,77,147,81,48,214,227,40,80,114,52,10,178,80,140,3,105,149,80,105,168,211,44,53,7,27,120,158,217,175,150,231,2,210,164,106,19,193,119,211,188,122,139,126,161,211,171,253,206,90,88,211,187,200,111,192,110,77,70,97,80,84,111,23,223,76,30,189,156,206,102,211,115,91,117,243,233,201,184,156,94,84,175,237,196,150,182,32,59,173,190,89,113,208,249,202,68,62,155,225,88,168,217,94,218,110,235,82,20,234,232,56,214,205,182,56,97,159,96,146,203,5,102,115,214,189,7,62,205,134,77,62,239,18,61,205,170,236,158,183,110,134,36,221,163,175,166,38,247,218,196,107,101,54,118,212,250,108,236,235,206,195,54,121,70,17,129,47,148,56,177,186,86,40,178,139,231,229,52,199,65,8,25,33,18,216,83,117,136,144,240,78,222,90,91,93,251,161,48,15,221,145,121,218,251,209,190,228,210,200,191,189,137,234,74,93,180,147,182,157,218,55,60,160,174,159,237,152,201,200,232,8,15,19,140,14,84,24,166,56,122,213,65,148,10,29,218,36,55,42,142,59,22,222,18,184,86,203,52,179,169,13,76,22,81,224,70,99,29,140,240,156,200,136,92,234,56,204,39,113,150,119,3,247,116,129,74,165,40,28,18,61,247,45,165,171,68,245,151,60,33,177,8,135,173,147,228,207,255,232,202,179,34,191,141,15,174,92,101,243,233,238,29,250,251,31,198,180,25,118,203,58,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreatetableCell1LocalizableString());
			LocalizableStrings.Add(CreatetableCell2LocalizableString());
			LocalizableStrings.Add(CreatetableCell3LocalizableString());
			LocalizableStrings.Add(CreatecheckBox1LocalizableString());
		}

		protected virtual SchemaLocalizableString CreatetableCell1LocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("c8c5a4c7-bae7-4151-a0b4-7c27b414edd7"),
				Name = "tableCell1",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("e529ae9e-7a33-43c5-bf49-71d2560df6ad"),
				ModifiedInSchemaUId = new Guid("e529ae9e-7a33-43c5-bf49-71d2560df6ad")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreatetableCell2LocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("0b018e21-be2e-4b40-8163-230653f67631"),
				Name = "tableCell2",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("e529ae9e-7a33-43c5-bf49-71d2560df6ad"),
				ModifiedInSchemaUId = new Guid("e529ae9e-7a33-43c5-bf49-71d2560df6ad")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreatetableCell3LocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("deb71c56-510b-4496-8bf2-258e03ba43ee"),
				Name = "tableCell3",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("e529ae9e-7a33-43c5-bf49-71d2560df6ad"),
				ModifiedInSchemaUId = new Guid("e529ae9e-7a33-43c5-bf49-71d2560df6ad")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreatecheckBox1LocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("6f646853-8e7c-48b2-90f4-4360c2e24545"),
				Name = "checkBox1",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("e529ae9e-7a33-43c5-bf49-71d2560df6ad"),
				ModifiedInSchemaUId = new Guid("e529ae9e-7a33-43c5-bf49-71d2560df6ad")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e529ae9e-7a33-43c5-bf49-71d2560df6ad"));
		}

		#endregion

	}

	#endregion

	#region Class: Report1

	/// <exclude/>
	/// <XRTypeInfo>
///   <AssemblyFullName>igkrhzxx, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null</AssemblyFullName>
///   <AssemblyLocation />
///   <TypeName>Report1</TypeName>
///   <Localization>ru-RU</Localization>
/// </XRTypeInfo>

public class Report1 : Terrasoft.Reports.Report {
    private DevExpress.XtraReports.UI.DetailBand Detail;
    private DevExpress.XtraReports.UI.XRTable table1;
    private DevExpress.XtraReports.UI.XRTableRow tableRow1;
    private DevExpress.XtraReports.UI.XRTableCell tableCell1;
    private DevExpress.XtraReports.UI.XRTableCell tableCell2;
    private DevExpress.XtraReports.UI.XRTableCell tableCell3;
    private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
    private DevExpress.XtraReports.UI.XRCheckBox checkBox1;
    private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
    private DevExpress.XtraReports.UI.XRControlStyle TableCellStyle;
    private DevExpress.XtraReports.UI.XRControlStyle HeaderStyle;
    private DevExpress.XtraReports.UI.XRControlStyle TableHeaderStyle;
    private DevExpress.XtraReports.UI.XRControlStyle TableSubHeaderStyle;
    private System.Resources.ResourceManager _resources;
    public Report1() {
        this.InitializeComponent();
    }
    private System.Resources.ResourceManager resources {
        get {
            if (_resources == null) {
                string resourceString = System.Text.Encoding.UTF8.GetString(new Terrasoft.Common.CompressionUtilities().UnZip(new byte[] {31,139,8,0,0,0,0,0,4,0,237,85,77,115,179,56,12,254,65,239,161,152,132,109,57,236,193,144,240,85,112,3,1,243,113,139,161,37,1,147,176,77,2,132,95,191,50,233,36,221,158,186,151,190,135,93,102,36,123,60,200,146,30,61,146,199,227,123,215,149,75,140,177,30,128,194,204,32,74,62,11,56,91,43,235,44,33,93,145,56,85,150,120,231,168,161,35,155,209,75,42,211,117,22,27,117,150,216,71,219,68,99,42,171,23,102,242,157,171,107,113,150,56,227,38,86,207,171,208,63,123,250,188,119,43,124,180,151,4,49,43,64,121,19,169,172,161,168,176,156,45,211,251,50,178,232,14,236,170,181,76,21,106,170,239,89,60,87,211,42,159,165,33,173,72,152,14,47,161,39,101,33,158,191,172,73,248,154,16,41,139,165,207,49,140,46,119,16,219,7,45,139,233,61,78,74,120,129,109,145,134,38,20,246,65,158,37,61,154,241,177,48,233,201,173,73,199,204,129,167,51,176,147,149,209,173,11,14,49,93,54,177,119,14,32,150,194,228,29,107,140,203,107,140,47,49,58,221,252,6,51,218,102,16,51,75,72,197,102,206,113,19,67,238,70,198,243,61,129,123,230,42,185,230,10,57,247,165,63,163,199,194,162,151,44,68,231,44,161,82,222,24,71,192,198,47,98,97,71,220,44,225,17,147,79,156,85,104,71,198,98,75,98,15,145,106,169,120,99,192,189,69,169,36,235,129,221,226,229,4,236,249,57,187,252,144,111,42,253,80,77,177,101,31,234,169,68,154,15,245,210,250,26,91,62,222,96,173,197,150,135,221,82,243,177,185,196,105,175,189,139,53,235,53,46,206,167,111,249,81,215,213,3,124,79,215,58,95,139,61,237,231,216,184,213,205,151,213,35,51,233,181,174,123,168,177,76,1,23,167,77,47,202,18,240,144,68,94,105,226,40,233,194,97,49,186,241,222,42,98,94,67,238,167,92,38,93,222,12,109,186,235,75,10,60,201,101,184,167,146,164,43,222,128,133,174,45,138,120,144,128,123,124,21,43,188,72,130,75,26,247,80,31,13,165,194,78,58,241,87,26,116,27,240,187,138,237,25,145,151,40,29,35,217,11,235,145,152,81,255,178,224,133,107,220,121,22,205,2,224,162,178,255,41,223,137,47,128,196,214,237,254,114,187,96,50,234,1,19,158,151,91,59,77,200,33,146,249,31,153,143,4,119,226,52,30,80,70,181,237,6,56,129,49,212,163,223,249,152,222,112,3,219,225,152,125,224,154,95,20,43,131,184,128,191,213,189,207,136,145,39,116,11,28,145,94,35,232,197,68,219,230,112,158,46,140,223,134,127,226,87,245,247,114,16,119,101,91,102,81,30,153,70,155,55,255,213,25,129,216,7,111,28,92,138,37,191,238,251,169,7,117,161,235,239,245,224,13,219,32,49,16,112,171,45,44,126,231,95,131,135,223,134,47,149,174,179,169,255,152,57,254,77,45,230,229,183,114,251,218,47,165,199,79,247,154,213,5,218,196,254,207,204,90,152,233,159,122,43,4,251,150,53,249,15,249,70,133,182,26,197,160,222,253,223,99,255,138,127,83,31,97,248,231,213,167,242,196,35,223,211,244,47,51,82,91,117,226,13,116,191,240,202,157,108,185,186,5,217,129,84,32,53,8,7,105,64,246,32,7,144,22,228,47,144,119,252,207,207,214,250,92,199,165,125,149,195,57,155,163,110,49,176,147,126,208,250,179,31,213,70,211,230,166,54,245,126,160,195,27,193,241,219,126,122,140,133,194,111,149,88,30,133,42,105,90,117,253,114,40,164,181,50,60,118,210,97,176,141,174,76,157,169,183,150,98,182,71,154,42,82,120,24,167,183,92,125,19,123,113,160,202,79,167,23,115,229,234,139,208,213,149,135,183,253,209,86,150,15,90,57,13,153,133,143,28,130,223,86,159,124,186,55,159,47,191,248,89,193,79,100,144,204,103,244,156,62,238,141,93,251,171,79,87,83,102,104,187,14,253,227,159,127,3,44,86,121,183,244,10,0,0,}));
this._resources = new DevExpress.XtraReports.Serialization.XRResourceManager(resourceString);
            }
            return this._resources;
        }
    }
    private void InitializeComponent() {
        this.Detail = new DevExpress.XtraReports.UI.DetailBand();
        this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
        this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
        this.table1 = new DevExpress.XtraReports.UI.XRTable();
        this.tableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
        this.tableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
        this.tableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
        this.tableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
        this.checkBox1 = new DevExpress.XtraReports.UI.XRCheckBox();
        this.TableCellStyle = new DevExpress.XtraReports.UI.XRControlStyle();
        this.HeaderStyle = new DevExpress.XtraReports.UI.XRControlStyle();
        this.TableHeaderStyle = new DevExpress.XtraReports.UI.XRControlStyle();
        this.TableSubHeaderStyle = new DevExpress.XtraReports.UI.XRControlStyle();
        ((System.ComponentModel.ISupportInitialize)(this.table1)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
        // 
        // Detail
        // 
        this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
                    this.table1});
        this.Detail.Dpi = 254F;
        this.Detail.HeightF = 489.4792F;
        this.Detail.Name = "Detail";
        this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254F);
        this.Detail.Tag = "58fed16a-15fc-4dfb-b8b8-f8277e95144d";
        this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
        // 
        // TopMargin
        // 
        this.TopMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
                    this.checkBox1});
        this.TopMargin.Dpi = 254F;
        this.TopMargin.HeightF = 254F;
        this.TopMargin.Name = "TopMargin";
        this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254F);
        this.TopMargin.Tag = "8765e001-56d8-4944-8c26-4d17871e7225";
        this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
        // 
        // BottomMargin
        // 
        this.BottomMargin.Dpi = 254F;
        this.BottomMargin.HeightF = 254F;
        this.BottomMargin.Name = "BottomMargin";
        this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 254F);
        this.BottomMargin.Tag = "3179b85d-556c-4847-af1e-af710b867f60";
        this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
        // 
        // table1
        // 
        this.table1.Dpi = 254F;
        this.table1.LocationFloat = new DevExpress.Utils.PointFloat(66.14584F, 13.22917F);
        this.table1.Name = "table1";
        this.table1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
                    this.tableRow1});
        this.table1.SizeF = new System.Drawing.SizeF(1783.292F, 476.25F);
        this.table1.Tag = "2d5aed44-c21f-4582-8f49-4015b54b6484";
        // 
        // tableRow1
        // 
        this.tableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
                    this.tableCell1,
                    this.tableCell2,
                    this.tableCell3});
        this.tableRow1.Dpi = 254F;
        this.tableRow1.Name = "tableRow1";
        this.tableRow1.Tag = "0bd3c299-f3a4-419c-911d-e1f6a505fbad";
        this.tableRow1.Weight = 1D;
        // 
        // tableCell1
        // 
        this.tableCell1.Dpi = 254F;
        this.tableCell1.Multiline = true;
        this.tableCell1.Name = "tableCell1";
        this.tableCell1.Tag = "c8c5a4c7-bae7-4151-a0b4-7c27b414edd7";
        this.tableCell1.Text = "fdsafdsa fdsa fds afds\r\naf \r\ndsaf\r\nd\r\nsa \r\nf\r\ndsa\r\n f\r\n\r\ndsa \r\nf\r\n\r\nsd\r\na\r\nf\r\ndsa" +
            "";
        this.tableCell1.Weight = 1D;
        // 
        // tableCell2
        // 
        this.tableCell2.Dpi = 254F;
        this.tableCell2.Multiline = true;
        this.tableCell2.Name = "tableCell2";
        this.tableCell2.Tag = "0b018e21-be2e-4b40-8163-230653f67631";
        this.tableCell2.Text = "fdsa fdsa \r\nf\r\ndsa\r\n f\r\nds\r\nafdsafdsa f\r\ndsa\r\n fdsaf dsfdsafa \r\nds\r\na fdsafdsa fd" +
            "s af ddsa\r\n\r\nfds afdsa fdsa fdsa fd sa\r\n";
        this.tableCell2.Weight = 1D;
        // 
        // tableCell3
        // 
        this.tableCell3.Dpi = 254F;
        this.tableCell3.Name = "tableCell3";
        this.tableCell3.Tag = "deb71c56-510b-4496-8bf2-258e03ba43ee";
        this.tableCell3.Text = "tableCell3";
        this.tableCell3.Weight = 1D;
        // 
        // checkBox1
        // 
        this.checkBox1.Dpi = 254F;
        this.checkBox1.LocationFloat = new DevExpress.Utils.PointFloat(66.14584F, 170.58F);
        this.checkBox1.Name = "checkBox1";
        this.checkBox1.SizeF = new System.Drawing.SizeF(1783.292F, 58.42F);
        this.checkBox1.Tag = "6f646853-8e7c-48b2-90f4-4360c2e24545";
        this.checkBox1.Text = "checkBox1";
        // 
        // TableCellStyle
        // 
        this.TableCellStyle.BorderColor = System.Drawing.Color.Silver;
        this.TableCellStyle.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)));
        this.TableCellStyle.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        this.TableCellStyle.Name = "TableCellStyle";
        this.TableCellStyle.Padding = new DevExpress.XtraPrinting.PaddingInfo(8, 8, 5, 5, 254F);
        this.TableCellStyle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        // 
        // HeaderStyle
        // 
        this.HeaderStyle.Font = new System.Drawing.Font("Verdana", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        this.HeaderStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(165)))));
        this.HeaderStyle.Name = "HeaderStyle";
        this.HeaderStyle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        // 
        // TableHeaderStyle
        // 
        this.TableHeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
        this.TableHeaderStyle.BorderColor = System.Drawing.Color.Silver;
        this.TableHeaderStyle.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)));
        this.TableHeaderStyle.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        this.TableHeaderStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
        this.TableHeaderStyle.Name = "TableHeaderStyle";
        this.TableHeaderStyle.Padding = new DevExpress.XtraPrinting.PaddingInfo(8, 8, 5, 5, 254F);
        this.TableHeaderStyle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        // 
        // TableSubHeaderStyle
        // 
        this.TableSubHeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
        this.TableSubHeaderStyle.BorderColor = System.Drawing.Color.Silver;
        this.TableSubHeaderStyle.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)));
        this.TableSubHeaderStyle.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
        this.TableSubHeaderStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
        this.TableSubHeaderStyle.Name = "TableSubHeaderStyle";
        this.TableSubHeaderStyle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        // 
        // Report1
        // 
        this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
                    this.Detail,
                    this.TopMargin,
                    this.BottomMargin});
        this.Caption = "Отчет1";
        this.Dpi = 254F;
        this.Margins = new System.Drawing.Printing.Margins(254, 254, 254, 254);
        this.Name = "Report1";
        this.Packages = ((System.Collections.Generic.IDictionary<System.Guid, string>)(resources.GetObject("$this.Packages")));
        this.PackageUId = new System.Guid("5be3998b-c5c3-42bb-a01c-2e4149059a97");
        this.PageHeight = 2794;
        this.PageWidth = 2159;
        this.ReportUnit = DevExpress.XtraReports.UI.ReportUnit.TenthsOfAMillimeter;
        this.ScriptReferencesString = "Terrasoft.Common.dll\r\nTerrasoft.Core.dll\r\nTerrasoft.Reports.dll";
        this.ScriptsSource = "using System;\r\nusing System.Collections.Generic;\r\nusing System.Data; \r\nusing Terr" +
            "asoft.Common;\r\nusing Terrasoft.Core;\r\nusing Terrasoft.Reports;\r\nusing Terrasoft." +
            "Core.Entities; \r\n";
        this.SnapGridSize = 31.75F;
        this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
                    this.TableCellStyle,
                    this.HeaderStyle,
                    this.TableHeaderStyle,
                    this.TableSubHeaderStyle});
        this.Tag = "27fb7539-f375-4009-be25-39150e8d7466";
        this.UId = new System.Guid("e529ae9e-7a33-43c5-bf49-71d2560df6ad");
        this.UserConnection = null;
        this.Version = "10.2";
        ((System.ComponentModel.ISupportInitialize)(this.table1)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
    }
}

	#endregion

}

