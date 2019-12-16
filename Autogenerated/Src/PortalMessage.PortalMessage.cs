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

	#region Class: PortalMessageSchema

	/// <exclude/>
	public class PortalMessageSchema : Terrasoft.Configuration.PortalMessage_PortalMessageFeed_TerrasoftSchema
	{

		#region Constructors: Public

		public PortalMessageSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public PortalMessageSchema(PortalMessageSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public PortalMessageSchema(PortalMessageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("cdbe490f-b290-4c2f-8cfc-cd24be0bdb29");
			Name = "PortalMessage";
			ParentSchemaUId = new Guid("36fb7666-f45c-48f7-be50-178c7adbe3c0");
			ExtendParent = true;
			CreatedInPackageId = new Guid("3d13b118-f5cc-492f-950e-fcd19f4bb9cc");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("47703666-69f2-47ed-8746-5c85c6a6bb9a")) == null) {
				Columns.Add(CreateTypeColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateTypeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("47703666-69f2-47ed-8746-5c85c6a6bb9a"),
				Name = @"Type",
				ReferenceSchemaUId = new Guid("ceb61101-7562-4107-bf84-9dfb310c1c1c"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("cdbe490f-b290-4c2f-8cfc-cd24be0bdb29"),
				ModifiedInSchemaUId = new Guid("cdbe490f-b290-4c2f-8cfc-cd24be0bdb29"),
				CreatedInPackageId = new Guid("761cfd91-bc98-408a-bd46-c0d06c3eba85"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"d00c02b1-f740-409d-9f04-d921f2aaae3e"
				}
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreatePortalMessageEventsProcessSchema();
		}

		protected virtual ProcessSchema CreatePortalMessageEventsProcessSchema() {
			var schema = new PortalMessageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new PortalMessage(userConnection){Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new PortalMessage_PortalMessageEventsProcess(userConnnection);
		}

		public override object Clone() {
			return new PortalMessageSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new PortalMessageSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("cdbe490f-b290-4c2f-8cfc-cd24be0bdb29"));
		}

		#endregion

	}

	#endregion

	#region Class: PortalMessage

	/// <summary>
	/// Portal message.
	/// </summary>
	public class PortalMessage : Terrasoft.Configuration.PortalMessage_PortalMessageFeed_Terrasoft
	{

		#region Constructors: Public

		public PortalMessage(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "PortalMessage";
		}

		public PortalMessage(PortalMessage source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid TypeId {
			get {
				return GetTypedColumnValue<Guid>("TypeId");
			}
			set {
				SetColumnValue("TypeId", value);
				_type = null;
			}
		}

		/// <exclude/>
		public string TypeName {
			get {
				return GetTypedColumnValue<string>("TypeName");
			}
			set {
				SetColumnValue("TypeName", value);
				if (_type != null) {
					_type.Name = value;
				}
			}
		}

		private PortalMessageType _type;
		/// <summary>
		/// Type.
		/// </summary>
		public PortalMessageType Type {
			get {
				return _type ??
					(_type = LookupColumnEntities.GetEntity("Type") as PortalMessageType);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new PortalMessage_PortalMessageEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("PortalMessageDeleted", e);
			Saving += (s, e) => ThrowEvent("PortalMessageSaving", e);
			Updating += (s, e) => ThrowEvent("PortalMessageUpdating", e);
			Validating += (s, e) => ThrowEvent("PortalMessageValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new PortalMessage(this);
		}

		#endregion

	}

	#endregion

	#region Class: PortalMessage_PortalMessageEventsProcess

	/// <exclude/>
	public class PortalMessage_PortalMessageEventsProcess<TEntity> : Terrasoft.Configuration.PortalMessage_PortalMessageFeedEventsProcess<TEntity> where TEntity : PortalMessage
	{

		public PortalMessage_PortalMessageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "PortalMessage_PortalMessageEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("cdbe490f-b290-4c2f-8cfc-cd24be0bdb29");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		private ProcessFlowElement _eventSubProcess1xcvcfgdrtgwe;
		public ProcessFlowElement EventSubProcess1xcvcfgdrtgwe {
			get {
				return _eventSubProcess1xcvcfgdrtgwe ?? (_eventSubProcess1xcvcfgdrtgwe = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess1xcvcfgdrtgwe",
					SchemaElementUId = new Guid("9914235a-db8a-4c38-931c-0d176ca9f65d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _portalMessageSavingChildMessage;
		public ProcessFlowElement PortalMessageSavingChildMessage {
			get {
				return _portalMessageSavingChildMessage ?? (_portalMessageSavingChildMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "PortalMessageSavingChildMessage",
					SchemaElementUId = new Guid("a8ae8528-f416-48be-aa9c-3efc8e696eb7"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _portalMessageUpdatingMessage;
		public ProcessFlowElement PortalMessageUpdatingMessage {
			get {
				return _portalMessageUpdatingMessage ?? (_portalMessageUpdatingMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "PortalMessageUpdatingMessage",
					SchemaElementUId = new Guid("0dc311df-6d12-4500-bc70-463c637d1cca"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _checkPermissionsBeforeUpdating;
		public ProcessScriptTask CheckPermissionsBeforeUpdating {
			get {
				return _checkPermissionsBeforeUpdating ?? (_checkPermissionsBeforeUpdating = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "CheckPermissionsBeforeUpdating",
					SchemaElementUId = new Guid("b9cecc8f-9c63-4211-bd89-f4e2017ac9a0"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = CheckPermissionsBeforeUpdatingExecute,
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
					SchemaElementUId = new Guid("03f56908-f4ed-4b71-a399-9f711ffd5f1a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = NotifyListenersScriptTaskExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess1xcvcfgdrtgwe.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess1xcvcfgdrtgwe };
			FlowElements[PortalMessageSavingChildMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { PortalMessageSavingChildMessage };
			FlowElements[PortalMessageUpdatingMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { PortalMessageUpdatingMessage };
			FlowElements[CheckPermissionsBeforeUpdating.SchemaElementUId] = new Collection<ProcessFlowElement> { CheckPermissionsBeforeUpdating };
			FlowElements[NotifyListenersScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { NotifyListenersScriptTask };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess1xcvcfgdrtgwe":
						break;
					case "PortalMessageSavingChildMessage":
						e.Context.QueueTasks.Enqueue("NotifyListenersScriptTask");
						break;
					case "PortalMessageUpdatingMessage":
						e.Context.QueueTasks.Enqueue("CheckPermissionsBeforeUpdating");
						break;
					case "CheckPermissionsBeforeUpdating":
						break;
					case "NotifyListenersScriptTask":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("PortalMessageSavingChildMessage");
			ActivatedEventElements.Add("PortalMessageUpdatingMessage");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "EventSubProcess1xcvcfgdrtgwe":
					context.QueueTasks.Dequeue();
					break;
				case "PortalMessageSavingChildMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "PortalMessageSavingChildMessage";
					result = PortalMessageSavingChildMessage.Execute(context);
					break;
				case "PortalMessageUpdatingMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "PortalMessageUpdatingMessage";
					result = PortalMessageUpdatingMessage.Execute(context);
					break;
				case "CheckPermissionsBeforeUpdating":
					context.QueueTasks.Dequeue();
					context.SenderName = "CheckPermissionsBeforeUpdating";
					result = CheckPermissionsBeforeUpdating.Execute(context, CheckPermissionsBeforeUpdatingExecute);
					break;
				case "NotifyListenersScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "NotifyListenersScriptTask";
					result = NotifyListenersScriptTask.Execute(context, NotifyListenersScriptTaskExecute);
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

		public virtual bool CheckPermissionsBeforeUpdatingExecute(ProcessExecutingContext context) {
			if (UserConnection.CurrentUser.ConnectionType != UserType.SSP) {
				return true;
			}
			var createdById = Entity.GetTypedColumnValue<System.Guid>("CreatedById");
			if (UserConnection.CurrentUser.ContactId != createdById || Entity.GetTypedOldColumnValue<int>("IsNotPublished") == 0) {
				return false;
			}
			return true;
		}

		public virtual bool NotifyListenersScriptTaskExecute(ProcessExecutingContext context) {
			if(Entity.StoringState != StoringObjectState.New){
				CopyFiles();
			}
			return true;
		}

		public virtual void CopyFiles() {
			var recordId = Entity.GetTypedColumnValue<Guid>("EntityId");
			var entityUId = Entity.GetTypedColumnValue<Guid>("EntitySchemaUId");
			var schemaName = UserConnection.EntitySchemaManager.GetInstanceByUId(entityUId).Name;
			
			if(Entity.GetTypedColumnValue<bool>("IsNotPublished") && recordId.IsNotEmpty()) {
				Entity.SetColumnValue("IsNotPublished", false);
				var ignoreSchemaListForCopingFiles = GetIgnoreForCopyFilesSchemaList();
				if (ignoreSchemaListForCopingFiles.Contains(schemaName)) {
					return;
				}
				var schemasWithSpecifiedClassForCopying = GetSchemasWithSpecifiedClassForCopying();
				if (schemasWithSpecifiedClassForCopying.Contains(schemaName)) {
					var copyingUtility = GetInstanceOfSpecifiedClassForCopying(schemaName);
					if(copyingUtility != null) {
						copyingUtility.CopyAll("PortalMessage", Entity.PrimaryColumnValue, recordId);
						return;
					}
				}
				Terrasoft.Configuration.CommonUtilities
					.CopyFileDetail(UserConnection, Entity.PrimaryColumnValue, recordId, "PortalMessage", schemaName, false);
			}
		}

		public virtual void NotifyListeners() {
			if(this.Entity.GetTypedColumnValue<bool>("IsNotPublished")){
				return;
			}
			var notifier = new PortalMessageNotifier(this.Entity);
			var manager = new MessageHistoryManager(UserConnection, notifier);
			manager.Notify();
		}

		public virtual List<string> GetIgnoreForCopyFilesSchemaList() {
			return new List<string> { "Lead" };
		}

		public virtual List<string> GetSchemasWithSpecifiedClassForCopying() {
			return new List<string> { "Case" };
		}

		public virtual IEntityFileCopier GetInstanceOfSpecifiedClassForCopying(string schemaName) {
			var userConnectionArgument = new ConstructorArgument("schemaName", UserConnection);
			return	ClassFactory.Get<IEntityFileCopier>(schemaName, userConnectionArgument);
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "PortalMessageSaving":
							if (ActivatedEventElements.Contains("PortalMessageSavingChildMessage")) {
							context.QueueTasks.Enqueue("PortalMessageSavingChildMessage");
						}
						break;
					case "PortalMessageUpdating":
							if (ActivatedEventElements.Contains("PortalMessageUpdatingMessage")) {
							context.QueueTasks.Enqueue("PortalMessageUpdatingMessage");
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

	#region Class: PortalMessage_PortalMessageEventsProcess

	/// <exclude/>
	public class PortalMessage_PortalMessageEventsProcess : PortalMessage_PortalMessageEventsProcess<PortalMessage>
	{

		public PortalMessage_PortalMessageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: PortalMessageEventsProcessSchema

	/// <exclude/>
	public class PortalMessageEventsProcessSchema : Terrasoft.Configuration.PortalMessage_PortalMessageFeed_TerrasoftEventsProcessSchema
	{

		#region Constructors: Public

		public PortalMessageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public PortalMessageEventsProcessSchema(PortalMessageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "PortalMessage_PortalMessageEventsProcess";
			UId = new Guid("c3615aa2-294a-4b98-99f0-89288fd8cd31");
			CreatedInPackageId = new Guid("3d13b118-f5cc-492f-950e-fcd19f4bb9cc");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("3b8a966a-9abc-4aaf-99bf-46c9595d9b66");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
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
			ProcessSchemaEventSubProcess eventsubprocess1xcvcfgdrtgwe = CreateEventSubProcess1xcvcfgdrtgweEventSubProcess();
			FlowElements.Add(eventsubprocess1xcvcfgdrtgwe);
			ProcessSchemaStartMessageEvent portalmessagesavingchildmessage = CreatePortalMessageSavingChildMessageStartMessageEvent();
			eventsubprocess1xcvcfgdrtgwe.FlowElements.Add(portalmessagesavingchildmessage);
			ProcessSchemaStartMessageEvent portalmessageupdatingmessage = CreatePortalMessageUpdatingMessageStartMessageEvent();
			eventsubprocess1xcvcfgdrtgwe.FlowElements.Add(portalmessageupdatingmessage);
			ProcessSchemaScriptTask checkpermissionsbeforeupdating = CreateCheckPermissionsBeforeUpdatingScriptTask();
			eventsubprocess1xcvcfgdrtgwe.FlowElements.Add(checkpermissionsbeforeupdating);
			ProcessSchemaScriptTask notifylistenersscripttask = CreateNotifyListenersScriptTaskScriptTask();
			eventsubprocess1xcvcfgdrtgwe.FlowElements.Add(notifylistenersscripttask);
			FlowElements.Add(CreateSequenceFlow1bvghyttSequenceFlow());
			FlowElements.Add(CreateSequenceFlow3_51876357cbba4e98a85133a1123d4524SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1bvghyttSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1bvghytt",
				UId = new Guid("dcd86622-e22d-4a26-bcd5-08b36cbcfd69"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("3b8a966a-9abc-4aaf-99bf-46c9595d9b66"),
				CreatedInPackageId = new Guid("3d13b118-f5cc-492f-950e-fcd19f4bb9cc"),
				CreatedInSchemaUId = new Guid("c3615aa2-294a-4b98-99f0-89288fd8cd31"),
				CurveCenterPosition = new Point(218, 132),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("c3615aa2-294a-4b98-99f0-89288fd8cd31"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("a8ae8528-f416-48be-aa9c-3efc8e696eb7"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("03f56908-f4ed-4b71-a399-9f711ffd5f1a"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3_51876357cbba4e98a85133a1123d4524SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3_51876357cbba4e98a85133a1123d4524",
				UId = new Guid("51876357-cbba-4e98-a851-33a1123d4524"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("3b8a966a-9abc-4aaf-99bf-46c9595d9b66"),
				CreatedInPackageId = new Guid("761cfd91-bc98-408a-bd46-c0d06c3eba85"),
				CreatedInSchemaUId = new Guid("c3615aa2-294a-4b98-99f0-89288fd8cd31"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("c3615aa2-294a-4b98-99f0-89288fd8cd31"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("0dc311df-6d12-4500-bc70-463c637d1cca"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("b9cecc8f-9c63-4211-bd89-f4e2017ac9a0"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("60cf4211-455e-4ae7-adeb-6a0ecd63a6ca"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("3b8a966a-9abc-4aaf-99bf-46c9595d9b66"),
				CreatedInPackageId = new Guid("3d13b118-f5cc-492f-950e-fcd19f4bb9cc"),
				CreatedInSchemaUId = new Guid("c3615aa2-294a-4b98-99f0-89288fd8cd31"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("c3615aa2-294a-4b98-99f0-89288fd8cd31"),
				Name = @"LaneSet1",
				Position = new Point(5, 5),
				Size = new Size(1085, 400),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("64a2a454-fe8b-44cb-bce1-829294b661d8"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("60cf4211-455e-4ae7-adeb-6a0ecd63a6ca"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("3d13b118-f5cc-492f-950e-fcd19f4bb9cc"),
				CreatedInSchemaUId = new Guid("c3615aa2-294a-4b98-99f0-89288fd8cd31"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("c3615aa2-294a-4b98-99f0-89288fd8cd31"),
				Name = @"Lane1",
				Position = new Point(29, 0),
				Size = new Size(1056, 400),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess1xcvcfgdrtgweEventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess1xcvcfgdrtgwe = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("9914235a-db8a-4c38-931c-0d176ca9f65d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("64a2a454-fe8b-44cb-bce1-829294b661d8"),
				CreatedInOwnerSchemaUId = new Guid("3b8a966a-9abc-4aaf-99bf-46c9595d9b66"),
				CreatedInPackageId = new Guid("3d13b118-f5cc-492f-950e-fcd19f4bb9cc"),
				CreatedInSchemaUId = new Guid("c3615aa2-294a-4b98-99f0-89288fd8cd31"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("c3615aa2-294a-4b98-99f0-89288fd8cd31"),
				Name = @"EventSubProcess1xcvcfgdrtgwe",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(80, 40),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(497, 420),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess1xcvcfgdrtgwe;
		}

		protected virtual ProcessSchemaStartMessageEvent CreatePortalMessageSavingChildMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("a8ae8528-f416-48be-aa9c-3efc8e696eb7"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("9914235a-db8a-4c38-931c-0d176ca9f65d"),
				CreatedInOwnerSchemaUId = new Guid("3b8a966a-9abc-4aaf-99bf-46c9595d9b66"),
				CreatedInPackageId = new Guid("3d13b118-f5cc-492f-950e-fcd19f4bb9cc"),
				CreatedInSchemaUId = new Guid("c3615aa2-294a-4b98-99f0-89288fd8cd31"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"PortalMessageSaving",
				ModifiedInSchemaUId = new Guid("c3615aa2-294a-4b98-99f0-89288fd8cd31"),
				Name = @"PortalMessageSavingChildMessage",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(71, 107),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaStartMessageEvent CreatePortalMessageUpdatingMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("0dc311df-6d12-4500-bc70-463c637d1cca"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("9914235a-db8a-4c38-931c-0d176ca9f65d"),
				CreatedInOwnerSchemaUId = new Guid("3b8a966a-9abc-4aaf-99bf-46c9595d9b66"),
				CreatedInPackageId = new Guid("761cfd91-bc98-408a-bd46-c0d06c3eba85"),
				CreatedInSchemaUId = new Guid("c3615aa2-294a-4b98-99f0-89288fd8cd31"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"PortalMessageUpdating",
				ModifiedInSchemaUId = new Guid("c3615aa2-294a-4b98-99f0-89288fd8cd31"),
				Name = @"PortalMessageUpdatingMessage",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(73, 268),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateCheckPermissionsBeforeUpdatingScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("b9cecc8f-9c63-4211-bd89-f4e2017ac9a0"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("9914235a-db8a-4c38-931c-0d176ca9f65d"),
				CreatedInOwnerSchemaUId = new Guid("3b8a966a-9abc-4aaf-99bf-46c9595d9b66"),
				CreatedInPackageId = new Guid("761cfd91-bc98-408a-bd46-c0d06c3eba85"),
				CreatedInSchemaUId = new Guid("c3615aa2-294a-4b98-99f0-89288fd8cd31"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("c3615aa2-294a-4b98-99f0-89288fd8cd31"),
				Name = @"CheckPermissionsBeforeUpdating",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(271, 254),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,143,65,11,130,64,16,133,207,9,254,135,201,83,94,150,238,101,135,150,16,47,37,88,221,55,29,105,97,93,99,119,54,144,236,191,183,66,160,118,233,54,124,240,230,123,79,214,176,186,88,52,188,213,26,75,146,173,102,220,25,131,154,6,202,70,124,238,30,8,203,4,6,60,220,172,40,242,24,94,97,176,48,72,206,104,32,227,112,19,6,239,48,120,10,3,165,65,65,88,237,187,172,130,4,14,154,36,117,44,69,26,162,21,111,149,107,244,85,40,135,219,162,179,132,13,75,157,172,118,171,136,143,177,40,246,223,228,223,122,36,74,242,14,223,108,170,236,251,95,231,73,205,180,82,147,215,101,246,216,82,238,110,74,218,59,122,35,36,9,172,103,171,106,161,236,119,214,116,231,7,150,241,62,52,55,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaScriptTask CreateNotifyListenersScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("03f56908-f4ed-4b71-a399-9f711ffd5f1a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("9914235a-db8a-4c38-931c-0d176ca9f65d"),
				CreatedInOwnerSchemaUId = new Guid("3b8a966a-9abc-4aaf-99bf-46c9595d9b66"),
				CreatedInPackageId = new Guid("3d13b118-f5cc-492f-950e-fcd19f4bb9cc"),
				CreatedInSchemaUId = new Guid("c3615aa2-294a-4b98-99f0-89288fd8cd31"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("c3615aa2-294a-4b98-99f0-89288fd8cd31"),
				Name = @"NotifyListenersScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(316, 93),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,203,76,211,112,205,43,201,44,169,212,11,46,201,47,202,204,75,15,46,73,44,73,85,80,180,85,128,242,253,147,178,82,147,75,192,162,122,126,169,229,154,213,188,92,156,206,249,5,149,110,153,57,169,197,26,154,214,188,92,181,188,92,69,169,37,165,69,121,10,37,69,165,169,214,0,138,232,51,43,82,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateCopyFilesMethod());
			Methods.Add(CreateNotifyListenersMethod());
			Methods.Add(CreateGetIgnoreForCopyFilesSchemaListMethod());
			Methods.Add(CreateGetSchemasWithSpecifiedClassForCopyingMethod());
			Methods.Add(CreateGetInstanceOfSpecifiedClassForCopyingMethod());
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
			Usings.Add(new SchemaUsing() {
				UId = new Guid("65485a75-f72c-48f9-8eba-cd69d630ffeb"),
				Name = "System.Collections.Generic",
				Alias = "",
				CreatedInPackageId = new Guid("e6f8ef6e-ec66-4714-a4d3-aef4942672f1")
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

		protected virtual SchemaMethod CreateCopyFilesMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("af53c265-3200-455d-bd2e-5ff9bb671637"),
				Name = "CopyFiles",
				CreatedInSchemaUId = new Guid("c3615aa2-294a-4b98-99f0-89288fd8cd31"),
				CreatedInPackageId = new Guid("11001124-3705-4725-a268-34190b97fa11"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,146,209,106,194,48,20,134,175,237,83,100,94,72,4,233,11,56,7,155,83,17,166,19,156,219,117,108,79,245,64,154,72,146,10,101,248,238,59,105,58,171,147,57,7,189,105,242,231,63,223,249,207,217,11,195,12,36,218,164,211,148,13,216,72,57,116,101,60,1,247,86,238,32,29,106,89,228,234,93,200,2,238,39,5,166,15,188,29,20,211,180,221,237,71,123,122,12,213,255,234,95,175,151,201,22,114,177,106,76,108,117,48,23,57,144,203,202,130,25,106,165,32,113,168,85,124,250,100,38,148,216,128,241,21,166,202,58,161,18,120,242,181,249,145,162,27,123,151,126,20,97,198,175,224,172,181,150,132,51,181,115,237,22,197,90,162,221,2,209,176,78,231,152,70,92,93,142,242,157,43,121,183,203,62,163,86,237,183,4,119,98,117,97,210,99,153,144,22,168,179,150,111,13,55,74,27,8,248,47,104,221,88,83,115,59,84,155,49,74,176,212,174,239,165,210,132,155,178,58,111,244,220,27,97,198,248,117,163,152,18,115,2,149,229,77,150,129,186,101,192,21,70,145,203,33,16,5,129,253,64,183,93,238,32,193,12,41,27,41,172,173,1,200,50,96,45,255,22,30,233,110,48,189,130,232,177,146,160,90,57,148,148,114,29,76,61,228,215,236,87,128,19,47,66,33,22,254,195,232,110,192,84,33,101,40,212,58,191,140,189,203,163,148,188,189,208,198,9,57,3,107,105,193,104,134,245,172,23,6,115,97,202,147,121,247,142,11,82,213,107,210,245,241,210,247,6,198,8,171,51,231,219,205,112,83,24,81,173,241,80,231,185,86,161,46,130,37,125,252,61,237,103,160,88,36,63,223,251,155,16,122,236,2,188,201,163,89,196,67,244,5,166,145,19,146,231,3,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateNotifyListenersMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("ca5bc9d6-a5d6-47ac-b1ad-f36da5c5e27f"),
				Name = "NotifyListeners",
				CreatedInSchemaUId = new Guid("c3615aa2-294a-4b98-99f0-89288fd8cd31"),
				CreatedInPackageId = new Guid("11001124-3705-4725-a268-34190b97fa11"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,77,141,203,14,130,48,16,69,215,146,240,15,13,171,146,24,126,0,117,67,140,186,128,176,80,247,69,6,105,82,102,76,59,213,52,198,127,247,1,26,215,231,158,123,116,39,185,215,46,91,35,107,14,217,6,120,31,46,208,22,100,252,128,71,101,60,44,26,34,179,146,201,206,85,196,181,111,140,118,61,180,73,154,222,227,104,102,129,189,197,60,142,30,113,116,85,86,32,177,238,52,88,177,20,8,55,81,147,101,101,74,112,78,157,161,154,216,127,48,205,71,111,80,248,90,124,181,73,216,106,199,100,67,57,50,121,112,96,11,66,132,19,107,194,249,175,245,254,152,252,236,211,8,50,205,159,9,19,173,140,216,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetIgnoreForCopyFilesSchemaListMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("4898a6a7-c115-4f5f-a0c8-92816f77b2f4"),
				Name = "GetIgnoreForCopyFilesSchemaList",
				CreatedInSchemaUId = new Guid("c3615aa2-294a-4b98-99f0-89288fd8cd31"),
				CreatedInPackageId = new Guid("e6f8ef6e-ec66-4714-a4d3-aef4942672f1"),
				ResultValueTypeName = "List<string>"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,200,75,45,87,240,201,44,46,177,41,46,41,202,204,75,183,83,168,86,80,242,73,77,76,81,82,168,181,6,0,57,194,184,212,35,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetSchemasWithSpecifiedClassForCopyingMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("a4038890-5bbb-4119-be8b-d6fc73a233bf"),
				Name = "GetSchemasWithSpecifiedClassForCopying",
				CreatedInSchemaUId = new Guid("c3615aa2-294a-4b98-99f0-89288fd8cd31"),
				CreatedInPackageId = new Guid("c85d2d65-6230-4aeb-9934-bfac9785d42f"),
				ResultValueTypeName = "List<string>"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,200,75,45,87,240,201,44,46,177,41,46,41,202,204,75,183,83,168,86,80,114,78,44,78,85,82,168,181,6,0,166,126,169,138,35,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetInstanceOfSpecifiedClassForCopyingMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("4c379db7-3eb1-46a1-a1be-5cc18edf6e38"),
				Name = "GetInstanceOfSpecifiedClassForCopying",
				CreatedInSchemaUId = new Guid("c3615aa2-294a-4b98-99f0-89288fd8cd31"),
				CreatedInPackageId = new Guid("c85d2d65-6230-4aeb-9934-bfac9785d42f"),
				ResultValueTypeName = "IEntityFileCopier"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("9614b481-9d1c-4dfc-a768-4b15efa29b49"),
				Name = "schemaName",
				CreatedInSchemaUId = new Guid("c3615aa2-294a-4b98-99f0-89288fd8cd31"),
				ModifiedInSchemaUId = new Guid("c3615aa2-294a-4b98-99f0-89288fd8cd31"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("c85d2d65-6230-4aeb-9934-bfac9785d42f")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,75,44,82,40,45,78,45,114,206,207,203,75,77,46,201,204,207,115,44,74,47,205,77,205,43,81,176,85,200,75,45,87,0,74,20,151,20,149,38,151,228,23,193,100,52,148,138,147,51,82,115,19,253,18,115,83,149,116,20,66,81,180,107,90,243,114,21,165,150,148,22,229,113,58,231,36,22,23,187,37,130,180,86,234,185,167,150,216,120,186,230,149,100,150,84,186,101,230,164,58,231,23,100,166,22,217,105,32,76,210,193,225,14,77,107,0,12,59,246,112,164,0,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new PortalMessageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c3615aa2-294a-4b98-99f0-89288fd8cd31"));
		}

		#endregion

	}

	#endregion


	#region Class: PortalMessageEventsProcess

	/// <exclude/>
	public class PortalMessageEventsProcess : PortalMessage_PortalMessageEventsProcess
	{

		public PortalMessageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

