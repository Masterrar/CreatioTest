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

	#region Class: MLNewOpprtunityScoringProcess

	/// <exclude/>
	public class MLNewOpprtunityScoringProcess : Terrasoft.Core.Process.Process
	{

		#region Class: ProcessLane1

		/// <exclude/>
		public class ProcessLane1 : ProcessLane
		{

			public ProcessLane1(UserConnection userConnection, MLNewOpprtunityScoringProcess process)
				: base(userConnection) {
				Owner = process;
				IsUsedParentUserContexts = false;
			}

		}

		#endregion

		#region Class: SubProcess1FlowElement

		/// <exclude/>
		public class SubProcess1FlowElement : SubProcessProxy
		{

			#region Constructors: Public

			public SubProcess1FlowElement(UserConnection userConnection, MLNewOpprtunityScoringProcess process)
				: base(userConnection, process) {
				InitialSchemaUId = new Guid("5b0e183e-35ad-4c4e-8e21-234be22d89b4");
			}

			#endregion

			#region Properties: Public

			public Guid ScoreModelId {
				get {
					return GetParameterValue<Guid>("ScoreModelId");
				}
				set {
					SetParameterValue("ScoreModelId", value);
				}
			}

			public Guid ProcessSchemaParameter1 {
				get {
					return GetParameterValue<Guid>("ProcessSchemaParameter1");
				}
				set {
					SetParameterValue("ProcessSchemaParameter1", value);
				}
			}

			public Guid RecordId {
				get {
					return GetParameterValue<Guid>("RecordId");
				}
				set {
					SetParameterValue("RecordId", value);
				}
			}

			#endregion

			#region Methods: Protected

			protected override void InitializeOwnProperties(Process owner) {
				base.InitializeOwnProperties(owner);
				var process = (MLNewOpprtunityScoringProcess)owner;
				Name = "SubProcess1";
				SerializeToDB = true;
				IsLogging = true;
				SchemaElementUId = new Guid("a16ca984-b679-428e-97d1-74f90e4f75a4");
				CreatedInSchemaUId = process.InternalSchemaUId;
				ProcessLane = process.Lane1;
			}

			protected override void InitializeParameterValues() {
				base.InitializeParameterValues();
				var process = (MLNewOpprtunityScoringProcess)Owner;
				SetParameterValue("RecordId", (Guid)((process.StartSignal1.RecordId)));
			}

			#endregion

		}

		#endregion

		public MLNewOpprtunityScoringProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "MLNewOpprtunityScoringProcess";
			SchemaUId = new Guid("b043bc4b-e86d-41aa-89d1-0c147f2dbc44");
			Caption = Schema.Caption;
			SchemaManagerName = "ProcessSchemaManager";
			SerializeToDB = true;
			SerializeToMemory = true;
			IsLogging = true;
			_notificationCaption = () => { return new LocalizableString((Caption)); };
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("b043bc4b-e86d-41aa-89d1-0c147f2dbc44");
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

		private ProcessLane1 _lane1;
		public ProcessLane1 Lane1 {
			get {
				return _lane1 ?? ((_lane1) = new ProcessLane1(UserConnection, this));
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
					SchemaElementUId = new Guid("93dae536-6838-427b-bfa3-b920f84f2991"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
				});
			}
		}

		private ProcessStartSignalEvent _startSignal1;
		public ProcessStartSignalEvent StartSignal1 {
			get {
				return _startSignal1 ?? (_startSignal1 = new ProcessStartSignalEvent(UserConnection) {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartSignalEvent",
					Name = "StartSignal1",
					SerializeToDB = false,
					IsLogging = true,
					SchemaElementUId = new Guid("798b8cef-777d-4932-b39b-d890d8d9af31"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private SubProcess1FlowElement _subProcess1;
		public SubProcess1FlowElement SubProcess1 {
			get {
				return _subProcess1 ?? ((_subProcess1) = new SubProcess1FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessToken _startSignal1SubProcess1Token;
		public ProcessToken StartSignal1SubProcess1Token {
			get {
				return _startSignal1SubProcess1Token ?? (_startSignal1SubProcess1Token = new ProcessToken(UserConnection) {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaToken",
					Name = "StartSignal1SubProcess1Token",
					SchemaElementUId = new Guid("49331e5c-493a-4b60-afb7-40e653f64f91"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[TerminateEvent1.SchemaElementUId] = new Collection<ProcessFlowElement> { TerminateEvent1 };
			FlowElements[StartSignal1.SchemaElementUId] = new Collection<ProcessFlowElement> { StartSignal1 };
			FlowElements[SubProcess1.SchemaElementUId] = new Collection<ProcessFlowElement> { SubProcess1 };
			FlowElements[StartSignal1SubProcess1Token.SchemaElementUId] = new Collection<ProcessFlowElement> { StartSignal1SubProcess1Token };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "TerminateEvent1":
						CompleteProcess();
						break;
					case "StartSignal1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("StartSignal1SubProcess1Token", e.Context.SenderName));
						break;
					case "SubProcess1":
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("TerminateEvent1", e.Context.SenderName));
						break;
					case "StartSignal1SubProcess1Token":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("SubProcess1", e.Context.SenderName));
						break;
			}
		}

		private void WritePropertyValues(DataWriter writer, bool useAllValueSources) {
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
			MetaPathParameterValues.Add("88b522e3-a734-4108-b1ee-d697dfbaeb5b", () => StartSignal1.RecordId);
			MetaPathParameterValues.Add("5d1d8fdf-760f-473a-82ba-67ec1766c68d", () => SubProcess1.ScoreModelId);
			MetaPathParameterValues.Add("b9c460de-ab3f-4d1b-8fd2-e661a1051638", () => SubProcess1.ProcessSchemaParameter1);
			MetaPathParameterValues.Add("342bc2ca-fffc-461e-9e8c-f3c2653ef5cd", () => SubProcess1.RecordId);
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
			var cloneItem = (MLNewOpprtunityScoringProcess)base.CloneShallow();
			cloneItem.ExecutedEventHandler = ExecutedEventHandler;
			return cloneItem;
		}

		#endregion

	}

	#endregion

}

