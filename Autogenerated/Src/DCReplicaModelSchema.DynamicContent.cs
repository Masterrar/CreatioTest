﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: DCReplicaModelSchema

	/// <exclude/>
	public class DCReplicaModelSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public DCReplicaModelSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public DCReplicaModelSchema(DCReplicaModelSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("eb4f0b98-3e23-4d31-a310-9250a56f1ae8");
			Name = "DCReplicaModel";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("748ec229-6875-456a-9dfd-63087e63e63a");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,84,77,111,218,64,16,61,19,41,255,97,74,14,1,169,178,123,14,49,85,11,82,133,212,180,81,75,79,85,14,203,238,24,111,99,239,58,187,235,16,132,242,223,187,31,182,193,36,165,110,47,152,157,143,55,111,118,223,140,32,5,234,146,80,132,37,42,69,180,76,77,52,147,34,229,235,74,17,195,165,136,230,91,65,10,78,173,209,160,48,209,141,100,152,235,243,179,221,249,217,160,210,92,172,225,251,86,27,44,38,71,231,232,51,23,15,123,99,79,244,57,49,196,253,87,132,26,155,108,211,47,20,174,109,32,204,114,162,245,21,204,103,223,176,204,57,37,158,135,143,136,227,24,174,117,85,20,68,109,167,245,217,71,131,145,160,176,84,168,45,52,48,11,13,133,203,130,84,42,155,129,8,84,97,154,12,91,204,97,60,5,27,202,205,54,106,112,227,3,224,178,90,217,40,160,30,251,152,200,96,231,201,180,124,111,149,44,81,25,142,150,244,173,79,12,254,99,182,222,240,67,240,135,10,129,51,87,61,229,168,162,54,244,144,64,195,224,83,197,25,44,24,236,96,141,102,2,218,253,60,67,226,237,209,23,220,184,239,104,60,57,81,176,230,126,169,129,146,210,63,196,201,130,218,40,247,136,179,16,219,173,251,47,109,129,76,193,106,163,204,137,193,131,155,254,75,167,243,217,178,206,57,238,185,71,109,193,240,9,10,162,239,97,195,77,198,5,152,12,247,28,136,134,21,55,27,174,17,44,128,163,183,202,37,189,15,105,168,189,82,104,165,148,19,144,10,119,118,154,48,183,129,55,174,90,95,158,181,242,59,149,90,122,189,74,54,143,83,3,245,45,252,193,14,228,182,237,88,95,182,61,155,140,24,32,202,221,29,205,43,134,236,191,110,225,231,29,124,116,192,139,26,245,88,171,2,55,62,236,221,93,173,211,11,20,44,204,78,119,144,110,208,100,146,245,153,162,175,143,118,201,88,177,105,192,39,71,146,27,160,82,60,186,41,180,247,99,151,193,107,51,223,108,27,55,251,102,91,98,116,240,48,46,85,131,168,242,220,101,187,239,31,218,246,150,146,40,82,128,93,103,152,12,253,158,25,78,235,26,245,218,145,171,95,72,13,108,50,78,179,134,25,178,232,58,246,153,221,39,181,219,145,238,219,112,171,132,24,251,10,47,104,143,186,123,40,84,26,67,226,209,6,161,238,155,196,115,247,150,193,123,127,243,47,112,96,23,220,3,59,98,73,64,137,22,236,109,109,244,138,110,204,238,208,56,26,209,53,190,250,220,186,235,133,209,186,195,185,113,119,4,210,196,28,26,163,165,244,50,29,141,67,198,115,248,92,249,126,94,215,77,144,124,215,104,109,191,1,193,216,165,123,232,6,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("eb4f0b98-3e23-4d31-a310-9250a56f1ae8"));
		}

		#endregion

	}

	#endregion

}
