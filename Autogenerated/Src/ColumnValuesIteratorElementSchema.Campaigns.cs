namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ColumnValuesIteratorElementSchema

	/// <exclude/>
	public class ColumnValuesIteratorElementSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ColumnValuesIteratorElementSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ColumnValuesIteratorElementSchema(ColumnValuesIteratorElementSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("940b6f42-9d5c-4d59-8253-b8b8e250727e");
			Name = "ColumnValuesIteratorElement";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6c038aa0-46cd-4697-bc93-5c682e364aef");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,145,61,79,195,48,16,134,231,70,234,127,56,133,5,150,120,135,52,18,138,24,24,42,117,64,236,87,231,146,90,141,237,200,231,20,16,234,127,199,181,147,10,162,138,205,247,245,188,119,175,13,106,226,1,37,193,27,57,135,108,91,95,212,214,180,170,27,29,122,101,77,81,163,30,80,117,134,215,217,247,58,91,103,171,59,71,93,40,64,221,35,243,35,212,182,31,181,121,199,126,36,126,245,20,166,172,123,233,73,147,241,177,93,8,1,37,143,90,163,251,170,166,248,121,207,222,161,244,64,169,17,90,235,66,19,17,72,71,237,38,191,197,204,69,85,204,56,241,139,55,140,251,94,73,192,25,41,47,107,253,191,213,42,29,114,189,100,75,254,96,155,112,203,46,178,82,113,185,119,76,108,241,72,12,65,230,50,246,161,252,1,52,74,103,25,78,81,9,208,52,32,163,244,148,41,174,40,177,100,149,3,58,212,96,194,15,108,114,105,141,167,79,159,87,117,122,68,71,6,103,37,49,43,211,205,70,113,81,138,56,22,41,203,211,79,86,53,176,75,67,247,183,28,152,225,147,218,195,211,228,3,153,38,89,17,227,115,250,230,63,201,243,15,148,145,250,14,41,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("940b6f42-9d5c-4d59-8253-b8b8e250727e"));
		}

		#endregion

	}

	#endregion

}

