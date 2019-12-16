﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SequenseNumberGeneratorSchema

	/// <exclude/>
	public class SequenseNumberGeneratorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SequenseNumberGeneratorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SequenseNumberGeneratorSchema(SequenseNumberGeneratorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("ad263e4f-8a6d-459c-bd3e-01d2b6f5abec");
			Name = "SequenseNumberGenerator";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("677baab4-893e-4898-b508-38190fd135a7");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,85,93,107,219,48,20,125,118,97,255,65,56,47,14,20,101,123,93,218,194,218,134,82,88,63,104,178,237,161,148,162,216,183,137,153,45,123,210,85,218,48,242,223,39,75,178,45,167,246,218,45,4,226,43,223,143,115,206,189,55,226,44,7,89,178,24,200,2,132,96,178,120,66,122,86,240,167,116,165,4,195,180,224,31,14,126,127,56,8,148,76,249,138,204,183,18,33,159,54,182,31,34,96,232,156,158,159,14,190,154,113,76,49,5,169,29,180,203,72,192,74,151,36,103,25,147,242,51,153,195,47,5,92,194,181,202,151,32,46,128,131,134,84,8,227,58,153,76,200,145,84,121,206,196,246,196,217,163,234,67,204,215,62,185,135,250,211,154,180,206,48,241,82,220,223,44,101,145,1,194,131,54,74,181,204,210,152,196,21,146,97,32,65,165,77,11,187,224,18,25,71,13,253,86,164,27,134,96,160,190,194,218,130,245,65,145,30,156,30,1,210,34,127,13,61,40,109,61,18,87,16,136,68,97,218,213,129,125,43,138,24,18,37,224,90,183,156,28,147,16,101,249,232,184,64,215,53,180,237,8,70,192,19,203,205,217,62,81,161,98,173,65,197,213,72,101,61,156,108,3,130,69,99,98,4,219,189,203,217,204,198,118,30,175,33,103,4,60,227,144,124,147,32,52,8,14,113,53,162,68,117,76,87,36,232,196,31,119,50,76,141,195,94,150,227,189,60,83,15,234,144,18,90,212,18,68,53,193,85,207,11,212,145,144,188,163,235,61,13,30,110,173,75,187,207,122,207,180,164,87,128,150,156,116,15,255,66,192,107,228,48,122,242,6,92,219,212,142,248,29,227,255,112,94,1,174,139,228,221,32,123,182,232,13,220,230,68,0,42,193,229,201,64,232,136,30,77,106,23,143,171,91,183,122,151,236,28,215,179,30,108,152,32,220,28,233,9,179,174,116,150,151,184,157,54,175,203,122,53,181,7,135,103,50,215,227,15,73,179,176,81,183,211,135,127,91,236,113,155,53,97,200,190,179,76,193,98,91,194,21,227,108,101,32,68,231,61,231,227,110,9,250,165,44,221,27,157,125,147,38,32,232,5,160,59,138,194,190,20,161,43,221,144,161,63,82,92,223,50,161,81,33,116,215,153,122,80,187,254,55,10,75,133,109,84,40,64,170,12,31,55,85,181,240,176,151,84,5,237,210,252,245,198,112,186,173,82,71,225,2,94,48,28,187,18,246,234,137,140,40,203,217,11,196,74,11,172,165,216,35,61,227,82,195,56,63,109,143,162,113,221,197,160,13,164,115,100,2,23,130,113,201,172,151,189,23,105,165,10,189,212,119,136,185,56,191,194,6,50,122,7,44,57,43,242,60,69,189,193,14,78,128,98,91,167,245,232,219,252,16,181,149,106,255,32,125,34,81,235,216,168,35,245,37,170,56,146,19,242,177,193,25,4,205,176,69,118,218,198,125,145,247,159,30,168,209,177,46,177,179,191,59,18,51,140,215,77,54,143,246,93,145,101,75,22,255,244,153,55,8,113,45,138,103,103,236,94,41,102,21,232,9,180,174,118,167,220,150,12,253,27,184,51,255,104,247,7,62,143,9,46,190,8,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ad263e4f-8a6d-459c-bd3e-01d2b6f5abec"));
		}

		#endregion

	}

	#endregion

}
