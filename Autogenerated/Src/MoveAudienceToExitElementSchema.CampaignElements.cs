﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: MoveAudienceToExitElementSchema

	/// <exclude/>
	public class MoveAudienceToExitElementSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public MoveAudienceToExitElementSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public MoveAudienceToExitElementSchema(MoveAudienceToExitElementSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("d93ec393-d854-4c31-8744-226d42cd33ec");
			Name = "MoveAudienceToExitElement";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d0bba11f-3986-4819-81ab-1d3ddbfc1f48");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,221,87,221,111,26,71,16,127,38,82,254,135,17,125,8,72,24,154,40,46,137,109,168,12,216,22,82,29,89,137,211,151,168,15,203,222,0,91,29,183,167,221,61,59,212,202,255,222,217,143,59,56,224,0,87,174,84,245,229,116,55,59,59,59,243,251,205,199,94,194,22,168,83,198,17,238,81,41,166,229,212,180,135,50,153,138,89,166,152,17,50,121,253,234,233,245,171,90,166,69,50,131,47,75,109,112,113,190,241,77,250,113,140,220,42,235,246,13,38,168,4,95,233,172,155,85,88,37,111,15,217,34,101,98,150,28,84,104,143,19,131,106,74,30,235,74,221,59,37,105,217,174,147,198,79,10,103,228,26,12,99,166,245,25,220,202,7,188,204,34,129,9,199,123,121,245,93,152,171,24,23,152,24,167,220,233,116,224,66,103,139,5,83,203,126,248,14,235,96,230,204,192,130,182,107,72,153,50,130,139,148,37,70,131,145,192,51,165,172,10,15,78,130,32,92,96,178,4,157,34,23,83,129,17,76,101,28,161,106,231,103,116,214,14,249,54,66,77,155,110,101,132,228,121,138,202,44,27,159,136,23,232,65,125,172,243,192,111,36,139,235,45,82,175,125,213,108,134,247,203,212,42,172,182,22,210,246,39,105,126,23,90,76,98,108,193,45,26,150,27,13,54,203,38,215,23,155,127,144,249,52,155,196,130,3,183,112,85,163,5,103,48,96,26,115,75,185,78,88,109,193,56,188,221,41,33,149,48,75,50,252,228,16,94,241,65,233,98,44,128,103,64,74,15,204,160,95,79,253,7,112,187,14,218,40,75,112,181,207,59,64,58,15,7,97,18,249,179,118,28,172,50,110,164,178,103,187,112,189,198,38,251,78,48,194,41,203,98,227,253,241,219,136,76,69,138,72,78,42,156,246,234,149,40,213,59,253,118,97,120,157,242,28,229,202,157,141,38,216,186,171,213,194,119,160,59,143,243,11,159,227,130,173,173,181,215,45,217,194,168,253,216,19,211,240,69,99,113,18,42,9,182,128,132,24,233,213,181,204,20,199,122,127,236,24,166,222,34,167,71,31,113,209,113,150,142,3,169,58,61,189,11,77,7,97,237,140,106,87,232,134,151,181,32,201,226,216,63,3,200,255,3,168,182,12,71,130,155,123,249,25,39,34,137,234,253,145,112,253,153,220,176,237,74,57,41,104,151,68,128,222,162,126,3,34,210,251,141,210,59,105,250,228,171,247,239,88,185,233,121,123,47,203,96,11,86,174,95,220,100,34,106,129,125,246,97,61,190,150,167,185,60,39,202,165,2,235,174,55,169,123,77,168,123,21,25,81,50,182,161,234,203,176,220,98,168,18,253,214,118,89,126,254,34,37,91,213,184,66,219,19,232,90,166,52,52,115,49,218,147,186,227,136,78,178,211,71,217,172,10,52,3,115,112,86,181,165,220,44,144,111,74,137,8,29,220,112,233,54,5,44,102,104,194,91,77,161,201,84,82,196,232,138,69,23,208,255,38,103,54,208,173,56,109,160,207,139,246,80,147,190,142,217,12,30,231,130,207,129,40,20,156,6,136,246,3,59,15,91,232,34,81,223,104,152,89,18,169,154,19,105,42,144,248,102,39,167,245,190,24,201,245,167,119,131,15,221,211,95,186,239,79,174,6,31,62,158,188,191,190,26,157,12,78,223,13,79,62,118,7,221,203,183,195,203,110,247,116,244,163,238,166,104,158,249,19,41,227,141,233,181,66,209,131,161,195,203,190,46,148,143,81,75,164,189,130,172,138,142,5,96,139,64,241,59,242,108,31,197,222,49,65,170,133,213,42,94,55,28,255,21,222,82,229,252,124,60,135,132,225,92,70,199,16,56,84,232,56,99,144,224,35,57,23,186,161,163,80,88,49,143,101,226,186,163,153,99,113,223,202,245,246,117,91,31,138,238,15,173,129,104,101,58,152,58,190,217,230,134,214,64,44,138,68,78,254,164,178,1,119,70,49,186,3,136,54,160,234,6,104,39,83,243,240,192,62,8,143,76,151,255,4,157,255,222,200,40,147,38,83,241,175,147,70,208,53,142,153,50,240,140,1,243,204,12,216,59,130,142,206,142,240,183,193,33,252,0,93,199,242,49,31,167,207,77,134,76,163,162,118,158,248,31,187,202,11,202,215,178,218,174,91,73,78,65,133,133,109,95,15,51,183,35,62,143,193,246,66,163,236,33,148,227,202,137,122,96,42,52,78,70,191,77,185,205,94,5,115,235,231,134,134,121,237,126,239,62,35,151,42,26,71,180,211,11,198,249,221,100,235,254,80,22,4,173,13,95,123,27,222,250,190,235,219,239,56,17,70,176,88,252,85,252,131,237,136,125,43,36,159,75,121,94,110,45,239,185,133,120,105,89,72,178,191,1,58,2,2,230,64,16,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d93ec393-d854-4c31-8744-226d42cd33ec"));
		}

		#endregion

	}

	#endregion

}
