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

	#region Class: LocalMessageSchema

	/// <exclude/>
	public class LocalMessageSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public LocalMessageSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public LocalMessageSchema(LocalMessageSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public LocalMessageSchema(LocalMessageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("77be0245-e5e4-4e4e-a953-5baba9d6ae45");
			RealUId = new Guid("77be0245-e5e4-4e4e-a953-5baba9d6ae45");
			Name = "LocalMessage";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("fbc6b186-99e1-4d4c-b364-60c4cd825fdb");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("a1f10d23-ef64-411c-a1a3-1d2b9a04ba22")) == null) {
				Columns.Add(CreateMessageColumn());
			}
			if (Columns.FindByUId(new Guid("61e46e95-a216-4327-a468-8f6ca2512fd2")) == null) {
				Columns.Add(CreateEntitySchemaUIdColumn());
			}
			if (Columns.FindByUId(new Guid("906fd74d-fc8a-467c-b07f-e55fec5b7565")) == null) {
				Columns.Add(CreateEntityIdColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateMessageColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("a1f10d23-ef64-411c-a1a3-1d2b9a04ba22"),
				Name = @"Message",
				CreatedInSchemaUId = new Guid("77be0245-e5e4-4e4e-a953-5baba9d6ae45"),
				ModifiedInSchemaUId = new Guid("77be0245-e5e4-4e4e-a953-5baba9d6ae45"),
				CreatedInPackageId = new Guid("fbc6b186-99e1-4d4c-b364-60c4cd825fdb")
			};
		}

		protected virtual EntitySchemaColumn CreateEntitySchemaUIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("61e46e95-a216-4327-a468-8f6ca2512fd2"),
				Name = @"EntitySchemaUId",
				CreatedInSchemaUId = new Guid("77be0245-e5e4-4e4e-a953-5baba9d6ae45"),
				ModifiedInSchemaUId = new Guid("77be0245-e5e4-4e4e-a953-5baba9d6ae45"),
				CreatedInPackageId = new Guid("c7e51cd7-a0e6-4ced-adba-1c886021699d")
			};
		}

		protected virtual EntitySchemaColumn CreateEntityIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("906fd74d-fc8a-467c-b07f-e55fec5b7565"),
				Name = @"EntityId",
				CreatedInSchemaUId = new Guid("77be0245-e5e4-4e4e-a953-5baba9d6ae45"),
				ModifiedInSchemaUId = new Guid("77be0245-e5e4-4e4e-a953-5baba9d6ae45"),
				CreatedInPackageId = new Guid("c7e51cd7-a0e6-4ced-adba-1c886021699d")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateLocalMessageEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateLocalMessageEventsProcessSchema() {
			var schema = new LocalMessageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new LocalMessage(userConnection){Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new LocalMessage_LocalMessageEventsProcess(userConnnection);
		}

		public override object Clone() {
			return new LocalMessageSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new LocalMessageSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("77be0245-e5e4-4e4e-a953-5baba9d6ae45"));
		}

		#endregion

	}

	#endregion

	#region Class: LocalMessage

	/// <summary>
	/// Local Message.
	/// </summary>
	public class LocalMessage : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public LocalMessage(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "LocalMessage";
		}

		public LocalMessage(LocalMessage source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Message.
		/// </summary>
		public  string Message {
			get {
				return GetTypedColumnValue<string>("Message");
			}
			set {
				SetColumnValue("Message", value);
			}
		}

		/// <summary>
		/// Schema.
		/// </summary>
		public  Guid EntitySchemaUId {
			get {
				return GetTypedColumnValue<Guid>("EntitySchemaUId");
			}
			set {
				SetColumnValue("EntitySchemaUId", value);
			}
		}

		/// <summary>
		/// EntityId.
		/// </summary>
		public  Guid EntityId {
			get {
				return GetTypedColumnValue<Guid>("EntityId");
			}
			set {
				SetColumnValue("EntityId", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new LocalMessage_LocalMessageEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Inserted += (s, e) => ThrowEvent("LocalMessageInserted", e);
			Validating += (s, e) => ThrowEvent("LocalMessageValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new LocalMessage(this);
		}

		#endregion

	}

	#endregion

	#region Class: LocalMessage_LocalMessageEventsProcess

	/// <exclude/>
	public class LocalMessage_LocalMessageEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_LocalMessageEventsProcess<TEntity> where TEntity : LocalMessage
	{

		public LocalMessage_LocalMessageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "LocalMessage_LocalMessageEventsProcess";
			SchemaUId = new Guid("77be0245-e5e4-4e4e-a953-5baba9d6ae45");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private  Guid InternalSchemaUId {
			get {
				return new Guid("77be0245-e5e4-4e4e-a953-5baba9d6ae45");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		private ProcessFlowElement _eventSubProcess145674674;
		public  ProcessFlowElement EventSubProcess145674674 {
			get {
				return _eventSubProcess145674674 ?? (_eventSubProcess145674674 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess145674674",
					SchemaElementUId = new Guid("ff9699e6-7268-4476-9613-b20336f66eaa"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _localMessageInserted;
		public  ProcessFlowElement LocalMessageInserted {
			get {
				return _localMessageInserted ?? (_localMessageInserted = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "LocalMessageInserted",
					SchemaElementUId = new Guid("b4b996f4-17d5-48ba-ba98-1bab7be992ab"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _notifyListeners;
		public  ProcessScriptTask NotifyListeners {
			get {
				return _notifyListeners ?? (_notifyListeners = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "NotifyListeners",
					SchemaElementUId = new Guid("bb232437-5032-42b4-9640-2c87b12b0c76"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = NotifyListenersExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess145674674.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess145674674 };
			FlowElements[LocalMessageInserted.SchemaElementUId] = new Collection<ProcessFlowElement> { LocalMessageInserted };
			FlowElements[NotifyListeners.SchemaElementUId] = new Collection<ProcessFlowElement> { NotifyListeners };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess145674674":
						break;
					case "LocalMessageInserted":
						e.Context.QueueTasks.Enqueue("NotifyListeners");
						break;
					case "NotifyListeners":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("LocalMessageInserted");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "EventSubProcess145674674":
					context.QueueTasks.Dequeue();
					break;
				case "LocalMessageInserted":
					context.QueueTasks.Dequeue();
					context.SenderName = "LocalMessageInserted";
					result = LocalMessageInserted.Execute(context);
					break;
				case "NotifyListeners":
					context.QueueTasks.Dequeue();
					context.SenderName = "NotifyListeners";
					result = NotifyListeners.Execute(context, NotifyListenersExecute);
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

		public virtual bool NotifyListenersExecute(ProcessExecutingContext context) {
			var notifier = new LocalMessageNotifier(this.Entity);
			var manager = new MessageHistoryManager(UserConnection, notifier);
			manager.Notify();
			return true;
		}

		public override void LocalMessageExecuting(EntityChangeType changeType) {
			var lmHelper = new Terrasoft.Configuration.LocalMessageHelper(this.Entity, UserConnection, changeType);
			lmHelper.CreateLocalMessage();
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "LocalMessageInserted":
							if (ActivatedEventElements.Contains("LocalMessageInserted")) {
							context.QueueTasks.Enqueue("LocalMessageInserted");
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

	#region Class: LocalMessage_LocalMessageEventsProcess

	/// <exclude/>
	public class LocalMessage_LocalMessageEventsProcess : LocalMessage_LocalMessageEventsProcess<LocalMessage>
	{

		public LocalMessage_LocalMessageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: LocalMessageEventsProcessSchema

	/// <exclude/>
	public class LocalMessageEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public LocalMessageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public LocalMessageEventsProcessSchema(LocalMessageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "LocalMessage_LocalMessageEventsProcess";
			UId = new Guid("64297b79-ba02-455d-b39d-b0b38b0ba20a");
			CreatedInPackageId = new Guid("fbc6b186-99e1-4d4c-b364-60c4cd825fdb");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLocalMessageLaneSet = CreateLocalMessageLaneSetLaneSet();
			LaneSets.Add(schemaLocalMessageLaneSet);
			ProcessSchemaLane schemaLocalMessageLane = CreateLocalMessageLaneLane();
			schemaLocalMessageLaneSet.Lanes.Add(schemaLocalMessageLane);
			ProcessSchemaEventSubProcess eventsubprocess145674674 = CreateEventSubProcess145674674EventSubProcess();
			FlowElements.Add(eventsubprocess145674674);
			ProcessSchemaStartMessageEvent localmessageinserted = CreateLocalMessageInsertedStartMessageEvent();
			eventsubprocess145674674.FlowElements.Add(localmessageinserted);
			ProcessSchemaScriptTask notifylisteners = CreateNotifyListenersScriptTask();
			eventsubprocess145674674.FlowElements.Add(notifylisteners);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("ff5295e6-b3bf-40d7-be8e-b935d7f0d61d"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("66f58f21-6ed1-4e29-b506-6b9f6426d463"),
				CreatedInPackageId = new Guid("86d7259d-20eb-44b7-8dc0-0aa7866d53e5"),
				CreatedInSchemaUId = new Guid("64297b79-ba02-455d-b39d-b0b38b0ba20a"),
				CurveCenterPosition = new Point(188, 102),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("64297b79-ba02-455d-b39d-b0b38b0ba20a"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("b4b996f4-17d5-48ba-ba98-1bab7be992ab"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("bb232437-5032-42b4-9640-2c87b12b0c76"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLocalMessageLaneSetLaneSet() {
			ProcessSchemaLaneSet schemaLocalMessageLaneSet = new ProcessSchemaLaneSet(this) {
				UId = new Guid("e7d1cb09-bf02-4aa4-81b6-adc28a4912f6"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("66f58f21-6ed1-4e29-b506-6b9f6426d463"),
				CreatedInPackageId = new Guid("86d7259d-20eb-44b7-8dc0-0aa7866d53e5"),
				CreatedInSchemaUId = new Guid("64297b79-ba02-455d-b39d-b0b38b0ba20a"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("64297b79-ba02-455d-b39d-b0b38b0ba20a"),
				Name = @"LocalMessageLaneSet",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(5, 5),
				Size = new Size(1192, 199),
				UseBackgroundMode = false
			};
			return schemaLocalMessageLaneSet;
		}

		protected virtual ProcessSchemaLane CreateLocalMessageLaneLane() {
			ProcessSchemaLane schemaLocalMessageLane = new ProcessSchemaLane(this) {
				UId = new Guid("036a0492-ac0f-4b86-8b50-89dd23d3a2c5"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("e7d1cb09-bf02-4aa4-81b6-adc28a4912f6"),
				CreatedInOwnerSchemaUId = new Guid("77be0245-e5e4-4e4e-a953-5baba9d6ae45"),
				CreatedInPackageId = new Guid("86d7259d-20eb-44b7-8dc0-0aa7866d53e5"),
				CreatedInSchemaUId = new Guid("64297b79-ba02-455d-b39d-b0b38b0ba20a"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("64297b79-ba02-455d-b39d-b0b38b0ba20a"),
				Name = @"LocalMessageLane",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(29, 0),
				Size = new Size(1163, 199),
				UseBackgroundMode = false
			};
			return schemaLocalMessageLane;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess145674674EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess145674674 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("ff9699e6-7268-4476-9613-b20336f66eaa"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("036a0492-ac0f-4b86-8b50-89dd23d3a2c5"),
				CreatedInOwnerSchemaUId = new Guid("66f58f21-6ed1-4e29-b506-6b9f6426d463"),
				CreatedInPackageId = new Guid("86d7259d-20eb-44b7-8dc0-0aa7866d53e5"),
				CreatedInSchemaUId = new Guid("64297b79-ba02-455d-b39d-b0b38b0ba20a"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("64297b79-ba02-455d-b39d-b0b38b0ba20a"),
				Name = @"EventSubProcess145674674",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(42, 21),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(371, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess145674674;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateLocalMessageInsertedStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("b4b996f4-17d5-48ba-ba98-1bab7be992ab"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ff9699e6-7268-4476-9613-b20336f66eaa"),
				CreatedInOwnerSchemaUId = new Guid("66f58f21-6ed1-4e29-b506-6b9f6426d463"),
				CreatedInPackageId = new Guid("86d7259d-20eb-44b7-8dc0-0aa7866d53e5"),
				CreatedInSchemaUId = new Guid("64297b79-ba02-455d-b39d-b0b38b0ba20a"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"LocalMessageInserted",
				ModifiedInSchemaUId = new Guid("64297b79-ba02-455d-b39d-b0b38b0ba20a"),
				Name = @"LocalMessageInserted",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(50, 58),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateNotifyListenersScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("bb232437-5032-42b4-9640-2c87b12b0c76"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ff9699e6-7268-4476-9613-b20336f66eaa"),
				CreatedInOwnerSchemaUId = new Guid("66f58f21-6ed1-4e29-b506-6b9f6426d463"),
				CreatedInPackageId = new Guid("86d7259d-20eb-44b7-8dc0-0aa7866d53e5"),
				CreatedInSchemaUId = new Guid("64297b79-ba02-455d-b39d-b0b38b0ba20a"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("64297b79-ba02-455d-b39d-b0b38b0ba20a"),
				Name = @"NotifyListeners",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(225, 44),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,75,44,82,200,203,47,201,76,203,76,45,82,176,85,200,75,45,87,240,201,79,78,204,241,77,45,46,78,76,79,245,131,74,105,148,100,100,22,235,185,230,149,100,150,84,106,90,243,114,149,1,181,229,38,230,1,85,192,116,65,53,120,100,22,151,228,23,85,250,66,228,52,66,139,83,139,156,243,243,242,82,147,75,50,243,243,116,224,86,129,204,128,234,215,3,219,81,169,1,18,42,74,45,41,45,202,83,40,41,42,77,181,6,0,161,98,41,235,154,0,0,0 }
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

		protected override SchemaMethod CreateLocalMessageExecutingMethod() {
			SchemaMethod method = base.CreateLocalMessageExecutingMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,77,141,75,10,194,48,16,134,247,158,98,150,45,148,92,160,184,42,130,11,221,213,3,12,225,111,26,136,147,50,51,86,122,123,45,69,112,255,61,86,86,42,207,43,202,2,165,51,9,222,52,66,149,173,78,30,134,42,83,78,47,101,207,85,194,173,70,46,119,152,113,194,33,52,62,103,11,23,241,236,91,71,15,131,126,13,65,220,241,142,226,204,146,48,110,11,218,254,244,123,132,65,193,142,255,86,211,246,31,106,54,191,216,134,0,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new LocalMessageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("64297b79-ba02-455d-b39d-b0b38b0ba20a"));
		}

		#endregion

	}

	#endregion


	#region Class: LocalMessageEventsProcess

	/// <exclude/>
	public class LocalMessageEventsProcess : LocalMessage_LocalMessageEventsProcess
	{

		public LocalMessageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

