namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IImportParametersRepositorySchema

	/// <exclude/>
	public class IImportParametersRepositorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IImportParametersRepositorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IImportParametersRepositorySchema(IImportParametersRepositorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("0944487b-5887-4694-84cc-de8e541b2ac6");
			Name = "IImportParametersRepository";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("a83ae89b-1206-453d-b626-f37ab41fffbf");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,84,77,79,235,48,16,60,183,82,255,195,138,19,72,85,114,127,132,94,128,87,249,134,30,95,103,19,111,138,133,99,91,182,3,138,158,248,239,216,113,210,230,75,136,86,28,179,158,157,153,157,172,45,105,137,86,211,28,225,1,141,161,86,21,46,185,86,178,224,187,202,80,199,149,76,254,114,129,164,212,202,184,213,242,255,106,185,168,44,151,59,184,175,173,195,242,114,244,237,91,133,192,60,244,217,100,139,18,13,207,61,198,163,116,245,34,120,14,92,58,52,69,144,35,145,243,142,26,239,192,23,237,63,212,202,114,167,76,13,127,128,220,74,199,93,125,168,101,99,248,198,147,6,59,139,52,77,33,179,85,89,82,83,111,186,194,163,102,212,33,88,71,119,8,170,0,222,116,131,69,107,189,183,125,91,58,238,203,116,16,0,233,69,174,206,56,59,219,100,105,83,153,7,72,252,136,182,238,131,206,16,252,174,56,107,109,244,48,231,219,202,151,57,91,195,33,214,230,192,222,202,202,211,14,8,47,98,116,243,19,222,160,240,57,128,222,7,2,133,50,39,206,25,37,99,15,97,51,115,68,177,214,252,16,253,173,201,45,58,219,121,202,169,204,81,64,33,232,46,249,13,99,13,218,160,171,140,180,27,50,213,200,210,238,48,160,95,148,18,193,14,177,164,79,122,221,52,32,59,126,180,118,195,130,84,43,139,236,244,77,27,15,74,6,44,64,88,114,212,34,62,81,81,225,92,240,147,63,27,3,24,100,114,114,22,218,168,220,227,189,219,105,16,39,255,242,35,147,104,61,244,58,59,87,92,250,215,64,134,151,135,77,99,232,95,212,187,142,98,54,136,53,52,213,189,206,143,247,191,119,83,63,184,123,237,249,202,85,169,195,253,250,46,163,110,151,111,120,243,186,250,179,200,242,134,53,112,59,55,36,80,201,224,61,46,194,140,137,209,253,56,240,102,97,190,53,76,222,219,48,204,179,151,236,226,217,219,62,15,17,44,62,87,203,207,47,55,186,168,69,77,6,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("0944487b-5887-4694-84cc-de8e541b2ac6"));
		}

		#endregion

	}

	#endregion

}

