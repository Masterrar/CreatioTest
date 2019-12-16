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

	#region Class: QueueStatusSchema

	/// <exclude/>
	public class QueueStatusSchema : Terrasoft.Configuration.BaseLookupSchema
	{

		#region Constructors: Public

		public QueueStatusSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public QueueStatusSchema(QueueStatusSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public QueueStatusSchema(QueueStatusSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("749b84e0-9db9-4883-9303-ffc09ea14ecc");
			RealUId = new Guid("749b84e0-9db9-4883-9303-ffc09ea14ecc");
			Name = "QueueStatus";
			ParentSchemaUId = new Guid("11ab4bcb-9b23-4b6d-9c86-520fae925d75");
			ExtendParent = false;
			CreatedInPackageId = new Guid("f218b7b3-8c78-4ff0-aa0a-44d361bf4ae4");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("62d58a77-e861-4875-a481-f7ba7617949f")) == null) {
				Columns.Add(CreateIsInitialColumn());
			}
			if (Columns.FindByUId(new Guid("1125807f-5e6c-4a98-8c35-4e40db800ed1")) == null) {
				Columns.Add(CreateIsFinalColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateIsInitialColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("62d58a77-e861-4875-a481-f7ba7617949f"),
				Name = @"IsInitial",
				CreatedInSchemaUId = new Guid("749b84e0-9db9-4883-9303-ffc09ea14ecc"),
				ModifiedInSchemaUId = new Guid("749b84e0-9db9-4883-9303-ffc09ea14ecc"),
				CreatedInPackageId = new Guid("7be0af39-38cd-442a-b589-d8f3ef3f4d19")
			};
		}

		protected virtual EntitySchemaColumn CreateIsFinalColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("1125807f-5e6c-4a98-8c35-4e40db800ed1"),
				Name = @"IsFinal",
				CreatedInSchemaUId = new Guid("749b84e0-9db9-4883-9303-ffc09ea14ecc"),
				ModifiedInSchemaUId = new Guid("749b84e0-9db9-4883-9303-ffc09ea14ecc"),
				CreatedInPackageId = new Guid("7be0af39-38cd-442a-b589-d8f3ef3f4d19")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateQueueStatusEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateQueueStatusEventsProcessSchema() {
			var schema = new QueueStatusEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new QueueStatus(userConnection){Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new QueueStatus_OperatorSingleWindowEventsProcess(userConnnection);
		}

		public override object Clone() {
			return new QueueStatusSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new QueueStatusSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("749b84e0-9db9-4883-9303-ffc09ea14ecc"));
		}

		#endregion

	}

	#endregion

	#region Class: QueueStatus

	/// <summary>
	/// Agent desktop queue status.
	/// </summary>
	public class QueueStatus : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public QueueStatus(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "QueueStatus";
		}

		public QueueStatus(QueueStatus source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// New.
		/// </summary>
		public  bool IsInitial {
			get {
				return GetTypedColumnValue<bool>("IsInitial");
			}
			set {
				SetColumnValue("IsInitial", value);
			}
		}

		/// <summary>
		/// Final.
		/// </summary>
		public  bool IsFinal {
			get {
				return GetTypedColumnValue<bool>("IsFinal");
			}
			set {
				SetColumnValue("IsFinal", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new QueueStatus_OperatorSingleWindowEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Saved += (s, e) => ThrowEvent("QueueStatusSaved", e);
			Validating += (s, e) => ThrowEvent("QueueStatusValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new QueueStatus(this);
		}

		#endregion

	}

	#endregion

	#region Class: QueueStatus_OperatorSingleWindowEventsProcess

	/// <exclude/>
	public class QueueStatus_OperatorSingleWindowEventsProcess<TEntity> : Terrasoft.Configuration.BaseLookup_BaseEventsProcess<TEntity> where TEntity : QueueStatus
	{

		public QueueStatus_OperatorSingleWindowEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "QueueStatus_OperatorSingleWindowEventsProcess";
			SchemaUId = new Guid("749b84e0-9db9-4883-9303-ffc09ea14ecc");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private  Guid InternalSchemaUId {
			get {
				return new Guid("749b84e0-9db9-4883-9303-ffc09ea14ecc");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		private ProcessFlowElement _eventSubProcess3_fcae09c63f4e45bf843931f2d37e9dcf;
		public  ProcessFlowElement EventSubProcess3_fcae09c63f4e45bf843931f2d37e9dcf {
			get {
				return _eventSubProcess3_fcae09c63f4e45bf843931f2d37e9dcf ?? (_eventSubProcess3_fcae09c63f4e45bf843931f2d37e9dcf = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess3_fcae09c63f4e45bf843931f2d37e9dcf",
					SchemaElementUId = new Guid("fcae09c6-3f4e-45bf-8439-31f2d37e9dcf"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _queueStatusSavedMessage;
		public  ProcessFlowElement QueueStatusSavedMessage {
			get {
				return _queueStatusSavedMessage ?? (_queueStatusSavedMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "QueueStatusSavedMessage",
					SchemaElementUId = new Guid("062f67e3-4410-49e1-b59e-e4c6eecb5565"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTask_QueueStatusSaved;
		public  ProcessScriptTask ScriptTask_QueueStatusSaved {
			get {
				return _scriptTask_QueueStatusSaved ?? (_scriptTask_QueueStatusSaved = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask_QueueStatusSaved",
					SchemaElementUId = new Guid("4af156eb-0dc6-457e-88c1-3f147effce17"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask_QueueStatusSavedExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess3_fcae09c63f4e45bf843931f2d37e9dcf.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess3_fcae09c63f4e45bf843931f2d37e9dcf };
			FlowElements[QueueStatusSavedMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { QueueStatusSavedMessage };
			FlowElements[ScriptTask_QueueStatusSaved.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask_QueueStatusSaved };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess3_fcae09c63f4e45bf843931f2d37e9dcf":
						break;
					case "QueueStatusSavedMessage":
						e.Context.QueueTasks.Enqueue("ScriptTask_QueueStatusSaved");
						break;
					case "ScriptTask_QueueStatusSaved":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("QueueStatusSavedMessage");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "EventSubProcess3_fcae09c63f4e45bf843931f2d37e9dcf":
					context.QueueTasks.Dequeue();
					break;
				case "QueueStatusSavedMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "QueueStatusSavedMessage";
					result = QueueStatusSavedMessage.Execute(context);
					break;
				case "ScriptTask_QueueStatusSaved":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask_QueueStatusSaved";
					result = ScriptTask_QueueStatusSaved.Execute(context, ScriptTask_QueueStatusSavedExecute);
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

		public virtual bool ScriptTask_QueueStatusSavedExecute(ProcessExecutingContext context) {
			QueueCacheHelper.ClearCache();
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "QueueStatusSaved":
							if (ActivatedEventElements.Contains("QueueStatusSavedMessage")) {
							context.QueueTasks.Enqueue("QueueStatusSavedMessage");
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

	#region Class: QueueStatus_OperatorSingleWindowEventsProcess

	/// <exclude/>
	public class QueueStatus_OperatorSingleWindowEventsProcess : QueueStatus_OperatorSingleWindowEventsProcess<QueueStatus>
	{

		public QueueStatus_OperatorSingleWindowEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: QueueStatusEventsProcessSchema

	/// <exclude/>
	public class QueueStatusEventsProcessSchema : Terrasoft.Configuration.BaseLookupEventsProcessSchema
	{

		#region Constructors: Public

		public QueueStatusEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public QueueStatusEventsProcessSchema(QueueStatusEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "QueueStatus_OperatorSingleWindowEventsProcess";
			UId = new Guid("4a5477c2-62cc-4e4f-8b3d-6fc9a8c00945");
			CreatedInPackageId = new Guid("f218b7b3-8c78-4ff0-aa0a-44d361bf4ae4");
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
			ProcessSchemaLaneSet schemaLaneSet2_92ae5f7c168a453db0a854d17a8d008e = CreateLaneSet2_92ae5f7c168a453db0a854d17a8d008eLaneSet();
			LaneSets.Add(schemaLaneSet2_92ae5f7c168a453db0a854d17a8d008e);
			ProcessSchemaLane schemaLane1_71556abc71b74e4ca3c8d70ccda5edfb = CreateLane1_71556abc71b74e4ca3c8d70ccda5edfbLane();
			schemaLaneSet2_92ae5f7c168a453db0a854d17a8d008e.Lanes.Add(schemaLane1_71556abc71b74e4ca3c8d70ccda5edfb);
			ProcessSchemaEventSubProcess eventsubprocess3_fcae09c63f4e45bf843931f2d37e9dcf = CreateEventSubProcess3_fcae09c63f4e45bf843931f2d37e9dcfEventSubProcess();
			FlowElements.Add(eventsubprocess3_fcae09c63f4e45bf843931f2d37e9dcf);
			ProcessSchemaStartMessageEvent queuestatussavedmessage = CreateQueueStatusSavedMessageStartMessageEvent();
			eventsubprocess3_fcae09c63f4e45bf843931f2d37e9dcf.FlowElements.Add(queuestatussavedmessage);
			ProcessSchemaScriptTask scripttask_queuestatussaved = CreateScriptTask_QueueStatusSavedScriptTask();
			eventsubprocess3_fcae09c63f4e45bf843931f2d37e9dcf.FlowElements.Add(scripttask_queuestatussaved);
			FlowElements.Add(CreateSequenceFlow4_a9970fc7268c4c6a9009421f36ecd719SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4_a9970fc7268c4c6a9009421f36ecd719SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4_a9970fc7268c4c6a9009421f36ecd719",
				UId = new Guid("a9970fc7-268c-4c6a-9009-421f36ecd719"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("e20c0489-122a-4242-999c-169e8e866fc1"),
				CreatedInPackageId = new Guid("32e311e2-322a-4bd2-a082-89dd3de597a9"),
				CreatedInSchemaUId = new Guid("4a5477c2-62cc-4e4f-8b3d-6fc9a8c00945"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("4a5477c2-62cc-4e4f-8b3d-6fc9a8c00945"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("062f67e3-4410-49e1-b59e-e4c6eecb5565"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("4af156eb-0dc6-457e-88c1-3f147effce17"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet2_92ae5f7c168a453db0a854d17a8d008eLaneSet() {
			ProcessSchemaLaneSet schemaLaneSet2_92ae5f7c168a453db0a854d17a8d008e = new ProcessSchemaLaneSet(this) {
				UId = new Guid("92ae5f7c-168a-453d-b0a8-54d17a8d008e"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("e20c0489-122a-4242-999c-169e8e866fc1"),
				CreatedInPackageId = new Guid("32e311e2-322a-4bd2-a082-89dd3de597a9"),
				CreatedInSchemaUId = new Guid("4a5477c2-62cc-4e4f-8b3d-6fc9a8c00945"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("4a5477c2-62cc-4e4f-8b3d-6fc9a8c00945"),
				Name = @"LaneSet2_92ae5f7c168a453db0a854d17a8d008e",
				Position = new Point(0, 5),
				Size = new Size(0, 400),
				UseBackgroundMode = false
			};
			return schemaLaneSet2_92ae5f7c168a453db0a854d17a8d008e;
		}

		protected virtual ProcessSchemaLane CreateLane1_71556abc71b74e4ca3c8d70ccda5edfbLane() {
			ProcessSchemaLane schemaLane1_71556abc71b74e4ca3c8d70ccda5edfb = new ProcessSchemaLane(this) {
				UId = new Guid("71556abc-71b7-4e4c-a3c8-d70ccda5edfb"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("92ae5f7c-168a-453d-b0a8-54d17a8d008e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("32e311e2-322a-4bd2-a082-89dd3de597a9"),
				CreatedInSchemaUId = new Guid("4a5477c2-62cc-4e4f-8b3d-6fc9a8c00945"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("4a5477c2-62cc-4e4f-8b3d-6fc9a8c00945"),
				Name = @"Lane1_71556abc71b74e4ca3c8d70ccda5edfb",
				Position = new Point(0, 0),
				Size = new Size(700, 400),
				UseBackgroundMode = false
			};
			return schemaLane1_71556abc71b74e4ca3c8d70ccda5edfb;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess3_fcae09c63f4e45bf843931f2d37e9dcfEventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess3_fcae09c63f4e45bf843931f2d37e9dcf = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("fcae09c6-3f4e-45bf-8439-31f2d37e9dcf"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("71556abc-71b7-4e4c-a3c8-d70ccda5edfb"),
				CreatedInOwnerSchemaUId = new Guid("e20c0489-122a-4242-999c-169e8e866fc1"),
				CreatedInPackageId = new Guid("32e311e2-322a-4bd2-a082-89dd3de597a9"),
				CreatedInSchemaUId = new Guid("4a5477c2-62cc-4e4f-8b3d-6fc9a8c00945"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("4a5477c2-62cc-4e4f-8b3d-6fc9a8c00945"),
				Name = @"EventSubProcess3_fcae09c63f4e45bf843931f2d37e9dcf",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(35, 34),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(268, 146),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess3_fcae09c63f4e45bf843931f2d37e9dcf;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateQueueStatusSavedMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("062f67e3-4410-49e1-b59e-e4c6eecb5565"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("fcae09c6-3f4e-45bf-8439-31f2d37e9dcf"),
				CreatedInOwnerSchemaUId = new Guid("e20c0489-122a-4242-999c-169e8e866fc1"),
				CreatedInPackageId = new Guid("32e311e2-322a-4bd2-a082-89dd3de597a9"),
				CreatedInSchemaUId = new Guid("4a5477c2-62cc-4e4f-8b3d-6fc9a8c00945"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"QueueStatusSaved",
				ModifiedInSchemaUId = new Guid("4a5477c2-62cc-4e4f-8b3d-6fc9a8c00945"),
				Name = @"QueueStatusSavedMessage",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(38, 52),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask_QueueStatusSavedScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("4af156eb-0dc6-457e-88c1-3f147effce17"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("fcae09c6-3f4e-45bf-8439-31f2d37e9dcf"),
				CreatedInOwnerSchemaUId = new Guid("e20c0489-122a-4242-999c-169e8e866fc1"),
				CreatedInPackageId = new Guid("32e311e2-322a-4bd2-a082-89dd3de597a9"),
				CreatedInSchemaUId = new Guid("4a5477c2-62cc-4e4f-8b3d-6fc9a8c00945"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("4a5477c2-62cc-4e4f-8b3d-6fc9a8c00945"),
				Name = @"ScriptTask_QueueStatusSaved",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(159, 38),
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
			return new QueueStatusEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("4a5477c2-62cc-4e4f-8b3d-6fc9a8c00945"));
		}

		#endregion

	}

	#endregion


	#region Class: QueueStatusEventsProcess

	/// <exclude/>
	public class QueueStatusEventsProcess : QueueStatus_OperatorSingleWindowEventsProcess
	{

		public QueueStatusEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

