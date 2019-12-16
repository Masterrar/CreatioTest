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

	#region Class: MLLeadQualificationScoringProcess

	/// <exclude/>
	public class MLLeadQualificationScoringProcess : Terrasoft.Core.Process.Process
	{

		#region Class: ProcessLane1

		/// <exclude/>
		public class ProcessLane1 : ProcessLane
		{

			public ProcessLane1(UserConnection userConnection, MLLeadQualificationScoringProcess process)
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

			public SubProcess1FlowElement(UserConnection userConnection, MLLeadQualificationScoringProcess process)
				: base(userConnection, process) {
				InitialSchemaUId = new Guid("4d01c8d5-6e09-438f-9253-457a95b2e9f6");
			}

			#endregion

			#region Properties: Public

			public  Guid RecordId {
				get {
					return GetParameterValue<Guid>("RecordId");
				}
				set {
					SetParameterValue("RecordId", value);
				}
			}

			public  Guid ScoreModelId {
				get {
					return GetParameterValue<Guid>("ScoreModelId");
				}
				set {
					SetParameterValue("ScoreModelId", value);
				}
			}

			public  Guid LeadSchemaUId {
				get {
					return GetParameterValue<Guid>("LeadSchemaUId");
				}
				set {
					SetParameterValue("LeadSchemaUId", value);
				}
			}

			#endregion

			#region Methods: Protected

			protected override void InitializeOwnProperties(Process owner) {
				base.InitializeOwnProperties(owner);
				var process = (MLLeadQualificationScoringProcess)owner;
				Name = "SubProcess1";
				SerializeToDB = true;
				IsLogging = true;
				SchemaElementUId = new Guid("0d9fcd86-7be9-4827-913b-be9970f52dac");
				CreatedInSchemaUId = process.InternalSchemaUId;
				ProcessLane = process.Lane1;
			}

			protected override void InitializeParameterValues() {
				base.InitializeParameterValues();
				var process = (MLLeadQualificationScoringProcess)Owner;
				SetParameterValue("RecordId", (Guid)((process.StartSignal.RecordId)));
			}

			#endregion

		}

		#endregion

		public MLLeadQualificationScoringProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "MLLeadQualificationScoringProcess";
			SchemaUId = new Guid("83107e1b-331c-4d43-b58e-bb0c0649a7e2");
			Caption = Schema.Caption;
			SchemaManagerName = "ProcessSchemaManager";
			SerializeToDB = true;
			SerializeToMemory = true;
			IsLogging = true;
			_notificationCaption = () => { return new LocalizableString((Caption)); };
			_leadSchemaUId = () => { return (Guid)(new Guid("{41AF89E9-750B-4EBB-8CAC-FF39B64841EC}")); };
			InitializeFlowElements();
		}

		#region Properties: Private

		private  Guid InternalSchemaUId {
			get {
				return new Guid("83107e1b-331c-4d43-b58e-bb0c0649a7e2");
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

		private Func<Guid> _leadSchemaUId;
		public  virtual Guid LeadSchemaUId {
			get {
				return (_leadSchemaUId ?? (_leadSchemaUId = () => Guid.Empty)).Invoke();
			}
			set {
				_leadSchemaUId = () => { return value; };
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
					SchemaElementUId = new Guid("c073f490-87d7-461c-9e45-1842db44813d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
				});
			}
		}

		private ProcessStartSignalEvent _startSignal;
		public  ProcessStartSignalEvent StartSignal {
			get {
				return _startSignal ?? (_startSignal = new ProcessStartSignalEvent(UserConnection) {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartSignalEvent",
					Name = "StartSignal",
					SerializeToDB = false,
					IsLogging = true,
					SchemaElementUId = new Guid("f6a831e5-f4e5-4a6a-9929-fb6b0c2a80df"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private SubProcess1FlowElement _subProcess1;
		public  SubProcess1FlowElement SubProcess1 {
			get {
				return _subProcess1 ?? ((_subProcess1) = new SubProcess1FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessToken _startSignalSubProcess1Token;
		public  ProcessToken StartSignalSubProcess1Token {
			get {
				return _startSignalSubProcess1Token ?? (_startSignalSubProcess1Token = new ProcessToken(UserConnection) {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaToken",
					Name = "StartSignalSubProcess1Token",
					SchemaElementUId = new Guid("0eaf80cb-2cd8-4eda-8297-3fa874d203fa"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[TerminateEvent1.SchemaElementUId] = new Collection<ProcessFlowElement> { TerminateEvent1 };
			FlowElements[StartSignal.SchemaElementUId] = new Collection<ProcessFlowElement> { StartSignal };
			FlowElements[SubProcess1.SchemaElementUId] = new Collection<ProcessFlowElement> { SubProcess1 };
			FlowElements[StartSignalSubProcess1Token.SchemaElementUId] = new Collection<ProcessFlowElement> { StartSignalSubProcess1Token };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "TerminateEvent1":
						CompleteProcess();
						break;
					case "StartSignal":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("StartSignalSubProcess1Token", e.Context.SenderName));
						break;
					case "SubProcess1":
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("TerminateEvent1", e.Context.SenderName));
						break;
					case "StartSignalSubProcess1Token":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("SubProcess1", e.Context.SenderName));
						break;
			}
		}

		private void WritePropertyValues(DataWriter writer, bool useAllValueSources) {
			if (!HasMapping("LeadSchemaUId")) {
				writer.WriteValue("LeadSchemaUId", LeadSchemaUId, Guid.Empty);
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
			MetaPathParameterValues.Add("5c234869-5a2b-4832-acaf-d0420f360401", () => LeadSchemaUId);
			MetaPathParameterValues.Add("8614aa07-1c1c-4a42-b397-0b767edd2154", () => StartSignal.RecordId);
			MetaPathParameterValues.Add("963db144-74ac-453f-8fdd-263731081899", () => SubProcess1.RecordId);
			MetaPathParameterValues.Add("050d3898-c351-4d7b-bd74-9d0b07e3a2bd", () => SubProcess1.ScoreModelId);
			MetaPathParameterValues.Add("6af0a26d-467f-40ee-a64f-588b2a97cb93", () => SubProcess1.LeadSchemaUId);
		}

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			bool hasValueToRead = reader.HasValue();
			switch (reader.CurrentName) {
				case "LeadSchemaUId":
					if (!hasValueToRead) break;
					LeadSchemaUId = reader.GetValue<System.Guid>();
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
			var cloneItem = (MLLeadQualificationScoringProcess)base.CloneShallow();
			cloneItem.ExecutedEventHandler = ExecutedEventHandler;
			return cloneItem;
		}

		#endregion

	}

	#endregion

}

