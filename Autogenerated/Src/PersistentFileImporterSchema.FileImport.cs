﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: PersistentFileImporterSchema

	/// <exclude/>
	public class PersistentFileImporterSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public PersistentFileImporterSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public PersistentFileImporterSchema(PersistentFileImporterSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("ebe6b7f5-a56a-4b4c-b200-113925999bd8");
			Name = "PersistentFileImporter";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,86,73,143,219,54,20,62,43,64,254,3,235,94,40,96,32,231,210,203,204,216,131,137,50,19,232,208,118,80,79,122,104,16,4,140,244,108,19,149,72,129,164,60,157,6,254,239,125,164,22,203,212,82,3,237,197,203,227,219,190,183,124,164,96,5,232,146,165,64,158,65,41,166,229,214,68,177,20,91,190,171,20,51,92,138,232,145,231,144,20,165,84,230,237,155,239,111,223,4,149,230,98,71,54,175,218,64,113,211,253,239,91,43,152,146,159,187,158,212,122,100,169,145,138,131,70,13,212,89,46,151,228,150,139,61,40,110,50,153,146,84,193,118,181,120,207,52,156,114,3,181,88,174,81,247,243,7,216,178,42,55,239,185,200,208,51,53,175,37,200,45,77,124,237,240,138,252,130,208,201,138,8,252,66,141,39,80,154,35,38,97,206,212,194,47,232,180,172,190,229,28,227,230,76,107,50,174,72,174,137,31,2,13,109,189,130,31,21,236,16,45,121,228,144,103,250,154,60,41,126,96,6,28,180,32,169,181,159,152,194,52,208,72,255,6,165,212,28,225,191,146,175,124,242,204,150,46,40,107,71,196,3,183,49,108,7,228,107,90,41,133,73,246,100,231,70,189,131,186,222,93,192,190,204,117,192,161,0,145,213,64,154,255,13,170,39,37,75,80,6,155,229,33,243,2,141,34,156,57,90,173,231,240,147,187,59,27,35,160,115,58,43,18,219,142,53,72,162,143,96,110,103,146,89,83,1,47,4,7,84,27,85,89,139,123,181,171,10,172,32,93,84,26,20,30,8,72,237,216,46,174,200,167,51,65,24,134,55,163,152,207,138,59,34,90,173,29,136,96,164,238,8,144,208,49,249,52,168,190,218,154,118,57,77,53,174,135,20,59,231,38,188,86,112,235,166,171,162,96,232,167,21,196,10,16,152,38,28,141,152,64,186,144,91,98,119,11,53,1,154,141,28,223,140,5,89,174,163,206,239,210,119,124,91,218,94,184,45,92,249,133,94,219,58,147,180,19,68,183,75,167,237,140,155,165,28,15,74,207,59,68,206,29,135,117,217,175,201,55,92,28,234,157,145,239,228,56,95,185,159,193,236,229,96,147,219,222,31,36,207,200,7,200,113,188,252,97,163,31,43,60,107,154,10,90,163,179,36,195,128,46,157,233,201,140,106,111,212,55,116,251,124,28,137,190,97,7,136,235,245,119,67,65,125,223,164,236,126,182,225,79,146,168,79,35,171,49,34,137,220,103,146,221,252,91,226,159,202,140,153,62,45,209,97,152,22,206,213,92,164,121,172,167,216,207,50,102,233,254,34,192,78,113,131,105,194,231,233,164,162,103,185,49,202,94,36,225,23,172,197,73,177,159,207,5,115,34,13,78,23,100,189,5,187,240,62,67,176,141,45,145,7,188,37,121,134,236,18,203,188,42,132,190,223,237,48,18,179,84,149,177,210,94,66,245,150,14,142,105,216,81,141,229,184,211,202,76,57,242,214,167,165,146,255,154,184,107,88,173,118,73,135,70,230,1,123,48,36,187,168,134,61,63,102,86,236,19,247,21,105,10,128,13,74,177,229,82,213,115,22,188,236,17,15,165,227,9,140,72,239,162,198,131,31,61,12,201,15,248,196,168,242,188,5,21,240,237,0,123,111,99,144,207,19,125,54,132,177,165,219,28,178,153,213,9,59,231,193,4,241,204,216,222,52,150,102,175,228,11,177,243,241,43,94,232,238,129,214,134,126,248,43,133,210,10,104,171,125,36,144,107,232,162,14,8,167,87,129,214,194,125,213,159,227,59,235,219,28,255,247,161,75,4,106,10,150,207,242,176,189,19,34,79,127,148,121,131,3,83,189,169,197,201,176,205,243,43,63,110,58,201,182,222,51,78,63,136,170,192,225,2,52,240,159,120,3,79,241,190,18,127,110,248,223,214,15,190,207,55,96,12,50,151,182,51,245,59,203,43,160,254,244,47,78,30,31,132,225,230,213,245,209,122,209,177,172,132,193,151,206,79,239,222,53,41,163,71,107,159,136,173,36,205,6,184,235,121,229,45,85,20,159,14,7,41,222,87,72,137,234,153,23,240,135,20,54,207,158,167,168,21,79,88,37,153,167,143,49,13,50,192,5,247,208,125,150,13,71,178,33,162,137,177,243,72,29,165,199,127,0,216,18,132,215,44,13,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ebe6b7f5-a56a-4b4c-b200-113925999bd8"));
		}

		#endregion

	}

	#endregion

}
