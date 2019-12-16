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
	using Terrasoft.Core.Campaign;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.DcmProcess;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Factories;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities.Json.Converters;

	#region Class: CampaignParticipantSchema

	/// <exclude/>
	public class CampaignParticipantSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public CampaignParticipantSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public CampaignParticipantSchema(CampaignParticipantSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public CampaignParticipantSchema(CampaignParticipantSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("d42c6b3f-5128-4a5f-9346-557b066db650");
			RealUId = new Guid("d42c6b3f-5128-4a5f-9346-557b066db650");
			Name = "CampaignParticipant";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("0fa99f9a-3eca-422f-9a3c-3294c39b5190");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("e0a882f3-eac1-46cb-91c9-d678e0723090")) == null) {
				Columns.Add(CreateCampaignColumn());
			}
			if (Columns.FindByUId(new Guid("68b7f207-bd39-4ed1-b85c-309af28a6329")) == null) {
				Columns.Add(CreateContactColumn());
			}
			if (Columns.FindByUId(new Guid("5fd85758-dccd-4a3c-990d-d8d86a2d168d")) == null) {
				Columns.Add(CreateStatusColumn());
			}
			if (Columns.FindByUId(new Guid("10ce1ffe-4c46-4565-8ef2-14904fa77be9")) == null) {
				Columns.Add(CreateCampaignItemColumn());
			}
			if (Columns.FindByUId(new Guid("12d696f8-d572-4651-a7c8-f6732aefd884")) == null) {
				Columns.Add(CreateStepModifiedOnColumn());
			}
			if (Columns.FindByUId(new Guid("fcb47eb0-d278-4a17-939c-c6df557d9a04")) == null) {
				Columns.Add(CreateStepCompletedOnColumn());
			}
			if (Columns.FindByUId(new Guid("9ec2aa9e-da21-4ebb-87bc-da31089b8054")) == null) {
				Columns.Add(CreateStepCompletedColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateCampaignColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("e0a882f3-eac1-46cb-91c9-d678e0723090"),
				Name = @"Campaign",
				ReferenceSchemaUId = new Guid("1f9bb71a-eb9c-4220-a40e-9b623eacfec8"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("d42c6b3f-5128-4a5f-9346-557b066db650"),
				ModifiedInSchemaUId = new Guid("d42c6b3f-5128-4a5f-9346-557b066db650"),
				CreatedInPackageId = new Guid("0fa99f9a-3eca-422f-9a3c-3294c39b5190")
			};
		}

		protected virtual EntitySchemaColumn CreateContactColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("68b7f207-bd39-4ed1-b85c-309af28a6329"),
				Name = @"Contact",
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("d42c6b3f-5128-4a5f-9346-557b066db650"),
				ModifiedInSchemaUId = new Guid("d42c6b3f-5128-4a5f-9346-557b066db650"),
				CreatedInPackageId = new Guid("0fa99f9a-3eca-422f-9a3c-3294c39b5190")
			};
		}

		protected virtual EntitySchemaColumn CreateStatusColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("5fd85758-dccd-4a3c-990d-d8d86a2d168d"),
				Name = @"Status",
				ReferenceSchemaUId = new Guid("cd0b4a6c-bf4d-4dee-a383-cf7f0fe65932"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsValueCloneable = false,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("d42c6b3f-5128-4a5f-9346-557b066db650"),
				ModifiedInSchemaUId = new Guid("d42c6b3f-5128-4a5f-9346-557b066db650"),
				CreatedInPackageId = new Guid("0fa99f9a-3eca-422f-9a3c-3294c39b5190"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"58b91b66-256b-48cf-a56a-a5b7036825e6"
				}
			};
		}

		protected virtual EntitySchemaColumn CreateCampaignItemColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("10ce1ffe-4c46-4565-8ef2-14904fa77be9"),
				Name = @"CampaignItem",
				ReferenceSchemaUId = new Guid("28045fad-1d04-4bb5-8600-ed4ca87b5650"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("d42c6b3f-5128-4a5f-9346-557b066db650"),
				ModifiedInSchemaUId = new Guid("d42c6b3f-5128-4a5f-9346-557b066db650"),
				CreatedInPackageId = new Guid("0fa99f9a-3eca-422f-9a3c-3294c39b5190")
			};
		}

		protected virtual EntitySchemaColumn CreateStepModifiedOnColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("DateTime")) {
				UId = new Guid("12d696f8-d572-4651-a7c8-f6732aefd884"),
				Name = @"StepModifiedOn",
				CreatedInSchemaUId = new Guid("d42c6b3f-5128-4a5f-9346-557b066db650"),
				ModifiedInSchemaUId = new Guid("d42c6b3f-5128-4a5f-9346-557b066db650"),
				CreatedInPackageId = new Guid("0fa99f9a-3eca-422f-9a3c-3294c39b5190")
			};
		}

		protected virtual EntitySchemaColumn CreateStepCompletedOnColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("DateTime")) {
				UId = new Guid("fcb47eb0-d278-4a17-939c-c6df557d9a04"),
				Name = @"StepCompletedOn",
				CreatedInSchemaUId = new Guid("d42c6b3f-5128-4a5f-9346-557b066db650"),
				ModifiedInSchemaUId = new Guid("d42c6b3f-5128-4a5f-9346-557b066db650"),
				CreatedInPackageId = new Guid("0fa99f9a-3eca-422f-9a3c-3294c39b5190")
			};
		}

		protected virtual EntitySchemaColumn CreateStepCompletedColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("9ec2aa9e-da21-4ebb-87bc-da31089b8054"),
				Name = @"StepCompleted",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("d42c6b3f-5128-4a5f-9346-557b066db650"),
				ModifiedInSchemaUId = new Guid("d42c6b3f-5128-4a5f-9346-557b066db650"),
				CreatedInPackageId = new Guid("0fa99f9a-3eca-422f-9a3c-3294c39b5190"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"False"
				}
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateCampaignParticipantEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateCampaignParticipantEventsProcessSchema() {
			var schema = new CampaignParticipantEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new CampaignParticipant(userConnection){Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new CampaignParticipant_CampaignsEventsProcess(userConnnection);
		}

		public override object Clone() {
			return new CampaignParticipantSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new CampaignParticipantSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d42c6b3f-5128-4a5f-9346-557b066db650"));
		}

		#endregion

	}

	#endregion

	#region Class: CampaignParticipant

	/// <summary>
	/// Campaign participant.
	/// </summary>
	public class CampaignParticipant : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public CampaignParticipant(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "CampaignParticipant";
		}

		public CampaignParticipant(CampaignParticipant source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid CampaignId {
			get {
				return GetTypedColumnValue<Guid>("CampaignId");
			}
			set {
				SetColumnValue("CampaignId", value);
				_campaign = null;
			}
		}

		/// <exclude/>
		public string CampaignName {
			get {
				return GetTypedColumnValue<string>("CampaignName");
			}
			set {
				SetColumnValue("CampaignName", value);
				if (_campaign != null) {
					_campaign.Name = value;
				}
			}
		}

		private Campaign _campaign;
		/// <summary>
		/// Campaign.
		/// </summary>
		public Campaign Campaign {
			get {
				return _campaign ??
					(_campaign = LookupColumnEntities.GetEntity("Campaign") as Campaign);
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
		public Guid StatusId {
			get {
				return GetTypedColumnValue<Guid>("StatusId");
			}
			set {
				SetColumnValue("StatusId", value);
				_status = null;
			}
		}

		/// <exclude/>
		public string StatusName {
			get {
				return GetTypedColumnValue<string>("StatusName");
			}
			set {
				SetColumnValue("StatusName", value);
				if (_status != null) {
					_status.Name = value;
				}
			}
		}

		private CmpgnParticipantStatus _status;
		/// <summary>
		/// Status.
		/// </summary>
		public CmpgnParticipantStatus Status {
			get {
				return _status ??
					(_status = LookupColumnEntities.GetEntity("Status") as CmpgnParticipantStatus);
			}
		}

		/// <exclude/>
		public Guid CampaignItemId {
			get {
				return GetTypedColumnValue<Guid>("CampaignItemId");
			}
			set {
				SetColumnValue("CampaignItemId", value);
				_campaignItem = null;
			}
		}

		/// <exclude/>
		public string CampaignItemName {
			get {
				return GetTypedColumnValue<string>("CampaignItemName");
			}
			set {
				SetColumnValue("CampaignItemName", value);
				if (_campaignItem != null) {
					_campaignItem.Name = value;
				}
			}
		}

		private CampaignItem _campaignItem;
		/// <summary>
		/// Current step.
		/// </summary>
		public CampaignItem CampaignItem {
			get {
				return _campaignItem ??
					(_campaignItem = LookupColumnEntities.GetEntity("CampaignItem") as CampaignItem);
			}
		}

		/// <summary>
		/// Step modified on.
		/// </summary>
		public DateTime StepModifiedOn {
			get {
				return GetTypedColumnValue<DateTime>("StepModifiedOn");
			}
			set {
				SetColumnValue("StepModifiedOn", value);
			}
		}

		/// <summary>
		/// Step completed on.
		/// </summary>
		public DateTime StepCompletedOn {
			get {
				return GetTypedColumnValue<DateTime>("StepCompletedOn");
			}
			set {
				SetColumnValue("StepCompletedOn", value);
			}
		}

		/// <summary>
		/// Step completed.
		/// </summary>
		public bool StepCompleted {
			get {
				return GetTypedColumnValue<bool>("StepCompleted");
			}
			set {
				SetColumnValue("StepCompleted", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new CampaignParticipant_CampaignsEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("CampaignParticipantDeleted", e);
			Inserted += (s, e) => ThrowEvent("CampaignParticipantInserted", e);
			Saving += (s, e) => ThrowEvent("CampaignParticipantSaving", e);
			Validating += (s, e) => ThrowEvent("CampaignParticipantValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new CampaignParticipant(this);
		}

		#endregion

	}

	#endregion

	#region Class: CampaignParticipant_CampaignsEventsProcess

	/// <exclude/>
	public class CampaignParticipant_CampaignsEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_LocalMessageEventsProcess<TEntity> where TEntity : CampaignParticipant
	{

		public CampaignParticipant_CampaignsEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "CampaignParticipant_CampaignsEventsProcess";
			SchemaUId = new Guid("d42c6b3f-5128-4a5f-9346-557b066db650");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("d42c6b3f-5128-4a5f-9346-557b066db650");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		private ProcessFlowElement _beforeSavingSubProcess;
		public ProcessFlowElement BeforeSavingSubProcess {
			get {
				return _beforeSavingSubProcess ?? (_beforeSavingSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "BeforeSavingSubProcess",
					SchemaElementUId = new Guid("6fa0ffb2-9e88-4795-bc52-b23307b191ca"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _campaignParticipantSaving;
		public ProcessFlowElement CampaignParticipantSaving {
			get {
				return _campaignParticipantSaving ?? (_campaignParticipantSaving = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "CampaignParticipantSaving",
					SchemaElementUId = new Guid("d76632a8-a4e3-4eb3-b45d-0e4a089a9821"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _beforeSavingTask;
		public ProcessScriptTask BeforeSavingTask {
			get {
				return _beforeSavingTask ?? (_beforeSavingTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "BeforeSavingTask",
					SchemaElementUId = new Guid("554749a0-778c-4a64-b04a-0e13c9a21067"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = BeforeSavingTaskExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcess3_7892104b73a246dfa7102186820743b4;
		public ProcessFlowElement EventSubProcess3_7892104b73a246dfa7102186820743b4 {
			get {
				return _eventSubProcess3_7892104b73a246dfa7102186820743b4 ?? (_eventSubProcess3_7892104b73a246dfa7102186820743b4 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess3_7892104b73a246dfa7102186820743b4",
					SchemaElementUId = new Guid("7892104b-73a2-46df-a710-2186820743b4"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _campaignParticipantInserted;
		public ProcessFlowElement CampaignParticipantInserted {
			get {
				return _campaignParticipantInserted ?? (_campaignParticipantInserted = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "CampaignParticipantInserted",
					SchemaElementUId = new Guid("35395012-7e3e-4075-91cb-1b5221a51f76"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _campaignParticipantInsertedScriptTask;
		public ProcessScriptTask CampaignParticipantInsertedScriptTask {
			get {
				return _campaignParticipantInsertedScriptTask ?? (_campaignParticipantInsertedScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "CampaignParticipantInsertedScriptTask",
					SchemaElementUId = new Guid("0c68692c-a146-4b1f-bc34-2871927f1aa2"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = CampaignParticipantInsertedScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcess4_5b90e69fb268496bbfb5fcb14cb8b50d;
		public ProcessFlowElement EventSubProcess4_5b90e69fb268496bbfb5fcb14cb8b50d {
			get {
				return _eventSubProcess4_5b90e69fb268496bbfb5fcb14cb8b50d ?? (_eventSubProcess4_5b90e69fb268496bbfb5fcb14cb8b50d = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess4_5b90e69fb268496bbfb5fcb14cb8b50d",
					SchemaElementUId = new Guid("5b90e69f-b268-496b-bfb5-fcb14cb8b50d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _campaignParticipantDeleted;
		public ProcessFlowElement CampaignParticipantDeleted {
			get {
				return _campaignParticipantDeleted ?? (_campaignParticipantDeleted = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "CampaignParticipantDeleted",
					SchemaElementUId = new Guid("8f9265a9-4e36-40bf-91e4-f1d827b69df9"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _campaignParticipantDeletedScriptTask;
		public ProcessScriptTask CampaignParticipantDeletedScriptTask {
			get {
				return _campaignParticipantDeletedScriptTask ?? (_campaignParticipantDeletedScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "CampaignParticipantDeletedScriptTask",
					SchemaElementUId = new Guid("6dc0c1bc-6fd6-4138-bd6b-8f29064c510f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = CampaignParticipantDeletedScriptTaskExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[BeforeSavingSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { BeforeSavingSubProcess };
			FlowElements[CampaignParticipantSaving.SchemaElementUId] = new Collection<ProcessFlowElement> { CampaignParticipantSaving };
			FlowElements[BeforeSavingTask.SchemaElementUId] = new Collection<ProcessFlowElement> { BeforeSavingTask };
			FlowElements[EventSubProcess3_7892104b73a246dfa7102186820743b4.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess3_7892104b73a246dfa7102186820743b4 };
			FlowElements[CampaignParticipantInserted.SchemaElementUId] = new Collection<ProcessFlowElement> { CampaignParticipantInserted };
			FlowElements[CampaignParticipantInsertedScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { CampaignParticipantInsertedScriptTask };
			FlowElements[EventSubProcess4_5b90e69fb268496bbfb5fcb14cb8b50d.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess4_5b90e69fb268496bbfb5fcb14cb8b50d };
			FlowElements[CampaignParticipantDeleted.SchemaElementUId] = new Collection<ProcessFlowElement> { CampaignParticipantDeleted };
			FlowElements[CampaignParticipantDeletedScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { CampaignParticipantDeletedScriptTask };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "BeforeSavingSubProcess":
						break;
					case "CampaignParticipantSaving":
						e.Context.QueueTasks.Enqueue("BeforeSavingTask");
						break;
					case "BeforeSavingTask":
						break;
					case "EventSubProcess3_7892104b73a246dfa7102186820743b4":
						break;
					case "CampaignParticipantInserted":
						e.Context.QueueTasks.Enqueue("CampaignParticipantInsertedScriptTask");
						break;
					case "CampaignParticipantInsertedScriptTask":
						break;
					case "EventSubProcess4_5b90e69fb268496bbfb5fcb14cb8b50d":
						break;
					case "CampaignParticipantDeleted":
						e.Context.QueueTasks.Enqueue("CampaignParticipantDeletedScriptTask");
						break;
					case "CampaignParticipantDeletedScriptTask":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("CampaignParticipantSaving");
			ActivatedEventElements.Add("CampaignParticipantInserted");
			ActivatedEventElements.Add("CampaignParticipantDeleted");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "BeforeSavingSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "CampaignParticipantSaving":
					context.QueueTasks.Dequeue();
					context.SenderName = "CampaignParticipantSaving";
					result = CampaignParticipantSaving.Execute(context);
					break;
				case "BeforeSavingTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "BeforeSavingTask";
					result = BeforeSavingTask.Execute(context, BeforeSavingTaskExecute);
					break;
				case "EventSubProcess3_7892104b73a246dfa7102186820743b4":
					context.QueueTasks.Dequeue();
					break;
				case "CampaignParticipantInserted":
					context.QueueTasks.Dequeue();
					context.SenderName = "CampaignParticipantInserted";
					result = CampaignParticipantInserted.Execute(context);
					break;
				case "CampaignParticipantInsertedScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "CampaignParticipantInsertedScriptTask";
					result = CampaignParticipantInsertedScriptTask.Execute(context, CampaignParticipantInsertedScriptTaskExecute);
					break;
				case "EventSubProcess4_5b90e69fb268496bbfb5fcb14cb8b50d":
					context.QueueTasks.Dequeue();
					break;
				case "CampaignParticipantDeleted":
					context.QueueTasks.Dequeue();
					context.SenderName = "CampaignParticipantDeleted";
					result = CampaignParticipantDeleted.Execute(context);
					break;
				case "CampaignParticipantDeletedScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "CampaignParticipantDeletedScriptTask";
					result = CampaignParticipantDeletedScriptTask.Execute(context, CampaignParticipantDeletedScriptTaskExecute);
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

		public virtual bool BeforeSavingTaskExecute(ProcessExecutingContext context) {
			BeforeSaving();
			return true;
		}

		public virtual bool CampaignParticipantInsertedScriptTaskExecute(ProcessExecutingContext context) {
			UpdateParticipantsCount(1);
			return true;
		}

		public virtual bool CampaignParticipantDeletedScriptTaskExecute(ProcessExecutingContext context) {
			UpdateParticipantsCount(-1);
			return true;
		}

		public virtual void BeforeSaving() {
			var changedValues = Entity.GetChangedColumnValues().ToArray();
			bool isStepCompleted = Entity.GetTypedColumnValue<bool>("StepCompleted");
			bool isStepCompletedChanged = changedValues.Any(x => x.Name == "StepCompleted");
			bool isCampaignItemChanged = changedValues.Any(x => x.Name == "CampaignItemId");
			if (isStepCompletedChanged) {
				if (isStepCompleted) {
					Entity.SetColumnValue("StepCompletedOn", DateTime.UtcNow);
				} else {
					Entity.SetColumnValue("StepCompletedOn", null);
				}
			}
			if (isCampaignItemChanged) {
				Entity.SetColumnValue("StepModifiedOn", DateTime.UtcNow);
			}
		}

		public virtual void UpdateParticipantsCount(int intCount) {
			Guid campaignId = Entity.GetTypedColumnValue<Guid>("CampaignId");
			if (campaignId == Guid.Empty) {
				return;
			}
			var update = new Update(UserConnection, "Campaign")
				.Set("ModifiedOn", Column.Parameter(DateTime.UtcNow))
				.Set("ModifiedById", Column.Parameter(UserConnection.CurrentUser.ContactId))
				.Set("TargetTotal", QueryColumnExpression.Add(new QueryColumnExpression("TargetTotal"),
					Column.Parameter(intCount)))
				.Where("Id").IsEqual(Column.Parameter(campaignId)) as Update;
			update.WithHints(new RowLockHint());
			var participantStatusId = Entity.GetTypedColumnValue<Guid>("StatusId");
			if (participantStatusId == CampaignConstants.CampaignParticipantReachedGoalStatusId) {
				update.Set("TargetAchieve", QueryColumnExpression.Add(new QueryColumnExpression("TargetAchieve"),
					Column.Parameter(intCount)));
			}
			
			update.Execute();
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "CampaignParticipantSaving":
							if (ActivatedEventElements.Contains("CampaignParticipantSaving")) {
							context.QueueTasks.Enqueue("CampaignParticipantSaving");
						}
						break;
					case "CampaignParticipantInserted":
							if (ActivatedEventElements.Contains("CampaignParticipantInserted")) {
							context.QueueTasks.Enqueue("CampaignParticipantInserted");
						}
						break;
					case "CampaignParticipantDeleted":
							if (ActivatedEventElements.Contains("CampaignParticipantDeleted")) {
							context.QueueTasks.Enqueue("CampaignParticipantDeleted");
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

	#region Class: CampaignParticipant_CampaignsEventsProcess

	/// <exclude/>
	public class CampaignParticipant_CampaignsEventsProcess : CampaignParticipant_CampaignsEventsProcess<CampaignParticipant>
	{

		public CampaignParticipant_CampaignsEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: CampaignParticipantEventsProcessSchema

	/// <exclude/>
	public class CampaignParticipantEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public CampaignParticipantEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public CampaignParticipantEventsProcessSchema(CampaignParticipantEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "CampaignParticipant_CampaignsEventsProcess";
			UId = new Guid("4c8fab55-8034-4c0a-8b51-ef02135114fd");
			CreatedInPackageId = new Guid("0fa99f9a-3eca-422f-9a3c-3294c39b5190");
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
			ProcessSchemaEventSubProcess beforesavingsubprocess = CreateBeforeSavingSubProcessEventSubProcess();
			FlowElements.Add(beforesavingsubprocess);
			ProcessSchemaEventSubProcess eventsubprocess3_7892104b73a246dfa7102186820743b4 = CreateEventSubProcess3_7892104b73a246dfa7102186820743b4EventSubProcess();
			FlowElements.Add(eventsubprocess3_7892104b73a246dfa7102186820743b4);
			ProcessSchemaEventSubProcess eventsubprocess4_5b90e69fb268496bbfb5fcb14cb8b50d = CreateEventSubProcess4_5b90e69fb268496bbfb5fcb14cb8b50dEventSubProcess();
			FlowElements.Add(eventsubprocess4_5b90e69fb268496bbfb5fcb14cb8b50d);
			ProcessSchemaStartMessageEvent campaignparticipantsaving = CreateCampaignParticipantSavingStartMessageEvent();
			beforesavingsubprocess.FlowElements.Add(campaignparticipantsaving);
			ProcessSchemaScriptTask beforesavingtask = CreateBeforeSavingTaskScriptTask();
			beforesavingsubprocess.FlowElements.Add(beforesavingtask);
			ProcessSchemaStartMessageEvent campaignparticipantinserted = CreateCampaignParticipantInsertedStartMessageEvent();
			eventsubprocess3_7892104b73a246dfa7102186820743b4.FlowElements.Add(campaignparticipantinserted);
			ProcessSchemaScriptTask campaignparticipantinsertedscripttask = CreateCampaignParticipantInsertedScriptTaskScriptTask();
			eventsubprocess3_7892104b73a246dfa7102186820743b4.FlowElements.Add(campaignparticipantinsertedscripttask);
			ProcessSchemaStartMessageEvent campaignparticipantdeleted = CreateCampaignParticipantDeletedStartMessageEvent();
			eventsubprocess4_5b90e69fb268496bbfb5fcb14cb8b50d.FlowElements.Add(campaignparticipantdeleted);
			ProcessSchemaScriptTask campaignparticipantdeletedscripttask = CreateCampaignParticipantDeletedScriptTaskScriptTask();
			eventsubprocess4_5b90e69fb268496bbfb5fcb14cb8b50d.FlowElements.Add(campaignparticipantdeletedscripttask);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2_88ea24796b6549ccb3ffbe3e710e9ee8SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3_b27ef6161a2a4bc78c008c9ae22ee40aSequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("1f678e27-37ca-4747-9c37-0edeb773f3b9"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("0fa99f9a-3eca-422f-9a3c-3294c39b5190"),
				CreatedInSchemaUId = new Guid("4c8fab55-8034-4c0a-8b51-ef02135114fd"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("4c8fab55-8034-4c0a-8b51-ef02135114fd"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("d76632a8-a4e3-4eb3-b45d-0e4a089a9821"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("554749a0-778c-4a64-b04a-0e13c9a21067"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2_88ea24796b6549ccb3ffbe3e710e9ee8SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2_88ea24796b6549ccb3ffbe3e710e9ee8",
				UId = new Guid("88ea2479-6b65-49cc-b3ff-be3e710e9ee8"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("6c038aa0-46cd-4697-bc93-5c682e364aef"),
				CreatedInSchemaUId = new Guid("4c8fab55-8034-4c0a-8b51-ef02135114fd"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("4c8fab55-8034-4c0a-8b51-ef02135114fd"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("35395012-7e3e-4075-91cb-1b5221a51f76"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("0c68692c-a146-4b1f-bc34-2871927f1aa2"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3_b27ef6161a2a4bc78c008c9ae22ee40aSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3_b27ef6161a2a4bc78c008c9ae22ee40a",
				UId = new Guid("b27ef616-1a2a-4bc7-8c00-8c9ae22ee40a"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("6c038aa0-46cd-4697-bc93-5c682e364aef"),
				CreatedInSchemaUId = new Guid("4c8fab55-8034-4c0a-8b51-ef02135114fd"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("4c8fab55-8034-4c0a-8b51-ef02135114fd"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("8f9265a9-4e36-40bf-91e4-f1d827b69df9"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("6dc0c1bc-6fd6-4138-bd6b-8f29064c510f"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("07f509fb-7a7c-4c9e-a08f-ee3ccabd15e3"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("0fa99f9a-3eca-422f-9a3c-3294c39b5190"),
				CreatedInSchemaUId = new Guid("4c8fab55-8034-4c0a-8b51-ef02135114fd"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("4c8fab55-8034-4c0a-8b51-ef02135114fd"),
				Name = @"LaneSet1",
				Position = new Point(0, 5),
				Size = new Size(0, 400),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("6fcc357a-8b38-47a7-b33c-8f791225f5b7"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("07f509fb-7a7c-4c9e-a08f-ee3ccabd15e3"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("0fa99f9a-3eca-422f-9a3c-3294c39b5190"),
				CreatedInSchemaUId = new Guid("4c8fab55-8034-4c0a-8b51-ef02135114fd"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("4c8fab55-8034-4c0a-8b51-ef02135114fd"),
				Name = @"Lane1",
				Position = new Point(0, 0),
				Size = new Size(700, 400),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaEventSubProcess CreateBeforeSavingSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaBeforeSavingSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("6fa0ffb2-9e88-4795-bc52-b23307b191ca"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6fcc357a-8b38-47a7-b33c-8f791225f5b7"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("0fa99f9a-3eca-422f-9a3c-3294c39b5190"),
				CreatedInSchemaUId = new Guid("4c8fab55-8034-4c0a-8b51-ef02135114fd"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("4c8fab55-8034-4c0a-8b51-ef02135114fd"),
				Name = @"BeforeSavingSubProcess",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(122, 60),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(303, 140),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaBeforeSavingSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateCampaignParticipantSavingStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("d76632a8-a4e3-4eb3-b45d-0e4a089a9821"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6fa0ffb2-9e88-4795-bc52-b23307b191ca"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("0fa99f9a-3eca-422f-9a3c-3294c39b5190"),
				CreatedInSchemaUId = new Guid("4c8fab55-8034-4c0a-8b51-ef02135114fd"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"CampaignParticipantSaving",
				ModifiedInSchemaUId = new Guid("4c8fab55-8034-4c0a-8b51-ef02135114fd"),
				Name = @"CampaignParticipantSaving",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(38, 46),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateBeforeSavingTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("554749a0-778c-4a64-b04a-0e13c9a21067"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6fa0ffb2-9e88-4795-bc52-b23307b191ca"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("0fa99f9a-3eca-422f-9a3c-3294c39b5190"),
				CreatedInSchemaUId = new Guid("4c8fab55-8034-4c0a-8b51-ef02135114fd"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("4c8fab55-8034-4c0a-8b51-ef02135114fd"),
				Name = @"BeforeSavingTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(197, 32),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,115,74,77,203,47,74,13,78,44,203,204,75,215,208,180,230,42,74,45,41,45,202,83,40,41,42,77,181,6,0,17,5,124,153,28,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess3_7892104b73a246dfa7102186820743b4EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess3_7892104b73a246dfa7102186820743b4 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("7892104b-73a2-46df-a710-2186820743b4"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6fcc357a-8b38-47a7-b33c-8f791225f5b7"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("6c038aa0-46cd-4697-bc93-5c682e364aef"),
				CreatedInSchemaUId = new Guid("4c8fab55-8034-4c0a-8b51-ef02135114fd"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("4c8fab55-8034-4c0a-8b51-ef02135114fd"),
				Name = @"EventSubProcess3_7892104b73a246dfa7102186820743b4",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(116, 255),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(315, 145),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess3_7892104b73a246dfa7102186820743b4;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateCampaignParticipantInsertedStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("35395012-7e3e-4075-91cb-1b5221a51f76"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7892104b-73a2-46df-a710-2186820743b4"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("6c038aa0-46cd-4697-bc93-5c682e364aef"),
				CreatedInSchemaUId = new Guid("4c8fab55-8034-4c0a-8b51-ef02135114fd"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"CampaignParticipantInserted",
				ModifiedInSchemaUId = new Guid("4c8fab55-8034-4c0a-8b51-ef02135114fd"),
				Name = @"CampaignParticipantInserted",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(37, 58),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateCampaignParticipantInsertedScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("0c68692c-a146-4b1f-bc34-2871927f1aa2"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7892104b-73a2-46df-a710-2186820743b4"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("6c038aa0-46cd-4697-bc93-5c682e364aef"),
				CreatedInSchemaUId = new Guid("4c8fab55-8034-4c0a-8b51-ef02135114fd"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("4c8fab55-8034-4c0a-8b51-ef02135114fd"),
				Name = @"CampaignParticipantInsertedScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(201, 44),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,45,72,73,44,73,13,72,44,42,201,76,206,44,72,204,43,41,118,206,47,205,43,209,48,212,180,230,229,42,74,45,41,45,202,83,40,41,42,77,181,6,0,237,217,85,118,41,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess4_5b90e69fb268496bbfb5fcb14cb8b50dEventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess4_5b90e69fb268496bbfb5fcb14cb8b50d = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("5b90e69f-b268-496b-bfb5-fcb14cb8b50d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6fcc357a-8b38-47a7-b33c-8f791225f5b7"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("6c038aa0-46cd-4697-bc93-5c682e364aef"),
				CreatedInSchemaUId = new Guid("4c8fab55-8034-4c0a-8b51-ef02135114fd"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("4c8fab55-8034-4c0a-8b51-ef02135114fd"),
				Name = @"EventSubProcess4_5b90e69fb268496bbfb5fcb14cb8b50d",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(116, 445),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(315, 142),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess4_5b90e69fb268496bbfb5fcb14cb8b50d;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateCampaignParticipantDeletedStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("8f9265a9-4e36-40bf-91e4-f1d827b69df9"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5b90e69f-b268-496b-bfb5-fcb14cb8b50d"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("6c038aa0-46cd-4697-bc93-5c682e364aef"),
				CreatedInSchemaUId = new Guid("4c8fab55-8034-4c0a-8b51-ef02135114fd"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"CampaignParticipantDeleted",
				ModifiedInSchemaUId = new Guid("4c8fab55-8034-4c0a-8b51-ef02135114fd"),
				Name = @"CampaignParticipantDeleted",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(45, 46),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateCampaignParticipantDeletedScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("6dc0c1bc-6fd6-4138-bd6b-8f29064c510f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5b90e69f-b268-496b-bfb5-fcb14cb8b50d"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("6c038aa0-46cd-4697-bc93-5c682e364aef"),
				CreatedInSchemaUId = new Guid("4c8fab55-8034-4c0a-8b51-ef02135114fd"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("4c8fab55-8034-4c0a-8b51-ef02135114fd"),
				Name = @"CampaignParticipantDeletedScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(201, 32),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,45,72,73,44,73,13,72,44,42,201,76,206,44,72,204,43,41,118,206,47,205,43,209,208,53,212,180,230,229,42,74,45,41,45,202,83,40,41,42,77,181,6,0,46,50,210,106,42,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateBeforeSavingMethod());
			Methods.Add(CreateUpdateParticipantsCountMethod());
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
				UId = new Guid("efa5b711-6092-4270-b54a-afe05a033700"),
				Name = "System.Linq",
				Alias = "",
				CreatedInPackageId = new Guid("0fa99f9a-3eca-422f-9a3c-3294c39b5190")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("540a2e64-5e86-4c5d-96de-35a2148ddede"),
				Name = "Terrasoft.Core.Campaign",
				Alias = "",
				CreatedInPackageId = new Guid("6c038aa0-46cd-4697-bc93-5c682e364aef")
			});
		}

		protected virtual SchemaMethod CreateBeforeSavingMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("ba42c958-9622-49d6-b8c6-953fb92f8c5f"),
				Name = "BeforeSaving",
				CreatedInSchemaUId = new Guid("4c8fab55-8034-4c0a-8b51-ef02135114fd"),
				CreatedInPackageId = new Guid("0fa99f9a-3eca-422f-9a3c-3294c39b5190"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,144,205,10,130,64,20,133,215,250,20,23,87,35,196,188,64,25,136,69,180,168,22,89,251,73,175,53,48,63,162,99,37,225,187,103,42,148,161,65,219,123,56,223,253,56,87,150,65,116,97,234,140,241,145,137,2,115,240,96,169,12,55,37,93,161,9,218,36,208,162,144,170,205,137,75,67,237,103,25,43,137,59,181,79,90,11,224,249,222,96,26,104,153,10,52,24,247,8,97,153,246,250,179,87,99,78,156,94,195,25,33,117,239,107,96,79,145,250,170,36,119,240,230,112,167,91,38,17,60,15,70,129,1,147,41,227,103,181,54,40,255,225,125,246,214,13,144,39,64,134,5,93,120,216,214,64,220,220,173,110,140,125,61,231,123,135,175,5,118,202,153,192,130,25,12,185,68,122,48,209,86,223,234,151,86,5,40,114,252,15,163,10,33,154,174,93,117,206,3,27,52,106,63,144,27,29,243,132,143,138,85,79,12,191,247,143,56,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateUpdateParticipantsCountMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("54a90002-2688-40fa-aa8e-1456e8361e49"),
				Name = "UpdateParticipantsCount",
				CreatedInSchemaUId = new Guid("4c8fab55-8034-4c0a-8b51-ef02135114fd"),
				CreatedInPackageId = new Guid("6c038aa0-46cd-4697-bc93-5c682e364aef"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("76d599be-df4b-4d5d-a798-e9854494c967"),
				Name = "intCount",
				CreatedInSchemaUId = new Guid("4c8fab55-8034-4c0a-8b51-ef02135114fd"),
				ModifiedInSchemaUId = new Guid("4c8fab55-8034-4c0a-8b51-ef02135114fd"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "int",
				CreatedInPackageId = new Guid("6c038aa0-46cd-4697-bc93-5c682e364aef")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,165,146,221,78,195,48,12,133,175,153,180,119,136,122,149,72,83,94,96,12,9,74,53,38,241,207,6,215,86,98,88,68,155,148,196,217,168,16,239,78,74,233,24,218,36,144,184,140,99,127,182,207,241,52,26,205,20,84,53,152,39,59,211,108,194,10,75,134,26,57,69,154,55,53,234,220,149,177,178,247,80,70,60,156,166,228,35,158,229,155,244,76,140,135,3,243,200,248,54,97,194,218,60,89,84,53,53,130,189,13,7,7,30,41,122,155,82,223,135,131,21,120,22,107,13,132,169,151,197,53,91,124,62,248,34,160,207,157,181,168,200,56,59,98,155,46,153,72,4,121,135,196,179,11,167,205,163,65,125,101,179,17,235,6,147,215,224,161,66,66,207,79,19,102,110,42,148,11,82,151,110,45,118,235,78,154,52,242,158,202,159,189,101,30,189,71,75,109,84,166,48,129,162,153,222,194,205,193,63,37,117,28,65,153,104,55,17,125,211,33,139,215,218,99,8,45,227,88,107,222,110,183,247,247,39,66,140,18,249,96,103,40,99,41,119,209,146,232,58,63,44,209,35,207,90,205,229,44,20,47,17,74,190,83,243,109,131,16,12,194,151,182,73,248,78,113,249,96,104,121,150,192,225,115,182,91,183,62,119,234,185,13,112,209,58,217,122,83,131,39,163,76,13,150,238,8,40,134,63,30,69,159,188,57,137,189,160,9,235,109,77,194,6,74,127,65,246,145,235,239,130,91,4,181,68,61,117,80,246,181,221,37,125,237,177,101,195,177,90,26,92,225,255,140,232,33,191,91,209,29,241,70,208,226,21,85,76,215,43,198,31,138,228,63,12,73,3,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new CampaignParticipantEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("4c8fab55-8034-4c0a-8b51-ef02135114fd"));
		}

		#endregion

	}

	#endregion


	#region Class: CampaignParticipantEventsProcess

	/// <exclude/>
	public class CampaignParticipantEventsProcess : CampaignParticipant_CampaignsEventsProcess
	{

		public CampaignParticipantEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

