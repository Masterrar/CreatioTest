namespace Terrasoft.Configuration
{

	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Drawing;
	using System.Globalization;
	using System.IO;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;

	#region Class: CmpgnPrtcpntEmailTargetOpSchema

	/// <exclude/>
	public class CmpgnPrtcpntEmailTargetOpSchema : Terrasoft.Core.Entities.EntitySchema
	{

		#region Constructors: Public

		public CmpgnPrtcpntEmailTargetOpSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public CmpgnPrtcpntEmailTargetOpSchema(CmpgnPrtcpntEmailTargetOpSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public CmpgnPrtcpntEmailTargetOpSchema(CmpgnPrtcpntEmailTargetOpSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("db6ddc59-17bc-4017-984b-55d8c7895d61");
			RealUId = new Guid("db6ddc59-17bc-4017-984b-55d8c7895d61");
			Name = "CmpgnPrtcpntEmailTargetOp";
			ParentSchemaUId = new Guid("1b56b061-4e91-4974-9038-df8340e534f2");
			ExtendParent = false;
			CreatedInPackageId = new Guid("6c038aa0-46cd-4697-bc93-5c682e364aef");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializePrimaryColumn() {
			base.InitializePrimaryColumn();
			PrimaryColumn = CreateMandrillRecipientUIdColumn();
			if (Columns.FindByUId(PrimaryColumn.UId) == null) {
				Columns.Add(PrimaryColumn);
			}
		}

		protected override void InitializePrimaryOrderColumn() {
			base.InitializePrimaryOrderColumn();
			PrimaryOrderColumn = CreateMandrillRecipientUIdColumn();
			if (Columns.FindByUId(PrimaryOrderColumn.UId) == null) {
				Columns.Add(PrimaryOrderColumn);
			}
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("0c270820-432a-47af-9840-4b0496b336db")) == null) {
				Columns.Add(CreateCampaignParticipantIdColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateMandrillRecipientUIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("84ad9018-b52d-454d-821a-d30ed2a3d98d"),
				Name = @"MandrillRecipientUId",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("db6ddc59-17bc-4017-984b-55d8c7895d61"),
				ModifiedInSchemaUId = new Guid("db6ddc59-17bc-4017-984b-55d8c7895d61"),
				CreatedInPackageId = new Guid("6c038aa0-46cd-4697-bc93-5c682e364aef")
			};
		}

		protected virtual EntitySchemaColumn CreateCampaignParticipantIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("0c270820-432a-47af-9840-4b0496b336db"),
				Name = @"CampaignParticipantId",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("db6ddc59-17bc-4017-984b-55d8c7895d61"),
				ModifiedInSchemaUId = new Guid("db6ddc59-17bc-4017-984b-55d8c7895d61"),
				CreatedInPackageId = new Guid("6c038aa0-46cd-4697-bc93-5c682e364aef")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateCmpgnPrtcpntEmailTargetOpEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateCmpgnPrtcpntEmailTargetOpEventsProcessSchema() {
			var schema = new CmpgnPrtcpntEmailTargetOpEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new CmpgnPrtcpntEmailTargetOp(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new CmpgnPrtcpntEmailTargetOp_CampaignsEventsProcess(userConnection);
		}

		public override object Clone() {
			return new CmpgnPrtcpntEmailTargetOpSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new CmpgnPrtcpntEmailTargetOpSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("db6ddc59-17bc-4017-984b-55d8c7895d61"));
		}

		#endregion

	}

	#endregion

	#region Class: CmpgnPrtcpntEmailTargetOp

	/// <summary>
	/// Entity to map CampaignParticipantOp and MandrillRecipient.
	/// </summary>
	public class CmpgnPrtcpntEmailTargetOp : Terrasoft.Core.Entities.Entity
	{

		#region Constructors: Public

		public CmpgnPrtcpntEmailTargetOp(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "CmpgnPrtcpntEmailTargetOp";
		}

		public CmpgnPrtcpntEmailTargetOp(CmpgnPrtcpntEmailTargetOp source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// MandrillRecipientUId.
		/// </summary>
		public Guid MandrillRecipientUId {
			get {
				return GetTypedColumnValue<Guid>("MandrillRecipientUId");
			}
			set {
				SetColumnValue("MandrillRecipientUId", value);
			}
		}

		public Guid CampaignParticipantId {
			get {
				return GetTypedColumnValue<Guid>("CampaignParticipantId");
			}
			set {
				SetColumnValue("CampaignParticipantId", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new CmpgnPrtcpntEmailTargetOp_CampaignsEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new CmpgnPrtcpntEmailTargetOp(this);
		}

		#endregion

	}

	#endregion

	#region Class: CmpgnPrtcpntEmailTargetOp_CampaignsEventsProcess

	/// <exclude/>
	public class CmpgnPrtcpntEmailTargetOp_CampaignsEventsProcess<TEntity> : Terrasoft.Core.Process.EmbeddedProcess where TEntity : CmpgnPrtcpntEmailTargetOp
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

		public CmpgnPrtcpntEmailTargetOp_CampaignsEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "CmpgnPrtcpntEmailTargetOp_CampaignsEventsProcess";
			SchemaUId = new Guid("db6ddc59-17bc-4017-984b-55d8c7895d61");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("db6ddc59-17bc-4017-984b-55d8c7895d61");
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

	#region Class: CmpgnPrtcpntEmailTargetOp_CampaignsEventsProcess

	/// <exclude/>
	public class CmpgnPrtcpntEmailTargetOp_CampaignsEventsProcess : CmpgnPrtcpntEmailTargetOp_CampaignsEventsProcess<CmpgnPrtcpntEmailTargetOp>
	{

		public CmpgnPrtcpntEmailTargetOp_CampaignsEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: CmpgnPrtcpntEmailTargetOpEventsProcessSchema

	/// <exclude/>
	public class CmpgnPrtcpntEmailTargetOpEventsProcessSchema : Terrasoft.Core.Process.EmbeddedProcessSchema
	{

		#region Constructors: Public

		public CmpgnPrtcpntEmailTargetOpEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public CmpgnPrtcpntEmailTargetOpEventsProcessSchema(CmpgnPrtcpntEmailTargetOpEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "CmpgnPrtcpntEmailTargetOp_CampaignsEventsProcess";
			UId = new Guid("1c4e5b5d-1ec1-4107-8eaa-fcfda3631530");
			CreatedInPackageId = new Guid("6c038aa0-46cd-4697-bc93-5c682e364aef");
			CreatedInSchemaUId = Guid.Empty;
			CreatedInVersion = @"0.0.0.0";
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d");
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

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new CmpgnPrtcpntEmailTargetOpEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("1c4e5b5d-1ec1-4107-8eaa-fcfda3631530"));
		}

		#endregion

	}

	#endregion


	#region Class: CmpgnPrtcpntEmailTargetOpEventsProcess

	/// <exclude/>
	public class CmpgnPrtcpntEmailTargetOpEventsProcess : CmpgnPrtcpntEmailTargetOp_CampaignsEventsProcess
	{

		public CmpgnPrtcpntEmailTargetOpEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

