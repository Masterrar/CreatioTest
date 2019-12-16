﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SequenceSettingsServiceSchema

	/// <exclude/>
	public class SequenceSettingsServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SequenceSettingsServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SequenceSettingsServiceSchema(SequenceSettingsServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("67d85461-7e33-4b25-8c30-d4ece35987d1");
			Name = "SequenceSettingsService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,221,83,193,110,218,64,16,61,19,41,255,176,242,201,72,200,190,55,4,9,136,90,181,18,161,138,211,230,128,122,88,236,129,174,106,239,186,59,99,87,86,149,127,239,236,218,6,19,34,90,169,61,245,96,204,206,206,155,55,243,230,89,203,2,176,148,41,136,71,176,86,162,217,81,180,52,122,167,246,149,149,164,140,190,190,250,121,125,53,170,80,233,189,72,26,36,40,162,4,108,173,82,88,153,12,242,155,75,151,209,60,37,85,251,50,151,243,158,96,123,76,24,54,98,33,186,91,188,118,197,8,190,46,10,95,153,239,227,56,22,83,172,138,66,218,102,214,157,19,248,94,129,230,209,16,136,24,142,252,199,147,70,61,32,30,32,54,93,71,60,61,89,153,210,23,23,155,99,121,15,196,68,37,79,177,85,185,162,230,129,171,42,11,5,104,194,112,120,112,163,136,91,241,27,136,203,138,186,64,54,118,36,101,181,205,85,42,210,92,34,30,122,78,186,150,187,166,222,136,133,68,232,14,140,113,59,57,155,217,7,222,1,29,7,79,43,107,153,84,212,50,175,252,212,231,99,183,145,82,90,89,8,205,102,184,13,176,193,142,253,158,207,193,204,253,10,179,19,28,239,132,156,198,62,255,8,183,64,149,213,56,59,16,123,194,105,220,199,93,226,102,93,66,107,169,161,194,163,13,111,242,189,174,205,55,8,87,64,95,77,198,18,6,31,215,201,99,48,17,78,38,64,122,107,108,33,137,227,156,186,2,68,185,135,54,20,125,64,163,39,98,97,178,38,161,38,135,147,148,67,52,122,178,178,44,33,155,56,186,7,118,187,209,8,151,107,250,189,244,139,81,44,32,171,218,207,246,217,141,22,34,89,103,200,83,173,198,194,239,101,84,75,203,86,107,211,87,178,100,22,13,63,14,91,225,72,248,137,157,200,50,104,72,157,32,227,155,51,24,99,6,21,34,230,95,52,142,98,109,239,96,39,171,156,194,23,212,109,137,86,240,3,212,225,150,173,7,218,182,219,180,103,255,201,188,238,159,100,232,159,127,227,155,174,218,153,107,78,192,36,109,219,99,48,243,175,139,200,255,218,111,181,81,153,91,195,31,24,110,226,205,121,212,238,47,13,56,116,220,210,130,36,182,219,60,39,176,61,50,124,73,63,160,238,157,229,158,231,95,166,30,49,5,87,6,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("67d85461-7e33-4b25-8c30-d4ece35987d1"));
		}

		#endregion

	}

	#endregion

}
