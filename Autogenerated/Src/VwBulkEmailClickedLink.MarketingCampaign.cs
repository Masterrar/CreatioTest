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

	#region Class: VwBulkEmailClickedLinkSchema

	/// <exclude/>
	public class VwBulkEmailClickedLinkSchema : Terrasoft.Core.Entities.EntitySchema
	{

		#region Constructors: Public

		public VwBulkEmailClickedLinkSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public VwBulkEmailClickedLinkSchema(VwBulkEmailClickedLinkSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public VwBulkEmailClickedLinkSchema(VwBulkEmailClickedLinkSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("5a80a107-e592-4efe-aaf5-db82d22703d5");
			RealUId = new Guid("5a80a107-e592-4efe-aaf5-db82d22703d5");
			Name = "VwBulkEmailClickedLink";
			ParentSchemaUId = new Guid("1b56b061-4e91-4974-9038-df8340e534f2");
			ExtendParent = false;
			CreatedInPackageId = new Guid("48513af2-42ae-4933-a664-64fbd4224266");
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
			if (Columns.FindByUId(new Guid("0104f8ed-b1fa-4f9e-8d19-9435001b0cd5")) == null) {
				Columns.Add(CreateContactColumn());
			}
			if (Columns.FindByUId(new Guid("57245380-5179-4489-81b6-b614a789fa97")) == null) {
				Columns.Add(CreateBulkEmailHyperlinkColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateContactColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("0104f8ed-b1fa-4f9e-8d19-9435001b0cd5"),
				Name = @"Contact",
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("5a80a107-e592-4efe-aaf5-db82d22703d5"),
				ModifiedInSchemaUId = new Guid("5a80a107-e592-4efe-aaf5-db82d22703d5"),
				CreatedInPackageId = new Guid("48513af2-42ae-4933-a664-64fbd4224266")
			};
		}

		protected virtual EntitySchemaColumn CreateBulkEmailHyperlinkColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("57245380-5179-4489-81b6-b614a789fa97"),
				Name = @"BulkEmailHyperlink",
				ReferenceSchemaUId = new Guid("09f52257-173f-4cd7-a86b-473372c67bd5"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("5a80a107-e592-4efe-aaf5-db82d22703d5"),
				ModifiedInSchemaUId = new Guid("5a80a107-e592-4efe-aaf5-db82d22703d5"),
				CreatedInPackageId = new Guid("48513af2-42ae-4933-a664-64fbd4224266")
			};
		}

		protected virtual EntitySchemaColumn CreateIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("015774f0-9515-40a6-a68d-2f27a827cc10"),
				Name = @"Id",
				CreatedInSchemaUId = new Guid("5a80a107-e592-4efe-aaf5-db82d22703d5"),
				ModifiedInSchemaUId = new Guid("5a80a107-e592-4efe-aaf5-db82d22703d5"),
				CreatedInPackageId = new Guid("48513af2-42ae-4933-a664-64fbd4224266")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateVwBulkEmailClickedLinkEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateVwBulkEmailClickedLinkEventsProcessSchema() {
			var schema = new VwBulkEmailClickedLinkEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new VwBulkEmailClickedLink(userConnection){Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new VwBulkEmailClickedLink_MarketingCampaignEventsProcess(userConnnection);
		}

		public override object Clone() {
			return new VwBulkEmailClickedLinkSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new VwBulkEmailClickedLinkSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5a80a107-e592-4efe-aaf5-db82d22703d5"));
		}

		#endregion

	}

	#endregion

	#region Class: VwBulkEmailClickedLink

	/// <summary>
	/// Click through links with email.
	/// </summary>
	public class VwBulkEmailClickedLink : Terrasoft.Core.Entities.Entity
	{

		#region Constructors: Public

		public VwBulkEmailClickedLink(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "VwBulkEmailClickedLink";
		}

		public VwBulkEmailClickedLink(VwBulkEmailClickedLink source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public  Guid ContactId {
			get {
				return GetTypedColumnValue<Guid>("ContactId");
			}
			set {
				SetColumnValue("ContactId", value);
				_contact = null;
			}
		}

		/// <exclude/>
		public  string ContactName {
			get {
				return GetTypedColumnValue<string>("ContactName");
			}
			set {
				SetColumnValue("ContactName", value);
				if (_contact != null) {
					_contact.Name = value;
				}
			}
		}

		private Contact _contact;
		/// <summary>
		/// Contact.
		/// </summary>
		public  Contact Contact {
			get {
				return _contact ??
					(_contact = LookupColumnEntities.GetEntity("Contact") as Contact);
			}
		}

		/// <exclude/>
		public  Guid BulkEmailHyperlinkId {
			get {
				return GetTypedColumnValue<Guid>("BulkEmailHyperlinkId");
			}
			set {
				SetColumnValue("BulkEmailHyperlinkId", value);
				_bulkEmailHyperlink = null;
			}
		}

		/// <exclude/>
		public  string BulkEmailHyperlinkCaption {
			get {
				return GetTypedColumnValue<string>("BulkEmailHyperlinkCaption");
			}
			set {
				SetColumnValue("BulkEmailHyperlinkCaption", value);
				if (_bulkEmailHyperlink != null) {
					_bulkEmailHyperlink.Caption = value;
				}
			}
		}

		private BulkEmailHyperlink _bulkEmailHyperlink;
		/// <summary>
		/// Link.
		/// </summary>
		public  BulkEmailHyperlink BulkEmailHyperlink {
			get {
				return _bulkEmailHyperlink ??
					(_bulkEmailHyperlink = LookupColumnEntities.GetEntity("BulkEmailHyperlink") as BulkEmailHyperlink);
			}
		}

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
			var process = new VwBulkEmailClickedLink_MarketingCampaignEventsProcess(UserConnection);
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
			return new VwBulkEmailClickedLink(this);
		}

		#endregion

	}

	#endregion

	#region Class: VwBulkEmailClickedLink_MarketingCampaignEventsProcess

	/// <exclude/>
	public class VwBulkEmailClickedLink_MarketingCampaignEventsProcess<TEntity> : Terrasoft.Core.Process.EmbeddedProcess where TEntity : VwBulkEmailClickedLink
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

		public VwBulkEmailClickedLink_MarketingCampaignEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "VwBulkEmailClickedLink_MarketingCampaignEventsProcess";
			SchemaUId = new Guid("5a80a107-e592-4efe-aaf5-db82d22703d5");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private  Guid InternalSchemaUId {
			get {
				return new Guid("5a80a107-e592-4efe-aaf5-db82d22703d5");
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

	#region Class: VwBulkEmailClickedLink_MarketingCampaignEventsProcess

	/// <exclude/>
	public class VwBulkEmailClickedLink_MarketingCampaignEventsProcess : VwBulkEmailClickedLink_MarketingCampaignEventsProcess<VwBulkEmailClickedLink>
	{

		public VwBulkEmailClickedLink_MarketingCampaignEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: VwBulkEmailClickedLinkEventsProcessSchema

	/// <exclude/>
	public class VwBulkEmailClickedLinkEventsProcessSchema : Terrasoft.Core.Process.EmbeddedProcessSchema
	{

		#region Constructors: Public

		public VwBulkEmailClickedLinkEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public VwBulkEmailClickedLinkEventsProcessSchema(VwBulkEmailClickedLinkEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "VwBulkEmailClickedLink_MarketingCampaignEventsProcess";
			UId = new Guid("6e011821-801d-4eb1-b779-245ad6da27ca");
			CreatedInPackageId = new Guid("48513af2-42ae-4933-a664-64fbd4224266");
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
			return new VwBulkEmailClickedLinkEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("6e011821-801d-4eb1-b779-245ad6da27ca"));
		}

		#endregion

	}

	#endregion


	#region Class: VwBulkEmailClickedLinkEventsProcess

	/// <exclude/>
	public class VwBulkEmailClickedLinkEventsProcess : VwBulkEmailClickedLink_MarketingCampaignEventsProcess
	{

		public VwBulkEmailClickedLinkEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

