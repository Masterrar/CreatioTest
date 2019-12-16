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

	#region Class: PortalEmailMessageSchema

	/// <exclude/>
	public class PortalEmailMessageSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public PortalEmailMessageSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public PortalEmailMessageSchema(PortalEmailMessageSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public PortalEmailMessageSchema(PortalEmailMessageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("92f15430-ea7c-4e98-9580-14b5d80fe5e6");
			RealUId = new Guid("92f15430-ea7c-4e98-9580-14b5d80fe5e6");
			Name = "PortalEmailMessage";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("c85d2d65-6230-4aeb-9934-bfac9785d42f");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("a4c8140b-6136-442a-9175-b70f9e955047")) == null) {
				Columns.Add(CreateCaseMessageHistoryColumn());
			}
			if (Columns.FindByUId(new Guid("f9e40343-10bf-4820-bfc2-824587ae9cb4")) == null) {
				Columns.Add(CreateRecipientColumn());
			}
			if (Columns.FindByUId(new Guid("9e79c0dd-c82f-49d9-9f56-766b8630b54b")) == null) {
				Columns.Add(CreateSenderColumn());
			}
			if (Columns.FindByUId(new Guid("b6ae512c-8182-444c-a2f2-44b30fc3075b")) == null) {
				Columns.Add(CreateSendDateColumn());
			}
			if (Columns.FindByUId(new Guid("b4a82d88-32bc-4eb5-8031-31b19adf856f")) == null) {
				Columns.Add(CreateIsHtmlBodyColumn());
			}
			if (Columns.FindByUId(new Guid("22daf758-b8ff-4474-824b-5f56a23d552e")) == null) {
				Columns.Add(CreateMessageTypeIdColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateCaseMessageHistoryColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("a4c8140b-6136-442a-9175-b70f9e955047"),
				Name = @"CaseMessageHistory",
				ReferenceSchemaUId = new Guid("9abf0257-2d36-47ca-920c-b9fb084275d6"),
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("92f15430-ea7c-4e98-9580-14b5d80fe5e6"),
				ModifiedInSchemaUId = new Guid("92f15430-ea7c-4e98-9580-14b5d80fe5e6"),
				CreatedInPackageId = new Guid("eac080e5-c7e6-4027-928f-bde13f5a1451")
			};
		}

		protected virtual EntitySchemaColumn CreateRecipientColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("f9e40343-10bf-4820-bfc2-824587ae9cb4"),
				Name = @"Recipient",
				CreatedInSchemaUId = new Guid("92f15430-ea7c-4e98-9580-14b5d80fe5e6"),
				ModifiedInSchemaUId = new Guid("92f15430-ea7c-4e98-9580-14b5d80fe5e6"),
				CreatedInPackageId = new Guid("eac080e5-c7e6-4027-928f-bde13f5a1451")
			};
		}

		protected virtual EntitySchemaColumn CreateSenderColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("9e79c0dd-c82f-49d9-9f56-766b8630b54b"),
				Name = @"Sender",
				CreatedInSchemaUId = new Guid("92f15430-ea7c-4e98-9580-14b5d80fe5e6"),
				ModifiedInSchemaUId = new Guid("92f15430-ea7c-4e98-9580-14b5d80fe5e6"),
				CreatedInPackageId = new Guid("eac080e5-c7e6-4027-928f-bde13f5a1451")
			};
		}

		protected virtual EntitySchemaColumn CreateSendDateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("DateTime")) {
				UId = new Guid("b6ae512c-8182-444c-a2f2-44b30fc3075b"),
				Name = @"SendDate",
				CreatedInSchemaUId = new Guid("92f15430-ea7c-4e98-9580-14b5d80fe5e6"),
				ModifiedInSchemaUId = new Guid("92f15430-ea7c-4e98-9580-14b5d80fe5e6"),
				CreatedInPackageId = new Guid("eac080e5-c7e6-4027-928f-bde13f5a1451")
			};
		}

		protected virtual EntitySchemaColumn CreateIsHtmlBodyColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("b4a82d88-32bc-4eb5-8031-31b19adf856f"),
				Name = @"IsHtmlBody",
				CreatedInSchemaUId = new Guid("92f15430-ea7c-4e98-9580-14b5d80fe5e6"),
				ModifiedInSchemaUId = new Guid("92f15430-ea7c-4e98-9580-14b5d80fe5e6"),
				CreatedInPackageId = new Guid("eac080e5-c7e6-4027-928f-bde13f5a1451")
			};
		}

		protected virtual EntitySchemaColumn CreateMessageTypeIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("22daf758-b8ff-4474-824b-5f56a23d552e"),
				Name = @"MessageTypeId",
				CreatedInSchemaUId = new Guid("92f15430-ea7c-4e98-9580-14b5d80fe5e6"),
				ModifiedInSchemaUId = new Guid("92f15430-ea7c-4e98-9580-14b5d80fe5e6"),
				CreatedInPackageId = new Guid("eac080e5-c7e6-4027-928f-bde13f5a1451")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreatePortalEmailMessageEventsProcessSchema();
		}

		protected virtual ProcessSchema CreatePortalEmailMessageEventsProcessSchema() {
			var schema = new PortalEmailMessageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new PortalEmailMessage(userConnection){Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new PortalEmailMessage_PortalEventsProcess(userConnnection);
		}

		public override object Clone() {
			return new PortalEmailMessageSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new PortalEmailMessageSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("92f15430-ea7c-4e98-9580-14b5d80fe5e6"));
		}

		#endregion

	}

	#endregion

	#region Class: PortalEmailMessage

	/// <summary>
	/// Portal email message.
	/// </summary>
	public class PortalEmailMessage : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public PortalEmailMessage(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "PortalEmailMessage";
		}

		public PortalEmailMessage(PortalEmailMessage source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid CaseMessageHistoryId {
			get {
				return GetTypedColumnValue<Guid>("CaseMessageHistoryId");
			}
			set {
				SetColumnValue("CaseMessageHistoryId", value);
				_caseMessageHistory = null;
			}
		}

		private CaseMessageHistory _caseMessageHistory;
		/// <summary>
		/// CaseMessageHistory.
		/// </summary>
		public CaseMessageHistory CaseMessageHistory {
			get {
				return _caseMessageHistory ??
					(_caseMessageHistory = LookupColumnEntities.GetEntity("CaseMessageHistory") as CaseMessageHistory);
			}
		}

		/// <summary>
		/// Recipient.
		/// </summary>
		public string Recipient {
			get {
				return GetTypedColumnValue<string>("Recipient");
			}
			set {
				SetColumnValue("Recipient", value);
			}
		}

		/// <summary>
		/// Sender.
		/// </summary>
		public string Sender {
			get {
				return GetTypedColumnValue<string>("Sender");
			}
			set {
				SetColumnValue("Sender", value);
			}
		}

		/// <summary>
		/// SendDate.
		/// </summary>
		public DateTime SendDate {
			get {
				return GetTypedColumnValue<DateTime>("SendDate");
			}
			set {
				SetColumnValue("SendDate", value);
			}
		}

		/// <summary>
		/// Is html body.
		/// </summary>
		public bool IsHtmlBody {
			get {
				return GetTypedColumnValue<bool>("IsHtmlBody");
			}
			set {
				SetColumnValue("IsHtmlBody", value);
			}
		}

		/// <summary>
		/// Message type.
		/// </summary>
		public Guid MessageTypeId {
			get {
				return GetTypedColumnValue<Guid>("MessageTypeId");
			}
			set {
				SetColumnValue("MessageTypeId", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new PortalEmailMessage_PortalEventsProcess(UserConnection);
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
			return new PortalEmailMessage(this);
		}

		#endregion

	}

	#endregion

	#region Class: PortalEmailMessage_PortalEventsProcess

	/// <exclude/>
	public class PortalEmailMessage_PortalEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_LocalMessageEventsProcess<TEntity> where TEntity : PortalEmailMessage
	{

		public PortalEmailMessage_PortalEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "PortalEmailMessage_PortalEventsProcess";
			SchemaUId = new Guid("92f15430-ea7c-4e98-9580-14b5d80fe5e6");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("92f15430-ea7c-4e98-9580-14b5d80fe5e6");
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

	#region Class: PortalEmailMessage_PortalEventsProcess

	/// <exclude/>
	public class PortalEmailMessage_PortalEventsProcess : PortalEmailMessage_PortalEventsProcess<PortalEmailMessage>
	{

		public PortalEmailMessage_PortalEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: PortalEmailMessageEventsProcessSchema

	/// <exclude/>
	public class PortalEmailMessageEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public PortalEmailMessageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public PortalEmailMessageEventsProcessSchema(PortalEmailMessageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "PortalEmailMessage_PortalEventsProcess";
			UId = new Guid("c5825789-d4e9-48d7-9cdf-a2fcf29c12dc");
			CreatedInPackageId = new Guid("c85d2d65-6230-4aeb-9934-bfac9785d42f");
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
			return new PortalEmailMessageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c5825789-d4e9-48d7-9cdf-a2fcf29c12dc"));
		}

		#endregion

	}

	#endregion


	#region Class: PortalEmailMessageEventsProcess

	/// <exclude/>
	public class PortalEmailMessageEventsProcess : PortalEmailMessage_PortalEventsProcess
	{

		public PortalEmailMessageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

