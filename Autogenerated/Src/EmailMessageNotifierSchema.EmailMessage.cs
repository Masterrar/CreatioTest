﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: EmailMessageNotifierSchema

	/// <exclude/>
	public class EmailMessageNotifierSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public EmailMessageNotifierSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public EmailMessageNotifierSchema(EmailMessageNotifierSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("bb7f384f-9d38-444a-b5b7-db76eaf138d9");
			Name = "EmailMessageNotifier";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("a59df2ff-e832-4d10-b45d-34c5dc9c091f");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,86,201,110,219,48,16,61,171,64,254,129,85,46,50,106,232,3,156,186,65,188,36,113,145,196,105,156,180,103,90,26,219,4,36,202,37,169,180,66,145,127,239,112,147,100,121,233,114,177,68,234,205,123,179,146,230,52,7,185,165,9,144,103,16,130,202,98,165,226,113,193,87,108,93,10,170,88,193,207,222,253,58,123,23,148,146,241,53,89,84,82,65,126,209,89,35,62,203,32,209,96,25,223,0,7,193,146,61,204,132,42,218,108,182,181,242,188,224,135,191,8,56,182,31,79,185,98,138,129,60,10,152,140,154,79,183,74,109,95,20,203,152,170,200,208,59,244,13,150,113,235,3,162,17,127,46,96,141,97,144,113,70,165,28,144,105,78,89,118,15,82,210,53,60,20,138,173,24,8,131,219,150,203,140,37,36,209,176,131,40,50,32,35,42,97,207,54,208,201,108,100,48,99,74,148,137,42,196,128,60,26,78,67,239,249,15,49,71,38,244,138,128,121,244,201,139,4,129,60,220,22,128,148,59,203,30,49,122,129,227,152,241,85,129,25,224,240,131,180,119,44,198,131,16,112,3,202,45,34,47,211,225,237,91,147,177,0,170,32,29,85,179,20,205,44,22,91,64,61,87,91,72,177,45,202,156,127,165,89,9,31,111,74,150,126,138,66,199,170,63,207,210,176,71,134,67,114,133,132,175,104,102,114,33,227,25,79,138,28,139,102,66,183,56,114,105,197,130,63,243,35,137,162,137,50,220,131,191,240,167,229,127,216,137,105,206,79,71,132,13,13,207,44,135,134,101,206,107,14,23,231,45,147,88,218,234,223,25,23,192,83,189,172,9,111,169,188,82,24,218,38,71,2,164,193,174,1,247,201,55,198,19,36,133,72,219,133,120,20,44,167,40,223,104,56,147,69,178,129,156,190,180,177,118,43,198,61,135,185,67,223,245,44,75,61,185,182,39,118,182,254,208,25,182,75,23,10,131,104,68,198,27,202,109,245,13,232,77,143,104,240,102,91,254,28,67,182,99,225,214,110,70,238,65,109,138,20,135,17,163,121,69,54,55,32,118,65,38,204,168,98,148,166,164,125,98,10,187,239,236,255,12,205,43,21,36,235,100,65,143,206,97,205,168,119,81,91,37,53,151,205,189,92,128,62,32,157,189,93,68,29,81,155,182,216,26,68,225,221,67,216,39,161,175,237,184,67,24,122,248,181,40,114,4,59,47,71,149,55,8,123,241,149,52,44,30,121,7,43,53,47,21,136,207,5,227,245,36,118,240,247,136,143,231,220,188,160,188,158,138,120,38,167,223,75,154,121,151,58,134,26,226,20,190,109,64,128,55,173,91,172,197,160,131,255,82,130,168,30,169,192,107,7,125,137,246,186,175,215,35,84,186,20,217,132,218,51,60,154,140,166,63,33,41,113,158,72,186,172,95,135,157,218,225,197,32,75,1,147,81,179,21,245,124,65,61,213,76,23,243,9,104,138,231,116,218,188,14,143,213,45,182,114,96,113,81,35,223,48,7,63,54,44,3,18,53,116,177,126,180,180,109,103,240,35,5,125,192,124,160,3,45,115,108,225,246,225,128,247,4,250,142,71,195,241,150,184,240,66,108,69,162,247,214,0,115,255,80,102,217,92,76,243,173,170,162,83,242,109,87,15,118,177,113,228,111,142,249,147,65,126,176,109,85,59,107,188,61,44,245,126,104,70,43,54,190,183,189,11,118,198,50,190,74,211,78,35,185,242,105,31,113,38,80,246,116,228,88,171,21,246,46,79,160,110,219,126,35,22,28,244,174,21,193,155,127,243,47,238,105,31,246,87,128,42,5,223,61,79,218,199,159,63,208,108,217,218,55,240,255,28,93,58,167,39,202,180,44,138,12,91,105,38,111,85,158,141,138,180,10,155,226,59,71,59,99,133,44,51,121,141,215,24,14,215,148,211,101,6,105,20,78,152,212,111,230,170,158,224,237,147,162,231,254,52,8,46,79,245,73,221,205,86,220,153,12,218,255,212,98,237,155,97,133,83,161,116,152,92,85,118,114,190,48,16,75,139,127,25,227,235,66,228,84,225,175,86,248,103,238,195,215,149,221,221,221,124,251,13,3,181,80,235,92,11,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("bb7f384f-9d38-444a-b5b7-db76eaf138d9"));
		}

		#endregion

	}

	#endregion

}

