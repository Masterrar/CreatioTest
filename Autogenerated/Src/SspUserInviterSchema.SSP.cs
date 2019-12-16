﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SspUserInviterSchema

	/// <exclude/>
	public class SspUserInviterSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SspUserInviterSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SspUserInviterSchema(SspUserInviterSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("35314301-48db-4886-bb11-d28d71215caa");
			Name = "SspUserInviter";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("7cc31540-fa76-4c79-9b86-a6eabd8e662c");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,88,75,111,219,56,16,62,187,64,255,3,171,94,100,32,160,239,117,156,194,73,220,214,139,108,155,141,155,205,113,193,72,180,77,84,38,85,146,74,226,22,249,239,59,124,73,148,44,197,109,129,32,146,200,121,126,243,224,208,156,236,168,42,73,70,209,87,42,37,81,98,173,241,133,224,107,182,169,36,209,76,112,188,90,93,191,126,245,243,245,171,81,165,24,223,160,213,94,105,186,155,118,190,129,167,40,104,102,24,20,254,72,57,149,44,59,160,185,36,154,28,44,94,49,254,189,89,140,141,216,237,4,239,223,145,116,104,29,95,158,247,109,221,209,251,23,4,154,221,79,90,151,120,126,175,180,36,206,139,174,161,43,170,53,124,41,52,67,86,81,7,164,189,10,4,192,8,172,111,37,221,192,6,186,40,136,82,239,208,74,149,183,138,202,37,127,96,154,74,75,49,153,76,208,169,170,118,59,34,247,103,254,219,82,163,199,45,203,182,136,89,90,84,1,155,66,90,160,82,72,77,10,28,56,39,17,107,89,221,23,44,67,153,229,238,170,26,153,216,193,95,109,210,181,20,37,149,154,81,176,11,222,53,132,141,230,214,164,3,155,236,130,145,134,50,193,185,139,47,174,9,99,19,70,101,144,100,233,47,106,242,238,167,177,102,52,218,80,109,0,30,61,59,189,165,100,15,4,156,5,248,13,226,255,145,178,188,149,197,116,208,164,115,162,40,2,34,240,218,226,143,42,89,28,181,203,11,159,91,217,104,118,22,212,160,247,239,81,26,222,103,232,35,213,243,70,50,172,165,227,241,244,5,120,226,152,61,10,249,13,61,50,189,53,73,51,207,119,140,223,114,166,79,21,165,40,147,116,61,75,150,62,58,118,143,153,108,211,66,38,147,51,23,187,163,46,244,178,163,222,197,159,200,96,140,148,249,231,81,126,75,121,238,114,192,127,247,37,132,77,165,151,220,173,11,29,137,181,79,74,159,171,234,4,94,148,38,60,163,202,108,234,45,237,113,221,38,166,197,246,168,223,46,173,175,192,167,211,67,238,51,212,164,185,47,186,65,15,33,255,0,151,42,3,96,192,199,242,152,143,75,8,26,35,5,251,1,126,16,196,233,99,237,151,119,11,69,126,181,235,237,23,125,106,51,165,157,26,169,90,159,99,95,51,145,187,144,166,198,170,33,100,210,241,180,230,136,196,206,58,130,29,81,111,246,56,249,125,91,105,199,184,184,140,135,224,255,155,234,173,200,109,187,177,117,222,91,244,61,117,231,29,127,32,210,39,218,10,156,119,85,218,110,202,112,228,232,127,73,81,209,14,146,39,40,185,142,25,147,19,175,13,47,118,165,222,143,241,21,93,235,47,235,27,182,217,234,157,80,240,154,38,147,196,163,199,214,40,245,212,75,245,185,42,138,47,210,114,165,45,91,198,193,202,145,164,186,146,28,153,147,4,44,208,244,9,142,164,74,74,202,53,122,3,120,130,0,71,55,122,143,224,196,185,213,172,96,166,230,140,237,215,196,144,117,220,239,17,132,111,232,247,138,42,61,246,146,222,253,58,14,127,130,192,243,200,30,28,193,179,150,223,125,237,123,69,77,107,64,23,146,194,87,220,1,255,169,168,220,167,54,93,63,86,44,63,115,167,90,64,206,139,183,25,103,37,116,172,247,222,154,25,163,218,241,52,81,57,120,145,44,243,164,187,145,153,245,197,142,176,162,127,203,176,224,185,74,19,3,43,156,243,61,34,156,236,207,48,21,213,91,31,164,216,165,73,236,142,33,81,13,175,133,176,130,58,254,75,48,94,11,247,170,178,154,236,75,45,62,82,15,169,181,248,94,145,34,178,208,147,223,109,169,164,177,179,120,201,83,103,38,134,124,1,11,65,163,74,29,146,99,68,148,7,175,47,48,15,130,229,104,14,96,154,47,3,174,106,21,151,149,241,85,120,196,161,186,162,86,227,237,120,50,7,230,19,142,81,88,230,38,175,77,60,125,46,13,247,19,220,210,125,190,95,230,222,240,90,41,246,145,55,171,70,149,121,118,180,141,241,87,97,82,200,157,199,253,62,222,80,146,27,29,102,212,172,93,236,230,221,31,59,136,93,104,126,199,212,166,149,88,213,120,206,247,105,211,50,2,248,198,92,39,213,86,138,153,49,7,106,200,133,219,73,245,243,105,122,121,190,120,162,89,101,250,118,126,111,94,189,131,77,5,225,5,87,149,164,151,231,205,82,100,69,144,179,52,102,24,4,193,47,233,30,179,62,243,176,83,71,29,105,234,116,70,226,70,48,12,21,20,165,78,6,54,100,177,182,198,109,0,120,134,188,42,211,186,92,118,219,6,230,226,149,218,196,159,30,48,118,34,248,129,241,124,32,128,179,153,215,20,73,9,209,8,109,57,54,109,100,163,105,123,8,40,233,55,205,53,80,48,206,183,154,105,135,219,152,102,58,200,113,1,174,207,116,249,235,246,48,40,192,131,19,245,145,70,198,115,120,11,47,254,233,30,207,67,149,3,71,200,66,74,33,63,8,105,139,244,14,166,88,81,105,235,98,211,45,6,234,166,247,152,124,114,48,142,199,24,100,46,72,182,117,180,30,107,136,84,149,193,160,104,170,113,77,10,69,167,97,221,154,17,38,28,145,153,57,140,220,23,116,101,117,116,142,6,124,7,19,183,189,191,66,154,41,81,201,12,232,132,36,27,122,226,189,239,206,103,208,76,15,132,170,0,249,39,162,62,11,107,53,182,64,215,7,97,111,199,185,23,162,64,23,91,154,125,91,174,231,69,225,44,131,115,26,122,67,231,104,123,19,227,102,90,192,47,160,246,155,131,213,241,123,220,10,132,32,106,51,219,94,81,90,179,251,209,171,199,3,147,26,206,169,144,44,60,247,238,28,30,36,16,237,102,76,29,110,180,46,250,30,224,53,92,169,33,67,80,90,183,6,119,251,101,188,43,179,213,59,75,24,180,225,206,149,223,208,76,60,184,198,121,37,54,80,252,97,184,242,73,224,126,146,32,166,101,57,194,107,207,120,197,248,183,131,89,169,209,95,151,242,137,191,54,134,58,187,1,252,237,217,6,12,159,104,81,218,54,215,93,10,202,107,180,236,158,13,239,75,58,45,65,107,165,174,243,19,20,138,187,235,57,14,30,93,108,9,223,208,198,212,231,223,74,163,99,55,163,121,158,183,243,166,249,101,34,92,2,81,86,223,16,7,146,202,174,148,102,132,65,28,176,157,37,142,51,57,115,179,186,235,240,62,45,143,93,32,79,39,86,80,124,183,114,195,78,238,19,52,61,100,243,178,251,122,26,176,165,126,55,174,191,129,91,162,5,160,140,140,118,191,2,192,48,111,18,215,121,19,74,161,116,151,236,253,203,247,194,80,101,131,119,94,39,174,61,194,181,135,30,63,133,189,220,206,155,177,100,160,127,213,101,214,153,26,167,97,4,138,26,64,148,104,161,225,181,175,230,67,9,232,86,219,139,176,246,63,251,213,157,213,148,20,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateContactHasNoEmailLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateContactHasNoEmailLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("6262f843-99e3-4dc0-a187-67f2246e8f46"),
				Name = "ContactHasNoEmail",
				CreatedInPackageId = new Guid("7cc31540-fa76-4c79-9b86-a6eabd8e662c"),
				CreatedInSchemaUId = new Guid("35314301-48db-4886-bb11-d28d71215caa"),
				ModifiedInSchemaUId = new Guid("35314301-48db-4886-bb11-d28d71215caa")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("35314301-48db-4886-bb11-d28d71215caa"));
		}

		#endregion

	}

	#endregion

}
