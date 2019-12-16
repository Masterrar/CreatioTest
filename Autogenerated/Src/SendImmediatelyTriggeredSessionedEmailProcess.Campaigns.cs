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
	using System.Web;
	using Terrasoft.Common;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Factories;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;

	#region Class: SendImmediatelyTriggeredSessionedEmailProcessMethodsWrapper

	/// <exclude/>
	public class SendImmediatelyTriggeredSessionedEmailProcessMethodsWrapper : ProcessModel
	{

		public SendImmediatelyTriggeredSessionedEmailProcessMethodsWrapper(Process process)
			: base(process) {
			AddScriptTaskMethod("ScriptTask1Execute", ScriptTask1Execute);
		}

		#region Methods: Private

		private bool ScriptTask1Execute(ProcessExecutingContext context) {
			SendMailing();
			return true;
		}

			public virtual void SendMailing() {
			
				var userConnection = this.Get<UserConnection>("UserConnection");
				var bulkEmailId = this.Get<Guid>("BulkEmailId");
				var applicationUrl = this.Get<string>("ApplicationUrl");
				var sessionId = this.Get<Guid>("SessionUId");
				
				try {
					var mailingService = ClassFactory.Get<MailingService>(new ConstructorArgument("userConnection", userConnection));
					var isDelayedStart = true;
					mailingService.SendSessionedMessage(bulkEmailId, sessionId, isDelayedStart, applicationUrl);
				} catch (Exception e) {
					MailingUtilities.Log.ErrorFormat(
						"[SendImmediatelyTriggeredSessionedEmailProcess]: "
						+ "Failed to trigger. Params bulkEmailId: {0} sessionId: {1} applicationUrl: {2}.",
							e, bulkEmailId, sessionId, applicationUrl);
					throw e;
				}
					
			}

		#endregion

	}

	#endregion

	#region Class: SendImmediatelyTriggeredSessionedEmailProcess

	/// <exclude/>
	public class SendImmediatelyTriggeredSessionedEmailProcess : Terrasoft.Core.Process.Process
	{

		#region Class: ProcessLane1

		/// <exclude/>
		public class ProcessLane1 : ProcessLane
		{

			public ProcessLane1(UserConnection userConnection, SendImmediatelyTriggeredSessionedEmailProcess process)
				: base(userConnection) {
				Owner = process;
				IsUsedParentUserContexts = false;
			}

		}

		#endregion

		public SendImmediatelyTriggeredSessionedEmailProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SendImmediatelyTriggeredSessionedEmailProcess";
			SchemaUId = new Guid("8aebf4e7-ccbb-459e-ab11-50474833fc30");
			Caption = Schema.Caption;
			SchemaManagerName = "ProcessSchemaManager";
			SerializeToDB = false;
			SerializeToMemory = true;
			IsLogging = false;
			_bulkEmailId = () => { return (Guid)(Guid.Empty); };
			_applicationUrl = () => { return new LocalizableString(string.Empty); };
			_sessionUId = () => { return (Guid)(Guid.Empty); };
			ProcessModel = new SendImmediatelyTriggeredSessionedEmailProcessMethodsWrapper(this);
			InitializeFlowElements();
		}

		#region Properties: Private

		private  Guid InternalSchemaUId {
			get {
				return new Guid("8aebf4e7-ccbb-459e-ab11-50474833fc30");
			}
		}

		#endregion

		#region Properties: Public

		private Func<Guid> _bulkEmailId;
		public  virtual Guid BulkEmailId {
			get {
				return (_bulkEmailId ?? (_bulkEmailId = () => Guid.Empty)).Invoke();
			}
			set {
				_bulkEmailId = () => { return value; };
			}
		}

		private Func<string> _applicationUrl;
		public  virtual string ApplicationUrl {
			get {
				return (_applicationUrl ?? (_applicationUrl = () => null)).Invoke();
			}
			set {
				_applicationUrl = () => { return value; };
			}
		}

		private Func<Guid> _sessionUId;
		public  virtual Guid SessionUId {
			get {
				return (_sessionUId ?? (_sessionUId = () => Guid.Empty)).Invoke();
			}
			set {
				_sessionUId = () => { return value; };
			}
		}

		private ProcessLane1 _lane1;
		public  ProcessLane1 Lane1 {
			get {
				return _lane1 ?? ((_lane1) = new ProcessLane1(UserConnection, this));
			}
		}

		private ProcessFlowElement _startEvent1;
		public  ProcessFlowElement StartEvent1 {
			get {
				return _startEvent1 ?? (_startEvent1 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartEvent",
					Name = "StartEvent1",
					SchemaElementUId = new Guid("b34da711-ef63-45f5-9f61-b12a7b00c25f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
				});
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
					SchemaElementUId = new Guid("dccf6c23-3ee3-4b32-b31e-51e69db287e4"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
				});
			}
		}

		private ProcessScriptTask _scriptTask1;
		public  ProcessScriptTask ScriptTask1 {
			get {
				return _scriptTask1 ?? (_scriptTask1 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask1",
					SchemaElementUId = new Guid("177a189b-8369-4d5f-ac48-10d3c887933f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
					Script = ProcessModel.GetScriptTaskMethod("ScriptTask1Execute"),
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[StartEvent1.SchemaElementUId] = new Collection<ProcessFlowElement> { StartEvent1 };
			FlowElements[TerminateEvent1.SchemaElementUId] = new Collection<ProcessFlowElement> { TerminateEvent1 };
			FlowElements[ScriptTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask1 };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "StartEvent1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ScriptTask1", e.Context.SenderName));
						break;
					case "TerminateEvent1":
						CompleteProcess();
						break;
					case "ScriptTask1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("TerminateEvent1", e.Context.SenderName));
						break;
			}
		}

		private void WritePropertyValues(DataWriter writer, bool useAllValueSources) {
			if (!HasMapping("BulkEmailId")) {
				writer.WriteValue("BulkEmailId", BulkEmailId, Guid.Empty);
			}
			if (!HasMapping("ApplicationUrl")) {
				writer.WriteValue("ApplicationUrl", ApplicationUrl, null);
			}
			if (!HasMapping("SessionUId")) {
				writer.WriteValue("SessionUId", SessionUId, Guid.Empty);
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
			MetaPathParameterValues.Add("078e30e0-7451-46fc-8ec1-197be366f2d2", () => BulkEmailId);
			MetaPathParameterValues.Add("f8694524-2b51-476b-bd50-f6c8831e50d2", () => ApplicationUrl);
			MetaPathParameterValues.Add("3ea09e15-555d-47fc-b466-629d200d2ec2", () => SessionUId);
		}

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			bool hasValueToRead = reader.HasValue();
			switch (reader.CurrentName) {
				case "BulkEmailId":
					if (!hasValueToRead) break;
					BulkEmailId = reader.GetValue<System.Guid>();
				break;
				case "ApplicationUrl":
					if (!hasValueToRead) break;
					ApplicationUrl = reader.GetValue<System.String>();
				break;
				case "SessionUId":
					if (!hasValueToRead) break;
					SessionUId = reader.GetValue<System.Guid>();
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
			var cloneItem = (SendImmediatelyTriggeredSessionedEmailProcess)base.CloneShallow();
			cloneItem.ExecutedEventHandler = ExecutedEventHandler;
			return cloneItem;
		}

		#endregion

	}

	#endregion

}

