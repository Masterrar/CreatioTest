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

	#region Class: RawMandrillEventSchema

	/// <exclude/>
	public class RawMandrillEventSchema : Terrasoft.Core.Entities.EntitySchema
	{

		#region Constructors: Public

		public RawMandrillEventSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public RawMandrillEventSchema(RawMandrillEventSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public RawMandrillEventSchema(RawMandrillEventSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("0806fb23-ad70-4e20-86cc-f48306bf4bcc");
			RealUId = new Guid("0806fb23-ad70-4e20-86cc-f48306bf4bcc");
			Name = "RawMandrillEvent";
			ParentSchemaUId = new Guid("1b56b061-4e91-4974-9038-df8340e534f2");
			ExtendParent = false;
			CreatedInPackageId = new Guid("b477c174-1d53-4a21-b489-a41e481a96a0");
			IsDBView = false;
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
			if (Columns.FindByUId(new Guid("e05e8c5a-ccee-466c-9970-cffee53d9667")) == null) {
				Columns.Add(CreateJsonDataColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("f271f2ab-e555-4ca7-b2a6-2afba1c7425a"),
				Name = @"Id",
				CreatedInSchemaUId = new Guid("0806fb23-ad70-4e20-86cc-f48306bf4bcc"),
				ModifiedInSchemaUId = new Guid("0806fb23-ad70-4e20-86cc-f48306bf4bcc"),
				CreatedInPackageId = new Guid("b477c174-1d53-4a21-b489-a41e481a96a0")
			};
		}

		protected virtual EntitySchemaColumn CreateJsonDataColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("File")) {
				UId = new Guid("e05e8c5a-ccee-466c-9970-cffee53d9667"),
				Name = @"JsonData",
				CreatedInSchemaUId = new Guid("0806fb23-ad70-4e20-86cc-f48306bf4bcc"),
				ModifiedInSchemaUId = new Guid("0806fb23-ad70-4e20-86cc-f48306bf4bcc"),
				CreatedInPackageId = new Guid("b477c174-1d53-4a21-b489-a41e481a96a0")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateRawMandrillEventEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateRawMandrillEventEventsProcessSchema() {
			var schema = new RawMandrillEventEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new RawMandrillEvent(userConnection){Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new RawMandrillEvent_MarketingCampaignEventsProcess(userConnnection);
		}

		public override object Clone() {
			return new RawMandrillEventSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new RawMandrillEventSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("0806fb23-ad70-4e20-86cc-f48306bf4bcc"));
		}

		#endregion

	}

	#endregion

	#region Class: RawMandrillEvent

	/// <summary>
	/// Mandrill pre-processed events.
	/// </summary>
	public class RawMandrillEvent : Terrasoft.Core.Entities.Entity
	{

		#region Constructors: Public

		public RawMandrillEvent(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "RawMandrillEvent";
		}

		public RawMandrillEvent(RawMandrillEvent source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Id.
		/// </summary>
		public  Guid Id {
			get {
				return GetTypedColumnValue<Guid>("Id");
			}
			set {
				SetColumnValue("Id", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new RawMandrillEvent_MarketingCampaignEventsProcess(UserConnection);
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
			return new RawMandrillEvent(this);
		}

		#endregion

	}

	#endregion

	#region Class: RawMandrillEvent_MarketingCampaignEventsProcess

	/// <exclude/>
	public class RawMandrillEvent_MarketingCampaignEventsProcess<TEntity> : Terrasoft.Core.Process.EmbeddedProcess where TEntity : RawMandrillEvent
	{

		private TEntity _entity;
		public  TEntity Entity {
			get {
				return _entity;
			}
			set {
				_entity = value;
			}
		}

		public RawMandrillEvent_MarketingCampaignEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "RawMandrillEvent_MarketingCampaignEventsProcess";
			SchemaUId = new Guid("0806fb23-ad70-4e20-86cc-f48306bf4bcc");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private  Guid InternalSchemaUId {
			get {
				return new Guid("0806fb23-ad70-4e20-86cc-f48306bf4bcc");
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

	#region Class: RawMandrillEvent_MarketingCampaignEventsProcess

	/// <exclude/>
	public class RawMandrillEvent_MarketingCampaignEventsProcess : RawMandrillEvent_MarketingCampaignEventsProcess<RawMandrillEvent>
	{

		public RawMandrillEvent_MarketingCampaignEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: RawMandrillEventEventsProcessSchema

	/// <exclude/>
	public class RawMandrillEventEventsProcessSchema : Terrasoft.Core.Process.EmbeddedProcessSchema
	{

		#region Constructors: Public

		public RawMandrillEventEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public RawMandrillEventEventsProcessSchema(RawMandrillEventEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "RawMandrillEvent_MarketingCampaignEventsProcess";
			UId = new Guid("ec8669b2-862c-4c68-be10-51c986d3dfc9");
			CreatedInPackageId = new Guid("b477c174-1d53-4a21-b489-a41e481a96a0");
			CreatedInSchemaUId = Guid.Empty;
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
			return new RawMandrillEventEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ec8669b2-862c-4c68-be10-51c986d3dfc9"));
		}

		#endregion

	}

	#endregion


	#region Class: RawMandrillEventEventsProcess

	/// <exclude/>
	public class RawMandrillEventEventsProcess : RawMandrillEvent_MarketingCampaignEventsProcess
	{

		public RawMandrillEventEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

