namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: DCSegmentationStrategyBaseSchema

	/// <exclude/>
	public class DCSegmentationStrategyBaseSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public DCSegmentationStrategyBaseSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public DCSegmentationStrategyBaseSchema(DCSegmentationStrategyBaseSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("1a5fefef-c426-40f0-a77a-e097708df1d9");
			Name = "DCSegmentationStrategyBase";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("41c9b305-ccaa-4408-abc9-8158dd3fa84a");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,189,83,205,110,155,64,16,62,219,146,223,97,228,94,18,169,130,123,253,35,165,56,234,169,106,20,183,15,48,134,1,86,130,93,186,59,56,69,86,223,189,195,2,46,182,112,146,94,122,100,152,249,246,251,153,209,88,146,171,48,38,248,78,214,162,51,41,7,145,209,169,202,106,139,172,140,14,118,141,198,82,197,82,100,210,188,152,159,22,243,89,237,148,206,96,223,56,166,114,181,152,75,229,131,165,76,186,33,42,208,185,79,176,139,246,148,149,210,239,49,246,44,88,148,53,159,209,145,239,14,195,16,214,174,46,75,180,205,182,255,126,166,202,146,147,17,7,174,235,87,228,128,115,100,64,75,224,58,188,246,93,212,128,117,162,72,199,20,12,96,225,8,173,170,15,133,138,1,15,45,78,204,16,183,156,94,165,52,59,121,90,127,85,24,45,179,117,204,198,138,152,39,143,215,117,92,51,247,133,200,146,128,57,16,254,166,56,146,29,4,52,160,4,7,133,39,188,40,206,1,65,36,38,148,42,77,9,196,173,161,191,56,56,163,134,215,176,235,10,45,150,32,246,211,102,233,70,228,163,110,116,185,125,16,91,24,76,58,198,245,67,196,100,221,71,120,201,85,156,123,251,186,196,14,205,200,219,96,29,250,94,255,94,239,217,109,147,238,46,127,245,20,96,130,214,61,180,43,50,155,77,181,111,166,6,86,109,251,239,62,1,210,73,23,194,101,34,79,214,84,100,89,104,191,35,143,209,42,113,78,131,211,144,26,123,14,196,181,174,173,29,201,95,75,233,102,121,91,248,50,220,222,200,104,210,179,65,233,84,237,4,25,241,10,222,144,250,149,56,55,201,123,116,238,124,228,174,143,217,82,37,237,8,46,55,117,145,192,161,189,25,205,192,70,254,196,170,146,123,185,181,108,215,7,115,52,42,25,4,60,244,151,118,119,191,250,15,76,124,197,18,215,86,187,237,15,173,126,214,4,42,105,239,62,85,114,87,215,153,61,119,15,73,68,32,217,142,126,125,169,85,18,60,150,21,55,109,124,235,112,128,156,82,219,246,14,106,247,114,37,5,61,202,123,220,188,174,120,223,105,179,84,154,35,1,22,5,180,11,234,227,198,2,18,100,252,23,179,163,130,208,126,171,118,50,118,126,246,106,63,186,173,185,44,74,237,15,225,121,26,2,193,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("1a5fefef-c426-40f0-a77a-e097708df1d9"));
		}

		#endregion

	}

	#endregion

}

