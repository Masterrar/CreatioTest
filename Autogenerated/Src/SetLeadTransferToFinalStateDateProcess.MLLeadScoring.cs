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
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;

	#region Class: SetLeadTransferToFinalStateDateProcessMethodsWrapper

	/// <exclude/>
	public class SetLeadTransferToFinalStateDateProcessMethodsWrapper : ProcessModel
	{

		public SetLeadTransferToFinalStateDateProcessMethodsWrapper(Process process)
			: base(process) {
			AddScriptTaskMethod("ScriptTaskUpdateLeadDateExecute", ScriptTaskUpdateLeadDateExecute);
		}

		#region Methods: Private

		private bool ScriptTaskUpdateLeadDateExecute(ProcessExecutingContext context) {
			var userConnection = Get<UserConnection>("UserConnection");
			Guid entityId = Get<Guid>("LeadId");
			var update = new Update(userConnection, "Lead")
				.Set("MovedToFinalStateOn", Column.Parameter(DateTime.UtcNow))
				.Where("Id").IsEqual(Column.Parameter(entityId));
			update.Execute();
			return true;
		}

		#endregion

	}

	#endregion

	#region Class: SetLeadTransferToFinalStateDateProcess

	/// <exclude/>
	public class SetLeadTransferToFinalStateDateProcess : Terrasoft.Core.Process.Process
	{

		#region Class: ProcessLane1

		/// <exclude/>
		public class ProcessLane1 : ProcessLane
		{

			public ProcessLane1(UserConnection userConnection, SetLeadTransferToFinalStateDateProcess process)
				: base(userConnection) {
				Owner = process;
				IsUsedParentUserContexts = false;
			}

		}

		#endregion

		public SetLeadTransferToFinalStateDateProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SetLeadTransferToFinalStateDateProcess";
			SchemaUId = new Guid("fb666586-b2e2-45cb-b5b5-76e6a31ebe00");
			Caption = Schema.Caption;
			SchemaManagerName = "ProcessSchemaManager";
			SerializeToDB = true;
			SerializeToMemory = true;
			IsLogging = true;
			_notificationCaption = () => { return new LocalizableString((Caption)); };
			_leadId = () => { return (Guid)((StartLeadStateUpdatedSignal.RecordId)); };
			ProcessModel = new SetLeadTransferToFinalStateDateProcessMethodsWrapper(this);
			InitializeFlowElements();
		}

		#region Properties: Private

		private  Guid InternalSchemaUId {
			get {
				return new Guid("fb666586-b2e2-45cb-b5b5-76e6a31ebe00");
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

		private Func<Guid> _leadId;
		public  virtual Guid LeadId {
			get {
				return (_leadId ?? (_leadId = () => Guid.Empty)).Invoke();
			}
			set {
				_leadId = () => { return value; };
			}
		}

		private ProcessLane1 _lane1;
		public  ProcessLane1 Lane1 {
			get {
				return _lane1 ?? ((_lane1) = new ProcessLane1(UserConnection, this));
			}
		}

		private ProcessTerminateEvent _terminateEvent1;
		public  ProcessTerminateEvent TerminateEvent1 {
			get {
				return _terminateEvent1 ?? (_terminateEvent1 = new ProcessTerminateEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaTerminateEvent",
					Name = "TerminateEvent1",
					SchemaElementUId = new Guid("7263e13c-1961-473a-83b2-06f8f352feb7"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
				});
			}
		}

		private ProcessStartSignalEvent _startLeadStateUpdatedSignal;
		public  ProcessStartSignalEvent StartLeadStateUpdatedSignal {
			get {
				return _startLeadStateUpdatedSignal ?? (_startLeadStateUpdatedSignal = new ProcessStartSignalEvent(UserConnection) {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartSignalEvent",
					Name = "StartLeadStateUpdatedSignal",
					SerializeToDB = false,
					IsLogging = true,
					SchemaElementUId = new Guid("9b8ba023-a688-4689-b539-7197c2f9cfa4"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTaskUpdateLeadDate;
		public  ProcessScriptTask ScriptTaskUpdateLeadDate {
			get {
				return _scriptTaskUpdateLeadDate ?? (_scriptTaskUpdateLeadDate = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTaskUpdateLeadDate",
					SchemaElementUId = new Guid("685d1f9a-2417-4f53-9f73-b3511d0c3371"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
					Script = ProcessModel.GetScriptTaskMethod("ScriptTaskUpdateLeadDateExecute"),
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[TerminateEvent1.SchemaElementUId] = new Collection<ProcessFlowElement> { TerminateEvent1 };
			FlowElements[StartLeadStateUpdatedSignal.SchemaElementUId] = new Collection<ProcessFlowElement> { StartLeadStateUpdatedSignal };
			FlowElements[ScriptTaskUpdateLeadDate.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTaskUpdateLeadDate };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "TerminateEvent1":
						CompleteProcess();
						break;
					case "StartLeadStateUpdatedSignal":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ScriptTaskUpdateLeadDate", e.Context.SenderName));
						break;
					case "ScriptTaskUpdateLeadDate":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("TerminateEvent1", e.Context.SenderName));
						break;
			}
		}

		private void WritePropertyValues(DataWriter writer, bool useAllValueSources) {
			if (!HasMapping("LeadId")) {
				writer.WriteValue("LeadId", LeadId, Guid.Empty);
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
			MetaPathParameterValues.Add("9244bfeb-8f12-417b-8180-218d1e51b8f8", () => LeadId);
			MetaPathParameterValues.Add("10ad8c88-1c0c-4683-ac5a-096d3957a4eb", () => StartLeadStateUpdatedSignal.RecordId);
		}

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			bool hasValueToRead = reader.HasValue();
			switch (reader.CurrentName) {
				case "LeadId":
					if (!hasValueToRead) break;
					LeadId = reader.GetValue<System.Guid>();
				break;
			}
		}

		protected override void WritePropertyValues(DataWriter writer) {
			base.WritePropertyValues(writer);
			WritePropertyValues(writer, true);
		}

		#endregion

		#region Methods: Public

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
			var cloneItem = (SetLeadTransferToFinalStateDateProcess)base.CloneShallow();
			cloneItem.ExecutedEventHandler = ExecutedEventHandler;
			return cloneItem;
		}

		#endregion

	}

	#endregion

}

