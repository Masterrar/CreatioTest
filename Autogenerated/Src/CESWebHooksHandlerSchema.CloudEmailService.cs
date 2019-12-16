﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CESWebHooksHandlerSchema

	/// <exclude/>
	public class CESWebHooksHandlerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CESWebHooksHandlerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CESWebHooksHandlerSchema(CESWebHooksHandlerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("c9976940-f70d-4dd0-995b-4a09639dc922");
			Name = "CESWebHooksHandler";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("06435d27-8c1b-4953-b634-242d1f4c8b8a");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,84,77,139,219,48,16,61,59,144,255,32,220,75,2,193,166,215,77,118,15,77,203,238,22,82,2,233,182,199,162,216,227,88,173,34,153,145,148,37,132,253,239,213,151,189,182,201,182,165,23,99,105,52,111,158,222,155,145,160,71,80,13,45,128,124,5,68,170,100,165,179,181,20,21,59,24,164,154,73,49,157,92,166,147,196,40,38,14,131,35,8,203,233,196,70,222,33,28,236,49,178,230,84,169,27,178,254,180,251,14,251,7,41,127,169,7,42,74,14,232,79,229,121,78,86,202,28,143,20,207,119,113,29,227,164,146,72,116,13,4,233,51,121,134,125,237,114,179,54,39,239,37,53,102,207,89,65,10,87,233,74,33,114,67,62,80,5,27,202,184,37,219,85,79,46,158,193,43,81,41,148,166,66,91,178,91,100,39,170,33,196,155,176,32,133,139,19,38,52,249,8,21,53,92,63,10,13,120,162,156,220,146,247,203,136,5,162,12,112,67,236,45,202,6,80,51,240,224,82,67,161,161,28,194,43,141,78,202,31,13,202,2,148,250,98,245,183,192,105,160,27,111,180,13,177,116,25,18,35,14,145,39,171,63,43,59,140,109,15,194,153,148,36,7,208,228,130,160,13,138,65,133,229,139,11,191,92,103,242,83,238,91,22,61,81,119,103,81,252,141,192,231,152,121,165,120,4,29,20,126,75,181,13,232,90,150,111,249,225,156,184,135,206,133,217,147,2,180,30,10,75,201,37,155,193,114,30,185,184,36,246,234,219,204,254,207,135,221,59,236,242,108,119,86,59,208,218,222,74,101,182,218,55,202,13,204,134,216,11,143,156,164,27,107,21,50,206,251,74,69,43,90,146,233,124,25,104,84,190,116,160,177,26,55,84,75,54,233,49,29,29,9,48,94,196,36,74,203,250,161,127,86,214,143,78,8,142,103,209,111,172,17,172,216,202,162,187,225,176,207,129,172,252,80,214,97,140,178,46,49,31,103,174,26,138,244,72,132,117,251,54,29,42,150,222,61,246,224,92,204,77,87,12,102,171,220,103,122,160,56,218,93,131,157,36,43,35,167,22,226,191,140,239,55,206,40,33,72,27,95,139,93,81,67,105,236,69,159,180,93,187,1,206,66,117,219,226,227,54,104,219,222,255,220,163,52,77,88,245,198,113,209,113,136,77,35,12,231,11,162,209,64,248,206,255,224,94,216,29,110,218,189,223,181,215,153,178,170,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c9976940-f70d-4dd0-995b-4a09639dc922"));
		}

		#endregion

	}

	#endregion

}

