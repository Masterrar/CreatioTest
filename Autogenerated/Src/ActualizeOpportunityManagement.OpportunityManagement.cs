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
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;
	using Terrasoft.Messaging.Common;

	#region Class: ActualizeOpportunityManagementMethodsWrapper

	/// <exclude/>
	public class ActualizeOpportunityManagementMethodsWrapper : ProcessModel
	{

		public ActualizeOpportunityManagementMethodsWrapper(Process process)
			: base(process) {
			AddScriptTaskMethod("ScriptTask1Execute", ScriptTask1Execute);
		}

		#region Methods: Private

		private bool ScriptTask1Execute(ProcessExecutingContext context) {
			UserConnection userConnection = Get<UserConnection>("UserConnection");
			string useOldProcessFeatureCode = "UseOldOpportunityManagementProcess";
			bool useOldVersion = Get<bool>("UseOldOpportunityManagement");
			bool forceUpdateUsageState = Get<bool>("ForceUpdateUsageState");
			bool useOldVersionFeatureEnabled = userConnection.GetIsFeatureEnabled(useOldProcessFeatureCode);
			if (forceUpdateUsageState && useOldVersionFeatureEnabled != useOldVersion) {
				var newState = useOldVersion ? FeatureState.Enabled : FeatureState.Disabled;
				userConnection.SetFeatureState(useOldProcessFeatureCode, (int)newState);
			}
			global::Common.Logging.ILog _logger = global::Common.Logging.LogManager.GetLogger("Process");
			StoredProcedure storedProcedure = new StoredProcedure(userConnection,
				"tsp_ActualizeOpportunityManagementProcess");
			storedProcedure.WithParameter("fetchProcessesInfo", true);
			Dictionary<Guid, bool> processSchemasInfos = new Dictionary<Guid, bool>();
			using (var executor = userConnection.EnsureDBConnection()) {
				using (var reader = storedProcedure.ExecuteReader(executor)) {
					while (reader.Read()) {
						var schemaName = reader.GetValue<string>("SchemaName");
						var schemaId = reader.GetValue<Guid>("SchemaId");
						var toBeEnabled = reader.GetValue<bool>("ToBeEnabled");
						_logger.InfoFormat("Process {0}({1}) will be set to enabled state = {2}", schemaName,
							schemaId, toBeEnabled);
						processSchemasInfos[schemaId] = toBeEnabled;
					}
				}
			}
			var processSchemaManager = userConnection.ProcessSchemaManager;
			foreach (var processSchemaInfo in processSchemasInfos) {
				if (processSchemaInfo.Value) {
					processSchemaManager.EnableProcess(userConnection, processSchemaInfo.Key);
				} else {
					processSchemaManager.DisableProcess(userConnection, processSchemaInfo.Key);
				}
			}
			return true;
		}

		#endregion

	}

	#endregion

	#region Class: ActualizeOpportunityManagement

	/// <exclude/>
	public class ActualizeOpportunityManagement : Terrasoft.Core.Process.Process
	{

		#region Class: ProcessLane1

		/// <exclude/>
		public class ProcessLane1 : ProcessLane
		{

			public ProcessLane1(UserConnection userConnection, ActualizeOpportunityManagement process)
				: base(userConnection) {
				Owner = process;
				IsUsedParentUserContexts = false;
			}

		}

		#endregion

		public ActualizeOpportunityManagement(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ActualizeOpportunityManagement";
			SchemaUId = new Guid("b6ff5850-31d1-4c81-8623-3bed938d7410");
			Caption = Schema.Caption;
			SchemaManagerName = "ProcessSchemaManager";
			SerializeToDB = true;
			SerializeToMemory = true;
			IsLogging = true;
			_useOldOpportunityManagement = () => { return (bool)(false); };
			_forceUpdateUsageState = () => { return (bool)(false); };
			ProcessModel = new ActualizeOpportunityManagementMethodsWrapper(this);
			InitializeFlowElements();
		}

		#region Properties: Private

		private  Guid InternalSchemaUId {
			get {
				return new Guid("b6ff5850-31d1-4c81-8623-3bed938d7410");
			}
		}

		#endregion

		#region Properties: Public

		private Func<bool> _useOldOpportunityManagement;
		public  virtual bool UseOldOpportunityManagement {
			get {
				return (_useOldOpportunityManagement ?? (_useOldOpportunityManagement = () => false)).Invoke();
			}
			set {
				_useOldOpportunityManagement = () => { return value; };
			}
		}

		private Func<bool> _forceUpdateUsageState;
		public  virtual bool ForceUpdateUsageState {
			get {
				return (_forceUpdateUsageState ?? (_forceUpdateUsageState = () => false)).Invoke();
			}
			set {
				_forceUpdateUsageState = () => { return value; };
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
					SchemaElementUId = new Guid("bd55a57e-84da-418d-b2c5-eff69e0d9f66"),
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
					SchemaElementUId = new Guid("6e0c0db2-0fc8-4e1d-9405-615558bb3aa8"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
					Script = ProcessModel.GetScriptTaskMethod("ScriptTask1Execute"),
				});
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
					SchemaElementUId = new Guid("30dea69a-5bf4-41be-a9fa-4c2cfc034c42"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[TerminateEvent1.SchemaElementUId] = new Collection<ProcessFlowElement> { TerminateEvent1 };
			FlowElements[ScriptTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask1 };
			FlowElements[StartEvent1.SchemaElementUId] = new Collection<ProcessFlowElement> { StartEvent1 };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "TerminateEvent1":
						CompleteProcess();
						break;
					case "ScriptTask1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("TerminateEvent1", e.Context.SenderName));
						break;
					case "StartEvent1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ScriptTask1", e.Context.SenderName));
						break;
			}
		}

		private void WritePropertyValues(DataWriter writer, bool useAllValueSources) {
			if (!HasMapping("UseOldOpportunityManagement")) {
				writer.WriteValue("UseOldOpportunityManagement", UseOldOpportunityManagement, false);
			}
			if (!HasMapping("ForceUpdateUsageState")) {
				writer.WriteValue("ForceUpdateUsageState", ForceUpdateUsageState, false);
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
			MetaPathParameterValues.Add("3ff48ce7-83d2-4277-b6fd-fab27995227b", () => UseOldOpportunityManagement);
			MetaPathParameterValues.Add("bef529ce-cae2-41eb-a7f6-d2fd86d702a1", () => ForceUpdateUsageState);
		}

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			bool hasValueToRead = reader.HasValue();
			switch (reader.CurrentName) {
				case "UseOldOpportunityManagement":
					if (!hasValueToRead) break;
					UseOldOpportunityManagement = reader.GetValue<System.Boolean>();
				break;
				case "ForceUpdateUsageState":
					if (!hasValueToRead) break;
					ForceUpdateUsageState = reader.GetValue<System.Boolean>();
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
			var cloneItem = (ActualizeOpportunityManagement)base.CloneShallow();
			cloneItem.ExecutedEventHandler = ExecutedEventHandler;
			return cloneItem;
		}

		#endregion

	}

	#endregion

}

