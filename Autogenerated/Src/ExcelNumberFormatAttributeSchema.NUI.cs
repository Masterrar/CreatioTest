namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ExcelNumberFormatAttributeSchema

	/// <exclude/>
	public class ExcelNumberFormatAttributeSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ExcelNumberFormatAttributeSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ExcelNumberFormatAttributeSchema(ExcelNumberFormatAttributeSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("5641821c-39ed-4a72-847f-ca3f93100c38");
			Name = "ExcelNumberFormatAttribute";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,83,75,111,218,64,16,62,131,196,127,24,41,23,35,185,38,105,111,161,84,66,1,212,92,210,72,129,166,82,213,195,98,143,205,74,251,176,246,209,134,34,254,123,214,187,216,50,224,144,170,7,219,218,157,153,239,49,51,22,132,163,46,73,138,176,68,165,136,150,185,73,238,164,200,105,97,21,49,84,138,100,254,82,74,101,150,114,254,146,34,27,244,119,131,254,160,223,179,154,138,2,158,182,218,32,31,55,231,153,76,45,71,97,22,82,113,98,146,111,37,138,31,156,189,23,79,158,74,133,36,211,27,68,51,246,232,87,10,11,71,13,119,140,104,125,11,158,249,193,242,53,170,80,57,53,70,209,181,53,232,179,71,163,17,124,214,150,115,162,182,95,14,231,38,3,114,169,32,195,84,86,110,156,4,172,176,192,61,172,138,56,44,64,97,57,228,20,89,150,212,96,163,22,218,207,6,106,165,73,129,81,115,92,18,85,160,209,201,162,42,29,254,114,169,165,93,51,154,66,90,169,190,32,26,110,161,101,160,23,26,218,120,126,84,178,68,101,40,58,227,143,30,48,196,79,93,250,11,79,2,194,179,212,126,168,247,113,110,164,150,183,186,23,230,211,71,104,75,131,29,56,43,99,216,191,75,149,51,82,196,160,55,210,178,12,172,198,3,119,160,166,217,69,226,181,148,12,166,101,201,182,255,199,157,74,102,185,128,63,52,51,155,203,22,103,210,125,241,59,97,22,225,185,74,255,119,146,223,190,104,35,21,253,43,133,33,12,8,163,133,168,150,246,50,229,215,166,98,90,23,120,126,221,21,57,145,115,133,34,11,211,63,94,5,247,31,106,163,108,106,164,58,89,134,3,233,219,59,22,249,102,147,211,102,199,245,244,69,123,2,19,184,94,197,144,249,166,133,246,186,171,155,235,89,92,81,245,168,211,187,233,240,48,129,15,55,67,216,249,156,135,99,184,54,250,216,39,156,143,125,114,174,46,164,62,31,4,180,134,152,44,148,228,225,28,121,125,195,144,74,115,136,230,142,44,185,215,51,204,169,192,44,50,219,18,101,30,189,57,142,97,220,101,102,88,27,233,117,77,107,2,23,240,58,208,130,184,125,245,238,158,112,184,61,190,220,191,2,120,102,206,72,138,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5641821c-39ed-4a72-847f-ca3f93100c38"));
		}

		#endregion

	}

	#endregion

}

