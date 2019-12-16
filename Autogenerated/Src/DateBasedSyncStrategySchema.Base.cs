﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: DateBasedSyncStrategySchema

	/// <exclude/>
	public class DateBasedSyncStrategySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public DateBasedSyncStrategySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public DateBasedSyncStrategySchema(DateBasedSyncStrategySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("9268c52e-f894-4e71-8c25-639c288db644");
			Name = "DateBasedSyncStrategy";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("e0bd8020-de17-4815-83cd-c2dac7bbc324");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,85,75,79,219,64,16,62,7,137,255,48,13,151,88,10,14,66,180,7,94,21,77,2,138,68,2,37,166,87,180,216,147,176,234,122,215,221,93,7,82,196,127,239,172,31,193,118,29,90,14,33,59,143,111,190,121,70,178,24,77,194,66,132,0,181,102,70,45,172,63,101,92,236,238,188,238,238,116,82,195,229,18,230,107,99,49,62,105,188,253,43,161,30,153,224,191,153,229,74,190,107,223,113,134,42,142,183,105,228,130,47,83,93,186,238,241,5,124,154,141,131,121,112,49,27,93,220,141,14,31,14,96,48,128,224,102,116,3,195,187,233,254,209,225,231,163,47,27,156,154,183,63,137,89,226,32,80,70,124,209,26,75,99,59,7,141,254,88,90,110,57,26,50,32,147,61,141,75,130,132,161,96,198,28,195,136,89,252,198,12,70,243,181,12,231,150,226,225,114,157,25,14,136,220,169,73,227,152,233,245,249,230,141,8,161,198,197,89,119,82,117,232,14,206,129,199,137,192,24,165,101,220,42,217,135,8,5,95,161,198,8,22,90,197,85,215,134,167,95,130,15,154,209,52,210,243,167,41,223,173,92,33,37,1,88,5,6,5,134,22,152,16,32,149,221,143,52,91,216,126,254,149,52,150,140,104,10,12,91,162,233,23,120,84,44,154,137,10,177,214,0,254,3,85,202,58,137,83,215,248,86,248,37,233,163,224,33,132,174,170,91,136,30,67,189,198,157,215,172,206,155,142,92,114,20,17,181,228,86,243,21,153,228,202,102,23,154,109,40,230,212,69,12,120,236,232,193,138,137,20,251,121,93,184,164,186,232,240,9,126,165,168,215,192,76,145,116,194,52,45,133,69,237,111,48,171,213,239,36,57,7,40,113,161,86,132,147,130,56,141,99,206,189,158,200,173,86,9,106,187,118,169,40,75,77,193,232,131,100,230,200,28,65,124,73,52,245,199,249,83,66,137,160,48,91,185,21,160,176,226,218,166,76,128,177,218,205,253,189,52,68,112,106,150,57,228,119,151,178,115,112,91,222,233,44,209,66,254,173,163,209,166,90,66,247,126,54,186,187,184,12,128,254,143,175,199,193,120,4,243,201,108,56,134,215,131,183,238,73,102,250,230,62,223,62,78,151,86,149,8,164,161,85,218,117,47,27,132,220,162,24,138,214,113,232,221,83,99,200,85,82,42,14,37,173,61,251,144,109,237,26,92,70,115,180,150,242,51,94,193,159,14,73,175,42,135,179,51,144,169,16,153,254,127,207,12,253,217,39,173,158,65,226,51,184,251,50,126,9,49,113,177,123,78,114,173,194,236,238,61,10,156,103,213,237,213,9,250,119,104,84,170,67,210,42,77,75,213,135,246,237,233,246,243,88,157,238,95,136,198,39,209,76,149,89,248,63,220,220,118,61,63,80,69,68,207,203,110,158,48,216,228,59,83,118,82,158,27,140,222,153,123,213,35,89,116,175,179,153,97,161,88,52,142,233,240,155,75,186,72,78,12,103,148,40,139,202,103,176,78,208,191,66,59,161,134,50,90,147,70,206,158,211,85,237,107,93,240,78,26,209,42,11,67,113,170,166,14,199,197,138,134,74,164,177,204,18,63,45,29,207,123,221,235,234,193,41,112,31,26,120,45,201,156,215,99,126,109,179,57,134,198,34,255,115,188,167,104,159,84,212,152,236,218,38,111,251,85,112,105,182,237,36,29,169,198,70,231,123,162,232,231,66,243,8,203,125,222,226,222,43,247,160,88,227,220,218,191,84,58,102,182,215,230,81,204,96,173,132,239,99,246,192,105,250,157,40,71,232,195,48,21,4,140,19,185,80,254,68,174,152,230,76,218,66,232,121,31,212,44,151,86,133,111,127,0,54,11,233,24,124,8,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateLocNoSettingsLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateLocNoSettingsLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("ae34ce39-8021-4700-a745-d8b45529f0a2"),
				Name = "LocNoSettings",
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("9268c52e-f894-4e71-8c25-639c288db644"),
				ModifiedInSchemaUId = new Guid("9268c52e-f894-4e71-8c25-639c288db644")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("9268c52e-f894-4e71-8c25-639c288db644"));
		}

		#endregion

	}

	#endregion

}
