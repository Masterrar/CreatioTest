﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IndexingEntityListBuilderSchema

	/// <exclude/>
	public class IndexingEntityListBuilderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IndexingEntityListBuilderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IndexingEntityListBuilderSchema(IndexingEntityListBuilderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("53dfc9d5-8345-4de0-994f-2835d022341e");
			Name = "IndexingEntityListBuilder";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("eef27540-b1e9-466b-87b9-62933f9468f4");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,237,28,93,111,220,54,242,217,5,250,31,216,77,209,202,192,66,185,246,222,18,219,129,227,216,198,226,226,196,205,58,205,99,64,75,92,91,23,173,180,161,184,177,183,174,255,251,205,240,67,34,37,82,210,218,73,14,7,28,80,164,89,138,51,28,206,247,12,201,20,116,201,170,21,77,24,185,96,156,211,170,92,136,248,168,44,22,217,213,154,83,145,149,69,124,154,151,151,52,159,51,202,147,235,31,127,184,251,241,135,157,117,149,21,87,100,190,169,4,91,62,111,253,6,224,60,103,9,66,86,241,41,43,24,207,146,206,156,215,89,241,185,25,188,146,11,60,123,118,84,46,151,176,222,235,242,234,10,134,155,239,54,97,56,195,255,37,68,50,208,179,94,22,239,69,150,87,126,64,206,66,227,241,171,151,193,79,199,133,200,68,198,16,39,76,121,194,217,21,44,76,142,114,90,85,207,200,172,72,217,45,0,201,73,155,215,89,37,94,174,179,60,101,28,166,194,127,79,159,62,37,123,213,122,185,164,124,115,160,127,203,9,21,161,5,201,16,152,94,230,140,48,9,30,27,136,167,22,200,106,125,153,103,9,161,151,149,224,52,17,36,193,133,123,215,69,193,53,116,130,116,4,45,4,208,122,206,75,1,242,98,169,220,72,135,54,57,0,34,33,75,90,208,43,198,227,122,146,77,206,206,202,96,33,128,87,0,101,156,209,180,44,242,13,153,33,240,199,28,254,216,71,60,103,26,205,41,19,40,104,198,163,137,45,173,201,238,243,30,58,222,46,22,21,19,100,193,68,114,77,10,118,43,128,170,132,151,91,211,4,76,67,145,126,20,229,234,4,113,157,33,22,160,111,242,228,73,41,151,120,3,184,159,60,153,244,209,114,194,203,37,169,62,231,68,100,75,54,146,142,14,1,11,64,50,255,156,191,162,130,93,0,26,139,142,214,151,1,98,46,202,71,147,34,74,63,33,206,184,34,99,103,39,72,200,44,37,57,168,221,35,229,146,165,168,187,134,136,159,39,191,222,221,221,157,174,179,52,62,94,174,196,230,254,254,254,215,94,110,0,193,36,145,102,79,110,56,93,61,148,35,192,81,229,60,62,0,18,139,35,102,237,39,172,72,149,61,233,223,218,184,78,50,6,166,140,150,149,125,1,190,245,16,250,42,147,142,18,134,72,185,32,149,118,155,228,38,3,245,190,201,242,156,92,50,229,14,88,26,36,95,174,97,97,218,83,228,79,137,114,2,243,228,154,45,233,31,107,6,0,228,163,242,40,248,171,118,93,35,182,49,236,32,246,42,198,72,194,217,98,127,242,190,98,28,220,75,161,54,51,121,122,0,59,64,95,147,176,65,9,184,160,228,227,218,249,61,64,46,144,185,98,28,93,242,72,159,134,106,10,92,87,209,7,152,143,238,71,187,92,82,174,84,0,235,103,58,162,216,115,125,46,240,56,179,7,20,155,237,77,126,201,184,88,195,130,94,224,89,11,150,72,175,189,115,5,78,79,253,109,135,51,177,230,69,119,21,242,226,5,137,186,163,251,224,38,111,188,107,69,187,187,146,178,157,123,249,103,213,44,225,195,242,133,230,107,102,205,191,31,167,12,179,171,2,130,101,218,196,35,212,7,53,72,50,200,4,170,193,176,162,56,221,193,3,12,104,15,5,248,220,5,237,142,132,185,220,153,170,216,220,25,86,124,238,96,238,99,178,7,199,54,92,118,125,135,184,214,158,2,61,151,216,172,216,144,238,122,28,134,81,144,11,0,183,244,24,127,134,148,120,16,139,253,107,132,54,171,105,142,42,171,33,197,223,161,229,70,232,180,65,183,21,171,217,130,174,115,225,50,216,112,189,73,210,122,125,91,173,142,22,29,6,177,51,22,226,145,61,41,150,63,70,82,111,28,29,18,187,200,114,193,56,161,58,208,44,74,110,60,94,37,227,4,249,140,129,98,140,219,59,148,40,246,186,65,6,163,76,245,249,100,93,36,39,114,177,30,211,28,66,116,220,198,19,86,160,206,146,74,137,186,195,150,67,12,175,236,234,209,253,22,129,71,166,229,61,194,80,139,73,54,163,99,213,98,49,145,63,196,120,149,236,143,139,241,199,118,136,239,97,152,51,77,49,203,25,10,90,92,119,205,30,179,107,227,244,152,221,112,20,9,148,115,163,114,11,165,178,1,12,228,227,85,184,82,52,108,15,193,134,198,131,44,15,172,165,152,31,250,168,196,16,88,203,171,167,189,121,57,40,92,121,249,111,80,183,10,20,143,10,66,249,216,12,83,154,12,38,225,86,104,152,107,189,125,63,75,29,150,89,115,103,158,169,22,139,246,251,176,73,77,10,205,112,148,105,192,68,101,185,203,215,137,40,121,159,145,206,10,72,119,104,158,253,5,170,74,37,223,141,122,25,67,13,22,216,170,0,143,189,118,27,4,138,90,9,175,155,239,238,106,54,181,210,96,216,119,39,47,30,100,192,25,19,215,229,216,100,254,112,181,202,209,90,105,129,69,145,212,93,95,148,32,203,50,205,22,25,75,223,22,38,174,36,117,239,39,160,76,114,100,69,57,93,146,130,46,217,254,4,28,244,228,192,50,245,142,115,65,35,135,73,192,89,9,214,96,81,148,85,189,192,202,239,55,29,41,137,108,219,157,236,61,53,75,249,163,216,224,170,146,161,155,179,122,13,245,189,138,58,128,184,81,35,245,47,212,132,102,53,1,196,142,108,120,87,150,66,13,40,11,25,94,28,67,160,90,80,251,146,65,144,8,64,166,216,171,201,18,154,191,133,216,38,155,106,115,112,255,137,136,223,114,237,114,144,192,134,111,202,41,33,145,22,246,248,172,245,93,65,102,11,18,117,32,127,2,226,214,121,110,182,191,211,144,29,31,166,41,146,20,31,65,133,46,152,26,253,144,137,235,115,84,8,38,89,105,182,176,4,37,201,170,178,144,73,210,75,38,110,24,43,166,29,50,227,55,0,55,245,119,95,166,190,78,136,27,223,32,107,98,20,106,197,8,89,160,251,12,89,225,238,92,45,84,197,31,174,25,103,209,45,122,177,219,24,112,210,63,209,103,169,28,174,122,93,150,159,214,43,242,203,47,240,237,29,91,192,76,112,53,1,214,213,12,170,57,36,64,97,244,95,37,75,79,153,152,85,51,229,203,21,76,164,136,155,58,164,53,8,190,42,147,13,202,29,149,38,196,39,37,95,82,17,77,238,254,113,31,223,253,118,63,153,106,78,105,222,235,31,67,187,150,179,119,31,34,42,35,172,157,123,146,80,108,23,70,199,183,9,91,41,147,184,109,120,128,157,201,248,152,243,146,71,45,202,129,35,36,87,18,210,66,134,189,144,179,182,171,136,137,132,126,70,228,46,13,27,156,205,178,219,248,140,85,21,212,185,53,117,247,150,62,33,219,91,98,208,63,245,108,237,132,155,113,219,229,123,93,248,59,229,177,72,170,43,23,0,149,201,190,234,45,111,229,160,45,213,9,122,106,39,19,123,144,167,110,97,240,123,220,174,195,4,157,135,26,10,234,4,199,153,186,250,110,59,84,96,67,192,9,70,45,24,242,174,188,57,42,215,5,86,12,245,42,102,44,218,37,247,93,255,171,84,214,114,189,74,9,170,182,87,212,190,225,185,235,76,186,152,44,223,162,49,213,106,11,106,82,103,21,213,103,141,208,217,130,49,177,169,12,42,182,251,146,209,232,184,214,165,168,249,222,232,217,160,130,1,75,26,237,226,229,13,172,134,188,50,53,49,104,116,143,126,25,233,190,234,131,31,10,187,25,76,247,9,230,206,222,202,172,16,255,252,61,62,163,183,127,182,83,69,127,230,147,66,94,89,87,249,70,124,162,220,162,72,126,184,1,41,228,93,243,177,145,41,146,130,104,148,34,32,50,237,127,122,145,61,40,247,178,4,81,102,41,241,43,98,208,24,221,234,209,81,115,79,97,105,231,67,24,225,126,218,58,196,41,53,112,138,83,213,220,87,96,232,158,209,190,253,213,21,158,81,29,213,243,244,74,187,77,14,163,227,197,172,122,3,113,249,45,151,103,19,81,131,184,143,10,181,155,240,178,179,106,190,169,102,75,136,24,42,71,112,54,219,32,214,155,129,146,133,86,253,251,56,196,41,126,102,233,136,212,225,190,150,14,51,98,213,25,40,72,220,161,70,110,85,227,168,211,144,115,158,161,69,232,137,62,191,100,165,33,210,33,57,16,239,214,57,139,234,133,165,11,155,170,93,186,241,115,167,158,19,207,153,128,192,157,176,212,162,93,26,189,218,121,45,74,249,19,15,116,32,175,141,20,74,215,59,166,169,38,197,225,252,144,107,109,192,186,82,27,128,237,117,72,200,26,82,114,172,48,47,55,132,3,95,208,29,173,212,82,198,202,71,122,34,13,85,219,233,127,211,141,12,18,39,229,52,57,48,59,197,200,173,195,161,20,90,200,39,233,224,160,124,147,95,175,66,138,222,166,96,234,47,176,148,50,106,203,243,82,93,107,118,251,43,20,79,32,200,151,155,195,42,137,134,101,47,67,172,73,1,42,179,212,255,102,216,49,161,252,130,175,25,1,47,209,221,86,40,220,95,150,101,78,60,62,229,33,33,166,149,28,56,73,153,131,221,20,91,88,154,133,103,197,42,124,236,219,149,205,86,82,85,126,27,89,76,110,160,212,146,135,213,171,224,89,88,64,42,218,80,142,218,40,195,66,232,76,117,87,15,73,66,171,188,223,147,58,97,213,177,2,205,236,110,89,8,245,210,221,239,88,24,122,14,218,167,54,38,239,140,145,246,35,111,69,176,91,241,53,251,81,189,237,168,185,89,112,40,127,109,216,9,32,23,0,209,223,15,154,51,172,42,72,165,254,39,107,18,53,164,171,151,58,18,169,25,177,108,49,54,197,251,97,37,131,33,0,10,110,26,240,154,130,74,45,15,159,52,168,69,146,193,89,79,121,199,86,57,77,216,133,190,56,19,233,47,110,1,161,7,71,74,72,237,72,53,226,176,204,39,199,243,63,190,159,184,188,171,135,100,167,103,183,120,191,149,220,144,154,22,124,171,193,219,226,165,156,56,162,224,151,114,33,165,125,67,10,50,133,37,253,196,203,208,185,82,135,157,90,112,147,3,41,237,250,112,202,98,145,244,20,246,34,195,150,160,96,184,34,48,53,192,162,92,213,8,122,253,77,71,227,28,173,53,108,182,148,88,253,45,214,112,145,91,2,198,23,229,92,34,136,118,167,173,251,95,15,211,225,115,216,24,229,172,82,113,2,219,230,250,108,47,38,126,166,55,27,172,47,239,201,108,69,35,114,142,239,162,222,219,112,178,90,93,232,222,46,200,122,108,127,69,118,130,146,178,128,169,34,251,75,118,131,80,214,205,189,195,129,227,72,191,21,154,47,227,201,64,26,4,205,10,85,194,228,163,239,63,141,75,252,116,123,227,162,108,119,135,108,19,237,55,169,101,249,5,5,139,117,157,233,0,12,8,55,144,134,105,113,78,14,142,91,88,122,42,107,181,188,44,42,97,7,242,50,201,184,3,96,103,73,99,31,78,207,186,153,177,105,26,215,26,0,12,228,144,115,186,137,154,2,173,233,156,89,128,113,211,81,81,117,159,108,30,235,174,247,41,47,215,171,151,166,24,198,230,183,78,145,206,169,184,222,141,77,171,102,111,159,252,214,148,129,46,25,106,251,145,189,226,191,216,198,211,62,29,236,231,152,18,194,237,229,126,159,166,142,147,60,126,149,20,251,107,85,100,61,125,29,199,148,252,229,240,55,104,240,184,21,149,189,26,169,51,236,192,1,202,139,190,206,135,143,124,83,14,60,147,89,254,64,71,199,67,81,95,107,7,173,197,3,114,56,220,163,113,138,139,112,195,38,182,58,46,110,67,198,71,233,195,26,35,161,13,236,142,104,89,216,54,151,97,51,228,255,150,247,56,203,235,118,148,190,185,249,117,150,124,156,13,6,59,153,91,89,96,7,203,72,51,236,192,141,183,69,9,250,104,131,236,18,254,40,171,244,239,103,132,105,30,93,179,228,147,213,123,161,3,87,127,30,108,42,114,161,166,31,48,96,51,95,197,162,195,29,38,179,199,161,130,188,233,52,185,39,12,35,45,202,123,232,136,42,221,185,20,172,26,252,122,120,84,139,92,215,36,11,154,87,246,229,185,29,73,114,102,58,99,237,115,198,113,205,42,131,68,151,79,62,43,71,46,226,103,103,208,1,214,78,96,192,73,56,5,86,13,244,247,223,102,117,249,55,77,245,152,214,56,43,210,74,95,220,71,101,211,81,165,255,238,126,79,134,190,153,28,232,34,44,181,211,253,13,249,196,54,234,174,25,89,209,140,247,30,135,73,162,220,11,95,17,228,173,146,23,231,0,60,46,113,223,216,135,214,206,109,252,141,106,253,180,86,176,33,21,147,219,15,9,228,197,2,23,211,200,14,90,125,28,170,89,34,171,249,85,125,231,245,251,176,217,49,241,217,0,69,67,134,238,50,207,195,206,71,8,204,27,99,195,149,147,227,64,170,190,139,94,58,62,43,60,104,188,120,57,103,190,94,44,178,219,22,122,160,190,185,161,213,244,69,172,174,94,211,44,244,234,151,124,201,224,14,106,63,4,168,235,197,92,26,244,197,151,227,250,19,118,98,154,232,168,63,159,131,208,11,225,76,194,88,43,71,213,102,229,73,171,2,220,213,64,243,118,107,71,143,59,183,230,29,171,192,145,22,146,11,78,101,68,106,206,115,21,72,119,220,0,42,55,235,186,44,135,41,227,204,103,37,55,103,120,49,182,15,55,24,12,67,167,54,70,243,207,237,101,49,30,154,191,97,212,79,153,160,89,30,180,147,186,47,213,180,168,59,34,242,40,110,111,175,74,183,122,141,171,118,94,82,124,63,174,204,253,4,140,117,24,82,211,218,122,230,227,68,251,18,138,245,244,4,131,191,116,0,111,185,190,254,18,217,118,226,123,18,50,210,81,11,173,202,38,245,145,39,59,186,135,107,110,64,146,241,23,191,30,207,109,99,91,149,77,209,22,231,34,30,219,236,97,118,224,62,106,213,119,19,85,11,168,11,166,143,255,94,168,255,61,243,223,32,29,121,122,159,178,156,93,81,193,156,94,237,192,13,169,111,85,83,182,174,126,245,86,132,78,203,80,189,24,194,110,97,231,81,78,157,165,210,250,246,240,216,87,9,39,25,102,112,220,92,2,69,6,49,227,169,46,55,166,33,236,182,11,190,254,1,184,119,149,109,111,49,2,166,147,172,126,179,223,96,25,127,119,92,114,163,190,16,139,200,212,248,200,171,141,214,184,14,111,157,26,181,137,249,139,26,187,126,143,63,19,108,9,32,173,163,168,216,94,218,188,220,71,50,113,122,164,164,142,207,122,240,126,71,93,96,252,60,185,107,19,115,143,187,153,96,126,239,204,195,209,238,220,137,123,16,19,32,181,109,161,222,105,241,76,159,53,140,52,85,249,79,10,184,151,107,204,45,223,111,104,172,129,50,27,153,49,57,80,118,6,42,227,250,208,113,166,142,255,140,129,83,5,42,108,126,187,175,47,181,88,247,186,180,130,121,110,40,111,125,81,252,84,206,231,83,11,253,148,52,143,250,221,246,197,240,59,150,161,135,118,234,112,12,91,44,227,222,197,6,226,95,53,57,176,223,79,106,223,228,191,95,97,67,219,207,77,39,77,197,34,211,29,71,122,234,137,144,20,217,188,149,89,200,87,84,74,38,230,154,78,229,62,120,37,246,50,117,39,79,205,140,95,1,120,86,36,34,218,197,91,23,199,20,207,78,117,133,209,122,151,43,101,90,233,222,131,131,114,100,187,247,81,207,74,59,188,83,104,204,97,153,173,165,212,188,200,241,51,16,104,113,162,83,20,124,225,169,49,213,85,91,59,166,73,142,80,235,56,126,48,251,42,24,88,160,91,43,227,97,48,62,186,27,115,21,218,86,50,63,170,118,44,177,94,218,181,255,21,1,121,247,163,190,10,29,60,88,174,235,53,115,230,102,212,196,215,197,112,157,114,187,189,16,178,93,61,102,15,193,200,127,0,99,117,145,27,116,72,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("53dfc9d5-8345-4de0-994f-2835d022341e"));
		}

		#endregion

	}

	#endregion

}

