﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CaseActiveIntervalReaderSchema

	/// <exclude/>
	public class CaseActiveIntervalReaderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CaseActiveIntervalReaderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CaseActiveIntervalReaderSchema(CaseActiveIntervalReaderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("9b299706-707d-4ea1-bb1f-dd34d3b36ef1");
			Name = "CaseActiveIntervalReader";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("c4b72b51-b2ae-4127-a458-608f5464622c");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,197,87,75,111,227,54,16,62,123,129,253,15,172,246,162,0,174,220,115,98,171,72,157,7,12,36,217,52,118,218,195,98,81,48,210,216,102,43,145,14,73,185,112,139,252,247,14,73,81,146,233,71,188,135,182,201,33,226,104,94,156,249,230,27,133,211,18,212,138,102,64,102,32,37,85,98,174,147,177,224,115,182,168,36,213,76,240,143,31,254,254,248,161,87,41,198,23,100,186,81,26,202,139,224,156,220,49,254,186,35,28,139,162,128,204,120,80,201,45,112,144,44,107,117,186,177,202,82,240,253,111,36,28,146,39,215,92,51,205,64,161,130,249,237,125,146,176,192,80,100,92,80,165,200,57,25,83,5,151,24,125,13,19,174,65,174,105,241,4,52,7,105,149,7,131,1,25,170,170,44,169,220,164,245,249,22,52,201,154,148,137,152,19,103,78,148,166,186,82,36,167,26,84,226,141,7,29,235,85,245,82,176,140,100,54,242,225,184,61,83,198,189,121,94,81,77,109,94,59,137,89,193,3,96,61,115,231,255,251,76,112,77,25,86,147,204,133,36,106,5,25,155,99,112,165,177,89,176,216,152,52,105,210,184,234,166,217,91,73,182,70,165,78,162,46,112,207,101,230,239,113,91,177,220,190,157,228,196,189,232,45,64,95,184,39,229,159,222,186,38,63,9,81,0,229,100,42,138,202,84,239,243,26,100,94,193,123,230,111,238,210,159,128,231,174,42,245,185,46,209,163,20,43,144,166,201,88,39,60,104,108,13,228,71,10,133,45,84,68,47,129,84,10,235,131,149,226,174,153,7,234,97,37,216,160,10,154,227,236,168,113,171,187,242,217,144,103,212,30,55,202,225,209,21,160,185,191,239,128,47,195,59,5,184,97,80,228,238,242,214,238,200,213,167,30,8,25,54,238,20,16,72,68,165,224,197,166,193,1,249,45,171,159,46,142,103,133,215,67,180,85,153,22,210,230,102,33,112,36,181,9,199,65,165,5,251,11,251,72,9,135,63,9,67,7,148,35,227,224,144,153,118,13,21,32,42,37,204,71,209,161,241,137,6,169,195,237,177,94,174,168,164,37,225,72,104,163,168,218,106,68,148,62,7,93,29,14,172,246,126,99,42,23,85,9,92,171,40,53,136,104,142,91,86,53,246,15,101,28,7,80,216,78,168,79,174,152,125,192,11,12,177,156,200,112,125,34,94,126,199,183,105,27,239,172,6,80,224,106,20,56,115,224,106,250,135,239,219,140,103,226,179,245,58,244,125,78,227,179,83,176,119,15,122,41,114,117,10,246,198,75,200,254,32,21,103,175,21,210,60,82,11,182,213,194,176,96,115,200,54,89,225,57,244,212,222,41,81,201,12,162,212,164,220,250,104,201,249,120,243,92,44,220,62,85,201,31,80,18,165,83,199,224,153,21,89,173,93,15,18,116,37,185,74,159,143,93,163,179,31,94,54,254,82,195,129,183,237,206,215,11,82,162,171,204,21,83,154,241,76,187,44,98,187,184,54,237,114,36,238,182,125,226,80,64,194,244,61,6,44,45,207,153,84,250,186,0,211,91,108,179,51,253,242,195,87,92,176,122,182,89,65,238,236,126,49,68,53,52,22,105,188,227,207,161,197,230,199,148,79,174,113,150,92,22,69,12,62,66,234,104,187,87,11,190,37,12,25,141,182,210,173,227,186,90,117,34,127,3,24,79,97,155,39,215,11,162,89,9,72,52,110,34,187,141,155,75,81,218,161,189,243,109,61,6,75,223,218,217,1,119,97,247,29,39,172,153,212,21,234,77,174,57,142,161,164,47,5,12,113,246,192,120,241,44,145,154,117,181,77,28,42,246,205,190,195,226,236,177,144,160,170,194,244,202,176,232,126,157,122,186,123,108,78,226,134,17,146,96,49,251,48,190,27,206,111,119,177,175,169,36,160,94,235,80,14,179,211,108,9,37,253,185,2,185,9,200,45,233,42,220,83,78,23,32,251,36,218,170,114,84,39,214,194,92,106,147,125,11,25,12,134,33,147,203,188,134,87,28,77,189,82,116,150,24,141,45,15,136,149,247,236,175,157,202,62,235,16,175,123,131,155,241,158,228,173,185,117,96,212,110,88,129,245,86,70,61,54,231,49,174,83,13,78,250,43,211,203,71,67,46,96,84,98,39,196,175,92,36,28,166,4,55,243,147,60,8,125,253,138,8,193,34,125,49,85,114,177,206,39,249,185,123,250,154,76,212,13,227,180,136,250,4,119,45,156,213,197,251,175,98,63,129,18,197,26,242,255,41,252,35,197,5,247,111,4,247,145,77,96,116,223,14,136,251,222,245,161,118,56,26,66,129,67,11,78,112,168,26,76,70,103,26,67,31,201,37,223,196,103,205,40,238,18,242,190,237,17,58,233,239,238,139,250,83,219,132,252,174,245,215,196,233,225,255,13,64,179,37,169,55,81,203,106,108,247,158,173,85,47,100,26,187,27,183,4,142,43,66,61,79,72,248,19,90,36,118,190,209,206,167,176,119,191,120,135,118,199,132,156,209,58,183,140,229,230,253,116,143,59,28,114,36,89,36,19,211,118,31,98,212,220,52,185,103,206,49,249,209,27,7,95,108,201,184,146,18,107,107,164,38,163,250,232,29,32,237,159,55,150,117,128,38,15,199,205,22,241,97,74,77,178,142,179,235,63,111,221,61,219,97,246,61,59,182,150,117,69,111,255,0,78,40,65,74,16,16,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("9b299706-707d-4ea1-bb1f-dd34d3b36ef1"));
		}

		#endregion

	}

	#endregion

}

