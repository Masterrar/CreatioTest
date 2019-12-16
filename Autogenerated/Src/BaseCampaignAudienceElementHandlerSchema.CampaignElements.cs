﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: BaseCampaignAudienceElementHandlerSchema

	/// <exclude/>
	public class BaseCampaignAudienceElementHandlerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public BaseCampaignAudienceElementHandlerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public BaseCampaignAudienceElementHandlerSchema(BaseCampaignAudienceElementHandlerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("326349f5-a353-47fc-80f8-b6d9a046a25f");
			Name = "BaseCampaignAudienceElementHandler";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d0bba11f-3986-4819-81ab-1d3ddbfc1f48");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,205,88,91,111,219,54,20,126,118,129,253,7,206,123,145,1,71,65,210,110,197,154,216,129,227,218,109,134,164,25,154,164,125,24,134,129,145,40,155,168,68,121,36,237,198,43,250,223,119,120,21,37,203,118,82,116,192,128,32,176,72,158,251,119,46,36,195,5,17,11,156,16,116,75,56,199,162,204,100,60,46,89,70,103,75,142,37,45,217,15,207,190,252,240,172,179,20,148,205,208,205,90,72,82,156,52,190,225,124,158,147,68,29,22,241,27,194,8,167,201,198,153,215,88,226,141,197,75,202,254,174,22,67,5,138,162,100,237,59,156,196,35,41,57,189,95,74,34,182,30,25,227,98,129,233,108,59,15,119,32,158,172,8,147,111,49,75,115,194,171,211,234,140,59,114,147,204,73,129,209,0,213,9,235,219,64,10,196,135,135,135,232,84,44,139,2,243,245,208,126,131,55,37,166,76,160,130,200,121,153,10,148,149,28,21,176,162,86,149,44,188,76,41,97,16,1,146,147,2,148,17,136,50,148,56,49,142,235,97,192,118,177,188,207,105,130,240,189,144,28,39,18,37,57,22,2,157,99,225,117,30,89,158,19,195,210,218,135,94,33,119,32,52,91,17,246,209,197,53,243,212,153,36,252,6,175,72,31,132,117,130,141,113,185,88,195,210,23,109,108,231,39,78,102,16,116,101,161,144,24,20,127,133,126,231,116,133,37,49,251,11,243,129,18,181,143,64,87,227,89,48,60,145,183,248,62,39,239,0,124,224,215,174,93,235,158,108,165,154,150,121,10,42,105,87,55,168,204,86,247,196,234,68,88,106,212,170,235,56,165,36,79,181,130,165,4,172,146,212,108,55,3,166,23,180,128,50,67,114,238,99,130,230,198,85,177,39,10,227,1,58,91,174,78,95,82,243,187,98,120,178,67,224,45,8,186,187,72,157,204,154,97,72,104,163,247,10,126,179,164,169,242,89,69,105,188,165,248,14,16,35,159,245,137,168,59,26,61,255,121,52,29,191,56,24,159,31,29,29,188,56,30,253,122,112,126,244,114,114,112,60,157,78,166,71,47,159,79,38,231,191,116,123,123,188,9,94,92,16,46,41,81,30,213,96,220,97,221,136,1,160,21,64,18,239,213,83,65,32,192,156,100,131,174,209,245,45,201,129,97,247,112,184,213,78,3,138,240,52,250,43,11,190,12,118,76,98,212,78,213,62,84,45,235,116,102,68,218,95,29,78,228,146,179,58,43,116,118,134,162,250,138,241,96,200,42,234,245,180,200,206,87,253,95,84,44,155,148,43,156,47,73,112,246,235,110,223,94,153,50,177,37,151,46,38,108,89,16,174,178,231,116,71,194,15,209,27,34,175,202,148,102,148,164,141,61,17,245,172,170,43,204,81,178,228,28,22,221,30,232,11,148,27,20,245,98,103,45,167,25,106,108,196,23,140,74,138,115,87,50,193,109,203,60,239,53,156,221,16,25,186,81,105,68,13,143,39,105,84,23,108,245,83,204,4,164,94,192,169,193,59,254,173,164,44,106,232,211,55,202,118,236,89,52,24,58,178,24,146,201,237,90,34,181,107,127,134,187,145,165,232,187,205,158,58,232,86,99,3,36,149,153,3,79,237,214,42,146,158,97,22,127,156,19,78,162,7,197,225,33,190,128,198,121,228,118,110,136,106,188,225,214,177,181,189,221,213,241,228,33,33,11,25,133,94,49,4,95,119,36,240,221,34,5,232,9,223,59,148,28,244,153,202,185,170,55,204,148,159,122,205,130,82,164,186,156,74,245,156,66,21,135,180,119,205,109,75,130,235,149,5,230,184,64,12,148,27,116,221,249,238,240,210,114,8,138,198,14,228,171,26,114,122,168,57,213,42,199,170,4,165,140,37,99,167,181,209,86,92,176,172,140,30,157,88,78,49,135,106,48,148,224,100,142,34,5,55,215,46,160,131,55,207,105,56,102,62,240,110,223,199,61,190,16,147,98,33,215,144,157,103,58,109,16,22,186,102,159,65,219,110,30,54,65,238,88,123,130,184,120,219,222,147,164,228,169,54,205,17,223,105,112,181,182,136,190,215,172,247,77,149,106,127,83,125,175,1,41,106,152,0,93,32,158,170,215,91,11,54,103,161,62,18,11,146,64,25,75,52,162,64,69,186,2,184,237,110,199,27,96,50,61,180,59,116,158,178,77,213,247,165,26,98,52,181,201,31,225,193,247,8,85,129,137,163,170,183,102,63,167,61,165,120,111,22,188,205,145,84,248,106,183,213,237,31,57,85,169,11,61,136,166,122,158,135,49,84,8,60,35,72,150,225,42,39,98,153,63,62,59,113,67,59,112,173,191,4,184,38,223,230,160,134,151,67,150,14,128,27,188,104,10,196,170,145,113,225,88,223,243,242,19,97,22,179,123,248,90,123,187,195,91,242,32,29,131,77,127,236,102,146,147,21,201,129,133,2,175,250,249,72,62,21,6,116,249,209,193,248,224,73,158,86,119,154,46,183,173,70,1,244,84,149,137,161,79,97,149,52,102,12,181,58,245,125,233,174,11,191,212,166,104,131,90,171,153,175,86,148,85,204,107,245,204,213,187,193,134,122,241,148,114,33,175,249,107,146,97,64,150,235,81,97,231,107,148,28,61,79,120,134,141,209,161,163,234,22,101,110,144,178,227,66,199,218,185,170,153,117,101,17,62,176,110,0,161,188,192,50,242,222,112,5,113,140,23,138,198,201,111,140,20,163,52,109,196,170,85,76,223,58,112,179,110,182,38,228,120,78,146,79,2,145,7,136,27,97,66,143,196,22,199,202,205,121,137,83,162,6,121,151,1,177,75,97,155,161,141,188,165,160,200,222,187,129,6,159,22,108,59,222,196,73,255,62,240,179,65,85,62,41,83,146,59,36,138,94,3,83,59,4,132,157,179,41,202,131,64,1,228,71,151,244,35,182,246,131,143,134,83,179,71,246,42,240,212,211,193,76,148,151,201,63,55,122,249,131,154,207,29,240,130,27,91,31,217,203,201,187,18,218,229,146,165,19,206,75,222,117,104,249,190,216,251,102,240,237,200,236,88,43,220,171,101,204,94,124,94,2,0,69,128,200,76,235,175,160,150,241,178,0,171,74,174,170,220,119,234,19,143,232,17,174,167,110,54,24,155,43,85,23,104,111,191,237,16,85,118,126,211,252,183,13,157,109,133,184,173,46,214,103,118,15,214,248,182,84,28,162,224,238,226,130,48,168,93,60,99,192,110,168,120,243,105,164,31,246,129,59,65,184,29,9,43,176,217,187,129,101,191,119,252,159,82,6,150,164,107,136,168,158,194,140,82,106,254,47,151,18,101,52,151,202,251,143,4,132,37,111,226,96,107,39,111,206,97,45,195,192,54,141,118,226,193,4,74,153,102,125,249,17,168,223,149,83,77,27,237,174,106,193,237,57,219,36,182,111,5,149,20,23,82,95,6,27,140,45,147,170,201,214,11,158,89,139,111,215,11,98,234,220,21,230,159,8,244,194,153,126,119,19,22,66,106,255,181,137,17,160,201,87,190,251,178,204,97,90,22,94,183,26,148,116,79,184,33,152,39,115,245,64,251,214,157,139,154,175,116,14,84,113,117,248,156,50,119,219,237,180,194,204,214,107,47,188,82,170,211,226,54,85,241,156,173,213,72,224,250,124,80,188,26,240,13,121,132,80,222,127,105,217,247,110,229,174,189,213,37,151,235,59,149,169,138,40,178,55,44,152,239,89,138,170,199,182,76,191,52,246,16,86,143,168,213,117,1,220,128,238,9,12,173,73,185,160,36,221,146,47,127,92,115,48,42,58,238,253,25,60,103,233,246,125,173,31,95,253,211,141,228,235,112,14,195,249,211,222,75,122,245,11,100,219,133,56,96,233,102,27,176,70,42,0,155,87,4,229,77,242,224,163,234,4,92,150,179,25,196,80,247,30,219,252,218,122,43,121,168,122,151,237,121,19,200,108,185,174,130,47,231,188,252,252,200,177,234,63,10,150,192,171,173,177,170,71,199,191,153,111,11,81,97,95,227,234,113,218,254,70,183,63,66,77,142,255,175,48,53,18,16,86,225,239,95,94,54,233,50,111,26,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("326349f5-a353-47fc-80f8-b6d9a046a25f"));
		}

		#endregion

	}

	#endregion

}

