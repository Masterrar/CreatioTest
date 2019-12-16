﻿namespace Terrasoft.Configuration
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

	#region Class: DomainInfoSchema

	/// <exclude/>
	[IsVirtual]
	public class DomainInfoSchema : Terrasoft.Core.Entities.EntitySchema
	{

		#region Constructors: Public

		public DomainInfoSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public DomainInfoSchema(DomainInfoSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public DomainInfoSchema(DomainInfoSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("abb2448c-6f83-4363-b02e-0afa5e052a89");
			RealUId = new Guid("abb2448c-6f83-4363-b02e-0afa5e052a89");
			Name = "DomainInfo";
			ParentSchemaUId = new Guid("1b56b061-4e91-4974-9038-df8340e534f2");
			ExtendParent = false;
			CreatedInPackageId = new Guid("6b0d8068-2d05-42af-bf7c-865991421ad7");
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
			if (Columns.FindByUId(new Guid("5c1aae21-3f84-4e6b-af38-538e4e43644c")) == null) {
				Columns.Add(CreateDomainColumn());
			}
			if (Columns.FindByUId(new Guid("7183eb9d-7615-4195-b4a4-77b24819f843")) == null) {
				Columns.Add(CreateDKIMVerifiedColumn());
			}
			if (Columns.FindByUId(new Guid("e3af0e3e-3bc3-446c-aa03-de0e1e93f5a1")) == null) {
				Columns.Add(CreateIsNewColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("bc7b7713-7483-402f-a98b-ff77ead465d2"),
				Name = @"Id",
				CreatedInSchemaUId = new Guid("abb2448c-6f83-4363-b02e-0afa5e052a89"),
				ModifiedInSchemaUId = new Guid("abb2448c-6f83-4363-b02e-0afa5e052a89"),
				CreatedInPackageId = new Guid("6b0d8068-2d05-42af-bf7c-865991421ad7")
			};
		}

		protected virtual EntitySchemaColumn CreateDomainColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("LongText")) {
				UId = new Guid("5c1aae21-3f84-4e6b-af38-538e4e43644c"),
				Name = @"Domain",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("abb2448c-6f83-4363-b02e-0afa5e052a89"),
				ModifiedInSchemaUId = new Guid("abb2448c-6f83-4363-b02e-0afa5e052a89"),
				CreatedInPackageId = new Guid("6b0d8068-2d05-42af-bf7c-865991421ad7")
			};
		}

		protected virtual EntitySchemaColumn CreateDKIMVerifiedColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("7183eb9d-7615-4195-b4a4-77b24819f843"),
				Name = @"DKIMVerified",
				CreatedInSchemaUId = new Guid("abb2448c-6f83-4363-b02e-0afa5e052a89"),
				ModifiedInSchemaUId = new Guid("abb2448c-6f83-4363-b02e-0afa5e052a89"),
				CreatedInPackageId = new Guid("6b0d8068-2d05-42af-bf7c-865991421ad7")
			};
		}

		protected virtual EntitySchemaColumn CreateIsNewColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("e3af0e3e-3bc3-446c-aa03-de0e1e93f5a1"),
				Name = @"IsNew",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("abb2448c-6f83-4363-b02e-0afa5e052a89"),
				ModifiedInSchemaUId = new Guid("abb2448c-6f83-4363-b02e-0afa5e052a89"),
				CreatedInPackageId = new Guid("6b0d8068-2d05-42af-bf7c-865991421ad7"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"True"
				}
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateDomainInfoEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateDomainInfoEventsProcessSchema() {
			var schema = new DomainInfoEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new DomainInfo(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new DomainInfo_BpmonlineCloudIntegrationEventsProcess(userConnection);
		}

		public override object Clone() {
			return new DomainInfoSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new DomainInfoSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("abb2448c-6f83-4363-b02e-0afa5e052a89"));
		}

		#endregion

	}

	#endregion

	#region Class: DomainInfo

	/// <summary>
	/// Sending domain.
	/// </summary>
	public class DomainInfo : Terrasoft.Core.Entities.Entity
	{

		#region Constructors: Public

		public DomainInfo(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "DomainInfo";
		}

		public DomainInfo(DomainInfo source)
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

		/// <summary>
		/// Domain.
		/// </summary>
		public string Domain {
			get {
				return GetTypedColumnValue<string>("Domain");
			}
			set {
				SetColumnValue("Domain", value);
			}
		}

		/// <summary>
		/// Domain verified.
		/// </summary>
		public bool DKIMVerified {
			get {
				return GetTypedColumnValue<bool>("DKIMVerified");
			}
			set {
				SetColumnValue("DKIMVerified", value);
			}
		}

		/// <summary>
		/// Is new.
		/// </summary>
		public bool IsNew {
			get {
				return GetTypedColumnValue<bool>("IsNew");
			}
			set {
				SetColumnValue("IsNew", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new DomainInfo_BpmonlineCloudIntegrationEventsProcess(UserConnection);
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
			return new DomainInfo(this);
		}

		#endregion

	}

	#endregion

	#region Class: DomainInfo_BpmonlineCloudIntegrationEventsProcess

	/// <exclude/>
	public class DomainInfo_BpmonlineCloudIntegrationEventsProcess<TEntity> : Terrasoft.Core.Process.EmbeddedProcess where TEntity : DomainInfo
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

		public DomainInfo_BpmonlineCloudIntegrationEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "DomainInfo_BpmonlineCloudIntegrationEventsProcess";
			SchemaUId = new Guid("abb2448c-6f83-4363-b02e-0afa5e052a89");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("abb2448c-6f83-4363-b02e-0afa5e052a89");
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

	#region Class: DomainInfo_BpmonlineCloudIntegrationEventsProcess

	/// <exclude/>
	public class DomainInfo_BpmonlineCloudIntegrationEventsProcess : DomainInfo_BpmonlineCloudIntegrationEventsProcess<DomainInfo>
	{

		public DomainInfo_BpmonlineCloudIntegrationEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: DomainInfoEventsProcessSchema

	/// <exclude/>
	public class DomainInfoEventsProcessSchema : Terrasoft.Core.Process.EmbeddedProcessSchema
	{

		#region Constructors: Public

		public DomainInfoEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public DomainInfoEventsProcessSchema(DomainInfoEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "DomainInfo_BpmonlineCloudIntegrationEventsProcess";
			UId = new Guid("6f499172-df0c-4779-b42c-3f60c081f071");
			CreatedInPackageId = new Guid("6b0d8068-2d05-42af-bf7c-865991421ad7");
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
			return new DomainInfoEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("6f499172-df0c-4779-b42c-3f60c081f071"));
		}

		#endregion

	}

	#endregion


	#region Class: DomainInfoEventsProcess

	/// <exclude/>
	public class DomainInfoEventsProcess : DomainInfo_BpmonlineCloudIntegrationEventsProcess
	{

		public DomainInfoEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

