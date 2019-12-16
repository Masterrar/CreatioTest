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

	#region Class: BulkEmailInProgressSchema

	/// <exclude/>
	public class BulkEmailInProgressSchema : Terrasoft.Core.Entities.EntitySchema
	{

		#region Constructors: Public

		public BulkEmailInProgressSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public BulkEmailInProgressSchema(BulkEmailInProgressSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public BulkEmailInProgressSchema(BulkEmailInProgressSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("ab8ddf21-3930-472b-8724-d2b2bf8f8257");
			RealUId = new Guid("ab8ddf21-3930-472b-8724-d2b2bf8f8257");
			Name = "BulkEmailInProgress";
			ParentSchemaUId = new Guid("1b56b061-4e91-4974-9038-df8340e534f2");
			ExtendParent = false;
			CreatedInPackageId = new Guid("d6cb3076-08d5-49e6-ac18-d8f418ab1e90");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializePrimaryColumn() {
			base.InitializePrimaryColumn();
			PrimaryColumn = CreateSessionIdColumn();
			if (Columns.FindByUId(PrimaryColumn.UId) == null) {
				Columns.Add(PrimaryColumn);
			}
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("c812ddcd-8e0e-4db3-ac44-94f97402eb9d")) == null) {
				Columns.Add(CreateBulkEmailIdColumn());
			}
			if (Columns.FindByUId(new Guid("c4499e57-3833-472c-b6ea-9b481dc68a75")) == null) {
				Columns.Add(CreateCreatedOnColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateSessionIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("f1f3a9b2-666b-4cb3-8331-d163079c0b62"),
				Name = @"SessionId",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsValueCloneable = false,
				IsIndexed = true,
				UsageType = EntitySchemaColumnUsageType.Advanced,
				CreatedInSchemaUId = new Guid("ab8ddf21-3930-472b-8724-d2b2bf8f8257"),
				ModifiedInSchemaUId = new Guid("ab8ddf21-3930-472b-8724-d2b2bf8f8257"),
				CreatedInPackageId = new Guid("d6cb3076-08d5-49e6-ac18-d8f418ab1e90")
			};
		}

		protected virtual EntitySchemaColumn CreateBulkEmailIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("c812ddcd-8e0e-4db3-ac44-94f97402eb9d"),
				Name = @"BulkEmailId",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				UsageType = EntitySchemaColumnUsageType.Advanced,
				CreatedInSchemaUId = new Guid("ab8ddf21-3930-472b-8724-d2b2bf8f8257"),
				ModifiedInSchemaUId = new Guid("ab8ddf21-3930-472b-8724-d2b2bf8f8257"),
				CreatedInPackageId = new Guid("d6cb3076-08d5-49e6-ac18-d8f418ab1e90")
			};
		}

		protected virtual EntitySchemaColumn CreateCreatedOnColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("DateTime")) {
				UId = new Guid("c4499e57-3833-472c-b6ea-9b481dc68a75"),
				Name = @"CreatedOn",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				UsageType = EntitySchemaColumnUsageType.Advanced,
				CreatedInSchemaUId = new Guid("ab8ddf21-3930-472b-8724-d2b2bf8f8257"),
				ModifiedInSchemaUId = new Guid("ab8ddf21-3930-472b-8724-d2b2bf8f8257"),
				CreatedInPackageId = new Guid("d6cb3076-08d5-49e6-ac18-d8f418ab1e90"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.SystemValue,
					ValueSource = SystemValueManager.GetInstanceByName(@"CurrentDateTime")
				}
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateBulkEmailInProgressEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateBulkEmailInProgressEventsProcessSchema() {
			var schema = new BulkEmailInProgressEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new BulkEmailInProgress(userConnection){Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new BulkEmailInProgress_MailingEventsProcess(userConnnection);
		}

		public override object Clone() {
			return new BulkEmailInProgressSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new BulkEmailInProgressSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ab8ddf21-3930-472b-8724-d2b2bf8f8257"));
		}

		#endregion

	}

	#endregion

	#region Class: BulkEmailInProgress

	/// <summary>
	/// BulkEmailInProgress.
	/// </summary>
	public class BulkEmailInProgress : Terrasoft.Core.Entities.Entity
	{

		#region Constructors: Public

		public BulkEmailInProgress(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "BulkEmailInProgress";
		}

		public BulkEmailInProgress(BulkEmailInProgress source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Session.
		/// </summary>
		public  Guid SessionId {
			get {
				return GetTypedColumnValue<Guid>("SessionId");
			}
			set {
				SetColumnValue("SessionId", value);
			}
		}

		/// <summary>
		/// BulkEmail.
		/// </summary>
		public  Guid BulkEmailId {
			get {
				return GetTypedColumnValue<Guid>("BulkEmailId");
			}
			set {
				SetColumnValue("BulkEmailId", value);
			}
		}

		/// <summary>
		/// CreatedOn.
		/// </summary>
		public  DateTime CreatedOn {
			get {
				return GetTypedColumnValue<DateTime>("CreatedOn");
			}
			set {
				SetColumnValue("CreatedOn", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new BulkEmailInProgress_MailingEventsProcess(UserConnection);
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
			return new BulkEmailInProgress(this);
		}

		#endregion

	}

	#endregion

	#region Class: BulkEmailInProgress_MailingEventsProcess

	/// <exclude/>
	public class BulkEmailInProgress_MailingEventsProcess<TEntity> : Terrasoft.Core.Process.EmbeddedProcess where TEntity : BulkEmailInProgress
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

		public BulkEmailInProgress_MailingEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "BulkEmailInProgress_MailingEventsProcess";
			SchemaUId = new Guid("ab8ddf21-3930-472b-8724-d2b2bf8f8257");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private  Guid InternalSchemaUId {
			get {
				return new Guid("ab8ddf21-3930-472b-8724-d2b2bf8f8257");
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

	#region Class: BulkEmailInProgress_MailingEventsProcess

	/// <exclude/>
	public class BulkEmailInProgress_MailingEventsProcess : BulkEmailInProgress_MailingEventsProcess<BulkEmailInProgress>
	{

		public BulkEmailInProgress_MailingEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: BulkEmailInProgressEventsProcessSchema

	/// <exclude/>
	public class BulkEmailInProgressEventsProcessSchema : Terrasoft.Core.Process.EmbeddedProcessSchema
	{

		#region Constructors: Public

		public BulkEmailInProgressEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public BulkEmailInProgressEventsProcessSchema(BulkEmailInProgressEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "BulkEmailInProgress_MailingEventsProcess";
			UId = new Guid("c84d674f-c0df-4da0-8c1f-9cdd1b3711cc");
			CreatedInPackageId = new Guid("d6cb3076-08d5-49e6-ac18-d8f418ab1e90");
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
			return new BulkEmailInProgressEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c84d674f-c0df-4da0-8c1f-9cdd1b3711cc"));
		}

		#endregion

	}

	#endregion


	#region Class: BulkEmailInProgressEventsProcess

	/// <exclude/>
	public class BulkEmailInProgressEventsProcess : BulkEmailInProgress_MailingEventsProcess
	{

		public BulkEmailInProgressEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

