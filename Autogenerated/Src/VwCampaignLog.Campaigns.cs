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

	#region Class: VwCampaignLogSchema

	/// <exclude/>
	public class VwCampaignLogSchema : Terrasoft.Core.Entities.EntitySchema
	{

		#region Constructors: Public

		public VwCampaignLogSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public VwCampaignLogSchema(VwCampaignLogSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public VwCampaignLogSchema(VwCampaignLogSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("bcf4752b-140d-4a7d-9c1b-8a3651dde04c");
			RealUId = new Guid("bcf4752b-140d-4a7d-9c1b-8a3651dde04c");
			Name = "VwCampaignLog";
			ParentSchemaUId = new Guid("1b56b061-4e91-4974-9038-df8340e534f2");
			ExtendParent = false;
			CreatedInPackageId = new Guid("bac310da-8f6a-4932-87be-74eb3d9d7067");
			IsDBView = true;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializePrimaryColumn() {
			base.InitializePrimaryColumn();
			PrimaryColumn = CreateIdColumn();
			if (Columns.FindByUId(PrimaryColumn.UId) == null) {
				Columns.Add(PrimaryColumn);
			}
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("5866a432-2635-4695-8ba6-d571b4e99c44")) == null) {
				Columns.Add(CreateCampaignColumn());
			}
			if (Columns.FindByUId(new Guid("15c2d6ef-6442-4767-9978-e5256a8a2628")) == null) {
				Columns.Add(CreateCampaignItemColumn());
			}
			if (Columns.FindByUId(new Guid("36e9e88a-c417-45e7-be15-7ba9d9f96189")) == null) {
				Columns.Add(CreateAmountColumn());
			}
			if (Columns.FindByUId(new Guid("6ad08566-b6a1-43b8-9509-01dbc7ac191a")) == null) {
				Columns.Add(CreateCreatedOnColumn());
			}
			if (Columns.FindByUId(new Guid("5796ca82-e7c8-49a6-befc-03cfca63f3dd")) == null) {
				Columns.Add(CreateScheduledDateColumn());
			}
			if (Columns.FindByUId(new Guid("2ce41aed-f6a8-45f4-98c2-41061681af7d")) == null) {
				Columns.Add(CreateStartDateColumn());
			}
			if (Columns.FindByUId(new Guid("5f92d3ef-20d7-4b8d-a637-1621424cc9ed")) == null) {
				Columns.Add(CreateEndDateColumn());
			}
			if (Columns.FindByUId(new Guid("b9d81e8a-f5c4-45a3-b7d3-79419fb35d06")) == null) {
				Columns.Add(CreateErrorTextColumn());
			}
			if (Columns.FindByUId(new Guid("b82382c5-9b64-44b5-8867-6eb115869bbd")) == null) {
				Columns.Add(CreateDurationSsColumn());
			}
			if (Columns.FindByUId(new Guid("962dcc52-d16e-4df8-9748-b5da1a5ca89b")) == null) {
				Columns.Add(CreateDurationMiColumn());
			}
			if (Columns.FindByUId(new Guid("e32cee04-b297-40d0-83b2-a3e7d39fae43")) == null) {
				Columns.Add(CreateStatusColumn());
			}
			if (Columns.FindByUId(new Guid("6b69b085-468b-423e-aade-db70d5dbdc13")) == null) {
				Columns.Add(CreateActionColumn());
			}
			if (Columns.FindByUId(new Guid("e88b7112-a762-43e5-bb15-52178aa314f7")) == null) {
				Columns.Add(CreateSessionIdColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("8ed01284-6cd0-4a87-89e6-1d6af46808f4"),
				Name = @"Id",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("bcf4752b-140d-4a7d-9c1b-8a3651dde04c"),
				ModifiedInSchemaUId = new Guid("bcf4752b-140d-4a7d-9c1b-8a3651dde04c"),
				CreatedInPackageId = new Guid("bac310da-8f6a-4932-87be-74eb3d9d7067")
			};
		}

		protected virtual EntitySchemaColumn CreateCampaignColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("5866a432-2635-4695-8ba6-d571b4e99c44"),
				Name = @"Campaign",
				ReferenceSchemaUId = new Guid("1f9bb71a-eb9c-4220-a40e-9b623eacfec8"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("bcf4752b-140d-4a7d-9c1b-8a3651dde04c"),
				ModifiedInSchemaUId = new Guid("bcf4752b-140d-4a7d-9c1b-8a3651dde04c"),
				CreatedInPackageId = new Guid("bac310da-8f6a-4932-87be-74eb3d9d7067")
			};
		}

		protected virtual EntitySchemaColumn CreateCampaignItemColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("15c2d6ef-6442-4767-9978-e5256a8a2628"),
				Name = @"CampaignItem",
				ReferenceSchemaUId = new Guid("28045fad-1d04-4bb5-8600-ed4ca87b5650"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("bcf4752b-140d-4a7d-9c1b-8a3651dde04c"),
				ModifiedInSchemaUId = new Guid("bcf4752b-140d-4a7d-9c1b-8a3651dde04c"),
				CreatedInPackageId = new Guid("bac310da-8f6a-4932-87be-74eb3d9d7067")
			};
		}

		protected virtual EntitySchemaColumn CreateAmountColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("36e9e88a-c417-45e7-be15-7ba9d9f96189"),
				Name = @"Amount",
				CreatedInSchemaUId = new Guid("bcf4752b-140d-4a7d-9c1b-8a3651dde04c"),
				ModifiedInSchemaUId = new Guid("bcf4752b-140d-4a7d-9c1b-8a3651dde04c"),
				CreatedInPackageId = new Guid("bac310da-8f6a-4932-87be-74eb3d9d7067")
			};
		}

		protected virtual EntitySchemaColumn CreateCreatedOnColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("DateTime")) {
				UId = new Guid("6ad08566-b6a1-43b8-9509-01dbc7ac191a"),
				Name = @"CreatedOn",
				CreatedInSchemaUId = new Guid("bcf4752b-140d-4a7d-9c1b-8a3651dde04c"),
				ModifiedInSchemaUId = new Guid("bcf4752b-140d-4a7d-9c1b-8a3651dde04c"),
				CreatedInPackageId = new Guid("6c038aa0-46cd-4697-bc93-5c682e364aef")
			};
		}

		protected virtual EntitySchemaColumn CreateScheduledDateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("DateTime")) {
				UId = new Guid("5796ca82-e7c8-49a6-befc-03cfca63f3dd"),
				Name = @"ScheduledDate",
				CreatedInSchemaUId = new Guid("bcf4752b-140d-4a7d-9c1b-8a3651dde04c"),
				ModifiedInSchemaUId = new Guid("bcf4752b-140d-4a7d-9c1b-8a3651dde04c"),
				CreatedInPackageId = new Guid("bac310da-8f6a-4932-87be-74eb3d9d7067")
			};
		}

		protected virtual EntitySchemaColumn CreateStartDateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("DateTime")) {
				UId = new Guid("2ce41aed-f6a8-45f4-98c2-41061681af7d"),
				Name = @"StartDate",
				CreatedInSchemaUId = new Guid("bcf4752b-140d-4a7d-9c1b-8a3651dde04c"),
				ModifiedInSchemaUId = new Guid("bcf4752b-140d-4a7d-9c1b-8a3651dde04c"),
				CreatedInPackageId = new Guid("bac310da-8f6a-4932-87be-74eb3d9d7067")
			};
		}

		protected virtual EntitySchemaColumn CreateEndDateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("DateTime")) {
				UId = new Guid("5f92d3ef-20d7-4b8d-a637-1621424cc9ed"),
				Name = @"EndDate",
				CreatedInSchemaUId = new Guid("bcf4752b-140d-4a7d-9c1b-8a3651dde04c"),
				ModifiedInSchemaUId = new Guid("bcf4752b-140d-4a7d-9c1b-8a3651dde04c"),
				CreatedInPackageId = new Guid("bac310da-8f6a-4932-87be-74eb3d9d7067")
			};
		}

		protected virtual EntitySchemaColumn CreateErrorTextColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("LongText")) {
				UId = new Guid("b9d81e8a-f5c4-45a3-b7d3-79419fb35d06"),
				Name = @"ErrorText",
				CreatedInSchemaUId = new Guid("bcf4752b-140d-4a7d-9c1b-8a3651dde04c"),
				ModifiedInSchemaUId = new Guid("bcf4752b-140d-4a7d-9c1b-8a3651dde04c"),
				CreatedInPackageId = new Guid("bac310da-8f6a-4932-87be-74eb3d9d7067")
			};
		}

		protected virtual EntitySchemaColumn CreateDurationSsColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("b82382c5-9b64-44b5-8867-6eb115869bbd"),
				Name = @"DurationSs",
				CreatedInSchemaUId = new Guid("bcf4752b-140d-4a7d-9c1b-8a3651dde04c"),
				ModifiedInSchemaUId = new Guid("bcf4752b-140d-4a7d-9c1b-8a3651dde04c"),
				CreatedInPackageId = new Guid("bac310da-8f6a-4932-87be-74eb3d9d7067")
			};
		}

		protected virtual EntitySchemaColumn CreateDurationMiColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("962dcc52-d16e-4df8-9748-b5da1a5ca89b"),
				Name = @"DurationMi",
				CreatedInSchemaUId = new Guid("bcf4752b-140d-4a7d-9c1b-8a3651dde04c"),
				ModifiedInSchemaUId = new Guid("bcf4752b-140d-4a7d-9c1b-8a3651dde04c"),
				CreatedInPackageId = new Guid("bac310da-8f6a-4932-87be-74eb3d9d7067")
			};
		}

		protected virtual EntitySchemaColumn CreateStatusColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("e32cee04-b297-40d0-83b2-a3e7d39fae43"),
				Name = @"Status",
				ReferenceSchemaUId = new Guid("05938a8b-b4ed-4a29-85df-478ca8d8adfd"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("bcf4752b-140d-4a7d-9c1b-8a3651dde04c"),
				ModifiedInSchemaUId = new Guid("bcf4752b-140d-4a7d-9c1b-8a3651dde04c"),
				CreatedInPackageId = new Guid("bac310da-8f6a-4932-87be-74eb3d9d7067")
			};
		}

		protected virtual EntitySchemaColumn CreateActionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("6b69b085-468b-423e-aade-db70d5dbdc13"),
				Name = @"Action",
				ReferenceSchemaUId = new Guid("41879c50-004a-4a40-9080-fe06a2f6b1c3"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("bcf4752b-140d-4a7d-9c1b-8a3651dde04c"),
				ModifiedInSchemaUId = new Guid("bcf4752b-140d-4a7d-9c1b-8a3651dde04c"),
				CreatedInPackageId = new Guid("bac310da-8f6a-4932-87be-74eb3d9d7067")
			};
		}

		protected virtual EntitySchemaColumn CreateSessionIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("e88b7112-a762-43e5-bb15-52178aa314f7"),
				Name = @"SessionId",
				CreatedInSchemaUId = new Guid("bcf4752b-140d-4a7d-9c1b-8a3651dde04c"),
				ModifiedInSchemaUId = new Guid("bcf4752b-140d-4a7d-9c1b-8a3651dde04c"),
				CreatedInPackageId = new Guid("6c038aa0-46cd-4697-bc93-5c682e364aef")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateVwCampaignLogEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateVwCampaignLogEventsProcessSchema() {
			var schema = new VwCampaignLogEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new VwCampaignLog(userConnection){Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new VwCampaignLog_CampaignsEventsProcess(userConnnection);
		}

		public override object Clone() {
			return new VwCampaignLogSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new VwCampaignLogSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("bcf4752b-140d-4a7d-9c1b-8a3651dde04c"));
		}

		#endregion

	}

	#endregion

	#region Class: VwCampaignLog

	/// <summary>
	/// Campaign log.
	/// </summary>
	public class VwCampaignLog : Terrasoft.Core.Entities.Entity
	{

		#region Constructors: Public

		public VwCampaignLog(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "VwCampaignLog";
		}

		public VwCampaignLog(VwCampaignLog source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Id.
		/// </summary>
		public Guid Id {
			get {
				return GetTypedColumnValue<Guid>("Id");
			}
			set {
				SetColumnValue("Id", value);
			}
		}

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
		/// Step.
		/// </summary>
		public CampaignItem CampaignItem {
			get {
				return _campaignItem ??
					(_campaignItem = LookupColumnEntities.GetEntity("CampaignItem") as CampaignItem);
			}
		}

		/// <summary>
		/// Participants.
		/// </summary>
		public int Amount {
			get {
				return GetTypedColumnValue<int>("Amount");
			}
			set {
				SetColumnValue("Amount", value);
			}
		}

		/// <summary>
		/// Created on.
		/// </summary>
		public DateTime CreatedOn {
			get {
				return GetTypedColumnValue<DateTime>("CreatedOn");
			}
			set {
				SetColumnValue("CreatedOn", value);
			}
		}

		/// <summary>
		/// Scheduled date.
		/// </summary>
		public DateTime ScheduledDate {
			get {
				return GetTypedColumnValue<DateTime>("ScheduledDate");
			}
			set {
				SetColumnValue("ScheduledDate", value);
			}
		}

		/// <summary>
		/// Start date.
		/// </summary>
		public DateTime StartDate {
			get {
				return GetTypedColumnValue<DateTime>("StartDate");
			}
			set {
				SetColumnValue("StartDate", value);
			}
		}

		/// <summary>
		/// End date.
		/// </summary>
		public DateTime EndDate {
			get {
				return GetTypedColumnValue<DateTime>("EndDate");
			}
			set {
				SetColumnValue("EndDate", value);
			}
		}

		/// <summary>
		/// Error details.
		/// </summary>
		public string ErrorText {
			get {
				return GetTypedColumnValue<string>("ErrorText");
			}
			set {
				SetColumnValue("ErrorText", value);
			}
		}

		/// <summary>
		/// Duration, sec..
		/// </summary>
		public int DurationSs {
			get {
				return GetTypedColumnValue<int>("DurationSs");
			}
			set {
				SetColumnValue("DurationSs", value);
			}
		}

		/// <summary>
		/// Duration, min..
		/// </summary>
		public int DurationMi {
			get {
				return GetTypedColumnValue<int>("DurationMi");
			}
			set {
				SetColumnValue("DurationMi", value);
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

		private CampaignLogStatus _status;
		/// <summary>
		/// Status.
		/// </summary>
		public CampaignLogStatus Status {
			get {
				return _status ??
					(_status = LookupColumnEntities.GetEntity("Status") as CampaignLogStatus);
			}
		}

		/// <exclude/>
		public Guid ActionId {
			get {
				return GetTypedColumnValue<Guid>("ActionId");
			}
			set {
				SetColumnValue("ActionId", value);
				_action = null;
			}
		}

		/// <exclude/>
		public string ActionName {
			get {
				return GetTypedColumnValue<string>("ActionName");
			}
			set {
				SetColumnValue("ActionName", value);
				if (_action != null) {
					_action.Name = value;
				}
			}
		}

		private CampaignLogItemType _action;
		/// <summary>
		/// Action.
		/// </summary>
		public CampaignLogItemType Action {
			get {
				return _action ??
					(_action = LookupColumnEntities.GetEntity("Action") as CampaignLogItemType);
			}
		}

		/// <summary>
		/// SessionId.
		/// </summary>
		public Guid SessionId {
			get {
				return GetTypedColumnValue<Guid>("SessionId");
			}
			set {
				SetColumnValue("SessionId", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new VwCampaignLog_CampaignsEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Validating += (s, e) => ThrowEvent("VwCampaignLogValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new VwCampaignLog(this);
		}

		#endregion

	}

	#endregion

	#region Class: VwCampaignLog_CampaignsEventsProcess

	/// <exclude/>
	public class VwCampaignLog_CampaignsEventsProcess<TEntity> : Terrasoft.Core.Process.EmbeddedProcess where TEntity : VwCampaignLog
	{

		private TEntity _entity;
		public TEntity Entity {
			get {
				return _entity;
			}
			set {
				_entity = value;
			}
		}

		public VwCampaignLog_CampaignsEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "VwCampaignLog_CampaignsEventsProcess";
			SchemaUId = new Guid("bcf4752b-140d-4a7d-9c1b-8a3651dde04c");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("bcf4752b-140d-4a7d-9c1b-8a3651dde04c");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
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

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
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

	#region Class: VwCampaignLog_CampaignsEventsProcess

	/// <exclude/>
	public class VwCampaignLog_CampaignsEventsProcess : VwCampaignLog_CampaignsEventsProcess<VwCampaignLog>
	{

		public VwCampaignLog_CampaignsEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: VwCampaignLogEventsProcessSchema

	/// <exclude/>
	public class VwCampaignLogEventsProcessSchema : Terrasoft.Core.Process.EmbeddedProcessSchema
	{

		#region Constructors: Public

		public VwCampaignLogEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public VwCampaignLogEventsProcessSchema(VwCampaignLogEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "VwCampaignLog_CampaignsEventsProcess";
			UId = new Guid("6697848e-08b3-44ab-bd1e-2735951c39fa");
			CreatedInPackageId = new Guid("bac310da-8f6a-4932-87be-74eb3d9d7067");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
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
			ProcessSchemaLaneSet schemaLaneSet2_cfc0909a0c7040e6b5ff6279ed5fc113 = CreateLaneSet2_cfc0909a0c7040e6b5ff6279ed5fc113LaneSet();
			LaneSets.Add(schemaLaneSet2_cfc0909a0c7040e6b5ff6279ed5fc113);
			ProcessSchemaLane schemaLane1_8f34ecfc7feb4829b9e179c00dbdf7b2 = CreateLane1_8f34ecfc7feb4829b9e179c00dbdf7b2Lane();
			schemaLaneSet2_cfc0909a0c7040e6b5ff6279ed5fc113.Lanes.Add(schemaLane1_8f34ecfc7feb4829b9e179c00dbdf7b2);
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet2_cfc0909a0c7040e6b5ff6279ed5fc113LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet2_cfc0909a0c7040e6b5ff6279ed5fc113 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("cfc0909a-0c70-40e6-b5ff-6279ed5fc113"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("bac310da-8f6a-4932-87be-74eb3d9d7067"),
				CreatedInSchemaUId = new Guid("6697848e-08b3-44ab-bd1e-2735951c39fa"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("6697848e-08b3-44ab-bd1e-2735951c39fa"),
				Name = @"LaneSet2_cfc0909a0c7040e6b5ff6279ed5fc113",
				Position = new Point(0, 5),
				Size = new Size(0, 400),
				UseBackgroundMode = false
			};
			return schemaLaneSet2_cfc0909a0c7040e6b5ff6279ed5fc113;
		}

		protected virtual ProcessSchemaLane CreateLane1_8f34ecfc7feb4829b9e179c00dbdf7b2Lane() {
			ProcessSchemaLane schemaLane1_8f34ecfc7feb4829b9e179c00dbdf7b2 = new ProcessSchemaLane(this) {
				UId = new Guid("8f34ecfc-7feb-4829-b9e1-79c00dbdf7b2"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("cfc0909a-0c70-40e6-b5ff-6279ed5fc113"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("bac310da-8f6a-4932-87be-74eb3d9d7067"),
				CreatedInSchemaUId = new Guid("6697848e-08b3-44ab-bd1e-2735951c39fa"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("6697848e-08b3-44ab-bd1e-2735951c39fa"),
				Name = @"Lane1_8f34ecfc7feb4829b9e179c00dbdf7b2",
				Position = new Point(0, 0),
				Size = new Size(700, 400),
				UseBackgroundMode = false
			};
			return schemaLane1_8f34ecfc7feb4829b9e179c00dbdf7b2;
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

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new VwCampaignLogEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("6697848e-08b3-44ab-bd1e-2735951c39fa"));
		}

		#endregion

	}

	#endregion


	#region Class: VwCampaignLogEventsProcess

	/// <exclude/>
	public class VwCampaignLogEventsProcess : VwCampaignLog_CampaignsEventsProcess
	{

		public VwCampaignLogEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

