namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: DCTemplateGroupModelSchema

	/// <exclude/>
	public class DCTemplateGroupModelSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public DCTemplateGroupModelSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public DCTemplateGroupModelSchema(DCTemplateGroupModelSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("a31f9786-6cb9-4933-9916-2eea05b45be7");
			Name = "DCTemplateGroupModel";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("748ec229-6875-456a-9dfd-63087e63e63a");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,83,193,110,219,48,12,61,187,64,255,129,75,47,45,48,216,247,166,78,15,9,80,228,208,173,192,186,15,80,101,58,86,97,75,158,68,55,53,130,254,251,40,41,118,210,32,233,178,75,20,209,228,123,143,228,147,22,13,186,86,72,132,103,180,86,56,83,82,58,55,186,84,171,206,10,82,70,167,139,94,139,70,73,14,18,106,74,31,77,129,181,187,188,216,92,94,36,157,83,122,5,191,122,71,216,76,199,251,153,64,11,65,194,255,183,66,18,23,115,249,149,197,21,39,194,188,22,206,221,194,98,254,140,77,91,11,194,7,107,186,54,16,135,188,44,203,224,206,117,77,35,108,63,219,222,67,13,144,1,139,173,69,199,4,80,48,1,52,190,10,74,99,185,2,17,164,197,50,159,28,32,79,178,25,112,129,162,62,29,208,179,61,248,182,123,169,149,4,25,24,142,139,74,54,65,216,216,193,147,53,45,90,82,200,109,60,133,242,248,253,80,121,8,252,214,234,79,135,160,10,175,161,84,104,211,49,117,95,198,160,227,161,83,5,44,11,216,192,10,105,10,206,255,124,64,30,226,233,15,92,251,243,250,102,250,63,132,96,74,160,109,91,123,147,248,135,134,221,40,14,213,156,193,173,11,124,135,181,162,74,105,160,10,71,250,175,121,21,175,117,25,74,143,240,93,161,46,226,252,63,47,227,17,169,50,197,57,155,248,249,198,214,229,177,56,192,247,150,83,21,129,52,250,205,111,146,125,205,230,58,237,161,193,201,222,75,212,183,187,62,230,17,192,129,238,234,218,99,248,243,68,151,33,210,10,43,26,224,167,130,249,36,184,119,50,27,152,182,110,54,47,175,40,9,214,149,146,213,32,16,139,244,46,11,165,251,243,114,196,79,79,238,186,241,174,20,196,143,225,132,250,235,99,246,142,172,55,144,7,228,36,106,248,150,135,70,66,36,185,7,141,235,83,152,176,137,73,9,187,36,143,88,233,178,248,62,4,195,54,199,184,191,197,47,31,241,184,13,52,211,163,27,142,123,255,28,228,216,95,97,179,231,173,211,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a31f9786-6cb9-4933-9916-2eea05b45be7"));
		}

		#endregion

	}

	#endregion

}

