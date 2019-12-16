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
	using Terrasoft.Configuration.MandrillService;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;
	using TSConfiguration = Terrasoft.Configuration;

	#region Class: UpdateEmailAnaliticsProcessSchema

	/// <exclude/>
	public class UpdateEmailAnaliticsProcessSchema : Terrasoft.Core.Process.ProcessSchema
	{

		#region Constructors: Public

		public UpdateEmailAnaliticsProcessSchema(ProcessSchemaManager processSchemaManager)
			: base(processSchemaManager) {
		}

		public UpdateEmailAnaliticsProcessSchema(UpdateEmailAnaliticsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "UpdateEmailAnaliticsProcess";
			UId = new Guid("1dd85556-3227-499f-af34-bab27dfa7f41");
			CreatedInPackageId = new Guid("37b787ac-5e4e-4031-9f78-6e5fdb456414");
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
			ZipCompiledMethodsBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,197,87,91,79,227,56,20,126,46,18,255,193,202,147,171,173,34,237,236,195,74,12,29,9,74,161,213,118,10,162,176,243,128,208,202,77,220,214,75,106,7,219,1,58,43,254,251,30,95,146,38,105,202,6,180,179,43,36,146,218,231,242,249,59,23,159,28,30,164,217,60,97,17,122,98,82,103,36,65,79,130,197,232,43,97,28,119,209,95,135,7,157,137,88,142,249,66,224,224,206,44,222,31,161,153,38,82,211,56,12,186,159,97,251,36,50,90,236,59,157,10,238,222,7,130,107,18,233,225,154,176,68,225,170,208,153,152,10,125,171,168,221,60,23,210,203,122,177,219,52,38,154,158,102,201,131,221,7,71,154,41,205,162,198,221,147,56,102,154,9,78,234,114,59,128,207,25,103,106,149,35,126,61,60,48,127,77,167,222,239,223,50,161,229,198,62,59,87,82,68,84,169,89,180,162,107,130,148,123,244,145,217,234,192,225,204,169,56,141,12,184,176,34,250,149,112,178,164,50,188,160,122,204,149,38,60,162,167,155,41,89,83,28,236,115,237,245,29,215,185,99,148,250,103,223,59,15,7,146,130,186,223,198,85,12,78,213,171,132,195,23,26,101,154,54,201,188,162,136,232,104,133,240,240,37,162,169,89,70,180,107,15,12,148,14,165,20,18,56,221,7,244,62,232,129,180,53,243,30,142,27,163,88,101,155,113,141,86,34,3,180,25,188,245,17,176,55,130,159,201,102,176,130,68,28,229,59,46,248,157,241,144,103,107,42,201,60,161,199,160,249,5,205,115,87,215,227,88,57,245,111,44,73,106,56,204,166,183,176,16,64,102,180,194,198,111,89,25,49,94,53,230,112,118,124,98,142,54,41,149,9,227,15,106,0,135,134,255,22,84,89,193,153,247,226,78,232,50,165,92,217,115,156,17,77,42,210,189,237,161,43,138,5,228,91,206,30,51,186,165,109,215,213,235,7,131,218,16,148,182,225,109,81,233,213,232,66,77,196,210,196,67,179,4,156,210,34,67,103,26,226,16,219,148,142,51,89,79,216,30,10,180,74,255,104,118,23,180,79,231,127,196,219,246,224,133,77,165,37,227,75,180,134,98,131,98,239,161,178,119,123,228,39,34,81,34,150,208,8,92,54,78,236,187,75,62,183,30,58,75,122,197,84,104,218,3,250,9,5,71,232,46,128,231,12,204,130,173,223,232,198,44,222,35,179,230,93,153,133,207,57,218,183,145,218,254,88,5,218,26,155,213,253,16,180,253,184,150,137,152,147,228,232,104,32,214,107,104,154,198,43,64,11,199,240,82,70,177,11,113,114,121,113,49,188,70,68,189,101,194,128,103,11,132,115,173,62,226,89,146,248,234,45,76,237,49,0,207,82,219,246,72,138,227,187,58,243,40,250,30,151,79,22,235,211,145,28,142,213,20,92,94,202,225,58,213,27,188,101,170,235,81,148,184,3,222,51,22,135,83,250,108,158,184,27,222,136,153,53,130,131,105,144,39,98,71,82,157,73,190,117,216,166,36,247,221,208,255,102,65,186,78,210,236,233,35,101,217,108,169,69,81,238,220,3,111,245,253,34,177,20,77,224,56,16,3,78,159,33,161,205,143,250,77,105,144,134,3,145,100,107,142,3,80,15,220,202,185,20,107,28,20,118,253,234,183,21,5,166,2,211,70,51,101,100,161,124,176,83,14,175,136,132,12,210,84,42,108,188,137,249,159,224,225,238,222,95,42,55,51,240,185,96,203,76,18,59,72,124,37,242,129,106,72,3,88,86,90,133,149,27,56,83,249,140,3,247,198,71,212,33,182,105,250,97,109,136,16,123,162,227,216,222,57,221,110,120,194,77,222,14,95,224,230,80,216,26,124,155,206,45,161,158,154,217,99,114,67,95,52,100,252,237,100,18,116,115,33,199,113,158,160,215,52,98,41,163,92,7,249,190,103,187,28,92,195,184,26,62,66,70,148,130,213,53,13,195,193,49,57,52,130,252,80,35,154,192,253,29,206,82,176,186,216,76,197,68,68,15,118,3,187,156,232,33,45,51,151,115,62,87,36,85,89,146,231,202,4,206,106,243,12,231,34,153,50,221,21,159,157,186,242,17,18,197,243,226,181,143,106,115,226,144,43,168,169,179,211,237,18,206,123,131,55,52,54,19,194,53,37,49,53,174,237,163,239,243,53,175,80,183,139,183,126,114,19,118,134,146,227,216,209,59,230,49,125,1,101,103,197,180,181,75,25,51,94,80,228,166,141,231,21,75,40,194,94,200,152,46,16,57,123,149,217,168,108,109,204,245,47,159,112,213,157,55,218,113,164,133,48,97,52,141,70,175,197,212,226,56,244,93,206,41,181,153,221,155,135,176,58,218,31,208,241,26,29,7,189,34,249,161,179,255,78,146,140,94,17,38,143,221,165,208,243,37,255,5,7,101,112,208,218,42,88,223,59,154,55,34,121,223,116,222,56,155,214,73,236,161,202,96,254,3,56,109,130,209,154,210,211,55,40,109,107,195,124,91,228,145,44,157,244,189,17,105,58,71,139,128,24,122,247,126,235,88,150,35,211,141,173,92,76,23,4,74,100,84,250,76,250,245,147,157,123,106,31,79,38,140,221,27,42,37,81,98,161,161,237,74,26,86,123,253,108,163,102,84,155,102,175,76,49,91,122,108,19,223,137,84,65,177,131,184,253,102,165,146,9,223,71,204,12,180,245,127,140,126,246,45,164,140,169,14,190,54,227,172,74,235,237,63,44,235,95,71,255,65,15,216,231,251,127,105,3,251,192,236,38,222,223,61,195,136,19,2,18,0,0 };
			RealUId = new Guid("1dd85556-3227-499f-af34-bab27dfa7f41");
			Version = 0;
			PackageUId = new Guid("789c617e-760f-4576-a608-ee12728eae0a");
		}

		protected virtual ProcessSchemaParameter CreateLOGGERParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("231071ea-6643-4898-b33f-fe82c1526d35"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("1dd85556-3227-499f-af34-bab27dfa7f41"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("1dd85556-3227-499f-af34-bab27dfa7f41"),
				Name = @"LOGGER",
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			};
		}

		protected virtual ProcessSchemaParameter CreateSessionKeyParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("30944bf2-810c-4ad1-9ce6-01558b20047e"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("1dd85556-3227-499f-af34-bab27dfa7f41"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("1dd85556-3227-499f-af34-bab27dfa7f41"),
				Name = @"SessionKey",
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
			ProcessSchemaStartEvent start1 = CreateStart1StartEvent();
			FlowElements.Add(start1);
			ProcessSchemaTerminateEvent terminate1 = CreateTerminate1TerminateEvent();
			FlowElements.Add(terminate1);
			ProcessSchemaScriptTask mainscripttask = CreateMainScriptTaskScriptTask();
			FlowElements.Add(mainscripttask);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("1418531f-a63d-4ad5-9116-b42ff97174f6"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("37b787ac-5e4e-4031-9f78-6e5fdb456414"),
				CreatedInSchemaUId = new Guid("1dd85556-3227-499f-af34-bab27dfa7f41"),
				CurveCenterPosition = new Point(373, 203),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("1dd85556-3227-499f-af34-bab27dfa7f41"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("1fae9bb1-7179-4e6f-bc70-4fbd630d6a16"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("b948883d-49cc-436b-9a6c-e02d5971d5ee"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("ce8c5fda-5c2a-4680-8509-b7549bfb29c1"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("37b787ac-5e4e-4031-9f78-6e5fdb456414"),
				CreatedInSchemaUId = new Guid("1dd85556-3227-499f-af34-bab27dfa7f41"),
				CurveCenterPosition = new Point(373, 203),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("1dd85556-3227-499f-af34-bab27dfa7f41"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("b948883d-49cc-436b-9a6c-e02d5971d5ee"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("89d38304-7be6-4b99-9a47-f637b0ef69c4"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("4d4df1b5-735b-4be3-8f99-3bc85abc2611"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("37b787ac-5e4e-4031-9f78-6e5fdb456414"),
				CreatedInSchemaUId = new Guid("1dd85556-3227-499f-af34-bab27dfa7f41"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("1dd85556-3227-499f-af34-bab27dfa7f41"),
				Name = @"LaneSet1",
				Position = new Point(5, 5),
				Size = new Size(0, 0)
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("1b46e01f-8c20-4efe-ab42-bc6bc456295d"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("4d4df1b5-735b-4be3-8f99-3bc85abc2611"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("37b787ac-5e4e-4031-9f78-6e5fdb456414"),
				CreatedInSchemaUId = new Guid("1dd85556-3227-499f-af34-bab27dfa7f41"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("1dd85556-3227-499f-af34-bab27dfa7f41"),
				Name = @"Lane1",
				Position = new Point(29, 0),
				Size = new Size(0, 0)
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaStartEvent CreateStart1StartEvent() {
			ProcessSchemaStartEvent schemaStartEvent = new ProcessSchemaStartEvent(this) {
				UId = new Guid("1fae9bb1-7179-4e6f-bc70-4fbd630d6a16"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1b46e01f-8c20-4efe-ab42-bc6bc456295d"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("37b787ac-5e4e-4031-9f78-6e5fdb456414"),
				CreatedInSchemaUId = new Guid("1dd85556-3227-499f-af34-bab27dfa7f41"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsInterrupting = false,
				IsLogging = true,
				ManagerItemUId = new Guid("53818048-7868-48f6-ada0-0ebaa65af628"),
				ModifiedInSchemaUId = new Guid("1dd85556-3227-499f-af34-bab27dfa7f41"),
				Name = @"Start1",
				Position = new Point(50, 184),
				SerializeToDB = false,
				Size = new Size(27, 27)
			};
			
			return schemaStartEvent;
		}

		protected virtual ProcessSchemaTerminateEvent CreateTerminate1TerminateEvent() {
			ProcessSchemaTerminateEvent schemaTerminateEvent = new ProcessSchemaTerminateEvent(this) {
				UId = new Guid("89d38304-7be6-4b99-9a47-f637b0ef69c4"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1b46e01f-8c20-4efe-ab42-bc6bc456295d"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("37b787ac-5e4e-4031-9f78-6e5fdb456414"),
				CreatedInSchemaUId = new Guid("1dd85556-3227-499f-af34-bab27dfa7f41"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = true,
				ManagerItemUId = new Guid("1bd93619-0574-454e-bb4e-cf53b9eb9470"),
				ModifiedInSchemaUId = new Guid("1dd85556-3227-499f-af34-bab27dfa7f41"),
				Name = @"Terminate1",
				Position = new Point(600, 184),
				SerializeToDB = false,
				Size = new Size(27, 27),
				ThrowToBase = false
			};
			
			return schemaTerminateEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateMainScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("b948883d-49cc-436b-9a6c-e02d5971d5ee"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1b46e01f-8c20-4efe-ab42-bc6bc456295d"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("37b787ac-5e4e-4031-9f78-6e5fdb456414"),
				CreatedInSchemaUId = new Guid("1dd85556-3227-499f-af34-bab27dfa7f41"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("1dd85556-3227-499f-af34-bab27dfa7f41"),
				Name = @"MainScriptTask",
				Position = new Point(274, 170),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,243,77,204,204,211,208,180,230,229,42,74,45,41,45,202,83,40,41,42,77,181,6,0,176,217,148,41,21,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("3c147ea6-a9b7-4999-ba05-f1062ef362f0"),
				Name = "Terrasoft.Configuration.MandrillService",
				Alias = "",
				CreatedInPackageId = new Guid("37b787ac-5e4e-4031-9f78-6e5fdb456414")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e8084a72-4766-41d9-877f-c004b422c728"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("37b787ac-5e4e-4031-9f78-6e5fdb456414")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("99c65a0f-7413-4117-a3f0-a052941ee8eb"),
				Name = "Terrasoft.Configuration",
				Alias = "TSConfiguration",
				CreatedInPackageId = new Guid("37b787ac-5e4e-4031-9f78-6e5fdb456414")
			});
		}

		#endregion

		#region Methods: Public

		public override Process CreateProcess(UserConnection userConnection) {
			return new UpdateEmailAnaliticsProcess(userConnection);
		}

		public override object Clone() {
			return new UpdateEmailAnaliticsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("1dd85556-3227-499f-af34-bab27dfa7f41"));
		}

		#endregion

	}

	#endregion

	#region Class: UpdateEmailAnaliticsProcess

	/// <exclude/>
	public class UpdateEmailAnaliticsProcess : Terrasoft.Core.Process.Process
	{

		#region Class: ProcessLane1

		/// <exclude/>
		public class ProcessLane1 : ProcessLane
		{

			public ProcessLane1(UserConnection userConnection, UpdateEmailAnaliticsProcess process)
				: base(userConnection) {
				Owner = process;
				IsUsedParentUserContexts = false;
			}

		}

		#endregion

		public UpdateEmailAnaliticsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "UpdateEmailAnaliticsProcess";
			SchemaUId = new Guid("1dd85556-3227-499f-af34-bab27dfa7f41");
			Caption = Schema.Caption;
			SchemaManagerName = "ProcessSchemaManager";
			SerializeToDB = false;
			SerializeToMemory = false;
			IsLogging = false;
			_notificationCaption = () => { return new LocalizableString((Caption)); };
			InitializeFlowElements();
		}

		#region Properties: Private

		private  Guid InternalSchemaUId {
			get {
				return new Guid("1dd85556-3227-499f-af34-bab27dfa7f41");
			}
		}

		#endregion

		#region Properties: Public

		private Func<string> _notificationCaption;
		public  virtual string NotificationCaption {
			get {
				return (_notificationCaption ?? (_notificationCaption = () => null)).Invoke();
			}
			set {
				_notificationCaption = () => { return value; };
			}
		}

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

		private ProcessFlowElement _start1;
		public  ProcessFlowElement Start1 {
			get {
				return _start1 ?? (_start1 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartEvent",
					Name = "Start1",
					SchemaElementUId = new Guid("1fae9bb1-7179-4e6f-bc70-4fbd630d6a16"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
				});
			}
		}

		private ProcessTerminateEvent _terminate1;
		public  ProcessTerminateEvent Terminate1 {
			get {
				return _terminate1 ?? (_terminate1 = new ProcessTerminateEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaTerminateEvent",
					Name = "Terminate1",
					SchemaElementUId = new Guid("89d38304-7be6-4b99-9a47-f637b0ef69c4"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
				});
			}
		}

		private ProcessScriptTask _mainScriptTask;
		public  ProcessScriptTask MainScriptTask {
			get {
				return _mainScriptTask ?? (_mainScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "MainScriptTask",
					SchemaElementUId = new Guid("b948883d-49cc-436b-9a6c-e02d5971d5ee"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
					Script = MainScriptTaskExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[Start1.SchemaElementUId] = new Collection<ProcessFlowElement> { Start1 };
			FlowElements[Terminate1.SchemaElementUId] = new Collection<ProcessFlowElement> { Terminate1 };
			FlowElements[MainScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { MainScriptTask };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "Start1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("MainScriptTask", e.Context.SenderName));
						break;
					case "Terminate1":
						CompleteProcess();
						break;
					case "MainScriptTask":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("Terminate1", e.Context.SenderName));
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
			MetaPathParameterValues.Add("231071ea-6643-4898-b33f-fe82c1526d35", () => LOGGER);
			MetaPathParameterValues.Add("30944bf2-810c-4ad1-9ce6-01558b20047e", () => SessionKey);
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

		public virtual bool MainScriptTaskExecute(ProcessExecutingContext context) {
			Main();
			return true;
		}

			
			public virtual void Main() {
				LogInfo("[Main]: Started.");
				ActualizeNonActualContactEmails();
				ActualizeDoNotUseEmailForContacts();
				UpdateBulkEmailStatistic();
				UpdateBulkEmailAdditionalStatistic();
				LogInfo("[Main]: Finished.");
			}
			
			
			public virtual void UpdateBulkEmailStatistic() {
				try {
					ProcessSchema schema = 
						UserConnection.ProcessSchemaManager.GetInstanceByName("UpdateBulkEmailStatisticProcess");
					Process process = schema.CreateProcess(UserConnection);
					process.Execute(UserConnection);
				} catch (Exception e){
					LogError("[UpdateBulkEmailStatistic]", e);
				}
			}
			
			
			public virtual void UpdateBulkEmailAdditionalStatistic() {
				try {
					int hourCount = GetHourlyChartHourCount();
					IEnumerable<int> bulkEmailRIds = GetWillUpdateBulkEmailRIds();
					foreach(int bulkEmailRId in bulkEmailRIds) {
						UpdateHyperlinksClicksCount(bulkEmailRId);
						UpdateClicksOpensChartData(bulkEmailRId, hourCount);
						UpdateBulkEmailUniqueStatistic(bulkEmailRId);
					}
				} catch (Exception e){
					LogError("[UpdateBulkEmailAdditionalStatistic]", e);
				}
			}
			
			
			public virtual void ActualizeDoNotUseEmailForContacts() {
				try {
					MandrillUtilities.ExecuteStoredProcedure(UserConnection, "tsp_ActualizeDoNotUseEmail");
				} catch (Exception e){
					LogError("[ActualizeDoNotUseEmailForContacts]", e);
				}
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
			
			
			public virtual void ActualizeNonActualContactEmails() {
				try {
					MandrillUtilities.ExecuteStoredProcedure(UserConnection, "tsp_UpdateNonActualContactEmails");
				} catch (Exception e){
					LogError("[ActualizeNonActualContactEmails]", e);
				}
			}
			
			
			public virtual IEnumerable<int> GetWillUpdateBulkEmailRIds() {
				var select = new Select(UserConnection)
					.Column("RId")
					.From("BulkEmail")
					.Where("StatusId").In(Column.Parameters(new object[] {
						TSConfiguration.MarketingConsts.BulkEmailStatusFinishedId,
						TSConfiguration.MarketingConsts.BulkEmailStatusStoppedId,
						TSConfiguration.MarketingConsts.BulkEmailStatusActiveId
					})).And().Exists(
						new Select(UserConnection)
							.Column(Column.SqlText("NULL"))
							.From("MandrillRecipient")
							.Where("BulkEmailRId").IsEqual("RId")
					) as Select;
				HintsHelper.SpecifyNoLockHints(select, true);
				
				var result = new List<int>();
				
				using (DBExecutor dbExecutor = UserConnection.EnsureDBConnection()) {
					using (IDataReader reader = select.ExecuteReader(dbExecutor)) {
						int rIdColumnIndex = reader.GetOrdinal("RId");
						while (reader.Read()) {
							int bulkEmailRId = reader.GetInt32(rIdColumnIndex);
							result.Add(bulkEmailRId);
						}
					}
				}
				
				return result;
			}
			
			
			public virtual void UpdateHyperlinksClicksCount(int bulkEmailRId) {
				try {
					MandrillUtilities.ExecuteStoredProcedure(UserConnection, "tsp_UpdateHyperlinksClicksCount",
						new KeyValuePair<string, object>("bulkEmailRId", bulkEmailRId));
				} catch (Exception e){
					LogError("[UpdateHyperlinksClicksCount]", e);
				}
			}
			
			
			public virtual void UpdateClicksOpensChartData(int bulkEmailRId, int hourCount) {
				try {
					MandrillUtilities.ExecuteStoredProcedure(UserConnection, "tsp_UpdateClicksOpensChartData",
						new KeyValuePair<string, object>("BulkEmailRId", bulkEmailRId),
						new KeyValuePair<string, object>("HoursCount", hourCount));
				} catch (Exception e){
					LogError("[UpdateClicksOpensChartData]", e);
				}
			}
			
			
			public virtual int GetHourlyChartHourCount() {
				const int defaultHourCount = 72;
				int hourCount = (int)Terrasoft.Core.Configuration.SysSettings.GetValue(
					UserConnection, "BulkEmailHourlyStatisticPeriod");
				if (hourCount < 1) {
					hourCount = defaultHourCount;
				}
				return hourCount;
			}
			
			
			public virtual void UpdateBulkEmailUniqueStatistic(int bulkEmailRId) {
				try {
					MandrillUtilities.ExecuteStoredProcedure(UserConnection, "tsp_UpdateBulkEmailUniqueStatistic",
						new KeyValuePair<string, object>("bulkEmailRId", bulkEmailRId));
				} catch (Exception e){
					LogError("[UpdateBulkEmailUniqueStatistic]", e);
				}
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
			var cloneItem = (UpdateEmailAnaliticsProcess)base.CloneShallow();
			cloneItem.ExecutedEventHandler = ExecutedEventHandler;
			cloneItem.LOGGER = LOGGER;
			return cloneItem;
		}

		#endregion

	}

	#endregion

}

