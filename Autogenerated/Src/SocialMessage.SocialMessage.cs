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
	using System.Security;
	using System.Text.RegularExpressions;
	using Terrasoft.Common;
	using Terrasoft.Common.Json;
	using Terrasoft.Configuration;
	using Terrasoft.Configuration.RightsService;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.DcmProcess;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Factories;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;
	using Terrasoft.GlobalSearch.Indexing;
	using Terrasoft.Messaging.Common;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities.Json.Converters;

	#region Class: SocialMessageSchema

	/// <exclude/>
	public class SocialMessageSchema : Terrasoft.Configuration.SocialMessage_ESN_TerrasoftSchema
	{

		#region Constructors: Public

		public SocialMessageSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public SocialMessageSchema(SocialMessageSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public SocialMessageSchema(SocialMessageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("484d4617-cde2-455d-93d8-98f58bf85cbb");
			Name = "SocialMessage";
			ParentSchemaUId = new Guid("b0e78c23-7095-4d59-b8eb-c10243bcd67b");
			ExtendParent = true;
			CreatedInPackageId = new Guid("54cf5269-6f00-4e87-a6e6-8261561e21be");
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
			EventsProcessSchema = CreateSocialMessageEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateSocialMessageEventsProcessSchema() {
			var schema = new SocialMessageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new SocialMessage(userConnection){Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new SocialMessage_SocialMessageEventsProcess(userConnnection);
		}

		public override object Clone() {
			return new SocialMessageSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new SocialMessageSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("484d4617-cde2-455d-93d8-98f58bf85cbb"));
		}

		#endregion

	}

	#endregion

	#region Class: SocialMessage

	/// <summary>
	/// Message/comment.
	/// </summary>
	public class SocialMessage : Terrasoft.Configuration.SocialMessage_ESN_Terrasoft
	{

		#region Constructors: Public

		public SocialMessage(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "SocialMessage";
		}

		public SocialMessage(SocialMessage source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new SocialMessage_SocialMessageEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Inserted += (s, e) => ThrowEvent("SocialMessageInserted", e);
			Saved += (s, e) => ThrowEvent("SocialMessageSaved", e);
			Updated += (s, e) => ThrowEvent("SocialMessageUpdated", e);
			Validating += (s, e) => ThrowEvent("SocialMessageValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SocialMessage(this);
		}

		#endregion

	}

	#endregion

	#region Class: SocialMessage_SocialMessageEventsProcess

	/// <exclude/>
	public class SocialMessage_SocialMessageEventsProcess<TEntity> : Terrasoft.Configuration.SocialMessage_ESNEventsProcess<TEntity> where TEntity : SocialMessage
	{

		public SocialMessage_SocialMessageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SocialMessage_SocialMessageEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("484d4617-cde2-455d-93d8-98f58bf85cbb");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		private ProcessFlowElement _socialMessageEventSubProcess1;
		public ProcessFlowElement SocialMessageEventSubProcess1 {
			get {
				return _socialMessageEventSubProcess1 ?? (_socialMessageEventSubProcess1 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "SocialMessageEventSubProcess1",
					SchemaElementUId = new Guid("eeb06647-78c1-4911-98dc-ffc6f020d7ee"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _socSocialMessageInsertedChildMessage;
		public ProcessFlowElement SocSocialMessageInsertedChildMessage {
			get {
				return _socSocialMessageInsertedChildMessage ?? (_socSocialMessageInsertedChildMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "SocSocialMessageInsertedChildMessage",
					SchemaElementUId = new Guid("db10de47-b4d3-4b8c-a001-f1dd2024cbfd"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessThrowMessageEvent _socialMessageInsertedChildToParentMessage;
		public ProcessThrowMessageEvent SocialMessageInsertedChildToParentMessage {
			get {
				return _socialMessageInsertedChildToParentMessage ?? (_socialMessageInsertedChildToParentMessage = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "SocialMessageInsertedChildToParentMessage",
					SchemaElementUId = new Guid("61b04ce4-a816-4c1c-83a9-f3dd518da3c1"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "SocialMessageInserted",
						ThrowToBase = true,
				});
			}
		}

		private ProcessScriptTask _notifyListenersScriptTask;
		public ProcessScriptTask NotifyListenersScriptTask {
			get {
				return _notifyListenersScriptTask ?? (_notifyListenersScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "NotifyListenersScriptTask",
					SchemaElementUId = new Guid("31a5ebf0-03a1-4fca-a0dc-68d97eb27d62"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = NotifyListenersScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _socialMessageEventSubProcessUpdate;
		public ProcessFlowElement SocialMessageEventSubProcessUpdate {
			get {
				return _socialMessageEventSubProcessUpdate ?? (_socialMessageEventSubProcessUpdate = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "SocialMessageEventSubProcessUpdate",
					SchemaElementUId = new Guid("4e83c29d-9c37-4df3-a7e2-2c8a7161fd52"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _socialMessageUpdatedChildMessage;
		public ProcessFlowElement SocialMessageUpdatedChildMessage {
			get {
				return _socialMessageUpdatedChildMessage ?? (_socialMessageUpdatedChildMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "SocialMessageUpdatedChildMessage",
					SchemaElementUId = new Guid("21ad5aad-f657-45ab-a37b-8954b8467253"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessThrowMessageEvent _socialMessageUpdatedChildToParentMessage;
		public ProcessThrowMessageEvent SocialMessageUpdatedChildToParentMessage {
			get {
				return _socialMessageUpdatedChildToParentMessage ?? (_socialMessageUpdatedChildToParentMessage = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "SocialMessageUpdatedChildToParentMessage",
					SchemaElementUId = new Guid("7e8b2139-362c-4e7e-9819-1d9946850819"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "SocialMessageUpdated",
						ThrowToBase = true,
				});
			}
		}

		private ProcessScriptTask _updateNotifyListenersScriptTaks;
		public ProcessScriptTask UpdateNotifyListenersScriptTaks {
			get {
				return _updateNotifyListenersScriptTaks ?? (_updateNotifyListenersScriptTaks = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "UpdateNotifyListenersScriptTaks",
					SchemaElementUId = new Guid("fef7c93c-33b0-4b62-bb90-c20f27103d4f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = UpdateNotifyListenersScriptTaksExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[SocialMessageEventSubProcess1.SchemaElementUId] = new Collection<ProcessFlowElement> { SocialMessageEventSubProcess1 };
			FlowElements[SocSocialMessageInsertedChildMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { SocSocialMessageInsertedChildMessage };
			FlowElements[SocialMessageInsertedChildToParentMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { SocialMessageInsertedChildToParentMessage };
			FlowElements[NotifyListenersScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { NotifyListenersScriptTask };
			FlowElements[SocialMessageEventSubProcessUpdate.SchemaElementUId] = new Collection<ProcessFlowElement> { SocialMessageEventSubProcessUpdate };
			FlowElements[SocialMessageUpdatedChildMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { SocialMessageUpdatedChildMessage };
			FlowElements[SocialMessageUpdatedChildToParentMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { SocialMessageUpdatedChildToParentMessage };
			FlowElements[UpdateNotifyListenersScriptTaks.SchemaElementUId] = new Collection<ProcessFlowElement> { UpdateNotifyListenersScriptTaks };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "SocialMessageEventSubProcess1":
						break;
					case "SocSocialMessageInsertedChildMessage":
						e.Context.QueueTasks.Enqueue("SocialMessageInsertedChildToParentMessage");
						break;
					case "SocialMessageInsertedChildToParentMessage":
						e.Context.QueueTasks.Enqueue("NotifyListenersScriptTask");
						break;
					case "NotifyListenersScriptTask":
						break;
					case "SocialMessageEventSubProcessUpdate":
						break;
					case "SocialMessageUpdatedChildMessage":
						e.Context.QueueTasks.Enqueue("SocialMessageUpdatedChildToParentMessage");
						break;
					case "SocialMessageUpdatedChildToParentMessage":
						e.Context.QueueTasks.Enqueue("UpdateNotifyListenersScriptTaks");
						break;
					case "UpdateNotifyListenersScriptTaks":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("SocSocialMessageInsertedChildMessage");
			ActivatedEventElements.Add("SocialMessageUpdatedChildMessage");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "SocialMessageEventSubProcess1":
					context.QueueTasks.Dequeue();
					break;
				case "SocSocialMessageInsertedChildMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "SocSocialMessageInsertedChildMessage";
					result = SocSocialMessageInsertedChildMessage.Execute(context);
					break;
				case "SocialMessageInsertedChildToParentMessage":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "SocialMessageInserted");
					result = SocialMessageInsertedChildToParentMessage.Execute(context);
					break;
				case "NotifyListenersScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "NotifyListenersScriptTask";
					result = NotifyListenersScriptTask.Execute(context, NotifyListenersScriptTaskExecute);
					break;
				case "SocialMessageEventSubProcessUpdate":
					context.QueueTasks.Dequeue();
					break;
				case "SocialMessageUpdatedChildMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "SocialMessageUpdatedChildMessage";
					result = SocialMessageUpdatedChildMessage.Execute(context);
					break;
				case "SocialMessageUpdatedChildToParentMessage":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "SocialMessageUpdated");
					result = SocialMessageUpdatedChildToParentMessage.Execute(context);
					break;
				case "UpdateNotifyListenersScriptTaks":
					context.QueueTasks.Dequeue();
					context.SenderName = "UpdateNotifyListenersScriptTaks";
					result = UpdateNotifyListenersScriptTaks.Execute(context, UpdateNotifyListenersScriptTaksExecute);
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

		public virtual bool NotifyListenersScriptTaskExecute(ProcessExecutingContext context) {
			var notifier = new SocialMessageNotifier(this.Entity);
			var manager = new MessageHistoryManager(UserConnection, notifier);
			manager.Notify();
			return true;
		}

		public virtual bool UpdateNotifyListenersScriptTaksExecute(ProcessExecutingContext context) {
			if (UserConnection.GetIsFeatureEnabled("CanUpdateHistoryMessage")) {
				var notifier = new SocialMessageNotifier(this.Entity);
				var manager = new MessageHistoryManager(UserConnection, notifier);
				manager.Notify();
			}
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "SocialMessageInserted":
							if (ActivatedEventElements.Contains("SocSocialMessageInsertedChildMessage")) {
							context.QueueTasks.Enqueue("SocSocialMessageInsertedChildMessage");
							ProcessQueue(context);
							return;
						}
						break;
					case "SocialMessageUpdated":
							if (ActivatedEventElements.Contains("SocialMessageUpdatedChildMessage")) {
							context.QueueTasks.Enqueue("SocialMessageUpdatedChildMessage");
							ProcessQueue(context);
							return;
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

	#region Class: SocialMessage_SocialMessageEventsProcess

	/// <exclude/>
	public class SocialMessage_SocialMessageEventsProcess : SocialMessage_SocialMessageEventsProcess<SocialMessage>
	{

		public SocialMessage_SocialMessageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SocialMessageEventsProcessSchema

	/// <exclude/>
	public class SocialMessageEventsProcessSchema : Terrasoft.Configuration.SocialMessage_ESN_TerrasoftEventsProcessSchema
	{

		#region Constructors: Public

		public SocialMessageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public SocialMessageEventsProcessSchema(SocialMessageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "SocialMessage_SocialMessageEventsProcess";
			UId = new Guid("d8b9d018-b420-4f2e-97fe-57bbd734d4ce");
			CreatedInPackageId = new Guid("54cf5269-6f00-4e87-a6e6-8261561e21be");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("dd1b8305-7550-48b6-b8db-f82d66310892");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaSocialMessageLaneSet = CreateSocialMessageLaneSetLaneSet();
			LaneSets.Add(schemaSocialMessageLaneSet);
			ProcessSchemaLane schemaSocialMessageLane = CreateSocialMessageLaneLane();
			schemaSocialMessageLaneSet.Lanes.Add(schemaSocialMessageLane);
			ProcessSchemaEventSubProcess socialmessageeventsubprocess1 = CreateSocialMessageEventSubProcess1EventSubProcess();
			FlowElements.Add(socialmessageeventsubprocess1);
			ProcessSchemaEventSubProcess socialmessageeventsubprocessupdate = CreateSocialMessageEventSubProcessUpdateEventSubProcess();
			FlowElements.Add(socialmessageeventsubprocessupdate);
			ProcessSchemaStartMessageEvent socsocialmessageinsertedchildmessage = CreateSocSocialMessageInsertedChildMessageStartMessageEvent();
			socialmessageeventsubprocess1.FlowElements.Add(socsocialmessageinsertedchildmessage);
			ProcessSchemaIntermediateThrowMessageEvent socialmessageinsertedchildtoparentmessage = CreateSocialMessageInsertedChildToParentMessageIntermediateThrowMessageEvent();
			socialmessageeventsubprocess1.FlowElements.Add(socialmessageinsertedchildtoparentmessage);
			ProcessSchemaScriptTask notifylistenersscripttask = CreateNotifyListenersScriptTaskScriptTask();
			socialmessageeventsubprocess1.FlowElements.Add(notifylistenersscripttask);
			ProcessSchemaStartMessageEvent socialmessageupdatedchildmessage = CreateSocialMessageUpdatedChildMessageStartMessageEvent();
			socialmessageeventsubprocessupdate.FlowElements.Add(socialmessageupdatedchildmessage);
			ProcessSchemaIntermediateThrowMessageEvent socialmessageupdatedchildtoparentmessage = CreateSocialMessageUpdatedChildToParentMessageIntermediateThrowMessageEvent();
			socialmessageeventsubprocessupdate.FlowElements.Add(socialmessageupdatedchildtoparentmessage);
			ProcessSchemaScriptTask updatenotifylistenersscripttaks = CreateUpdateNotifyListenersScriptTaksScriptTask();
			socialmessageeventsubprocessupdate.FlowElements.Add(updatenotifylistenersscripttaks);
			FlowElements.Add(CreateSequenceFlow9468748SequenceFlow());
			FlowElements.Add(CreateSequenceFlow1026546SequenceFlow());
			FlowElements.Add(CreateSequenceFlow13_71e5cc9feeac4ae9a0e016969150a199SequenceFlow());
			FlowElements.Add(CreateSequenceFlow14_9786b56ebb0e49f3971e44a4e43ad0eaSequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow9468748SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow9468748",
				UId = new Guid("4ca8e96d-e734-4f05-8701-120d86a832af"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("dd1b8305-7550-48b6-b8db-f82d66310892"),
				CreatedInPackageId = new Guid("54cf5269-6f00-4e87-a6e6-8261561e21be"),
				CreatedInSchemaUId = new Guid("d8b9d018-b420-4f2e-97fe-57bbd734d4ce"),
				CurveCenterPosition = new Point(214, 82),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("d8b9d018-b420-4f2e-97fe-57bbd734d4ce"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("db10de47-b4d3-4b8c-a001-f1dd2024cbfd"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("61b04ce4-a816-4c1c-83a9-f3dd518da3c1"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1026546SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1026546",
				UId = new Guid("1e5cf18c-d2b8-4086-b092-147f4ea2f895"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("dd1b8305-7550-48b6-b8db-f82d66310892"),
				CreatedInPackageId = new Guid("54cf5269-6f00-4e87-a6e6-8261561e21be"),
				CreatedInSchemaUId = new Guid("d8b9d018-b420-4f2e-97fe-57bbd734d4ce"),
				CurveCenterPosition = new Point(367, 85),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("d8b9d018-b420-4f2e-97fe-57bbd734d4ce"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("61b04ce4-a816-4c1c-83a9-f3dd518da3c1"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("31a5ebf0-03a1-4fca-a0dc-68d97eb27d62"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow13_71e5cc9feeac4ae9a0e016969150a199SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow13_71e5cc9feeac4ae9a0e016969150a199",
				UId = new Guid("71e5cc9f-eeac-4ae9-a0e0-16969150a199"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("dd1b8305-7550-48b6-b8db-f82d66310892"),
				CreatedInPackageId = new Guid("8c729234-c444-46c1-a762-a0bd5f993895"),
				CreatedInSchemaUId = new Guid("d8b9d018-b420-4f2e-97fe-57bbd734d4ce"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("d8b9d018-b420-4f2e-97fe-57bbd734d4ce"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("21ad5aad-f657-45ab-a37b-8954b8467253"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("7e8b2139-362c-4e7e-9819-1d9946850819"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow14_9786b56ebb0e49f3971e44a4e43ad0eaSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow14_9786b56ebb0e49f3971e44a4e43ad0ea",
				UId = new Guid("9786b56e-bb0e-49f3-971e-44a4e43ad0ea"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("dd1b8305-7550-48b6-b8db-f82d66310892"),
				CreatedInPackageId = new Guid("8c729234-c444-46c1-a762-a0bd5f993895"),
				CreatedInSchemaUId = new Guid("d8b9d018-b420-4f2e-97fe-57bbd734d4ce"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("d8b9d018-b420-4f2e-97fe-57bbd734d4ce"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("7e8b2139-362c-4e7e-9819-1d9946850819"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("fef7c93c-33b0-4b62-bb90-c20f27103d4f"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateSocialMessageLaneSetLaneSet() {
			ProcessSchemaLaneSet schemaSocialMessageLaneSet = new ProcessSchemaLaneSet(this) {
				UId = new Guid("aeb215f1-5bb6-4887-82ab-5e6f25079893"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("dd1b8305-7550-48b6-b8db-f82d66310892"),
				CreatedInPackageId = new Guid("54cf5269-6f00-4e87-a6e6-8261561e21be"),
				CreatedInSchemaUId = new Guid("d8b9d018-b420-4f2e-97fe-57bbd734d4ce"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("d8b9d018-b420-4f2e-97fe-57bbd734d4ce"),
				Name = @"SocialMessageLaneSet",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(5, 5),
				Size = new Size(909, 177),
				UseBackgroundMode = false
			};
			return schemaSocialMessageLaneSet;
		}

		protected virtual ProcessSchemaLane CreateSocialMessageLaneLane() {
			ProcessSchemaLane schemaSocialMessageLane = new ProcessSchemaLane(this) {
				UId = new Guid("360d0932-586a-41b0-8edb-7c58edda5a52"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("aeb215f1-5bb6-4887-82ab-5e6f25079893"),
				CreatedInOwnerSchemaUId = new Guid("484d4617-cde2-455d-93d8-98f58bf85cbb"),
				CreatedInPackageId = new Guid("54cf5269-6f00-4e87-a6e6-8261561e21be"),
				CreatedInSchemaUId = new Guid("d8b9d018-b420-4f2e-97fe-57bbd734d4ce"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("d8b9d018-b420-4f2e-97fe-57bbd734d4ce"),
				Name = @"SocialMessageLane",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(29, 0),
				Size = new Size(880, 177),
				UseBackgroundMode = false
			};
			return schemaSocialMessageLane;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSocialMessageEventSubProcess1EventSubProcess() {
			ProcessSchemaEventSubProcess schemaSocialMessageEventSubProcess1 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("eeb06647-78c1-4911-98dc-ffc6f020d7ee"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("360d0932-586a-41b0-8edb-7c58edda5a52"),
				CreatedInOwnerSchemaUId = new Guid("dd1b8305-7550-48b6-b8db-f82d66310892"),
				CreatedInPackageId = new Guid("54cf5269-6f00-4e87-a6e6-8261561e21be"),
				CreatedInSchemaUId = new Guid("d8b9d018-b420-4f2e-97fe-57bbd734d4ce"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("d8b9d018-b420-4f2e-97fe-57bbd734d4ce"),
				Name = @"SocialMessageEventSubProcess1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(35, 20),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(485, 200),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSocialMessageEventSubProcess1;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateSocSocialMessageInsertedChildMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("db10de47-b4d3-4b8c-a001-f1dd2024cbfd"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("eeb06647-78c1-4911-98dc-ffc6f020d7ee"),
				CreatedInOwnerSchemaUId = new Guid("dd1b8305-7550-48b6-b8db-f82d66310892"),
				CreatedInPackageId = new Guid("54cf5269-6f00-4e87-a6e6-8261561e21be"),
				CreatedInSchemaUId = new Guid("d8b9d018-b420-4f2e-97fe-57bbd734d4ce"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"SocialMessageInserted",
				ModifiedInSchemaUId = new Guid("d8b9d018-b420-4f2e-97fe-57bbd734d4ce"),
				Name = @"SocSocialMessageInsertedChildMessage",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(57, 58),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateSocialMessageInsertedChildToParentMessageIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("61b04ce4-a816-4c1c-83a9-f3dd518da3c1"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("eeb06647-78c1-4911-98dc-ffc6f020d7ee"),
				CreatedInOwnerSchemaUId = new Guid("dd1b8305-7550-48b6-b8db-f82d66310892"),
				CreatedInPackageId = new Guid("54cf5269-6f00-4e87-a6e6-8261561e21be"),
				CreatedInSchemaUId = new Guid("d8b9d018-b420-4f2e-97fe-57bbd734d4ce"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"SocialMessageInserted",
				ModifiedInSchemaUId = new Guid("d8b9d018-b420-4f2e-97fe-57bbd734d4ce"),
				Name = @"SocialMessageInsertedChildToParentMessage",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(190, 58),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateNotifyListenersScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("31a5ebf0-03a1-4fca-a0dc-68d97eb27d62"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("eeb06647-78c1-4911-98dc-ffc6f020d7ee"),
				CreatedInOwnerSchemaUId = new Guid("dd1b8305-7550-48b6-b8db-f82d66310892"),
				CreatedInPackageId = new Guid("54cf5269-6f00-4e87-a6e6-8261561e21be"),
				CreatedInSchemaUId = new Guid("d8b9d018-b420-4f2e-97fe-57bbd734d4ce"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("d8b9d018-b420-4f2e-97fe-57bbd734d4ce"),
				Name = @"NotifyListenersScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(330, 44),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,61,141,77,10,131,64,12,133,247,133,222,33,203,17,138,23,144,174,138,224,198,110,138,7,24,36,218,64,77,32,137,202,220,222,159,78,187,125,223,251,222,91,162,2,139,211,64,168,112,7,198,21,94,210,83,252,180,104,22,71,124,102,22,252,77,86,214,236,228,169,168,174,151,101,247,166,200,123,227,167,101,161,33,115,209,212,126,89,232,12,245,33,204,216,59,9,223,254,95,199,70,246,203,243,35,133,35,82,244,89,25,92,103,172,54,218,32,185,143,155,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSocialMessageEventSubProcessUpdateEventSubProcess() {
			ProcessSchemaEventSubProcess schemaSocialMessageEventSubProcessUpdate = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("4e83c29d-9c37-4df3-a7e2-2c8a7161fd52"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("360d0932-586a-41b0-8edb-7c58edda5a52"),
				CreatedInOwnerSchemaUId = new Guid("dd1b8305-7550-48b6-b8db-f82d66310892"),
				CreatedInPackageId = new Guid("8c729234-c444-46c1-a762-a0bd5f993895"),
				CreatedInSchemaUId = new Guid("d8b9d018-b420-4f2e-97fe-57bbd734d4ce"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("d8b9d018-b420-4f2e-97fe-57bbd734d4ce"),
				Name = @"SocialMessageEventSubProcessUpdate",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(27, 290),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(500, 170),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSocialMessageEventSubProcessUpdate;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateSocialMessageUpdatedChildMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("21ad5aad-f657-45ab-a37b-8954b8467253"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4e83c29d-9c37-4df3-a7e2-2c8a7161fd52"),
				CreatedInOwnerSchemaUId = new Guid("dd1b8305-7550-48b6-b8db-f82d66310892"),
				CreatedInPackageId = new Guid("8c729234-c444-46c1-a762-a0bd5f993895"),
				CreatedInSchemaUId = new Guid("d8b9d018-b420-4f2e-97fe-57bbd734d4ce"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"SocialMessageUpdated",
				ModifiedInSchemaUId = new Guid("d8b9d018-b420-4f2e-97fe-57bbd734d4ce"),
				Name = @"SocialMessageUpdatedChildMessage",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(52, 71),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateSocialMessageUpdatedChildToParentMessageIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("7e8b2139-362c-4e7e-9819-1d9946850819"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4e83c29d-9c37-4df3-a7e2-2c8a7161fd52"),
				CreatedInOwnerSchemaUId = new Guid("dd1b8305-7550-48b6-b8db-f82d66310892"),
				CreatedInPackageId = new Guid("8c729234-c444-46c1-a762-a0bd5f993895"),
				CreatedInSchemaUId = new Guid("d8b9d018-b420-4f2e-97fe-57bbd734d4ce"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"SocialMessageUpdated",
				ModifiedInSchemaUId = new Guid("d8b9d018-b420-4f2e-97fe-57bbd734d4ce"),
				Name = @"SocialMessageUpdatedChildToParentMessage",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(205, 71),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateUpdateNotifyListenersScriptTaksScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("fef7c93c-33b0-4b62-bb90-c20f27103d4f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("4e83c29d-9c37-4df3-a7e2-2c8a7161fd52"),
				CreatedInOwnerSchemaUId = new Guid("dd1b8305-7550-48b6-b8db-f82d66310892"),
				CreatedInPackageId = new Guid("8c729234-c444-46c1-a762-a0bd5f993895"),
				CreatedInSchemaUId = new Guid("d8b9d018-b420-4f2e-97fe-57bbd734d4ce"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("d8b9d018-b420-4f2e-97fe-57bbd734d4ce"),
				Name = @"UpdateNotifyListenersScriptTaks",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(338, 57),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,93,143,75,14,130,64,12,134,215,146,112,135,9,171,33,49,92,128,184,34,248,88,232,198,112,128,10,69,155,96,199,116,138,134,24,239,46,226,224,194,109,255,199,215,159,90,99,43,143,82,56,102,172,149,28,103,27,212,157,95,35,104,47,88,50,156,58,108,108,82,0,87,183,6,20,183,228,213,201,176,71,239,225,140,73,154,154,103,28,45,238,32,134,157,82,75,40,102,101,24,31,230,232,106,130,46,248,14,65,179,122,33,159,149,172,164,67,154,135,224,21,120,180,204,185,144,152,57,95,237,239,199,229,15,54,149,132,130,108,162,12,246,115,123,197,145,224,184,128,141,74,143,249,27,10,76,59,253,231,0,0,0 }
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
				CreatedInPackageId = new Guid("201fea27-b50a-40ad-a9a0-a08e92938ca6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("cde525cf-d220-4d2a-b963-e55254c639fc"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("201fea27-b50a-40ad-a9a0-a08e92938ca6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5c9c82c6-ba6d-4a57-9a14-87fe8faa4ebb"),
				Name = "Terrasoft.Core.DB",
				Alias = "",
				CreatedInPackageId = new Guid("201fea27-b50a-40ad-a9a0-a08e92938ca6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7821de68-c82b-4917-a6cd-add2adfbe400"),
				Name = "Terrasoft.Common",
				Alias = "",
				CreatedInPackageId = new Guid("201fea27-b50a-40ad-a9a0-a08e92938ca6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d67de76f-9cbc-4bfc-babb-6f65cb89b973"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("201fea27-b50a-40ad-a9a0-a08e92938ca6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("74160d3b-65e3-4694-b554-089f2d980e54"),
				Name = "Newtonsoft.Json",
				Alias = "",
				CreatedInPackageId = new Guid("201fea27-b50a-40ad-a9a0-a08e92938ca6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e401300a-9f16-40c2-9788-cf310ae9d1c5"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("201fea27-b50a-40ad-a9a0-a08e92938ca6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("fb9a2a2d-ea99-4726-bdea-d9500c7ff98e"),
				Name = "Terrasoft.Messaging.Common",
				Alias = "",
				CreatedInPackageId = new Guid("45651080-8a86-4041-b656-96c6d9b69016")
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
				UId = new Guid("216a3027-4a2a-4c34-8301-167ccd647bf0"),
				Name = "Terrasoft.Configuration.RightsService",
				Alias = "",
				CreatedInPackageId = new Guid("b66b5ae8-46e0-4931-ad78-c2c1ba5fd6ea")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("0f6d4c57-eb66-4a65-9ddb-3842d2bc8cfb"),
				Name = "System.Security",
				Alias = "",
				CreatedInPackageId = new Guid("b66b5ae8-46e0-4931-ad78-c2c1ba5fd6ea")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("47d7770f-b6e1-44b3-bf73-bc94d4eb7edb"),
				Name = "Terrasoft.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("b66b5ae8-46e0-4931-ad78-c2c1ba5fd6ea")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("269ca102-d8fc-45d6-a6cd-8a6462201b91"),
				Name = "System.Linq",
				Alias = "",
				CreatedInPackageId = new Guid("b66b5ae8-46e0-4931-ad78-c2c1ba5fd6ea")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5f9277d7-1bb2-45d3-824d-b50bc30b217b"),
				Name = "System.Collections.Generic",
				Alias = "",
				CreatedInPackageId = new Guid("b66b5ae8-46e0-4931-ad78-c2c1ba5fd6ea")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("41662933-bfb2-40e1-b444-afca760c7a83"),
				Name = "System.Text.RegularExpressions",
				Alias = "",
				CreatedInPackageId = new Guid("f8040510-1587-4652-9d4f-4809f5f9b2d7")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("aca2294b-e209-4c40-9400-0d59d9ecd1ea"),
				Name = "Terrasoft.GlobalSearch.Indexing",
				Alias = "",
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5410f06b-83f8-43fa-bc49-82a2dd508d3c"),
				Name = "System.Linq",
				Alias = "",
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			});
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SocialMessageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d8b9d018-b420-4f2e-97fe-57bbd734d4ce"));
		}

		#endregion

	}

	#endregion


	#region Class: SocialMessageEventsProcess

	/// <exclude/>
	public class SocialMessageEventsProcess : SocialMessage_SocialMessageEventsProcess
	{

		public SocialMessageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

