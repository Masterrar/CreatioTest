﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: MailingStateSchema

	/// <exclude/>
	public class MailingStateSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public MailingStateSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public MailingStateSchema(MailingStateSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("d6624373-5eed-4cd1-89cc-7a68dfce03a5");
			Name = "MailingState";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b39fd9cb-6840-4142-8022-7c9d0489d323");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,189,86,75,111,219,56,16,62,59,64,254,3,87,237,65,6,12,250,30,199,14,90,215,155,13,144,20,65,220,180,135,162,7,90,26,59,220,72,148,75,82,110,93,35,255,189,195,135,100,74,182,146,20,11,236,197,150,168,153,111,190,121,83,176,28,212,154,37,64,62,129,148,76,21,75,77,167,133,88,242,85,41,153,230,133,56,61,217,157,158,156,158,244,74,197,197,138,204,183,74,67,62,106,189,211,107,46,190,239,15,67,164,60,47,196,241,47,18,232,135,247,157,159,102,66,115,205,65,141,172,241,55,18,86,200,133,76,51,166,212,25,185,97,60,67,157,185,102,26,236,247,225,112,72,206,85,153,231,76,110,39,254,253,221,66,105,201,18,77,18,163,68,138,37,201,157,26,81,70,143,86,106,195,64,111,93,46,50,158,16,214,84,109,154,235,185,120,212,156,110,101,177,6,105,184,158,145,91,171,239,190,123,44,175,140,49,213,240,83,147,234,127,71,86,160,71,100,45,249,6,81,137,50,47,79,30,24,68,234,176,155,134,110,64,63,20,169,177,226,148,188,25,143,176,41,120,74,166,18,240,249,14,114,46,82,52,26,219,40,110,9,216,191,1,58,46,141,255,89,242,107,110,159,62,98,242,235,211,132,173,77,190,7,100,205,36,203,49,96,139,127,33,209,95,191,185,119,208,32,85,159,236,140,201,222,134,73,146,130,74,36,183,42,100,28,200,208,119,98,27,247,201,133,135,165,127,23,50,103,58,190,4,125,93,153,253,204,178,18,226,6,139,254,32,52,99,141,244,206,200,75,74,35,43,232,35,124,175,241,207,164,129,182,163,224,99,78,239,21,72,124,22,232,150,117,180,10,75,224,202,160,10,131,195,126,125,70,10,141,168,144,186,239,237,114,180,7,142,149,34,250,1,136,172,184,209,90,124,216,150,63,183,1,33,2,29,29,71,142,106,52,249,132,202,238,153,158,15,173,192,113,249,70,156,162,137,249,53,29,96,108,103,69,194,50,254,139,47,50,168,114,244,44,212,62,47,206,124,144,234,80,111,93,133,224,63,84,226,203,149,215,134,173,240,90,64,135,133,19,213,58,55,106,53,117,57,142,154,85,23,102,124,239,141,103,122,136,184,119,193,214,98,208,26,62,194,12,35,188,39,133,77,242,54,186,110,127,81,116,231,1,158,168,133,141,70,221,48,8,33,224,7,57,0,233,40,112,250,165,144,143,118,182,211,59,80,69,41,19,148,47,36,91,193,192,53,88,52,157,205,77,243,152,238,193,10,222,240,20,100,52,56,78,191,191,231,181,49,60,145,203,129,156,243,128,92,92,56,248,195,239,24,196,105,153,233,82,130,11,225,37,8,144,44,107,177,163,31,96,233,197,6,100,201,50,85,25,151,128,103,194,217,15,147,117,180,221,230,160,93,175,45,202,236,145,128,153,253,118,240,151,234,181,61,103,20,103,70,239,42,117,149,31,32,97,168,176,242,150,28,228,243,205,83,99,204,173,233,35,72,142,83,23,96,208,85,92,234,146,101,174,187,208,185,247,77,228,248,178,196,243,128,50,54,65,227,164,34,80,21,170,169,164,251,117,138,221,212,57,31,163,218,70,212,167,95,184,126,248,135,11,173,98,163,121,87,252,192,50,124,52,7,113,223,207,107,138,172,226,168,118,116,128,187,46,43,115,65,111,171,22,139,15,201,32,238,3,72,108,79,84,232,211,43,53,251,142,62,198,221,138,70,197,91,155,253,132,164,68,246,127,56,169,253,134,238,245,58,43,199,3,187,234,169,239,10,93,21,227,138,82,77,174,4,138,138,196,142,217,115,5,64,18,9,203,113,228,151,19,150,248,186,16,10,162,225,4,243,91,233,4,215,132,250,202,209,82,168,216,216,203,135,245,181,147,247,149,192,245,103,58,206,82,231,88,83,158,82,7,125,111,185,81,88,123,12,220,225,59,242,92,131,5,97,66,91,46,78,174,235,124,73,99,32,92,137,47,182,184,240,20,118,180,153,97,178,114,108,41,139,60,140,84,232,168,9,83,123,111,214,59,147,240,37,206,65,72,33,253,31,242,210,145,142,56,156,247,121,75,102,124,152,52,148,60,210,179,85,227,213,231,110,75,82,188,224,25,103,92,27,216,81,57,104,27,161,117,11,57,116,140,73,220,22,169,87,94,189,185,166,69,10,228,47,92,35,101,150,85,30,28,236,212,14,86,135,20,142,227,123,66,79,225,200,110,105,190,126,120,39,254,186,140,201,83,240,71,55,38,175,25,189,80,0,222,89,151,255,96,238,250,222,240,195,214,75,197,173,203,188,183,81,95,78,252,241,184,250,240,204,100,114,167,205,67,60,251,13,74,104,103,175,143,13,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d6624373-5eed-4cd1-89cc-7a68dfce03a5"));
		}

		#endregion

	}

	#endregion

}

