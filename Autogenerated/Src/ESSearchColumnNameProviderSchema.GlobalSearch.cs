﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ESSearchColumnNameProviderSchema

	/// <exclude/>
	public class ESSearchColumnNameProviderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ESSearchColumnNameProviderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ESSearchColumnNameProviderSchema(ESSearchColumnNameProviderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("affbec52-d465-4d51-b908-721b11c940ab");
			Name = "ESSearchColumnNameProvider";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("3c3a921b-299a-4f38-a040-5c0154a25bee");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,165,86,219,110,219,56,16,125,118,129,254,3,87,93,20,54,54,144,223,235,56,64,210,164,169,129,38,48,86,105,95,138,69,192,72,35,155,88,137,50,120,73,99,168,254,247,14,69,217,162,46,140,215,221,23,27,18,231,204,156,153,57,51,34,167,57,200,13,141,129,60,128,16,84,22,169,10,63,22,60,101,43,45,168,98,5,15,111,179,226,137,102,17,80,17,175,223,190,41,223,190,25,105,201,248,138,68,91,169,32,159,117,158,17,156,101,16,27,164,12,111,129,131,96,113,99,227,250,66,67,157,243,175,138,101,178,49,112,73,8,240,189,15,63,209,88,21,130,193,32,210,13,130,231,104,241,78,192,10,9,145,143,25,149,242,3,185,137,92,6,247,88,129,165,40,158,89,2,162,178,158,78,167,228,92,234,60,167,98,123,81,63,223,32,82,177,152,200,10,72,158,168,132,132,176,124,147,65,14,92,85,133,34,69,138,48,0,18,11,72,231,193,194,23,35,152,238,157,158,79,157,40,223,175,33,165,58,83,87,140,39,152,207,88,109,55,80,164,99,175,155,201,228,31,68,109,244,83,134,180,98,147,216,43,121,145,15,196,235,8,189,148,85,222,77,153,176,119,138,114,133,165,90,10,246,76,21,216,243,141,125,32,2,104,82,240,108,75,62,83,185,142,64,157,75,37,144,242,5,2,243,92,115,22,87,245,184,6,69,177,183,100,110,160,35,14,63,122,230,101,128,145,20,182,178,133,11,206,72,112,25,199,133,230,157,247,187,153,75,34,54,36,137,117,69,190,20,197,191,122,99,115,139,116,154,178,23,50,39,1,75,130,89,157,25,240,196,38,215,206,244,19,131,44,57,154,230,87,9,2,153,114,43,107,242,168,91,207,179,65,140,71,233,228,113,229,29,129,215,136,86,45,17,218,168,222,208,173,186,94,179,181,10,240,247,126,220,161,223,102,63,33,101,213,159,78,82,88,190,129,44,71,62,246,104,238,73,56,92,84,90,138,171,89,30,237,94,207,242,14,212,186,240,246,163,238,245,149,102,89,50,160,180,170,151,227,218,40,101,153,2,241,128,51,116,182,199,37,149,85,20,175,33,167,166,62,251,204,159,169,112,204,111,53,75,76,54,248,23,46,169,144,48,110,206,38,179,3,32,62,148,25,141,111,162,195,196,132,181,234,151,184,3,216,139,181,103,41,25,119,3,204,219,179,82,225,101,184,92,23,28,140,209,34,169,144,163,159,63,123,212,134,145,209,93,100,113,251,172,70,14,195,191,230,228,207,32,44,187,5,216,61,110,76,188,210,165,127,175,243,39,211,246,102,144,118,193,204,227,240,20,244,142,64,38,225,20,110,10,94,84,104,126,246,30,170,95,1,74,11,238,148,223,149,213,144,80,92,109,184,226,172,55,185,125,112,165,208,101,130,253,117,77,195,230,100,54,136,65,251,206,44,133,55,92,49,181,181,199,119,148,211,21,8,252,52,170,253,100,92,109,141,183,113,79,159,141,122,134,246,106,88,237,78,198,101,31,120,208,64,93,173,35,19,227,102,103,39,198,67,165,221,196,38,241,186,162,243,22,46,180,111,205,37,64,213,25,182,34,53,139,170,246,222,159,43,223,182,49,46,47,51,70,247,169,219,163,54,237,73,95,181,70,105,165,119,86,119,3,34,12,203,6,126,152,131,97,9,90,125,190,34,68,235,246,4,33,130,163,154,223,22,85,171,228,127,67,10,2,240,176,215,217,102,7,30,122,233,134,63,185,151,191,209,74,55,252,89,43,186,51,8,45,82,248,145,48,151,167,154,131,13,212,25,86,135,216,192,238,153,59,28,195,135,226,75,241,3,196,130,35,119,134,242,24,79,220,189,211,236,240,218,243,53,85,244,27,205,116,181,174,195,133,180,55,16,242,254,61,57,198,241,143,19,57,162,104,29,21,62,150,253,187,206,238,255,173,200,255,168,73,83,2,207,38,236,213,125,72,105,67,75,201,29,138,86,204,161,133,227,2,125,11,108,210,31,198,227,151,141,254,109,170,46,15,138,179,123,171,58,94,39,151,166,143,224,0,181,250,93,155,237,238,23,108,18,130,36,159,13,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("affbec52-d465-4d51-b908-721b11c940ab"));
		}

		#endregion

	}

	#endregion

}
