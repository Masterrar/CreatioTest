﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SysAdminUnitEventListenerSchema

	/// <exclude/>
	public class SysAdminUnitEventListenerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SysAdminUnitEventListenerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SysAdminUnitEventListenerSchema(SysAdminUnitEventListenerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("020aa647-daf1-4077-a5db-bbe8dad8c008");
			Name = "SysAdminUnitEventListener";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("7cc31540-fa76-4c79-9b86-a6eabd8e662c");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,205,83,77,111,26,49,16,61,19,41,255,97,186,145,18,86,66,222,182,71,2,68,20,161,36,82,63,162,64,122,169,122,48,235,89,112,181,107,175,108,47,21,170,242,223,235,15,76,88,4,73,143,189,32,121,246,205,155,247,230,13,130,86,168,107,154,35,204,81,41,170,101,97,200,68,138,130,47,27,69,13,151,226,252,236,207,249,89,167,209,92,44,97,182,209,6,171,235,221,251,68,11,121,228,203,149,209,51,84,107,158,227,113,184,66,50,21,134,27,142,250,77,0,153,174,81,24,135,179,200,11,133,75,59,3,38,37,213,186,239,36,141,89,197,197,147,224,198,195,62,115,171,81,160,242,224,44,203,96,160,155,170,162,106,51,218,190,35,0,10,169,224,106,191,255,10,208,77,220,0,250,121,36,18,100,7,12,3,141,72,75,45,33,87,88,12,147,215,85,147,79,84,163,175,109,90,250,18,200,28,223,143,35,159,186,179,124,133,21,253,106,163,129,33,36,251,18,147,244,167,109,170,155,69,201,115,200,221,10,78,111,0,250,112,98,182,165,112,161,238,118,249,160,100,141,202,137,238,195,131,231,246,219,139,115,66,156,119,88,90,80,235,17,18,233,92,160,96,129,105,251,222,210,126,65,179,146,236,128,243,48,18,95,184,163,130,149,168,227,254,239,133,182,114,144,133,32,200,174,45,59,236,27,212,84,209,10,132,221,212,48,209,86,134,221,235,200,91,133,240,34,131,204,67,142,119,96,50,154,175,208,231,25,179,236,159,76,211,75,27,23,6,149,31,48,86,75,237,50,4,46,180,161,194,254,129,114,41,12,229,194,29,178,89,97,28,232,45,0,163,134,182,180,108,87,43,215,118,28,103,8,107,201,25,124,19,209,121,87,46,126,97,30,93,244,224,216,116,192,20,124,140,157,133,141,153,236,53,199,46,76,175,253,247,208,13,52,158,137,189,170,110,168,165,1,26,96,188,128,238,14,67,110,209,204,55,53,178,137,44,155,74,124,167,101,131,131,219,134,179,81,55,153,56,167,185,185,103,73,10,239,134,224,170,100,90,213,118,196,229,165,103,234,188,78,179,144,178,12,52,194,154,180,167,226,16,73,26,237,116,90,7,55,108,223,223,205,13,8,252,221,170,237,137,126,178,27,120,161,221,218,111,241,145,25,154,71,204,165,98,190,250,111,134,157,211,30,68,223,73,47,208,190,225,82,27,101,111,161,189,174,30,188,239,193,199,255,81,215,135,23,93,207,238,247,249,232,127,59,84,219,69,91,251,11,181,181,181,15,70,6,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("020aa647-daf1-4077-a5db-bbe8dad8c008"));
		}

		#endregion

	}

	#endregion

}

