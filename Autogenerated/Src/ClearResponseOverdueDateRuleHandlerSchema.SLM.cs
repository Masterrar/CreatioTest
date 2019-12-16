namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ClearResponseOverdueDateRuleHandlerSchema

	/// <exclude/>
	public class ClearResponseOverdueDateRuleHandlerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ClearResponseOverdueDateRuleHandlerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ClearResponseOverdueDateRuleHandlerSchema(ClearResponseOverdueDateRuleHandlerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("1d4ab598-48ce-4320-8df6-59d7c39071fd");
			Name = "ClearResponseOverdueDateRuleHandler";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b11d550e-0087-4f53-ae17-fb00d41102cf");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,82,203,110,194,48,16,60,7,137,127,112,225,18,164,42,234,153,150,30,26,250,58,84,69,60,122,119,147,37,181,228,216,209,218,70,66,21,255,222,141,29,4,4,162,114,178,118,60,179,179,179,182,226,37,152,138,103,192,150,128,200,141,94,219,36,213,106,45,10,135,220,10,173,250,189,223,126,47,114,70,168,130,45,182,198,66,121,223,170,147,41,183,252,12,76,181,148,144,213,29,76,242,10,10,80,100,7,206,177,87,89,106,117,249,6,161,11,79,166,79,157,87,207,202,10,43,192,116,18,94,120,102,53,118,50,142,178,39,41,151,160,114,142,53,149,200,67,132,130,96,150,74,110,204,152,14,224,56,167,245,81,70,248,220,0,230,14,104,23,48,119,18,222,184,202,37,160,151,85,238,91,138,140,101,181,234,26,17,27,179,247,148,155,211,62,81,253,12,135,9,72,109,209,213,65,104,144,153,55,240,94,123,179,43,108,226,149,1,164,70,42,60,19,115,39,229,136,121,195,168,69,154,180,104,245,14,163,93,176,30,210,174,194,124,77,221,12,59,67,93,1,214,111,114,113,212,150,67,171,12,83,20,96,189,83,84,161,216,80,12,102,26,224,31,235,15,176,63,58,191,236,187,209,34,103,97,23,177,255,52,91,6,254,216,71,23,107,22,7,132,126,176,93,110,43,200,233,87,187,82,125,113,233,224,65,40,251,24,15,90,59,30,140,216,205,132,221,237,91,68,141,126,1,246,72,122,174,186,37,73,8,184,235,72,213,96,167,65,9,251,3,5,201,24,244,193,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("1d4ab598-48ce-4320-8df6-59d7c39071fd"));
		}

		#endregion

	}

	#endregion

}

