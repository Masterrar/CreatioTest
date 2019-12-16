﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: FolderManagerServiceSchema

	/// <exclude/>
	public class FolderManagerServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public FolderManagerServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public FolderManagerServiceSchema(FolderManagerServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("2bec5c05-e607-4c38-b513-0c2f1b93db25");
			Name = "FolderManagerService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("be1f674b-cdb4-46e4-8c46-23cae20b9205");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,86,75,143,226,70,16,62,19,41,255,161,196,94,140,132,204,125,102,96,69,208,48,225,48,179,8,178,201,33,138,34,99,151,161,181,126,144,238,54,19,103,52,255,61,229,126,24,219,52,134,155,187,92,207,175,190,170,238,44,72,81,28,131,16,225,55,228,60,16,121,44,253,69,158,197,108,95,240,64,178,60,243,151,121,18,33,127,13,178,96,143,124,139,252,196,72,249,227,231,159,6,133,96,217,30,182,165,144,152,62,118,206,254,166,200,36,75,209,39,3,22,36,236,63,229,235,66,203,184,123,205,35,76,252,121,40,217,169,163,215,76,42,77,175,253,225,120,77,238,47,131,80,230,156,161,112,105,252,129,187,179,95,250,255,133,227,158,194,195,34,9,132,120,0,87,229,74,111,50,153,192,147,40,210,52,224,229,204,156,45,50,113,206,225,61,231,63,224,157,201,3,236,121,94,28,133,53,153,52,108,254,156,139,227,27,74,10,127,164,154,119,44,97,178,220,224,63,5,227,152,98,38,133,215,60,84,0,193,20,110,152,84,90,190,17,68,163,191,40,200,177,216,37,44,132,176,170,199,89,14,60,192,47,129,64,115,26,195,202,165,52,182,237,170,240,218,162,16,132,209,86,6,18,253,213,6,131,232,91,150,148,77,41,197,173,232,81,163,185,100,152,68,4,231,154,87,237,213,8,14,142,250,96,146,34,198,157,144,75,228,240,119,220,22,60,54,149,95,56,139,190,203,170,110,106,168,73,238,215,32,139,146,202,112,223,252,105,164,186,173,131,47,152,69,58,25,115,182,125,206,51,33,121,81,49,132,210,83,88,153,236,52,110,46,48,188,209,3,236,8,50,111,4,31,131,207,219,234,223,133,170,38,195,176,98,54,20,173,163,245,213,145,194,7,124,246,103,190,230,249,145,240,161,74,175,224,218,40,109,206,247,69,197,15,104,167,210,214,128,233,12,50,124,119,217,121,195,118,122,195,113,199,211,232,6,204,237,100,115,73,86,24,217,116,205,241,130,8,221,51,229,215,229,6,192,215,175,224,93,72,167,122,126,245,228,151,254,11,202,167,142,179,153,215,7,197,104,244,216,78,173,143,118,47,14,214,169,92,93,116,52,9,59,127,57,178,238,137,123,71,5,125,29,121,69,121,200,27,51,9,109,242,172,86,89,152,20,17,62,211,14,175,98,175,50,13,224,243,191,24,22,20,2,22,28,73,207,106,25,169,167,149,230,42,161,117,192,233,102,33,172,5,28,235,207,17,33,83,197,25,92,148,122,43,98,127,189,227,235,212,61,7,39,218,54,50,185,31,161,198,90,232,238,125,37,88,178,36,1,65,139,143,54,128,90,247,176,43,33,42,179,32,173,5,49,75,40,104,237,97,210,117,241,164,18,3,50,193,233,144,74,209,181,175,162,225,236,141,234,210,252,6,22,61,77,148,158,219,140,190,169,224,179,229,90,157,239,52,198,10,246,114,27,30,48,13,222,72,50,156,169,70,148,32,148,72,105,53,29,152,133,119,202,89,4,102,170,116,100,239,165,32,81,163,132,49,40,73,59,187,49,225,197,171,171,184,27,119,164,30,22,131,65,103,94,125,243,229,181,28,119,125,94,56,83,99,252,217,211,186,121,20,129,192,68,79,57,26,234,129,204,13,106,254,157,29,19,121,193,67,108,162,215,11,118,132,66,178,76,61,116,238,182,137,235,190,246,171,41,162,9,253,128,107,235,154,150,181,222,118,102,167,108,232,5,72,179,67,115,239,30,66,207,116,171,91,103,221,70,103,69,99,80,173,108,117,122,145,39,69,154,85,127,235,1,87,114,195,146,184,203,143,86,61,150,28,206,104,254,226,128,225,15,59,247,111,69,146,124,227,207,233,81,150,94,133,76,30,123,78,43,179,234,7,221,202,110,122,235,26,88,71,253,101,222,116,219,111,110,131,88,152,218,238,90,142,172,74,109,210,4,242,102,26,109,216,237,170,28,156,2,14,220,114,101,106,119,238,85,58,121,38,118,101,70,55,75,53,63,186,178,223,131,164,160,57,155,58,47,207,234,58,88,95,106,47,121,158,46,117,90,23,224,143,59,60,57,135,101,154,208,141,203,72,167,237,190,169,60,203,176,193,115,103,149,144,153,155,227,77,245,107,109,35,227,27,236,215,94,236,38,35,125,219,62,245,227,179,137,255,225,252,92,112,222,193,23,21,27,52,108,223,252,77,254,46,230,113,172,119,222,212,250,243,181,3,244,28,141,170,61,200,130,103,53,1,154,203,181,115,137,106,105,83,72,146,255,1,73,87,20,75,105,14,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("2bec5c05-e607-4c38-b513-0c2f1b93db25"));
		}

		#endregion

	}

	#endregion

}
