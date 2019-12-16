﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SupplyPaymentServiceSchema

	/// <exclude/>
	public class SupplyPaymentServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SupplyPaymentServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SupplyPaymentServiceSchema(SupplyPaymentServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("23c7aa6b-167a-48e3-ba60-3683f5ff5f9d");
			Name = "SupplyPaymentService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("a9dc8202-29a7-4ff6-a0ce-2857c0a07123");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,237,89,75,111,220,54,16,62,111,128,252,7,118,115,209,22,142,234,94,109,199,128,189,118,130,45,106,199,201,218,245,193,8,10,89,26,219,68,245,50,73,109,178,72,252,223,75,138,148,68,113,41,173,30,110,138,22,201,197,89,206,227,155,25,206,80,67,78,236,69,64,83,207,7,116,9,132,120,52,185,99,238,60,137,239,240,125,70,60,134,147,248,229,139,175,47,95,76,50,138,227,123,180,92,83,6,209,190,241,219,93,2,89,97,31,206,146,0,194,86,162,123,13,183,237,12,71,62,195,171,28,183,226,211,13,35,208,180,238,158,198,12,51,12,180,145,225,228,216,70,226,38,113,114,20,229,136,156,254,138,192,61,135,71,243,208,163,116,15,45,179,52,13,215,23,222,58,130,152,41,83,115,190,27,245,131,7,139,17,207,103,159,196,218,17,77,207,129,113,117,41,247,225,22,135,152,173,63,194,99,134,9,8,113,234,232,63,132,195,232,13,218,34,34,184,92,181,16,204,4,72,154,221,134,216,71,190,176,207,106,30,218,67,199,30,133,210,216,201,215,220,224,210,179,51,96,15,73,192,125,187,32,120,133,153,116,103,146,18,17,120,64,121,24,215,243,36,12,193,23,251,128,222,1,171,161,92,144,36,200,124,230,188,203,112,128,168,133,178,8,118,80,78,244,85,104,22,193,12,137,36,154,76,86,30,65,64,31,185,219,49,124,86,80,75,255,1,34,239,67,6,100,237,92,81,32,60,160,177,132,118,117,134,51,47,246,238,129,236,160,169,205,154,233,108,63,7,224,202,93,238,86,228,145,117,174,145,251,145,69,177,187,160,71,225,103,111,77,151,32,188,226,240,140,100,176,95,154,148,74,37,124,93,200,31,5,129,20,115,166,134,118,193,251,152,121,185,85,155,204,31,20,69,183,229,45,14,25,16,42,216,28,241,123,78,128,7,89,174,94,99,246,112,225,17,94,128,130,197,201,101,38,146,148,167,3,193,52,137,47,215,41,184,231,9,59,229,184,225,142,228,153,222,212,66,112,26,230,169,178,183,8,246,108,235,159,220,69,48,85,146,246,237,202,105,179,173,86,47,40,183,227,60,11,67,73,118,134,25,83,212,203,180,35,234,119,142,85,105,158,146,175,114,184,102,47,1,150,145,56,207,0,94,31,102,205,24,121,44,101,158,182,215,217,60,35,68,212,113,207,114,251,31,85,87,17,238,77,102,219,118,85,187,245,47,23,232,119,171,206,97,121,55,217,150,120,69,100,222,147,0,72,45,227,240,243,102,151,14,48,60,171,140,125,61,231,59,164,43,211,73,9,3,218,64,179,152,161,81,231,25,101,73,212,206,115,2,33,94,113,139,79,120,92,27,88,108,57,167,145,175,98,220,164,92,133,132,255,241,155,148,111,161,9,241,163,40,201,226,38,136,86,162,82,112,130,169,47,184,90,121,123,49,93,0,241,161,145,235,210,251,210,110,16,103,104,133,217,70,47,212,36,204,11,219,21,109,229,40,60,106,182,57,207,247,6,154,104,210,182,164,71,190,193,191,99,218,156,164,226,131,225,55,137,23,228,143,70,126,254,3,135,94,117,138,225,231,254,82,174,18,126,14,93,165,1,255,255,230,249,148,136,149,234,19,40,217,80,38,255,200,163,74,174,25,72,27,103,145,43,173,95,2,171,239,252,14,82,231,209,242,49,188,132,47,156,234,20,155,134,126,70,122,145,206,208,107,228,56,250,10,103,48,146,30,253,130,126,221,221,157,113,66,161,100,54,157,21,216,215,15,64,64,229,12,143,231,140,31,129,121,140,29,101,65,185,45,78,225,245,12,121,84,249,39,163,45,29,119,79,191,128,159,113,159,171,47,192,164,33,162,133,25,50,154,105,213,193,7,224,115,71,194,242,115,90,173,248,178,75,41,29,120,214,208,151,5,81,198,189,242,186,252,178,191,222,176,193,8,97,123,244,74,47,187,199,111,35,122,178,100,106,249,40,115,187,12,152,78,107,12,94,113,83,146,171,69,59,163,127,114,19,77,205,34,224,113,21,2,238,57,124,22,127,29,173,239,209,25,229,103,151,51,111,255,40,139,170,92,196,148,121,177,15,199,107,241,41,117,172,95,105,19,130,43,223,68,84,39,137,132,177,214,246,68,23,226,119,127,118,2,119,114,131,254,240,194,12,168,211,192,166,241,228,219,187,99,4,166,139,88,222,39,236,88,55,72,68,65,28,106,129,38,112,64,25,193,241,253,97,209,96,116,130,200,251,141,65,24,178,83,81,32,248,14,57,157,117,136,76,56,44,251,25,145,251,232,39,149,39,167,81,90,85,104,187,233,149,120,15,243,55,161,149,3,79,219,99,85,239,176,134,196,204,232,209,186,108,80,173,101,235,129,41,248,47,113,4,135,102,215,215,5,84,59,212,204,131,107,248,118,139,214,113,232,94,43,217,254,27,93,128,118,223,229,90,27,219,3,80,29,152,135,102,35,220,37,222,227,192,122,160,104,29,246,24,215,138,38,179,11,234,24,184,62,56,246,246,127,140,151,230,37,161,83,185,62,3,252,24,220,226,174,50,10,184,188,240,140,168,118,126,197,24,90,236,82,180,127,173,43,200,222,165,94,93,192,198,100,139,118,141,235,178,97,35,65,123,162,89,238,144,163,124,213,111,154,157,188,29,11,220,27,81,191,234,142,42,134,252,174,60,162,16,202,219,209,144,82,40,132,251,23,67,9,219,189,28,106,247,251,65,49,171,191,16,140,106,13,213,59,194,240,230,176,82,48,164,61,212,224,107,1,28,226,76,241,170,49,212,23,77,190,191,43,58,120,159,86,87,123,136,25,148,10,245,167,28,45,21,140,171,227,160,128,148,51,142,170,65,45,175,162,205,62,122,43,227,130,252,10,226,64,206,24,155,6,142,249,232,82,18,111,222,167,32,39,204,250,4,117,114,115,13,183,139,120,149,252,5,142,20,227,247,204,233,197,251,229,37,55,77,140,65,129,178,183,9,137,60,113,255,228,172,103,64,41,191,197,202,37,247,55,42,94,23,142,147,96,189,100,235,16,106,44,229,170,123,77,188,148,199,89,62,87,125,4,154,38,49,133,118,165,249,224,181,152,188,222,38,73,136,206,1,130,19,188,194,1,140,153,135,110,188,197,219,228,53,242,155,198,105,108,19,176,134,185,111,135,244,155,135,78,38,114,219,124,170,97,52,37,65,239,18,2,158,255,128,138,55,18,43,51,131,8,225,109,33,40,51,218,84,217,226,70,161,185,147,167,37,192,164,254,34,198,35,208,100,117,199,155,241,190,174,87,217,162,63,236,108,241,160,39,138,56,27,52,227,223,108,32,86,142,22,111,180,213,128,165,40,120,245,231,73,127,201,189,243,66,10,85,217,255,183,107,57,127,203,251,81,199,61,235,248,71,25,127,183,50,182,61,15,143,3,177,77,161,255,212,90,128,18,186,225,201,122,32,122,213,202,152,51,175,126,103,149,62,226,55,243,218,58,198,78,141,28,54,186,206,74,135,59,23,247,19,1,191,171,225,169,99,175,148,125,178,25,162,3,114,83,54,117,223,236,126,218,183,9,106,204,61,154,193,205,8,86,207,243,125,52,154,119,27,107,128,208,1,15,8,250,246,13,181,205,95,208,65,183,160,25,67,39,109,222,84,205,153,236,79,164,252,159,101,230,98,31,182,108,12,89,236,77,109,105,79,77,101,30,197,89,243,119,208,210,236,170,53,125,233,233,111,157,79,6,178,89,41,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("23c7aa6b-167a-48e3-ba60-3683f5ff5f9d"));
		}

		#endregion

	}

	#endregion

}
