﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SspUserManagementServiceHelperSchema

	/// <exclude/>
	public class SspUserManagementServiceHelperSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SspUserManagementServiceHelperSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SspUserManagementServiceHelperSchema(SspUserManagementServiceHelperSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("6b839ffb-24e7-4bd4-8864-98ed5f5bd62f");
			Name = "SspUserManagementServiceHelper";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("7cc31540-fa76-4c79-9b86-a6eabd8e662c");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,213,91,91,115,219,184,21,126,246,206,236,127,64,212,153,13,53,227,210,221,151,62,172,99,237,200,151,100,213,102,99,215,114,218,135,76,30,96,10,146,208,165,72,5,32,237,213,102,252,223,123,14,46,36,0,94,116,113,234,105,103,50,177,9,2,231,250,157,131,131,3,58,163,43,38,215,52,97,228,142,9,65,101,62,47,226,139,60,155,243,69,41,104,193,243,44,158,78,111,190,255,238,235,247,223,29,149,146,103,11,50,221,200,130,173,78,131,103,88,147,166,44,193,5,50,126,199,50,38,120,210,152,115,73,11,218,24,124,207,179,47,141,193,41,75,74,193,139,77,253,194,149,110,181,202,179,246,55,130,117,141,199,151,231,240,10,94,254,73,176,5,72,73,46,82,42,229,79,100,42,215,31,37,19,191,210,140,46,216,138,101,197,148,137,7,158,176,95,88,186,102,66,173,56,57,57,33,111,100,185,90,81,177,25,153,103,92,67,86,213,34,178,84,211,201,60,23,228,49,23,191,33,255,71,94,44,73,137,243,68,158,50,73,104,54,35,60,123,224,5,147,177,165,122,226,144,93,151,247,41,79,72,130,114,109,21,235,232,171,18,173,214,6,236,94,136,50,41,114,1,74,221,40,82,122,70,40,189,26,152,100,188,224,52,229,127,160,92,36,99,143,32,153,44,104,6,48,200,231,164,88,50,88,194,24,73,4,155,159,13,250,101,25,156,140,180,204,113,197,109,77,5,93,145,12,144,117,54,64,3,128,112,153,198,198,96,52,233,230,243,209,159,122,50,138,223,156,40,82,149,216,158,189,172,193,250,197,139,124,170,196,151,103,72,16,216,71,71,193,164,179,96,26,130,234,232,201,88,156,101,51,109,116,223,3,55,34,7,118,5,103,104,127,145,23,176,146,205,122,92,176,221,224,23,130,81,240,103,139,129,125,51,88,102,196,95,23,62,126,37,11,86,156,18,137,255,61,61,75,176,137,66,241,254,130,153,117,225,227,174,130,169,152,75,42,167,108,229,26,56,53,120,52,92,183,120,245,87,86,44,243,153,114,41,127,160,5,211,111,215,250,129,188,43,249,140,188,99,5,146,150,160,213,56,73,242,50,43,34,53,142,16,154,204,44,194,4,43,74,145,181,76,150,17,134,223,123,46,139,55,184,108,20,217,21,71,154,128,250,253,105,24,191,229,66,22,209,208,133,162,21,99,114,149,149,43,38,232,125,202,52,141,86,54,53,11,35,154,180,156,166,12,83,55,56,64,253,56,83,249,64,143,5,209,51,140,47,129,8,207,224,197,16,51,126,185,202,162,193,77,46,10,154,26,54,147,217,0,68,21,249,42,26,64,42,31,207,86,60,251,8,185,102,48,212,42,197,255,90,50,193,162,129,154,54,201,34,77,35,190,193,40,103,128,5,25,89,209,134,132,74,35,132,82,217,36,245,232,242,252,234,119,216,28,16,208,204,254,114,22,248,54,190,202,100,41,216,229,121,61,20,13,29,179,42,66,19,220,141,110,25,157,1,168,102,245,175,103,198,12,177,102,195,244,112,100,121,213,100,142,30,151,60,101,36,170,215,198,248,195,97,116,116,180,225,44,157,17,227,122,103,34,184,71,107,254,79,154,150,198,103,45,134,60,53,116,158,244,79,253,227,169,5,0,198,129,64,22,28,254,158,39,55,52,249,13,146,161,30,254,71,201,196,38,10,112,216,237,98,195,179,114,111,90,145,27,28,19,229,184,254,25,31,192,147,205,57,32,212,221,102,237,188,168,48,2,111,0,11,99,169,232,212,239,39,32,144,248,91,206,51,59,201,178,168,230,86,3,118,201,181,150,5,133,240,150,184,50,79,228,213,151,146,166,125,106,105,136,134,200,140,0,46,236,142,175,88,252,33,127,196,74,134,13,1,193,242,156,21,143,140,161,144,5,21,5,14,163,128,217,44,26,92,150,76,63,90,186,106,52,96,139,1,138,145,96,164,106,48,133,45,157,53,66,97,247,148,229,237,66,117,98,124,224,162,0,118,14,108,198,235,117,202,217,236,122,141,16,160,233,219,50,75,110,177,104,121,155,11,132,71,79,238,120,160,98,167,196,97,129,128,227,214,226,202,147,106,39,192,7,59,3,25,123,51,112,160,118,80,107,118,169,40,169,180,226,34,39,156,228,5,153,98,101,233,94,59,210,53,115,90,5,156,38,129,182,249,134,166,47,139,222,244,52,211,74,98,101,103,120,190,14,141,83,113,172,103,105,100,91,139,181,242,8,245,53,220,174,67,195,118,82,15,172,237,80,119,209,1,184,117,244,176,111,92,93,252,49,160,109,65,229,18,183,66,248,62,199,64,105,44,191,22,11,187,122,155,51,168,96,250,201,97,101,54,158,214,5,53,78,117,142,10,227,81,21,215,209,143,67,75,75,9,216,74,201,117,0,210,82,249,189,139,224,95,124,130,7,209,248,235,112,232,175,14,117,9,44,29,106,164,23,251,184,219,107,91,54,251,137,108,164,167,190,116,83,151,37,147,108,158,155,140,209,82,52,29,146,92,234,0,232,137,75,187,160,22,196,91,86,165,158,150,247,219,42,28,27,215,110,32,190,103,243,226,26,138,137,238,48,109,19,36,76,76,253,154,213,65,209,161,84,151,45,20,2,58,214,28,20,25,29,180,14,140,13,19,184,13,3,120,58,55,54,78,131,163,111,13,215,198,6,233,98,87,214,168,62,24,193,215,111,167,183,97,178,244,54,193,26,186,227,143,111,111,195,130,171,154,170,7,187,247,74,88,237,111,149,61,201,29,69,114,177,136,107,27,105,182,134,159,85,193,75,216,189,123,148,86,37,96,161,149,107,39,237,89,199,0,196,72,117,24,98,245,218,125,17,234,45,238,44,1,186,32,234,193,229,219,0,85,65,114,252,64,121,138,103,193,177,172,93,100,96,119,40,44,141,142,189,104,124,30,22,253,104,255,223,117,230,135,50,77,163,231,120,235,33,135,84,113,177,100,201,111,32,17,159,241,98,163,82,155,102,133,103,210,176,216,150,246,4,111,157,199,231,36,236,106,113,16,103,122,19,120,207,158,67,113,190,71,8,148,134,31,228,213,25,249,177,62,172,22,75,145,63,26,44,232,230,235,213,239,9,91,235,195,243,169,123,2,61,82,217,14,230,32,184,144,103,157,31,1,77,45,237,144,224,116,126,81,175,140,1,250,167,181,148,175,124,49,77,203,35,86,14,147,81,43,199,225,33,26,60,245,122,232,146,43,57,169,216,40,47,28,19,89,8,158,45,70,54,194,234,247,8,105,125,188,54,49,40,234,61,193,202,213,73,77,205,69,95,155,16,236,154,104,101,127,177,6,136,163,196,55,233,130,84,138,126,218,218,2,177,121,229,51,57,179,171,143,186,23,89,3,57,89,166,187,101,98,99,180,146,102,191,179,244,182,142,58,158,160,55,166,211,143,183,0,10,201,29,45,202,214,38,185,212,39,67,57,24,41,76,228,115,229,211,63,227,24,89,83,136,4,125,161,128,28,8,197,227,122,162,174,103,200,60,165,11,175,81,110,218,226,42,207,40,169,186,78,245,166,37,88,159,74,111,128,141,201,57,70,152,246,254,120,124,121,94,69,88,182,224,25,139,85,62,187,160,153,110,194,155,254,174,180,200,237,74,104,173,217,66,159,53,172,0,177,217,152,74,14,200,132,229,92,196,250,248,59,140,239,114,164,11,72,171,126,211,220,122,115,171,159,80,79,171,205,48,119,143,155,38,40,65,182,134,233,20,163,214,44,101,136,85,201,214,42,48,206,54,86,250,87,13,46,184,253,20,148,103,242,239,76,205,138,117,0,12,235,240,217,33,169,105,120,27,163,171,61,15,40,11,213,243,199,26,195,27,48,187,125,203,220,112,239,183,73,199,81,5,112,115,69,147,165,85,199,221,94,64,244,137,106,29,152,78,82,29,254,161,8,177,186,143,96,94,59,36,170,253,122,76,28,51,216,164,77,88,42,89,55,197,75,192,200,158,20,77,87,221,205,1,173,97,173,192,36,9,215,87,33,58,188,157,11,17,53,128,247,32,43,90,36,75,53,135,218,242,139,80,179,39,170,73,187,166,2,77,113,164,12,78,138,156,36,40,64,243,34,204,93,226,22,146,131,209,100,6,123,36,159,115,72,229,144,67,214,170,144,169,68,1,130,11,86,168,116,143,89,170,73,151,89,112,217,27,159,16,116,131,209,29,34,18,178,209,146,101,221,6,177,4,103,57,201,242,194,152,167,54,77,157,39,149,201,140,116,14,29,79,167,147,209,155,147,74,176,70,142,179,185,103,60,155,41,171,169,195,216,167,207,154,199,49,233,60,154,33,110,181,28,103,16,21,80,214,85,152,213,59,133,27,92,134,100,165,128,118,79,79,138,240,24,198,16,221,18,178,212,88,8,186,137,156,172,35,152,44,211,194,110,185,112,74,194,94,11,166,59,159,145,147,90,244,10,93,192,65,25,250,202,46,125,207,178,69,177,220,59,107,108,133,126,8,160,133,200,203,53,20,30,160,35,203,18,182,43,170,105,141,79,91,41,66,225,0,144,88,149,144,106,239,153,134,57,155,181,109,100,247,121,158,106,97,38,115,179,248,29,74,113,133,66,232,147,55,109,61,118,59,183,140,212,92,235,6,87,162,63,255,236,166,67,51,26,36,194,99,135,186,95,236,135,244,99,87,186,201,12,157,131,210,197,87,171,181,254,146,161,215,220,0,37,194,50,244,249,140,204,1,75,26,85,54,82,160,208,172,246,40,51,150,226,46,53,215,73,94,237,171,251,84,27,147,153,196,84,33,247,204,17,198,37,173,117,3,40,112,165,229,223,227,250,224,197,11,11,228,253,220,130,161,179,164,207,219,114,193,161,149,132,74,16,117,41,174,201,108,187,168,177,42,118,84,54,102,255,87,118,211,161,99,247,72,245,96,54,201,255,255,35,135,167,116,12,59,67,20,105,69,127,218,126,13,107,175,87,142,171,19,136,54,203,14,75,237,241,101,216,119,14,105,13,158,106,39,168,220,19,204,176,46,129,136,100,80,131,145,8,125,171,189,77,120,22,134,85,61,77,249,117,110,96,130,51,91,49,170,118,168,218,126,102,151,65,187,161,60,190,40,145,99,103,109,43,243,189,12,192,200,142,107,67,192,184,229,92,189,241,170,68,152,16,120,10,138,101,85,91,218,130,13,247,230,74,250,31,126,32,182,168,195,113,211,227,181,150,110,57,226,87,103,62,165,207,78,41,184,74,178,205,28,108,82,173,201,147,187,102,219,176,58,59,44,227,246,245,36,218,83,75,111,75,186,145,87,182,183,184,61,82,222,70,216,211,22,113,251,33,59,153,223,124,42,87,215,208,18,14,191,216,245,209,7,95,85,116,94,139,5,205,248,31,212,150,169,240,75,182,232,250,26,104,187,249,186,155,166,81,175,201,182,55,91,255,107,86,226,25,192,100,165,13,64,239,243,178,8,16,181,95,37,48,24,169,47,171,158,139,75,109,210,99,146,223,255,27,20,25,53,239,249,186,110,248,120,117,7,24,98,209,185,29,52,203,26,27,112,200,85,122,139,155,173,181,96,254,139,239,116,181,178,219,55,58,44,248,251,118,57,95,215,79,141,174,245,103,224,119,248,87,71,13,242,237,151,161,187,181,234,12,179,142,251,212,237,93,59,95,150,237,199,118,213,99,144,22,208,170,204,34,247,27,194,86,16,174,187,159,197,217,151,146,201,98,48,50,95,148,18,51,208,60,54,107,41,229,104,210,8,76,205,90,101,41,216,239,172,8,64,193,46,9,203,234,201,52,60,87,140,140,58,170,158,61,223,92,41,29,162,174,207,94,111,181,140,86,86,55,208,180,246,88,110,25,61,52,169,120,10,155,113,17,189,38,175,143,225,31,254,119,250,218,41,32,165,127,102,58,240,16,101,89,134,123,136,87,207,40,1,177,72,209,146,122,55,24,218,110,119,130,175,244,185,119,48,240,122,76,14,111,172,91,244,183,165,145,35,152,30,169,131,71,233,14,218,40,186,85,121,82,125,13,227,88,169,26,219,161,210,8,36,105,115,220,14,77,39,181,202,5,47,2,71,181,10,19,176,220,139,226,215,34,87,247,179,159,1,219,90,252,168,109,92,110,135,239,11,2,49,177,194,34,24,237,138,90,131,10,121,7,0,175,162,2,10,84,108,44,254,118,128,223,147,215,245,221,1,118,214,192,59,0,207,136,26,0,207,189,73,253,248,194,240,195,246,32,175,59,56,80,163,28,2,68,173,151,110,29,232,223,251,209,182,103,95,193,234,229,26,234,91,244,25,194,46,22,115,64,111,7,124,208,155,209,246,94,190,135,112,233,201,234,3,61,212,35,64,187,97,178,19,218,125,82,248,117,117,192,119,59,168,45,59,215,137,187,52,238,105,182,128,56,82,32,6,248,227,135,210,136,32,9,152,40,247,186,152,171,10,100,94,117,214,251,251,241,28,252,8,252,216,96,244,1,236,210,33,64,215,141,157,150,91,163,195,174,153,170,37,110,249,124,172,187,162,150,147,245,208,174,119,59,113,15,23,203,160,162,189,203,137,68,42,213,85,55,17,143,200,160,13,203,100,255,165,135,141,95,123,219,233,174,211,212,122,130,220,57,190,233,47,222,241,246,87,86,231,181,240,15,26,122,63,140,111,249,130,195,150,230,245,223,85,64,140,235,2,30,91,53,189,119,209,250,30,58,136,253,62,243,221,106,29,149,206,104,136,25,155,83,236,5,57,6,217,197,142,151,102,153,89,162,200,181,91,80,139,138,70,49,107,106,19,134,127,38,16,156,124,198,235,181,243,100,144,118,203,22,26,103,48,86,155,184,231,118,93,143,250,131,48,246,31,235,201,215,68,138,56,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("6b839ffb-24e7-4bd4-8864-98ed5f5bd62f"));
		}

		#endregion

	}

	#endregion

}

