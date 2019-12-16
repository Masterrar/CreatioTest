﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: MLAppListenerSchema

	/// <exclude/>
	public class MLAppListenerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public MLAppListenerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public MLAppListenerSchema(MLAppListenerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("6ca0b7b5-dd95-46e1-b532-873fa83f36a2");
			Name = "MLAppListener";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("73704ec6-562c-4400-8a4a-17477a18625f");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,86,109,111,211,48,16,254,28,36,254,195,169,124,160,147,170,244,59,107,138,70,121,209,96,133,137,49,237,3,66,200,117,46,173,193,177,35,219,41,171,166,253,119,46,111,107,236,166,3,36,164,105,155,207,119,231,231,206,207,61,142,98,57,218,130,113,132,47,104,12,179,58,115,241,66,171,76,172,75,195,156,208,42,94,94,60,125,114,247,244,73,84,90,161,214,112,181,179,14,243,211,96,77,33,82,34,175,252,109,252,14,21,26,193,247,62,253,204,121,174,213,240,142,193,99,118,31,208,81,175,183,140,59,109,4,218,33,143,27,92,237,79,167,253,233,116,10,51,91,230,57,51,187,121,187,190,66,87,22,22,150,23,80,80,1,58,21,156,73,248,161,87,22,152,74,193,160,213,114,139,245,190,80,14,77,70,93,179,113,151,107,218,75,86,148,43,41,56,112,201,108,229,126,86,20,23,130,218,68,109,129,23,64,171,55,91,84,174,51,189,98,22,41,230,174,134,21,61,51,184,166,34,225,173,64,153,218,23,112,105,196,150,57,108,54,139,102,65,80,88,170,149,220,193,57,37,187,226,27,76,75,137,230,198,48,194,13,223,109,96,72,96,81,1,105,218,179,163,235,113,179,129,184,249,248,228,180,127,70,7,147,122,239,240,214,193,119,230,27,66,103,50,171,134,1,181,235,126,233,57,94,91,52,125,207,210,91,159,182,61,64,149,54,109,240,123,114,105,52,1,117,116,195,71,250,18,100,15,150,21,137,163,104,141,14,146,121,120,50,188,124,9,227,208,150,248,117,197,13,215,253,172,77,211,34,59,156,53,129,45,147,101,77,236,232,222,199,234,183,204,95,237,145,54,255,69,34,35,116,94,87,33,73,64,149,82,158,116,46,81,120,65,241,98,131,252,231,153,89,151,57,25,63,146,239,120,20,92,234,168,69,223,4,123,184,15,178,81,40,113,186,158,192,175,35,15,238,232,27,48,235,87,208,166,189,111,254,24,154,43,51,72,139,214,163,235,94,8,226,160,121,199,152,65,81,214,153,178,34,120,197,141,122,252,26,143,112,206,107,195,107,204,88,41,93,59,160,124,31,60,1,188,69,94,58,154,114,86,58,157,83,185,164,1,52,104,43,250,41,242,231,52,116,66,33,16,78,160,83,173,99,198,197,15,167,244,21,160,147,0,111,248,199,237,101,221,63,2,173,213,32,65,144,152,34,85,214,25,249,32,2,55,152,37,35,47,221,104,58,135,95,194,109,128,151,150,176,66,197,189,170,152,142,174,195,192,106,75,193,12,203,65,145,246,39,35,159,178,163,249,117,144,102,54,173,189,143,87,21,140,153,159,239,132,20,207,109,132,237,106,143,174,195,9,57,144,0,114,58,11,136,224,251,196,135,92,251,3,63,150,232,54,250,168,156,110,181,72,161,147,195,247,164,247,15,96,105,226,43,188,231,42,211,212,101,99,104,30,234,246,36,129,182,196,139,253,102,83,193,131,186,94,59,33,109,252,26,37,58,252,36,211,58,189,194,95,80,181,111,70,188,163,103,106,14,119,245,93,232,108,188,188,88,234,20,229,23,195,136,103,134,156,79,38,251,173,87,204,241,205,165,65,122,152,170,67,171,93,184,111,71,56,84,253,184,3,112,158,231,20,64,101,146,251,108,40,199,124,252,216,1,147,102,132,131,114,111,180,249,89,127,53,196,31,41,118,210,239,77,107,169,180,105,2,52,86,248,143,0,131,250,123,232,14,58,243,159,160,253,53,119,254,36,43,61,137,108,180,1,54,244,225,64,21,255,237,40,242,86,150,231,253,76,173,113,104,14,245,150,190,111,68,218,50,248,147,170,94,245,234,220,113,248,120,183,57,58,90,135,226,78,124,230,189,87,61,242,103,225,116,96,110,251,207,193,130,145,123,252,25,115,130,67,215,84,107,177,141,91,26,177,149,196,55,202,137,234,213,190,226,70,20,238,3,238,30,235,123,109,165,95,191,1,226,238,147,44,153,10,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("6ca0b7b5-dd95-46e1-b532-873fa83f36a2"));
		}

		#endregion

	}

	#endregion

}

