namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: TempAccessProxyExceptionsSchema

	/// <exclude/>
	public class TempAccessProxyExceptionsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public TempAccessProxyExceptionsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public TempAccessProxyExceptionsSchema(TempAccessProxyExceptionsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("7f12bace-72ee-4042-9a07-c5a18b5d88ca");
			Name = "TempAccessProxyExceptions";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("f214e3c2-8cc2-4e62-be3f-96a9b4832c80");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,237,82,205,106,219,64,16,62,219,224,119,24,220,75,10,70,186,187,142,33,164,57,244,82,2,206,11,140,215,35,121,200,106,87,204,140,98,187,33,239,222,213,74,110,131,147,28,10,237,173,167,101,135,249,249,254,2,54,164,45,58,130,7,18,65,141,149,21,183,49,84,92,119,130,198,49,20,119,71,35,9,232,111,156,35,213,123,116,143,88,211,108,250,60,155,78,58,229,80,195,230,164,70,205,151,217,52,85,62,9,213,105,8,110,61,170,46,225,166,229,13,201,19,201,221,209,81,219,175,203,93,101,89,194,74,187,166,65,57,173,199,255,195,158,128,206,93,96,123,52,96,77,175,196,67,128,195,158,2,180,18,143,39,168,163,65,66,26,5,42,137,13,96,203,160,249,68,113,94,92,190,218,220,118,91,207,14,92,15,231,29,52,176,132,87,200,38,207,25,221,111,18,49,168,73,231,44,74,226,114,159,87,13,29,151,4,114,225,91,96,99,244,252,131,20,16,2,29,128,211,60,134,164,109,172,18,19,74,35,68,224,132,170,235,249,91,44,243,114,61,224,44,126,93,40,47,79,172,90,20,108,32,36,211,174,231,201,56,77,86,204,215,189,116,227,103,16,110,71,234,132,183,164,249,106,86,171,88,149,121,54,175,26,85,121,139,225,42,241,237,45,29,183,125,238,155,39,75,216,162,210,213,185,6,189,243,147,151,81,42,10,187,65,173,252,31,170,23,197,143,50,145,228,13,228,140,159,216,78,127,35,31,125,20,28,122,15,21,178,167,29,236,186,36,182,103,10,6,198,13,197,206,22,201,21,59,68,121,236,179,180,245,212,232,2,190,126,223,228,129,78,104,1,100,238,15,98,244,46,129,255,145,250,88,155,127,17,175,151,159,102,152,71,168,194,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("7f12bace-72ee-4042-9a07-c5a18b5d88ca"));
		}

		#endregion

	}

	#endregion

}

