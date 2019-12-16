namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: TermCalculationServiceUtilitiesSchema

	/// <exclude/>
	public class TermCalculationServiceUtilitiesSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public TermCalculationServiceUtilitiesSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public TermCalculationServiceUtilitiesSchema(TermCalculationServiceUtilitiesSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("609e8015-fad5-45e5-8005-deb9093949ca");
			Name = "TermCalculationServiceUtilities";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d862795b-510a-489d-988e-e22493fe3a79");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,181,148,77,111,219,48,12,134,207,9,144,255,64,32,231,185,247,166,216,48,164,192,144,195,128,32,201,173,216,65,81,152,64,168,45,121,148,52,32,11,250,223,71,73,241,71,221,52,174,179,205,7,89,162,44,242,17,249,154,90,20,104,75,33,17,54,72,36,172,217,187,108,110,244,94,29,60,9,167,140,206,216,94,204,69,46,125,30,215,107,164,95,74,226,100,124,154,140,39,227,145,183,74,31,96,125,180,14,139,89,103,157,173,188,118,170,192,140,207,40,145,171,223,209,193,44,158,155,18,30,120,1,243,92,88,123,15,103,175,33,214,10,127,122,180,46,126,117,199,15,60,88,95,20,130,142,159,147,1,166,225,73,99,243,142,147,236,252,197,195,93,235,200,211,163,112,130,175,228,72,72,247,131,13,165,223,230,74,66,41,200,49,21,200,64,112,17,96,148,174,88,179,46,201,148,200,135,144,129,151,209,73,218,239,66,54,148,145,232,45,82,98,250,142,197,22,41,16,85,72,223,188,218,85,36,11,78,224,98,7,39,8,251,163,3,186,89,156,216,243,228,37,12,61,193,111,139,191,36,101,72,185,227,245,224,87,67,55,241,135,18,88,71,65,63,43,78,56,79,163,94,54,172,160,62,146,41,234,93,42,82,92,39,107,219,56,234,74,14,58,154,179,165,209,22,43,209,189,209,220,215,36,147,79,146,117,36,148,70,130,189,33,32,100,73,5,151,65,229,32,244,14,172,201,125,109,25,36,199,11,50,172,152,222,215,33,124,64,136,171,54,228,176,106,176,21,67,250,191,212,78,250,138,113,69,147,235,110,106,110,225,168,156,252,31,81,220,243,61,11,46,175,221,40,249,108,155,62,240,241,54,212,122,191,234,76,195,90,83,210,194,101,150,83,95,71,234,105,9,53,205,224,159,114,109,60,73,172,106,113,115,115,104,101,105,24,70,110,98,103,104,146,242,47,16,6,83,108,141,201,97,193,5,169,127,245,191,160,184,169,65,207,133,197,254,230,252,74,232,23,181,207,198,63,9,20,213,120,254,7,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("609e8015-fad5-45e5-8005-deb9093949ca"));
		}

		#endregion

	}

	#endregion

}

