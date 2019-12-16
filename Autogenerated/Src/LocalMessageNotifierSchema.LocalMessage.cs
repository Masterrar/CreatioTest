namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: LocalMessageNotifierSchema

	/// <exclude/>
	public class LocalMessageNotifierSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public LocalMessageNotifierSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public LocalMessageNotifierSchema(LocalMessageNotifierSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f4f644d0-eb01-48be-be16-2d50b24a40a4");
			Name = "LocalMessageNotifier";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("4a46c73e-2533-4fb4-8b08-c16580add3d1");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,146,221,106,2,49,16,133,175,21,124,135,96,111,42,200,62,128,182,133,170,197,10,182,74,181,189,159,102,103,215,192,110,34,249,161,44,226,187,119,54,137,186,182,34,94,133,76,190,57,51,115,50,206,8,153,179,85,101,44,150,195,78,219,53,174,201,88,21,5,114,43,148,52,201,20,37,106,193,143,200,26,181,6,163,50,75,148,198,228,69,90,97,5,26,122,239,180,37,148,104,182,192,241,140,146,153,200,157,134,90,174,211,222,213,92,235,78,99,78,87,54,46,192,152,1,155,43,14,197,27,26,3,57,190,43,43,50,129,218,115,91,247,93,8,206,120,141,93,164,216,128,141,192,224,191,220,86,168,115,42,68,163,88,237,184,85,122,192,150,94,53,0,177,194,37,237,123,63,91,197,208,31,61,182,171,249,86,132,102,50,83,236,145,73,252,97,205,72,96,14,16,1,33,153,92,180,235,106,139,41,57,235,74,249,5,133,195,7,106,136,12,125,186,239,70,186,219,235,135,236,177,70,176,152,142,170,89,122,93,97,234,68,74,249,13,254,175,198,66,94,87,152,16,180,22,37,158,84,22,242,168,241,10,230,217,90,224,155,146,20,72,135,12,196,248,116,240,232,3,185,210,105,179,207,165,22,37,232,170,81,36,166,172,248,6,75,248,108,178,33,148,80,44,50,115,65,251,71,251,102,168,47,136,246,78,132,223,68,210,244,243,246,153,159,250,224,116,107,119,131,65,225,35,143,13,208,128,55,39,213,52,219,135,90,225,216,15,235,99,31,247,11,101,26,86,204,223,67,244,60,232,99,191,157,221,3,129,110,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f4f644d0-eb01-48be-be16-2d50b24a40a4"));
		}

		#endregion

	}

	#endregion

}

