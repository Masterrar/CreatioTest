﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ExcludeCampaignAudienceElementSchema

	/// <exclude/>
	public class ExcludeCampaignAudienceElementSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ExcludeCampaignAudienceElementSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ExcludeCampaignAudienceElementSchema(ExcludeCampaignAudienceElementSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("83643f4d-6b79-41b1-827b-45f9c1bce5f4");
			Name = "ExcludeCampaignAudienceElement";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("0fa99f9a-3eca-422f-9a3c-3294c39b5190");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,86,77,111,227,54,16,61,123,129,253,15,83,47,176,149,129,64,190,199,177,139,212,235,4,1,182,104,26,239,173,232,129,166,70,54,1,138,84,248,17,59,8,242,223,59,36,37,89,142,99,111,246,98,72,212,188,249,120,243,102,104,197,42,180,53,227,8,63,208,24,102,117,233,242,185,86,165,88,123,195,156,208,234,243,167,151,207,159,6,222,10,181,134,229,179,117,88,77,222,188,231,223,133,122,60,58,156,107,41,145,7,15,54,191,69,133,70,240,189,77,63,150,193,124,206,170,154,137,181,58,105,240,237,79,250,68,31,191,24,92,147,71,152,75,102,237,37,44,118,92,250,2,91,248,181,47,4,42,142,11,137,21,42,23,17,227,241,24,174,172,175,42,102,158,103,205,251,98,135,220,59,182,146,8,188,129,2,38,12,108,55,130,111,0,147,99,224,90,57,198,157,133,210,232,106,111,204,154,64,121,27,96,220,139,80,251,149,20,28,120,72,241,39,25,194,37,180,95,110,164,222,118,121,15,94,98,238,93,185,247,70,215,104,156,64,170,249,222,136,39,230,48,25,212,233,5,110,189,40,224,158,145,9,23,53,83,110,233,152,243,246,174,128,233,12,238,108,27,227,86,51,25,80,131,63,186,176,212,106,235,8,96,187,30,244,188,60,32,227,27,44,2,172,117,24,225,151,31,131,47,118,194,97,209,34,39,135,25,223,45,148,175,208,132,38,92,133,236,103,112,45,137,2,44,142,170,64,75,85,196,184,10,183,255,254,7,47,241,121,240,161,20,186,71,71,162,106,51,185,248,5,7,135,53,252,10,242,20,121,175,13,17,95,80,21,169,189,103,122,29,165,148,190,191,21,114,60,184,145,108,221,72,86,168,66,112,98,214,130,219,48,215,233,89,216,78,182,191,91,88,83,54,160,13,40,237,242,206,105,95,188,173,122,87,90,203,55,202,129,23,88,163,155,128,13,63,175,231,139,248,11,221,70,23,167,212,186,196,176,25,96,110,144,222,218,145,72,135,217,168,233,239,19,51,20,41,218,77,97,197,44,210,18,113,173,237,63,30,205,115,54,154,236,45,27,134,169,35,133,8,59,135,64,9,157,119,71,249,141,48,214,253,109,190,97,201,188,116,217,174,149,213,96,151,127,199,146,90,93,27,180,54,88,46,181,55,28,105,131,249,74,93,75,193,108,190,120,244,76,218,108,216,182,114,56,74,208,193,215,175,112,2,126,0,124,71,32,63,130,246,71,77,17,162,132,236,184,136,223,166,160,188,148,45,39,131,163,146,30,176,210,79,120,140,108,188,190,198,95,131,206,27,213,240,145,28,229,215,170,56,153,211,5,28,151,153,223,169,44,241,145,147,57,221,25,14,141,205,78,143,236,104,4,204,54,141,142,185,124,92,48,218,17,6,139,51,170,127,136,5,89,146,124,24,63,186,186,116,73,70,72,235,218,96,57,29,70,117,12,199,51,216,10,183,9,43,60,113,66,131,161,131,130,187,237,29,222,107,163,57,117,237,196,48,196,147,68,159,157,69,183,201,103,41,36,213,191,119,180,143,145,95,141,91,251,164,248,166,26,160,54,25,35,232,74,73,110,142,197,28,86,245,251,19,49,57,67,69,186,202,104,232,185,55,38,204,123,73,29,217,95,102,33,217,46,203,199,24,185,151,235,153,162,235,208,100,80,212,232,233,48,58,104,242,28,54,52,148,180,68,104,51,86,7,100,174,176,229,19,11,34,34,250,56,230,113,174,61,165,70,45,235,174,211,122,175,31,219,108,179,45,154,158,51,88,61,119,5,210,159,139,250,231,44,11,178,92,210,206,151,216,48,148,165,188,251,181,180,99,213,204,199,18,93,79,200,54,41,57,203,82,23,70,125,224,197,123,87,237,232,140,204,211,233,225,33,157,253,15,243,26,119,55,124,9,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("83643f4d-6b79-41b1-827b-45f9c1bce5f4"));
		}

		#endregion

	}

	#endregion

}
