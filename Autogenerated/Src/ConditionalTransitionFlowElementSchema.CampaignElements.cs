﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ConditionalTransitionFlowElementSchema

	/// <exclude/>
	public class ConditionalTransitionFlowElementSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ConditionalTransitionFlowElementSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ConditionalTransitionFlowElementSchema(ConditionalTransitionFlowElementSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("7834dd6b-aacf-4fd5-8228-946288744800");
			Name = "ConditionalTransitionFlowElement";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d0bba11f-3986-4819-81ab-1d3ddbfc1f48");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,86,81,111,219,54,16,126,47,208,255,112,245,94,228,33,149,135,98,79,117,157,32,181,147,214,192,182,102,115,178,61,22,180,120,178,89,80,164,74,82,78,141,52,255,125,71,201,182,68,75,113,213,232,73,162,120,223,125,119,247,221,145,138,101,104,115,150,32,220,162,49,204,234,212,197,83,173,82,177,42,12,115,66,171,151,47,30,94,190,0,122,10,43,212,10,22,91,235,48,27,55,151,154,134,6,227,217,123,250,91,253,255,197,224,138,32,96,42,153,181,111,129,112,185,240,152,76,222,26,166,108,249,126,45,245,253,149,196,12,149,219,155,141,70,35,120,103,139,44,99,102,123,94,47,53,204,193,29,236,33,55,58,65,107,1,43,144,184,129,49,10,65,242,98,41,69,2,137,103,243,67,50,64,124,89,150,51,177,82,245,255,155,202,215,129,175,71,125,216,211,14,34,214,202,58,166,28,69,125,99,196,134,57,108,238,202,171,37,72,252,46,176,206,248,52,146,137,99,137,187,101,75,137,127,81,85,96,2,131,221,218,96,28,248,64,197,43,55,93,158,137,98,142,198,9,44,93,107,135,137,67,222,229,252,90,75,142,230,35,74,218,14,159,211,198,87,224,173,163,24,251,229,75,5,162,12,147,212,163,83,112,107,164,157,72,97,25,76,39,131,38,254,96,116,30,31,65,142,218,152,249,158,110,200,45,248,120,168,183,251,103,133,14,38,231,33,125,184,184,128,40,92,153,128,194,251,0,40,26,14,199,33,148,237,130,154,192,134,201,2,27,91,31,159,89,138,82,123,61,19,59,195,84,40,180,32,210,166,208,241,27,38,69,249,38,44,112,148,108,139,188,79,86,43,213,47,181,150,48,183,179,202,110,225,152,113,240,224,243,55,246,145,143,195,184,78,114,35,0,170,59,112,182,181,176,196,148,122,190,44,125,210,104,207,148,250,168,230,219,159,164,160,190,43,29,204,213,204,195,63,159,96,161,132,3,226,6,185,15,148,212,249,181,64,179,133,123,225,214,224,68,214,160,219,159,93,99,100,44,144,240,72,247,126,96,148,14,239,188,191,250,237,57,196,201,144,64,65,112,26,45,34,21,164,190,93,83,25,76,180,225,62,231,187,121,80,9,25,156,31,21,253,233,127,40,4,117,150,144,14,205,156,63,205,240,180,166,255,68,183,214,252,244,88,243,85,252,128,110,87,200,143,186,48,54,26,30,119,174,65,87,24,213,72,217,100,242,195,4,199,165,40,46,2,137,252,10,111,126,167,89,221,88,122,170,89,247,244,54,154,242,112,245,205,81,156,255,145,28,110,73,13,7,199,109,158,212,131,209,171,163,190,249,254,61,160,64,204,127,107,217,213,49,30,205,153,199,54,254,34,89,35,47,36,242,153,231,247,138,166,85,33,101,39,226,134,25,248,162,151,7,131,79,138,70,84,228,205,124,24,195,0,104,220,109,190,155,28,101,89,200,184,85,168,14,179,61,62,245,188,67,159,51,93,84,70,100,31,178,137,47,121,133,28,189,110,250,233,2,173,79,213,191,125,107,198,151,138,71,131,133,195,124,170,179,92,162,243,112,131,97,60,183,127,208,137,251,201,92,125,45,152,140,166,90,22,153,138,111,152,161,19,146,132,28,29,51,106,141,245,199,159,83,67,213,31,39,244,176,160,123,70,226,71,139,111,193,221,199,164,236,173,248,42,203,221,54,46,137,218,104,223,104,195,118,228,23,101,125,219,235,111,131,19,42,166,202,92,55,188,252,251,38,58,190,34,156,29,110,8,213,198,193,217,161,191,207,224,206,150,113,40,50,165,64,142,211,226,101,23,196,112,74,117,157,165,218,121,158,115,95,36,21,128,245,173,65,239,81,211,113,141,57,49,72,255,41,219,206,238,70,190,91,51,71,35,41,145,5,167,35,149,241,195,33,37,245,74,36,61,198,103,185,94,181,178,61,127,207,108,112,203,185,203,189,2,233,126,67,199,157,215,16,93,94,234,51,134,41,14,105,89,144,250,184,177,241,187,209,30,172,235,234,163,55,116,157,166,51,160,18,230,212,32,193,151,89,111,75,113,73,92,226,96,199,81,222,159,28,114,79,238,107,201,191,255,205,231,240,59,252,69,203,255,3,121,171,59,179,100,12,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("7834dd6b-aacf-4fd5-8228-946288744800"));
		}

		#endregion

	}

	#endregion

}

