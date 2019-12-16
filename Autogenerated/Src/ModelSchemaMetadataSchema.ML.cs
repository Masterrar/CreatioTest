﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ModelSchemaMetadataSchema

	/// <exclude/>
	public class ModelSchemaMetadataSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ModelSchemaMetadataSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ModelSchemaMetadataSchema(ModelSchemaMetadataSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("3aafb1e4-7ef7-46d3-9a1c-bf938d74b695");
			Name = "ModelSchemaMetadata";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("73704ec6-562c-4400-8a4a-17477a18625f");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,213,87,75,111,219,48,12,62,175,192,254,3,225,30,214,1,89,114,95,219,0,93,3,20,5,218,108,104,115,27,118,80,108,38,22,42,75,158,30,235,178,98,255,125,148,228,56,47,175,177,155,98,192,78,182,100,82,252,62,138,47,75,86,160,41,89,138,48,65,173,153,81,51,219,191,84,114,198,231,78,51,203,149,236,223,222,188,61,122,122,123,244,198,25,46,231,112,191,48,22,11,18,17,2,83,255,221,244,175,80,162,230,233,233,182,204,136,179,185,84,198,242,212,236,124,187,115,210,242,2,251,247,164,201,4,255,21,76,145,20,201,29,107,156,211,2,46,5,51,230,35,220,170,12,197,125,154,99,193,200,168,43,100,16,26,12,6,112,102,92,81,48,189,24,86,235,17,154,84,243,41,26,96,144,6,81,120,228,54,231,146,214,25,179,204,160,237,47,85,7,107,186,95,71,244,145,56,91,205,82,251,45,108,224,212,205,231,168,71,220,148,130,45,78,146,167,49,185,233,119,242,222,127,45,221,84,240,20,82,15,175,9,221,155,167,128,176,230,241,69,171,18,181,229,72,100,190,4,221,248,125,155,66,216,184,66,107,64,105,48,254,89,145,144,100,187,95,107,172,35,143,208,111,177,152,162,62,241,16,225,28,18,47,158,244,224,218,220,225,119,199,53,102,180,105,181,195,0,126,137,222,88,237,111,35,232,60,193,28,237,169,55,121,10,191,59,98,203,162,135,54,49,78,114,94,11,208,27,254,44,41,84,8,135,85,48,69,176,57,130,241,118,153,33,27,136,144,106,156,157,39,30,74,50,24,86,122,61,152,58,27,174,15,114,87,48,249,65,35,203,216,84,96,176,100,54,77,21,4,64,73,177,160,151,7,58,27,165,65,152,17,208,120,20,97,158,129,93,148,8,201,141,82,15,174,76,128,201,12,146,79,74,9,100,50,233,224,218,138,237,184,193,195,51,38,76,163,139,71,43,157,67,60,253,142,94,88,25,18,178,61,222,74,163,53,214,203,40,127,32,78,186,78,212,40,169,164,152,144,24,93,3,184,214,143,121,213,201,219,119,187,186,47,99,227,163,148,10,130,52,20,72,5,248,12,102,177,218,53,243,8,59,63,152,112,56,92,133,230,218,9,59,202,43,217,38,23,108,233,237,167,127,195,141,61,219,41,70,147,141,99,134,176,185,54,77,158,57,70,153,197,194,21,214,113,119,107,115,95,133,222,52,211,165,94,7,175,52,249,189,93,225,126,190,52,111,195,106,87,168,219,135,203,6,216,246,49,210,164,246,124,116,212,26,109,203,252,231,165,194,238,141,191,36,27,152,158,187,2,165,237,152,12,77,106,207,19,173,53,90,38,64,164,59,132,139,165,222,235,71,248,181,44,157,61,100,4,169,186,160,51,68,132,58,96,225,143,6,238,79,125,233,112,82,121,43,206,40,167,48,241,173,142,150,254,185,103,100,9,100,160,113,198,122,245,41,198,211,15,109,184,190,253,11,33,212,35,121,33,196,0,121,76,227,199,85,87,238,65,50,166,59,164,185,210,191,78,240,167,245,207,170,129,211,27,185,5,39,52,65,118,105,223,222,122,235,78,18,220,216,182,117,92,203,140,167,132,200,192,99,142,148,44,186,186,87,147,43,39,178,106,2,162,44,90,205,69,126,102,161,48,56,75,135,210,9,113,54,72,135,222,97,107,243,80,166,8,14,246,199,108,76,83,81,77,242,210,105,106,111,86,44,122,241,180,146,105,34,103,201,32,45,56,141,219,196,170,131,71,120,237,138,253,126,153,210,205,172,203,116,247,141,205,153,13,165,36,141,44,98,216,123,228,82,249,133,79,138,78,224,175,35,225,214,216,43,249,215,175,10,159,157,61,176,44,244,40,114,120,154,47,35,102,173,66,148,132,152,251,249,249,176,30,24,33,254,15,201,94,37,249,191,78,236,195,34,224,22,45,243,172,91,196,128,207,128,224,32,223,13,252,127,74,172,21,177,47,204,184,61,248,170,87,88,94,251,98,77,135,118,246,183,233,160,49,149,131,66,247,49,55,52,176,33,132,71,99,179,223,79,236,208,140,108,201,80,133,244,219,207,112,55,99,171,199,203,34,150,246,254,0,247,244,127,5,226,17,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("3aafb1e4-7ef7-46d3-9a1c-bf938d74b695"));
		}

		#endregion

	}

	#endregion

}
