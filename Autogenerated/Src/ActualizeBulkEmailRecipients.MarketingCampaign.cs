namespace Terrasoft.Core.Process
{

	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Data;
	using System.Drawing;
	using System.Globalization;
	using System.Text;
	using Terrasoft.Common;
	using Terrasoft.Configuration;
	using Terrasoft.Configuration.MandrillService;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;

	#region Class: ActualizeBulkEmailRecipientsSchema

	/// <exclude/>
	public class ActualizeBulkEmailRecipientsSchema : Terrasoft.Core.Process.ProcessSchema
	{

		#region Constructors: Public

		public ActualizeBulkEmailRecipientsSchema(ProcessSchemaManager processSchemaManager)
			: base(processSchemaManager) {
		}

		public ActualizeBulkEmailRecipientsSchema(ActualizeBulkEmailRecipientsSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "ActualizeBulkEmailRecipients";
			UId = new Guid("61c36017-c6ff-42bf-a2dc-e8d28ab4e481");
			CreatedInPackageId = new Guid("35882ed5-b82b-46d1-974a-718c2ed2f472");
			CreatedInSchemaUId = Guid.Empty;
			CreatedInVersion = @"7.6.0.0";
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
			RealUId = new Guid("61c36017-c6ff-42bf-a2dc-e8d28ab4e481");
			Version = 0;
			PackageUId = new Guid("789c617e-760f-4576-a608-ee12728eae0a");
			UseSystemSecurityContext = false;
		}

		protected virtual ProcessSchemaParameter CreateSessionKeyParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("ccf30a79-ff5e-451c-98a5-2d4d6cf1299a"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("61c36017-c6ff-42bf-a2dc-e8d28ab4e481"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("61c36017-c6ff-42bf-a2dc-e8d28ab4e481"),
				Name = @"SessionKey",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("ShortText"),
			};
		}

		protected virtual ProcessSchemaParameter CreateLOGGERParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("4449f3bb-5841-48c7-a613-6d90a9b7f456"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("61c36017-c6ff-42bf-a2dc-e8d28ab4e481"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("61c36017-c6ff-42bf-a2dc-e8d28ab4e481"),
				Name = @"LOGGER",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateSessionKeyParameter());
			Parameters.Add(CreateLOGGERParameter());
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
			ProcessSchemaScriptTask scriptmain = CreateScriptMainScriptTask();
			FlowElements.Add(scriptmain);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("f1fca63b-3ea2-4f68-ba94-89dcf46af738"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("35882ed5-b82b-46d1-974a-718c2ed2f472"),
				CreatedInSchemaUId = new Guid("61c36017-c6ff-42bf-a2dc-e8d28ab4e481"),
				CurveCenterPosition = new Point(373, 203),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("61c36017-c6ff-42bf-a2dc-e8d28ab4e481"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("77f33242-6f7d-4ced-8c74-7346cfe812d0"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("af84af2a-d656-4916-8437-11132ba775d9"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("0022e166-b714-4a74-a4ee-65379bbfa3b4"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("35882ed5-b82b-46d1-974a-718c2ed2f472"),
				CreatedInSchemaUId = new Guid("61c36017-c6ff-42bf-a2dc-e8d28ab4e481"),
				CurveCenterPosition = new Point(527, 208),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("61c36017-c6ff-42bf-a2dc-e8d28ab4e481"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("af84af2a-d656-4916-8437-11132ba775d9"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("d3d157f1-a25d-44fb-a96d-539664c943d0"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("b13ff23e-a247-494f-9649-f91b05c59347"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("35882ed5-b82b-46d1-974a-718c2ed2f472"),
				CreatedInSchemaUId = new Guid("61c36017-c6ff-42bf-a2dc-e8d28ab4e481"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("61c36017-c6ff-42bf-a2dc-e8d28ab4e481"),
				Name = @"LaneSet1",
				Position = new Point(5, 5),
				Size = new Size(882, 400),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("f86465b4-1339-4651-87fe-38b2d48028bc"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("b13ff23e-a247-494f-9649-f91b05c59347"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("35882ed5-b82b-46d1-974a-718c2ed2f472"),
				CreatedInSchemaUId = new Guid("61c36017-c6ff-42bf-a2dc-e8d28ab4e481"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("61c36017-c6ff-42bf-a2dc-e8d28ab4e481"),
				Name = @"Lane1",
				Position = new Point(29, 0),
				Size = new Size(853, 400),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaStartEvent CreateStart1StartEvent() {
			ProcessSchemaStartEvent schemaStartEvent = new ProcessSchemaStartEvent(this) {
				UId = new Guid("77f33242-6f7d-4ced-8c74-7346cfe812d0"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f86465b4-1339-4651-87fe-38b2d48028bc"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("35882ed5-b82b-46d1-974a-718c2ed2f472"),
				CreatedInSchemaUId = new Guid("61c36017-c6ff-42bf-a2dc-e8d28ab4e481"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("53818048-7868-48f6-ada0-0ebaa65af628"),
				ModifiedInSchemaUId = new Guid("61c36017-c6ff-42bf-a2dc-e8d28ab4e481"),
				Name = @"Start1",
				Position = new Point(50, 184),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartEvent;
		}

		protected virtual ProcessSchemaTerminateEvent CreateTerminate1TerminateEvent() {
			ProcessSchemaTerminateEvent schemaTerminateEvent = new ProcessSchemaTerminateEvent(this) {
				UId = new Guid("d3d157f1-a25d-44fb-a96d-539664c943d0"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f86465b4-1339-4651-87fe-38b2d48028bc"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("35882ed5-b82b-46d1-974a-718c2ed2f472"),
				CreatedInSchemaUId = new Guid("61c36017-c6ff-42bf-a2dc-e8d28ab4e481"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = false,
				ManagerItemUId = new Guid("1bd93619-0574-454e-bb4e-cf53b9eb9470"),
				ModifiedInSchemaUId = new Guid("61c36017-c6ff-42bf-a2dc-e8d28ab4e481"),
				Name = @"Terminate1",
				Position = new Point(600, 184),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaTerminateEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptMainScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("af84af2a-d656-4916-8437-11132ba775d9"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f86465b4-1339-4651-87fe-38b2d48028bc"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("35882ed5-b82b-46d1-974a-718c2ed2f472"),
				CreatedInSchemaUId = new Guid("61c36017-c6ff-42bf-a2dc-e8d28ab4e481"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("61c36017-c6ff-42bf-a2dc-e8d28ab4e481"),
				Name = @"ScriptMain",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(295, 170),
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
			Methods.Add(CreateMainMethod());
			Methods.Add(CreateLogErrorMethod());
			Methods.Add(CreateGetLoggerMethod());
			Methods.Add(CreateDeleteOutdatedDataMethod());
			Methods.Add(CreateProcessTriggerEmailsMethod());
			Methods.Add(CreateProcessMassEmailsMethod());
			Methods.Add(CreateInitialEmailsToProccessMethod());
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e3484efc-ebe3-4366-a991-1b0729f90297"),
				Name = "Terrasoft.Configuration.MandrillService",
				Alias = "",
				CreatedInPackageId = new Guid("35882ed5-b82b-46d1-974a-718c2ed2f472")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("cc216601-e3bc-4db4-a328-21462c6c475e"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("35882ed5-b82b-46d1-974a-718c2ed2f472")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("1cfb36b4-606d-4fea-9001-ac2a86966701"),
				Name = "Terrasoft.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("196dac4c-8195-4488-a569-0010bfda9cdc")
			});
		}

		protected virtual SchemaMethod CreateMainMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("85bd34ee-281a-40d1-bda5-17a9704e8550"),
				Name = "Main",
				CreatedInSchemaUId = new Guid("61c36017-c6ff-42bf-a2dc-e8d28ab4e481"),
				CreatedInPackageId = new Guid("35882ed5-b82b-46d1-974a-718c2ed2f472"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,101,142,193,106,195,64,12,68,207,245,87,136,156,28,40,246,7,132,158,226,210,83,112,192,78,239,234,122,236,46,108,118,91,73,27,112,190,190,235,66,105,161,23,193,240,102,30,106,219,118,236,187,158,174,188,210,27,200,222,33,32,175,164,136,174,196,68,89,65,19,102,186,113,200,133,204,228,82,142,70,248,204,28,148,238,144,68,213,141,133,38,94,143,223,228,137,106,31,109,63,66,132,53,205,214,28,147,160,156,56,251,37,11,155,79,177,25,86,29,96,230,227,162,77,245,240,2,123,221,236,245,69,33,165,24,225,182,214,35,237,78,28,39,241,33,12,86,118,106,222,93,62,38,54,156,33,62,77,29,175,186,219,31,170,179,36,7,213,81,252,178,64,158,175,236,131,214,63,239,252,242,19,171,254,135,29,2,12,125,182,205,91,148,198,127,232,23,224,146,212,243,29,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateLogErrorMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("29558aa7-8144-490a-b708-32f83c335ed4"),
				Name = "LogError",
				CreatedInSchemaUId = new Guid("61c36017-c6ff-42bf-a2dc-e8d28ab4e481"),
				CreatedInPackageId = new Guid("35882ed5-b82b-46d1-974a-718c2ed2f472"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("61d978b6-aa02-4c1c-93ba-8689cc50b2a0"),
				Name = "message",
				CreatedInSchemaUId = new Guid("61c36017-c6ff-42bf-a2dc-e8d28ab4e481"),
				ModifiedInSchemaUId = new Guid("61c36017-c6ff-42bf-a2dc-e8d28ab4e481"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("35882ed5-b82b-46d1-974a-718c2ed2f472")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("6b10f63d-c22b-4f14-b46f-da91d8e98fc8"),
				Name = "e",
				CreatedInSchemaUId = new Guid("61c36017-c6ff-42bf-a2dc-e8d28ab4e481"),
				ModifiedInSchemaUId = new Guid("61c36017-c6ff-42bf-a2dc-e8d28ab4e481"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Exception",
				CreatedInPackageId = new Guid("35882ed5-b82b-46d1-974a-718c2ed2f472")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,75,44,82,200,201,79,79,79,45,82,176,85,112,79,45,241,1,179,53,52,173,185,32,162,122,174,69,69,249,69,26,37,25,153,197,122,126,137,185,169,10,218,10,74,86,10,209,74,64,58,56,181,184,56,51,63,207,59,181,18,36,24,171,0,18,203,5,138,37,166,131,85,89,43,233,40,164,106,90,3,0,131,238,231,16,97,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetLoggerMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("998d222e-95a7-4fa7-96ae-03134231f511"),
				Name = "GetLogger",
				CreatedInSchemaUId = new Guid("61c36017-c6ff-42bf-a2dc-e8d28ab4e481"),
				CreatedInPackageId = new Guid("35882ed5-b82b-46d1-974a-718c2ed2f472"),
				ResultValueTypeName = "global::Common.Logging.ILog"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,142,77,10,194,48,20,132,215,230,20,143,174,146,77,14,208,210,149,148,32,214,20,172,23,136,24,107,32,63,146,164,74,17,239,110,26,90,93,185,154,247,96,102,190,121,8,15,218,13,131,244,80,67,219,49,214,28,65,4,24,180,59,11,93,150,91,103,140,179,180,77,14,101,7,186,75,71,133,212,21,240,154,169,193,142,90,19,120,161,205,183,230,79,56,233,65,88,145,60,148,201,216,102,55,142,55,21,40,23,70,146,10,109,22,126,189,44,170,208,59,179,66,244,25,30,120,66,117,190,49,247,56,225,94,134,160,156,221,203,137,100,250,239,79,121,54,170,11,229,242,57,43,38,244,228,250,92,129,11,94,144,185,213,203,56,122,187,98,62,183,168,15,183,4,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateDeleteOutdatedDataMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("c3a19e27-b010-44cd-8bc6-550d4b0f297b"),
				Name = "DeleteOutdatedData",
				CreatedInSchemaUId = new Guid("61c36017-c6ff-42bf-a2dc-e8d28ab4e481"),
				CreatedInPackageId = new Guid("196dac4c-8195-4488-a569-0010bfda9cdc"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("96c06f30-d70a-40c7-996f-8be019477bf7"),
				Name = "dayCount",
				CreatedInSchemaUId = new Guid("61c36017-c6ff-42bf-a2dc-e8d28ab4e481"),
				ModifiedInSchemaUId = new Guid("61c36017-c6ff-42bf-a2dc-e8d28ab4e481"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "int",
				CreatedInPackageId = new Guid("196dac4c-8195-4488-a569-0010bfda9cdc")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,84,209,110,218,48,20,125,14,18,255,96,241,228,72,149,69,223,166,117,76,42,16,38,36,166,118,148,173,143,147,137,239,138,53,199,78,109,167,5,85,252,251,174,227,4,66,52,77,125,24,130,144,220,220,156,115,124,238,113,86,210,249,79,82,251,207,100,91,169,223,89,193,165,90,47,133,35,19,162,225,149,172,218,187,52,189,25,14,94,184,37,249,14,242,216,246,173,2,123,104,250,30,64,65,238,233,119,7,118,102,180,198,115,105,116,58,28,36,108,102,84,85,104,58,66,208,81,93,88,88,83,208,209,180,37,139,197,199,29,88,160,41,203,246,72,232,40,150,146,228,159,184,248,97,27,83,210,235,246,162,229,105,104,66,41,50,125,229,90,88,169,212,26,114,89,74,208,254,116,63,146,158,165,212,18,217,210,101,207,21,87,93,137,87,36,202,175,165,222,89,1,118,122,184,117,57,46,170,197,156,153,42,0,19,238,26,201,232,214,112,224,209,159,55,124,166,114,82,63,17,58,159,102,123,200,43,111,44,17,219,211,233,132,92,174,142,101,218,85,22,230,211,115,137,166,105,141,211,2,45,231,220,243,53,112,20,66,108,252,155,116,32,89,60,129,216,65,123,19,99,95,192,63,60,171,13,236,61,77,175,106,43,250,29,247,220,242,2,60,88,215,18,39,175,59,169,128,208,200,198,2,242,73,84,146,92,36,135,221,10,209,27,24,155,79,55,135,18,176,240,2,22,97,241,250,7,87,21,108,204,82,251,22,19,101,213,69,58,78,211,16,54,196,61,134,99,56,224,239,72,114,238,243,29,161,217,62,135,50,160,18,104,4,172,204,83,102,173,177,116,180,64,13,32,136,55,68,106,233,37,87,68,160,83,228,23,218,156,43,192,244,122,40,74,18,148,6,31,61,223,42,112,56,93,8,124,199,48,49,236,4,30,88,48,243,23,27,2,1,47,55,72,228,198,111,216,20,14,93,7,113,111,77,14,2,103,215,110,138,203,106,207,20,12,149,119,229,207,57,198,197,67,27,210,187,202,163,98,16,97,192,163,218,133,30,52,123,148,126,119,154,15,237,74,122,71,187,224,135,58,169,233,77,80,222,198,243,255,229,51,233,132,112,102,138,2,87,181,145,5,152,202,35,204,245,135,241,56,206,181,47,178,201,43,61,63,29,3,80,143,254,29,115,119,222,226,2,216,194,216,130,251,110,10,68,109,46,105,82,128,175,131,191,5,128,145,238,27,224,35,121,27,31,49,19,23,206,54,17,169,115,56,28,252,1,158,243,67,123,51,5,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateProcessTriggerEmailsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("a488f38b-423a-48c9-a734-84522a1bc039"),
				Name = "ProcessTriggerEmails",
				CreatedInSchemaUId = new Guid("61c36017-c6ff-42bf-a2dc-e8d28ab4e481"),
				CreatedInPackageId = new Guid("196dac4c-8195-4488-a569-0010bfda9cdc"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("b60dbddb-cf7a-40ca-b7f9-0d6859902d49"),
				Name = "dayCount",
				CreatedInSchemaUId = new Guid("61c36017-c6ff-42bf-a2dc-e8d28ab4e481"),
				ModifiedInSchemaUId = new Guid("61c36017-c6ff-42bf-a2dc-e8d28ab4e481"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "int",
				CreatedInPackageId = new Guid("196dac4c-8195-4488-a569-0010bfda9cdc")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,145,65,75,195,64,16,133,207,17,252,15,67,79,91,40,161,222,68,241,96,107,132,130,130,104,197,163,140,187,99,92,76,118,203,236,68,173,210,255,238,36,209,198,234,197,203,102,119,152,55,239,203,155,23,100,120,104,170,231,162,70,95,165,133,75,112,2,139,224,197,99,213,151,150,241,138,163,181,148,146,185,68,126,38,241,161,156,199,144,36,229,75,246,101,73,76,174,235,156,125,79,153,163,80,25,121,189,112,227,227,253,189,199,200,132,246,9,140,15,50,56,93,47,28,248,176,235,60,134,143,253,189,76,120,221,125,179,23,37,75,162,106,215,2,144,107,152,148,45,208,43,220,236,86,205,109,34,86,164,64,86,124,12,19,24,73,90,221,159,90,105,176,242,239,244,69,121,169,46,138,126,77,214,175,60,5,73,163,150,46,203,126,89,228,119,94,158,174,144,177,38,33,54,63,129,255,211,239,112,61,143,77,144,190,183,73,234,8,230,108,86,188,145,109,84,8,238,97,123,61,129,93,238,188,8,73,7,158,205,134,146,25,247,153,100,217,160,203,231,177,174,49,184,165,175,41,54,162,99,14,14,167,211,206,238,15,91,175,33,51,168,123,174,141,30,27,176,40,237,94,138,55,75,171,214,13,232,203,237,34,150,5,115,100,147,132,245,7,242,243,200,53,138,25,157,107,14,228,64,34,84,17,29,56,20,108,31,219,197,47,145,75,18,208,141,131,244,161,3,117,203,205,135,30,205,241,8,62,166,155,209,4,58,228,157,128,39,138,208,2,42,223,230,19,120,80,227,171,153,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateProcessMassEmailsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("97e856b7-7a63-446f-b502-109f5a632dea"),
				Name = "ProcessMassEmails",
				CreatedInSchemaUId = new Guid("61c36017-c6ff-42bf-a2dc-e8d28ab4e481"),
				CreatedInPackageId = new Guid("196dac4c-8195-4488-a569-0010bfda9cdc"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("ce7241aa-abbd-42c2-a08c-3dd8c1d06bbf"),
				Name = "dayCount",
				CreatedInSchemaUId = new Guid("61c36017-c6ff-42bf-a2dc-e8d28ab4e481"),
				ModifiedInSchemaUId = new Guid("61c36017-c6ff-42bf-a2dc-e8d28ab4e481"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "int",
				CreatedInPackageId = new Guid("196dac4c-8195-4488-a569-0010bfda9cdc")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,146,65,107,219,64,16,133,207,10,228,63,12,62,173,193,200,46,244,80,26,114,168,109,5,12,53,9,137,74,143,97,178,59,181,150,72,187,102,118,148,198,13,254,239,157,141,218,168,110,47,189,72,218,199,204,188,239,141,246,9,25,30,250,246,177,234,208,183,105,227,18,92,194,38,120,241,216,14,82,29,111,56,90,75,41,153,45,242,35,137,15,187,85,12,73,82,185,197,148,114,141,42,203,223,35,86,40,180,139,124,216,184,233,197,249,217,183,200,132,182,1,227,131,140,54,183,27,7,62,156,218,78,225,229,252,172,16,62,188,190,139,249,124,94,95,175,175,161,174,238,106,120,15,210,232,28,101,235,72,154,232,160,33,166,92,245,164,240,73,212,195,101,70,114,61,147,226,7,250,14,119,167,170,249,146,136,149,58,144,21,31,195,12,38,146,246,247,159,172,244,216,250,31,148,131,108,135,32,183,100,253,222,83,144,52,201,1,138,226,175,249,229,87,47,205,13,50,42,10,177,249,51,211,255,212,59,60,172,98,31,100,168,237,147,58,130,89,47,171,103,178,189,54,130,123,120,251,188,132,83,232,178,10,73,7,174,151,163,100,166,195,218,138,98,236,43,87,177,235,48,184,218,119,20,123,209,49,239,62,44,22,175,118,255,176,13,61,100,198,238,129,235,168,143,35,88,148,252,235,170,103,75,251,236,6,244,203,237,115,220,85,204,145,77,18,214,0,229,85,228,14,197,76,174,116,15,228,64,34,180,17,29,56,20,204,135,183,187,81,35,239,72,202,81,208,165,125,132,151,197,113,50,59,185,28,211,153,90,101,16,229,56,254,4,193,43,42,32,161,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateInitialEmailsToProccessMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("921c066d-a600-4bf9-8829-cd6a6ef96b9f"),
				Name = "InitialEmailsToProccess",
				CreatedInSchemaUId = new Guid("61c36017-c6ff-42bf-a2dc-e8d28ab4e481"),
				CreatedInPackageId = new Guid("196dac4c-8195-4488-a569-0010bfda9cdc"),
				ResultValueTypeName = "List<int>"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("8be56cf3-11fa-41dc-b1a5-0d3737f5c353"),
				Name = "emailCategoryId",
				CreatedInSchemaUId = new Guid("61c36017-c6ff-42bf-a2dc-e8d28ab4e481"),
				ModifiedInSchemaUId = new Guid("61c36017-c6ff-42bf-a2dc-e8d28ab4e481"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("196dac4c-8195-4488-a569-0010bfda9cdc")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,84,93,111,155,48,20,125,38,82,254,131,149,39,35,85,206,246,220,101,82,72,200,20,41,81,187,66,183,103,7,110,137,85,199,166,246,37,77,52,245,191,239,242,17,74,54,109,15,69,2,204,181,239,185,199,247,28,179,81,30,191,40,131,95,217,174,210,207,241,65,42,253,176,206,61,155,49,3,175,108,115,153,229,225,237,120,52,157,78,89,122,183,188,99,137,117,200,118,103,230,32,83,165,2,131,158,101,182,50,200,158,172,99,59,85,176,92,162,28,143,142,210,49,168,17,253,247,10,220,185,195,76,64,67,134,252,209,131,91,88,99,104,172,172,9,199,163,64,44,172,174,14,134,79,136,192,164,9,172,156,61,240,73,116,33,214,6,127,238,193,1,45,2,95,90,227,225,222,217,12,188,87,166,88,216,67,169,1,129,146,197,218,199,47,149,212,188,133,20,247,210,201,3,77,57,254,36,181,135,176,1,154,155,156,79,22,18,161,176,238,188,254,111,86,179,139,247,165,131,252,4,37,86,190,205,54,156,194,193,95,201,91,233,158,1,27,130,198,163,23,253,126,218,220,149,50,202,239,33,39,216,155,143,228,39,104,203,242,227,233,115,234,255,17,134,123,10,69,124,34,221,61,255,183,90,34,181,37,255,28,246,138,117,130,209,213,105,182,149,38,119,74,235,132,204,177,37,121,100,1,212,161,78,186,104,224,180,65,215,7,66,223,176,214,4,33,147,190,163,64,254,67,242,208,47,42,83,213,106,51,190,140,226,19,100,21,146,231,242,93,63,156,177,107,174,34,54,190,114,176,140,222,67,156,112,107,156,11,208,122,73,118,125,0,153,131,35,75,55,175,217,0,82,180,3,104,87,240,129,163,197,55,192,228,69,167,112,66,222,118,63,24,206,246,26,248,75,193,224,117,175,52,48,222,86,17,53,98,79,38,8,174,78,160,152,231,249,31,109,23,203,40,61,151,64,129,35,56,130,165,239,31,82,87,144,218,181,193,11,38,81,106,130,252,83,24,214,135,150,112,223,234,103,253,160,251,141,101,18,179,61,227,241,41,131,178,70,101,208,17,216,216,34,118,206,58,62,89,17,7,200,25,90,70,222,68,37,117,115,160,155,211,173,173,204,235,166,209,92,47,87,42,93,1,72,162,65,93,144,138,56,192,202,153,235,63,202,237,111,177,141,37,1,106,4,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override Process CreateProcess(UserConnection userConnection) {
			return new ActualizeBulkEmailRecipients(userConnection);
		}

		public override object Clone() {
			return new ActualizeBulkEmailRecipientsSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("61c36017-c6ff-42bf-a2dc-e8d28ab4e481"));
		}

		#endregion

	}

	#endregion

	#region Class: ActualizeBulkEmailRecipients

	/// <exclude/>
	public class ActualizeBulkEmailRecipients : Terrasoft.Core.Process.Process
	{

		#region Class: ProcessLane1

		/// <exclude/>
		public class ProcessLane1 : ProcessLane
		{

			public ProcessLane1(UserConnection userConnection, ActualizeBulkEmailRecipients process)
				: base(userConnection) {
				Owner = process;
				IsUsedParentUserContexts = false;
			}

		}

		#endregion

		public ActualizeBulkEmailRecipients(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ActualizeBulkEmailRecipients";
			SchemaUId = new Guid("61c36017-c6ff-42bf-a2dc-e8d28ab4e481");
			Caption = Schema.Caption;
			SchemaManagerName = "ProcessSchemaManager";
			SerializeToDB = false;
			SerializeToMemory = false;
			IsLogging = false;
			UseSystemSecurityContext = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("61c36017-c6ff-42bf-a2dc-e8d28ab4e481");
			}
		}

		private string ConditionalExpressionLogMessage {
			get {
				return "Process: ActualizeBulkEmailRecipients, Source element: {0}, Conditional flow: {1}, Expression: {2}, Result: {3}";
			}
		}

		private string DeadEndGatewayLogMessage {
			get {
				return "Process: ActualizeBulkEmailRecipients, Source element: {0}, None of the exclusive gateway conditions are met!";
			}
		}

		#endregion

		#region Properties: Public

		public virtual string SessionKey {
			get;
			set;
		}

		public virtual Object LOGGER {
			get;
			set;
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
					SchemaElementUId = new Guid("77f33242-6f7d-4ced-8c74-7346cfe812d0"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
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
					SchemaElementUId = new Guid("d3d157f1-a25d-44fb-a96d-539664c943d0"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptMain;
		public ProcessScriptTask ScriptMain {
			get {
				return _scriptMain ?? (_scriptMain = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptMain",
					SchemaElementUId = new Guid("af84af2a-d656-4916-8437-11132ba775d9"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					Script = ScriptMainExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[Start1.SchemaElementUId] = new Collection<ProcessFlowElement> { Start1 };
			FlowElements[Terminate1.SchemaElementUId] = new Collection<ProcessFlowElement> { Terminate1 };
			FlowElements[ScriptMain.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptMain };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "Start1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ScriptMain", e.Context.SenderName));
						break;
					case "Terminate1":
						CompleteProcess();
						break;
					case "ScriptMain":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("Terminate1", e.Context.SenderName));
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
			MetaPathParameterValues.Add("ccf30a79-ff5e-451c-98a5-2d4d6cf1299a", () => SessionKey);
			MetaPathParameterValues.Add("4449f3bb-5841-48c7-a613-6d90a9b7f456", () => LOGGER);
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
			}
		}

		protected override void WritePropertyValues(DataWriter writer) {
			base.WritePropertyValues(writer);
			WritePropertyValues(writer, true);
		}

		#endregion

		#region Methods: Public

		public virtual bool ScriptMainExecute(ProcessExecutingContext context) {
			Main();
			return true;
		}

		public virtual void Main() {
			///TODO may be there is sence to use def value if count equals zero 
			var dayCount = (int)Terrasoft.Core.Configuration.SysSettings.
				GetValue(UserConnection, "MandrillStatisticUpdatePeriodDays");
			ProcessTriggerEmails(dayCount);
			ProcessMassEmails(dayCount);
			DeleteOutdatedData(dayCount);
		}

		public virtual void LogError(string message, Exception e) {
			var logger = GetLogger();
			logger.Error(this.Name + ": [" + SessionKey + "] " + message + ";", e);
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

		public virtual void DeleteOutdatedData(int dayCount) {
			List<int> bulkEmailRIds = new List<int>();
			var checkEmailQuery = new Select(UserConnection)
				.Column("RId")
				.From("BulkEmail")
				.Where().Exists(
						new Select(UserConnection)
							.Top(1)
							.Column("Id")
							.From("MandrillRecipient")
							.Where("BulkEmailRId").IsEqual("BulkEmail", "RId"))
				.OrderByAsc("RecipientCount") as Select;
			
			try {
				using (DBExecutor dbExecutor = UserConnection.EnsureDBConnection()) {
					using (IDataReader reader = dbExecutor.ExecuteReader(checkEmailQuery.GetSqlText(),
						checkEmailQuery.Parameters)) {
						while (reader.Read()) {
							bulkEmailRIds.Add(UserConnection.DBTypeConverter.DBValueToInt(reader.GetValue(0)));
						}
					}
				}
			} catch (Exception e) {
					LogError("Failed to initial data for clear temp mailing tables", e);
			}
			
			foreach (int bulkEmailRId in bulkEmailRIds) {
				
				var storedProcedure = new StoredProcedure(UserConnection, "tsp_DeleteMandrillOutdatedData");
				storedProcedure.WithParameter(bulkEmailRId);
				storedProcedure.WithParameter(dayCount);	
				try {
					using (DBExecutor dbExecutor = UserConnection.EnsureDBConnection()) {
						dbExecutor.CommandTimeout = 1800;
						storedProcedure.Execute(dbExecutor);
					}
				} catch (Exception e) {
					LogError(string.Format("Failed to delete  data from temp mailing tables. BulkEmailRId: {0}", bulkEmailRId), e);
				}
			}
		}

		public virtual void ProcessTriggerEmails(int dayCount) {
			var bulkEmailsIds = InitialEmailsToProccess(MarketingConsts.TriggeredEmailBulkEmailCategoryId);
			foreach (int bulkEmailRId in bulkEmailsIds) {
				try {
					var storedProcedure = new StoredProcedure(UserConnection, "tsp_ActualizeTriggerMailingRecipients");
					storedProcedure.WithParameter(bulkEmailRId);
					storedProcedure.WithParameter(dayCount);
					using (DBExecutor dbExecutor = UserConnection.EnsureDBConnection()) {
						dbExecutor.CommandTimeout = 1800;
						storedProcedure.Execute(dbExecutor);
					}
				} catch (Exception e) {
					LogError(string.Format("Failed to load data to BulkEmailTarget for trigger emails. BulkEmailRId: {0}", 
						bulkEmailRId), e);
				}
			}
		}

		public virtual void ProcessMassEmails(int dayCount) {
			var bulkEmailsIds = InitialEmailsToProccess(MarketingConsts.MassmailingBulkEmailCategoryId);
			foreach (int bulkEmailRId in bulkEmailsIds) {
				try {
					///TODO TEST 4 threads method here
					var storedProcedure = new StoredProcedure(UserConnection, "tsp_ActualizeMassMailingRecipients");
					storedProcedure.WithParameter(bulkEmailRId);
					storedProcedure.WithParameter(dayCount);
					using (DBExecutor dbExecutor = UserConnection.EnsureDBConnection()) {
						dbExecutor.CommandTimeout = 1800;
						storedProcedure.Execute(dbExecutor);
					}
				} catch (Exception e) {
					LogError(string.Format("Failed to load data to BulkEmailTarget. BulkEmailRId: {0}", bulkEmailRId), e);
				}
			}
		}

		public virtual List<int> InitialEmailsToProccess(Guid emailCategoryId) {
			List<int> bulkEmailRIds = new List<int>();
			/// TODO Sort by recipients count for big data
			var emailsQuery = new Select(UserConnection)
				.Column("RId")
				.From("BulkEmail")
				.Where("ResponseProcessingCompleted").IsEqual(Column.Parameter(false))
				.And("CategoryId").IsEqual(Column.Parameter(emailCategoryId))
				.And("StatusId").In(
					Column.Parameter(MarketingConsts.BulkEmailStatusFinishedId),
					Column.Parameter(MarketingConsts.BulkEmailStatusStoppedId),
					Column.Parameter(MarketingConsts.BulkEmailStatusActiveId))
				.And().Exists(new Select(UserConnection).Top(1).Column("Id")
							.From("MandrillSentMessage").Where("BulkEmailRId").IsEqual("BulkEmail", "RId")) as Select;
			try {
				using (DBExecutor dbExecutor = UserConnection.EnsureDBConnection()) {
					using (IDataReader reader = dbExecutor.ExecuteReader(emailsQuery.GetSqlText(),
						emailsQuery.Parameters)) {
						while (reader.Read()) {
							bulkEmailRIds.Add(UserConnection.DBTypeConverter.DBValueToInt(reader.GetValue(0)));
						}
					}
				}
			} catch (Exception e) {
					LogError("Failed to initial data for loading to BulkEmailTarget", e);
			}
			return bulkEmailRIds;
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
			var cloneItem = (ActualizeBulkEmailRecipients)base.CloneShallow();
			cloneItem.ExecutedEventHandler = ExecutedEventHandler;
			cloneItem.LOGGER = LOGGER;
			return cloneItem;
		}

		#endregion

	}

	#endregion

}

