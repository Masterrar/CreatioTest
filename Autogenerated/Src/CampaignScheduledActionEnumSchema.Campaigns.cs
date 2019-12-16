namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CampaignScheduledActionEnumSchema

	/// <exclude/>
	public class CampaignScheduledActionEnumSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CampaignScheduledActionEnumSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CampaignScheduledActionEnumSchema(CampaignScheduledActionEnumSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("ee85b26e-3465-4222-8e7e-6c8dbf431c31");
			Name = "CampaignScheduledActionEnum";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6c038aa0-46cd-4697-bc93-5c682e364aef");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,147,203,106,195,64,12,69,215,54,248,31,4,221,150,184,175,85,169,3,37,233,15,52,133,174,149,177,236,12,100,30,204,99,17,74,255,189,242,56,110,92,226,4,211,165,196,157,115,175,36,70,163,34,111,81,16,124,144,115,232,77,19,22,43,163,27,217,70,135,65,26,93,228,95,69,94,228,217,141,163,150,75,120,211,81,61,195,10,149,69,217,234,141,216,81,29,247,84,191,138,94,204,202,178,44,225,197,71,165,208,29,150,199,122,77,232,133,147,91,242,128,73,233,161,49,14,196,17,3,181,228,16,129,97,110,49,16,202,17,194,198,237,94,10,32,246,190,108,157,113,208,236,204,61,53,222,163,62,121,245,1,22,191,226,177,81,214,41,43,184,187,77,147,76,195,54,1,93,152,137,235,181,21,220,95,7,26,59,155,199,210,10,30,174,226,134,197,128,159,76,10,159,59,26,173,35,137,88,204,183,13,82,17,212,212,72,77,126,160,73,125,2,166,105,214,24,168,235,14,119,224,171,4,25,14,151,2,255,121,203,209,31,231,70,159,216,201,89,114,99,237,220,228,198,254,59,120,90,249,19,55,191,251,159,64,186,238,63,67,87,114,239,7,24,145,138,250,68,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ee85b26e-3465-4222-8e7e-6c8dbf431c31"));
		}

		#endregion

	}

	#endregion

}

