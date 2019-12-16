﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CustomLicPackageServiceSchema

	/// <exclude/>
	public class CustomLicPackageServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CustomLicPackageServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CustomLicPackageServiceSchema(CustomLicPackageServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f4d0167a-6273-4b82-88d0-ed371683beb1");
			Name = "CustomLicPackageService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("9f41bd41-a240-4f13-b0e5-89611787d84b");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,213,87,223,111,211,48,16,126,238,164,253,15,102,188,164,82,149,242,76,217,164,49,180,1,218,160,90,59,144,152,120,240,156,107,103,45,177,131,237,20,10,218,255,206,157,147,180,105,226,150,109,15,72,147,90,85,190,220,143,47,223,125,103,187,138,103,96,115,46,128,77,193,24,110,245,204,197,39,90,205,228,188,48,220,73,173,246,247,254,236,239,245,10,43,213,156,77,150,214,65,54,106,173,209,63,77,65,144,179,141,207,64,129,145,162,227,51,1,179,144,2,46,116,2,233,206,135,241,87,184,217,237,112,140,165,22,30,219,218,175,9,62,203,182,61,49,16,178,99,193,117,20,62,127,105,96,142,201,217,73,202,173,125,205,176,92,193,83,249,27,18,228,37,145,37,39,232,54,28,14,217,27,91,100,25,55,203,163,106,237,67,152,208,202,113,169,44,147,106,166,77,230,161,50,126,163,11,199,56,97,135,210,67,184,184,78,51,108,228,201,139,155,84,10,38,124,170,96,241,30,117,164,71,223,26,234,216,232,28,140,147,128,120,199,62,222,67,236,96,244,134,51,112,150,105,195,44,253,186,91,96,10,53,192,244,140,97,24,40,1,241,42,178,9,171,198,101,157,33,250,198,92,220,241,57,124,162,208,63,108,14,110,68,249,70,236,254,49,133,133,46,148,163,202,93,90,182,3,144,24,178,34,227,196,103,120,50,128,132,59,24,58,89,190,126,145,211,242,65,111,191,170,255,14,35,66,229,95,130,74,202,222,248,117,105,109,26,125,255,90,74,59,41,172,211,217,185,20,21,185,149,234,47,113,64,113,180,0,3,240,115,93,89,17,130,51,72,214,119,178,29,219,252,19,56,20,113,142,98,187,145,169,116,203,75,248,81,72,3,25,40,103,163,230,130,134,136,29,178,127,132,144,87,92,25,146,254,247,182,46,183,64,101,175,217,91,110,235,85,72,169,8,219,58,142,5,80,168,134,198,24,106,143,188,92,146,8,172,91,17,93,24,131,112,54,251,61,230,134,103,248,10,7,193,167,7,163,71,101,164,14,110,77,72,15,215,249,58,253,91,189,213,5,184,91,157,180,134,239,250,51,206,36,47,113,173,123,213,187,198,253,230,131,90,232,59,136,202,48,42,60,254,60,153,30,12,216,91,157,44,39,110,153,82,131,208,237,2,172,69,114,87,214,248,171,225,121,14,201,128,242,80,115,192,186,83,191,195,108,248,151,166,248,163,213,106,192,106,245,236,246,243,29,110,78,24,142,74,155,140,137,224,41,55,152,175,72,93,84,177,153,175,183,129,62,243,205,238,201,25,139,174,44,24,140,83,229,169,192,14,15,153,42,210,180,246,232,25,112,133,81,236,149,103,150,134,99,109,219,140,140,81,97,239,33,69,30,241,96,113,107,185,181,161,85,160,154,104,124,238,251,186,81,207,182,23,231,210,186,55,129,83,224,136,58,116,193,127,109,106,63,242,238,101,111,142,154,205,177,53,247,11,110,152,241,108,97,121,5,63,183,23,136,74,10,31,209,207,50,111,179,169,120,252,1,23,183,1,181,160,200,130,248,122,36,190,172,253,94,136,245,97,194,232,50,210,209,68,201,129,168,189,42,26,2,12,212,136,122,205,179,238,176,137,122,80,57,116,192,118,94,160,116,188,31,213,124,17,81,241,113,146,68,43,28,253,192,48,52,8,189,127,230,123,202,78,29,159,115,235,2,207,170,169,254,63,154,126,209,210,244,19,164,235,181,43,66,103,210,131,245,251,144,141,141,85,213,232,112,154,210,221,165,93,210,95,74,158,90,145,130,67,67,179,46,183,224,105,65,249,105,241,77,43,248,128,183,92,250,207,176,192,27,40,217,78,141,206,174,156,136,66,176,226,169,190,82,120,213,51,150,167,228,27,245,7,109,156,21,32,178,198,117,137,21,136,199,142,238,191,103,183,59,188,193,14,118,221,43,150,107,90,240,151,127,33,102,166,203,28,232,15,139,244,152,34,207,214,96,147,44,100,167,95,229,171,183,132,93,123,66,181,41,236,216,26,2,247,147,192,149,115,127,15,141,127,1,6,3,180,136,241,13,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f4d0167a-6273-4b82-88d0-ed371683beb1"));
		}

		#endregion

	}

	#endregion

}
