﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: BulkEmailEventLoggerSchema

	/// <exclude/>
	public class BulkEmailEventLoggerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public BulkEmailEventLoggerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public BulkEmailEventLoggerSchema(BulkEmailEventLoggerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("16372cd2-a230-4849-855b-d663231fa607");
			Name = "BulkEmailEventLogger";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("c3ce7540-fd5d-4b47-a634-a6e29aca9de2");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,237,88,91,111,234,70,16,126,230,72,231,63,108,221,62,24,9,12,33,36,58,185,113,20,140,57,138,148,84,81,195,81,31,218,42,218,152,1,220,216,107,180,187,38,65,17,255,189,179,187,190,97,28,78,82,169,82,111,121,32,236,122,46,223,206,55,179,51,134,209,8,196,146,250,64,38,192,57,21,241,76,58,110,204,102,193,60,225,84,6,49,251,248,225,229,227,135,70,34,2,54,39,119,107,33,33,58,203,215,110,204,97,123,229,140,134,184,129,91,223,115,152,163,54,113,67,42,196,41,25,38,225,163,23,209,32,244,86,192,228,117,60,159,3,215,114,157,78,135,156,139,36,138,40,95,15,210,245,45,143,87,193,20,4,137,64,46,226,169,32,50,38,97,60,39,74,95,57,90,242,216,7,33,156,76,189,83,210,95,38,15,97,224,19,95,185,125,197,107,67,29,40,7,56,14,32,156,34,194,91,30,172,168,4,13,170,177,52,11,194,129,78,99,22,174,201,87,1,28,195,194,192,87,49,33,247,201,214,250,172,86,231,75,18,76,201,61,70,53,230,63,129,72,66,73,46,8,131,39,189,111,91,158,59,186,28,125,26,123,237,227,113,183,223,238,31,185,94,251,228,96,124,216,238,157,28,184,238,81,127,244,169,235,142,172,230,62,203,1,155,197,53,134,143,189,94,215,115,187,110,251,228,216,61,105,247,251,195,126,251,114,56,58,106,247,70,135,151,151,199,135,71,151,189,227,87,13,7,76,146,251,136,62,95,3,155,203,5,6,236,231,0,25,72,228,45,229,154,226,11,210,239,226,223,30,101,145,60,8,201,81,214,152,64,141,158,81,208,49,7,54,53,97,79,215,89,146,196,12,149,18,95,198,92,49,161,41,76,137,48,116,214,17,105,87,56,217,166,164,73,52,203,141,10,83,136,167,134,186,205,126,120,55,38,13,95,201,145,85,140,100,92,49,9,156,209,16,161,217,154,157,135,12,241,213,180,69,70,40,55,9,34,32,66,82,46,213,170,69,76,148,8,168,3,253,136,69,216,34,222,179,15,75,13,18,178,111,45,162,15,209,72,133,177,84,5,157,195,4,162,101,168,141,104,87,165,12,75,119,212,17,149,223,37,229,52,18,36,126,248,29,15,251,203,111,102,13,136,84,100,225,145,124,157,126,107,172,40,207,28,96,148,140,71,103,28,243,136,74,123,199,113,201,210,89,161,30,48,116,156,101,227,149,94,216,21,2,154,14,134,42,182,173,29,70,173,166,177,211,112,238,64,218,150,10,137,213,194,204,8,147,136,57,183,153,59,59,143,87,115,91,254,46,139,108,157,82,30,246,138,210,176,32,169,78,173,196,97,69,209,68,187,94,171,68,71,69,107,4,194,231,129,38,182,78,49,13,114,51,139,104,48,35,118,158,9,228,59,140,106,18,134,25,113,121,78,228,18,35,144,8,85,96,244,191,128,244,42,187,133,161,204,122,195,144,149,33,83,82,48,53,176,107,79,85,49,152,163,220,20,96,77,218,41,164,42,11,29,47,90,202,117,129,183,236,207,197,75,67,194,116,184,174,15,161,49,180,227,194,24,240,158,193,79,36,216,233,211,13,241,169,244,23,196,46,149,79,238,244,198,116,140,175,18,255,201,0,132,131,137,230,120,138,160,52,177,173,66,235,105,129,17,32,79,28,5,49,172,216,111,28,114,35,230,68,166,57,127,74,94,186,27,4,139,201,95,169,134,12,136,254,44,93,39,217,5,145,18,85,199,74,77,201,103,216,95,167,215,154,172,151,6,206,175,236,198,64,57,125,57,192,133,75,195,16,83,221,127,60,125,233,109,44,131,74,149,37,102,255,188,228,28,77,228,86,177,26,25,240,226,209,231,207,197,179,146,1,116,136,90,21,59,14,158,72,65,177,155,206,24,51,83,21,101,161,82,220,36,85,173,20,114,33,234,35,236,59,5,187,70,88,239,79,56,206,39,133,188,26,5,170,23,84,53,76,45,141,57,167,170,85,56,105,110,25,202,251,167,187,0,255,241,58,96,96,250,150,141,207,82,73,14,50,225,172,16,62,123,157,226,170,145,116,91,217,74,89,13,102,202,178,147,54,199,193,190,102,155,39,177,57,239,15,214,139,210,188,203,250,171,221,109,237,116,219,230,134,156,115,136,226,21,96,3,90,19,115,219,12,72,69,177,4,160,93,99,194,42,167,115,113,248,247,53,202,82,11,175,78,120,122,3,79,139,99,221,2,76,243,202,104,114,114,249,78,85,225,92,119,28,194,48,201,46,172,210,197,108,13,38,104,69,109,16,80,59,4,7,71,38,131,89,0,220,57,239,104,165,122,27,121,79,176,6,234,147,80,54,37,82,245,232,167,5,48,66,205,180,176,160,130,60,0,174,181,52,76,247,155,204,123,147,53,80,159,36,158,153,35,170,237,253,154,149,27,197,28,42,43,161,236,6,218,111,194,220,153,214,64,77,69,111,14,66,209,198,141,203,98,189,165,151,78,97,122,210,65,230,244,5,186,59,230,212,77,57,53,99,206,222,89,38,157,92,76,226,127,123,124,41,143,93,91,19,87,9,66,201,181,106,160,59,215,119,107,107,70,111,109,15,79,165,17,103,243,238,116,38,79,88,208,197,125,74,166,230,110,250,207,102,121,30,9,115,156,162,9,253,251,107,227,47,126,5,120,251,192,255,206,138,41,193,120,99,217,148,74,247,189,197,163,94,104,85,55,87,231,143,232,255,29,225,159,147,245,87,200,220,159,78,250,191,97,67,40,126,90,249,102,63,168,204,66,102,183,188,137,175,4,155,63,0,105,63,87,137,102,19,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("16372cd2-a230-4849-855b-d663231fa607"));
		}

		#endregion

	}

	#endregion

}
