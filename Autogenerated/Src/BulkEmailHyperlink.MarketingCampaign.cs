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

	#region Class: BulkEmailHyperlinkSchema

	/// <exclude/>
	public class BulkEmailHyperlinkSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public BulkEmailHyperlinkSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public BulkEmailHyperlinkSchema(BulkEmailHyperlinkSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public BulkEmailHyperlinkSchema(BulkEmailHyperlinkSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("09f52257-173f-4cd7-a86b-473372c67bd5");
			RealUId = new Guid("09f52257-173f-4cd7-a86b-473372c67bd5");
			Name = "BulkEmailHyperlink";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("48513af2-42ae-4933-a664-64fbd4224266");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializePrimaryDisplayColumn() {
			base.InitializePrimaryDisplayColumn();
			PrimaryDisplayColumn = CreateCaptionColumn();
			if (Columns.FindByUId(PrimaryDisplayColumn.UId) == null) {
				Columns.Add(PrimaryDisplayColumn);
			}
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("0a29118e-e3f4-4166-a404-5ce7c2e85cb7")) == null) {
				Columns.Add(CreateUrlColumn());
			}
			if (Columns.FindByUId(new Guid("0c85986f-d3d7-4e8c-ae13-5a2a84ef2dcb")) == null) {
				Columns.Add(CreateClicksCountColumn());
			}
			if (Columns.FindByUId(new Guid("7124d307-8670-46a1-959f-fed2083963f1")) == null) {
				Columns.Add(CreateBulkEmailColumn());
			}
			if (Columns.FindByUId(new Guid("7760e14d-7b50-4ae1-a60e-d8d67c139396")) == null) {
				Columns.Add(CreateHashColumn());
			}
			if (Columns.FindByUId(new Guid("ebf5edbc-34f6-4b04-b26a-43755cddd146")) == null) {
				Columns.Add(CreateBpmReplicaMaskColumn());
			}
			if (Columns.FindByUId(new Guid("1e56974d-e214-4443-ac1c-a6a116dd651d")) == null) {
				Columns.Add(CreateBpmTrackIdColumn());
			}
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.ModifiedInSchemaUId = new Guid("09f52257-173f-4cd7-a86b-473372c67bd5");
			column.CreatedInPackageId = new Guid("48513af2-42ae-4933-a664-64fbd4224266");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.ModifiedInSchemaUId = new Guid("09f52257-173f-4cd7-a86b-473372c67bd5");
			column.CreatedInPackageId = new Guid("48513af2-42ae-4933-a664-64fbd4224266");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.ModifiedInSchemaUId = new Guid("09f52257-173f-4cd7-a86b-473372c67bd5");
			column.CreatedInPackageId = new Guid("48513af2-42ae-4933-a664-64fbd4224266");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.ModifiedInSchemaUId = new Guid("09f52257-173f-4cd7-a86b-473372c67bd5");
			column.CreatedInPackageId = new Guid("48513af2-42ae-4933-a664-64fbd4224266");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.ModifiedInSchemaUId = new Guid("09f52257-173f-4cd7-a86b-473372c67bd5");
			column.CreatedInPackageId = new Guid("48513af2-42ae-4933-a664-64fbd4224266");
			return column;
		}

		protected override EntitySchemaColumn CreateProcessListenersColumn() {
			EntitySchemaColumn column = base.CreateProcessListenersColumn();
			column.ModifiedInSchemaUId = new Guid("09f52257-173f-4cd7-a86b-473372c67bd5");
			column.CreatedInPackageId = new Guid("48513af2-42ae-4933-a664-64fbd4224266");
			return column;
		}

		protected virtual EntitySchemaColumn CreateCaptionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("c2e34957-f4f8-428d-85c4-d1a467ec7e7e"),
				Name = @"Caption",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("09f52257-173f-4cd7-a86b-473372c67bd5"),
				ModifiedInSchemaUId = new Guid("09f52257-173f-4cd7-a86b-473372c67bd5"),
				CreatedInPackageId = new Guid("48513af2-42ae-4933-a664-64fbd4224266")
			};
		}

		protected virtual EntitySchemaColumn CreateUrlColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("0a29118e-e3f4-4166-a404-5ce7c2e85cb7"),
				Name = @"Url",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("09f52257-173f-4cd7-a86b-473372c67bd5"),
				ModifiedInSchemaUId = new Guid("09f52257-173f-4cd7-a86b-473372c67bd5"),
				CreatedInPackageId = new Guid("48513af2-42ae-4933-a664-64fbd4224266")
			};
		}

		protected virtual EntitySchemaColumn CreateClicksCountColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("0c85986f-d3d7-4e8c-ae13-5a2a84ef2dcb"),
				Name = @"ClicksCount",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("09f52257-173f-4cd7-a86b-473372c67bd5"),
				ModifiedInSchemaUId = new Guid("09f52257-173f-4cd7-a86b-473372c67bd5"),
				CreatedInPackageId = new Guid("48513af2-42ae-4933-a664-64fbd4224266")
			};
		}

		protected virtual EntitySchemaColumn CreateBulkEmailColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("7124d307-8670-46a1-959f-fed2083963f1"),
				Name = @"BulkEmail",
				ReferenceSchemaUId = new Guid("95fbcf9c-e36d-4acd-8b5a-d657de6e30a8"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("09f52257-173f-4cd7-a86b-473372c67bd5"),
				ModifiedInSchemaUId = new Guid("09f52257-173f-4cd7-a86b-473372c67bd5"),
				CreatedInPackageId = new Guid("48513af2-42ae-4933-a664-64fbd4224266")
			};
		}

		protected virtual EntitySchemaColumn CreateHashColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("7760e14d-7b50-4ae1-a60e-d8d67c139396"),
				Name = @"Hash",
				IsIndexed = true,
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("09f52257-173f-4cd7-a86b-473372c67bd5"),
				ModifiedInSchemaUId = new Guid("09f52257-173f-4cd7-a86b-473372c67bd5"),
				CreatedInPackageId = new Guid("48513af2-42ae-4933-a664-64fbd4224266")
			};
		}

		protected virtual EntitySchemaColumn CreateBpmReplicaMaskColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("ebf5edbc-34f6-4b04-b26a-43755cddd146"),
				Name = @"BpmReplicaMask",
				CreatedInSchemaUId = new Guid("09f52257-173f-4cd7-a86b-473372c67bd5"),
				ModifiedInSchemaUId = new Guid("09f52257-173f-4cd7-a86b-473372c67bd5"),
				CreatedInPackageId = new Guid("633119c1-eb92-42a3-a09d-15ece666869f")
			};
		}

		protected virtual EntitySchemaColumn CreateBpmTrackIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("1e56974d-e214-4443-ac1c-a6a116dd651d"),
				Name = @"BpmTrackId",
				CreatedInSchemaUId = new Guid("09f52257-173f-4cd7-a86b-473372c67bd5"),
				ModifiedInSchemaUId = new Guid("09f52257-173f-4cd7-a86b-473372c67bd5"),
				CreatedInPackageId = new Guid("9892593b-d041-45d0-95a7-d3a6e875d1a5")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateBulkEmailHyperlinkEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateBulkEmailHyperlinkEventsProcessSchema() {
			var schema = new BulkEmailHyperlinkEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new BulkEmailHyperlink(userConnection){Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new BulkEmailHyperlink_MarketingCampaignEventsProcess(userConnnection);
		}

		public override object Clone() {
			return new BulkEmailHyperlinkSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new BulkEmailHyperlinkSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("09f52257-173f-4cd7-a86b-473372c67bd5"));
		}

		#endregion

	}

	#endregion

	#region Class: BulkEmailHyperlink

	/// <summary>
	/// Link.
	/// </summary>
	public class BulkEmailHyperlink : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public BulkEmailHyperlink(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "BulkEmailHyperlink";
		}

		public BulkEmailHyperlink(BulkEmailHyperlink source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Title.
		/// </summary>
		public string Caption {
			get {
				return GetTypedColumnValue<string>("Caption");
			}
			set {
				SetColumnValue("Caption", value);
			}
		}

		/// <summary>
		/// URL.
		/// </summary>
		public string Url {
			get {
				return GetTypedColumnValue<string>("Url");
			}
			set {
				SetColumnValue("Url", value);
			}
		}

		/// <summary>
		/// Number of clicks.
		/// </summary>
		public int ClicksCount {
			get {
				return GetTypedColumnValue<int>("ClicksCount");
			}
			set {
				SetColumnValue("ClicksCount", value);
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
		/// Bulk email.
		/// </summary>
		public BulkEmail BulkEmail {
			get {
				return _bulkEmail ??
					(_bulkEmail = LookupColumnEntities.GetEntity("BulkEmail") as BulkEmail);
			}
		}

		/// <summary>
		/// Hash.
		/// </summary>
		public Guid Hash {
			get {
				return GetTypedColumnValue<Guid>("Hash");
			}
			set {
				SetColumnValue("Hash", value);
			}
		}

		/// <summary>
		/// Template replica identifier.
		/// </summary>
		public int BpmReplicaMask {
			get {
				return GetTypedColumnValue<int>("BpmReplicaMask");
			}
			set {
				SetColumnValue("BpmReplicaMask", value);
			}
		}

		/// <summary>
		/// Hyperlink identifier.
		/// </summary>
		public int BpmTrackId {
			get {
				return GetTypedColumnValue<int>("BpmTrackId");
			}
			set {
				SetColumnValue("BpmTrackId", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new BulkEmailHyperlink_MarketingCampaignEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("BulkEmailHyperlinkDeleted", e);
			Inserting += (s, e) => ThrowEvent("BulkEmailHyperlinkInserting", e);
			Validating += (s, e) => ThrowEvent("BulkEmailHyperlinkValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new BulkEmailHyperlink(this);
		}

		#endregion

	}

	#endregion

	#region Class: BulkEmailHyperlink_MarketingCampaignEventsProcess

	/// <exclude/>
	public class BulkEmailHyperlink_MarketingCampaignEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_LocalMessageEventsProcess<TEntity> where TEntity : BulkEmailHyperlink
	{

		public BulkEmailHyperlink_MarketingCampaignEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "BulkEmailHyperlink_MarketingCampaignEventsProcess";
			SchemaUId = new Guid("09f52257-173f-4cd7-a86b-473372c67bd5");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("09f52257-173f-4cd7-a86b-473372c67bd5");
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

	#region Class: BulkEmailHyperlink_MarketingCampaignEventsProcess

	/// <exclude/>
	public class BulkEmailHyperlink_MarketingCampaignEventsProcess : BulkEmailHyperlink_MarketingCampaignEventsProcess<BulkEmailHyperlink>
	{

		public BulkEmailHyperlink_MarketingCampaignEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: BulkEmailHyperlinkEventsProcessSchema

	/// <exclude/>
	public class BulkEmailHyperlinkEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public BulkEmailHyperlinkEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public BulkEmailHyperlinkEventsProcessSchema(BulkEmailHyperlinkEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "BulkEmailHyperlink_MarketingCampaignEventsProcess";
			UId = new Guid("c21c52dc-8e6c-4f38-a014-e55cc7a16b3b");
			CreatedInPackageId = new Guid("48513af2-42ae-4933-a664-64fbd4224266");
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
				CreatedInPackageId = new Guid("48513af2-42ae-4933-a664-64fbd4224266")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("cde525cf-d220-4d2a-b963-e55254c639fc"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("48513af2-42ae-4933-a664-64fbd4224266")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5c9c82c6-ba6d-4a57-9a14-87fe8faa4ebb"),
				Name = "Terrasoft.Core.DB",
				Alias = "",
				CreatedInPackageId = new Guid("48513af2-42ae-4933-a664-64fbd4224266")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7821de68-c82b-4917-a6cd-add2adfbe400"),
				Name = "Terrasoft.Common",
				Alias = "",
				CreatedInPackageId = new Guid("48513af2-42ae-4933-a664-64fbd4224266")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d67de76f-9cbc-4bfc-babb-6f65cb89b973"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("48513af2-42ae-4933-a664-64fbd4224266")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("74160d3b-65e3-4694-b554-089f2d980e54"),
				Name = "Newtonsoft.Json",
				Alias = "",
				CreatedInPackageId = new Guid("48513af2-42ae-4933-a664-64fbd4224266")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e401300a-9f16-40c2-9788-cf310ae9d1c5"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("48513af2-42ae-4933-a664-64fbd4224266")
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
			return new BulkEmailHyperlinkEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c21c52dc-8e6c-4f38-a014-e55cc7a16b3b"));
		}

		#endregion

	}

	#endregion


	#region Class: BulkEmailHyperlinkEventsProcess

	/// <exclude/>
	public class BulkEmailHyperlinkEventsProcess : BulkEmailHyperlink_MarketingCampaignEventsProcess
	{

		public BulkEmailHyperlinkEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

