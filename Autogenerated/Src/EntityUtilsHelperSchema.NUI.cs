﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: EntityUtilsHelperSchema

	/// <exclude/>
	public class EntityUtilsHelperSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public EntityUtilsHelperSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public EntityUtilsHelperSchema(EntityUtilsHelperSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("012573d5-4a1d-467e-84b4-9ca561534f11");
			Name = "EntityUtilsHelper";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("1b48d10c-73f9-465d-8c06-a582b79b2f43");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,237,90,91,111,219,54,20,126,86,129,254,7,214,3,10,7,48,156,61,47,137,129,198,73,58,3,189,173,78,183,135,97,24,104,137,174,185,72,148,71,82,78,189,34,255,125,135,23,137,23,81,78,130,181,216,48,244,165,142,201,115,227,119,174,164,203,112,69,196,22,231,4,93,19,206,177,168,215,114,58,175,217,154,126,108,56,150,180,102,79,159,124,126,250,36,107,4,101,31,209,114,47,36,169,78,162,239,64,95,150,36,87,196,98,250,146,48,194,105,222,163,89,188,117,75,190,166,170,170,89,122,135,147,161,245,233,37,147,84,82,34,128,0,72,190,227,228,35,232,70,243,18,11,241,3,210,155,251,15,146,150,226,71,82,110,9,215,68,199,199,199,232,84,52,85,133,249,126,102,191,155,109,148,43,62,180,174,57,186,173,249,141,82,119,75,229,6,17,45,103,218,242,30,123,204,219,102,85,210,220,50,38,244,101,159,181,206,206,178,43,74,202,2,76,123,199,233,14,75,98,54,183,230,11,226,4,23,53,43,247,232,131,32,28,160,103,6,74,244,123,19,124,63,177,34,9,43,140,212,80,5,16,10,201,155,92,214,92,41,210,6,26,138,224,228,11,6,192,225,146,254,69,4,194,136,145,91,68,129,15,51,240,127,189,70,114,67,236,161,78,5,129,63,57,89,159,141,122,231,27,29,207,38,173,96,227,30,197,39,182,36,167,107,74,10,164,236,70,121,103,248,52,128,206,152,179,197,28,87,136,65,236,157,141,194,99,142,102,158,234,16,17,208,219,89,11,66,181,12,45,210,186,163,103,232,56,66,52,212,116,132,84,96,103,89,132,51,58,67,61,224,179,236,206,250,108,72,147,21,118,119,216,73,175,137,220,212,38,16,106,9,210,73,145,112,81,187,48,135,192,144,224,166,2,75,12,112,182,41,166,3,53,175,183,123,0,126,218,49,31,134,88,212,13,207,137,177,122,81,140,102,215,202,95,122,13,209,98,130,110,55,52,223,104,153,70,25,21,168,164,236,6,92,169,18,33,128,186,39,26,12,107,42,246,6,254,54,98,205,119,189,169,45,85,130,186,148,50,156,224,218,132,93,203,124,67,42,172,5,29,207,188,131,29,208,61,192,174,237,208,6,216,144,54,153,140,132,38,153,160,53,175,43,123,102,125,220,91,90,150,104,165,76,223,66,248,246,143,203,137,108,56,19,179,94,78,184,186,23,133,102,203,97,210,220,186,26,237,40,151,13,46,81,204,140,94,18,185,244,142,226,118,198,47,27,90,160,208,123,19,4,121,174,16,117,200,235,108,204,50,187,158,70,165,141,246,29,230,150,226,167,134,240,61,68,187,42,2,62,181,94,31,71,89,49,245,41,94,99,134,63,18,62,25,82,165,51,38,243,180,76,95,20,197,139,178,52,36,115,109,183,24,39,200,174,104,41,9,23,138,124,236,175,155,84,48,187,191,64,32,189,83,14,34,138,116,108,22,161,143,128,211,168,168,217,245,126,11,253,225,79,192,121,146,64,40,64,242,200,90,96,188,229,163,2,93,76,246,124,17,33,114,228,215,133,111,9,252,95,78,96,95,37,101,112,32,178,40,196,104,6,81,70,149,67,32,37,215,58,138,16,56,7,186,178,114,131,133,225,127,90,12,38,104,113,201,154,138,112,188,42,201,105,189,250,3,52,40,155,45,52,223,106,197,96,173,248,138,22,140,32,177,173,110,231,137,175,93,162,112,89,38,134,189,233,18,239,200,120,85,215,96,150,250,247,72,133,116,165,135,23,93,19,226,50,96,242,51,76,251,131,245,204,50,244,179,104,112,198,179,201,7,34,111,68,183,112,249,9,208,84,249,91,144,45,140,92,132,229,123,4,39,170,115,125,115,241,140,241,25,251,57,184,171,33,177,212,145,141,13,99,243,97,171,78,155,12,196,67,230,126,96,193,209,0,172,9,42,209,150,49,149,61,182,148,173,246,104,135,203,6,186,131,46,102,210,213,243,67,37,246,17,8,7,108,186,160,26,205,65,245,180,181,222,90,242,152,50,10,71,73,201,150,245,63,150,204,225,26,1,84,76,134,221,174,91,246,26,94,80,252,109,195,147,245,125,226,215,115,175,227,189,39,107,194,137,186,254,120,125,239,176,4,146,110,87,206,183,166,77,185,14,26,123,180,127,66,112,107,112,159,73,71,168,138,169,46,229,193,214,159,53,184,109,180,250,14,159,216,34,141,58,55,77,144,238,30,61,213,97,183,8,192,233,122,75,124,224,54,35,58,225,211,37,145,23,45,171,181,202,22,46,56,63,193,224,170,177,234,37,22,98,202,2,99,167,70,242,212,214,250,86,122,70,215,104,252,204,182,225,133,208,98,231,101,205,136,234,89,29,81,6,247,76,73,89,67,140,58,149,147,234,227,2,34,67,115,168,2,171,227,196,125,59,107,123,123,64,116,226,148,6,228,160,250,85,93,223,52,91,167,210,244,75,43,69,19,158,132,59,5,21,219,18,251,94,106,9,130,110,173,119,20,160,206,164,121,184,17,177,245,229,134,220,23,201,253,86,136,58,154,37,52,108,103,161,191,221,1,179,160,0,130,252,7,52,248,150,53,83,141,105,97,43,248,249,94,9,30,247,2,200,182,72,91,110,147,93,43,115,37,247,138,200,124,115,5,85,235,226,124,220,11,96,71,237,129,10,38,91,94,48,198,131,99,76,130,136,123,103,102,189,185,3,197,73,235,99,253,56,161,129,47,66,217,119,136,148,130,56,180,67,195,131,212,136,52,69,113,115,143,181,135,36,165,67,201,153,104,63,131,20,63,96,201,196,15,233,78,202,32,119,90,251,36,17,224,157,172,116,158,247,166,95,151,12,94,232,219,180,220,61,24,97,31,11,93,134,226,146,112,78,25,248,216,101,140,203,45,109,196,179,179,100,133,3,93,65,200,233,228,56,242,242,238,30,184,13,72,187,0,151,24,152,22,153,40,200,84,249,93,237,37,121,193,57,86,25,109,176,192,66,47,254,250,155,95,35,28,25,28,131,53,101,57,100,224,57,16,138,190,125,29,255,96,192,7,82,150,18,106,65,53,112,76,101,161,33,136,67,211,124,220,61,234,209,109,232,81,180,155,134,213,120,34,16,102,133,158,38,236,205,29,102,154,240,125,211,150,197,135,180,245,120,186,11,7,138,244,144,103,230,129,127,255,97,224,43,15,98,143,121,119,120,8,108,174,189,136,120,158,122,192,8,215,206,75,246,209,193,66,168,34,161,59,239,97,145,67,166,204,94,81,33,149,200,254,112,40,190,216,75,70,171,131,22,230,119,12,179,133,176,148,48,123,85,160,89,220,35,74,188,101,229,126,161,185,70,179,171,18,171,39,125,44,149,172,28,18,2,50,64,135,144,254,149,226,33,178,219,39,15,19,47,162,41,181,117,237,155,87,244,36,98,158,212,47,168,110,254,16,232,167,166,168,183,227,231,76,165,229,62,253,248,49,48,211,222,247,40,18,187,127,130,20,128,167,173,190,1,87,90,170,222,107,9,50,85,210,170,80,215,101,228,227,9,219,107,12,229,207,127,84,169,240,118,11,170,44,51,220,28,134,79,223,14,210,170,50,7,98,159,63,119,38,64,71,122,3,38,188,229,151,213,22,6,42,215,82,236,187,129,211,119,226,202,166,253,105,77,79,230,197,234,242,19,201,27,9,177,147,154,246,68,195,201,197,185,91,242,52,72,190,239,10,187,147,50,93,74,204,229,53,199,76,96,203,209,214,239,224,70,144,134,58,190,33,120,78,232,13,169,222,203,153,72,62,155,117,141,50,70,208,19,149,165,89,1,139,225,215,184,56,22,123,193,22,203,245,227,205,61,240,116,230,197,77,242,11,219,132,238,51,202,179,196,71,44,109,5,92,84,26,232,0,112,133,248,222,135,49,158,69,156,168,65,175,199,190,118,58,124,193,150,54,74,245,71,222,76,82,87,147,1,44,30,120,65,201,6,174,228,225,93,60,178,186,183,48,24,61,189,123,147,83,236,189,86,69,210,60,34,175,102,46,138,120,240,13,38,209,224,146,106,25,59,185,154,55,210,114,144,221,149,27,239,109,116,81,76,175,235,165,46,106,227,163,137,47,221,91,239,7,225,93,191,182,168,255,52,64,147,197,229,14,229,24,238,138,169,130,244,30,226,106,133,243,155,100,77,146,27,94,223,6,55,139,59,255,217,53,42,159,233,121,211,172,134,139,176,246,55,154,34,63,94,96,33,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("012573d5-4a1d-467e-84b4-9ca561534f11"));
		}

		#endregion

	}

	#endregion

}

