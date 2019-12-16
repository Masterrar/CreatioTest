namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CalendarRemindCalculatorCustomerServiceSchema

	/// <exclude/>
	public class CalendarRemindCalculatorCustomerServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CalendarRemindCalculatorCustomerServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CalendarRemindCalculatorCustomerServiceSchema(CalendarRemindCalculatorCustomerServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("edcd46c2-7ae7-4652-8fc1-4857d18db187");
			Name = "CalendarRemindCalculatorCustomerService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("50529f8b-8504-4b8d-9a81-5bda32bd1be4");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,81,77,107,2,49,16,61,175,224,127,24,244,178,130,248,3,20,79,75,41,30,10,165,182,167,210,67,204,142,219,192,110,178,76,18,69,116,255,123,39,217,181,126,20,97,123,9,188,153,188,121,239,205,120,171,116,1,235,131,117,88,45,134,3,31,225,59,18,9,107,182,110,150,25,66,46,15,7,90,84,104,107,33,241,166,169,183,170,240,36,156,50,122,56,56,134,127,201,152,176,96,8,89,41,172,157,67,38,74,212,185,160,55,172,148,206,25,73,95,10,103,40,243,214,153,10,105,141,180,83,18,35,181,246,155,82,73,144,129,217,151,8,143,37,120,34,91,74,46,142,140,182,142,188,228,22,27,123,37,181,19,174,21,78,234,22,244,21,77,63,44,18,143,211,40,67,116,240,55,112,18,38,38,115,216,8,139,233,93,11,162,163,166,85,29,179,86,235,173,195,157,209,23,116,223,38,15,30,227,66,58,139,237,114,172,227,109,203,222,219,201,8,57,215,138,131,11,45,241,95,49,166,240,236,85,14,146,83,172,242,206,120,178,19,20,43,79,218,41,119,128,37,20,232,178,95,156,222,79,104,201,83,208,184,255,252,130,35,140,58,229,85,62,154,194,136,79,96,136,105,140,160,153,44,162,128,218,166,215,243,151,160,125,89,194,233,116,165,58,187,240,194,135,224,114,246,84,213,238,112,54,153,16,58,79,58,82,219,169,77,124,207,101,220,247,62,244,159,243,65,72,203,185,175,76,54,139,7,55,237,106,215,165,230,7,190,242,169,153,112,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("edcd46c2-7ae7-4652-8fc1-4857d18db187"));
		}

		#endregion

	}

	#endregion

}

