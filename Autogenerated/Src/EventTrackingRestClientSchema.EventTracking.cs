﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: EventTrackingRestClientSchema

	/// <exclude/>
	public class EventTrackingRestClientSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public EventTrackingRestClientSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public EventTrackingRestClientSchema(EventTrackingRestClientSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("3f46f735-4ebf-4f4f-b80f-090ff41632ea");
			Name = "EventTrackingRestClient";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("9af1fba8-e20e-442c-aa2d-7a413d186e60");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,189,85,81,111,218,48,16,126,166,82,255,195,73,123,216,203,6,234,43,101,149,24,170,42,70,167,50,168,182,103,19,31,200,34,177,51,159,195,20,77,253,239,59,219,33,163,140,132,168,72,123,137,108,231,243,125,223,221,103,251,180,200,144,114,145,32,60,163,181,130,204,218,245,39,70,175,213,166,176,194,41,163,175,175,126,95,95,245,10,82,122,3,203,146,28,102,183,71,115,198,167,41,38,30,76,253,7,212,104,85,194,24,70,189,179,184,225,85,184,215,69,54,132,251,29,106,247,108,69,178,253,106,36,6,192,96,48,128,17,21,89,38,108,121,87,205,3,12,156,199,65,198,192,254,30,55,56,0,230,197,42,85,9,32,7,62,138,11,94,110,111,42,225,19,220,124,240,195,73,42,136,194,232,203,183,2,109,185,68,47,214,88,94,121,137,42,81,203,40,180,73,244,76,105,121,70,239,150,33,221,148,250,96,81,228,147,158,240,175,109,173,244,73,207,197,6,31,141,144,221,180,113,186,106,173,146,96,211,56,113,123,208,41,145,241,55,160,23,112,86,230,191,113,163,222,177,252,91,213,5,102,102,135,60,253,120,115,78,108,48,96,8,51,109,126,233,37,18,241,218,2,127,22,72,174,81,110,216,2,107,99,193,70,36,172,140,44,193,172,97,137,238,48,16,16,218,157,74,90,15,73,18,130,157,160,135,33,124,22,132,11,30,178,17,92,153,145,210,206,111,12,217,30,235,170,132,169,224,54,150,253,26,115,72,185,231,36,103,253,5,25,231,106,134,101,172,94,111,131,238,54,12,168,26,196,170,157,38,122,68,33,223,19,167,23,211,84,178,149,238,161,80,18,170,228,166,178,133,175,147,83,92,227,120,167,202,28,47,114,170,142,210,221,166,19,220,109,54,249,180,246,234,231,214,228,104,157,66,78,97,30,98,182,212,247,255,25,169,56,3,46,135,226,151,146,192,25,160,82,39,237,156,126,203,168,174,194,148,55,222,65,61,13,241,90,12,238,133,146,188,246,183,139,233,175,248,26,237,254,129,43,32,78,37,190,36,33,169,243,158,30,133,190,200,55,47,128,31,240,140,35,82,108,18,222,30,37,121,94,191,89,117,219,104,46,241,81,207,168,71,173,151,167,81,212,119,145,22,232,77,166,170,183,116,58,83,83,25,247,189,129,48,244,16,230,139,239,57,156,79,53,108,240,159,183,37,88,117,129,154,177,149,240,68,251,56,236,34,151,29,219,151,63,138,201,177,28,177,8,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("3f46f735-4ebf-4f4f-b80f-090ff41632ea"));
		}

		#endregion

	}

	#endregion

}

