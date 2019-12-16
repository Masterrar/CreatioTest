namespace Terrasoft.Core.Process
{

	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Drawing;
	using System.Globalization;
	using System.Text;
	using Terrasoft.Common;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Factories;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;

	#region Class: SendPushNotificationProcessMethodsWrapper

	/// <exclude/>
	public class SendPushNotificationProcessMethodsWrapper : ProcessModel
	{

		public SendPushNotificationProcessMethodsWrapper(Process process)
			: base(process) {
			AddScriptTaskMethod("SendPushScriptTaskExecute", SendPushScriptTaskExecute);
		}

		#region Methods: Private

		private bool SendPushScriptTaskExecute(ProcessExecutingContext context) {
			var userConnection = this.Get<UserConnection>("UserConnection");
			var pushNotification = new PushNotification(userConnection);
			string title = Get<string>("Title");
			string message = Get<string>("Message");
			Guid sysAdminUnitId = Guid.Empty;
			try {
				sysAdminUnitId = Get<Guid>("SysAdminUnitId");
			} catch(Exception e) {
			}
			if (sysAdminUnitId == Guid.Empty) {
				return true;
			}
			Guid entityId = Guid.Empty;
			try {
				entityId = Get<Guid>("EntityId");
			} catch(Exception e) {
			}
			string entityName = string.Empty;
			if (entityId != Guid.Empty) {
				EntitySchema sysSchema = userConnection.EntitySchemaManager.GetInstanceByName("SysSchema");
				Entity sysSchemaEntity = sysSchema.CreateEntity(userConnection);
				if (sysSchemaEntity.FetchFromDB(sysSchema.PrimaryColumn.ColumnValueName, entityId,
						new List<string> { "Name" })) {
					entityName = sysSchemaEntity.GetTypedColumnValue<string>("Name");
				}
			}
			string recordIdStr = string.Empty;
			try {
				Guid recordId = Get<Guid>("RecordId");
				recordIdStr = recordId.ToString();
			} catch(Exception e) {
			}
			Dictionary<string, string> additionalData = new Dictionary<string, string>();
			additionalData.Add("entityName", entityName);
			additionalData.Add("recordId", recordIdStr);
			pushNotification.Send(sysAdminUnitId, title, message, additionalData);
			return true;
		}

		#endregion

	}

	#endregion

	#region Class: SendPushNotificationProcess

	/// <exclude/>
	public class SendPushNotificationProcess : Terrasoft.Core.Process.Process
	{

		#region Class: ProcessLane1

		/// <exclude/>
		public class ProcessLane1 : ProcessLane
		{

			public ProcessLane1(UserConnection userConnection, SendPushNotificationProcess process)
				: base(userConnection) {
				Owner = process;
				IsUsedParentUserContexts = false;
			}

		}

		#endregion

		public SendPushNotificationProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SendPushNotificationProcess";
			SchemaUId = new Guid("fe450ad3-5b58-49a8-8d3a-a2e4f9561133");
			Caption = Schema.Caption;
			SchemaManagerName = "ProcessSchemaManager";
			SerializeToDB = true;
			SerializeToMemory = true;
			IsLogging = true;
			_notificationCaption = () => { return new LocalizableString((Caption)); };
			_sysAdminUnitId = () => { return (Guid)(Guid.Empty); };
			_recordId = () => { return (Guid)(Guid.Empty); };
			_entityId = () => { return (Guid)(Guid.Empty); };
			ProcessModel = new SendPushNotificationProcessMethodsWrapper(this);
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("fe450ad3-5b58-49a8-8d3a-a2e4f9561133");
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

		public virtual string Message {
			get;
			set;
		}

		public virtual string Title {
			get;
			set;
		}

		private Func<Guid> _sysAdminUnitId;
		public virtual Guid SysAdminUnitId {
			get {
				return (_sysAdminUnitId ?? (_sysAdminUnitId = () => Guid.Empty)).Invoke();
			}
			set {
				_sysAdminUnitId = () => { return value; };
			}
		}

		private Func<Guid> _recordId;
		public virtual Guid RecordId {
			get {
				return (_recordId ?? (_recordId = () => Guid.Empty)).Invoke();
			}
			set {
				_recordId = () => { return value; };
			}
		}

		private Func<Guid> _entityId;
		public virtual Guid EntityId {
			get {
				return (_entityId ?? (_entityId = () => Guid.Empty)).Invoke();
			}
			set {
				_entityId = () => { return value; };
			}
		}

		private ProcessLane1 _lane1;
		public ProcessLane1 Lane1 {
			get {
				return _lane1 ?? ((_lane1) = new ProcessLane1(UserConnection, this));
			}
		}

		private ProcessFlowElement _startEvent1;
		public ProcessFlowElement StartEvent1 {
			get {
				return _startEvent1 ?? (_startEvent1 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartEvent",
					Name = "StartEvent1",
					SchemaElementUId = new Guid("7220e5f3-490a-4ad0-8a5b-54c3db3e5d93"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
				});
			}
		}

		private ProcessTerminateEvent _terminateEvent1;
		public ProcessTerminateEvent TerminateEvent1 {
			get {
				return _terminateEvent1 ?? (_terminateEvent1 = new ProcessTerminateEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaTerminateEvent",
					Name = "TerminateEvent1",
					SchemaElementUId = new Guid("6b3f194b-d91a-4e02-a4e7-5aee0fb6f045"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
				});
			}
		}

		private ProcessScriptTask _sendPushScriptTask;
		public ProcessScriptTask SendPushScriptTask {
			get {
				return _sendPushScriptTask ?? (_sendPushScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "SendPushScriptTask",
					SchemaElementUId = new Guid("e121f810-3b59-47b8-830a-54e2babe3992"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
					Script = ProcessModel.GetScriptTaskMethod("SendPushScriptTaskExecute"),
				});
			}
		}

		private ProcessScriptTask _initMessageParamTask;
		public ProcessScriptTask InitMessageParamTask {
			get {
				return _initMessageParamTask ?? (_initMessageParamTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaFormulaTask",
					Name = "InitMessageParamTask",
					SchemaElementUId = new Guid("5c324093-ffa9-4806-b437-132d68c6c4da"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
					Script = InitMessageParamTaskExecute,
				});
			}
		}

		private ProcessScriptTask _initTitleParamTask;
		public ProcessScriptTask InitTitleParamTask {
			get {
				return _initTitleParamTask ?? (_initTitleParamTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaFormulaTask",
					Name = "InitTitleParamTask",
					SchemaElementUId = new Guid("2d0ee355-589a-463b-a0d1-7937b724e85c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
					Script = InitTitleParamTaskExecute,
				});
			}
		}

		private ProcessScriptTask _initUserIdParamTask;
		public ProcessScriptTask InitUserIdParamTask {
			get {
				return _initUserIdParamTask ?? (_initUserIdParamTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaFormulaTask",
					Name = "InitUserIdParamTask",
					SchemaElementUId = new Guid("f8d4b32b-1729-4572-aff3-2ad51de3a8e0"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
					Script = InitUserIdParamTaskExecute,
				});
			}
		}

		private ProcessScriptTask _initEntityNameParamTask;
		public ProcessScriptTask InitEntityNameParamTask {
			get {
				return _initEntityNameParamTask ?? (_initEntityNameParamTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaFormulaTask",
					Name = "InitEntityNameParamTask",
					SchemaElementUId = new Guid("d9f37a04-6af0-4c26-90c4-a327cb1f4edb"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
					Script = InitEntityNameParamTaskExecute,
				});
			}
		}

		private ProcessScriptTask _initRecordIdParamTask;
		public ProcessScriptTask InitRecordIdParamTask {
			get {
				return _initRecordIdParamTask ?? (_initRecordIdParamTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaFormulaTask",
					Name = "InitRecordIdParamTask",
					SchemaElementUId = new Guid("70209d45-c697-4d02-8b22-caa501012c64"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
					Script = InitRecordIdParamTaskExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[StartEvent1.SchemaElementUId] = new Collection<ProcessFlowElement> { StartEvent1 };
			FlowElements[TerminateEvent1.SchemaElementUId] = new Collection<ProcessFlowElement> { TerminateEvent1 };
			FlowElements[SendPushScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { SendPushScriptTask };
			FlowElements[InitMessageParamTask.SchemaElementUId] = new Collection<ProcessFlowElement> { InitMessageParamTask };
			FlowElements[InitTitleParamTask.SchemaElementUId] = new Collection<ProcessFlowElement> { InitTitleParamTask };
			FlowElements[InitUserIdParamTask.SchemaElementUId] = new Collection<ProcessFlowElement> { InitUserIdParamTask };
			FlowElements[InitEntityNameParamTask.SchemaElementUId] = new Collection<ProcessFlowElement> { InitEntityNameParamTask };
			FlowElements[InitRecordIdParamTask.SchemaElementUId] = new Collection<ProcessFlowElement> { InitRecordIdParamTask };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "StartEvent1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("InitMessageParamTask", e.Context.SenderName));
						break;
					case "TerminateEvent1":
						CompleteProcess();
						break;
					case "SendPushScriptTask":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("TerminateEvent1", e.Context.SenderName));
						break;
					case "InitMessageParamTask":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("InitTitleParamTask", e.Context.SenderName));
						break;
					case "InitTitleParamTask":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("InitEntityNameParamTask", e.Context.SenderName));
						break;
					case "InitUserIdParamTask":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("SendPushScriptTask", e.Context.SenderName));
						break;
					case "InitEntityNameParamTask":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("InitRecordIdParamTask", e.Context.SenderName));
						break;
					case "InitRecordIdParamTask":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("InitUserIdParamTask", e.Context.SenderName));
						break;
			}
		}

		private void WritePropertyValues(DataWriter writer, bool useAllValueSources) {
			if (!HasMapping("Message")) {
				writer.WriteValue("Message", Message, null);
			}
			if (!HasMapping("Title")) {
				writer.WriteValue("Title", Title, null);
			}
			if (!HasMapping("SysAdminUnitId")) {
				writer.WriteValue("SysAdminUnitId", SysAdminUnitId, Guid.Empty);
			}
			if (!HasMapping("RecordId")) {
				writer.WriteValue("RecordId", RecordId, Guid.Empty);
			}
			if (!HasMapping("EntityId")) {
				writer.WriteValue("EntityId", EntityId, Guid.Empty);
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
			context.QueueTasksV2.Enqueue(new ProcessQueueElement("StartEvent1", string.Empty));
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
			MetaPathParameterValues.Add("5a94118e-f9f1-403e-879c-cf5cac300ead", () => Message);
			MetaPathParameterValues.Add("6954140d-03e2-4062-a5cd-6e10003cf1b6", () => Title);
			MetaPathParameterValues.Add("5b6c5010-defd-4616-afc9-0afea4dcc70f", () => SysAdminUnitId);
			MetaPathParameterValues.Add("546916b2-cb85-4cc4-abc0-d3b9dec42cc4", () => RecordId);
			MetaPathParameterValues.Add("1f35dc06-916d-41f0-874c-d450b70d654b", () => EntityId);
		}

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			bool hasValueToRead = reader.HasValue();
			switch (reader.CurrentName) {
				case "Message":
					if (!hasValueToRead) break;
					Message = reader.GetValue<System.String>();
				break;
				case "Title":
					if (!hasValueToRead) break;
					Title = reader.GetValue<System.String>();
				break;
				case "SysAdminUnitId":
					if (!hasValueToRead) break;
					SysAdminUnitId = reader.GetValue<System.Guid>();
				break;
				case "RecordId":
					if (!hasValueToRead) break;
					RecordId = reader.GetValue<System.Guid>();
				break;
				case "EntityId":
					if (!hasValueToRead) break;
					EntityId = reader.GetValue<System.Guid>();
				break;
			}
		}

		protected override void WritePropertyValues(DataWriter writer) {
			base.WritePropertyValues(writer);
			WritePropertyValues(writer, true);
		}

		#endregion

		#region Methods: Public

		public virtual bool InitMessageParamTaskExecute(ProcessExecutingContext context) {
			var localMessage = (Message);
			Message = (System.String)localMessage;
			return true;
		}

		public virtual bool InitTitleParamTaskExecute(ProcessExecutingContext context) {
			var localTitle = (Title);
			Title = (System.String)localTitle;
			return true;
		}

		public virtual bool InitUserIdParamTaskExecute(ProcessExecutingContext context) {
			var localSysAdminUnitId = (SysAdminUnitId);
			SysAdminUnitId = (System.Guid)localSysAdminUnitId;
			return true;
		}

		public virtual bool InitEntityNameParamTaskExecute(ProcessExecutingContext context) {
			var localEntityId = (EntityId);
			EntityId = (System.Guid)localEntityId;
			return true;
		}

		public virtual bool InitRecordIdParamTaskExecute(ProcessExecutingContext context) {
			var localRecordId = (RecordId);
			RecordId = (System.Guid)localRecordId;
			return true;
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
			var cloneItem = (SendPushNotificationProcess)base.CloneShallow();
			cloneItem.ExecutedEventHandler = ExecutedEventHandler;
			return cloneItem;
		}

		#endregion

	}

	#endregion

}

