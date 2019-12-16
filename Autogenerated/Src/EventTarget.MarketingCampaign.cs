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
	using Terrasoft.Configuration.MarketingCampaign;
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

	#region Class: EventTargetSchema

	/// <exclude/>
	public class EventTargetSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public EventTargetSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public EventTargetSchema(EventTargetSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public EventTargetSchema(EventTargetSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("fb50e79e-ede8-4714-b6c8-c7cf4d3a9f87");
			RealUId = new Guid("fb50e79e-ede8-4714-b6c8-c7cf4d3a9f87");
			Name = "EventTarget";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("b827f319-d8b8-41a8-9645-da32137f000d");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("6eaac54f-9bf3-470c-8bf5-4478a07094a8")) == null) {
				Columns.Add(CreateEventColumn());
			}
			if (Columns.FindByUId(new Guid("b352323b-76f5-4633-b11b-378d66ed9282")) == null) {
				Columns.Add(CreateEventResponseColumn());
			}
			if (Columns.FindByUId(new Guid("c1ab957f-49de-47bc-9df2-2b52e71fde23")) == null) {
				Columns.Add(CreateNoteColumn());
			}
			if (Columns.FindByUId(new Guid("7aedd8e6-8654-474d-9da8-21f92dc045f9")) == null) {
				Columns.Add(CreateIsFromGroupColumn());
			}
			if (Columns.FindByUId(new Guid("3e2f761d-432c-43fc-ae14-386b07f004a7")) == null) {
				Columns.Add(CreateContactColumn());
			}
			if (Columns.FindByUId(new Guid("1a79fbd7-10b2-4e29-bb1f-c4b3aec9e534")) == null) {
				Columns.Add(CreateGeneratedWebFormColumn());
			}
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.ModifiedInSchemaUId = new Guid("fb50e79e-ede8-4714-b6c8-c7cf4d3a9f87");
			column.CreatedInPackageId = new Guid("b827f319-d8b8-41a8-9645-da32137f000d");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.ModifiedInSchemaUId = new Guid("fb50e79e-ede8-4714-b6c8-c7cf4d3a9f87");
			column.CreatedInPackageId = new Guid("b827f319-d8b8-41a8-9645-da32137f000d");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.ModifiedInSchemaUId = new Guid("fb50e79e-ede8-4714-b6c8-c7cf4d3a9f87");
			column.CreatedInPackageId = new Guid("b827f319-d8b8-41a8-9645-da32137f000d");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.ModifiedInSchemaUId = new Guid("fb50e79e-ede8-4714-b6c8-c7cf4d3a9f87");
			column.CreatedInPackageId = new Guid("b827f319-d8b8-41a8-9645-da32137f000d");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.ModifiedInSchemaUId = new Guid("fb50e79e-ede8-4714-b6c8-c7cf4d3a9f87");
			column.CreatedInPackageId = new Guid("b827f319-d8b8-41a8-9645-da32137f000d");
			return column;
		}

		protected override EntitySchemaColumn CreateProcessListenersColumn() {
			EntitySchemaColumn column = base.CreateProcessListenersColumn();
			column.ModifiedInSchemaUId = new Guid("fb50e79e-ede8-4714-b6c8-c7cf4d3a9f87");
			column.CreatedInPackageId = new Guid("b827f319-d8b8-41a8-9645-da32137f000d");
			return column;
		}

		protected virtual EntitySchemaColumn CreateEventColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("6eaac54f-9bf3-470c-8bf5-4478a07094a8"),
				Name = @"Event",
				ReferenceSchemaUId = new Guid("5b4fdfc7-12b6-4b4f-a9bd-b6f1b6e4447f"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("fb50e79e-ede8-4714-b6c8-c7cf4d3a9f87"),
				ModifiedInSchemaUId = new Guid("fb50e79e-ede8-4714-b6c8-c7cf4d3a9f87"),
				CreatedInPackageId = new Guid("b827f319-d8b8-41a8-9645-da32137f000d")
			};
		}

		protected virtual EntitySchemaColumn CreateEventResponseColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("b352323b-76f5-4633-b11b-378d66ed9282"),
				Name = @"EventResponse",
				ReferenceSchemaUId = new Guid("07c07e96-3347-4788-91bd-36935aeada6c"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("fb50e79e-ede8-4714-b6c8-c7cf4d3a9f87"),
				ModifiedInSchemaUId = new Guid("fb50e79e-ede8-4714-b6c8-c7cf4d3a9f87"),
				CreatedInPackageId = new Guid("b827f319-d8b8-41a8-9645-da32137f000d"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"c6eae023-2778-49c6-8273-6b015c1cc611"
				}
			};
		}

		protected virtual EntitySchemaColumn CreateNoteColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("LongText")) {
				UId = new Guid("c1ab957f-49de-47bc-9df2-2b52e71fde23"),
				Name = @"Note",
				CreatedInSchemaUId = new Guid("fb50e79e-ede8-4714-b6c8-c7cf4d3a9f87"),
				ModifiedInSchemaUId = new Guid("fb50e79e-ede8-4714-b6c8-c7cf4d3a9f87"),
				CreatedInPackageId = new Guid("b827f319-d8b8-41a8-9645-da32137f000d")
			};
		}

		protected virtual EntitySchemaColumn CreateIsFromGroupColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("7aedd8e6-8654-474d-9da8-21f92dc045f9"),
				Name = @"IsFromGroup",
				IsValueCloneable = false,
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("fb50e79e-ede8-4714-b6c8-c7cf4d3a9f87"),
				ModifiedInSchemaUId = new Guid("fb50e79e-ede8-4714-b6c8-c7cf4d3a9f87"),
				CreatedInPackageId = new Guid("48513af2-42ae-4933-a664-64fbd4224266"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"False"
				}
			};
		}

		protected virtual EntitySchemaColumn CreateContactColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("3e2f761d-432c-43fc-ae14-386b07f004a7"),
				Name = @"Contact",
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("fb50e79e-ede8-4714-b6c8-c7cf4d3a9f87"),
				ModifiedInSchemaUId = new Guid("fb50e79e-ede8-4714-b6c8-c7cf4d3a9f87"),
				CreatedInPackageId = new Guid("f34f31e2-7f75-40a5-8a68-3d9273ea8cb6")
			};
		}

		protected virtual EntitySchemaColumn CreateGeneratedWebFormColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("1a79fbd7-10b2-4e29-bb1f-c4b3aec9e534"),
				Name = @"GeneratedWebForm",
				ReferenceSchemaUId = new Guid("41ae7d8d-bec3-41df-a6f0-2ab0d08b3967"),
				IsValueCloneable = false,
				IsIndexed = true,
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("fb50e79e-ede8-4714-b6c8-c7cf4d3a9f87"),
				ModifiedInSchemaUId = new Guid("fb50e79e-ede8-4714-b6c8-c7cf4d3a9f87"),
				CreatedInPackageId = new Guid("d29e8339-d159-492c-b850-b36f13c6eff8")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateEventTargetEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateEventTargetEventsProcessSchema() {
			var schema = new EventTargetEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new EventTarget(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new EventTarget_MarketingCampaignEventsProcess(userConnection);
		}

		public override object Clone() {
			return new EventTargetSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new EventTargetSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("fb50e79e-ede8-4714-b6c8-c7cf4d3a9f87"));
		}

		#endregion

	}

	#endregion

	#region Class: EventTarget

	/// <summary>
	/// Event participant.
	/// </summary>
	public class EventTarget : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public EventTarget(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "EventTarget";
		}

		public EventTarget(EventTarget source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid EventId {
			get {
				return GetTypedColumnValue<Guid>("EventId");
			}
			set {
				SetColumnValue("EventId", value);
				_event = null;
			}
		}

		/// <exclude/>
		public string EventName {
			get {
				return GetTypedColumnValue<string>("EventName");
			}
			set {
				SetColumnValue("EventName", value);
				if (_event != null) {
					_event.Name = value;
				}
			}
		}

		private Event _event;
		/// <summary>
		/// Event.
		/// </summary>
		public Event Event {
			get {
				return _event ??
					(_event = LookupColumnEntities.GetEntity("Event") as Event);
			}
		}

		/// <exclude/>
		public Guid EventResponseId {
			get {
				return GetTypedColumnValue<Guid>("EventResponseId");
			}
			set {
				SetColumnValue("EventResponseId", value);
				_eventResponse = null;
			}
		}

		/// <exclude/>
		public string EventResponseName {
			get {
				return GetTypedColumnValue<string>("EventResponseName");
			}
			set {
				SetColumnValue("EventResponseName", value);
				if (_eventResponse != null) {
					_eventResponse.Name = value;
				}
			}
		}

		private EventResponse _eventResponse;
		/// <summary>
		/// Response.
		/// </summary>
		public EventResponse EventResponse {
			get {
				return _eventResponse ??
					(_eventResponse = LookupColumnEntities.GetEntity("EventResponse") as EventResponse);
			}
		}

		/// <summary>
		/// Notes.
		/// </summary>
		public string Note {
			get {
				return GetTypedColumnValue<string>("Note");
			}
			set {
				SetColumnValue("Note", value);
			}
		}

		/// <summary>
		/// IsFromGroup.
		/// </summary>
		public bool IsFromGroup {
			get {
				return GetTypedColumnValue<bool>("IsFromGroup");
			}
			set {
				SetColumnValue("IsFromGroup", value);
			}
		}

		/// <exclude/>
		public Guid ContactId {
			get {
				return GetTypedColumnValue<Guid>("ContactId");
			}
			set {
				SetColumnValue("ContactId", value);
				_contact = null;
			}
		}

		/// <exclude/>
		public string ContactName {
			get {
				return GetTypedColumnValue<string>("ContactName");
			}
			set {
				SetColumnValue("ContactName", value);
				if (_contact != null) {
					_contact.Name = value;
				}
			}
		}

		private Contact _contact;
		/// <summary>
		/// Contact.
		/// </summary>
		public Contact Contact {
			get {
				return _contact ??
					(_contact = LookupColumnEntities.GetEntity("Contact") as Contact);
			}
		}

		/// <exclude/>
		public Guid GeneratedWebFormId {
			get {
				return GetTypedColumnValue<Guid>("GeneratedWebFormId");
			}
			set {
				SetColumnValue("GeneratedWebFormId", value);
				_generatedWebForm = null;
			}
		}

		/// <exclude/>
		public string GeneratedWebFormName {
			get {
				return GetTypedColumnValue<string>("GeneratedWebFormName");
			}
			set {
				SetColumnValue("GeneratedWebFormName", value);
				if (_generatedWebForm != null) {
					_generatedWebForm.Name = value;
				}
			}
		}

		private GeneratedWebForm _generatedWebForm;
		/// <summary>
		/// GeneratedWebForm.
		/// </summary>
		public GeneratedWebForm GeneratedWebForm {
			get {
				return _generatedWebForm ??
					(_generatedWebForm = LookupColumnEntities.GetEntity("GeneratedWebForm") as GeneratedWebForm);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new EventTarget_MarketingCampaignEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("EventTargetDeleted", e);
			Inserted += (s, e) => ThrowEvent("EventTargetInserted", e);
			Inserting += (s, e) => ThrowEvent("EventTargetInserting", e);
			Validating += (s, e) => ThrowEvent("EventTargetValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new EventTarget(this);
		}

		#endregion

	}

	#endregion

	#region Class: EventTarget_MarketingCampaignEventsProcess

	/// <exclude/>
	public class EventTarget_MarketingCampaignEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_LocalMessageEventsProcess<TEntity> where TEntity : EventTarget
	{

		public EventTarget_MarketingCampaignEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "EventTarget_MarketingCampaignEventsProcess";
			SchemaUId = new Guid("fb50e79e-ede8-4714-b6c8-c7cf4d3a9f87");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("fb50e79e-ede8-4714-b6c8-c7cf4d3a9f87");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		private ProcessFlowElement _eventTargetInsertedEventSubProcess;
		public ProcessFlowElement EventTargetInsertedEventSubProcess {
			get {
				return _eventTargetInsertedEventSubProcess ?? (_eventTargetInsertedEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventTargetInsertedEventSubProcess",
					SchemaElementUId = new Guid("6a1f2c07-dfd2-4c74-a39b-d8b35fe96deb"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _eventTargetInsertedMessage;
		public ProcessFlowElement EventTargetInsertedMessage {
			get {
				return _eventTargetInsertedMessage ?? (_eventTargetInsertedMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "EventTargetInsertedMessage",
					SchemaElementUId = new Guid("ec94274a-f9d2-4fe3-9753-0421a296381d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _eventTargetInsertedScriptTask;
		public ProcessScriptTask EventTargetInsertedScriptTask {
			get {
				return _eventTargetInsertedScriptTask ?? (_eventTargetInsertedScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "EventTargetInsertedScriptTask",
					SchemaElementUId = new Guid("42b83b69-f0ce-4434-949f-fb19470017dd"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = EventTargetInsertedScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _eventTargetDeletedEventSubProcess;
		public ProcessFlowElement EventTargetDeletedEventSubProcess {
			get {
				return _eventTargetDeletedEventSubProcess ?? (_eventTargetDeletedEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventTargetDeletedEventSubProcess",
					SchemaElementUId = new Guid("f93145e4-0b2f-4a91-a6f5-b46b056565b2"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _eventTargetDeletedMessage;
		public ProcessFlowElement EventTargetDeletedMessage {
			get {
				return _eventTargetDeletedMessage ?? (_eventTargetDeletedMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "EventTargetDeletedMessage",
					SchemaElementUId = new Guid("7dca9a7d-f485-4a16-9c0e-24383b35bd95"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _eventTargetDeletedScriptTask;
		public ProcessScriptTask EventTargetDeletedScriptTask {
			get {
				return _eventTargetDeletedScriptTask ?? (_eventTargetDeletedScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "EventTargetDeletedScriptTask",
					SchemaElementUId = new Guid("eb76c1ea-cf36-424a-8ce5-a78ea0658fd3"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = EventTargetDeletedScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcess3_480f29c3b9b14d548f9e17acbe56366c;
		public ProcessFlowElement EventSubProcess3_480f29c3b9b14d548f9e17acbe56366c {
			get {
				return _eventSubProcess3_480f29c3b9b14d548f9e17acbe56366c ?? (_eventSubProcess3_480f29c3b9b14d548f9e17acbe56366c = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess3_480f29c3b9b14d548f9e17acbe56366c",
					SchemaElementUId = new Guid("480f29c3-b9b1-4d54-8f9e-17acbe56366c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessage3_4beebb560e174209a9ddd22032cf9520;
		public ProcessFlowElement StartMessage3_4beebb560e174209a9ddd22032cf9520 {
			get {
				return _startMessage3_4beebb560e174209a9ddd22032cf9520 ?? (_startMessage3_4beebb560e174209a9ddd22032cf9520 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessage3_4beebb560e174209a9ddd22032cf9520",
					SchemaElementUId = new Guid("4beebb56-0e17-4209-a9dd-d22032cf9520"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTask3_dc8bd2905b244667b64d9b6d0f99bda3;
		public ProcessScriptTask ScriptTask3_dc8bd2905b244667b64d9b6d0f99bda3 {
			get {
				return _scriptTask3_dc8bd2905b244667b64d9b6d0f99bda3 ?? (_scriptTask3_dc8bd2905b244667b64d9b6d0f99bda3 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask3_dc8bd2905b244667b64d9b6d0f99bda3",
					SchemaElementUId = new Guid("dc8bd290-5b24-4667-b64d-9b6d0f99bda3"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask3_dc8bd2905b244667b64d9b6d0f99bda3Execute,
				});
			}
		}

		private LocalizableString _uniqueConstraintMessageText;
		public LocalizableString UniqueConstraintMessageText {
			get {
				return _uniqueConstraintMessageText ?? (_uniqueConstraintMessageText = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.UniqueConstraintMessageText.Value"));
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventTargetInsertedEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { EventTargetInsertedEventSubProcess };
			FlowElements[EventTargetInsertedMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { EventTargetInsertedMessage };
			FlowElements[EventTargetInsertedScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { EventTargetInsertedScriptTask };
			FlowElements[EventTargetDeletedEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { EventTargetDeletedEventSubProcess };
			FlowElements[EventTargetDeletedMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { EventTargetDeletedMessage };
			FlowElements[EventTargetDeletedScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { EventTargetDeletedScriptTask };
			FlowElements[EventSubProcess3_480f29c3b9b14d548f9e17acbe56366c.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess3_480f29c3b9b14d548f9e17acbe56366c };
			FlowElements[StartMessage3_4beebb560e174209a9ddd22032cf9520.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage3_4beebb560e174209a9ddd22032cf9520 };
			FlowElements[ScriptTask3_dc8bd2905b244667b64d9b6d0f99bda3.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask3_dc8bd2905b244667b64d9b6d0f99bda3 };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventTargetInsertedEventSubProcess":
						break;
					case "EventTargetInsertedMessage":
						e.Context.QueueTasks.Enqueue("EventTargetInsertedScriptTask");
						break;
					case "EventTargetInsertedScriptTask":
						break;
					case "EventTargetDeletedEventSubProcess":
						break;
					case "EventTargetDeletedMessage":
						e.Context.QueueTasks.Enqueue("EventTargetDeletedScriptTask");
						break;
					case "EventTargetDeletedScriptTask":
						break;
					case "EventSubProcess3_480f29c3b9b14d548f9e17acbe56366c":
						break;
					case "StartMessage3_4beebb560e174209a9ddd22032cf9520":
						e.Context.QueueTasks.Enqueue("ScriptTask3_dc8bd2905b244667b64d9b6d0f99bda3");
						break;
					case "ScriptTask3_dc8bd2905b244667b64d9b6d0f99bda3":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("EventTargetInsertedMessage");
			ActivatedEventElements.Add("EventTargetDeletedMessage");
			ActivatedEventElements.Add("StartMessage3_4beebb560e174209a9ddd22032cf9520");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "EventTargetInsertedEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "EventTargetInsertedMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "EventTargetInsertedMessage";
					result = EventTargetInsertedMessage.Execute(context);
					break;
				case "EventTargetInsertedScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "EventTargetInsertedScriptTask";
					result = EventTargetInsertedScriptTask.Execute(context, EventTargetInsertedScriptTaskExecute);
					break;
				case "EventTargetDeletedEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "EventTargetDeletedMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "EventTargetDeletedMessage";
					result = EventTargetDeletedMessage.Execute(context);
					break;
				case "EventTargetDeletedScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "EventTargetDeletedScriptTask";
					result = EventTargetDeletedScriptTask.Execute(context, EventTargetDeletedScriptTaskExecute);
					break;
				case "EventSubProcess3_480f29c3b9b14d548f9e17acbe56366c":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage3_4beebb560e174209a9ddd22032cf9520":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage3_4beebb560e174209a9ddd22032cf9520";
					result = StartMessage3_4beebb560e174209a9ddd22032cf9520.Execute(context);
					break;
				case "ScriptTask3_dc8bd2905b244667b64d9b6d0f99bda3":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask3_dc8bd2905b244667b64d9b6d0f99bda3";
					result = ScriptTask3_dc8bd2905b244667b64d9b6d0f99bda3.Execute(context, ScriptTask3_dc8bd2905b244667b64d9b6d0f99bda3Execute);
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

		public virtual bool EventTargetInsertedScriptTaskExecute(ProcessExecutingContext context) {
			UpdateEventRecipientCount(1);
			return true;
		}

		public virtual bool EventTargetDeletedScriptTaskExecute(ProcessExecutingContext context) {
			UpdateEventRecipientCount(-1);
			return true;
		}

		public virtual bool ScriptTask3_dc8bd2905b244667b64d9b6d0f99bda3Execute(ProcessExecutingContext context) {
			var conditions = new Dictionary<string, object>();
			conditions.Add("Event", Entity.EventId);
			conditions.Add("Contact", Entity.ContactId);
			if (Entity.ExistInDB(conditions)) {
				throw new SaveDuplicatedEntityException(UniqueConstraintMessageText.Value);
			}
			return true;
		}

		public virtual void UpdateEventRecipientCount(int incCount) {
			
						var eventId = Entity.GetTypedColumnValue<Guid>("EventId");
						if (eventId == Guid.Empty) {
							return;
						}
						var updateEvent = new Update(UserConnection, "Event")
							.Set("ModifiedOn", Column.Parameter(DateTime.UtcNow))
							.Set("ModifiedById", Column.Parameter(UserConnection.CurrentUser.ContactId))
							.Set("RecipientCount", QueryColumnExpression.Add(new QueryColumnExpression("RecipientCount"),
								Column.Parameter(incCount)))
							.Where("Id").IsEqual(Column.Parameter(eventId)) as Update;
						updateEvent.Execute();
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "EventTargetInserted":
							if (ActivatedEventElements.Contains("EventTargetInsertedMessage")) {
							context.QueueTasks.Enqueue("EventTargetInsertedMessage");
						}
						break;
					case "EventTargetDeleted":
							if (ActivatedEventElements.Contains("EventTargetDeletedMessage")) {
							context.QueueTasks.Enqueue("EventTargetDeletedMessage");
						}
						break;
					case "EventTargetInserting":
							if (ActivatedEventElements.Contains("StartMessage3_4beebb560e174209a9ddd22032cf9520")) {
							context.QueueTasks.Enqueue("StartMessage3_4beebb560e174209a9ddd22032cf9520");
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

	#region Class: EventTarget_MarketingCampaignEventsProcess

	/// <exclude/>
	public class EventTarget_MarketingCampaignEventsProcess : EventTarget_MarketingCampaignEventsProcess<EventTarget>
	{

		public EventTarget_MarketingCampaignEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: EventTargetEventsProcessSchema

	/// <exclude/>
	public class EventTargetEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public EventTargetEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public EventTargetEventsProcessSchema(EventTargetEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "EventTarget_MarketingCampaignEventsProcess";
			UId = new Guid("6f32160b-5031-48b7-90f4-da90a4d61b79");
			CreatedInPackageId = new Guid("b827f319-d8b8-41a8-9645-da32137f000d");
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
			ProcessSchemaLaneSet schemaLaneSet1 = CreateLaneSet1LaneSet();
			LaneSets.Add(schemaLaneSet1);
			ProcessSchemaLane schemaLane1 = CreateLane1Lane();
			schemaLaneSet1.Lanes.Add(schemaLane1);
			ProcessSchemaEventSubProcess eventtargetinsertedeventsubprocess = CreateEventTargetInsertedEventSubProcessEventSubProcess();
			FlowElements.Add(eventtargetinsertedeventsubprocess);
			ProcessSchemaEventSubProcess eventtargetdeletedeventsubprocess = CreateEventTargetDeletedEventSubProcessEventSubProcess();
			FlowElements.Add(eventtargetdeletedeventsubprocess);
			ProcessSchemaEventSubProcess eventsubprocess3_480f29c3b9b14d548f9e17acbe56366c = CreateEventSubProcess3_480f29c3b9b14d548f9e17acbe56366cEventSubProcess();
			FlowElements.Add(eventsubprocess3_480f29c3b9b14d548f9e17acbe56366c);
			ProcessSchemaStartMessageEvent eventtargetinsertedmessage = CreateEventTargetInsertedMessageStartMessageEvent();
			eventtargetinsertedeventsubprocess.FlowElements.Add(eventtargetinsertedmessage);
			ProcessSchemaScriptTask eventtargetinsertedscripttask = CreateEventTargetInsertedScriptTaskScriptTask();
			eventtargetinsertedeventsubprocess.FlowElements.Add(eventtargetinsertedscripttask);
			ProcessSchemaStartMessageEvent eventtargetdeletedmessage = CreateEventTargetDeletedMessageStartMessageEvent();
			eventtargetdeletedeventsubprocess.FlowElements.Add(eventtargetdeletedmessage);
			ProcessSchemaScriptTask eventtargetdeletedscripttask = CreateEventTargetDeletedScriptTaskScriptTask();
			eventtargetdeletedeventsubprocess.FlowElements.Add(eventtargetdeletedscripttask);
			ProcessSchemaStartMessageEvent startmessage3_4beebb560e174209a9ddd22032cf9520 = CreateStartMessage3_4beebb560e174209a9ddd22032cf9520StartMessageEvent();
			eventsubprocess3_480f29c3b9b14d548f9e17acbe56366c.FlowElements.Add(startmessage3_4beebb560e174209a9ddd22032cf9520);
			ProcessSchemaScriptTask scripttask3_dc8bd2905b244667b64d9b6d0f99bda3 = CreateScriptTask3_dc8bd2905b244667b64d9b6d0f99bda3ScriptTask();
			FlowElements.Add(scripttask3_dc8bd2905b244667b64d9b6d0f99bda3);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateSequenceFlow4_0076751194fb45be917782a60a7df61bSequenceFlow());
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateUniqueConstraintMessageTextLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateUniqueConstraintMessageTextLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("98e52ed4-c7e3-4e22-8e0b-f8a2c2efe13e"),
				Name = "UniqueConstraintMessageText",
				CreatedInPackageId = new Guid("c92d8fca-4a0d-4385-86d2-4f5717aa816e"),
				CreatedInSchemaUId = new Guid("6f32160b-5031-48b7-90f4-da90a4d61b79"),
				ModifiedInSchemaUId = new Guid("6f32160b-5031-48b7-90f4-da90a4d61b79")
			};
			return localizableString;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("851ac8a0-daf7-4f31-8e86-a7d1ca198c62"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("06c5e2cb-107e-4211-a5bd-01241dc3944b"),
				CreatedInSchemaUId = new Guid("6f32160b-5031-48b7-90f4-da90a4d61b79"),
				CurveCenterPosition = new Point(194, 92),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("6f32160b-5031-48b7-90f4-da90a4d61b79"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("ec94274a-f9d2-4fe3-9753-0421a296381d"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("42b83b69-f0ce-4434-949f-fb19470017dd"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("14de1fd5-7db2-4eac-acbe-0842cd8cda68"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("06c5e2cb-107e-4211-a5bd-01241dc3944b"),
				CreatedInSchemaUId = new Guid("6f32160b-5031-48b7-90f4-da90a4d61b79"),
				CurveCenterPosition = new Point(504, 94),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("6f32160b-5031-48b7-90f4-da90a4d61b79"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("7dca9a7d-f485-4a16-9c0e-24383b35bd95"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("eb76c1ea-cf36-424a-8ce5-a78ea0658fd3"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4_0076751194fb45be917782a60a7df61bSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4_0076751194fb45be917782a60a7df61b",
				UId = new Guid("00767511-94fb-45be-9177-82a60a7df61b"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("c92d8fca-4a0d-4385-86d2-4f5717aa816e"),
				CreatedInSchemaUId = new Guid("6f32160b-5031-48b7-90f4-da90a4d61b79"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("6f32160b-5031-48b7-90f4-da90a4d61b79"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("4beebb56-0e17-4209-a9dd-d22032cf9520"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("dc8bd290-5b24-4667-b64d-9b6d0f99bda3"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("31f074af-ff5d-4345-b740-cb1eb4548e94"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("06c5e2cb-107e-4211-a5bd-01241dc3944b"),
				CreatedInSchemaUId = new Guid("6f32160b-5031-48b7-90f4-da90a4d61b79"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("6f32160b-5031-48b7-90f4-da90a4d61b79"),
				Name = @"LaneSet1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(5, 5),
				Size = new Size(912, 177),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("b8899fe4-b055-4388-9fd3-5e6703d05acc"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("31f074af-ff5d-4345-b740-cb1eb4548e94"),
				CreatedInOwnerSchemaUId = new Guid("fb50e79e-ede8-4714-b6c8-c7cf4d3a9f87"),
				CreatedInPackageId = new Guid("06c5e2cb-107e-4211-a5bd-01241dc3944b"),
				CreatedInSchemaUId = new Guid("6f32160b-5031-48b7-90f4-da90a4d61b79"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("6f32160b-5031-48b7-90f4-da90a4d61b79"),
				Name = @"Lane1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(29, 0),
				Size = new Size(883, 177),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventTargetInsertedEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventTargetInsertedEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("6a1f2c07-dfd2-4c74-a39b-d8b35fe96deb"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b8899fe4-b055-4388-9fd3-5e6703d05acc"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("06c5e2cb-107e-4211-a5bd-01241dc3944b"),
				CreatedInSchemaUId = new Guid("6f32160b-5031-48b7-90f4-da90a4d61b79"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("6f32160b-5031-48b7-90f4-da90a4d61b79"),
				Name = @"EventTargetInsertedEventSubProcess",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(28, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(277, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventTargetInsertedEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateEventTargetInsertedMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("ec94274a-f9d2-4fe3-9753-0421a296381d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6a1f2c07-dfd2-4c74-a39b-d8b35fe96deb"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("06c5e2cb-107e-4211-a5bd-01241dc3944b"),
				CreatedInSchemaUId = new Guid("6f32160b-5031-48b7-90f4-da90a4d61b79"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"EventTargetInserted",
				ModifiedInSchemaUId = new Guid("6f32160b-5031-48b7-90f4-da90a4d61b79"),
				Name = @"EventTargetInsertedMessage",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(50, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateEventTargetInsertedScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("42b83b69-f0ce-4434-949f-fb19470017dd"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6a1f2c07-dfd2-4c74-a39b-d8b35fe96deb"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("06c5e2cb-107e-4211-a5bd-01241dc3944b"),
				CreatedInSchemaUId = new Guid("6f32160b-5031-48b7-90f4-da90a4d61b79"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("6f32160b-5031-48b7-90f4-da90a4d61b79"),
				Name = @"EventTargetInsertedScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(176, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,45,72,73,44,73,117,45,75,205,43,9,74,77,206,44,200,4,50,156,243,75,243,74,52,12,53,173,121,185,138,82,75,74,139,242,20,74,138,74,83,173,1,226,225,174,79,43,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventTargetDeletedEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventTargetDeletedEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("f93145e4-0b2f-4a91-a6f5-b46b056565b2"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b8899fe4-b055-4388-9fd3-5e6703d05acc"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("06c5e2cb-107e-4211-a5bd-01241dc3944b"),
				CreatedInSchemaUId = new Guid("6f32160b-5031-48b7-90f4-da90a4d61b79"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("6f32160b-5031-48b7-90f4-da90a4d61b79"),
				Name = @"EventTargetDeletedEventSubProcess",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(315, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(315, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventTargetDeletedEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateEventTargetDeletedMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("7dca9a7d-f485-4a16-9c0e-24383b35bd95"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f93145e4-0b2f-4a91-a6f5-b46b056565b2"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("06c5e2cb-107e-4211-a5bd-01241dc3944b"),
				CreatedInSchemaUId = new Guid("6f32160b-5031-48b7-90f4-da90a4d61b79"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"EventTargetDeleted",
				ModifiedInSchemaUId = new Guid("6f32160b-5031-48b7-90f4-da90a4d61b79"),
				Name = @"EventTargetDeletedMessage",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(57, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateEventTargetDeletedScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("eb76c1ea-cf36-424a-8ce5-a78ea0658fd3"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f93145e4-0b2f-4a91-a6f5-b46b056565b2"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("06c5e2cb-107e-4211-a5bd-01241dc3944b"),
				CreatedInSchemaUId = new Guid("6f32160b-5031-48b7-90f4-da90a4d61b79"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("6f32160b-5031-48b7-90f4-da90a4d61b79"),
				Name = @"EventTargetDeletedScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(211, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,45,72,73,44,73,117,45,75,205,43,9,74,77,206,44,200,4,50,156,243,75,243,74,52,116,13,53,173,121,185,138,82,75,74,139,242,20,74,138,74,83,173,1,135,212,84,250,44,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess3_480f29c3b9b14d548f9e17acbe56366cEventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess3_480f29c3b9b14d548f9e17acbe56366c = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("480f29c3-b9b1-4d54-8f9e-17acbe56366c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b8899fe4-b055-4388-9fd3-5e6703d05acc"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("c92d8fca-4a0d-4385-86d2-4f5717aa816e"),
				CreatedInSchemaUId = new Guid("6f32160b-5031-48b7-90f4-da90a4d61b79"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("6f32160b-5031-48b7-90f4-da90a4d61b79"),
				Name = @"EventSubProcess3_480f29c3b9b14d548f9e17acbe56366c",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(25, 177),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(282, 183),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess3_480f29c3b9b14d548f9e17acbe56366c;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage3_4beebb560e174209a9ddd22032cf9520StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("4beebb56-0e17-4209-a9dd-d22032cf9520"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("480f29c3-b9b1-4d54-8f9e-17acbe56366c"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("c92d8fca-4a0d-4385-86d2-4f5717aa816e"),
				CreatedInSchemaUId = new Guid("6f32160b-5031-48b7-90f4-da90a4d61b79"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"EventTargetInserting",
				ModifiedInSchemaUId = new Guid("6f32160b-5031-48b7-90f4-da90a4d61b79"),
				Name = @"StartMessage3_4beebb560e174209a9ddd22032cf9520",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(42, 78),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask3_dc8bd2905b244667b64d9b6d0f99bda3ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("dc8bd290-5b24-4667-b64d-9b6d0f99bda3"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b8899fe4-b055-4388-9fd3-5e6703d05acc"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("c92d8fca-4a0d-4385-86d2-4f5717aa816e"),
				CreatedInSchemaUId = new Guid("6f32160b-5031-48b7-90f4-da90a4d61b79"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("6f32160b-5031-48b7-90f4-da90a4d61b79"),
				Name = @"ScriptTask3_dc8bd2905b244667b64d9b6d0f99bda3",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(204, 241),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,142,187,14,194,48,12,69,103,250,21,22,83,42,161,254,64,1,9,104,135,14,76,60,246,144,24,48,66,14,36,78,41,66,252,59,165,128,96,96,188,214,185,199,183,214,30,140,99,75,66,142,3,140,128,241,2,5,153,103,212,254,58,12,226,137,119,3,112,155,3,26,25,171,52,79,190,120,54,177,86,245,203,26,89,250,3,40,89,72,174,89,23,43,251,7,156,57,22,109,126,208,247,161,131,105,11,234,99,104,40,72,197,197,84,125,13,105,10,183,164,39,123,239,46,221,196,133,174,177,136,167,35,25,45,104,95,197,178,49,120,122,210,106,197,116,142,216,234,219,249,154,88,230,24,130,222,225,18,27,201,214,250,24,177,125,120,79,60,74,244,12,226,35,230,15,129,31,204,57,8,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateUpdateEventRecipientCountMethod());
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("fb7b81ba-7c3c-45a5-ae9e-c6c03dceb812"),
				Name = "Terrasoft.UI.WebControls.Controls",
				Alias = "",
				CreatedInPackageId = new Guid("b827f319-d8b8-41a8-9645-da32137f000d")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("cde525cf-d220-4d2a-b963-e55254c639fc"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("b827f319-d8b8-41a8-9645-da32137f000d")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5c9c82c6-ba6d-4a57-9a14-87fe8faa4ebb"),
				Name = "Terrasoft.Core.DB",
				Alias = "",
				CreatedInPackageId = new Guid("b827f319-d8b8-41a8-9645-da32137f000d")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7821de68-c82b-4917-a6cd-add2adfbe400"),
				Name = "Terrasoft.Common",
				Alias = "",
				CreatedInPackageId = new Guid("b827f319-d8b8-41a8-9645-da32137f000d")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d67de76f-9cbc-4bfc-babb-6f65cb89b973"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("b827f319-d8b8-41a8-9645-da32137f000d")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("74160d3b-65e3-4694-b554-089f2d980e54"),
				Name = "Newtonsoft.Json",
				Alias = "",
				CreatedInPackageId = new Guid("b827f319-d8b8-41a8-9645-da32137f000d")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e401300a-9f16-40c2-9788-cf310ae9d1c5"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("b827f319-d8b8-41a8-9645-da32137f000d")
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
			Usings.Add(new SchemaUsing() {
				UId = new Guid("f0a023ad-ad2b-408e-90b9-273a6b4708c2"),
				Name = "Terrasoft.Configuration.MarketingCampaign",
				Alias = "",
				CreatedInPackageId = new Guid("c92d8fca-4a0d-4385-86d2-4f5717aa816e")
			});
		}

		protected virtual SchemaMethod CreateUpdateEventRecipientCountMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("fd608b67-6a0c-44e7-8ad9-49036a716c03"),
				Name = "UpdateEventRecipientCount",
				CreatedInSchemaUId = new Guid("6f32160b-5031-48b7-90f4-da90a4d61b79"),
				CreatedInPackageId = new Guid("06c5e2cb-107e-4211-a5bd-01241dc3944b"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("6585f167-cfcf-4dff-b62e-2115338f502c"),
				Name = "incCount",
				CreatedInSchemaUId = new Guid("6f32160b-5031-48b7-90f4-da90a4d61b79"),
				ModifiedInSchemaUId = new Guid("6f32160b-5031-48b7-90f4-da90a4d61b79"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "int",
				CreatedInPackageId = new Guid("06c5e2cb-107e-4211-a5bd-01241dc3944b")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,81,219,106,195,32,24,190,206,32,239,32,94,41,4,95,160,235,96,203,164,244,98,231,118,187,22,253,203,132,68,51,163,109,195,216,187,79,99,87,86,146,219,223,239,232,87,94,21,69,177,23,14,193,30,140,95,43,180,68,220,120,237,7,182,2,191,25,58,80,181,109,66,107,222,69,19,224,122,21,180,186,33,152,103,44,166,139,50,209,245,14,145,51,125,137,18,136,241,182,243,3,69,223,35,160,112,224,131,51,25,253,83,254,89,134,78,9,15,163,88,180,53,112,64,219,241,66,182,61,184,218,26,3,210,107,107,42,148,13,49,205,98,236,13,60,193,15,86,233,157,6,245,100,112,133,114,70,246,44,156,104,193,131,35,247,81,102,163,91,96,91,47,31,237,129,206,82,239,134,216,97,134,124,105,207,234,224,92,180,79,87,22,207,94,200,88,244,82,241,21,164,238,116,4,213,54,196,160,21,122,9,224,134,44,204,143,157,131,190,79,74,183,74,145,84,115,246,117,162,66,171,108,81,76,2,106,35,71,8,61,167,248,248,4,7,4,167,77,216,186,231,95,65,52,100,66,59,109,68,41,18,253,233,171,243,36,255,134,96,252,8,50,196,13,232,226,23,206,71,142,91,27,2,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new EventTargetEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("6f32160b-5031-48b7-90f4-da90a4d61b79"));
		}

		#endregion

	}

	#endregion


	#region Class: EventTargetEventsProcess

	/// <exclude/>
	public class EventTargetEventsProcess : EventTarget_MarketingCampaignEventsProcess
	{

		public EventTargetEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

