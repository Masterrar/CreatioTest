namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CampaignInfoSchema

	/// <exclude/>
	public class CampaignInfoSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CampaignInfoSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CampaignInfoSchema(CampaignInfoSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("d788e01e-bff4-487a-85dc-ee3d99dc9d42");
			Name = "CampaignInfo";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6c038aa0-46cd-4697-bc93-5c682e364aef");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,146,221,106,132,48,16,133,175,87,240,29,6,246,94,239,187,165,55,66,203,222,9,219,62,64,86,199,236,64,126,108,38,161,136,244,221,27,227,186,218,82,10,91,144,192,156,113,206,124,228,196,8,141,220,139,6,225,21,157,19,108,59,95,84,214,116,36,131,19,158,172,201,179,49,207,118,129,201,72,56,13,236,81,31,98,29,191,189,67,25,251,80,41,193,252,0,149,208,189,32,105,142,166,179,121,22,251,101,89,194,35,7,173,133,27,158,174,117,250,23,252,69,120,112,216,59,100,52,158,65,145,188,248,15,156,78,104,174,54,192,94,120,4,138,110,160,109,139,170,88,44,203,141,103,31,206,138,26,104,146,237,119,130,221,152,40,110,152,181,179,61,58,79,24,89,235,52,54,247,127,98,38,225,205,208,123,136,219,219,200,71,29,161,3,219,173,104,147,232,135,226,54,189,37,90,144,94,2,181,43,81,11,35,72,244,7,224,233,248,252,247,230,233,82,2,223,177,249,148,6,238,216,255,172,132,156,3,34,211,82,19,51,224,117,125,239,172,140,161,241,28,206,223,24,103,107,21,28,77,189,140,252,2,176,71,211,206,233,164,122,86,183,98,124,102,81,252,2,83,186,50,19,163,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d788e01e-bff4-487a-85dc-ee3d99dc9d42"));
		}

		#endregion

	}

	#endregion

}

