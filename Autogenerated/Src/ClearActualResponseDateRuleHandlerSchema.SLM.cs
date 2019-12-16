namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ClearActualResponseDateRuleHandlerSchema

	/// <exclude/>
	public class ClearActualResponseDateRuleHandlerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ClearActualResponseDateRuleHandlerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ClearActualResponseDateRuleHandlerSchema(ClearActualResponseDateRuleHandlerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("49896338-f1b3-42b4-a897-a58e4a82829a");
			Name = "ClearActualResponseDateRuleHandler";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b11d550e-0087-4f53-ae17-fb00d41102cf");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,82,203,110,194,48,16,60,7,137,127,112,225,18,164,42,31,64,75,165,54,244,117,168,138,128,246,190,77,150,212,146,99,71,107,27,9,85,252,123,237,56,8,146,18,209,147,181,227,153,157,157,181,37,148,168,43,200,144,173,145,8,180,218,152,36,85,114,195,11,75,96,184,146,195,193,207,112,16,89,205,101,193,86,59,109,176,188,233,212,201,28,12,252,1,83,37,4,102,190,131,78,158,81,34,241,236,200,57,245,42,75,37,207,223,16,246,225,201,252,161,247,234,81,26,110,56,234,94,194,19,100,70,81,47,227,36,123,146,130,64,153,3,121,170,35,143,9,11,7,179,84,128,214,83,119,32,208,125,102,44,136,165,91,162,75,138,110,21,184,180,2,95,64,230,2,169,86,85,246,75,240,140,101,94,244,15,13,155,178,215,20,116,187,77,228,31,225,232,239,100,134,172,143,225,198,88,212,253,107,171,131,215,101,151,248,67,35,185,62,50,188,17,179,173,114,194,106,191,168,67,154,117,104,126,129,209,62,56,143,221,162,194,120,77,221,204,186,32,85,33,249,7,57,59,105,199,161,83,134,41,10,52,181,83,84,17,223,186,24,76,55,192,5,235,55,52,223,42,63,239,187,85,60,103,97,23,113,253,99,118,12,235,227,16,157,111,88,28,16,247,125,205,122,87,97,238,190,180,45,229,39,8,139,183,126,157,107,94,226,93,60,10,27,206,49,127,151,163,9,187,154,49,105,133,56,180,137,154,30,43,52,39,242,182,232,58,40,66,198,125,79,176,6,107,103,117,216,47,213,100,123,218,193,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("49896338-f1b3-42b4-a897-a58e4a82829a"));
		}

		#endregion

	}

	#endregion

}

