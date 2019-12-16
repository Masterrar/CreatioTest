﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ReportGenerationCompletionSenderSchema

	/// <exclude/>
	public class ReportGenerationCompletionSenderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ReportGenerationCompletionSenderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ReportGenerationCompletionSenderSchema(ReportGenerationCompletionSenderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("796ba3b1-67e9-4cd7-8749-45333ce9cc0b");
			Name = "ReportGenerationCompletionSender";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("f8ef1a6f-6619-48e3-9227-afa9b7782f83");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,237,86,77,107,219,64,16,61,59,144,255,48,117,32,56,80,228,123,18,251,98,72,8,52,80,26,247,92,214,242,72,94,186,218,21,179,171,164,105,48,244,111,244,239,245,151,116,118,245,97,197,86,45,5,218,91,15,54,214,104,231,205,204,155,183,47,209,34,67,155,139,24,97,137,68,194,154,196,69,11,163,19,153,22,36,156,52,250,244,228,229,244,100,84,88,169,83,72,149,89,9,117,121,185,48,89,102,116,244,193,164,41,135,175,154,247,55,82,33,39,63,34,57,164,104,161,36,106,23,45,133,253,202,71,248,208,25,97,202,136,176,80,194,90,248,132,185,33,119,139,26,203,66,12,154,43,244,191,30,80,175,145,66,202,116,58,133,107,91,100,153,160,231,121,245,204,137,132,150,161,45,8,88,9,139,32,86,214,145,136,125,46,152,4,108,200,247,191,40,212,128,180,41,2,113,83,37,170,225,167,45,252,188,88,41,25,55,128,16,15,108,117,228,73,106,6,188,145,168,214,246,18,62,146,124,20,14,195,36,163,188,124,232,5,131,47,182,136,99,180,214,80,73,219,232,140,227,37,114,245,92,243,104,52,183,89,196,206,80,40,102,28,198,14,215,229,161,125,230,66,224,78,75,39,133,146,223,209,115,167,241,9,36,67,8,205,235,103,182,220,6,57,5,17,98,194,100,54,238,107,116,60,157,151,252,68,77,189,54,149,60,112,213,80,239,200,147,11,8,252,141,88,81,48,3,254,190,23,90,164,172,161,91,116,94,101,124,228,160,157,241,133,23,222,104,123,156,35,102,37,103,57,74,28,200,16,23,180,129,8,21,202,118,138,168,119,222,71,73,174,16,10,238,252,60,254,243,194,217,238,10,122,122,189,71,183,49,235,129,141,122,230,252,18,249,250,90,166,138,37,107,10,215,146,247,91,58,15,145,92,144,200,64,179,31,204,198,73,115,145,45,103,249,27,60,158,47,153,20,194,140,59,3,199,1,143,239,143,113,201,250,92,116,61,13,32,221,152,180,183,191,29,170,50,49,147,85,131,138,142,182,15,128,9,93,65,218,206,151,84,32,200,228,109,44,120,131,224,109,24,94,51,61,73,246,143,68,40,139,92,164,70,125,189,205,198,12,86,198,168,192,251,125,89,237,78,179,205,105,161,38,55,7,116,193,33,131,239,225,179,69,218,87,113,56,220,69,205,69,207,229,223,137,37,88,214,81,165,84,146,214,248,205,29,181,196,218,57,159,54,50,222,128,180,252,236,64,36,60,101,200,143,11,34,239,232,3,69,212,216,88,185,229,161,213,143,44,219,251,83,120,199,254,116,80,132,221,104,24,250,171,45,151,126,223,235,201,204,225,67,93,105,210,123,186,105,170,246,181,157,165,179,189,181,237,157,223,149,237,236,69,183,127,253,230,87,105,126,143,117,162,51,59,89,84,155,231,171,20,11,253,235,199,207,50,2,210,193,179,41,200,162,74,254,123,199,112,239,40,85,181,239,23,255,198,39,42,137,241,32,147,46,111,234,42,208,137,83,3,213,130,228,255,44,176,84,232,182,173,211,150,148,223,205,64,23,74,193,249,121,43,26,181,7,30,92,252,79,127,202,171,216,107,19,220,254,6,207,75,67,18,181,10,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("796ba3b1-67e9-4cd7-8749-45333ce9cc0b"));
		}

		#endregion

	}

	#endregion

}

