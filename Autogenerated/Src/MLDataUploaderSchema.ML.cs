﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: MLDataUploaderSchema

	/// <exclude/>
	public class MLDataUploaderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public MLDataUploaderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public MLDataUploaderSchema(MLDataUploaderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("bbd5bc2a-31b9-4357-9afa-3ec7a140e7fe");
			Name = "MLDataUploader";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("73704ec6-562c-4400-8a4a-17477a18625f");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,205,86,91,107,219,48,20,126,78,161,255,225,144,189,36,16,156,247,182,201,67,83,58,2,233,40,180,123,26,163,40,246,113,35,102,75,222,145,148,46,43,253,239,211,197,142,47,113,66,6,123,216,155,37,157,235,247,125,71,178,96,57,170,130,197,8,207,72,196,148,76,117,180,144,34,229,175,134,152,230,82,68,15,171,203,139,247,203,139,129,81,92,188,194,211,78,105,204,175,247,235,166,23,97,116,119,123,244,232,158,197,90,18,71,101,45,172,205,39,194,87,27,30,150,66,35,165,182,128,43,88,62,172,238,152,102,95,139,76,178,4,201,155,77,167,83,184,81,38,207,25,237,230,229,58,24,40,72,172,49,104,9,57,139,55,92,32,100,200,72,184,204,10,105,203,99,140,42,255,105,35,64,97,214,25,143,129,87,105,15,179,14,222,125,230,125,133,15,168,55,50,81,87,240,232,93,195,97,183,174,86,97,122,131,103,21,119,88,93,216,41,24,177,28,132,165,102,54,84,152,97,172,135,243,27,133,8,49,97,58,27,30,96,30,61,5,163,233,28,126,26,164,221,196,86,192,52,16,106,67,162,81,78,42,9,52,49,238,234,104,228,247,233,234,236,165,219,252,139,201,215,72,32,83,48,1,155,196,70,140,37,37,42,186,153,86,70,206,203,98,89,182,62,10,133,64,40,122,124,93,2,137,34,9,88,250,245,71,224,191,189,89,129,189,200,152,178,80,159,169,132,71,146,91,158,160,2,6,107,166,44,62,206,219,183,201,243,34,195,28,133,246,34,86,174,11,7,67,3,197,14,239,14,188,189,40,122,149,19,10,64,100,153,146,61,76,180,103,38,234,134,135,169,139,241,237,14,83,102,50,125,203,69,98,73,24,233,93,129,50,29,117,140,199,227,239,181,82,67,79,109,3,232,25,150,174,108,239,57,102,94,181,196,183,76,99,56,44,194,194,18,201,18,41,178,93,21,102,21,194,190,228,89,189,186,62,230,240,20,20,108,193,255,181,115,46,205,117,191,211,103,195,19,120,81,168,148,173,108,153,244,235,162,214,128,37,76,147,113,215,197,57,83,183,20,92,115,150,241,223,94,7,2,223,44,143,74,51,97,103,251,144,245,67,210,61,190,231,78,99,187,217,225,252,217,70,63,54,225,80,56,155,232,96,190,218,211,93,66,18,66,85,195,9,229,62,88,113,11,205,83,142,116,58,78,217,142,15,18,190,91,246,165,148,218,205,143,186,84,182,155,155,4,214,246,21,78,58,90,41,165,10,238,109,24,12,58,50,128,25,244,232,98,80,75,192,26,52,229,16,34,52,162,207,202,248,254,236,227,180,94,234,11,154,164,182,247,14,38,103,222,209,241,198,136,31,254,106,60,151,127,103,27,80,174,238,247,53,238,175,199,54,228,85,45,176,229,164,13,203,96,43,45,156,33,253,194,37,118,221,142,172,208,29,223,46,218,17,40,163,224,226,173,157,217,164,49,72,227,191,131,231,127,127,191,224,223,62,96,213,198,137,135,172,142,209,116,170,255,17,250,223,181,146,40,119,78,242,109,33,141,253,152,181,47,207,104,85,113,22,124,38,93,230,3,117,131,144,118,31,230,4,159,125,207,166,221,251,3,203,23,36,43,193,9,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("bbd5bc2a-31b9-4357-9afa-3ec7a140e7fe"));
		}

		#endregion

	}

	#endregion

}

