﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CaseTermStrategyByServiceInServicePactSchema

	/// <exclude/>
	public class CaseTermStrategyByServiceInServicePactSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CaseTermStrategyByServiceInServicePactSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CaseTermStrategyByServiceInServicePactSchema(CaseTermStrategyByServiceInServicePactSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("71ebe1a4-e2ab-467c-9422-fde6ea4bd7f3");
			Name = "CaseTermStrategyByServiceInServicePact";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("5be0374d-f3b5-4c63-b887-7fd46e962c93");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,181,86,75,111,219,56,16,62,171,64,255,195,64,185,200,128,33,239,57,117,84,164,110,18,248,208,34,91,187,237,161,232,129,145,70,54,119,37,202,37,41,23,218,34,255,189,195,135,100,90,118,187,198,2,139,0,129,72,206,124,243,205,219,130,213,168,118,44,71,88,163,148,76,53,165,78,23,141,40,249,166,149,76,243,70,188,124,241,227,229,139,168,85,92,108,96,213,41,141,245,171,209,153,228,171,10,115,35,172,210,7,20,40,121,126,144,9,97,235,186,17,231,95,36,254,234,62,189,19,154,107,142,138,4,204,95,116,37,113,67,166,96,81,49,165,224,26,22,76,33,169,212,43,77,132,113,211,189,233,86,40,247,60,199,165,240,31,143,44,215,86,117,54,155,193,92,181,117,205,100,151,249,243,45,40,175,8,122,203,52,20,168,9,140,11,84,160,121,141,96,78,10,158,58,216,73,222,72,174,59,96,162,0,229,144,211,30,116,22,160,238,218,167,138,231,144,91,126,151,177,35,55,222,144,224,88,152,192,76,240,15,46,83,132,181,108,115,221,72,227,249,163,53,100,61,59,113,205,94,44,5,69,142,85,252,31,114,134,129,192,239,192,9,128,9,202,118,83,146,187,72,42,136,144,75,44,111,226,203,152,198,179,204,121,150,14,86,103,99,179,243,29,147,172,6,65,165,117,19,183,20,42,226,45,92,129,196,217,199,163,115,58,159,89,225,243,186,76,110,84,156,173,137,39,125,181,53,10,173,142,20,124,164,47,99,158,28,91,134,99,98,83,120,203,237,7,57,50,167,32,83,33,78,161,121,250,139,94,51,99,93,77,140,193,232,26,158,200,88,50,214,181,2,96,115,21,217,122,237,86,249,22,107,246,158,220,128,27,136,207,70,210,84,124,244,236,210,119,133,162,112,73,246,103,159,241,119,168,183,77,97,147,45,27,77,230,176,248,77,190,31,80,43,155,214,156,85,4,200,36,240,130,130,198,75,142,242,119,249,146,168,91,41,84,182,56,85,131,82,54,53,40,219,232,84,245,90,83,96,76,18,122,21,155,134,158,26,52,123,234,93,82,134,135,150,23,134,78,143,184,44,146,62,62,123,194,207,135,107,138,78,129,37,107,43,157,24,157,137,13,74,196,75,72,214,146,210,56,0,220,19,141,48,153,84,178,1,202,164,7,143,28,175,224,201,1,62,219,255,254,145,120,185,110,11,160,59,181,242,206,37,147,48,49,103,227,124,207,43,26,11,10,202,70,66,152,238,63,91,148,221,133,125,129,234,91,156,145,23,40,209,244,163,110,122,164,1,104,104,214,227,154,63,13,246,190,161,96,223,238,118,85,231,137,217,232,156,16,3,50,217,199,137,62,83,47,156,222,22,69,98,206,11,137,212,62,238,246,51,215,219,71,99,19,45,158,187,164,1,78,60,184,106,196,186,219,209,96,254,214,178,106,122,40,110,170,144,120,234,178,96,194,219,119,227,91,166,153,121,75,3,57,147,177,87,255,23,17,219,92,23,16,49,114,3,145,203,251,240,223,134,238,7,215,25,110,123,112,65,116,247,172,178,165,162,183,92,13,219,230,210,249,89,51,245,119,156,221,87,108,163,224,251,150,231,91,194,44,120,78,24,254,72,232,173,153,239,146,166,100,69,145,43,58,40,57,45,228,226,116,182,246,77,187,14,169,141,155,217,205,212,161,184,250,225,186,236,61,161,238,9,207,201,97,250,18,39,5,134,111,216,234,18,21,53,55,181,185,89,63,99,48,223,107,86,144,50,239,165,78,42,119,52,186,211,80,224,29,19,108,131,114,10,227,185,235,161,141,175,244,3,165,173,133,201,191,205,138,59,42,178,70,21,119,120,119,109,99,154,196,105,186,45,48,140,18,39,228,39,186,41,83,82,118,119,73,220,143,146,116,89,196,147,212,200,56,136,147,166,60,160,59,186,135,159,78,128,227,11,103,133,194,61,22,29,133,35,152,153,99,140,116,169,222,55,250,174,222,233,46,57,204,72,27,109,43,105,108,140,84,190,252,241,213,225,69,118,134,31,77,106,39,107,40,153,190,243,222,127,50,245,55,55,194,89,114,26,171,9,220,140,38,60,188,118,240,209,120,61,92,255,39,124,79,214,120,31,114,29,25,29,124,239,119,128,43,75,175,252,220,239,14,95,170,143,18,169,115,240,131,61,251,160,78,109,101,79,195,2,154,134,27,232,204,158,9,108,156,25,47,254,238,120,226,60,255,4,13,9,197,239,144,11,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("71ebe1a4-e2ab-467c-9422-fde6ea4bd7f3"));
		}

		#endregion

	}

	#endregion

}
