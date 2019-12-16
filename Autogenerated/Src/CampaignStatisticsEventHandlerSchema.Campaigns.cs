namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CampaignStatisticsEventHandlerSchema

	/// <exclude/>
	public class CampaignStatisticsEventHandlerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CampaignStatisticsEventHandlerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CampaignStatisticsEventHandlerSchema(CampaignStatisticsEventHandlerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("056a2c31-7878-4573-8dca-ecafe4c5fd1b");
			Name = "CampaignStatisticsEventHandler";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6c038aa0-46cd-4697-bc93-5c682e364aef");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,205,86,75,111,211,74,20,94,27,137,255,48,10,27,91,170,92,216,82,64,74,67,10,149,74,91,145,20,22,87,119,49,29,159,56,35,236,25,51,143,182,41,234,127,231,204,195,118,30,78,91,116,37,116,87,137,199,231,245,125,223,57,115,44,104,13,186,161,12,200,28,148,162,90,46,76,62,145,98,193,75,171,168,225,82,188,124,241,235,229,139,196,106,46,74,50,91,105,3,245,81,247,188,238,162,32,31,27,163,248,181,53,160,247,154,76,104,221,80,94,138,124,122,3,194,124,166,162,168,64,237,181,254,120,252,100,32,52,64,147,87,10,74,172,149,76,42,170,245,91,210,190,92,79,226,237,14,15,15,201,59,109,235,154,170,213,135,248,140,104,13,229,66,147,26,204,82,22,154,24,73,40,51,150,86,252,30,8,139,161,136,54,72,135,54,156,105,82,88,229,42,234,94,129,75,163,243,54,254,225,90,130,198,94,87,156,17,13,180,130,130,48,87,94,87,221,172,139,184,94,39,25,46,255,152,106,56,32,167,23,162,247,150,205,198,193,244,14,152,117,138,33,83,53,23,212,0,230,255,229,97,247,252,72,129,56,176,216,183,228,82,241,27,111,227,222,55,225,129,48,247,30,161,122,124,211,10,234,190,128,115,108,20,242,158,8,252,145,139,244,113,12,217,209,222,160,173,227,156,94,87,48,28,243,25,222,151,84,97,78,222,32,148,71,2,173,89,101,71,145,8,16,69,224,98,147,152,75,37,27,64,107,112,204,120,205,30,183,255,18,122,101,15,141,51,168,128,25,242,9,204,92,26,90,13,212,163,39,210,10,19,236,210,140,184,17,75,146,27,170,176,83,188,43,98,129,219,24,39,189,210,160,80,57,129,255,49,119,230,109,147,4,231,160,178,181,72,79,172,96,185,15,151,142,78,139,81,22,223,231,39,74,214,67,84,116,132,181,134,223,151,160,32,29,181,166,46,70,126,170,167,63,113,2,210,144,35,71,119,116,48,160,122,225,217,18,106,154,79,133,225,102,117,90,100,25,161,58,214,235,229,75,2,144,124,214,0,227,139,213,185,60,147,236,199,103,142,200,211,160,111,162,192,88,37,34,96,127,244,176,143,197,175,64,49,93,49,95,194,39,73,171,63,162,241,217,26,12,20,149,143,69,145,142,92,139,91,237,88,137,124,61,201,77,55,101,249,64,214,136,197,1,105,35,239,144,183,69,196,141,228,5,185,106,10,252,223,6,28,219,130,131,96,224,33,128,210,27,224,141,7,220,131,251,115,26,92,20,213,23,186,19,235,153,130,244,193,172,175,62,182,117,128,178,213,214,7,187,87,67,215,233,51,192,222,158,83,85,70,20,35,52,14,228,207,236,117,76,182,13,58,27,242,30,179,37,199,219,122,200,127,24,238,86,148,47,178,224,11,14,197,133,232,67,244,250,127,68,84,115,94,67,126,101,216,185,188,221,227,123,140,227,50,228,189,73,71,62,177,74,225,141,234,78,115,191,162,152,113,157,178,57,179,255,97,86,131,8,65,161,160,78,254,157,155,101,24,81,167,210,87,121,219,206,108,154,101,27,134,97,213,64,20,248,225,185,87,229,218,189,186,189,136,253,193,184,105,42,188,129,187,69,188,144,106,112,255,74,247,36,155,188,243,107,183,181,238,205,105,28,16,220,31,97,66,58,235,141,253,156,252,115,161,10,164,234,205,235,215,217,191,126,230,194,194,246,35,119,225,151,108,55,90,70,173,226,191,228,169,97,12,108,61,96,57,134,45,73,58,189,99,208,56,85,9,220,181,209,146,184,210,240,243,75,211,18,194,92,157,177,251,153,63,254,70,43,11,233,238,6,62,32,163,80,85,23,114,20,147,37,109,53,103,178,44,177,103,166,74,73,117,34,85,77,77,26,115,28,96,250,126,204,182,187,34,134,49,75,37,111,99,253,107,234,14,10,214,125,58,85,178,68,210,30,209,11,218,143,19,98,218,175,147,191,32,223,238,39,209,255,79,204,221,26,255,182,180,91,131,27,78,55,15,241,236,55,103,215,72,151,41,12,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateOnExecutionTerminateExceptionLocalizableString());
			LocalizableStrings.Add(CreateOnStopExceptionLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateOnExecutionTerminateExceptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("0197d642-0e99-4a65-b19d-c37839084917"),
				Name = "OnExecutionTerminateException",
				CreatedInPackageId = new Guid("6c038aa0-46cd-4697-bc93-5c682e364aef"),
				CreatedInSchemaUId = new Guid("056a2c31-7878-4573-8dca-ecafe4c5fd1b"),
				ModifiedInSchemaUId = new Guid("056a2c31-7878-4573-8dca-ecafe4c5fd1b")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateOnStopExceptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("240946f2-b208-45ac-909a-43c9b9be0ccb"),
				Name = "OnStopException",
				CreatedInPackageId = new Guid("6c038aa0-46cd-4697-bc93-5c682e364aef"),
				CreatedInSchemaUId = new Guid("056a2c31-7878-4573-8dca-ecafe4c5fd1b"),
				ModifiedInSchemaUId = new Guid("056a2c31-7878-4573-8dca-ecafe4c5fd1b")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("056a2c31-7878-4573-8dca-ecafe4c5fd1b"));
		}

		#endregion

	}

	#endregion

}

