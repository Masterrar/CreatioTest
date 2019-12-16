﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: BaseImportParamsGeneratorSchema

	/// <exclude/>
	public class BaseImportParamsGeneratorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public BaseImportParamsGeneratorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public BaseImportParamsGeneratorSchema(BaseImportParamsGeneratorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("1e4db8a1-9ae9-42d1-b927-958c21e8ee77");
			Name = "BaseImportParamsGenerator";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("9d05c8ee-17e3-41aa-adfe-7e36f0a4c27c");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,205,88,75,111,219,70,16,62,43,64,254,195,70,185,72,128,64,221,29,89,70,34,63,106,212,77,131,216,237,165,48,10,154,28,73,172,41,146,221,93,42,22,18,253,247,238,139,220,217,229,75,46,122,232,73,226,112,158,223,60,118,150,89,184,3,86,132,17,144,7,160,52,100,249,154,7,171,60,91,39,155,146,134,60,201,179,183,111,190,191,125,51,42,89,146,109,200,253,129,113,216,125,240,158,5,127,154,66,36,153,89,112,3,25,208,36,106,240,220,37,217,223,150,184,202,119,187,60,179,207,215,73,10,183,187,34,167,28,243,80,8,174,50,158,240,4,152,32,139,23,239,41,108,132,21,178,74,67,198,206,200,167,144,25,169,47,33,13,119,76,217,14,121,78,21,243,124,62,39,11,86,238,118,33,61,44,205,179,148,32,137,18,33,133,146,33,155,74,40,168,100,230,158,208,130,1,132,41,203,73,68,97,125,62,238,192,41,184,109,117,101,76,230,82,79,81,62,165,73,68,34,233,120,183,223,228,140,180,107,17,26,100,22,106,0,174,19,72,99,129,192,23,154,236,67,14,42,222,81,161,31,136,194,236,112,31,109,97,23,146,63,105,158,115,253,95,99,56,122,15,89,172,213,152,103,163,243,158,211,50,226,13,157,57,23,169,133,152,48,245,90,100,37,45,119,217,125,36,146,195,36,131,114,171,10,239,46,97,124,161,3,208,124,191,135,105,9,75,242,19,132,49,80,68,146,249,28,22,211,129,104,210,128,196,146,96,182,99,127,164,22,61,19,156,31,107,36,42,153,203,136,101,29,62,28,10,248,237,54,22,204,5,80,126,248,44,26,134,156,147,177,33,143,63,244,136,126,133,53,80,200,34,208,9,240,85,120,175,135,180,225,120,125,85,248,157,164,157,172,200,6,166,64,87,186,148,27,125,0,174,164,54,89,14,57,101,6,59,157,151,206,202,158,92,38,106,64,136,182,90,104,47,102,198,155,165,240,205,214,197,148,232,130,194,181,34,124,138,252,210,57,158,104,214,232,27,40,8,3,129,152,51,162,40,148,74,253,222,31,33,138,112,3,156,17,190,5,227,20,217,43,175,130,154,127,238,11,44,20,71,253,248,208,35,106,57,77,100,61,176,57,16,105,212,54,192,77,155,216,182,53,164,1,4,126,1,190,205,59,39,10,110,122,25,255,213,174,168,250,82,17,43,152,71,251,144,154,216,20,93,100,46,131,111,174,184,102,52,9,102,134,163,217,207,147,233,76,51,58,67,160,139,93,15,140,90,166,57,111,134,4,149,220,81,131,71,129,151,52,195,113,188,18,193,142,169,178,207,147,152,124,44,138,180,138,102,130,106,22,56,80,102,142,38,75,152,185,216,33,151,234,78,241,69,2,11,21,102,15,156,49,218,16,194,136,49,175,237,140,130,174,33,174,131,208,105,34,160,127,206,27,145,212,39,121,112,157,80,198,39,83,45,172,249,131,214,118,55,118,155,167,192,177,29,217,56,174,112,237,4,173,234,30,67,148,147,210,35,41,31,42,108,7,226,15,132,201,201,138,130,104,145,70,77,77,176,5,251,127,106,226,238,142,240,149,74,181,191,109,90,251,245,13,168,106,64,140,151,10,173,65,14,2,253,239,147,58,134,38,13,104,43,24,155,178,118,99,52,236,50,235,104,85,113,171,213,105,72,89,64,89,108,76,98,91,23,23,30,7,2,206,103,238,40,163,132,242,50,76,73,163,45,69,164,248,120,153,56,27,22,160,7,60,7,253,14,48,35,200,87,94,117,66,103,195,52,71,151,54,191,172,36,165,177,186,239,172,9,205,53,168,94,213,135,22,239,98,253,90,231,69,172,40,194,6,142,56,16,36,39,75,190,244,41,80,163,76,145,174,210,239,110,220,61,110,89,227,133,133,1,235,80,156,78,59,158,238,93,139,99,61,62,181,12,19,123,54,58,105,50,170,42,174,209,109,22,195,75,61,3,149,82,253,226,62,47,105,4,206,27,124,106,105,106,112,9,140,39,153,186,145,116,30,122,136,167,46,162,22,113,52,57,16,249,164,241,225,182,236,233,32,35,59,164,203,242,171,64,111,25,91,177,208,184,170,242,224,207,48,191,52,186,234,9,185,101,83,135,123,4,15,51,65,153,225,173,199,44,237,214,145,0,165,217,155,90,46,159,247,210,136,216,245,21,71,132,92,180,12,19,171,204,205,155,81,117,203,126,134,131,231,190,88,9,229,62,91,97,134,29,66,5,216,153,223,150,21,54,127,250,75,240,44,135,124,109,73,30,52,72,67,45,183,199,251,95,143,47,38,135,223,219,238,123,179,22,187,193,101,200,67,101,205,8,144,35,110,199,100,77,38,45,66,183,236,46,207,159,203,66,202,212,117,163,93,252,163,231,182,248,232,77,93,163,173,121,129,252,224,104,236,186,49,62,186,87,42,225,149,248,77,226,155,50,137,69,53,95,244,94,16,207,72,86,166,169,182,115,196,45,178,111,222,206,26,181,240,148,231,41,89,109,33,122,214,202,175,94,196,108,98,85,75,63,195,225,223,246,173,20,117,26,22,113,191,59,183,46,159,188,196,15,223,2,213,21,19,244,85,176,176,135,101,207,61,80,113,145,76,112,158,143,113,54,199,75,121,39,52,71,56,211,77,183,152,43,238,118,97,13,181,22,51,119,200,6,191,198,129,41,30,252,197,75,123,185,152,87,239,107,1,120,137,160,208,43,153,250,206,245,145,110,202,157,112,234,179,192,238,170,122,55,174,249,181,221,234,73,125,162,82,255,228,178,224,198,98,17,169,77,224,43,110,207,214,165,33,70,187,82,231,226,53,235,187,41,239,157,79,11,178,51,171,161,160,43,163,110,68,190,165,249,55,53,40,90,131,159,84,192,79,113,249,251,157,254,122,173,77,200,92,11,104,24,123,115,192,46,128,104,237,50,167,128,179,177,58,75,170,149,178,203,119,235,173,94,51,174,197,255,48,218,18,212,166,36,169,63,94,136,243,162,134,118,132,55,50,161,212,140,33,33,240,104,6,147,4,235,93,115,0,168,206,255,241,67,11,136,113,36,1,250,149,42,135,38,211,90,187,88,82,68,24,89,9,70,153,70,103,132,46,126,38,158,153,244,113,134,205,59,120,58,119,112,12,92,117,36,50,119,150,96,22,60,69,254,31,131,225,53,141,254,95,182,156,183,113,183,136,186,13,138,111,206,211,174,97,108,104,238,124,22,180,127,0,90,110,46,123,167,24,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("1e4db8a1-9ae9-42d1-b927-958c21e8ee77"));
		}

		#endregion

	}

	#endregion

}
