﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CampaignAnalyticsProviderSchema

	/// <exclude/>
	public class CampaignAnalyticsProviderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CampaignAnalyticsProviderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CampaignAnalyticsProviderSchema(CampaignAnalyticsProviderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("030e85a7-988e-4d0e-8b48-ddcbedc5a892");
			Name = "CampaignAnalyticsProvider";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6c038aa0-46cd-4697-bc93-5c682e364aef");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,197,88,75,111,227,54,16,62,123,129,253,15,172,123,145,209,64,190,55,177,129,188,107,32,205,6,113,218,30,138,30,24,105,108,19,149,40,45,73,37,113,119,243,223,59,124,233,45,197,9,80,244,146,88,228,204,55,31,135,195,153,33,57,77,65,230,52,2,242,0,66,80,153,109,84,120,158,241,13,219,22,130,42,150,241,207,159,190,125,254,52,41,36,227,91,178,222,75,5,233,113,235,27,229,147,4,34,45,44,195,107,224,32,88,212,145,185,160,138,86,131,117,91,105,154,241,254,25,1,67,227,225,57,77,115,202,182,131,138,225,197,25,78,225,228,143,2,182,72,140,156,39,84,202,159,201,29,21,138,69,44,167,92,201,83,78,147,61,126,201,59,145,61,177,24,132,81,152,207,231,228,68,22,105,74,197,126,233,190,209,33,138,50,46,73,146,109,89,68,54,153,32,17,77,162,34,161,10,36,161,30,199,77,88,102,161,199,154,215,192,242,226,49,65,128,72,147,33,126,13,61,60,38,223,12,151,138,61,186,86,137,34,82,153,208,139,48,40,86,162,77,215,243,245,226,228,121,199,162,29,137,97,195,56,114,45,36,32,197,140,115,187,95,97,9,49,111,99,156,228,84,208,148,112,140,143,197,84,171,157,151,90,211,229,10,241,41,199,160,201,54,104,29,128,68,2,54,139,105,107,15,126,107,106,205,151,39,115,3,106,108,56,87,12,58,33,104,106,147,38,133,25,209,81,57,153,180,132,22,45,49,29,30,147,87,231,75,224,177,117,103,211,183,104,48,7,140,10,208,158,21,236,9,247,212,10,228,246,131,180,108,180,62,45,143,45,168,99,34,241,207,1,6,127,5,181,203,226,33,107,107,208,103,137,92,131,234,141,85,59,29,244,206,221,195,215,2,164,170,2,210,13,120,103,61,81,129,28,13,252,130,112,120,118,182,90,158,158,25,217,137,62,213,69,202,131,105,148,79,143,200,212,239,211,10,15,243,42,158,246,11,173,21,228,120,160,243,4,20,12,203,80,85,200,46,196,85,193,35,252,93,112,53,100,114,22,158,202,96,106,68,74,229,43,145,165,65,41,89,243,202,212,74,35,146,23,253,99,7,2,58,216,136,27,174,228,229,215,130,38,129,101,18,222,233,24,197,21,136,160,237,200,176,82,155,121,216,107,145,21,249,217,254,13,63,181,164,58,78,232,204,55,28,73,168,116,123,101,226,107,98,55,49,92,231,16,177,205,254,54,187,201,162,191,127,97,24,10,193,204,10,176,13,233,146,199,109,126,96,41,92,177,4,215,38,125,80,152,168,216,152,49,100,37,20,38,106,192,96,136,153,59,80,206,214,105,28,151,163,129,183,159,21,34,130,203,151,92,128,148,58,155,156,38,140,74,237,4,1,136,18,127,225,211,35,107,99,114,163,19,39,77,190,224,73,51,85,37,60,229,177,227,58,25,50,142,251,114,109,128,196,23,113,232,6,93,53,177,102,222,70,181,200,139,2,254,175,37,182,77,227,2,111,16,246,189,171,115,48,126,109,175,230,175,0,85,8,238,150,82,207,66,62,175,60,101,44,198,32,106,100,21,115,150,126,167,73,1,1,230,111,114,193,76,2,192,42,112,114,93,176,248,168,191,90,234,200,94,18,134,127,209,15,90,206,252,94,197,206,15,102,68,186,248,62,34,143,89,150,16,38,27,1,125,68,48,86,177,10,161,113,31,133,58,96,127,48,152,225,131,216,99,242,179,172,28,50,201,10,69,244,22,194,11,147,10,171,189,230,48,43,35,184,62,234,50,219,32,115,175,51,177,7,20,197,173,13,59,250,234,246,203,48,249,211,206,252,133,50,117,11,117,175,107,218,126,173,100,177,40,171,153,41,192,218,118,216,147,154,46,133,200,132,207,0,189,139,8,141,72,103,167,144,136,113,154,99,64,32,145,64,62,68,97,197,177,234,109,117,76,143,243,64,169,72,7,62,223,254,135,100,214,133,204,177,84,66,236,185,184,29,250,254,157,124,20,11,9,143,47,172,180,217,93,215,79,67,11,107,69,113,63,112,57,125,32,112,31,198,109,198,15,135,233,57,234,171,75,94,164,152,133,30,19,56,25,57,194,67,45,134,158,149,129,235,67,104,179,241,168,183,18,180,161,224,14,222,59,114,136,47,86,182,127,15,46,206,46,95,32,42,116,207,26,63,150,63,23,173,126,43,188,228,178,16,112,113,86,13,5,85,38,104,177,13,45,12,220,3,213,29,101,176,210,183,16,251,65,132,249,55,35,139,101,153,18,244,162,152,79,11,118,30,239,51,202,230,101,147,144,204,154,150,65,167,202,31,215,16,170,152,29,199,144,101,15,80,215,110,5,217,32,136,206,171,8,210,106,20,234,72,145,59,165,253,250,152,129,151,101,51,229,213,198,203,67,115,191,143,124,218,175,37,251,78,158,183,57,222,193,191,246,21,172,38,104,104,172,201,122,253,234,189,224,172,159,105,46,235,55,143,177,126,184,221,20,224,69,4,205,198,164,66,127,15,140,171,190,8,226,245,159,119,192,177,185,16,216,121,111,109,191,66,212,142,234,90,140,23,173,248,208,43,150,176,86,6,239,86,99,212,144,76,216,184,91,213,107,254,109,38,82,154,176,127,92,227,167,201,99,203,161,207,131,222,212,209,139,132,104,222,31,116,18,20,253,62,37,75,34,122,155,148,122,151,169,210,188,82,88,144,1,40,23,45,67,134,218,122,206,80,175,150,155,67,157,186,233,110,226,124,251,166,246,230,141,187,122,14,240,15,0,36,175,92,91,123,35,120,220,187,125,215,222,183,91,223,238,243,244,118,246,0,215,240,164,59,221,207,76,237,240,167,79,22,58,170,57,242,174,70,54,9,221,218,119,9,160,209,174,226,166,207,238,161,145,217,161,247,209,16,173,61,79,216,231,148,220,183,186,178,249,166,82,185,171,17,214,134,153,205,27,114,121,111,255,31,96,95,230,216,49,152,83,207,28,111,68,245,48,181,167,136,81,245,193,106,249,241,171,184,240,208,35,45,107,105,222,29,163,234,2,138,90,35,215,83,27,226,54,210,199,19,64,135,225,113,183,192,175,253,163,193,27,175,18,3,88,126,161,225,105,187,99,24,111,65,218,189,199,113,189,112,120,208,145,23,23,59,218,28,124,253,23,92,21,11,213,241,20,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("030e85a7-988e-4d0e-8b48-ddcbedc5a892"));
		}

		#endregion

	}

	#endregion

}

