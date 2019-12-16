﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: DeduplicationSearchQueryBuilderSchema

	/// <exclude/>
	public class DeduplicationSearchQueryBuilderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public DeduplicationSearchQueryBuilderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public DeduplicationSearchQueryBuilderSchema(DeduplicationSearchQueryBuilderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("2feccb84-df80-4ade-9331-c969bd3ac170");
			Name = "DeduplicationSearchQueryBuilder";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("4c53ad23-c903-414d-89cd-b08703861304");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,86,93,79,219,48,20,125,14,18,255,193,128,132,138,84,185,123,6,154,105,80,58,33,1,221,104,181,61,155,228,150,90,74,156,98,59,157,58,232,127,159,63,83,55,73,155,77,218,83,27,251,220,227,227,251,105,70,114,16,75,146,0,154,1,231,68,20,115,137,111,11,54,167,175,37,39,146,22,12,143,32,45,151,25,77,204,215,241,209,251,241,81,84,10,202,94,209,116,45,36,228,10,157,101,144,232,77,129,191,2,3,78,147,171,58,230,129,178,55,181,168,150,207,56,188,42,40,186,205,136,16,151,104,135,124,10,132,39,139,239,37,240,245,77,73,179,20,184,49,25,12,6,232,90,148,121,78,248,58,118,223,22,138,222,52,22,189,88,48,154,23,28,165,33,33,226,160,16,66,98,207,50,8,104,150,229,139,194,161,68,11,233,210,129,46,209,125,167,212,232,221,200,173,174,248,8,114,81,164,234,146,223,56,93,17,9,118,119,105,63,80,192,48,166,153,84,103,24,162,198,114,111,228,78,5,241,92,102,224,176,105,203,98,95,211,71,209,3,21,242,122,107,164,194,83,230,108,68,36,137,81,94,164,144,93,160,119,3,92,17,142,68,178,128,156,88,136,64,67,11,192,63,23,192,161,151,152,85,52,140,145,253,135,167,6,252,164,18,6,13,135,173,10,2,200,197,149,57,164,77,135,61,197,126,91,20,157,163,158,144,92,37,12,190,23,79,101,150,77,248,93,190,148,235,94,235,33,179,245,18,46,252,45,162,128,76,93,96,231,66,120,76,185,144,19,62,130,57,41,51,217,188,145,197,29,188,209,22,98,143,139,206,207,81,171,84,71,105,197,217,107,109,16,100,2,254,135,80,205,186,87,162,57,210,157,88,185,51,56,237,51,254,65,178,210,216,51,37,24,125,124,132,17,176,155,117,5,43,107,17,159,180,222,213,236,170,16,56,198,42,22,28,100,201,153,89,107,243,128,223,134,95,45,217,239,48,81,152,101,93,73,230,50,62,10,227,216,21,70,111,99,93,186,223,163,30,231,124,215,226,50,91,38,222,83,232,160,171,240,172,208,117,217,187,176,172,155,32,92,155,189,125,65,43,106,116,5,189,88,235,9,163,217,4,113,245,219,71,93,181,223,119,185,235,210,207,20,170,243,188,78,26,77,130,53,227,77,145,174,255,34,186,85,31,225,149,13,218,225,232,40,111,111,134,159,139,66,6,189,67,167,232,158,61,173,170,41,222,54,179,154,231,134,245,76,51,171,62,207,108,168,133,67,25,199,53,146,50,174,197,43,82,19,6,72,178,232,249,59,43,152,74,93,202,182,106,29,109,37,172,174,204,101,251,112,95,183,175,88,251,174,91,187,147,173,19,27,60,39,181,24,69,81,205,11,94,16,254,146,166,77,251,138,125,183,80,91,98,237,163,237,127,28,160,118,90,152,23,117,10,151,231,103,192,82,59,32,247,77,75,51,151,237,166,25,218,148,169,66,163,50,45,212,176,230,48,31,158,118,141,98,92,247,237,233,32,54,37,102,39,126,176,209,136,66,207,72,191,191,99,101,14,156,188,100,112,221,40,181,216,4,91,216,254,48,166,44,13,16,246,185,129,230,59,171,19,54,37,43,112,123,225,244,53,1,86,169,112,0,142,31,53,230,170,54,176,93,167,59,100,183,173,152,192,120,55,88,194,85,171,192,83,208,47,56,147,123,186,147,181,182,28,219,96,124,23,217,86,160,171,16,215,13,27,53,24,55,202,210,167,172,179,243,141,49,104,21,53,153,170,121,151,76,234,194,255,212,213,139,218,39,140,55,26,243,34,239,112,155,134,184,206,63,165,191,59,157,172,32,14,237,29,90,23,239,182,183,79,172,67,124,14,229,5,252,123,172,157,165,122,112,234,87,174,165,243,3,236,16,67,211,192,58,245,64,225,218,213,221,197,205,31,205,78,93,174,78,12,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("2feccb84-df80-4ade-9331-c969bd3ac170"));
		}

		#endregion

	}

	#endregion

}

