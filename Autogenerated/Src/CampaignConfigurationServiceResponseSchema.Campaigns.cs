namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CampaignConfigurationServiceResponseSchema

	/// <exclude/>
	public class CampaignConfigurationServiceResponseSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CampaignConfigurationServiceResponseSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CampaignConfigurationServiceResponseSchema(CampaignConfigurationServiceResponseSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("fd1fe187-de0b-4898-b834-f29572b7524b");
			Name = "CampaignConfigurationServiceResponse";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6c038aa0-46cd-4697-bc93-5c682e364aef");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,83,61,111,194,48,16,157,131,196,127,56,193,66,150,176,67,219,5,58,116,0,33,168,212,161,98,56,204,37,117,149,216,145,237,148,82,212,255,222,203,23,4,212,162,8,117,179,159,238,221,123,239,124,86,152,144,77,81,16,60,147,49,104,117,232,130,137,86,161,140,50,131,78,106,213,237,28,186,29,47,179,82,69,176,218,91,71,201,248,120,63,81,230,153,12,86,100,62,164,160,153,222,82,28,76,209,33,247,113,6,133,27,95,52,8,150,153,114,50,161,156,33,49,150,95,133,16,87,113,93,223,80,196,23,152,196,104,237,8,38,152,164,40,35,117,102,169,18,90,178,113,173,44,21,188,225,112,8,119,54,75,18,52,251,135,234,94,235,67,168,13,136,170,19,216,146,13,166,162,7,53,123,216,160,191,54,253,175,25,72,179,77,44,5,136,220,86,43,87,48,130,235,166,189,67,97,252,148,152,97,103,50,225,180,225,224,139,66,175,172,184,204,86,0,83,10,49,139,29,136,19,13,156,6,97,8,29,129,100,16,21,167,212,97,43,183,193,81,167,57,133,58,117,155,14,3,31,242,69,241,188,23,52,138,223,250,73,133,26,238,65,209,14,26,200,192,207,151,193,251,190,18,108,114,91,2,216,73,247,6,188,144,60,7,153,107,111,208,210,22,120,176,244,41,40,205,25,255,16,242,177,238,5,228,243,11,231,26,3,186,33,121,159,212,182,124,247,243,37,88,24,157,146,113,146,218,172,64,213,29,244,230,157,132,251,35,93,177,201,51,74,54,100,6,115,254,236,236,172,183,59,217,234,249,235,198,12,154,9,154,231,50,95,68,197,87,246,60,91,29,126,15,83,162,231,32,99,63,180,197,214,26,106,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("fd1fe187-de0b-4898-b834-f29572b7524b"));
		}

		#endregion

	}

	#endregion

}

