namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: BulkEmailAudienceDataSourceFactorySchema

	/// <exclude/>
	public class BulkEmailAudienceDataSourceFactorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public BulkEmailAudienceDataSourceFactorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public BulkEmailAudienceDataSourceFactorySchema(BulkEmailAudienceDataSourceFactorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("1c1f0d41-7ba2-4160-96b6-1a7c839825bf");
			Name = "BulkEmailAudienceDataSourceFactory";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("93656b7c-51ad-4950-bd26-b581bae6f796");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,237,84,77,111,219,48,12,61,167,64,255,3,225,30,150,1,129,125,111,82,3,91,186,13,62,116,24,144,246,7,168,54,157,8,179,101,79,148,80,100,67,255,251,40,249,163,118,19,183,25,176,245,180,155,41,145,143,124,143,207,82,162,68,170,69,138,112,139,90,11,170,114,19,174,43,149,203,173,213,194,200,74,157,159,253,58,63,155,89,146,106,11,155,61,25,44,151,125,188,174,52,114,196,241,133,198,45,39,67,162,12,234,156,225,46,33,185,17,178,224,172,15,54,147,168,82,188,22,70,108,42,171,83,252,44,82,83,233,189,47,140,162,8,86,100,203,82,232,125,220,198,73,89,23,88,162,50,4,121,147,10,166,130,84,163,48,8,82,145,17,12,71,80,229,92,137,232,46,242,171,96,186,93,16,197,97,215,41,26,180,170,237,125,33,83,72,11,65,4,31,109,241,253,83,201,16,147,227,158,192,104,113,144,178,65,34,214,5,179,35,236,103,78,216,94,57,22,157,140,182,238,142,46,225,155,159,205,43,116,32,145,63,184,198,92,216,194,64,250,84,22,194,218,75,68,32,84,47,147,83,201,236,240,4,126,97,223,107,40,82,167,210,235,245,243,247,224,9,61,54,83,95,160,202,26,106,46,26,50,189,65,179,171,178,83,72,14,140,80,250,162,129,15,20,62,140,72,254,137,21,142,208,244,39,181,208,162,4,197,191,196,85,96,9,53,239,68,97,234,254,130,32,190,227,248,29,57,189,219,163,112,21,249,252,227,229,247,157,94,73,22,196,183,188,0,171,228,15,203,246,205,152,142,204,37,234,110,51,46,19,208,165,190,130,40,76,186,219,200,159,216,224,17,127,57,136,90,108,209,201,194,170,100,135,0,26,141,213,138,226,175,211,106,189,176,89,150,107,21,117,16,29,230,192,20,211,66,183,86,76,218,150,243,187,145,154,48,22,119,1,95,172,204,96,32,217,130,135,53,208,51,110,157,53,107,70,241,171,127,97,234,249,115,244,17,240,19,232,114,224,214,55,179,31,60,72,179,3,106,158,133,36,3,178,117,93,105,243,223,149,111,232,202,254,81,254,75,246,108,19,250,165,254,19,187,46,6,248,203,137,119,150,227,230,116,124,248,248,27,31,146,2,46,229,7,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("1c1f0d41-7ba2-4160-96b6-1a7c839825bf"));
		}

		#endregion

	}

	#endregion

}

