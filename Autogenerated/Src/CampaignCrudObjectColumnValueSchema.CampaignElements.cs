namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CampaignCrudObjectColumnValueSchema

	/// <exclude/>
	public class CampaignCrudObjectColumnValueSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CampaignCrudObjectColumnValueSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CampaignCrudObjectColumnValueSchema(CampaignCrudObjectColumnValueSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("64496986-5fe2-4f0f-beca-e34f759c7102");
			Name = "CampaignCrudObjectColumnValue";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d0bba11f-3986-4819-81ab-1d3ddbfc1f48");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,145,77,79,195,48,12,134,207,155,180,255,96,105,247,245,206,16,151,34,24,135,9,4,140,187,155,184,109,80,62,70,156,32,77,19,255,157,52,233,166,129,196,216,37,74,28,251,125,31,219,22,13,241,22,5,193,43,121,143,236,218,176,168,157,109,85,23,61,6,229,236,108,186,159,77,39,145,149,237,224,101,199,129,204,114,54,77,145,185,167,46,125,67,173,145,249,10,106,52,91,84,157,173,125,148,143,205,59,137,80,59,29,141,125,67,29,41,23,84,85,5,215,28,141,65,191,187,25,223,37,7,62,135,36,48,78,146,134,208,99,0,197,16,153,36,52,59,16,163,48,212,207,155,91,112,89,26,72,147,33,27,120,113,208,173,78,132,183,177,209,74,128,24,192,254,227,154,236,51,219,177,155,53,133,222,201,212,207,83,22,41,159,191,201,115,96,99,213,71,130,86,50,113,168,86,145,7,215,194,112,15,137,57,91,44,142,181,167,116,7,188,251,168,228,216,255,230,65,194,30,58,10,75,224,225,248,58,99,155,185,7,43,78,51,16,33,205,232,18,179,113,108,165,248,82,171,59,141,29,4,7,202,74,37,48,80,89,77,217,85,143,12,6,133,119,124,222,184,113,78,195,10,121,157,115,255,244,159,147,149,101,3,249,93,162,63,131,41,246,13,22,182,146,63,172,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("64496986-5fe2-4f0f-beca-e34f759c7102"));
		}

		#endregion

	}

	#endregion

}

