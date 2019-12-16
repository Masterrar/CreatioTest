namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: Base64ImageSchema

	/// <exclude/>
	public class Base64ImageSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public Base64ImageSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public Base64ImageSchema(Base64ImageSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("efe46806-614f-4213-8fdf-a9bbacc250fd");
			Name = "Base64Image";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("5d774dd3-3f0d-4e5d-9409-9a3b17d3417e");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,197,82,203,110,194,48,16,60,7,137,127,88,133,75,43,209,228,82,245,192,35,135,34,14,28,82,113,224,7,76,88,82,75,248,33,219,57,160,138,127,175,227,7,13,109,16,180,151,74,145,229,236,238,204,206,172,151,19,134,90,146,10,97,131,74,17,45,246,38,91,8,190,167,117,163,136,161,130,103,37,161,7,202,235,225,224,99,56,72,70,10,107,27,132,197,129,104,61,129,87,162,241,229,121,197,72,141,54,105,191,60,207,97,166,27,198,136,58,22,225,223,165,65,161,84,168,145,27,220,1,209,176,117,72,208,70,89,238,44,34,243,14,84,54,219,3,173,160,106,59,125,107,212,42,249,146,34,184,101,105,42,35,148,85,180,118,40,47,198,115,74,162,8,3,110,125,206,83,70,25,110,142,18,211,162,92,149,203,39,99,175,32,246,96,222,17,104,203,157,205,114,87,94,244,162,43,97,213,115,147,22,11,127,185,14,13,218,59,170,31,188,83,136,10,198,193,58,4,210,199,22,150,76,44,31,213,161,54,91,50,105,142,227,14,36,214,130,27,192,233,154,203,246,76,139,55,123,254,194,220,255,143,166,101,58,143,229,234,156,188,247,196,185,155,59,204,212,5,202,0,176,193,136,245,137,168,104,30,41,166,221,225,141,144,239,252,34,197,64,88,171,181,18,18,149,161,216,187,84,157,61,117,129,159,195,62,151,118,119,58,186,15,158,28,202,251,169,209,235,74,52,94,10,236,109,215,154,237,121,162,123,122,158,231,244,151,190,189,175,123,79,215,8,188,209,244,226,53,66,176,27,59,125,2,183,204,152,210,175,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("efe46806-614f-4213-8fdf-a9bbacc250fd"));
		}

		#endregion

	}

	#endregion

}

