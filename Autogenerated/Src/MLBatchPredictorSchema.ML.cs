namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: MLBatchPredictorSchema

	/// <exclude/>
	public class MLBatchPredictorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public MLBatchPredictorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public MLBatchPredictorSchema(MLBatchPredictorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("b40d207f-a50e-4dea-9ec9-3919006013ff");
			Name = "MLBatchPredictor";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("73704ec6-562c-4400-8a4a-17477a18625f");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,197,84,77,107,220,48,16,61,39,144,255,48,56,151,22,130,125,79,28,67,154,13,73,96,13,11,41,244,172,149,198,182,178,182,100,36,217,233,18,250,223,59,150,45,239,71,182,161,61,245,38,141,102,230,189,121,111,108,197,26,180,45,227,8,223,209,24,102,117,225,226,123,173,10,89,118,134,57,169,85,156,47,47,206,223,47,206,207,58,43,85,9,47,91,235,176,185,57,186,83,73,93,35,31,242,109,252,136,10,141,228,148,67,89,151,6,75,138,194,179,114,104,10,194,185,134,231,124,249,141,57,94,173,12,10,201,157,54,62,49,73,18,72,109,215,52,204,108,179,233,190,192,66,42,180,208,160,171,180,176,80,104,3,235,161,20,218,177,118,224,23,106,147,189,226,182,91,215,146,131,12,160,167,48,207,222,61,238,204,48,31,65,174,97,229,139,199,199,99,86,62,48,53,177,32,152,99,176,222,130,171,16,108,139,92,22,18,5,52,140,87,68,27,106,100,70,13,26,53,90,96,29,207,237,146,227,126,105,203,12,107,64,145,21,183,145,79,30,29,136,178,252,100,43,224,7,6,165,137,175,63,221,142,87,157,218,76,132,81,60,49,37,106,52,81,54,29,128,230,70,194,0,159,22,84,165,25,176,71,229,98,114,173,215,27,50,224,77,186,10,38,193,137,57,188,85,104,48,224,109,112,11,210,2,21,72,71,39,49,28,72,8,3,132,1,61,171,59,28,158,119,189,13,218,174,118,222,76,87,49,55,21,126,28,3,127,114,108,7,68,224,6,139,219,232,174,44,201,42,230,240,33,60,68,217,143,10,21,80,15,18,200,58,154,6,65,23,211,48,5,147,53,161,57,29,160,9,97,110,233,81,122,45,69,48,243,75,190,204,119,202,195,158,11,87,112,231,231,78,23,243,252,233,99,39,197,21,232,245,43,237,124,150,193,73,145,191,222,124,178,66,47,172,39,89,135,189,217,233,226,183,137,232,122,61,36,218,255,180,49,51,161,5,241,137,178,197,145,235,255,106,119,192,248,11,215,189,31,131,50,171,125,10,159,57,243,39,75,224,96,136,224,196,37,42,49,126,236,254,254,107,252,65,29,4,41,246,27,93,37,26,234,18,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b40d207f-a50e-4dea-9ec9-3919006013ff"));
		}

		#endregion

	}

	#endregion

}

