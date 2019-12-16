﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IndexingDetailListBuilderSchema

	/// <exclude/>
	public class IndexingDetailListBuilderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IndexingDetailListBuilderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IndexingDetailListBuilderSchema(IndexingDetailListBuilderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("dda1fec8-fa97-417a-afb0-5e95a8f4439c");
			Name = "IndexingDetailListBuilder";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("eef27540-b1e9-466b-87b9-62933f9468f4");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,237,26,219,110,219,56,246,217,3,204,63,112,53,192,192,6,12,101,119,31,147,218,65,110,45,140,109,210,236,56,179,243,48,24,4,138,68,39,68,116,113,68,42,173,55,147,127,223,195,155,68,138,212,37,110,139,121,217,151,54,34,207,141,231,206,67,231,81,134,233,54,138,49,186,193,101,25,209,98,195,194,179,34,223,144,251,170,140,24,41,242,240,67,90,220,69,233,26,71,101,252,240,227,15,47,63,254,48,169,40,201,239,209,122,71,25,206,142,90,223,128,156,166,56,230,152,52,252,128,115,92,146,216,129,249,72,242,167,102,209,100,156,101,69,238,223,41,113,215,122,120,145,51,194,8,166,0,0,32,63,149,248,30,184,163,179,52,162,244,16,173,242,4,127,1,164,115,204,34,146,126,36,148,157,86,36,77,112,41,128,15,14,14,208,59,90,101,89,84,238,150,234,91,236,83,196,30,48,34,28,25,39,40,17,200,52,212,24,7,6,202,182,186,75,73,140,98,206,174,155,27,106,36,17,226,238,44,73,38,47,66,154,90,246,235,178,216,226,146,159,233,144,255,205,64,161,56,145,32,109,137,197,194,57,222,68,85,202,164,188,92,67,108,183,197,168,216,136,67,96,193,47,172,145,77,225,39,91,77,29,21,207,160,85,146,224,90,206,27,78,67,81,182,214,184,15,76,38,247,152,169,191,38,37,102,85,153,91,136,225,175,91,10,39,56,18,0,175,252,223,215,30,249,215,36,219,166,74,221,194,235,76,141,247,74,125,78,132,175,193,198,59,202,74,96,62,71,242,255,37,186,165,130,170,52,5,61,178,241,158,73,201,170,40,237,195,95,155,232,157,135,182,185,160,227,99,52,109,45,45,80,142,63,247,49,82,4,39,47,40,128,208,99,81,204,78,146,164,196,148,6,243,122,37,64,175,243,6,236,36,142,139,42,55,193,212,138,23,236,148,164,41,48,90,229,155,194,6,149,144,175,179,145,86,226,225,89,229,36,150,22,250,182,198,66,183,177,73,125,111,163,157,121,168,116,219,206,199,83,154,208,187,179,135,37,45,121,134,236,233,0,127,35,83,197,69,90,101,57,138,82,18,81,76,81,10,169,103,31,91,189,39,41,195,37,144,222,70,37,161,69,206,227,124,217,82,226,85,149,221,113,24,206,240,68,242,27,111,68,63,131,179,1,250,35,205,235,195,116,77,237,131,234,52,187,95,222,218,9,130,237,67,145,227,219,92,144,148,54,8,252,72,225,197,19,168,164,241,136,128,225,47,172,11,246,170,96,18,252,171,124,66,74,165,93,35,135,54,96,208,37,228,177,123,212,122,5,84,58,172,173,112,59,109,201,81,247,48,164,64,235,183,162,0,89,160,64,174,5,30,109,253,132,243,68,22,94,187,10,67,168,130,216,85,204,138,146,215,97,81,231,61,250,93,229,208,125,64,108,253,23,92,37,18,174,66,0,47,202,227,186,2,191,163,24,163,184,196,155,69,240,43,229,114,229,185,108,145,2,116,176,148,157,67,216,82,186,108,42,58,219,137,169,77,7,85,214,231,76,28,241,16,221,129,251,78,91,91,74,181,183,246,50,40,200,94,56,26,161,159,75,204,30,138,68,180,40,228,57,98,184,199,247,62,96,70,17,40,0,151,66,47,178,37,17,94,167,117,36,107,72,159,35,138,21,8,132,40,19,80,139,64,162,112,251,254,70,216,195,186,218,108,200,151,96,121,222,16,66,159,97,29,81,177,1,10,22,184,13,41,233,92,84,35,192,46,136,133,104,252,128,179,72,202,241,238,64,195,72,167,22,167,212,174,12,71,146,152,215,2,113,45,240,184,48,83,5,224,19,79,171,255,57,42,245,137,23,13,165,211,157,192,247,34,74,183,85,1,33,33,194,255,68,105,133,143,134,226,94,232,254,17,239,208,51,7,135,115,146,154,247,221,238,47,212,251,89,69,89,145,161,162,68,178,95,210,167,242,107,253,95,120,39,142,123,13,226,59,117,183,173,193,145,22,48,251,52,176,131,213,240,133,239,73,73,217,167,82,53,192,211,4,45,150,94,130,104,177,64,73,8,226,41,19,113,194,158,238,1,232,251,122,147,209,108,194,53,139,74,70,249,194,84,178,179,93,194,60,139,44,39,20,28,73,18,237,211,221,108,134,142,189,242,30,90,36,7,189,236,186,196,188,72,65,14,180,172,73,101,172,243,245,167,10,243,253,206,50,35,237,252,92,144,68,17,195,150,65,228,181,233,223,146,200,84,155,113,3,23,192,40,126,64,83,35,162,72,110,155,82,195,78,36,9,25,169,156,208,14,97,250,4,134,81,236,36,248,5,125,82,17,168,20,60,33,27,52,229,128,127,131,70,160,74,211,154,220,196,18,41,132,110,92,33,114,243,204,57,109,77,225,117,92,133,62,217,110,83,174,41,173,186,172,72,200,134,224,228,83,142,54,162,19,232,82,158,19,162,192,59,88,26,101,199,57,121,0,133,71,151,41,55,68,77,82,50,47,54,181,52,88,202,132,167,147,184,217,65,152,132,44,131,242,147,237,148,57,46,235,83,201,246,134,78,189,118,209,30,138,218,2,184,57,84,98,130,33,1,45,252,165,40,84,50,110,226,81,106,239,66,24,155,23,104,135,225,212,36,164,172,86,35,133,80,223,184,170,5,164,148,35,92,209,147,244,115,180,163,107,204,167,29,64,118,3,1,135,219,136,43,122,14,53,155,228,2,2,90,9,7,0,124,70,18,156,58,167,148,160,66,113,174,198,106,10,10,140,31,92,237,9,63,228,223,103,16,25,12,203,213,105,119,215,57,119,20,60,111,244,165,146,204,96,121,49,156,128,23,149,232,254,30,122,4,217,104,178,136,62,34,146,188,189,184,88,37,165,223,71,99,195,59,207,58,252,177,131,83,171,124,201,162,213,129,173,235,210,80,95,112,210,28,127,149,52,122,117,203,82,237,227,177,161,124,11,74,215,24,20,4,218,239,213,62,100,190,44,226,126,37,191,193,215,174,32,57,125,42,47,178,45,171,253,89,149,188,99,20,188,252,253,245,229,31,175,183,47,255,124,13,32,181,243,207,91,253,109,215,17,73,237,189,160,62,149,76,230,150,200,38,233,185,33,249,176,171,52,53,194,42,56,111,45,21,142,37,165,187,114,151,14,150,210,209,197,0,172,223,252,121,251,166,23,44,197,127,86,87,106,221,146,186,211,155,42,32,158,2,111,87,45,95,20,162,70,250,218,246,142,108,3,229,206,215,89,236,91,245,230,30,238,67,133,208,72,239,215,252,206,171,146,142,200,226,205,241,52,25,145,146,77,38,42,115,203,15,222,18,229,137,106,228,122,239,139,53,61,46,151,77,175,45,224,36,46,64,11,185,78,192,186,34,215,193,228,28,249,183,50,218,202,214,188,181,184,133,115,117,42,104,98,238,132,107,204,32,140,98,156,24,133,67,244,97,2,199,165,194,201,91,58,226,77,251,162,21,145,58,114,3,29,136,178,217,232,22,201,109,82,30,247,236,78,146,132,10,215,81,126,39,166,27,202,188,223,180,47,225,190,208,27,186,27,79,24,89,100,125,113,198,41,251,16,71,53,45,166,87,119,116,43,61,177,109,47,106,175,116,232,104,10,250,1,133,211,85,69,189,171,111,105,163,76,27,179,126,168,224,8,194,70,156,233,42,81,36,248,178,29,86,124,91,140,58,104,104,173,139,51,175,18,147,28,205,232,158,196,214,25,173,73,53,199,242,246,42,252,138,115,205,45,130,141,86,199,86,161,26,148,5,191,195,50,255,190,219,89,204,14,29,145,220,149,63,194,223,109,156,85,98,3,253,17,174,146,64,49,50,212,56,111,148,48,235,110,190,212,167,85,18,71,140,81,134,95,122,84,210,214,49,200,89,191,169,177,10,122,174,221,223,167,87,234,15,246,173,60,79,162,130,222,238,171,218,67,68,55,242,156,26,214,59,38,208,5,110,100,135,181,109,13,118,0,198,25,188,88,81,172,182,173,165,5,106,141,218,66,115,251,50,202,163,123,72,159,188,228,173,212,117,204,154,2,25,131,5,139,172,41,219,254,60,218,39,84,156,120,61,245,29,69,86,85,244,231,159,45,246,173,106,171,58,73,190,102,12,91,59,251,16,49,188,217,52,13,136,9,167,4,82,6,33,73,221,47,180,166,111,70,147,173,141,204,11,101,200,11,165,49,151,49,111,58,195,101,222,60,164,190,3,170,210,110,40,11,91,215,56,45,226,44,252,84,38,184,60,221,157,208,120,58,27,106,5,188,114,153,55,192,206,171,179,40,61,53,83,3,227,10,127,97,150,204,102,79,214,66,80,6,131,173,113,183,61,149,124,204,75,159,234,151,173,33,234,91,51,147,122,5,134,204,20,203,28,53,38,51,73,33,110,48,160,66,5,169,175,127,76,45,128,68,236,97,252,77,174,245,212,209,237,101,111,201,51,182,136,95,157,100,190,123,232,143,9,110,213,148,138,203,166,25,228,206,125,214,105,96,109,109,204,173,227,132,242,134,57,46,240,148,36,13,171,65,231,21,29,236,86,210,67,105,81,60,86,91,237,196,172,208,243,44,245,0,192,175,160,93,63,154,112,219,90,67,231,157,253,45,84,59,19,110,140,91,119,210,146,218,0,138,158,155,233,94,77,119,187,231,246,252,46,68,246,196,73,162,12,242,81,232,79,165,61,203,65,205,83,206,145,43,182,210,249,220,83,207,121,251,138,94,70,219,16,254,189,199,255,183,228,87,90,114,197,181,248,23,153,243,236,1,199,143,218,116,132,63,160,170,223,92,141,53,216,88,245,10,70,77,106,26,208,243,55,241,2,93,90,110,202,10,35,72,172,205,41,245,25,187,202,79,109,169,187,162,72,121,21,90,209,149,68,241,24,168,199,10,150,237,116,10,231,41,126,117,159,23,208,117,55,63,69,11,37,19,185,172,152,216,134,151,244,103,237,66,96,204,189,101,5,16,34,19,122,3,253,7,228,126,165,237,243,136,69,162,158,137,91,49,104,128,111,91,139,71,38,178,116,198,14,244,112,165,246,173,222,208,83,71,187,95,104,45,187,181,170,159,98,249,11,127,172,198,80,47,149,38,213,204,11,253,252,51,242,67,132,146,235,194,145,100,80,99,106,189,62,54,244,215,82,127,35,7,170,216,51,57,69,254,240,233,74,6,138,144,255,141,109,196,107,220,145,59,157,140,155,110,214,25,81,122,126,101,83,107,105,236,44,213,160,47,91,165,185,201,210,184,55,13,14,182,68,79,187,87,231,74,7,51,4,29,200,13,215,214,175,14,192,255,244,95,60,21,118,60,136,59,38,108,186,85,199,211,173,108,64,173,60,160,176,168,25,50,180,113,101,171,201,242,62,93,3,63,161,248,230,245,186,161,197,167,147,106,77,176,129,188,33,205,123,124,220,122,103,127,27,149,225,30,79,189,161,70,121,130,148,240,190,126,192,125,91,229,222,163,166,104,223,127,154,57,102,58,210,158,237,9,98,111,61,201,160,239,12,79,33,59,158,32,187,170,253,62,179,77,254,67,165,176,131,79,51,209,236,205,244,110,142,183,222,130,157,33,192,119,186,63,113,6,141,65,234,113,133,117,163,185,108,237,55,181,199,193,108,191,180,40,21,180,225,174,225,146,235,125,41,8,229,75,65,91,216,185,67,193,172,130,111,28,208,122,159,150,79,49,251,140,113,238,50,226,162,206,209,237,166,44,178,245,83,10,133,29,223,144,12,95,70,113,89,192,50,43,218,139,179,153,167,84,54,2,246,12,88,229,170,185,8,43,255,3,105,221,146,170,240,48,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("dda1fec8-fa97-417a-afb0-5e95a8f4439c"));
		}

		#endregion

	}

	#endregion

}

