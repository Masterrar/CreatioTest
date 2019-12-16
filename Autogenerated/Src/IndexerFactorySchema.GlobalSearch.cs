﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IndexerFactorySchema

	/// <exclude/>
	public class IndexerFactorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IndexerFactorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IndexerFactorySchema(IndexerFactorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("7dd97aab-f6c9-494a-bc55-6550dca89127");
			Name = "IndexerFactory";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("3c3a921b-299a-4f38-a040-5c0154a25bee");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,189,86,235,106,219,48,20,254,237,64,223,65,116,80,92,24,122,128,165,105,200,114,35,176,142,174,105,246,119,40,246,113,34,38,203,158,36,135,153,146,119,159,46,118,106,59,86,74,25,27,9,196,58,183,239,59,23,29,135,147,20,100,78,34,64,207,32,4,145,89,162,240,52,227,9,221,21,130,40,154,113,188,100,217,150,176,53,16,17,237,175,6,47,87,131,160,144,148,239,208,186,148,10,210,97,231,140,191,80,254,235,85,216,12,42,0,207,185,162,138,130,244,26,44,72,164,50,225,177,104,50,193,43,30,195,111,173,55,134,250,251,65,192,78,179,69,83,70,164,252,132,172,22,132,11,87,94,13,180,69,94,108,25,141,80,100,12,206,244,193,139,181,57,133,89,80,96,177,142,243,40,232,129,40,112,202,220,29,144,0,18,103,156,149,104,114,32,148,145,45,131,154,76,157,31,250,65,124,170,97,5,4,60,118,88,109,96,93,123,169,68,97,104,25,120,203,185,66,119,252,219,204,67,63,5,47,131,91,100,154,24,4,126,142,104,228,247,54,245,14,142,151,147,120,0,181,207,188,229,219,102,25,67,75,80,43,249,4,132,41,136,109,232,242,21,200,192,198,161,147,34,176,63,53,103,1,170,16,188,18,226,141,4,161,11,198,33,114,147,106,98,46,128,104,19,168,163,92,55,135,230,9,24,57,195,187,190,109,166,212,34,57,221,67,244,115,37,117,22,41,17,229,52,99,69,202,167,123,194,119,93,122,31,145,59,78,18,5,98,126,208,194,137,216,201,74,217,22,214,153,28,136,64,105,22,211,132,66,236,34,127,39,172,48,181,183,234,160,207,119,140,31,250,60,198,99,13,95,164,32,76,202,120,158,230,170,188,115,124,26,102,247,161,203,211,2,231,46,163,25,149,57,35,149,213,134,198,186,239,186,134,143,253,202,176,234,132,139,66,19,20,122,163,140,16,47,24,171,51,173,155,150,16,38,193,121,31,155,205,236,171,2,158,240,50,140,172,0,141,238,145,123,194,206,2,111,86,22,195,3,223,219,206,101,65,227,241,165,228,122,167,205,148,202,73,214,209,30,82,162,235,83,77,158,59,15,123,173,250,32,78,158,206,4,247,217,12,207,39,220,31,112,108,170,224,29,92,123,19,234,1,159,129,210,119,57,212,107,197,172,83,105,67,126,213,107,191,115,167,252,235,0,187,8,198,71,154,151,131,62,112,25,54,2,189,111,39,156,239,180,207,68,66,181,215,12,245,69,38,86,92,95,109,213,223,21,51,122,125,9,182,90,99,121,117,39,208,190,28,170,205,105,182,197,157,243,172,160,79,55,164,53,157,103,62,13,178,181,199,241,141,108,54,121,172,91,243,215,43,227,63,37,126,130,185,184,158,235,158,220,220,56,164,75,187,178,206,184,55,185,55,185,126,43,64,255,35,136,255,121,151,102,192,64,119,169,115,45,222,17,185,51,250,78,218,22,186,207,241,15,29,75,5,121,118,9,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("7dd97aab-f6c9-494a-bc55-6550dca89127"));
		}

		#endregion

	}

	#endregion

}
