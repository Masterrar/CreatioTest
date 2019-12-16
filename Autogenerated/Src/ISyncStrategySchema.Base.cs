﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ISyncStrategySchema

	/// <exclude/>
	public class ISyncStrategySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ISyncStrategySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ISyncStrategySchema(ISyncStrategySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("b771ff15-a14f-4f39-be65-1b31aa728594");
			Name = "ISyncStrategy";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("e0bd8020-de17-4815-83cd-c2dac7bbc324");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,213,85,177,110,219,48,16,157,109,32,255,112,112,150,20,8,164,165,83,226,24,104,61,4,30,20,184,117,243,1,180,116,150,136,82,164,192,163,146,168,69,254,189,71,81,182,24,39,241,208,161,65,23,65,58,242,222,189,123,239,68,106,81,35,53,34,71,248,129,214,10,50,59,151,100,66,170,179,233,239,179,233,164,37,169,75,216,116,228,176,190,62,250,78,110,149,217,10,37,127,9,39,141,30,87,125,246,87,196,100,85,139,198,191,191,94,201,100,141,99,116,172,187,52,122,39,203,214,246,128,125,62,239,226,125,231,22,75,142,192,74,59,180,59,230,122,5,171,77,167,243,141,227,173,88,118,253,166,52,77,97,78,109,93,11,219,45,134,239,181,53,15,178,64,130,26,93,101,10,130,157,177,160,141,3,226,108,44,56,76,36,74,94,39,20,54,175,146,33,237,158,120,77,106,134,67,132,220,226,238,102,230,201,44,149,68,237,102,233,2,114,37,136,46,65,16,8,221,245,96,149,53,122,80,2,104,160,5,91,65,8,174,107,112,15,124,103,28,7,42,225,224,177,66,13,178,110,20,214,140,233,101,232,76,107,193,60,70,233,28,129,186,37,7,248,212,160,46,98,58,113,247,35,161,161,138,171,36,49,253,65,171,177,74,96,39,123,21,182,178,40,80,239,121,205,211,72,184,166,221,42,153,71,0,71,90,79,252,96,28,60,201,130,178,87,176,238,211,122,43,94,121,209,7,190,163,107,173,166,184,141,227,81,73,178,96,200,74,23,248,180,52,74,97,238,57,251,14,189,115,123,187,46,193,34,25,245,192,46,177,5,145,159,251,82,236,93,222,90,203,61,115,158,42,208,38,7,86,233,49,173,121,35,172,168,65,243,127,112,51,203,131,197,139,83,28,253,139,103,36,53,57,193,101,147,121,218,67,140,136,54,116,122,8,220,189,49,113,127,165,66,212,70,92,227,237,253,112,139,238,94,135,186,25,149,253,42,210,133,175,2,161,207,79,215,31,106,87,228,86,48,129,139,12,62,4,215,214,194,85,1,236,223,123,24,35,70,108,22,189,124,33,0,187,86,41,104,56,252,255,142,192,165,63,110,252,241,51,246,120,114,42,50,97,127,210,190,5,111,231,120,248,97,241,113,14,85,40,152,253,105,68,255,24,100,122,23,248,193,200,2,54,232,134,125,155,168,185,151,170,69,96,16,138,123,217,38,147,119,133,91,90,228,243,115,127,211,248,35,157,127,10,234,15,100,190,216,178,47,235,207,160,132,46,91,6,60,37,227,241,92,109,142,225,222,153,143,193,229,195,60,240,52,132,212,111,45,218,238,98,36,127,206,55,77,56,218,249,235,57,92,191,81,232,108,250,252,7,250,163,244,96,50,8,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b771ff15-a14f-4f39-be65-1b31aa728594"));
		}

		#endregion

	}

	#endregion

}
