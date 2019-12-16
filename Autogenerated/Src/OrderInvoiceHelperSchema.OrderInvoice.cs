﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: OrderInvoiceHelperSchema

	/// <exclude/>
	public class OrderInvoiceHelperSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public OrderInvoiceHelperSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public OrderInvoiceHelperSchema(OrderInvoiceHelperSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("4ad2243e-f8fe-48a3-a75c-73dc11188592");
			Name = "OrderInvoiceHelper";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("650a2ad9-42d3-4738-b18c-b0f4ce2ed031");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,205,87,91,111,211,48,20,126,206,164,253,7,179,73,40,149,162,244,157,181,147,96,99,163,130,193,68,129,119,47,57,237,140,18,167,248,82,84,161,253,119,236,216,105,125,73,179,76,226,129,62,52,177,125,206,119,190,115,177,125,34,57,161,107,180,220,113,1,245,197,233,137,116,134,249,85,83,85,80,8,210,80,158,223,2,5,70,138,80,228,19,161,191,246,115,223,128,49,204,155,149,80,154,12,142,76,231,239,169,32,130,0,223,175,235,217,171,134,174,200,90,50,172,173,161,121,168,227,45,43,197,211,19,138,107,224,27,92,128,39,234,72,229,95,88,9,108,65,183,13,41,224,244,228,207,233,73,178,145,15,21,41,80,81,97,206,145,187,252,1,170,13,48,37,241,71,67,39,201,57,131,181,230,161,0,185,96,178,16,13,227,111,208,125,171,110,36,44,84,12,146,126,231,192,148,30,53,129,67,210,27,78,144,230,145,36,129,208,60,16,187,208,66,79,150,11,208,210,208,241,185,221,179,70,153,211,129,236,101,22,88,8,134,134,197,26,68,107,41,217,48,178,197,2,16,183,19,79,250,111,200,248,29,136,199,166,212,150,89,35,20,38,148,214,120,55,68,91,194,132,196,21,106,179,189,67,183,32,150,141,100,5,152,113,106,30,203,226,17,106,140,120,187,98,6,25,186,38,45,71,204,118,51,21,124,85,32,25,50,207,75,180,197,21,41,85,85,202,154,214,120,147,161,91,73,74,171,253,181,249,189,40,187,240,110,49,67,96,12,207,61,244,252,138,129,114,212,146,240,131,50,49,177,88,188,167,178,6,134,31,42,152,117,118,139,214,36,255,214,220,128,40,30,21,166,79,36,255,129,43,9,60,191,38,92,16,90,136,212,66,25,10,121,171,116,195,154,250,250,93,234,145,81,65,185,103,164,86,158,26,168,207,170,166,211,73,230,122,148,5,182,45,50,3,33,25,181,62,186,213,50,148,128,107,208,244,218,205,209,151,133,242,176,108,102,122,163,25,73,141,8,169,141,195,82,83,88,25,87,77,196,210,241,238,12,84,133,114,237,199,33,31,119,120,51,84,93,195,46,15,86,31,161,27,41,20,188,27,23,6,92,86,66,197,133,194,239,1,221,206,209,149,58,204,176,170,160,84,235,22,29,223,133,58,73,21,122,100,32,33,43,148,246,4,220,84,68,126,67,104,249,110,215,22,141,7,149,127,132,221,4,189,82,156,100,85,161,215,175,145,1,75,18,127,39,60,135,210,166,104,143,179,231,212,166,75,59,157,191,45,203,216,112,134,250,80,140,247,230,92,177,255,54,231,6,235,72,9,55,106,123,223,144,170,242,106,198,22,180,113,166,75,168,155,202,193,36,238,217,117,14,13,167,36,18,79,220,2,50,188,92,219,118,198,219,39,121,16,113,85,175,71,211,118,113,212,136,241,119,143,111,134,99,161,189,44,52,15,63,85,124,245,25,38,225,128,164,84,157,48,167,174,185,78,209,243,201,23,143,66,144,25,124,171,250,244,242,252,62,151,80,227,197,127,145,208,193,141,120,209,187,149,45,108,180,185,94,22,226,113,91,237,153,70,226,112,151,59,93,196,116,58,69,51,46,107,125,57,93,118,19,231,230,135,186,135,51,209,189,58,171,238,227,60,11,148,15,47,249,222,220,52,180,55,219,96,134,107,164,91,189,249,153,123,120,233,80,159,93,134,72,7,200,217,180,213,236,7,138,14,212,126,180,113,96,206,85,125,118,185,40,59,175,95,72,105,159,199,3,141,62,42,231,40,237,222,38,78,244,83,59,49,222,82,91,41,145,185,158,72,162,222,97,143,13,115,154,243,67,8,134,116,59,97,167,93,237,186,149,182,163,243,58,10,179,223,81,152,254,238,68,143,239,112,179,26,182,134,153,189,5,199,92,13,35,206,155,46,130,200,223,192,61,141,135,55,53,15,26,241,220,93,189,195,20,175,129,233,147,120,161,190,59,48,45,192,158,42,161,243,118,147,31,235,101,254,133,201,222,176,90,187,227,58,116,19,157,184,57,139,195,146,29,35,239,156,112,158,203,94,104,141,17,239,235,162,207,132,207,204,107,178,125,236,136,139,49,16,119,207,71,72,91,180,232,94,115,73,245,120,28,50,180,48,250,222,8,74,46,188,52,34,75,61,216,62,132,123,43,39,145,116,190,196,91,72,87,184,226,224,247,231,177,164,247,249,210,162,31,251,116,213,115,237,244,95,71,191,240,50,113,16,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("4ad2243e-f8fe-48a3-a75c-73dc11188592"));
		}

		#endregion

	}

	#endregion

}

