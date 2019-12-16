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
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;

	#region Class: SatisfactionUpdateProcessSchema

	/// <exclude/>
	public class SatisfactionUpdateProcessSchema : Terrasoft.Core.Process.ProcessSchema
	{

		#region Constructors: Public

		public SatisfactionUpdateProcessSchema(ProcessSchemaManager processSchemaManager)
			: base(processSchemaManager) {
		}

		public SatisfactionUpdateProcessSchema(SatisfactionUpdateProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "SatisfactionUpdateProcess";
			UId = new Guid("92753ebc-e72e-41f5-8d5a-68c4b7974bca");
			CreatedInPackageId = new Guid("9141d462-7675-4656-8ea8-25b81010cd22");
			CreatedInSchemaUId = Guid.Empty;
			CreatedInVersion = @"0.0.0.0";
			CultureName = @"en-US";
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsLogging = false;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			SerializeToDB = false;
			SerializeToMemory = true;
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
			ZipMethodsBody = new byte[] {  };
			ZipCompiledMethodsBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,144,221,106,131,64,16,133,175,21,124,135,173,87,43,136,47,144,54,16,210,144,139,164,144,96,219,251,173,142,205,192,186,202,254,88,164,244,221,187,63,45,209,68,216,155,101,230,156,239,204,73,226,222,124,112,172,200,128,82,27,198,201,51,86,26,59,193,228,248,136,66,231,100,111,176,94,147,61,232,235,160,100,26,85,195,252,247,8,3,112,154,145,239,36,142,6,38,201,174,60,147,39,34,224,139,236,132,70,61,150,213,5,90,118,54,32,71,250,166,64,110,59,33,192,43,139,233,194,11,19,236,19,100,78,210,59,243,52,91,37,177,181,45,54,117,189,225,60,236,111,59,110,90,161,168,155,57,172,186,85,41,155,194,137,108,240,192,177,10,30,192,55,57,254,45,228,244,196,191,27,22,203,240,208,166,147,192,170,11,93,132,19,20,11,137,174,37,245,157,117,179,136,187,29,23,247,117,236,161,14,247,189,51,110,192,145,215,52,61,57,141,239,34,194,134,62,204,210,22,246,26,205,80,168,3,140,212,155,103,1,22,205,215,108,131,97,156,47,160,79,18,91,187,52,33,123,216,79,18,219,103,125,140,20,243,142,86,126,146,196,191,205,204,68,9,67,2,0,0 };
			RealUId = new Guid("92753ebc-e72e-41f5-8d5a-68c4b7974bca");
			Version = 0;
			PackageUId = new Guid("10cb6199-40c6-4b6d-9d0e-500310d45f57");
			UseSystemSecurityContext = false;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
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
			ProcessSchemaScriptTask setsatisfactionlevelscripttask = CreateSetSatisfactionLevelScriptTaskScriptTask();
			FlowElements.Add(setsatisfactionlevelscripttask);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("c35981e6-30bd-4881-a05d-ea9eb86708a0"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("9141d462-7675-4656-8ea8-25b81010cd22"),
				CreatedInSchemaUId = new Guid("92753ebc-e72e-41f5-8d5a-68c4b7974bca"),
				CurveCenterPosition = new Point(373, 203),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("92753ebc-e72e-41f5-8d5a-68c4b7974bca"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("03ed6b2a-7daa-4d2e-acc8-3c5231eb7a36"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("d1cfdcbf-8b95-4b1f-96a9-755138c91dd2"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("01d452f2-ee08-430e-a761-667ecdf437b2"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("9141d462-7675-4656-8ea8-25b81010cd22"),
				CreatedInSchemaUId = new Guid("92753ebc-e72e-41f5-8d5a-68c4b7974bca"),
				CurveCenterPosition = new Point(373, 203),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("92753ebc-e72e-41f5-8d5a-68c4b7974bca"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("d1cfdcbf-8b95-4b1f-96a9-755138c91dd2"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("bf5a4500-60e8-49a7-b936-cab4fc19a130"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("8f1a79b9-e0b9-4065-bb4c-6773b9d9a52f"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("9141d462-7675-4656-8ea8-25b81010cd22"),
				CreatedInSchemaUId = new Guid("92753ebc-e72e-41f5-8d5a-68c4b7974bca"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("92753ebc-e72e-41f5-8d5a-68c4b7974bca"),
				Name = @"LaneSet1",
				Position = new Point(5, 5),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("28ed4bf2-6990-4640-a02d-25e42219854d"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("8f1a79b9-e0b9-4065-bb4c-6773b9d9a52f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("9141d462-7675-4656-8ea8-25b81010cd22"),
				CreatedInSchemaUId = new Guid("92753ebc-e72e-41f5-8d5a-68c4b7974bca"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("92753ebc-e72e-41f5-8d5a-68c4b7974bca"),
				Name = @"Lane1",
				Position = new Point(29, 0),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaStartEvent CreateStart1StartEvent() {
			ProcessSchemaStartEvent schemaStartEvent = new ProcessSchemaStartEvent(this) {
				UId = new Guid("03ed6b2a-7daa-4d2e-acc8-3c5231eb7a36"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("28ed4bf2-6990-4640-a02d-25e42219854d"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("9141d462-7675-4656-8ea8-25b81010cd22"),
				CreatedInSchemaUId = new Guid("92753ebc-e72e-41f5-8d5a-68c4b7974bca"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsInterrupting = false,
				IsLogging = true,
				ManagerItemUId = new Guid("53818048-7868-48f6-ada0-0ebaa65af628"),
				ModifiedInSchemaUId = new Guid("92753ebc-e72e-41f5-8d5a-68c4b7974bca"),
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
				UId = new Guid("bf5a4500-60e8-49a7-b936-cab4fc19a130"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("28ed4bf2-6990-4640-a02d-25e42219854d"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("9141d462-7675-4656-8ea8-25b81010cd22"),
				CreatedInSchemaUId = new Guid("92753ebc-e72e-41f5-8d5a-68c4b7974bca"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = true,
				ManagerItemUId = new Guid("1bd93619-0574-454e-bb4e-cf53b9eb9470"),
				ModifiedInSchemaUId = new Guid("92753ebc-e72e-41f5-8d5a-68c4b7974bca"),
				Name = @"Terminate1",
				Position = new Point(309, 184),
				SerializeToDB = false,
				Size = new Size(27, 27),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaTerminateEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateSetSatisfactionLevelScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("d1cfdcbf-8b95-4b1f-96a9-755138c91dd2"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("28ed4bf2-6990-4640-a02d-25e42219854d"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("9141d462-7675-4656-8ea8-25b81010cd22"),
				CreatedInSchemaUId = new Guid("92753ebc-e72e-41f5-8d5a-68c4b7974bca"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("92753ebc-e72e-41f5-8d5a-68c4b7974bca"),
				Name = @"SetSatisfactionLevelScriptTask",
				Position = new Point(155, 170),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,84,219,142,218,48,16,125,78,165,254,131,151,39,35,33,255,192,94,84,22,150,21,234,118,75,155,110,247,161,234,131,149,12,196,82,226,80,219,97,27,85,252,123,199,151,128,19,16,149,250,130,144,115,206,156,153,51,151,36,73,118,92,17,208,191,200,45,145,240,70,30,164,17,166,77,179,2,42,254,165,1,213,210,23,13,106,86,75,9,153,17,181,100,49,224,19,151,124,3,106,66,70,41,55,66,175,185,131,188,108,115,110,96,52,190,126,255,46,73,18,12,205,86,74,84,92,181,46,222,172,46,155,74,178,165,158,150,111,188,213,41,148,24,24,197,141,106,192,51,180,81,66,110,72,198,53,44,115,15,127,230,21,32,198,198,154,230,225,141,142,102,136,96,203,124,52,102,246,123,143,188,173,133,52,151,184,43,11,56,199,204,234,170,130,203,220,153,135,244,216,222,22,68,148,222,39,210,56,23,116,96,63,130,25,34,6,198,6,187,196,154,208,171,192,101,83,217,210,241,152,252,113,95,18,5,166,81,50,50,106,239,126,109,255,114,116,209,192,71,104,117,104,227,147,208,230,230,177,17,249,29,13,129,231,194,201,96,27,110,176,242,9,113,31,137,142,250,246,4,59,40,109,0,76,246,136,78,135,136,46,96,60,8,174,89,189,135,91,242,239,185,97,11,33,243,165,212,134,203,12,238,91,107,166,111,106,55,59,235,90,1,207,10,66,61,57,120,74,196,193,221,131,55,1,240,193,230,129,218,195,116,216,12,3,153,240,116,222,248,196,113,25,126,155,230,149,144,95,197,166,48,214,140,53,47,117,240,219,89,45,114,124,244,242,182,171,223,218,45,132,193,248,206,203,6,130,233,195,225,237,68,108,123,189,208,2,76,86,44,84,93,205,239,169,200,143,93,118,34,110,124,47,235,32,224,142,14,198,188,83,113,50,167,173,101,88,180,225,66,106,28,20,79,141,100,67,253,41,152,72,133,142,78,218,143,251,54,57,51,54,63,92,188,159,135,12,246,81,53,97,165,46,215,227,215,15,157,27,238,95,175,168,43,15,195,243,241,220,148,229,103,245,90,8,3,233,150,103,208,17,255,163,164,110,159,39,93,166,39,85,132,64,124,7,212,205,67,7,216,219,31,255,247,184,130,246,84,208,80,105,184,124,145,254,56,222,93,91,82,76,236,237,251,113,177,221,225,12,155,61,119,47,195,25,14,121,50,59,80,244,236,53,238,16,175,5,40,52,193,157,205,165,164,225,28,175,184,66,171,13,40,29,229,131,169,112,29,4,175,227,42,93,62,236,225,55,100,13,166,210,171,40,62,82,127,1,105,253,238,254,93,6,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("ca2c725f-edc8-445a-a394-c112481e1f94"),
				Name = "System.Linq",
				Alias = "",
				CreatedInPackageId = new Guid("9141d462-7675-4656-8ea8-25b81010cd22")
			});
		}

		#endregion

		#region Methods: Public

		public override Process CreateProcess(UserConnection userConnection) {
			return new SatisfactionUpdateProcess(userConnection);
		}

		public override object Clone() {
			return new SatisfactionUpdateProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("92753ebc-e72e-41f5-8d5a-68c4b7974bca"));
		}

		#endregion

	}

	#endregion

	#region Class: SatisfactionUpdateProcess

	/// <exclude/>
	public class SatisfactionUpdateProcess : Terrasoft.Core.Process.Process
	{

		#region Class: ProcessLane1

		/// <exclude/>
		public class ProcessLane1 : ProcessLane
		{

			public ProcessLane1(UserConnection userConnection, SatisfactionUpdateProcess process)
				: base(userConnection) {
				Owner = process;
				IsUsedParentUserContexts = false;
			}

		}

		#endregion

		public SatisfactionUpdateProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SatisfactionUpdateProcess";
			SchemaUId = new Guid("92753ebc-e72e-41f5-8d5a-68c4b7974bca");
			Caption = Schema.Caption;
			SchemaManagerName = "ProcessSchemaManager";
			SerializeToDB = false;
			SerializeToMemory = true;
			IsLogging = false;
			UseSystemSecurityContext = false;
			_notificationCaption = () => { return new LocalizableString((Caption)); };
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("92753ebc-e72e-41f5-8d5a-68c4b7974bca");
			}
		}

		private string ConditionalExpressionLogMessage {
			get {
				return "Process: SatisfactionUpdateProcess, Source element: {0}, Conditional flow: {1}, Expression: {2}, Result: {3}";
			}
		}

		private string DeadEndGatewayLogMessage {
			get {
				return "Process: SatisfactionUpdateProcess, Source element: {0}, None of the exclusive gateway conditions are met!";
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
					SchemaElementUId = new Guid("03ed6b2a-7daa-4d2e-acc8-3c5231eb7a36"),
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
					SchemaElementUId = new Guid("bf5a4500-60e8-49a7-b936-cab4fc19a130"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
				});
			}
		}

		private ProcessScriptTask _setSatisfactionLevelScriptTask;
		public ProcessScriptTask SetSatisfactionLevelScriptTask {
			get {
				return _setSatisfactionLevelScriptTask ?? (_setSatisfactionLevelScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "SetSatisfactionLevelScriptTask",
					SchemaElementUId = new Guid("d1cfdcbf-8b95-4b1f-96a9-755138c91dd2"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
					Script = SetSatisfactionLevelScriptTaskExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[Start1.SchemaElementUId] = new Collection<ProcessFlowElement> { Start1 };
			FlowElements[Terminate1.SchemaElementUId] = new Collection<ProcessFlowElement> { Terminate1 };
			FlowElements[SetSatisfactionLevelScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { SetSatisfactionLevelScriptTask };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "Start1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("SetSatisfactionLevelScriptTask", e.Context.SenderName));
						break;
					case "Terminate1":
						CompleteProcess();
						break;
					case "SetSatisfactionLevelScriptTask":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("Terminate1", e.Context.SenderName));
						break;
			}
		}

		private void WritePropertyValues(DataWriter writer, bool useAllValueSources) {
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
		}

		protected override void WritePropertyValues(DataWriter writer) {
			base.WritePropertyValues(writer);
			WritePropertyValues(writer, true);
		}

		#endregion

		#region Methods: Public

		public virtual bool SetSatisfactionLevelScriptTaskExecute(ProcessExecutingContext context) {
						var esq = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "SatisfactionUpdate");
						esq.PrimaryQueryColumn.IsAlwaysSelect = true;
						string caseIdColumnName = esq.AddColumn("Case.Id").Name;
						string pointColumnName = esq.AddColumn("Point").Name;
						string commentColumnName = esq.AddColumn("Comment").Name;
						EntityCollection updates = esq.GetEntityCollection(UserConnection);
						if (!updates.Any()) {
							return true;
						}
						var deleteKeys = new List<Guid>();
						Dictionary<int, Guid> satisfactionLevels = GetDictionarySatisfactionLevel();
						EntitySchema caseEntitySchema = UserConnection.EntitySchemaManager.FindInstanceByName("Case");
						foreach (Entity update in updates) {
							Entity @case = caseEntitySchema.CreateEntity(UserConnection);
							@case.UseAdminRights = false;
							var id = update.GetTypedColumnValue<Guid>(caseIdColumnName);
							if (@case.FetchFromDB(id)) {
								var point = update.GetTypedColumnValue<int>(pointColumnName);
								if (satisfactionLevels.ContainsKey(point)) {
									@case.SetColumnValue("SatisfactionLevelId", satisfactionLevels[point]);
								}
								var comment = update.GetTypedColumnValue<string>(commentColumnName);
								if (!string.IsNullOrWhiteSpace(comment)) {
									@case.SetColumnValue("SatisfactionLevelComment", comment);
								}
								@case.Save(false);
							}				
							deleteKeys.Add(update.PrimaryColumnValue);
						}
						if (deleteKeys.Any()) {
							var deleteQuery = new Delete(UserConnection)
								.From("SatisfactionUpdate")
								.Where("Id").In(Column.Parameters(deleteKeys)) as Delete;
							deleteQuery.Execute();
						}
						return true;
		}

			
			public virtual Dictionary<int, Guid> GetDictionarySatisfactionLevel() {
				var ESQ = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "SatisfactionLevel");
			ESQ.AddAllSchemaColumns();
			var satisfactionLevels = ESQ.GetEntityCollection(UserConnection);
			var retDictionary = new Dictionary<int, Guid>();
			foreach(var satisfactionLevel in satisfactionLevels) {
				var point = satisfactionLevel.GetTypedColumnValue<int>("Point");
				if(!retDictionary.ContainsKey(point)) {
					retDictionary.Add(point, satisfactionLevel.PrimaryColumnValue);
				}
			}
			return retDictionary;
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
			var cloneItem = (SatisfactionUpdateProcess)base.CloneShallow();
			cloneItem.ExecutedEventHandler = ExecutedEventHandler;
			return cloneItem;
		}

		#endregion

	}

	#endregion

}

