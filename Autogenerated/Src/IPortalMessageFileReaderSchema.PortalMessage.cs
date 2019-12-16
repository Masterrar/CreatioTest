namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IPortalMessageFileReaderSchema

	/// <exclude/>
	public class IPortalMessageFileReaderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IPortalMessageFileReaderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IPortalMessageFileReaderSchema(IPortalMessageFileReaderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("036d92f0-de76-43ba-9d4d-3a87133b254f");
			Name = "IPortalMessageFileReader";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("c85d2d65-6230-4aeb-9934-bfac9785d42f");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,148,193,110,219,48,12,134,207,45,208,119,32,218,75,11,12,206,189,233,122,88,178,5,6,150,38,104,131,94,138,29,20,155,246,132,73,178,64,73,5,188,162,239,62,73,78,19,39,145,139,236,146,64,226,255,127,164,40,90,138,73,52,154,21,8,43,36,98,166,169,108,54,105,84,197,107,71,204,242,70,93,156,191,93,156,159,57,195,85,13,79,173,177,40,199,7,107,175,23,2,139,32,54,217,12,21,18,47,142,52,143,78,89,46,49,123,242,81,38,248,223,200,222,169,118,201,31,28,15,162,87,94,224,188,41,81,100,83,102,153,175,200,18,43,172,55,120,203,21,97,237,221,0,19,193,140,185,133,101,67,150,137,57,26,195,106,252,193,5,78,87,139,40,124,233,123,127,249,13,237,214,130,23,80,4,223,128,237,44,28,119,155,98,73,141,70,178,28,67,154,104,142,224,142,60,71,185,70,186,126,240,45,132,175,112,153,151,151,55,33,201,71,150,153,227,37,228,37,188,65,141,118,12,38,252,188,15,219,39,132,204,98,249,173,77,80,182,177,255,132,45,212,62,204,88,10,221,222,70,79,197,133,255,36,41,10,78,133,52,22,77,154,18,34,167,98,86,173,62,168,229,103,211,252,113,218,79,161,147,10,66,248,84,212,51,146,241,183,188,79,227,202,194,38,144,226,92,161,42,187,225,240,171,110,175,191,149,24,207,126,121,81,48,26,141,224,206,56,41,25,181,247,155,117,212,130,253,205,44,16,106,66,131,190,12,17,157,80,68,107,246,225,28,245,172,159,79,248,126,230,110,178,83,125,40,185,209,130,181,207,76,184,244,53,79,123,130,195,166,164,145,154,120,168,49,151,254,219,26,230,46,15,85,167,193,95,143,129,241,51,73,35,62,189,164,92,89,164,202,191,127,183,144,31,61,8,143,200,74,164,193,59,219,122,161,106,40,36,181,225,76,58,82,64,118,24,168,60,7,74,127,134,228,253,237,102,110,67,26,42,2,226,229,229,223,149,147,72,108,45,240,46,245,124,221,195,12,237,81,192,92,111,218,173,251,145,188,252,2,129,237,3,11,29,31,111,63,121,253,229,205,120,160,121,239,255,0,22,86,42,241,53,6,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("036d92f0-de76-43ba-9d4d-3a87133b254f"));
		}

		#endregion

	}

	#endregion

}

