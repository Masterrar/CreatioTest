namespace Terrasoft.Core.Process.Configuration
{

	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Configuration.FileImport;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Factories;
	using Terrasoft.Core.Process;
	using Terrasoft.UI.WebControls.Controls;

	#region Class: FileImportPersistentTaskSchema

	/// <exclude/>
	public class FileImportPersistentTaskSchema : Terrasoft.Core.Process.ProcessUserTaskSchema
	{

		#region Constructors: Public

		public FileImportPersistentTaskSchema(ProcessUserTaskSchemaManager processUserTaskSchemaManager)
			: base(processUserTaskSchemaManager) {
		}

		public FileImportPersistentTaskSchema(ProcessUserTaskSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("4a4279e7-7ad3-4bc4-a92b-e762eeee9c8e");
			RealUId = new Guid("4a4279e7-7ad3-4bc4-a92b-e762eeee9c8e");
			Name = "FileImportPersistentTask";
			CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8");
			UsageType = ProcessSchemaUsageType.Advanced;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParametersEditPageSchemaV2UId = Guid.Empty;
			DcmParametersEditPageSchemaV2UId = Guid.Empty;
			ZipExecuteBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,144,65,106,195,48,16,69,215,245,41,68,86,10,20,95,32,20,10,166,45,94,37,52,245,1,6,233,183,21,56,146,24,141,147,150,210,187,119,156,104,213,196,187,249,204,252,199,99,30,87,71,98,19,14,57,177,236,136,233,0,1,151,87,228,84,130,36,254,54,15,38,226,100,250,197,3,59,20,112,151,98,132,147,144,226,122,211,44,195,218,33,123,18,84,24,39,135,82,122,111,47,121,175,65,1,189,191,55,47,83,240,173,2,10,236,246,20,193,67,239,215,10,158,77,179,2,67,17,68,121,14,99,37,129,171,229,238,230,242,218,112,6,9,125,20,173,117,12,53,122,211,96,117,113,155,222,238,233,88,195,249,240,202,119,102,105,91,244,93,63,205,221,2,228,50,252,47,107,237,215,56,18,247,105,183,90,164,217,176,163,232,48,194,63,125,57,228,179,242,140,101,200,196,209,188,211,88,160,165,166,102,225,9,155,213,31,33,23,94,168,199,1,0,0 };
			SerializeToDB = false;
			IsUserTask = false;
			IsPartial = false;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			SetParametersDefInheritance();
			Parameters.Add(CreateImportSessionIdParameter());
		}

		protected virtual ProcessSchemaParameter CreateImportSessionIdParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("eab23d00-5110-4cc1-a7a6-95fd2039de56"),
				Name = "ImportSessionId",
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateGetResultParameterAllValuesMethod());
			Methods.Add(CreateCompleteExecutingMethod());
			Methods.Add(CreateCancelExecutingMethod());
			Methods.Add(CreateGetExecutionDataMethod());
			Methods.Add(CreateSynchronizeDynamicParametersMethod());
			Methods.Add(CreateSynchronizeParametersMethod());
			Methods.Add(CreateGetNotificationDataMethod());
			Methods.Add(CreateCreateTagsMethod());
			Methods.Add(CreateGetPersistentFileImporterMethod());
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("a24fa397-e164-47cb-8cdf-1ed6bc45647b"),
				Name = "Terrasoft.Configuration.FileImport",
				Alias = "",
				CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e83b02ee-b8b9-4a17-b1e7-9c6dcef373ab"),
				Name = "Terrasoft.Core.Factories",
				Alias = "",
				CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8")
			});
		}

		protected virtual SchemaMethod CreateGetResultParameterAllValuesMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("07a6b118-c311-4363-8968-017ac169fc4c"),
				Name = "GetResultParameterAllValues",
				CreatedInSchemaUId = new Guid("4a4279e7-7ad3-4bc4-a92b-e762eeee9c8e"),
				CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8"),
				ResultValueTypeName = "Dictionary<Guid, string>",
				IsOverride = true,
				IsCustom = true
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("cf79ac7e-de8c-4109-bc53-1bf2a3d2a2b4"),
				Name = "userConnection",
				CreatedInSchemaUId = new Guid("4a4279e7-7ad3-4bc4-a92b-e762eeee9c8e"),
				ModifiedInSchemaUId = new Guid("4a4279e7-7ad3-4bc4-a92b-e762eeee9c8e"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "UserConnection",
				CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("728cb53d-f460-4649-81f3-02c2b27d17c2"),
				Name = "schemaUserTask",
				CreatedInSchemaUId = new Guid("4a4279e7-7ad3-4bc4-a92b-e762eeee9c8e"),
				ModifiedInSchemaUId = new Guid("4a4279e7-7ad3-4bc4-a92b-e762eeee9c8e"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "ProcessSchemaUserTask",
				CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,200,75,45,87,112,201,76,46,201,204,207,75,44,170,180,113,47,205,76,209,81,40,46,41,202,204,75,183,211,208,180,6,0,179,24,102,192,38,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCompleteExecutingMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("9b34bb17-61df-4244-99bc-625b7132fb95"),
				Name = "CompleteExecuting",
				CreatedInSchemaUId = new Guid("4a4279e7-7ad3-4bc4-a92b-e762eeee9c8e"),
				CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8"),
				ResultValueTypeName = "bool",
				IsOverride = true,
				IsCustom = true
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("be1b93c8-9ada-4ab9-80bb-d24268fc6577"),
				Name = "parameters",
				CreatedInSchemaUId = new Guid("4a4279e7-7ad3-4bc4-a92b-e762eeee9c8e"),
				ModifiedInSchemaUId = new Guid("4a4279e7-7ad3-4bc4-a92b-e762eeee9c8e"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "object[]",
				CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8"),
				IsParams = true
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,80,61,11,194,48,16,157,205,175,184,177,93,138,123,208,165,88,113,43,136,56,136,67,44,87,13,36,151,146,187,136,32,254,119,139,95,212,14,14,110,199,251,226,189,59,155,8,214,119,33,74,109,162,241,40,24,97,6,221,251,230,221,116,15,134,97,245,45,97,173,108,11,217,200,88,60,85,107,49,71,132,57,84,214,225,0,225,5,37,95,212,49,52,200,92,6,151,60,241,72,146,195,85,77,126,133,206,254,8,213,234,166,206,253,202,246,3,63,38,46,81,234,126,136,101,65,146,106,192,101,27,198,88,6,34,108,196,6,202,181,26,58,95,117,182,86,78,143,138,60,126,66,175,87,17,37,69,130,131,97,44,202,224,59,215,19,139,11,54,73,44,29,51,74,206,229,250,14,183,233,196,226,121,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCancelExecutingMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("ca2cfe05-4ce9-42cd-a860-c42ef5c4c224"),
				Name = "CancelExecuting",
				CreatedInSchemaUId = new Guid("4a4279e7-7ad3-4bc4-a92b-e762eeee9c8e"),
				CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8"),
				ResultValueTypeName = "void",
				IsOverride = true,
				IsCustom = true
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("b844354b-cf97-4036-ae47-417175cff551"),
				Name = "parameters",
				CreatedInSchemaUId = new Guid("4a4279e7-7ad3-4bc4-a92b-e762eeee9c8e"),
				ModifiedInSchemaUId = new Guid("4a4279e7-7ad3-4bc4-a92b-e762eeee9c8e"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "object[]",
				CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8"),
				IsParams = true
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,75,44,82,200,204,45,200,47,42,9,72,44,74,204,77,45,73,45,42,14,74,45,200,47,206,44,201,47,170,84,176,85,200,75,45,87,240,196,169,64,35,180,56,181,200,57,63,47,47,53,185,36,51,63,79,211,154,11,183,97,122,206,137,121,201,169,57,16,195,130,83,139,139,129,26,52,80,120,158,41,64,3,146,18,139,83,161,74,93,43,82,147,75,75,50,243,210,53,10,224,230,105,90,3,0,46,58,197,97,179,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetExecutionDataMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("edf02952-d873-4c49-9436-ca8a8843ff68"),
				Name = "GetExecutionData",
				CreatedInSchemaUId = new Guid("4a4279e7-7ad3-4bc4-a92b-e762eeee9c8e"),
				CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8"),
				ResultValueTypeName = "string",
				IsOverride = true,
				IsCustom = true
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,40,46,41,202,204,75,215,115,205,45,40,169,180,6,0,142,207,47,4,20,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSynchronizeDynamicParametersMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("ae0c320c-3be1-4bd1-86b1-49ddb1985f3e"),
				Name = "SynchronizeDynamicParameters",
				CreatedInSchemaUId = new Guid("4a4279e7-7ad3-4bc4-a92b-e762eeee9c8e"),
				CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8"),
				ResultValueTypeName = "void",
				IsOverride = true,
				IsCustom = true
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("9a1cb492-175b-4793-bb82-59e865268018"),
				Name = "userConnection",
				CreatedInSchemaUId = new Guid("4a4279e7-7ad3-4bc4-a92b-e762eeee9c8e"),
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "UserConnection",
				CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("6b75ba89-6937-48e4-98c8-ae356e116525"),
				Name = "target",
				CreatedInSchemaUId = new Guid("4a4279e7-7ad3-4bc4-a92b-e762eeee9c8e"),
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "ProcessUserTaskSchema",
				CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,75,74,44,78,213,11,174,204,75,206,40,202,207,203,172,74,117,169,204,75,204,205,76,14,72,44,74,204,77,45,73,45,42,214,40,45,78,45,114,206,207,203,75,77,46,201,204,207,211,81,40,73,44,74,79,45,209,180,6,0,220,224,0,174,58,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSynchronizeParametersMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("d11a52ab-3abb-4de1-9b2a-3fa73593b8c5"),
				Name = "SynchronizeParameters",
				CreatedInSchemaUId = new Guid("4a4279e7-7ad3-4bc4-a92b-e762eeee9c8e"),
				CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8"),
				ResultValueTypeName = "void",
				IsOverride = true,
				IsCustom = true
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("f078cf00-8efb-4511-bfa6-057e8f542379"),
				Name = "schemaElement",
				CreatedInSchemaUId = new Guid("4a4279e7-7ad3-4bc4-a92b-e762eeee9c8e"),
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "ProcessSchemaUserTask",
				CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,75,74,44,78,213,11,174,204,75,206,40,202,207,203,172,74,13,72,44,74,204,77,45,73,45,42,214,40,78,206,72,205,77,116,205,73,205,77,205,43,209,180,6,0,231,209,250,48,42,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetNotificationDataMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("11ad09be-c56b-4526-9154-71cd7cb29886"),
				Name = "GetNotificationData",
				CreatedInSchemaUId = new Guid("4a4279e7-7ad3-4bc4-a92b-e762eeee9c8e"),
				CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8"),
				ResultValueTypeName = "ProcessElementNotification",
				IsOverride = true,
				IsCustom = true
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,72,74,44,78,213,115,79,45,241,203,47,201,76,203,76,78,44,201,204,207,115,73,44,73,212,208,180,6,0,189,127,96,121,34,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCreateTagsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("fb4baa22-6461-440e-9e0c-8aec95cb53ec"),
				Name = "CreateTags",
				CreatedInSchemaUId = new Guid("4a4279e7-7ad3-4bc4-a92b-e762eeee9c8e"),
				CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8"),
				ResultValueTypeName = "List<ImportTag>"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,101,144,207,74,196,48,16,198,207,205,83,132,158,82,40,121,129,85,15,182,172,8,122,209,170,231,177,142,37,152,63,101,146,32,235,178,239,110,210,74,183,93,47,33,249,102,242,251,230,155,22,2,188,130,142,216,29,70,228,31,155,215,53,127,241,72,141,179,22,251,160,156,149,237,186,252,8,22,6,36,121,135,97,163,223,30,150,171,8,233,112,159,34,213,177,83,6,171,106,199,124,32,101,7,222,71,34,180,249,103,246,217,248,102,98,227,116,52,182,85,126,212,48,243,132,141,90,215,151,19,53,51,38,171,211,183,51,53,251,137,149,97,128,161,67,147,112,147,161,197,111,254,224,122,208,234,7,222,53,62,79,61,226,2,254,230,232,203,143,208,163,124,66,239,34,245,169,207,81,10,93,243,114,175,52,222,155,209,81,232,96,248,91,69,89,179,162,252,71,245,178,59,91,203,41,75,153,198,34,12,145,236,60,136,242,225,106,129,221,240,35,103,69,214,23,137,31,89,81,172,151,145,18,204,177,228,222,145,129,32,86,233,234,245,110,43,86,156,216,105,199,126,1,106,57,119,169,231,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetPersistentFileImporterMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("a331f074-6ab9-436e-a542-f13ab2a082d9"),
				Name = "GetPersistentFileImporter",
				CreatedInSchemaUId = new Guid("4a4279e7-7ad3-4bc4-a92b-e762eeee9c8e"),
				CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8"),
				ResultValueTypeName = "IBaseFileImporter"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("cef9a9ce-f613-477f-a1fa-655ffa0bac5e"),
				Name = "userConnection",
				CreatedInSchemaUId = Guid.Empty,
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "UserConnection",
				CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,75,44,82,72,203,204,73,245,204,45,200,47,42,73,45,82,176,85,112,206,73,44,46,118,75,76,46,201,47,170,212,115,79,45,177,9,72,45,42,206,44,46,73,205,43,113,67,82,105,167,145,151,90,174,224,156,159,87,92,82,84,10,82,236,88,148,94,154,11,84,164,161,84,90,156,90,4,148,200,75,77,46,201,204,207,83,210,81,8,69,17,208,212,180,230,42,74,45,41,45,202,67,177,218,26,0,12,168,190,185,140,0,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new FileImportPersistentTaskSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("4a4279e7-7ad3-4bc4-a92b-e762eeee9c8e"));
		}

		public override void InitializePrimaryInfo() {
			InitializeProperties();
			base.InitializePrimaryInfo();
			InitializeLocalizableValues();
		}

		public override Dictionary<Guid, string> GetResultParameterAllValues(UserConnection userConnection, ProcessSchemaUserTask schemaUserTask) {
			return new Dictionary<Guid, string>();
		}

		public override void SynchronizeDynamicParameters(UserConnection userConnection, ProcessUserTaskSchema target) {
			base.SynchronizeDynamicParameters(userConnection, target);
		}

		public override ProcessUserTask CreateProcessUserTask(UserConnection userConnection) {
			return new FileImportPersistentTask(userConnection) {
				SchemaUId = new Guid("4a4279e7-7ad3-4bc4-a92b-e762eeee9c8e")
			};
		}

		public override void SynchronizeParameters(ProcessSchemaUserTask schemaElement) {
			base.SynchronizeParameters(schemaElement);
		}

		#endregion

	}

	#endregion

	#region Class: FileImportPersistentTask

	[DesignModeProperty(Name = "ImportSessionId", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "4a4279e77ad34bc4a92be762eeee9c8e", CaptionResourceItem = "Parameters.ImportSessionId.Caption", DescriptionResourceItem = "Parameters.ImportSessionId.Caption", UseSolutionStorage = true)]
	/// <exclude/>
	public class FileImportPersistentTask : ProcessUserTask
	{

		#region Constructors: Public

		public FileImportPersistentTask(UserConnection userConnection)
			: base(userConnection) {
			SchemaUId = new Guid("4a4279e7-7ad3-4bc4-a92b-e762eeee9c8e");
		}

		#endregion

		#region Properties: Public

		public virtual Guid ImportSessionId {
			get;
			set;
		}

		#endregion

		#region Methods: Protected

		protected override bool InternalExecute(ProcessExecutingContext context) {
			var importParametersRepository = new ImportParametersRepository(UserConnection);
			importParametersRepository.UpdateImportProcessId(ImportSessionId, Guid.Parse(OwnerUId));
			var persistentFileImporter = new PersistentFileImporter(UserConnection);
			var tags = CreateTags();
			persistentFileImporter.SaveImportTags(ImportSessionId, tags);
			try {
				persistentFileImporter.Import(ImportSessionId);
			} catch(OperationCanceledException) {
				return false;
			}
			return true;
		}

		#endregion

		#region Methods: Public

		public override bool CompleteExecuting(params object[] parameters) {
			var importParameter = parameters[0] as ImportParameters;
			if (importParameter.ImportStage > FileImportStagesEnum.ProcessColumnsFileImportStage) {
				importParameter.ImportStage = FileImportStagesEnum.ProcessColumnsFileImportStage;
			}
			var fileImporter = GetPersistentFileImporter(UserConnection);
			fileImporter.ImportWithParams(importParameter);
			
			return base.CompleteExecuting(null);
		}

		public override void CancelExecuting(params object[] parameters) {
			var importParametersRepository = new ImportParametersRepository(UserConnection);
			importParametersRepository.CancelImportSession(ImportSessionId);
			base.CancelExecuting(parameters);
		}

		public override string GetExecutionData() {
			return string.Empty;
		}

		public override ProcessElementNotification GetNotificationData() {
			return base.GetNotificationData();
		}

		public virtual List<ImportTag> CreateTags() {
			DataValueType dataValueType = UserConnection.DataValueTypeManager.GetDataValueTypeByValueType(typeof(DateTime));
			string currentDate = dataValueType.GetColumnDisplayValue(null, UserConnection.CurrentUser.GetCurrentDateTime());
			string tagTemplate = new LocalizableString(UserConnection.Workspace.ResourceStorage, "FileImportTagManager",
				"LocalizableStrings.TagTemplate.Value");
			return new List<ImportTag> { 
				new ImportTag {
					DisplayValue = string.Format(tagTemplate, currentDate)
				}
			};
		}

		public virtual IBaseFileImporter GetPersistentFileImporter(UserConnection userConnection) {
			var fileImporter = ClassFactory.Get<PersistentFileImporter>(new ConstructorArgument("userConnection", UserConnection));
			return fileImporter;
		}

		public override void WritePropertiesData(DataWriter writer) {
			writer.WriteStartObject(Name);
			base.WritePropertiesData(writer);
			if (Status == Core.Process.ProcessStatus.Inactive) {
				writer.WriteFinishObject();
				return;
			}
			if (!HasMapping("ImportSessionId")) {
				writer.WriteValue("ImportSessionId", ImportSessionId, Guid.Empty);
			}
			writer.WriteFinishObject();
		}

		#endregion

		#region Methods: Protected

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			switch (reader.CurrentName) {
				case "ImportSessionId":
					ImportSessionId = reader.GetGuidValue();
				break;
			}
		}

		#endregion

	}

	#endregion

}

