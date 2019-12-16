namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ParticipantsAnalyticsResponseSchema

	/// <exclude/>
	public class ParticipantsAnalyticsResponseSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ParticipantsAnalyticsResponseSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ParticipantsAnalyticsResponseSchema(ParticipantsAnalyticsResponseSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f53c9ec6-85b8-4636-8f98-86f86c8b298c");
			Name = "ParticipantsAnalyticsResponse";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6c038aa0-46cd-4697-bc93-5c682e364aef");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,146,79,75,3,49,16,197,207,45,244,59,12,237,197,94,118,239,106,11,82,165,20,84,196,122,19,15,179,217,217,117,32,201,174,249,163,84,241,187,155,236,118,151,182,86,197,75,224,37,47,51,191,121,137,70,69,182,70,65,240,64,198,160,173,10,151,44,42,93,112,233,13,58,174,244,104,248,49,26,14,188,101,93,194,122,99,29,169,179,3,29,252,82,146,136,102,155,44,73,147,97,241,205,115,239,181,99,69,201,58,156,162,228,247,166,118,112,5,223,196,80,25,4,44,36,90,123,10,119,104,28,11,174,81,59,123,161,81,110,130,178,247,1,50,148,167,230,66,154,166,112,110,189,82,104,54,243,173,238,12,80,84,6,122,15,17,8,67,197,108,188,64,85,35,151,58,180,127,101,65,201,161,94,146,59,218,247,228,7,154,23,79,214,77,199,233,60,217,246,10,153,57,100,109,129,117,32,80,205,120,128,89,229,29,212,59,37,0,165,172,68,123,202,26,8,197,51,136,45,11,112,12,170,99,79,119,6,124,188,68,135,177,131,65,225,158,194,70,237,51,201,2,68,76,236,175,192,6,31,77,104,125,204,119,166,170,41,220,160,152,117,83,167,61,63,76,181,29,171,103,203,41,60,96,193,100,146,222,188,139,216,50,222,144,202,200,156,220,134,79,5,51,24,119,147,173,242,241,52,98,119,220,75,207,121,95,122,149,67,252,97,131,65,73,238,12,108,88,162,250,252,5,234,154,173,131,170,216,15,206,194,219,51,199,52,187,135,216,141,253,31,204,216,37,184,138,69,247,185,87,87,218,43,50,152,73,58,63,154,122,188,51,135,61,105,127,153,110,66,58,111,95,165,209,237,238,254,230,231,23,1,230,49,195,161,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f53c9ec6-85b8-4636-8f98-86f86c8b298c"));
		}

		#endregion

	}

	#endregion

}

