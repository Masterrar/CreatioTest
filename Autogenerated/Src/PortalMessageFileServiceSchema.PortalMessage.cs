﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: PortalMessageFileServiceSchema

	/// <exclude/>
	public class PortalMessageFileServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public PortalMessageFileServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public PortalMessageFileServiceSchema(PortalMessageFileServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("82979e3f-cad6-4131-ab9f-5fac8a969ecc");
			Name = "PortalMessageFileService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("c85d2d65-6230-4aeb-9934-bfac9785d42f");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,221,86,75,111,219,56,16,62,187,64,255,195,192,189,216,128,43,223,235,216,69,155,108,3,47,54,77,96,167,237,33,40,22,180,52,114,136,165,72,149,164,108,184,65,255,123,135,148,100,235,233,116,123,236,197,128,230,249,113,230,155,25,75,150,160,73,89,136,112,143,90,51,163,98,27,92,42,25,243,109,166,153,229,74,190,124,241,244,242,197,32,51,92,110,97,125,48,22,147,89,227,155,236,133,192,208,25,155,224,26,37,106,30,182,108,86,153,180,60,193,96,77,90,38,248,119,31,187,101,69,218,29,15,241,70,69,40,206,42,131,119,148,111,247,124,144,224,11,110,78,6,167,39,146,152,96,39,137,146,165,249,74,101,150,108,78,198,39,19,146,145,244,149,198,45,165,3,184,20,204,152,55,176,66,22,145,221,109,234,31,238,77,166,211,41,92,152,44,73,152,62,44,138,239,194,12,168,204,134,109,209,128,202,29,130,210,126,90,113,120,184,98,150,81,249,173,102,161,253,74,130,52,219,8,30,66,232,82,182,50,14,158,124,214,35,178,59,173,82,212,150,35,161,187,243,142,185,190,9,203,11,46,21,117,4,84,12,90,237,13,88,5,27,4,141,86,115,220,97,20,28,221,170,232,114,120,55,152,108,80,143,62,18,113,96,14,67,114,247,161,134,99,135,183,4,204,41,246,170,208,192,19,108,209,206,192,184,159,31,103,32,209,35,45,8,197,34,140,96,199,68,134,255,3,134,243,253,236,124,234,56,174,51,30,193,63,165,174,11,201,43,148,81,94,63,255,157,75,27,194,102,235,239,148,182,76,124,224,2,75,242,208,12,81,75,240,215,89,160,11,143,223,160,65,111,118,120,3,181,209,109,129,43,9,211,85,192,60,234,77,142,207,5,55,245,74,46,255,146,89,130,154,109,4,94,180,108,175,238,111,23,208,142,208,81,239,179,245,237,43,111,111,89,115,203,178,170,16,147,11,37,243,62,61,133,197,152,101,194,86,102,30,221,35,31,214,38,109,203,114,65,181,15,15,239,76,250,17,45,173,133,148,42,188,225,130,219,195,10,191,101,92,99,130,210,154,81,245,195,45,32,170,236,51,46,206,42,40,4,209,184,167,217,149,162,22,168,168,215,239,153,57,21,200,181,182,103,19,104,101,105,59,99,148,247,62,213,110,111,34,44,91,145,29,71,81,195,191,105,171,143,185,102,86,6,40,226,245,135,104,51,161,80,204,253,252,14,122,83,192,219,183,48,234,215,206,65,226,190,55,250,232,19,181,158,186,37,243,91,52,30,207,58,39,252,88,164,27,180,143,42,250,149,93,121,141,22,210,54,213,76,207,126,242,146,148,105,150,128,164,233,154,15,107,15,90,70,195,69,131,183,153,228,223,50,228,17,241,129,199,28,117,112,49,245,238,221,209,116,237,12,12,23,141,221,82,30,24,122,6,34,132,26,227,249,176,126,57,134,211,69,59,3,237,254,76,75,179,112,116,103,156,142,56,236,185,125,236,154,48,3,225,241,224,87,147,244,238,165,60,95,153,192,47,160,91,162,167,223,81,213,233,26,60,208,205,93,202,157,250,15,71,121,115,252,98,186,93,223,15,39,224,70,4,141,253,160,116,194,44,201,201,180,164,128,23,5,127,27,37,39,240,94,69,135,181,61,8,172,153,28,165,193,23,205,210,20,163,137,231,97,9,240,124,208,218,26,236,95,190,68,146,54,51,71,134,46,42,245,166,193,128,73,227,150,67,189,167,99,240,211,60,216,49,237,14,5,45,172,26,245,59,178,143,28,217,201,35,183,14,58,86,241,188,119,110,130,110,228,45,200,13,140,101,66,215,213,2,101,49,112,231,110,252,21,10,180,4,167,99,156,96,115,128,45,223,161,132,211,36,184,63,40,29,166,191,53,120,238,89,110,248,150,207,70,239,29,142,123,157,225,4,120,156,227,221,51,3,145,127,15,85,71,217,71,212,123,78,68,120,13,49,19,6,255,24,202,111,148,18,69,223,90,52,25,249,63,88,29,101,174,82,56,20,200,100,255,250,190,204,213,205,245,93,227,87,17,34,232,131,209,133,96,86,225,98,245,6,116,254,7,249,241,19,202,85,49,96,9,13,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("82979e3f-cad6-4131-ab9f-5fac8a969ecc"));
		}

		#endregion

	}

	#endregion

}
