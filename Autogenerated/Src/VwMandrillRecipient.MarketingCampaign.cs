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
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities.Json.Converters;

	#region Class: VwMandrillRecipientSchema

	/// <exclude/>
	public class VwMandrillRecipientSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public VwMandrillRecipientSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public VwMandrillRecipientSchema(VwMandrillRecipientSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public VwMandrillRecipientSchema(VwMandrillRecipientSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("7a0ca7dc-65b1-4c35-b2c6-9ebfd8bce125");
			RealUId = new Guid("7a0ca7dc-65b1-4c35-b2c6-9ebfd8bce125");
			Name = "VwMandrillRecipient";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("45262819-64d3-4adf-bb0f-9b94e1486e18");
			IsDBView = true;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("8cf566c0-7efe-40ce-835b-da7e6175d994")) == null) {
				Columns.Add(CreateBulkEmailColumn());
			}
			if (Columns.FindByUId(new Guid("9ef336de-da1b-483e-88d0-e158e079f598")) == null) {
				Columns.Add(CreateContactColumn());
			}
			if (Columns.FindByUId(new Guid("f431b046-38d1-4b4f-9f90-666249b56a86")) == null) {
				Columns.Add(CreateEmailAddressColumn());
			}
			if (Columns.FindByUId(new Guid("786a9785-b47f-4336-b539-88ee8cec2463")) == null) {
				Columns.Add(CreateRIdColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateBulkEmailColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("8cf566c0-7efe-40ce-835b-da7e6175d994"),
				Name = @"BulkEmail",
				ReferenceSchemaUId = new Guid("95fbcf9c-e36d-4acd-8b5a-d657de6e30a8"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("7a0ca7dc-65b1-4c35-b2c6-9ebfd8bce125"),
				ModifiedInSchemaUId = new Guid("7a0ca7dc-65b1-4c35-b2c6-9ebfd8bce125"),
				CreatedInPackageId = new Guid("bf106969-ca59-4591-8fd8-1964385773cf")
			};
		}

		protected virtual EntitySchemaColumn CreateContactColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("9ef336de-da1b-483e-88d0-e158e079f598"),
				Name = @"Contact",
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsValueCloneable = false,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("7a0ca7dc-65b1-4c35-b2c6-9ebfd8bce125"),
				ModifiedInSchemaUId = new Guid("7a0ca7dc-65b1-4c35-b2c6-9ebfd8bce125"),
				CreatedInPackageId = new Guid("bf106969-ca59-4591-8fd8-1964385773cf")
			};
		}

		protected virtual EntitySchemaColumn CreateEmailAddressColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("f431b046-38d1-4b4f-9f90-666249b56a86"),
				Name = @"EmailAddress",
				IsValueCloneable = false,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("7a0ca7dc-65b1-4c35-b2c6-9ebfd8bce125"),
				ModifiedInSchemaUId = new Guid("7a0ca7dc-65b1-4c35-b2c6-9ebfd8bce125"),
				CreatedInPackageId = new Guid("bf106969-ca59-4591-8fd8-1964385773cf")
			};
		}

		protected virtual EntitySchemaColumn CreateRIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("786a9785-b47f-4336-b539-88ee8cec2463"),
				Name = @"RId",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("7a0ca7dc-65b1-4c35-b2c6-9ebfd8bce125"),
				ModifiedInSchemaUId = new Guid("7a0ca7dc-65b1-4c35-b2c6-9ebfd8bce125"),
				CreatedInPackageId = new Guid("196dac4c-8195-4488-a569-0010bfda9cdc")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateVwMandrillRecipientEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateVwMandrillRecipientEventsProcessSchema() {
			var schema = new VwMandrillRecipientEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new VwMandrillRecipient(userConnection){Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new VwMandrillRecipient_MarketingCampaignEventsProcess(userConnnection);
		}

		public override object Clone() {
			return new VwMandrillRecipientSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new VwMandrillRecipientSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("7a0ca7dc-65b1-4c35-b2c6-9ebfd8bce125"));
		}

		#endregion

	}

	#endregion

	#region Class: VwMandrillRecipient

	/// <summary>
	/// Contact in bulk email audience.
	/// </summary>
	public class VwMandrillRecipient : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public VwMandrillRecipient(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "VwMandrillRecipient";
		}

		public VwMandrillRecipient(VwMandrillRecipient source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public  Guid BulkEmailId {
			get {
				return GetTypedColumnValue<Guid>("BulkEmailId");
			}
			set {
				SetColumnValue("BulkEmailId", value);
				_bulkEmail = null;
			}
		}

		/// <exclude/>
		public  string BulkEmailName {
			get {
				return GetTypedColumnValue<string>("BulkEmailName");
			}
			set {
				SetColumnValue("BulkEmailName", value);
				if (_bulkEmail != null) {
					_bulkEmail.Name = value;
				}
			}
		}

		private BulkEmail _bulkEmail;
		/// <summary>
		/// Bulk email.
		/// </summary>
		public  BulkEmail BulkEmail {
			get {
				return _bulkEmail ??
					(_bulkEmail = LookupColumnEntities.GetEntity("BulkEmail") as BulkEmail);
			}
		}

		/// <exclude/>
		public  Guid ContactId {
			get {
				return GetTypedColumnValue<Guid>("ContactId");
			}
			set {
				SetColumnValue("ContactId", value);
				_contact = null;
			}
		}

		/// <exclude/>
		public  string ContactName {
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
		public  Contact Contact {
			get {
				return _contact ??
					(_contact = LookupColumnEntities.GetEntity("Contact") as Contact);
			}
		}

		/// <summary>
		/// Email.
		/// </summary>
		public  string EmailAddress {
			get {
				return GetTypedColumnValue<string>("EmailAddress");
			}
			set {
				SetColumnValue("EmailAddress", value);
			}
		}

		/// <summary>
		/// RId.
		/// </summary>
		public  int RId {
			get {
				return GetTypedColumnValue<int>("RId");
			}
			set {
				SetColumnValue("RId", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new VwMandrillRecipient_MarketingCampaignEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("VwMandrillRecipientDeleted", e);
			Inserted += (s, e) => ThrowEvent("VwMandrillRecipientInserted", e);
			Validating += (s, e) => ThrowEvent("VwMandrillRecipientValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new VwMandrillRecipient(this);
		}

		#endregion

	}

	#endregion

	#region Class: VwMandrillRecipient_MarketingCampaignEventsProcess

	/// <exclude/>
	public class VwMandrillRecipient_MarketingCampaignEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_LocalMessageEventsProcess<TEntity> where TEntity : VwMandrillRecipient
	{

		public VwMandrillRecipient_MarketingCampaignEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "VwMandrillRecipient_MarketingCampaignEventsProcess";
			SchemaUId = new Guid("7a0ca7dc-65b1-4c35-b2c6-9ebfd8bce125");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private  Guid InternalSchemaUId {
			get {
				return new Guid("7a0ca7dc-65b1-4c35-b2c6-9ebfd8bce125");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		private ProcessFlowElement _mandrillRecipientInsertedSubProcess;
		public  ProcessFlowElement MandrillRecipientInsertedSubProcess {
			get {
				return _mandrillRecipientInsertedSubProcess ?? (_mandrillRecipientInsertedSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "MandrillRecipientInsertedSubProcess",
					SchemaElementUId = new Guid("751b6163-5422-4bb1-b423-87f50f8b4403"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _mandrillRecipientInsertedScriptTask;
		public  ProcessScriptTask MandrillRecipientInsertedScriptTask {
			get {
				return _mandrillRecipientInsertedScriptTask ?? (_mandrillRecipientInsertedScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "MandrillRecipientInsertedScriptTask",
					SchemaElementUId = new Guid("4c07b882-147a-448b-9667-05dbd5877d6b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = MandrillRecipientInsertedScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _mandrillRecipientInserted;
		public  ProcessFlowElement MandrillRecipientInserted {
			get {
				return _mandrillRecipientInserted ?? (_mandrillRecipientInserted = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "MandrillRecipientInserted",
					SchemaElementUId = new Guid("2d0bf5e8-b830-4c4a-be44-3d4d9547a945"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _mandrillRecipientDeletedSubProcess;
		public  ProcessFlowElement MandrillRecipientDeletedSubProcess {
			get {
				return _mandrillRecipientDeletedSubProcess ?? (_mandrillRecipientDeletedSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "MandrillRecipientDeletedSubProcess",
					SchemaElementUId = new Guid("c652f158-16c3-4cb0-af96-672811bc48c1"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _mandrillRecipientDeleted;
		public  ProcessFlowElement MandrillRecipientDeleted {
			get {
				return _mandrillRecipientDeleted ?? (_mandrillRecipientDeleted = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "MandrillRecipientDeleted",
					SchemaElementUId = new Guid("8bae41ab-7130-42f6-99c4-5d8329c34551"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _mandrillRecipientDeletedScriptTask;
		public  ProcessScriptTask MandrillRecipientDeletedScriptTask {
			get {
				return _mandrillRecipientDeletedScriptTask ?? (_mandrillRecipientDeletedScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "MandrillRecipientDeletedScriptTask",
					SchemaElementUId = new Guid("014fda5c-b5e2-47ce-ae47-9914377f505f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = MandrillRecipientDeletedScriptTaskExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[MandrillRecipientInsertedSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { MandrillRecipientInsertedSubProcess };
			FlowElements[MandrillRecipientInsertedScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { MandrillRecipientInsertedScriptTask };
			FlowElements[MandrillRecipientInserted.SchemaElementUId] = new Collection<ProcessFlowElement> { MandrillRecipientInserted };
			FlowElements[MandrillRecipientDeletedSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { MandrillRecipientDeletedSubProcess };
			FlowElements[MandrillRecipientDeleted.SchemaElementUId] = new Collection<ProcessFlowElement> { MandrillRecipientDeleted };
			FlowElements[MandrillRecipientDeletedScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { MandrillRecipientDeletedScriptTask };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "MandrillRecipientInsertedSubProcess":
						break;
					case "MandrillRecipientInsertedScriptTask":
						break;
					case "MandrillRecipientInserted":
						e.Context.QueueTasks.Enqueue("MandrillRecipientInsertedScriptTask");
						break;
					case "MandrillRecipientDeletedSubProcess":
						break;
					case "MandrillRecipientDeleted":
						e.Context.QueueTasks.Enqueue("MandrillRecipientDeletedScriptTask");
						break;
					case "MandrillRecipientDeletedScriptTask":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("MandrillRecipientInserted");
			ActivatedEventElements.Add("MandrillRecipientDeleted");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "MandrillRecipientInsertedSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "MandrillRecipientInsertedScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "MandrillRecipientInsertedScriptTask";
					result = MandrillRecipientInsertedScriptTask.Execute(context, MandrillRecipientInsertedScriptTaskExecute);
					break;
				case "MandrillRecipientInserted":
					context.QueueTasks.Dequeue();
					context.SenderName = "MandrillRecipientInserted";
					result = MandrillRecipientInserted.Execute(context);
					break;
				case "MandrillRecipientDeletedSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "MandrillRecipientDeleted":
					context.QueueTasks.Dequeue();
					context.SenderName = "MandrillRecipientDeleted";
					result = MandrillRecipientDeleted.Execute(context);
					break;
				case "MandrillRecipientDeletedScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "MandrillRecipientDeletedScriptTask";
					result = MandrillRecipientDeletedScriptTask.Execute(context, MandrillRecipientDeletedScriptTaskExecute);
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

		public virtual bool MandrillRecipientInsertedScriptTaskExecute(ProcessExecutingContext context) {
			
						UpdateBulkEmailRecipientCount(1);
						return true;
		}

		public virtual bool MandrillRecipientDeletedScriptTaskExecute(ProcessExecutingContext context) {
			
						UpdateBulkEmailRecipientCount(-1);
						return true;
		}

		public virtual void UpdateBulkEmailRecipientCount(int incCount) {
			
						var bulkEmailId = Entity.GetTypedColumnValue<Guid>("BulkEmailId");
						if (bulkEmailId == Guid.Empty) {
							return;
						}
						var update = new Update(UserConnection, "BulkEmail")
							.Set("ModifiedOn", Column.Parameter(DateTime.UtcNow))
							.Set("ModifiedById", Column.Parameter(UserConnection.CurrentUser.ContactId))
							.Set("RecipientCount", QueryColumnExpression.Add(new QueryColumnExpression("RecipientCount"),
								Column.Parameter(incCount)))
							.Where("Id").IsEqual(Column.Parameter(bulkEmailId));
						update.Execute();
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "VwMandrillRecipientInserted":
							if (ActivatedEventElements.Contains("MandrillRecipientInserted")) {
							context.QueueTasks.Enqueue("MandrillRecipientInserted");
						}
						break;
					case "VwMandrillRecipientDeleted":
							if (ActivatedEventElements.Contains("MandrillRecipientDeleted")) {
							context.QueueTasks.Enqueue("MandrillRecipientDeleted");
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

	#region Class: VwMandrillRecipient_MarketingCampaignEventsProcess

	/// <exclude/>
	public class VwMandrillRecipient_MarketingCampaignEventsProcess : VwMandrillRecipient_MarketingCampaignEventsProcess<VwMandrillRecipient>
	{

		public VwMandrillRecipient_MarketingCampaignEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: VwMandrillRecipientEventsProcessSchema

	/// <exclude/>
	public class VwMandrillRecipientEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public VwMandrillRecipientEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public VwMandrillRecipientEventsProcessSchema(VwMandrillRecipientEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "VwMandrillRecipient_MarketingCampaignEventsProcess";
			UId = new Guid("e68a8ae0-91e2-4b34-9b81-2bdc714b3373");
			CreatedInPackageId = new Guid("bf106969-ca59-4591-8fd8-1964385773cf");
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
			ProcessSchemaEventSubProcess mandrillrecipientinsertedsubprocess = CreateMandrillRecipientInsertedSubProcessEventSubProcess();
			FlowElements.Add(mandrillrecipientinsertedsubprocess);
			ProcessSchemaEventSubProcess mandrillrecipientdeletedsubprocess = CreateMandrillRecipientDeletedSubProcessEventSubProcess();
			FlowElements.Add(mandrillrecipientdeletedsubprocess);
			ProcessSchemaScriptTask mandrillrecipientinsertedscripttask = CreateMandrillRecipientInsertedScriptTaskScriptTask();
			mandrillrecipientinsertedsubprocess.FlowElements.Add(mandrillrecipientinsertedscripttask);
			ProcessSchemaStartMessageEvent mandrillrecipientinserted = CreateMandrillRecipientInsertedStartMessageEvent();
			mandrillrecipientinsertedsubprocess.FlowElements.Add(mandrillrecipientinserted);
			ProcessSchemaStartMessageEvent mandrillrecipientdeleted = CreateMandrillRecipientDeletedStartMessageEvent();
			mandrillrecipientdeletedsubprocess.FlowElements.Add(mandrillrecipientdeleted);
			ProcessSchemaScriptTask mandrillrecipientdeletedscripttask = CreateMandrillRecipientDeletedScriptTaskScriptTask();
			mandrillrecipientdeletedsubprocess.FlowElements.Add(mandrillrecipientdeletedscripttask);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("0c05d402-0c94-4937-850b-02c8e64e78ad"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("56ea33ea-e32a-430c-959f-44e40c0eb1dc"),
				CreatedInSchemaUId = new Guid("e68a8ae0-91e2-4b34-9b81-2bdc714b3373"),
				CurveCenterPosition = new Point(397, 73),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("e68a8ae0-91e2-4b34-9b81-2bdc714b3373"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("2d0bf5e8-b830-4c4a-be44-3d4d9547a945"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("4c07b882-147a-448b-9667-05dbd5877d6b"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("e7baf4f0-1056-446e-bafc-c5d5303e7fdb"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("56ea33ea-e32a-430c-959f-44e40c0eb1dc"),
				CreatedInSchemaUId = new Guid("e68a8ae0-91e2-4b34-9b81-2bdc714b3373"),
				CurveCenterPosition = new Point(468, 80),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("e68a8ae0-91e2-4b34-9b81-2bdc714b3373"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("8bae41ab-7130-42f6-99c4-5d8329c34551"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("014fda5c-b5e2-47ce-ae47-9914377f505f"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("705b3bcb-338b-4e77-b049-57147b33f114"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("56ea33ea-e32a-430c-959f-44e40c0eb1dc"),
				CreatedInSchemaUId = new Guid("e68a8ae0-91e2-4b34-9b81-2bdc714b3373"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("e68a8ae0-91e2-4b34-9b81-2bdc714b3373"),
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
				UId = new Guid("7272bdc7-1752-4151-9d2d-af7add612039"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("705b3bcb-338b-4e77-b049-57147b33f114"),
				CreatedInOwnerSchemaUId = new Guid("7a0ca7dc-65b1-4c35-b2c6-9ebfd8bce125"),
				CreatedInPackageId = new Guid("56ea33ea-e32a-430c-959f-44e40c0eb1dc"),
				CreatedInSchemaUId = new Guid("e68a8ae0-91e2-4b34-9b81-2bdc714b3373"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("e68a8ae0-91e2-4b34-9b81-2bdc714b3373"),
				Name = @"Lane1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(29, 0),
				Size = new Size(883, 177),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaEventSubProcess CreateMandrillRecipientInsertedSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaMandrillRecipientInsertedSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("751b6163-5422-4bb1-b423-87f50f8b4403"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7272bdc7-1752-4151-9d2d-af7add612039"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("56ea33ea-e32a-430c-959f-44e40c0eb1dc"),
				CreatedInSchemaUId = new Guid("e68a8ae0-91e2-4b34-9b81-2bdc714b3373"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("e68a8ae0-91e2-4b34-9b81-2bdc714b3373"),
				Name = @"MandrillRecipientInsertedSubProcess",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(43, 9),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(242, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaMandrillRecipientInsertedSubProcess;
		}

		protected virtual ProcessSchemaScriptTask CreateMandrillRecipientInsertedScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("4c07b882-147a-448b-9667-05dbd5877d6b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("751b6163-5422-4bb1-b423-87f50f8b4403"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("56ea33ea-e32a-430c-959f-44e40c0eb1dc"),
				CreatedInSchemaUId = new Guid("e68a8ae0-91e2-4b34-9b81-2bdc714b3373"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("e68a8ae0-91e2-4b34-9b81-2bdc714b3373"),
				Name = @"MandrillRecipientInsertedScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(140, 35),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,227,229,226,228,228,12,45,72,73,44,73,117,42,205,201,118,205,77,204,204,9,74,77,206,44,200,76,205,43,113,206,47,205,43,209,48,212,180,230,5,169,42,74,45,41,45,202,83,40,41,42,77,181,6,0,101,188,30,36,55,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateMandrillRecipientInsertedStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("2d0bf5e8-b830-4c4a-be44-3d4d9547a945"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("751b6163-5422-4bb1-b423-87f50f8b4403"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("56ea33ea-e32a-430c-959f-44e40c0eb1dc"),
				CreatedInSchemaUId = new Guid("e68a8ae0-91e2-4b34-9b81-2bdc714b3373"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"VwMandrillRecipientInserted",
				ModifiedInSchemaUId = new Guid("e68a8ae0-91e2-4b34-9b81-2bdc714b3373"),
				Name = @"MandrillRecipientInserted",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(28, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateMandrillRecipientDeletedSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaMandrillRecipientDeletedSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("c652f158-16c3-4cb0-af96-672811bc48c1"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7272bdc7-1752-4151-9d2d-af7add612039"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("56ea33ea-e32a-430c-959f-44e40c0eb1dc"),
				CreatedInSchemaUId = new Guid("e68a8ae0-91e2-4b34-9b81-2bdc714b3373"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("e68a8ae0-91e2-4b34-9b81-2bdc714b3373"),
				Name = @"MandrillRecipientDeletedSubProcess",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(372, 9),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(276, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaMandrillRecipientDeletedSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateMandrillRecipientDeletedStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("8bae41ab-7130-42f6-99c4-5d8329c34551"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c652f158-16c3-4cb0-af96-672811bc48c1"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("56ea33ea-e32a-430c-959f-44e40c0eb1dc"),
				CreatedInSchemaUId = new Guid("e68a8ae0-91e2-4b34-9b81-2bdc714b3373"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"VwMandrillRecipientDeleted",
				ModifiedInSchemaUId = new Guid("e68a8ae0-91e2-4b34-9b81-2bdc714b3373"),
				Name = @"MandrillRecipientDeleted",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(43, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateMandrillRecipientDeletedScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("014fda5c-b5e2-47ce-ae47-9914377f505f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c652f158-16c3-4cb0-af96-672811bc48c1"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("56ea33ea-e32a-430c-959f-44e40c0eb1dc"),
				CreatedInSchemaUId = new Guid("e68a8ae0-91e2-4b34-9b81-2bdc714b3373"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("e68a8ae0-91e2-4b34-9b81-2bdc714b3373"),
				Name = @"MandrillRecipientDeletedScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(134, 37),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,227,229,226,228,228,12,45,72,73,44,73,117,42,205,201,118,205,77,204,204,9,74,77,206,44,200,76,205,43,113,206,47,205,43,209,208,53,212,180,230,5,41,43,74,45,41,45,202,83,40,41,42,77,181,6,0,33,230,226,15,56,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateUpdateBulkEmailRecipientCountMethod());
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
				UId = new Guid("d14e5b85-d883-4e85-9a22-1d55a06096a5"),
				Name = "Terrasoft.Core.Entities",
				Alias = "",
				CreatedInPackageId = new Guid("56ea33ea-e32a-430c-959f-44e40c0eb1dc")
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
		}

		protected virtual SchemaMethod CreateUpdateBulkEmailRecipientCountMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("855fdedb-ab94-44d8-a19c-eb6398c0034f"),
				Name = "UpdateBulkEmailRecipientCount",
				CreatedInSchemaUId = new Guid("e68a8ae0-91e2-4b34-9b81-2bdc714b3373"),
				CreatedInPackageId = new Guid("56ea33ea-e32a-430c-959f-44e40c0eb1dc"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("06184448-5f5f-4f82-8ce8-8bb34a5ca7c5"),
				Name = "incCount",
				CreatedInSchemaUId = new Guid("e68a8ae0-91e2-4b34-9b81-2bdc714b3373"),
				ModifiedInSchemaUId = new Guid("e68a8ae0-91e2-4b34-9b81-2bdc714b3373"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "int",
				CreatedInPackageId = new Guid("56ea33ea-e32a-430c-959f-44e40c0eb1dc")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,145,205,78,132,48,20,133,215,152,240,14,77,87,109,66,250,2,227,152,56,72,38,44,252,31,116,93,233,157,216,8,45,150,91,103,136,241,221,45,160,142,4,150,109,207,249,206,185,189,241,89,20,69,31,210,145,23,95,189,101,181,212,85,174,200,154,100,6,53,118,98,11,184,235,26,80,169,173,124,109,158,100,229,225,124,235,181,186,96,116,115,210,83,190,138,123,140,222,19,54,193,172,73,47,22,89,221,96,199,201,231,32,138,28,160,119,102,116,124,197,191,241,190,81,18,33,36,27,56,144,98,56,176,162,5,151,90,99,160,68,109,77,66,78,153,148,143,44,241,8,200,232,181,85,122,175,65,221,26,154,144,177,170,184,147,78,214,128,224,216,85,64,237,116,13,162,192,242,198,30,248,162,117,211,133,49,22,204,211,10,34,245,206,129,193,254,86,132,107,148,37,230,106,74,124,128,82,55,58,136,82,235,13,6,230,189,7,215,141,224,236,216,56,104,219,158,116,169,20,235,71,93,124,157,81,120,50,70,68,179,130,218,148,131,132,255,181,120,126,5,7,140,246,107,17,121,155,189,123,89,177,153,237,223,154,248,207,246,198,13,136,236,8,165,15,159,207,87,223,163,240,27,47,27,2,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new VwMandrillRecipientEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e68a8ae0-91e2-4b34-9b81-2bdc714b3373"));
		}

		#endregion

	}

	#endregion


	#region Class: VwMandrillRecipientEventsProcess

	/// <exclude/>
	public class VwMandrillRecipientEventsProcess : VwMandrillRecipient_MarketingCampaignEventsProcess
	{

		public VwMandrillRecipientEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

