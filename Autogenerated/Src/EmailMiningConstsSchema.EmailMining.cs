﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: EmailMiningConstsSchema

	/// <exclude/>
	public class EmailMiningConstsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public EmailMiningConstsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public EmailMiningConstsSchema(EmailMiningConstsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("1d5e5c83-b152-4d68-8555-f21b36618bc1");
			Name = "EmailMiningConsts";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b6327e89-1dee-4b6f-a695-226c016beae1");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,189,90,219,110,219,56,16,125,78,129,254,3,161,62,196,1,92,123,159,123,9,144,141,221,34,139,166,13,234,116,247,113,65,75,116,204,93,137,20,72,42,137,183,200,191,239,112,72,201,178,44,201,146,163,20,8,16,93,134,51,135,51,135,195,25,209,130,38,76,167,52,100,228,150,41,69,181,92,153,201,165,20,43,126,151,41,106,184,20,147,121,66,121,124,205,5,23,119,175,95,253,124,253,234,36,211,112,73,22,27,109,88,242,190,114,15,99,227,152,133,118,160,158,124,102,130,41,30,110,101,202,38,146,68,10,120,3,239,166,211,41,249,160,179,36,161,106,115,238,239,209,40,73,208,42,9,65,153,161,194,232,73,46,61,45,137,167,217,50,230,33,1,9,3,255,194,152,106,77,74,152,47,237,96,13,114,63,209,216,158,53,124,112,203,30,13,73,169,66,148,154,169,123,14,14,249,241,253,11,209,56,43,120,100,140,67,18,177,73,161,165,140,34,135,129,88,1,140,114,243,125,52,55,78,235,194,41,5,47,45,188,174,143,36,216,127,31,56,151,60,53,58,230,118,205,136,217,164,140,200,21,49,112,13,26,20,13,13,139,8,19,134,155,13,225,145,189,88,241,16,163,71,184,32,203,52,57,149,34,230,130,181,249,207,57,238,106,103,244,173,53,244,142,44,112,54,115,145,37,206,141,13,78,204,199,2,150,132,138,140,198,241,102,66,126,104,184,125,88,51,81,5,166,83,22,238,10,147,229,6,167,148,65,0,218,157,236,99,173,24,141,96,98,155,58,212,215,168,20,156,44,216,67,205,251,81,224,4,130,179,247,93,230,19,101,224,117,137,232,194,76,27,153,144,88,222,241,240,217,40,47,157,178,102,148,78,0,81,162,102,37,13,195,104,215,8,123,210,221,211,56,99,103,86,250,228,29,89,82,205,70,238,9,193,200,61,29,201,46,224,181,129,171,74,20,107,9,229,20,51,70,99,45,73,168,216,234,99,176,143,54,32,211,61,242,93,58,27,181,28,220,127,216,202,197,223,29,149,86,89,28,19,1,41,174,95,164,154,129,124,5,93,62,92,141,66,163,192,74,181,49,43,71,199,21,228,10,42,34,188,3,23,152,65,177,126,178,234,191,128,86,7,26,25,113,0,248,206,144,14,51,96,54,207,14,133,215,229,252,131,206,69,177,14,216,52,19,17,83,167,122,88,144,11,212,218,17,106,73,184,3,224,116,45,5,35,144,101,151,125,243,95,51,220,27,212,121,16,40,138,213,100,153,230,33,47,154,108,104,24,202,76,188,108,178,185,112,54,122,37,155,67,17,236,191,122,155,81,148,50,77,163,80,231,76,19,73,224,160,200,29,253,192,150,111,105,20,41,166,245,80,104,255,98,203,153,179,113,16,114,33,218,27,247,17,11,185,25,49,174,202,174,152,75,194,53,171,164,121,224,0,171,100,1,51,130,138,72,231,78,0,179,33,4,206,22,37,212,208,195,21,221,77,46,63,3,113,167,172,166,164,107,174,140,109,20,96,36,121,160,26,220,250,143,155,241,209,149,90,29,154,239,185,86,23,134,26,145,81,144,203,180,113,102,7,42,77,211,152,15,141,244,194,43,109,1,234,69,106,88,82,39,62,68,22,5,158,33,57,152,128,94,107,141,165,90,146,100,34,175,179,177,45,224,172,190,119,170,201,158,29,218,192,201,150,61,117,153,117,46,84,184,190,44,131,104,232,35,26,35,57,239,191,208,27,140,150,55,234,122,145,81,192,138,253,185,17,16,228,44,162,185,233,153,220,27,48,89,101,237,136,32,65,183,227,185,150,75,30,251,138,97,16,76,94,97,59,172,4,133,106,168,221,48,96,0,118,255,105,37,161,132,3,206,144,149,84,200,118,32,120,156,37,184,43,88,195,182,137,158,99,239,251,139,41,190,53,220,151,223,223,212,29,21,252,191,162,170,233,25,190,138,225,178,182,114,4,119,197,70,65,89,206,61,111,39,153,47,254,158,15,208,43,106,195,230,69,186,193,42,167,183,145,206,194,53,129,132,143,107,97,108,107,155,49,209,50,228,208,252,11,102,30,164,250,119,76,152,9,39,103,67,204,163,108,185,117,54,37,193,46,115,186,56,166,26,171,131,232,21,181,129,243,34,93,96,253,33,151,207,135,4,74,218,224,192,235,10,148,74,94,169,12,120,129,164,50,199,157,211,239,241,219,228,114,17,26,126,255,171,211,202,22,72,223,253,146,8,105,74,213,225,134,245,95,185,91,227,87,130,218,217,151,118,132,226,221,40,104,39,141,147,77,160,238,200,209,16,88,163,240,223,126,140,217,216,234,36,141,25,68,247,25,232,102,219,166,118,23,217,172,220,198,30,66,151,127,231,85,204,100,10,10,37,165,128,11,150,15,71,244,25,59,240,230,168,169,14,31,190,169,39,250,86,234,5,24,190,199,109,103,208,181,53,77,109,196,11,82,188,48,220,202,245,55,138,221,217,76,251,137,199,145,126,7,5,52,191,167,134,229,190,195,155,189,64,204,56,30,62,192,20,62,56,63,142,235,77,158,147,191,209,157,215,52,69,23,187,104,117,30,61,202,99,248,134,137,200,193,172,98,102,14,52,78,254,224,218,197,190,37,225,130,69,99,178,204,76,101,45,67,19,99,27,152,99,215,116,213,219,215,214,206,14,63,43,18,163,0,69,14,172,164,45,240,2,233,16,232,230,121,31,211,10,48,151,10,14,5,2,207,127,84,22,26,169,144,67,126,201,213,175,192,170,153,78,75,241,164,96,210,4,246,86,247,106,12,93,39,215,174,89,125,106,7,120,205,204,90,118,162,202,13,83,176,152,19,104,110,5,225,144,69,121,200,141,253,48,127,207,148,182,154,86,74,38,184,98,253,106,245,71,114,110,105,5,211,115,123,132,81,122,93,59,101,16,107,8,34,62,73,169,162,9,126,231,250,24,128,115,130,115,219,116,151,189,52,33,159,32,223,184,175,53,169,217,228,239,30,120,28,147,101,145,107,35,182,162,89,108,136,231,153,27,250,97,138,218,183,198,156,176,222,105,240,161,116,177,3,253,199,144,237,228,75,160,203,195,118,153,87,56,77,166,12,50,87,177,245,55,132,29,254,229,33,174,167,170,3,131,65,62,225,43,98,199,77,174,244,87,216,231,190,169,185,157,254,232,44,87,112,226,103,142,19,118,35,158,138,113,91,2,221,170,205,103,102,48,125,91,109,99,34,33,25,56,51,123,170,202,214,157,46,179,86,242,193,157,37,9,80,201,163,75,170,205,252,49,100,169,205,106,126,90,19,8,80,66,13,84,169,84,216,52,19,218,115,135,211,159,191,61,157,90,126,212,147,98,140,190,104,163,115,247,15,88,123,39,150,81,102,163,226,54,18,0,30,217,107,16,231,85,113,76,53,43,153,137,200,158,106,178,71,174,241,28,117,105,207,150,109,149,193,154,155,192,253,230,109,230,141,178,254,213,214,87,112,26,90,215,22,135,197,88,129,64,70,54,4,22,238,49,77,71,21,25,152,43,30,69,229,74,186,34,120,176,46,107,131,60,0,78,167,255,202,247,59,173,64,119,69,155,10,255,234,176,129,142,28,180,204,84,184,61,116,200,119,27,99,127,2,208,66,161,95,241,29,97,225,160,245,174,252,253,239,36,112,10,121,85,59,242,57,246,121,125,175,71,228,127,157,128,214,236,15,22,152,170,111,233,156,120,39,38,90,192,121,135,53,0,27,247,32,95,164,233,108,89,24,104,69,139,162,111,115,217,195,125,168,31,215,135,143,240,247,63,229,168,185,249,106,35,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("1d5e5c83-b152-4d68-8555-f21b36618bc1"));
		}

		#endregion

	}

	#endregion

}

