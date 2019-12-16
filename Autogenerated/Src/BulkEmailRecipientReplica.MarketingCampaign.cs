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

	#region Class: BulkEmailRecipientReplicaSchema

	/// <exclude/>
	public class BulkEmailRecipientReplicaSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public BulkEmailRecipientReplicaSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public BulkEmailRecipientReplicaSchema(BulkEmailRecipientReplicaSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public BulkEmailRecipientReplicaSchema(BulkEmailRecipientReplicaSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private EntitySchemaIndex CreateIXUFpeoUzBJQmx6mbqajEidE5AkgIndex() {
			EntitySchemaIndex index = new EntitySchemaIndex() {
				IsAutoName = true,
				IsClustered = false,
				IsUnique = false
			};
			index.UId = new Guid("c4849838-257e-4c15-a913-4fe8dc35bd15");
			index.Name = "IXUFpeoUzBJQmx6mbqajEidE5Akg";
			index.CreatedInSchemaUId = new Guid("71dbd47d-eda7-4f91-bd02-ab75732cd2f3");
			index.ModifiedInSchemaUId = new Guid("71dbd47d-eda7-4f91-bd02-ab75732cd2f3");
			index.CreatedInPackageId = new Guid("9892593b-d041-45d0-95a7-d3a6e875d1a5");
			EntitySchemaIndexColumn recipientIdIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("db9c3b82-f4a4-4c73-bb51-2a7865586398"),
				ColumnUId = new Guid("cb7ca679-90ed-45a4-9573-e4fe99c3d169"),
				CreatedInSchemaUId = new Guid("71dbd47d-eda7-4f91-bd02-ab75732cd2f3"),
				ModifiedInSchemaUId = new Guid("71dbd47d-eda7-4f91-bd02-ab75732cd2f3"),
				CreatedInPackageId = new Guid("9892593b-d041-45d0-95a7-d3a6e875d1a5"),
				OrderDirection = OrderDirectionStrict.Ascending
			};
			index.Columns.Add(recipientIdIndexColumn);
			return index;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("71dbd47d-eda7-4f91-bd02-ab75732cd2f3");
			RealUId = new Guid("71dbd47d-eda7-4f91-bd02-ab75732cd2f3");
			Name = "BulkEmailRecipientReplica";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("9892593b-d041-45d0-95a7-d3a6e875d1a5");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("80e92fb6-37f7-4532-84a6-8ffe3d445cc5")) == null) {
				Columns.Add(CreateDCReplicaColumn());
			}
			if (Columns.FindByUId(new Guid("cb7ca679-90ed-45a4-9573-e4fe99c3d169")) == null) {
				Columns.Add(CreateRecipientIdColumn());
			}
			if (Columns.FindByUId(new Guid("ee4dc8fc-f3fa-4f43-b46d-58bf87f5a6a7")) == null) {
				Columns.Add(CreateBulkEmailColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateDCReplicaColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("80e92fb6-37f7-4532-84a6-8ffe3d445cc5"),
				Name = @"DCReplica",
				ReferenceSchemaUId = new Guid("dcb6b7a6-c21f-45d1-a442-dda902ef64c5"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("71dbd47d-eda7-4f91-bd02-ab75732cd2f3"),
				ModifiedInSchemaUId = new Guid("71dbd47d-eda7-4f91-bd02-ab75732cd2f3"),
				CreatedInPackageId = new Guid("9892593b-d041-45d0-95a7-d3a6e875d1a5")
			};
		}

		protected virtual EntitySchemaColumn CreateRecipientIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("cb7ca679-90ed-45a4-9573-e4fe99c3d169"),
				Name = @"RecipientId",
				CreatedInSchemaUId = new Guid("71dbd47d-eda7-4f91-bd02-ab75732cd2f3"),
				ModifiedInSchemaUId = new Guid("71dbd47d-eda7-4f91-bd02-ab75732cd2f3"),
				CreatedInPackageId = new Guid("9892593b-d041-45d0-95a7-d3a6e875d1a5")
			};
		}

		protected virtual EntitySchemaColumn CreateBulkEmailColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("ee4dc8fc-f3fa-4f43-b46d-58bf87f5a6a7"),
				Name = @"BulkEmail",
				ReferenceSchemaUId = new Guid("95fbcf9c-e36d-4acd-8b5a-d657de6e30a8"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("71dbd47d-eda7-4f91-bd02-ab75732cd2f3"),
				ModifiedInSchemaUId = new Guid("71dbd47d-eda7-4f91-bd02-ab75732cd2f3"),
				CreatedInPackageId = new Guid("c92d8fca-4a0d-4385-86d2-4f5717aa816e")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeIndexes() {
			base.InitializeIndexes();
			Indexes.Add(CreateIXUFpeoUzBJQmx6mbqajEidE5AkgIndex());
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateBulkEmailRecipientReplicaEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateBulkEmailRecipientReplicaEventsProcessSchema() {
			var schema = new BulkEmailRecipientReplicaEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new BulkEmailRecipientReplica(userConnection){Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new BulkEmailRecipientReplica_MarketingCampaignEventsProcess(userConnnection);
		}

		public override object Clone() {
			return new BulkEmailRecipientReplicaSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new BulkEmailRecipientReplicaSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("71dbd47d-eda7-4f91-bd02-ab75732cd2f3"));
		}

		#endregion

	}

	#endregion

	#region Class: BulkEmailRecipientReplica

	/// <summary>
	/// BulkEmailRecipientReplica.
	/// </summary>
	public class BulkEmailRecipientReplica : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public BulkEmailRecipientReplica(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "BulkEmailRecipientReplica";
		}

		public BulkEmailRecipientReplica(BulkEmailRecipientReplica source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid DCReplicaId {
			get {
				return GetTypedColumnValue<Guid>("DCReplicaId");
			}
			set {
				SetColumnValue("DCReplicaId", value);
				_dCReplica = null;
			}
		}

		private DCReplica _dCReplica;
		/// <summary>
		/// Email template replica.
		/// </summary>
		public DCReplica DCReplica {
			get {
				return _dCReplica ??
					(_dCReplica = LookupColumnEntities.GetEntity("DCReplica") as DCReplica);
			}
		}

		/// <summary>
		/// Recipient unique identifier.
		/// </summary>
		public Guid RecipientId {
			get {
				return GetTypedColumnValue<Guid>("RecipientId");
			}
			set {
				SetColumnValue("RecipientId", value);
			}
		}

		/// <exclude/>
		public Guid BulkEmailId {
			get {
				return GetTypedColumnValue<Guid>("BulkEmailId");
			}
			set {
				SetColumnValue("BulkEmailId", value);
				_bulkEmail = null;
			}
		}

		/// <exclude/>
		public string BulkEmailName {
			get {
				return GetTypedColumnValue<string>("BulkEmailName");
			}
			set {
				SetColumnValue("BulkEmailName", value);
				if (_bulkEmail != null) {
					_bulkEmail.Name = value;
				}
			}
		}

		private BulkEmail _bulkEmail;
		/// <summary>
		/// BulkEmail unique identifier.
		/// </summary>
		public BulkEmail BulkEmail {
			get {
				return _bulkEmail ??
					(_bulkEmail = LookupColumnEntities.GetEntity("BulkEmail") as BulkEmail);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new BulkEmailRecipientReplica_MarketingCampaignEventsProcess(UserConnection);
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
			return new BulkEmailRecipientReplica(this);
		}

		#endregion

	}

	#endregion

	#region Class: BulkEmailRecipientReplica_MarketingCampaignEventsProcess

	/// <exclude/>
	public class BulkEmailRecipientReplica_MarketingCampaignEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_LocalMessageEventsProcess<TEntity> where TEntity : BulkEmailRecipientReplica
	{

		public BulkEmailRecipientReplica_MarketingCampaignEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "BulkEmailRecipientReplica_MarketingCampaignEventsProcess";
			SchemaUId = new Guid("71dbd47d-eda7-4f91-bd02-ab75732cd2f3");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("71dbd47d-eda7-4f91-bd02-ab75732cd2f3");
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

	#region Class: BulkEmailRecipientReplica_MarketingCampaignEventsProcess

	/// <exclude/>
	public class BulkEmailRecipientReplica_MarketingCampaignEventsProcess : BulkEmailRecipientReplica_MarketingCampaignEventsProcess<BulkEmailRecipientReplica>
	{

		public BulkEmailRecipientReplica_MarketingCampaignEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: BulkEmailRecipientReplicaEventsProcessSchema

	/// <exclude/>
	public class BulkEmailRecipientReplicaEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public BulkEmailRecipientReplicaEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public BulkEmailRecipientReplicaEventsProcessSchema(BulkEmailRecipientReplicaEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "BulkEmailRecipientReplica_MarketingCampaignEventsProcess";
			UId = new Guid("14ae1b5e-80ea-4b4c-a8fa-b06787240309");
			CreatedInPackageId = new Guid("9892593b-d041-45d0-95a7-d3a6e875d1a5");
			CreatedInSchemaUId = Guid.Empty;
			CreatedInVersion = @"0.0.0.0";
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
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
			return new BulkEmailRecipientReplicaEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("14ae1b5e-80ea-4b4c-a8fa-b06787240309"));
		}

		#endregion

	}

	#endregion


	#region Class: BulkEmailRecipientReplicaEventsProcess

	/// <exclude/>
	public class BulkEmailRecipientReplicaEventsProcess : BulkEmailRecipientReplica_MarketingCampaignEventsProcess
	{

		public BulkEmailRecipientReplicaEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

