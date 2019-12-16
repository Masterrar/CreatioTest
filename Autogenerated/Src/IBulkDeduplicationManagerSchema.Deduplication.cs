namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IBulkDeduplicationManagerSchema

	/// <exclude/>
	public class IBulkDeduplicationManagerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IBulkDeduplicationManagerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IBulkDeduplicationManagerSchema(IBulkDeduplicationManagerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("fb400a12-d325-494b-95d3-08ad728af5c2");
			Name = "IBulkDeduplicationManager";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("3066e968-6ad0-45b5-bf2b-b9af469e0d31");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,181,84,77,79,227,48,16,61,83,169,255,97,20,46,32,161,228,14,37,210,178,160,170,210,130,86,80,78,104,15,38,158,116,45,18,59,59,99,11,85,136,255,190,142,157,180,165,77,249,56,112,138,231,227,205,155,121,227,88,139,26,185,17,5,194,28,137,4,155,210,166,63,141,46,213,194,145,176,202,232,244,18,165,107,42,85,4,107,60,122,25,143,14,28,43,189,128,187,37,91,172,207,198,35,239,57,36,92,248,48,204,180,69,42,125,185,83,152,93,184,234,233,13,248,90,104,177,64,10,128,44,203,96,194,174,174,5,45,243,206,110,1,32,55,17,80,71,72,218,35,178,13,72,227,30,125,30,168,158,114,63,35,12,117,51,23,252,116,103,5,217,182,163,131,151,208,213,106,142,107,180,127,141,228,83,248,29,72,98,112,187,231,224,152,162,101,239,69,132,130,176,60,79,118,120,102,186,52,73,150,167,171,10,217,118,137,73,35,72,212,160,253,42,206,19,212,86,217,229,141,63,39,249,85,56,135,64,58,201,66,214,26,68,104,29,105,206,63,193,61,201,250,228,22,61,152,213,206,177,227,60,98,75,237,166,215,61,29,159,125,85,138,174,34,242,148,140,107,110,253,101,51,154,241,59,4,217,4,21,166,114,181,230,21,162,179,67,148,223,135,154,178,100,180,73,190,238,28,24,43,44,44,196,200,71,196,78,15,130,201,60,67,8,126,126,147,251,165,27,88,232,112,114,88,107,31,10,90,168,46,131,119,151,123,2,209,245,240,167,215,235,164,253,187,186,185,227,57,140,240,238,45,248,33,37,3,97,97,200,127,173,1,167,213,63,135,29,13,84,138,237,183,110,62,210,221,6,254,153,244,55,224,62,242,199,142,64,248,71,110,185,127,5,94,55,87,181,19,131,144,114,75,230,71,99,170,118,186,185,137,37,127,249,81,134,68,156,58,37,189,132,91,141,244,154,29,162,150,241,145,9,246,107,124,62,223,56,95,255,3,112,79,237,253,149,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("fb400a12-d325-494b-95d3-08ad728af5c2"));
		}

		#endregion

	}

	#endregion

}

