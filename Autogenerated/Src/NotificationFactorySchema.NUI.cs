﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: NotificationFactorySchema

	/// <exclude/>
	public class NotificationFactorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public NotificationFactorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public NotificationFactorySchema(NotificationFactorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("a9587f5f-b07f-4d96-b18e-df6bed9079ad");
			Name = "NotificationFactory";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("edbaf284-b37c-4101-84cb-76a44645334f");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,84,93,107,219,48,20,125,78,161,255,225,46,133,98,67,112,96,143,105,26,8,33,25,129,37,221,104,183,151,49,138,236,92,187,222,108,41,72,242,86,179,230,191,239,74,242,103,112,59,150,7,197,146,238,199,57,231,222,43,206,114,84,71,22,33,60,160,148,76,137,88,7,43,193,227,52,41,36,211,169,224,151,23,127,46,47,70,133,74,121,2,247,165,210,152,223,52,251,174,75,158,11,62,124,35,241,181,243,96,195,34,45,100,138,170,181,72,50,17,178,108,54,115,17,131,143,34,73,232,152,238,201,226,74,98,66,144,96,149,49,165,102,176,23,58,141,211,200,194,116,145,74,107,118,44,194,44,141,32,50,86,67,70,48,131,237,160,239,200,80,109,178,108,82,204,14,148,230,147,76,127,49,141,54,244,232,232,54,32,145,29,4,207,74,248,162,80,146,96,28,35,19,10,30,139,222,254,166,235,163,52,165,139,90,215,45,145,131,199,140,150,91,160,207,29,227,44,65,25,124,64,109,88,163,244,198,93,148,106,236,59,21,70,87,200,15,14,99,181,175,101,33,35,45,11,69,100,12,108,171,66,133,218,41,50,64,218,59,195,223,135,239,131,85,100,116,198,138,240,14,208,60,189,141,110,135,250,73,188,170,103,40,68,6,196,124,171,108,113,119,76,254,196,195,82,221,133,74,100,168,209,123,40,143,232,42,106,190,106,92,34,252,65,0,190,125,7,166,181,76,195,66,163,34,108,141,153,145,114,101,244,200,151,205,189,167,233,66,196,94,29,185,185,241,39,64,226,161,111,185,140,36,234,66,114,120,215,6,14,182,106,95,100,217,157,92,231,71,93,122,254,255,113,238,20,99,58,157,194,92,21,121,206,100,185,168,15,86,212,21,6,125,74,37,100,156,198,49,44,97,126,100,146,229,18,99,224,52,165,68,108,108,153,237,105,51,158,46,130,38,214,244,60,152,115,180,94,183,29,159,133,89,65,196,78,160,96,62,181,102,173,151,227,172,22,219,26,3,153,254,3,195,124,90,59,117,218,172,55,92,21,179,58,166,71,29,106,198,188,137,82,151,178,95,96,74,84,23,208,252,123,173,185,43,79,26,131,215,49,190,5,78,165,129,151,23,176,183,64,63,239,172,103,3,219,92,27,194,82,72,92,115,22,102,120,232,15,216,215,247,99,31,174,175,223,234,194,182,1,253,26,119,221,41,6,128,195,118,178,107,197,147,236,49,15,179,242,115,193,50,202,132,135,189,147,177,237,209,229,144,133,139,164,233,173,234,103,177,176,170,209,13,54,66,70,72,104,231,61,193,23,222,96,206,137,139,51,226,248,187,126,40,76,148,165,76,138,28,185,246,198,125,185,198,147,243,167,204,175,164,63,1,229,137,158,192,91,63,71,120,180,37,198,231,70,13,243,156,5,107,41,133,244,240,57,216,161,82,244,166,77,140,69,87,156,115,205,6,198,168,58,235,30,157,254,2,175,255,73,140,173,6,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a9587f5f-b07f-4d96-b18e-df6bed9079ad"));
		}

		#endregion

	}

	#endregion

}

