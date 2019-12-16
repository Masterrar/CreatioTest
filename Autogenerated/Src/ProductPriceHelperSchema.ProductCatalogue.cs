﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ProductPriceHelperSchema

	/// <exclude/>
	public class ProductPriceHelperSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ProductPriceHelperSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ProductPriceHelperSchema(ProductPriceHelperSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("70b4bee4-c8f3-41d2-b561-a02a76828ee7");
			Name = "ProductPriceHelper";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("741231e0-c6fd-4dea-b23f-a6b7a76d6de7");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,213,88,75,115,219,54,16,62,43,51,253,15,176,58,147,202,51,44,221,115,34,41,211,216,113,234,153,58,245,212,110,15,189,100,32,18,178,216,82,164,2,128,114,212,196,255,189,11,44,64,2,224,67,76,210,233,227,98,153,228,238,98,31,223,190,80,208,45,19,59,154,48,114,199,56,167,162,92,203,248,188,44,214,217,125,197,169,204,202,130,124,245,228,195,87,79,38,149,200,138,123,114,123,16,146,109,159,7,207,192,144,231,44,81,212,34,126,205,10,198,179,164,161,113,229,114,214,247,222,63,180,151,234,85,33,51,153,49,1,4,64,242,53,103,247,74,197,243,156,10,241,140,220,240,50,173,18,121,3,199,179,31,88,190,99,92,83,237,170,85,158,37,36,81,68,29,52,96,224,68,89,88,75,187,204,88,158,106,113,217,158,74,166,101,76,118,248,64,126,17,140,131,170,5,154,75,222,86,222,243,115,151,84,235,122,184,77,54,108,75,201,219,157,115,48,190,59,78,92,211,105,245,88,145,162,134,230,217,26,15,94,151,28,168,75,46,140,174,104,112,219,212,89,160,189,175,252,41,209,110,152,4,54,145,5,233,48,114,210,97,16,80,6,188,177,107,214,53,45,232,61,227,128,16,121,5,42,211,34,97,47,15,111,0,127,179,169,171,234,244,212,63,224,111,146,109,196,62,14,59,243,154,201,77,217,27,252,172,144,4,78,208,106,2,230,171,109,113,195,89,146,9,224,156,161,54,132,233,31,235,74,87,69,100,32,187,134,25,108,66,242,24,41,98,124,45,226,203,172,72,27,245,29,159,100,107,50,115,4,196,23,84,210,95,105,94,177,187,195,14,212,19,228,50,47,169,244,222,90,85,38,123,202,73,186,106,168,23,100,214,65,221,43,29,21,152,112,38,43,94,184,130,226,218,7,72,242,168,255,26,186,239,92,167,91,55,238,203,44,37,111,74,190,165,121,246,39,211,6,250,238,139,180,167,183,89,227,94,107,69,10,207,192,134,94,108,252,7,65,81,170,164,168,184,86,109,126,129,164,203,192,133,86,66,97,207,79,111,140,172,107,42,55,241,207,101,85,164,232,227,200,211,32,34,215,89,186,43,65,49,77,2,181,41,254,254,129,30,46,121,185,253,141,241,50,12,16,57,89,132,71,212,145,176,65,103,210,209,215,170,25,181,216,28,183,30,119,164,176,158,20,60,137,76,85,33,41,19,210,158,174,96,0,223,52,113,109,28,88,223,135,107,160,53,26,104,0,129,164,209,172,250,88,227,151,32,158,192,213,86,98,222,33,30,61,246,162,77,141,31,158,117,176,224,137,1,190,180,59,60,68,117,146,41,105,93,116,227,203,70,41,161,60,177,20,191,159,157,157,145,185,168,182,91,202,15,75,251,2,138,112,74,100,73,32,69,120,198,246,140,200,13,35,47,169,64,21,126,204,132,36,123,133,136,184,150,112,22,138,152,99,122,137,165,207,118,149,198,243,51,251,9,129,98,212,33,251,140,203,10,96,255,186,2,200,64,192,60,198,171,116,102,225,81,174,126,7,6,178,114,63,107,124,54,248,62,105,247,235,24,6,1,128,179,132,172,16,241,29,63,192,1,8,234,160,102,71,100,234,29,60,141,48,140,101,213,117,228,105,157,49,166,154,40,229,227,87,219,157,60,184,165,70,225,114,229,155,163,138,155,34,62,237,179,195,8,12,216,220,80,143,15,157,105,48,166,22,145,213,65,197,97,32,118,59,202,233,150,20,80,221,23,83,211,227,174,210,233,210,138,209,65,212,52,237,112,7,71,65,52,50,120,120,15,202,139,163,145,55,181,64,39,171,150,130,47,180,159,72,173,135,223,185,236,123,213,125,189,118,28,159,115,6,21,200,136,8,162,108,82,107,85,150,57,244,164,75,38,129,69,133,196,72,136,245,27,85,56,47,94,206,154,131,189,192,52,108,47,106,29,158,145,162,202,243,209,49,74,180,134,16,170,156,74,124,211,120,152,208,34,37,110,222,120,195,146,237,42,35,99,24,128,72,69,210,75,200,32,150,95,30,126,79,201,241,97,127,195,30,48,249,26,33,46,4,2,51,34,50,8,140,85,32,201,65,136,51,17,142,130,73,32,73,245,197,11,182,118,90,163,152,13,144,122,45,20,28,137,122,199,96,172,250,157,157,142,101,117,35,24,133,206,24,47,196,198,51,34,61,200,14,101,124,81,205,113,145,160,10,207,0,194,255,23,104,254,220,138,246,95,196,181,106,75,73,9,147,162,222,139,65,78,193,30,200,69,166,73,192,251,115,88,218,160,93,70,4,59,238,210,182,186,15,245,194,226,64,232,49,106,62,214,173,51,180,12,187,225,99,79,241,109,97,215,173,194,141,158,253,101,184,229,153,118,61,110,135,72,171,113,37,208,81,152,42,231,27,90,220,179,116,126,183,236,27,85,35,130,190,1,247,41,6,181,7,217,40,221,41,226,122,123,130,255,59,71,127,16,237,176,62,55,156,74,116,205,170,30,70,243,26,111,156,212,103,199,175,222,129,117,98,214,136,60,29,223,151,54,44,249,131,176,119,21,204,240,57,131,69,149,148,107,114,94,113,14,255,31,20,62,239,232,123,245,131,78,214,147,160,24,155,188,160,224,116,121,91,86,220,237,15,3,25,171,244,159,46,47,224,111,86,224,109,79,31,151,155,137,234,197,37,152,207,84,186,186,154,223,224,218,164,74,143,54,130,80,206,148,165,64,171,44,79,157,115,208,46,77,42,121,5,62,128,170,198,31,50,225,78,189,195,217,223,1,45,97,176,117,108,7,50,201,129,75,11,178,0,36,186,97,90,175,145,90,24,194,211,223,40,141,52,235,136,99,2,85,249,241,165,53,46,12,68,130,19,63,93,154,246,252,52,204,227,80,187,143,31,67,7,232,55,205,137,163,241,44,14,69,178,225,101,1,177,235,135,113,98,110,54,254,77,28,183,33,164,247,231,91,208,223,94,43,30,3,78,184,107,215,126,15,160,224,161,177,21,187,26,166,33,187,222,174,90,236,79,159,98,181,186,149,165,170,138,183,82,141,181,39,11,98,158,127,210,253,67,191,85,83,79,176,51,133,139,82,98,34,52,80,61,17,82,29,168,84,252,246,226,165,143,185,231,214,69,177,74,250,254,248,169,30,122,209,236,96,198,114,244,138,106,115,134,24,236,189,202,206,185,77,233,36,196,179,35,165,168,71,70,247,108,246,137,215,0,250,6,118,40,121,118,41,196,75,24,119,174,75,94,239,41,254,70,239,53,92,206,146,146,55,131,220,213,186,235,51,192,175,248,198,142,80,186,190,226,25,230,181,90,158,201,183,102,57,18,106,150,220,126,226,174,58,13,182,80,63,199,240,234,25,19,203,92,11,93,21,158,77,51,127,181,180,120,197,155,51,179,109,46,244,104,49,0,101,127,134,115,118,203,1,104,53,184,234,154,11,241,30,171,117,45,210,36,102,139,126,225,220,71,12,168,218,63,88,246,15,174,173,153,53,92,38,26,133,92,137,129,219,186,143,236,95,3,143,158,138,6,121,5,211,144,68,45,251,70,12,68,189,57,96,1,102,17,189,118,54,25,236,36,206,84,225,39,140,115,17,117,252,22,173,3,221,88,44,122,54,237,99,56,55,92,1,194,189,203,95,7,230,221,65,235,193,250,63,133,86,55,177,204,181,170,123,168,251,101,40,215,220,13,210,109,110,61,146,237,60,29,174,221,159,81,1,70,168,102,183,84,163,88,235,170,171,117,69,214,149,125,227,107,85,87,190,152,73,217,214,192,190,230,98,222,185,175,30,255,2,100,45,206,45,178,29,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("70b4bee4-c8f3-41d2-b561-a02a76828ee7"));
		}

		#endregion

	}

	#endregion

}
