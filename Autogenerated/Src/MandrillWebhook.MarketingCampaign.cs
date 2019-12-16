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

	#region Class: MandrillWebhookSchema

	/// <exclude/>
	public class MandrillWebhookSchema : Terrasoft.Configuration.BaseLookupSchema
	{

		#region Constructors: Public

		public MandrillWebhookSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public MandrillWebhookSchema(MandrillWebhookSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public MandrillWebhookSchema(MandrillWebhookSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("9cb40145-6516-4748-9f9c-905cd3aac514");
			RealUId = new Guid("9cb40145-6516-4748-9f9c-905cd3aac514");
			Name = "MandrillWebhook";
			ParentSchemaUId = new Guid("11ab4bcb-9b23-4b6d-9c86-520fae925d75");
			ExtendParent = false;
			CreatedInPackageId = new Guid("b477c174-1d53-4a21-b489-a41e481a96a0");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("07e2d2ff-105d-4a42-a1dd-1c472823f30a")) == null) {
				Columns.Add(CreateWebhookIdColumn());
			}
			if (Columns.FindByUId(new Guid("f1c1b7d7-cf8e-425f-be50-88d991c8bc17")) == null) {
				Columns.Add(CreateAuthKeyColumn());
			}
			if (Columns.FindByUId(new Guid("6c4b0318-9dba-4b9b-a8fe-149d65a049d3")) == null) {
				Columns.Add(CreateWebhookURLColumn());
			}
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.ModifiedInSchemaUId = new Guid("9cb40145-6516-4748-9f9c-905cd3aac514");
			column.CreatedInPackageId = new Guid("b477c174-1d53-4a21-b489-a41e481a96a0");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.ModifiedInSchemaUId = new Guid("9cb40145-6516-4748-9f9c-905cd3aac514");
			column.CreatedInPackageId = new Guid("b477c174-1d53-4a21-b489-a41e481a96a0");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.ModifiedInSchemaUId = new Guid("9cb40145-6516-4748-9f9c-905cd3aac514");
			column.CreatedInPackageId = new Guid("b477c174-1d53-4a21-b489-a41e481a96a0");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.ModifiedInSchemaUId = new Guid("9cb40145-6516-4748-9f9c-905cd3aac514");
			column.CreatedInPackageId = new Guid("b477c174-1d53-4a21-b489-a41e481a96a0");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.ModifiedInSchemaUId = new Guid("9cb40145-6516-4748-9f9c-905cd3aac514");
			column.CreatedInPackageId = new Guid("b477c174-1d53-4a21-b489-a41e481a96a0");
			return column;
		}

		protected override EntitySchemaColumn CreateNameColumn() {
			EntitySchemaColumn column = base.CreateNameColumn();
			column.ModifiedInSchemaUId = new Guid("9cb40145-6516-4748-9f9c-905cd3aac514");
			column.CreatedInPackageId = new Guid("b477c174-1d53-4a21-b489-a41e481a96a0");
			return column;
		}

		protected override EntitySchemaColumn CreateDescriptionColumn() {
			EntitySchemaColumn column = base.CreateDescriptionColumn();
			column.ModifiedInSchemaUId = new Guid("9cb40145-6516-4748-9f9c-905cd3aac514");
			column.CreatedInPackageId = new Guid("b477c174-1d53-4a21-b489-a41e481a96a0");
			return column;
		}

		protected override EntitySchemaColumn CreateProcessListenersColumn() {
			EntitySchemaColumn column = base.CreateProcessListenersColumn();
			column.ModifiedInSchemaUId = new Guid("9cb40145-6516-4748-9f9c-905cd3aac514");
			column.CreatedInPackageId = new Guid("b477c174-1d53-4a21-b489-a41e481a96a0");
			return column;
		}

		protected virtual EntitySchemaColumn CreateWebhookIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("07e2d2ff-105d-4a42-a1dd-1c472823f30a"),
				Name = @"WebhookId",
				CreatedInSchemaUId = new Guid("9cb40145-6516-4748-9f9c-905cd3aac514"),
				ModifiedInSchemaUId = new Guid("9cb40145-6516-4748-9f9c-905cd3aac514"),
				CreatedInPackageId = new Guid("b477c174-1d53-4a21-b489-a41e481a96a0")
			};
		}

		protected virtual EntitySchemaColumn CreateAuthKeyColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("f1c1b7d7-cf8e-425f-be50-88d991c8bc17"),
				Name = @"AuthKey",
				CreatedInSchemaUId = new Guid("9cb40145-6516-4748-9f9c-905cd3aac514"),
				ModifiedInSchemaUId = new Guid("9cb40145-6516-4748-9f9c-905cd3aac514"),
				CreatedInPackageId = new Guid("b477c174-1d53-4a21-b489-a41e481a96a0")
			};
		}

		protected virtual EntitySchemaColumn CreateWebhookURLColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("LongText")) {
				UId = new Guid("6c4b0318-9dba-4b9b-a8fe-149d65a049d3"),
				Name = @"WebhookURL",
				CreatedInSchemaUId = new Guid("9cb40145-6516-4748-9f9c-905cd3aac514"),
				ModifiedInSchemaUId = new Guid("9cb40145-6516-4748-9f9c-905cd3aac514"),
				CreatedInPackageId = new Guid("b477c174-1d53-4a21-b489-a41e481a96a0")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateMandrillWebhookEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateMandrillWebhookEventsProcessSchema() {
			var schema = new MandrillWebhookEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new MandrillWebhook(userConnection){Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new MandrillWebhook_MarketingCampaignEventsProcess(userConnnection);
		}

		public override object Clone() {
			return new MandrillWebhookSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new MandrillWebhookSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("9cb40145-6516-4748-9f9c-905cd3aac514"));
		}

		#endregion

	}

	#endregion

	#region Class: MandrillWebhook

	/// <summary>
	/// Mandrill bulk email update.
	/// </summary>
	public class MandrillWebhook : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public MandrillWebhook(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "MandrillWebhook";
		}

		public MandrillWebhook(MandrillWebhook source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Number.
		/// </summary>
		public  int WebhookId {
			get {
				return GetTypedColumnValue<int>("WebhookId");
			}
			set {
				SetColumnValue("WebhookId", value);
			}
		}

		/// <summary>
		/// Authentication key.
		/// </summary>
		public  string AuthKey {
			get {
				return GetTypedColumnValue<string>("AuthKey");
			}
			set {
				SetColumnValue("AuthKey", value);
			}
		}

		/// <summary>
		/// Webhook address for customer.
		/// </summary>
		public  string WebhookURL {
			get {
				return GetTypedColumnValue<string>("WebhookURL");
			}
			set {
				SetColumnValue("WebhookURL", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new MandrillWebhook_MarketingCampaignEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Inserting += (s, e) => ThrowEvent("MandrillWebhookInserting", e);
			Validating += (s, e) => ThrowEvent("MandrillWebhookValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new MandrillWebhook(this);
		}

		#endregion

	}

	#endregion

	#region Class: MandrillWebhook_MarketingCampaignEventsProcess

	/// <exclude/>
	public class MandrillWebhook_MarketingCampaignEventsProcess<TEntity> : Terrasoft.Configuration.BaseLookup_BaseEventsProcess<TEntity> where TEntity : MandrillWebhook
	{

		public MandrillWebhook_MarketingCampaignEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "MandrillWebhook_MarketingCampaignEventsProcess";
			SchemaUId = new Guid("9cb40145-6516-4748-9f9c-905cd3aac514");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private  Guid InternalSchemaUId {
			get {
				return new Guid("9cb40145-6516-4748-9f9c-905cd3aac514");
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

	#region Class: MandrillWebhook_MarketingCampaignEventsProcess

	/// <exclude/>
	public class MandrillWebhook_MarketingCampaignEventsProcess : MandrillWebhook_MarketingCampaignEventsProcess<MandrillWebhook>
	{

		public MandrillWebhook_MarketingCampaignEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: MandrillWebhookEventsProcessSchema

	/// <exclude/>
	public class MandrillWebhookEventsProcessSchema : Terrasoft.Configuration.BaseLookupEventsProcessSchema
	{

		#region Constructors: Public

		public MandrillWebhookEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public MandrillWebhookEventsProcessSchema(MandrillWebhookEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "MandrillWebhook_MarketingCampaignEventsProcess";
			UId = new Guid("1aa740c5-c938-4dd0-a3b3-c6f92aa2fd5a");
			CreatedInPackageId = new Guid("b477c174-1d53-4a21-b489-a41e481a96a0");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("e20c0489-122a-4242-999c-169e8e866fc1");
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
				CreatedInPackageId = new Guid("b477c174-1d53-4a21-b489-a41e481a96a0")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("cde525cf-d220-4d2a-b963-e55254c639fc"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("b477c174-1d53-4a21-b489-a41e481a96a0")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5c9c82c6-ba6d-4a57-9a14-87fe8faa4ebb"),
				Name = "Terrasoft.Core.DB",
				Alias = "",
				CreatedInPackageId = new Guid("b477c174-1d53-4a21-b489-a41e481a96a0")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7821de68-c82b-4917-a6cd-add2adfbe400"),
				Name = "Terrasoft.Common",
				Alias = "",
				CreatedInPackageId = new Guid("b477c174-1d53-4a21-b489-a41e481a96a0")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d67de76f-9cbc-4bfc-babb-6f65cb89b973"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("b477c174-1d53-4a21-b489-a41e481a96a0")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("74160d3b-65e3-4694-b554-089f2d980e54"),
				Name = "Newtonsoft.Json",
				Alias = "",
				CreatedInPackageId = new Guid("b477c174-1d53-4a21-b489-a41e481a96a0")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e401300a-9f16-40c2-9788-cf310ae9d1c5"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("b477c174-1d53-4a21-b489-a41e481a96a0")
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
			return new MandrillWebhookEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("1aa740c5-c938-4dd0-a3b3-c6f92aa2fd5a"));
		}

		#endregion

	}

	#endregion


	#region Class: MandrillWebhookEventsProcess

	/// <exclude/>
	public class MandrillWebhookEventsProcess : MandrillWebhook_MarketingCampaignEventsProcess
	{

		public MandrillWebhookEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

