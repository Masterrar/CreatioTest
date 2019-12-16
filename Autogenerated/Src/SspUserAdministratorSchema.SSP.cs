﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SspUserAdministratorSchema

	/// <exclude/>
	public class SspUserAdministratorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SspUserAdministratorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SspUserAdministratorSchema(SspUserAdministratorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("623e144d-2bff-4944-aa0a-346ec2a0efa2");
			Name = "SspUserAdministrator";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("7cc31540-fa76-4c79-9b86-a6eabd8e662c");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,237,90,221,115,219,184,17,127,214,205,220,255,128,227,189,80,51,30,250,61,142,213,202,178,47,85,199,177,61,86,210,60,116,58,45,76,66,22,27,138,212,17,164,115,58,143,255,247,91,44,0,18,0,65,138,74,220,187,206,180,47,137,72,238,23,22,191,253,192,194,57,221,50,190,163,49,35,31,88,89,82,94,172,171,104,81,228,235,244,177,46,105,149,22,121,180,90,221,125,255,221,243,247,223,77,106,158,230,143,100,181,231,21,219,158,57,207,192,147,101,44,22,12,60,122,199,114,86,166,241,32,205,237,195,191,225,231,251,34,97,89,135,238,58,205,127,110,95,154,118,109,183,69,238,255,82,178,190,247,209,229,69,239,167,171,188,74,171,148,113,31,193,39,246,208,209,40,13,92,177,170,130,39,78,206,9,74,113,252,181,231,154,0,24,129,245,199,146,61,194,7,178,200,40,231,111,200,138,239,62,114,86,206,147,109,154,167,188,2,174,162,68,186,211,211,83,242,150,215,219,45,45,247,51,245,140,60,100,93,148,36,46,25,21,66,73,92,228,21,141,43,66,243,132,212,32,136,71,154,247,212,96,78,243,138,149,57,205,72,140,18,124,74,201,27,178,244,27,51,121,70,131,26,203,239,202,98,199,74,225,168,55,226,119,5,59,199,18,73,226,26,141,47,132,72,97,103,46,119,59,106,8,77,11,39,59,45,9,233,23,13,185,251,248,76,30,89,117,70,94,164,194,93,153,62,209,138,145,119,117,154,144,127,114,190,187,47,138,234,93,89,212,187,101,114,54,96,211,60,203,200,174,40,43,112,9,122,141,60,10,158,131,166,161,154,149,165,133,136,96,152,76,192,40,114,142,212,147,137,99,7,249,225,28,25,163,171,237,174,218,75,146,201,159,92,107,213,251,55,238,123,128,149,237,1,8,168,74,124,199,93,250,152,167,154,48,20,100,31,246,59,38,98,116,122,134,242,56,90,229,17,249,68,179,26,99,100,242,50,224,37,0,175,212,82,165,25,70,134,196,207,65,55,117,249,186,111,236,125,252,145,229,137,132,151,141,53,88,54,224,176,142,1,136,128,182,93,253,144,165,241,128,193,75,112,71,74,179,244,87,80,64,73,206,190,144,20,248,105,14,9,173,88,147,106,195,128,133,49,17,61,235,243,192,135,246,224,116,54,188,70,180,192,27,64,161,3,212,218,122,156,42,156,56,68,231,14,153,220,182,174,183,206,113,49,157,247,225,212,220,195,62,39,190,103,213,166,72,68,176,98,176,12,248,111,33,210,10,168,51,189,164,117,130,107,133,119,74,22,23,101,210,227,30,124,179,163,37,221,146,28,74,201,121,160,210,211,50,9,102,11,149,169,210,132,65,158,93,167,172,140,222,158,34,173,159,85,252,27,204,48,121,136,159,195,196,52,142,139,58,215,0,15,102,115,249,44,195,122,80,101,201,170,186,204,185,84,100,17,234,47,157,60,35,189,36,24,66,124,110,22,121,66,0,11,34,43,11,163,78,36,177,109,89,15,12,56,86,146,14,54,156,192,159,239,118,198,211,202,195,35,225,243,68,75,33,177,217,54,23,61,240,42,244,105,212,73,195,160,139,160,120,93,178,53,212,234,122,155,255,77,36,13,141,57,155,236,6,22,44,212,192,127,158,175,11,237,32,32,105,156,229,83,102,60,136,76,134,10,129,39,132,250,53,117,63,70,194,120,143,144,57,172,229,73,112,65,222,232,49,70,173,87,72,209,210,205,228,233,183,108,81,103,128,7,134,139,176,43,191,200,200,104,170,147,2,78,72,0,33,39,130,67,241,6,39,70,33,240,185,241,14,75,146,2,47,106,178,225,227,179,140,62,49,189,37,18,177,214,222,71,138,201,169,151,79,69,131,99,211,175,203,252,190,200,152,68,181,72,76,2,210,248,80,194,235,22,189,22,192,4,25,178,121,96,166,228,29,141,99,215,55,141,142,49,120,52,136,77,83,18,149,108,59,94,244,211,223,227,138,129,71,46,189,159,167,245,127,191,143,237,90,205,61,14,246,167,137,102,135,90,133,161,102,179,219,16,229,132,33,6,71,133,195,224,238,217,56,53,125,92,242,255,177,212,62,203,28,103,182,167,133,183,50,199,206,8,68,221,117,26,223,209,248,51,125,100,92,100,160,80,213,229,101,254,148,2,15,138,207,215,133,246,102,186,38,161,126,7,199,138,152,229,156,9,182,104,201,111,138,234,166,206,178,219,18,67,51,156,106,22,29,82,2,216,30,19,158,137,79,30,121,145,235,126,49,131,178,83,187,35,203,126,193,199,59,249,163,219,210,161,91,70,150,251,67,221,146,174,246,230,206,224,130,198,86,119,189,248,96,118,3,254,169,177,207,199,131,9,88,145,208,138,126,117,181,149,93,214,83,90,86,53,116,232,24,32,247,176,56,72,20,37,150,221,225,125,54,162,75,28,202,218,106,221,108,214,162,173,216,205,59,65,113,131,117,187,121,229,164,99,11,206,110,72,91,200,23,204,243,193,112,243,196,167,101,137,248,194,167,61,237,96,116,207,178,130,38,230,190,45,104,188,233,214,31,59,12,187,248,221,25,224,3,87,121,34,170,241,237,89,19,66,22,19,156,109,114,8,156,38,94,186,182,206,147,68,152,133,241,17,119,48,62,162,24,232,101,156,168,35,146,169,127,234,137,52,35,201,15,29,110,96,177,92,103,158,110,159,56,50,2,168,198,70,219,114,142,105,54,7,218,211,67,113,0,102,43,72,93,236,27,100,134,102,13,233,169,211,0,146,21,19,0,208,117,26,31,156,237,152,70,178,180,134,193,106,254,17,218,149,0,86,54,141,126,42,139,109,104,159,4,166,209,156,75,162,169,220,150,232,211,134,149,172,225,179,187,44,32,95,242,171,159,97,17,161,148,31,225,193,46,236,180,94,83,45,109,158,39,141,44,111,91,216,232,237,23,220,153,252,116,26,204,232,182,124,164,112,130,195,148,229,213,237,164,128,190,133,180,174,159,18,202,149,111,123,155,50,249,57,186,250,133,197,53,100,131,152,102,180,124,43,182,112,102,119,18,253,184,45,208,238,95,101,170,205,100,233,145,199,164,255,44,112,175,77,85,94,176,170,19,144,76,37,186,34,190,30,62,213,22,105,148,222,222,137,77,50,52,53,176,24,133,217,37,200,45,255,90,164,66,146,225,81,53,225,218,43,14,80,162,25,110,27,157,118,111,105,224,194,140,156,255,135,198,171,132,134,42,87,35,130,3,142,7,196,61,68,85,133,221,225,28,55,193,160,154,143,127,40,62,238,160,171,97,193,204,20,199,145,142,195,185,86,87,215,81,147,10,17,120,150,161,228,203,38,141,55,228,75,154,101,228,129,233,121,41,67,243,197,224,74,89,109,202,214,229,65,156,51,46,210,60,177,228,193,78,225,73,88,245,62,252,98,143,129,120,13,77,84,83,254,187,107,179,79,35,109,164,138,186,223,165,6,56,152,189,178,27,206,146,72,133,179,124,232,158,144,157,8,253,148,86,155,191,0,66,121,40,152,238,139,47,215,69,252,89,188,8,53,6,39,226,12,24,118,208,119,66,250,80,39,233,229,88,192,37,19,51,2,160,80,1,106,38,16,145,28,52,144,239,132,203,25,52,159,220,227,4,9,107,249,91,194,122,210,117,130,6,116,104,54,44,67,64,214,123,135,71,0,78,30,246,100,153,244,13,37,191,2,179,32,172,15,177,38,170,28,4,1,151,4,16,214,42,15,124,254,123,225,50,102,251,219,140,253,7,111,254,98,195,226,207,4,156,104,229,45,246,11,184,126,44,4,14,78,79,117,233,182,84,140,237,68,31,138,34,147,86,46,215,120,110,42,170,43,97,93,104,204,63,255,55,154,208,111,171,177,66,171,87,155,204,68,126,225,232,220,111,109,51,201,185,121,41,117,176,174,234,81,129,30,226,31,51,37,96,91,154,102,193,12,255,243,94,94,142,46,152,199,116,170,222,235,134,67,135,43,185,76,197,122,177,191,18,38,107,76,163,253,125,245,81,128,92,95,197,118,230,246,120,175,188,95,193,1,125,75,223,211,28,206,174,165,24,254,44,213,213,148,170,204,129,82,11,219,46,205,144,108,110,108,200,221,214,158,235,31,135,26,20,198,231,48,192,53,1,196,112,57,7,104,205,234,74,157,41,72,31,15,34,87,137,143,174,217,186,186,93,223,167,143,155,106,91,112,248,25,6,127,14,166,7,36,224,5,122,185,101,66,235,154,102,156,185,244,98,226,106,126,80,208,215,223,245,204,189,149,57,18,222,56,234,69,132,30,61,4,75,2,207,72,107,0,212,181,26,241,40,54,161,216,91,132,21,56,237,113,189,49,59,234,14,146,181,228,49,35,100,200,192,127,255,135,26,98,226,4,255,229,112,135,173,51,129,48,153,255,190,206,226,134,183,248,235,184,11,150,223,72,215,30,131,53,49,10,173,120,104,249,147,164,121,151,116,98,134,54,169,232,67,198,212,239,175,77,2,150,189,129,2,184,82,35,146,187,117,221,98,40,28,145,51,38,151,41,62,194,230,168,19,192,9,41,240,15,111,102,34,118,146,20,255,22,71,21,230,1,90,181,244,201,51,209,214,6,122,68,71,94,78,172,143,184,136,19,3,95,242,171,154,143,99,155,248,131,181,168,232,39,86,197,27,81,234,47,47,194,214,168,182,105,156,216,228,253,249,207,165,132,159,88,24,49,25,137,85,98,6,209,180,230,238,72,105,234,98,30,127,58,158,198,151,56,191,119,118,173,217,47,159,60,129,218,35,228,89,251,223,93,181,153,49,91,75,35,227,181,49,203,78,198,201,105,45,244,203,193,180,210,35,201,184,133,84,211,216,131,93,238,37,180,39,127,116,210,61,156,70,164,149,199,102,221,223,39,47,188,74,90,24,31,38,175,155,63,134,210,199,80,246,120,105,111,34,142,75,29,54,181,220,215,241,231,241,36,81,131,165,230,206,160,42,244,159,144,89,183,8,175,118,70,79,147,127,153,135,244,163,254,254,197,30,45,201,107,134,111,27,48,169,107,28,176,214,146,141,26,135,135,2,131,55,220,77,177,21,29,52,109,15,162,249,192,116,193,219,211,52,228,61,23,221,253,183,208,135,56,71,28,215,105,254,8,205,16,94,128,82,57,50,193,191,234,169,104,85,143,30,218,124,85,74,75,185,26,108,180,55,176,93,3,250,182,84,218,45,244,205,27,158,21,178,216,25,14,79,251,90,147,121,226,169,143,159,216,168,179,174,119,38,211,76,90,194,70,153,103,54,227,30,138,91,46,85,235,58,35,153,218,55,133,241,255,205,156,124,107,191,132,119,191,1,74,22,125,121,24,45,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("623e144d-2bff-4944-aa0a-346ec2a0efa2"));
		}

		#endregion

	}

	#endregion

}

