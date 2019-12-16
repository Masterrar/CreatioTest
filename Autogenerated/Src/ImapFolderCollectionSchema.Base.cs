﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ImapFolderCollectionSchema

	/// <exclude/>
	public class ImapFolderCollectionSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ImapFolderCollectionSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ImapFolderCollectionSchema(ImapFolderCollectionSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("5d9d9b0d-434f-493e-9546-69953ec7a88d");
			Name = "ImapFolderCollection";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("1b48d10c-73f9-465d-8c06-a582b79b2f43");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,84,77,111,219,48,12,61,187,64,255,3,145,93,92,20,176,119,94,18,3,107,145,22,3,210,109,88,59,236,48,12,131,226,208,169,80,89,246,36,57,91,80,244,191,151,150,252,21,229,163,91,177,139,19,137,228,35,249,248,40,201,114,212,37,75,17,238,80,41,166,139,204,68,151,133,204,248,170,82,204,240,66,70,31,114,86,158,158,60,158,158,4,149,230,114,5,183,27,109,48,31,123,103,10,18,2,211,58,66,31,179,69,215,40,81,241,116,199,103,206,229,175,254,242,134,113,113,129,104,147,215,255,201,66,182,55,10,87,4,2,151,130,105,253,14,106,227,85,33,150,168,250,4,214,47,142,99,152,232,42,207,153,218,36,205,217,198,128,185,103,6,80,166,172,212,149,96,6,53,249,33,66,170,48,155,142,252,164,145,15,62,138,19,224,82,27,38,83,140,218,60,177,151,104,162,144,142,15,186,61,127,99,186,198,167,100,75,10,134,66,17,36,152,2,114,246,128,182,133,175,134,11,110,56,234,91,84,107,78,147,224,121,41,48,71,105,236,0,40,104,137,37,210,71,26,200,84,145,3,254,49,168,36,19,32,248,66,81,230,190,148,65,234,178,90,8,158,66,106,219,222,199,20,241,55,147,85,142,138,45,4,78,122,143,4,30,45,137,29,219,87,28,197,146,232,254,172,248,154,186,112,70,202,55,100,216,81,220,97,67,145,81,23,172,132,204,66,234,168,13,25,146,21,148,14,240,96,29,63,121,119,208,227,166,38,226,193,149,181,93,35,73,86,27,85,165,166,80,117,165,174,119,231,210,16,177,143,130,208,191,104,235,237,111,206,106,54,130,32,24,214,2,83,184,70,211,28,194,221,144,90,198,193,83,253,121,41,255,161,206,27,204,3,201,91,82,63,213,82,186,216,132,25,76,41,36,250,136,218,208,238,204,113,141,162,171,225,24,105,55,104,238,139,125,147,133,221,209,90,1,147,144,183,70,60,216,157,190,250,122,73,172,76,39,37,83,44,39,43,72,122,100,166,163,166,108,178,71,93,158,216,79,228,130,188,136,228,213,75,58,137,45,94,15,175,208,84,74,234,164,175,119,208,83,189,64,206,252,55,242,28,104,224,144,142,218,1,206,185,54,91,177,10,233,253,49,52,75,137,191,193,183,134,110,122,65,86,40,8,215,76,1,39,199,183,99,250,153,116,179,191,44,42,105,232,234,252,188,205,17,56,204,232,253,114,25,214,168,61,96,43,209,239,252,199,89,3,109,213,25,184,110,155,98,254,163,156,172,226,91,253,239,213,211,23,199,51,48,185,95,68,9,152,77,73,15,38,58,234,105,173,143,105,166,157,218,157,23,51,212,193,214,100,155,149,156,117,158,254,96,123,75,216,242,219,144,53,220,197,200,243,220,94,252,87,54,254,111,45,207,94,108,118,208,229,80,202,126,237,219,93,30,104,204,31,127,115,55,188,122,122,6,122,145,110,71,82,8,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5d9d9b0d-434f-493e-9546-69953ec7a88d"));
		}

		#endregion

	}

	#endregion

}

