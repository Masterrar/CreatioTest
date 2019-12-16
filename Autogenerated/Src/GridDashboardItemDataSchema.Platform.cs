﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: GridDashboardItemDataSchema

	/// <exclude/>
	public class GridDashboardItemDataSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public GridDashboardItemDataSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public GridDashboardItemDataSchema(GridDashboardItemDataSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("fdc01022-208b-4af7-a431-c65ed004a596");
			Name = "GridDashboardItemData";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,88,93,83,219,56,20,125,78,103,250,31,212,244,197,153,201,152,119,40,157,33,9,101,96,11,101,128,238,195,50,125,80,108,37,104,215,145,83,73,134,205,48,249,239,123,175,62,44,201,113,128,206,150,151,216,242,185,71,71,247,75,18,130,174,152,90,211,130,145,59,38,37,85,245,66,231,211,90,44,248,178,145,84,243,90,188,127,247,252,254,221,160,81,92,44,201,237,70,105,182,58,234,188,3,190,170,88,129,96,149,159,49,193,36,47,118,48,51,170,105,24,156,214,171,85,45,226,119,201,242,83,161,185,230,76,133,225,43,246,164,129,20,53,93,168,90,228,95,185,248,25,190,198,130,37,219,55,158,207,38,240,9,62,126,148,108,9,18,201,180,162,74,29,146,51,201,203,25,85,15,243,154,202,242,28,36,162,66,3,60,56,56,32,159,84,179,90,81,185,249,236,222,17,77,74,15,39,79,188,92,50,157,123,240,65,132,190,223,33,205,134,237,16,210,12,71,63,0,182,110,230,21,47,72,129,98,250,181,144,67,50,161,138,245,104,28,60,27,157,97,69,224,35,45,155,66,215,242,144,92,27,98,11,112,147,244,210,103,96,130,222,18,144,0,99,114,241,109,254,55,132,144,20,38,244,99,242,93,49,9,180,194,134,149,52,201,235,152,112,161,137,230,43,246,87,45,216,183,197,66,49,61,194,249,6,135,100,14,146,51,203,233,185,186,198,29,67,130,249,53,216,254,95,197,238,227,156,139,18,126,33,37,155,149,248,147,86,13,251,189,139,233,227,255,149,5,126,100,162,180,97,75,99,120,45,235,53,147,152,254,135,248,172,129,139,149,206,39,254,149,36,121,132,46,185,101,88,120,147,134,87,37,147,68,197,111,71,191,97,190,250,17,74,137,151,140,124,229,74,127,178,30,254,76,112,226,96,142,22,102,129,3,168,8,243,107,223,6,137,77,153,216,144,99,227,218,60,101,58,178,118,41,52,63,41,203,27,42,150,16,7,246,148,234,120,38,195,90,150,232,122,140,197,112,76,134,178,126,154,214,141,208,248,188,4,225,182,145,13,201,118,228,184,37,211,141,20,29,53,246,219,246,13,65,186,100,250,161,46,141,199,248,35,213,204,251,203,188,144,139,19,232,59,27,114,198,180,201,86,23,247,193,35,149,102,66,88,52,46,193,162,50,167,136,47,136,75,235,252,92,93,53,85,245,77,158,174,214,122,147,1,203,109,241,192,86,244,10,210,47,27,141,60,91,188,132,72,248,224,87,82,3,148,32,125,60,228,245,156,172,215,213,230,214,38,242,196,166,250,23,94,105,0,36,12,14,109,41,28,57,176,38,152,220,252,122,98,244,2,195,6,191,177,225,186,164,235,29,131,211,232,187,2,128,181,180,77,61,51,110,156,159,254,203,138,6,250,28,216,166,85,13,198,170,145,108,54,9,67,89,112,154,227,56,71,199,220,48,138,62,40,195,163,215,145,91,118,102,135,179,48,91,32,26,60,61,240,138,145,44,88,231,248,19,77,21,2,142,125,203,7,221,54,43,239,12,248,91,192,214,68,139,7,187,174,21,56,131,139,174,127,34,202,65,109,155,221,35,54,28,27,62,211,123,38,1,29,73,26,147,108,198,141,11,96,79,114,229,50,38,150,226,243,8,38,203,141,113,16,51,240,114,177,218,76,161,93,184,242,216,100,8,255,131,109,198,118,238,81,48,218,250,7,52,54,134,158,165,197,56,200,54,202,211,110,250,110,247,213,144,75,131,164,140,10,59,214,91,73,206,146,195,252,202,122,232,172,237,0,45,151,133,218,60,179,229,229,156,238,94,122,178,42,124,189,164,130,46,33,224,64,125,14,27,46,21,5,248,223,148,103,183,88,237,52,110,71,130,165,225,217,96,198,213,186,162,46,94,136,131,201,226,185,243,47,80,110,215,123,176,89,47,37,132,101,63,29,104,114,108,175,209,216,239,39,21,167,232,56,215,141,76,23,178,232,54,85,195,150,139,6,38,189,33,107,141,199,219,92,117,212,22,114,77,245,3,80,182,189,9,203,239,187,230,21,30,19,93,128,17,146,5,66,159,58,9,205,148,174,205,198,125,28,205,108,83,216,239,5,217,176,176,152,161,39,216,219,88,19,202,168,108,251,167,66,121,71,113,22,71,121,104,115,107,79,133,199,144,251,33,158,33,134,63,250,88,83,156,95,69,128,58,65,189,104,189,89,199,172,125,110,49,144,126,77,235,90,241,206,100,200,16,127,120,155,47,251,230,197,250,54,67,119,70,64,228,231,253,157,201,180,193,227,23,123,215,203,251,197,125,240,174,151,110,194,133,78,48,196,177,40,236,131,247,29,157,173,85,234,169,14,8,169,224,204,56,10,247,140,171,134,231,183,76,62,242,130,93,214,37,171,96,35,209,76,40,115,33,74,38,109,199,243,187,250,84,52,171,12,165,249,240,108,9,171,20,235,38,228,94,13,59,206,7,77,187,158,79,147,23,35,25,149,230,135,227,189,221,105,167,48,156,14,201,22,76,50,104,125,161,225,189,146,130,125,22,29,89,174,175,155,77,36,158,110,116,180,187,115,56,236,203,155,71,79,235,119,235,185,184,171,255,97,130,132,211,33,104,191,166,18,68,193,33,71,57,237,22,4,218,163,67,164,211,226,84,132,15,222,196,204,13,38,166,29,58,244,219,143,147,123,14,224,143,92,234,134,86,175,29,252,167,208,160,53,75,15,116,206,25,206,93,126,249,221,115,32,182,174,151,201,179,239,157,219,77,103,179,27,147,187,228,186,51,110,167,76,28,214,189,155,252,130,115,162,11,109,247,106,110,6,110,204,12,202,30,178,97,179,50,15,203,244,194,142,81,201,91,134,248,190,238,175,156,237,93,199,239,114,176,78,252,167,67,200,28,55,142,84,238,209,93,99,90,164,93,241,180,94,111,194,237,34,11,120,127,230,111,7,108,89,155,250,105,111,13,187,24,231,79,15,235,28,102,98,164,74,107,178,19,169,36,30,193,44,14,198,139,254,229,238,208,67,234,133,63,242,207,93,39,126,209,179,111,76,226,221,43,137,119,124,146,201,175,156,237,176,223,207,219,244,238,43,140,52,61,177,35,126,232,221,220,118,186,66,232,104,254,154,25,237,107,222,19,167,234,103,126,227,190,247,181,22,219,164,3,67,220,225,220,161,103,97,46,92,51,123,101,220,175,34,192,60,139,215,0,109,212,94,218,38,27,147,151,1,153,230,192,252,213,106,180,163,233,224,246,63,226,12,23,85,51,20,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("fdc01022-208b-4af7-a431-c65ed004a596"));
		}

		#endregion

	}

	#endregion

}

