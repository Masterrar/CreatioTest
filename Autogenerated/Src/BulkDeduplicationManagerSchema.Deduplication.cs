﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: BulkDeduplicationManagerSchema

	/// <exclude/>
	public class BulkDeduplicationManagerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public BulkDeduplicationManagerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public BulkDeduplicationManagerSchema(BulkDeduplicationManagerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("9c848255-c02c-4ca5-9d7c-159a0d6b4582");
			Name = "BulkDeduplicationManager";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("3066e968-6ad0-45b5-bf2b-b9af469e0d31");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,237,26,201,114,219,200,245,204,169,154,127,104,51,83,101,160,204,129,237,28,199,34,167,100,109,225,140,37,43,146,28,31,92,46,23,68,52,37,68,32,64,119,55,100,177,40,254,123,222,235,13,13,160,1,82,74,114,155,139,101,244,242,246,189,153,199,11,202,151,241,140,146,43,202,88,204,139,185,136,14,138,124,158,222,148,44,22,105,145,71,135,52,41,151,89,58,147,95,63,255,180,254,249,167,65,201,211,252,134,92,174,184,160,139,119,141,111,184,157,101,116,134,135,121,116,66,115,202,210,89,239,153,143,215,255,134,255,158,22,9,205,90,231,62,164,249,247,214,226,25,21,213,90,141,186,163,44,230,34,157,69,135,197,34,78,27,148,71,87,49,191,219,114,239,51,189,222,95,166,200,191,96,241,76,240,232,130,126,47,41,23,252,233,247,248,18,120,163,213,61,88,17,151,183,49,91,86,75,174,192,23,139,34,247,239,48,218,181,30,29,229,34,21,41,229,157,7,142,129,152,130,117,156,56,43,211,232,146,178,251,116,70,165,240,163,163,7,65,115,142,58,241,29,7,30,163,127,8,177,140,246,175,185,228,178,126,80,210,178,170,244,74,198,125,168,14,99,17,27,105,69,205,171,0,20,192,254,141,209,27,132,115,0,50,230,191,145,247,101,118,87,147,253,105,156,199,55,148,201,179,175,95,191,38,123,188,92,44,98,182,154,232,111,188,64,18,247,6,89,168,43,145,185,241,218,185,242,229,144,206,227,50,19,239,211,60,1,126,2,177,90,210,98,30,76,187,240,134,225,87,184,181,44,175,97,157,204,144,198,78,18,9,80,31,115,234,219,26,145,78,4,0,125,45,153,179,146,56,78,105,150,128,40,206,89,122,31,11,170,54,151,234,131,48,26,39,69,158,173,200,244,82,196,76,212,32,106,43,86,214,176,34,223,248,150,19,239,252,128,91,148,162,71,29,100,41,205,5,249,118,221,189,217,1,110,127,185,188,156,221,194,149,140,178,207,44,94,130,160,190,197,173,181,218,229,25,152,156,32,96,126,104,113,83,254,41,79,129,236,125,1,223,215,165,160,103,16,202,192,236,134,102,99,232,185,155,2,173,167,241,195,49,21,179,219,115,16,51,135,11,111,223,188,121,167,37,77,243,68,9,187,46,249,115,86,0,41,232,106,40,253,66,128,157,210,196,200,95,127,146,251,148,137,50,206,36,138,131,91,58,107,139,3,52,35,74,62,205,5,184,2,28,28,79,200,219,45,136,165,143,148,168,20,196,44,141,77,163,85,134,215,101,60,193,39,78,25,92,206,181,51,150,181,207,17,66,24,12,124,26,104,43,32,4,243,189,6,243,13,234,48,66,178,150,80,210,57,9,148,66,162,41,63,43,179,236,35,59,90,44,197,42,168,145,165,2,228,39,150,133,230,222,224,67,113,19,29,49,86,176,96,232,63,74,82,78,40,130,138,134,161,212,228,96,35,255,189,143,89,131,159,3,84,173,18,211,62,187,41,23,104,144,99,146,211,31,196,179,19,12,235,151,135,163,6,52,141,108,171,151,0,10,25,155,244,39,228,58,177,183,213,249,38,129,226,126,43,3,134,138,30,191,242,18,208,227,164,79,198,221,54,6,64,217,225,162,155,126,67,62,165,226,182,168,5,175,193,192,245,78,149,3,16,240,34,254,103,73,65,186,192,205,161,230,130,154,68,119,196,191,107,99,35,84,94,64,151,55,22,133,118,65,249,119,173,249,22,192,134,75,68,238,1,27,141,29,168,74,6,0,48,2,146,49,75,72,40,144,165,202,69,14,166,190,159,253,136,87,252,146,98,206,2,148,32,65,90,221,0,84,251,201,34,205,47,210,155,91,193,107,219,140,138,146,229,72,168,43,54,35,134,195,84,18,7,216,246,20,159,35,29,237,38,40,15,76,161,148,93,21,74,157,138,20,164,245,52,94,106,177,124,249,10,113,14,151,249,200,35,82,64,234,10,139,119,131,211,66,236,38,39,208,242,65,56,75,37,159,10,0,220,238,144,27,238,170,139,115,168,79,226,217,45,9,16,130,162,25,34,167,161,222,70,137,30,26,191,32,142,253,36,81,139,129,186,25,74,20,95,129,2,245,237,6,14,12,85,47,122,0,70,251,249,42,120,192,176,252,16,253,73,193,191,199,30,214,30,31,97,247,95,113,86,82,239,126,184,51,229,29,210,249,186,139,240,20,63,189,172,36,73,224,77,144,35,127,222,12,107,214,217,3,217,103,181,39,101,154,160,125,94,20,63,46,232,172,96,201,52,9,60,166,83,200,66,127,66,88,241,99,7,235,124,150,85,181,46,94,74,220,90,95,136,249,75,11,238,215,232,170,80,199,130,186,20,144,173,232,60,102,144,251,186,96,134,62,113,180,74,97,95,40,11,188,2,24,17,73,64,79,24,232,81,13,168,246,67,202,197,158,197,53,205,231,197,68,197,52,192,104,132,139,66,132,110,4,195,9,18,168,130,163,19,238,142,211,12,10,20,30,29,100,52,102,190,13,180,45,252,62,0,15,22,84,173,126,78,5,212,83,12,8,193,35,129,90,132,182,102,25,179,148,67,18,130,106,58,58,250,14,229,209,168,75,137,231,177,184,213,133,137,161,56,82,20,6,42,42,163,99,170,255,69,198,202,28,205,133,209,33,240,158,230,112,60,12,157,224,100,50,33,229,181,222,68,98,182,13,15,166,206,166,214,36,139,190,245,122,30,9,71,125,42,9,61,193,46,133,30,22,67,157,143,50,27,61,240,80,159,19,91,17,29,167,140,11,19,181,140,92,48,52,53,252,17,1,74,217,131,164,12,204,90,89,165,141,222,71,149,207,200,177,206,208,162,145,108,91,163,227,39,172,40,151,53,155,151,43,255,23,131,239,179,247,145,138,75,55,136,124,154,252,101,253,127,89,255,118,235,199,162,103,155,101,107,26,79,148,93,129,52,181,133,105,245,1,90,172,248,124,252,41,124,62,111,186,47,192,82,129,97,67,155,174,105,122,147,164,52,66,85,46,73,89,121,171,94,117,192,208,44,115,214,209,195,146,81,206,149,37,120,47,85,39,218,20,84,123,210,170,173,213,91,221,13,236,146,201,186,137,154,172,4,215,69,145,133,234,208,70,11,75,231,117,191,154,213,145,79,82,198,50,23,159,209,31,248,55,80,64,54,222,228,43,37,105,26,148,142,14,92,118,231,224,55,127,20,215,166,157,224,74,67,205,126,98,230,237,227,43,87,239,174,147,77,177,163,165,178,238,155,8,0,29,71,15,116,86,66,11,166,219,18,164,67,98,81,246,238,80,103,36,183,51,192,105,158,208,135,6,60,187,182,113,76,178,131,97,11,81,26,188,82,152,34,97,87,10,192,23,219,71,219,96,3,87,7,157,29,40,120,249,162,184,87,41,5,110,243,96,23,138,123,192,153,239,211,52,7,187,203,86,112,109,111,71,198,76,63,189,11,5,198,152,235,61,232,231,130,221,201,225,123,164,244,210,216,62,40,25,131,0,132,171,145,3,100,151,225,210,104,171,233,142,200,60,206,184,191,130,85,117,228,84,82,15,214,188,135,94,55,34,245,60,59,33,114,136,86,69,199,99,86,44,244,144,183,221,164,143,228,88,172,152,207,33,243,170,255,207,138,50,23,174,175,49,53,40,209,46,133,243,114,61,58,9,14,43,30,228,64,12,3,42,147,25,83,207,21,162,147,163,43,91,187,203,59,102,114,127,92,176,69,140,48,113,226,172,62,162,63,184,46,105,236,97,8,159,86,48,193,144,23,37,155,209,202,17,135,163,26,35,246,164,12,128,50,40,170,52,28,246,1,165,234,169,192,122,222,208,241,194,231,194,84,226,4,72,70,174,207,3,35,53,1,80,228,223,237,64,148,174,212,251,6,8,22,21,165,18,101,164,28,131,86,5,153,121,6,153,4,26,179,6,129,157,184,1,17,233,152,92,36,148,188,24,19,124,98,168,86,162,143,127,122,6,134,191,12,125,29,21,129,58,131,188,92,87,170,218,188,12,214,74,50,155,17,89,75,238,54,33,88,125,154,209,36,34,21,146,223,200,218,67,204,198,76,29,109,109,80,102,89,115,14,89,101,249,139,74,34,22,24,218,92,197,176,239,236,88,66,245,178,216,226,207,222,218,141,207,148,131,155,65,36,128,188,233,240,135,254,3,55,183,50,215,234,6,46,44,83,118,233,247,72,6,136,247,118,104,162,75,162,16,10,83,12,32,129,141,45,106,214,183,125,54,232,12,184,229,3,77,154,223,82,150,138,164,152,145,25,163,243,241,176,243,181,4,147,76,109,29,99,212,240,245,164,111,86,142,71,136,239,94,247,140,81,64,9,166,117,37,213,239,15,194,38,65,246,78,111,91,20,87,247,3,55,220,216,40,97,52,38,109,169,11,113,195,160,154,117,109,155,127,115,112,48,229,178,152,190,40,115,61,175,28,85,59,176,152,163,64,198,42,103,232,13,93,54,104,139,217,29,85,13,147,4,56,178,59,21,166,30,22,59,196,22,157,83,249,118,71,30,31,13,233,207,0,162,41,208,172,185,62,1,71,177,139,193,8,117,244,48,163,75,217,178,200,157,117,159,47,109,158,111,208,205,16,32,29,140,123,204,186,222,162,216,72,209,13,195,151,161,91,35,100,109,111,152,172,165,201,126,116,211,183,110,247,90,73,220,134,65,107,8,29,196,173,21,37,246,165,198,116,73,123,91,26,176,73,16,106,181,32,29,162,16,113,38,201,192,250,227,253,114,1,240,222,84,137,74,197,69,28,7,59,28,84,219,234,189,160,235,169,161,245,26,176,125,106,190,101,74,111,135,243,216,199,217,238,152,4,200,73,42,41,135,63,123,245,23,74,88,122,245,42,172,133,157,42,191,98,127,107,229,216,83,144,185,122,54,213,130,171,66,55,182,248,161,55,35,203,53,52,245,119,245,8,208,156,56,148,242,141,202,11,47,186,44,23,38,109,200,131,129,25,91,12,180,202,94,141,155,176,244,126,109,156,208,0,206,107,163,5,23,97,69,184,59,21,106,147,199,113,244,175,49,213,25,178,117,134,223,96,2,57,205,234,157,86,181,80,153,60,25,186,8,37,105,110,25,161,37,118,156,230,73,35,211,162,86,204,124,203,128,64,21,106,16,77,149,13,12,232,39,140,57,6,190,73,7,177,123,122,218,81,141,17,156,81,81,104,78,153,68,129,17,178,206,19,206,45,36,80,75,254,198,176,1,182,179,72,57,254,182,196,168,118,236,90,44,249,181,237,250,239,156,187,252,46,93,46,105,82,221,109,233,49,50,112,234,104,12,144,118,96,121,213,9,196,220,177,236,157,209,7,29,107,0,179,54,232,95,27,52,153,75,146,255,8,5,137,226,184,136,243,27,26,180,241,92,197,119,52,168,83,106,205,102,227,113,94,237,126,123,53,153,61,62,122,226,229,100,236,11,230,62,7,175,158,209,154,122,156,114,245,232,95,61,127,117,212,149,237,25,87,21,9,45,80,144,133,250,9,154,119,84,169,238,169,3,91,157,174,9,250,202,178,95,89,70,147,25,39,52,73,173,184,17,82,179,197,156,223,119,61,55,193,183,127,42,128,85,72,61,185,227,200,140,248,15,246,76,174,26,85,106,231,15,25,128,247,173,191,114,208,198,160,199,221,157,63,111,112,135,55,158,154,181,191,191,255,101,184,110,23,201,181,70,127,35,201,28,218,126,255,252,227,229,85,213,193,60,161,227,119,91,224,247,69,178,10,58,249,175,147,222,219,238,54,105,239,106,123,235,174,131,244,253,30,57,69,233,139,102,188,70,212,194,41,90,235,157,165,115,213,141,253,162,6,112,75,169,236,228,6,109,217,178,30,111,6,227,167,204,83,91,67,60,11,186,250,17,132,1,236,246,187,126,43,215,205,174,59,0,125,249,196,214,214,225,104,67,116,13,111,235,119,66,109,37,239,107,194,159,69,20,206,139,44,212,110,90,254,139,208,1,198,123,85,168,40,138,5,132,39,102,52,78,248,202,125,172,131,160,216,47,229,33,243,82,194,221,98,62,174,3,185,168,57,48,96,248,228,92,229,102,87,75,209,134,0,28,239,219,65,151,218,187,108,12,216,240,101,191,34,76,79,74,235,100,181,187,4,36,127,18,52,168,175,42,170,230,96,187,59,250,152,108,228,29,44,202,64,99,120,218,18,97,92,148,205,48,227,23,229,174,19,181,255,233,248,76,81,28,12,15,226,60,47,4,42,89,219,0,208,160,82,34,154,183,54,110,178,126,179,33,113,158,128,109,131,14,201,250,237,38,34,87,183,148,44,40,231,96,138,104,245,235,191,111,134,166,129,247,14,46,70,164,233,163,190,167,55,31,67,99,15,67,110,202,117,39,74,122,173,62,100,218,252,7,200,8,52,253,223,46,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("9c848255-c02c-4ca5-9d7c-159a0d6b4582"));
		}

		#endregion

	}

	#endregion

}

