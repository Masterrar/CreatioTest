namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IMailingAudienceDataSourceFactorySchema

	/// <exclude/>
	public class IMailingAudienceDataSourceFactorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IMailingAudienceDataSourceFactorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IMailingAudienceDataSourceFactorySchema(IMailingAudienceDataSourceFactorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("b546faf9-3ac8-4a7c-a169-bbd0f8b47719");
			Name = "IMailingAudienceDataSourceFactory";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("137c1838-0170-451f-b0dc-9c1d36ce6de8");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,237,84,77,111,219,48,12,61,175,64,255,3,225,29,182,1,69,124,111,83,3,69,246,1,31,58,20,72,251,3,84,139,118,4,212,146,71,81,235,178,162,255,125,180,236,168,73,179,108,105,209,161,151,221,68,137,124,124,143,31,178,170,69,223,169,10,225,18,137,148,119,53,79,102,206,214,166,9,164,216,56,123,120,112,119,120,240,38,120,99,27,152,47,61,99,123,146,236,153,35,20,75,236,183,132,141,56,67,105,25,169,22,184,99,40,207,149,185,17,175,179,160,13,218,10,63,42,86,115,23,168,194,207,170,98,71,203,24,152,231,57,76,125,104,91,69,203,98,180,47,200,125,55,26,61,180,200,11,167,129,29,84,132,138,17,140,245,172,4,203,131,171,37,12,177,127,168,79,179,221,185,178,188,152,172,210,228,107,121,186,112,125,99,42,1,28,249,254,157,46,72,212,93,228,156,212,158,71,126,254,24,46,34,218,240,248,88,209,166,164,135,132,91,226,44,222,38,129,79,213,183,45,112,184,233,20,169,22,172,52,249,52,11,30,73,90,107,177,234,251,154,21,87,98,191,243,80,165,171,201,52,143,254,191,15,151,57,241,170,193,82,103,197,229,2,33,88,243,45,72,71,52,90,54,181,65,234,41,179,60,180,3,213,63,131,93,43,174,22,115,243,19,7,48,47,167,62,190,147,4,125,69,164,32,122,27,128,144,3,89,95,124,125,110,161,166,249,10,162,199,220,237,11,179,216,145,114,204,241,254,106,163,114,176,89,200,35,248,18,140,134,84,158,163,190,199,144,4,126,56,25,103,6,173,30,198,38,218,247,195,218,108,94,238,177,69,115,73,35,46,168,95,111,157,96,196,253,244,131,133,190,143,77,223,43,120,36,42,24,112,107,120,17,3,253,160,167,212,224,67,215,57,226,231,109,235,238,178,192,94,63,209,255,205,222,99,179,153,76,211,136,57,110,248,170,119,255,96,211,215,1,210,132,12,0,143,146,175,209,124,253,15,35,77,225,139,252,28,227,115,210,255,132,159,228,254,23,148,64,190,28,215,7,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b546faf9-3ac8-4a7c-a169-bbd0f8b47719"));
		}

		#endregion

	}

	#endregion

}

