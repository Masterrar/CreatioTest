﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: BaseAsyncReportGenerationControllerSchema

	/// <exclude/>
	public class BaseAsyncReportGenerationControllerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public BaseAsyncReportGenerationControllerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public BaseAsyncReportGenerationControllerSchema(BaseAsyncReportGenerationControllerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("0d21f704-7f46-4ff9-bf04-3bbd8721391d");
			Name = "BaseAsyncReportGenerationController";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("f8ef1a6f-6619-48e3-9227-afa9b7782f83");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,87,219,110,27,55,16,125,86,128,252,3,161,22,200,170,80,87,175,69,100,217,80,221,216,53,224,164,134,37,163,15,69,81,80,212,72,34,178,34,55,36,87,177,96,232,223,59,188,236,125,87,54,242,98,120,201,185,207,57,51,148,160,123,208,41,101,64,150,160,20,213,114,99,226,107,41,54,124,155,41,106,184,20,239,223,189,188,127,55,200,52,23,91,178,56,106,3,251,105,241,93,170,252,13,43,84,219,239,165,152,54,164,227,187,191,90,71,40,221,101,164,230,55,126,132,84,42,179,0,117,224,12,186,197,21,196,55,148,25,169,56,232,150,147,107,153,36,192,172,41,29,223,130,0,197,89,75,230,158,139,111,120,136,199,63,41,216,162,40,185,78,168,214,31,201,239,84,195,92,31,5,243,81,56,125,23,22,198,104,148,181,172,156,218,100,50,33,23,58,219,239,169,58,94,134,111,84,81,160,65,24,77,40,89,161,33,66,87,218,40,234,98,33,114,67,168,53,188,83,82,200,76,19,229,28,144,109,225,129,176,194,69,156,123,152,84,92,164,217,42,225,172,176,73,152,141,248,45,1,19,159,86,168,232,152,220,189,154,224,224,197,37,89,22,7,107,105,40,38,246,145,60,40,126,160,6,252,125,234,63,108,228,218,16,140,203,150,248,154,38,201,138,178,175,143,144,160,97,177,125,82,9,153,145,225,36,248,255,44,215,144,76,188,247,92,52,92,197,250,192,38,95,164,225,155,227,112,26,34,0,177,246,65,212,35,186,225,144,172,251,194,81,64,215,82,36,71,130,120,123,68,148,99,116,240,160,36,3,173,165,34,255,169,230,209,43,190,80,46,5,101,16,107,61,254,58,235,25,114,178,238,58,47,166,222,130,52,136,85,88,159,183,209,119,110,25,58,24,108,193,132,255,6,10,76,166,68,175,79,114,117,69,162,222,203,25,185,5,211,227,42,26,141,92,192,131,147,253,123,58,95,48,7,23,149,89,130,186,146,133,28,243,162,229,41,191,1,186,209,40,100,214,110,26,134,235,56,235,7,193,17,169,110,46,186,250,125,25,249,200,95,137,185,222,228,158,136,11,238,229,80,199,64,145,239,203,99,138,189,64,42,155,41,57,245,234,116,208,14,179,104,126,247,153,57,112,101,50,154,52,73,22,218,99,57,214,2,195,129,42,164,194,183,12,144,155,51,242,167,49,169,139,247,217,204,153,47,141,173,217,157,99,182,109,48,14,94,39,59,45,181,105,154,226,200,113,61,241,44,198,2,63,25,158,112,91,39,171,237,90,88,19,138,130,199,0,151,28,145,63,15,95,234,198,78,47,29,115,226,52,124,59,200,62,131,217,201,222,17,112,150,78,231,96,30,138,103,179,55,84,127,93,96,79,44,51,158,52,40,172,158,240,139,229,42,174,36,125,77,217,206,179,57,79,182,133,203,115,209,92,70,190,80,2,190,87,137,51,87,219,108,143,216,138,4,46,106,185,137,138,96,70,99,82,249,255,188,238,80,213,209,53,28,55,241,54,170,145,35,175,222,109,198,215,100,97,40,78,104,156,165,6,188,82,228,142,21,48,169,214,119,235,177,151,194,109,154,98,255,224,110,93,45,93,115,196,248,13,143,117,180,145,118,241,160,246,4,200,1,252,24,92,161,94,225,53,191,177,218,203,194,55,74,148,129,4,153,28,95,30,185,109,194,120,177,83,173,115,61,61,138,93,45,154,151,75,108,67,84,7,198,184,39,243,206,42,47,12,22,119,95,162,49,76,147,168,233,7,71,90,150,152,150,101,127,220,174,250,23,4,76,224,187,231,234,49,198,108,31,168,217,125,18,12,151,111,212,109,40,188,187,172,118,224,110,105,50,68,230,250,112,70,215,39,84,42,51,175,118,15,98,107,118,133,114,48,22,251,227,150,244,31,28,7,184,230,14,7,51,156,27,212,24,36,152,133,243,148,108,120,2,150,15,191,204,158,150,55,191,254,246,225,195,75,153,114,62,59,218,155,34,158,107,205,183,226,6,149,243,237,144,151,218,35,229,213,209,56,174,78,250,113,61,175,113,71,224,163,26,168,106,105,191,101,23,149,163,205,61,249,6,3,127,237,94,132,92,236,240,69,107,214,146,17,166,96,51,27,190,246,154,139,171,20,214,195,201,165,131,160,127,75,118,170,230,53,34,53,197,168,193,118,79,255,127,254,45,152,169,235,72,12,54,250,24,95,241,19,85,224,102,39,27,154,10,106,247,92,155,11,235,38,223,225,3,163,142,229,83,199,171,199,93,180,244,54,138,208,188,198,32,94,128,253,101,16,169,98,174,92,118,76,185,114,192,85,102,219,40,55,177,148,115,252,29,114,204,3,58,17,92,2,108,71,162,79,207,12,82,7,90,120,30,181,98,44,111,103,120,95,89,114,37,70,188,100,21,30,63,216,239,98,158,88,192,215,251,221,156,56,86,34,10,47,10,95,250,115,67,60,204,161,89,239,148,236,216,171,94,39,178,221,180,141,140,130,151,113,99,161,158,153,56,173,241,216,51,7,127,136,114,254,180,126,120,250,31,16,4,90,57,27,15,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("0d21f704-7f46-4ff9-bf04-3bbd8721391d"));
		}

		#endregion

	}

	#endregion

}

