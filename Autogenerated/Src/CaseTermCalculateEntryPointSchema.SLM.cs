﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CaseTermCalculateEntryPointSchema

	/// <exclude/>
	public class CaseTermCalculateEntryPointSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CaseTermCalculateEntryPointSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CaseTermCalculateEntryPointSchema(CaseTermCalculateEntryPointSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f2ff0679-815f-4ee9-9e1f-054f65a14aeb");
			Name = "CaseTermCalculateEntryPoint";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("c4b72b51-b2ae-4127-a458-608f5464622c");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,237,87,75,111,227,54,16,62,123,129,253,15,172,123,81,0,65,190,111,108,45,12,111,178,245,97,23,139,56,185,244,198,200,99,135,173,68,26,36,229,212,93,248,191,119,72,138,122,208,82,156,164,15,4,109,47,178,72,207,124,156,231,199,17,167,5,168,29,205,128,220,130,148,84,137,141,78,22,130,111,216,182,148,84,51,193,147,5,205,129,175,169,84,239,223,125,127,255,110,84,42,198,183,100,117,80,26,138,203,96,141,154,121,14,153,81,83,201,103,224,32,89,214,200,180,15,144,208,191,95,20,130,15,105,36,215,52,211,66,50,80,253,18,45,163,207,10,36,184,95,160,103,89,153,219,245,10,228,158,101,198,40,212,156,76,38,100,170,202,162,160,242,144,86,235,43,174,229,129,236,4,227,154,108,132,36,89,163,75,52,98,41,175,55,105,41,238,202,251,156,101,36,203,169,82,100,65,21,180,79,5,11,249,205,32,162,232,119,123,242,232,71,9,91,3,249,77,138,29,72,141,190,146,15,102,161,49,170,176,118,50,161,121,118,227,51,104,69,244,3,144,82,1,90,39,56,119,121,72,106,141,73,168,50,221,211,188,132,122,121,251,164,114,35,187,243,214,144,59,148,94,212,194,225,210,20,203,104,180,5,125,105,95,118,146,237,209,105,162,170,141,99,229,48,214,150,243,185,27,0,4,82,90,150,38,225,10,35,96,3,249,132,251,75,206,52,163,57,251,29,3,70,9,135,71,194,80,159,114,172,107,177,177,113,153,42,0,146,73,216,204,198,79,100,98,60,73,93,186,6,226,86,101,244,9,132,232,194,121,126,124,3,214,218,157,29,149,180,32,28,251,124,54,46,59,41,26,167,125,57,159,78,172,198,115,221,13,178,222,61,161,138,197,40,16,154,5,98,207,41,136,47,160,31,196,218,212,130,43,36,247,175,175,170,79,248,184,101,5,152,186,217,99,227,92,75,81,220,233,44,170,247,215,213,75,76,204,243,103,193,97,201,55,130,232,214,194,27,43,65,151,146,119,228,146,10,214,236,69,13,84,71,187,237,132,55,171,162,21,19,187,27,164,89,172,105,32,87,191,65,86,106,168,99,105,254,84,141,161,88,7,82,155,85,92,135,125,201,145,97,176,1,45,209,248,69,108,109,29,117,188,49,81,245,27,141,250,74,35,154,34,5,85,191,122,23,247,212,50,152,229,245,82,179,156,233,3,38,197,20,162,103,251,59,183,27,164,215,57,105,213,165,247,199,233,245,120,26,85,210,94,50,185,1,106,81,172,159,51,107,80,242,19,85,215,57,221,70,93,99,77,188,53,197,166,240,88,23,206,219,143,161,213,201,124,189,142,90,33,107,71,40,241,202,6,55,238,4,231,130,80,85,215,204,71,135,253,129,240,50,207,3,147,87,34,47,95,110,178,200,247,175,182,216,232,190,198,96,91,179,222,238,23,214,226,13,100,127,77,53,46,175,120,89,128,164,247,57,76,61,134,23,73,145,228,220,155,10,154,240,109,150,173,145,246,173,142,210,3,196,146,224,226,171,120,12,178,245,15,21,126,139,137,134,235,190,21,245,183,212,2,195,182,55,29,240,106,211,7,155,225,252,237,114,110,210,88,136,146,227,168,37,171,148,218,59,128,80,190,198,139,92,85,145,114,123,90,216,82,126,238,213,76,229,22,91,7,161,199,233,39,102,161,81,148,60,50,253,64,172,152,178,99,39,206,68,232,247,22,231,194,206,61,125,130,86,247,237,56,93,153,87,91,201,225,224,122,10,225,34,167,210,57,39,226,254,23,108,30,28,70,168,54,211,129,205,171,29,77,78,61,239,248,141,160,30,165,53,65,244,145,79,120,3,214,94,79,209,75,156,221,227,202,134,148,212,177,137,201,41,51,181,201,225,101,221,221,29,66,230,114,235,201,164,153,61,231,213,201,81,56,58,197,100,144,98,106,107,207,32,54,25,143,27,157,22,142,2,243,45,133,41,67,242,49,67,158,251,252,57,224,135,149,158,134,100,188,170,100,211,232,196,169,22,98,187,211,16,213,31,96,16,163,198,2,211,93,33,126,131,97,250,31,117,59,77,139,250,95,112,219,199,150,109,72,100,197,126,152,5,108,158,124,181,237,235,18,102,225,124,139,35,69,174,97,208,213,57,58,179,175,111,18,39,219,227,106,220,137,125,101,77,157,106,79,31,120,72,55,119,201,162,148,18,149,204,110,226,165,46,95,116,163,33,102,215,19,99,122,215,106,229,195,99,227,83,107,38,75,117,85,236,240,202,186,168,227,50,106,149,113,255,180,56,48,63,196,193,85,106,239,206,234,208,35,129,28,17,253,17,127,254,118,235,51,243,100,144,232,103,249,65,102,15,76,182,63,199,115,156,222,75,211,142,245,218,95,233,255,110,198,126,54,235,94,11,153,157,124,124,252,79,189,255,65,234,125,53,39,254,13,244,116,182,201,219,131,155,217,59,254,1,160,31,27,171,185,20,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f2ff0679-815f-4ee9-9e1f-054f65a14aeb"));
		}

		#endregion

	}

	#endregion

}

