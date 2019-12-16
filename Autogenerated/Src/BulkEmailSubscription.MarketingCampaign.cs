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

	#region Class: BulkEmailSubscriptionSchema

	/// <exclude/>
	public class BulkEmailSubscriptionSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public BulkEmailSubscriptionSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public BulkEmailSubscriptionSchema(BulkEmailSubscriptionSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public BulkEmailSubscriptionSchema(BulkEmailSubscriptionSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f97c7fd3-c52c-4a76-9cbd-c749e4fda8de");
			RealUId = new Guid("f97c7fd3-c52c-4a76-9cbd-c749e4fda8de");
			Name = "BulkEmailSubscription";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("036273dd-d44c-45e1-8c98-d51acfaf8b95");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("f9439025-deb8-44e9-8820-eccf85451f48")) == null) {
				Columns.Add(CreateContactColumn());
			}
			if (Columns.FindByUId(new Guid("062ba997-5cf3-4ab7-befb-ba292e02f28f")) == null) {
				Columns.Add(CreateBulkEmailTypeColumn());
			}
			if (Columns.FindByUId(new Guid("3943ceae-c85f-4ab0-8cd2-d4f5cba8b2da")) == null) {
				Columns.Add(CreateBulkEmailSubsStatusColumn());
			}
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.ModifiedInSchemaUId = new Guid("f97c7fd3-c52c-4a76-9cbd-c749e4fda8de");
			column.CreatedInPackageId = new Guid("036273dd-d44c-45e1-8c98-d51acfaf8b95");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.ModifiedInSchemaUId = new Guid("f97c7fd3-c52c-4a76-9cbd-c749e4fda8de");
			column.CreatedInPackageId = new Guid("036273dd-d44c-45e1-8c98-d51acfaf8b95");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.ModifiedInSchemaUId = new Guid("f97c7fd3-c52c-4a76-9cbd-c749e4fda8de");
			column.CreatedInPackageId = new Guid("036273dd-d44c-45e1-8c98-d51acfaf8b95");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.ModifiedInSchemaUId = new Guid("f97c7fd3-c52c-4a76-9cbd-c749e4fda8de");
			column.CreatedInPackageId = new Guid("036273dd-d44c-45e1-8c98-d51acfaf8b95");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.ModifiedInSchemaUId = new Guid("f97c7fd3-c52c-4a76-9cbd-c749e4fda8de");
			column.CreatedInPackageId = new Guid("036273dd-d44c-45e1-8c98-d51acfaf8b95");
			return column;
		}

		protected override EntitySchemaColumn CreateProcessListenersColumn() {
			EntitySchemaColumn column = base.CreateProcessListenersColumn();
			column.ModifiedInSchemaUId = new Guid("f97c7fd3-c52c-4a76-9cbd-c749e4fda8de");
			column.CreatedInPackageId = new Guid("036273dd-d44c-45e1-8c98-d51acfaf8b95");
			return column;
		}

		protected virtual EntitySchemaColumn CreateContactColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("f9439025-deb8-44e9-8820-eccf85451f48"),
				Name = @"Contact",
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("f97c7fd3-c52c-4a76-9cbd-c749e4fda8de"),
				ModifiedInSchemaUId = new Guid("f97c7fd3-c52c-4a76-9cbd-c749e4fda8de"),
				CreatedInPackageId = new Guid("036273dd-d44c-45e1-8c98-d51acfaf8b95")
			};
		}

		protected virtual EntitySchemaColumn CreateBulkEmailTypeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("062ba997-5cf3-4ab7-befb-ba292e02f28f"),
				Name = @"BulkEmailType",
				ReferenceSchemaUId = new Guid("708702c2-7d97-4702-879a-39aa5f6eef8f"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("f97c7fd3-c52c-4a76-9cbd-c749e4fda8de"),
				ModifiedInSchemaUId = new Guid("f97c7fd3-c52c-4a76-9cbd-c749e4fda8de"),
				CreatedInPackageId = new Guid("036273dd-d44c-45e1-8c98-d51acfaf8b95")
			};
		}

		protected virtual EntitySchemaColumn CreateBulkEmailSubsStatusColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("3943ceae-c85f-4ab0-8cd2-d4f5cba8b2da"),
				Name = @"BulkEmailSubsStatus",
				ReferenceSchemaUId = new Guid("40516046-e9f2-4922-8e85-01c5251329f7"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("f97c7fd3-c52c-4a76-9cbd-c749e4fda8de"),
				ModifiedInSchemaUId = new Guid("f97c7fd3-c52c-4a76-9cbd-c749e4fda8de"),
				CreatedInPackageId = new Guid("036273dd-d44c-45e1-8c98-d51acfaf8b95")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateBulkEmailSubscriptionEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateBulkEmailSubscriptionEventsProcessSchema() {
			var schema = new BulkEmailSubscriptionEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new BulkEmailSubscription(userConnection){Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new BulkEmailSubscription_MarketingCampaignEventsProcess(userConnnection);
		}

		public override object Clone() {
			return new BulkEmailSubscriptionSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new BulkEmailSubscriptionSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f97c7fd3-c52c-4a76-9cbd-c749e4fda8de"));
		}

		#endregion

	}

	#endregion

	#region Class: BulkEmailSubscription

	/// <summary>
	/// Bulk email subscription.
	/// </summary>
	public class BulkEmailSubscription : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public BulkEmailSubscription(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "BulkEmailSubscription";
		}

		public BulkEmailSubscription(BulkEmailSubscription source)
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
		public  Guid BulkEmailTypeId {
			get {
				return GetTypedColumnValue<Guid>("BulkEmailTypeId");
			}
			set {
				SetColumnValue("BulkEmailTypeId", value);
				_bulkEmailType = null;
			}
		}

		/// <exclude/>
		public  string BulkEmailTypeName {
			get {
				return GetTypedColumnValue<string>("BulkEmailTypeName");
			}
			set {
				SetColumnValue("BulkEmailTypeName", value);
				if (_bulkEmailType != null) {
					_bulkEmailType.Name = value;
				}
			}
		}

		private BulkEmailType _bulkEmailType;
		/// <summary>
		/// Bulk email type.
		/// </summary>
		public  BulkEmailType BulkEmailType {
			get {
				return _bulkEmailType ??
					(_bulkEmailType = LookupColumnEntities.GetEntity("BulkEmailType") as BulkEmailType);
			}
		}

		/// <exclude/>
		public  Guid BulkEmailSubsStatusId {
			get {
				return GetTypedColumnValue<Guid>("BulkEmailSubsStatusId");
			}
			set {
				SetColumnValue("BulkEmailSubsStatusId", value);
				_bulkEmailSubsStatus = null;
			}
		}

		/// <exclude/>
		public  string BulkEmailSubsStatusName {
			get {
				return GetTypedColumnValue<string>("BulkEmailSubsStatusName");
			}
			set {
				SetColumnValue("BulkEmailSubsStatusName", value);
				if (_bulkEmailSubsStatus != null) {
					_bulkEmailSubsStatus.Name = value;
				}
			}
		}

		private BulkEmailSubsStatus _bulkEmailSubsStatus;
		/// <summary>
		/// Subscription status.
		/// </summary>
		public  BulkEmailSubsStatus BulkEmailSubsStatus {
			get {
				return _bulkEmailSubsStatus ??
					(_bulkEmailSubsStatus = LookupColumnEntities.GetEntity("BulkEmailSubsStatus") as BulkEmailSubsStatus);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new BulkEmailSubscription_MarketingCampaignEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Inserting += (s, e) => ThrowEvent("BulkEmailSubscriptionInserting", e);
			Validating += (s, e) => ThrowEvent("BulkEmailSubscriptionValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new BulkEmailSubscription(this);
		}

		#endregion

	}

	#endregion

	#region Class: BulkEmailSubscription_MarketingCampaignEventsProcess

	/// <exclude/>
	public class BulkEmailSubscription_MarketingCampaignEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_LocalMessageEventsProcess<TEntity> where TEntity : BulkEmailSubscription
	{

		public BulkEmailSubscription_MarketingCampaignEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "BulkEmailSubscription_MarketingCampaignEventsProcess";
			SchemaUId = new Guid("f97c7fd3-c52c-4a76-9cbd-c749e4fda8de");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private  Guid InternalSchemaUId {
			get {
				return new Guid("f97c7fd3-c52c-4a76-9cbd-c749e4fda8de");
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

	#region Class: BulkEmailSubscription_MarketingCampaignEventsProcess

	/// <exclude/>
	public class BulkEmailSubscription_MarketingCampaignEventsProcess : BulkEmailSubscription_MarketingCampaignEventsProcess<BulkEmailSubscription>
	{

		public BulkEmailSubscription_MarketingCampaignEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: BulkEmailSubscriptionEventsProcessSchema

	/// <exclude/>
	public class BulkEmailSubscriptionEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public BulkEmailSubscriptionEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public BulkEmailSubscriptionEventsProcessSchema(BulkEmailSubscriptionEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "BulkEmailSubscription_MarketingCampaignEventsProcess";
			UId = new Guid("f7ffa3ca-753f-46f0-a02f-f7e72e3afd3e");
			CreatedInPackageId = new Guid("036273dd-d44c-45e1-8c98-d51acfaf8b95");
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
				CreatedInPackageId = new Guid("036273dd-d44c-45e1-8c98-d51acfaf8b95")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("cde525cf-d220-4d2a-b963-e55254c639fc"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("036273dd-d44c-45e1-8c98-d51acfaf8b95")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5c9c82c6-ba6d-4a57-9a14-87fe8faa4ebb"),
				Name = "Terrasoft.Core.DB",
				Alias = "",
				CreatedInPackageId = new Guid("036273dd-d44c-45e1-8c98-d51acfaf8b95")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7821de68-c82b-4917-a6cd-add2adfbe400"),
				Name = "Terrasoft.Common",
				Alias = "",
				CreatedInPackageId = new Guid("036273dd-d44c-45e1-8c98-d51acfaf8b95")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d67de76f-9cbc-4bfc-babb-6f65cb89b973"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("036273dd-d44c-45e1-8c98-d51acfaf8b95")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("74160d3b-65e3-4694-b554-089f2d980e54"),
				Name = "Newtonsoft.Json",
				Alias = "",
				CreatedInPackageId = new Guid("036273dd-d44c-45e1-8c98-d51acfaf8b95")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e401300a-9f16-40c2-9788-cf310ae9d1c5"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("036273dd-d44c-45e1-8c98-d51acfaf8b95")
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
			return new BulkEmailSubscriptionEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f7ffa3ca-753f-46f0-a02f-f7e72e3afd3e"));
		}

		#endregion

	}

	#endregion


	#region Class: BulkEmailSubscriptionEventsProcess

	/// <exclude/>
	public class BulkEmailSubscriptionEventsProcess : BulkEmailSubscription_MarketingCampaignEventsProcess
	{

		public BulkEmailSubscriptionEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

