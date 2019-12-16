﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: BulkEmailNotificationProviderSchema

	/// <exclude/>
	public class BulkEmailNotificationProviderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public BulkEmailNotificationProviderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public BulkEmailNotificationProviderSchema(BulkEmailNotificationProviderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("36980980-5c31-4ced-b403-cc72d034ec69");
			Name = "BulkEmailNotificationProvider";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("bf106969-ca59-4591-8fd8-1964385773cf");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,189,88,221,111,219,54,16,127,118,129,254,15,156,10,20,50,22,200,235,107,157,26,112,155,52,240,214,54,65,236,108,15,109,81,48,210,57,225,170,15,143,164,50,120,65,254,247,29,191,100,82,150,100,247,97,123,73,76,242,126,247,125,199,163,74,90,128,216,208,20,200,10,56,167,162,90,203,228,93,85,174,217,93,205,169,100,85,249,252,217,227,243,103,163,90,176,242,46,32,225,144,156,189,157,54,71,203,173,144,80,224,126,158,67,170,112,34,185,128,18,56,75,167,61,240,54,22,215,184,243,130,195,29,162,201,187,156,10,241,154,188,173,243,239,231,5,101,249,167,74,178,53,75,181,74,87,188,122,96,25,112,13,152,76,38,228,84,212,69,65,249,118,102,215,13,138,148,30,140,108,44,46,113,176,137,135,219,212,183,57,75,73,170,228,14,139,37,168,22,21,208,117,116,66,22,221,138,142,148,19,27,227,222,51,200,51,180,238,138,179,7,42,65,219,49,218,152,5,73,209,119,146,8,201,149,107,46,174,47,111,174,190,125,154,127,60,39,111,72,228,243,142,166,189,32,71,222,88,17,25,223,142,94,64,153,25,21,236,218,57,91,161,121,157,202,138,43,173,180,39,172,82,198,43,131,254,136,111,4,112,100,81,154,192,147,58,88,142,21,155,209,107,114,139,46,139,91,71,68,123,229,233,7,68,157,49,141,196,152,157,26,99,79,72,117,251,39,178,155,145,13,229,152,203,18,184,8,68,122,219,158,184,33,111,160,176,13,112,201,160,229,139,118,166,233,141,11,94,213,27,82,162,136,164,161,241,211,202,153,229,226,169,201,181,30,163,59,144,246,215,136,131,172,121,233,69,91,7,87,169,218,184,167,83,122,147,146,71,43,240,9,9,123,229,119,75,238,243,211,71,144,247,149,73,227,74,98,8,32,115,137,108,151,164,122,192,138,71,253,200,67,197,50,50,207,50,108,15,117,81,138,120,9,170,75,16,161,255,217,184,140,204,202,40,148,24,202,56,186,134,130,149,25,106,30,157,144,104,145,69,227,100,46,98,253,99,136,208,44,86,172,0,11,240,55,134,128,152,156,146,166,178,17,212,28,122,7,67,248,51,16,41,103,27,93,160,134,67,176,211,130,238,10,212,55,174,217,237,16,22,32,84,44,45,102,197,100,190,111,26,54,214,101,122,15,5,109,81,159,151,146,201,173,57,50,219,45,160,95,123,98,9,82,162,121,66,49,65,142,139,130,222,193,46,18,110,53,245,75,185,39,3,126,173,88,185,162,183,57,28,147,1,31,96,45,47,107,44,92,133,210,182,204,51,244,244,77,201,36,202,190,28,138,220,66,156,255,85,211,188,5,10,137,172,148,5,54,35,43,97,231,219,14,246,203,90,183,153,144,253,94,252,122,85,183,97,232,98,188,21,126,56,246,244,223,5,240,166,95,66,119,188,44,241,232,7,133,14,5,223,71,221,28,27,118,93,248,40,91,51,236,142,188,106,213,73,72,103,9,166,94,102,36,243,50,107,89,226,43,187,218,110,192,15,173,53,200,36,117,114,229,46,130,216,47,106,33,69,210,230,209,156,47,178,241,33,3,131,251,126,81,174,43,114,1,242,26,210,138,103,237,147,216,232,213,113,133,153,255,51,146,53,71,70,231,223,105,94,131,187,183,70,23,53,250,146,153,122,155,54,59,201,138,111,209,52,188,233,186,209,159,155,18,253,138,119,101,45,29,7,235,88,219,249,75,248,155,236,233,235,4,143,116,119,193,137,162,79,130,233,62,95,79,12,245,219,42,219,14,16,251,13,209,65,172,138,136,178,218,217,125,147,110,250,64,105,168,236,237,53,211,111,155,95,199,1,131,93,167,27,208,107,175,41,58,229,62,130,16,78,189,131,90,248,194,253,238,115,12,214,167,247,249,232,161,193,106,175,127,155,43,218,207,204,195,119,244,161,65,102,190,217,128,78,122,61,75,144,106,141,51,165,190,172,201,186,226,36,229,64,85,31,240,188,167,72,228,61,150,184,214,190,103,248,208,59,122,4,211,108,223,68,150,105,52,155,163,10,0,138,241,250,77,244,129,9,121,186,154,33,22,96,22,77,102,78,118,114,58,209,96,127,144,9,123,11,246,39,55,84,104,38,174,148,44,3,151,194,142,31,182,24,51,61,76,247,183,189,203,161,227,212,159,32,58,142,237,253,240,142,218,155,190,159,164,135,127,48,39,248,161,237,140,214,181,46,91,161,3,192,117,183,193,127,162,206,229,177,113,232,206,193,86,88,250,91,85,228,60,108,194,31,196,73,203,50,125,69,132,252,150,146,99,215,158,33,181,59,238,138,171,27,149,93,31,189,214,134,117,141,254,199,245,77,203,79,30,104,98,65,95,154,250,72,150,13,192,84,161,6,212,188,73,148,1,148,151,77,33,250,118,184,121,182,210,44,196,10,151,96,135,25,236,180,126,160,156,124,7,37,19,205,252,153,68,223,34,252,187,179,97,71,180,169,54,248,116,49,109,236,74,253,62,163,146,238,223,17,218,205,225,77,160,108,218,111,232,141,182,253,173,218,27,176,188,150,167,181,193,135,36,163,57,251,7,174,172,90,90,189,100,233,182,227,240,126,51,30,74,222,87,188,160,50,142,190,68,143,191,60,125,137,94,147,199,87,79,56,69,160,253,39,45,142,199,151,160,159,223,122,74,137,84,103,4,109,77,50,153,13,212,99,119,141,24,30,216,3,25,14,39,180,76,225,64,185,216,121,10,203,69,123,16,159,173,102,167,9,141,37,128,224,84,5,178,206,115,227,36,182,38,222,59,153,252,100,206,200,203,151,222,163,58,209,237,17,117,250,13,182,113,36,194,171,106,60,68,155,213,128,169,130,109,179,201,21,61,201,132,44,80,159,88,109,143,119,92,62,183,165,216,140,29,41,110,186,190,50,245,233,3,129,110,35,0,59,177,14,181,111,63,38,178,117,213,77,199,39,139,161,71,232,32,193,17,143,207,35,95,159,123,207,149,30,156,255,56,81,56,111,61,136,59,234,181,58,44,179,185,240,28,241,25,222,194,172,84,233,231,118,222,243,170,240,193,205,193,255,242,194,251,111,158,120,163,228,143,123,224,16,198,22,81,31,112,86,188,228,61,239,14,149,174,201,170,66,85,177,118,5,205,21,42,30,143,27,150,250,117,179,16,215,64,125,21,246,216,172,105,46,160,133,106,187,97,49,200,33,172,43,172,75,42,108,37,120,95,127,92,235,12,235,230,232,182,232,127,121,29,26,74,92,107,243,95,31,221,29,111,113,94,214,5,112,245,253,224,116,239,217,53,83,13,48,120,185,54,253,207,125,92,107,157,43,148,136,199,125,83,180,221,243,183,112,231,95,88,147,160,170,47,23,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("36980980-5c31-4ced-b403-cc72d034ec69"));
		}

		#endregion

	}

	#endregion

}

