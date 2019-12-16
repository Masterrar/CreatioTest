﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: DCTemplateServiceSchema

	/// <exclude/>
	public class DCTemplateServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public DCTemplateServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public DCTemplateServiceSchema(DCTemplateServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e9551305-a29e-4f49-b6a7-068d23b25927");
			Name = "DCTemplateService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("e81fdc99-2bd3-4785-b2cd-a2accfc6f9a3");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,205,87,77,111,219,56,16,61,187,64,255,195,172,123,145,129,128,190,55,182,129,36,238,238,102,129,52,129,147,96,15,193,30,104,105,20,115,43,81,42,73,217,53,178,254,239,59,164,68,73,145,63,154,164,155,102,47,182,53,156,121,51,243,248,56,162,37,79,81,231,60,68,184,65,165,184,206,98,195,206,50,25,139,251,66,113,35,50,201,166,107,201,83,17,146,209,160,52,239,223,61,188,127,215,43,180,144,247,112,189,214,6,211,227,206,51,187,70,181,20,33,94,100,17,38,7,23,217,73,104,196,210,101,57,236,247,39,206,27,135,167,213,201,166,220,112,251,91,241,208,60,59,216,165,213,187,194,168,20,10,77,83,87,50,173,127,80,120,79,0,112,150,112,173,63,194,244,236,6,211,60,225,6,171,6,156,211,112,56,132,145,46,210,148,171,245,164,122,174,214,33,203,145,106,64,13,43,97,22,16,149,117,128,169,80,52,131,43,84,113,166,82,13,103,179,219,105,229,78,25,53,243,192,195,22,242,93,5,235,59,255,203,218,78,116,254,25,13,85,157,83,228,92,36,194,172,103,248,181,16,10,83,106,86,7,237,7,219,57,140,225,59,33,214,139,85,134,104,96,147,228,197,60,161,186,67,75,195,54,11,240,17,78,185,110,56,233,61,56,94,106,246,46,208,44,178,136,248,187,114,48,229,98,151,181,146,54,190,36,174,60,61,32,36,76,79,89,237,61,236,186,143,114,174,120,10,68,42,142,251,62,170,63,25,105,68,8,21,198,227,126,83,171,231,172,63,156,16,174,54,92,82,225,102,193,13,132,180,194,201,212,228,141,144,12,137,102,163,161,75,208,228,83,104,10,37,117,59,195,35,165,85,20,204,232,208,209,30,162,205,149,205,255,198,208,148,251,223,244,253,164,112,118,93,132,33,106,109,97,114,101,181,97,214,96,84,129,176,90,160,4,77,100,193,138,107,208,165,27,123,46,126,183,188,151,212,229,83,214,245,197,60,209,110,231,50,179,64,181,18,228,62,26,122,222,172,247,221,165,23,121,91,198,189,59,58,123,231,114,153,125,193,160,212,11,233,180,127,117,121,125,211,63,130,91,37,252,54,90,171,85,9,89,173,66,81,155,95,233,248,208,46,142,129,0,46,168,42,126,143,165,137,253,161,51,121,100,177,123,190,242,195,190,78,234,94,235,135,8,112,58,13,182,181,85,43,104,0,15,46,239,146,43,80,62,104,12,18,87,7,113,131,193,177,11,51,106,93,1,56,4,143,58,195,60,211,194,100,180,90,98,53,21,52,75,163,198,232,230,220,36,184,213,168,40,171,164,125,166,148,85,138,170,52,31,53,67,30,93,230,110,242,212,216,179,93,171,93,248,163,210,145,24,227,101,58,95,120,175,41,173,13,221,46,217,219,217,167,111,97,82,68,120,98,140,18,243,130,230,98,5,209,251,231,160,127,149,247,119,147,38,245,251,203,70,109,90,45,226,55,65,111,156,168,37,159,109,54,153,133,62,165,46,195,76,69,231,81,224,61,152,183,28,237,102,202,83,41,98,8,186,121,126,33,22,139,36,25,212,116,212,160,231,86,217,29,119,50,86,88,27,64,119,126,8,178,21,193,62,125,45,232,92,5,191,21,130,126,167,185,89,15,246,33,59,151,207,184,178,223,94,79,189,77,249,181,163,117,167,228,160,179,169,131,90,199,101,252,6,66,110,194,5,4,68,60,186,222,161,150,120,207,235,155,53,139,212,95,21,232,62,203,211,95,31,4,183,180,57,240,22,176,20,183,166,113,172,178,244,5,239,129,243,168,63,185,149,130,102,4,136,136,180,33,98,129,10,178,152,134,62,13,126,44,41,123,202,132,223,62,231,251,6,40,79,18,154,124,177,155,40,150,7,62,207,138,102,40,252,231,115,208,242,244,234,115,112,127,247,110,159,156,36,161,225,252,192,228,219,143,244,179,231,158,105,59,238,31,9,65,171,173,227,142,216,183,70,255,24,118,188,16,6,143,50,189,201,97,154,98,130,6,95,249,56,173,56,141,223,232,89,167,234,237,238,77,238,163,166,131,203,200,157,219,68,200,47,212,130,79,101,59,52,194,94,220,81,161,191,97,197,52,209,215,116,59,180,140,70,236,5,215,44,143,238,186,250,145,110,126,194,45,171,20,206,219,222,179,202,26,158,49,99,254,47,183,43,213,217,188,221,67,166,106,111,107,204,188,222,136,248,128,50,42,255,149,185,231,210,250,216,184,249,23,49,40,171,60,53,16,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e9551305-a29e-4f49-b6a7-068d23b25927"));
		}

		#endregion

	}

	#endregion

}
