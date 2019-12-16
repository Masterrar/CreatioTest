﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: EmailMiningServiceProxySchema

	/// <exclude/>
	public class EmailMiningServiceProxySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public EmailMiningServiceProxySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public EmailMiningServiceProxySchema(EmailMiningServiceProxySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e91d9edc-05b9-4672-95b3-5fa7bd473efa");
			Name = "EmailMiningServiceProxy";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("bae6174e-6d8e-4782-b180-300a95031ded");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,205,89,109,111,220,54,18,254,188,5,250,31,24,29,208,106,129,61,217,41,238,128,131,179,222,194,111,73,182,137,29,35,235,220,1,87,20,6,87,75,239,234,34,81,42,73,217,217,115,253,223,111,134,111,162,100,201,177,211,11,144,126,72,87,124,25,14,103,158,153,121,134,230,180,96,178,162,41,35,23,76,8,42,203,43,149,28,149,252,42,91,215,130,170,172,228,201,73,65,179,252,52,227,25,95,127,255,221,237,247,223,141,106,9,63,201,98,43,21,43,94,116,190,97,111,158,179,20,55,202,228,21,227,76,100,233,189,53,111,51,254,251,189,193,11,246,73,221,27,60,99,193,216,58,47,151,52,223,219,59,42,139,2,244,122,91,174,215,48,220,204,159,177,27,5,199,226,13,126,145,37,111,38,222,51,169,22,27,42,170,102,40,188,44,74,235,159,105,153,129,195,85,54,5,227,234,88,149,253,203,5,27,26,111,203,26,92,117,194,85,166,50,38,7,23,188,164,169,42,197,192,138,211,146,103,56,171,109,2,243,127,17,108,13,167,145,57,87,76,92,129,139,247,200,60,112,230,130,137,235,44,101,231,162,252,180,213,235,119,118,118,200,84,214,69,65,197,118,102,191,253,94,114,85,10,146,210,60,199,51,165,217,74,202,43,194,80,32,41,180,196,196,9,217,9,164,84,245,50,207,82,146,121,65,195,58,140,110,181,30,94,241,83,166,54,229,74,238,145,115,45,195,76,118,181,212,3,7,85,149,131,85,200,146,170,116,67,4,251,189,6,151,107,149,37,83,94,77,153,120,1,59,93,9,211,138,10,90,16,14,225,176,31,153,213,209,236,109,38,131,221,90,94,37,202,148,73,180,124,50,221,209,123,26,17,130,169,90,112,57,59,206,116,0,128,120,114,147,169,141,181,17,149,228,35,219,18,202,87,32,168,134,127,87,84,81,28,189,166,121,205,64,154,219,142,242,26,17,83,13,138,237,132,188,98,74,91,206,129,4,80,93,1,220,217,140,28,226,173,143,192,55,241,252,132,215,5,19,116,153,51,187,111,102,149,31,191,176,182,101,124,101,204,171,191,239,12,82,218,131,206,254,71,57,149,96,253,167,98,230,144,74,70,178,162,202,25,70,139,70,60,26,113,42,25,35,169,96,87,251,209,16,4,162,157,89,47,134,126,61,102,87,180,206,213,97,198,87,176,37,86,219,138,149,87,241,144,152,241,248,183,6,120,41,94,98,232,14,228,161,144,232,194,17,98,88,42,202,21,2,82,100,215,84,49,51,95,153,15,146,226,60,145,10,35,16,108,87,214,43,43,79,30,156,207,223,128,235,247,73,212,51,28,189,24,20,98,23,106,13,207,169,64,212,153,152,64,81,235,14,30,52,10,30,16,22,220,243,3,23,140,166,27,132,9,200,131,188,118,6,176,71,153,26,43,151,38,154,47,97,55,135,84,126,9,9,166,20,240,85,115,21,245,163,200,155,232,101,198,242,213,144,125,36,98,33,133,232,164,171,146,231,91,50,135,12,78,46,115,248,103,159,192,207,83,202,233,154,9,168,26,10,83,59,19,113,20,168,28,141,91,55,243,66,62,64,46,58,50,138,162,2,151,117,235,187,127,207,28,11,194,17,36,12,174,200,165,240,191,251,23,95,100,5,91,84,148,227,74,157,86,112,160,172,21,40,237,166,146,151,162,44,64,205,90,49,25,255,99,64,209,185,177,244,123,86,149,2,82,33,185,44,218,223,251,38,220,76,134,223,162,21,166,157,45,179,120,32,136,219,8,21,53,74,120,76,214,156,67,189,200,104,158,253,23,50,103,166,177,109,114,122,165,67,67,149,46,113,113,154,111,101,38,201,13,91,186,212,255,216,76,218,118,71,52,187,216,48,130,99,36,245,131,173,60,106,131,118,32,38,227,142,183,219,210,199,4,217,201,104,212,193,0,88,182,7,20,163,236,138,196,207,90,38,191,16,91,176,122,11,117,225,225,13,104,162,9,65,0,4,208,25,187,179,71,193,32,28,204,217,13,105,246,197,6,26,152,116,71,54,243,14,186,178,169,125,125,161,116,93,102,43,114,180,97,233,199,247,0,202,76,176,213,57,154,144,1,74,100,140,186,217,152,183,222,250,32,114,163,178,29,166,85,6,137,199,233,220,44,2,141,129,120,45,152,82,176,10,249,155,250,39,214,166,184,99,209,137,185,106,96,39,13,60,169,57,156,205,83,214,114,141,184,137,61,28,248,100,165,182,227,198,9,205,241,201,92,158,213,121,254,78,232,37,113,96,212,118,172,36,175,104,189,102,241,231,18,218,132,60,183,199,140,212,70,148,55,218,27,115,158,150,66,192,61,90,140,236,228,83,202,42,252,17,63,237,82,161,67,71,198,170,96,195,195,10,24,37,16,37,166,179,253,9,7,154,202,208,152,38,223,119,173,25,152,194,72,248,22,204,208,83,167,122,192,235,224,120,159,154,24,2,118,46,24,132,54,179,159,177,97,36,38,171,56,86,211,143,72,51,168,23,30,150,43,180,105,176,9,77,121,1,12,96,5,189,70,93,112,13,209,169,217,50,139,35,92,111,139,133,147,83,200,53,174,127,132,148,101,89,230,32,99,46,95,171,34,55,146,200,207,36,218,192,87,4,92,33,170,114,154,241,168,37,92,66,0,235,244,253,104,13,23,122,71,71,71,35,70,91,17,100,153,175,228,228,147,18,144,156,244,232,193,10,242,132,148,46,135,92,83,225,121,174,201,51,67,78,184,13,162,53,52,38,254,182,145,124,234,13,100,77,101,199,15,28,162,141,123,236,232,162,71,85,253,101,240,97,244,51,100,214,169,248,162,7,52,186,10,119,144,162,57,140,131,203,192,133,126,253,205,73,149,14,47,104,140,101,176,53,200,188,29,43,120,250,100,126,36,231,239,22,23,246,90,118,229,203,82,20,20,37,28,3,61,55,31,186,157,244,171,100,89,139,20,109,53,200,206,236,82,220,5,107,76,133,21,86,167,166,73,69,154,188,106,230,227,113,104,190,240,54,9,184,30,157,21,251,107,183,76,28,46,237,179,179,174,21,192,168,172,109,77,211,176,48,69,59,126,82,159,1,248,3,18,238,140,190,208,192,61,172,179,28,241,15,52,238,20,224,9,12,206,94,180,53,13,161,127,157,137,146,99,67,0,77,253,205,91,200,136,46,239,65,161,84,165,162,185,59,71,130,0,115,18,244,188,181,165,101,205,178,69,157,166,140,173,216,170,179,12,172,99,246,147,125,173,169,254,157,232,208,131,132,170,119,73,217,61,243,37,220,243,137,146,112,75,45,156,246,205,181,19,232,65,33,20,240,102,144,132,90,125,168,101,72,100,54,155,69,67,251,12,210,226,232,2,213,242,167,66,253,191,221,189,187,125,126,7,148,163,109,164,9,25,54,233,160,112,111,187,61,98,254,107,11,247,211,95,36,220,216,210,73,190,39,220,76,63,36,25,43,96,232,149,25,217,245,165,111,192,206,199,76,233,206,28,123,116,236,82,228,158,51,240,40,108,133,109,234,53,107,172,156,0,102,255,218,48,193,226,143,215,232,239,143,215,247,60,109,228,141,146,5,195,151,45,187,206,146,25,119,121,147,13,127,132,43,255,152,144,19,60,134,20,230,28,240,224,243,187,36,178,57,97,52,130,3,176,198,3,173,67,76,4,5,98,210,156,125,18,232,57,118,23,234,55,129,213,227,151,50,227,125,65,54,105,223,121,88,216,16,102,167,211,169,55,41,246,106,70,183,56,216,127,81,154,80,143,157,240,59,194,114,8,158,33,207,61,250,164,57,191,42,31,62,232,73,60,250,91,120,67,34,204,38,213,238,91,18,113,217,150,20,53,172,95,50,72,168,20,147,28,62,32,249,126,13,194,71,87,109,210,16,148,9,49,229,24,26,42,68,146,252,170,175,82,90,30,115,36,209,62,230,116,159,82,147,3,177,174,17,131,1,137,245,196,18,59,64,224,160,208,75,110,24,119,239,106,80,248,9,135,197,112,154,23,62,124,222,103,168,171,63,1,210,73,26,174,32,216,193,66,120,172,239,29,99,155,206,255,255,155,91,64,79,76,170,177,181,241,41,39,57,194,103,209,167,155,190,208,194,177,67,90,151,79,186,174,170,53,108,136,156,25,122,176,127,236,52,142,150,159,155,141,65,143,155,32,139,49,157,99,247,196,112,85,243,102,18,67,237,29,119,158,82,18,93,244,78,179,60,207,36,3,159,173,228,125,9,192,129,236,35,224,107,70,145,81,68,134,156,66,121,105,233,246,121,210,232,248,175,116,9,221,4,2,228,244,78,187,162,199,189,248,49,104,121,0,72,223,58,135,180,248,107,135,125,246,209,217,14,123,179,219,45,211,88,134,228,12,4,132,87,63,47,97,119,120,64,208,2,180,246,45,20,85,181,60,42,87,204,25,186,53,157,52,243,77,193,29,18,48,219,39,127,219,221,37,127,252,49,124,196,126,80,159,31,18,245,108,159,252,125,183,89,250,231,219,88,211,110,143,36,164,49,200,212,241,208,37,155,19,83,124,145,222,221,115,37,248,158,178,166,168,249,20,130,153,226,131,200,76,109,247,163,141,184,175,247,158,224,89,66,248,42,51,33,61,202,58,118,240,194,237,104,87,221,86,181,118,36,197,225,51,165,156,151,186,200,164,37,62,211,43,168,51,203,109,243,103,50,203,96,52,247,140,2,149,30,163,70,211,248,97,190,107,180,11,61,241,90,169,170,113,83,242,129,211,26,138,180,128,46,104,229,125,244,167,158,42,58,57,161,255,216,179,18,122,61,168,120,95,112,228,151,58,53,244,105,132,91,136,17,226,255,160,134,110,209,101,216,51,161,209,202,100,61,175,165,123,27,209,28,115,255,1,104,116,159,145,188,22,63,119,54,193,21,20,228,25,63,191,247,128,80,239,208,251,232,58,50,168,178,164,198,210,139,138,166,31,19,226,19,91,10,134,215,176,138,129,20,143,27,156,253,20,226,108,40,158,39,15,231,52,75,117,27,40,246,33,241,174,135,161,126,105,62,218,109,189,254,33,207,155,62,216,59,155,198,205,236,81,192,194,236,241,205,20,184,19,223,12,192,31,215,76,168,228,152,73,247,58,240,110,249,31,64,227,244,225,51,102,113,175,95,157,227,9,20,48,20,224,95,161,33,15,232,252,25,190,83,180,129,238,83,222,215,14,141,86,96,188,123,3,25,15,200,66,65,115,96,201,5,38,39,75,201,45,138,224,120,150,93,195,248,95,73,24,68,16,251,4,12,39,49,131,23,153,44,112,83,18,181,156,132,153,223,155,219,116,251,88,158,92,105,78,222,50,190,86,155,230,193,181,11,114,171,110,167,131,65,139,212,21,100,209,103,228,172,46,150,64,198,129,239,123,186,17,3,220,199,88,82,48,58,96,16,218,123,85,2,223,109,22,58,247,155,160,240,145,208,209,106,66,58,154,59,164,247,224,188,239,182,7,192,21,123,95,54,92,53,215,209,213,73,146,239,222,144,31,126,104,150,162,185,125,167,2,91,144,181,143,191,21,148,52,134,252,114,128,120,154,110,40,162,57,56,249,119,86,53,134,132,52,100,153,161,27,26,163,57,241,218,183,164,51,67,238,108,244,65,236,53,164,63,174,104,38,112,15,254,63,177,91,90,99,94,178,209,109,232,245,206,62,200,117,94,92,61,12,250,91,227,190,63,249,195,216,255,0,108,76,9,184,9,36,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e91d9edc-05b9-4672-95b3-5fa7bd473efa"));
		}

		#endregion

	}

	#endregion

}

