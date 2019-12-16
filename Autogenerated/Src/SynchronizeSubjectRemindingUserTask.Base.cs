namespace Terrasoft.Core.Process.Configuration
{

	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using System.Linq;
	using Terrasoft.Common;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Process;
	using Terrasoft.UI.WebControls.Controls;

	#region Class: SynchronizeSubjectRemindingUserTaskSchema

	/// <exclude/>
	public class SynchronizeSubjectRemindingUserTaskSchema : Terrasoft.Core.Process.ProcessUserTaskSchema
	{

		#region Constructors: Public

		public SynchronizeSubjectRemindingUserTaskSchema(ProcessUserTaskSchemaManager processUserTaskSchemaManager)
			: base(processUserTaskSchemaManager) {
		}

		public SynchronizeSubjectRemindingUserTaskSchema(ProcessUserTaskSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("30392711-0c15-40b6-8b03-9e3232660270");
			RealUId = new Guid("30392711-0c15-40b6-8b03-9e3232660270");
			Name = "SynchronizeSubjectRemindingUserTask";
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			UsageType = ProcessSchemaUsageType.Advanced;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParametersEditPageSchemaV2UId = Guid.Empty;
			DcmParametersEditPageSchemaV2UId = Guid.Empty;
			ZipExecuteBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,197,87,223,111,219,54,16,126,182,254,10,198,15,133,132,6,66,176,199,41,205,230,58,78,96,160,203,178,216,109,30,134,62,208,210,217,230,38,75,14,69,165,51,86,255,239,187,35,41,137,178,228,214,27,18,12,8,98,251,120,252,238,187,159,58,253,60,20,75,230,143,74,181,206,37,123,247,142,101,101,154,6,236,111,111,80,137,216,199,2,228,56,207,50,136,149,200,179,112,92,74,9,153,34,105,136,98,197,99,53,77,34,111,239,61,115,201,36,108,68,150,136,108,53,139,215,176,225,221,219,147,76,9,181,51,167,191,240,140,175,16,229,22,212,52,43,20,207,98,120,191,187,227,27,240,135,195,135,10,104,56,12,162,62,232,113,158,150,155,172,64,11,7,7,161,61,137,188,57,72,201,139,124,169,136,231,82,172,74,201,53,135,26,27,175,62,149,66,66,82,75,34,111,145,231,105,3,57,249,75,20,138,140,44,121,90,128,33,2,93,23,78,242,211,220,126,42,65,238,80,63,131,47,204,85,250,141,228,126,15,246,57,107,71,131,114,131,198,70,9,138,30,196,106,173,233,221,166,249,130,167,163,237,118,6,74,161,94,17,222,0,87,165,132,182,230,52,155,108,22,144,36,144,124,200,87,34,246,246,145,167,249,132,163,36,25,165,105,43,178,126,80,29,222,136,84,129,44,72,201,55,146,177,68,116,48,242,71,161,214,247,92,98,218,72,201,55,194,113,190,217,114,41,138,60,155,239,182,16,78,158,74,158,146,35,179,114,241,7,80,193,12,135,231,204,254,184,151,98,195,229,206,152,253,196,211,18,2,52,45,150,254,217,180,176,42,215,144,34,58,123,243,134,49,18,162,131,41,152,152,128,212,1,121,113,162,182,178,137,166,253,74,164,246,175,16,145,188,148,49,144,29,255,182,20,73,192,140,32,120,149,232,239,10,183,228,66,252,253,152,203,63,139,45,143,33,52,57,57,40,99,247,56,8,156,250,23,64,101,103,248,96,255,26,88,76,97,106,46,250,109,28,157,79,230,247,166,142,32,227,188,204,20,226,85,208,216,176,40,136,188,193,180,129,188,52,54,174,108,255,205,115,91,20,166,149,62,96,159,86,26,84,185,131,37,206,46,95,32,170,64,141,139,8,63,46,141,25,252,250,246,173,182,60,104,186,217,177,253,187,248,28,217,179,184,26,111,213,177,246,149,98,154,56,213,122,73,121,187,242,235,154,161,64,18,131,1,185,124,86,99,152,52,20,126,93,78,154,194,192,226,26,103,52,243,74,86,121,168,51,111,68,250,120,239,209,95,29,42,12,102,254,12,15,60,91,129,223,190,168,11,182,59,202,218,65,102,87,236,130,26,11,251,138,98,104,27,206,100,8,103,104,103,66,118,1,240,161,113,193,190,126,101,125,0,222,224,39,230,127,119,14,7,221,25,174,75,220,228,243,176,150,188,193,143,39,97,214,9,189,248,220,227,71,248,66,51,52,242,116,105,143,144,219,51,4,152,82,26,92,7,65,55,169,238,82,64,67,215,176,116,74,169,48,5,208,213,212,37,72,117,22,222,193,23,250,212,138,123,79,215,216,209,57,202,206,236,165,201,102,139,197,115,156,133,115,199,167,2,236,127,214,82,241,215,15,104,103,146,7,161,115,159,142,207,25,129,28,165,133,135,77,127,20,74,106,7,139,59,92,60,126,149,154,105,229,209,152,111,117,198,109,171,156,68,253,95,177,183,6,142,186,208,120,81,81,209,13,200,0,151,1,195,9,179,125,48,85,251,130,110,198,73,97,160,254,243,106,244,113,154,28,26,51,243,194,69,159,84,243,172,101,237,155,13,101,48,40,27,45,12,44,127,21,175,111,100,190,185,126,127,188,198,170,228,252,79,233,105,51,238,155,206,51,93,96,87,126,59,30,168,105,125,185,22,197,54,229,214,37,109,63,8,12,184,13,204,222,179,255,246,117,199,217,25,254,154,253,85,47,32,71,124,183,231,182,151,44,175,254,110,162,144,180,91,137,234,69,53,82,99,160,187,74,247,241,114,192,156,199,92,23,236,204,121,149,56,33,42,29,128,174,215,174,27,81,43,29,102,115,50,139,211,171,206,60,187,171,29,73,137,75,163,201,203,41,198,79,176,109,174,207,197,230,168,253,70,195,211,182,155,200,216,87,185,87,140,140,177,240,157,200,24,165,23,143,204,53,20,177,20,223,156,20,142,74,19,155,19,230,246,139,21,78,219,84,31,77,253,196,108,171,181,123,251,62,223,150,219,185,80,41,80,123,231,202,116,248,227,90,40,152,209,134,238,7,39,114,30,14,27,40,90,249,155,95,142,181,131,103,19,61,135,10,187,14,77,50,190,72,33,65,28,100,33,150,34,214,155,215,167,31,208,171,147,25,160,7,0,201,60,159,65,166,95,59,148,44,225,101,171,194,229,70,147,227,88,105,28,234,153,250,232,33,193,159,245,122,222,60,252,205,27,106,119,231,181,219,116,235,213,245,88,96,156,181,223,217,42,140,180,214,34,19,126,181,205,154,40,209,94,143,185,200,116,224,162,225,63,125,245,33,57,197,17,0,0 };
			SerializeToDB = false;
			IsUserTask = false;
			IsPartial = false;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			SetParametersDefInheritance();
			Parameters.Add(CreateActiveParameter());
			Parameters.Add(CreateSubjectPrimaryColumnValueParameter());
			Parameters.Add(CreateAuthorParameter());
			Parameters.Add(CreateContactParameter());
			Parameters.Add(CreateSourceParameter());
			Parameters.Add(CreateRemindTimeParameter());
			Parameters.Add(CreateDescriptionParameter());
			Parameters.Add(CreateSysEntitySchemaParameter());
			Parameters.Add(CreateSubjectCaptionParameter());
			Parameters.Add(CreateTypeCaptionParameter());
			Parameters.Add(CreateIsListSubjectRemindsParameter());
			Parameters.Add(CreateIsSubjectDeleteParameter());
			Parameters.Add(CreateNotificationTypeParameter());
			Parameters.Add(CreatePopupTitleParameter());
			Parameters.Add(CreateIsSingleReminderParameter());
		}

		protected virtual ProcessSchemaParameter CreateActiveParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("bb2cfe13-818f-406d-b306-238b5c83cc5d"),
				Name = "Active",
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = true,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateSubjectPrimaryColumnValueParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("0eedefc0-8e0c-4485-80eb-022489352861"),
				Name = "SubjectPrimaryColumnValue",
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = true,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateAuthorParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("f41f2b3e-8b41-4101-b028-09a5bad36ab8"),
				Name = "Author",
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateContactParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("3964073d-e93f-48fc-baba-c7deb337b232"),
				Name = "Contact",
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = true,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateSourceParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("a454b4a0-85c8-49a8-afa9-a918b86569a5"),
				Name = "Source",
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = true,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateRemindTimeParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("59410b57-d0cf-4b57-b794-b1fc70b3bb53"),
				Name = "RemindTime",
				DataValueType = DataValueTypeManager.GetInstanceByName("DateTime"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = true,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateDescriptionParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("da854917-3d08-4d13-bfd9-8834e2122321"),
				Name = "Description",
				DataValueType = DataValueTypeManager.GetInstanceByName("MediumText"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = true,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateSysEntitySchemaParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("492fb3fb-4d86-4ff0-a6f8-dbd5a0419893"),
				Name = "SysEntitySchema",
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = true,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateSubjectCaptionParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("17c36094-1f3d-4fc3-84fd-85c0d6c40647"),
				Name = "SubjectCaption",
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateTypeCaptionParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("131a3953-62ab-472a-b575-ecf2ff2c0e05"),
				Name = "TypeCaption",
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateIsListSubjectRemindsParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("916137b3-0b84-467e-9f5a-e6c478a6b33c"),
				Name = "IsListSubjectReminds",
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateIsSubjectDeleteParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("b4d927c1-e0b0-4451-abbb-2cb5d6f5b818"),
				Name = "IsSubjectDelete",
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateNotificationTypeParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("71a40919-3237-4692-9c5c-1e31bca92712"),
				Name = "NotificationType",
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreatePopupTitleParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("b4a8c3cd-aba4-4189-be98-ec02f4b07ba7"),
				Name = "PopupTitle",
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
				ReferenceSchemaUId = Guid.Empty,
				IsResult = false,
				IsPerformer = false,
				IsValueSerializable = true,
				IsRequired = false,
				IsLazy = false
			};
		}

		protected virtual ProcessSchemaParameter CreateIsSingleReminderParameter() {
			return new ProcessSchemaParameter(SchemaManagerProvider) {
				UId = new Guid("38404fef-2ad9-4d24-9a24-d5c4057cb40b"),
				Name = "IsSingleReminder",
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
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
			Methods.Add(CreateDeleteRemindingListMethod());
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("defca40a-31d5-45aa-92c9-5a329365835f"),
				Name = "Terrasoft.Core.Entities",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("04a0aab7-23a5-48be-b5c3-aad0677a78c4"),
				Name = "Terrasoft.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("c73c8b55-d498-4a91-97b2-bc1e4602fe26"),
				Name = "System.Linq",
				Alias = "",
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			});
		}

		protected virtual SchemaMethod CreateDeleteRemindingListMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("1f6c0d84-7a7a-49a8-a5ec-7df820bfca43"),
				Name = "DeleteRemindingList",
				CreatedInSchemaUId = new Guid("30392711-0c15-40b6-8b03-9e3232660270"),
				CreatedInPackageId = new Guid("a99d7388-fb0e-4870-87fc-76975bec5847"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("728c87bf-e6fc-4343-bada-ac131b688464"),
				Name = "entities",
				CreatedInSchemaUId = Guid.Empty,
				ModifiedInSchemaUId = Guid.Empty,
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "EntityCollection",
				CreatedInPackageId = new Guid("a99d7388-fb0e-4870-87fc-76975bec5847")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,75,44,82,72,206,47,205,43,81,176,85,72,205,43,201,44,201,76,45,214,115,6,9,88,115,165,229,23,105,100,2,101,50,129,114,6,214,64,202,6,162,20,200,212,214,214,84,168,230,226,132,233,136,54,136,213,115,73,205,73,45,73,213,208,180,230,170,5,0,146,97,130,243,85,0,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SynchronizeSubjectRemindingUserTaskSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("30392711-0c15-40b6-8b03-9e3232660270"));
		}

		public override void InitializePrimaryInfo() {
			InitializeProperties();
			base.InitializePrimaryInfo();
			InitializeLocalizableValues();
		}

		public override ProcessUserTask CreateProcessUserTask(UserConnection userConnection) {
			return new SynchronizeSubjectRemindingUserTask(userConnection) {
				SchemaUId = new Guid("30392711-0c15-40b6-8b03-9e3232660270")
			};
		}

		#endregion

	}

	#endregion

	#region Class: SynchronizeSubjectRemindingUserTask

	[DesignModeProperty(Name = "Active", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "303927110c1540b68b039e3232660270", CaptionResourceItem = "Parameters.Active.Caption", DescriptionResourceItem = "Parameters.Active.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "SubjectPrimaryColumnValue", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "303927110c1540b68b039e3232660270", CaptionResourceItem = "Parameters.SubjectPrimaryColumnValue.Caption", DescriptionResourceItem = "Parameters.SubjectPrimaryColumnValue.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "Author", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "303927110c1540b68b039e3232660270", CaptionResourceItem = "Parameters.Author.Caption", DescriptionResourceItem = "Parameters.Author.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "Contact", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "303927110c1540b68b039e3232660270", CaptionResourceItem = "Parameters.Contact.Caption", DescriptionResourceItem = "Parameters.Contact.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "Source", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "303927110c1540b68b039e3232660270", CaptionResourceItem = "Parameters.Source.Caption", DescriptionResourceItem = "Parameters.Source.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "RemindTime", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "303927110c1540b68b039e3232660270", CaptionResourceItem = "Parameters.RemindTime.Caption", DescriptionResourceItem = "Parameters.RemindTime.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "Description", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "303927110c1540b68b039e3232660270", CaptionResourceItem = "Parameters.Description.Caption", DescriptionResourceItem = "Parameters.Description.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "SysEntitySchema", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "303927110c1540b68b039e3232660270", CaptionResourceItem = "Parameters.SysEntitySchema.Caption", DescriptionResourceItem = "Parameters.SysEntitySchema.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "SubjectCaption", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "303927110c1540b68b039e3232660270", CaptionResourceItem = "Parameters.SubjectCaption.Caption", DescriptionResourceItem = "Parameters.SubjectCaption.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "TypeCaption", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "303927110c1540b68b039e3232660270", CaptionResourceItem = "Parameters.TypeCaption.Caption", DescriptionResourceItem = "Parameters.TypeCaption.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "IsListSubjectReminds", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "303927110c1540b68b039e3232660270", CaptionResourceItem = "Parameters.IsListSubjectReminds.Caption", DescriptionResourceItem = "Parameters.IsListSubjectReminds.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "IsSubjectDelete", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "303927110c1540b68b039e3232660270", CaptionResourceItem = "Parameters.IsSubjectDelete.Caption", DescriptionResourceItem = "Parameters.IsSubjectDelete.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "NotificationType", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "303927110c1540b68b039e3232660270", CaptionResourceItem = "Parameters.NotificationType.Caption", DescriptionResourceItem = "Parameters.NotificationType.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "PopupTitle", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "303927110c1540b68b039e3232660270", CaptionResourceItem = "Parameters.PopupTitle.Caption", DescriptionResourceItem = "Parameters.PopupTitle.Caption", UseSolutionStorage = true)]
	[DesignModeProperty(Name = "IsSingleReminder", Group = "", ValuesProvider = "ProcessSchemaParameterValueProvider", Editor="xtype=processschemaparametervalueedit;dataProvider=processschemaparametervalueprovider", ResourceManager = "303927110c1540b68b039e3232660270", CaptionResourceItem = "Parameters.IsSingleReminder.Caption", DescriptionResourceItem = "Parameters.IsSingleReminder.Caption", UseSolutionStorage = true)]
	/// <exclude/>
	public class SynchronizeSubjectRemindingUserTask : ProcessUserTask
	{

		#region Constructors: Public

		public SynchronizeSubjectRemindingUserTask(UserConnection userConnection)
			: base(userConnection) {
			SchemaUId = new Guid("30392711-0c15-40b6-8b03-9e3232660270");
		}

		#endregion

		#region Properties: Public

		public virtual bool Active {
			get;
			set;
		}

		public virtual Guid SubjectPrimaryColumnValue {
			get;
			set;
		}

		public virtual Object Author {
			get;
			set;
		}

		public virtual Guid Contact {
			get;
			set;
		}

		public virtual Object Source {
			get;
			set;
		}

		public virtual DateTime RemindTime {
			get;
			set;
		}

		public virtual string Description {
			get;
			set;
		}

		public virtual Guid SysEntitySchema {
			get;
			set;
		}

		public virtual string SubjectCaption {
			get;
			set;
		}

		public virtual string TypeCaption {
			get;
			set;
		}

		public virtual bool IsListSubjectReminds {
			get;
			set;
		}

		public virtual bool IsSubjectDelete {
			get;
			set;
		}

		public virtual Guid NotificationType {
			get;
			set;
		}

		public virtual string PopupTitle {
			get;
			set;
		}

		public virtual bool IsSingleReminder {
			get;
			set;
		}

		#endregion

		#region Methods: Protected

		protected override bool InternalExecute(ProcessExecutingContext context) {
			if (Author == null) {
				Author = UserConnection.CurrentUser.ContactId;
			}
			var remindingSchema = UserConnection.EntitySchemaManager.GetInstanceByName("Reminding");
			var remindingSchemaColumns = remindingSchema.Columns;
			Terrasoft.Configuration.Reminding requiredReminding;
			bool remindingExists = false;
			var entitySchemaManager = UserConnection.EntitySchemaManager;
			var query = new EntitySchemaQuery(entitySchemaManager, "Reminding") {
				UseAdminRights = GlobalAppSettings.FeatureUseAdminRightsInEmbeddedLogic
			};
			query.AddAllSchemaColumns();
			query.Filters.Add(query.CreateFilterWithParameters(FilterComparisonType.Equal, "SubjectId", SubjectPrimaryColumnValue));
			if(!IsSubjectDelete &&  !IsSingleReminder) {
				query.Filters.Add(query.CreateFilterWithParameters(FilterComparisonType.Equal, "Contact", Contact));
			}
			query.Filters.Add(query.CreateFilterWithParameters(FilterComparisonType.Equal, "Source", (Guid) Source));
			query.Filters.Add(query.CreateFilterWithParameters(FilterComparisonType.Equal, "SysEntitySchema.SysWorkspace.Id", UserConnection.Workspace.Id));
			var entities = query.GetEntityCollection(UserConnection);
			if (IsSingleReminder) {
				var count = entities.Count;
				ICollection<Entity> entityToDelete = new List<Entity>();
				for (int i = 0; i < count; i++) {
					var entity = entities[i];
					var contactId = entity.GetTypedColumnValue<Guid>("ContactId");
					if (!contactId.Equals(Contact)) {
						entity.Delete();
						entityToDelete.Add(entity);
					}
				}
				entities.RemoveRange(entityToDelete);
			}
			remindingExists = entities.Count > 0 && !IsListSubjectReminds;
			requiredReminding = entities.Count == 0 || IsListSubjectReminds
				? (Terrasoft.Configuration.Reminding) remindingSchema.CreateEntity(UserConnection)
				: (Terrasoft.Configuration.Reminding) entities[0];
			requiredReminding.UseAdminRights = GlobalAppSettings.FeatureUseAdminRightsInEmbeddedLogic;
			
			if (Active){
				if(!remindingExists) {
					requiredReminding.SetDefColumnValues();
					requiredReminding.Id = Guid.NewGuid();
				}
				if (SubjectPrimaryColumnValue != Guid.Empty) {
					requiredReminding.SetColumnValue(
						remindingSchemaColumns.GetByName("SubjectId").ColumnValueName, 
						SubjectPrimaryColumnValue
					);
					if (!string.IsNullOrEmpty(SubjectCaption)) {
						requiredReminding.SetColumnValue(
									remindingSchemaColumns.GetByName("SubjectCaption").ColumnValueName, 
									SubjectCaption);
					} else {
						if(SysEntitySchema != Guid.Empty) {
							var subjectSchema = UserConnection.EntitySchemaManager.GetInstanceByUId(SysEntitySchema);
							var subjectEntity = subjectSchema.CreateEntity(UserConnection);
							if (subjectEntity.FetchFromDB(SubjectPrimaryColumnValue)) {
								requiredReminding.SetColumnValue(
									remindingSchemaColumns.GetByName("SubjectCaption").ColumnValueName, 
									subjectEntity.GetTypedColumnValue<String>(subjectSchema.GetPrimaryDisplayColumnName())
								);
							}
						}
					}
				}
				if (Contact != Guid.Empty) {
					requiredReminding.SetColumnValue(
						remindingSchemaColumns.GetByName("Contact").ColumnValueName, 
						Contact
					);
				}
				if (!string.IsNullOrEmpty(TypeCaption)) {
					var typeCaptionColumn = remindingSchemaColumns.GetByName("TypeCaption");
					if (typeCaptionColumn != null) {
						requiredReminding.SetColumnValue(typeCaptionColumn.ColumnValueName, TypeCaption);
					}
				}
				if ((Guid)Source != Guid.Empty) {
					requiredReminding.SetColumnValue(
						remindingSchemaColumns.GetByName("Source").ColumnValueName, 
						(Guid)Source
					);
				}
				requiredReminding.SetColumnValue(
					remindingSchemaColumns.GetByName("RemindTime").ColumnValueName, 
					RemindTime
				);
				if ((Guid)Author != Guid.Empty) {
					requiredReminding.SetColumnValue(
						remindingSchemaColumns.GetByName("Author").ColumnValueName, 
						(Guid)Author
					);
				}
				requiredReminding.SetColumnValue(
					remindingSchemaColumns.GetByName("Description").ColumnValueName, 
					Description
				);
				if (SysEntitySchema != Guid.Empty) {
					requiredReminding.SetColumnValue(
						remindingSchemaColumns.GetByName("SysEntitySchema").ColumnValueName,
						SysEntitySchema
					);
				}
				if (PopupTitle.IsNotNullOrWhiteSpace()) {
					requiredReminding.SetColumnValue("PopupTitle", PopupTitle);
				}
				if (UserConnection.GetIsFeatureEnabled("NotificationV2")) {
					requiredReminding.SetColumnValue("IsNeedToSend", true);
				}
				requiredReminding.SetColumnValue(
					remindingSchemaColumns.GetByName("NotificationType").ColumnValueName, 
					NotificationType
				);
				requiredReminding.Save();
			} else {
				if(!IsListSubjectReminds && !IsSubjectDelete) {
					requiredReminding.Delete();
				} else {
					DeleteRemindingList(entities);
				}
			}
			return true;
		}

		#endregion

		#region Methods: Public

		public virtual void DeleteRemindingList(EntityCollection entities) {
			var count = entities.Count;
			for(int i = 0; i < count; i++) {
				entities[0].Delete();
			}
		}

		public override void WritePropertiesData(DataWriter writer) {
			writer.WriteStartObject(Name);
			base.WritePropertiesData(writer);
			if (Status == Core.Process.ProcessStatus.Inactive) {
				writer.WriteFinishObject();
				return;
			}
			if (!HasMapping("Active")) {
				writer.WriteValue("Active", Active, false);
			}
			if (!HasMapping("SubjectPrimaryColumnValue")) {
				writer.WriteValue("SubjectPrimaryColumnValue", SubjectPrimaryColumnValue, Guid.Empty);
			}
			if (Author != null) {
				if (Author.GetType().IsSerializable || Author.GetType().GetInterface("ISerializable") != null) {
					writer.WriteSerializableObjectValue("Author", Author, null);
				}
			}
			if (!HasMapping("Contact")) {
				writer.WriteValue("Contact", Contact, Guid.Empty);
			}
			if (Source != null) {
				if (Source.GetType().IsSerializable || Source.GetType().GetInterface("ISerializable") != null) {
					writer.WriteSerializableObjectValue("Source", Source, null);
				}
			}
			if (!HasMapping("RemindTime")) {
				writer.WriteValue("RemindTime", RemindTime, DateTime.ParseExact("01.01.0001 0:00", "dd.MM.yyyy H:mm", CultureInfo.InvariantCulture));
			}
			if (!HasMapping("Description")) {
				writer.WriteValue("Description", Description, null);
			}
			if (!HasMapping("SysEntitySchema")) {
				writer.WriteValue("SysEntitySchema", SysEntitySchema, Guid.Empty);
			}
			if (!HasMapping("SubjectCaption")) {
				writer.WriteValue("SubjectCaption", SubjectCaption, null);
			}
			if (!HasMapping("TypeCaption")) {
				writer.WriteValue("TypeCaption", TypeCaption, null);
			}
			if (!HasMapping("IsListSubjectReminds")) {
				writer.WriteValue("IsListSubjectReminds", IsListSubjectReminds, false);
			}
			if (!HasMapping("IsSubjectDelete")) {
				writer.WriteValue("IsSubjectDelete", IsSubjectDelete, false);
			}
			if (!HasMapping("NotificationType")) {
				writer.WriteValue("NotificationType", NotificationType, Guid.Empty);
			}
			if (!HasMapping("PopupTitle")) {
				writer.WriteValue("PopupTitle", PopupTitle, null);
			}
			if (!HasMapping("IsSingleReminder")) {
				writer.WriteValue("IsSingleReminder", IsSingleReminder, false);
			}
			writer.WriteFinishObject();
		}

		#endregion

		#region Methods: Protected

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			switch (reader.CurrentName) {
				case "Active":
					Active = reader.GetBoolValue();
				break;
				case "SubjectPrimaryColumnValue":
					SubjectPrimaryColumnValue = reader.GetGuidValue();
				break;
				case "Author":
					Author = reader.GetSerializableObjectValue();
				break;
				case "Contact":
					Contact = reader.GetGuidValue();
				break;
				case "Source":
					Source = reader.GetSerializableObjectValue();
				break;
				case "RemindTime":
					RemindTime = reader.GetDateTimeValue();
				break;
				case "Description":
					Description = reader.GetStringValue();
				break;
				case "SysEntitySchema":
					SysEntitySchema = reader.GetGuidValue();
				break;
				case "SubjectCaption":
					SubjectCaption = reader.GetStringValue();
				break;
				case "TypeCaption":
					TypeCaption = reader.GetStringValue();
				break;
				case "IsListSubjectReminds":
					IsListSubjectReminds = reader.GetBoolValue();
				break;
				case "IsSubjectDelete":
					IsSubjectDelete = reader.GetBoolValue();
				break;
				case "NotificationType":
					NotificationType = reader.GetGuidValue();
				break;
				case "PopupTitle":
					PopupTitle = reader.GetStringValue();
				break;
				case "IsSingleReminder":
					IsSingleReminder = reader.GetBoolValue();
				break;
			}
		}

		#endregion

	}

	#endregion

}

