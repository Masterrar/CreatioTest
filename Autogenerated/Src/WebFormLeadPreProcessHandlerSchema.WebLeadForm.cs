﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: WebFormLeadPreProcessHandlerSchema

	/// <exclude/>
	public class WebFormLeadPreProcessHandlerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public WebFormLeadPreProcessHandlerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public WebFormLeadPreProcessHandlerSchema(WebFormLeadPreProcessHandlerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("5131dc53-4fdc-4167-9a9a-5dfd90a5a90d");
			Name = "WebFormLeadPreProcessHandler";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("fc0e3e3b-059a-41c0-ac9d-be82e0250c11");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,85,75,111,219,48,12,62,167,64,255,131,150,93,82,160,176,239,109,210,75,250,10,182,14,5,218,116,103,85,166,29,1,182,100,72,114,176,162,232,127,31,245,176,107,43,174,51,236,96,64,164,200,143,252,72,138,22,180,2,93,83,6,228,25,148,162,90,230,38,89,75,145,243,162,81,212,112,41,78,79,222,79,79,102,141,230,162,32,119,32,0,181,144,253,134,215,91,169,170,39,80,123,206,224,178,51,88,75,21,73,201,45,101,70,42,14,26,245,120,243,93,65,129,168,100,93,82,173,47,72,0,250,9,52,123,84,240,168,36,3,173,239,169,200,74,80,206,62,77,83,178,212,77,85,81,245,118,21,100,127,175,73,173,0,63,231,66,118,86,103,131,230,82,145,18,225,136,166,123,148,147,22,35,141,64,150,26,128,150,90,18,166,32,95,205,191,96,159,108,98,206,7,105,206,73,106,49,235,230,181,228,140,48,203,107,146,214,5,57,142,137,120,239,142,126,87,47,188,175,65,25,172,227,133,61,27,96,232,238,77,234,86,36,91,13,10,211,23,40,89,159,72,180,125,156,205,10,48,151,238,160,195,225,35,4,2,145,249,88,195,192,15,96,118,50,155,138,186,151,60,35,79,96,182,117,160,243,64,107,204,117,177,9,226,166,170,165,50,143,84,209,74,7,230,216,163,122,40,159,133,244,34,117,114,13,57,109,74,243,66,203,6,30,168,160,5,40,178,242,211,227,39,235,45,185,3,179,180,149,30,49,189,90,156,245,57,70,57,223,100,220,216,4,175,169,161,139,246,96,7,200,29,218,140,80,6,202,118,196,89,220,114,40,51,221,217,245,68,46,58,207,100,120,213,2,205,240,61,40,12,255,11,159,156,75,114,17,217,93,14,204,238,64,22,138,214,59,206,104,185,150,101,83,9,61,238,240,241,53,195,9,168,73,54,109,202,60,39,139,111,161,141,247,80,98,87,147,141,62,68,139,242,74,4,50,60,235,104,43,48,141,18,189,92,103,123,170,8,115,158,216,203,33,60,54,179,143,191,21,220,124,29,227,156,248,8,209,213,222,22,183,189,27,62,130,80,178,17,44,204,196,167,148,252,128,183,81,43,7,251,105,230,90,56,49,93,7,221,254,167,138,219,210,0,206,37,100,235,182,64,29,66,64,148,174,74,71,134,41,212,103,140,194,100,13,250,177,143,86,98,96,124,80,143,227,27,197,173,76,127,25,239,121,167,184,249,3,172,49,184,233,205,14,220,215,219,248,237,174,215,53,48,158,115,172,122,137,187,211,106,107,124,249,73,135,153,198,160,75,183,98,136,229,187,154,55,131,233,152,95,61,99,16,171,195,38,183,202,100,153,58,143,113,128,246,205,123,87,43,145,204,150,104,210,41,90,114,222,215,41,193,128,210,164,232,214,223,1,140,127,76,186,83,132,255,6,210,255,140,253,201,189,111,29,126,80,221,158,11,197,93,68,127,137,97,69,206,201,193,94,108,31,214,127,173,247,40,216,42,10,231,167,109,228,95,18,195,121,195,193,2,239,246,182,191,243,212,187,172,39,6,211,107,135,74,212,253,5,164,71,1,212,26,9,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5131dc53-4fdc-4167-9a9a-5dfd90a5a90d"));
		}

		#endregion

	}

	#endregion

}
