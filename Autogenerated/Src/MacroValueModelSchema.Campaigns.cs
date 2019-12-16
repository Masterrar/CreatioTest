namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: MacroValueModelSchema

	/// <exclude/>
	public class MacroValueModelSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public MacroValueModelSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public MacroValueModelSchema(MacroValueModelSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e05ca81a-184e-4e98-bb5a-a27cf686c759");
			Name = "MacroValueModel";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6c038aa0-46cd-4697-bc93-5c682e364aef");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,81,75,107,195,48,12,62,47,144,255,32,218,123,114,223,186,194,200,185,80,232,216,93,113,229,224,225,216,65,178,7,165,244,191,207,177,219,210,141,173,20,132,65,143,239,33,217,225,72,50,161,34,120,39,102,20,175,67,211,121,167,205,16,25,131,241,174,233,112,156,208,12,78,234,234,88,87,117,245,180,100,26,82,3,58,139,34,207,176,65,197,254,3,109,164,141,223,147,77,3,41,218,182,133,149,196,113,68,62,172,207,121,162,13,104,156,128,113,218,3,246,62,6,24,103,48,124,205,104,208,158,129,92,48,225,0,202,219,56,186,230,66,212,222,48,77,177,183,70,129,154,197,255,208,46,22,175,30,183,236,39,226,96,40,25,221,102,100,233,255,246,151,11,111,214,160,128,215,197,85,115,157,187,149,191,232,75,96,227,134,51,228,8,3,133,23,144,249,57,221,17,200,118,165,172,123,159,222,247,159,164,2,228,213,30,166,223,21,79,76,19,147,164,75,230,255,131,20,43,33,2,197,164,95,23,153,113,209,174,31,89,174,240,253,235,97,73,110,95,206,156,243,82,253,89,60,125,3,240,194,95,129,95,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e05ca81a-184e-4e98-bb5a-a27cf686c759"));
		}

		#endregion

	}

	#endregion

}

