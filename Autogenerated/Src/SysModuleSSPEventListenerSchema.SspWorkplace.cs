﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SysModuleSSPEventListenerSchema

	/// <exclude/>
	public class SysModuleSSPEventListenerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SysModuleSSPEventListenerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SysModuleSSPEventListenerSchema(SysModuleSSPEventListenerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("ff04ed70-ba1a-4a88-8f8b-7167d956ddc8");
			Name = "SysModuleSSPEventListener";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("9735f166-4b01-4c20-b58c-0bd002ae38b1");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,84,193,78,219,64,16,61,7,169,255,48,184,23,91,162,246,29,146,72,41,130,42,18,20,212,64,123,168,122,216,216,227,176,149,189,235,238,174,211,186,192,191,119,188,107,59,118,72,160,168,61,197,217,157,247,230,205,155,157,17,44,71,93,176,24,225,6,149,98,90,166,38,60,149,34,229,171,82,49,195,165,8,23,24,215,191,111,14,238,223,28,140,74,205,197,106,16,170,48,60,19,134,27,142,250,228,165,128,112,166,43,17,95,21,232,168,95,15,8,231,194,160,74,73,238,95,96,207,214,40,204,254,184,115,22,27,169,156,108,138,121,171,112,69,41,224,52,99,90,31,195,162,210,151,50,41,51,92,44,174,45,209,5,215,6,5,42,27,28,69,17,140,117,153,231,76,85,211,230,191,5,66,161,228,154,39,168,55,4,128,181,160,10,208,202,129,59,38,146,140,228,132,45,77,212,227,249,106,197,87,131,132,254,34,190,195,156,125,164,70,193,4,188,142,215,11,190,17,162,40,151,25,143,33,182,201,247,138,134,99,120,207,52,238,96,39,138,123,91,82,103,192,37,154,59,153,144,5,215,74,26,234,61,38,238,126,187,102,123,240,137,48,68,164,52,104,247,76,128,213,159,89,250,78,163,90,115,122,86,133,84,134,101,192,83,24,23,76,177,92,97,10,130,106,153,120,186,171,36,154,130,169,10,114,234,71,201,50,77,89,16,33,166,192,137,215,60,190,27,186,173,163,168,174,176,211,18,109,139,113,9,158,176,79,123,124,206,129,154,138,11,109,152,136,49,28,71,22,182,155,165,70,63,39,219,54,21,152,90,149,185,237,238,78,214,162,53,18,214,146,39,157,103,77,109,51,189,208,133,239,132,65,71,126,4,238,100,150,82,164,237,216,76,173,52,96,0,245,24,142,70,107,166,160,36,143,105,86,69,227,252,100,131,14,111,7,87,39,22,66,45,240,15,135,152,240,3,154,185,62,71,102,74,69,175,131,45,51,76,124,143,244,52,218,190,240,223,76,37,94,0,15,15,112,184,97,183,168,83,153,149,185,248,204,178,18,47,36,75,106,160,109,83,29,108,243,141,70,3,68,125,153,244,64,99,46,204,180,195,28,78,192,167,131,160,215,240,144,186,221,150,59,82,72,18,155,66,30,59,7,88,189,30,206,126,97,92,210,40,147,1,118,6,221,96,87,117,206,241,188,247,228,103,253,224,169,47,240,39,144,19,218,168,178,142,159,53,61,244,189,161,69,222,209,150,207,65,112,210,229,151,237,102,178,205,153,64,205,185,157,241,170,31,227,247,26,140,13,209,160,136,208,125,160,133,142,159,12,244,144,113,234,15,4,56,190,199,102,156,81,36,110,162,247,141,183,221,28,207,204,118,111,108,246,44,143,240,74,204,5,153,67,79,155,134,97,247,96,54,11,74,174,105,251,210,98,116,35,176,193,249,114,249,157,124,165,157,33,18,84,47,189,250,37,233,232,37,245,91,84,107,229,206,209,106,102,43,216,10,126,252,215,210,111,139,132,109,42,216,45,61,120,173,47,67,210,215,217,210,98,255,131,43,91,175,199,157,14,15,233,236,15,29,69,160,151,61,8,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ff04ed70-ba1a-4a88-8f8b-7167d956ddc8"));
		}

		#endregion

	}

	#endregion

}
