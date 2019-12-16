﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: LookupValuesProcessorSchema

	/// <exclude/>
	public class LookupValuesProcessorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public LookupValuesProcessorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public LookupValuesProcessorSchema(LookupValuesProcessorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f954271b-f92d-4967-9455-65fbd0395b89");
			Name = "LookupValuesProcessor";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,237,26,219,82,27,55,244,217,153,201,63,40,228,101,153,50,75,159,139,113,134,56,132,48,133,196,229,146,62,118,148,245,1,52,89,239,26,73,107,240,100,248,247,234,182,182,46,103,205,210,118,146,182,201,75,136,164,115,215,185,106,93,209,25,136,57,45,128,92,0,231,84,212,87,50,31,215,213,21,187,110,56,149,172,174,242,183,172,132,227,217,188,230,242,249,179,47,207,159,13,26,193,170,107,114,190,20,18,102,123,209,90,161,150,37,20,26,79,228,71,80,1,103,69,2,115,194,170,219,245,230,184,230,16,174,242,195,74,50,201,64,168,109,117,240,146,195,181,162,71,200,184,164,66,252,66,78,234,250,115,51,255,72,203,6,196,132,215,5,8,81,115,3,57,111,62,149,172,32,133,134,235,2,27,104,21,214,52,223,50,40,167,138,232,132,179,5,149,96,200,12,230,118,65,56,208,105,93,149,75,242,169,174,75,242,199,130,150,108,170,246,207,224,182,97,28,166,74,215,102,86,57,41,7,47,161,154,90,170,110,237,88,40,99,10,201,155,66,214,92,243,49,34,58,54,86,92,84,208,236,82,0,87,168,149,53,38,105,130,229,142,149,168,67,160,109,98,116,28,116,9,76,246,187,48,247,12,94,196,122,63,98,110,128,30,54,43,173,244,152,3,215,119,168,77,91,75,133,9,211,214,184,110,73,34,62,209,242,11,185,6,185,71,30,97,116,184,128,74,226,118,5,125,100,1,222,209,106,90,2,31,162,166,62,228,92,253,163,193,14,248,181,24,17,119,96,182,31,185,219,83,144,55,117,226,62,187,187,187,100,40,154,217,140,242,229,168,221,56,152,78,5,25,43,143,82,154,127,168,72,97,12,158,175,192,119,99,248,225,156,114,58,35,149,10,207,253,45,16,183,91,35,19,21,75,34,138,27,152,81,114,219,0,95,230,195,93,3,54,242,189,118,81,179,169,102,183,98,102,47,55,179,248,231,6,253,55,141,77,20,217,214,87,22,148,147,34,68,80,23,175,0,242,179,186,150,22,41,143,40,90,111,97,87,36,139,49,95,236,147,170,41,203,150,184,161,110,4,14,40,107,25,173,104,17,126,254,94,105,189,109,201,15,60,188,252,3,159,2,127,189,60,16,69,230,142,31,60,103,236,182,59,220,51,33,117,122,41,141,3,56,235,235,40,80,142,208,247,18,44,146,117,158,173,209,56,32,225,223,67,122,123,158,225,47,143,167,241,77,54,21,83,58,18,54,213,112,87,12,248,102,106,2,74,19,62,86,0,109,169,173,209,185,219,107,245,131,128,129,211,86,163,63,133,116,171,105,47,226,136,29,98,127,60,116,151,224,7,97,246,134,153,104,87,70,31,170,44,169,78,119,200,81,195,166,35,226,91,219,238,145,200,142,59,214,63,44,26,73,205,178,67,142,15,171,102,6,156,126,42,193,81,31,17,76,71,63,8,148,212,218,5,252,99,229,174,71,32,67,241,39,41,88,134,203,55,192,36,67,165,176,30,125,165,42,32,45,110,72,166,165,97,170,94,18,86,97,82,173,130,203,183,148,142,169,76,35,229,191,194,114,199,160,231,230,228,73,225,82,193,221,143,72,249,134,145,242,30,238,254,163,65,18,75,30,10,248,127,8,16,165,100,90,79,220,69,59,33,254,90,208,124,167,190,111,200,115,144,13,175,196,232,164,135,57,135,187,45,180,31,58,157,33,210,43,115,127,235,200,209,9,183,75,131,182,211,209,216,190,136,10,45,236,152,115,191,193,59,165,21,189,86,78,162,212,63,86,243,7,173,10,120,189,84,90,197,69,202,39,46,110,157,40,73,167,24,96,173,226,106,112,86,223,141,235,70,53,217,137,40,7,243,185,183,58,165,247,150,100,139,96,67,205,178,70,58,85,221,151,174,229,50,13,96,112,107,73,255,232,139,167,85,14,160,245,101,101,219,49,193,243,224,162,18,138,233,125,99,217,199,186,228,69,237,70,134,35,94,43,239,85,217,72,137,240,17,57,18,25,234,30,43,131,106,17,212,180,45,129,219,60,165,215,214,54,118,247,119,38,111,38,58,114,64,131,100,118,115,92,207,84,52,49,81,87,23,203,185,154,157,111,27,90,198,249,211,248,171,187,180,1,38,116,107,30,207,203,214,147,188,51,142,142,164,232,36,154,82,91,34,129,141,92,48,43,171,196,116,215,142,132,71,134,230,107,80,52,107,173,156,111,182,161,13,142,212,57,130,225,193,80,70,140,78,246,91,107,12,54,176,112,65,157,33,14,19,114,65,57,96,124,243,139,250,164,190,3,158,173,80,245,248,244,2,201,10,250,17,70,82,86,9,85,167,48,183,89,123,141,73,130,9,186,246,31,4,109,7,177,243,74,150,7,251,247,97,237,141,103,32,64,90,205,109,34,104,97,125,87,29,151,64,121,48,144,13,108,138,198,178,157,255,122,208,93,96,103,76,136,191,59,175,181,69,58,172,83,135,27,71,193,141,133,143,150,101,72,235,160,44,251,86,182,211,77,10,225,37,13,43,47,202,56,142,82,191,6,17,179,129,75,4,24,249,72,195,214,197,130,120,246,186,41,29,212,29,40,214,175,49,246,129,99,23,88,104,120,174,189,212,207,115,196,121,147,7,188,231,123,106,191,158,205,27,106,126,76,51,95,173,163,123,159,88,253,233,253,219,191,126,28,154,165,33,105,199,33,44,86,67,33,55,204,57,154,114,25,146,236,211,39,6,193,58,3,35,192,42,90,17,73,131,136,245,249,5,129,234,19,66,35,181,80,192,172,138,34,179,187,176,187,230,3,51,80,124,101,232,53,249,242,180,53,73,43,144,50,203,223,81,97,193,86,178,6,90,234,66,137,107,135,213,202,96,88,244,243,79,91,242,124,218,253,106,157,141,11,34,107,197,206,24,133,92,155,102,177,111,126,90,184,120,253,24,211,233,142,202,4,180,101,249,120,37,66,226,99,212,221,239,98,209,180,72,226,199,238,180,163,196,162,245,62,181,244,135,31,172,111,109,131,226,68,213,25,84,52,47,42,108,68,56,133,85,90,219,39,63,239,121,203,161,47,134,127,240,211,62,89,127,2,51,237,174,158,167,164,208,99,141,105,138,92,31,100,16,189,39,111,68,90,227,108,78,191,243,207,108,158,173,184,108,231,23,244,51,100,79,96,132,245,91,40,83,223,11,131,151,166,15,149,255,169,35,235,241,113,196,126,83,209,255,107,245,244,41,188,202,143,171,69,173,180,144,55,76,191,246,172,96,49,9,116,206,122,181,41,13,160,233,155,184,204,93,248,79,69,118,203,165,182,32,212,215,243,199,177,190,239,11,21,202,102,156,178,133,56,205,52,62,217,128,222,158,111,229,150,226,163,225,109,153,137,118,138,249,14,30,130,158,210,53,116,167,39,167,112,160,34,150,151,172,15,197,183,186,209,113,208,183,70,236,40,241,35,180,140,105,94,185,234,79,244,223,175,246,80,35,146,167,139,232,249,195,254,207,30,191,94,78,168,188,233,126,207,208,69,51,60,204,223,80,73,141,130,122,32,38,76,144,11,184,151,193,230,42,203,225,131,175,134,183,59,239,160,156,43,229,38,28,212,85,195,122,223,64,102,237,252,154,165,12,54,137,180,122,201,192,110,204,207,138,146,47,253,47,144,206,21,35,123,5,190,131,191,103,184,248,61,135,64,250,30,143,78,155,166,109,156,104,207,183,240,148,200,27,184,10,158,52,99,8,186,128,172,235,7,1,45,108,231,212,238,140,74,10,42,139,155,236,240,190,128,185,121,24,90,59,66,84,75,76,77,126,188,158,244,234,245,54,220,182,42,50,219,145,240,250,187,115,250,148,255,248,7,252,174,223,101,76,218,10,237,122,38,183,118,86,78,71,105,213,44,155,179,9,101,225,239,13,252,160,183,42,236,216,182,165,109,85,70,113,249,246,179,79,137,10,227,154,31,236,12,119,229,244,245,114,197,77,143,7,29,2,36,41,237,210,148,211,16,95,127,80,9,50,219,165,171,144,88,210,210,23,139,83,208,39,123,221,47,20,216,188,148,18,242,223,8,162,55,139,190,99,212,160,235,139,245,230,79,90,120,129,233,30,242,6,200,231,190,127,152,3,234,58,246,125,185,15,233,34,37,137,12,60,17,249,13,191,17,178,187,254,166,218,249,19,31,85,159,173,134,38,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f954271b-f92d-4967-9455-65fbd0395b89"));
		}

		#endregion

	}

	#endregion

}

