namespace Terrasoft.Core.Process
{

	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Drawing;
	using System.Globalization;
	using System.Linq;
	using System.Text;
	using Terrasoft.Common;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Factories;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;
	using Terrasoft.Sync;
	using Terrasoft.Sync.Exchange;

	#region Class: SyncExchangeContactsProcessSchema

	/// <exclude/>
	public class SyncExchangeContactsProcessSchema : Terrasoft.Core.Process.ProcessSchema
	{

		#region Constructors: Public

		public SyncExchangeContactsProcessSchema(ProcessSchemaManager processSchemaManager)
			: base(processSchemaManager) {
		}

		public SyncExchangeContactsProcessSchema(SyncExchangeContactsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "SyncExchangeContactsProcess";
			UId = new Guid("9a0f18ce-f112-4078-9025-0c8243d9bf63");
			CreatedInPackageId = new Guid("f4dad6d8-e90c-404a-81b9-255599719041");
			CreatedInSchemaUId = Guid.Empty;
			CreatedInVersion = @"0.0.0.0";
			CultureName = @"ru-RU";
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsLogging = false;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			SerializeToDB = false;
			SerializeToMemory = false;
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
			ZipMethodsBody = new byte[] {  };
			ZipCompiledMethodsBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,165,85,77,111,26,49,16,61,19,41,255,193,245,33,90,164,213,42,189,182,77,164,176,33,45,82,243,161,146,156,74,15,238,238,20,172,122,109,100,123,105,40,218,255,158,241,218,32,246,163,128,84,33,36,51,30,191,121,243,222,216,156,159,45,203,159,130,103,100,197,181,45,153,32,43,197,115,50,93,203,108,161,149,228,127,33,26,146,205,249,217,96,34,185,229,76,96,224,9,116,193,141,225,74,154,209,250,113,9,154,89,183,142,134,31,49,141,255,34,145,177,154,203,121,50,49,15,165,16,143,122,92,44,237,58,154,130,204,1,215,140,139,155,60,215,96,204,208,3,15,238,148,46,152,253,6,166,20,54,122,0,200,167,96,95,12,232,109,154,131,29,104,176,165,150,110,89,225,119,197,52,89,128,192,218,228,138,72,248,67,198,210,114,187,222,99,173,191,212,219,158,148,79,77,82,1,76,119,51,35,87,44,85,82,66,230,26,169,79,248,22,136,174,73,221,35,11,54,135,152,20,126,241,188,20,117,171,210,18,161,50,38,210,5,147,115,48,169,42,165,141,241,76,161,44,236,199,92,242,248,53,171,35,47,150,11,172,159,56,2,219,216,196,66,97,90,44,98,210,21,44,38,78,9,244,227,234,154,164,130,25,115,199,50,171,244,58,249,12,246,211,136,25,216,2,58,240,39,173,86,28,1,174,35,186,13,35,186,197,19,251,187,52,118,144,3,39,33,238,98,215,165,67,188,209,243,178,0,105,35,90,54,72,209,152,180,180,58,114,220,116,122,160,125,141,29,135,177,22,237,112,135,37,142,212,208,231,171,210,182,13,114,161,30,75,124,102,219,150,26,164,237,75,83,163,12,129,31,88,1,187,209,126,215,59,219,13,22,189,99,221,204,232,153,232,221,47,252,225,62,125,151,178,129,24,38,52,140,164,175,217,55,181,120,65,2,103,127,60,162,155,205,140,254,134,245,140,126,32,51,186,185,172,102,40,235,140,6,160,16,125,143,209,170,138,169,31,185,190,81,44,246,122,249,170,88,238,105,245,85,67,188,192,197,56,244,239,88,242,7,169,42,26,147,142,42,253,205,135,182,60,226,189,153,143,234,235,123,147,57,119,122,117,240,86,165,76,78,138,165,210,54,120,106,238,180,42,182,126,147,139,11,226,50,198,175,251,25,207,106,187,31,128,130,47,245,123,24,146,110,65,114,200,107,11,171,211,106,181,176,218,2,93,86,4,245,166,59,73,99,210,128,242,245,134,221,130,39,82,63,94,174,1,212,41,23,96,66,246,225,9,61,225,79,162,38,119,216,154,171,214,43,147,220,142,166,144,149,26,239,231,88,206,185,4,247,224,213,2,96,212,194,14,61,162,7,113,59,175,87,146,150,90,227,3,227,162,201,196,247,124,64,215,255,227,245,47,212,83,88,213,138,191,1,149,43,166,40,169,7,0,0 };
			RealUId = new Guid("9a0f18ce-f112-4078-9025-0c8243d9bf63");
			Version = 0;
			PackageUId = new Guid("b8c22230-2173-426f-959e-be736709a63f");
			UseSystemSecurityContext = false;
		}

		protected virtual ProcessSchemaParameter CreateSenderEmailAddressParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("7176f340-3ddc-4681-8284-213f3d143daf"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("9a0f18ce-f112-4078-9025-0c8243d9bf63"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("9a0f18ce-f112-4078-9025-0c8243d9bf63"),
				Name = @"SenderEmailAddress",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MediumText"),
			};
		}

		protected virtual ProcessSchemaParameter CreateLoadResultParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("dc028f17-14b6-40df-a81d-174aaa291cfa"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("9a0f18ce-f112-4078-9025-0c8243d9bf63"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("9a0f18ce-f112-4078-9025-0c8243d9bf63"),
				Name = @"LoadResult",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText"),
			};
		}

		protected virtual ProcessSchemaParameter CreateCreateRemindingParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("58981c59-df61-4099-90a2-9a7c7ea42640"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("9a0f18ce-f112-4078-9025-0c8243d9bf63"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("9a0f18ce-f112-4078-9025-0c8243d9bf63"),
				Name = @"CreateReminding",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					Value = @"false",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("9a0f18ce-f112-4078-9025-0c8243d9bf63"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateCanImportContactsFromExchangeParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("783b5729-cf20-49ae-b0a6-57c22c4b618a"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("9a0f18ce-f112-4078-9025-0c8243d9bf63"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("9a0f18ce-f112-4078-9025-0c8243d9bf63"),
				Name = @"CanImportContactsFromExchange",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateCanExportContactsToExchangeParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("70f91b46-5189-4adf-9698-d9898ee2918f"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("9a0f18ce-f112-4078-9025-0c8243d9bf63"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("9a0f18ce-f112-4078-9025-0c8243d9bf63"),
				Name = @"CanExportContactsToExchange",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateNeedSetUserAddressParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("04af54a0-4e98-4fb5-963a-ab07f56ff338"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("f4dad6d8-e90c-404a-81b9-255599719041"),
				CreatedInSchemaUId = new Guid("9a0f18ce-f112-4078-9025-0c8243d9bf63"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("9a0f18ce-f112-4078-9025-0c8243d9bf63"),
				Name = @"NeedSetUserAddress",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("LocalizableStringDataValueType"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("9a0f18ce-f112-4078-9025-0c8243d9bf63"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateSyncContactsSuccessMessageParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("88cc7109-429a-4df6-b4e6-8dd40e8225c9"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("f4dad6d8-e90c-404a-81b9-255599719041"),
				CreatedInSchemaUId = new Guid("9a0f18ce-f112-4078-9025-0c8243d9bf63"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("9a0f18ce-f112-4078-9025-0c8243d9bf63"),
				Name = @"SyncContactsSuccessMessage",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("LocalizableStringDataValueType"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("9a0f18ce-f112-4078-9025-0c8243d9bf63"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateSyncContactsSuccessMessageCaptionParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("72f4667a-c301-40c7-a26e-5d67915e3c85"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("43a72267-b2f6-464f-af52-bc7506959e73"),
				CreatedInSchemaUId = new Guid("9a0f18ce-f112-4078-9025-0c8243d9bf63"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("9a0f18ce-f112-4078-9025-0c8243d9bf63"),
				Name = @"SyncContactsSuccessMessageCaption",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("LocalizableStringDataValueType"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("9a0f18ce-f112-4078-9025-0c8243d9bf63"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateSyncContactDeniedParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("0defec7e-3189-46e4-89a5-cc259329f38f"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("6ce04b71-5a25-42cb-ad4b-066c11bad2f1"),
				CreatedInSchemaUId = new Guid("9a0f18ce-f112-4078-9025-0c8243d9bf63"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("9a0f18ce-f112-4078-9025-0c8243d9bf63"),
				Name = @"SyncContactDenied",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("LocalizableStringDataValueType"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("9a0f18ce-f112-4078-9025-0c8243d9bf63"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateImportContactDeniedParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("0c6d02ed-fc54-42b7-b632-c620589e113a"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("6ce04b71-5a25-42cb-ad4b-066c11bad2f1"),
				CreatedInSchemaUId = new Guid("9a0f18ce-f112-4078-9025-0c8243d9bf63"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("9a0f18ce-f112-4078-9025-0c8243d9bf63"),
				Name = @"ImportContactDenied",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("LocalizableStringDataValueType"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("9a0f18ce-f112-4078-9025-0c8243d9bf63"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateExportContactDeniedParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("1732dfcd-210e-45f6-a830-92594051da34"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("6ce04b71-5a25-42cb-ad4b-066c11bad2f1"),
				CreatedInSchemaUId = new Guid("9a0f18ce-f112-4078-9025-0c8243d9bf63"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("9a0f18ce-f112-4078-9025-0c8243d9bf63"),
				Name = @"ExportContactDenied",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("LocalizableStringDataValueType"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("9a0f18ce-f112-4078-9025-0c8243d9bf63"),
				},
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateSenderEmailAddressParameter());
			Parameters.Add(CreateLoadResultParameter());
			Parameters.Add(CreateCreateRemindingParameter());
			Parameters.Add(CreateCanImportContactsFromExchangeParameter());
			Parameters.Add(CreateCanExportContactsToExchangeParameter());
			Parameters.Add(CreateNeedSetUserAddressParameter());
			Parameters.Add(CreateSyncContactsSuccessMessageParameter());
			Parameters.Add(CreateSyncContactsSuccessMessageCaptionParameter());
			Parameters.Add(CreateSyncContactDeniedParameter());
			Parameters.Add(CreateImportContactDeniedParameter());
			Parameters.Add(CreateExportContactDeniedParameter());
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
			ProcessSchemaScriptTask syncwithexchangecontactsscripttask = CreateSyncWithExchangeContactsScriptTaskScriptTask();
			FlowElements.Add(syncwithexchangecontactsscripttask);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("1ca893ee-fc53-4729-a96b-2986d35aa832"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("f4dad6d8-e90c-404a-81b9-255599719041"),
				CreatedInSchemaUId = new Guid("9a0f18ce-f112-4078-9025-0c8243d9bf63"),
				CurveCenterPosition = new Point(373, 203),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("9a0f18ce-f112-4078-9025-0c8243d9bf63"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("d6eee404-7e5e-431b-9556-6e636da2acb2"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("5c04c1d8-a5db-409d-9633-133572f5bf9a"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("5dd441c0-0fb4-436a-88a3-399f8d0421ca"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("f4dad6d8-e90c-404a-81b9-255599719041"),
				CreatedInSchemaUId = new Guid("9a0f18ce-f112-4078-9025-0c8243d9bf63"),
				CurveCenterPosition = new Point(373, 203),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("9a0f18ce-f112-4078-9025-0c8243d9bf63"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("5c04c1d8-a5db-409d-9633-133572f5bf9a"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("5943caea-1c98-4cee-a479-e8bd87148fc5"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("30a2fe96-a8db-4c2a-81f1-3ada1076a775"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("f4dad6d8-e90c-404a-81b9-255599719041"),
				CreatedInSchemaUId = new Guid("9a0f18ce-f112-4078-9025-0c8243d9bf63"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("9a0f18ce-f112-4078-9025-0c8243d9bf63"),
				Name = @"LaneSet1",
				Position = new Point(5, 5),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("20bf330f-b5f7-4426-bb42-a2f8dd4bcf0c"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("30a2fe96-a8db-4c2a-81f1-3ada1076a775"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("f4dad6d8-e90c-404a-81b9-255599719041"),
				CreatedInSchemaUId = new Guid("9a0f18ce-f112-4078-9025-0c8243d9bf63"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("9a0f18ce-f112-4078-9025-0c8243d9bf63"),
				Name = @"Lane1",
				Position = new Point(29, 0),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaStartEvent CreateStart1StartEvent() {
			ProcessSchemaStartEvent schemaStartEvent = new ProcessSchemaStartEvent(this) {
				UId = new Guid("d6eee404-7e5e-431b-9556-6e636da2acb2"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("20bf330f-b5f7-4426-bb42-a2f8dd4bcf0c"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("f4dad6d8-e90c-404a-81b9-255599719041"),
				CreatedInSchemaUId = new Guid("9a0f18ce-f112-4078-9025-0c8243d9bf63"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsInterrupting = false,
				IsLogging = true,
				ManagerItemUId = new Guid("53818048-7868-48f6-ada0-0ebaa65af628"),
				ModifiedInSchemaUId = new Guid("9a0f18ce-f112-4078-9025-0c8243d9bf63"),
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
				UId = new Guid("5943caea-1c98-4cee-a479-e8bd87148fc5"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("20bf330f-b5f7-4426-bb42-a2f8dd4bcf0c"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("f4dad6d8-e90c-404a-81b9-255599719041"),
				CreatedInSchemaUId = new Guid("9a0f18ce-f112-4078-9025-0c8243d9bf63"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = true,
				ManagerItemUId = new Guid("1bd93619-0574-454e-bb4e-cf53b9eb9470"),
				ModifiedInSchemaUId = new Guid("9a0f18ce-f112-4078-9025-0c8243d9bf63"),
				Name = @"Terminate1",
				Position = new Point(600, 184),
				SerializeToDB = false,
				Size = new Size(27, 27),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaTerminateEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateSyncWithExchangeContactsScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("5c04c1d8-a5db-409d-9633-133572f5bf9a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("20bf330f-b5f7-4426-bb42-a2f8dd4bcf0c"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("f4dad6d8-e90c-404a-81b9-255599719041"),
				CreatedInSchemaUId = new Guid("9a0f18ce-f112-4078-9025-0c8243d9bf63"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("9a0f18ce-f112-4078-9025-0c8243d9bf63"),
				Name = @"SyncWithExchangeContactsScriptTask",
				Position = new Point(288, 170),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,174,204,75,206,40,202,207,203,172,74,213,208,180,230,229,42,74,45,41,45,202,83,40,41,42,77,181,6,0,209,75,113,44,28,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("b44ef58f-14cf-436e-926c-a749ba553e75"),
				Name = "Terrasoft.Sync.Exchange",
				Alias = "",
				CreatedInPackageId = new Guid("f4dad6d8-e90c-404a-81b9-255599719041")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("2b77174c-a967-495f-a790-5191b16f9e7e"),
				Name = "Terrasoft.Sync",
				Alias = "",
				CreatedInPackageId = new Guid("f4dad6d8-e90c-404a-81b9-255599719041")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("8e4a5993-bda8-4c62-8675-eb4326cd459a"),
				Name = "System.Linq",
				Alias = "",
				CreatedInPackageId = new Guid("f4dad6d8-e90c-404a-81b9-255599719041")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("8cfdb105-54a9-456a-93b1-fdc30663c698"),
				Name = "System.Collections.Generic",
				Alias = "",
				CreatedInPackageId = new Guid("f4dad6d8-e90c-404a-81b9-255599719041")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("df88aa77-d3f3-411f-a4ec-eded0eb71bbf"),
				Name = "Terrasoft.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("f4dad6d8-e90c-404a-81b9-255599719041")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("c0930077-79d2-414b-99da-47efbce6a23c"),
				Name = "Terrasoft.Core.Factories",
				Alias = "",
				CreatedInPackageId = new Guid("f4dad6d8-e90c-404a-81b9-255599719041")
			});
		}

		#endregion

		#region Methods: Public

		public override Process CreateProcess(UserConnection userConnection) {
			return new SyncExchangeContactsProcess(userConnection);
		}

		public override object Clone() {
			return new SyncExchangeContactsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("9a0f18ce-f112-4078-9025-0c8243d9bf63"));
		}

		#endregion

	}

	#endregion

	#region Class: SyncExchangeContactsProcess

	/// <exclude/>
	public class SyncExchangeContactsProcess : Terrasoft.Core.Process.Process
	{

		#region Class: ProcessLane1

		/// <exclude/>
		public class ProcessLane1 : ProcessLane
		{

			public ProcessLane1(UserConnection userConnection, SyncExchangeContactsProcess process)
				: base(userConnection) {
				Owner = process;
				IsUsedParentUserContexts = false;
			}

		}

		#endregion

		public SyncExchangeContactsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SyncExchangeContactsProcess";
			SchemaUId = new Guid("9a0f18ce-f112-4078-9025-0c8243d9bf63");
			Caption = Schema.Caption;
			SchemaManagerName = "ProcessSchemaManager";
			SerializeToDB = false;
			SerializeToMemory = false;
			IsLogging = false;
			UseSystemSecurityContext = false;
			_notificationCaption = () => { return new LocalizableString((Caption)); };
			_createReminding = () => { return (bool)(false); };
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("9a0f18ce-f112-4078-9025-0c8243d9bf63");
			}
		}

		private string ConditionalExpressionLogMessage {
			get {
				return "Process: SyncExchangeContactsProcess, Source element: {0}, Conditional flow: {1}, Expression: {2}, Result: {3}";
			}
		}

		private string DeadEndGatewayLogMessage {
			get {
				return "Process: SyncExchangeContactsProcess, Source element: {0}, None of the exclusive gateway conditions are met!";
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

		public virtual string SenderEmailAddress {
			get;
			set;
		}

		public virtual string LoadResult {
			get;
			set;
		}

		private Func<bool> _createReminding;
		public virtual bool CreateReminding {
			get {
				return (_createReminding ?? (_createReminding = () => false)).Invoke();
			}
			set {
				_createReminding = () => { return value; };
			}
		}

		public virtual bool CanImportContactsFromExchange {
			get;
			set;
		}

		public virtual bool CanExportContactsToExchange {
			get;
			set;
		}

		private LocalizableString _needSetUserAddress;
		public virtual LocalizableString NeedSetUserAddress {
			get {
				return _needSetUserAddress ?? (_needSetUserAddress = GetLocalizableString("9a0f18cef112407890250c8243d9bf63",
						 "Parameters.NeedSetUserAddress.Value"));
			}
			set {
				_needSetUserAddress = value;
			}
		}

		private LocalizableString _syncContactsSuccessMessage;
		public virtual LocalizableString SyncContactsSuccessMessage {
			get {
				return _syncContactsSuccessMessage ?? (_syncContactsSuccessMessage = GetLocalizableString("9a0f18cef112407890250c8243d9bf63",
						 "Parameters.SyncContactsSuccessMessage.Value"));
			}
			set {
				_syncContactsSuccessMessage = value;
			}
		}

		private LocalizableString _syncContactsSuccessMessageCaption;
		public virtual LocalizableString SyncContactsSuccessMessageCaption {
			get {
				return _syncContactsSuccessMessageCaption ?? (_syncContactsSuccessMessageCaption = GetLocalizableString("9a0f18cef112407890250c8243d9bf63",
						 "Parameters.SyncContactsSuccessMessageCaption.Value"));
			}
			set {
				_syncContactsSuccessMessageCaption = value;
			}
		}

		private LocalizableString _syncContactDenied;
		public virtual LocalizableString SyncContactDenied {
			get {
				return _syncContactDenied ?? (_syncContactDenied = GetLocalizableString("9a0f18cef112407890250c8243d9bf63",
						 "Parameters.SyncContactDenied.Value"));
			}
			set {
				_syncContactDenied = value;
			}
		}

		private LocalizableString _importContactDenied;
		public virtual LocalizableString ImportContactDenied {
			get {
				return _importContactDenied ?? (_importContactDenied = GetLocalizableString("9a0f18cef112407890250c8243d9bf63",
						 "Parameters.ImportContactDenied.Value"));
			}
			set {
				_importContactDenied = value;
			}
		}

		private LocalizableString _exportContactDenied;
		public virtual LocalizableString ExportContactDenied {
			get {
				return _exportContactDenied ?? (_exportContactDenied = GetLocalizableString("9a0f18cef112407890250c8243d9bf63",
						 "Parameters.ExportContactDenied.Value"));
			}
			set {
				_exportContactDenied = value;
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
					SchemaElementUId = new Guid("d6eee404-7e5e-431b-9556-6e636da2acb2"),
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
					SchemaElementUId = new Guid("5943caea-1c98-4cee-a479-e8bd87148fc5"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
				});
			}
		}

		private ProcessScriptTask _syncWithExchangeContactsScriptTask;
		public ProcessScriptTask SyncWithExchangeContactsScriptTask {
			get {
				return _syncWithExchangeContactsScriptTask ?? (_syncWithExchangeContactsScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "SyncWithExchangeContactsScriptTask",
					SchemaElementUId = new Guid("5c04c1d8-a5db-409d-9633-133572f5bf9a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
					Script = SyncWithExchangeContactsScriptTaskExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[Start1.SchemaElementUId] = new Collection<ProcessFlowElement> { Start1 };
			FlowElements[Terminate1.SchemaElementUId] = new Collection<ProcessFlowElement> { Terminate1 };
			FlowElements[SyncWithExchangeContactsScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { SyncWithExchangeContactsScriptTask };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "Start1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("SyncWithExchangeContactsScriptTask", e.Context.SenderName));
						break;
					case "Terminate1":
						CompleteProcess();
						break;
					case "SyncWithExchangeContactsScriptTask":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("Terminate1", e.Context.SenderName));
						break;
			}
		}

		private void WritePropertyValues(DataWriter writer, bool useAllValueSources) {
			if (!HasMapping("SenderEmailAddress")) {
				writer.WriteValue("SenderEmailAddress", SenderEmailAddress, null);
			}
			if (!HasMapping("LoadResult")) {
				writer.WriteValue("LoadResult", LoadResult, null);
			}
			if (!HasMapping("CanImportContactsFromExchange")) {
				writer.WriteValue("CanImportContactsFromExchange", CanImportContactsFromExchange, false);
			}
			if (!HasMapping("CanExportContactsToExchange")) {
				writer.WriteValue("CanExportContactsToExchange", CanExportContactsToExchange, false);
			}
			if (!HasMapping("CreateReminding")) {
				writer.WriteValue("CreateReminding", CreateReminding, false);
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
			MetaPathParameterValues.Add("7176f340-3ddc-4681-8284-213f3d143daf", () => SenderEmailAddress);
			MetaPathParameterValues.Add("dc028f17-14b6-40df-a81d-174aaa291cfa", () => LoadResult);
			MetaPathParameterValues.Add("58981c59-df61-4099-90a2-9a7c7ea42640", () => CreateReminding);
			MetaPathParameterValues.Add("783b5729-cf20-49ae-b0a6-57c22c4b618a", () => CanImportContactsFromExchange);
			MetaPathParameterValues.Add("70f91b46-5189-4adf-9698-d9898ee2918f", () => CanExportContactsToExchange);
			MetaPathParameterValues.Add("04af54a0-4e98-4fb5-963a-ab07f56ff338", () => NeedSetUserAddress);
			MetaPathParameterValues.Add("88cc7109-429a-4df6-b4e6-8dd40e8225c9", () => SyncContactsSuccessMessage);
			MetaPathParameterValues.Add("72f4667a-c301-40c7-a26e-5d67915e3c85", () => SyncContactsSuccessMessageCaption);
			MetaPathParameterValues.Add("0defec7e-3189-46e4-89a5-cc259329f38f", () => SyncContactDenied);
			MetaPathParameterValues.Add("0c6d02ed-fc54-42b7-b632-c620589e113a", () => ImportContactDenied);
			MetaPathParameterValues.Add("1732dfcd-210e-45f6-a830-92594051da34", () => ExportContactDenied);
		}

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			bool hasValueToRead = reader.HasValue();
			switch (reader.CurrentName) {
				case "SenderEmailAddress":
					if (!hasValueToRead) break;
					SenderEmailAddress = reader.GetValue<System.String>();
				break;
				case "LoadResult":
					if (!hasValueToRead) break;
					LoadResult = reader.GetValue<System.String>();
				break;
				case "CanImportContactsFromExchange":
					if (!hasValueToRead) break;
					CanImportContactsFromExchange = reader.GetValue<System.Boolean>();
				break;
				case "CanExportContactsToExchange":
					if (!hasValueToRead) break;
					CanExportContactsToExchange = reader.GetValue<System.Boolean>();
				break;
				case "CreateReminding":
					if (!hasValueToRead) break;
					CreateReminding = reader.GetValue<System.Boolean>();
				break;
			}
		}

		protected override void WritePropertyValues(DataWriter writer) {
			base.WritePropertyValues(writer);
			WritePropertyValues(writer, true);
		}

		#endregion

		#region Methods: Public

		public virtual bool SyncWithExchangeContactsScriptTaskExecute(ProcessExecutingContext context) {
			Synchronize();
			return true;
		}

			
			public virtual void Synchronize() {
				InitializePermissionsByOperations();
				if (string.IsNullOrEmpty(SenderEmailAddress)) {
					FormatResult(NeedSetUserAddress);
					return;
				}
				var helper = new EntitySynchronizerHelper();
				helper.ClearEntitySynchronizer(UserConnection);
				string resultMessage, messageTpl;
				int localChangesCount, remoteChangesCount;
				ExchangeUtility.SyncExchangeItems(UserConnection, SenderEmailAddress, 
					() => ClassFactory.Get<BaseExchangeSyncProvider>("ExchangeContactSyncProvider",
						new ConstructorArgument("userConnection", UserConnection),
						new ConstructorArgument("senderEmailAddress", SenderEmailAddress),
						new ConstructorArgument("settings", null)),
					out resultMessage, out localChangesCount, out remoteChangesCount,
					ExchangeUtility.ContactSyncProcessName);
				if (!string.IsNullOrEmpty(resultMessage)) {
					FormatResult(resultMessage);
					return;
				}
				return;
			}
			
			
			public virtual void FormatResult(string message) {
				string resultMessage = string.Format("{{\"key\": \"{0}\", \"message\": \"{1}\"}},", 
					SenderEmailAddress, message);
				LoadResult = string.Format("{{ \"Messages\": [{0}] }}", resultMessage);
			}
			
			
			public virtual string FormatMsgBySyncAccess(string message) {
					if (!CanImportContactsFromExchange && !CanExportContactsToExchange) {
						return SyncContactDenied;
					}
					if (!CanImportContactsFromExchange) {
						return string.Format("{0} {1}", message, ImportContactDenied);
					}
					if (!CanExportContactsToExchange) {
						return string.Format("{0} {1}", message, ExportContactDenied);
					}
					return message;
			}
			
			
			public virtual void InitializePermissionsByOperations() {
				CanImportContactsFromExchange = UserConnection.DBSecurityEngine.GetCanExecuteOperation("CanImportContactsFromExchange", UserConnection.CurrentUser.Id);
				CanExportContactsToExchange = UserConnection.DBSecurityEngine.GetCanExecuteOperation("CanExportContactsToExchange", UserConnection.CurrentUser.Id);
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
			var cloneItem = (SyncExchangeContactsProcess)base.CloneShallow();
			cloneItem.ExecutedEventHandler = ExecutedEventHandler;
			return cloneItem;
		}

		#endregion

	}

	#endregion

}

