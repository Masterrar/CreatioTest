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
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;

	#region Class: RunSendEmailToCaseGroupSchema

	/// <exclude/>
	public class RunSendEmailToCaseGroupSchema : Terrasoft.Core.Process.ProcessSchema
	{

		#region Constructors: Public

		public RunSendEmailToCaseGroupSchema(ProcessSchemaManager processSchemaManager)
			: base(processSchemaManager) {
		}

		public RunSendEmailToCaseGroupSchema(RunSendEmailToCaseGroupSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "RunSendEmailToCaseGroup";
			UId = new Guid("ca99430d-23aa-4c19-8f3a-80fbd7f879ae");
			CreatedInPackageId = new Guid("7a0d600e-cd90-4098-b0b6-70054dbd4b49");
			CreatedInSchemaUId = Guid.Empty;
			CreatedInVersion = @"7.7.0.0";
			CultureName = @"en-US";
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsLogging = false;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			SerializeToDB = true;
			SerializeToMemory = true;
			Tag = @"Business process";
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
			UseForceCompile = true;
			ZipMethodsBody = new byte[] {  };
			ZipCompiledMethodsBody = new byte[] {  };
			RealUId = new Guid("ca99430d-23aa-4c19-8f3a-80fbd7f879ae");
			Version = 0;
			PackageUId = new Guid("1f513d05-8e3f-4989-92ce-3af40e5127d6");
		}

		protected virtual ProcessSchemaParameter CreateCaseRecordIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("02541d56-c300-4b56-b7b9-a795a2af3a8e"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("ca99430d-23aa-4c19-8f3a-80fbd7f879ae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ca99430d-23aa-4c19-8f3a-80fbd7f879ae"),
				Name = @"CaseRecordId",
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{3c1a583e-579d-4272-8c0c-cb74582f81f0}].[Parameter:{bcf4067c-cafc-4056-b29f-1afecb12a005}]#]  == Guid.Empty ? [#[IsOwnerSchema:false].[IsSchema:false].[Element:{5f24a920-e8d6-4e2b-ab95-9606f938e9ce}].[Parameter:{387361b5-5452-454b-89f5-1cd99a230829}]#] : [#[IsOwnerSchema:false].[IsSchema:false].[Element:{3c1a583e-579d-4272-8c0c-cb74582f81f0}].[Parameter:{bcf4067c-cafc-4056-b29f-1afecb12a005}]#]",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("ca99430d-23aa-4c19-8f3a-80fbd7f879ae"),
				},
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateCaseRecordIdParameter());
		}

		protected virtual void InitializeStartSignal1Parameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var recordIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("bcf4067c-cafc-4056-b29f-1afecb12a005"),
				ContainerUId = new Guid("3c1a583e-579d-4272-8c0c-cb74582f81f0"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("3c1a583e-579d-4272-8c0c-cb74582f81f0"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = true,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ca99430d-23aa-4c19-8f3a-80fbd7f879ae"),
				Name = @"RecordId",
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			recordIdParameter.SourceValue = new ProcessSchemaParameterValue(recordIdParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(recordIdParameter);
			var entitySchemaUIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("7cc92fc9-fece-47af-9bf1-99d8b3ec74eb"),
				ContainerUId = new Guid("3c1a583e-579d-4272-8c0c-cb74582f81f0"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("3c1a583e-579d-4272-8c0c-cb74582f81f0"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ca99430d-23aa-4c19-8f3a-80fbd7f879ae"),
				Name = @"EntitySchemaUId",
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			entitySchemaUIdParameter.SourceValue = new ProcessSchemaParameterValue(entitySchemaUIdParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"117d32f9-8275-4534-8411-1c66115ce9cd",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(entitySchemaUIdParameter);
		}

		protected virtual void InitializeStartSignal2Parameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var recordIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("387361b5-5452-454b-89f5-1cd99a230829"),
				ContainerUId = new Guid("5f24a920-e8d6-4e2b-ab95-9606f938e9ce"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("5f24a920-e8d6-4e2b-ab95-9606f938e9ce"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = true,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ca99430d-23aa-4c19-8f3a-80fbd7f879ae"),
				Name = @"RecordId",
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			recordIdParameter.SourceValue = new ProcessSchemaParameterValue(recordIdParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(recordIdParameter);
			var entitySchemaUIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("fbbbcb2e-769d-4c62-aa1b-04440ddcd118"),
				ContainerUId = new Guid("5f24a920-e8d6-4e2b-ab95-9606f938e9ce"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("5f24a920-e8d6-4e2b-ab95-9606f938e9ce"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ca99430d-23aa-4c19-8f3a-80fbd7f879ae"),
				Name = @"EntitySchemaUId",
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			entitySchemaUIdParameter.SourceValue = new ProcessSchemaParameterValue(entitySchemaUIdParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"117d32f9-8275-4534-8411-1c66115ce9cd",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(entitySchemaUIdParameter);
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet1 = CreateLaneSet1LaneSet();
			LaneSets.Add(schemaLaneSet1);
			ProcessSchemaLane schemaLane1 = CreateLane1Lane();
			schemaLaneSet1.Lanes.Add(schemaLane1);
			ProcessSchemaTerminateEvent terminate1 = CreateTerminate1TerminateEvent();
			FlowElements.Add(terminate1);
			ProcessSchemaStartSignalEvent startsignal1 = CreateStartSignal1StartSignalEvent();
			FlowElements.Add(startsignal1);
			ProcessSchemaStartSignalEvent startsignal2 = CreateStartSignal2StartSignalEvent();
			FlowElements.Add(startsignal2);
			ProcessSchemaExclusiveGateway exclusivegateway1 = CreateExclusiveGateway1ExclusiveGateway();
			FlowElements.Add(exclusivegateway1);
			ProcessSchemaScriptTask runprocess = CreateRunProcessScriptTask();
			FlowElements.Add(runprocess);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
			FlowElements.Add(CreateDefaultSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("14ab0ad1-8660-4bb3-8424-564ccb990427"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("7a0d600e-cd90-4098-b0b6-70054dbd4b49"),
				CreatedInSchemaUId = new Guid("ca99430d-23aa-4c19-8f3a-80fbd7f879ae"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("ca99430d-23aa-4c19-8f3a-80fbd7f879ae"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("3c1a583e-579d-4272-8c0c-cb74582f81f0"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("729349f8-3eae-4a71-b2b3-d27ffe76beef"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(184, 126));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3",
				UId = new Guid("bc83b551-12cb-4fba-accd-964617644676"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("7a0d600e-cd90-4098-b0b6-70054dbd4b49"),
				CreatedInSchemaUId = new Guid("ca99430d-23aa-4c19-8f3a-80fbd7f879ae"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("ca99430d-23aa-4c19-8f3a-80fbd7f879ae"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("5f24a920-e8d6-4e2b-ab95-9606f938e9ce"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("729349f8-3eae-4a71-b2b3-d27ffe76beef"),
				TargetSequenceFlowPointLocalPosition = new Point(0, -1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(184, 266));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateDefaultSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "DefaultSequenceFlow1",
				UId = new Guid("930315a5-ede8-41f0-822f-7abd90adfb85"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("7a0d600e-cd90-4098-b0b6-70054dbd4b49"),
				CreatedInSchemaUId = new Guid("ca99430d-23aa-4c19-8f3a-80fbd7f879ae"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("ca99430d-23aa-4c19-8f3a-80fbd7f879ae"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("729349f8-3eae-4a71-b2b3-d27ffe76beef"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("6b467a14-3688-4459-af56-2285cc0165d9"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("f937c722-64ff-4561-ab8b-c5f114957735"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("7a0d600e-cd90-4098-b0b6-70054dbd4b49"),
				CreatedInSchemaUId = new Guid("ca99430d-23aa-4c19-8f3a-80fbd7f879ae"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("ca99430d-23aa-4c19-8f3a-80fbd7f879ae"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("6b467a14-3688-4459-af56-2285cc0165d9"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("2d3139b5-6a1a-4db2-acb1-ecb5cfa443cb"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("8c91975d-2cb4-4229-8b2b-8c71b0e9324c"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("7a0d600e-cd90-4098-b0b6-70054dbd4b49"),
				CreatedInSchemaUId = new Guid("ca99430d-23aa-4c19-8f3a-80fbd7f879ae"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("ca99430d-23aa-4c19-8f3a-80fbd7f879ae"),
				Name = @"LaneSet1",
				Position = new Point(0, 0),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("db57a53e-48a6-4c67-873b-dbda1884c1fa"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("8c91975d-2cb4-4229-8b2b-8c71b0e9324c"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("7a0d600e-cd90-4098-b0b6-70054dbd4b49"),
				CreatedInSchemaUId = new Guid("ca99430d-23aa-4c19-8f3a-80fbd7f879ae"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("ca99430d-23aa-4c19-8f3a-80fbd7f879ae"),
				Name = @"Lane1",
				Position = new Point(0, 0),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaTerminateEvent CreateTerminate1TerminateEvent() {
			ProcessSchemaTerminateEvent schemaTerminateEvent = new ProcessSchemaTerminateEvent(this) {
				UId = new Guid("2d3139b5-6a1a-4db2-acb1-ecb5cfa443cb"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("db57a53e-48a6-4c67-873b-dbda1884c1fa"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("7a0d600e-cd90-4098-b0b6-70054dbd4b49"),
				CreatedInSchemaUId = new Guid("ca99430d-23aa-4c19-8f3a-80fbd7f879ae"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = true,
				ManagerItemUId = new Guid("1bd93619-0574-454e-bb4e-cf53b9eb9470"),
				ModifiedInSchemaUId = new Guid("ca99430d-23aa-4c19-8f3a-80fbd7f879ae"),
				Name = @"Terminate1",
				Position = new Point(438, 180),
				SerializeToDB = false,
				Size = new Size(27, 27),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaTerminateEvent;
		}

		protected virtual ProcessSchemaStartSignalEvent CreateStartSignal1StartSignalEvent() {
			ProcessSchemaStartSignalEvent schemaStartSignalEvent = new ProcessSchemaStartSignalEvent(this) {	UId = new Guid("3c1a583e-579d-4272-8c0c-cb74582f81f0"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("db57a53e-48a6-4c67-873b-dbda1884c1fa"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("7a0d600e-cd90-4098-b0b6-70054dbd4b49"),
				CreatedInSchemaUId = new Guid("ca99430d-23aa-4c19-8f3a-80fbd7f879ae"),
				DragGroupName = @"Event",
				EntitySchemaUId = new Guid("117d32f9-8275-4534-8411-1c66115ce9cd"),
				EntitySignal = EntityChangeType.Inserted,
				HasEntityColumnChange = false,
				HasEntityFilters = true,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = true,
				ManagerItemUId = new Guid("1129e72f-0e8c-445a-b2ea-463517e86395"),
				ModifiedInSchemaUId = new Guid("ca99430d-23aa-4c19-8f3a-80fbd7f879ae"),
				Name = @"StartSignal1",
				NewEntityChangedColumns = false,
				Position = new Point(77, 113),
				SerializeToDB = false,
				Size = new Size(27, 27),
				UseBackgroundMode = false,
				WaitingEntitySignal = true,
				WaitingRandomSignal = false
			};
			InitializeStartSignal1Parameters(schemaStartSignalEvent);
			return schemaStartSignalEvent;
		}

		protected virtual ProcessSchemaStartSignalEvent CreateStartSignal2StartSignalEvent() {
			ProcessSchemaStartSignalEvent schemaStartSignalEvent = new ProcessSchemaStartSignalEvent(this) {	UId = new Guid("5f24a920-e8d6-4e2b-ab95-9606f938e9ce"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("db57a53e-48a6-4c67-873b-dbda1884c1fa"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("7a0d600e-cd90-4098-b0b6-70054dbd4b49"),
				CreatedInSchemaUId = new Guid("ca99430d-23aa-4c19-8f3a-80fbd7f879ae"),
				DragGroupName = @"Event",
				EntitySchemaUId = new Guid("117d32f9-8275-4534-8411-1c66115ce9cd"),
				EntitySignal = EntityChangeType.Updated,
				HasEntityColumnChange = true,
				HasEntityFilters = true,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = true,
				ManagerItemUId = new Guid("1129e72f-0e8c-445a-b2ea-463517e86395"),
				ModifiedInSchemaUId = new Guid("ca99430d-23aa-4c19-8f3a-80fbd7f879ae"),
				Name = @"StartSignal2",
				NewEntityChangedColumns = false,
				Position = new Point(77, 253),
				SerializeToDB = false,
				Size = new Size(27, 27),
				UseBackgroundMode = false,
				WaitingEntitySignal = true,
				WaitingRandomSignal = false
			};
			schemaStartSignalEvent.EntityChangedColumns.Add("70620d00-e4ea-48d1-9fdc-4572fcd8d41b");
			schemaStartSignalEvent.EntityChangedColumns.Add("9147230c-ab53-4eb4-b0b4-ac78be6f8326");
			InitializeStartSignal2Parameters(schemaStartSignalEvent);
			return schemaStartSignalEvent;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGateway1ExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("729349f8-3eae-4a71-b2b3-d27ffe76beef"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("db57a53e-48a6-4c67-873b-dbda1884c1fa"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("7a0d600e-cd90-4098-b0b6-70054dbd4b49"),
				CreatedInSchemaUId = new Guid("ca99430d-23aa-4c19-8f3a-80fbd7f879ae"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = true,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("ca99430d-23aa-4c19-8f3a-80fbd7f879ae"),
				Name = @"ExclusiveGateway1",
				Position = new Point(157, 166),
				SerializeToDB = false,
				Size = new Size(55, 55),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaScriptTask CreateRunProcessScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("6b467a14-3688-4459-af56-2285cc0165d9"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("db57a53e-48a6-4c67-873b-dbda1884c1fa"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("7a0d600e-cd90-4098-b0b6-70054dbd4b49"),
				CreatedInSchemaUId = new Guid("ca99430d-23aa-4c19-8f3a-80fbd7f879ae"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("ca99430d-23aa-4c19-8f3a-80fbd7f879ae"),
				Name = @"RunProcess",
				Position = new Point(280, 166),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,165,86,93,111,219,54,20,125,78,128,252,7,213,79,50,224,8,89,230,21,70,179,100,112,20,57,243,208,116,89,228,180,15,195,30,56,233,198,33,64,145,42,69,181,53,214,252,247,93,126,72,162,100,37,104,209,0,177,45,146,247,220,115,207,253,160,238,43,144,177,224,28,50,69,5,15,234,254,227,121,112,223,91,56,59,58,164,15,65,216,63,21,197,181,148,192,149,62,26,117,203,155,93,9,193,185,69,208,191,163,52,189,157,6,255,29,29,30,236,57,25,224,45,203,210,123,74,119,149,130,98,143,199,211,209,225,39,34,131,10,120,14,50,41,8,101,8,180,1,41,73,37,30,20,242,144,160,201,60,208,109,45,73,3,148,130,82,148,111,171,232,26,212,123,194,106,248,181,82,18,23,46,6,33,205,2,164,57,73,235,178,20,82,165,32,63,209,12,140,143,201,44,176,22,81,82,148,106,55,29,23,4,209,215,213,10,136,170,37,36,156,252,203,32,15,39,198,254,6,170,138,108,225,166,102,138,190,37,124,91,227,195,100,26,124,253,58,212,224,251,32,222,159,78,166,86,91,173,73,70,42,184,131,76,200,124,157,163,40,97,170,8,70,65,183,156,176,159,162,118,227,213,121,112,93,211,220,5,130,166,7,191,5,227,39,245,222,27,127,239,180,221,59,115,46,161,250,136,158,56,124,14,18,174,168,218,165,217,35,20,228,175,26,228,110,40,142,127,224,134,112,100,47,103,193,36,70,206,19,45,231,1,66,69,203,60,143,5,171,11,30,78,174,165,168,75,187,211,196,102,17,208,159,62,138,66,217,231,189,20,250,50,24,123,157,41,207,30,5,224,53,99,86,55,3,78,242,130,242,123,78,85,242,163,225,96,173,45,27,48,75,222,202,164,19,104,35,123,71,10,108,143,158,75,63,108,244,160,72,166,34,91,117,211,72,31,111,97,182,90,19,147,219,46,28,45,132,110,51,135,96,171,91,39,248,194,105,184,206,29,145,158,203,21,101,10,100,165,93,135,189,141,88,98,241,129,221,254,64,213,227,45,145,72,65,159,13,237,98,44,138,146,72,90,217,78,143,146,143,53,97,24,249,223,24,186,110,214,53,191,19,12,222,184,167,127,116,247,233,5,108,32,199,126,218,201,146,9,198,218,97,208,99,209,102,55,110,143,12,18,208,161,72,168,176,39,16,193,117,232,31,130,162,144,103,232,177,195,143,82,208,191,66,148,254,34,128,81,205,154,137,48,200,213,212,241,213,69,244,202,121,88,87,239,176,128,254,148,31,30,169,130,180,36,25,132,150,132,107,70,47,233,27,40,74,134,130,166,102,94,185,226,242,199,149,63,169,76,210,181,232,55,36,147,162,114,101,53,26,248,190,7,83,23,207,33,235,54,195,149,74,225,8,212,105,232,140,44,218,15,15,179,110,18,225,223,72,228,145,254,50,214,43,41,138,141,8,253,46,157,13,35,153,249,243,125,230,50,236,2,63,144,128,148,120,160,100,109,59,227,224,41,0,86,65,227,124,95,122,133,119,194,183,40,223,51,24,87,125,31,189,17,224,119,96,229,183,37,120,220,114,32,200,243,222,153,51,51,249,126,129,138,78,224,219,246,108,56,80,216,71,84,110,181,155,175,123,106,152,142,113,11,67,168,153,71,169,129,253,254,10,232,147,136,110,37,45,136,220,121,13,250,82,77,60,233,79,253,129,255,94,53,232,49,104,172,172,238,66,119,129,41,127,151,38,189,143,35,247,245,98,245,203,114,158,28,47,175,78,94,31,207,227,197,207,199,139,69,60,63,62,153,159,92,157,206,23,39,171,101,124,217,93,68,133,109,202,253,183,151,91,41,50,108,140,222,141,208,24,149,254,30,154,58,16,211,99,216,148,132,103,112,185,187,199,44,141,145,109,239,176,49,15,26,34,38,28,103,237,138,137,207,9,223,82,62,44,221,89,223,253,212,187,248,30,90,27,167,200,179,32,86,232,43,106,30,48,49,110,92,54,175,69,23,65,217,220,19,14,233,249,163,161,197,106,13,204,29,100,94,4,154,106,192,209,237,63,70,27,145,26,211,208,205,226,142,118,116,87,115,39,75,216,139,114,214,17,50,54,254,140,48,105,20,121,205,192,153,34,229,158,177,187,4,27,224,49,37,116,62,250,54,221,69,25,37,95,40,78,218,203,157,190,63,6,145,181,67,178,71,0,123,67,225,79,236,90,181,51,197,254,162,30,150,129,169,249,62,74,242,5,178,90,141,166,238,201,188,57,251,163,243,127,220,183,76,239,2,12,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("09015002-8c72-44a0-87aa-300725e2353a"),
				Name = "Terrasoft.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("7a0d600e-cd90-4098-b0b6-70054dbd4b49")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("4bc22559-3627-4ea2-9aee-a2721c12aafa"),
				Name = "System.Text",
				Alias = "",
				CreatedInPackageId = new Guid("7a0d600e-cd90-4098-b0b6-70054dbd4b49")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("60d0ddb8-902b-457f-9428-6aa42c5240aa"),
				Name = "System",
				Alias = "",
				CreatedInPackageId = new Guid("7a0d600e-cd90-4098-b0b6-70054dbd4b49")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7abde226-b990-4e5b-9337-0c55786d6c6f"),
				Name = "System.Linq",
				Alias = "",
				CreatedInPackageId = new Guid("7a0d600e-cd90-4098-b0b6-70054dbd4b49")
			});
		}

		#endregion

		#region Methods: Public

		public override Process CreateProcess(UserConnection userConnection) {
			return new RunSendEmailToCaseGroup(userConnection);
		}

		public override object Clone() {
			return new RunSendEmailToCaseGroupSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ca99430d-23aa-4c19-8f3a-80fbd7f879ae"));
		}

		#endregion

	}

	#endregion

	#region Class: RunSendEmailToCaseGroup

	/// <exclude/>
	public class RunSendEmailToCaseGroup : Terrasoft.Core.Process.Process
	{

		#region Class: ProcessLane1

		/// <exclude/>
		public class ProcessLane1 : ProcessLane
		{

			public ProcessLane1(UserConnection userConnection, RunSendEmailToCaseGroup process)
				: base(userConnection) {
				Owner = process;
				IsUsedParentUserContexts = false;
			}

		}

		#endregion

		public RunSendEmailToCaseGroup(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "RunSendEmailToCaseGroup";
			SchemaUId = new Guid("ca99430d-23aa-4c19-8f3a-80fbd7f879ae");
			Caption = Schema.Caption;
			SchemaManagerName = "ProcessSchemaManager";
			SerializeToDB = true;
			SerializeToMemory = true;
			IsLogging = false;
			_notificationCaption = () => { return new LocalizableString((Caption)); };
			_caseRecordId = () => { return (Guid)((StartSignal1.RecordId)  == Guid.Empty ? (StartSignal2.RecordId) : (StartSignal1.RecordId)); };
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("ca99430d-23aa-4c19-8f3a-80fbd7f879ae");
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

		private Func<Guid> _caseRecordId;
		public virtual Guid CaseRecordId {
			get {
				return (_caseRecordId ?? (_caseRecordId = () => Guid.Empty)).Invoke();
			}
			set {
				_caseRecordId = () => { return value; };
			}
		}

		private ProcessLane1 _lane1;
		public ProcessLane1 Lane1 {
			get {
				return _lane1 ?? ((_lane1) = new ProcessLane1(UserConnection, this));
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
					SchemaElementUId = new Guid("2d3139b5-6a1a-4db2-acb1-ecb5cfa443cb"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
				});
			}
		}

		private ProcessStartSignalEvent _startSignal1;
		public ProcessStartSignalEvent StartSignal1 {
			get {
				return _startSignal1 ?? (_startSignal1 = new ProcessStartSignalEvent(UserConnection) {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartSignalEvent",
					Name = "StartSignal1",
					SerializeToDB = false,
					IsLogging = true,
					SchemaElementUId = new Guid("3c1a583e-579d-4272-8c0c-cb74582f81f0"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessStartSignalEvent _startSignal2;
		public ProcessStartSignalEvent StartSignal2 {
			get {
				return _startSignal2 ?? (_startSignal2 = new ProcessStartSignalEvent(UserConnection) {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartSignalEvent",
					Name = "StartSignal2",
					SerializeToDB = false,
					IsLogging = true,
					SchemaElementUId = new Guid("5f24a920-e8d6-4e2b-ab95-9606f938e9ce"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
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
					SchemaElementUId = new Guid("729349f8-3eae-4a71-b2b3-d27ffe76beef"),
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

		private ProcessScriptTask _runProcess;
		public ProcessScriptTask RunProcess {
			get {
				return _runProcess ?? (_runProcess = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "RunProcess",
					SchemaElementUId = new Guid("6b467a14-3688-4459-af56-2285cc0165d9"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
					Script = RunProcessExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[Terminate1.SchemaElementUId] = new Collection<ProcessFlowElement> { Terminate1 };
			FlowElements[StartSignal1.SchemaElementUId] = new Collection<ProcessFlowElement> { StartSignal1 };
			FlowElements[StartSignal2.SchemaElementUId] = new Collection<ProcessFlowElement> { StartSignal2 };
			FlowElements[ExclusiveGateway1.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway1 };
			FlowElements[RunProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { RunProcess };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "Terminate1":
						CompleteProcess();
						break;
					case "StartSignal1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ExclusiveGateway1", e.Context.SenderName));
						break;
					case "StartSignal2":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ExclusiveGateway1", e.Context.SenderName));
						break;
					case "ExclusiveGateway1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("RunProcess", e.Context.SenderName));
						break;
					case "RunProcess":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("Terminate1", e.Context.SenderName));
						break;
			}
		}

		private void WritePropertyValues(DataWriter writer, bool useAllValueSources) {
			if (!HasMapping("CaseRecordId")) {
				writer.WriteValue("CaseRecordId", CaseRecordId, Guid.Empty);
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
			MetaPathParameterValues.Add("02541d56-c300-4b56-b7b9-a795a2af3a8e", () => CaseRecordId);
			MetaPathParameterValues.Add("bcf4067c-cafc-4056-b29f-1afecb12a005", () => StartSignal1.RecordId);
			MetaPathParameterValues.Add("7cc92fc9-fece-47af-9bf1-99d8b3ec74eb", () => StartSignal1.EntitySchemaUId);
			MetaPathParameterValues.Add("387361b5-5452-454b-89f5-1cd99a230829", () => StartSignal2.RecordId);
			MetaPathParameterValues.Add("fbbbcb2e-769d-4c62-aa1b-04440ddcd118", () => StartSignal2.EntitySchemaUId);
		}

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			bool hasValueToRead = reader.HasValue();
			switch (reader.CurrentName) {
				case "CaseRecordId":
					if (!hasValueToRead) break;
					CaseRecordId = reader.GetValue<System.Guid>();
				break;
			}
		}

		protected override void WritePropertyValues(DataWriter writer) {
			base.WritePropertyValues(writer);
			WritePropertyValues(writer, true);
		}

		#endregion

		#region Methods: Public

		public virtual bool RunProcessExecute(ProcessExecutingContext context) {
			UserConnection userConnection = UserConnection;
			if (userConnection.CurrentUser.ConnectionType == UserType.SSP) {
				userConnection = userConnection.AppConnection.SystemUserConnection;
			}
			var senderEmail = Terrasoft.Core.Configuration.SysSettings.GetValue<string>(userConnection, 
				"SupportServiceEmail", string.Empty);
			if (userConnection.GetIsFeatureEnabled("EmailMessageMultiLanguage") || userConnection.GetIsFeatureEnabled("EmailMessageMultiLanguageV2")) {
				var caseRecordId = (StartSignal1.RecordId != Guid.Empty)
					? StartSignal1.RecordId 
					: StartSignal2.RecordId;
				var esq = new EntitySchemaQuery(userConnection.EntitySchemaManager, "Case");
				esq.AddColumn("Group");
				var caseEntity = esq.GetEntity(userConnection, caseRecordId);
				if (caseEntity != null) {
					var adminUnitEsq = new EntitySchemaQuery(userConnection.EntitySchemaManager, "SysAdminUnit");
					var emailColumnName = adminUnitEsq.AddColumn("Contact.Email").Name;
					var groupId = caseEntity.GetTypedColumnValue<Guid>("GroupId");
					adminUnitEsq.Filters.Add(adminUnitEsq.CreateFilterWithParameters(FilterComparisonType.Equal, "[SysUserInRole:SysUser].SysRole", groupId));
					var collection = adminUnitEsq.GetEntityCollection(userConnection);
					var result = string.Join(";", collection.Select(e => e.GetTypedColumnValue<string>(emailColumnName)));
					if (!string.IsNullOrWhiteSpace(result)) {
						var emailTemplateSender = new Terrasoft.Configuration.EmailWithMacrosManager(userConnection);
						var emailTemplateId = Terrasoft.Configuration.CaseConsts.GroupTemplateId;
						if (userConnection.GetIsFeatureEnabled("EmailMessageMultiLanguageV2")) {
							emailTemplateSender.SendEmailFromTo(caseRecordId, emailTemplateId, senderEmail, result);
							return true;
						} else {
							var emailTemplateStore = new Terrasoft.Configuration.EmailTemplateStore(userConnection);
							var emailTemplateLanguageHelper = new Terrasoft.Configuration.EmailTemplateLanguageHelper(caseRecordId, userConnection);
							var languageId = emailTemplateLanguageHelper.GetLanguageId(emailTemplateId);
							var templateEntity = emailTemplateStore.GetTemplate(emailTemplateId, languageId);
							emailTemplateSender.SendEmailFromTo(caseRecordId, templateEntity.PrimaryColumnValue, senderEmail, result);
						}
					}
				}
			} else {
				Guid sendEmailToCaseGroup = new Guid("C68F5A4E-AD06-4C83-88C4-040D2480FACB");
				var manager = userConnection.ProcessSchemaManager;
				var processSchema = manager.GetInstanceByUId(sendEmailToCaseGroup);
				if (ProcessSchemaManager.GetCanUseFlowEngine(userConnection, processSchema)) {
					var flowEngine = new FlowEngine(userConnection);
					Dictionary<string, string> parameter = new Dictionary<string, string>();
					parameter.Add("CaseRecordId", CaseRecordId.ToString());
					flowEngine.RunProcess(processSchema, parameter);
				} else {
					var moduleProcess = processSchema.CreateProcess(userConnection);
					if (processSchema.Parameters.ExistsByName("CaseRecordId")) {
						moduleProcess.SetPropertyValue("CaseRecordId", CaseRecordId);
					}
					moduleProcess.Execute(userConnection);
				}
			}
			return true;
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
			var cloneItem = (RunSendEmailToCaseGroup)base.CloneShallow();
			cloneItem.ExecutedEventHandler = ExecutedEventHandler;
			return cloneItem;
		}

		#endregion

	}

	#endregion

}

