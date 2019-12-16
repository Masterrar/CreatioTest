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

	#region Class: QueueSchema

	/// <exclude/>
	public class QueueSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public QueueSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public QueueSchema(QueueSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public QueueSchema(QueueSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("c434cf4e-85f5-48e3-b545-bd3fe9c882ab");
			RealUId = new Guid("c434cf4e-85f5-48e3-b545-bd3fe9c882ab");
			Name = "Queue";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("f218b7b3-8c78-4ff0-aa0a-44d361bf4ae4");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializePrimaryDisplayColumn() {
			base.InitializePrimaryDisplayColumn();
			PrimaryDisplayColumn = CreateNameColumn();
			if (Columns.FindByUId(PrimaryDisplayColumn.UId) == null) {
				Columns.Add(PrimaryDisplayColumn);
			}
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("3f9570b5-7586-4d30-8fd9-270b48f119e5")) == null) {
				Columns.Add(CreateEntitySchemaUIdColumn());
			}
			if (Columns.FindByUId(new Guid("221254af-1f3e-4307-afae-07b0b4ea6fa8")) == null) {
				Columns.Add(CreatePriorityColumn());
			}
			if (Columns.FindByUId(new Guid("0ed6afd7-e32c-4c37-b56b-b7ad5fac5ab6")) == null) {
				Columns.Add(CreateStatusColumn());
			}
			if (Columns.FindByUId(new Guid("cc67082f-423a-4ba1-9725-697be295287c")) == null) {
				Columns.Add(CreateProcessSchemaUIdColumn());
			}
			if (Columns.FindByUId(new Guid("a61a55d4-1145-40f6-bf9b-cd8782490b70")) == null) {
				Columns.Add(CreateEntitySchemaCaptionColumn());
			}
			if (Columns.FindByUId(new Guid("20947e38-8e7c-4aec-b9eb-2423f68a902c")) == null) {
				Columns.Add(CreateProcessSchemaCaptionColumn());
			}
			if (Columns.FindByUId(new Guid("b4d49d9d-6e66-4713-bf29-50636fc8a992")) == null) {
				Columns.Add(CreateFilterDataColumn());
			}
			if (Columns.FindByUId(new Guid("d3081b72-5be4-42aa-8416-d3b9a39b7395")) == null) {
				Columns.Add(CreateFilterEditDataColumn());
			}
			if (Columns.FindByUId(new Guid("942e7c5a-29da-4ea8-ad7c-17ebb1222459")) == null) {
				Columns.Add(CreateIsManuallyFillingColumn());
			}
			if (Columns.FindByUId(new Guid("c303a54e-e7fc-4836-854f-82757798e1d5")) == null) {
				Columns.Add(CreateQueueEntitySchemaColumn());
			}
			if (Columns.FindByUId(new Guid("786afe14-f0ad-425b-990a-a4dda251099f")) == null) {
				Columns.Add(CreateBusinessProcessSchemaColumn());
			}
			if (Columns.FindByUId(new Guid("621442f1-3fb1-4ea0-ba1d-7f00029c93b2")) == null) {
				Columns.Add(CreateQueueUpdateFrequencyColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("6cae06b4-b7bc-4c70-a5b3-f3d43c046206"),
				Name = @"Name",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("c434cf4e-85f5-48e3-b545-bd3fe9c882ab"),
				ModifiedInSchemaUId = new Guid("c434cf4e-85f5-48e3-b545-bd3fe9c882ab"),
				CreatedInPackageId = new Guid("468cfeb3-dd71-4fe5-8b71-41582036f904")
			};
		}

		protected virtual EntitySchemaColumn CreateEntitySchemaUIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("3f9570b5-7586-4d30-8fd9-270b48f119e5"),
				Name = @"EntitySchemaUId",
				IsIndexed = true,
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("c434cf4e-85f5-48e3-b545-bd3fe9c882ab"),
				ModifiedInSchemaUId = new Guid("c434cf4e-85f5-48e3-b545-bd3fe9c882ab"),
				CreatedInPackageId = new Guid("f218b7b3-8c78-4ff0-aa0a-44d361bf4ae4")
			};
		}

		protected virtual EntitySchemaColumn CreatePriorityColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("221254af-1f3e-4307-afae-07b0b4ea6fa8"),
				Name = @"Priority",
				ReferenceSchemaUId = new Guid("eb2bc9f1-e40b-45f2-a8c2-4b8b9b6b6f65"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("c434cf4e-85f5-48e3-b545-bd3fe9c882ab"),
				ModifiedInSchemaUId = new Guid("c434cf4e-85f5-48e3-b545-bd3fe9c882ab"),
				CreatedInPackageId = new Guid("f218b7b3-8c78-4ff0-aa0a-44d361bf4ae4")
			};
		}

		protected virtual EntitySchemaColumn CreateStatusColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("0ed6afd7-e32c-4c37-b56b-b7ad5fac5ab6"),
				Name = @"Status",
				ReferenceSchemaUId = new Guid("749b84e0-9db9-4883-9303-ffc09ea14ecc"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("c434cf4e-85f5-48e3-b545-bd3fe9c882ab"),
				ModifiedInSchemaUId = new Guid("c434cf4e-85f5-48e3-b545-bd3fe9c882ab"),
				CreatedInPackageId = new Guid("f218b7b3-8c78-4ff0-aa0a-44d361bf4ae4")
			};
		}

		protected virtual EntitySchemaColumn CreateProcessSchemaUIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("cc67082f-423a-4ba1-9725-697be295287c"),
				Name = @"ProcessSchemaUId",
				IsIndexed = true,
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("c434cf4e-85f5-48e3-b545-bd3fe9c882ab"),
				ModifiedInSchemaUId = new Guid("c434cf4e-85f5-48e3-b545-bd3fe9c882ab"),
				CreatedInPackageId = new Guid("f218b7b3-8c78-4ff0-aa0a-44d361bf4ae4")
			};
		}

		protected virtual EntitySchemaColumn CreateEntitySchemaCaptionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("a61a55d4-1145-40f6-bf9b-cd8782490b70"),
				Name = @"EntitySchemaCaption",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("c434cf4e-85f5-48e3-b545-bd3fe9c882ab"),
				ModifiedInSchemaUId = new Guid("c434cf4e-85f5-48e3-b545-bd3fe9c882ab"),
				CreatedInPackageId = new Guid("7be0af39-38cd-442a-b589-d8f3ef3f4d19")
			};
		}

		protected virtual EntitySchemaColumn CreateProcessSchemaCaptionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("20947e38-8e7c-4aec-b9eb-2423f68a902c"),
				Name = @"ProcessSchemaCaption",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("c434cf4e-85f5-48e3-b545-bd3fe9c882ab"),
				ModifiedInSchemaUId = new Guid("c434cf4e-85f5-48e3-b545-bd3fe9c882ab"),
				CreatedInPackageId = new Guid("7be0af39-38cd-442a-b589-d8f3ef3f4d19")
			};
		}

		protected virtual EntitySchemaColumn CreateFilterDataColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("b4d49d9d-6e66-4713-bf29-50636fc8a992"),
				Name = @"FilterData",
				CreatedInSchemaUId = new Guid("c434cf4e-85f5-48e3-b545-bd3fe9c882ab"),
				ModifiedInSchemaUId = new Guid("c434cf4e-85f5-48e3-b545-bd3fe9c882ab"),
				CreatedInPackageId = new Guid("cbb457cb-1ef4-428e-937c-db6aedb72e75")
			};
		}

		protected virtual EntitySchemaColumn CreateFilterEditDataColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("d3081b72-5be4-42aa-8416-d3b9a39b7395"),
				Name = @"FilterEditData",
				CreatedInSchemaUId = new Guid("c434cf4e-85f5-48e3-b545-bd3fe9c882ab"),
				ModifiedInSchemaUId = new Guid("c434cf4e-85f5-48e3-b545-bd3fe9c882ab"),
				CreatedInPackageId = new Guid("cbb457cb-1ef4-428e-937c-db6aedb72e75")
			};
		}

		protected virtual EntitySchemaColumn CreateIsManuallyFillingColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("942e7c5a-29da-4ea8-ad7c-17ebb1222459"),
				Name = @"IsManuallyFilling",
				CreatedInSchemaUId = new Guid("c434cf4e-85f5-48e3-b545-bd3fe9c882ab"),
				ModifiedInSchemaUId = new Guid("c434cf4e-85f5-48e3-b545-bd3fe9c882ab"),
				CreatedInPackageId = new Guid("b37272aa-ca79-4db2-9717-1c02e42cc793"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"False"
				}
			};
		}

		protected virtual EntitySchemaColumn CreateQueueEntitySchemaColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("c303a54e-e7fc-4836-854f-82757798e1d5"),
				Name = @"QueueEntitySchema",
				ReferenceSchemaUId = new Guid("c5cc8540-b4cf-483e-a440-3e3347de8a42"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				IsWeakReference = true,
				CreatedInSchemaUId = new Guid("c434cf4e-85f5-48e3-b545-bd3fe9c882ab"),
				ModifiedInSchemaUId = new Guid("c434cf4e-85f5-48e3-b545-bd3fe9c882ab"),
				CreatedInPackageId = new Guid("36ba612f-971e-4193-8230-081e5d9f826d")
			};
		}

		protected virtual EntitySchemaColumn CreateBusinessProcessSchemaColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("786afe14-f0ad-425b-990a-a4dda251099f"),
				Name = @"BusinessProcessSchema",
				ReferenceSchemaUId = new Guid("93b95b14-135f-4692-94f3-4d974fe74054"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				IsWeakReference = true,
				CreatedInSchemaUId = new Guid("c434cf4e-85f5-48e3-b545-bd3fe9c882ab"),
				ModifiedInSchemaUId = new Guid("c434cf4e-85f5-48e3-b545-bd3fe9c882ab"),
				CreatedInPackageId = new Guid("36ba612f-971e-4193-8230-081e5d9f826d")
			};
		}

		protected virtual EntitySchemaColumn CreateQueueUpdateFrequencyColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("621442f1-3fb1-4ea0-ba1d-7f00029c93b2"),
				Name = @"QueueUpdateFrequency",
				ReferenceSchemaUId = new Guid("658c1af2-df48-464c-9257-0245f5460090"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("c434cf4e-85f5-48e3-b545-bd3fe9c882ab"),
				ModifiedInSchemaUId = new Guid("c434cf4e-85f5-48e3-b545-bd3fe9c882ab"),
				CreatedInPackageId = new Guid("96ba3f81-7af1-43c9-9a5b-ab40bf0d009a"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"b5f98e01-f990-4226-a012-13d5586d4fe6"
				}
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateQueueEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateQueueEventsProcessSchema() {
			var schema = new QueueEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new Queue(userConnection){Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new Queue_OperatorSingleWindowEventsProcess(userConnnection);
		}

		public override object Clone() {
			return new QueueSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new QueueSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c434cf4e-85f5-48e3-b545-bd3fe9c882ab"));
		}

		#endregion

	}

	#endregion

	#region Class: Queue

	/// <summary>
	/// Queue.
	/// </summary>
	public class Queue : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public Queue(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Queue";
		}

		public Queue(Queue source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Name.
		/// </summary>
		public  string Name {
			get {
				return GetTypedColumnValue<string>("Name");
			}
			set {
				SetColumnValue("Name", value);
			}
		}

		/// <summary>
		/// Deprecated queue.
		/// </summary>
		public  Guid EntitySchemaUId {
			get {
				return GetTypedColumnValue<Guid>("EntitySchemaUId");
			}
			set {
				SetColumnValue("EntitySchemaUId", value);
			}
		}

		/// <exclude/>
		public  Guid PriorityId {
			get {
				return GetTypedColumnValue<Guid>("PriorityId");
			}
			set {
				SetColumnValue("PriorityId", value);
				_priority = null;
			}
		}

		/// <exclude/>
		public  string PriorityName {
			get {
				return GetTypedColumnValue<string>("PriorityName");
			}
			set {
				SetColumnValue("PriorityName", value);
				if (_priority != null) {
					_priority.Name = value;
				}
			}
		}

		private QueuePriority _priority;
		/// <summary>
		/// Priority.
		/// </summary>
		public  QueuePriority Priority {
			get {
				return _priority ??
					(_priority = LookupColumnEntities.GetEntity("Priority") as QueuePriority);
			}
		}

		/// <exclude/>
		public  Guid StatusId {
			get {
				return GetTypedColumnValue<Guid>("StatusId");
			}
			set {
				SetColumnValue("StatusId", value);
				_status = null;
			}
		}

		/// <exclude/>
		public  string StatusName {
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

		private QueueStatus _status;
		/// <summary>
		/// Status.
		/// </summary>
		public  QueueStatus Status {
			get {
				return _status ??
					(_status = LookupColumnEntities.GetEntity("Status") as QueueStatus);
			}
		}

		/// <summary>
		/// Deprecated process.
		/// </summary>
		public  Guid ProcessSchemaUId {
			get {
				return GetTypedColumnValue<Guid>("ProcessSchemaUId");
			}
			set {
				SetColumnValue("ProcessSchemaUId", value);
			}
		}

		/// <summary>
		/// Deprecated queue title.
		/// </summary>
		public  string EntitySchemaCaption {
			get {
				return GetTypedColumnValue<string>("EntitySchemaCaption");
			}
			set {
				SetColumnValue("EntitySchemaCaption", value);
			}
		}

		/// <summary>
		/// Deprecated process title.
		/// </summary>
		public  string ProcessSchemaCaption {
			get {
				return GetTypedColumnValue<string>("ProcessSchemaCaption");
			}
			set {
				SetColumnValue("ProcessSchemaCaption", value);
			}
		}

		/// <summary>
		/// Queue object filter.
		/// </summary>
		public  string FilterData {
			get {
				return GetTypedColumnValue<string>("FilterData");
			}
			set {
				SetColumnValue("FilterData", value);
			}
		}

		/// <summary>
		/// Filtering object - Queue object.
		/// </summary>
		public  string FilterEditData {
			get {
				return GetTypedColumnValue<string>("FilterEditData");
			}
			set {
				SetColumnValue("FilterEditData", value);
			}
		}

		/// <summary>
		/// Fill in manually.
		/// </summary>
		public  bool IsManuallyFilling {
			get {
				return GetTypedColumnValue<bool>("IsManuallyFilling");
			}
			set {
				SetColumnValue("IsManuallyFilling", value);
			}
		}

		/// <exclude/>
		public  Guid QueueEntitySchemaId {
			get {
				return GetTypedColumnValue<Guid>("QueueEntitySchemaId");
			}
			set {
				SetColumnValue("QueueEntitySchemaId", value);
				_queueEntitySchema = null;
			}
		}

		/// <exclude/>
		public  string QueueEntitySchemaCaption {
			get {
				return GetTypedColumnValue<string>("QueueEntitySchemaCaption");
			}
			set {
				SetColumnValue("QueueEntitySchemaCaption", value);
				if (_queueEntitySchema != null) {
					_queueEntitySchema.Caption = value;
				}
			}
		}

		private VwQueueSysSchema _queueEntitySchema;
		/// <summary>
		/// Queue type.
		/// </summary>
		public  VwQueueSysSchema QueueEntitySchema {
			get {
				return _queueEntitySchema ??
					(_queueEntitySchema = LookupColumnEntities.GetEntity("QueueEntitySchema") as VwQueueSysSchema);
			}
		}

		/// <exclude/>
		public  Guid BusinessProcessSchemaId {
			get {
				return GetTypedColumnValue<Guid>("BusinessProcessSchemaId");
			}
			set {
				SetColumnValue("BusinessProcessSchemaId", value);
				_businessProcessSchema = null;
			}
		}

		/// <exclude/>
		public  string BusinessProcessSchemaCaption {
			get {
				return GetTypedColumnValue<string>("BusinessProcessSchemaCaption");
			}
			set {
				SetColumnValue("BusinessProcessSchemaCaption", value);
				if (_businessProcessSchema != null) {
					_businessProcessSchema.Caption = value;
				}
			}
		}

		private VwQueueSysProcess _businessProcessSchema;
		/// <summary>
		/// Business process.
		/// </summary>
		public  VwQueueSysProcess BusinessProcessSchema {
			get {
				return _businessProcessSchema ??
					(_businessProcessSchema = LookupColumnEntities.GetEntity("BusinessProcessSchema") as VwQueueSysProcess);
			}
		}

		/// <exclude/>
		public  Guid QueueUpdateFrequencyId {
			get {
				return GetTypedColumnValue<Guid>("QueueUpdateFrequencyId");
			}
			set {
				SetColumnValue("QueueUpdateFrequencyId", value);
				_queueUpdateFrequency = null;
			}
		}

		/// <exclude/>
		public  string QueueUpdateFrequencyName {
			get {
				return GetTypedColumnValue<string>("QueueUpdateFrequencyName");
			}
			set {
				SetColumnValue("QueueUpdateFrequencyName", value);
				if (_queueUpdateFrequency != null) {
					_queueUpdateFrequency.Name = value;
				}
			}
		}

		private QueueUpdateFrequency _queueUpdateFrequency;
		/// <summary>
		/// Update frequency.
		/// </summary>
		public  QueueUpdateFrequency QueueUpdateFrequency {
			get {
				return _queueUpdateFrequency ??
					(_queueUpdateFrequency = LookupColumnEntities.GetEntity("QueueUpdateFrequency") as QueueUpdateFrequency);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new Queue_OperatorSingleWindowEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("QueueDeleted", e);
			Saved += (s, e) => ThrowEvent("QueueSaved", e);
			Validating += (s, e) => ThrowEvent("QueueValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new Queue(this);
		}

		#endregion

	}

	#endregion

	#region Class: Queue_OperatorSingleWindowEventsProcess

	/// <exclude/>
	public class Queue_OperatorSingleWindowEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_LocalMessageEventsProcess<TEntity> where TEntity : Queue
	{

		public Queue_OperatorSingleWindowEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Queue_OperatorSingleWindowEventsProcess";
			SchemaUId = new Guid("c434cf4e-85f5-48e3-b545-bd3fe9c882ab");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			_detailKeyTemplate = () => {{ return "QueueDetail_"; }};
			InitializeFlowElements();
		}

		#region Properties: Private

		private  Guid InternalSchemaUId {
			get {
				return new Guid("c434cf4e-85f5-48e3-b545-bd3fe9c882ab");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		private Func<string> _detailKeyTemplate;
		public  virtual string DetailKeyTemplate {
			get {
				return (_detailKeyTemplate ?? (_detailKeyTemplate = () => null)).Invoke();
			}
			set {
				_detailKeyTemplate = () => { return value; };
			}
		}

		private ProcessFlowElement _deletedEventSubProcess;
		public  ProcessFlowElement DeletedEventSubProcess {
			get {
				return _deletedEventSubProcess ?? (_deletedEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "DeletedEventSubProcess",
					SchemaElementUId = new Guid("ee266ef9-274d-4e97-97e3-4df4f5b6e0e0"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _queueDeletedMessage;
		public  ProcessFlowElement QueueDeletedMessage {
			get {
				return _queueDeletedMessage ?? (_queueDeletedMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "QueueDeletedMessage",
					SchemaElementUId = new Guid("2aad1228-4b1a-4f8b-9516-34609add7e55"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _clearProfileScriptTask;
		public  ProcessScriptTask ClearProfileScriptTask {
			get {
				return _clearProfileScriptTask ?? (_clearProfileScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ClearProfileScriptTask",
					SchemaElementUId = new Guid("5eda0b61-311e-46cf-acc2-b9867aa345c7"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ClearProfileScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcess3_47e8fdb1426143a5a74c1d1c29370234;
		public  ProcessFlowElement EventSubProcess3_47e8fdb1426143a5a74c1d1c29370234 {
			get {
				return _eventSubProcess3_47e8fdb1426143a5a74c1d1c29370234 ?? (_eventSubProcess3_47e8fdb1426143a5a74c1d1c29370234 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess3_47e8fdb1426143a5a74c1d1c29370234",
					SchemaElementUId = new Guid("47e8fdb1-4261-43a5-a74c-1d1c29370234"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _queueSavedMessage;
		public  ProcessFlowElement QueueSavedMessage {
			get {
				return _queueSavedMessage ?? (_queueSavedMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "QueueSavedMessage",
					SchemaElementUId = new Guid("1e6c093a-28ab-438c-bca7-4d0215e3162d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTask_QueueSaved;
		public  ProcessScriptTask ScriptTask_QueueSaved {
			get {
				return _scriptTask_QueueSaved ?? (_scriptTask_QueueSaved = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask_QueueSaved",
					SchemaElementUId = new Guid("a12c62b6-7764-4fb3-b8ab-c8c98b039393"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask_QueueSavedExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[DeletedEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { DeletedEventSubProcess };
			FlowElements[QueueDeletedMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { QueueDeletedMessage };
			FlowElements[ClearProfileScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { ClearProfileScriptTask };
			FlowElements[EventSubProcess3_47e8fdb1426143a5a74c1d1c29370234.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess3_47e8fdb1426143a5a74c1d1c29370234 };
			FlowElements[QueueSavedMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { QueueSavedMessage };
			FlowElements[ScriptTask_QueueSaved.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask_QueueSaved };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "DeletedEventSubProcess":
						break;
					case "QueueDeletedMessage":
						e.Context.QueueTasks.Enqueue("ClearProfileScriptTask");
						break;
					case "ClearProfileScriptTask":
						break;
					case "EventSubProcess3_47e8fdb1426143a5a74c1d1c29370234":
						break;
					case "QueueSavedMessage":
						e.Context.QueueTasks.Enqueue("ScriptTask_QueueSaved");
						break;
					case "ScriptTask_QueueSaved":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("QueueDeletedMessage");
			ActivatedEventElements.Add("QueueSavedMessage");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "DeletedEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "QueueDeletedMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "QueueDeletedMessage";
					result = QueueDeletedMessage.Execute(context);
					break;
				case "ClearProfileScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "ClearProfileScriptTask";
					result = ClearProfileScriptTask.Execute(context, ClearProfileScriptTaskExecute);
					break;
				case "EventSubProcess3_47e8fdb1426143a5a74c1d1c29370234":
					context.QueueTasks.Dequeue();
					break;
				case "QueueSavedMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "QueueSavedMessage";
					result = QueueSavedMessage.Execute(context);
					break;
				case "ScriptTask_QueueSaved":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask_QueueSaved";
					result = ScriptTask_QueueSaved.Execute(context, ScriptTask_QueueSavedExecute);
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

		public virtual bool ClearProfileScriptTaskExecute(ProcessExecutingContext context) {
			ClearProfile();
			return true;
		}

		public virtual bool ScriptTask_QueueSavedExecute(ProcessExecutingContext context) {
			QueueCacheHelper.ClearCache();
			return true;
		}

		public virtual void ClearProfile() {
			var dataValueTypeManager = 
				(DataValueTypeManager)UserConnection.AppManagerProvider.GetManager("DataValueTypeManager");
			var textDataValueType = (TextDataValueType)dataValueTypeManager.GetInstanceByName("ShortText");
			textDataValueType.IsUnicode = true;
			var delete = new Delete(this.UserConnection)
				.From("SysProfileData")
				.Where("Key").ConsistsWith(new QueryParameter("DetailKeyTemplate", DetailKeyTemplate))
				.And().Not().Exists(
					new Select(UserConnection)
					.Column("Queue", "Id")
					.From("Queue")
					.Where("SysProfileData", "Key").EndsWith(Func.Cast("Id", textDataValueType))
				) as Delete;
			delete.Execute();
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "QueueDeleted":
							if (ActivatedEventElements.Contains("QueueDeletedMessage")) {
							context.QueueTasks.Enqueue("QueueDeletedMessage");
						}
						break;
					case "QueueSaved":
							if (ActivatedEventElements.Contains("QueueSavedMessage")) {
							context.QueueTasks.Enqueue("QueueSavedMessage");
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

	#region Class: Queue_OperatorSingleWindowEventsProcess

	/// <exclude/>
	public class Queue_OperatorSingleWindowEventsProcess : Queue_OperatorSingleWindowEventsProcess<Queue>
	{

		public Queue_OperatorSingleWindowEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: QueueEventsProcessSchema

	/// <exclude/>
	public class QueueEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public QueueEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public QueueEventsProcessSchema(QueueEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "Queue_OperatorSingleWindowEventsProcess";
			UId = new Guid("d62091ef-cae4-41fe-b9c9-9cb7afcd5131");
			CreatedInPackageId = new Guid("f218b7b3-8c78-4ff0-aa0a-44d361bf4ae4");
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

		protected virtual ProcessSchemaParameter CreateDetailKeyTemplateParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("4f48ecfc-fb57-47ac-9e8c-aa3f863b0633"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("d62091ef-cae4-41fe-b9c9-9cb7afcd5131"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("d62091ef-cae4-41fe-b9c9-9cb7afcd5131"),
				Name = @"DetailKeyTemplate",
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("ShortText"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("d62091ef-cae4-41fe-b9c9-9cb7afcd5131"),
				},
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateDetailKeyTemplateParameter());
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet1 = CreateLaneSet1LaneSet();
			LaneSets.Add(schemaLaneSet1);
			ProcessSchemaLane schemaLane1 = CreateLane1Lane();
			schemaLaneSet1.Lanes.Add(schemaLane1);
			ProcessSchemaEventSubProcess deletedeventsubprocess = CreateDeletedEventSubProcessEventSubProcess();
			FlowElements.Add(deletedeventsubprocess);
			ProcessSchemaEventSubProcess eventsubprocess3_47e8fdb1426143a5a74c1d1c29370234 = CreateEventSubProcess3_47e8fdb1426143a5a74c1d1c29370234EventSubProcess();
			FlowElements.Add(eventsubprocess3_47e8fdb1426143a5a74c1d1c29370234);
			ProcessSchemaStartMessageEvent queuedeletedmessage = CreateQueueDeletedMessageStartMessageEvent();
			deletedeventsubprocess.FlowElements.Add(queuedeletedmessage);
			ProcessSchemaScriptTask clearprofilescripttask = CreateClearProfileScriptTaskScriptTask();
			deletedeventsubprocess.FlowElements.Add(clearprofilescripttask);
			ProcessSchemaStartMessageEvent queuesavedmessage = CreateQueueSavedMessageStartMessageEvent();
			eventsubprocess3_47e8fdb1426143a5a74c1d1c29370234.FlowElements.Add(queuesavedmessage);
			ProcessSchemaScriptTask scripttask_queuesaved = CreateScriptTask_QueueSavedScriptTask();
			eventsubprocess3_47e8fdb1426143a5a74c1d1c29370234.FlowElements.Add(scripttask_queuesaved);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2_ff903a836a5f46a4a7e799d0d81132ecSequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("7c8b55cd-3733-4585-aa91-40a71957a054"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("468cfeb3-dd71-4fe5-8b71-41582036f904"),
				CreatedInSchemaUId = new Guid("d62091ef-cae4-41fe-b9c9-9cb7afcd5131"),
				CurveCenterPosition = new Point(192, 82),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("d62091ef-cae4-41fe-b9c9-9cb7afcd5131"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("2aad1228-4b1a-4f8b-9516-34609add7e55"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("5eda0b61-311e-46cf-acc2-b9867aa345c7"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2_ff903a836a5f46a4a7e799d0d81132ecSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2_ff903a836a5f46a4a7e799d0d81132ec",
				UId = new Guid("ff903a83-6a5f-46a4-a7e7-99d0d81132ec"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("32e311e2-322a-4bd2-a082-89dd3de597a9"),
				CreatedInSchemaUId = new Guid("d62091ef-cae4-41fe-b9c9-9cb7afcd5131"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("d62091ef-cae4-41fe-b9c9-9cb7afcd5131"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("1e6c093a-28ab-438c-bca7-4d0215e3162d"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("a12c62b6-7764-4fb3-b8ab-c8c98b039393"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("450b2fb2-a76e-4e0e-a656-91d3a7b4b449"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("468cfeb3-dd71-4fe5-8b71-41582036f904"),
				CreatedInSchemaUId = new Guid("d62091ef-cae4-41fe-b9c9-9cb7afcd5131"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("d62091ef-cae4-41fe-b9c9-9cb7afcd5131"),
				Name = @"LaneSet1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(5, 5),
				Size = new Size(1407, 154),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("f696bbc9-b44c-4b02-b2f7-314af6588a62"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("450b2fb2-a76e-4e0e-a656-91d3a7b4b449"),
				CreatedInOwnerSchemaUId = new Guid("c434cf4e-85f5-48e3-b545-bd3fe9c882ab"),
				CreatedInPackageId = new Guid("468cfeb3-dd71-4fe5-8b71-41582036f904"),
				CreatedInSchemaUId = new Guid("d62091ef-cae4-41fe-b9c9-9cb7afcd5131"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("d62091ef-cae4-41fe-b9c9-9cb7afcd5131"),
				Name = @"Lane1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(29, 0),
				Size = new Size(1378, 154),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaEventSubProcess CreateDeletedEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaDeletedEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("ee266ef9-274d-4e97-97e3-4df4f5b6e0e0"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f696bbc9-b44c-4b02-b2f7-314af6588a62"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("468cfeb3-dd71-4fe5-8b71-41582036f904"),
				CreatedInSchemaUId = new Guid("d62091ef-cae4-41fe-b9c9-9cb7afcd5131"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("d62091ef-cae4-41fe-b9c9-9cb7afcd5131"),
				Name = @"DeletedEventSubProcess",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(35, 20),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(245, 140),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaDeletedEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateQueueDeletedMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("2aad1228-4b1a-4f8b-9516-34609add7e55"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ee266ef9-274d-4e97-97e3-4df4f5b6e0e0"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("468cfeb3-dd71-4fe5-8b71-41582036f904"),
				CreatedInSchemaUId = new Guid("d62091ef-cae4-41fe-b9c9-9cb7afcd5131"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"QueueDeleted",
				ModifiedInSchemaUId = new Guid("d62091ef-cae4-41fe-b9c9-9cb7afcd5131"),
				Name = @"QueueDeletedMessage",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(36, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateClearProfileScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("5eda0b61-311e-46cf-acc2-b9867aa345c7"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ee266ef9-274d-4e97-97e3-4df4f5b6e0e0"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("468cfeb3-dd71-4fe5-8b71-41582036f904"),
				CreatedInSchemaUId = new Guid("d62091ef-cae4-41fe-b9c9-9cb7afcd5131"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("d62091ef-cae4-41fe-b9c9-9cb7afcd5131"),
				Name = @"ClearProfileScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(145, 37),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,115,206,73,77,44,10,40,202,79,203,204,73,213,208,180,230,229,42,74,45,41,45,202,83,40,41,42,77,181,6,0,152,182,183,37,29,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess3_47e8fdb1426143a5a74c1d1c29370234EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess3_47e8fdb1426143a5a74c1d1c29370234 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("47e8fdb1-4261-43a5-a74c-1d1c29370234"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f696bbc9-b44c-4b02-b2f7-314af6588a62"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("32e311e2-322a-4bd2-a082-89dd3de597a9"),
				CreatedInSchemaUId = new Guid("d62091ef-cae4-41fe-b9c9-9cb7afcd5131"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("d62091ef-cae4-41fe-b9c9-9cb7afcd5131"),
				Name = @"EventSubProcess3_47e8fdb1426143a5a74c1d1c29370234",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(339, 20),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(243, 140),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess3_47e8fdb1426143a5a74c1d1c29370234;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateQueueSavedMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("1e6c093a-28ab-438c-bca7-4d0215e3162d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("47e8fdb1-4261-43a5-a74c-1d1c29370234"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("32e311e2-322a-4bd2-a082-89dd3de597a9"),
				CreatedInSchemaUId = new Guid("d62091ef-cae4-41fe-b9c9-9cb7afcd5131"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"QueueSaved",
				ModifiedInSchemaUId = new Guid("d62091ef-cae4-41fe-b9c9-9cb7afcd5131"),
				Name = @"QueueSavedMessage",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(44, 56),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask_QueueSavedScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("a12c62b6-7764-4fb3-b8ab-c8c98b039393"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("47e8fdb1-4261-43a5-a74c-1d1c29370234"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("32e311e2-322a-4bd2-a082-89dd3de597a9"),
				CreatedInSchemaUId = new Guid("d62091ef-cae4-41fe-b9c9-9cb7afcd5131"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("d62091ef-cae4-41fe-b9c9-9cb7afcd5131"),
				Name = @"ScriptTask_QueueSaved",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(141, 42),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,44,77,45,77,117,78,76,206,72,245,72,205,41,72,45,210,115,206,73,77,44,2,11,104,104,90,115,21,165,150,148,22,229,41,148,20,149,166,90,3,0,20,55,106,10,43,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateClearProfileMethod());
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
		}

		protected virtual SchemaMethod CreateClearProfileMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("ffd27e68-5761-466f-943d-3beb934a8d89"),
				Name = "ClearProfile",
				CreatedInSchemaUId = new Guid("d62091ef-cae4-41fe-b9c9-9cb7afcd5131"),
				CreatedInPackageId = new Guid("468cfeb3-dd71-4fe5-8b71-41582036f904"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,81,205,138,194,48,16,62,43,248,14,37,167,4,36,47,32,123,112,253,89,100,89,113,81,215,115,104,198,109,160,77,74,50,113,237,219,239,164,233,69,235,37,144,111,50,223,95,110,202,23,90,161,250,81,117,132,83,215,194,151,178,234,23,124,241,86,204,166,19,190,126,49,18,231,0,126,229,172,133,18,141,179,114,217,182,195,228,224,221,205,104,240,242,3,112,128,56,123,69,193,196,98,54,189,145,52,194,29,31,30,144,46,63,61,131,226,149,195,36,178,179,1,149,45,225,189,219,171,6,56,59,86,206,99,90,239,5,70,228,114,23,206,214,148,78,39,25,244,17,6,23,26,106,192,132,89,248,43,214,253,133,99,101,130,124,76,42,168,17,185,245,174,33,161,46,80,216,171,169,33,9,176,126,114,169,192,147,135,79,232,152,144,180,21,76,192,112,49,88,241,68,251,29,193,119,7,229,201,39,246,181,0,42,83,211,227,19,52,109,173,16,216,188,24,97,162,39,94,90,205,133,220,59,164,115,115,79,172,156,224,73,98,61,146,217,18,249,216,231,132,28,212,177,177,156,145,112,76,228,108,167,89,158,228,8,25,207,200,96,253,41,21,237,228,48,27,171,115,144,109,180,165,92,169,128,60,177,205,199,223,215,27,22,133,10,67,141,84,112,46,151,140,67,25,169,87,177,248,7,167,235,130,205,115,2,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new QueueEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d62091ef-cae4-41fe-b9c9-9cb7afcd5131"));
		}

		#endregion

	}

	#endregion


	#region Class: QueueEventsProcess

	/// <exclude/>
	public class QueueEventsProcess : Queue_OperatorSingleWindowEventsProcess
	{

		public QueueEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

