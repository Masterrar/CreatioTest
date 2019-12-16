namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SocialMessageNotifierSchema

	/// <exclude/>
	public class SocialMessageNotifierSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SocialMessageNotifierSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SocialMessageNotifierSchema(SocialMessageNotifierSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f5268ed0-9504-4b95-a582-f1d27a5fc37c");
			Name = "SocialMessageNotifier";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("54cf5269-6f00-4e87-a6e6-8261561e21be");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,147,223,106,194,48,20,198,175,43,248,14,193,221,76,144,62,128,110,131,89,135,19,230,148,233,118,159,165,167,53,208,38,146,164,140,34,125,247,157,38,177,173,83,196,93,133,156,252,190,239,252,73,82,104,46,82,178,41,181,129,124,210,239,21,157,109,24,201,44,3,102,184,20,58,156,131,0,197,89,131,108,65,41,170,101,98,144,82,16,190,8,195,13,7,141,231,253,158,160,57,232,61,101,112,66,137,132,167,133,162,181,93,191,119,168,185,224,78,65,138,91,18,101,84,235,49,217,72,198,105,182,4,173,105,10,239,210,240,132,131,178,224,190,248,206,56,35,172,230,46,99,100,76,166,84,195,153,56,112,153,218,84,216,140,81,5,51,82,141,201,218,218,58,192,167,184,104,126,111,219,43,9,216,101,72,14,181,32,240,208,66,36,146,60,18,1,63,164,27,113,204,17,66,192,137,113,144,102,91,238,33,198,225,22,185,248,162,89,1,15,88,17,206,244,233,126,224,233,193,112,228,212,145,2,106,32,158,150,139,248,186,195,188,224,49,234,59,252,95,143,149,184,238,48,67,104,203,115,104,93,86,162,241,88,202,184,30,196,237,133,116,5,103,46,255,40,165,149,52,46,175,84,63,27,67,217,46,71,11,52,194,219,4,127,116,188,175,15,96,82,197,221,82,215,138,231,84,149,157,44,94,178,97,59,200,233,103,151,117,161,16,99,158,121,227,248,29,240,249,107,44,140,250,171,158,113,251,49,208,211,182,60,34,182,241,227,173,7,135,27,102,228,30,85,83,0,54,120,179,168,166,73,229,114,85,190,74,111,103,112,120,109,47,209,142,138,20,106,51,11,85,147,122,169,252,151,0,17,187,95,97,247,46,122,26,172,126,1,67,44,209,123,31,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f5268ed0-9504-4b95-a582-f1d27a5fc37c"));
		}

		#endregion

	}

	#endregion

}

