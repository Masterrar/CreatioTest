namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CaseTermIntervalSchema

	/// <exclude/>
	public class CaseTermIntervalSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CaseTermIntervalSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CaseTermIntervalSchema(CaseTermIntervalSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("cff3d064-d73b-473d-8492-7151dcd31b07");
			Name = "CaseTermInterval";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("f69a32ba-7e77-47bd-be6b-d095bbdc629a");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,84,81,107,219,48,16,126,78,161,255,225,198,160,164,176,217,93,31,219,52,48,194,54,250,208,81,214,108,47,99,15,170,115,246,196,100,201,232,228,64,216,242,223,119,146,173,196,142,66,9,133,64,164,211,125,186,239,251,238,44,45,106,164,70,20,8,75,180,86,144,41,93,182,48,186,148,85,107,133,147,70,159,159,253,61,63,155,180,36,117,5,79,27,114,88,223,238,246,11,161,80,175,132,165,165,172,241,187,150,14,238,246,177,44,6,57,159,17,111,45,86,124,29,124,210,109,125,195,89,132,92,176,126,114,194,33,241,49,255,242,60,135,25,181,117,45,236,102,222,239,125,30,56,78,4,169,249,111,45,20,20,166,110,20,58,212,72,4,20,240,89,68,231,3,248,207,207,74,84,244,139,87,77,251,172,100,1,200,149,211,194,94,221,228,171,209,200,220,175,222,249,13,203,119,66,106,250,198,198,24,77,254,224,195,225,129,81,107,31,191,230,240,182,147,199,162,59,133,35,181,11,37,136,246,114,239,123,17,33,231,152,222,143,80,120,196,251,162,43,133,22,74,99,161,72,92,56,38,184,151,25,46,72,42,194,13,220,15,247,179,177,17,243,232,68,36,254,104,77,131,214,73,100,246,143,225,226,192,57,33,29,2,209,16,199,29,31,82,76,57,70,146,126,54,124,245,8,13,235,64,96,82,161,159,24,94,80,191,216,190,92,185,235,209,235,74,7,236,9,181,15,186,187,115,233,1,221,111,179,58,197,162,47,232,8,124,87,81,59,168,5,253,1,230,217,98,118,156,106,136,88,116,173,213,52,127,216,103,207,242,24,28,8,26,119,210,87,242,136,233,101,175,105,45,44,88,164,86,117,95,231,48,55,243,115,223,9,150,37,76,71,134,188,185,3,221,42,5,23,23,35,163,178,229,166,65,127,184,194,82,240,157,211,228,13,184,76,32,63,60,119,152,195,85,164,52,233,249,252,75,8,29,126,123,29,185,237,144,226,110,92,198,12,99,248,116,130,59,196,235,248,121,248,144,94,215,153,222,234,23,134,39,125,47,248,241,219,254,7,43,122,147,247,136,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("cff3d064-d73b-473d-8492-7151dcd31b07"));
		}

		#endregion

	}

	#endregion

}

