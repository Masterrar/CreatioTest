namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: FileConstsSchema

	/// <exclude/>
	public class FileConstsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public FileConstsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public FileConstsSchema(FileConstsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("92a37fd3-69e6-42f0-916f-9be6698711d1");
			Name = "FileConsts";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,144,65,79,131,64,16,133,207,144,240,31,38,61,233,97,45,203,82,10,49,30,44,133,198,196,131,137,85,207,11,59,212,141,116,217,176,139,166,49,253,239,178,212,83,227,193,244,52,201,204,155,55,223,188,193,72,181,131,231,131,177,184,191,13,252,192,87,124,143,70,243,26,97,139,125,207,77,215,216,155,55,172,238,181,14,252,239,192,247,244,80,181,178,6,99,185,29,75,221,114,99,160,148,45,230,157,50,214,140,2,39,242,230,115,215,3,123,208,8,100,154,27,224,74,64,43,213,135,19,157,217,244,200,69,167,218,3,108,6,41,38,249,118,220,124,121,16,112,7,10,191,166,246,213,108,17,101,171,60,42,83,18,22,69,72,214,37,165,36,91,210,21,9,67,186,78,194,34,99,105,158,204,174,167,47,28,193,227,120,235,66,2,183,250,39,1,251,39,129,231,157,24,156,129,230,59,132,79,236,141,28,35,130,174,1,251,142,208,184,120,46,74,230,245,215,105,211,75,241,52,90,159,51,98,26,215,85,204,56,137,99,70,73,156,100,140,84,66,112,194,105,28,209,180,98,245,34,91,158,24,143,129,127,252,1,97,2,152,36,0,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("92a37fd3-69e6-42f0-916f-9be6698711d1"));
		}

		#endregion

	}

	#endregion

}

