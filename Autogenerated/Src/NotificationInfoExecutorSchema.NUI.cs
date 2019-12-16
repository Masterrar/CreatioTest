﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: NotificationInfoExecutorSchema

	/// <exclude/>
	public class NotificationInfoExecutorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public NotificationInfoExecutorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public NotificationInfoExecutorSchema(NotificationInfoExecutorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("75553c3e-2c66-4f32-9b0d-d8ebb10d1706");
			Name = "NotificationInfoExecutor";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,205,87,223,111,219,56,12,126,206,128,253,15,106,14,24,28,32,112,222,147,52,64,215,203,178,224,186,46,232,165,195,246,20,40,14,147,232,230,72,134,36,95,23,108,253,223,143,146,252,67,182,227,52,61,220,195,61,20,181,77,82,252,72,126,164,24,78,15,160,18,26,1,89,130,148,84,137,173,14,111,5,223,178,93,42,169,102,130,191,125,243,243,237,155,78,170,24,223,145,63,143,74,195,97,84,123,71,253,56,134,200,40,171,112,6,28,36,139,74,29,255,216,195,65,240,211,18,9,248,29,37,191,73,216,225,57,228,54,166,74,13,201,189,208,108,203,34,11,100,206,183,98,250,3,162,84,11,105,117,7,131,1,25,171,244,112,160,242,56,201,222,173,29,217,10,73,184,103,74,192,218,225,83,152,219,13,60,195,36,93,199,44,34,145,181,109,115,73,134,100,222,14,167,99,146,212,49,127,69,4,152,13,77,185,198,40,22,146,253,77,53,228,26,137,123,37,145,209,32,74,75,147,140,233,215,233,237,227,114,186,90,126,91,76,87,55,119,119,228,154,116,111,226,184,59,186,204,226,253,183,213,253,205,167,169,177,90,31,239,177,166,175,48,156,61,124,126,92,56,203,153,20,105,226,76,109,44,192,55,46,156,122,116,31,24,196,27,63,52,223,155,4,186,17,60,62,146,249,239,204,210,2,243,60,118,206,251,68,172,255,66,174,76,200,42,161,18,113,106,144,106,116,210,248,81,129,196,36,114,199,44,178,74,43,239,142,46,21,132,141,236,203,52,194,226,24,148,182,192,25,72,87,236,182,82,6,53,183,85,175,253,42,7,30,32,17,138,161,213,17,97,231,143,125,114,199,148,30,55,200,242,145,242,77,12,114,66,246,238,65,245,12,156,206,144,232,61,83,65,221,143,127,94,110,208,39,60,141,227,30,177,92,123,254,191,133,211,63,91,238,178,218,25,254,206,90,136,152,48,181,40,4,95,104,204,54,200,195,219,61,68,223,203,207,129,103,106,153,210,97,91,18,148,0,201,245,181,205,11,249,245,171,192,146,127,203,125,117,244,94,138,39,194,225,137,220,200,93,122,0,174,239,81,252,89,78,15,137,62,78,127,68,144,24,224,65,230,224,185,112,115,213,0,120,226,200,63,224,136,217,249,32,82,190,105,57,170,70,94,12,178,193,102,163,229,7,229,149,32,147,150,193,21,113,102,146,50,67,40,171,245,213,243,249,70,89,72,145,128,212,12,108,51,11,141,120,96,211,210,206,47,16,97,85,65,149,228,135,189,100,246,49,15,203,229,117,7,154,252,68,159,58,149,220,59,146,60,251,164,111,12,154,22,26,175,106,73,44,65,181,89,120,143,167,240,120,231,85,16,181,165,247,19,232,189,104,29,148,182,5,234,116,127,93,23,101,192,124,6,148,237,224,181,78,136,36,85,230,102,215,148,113,21,116,245,49,129,110,143,188,123,71,206,235,20,192,186,189,222,232,68,9,178,59,101,6,218,141,28,88,162,81,144,163,115,184,179,235,215,138,144,160,245,171,174,108,106,159,200,87,181,14,246,100,225,82,30,209,33,182,99,10,89,36,152,162,180,226,167,210,126,89,146,2,7,182,231,169,93,28,82,145,135,51,177,21,58,24,164,59,36,180,243,229,63,8,176,44,67,35,210,66,116,97,200,133,126,30,123,117,43,153,79,57,206,71,73,215,49,52,155,118,98,178,82,255,168,138,148,100,153,211,174,206,117,78,140,234,58,126,190,90,179,237,172,94,64,197,235,144,136,75,110,230,242,137,233,104,79,2,227,179,72,119,68,21,52,168,56,116,178,206,169,243,202,201,128,75,174,198,221,44,199,134,87,25,14,162,239,163,182,115,179,221,236,242,179,223,219,13,46,208,39,138,123,129,47,187,206,189,198,153,93,250,46,240,182,129,45,77,99,61,108,138,42,148,107,184,188,228,26,42,231,164,183,170,213,23,124,251,33,99,137,170,248,9,11,245,65,93,127,236,96,169,201,131,251,95,254,22,192,30,165,58,85,225,120,144,171,120,11,149,29,205,153,175,130,223,255,130,133,167,251,165,156,8,77,155,108,46,152,209,124,213,144,134,115,101,71,74,208,43,136,236,131,154,165,108,51,177,187,133,241,93,119,252,168,89,204,204,85,111,234,110,22,67,133,107,212,182,9,187,95,95,182,115,58,224,239,42,160,166,147,218,110,243,124,49,33,140,23,247,122,1,180,147,9,67,39,49,102,205,240,251,14,125,238,209,49,43,167,22,110,244,112,130,113,91,26,43,56,195,50,247,181,250,17,191,253,3,209,118,130,106,251,14,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("75553c3e-2c66-4f32-9b0d-d8ebb10d1706"));
		}

		#endregion

	}

	#endregion

}
