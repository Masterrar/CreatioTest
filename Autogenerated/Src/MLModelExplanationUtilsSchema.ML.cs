﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: MLModelExplanationUtilsSchema

	/// <exclude/>
	public class MLModelExplanationUtilsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public MLModelExplanationUtilsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public MLModelExplanationUtilsSchema(MLModelExplanationUtilsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("bb4514ca-ce31-4762-a546-68356a21540c");
			Name = "MLModelExplanationUtils";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("73704ec6-562c-4400-8a4a-17477a18625f");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,221,90,91,111,219,54,20,126,246,128,253,7,86,27,54,5,240,20,236,181,137,93,44,77,82,24,139,219,174,78,183,135,97,15,140,68,219,196,116,27,73,165,245,178,252,247,157,195,139,68,221,108,55,232,134,97,47,145,69,30,30,158,235,119,14,169,228,52,99,178,164,49,35,183,76,8,42,139,181,138,94,22,249,154,111,42,65,21,47,242,104,121,243,229,23,15,95,126,49,169,36,207,55,100,181,147,138,101,103,157,119,88,146,166,44,70,122,25,189,98,57,19,60,238,209,92,114,186,201,11,169,120,44,123,115,239,170,92,241,140,69,43,88,73,83,254,167,222,186,161,242,101,203,178,177,25,193,198,198,163,43,96,175,56,147,163,4,215,52,86,133,24,161,88,222,68,139,92,49,177,6,59,13,18,188,174,56,138,126,207,99,182,44,18,150,70,151,84,81,48,163,18,192,182,89,160,165,216,173,226,45,203,40,153,141,201,24,249,100,195,139,193,220,85,150,31,201,194,16,3,35,96,245,149,96,27,176,44,121,153,82,41,159,147,155,34,70,107,179,228,154,81,85,9,246,11,227,155,173,210,148,167,167,167,228,92,86,89,70,197,110,110,223,151,55,36,67,245,200,218,144,147,15,154,158,124,224,106,75,82,199,139,196,70,186,123,154,86,140,208,28,6,104,169,67,201,177,61,245,248,254,234,155,234,55,61,192,238,170,205,134,137,75,46,203,148,238,194,224,53,196,40,232,250,128,207,199,51,242,179,230,11,239,250,7,12,24,169,113,196,252,122,12,78,144,81,89,221,165,60,38,49,170,58,170,233,228,65,107,219,24,6,34,88,137,10,131,1,236,243,86,179,48,20,93,131,232,129,69,14,246,214,140,37,161,36,103,31,8,135,245,52,135,124,42,214,68,109,25,44,97,140,196,130,173,103,193,176,12,193,233,220,200,24,213,187,248,246,113,106,12,47,14,79,8,230,230,228,241,95,146,145,220,237,244,138,13,191,103,121,179,99,189,124,21,67,18,229,155,55,149,42,43,21,89,30,218,187,252,174,194,24,0,78,35,122,234,145,146,10,154,145,28,28,61,11,214,3,171,231,183,176,185,139,190,216,155,137,206,79,245,218,35,76,118,80,70,50,176,179,181,243,196,198,226,0,69,132,83,103,154,200,69,232,16,149,158,51,100,117,220,14,209,249,47,103,255,37,23,107,128,91,25,1,156,245,22,89,89,8,189,223,167,251,215,91,59,63,222,137,251,165,32,61,222,195,254,107,230,61,239,117,221,226,17,53,63,125,151,124,197,242,196,192,71,27,75,222,138,162,100,2,241,248,8,36,121,197,148,36,133,32,18,159,104,127,52,146,243,158,149,100,196,178,26,66,151,44,187,99,34,180,250,5,184,218,192,160,51,36,192,26,150,17,77,240,64,54,76,157,225,94,103,100,95,92,245,132,178,72,254,116,185,44,131,96,74,174,50,174,46,217,154,86,169,170,243,133,166,146,13,9,253,210,110,251,100,185,109,161,122,178,216,102,125,219,160,73,1,79,230,170,207,147,69,211,101,242,19,68,209,244,159,104,63,67,240,100,17,19,83,137,109,69,127,178,17,45,155,159,159,160,192,165,183,116,72,143,78,10,154,209,206,96,167,247,89,222,104,12,185,250,8,140,115,221,111,190,87,60,149,163,205,143,94,6,154,83,69,182,44,45,165,233,122,50,26,111,121,206,72,202,168,200,81,82,211,32,177,134,43,81,84,254,46,7,123,159,90,71,32,116,141,202,168,88,221,78,101,201,212,182,72,16,90,4,191,167,138,153,217,210,188,56,158,247,5,79,200,53,79,83,223,128,50,124,47,153,128,2,147,155,150,157,84,173,215,41,185,225,82,157,15,3,239,220,249,93,78,53,88,78,46,185,94,4,26,157,27,95,77,137,105,56,65,3,160,146,48,55,183,29,97,51,178,164,101,169,73,95,85,32,31,243,154,213,69,98,249,26,128,215,99,160,41,77,32,156,72,102,127,56,48,111,245,211,210,181,213,109,109,90,173,240,18,76,10,157,37,28,81,212,194,22,200,139,221,251,69,18,182,69,56,49,133,96,13,45,53,184,151,132,247,84,64,65,133,110,1,254,214,66,192,145,0,70,164,147,101,130,68,174,51,169,107,135,140,174,121,158,132,107,223,132,100,86,27,209,12,68,38,65,102,102,15,253,102,37,152,240,53,9,107,166,51,146,87,105,90,111,56,193,254,135,231,174,155,192,160,199,199,93,81,164,132,203,11,120,48,154,187,204,50,172,111,119,165,230,19,216,217,128,252,245,151,155,18,52,151,160,113,166,99,78,146,103,102,55,187,213,55,223,12,147,69,87,31,33,86,100,168,90,195,168,97,123,36,122,3,149,208,206,193,246,92,190,46,212,107,96,31,248,138,182,133,110,244,196,248,181,51,126,24,135,221,176,181,134,114,44,71,236,163,119,106,172,1,122,66,71,84,252,94,149,193,33,203,162,28,134,116,175,24,163,193,110,229,155,26,83,78,109,196,90,113,31,189,134,98,44,137,135,140,112,40,149,7,179,184,54,149,213,88,199,204,93,59,98,28,190,219,119,48,211,247,24,46,77,144,65,44,236,222,82,33,89,216,34,157,146,2,18,5,179,161,196,201,4,133,182,14,133,40,234,140,25,221,45,200,91,1,222,49,89,84,34,102,182,108,180,196,122,65,130,91,1,213,131,60,39,193,53,22,139,192,166,170,149,160,85,39,102,186,19,182,22,160,80,171,87,122,159,142,195,34,183,223,10,206,124,128,14,83,18,140,96,112,96,161,233,235,160,199,83,70,15,3,210,63,26,139,216,32,63,224,220,129,200,218,239,219,207,129,191,251,195,163,15,197,11,139,130,58,126,7,224,215,5,20,38,217,51,4,247,94,144,188,240,163,68,195,63,79,78,234,204,19,12,104,114,47,35,218,24,15,7,16,38,24,160,118,115,57,226,39,244,187,246,52,186,32,90,72,196,153,55,226,42,43,213,46,108,118,210,18,142,216,5,133,134,18,97,156,208,128,178,145,185,107,221,158,113,155,61,90,234,56,20,25,184,199,137,221,117,142,49,162,174,25,62,193,5,152,80,109,195,238,70,145,153,197,57,31,70,29,55,3,224,136,240,86,79,176,133,9,50,13,124,48,110,135,59,102,235,23,154,33,53,68,119,209,8,55,235,75,194,32,89,27,47,119,215,30,81,179,209,40,77,209,70,127,140,123,221,199,84,109,147,222,142,29,21,199,226,142,164,218,96,246,101,214,13,192,232,37,116,8,138,153,233,14,174,156,52,209,249,204,231,2,167,85,21,111,161,105,195,46,112,145,175,139,107,81,100,151,23,93,17,35,75,97,124,60,61,144,37,35,248,215,218,215,50,180,36,134,111,3,194,7,208,201,158,192,254,55,173,99,221,219,237,71,64,108,248,156,212,199,65,7,222,219,80,158,203,31,217,174,174,139,58,36,15,117,23,77,234,246,152,254,234,51,250,13,154,59,119,74,48,55,245,209,242,230,48,40,213,187,15,237,19,89,247,34,90,154,198,172,15,152,77,144,185,211,248,172,183,139,155,114,29,88,87,85,167,235,0,43,192,91,31,242,174,171,58,230,122,13,214,160,211,113,175,131,240,248,232,165,140,31,213,152,130,46,84,194,58,74,155,160,249,148,12,105,241,90,92,229,85,6,157,47,52,10,199,102,197,49,209,139,62,116,99,47,236,65,228,8,76,107,14,37,133,184,130,232,111,142,22,181,20,126,36,248,97,48,37,30,173,119,226,113,82,44,20,203,192,139,157,195,145,57,253,152,163,19,172,107,74,41,10,219,202,14,235,160,126,92,248,27,188,104,199,215,227,62,191,216,158,114,79,88,29,64,50,141,47,162,40,236,250,247,117,164,89,206,113,19,93,159,253,56,218,218,214,218,198,184,211,181,8,227,122,181,154,133,38,248,15,220,85,54,183,9,135,46,42,87,120,43,180,173,50,154,127,7,16,154,96,104,251,223,126,108,22,232,239,62,173,123,35,73,0,115,59,95,142,198,190,121,244,238,138,219,70,52,159,1,112,12,191,1,56,203,250,151,199,99,151,205,178,245,5,65,238,95,163,175,114,22,137,89,98,238,117,120,130,224,179,230,224,180,189,75,185,124,43,88,194,173,180,231,241,92,193,169,229,252,52,134,28,88,19,174,190,53,198,40,107,154,169,185,250,34,223,233,113,56,59,115,188,76,26,250,168,225,195,142,67,20,11,40,159,181,56,235,240,183,22,152,18,123,169,208,40,229,98,126,97,43,209,77,65,19,112,71,106,30,51,115,91,102,62,170,238,48,88,207,219,132,243,176,221,30,225,24,118,221,56,171,201,122,160,95,139,130,61,120,171,252,153,169,125,221,145,229,95,51,119,184,90,55,53,131,155,89,9,53,202,225,251,79,21,19,187,139,138,167,7,52,244,233,230,161,145,9,15,162,222,167,197,31,196,6,202,66,174,194,110,96,79,59,62,59,241,132,248,3,249,226,85,142,231,6,56,16,107,217,162,11,170,155,74,55,174,101,128,67,178,153,188,181,241,4,169,171,39,26,158,146,225,103,123,132,217,174,228,145,126,174,244,124,104,216,92,181,235,174,17,200,26,43,234,118,32,210,74,142,86,177,230,214,255,24,64,65,253,26,212,155,145,17,123,118,233,234,184,241,107,143,87,37,106,194,200,254,98,117,41,54,170,58,113,113,24,175,168,33,241,176,118,107,225,37,118,227,207,9,166,170,183,203,72,79,54,104,51,16,187,107,7,75,62,108,66,19,28,71,217,177,213,132,143,220,124,201,61,151,79,195,46,108,119,56,147,254,77,241,63,180,211,241,215,246,48,246,55,113,140,194,160,164,34,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateTrueLocalizableString());
			LocalizableStrings.Add(CreateFalseLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateTrueLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("9c27d325-8a0c-4c2c-a336-25a8504f7fe6"),
				Name = "True",
				CreatedInPackageId = new Guid("73704ec6-562c-4400-8a4a-17477a18625f"),
				CreatedInSchemaUId = new Guid("bb4514ca-ce31-4762-a546-68356a21540c"),
				ModifiedInSchemaUId = new Guid("bb4514ca-ce31-4762-a546-68356a21540c")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateFalseLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("b30b4a5d-e406-4aed-8e4b-1af3f59d1b11"),
				Name = "False",
				CreatedInPackageId = new Guid("73704ec6-562c-4400-8a4a-17477a18625f"),
				CreatedInSchemaUId = new Guid("bb4514ca-ce31-4762-a546-68356a21540c"),
				ModifiedInSchemaUId = new Guid("bb4514ca-ce31-4762-a546-68356a21540c")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("bb4514ca-ce31-4762-a546-68356a21540c"));
		}

		#endregion

	}

	#endregion

}

