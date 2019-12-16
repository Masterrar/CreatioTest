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
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;

	#region Class: ObjectRecordRightsActualizationProcessSchema

	/// <exclude/>
	public class ObjectRecordRightsActualizationProcessSchema : Terrasoft.Core.Process.ProcessSchema
	{

		#region Constructors: Public

		public ObjectRecordRightsActualizationProcessSchema(ProcessSchemaManager processSchemaManager)
			: base(processSchemaManager) {
		}

		public ObjectRecordRightsActualizationProcessSchema(ObjectRecordRightsActualizationProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "ObjectRecordRightsActualizationProcess";
			UId = new Guid("c949331e-753b-48bb-88a9-9e89d8c8a301");
			CreatedInPackageId = new Guid("a5664658-26d5-4600-862a-86467fd59244");
			CreatedInSchemaUId = Guid.Empty;
			CreatedInVersion = @"0.0.0.0";
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			SerializeToDB = true;
			SerializeToMemory = true;
			Tag = @"Business Process";
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
			UseSystemSecurityContext = true;
			ZipMethodsBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,145,221,106,132,64,12,133,175,91,232,59,12,94,41,136,47,208,31,232,46,219,101,47,250,131,226,3,100,103,130,166,232,76,201,68,193,150,190,123,99,87,164,75,247,106,32,201,57,95,78,230,99,56,118,100,205,72,44,3,116,102,12,228,76,133,222,149,216,147,119,228,155,52,10,235,99,122,140,17,26,204,204,215,205,245,213,8,108,208,11,201,84,217,22,123,120,6,175,61,54,247,70,90,138,197,30,229,174,142,200,219,224,61,90,161,224,31,210,228,188,144,100,197,238,191,193,237,226,13,78,233,164,100,16,116,175,199,119,213,168,247,5,226,140,58,248,40,224,45,110,166,250,224,210,117,129,253,64,78,177,127,41,218,79,178,108,134,44,105,212,244,20,175,120,10,220,131,164,75,61,191,180,65,241,2,61,254,170,215,227,84,200,35,114,45,212,145,16,198,98,203,168,243,107,123,51,189,113,176,106,153,158,135,207,77,114,178,44,209,6,118,37,53,173,196,71,59,255,0,125,194,60,177,232,146,124,189,187,114,191,127,0,194,152,205,226,173,1,0,0 };
			ZipCompiledMethodsBody = new byte[] {  };
			RealUId = new Guid("c949331e-753b-48bb-88a9-9e89d8c8a301");
			Version = 0;
			PackageUId = new Guid("5be3998b-c5c3-42bb-a01c-2e4149059a97");
			UseSystemSecurityContext = true;
		}

		protected virtual ProcessSchemaParameter CreateEntitySchemaUIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("a5251af1-5a5f-4a1a-b2df-fa3127bd8a6d"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("c949331e-753b-48bb-88a9-9e89d8c8a301"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("c949331e-753b-48bb-88a9-9e89d8c8a301"),
				Name = @"EntitySchemaUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateChunkSizeParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("3a99f3cf-49f7-4bb2-8733-3f5ae25c02a6"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("c949331e-753b-48bb-88a9-9e89d8c8a301"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("c949331e-753b-48bb-88a9-9e89d8c8a301"),
				Name = @"ChunkSize",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					Value = @"500",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("c949331e-753b-48bb-88a9-9e89d8c8a301"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateChunkProcessingDelayParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("63f8392a-72cc-4846-a89e-83ae75644a3c"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("c949331e-753b-48bb-88a9-9e89d8c8a301"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("c949331e-753b-48bb-88a9-9e89d8c8a301"),
				Name = @"ChunkProcessingDelay",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					Value = @"500",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("c949331e-753b-48bb-88a9-9e89d8c8a301"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateMaxDegreeOfParallelismParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("9975462c-580e-4b2b-93b8-5e7bd11a190c"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("c949331e-753b-48bb-88a9-9e89d8c8a301"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("c949331e-753b-48bb-88a9-9e89d8c8a301"),
				Name = @"MaxDegreeOfParallelism",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					Value = @"2",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("c949331e-753b-48bb-88a9-9e89d8c8a301"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateActualizationSuccessMessageParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("a9fa7b5b-d4bb-4388-a77e-49064d132625"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("c949331e-753b-48bb-88a9-9e89d8c8a301"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("c949331e-753b-48bb-88a9-9e89d8c8a301"),
				Name = @"ActualizationSuccessMessage",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("LongText"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("c949331e-753b-48bb-88a9-9e89d8c8a301"),
				},
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateEntitySchemaUIdParameter());
			Parameters.Add(CreateChunkSizeParameter());
			Parameters.Add(CreateChunkProcessingDelayParameter());
			Parameters.Add(CreateMaxDegreeOfParallelismParameter());
			Parameters.Add(CreateActualizationSuccessMessageParameter());
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet1 = CreateLaneSet1LaneSet();
			LaneSets.Add(schemaLaneSet1);
			ProcessSchemaLane schemaLane1 = CreateLane1Lane();
			schemaLaneSet1.Lanes.Add(schemaLane1);
			ProcessSchemaStartEvent startevent1 = CreateStartEvent1StartEvent();
			FlowElements.Add(startevent1);
			ProcessSchemaTerminateEvent terminator = CreateTerminatorTerminateEvent();
			FlowElements.Add(terminator);
			ProcessSchemaScriptTask actualizationexecutionscripttask = CreateActualizationExecutionScriptTaskScriptTask();
			FlowElements.Add(actualizationexecutionscripttask);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("bf247216-8908-4312-80d9-ccfc78d89f9c"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("be6f6b49-189f-4148-bff8-2c8c58642b76"),
				CreatedInSchemaUId = new Guid("c949331e-753b-48bb-88a9-9e89d8c8a301"),
				CurveCenterPosition = new Point(0, 0),
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("c949331e-753b-48bb-88a9-9e89d8c8a301"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("c7a5f5a7-e453-44de-91ea-22c336bb64a1"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("dfc394f8-650b-4d0a-a8cf-51caf2020168"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("da8527a2-5a1a-424e-9051-2e16259681f7"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("be6f6b49-189f-4148-bff8-2c8c58642b76"),
				CreatedInSchemaUId = new Guid("c949331e-753b-48bb-88a9-9e89d8c8a301"),
				CurveCenterPosition = new Point(0, 0),
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("c949331e-753b-48bb-88a9-9e89d8c8a301"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("dfc394f8-650b-4d0a-a8cf-51caf2020168"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("88ba5837-c741-4192-be87-98750b79328e"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("f4d04a01-c7d4-4bdd-a1c6-e8b41cb0d318"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("be6f6b49-189f-4148-bff8-2c8c58642b76"),
				CreatedInSchemaUId = new Guid("c949331e-753b-48bb-88a9-9e89d8c8a301"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("c949331e-753b-48bb-88a9-9e89d8c8a301"),
				Name = @"LaneSet1",
				Position = new Point(0, 0),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("c6e7cba3-06af-4f9e-ad67-421c556de0e7"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f4d04a01-c7d4-4bdd-a1c6-e8b41cb0d318"),
				CreatedInOwnerSchemaUId = new Guid("c949331e-753b-48bb-88a9-9e89d8c8a301"),
				CreatedInPackageId = new Guid("be6f6b49-189f-4148-bff8-2c8c58642b76"),
				CreatedInSchemaUId = new Guid("c949331e-753b-48bb-88a9-9e89d8c8a301"),
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("c949331e-753b-48bb-88a9-9e89d8c8a301"),
				Name = @"Lane1",
				Position = new Point(0, 0),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaStartEvent CreateStartEvent1StartEvent() {
			ProcessSchemaStartEvent schemaStartEvent = new ProcessSchemaStartEvent(this) {
				UId = new Guid("c7a5f5a7-e453-44de-91ea-22c336bb64a1"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c6e7cba3-06af-4f9e-ad67-421c556de0e7"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("be6f6b49-189f-4148-bff8-2c8c58642b76"),
				CreatedInSchemaUId = new Guid("c949331e-753b-48bb-88a9-9e89d8c8a301"),
				EntitySchemaUId = Guid.Empty,
				IsInterrupting = false,
				IsLogging = true,
				ManagerItemUId = new Guid("53818048-7868-48f6-ada0-0ebaa65af628"),
				ModifiedInSchemaUId = new Guid("c949331e-753b-48bb-88a9-9e89d8c8a301"),
				Name = @"StartEvent1",
				Position = new Point(50, 184),
				SerializeToDB = false,
				Size = new Size(27, 27),
				UseBackgroundMode = true
			};
			
			return schemaStartEvent;
		}

		protected virtual ProcessSchemaTerminateEvent CreateTerminatorTerminateEvent() {
			ProcessSchemaTerminateEvent schemaTerminateEvent = new ProcessSchemaTerminateEvent(this) {
				UId = new Guid("88ba5837-c741-4192-be87-98750b79328e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c6e7cba3-06af-4f9e-ad67-421c556de0e7"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("be6f6b49-189f-4148-bff8-2c8c58642b76"),
				CreatedInSchemaUId = new Guid("c949331e-753b-48bb-88a9-9e89d8c8a301"),
				EntitySchemaUId = Guid.Empty,
				IsLogging = true,
				ManagerItemUId = new Guid("1bd93619-0574-454e-bb4e-cf53b9eb9470"),
				ModifiedInSchemaUId = new Guid("c949331e-753b-48bb-88a9-9e89d8c8a301"),
				Name = @"Terminator",
				Position = new Point(600, 184),
				SerializeToDB = false,
				Size = new Size(27, 27),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaTerminateEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateActualizationExecutionScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("dfc394f8-650b-4d0a-a8cf-51caf2020168"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c6e7cba3-06af-4f9e-ad67-421c556de0e7"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("be6f6b49-189f-4148-bff8-2c8c58642b76"),
				CreatedInSchemaUId = new Guid("c949331e-753b-48bb-88a9-9e89d8c8a301"),
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("c949331e-753b-48bb-88a9-9e89d8c8a301"),
				Name = @"ActualizationExecutionScriptTask",
				Position = new Point(304, 170),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = true,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,82,203,110,131,48,16,60,195,87,88,156,204,133,31,160,141,84,229,165,28,210,68,161,81,207,174,217,128,91,99,82,219,164,161,21,255,222,53,36,36,161,233,1,9,219,51,179,179,179,123,96,154,128,178,194,214,9,207,161,96,219,69,74,30,137,205,133,137,230,96,31,230,149,72,71,52,152,222,34,130,48,246,15,72,100,220,86,76,138,111,208,200,81,240,69,86,111,239,192,237,6,120,169,211,141,200,114,107,158,122,8,237,69,183,6,244,184,84,10,161,162,84,40,127,123,17,132,40,127,145,142,198,121,165,62,18,252,189,54,38,148,69,98,255,20,220,161,172,117,201,193,24,161,178,9,72,86,255,195,30,160,6,66,75,118,156,64,166,1,86,187,53,211,76,74,144,194,20,127,165,238,227,156,152,216,17,58,8,56,154,126,162,190,161,152,141,56,224,3,182,110,172,137,206,199,65,216,97,72,126,124,239,20,119,11,72,64,98,82,51,33,109,31,124,119,69,111,131,12,163,113,41,171,66,209,192,141,44,154,233,178,160,193,185,74,16,250,158,23,189,230,160,129,6,47,245,30,90,204,194,60,151,182,181,71,59,110,228,218,41,0,43,13,237,78,11,38,164,35,118,30,153,57,153,136,125,239,42,192,174,153,110,35,22,233,192,249,189,134,98,207,111,124,171,107,215,244,149,78,191,71,195,48,49,226,134,112,102,121,78,232,244,200,97,239,58,39,224,66,107,200,78,40,156,69,171,149,128,74,55,80,8,149,226,168,47,187,104,172,198,243,168,205,165,45,192,28,63,169,184,91,138,37,126,44,131,118,33,27,95,131,173,180,34,86,87,16,255,2,67,75,150,172,55,3,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("bb926b70-8e92-4f36-94ed-dfe5dc28b2d5"),
				Name = "Terrasoft.Core",
				Alias = "",
				CreatedInPackageId = new Guid("a5664658-26d5-4600-862a-86467fd59244")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("896b9851-e42c-45a9-b833-b6ce2cb9410a"),
				Name = "Terrasoft.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("a5664658-26d5-4600-862a-86467fd59244")
			});
		}

		#endregion

		#region Methods: Public

		public override Process CreateProcess(UserConnection userConnection) {
			return new ObjectRecordRightsActualizationProcess(userConnection);
		}

		public override object Clone() {
			return new ObjectRecordRightsActualizationProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c949331e-753b-48bb-88a9-9e89d8c8a301"));
		}

		#endregion

	}

	#endregion

	#region Class: ObjectRecordRightsActualizationProcessMethodsWrapper

	/// <exclude/>
	public class ObjectRecordRightsActualizationProcessMethodsWrapper : ProcessModel
	{

		public ObjectRecordRightsActualizationProcessMethodsWrapper(Process process)
			: base(process) {
			AddScriptTaskMethod("ActualizationExecutionScriptTaskExecute", ActualizationExecutionScriptTaskExecute);
		}

		#region Methods: Private

		private bool ActualizationExecutionScriptTaskExecute(ProcessExecutingContext context) {
			var entitySchemaUId = this.Get<Guid>("EntitySchemaUId");
			var actualizer = new ObjectRecordRightsActualizer(this.Get<UserConnection>("UserConnection"));
			actualizer.ChunkSize = this.Get<int>("ChunkSize");
			actualizer.ChunkProcessingDelay = this.Get<int>("ChunkProcessingDelay");
			actualizer.MaxDegreeOfParallelism = this.Get<int>("MaxDegreeOfParallelism");
			if (entitySchemaUId.Equals(ActivityConsts.ActivityEntitySchemaUId)) {
				var activitySelectFilter = new Select(UserConnection).Column("Id").From("Activity")
					.Where("TypeId").IsNotEqual(Column.Parameter(ActivityConsts.EmailTypeUId)) as Select;
				actualizer.EntityRecordIdSelectFilter = activitySelectFilter;	
			}
			try {
				actualizer.Actualize(entitySchemaUId);
			} catch (Exception e) {
			} finally {
				SendReminding(this.Get<string>("ActualizationSuccessMessage"));
			}
			return true;
		}

			public virtual void SendReminding(string message) {
				var entitySchemaManager = this.Get<UserConnection>("UserConnection").EntitySchemaManager;
				var administratedObject = entitySchemaManager.GetInstanceByUId(this.Get<Guid>("EntitySchemaUId"));
				message = string.Format(message, administratedObject.Name);
				RemindingServerUtilities.CreateRemindingByProcess(UserConnection, "ObjectRecordRightsActualizationProcess", message);
			}

		#endregion

	}

	#endregion

	#region Class: ObjectRecordRightsActualizationProcess

	/// <exclude/>
	public class ObjectRecordRightsActualizationProcess : Terrasoft.Core.Process.Process
	{

		#region Class: ProcessLane1

		/// <exclude/>
		public class ProcessLane1 : ProcessLane
		{

			public ProcessLane1(UserConnection userConnection, ObjectRecordRightsActualizationProcess process)
				: base(userConnection) {
				Owner = process;
				IsUsedParentUserContexts = false;
			}

		}

		#endregion

		public ObjectRecordRightsActualizationProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ObjectRecordRightsActualizationProcess";
			SchemaUId = new Guid("c949331e-753b-48bb-88a9-9e89d8c8a301");
			Caption = Schema.Caption;
			SchemaManagerName = "ProcessSchemaManager";
			SerializeToDB = true;
			SerializeToMemory = true;
			IsLogging = true;
			UseSystemSecurityContext = true;
			_notificationCaption = () => { return new LocalizableString((Caption)); };
			ProcessModel = new ObjectRecordRightsActualizationProcessMethodsWrapper(this);
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("c949331e-753b-48bb-88a9-9e89d8c8a301");
			}
		}

		private string ConditionalExpressionLogMessage {
			get {
				return "Process: ObjectRecordRightsActualizationProcess, Source element: {0}, Conditional flow: {1}, Expression: {2}, Result: {3}";
			}
		}

		private string DeadEndGatewayLogMessage {
			get {
				return "Process: ObjectRecordRightsActualizationProcess, Source element: {0}, None of the exclusive gateway conditions are met!";
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

		public virtual Guid EntitySchemaUId {
			get;
			set;
		}

		private int _chunkSize = 500;
		public int ChunkSize {
			get {
				return _chunkSize;
			}
			set {
				_chunkSize = value;
			}
		}

		private int _chunkProcessingDelay = 500;
		public int ChunkProcessingDelay {
			get {
				return _chunkProcessingDelay;
			}
			set {
				_chunkProcessingDelay = value;
			}
		}

		private int _maxDegreeOfParallelism = 2;
		public int MaxDegreeOfParallelism {
			get {
				return _maxDegreeOfParallelism;
			}
			set {
				_maxDegreeOfParallelism = value;
			}
		}

		private string _actualizationSuccessMessage;
		public virtual string ActualizationSuccessMessage {
			get {
				return _actualizationSuccessMessage ?? (_actualizationSuccessMessage = GetLocalizableString("c949331e753b48bb88a99e89d8c8a301",
						 "Parameters.ActualizationSuccessMessage.Value"));
			}
			set {
				_actualizationSuccessMessage = value;
			}
		}

		private ProcessLane1 _lane1;
		public ProcessLane1 Lane1 {
			get {
				return _lane1 ?? ((_lane1) = new ProcessLane1(UserConnection, this));
			}
		}

		private ProcessFlowElement _startEvent1;
		public ProcessFlowElement StartEvent1 {
			get {
				return _startEvent1 ?? (_startEvent1 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartEvent",
					Name = "StartEvent1",
					SchemaElementUId = new Guid("c7a5f5a7-e453-44de-91ea-22c336bb64a1"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
				});
			}
		}

		private ProcessTerminateEvent _terminator;
		public ProcessTerminateEvent Terminator {
			get {
				return _terminator ?? (_terminator = new ProcessTerminateEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaTerminateEvent",
					Name = "Terminator",
					SchemaElementUId = new Guid("88ba5837-c741-4192-be87-98750b79328e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
				});
			}
		}

		private ProcessScriptTask _actualizationExecutionScriptTask;
		public ProcessScriptTask ActualizationExecutionScriptTask {
			get {
				return _actualizationExecutionScriptTask ?? (_actualizationExecutionScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ActualizationExecutionScriptTask",
					SchemaElementUId = new Guid("dfc394f8-650b-4d0a-a8cf-51caf2020168"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
					Script = ProcessModel.GetScriptTaskMethod("ActualizationExecutionScriptTaskExecute"),
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[StartEvent1.SchemaElementUId] = new Collection<ProcessFlowElement> { StartEvent1 };
			FlowElements[Terminator.SchemaElementUId] = new Collection<ProcessFlowElement> { Terminator };
			FlowElements[ActualizationExecutionScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { ActualizationExecutionScriptTask };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "StartEvent1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ActualizationExecutionScriptTask", e.Context.SenderName));
						break;
					case "Terminator":
						CompleteProcess();
						break;
					case "ActualizationExecutionScriptTask":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("Terminator", e.Context.SenderName));
						break;
			}
		}

		private void WritePropertyValues(DataWriter writer, bool useAllValueSources) {
			if (!HasMapping("EntitySchemaUId")) {
				writer.WriteValue("EntitySchemaUId", EntitySchemaUId, Guid.Empty);
			}
			if (!HasMapping("ChunkSize")) {
				writer.WriteValue("ChunkSize", ChunkSize, 0);
			}
			if (!HasMapping("ChunkProcessingDelay")) {
				writer.WriteValue("ChunkProcessingDelay", ChunkProcessingDelay, 0);
			}
			if (!HasMapping("MaxDegreeOfParallelism")) {
				writer.WriteValue("MaxDegreeOfParallelism", MaxDegreeOfParallelism, 0);
			}
			if (!HasMapping("ActualizationSuccessMessage")) {
				writer.WriteValue("ActualizationSuccessMessage", ActualizationSuccessMessage, null);
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
			context.QueueTasksV2.Enqueue(new ProcessQueueElement("StartEvent1", string.Empty));
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
			MetaPathParameterValues.Add("a5251af1-5a5f-4a1a-b2df-fa3127bd8a6d", () => EntitySchemaUId);
			MetaPathParameterValues.Add("3a99f3cf-49f7-4bb2-8733-3f5ae25c02a6", () => ChunkSize);
			MetaPathParameterValues.Add("63f8392a-72cc-4846-a89e-83ae75644a3c", () => ChunkProcessingDelay);
			MetaPathParameterValues.Add("9975462c-580e-4b2b-93b8-5e7bd11a190c", () => MaxDegreeOfParallelism);
			MetaPathParameterValues.Add("a9fa7b5b-d4bb-4388-a77e-49064d132625", () => ActualizationSuccessMessage);
		}

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			bool hasValueToRead = reader.HasValue();
			switch (reader.CurrentName) {
				case "EntitySchemaUId":
					if (!hasValueToRead) break;
					EntitySchemaUId = reader.GetValue<System.Guid>();
				break;
				case "ChunkSize":
					if (!hasValueToRead) break;
					ChunkSize = reader.GetValue<System.Int32>();
				break;
				case "ChunkProcessingDelay":
					if (!hasValueToRead) break;
					ChunkProcessingDelay = reader.GetValue<System.Int32>();
				break;
				case "MaxDegreeOfParallelism":
					if (!hasValueToRead) break;
					MaxDegreeOfParallelism = reader.GetValue<System.Int32>();
				break;
				case "ActualizationSuccessMessage":
					if (!hasValueToRead) break;
					ActualizationSuccessMessage = reader.GetValue<System.String>();
				break;
			}
		}

		protected override void WritePropertyValues(DataWriter writer) {
			base.WritePropertyValues(writer);
			WritePropertyValues(writer, true);
		}

		#endregion

		#region Methods: Public

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
			var cloneItem = (ObjectRecordRightsActualizationProcess)base.CloneShallow();
			cloneItem.ExecutedEventHandler = ExecutedEventHandler;
			return cloneItem;
		}

		#endregion

	}

	#endregion

}

