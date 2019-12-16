﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: PreparingMailingStateSchema

	/// <exclude/>
	public class PreparingMailingStateSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public PreparingMailingStateSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public PreparingMailingStateSchema(PreparingMailingStateSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("9c56d4d2-4922-428f-bb3f-7c5c79878461");
			Name = "PreparingMailingState";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b39fd9cb-6840-4142-8022-7c9d0489d323");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,205,26,105,111,220,198,245,243,6,200,127,152,108,10,132,219,44,8,199,104,129,192,178,28,232,116,22,144,28,85,187,142,129,22,69,48,34,71,43,86,60,54,195,161,164,181,160,255,222,55,247,193,153,149,156,162,104,253,65,38,135,111,222,188,251,154,109,113,67,250,13,46,8,90,17,74,113,223,93,179,252,168,107,175,171,245,64,49,171,186,246,235,175,30,191,254,106,50,244,85,187,70,203,109,207,72,179,23,188,3,124,93,147,130,3,247,249,123,210,18,90,21,35,152,179,170,253,125,180,184,186,161,4,151,176,96,191,184,84,52,77,215,198,191,56,244,229,71,39,203,231,129,142,183,45,110,170,2,22,25,105,217,151,194,231,231,93,73,234,254,249,109,231,184,170,147,236,248,128,244,150,48,128,200,63,50,216,194,42,242,2,236,28,52,1,70,73,106,61,63,62,76,126,58,105,217,142,163,1,224,20,23,172,163,18,2,96,190,165,100,13,132,160,163,26,247,253,27,116,65,201,6,83,216,166,216,94,50,204,136,0,220,12,87,117,85,160,130,195,197,193,208,27,228,239,154,60,138,157,246,12,176,38,134,91,38,206,169,238,52,230,201,70,190,160,130,127,71,85,203,52,158,115,252,176,34,205,166,134,143,203,234,51,65,251,232,175,175,255,242,250,199,31,95,237,165,55,246,189,218,124,73,138,106,83,129,170,251,179,170,169,24,108,126,253,10,254,169,173,223,146,182,148,100,249,52,158,86,164,46,83,4,46,20,234,131,161,4,196,5,57,198,12,47,187,129,130,171,253,134,71,107,1,145,135,67,125,123,210,0,130,147,59,32,234,172,91,175,9,69,191,93,69,86,159,33,241,130,118,27,66,185,146,57,153,29,3,63,37,165,62,75,189,162,143,61,161,32,239,86,58,113,248,250,136,214,132,237,161,158,255,121,250,130,211,132,13,168,163,164,61,44,192,87,15,54,21,90,18,122,87,21,132,63,70,144,43,96,128,85,18,212,106,149,214,184,69,225,123,26,135,17,227,175,184,174,74,12,208,200,62,189,96,219,57,46,104,119,129,41,8,36,190,152,198,145,86,191,38,59,253,229,5,148,185,118,17,93,124,129,214,20,206,227,35,45,208,75,178,233,250,138,147,240,214,46,138,216,247,14,141,97,162,71,40,67,56,39,236,166,75,186,198,18,8,57,39,125,143,215,130,121,116,4,105,0,188,214,95,205,12,91,200,216,253,12,241,100,52,153,220,97,138,32,58,80,6,128,228,35,43,192,95,87,85,67,254,222,181,100,209,94,119,60,110,222,129,29,242,181,85,7,223,51,131,33,95,234,109,115,129,105,34,66,252,3,203,125,163,207,143,6,74,65,152,124,53,215,168,103,123,230,240,198,161,126,31,181,228,126,196,147,36,116,18,248,210,62,138,159,167,136,49,44,27,42,97,135,203,168,0,123,146,116,80,194,6,218,186,164,136,117,165,137,68,60,17,198,11,169,21,148,8,70,242,158,48,111,33,123,63,84,37,143,144,12,44,113,81,206,145,120,55,194,91,148,174,2,174,226,56,247,101,122,80,182,12,5,1,123,27,63,253,93,38,153,230,210,19,209,158,14,124,203,1,93,15,13,136,62,155,14,158,136,166,243,32,48,205,230,207,236,55,124,192,86,243,60,155,163,228,6,135,81,216,226,178,173,84,31,103,57,143,132,248,253,68,144,79,35,17,111,253,207,164,134,8,154,143,204,198,95,240,12,32,142,207,181,5,147,146,78,90,224,148,226,171,154,128,131,131,39,131,251,99,229,223,160,39,181,208,31,110,33,51,222,246,89,16,3,16,83,111,82,238,46,50,200,166,239,16,85,248,248,94,238,20,67,237,249,171,250,204,63,105,68,185,62,81,242,83,93,163,204,69,242,83,126,208,110,179,25,218,135,29,116,32,26,217,196,193,164,31,243,79,55,132,146,236,1,237,251,116,240,72,192,112,213,246,217,67,206,23,180,34,159,92,1,82,151,138,64,100,119,29,56,192,162,133,50,9,242,198,103,50,214,116,150,114,145,136,254,129,224,100,208,207,101,16,92,136,170,7,208,38,226,132,123,146,178,255,116,25,51,139,113,116,213,117,53,90,244,22,116,73,120,245,254,183,129,208,237,73,179,97,219,76,46,64,92,231,255,185,42,36,15,164,80,31,117,208,227,47,89,224,151,188,33,24,154,54,59,29,218,2,158,7,238,90,230,184,143,224,91,179,89,126,74,187,38,147,39,228,171,110,147,253,48,155,73,110,242,131,62,155,238,34,111,234,132,97,35,12,45,86,113,26,16,103,41,205,79,224,113,128,236,82,224,26,83,97,169,217,44,238,63,1,146,125,244,42,105,17,23,132,94,119,180,249,132,43,118,72,224,73,36,175,204,75,79,176,112,76,106,188,93,180,75,2,209,167,4,115,149,28,102,64,195,76,148,215,126,121,15,77,209,146,48,222,20,240,54,138,65,161,50,164,205,96,122,142,33,153,87,117,173,52,239,31,165,101,36,27,172,124,89,19,178,201,34,20,253,25,253,0,85,110,212,76,36,155,162,116,39,86,25,50,72,197,82,243,28,157,85,61,123,187,8,106,182,119,198,217,181,175,187,66,106,130,204,49,202,71,54,111,255,114,15,141,37,79,73,118,9,124,77,178,201,21,128,139,27,148,57,113,6,42,252,228,209,234,108,143,80,5,99,99,10,130,0,19,114,163,128,228,169,34,94,37,176,124,227,199,191,201,196,227,52,95,81,92,220,146,242,160,174,112,79,120,28,75,225,1,26,198,117,240,236,167,0,193,94,244,16,165,60,165,178,248,1,58,2,115,193,42,190,85,34,178,77,189,18,178,138,153,79,41,91,185,36,125,87,223,57,182,162,80,39,3,36,87,66,89,60,151,51,133,26,142,143,198,113,115,47,21,101,243,11,40,135,62,12,205,149,48,169,87,123,206,97,75,6,190,70,214,91,69,43,85,97,236,248,40,252,16,134,52,139,132,141,235,96,141,228,5,101,116,26,47,53,155,126,217,136,81,138,65,107,209,93,130,51,171,175,33,230,57,10,19,186,178,60,75,148,217,11,152,93,98,245,122,254,1,106,92,183,192,116,217,117,178,182,165,39,231,155,15,129,172,162,163,229,162,204,220,220,52,102,104,102,179,188,197,26,248,9,187,161,221,189,224,251,3,44,95,146,107,200,234,160,220,147,135,130,8,36,217,159,166,154,112,4,94,111,235,90,116,95,177,27,4,134,246,232,16,241,132,218,142,1,220,208,150,83,47,241,223,223,84,53,1,50,220,170,98,183,37,125,255,253,158,13,29,26,210,228,66,215,140,115,81,73,105,39,88,148,110,2,19,190,144,139,52,54,115,240,85,253,129,135,81,0,0,218,157,89,218,39,98,230,196,164,40,58,27,138,174,32,88,222,122,62,173,18,214,154,87,193,34,23,169,172,99,221,99,252,45,180,100,131,126,53,182,24,85,168,76,164,128,52,113,127,80,110,1,50,30,1,1,147,201,135,144,225,42,112,224,237,5,4,72,208,222,84,131,139,89,215,118,81,202,109,178,66,225,251,188,194,196,199,45,129,78,59,122,90,213,76,4,139,233,145,109,41,52,187,152,66,23,188,226,101,48,7,48,6,105,240,42,175,28,17,34,55,70,8,113,144,155,232,28,2,27,103,247,128,165,27,134,176,135,78,87,163,180,174,180,63,14,136,185,210,180,214,81,22,177,10,215,147,188,102,51,53,21,114,134,1,222,0,42,28,67,185,29,197,184,142,144,245,177,126,79,212,32,209,33,77,99,159,199,173,75,24,54,117,51,176,234,128,218,2,122,107,109,217,170,90,12,134,79,65,217,222,103,201,122,125,62,70,61,119,73,11,170,176,255,169,80,70,253,156,33,57,210,216,177,104,134,249,255,202,93,227,212,156,204,93,57,79,94,17,158,252,92,173,27,208,72,219,108,162,94,92,130,126,243,17,42,208,81,155,171,33,115,100,194,74,68,5,182,196,119,6,83,22,218,138,13,198,40,98,36,90,159,60,125,124,99,70,164,185,122,50,88,249,96,221,225,175,27,24,114,5,205,63,207,34,185,220,166,111,21,170,156,44,254,104,134,1,31,112,67,158,208,13,48,129,122,62,192,127,116,209,62,161,6,138,124,196,110,112,139,30,227,19,255,167,220,79,242,34,179,54,144,3,188,145,195,162,133,173,100,33,214,161,243,132,234,90,60,103,142,122,139,27,82,220,246,67,35,102,111,252,226,66,102,30,9,32,87,180,62,22,165,114,8,239,35,239,180,8,21,130,141,172,115,62,35,165,80,53,110,55,62,65,77,243,51,88,32,161,125,216,203,24,41,59,196,6,32,249,145,250,180,231,141,77,4,201,33,168,201,38,32,146,165,32,86,11,100,226,48,19,217,184,12,89,157,88,38,147,224,86,2,79,136,212,61,209,188,248,71,57,51,219,221,135,132,128,14,122,241,215,92,177,1,155,12,202,209,246,20,96,7,74,50,62,91,122,231,220,70,228,7,101,105,28,200,179,203,185,171,211,185,163,72,149,124,13,176,49,200,225,234,95,224,154,54,146,228,234,46,113,238,217,148,223,206,206,149,189,206,141,9,206,173,161,205,60,215,127,62,215,142,175,95,58,72,240,180,42,137,190,49,131,164,191,129,192,70,144,30,145,240,155,184,44,58,226,149,69,139,51,190,62,244,191,68,70,50,194,206,2,4,208,147,2,135,116,43,139,19,49,225,144,59,151,132,185,179,111,54,244,126,51,161,40,22,83,219,62,15,64,249,20,6,62,218,65,140,25,12,36,198,52,142,171,203,49,127,128,16,8,55,43,162,254,84,83,217,247,207,80,25,31,214,56,125,79,234,184,253,221,12,46,89,183,217,144,210,182,206,19,5,110,45,251,172,91,231,252,234,3,170,213,6,51,29,103,167,255,80,211,3,14,12,249,231,14,180,79,205,68,204,222,88,172,32,67,253,243,13,58,228,157,1,170,160,214,197,242,54,31,77,209,247,26,149,228,84,232,245,241,21,143,211,61,191,153,224,228,127,167,232,251,46,15,166,230,38,240,136,84,199,51,65,104,121,186,105,88,14,133,170,46,120,79,230,85,169,210,135,119,142,96,199,103,190,76,62,113,241,216,219,168,3,161,63,16,140,184,142,65,88,14,227,121,223,201,3,128,144,14,114,228,242,134,11,38,42,2,198,111,203,108,171,101,0,248,228,199,232,122,118,21,243,169,73,114,174,18,145,116,48,160,208,69,202,142,34,35,86,27,206,32,9,240,97,158,73,1,222,124,205,38,172,29,3,182,137,87,139,216,138,193,22,28,126,3,154,26,52,58,148,142,206,210,25,164,192,140,211,102,138,12,100,123,250,255,40,172,156,80,218,81,43,219,168,73,9,152,63,230,115,96,86,194,126,4,10,36,39,18,61,190,227,117,130,201,25,86,61,210,235,184,131,153,110,58,162,255,216,77,48,167,83,156,225,179,206,47,20,249,197,102,254,145,21,31,186,251,57,175,100,207,138,207,50,249,203,217,243,244,144,75,150,147,44,208,77,103,206,225,17,104,147,250,64,245,226,192,243,126,205,247,188,224,134,213,180,213,154,17,105,177,151,164,169,90,254,251,160,44,145,118,230,208,145,159,44,109,75,86,213,189,56,116,207,169,64,35,23,62,59,34,81,36,16,61,233,188,203,59,214,212,149,170,234,170,244,0,91,190,102,163,89,183,186,223,139,93,146,186,247,127,191,190,54,151,20,205,23,95,11,142,239,102,21,113,207,222,204,74,184,103,239,101,93,146,166,115,143,177,153,223,221,196,200,240,26,152,160,48,9,110,219,140,252,174,112,207,43,119,187,46,79,121,225,229,186,186,11,249,47,12,110,195,95,162,72,132,201,95,174,104,186,157,223,191,88,154,237,162,4,178,63,84,145,88,199,191,101,25,205,26,44,10,117,80,244,151,33,1,58,231,83,156,201,244,239,84,2,76,73,192,44,36,199,183,202,208,105,118,212,185,114,213,95,132,181,127,3,96,37,170,208,198,40,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("9c56d4d2-4922-428f-bb3f-7c5c79878461"));
		}

		#endregion

	}

	#endregion

}
