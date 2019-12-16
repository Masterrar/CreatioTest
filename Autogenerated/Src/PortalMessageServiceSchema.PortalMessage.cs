﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: PortalMessageServiceSchema

	/// <exclude/>
	public class PortalMessageServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public PortalMessageServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public PortalMessageServiceSchema(PortalMessageServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("682b4b54-7423-4e8e-957d-1e0d6b0c9c0f");
			Name = "PortalMessageService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("954528c0-fb67-4d4c-88f7-007a094e70cf");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,84,201,110,219,48,16,61,43,64,254,97,224,94,28,32,144,238,89,12,196,78,179,20,112,18,216,41,114,48,122,160,164,145,205,70,36,85,146,74,160,26,249,247,112,145,109,73,94,82,244,98,88,51,111,222,12,223,60,146,19,134,170,32,9,194,51,74,73,148,200,116,56,18,60,163,243,82,18,77,5,63,62,90,30,31,5,165,162,124,14,211,74,105,100,231,157,239,112,82,114,77,25,134,83,148,148,228,244,175,171,219,66,153,236,27,77,112,44,82,204,15,38,195,171,68,211,183,175,73,194,23,140,55,128,230,248,140,53,75,155,25,137,251,226,225,245,112,111,234,187,57,159,166,168,118,1,204,16,7,58,110,178,171,209,39,162,212,6,99,192,6,254,77,226,220,28,19,70,57,81,234,12,158,132,212,36,31,163,82,100,142,53,222,225,162,40,130,11,85,50,70,100,53,168,191,235,60,100,66,194,187,144,175,182,241,59,213,11,40,28,11,48,79,163,194,85,125,212,32,152,213,213,102,213,90,146,68,255,114,49,85,52,134,68,23,187,82,197,3,106,115,132,194,44,36,166,57,213,213,4,255,148,84,34,67,174,85,191,249,97,183,2,151,240,69,137,69,133,117,32,61,177,77,138,50,206,105,2,137,21,97,167,6,112,6,67,162,54,138,4,75,167,202,90,190,49,234,133,72,173,128,142,201,39,187,154,185,192,45,106,213,17,8,136,214,146,198,230,192,10,18,193,57,38,26,83,208,2,46,10,34,9,147,152,1,55,151,228,178,87,227,239,168,210,66,86,247,105,47,26,132,235,70,81,183,147,175,222,87,58,24,183,34,64,83,35,13,205,40,202,240,34,114,149,187,137,22,30,63,77,22,200,200,131,9,245,6,254,191,203,131,200,160,70,128,136,127,155,147,108,179,73,212,165,228,106,224,117,6,83,74,215,82,24,244,42,109,241,179,199,2,253,35,208,180,73,48,51,166,190,231,111,226,21,251,94,120,179,243,222,211,227,244,185,119,10,118,175,168,244,141,144,140,104,19,55,208,250,164,62,20,254,80,130,159,194,80,164,213,84,87,57,182,32,235,104,248,34,73,81,96,122,106,219,5,19,243,64,9,174,240,48,169,115,210,202,74,83,76,74,137,45,43,93,109,182,108,76,176,39,213,191,45,105,10,221,109,249,49,2,101,80,230,142,109,173,224,4,150,14,224,165,3,142,239,187,250,247,127,42,148,35,239,47,163,232,73,120,131,58,89,108,90,15,171,182,37,250,123,166,216,110,111,223,157,224,163,190,17,200,83,127,41,220,183,143,118,130,157,71,231,160,86,174,96,118,77,52,105,90,160,117,97,191,168,15,156,56,142,98,140,44,70,217,183,67,91,203,44,140,233,31,185,47,236,181,214,23,11,145,195,93,35,13,75,152,163,62,7,101,127,234,163,238,162,204,164,96,123,9,111,214,201,127,165,171,87,240,92,21,216,230,115,54,25,111,178,255,65,56,34,133,245,65,155,183,182,216,120,11,214,109,176,115,179,31,159,40,19,77,191,205,7,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("682b4b54-7423-4e8e-957d-1e0d6b0c9c0f"));
		}

		#endregion

	}

	#endregion

}

