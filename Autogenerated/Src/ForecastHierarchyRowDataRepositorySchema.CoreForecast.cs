﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ForecastHierarchyRowDataRepositorySchema

	/// <exclude/>
	public class ForecastHierarchyRowDataRepositorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ForecastHierarchyRowDataRepositorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ForecastHierarchyRowDataRepositorySchema(ForecastHierarchyRowDataRepositorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("83526d74-74f9-4c6d-a095-476ee8d1bf5f");
			Name = "ForecastHierarchyRowDataRepository";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("e0b9d996-6f7e-4520-a678-da960c79be39");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,205,26,219,114,219,54,246,89,157,233,63,32,106,218,82,19,45,157,221,199,216,114,198,23,57,213,214,141,189,150,147,157,157,76,166,195,82,144,205,134,34,85,128,116,162,184,250,247,61,0,14,136,11,65,74,201,246,97,95,226,8,196,185,95,113,128,34,89,81,190,78,82,74,110,41,99,9,47,151,85,124,86,22,203,236,174,102,73,149,149,69,124,81,50,154,38,188,122,251,143,111,191,121,252,246,155,65,205,179,226,142,204,55,188,162,171,67,239,55,128,230,57,77,5,28,143,95,209,130,178,44,109,237,57,79,170,164,181,120,153,21,127,152,69,155,23,70,195,235,171,85,89,116,65,196,211,162,202,170,140,242,206,13,23,73,90,149,172,111,199,249,41,124,130,143,223,49,122,7,242,144,89,81,81,182,4,77,189,32,51,173,147,159,50,202,18,150,222,111,110,202,143,66,172,27,186,46,121,6,136,55,18,244,224,224,128,28,241,122,181,74,216,230,24,127,95,179,242,33,91,80,78,86,180,186,47,23,156,84,37,97,180,2,86,30,40,169,238,41,89,0,30,114,175,17,147,114,41,87,129,94,201,96,119,86,200,159,75,100,32,214,84,14,44,50,235,250,183,60,75,97,43,50,188,31,191,131,71,201,115,139,105,185,240,138,86,92,18,54,140,177,242,35,143,27,128,3,31,226,104,157,176,100,69,10,240,175,201,80,179,43,205,178,121,51,91,12,143,111,45,41,8,149,235,4,244,2,255,89,2,137,248,232,64,194,135,209,53,76,40,52,205,207,126,40,84,225,108,193,21,88,163,210,5,111,3,130,73,106,86,240,99,227,208,194,18,71,156,82,146,50,186,156,12,109,85,14,15,142,143,14,52,132,64,49,155,22,245,10,190,255,150,211,35,123,227,177,80,164,189,192,163,249,61,165,21,225,226,223,177,0,13,195,206,105,85,129,143,206,32,84,142,141,188,99,114,157,220,81,177,83,133,44,89,59,63,71,202,129,183,157,190,120,235,27,180,207,157,210,60,225,156,216,204,27,159,209,49,2,206,189,166,76,4,222,11,114,45,193,118,249,84,201,8,215,190,165,12,98,123,65,143,123,61,36,121,77,155,159,183,59,192,205,110,148,230,85,157,45,200,141,132,152,45,200,35,185,163,213,161,224,228,144,108,191,132,101,137,247,203,216,244,65,90,172,113,72,6,144,142,222,138,245,16,103,223,209,98,161,244,109,153,215,91,212,6,57,19,70,123,65,254,191,243,149,34,75,105,146,243,18,163,107,143,140,53,36,7,2,248,221,57,93,38,117,94,157,102,197,2,212,22,85,155,53,45,151,209,30,8,70,163,247,190,119,239,6,34,123,102,127,63,50,32,34,121,149,20,21,87,203,107,150,61,36,21,228,18,177,172,45,126,113,117,51,61,59,153,223,254,58,125,125,59,187,253,207,175,39,151,179,147,57,153,144,225,197,116,120,216,9,117,153,126,158,45,32,77,213,171,226,53,228,57,177,95,251,117,15,148,15,162,54,7,220,203,149,128,213,162,108,122,209,141,42,220,173,150,232,13,167,12,240,20,152,81,107,231,231,136,60,202,4,232,174,198,103,247,52,253,112,194,238,32,41,22,213,235,58,207,35,145,206,193,196,30,244,72,10,59,240,72,76,60,34,114,83,56,144,2,89,76,27,171,172,0,154,46,136,135,220,251,137,177,218,194,222,66,168,9,253,162,66,10,180,169,76,228,250,6,90,10,114,206,13,93,82,70,139,148,42,155,201,204,32,12,23,169,122,58,79,239,233,42,33,92,254,25,107,56,166,129,212,38,177,95,107,248,33,97,230,179,194,9,138,82,240,177,250,205,227,139,140,241,234,138,97,120,69,18,112,144,146,201,49,73,227,134,33,69,250,101,172,220,104,18,34,74,126,248,129,60,73,227,25,159,21,247,208,15,130,26,209,82,170,96,250,140,188,140,61,33,109,139,105,213,204,169,40,202,66,53,23,78,103,161,214,35,212,128,219,117,8,92,99,98,149,91,173,13,71,137,170,19,153,21,103,52,207,113,105,226,217,57,182,1,126,73,10,168,185,12,154,221,106,38,35,60,165,167,162,193,137,36,137,216,101,79,161,133,175,168,1,228,179,77,19,163,178,253,33,110,52,34,141,232,74,232,41,14,16,244,249,78,27,249,56,160,49,228,20,21,206,213,159,9,41,232,71,52,130,23,211,35,229,39,241,5,43,87,81,0,93,124,194,163,96,158,211,128,255,44,179,34,18,255,220,66,34,143,103,128,151,141,59,52,132,32,131,248,170,8,227,28,203,188,54,2,223,155,254,81,39,121,64,100,229,20,189,106,108,168,156,20,139,78,12,67,233,87,14,49,133,38,150,105,19,189,1,12,63,34,9,71,205,57,81,192,205,146,231,235,255,170,41,3,158,160,186,201,36,35,76,154,221,221,87,188,89,138,28,227,140,137,227,207,174,104,106,209,78,3,156,166,53,4,229,102,90,220,101,5,109,251,250,249,233,220,217,97,124,143,185,92,136,4,226,236,140,165,243,201,46,224,116,35,89,54,28,11,247,113,191,93,173,229,161,17,57,115,98,18,125,57,36,137,12,135,113,27,100,94,214,44,165,39,121,6,202,158,160,98,98,181,56,253,180,102,148,115,33,155,252,142,208,146,137,0,213,46,153,148,13,204,214,168,147,189,17,82,184,130,18,144,160,166,228,1,211,61,102,219,112,22,137,6,10,114,110,178,64,84,80,46,68,239,228,84,240,32,125,96,183,181,55,210,12,9,75,67,239,219,50,249,89,205,32,97,84,98,21,60,214,108,62,167,197,198,22,190,139,104,96,171,196,177,245,242,190,235,63,33,215,127,40,161,73,63,89,44,154,77,252,182,196,172,227,249,188,125,104,250,153,110,100,240,94,39,25,59,130,67,176,174,136,199,80,185,84,109,115,247,139,163,128,117,168,18,167,50,8,84,244,196,84,87,195,146,77,147,244,62,146,5,16,157,84,68,129,236,222,65,19,30,120,60,205,169,232,87,78,170,40,141,129,33,20,93,133,92,200,57,117,213,5,139,157,110,228,183,232,169,57,231,170,175,143,18,213,86,100,153,151,177,229,226,136,59,91,146,200,194,13,137,232,117,41,27,166,43,54,93,173,171,77,52,210,66,53,149,39,13,244,128,3,205,103,234,132,182,228,210,182,133,77,107,108,97,26,147,203,242,46,75,147,220,184,46,100,78,173,0,201,165,58,2,65,162,244,217,26,52,52,5,247,162,215,107,224,182,132,230,156,134,119,6,18,174,36,49,50,208,234,239,214,118,196,78,103,147,150,232,242,180,64,183,160,171,231,151,57,161,239,97,87,108,65,217,233,230,156,242,148,170,163,12,54,91,194,125,58,253,111,157,48,25,137,105,44,201,197,243,117,158,85,209,143,241,143,182,199,65,198,123,112,178,90,176,90,122,0,142,160,19,71,84,107,39,156,186,232,39,248,252,220,90,131,163,20,52,67,106,93,242,7,54,169,139,42,26,145,191,145,191,123,84,116,24,184,44,226,38,5,172,69,95,91,162,75,120,47,60,80,182,174,176,113,124,59,227,151,192,228,53,224,7,8,148,97,98,24,183,183,82,171,41,64,70,253,28,171,254,167,182,156,110,174,147,10,152,29,217,56,184,171,69,244,84,175,139,118,99,207,146,200,1,178,212,35,119,138,195,208,89,231,238,243,140,175,243,196,111,105,128,50,172,166,52,178,163,118,56,28,121,26,162,201,178,17,219,54,127,140,53,197,65,46,25,139,101,36,114,11,175,19,247,14,206,63,255,108,212,2,253,36,196,186,149,6,90,66,25,132,26,31,180,164,149,193,22,233,240,116,35,210,197,51,14,121,140,159,34,6,110,154,113,142,74,129,230,60,108,74,199,74,18,199,194,214,213,46,104,83,182,29,21,155,100,56,248,173,44,115,97,162,18,242,108,246,89,100,28,81,141,65,245,134,170,80,184,75,245,73,75,207,3,31,133,3,0,153,213,250,218,32,222,122,186,81,155,103,11,212,203,154,60,115,166,11,142,26,18,12,247,167,195,233,163,12,187,237,244,209,13,253,237,163,135,210,4,174,174,90,121,250,89,167,141,225,208,145,215,17,199,150,211,2,81,44,60,35,67,88,27,182,133,66,52,152,29,28,93,245,17,24,56,117,60,186,168,139,20,254,159,228,34,155,71,102,215,64,116,190,216,209,139,141,166,27,141,52,139,190,215,234,118,109,7,120,18,132,29,201,3,87,159,219,183,43,171,47,75,24,243,30,120,131,186,117,28,95,56,88,249,161,94,139,179,158,173,77,52,116,182,232,206,108,95,152,210,250,12,27,150,215,38,46,165,125,58,124,12,8,188,125,180,157,125,59,12,41,64,210,126,130,84,196,217,150,199,211,79,25,175,184,162,53,114,152,17,97,242,59,236,57,107,183,95,238,217,248,146,46,171,171,186,18,231,227,64,134,146,44,43,244,150,255,136,163,114,83,118,199,126,244,154,195,43,234,192,22,205,18,108,71,40,12,160,139,210,223,132,0,146,109,55,65,119,36,62,27,202,62,94,35,59,58,68,108,86,182,61,254,102,55,24,137,213,41,171,47,78,54,151,201,40,134,166,79,122,158,149,105,3,173,16,119,202,181,166,38,49,60,123,134,203,250,176,163,255,162,5,33,159,87,89,1,93,101,119,11,234,214,181,253,187,207,86,75,63,38,138,21,252,16,10,86,180,154,137,203,190,2,63,11,26,92,54,124,38,187,134,103,216,110,182,237,75,149,251,228,199,180,157,27,187,193,58,6,67,233,23,228,200,221,238,188,195,125,59,120,240,220,217,205,195,158,146,118,74,209,47,195,214,118,194,126,156,106,100,214,157,239,196,231,190,243,83,75,85,158,11,155,34,110,171,8,87,49,208,189,66,111,251,105,48,141,58,200,76,58,221,149,54,93,48,33,115,67,17,167,145,87,69,48,21,234,145,160,78,151,198,55,189,219,24,141,71,204,14,205,166,225,124,195,207,234,188,170,25,21,218,244,177,97,188,93,139,27,105,10,140,70,61,3,26,27,211,200,54,118,231,196,92,95,25,135,143,183,253,23,202,214,224,176,57,127,155,251,3,103,146,241,238,249,123,51,43,92,100,172,185,143,113,233,159,235,47,234,190,225,176,141,255,45,78,88,148,79,196,114,102,128,87,85,210,33,92,22,99,81,224,223,226,124,161,115,254,177,15,63,175,233,39,100,103,208,226,165,139,166,29,108,66,136,18,167,154,106,96,238,82,194,137,103,36,90,242,177,143,241,166,252,40,207,204,99,163,58,52,46,162,116,71,49,158,49,198,164,201,135,198,137,134,42,89,52,188,14,199,158,142,71,238,172,127,237,112,107,236,123,91,106,57,34,228,197,157,235,185,112,176,125,237,155,72,11,23,76,35,189,79,39,46,178,60,167,11,239,1,133,235,192,89,81,145,156,62,208,188,201,34,84,24,95,73,232,220,127,113,136,27,180,204,37,100,17,151,90,228,214,237,233,39,154,66,206,16,51,88,80,37,147,127,172,113,132,124,77,144,137,89,170,250,36,78,112,86,131,170,70,140,129,129,158,100,212,100,212,166,86,235,169,98,24,27,78,146,58,241,53,216,100,155,182,8,13,218,52,1,163,27,221,183,152,170,110,143,52,81,79,182,138,34,131,173,121,71,1,125,148,30,24,15,116,172,72,82,136,28,137,40,221,11,23,142,108,34,94,203,212,220,15,138,205,218,85,6,3,219,89,204,21,169,148,176,97,79,210,142,2,29,81,103,255,164,133,65,152,21,116,15,224,180,218,61,76,223,131,253,161,151,145,111,168,26,134,206,171,146,1,24,170,0,239,169,247,120,137,0,37,161,69,131,199,1,153,212,148,79,27,56,48,158,162,187,71,83,173,225,140,190,130,82,9,22,216,93,37,85,132,26,240,26,246,179,100,109,114,145,31,185,231,153,212,6,52,142,206,196,211,121,243,132,213,33,234,110,100,149,238,190,224,21,148,91,149,36,122,180,91,7,67,58,182,101,59,97,30,143,169,137,115,187,88,136,75,142,36,189,39,81,136,15,241,50,167,249,127,86,88,111,209,112,158,27,37,34,79,64,111,40,66,211,138,64,228,244,157,30,255,254,76,55,56,39,125,47,115,109,131,21,11,170,48,157,19,163,166,202,172,3,221,186,115,100,238,31,43,169,75,33,133,187,159,171,46,66,142,27,33,232,62,15,45,204,251,135,189,222,138,125,253,251,67,121,253,234,189,57,148,107,246,139,62,121,133,43,94,21,125,221,227,195,224,227,64,203,83,118,99,118,203,164,66,175,215,68,173,54,183,133,54,45,183,99,11,83,209,111,19,201,126,207,25,137,255,158,17,95,248,252,47,207,26,255,202,119,141,58,87,203,75,245,206,247,65,234,145,7,58,182,215,130,116,2,121,148,16,186,51,91,253,133,143,67,204,179,16,121,164,22,233,162,221,105,54,138,147,233,228,48,144,247,66,201,214,29,20,152,196,25,255,251,158,50,106,221,51,145,163,137,162,220,241,236,163,235,193,141,147,102,240,64,39,181,175,208,4,110,213,194,243,122,125,53,214,247,202,32,240,0,34,132,204,202,241,74,151,199,228,121,147,125,195,119,202,26,141,78,126,109,237,160,114,90,237,186,227,251,141,29,183,13,7,190,20,254,36,62,116,189,234,193,244,94,171,26,74,79,176,138,187,197,204,99,23,171,0,116,211,112,48,192,222,63,244,242,34,120,191,255,21,46,111,189,55,178,31,70,28,118,11,47,135,66,111,214,32,106,215,152,34,248,244,160,243,98,202,12,209,131,90,52,39,240,203,236,3,109,31,192,159,14,191,127,220,169,67,56,234,40,142,71,219,239,135,163,150,101,58,14,65,194,47,197,19,185,246,103,126,181,92,66,31,64,142,39,150,231,218,161,232,157,228,181,251,182,31,129,123,30,162,244,253,83,194,177,69,17,217,151,251,190,136,223,78,120,26,121,79,20,228,65,61,114,5,212,215,190,94,234,105,110,238,52,148,21,76,19,55,213,200,94,182,57,141,40,1,67,77,125,128,138,106,138,131,225,239,156,244,58,14,144,90,111,120,106,180,142,139,61,231,144,64,91,19,122,136,13,107,255,5,35,1,210,187,98,51,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateEmptyHierarchyValueLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateEmptyHierarchyValueLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("a416b392-9149-46c8-b2a6-121bc2cb969e"),
				Name = "EmptyHierarchyValue",
				CreatedInPackageId = new Guid("e0b9d996-6f7e-4520-a678-da960c79be39"),
				CreatedInSchemaUId = new Guid("83526d74-74f9-4c6d-a095-476ee8d1bf5f"),
				ModifiedInSchemaUId = new Guid("83526d74-74f9-4c6d-a095-476ee8d1bf5f")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("83526d74-74f9-4c6d-a095-476ee8d1bf5f"));
		}

		#endregion

	}

	#endregion

}

