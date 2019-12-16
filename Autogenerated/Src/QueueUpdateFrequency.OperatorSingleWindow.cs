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
	using Terrasoft.Common;
	using Terrasoft.Common.Json;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.DcmProcess;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Factories;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities.Json.Converters;

	#region Class: QueueUpdateFrequencySchema

	/// <exclude/>
	public class QueueUpdateFrequencySchema : Terrasoft.Configuration.BaseLookupSchema
	{

		#region Constructors: Public

		public QueueUpdateFrequencySchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public QueueUpdateFrequencySchema(QueueUpdateFrequencySchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public QueueUpdateFrequencySchema(QueueUpdateFrequencySchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("658c1af2-df48-464c-9257-0245f5460090");
			RealUId = new Guid("658c1af2-df48-464c-9257-0245f5460090");
			Name = "QueueUpdateFrequency";
			ParentSchemaUId = new Guid("11ab4bcb-9b23-4b6d-9c86-520fae925d75");
			ExtendParent = false;
			CreatedInPackageId = new Guid("96ba3f81-7af1-43c9-9a5b-ab40bf0d009a");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("104e6ad9-b211-4286-a3b8-62e29ae8a322")) == null) {
				Columns.Add(CreateFrequencyColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateFrequencyColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("104e6ad9-b211-4286-a3b8-62e29ae8a322"),
				Name = @"Frequency",
				CreatedInSchemaUId = new Guid("658c1af2-df48-464c-9257-0245f5460090"),
				ModifiedInSchemaUId = new Guid("658c1af2-df48-464c-9257-0245f5460090"),
				CreatedInPackageId = new Guid("96ba3f81-7af1-43c9-9a5b-ab40bf0d009a")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateQueueUpdateFrequencyEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateQueueUpdateFrequencyEventsProcessSchema() {
			var schema = new QueueUpdateFrequencyEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new QueueUpdateFrequency(userConnection){Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new QueueUpdateFrequency_OperatorSingleWindowEventsProcess(userConnnection);
		}

		public override object Clone() {
			return new QueueUpdateFrequencySchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new QueueUpdateFrequencySchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("658c1af2-df48-464c-9257-0245f5460090"));
		}

		#endregion

	}

	#endregion

	#region Class: QueueUpdateFrequency

	/// <summary>
	/// Queue update frequency.
	/// </summary>
	public class QueueUpdateFrequency : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public QueueUpdateFrequency(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "QueueUpdateFrequency";
		}

		public QueueUpdateFrequency(QueueUpdateFrequency source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Update frequency in minutes.
		/// </summary>
		public  int Frequency {
			get {
				return GetTypedColumnValue<int>("Frequency");
			}
			set {
				SetColumnValue("Frequency", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new QueueUpdateFrequency_OperatorSingleWindowEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Saved += (s, e) => ThrowEvent("QueueUpdateFrequencySaved", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new QueueUpdateFrequency(this);
		}

		#endregion

	}

	#endregion

	#region Class: QueueUpdateFrequency_OperatorSingleWindowEventsProcess

	/// <exclude/>
	public class QueueUpdateFrequency_OperatorSingleWindowEventsProcess<TEntity> : Terrasoft.Configuration.BaseLookup_BaseEventsProcess<TEntity> where TEntity : QueueUpdateFrequency
	{

		public QueueUpdateFrequency_OperatorSingleWindowEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "QueueUpdateFrequency_OperatorSingleWindowEventsProcess";
			SchemaUId = new Guid("658c1af2-df48-464c-9257-0245f5460090");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private  Guid InternalSchemaUId {
			get {
				return new Guid("658c1af2-df48-464c-9257-0245f5460090");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		private ProcessFlowElement _eventSubProcess3_331342c9982c4a4281870bdb5ed2e659;
		public  ProcessFlowElement EventSubProcess3_331342c9982c4a4281870bdb5ed2e659 {
			get {
				return _eventSubProcess3_331342c9982c4a4281870bdb5ed2e659 ?? (_eventSubProcess3_331342c9982c4a4281870bdb5ed2e659 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess3_331342c9982c4a4281870bdb5ed2e659",
					SchemaElementUId = new Guid("331342c9-982c-4a42-8187-0bdb5ed2e659"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessage3_9296aa43d7634650b0f333c745a017cb;
		public  ProcessFlowElement StartMessage3_9296aa43d7634650b0f333c745a017cb {
			get {
				return _startMessage3_9296aa43d7634650b0f333c745a017cb ?? (_startMessage3_9296aa43d7634650b0f333c745a017cb = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessage3_9296aa43d7634650b0f333c745a017cb",
					SchemaElementUId = new Guid("9296aa43-d763-4650-b0f3-33c745a017cb"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTask3_acfc7a7ed8484fc8aab5052a157f0173;
		public  ProcessScriptTask ScriptTask3_acfc7a7ed8484fc8aab5052a157f0173 {
			get {
				return _scriptTask3_acfc7a7ed8484fc8aab5052a157f0173 ?? (_scriptTask3_acfc7a7ed8484fc8aab5052a157f0173 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask3_acfc7a7ed8484fc8aab5052a157f0173",
					SchemaElementUId = new Guid("acfc7a7e-d848-4fc8-aab5-052a157f0173"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask3_acfc7a7ed8484fc8aab5052a157f0173Execute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess3_331342c9982c4a4281870bdb5ed2e659.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess3_331342c9982c4a4281870bdb5ed2e659 };
			FlowElements[StartMessage3_9296aa43d7634650b0f333c745a017cb.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage3_9296aa43d7634650b0f333c745a017cb };
			FlowElements[ScriptTask3_acfc7a7ed8484fc8aab5052a157f0173.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask3_acfc7a7ed8484fc8aab5052a157f0173 };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess3_331342c9982c4a4281870bdb5ed2e659":
						break;
					case "StartMessage3_9296aa43d7634650b0f333c745a017cb":
						e.Context.QueueTasks.Enqueue("ScriptTask3_acfc7a7ed8484fc8aab5052a157f0173");
						break;
					case "ScriptTask3_acfc7a7ed8484fc8aab5052a157f0173":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("StartMessage3_9296aa43d7634650b0f333c745a017cb");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "EventSubProcess3_331342c9982c4a4281870bdb5ed2e659":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage3_9296aa43d7634650b0f333c745a017cb":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage3_9296aa43d7634650b0f333c745a017cb";
					result = StartMessage3_9296aa43d7634650b0f333c745a017cb.Execute(context);
					break;
				case "ScriptTask3_acfc7a7ed8484fc8aab5052a157f0173":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask3_acfc7a7ed8484fc8aab5052a157f0173";
					result = ScriptTask3_acfc7a7ed8484fc8aab5052a157f0173.Execute(context, ScriptTask3_acfc7a7ed8484fc8aab5052a157f0173Execute);
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

		public virtual bool ScriptTask3_acfc7a7ed8484fc8aab5052a157f0173Execute(ProcessExecutingContext context) {
			QueueCacheHelper.ClearCache();
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "QueueUpdateFrequencySaved":
							if (ActivatedEventElements.Contains("StartMessage3_9296aa43d7634650b0f333c745a017cb")) {
							context.QueueTasks.Enqueue("StartMessage3_9296aa43d7634650b0f333c745a017cb");
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

	#region Class: QueueUpdateFrequency_OperatorSingleWindowEventsProcess

	/// <exclude/>
	public class QueueUpdateFrequency_OperatorSingleWindowEventsProcess : QueueUpdateFrequency_OperatorSingleWindowEventsProcess<QueueUpdateFrequency>
	{

		public QueueUpdateFrequency_OperatorSingleWindowEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: QueueUpdateFrequencyEventsProcessSchema

	/// <exclude/>
	public class QueueUpdateFrequencyEventsProcessSchema : Terrasoft.Configuration.BaseLookupEventsProcessSchema
	{

		#region Constructors: Public

		public QueueUpdateFrequencyEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public QueueUpdateFrequencyEventsProcessSchema(QueueUpdateFrequencyEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "QueueUpdateFrequency_OperatorSingleWindowEventsProcess";
			UId = new Guid("173d8eb0-9985-4776-a035-42eb5649b684");
			CreatedInPackageId = new Guid("96ba3f81-7af1-43c9-9a5b-ab40bf0d009a");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("e20c0489-122a-4242-999c-169e8e866fc1");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet2_df14064841b54a7286ea38357d307195 = CreateLaneSet2_df14064841b54a7286ea38357d307195LaneSet();
			LaneSets.Add(schemaLaneSet2_df14064841b54a7286ea38357d307195);
			ProcessSchemaLane schemaLane1_cdc6503f16a04969ba90433fde9bdb07 = CreateLane1_cdc6503f16a04969ba90433fde9bdb07Lane();
			schemaLaneSet2_df14064841b54a7286ea38357d307195.Lanes.Add(schemaLane1_cdc6503f16a04969ba90433fde9bdb07);
			ProcessSchemaEventSubProcess eventsubprocess3_331342c9982c4a4281870bdb5ed2e659 = CreateEventSubProcess3_331342c9982c4a4281870bdb5ed2e659EventSubProcess();
			FlowElements.Add(eventsubprocess3_331342c9982c4a4281870bdb5ed2e659);
			ProcessSchemaStartMessageEvent startmessage3_9296aa43d7634650b0f333c745a017cb = CreateStartMessage3_9296aa43d7634650b0f333c745a017cbStartMessageEvent();
			eventsubprocess3_331342c9982c4a4281870bdb5ed2e659.FlowElements.Add(startmessage3_9296aa43d7634650b0f333c745a017cb);
			ProcessSchemaScriptTask scripttask3_acfc7a7ed8484fc8aab5052a157f0173 = CreateScriptTask3_acfc7a7ed8484fc8aab5052a157f0173ScriptTask();
			eventsubprocess3_331342c9982c4a4281870bdb5ed2e659.FlowElements.Add(scripttask3_acfc7a7ed8484fc8aab5052a157f0173);
			FlowElements.Add(CreateSequenceFlow4_37647e85f3784dba993b071598ed31b0SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4_37647e85f3784dba993b071598ed31b0SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4_37647e85f3784dba993b071598ed31b0",
				UId = new Guid("37647e85-f378-4dba-993b-071598ed31b0"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("e20c0489-122a-4242-999c-169e8e866fc1"),
				CreatedInPackageId = new Guid("96ba3f81-7af1-43c9-9a5b-ab40bf0d009a"),
				CreatedInSchemaUId = new Guid("173d8eb0-9985-4776-a035-42eb5649b684"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("173d8eb0-9985-4776-a035-42eb5649b684"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("9296aa43-d763-4650-b0f3-33c745a017cb"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("acfc7a7e-d848-4fc8-aab5-052a157f0173"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(257, 107));
			schemaFlow.PolylinePointPositions.Add(new Point(257, 110));
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet2_df14064841b54a7286ea38357d307195LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet2_df14064841b54a7286ea38357d307195 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("df140648-41b5-4a72-86ea-38357d307195"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("e20c0489-122a-4242-999c-169e8e866fc1"),
				CreatedInPackageId = new Guid("96ba3f81-7af1-43c9-9a5b-ab40bf0d009a"),
				CreatedInSchemaUId = new Guid("173d8eb0-9985-4776-a035-42eb5649b684"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("173d8eb0-9985-4776-a035-42eb5649b684"),
				Name = @"LaneSet2_df14064841b54a7286ea38357d307195",
				Position = new Point(0, 0),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaLaneSet2_df14064841b54a7286ea38357d307195;
		}

		protected virtual ProcessSchemaLane CreateLane1_cdc6503f16a04969ba90433fde9bdb07Lane() {
			ProcessSchemaLane schemaLane1_cdc6503f16a04969ba90433fde9bdb07 = new ProcessSchemaLane(this) {
				UId = new Guid("cdc6503f-16a0-4969-ba90-433fde9bdb07"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("df140648-41b5-4a72-86ea-38357d307195"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("96ba3f81-7af1-43c9-9a5b-ab40bf0d009a"),
				CreatedInSchemaUId = new Guid("173d8eb0-9985-4776-a035-42eb5649b684"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("173d8eb0-9985-4776-a035-42eb5649b684"),
				Name = @"Lane1_cdc6503f16a04969ba90433fde9bdb07",
				Position = new Point(0, 0),
				Size = new Size(700, 400),
				UseBackgroundMode = false
			};
			return schemaLane1_cdc6503f16a04969ba90433fde9bdb07;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess3_331342c9982c4a4281870bdb5ed2e659EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess3_331342c9982c4a4281870bdb5ed2e659 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("331342c9-982c-4a42-8187-0bdb5ed2e659"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("cdc6503f-16a0-4969-ba90-433fde9bdb07"),
				CreatedInOwnerSchemaUId = new Guid("e20c0489-122a-4242-999c-169e8e866fc1"),
				CreatedInPackageId = new Guid("96ba3f81-7af1-43c9-9a5b-ab40bf0d009a"),
				CreatedInSchemaUId = new Guid("173d8eb0-9985-4776-a035-42eb5649b684"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("173d8eb0-9985-4776-a035-42eb5649b684"),
				Name = @"EventSubProcess3_331342c9982c4a4281870bdb5ed2e659",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(43, 23),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(557, 197),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess3_331342c9982c4a4281870bdb5ed2e659;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage3_9296aa43d7634650b0f333c745a017cbStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("9296aa43-d763-4650-b0f3-33c745a017cb"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("331342c9-982c-4a42-8187-0bdb5ed2e659"),
				CreatedInOwnerSchemaUId = new Guid("e20c0489-122a-4242-999c-169e8e866fc1"),
				CreatedInPackageId = new Guid("96ba3f81-7af1-43c9-9a5b-ab40bf0d009a"),
				CreatedInSchemaUId = new Guid("173d8eb0-9985-4776-a035-42eb5649b684"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"QueueUpdateFrequencySaved",
				ModifiedInSchemaUId = new Guid("173d8eb0-9985-4776-a035-42eb5649b684"),
				Name = @"StartMessage3_9296aa43d7634650b0f333c745a017cb",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(65, 70),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask3_acfc7a7ed8484fc8aab5052a157f0173ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("acfc7a7e-d848-4fc8-aab5-052a157f0173"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("331342c9-982c-4a42-8187-0bdb5ed2e659"),
				CreatedInOwnerSchemaUId = new Guid("e20c0489-122a-4242-999c-169e8e866fc1"),
				CreatedInPackageId = new Guid("96ba3f81-7af1-43c9-9a5b-ab40bf0d009a"),
				CreatedInSchemaUId = new Guid("173d8eb0-9985-4776-a035-42eb5649b684"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("173d8eb0-9985-4776-a035-42eb5649b684"),
				Name = @"ScriptTask3_acfc7a7ed8484fc8aab5052a157f0173",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(336, 59),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,44,77,45,77,117,78,76,206,72,245,72,205,41,72,45,210,115,206,73,77,44,2,11,104,104,90,115,21,165,150,148,22,229,41,148,20,149,166,90,3,0,20,55,106,10,43,0,0,0 }
			};
			
			return ScriptTask;
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
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("cde525cf-d220-4d2a-b963-e55254c639fc"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5c9c82c6-ba6d-4a57-9a14-87fe8faa4ebb"),
				Name = "Terrasoft.Core.DB",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7821de68-c82b-4917-a6cd-add2adfbe400"),
				Name = "Terrasoft.Common",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d67de76f-9cbc-4bfc-babb-6f65cb89b973"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("74160d3b-65e3-4694-b554-089f2d980e54"),
				Name = "Newtonsoft.Json",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e401300a-9f16-40c2-9788-cf310ae9d1c5"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
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
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new QueueUpdateFrequencyEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("173d8eb0-9985-4776-a035-42eb5649b684"));
		}

		#endregion

	}

	#endregion


	#region Class: QueueUpdateFrequencyEventsProcess

	/// <exclude/>
	public class QueueUpdateFrequencyEventsProcess : QueueUpdateFrequency_OperatorSingleWindowEventsProcess
	{

		public QueueUpdateFrequencyEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

