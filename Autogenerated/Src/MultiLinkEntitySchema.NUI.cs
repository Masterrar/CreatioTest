﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: MultiLinkEntitySchema

	/// <exclude/>
	public class MultiLinkEntitySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public MultiLinkEntitySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public MultiLinkEntitySchema(MultiLinkEntitySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("87281908-2453-4343-ace2-d8a6318c8221");
			Name = "MultiLinkEntity";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,86,219,78,227,48,16,125,46,18,255,48,130,151,32,85,201,59,45,145,118,41,139,42,113,19,133,125,69,38,153,180,222,77,236,96,59,101,43,196,191,239,36,113,154,52,151,46,90,144,242,98,123,46,103,206,28,123,34,88,130,58,101,1,194,3,42,197,180,140,140,123,46,69,196,151,153,98,134,75,113,120,240,118,120,48,202,52,23,75,88,108,180,193,100,210,90,147,125,28,99,144,27,107,247,18,5,42,30,212,54,205,176,73,34,69,255,137,194,161,125,247,66,24,110,56,106,50,32,147,99,133,75,74,4,231,49,211,250,20,174,179,216,240,43,46,126,23,86,155,194,196,243,60,152,234,44,73,152,218,248,118,189,48,84,13,46,55,32,35,72,114,159,52,70,136,201,47,79,168,48,144,42,212,110,229,235,53,156,211,236,57,230,1,4,121,186,118,54,56,133,121,177,117,155,98,73,86,149,134,28,223,10,44,91,188,63,56,198,33,1,190,83,124,77,38,229,97,90,46,8,0,11,165,136,55,240,168,81,17,251,162,100,19,158,178,157,245,164,215,103,198,139,67,194,59,213,70,81,61,99,144,207,191,200,195,135,39,109,241,220,49,69,125,54,168,44,139,219,40,165,7,60,229,84,96,88,150,117,67,166,147,97,35,234,118,150,136,65,163,160,255,248,50,227,97,21,225,190,224,123,30,90,44,199,40,194,146,165,93,202,168,112,10,154,5,70,170,156,184,162,17,22,125,217,148,86,59,156,22,123,187,228,141,247,17,213,229,233,4,114,217,143,70,173,22,192,25,244,244,100,212,67,52,89,246,178,63,26,189,239,47,251,26,205,74,150,82,145,134,146,96,88,181,204,46,97,205,149,201,88,12,107,73,156,222,41,76,153,194,58,135,179,167,206,180,91,95,187,243,132,187,182,162,235,108,126,178,56,67,27,201,119,142,174,90,246,71,99,219,122,247,34,73,205,230,100,210,12,91,107,229,99,97,107,251,129,176,193,135,3,254,43,84,46,72,247,65,229,205,209,232,124,0,91,165,218,118,56,98,55,51,109,105,219,36,60,2,167,195,176,59,215,55,89,28,223,170,194,223,57,169,90,49,50,43,37,95,65,224,43,124,83,203,44,65,97,10,139,139,63,1,166,121,71,123,200,183,121,222,219,217,234,234,63,157,173,65,228,80,182,170,106,202,245,191,89,182,236,118,115,4,95,81,203,64,21,246,46,182,71,70,177,97,47,185,6,180,19,8,158,55,48,45,148,162,48,2,65,177,206,142,236,236,32,224,158,239,110,67,121,237,88,165,91,199,199,127,20,252,37,67,224,97,158,35,226,185,254,166,94,97,235,239,185,243,22,153,115,197,181,153,230,66,246,97,27,179,226,164,20,201,34,88,97,194,202,10,170,197,89,123,174,184,77,219,107,38,216,18,85,126,13,230,244,254,50,17,224,247,66,107,93,33,91,34,35,154,210,44,88,129,83,188,241,202,54,18,184,232,130,178,168,44,30,66,210,4,230,158,83,28,131,246,49,111,97,180,185,70,165,131,187,64,51,195,168,108,106,113,91,181,211,181,104,28,119,239,197,120,224,202,14,249,7,13,79,53,224,194,214,232,172,89,204,67,42,227,30,95,50,174,48,60,133,136,197,26,123,68,183,59,0,250,71,64,99,232,245,106,116,38,65,86,63,31,64,95,91,158,88,63,21,158,255,37,226,109,68,244,139,119,152,254,168,108,253,77,229,126,70,244,229,116,223,81,252,76,110,255,177,28,251,167,81,3,25,195,190,139,208,29,144,61,211,218,182,167,186,88,117,144,61,19,187,220,221,221,124,255,11,29,249,143,103,80,11,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("87281908-2453-4343-ace2-d8a6318c8221"));
		}

		#endregion

	}

	#endregion

}

