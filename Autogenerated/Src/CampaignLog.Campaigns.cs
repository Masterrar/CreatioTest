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

	#region Class: CampaignLogSchema

	/// <exclude/>
	public class CampaignLogSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public CampaignLogSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public CampaignLogSchema(CampaignLogSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public CampaignLogSchema(CampaignLogSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("aeffc7bd-6d4c-4564-ac0a-b4a0dbd188c8");
			RealUId = new Guid("aeffc7bd-6d4c-4564-ac0a-b4a0dbd188c8");
			Name = "CampaignLog";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("01139456-0b6f-48fc-aabd-4d1589d97f4a")) == null) {
				Columns.Add(CreateCampaignColumn());
			}
			if (Columns.FindByUId(new Guid("6a9ba575-7dd3-4628-a58d-f44f92dea791")) == null) {
				Columns.Add(CreateCampaignItemColumn());
			}
			if (Columns.FindByUId(new Guid("7528fc30-0761-4ef8-b265-e4625d5e6405")) == null) {
				Columns.Add(CreateAmountColumn());
			}
			if (Columns.FindByUId(new Guid("fa3bd00c-cbe7-46a9-a572-ba5af2cd40c1")) == null) {
				Columns.Add(CreateScheduledDateColumn());
			}
			if (Columns.FindByUId(new Guid("a46d9bb5-9764-4b5c-a317-a56f9d467038")) == null) {
				Columns.Add(CreateStartDateColumn());
			}
			if (Columns.FindByUId(new Guid("1b823cd3-17d1-430c-850d-51aa5ab8505a")) == null) {
				Columns.Add(CreateEndDateColumn());
			}
			if (Columns.FindByUId(new Guid("463b7178-3ccb-4068-ae8d-6c882ddbbe6d")) == null) {
				Columns.Add(CreateErrorTextColumn());
			}
			if (Columns.FindByUId(new Guid("dcca3aa5-44b4-4d9a-98d4-56b0dfafc3b8")) == null) {
				Columns.Add(CreateStatusColumn());
			}
			if (Columns.FindByUId(new Guid("35226220-0079-43a1-b337-a1312505d32e")) == null) {
				Columns.Add(CreateActionColumn());
			}
			if (Columns.FindByUId(new Guid("b821eac9-af70-45ae-a453-1db15fd218ea")) == null) {
				Columns.Add(CreateSessionIdColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateCampaignColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("01139456-0b6f-48fc-aabd-4d1589d97f4a"),
				Name = @"Campaign",
				ReferenceSchemaUId = new Guid("1f9bb71a-eb9c-4220-a40e-9b623eacfec8"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("aeffc7bd-6d4c-4564-ac0a-b4a0dbd188c8"),
				ModifiedInSchemaUId = new Guid("aeffc7bd-6d4c-4564-ac0a-b4a0dbd188c8"),
				CreatedInPackageId = new Guid("3e5ddb1d-f56b-4045-8996-c13027d63563")
			};
		}

		protected virtual EntitySchemaColumn CreateCampaignItemColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("6a9ba575-7dd3-4628-a58d-f44f92dea791"),
				Name = @"CampaignItem",
				ReferenceSchemaUId = new Guid("28045fad-1d04-4bb5-8600-ed4ca87b5650"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("aeffc7bd-6d4c-4564-ac0a-b4a0dbd188c8"),
				ModifiedInSchemaUId = new Guid("aeffc7bd-6d4c-4564-ac0a-b4a0dbd188c8"),
				CreatedInPackageId = new Guid("3e5ddb1d-f56b-4045-8996-c13027d63563")
			};
		}

		protected virtual EntitySchemaColumn CreateAmountColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("7528fc30-0761-4ef8-b265-e4625d5e6405"),
				Name = @"Amount",
				CreatedInSchemaUId = new Guid("aeffc7bd-6d4c-4564-ac0a-b4a0dbd188c8"),
				ModifiedInSchemaUId = new Guid("aeffc7bd-6d4c-4564-ac0a-b4a0dbd188c8"),
				CreatedInPackageId = new Guid("3e5ddb1d-f56b-4045-8996-c13027d63563")
			};
		}

		protected virtual EntitySchemaColumn CreateScheduledDateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("DateTime")) {
				UId = new Guid("fa3bd00c-cbe7-46a9-a572-ba5af2cd40c1"),
				Name = @"ScheduledDate",
				CreatedInSchemaUId = new Guid("aeffc7bd-6d4c-4564-ac0a-b4a0dbd188c8"),
				ModifiedInSchemaUId = new Guid("aeffc7bd-6d4c-4564-ac0a-b4a0dbd188c8"),
				CreatedInPackageId = new Guid("3e5ddb1d-f56b-4045-8996-c13027d63563")
			};
		}

		protected virtual EntitySchemaColumn CreateStartDateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("DateTime")) {
				UId = new Guid("a46d9bb5-9764-4b5c-a317-a56f9d467038"),
				Name = @"StartDate",
				CreatedInSchemaUId = new Guid("aeffc7bd-6d4c-4564-ac0a-b4a0dbd188c8"),
				ModifiedInSchemaUId = new Guid("aeffc7bd-6d4c-4564-ac0a-b4a0dbd188c8"),
				CreatedInPackageId = new Guid("3e5ddb1d-f56b-4045-8996-c13027d63563")
			};
		}

		protected virtual EntitySchemaColumn CreateEndDateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("DateTime")) {
				UId = new Guid("1b823cd3-17d1-430c-850d-51aa5ab8505a"),
				Name = @"EndDate",
				CreatedInSchemaUId = new Guid("aeffc7bd-6d4c-4564-ac0a-b4a0dbd188c8"),
				ModifiedInSchemaUId = new Guid("aeffc7bd-6d4c-4564-ac0a-b4a0dbd188c8"),
				CreatedInPackageId = new Guid("3e5ddb1d-f56b-4045-8996-c13027d63563")
			};
		}

		protected virtual EntitySchemaColumn CreateErrorTextColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("463b7178-3ccb-4068-ae8d-6c882ddbbe6d"),
				Name = @"ErrorText",
				CreatedInSchemaUId = new Guid("aeffc7bd-6d4c-4564-ac0a-b4a0dbd188c8"),
				ModifiedInSchemaUId = new Guid("aeffc7bd-6d4c-4564-ac0a-b4a0dbd188c8"),
				CreatedInPackageId = new Guid("3e5ddb1d-f56b-4045-8996-c13027d63563")
			};
		}

		protected virtual EntitySchemaColumn CreateStatusColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("dcca3aa5-44b4-4d9a-98d4-56b0dfafc3b8"),
				Name = @"Status",
				ReferenceSchemaUId = new Guid("05938a8b-b4ed-4a29-85df-478ca8d8adfd"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("aeffc7bd-6d4c-4564-ac0a-b4a0dbd188c8"),
				ModifiedInSchemaUId = new Guid("aeffc7bd-6d4c-4564-ac0a-b4a0dbd188c8"),
				CreatedInPackageId = new Guid("bac310da-8f6a-4932-87be-74eb3d9d7067")
			};
		}

		protected virtual EntitySchemaColumn CreateActionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("35226220-0079-43a1-b337-a1312505d32e"),
				Name = @"Action",
				ReferenceSchemaUId = new Guid("41879c50-004a-4a40-9080-fe06a2f6b1c3"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("aeffc7bd-6d4c-4564-ac0a-b4a0dbd188c8"),
				ModifiedInSchemaUId = new Guid("aeffc7bd-6d4c-4564-ac0a-b4a0dbd188c8"),
				CreatedInPackageId = new Guid("bac310da-8f6a-4932-87be-74eb3d9d7067")
			};
		}

		protected virtual EntitySchemaColumn CreateSessionIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("b821eac9-af70-45ae-a453-1db15fd218ea"),
				Name = @"SessionId",
				CreatedInSchemaUId = new Guid("aeffc7bd-6d4c-4564-ac0a-b4a0dbd188c8"),
				ModifiedInSchemaUId = new Guid("aeffc7bd-6d4c-4564-ac0a-b4a0dbd188c8"),
				CreatedInPackageId = new Guid("6c038aa0-46cd-4697-bc93-5c682e364aef")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateCampaignLogEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateCampaignLogEventsProcessSchema() {
			var schema = new CampaignLogEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new CampaignLog(userConnection){Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new CampaignLog_CampaignsEventsProcess(userConnnection);
		}

		public override object Clone() {
			return new CampaignLogSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new CampaignLogSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("aeffc7bd-6d4c-4564-ac0a-b4a0dbd188c8"));
		}

		#endregion

	}

	#endregion

	#region Class: CampaignLog

	/// <summary>
	/// SysCampaignLog.
	/// </summary>
	public class CampaignLog : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public CampaignLog(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "CampaignLog";
		}

		public CampaignLog(CampaignLog source)
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
		/// <remarks>
		/// Session Id.
		/// </remarks>
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
			var process = new CampaignLog_CampaignsEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("CampaignLogDeleted", e);
			Validating += (s, e) => ThrowEvent("CampaignLogValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new CampaignLog(this);
		}

		#endregion

	}

	#endregion

	#region Class: CampaignLog_CampaignsEventsProcess

	/// <exclude/>
	public class CampaignLog_CampaignsEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_LocalMessageEventsProcess<TEntity> where TEntity : CampaignLog
	{

		public CampaignLog_CampaignsEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "CampaignLog_CampaignsEventsProcess";
			SchemaUId = new Guid("aeffc7bd-6d4c-4564-ac0a-b4a0dbd188c8");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("aeffc7bd-6d4c-4564-ac0a-b4a0dbd188c8");
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

	#region Class: CampaignLog_CampaignsEventsProcess

	/// <exclude/>
	public class CampaignLog_CampaignsEventsProcess : CampaignLog_CampaignsEventsProcess<CampaignLog>
	{

		public CampaignLog_CampaignsEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: CampaignLogEventsProcessSchema

	/// <exclude/>
	public class CampaignLogEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public CampaignLogEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public CampaignLogEventsProcessSchema(CampaignLogEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "CampaignLog_CampaignsEventsProcess";
			UId = new Guid("087701a3-fdf0-4457-ba42-0a6bd483e6d9");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
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

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new CampaignLogEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("087701a3-fdf0-4457-ba42-0a6bd483e6d9"));
		}

		#endregion

	}

	#endregion


	#region Class: CampaignLogEventsProcess

	/// <exclude/>
	public class CampaignLogEventsProcess : CampaignLog_CampaignsEventsProcess
	{

		public CampaignLogEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

