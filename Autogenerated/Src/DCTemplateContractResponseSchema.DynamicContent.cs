namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: DCTemplateContractResponseSchema

	/// <exclude/>
	public class DCTemplateContractResponseSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public DCTemplateContractResponseSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public DCTemplateContractResponseSchema(DCTemplateContractResponseSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("3fd21c44-491c-46a0-85b5-eea55b81914b");
			Name = "DCTemplateContractResponse";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("ad993b20-8db8-48d6-9762-5a83fb4975c6");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,80,59,111,194,48,16,158,139,196,127,56,209,161,155,179,67,203,2,107,37,4,108,85,7,99,46,193,40,182,35,251,220,42,69,252,247,94,156,135,66,81,171,46,150,253,249,238,123,89,105,48,84,82,33,236,209,123,25,92,78,98,229,108,174,139,232,37,105,103,197,186,182,210,104,197,32,161,165,233,228,50,157,60,196,160,109,1,187,58,16,26,177,141,150,180,65,177,67,175,101,169,191,210,218,98,152,250,31,175,88,75,146,205,221,75,69,188,204,235,143,30,11,30,132,85,41,67,152,195,122,181,71,83,149,146,176,31,219,178,115,103,3,166,233,44,203,224,57,68,99,164,175,151,221,187,31,0,213,80,192,231,73,171,19,40,222,150,218,6,158,70,254,241,152,191,204,238,185,103,217,18,58,22,105,143,144,71,171,26,215,156,143,106,112,57,208,9,199,4,55,209,184,136,15,173,176,87,103,42,49,24,162,232,89,154,58,181,167,0,218,230,206,155,182,146,62,70,54,202,241,54,46,230,157,129,42,30,74,173,186,72,191,151,2,115,248,203,20,19,93,82,111,67,205,27,239,42,244,164,145,187,222,36,141,246,255,103,177,9,232,85,83,155,141,44,184,195,25,21,137,97,99,156,161,13,241,138,230,128,190,137,208,103,184,119,15,119,192,5,10,164,5,132,230,184,118,142,209,30,91,211,233,221,162,183,224,245,27,184,140,116,172,216,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("3fd21c44-491c-46a0-85b5-eea55b81914b"));
		}

		#endregion

	}

	#endregion

}

