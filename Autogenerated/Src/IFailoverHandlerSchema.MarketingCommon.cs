namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IFailoverHandlerSchema

	/// <exclude/>
	public class IFailoverHandlerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IFailoverHandlerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IFailoverHandlerSchema(IFailoverHandlerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e7edf2cf-725e-49c2-915d-d5b92e144696");
			Name = "IFailoverHandler";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("097cd95f-c972-4e9b-ab53-9b1cae85bae7");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,81,75,111,131,48,12,62,23,137,255,96,117,151,237,2,247,182,235,165,218,180,78,154,84,169,157,118,14,96,32,19,73,144,147,160,85,211,254,251,76,160,168,236,113,200,193,159,253,61,236,120,43,117,5,199,179,117,168,214,113,228,67,121,66,34,97,77,233,146,157,33,252,7,78,142,121,141,133,111,144,254,24,120,195,140,135,148,50,154,155,113,164,133,66,219,138,28,103,26,186,148,149,39,225,164,209,113,244,217,207,45,110,8,43,46,97,175,29,82,201,132,21,236,31,133,108,76,135,244,36,116,193,110,97,46,77,83,216,88,175,148,160,243,118,172,15,100,58,89,160,5,133,174,54,133,5,103,128,3,72,103,8,152,10,117,224,67,201,114,54,185,104,164,87,34,173,207,26,153,131,188,120,255,178,6,78,243,108,178,135,15,204,61,171,50,101,72,61,197,126,25,156,87,112,8,82,67,243,103,214,0,236,8,133,227,172,239,38,187,206,57,133,27,88,173,32,161,160,191,222,253,210,91,36,190,153,198,188,63,216,114,123,170,17,122,12,242,9,76,54,105,96,76,46,179,245,22,157,145,197,104,204,91,220,190,206,4,97,174,127,183,30,55,67,93,12,203,133,250,139,95,255,77,51,148,193,111,41,41,150,251,71,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e7edf2cf-725e-49c2-915d-d5b92e144696"));
		}

		#endregion

	}

	#endregion

}

