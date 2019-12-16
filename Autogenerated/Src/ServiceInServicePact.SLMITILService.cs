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

	#region Class: ServiceInServicePactSchema

	/// <exclude/>
	public class ServiceInServicePactSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public ServiceInServicePactSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public ServiceInServicePactSchema(ServiceInServicePactSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public ServiceInServicePactSchema(ServiceInServicePactSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("d01c9dd6-2cb2-41d6-8fcd-29b86ed70b1b");
			RealUId = new Guid("d01c9dd6-2cb2-41d6-8fcd-29b86ed70b1b");
			Name = "ServiceInServicePact";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("ffa69c6a-c8bb-4a61-bc00-b0bcd40a9862");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializePrimaryDisplayColumn() {
			base.InitializePrimaryDisplayColumn();
			PrimaryDisplayColumn = CreateConcatNameColumn();
			if (Columns.FindByUId(PrimaryDisplayColumn.UId) == null) {
				Columns.Add(PrimaryDisplayColumn);
			}
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("73bba5cd-b107-4ae3-a065-9b9eb56cca89")) == null) {
				Columns.Add(CreateServiceItemColumn());
			}
			if (Columns.FindByUId(new Guid("a533502e-52b0-4824-9af7-9d62aaabdd96")) == null) {
				Columns.Add(CreateServicePactColumn());
			}
			if (Columns.FindByUId(new Guid("00c2bb07-f824-475c-88ae-6eee6e5fdd4c")) == null) {
				Columns.Add(CreateReactionTimeValueColumn());
			}
			if (Columns.FindByUId(new Guid("ca97e260-8487-40a3-8ae1-cbf99852eb86")) == null) {
				Columns.Add(CreateReactionTimeUnitColumn());
			}
			if (Columns.FindByUId(new Guid("f9b77e37-01b7-4c8b-9298-5e6da858b3a2")) == null) {
				Columns.Add(CreateSolutionTimeValueColumn());
			}
			if (Columns.FindByUId(new Guid("b4b2684c-d092-4ebb-b0f2-38c76dd70fe1")) == null) {
				Columns.Add(CreateSolutionTimeUnitColumn());
			}
			if (Columns.FindByUId(new Guid("088918cb-b8d4-4c12-a1eb-18fdd3ea9a69")) == null) {
				Columns.Add(CreateStatusColumn());
			}
			if (Columns.FindByUId(new Guid("9f68699f-3e58-4b1f-a1db-0bc70316b1db")) == null) {
				Columns.Add(CreateCalendarColumn());
			}
			if (Columns.FindByUId(new Guid("061013ea-f57e-4057-b3ab-3f7468100b79")) == null) {
				Columns.Add(CreateReactionTimeColumn());
			}
			if (Columns.FindByUId(new Guid("32599881-5e55-4180-aadb-9a1e8dfaf5c4")) == null) {
				Columns.Add(CreateSolutionTimeColumn());
			}
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.ModifiedInSchemaUId = new Guid("d01c9dd6-2cb2-41d6-8fcd-29b86ed70b1b");
			column.CreatedInPackageId = new Guid("ffa69c6a-c8bb-4a61-bc00-b0bcd40a9862");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.ModifiedInSchemaUId = new Guid("d01c9dd6-2cb2-41d6-8fcd-29b86ed70b1b");
			column.CreatedInPackageId = new Guid("ffa69c6a-c8bb-4a61-bc00-b0bcd40a9862");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.ModifiedInSchemaUId = new Guid("d01c9dd6-2cb2-41d6-8fcd-29b86ed70b1b");
			column.CreatedInPackageId = new Guid("ffa69c6a-c8bb-4a61-bc00-b0bcd40a9862");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.ModifiedInSchemaUId = new Guid("d01c9dd6-2cb2-41d6-8fcd-29b86ed70b1b");
			column.CreatedInPackageId = new Guid("ffa69c6a-c8bb-4a61-bc00-b0bcd40a9862");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.ModifiedInSchemaUId = new Guid("d01c9dd6-2cb2-41d6-8fcd-29b86ed70b1b");
			column.CreatedInPackageId = new Guid("ffa69c6a-c8bb-4a61-bc00-b0bcd40a9862");
			return column;
		}

		protected override EntitySchemaColumn CreateProcessListenersColumn() {
			EntitySchemaColumn column = base.CreateProcessListenersColumn();
			column.ModifiedInSchemaUId = new Guid("d01c9dd6-2cb2-41d6-8fcd-29b86ed70b1b");
			column.CreatedInPackageId = new Guid("ffa69c6a-c8bb-4a61-bc00-b0bcd40a9862");
			return column;
		}

		protected virtual EntitySchemaColumn CreateServiceItemColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("73bba5cd-b107-4ae3-a065-9b9eb56cca89"),
				Name = @"ServiceItem",
				ReferenceSchemaUId = new Guid("c6c44f0a-193e-4b5c-b35e-220a60c06898"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("d01c9dd6-2cb2-41d6-8fcd-29b86ed70b1b"),
				ModifiedInSchemaUId = new Guid("d01c9dd6-2cb2-41d6-8fcd-29b86ed70b1b"),
				CreatedInPackageId = new Guid("ffa69c6a-c8bb-4a61-bc00-b0bcd40a9862")
			};
		}

		protected virtual EntitySchemaColumn CreateServicePactColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("a533502e-52b0-4824-9af7-9d62aaabdd96"),
				Name = @"ServicePact",
				ReferenceSchemaUId = new Guid("595ddbda-31ce-4cca-9bdd-862257ceaf23"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("d01c9dd6-2cb2-41d6-8fcd-29b86ed70b1b"),
				ModifiedInSchemaUId = new Guid("d01c9dd6-2cb2-41d6-8fcd-29b86ed70b1b"),
				CreatedInPackageId = new Guid("ffa69c6a-c8bb-4a61-bc00-b0bcd40a9862")
			};
		}

		protected virtual EntitySchemaColumn CreateReactionTimeValueColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("00c2bb07-f824-475c-88ae-6eee6e5fdd4c"),
				Name = @"ReactionTimeValue",
				CreatedInSchemaUId = new Guid("d01c9dd6-2cb2-41d6-8fcd-29b86ed70b1b"),
				ModifiedInSchemaUId = new Guid("d01c9dd6-2cb2-41d6-8fcd-29b86ed70b1b"),
				CreatedInPackageId = new Guid("ffa69c6a-c8bb-4a61-bc00-b0bcd40a9862")
			};
		}

		protected virtual EntitySchemaColumn CreateReactionTimeUnitColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("ca97e260-8487-40a3-8ae1-cbf99852eb86"),
				Name = @"ReactionTimeUnit",
				ReferenceSchemaUId = new Guid("a9432d40-f95f-4d31-9f48-0444ebba77ab"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("d01c9dd6-2cb2-41d6-8fcd-29b86ed70b1b"),
				ModifiedInSchemaUId = new Guid("d01c9dd6-2cb2-41d6-8fcd-29b86ed70b1b"),
				CreatedInPackageId = new Guid("ffa69c6a-c8bb-4a61-bc00-b0bcd40a9862")
			};
		}

		protected virtual EntitySchemaColumn CreateSolutionTimeValueColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("f9b77e37-01b7-4c8b-9298-5e6da858b3a2"),
				Name = @"SolutionTimeValue",
				CreatedInSchemaUId = new Guid("d01c9dd6-2cb2-41d6-8fcd-29b86ed70b1b"),
				ModifiedInSchemaUId = new Guid("d01c9dd6-2cb2-41d6-8fcd-29b86ed70b1b"),
				CreatedInPackageId = new Guid("ffa69c6a-c8bb-4a61-bc00-b0bcd40a9862")
			};
		}

		protected virtual EntitySchemaColumn CreateSolutionTimeUnitColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("b4b2684c-d092-4ebb-b0f2-38c76dd70fe1"),
				Name = @"SolutionTimeUnit",
				ReferenceSchemaUId = new Guid("a9432d40-f95f-4d31-9f48-0444ebba77ab"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("d01c9dd6-2cb2-41d6-8fcd-29b86ed70b1b"),
				ModifiedInSchemaUId = new Guid("d01c9dd6-2cb2-41d6-8fcd-29b86ed70b1b"),
				CreatedInPackageId = new Guid("ffa69c6a-c8bb-4a61-bc00-b0bcd40a9862")
			};
		}

		protected virtual EntitySchemaColumn CreateStatusColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("088918cb-b8d4-4c12-a1eb-18fdd3ea9a69"),
				Name = @"Status",
				ReferenceSchemaUId = new Guid("4fcd6c56-2c34-4f37-9c39-35dd78cc6c0a"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("d01c9dd6-2cb2-41d6-8fcd-29b86ed70b1b"),
				ModifiedInSchemaUId = new Guid("d01c9dd6-2cb2-41d6-8fcd-29b86ed70b1b"),
				CreatedInPackageId = new Guid("ffa69c6a-c8bb-4a61-bc00-b0bcd40a9862")
			};
		}

		protected virtual EntitySchemaColumn CreateCalendarColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("9f68699f-3e58-4b1f-a1db-0bc70316b1db"),
				Name = @"Calendar",
				ReferenceSchemaUId = new Guid("3788dc9f-10e3-41a1-ac1b-bccc768afb64"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("d01c9dd6-2cb2-41d6-8fcd-29b86ed70b1b"),
				ModifiedInSchemaUId = new Guid("d01c9dd6-2cb2-41d6-8fcd-29b86ed70b1b"),
				CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485")
			};
		}

		protected virtual EntitySchemaColumn CreateReactionTimeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("061013ea-f57e-4057-b3ab-3f7468100b79"),
				Name = @"ReactionTime",
				CreatedInSchemaUId = new Guid("d01c9dd6-2cb2-41d6-8fcd-29b86ed70b1b"),
				ModifiedInSchemaUId = new Guid("d01c9dd6-2cb2-41d6-8fcd-29b86ed70b1b"),
				CreatedInPackageId = new Guid("ffa69c6a-c8bb-4a61-bc00-b0bcd40a9862")
			};
		}

		protected virtual EntitySchemaColumn CreateSolutionTimeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("32599881-5e55-4180-aadb-9a1e8dfaf5c4"),
				Name = @"SolutionTime",
				CreatedInSchemaUId = new Guid("d01c9dd6-2cb2-41d6-8fcd-29b86ed70b1b"),
				ModifiedInSchemaUId = new Guid("d01c9dd6-2cb2-41d6-8fcd-29b86ed70b1b"),
				CreatedInPackageId = new Guid("ffa69c6a-c8bb-4a61-bc00-b0bcd40a9862")
			};
		}

		protected virtual EntitySchemaColumn CreateConcatNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("LongText")) {
				UId = new Guid("aa82d8fc-c4d5-4cfe-9659-565656f5e80a"),
				Name = @"ConcatName",
				CreatedInSchemaUId = new Guid("d01c9dd6-2cb2-41d6-8fcd-29b86ed70b1b"),
				ModifiedInSchemaUId = new Guid("d01c9dd6-2cb2-41d6-8fcd-29b86ed70b1b"),
				CreatedInPackageId = new Guid("ad5b74fb-5a18-4ed5-aefb-d72c560aee61")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateServiceInServicePactEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateServiceInServicePactEventsProcessSchema() {
			var schema = new ServiceInServicePactEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new ServiceInServicePact(userConnection){Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new ServiceInServicePact_SLMITILServiceEventsProcess(userConnnection);
		}

		public override object Clone() {
			return new ServiceInServicePactSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new ServiceInServicePactSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d01c9dd6-2cb2-41d6-8fcd-29b86ed70b1b"));
		}

		#endregion

	}

	#endregion

	#region Class: ServiceInServicePact

	/// <summary>
	/// Service in service contract.
	/// </summary>
	public class ServiceInServicePact : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public ServiceInServicePact(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "ServiceInServicePact";
		}

		public ServiceInServicePact(ServiceInServicePact source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public  Guid ServiceItemId {
			get {
				return GetTypedColumnValue<Guid>("ServiceItemId");
			}
			set {
				SetColumnValue("ServiceItemId", value);
				_serviceItem = null;
			}
		}

		/// <exclude/>
		public  string ServiceItemName {
			get {
				return GetTypedColumnValue<string>("ServiceItemName");
			}
			set {
				SetColumnValue("ServiceItemName", value);
				if (_serviceItem != null) {
					_serviceItem.Name = value;
				}
			}
		}

		private ServiceItem _serviceItem;
		/// <summary>
		/// Service.
		/// </summary>
		public  ServiceItem ServiceItem {
			get {
				return _serviceItem ??
					(_serviceItem = LookupColumnEntities.GetEntity("ServiceItem") as ServiceItem);
			}
		}

		/// <exclude/>
		public  Guid ServicePactId {
			get {
				return GetTypedColumnValue<Guid>("ServicePactId");
			}
			set {
				SetColumnValue("ServicePactId", value);
				_servicePact = null;
			}
		}

		/// <exclude/>
		public  string ServicePactName {
			get {
				return GetTypedColumnValue<string>("ServicePactName");
			}
			set {
				SetColumnValue("ServicePactName", value);
				if (_servicePact != null) {
					_servicePact.Name = value;
				}
			}
		}

		private ServicePact _servicePact;
		/// <summary>
		/// Service agreement.
		/// </summary>
		public  ServicePact ServicePact {
			get {
				return _servicePact ??
					(_servicePact = LookupColumnEntities.GetEntity("ServicePact") as ServicePact);
			}
		}

		/// <summary>
		/// Response time value.
		/// </summary>
		public  int ReactionTimeValue {
			get {
				return GetTypedColumnValue<int>("ReactionTimeValue");
			}
			set {
				SetColumnValue("ReactionTimeValue", value);
			}
		}

		/// <exclude/>
		public  Guid ReactionTimeUnitId {
			get {
				return GetTypedColumnValue<Guid>("ReactionTimeUnitId");
			}
			set {
				SetColumnValue("ReactionTimeUnitId", value);
				_reactionTimeUnit = null;
			}
		}

		/// <exclude/>
		public  string ReactionTimeUnitName {
			get {
				return GetTypedColumnValue<string>("ReactionTimeUnitName");
			}
			set {
				SetColumnValue("ReactionTimeUnitName", value);
				if (_reactionTimeUnit != null) {
					_reactionTimeUnit.Name = value;
				}
			}
		}

		private TimeUnit _reactionTimeUnit;
		/// <summary>
		/// Response time unit.
		/// </summary>
		public  TimeUnit ReactionTimeUnit {
			get {
				return _reactionTimeUnit ??
					(_reactionTimeUnit = LookupColumnEntities.GetEntity("ReactionTimeUnit") as TimeUnit);
			}
		}

		/// <summary>
		/// Resolution time value.
		/// </summary>
		public  int SolutionTimeValue {
			get {
				return GetTypedColumnValue<int>("SolutionTimeValue");
			}
			set {
				SetColumnValue("SolutionTimeValue", value);
			}
		}

		/// <exclude/>
		public  Guid SolutionTimeUnitId {
			get {
				return GetTypedColumnValue<Guid>("SolutionTimeUnitId");
			}
			set {
				SetColumnValue("SolutionTimeUnitId", value);
				_solutionTimeUnit = null;
			}
		}

		/// <exclude/>
		public  string SolutionTimeUnitName {
			get {
				return GetTypedColumnValue<string>("SolutionTimeUnitName");
			}
			set {
				SetColumnValue("SolutionTimeUnitName", value);
				if (_solutionTimeUnit != null) {
					_solutionTimeUnit.Name = value;
				}
			}
		}

		private TimeUnit _solutionTimeUnit;
		/// <summary>
		/// Resolution time unit.
		/// </summary>
		public  TimeUnit SolutionTimeUnit {
			get {
				return _solutionTimeUnit ??
					(_solutionTimeUnit = LookupColumnEntities.GetEntity("SolutionTimeUnit") as TimeUnit);
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

		private ServiceStatus _status;
		/// <summary>
		/// Status.
		/// </summary>
		public  ServiceStatus Status {
			get {
				return _status ??
					(_status = LookupColumnEntities.GetEntity("Status") as ServiceStatus);
			}
		}

		/// <exclude/>
		public  Guid CalendarId {
			get {
				return GetTypedColumnValue<Guid>("CalendarId");
			}
			set {
				SetColumnValue("CalendarId", value);
				_calendar = null;
			}
		}

		/// <exclude/>
		public  string CalendarName {
			get {
				return GetTypedColumnValue<string>("CalendarName");
			}
			set {
				SetColumnValue("CalendarName", value);
				if (_calendar != null) {
					_calendar.Name = value;
				}
			}
		}

		private Calendar _calendar;
		/// <summary>
		/// Calendar.
		/// </summary>
		public  Calendar Calendar {
			get {
				return _calendar ??
					(_calendar = LookupColumnEntities.GetEntity("Calendar") as Calendar);
			}
		}

		/// <summary>
		/// Response time.
		/// </summary>
		public  string ReactionTime {
			get {
				return GetTypedColumnValue<string>("ReactionTime");
			}
			set {
				SetColumnValue("ReactionTime", value);
			}
		}

		/// <summary>
		/// Resolution time.
		/// </summary>
		public  string SolutionTime {
			get {
				return GetTypedColumnValue<string>("SolutionTime");
			}
			set {
				SetColumnValue("SolutionTime", value);
			}
		}

		/// <summary>
		/// ServiseAndServiseInServicePactName.
		/// </summary>
		public  string ConcatName {
			get {
				return GetTypedColumnValue<string>("ConcatName");
			}
			set {
				SetColumnValue("ConcatName", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new ServiceInServicePact_SLMITILServiceEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Inserting += (s, e) => ThrowEvent("ServiceInServicePactInserting", e);
			Saving += (s, e) => ThrowEvent("ServiceInServicePactSaving", e);
			Validating += (s, e) => ThrowEvent("ServiceInServicePactValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new ServiceInServicePact(this);
		}

		#endregion

	}

	#endregion

	#region Class: ServiceInServicePact_SLMITILServiceEventsProcess

	/// <exclude/>
	public class ServiceInServicePact_SLMITILServiceEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_LocalMessageEventsProcess<TEntity> where TEntity : ServiceInServicePact
	{

		public ServiceInServicePact_SLMITILServiceEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ServiceInServicePact_SLMITILServiceEventsProcess";
			SchemaUId = new Guid("d01c9dd6-2cb2-41d6-8fcd-29b86ed70b1b");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private  Guid InternalSchemaUId {
			get {
				return new Guid("d01c9dd6-2cb2-41d6-8fcd-29b86ed70b1b");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		private ProcessFlowElement _eventSubProcess1;
		public  ProcessFlowElement EventSubProcess1 {
			get {
				return _eventSubProcess1 ?? (_eventSubProcess1 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess1",
					SchemaElementUId = new Guid("54bfb749-41ec-4a98-8235-1e7a66a2c479"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _serviceInServicePactInsertingStartMessage;
		public  ProcessFlowElement ServiceInServicePactInsertingStartMessage {
			get {
				return _serviceInServicePactInsertingStartMessage ?? (_serviceInServicePactInsertingStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ServiceInServicePactInsertingStartMessage",
					SchemaElementUId = new Guid("46560a4b-9cde-4a4f-98aa-9a589efc3141"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
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
					SchemaElementUId = new Guid("ef6e1e54-ef85-4ab3-939d-18261f6c9435"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask1Execute,
				});
			}
		}

		private ProcessFlowElement _serviceInServicePactSavingStartMessage;
		public  ProcessFlowElement ServiceInServicePactSavingStartMessage {
			get {
				return _serviceInServicePactSavingStartMessage ?? (_serviceInServicePactSavingStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ServiceInServicePactSavingStartMessage",
					SchemaElementUId = new Guid("c8f05092-832a-4f9c-b78a-3c8c6efde1ba"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTask2;
		public  ProcessScriptTask ScriptTask2 {
			get {
				return _scriptTask2 ?? (_scriptTask2 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask2",
					SchemaElementUId = new Guid("45fc7f27-4316-4cd2-b43a-1b6c19af4e6c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask2Execute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess1.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess1 };
			FlowElements[ServiceInServicePactInsertingStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { ServiceInServicePactInsertingStartMessage };
			FlowElements[ScriptTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask1 };
			FlowElements[ServiceInServicePactSavingStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { ServiceInServicePactSavingStartMessage };
			FlowElements[ScriptTask2.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask2 };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess1":
						break;
					case "ServiceInServicePactInsertingStartMessage":
						e.Context.QueueTasks.Enqueue("ScriptTask1");
						break;
					case "ScriptTask1":
						break;
					case "ServiceInServicePactSavingStartMessage":
						e.Context.QueueTasks.Enqueue("ScriptTask2");
						break;
					case "ScriptTask2":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("ServiceInServicePactInsertingStartMessage");
			ActivatedEventElements.Add("ServiceInServicePactSavingStartMessage");
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
				case "ServiceInServicePactInsertingStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "ServiceInServicePactInsertingStartMessage";
					result = ServiceInServicePactInsertingStartMessage.Execute(context);
					break;
				case "ScriptTask1":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask1";
					result = ScriptTask1.Execute(context, ScriptTask1Execute);
					break;
				case "ServiceInServicePactSavingStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "ServiceInServicePactSavingStartMessage";
					result = ServiceInServicePactSavingStartMessage.Execute(context);
					break;
				case "ScriptTask2":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask2";
					result = ScriptTask2.Execute(context, ScriptTask2Execute);
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

		public virtual bool ScriptTask1Execute(ProcessExecutingContext context) {
			var esq = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "ServiceItem");
			var idColumnName = esq.AddColumn(esq.RootSchema.GetPrimaryColumnName()); 
			var reactionTimeValueColumnName = esq.AddColumn("ReactionTimeValue").Name;
			var reactionTimeUnitColumnName = esq.AddColumn("ReactionTimeUnit.Id").Name;
			var reactionTimeColumnName = esq.AddColumn("ReactionTime").Name;
			var solutionTimeValueColumnName = esq.AddColumn("SolutionTimeValue").Name;
			var solutionTimeUnitColumnName = esq.AddColumn("SolutionTimeUnit.Id").Name;
			var solutionTimeColumnName = esq.AddColumn("SolutionTime").Name;
			var statusColumnName = esq.AddColumn("Status.Id").Name;
			var filter = esq.CreateFilterWithParameters(FilterComparisonType.Equal, "Id", 
					Entity.GetTypedColumnValue<Guid>("ServiceItemId"));
			esq.Filters.Add(filter);
			string serviceItemName = GetServiceItemName();
			string servicePactName = GetServicePactName();
			var entityCollection = esq.GetEntityCollection(UserConnection);
			foreach(var entity in entityCollection) {
				Entity.SetColumnValue("ReactionTimeValue", entity.GetTypedColumnValue<int>(reactionTimeValueColumnName));
				Entity.SetColumnValue("ReactionTimeUnitId", entity.GetTypedColumnValue<Guid>(reactionTimeUnitColumnName));
				Entity.SetColumnValue("ReactionTime", entity.GetTypedColumnValue<string>(reactionTimeColumnName));
				Entity.SetColumnValue("SolutionTimeValue", entity.GetTypedColumnValue<int>(solutionTimeValueColumnName));
				Entity.SetColumnValue("SolutionTimeUnitId", entity.GetTypedColumnValue<Guid>(solutionTimeUnitColumnName));
				Entity.SetColumnValue("SolutionTime", entity.GetTypedColumnValue<string>(solutionTimeColumnName));
				Entity.SetColumnValue("StatusId", entity.GetTypedColumnValue<Guid>(statusColumnName));
				if(serviceItemName != null && servicePactName != null) {
					string concatName = serviceItemName + " " + servicePactName;
					concatName = concatName.Length > 500 ? concatName.Substring(0, 500) : concatName;
					Entity.SetColumnValue("ConcatName", concatName);
				} else {
					Entity.SetColumnValue("ConcatName", "Default name");
				}
			} 
			return true;
		}

		public virtual bool ScriptTask2Execute(ProcessExecutingContext context) {
			var esq = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "TimeUnit");
			esq.AddColumn("Name");
			esq.Filters.Add(esq.CreateFilterWithParameters(FilterComparisonType.Equal, "Id", Entity.GetTypedColumnValue<Guid>("ReactionTimeUnitId")));
			var entityCollection = esq.GetEntityCollection(UserConnection);
			if(entityCollection.Count > 0) {
				Entity.SetColumnValue("ReactionTime",Entity.GetTypedColumnValue<int>("ReactionTimeValue").ToString()+" "+entityCollection[0].GetTypedColumnValue<string>("Name"));
			}
			esq.Filters.Clear();
			esq.ResetSelectQuery();
			esq.Filters.Add(esq.CreateFilterWithParameters(FilterComparisonType.Equal, "Id", Entity.GetTypedColumnValue<Guid>("SolutionTimeUnitId")));
			entityCollection = esq.GetEntityCollection(UserConnection);
			if(entityCollection.Count > 0) {
				Entity.SetColumnValue("SolutionTime",Entity.GetTypedColumnValue<int>("SolutionTimeValue").ToString()+" "+entityCollection[0].GetTypedColumnValue<string>("Name"));
			}
			return true;
		}

		public override void LocalMessageExecuting(EntityChangeType changeType) {
			var lmHelper = new Terrasoft.Configuration.LocalMessageHelper(this.Entity, UserConnection, changeType);
			lmHelper.CreateLocalMessage();
		}

		public virtual string GetServiceItemName() {
			var serviceItemId = Entity.GetTypedColumnValue<Guid>("ServiceItemId");
			var serviceItemNameSelect = new Select(UserConnection)
					.Column("Name")
					.From("ServiceItem")
					.Where("Id").IsEqual(Column.Parameter(serviceItemId)) as Select;
			using (DBExecutor dbExecutor = UserConnection.EnsureDBConnection()) {
				using (IDataReader dr = serviceItemNameSelect.ExecuteReader(dbExecutor)) {
					if(dr.Read()){
						return dr.GetColumnValue<string>("Name");
					} else {
						return null;
					}
				}
			}
		}

		public virtual string GetServicePactName() {
			var servicePactId = Entity.GetTypedColumnValue<Guid>("ServicePactId");
			var servicePactNameSelect = new Select(UserConnection)
					.Column("Name")
					.From("ServicePact")
					.Where("Id").IsEqual(Column.Parameter(servicePactId)) as Select;
			using (DBExecutor dbExecutor = UserConnection.EnsureDBConnection()) {
				using (IDataReader dr = servicePactNameSelect.ExecuteReader(dbExecutor)) {
					if(dr.Read()){
						return dr.GetColumnValue<string>("Name");
					} else {
						return null;
					}
				}
			}
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "ServiceInServicePactInserting":
							if (ActivatedEventElements.Contains("ServiceInServicePactInsertingStartMessage")) {
							context.QueueTasks.Enqueue("ServiceInServicePactInsertingStartMessage");
						}
						break;
					case "ServiceInServicePactSaving":
							if (ActivatedEventElements.Contains("ServiceInServicePactSavingStartMessage")) {
							context.QueueTasks.Enqueue("ServiceInServicePactSavingStartMessage");
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

	#region Class: ServiceInServicePact_SLMITILServiceEventsProcess

	/// <exclude/>
	public class ServiceInServicePact_SLMITILServiceEventsProcess : ServiceInServicePact_SLMITILServiceEventsProcess<ServiceInServicePact>
	{

		public ServiceInServicePact_SLMITILServiceEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: ServiceInServicePactEventsProcessSchema

	/// <exclude/>
	public class ServiceInServicePactEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public ServiceInServicePactEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public ServiceInServicePactEventsProcessSchema(ServiceInServicePactEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "ServiceInServicePact_SLMITILServiceEventsProcess";
			UId = new Guid("4baddd61-79ed-480e-80bc-3ba9dd364b1f");
			CreatedInPackageId = new Guid("ffa69c6a-c8bb-4a61-bc00-b0bcd40a9862");
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
			ProcessSchemaEventSubProcess eventsubprocess1 = CreateEventSubProcess1EventSubProcess();
			FlowElements.Add(eventsubprocess1);
			ProcessSchemaStartMessageEvent serviceinservicepactinsertingstartmessage = CreateServiceInServicePactInsertingStartMessageStartMessageEvent();
			eventsubprocess1.FlowElements.Add(serviceinservicepactinsertingstartmessage);
			ProcessSchemaScriptTask scripttask1 = CreateScriptTask1ScriptTask();
			eventsubprocess1.FlowElements.Add(scripttask1);
			ProcessSchemaStartMessageEvent serviceinservicepactsavingstartmessage = CreateServiceInServicePactSavingStartMessageStartMessageEvent();
			eventsubprocess1.FlowElements.Add(serviceinservicepactsavingstartmessage);
			ProcessSchemaScriptTask scripttask2 = CreateScriptTask2ScriptTask();
			eventsubprocess1.FlowElements.Add(scripttask2);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("d57d0501-1819-4593-b20c-cd964c502a56"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("66f58f21-6ed1-4e29-b506-6b9f6426d463"),
				CreatedInPackageId = new Guid("ffa69c6a-c8bb-4a61-bc00-b0bcd40a9862"),
				CreatedInSchemaUId = new Guid("4baddd61-79ed-480e-80bc-3ba9dd364b1f"),
				CurveCenterPosition = new Point(162, 78),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("4baddd61-79ed-480e-80bc-3ba9dd364b1f"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("46560a4b-9cde-4a4f-98aa-9a589efc3141"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("ef6e1e54-ef85-4ab3-939d-18261f6c9435"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("d3b93cca-db86-4770-9d21-ad7bc41c9521"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("66f58f21-6ed1-4e29-b506-6b9f6426d463"),
				CreatedInPackageId = new Guid("ffa69c6a-c8bb-4a61-bc00-b0bcd40a9862"),
				CreatedInSchemaUId = new Guid("4baddd61-79ed-480e-80bc-3ba9dd364b1f"),
				CurveCenterPosition = new Point(510, 86),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("4baddd61-79ed-480e-80bc-3ba9dd364b1f"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("c8f05092-832a-4f9c-b78a-3c8c6efde1ba"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("45fc7f27-4316-4cd2-b43a-1b6c19af4e6c"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("5c5c8235-fa21-493e-b0e3-4512fdf0deb3"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("66f58f21-6ed1-4e29-b506-6b9f6426d463"),
				CreatedInPackageId = new Guid("ffa69c6a-c8bb-4a61-bc00-b0bcd40a9862"),
				CreatedInSchemaUId = new Guid("4baddd61-79ed-480e-80bc-3ba9dd364b1f"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("4baddd61-79ed-480e-80bc-3ba9dd364b1f"),
				Name = @"LaneSet1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(5, 5),
				Size = new Size(1050, 185),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("e7144a4c-3388-435e-8888-d425ebcdd3c4"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("5c5c8235-fa21-493e-b0e3-4512fdf0deb3"),
				CreatedInOwnerSchemaUId = new Guid("d01c9dd6-2cb2-41d6-8fcd-29b86ed70b1b"),
				CreatedInPackageId = new Guid("ffa69c6a-c8bb-4a61-bc00-b0bcd40a9862"),
				CreatedInSchemaUId = new Guid("4baddd61-79ed-480e-80bc-3ba9dd364b1f"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("4baddd61-79ed-480e-80bc-3ba9dd364b1f"),
				Name = @"Lane1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(29, 0),
				Size = new Size(1021, 185),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess1EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess1 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("54bfb749-41ec-4a98-8235-1e7a66a2c479"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e7144a4c-3388-435e-8888-d425ebcdd3c4"),
				CreatedInOwnerSchemaUId = new Guid("66f58f21-6ed1-4e29-b506-6b9f6426d463"),
				CreatedInPackageId = new Guid("ffa69c6a-c8bb-4a61-bc00-b0bcd40a9862"),
				CreatedInSchemaUId = new Guid("4baddd61-79ed-480e-80bc-3ba9dd364b1f"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("4baddd61-79ed-480e-80bc-3ba9dd364b1f"),
				Name = @"EventSubProcess1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(29, 9),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(735, 162),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess1;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateServiceInServicePactInsertingStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("46560a4b-9cde-4a4f-98aa-9a589efc3141"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("54bfb749-41ec-4a98-8235-1e7a66a2c479"),
				CreatedInOwnerSchemaUId = new Guid("66f58f21-6ed1-4e29-b506-6b9f6426d463"),
				CreatedInPackageId = new Guid("ffa69c6a-c8bb-4a61-bc00-b0bcd40a9862"),
				CreatedInSchemaUId = new Guid("4baddd61-79ed-480e-80bc-3ba9dd364b1f"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"ServiceInServicePactInserting",
				ModifiedInSchemaUId = new Guid("4baddd61-79ed-480e-80bc-3ba9dd364b1f"),
				Name = @"ServiceInServicePactInsertingStartMessage",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(28, 56),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask1ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("ef6e1e54-ef85-4ab3-939d-18261f6c9435"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("54bfb749-41ec-4a98-8235-1e7a66a2c479"),
				CreatedInOwnerSchemaUId = new Guid("66f58f21-6ed1-4e29-b506-6b9f6426d463"),
				CreatedInPackageId = new Guid("ffa69c6a-c8bb-4a61-bc00-b0bcd40a9862"),
				CreatedInSchemaUId = new Guid("4baddd61-79ed-480e-80bc-3ba9dd364b1f"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("4baddd61-79ed-480e-80bc-3ba9dd364b1f"),
				Name = @"ScriptTask1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(154, 42),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,85,77,111,219,48,12,61,167,64,255,131,230,67,33,163,129,145,203,46,115,151,97,240,178,162,192,54,164,245,218,157,53,135,73,4,216,114,171,143,12,193,208,255,62,202,114,102,71,78,92,33,39,137,143,239,81,207,36,179,99,146,128,122,33,31,137,128,63,100,33,52,215,251,188,216,66,197,238,13,200,61,125,84,32,179,90,8,40,52,175,69,210,7,124,103,130,109,64,78,73,148,131,220,241,2,238,52,84,81,156,94,94,236,144,148,175,178,186,52,149,248,193,42,64,118,212,72,62,175,218,59,106,79,15,117,173,29,81,114,11,122,41,121,197,228,190,203,161,113,156,18,71,37,129,53,234,63,121,5,79,172,52,48,194,28,61,248,224,40,78,44,50,29,114,61,10,174,67,169,44,54,185,91,157,39,11,37,58,102,80,136,8,126,90,238,131,207,115,189,245,180,220,195,14,158,214,39,11,37,242,24,52,211,70,141,230,54,136,129,244,154,151,26,100,11,207,208,99,13,95,155,171,95,92,111,151,76,34,18,15,138,186,203,172,174,158,153,228,10,75,216,63,67,178,120,49,172,196,150,68,210,41,182,207,100,226,58,214,182,152,141,183,218,141,123,55,183,134,175,230,180,223,189,182,20,219,192,86,217,209,43,91,48,117,37,217,136,210,146,139,13,81,93,78,251,54,20,200,143,47,233,16,191,196,62,24,224,15,151,244,48,58,208,148,140,149,150,110,234,90,43,48,99,225,69,188,241,180,4,235,218,118,229,150,118,68,132,139,1,101,76,254,162,57,173,55,57,232,158,45,167,70,104,218,18,156,180,145,11,61,167,35,51,218,56,26,162,101,27,177,249,110,35,98,238,155,157,159,226,96,177,113,25,247,217,142,133,2,69,134,83,250,182,123,35,107,32,88,43,220,189,243,139,34,88,44,204,189,211,75,100,92,164,217,9,129,239,240,54,140,35,230,107,234,79,231,59,252,119,51,101,73,174,174,6,131,216,134,220,60,76,218,105,45,106,81,176,195,160,250,100,215,36,194,223,181,207,100,165,39,71,137,221,33,249,6,98,163,183,100,78,222,207,102,228,83,63,146,155,223,78,148,206,166,54,26,147,15,189,112,218,219,96,190,83,217,127,20,122,213,165,52,30,188,18,40,21,184,55,133,164,71,95,96,205,76,169,137,176,103,71,113,121,241,138,11,84,130,54,82,16,45,13,164,255,0,100,198,69,11,44,8,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateServiceInServicePactSavingStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("c8f05092-832a-4f9c-b78a-3c8c6efde1ba"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("54bfb749-41ec-4a98-8235-1e7a66a2c479"),
				CreatedInOwnerSchemaUId = new Guid("66f58f21-6ed1-4e29-b506-6b9f6426d463"),
				CreatedInPackageId = new Guid("ffa69c6a-c8bb-4a61-bc00-b0bcd40a9862"),
				CreatedInSchemaUId = new Guid("4baddd61-79ed-480e-80bc-3ba9dd364b1f"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"ServiceInServicePactSaving",
				ModifiedInSchemaUId = new Guid("4baddd61-79ed-480e-80bc-3ba9dd364b1f"),
				Name = @"ServiceInServicePactSavingStartMessage",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(357, 56),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask2ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("45fc7f27-4316-4cd2-b43a-1b6c19af4e6c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("54bfb749-41ec-4a98-8235-1e7a66a2c479"),
				CreatedInOwnerSchemaUId = new Guid("66f58f21-6ed1-4e29-b506-6b9f6426d463"),
				CreatedInPackageId = new Guid("ffa69c6a-c8bb-4a61-bc00-b0bcd40a9862"),
				CreatedInSchemaUId = new Guid("4baddd61-79ed-480e-80bc-3ba9dd364b1f"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("4baddd61-79ed-480e-80bc-3ba9dd364b1f"),
				Name = @"ScriptTask2",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(490, 42),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,197,82,193,106,2,49,20,60,87,240,31,66,78,89,148,197,187,173,80,22,43,61,180,180,174,182,7,233,33,184,175,26,216,125,209,183,47,22,41,253,247,38,187,90,214,69,74,47,197,99,230,189,153,204,100,178,211,36,160,220,138,27,129,240,33,198,200,134,247,233,114,13,133,126,118,64,123,53,47,129,18,139,8,75,54,22,227,230,194,131,70,189,2,234,11,57,51,5,204,209,176,140,134,221,142,87,139,111,179,44,177,185,43,80,201,71,93,192,15,126,103,114,6,42,195,92,133,115,66,160,25,106,244,213,240,250,73,147,95,15,43,170,6,19,91,108,52,153,210,226,108,191,129,120,188,117,58,247,23,222,103,178,127,48,27,79,128,195,236,112,225,139,206,29,92,79,156,201,70,74,78,65,87,182,143,254,60,45,138,130,151,93,72,93,209,61,43,175,179,249,39,8,150,188,220,184,53,105,61,66,16,48,239,170,205,143,19,235,144,197,72,12,34,241,217,237,92,29,236,165,192,13,103,167,158,100,255,151,12,6,185,21,161,194,101,20,207,108,202,100,112,165,162,158,20,178,215,54,178,24,188,157,21,44,43,210,232,88,73,136,241,117,90,75,146,131,38,117,44,107,10,37,112,10,65,181,254,11,23,106,49,245,208,217,22,47,212,96,211,207,31,26,108,174,255,75,131,4,236,8,5,147,131,225,55,231,36,198,149,207,3,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateGetServiceItemNameMethod());
			Methods.Add(CreateGetServicePactNameMethod());
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("fb7b81ba-7c3c-45a5-ae9e-c6c03dceb812"),
				Name = "Terrasoft.UI.WebControls.Controls",
				Alias = "",
				CreatedInPackageId = new Guid("ffa69c6a-c8bb-4a61-bc00-b0bcd40a9862")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("cde525cf-d220-4d2a-b963-e55254c639fc"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("ffa69c6a-c8bb-4a61-bc00-b0bcd40a9862")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5c9c82c6-ba6d-4a57-9a14-87fe8faa4ebb"),
				Name = "Terrasoft.Core.DB",
				Alias = "",
				CreatedInPackageId = new Guid("ffa69c6a-c8bb-4a61-bc00-b0bcd40a9862")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7821de68-c82b-4917-a6cd-add2adfbe400"),
				Name = "Terrasoft.Common",
				Alias = "",
				CreatedInPackageId = new Guid("ffa69c6a-c8bb-4a61-bc00-b0bcd40a9862")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d67de76f-9cbc-4bfc-babb-6f65cb89b973"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("ffa69c6a-c8bb-4a61-bc00-b0bcd40a9862")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("74160d3b-65e3-4694-b554-089f2d980e54"),
				Name = "Newtonsoft.Json",
				Alias = "",
				CreatedInPackageId = new Guid("ffa69c6a-c8bb-4a61-bc00-b0bcd40a9862")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e401300a-9f16-40c2-9788-cf310ae9d1c5"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("ffa69c6a-c8bb-4a61-bc00-b0bcd40a9862")
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

		protected override SchemaMethod CreateLocalMessageExecutingMethod() {
			SchemaMethod method = base.CreateLocalMessageExecutingMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,77,141,75,10,194,48,16,134,247,158,98,150,45,148,92,160,184,42,130,11,221,213,3,12,225,111,26,136,147,50,51,86,122,123,45,69,112,255,61,86,86,42,207,43,202,2,165,51,9,222,52,66,149,173,78,30,134,42,83,78,47,101,207,85,194,173,70,46,119,152,113,194,33,52,62,103,11,23,241,236,91,71,15,131,126,13,65,220,241,142,226,204,146,48,110,11,218,254,244,123,132,65,193,142,255,86,211,246,31,106,54,191,216,134,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetServiceItemNameMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("4559e1c1-c54f-4ecd-a965-51b25d41a409"),
				Name = "GetServiceItemName",
				CreatedInSchemaUId = new Guid("4baddd61-79ed-480e-80bc-3ba9dd364b1f"),
				CreatedInPackageId = new Guid("ad5b74fb-5a18-4ed5-aefb-d72c560aee61"),
				ResultValueTypeName = "string"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,144,77,78,195,48,16,133,215,201,41,172,172,156,141,47,16,218,69,155,80,101,131,16,229,103,109,226,1,44,57,54,140,237,64,133,122,119,198,117,161,137,132,228,133,253,102,222,247,60,51,73,100,30,112,210,3,244,1,198,94,177,21,235,108,208,225,32,118,16,238,15,239,160,182,206,196,209,62,74,19,225,106,23,181,90,243,106,63,119,84,117,83,78,75,204,141,28,97,15,6,134,64,56,11,159,44,63,248,3,245,108,157,181,116,215,206,214,101,81,136,76,231,85,178,84,39,229,26,221,184,136,200,242,211,27,32,240,42,229,137,222,119,31,81,26,158,205,226,86,34,185,3,32,95,140,82,215,76,250,115,116,83,70,175,237,43,227,237,166,251,130,33,6,135,76,61,255,93,87,108,249,53,209,89,31,17,218,205,69,226,132,251,46,139,51,166,111,101,144,119,32,21,16,39,249,255,157,94,228,0,200,141,252,18,152,89,133,126,225,10,69,170,18,61,9,5,66,136,104,9,153,214,63,223,188,15,72,193,235,223,69,53,212,124,100,96,60,176,185,207,70,99,78,165,146,206,241,7,79,225,76,205,221,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetServicePactNameMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("0aff73f3-b966-4882-b27c-4df351944173"),
				Name = "GetServicePactName",
				CreatedInSchemaUId = new Guid("4baddd61-79ed-480e-80bc-3ba9dd364b1f"),
				CreatedInPackageId = new Guid("ad5b74fb-5a18-4ed5-aefb-d72c560aee61"),
				ResultValueTypeName = "string"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,144,77,110,195,32,16,133,215,246,41,144,87,120,195,5,156,100,145,216,141,188,169,162,166,63,107,106,38,45,18,198,233,0,110,163,42,119,239,16,210,198,150,42,177,128,55,243,190,199,204,40,145,57,192,81,119,176,147,157,111,21,91,178,198,122,237,79,98,11,254,241,116,4,181,25,76,232,237,179,52,1,22,219,160,213,138,23,251,169,163,40,171,124,156,99,238,101,15,123,48,208,121,194,89,248,100,233,193,159,168,103,51,88,75,119,61,216,50,207,50,145,232,188,136,150,226,162,220,225,208,207,34,146,252,242,14,8,188,136,121,162,117,205,71,144,134,39,179,216,73,36,183,7,228,179,81,202,146,73,119,141,174,242,224,180,125,99,188,94,55,95,208,5,63,32,83,175,127,215,37,155,127,77,52,214,5,132,122,125,147,56,225,190,243,236,138,105,107,233,229,3,72,5,196,137,254,127,167,23,41,0,82,35,191,5,38,86,166,15,92,161,136,85,162,71,33,67,240,1,45,33,227,250,167,155,119,30,41,120,245,187,168,138,154,207,12,140,3,54,245,217,96,204,165,148,211,57,255,0,162,85,181,1,221,1,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new ServiceInServicePactEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("4baddd61-79ed-480e-80bc-3ba9dd364b1f"));
		}

		#endregion

	}

	#endregion


	#region Class: ServiceInServicePactEventsProcess

	/// <exclude/>
	public class ServiceInServicePactEventsProcess : ServiceInServicePact_SLMITILServiceEventsProcess
	{

		public ServiceInServicePactEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

