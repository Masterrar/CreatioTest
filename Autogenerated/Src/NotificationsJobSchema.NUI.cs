﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: NotificationsJobSchema

	/// <exclude/>
	public class NotificationsJobSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public NotificationsJobSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public NotificationsJobSchema(NotificationsJobSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("3c6e0d65-7ec4-45eb-b1be-36536febb84e");
			Name = "NotificationsJob";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("edbaf284-b37c-4101-84cb-76a44645334f");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,84,201,110,219,48,16,61,59,64,254,97,224,94,100,192,144,239,241,18,184,142,93,184,104,147,52,75,47,65,16,80,210,200,97,64,145,6,73,165,53,130,254,123,71,164,100,211,138,157,246,34,113,121,179,188,55,51,148,172,64,179,102,41,194,29,106,205,140,202,109,60,83,50,231,171,82,51,203,149,60,61,121,59,61,233,148,134,203,21,220,110,140,197,98,216,218,19,94,8,76,43,176,137,191,160,68,205,211,29,38,116,171,241,216,121,188,96,169,85,154,163,57,138,184,77,159,49,43,5,234,227,8,235,35,208,253,39,141,43,202,7,102,130,25,115,6,151,202,242,156,167,142,144,249,170,18,135,25,12,6,48,50,101,81,48,189,153,212,123,135,7,149,131,12,45,224,69,37,113,99,49,8,76,214,101,34,120,10,169,179,106,7,129,51,88,210,111,254,27,211,146,50,35,248,155,139,187,75,142,112,150,73,75,9,94,107,254,202,44,250,251,181,223,64,90,221,131,177,186,226,186,152,79,239,238,111,230,79,179,171,139,57,140,161,187,23,237,74,94,73,116,185,83,192,238,176,211,169,3,161,204,124,172,106,31,134,94,112,20,217,177,184,159,149,18,200,228,57,60,113,179,64,102,75,141,115,201,18,129,217,48,132,105,100,153,146,98,3,203,25,163,218,56,245,225,201,236,138,208,138,223,34,174,203,170,226,85,14,78,196,58,5,47,104,91,202,168,7,85,23,118,58,222,61,241,119,209,98,23,248,193,125,191,225,43,138,120,186,94,139,218,238,113,232,45,218,28,200,216,123,161,94,181,63,153,40,113,212,16,158,68,161,202,125,144,165,16,61,231,230,207,199,132,190,163,125,86,71,245,76,200,253,57,44,91,121,68,247,6,53,41,33,253,232,64,185,183,109,8,243,28,162,3,20,198,62,183,26,116,144,228,190,191,138,236,187,12,66,182,158,103,163,240,67,120,245,88,73,118,176,21,42,93,232,171,145,46,228,17,204,127,75,23,180,65,123,52,221,129,31,36,220,78,227,251,113,244,39,107,166,89,1,146,30,182,113,119,95,132,238,164,210,188,154,171,70,149,209,192,161,15,27,187,53,90,212,166,59,185,222,174,33,87,26,184,155,220,148,146,113,179,191,231,167,238,225,87,197,179,38,231,143,107,221,135,229,5,119,43,226,49,242,243,222,7,149,188,208,245,4,118,89,132,61,241,174,150,237,246,161,22,161,17,195,109,139,132,35,181,148,185,186,41,9,171,65,251,223,216,191,124,254,21,222,196,11,165,83,164,142,25,29,182,154,68,222,103,199,110,214,168,242,232,48,170,23,79,141,193,34,17,155,31,37,19,4,192,236,146,152,244,107,91,137,191,194,135,96,170,87,101,129,210,70,237,154,245,219,147,241,79,7,65,221,250,161,124,77,139,123,206,49,101,25,245,130,54,62,208,168,245,89,120,68,39,127,1,0,181,95,86,52,7,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("3c6e0d65-7ec4-45eb-b1be-36536febb84e"));
		}

		#endregion

	}

	#endregion

}
