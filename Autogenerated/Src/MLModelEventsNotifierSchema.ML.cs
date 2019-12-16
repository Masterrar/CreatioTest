﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: MLModelEventsNotifierSchema

	/// <exclude/>
	public class MLModelEventsNotifierSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public MLModelEventsNotifierSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public MLModelEventsNotifierSchema(MLModelEventsNotifierSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("860938f2-0364-4231-a0af-c137b37cb23a");
			Name = "MLModelEventsNotifier";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("33c09d4f-db5e-4d77-bac6-f1fd801beedb");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,86,219,110,227,70,12,125,214,2,251,15,83,245,69,6,18,121,211,236,6,233,218,14,144,248,18,184,136,211,32,78,218,199,197,88,162,237,105,165,145,59,23,167,238,98,255,189,156,139,37,89,182,147,188,72,35,14,135,228,240,28,146,226,52,7,185,162,9,144,39,16,130,202,98,174,226,126,193,231,108,161,5,85,172,224,241,228,238,227,135,239,31,63,4,90,50,190,32,211,141,84,144,119,26,223,120,36,203,32,49,250,50,190,5,14,130,37,123,58,3,170,104,37,172,187,203,243,130,31,222,169,5,114,88,65,192,49,121,60,184,57,186,53,162,137,42,4,3,137,26,168,243,179,128,5,122,32,253,140,74,249,149,76,238,38,69,10,217,112,13,92,201,251,66,177,57,3,97,21,219,237,54,233,74,157,231,84,108,174,252,183,87,144,68,75,16,146,208,89,161,21,154,32,185,177,65,192,26,137,183,103,219,181,195,43,61,203,88,66,18,227,244,152,207,224,187,245,91,69,136,9,86,20,85,190,146,7,193,214,84,129,219,95,185,15,146,152,125,34,149,48,151,118,102,18,155,61,196,224,58,205,25,127,230,76,77,65,41,220,151,247,136,61,233,145,112,146,237,249,118,135,110,69,161,87,97,199,135,0,60,117,81,236,134,52,98,144,165,199,226,17,64,211,130,103,27,242,140,201,193,224,185,35,9,249,166,119,190,59,7,207,220,106,150,146,111,120,37,133,112,77,147,37,228,244,121,156,98,196,28,94,236,102,20,158,93,220,12,207,47,190,156,157,94,142,134,191,156,126,62,251,242,235,233,229,96,240,233,244,250,242,211,249,224,243,197,229,249,96,112,30,182,222,184,193,131,40,86,32,20,98,120,228,22,54,144,99,217,180,73,34,166,66,130,96,1,202,175,2,1,74,11,3,24,210,109,183,160,240,240,22,1,172,21,245,7,205,52,68,141,132,156,56,35,193,123,32,60,177,241,197,195,124,165,54,45,155,201,224,135,121,254,120,253,214,150,74,66,155,66,48,247,182,100,116,26,77,150,91,193,24,189,50,154,177,255,144,233,212,34,192,44,21,177,115,20,115,162,150,128,71,0,9,40,96,222,11,15,178,57,108,95,57,178,199,165,147,118,211,75,119,69,5,205,9,199,107,245,194,221,148,132,87,79,232,196,200,12,203,189,48,238,182,237,9,107,192,23,212,65,231,81,131,128,187,182,91,30,181,93,105,220,95,66,242,247,181,88,232,28,77,221,235,44,139,154,49,249,124,55,208,67,138,30,224,247,27,120,76,64,45,139,163,133,52,30,114,140,66,208,89,6,93,3,247,21,65,234,60,81,129,140,235,187,2,145,209,246,22,107,42,176,136,164,206,148,175,149,59,38,149,59,21,249,128,217,156,68,175,19,186,215,171,211,170,193,106,103,189,198,53,235,83,130,153,1,232,51,154,218,85,203,248,118,203,38,191,91,206,156,153,27,58,231,81,88,247,31,158,144,208,223,105,156,134,91,205,145,40,114,171,103,128,28,243,199,34,131,114,239,183,130,241,200,60,158,54,43,136,199,232,68,160,141,29,155,173,248,247,3,110,140,253,120,44,135,255,104,154,53,141,59,11,86,80,69,241,231,18,4,28,214,52,203,29,123,238,110,241,131,225,39,40,164,224,171,9,111,121,100,220,188,138,6,55,195,127,33,209,88,156,36,157,149,203,94,179,113,198,67,46,181,128,193,77,37,138,90,37,90,222,214,216,76,222,71,236,170,88,58,105,181,236,121,192,98,103,30,156,56,170,220,85,134,130,151,37,203,32,170,14,199,230,85,243,20,4,182,71,38,91,216,208,120,77,249,214,144,212,36,195,246,58,207,196,58,198,157,173,21,71,172,248,58,77,163,210,86,185,235,152,230,95,238,185,207,199,119,87,217,91,13,175,156,235,166,183,185,97,94,188,32,179,222,221,190,240,199,74,210,5,184,190,229,63,200,28,81,228,53,30,28,106,96,107,38,20,18,136,172,139,237,216,217,84,29,237,17,18,182,98,166,181,69,126,204,123,211,91,44,76,105,255,212,164,9,34,48,150,35,160,152,45,24,114,211,69,112,120,78,238,234,140,148,97,171,81,230,205,250,22,128,132,77,209,229,179,98,25,51,243,18,97,182,255,76,238,127,106,99,220,116,31,247,180,202,174,131,151,7,154,44,73,212,32,11,227,135,186,89,25,141,241,157,216,17,234,251,89,233,194,13,214,104,239,31,161,226,229,181,70,188,133,37,100,51,39,125,45,4,230,209,20,114,92,114,113,59,120,251,53,38,39,205,205,169,158,253,5,199,54,7,32,19,193,86,126,14,120,112,60,115,59,219,244,54,83,20,247,49,51,166,4,253,198,222,255,128,79,192,219,243,221,73,119,133,40,251,31,191,158,74,48,232,11,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("860938f2-0364-4231-a0af-c137b37cb23a"));
		}

		#endregion

	}

	#endregion

}

