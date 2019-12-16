namespace Terrasoft.Core.Process
{

	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Drawing;
	using System.Globalization;
	using System.Text;
	using Terrasoft.Common;
	using Terrasoft.Configuration;
	using Terrasoft.Configuration.FileImport;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Factories;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;
	using Terrasoft.Messaging.Common;

	#region Class: FileImportProcessSchema

	/// <exclude/>
	public class FileImportProcessSchema : Terrasoft.Core.Process.ProcessSchema
	{

		#region Constructors: Public

		public FileImportProcessSchema(ProcessSchemaManager processSchemaManager)
			: base(processSchemaManager) {
		}

		public FileImportProcessSchema(FileImportProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "FileImportProcess";
			UId = new Guid("3e7e191e-6b0c-4c8a-bfc3-00fe715aa84e");
			CreatedInPackageId = new Guid("422e303b-e4b1-4d5c-a964-ae75099f60da");
			CreatedInSchemaUId = Guid.Empty;
			CreatedInVersion = @"7.7.0.0";
			CultureName = @"ru-RU";
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			SerializeToDB = true;
			SerializeToMemory = true;
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
			ZipMethodsBody = new byte[] {  };
			ZipCompiledMethodsBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,148,109,111,218,48,16,128,63,131,212,255,96,241,201,104,81,254,192,74,165,242,214,33,193,132,86,182,125,118,195,129,172,57,118,116,118,216,88,213,255,190,179,51,72,156,242,82,36,132,156,243,221,115,47,190,187,162,124,81,50,99,59,137,174,20,138,205,134,194,194,84,42,152,229,133,65,7,200,70,8,194,69,34,254,84,202,53,179,96,173,52,122,182,238,179,215,187,110,167,86,88,137,237,66,104,177,37,219,147,194,1,211,240,251,228,21,255,110,1,71,70,107,200,28,161,251,159,137,187,19,200,202,72,252,136,219,255,12,146,89,135,101,230,12,146,176,204,65,59,222,139,149,123,9,59,3,213,70,47,1,173,180,142,204,162,140,7,108,164,132,181,83,225,193,251,244,9,220,125,243,254,129,191,139,39,64,171,251,165,64,145,3,169,89,86,212,199,193,121,119,158,223,54,229,117,113,107,242,220,108,235,242,53,69,173,178,37,13,199,13,243,175,198,201,141,108,1,14,194,107,136,243,209,87,135,137,118,210,237,159,197,14,38,136,6,217,167,1,227,188,25,99,63,250,72,191,8,189,86,48,249,147,65,225,253,221,228,66,234,109,147,127,72,161,223,250,76,195,105,127,25,61,50,170,204,245,18,77,70,5,191,41,116,175,251,225,176,37,216,5,224,22,62,8,159,233,141,89,80,64,52,19,151,93,12,97,99,16,98,71,254,17,188,159,83,3,150,86,195,76,2,123,25,252,184,161,255,27,184,99,80,212,44,84,113,234,163,245,117,124,187,105,214,103,193,161,165,130,222,129,74,191,57,33,239,143,170,15,204,209,149,159,218,99,114,252,74,211,122,234,209,190,49,109,73,64,5,99,4,87,162,62,63,182,164,243,118,215,189,235,22,241,254,108,135,214,140,41,236,201,177,112,226,135,80,37,172,246,5,176,117,244,53,104,237,170,52,82,62,148,132,246,69,36,31,238,143,71,238,232,207,108,248,216,251,148,57,244,67,42,180,35,253,204,100,37,34,37,225,239,200,83,228,217,51,171,81,24,75,91,40,81,17,185,46,149,106,239,207,116,84,97,188,52,152,213,84,239,145,71,46,169,154,43,200,9,24,92,250,181,51,55,153,80,242,175,120,81,240,28,116,90,155,39,253,105,240,151,45,68,6,233,55,176,166,196,140,244,12,82,226,9,235,157,234,144,94,66,238,58,189,119,92,155,174,106,231,105,200,167,23,61,172,15,166,245,88,175,204,179,234,237,72,194,240,102,157,78,179,44,148,73,149,94,58,53,152,11,199,27,89,38,205,42,247,189,41,53,73,231,205,55,203,63,111,185,95,137,105,7,0,0 };
			RealUId = new Guid("3e7e191e-6b0c-4c8a-bfc3-00fe715aa84e");
			Version = 0;
			PackageUId = new Guid("5932ac85-0d31-43c8-aeef-8b7dc5b56f60");
			UseSystemSecurityContext = false;
		}

		protected virtual ProcessSchemaParameter CreateImportSessionIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("c225458a-326c-44d0-97b2-08164e4e8c26"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("3e7e191e-6b0c-4c8a-bfc3-00fe715aa84e"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("3e7e191e-6b0c-4c8a-bfc3-00fe715aa84e"),
				Name = @"ImportSessionId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateCreateRemindingByProcessParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("d521237d-a51c-4c4e-879b-0f2c6b4b1102"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("3e7e191e-6b0c-4c8a-bfc3-00fe715aa84e"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("3e7e191e-6b0c-4c8a-bfc3-00fe715aa84e"),
				Name = @"CreateRemindingByProcess",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					Value = @"true",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("3e7e191e-6b0c-4c8a-bfc3-00fe715aa84e"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateImportLoggerParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("fc3e6aca-899d-4ba0-92f7-d6f237c2f5eb"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("3e7e191e-6b0c-4c8a-bfc3-00fe715aa84e"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("3e7e191e-6b0c-4c8a-bfc3-00fe715aa84e"),
				Name = @"ImportLogger",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			};
		}

		protected virtual ProcessSchemaParameter CreateFileImporterParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("a78ba39a-a76e-4d2f-a8b2-478e94949415"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("3e7e191e-6b0c-4c8a-bfc3-00fe715aa84e"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("3e7e191e-6b0c-4c8a-bfc3-00fe715aa84e"),
				Name = @"FileImporter",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			};
		}

		protected virtual ProcessSchemaParameter CreateImportNotifierParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("ee62b062-c5b1-407a-9433-31685004961e"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("3e7e191e-6b0c-4c8a-bfc3-00fe715aa84e"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("3e7e191e-6b0c-4c8a-bfc3-00fe715aa84e"),
				Name = @"ImportNotifier",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			};
		}

		protected virtual ProcessSchemaParameter CreateCompleteRemindingSubjectParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("e6a5383b-27dc-4e3f-acaf-0be29d36ba9f"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("422e303b-e4b1-4d5c-a964-ae75099f60da"),
				CreatedInSchemaUId = new Guid("3e7e191e-6b0c-4c8a-bfc3-00fe715aa84e"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("3e7e191e-6b0c-4c8a-bfc3-00fe715aa84e"),
				Name = @"CompleteRemindingSubject",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("LocalizableStringDataValueType"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("3e7e191e-6b0c-4c8a-bfc3-00fe715aa84e"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateCompleteRemindingDescriptionTemplateParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("bc14359b-5447-4d41-9da0-76039b4f5831"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("79cdeed7-eef0-4dd8-9765-07d140cf1035"),
				CreatedInSchemaUId = new Guid("3e7e191e-6b0c-4c8a-bfc3-00fe715aa84e"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("3e7e191e-6b0c-4c8a-bfc3-00fe715aa84e"),
				Name = @"CompleteRemindingDescriptionTemplate",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("LocalizableStringDataValueType"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("3e7e191e-6b0c-4c8a-bfc3-00fe715aa84e"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateNotImportedRowsCountMessageTemplateParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("231f8a46-6136-4dc2-a7ab-9f6f0e4c544e"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("79cdeed7-eef0-4dd8-9765-07d140cf1035"),
				CreatedInSchemaUId = new Guid("3e7e191e-6b0c-4c8a-bfc3-00fe715aa84e"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("3e7e191e-6b0c-4c8a-bfc3-00fe715aa84e"),
				Name = @"NotImportedRowsCountMessageTemplate",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("LocalizableStringDataValueType"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("3e7e191e-6b0c-4c8a-bfc3-00fe715aa84e"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateIsUsePersistentFileImportEnabledParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("d8a6c0ee-2b88-438c-9995-a64609e5aa7e"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("3e7e191e-6b0c-4c8a-bfc3-00fe715aa84e"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("3e7e191e-6b0c-4c8a-bfc3-00fe715aa84e"),
				Name = @"IsUsePersistentFileImportEnabled",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					Value = @"[#BooleanValue.True#]",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("3e7e191e-6b0c-4c8a-bfc3-00fe715aa84e"),
				},
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateImportSessionIdParameter());
			Parameters.Add(CreateCreateRemindingByProcessParameter());
			Parameters.Add(CreateImportLoggerParameter());
			Parameters.Add(CreateFileImporterParameter());
			Parameters.Add(CreateImportNotifierParameter());
			Parameters.Add(CreateCompleteRemindingSubjectParameter());
			Parameters.Add(CreateCompleteRemindingDescriptionTemplateParameter());
			Parameters.Add(CreateNotImportedRowsCountMessageTemplateParameter());
			Parameters.Add(CreateIsUsePersistentFileImportEnabledParameter());
		}

		protected virtual void InitializeUserTask2Parameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var importSessionIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("32b65f96-f26c-4513-8e9a-057ffcd02fab"),
				ContainerUId = new Guid("2c488a31-9f43-43e5-ac28-0a3a3ea2489c"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("4a4279e7-7ad3-4bc4-a92b-e762eeee9c8e"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("4a4279e7-7ad3-4bc4-a92b-e762eeee9c8e"),
				Name = @"ImportSessionId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			importSessionIdParameter.SourceValue = new ProcessSchemaParameterValue(importSessionIdParameter) {
				Source = ProcessSchemaParameterValueSource.Script,
				Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{c225458a-326c-44d0-97b2-08164e4e8c26}]#]",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("3e7e191e-6b0c-4c8a-bfc3-00fe715aa84e")
			};
			parametrizedElement.Parameters.Add(importSessionIdParameter);
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet1 = CreateLaneSet1LaneSet();
			LaneSets.Add(schemaLaneSet1);
			ProcessSchemaLane schemaLane1 = CreateLane1Lane();
			schemaLaneSet1.Lanes.Add(schemaLane1);
			ProcessSchemaStartEvent start1 = CreateStart1StartEvent();
			FlowElements.Add(start1);
			ProcessSchemaTerminateEvent terminate1 = CreateTerminate1TerminateEvent();
			FlowElements.Add(terminate1);
			ProcessSchemaScriptTask fileimporttask = CreateFileImportTaskScriptTask();
			FlowElements.Add(fileimporttask);
			ProcessSchemaScriptTask createremindingtask = CreateCreateRemindingTaskScriptTask();
			FlowElements.Add(createremindingtask);
			ProcessSchemaScriptTask postmessagetask = CreatePostMessageTaskScriptTask();
			FlowElements.Add(postmessagetask);
			ProcessSchemaScriptTask logimportresultstask = CreateLogImportResultsTaskScriptTask();
			FlowElements.Add(logimportresultstask);
			ProcessSchemaExclusiveGateway exclusivegateway1 = CreateExclusiveGateway1ExclusiveGateway();
			FlowElements.Add(exclusivegateway1);
			ProcessSchemaScriptTask scripttask1 = CreateScriptTask1ScriptTask();
			FlowElements.Add(scripttask1);
			ProcessSchemaUserTask usertask2 = CreateUserTask2UserTask();
			FlowElements.Add(usertask2);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateSequenceFlow4SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
			FlowElements.Add(CreateSequenceFlow5SequenceFlow());
			FlowElements.Add(CreateDefaultSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateConditionalSequenceFlow4ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow6SequenceFlow());
			FlowElements.Add(CreateSequenceFlow8SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("9f06bebc-217e-4b00-ac59-7b362c3e3060"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("422e303b-e4b1-4d5c-a964-ae75099f60da"),
				CreatedInSchemaUId = new Guid("3e7e191e-6b0c-4c8a-bfc3-00fe715aa84e"),
				CurveCenterPosition = new Point(373, 203),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("3e7e191e-6b0c-4c8a-bfc3-00fe715aa84e"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("796e22f0-f52d-4fb6-ab29-873e9f245a40"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("1b82b689-cca2-4475-8702-4bf214f6fa9a"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("93fb1d2e-b3d6-45c5-9b81-19bbe1c7567b"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("422e303b-e4b1-4d5c-a964-ae75099f60da"),
				CreatedInSchemaUId = new Guid("3e7e191e-6b0c-4c8a-bfc3-00fe715aa84e"),
				CurveCenterPosition = new Point(373, 203),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("3e7e191e-6b0c-4c8a-bfc3-00fe715aa84e"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("77c19b8e-5131-4a98-a063-832f58635a81"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("d24ff5d0-038b-47d1-931c-3f4de75a2a0f"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4",
				UId = new Guid("e16eac81-10f4-484b-af2f-4008bcf126b3"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("52abf94a-4a51-4e9b-afae-86480a04ff1e"),
				CreatedInSchemaUId = new Guid("3e7e191e-6b0c-4c8a-bfc3-00fe715aa84e"),
				CurveCenterPosition = new Point(373, 203),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("3e7e191e-6b0c-4c8a-bfc3-00fe715aa84e"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("d24ff5d0-038b-47d1-931c-3f4de75a2a0f"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("45ff1004-c87c-45b0-bfd2-5023cfd02f79"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3",
				UId = new Guid("55a7bc6d-9a13-4817-92c2-23510a5a7d42"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("79cdeed7-eef0-4dd8-9765-07d140cf1035"),
				CreatedInSchemaUId = new Guid("3e7e191e-6b0c-4c8a-bfc3-00fe715aa84e"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("3e7e191e-6b0c-4c8a-bfc3-00fe715aa84e"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("45ff1004-c87c-45b0-bfd2-5023cfd02f79"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("89735d99-1cde-4bd2-bbd1-d90f9c524476"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow5SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow5",
				UId = new Guid("41f61400-0554-4da5-b9f1-e39401588edd"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("79cdeed7-eef0-4dd8-9765-07d140cf1035"),
				CreatedInSchemaUId = new Guid("3e7e191e-6b0c-4c8a-bfc3-00fe715aa84e"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("3e7e191e-6b0c-4c8a-bfc3-00fe715aa84e"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("89735d99-1cde-4bd2-bbd1-d90f9c524476"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("4579883e-dfbb-4b76-b3f4-dae2f995a4bb"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateDefaultSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "DefaultSequenceFlow1",
				UId = new Guid("4c648c3e-231c-4394-a943-9058c33a35d7"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("5932ac85-0d31-43c8-aeef-8b7dc5b56f60"),
				CreatedInSchemaUId = new Guid("3e7e191e-6b0c-4c8a-bfc3-00fe715aa84e"),
				CurveCenterPosition = new Point(0, 0),
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("3e7e191e-6b0c-4c8a-bfc3-00fe715aa84e"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("a72c31b2-8a30-4119-8d97-33024d6f7375"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("77c19b8e-5131-4a98-a063-832f58635a81"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalSequenceFlow4ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalSequenceFlow4",
				UId = new Guid("109cd7cc-53f0-4df7-8071-4824befba3c4"),
				ConditionExpression = @"[#[IsOwnerSchema:false].[IsSchema:false].[Parameter:{d8a6c0ee-2b88-438c-9995-a64609e5aa7e}]#]",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("5932ac85-0d31-43c8-aeef-8b7dc5b56f60"),
				CreatedInSchemaUId = new Guid("3e7e191e-6b0c-4c8a-bfc3-00fe715aa84e"),
				CurveCenterPosition = new Point(0, 0),
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("3e7e191e-6b0c-4c8a-bfc3-00fe715aa84e"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("a72c31b2-8a30-4119-8d97-33024d6f7375"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("2c488a31-9f43-43e5-ac28-0a3a3ea2489c"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			schemaFlow.PolylinePointPositions.Add(new Point(272, 327));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow6SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow6",
				UId = new Guid("46bab91d-7603-4088-a4b9-5144990fca9f"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("5932ac85-0d31-43c8-aeef-8b7dc5b56f60"),
				CreatedInSchemaUId = new Guid("3e7e191e-6b0c-4c8a-bfc3-00fe715aa84e"),
				CurveCenterPosition = new Point(0, 0),
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("3e7e191e-6b0c-4c8a-bfc3-00fe715aa84e"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("1b82b689-cca2-4475-8702-4bf214f6fa9a"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("a72c31b2-8a30-4119-8d97-33024d6f7375"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow8SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow8",
				UId = new Guid("76cf7621-139f-423b-9d18-abc5cd910d73"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("5932ac85-0d31-43c8-aeef-8b7dc5b56f60"),
				CreatedInSchemaUId = new Guid("3e7e191e-6b0c-4c8a-bfc3-00fe715aa84e"),
				CurveCenterPosition = new Point(0, 0),
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("3e7e191e-6b0c-4c8a-bfc3-00fe715aa84e"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("2c488a31-9f43-43e5-ac28-0a3a3ea2489c"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("4579883e-dfbb-4b76-b3f4-dae2f995a4bb"),
				TargetSequenceFlowPointLocalPosition = new Point(0, -1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(833, 327));
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("81a2d907-3fa9-45ca-a3ed-a676ac7edf2e"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("422e303b-e4b1-4d5c-a964-ae75099f60da"),
				CreatedInSchemaUId = new Guid("3e7e191e-6b0c-4c8a-bfc3-00fe715aa84e"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("3e7e191e-6b0c-4c8a-bfc3-00fe715aa84e"),
				Name = @"LaneSet1",
				Position = new Point(5, 5),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("09a3376c-fbe5-466b-b421-55bb79fc0742"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("81a2d907-3fa9-45ca-a3ed-a676ac7edf2e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("422e303b-e4b1-4d5c-a964-ae75099f60da"),
				CreatedInSchemaUId = new Guid("3e7e191e-6b0c-4c8a-bfc3-00fe715aa84e"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("3e7e191e-6b0c-4c8a-bfc3-00fe715aa84e"),
				Name = @"Lane1",
				Position = new Point(29, 0),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaStartEvent CreateStart1StartEvent() {
			ProcessSchemaStartEvent schemaStartEvent = new ProcessSchemaStartEvent(this) {
				UId = new Guid("796e22f0-f52d-4fb6-ab29-873e9f245a40"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("09a3376c-fbe5-466b-b421-55bb79fc0742"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("422e303b-e4b1-4d5c-a964-ae75099f60da"),
				CreatedInSchemaUId = new Guid("3e7e191e-6b0c-4c8a-bfc3-00fe715aa84e"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsInterrupting = false,
				IsLogging = true,
				ManagerItemUId = new Guid("53818048-7868-48f6-ada0-0ebaa65af628"),
				ModifiedInSchemaUId = new Guid("3e7e191e-6b0c-4c8a-bfc3-00fe715aa84e"),
				Name = @"Start1",
				Position = new Point(50, 184),
				SerializeToDB = false,
				Size = new Size(27, 27),
				UseBackgroundMode = false
			};
			
			return schemaStartEvent;
		}

		protected virtual ProcessSchemaTerminateEvent CreateTerminate1TerminateEvent() {
			ProcessSchemaTerminateEvent schemaTerminateEvent = new ProcessSchemaTerminateEvent(this) {
				UId = new Guid("4579883e-dfbb-4b76-b3f4-dae2f995a4bb"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("09a3376c-fbe5-466b-b421-55bb79fc0742"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("422e303b-e4b1-4d5c-a964-ae75099f60da"),
				CreatedInSchemaUId = new Guid("3e7e191e-6b0c-4c8a-bfc3-00fe715aa84e"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = true,
				ManagerItemUId = new Guid("1bd93619-0574-454e-bb4e-cf53b9eb9470"),
				ModifiedInSchemaUId = new Guid("3e7e191e-6b0c-4c8a-bfc3-00fe715aa84e"),
				Name = @"Terminate1",
				Position = new Point(820, 184),
				SerializeToDB = false,
				Size = new Size(27, 27),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaTerminateEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateFileImportTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("77c19b8e-5131-4a98-a063-832f58635a81"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("09a3376c-fbe5-466b-b421-55bb79fc0742"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("422e303b-e4b1-4d5c-a964-ae75099f60da"),
				CreatedInSchemaUId = new Guid("3e7e191e-6b0c-4c8a-bfc3-00fe715aa84e"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("3e7e191e-6b0c-4c8a-bfc3-00fe715aa84e"),
				Name = @"FileImportTask",
				Position = new Point(351, 170),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,227,229,114,203,204,73,245,204,45,200,47,42,73,45,82,176,85,112,46,74,77,44,73,69,22,212,128,48,130,83,139,139,51,243,243,60,83,52,173,121,185,74,138,42,21,170,121,185,56,53,52,60,157,18,139,81,148,107,162,112,244,32,44,108,102,212,42,36,39,150,36,103,40,104,184,86,36,167,22,148,0,197,21,82,53,97,166,130,149,251,228,167,167,3,205,64,225,232,1,105,215,162,162,252,34,141,84,176,33,188,92,69,169,37,165,69,121,10,37,69,165,169,214,0,177,89,131,54,207,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaScriptTask CreateCreateRemindingTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("45ff1004-c87c-45b0-bfd2-5023cfd02f79"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("09a3376c-fbe5-466b-b421-55bb79fc0742"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("52abf94a-4a51-4e9b-afae-86480a04ff1e"),
				CreatedInSchemaUId = new Guid("3e7e191e-6b0c-4c8a-bfc3-00fe715aa84e"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("3e7e191e-6b0c-4c8a-bfc3-00fe715aa84e"),
				Name = @"CreateRemindingTask",
				Position = new Point(591, 170),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,165,84,95,111,155,48,16,127,206,164,125,7,139,39,162,69,168,123,238,82,105,33,75,133,212,86,85,73,251,238,194,37,245,20,236,200,62,86,161,40,223,125,103,28,192,9,172,108,218,19,216,254,253,185,59,159,79,108,88,24,107,224,8,79,80,8,153,11,185,93,84,143,90,101,96,204,148,29,62,127,154,36,197,94,105,124,228,154,23,128,160,13,219,119,191,115,22,134,201,130,27,88,137,29,56,32,232,233,217,34,90,145,234,165,70,232,54,82,50,17,74,38,249,244,154,140,210,202,60,27,208,137,220,40,150,149,90,131,68,187,38,19,251,137,149,148,144,33,193,163,184,59,180,188,219,82,228,44,83,18,121,134,73,78,112,143,28,197,205,190,69,46,41,205,181,40,128,229,205,207,57,248,22,240,164,221,32,195,58,178,82,72,100,82,225,41,169,252,73,189,155,88,149,180,57,247,170,17,61,12,32,44,221,160,166,178,178,28,76,166,197,222,166,64,60,183,25,173,148,46,56,134,177,42,246,59,240,46,97,217,129,215,64,103,20,207,204,247,234,25,205,200,104,226,1,214,10,249,174,59,245,185,246,126,30,104,81,231,38,168,1,6,83,187,97,87,174,1,38,126,224,95,46,35,31,74,250,158,238,149,111,161,11,124,200,160,118,63,118,229,201,248,112,105,130,195,213,145,29,190,30,131,25,235,85,41,45,95,127,82,83,204,252,218,214,186,73,154,189,65,193,239,185,164,56,116,130,80,124,251,33,81,96,229,246,111,152,56,107,64,58,103,115,155,234,69,167,249,156,147,150,109,18,139,95,84,182,132,97,112,214,201,193,223,153,155,202,156,158,216,157,218,254,143,249,203,123,234,75,57,123,159,199,116,91,42,183,238,61,166,63,185,72,131,92,102,208,56,181,37,247,61,58,117,210,189,112,138,220,84,113,192,240,220,180,150,104,241,81,10,184,132,77,172,118,101,33,95,248,174,4,19,246,17,222,113,24,124,47,241,77,233,36,167,158,104,31,254,8,165,29,4,255,192,73,85,169,51,168,41,109,254,164,99,208,68,93,11,214,152,38,160,17,65,199,178,131,133,36,155,33,52,194,241,38,65,208,111,244,15,130,119,111,163,142,126,104,220,126,192,172,140,223,21,181,66,175,101,163,231,113,29,23,65,204,155,224,79,79,124,132,118,167,120,14,238,114,123,175,116,200,149,255,114,99,154,102,137,6,44,181,100,168,75,184,254,13,171,64,117,238,218,6,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaScriptTask CreatePostMessageTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("d24ff5d0-038b-47d1-931c-3f4de75a2a0f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("09a3376c-fbe5-466b-b421-55bb79fc0742"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("52abf94a-4a51-4e9b-afae-86480a04ff1e"),
				CreatedInSchemaUId = new Guid("3e7e191e-6b0c-4c8a-bfc3-00fe715aa84e"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("3e7e191e-6b0c-4c8a-bfc3-00fe715aa84e"),
				Name = @"PostMessageTask",
				Position = new Point(471, 170),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,211,208,240,204,45,200,47,42,241,203,47,201,76,203,76,45,210,68,227,234,129,89,149,174,121,41,26,154,214,188,92,69,169,37,165,69,121,10,37,69,165,169,214,0,233,152,54,169,59,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaScriptTask CreateLogImportResultsTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("89735d99-1cde-4bd2-bbd1-d90f9c524476"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("09a3376c-fbe5-466b-b421-55bb79fc0742"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("79cdeed7-eef0-4dd8-9765-07d140cf1035"),
				CreatedInSchemaUId = new Guid("3e7e191e-6b0c-4c8a-bfc3-00fe715aa84e"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("3e7e191e-6b0c-4c8a-bfc3-00fe715aa84e"),
				Name = @"LogImportResultsTask",
				Position = new Point(711, 170),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,211,208,240,204,45,200,47,42,241,201,79,79,79,45,210,68,225,232,5,39,150,165,2,217,26,154,214,188,92,69,169,37,165,69,121,10,37,69,165,169,214,0,88,235,121,210,53,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGateway1ExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("a72c31b2-8a30-4119-8d97-33024d6f7375"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("09a3376c-fbe5-466b-b421-55bb79fc0742"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("5932ac85-0d31-43c8-aeef-8b7dc5b56f60"),
				CreatedInSchemaUId = new Guid("3e7e191e-6b0c-4c8a-bfc3-00fe715aa84e"),
				ImageList = null,
				ImageName = null,
				IsLogging = true,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("3e7e191e-6b0c-4c8a-bfc3-00fe715aa84e"),
				Name = @"ExclusiveGateway1",
				Position = new Point(245, 170),
				SerializeToDB = false,
				Size = new Size(55, 55),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask1ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("1b82b689-cca2-4475-8702-4bf214f6fa9a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("09a3376c-fbe5-466b-b421-55bb79fc0742"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("5932ac85-0d31-43c8-aeef-8b7dc5b56f60"),
				CreatedInSchemaUId = new Guid("3e7e191e-6b0c-4c8a-bfc3-00fe715aa84e"),
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("3e7e191e-6b0c-4c8a-bfc3-00fe715aa84e"),
				Name = @"ScriptTask1",
				Position = new Point(125, 170),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = true,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,204,49,10,128,48,12,5,208,221,83,148,78,10,226,5,58,138,149,110,130,120,128,170,127,40,212,84,146,120,127,59,184,186,63,222,10,109,109,144,77,176,128,37,137,130,212,167,140,112,221,133,117,162,184,103,156,182,55,21,240,88,136,112,104,42,52,204,208,32,30,81,31,198,135,90,251,147,216,174,115,13,163,82,50,202,15,220,11,205,159,150,252,116,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaUserTask CreateUserTask2UserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("2c488a31-9f43-43e5-ac28-0a3a3ea2489c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("09a3376c-fbe5-466b-b421-55bb79fc0742"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("5932ac85-0d31-43c8-aeef-8b7dc5b56f60"),
				CreatedInSchemaUId = new Guid("3e7e191e-6b0c-4c8a-bfc3-00fe715aa84e"),
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("3e7e191e-6b0c-4c8a-bfc3-00fe715aa84e"),
				Name = @"UserTask2",
				Position = new Point(351, 300),
				SchemaUId = new Guid("4a4279e7-7ad3-4bc4-a92b-e762eeee9c8e"),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
			ZipAfterActivitySaveScript = new byte[] {  }
			};
			InitializeUserTask2Parameters(schemaTask);
			return schemaTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("f41c767b-58cf-438a-ae91-abe533146f2d"),
				Name = "Terrasoft.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("422e303b-e4b1-4d5c-a964-ae75099f60da")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("2eb91ae4-6b15-469b-b9fc-09f42e13303e"),
				Name = "Terrasoft.Configuration.FileImport",
				Alias = "",
				CreatedInPackageId = new Guid("422e303b-e4b1-4d5c-a964-ae75099f60da")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("bbc74413-5949-4426-a5eb-dbae26e7d140"),
				Name = "Terrasoft.Messaging.Common",
				Alias = "",
				CreatedInPackageId = new Guid("52abf94a-4a51-4e9b-afae-86480a04ff1e")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5a9cb62b-9b58-4ad0-9299-3feeec1d49b1"),
				Name = "Terrasoft.Core.Factories",
				Alias = "",
				CreatedInPackageId = new Guid("79cdeed7-eef0-4dd8-9765-07d140cf1035")
			});
		}

		#endregion

		#region Methods: Public

		public override Process CreateProcess(UserConnection userConnection) {
			return new FileImportProcess(userConnection);
		}

		public override object Clone() {
			return new FileImportProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("3e7e191e-6b0c-4c8a-bfc3-00fe715aa84e"));
		}

		#endregion

	}

	#endregion

	#region Class: FileImportProcessMethodsWrapper

	/// <exclude/>
	public class FileImportProcessMethodsWrapper : ProcessModel
	{

		public FileImportProcessMethodsWrapper(Process process)
			: base(process) {
			AddScriptTaskMethod("ScriptTask1Execute", ScriptTask1Execute);
		}

		#region Methods: Private

		private bool ScriptTask1Execute(ProcessExecutingContext context) {
			Set("IsUsePersistentFileImportEnabled", UserConnection.GetIsFeatureEnabled("UsePersistentFileImport"));
			return true;
		}

		#endregion

	}

	#endregion

	#region Class: FileImportProcess

	/// <exclude/>
	public class FileImportProcess : Terrasoft.Core.Process.Process
	{

		#region Class: ProcessLane1

		/// <exclude/>
		public class ProcessLane1 : ProcessLane
		{

			public ProcessLane1(UserConnection userConnection, FileImportProcess process)
				: base(userConnection) {
				Owner = process;
				IsUsedParentUserContexts = false;
			}

		}

		#endregion

		#region Class: UserTask2FlowElement

		/// <exclude/>
		public class UserTask2FlowElement : FileImportPersistentTask
		{

			#region Constructors: Public

			public UserTask2FlowElement(UserConnection userConnection, FileImportProcess process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "UserTask2";
				IsLogging = true;
				SchemaElementUId = new Guid("2c488a31-9f43-43e5-ac28-0a3a3ea2489c");
				CreatedInSchemaUId = process.InternalSchemaUId;
				_importSessionId = () => (Guid)((process.ImportSessionId));
			}

			#endregion

			#region Properties: Public

			internal Func<Guid> _importSessionId;
			public override Guid ImportSessionId {
				get {
					return (_importSessionId ?? (_importSessionId = () => Guid.Empty)).Invoke();
				}
				set {
					_importSessionId = () => { return value; };
				}
			}

			#endregion

		}

		#endregion

		public FileImportProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "FileImportProcess";
			SchemaUId = new Guid("3e7e191e-6b0c-4c8a-bfc3-00fe715aa84e");
			Caption = Schema.Caption;
			SchemaManagerName = "ProcessSchemaManager";
			SerializeToDB = true;
			SerializeToMemory = true;
			IsLogging = true;
			UseSystemSecurityContext = false;
			_notificationCaption = () => { return new LocalizableString((Caption)); };
			_createRemindingByProcess = () => { return (bool)(true); };
			_isUsePersistentFileImportEnabled = () => { return (bool)(true); };
			ProcessModel = new FileImportProcessMethodsWrapper(this);
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("3e7e191e-6b0c-4c8a-bfc3-00fe715aa84e");
			}
		}

		private string ConditionalExpressionLogMessage {
			get {
				return "Process: FileImportProcess, Source element: {0}, Conditional flow: {1}, Expression: {2}, Result: {3}";
			}
		}

		private string DeadEndGatewayLogMessage {
			get {
				return "Process: FileImportProcess, Source element: {0}, None of the exclusive gateway conditions are met!";
			}
		}

		#endregion

		#region Properties: Public

		private Func<string> _notificationCaption;
		public virtual string NotificationCaption {
			get {
				return (_notificationCaption ?? (_notificationCaption = () => null)).Invoke();
			}
			set {
				_notificationCaption = () => { return value; };
			}
		}

		public virtual Guid ImportSessionId {
			get;
			set;
		}

		private Func<bool> _createRemindingByProcess;
		public virtual bool CreateRemindingByProcess {
			get {
				return (_createRemindingByProcess ?? (_createRemindingByProcess = () => false)).Invoke();
			}
			set {
				_createRemindingByProcess = () => { return value; };
			}
		}

		public virtual Object ImportLogger {
			get;
			set;
		}

		public virtual Object FileImporter {
			get;
			set;
		}

		public virtual Object ImportNotifier {
			get;
			set;
		}

		private LocalizableString _completeRemindingSubject;
		public virtual LocalizableString CompleteRemindingSubject {
			get {
				return _completeRemindingSubject ?? (_completeRemindingSubject = GetLocalizableString("3e7e191e6b0c4c8abfc300fe715aa84e",
						 "Parameters.CompleteRemindingSubject.Value"));
			}
			set {
				_completeRemindingSubject = value;
			}
		}

		private LocalizableString _completeRemindingDescriptionTemplate;
		public virtual LocalizableString CompleteRemindingDescriptionTemplate {
			get {
				return _completeRemindingDescriptionTemplate ?? (_completeRemindingDescriptionTemplate = GetLocalizableString("3e7e191e6b0c4c8abfc300fe715aa84e",
						 "Parameters.CompleteRemindingDescriptionTemplate.Value"));
			}
			set {
				_completeRemindingDescriptionTemplate = value;
			}
		}

		private LocalizableString _notImportedRowsCountMessageTemplate;
		public virtual LocalizableString NotImportedRowsCountMessageTemplate {
			get {
				return _notImportedRowsCountMessageTemplate ?? (_notImportedRowsCountMessageTemplate = GetLocalizableString("3e7e191e6b0c4c8abfc300fe715aa84e",
						 "Parameters.NotImportedRowsCountMessageTemplate.Value"));
			}
			set {
				_notImportedRowsCountMessageTemplate = value;
			}
		}

		private Func<bool> _isUsePersistentFileImportEnabled;
		public virtual bool IsUsePersistentFileImportEnabled {
			get {
				return (_isUsePersistentFileImportEnabled ?? (_isUsePersistentFileImportEnabled = () => false)).Invoke();
			}
			set {
				_isUsePersistentFileImportEnabled = () => { return value; };
			}
		}

		private ProcessLane1 _lane1;
		public ProcessLane1 Lane1 {
			get {
				return _lane1 ?? ((_lane1) = new ProcessLane1(UserConnection, this));
			}
		}

		private ProcessFlowElement _start1;
		public ProcessFlowElement Start1 {
			get {
				return _start1 ?? (_start1 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartEvent",
					Name = "Start1",
					SchemaElementUId = new Guid("796e22f0-f52d-4fb6-ab29-873e9f245a40"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
				});
			}
		}

		private ProcessTerminateEvent _terminate1;
		public ProcessTerminateEvent Terminate1 {
			get {
				return _terminate1 ?? (_terminate1 = new ProcessTerminateEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaTerminateEvent",
					Name = "Terminate1",
					SchemaElementUId = new Guid("4579883e-dfbb-4b76-b3f4-dae2f995a4bb"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
				});
			}
		}

		private ProcessScriptTask _fileImportTask;
		public ProcessScriptTask FileImportTask {
			get {
				return _fileImportTask ?? (_fileImportTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "FileImportTask",
					SchemaElementUId = new Guid("77c19b8e-5131-4a98-a063-832f58635a81"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
					Script = FileImportTaskExecute,
				});
			}
		}

		private ProcessScriptTask _createRemindingTask;
		public ProcessScriptTask CreateRemindingTask {
			get {
				return _createRemindingTask ?? (_createRemindingTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "CreateRemindingTask",
					SchemaElementUId = new Guid("45ff1004-c87c-45b0-bfd2-5023cfd02f79"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
					Script = CreateRemindingTaskExecute,
				});
			}
		}

		private ProcessScriptTask _postMessageTask;
		public ProcessScriptTask PostMessageTask {
			get {
				return _postMessageTask ?? (_postMessageTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "PostMessageTask",
					SchemaElementUId = new Guid("d24ff5d0-038b-47d1-931c-3f4de75a2a0f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
					Script = PostMessageTaskExecute,
				});
			}
		}

		private ProcessScriptTask _logImportResultsTask;
		public ProcessScriptTask LogImportResultsTask {
			get {
				return _logImportResultsTask ?? (_logImportResultsTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "LogImportResultsTask",
					SchemaElementUId = new Guid("89735d99-1cde-4bd2-bbd1-d90f9c524476"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
					Script = LogImportResultsTaskExecute,
				});
			}
		}

		private ProcessExclusiveGateway _exclusiveGateway1;
		public ProcessExclusiveGateway ExclusiveGateway1 {
			get {
				return _exclusiveGateway1 ?? (_exclusiveGateway1 = new ProcessExclusiveGateway() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaExclusiveGateway",
					Name = "ExclusiveGateway1",
					SchemaElementUId = new Guid("a72c31b2-8a30-4119-8d97-33024d6f7375"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
						Question = GetLocalizableString(Schema.GetResourceManagerName(),
					"BaseElements.ExclusiveGateway1.Question"),
						IsDecisionRequired = false,
						BranchingMode = GatewayBranchingMode.Auto,
						DecisionMode = GetewayDecisionSelectionMode.Single,
						ShowUserDecisionDialog = (processId, gatewayName) => {},
				});
			}
		}

		private ProcessScriptTask _scriptTask1;
		public ProcessScriptTask ScriptTask1 {
			get {
				return _scriptTask1 ?? (_scriptTask1 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask1",
					SchemaElementUId = new Guid("1b82b689-cca2-4475-8702-4bf214f6fa9a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
					Script = ProcessModel.GetScriptTaskMethod("ScriptTask1Execute"),
				});
			}
		}

		private UserTask2FlowElement _userTask2;
		public UserTask2FlowElement UserTask2 {
			get {
				return _userTask2 ?? (_userTask2 = new UserTask2FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessConditionalFlow _conditionalSequenceFlow4;
		public ProcessConditionalFlow ConditionalSequenceFlow4 {
			get {
				return _conditionalSequenceFlow4 ?? (_conditionalSequenceFlow4 = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ConditionalSequenceFlow4",
					SchemaElementUId = new Guid("109cd7cc-53f0-4df7-8071-4824befba3c4"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[Start1.SchemaElementUId] = new Collection<ProcessFlowElement> { Start1 };
			FlowElements[Terminate1.SchemaElementUId] = new Collection<ProcessFlowElement> { Terminate1 };
			FlowElements[FileImportTask.SchemaElementUId] = new Collection<ProcessFlowElement> { FileImportTask };
			FlowElements[CreateRemindingTask.SchemaElementUId] = new Collection<ProcessFlowElement> { CreateRemindingTask };
			FlowElements[PostMessageTask.SchemaElementUId] = new Collection<ProcessFlowElement> { PostMessageTask };
			FlowElements[LogImportResultsTask.SchemaElementUId] = new Collection<ProcessFlowElement> { LogImportResultsTask };
			FlowElements[ExclusiveGateway1.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway1 };
			FlowElements[ScriptTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask1 };
			FlowElements[UserTask2.SchemaElementUId] = new Collection<ProcessFlowElement> { UserTask2 };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "Start1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ScriptTask1", e.Context.SenderName));
						break;
					case "Terminate1":
						CompleteProcess();
						break;
					case "FileImportTask":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("PostMessageTask", e.Context.SenderName));
						break;
					case "CreateRemindingTask":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("LogImportResultsTask", e.Context.SenderName));
						break;
					case "PostMessageTask":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("CreateRemindingTask", e.Context.SenderName));
						break;
					case "LogImportResultsTask":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("Terminate1", e.Context.SenderName));
						break;
					case "ExclusiveGateway1":
						if (ConditionalSequenceFlow4ExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("UserTask2", e.Context.SenderName));
							break;
						}
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("FileImportTask", e.Context.SenderName));
						break;
					case "ScriptTask1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ExclusiveGateway1", e.Context.SenderName));
						break;
					case "UserTask2":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("Terminate1", e.Context.SenderName));
						break;
			}
		}

		private bool ConditionalSequenceFlow4ExpressionExecute() {
			bool result = Convert.ToBoolean((IsUsePersistentFileImportEnabled));
			Log.InfoFormat(ConditionalExpressionLogMessage, "ExclusiveGateway1", "ConditionalSequenceFlow4", "(IsUsePersistentFileImportEnabled)", result);
			return result;
		}

		private void WritePropertyValues(DataWriter writer, bool useAllValueSources) {
			if (!HasMapping("ImportSessionId")) {
				writer.WriteValue("ImportSessionId", ImportSessionId, Guid.Empty);
			}
			if (ImportLogger != null) {
				if (ImportLogger.GetType().IsSerializable ||
					ImportLogger.GetType().GetInterface("ISerializable") != null) {
					writer.WriteSerializableObjectValue("ImportLogger", ImportLogger, null);
				}
			}
			if (FileImporter != null) {
				if (FileImporter.GetType().IsSerializable ||
					FileImporter.GetType().GetInterface("ISerializable") != null) {
					writer.WriteSerializableObjectValue("FileImporter", FileImporter, null);
				}
			}
			if (ImportNotifier != null) {
				if (ImportNotifier.GetType().IsSerializable ||
					ImportNotifier.GetType().GetInterface("ISerializable") != null) {
					writer.WriteSerializableObjectValue("ImportNotifier", ImportNotifier, null);
				}
			}
			if (!HasMapping("CreateRemindingByProcess")) {
				writer.WriteValue("CreateRemindingByProcess", CreateRemindingByProcess, false);
			}
			if (!HasMapping("IsUsePersistentFileImportEnabled")) {
				writer.WriteValue("IsUsePersistentFileImportEnabled", IsUsePersistentFileImportEnabled, false);
			}
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			if (IsProcessExecutedBySignal) {
				return;
			}
			context.QueueTasksV2.Enqueue(new ProcessQueueElement("Start1", string.Empty));
		}

		protected override void CompleteApplyingFlowElementsPropertiesData() {
			base.CompleteApplyingFlowElementsPropertiesData();
			foreach (var item in FlowElements) {
				foreach (var itemValue in item.Value) {
					if (Guid.Equals(itemValue.CreatedInSchemaUId, InternalSchemaUId)) {
						itemValue.ExecutedEventHandler = OnExecuted;
					}
				}
			}
		}

		protected override void InitializeMetaPathParameterValues() {
			base.InitializeMetaPathParameterValues();
			MetaPathParameterValues.Add("c225458a-326c-44d0-97b2-08164e4e8c26", () => ImportSessionId);
			MetaPathParameterValues.Add("d521237d-a51c-4c4e-879b-0f2c6b4b1102", () => CreateRemindingByProcess);
			MetaPathParameterValues.Add("fc3e6aca-899d-4ba0-92f7-d6f237c2f5eb", () => ImportLogger);
			MetaPathParameterValues.Add("a78ba39a-a76e-4d2f-a8b2-478e94949415", () => FileImporter);
			MetaPathParameterValues.Add("ee62b062-c5b1-407a-9433-31685004961e", () => ImportNotifier);
			MetaPathParameterValues.Add("e6a5383b-27dc-4e3f-acaf-0be29d36ba9f", () => CompleteRemindingSubject);
			MetaPathParameterValues.Add("bc14359b-5447-4d41-9da0-76039b4f5831", () => CompleteRemindingDescriptionTemplate);
			MetaPathParameterValues.Add("231f8a46-6136-4dc2-a7ab-9f6f0e4c544e", () => NotImportedRowsCountMessageTemplate);
			MetaPathParameterValues.Add("d8a6c0ee-2b88-438c-9995-a64609e5aa7e", () => IsUsePersistentFileImportEnabled);
			MetaPathParameterValues.Add("32b65f96-f26c-4513-8e9a-057ffcd02fab", () => UserTask2.ImportSessionId);
		}

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			bool hasValueToRead = reader.HasValue();
			switch (reader.CurrentName) {
				case "ImportSessionId":
					if (!hasValueToRead) break;
					ImportSessionId = reader.GetValue<System.Guid>();
				break;
				case "ImportLogger":
					if (!hasValueToRead) break;
					ImportLogger = reader.GetSerializableObjectValue();
				break;
				case "FileImporter":
					if (!hasValueToRead) break;
					FileImporter = reader.GetSerializableObjectValue();
				break;
				case "ImportNotifier":
					if (!hasValueToRead) break;
					ImportNotifier = reader.GetSerializableObjectValue();
				break;
				case "CreateRemindingByProcess":
					if (!hasValueToRead) break;
					CreateRemindingByProcess = reader.GetValue<System.Boolean>();
				break;
				case "IsUsePersistentFileImportEnabled":
					if (!hasValueToRead) break;
					IsUsePersistentFileImportEnabled = reader.GetValue<System.Boolean>();
				break;
			}
		}

		protected override void WritePropertyValues(DataWriter writer) {
			base.WritePropertyValues(writer);
			WritePropertyValues(writer, true);
		}

		#endregion

		#region Methods: Public

		public virtual bool FileImportTaskExecute(ProcessExecutingContext context) {
			
			FileImporter = CreateFileImporter(ImportSessionId);
			try {
				((IBaseFileImporter)FileImporter).Import(ImportSessionId);
			} catch (Exception e) {
				((ImportLogger)ImportLogger).LogError(e);
			}
			return true;
		}

		public virtual bool CreateRemindingTaskExecute(ProcessExecutingContext context) {
			if (CreateRemindingByProcess) {
				ImportParameters parameters = ((IBaseFileImporter)FileImporter).FindImportParameters(ImportSessionId);
				SysUserInfo currentUser = UserConnection.CurrentUser;
				Guid contactId = currentUser.ContactId;
				DateTime dateTime = currentUser.GetCurrentDateTime();
				uint notImportedRowsCount = parameters.NotImportedRowsCount;
				string description = string.Format(CompleteRemindingDescriptionTemplate, parameters.ImportedRowsCount,
					parameters.TotalRowsCount, parameters.FileName);
				if (notImportedRowsCount > 0) {
					description += string.Format(NotImportedRowsCountMessageTemplate, notImportedRowsCount);
				}
				string caption = string.Format("{0} {1}", CompleteRemindingSubject, description);
				ISchemaManagerItem<EntitySchema> importSessionItem =
					UserConnection.EntitySchemaManager.GetItemByName("ImportSession");
				ISchemaManagerItem<EntitySchema> sysProcessLogItem =
					UserConnection.EntitySchemaManager.GetItemByName("VwSysProcessLog");
				EntitySchema remindingSchema = UserConnection.EntitySchemaManager.GetInstanceByName("Reminding");
				Entity reminding = remindingSchema.CreateEntity(UserConnection);
				reminding.SetDefColumnValues();
				reminding.SetColumnValue("AuthorId", contactId);
				reminding.SetColumnValue("ContactId", contactId);
				reminding.SetColumnValue("SourceId", RemindingConsts.RemindingSourceAuthorId);
				reminding.SetColumnValue("RemindTime", dateTime);
				reminding.SetColumnValue("Description", description);
				reminding.SetColumnValue("SubjectId", ImportSessionId);
				reminding.SetColumnValue("SysEntitySchemaId", sysProcessLogItem.UId);
				reminding.SetColumnValue("SubjectCaption", caption);
				reminding.SetColumnValue("LoaderId", importSessionItem.UId);
				reminding.Save();
			}
			return true;
		}

		public virtual bool PostMessageTaskExecute(ProcessExecutingContext context) {
			((ImportNotifier)ImportNotifier).NotifyEnd();
			return true;
		}

		public virtual bool LogImportResultsTaskExecute(ProcessExecutingContext context) {
			((ImportLogger)ImportLogger).SaveLog();
			return true;
		}

			public virtual IBaseFileImporter CreateFileImporter(Guid sessionId) {
				FileImportTagManager FileImportTagManager = new FileImportTagManager(UserConnection);
				var userConnectionArg = new ConstructorArgument("userConnection", UserConnection);
				var nonPersistentFileImporter = ClassFactory.Get<FileImporter>(userConnectionArg);
				ImportParameters parameters = nonPersistentFileImporter.GetImportParameters(sessionId);
				ImportLogger = new ImportLogger(UserConnection, parameters);
				ImportNotifier = new ImportNotifier(UserConnection, parameters);
				nonPersistentFileImporter.ImportEntitySaveError += ((ImportLogger)ImportLogger).HandleException;
				nonPersistentFileImporter.ImportEntitySaving += ((ImportNotifier)ImportNotifier).Notify;
				nonPersistentFileImporter.ColumnProcessError += ((ImportLogger)ImportLogger).HandleError;
				nonPersistentFileImporter.ImportEntitiesMerge += ((ImportLogger)ImportLogger).HandleInfoMessage;
				nonPersistentFileImporter.BeforeImportEntitiesSave += FileImportTagManager.CreateTags;
				nonPersistentFileImporter.AfterImportEntitiesSave += FileImportTagManager.DeleteNotUsedTags;
				nonPersistentFileImporter.ImportEntitySaved += FileImportTagManager.SaveEntityTags;
				
				List<ImportTag> tags = CreateTags();
				nonPersistentFileImporter.SaveImportTags(sessionId, tags);
				return nonPersistentFileImporter;
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

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			base.ThrowEvent(context, message);
		}

		public override void WritePropertiesData(DataWriter writer, bool writeFlowElements = true) {
			if (Status == Core.Process.ProcessStatus.Inactive) {
				return;
			}
			writer.WriteStartObject(Name);
			base.WritePropertiesData(writer, writeFlowElements);
			WritePropertyValues(writer, false);
			writer.WriteFinishObject();
		}

		public override object CloneShallow() {
			var cloneItem = (FileImportProcess)base.CloneShallow();
			cloneItem.ExecutedEventHandler = ExecutedEventHandler;
			cloneItem.ImportLogger = ImportLogger;
			cloneItem.FileImporter = FileImporter;
			cloneItem.ImportNotifier = ImportNotifier;
			return cloneItem;
		}

		#endregion

	}

	#endregion

}

