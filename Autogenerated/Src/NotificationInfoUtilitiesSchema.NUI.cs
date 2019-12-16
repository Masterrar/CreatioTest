﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: NotificationInfoUtilitiesSchema

	/// <exclude/>
	public class NotificationInfoUtilitiesSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public NotificationInfoUtilitiesSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public NotificationInfoUtilitiesSchema(NotificationInfoUtilitiesSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("603be24c-8285-4e4a-bdc2-24b982c331fe");
			Name = "NotificationInfoUtilities";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,205,88,75,111,219,56,16,62,59,64,255,3,225,189,72,128,33,223,55,142,129,52,237,6,94,52,65,183,73,218,51,99,209,54,23,18,229,144,84,3,163,200,127,223,33,169,7,73,81,178,236,45,186,155,75,44,206,112,248,205,123,72,134,115,34,246,120,77,208,35,225,28,139,98,35,147,155,130,109,232,182,228,88,210,130,189,187,248,241,238,98,242,27,39,91,248,64,55,25,22,226,119,116,95,72,186,161,107,205,176,98,155,226,73,210,140,74,74,196,187,11,96,46,5,101,91,244,112,16,146,228,151,222,55,8,207,50,178,86,27,69,114,75,24,225,116,221,225,249,68,217,75,187,120,79,94,37,112,43,100,127,138,130,181,4,27,113,158,247,81,56,233,91,79,62,50,169,81,95,106,216,243,249,28,45,68,153,231,152,31,150,213,183,214,23,21,27,84,214,26,162,77,193,17,179,244,71,20,12,192,115,108,84,170,229,204,45,65,251,242,57,163,107,36,36,240,172,209,90,139,28,176,224,228,135,134,227,218,156,128,213,63,115,250,29,75,98,168,123,243,81,137,3,195,93,167,57,101,79,140,202,21,251,82,100,68,241,40,207,77,234,227,111,75,154,58,124,200,144,39,91,34,47,205,47,81,255,122,235,108,188,229,69,185,63,182,227,173,2,78,88,106,176,187,138,220,17,185,43,210,62,69,42,243,172,62,178,50,39,28,63,103,100,209,213,106,137,110,137,180,151,197,138,105,104,145,189,79,33,94,34,97,239,78,197,12,61,9,194,33,182,153,9,63,84,58,159,113,165,220,119,204,17,17,47,232,10,49,242,138,116,132,28,30,214,59,146,227,191,74,194,15,145,187,43,177,25,238,48,195,91,194,103,104,10,8,213,97,6,243,52,54,38,2,169,201,117,154,66,2,148,57,139,106,158,126,170,189,119,213,1,242,7,205,36,156,0,233,130,54,250,39,32,86,50,110,56,1,107,26,234,55,42,119,159,49,135,20,135,15,17,153,69,200,149,61,230,20,50,233,241,176,135,28,120,41,113,54,51,222,108,78,157,249,198,75,30,136,202,218,8,163,171,37,138,138,231,191,225,35,198,177,133,221,8,23,74,135,200,0,170,136,6,121,155,246,136,19,81,102,178,130,11,238,244,25,60,19,183,22,24,140,11,7,176,137,9,116,101,212,50,7,214,42,152,181,9,209,167,130,58,213,247,68,185,187,43,184,14,121,248,115,114,7,208,107,1,74,1,101,199,202,113,95,113,86,86,241,215,120,120,149,78,227,89,35,165,66,54,110,187,66,160,182,215,187,223,42,99,112,34,75,206,66,58,95,90,121,56,144,89,43,191,254,44,161,204,20,140,248,203,209,25,102,159,29,59,201,174,158,162,206,187,110,254,110,149,48,1,166,10,156,81,59,147,170,248,135,144,84,255,19,77,137,147,15,84,72,202,128,24,136,156,16,26,242,106,47,170,3,29,128,70,8,148,120,130,215,59,20,233,106,168,161,65,225,175,48,214,58,4,148,176,177,247,232,82,57,55,249,182,35,156,4,52,50,41,42,34,125,86,92,199,66,208,2,182,135,42,237,39,1,253,194,174,222,26,231,57,136,103,29,243,196,118,135,168,226,208,231,25,25,132,198,66,80,48,30,186,70,57,41,240,68,48,242,130,93,160,63,220,134,60,37,134,194,46,96,244,80,126,66,17,133,162,6,22,138,28,201,157,120,29,221,68,117,119,54,68,127,116,209,11,95,52,8,129,214,109,233,133,65,134,166,48,194,240,34,119,106,93,210,8,153,251,82,22,123,213,64,16,131,38,114,53,117,18,99,186,188,113,36,247,15,69,139,185,22,210,202,52,246,17,158,128,48,180,197,188,230,214,225,228,204,82,93,47,250,227,65,116,78,45,170,195,218,166,213,174,119,180,188,114,5,184,161,208,227,216,83,124,101,27,209,100,173,232,154,89,79,164,186,56,57,29,74,91,82,231,244,88,239,106,230,233,114,149,170,179,29,89,70,76,199,141,246,102,39,168,253,208,232,243,236,128,188,193,80,59,39,186,134,194,115,92,132,141,110,154,109,143,56,86,145,196,191,111,150,199,246,188,63,120,131,11,164,136,191,197,229,169,59,1,11,212,253,159,219,76,59,18,124,47,13,169,18,236,186,1,76,205,188,233,24,222,107,163,194,177,145,86,164,115,71,139,226,118,26,124,95,164,7,79,185,68,173,53,131,158,61,176,223,67,68,251,204,62,189,217,168,27,77,104,71,67,104,88,87,57,220,55,32,93,61,198,106,185,97,251,84,224,148,240,144,200,150,210,48,63,82,153,117,248,244,162,167,90,247,220,122,189,97,188,35,66,4,17,54,132,134,213,139,81,219,29,21,203,219,192,64,227,47,213,157,214,184,254,212,145,229,204,10,141,158,15,103,53,213,95,90,57,221,158,246,95,150,206,227,101,72,151,81,219,58,231,21,203,96,55,55,195,246,232,102,94,207,224,54,154,248,236,182,30,242,41,194,44,69,121,145,210,205,193,99,31,124,108,250,169,83,91,32,32,108,57,238,189,124,186,84,151,91,192,218,188,133,252,218,49,79,157,46,32,195,55,39,5,197,200,87,160,163,247,8,211,71,221,81,243,88,191,28,123,141,9,200,174,111,69,157,55,173,224,91,9,221,160,40,36,56,185,102,135,40,110,186,88,87,165,158,187,88,248,174,229,223,172,234,242,60,234,178,25,22,25,178,160,83,182,189,51,71,39,96,74,181,125,128,132,94,169,220,185,7,65,12,151,76,170,242,125,210,184,252,127,172,219,31,78,209,115,40,229,90,65,11,33,57,101,219,25,148,30,169,19,239,70,73,113,29,218,189,178,143,45,206,234,185,181,25,208,212,208,213,115,112,232,49,199,208,173,135,162,211,47,108,205,76,213,125,54,106,134,84,115,76,239,155,15,160,51,134,109,179,151,121,179,8,16,71,194,240,222,122,46,157,7,76,245,180,90,141,230,246,129,161,60,49,59,6,222,19,204,170,187,8,107,255,0,237,170,160,14,15,26,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("603be24c-8285-4e4a-bdc2-24b982c331fe"));
		}

		#endregion

	}

	#endregion

}

