﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: GlobalSearchConnectorHelperSchema

	/// <exclude/>
	public class GlobalSearchConnectorHelperSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public GlobalSearchConnectorHelperSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public GlobalSearchConnectorHelperSchema(GlobalSearchConnectorHelperSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("738ef869-ce49-48e8-922a-76c4abd2eeec");
			Name = "GlobalSearchConnectorHelper";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("e4ec28be-5265-4264-b9ed-412a48548efb");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,189,88,75,115,219,54,16,62,43,51,249,15,24,38,7,42,81,165,166,211,233,33,182,212,113,20,59,241,180,77,61,150,219,28,156,199,192,226,90,98,67,145,44,0,218,81,60,254,239,93,60,40,18,224,83,73,166,55,18,220,199,135,221,111,23,11,198,116,3,60,165,75,32,23,192,24,229,201,181,24,207,147,248,58,92,101,140,138,48,137,31,62,184,123,248,96,144,241,48,94,145,197,150,11,216,28,56,239,40,31,69,176,148,194,124,252,10,98,96,225,178,34,243,6,68,101,237,2,62,215,47,142,207,97,149,69,148,29,127,78,25,112,46,13,23,114,231,192,197,98,77,89,90,44,149,161,51,192,117,252,242,136,193,10,21,201,60,162,156,63,39,175,162,228,138,70,11,160,108,185,198,253,197,136,55,97,175,33,74,129,41,241,52,187,138,194,37,89,74,233,118,225,129,140,71,97,30,177,9,26,11,116,113,198,194,27,42,64,153,27,76,38,19,114,200,179,205,134,178,237,44,95,56,163,66,0,139,201,117,194,72,74,153,194,190,212,246,165,45,46,152,92,185,13,197,154,220,162,77,8,200,13,141,50,224,227,157,197,73,217,100,170,29,74,19,92,228,218,127,75,141,220,209,148,120,31,198,79,238,126,188,159,250,151,31,14,222,63,29,142,159,60,246,100,220,6,141,24,95,66,20,110,66,212,70,132,218,72,114,77,196,26,170,64,247,65,181,179,90,66,230,31,12,189,131,150,104,253,6,219,239,138,1,237,149,189,95,210,31,190,96,68,166,42,48,7,191,182,66,89,200,10,225,223,21,141,54,89,2,244,238,29,127,154,131,120,4,113,160,9,102,222,13,219,78,66,136,130,94,84,59,228,128,14,25,92,79,189,191,56,176,249,14,170,55,153,145,80,113,118,9,29,120,25,208,32,137,163,45,177,45,144,143,153,245,222,22,184,51,100,57,210,152,131,16,184,105,158,71,14,176,204,68,184,228,170,194,246,142,227,14,215,203,80,105,225,247,67,173,56,50,6,102,228,163,113,161,139,120,97,252,119,132,87,21,51,203,100,181,203,32,171,150,208,47,198,45,29,67,6,124,89,24,110,216,155,90,193,158,64,55,36,198,150,60,245,236,24,123,51,171,41,147,228,234,31,252,32,195,185,204,24,131,88,16,41,79,104,154,34,100,45,194,117,231,28,31,78,148,89,29,65,221,229,90,208,250,78,174,109,24,67,162,154,223,192,97,0,210,183,66,9,41,85,155,3,20,126,5,226,184,238,147,63,84,138,247,237,89,58,99,9,2,21,33,244,42,132,163,76,172,19,22,114,29,148,53,82,7,227,132,73,11,48,104,33,141,120,59,213,76,177,26,35,95,148,145,215,202,198,188,48,97,130,178,2,97,158,6,70,77,229,164,113,187,190,202,177,167,247,188,211,73,241,0,186,77,88,208,166,151,203,184,186,249,182,176,36,34,25,103,83,77,39,9,219,80,225,123,120,14,60,191,123,118,239,141,20,176,209,206,149,99,229,138,114,248,229,231,242,254,166,178,50,110,48,230,227,139,228,133,250,186,80,162,254,113,188,76,2,233,226,104,49,63,61,197,195,95,188,216,10,224,190,5,100,152,219,103,32,50,22,187,168,208,32,82,18,177,33,174,138,107,163,122,191,47,45,186,74,215,138,43,246,195,0,62,203,238,190,38,25,139,154,186,143,174,29,19,36,203,192,169,212,63,147,234,141,76,96,81,43,17,88,84,225,65,194,68,43,7,240,187,171,163,247,209,162,164,4,188,246,124,24,150,76,238,126,82,76,97,209,72,97,25,105,235,53,9,233,29,96,211,238,191,49,206,250,177,62,218,141,59,154,104,222,215,103,109,68,188,201,71,13,206,219,131,112,127,0,54,133,126,167,49,38,68,143,114,228,106,219,60,249,245,61,26,148,165,55,248,232,205,212,180,167,150,119,67,37,48,171,229,87,180,11,183,186,136,213,209,226,0,169,24,208,129,229,179,183,165,177,20,165,242,229,154,150,137,91,86,224,78,88,178,153,59,46,125,35,179,219,72,126,110,19,23,92,126,224,236,154,99,62,46,217,41,46,15,189,163,194,172,73,38,222,38,144,125,108,37,75,35,134,91,162,222,253,52,23,87,175,127,166,250,254,114,186,138,241,10,49,199,62,100,148,13,165,80,27,111,37,105,132,67,155,239,130,68,254,60,126,230,13,199,23,44,220,216,71,88,35,25,62,193,150,239,59,70,126,223,76,46,112,82,144,169,108,71,210,150,226,203,247,114,43,110,110,113,202,230,126,71,54,117,66,130,234,157,160,200,142,123,97,176,82,249,169,60,201,23,58,197,128,111,73,115,103,210,46,20,172,25,220,232,184,152,81,193,5,218,78,4,226,53,91,42,128,119,145,169,209,132,181,155,54,43,109,56,220,165,50,117,251,201,39,191,39,183,56,45,218,69,98,99,83,12,171,32,235,53,226,149,90,107,34,80,27,130,142,122,178,38,205,242,120,215,163,164,114,134,31,119,217,112,139,193,64,35,55,33,19,25,141,74,157,207,50,85,26,103,252,188,2,76,192,156,57,122,124,148,166,165,183,38,43,189,58,76,170,111,94,213,223,11,249,93,236,127,233,50,103,93,40,154,98,218,114,181,195,221,105,179,110,235,217,93,35,122,29,38,216,190,92,1,217,187,244,248,84,219,213,234,169,60,104,129,234,106,148,238,64,178,11,53,107,230,133,133,135,58,80,100,163,127,67,153,236,30,56,73,213,162,30,58,243,166,30,54,166,237,167,48,218,27,85,131,100,134,195,38,232,227,163,32,208,154,202,71,121,94,202,89,221,164,186,15,111,157,130,254,42,22,59,36,236,107,242,235,40,217,112,161,53,121,145,233,179,126,122,216,215,171,214,150,97,181,216,110,242,55,185,217,179,241,118,221,160,170,93,215,196,207,12,135,61,187,11,50,201,155,25,3,248,220,220,73,142,91,124,57,25,179,46,16,77,119,33,243,25,125,230,57,10,175,137,95,255,203,66,254,17,23,52,140,57,150,154,228,254,112,232,92,56,234,213,46,81,244,125,77,125,196,89,20,117,214,2,30,5,152,35,235,24,18,9,89,11,145,18,6,255,102,192,69,223,16,27,113,111,246,90,42,159,27,229,154,223,66,55,73,24,24,191,101,2,74,181,183,112,101,20,115,239,197,73,166,237,233,191,34,186,61,120,214,255,18,188,119,181,255,63,233,30,153,235,131,113,94,130,179,119,48,44,229,254,193,144,106,29,145,192,8,232,45,126,83,28,202,21,106,214,202,75,247,255,1,129,109,7,116,185,25,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("738ef869-ce49-48e8-922a-76c4abd2eeec"));
		}

		#endregion

	}

	#endregion

}

