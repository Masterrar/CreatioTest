namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CaseTimezoneServiceSchema

	/// <exclude/>
	public class CaseTimezoneServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CaseTimezoneServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CaseTimezoneServiceSchema(CaseTimezoneServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("992549c5-f56f-432d-80e7-1157f156a8c6");
			Name = "CaseTimezoneService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d90d0856-ba58-4278-952e-572fe1ed6e53");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,82,193,106,194,64,16,61,91,240,31,22,79,10,146,220,91,21,84,168,181,96,91,170,197,131,244,176,38,163,93,154,221,77,119,38,66,90,252,247,206,38,81,211,86,236,33,129,125,243,102,230,205,155,49,82,3,166,50,2,177,0,231,36,218,13,5,99,107,54,106,155,57,73,202,154,230,213,87,243,170,145,161,50,91,49,207,145,64,7,115,112,59,21,193,204,198,144,220,92,10,6,195,136,212,174,40,115,153,183,132,245,137,80,23,226,224,28,206,116,142,105,93,148,229,120,24,134,162,135,153,214,210,229,131,234,61,150,8,130,148,6,241,105,13,8,44,219,5,7,118,88,163,175,42,45,60,55,57,25,209,171,199,134,152,62,0,113,151,148,245,175,85,162,40,127,134,143,76,57,208,96,8,219,245,135,31,66,244,197,63,41,158,21,84,64,220,241,77,210,108,157,168,72,68,137,68,44,4,47,88,175,151,91,9,18,215,98,196,104,245,226,4,191,138,63,211,22,192,4,72,68,172,159,229,159,166,62,178,195,223,244,94,42,157,212,194,240,246,251,173,42,111,26,183,6,189,176,8,156,120,14,40,115,6,7,127,106,247,194,67,200,115,87,143,41,148,247,82,55,177,177,226,77,77,205,206,190,67,123,6,244,102,99,118,169,245,244,56,95,180,186,194,59,1,72,183,214,105,73,140,51,117,6,136,114,11,37,20,220,163,53,93,49,178,113,62,167,60,129,31,148,35,26,44,157,76,83,136,187,190,221,51,159,178,53,8,151,107,22,214,31,188,71,114,254,182,38,126,111,197,132,135,21,180,171,200,209,156,142,40,220,111,148,99,255,88,215,29,36,60,126,112,166,200,11,223,29,99,6,34,239,77,183,86,205,223,117,99,207,63,254,246,223,228,253,37,13,134,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("992549c5-f56f-432d-80e7-1157f156a8c6"));
		}

		#endregion

	}

	#endregion

}

