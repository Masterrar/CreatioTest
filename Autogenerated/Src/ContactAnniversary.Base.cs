﻿namespace Terrasoft.Configuration
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

	#region Class: ContactAnniversarySchema

	/// <exclude/>
	public class ContactAnniversarySchema : Terrasoft.Configuration.BaseAnniversarySchema
	{

		#region Constructors: Public

		public ContactAnniversarySchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public ContactAnniversarySchema(ContactAnniversarySchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public ContactAnniversarySchema(ContactAnniversarySchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("fa36e9a5-c2fc-47b2-b5cb-2b58ef61d4e6");
			RealUId = new Guid("fa36e9a5-c2fc-47b2-b5cb-2b58ef61d4e6");
			Name = "ContactAnniversary";
			ParentSchemaUId = new Guid("c3d34c7a-3acf-4394-a9fe-50e48f92ca9f");
			ExtendParent = false;
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("e172fdfc-48ce-4a83-9e40-0c93bd26188f")) == null) {
				Columns.Add(CreateContactColumn());
			}
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.DefValue = new EntitySchemaColumnDef() {
				Source = EntitySchemaColumnDefSource.SystemValue,
				ValueSource = SystemValueManager.GetInstanceByName(@"CurrentDateTime")
			};
			column.ModifiedInSchemaUId = new Guid("fa36e9a5-c2fc-47b2-b5cb-2b58ef61d4e6");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.DefValue = new EntitySchemaColumnDef() {
				Source = EntitySchemaColumnDefSource.SystemValue,
				ValueSource = SystemValueManager.GetInstanceByName(@"CurrentUserContact")
			};
			column.ModifiedInSchemaUId = new Guid("fa36e9a5-c2fc-47b2-b5cb-2b58ef61d4e6");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.ModifiedInSchemaUId = new Guid("fa36e9a5-c2fc-47b2-b5cb-2b58ef61d4e6");
			return column;
		}

		protected virtual EntitySchemaColumn CreateContactColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("e172fdfc-48ce-4a83-9e40-0c93bd26188f"),
				Name = @"Contact",
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("fa36e9a5-c2fc-47b2-b5cb-2b58ef61d4e6"),
				ModifiedInSchemaUId = new Guid("fa36e9a5-c2fc-47b2-b5cb-2b58ef61d4e6"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateContactAnniversaryEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateContactAnniversaryEventsProcessSchema() {
			var schema = new ContactAnniversaryEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new ContactAnniversary(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new ContactAnniversary_BaseEventsProcess(userConnection);
		}

		public override object Clone() {
			return new ContactAnniversarySchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new ContactAnniversarySchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("fa36e9a5-c2fc-47b2-b5cb-2b58ef61d4e6"));
		}

		#endregion

	}

	#endregion

	#region Class: ContactAnniversary

	/// <summary>
	/// Noteworthy event of contact.
	/// </summary>
	public class ContactAnniversary : Terrasoft.Configuration.BaseAnniversary
	{

		#region Constructors: Public

		public ContactAnniversary(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "ContactAnniversary";
		}

		public ContactAnniversary(ContactAnniversary source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

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

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new ContactAnniversary_BaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("ContactAnniversaryDeleted", e);
			Deleting += (s, e) => ThrowEvent("ContactAnniversaryDeleting", e);
			Inserting += (s, e) => ThrowEvent("ContactAnniversaryInserting", e);
			Saved += (s, e) => ThrowEvent("ContactAnniversarySaved", e);
			Saving += (s, e) => ThrowEvent("ContactAnniversarySaving", e);
			Validating += (s, e) => ThrowEvent("ContactAnniversaryValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new ContactAnniversary(this);
		}

		#endregion

	}

	#endregion

	#region Class: ContactAnniversary_BaseEventsProcess

	/// <exclude/>
	public class ContactAnniversary_BaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseAnniversary_BaseEventsProcess<TEntity> where TEntity : ContactAnniversary
	{

		#region Class: SynchronizeContactDataFlowElement

		/// <exclude/>
		public class SynchronizeContactDataFlowElement : SynchronizeParentEntityData
		{

			public SynchronizeContactDataFlowElement(UserConnection userConnection, ContactAnniversary_BaseEventsProcess<TEntity> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "SynchronizeContactData";
				IsLogging = false;
				SchemaElementUId = new Guid("3652ed05-819a-4102-917d-dace3ab4d495");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		public ContactAnniversary_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ContactAnniversary_BaseEventsProcess";
			SchemaUId = new Guid("fa36e9a5-c2fc-47b2-b5cb-2b58ef61d4e6");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("fa36e9a5-c2fc-47b2-b5cb-2b58ef61d4e6");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		public virtual Guid TypeOldValue {
			get;
			set;
		}

		public virtual bool IsCurrentContactBirthday {
			get;
			set;
		}

		public virtual bool IsBirthDateChanged {
			get;
			set;
		}

		private ProcessFlowElement _eventSubProcess1;
		public ProcessFlowElement EventSubProcess1 {
			get {
				return _eventSubProcess1 ?? (_eventSubProcess1 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess1",
					SchemaElementUId = new Guid("424d3fcf-eb2b-44b3-8555-5c0ac3e2a30f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _contactAnniversarySaved;
		public ProcessFlowElement ContactAnniversarySaved {
			get {
				return _contactAnniversarySaved ?? (_contactAnniversarySaved = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ContactAnniversarySaved",
					SchemaElementUId = new Guid("440db6c0-ff9f-47ed-9c62-67e55f6e6a79"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptContactAnniversarySaved;
		public ProcessScriptTask ScriptContactAnniversarySaved {
			get {
				return _scriptContactAnniversarySaved ?? (_scriptContactAnniversarySaved = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptContactAnniversarySaved",
					SchemaElementUId = new Guid("eeab9c46-1fe0-4dc4-ad9c-093214604655"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptContactAnniversarySavedExecute,
				});
			}
		}

		private SynchronizeContactDataFlowElement _synchronizeContactData;
		public SynchronizeContactDataFlowElement SynchronizeContactData {
			get {
				return _synchronizeContactData ?? (_synchronizeContactData = new SynchronizeContactDataFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessScriptTask _scriptTask2;
		public ProcessScriptTask ScriptTask2 {
			get {
				return _scriptTask2 ?? (_scriptTask2 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask2",
					SchemaElementUId = new Guid("daaed5bf-853f-4420-952f-6cfaa85c2d3a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask2Execute,
				});
			}
		}

		private ProcessScriptTask _updateContact;
		public ProcessScriptTask UpdateContact {
			get {
				return _updateContact ?? (_updateContact = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "UpdateContact",
					SchemaElementUId = new Guid("d4331a0d-ad4b-4ebf-975e-9c42e00d79e5"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = UpdateContactExecute,
				});
			}
		}

		private ProcessScriptTask _updateRemindings;
		public ProcessScriptTask UpdateRemindings {
			get {
				return _updateRemindings ?? (_updateRemindings = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "UpdateRemindings",
					SchemaElementUId = new Guid("ee0b8d22-9347-4315-98fe-7c8d0025dd71"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = UpdateRemindingsExecute,
				});
			}
		}

		private ProcessFlowElement _subProcess1;
		public ProcessFlowElement SubProcess1 {
			get {
				return _subProcess1 ?? (_subProcess1 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "SubProcess1",
					SchemaElementUId = new Guid("fe0343c3-0156-43a3-8ef5-0272760bc31b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _contactAnniversaryDeleted;
		public ProcessFlowElement ContactAnniversaryDeleted {
			get {
				return _contactAnniversaryDeleted ?? (_contactAnniversaryDeleted = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ContactAnniversaryDeleted",
					SchemaElementUId = new Guid("d5967a6b-4d60-4373-a28e-bb505b05529f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptContactAnniversaryDeleted;
		public ProcessScriptTask ScriptContactAnniversaryDeleted {
			get {
				return _scriptContactAnniversaryDeleted ?? (_scriptContactAnniversaryDeleted = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptContactAnniversaryDeleted",
					SchemaElementUId = new Guid("83931b88-8f3d-460e-810d-2b856fdd63cd"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptContactAnniversaryDeletedExecute,
				});
			}
		}

		private ProcessScriptTask _scriptTask1;
		public ProcessScriptTask ScriptTask1 {
			get {
				return _scriptTask1 ?? (_scriptTask1 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask1",
					SchemaElementUId = new Guid("5a7868e9-c996-46aa-9c4a-a3c9a56aa185"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask1Execute,
				});
			}
		}

		private ProcessExclusiveGateway _exclusiveGateway1;
		public ProcessExclusiveGateway ExclusiveGateway1 {
			get {
				return _exclusiveGateway1 ?? (_exclusiveGateway1 = new ProcessExclusiveGateway() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaExclusiveGateway",
					Name = "ExclusiveGateway1",
					SchemaElementUId = new Guid("5775ae89-a558-4cdf-8179-58c1cef66760"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Question = new LocalizableString(Storage, Schema.GetResourceManagerName(),
					"EventsProcessSchema.BaseElements.ExclusiveGateway1.Question"),
						IsDecisionRequired = false,
						BranchingMode = GatewayBranchingMode.Auto,
						DecisionMode = GetewayDecisionSelectionMode.Single,
						ShowUserDecisionDialog = (processId, gatewayName) => {},
				});
			}
		}

		private ProcessFlowElement _subProcess2;
		public ProcessFlowElement SubProcess2 {
			get {
				return _subProcess2 ?? (_subProcess2 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "SubProcess2",
					SchemaElementUId = new Guid("fa6975d5-6872-4dac-bf64-d62644f1dbaf"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _contactAnniversaryDeleting;
		public ProcessFlowElement ContactAnniversaryDeleting {
			get {
				return _contactAnniversaryDeleting ?? (_contactAnniversaryDeleting = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ContactAnniversaryDeleting",
					SchemaElementUId = new Guid("ff12752a-dbbb-4bf8-bd12-3270401a4070"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptContactAnniversaryDeleting;
		public ProcessScriptTask ScriptContactAnniversaryDeleting {
			get {
				return _scriptContactAnniversaryDeleting ?? (_scriptContactAnniversaryDeleting = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptContactAnniversaryDeleting",
					SchemaElementUId = new Guid("645b0ac9-19cc-4b92-96b5-92451ca11b5b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptContactAnniversaryDeletingExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcess3_128f81454a2b4a1cb112cdec8d554bc1;
		public ProcessFlowElement EventSubProcess3_128f81454a2b4a1cb112cdec8d554bc1 {
			get {
				return _eventSubProcess3_128f81454a2b4a1cb112cdec8d554bc1 ?? (_eventSubProcess3_128f81454a2b4a1cb112cdec8d554bc1 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess3_128f81454a2b4a1cb112cdec8d554bc1",
					SchemaElementUId = new Guid("128f8145-4a2b-4a1c-b112-cdec8d554bc1"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _contactAnniversarySaving_Base;
		public ProcessFlowElement ContactAnniversarySaving_Base {
			get {
				return _contactAnniversarySaving_Base ?? (_contactAnniversarySaving_Base = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ContactAnniversarySaving_Base",
					SchemaElementUId = new Guid("12777a63-1ce5-4a98-a8c9-204c614985d9"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _initValues;
		public ProcessScriptTask InitValues {
			get {
				return _initValues ?? (_initValues = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "InitValues",
					SchemaElementUId = new Guid("a58f9919-d1a3-4dd9-9cf4-de80a6f1afe6"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = InitValuesExecute,
				});
			}
		}

		private ProcessConditionalFlow _sequenceFlow16338;
		public ProcessConditionalFlow SequenceFlow16338 {
			get {
				return _sequenceFlow16338 ?? (_sequenceFlow16338 = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "SequenceFlow16338",
					SchemaElementUId = new Guid("68b4dfb4-c8c0-40c2-97e1-049c2664f8d6"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess1.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess1 };
			FlowElements[ContactAnniversarySaved.SchemaElementUId] = new Collection<ProcessFlowElement> { ContactAnniversarySaved };
			FlowElements[ScriptContactAnniversarySaved.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptContactAnniversarySaved };
			FlowElements[SynchronizeContactData.SchemaElementUId] = new Collection<ProcessFlowElement> { SynchronizeContactData };
			FlowElements[ScriptTask2.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask2 };
			FlowElements[UpdateContact.SchemaElementUId] = new Collection<ProcessFlowElement> { UpdateContact };
			FlowElements[UpdateRemindings.SchemaElementUId] = new Collection<ProcessFlowElement> { UpdateRemindings };
			FlowElements[SubProcess1.SchemaElementUId] = new Collection<ProcessFlowElement> { SubProcess1 };
			FlowElements[ContactAnniversaryDeleted.SchemaElementUId] = new Collection<ProcessFlowElement> { ContactAnniversaryDeleted };
			FlowElements[ScriptContactAnniversaryDeleted.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptContactAnniversaryDeleted };
			FlowElements[ScriptTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask1 };
			FlowElements[ExclusiveGateway1.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway1 };
			FlowElements[SubProcess2.SchemaElementUId] = new Collection<ProcessFlowElement> { SubProcess2 };
			FlowElements[ContactAnniversaryDeleting.SchemaElementUId] = new Collection<ProcessFlowElement> { ContactAnniversaryDeleting };
			FlowElements[ScriptContactAnniversaryDeleting.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptContactAnniversaryDeleting };
			FlowElements[EventSubProcess3_128f81454a2b4a1cb112cdec8d554bc1.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess3_128f81454a2b4a1cb112cdec8d554bc1 };
			FlowElements[ContactAnniversarySaving_Base.SchemaElementUId] = new Collection<ProcessFlowElement> { ContactAnniversarySaving_Base };
			FlowElements[InitValues.SchemaElementUId] = new Collection<ProcessFlowElement> { InitValues };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess1":
						break;
					case "ContactAnniversarySaved":
						e.Context.QueueTasks.Enqueue("ScriptContactAnniversarySaved");
						break;
					case "ScriptContactAnniversarySaved":
						e.Context.QueueTasks.Enqueue("ScriptTask2");
						break;
					case "SynchronizeContactData":
							e.Context.QueueTasks.Enqueue("UpdateContact");
						break;
					case "ScriptTask2":
						e.Context.QueueTasks.Enqueue("SynchronizeContactData");
						break;
					case "UpdateContact":
						e.Context.QueueTasks.Enqueue("UpdateRemindings");
						break;
					case "UpdateRemindings":
						break;
					case "SubProcess1":
						break;
					case "ContactAnniversaryDeleted":
						e.Context.QueueTasks.Enqueue("ExclusiveGateway1");
						break;
					case "ScriptContactAnniversaryDeleted":
						break;
					case "ScriptTask1":
						e.Context.QueueTasks.Enqueue("ScriptTask2");
						break;
					case "ExclusiveGateway1":
							e.Context.QueueTasks.Enqueue("ScriptContactAnniversaryDeleted");
						if (SequenceFlow16338ExpressionExecute()) {
							e.Context.QueueTasks.Enqueue("ScriptTask1");
							break;
						}
						break;
					case "SubProcess2":
						break;
					case "ContactAnniversaryDeleting":
						e.Context.QueueTasks.Enqueue("ScriptContactAnniversaryDeleting");
						break;
					case "ScriptContactAnniversaryDeleting":
						break;
					case "EventSubProcess3_128f81454a2b4a1cb112cdec8d554bc1":
						break;
					case "ContactAnniversarySaving_Base":
						e.Context.QueueTasks.Enqueue("InitValues");
						break;
					case "InitValues":
						break;
			}
			ProcessQueue(e.Context);
		}

		private bool SequenceFlow16338ExpressionExecute() {
			return Convert.ToBoolean(IsCurrentContactBirthday);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("ContactAnniversarySaved");
			ActivatedEventElements.Add("ContactAnniversaryDeleted");
			ActivatedEventElements.Add("ContactAnniversaryDeleting");
			ActivatedEventElements.Add("ContactAnniversarySaving_Base");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "EventSubProcess1":
					context.QueueTasks.Dequeue();
					break;
				case "ContactAnniversarySaved":
					context.QueueTasks.Dequeue();
					context.SenderName = "ContactAnniversarySaved";
					result = ContactAnniversarySaved.Execute(context);
					break;
				case "ScriptContactAnniversarySaved":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptContactAnniversarySaved";
					result = ScriptContactAnniversarySaved.Execute(context, ScriptContactAnniversarySavedExecute);
					break;
				case "SynchronizeContactData":
					context.QueueTasks.Dequeue();
					context.SenderName = "SynchronizeContactData";
					result = SynchronizeContactData.Execute(context);
					break;
				case "ScriptTask2":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask2";
					result = ScriptTask2.Execute(context, ScriptTask2Execute);
					break;
				case "UpdateContact":
					context.QueueTasks.Dequeue();
					context.SenderName = "UpdateContact";
					result = UpdateContact.Execute(context, UpdateContactExecute);
					break;
				case "UpdateRemindings":
					context.QueueTasks.Dequeue();
					context.SenderName = "UpdateRemindings";
					result = UpdateRemindings.Execute(context, UpdateRemindingsExecute);
					break;
				case "SubProcess1":
					context.QueueTasks.Dequeue();
					break;
				case "ContactAnniversaryDeleted":
					context.QueueTasks.Dequeue();
					context.SenderName = "ContactAnniversaryDeleted";
					result = ContactAnniversaryDeleted.Execute(context);
					break;
				case "ScriptContactAnniversaryDeleted":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptContactAnniversaryDeleted";
					result = ScriptContactAnniversaryDeleted.Execute(context, ScriptContactAnniversaryDeletedExecute);
					break;
				case "ScriptTask1":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask1";
					result = ScriptTask1.Execute(context, ScriptTask1Execute);
					break;
				case "ExclusiveGateway1":
					context.QueueTasks.Dequeue();
					context.SenderName = "ExclusiveGateway1";
					result = ExclusiveGateway1.Execute(context);
					break;
				case "SubProcess2":
					context.QueueTasks.Dequeue();
					break;
				case "ContactAnniversaryDeleting":
					context.QueueTasks.Dequeue();
					context.SenderName = "ContactAnniversaryDeleting";
					result = ContactAnniversaryDeleting.Execute(context);
					break;
				case "ScriptContactAnniversaryDeleting":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptContactAnniversaryDeleting";
					result = ScriptContactAnniversaryDeleting.Execute(context, ScriptContactAnniversaryDeletingExecute);
					break;
				case "EventSubProcess3_128f81454a2b4a1cb112cdec8d554bc1":
					context.QueueTasks.Dequeue();
					break;
				case "ContactAnniversarySaving_Base":
					context.QueueTasks.Dequeue();
					context.SenderName = "ContactAnniversarySaving_Base";
					result = ContactAnniversarySaving_Base.Execute(context);
					break;
				case "InitValues":
					context.QueueTasks.Dequeue();
					context.SenderName = "InitValues";
					result = InitValues.Execute(context, InitValuesExecute);
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

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			switch (reader.CurrentName) {
				case "IsBirthDateChanged":
					IsBirthDateChanged = reader.GetValue<System.Boolean>();
				break;
				case "IsCurrentContactBirthday":
					IsCurrentContactBirthday = reader.GetValue<System.Boolean>();
				break;
				case "TypeOldValue":
					TypeOldValue = reader.GetValue<System.Guid>();
				break;
			}
		}

		#endregion

		#region Methods: Public

		public virtual bool ScriptContactAnniversarySavedExecute(ProcessExecutingContext context) {
			SynchronizeContactData.DeleteChild = false;
			return true;
		}

		public virtual bool ScriptTask2Execute(ProcessExecutingContext context) {
			var conditionMappingColumns = new System.Collections.Generic.Dictionary<
				Guid, System.Collections.Generic.Dictionary<Guid, object>>();
			var mappingColumns = new System.Collections.Generic.Dictionary<Guid, Guid>();
			var defaultValues = new System.Collections.Generic.Dictionary<Guid, object>();
			
			//--------------- Entity Schema Columns UId -------------------------------
			var contactAnniversaryAnniversaryTypeColumnUId = new Guid("93c29696-307b-45f3-a799-b51670bdfcb6");
			var contactAnniversaryDateColumnUId = new Guid("ce66aa7d-8443-4b5a-a7fe-a90ae4e809de");
			var birthdayId = new Guid("173d56d2-fdca-df11-9b2a-001d60e938c6");
			var contactBirthDateColumnUId = new Guid("3f08db69-6d2f-4b1c-87a4-acddc6c3b9d6");
			
			var entity = context.Process.GetPropertyValue("Entity") as Terrasoft.Core.Entities.Entity;
			var entitySchema = entity.Schema;
			
			var userConnection = context.Process.UserConnection;
			var entitySchemaManager = context.Process.SchemaManager as Terrasoft.Core.Entities.EntitySchemaManager;
			var entitySchemaQuery = new EntitySchemaQuery(entitySchemaManager, entity.Schema.Name);
			var createdOnColumn = entitySchemaQuery.AddColumn("CreatedOn");
			entitySchemaQuery.AddAllSchemaColumns();
			createdOnColumn.OrderByAsc();
			entitySchemaQuery.Filters.Add(
				entitySchemaQuery.CreateFilterWithParameters(FilterComparisonType.Equal, 
					"Contact", entity.GetTypedColumnValue<Guid>("ContactId")));
			entitySchemaQuery.Filters.Add(
				entitySchemaQuery.CreateFilterWithParameters(FilterComparisonType.Equal, 
					"AnniversaryType", birthdayId));
			var aniversaryCollection = entitySchemaQuery.GetEntityCollection(userConnection);
			
			if (aniversaryCollection.Count > 0) {
				Guid id = aniversaryCollection[0].GetTypedColumnValue<Guid>("Id");
				if (id == entity.GetTypedColumnValue<Guid>("Id")) {
					//--------------- Condition Mapping Columns ----------------
					var primaryAddressCondition = new System.Collections.Generic.Dictionary<Guid, object>();
					primaryAddressCondition.Add(contactAnniversaryAnniversaryTypeColumnUId, birthdayId);
					conditionMappingColumns.Add(contactBirthDateColumnUId, primaryAddressCondition);
			
					//--------------- Mapping Columns ----------------
					mappingColumns.Add(contactBirthDateColumnUId, contactAnniversaryDateColumnUId);
				}
			} else if (IsCurrentContactBirthday) {
				var primaryAddressCondition = new System.Collections.Generic.Dictionary<Guid, object>();
				primaryAddressCondition.Add(contactAnniversaryAnniversaryTypeColumnUId, birthdayId);
				conditionMappingColumns.Add(contactBirthDateColumnUId, primaryAddressCondition);
				
				mappingColumns.Add(contactBirthDateColumnUId, contactAnniversaryDateColumnUId);
			}
			
			SynchronizeContactData.ParentEntityColumnUId = entitySchema.Columns.GetByName("Contact").UId;
			SynchronizeContactData.ConditionMappingColumns = conditionMappingColumns;
			SynchronizeContactData.MappingColumns = mappingColumns;
			SynchronizeContactData.DefaultValues = defaultValues;
			return true;
		}

		public virtual bool UpdateContactExecute(ProcessExecutingContext context) {
			UpdateContactModifedOn();
			return true;
		}

		public virtual bool UpdateRemindingsExecute(ProcessExecutingContext context) {
			UpdateRemindingsExecute();
			return true;
		}

		public virtual bool ScriptContactAnniversaryDeletedExecute(ProcessExecutingContext context) {
			return true;
			
			
		}

		public virtual bool ScriptTask1Execute(ProcessExecutingContext context) {
			Guid id = Entity.GetTypedColumnValue<Guid>("ContactId");
			Guid schemaUId = Entity.Contact.Schema.UId;
			Entity contactEntity = Entity.Contact.Schema.CreateEntity(UserConnection);
			contactEntity.FetchFromDB(id);
			BaseAnniversaryReminding remindingsGenerator = GetRemindingsGenerator(contactEntity);
			remindingsGenerator.DeleteRecordRemindings(schemaUId);
			SynchronizeContactData.DeleteChild = true;
			return true;
		}

		public virtual bool ScriptContactAnniversaryDeletingExecute(ProcessExecutingContext context) {
			IsCurrentContactBirthday = false;
			if (Entity.AnniversaryTypeId != new Guid("173D56D2-FDCA-DF11-9B2A-001D60E938C6")) {
				return true;
			}
			TypeOldValue= Entity.GetTypedOldColumnValue<Guid>(Entity.Schema.Columns.GetByName("AnniversaryType").ColumnValueName);
			var entitySchemaManager = UserConnection.GetSchemaManager("EntitySchemaManager") as EntitySchemaManager;
			var entitySchemaQuery = new EntitySchemaQuery(entitySchemaManager, "Contact");
			entitySchemaQuery.AddColumn("Id");
			entitySchemaQuery.Filters.Add(entitySchemaQuery.CreateFilterWithParameters(FilterComparisonType.Equal,
				"BirthDate", Entity.Date));
			entitySchemaQuery.Filters.Add(entitySchemaQuery.CreateFilterWithParameters(FilterComparisonType.Equal,
				"Id", Entity.ContactId));
			var entities = entitySchemaQuery.GetEntityCollection(UserConnection);
			if (entities.Count == 1) {
				entitySchemaQuery = new EntitySchemaQuery(entitySchemaManager, "ContactAnniversary");
				entitySchemaQuery.AddColumn("Id");
				entitySchemaQuery.Filters.Add(entitySchemaQuery.CreateFilterWithParameters(FilterComparisonType.Equal,
					"AnniversaryType", "173D56D2-FDCA-DF11-9B2A-001D60E938C6"));
				entitySchemaQuery.Filters.Add(entitySchemaQuery.CreateFilterWithParameters(FilterComparisonType.Equal,
					"Contact", Entity.ContactId));
				entitySchemaQuery.Filters.Add(entitySchemaQuery.CreateFilterWithParameters(FilterComparisonType.Equal,
					"Date", Entity.Date));
				entities = entitySchemaQuery.GetEntityCollection(UserConnection);
				if (entities.Count == 1) {
					IsCurrentContactBirthday = true;
				}
			}
			return true;
		}

		public virtual bool InitValuesExecute(ProcessExecutingContext context) {
			IsBirthDateChanged = Entity.GetChangedColumnValues().Any(col => col.Name == "Date");
			return true;
		}

		public virtual void UpdateContactModifedOn() {
			var contactId = Entity.GetTypedColumnValue<Guid>("ContactId");
			var instance = UserConnection.EntitySchemaManager.GetInstanceByName("Contact");
			var entity = instance.CreateEntity(UserConnection);
			if (entity.FetchFromDB(contactId)) {
				entity.SetColumnValue("ModifiedOn", DateTime.UtcNow);
				entity.Save();
			}
		}

		public virtual void UpdateRemindingsExecute() {
			if (!IsBirthDateChanged) {
				return;
			}
			var contactSchema = UserConnection.EntitySchemaManager.GetInstanceByName("Contact");
			var contactEntity = contactSchema.CreateEntity(UserConnection);
			if (Entity.ContactId.IsNotEmpty() && contactEntity.FetchFromDB(Entity.ContactId)) {
				BaseAnniversaryReminding remindingsGenerator = GetRemindingsGenerator(contactEntity);
				remindingsGenerator.GenerateActualRemindings();
			}
		}

		public virtual BaseAnniversaryReminding GetRemindingsGenerator(Entity contactEntity) {
			if (contactEntity.GetTypedColumnValue<Guid>("TypeId") == ContactConsts.EmployeeTypeId) {
				return new EmployeeAnniversaryReminding(UserConnection, contactEntity.GetTypedColumnValue<Guid>("Id"));
			} else {
				var remindingInfo = new ContactAnniversaryRemindingInfo();
				remindingInfo.Initialize(contactEntity);
				return new ContactAnniversaryReminding(UserConnection, remindingInfo);
			}
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "ContactAnniversarySaved":
							if (ActivatedEventElements.Contains("ContactAnniversarySaved")) {
							context.QueueTasks.Enqueue("ContactAnniversarySaved");
						}
						break;
					case "ContactAnniversaryDeleted":
							if (ActivatedEventElements.Contains("ContactAnniversaryDeleted")) {
							context.QueueTasks.Enqueue("ContactAnniversaryDeleted");
						}
						break;
					case "ContactAnniversaryDeleting":
							if (ActivatedEventElements.Contains("ContactAnniversaryDeleting")) {
							context.QueueTasks.Enqueue("ContactAnniversaryDeleting");
						}
						break;
					case "ContactAnniversarySaving":
							if (ActivatedEventElements.Contains("ContactAnniversarySaving_Base")) {
							context.QueueTasks.Enqueue("ContactAnniversarySaving_Base");
						}
						break;
			}
			base.ThrowEvent(context, message);
			ProcessQueue(context);
		}

		public override void WritePropertiesData(DataWriter writer, bool writeFlowElements = true) {
			base.WritePropertiesData(writer, writeFlowElements);
			if (!HasMapping("IsBirthDateChanged") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("IsBirthDateChanged", IsBirthDateChanged, false);
			}
			if (!HasMapping("IsCurrentContactBirthday") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("IsCurrentContactBirthday", IsCurrentContactBirthday, false);
			}
			if (!HasMapping("TypeOldValue") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("TypeOldValue", TypeOldValue, Guid.Empty);
			}
		}

		public override object CloneShallow() {
			return base.CloneShallow();
		}

		#endregion

	}

	#endregion

	#region Class: ContactAnniversary_BaseEventsProcess

	/// <exclude/>
	public class ContactAnniversary_BaseEventsProcess : ContactAnniversary_BaseEventsProcess<ContactAnniversary>
	{

		public ContactAnniversary_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: ContactAnniversaryEventsProcessSchema

	/// <exclude/>
	public class ContactAnniversaryEventsProcessSchema : Terrasoft.Configuration.BaseAnniversaryEventsProcessSchema
	{

		#region Constructors: Public

		public ContactAnniversaryEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public ContactAnniversaryEventsProcessSchema(ContactAnniversaryEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "ContactAnniversary_BaseEventsProcess";
			UId = new Guid("59b6d995-0d3c-4bc1-a9a7-c477b19e5581");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = Guid.Empty;
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
		}

		protected virtual ProcessSchemaParameter CreateTypeOldValueParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("a038ba15-96ec-4b2a-9bff-c5964d2b82e6"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("59b6d995-0d3c-4bc1-a9a7-c477b19e5581"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("59b6d995-0d3c-4bc1-a9a7-c477b19e5581"),
				Name = @"TypeOldValue",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateIsCurrentContactBirthdayParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("3e87e812-ed3d-4373-8a63-8150a0bb9097"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("59b6d995-0d3c-4bc1-a9a7-c477b19e5581"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("59b6d995-0d3c-4bc1-a9a7-c477b19e5581"),
				Name = @"IsCurrentContactBirthday",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateIsBirthDateChangedParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("d6dab26b-b87a-4042-9520-4dcca2f0940c"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("59b6d995-0d3c-4bc1-a9a7-c477b19e5581"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("59b6d995-0d3c-4bc1-a9a7-c477b19e5581"),
				Name = @"IsBirthDateChanged",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateTypeOldValueParameter());
			Parameters.Add(CreateIsCurrentContactBirthdayParameter());
			Parameters.Add(CreateIsBirthDateChangedParameter());
		}

		protected virtual void InitializeSynchronizeContactDataParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("07744d6d-104b-4d6c-ad63-65257bc53704"),
				ContainerUId = new Guid("3652ed05-819a-4102-917d-dace3ab4d495"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("3e6374da-0124-4817-bb7c-34b2b4ba4816"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = true,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("3e6374da-0124-4817-bb7c-34b2b4ba4816"),
				Name = @"ParentEntityColumnUId",
				SourceParameterUId = Guid.Empty,
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					Value = null,
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			});
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("cc4ba375-9ef5-4f53-b8bf-9db377999da0"),
				ContainerUId = new Guid("3652ed05-819a-4102-917d-dace3ab4d495"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("3e6374da-0124-4817-bb7c-34b2b4ba4816"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = true,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("3e6374da-0124-4817-bb7c-34b2b4ba4816"),
				Name = @"ConditionMappingColumns",
				SourceParameterUId = Guid.Empty,
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					Value = null,
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			});
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("de0ffaf1-197e-4fe6-92d5-6c38a2248e15"),
				ContainerUId = new Guid("3652ed05-819a-4102-917d-dace3ab4d495"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("3e6374da-0124-4817-bb7c-34b2b4ba4816"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = true,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("3e6374da-0124-4817-bb7c-34b2b4ba4816"),
				Name = @"MappingColumns",
				SourceParameterUId = Guid.Empty,
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					Value = null,
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			});
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("52551aeb-9f14-4afb-8ce3-e007d9c4604e"),
				ContainerUId = new Guid("3652ed05-819a-4102-917d-dace3ab4d495"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("3e6374da-0124-4817-bb7c-34b2b4ba4816"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("3e6374da-0124-4817-bb7c-34b2b4ba4816"),
				Name = @"DefaultValues",
				SourceParameterUId = Guid.Empty,
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					Value = null,
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			});
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("2ef3397e-9241-44f3-ac7a-59c1a4d8dfd4"),
				ContainerUId = new Guid("3652ed05-819a-4102-917d-dace3ab4d495"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("3e6374da-0124-4817-bb7c-34b2b4ba4816"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("3e6374da-0124-4817-bb7c-34b2b4ba4816"),
				Name = @"DeleteChild",
				SourceParameterUId = Guid.Empty,
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					Value = null,
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			});
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet755 = CreateLaneSet755LaneSet();
			LaneSets.Add(schemaLaneSet755);
			ProcessSchemaLane schemaLane2763 = CreateLane2763Lane();
			schemaLaneSet755.Lanes.Add(schemaLane2763);
			ProcessSchemaEventSubProcess eventsubprocess1 = CreateEventSubProcess1EventSubProcess();
			FlowElements.Add(eventsubprocess1);
			ProcessSchemaEventSubProcess subprocess1 = CreateSubProcess1EventSubProcess();
			FlowElements.Add(subprocess1);
			ProcessSchemaEventSubProcess subprocess2 = CreateSubProcess2EventSubProcess();
			FlowElements.Add(subprocess2);
			ProcessSchemaEventSubProcess eventsubprocess3_128f81454a2b4a1cb112cdec8d554bc1 = CreateEventSubProcess3_128f81454a2b4a1cb112cdec8d554bc1EventSubProcess();
			FlowElements.Add(eventsubprocess3_128f81454a2b4a1cb112cdec8d554bc1);
			ProcessSchemaStartMessageEvent contactanniversarysaved = CreateContactAnniversarySavedStartMessageEvent();
			eventsubprocess1.FlowElements.Add(contactanniversarysaved);
			ProcessSchemaScriptTask scriptcontactanniversarysaved = CreateScriptContactAnniversarySavedScriptTask();
			eventsubprocess1.FlowElements.Add(scriptcontactanniversarysaved);
			ProcessSchemaUserTask synchronizecontactdata = CreateSynchronizeContactDataUserTask();
			eventsubprocess1.FlowElements.Add(synchronizecontactdata);
			ProcessSchemaScriptTask scripttask2 = CreateScriptTask2ScriptTask();
			eventsubprocess1.FlowElements.Add(scripttask2);
			ProcessSchemaScriptTask updatecontact = CreateUpdateContactScriptTask();
			eventsubprocess1.FlowElements.Add(updatecontact);
			ProcessSchemaScriptTask updateremindings = CreateUpdateRemindingsScriptTask();
			eventsubprocess1.FlowElements.Add(updateremindings);
			ProcessSchemaStartMessageEvent contactanniversarydeleted = CreateContactAnniversaryDeletedStartMessageEvent();
			subprocess1.FlowElements.Add(contactanniversarydeleted);
			ProcessSchemaScriptTask scriptcontactanniversarydeleted = CreateScriptContactAnniversaryDeletedScriptTask();
			subprocess1.FlowElements.Add(scriptcontactanniversarydeleted);
			ProcessSchemaScriptTask scripttask1 = CreateScriptTask1ScriptTask();
			subprocess1.FlowElements.Add(scripttask1);
			ProcessSchemaExclusiveGateway exclusivegateway1 = CreateExclusiveGateway1ExclusiveGateway();
			subprocess1.FlowElements.Add(exclusivegateway1);
			ProcessSchemaStartMessageEvent contactanniversarydeleting = CreateContactAnniversaryDeletingStartMessageEvent();
			subprocess2.FlowElements.Add(contactanniversarydeleting);
			ProcessSchemaScriptTask scriptcontactanniversarydeleting = CreateScriptContactAnniversaryDeletingScriptTask();
			subprocess2.FlowElements.Add(scriptcontactanniversarydeleting);
			ProcessSchemaStartMessageEvent contactanniversarysaving_base = CreateContactAnniversarySaving_BaseStartMessageEvent();
			eventsubprocess3_128f81454a2b4a1cb112cdec8d554bc1.FlowElements.Add(contactanniversarysaving_base);
			ProcessSchemaScriptTask initvalues = CreateInitValuesScriptTask();
			eventsubprocess3_128f81454a2b4a1cb112cdec8d554bc1.FlowElements.Add(initvalues);
			FlowElements.Add(CreateSequenceFlow16332SequenceFlow());
			FlowElements.Add(CreateSequenceFlow16333SequenceFlow());
			FlowElements.Add(CreateSequenceFlow16334SequenceFlow());
			FlowElements.Add(CreateSequenceFlow16335SequenceFlow());
			FlowElements.Add(CreateSequenceFlow16336SequenceFlow());
			FlowElements.Add(CreateSequenceFlow16337SequenceFlow());
			FlowElements.Add(CreateSequenceFlow16338ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3_c000ff0124944eb0972eb2e378d5f38bSequenceFlow());
			FlowElements.Add(CreateSequenceFlow4_7b350f43facd45c08f47ae8d06210dceSequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow16332SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow16332",
				UId = new Guid("566d7bc4-7e86-4c58-accf-cb746dda19cd"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("add7fe6a-0f22-4b77-a577-0ca7fe7f73bc"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("59b6d995-0d3c-4bc1-a9a7-c477b19e5581"),
				CurveCenterPosition = new Point(232, 156),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("59b6d995-0d3c-4bc1-a9a7-c477b19e5581"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("440db6c0-ff9f-47ed-9c62-67e55f6e6a79"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("eeab9c46-1fe0-4dc4-ad9c-093214604655"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow16333SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow16333",
				UId = new Guid("eb2c2ed8-6699-432c-8f82-998a44ecae9a"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("add7fe6a-0f22-4b77-a577-0ca7fe7f73bc"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("59b6d995-0d3c-4bc1-a9a7-c477b19e5581"),
				CurveCenterPosition = new Point(354, 162),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("59b6d995-0d3c-4bc1-a9a7-c477b19e5581"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("eeab9c46-1fe0-4dc4-ad9c-093214604655"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("daaed5bf-853f-4420-952f-6cfaa85c2d3a"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow16334SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow16334",
				UId = new Guid("50b94fcb-66e3-48e9-97bf-0b054b0fa6de"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("add7fe6a-0f22-4b77-a577-0ca7fe7f73bc"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("59b6d995-0d3c-4bc1-a9a7-c477b19e5581"),
				CurveCenterPosition = new Point(172, 288),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("59b6d995-0d3c-4bc1-a9a7-c477b19e5581"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("5775ae89-a558-4cdf-8179-58c1cef66760"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("83931b88-8f3d-460e-810d-2b856fdd63cd"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow16335SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow16335",
				UId = new Guid("4acd322b-29b6-497d-915e-c13ba5cc4247"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("add7fe6a-0f22-4b77-a577-0ca7fe7f73bc"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("59b6d995-0d3c-4bc1-a9a7-c477b19e5581"),
				CurveCenterPosition = new Point(407, 280),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("59b6d995-0d3c-4bc1-a9a7-c477b19e5581"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("ff12752a-dbbb-4bf8-bd12-3270401a4070"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("645b0ac9-19cc-4b92-96b5-92451ca11b5b"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow16336SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow16336",
				UId = new Guid("dddbe5a2-bc3c-436a-b49a-e29592ebc901"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("add7fe6a-0f22-4b77-a577-0ca7fe7f73bc"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("59b6d995-0d3c-4bc1-a9a7-c477b19e5581"),
				CurveCenterPosition = new Point(170, 325),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("59b6d995-0d3c-4bc1-a9a7-c477b19e5581"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("d5967a6b-4d60-4373-a28e-bb505b05529f"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("5775ae89-a558-4cdf-8179-58c1cef66760"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow16337SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow16337",
				UId = new Guid("abba27c4-a814-420e-964d-476c49dd7c48"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("add7fe6a-0f22-4b77-a577-0ca7fe7f73bc"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("59b6d995-0d3c-4bc1-a9a7-c477b19e5581"),
				CurveCenterPosition = new Point(305, 232),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("59b6d995-0d3c-4bc1-a9a7-c477b19e5581"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("5a7868e9-c996-46aa-9c4a-a3c9a56aa185"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("daaed5bf-853f-4420-952f-6cfaa85c2d3a"),
				TargetSequenceFlowPointLocalPosition = new Point(0, -1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(315, 239));
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateSequenceFlow16338ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "SequenceFlow16338",
				UId = new Guid("68b4dfb4-c8c0-40c2-97e1-049c2664f8d6"),
				ConditionExpression = @"IsCurrentContactBirthday",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("add7fe6a-0f22-4b77-a577-0ca7fe7f73bc"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("59b6d995-0d3c-4bc1-a9a7-c477b19e5581"),
				CurveCenterPosition = new Point(267, 368),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("59b6d995-0d3c-4bc1-a9a7-c477b19e5581"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("5775ae89-a558-4cdf-8179-58c1cef66760"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("5a7868e9-c996-46aa-9c4a-a3c9a56aa185"),
				TargetSequenceFlowPointLocalPosition = new Point(0, -1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("c91ff1eb-030d-4444-ae63-9a7935dad063"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("add7fe6a-0f22-4b77-a577-0ca7fe7f73bc"),
				CreatedInPackageId = new Guid("d8b043ab-1ada-4e1f-9921-a7610c352117"),
				CreatedInSchemaUId = new Guid("59b6d995-0d3c-4bc1-a9a7-c477b19e5581"),
				CurveCenterPosition = new Point(354, 162),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("59b6d995-0d3c-4bc1-a9a7-c477b19e5581"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("daaed5bf-853f-4420-952f-6cfaa85c2d3a"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("3652ed05-819a-4102-917d-dace3ab4d495"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("9765c795-6168-4f9f-9eed-18df4ff6e4f2"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("add7fe6a-0f22-4b77-a577-0ca7fe7f73bc"),
				CreatedInPackageId = new Guid("8545ab96-9a47-426f-bffc-031c3bbd0779"),
				CreatedInSchemaUId = new Guid("59b6d995-0d3c-4bc1-a9a7-c477b19e5581"),
				CurveCenterPosition = new Point(563, 98),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("59b6d995-0d3c-4bc1-a9a7-c477b19e5581"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("3652ed05-819a-4102-917d-dace3ab4d495"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("d4331a0d-ad4b-4ebf-975e-9c42e00d79e5"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3_c000ff0124944eb0972eb2e378d5f38bSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3_c000ff0124944eb0972eb2e378d5f38b",
				UId = new Guid("c000ff01-2494-4eb0-972e-b2e378d5f38b"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("add7fe6a-0f22-4b77-a577-0ca7fe7f73bc"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("59b6d995-0d3c-4bc1-a9a7-c477b19e5581"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("59b6d995-0d3c-4bc1-a9a7-c477b19e5581"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("12777a63-1ce5-4a98-a8c9-204c614985d9"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("a58f9919-d1a3-4dd9-9cf4-de80a6f1afe6"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4_7b350f43facd45c08f47ae8d06210dceSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4_7b350f43facd45c08f47ae8d06210dce",
				UId = new Guid("7b350f43-facd-45c0-8f47-ae8d06210dce"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("add7fe6a-0f22-4b77-a577-0ca7fe7f73bc"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("59b6d995-0d3c-4bc1-a9a7-c477b19e5581"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("59b6d995-0d3c-4bc1-a9a7-c477b19e5581"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("d4331a0d-ad4b-4ebf-975e-9c42e00d79e5"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("ee0b8d22-9347-4315-98fe-7c8d0025dd71"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet755LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet755 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("bdc8e852-880e-4e8a-97c4-10f133130cad"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("add7fe6a-0f22-4b77-a577-0ca7fe7f73bc"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("59b6d995-0d3c-4bc1-a9a7-c477b19e5581"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("59b6d995-0d3c-4bc1-a9a7-c477b19e5581"),
				Name = @"LaneSet755",
				Position = new Point(5, 5),
				Size = new Size(1041, 431),
				UseBackgroundMode = false
			};
			return schemaLaneSet755;
		}

		protected virtual ProcessSchemaLane CreateLane2763Lane() {
			ProcessSchemaLane schemaLane2763 = new ProcessSchemaLane(this) {
				UId = new Guid("839f995b-66bf-40c4-b4a1-6b9d350ee400"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("bdc8e852-880e-4e8a-97c4-10f133130cad"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("59b6d995-0d3c-4bc1-a9a7-c477b19e5581"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("59b6d995-0d3c-4bc1-a9a7-c477b19e5581"),
				Name = @"Lane2763",
				Position = new Point(29, 0),
				Size = new Size(1012, 431),
				UseBackgroundMode = false
			};
			return schemaLane2763;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess1EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess1 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("424d3fcf-eb2b-44b3-8555-5c0ac3e2a30f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("839f995b-66bf-40c4-b4a1-6b9d350ee400"),
				CreatedInOwnerSchemaUId = new Guid("add7fe6a-0f22-4b77-a577-0ca7fe7f73bc"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("59b6d995-0d3c-4bc1-a9a7-c477b19e5581"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("59b6d995-0d3c-4bc1-a9a7-c477b19e5581"),
				Name = @"EventSubProcess1",
				Position = new Point(35, 20),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(745, 164),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess1;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateContactAnniversarySavedStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("440db6c0-ff9f-47ed-9c62-67e55f6e6a79"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("424d3fcf-eb2b-44b3-8555-5c0ac3e2a30f"),
				CreatedInOwnerSchemaUId = new Guid("add7fe6a-0f22-4b77-a577-0ca7fe7f73bc"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("59b6d995-0d3c-4bc1-a9a7-c477b19e5581"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"ContactAnniversarySaved",
				ModifiedInSchemaUId = new Guid("59b6d995-0d3c-4bc1-a9a7-c477b19e5581"),
				Name = @"ContactAnniversarySaved",
				Position = new Point(29, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptContactAnniversarySavedScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("eeab9c46-1fe0-4dc4-ad9c-093214604655"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("424d3fcf-eb2b-44b3-8555-5c0ac3e2a30f"),
				CreatedInOwnerSchemaUId = new Guid("add7fe6a-0f22-4b77-a577-0ca7fe7f73bc"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("59b6d995-0d3c-4bc1-a9a7-c477b19e5581"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("59b6d995-0d3c-4bc1-a9a7-c477b19e5581"),
				Name = @"ScriptContactAnniversarySaved",
				Position = new Point(127, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,174,204,75,206,40,202,207,203,172,74,117,206,207,43,73,76,46,113,73,44,73,212,115,73,205,73,45,73,117,206,200,204,73,81,176,85,72,75,204,41,78,181,230,229,42,74,45,41,45,202,83,40,41,42,77,181,6,0,153,145,99,28,57,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaUserTask CreateSynchronizeContactDataUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("3652ed05-819a-4102-917d-dace3ab4d495"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("424d3fcf-eb2b-44b3-8555-5c0ac3e2a30f"),
				CreatedInOwnerSchemaUId = new Guid("add7fe6a-0f22-4b77-a577-0ca7fe7f73bc"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("59b6d995-0d3c-4bc1-a9a7-c477b19e5581"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("3e6374da-0124-4817-bb7c-34b2b4ba4816"),
				ModifiedInSchemaUId = new Guid("59b6d995-0d3c-4bc1-a9a7-c477b19e5581"),
				Name = @"SynchronizeContactData",
				Position = new Point(379, 51),
				SchemaUId = new Guid("3e6374da-0124-4817-bb7c-34b2b4ba4816"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			InitializeSynchronizeContactDataParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask2ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("daaed5bf-853f-4420-952f-6cfaa85c2d3a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("424d3fcf-eb2b-44b3-8555-5c0ac3e2a30f"),
				CreatedInOwnerSchemaUId = new Guid("add7fe6a-0f22-4b77-a577-0ca7fe7f73bc"),
				CreatedInPackageId = new Guid("d8b043ab-1ada-4e1f-9921-a7610c352117"),
				CreatedInSchemaUId = new Guid("59b6d995-0d3c-4bc1-a9a7-c477b19e5581"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("59b6d995-0d3c-4bc1-a9a7-c477b19e5581"),
				Name = @"ScriptTask2",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(246, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,197,86,93,111,155,48,20,125,166,82,255,131,197,19,145,10,37,77,74,130,186,86,106,105,87,245,97,91,167,238,227,97,218,131,177,47,171,39,48,153,49,221,216,212,255,62,27,19,242,5,109,214,117,26,138,34,48,199,199,199,247,92,223,203,29,22,136,228,156,50,201,114,254,10,207,102,140,127,137,242,180,204,120,129,142,17,135,239,232,166,42,36,100,158,26,76,129,104,84,225,93,2,7,193,136,119,206,234,1,44,170,23,187,59,214,101,201,232,222,150,112,131,205,227,175,10,115,114,226,12,142,118,119,238,148,146,236,233,2,12,163,254,95,208,81,72,112,153,202,15,56,45,225,41,108,141,190,154,111,119,103,127,223,93,189,208,5,151,76,86,232,134,220,66,134,209,92,245,251,43,138,220,135,47,35,79,197,93,98,34,79,57,103,119,32,10,181,238,210,237,187,106,6,134,81,243,25,237,90,149,99,135,35,114,16,6,97,224,142,252,73,236,142,15,147,145,139,39,97,232,198,135,195,96,226,199,52,33,113,96,207,67,176,185,198,57,150,61,196,4,130,0,227,9,117,167,227,241,200,29,199,135,88,17,39,224,226,208,199,48,134,169,31,82,104,137,99,38,228,45,197,213,26,199,112,50,162,135,1,61,112,19,74,176,75,147,225,208,13,227,3,236,250,254,144,6,62,132,163,41,217,16,119,166,169,250,101,141,18,127,74,227,32,116,21,109,162,100,13,137,59,157,224,177,139,9,165,36,32,163,56,164,134,210,144,130,49,229,184,102,135,31,210,187,22,57,129,66,219,44,213,237,12,132,172,234,140,112,108,227,159,61,64,184,64,239,64,8,92,228,137,84,169,33,192,171,95,49,40,204,77,117,180,204,221,248,125,220,60,122,230,185,21,80,22,32,162,156,115,147,94,29,66,222,175,0,58,168,95,97,142,191,128,232,152,186,250,254,81,217,43,240,142,133,222,150,32,170,38,216,23,235,227,78,135,164,189,213,61,123,175,113,6,173,155,2,148,135,244,13,55,54,182,241,89,162,244,78,41,53,111,29,59,154,195,107,239,58,161,167,105,106,70,154,163,85,31,196,181,101,188,55,130,130,56,171,78,11,226,116,19,189,100,169,84,169,175,9,29,85,166,54,1,70,137,129,125,100,242,246,26,11,181,45,61,199,49,131,81,158,205,176,96,69,206,245,169,244,46,190,149,56,221,67,138,203,178,35,147,194,118,27,24,149,101,26,212,108,179,78,180,23,166,42,205,177,87,212,30,12,254,131,212,181,226,162,36,47,206,240,96,110,34,110,49,139,10,217,233,164,218,167,201,152,5,206,89,205,124,115,36,89,130,156,46,82,149,175,37,151,232,4,249,3,244,171,233,30,136,233,147,223,133,254,228,127,126,40,178,58,164,106,53,75,47,166,57,142,183,112,163,182,161,94,218,218,172,236,209,188,37,162,166,39,182,213,125,179,148,91,150,14,220,76,176,76,87,112,74,133,58,168,139,249,127,215,117,44,171,135,183,78,145,237,27,200,138,215,53,111,79,211,95,230,221,172,203,123,125,219,52,94,119,69,114,155,248,101,127,36,225,145,150,86,111,239,126,119,231,30,65,90,0,210,41,113,85,68,165,16,42,37,162,37,86,21,11,99,255,63,116,239,31,153,247,252,222,89,234,247,236,46,220,235,156,184,169,56,185,21,57,103,63,161,137,190,194,97,79,21,46,229,71,91,65,218,182,191,92,104,188,185,20,117,138,207,42,221,106,218,26,106,15,60,133,63,234,165,143,122,63,105,123,98,215,79,181,193,144,109,57,241,124,237,235,115,229,107,84,77,19,32,75,193,145,20,37,28,253,6,192,160,112,217,135,11,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaScriptTask CreateUpdateContactScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("d4331a0d-ad4b-4ebf-975e-9c42e00d79e5"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("424d3fcf-eb2b-44b3-8555-5c0ac3e2a30f"),
				CreatedInOwnerSchemaUId = new Guid("add7fe6a-0f22-4b77-a577-0ca7fe7f73bc"),
				CreatedInPackageId = new Guid("8545ab96-9a47-426f-bffc-031c3bbd0779"),
				CreatedInSchemaUId = new Guid("59b6d995-0d3c-4bc1-a9a7-c477b19e5581"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("59b6d995-0d3c-4bc1-a9a7-c477b19e5581"),
				Name = @"UpdateContact",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(498, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,45,72,73,44,73,117,206,207,43,73,76,46,241,205,79,201,76,75,77,241,207,211,208,180,230,229,42,74,45,41,45,202,83,40,41,42,77,181,6,0,206,184,230,27,39,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaScriptTask CreateUpdateRemindingsScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("ee0b8d22-9347-4315-98fe-7c8d0025dd71"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("424d3fcf-eb2b-44b3-8555-5c0ac3e2a30f"),
				CreatedInOwnerSchemaUId = new Guid("add7fe6a-0f22-4b77-a577-0ca7fe7f73bc"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("59b6d995-0d3c-4bc1-a9a7-c477b19e5581"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("59b6d995-0d3c-4bc1-a9a7-c477b19e5581"),
				Name = @"UpdateRemindings",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(612, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,45,72,73,44,73,13,74,205,205,204,75,201,204,75,47,118,173,72,77,46,45,73,213,208,180,230,42,74,45,41,45,202,83,40,41,42,77,181,6,0,156,21,185,198,39,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSubProcess1EventSubProcess() {
			ProcessSchemaEventSubProcess schemaSubProcess1 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("fe0343c3-0156-43a3-8ef5-0272760bc31b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("839f995b-66bf-40c4-b4a1-6b9d350ee400"),
				CreatedInOwnerSchemaUId = new Guid("add7fe6a-0f22-4b77-a577-0ca7fe7f73bc"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("59b6d995-0d3c-4bc1-a9a7-c477b19e5581"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("59b6d995-0d3c-4bc1-a9a7-c477b19e5581"),
				Name = @"SubProcess1",
				Position = new Point(35, 189),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(370, 228),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSubProcess1;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateContactAnniversaryDeletedStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("d5967a6b-4d60-4373-a28e-bb505b05529f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("fe0343c3-0156-43a3-8ef5-0272760bc31b"),
				CreatedInOwnerSchemaUId = new Guid("add7fe6a-0f22-4b77-a577-0ca7fe7f73bc"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("59b6d995-0d3c-4bc1-a9a7-c477b19e5581"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"ContactAnniversaryDeleted",
				ModifiedInSchemaUId = new Guid("59b6d995-0d3c-4bc1-a9a7-c477b19e5581"),
				Name = @"ContactAnniversaryDeleted",
				Position = new Point(22, 142),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptContactAnniversaryDeletedScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("83931b88-8f3d-460e-810d-2b856fdd63cd"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("fe0343c3-0156-43a3-8ef5-0272760bc31b"),
				CreatedInOwnerSchemaUId = new Guid("add7fe6a-0f22-4b77-a577-0ca7fe7f73bc"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("59b6d995-0d3c-4bc1-a9a7-c477b19e5581"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("59b6d995-0d3c-4bc1-a9a7-c477b19e5581"),
				Name = @"ScriptContactAnniversaryDeleted",
				Position = new Point(204, 128),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,40,41,42,77,181,230,226,226,2,0,255,245,21,53,15,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask1ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("5a7868e9-c996-46aa-9c4a-a3c9a56aa185"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("fe0343c3-0156-43a3-8ef5-0272760bc31b"),
				CreatedInOwnerSchemaUId = new Guid("add7fe6a-0f22-4b77-a577-0ca7fe7f73bc"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("59b6d995-0d3c-4bc1-a9a7-c477b19e5581"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("59b6d995-0d3c-4bc1-a9a7-c477b19e5581"),
				Name = @"ScriptTask1",
				Position = new Point(92, 23),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,144,205,106,195,48,16,132,239,133,190,131,200,73,189,232,5,250,3,141,157,152,92,157,166,119,33,13,181,192,94,149,213,170,224,62,125,165,216,253,9,109,65,7,173,190,157,25,237,118,57,120,85,206,189,218,145,4,153,77,7,121,154,95,225,155,56,230,137,158,237,152,113,215,149,166,7,189,105,34,137,117,114,240,155,155,219,235,171,250,168,146,27,48,217,211,225,135,193,218,101,142,103,100,10,43,205,11,83,110,97,107,245,159,164,97,88,193,194,244,41,129,11,39,56,9,145,106,240,133,137,217,67,220,176,231,56,181,91,29,124,229,91,155,240,72,20,222,192,201,242,220,99,10,228,3,189,40,254,188,165,14,4,182,18,185,252,161,12,220,255,6,250,34,165,218,254,161,54,45,70,8,122,184,200,254,219,68,127,109,165,234,142,51,185,129,35,133,119,172,115,182,86,236,42,109,134,48,214,221,9,103,156,51,36,51,45,213,7,254,103,6,96,154,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGateway1ExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("5775ae89-a558-4cdf-8179-58c1cef66760"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("fe0343c3-0156-43a3-8ef5-0272760bc31b"),
				CreatedInOwnerSchemaUId = new Guid("add7fe6a-0f22-4b77-a577-0ca7fe7f73bc"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("59b6d995-0d3c-4bc1-a9a7-c477b19e5581"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("59b6d995-0d3c-4bc1-a9a7-c477b19e5581"),
				Name = @"ExclusiveGateway1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(99, 128),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSubProcess2EventSubProcess() {
			ProcessSchemaEventSubProcess schemaSubProcess2 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("fa6975d5-6872-4dac-bf64-d62644f1dbaf"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("839f995b-66bf-40c4-b4a1-6b9d350ee400"),
				CreatedInOwnerSchemaUId = new Guid("add7fe6a-0f22-4b77-a577-0ca7fe7f73bc"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("59b6d995-0d3c-4bc1-a9a7-c477b19e5581"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("59b6d995-0d3c-4bc1-a9a7-c477b19e5581"),
				Name = @"SubProcess2",
				Position = new Point(414, 261),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(233, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSubProcess2;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateContactAnniversaryDeletingStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("ff12752a-dbbb-4bf8-bd12-3270401a4070"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("fa6975d5-6872-4dac-bf64-d62644f1dbaf"),
				CreatedInOwnerSchemaUId = new Guid("add7fe6a-0f22-4b77-a577-0ca7fe7f73bc"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("59b6d995-0d3c-4bc1-a9a7-c477b19e5581"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"ContactAnniversaryDeleting",
				ModifiedInSchemaUId = new Guid("59b6d995-0d3c-4bc1-a9a7-c477b19e5581"),
				Name = @"ContactAnniversaryDeleting",
				Position = new Point(35, 56),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptContactAnniversaryDeletingScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("645b0ac9-19cc-4b92-96b5-92451ca11b5b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("fa6975d5-6872-4dac-bf64-d62644f1dbaf"),
				CreatedInOwnerSchemaUId = new Guid("add7fe6a-0f22-4b77-a577-0ca7fe7f73bc"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("59b6d995-0d3c-4bc1-a9a7-c477b19e5581"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("59b6d995-0d3c-4bc1-a9a7-c477b19e5581"),
				Name = @"ScriptContactAnniversaryDeleting",
				Position = new Point(119, 42),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,189,84,203,110,194,48,16,60,39,95,225,250,228,72,16,17,80,105,17,77,37,72,2,202,161,47,245,117,182,200,82,44,5,135,58,54,85,84,241,239,181,9,84,64,210,170,82,91,142,241,238,206,78,102,118,55,206,3,37,4,112,25,100,92,210,137,28,50,33,103,9,45,144,143,166,52,205,161,111,179,41,34,17,151,76,22,238,128,115,182,4,145,83,81,60,20,11,136,19,116,226,35,14,111,104,172,88,66,176,119,214,9,79,187,97,187,57,10,131,65,51,28,121,94,179,55,108,15,154,173,150,23,118,91,81,175,115,30,116,177,227,160,119,219,18,32,149,224,72,10,165,59,172,108,131,118,147,38,79,52,85,224,163,77,183,49,72,243,158,232,64,144,165,106,206,215,225,11,211,235,114,203,232,126,50,131,57,117,203,120,110,74,134,197,53,157,3,193,7,92,177,227,238,128,152,20,167,111,47,169,64,176,6,42,113,174,40,167,47,32,244,191,63,230,32,180,34,28,38,146,101,220,224,238,101,16,28,85,203,176,131,104,142,106,2,213,70,119,10,132,145,216,104,23,29,190,147,26,74,13,132,55,6,97,205,187,2,229,14,146,141,70,4,199,73,125,202,136,165,82,235,97,82,73,53,26,8,160,18,202,156,103,38,103,183,84,104,141,76,1,41,31,131,108,190,160,130,229,25,55,114,186,209,171,162,105,195,182,240,122,96,66,93,139,27,91,227,204,151,115,76,14,250,151,63,155,111,100,138,19,103,215,96,6,185,150,187,218,82,27,91,214,105,245,210,210,108,178,239,189,83,110,192,22,69,227,43,46,145,239,35,111,61,200,127,228,234,206,180,26,247,170,176,85,135,107,114,254,71,94,171,178,75,154,247,15,119,253,168,52,183,27,82,63,11,71,36,82,191,14,214,239,39,209,250,110,20,173,248,235,91,94,30,90,107,165,111,237,238,233,253,0,142,120,65,106,254,5,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess3_128f81454a2b4a1cb112cdec8d554bc1EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess3_128f81454a2b4a1cb112cdec8d554bc1 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("128f8145-4a2b-4a1c-b112-cdec8d554bc1"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("839f995b-66bf-40c4-b4a1-6b9d350ee400"),
				CreatedInOwnerSchemaUId = new Guid("add7fe6a-0f22-4b77-a577-0ca7fe7f73bc"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("59b6d995-0d3c-4bc1-a9a7-c477b19e5581"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("59b6d995-0d3c-4bc1-a9a7-c477b19e5581"),
				Name = @"EventSubProcess3_128f81454a2b4a1cb112cdec8d554bc1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(23, 438),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(300, 182),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess3_128f81454a2b4a1cb112cdec8d554bc1;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateContactAnniversarySaving_BaseStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("12777a63-1ce5-4a98-a8c9-204c614985d9"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("128f8145-4a2b-4a1c-b112-cdec8d554bc1"),
				CreatedInOwnerSchemaUId = new Guid("add7fe6a-0f22-4b77-a577-0ca7fe7f73bc"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("59b6d995-0d3c-4bc1-a9a7-c477b19e5581"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"ContactAnniversarySaving",
				ModifiedInSchemaUId = new Guid("59b6d995-0d3c-4bc1-a9a7-c477b19e5581"),
				Name = @"ContactAnniversarySaving_Base",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(30, 48),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateInitValuesScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("a58f9919-d1a3-4dd9-9cf4-de80a6f1afe6"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("128f8145-4a2b-4a1c-b112-cdec8d554bc1"),
				CreatedInOwnerSchemaUId = new Guid("add7fe6a-0f22-4b77-a577-0ca7fe7f73bc"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				CreatedInSchemaUId = new Guid("59b6d995-0d3c-4bc1-a9a7-c477b19e5581"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("59b6d995-0d3c-4bc1-a9a7-c477b19e5581"),
				Name = @"InitValues",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(147, 34),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,243,44,118,202,44,42,201,112,73,44,73,117,206,72,204,75,79,77,81,176,85,112,205,43,201,44,169,212,115,79,45,129,138,57,231,231,148,230,230,133,37,230,148,166,22,107,104,234,57,230,85,106,36,231,231,40,216,218,41,0,41,61,191,196,220,84,5,91,91,5,37,144,41,74,154,214,92,69,169,37,165,69,121,10,37,69,165,169,214,0,142,42,110,165,97,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateUpdateContactModifedOnMethod());
			Methods.Add(CreateUpdateRemindingsExecuteMethod());
			Methods.Add(CreateGetRemindingsGeneratorMethod());
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
				UId = new Guid("3c64e1dc-77b8-4097-a925-abba1ad8e6fe"),
				Name = "System.Linq",
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
		}

		protected virtual SchemaMethod CreateUpdateContactModifedOnMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("ec079fb1-b693-4f56-be07-c3370cc77f5e"),
				Name = "UpdateContactModifedOn",
				CreatedInSchemaUId = new Guid("59b6d995-0d3c-4bc1-a9a7-c477b19e5581"),
				CreatedInPackageId = new Guid("8545ab96-9a47-426f-bffc-031c3bbd0779"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,85,143,205,110,194,48,16,132,207,240,20,86,78,142,132,252,2,109,57,16,10,226,0,61,240,115,95,217,3,177,132,215,149,217,164,138,170,190,123,13,33,81,123,92,237,124,223,104,90,74,202,70,22,178,178,113,234,77,189,179,120,233,204,26,114,232,62,225,170,120,109,2,159,232,218,224,117,221,120,55,215,69,53,164,139,242,101,218,102,220,243,77,136,45,50,125,188,33,229,63,195,138,143,108,122,217,222,214,8,180,37,166,11,210,221,188,121,2,139,110,71,1,163,113,240,225,65,101,219,32,54,85,2,9,122,155,254,223,145,25,127,86,186,103,204,10,98,235,85,138,97,185,208,227,170,178,84,223,211,201,51,177,135,252,217,164,139,109,116,254,236,225,62,184,152,169,101,110,57,248,0,115,20,187,139,95,217,61,98,212,66,231,251,231,23,150,239,79,52,48,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateUpdateRemindingsExecuteMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("2927bcc4-ed2f-4f95-9867-c91c452ff031"),
				Name = "UpdateRemindingsExecute",
				CreatedInSchemaUId = new Guid("59b6d995-0d3c-4bc1-a9a7-c477b19e5581"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,143,77,106,195,48,16,133,215,241,41,212,44,130,188,209,5,66,23,177,243,131,23,205,34,165,7,24,228,169,45,136,70,101,52,9,152,146,187,119,168,82,90,147,238,6,30,223,247,222,132,119,99,159,186,220,4,150,113,11,130,237,8,52,96,95,155,207,106,193,40,23,166,117,117,171,174,192,198,39,18,240,242,234,71,140,96,158,205,91,70,110,19,17,122,9,137,220,142,36,200,84,210,23,32,24,144,221,1,165,163,44,64,30,155,233,8,17,237,178,45,150,101,189,254,43,45,176,74,103,37,174,101,212,73,37,180,243,62,229,131,78,47,153,187,91,187,222,117,249,152,100,23,63,20,168,205,106,53,47,112,123,20,63,238,57,197,109,243,128,214,223,63,55,144,113,67,20,174,200,25,120,58,97,12,212,7,26,12,255,92,249,128,132,12,146,88,247,234,135,167,199,192,206,90,117,234,226,31,218,221,47,220,120,185,192,249,87,99,21,184,125,1,143,126,240,118,152,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetRemindingsGeneratorMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("1b88b786-0898-4538-8b6e-5b0fb77c8f7a"),
				Name = "GetRemindingsGenerator",
				CreatedInSchemaUId = new Guid("59b6d995-0d3c-4bc1-a9a7-c477b19e5581"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2"),
				ResultValueTypeName = "BaseAnniversaryReminding"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("25424e63-1068-42ae-8bb3-725de7367e8f"),
				Name = "contactEntity",
				CreatedInSchemaUId = new Guid("59b6d995-0d3c-4bc1-a9a7-c477b19e5581"),
				ModifiedInSchemaUId = new Guid("59b6d995-0d3c-4bc1-a9a7-c477b19e5581"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Entity",
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,80,205,10,130,64,16,62,235,83,12,158,20,194,23,40,131,8,9,175,81,221,23,157,98,96,157,141,221,209,176,232,221,115,51,3,41,162,211,192,204,247,59,116,132,184,52,44,170,148,156,133,164,75,55,40,187,238,140,213,218,232,166,230,131,210,13,46,54,13,85,203,56,242,251,162,138,18,200,50,88,15,164,126,56,113,105,94,159,181,233,16,7,68,2,183,48,176,40,141,101,96,188,192,120,93,49,83,139,214,41,219,109,177,38,174,136,79,241,222,161,237,85,24,75,33,195,51,248,59,141,79,146,204,195,59,160,118,232,29,91,101,193,142,186,5,31,13,100,79,251,87,212,111,238,30,21,247,34,193,132,151,22,76,66,74,211,21,167,207,25,144,239,94,63,132,63,106,77,12,124,236,7,37,143,5,25,122,1,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new ContactAnniversaryEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("59b6d995-0d3c-4bc1-a9a7-c477b19e5581"));
		}

		#endregion

	}

	#endregion


	#region Class: ContactAnniversaryEventsProcess

	/// <exclude/>
	public class ContactAnniversaryEventsProcess : ContactAnniversary_BaseEventsProcess
	{

		public ContactAnniversaryEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

