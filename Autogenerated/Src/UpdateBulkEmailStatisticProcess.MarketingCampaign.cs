namespace Terrasoft.Core.Process
{

	using Mandrill;
	using Mandrill.Models;
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
	using Terrasoft.Configuration.MandrillService;
	using Terrasoft.Configuration.Marketing.Utilities;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;

	#region Class: UpdateBulkEmailStatisticProcessSchema

	/// <exclude/>
	public class UpdateBulkEmailStatisticProcessSchema : Terrasoft.Core.Process.ProcessSchema
	{

		#region Constructors: Public

		public UpdateBulkEmailStatisticProcessSchema(ProcessSchemaManager processSchemaManager)
			: base(processSchemaManager) {
		}

		public UpdateBulkEmailStatisticProcessSchema(UpdateBulkEmailStatisticProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "UpdateBulkEmailStatisticProcess";
			UId = new Guid("9aa23ffa-eec2-493e-99cd-4e7b2e88a98b");
			CreatedInPackageId = new Guid("a71cf908-541e-4deb-89f8-9de8aba93b8f");
			CreatedInSchemaUId = Guid.Empty;
			CreatedInVersion = @"7.11.2.1633";
			CultureName = @"en-US";
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
			ZipCompiledMethodsBody = new byte[] {  };
			RealUId = new Guid("9aa23ffa-eec2-493e-99cd-4e7b2e88a98b");
			Version = 0;
			PackageUId = new Guid("789c617e-760f-4576-a608-ee12728eae0a");
		}

		protected virtual ProcessSchemaParameter CreateSessionKeyParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("cad79a49-4031-447e-9541-b644e757b7fe"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("9aa23ffa-eec2-493e-99cd-4e7b2e88a98b"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("9aa23ffa-eec2-493e-99cd-4e7b2e88a98b"),
				Name = @"SessionKey",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("ShortText"),
			};
		}

		protected virtual ProcessSchemaParameter CreateLOGGERParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("416f5a5f-33a2-49db-b8c3-8e8f3df4f002"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("9aa23ffa-eec2-493e-99cd-4e7b2e88a98b"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("9aa23ffa-eec2-493e-99cd-4e7b2e88a98b"),
				Name = @"LOGGER",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			};
		}

		protected virtual ProcessSchemaParameter CreateBulkEmailIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("ace018d5-3c9d-42ca-957c-7794475b8f34"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("9aa23ffa-eec2-493e-99cd-4e7b2e88a98b"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("9aa23ffa-eec2-493e-99cd-4e7b2e88a98b"),
				Name = @"BulkEmailId",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreatePrimaryColumnNameParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("ed38ac4d-40b6-42be-ab57-1ded9724f8a9"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("9aa23ffa-eec2-493e-99cd-4e7b2e88a98b"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("9aa23ffa-eec2-493e-99cd-4e7b2e88a98b"),
				Name = @"PrimaryColumnName",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MediumText"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateSessionKeyParameter());
			Parameters.Add(CreateLOGGERParameter());
			Parameters.Add(CreateBulkEmailIdParameter());
			Parameters.Add(CreatePrimaryColumnNameParameter());
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaMainLaneSet = CreateMainLaneSetLaneSet();
			LaneSets.Add(schemaMainLaneSet);
			ProcessSchemaLane schemaMainLane = CreateMainLaneLane();
			schemaMainLaneSet.Lanes.Add(schemaMainLane);
			ProcessSchemaStartEvent processstart = CreateProcessStartStartEvent();
			FlowElements.Add(processstart);
			ProcessSchemaTerminateEvent processterminate = CreateProcessTerminateTerminateEvent();
			FlowElements.Add(processterminate);
			ProcessSchemaScriptTask processscripttask = CreateProcessScriptTaskScriptTask();
			FlowElements.Add(processscripttask);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("079cefba-1fb2-4512-8470-5cca0e5f1e29"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("a71cf908-541e-4deb-89f8-9de8aba93b8f"),
				CreatedInSchemaUId = new Guid("9aa23ffa-eec2-493e-99cd-4e7b2e88a98b"),
				CurveCenterPosition = new Point(373, 203),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("9aa23ffa-eec2-493e-99cd-4e7b2e88a98b"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("fc85033b-7ca3-4569-bcdb-af8a1555df7e"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("5e5f7f80-ff86-4008-a039-aca76a3d0cd9"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("be7e5eee-4c32-4183-abac-9b9010457ab3"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("a71cf908-541e-4deb-89f8-9de8aba93b8f"),
				CreatedInSchemaUId = new Guid("9aa23ffa-eec2-493e-99cd-4e7b2e88a98b"),
				CurveCenterPosition = new Point(373, 203),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("9aa23ffa-eec2-493e-99cd-4e7b2e88a98b"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("5e5f7f80-ff86-4008-a039-aca76a3d0cd9"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("25a97836-117b-4528-8563-53e60891a397"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateMainLaneSetLaneSet() {
			ProcessSchemaLaneSet schemaMainLaneSet = new ProcessSchemaLaneSet(this) {
				UId = new Guid("2e16cf8a-c255-4056-8ef2-10f18ba4eb4b"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("a71cf908-541e-4deb-89f8-9de8aba93b8f"),
				CreatedInSchemaUId = new Guid("9aa23ffa-eec2-493e-99cd-4e7b2e88a98b"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("9aa23ffa-eec2-493e-99cd-4e7b2e88a98b"),
				Name = @"MainLaneSet",
				Position = new Point(5, 5),
				Size = new Size(882, 400),
				UseBackgroundMode = false
			};
			return schemaMainLaneSet;
		}

		protected virtual ProcessSchemaLane CreateMainLaneLane() {
			ProcessSchemaLane schemaMainLane = new ProcessSchemaLane(this) {
				UId = new Guid("52c751bd-683b-495b-86ac-316768d594cf"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("2e16cf8a-c255-4056-8ef2-10f18ba4eb4b"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("a71cf908-541e-4deb-89f8-9de8aba93b8f"),
				CreatedInSchemaUId = new Guid("9aa23ffa-eec2-493e-99cd-4e7b2e88a98b"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("9aa23ffa-eec2-493e-99cd-4e7b2e88a98b"),
				Name = @"MainLane",
				Position = new Point(29, 0),
				Size = new Size(853, 400),
				UseBackgroundMode = false
			};
			return schemaMainLane;
		}

		protected virtual ProcessSchemaStartEvent CreateProcessStartStartEvent() {
			ProcessSchemaStartEvent schemaStartEvent = new ProcessSchemaStartEvent(this) {
				UId = new Guid("fc85033b-7ca3-4569-bcdb-af8a1555df7e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("52c751bd-683b-495b-86ac-316768d594cf"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("a71cf908-541e-4deb-89f8-9de8aba93b8f"),
				CreatedInSchemaUId = new Guid("9aa23ffa-eec2-493e-99cd-4e7b2e88a98b"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("53818048-7868-48f6-ada0-0ebaa65af628"),
				ModifiedInSchemaUId = new Guid("9aa23ffa-eec2-493e-99cd-4e7b2e88a98b"),
				Name = @"ProcessStart",
				Position = new Point(50, 184),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartEvent;
		}

		protected virtual ProcessSchemaTerminateEvent CreateProcessTerminateTerminateEvent() {
			ProcessSchemaTerminateEvent schemaTerminateEvent = new ProcessSchemaTerminateEvent(this) {
				UId = new Guid("25a97836-117b-4528-8563-53e60891a397"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("52c751bd-683b-495b-86ac-316768d594cf"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("a71cf908-541e-4deb-89f8-9de8aba93b8f"),
				CreatedInSchemaUId = new Guid("9aa23ffa-eec2-493e-99cd-4e7b2e88a98b"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = false,
				ManagerItemUId = new Guid("1bd93619-0574-454e-bb4e-cf53b9eb9470"),
				ModifiedInSchemaUId = new Guid("9aa23ffa-eec2-493e-99cd-4e7b2e88a98b"),
				Name = @"ProcessTerminate",
				Position = new Point(600, 184),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaTerminateEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateProcessScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("5e5f7f80-ff86-4008-a039-aca76a3d0cd9"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("52c751bd-683b-495b-86ac-316768d594cf"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("a71cf908-541e-4deb-89f8-9de8aba93b8f"),
				CreatedInSchemaUId = new Guid("9aa23ffa-eec2-493e-99cd-4e7b2e88a98b"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("9aa23ffa-eec2-493e-99cd-4e7b2e88a98b"),
				Name = @"ProcessScriptTask",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(204, 170),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,243,77,204,204,211,208,180,230,229,42,74,45,41,45,202,83,40,41,42,77,181,6,0,176,217,148,41,21,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateGetLoggerMethod());
			Methods.Add(CreateMainMethod());
			Methods.Add(CreateLogInfoMethod());
			Methods.Add(CreateLogErrorMethod());
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5bbc2622-4204-46b8-a625-ce0204ebcf8c"),
				Name = "Mandrill",
				Alias = "",
				CreatedInPackageId = new Guid("a71cf908-541e-4deb-89f8-9de8aba93b8f")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5515ff7d-6627-44d4-bdc1-70a1b22a4cb6"),
				Name = "Mandrill.Models",
				Alias = "",
				CreatedInPackageId = new Guid("a71cf908-541e-4deb-89f8-9de8aba93b8f")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("a4a20e82-73a1-4a69-8673-a5cc6340bc21"),
				Name = "Terrasoft.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("a71cf908-541e-4deb-89f8-9de8aba93b8f")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("ef899f9d-0036-4801-82bf-72b31ed11ca8"),
				Name = "System.Linq",
				Alias = "",
				CreatedInPackageId = new Guid("a71cf908-541e-4deb-89f8-9de8aba93b8f")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("cdae3159-1884-4d98-85c8-c8056f5aed58"),
				Name = "Terrasoft.Configuration.MandrillService",
				Alias = "",
				CreatedInPackageId = new Guid("56ea33ea-e32a-430c-959f-44e40c0eb1dc")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e9c1af0d-16a1-4c6a-a1b4-ed25710fc2d9"),
				Name = "Terrasoft.Configuration.Marketing.Utilities",
				Alias = "",
				CreatedInPackageId = new Guid("56ea33ea-e32a-430c-959f-44e40c0eb1dc")
			});
		}

		protected virtual SchemaMethod CreateGetLoggerMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("71d177cc-03bf-46d6-b50e-8cd474888fad"),
				Name = "GetLogger",
				CreatedInSchemaUId = new Guid("9aa23ffa-eec2-493e-99cd-4e7b2e88a98b"),
				CreatedInPackageId = new Guid("a71cf908-541e-4deb-89f8-9de8aba93b8f"),
				ResultValueTypeName = "global::Common.Logging.ILog"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,142,77,10,194,48,16,133,215,17,188,67,232,42,217,228,0,149,174,164,4,177,166,96,189,64,196,88,3,249,145,36,85,138,120,119,211,244,71,55,174,222,48,243,230,123,111,189,2,0,60,184,131,202,182,173,112,176,128,85,77,105,121,132,220,195,86,217,51,87,121,190,181,90,91,67,170,232,144,166,37,187,56,108,214,195,159,188,66,52,255,21,208,116,74,97,248,74,23,176,224,254,64,162,30,184,225,209,67,168,8,85,114,163,112,147,158,48,174,5,30,249,96,234,82,76,237,198,237,123,201,246,193,165,66,158,197,232,218,149,250,30,122,212,8,239,165,53,123,209,227,165,205,119,23,89,180,147,23,194,196,115,80,132,201,201,54,9,131,50,150,225,223,4,39,66,231,204,28,253,1,29,188,33,141,41,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateMainMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("d9ef6729-8bd9-4311-b41d-89b8ef328cbb"),
				Name = "Main",
				CreatedInSchemaUId = new Guid("9aa23ffa-eec2-493e-99cd-4e7b2e88a98b"),
				CreatedInPackageId = new Guid("a71cf908-541e-4deb-89f8-9de8aba93b8f"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,227,229,226,228,228,244,201,79,247,204,75,203,215,80,138,246,77,204,204,139,181,82,8,46,73,44,42,73,77,209,83,210,180,230,5,41,112,205,77,204,204,1,10,150,100,22,151,100,38,123,36,230,165,228,164,22,41,164,98,21,181,85,200,75,45,87,192,170,67,35,180,56,181,200,57,63,47,47,53,185,36,51,63,15,106,56,86,99,244,66,11,82,18,75,82,157,74,115,178,93,19,115,145,228,53,192,66,32,45,158,41,80,3,48,156,239,150,153,151,89,156,1,113,63,0,186,62,123,13,225,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateLogInfoMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("e7274bc7-8287-41ae-a453-4e9796c6e0d7"),
				Name = "LogInfo",
				CreatedInSchemaUId = new Guid("9aa23ffa-eec2-493e-99cd-4e7b2e88a98b"),
				CreatedInPackageId = new Guid("a71cf908-541e-4deb-89f8-9de8aba93b8f"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("d590fa4e-a943-4b63-b5ab-52ae10408e65"),
				Name = "message",
				CreatedInSchemaUId = new Guid("9aa23ffa-eec2-493e-99cd-4e7b2e88a98b"),
				ModifiedInSchemaUId = new Guid("9aa23ffa-eec2-493e-99cd-4e7b2e88a98b"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("a71cf908-541e-4deb-89f8-9de8aba93b8f")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,75,44,82,200,201,79,79,79,45,82,176,85,112,79,45,241,1,179,53,52,173,185,32,162,122,158,121,105,249,26,37,25,153,197,122,126,137,185,169,10,218,10,74,86,10,209,74,64,58,56,181,184,56,51,63,207,59,181,18,36,24,171,0,18,203,5,138,37,166,131,85,89,43,105,90,3,0,43,138,177,200,93,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateLogErrorMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("4d0e23d9-7d74-45f4-a298-519e2b1f9859"),
				Name = "LogError",
				CreatedInSchemaUId = new Guid("9aa23ffa-eec2-493e-99cd-4e7b2e88a98b"),
				CreatedInPackageId = new Guid("a71cf908-541e-4deb-89f8-9de8aba93b8f"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("13177034-7a7e-4e58-959b-de65c46f8559"),
				Name = "message",
				CreatedInSchemaUId = new Guid("9aa23ffa-eec2-493e-99cd-4e7b2e88a98b"),
				ModifiedInSchemaUId = new Guid("9aa23ffa-eec2-493e-99cd-4e7b2e88a98b"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("a71cf908-541e-4deb-89f8-9de8aba93b8f")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("92e12b8b-3fa5-43a0-9296-83a13fc869a1"),
				Name = "e",
				CreatedInSchemaUId = new Guid("9aa23ffa-eec2-493e-99cd-4e7b2e88a98b"),
				ModifiedInSchemaUId = new Guid("9aa23ffa-eec2-493e-99cd-4e7b2e88a98b"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Exception",
				CreatedInPackageId = new Guid("a71cf908-541e-4deb-89f8-9de8aba93b8f")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,75,44,82,200,201,79,79,79,45,82,176,85,112,79,45,241,1,179,53,52,173,185,32,162,122,174,69,69,249,69,26,37,25,153,197,122,126,137,185,169,10,218,10,74,86,10,209,74,64,58,56,181,184,56,51,63,207,59,181,18,36,24,171,0,18,203,5,138,37,166,131,85,89,43,233,40,164,106,90,3,0,131,238,231,16,97,0,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override Process CreateProcess(UserConnection userConnection) {
			return new UpdateBulkEmailStatisticProcess(userConnection);
		}

		public override object Clone() {
			return new UpdateBulkEmailStatisticProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("9aa23ffa-eec2-493e-99cd-4e7b2e88a98b"));
		}

		#endregion

	}

	#endregion

	#region Class: UpdateBulkEmailStatisticProcess

	/// <exclude/>
	public class UpdateBulkEmailStatisticProcess : Terrasoft.Core.Process.Process
	{

		#region Class: ProcessMainLane

		/// <exclude/>
		public class ProcessMainLane : ProcessLane
		{

			public ProcessMainLane(UserConnection userConnection, UpdateBulkEmailStatisticProcess process)
				: base(userConnection) {
				Owner = process;
				IsUsedParentUserContexts = false;
			}

		}

		#endregion

		public UpdateBulkEmailStatisticProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "UpdateBulkEmailStatisticProcess";
			SchemaUId = new Guid("9aa23ffa-eec2-493e-99cd-4e7b2e88a98b");
			Caption = Schema.Caption;
			SchemaManagerName = "ProcessSchemaManager";
			SerializeToDB = false;
			SerializeToMemory = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private  Guid InternalSchemaUId {
			get {
				return new Guid("9aa23ffa-eec2-493e-99cd-4e7b2e88a98b");
			}
		}

		#endregion

		#region Properties: Public

		public  virtual string SessionKey {
			get;
			set;
		}

		public  virtual Object LOGGER {
			get;
			set;
		}

		public  virtual Guid BulkEmailId {
			get;
			set;
		}

		public  virtual string PrimaryColumnName {
			get;
			set;
		}

		private ProcessMainLane _mainLane;
		public  ProcessMainLane MainLane {
			get {
				return _mainLane ?? ((_mainLane) = new ProcessMainLane(UserConnection, this));
			}
		}

		private ProcessFlowElement _processStart;
		public  ProcessFlowElement ProcessStart {
			get {
				return _processStart ?? (_processStart = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartEvent",
					Name = "ProcessStart",
					SchemaElementUId = new Guid("fc85033b-7ca3-4569-bcdb-af8a1555df7e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessTerminateEvent _processTerminate;
		public  ProcessTerminateEvent ProcessTerminate {
			get {
				return _processTerminate ?? (_processTerminate = new ProcessTerminateEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaTerminateEvent",
					Name = "ProcessTerminate",
					SchemaElementUId = new Guid("25a97836-117b-4528-8563-53e60891a397"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _processScriptTask;
		public  ProcessScriptTask ProcessScriptTask {
			get {
				return _processScriptTask ?? (_processScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ProcessScriptTask",
					SchemaElementUId = new Guid("5e5f7f80-ff86-4008-a039-aca76a3d0cd9"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					Script = ProcessScriptTaskExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[ProcessStart.SchemaElementUId] = new Collection<ProcessFlowElement> { ProcessStart };
			FlowElements[ProcessTerminate.SchemaElementUId] = new Collection<ProcessFlowElement> { ProcessTerminate };
			FlowElements[ProcessScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { ProcessScriptTask };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "ProcessStart":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ProcessScriptTask", e.Context.SenderName));
						break;
					case "ProcessTerminate":
						CompleteProcess();
						break;
					case "ProcessScriptTask":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ProcessTerminate", e.Context.SenderName));
						break;
			}
		}

		private void WritePropertyValues(DataWriter writer, bool useAllValueSources) {
			if (!HasMapping("SessionKey")) {
				writer.WriteValue("SessionKey", SessionKey, null);
			}
			if (LOGGER != null) {
				if (LOGGER.GetType().IsSerializable ||
					LOGGER.GetType().GetInterface("ISerializable") != null) {
					writer.WriteSerializableObjectValue("LOGGER", LOGGER, null);
				}
			}
			if (!HasMapping("BulkEmailId")) {
				writer.WriteValue("BulkEmailId", BulkEmailId, Guid.Empty);
			}
			if (!HasMapping("PrimaryColumnName")) {
				writer.WriteValue("PrimaryColumnName", PrimaryColumnName, null);
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
			context.QueueTasksV2.Enqueue(new ProcessQueueElement("ProcessStart", string.Empty));
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
			MetaPathParameterValues.Add("cad79a49-4031-447e-9541-b644e757b7fe", () => SessionKey);
			MetaPathParameterValues.Add("416f5a5f-33a2-49db-b8c3-8e8f3df4f002", () => LOGGER);
			MetaPathParameterValues.Add("ace018d5-3c9d-42ca-957c-7794475b8f34", () => BulkEmailId);
			MetaPathParameterValues.Add("ed38ac4d-40b6-42be-ab57-1ded9724f8a9", () => PrimaryColumnName);
		}

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			bool hasValueToRead = reader.HasValue();
			switch (reader.CurrentName) {
				case "SessionKey":
					if (!hasValueToRead) break;
					SessionKey = reader.GetValue<System.String>();
				break;
				case "LOGGER":
					if (!hasValueToRead) break;
					LOGGER = reader.GetSerializableObjectValue();
				break;
				case "BulkEmailId":
					if (!hasValueToRead) break;
					BulkEmailId = reader.GetValue<System.Guid>();
				break;
				case "PrimaryColumnName":
					if (!hasValueToRead) break;
					PrimaryColumnName = reader.GetValue<System.String>();
				break;
			}
		}

		protected override void WritePropertyValues(DataWriter writer) {
			base.WritePropertyValues(writer);
			WritePropertyValues(writer, true);
		}

		#endregion

		#region Methods: Public

		public virtual bool ProcessScriptTaskExecute(ProcessExecutingContext context) {
			Main();
			return true;
		}

		public virtual global::Common.Logging.ILog GetLogger() {
			
						var logger = LOGGER as global::Common.Logging.ILog;
						if (logger == null) {
							logger = global::Common.Logging.LogManager.GetLogger(this.Name);
							LOGGER = logger;
						}
						if (string.IsNullOrEmpty(SessionKey)) {
							SessionKey = Guid.NewGuid().ToString("N");
						}
						return logger;
		}

		public virtual void Main() {
			
						LogInfo("[Main]: Started.");
						EmailStatisticHandler emailStatisticHandler = new EmailStatisticHandler(UserConnection);
						emailStatisticHandler.UpdateBulkEamilStatistic(BulkEmailId);
						LogInfo("[Main]: Finished.");
		}

		public virtual void LogInfo(string message) {
			var logger = GetLogger();
			logger.Info(this.Name + ": [" + SessionKey + "] " + message + ";");
		}

		public virtual void LogError(string message, Exception e) {
			var logger = GetLogger();
			logger.Error(this.Name + ": [" + SessionKey + "] " + message + ";", e);
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
			var cloneItem = (UpdateBulkEmailStatisticProcess)base.CloneShallow();
			cloneItem.ExecutedEventHandler = ExecutedEventHandler;
			cloneItem.LOGGER = LOGGER;
			return cloneItem;
		}

		#endregion

	}

	#endregion

}

