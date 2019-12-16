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

	#region Class: CmpgnPrtcpntEmailTargetSchema

	/// <exclude/>
	public class CmpgnPrtcpntEmailTargetSchema : Terrasoft.Core.Entities.EntitySchema
	{

		#region Constructors: Public

		public CmpgnPrtcpntEmailTargetSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public CmpgnPrtcpntEmailTargetSchema(CmpgnPrtcpntEmailTargetSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public CmpgnPrtcpntEmailTargetSchema(CmpgnPrtcpntEmailTargetSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e521c31e-477e-4297-bb95-8ccf475cb11c");
			RealUId = new Guid("e521c31e-477e-4297-bb95-8ccf475cb11c");
			Name = "CmpgnPrtcpntEmailTarget";
			ParentSchemaUId = new Guid("1b56b061-4e91-4974-9038-df8340e534f2");
			ExtendParent = false;
			CreatedInPackageId = new Guid("d0bba11f-3986-4819-81ab-1d3ddbfc1f48");
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
			if (Columns.FindByUId(new Guid("ccb81fc9-f79f-45f9-96fd-03d265f8ac90")) == null) {
				Columns.Add(CreateCampaignParticipantIdColumn());
			}
			if (Columns.FindByUId(new Guid("71f330ca-e2d6-4e25-8298-d86830dbdc2d")) == null) {
				Columns.Add(CreateWasUsedColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateMandrillRecipientUIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("97eef402-9812-43a4-ba42-04a367d411f3"),
				Name = @"MandrillRecipientUId",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("e521c31e-477e-4297-bb95-8ccf475cb11c"),
				ModifiedInSchemaUId = new Guid("e521c31e-477e-4297-bb95-8ccf475cb11c"),
				CreatedInPackageId = new Guid("d0bba11f-3986-4819-81ab-1d3ddbfc1f48")
			};
		}

		protected virtual EntitySchemaColumn CreateCampaignParticipantIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("ccb81fc9-f79f-45f9-96fd-03d265f8ac90"),
				Name = @"CampaignParticipantId",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("e521c31e-477e-4297-bb95-8ccf475cb11c"),
				ModifiedInSchemaUId = new Guid("e521c31e-477e-4297-bb95-8ccf475cb11c"),
				CreatedInPackageId = new Guid("6c038aa0-46cd-4697-bc93-5c682e364aef")
			};
		}

		protected virtual EntitySchemaColumn CreateWasUsedColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("71f330ca-e2d6-4e25-8298-d86830dbdc2d"),
				Name = @"WasUsed",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("e521c31e-477e-4297-bb95-8ccf475cb11c"),
				ModifiedInSchemaUId = new Guid("e521c31e-477e-4297-bb95-8ccf475cb11c"),
				CreatedInPackageId = new Guid("6c038aa0-46cd-4697-bc93-5c682e364aef"),
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
			EventsProcessSchema = CreateCmpgnPrtcpntEmailTargetEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateCmpgnPrtcpntEmailTargetEventsProcessSchema() {
			var schema = new CmpgnPrtcpntEmailTargetEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new CmpgnPrtcpntEmailTarget(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new CmpgnPrtcpntEmailTarget_CampaignsEventsProcess(userConnection);
		}

		public override object Clone() {
			return new CmpgnPrtcpntEmailTargetSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new CmpgnPrtcpntEmailTargetSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e521c31e-477e-4297-bb95-8ccf475cb11c"));
		}

		#endregion

	}

	#endregion

	#region Class: CmpgnPrtcpntEmailTarget

	/// <summary>
	/// Entity to map CampaignParticipant and MandrillRecipient.
	/// </summary>
	public class CmpgnPrtcpntEmailTarget : Terrasoft.Core.Entities.Entity
	{

		#region Constructors: Public

		public CmpgnPrtcpntEmailTarget(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "CmpgnPrtcpntEmailTarget";
		}

		public CmpgnPrtcpntEmailTarget(CmpgnPrtcpntEmailTarget source)
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

		/// <summary>
		/// CampaignParticipant.
		/// </summary>
		public Guid CampaignParticipantId {
			get {
				return GetTypedColumnValue<Guid>("CampaignParticipantId");
			}
			set {
				SetColumnValue("CampaignParticipantId", value);
			}
		}

		/// <summary>
		/// WasUsed.
		/// </summary>
		public bool WasUsed {
			get {
				return GetTypedColumnValue<bool>("WasUsed");
			}
			set {
				SetColumnValue("WasUsed", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new CmpgnPrtcpntEmailTarget_CampaignsEventsProcess(UserConnection);
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
			return new CmpgnPrtcpntEmailTarget(this);
		}

		#endregion

	}

	#endregion

	#region Class: CmpgnPrtcpntEmailTarget_CampaignsEventsProcess

	/// <exclude/>
	public class CmpgnPrtcpntEmailTarget_CampaignsEventsProcess<TEntity> : Terrasoft.Core.Process.EmbeddedProcess where TEntity : CmpgnPrtcpntEmailTarget
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

		public CmpgnPrtcpntEmailTarget_CampaignsEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "CmpgnPrtcpntEmailTarget_CampaignsEventsProcess";
			SchemaUId = new Guid("e521c31e-477e-4297-bb95-8ccf475cb11c");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("e521c31e-477e-4297-bb95-8ccf475cb11c");
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

	#region Class: CmpgnPrtcpntEmailTarget_CampaignsEventsProcess

	/// <exclude/>
	public class CmpgnPrtcpntEmailTarget_CampaignsEventsProcess : CmpgnPrtcpntEmailTarget_CampaignsEventsProcess<CmpgnPrtcpntEmailTarget>
	{

		public CmpgnPrtcpntEmailTarget_CampaignsEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: CmpgnPrtcpntEmailTargetEventsProcessSchema

	/// <exclude/>
	public class CmpgnPrtcpntEmailTargetEventsProcessSchema : Terrasoft.Core.Process.EmbeddedProcessSchema
	{

		#region Constructors: Public

		public CmpgnPrtcpntEmailTargetEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public CmpgnPrtcpntEmailTargetEventsProcessSchema(CmpgnPrtcpntEmailTargetEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "CmpgnPrtcpntEmailTarget_CampaignsEventsProcess";
			UId = new Guid("a2fcda51-45a3-4db8-b80d-5e242c2dafd6");
			CreatedInPackageId = new Guid("d0bba11f-3986-4819-81ab-1d3ddbfc1f48");
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
			return new CmpgnPrtcpntEmailTargetEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a2fcda51-45a3-4db8-b80d-5e242c2dafd6"));
		}

		#endregion

	}

	#endregion


	#region Class: CmpgnPrtcpntEmailTargetEventsProcess

	/// <exclude/>
	public class CmpgnPrtcpntEmailTargetEventsProcess : CmpgnPrtcpntEmailTarget_CampaignsEventsProcess
	{

		public CmpgnPrtcpntEmailTargetEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

