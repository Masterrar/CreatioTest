namespace Terrasoft.Configuration
{

	using DataContract = Terrasoft.Nui.ServiceModel.DataContract;
	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Data;
	using System.Drawing;
	using System.Globalization;
	using System.IO;
	using System.Linq;
	using Terrasoft.Common;
	using Terrasoft.Common.Json;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.DcmProcess;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Factories;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;
	using Terrasoft.GlobalSearch.Indexing;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities.Json.Converters;

	#region Class: CaseFileSchema

	/// <exclude/>
	public class CaseFileSchema : Terrasoft.Configuration.CaseFile_Case_TerrasoftSchema
	{

		#region Constructors: Public

		public CaseFileSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public CaseFileSchema(CaseFileSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public CaseFileSchema(CaseFileSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("736dce4a-0ec7-4890-99e2-18d8851b80e6");
			Name = "CaseFile";
			ParentSchemaUId = new Guid("72deb8f3-0936-41ca-b4ae-102c6c4bf708");
			ExtendParent = true;
			CreatedInPackageId = new Guid("33bac096-c819-4c57-86af-fe71bbb0cb56");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateCaseFileEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateCaseFileEventsProcessSchema() {
			var schema = new CaseFileEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new CaseFile(userConnection){Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new CaseFile_CaseServiceEventsProcess(userConnnection);
		}

		public override object Clone() {
			return new CaseFileSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new CaseFileSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("736dce4a-0ec7-4890-99e2-18d8851b80e6"));
		}

		#endregion

	}

	#endregion

	#region Class: CaseFile

	/// <summary>
	/// Attachments and notes detail object in Cases section.
	/// </summary>
	public class CaseFile : Terrasoft.Configuration.CaseFile_Case_Terrasoft
	{

		#region Constructors: Public

		public CaseFile(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "CaseFile";
		}

		public CaseFile(CaseFile source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new CaseFile_CaseServiceEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Inserted += (s, e) => ThrowEvent("CaseFileInserted", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new CaseFile(this);
		}

		#endregion

	}

	#endregion

	#region Class: CaseFile_CaseServiceEventsProcess

	/// <exclude/>
	public class CaseFile_CaseServiceEventsProcess<TEntity> : Terrasoft.Configuration.CaseFile_CaseEventsProcess<TEntity> where TEntity : CaseFile
	{

		public CaseFile_CaseServiceEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "CaseFile_CaseServiceEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("736dce4a-0ec7-4890-99e2-18d8851b80e6");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		private ProcessFlowElement _eventSubProcess3_4f47efa85b0548aba7425f1444e6efbe;
		public ProcessFlowElement EventSubProcess3_4f47efa85b0548aba7425f1444e6efbe {
			get {
				return _eventSubProcess3_4f47efa85b0548aba7425f1444e6efbe ?? (_eventSubProcess3_4f47efa85b0548aba7425f1444e6efbe = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess3_4f47efa85b0548aba7425f1444e6efbe",
					SchemaElementUId = new Guid("4f47efa8-5b05-48ab-a742-5f1444e6efbe"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessage3_d2d754bfe83e4a33a4261ac9a26d3d73;
		public ProcessFlowElement StartMessage3_d2d754bfe83e4a33a4261ac9a26d3d73 {
			get {
				return _startMessage3_d2d754bfe83e4a33a4261ac9a26d3d73 ?? (_startMessage3_d2d754bfe83e4a33a4261ac9a26d3d73 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessage3_d2d754bfe83e4a33a4261ac9a26d3d73",
					SchemaElementUId = new Guid("d2d754bf-e83e-4a33-a426-1ac9a26d3d73"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTask3_c959bb6a28f640e88e18746af09758b1;
		public ProcessScriptTask ScriptTask3_c959bb6a28f640e88e18746af09758b1 {
			get {
				return _scriptTask3_c959bb6a28f640e88e18746af09758b1 ?? (_scriptTask3_c959bb6a28f640e88e18746af09758b1 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask3_c959bb6a28f640e88e18746af09758b1",
					SchemaElementUId = new Guid("c959bb6a-28f6-40e8-8e18-746af09758b1"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask3_c959bb6a28f640e88e18746af09758b1Execute,
				});
			}
		}

		private ProcessThrowMessageEvent _intermediateThrowMessage1_cb35b2dcae514d96b46177b11d4fb395;
		public ProcessThrowMessageEvent IntermediateThrowMessage1_cb35b2dcae514d96b46177b11d4fb395 {
			get {
				return _intermediateThrowMessage1_cb35b2dcae514d96b46177b11d4fb395 ?? (_intermediateThrowMessage1_cb35b2dcae514d96b46177b11d4fb395 = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "IntermediateThrowMessage1_cb35b2dcae514d96b46177b11d4fb395",
					SchemaElementUId = new Guid("cb35b2dc-ae51-4d96-b461-77b11d4fb395"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "CaseFileInserted",
						ThrowToBase = true,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess3_4f47efa85b0548aba7425f1444e6efbe.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess3_4f47efa85b0548aba7425f1444e6efbe };
			FlowElements[StartMessage3_d2d754bfe83e4a33a4261ac9a26d3d73.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage3_d2d754bfe83e4a33a4261ac9a26d3d73 };
			FlowElements[ScriptTask3_c959bb6a28f640e88e18746af09758b1.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask3_c959bb6a28f640e88e18746af09758b1 };
			FlowElements[IntermediateThrowMessage1_cb35b2dcae514d96b46177b11d4fb395.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowMessage1_cb35b2dcae514d96b46177b11d4fb395 };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess3_4f47efa85b0548aba7425f1444e6efbe":
						break;
					case "StartMessage3_d2d754bfe83e4a33a4261ac9a26d3d73":
						e.Context.QueueTasks.Enqueue("ScriptTask3_c959bb6a28f640e88e18746af09758b1");
						break;
					case "ScriptTask3_c959bb6a28f640e88e18746af09758b1":
						e.Context.QueueTasks.Enqueue("IntermediateThrowMessage1_cb35b2dcae514d96b46177b11d4fb395");
						break;
					case "IntermediateThrowMessage1_cb35b2dcae514d96b46177b11d4fb395":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("StartMessage3_d2d754bfe83e4a33a4261ac9a26d3d73");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "EventSubProcess3_4f47efa85b0548aba7425f1444e6efbe":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage3_d2d754bfe83e4a33a4261ac9a26d3d73":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage3_d2d754bfe83e4a33a4261ac9a26d3d73";
					result = StartMessage3_d2d754bfe83e4a33a4261ac9a26d3d73.Execute(context);
					break;
				case "ScriptTask3_c959bb6a28f640e88e18746af09758b1":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask3_c959bb6a28f640e88e18746af09758b1";
					result = ScriptTask3_c959bb6a28f640e88e18746af09758b1.Execute(context, ScriptTask3_c959bb6a28f640e88e18746af09758b1Execute);
					break;
				case "IntermediateThrowMessage1_cb35b2dcae514d96b46177b11d4fb395":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "CaseFileInserted");
					result = IntermediateThrowMessage1_cb35b2dcae514d96b46177b11d4fb395.Execute(context);
					break;
			}
			if (!result && context.QueueTasks.Count > 0) {
				ProcessQueue(context);
			}
			return result;
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

		#endregion

		#region Methods: Public

		public virtual bool ScriptTask3_c959bb6a28f640e88e18746af09758b1Execute(ProcessExecutingContext context) {
			if(Entity.GetTypedColumnValue<bool>("IsNeedToNotify")) {
				var notifier = new CaseFileMessageNotifier(this.Entity);
				var manager = new MessageHistoryManager(UserConnection, notifier);
				manager.Notify();
			}
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "CaseFileInserted":
							if (ActivatedEventElements.Contains("StartMessage3_d2d754bfe83e4a33a4261ac9a26d3d73")) {
							context.QueueTasks.Enqueue("StartMessage3_d2d754bfe83e4a33a4261ac9a26d3d73");
						}
						break;
			}
			base.ThrowEvent(context, message);
			ProcessQueue(context);
		}

		public override void WritePropertiesData(DataWriter writer, bool writeFlowElements = true) {
			base.WritePropertiesData(writer, writeFlowElements);
		}

		public override object CloneShallow() {
			return base.CloneShallow();
		}

		#endregion

	}

	#endregion

	#region Class: CaseFile_CaseServiceEventsProcess

	/// <exclude/>
	public class CaseFile_CaseServiceEventsProcess : CaseFile_CaseServiceEventsProcess<CaseFile>
	{

		public CaseFile_CaseServiceEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: CaseFileEventsProcessSchema

	/// <exclude/>
	public class CaseFileEventsProcessSchema : Terrasoft.Configuration.CaseFile_Case_TerrasoftEventsProcessSchema
	{

		#region Constructors: Public

		public CaseFileEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public CaseFileEventsProcessSchema(CaseFileEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "CaseFile_CaseServiceEventsProcess";
			UId = new Guid("076a245b-ed05-4091-94e9-63c51ae51dc2");
			CreatedInPackageId = new Guid("33bac096-c819-4c57-86af-fe71bbb0cb56");
			CreatedInSchemaUId = Guid.Empty;
			CreatedInVersion = @"0.0.0.0";
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("13fb4dde-6869-4210-9b9c-69e11c081f82");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet4_9d440d941312486b9686204d2c83f48d = CreateLaneSet4_9d440d941312486b9686204d2c83f48dLaneSet();
			LaneSets.Add(schemaLaneSet4_9d440d941312486b9686204d2c83f48d);
			ProcessSchemaLane schemaLane4_70c0a754b0a643669d3c4af9e17ed054 = CreateLane4_70c0a754b0a643669d3c4af9e17ed054Lane();
			schemaLaneSet4_9d440d941312486b9686204d2c83f48d.Lanes.Add(schemaLane4_70c0a754b0a643669d3c4af9e17ed054);
			ProcessSchemaEventSubProcess eventsubprocess3_4f47efa85b0548aba7425f1444e6efbe = CreateEventSubProcess3_4f47efa85b0548aba7425f1444e6efbeEventSubProcess();
			FlowElements.Add(eventsubprocess3_4f47efa85b0548aba7425f1444e6efbe);
			ProcessSchemaStartMessageEvent startmessage3_d2d754bfe83e4a33a4261ac9a26d3d73 = CreateStartMessage3_d2d754bfe83e4a33a4261ac9a26d3d73StartMessageEvent();
			eventsubprocess3_4f47efa85b0548aba7425f1444e6efbe.FlowElements.Add(startmessage3_d2d754bfe83e4a33a4261ac9a26d3d73);
			ProcessSchemaScriptTask scripttask3_c959bb6a28f640e88e18746af09758b1 = CreateScriptTask3_c959bb6a28f640e88e18746af09758b1ScriptTask();
			eventsubprocess3_4f47efa85b0548aba7425f1444e6efbe.FlowElements.Add(scripttask3_c959bb6a28f640e88e18746af09758b1);
			ProcessSchemaIntermediateThrowMessageEvent intermediatethrowmessage1_cb35b2dcae514d96b46177b11d4fb395 = CreateIntermediateThrowMessage1_cb35b2dcae514d96b46177b11d4fb395IntermediateThrowMessageEvent();
			eventsubprocess3_4f47efa85b0548aba7425f1444e6efbe.FlowElements.Add(intermediatethrowmessage1_cb35b2dcae514d96b46177b11d4fb395);
			FlowElements.Add(CreateSequenceFlow5_97b0436cb2ee4c21ac4b4983079c8f6fSequenceFlow());
			FlowElements.Add(CreateSequenceFlow7_35bc12bffd694f27aab98dc0b4c7fa4dSequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow5_97b0436cb2ee4c21ac4b4983079c8f6fSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow5_97b0436cb2ee4c21ac4b4983079c8f6f",
				UId = new Guid("97b0436c-b2ee-4c21-ac4b-4983079c8f6f"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("13fb4dde-6869-4210-9b9c-69e11c081f82"),
				CreatedInPackageId = new Guid("33bac096-c819-4c57-86af-fe71bbb0cb56"),
				CreatedInSchemaUId = new Guid("076a245b-ed05-4091-94e9-63c51ae51dc2"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("076a245b-ed05-4091-94e9-63c51ae51dc2"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("d2d754bf-e83e-4a33-a426-1ac9a26d3d73"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("c959bb6a-28f6-40e8-8e18-746af09758b1"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow7_35bc12bffd694f27aab98dc0b4c7fa4dSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow7_35bc12bffd694f27aab98dc0b4c7fa4d",
				UId = new Guid("35bc12bf-fd69-4f27-aab9-8dc0b4c7fa4d"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("13fb4dde-6869-4210-9b9c-69e11c081f82"),
				CreatedInPackageId = new Guid("33bac096-c819-4c57-86af-fe71bbb0cb56"),
				CreatedInSchemaUId = new Guid("076a245b-ed05-4091-94e9-63c51ae51dc2"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("076a245b-ed05-4091-94e9-63c51ae51dc2"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("c959bb6a-28f6-40e8-8e18-746af09758b1"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("cb35b2dc-ae51-4d96-b461-77b11d4fb395"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet4_9d440d941312486b9686204d2c83f48dLaneSet() {
			ProcessSchemaLaneSet schemaLaneSet4_9d440d941312486b9686204d2c83f48d = new ProcessSchemaLaneSet(this) {
				UId = new Guid("9d440d94-1312-486b-9686-204d2c83f48d"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("13fb4dde-6869-4210-9b9c-69e11c081f82"),
				CreatedInPackageId = new Guid("33bac096-c819-4c57-86af-fe71bbb0cb56"),
				CreatedInSchemaUId = new Guid("076a245b-ed05-4091-94e9-63c51ae51dc2"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("076a245b-ed05-4091-94e9-63c51ae51dc2"),
				Name = @"LaneSet4_9d440d941312486b9686204d2c83f48d",
				Position = new Point(0, 5),
				Size = new Size(0, 400),
				UseBackgroundMode = false
			};
			return schemaLaneSet4_9d440d941312486b9686204d2c83f48d;
		}

		protected virtual ProcessSchemaLane CreateLane4_70c0a754b0a643669d3c4af9e17ed054Lane() {
			ProcessSchemaLane schemaLane4_70c0a754b0a643669d3c4af9e17ed054 = new ProcessSchemaLane(this) {
				UId = new Guid("70c0a754-b0a6-4366-9d3c-4af9e17ed054"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("9d440d94-1312-486b-9686-204d2c83f48d"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("33bac096-c819-4c57-86af-fe71bbb0cb56"),
				CreatedInSchemaUId = new Guid("076a245b-ed05-4091-94e9-63c51ae51dc2"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("076a245b-ed05-4091-94e9-63c51ae51dc2"),
				Name = @"Lane4_70c0a754b0a643669d3c4af9e17ed054",
				Position = new Point(0, 0),
				Size = new Size(700, 400),
				UseBackgroundMode = false
			};
			return schemaLane4_70c0a754b0a643669d3c4af9e17ed054;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess3_4f47efa85b0548aba7425f1444e6efbeEventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess3_4f47efa85b0548aba7425f1444e6efbe = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("4f47efa8-5b05-48ab-a742-5f1444e6efbe"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("70c0a754-b0a6-4366-9d3c-4af9e17ed054"),
				CreatedInOwnerSchemaUId = new Guid("13fb4dde-6869-4210-9b9c-69e11c081f82"),
				CreatedInPackageId = new Guid("33bac096-c819-4c57-86af-fe71bbb0cb56"),
				CreatedInSchemaUId = new Guid("076a245b-ed05-4091-94e9-63c51ae51dc2"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("076a245b-ed05-4091-94e9-63c51ae51dc2"),
				Name = @"EventSubProcess3_4f47efa85b0548aba7425f1444e6efbe",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(100, 20),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(1010, 300),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess3_4f47efa85b0548aba7425f1444e6efbe;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage3_d2d754bfe83e4a33a4261ac9a26d3d73StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("d2d754bf-e83e-4a33-a426-1ac9a26d3d73"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4f47efa8-5b05-48ab-a742-5f1444e6efbe"),
				CreatedInOwnerSchemaUId = new Guid("13fb4dde-6869-4210-9b9c-69e11c081f82"),
				CreatedInPackageId = new Guid("33bac096-c819-4c57-86af-fe71bbb0cb56"),
				CreatedInSchemaUId = new Guid("076a245b-ed05-4091-94e9-63c51ae51dc2"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"CaseFileInserted",
				ModifiedInSchemaUId = new Guid("076a245b-ed05-4091-94e9-63c51ae51dc2"),
				Name = @"StartMessage3_d2d754bfe83e4a33a4261ac9a26d3d73",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(113, 90),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask3_c959bb6a28f640e88e18746af09758b1ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("c959bb6a-28f6-40e8-8e18-746af09758b1"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4f47efa8-5b05-48ab-a742-5f1444e6efbe"),
				CreatedInOwnerSchemaUId = new Guid("13fb4dde-6869-4210-9b9c-69e11c081f82"),
				CreatedInPackageId = new Guid("33bac096-c819-4c57-86af-fe71bbb0cb56"),
				CreatedInSchemaUId = new Guid("076a245b-ed05-4091-94e9-63c51ae51dc2"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("076a245b-ed05-4091-94e9-63c51ae51dc2"),
				Name = @"ScriptTask3_c959bb6a28f640e88e18746af09758b1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(291, 76),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,61,142,205,14,130,48,16,132,207,146,240,14,13,167,146,24,94,0,245,66,252,59,192,9,189,87,89,180,73,217,53,237,86,211,24,223,93,145,234,117,102,190,153,209,189,92,35,107,14,197,22,184,13,55,232,42,50,126,192,163,50,30,22,39,34,179,146,217,222,53,0,93,75,13,177,238,67,150,231,226,153,38,179,187,178,2,71,69,131,21,75,129,240,16,149,114,176,209,6,106,112,78,93,160,137,174,228,171,118,197,180,147,151,17,29,20,126,34,63,50,18,59,237,152,108,168,39,79,30,28,216,138,16,225,204,154,112,254,159,251,150,196,130,98,122,37,71,237,149,38,22,216,91,20,108,61,148,111,58,230,253,98,221,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateIntermediateThrowMessage1_cb35b2dcae514d96b46177b11d4fb395IntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("cb35b2dc-ae51-4d96-b461-77b11d4fb395"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4f47efa8-5b05-48ab-a742-5f1444e6efbe"),
				CreatedInOwnerSchemaUId = new Guid("13fb4dde-6869-4210-9b9c-69e11c081f82"),
				CreatedInPackageId = new Guid("33bac096-c819-4c57-86af-fe71bbb0cb56"),
				CreatedInSchemaUId = new Guid("076a245b-ed05-4091-94e9-63c51ae51dc2"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"CaseFileInserted",
				ModifiedInSchemaUId = new Guid("076a245b-ed05-4091-94e9-63c51ae51dc2"),
				Name = @"IntermediateThrowMessage1_cb35b2dcae514d96b46177b11d4fb395",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(491, 90),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("fb7b81ba-7c3c-45a5-ae9e-c6c03dceb812"),
				Name = "Terrasoft.UI.WebControls.Controls",
				Alias = "",
				CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("cde525cf-d220-4d2a-b963-e55254c639fc"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5c9c82c6-ba6d-4a57-9a14-87fe8faa4ebb"),
				Name = "Terrasoft.Core.DB",
				Alias = "",
				CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7821de68-c82b-4917-a6cd-add2adfbe400"),
				Name = "Terrasoft.Common",
				Alias = "",
				CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d67de76f-9cbc-4bfc-babb-6f65cb89b973"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("74160d3b-65e3-4694-b554-089f2d980e54"),
				Name = "Newtonsoft.Json",
				Alias = "",
				CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e401300a-9f16-40c2-9788-cf310ae9d1c5"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("8344487b-4f62-45ad-a3a1-e073f07b2ef2"),
				Name = "System.Collections.Generic",
				Alias = "",
				CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e33423da-6c95-41fd-bf98-97c4161975e5"),
				Name = "System.Linq",
				Alias = "",
				CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d5bb3512-71e0-482a-9c7e-16bf22c586b7"),
				Name = "Terrasoft.Nui.ServiceModel.DataContract",
				Alias = "DataContract",
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("b261d1c9-cc98-44e8-aabd-7806d1dc26ed"),
				Name = "Terrasoft.Core.Factories",
				Alias = "",
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("c261d1c9-cc98-44e8-aabd-7806d1dc26ec"),
				Name = "Terrasoft.Core.DcmProcess",
				Alias = "",
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("36db9306-521c-4d94-87c4-a02688862caa"),
				Name = "Terrasoft.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("8a6b5719-da97-4634-8f04-4375bc29ffcf")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("aca2294b-e209-4c40-9400-0d59d9ecd1ea"),
				Name = "Terrasoft.GlobalSearch.Indexing",
				Alias = "",
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			});
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new CaseFileEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("076a245b-ed05-4091-94e9-63c51ae51dc2"));
		}

		#endregion

	}

	#endregion


	#region Class: CaseFileEventsProcess

	/// <exclude/>
	public class CaseFileEventsProcess : CaseFile_CaseServiceEventsProcess
	{

		public CaseFileEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

