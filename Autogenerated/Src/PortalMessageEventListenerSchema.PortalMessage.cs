namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: PortalMessageEventListenerSchema

	/// <exclude/>
	public class PortalMessageEventListenerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public PortalMessageEventListenerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public PortalMessageEventListenerSchema(PortalMessageEventListenerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("7651591f-a66d-4dfa-8f74-cd990454a314");
			Name = "PortalMessageEventListener";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("c85d2d65-6230-4aeb-9934-bfac9785d42f");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,84,193,106,219,64,16,61,59,144,127,24,212,67,36,8,210,221,145,13,137,27,154,66,237,22,236,246,82,122,24,75,35,107,139,52,107,118,87,42,34,228,223,187,218,149,76,101,236,244,34,216,153,55,243,222,190,153,21,99,77,250,136,25,193,142,148,66,45,11,19,175,36,23,226,208,40,52,66,242,237,205,235,237,205,172,209,130,15,176,237,180,161,250,225,116,254,183,68,81,252,241,233,106,234,153,141,48,130,244,127,1,241,115,75,108,122,156,69,126,80,116,176,18,96,85,161,214,115,248,38,149,193,106,77,90,227,129,28,238,139,176,130,152,148,67,39,73,2,169,110,234,26,85,183,28,206,35,0,10,169,224,110,210,224,14,168,231,236,128,28,99,60,118,72,206,90,164,154,8,43,45,33,83,84,44,130,247,117,199,79,168,201,197,186,137,192,0,146,190,223,207,11,169,112,155,149,84,227,198,14,2,22,16,76,52,6,209,47,91,117,108,246,149,200,32,235,93,120,199,4,152,195,21,118,219,227,213,89,116,114,116,77,166,148,121,239,169,18,45,26,26,178,196,185,7,92,67,59,37,62,121,110,183,11,188,32,231,21,233,209,218,45,182,148,123,131,227,83,77,114,94,148,30,81,97,13,108,29,88,4,218,106,176,126,45,221,5,192,159,226,52,113,144,203,21,20,44,119,37,185,57,141,51,154,95,157,146,211,245,88,24,82,142,224,81,29,116,63,27,16,172,13,178,125,6,153,100,131,130,251,21,53,37,141,132,238,10,144,163,193,137,150,97,50,178,181,116,34,39,104,165,200,225,43,187,107,135,114,255,155,178,241,10,247,112,137,26,40,130,254,121,205,102,123,59,185,120,172,28,75,40,122,112,73,95,10,181,31,186,221,146,208,71,34,15,244,32,81,132,3,32,254,68,102,215,29,41,95,201,170,169,249,7,86,13,165,123,41,171,101,24,124,214,27,105,220,24,117,73,121,16,69,158,126,166,200,52,138,125,167,55,247,109,81,1,75,35,10,97,87,107,1,76,127,166,187,183,25,114,35,235,160,181,47,171,145,109,96,172,26,240,47,118,25,165,234,214,62,119,210,250,93,147,178,63,28,182,86,217,85,187,63,81,14,237,134,86,177,99,235,66,31,125,187,184,174,62,58,13,218,24,252,5,243,41,82,32,227,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("7651591f-a66d-4dfa-8f74-cd990454a314"));
		}

		#endregion

	}

	#endregion

}

