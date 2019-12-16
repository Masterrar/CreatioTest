﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: EmailTemplateCommLangHandlerSchema

	/// <exclude/>
	public class EmailTemplateCommLangHandlerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public EmailTemplateCommLangHandlerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public EmailTemplateCommLangHandlerSchema(EmailTemplateCommLangHandlerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("1e74a254-fcca-4fb6-be7b-59789815c512");
			Name = "EmailTemplateCommLangHandler";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("91d5b8ed-2389-4812-9e17-f329888285e6");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,205,86,223,79,219,48,16,126,46,18,255,195,145,73,40,149,88,242,62,154,72,163,43,172,18,176,73,133,189,187,201,181,245,150,216,145,237,192,58,196,255,190,115,156,144,38,180,165,15,104,218,75,211,216,231,239,190,251,238,135,35,88,142,186,96,9,194,29,42,197,180,92,152,96,44,197,130,47,75,197,12,151,2,142,143,158,142,143,6,165,230,98,9,179,181,54,152,159,191,188,111,158,81,184,107,61,152,8,195,13,71,77,6,100,242,65,225,210,2,143,51,166,245,39,152,228,140,103,119,152,23,25,51,56,150,121,126,205,196,242,43,19,105,134,170,178,15,195,16,70,186,204,115,166,214,113,253,254,89,0,155,107,163,88,98,0,63,90,4,48,53,4,36,132,81,10,158,56,250,25,161,149,108,137,160,48,65,254,128,42,104,32,195,13,204,162,156,103,60,105,49,19,203,109,47,53,232,49,191,174,253,212,219,163,171,146,167,103,96,127,45,254,83,21,73,27,186,20,228,168,76,140,84,164,192,119,37,13,38,6,83,103,212,143,183,90,152,10,82,144,101,252,15,130,192,71,224,116,158,9,202,154,92,144,45,82,208,10,23,145,183,143,176,7,97,28,188,224,135,125,7,163,130,41,150,131,160,122,136,188,132,105,156,166,94,60,166,167,21,78,170,20,120,138,148,198,5,39,5,71,97,101,188,253,108,169,81,81,124,130,34,162,80,189,248,158,222,41,39,205,66,231,112,209,68,190,87,106,223,170,8,142,211,25,220,119,240,161,235,110,8,182,88,7,131,158,81,212,51,59,175,140,170,178,92,207,146,21,230,172,130,175,255,70,61,31,193,166,225,13,19,148,101,21,92,114,145,78,235,44,92,172,111,41,116,223,179,114,121,67,7,110,255,187,115,132,215,130,7,99,133,20,161,219,241,239,123,228,153,6,123,174,143,16,92,162,73,86,151,74,230,95,46,124,167,131,243,242,252,223,84,12,86,68,189,184,38,252,175,43,164,86,218,177,120,207,26,233,164,209,193,119,178,84,103,224,3,138,212,245,118,183,209,169,181,11,84,118,246,29,214,230,85,195,57,55,59,148,111,5,169,108,55,248,185,168,150,104,28,243,66,241,7,59,14,117,189,176,175,86,250,25,120,203,117,79,186,222,235,97,68,118,73,118,131,102,37,211,67,245,90,97,242,11,184,110,167,255,35,55,43,208,5,38,118,84,165,237,248,199,223,92,155,67,171,185,65,179,51,112,210,189,93,14,29,131,141,227,106,140,110,191,145,14,133,106,124,95,75,150,82,87,198,238,9,11,169,0,59,228,244,107,28,133,166,84,66,199,211,13,137,156,20,163,176,217,235,230,118,46,101,6,83,221,116,218,15,26,33,169,155,192,173,42,238,98,131,54,198,51,152,222,117,88,66,151,116,211,115,124,1,126,119,7,162,8,68,153,101,141,197,160,191,13,87,104,58,189,63,163,91,19,253,122,204,62,111,76,242,54,194,168,231,62,32,140,230,184,191,25,70,27,65,141,231,52,105,145,78,28,59,112,220,78,79,225,132,46,110,250,196,9,166,250,150,214,191,169,73,94,208,32,111,236,43,71,235,2,211,177,204,202,92,144,120,37,142,220,137,216,247,102,229,252,39,137,236,13,135,239,2,119,33,211,53,97,189,217,221,4,210,43,20,208,86,195,170,130,52,50,149,172,236,71,91,215,100,95,171,52,133,51,217,2,186,179,174,30,184,50,37,203,94,21,202,142,244,214,229,80,231,195,222,96,91,172,122,247,231,158,241,226,86,187,139,207,127,1,100,112,97,156,253,10,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("1e74a254-fcca-4fb6-be7b-59789815c512"));
		}

		#endregion

	}

	#endregion

}

