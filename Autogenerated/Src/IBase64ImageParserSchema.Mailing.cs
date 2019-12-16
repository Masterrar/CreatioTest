namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IBase64ImageParserSchema

	/// <exclude/>
	public class IBase64ImageParserSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IBase64ImageParserSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IBase64ImageParserSchema(IBase64ImageParserSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("d22fb757-667d-4ac9-b5bd-1e09eb515bb0");
			Name = "IBase64ImageParser";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("5d774dd3-3f0d-4e5d-9409-9a3b17d3417e");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,165,147,193,74,195,64,16,134,207,45,244,29,134,244,162,32,201,69,60,104,155,131,34,88,176,32,181,47,176,141,179,113,97,179,27,102,118,45,69,250,238,78,146,166,6,90,40,232,41,236,50,255,55,255,63,179,113,170,66,174,85,129,176,70,34,197,94,135,244,201,59,109,202,72,42,24,239,210,165,50,214,184,114,50,254,158,140,71,83,194,82,46,97,225,2,146,22,217,61,44,30,21,227,221,237,162,82,37,190,41,98,164,201,88,42,179,44,131,25,199,170,82,180,203,15,231,21,214,132,140,46,48,152,30,0,218,19,212,162,147,30,240,178,94,190,182,160,103,139,149,212,1,251,72,82,35,213,30,142,80,68,40,8,245,60,185,96,57,29,56,75,178,60,237,1,217,192,86,29,55,214,20,3,59,231,226,140,154,232,39,137,218,11,105,252,133,36,129,194,39,2,7,106,82,80,31,179,117,3,94,131,114,96,26,160,244,1,5,191,176,127,36,57,141,210,221,200,40,85,5,78,214,58,79,152,138,36,127,239,70,56,116,33,195,44,58,223,233,44,107,5,231,245,109,117,146,47,28,7,229,58,70,19,243,207,190,193,232,99,248,126,229,91,197,192,177,40,144,89,71,123,3,94,58,208,214,48,130,139,214,158,250,35,12,145,28,231,171,238,11,129,34,54,220,203,60,173,44,163,0,123,66,131,220,120,111,97,77,187,118,211,87,135,253,201,216,68,23,3,12,220,119,147,187,126,16,209,190,125,223,83,116,31,221,207,208,28,247,63,162,142,52,117,72,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d22fb757-667d-4ac9-b5bd-1e09eb515bb0"));
		}

		#endregion

	}

	#endregion

}

