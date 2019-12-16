﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: PortalEmailMessageUtilitiesSchema

	/// <exclude/>
	public class PortalEmailMessageUtilitiesSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public PortalEmailMessageUtilitiesSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public PortalEmailMessageUtilitiesSchema(PortalEmailMessageUtilitiesSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("9b5fef7d-8ca5-4e04-8544-f0e6ae74f9d5");
			Name = "PortalEmailMessageUtilities";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("33bac096-c819-4c57-86af-fe71bbb0cb56");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,197,87,109,111,218,72,16,254,236,74,253,15,115,110,165,3,93,206,168,95,211,128,148,82,218,114,186,164,81,33,119,31,79,27,123,128,213,217,187,238,238,58,4,69,249,239,55,251,98,176,137,33,244,164,211,125,1,188,158,121,230,153,217,121,67,176,2,117,201,82,132,57,42,197,180,92,152,100,44,197,130,47,43,197,12,151,226,245,171,199,215,175,162,74,115,177,132,217,70,27,44,222,111,159,151,185,188,99,249,249,249,88,22,133,20,201,239,114,185,164,227,221,251,38,164,194,67,231,201,199,15,7,95,77,132,225,134,163,38,1,18,121,163,112,73,148,224,70,42,195,242,73,193,120,126,133,90,179,37,222,26,158,59,65,39,55,24,12,224,66,87,69,193,212,102,20,158,191,97,169,80,163,48,26,42,39,188,129,52,103,90,195,66,42,88,75,245,55,172,185,89,65,233,160,1,45,54,20,30,92,39,53,230,160,1,90,86,119,57,79,65,27,10,83,26,176,142,18,139,30,29,185,168,84,252,158,25,132,84,10,109,72,95,89,191,47,83,195,239,137,212,44,93,145,237,107,186,21,24,66,92,159,198,239,155,138,193,164,66,150,73,145,111,96,74,129,135,191,114,250,24,2,253,188,98,130,12,171,228,51,26,123,35,168,122,241,115,94,113,223,135,116,27,211,43,52,43,153,233,115,184,241,86,252,219,253,72,186,3,2,214,117,108,96,197,181,145,106,3,60,163,216,242,5,71,229,34,106,86,8,44,176,79,182,72,131,125,168,139,146,41,86,128,32,127,135,113,45,31,143,106,191,193,98,18,192,197,192,201,237,212,20,154,74,9,61,154,238,172,202,5,140,153,198,224,223,151,64,75,97,42,85,6,70,194,29,17,202,220,47,203,237,121,68,200,72,141,218,17,236,207,21,207,172,227,181,137,134,141,105,214,115,105,186,217,58,220,7,91,51,81,116,207,20,104,204,49,53,116,51,13,229,157,238,204,189,237,109,21,221,61,71,158,71,80,77,38,15,152,86,6,103,41,203,153,186,176,68,70,61,47,248,116,228,146,198,148,30,6,117,109,255,123,133,20,13,114,190,35,70,46,241,23,60,55,20,197,187,141,147,160,22,96,136,20,112,177,205,204,27,166,40,16,188,100,84,66,255,225,141,206,154,124,27,204,180,165,150,18,181,147,248,29,189,203,96,226,216,133,28,184,80,151,5,245,225,52,163,91,221,230,56,161,205,55,37,102,99,153,87,133,248,131,229,21,134,187,138,167,89,28,46,214,233,91,39,78,214,29,59,225,184,157,24,2,215,176,151,57,201,173,70,69,81,17,116,72,229,220,119,226,81,50,151,101,239,93,253,224,225,61,102,219,235,248,12,28,203,32,248,73,201,194,139,109,143,126,147,92,244,236,135,37,154,76,201,142,58,107,244,167,32,22,37,95,3,126,141,152,76,245,228,123,197,242,222,78,150,222,212,94,29,5,239,160,121,130,153,110,231,218,6,163,228,82,100,109,70,167,128,124,115,189,228,69,222,29,9,217,38,126,216,110,151,106,3,241,160,7,123,242,141,199,231,126,185,112,248,242,105,184,242,231,10,21,30,161,230,115,39,185,177,69,139,84,142,189,93,21,244,107,12,71,169,243,86,158,105,251,26,8,154,78,177,159,92,75,67,159,147,7,10,184,238,121,200,147,19,125,151,220,29,163,174,149,220,117,118,119,141,196,90,34,4,163,27,234,121,110,52,193,95,72,33,43,10,76,7,167,156,82,227,185,217,212,223,160,200,252,104,62,52,167,221,254,113,100,2,204,86,114,173,195,38,67,138,97,179,225,139,86,3,69,23,238,255,161,207,207,85,133,103,150,77,152,208,107,138,130,38,198,152,157,129,164,9,173,214,156,122,253,175,176,96,185,222,159,205,14,8,31,82,44,109,10,64,170,112,49,140,41,125,102,85,105,189,196,108,82,191,139,71,243,149,178,97,88,175,80,4,206,36,189,79,123,48,2,174,197,207,6,216,46,14,100,115,107,194,79,145,214,194,119,39,101,238,66,252,85,248,60,57,52,51,200,197,93,242,54,214,187,159,134,29,75,95,173,20,25,75,219,53,250,78,191,194,2,96,147,37,236,25,105,71,90,182,183,142,246,202,178,183,114,88,150,157,16,68,211,142,162,100,82,148,59,159,252,32,227,206,128,125,121,141,107,251,93,179,114,132,184,160,66,181,139,143,117,98,234,30,94,44,226,169,48,242,120,105,206,208,184,129,122,6,207,122,10,223,118,162,32,214,89,169,29,138,93,126,239,65,81,235,231,37,71,215,94,15,182,194,206,57,238,247,251,145,131,64,15,209,223,3,159,81,169,163,250,247,200,65,191,11,246,35,173,61,63,12,108,149,230,188,192,81,3,99,31,124,170,191,152,34,255,32,179,205,15,195,219,202,25,181,16,246,193,195,101,88,205,238,27,59,101,115,106,131,144,137,144,155,174,112,125,114,134,205,218,166,177,63,168,119,237,94,31,134,67,120,23,52,108,109,180,21,182,117,224,11,65,111,244,101,86,112,113,43,184,105,111,118,237,60,79,198,149,82,148,1,246,52,153,102,1,62,178,127,221,40,245,23,242,147,84,5,51,189,183,97,211,240,235,47,1,62,242,236,137,90,83,214,177,188,219,183,93,249,251,4,49,252,18,240,163,183,177,237,174,244,239,135,92,165,45,122,214,160,11,143,109,242,79,245,170,25,90,75,189,114,182,253,111,54,159,32,224,250,244,145,1,230,79,219,135,79,255,0,144,164,248,237,126,16,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("9b5fef7d-8ca5-4e04-8544-f0e6ae74f9d5"));
		}

		#endregion

	}

	#endregion

}
