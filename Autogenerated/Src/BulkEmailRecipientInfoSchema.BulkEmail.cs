namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: BulkEmailRecipientInfoSchema

	/// <exclude/>
	public class BulkEmailRecipientInfoSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public BulkEmailRecipientInfoSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public BulkEmailRecipientInfoSchema(BulkEmailRecipientInfoSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("edb51f3a-b81d-4db8-b7ae-fa1b74840be6");
			Name = "BulkEmailRecipientInfo";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("dd52e867-4cdd-49ef-ae6f-89b6a324e270");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,84,193,78,227,48,16,61,131,196,63,140,196,129,11,106,239,5,129,118,83,84,229,128,84,117,225,3,220,120,146,142,72,236,224,113,96,81,197,191,51,182,211,108,169,118,33,221,75,34,191,204,204,155,55,243,28,163,26,228,86,21,8,15,232,156,98,91,250,73,102,77,73,85,231,148,39,107,206,78,183,103,167,39,29,147,169,224,215,27,123,108,174,14,206,18,95,215,88,132,96,158,44,208,160,163,66,98,36,234,220,97,37,40,100,181,98,158,193,207,174,126,186,107,20,213,43,44,168,37,52,62,55,165,141,145,211,233,20,174,185,107,26,229,222,110,250,243,210,217,23,210,200,208,160,223,88,205,160,140,134,214,217,22,157,39,129,75,235,224,213,186,39,120,37,191,1,183,171,9,182,132,181,48,1,6,170,201,174,248,116,175,122,219,173,107,42,160,8,109,253,163,43,152,65,126,143,204,170,194,79,248,37,228,119,191,91,74,179,233,129,121,118,32,232,100,27,69,13,250,151,67,211,51,88,70,238,244,253,80,117,4,30,13,61,119,8,162,220,120,42,9,93,16,52,168,155,12,121,251,130,118,138,22,29,105,200,53,108,161,66,127,5,28,30,239,95,112,69,221,160,180,118,34,245,8,30,246,46,236,63,166,255,232,179,199,114,174,164,63,50,80,88,227,85,225,25,188,90,215,248,53,29,201,86,179,20,191,58,66,93,159,114,193,208,13,51,77,35,29,49,197,62,249,8,186,57,150,170,171,189,40,211,24,102,233,55,40,243,228,86,174,5,70,179,38,96,212,128,131,226,220,144,39,37,182,76,37,178,80,118,108,47,189,117,1,7,175,130,86,254,155,49,207,37,226,129,26,188,133,63,22,15,216,104,214,5,202,62,69,40,135,119,80,219,168,194,89,142,187,254,86,242,156,226,47,68,208,235,100,175,203,222,102,55,112,159,202,252,119,27,14,91,97,80,123,119,106,132,1,86,41,233,239,6,56,71,163,211,229,142,231,132,238,131,239,31,17,153,224,27,89,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("edb51f3a-b81d-4db8-b7ae-fa1b74840be6"));
		}

		#endregion

	}

	#endregion

}

