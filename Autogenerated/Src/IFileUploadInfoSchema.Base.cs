namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IFileUploadInfoSchema

	/// <exclude/>
	public class IFileUploadInfoSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IFileUploadInfoSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IFileUploadInfoSchema(IFileUploadInfoSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("28ad8049-6da4-4639-b9de-e5c9a1fd33d3");
			Name = "IFileUploadInfo";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,165,148,75,79,195,48,12,128,207,157,196,127,176,180,251,118,7,196,129,241,80,37,4,19,27,187,103,173,219,89,52,73,149,56,72,21,218,127,39,73,181,49,30,29,107,57,198,253,226,47,118,26,43,33,209,214,34,67,88,162,49,194,234,130,39,51,173,10,42,157,17,76,90,77,238,168,194,151,186,210,34,63,27,189,159,141,18,103,73,149,176,104,44,163,188,248,182,158,164,79,62,228,131,99,131,165,223,12,169,98,52,133,79,127,14,233,103,162,84,21,58,98,181,91,87,148,1,237,168,159,80,18,148,251,116,115,163,107,52,76,104,207,97,30,247,198,52,201,116,58,133,75,235,164,20,166,185,218,5,66,42,64,197,196,13,216,108,131,82,128,242,213,78,246,27,166,135,59,44,155,80,199,109,228,23,17,127,244,116,248,20,143,144,148,200,161,220,100,123,68,121,35,88,124,83,102,186,114,82,157,96,158,69,176,191,51,150,249,119,250,128,13,76,78,121,40,169,32,52,29,138,123,71,121,68,211,124,64,122,110,234,83,29,75,143,246,117,44,53,139,10,138,96,170,80,149,188,233,16,228,152,145,244,100,228,195,193,30,34,221,79,54,23,198,215,113,250,165,183,252,208,171,255,106,123,19,149,235,210,197,238,29,202,86,1,30,112,89,153,246,111,85,113,135,102,193,6,133,244,191,114,132,122,190,29,244,67,64,146,66,11,84,0,49,144,133,108,227,212,43,230,224,226,68,232,144,174,181,174,32,181,179,150,221,141,170,62,234,235,134,17,140,80,229,31,183,21,184,231,128,13,104,220,27,26,27,198,233,239,2,63,1,97,213,18,255,239,90,65,198,114,219,187,227,45,187,11,96,236,91,167,116,140,42,111,135,175,95,181,177,195,208,246,3,26,69,208,76,64,6,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("28ad8049-6da4-4639-b9de-e5c9a1fd33d3"));
		}

		#endregion

	}

	#endregion

}

