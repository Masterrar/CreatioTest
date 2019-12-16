﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: MailingDbUtilitiesSchema

	/// <exclude/>
	public class MailingDbUtilitiesSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public MailingDbUtilitiesSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public MailingDbUtilitiesSchema(MailingDbUtilitiesSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("5bc508bc-440d-4c92-9800-5a2fc383b4a2");
			Name = "MailingDbUtilities";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("956f026d-fde0-4edb-a4cc-83d98fd529ec");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,181,88,75,115,219,54,16,62,43,51,249,15,24,245,66,77,85,42,189,182,150,102,28,91,73,61,77,60,174,101,39,135,78,15,16,185,146,80,83,4,3,128,86,212,140,255,123,23,15,146,0,69,201,116,166,245,65,20,129,197,183,175,111,177,43,231,116,11,178,160,9,144,59,16,130,74,190,82,241,5,207,87,108,93,10,170,24,207,95,191,250,246,250,213,160,148,44,95,147,197,94,42,216,254,218,122,71,249,44,131,68,11,203,248,61,228,32,88,210,200,248,176,2,142,173,199,151,111,113,11,55,127,16,176,70,32,114,145,81,41,127,33,31,41,203,80,250,114,121,175,240,139,98,32,141,212,100,50,33,103,178,220,110,169,216,207,220,187,149,216,147,68,159,36,43,46,200,142,139,7,178,99,106,67,82,170,232,146,74,136,171,179,19,239,112,81,46,51,150,184,115,93,10,7,223,140,210,218,182,143,160,54,60,69,235,110,4,123,164,10,236,110,219,38,179,112,11,170,20,185,36,178,92,126,41,65,236,137,218,80,69,36,232,120,17,197,11,146,19,134,33,68,123,5,223,18,35,18,215,96,147,54,218,89,65,5,221,146,28,115,54,29,90,144,225,236,15,131,203,114,169,104,158,64,124,54,49,66,221,103,74,9,2,179,155,219,108,13,103,247,248,78,146,122,161,39,10,210,229,129,174,97,193,254,129,225,236,186,220,46,17,132,175,140,59,214,25,197,201,18,156,151,144,30,130,9,27,21,103,186,23,18,233,199,4,207,85,130,250,100,97,131,77,208,66,133,233,90,216,24,190,7,117,199,139,43,45,111,87,34,183,97,1,199,228,62,112,153,132,17,24,163,199,138,120,254,140,136,102,251,96,96,21,147,28,118,78,81,20,30,28,25,169,65,140,186,35,255,184,91,198,138,40,183,121,100,31,241,57,86,137,96,242,33,26,222,130,44,51,101,17,135,163,74,250,29,230,62,178,246,142,80,184,45,166,107,102,240,228,40,8,121,106,89,120,140,146,134,204,39,24,57,255,10,73,169,64,146,171,28,61,82,85,180,10,36,59,230,74,199,131,87,1,145,47,165,162,3,227,203,191,241,113,154,67,107,80,190,1,195,217,187,50,183,25,50,116,80,130,230,18,107,24,201,228,64,141,97,254,145,255,139,233,21,231,46,120,137,220,64,94,51,163,20,99,35,248,238,128,148,246,238,112,156,212,100,114,241,245,45,109,83,82,187,122,182,112,47,190,224,140,180,194,50,182,12,57,201,225,138,178,232,156,84,109,62,147,41,249,249,13,254,25,14,13,30,169,208,5,230,85,11,238,31,86,80,101,103,187,86,124,162,91,192,16,44,94,20,144,176,213,254,154,127,224,201,195,111,104,138,140,70,141,102,44,106,108,41,46,50,144,218,248,78,137,103,27,235,222,74,185,115,209,19,170,205,111,69,44,10,77,114,234,93,207,137,244,249,116,105,83,132,13,98,218,114,49,158,231,178,20,112,249,182,89,138,70,85,124,7,131,35,14,248,6,197,46,253,81,163,165,50,97,16,122,247,227,180,51,32,78,248,201,60,158,200,110,195,50,32,81,183,230,105,71,70,220,197,197,14,48,159,122,116,169,196,220,87,4,190,22,2,164,212,84,51,221,51,231,249,79,176,45,176,183,10,115,49,245,189,22,30,105,86,98,135,248,164,31,186,144,44,252,201,178,181,34,215,248,29,59,11,126,54,199,78,21,106,63,171,79,85,174,233,68,22,104,222,224,96,105,92,201,107,174,230,26,198,132,178,45,18,233,122,51,126,142,17,74,104,146,53,46,84,204,177,224,56,126,216,6,111,190,77,77,111,169,119,170,58,113,118,228,41,51,149,254,37,124,245,15,85,139,81,248,122,183,47,32,158,127,41,105,86,243,246,3,172,148,231,84,0,210,242,198,179,221,18,208,90,21,154,17,223,178,245,198,67,148,241,121,154,86,189,238,66,223,66,209,155,209,200,63,169,39,47,148,249,188,129,92,215,102,20,226,141,137,59,123,163,243,11,72,245,200,68,244,16,99,158,73,120,185,39,65,97,28,63,81,171,25,245,174,23,143,114,166,107,209,52,149,150,13,122,4,114,213,100,222,251,150,204,75,248,127,180,212,80,55,90,242,220,216,245,2,227,191,171,114,48,225,221,37,115,80,39,118,10,179,57,15,231,175,78,112,67,183,94,153,119,237,243,184,108,189,115,64,189,30,36,40,245,92,143,23,60,78,6,133,224,9,164,216,58,250,230,249,191,25,196,101,97,153,178,104,89,97,182,159,155,225,157,195,114,56,179,157,74,171,53,171,242,56,115,26,73,123,167,246,30,135,172,133,55,149,129,209,51,83,185,163,136,245,207,101,209,218,70,126,135,189,97,249,13,101,226,204,202,141,221,196,57,251,243,47,210,248,85,81,73,247,124,89,184,203,162,109,199,129,226,194,187,50,112,254,4,154,108,236,216,80,3,163,91,29,90,6,178,136,63,99,219,105,136,84,203,196,104,242,184,57,18,27,243,157,138,39,159,237,8,81,141,15,207,211,239,92,151,235,14,111,84,77,27,215,31,116,221,234,230,162,227,15,91,176,227,171,157,230,250,18,179,190,5,135,179,139,99,80,167,57,201,75,145,192,29,93,102,112,158,49,138,244,50,15,243,3,81,47,234,240,101,216,145,188,251,167,15,160,45,221,54,162,187,165,94,10,153,248,221,114,56,211,159,22,109,139,82,76,114,47,166,167,129,68,216,9,63,181,6,30,179,221,219,42,133,201,12,16,204,181,204,36,177,244,48,63,206,136,22,106,146,18,0,134,197,247,200,89,74,92,211,109,15,11,193,40,210,84,91,43,115,173,13,47,3,174,34,15,39,15,18,68,182,170,75,210,21,166,122,179,118,219,47,216,157,111,117,247,220,19,168,250,158,97,167,195,223,182,163,193,20,20,216,212,99,8,234,242,250,244,92,20,104,232,24,139,154,80,29,253,167,128,91,243,151,112,229,95,198,221,26,146,230,19,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5bc508bc-440d-4c92-9800-5a2fc383b4a2"));
		}

		#endregion

	}

	#endregion

}
