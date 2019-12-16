namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: InvalidQueryStructureExceptionSchema

	/// <exclude/>
	public class InvalidQueryStructureExceptionSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public InvalidQueryStructureExceptionSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public InvalidQueryStructureExceptionSchema(InvalidQueryStructureExceptionSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("efb635f4-13c4-4e2e-a2d4-fb0118960ea2");
			Name = "InvalidQueryStructureException";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("69e28147-db31-49df-9976-b6fb9eb762c1");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,82,77,143,130,64,12,61,99,226,127,104,240,162,23,184,187,234,65,217,195,222,220,184,127,160,142,5,39,129,129,204,199,186,196,248,223,183,12,32,104,178,38,123,32,161,175,175,237,123,211,42,44,200,84,40,8,190,72,107,52,101,106,163,93,169,82,153,57,141,86,150,42,74,106,133,133,20,12,90,82,118,58,185,78,39,129,51,82,101,112,168,141,165,226,237,30,143,59,104,138,146,45,167,56,57,211,148,113,35,216,229,104,204,18,146,221,129,114,18,118,235,100,126,34,253,254,35,168,106,6,121,110,28,199,176,50,174,40,80,215,155,46,190,51,192,158,117,121,81,112,172,153,67,4,66,83,186,14,159,250,133,241,6,46,103,82,99,74,75,104,50,103,52,32,213,55,230,242,4,198,106,39,172,99,165,253,224,120,52,185,114,199,92,10,16,141,104,248,104,75,62,29,233,250,208,151,13,186,150,48,114,17,92,189,147,193,118,169,218,73,165,102,247,123,223,182,101,60,155,245,64,66,41,186,220,130,24,202,162,59,121,44,176,87,248,90,219,124,1,205,194,130,219,139,145,251,206,234,48,17,82,254,12,89,224,141,242,31,159,136,193,140,248,229,128,250,198,127,136,242,72,133,26,11,224,179,161,117,216,213,134,155,225,185,58,40,90,197,158,248,15,51,172,175,57,180,174,193,162,41,12,150,112,68,67,243,30,123,176,59,35,117,106,215,224,227,22,125,4,111,191,24,81,106,110,2,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("efb635f4-13c4-4e2e-a2d4-fb0118960ea2"));
		}

		#endregion

	}

	#endregion

}

