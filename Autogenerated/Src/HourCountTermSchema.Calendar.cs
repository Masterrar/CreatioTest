namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: HourCountTermSchema

	/// <exclude/>
	public class HourCountTermSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public HourCountTermSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public HourCountTermSchema(HourCountTermSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e2216cbe-4197-4a17-8a40-fbb367f7eb39");
			Name = "HourCountTerm";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("761f835c-6644-4753-9a3e-2c2ccab7b4d0");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,83,219,110,219,48,12,125,118,129,254,3,145,190,164,64,33,191,111,153,129,33,189,44,192,10,12,88,246,1,140,205,38,2,100,57,19,165,2,70,209,127,31,37,197,78,226,174,221,94,130,136,62,135,60,60,36,45,182,196,123,172,9,214,228,28,114,247,228,213,178,179,79,122,27,28,122,221,89,181,68,67,182,65,199,151,23,47,151,23,69,96,109,183,240,179,103,79,237,231,201,91,152,198,80,29,105,172,30,200,146,211,245,27,204,119,109,127,31,131,239,84,21,128,64,174,28,109,229,1,75,131,204,240,9,190,117,193,45,187,96,189,176,218,132,40,203,18,22,28,218,22,93,95,29,222,9,1,94,32,176,233,97,39,28,86,3,180,60,193,238,195,198,232,26,234,148,252,44,181,148,122,212,54,120,58,41,86,188,164,130,163,166,71,242,187,174,137,170,126,164,60,249,235,84,79,22,132,166,14,6,61,65,35,63,107,221,82,20,86,31,124,85,35,175,156,18,23,123,116,216,130,149,25,125,153,53,216,243,172,26,166,1,241,169,22,101,66,252,157,144,58,159,85,177,51,6,223,197,130,89,198,91,154,35,31,156,229,99,118,47,34,5,54,196,35,240,96,87,247,44,19,211,13,193,237,208,203,216,222,124,117,103,67,75,14,55,134,22,171,33,215,45,246,85,82,123,3,90,230,146,84,93,67,92,165,162,200,249,115,47,247,218,177,159,95,171,35,47,231,87,95,155,38,245,48,207,212,184,59,197,235,7,118,63,144,151,126,119,148,154,128,96,181,231,255,245,120,152,201,172,90,11,127,156,208,135,54,11,36,195,229,207,251,206,174,71,45,80,199,165,250,135,185,209,41,233,35,178,126,69,210,124,180,115,98,236,160,241,6,78,205,31,188,91,89,57,131,103,52,21,236,229,22,101,93,39,198,111,144,73,157,213,57,230,27,25,105,129,83,80,78,148,197,204,124,27,188,178,113,44,167,227,184,18,84,62,143,244,206,209,243,224,235,31,154,19,138,140,113,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e2216cbe-4197-4a17-8a40-fbb367f7eb39"));
		}

		#endregion

	}

	#endregion

}

