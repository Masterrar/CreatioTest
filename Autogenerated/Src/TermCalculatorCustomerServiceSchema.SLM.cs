namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: TermCalculatorCustomerServiceSchema

	/// <exclude/>
	public class TermCalculatorCustomerServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public TermCalculatorCustomerServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public TermCalculatorCustomerServiceSchema(TermCalculatorCustomerServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("5034a0e1-cd7c-4f00-b59d-d7837cec6620");
			Name = "TermCalculatorCustomerService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("50529f8b-8504-4b8d-9a81-5bda32bd1be4");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,82,237,138,194,48,16,252,93,193,119,216,67,144,30,72,31,64,145,131,43,34,133,19,228,244,30,32,54,171,23,104,147,222,38,17,202,225,187,95,210,15,173,245,234,207,157,157,157,217,217,196,106,33,79,176,43,181,193,124,49,30,217,78,25,125,8,249,115,197,246,72,196,180,58,154,40,86,132,3,112,180,146,70,24,129,218,245,199,35,201,114,212,5,75,241,142,37,143,226,100,137,25,161,228,120,244,235,121,193,132,240,228,74,136,51,166,245,220,179,243,152,101,169,205,152,81,20,91,109,84,142,180,67,58,139,20,171,129,194,30,50,145,66,234,249,207,233,208,151,115,211,206,52,184,121,42,169,13,217,212,181,156,245,182,18,174,60,90,147,167,242,225,151,70,114,18,18,83,31,8,236,93,57,131,181,21,28,116,205,77,220,77,19,222,96,5,9,69,194,148,9,127,5,111,22,204,225,192,52,134,125,129,222,108,119,172,138,113,169,119,157,160,228,117,32,95,117,243,109,208,124,43,238,163,145,50,78,21,121,147,174,45,65,157,221,235,8,142,245,98,107,52,46,173,147,99,148,240,176,113,9,8,141,37,9,187,219,54,240,178,4,105,179,12,166,211,46,28,221,134,61,195,75,70,171,188,48,101,37,19,188,13,112,235,110,125,131,168,183,194,98,32,231,255,41,31,31,240,154,239,211,253,70,247,218,184,23,57,250,156,27,33,187,80,216,45,98,149,217,92,234,250,187,2,85,29,254,208,104,207,115,167,220,60,89,139,193,242,154,170,111,56,40,187,232,30,253,113,240,189,220,54,255,32,236,153,205,134,87,29,58,99,131,117,161,203,31,7,178,223,151,22,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5034a0e1-cd7c-4f00-b59d-d7837cec6620"));
		}

		#endregion

	}

	#endregion

}

