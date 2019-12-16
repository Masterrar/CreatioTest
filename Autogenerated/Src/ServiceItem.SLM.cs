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

	#region Class: ServiceItem_SLM_TerrasoftSchema

	/// <exclude/>
	public class ServiceItem_SLM_TerrasoftSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public ServiceItem_SLM_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public ServiceItem_SLM_TerrasoftSchema(ServiceItem_SLM_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public ServiceItem_SLM_TerrasoftSchema(ServiceItem_SLM_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("c6c44f0a-193e-4b5c-b35e-220a60c06898");
			RealUId = new Guid("c6c44f0a-193e-4b5c-b35e-220a60c06898");
			Name = "ServiceItem_SLM_Terrasoft";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("ffa69c6a-c8bb-4a61-bc00-b0bcd40a9862");
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
			if (Columns.FindByUId(new Guid("08272f0d-1d32-40fb-93fa-8f26e83f065f")) == null) {
				Columns.Add(CreateStatusColumn());
			}
			if (Columns.FindByUId(new Guid("96b666c6-1aee-4a64-bbd8-3e0784e98ad7")) == null) {
				Columns.Add(CreateReactionTimeValueColumn());
			}
			if (Columns.FindByUId(new Guid("0f639a8f-2578-4559-9241-2b3fb8c3e25c")) == null) {
				Columns.Add(CreateReactionTimeUnitColumn());
			}
			if (Columns.FindByUId(new Guid("0442e7ab-87f5-4110-840b-885efd5cc394")) == null) {
				Columns.Add(CreateSolutionTimeValueColumn());
			}
			if (Columns.FindByUId(new Guid("bdb8cb94-0dc8-402d-91e2-566c26baf6d8")) == null) {
				Columns.Add(CreateSolutionTimeUnitColumn());
			}
			if (Columns.FindByUId(new Guid("6d363bd0-0b58-4887-921c-a1506b3d27dc")) == null) {
				Columns.Add(CreateCaseCategoryColumn());
			}
			if (Columns.FindByUId(new Guid("2bdaed40-2269-4558-98d9-c7b7332c62fa")) == null) {
				Columns.Add(CreateNotesColumn());
			}
			if (Columns.FindByUId(new Guid("c9da4510-b44e-4d90-8027-57f08c93daa1")) == null) {
				Columns.Add(CreateReactionTimeColumn());
			}
			if (Columns.FindByUId(new Guid("d80d5977-22ac-4c50-b1aa-a93b4d7ec652")) == null) {
				Columns.Add(CreateSolutionTimeColumn());
			}
			if (Columns.FindByUId(new Guid("97852225-890c-4eba-ab9e-12de2129863a")) == null) {
				Columns.Add(CreateOwnerColumn());
			}
			if (Columns.FindByUId(new Guid("ecba8517-ce27-4d3a-b8f1-27acf4774fc3")) == null) {
				Columns.Add(CreateCalendarColumn());
			}
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.ModifiedInSchemaUId = new Guid("c6c44f0a-193e-4b5c-b35e-220a60c06898");
			column.CreatedInPackageId = new Guid("ffa69c6a-c8bb-4a61-bc00-b0bcd40a9862");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.ModifiedInSchemaUId = new Guid("c6c44f0a-193e-4b5c-b35e-220a60c06898");
			column.CreatedInPackageId = new Guid("ffa69c6a-c8bb-4a61-bc00-b0bcd40a9862");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.ModifiedInSchemaUId = new Guid("c6c44f0a-193e-4b5c-b35e-220a60c06898");
			column.CreatedInPackageId = new Guid("ffa69c6a-c8bb-4a61-bc00-b0bcd40a9862");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.ModifiedInSchemaUId = new Guid("c6c44f0a-193e-4b5c-b35e-220a60c06898");
			column.CreatedInPackageId = new Guid("ffa69c6a-c8bb-4a61-bc00-b0bcd40a9862");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.ModifiedInSchemaUId = new Guid("c6c44f0a-193e-4b5c-b35e-220a60c06898");
			column.CreatedInPackageId = new Guid("ffa69c6a-c8bb-4a61-bc00-b0bcd40a9862");
			return column;
		}

		protected override EntitySchemaColumn CreateProcessListenersColumn() {
			EntitySchemaColumn column = base.CreateProcessListenersColumn();
			column.ModifiedInSchemaUId = new Guid("c6c44f0a-193e-4b5c-b35e-220a60c06898");
			column.CreatedInPackageId = new Guid("ffa69c6a-c8bb-4a61-bc00-b0bcd40a9862");
			return column;
		}

		protected virtual EntitySchemaColumn CreateNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("58aa36e4-8c91-4f2d-abdf-bc0b293db336"),
				Name = @"Name",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("c6c44f0a-193e-4b5c-b35e-220a60c06898"),
				ModifiedInSchemaUId = new Guid("c6c44f0a-193e-4b5c-b35e-220a60c06898"),
				CreatedInPackageId = new Guid("ffa69c6a-c8bb-4a61-bc00-b0bcd40a9862")
			};
		}

		protected virtual EntitySchemaColumn CreateStatusColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("08272f0d-1d32-40fb-93fa-8f26e83f065f"),
				Name = @"Status",
				ReferenceSchemaUId = new Guid("4fcd6c56-2c34-4f37-9c39-35dd78cc6c0a"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("c6c44f0a-193e-4b5c-b35e-220a60c06898"),
				ModifiedInSchemaUId = new Guid("c6c44f0a-193e-4b5c-b35e-220a60c06898"),
				CreatedInPackageId = new Guid("ffa69c6a-c8bb-4a61-bc00-b0bcd40a9862"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Settings,
					ValueSource = @"ServiceItemStatusDef"
				}
			};
		}

		protected virtual EntitySchemaColumn CreateReactionTimeValueColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("96b666c6-1aee-4a64-bbd8-3e0784e98ad7"),
				Name = @"ReactionTimeValue",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("c6c44f0a-193e-4b5c-b35e-220a60c06898"),
				ModifiedInSchemaUId = new Guid("c6c44f0a-193e-4b5c-b35e-220a60c06898"),
				CreatedInPackageId = new Guid("ffa69c6a-c8bb-4a61-bc00-b0bcd40a9862")
			};
		}

		protected virtual EntitySchemaColumn CreateReactionTimeUnitColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("0f639a8f-2578-4559-9241-2b3fb8c3e25c"),
				Name = @"ReactionTimeUnit",
				ReferenceSchemaUId = new Guid("a9432d40-f95f-4d31-9f48-0444ebba77ab"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("c6c44f0a-193e-4b5c-b35e-220a60c06898"),
				ModifiedInSchemaUId = new Guid("c6c44f0a-193e-4b5c-b35e-220a60c06898"),
				CreatedInPackageId = new Guid("ffa69c6a-c8bb-4a61-bc00-b0bcd40a9862")
			};
		}

		protected virtual EntitySchemaColumn CreateSolutionTimeValueColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("0442e7ab-87f5-4110-840b-885efd5cc394"),
				Name = @"SolutionTimeValue",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("c6c44f0a-193e-4b5c-b35e-220a60c06898"),
				ModifiedInSchemaUId = new Guid("c6c44f0a-193e-4b5c-b35e-220a60c06898"),
				CreatedInPackageId = new Guid("ffa69c6a-c8bb-4a61-bc00-b0bcd40a9862")
			};
		}

		protected virtual EntitySchemaColumn CreateSolutionTimeUnitColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("bdb8cb94-0dc8-402d-91e2-566c26baf6d8"),
				Name = @"SolutionTimeUnit",
				ReferenceSchemaUId = new Guid("a9432d40-f95f-4d31-9f48-0444ebba77ab"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("c6c44f0a-193e-4b5c-b35e-220a60c06898"),
				ModifiedInSchemaUId = new Guid("c6c44f0a-193e-4b5c-b35e-220a60c06898"),
				CreatedInPackageId = new Guid("ffa69c6a-c8bb-4a61-bc00-b0bcd40a9862")
			};
		}

		protected virtual EntitySchemaColumn CreateCaseCategoryColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("6d363bd0-0b58-4887-921c-a1506b3d27dc"),
				Name = @"CaseCategory",
				ReferenceSchemaUId = new Guid("63fec14d-0309-43b0-99c5-b085abf0c314"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("c6c44f0a-193e-4b5c-b35e-220a60c06898"),
				ModifiedInSchemaUId = new Guid("c6c44f0a-193e-4b5c-b35e-220a60c06898"),
				CreatedInPackageId = new Guid("ffa69c6a-c8bb-4a61-bc00-b0bcd40a9862")
			};
		}

		protected virtual EntitySchemaColumn CreateNotesColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("2bdaed40-2269-4558-98d9-c7b7332c62fa"),
				Name = @"Notes",
				CreatedInSchemaUId = new Guid("c6c44f0a-193e-4b5c-b35e-220a60c06898"),
				ModifiedInSchemaUId = new Guid("c6c44f0a-193e-4b5c-b35e-220a60c06898"),
				CreatedInPackageId = new Guid("ffa69c6a-c8bb-4a61-bc00-b0bcd40a9862")
			};
		}

		protected virtual EntitySchemaColumn CreateReactionTimeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("c9da4510-b44e-4d90-8027-57f08c93daa1"),
				Name = @"ReactionTime",
				CreatedInSchemaUId = new Guid("c6c44f0a-193e-4b5c-b35e-220a60c06898"),
				ModifiedInSchemaUId = new Guid("c6c44f0a-193e-4b5c-b35e-220a60c06898"),
				CreatedInPackageId = new Guid("ffa69c6a-c8bb-4a61-bc00-b0bcd40a9862")
			};
		}

		protected virtual EntitySchemaColumn CreateSolutionTimeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("d80d5977-22ac-4c50-b1aa-a93b4d7ec652"),
				Name = @"SolutionTime",
				CreatedInSchemaUId = new Guid("c6c44f0a-193e-4b5c-b35e-220a60c06898"),
				ModifiedInSchemaUId = new Guid("c6c44f0a-193e-4b5c-b35e-220a60c06898"),
				CreatedInPackageId = new Guid("ffa69c6a-c8bb-4a61-bc00-b0bcd40a9862")
			};
		}

		protected virtual EntitySchemaColumn CreateOwnerColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("97852225-890c-4eba-ab9e-12de2129863a"),
				Name = @"Owner",
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("c6c44f0a-193e-4b5c-b35e-220a60c06898"),
				ModifiedInSchemaUId = new Guid("c6c44f0a-193e-4b5c-b35e-220a60c06898"),
				CreatedInPackageId = new Guid("af2f4ac9-4bf5-4cc5-9c73-7ee909501027")
			};
		}

		protected virtual EntitySchemaColumn CreateCalendarColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("ecba8517-ce27-4d3a-b8f1-27acf4774fc3"),
				Name = @"Calendar",
				ReferenceSchemaUId = new Guid("3788dc9f-10e3-41a1-ac1b-bccc768afb64"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("c6c44f0a-193e-4b5c-b35e-220a60c06898"),
				ModifiedInSchemaUId = new Guid("c6c44f0a-193e-4b5c-b35e-220a60c06898"),
				CreatedInPackageId = new Guid("b11d550e-0087-4f53-ae17-fb00d41102cf")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateServiceItem_SLM_TerrasoftEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateServiceItem_SLM_TerrasoftEventsProcessSchema() {
			var schema = new ServiceItem_SLM_TerrasoftEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new ServiceItem_SLM_Terrasoft(userConnection){Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new ServiceItem_SLMEventsProcess(userConnnection);
		}

		public override object Clone() {
			return new ServiceItem_SLM_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new ServiceItem_SLM_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c6c44f0a-193e-4b5c-b35e-220a60c06898"));
		}

		#endregion

	}

	#endregion

	#region Class: ServiceItem_SLM_Terrasoft

	/// <summary>
	/// Service.
	/// </summary>
	public class ServiceItem_SLM_Terrasoft : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public ServiceItem_SLM_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "ServiceItem_SLM_Terrasoft";
		}

		public ServiceItem_SLM_Terrasoft(ServiceItem_SLM_Terrasoft source)
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
		public  Guid CaseCategoryId {
			get {
				return GetTypedColumnValue<Guid>("CaseCategoryId");
			}
			set {
				SetColumnValue("CaseCategoryId", value);
				_caseCategory = null;
			}
		}

		/// <exclude/>
		public  string CaseCategoryName {
			get {
				return GetTypedColumnValue<string>("CaseCategoryName");
			}
			set {
				SetColumnValue("CaseCategoryName", value);
				if (_caseCategory != null) {
					_caseCategory.Name = value;
				}
			}
		}

		private CaseCategory _caseCategory;
		/// <summary>
		/// Case category.
		/// </summary>
		public  CaseCategory CaseCategory {
			get {
				return _caseCategory ??
					(_caseCategory = LookupColumnEntities.GetEntity("CaseCategory") as CaseCategory);
			}
		}

		/// <summary>
		/// Notes.
		/// </summary>
		public  string Notes {
			get {
				return GetTypedColumnValue<string>("Notes");
			}
			set {
				SetColumnValue("Notes", value);
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

		/// <exclude/>
		public  Guid OwnerId {
			get {
				return GetTypedColumnValue<Guid>("OwnerId");
			}
			set {
				SetColumnValue("OwnerId", value);
				_owner = null;
			}
		}

		/// <exclude/>
		public  string OwnerName {
			get {
				return GetTypedColumnValue<string>("OwnerName");
			}
			set {
				SetColumnValue("OwnerName", value);
				if (_owner != null) {
					_owner.Name = value;
				}
			}
		}

		private Contact _owner;
		/// <summary>
		/// Owner.
		/// </summary>
		public  Contact Owner {
			get {
				return _owner ??
					(_owner = LookupColumnEntities.GetEntity("Owner") as Contact);
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

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new ServiceItem_SLMEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Saving += (s, e) => ThrowEvent("ServiceItem_SLM_TerrasoftSaving", e);
			Validating += (s, e) => ThrowEvent("ServiceItem_SLM_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new ServiceItem_SLM_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: ServiceItem_SLMEventsProcess

	/// <exclude/>
	public class ServiceItem_SLMEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_LocalMessageEventsProcess<TEntity> where TEntity : ServiceItem_SLM_Terrasoft
	{

		public ServiceItem_SLMEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ServiceItem_SLMEventsProcess";
			SchemaUId = new Guid("c6c44f0a-193e-4b5c-b35e-220a60c06898");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private  Guid InternalSchemaUId {
			get {
				return new Guid("c6c44f0a-193e-4b5c-b35e-220a60c06898");
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
					SchemaElementUId = new Guid("2b6c7d79-85fd-468e-8c1d-389484fecad0"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _serviceItemSavingStartMessage;
		public  ProcessFlowElement ServiceItemSavingStartMessage {
			get {
				return _serviceItemSavingStartMessage ?? (_serviceItemSavingStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ServiceItemSavingStartMessage",
					SchemaElementUId = new Guid("974c36b2-34fb-41c3-aafd-e58e479c2be2"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _serviceItemSavingScriptTask;
		public  ProcessScriptTask ServiceItemSavingScriptTask {
			get {
				return _serviceItemSavingScriptTask ?? (_serviceItemSavingScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ServiceItemSavingScriptTask",
					SchemaElementUId = new Guid("825523e6-0515-4441-bb43-b08b96db9fac"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ServiceItemSavingScriptTaskExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess1.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess1 };
			FlowElements[ServiceItemSavingStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { ServiceItemSavingStartMessage };
			FlowElements[ServiceItemSavingScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { ServiceItemSavingScriptTask };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess1":
						break;
					case "ServiceItemSavingStartMessage":
						e.Context.QueueTasks.Enqueue("ServiceItemSavingScriptTask");
						break;
					case "ServiceItemSavingScriptTask":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("ServiceItemSavingStartMessage");
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
				case "ServiceItemSavingStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "ServiceItemSavingStartMessage";
					result = ServiceItemSavingStartMessage.Execute(context);
					break;
				case "ServiceItemSavingScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "ServiceItemSavingScriptTask";
					result = ServiceItemSavingScriptTask.Execute(context, ServiceItemSavingScriptTaskExecute);
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

		public virtual bool ServiceItemSavingScriptTaskExecute(ProcessExecutingContext context) {
			var esq = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "TimeUnit");
			esq.AddColumn("Name");
			esq.Filters.Add(esq.CreateFilterWithParameters(FilterComparisonType.Equal, "Id", Entity.GetTypedColumnValue<Guid>("ReactionTimeUnitId")));
			var entityCollection = esq.GetEntityCollection(UserConnection);
			Entity.SetColumnValue("ReactionTime", entityCollection[0].GetTypedColumnValue<string>("Name") +": "+ Entity.GetTypedColumnValue<int>("ReactionTimeValue").ToString());
			
			esq.Filters.Clear();
			esq.ResetSelectQuery();
			esq.Filters.Add(esq.CreateFilterWithParameters(FilterComparisonType.Equal, "Id", Entity.GetTypedColumnValue<Guid>("SolutionTimeUnitId")));
			entityCollection = esq.GetEntityCollection(UserConnection);
			entityCollection[0].GetTypedColumnValue<string>("Name");
			Entity.SetColumnValue("SolutionTime", entityCollection[0].GetTypedColumnValue<string>("Name") +": "+ Entity.GetTypedColumnValue<int>("SolutionTimeValue").ToString());
			return true;
		}

		public override void LocalMessageExecuting(EntityChangeType changeType) {
			var lmHelper = new Terrasoft.Configuration.LocalMessageHelper(this.Entity, UserConnection, changeType);
			lmHelper.CreateLocalMessage();
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "ServiceItem_SLM_TerrasoftSaving":
							if (ActivatedEventElements.Contains("ServiceItemSavingStartMessage")) {
							context.QueueTasks.Enqueue("ServiceItemSavingStartMessage");
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

	#region Class: ServiceItem_SLMEventsProcess

	/// <exclude/>
	public class ServiceItem_SLMEventsProcess : ServiceItem_SLMEventsProcess<ServiceItem_SLM_Terrasoft>
	{

		public ServiceItem_SLMEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: ServiceItem_SLM_TerrasoftEventsProcessSchema

	/// <exclude/>
	public class ServiceItem_SLM_TerrasoftEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public ServiceItem_SLM_TerrasoftEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public ServiceItem_SLM_TerrasoftEventsProcessSchema(ServiceItem_SLM_TerrasoftEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "ServiceItem_SLMEventsProcess";
			UId = new Guid("d1648fb9-6c47-49e8-bc9d-8238ea55ab86");
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

		protected override ProcessSchemaParameter CreateNextProcessElementReadyParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("d9e67329-fde2-4fbd-aa49-2d69ca3d2b5b"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				Name = @"NextProcessElementReady",
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected override ProcessSchemaParameter CreateIsProcessModeSaveParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("4cb16350-d39b-4247-9da5-33032cf8667d"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				Name = @"IsProcessModeSave",
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
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
			ProcessSchemaStartMessageEvent serviceitemsavingstartmessage = CreateServiceItemSavingStartMessageStartMessageEvent();
			eventsubprocess1.FlowElements.Add(serviceitemsavingstartmessage);
			ProcessSchemaScriptTask serviceitemsavingscripttask = CreateServiceItemSavingScriptTaskScriptTask();
			eventsubprocess1.FlowElements.Add(serviceitemsavingscripttask);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("3d1188b5-6a44-4751-90aa-9068d5c4bb42"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("66f58f21-6ed1-4e29-b506-6b9f6426d463"),
				CreatedInPackageId = new Guid("ffa69c6a-c8bb-4a61-bc00-b0bcd40a9862"),
				CreatedInSchemaUId = new Guid("d1648fb9-6c47-49e8-bc9d-8238ea55ab86"),
				CurveCenterPosition = new Point(178, 82),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("d1648fb9-6c47-49e8-bc9d-8238ea55ab86"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("974c36b2-34fb-41c3-aafd-e58e479c2be2"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("825523e6-0515-4441-bb43-b08b96db9fac"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("41e459e5-2a3c-452d-bd27-a7fce401240f"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("66f58f21-6ed1-4e29-b506-6b9f6426d463"),
				CreatedInPackageId = new Guid("ffa69c6a-c8bb-4a61-bc00-b0bcd40a9862"),
				CreatedInSchemaUId = new Guid("d1648fb9-6c47-49e8-bc9d-8238ea55ab86"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("d1648fb9-6c47-49e8-bc9d-8238ea55ab86"),
				Name = @"LaneSet1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(5, 5),
				Size = new Size(1566, 170),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("b9b1aa19-f521-4fe0-840f-aaddb4175bd9"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("41e459e5-2a3c-452d-bd27-a7fce401240f"),
				CreatedInOwnerSchemaUId = new Guid("c6c44f0a-193e-4b5c-b35e-220a60c06898"),
				CreatedInPackageId = new Guid("ffa69c6a-c8bb-4a61-bc00-b0bcd40a9862"),
				CreatedInSchemaUId = new Guid("d1648fb9-6c47-49e8-bc9d-8238ea55ab86"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("d1648fb9-6c47-49e8-bc9d-8238ea55ab86"),
				Name = @"Lane1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(29, 0),
				Size = new Size(1537, 170),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess1EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess1 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("2b6c7d79-85fd-468e-8c1d-389484fecad0"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("b9b1aa19-f521-4fe0-840f-aaddb4175bd9"),
				CreatedInOwnerSchemaUId = new Guid("66f58f21-6ed1-4e29-b506-6b9f6426d463"),
				CreatedInPackageId = new Guid("ffa69c6a-c8bb-4a61-bc00-b0bcd40a9862"),
				CreatedInSchemaUId = new Guid("d1648fb9-6c47-49e8-bc9d-8238ea55ab86"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("d1648fb9-6c47-49e8-bc9d-8238ea55ab86"),
				Name = @"EventSubProcess1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(42, 0),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(511, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess1;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateServiceItemSavingStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("974c36b2-34fb-41c3-aafd-e58e479c2be2"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("2b6c7d79-85fd-468e-8c1d-389484fecad0"),
				CreatedInOwnerSchemaUId = new Guid("66f58f21-6ed1-4e29-b506-6b9f6426d463"),
				CreatedInPackageId = new Guid("ffa69c6a-c8bb-4a61-bc00-b0bcd40a9862"),
				CreatedInSchemaUId = new Guid("d1648fb9-6c47-49e8-bc9d-8238ea55ab86"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"ServiceItemSaving",
				ModifiedInSchemaUId = new Guid("d1648fb9-6c47-49e8-bc9d-8238ea55ab86"),
				Name = @"ServiceItemSavingStartMessage",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(141, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateServiceItemSavingScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("825523e6-0515-4441-bb43-b08b96db9fac"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("2b6c7d79-85fd-468e-8c1d-389484fecad0"),
				CreatedInOwnerSchemaUId = new Guid("66f58f21-6ed1-4e29-b506-6b9f6426d463"),
				CreatedInPackageId = new Guid("ffa69c6a-c8bb-4a61-bc00-b0bcd40a9862"),
				CreatedInSchemaUId = new Guid("d1648fb9-6c47-49e8-bc9d-8238ea55ab86"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("d1648fb9-6c47-49e8-bc9d-8238ea55ab86"),
				Name = @"ServiceItemSavingScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(232, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,197,81,205,75,195,48,20,191,11,254,15,33,167,148,141,226,217,233,64,74,29,30,20,93,55,61,136,135,176,62,182,64,154,108,175,47,147,254,247,38,253,144,174,84,15,10,122,204,47,239,189,223,215,81,34,131,242,192,174,153,129,119,150,26,82,84,101,155,29,20,242,201,1,86,98,93,2,38,214,24,216,144,178,38,238,15,220,75,35,183,128,83,198,87,170,128,181,81,196,163,217,249,153,191,22,223,228,121,98,181,43,140,224,15,178,128,79,252,86,105,2,44,195,191,8,239,4,65,18,52,232,139,162,221,163,68,63,30,70,68,3,38,182,216,75,84,165,53,171,106,15,113,122,112,82,123,194,187,156,79,91,177,241,2,40,252,181,132,207,82,59,184,90,56,149,207,5,95,130,172,101,119,250,252,90,20,5,45,199,224,186,94,247,91,186,241,230,35,8,146,252,185,116,240,51,8,33,28,104,185,51,160,30,237,41,161,87,56,164,120,189,120,27,149,91,18,42,179,157,119,97,177,9,191,100,124,242,157,65,101,104,224,175,198,121,20,175,108,86,95,19,181,209,211,216,19,13,18,69,87,198,18,74,160,12,130,182,166,235,127,106,41,243,208,104,75,191,106,232,135,217,127,221,109,95,230,31,116,219,167,27,239,22,129,28,26,70,232,96,246,1,45,130,22,13,199,3,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
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

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new ServiceItem_SLM_TerrasoftEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d1648fb9-6c47-49e8-bc9d-8238ea55ab86"));
		}

		#endregion

	}

	#endregion

}

