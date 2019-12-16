﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: AccountInfoSchema

	/// <exclude/>
	public class AccountInfoSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public AccountInfoSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public AccountInfoSchema(AccountInfoSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("664e29f1-8562-4e4b-9032-ee822c76c25c");
			Name = "AccountInfo";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("5f5fe385-d25b-4c17-9585-cfaff007abaf");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,87,91,111,218,48,20,126,110,165,254,7,139,190,108,210,4,239,3,85,66,108,218,216,212,10,169,221,250,80,245,193,36,39,96,53,216,153,47,32,84,237,191,239,216,185,144,43,36,89,158,136,237,243,29,127,231,110,56,221,129,138,168,7,228,9,164,164,74,4,122,188,16,60,96,27,35,169,102,130,143,23,95,31,239,133,15,161,186,185,126,191,185,190,50,138,241,13,121,128,131,22,220,73,255,80,130,79,111,174,241,232,86,194,6,17,100,17,82,165,62,147,185,231,9,195,245,146,7,194,29,79,38,19,50,83,102,183,163,242,120,151,172,157,40,9,132,36,12,197,228,206,93,73,232,90,24,77,104,140,39,74,83,109,20,161,220,39,76,43,162,64,238,153,7,106,156,170,156,228,116,70,102,29,50,143,120,78,109,129,192,213,187,35,145,145,92,73,17,129,212,12,144,233,202,161,226,243,50,75,183,241,13,240,98,36,169,236,175,222,2,153,175,150,228,13,142,227,12,49,41,67,102,123,26,26,200,150,79,181,160,147,76,66,92,105,105,221,59,143,216,79,56,146,119,178,1,61,181,183,78,201,223,46,244,56,70,149,136,192,125,39,110,236,70,245,188,130,70,218,177,228,131,5,247,230,126,128,53,217,10,241,70,104,20,161,238,56,35,124,177,163,140,119,179,161,157,162,38,91,158,97,253,29,193,243,40,250,226,32,253,13,162,88,87,71,235,204,124,230,182,55,163,6,85,225,252,24,203,188,188,166,95,170,63,93,137,253,0,75,27,146,186,107,79,118,36,222,70,132,5,168,224,143,1,133,117,107,60,15,192,159,18,129,106,229,129,161,202,17,246,24,33,71,151,189,255,24,215,252,255,27,225,97,235,234,230,239,18,162,194,144,97,75,90,160,204,0,228,176,245,42,186,233,200,175,10,106,114,226,125,44,217,159,40,154,10,155,120,12,116,206,134,167,75,248,10,235,37,79,133,227,232,219,190,141,155,186,184,91,103,205,45,112,63,110,235,110,29,239,150,54,75,195,169,238,178,86,83,202,119,157,4,189,155,140,37,172,235,156,153,151,135,82,253,197,195,77,39,74,156,99,243,76,15,91,176,21,152,13,212,45,77,196,152,79,168,193,35,174,211,246,216,105,166,205,188,59,45,13,204,38,222,157,173,123,189,101,170,229,29,185,158,240,201,170,9,104,168,156,158,218,252,120,177,79,140,196,35,199,15,35,166,126,91,181,115,212,138,67,114,244,241,53,151,67,107,33,66,178,44,8,244,75,255,51,110,108,180,115,144,201,117,217,169,151,111,27,194,189,229,249,215,236,231,54,147,178,71,133,38,147,172,215,211,49,153,153,150,130,13,93,252,120,60,117,160,243,21,154,93,60,236,147,49,255,164,74,248,245,127,147,85,21,52,78,210,88,178,255,155,236,82,37,48,142,142,229,232,108,151,168,154,237,219,155,117,85,151,236,105,236,50,117,221,178,185,152,160,115,167,161,255,4,44,39,82,215,167,91,5,85,243,116,75,82,52,251,232,77,214,32,219,158,76,155,160,21,186,191,80,48,99,90,88,12,85,245,177,186,22,101,31,73,240,33,96,28,252,211,95,197,156,5,151,138,60,189,103,216,42,7,236,128,33,82,19,123,230,163,75,109,205,118,139,68,19,180,177,95,167,128,98,131,78,170,127,149,106,27,38,58,249,128,183,136,80,37,171,206,199,164,168,125,216,184,164,211,82,17,35,195,126,255,35,203,208,198,136,32,192,201,215,70,228,57,57,236,25,17,220,251,7,116,246,176,126,179,17,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("664e29f1-8562-4e4b-9032-ee822c76c25c"));
		}

		#endregion

	}

	#endregion

}

