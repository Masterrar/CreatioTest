namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ImapAppEventListenerSchema

	/// <exclude/>
	public class ImapAppEventListenerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ImapAppEventListenerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ImapAppEventListenerSchema(ImapAppEventListenerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("658bca78-1cb6-4a31-8066-4b35f067fddd");
			Name = "ImapAppEventListener";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,83,91,107,194,48,20,126,86,240,63,100,250,162,224,234,16,183,135,57,132,106,43,8,243,130,237,216,227,136,205,105,23,104,147,146,68,153,12,255,187,105,139,243,178,182,235,158,66,190,243,93,146,147,19,134,35,144,49,246,0,185,32,4,150,220,87,198,132,51,159,6,91,129,21,229,172,81,255,110,212,107,91,73,89,128,102,76,65,144,193,102,76,13,59,194,52,28,22,85,147,173,240,181,179,60,83,46,51,4,24,83,236,41,46,104,62,99,126,101,126,198,223,97,163,213,81,196,153,174,234,122,75,64,160,35,209,36,196,82,62,163,89,132,99,51,142,237,29,48,245,74,165,2,6,34,229,197,219,77,72,61,228,37,180,92,150,214,254,22,214,146,219,255,100,204,65,125,114,162,83,86,169,89,234,123,50,222,113,74,208,82,95,61,118,20,22,170,125,242,210,221,84,240,165,144,151,173,29,164,29,91,212,71,119,11,219,117,92,115,97,153,107,171,255,241,128,122,61,228,46,173,37,154,172,231,247,131,254,227,224,41,241,174,165,183,202,250,180,55,198,148,145,151,153,179,103,158,163,116,163,33,216,119,145,165,215,49,150,64,46,225,81,187,153,139,55,59,195,106,174,211,16,7,153,154,50,15,18,175,27,251,114,66,229,156,55,74,242,14,159,7,255,223,51,57,89,145,241,109,173,178,187,163,159,52,85,155,140,88,2,251,74,222,68,148,19,210,156,22,48,66,253,162,188,244,91,173,4,223,81,2,162,139,174,182,163,118,118,206,67,193,232,217,140,148,14,94,129,210,1,41,245,124,255,61,184,229,250,202,233,73,3,178,47,165,119,25,118,9,29,142,186,65,20,105,150,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("658bca78-1cb6-4a31-8066-4b35f067fddd"));
		}

		#endregion

	}

	#endregion

}

