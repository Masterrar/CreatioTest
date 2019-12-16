﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: BulkDeduplicationSchedulerSchema

	/// <exclude/>
	public class BulkDeduplicationSchedulerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public BulkDeduplicationSchedulerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public BulkDeduplicationSchedulerSchema(BulkDeduplicationSchedulerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("81746d10-e0d6-4a26-8a1a-6730dd82ee81");
			Name = "BulkDeduplicationScheduler";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("4c53ad23-c903-414d-89cd-b08703861304");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,86,109,79,219,48,16,254,92,36,254,131,85,190,180,82,149,238,51,12,164,209,14,212,73,160,110,128,38,109,154,144,113,46,173,33,177,163,179,211,173,67,253,239,187,196,206,91,171,190,128,246,45,182,239,158,187,123,238,241,57,138,39,96,82,46,128,221,3,34,55,58,178,193,72,171,72,206,50,228,86,106,21,140,33,204,210,88,138,98,117,124,244,122,124,212,201,140,84,51,118,183,52,22,146,179,181,53,121,199,49,136,220,216,4,215,160,0,165,168,109,190,102,28,237,223,245,117,48,73,210,56,184,71,57,155,1,154,250,180,153,18,194,182,253,224,138,11,171,81,194,86,207,224,78,204,169,138,24,144,44,200,230,4,97,70,249,177,81,204,141,57,101,143,151,89,252,210,42,243,14,56,138,121,229,85,56,13,135,67,246,209,100,73,194,113,121,225,215,99,136,120,22,91,38,41,127,72,64,217,194,155,233,136,217,57,144,53,0,19,8,209,121,119,178,25,162,4,239,14,47,152,84,22,48,162,46,4,101,160,97,35,210,79,31,230,82,170,144,138,235,217,101,10,58,234,237,192,236,247,127,145,95,154,61,209,9,19,121,149,108,187,49,59,101,59,160,8,39,111,121,205,25,245,213,114,101,137,183,41,202,5,183,80,176,211,73,221,130,137,252,156,25,139,133,36,60,74,232,8,29,123,124,48,95,244,211,53,234,44,101,231,172,187,17,187,123,246,78,200,91,18,243,148,91,226,82,229,192,175,31,86,91,173,223,29,99,138,90,128,49,121,168,42,249,234,220,217,123,147,50,196,9,168,208,145,231,215,158,201,43,9,113,184,141,70,4,30,106,21,47,217,131,1,36,206,149,187,82,236,49,107,173,247,132,40,154,133,89,126,61,242,64,133,30,124,28,167,141,237,125,239,173,5,110,199,237,179,66,20,157,181,116,136,145,141,252,58,157,213,238,36,111,192,206,245,86,34,76,126,167,68,217,153,107,176,142,99,223,237,158,223,55,148,118,194,243,157,50,51,4,155,145,12,220,121,112,165,49,225,182,119,160,120,6,77,188,183,149,208,160,184,184,199,82,205,105,2,218,80,139,253,147,160,26,83,85,137,52,27,26,205,90,104,25,178,13,155,94,67,126,237,242,166,28,169,0,42,136,133,123,77,74,218,22,28,27,197,83,63,247,187,6,245,180,116,94,103,21,146,64,173,62,255,73,145,110,131,83,199,1,104,212,226,81,203,173,215,175,1,159,93,159,8,233,63,53,182,68,173,226,27,194,86,240,155,141,101,33,96,26,193,31,93,168,1,211,79,207,164,234,11,207,84,231,149,117,235,154,187,77,104,182,26,20,38,171,86,136,49,88,46,99,130,255,148,166,117,207,71,116,211,45,248,145,145,183,211,129,251,66,29,78,103,239,28,61,192,174,49,184,188,245,218,229,13,190,107,124,41,254,5,130,29,70,163,12,145,30,186,124,58,52,205,90,20,246,219,10,240,15,187,39,118,84,239,228,207,126,201,166,111,107,187,238,242,141,56,180,254,123,153,192,15,173,114,160,242,115,162,34,29,60,88,225,45,70,235,138,44,83,106,232,173,173,218,190,247,188,145,38,146,72,120,110,162,58,239,205,205,160,81,95,48,214,183,218,206,73,60,77,57,180,218,63,41,94,83,81,255,162,228,18,168,196,50,104,242,215,154,68,111,31,46,99,136,169,57,187,70,203,154,197,246,217,218,170,224,27,36,122,81,164,189,57,156,107,207,193,254,30,238,154,180,110,183,185,73,59,255,0,203,3,227,61,188,10,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("81746d10-e0d6-4a26-8a1a-6730dd82ee81"));
		}

		#endregion

	}

	#endregion

}
