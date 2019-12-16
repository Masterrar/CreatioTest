﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: PrmCertifiedContactsActualizerEventListenerSchema

	/// <exclude/>
	public class PrmCertifiedContactsActualizerEventListenerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public PrmCertifiedContactsActualizerEventListenerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public PrmCertifiedContactsActualizerEventListenerSchema(PrmCertifiedContactsActualizerEventListenerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("62cc41d2-c829-47ff-91e7-ee6f8a7a627d");
			Name = "PrmCertifiedContactsActualizerEventListener";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("17d20118-0995-427a-b811-b7f3235a9cbc");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,85,223,79,219,48,16,126,14,18,255,131,149,189,148,169,74,121,217,11,208,34,86,10,98,26,140,13,38,30,166,9,25,231,218,122,36,118,100,59,93,1,241,191,239,28,59,109,28,26,96,106,213,202,190,187,239,238,190,251,97,65,115,208,5,101,64,174,65,41,170,229,212,36,99,41,166,124,86,42,106,184,20,219,91,79,219,91,81,169,185,152,145,171,7,109,32,71,121,150,1,179,66,157,156,130,0,197,217,254,74,231,123,73,149,121,108,159,147,179,188,200,146,115,106,216,28,148,222,44,189,86,124,54,11,164,205,144,20,116,221,39,39,148,25,169,56,108,180,188,129,59,212,202,115,41,54,219,119,75,16,249,10,195,77,203,12,84,167,70,192,21,106,161,222,96,48,32,7,186,204,115,170,30,70,254,124,196,76,73,51,254,8,164,192,132,145,50,194,164,48,24,55,97,160,12,159,114,70,13,232,164,182,30,52,204,139,242,46,227,140,176,140,106,77,46,85,62,118,6,144,142,29,130,94,97,171,201,2,132,249,202,177,72,214,195,30,57,42,138,224,234,51,213,128,136,79,85,152,209,7,5,51,12,154,156,112,200,82,189,135,216,124,129,81,56,97,225,14,68,1,77,165,200,30,136,54,202,166,127,251,71,222,157,42,89,22,100,72,226,75,151,139,158,243,226,149,168,226,253,87,1,141,43,251,5,54,226,251,49,191,200,187,91,223,47,111,192,51,37,197,100,89,40,208,218,38,139,30,118,201,46,249,68,62,226,231,240,13,91,204,245,191,195,138,171,38,104,194,214,85,176,234,176,52,228,150,134,23,251,45,101,188,22,110,188,42,213,245,49,80,252,169,65,53,53,203,224,188,239,75,12,34,117,85,14,75,126,169,100,97,179,0,91,246,170,191,124,200,174,215,90,216,173,163,221,7,81,52,3,67,134,163,182,95,114,120,72,122,237,187,97,152,85,226,214,72,136,186,83,37,23,105,68,117,248,209,130,102,37,206,215,28,216,253,145,154,149,57,18,118,81,102,89,47,14,13,99,111,25,189,244,90,33,56,233,179,253,125,14,146,12,153,14,79,235,20,125,48,124,138,105,5,197,32,195,33,17,24,207,78,173,18,133,16,195,23,117,78,80,33,179,131,142,226,95,113,160,29,255,38,84,135,49,248,172,158,221,159,2,83,170,141,253,224,53,222,67,92,232,114,197,91,43,173,46,218,186,122,233,28,204,92,118,238,143,133,228,41,169,215,232,24,103,209,79,45,78,74,175,166,206,146,139,177,173,150,109,114,44,65,163,194,100,137,123,171,87,79,97,127,189,123,118,86,164,7,102,63,32,151,11,176,200,155,108,154,108,157,161,210,49,24,202,51,130,114,215,160,107,156,49,46,2,3,99,187,112,81,239,224,221,163,63,234,173,188,245,93,120,97,171,38,55,82,221,87,143,109,226,130,107,137,199,165,82,88,44,123,235,21,108,131,245,137,81,37,248,240,207,60,125,196,111,77,12,93,192,95,210,32,214,62,165,189,230,82,109,112,208,111,175,67,143,26,100,127,38,180,161,130,173,31,63,75,40,34,244,107,159,206,232,221,93,209,88,47,237,151,177,186,112,108,107,66,69,74,180,119,137,167,170,48,83,169,154,15,100,250,226,245,164,158,255,106,168,146,149,143,65,219,201,1,26,210,156,8,228,99,24,51,55,143,241,104,178,4,86,86,93,239,175,146,131,65,165,56,106,236,9,108,41,165,120,234,91,249,155,176,100,25,12,163,215,222,235,30,163,238,205,26,114,195,32,214,1,120,250,219,139,2,139,202,26,79,67,212,53,62,93,117,176,119,248,253,7,94,49,153,100,219,9,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("62cc41d2-c829-47ff-91e7-ee6f8a7a627d"));
		}

		#endregion

	}

	#endregion

}

