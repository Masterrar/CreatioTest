namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SaveDuplicatedEntityExceptionSchema

	/// <exclude/>
	public class SaveDuplicatedEntityExceptionSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SaveDuplicatedEntityExceptionSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SaveDuplicatedEntityExceptionSchema(SaveDuplicatedEntityExceptionSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("b337a224-56ad-46fe-b05d-92c5ffd63b6b");
			Name = "SaveDuplicatedEntityException";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("c92d8fca-4a0d-4385-86d2-4f5717aa816e");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,81,187,110,194,80,12,157,131,196,63,88,116,161,75,178,83,202,146,50,116,168,84,9,126,192,36,78,184,42,185,55,186,118,154,166,136,127,175,115,19,30,101,96,244,145,207,195,199,22,43,226,26,51,130,45,121,143,236,10,137,83,103,11,83,54,30,197,56,27,127,160,255,34,49,182,76,177,170,209,148,118,58,57,78,39,81,195,10,193,166,99,161,234,101,58,81,228,201,83,169,4,72,15,200,188,128,13,126,211,91,83,31,76,134,66,249,218,138,145,110,253,147,81,221,171,6,66,146,36,176,228,166,170,208,119,171,113,190,108,128,236,189,107,25,218,61,89,200,207,58,64,65,7,196,119,189,189,56,48,150,201,75,124,150,75,110,244,234,102,167,44,200,250,60,143,227,192,2,110,162,69,199,16,239,122,144,179,44,190,201,196,121,189,235,51,168,14,27,247,23,4,224,221,26,49,120,48,191,196,128,96,169,237,51,10,90,237,216,21,122,22,141,173,197,87,251,33,98,107,100,175,12,174,41,51,133,161,28,244,35,206,131,62,136,177,164,248,98,152,220,59,46,107,244,88,129,213,95,190,206,198,245,217,106,171,78,227,160,174,40,144,19,103,222,236,52,86,31,34,136,199,203,36,112,131,212,216,215,195,166,230,218,68,223,252,40,252,220,243,162,104,1,59,100,154,159,65,56,194,105,172,144,108,62,180,24,230,1,253,15,158,254,0,236,160,101,60,131,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b337a224-56ad-46fe-b05d-92c5ffd63b6b"));
		}

		#endregion

	}

	#endregion

}

