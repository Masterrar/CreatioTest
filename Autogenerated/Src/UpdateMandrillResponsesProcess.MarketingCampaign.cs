namespace Terrasoft.Core.Process
{

	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Drawing;
	using System.Globalization;
	using System.IO;
	using System.Linq;
	using System.Text;
	using Terrasoft.Common;
	using Terrasoft.Configuration.MandrillService;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;

	#region Class: UpdateMandrillResponsesProcessSchema

	/// <exclude/>
	public class UpdateMandrillResponsesProcessSchema : Terrasoft.Core.Process.ProcessSchema
	{

		#region Constructors: Public

		public UpdateMandrillResponsesProcessSchema(ProcessSchemaManager processSchemaManager)
			: base(processSchemaManager) {
		}

		public UpdateMandrillResponsesProcessSchema(UpdateMandrillResponsesProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "UpdateMandrillResponsesProcess";
			UId = new Guid("7222a17a-50c5-4a8b-8f8f-1041abb4ad34");
			CreatedInPackageId = new Guid("06c5e2cb-107e-4211-a5bd-01241dc3944b");
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
			RealUId = new Guid("7222a17a-50c5-4a8b-8f8f-1041abb4ad34");
			Version = 0;
			PackageUId = new Guid("789c617e-760f-4576-a608-ee12728eae0a");
		}

		protected virtual ProcessSchemaParameter CreateLOGGERParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("f825cfc9-031d-41c1-8549-65ac1a32ece6"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("7222a17a-50c5-4a8b-8f8f-1041abb4ad34"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("7222a17a-50c5-4a8b-8f8f-1041abb4ad34"),
				Name = @"LOGGER",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			};
		}

		protected virtual ProcessSchemaParameter CreateSessionKeyParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("93ad24a1-a51f-4f98-af3b-4e738383eaa8"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("7222a17a-50c5-4a8b-8f8f-1041abb4ad34"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("7222a17a-50c5-4a8b-8f8f-1041abb4ad34"),
				Name = @"SessionKey",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("ShortText"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateLOGGERParameter());
			Parameters.Add(CreateSessionKeyParameter());
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet1 = CreateLaneSet1LaneSet();
			LaneSets.Add(schemaLaneSet1);
			ProcessSchemaLane schemaLane1 = CreateLane1Lane();
			schemaLaneSet1.Lanes.Add(schemaLane1);
			ProcessSchemaStartEvent startprocess = CreateStartProcessStartEvent();
			FlowElements.Add(startprocess);
			ProcessSchemaTerminateEvent terminateprocess = CreateTerminateProcessTerminateEvent();
			FlowElements.Add(terminateprocess);
			ProcessSchemaScriptTask processscripttask = CreateProcessScriptTaskScriptTask();
			FlowElements.Add(processscripttask);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("2025ff3f-3dfe-41db-aba0-5d40e25c11c5"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("06c5e2cb-107e-4211-a5bd-01241dc3944b"),
				CreatedInSchemaUId = new Guid("7222a17a-50c5-4a8b-8f8f-1041abb4ad34"),
				CurveCenterPosition = new Point(373, 203),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("7222a17a-50c5-4a8b-8f8f-1041abb4ad34"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("a64b7740-676e-4a65-ab5f-f87cb4232b49"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("769c9c35-108b-46c1-b841-0e2593fa66a1"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("237c105c-0c2a-4255-b3a4-9b909e6e7319"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("06c5e2cb-107e-4211-a5bd-01241dc3944b"),
				CreatedInSchemaUId = new Guid("7222a17a-50c5-4a8b-8f8f-1041abb4ad34"),
				CurveCenterPosition = new Point(373, 203),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("7222a17a-50c5-4a8b-8f8f-1041abb4ad34"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("769c9c35-108b-46c1-b841-0e2593fa66a1"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("62d7928f-7bab-4331-adf8-50fc4c0da58d"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("8f84297d-9a9e-4d2c-8f79-2be16258ac69"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("06c5e2cb-107e-4211-a5bd-01241dc3944b"),
				CreatedInSchemaUId = new Guid("7222a17a-50c5-4a8b-8f8f-1041abb4ad34"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("7222a17a-50c5-4a8b-8f8f-1041abb4ad34"),
				Name = @"LaneSet1",
				Position = new Point(5, 5),
				Size = new Size(882, 400),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("377560a4-964a-45bf-abc2-d4e47b8da64d"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("8f84297d-9a9e-4d2c-8f79-2be16258ac69"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("06c5e2cb-107e-4211-a5bd-01241dc3944b"),
				CreatedInSchemaUId = new Guid("7222a17a-50c5-4a8b-8f8f-1041abb4ad34"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("7222a17a-50c5-4a8b-8f8f-1041abb4ad34"),
				Name = @"Lane1",
				Position = new Point(29, 0),
				Size = new Size(853, 400),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaStartEvent CreateStartProcessStartEvent() {
			ProcessSchemaStartEvent schemaStartEvent = new ProcessSchemaStartEvent(this) {
				UId = new Guid("a64b7740-676e-4a65-ab5f-f87cb4232b49"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("377560a4-964a-45bf-abc2-d4e47b8da64d"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("06c5e2cb-107e-4211-a5bd-01241dc3944b"),
				CreatedInSchemaUId = new Guid("7222a17a-50c5-4a8b-8f8f-1041abb4ad34"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("53818048-7868-48f6-ada0-0ebaa65af628"),
				ModifiedInSchemaUId = new Guid("7222a17a-50c5-4a8b-8f8f-1041abb4ad34"),
				Name = @"StartProcess",
				Position = new Point(50, 184),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartEvent;
		}

		protected virtual ProcessSchemaTerminateEvent CreateTerminateProcessTerminateEvent() {
			ProcessSchemaTerminateEvent schemaTerminateEvent = new ProcessSchemaTerminateEvent(this) {
				UId = new Guid("62d7928f-7bab-4331-adf8-50fc4c0da58d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("377560a4-964a-45bf-abc2-d4e47b8da64d"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("06c5e2cb-107e-4211-a5bd-01241dc3944b"),
				CreatedInSchemaUId = new Guid("7222a17a-50c5-4a8b-8f8f-1041abb4ad34"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = false,
				ManagerItemUId = new Guid("1bd93619-0574-454e-bb4e-cf53b9eb9470"),
				ModifiedInSchemaUId = new Guid("7222a17a-50c5-4a8b-8f8f-1041abb4ad34"),
				Name = @"TerminateProcess",
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
				UId = new Guid("769c9c35-108b-46c1-b841-0e2593fa66a1"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("377560a4-964a-45bf-abc2-d4e47b8da64d"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("06c5e2cb-107e-4211-a5bd-01241dc3944b"),
				CreatedInSchemaUId = new Guid("7222a17a-50c5-4a8b-8f8f-1041abb4ad34"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("7222a17a-50c5-4a8b-8f8f-1041abb4ad34"),
				Name = @"ProcessScriptTask",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(288, 170),
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
			Methods.Add(CreateLogErrorMethod());
			Methods.Add(CreateLogInfoMethod());
			Methods.Add(CreateGetLoggerMethod());
			Methods.Add(CreateMainMethod());
			Methods.Add(CreateProcessMandrillResponseMethod());
			Methods.Add(CreateActualizeUnsubscribeEmailsMethod());
			Methods.Add(CreateProcessRawMandrillEventsMethod());
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("64578af7-0e25-4cf2-b0f3-c88d9d4dcaa2"),
				Name = "System.IO",
				Alias = "",
				CreatedInPackageId = new Guid("06c5e2cb-107e-4211-a5bd-01241dc3944b")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("038058ed-0ffc-4c45-9f1b-05103bd22326"),
				Name = "Terrasoft.Configuration.MandrillService",
				Alias = "",
				CreatedInPackageId = new Guid("06c5e2cb-107e-4211-a5bd-01241dc3944b")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("08cbf583-c9f1-400c-811a-4ec498339d60"),
				Name = "System.Text",
				Alias = "",
				CreatedInPackageId = new Guid("06c5e2cb-107e-4211-a5bd-01241dc3944b")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("525941e7-4f57-44d0-bbe4-04f450b2d9e5"),
				Name = "System.Linq",
				Alias = "",
				CreatedInPackageId = new Guid("48513af2-42ae-4933-a664-64fbd4224266")
			});
		}

		protected virtual SchemaMethod CreateLogErrorMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("1dbedb44-7890-4b83-acb4-8da61532b92e"),
				Name = "LogError",
				CreatedInSchemaUId = new Guid("7222a17a-50c5-4a8b-8f8f-1041abb4ad34"),
				CreatedInPackageId = new Guid("48513af2-42ae-4933-a664-64fbd4224266"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("0a214fe2-9394-47a0-abf4-a048d8df9bea"),
				Name = "message",
				CreatedInSchemaUId = new Guid("7222a17a-50c5-4a8b-8f8f-1041abb4ad34"),
				ModifiedInSchemaUId = new Guid("7222a17a-50c5-4a8b-8f8f-1041abb4ad34"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("48513af2-42ae-4933-a664-64fbd4224266")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("f6f39fd5-3172-43bb-8810-7db215541e1f"),
				Name = "e",
				CreatedInSchemaUId = new Guid("7222a17a-50c5-4a8b-8f8f-1041abb4ad34"),
				ModifiedInSchemaUId = new Guid("7222a17a-50c5-4a8b-8f8f-1041abb4ad34"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Exception",
				CreatedInPackageId = new Guid("48513af2-42ae-4933-a664-64fbd4224266")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,75,44,82,200,201,79,79,79,45,82,176,85,112,79,45,241,1,179,53,52,173,185,32,162,122,174,69,69,249,69,26,37,25,153,197,122,126,137,185,169,10,218,10,74,86,10,209,74,64,58,56,181,184,56,51,63,207,59,181,18,36,24,171,0,18,203,5,138,37,166,131,85,89,43,233,40,164,106,90,3,0,131,238,231,16,97,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateLogInfoMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("3e9789fe-0ffb-4e7b-9963-02f83d08d1e3"),
				Name = "LogInfo",
				CreatedInSchemaUId = new Guid("7222a17a-50c5-4a8b-8f8f-1041abb4ad34"),
				CreatedInPackageId = new Guid("48513af2-42ae-4933-a664-64fbd4224266"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("df8b491e-5281-41d0-9d0f-2d1214b1a6a4"),
				Name = "message",
				CreatedInSchemaUId = new Guid("7222a17a-50c5-4a8b-8f8f-1041abb4ad34"),
				ModifiedInSchemaUId = new Guid("7222a17a-50c5-4a8b-8f8f-1041abb4ad34"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("48513af2-42ae-4933-a664-64fbd4224266")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,75,44,82,200,201,79,79,79,45,82,176,85,112,79,45,241,1,179,53,52,173,185,32,162,122,158,121,105,249,26,37,25,153,197,122,126,137,185,169,10,218,10,74,86,10,209,74,64,58,56,181,184,56,51,63,207,59,181,18,36,24,171,0,18,203,5,138,37,166,131,85,89,43,105,90,3,0,43,138,177,200,93,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetLoggerMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("ab5a6eaa-158e-40a1-b670-030826966883"),
				Name = "GetLogger",
				CreatedInSchemaUId = new Guid("7222a17a-50c5-4a8b-8f8f-1041abb4ad34"),
				CreatedInPackageId = new Guid("48513af2-42ae-4933-a664-64fbd4224266"),
				ResultValueTypeName = "global::Common.Logging.ILog"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,142,77,10,194,48,20,132,215,230,20,143,174,146,77,14,208,210,149,148,32,214,20,172,23,136,24,107,32,63,146,164,74,17,239,110,26,90,93,185,154,247,96,102,190,121,8,15,218,13,131,244,80,67,219,49,214,28,65,4,24,180,59,11,93,150,91,103,140,179,180,77,14,101,7,186,75,71,133,212,21,240,154,169,193,142,90,19,120,161,205,183,230,79,56,233,65,88,145,60,148,201,216,102,55,142,55,21,40,23,70,146,10,109,22,126,189,44,170,208,59,179,66,244,25,30,120,66,117,190,49,247,56,225,94,134,160,156,221,203,137,100,250,239,79,121,54,170,11,229,242,57,43,38,244,228,250,92,129,11,94,144,185,213,203,56,122,187,98,62,183,168,15,183,4,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateMainMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("03d9e2d6-5016-462d-80ff-2efe6db03491"),
				Name = "Main",
				CreatedInSchemaUId = new Guid("7222a17a-50c5-4a8b-8f8f-1041abb4ad34"),
				CreatedInPackageId = new Guid("48513af2-42ae-4933-a664-64fbd4224266"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,243,201,79,247,204,75,203,215,80,138,246,77,204,204,139,181,82,8,46,73,44,42,73,77,209,83,210,180,230,229,10,40,202,79,78,45,46,14,74,44,247,77,204,75,41,202,204,201,113,45,75,205,43,41,214,64,146,132,201,4,165,22,23,228,231,21,167,130,229,28,147,75,74,19,115,50,171,82,67,243,138,75,147,138,147,139,50,147,82,93,115,19,51,115,32,90,125,208,109,117,203,204,203,44,206,128,88,11,0,116,214,235,77,147,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateProcessMandrillResponseMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("32eb25af-6046-43da-b7ac-860340fc2bd4"),
				Name = "ProcessMandrillResponse",
				CreatedInSchemaUId = new Guid("7222a17a-50c5-4a8b-8f8f-1041abb4ad34"),
				CreatedInPackageId = new Guid("37b787ac-5e4e-4031-9f78-6e5fdb456414"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,141,65,10,194,48,16,69,215,22,122,135,144,85,10,197,11,184,148,236,20,68,233,74,68,74,242,209,64,201,132,153,41,84,196,187,107,4,151,174,255,123,239,43,63,204,179,109,86,251,49,71,78,211,52,104,154,146,38,200,218,47,8,179,226,164,196,136,7,166,128,56,51,220,32,224,45,229,140,160,137,114,111,172,74,185,126,103,145,95,228,8,41,148,5,182,219,180,205,203,132,81,195,221,56,191,4,148,42,25,116,245,114,71,55,207,76,236,236,249,143,127,177,253,135,173,141,55,8,142,190,137,167,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateActualizeUnsubscribeEmailsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("a777071f-952e-4ddb-8ecc-c9b3d6797967"),
				Name = "ActualizeUnsubscribeEmails",
				CreatedInSchemaUId = new Guid("7222a17a-50c5-4a8b-8f8f-1041abb4ad34"),
				CreatedInPackageId = new Guid("37b787ac-5e4e-4031-9f78-6e5fdb456414"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,141,75,10,194,48,16,64,215,22,122,135,144,85,10,197,11,184,18,201,78,65,144,172,68,36,157,12,58,16,147,50,153,64,85,188,187,230,0,238,223,71,248,169,222,125,183,58,248,20,152,98,116,66,145,132,176,172,237,130,80,5,79,146,25,195,145,51,96,168,140,198,21,228,93,78,9,65,40,167,81,105,41,243,117,11,82,125,164,23,186,84,234,84,128,105,66,251,240,20,139,30,54,125,247,81,224,5,238,202,216,5,112,110,158,194,161,93,247,249,102,153,51,27,125,254,159,184,232,241,135,183,204,23,202,1,169,88,173,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateProcessRawMandrillEventsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("5ac2e43a-3cef-4ecb-a9a8-f71c6bf8ae69"),
				Name = "ProcessRawMandrillEvents",
				CreatedInSchemaUId = new Guid("7222a17a-50c5-4a8b-8f8f-1041abb4ad34"),
				CreatedInPackageId = new Guid("37b787ac-5e4e-4031-9f78-6e5fdb456414"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,243,77,204,75,41,202,204,201,9,79,77,242,200,207,207,118,45,75,205,43,9,202,47,45,73,45,82,40,130,80,182,10,121,169,229,10,190,56,213,105,132,22,167,22,57,231,231,229,165,38,151,100,230,231,105,90,243,114,65,116,234,5,20,229,39,167,22,23,7,37,150,195,116,131,181,21,107,104,90,3,0,88,203,28,228,119,0,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override Process CreateProcess(UserConnection userConnection) {
			return new UpdateMandrillResponsesProcess(userConnection);
		}

		public override object Clone() {
			return new UpdateMandrillResponsesProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("7222a17a-50c5-4a8b-8f8f-1041abb4ad34"));
		}

		#endregion

	}

	#endregion

	#region Class: UpdateMandrillResponsesProcess

	/// <exclude/>
	public class UpdateMandrillResponsesProcess : Terrasoft.Core.Process.Process
	{

		#region Class: ProcessLane1

		/// <exclude/>
		public class ProcessLane1 : ProcessLane
		{

			public ProcessLane1(UserConnection userConnection, UpdateMandrillResponsesProcess process)
				: base(userConnection) {
				Owner = process;
				IsUsedParentUserContexts = false;
			}

		}

		#endregion

		public UpdateMandrillResponsesProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "UpdateMandrillResponsesProcess";
			SchemaUId = new Guid("7222a17a-50c5-4a8b-8f8f-1041abb4ad34");
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
				return new Guid("7222a17a-50c5-4a8b-8f8f-1041abb4ad34");
			}
		}

		#endregion

		#region Properties: Public

		public  virtual Object LOGGER {
			get;
			set;
		}

		public  virtual string SessionKey {
			get;
			set;
		}

		private ProcessLane1 _lane1;
		public  ProcessLane1 Lane1 {
			get {
				return _lane1 ?? ((_lane1) = new ProcessLane1(UserConnection, this));
			}
		}

		private ProcessFlowElement _startProcess;
		public  ProcessFlowElement StartProcess {
			get {
				return _startProcess ?? (_startProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartEvent",
					Name = "StartProcess",
					SchemaElementUId = new Guid("a64b7740-676e-4a65-ab5f-f87cb4232b49"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessTerminateEvent _terminateProcess;
		public  ProcessTerminateEvent TerminateProcess {
			get {
				return _terminateProcess ?? (_terminateProcess = new ProcessTerminateEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaTerminateEvent",
					Name = "TerminateProcess",
					SchemaElementUId = new Guid("62d7928f-7bab-4331-adf8-50fc4c0da58d"),
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
					SchemaElementUId = new Guid("769c9c35-108b-46c1-b841-0e2593fa66a1"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					Script = ProcessScriptTaskExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[StartProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { StartProcess };
			FlowElements[TerminateProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { TerminateProcess };
			FlowElements[ProcessScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { ProcessScriptTask };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "StartProcess":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ProcessScriptTask", e.Context.SenderName));
						break;
					case "TerminateProcess":
						CompleteProcess();
						break;
					case "ProcessScriptTask":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("TerminateProcess", e.Context.SenderName));
						break;
			}
		}

		private void WritePropertyValues(DataWriter writer, bool useAllValueSources) {
			if (LOGGER != null) {
				if (LOGGER.GetType().IsSerializable ||
					LOGGER.GetType().GetInterface("ISerializable") != null) {
					writer.WriteSerializableObjectValue("LOGGER", LOGGER, null);
				}
			}
			if (!HasMapping("SessionKey")) {
				writer.WriteValue("SessionKey", SessionKey, null);
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
			context.QueueTasksV2.Enqueue(new ProcessQueueElement("StartProcess", string.Empty));
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
			MetaPathParameterValues.Add("f825cfc9-031d-41c1-8549-65ac1a32ece6", () => LOGGER);
			MetaPathParameterValues.Add("93ad24a1-a51f-4f98-af3b-4e738383eaa8", () => SessionKey);
		}

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			bool hasValueToRead = reader.HasValue();
			switch (reader.CurrentName) {
				case "LOGGER":
					if (!hasValueToRead) break;
					LOGGER = reader.GetSerializableObjectValue();
				break;
				case "SessionKey":
					if (!hasValueToRead) break;
					SessionKey = reader.GetValue<System.String>();
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

		public virtual void LogError(string message, Exception e) {
			var logger = GetLogger();
			logger.Error(this.Name + ": [" + SessionKey + "] " + message + ";", e);
		}

		public virtual void LogInfo(string message) {
			var logger = GetLogger();
			logger.Info(this.Name + ": [" + SessionKey + "] " + message + ";");
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
			ProcessRawMandrillEvents();
			ProcessMandrillResponse();
			ActualizeUnsubscribeEmails();
			LogInfo("[Main]: Finished.");
		}

		public virtual void ProcessMandrillResponse() {
			try {
				MandrillUtilities.ExecuteStoredProcedure(UserConnection, "tsp_ProcessMandrillResponse");
			} catch (Exception e){
				LogError("[ProcessMandrillResponse]", e);
			}
		}

		public virtual void ActualizeUnsubscribeEmails() {
			try {
				MandrillUtilities.ExecuteStoredProcedure(UserConnection, "tsp_ActualizeUnsubscribeEmails");
			} catch (Exception e){
				LogError("[ActualizeUnsubscribeEmails]", e);
			}
		}

		public virtual void ProcessRawMandrillEvents() {
			MandrillWebHookEventRouter router = new MandrillWebHookEventRouter(UserConnection);
			router.ProcessRawMandrillEvents();
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
			var cloneItem = (UpdateMandrillResponsesProcess)base.CloneShallow();
			cloneItem.ExecutedEventHandler = ExecutedEventHandler;
			cloneItem.LOGGER = LOGGER;
			return cloneItem;
		}

		#endregion

	}

	#endregion

}

