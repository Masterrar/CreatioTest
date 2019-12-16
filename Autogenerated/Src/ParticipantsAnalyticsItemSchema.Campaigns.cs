namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ParticipantsAnalyticsItemSchema

	/// <exclude/>
	public class ParticipantsAnalyticsItemSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ParticipantsAnalyticsItemSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ParticipantsAnalyticsItemSchema(ParticipantsAnalyticsItemSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f63154a0-be3b-4482-959d-f99cde09a649");
			Name = "ParticipantsAnalyticsItem";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6c038aa0-46cd-4697-bc93-5c682e364aef");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,197,84,77,111,219,48,12,61,167,64,255,3,145,94,182,139,125,239,199,128,194,29,134,30,90,4,203,110,195,14,138,76,123,4,108,73,35,37,20,105,209,255,62,202,94,10,247,35,70,114,218,197,198,163,159,30,223,35,97,57,211,163,4,99,17,126,32,179,17,223,196,162,242,174,161,54,177,137,228,221,233,201,211,233,201,34,9,185,22,214,91,137,216,95,188,193,197,247,228,34,245,88,172,145,201,116,244,56,156,83,150,242,206,24,91,5,80,117,70,228,28,86,134,35,89,10,198,69,185,118,166,219,42,146,91,213,24,200,101,89,194,165,164,190,55,188,253,242,15,223,160,88,166,13,10,184,212,171,190,53,29,144,171,245,29,61,11,52,158,21,170,0,60,80,252,173,167,17,193,50,54,87,203,172,122,91,47,203,157,208,101,57,81,254,121,99,162,209,152,145,141,141,191,180,16,210,166,35,11,54,219,156,115,185,120,26,156,190,228,90,177,15,168,108,204,225,6,141,241,251,219,40,67,161,50,125,48,212,58,160,108,152,106,212,177,53,132,92,188,156,152,122,28,77,222,97,191,65,254,116,175,107,130,43,88,210,152,234,115,246,188,51,253,45,81,13,99,92,200,187,90,44,90,140,23,32,250,200,232,121,198,209,52,41,88,175,123,124,55,199,157,233,9,181,88,71,12,149,239,67,135,17,243,136,129,4,240,79,210,213,68,78,120,68,28,187,19,153,26,169,178,143,215,17,117,197,80,237,229,254,247,212,141,233,228,152,216,206,187,253,105,222,39,191,159,163,207,132,255,168,181,254,228,158,15,232,249,245,67,222,145,205,2,123,139,146,175,138,3,58,174,246,147,143,108,43,73,2,186,250,160,217,174,247,114,103,154,158,233,137,241,2,24,240,88,125,93,124,254,11,20,230,182,165,89,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f63154a0-be3b-4482-959d-f99cde09a649"));
		}

		#endregion

	}

	#endregion

}

