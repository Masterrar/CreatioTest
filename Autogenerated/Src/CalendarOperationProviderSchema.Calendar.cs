﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CalendarOperationProviderSchema

	/// <exclude/>
	public class CalendarOperationProviderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CalendarOperationProviderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CalendarOperationProviderSchema(CalendarOperationProviderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("c1cfad1f-fd4b-4c49-8ad2-e4e9a4356b9d");
			Name = "CalendarOperationProvider";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d2179f89-6a33-4745-96ee-fd30f06a5c1f");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,237,87,75,143,219,54,16,62,43,64,254,3,235,94,180,89,87,238,57,126,0,91,59,91,44,144,214,1,226,182,135,162,88,208,50,181,225,86,162,92,146,114,226,6,254,239,29,62,69,89,15,187,77,47,5,122,89,47,169,121,126,243,205,104,196,112,65,196,30,167,4,109,8,231,88,148,153,76,150,37,203,232,83,197,177,164,37,75,150,56,39,108,135,185,120,249,226,243,203,23,81,37,40,123,66,111,62,73,194,4,60,22,83,127,247,254,40,36,41,206,207,96,45,207,73,170,76,137,228,123,194,8,167,105,75,230,45,101,127,212,151,61,145,116,11,112,146,220,227,84,150,156,146,32,22,23,244,134,22,228,39,70,37,154,95,206,47,113,194,96,6,12,125,205,201,19,60,71,203,28,11,129,94,123,147,235,61,49,154,239,120,121,160,59,194,181,244,100,50,65,51,81,21,5,230,199,133,61,223,49,84,58,97,180,183,210,40,43,57,74,173,173,196,105,78,2,213,125,181,205,105,138,82,237,183,215,43,68,244,48,16,82,244,89,135,229,179,184,167,36,223,169,52,222,113,122,192,146,152,167,123,115,64,156,224,93,201,242,99,109,114,230,255,91,225,227,2,61,186,136,167,157,106,223,97,65,150,101,197,36,128,92,128,176,251,119,106,131,0,85,19,71,51,40,40,132,144,188,82,213,211,161,233,196,141,200,57,158,250,226,1,138,67,113,78,255,36,2,97,196,200,71,68,193,0,102,192,222,50,67,242,3,1,21,66,80,202,73,54,31,245,130,51,154,44,12,184,137,119,52,57,247,52,219,99,142,11,196,160,59,230,35,151,251,104,177,1,23,190,118,179,137,22,210,58,191,174,183,162,204,137,36,191,105,124,76,5,123,35,136,251,96,118,182,111,144,106,181,40,242,176,3,127,27,21,56,253,39,81,106,233,72,219,113,70,71,157,80,5,199,134,210,23,131,57,110,79,3,231,247,34,206,209,1,238,50,61,95,142,240,76,207,2,51,110,142,48,204,228,204,89,246,228,183,15,23,241,205,212,90,246,109,49,119,134,148,166,87,136,125,44,97,97,251,58,230,7,34,63,148,182,143,75,9,99,149,236,6,152,0,126,132,46,120,56,111,174,170,165,139,206,22,83,29,145,132,243,112,57,119,48,20,20,198,70,203,157,134,117,14,56,175,172,130,254,183,45,205,137,172,56,19,139,187,84,86,154,214,59,148,83,33,21,153,3,150,57,169,142,110,116,72,161,135,55,172,42,128,62,219,156,156,113,5,144,130,95,17,55,7,153,135,97,140,86,54,25,159,213,24,186,74,154,144,29,139,212,197,71,66,126,23,218,130,162,146,211,87,21,255,197,63,137,61,221,18,117,185,33,197,62,7,171,99,107,205,16,167,63,214,29,4,10,198,245,187,20,212,180,221,184,14,171,142,192,90,170,163,240,8,234,92,161,255,181,173,177,207,201,42,184,60,54,165,243,1,175,89,14,16,222,21,23,18,51,230,194,52,104,134,226,33,91,139,48,94,139,99,228,193,78,75,38,41,171,200,166,84,87,224,216,115,234,110,183,211,73,4,120,191,66,221,184,38,33,24,209,91,160,206,25,160,228,147,228,120,213,133,106,211,255,120,16,149,111,218,200,71,182,84,234,39,129,30,47,89,236,125,89,145,147,254,107,200,171,229,254,230,20,184,244,202,116,177,250,86,49,244,217,30,235,11,21,54,52,183,5,235,202,9,81,183,58,64,153,86,185,93,114,232,161,148,195,253,94,131,52,90,252,88,21,91,216,100,160,145,245,45,146,37,122,178,241,246,143,1,119,225,74,216,53,220,6,134,129,121,155,116,176,160,89,249,158,126,111,147,245,224,32,157,235,87,109,219,112,28,116,21,8,186,217,48,196,85,163,160,22,197,88,153,167,32,254,237,20,126,102,129,127,56,223,222,250,142,241,178,207,70,246,25,100,157,51,56,5,146,81,24,156,146,177,84,13,154,206,63,239,110,185,103,116,91,39,242,10,81,71,246,150,229,117,150,53,18,93,233,43,97,165,163,228,158,114,33,215,124,69,50,92,229,48,60,208,28,134,91,178,12,220,107,191,38,142,121,35,46,125,233,29,171,33,99,253,125,5,101,168,242,188,78,87,245,32,68,17,135,193,221,24,225,100,153,151,140,196,222,204,9,145,92,144,90,211,150,118,157,169,10,245,150,204,73,247,229,179,170,45,180,114,176,79,124,4,253,193,42,177,243,120,149,116,11,46,212,116,226,115,179,191,122,20,65,37,21,94,206,208,233,242,36,234,156,45,96,6,22,76,61,237,245,102,233,214,55,221,200,142,54,141,81,67,25,16,181,48,223,93,255,100,208,24,43,242,226,82,17,236,149,157,59,101,223,22,242,243,240,6,114,30,193,197,49,227,139,162,16,239,24,41,189,139,105,215,118,145,169,14,87,88,207,160,197,61,193,125,193,140,205,240,173,242,165,187,107,207,50,116,221,34,123,205,2,99,118,174,96,203,170,145,9,119,8,155,98,189,116,184,87,14,105,47,28,255,243,245,74,190,94,201,208,127,129,134,23,137,80,207,85,71,137,199,107,57,241,120,45,41,162,232,242,87,82,77,136,107,139,13,223,162,20,22,49,243,249,98,15,253,229,216,212,132,211,97,119,87,68,33,14,33,185,145,32,226,16,63,87,161,7,6,95,99,144,225,194,121,117,133,104,227,210,176,229,161,30,123,197,129,133,211,220,54,47,79,127,1,98,155,77,188,50,20,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c1cfad1f-fd4b-4c49-8ad2-e4e9a4356b9d"));
		}

		#endregion

	}

	#endregion

}
