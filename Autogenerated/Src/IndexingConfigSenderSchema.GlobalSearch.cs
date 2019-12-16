﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IndexingConfigSenderSchema

	/// <exclude/>
	public class IndexingConfigSenderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IndexingConfigSenderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IndexingConfigSenderSchema(IndexingConfigSenderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("c5cb028a-05f4-4596-988a-6fb508bebf2c");
			Name = "IndexingConfigSender";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("eef27540-b1e9-466b-87b9-62933f9468f4");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,181,88,109,83,219,70,16,254,236,204,228,63,92,5,147,200,13,35,39,124,4,76,134,130,67,220,6,195,96,211,47,157,214,115,72,107,89,173,222,122,119,50,184,12,255,189,187,58,157,37,203,146,13,153,246,67,176,116,183,187,247,220,179,175,74,204,35,144,41,119,129,77,64,8,46,147,153,114,206,147,120,22,248,153,224,42,72,98,231,50,76,238,121,56,6,46,220,249,219,55,79,111,223,116,50,25,196,62,27,47,165,130,232,184,246,142,202,97,8,46,105,74,231,18,98,16,129,187,33,51,129,71,229,220,130,159,133,92,12,30,83,1,82,146,124,41,231,231,103,30,29,157,39,81,132,16,190,37,190,143,203,229,254,8,30,20,42,16,216,159,101,18,151,27,183,32,213,120,206,69,90,46,85,239,37,96,13,203,24,148,194,71,73,27,172,95,147,172,209,80,17,111,179,237,124,225,174,74,68,0,36,129,50,123,2,124,84,101,231,33,151,242,136,13,99,15,30,81,75,219,29,3,190,138,92,174,215,235,177,19,153,69,17,23,203,211,226,157,182,37,11,72,5,60,6,177,10,20,218,101,42,97,106,14,122,157,0,72,16,139,192,5,199,88,233,85,204,164,217,125,24,184,204,165,211,91,14,239,60,229,0,74,164,72,170,226,177,66,180,55,34,88,112,5,122,191,142,48,95,24,160,97,133,7,120,16,6,81,160,64,176,148,43,252,137,157,149,74,21,78,39,213,22,25,158,64,106,2,184,151,196,225,18,125,230,195,35,155,130,54,119,97,172,221,104,99,232,151,24,30,180,144,109,217,206,143,221,158,253,219,31,189,223,63,116,247,173,238,241,22,120,39,18,128,185,2,102,125,235,14,105,194,171,197,58,46,173,222,41,18,72,247,212,196,109,129,186,194,184,110,129,77,179,181,247,109,48,48,118,89,196,99,238,131,120,37,47,67,82,157,134,248,167,79,86,174,10,35,151,160,40,31,64,216,86,53,53,87,100,236,161,111,181,59,215,125,123,35,146,20,4,69,17,57,55,81,8,29,188,221,238,213,214,217,60,145,138,113,207,163,92,109,189,71,97,20,111,34,40,56,11,11,95,73,149,234,70,167,227,131,121,234,8,80,25,122,183,205,237,88,30,210,16,203,146,93,24,185,19,225,1,179,246,63,229,215,68,245,103,250,251,252,98,248,121,194,176,24,139,221,43,193,231,121,243,95,161,63,252,78,244,179,44,12,89,38,194,215,58,192,192,195,227,143,215,5,22,129,80,25,15,107,151,69,185,157,87,37,153,207,159,235,213,147,162,242,87,30,102,96,215,82,3,175,93,141,82,212,182,14,138,83,157,65,148,170,229,75,25,209,86,176,224,229,140,184,121,25,51,229,175,224,230,85,212,248,21,84,99,109,102,39,77,151,141,58,237,148,53,159,65,244,217,109,123,253,239,101,214,20,118,99,169,78,243,75,121,54,141,66,247,156,37,11,3,204,222,93,5,204,240,101,148,7,185,238,55,84,45,170,22,155,6,109,91,45,148,183,155,106,223,217,112,68,48,67,166,91,79,102,125,236,45,152,90,93,35,222,217,38,171,219,184,110,241,75,242,202,73,43,144,83,155,90,86,222,76,69,70,242,103,194,207,34,36,212,182,214,125,136,78,170,121,213,248,73,59,170,12,165,237,244,189,192,173,81,26,2,65,64,138,77,243,99,201,172,218,37,135,52,60,157,135,1,10,97,139,220,209,172,42,194,108,42,86,207,218,153,122,240,88,121,178,34,90,121,108,205,154,210,154,206,148,202,187,153,5,204,130,221,20,214,213,6,216,233,108,140,55,218,35,212,4,115,152,13,156,13,99,28,182,120,24,252,131,3,23,207,79,172,50,70,243,87,251,108,193,112,184,200,39,46,167,198,155,230,164,105,12,179,107,195,69,45,32,10,122,106,113,130,84,108,204,32,141,12,84,239,127,5,106,158,120,245,225,206,184,116,145,4,30,27,243,5,104,112,242,156,135,225,61,119,255,178,115,7,226,191,20,233,163,153,168,124,49,224,40,207,170,235,206,24,103,153,12,235,151,7,236,135,190,25,251,71,160,156,175,74,165,229,166,115,253,203,42,249,104,210,113,6,66,36,98,221,84,190,116,133,165,29,163,221,120,155,65,136,72,170,138,195,120,150,216,69,193,251,146,136,136,99,174,17,189,84,201,76,238,200,162,109,72,54,11,226,64,206,49,21,30,2,53,103,22,251,80,228,127,199,50,199,106,140,71,236,233,227,243,1,43,1,227,194,39,92,64,134,20,134,31,190,29,62,91,7,70,121,13,246,186,161,3,214,66,79,109,163,48,188,43,172,155,157,218,22,207,102,161,242,77,145,127,211,172,232,192,175,138,166,47,138,166,244,47,82,59,15,21,52,103,87,35,160,160,127,40,71,88,84,175,69,222,119,236,230,158,217,101,239,222,177,70,249,114,20,233,118,55,61,188,214,242,8,191,73,7,89,180,76,198,241,83,14,200,146,99,134,173,162,176,84,24,237,80,253,172,149,239,83,182,89,98,49,201,90,107,60,117,128,181,77,28,172,109,58,113,15,169,24,13,38,227,201,217,232,226,236,246,226,112,250,49,63,178,44,90,206,79,92,22,189,158,106,203,157,8,236,125,235,169,153,39,103,34,130,104,128,60,191,239,189,239,62,247,100,153,157,249,237,246,40,15,254,39,243,206,36,25,231,14,210,183,162,92,154,173,142,186,133,191,51,252,193,224,213,191,101,97,54,59,133,235,116,116,226,190,126,112,110,174,199,19,237,8,237,143,194,128,115,230,121,55,92,224,124,174,232,195,102,184,138,81,3,231,128,209,135,62,190,45,240,27,198,193,27,232,2,125,125,255,39,6,128,189,233,58,147,65,91,236,143,240,13,237,86,7,253,66,169,18,111,237,53,4,59,130,192,110,186,10,179,138,7,6,143,224,102,10,206,228,50,118,237,2,65,158,232,41,235,159,54,150,88,218,43,32,55,117,49,138,90,250,15,133,202,26,46,253,11,59,142,26,43,188,17,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c5cb028a-05f4-4596-988a-6fb508bebf2c"));
		}

		#endregion

	}

	#endregion

}

