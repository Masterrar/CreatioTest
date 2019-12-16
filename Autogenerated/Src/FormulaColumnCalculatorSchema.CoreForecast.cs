﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: FormulaColumnCalculatorSchema

	/// <exclude/>
	public class FormulaColumnCalculatorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public FormulaColumnCalculatorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public FormulaColumnCalculatorSchema(FormulaColumnCalculatorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("33798c1b-c2b3-469c-b5b4-8a4c497120e5");
			Name = "FormulaColumnCalculator";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("e0b9d996-6f7e-4520-a678-da960c79be39");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,181,88,75,143,19,57,16,62,7,137,255,224,205,30,182,35,69,157,213,30,201,3,65,230,161,104,129,29,49,3,23,132,144,233,118,102,172,237,180,131,237,14,4,148,255,190,85,126,116,108,119,247,176,23,46,147,113,185,92,207,207,85,229,174,233,142,169,61,45,24,185,99,82,82,37,182,58,95,139,122,203,239,27,73,53,23,117,126,37,36,43,168,210,239,255,122,250,228,199,211,39,163,70,241,250,158,220,30,149,102,187,121,178,206,47,168,166,29,226,90,84,21,43,80,152,202,175,89,205,36,47,58,60,175,120,253,229,76,12,109,217,237,68,221,191,35,217,16,61,191,162,133,22,146,51,213,199,241,166,225,249,45,147,7,94,176,215,162,100,85,126,249,77,179,90,161,125,29,187,174,43,241,153,86,252,187,137,5,236,194,254,108,54,35,11,213,236,118,84,30,87,110,189,166,85,209,84,84,51,69,182,66,238,224,95,82,136,170,217,129,199,254,196,44,57,178,80,140,209,74,9,82,72,182,93,142,127,30,254,124,227,255,247,218,132,28,147,25,202,251,112,193,182,180,169,244,75,94,151,96,124,166,143,123,38,182,89,207,129,201,148,188,129,148,147,37,105,247,192,109,173,80,15,154,189,54,86,223,193,121,100,155,124,4,225,251,230,115,197,11,82,84,84,41,18,177,157,197,146,103,164,71,25,249,97,2,54,250,93,178,123,240,133,24,85,178,193,212,168,103,228,198,200,181,28,105,76,13,97,83,115,205,49,248,16,85,74,106,246,149,112,56,79,107,0,171,216,18,253,192,76,12,93,252,6,12,27,207,86,214,242,188,85,51,75,245,44,246,84,210,29,169,193,225,229,184,81,76,130,157,181,5,236,120,117,7,106,144,6,249,244,196,124,49,51,39,140,0,23,157,1,245,217,187,72,28,137,165,79,48,64,163,209,40,97,90,38,108,8,202,209,201,133,146,213,165,141,102,28,218,43,206,170,18,131,42,249,1,96,104,55,247,118,65,194,204,220,160,229,138,124,50,30,48,205,164,193,124,203,122,206,162,241,228,45,219,11,197,193,145,35,249,84,36,148,248,220,13,92,107,81,134,252,251,132,210,175,231,246,129,49,29,30,83,49,97,192,58,86,85,145,109,209,122,158,56,143,153,121,167,121,5,112,2,40,125,218,38,148,136,221,216,227,172,136,117,95,214,205,142,73,250,185,98,11,235,236,202,251,168,230,143,39,231,70,10,96,68,85,207,236,255,133,102,165,79,145,208,102,73,18,16,36,203,31,228,30,236,33,222,24,133,139,83,42,98,56,121,29,194,210,128,119,212,73,42,121,254,156,100,93,234,146,172,241,18,217,178,122,132,42,174,23,131,202,86,153,17,61,194,11,27,220,248,23,242,30,226,87,235,44,189,98,211,196,215,201,100,50,239,120,214,129,87,135,224,61,74,97,103,61,234,80,251,60,74,101,254,18,79,134,128,159,174,189,63,201,125,176,238,164,196,199,242,147,8,254,165,78,37,247,50,89,182,160,139,201,22,114,9,235,99,128,139,88,127,133,63,182,8,216,191,203,21,9,18,17,132,31,108,76,66,139,102,26,82,22,148,215,182,131,111,202,190,200,245,84,21,251,171,18,68,171,16,200,176,217,185,1,168,221,235,114,34,34,59,28,109,106,173,118,75,236,244,189,134,117,202,102,135,224,205,75,203,169,181,179,67,237,201,104,42,114,149,181,134,12,149,210,215,76,63,136,193,70,119,16,28,146,71,15,12,33,162,178,48,184,72,129,81,0,233,190,237,198,56,202,55,53,224,66,219,147,38,68,83,199,30,246,95,175,9,217,8,248,208,14,126,37,82,134,52,78,163,60,59,183,55,48,95,174,252,184,136,139,214,176,3,149,228,64,171,198,68,13,113,125,193,13,84,97,104,89,0,190,97,194,155,18,251,11,17,51,214,141,64,12,163,197,3,201,240,108,32,19,70,166,94,21,35,190,37,89,176,145,35,16,242,203,47,13,140,164,89,96,160,33,219,10,63,105,207,154,195,214,64,156,86,53,133,185,236,111,118,140,228,189,199,237,224,200,8,230,39,205,235,134,205,29,225,228,126,209,96,152,224,152,100,48,216,89,77,155,210,249,125,221,240,178,71,234,60,56,138,241,5,110,19,230,252,138,75,165,255,145,110,26,206,56,6,0,238,47,119,175,16,35,218,59,217,209,57,105,229,150,172,224,59,90,185,17,222,232,4,21,127,206,3,239,141,218,223,192,202,166,170,34,39,195,19,200,100,77,238,58,109,130,247,162,236,113,111,26,234,205,239,196,173,201,116,182,6,143,26,201,54,245,86,0,84,193,117,78,107,237,136,173,233,86,190,253,235,189,56,56,107,210,219,150,183,216,13,109,0,172,90,227,156,200,54,213,100,9,33,104,93,149,12,244,214,198,253,121,160,211,160,15,147,128,162,54,245,181,20,205,62,206,142,7,172,23,128,85,27,99,233,228,250,208,25,149,83,75,187,4,224,232,163,1,69,42,59,247,123,142,245,173,248,218,207,103,54,172,161,125,215,217,20,142,77,13,117,178,166,149,143,11,220,184,204,59,156,220,223,96,240,49,87,56,88,155,74,151,140,68,88,237,220,174,45,45,57,192,205,198,161,147,21,176,26,158,126,44,122,80,168,44,209,225,220,245,137,115,23,20,177,238,161,152,20,183,11,86,65,23,136,138,91,219,15,32,7,31,62,194,132,25,9,35,167,232,154,37,183,69,245,225,233,26,123,97,204,214,177,59,86,210,170,104,161,248,242,232,91,87,196,56,237,24,224,142,158,122,171,179,73,103,143,204,56,115,164,56,39,218,171,121,44,207,29,19,130,114,237,95,253,61,97,185,96,208,87,236,59,214,237,101,29,197,125,85,220,118,122,44,224,206,252,246,242,249,186,231,219,195,43,174,180,109,55,254,118,141,54,231,143,46,190,17,53,18,140,183,253,13,33,26,225,195,165,193,224,52,196,136,135,134,179,229,212,147,7,168,80,168,191,213,140,198,221,227,157,179,45,17,117,133,170,115,115,31,95,30,109,5,93,218,6,105,175,167,151,16,69,193,136,194,32,132,50,39,17,204,219,60,218,93,80,216,109,204,230,116,126,203,48,38,25,69,189,116,210,130,113,18,85,246,88,88,79,141,143,24,220,28,101,170,142,141,18,220,237,249,0,111,208,222,58,16,136,142,153,72,97,119,136,5,76,146,62,226,126,206,19,79,48,176,216,205,159,124,54,56,143,83,63,251,24,51,248,133,235,15,229,26,198,255,253,194,114,30,73,199,171,155,243,120,26,126,84,49,103,108,135,80,45,225,181,40,249,150,195,104,26,204,180,103,149,41,247,130,125,43,216,222,188,157,237,7,34,247,65,239,141,208,155,221,190,98,248,54,96,229,165,103,26,175,22,179,246,68,242,97,39,253,118,114,238,155,61,155,103,227,60,100,122,159,2,249,250,129,21,255,250,71,202,229,110,175,143,25,134,71,108,179,225,167,131,121,12,180,187,8,184,248,35,206,168,183,131,69,253,54,57,209,15,15,67,61,253,7,149,121,203,30,27,22,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("33798c1b-c2b3-469c-b5b4-8a4c497120e5"));
		}

		#endregion

	}

	#endregion

}

