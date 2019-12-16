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
	using Terrasoft.Common.Json;
	using Terrasoft.Configuration;
	using Terrasoft.Configuration.FileImport;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;

	#region Class: UpdateSsoContactMethodsWrapper

	/// <exclude/>
	public class UpdateSsoContactMethodsWrapper : ProcessModel
	{

		public UpdateSsoContactMethodsWrapper(Process process)
			: base(process) {
			AddScriptTaskMethod("ActualizeContactScriptTaskExecute", ActualizeContactScriptTaskExecute);
		}

		#region Methods: Private

		private bool ActualizeContactScriptTaskExecute(ProcessExecutingContext context) {
			Dictionary<string, string> contactValues = Json.Deserialize<Dictionary<string, string>>(Get<string>("ClaimData"));
			UserConnection userConnection = Get<UserConnection>("UserConnection");
			var contact = new Terrasoft.Configuration.Contact(userConnection);
			string contactId;
			if (!contactValues.TryGetValue(contact.Schema.GetPrimaryColumnName(), out contactId)) {
				return true;
			}
			if (contact.FetchFromDB(new Guid(contactId))) {
				UpdateContact(contact, contactValues);
				string isNewRecord;
				if (contactValues.TryGetValue("IsNewRecord", out isNewRecord) &&
						isNewRecord.Equals("true", StringComparison.InvariantCultureIgnoreCase)) {
					EntitySchema schema = userConnection.EntitySchemaManager.GetInstanceByName("Contact");
					var userId = new Guid(contactValues["SysAdminUnitId"]);
					userConnection.DBSecurityEngine.AddDefRights(contact.Id, userId, contact.Id, schema);
				}
			}
			return true;
		}

			private void UpdateContact(Entity contact, Dictionary<string, string> contactValues) {
				UserConnection userConnection = Get<UserConnection>("UserConnection");
				var importParamsGenerator = new BaseImportParamsGenerator();
				ImportParameters parameters = importParamsGenerator.GenerateParameters(contact.Schema, contactValues);
				var fileImporter = new FileImporter(userConnection);
				fileImporter.ImportWithParams(parameters);
			}

		#endregion

	}

	#endregion

	#region Class: UpdateSsoContact

	/// <exclude/>
	public class UpdateSsoContact : Terrasoft.Core.Process.Process
	{

		#region Class: ProcessLane1

		/// <exclude/>
		public class ProcessLane1 : ProcessLane
		{

			public ProcessLane1(UserConnection userConnection, UpdateSsoContact process)
				: base(userConnection) {
				Owner = process;
				IsUsedParentUserContexts = false;
			}

		}

		#endregion

		public UpdateSsoContact(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "UpdateSsoContact";
			SchemaUId = new Guid("68863bda-42e0-4e97-8ccd-44ecc9704920");
			Caption = Schema.Caption;
			SchemaManagerName = "ProcessSchemaManager";
			SerializeToDB = true;
			SerializeToMemory = true;
			IsLogging = true;
			_claimDataParameter = () => { return new LocalizableString((ClaimData)); };
			ProcessModel = new UpdateSsoContactMethodsWrapper(this);
			InitializeFlowElements();
		}

		#region Properties: Private

		private  Guid InternalSchemaUId {
			get {
				return new Guid("68863bda-42e0-4e97-8ccd-44ecc9704920");
			}
		}

		#endregion

		#region Properties: Public

		public  virtual string ClaimData {
			get;
			set;
		}

		private Func<string> _claimDataParameter;
		public  virtual string ClaimDataParameter {
			get {
				return (_claimDataParameter ?? (_claimDataParameter = () => null)).Invoke();
			}
			set {
				_claimDataParameter = () => { return value; };
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
					SchemaElementUId = new Guid("53f8bb9d-d2f9-4c5b-971e-b3e40d52f392"),
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
					SchemaElementUId = new Guid("555e3b1a-abd9-471c-95fa-aa67e9fd6682"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
				});
			}
		}

		private ProcessScriptTask _actualizeContactScriptTask;
		public  ProcessScriptTask ActualizeContactScriptTask {
			get {
				return _actualizeContactScriptTask ?? (_actualizeContactScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ActualizeContactScriptTask",
					SchemaElementUId = new Guid("cbb782a3-c7d6-4bd4-aa95-5920db4ed1cd"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
					Script = ProcessModel.GetScriptTaskMethod("ActualizeContactScriptTaskExecute"),
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[StartEvent1.SchemaElementUId] = new Collection<ProcessFlowElement> { StartEvent1 };
			FlowElements[TerminateEvent1.SchemaElementUId] = new Collection<ProcessFlowElement> { TerminateEvent1 };
			FlowElements[ActualizeContactScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { ActualizeContactScriptTask };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "StartEvent1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ActualizeContactScriptTask", e.Context.SenderName));
						break;
					case "TerminateEvent1":
						CompleteProcess();
						break;
					case "ActualizeContactScriptTask":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("TerminateEvent1", e.Context.SenderName));
						break;
			}
		}

		private void WritePropertyValues(DataWriter writer, bool useAllValueSources) {
			if (!HasMapping("ClaimData")) {
				writer.WriteValue("ClaimData", ClaimData, null);
			}
			if (!HasMapping("ClaimDataParameter")) {
				writer.WriteValue("ClaimDataParameter", ClaimDataParameter, null);
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
			MetaPathParameterValues.Add("e0163958-03fb-4dac-9b04-e86470669a67", () => ClaimData);
			MetaPathParameterValues.Add("54f5ff55-a135-4389-a68e-d3d53ae02592", () => ClaimDataParameter);
		}

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			bool hasValueToRead = reader.HasValue();
			switch (reader.CurrentName) {
				case "ClaimData":
					if (!hasValueToRead) break;
					ClaimData = reader.GetValue<System.String>();
				break;
				case "ClaimDataParameter":
					if (!hasValueToRead) break;
					ClaimDataParameter = reader.GetValue<System.String>();
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
			var cloneItem = (UpdateSsoContact)base.CloneShallow();
			cloneItem.ExecutedEventHandler = ExecutedEventHandler;
			return cloneItem;
		}

		#endregion

	}

	#endregion

}

