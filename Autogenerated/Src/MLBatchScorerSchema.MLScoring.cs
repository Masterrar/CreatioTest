﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: MLBatchScorerSchema

	/// <exclude/>
	public class MLBatchScorerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public MLBatchScorerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public MLBatchScorerSchema(MLBatchScorerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("94a1827a-9241-4908-b110-6cc1dd10cabd");
			Name = "MLBatchScorer";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("11899473-4fd2-4242-bdeb-3205232c82be");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,85,77,111,218,64,16,61,19,41,255,97,68,47,166,66,38,109,111,5,124,72,162,84,72,144,162,66,123,169,122,88,236,113,216,202,222,117,119,215,180,52,234,127,239,236,7,198,134,52,205,109,61,59,243,102,222,155,183,32,88,137,186,98,41,194,26,149,98,90,230,38,190,145,34,231,15,181,98,134,75,17,47,230,151,23,143,151,23,189,90,115,241,0,171,189,54,88,142,79,190,169,164,40,48,181,249,58,254,128,2,21,79,207,114,230,92,252,56,6,111,164,194,227,87,187,185,194,248,142,165,70,42,142,250,169,140,197,60,158,9,131,42,167,169,109,2,165,188,82,248,64,189,225,166,96,90,191,135,197,252,154,153,116,187,74,9,75,185,132,209,104,4,19,93,151,37,83,251,36,124,187,107,13,40,12,55,212,10,124,159,74,97,198,137,201,14,161,100,233,150,11,132,2,153,18,246,174,148,25,22,241,1,110,212,194,251,122,139,57,171,11,115,205,69,70,153,145,217,87,40,243,104,22,38,89,122,80,169,6,67,184,39,197,97,74,51,146,204,218,232,216,142,65,37,75,37,55,5,150,107,42,28,124,35,196,170,222,20,60,133,212,50,234,18,130,134,224,125,93,90,165,27,116,42,123,116,116,143,130,216,30,170,182,151,164,203,210,97,250,140,83,69,92,96,38,72,10,86,240,223,36,7,3,129,63,129,83,61,19,100,15,153,131,217,34,149,32,66,170,48,159,246,59,67,245,71,137,159,53,110,192,71,167,232,147,138,41,86,130,32,1,166,253,90,163,162,233,132,119,77,63,89,19,184,141,65,218,4,227,201,200,85,56,128,160,71,167,105,244,185,3,2,93,204,1,9,181,97,26,163,211,176,117,115,239,79,16,10,69,230,181,234,10,183,64,179,149,153,213,76,73,67,133,152,61,35,91,112,210,142,21,53,66,46,149,83,74,87,152,242,156,99,118,180,205,75,116,113,201,94,14,95,215,22,225,44,59,99,134,221,73,21,28,208,8,105,195,110,144,170,185,120,30,167,82,242,215,222,215,186,227,121,182,66,83,43,161,155,64,240,94,32,77,244,201,253,45,142,237,244,234,32,33,200,29,189,98,158,33,204,185,54,147,76,210,78,49,129,48,125,180,152,47,44,99,255,243,227,217,15,109,125,175,55,115,249,183,158,9,73,55,33,83,211,155,25,130,220,124,39,228,36,129,51,33,134,64,143,111,133,106,199,83,92,90,74,158,88,216,126,207,1,134,167,247,177,54,85,109,146,150,88,159,28,29,77,207,212,171,225,22,28,249,137,158,106,149,179,66,227,96,124,68,62,80,211,222,25,211,115,236,120,133,246,23,51,146,174,57,76,19,240,39,223,107,16,175,165,5,138,2,168,151,51,192,141,91,254,125,210,143,52,93,201,104,124,107,67,191,153,150,55,53,219,17,231,151,218,209,213,121,99,184,227,255,141,225,155,219,109,251,130,23,123,194,239,50,212,127,177,181,116,92,185,105,35,175,167,71,60,172,48,104,66,118,33,4,67,130,209,191,194,187,183,145,103,250,26,222,92,93,13,198,255,126,233,62,218,13,82,236,47,4,89,201,247,16,7,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("94a1827a-9241-4908-b110-6cc1dd10cabd"));
		}

		#endregion

	}

	#endregion

}

