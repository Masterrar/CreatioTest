﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SysProcessLogArchiverSchema

	/// <exclude/>
	public class SysProcessLogArchiverSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SysProcessLogArchiverSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SysProcessLogArchiverSchema(SysProcessLogArchiverSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("8c2d19de-199d-4977-9d50-3cf2588d6d21");
			Name = "SysProcessLogArchiver";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("920a417a-9c96-40b0-b7b5-e7da9902441a");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,181,88,221,111,219,54,16,127,118,129,254,15,132,247,34,3,142,146,180,88,187,54,113,6,127,165,245,144,166,89,147,174,15,195,80,48,18,29,11,149,37,149,164,210,122,133,255,247,29,191,36,82,162,28,7,67,95,18,139,186,239,251,221,241,78,25,94,19,86,224,136,160,27,66,41,102,249,146,135,211,60,91,38,119,37,197,60,201,179,167,79,126,60,125,210,43,89,146,221,161,235,13,227,100,125,210,120,6,250,52,37,145,32,102,225,27,146,17,154,68,53,141,45,150,146,174,243,112,158,241,132,39,132,117,18,204,38,45,189,23,73,246,21,14,225,248,23,74,238,64,61,90,100,156,208,37,120,243,26,45,164,196,205,152,70,171,228,158,80,73,86,148,183,105,18,161,196,80,181,137,122,63,36,97,239,240,240,16,157,178,114,189,198,116,115,102,14,36,25,185,39,12,17,201,134,40,137,114,26,179,176,226,56,180,89,238,243,36,70,90,116,48,80,134,110,149,185,36,139,149,197,142,245,211,20,51,246,90,120,119,69,243,136,48,118,145,223,249,236,143,4,157,159,12,121,28,55,62,85,106,32,79,28,103,28,84,93,209,228,30,115,162,222,23,234,1,69,226,61,98,156,138,80,191,77,24,207,233,230,10,146,154,199,160,242,154,112,14,231,211,60,38,104,132,250,77,11,224,149,34,237,159,180,69,66,220,209,140,44,113,153,114,71,236,12,111,24,8,123,126,228,225,209,102,120,244,124,80,193,159,230,37,136,245,155,98,147,60,96,80,151,216,95,143,118,88,5,186,38,229,114,9,97,7,253,50,31,145,118,172,122,227,83,171,185,157,4,86,18,204,65,255,68,103,205,197,74,149,197,243,132,164,113,87,10,41,193,113,158,165,27,244,145,17,10,249,206,84,121,162,207,165,243,124,226,229,153,77,230,223,73,84,130,27,232,115,124,107,126,119,208,38,82,16,64,254,84,121,53,212,222,157,161,207,88,33,240,58,90,145,53,126,135,139,7,28,146,176,164,101,4,186,132,91,18,234,218,43,5,123,47,224,3,203,218,218,216,1,18,77,171,215,179,236,135,0,55,156,233,53,162,1,20,22,125,248,177,29,170,94,203,39,224,201,200,183,93,97,80,134,244,126,52,211,59,108,35,166,143,182,67,15,181,170,231,154,65,61,107,182,46,158,148,172,161,73,57,138,230,169,163,74,114,109,165,95,219,221,153,121,71,248,42,239,196,154,108,115,10,236,201,191,208,232,180,199,127,150,132,110,16,35,226,102,80,191,71,232,13,209,133,15,132,245,165,33,223,6,240,206,83,193,178,12,131,193,80,176,170,67,121,41,93,115,76,249,12,180,7,131,129,202,204,98,54,153,230,208,123,179,24,170,26,50,199,175,165,102,157,159,133,117,20,52,210,62,80,225,11,225,238,200,131,170,110,205,41,244,187,192,205,220,34,150,33,133,7,96,134,7,67,121,78,243,181,214,96,121,173,205,179,109,10,21,196,72,96,161,109,96,231,193,137,108,21,48,133,185,64,55,15,38,159,46,225,246,54,1,191,199,212,113,221,132,99,132,148,129,85,4,137,10,120,45,97,216,174,213,191,235,183,255,200,224,171,55,144,180,114,157,49,113,204,44,1,3,143,151,90,253,227,156,157,166,4,83,39,218,129,237,94,36,213,59,153,189,128,240,232,154,59,19,180,168,15,41,65,10,214,146,39,6,106,78,12,2,85,40,100,201,202,243,46,48,136,100,6,142,33,230,205,167,21,161,196,125,53,148,74,7,128,160,160,14,178,144,160,2,221,160,181,157,48,129,179,140,220,59,96,58,12,62,141,45,140,12,209,194,14,148,182,65,28,217,225,117,139,85,4,169,163,98,148,209,75,24,203,112,180,66,70,157,18,10,24,244,136,239,89,178,67,133,34,7,128,138,67,11,86,173,201,230,144,233,176,240,22,142,29,248,133,159,18,190,122,11,183,57,11,228,223,240,50,191,200,163,47,131,26,5,95,200,70,105,93,136,130,168,89,209,104,212,184,135,127,87,8,122,109,119,211,133,30,103,28,155,254,200,147,44,16,127,110,54,5,129,220,195,220,59,172,39,130,78,155,52,140,222,103,117,175,25,162,86,135,1,48,177,249,215,18,167,78,148,44,47,92,56,58,162,234,206,84,9,81,92,225,21,166,32,7,134,223,102,70,195,138,201,32,146,18,94,210,204,134,196,238,162,85,234,27,221,223,173,61,64,170,69,170,144,250,63,240,47,134,183,157,151,134,54,69,123,210,88,39,156,29,39,172,7,91,166,227,10,146,255,194,105,217,106,16,195,135,70,209,225,206,137,210,235,137,83,154,29,189,214,174,104,81,13,78,221,202,83,21,97,53,28,152,187,162,38,63,105,52,81,161,179,170,4,93,145,44,212,245,14,36,104,36,187,132,126,35,67,161,74,237,38,23,172,129,11,147,90,166,207,63,113,81,223,36,80,108,157,151,184,118,70,164,20,171,37,75,82,168,245,64,57,214,185,105,52,76,49,202,194,143,60,186,204,191,133,227,88,238,23,193,65,91,240,35,97,101,212,253,36,92,237,216,180,134,157,107,147,215,5,27,3,109,76,116,205,15,54,213,59,156,225,59,88,107,214,250,255,168,185,57,132,227,162,176,219,135,92,200,221,137,57,244,8,116,50,165,133,139,144,44,228,70,26,145,201,70,88,100,183,246,199,205,167,214,210,224,221,224,63,72,205,76,95,254,232,171,236,76,60,135,141,26,250,18,186,85,187,28,199,183,169,252,80,225,217,233,229,137,178,159,157,157,30,154,95,214,150,162,186,157,183,215,185,192,217,115,8,105,77,164,63,169,227,111,247,8,155,26,163,235,176,233,169,17,177,130,68,201,50,33,177,233,39,59,130,87,8,139,80,6,86,141,250,117,127,234,159,105,184,90,82,151,112,126,122,40,233,119,177,223,228,253,179,177,49,132,211,156,2,168,180,29,45,110,147,47,123,31,240,102,209,38,64,173,201,185,217,140,205,182,135,140,69,15,207,91,22,8,246,94,78,140,116,123,55,177,36,183,247,16,239,108,104,89,109,49,239,15,130,66,117,70,148,194,176,148,64,213,51,61,36,136,74,172,144,177,50,91,203,46,40,152,184,75,195,118,23,83,231,218,88,93,25,213,197,63,172,239,27,102,110,24,231,182,228,152,151,76,206,129,34,250,82,76,93,38,226,232,77,153,196,65,127,62,123,54,158,63,123,249,242,96,242,98,254,236,96,118,126,124,124,240,234,229,241,228,224,232,232,120,246,226,104,254,234,249,111,211,23,253,129,117,177,58,227,115,189,104,116,36,22,46,210,34,112,45,215,25,236,153,1,185,239,126,46,168,119,205,138,226,49,85,46,102,230,142,181,181,177,233,72,74,75,247,67,179,236,5,89,242,247,48,178,81,57,18,251,100,97,74,50,190,191,68,57,30,183,185,170,61,75,247,184,70,124,20,189,229,154,234,148,13,170,107,157,126,41,231,50,231,122,202,214,167,149,1,227,44,110,114,194,70,91,136,118,45,0,37,185,47,224,221,123,170,4,120,160,84,163,175,33,181,219,175,203,50,77,131,253,38,112,85,32,238,55,102,141,114,14,0,212,107,151,253,65,75,206,91,55,20,103,12,75,112,24,69,61,235,227,141,62,105,126,116,112,115,218,65,228,255,252,180,15,181,250,192,101,40,125,31,1,236,87,102,213,56,105,187,40,62,58,36,62,31,183,40,194,92,236,170,243,239,17,41,100,175,34,230,215,192,23,172,15,208,103,110,113,244,197,23,47,190,162,249,183,154,223,90,90,253,131,74,251,163,255,246,63,113,109,0,28,119,25,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("8c2d19de-199d-4977-9d50-3cf2588d6d21"));
		}

		#endregion

	}

	#endregion

}

