namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: FileEntityUploadInfoSchema

	/// <exclude/>
	public class FileEntityUploadInfoSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public FileEntityUploadInfoSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public FileEntityUploadInfoSchema(FileEntityUploadInfoSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("d770075c-2aa0-4a74-8063-064d78bec922");
			Name = "FileEntityUploadInfo";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("be1f674b-cdb4-46e4-8c46-23cae20b9205");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,83,77,107,219,64,16,61,43,144,255,48,36,151,24,130,161,215,132,28,18,215,46,130,146,154,218,73,206,107,105,36,47,93,237,46,187,35,18,83,252,223,179,95,66,150,90,168,220,147,180,243,230,205,123,59,51,43,89,131,86,179,2,97,139,198,48,171,42,154,47,148,172,120,221,26,70,92,201,249,138,11,124,209,66,177,242,242,226,247,229,69,214,90,46,107,216,28,44,97,115,63,58,207,243,31,125,168,47,248,134,187,71,173,29,226,48,221,238,4,47,160,16,204,90,240,181,151,146,56,29,162,66,46,43,5,119,144,247,154,62,226,88,94,56,187,54,88,59,71,176,142,37,156,77,75,166,45,72,25,27,74,119,181,255,86,245,198,165,122,83,24,226,155,98,143,13,123,118,119,191,133,111,45,47,161,114,148,188,188,133,148,229,143,1,245,85,179,157,82,2,184,93,236,91,249,11,203,88,19,30,160,98,194,58,126,66,87,220,88,10,41,14,114,182,112,6,193,116,182,28,41,58,120,108,226,62,36,174,130,7,95,56,252,244,193,196,234,76,69,96,161,68,219,200,4,93,125,101,196,174,34,144,255,97,116,100,189,75,27,56,62,189,64,76,216,30,116,180,227,45,132,94,219,176,11,62,254,210,217,123,69,99,253,72,30,224,75,8,28,227,32,174,81,150,113,88,233,60,156,220,218,40,141,134,56,14,231,150,154,255,116,32,252,201,100,141,30,138,61,172,145,194,55,158,50,218,27,245,14,18,223,225,89,81,222,104,129,141,107,41,150,203,143,2,181,95,218,155,89,180,119,60,241,52,20,233,219,55,80,137,52,155,126,134,204,13,25,100,141,95,59,114,106,147,105,73,112,188,6,147,249,97,63,227,110,156,171,217,45,207,100,94,216,229,209,2,157,75,238,247,232,92,187,107,102,92,99,255,99,50,161,69,167,236,87,38,218,233,244,18,11,222,48,1,91,69,76,248,158,125,71,89,211,254,60,249,248,92,38,115,184,36,72,143,231,223,156,211,231,228,99,199,79,12,95,249,121,182,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d770075c-2aa0-4a74-8063-064d78bec922"));
		}

		#endregion

	}

	#endregion

}

