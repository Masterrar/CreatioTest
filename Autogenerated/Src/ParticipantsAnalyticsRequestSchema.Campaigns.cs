namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ParticipantsAnalyticsRequestSchema

	/// <exclude/>
	public class ParticipantsAnalyticsRequestSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ParticipantsAnalyticsRequestSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ParticipantsAnalyticsRequestSchema(ParticipantsAnalyticsRequestSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("2ebfd074-f11c-4f75-a663-f6dad21baf80");
			Name = "ParticipantsAnalyticsRequest";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6c038aa0-46cd-4697-bc93-5c682e364aef");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,84,77,111,219,48,12,61,167,64,255,3,145,94,218,139,125,95,63,128,34,69,139,30,54,20,77,119,26,118,96,36,218,33,32,203,158,68,111,200,138,254,247,81,118,156,212,233,144,194,23,195,148,30,201,247,158,73,123,172,40,54,104,8,94,40,4,140,117,33,217,162,246,5,151,109,64,225,218,159,158,188,158,158,204,218,200,190,132,229,38,10,85,151,7,113,246,220,122,225,138,178,37,5,70,199,127,187,60,69,41,238,44,80,169,1,44,28,198,248,5,158,48,8,27,110,208,75,188,245,232,54,26,197,103,250,213,82,148,14,159,231,57,92,197,182,170,48,108,110,182,241,246,30,26,12,74,86,40,64,81,135,29,150,8,76,160,226,122,190,192,170,65,46,189,178,248,205,134,178,195,248,129,228,191,237,207,143,145,186,152,231,55,217,182,151,218,34,200,62,238,137,196,196,4,12,58,211,58,20,138,250,218,247,76,144,93,77,192,161,232,80,233,42,127,39,241,199,29,10,166,218,1,141,252,212,131,166,93,57,54,96,146,101,159,56,54,123,237,92,219,217,252,20,234,134,52,129,146,215,93,153,254,254,208,214,94,207,64,150,45,233,7,44,184,119,22,254,172,217,172,199,10,60,145,141,123,161,99,69,31,37,245,154,190,82,181,162,112,254,77,189,130,107,152,15,222,60,218,249,69,146,57,232,124,104,217,238,184,60,90,72,227,54,155,149,36,151,16,245,145,162,183,35,42,150,162,68,161,96,151,6,195,226,102,2,163,62,169,43,160,183,52,166,149,78,94,116,170,225,126,140,154,202,239,174,165,61,59,161,201,244,52,255,83,114,91,204,84,106,247,14,75,144,53,10,176,183,108,186,9,110,35,189,95,170,3,241,186,13,250,237,237,71,196,192,82,239,199,27,49,244,138,130,162,127,11,29,153,110,198,100,77,58,103,181,35,208,121,229,218,78,176,69,25,38,233,125,223,56,246,101,85,215,14,190,143,0,71,76,57,35,111,251,197,233,226,254,116,124,248,246,15,143,186,174,227,32,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("2ebfd074-f11c-4f75-a663-f6dad21baf80"));
		}

		#endregion

	}

	#endregion

}

