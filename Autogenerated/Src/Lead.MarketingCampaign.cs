namespace Terrasoft.Configuration
{

	using DataContract = Terrasoft.Nui.ServiceModel.DataContract;
	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Collections.Specialized;
	using System.Data;
	using System.Drawing;
	using System.Globalization;
	using System.IO;
	using System.Web;
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

	#region Class: Lead_MarketingCampaign_TerrasoftSchema

	/// <exclude/>
	public class Lead_MarketingCampaign_TerrasoftSchema : Terrasoft.Configuration.Lead_OrderLead_TerrasoftSchema
	{

		#region Constructors: Public

		public Lead_MarketingCampaign_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public Lead_MarketingCampaign_TerrasoftSchema(Lead_MarketingCampaign_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public Lead_MarketingCampaign_TerrasoftSchema(Lead_MarketingCampaign_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private EntitySchemaIndex CreateIMLLeadModifiedOnIndex() {
			EntitySchemaIndex index = new EntitySchemaIndex() {
				IsAutoName = false,
				IsClustered = false,
				IsUnique = false
			};
			index.UId = new Guid("e0ee791a-7d9e-4ef7-8653-eb995a3f6d74");
			index.Name = "IMLLeadModifiedOn";
			index.CreatedInSchemaUId = new Guid("d9947110-c8c4-49c9-8bc1-344ec81a0258");
			index.ModifiedInSchemaUId = new Guid("d9947110-c8c4-49c9-8bc1-344ec81a0258");
			index.CreatedInPackageId = new Guid("296a0a1e-e6de-4406-bbd8-86a62e047ff0");
			EntitySchemaIndexColumn modifiedOnIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("aaa8ad09-ce33-4f85-9c6f-46d679ad61ee"),
				ColumnUId = new Guid("9928edec-4272-425a-93bb-48743fee4b04"),
				CreatedInSchemaUId = new Guid("d9947110-c8c4-49c9-8bc1-344ec81a0258"),
				ModifiedInSchemaUId = new Guid("d9947110-c8c4-49c9-8bc1-344ec81a0258"),
				CreatedInPackageId = new Guid("296a0a1e-e6de-4406-bbd8-86a62e047ff0"),
				OrderDirection = OrderDirectionStrict.Descending
			};
			index.Columns.Add(modifiedOnIndexColumn);
			return index;
		}

		private EntitySchemaIndex CreateIDX_LeadNameIndex() {
			EntitySchemaIndex index = new EntitySchemaIndex() {
				IsAutoName = false,
				IsClustered = false,
				IsUnique = false
			};
			index.UId = new Guid("bf3f62f3-5d38-4031-a648-58b036f8f19d");
			index.Name = "IDX_LeadName";
			index.CreatedInSchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec");
			index.ModifiedInSchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec");
			index.CreatedInPackageId = new Guid("b424f2c1-869b-44e8-aaf1-c9a818421e06");
			EntitySchemaIndexColumn leadNameIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("2c3ed9bd-ff44-447d-b4af-c6a4e4090a5a"),
				ColumnUId = new Guid("d06ba9af-faf5-4741-a672-e154ae561a94"),
				CreatedInSchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec"),
				ModifiedInSchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec"),
				CreatedInPackageId = new Guid("b424f2c1-869b-44e8-aaf1-c9a818421e06"),
				OrderDirection = OrderDirectionStrict.Ascending
			};
			index.Columns.Add(leadNameIndexColumn);
			return index;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("5c06dbee-b035-41e6-a7c7-df3fc2c8297f");
			Name = "Lead_MarketingCampaign_Terrasoft";
			ParentSchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec");
			ExtendParent = true;
			CreatedInPackageId = new Guid("3a81387c-e6ac-40c7-b70e-9a0c3966258b");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("0c40a261-945a-41b7-8db3-8ea08c2a021a")) == null) {
				Columns.Add(CreateCampaignColumn());
			}
			if (Columns.FindByUId(new Guid("7dd57d6b-5262-4c8c-a61a-41b83257b36f")) == null) {
				Columns.Add(CreateBulkEmailColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateCampaignColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("0c40a261-945a-41b7-8db3-8ea08c2a021a"),
				Name = @"Campaign",
				ReferenceSchemaUId = new Guid("1f9bb71a-eb9c-4220-a40e-9b623eacfec8"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("5c06dbee-b035-41e6-a7c7-df3fc2c8297f"),
				ModifiedInSchemaUId = new Guid("5c06dbee-b035-41e6-a7c7-df3fc2c8297f"),
				CreatedInPackageId = new Guid("3a81387c-e6ac-40c7-b70e-9a0c3966258b")
			};
		}

		protected virtual EntitySchemaColumn CreateBulkEmailColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("7dd57d6b-5262-4c8c-a61a-41b83257b36f"),
				Name = @"BulkEmail",
				ReferenceSchemaUId = new Guid("95fbcf9c-e36d-4acd-8b5a-d657de6e30a8"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("5c06dbee-b035-41e6-a7c7-df3fc2c8297f"),
				ModifiedInSchemaUId = new Guid("5c06dbee-b035-41e6-a7c7-df3fc2c8297f"),
				CreatedInPackageId = new Guid("3a81387c-e6ac-40c7-b70e-9a0c3966258b")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeIndexes() {
			base.InitializeIndexes();
			Indexes.Add(CreateIMLLeadModifiedOnIndex());
			Indexes.Add(CreateIDX_LeadNameIndex());
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateLead_MarketingCampaign_TerrasoftEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateLead_MarketingCampaign_TerrasoftEventsProcessSchema() {
			var schema = new Lead_MarketingCampaign_TerrasoftEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new Lead_MarketingCampaign_Terrasoft(userConnection){Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new Lead_MarketingCampaignEventsProcess(userConnnection);
		}

		public override object Clone() {
			return new Lead_MarketingCampaign_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new Lead_MarketingCampaign_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5c06dbee-b035-41e6-a7c7-df3fc2c8297f"));
		}

		#endregion

	}

	#endregion

	#region Class: Lead_MarketingCampaign_Terrasoft

	/// <summary>
	/// Lead.
	/// </summary>
	public class Lead_MarketingCampaign_Terrasoft : Terrasoft.Configuration.Lead_OrderLead_Terrasoft
	{

		#region Constructors: Public

		public Lead_MarketingCampaign_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Lead_MarketingCampaign_Terrasoft";
		}

		public Lead_MarketingCampaign_Terrasoft(Lead_MarketingCampaign_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public  Guid CampaignId {
			get {
				return GetTypedColumnValue<Guid>("CampaignId");
			}
			set {
				SetColumnValue("CampaignId", value);
				_campaign = null;
			}
		}

		/// <exclude/>
		public  string CampaignName {
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
		public  Campaign Campaign {
			get {
				return _campaign ??
					(_campaign = LookupColumnEntities.GetEntity("Campaign") as Campaign);
			}
		}

		/// <exclude/>
		public  Guid BulkEmailId {
			get {
				return GetTypedColumnValue<Guid>("BulkEmailId");
			}
			set {
				SetColumnValue("BulkEmailId", value);
				_bulkEmail = null;
			}
		}

		/// <exclude/>
		public  string BulkEmailName {
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
		public  BulkEmail BulkEmail {
			get {
				return _bulkEmail ??
					(_bulkEmail = LookupColumnEntities.GetEntity("BulkEmail") as BulkEmail);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new Lead_MarketingCampaignEventsProcess(UserConnection);
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
			return new Lead_MarketingCampaign_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: Lead_MarketingCampaignEventsProcess

	/// <exclude/>
	public class Lead_MarketingCampaignEventsProcess<TEntity> : Terrasoft.Configuration.Lead_OrderLeadEventsProcess<TEntity> where TEntity : Lead_MarketingCampaign_Terrasoft
	{

		public Lead_MarketingCampaignEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Lead_MarketingCampaignEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private  Guid InternalSchemaUId {
			get {
				return new Guid("5c06dbee-b035-41e6-a7c7-df3fc2c8297f");
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

		public virtual void BindToCampaignAndBulkEmail() {
			if (!Entity.IsColumnValueLoaded("BpmHref")) {
				return;
			}
			string bpmHref = Entity.GetTypedColumnValue<string>("BpmHref");
			NameValueCollection bpmHrefParameters = null;
			Uri uri;
			if (Uri.TryCreate(bpmHref, UriKind.Absolute, out uri)) {
				bpmHrefParameters = HttpUtility.ParseQueryString(uri.Query);
			} else {
				return;
			}
			string utmCampaignValue = bpmHrefParameters["utm_campaign"] != null ? bpmHrefParameters["utm_campaign"] : string.Empty;
			string bulkEmailRIdValue = bpmHrefParameters["bulk_email_rid"] != null ? bpmHrefParameters["bulk_email_rid"] : string.Empty;
			if(!string.IsNullOrEmpty(utmCampaignValue)) {
				var esq = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "Campaign");
				var idColumnName = esq.AddColumn("Id").Name; 
				esq.AddColumn("CreatedOn").OrderByAsc(); 
				var utmFilter = esq.CreateFilterWithParameters(
					FilterComparisonType.Equal,  "UtmCampaign", utmCampaignValue);
				esq.Filters.Add(utmFilter);
				var entityCollection = esq.GetEntityCollection(UserConnection);
				if(entityCollection.Count > 0) {
					Entity.SetColumnValue("CampaignId", entityCollection[0].GetColumnValue(idColumnName));
				}
			}
			if(!string.IsNullOrEmpty(bulkEmailRIdValue)){
				var select = new Select(UserConnection)
							.Column("Id")
							.From("BulkEmail")
							.Where("RId").IsEqual(Column.Parameter(bulkEmailRIdValue)) as Select;
				var bulkEmailId = select.ExecuteScalar<Guid>();
				if(bulkEmailId != Guid.Empty) {
					Entity.SetColumnValue("BulkEmailId", bulkEmailId);
				}
			}
		}

		public override void LeadInserting() {
			base.LeadInserting();
			BindToCampaignAndBulkEmail();
		}

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

	#region Class: Lead_MarketingCampaignEventsProcess

	/// <exclude/>
	public class Lead_MarketingCampaignEventsProcess : Lead_MarketingCampaignEventsProcess<Lead_MarketingCampaign_Terrasoft>
	{

		public Lead_MarketingCampaignEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: Lead_MarketingCampaign_TerrasoftEventsProcessSchema

	/// <exclude/>
	public class Lead_MarketingCampaign_TerrasoftEventsProcessSchema : Terrasoft.Configuration.Lead_OrderLead_TerrasoftEventsProcessSchema
	{

		#region Constructors: Public

		public Lead_MarketingCampaign_TerrasoftEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public Lead_MarketingCampaign_TerrasoftEventsProcessSchema(Lead_MarketingCampaign_TerrasoftEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "Lead_MarketingCampaignEventsProcess";
			UId = new Guid("cb998591-fb1e-44ca-9aa6-33ec299f99b8");
			CreatedInPackageId = new Guid("3a81387c-e6ac-40c7-b70e-9a0c3966258b");
			CreatedInSchemaUId = Guid.Empty;
			CreatedInVersion = @"0.0.0.0";
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("8809225a-873c-47d0-b036-0b91f1749b42");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaMarketingCampaignLaneSet3 = CreateMarketingCampaignLaneSet3LaneSet();
			LaneSets.Add(schemaMarketingCampaignLaneSet3);
			ProcessSchemaLane schemaMarketingCampaignLane1 = CreateMarketingCampaignLane1Lane();
			schemaMarketingCampaignLaneSet3.Lanes.Add(schemaMarketingCampaignLane1);
		}

		protected virtual ProcessSchemaLaneSet CreateMarketingCampaignLaneSet3LaneSet() {
			ProcessSchemaLaneSet schemaMarketingCampaignLaneSet3 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("43d9cbd9-12b8-4d50-81f4-1a681cec8d6b"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("8809225a-873c-47d0-b036-0b91f1749b42"),
				CreatedInPackageId = new Guid("3a81387c-e6ac-40c7-b70e-9a0c3966258b"),
				CreatedInSchemaUId = new Guid("cb998591-fb1e-44ca-9aa6-33ec299f99b8"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("cb998591-fb1e-44ca-9aa6-33ec299f99b8"),
				Name = @"MarketingCampaignLaneSet3",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(5, 5),
				Size = new Size(837, 170),
				UseBackgroundMode = false
			};
			return schemaMarketingCampaignLaneSet3;
		}

		protected virtual ProcessSchemaLane CreateMarketingCampaignLane1Lane() {
			ProcessSchemaLane schemaMarketingCampaignLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("e1707b8e-8591-4e96-b56f-f535cdb27b8d"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("43d9cbd9-12b8-4d50-81f4-1a681cec8d6b"),
				CreatedInOwnerSchemaUId = new Guid("5c06dbee-b035-41e6-a7c7-df3fc2c8297f"),
				CreatedInPackageId = new Guid("3a81387c-e6ac-40c7-b70e-9a0c3966258b"),
				CreatedInSchemaUId = new Guid("cb998591-fb1e-44ca-9aa6-33ec299f99b8"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("cb998591-fb1e-44ca-9aa6-33ec299f99b8"),
				Name = @"MarketingCampaignLane1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(29, 0),
				Size = new Size(808, 170),
				UseBackgroundMode = false
			};
			return schemaMarketingCampaignLane1;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateBindToCampaignAndBulkEmailMethod());
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("fb7b81ba-7c3c-45a5-ae9e-c6c03dceb812"),
				Name = "Terrasoft.UI.WebControls.Controls",
				Alias = "",
				CreatedInPackageId = new Guid("e2e8b4e4-4b03-4026-918c-e0a401773e64")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("cde525cf-d220-4d2a-b963-e55254c639fc"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("e2e8b4e4-4b03-4026-918c-e0a401773e64")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5c9c82c6-ba6d-4a57-9a14-87fe8faa4ebb"),
				Name = "Terrasoft.Core.DB",
				Alias = "",
				CreatedInPackageId = new Guid("e2e8b4e4-4b03-4026-918c-e0a401773e64")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7821de68-c82b-4917-a6cd-add2adfbe400"),
				Name = "Terrasoft.Common",
				Alias = "",
				CreatedInPackageId = new Guid("e2e8b4e4-4b03-4026-918c-e0a401773e64")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d67de76f-9cbc-4bfc-babb-6f65cb89b973"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("e2e8b4e4-4b03-4026-918c-e0a401773e64")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("74160d3b-65e3-4694-b554-089f2d980e54"),
				Name = "Newtonsoft.Json",
				Alias = "",
				CreatedInPackageId = new Guid("e2e8b4e4-4b03-4026-918c-e0a401773e64")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e401300a-9f16-40c2-9788-cf310ae9d1c5"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("e2e8b4e4-4b03-4026-918c-e0a401773e64")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("85b2cb4e-5c08-4ff5-affc-a9802222c0a5"),
				Name = "System.Collections.Specialized",
				Alias = "",
				CreatedInPackageId = new Guid("3a81387c-e6ac-40c7-b70e-9a0c3966258b")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("826762da-1a84-4b92-a6ca-292b47eaa0c2"),
				Name = "System.Web",
				Alias = "",
				CreatedInPackageId = new Guid("3a81387c-e6ac-40c7-b70e-9a0c3966258b")
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

		protected override SchemaMethod CreateLeadInsertingMethod() {
			SchemaMethod method = base.CreateLeadInsertingMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,75,74,44,78,213,243,73,77,76,241,204,43,78,45,42,201,204,75,215,208,180,230,114,202,204,75,9,201,119,78,204,45,72,204,76,207,115,204,75,113,42,205,201,118,205,77,204,204,1,202,2,0,200,147,216,205,51,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateBindToCampaignAndBulkEmailMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("9dbca586-5998-4ab4-b3a2-28fb1f66b981"),
				Name = "BindToCampaignAndBulkEmail",
				CreatedInSchemaUId = new Guid("cb998591-fb1e-44ca-9aa6-33ec299f99b8"),
				CreatedInPackageId = new Guid("3a81387c-e6ac-40c7-b70e-9a0c3966258b"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,84,219,110,218,64,16,125,6,41,255,176,248,105,45,161,85,158,75,74,5,22,73,172,182,161,13,161,121,136,34,180,193,3,172,234,11,217,93,183,177,42,254,189,179,23,140,101,39,105,223,188,51,103,206,156,185,89,108,8,29,204,114,45,116,197,98,21,21,105,153,229,63,120,90,194,151,130,39,144,208,96,186,207,174,37,108,130,48,36,127,206,250,61,9,186,148,249,232,172,127,56,235,43,45,69,190,37,79,14,65,62,18,207,115,5,250,174,218,67,210,96,187,112,216,113,131,15,57,110,120,6,214,141,200,20,214,90,20,249,145,237,27,151,232,212,32,21,242,230,101,154,34,124,41,5,41,165,192,47,129,170,241,197,238,100,21,73,224,26,168,15,27,18,52,127,22,121,194,38,79,10,211,107,24,146,162,212,38,204,23,240,26,255,181,214,251,165,22,169,17,143,14,5,223,75,144,213,194,74,166,24,202,236,219,40,62,16,72,21,188,213,137,82,103,17,207,246,92,108,93,213,72,221,73,247,16,32,106,181,246,176,224,145,12,92,125,228,211,127,96,63,16,151,137,205,178,189,174,70,167,17,148,233,207,89,198,69,122,27,39,239,100,54,176,21,24,220,74,138,228,95,185,59,232,78,118,177,161,3,111,138,213,13,18,205,165,117,209,118,35,124,239,127,113,73,64,61,155,137,194,111,191,45,139,245,14,115,216,6,211,165,2,25,21,121,238,86,129,53,1,95,121,206,183,32,135,36,56,18,219,13,178,148,194,111,154,89,39,228,198,12,108,146,120,27,13,226,36,8,153,113,141,8,226,91,78,183,61,201,28,217,216,92,38,32,167,213,68,173,105,104,177,134,27,43,185,20,41,54,196,19,187,0,103,186,23,122,119,106,24,197,136,158,115,68,5,74,148,66,21,185,185,3,54,123,46,121,58,36,36,88,158,218,18,12,59,219,98,235,49,57,28,137,50,58,105,157,191,174,22,108,87,26,23,227,132,225,209,205,90,158,86,63,45,3,142,172,77,192,162,162,204,53,25,147,115,55,165,158,63,227,5,232,198,5,211,186,241,216,208,97,71,197,195,249,163,145,208,12,104,142,37,180,201,15,246,88,222,220,154,206,22,135,225,113,107,20,152,60,126,113,22,246,209,174,206,40,239,245,88,115,236,222,116,41,139,12,127,60,71,246,218,126,191,3,137,117,221,218,13,137,149,29,19,117,241,172,158,235,107,170,8,87,94,196,113,40,53,40,78,80,164,83,203,102,47,176,198,63,208,98,205,83,46,47,174,74,145,140,233,113,8,205,0,188,66,227,116,103,245,254,12,166,167,48,28,66,131,164,238,239,95,74,90,14,209,209,5,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new Lead_MarketingCampaign_TerrasoftEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("cb998591-fb1e-44ca-9aa6-33ec299f99b8"));
		}

		#endregion

	}

	#endregion

}

