namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CampaignAppEventListenerSchema

	/// <exclude/>
	public class CampaignAppEventListenerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CampaignAppEventListenerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CampaignAppEventListenerSchema(CampaignAppEventListenerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("3e664810-988a-4dee-b55a-dbf31d8fa22e");
			Name = "CampaignAppEventListener";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("1f302b36-4763-41e5-806c-b1f1f1b6d901");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,205,84,81,107,219,48,16,126,78,161,255,225,112,95,82,24,246,123,154,26,182,52,101,25,29,27,75,97,207,138,124,182,197,162,147,145,228,18,175,236,191,239,44,39,153,147,37,51,148,177,245,77,186,59,125,247,221,167,79,34,161,209,85,66,34,60,162,181,194,153,220,199,51,67,185,42,106,43,188,50,116,121,241,124,121,49,170,157,162,226,160,196,98,60,19,186,18,170,160,155,161,130,120,65,30,109,206,93,220,112,237,210,11,235,151,188,18,235,179,197,247,66,122,99,213,105,184,175,184,226,42,173,77,75,140,243,87,22,11,30,4,102,107,225,220,4,230,27,89,10,42,240,109,85,205,159,144,252,131,114,30,9,109,168,77,146,4,166,174,214,90,216,38,221,238,191,96,101,209,113,165,3,141,190,52,153,3,111,64,145,242,74,172,213,119,4,150,239,155,40,48,222,157,79,122,0,85,189,90,43,9,178,237,13,187,25,143,91,195,4,22,191,211,25,61,7,74,123,254,31,187,230,19,248,28,48,187,228,49,225,16,120,167,136,73,110,105,57,206,35,130,180,152,223,70,65,131,78,189,38,74,82,80,30,181,139,247,64,201,49,210,180,18,86,104,32,118,201,109,36,13,95,227,198,71,233,130,156,23,196,158,49,121,31,124,55,194,108,91,151,164,241,52,9,0,1,111,43,197,147,81,25,124,106,53,8,55,61,62,58,5,219,46,215,208,250,110,52,234,51,142,219,193,166,139,157,140,243,13,202,186,245,232,131,41,10,180,111,224,76,34,29,71,181,67,203,13,8,101,27,142,174,111,134,176,63,152,213,157,226,135,225,101,217,71,62,8,191,4,247,81,105,92,242,225,172,94,247,113,15,194,47,193,189,183,162,208,172,226,178,33,89,90,67,236,203,30,252,169,108,58,30,70,237,158,225,156,188,242,205,123,65,217,1,231,19,201,115,204,127,252,193,172,193,10,115,202,0,117,229,27,40,59,164,255,229,73,38,50,228,200,36,185,51,64,198,151,237,183,147,27,11,188,218,191,54,104,208,199,195,35,47,209,57,150,39,188,128,87,48,120,159,206,63,28,255,117,220,250,47,50,127,117,244,43,164,172,251,185,195,190,139,30,6,57,246,19,0,30,201,196,128,7,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("3e664810-988a-4dee-b55a-dbf31d8fa22e"));
		}

		#endregion

	}

	#endregion

}

