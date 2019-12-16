﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SetOpportunityWinnerOperationSchema

	/// <exclude/>
	public class SetOpportunityWinnerOperationSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SetOpportunityWinnerOperationSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SetOpportunityWinnerOperationSchema(SetOpportunityWinnerOperationSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("a805cdc5-c859-4006-bba1-bd7a97ca91f1");
			Name = "SetOpportunityWinnerOperation";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("de2b3e7f-7fd4-4205-83d9-d3278f5d6ce6");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,86,93,111,226,56,20,125,166,82,255,131,55,59,15,137,84,12,180,3,51,12,109,87,148,143,17,210,76,219,21,221,237,227,200,155,24,136,54,177,51,182,211,46,170,248,239,235,175,4,39,1,186,203,3,144,235,123,175,207,57,247,250,58,4,165,152,103,40,196,224,9,51,134,56,93,9,56,161,100,21,175,115,134,68,76,201,249,217,219,249,217,249,89,43,231,49,89,131,229,150,11,156,142,202,103,55,40,77,41,57,188,194,240,49,59,156,222,29,93,154,17,17,139,24,243,145,222,255,87,134,215,18,14,152,36,136,243,47,96,137,197,67,150,81,38,114,18,139,237,115,76,8,102,15,25,46,48,203,128,78,167,3,174,121,158,166,136,109,111,237,243,35,102,43,202,82,14,232,62,22,188,234,96,192,177,16,10,5,45,178,192,34,73,199,201,146,229,127,37,113,8,66,133,226,61,16,45,163,220,30,58,37,92,32,34,36,252,71,22,191,32,129,205,122,102,30,64,168,214,1,23,76,193,24,135,33,205,137,208,34,108,239,101,149,192,13,240,172,209,27,29,13,91,10,180,198,19,154,228,41,41,130,180,105,17,157,8,122,120,149,192,171,65,218,100,130,52,5,76,34,195,162,74,105,30,227,36,58,198,135,97,20,81,146,108,193,31,92,165,151,234,132,74,24,240,35,175,60,143,14,198,124,205,227,8,252,8,19,202,113,244,76,137,37,33,161,17,252,170,23,125,111,208,157,246,175,122,221,73,187,127,55,27,180,167,243,94,175,61,252,212,187,107,119,187,189,233,160,59,27,94,125,158,12,188,224,253,244,223,40,23,135,242,143,135,227,241,124,58,159,181,47,47,63,94,182,63,206,229,215,231,201,180,223,190,28,207,174,238,134,253,254,96,250,105,168,243,159,82,72,23,157,229,161,160,76,233,164,219,199,202,100,90,233,100,19,249,53,233,170,202,5,224,77,37,106,85,173,112,178,193,225,223,99,182,206,83,76,196,125,158,36,62,145,85,165,43,191,22,109,164,105,213,202,33,37,56,80,159,221,105,150,223,177,216,80,211,8,84,200,48,28,21,173,96,31,141,224,95,43,92,109,219,17,129,66,177,136,124,237,65,77,223,21,204,76,251,47,195,13,78,209,239,57,102,91,227,48,227,63,109,165,26,14,126,141,14,116,61,190,35,34,203,204,46,128,103,183,181,237,209,42,178,194,113,20,153,131,224,55,14,160,117,53,6,139,195,252,191,41,81,65,201,208,24,235,56,46,74,106,38,77,188,2,126,37,135,228,35,75,85,16,111,49,44,114,70,180,108,112,150,102,98,107,194,118,250,219,46,58,241,106,227,167,109,134,45,250,63,81,146,227,107,21,124,235,127,240,222,26,92,118,242,104,7,110,97,155,133,146,3,61,195,210,159,178,49,55,93,233,91,168,88,255,20,72,151,56,145,129,114,124,234,31,83,21,99,171,75,16,192,39,154,249,189,192,16,148,31,104,165,246,246,123,41,92,197,58,156,51,154,250,158,211,49,123,63,199,235,121,131,25,174,184,169,36,112,193,103,63,115,148,248,102,15,248,136,152,228,45,36,11,3,31,202,145,165,134,186,163,87,224,32,27,19,57,0,22,150,248,169,108,242,108,55,3,171,124,224,61,21,190,74,161,207,98,0,16,183,2,141,220,98,26,1,225,236,31,28,230,2,47,67,148,32,102,43,24,252,191,35,232,204,152,250,37,168,13,114,226,84,111,64,221,71,92,222,9,105,134,136,124,100,250,175,33,160,208,54,111,203,34,149,236,98,179,168,151,164,171,153,168,210,75,108,192,171,68,37,19,72,139,128,37,152,78,29,205,117,166,180,4,106,68,221,120,166,54,222,173,83,76,219,110,240,186,163,29,111,157,209,249,18,75,31,148,128,23,42,91,118,74,247,83,243,96,163,234,198,230,102,206,143,64,121,8,127,177,249,23,220,105,133,111,20,69,56,242,107,183,105,80,59,157,238,145,228,229,5,130,223,59,144,245,172,163,61,60,154,68,203,99,137,30,146,255,156,75,241,42,1,221,56,89,79,16,48,251,103,153,105,121,13,160,62,124,106,105,27,183,115,153,221,29,229,123,34,135,20,174,189,122,4,224,183,247,245,107,196,124,105,32,109,213,136,156,186,119,170,115,121,7,112,194,49,56,76,213,121,83,40,185,54,118,58,48,56,109,35,186,114,235,214,115,98,161,158,47,220,223,51,217,119,155,85,100,169,114,151,98,248,94,17,234,93,184,117,115,119,57,60,50,118,170,249,213,43,117,197,188,3,255,2,29,154,228,102,12,12,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a805cdc5-c859-4006-bba1-bd7a97ca91f1"));
		}

		#endregion

	}

	#endregion

}

