﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ForecastSheetRepositorySchema

	/// <exclude/>
	public class ForecastSheetRepositorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ForecastSheetRepositorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ForecastSheetRepositorySchema(ForecastSheetRepositorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("c34e79ef-1670-4e4f-b615-ef0f2fc4892b");
			Name = "ForecastSheetRepository";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("e0b9d996-6f7e-4520-a678-da960c79be39");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,213,88,75,111,219,70,16,62,43,64,254,195,64,185,72,128,65,181,57,218,146,0,87,177,93,5,137,235,70,78,46,65,81,172,201,145,68,100,201,85,119,151,78,84,195,255,189,179,15,138,111,89,178,11,20,189,216,92,238,60,190,249,118,118,102,168,148,37,168,54,44,68,184,69,41,153,18,75,29,204,68,186,140,87,153,100,58,22,105,112,41,36,134,76,233,47,111,95,191,122,120,253,170,151,169,56,93,193,138,139,59,198,79,79,103,34,73,72,232,131,88,173,232,245,217,110,127,177,85,26,147,250,154,76,115,142,161,177,171,130,43,76,81,198,97,33,83,70,32,177,235,125,112,201,66,45,100,140,170,93,194,224,233,222,9,222,171,174,109,50,125,145,234,88,59,203,36,242,70,226,138,144,194,60,213,40,151,196,209,41,204,115,54,22,107,68,253,9,55,66,197,4,102,107,229,71,163,17,140,85,150,36,76,110,167,126,125,35,197,125,28,161,130,4,245,90,68,10,180,0,137,154,224,223,35,196,233,82,200,196,210,12,236,78,100,26,244,26,97,233,93,4,185,201,81,201,230,38,187,227,113,72,154,30,210,30,68,61,115,90,13,80,246,197,21,106,101,125,41,163,20,236,228,70,117,193,241,134,73,150,64,74,89,50,233,231,192,230,81,127,122,91,2,10,20,32,17,183,140,81,6,227,145,213,40,12,80,176,153,76,213,116,172,16,33,148,184,156,244,45,210,254,104,58,30,229,155,70,218,190,53,200,236,195,224,42,139,35,40,60,14,205,153,61,118,210,156,147,80,4,212,197,92,200,153,82,96,125,60,77,145,144,160,114,170,74,65,238,225,235,158,241,12,119,203,219,46,189,66,204,195,178,225,206,35,120,128,21,234,51,227,245,12,92,184,7,194,51,71,116,28,176,154,70,3,146,162,44,165,43,114,77,98,207,135,181,161,43,46,34,208,219,205,243,25,124,210,70,59,155,55,86,237,150,180,94,194,43,61,104,162,225,56,196,77,165,6,68,155,129,11,39,7,249,255,103,163,220,93,69,195,142,222,62,155,234,131,236,180,211,157,95,65,91,67,183,159,95,194,121,3,69,10,33,114,254,239,69,181,207,222,33,209,205,211,25,233,183,199,120,104,145,42,39,73,35,146,175,11,74,94,198,227,191,217,29,199,63,90,171,151,207,153,227,138,216,154,98,101,50,92,111,143,35,176,77,173,193,211,252,34,205,18,146,35,196,227,95,115,5,143,114,78,205,127,10,187,183,117,218,14,39,109,135,36,167,15,98,51,87,28,207,97,27,194,227,184,12,5,207,146,20,54,76,175,143,99,179,93,177,171,254,206,172,244,13,9,55,88,59,16,40,167,89,131,31,7,177,174,210,0,71,3,8,124,48,66,29,71,249,6,211,200,141,79,149,81,106,102,184,63,133,255,122,138,114,62,16,25,87,194,15,37,93,115,84,31,70,54,153,222,225,146,101,92,255,18,167,17,157,202,192,52,35,177,28,116,105,13,135,141,132,235,144,132,125,67,165,73,71,67,122,78,223,101,140,60,34,254,110,100,124,207,52,186,205,141,91,80,190,16,7,33,241,194,34,145,242,45,204,105,40,135,63,57,253,153,0,61,126,100,41,91,81,165,163,244,48,211,58,202,65,63,247,219,31,158,121,63,213,83,43,142,141,230,117,45,51,51,119,27,239,54,44,239,220,133,216,17,193,224,179,66,73,202,169,155,249,33,171,44,135,96,111,91,175,250,54,152,173,49,252,118,46,87,84,76,82,125,157,113,62,48,147,10,145,93,211,182,35,97,175,87,115,49,169,57,177,66,143,251,195,163,244,162,25,195,12,254,134,90,161,73,19,163,156,92,191,132,154,159,218,210,223,130,39,28,125,116,233,219,113,128,181,9,216,181,26,223,179,114,174,238,153,164,19,86,148,137,20,105,138,223,157,210,192,115,225,118,2,234,75,19,175,23,144,39,147,245,174,138,124,49,215,184,34,106,167,187,157,48,249,54,243,82,84,146,30,187,50,52,29,228,71,108,115,65,89,197,170,215,202,188,181,215,164,233,168,13,131,133,122,213,108,115,174,56,222,118,213,198,62,251,69,103,127,169,23,103,201,251,50,199,230,27,150,249,0,125,22,227,190,81,85,209,231,147,227,196,230,141,91,12,74,158,118,210,230,67,203,103,78,249,74,84,114,47,55,86,54,229,154,80,217,162,207,68,77,181,203,61,229,214,205,110,240,14,149,111,187,56,46,27,157,182,160,178,61,172,23,50,29,174,97,112,241,35,196,141,189,75,152,187,232,153,234,21,92,72,41,228,165,45,241,131,254,57,109,155,53,136,48,204,164,164,123,249,125,29,115,132,247,139,223,174,33,21,26,168,83,197,209,41,60,252,244,120,66,215,77,41,170,121,180,250,153,86,11,205,194,111,183,210,126,199,63,188,125,236,159,56,31,189,18,174,19,192,192,43,153,199,66,163,2,216,135,187,187,125,57,87,195,54,98,253,45,38,74,221,83,227,195,214,199,234,118,23,225,26,19,246,123,134,68,46,170,191,252,29,111,236,213,234,106,80,22,240,117,254,4,58,178,211,66,246,241,144,139,224,60,138,206,57,119,186,46,11,85,94,78,42,21,200,228,44,137,23,129,84,49,156,212,63,214,119,60,57,245,67,234,112,81,30,75,29,230,127,243,3,70,249,195,174,251,119,12,127,220,197,155,106,191,187,72,54,68,173,111,120,37,181,142,19,41,78,163,139,253,29,16,44,213,190,246,115,104,155,220,232,221,63,152,44,144,75,35,20,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c34e79ef-1670-4e4f-b615-ef0f2fc4892b"));
		}

		#endregion

	}

	#endregion

}
