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
	using Terrasoft.Core.Campaign;
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

	#region Class: CampaignParticipantOpSchema

	/// <exclude/>
	public class CampaignParticipantOpSchema : Terrasoft.Configuration.CampaignParticipantSchema
	{

		#region Constructors: Public

		public CampaignParticipantOpSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public CampaignParticipantOpSchema(CampaignParticipantOpSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public CampaignParticipantOpSchema(CampaignParticipantOpSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("768ecc55-e80e-4df8-837f-085fb32e001f");
			RealUId = new Guid("768ecc55-e80e-4df8-837f-085fb32e001f");
			Name = "CampaignParticipantOp";
			ParentSchemaUId = new Guid("d42c6b3f-5128-4a5f-9346-557b066db650");
			ExtendParent = false;
			CreatedInPackageId = new Guid("bac310da-8f6a-4932-87be-74eb3d9d7067");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("aaaacfa8-e963-4328-8eea-9505e11cda00")) == null) {
				Columns.Add(CreateSessionIdColumn());
			}
			if (Columns.FindByUId(new Guid("60266941-88a3-49b0-9402-5e0374d8f483")) == null) {
				Columns.Add(CreateIsReadyToSyncColumn());
			}
			if (Columns.FindByUId(new Guid("8b71ab42-eae2-4ec6-8eb4-fb9ea747660a")) == null) {
				Columns.Add(CreateInitialCampaignItemColumn());
			}
			if (Columns.FindByUId(new Guid("3b685758-82b4-48b3-b4d7-76d8cb507607")) == null) {
				Columns.Add(CreateCampaignParticipantColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateSessionIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("aaaacfa8-e963-4328-8eea-9505e11cda00"),
				Name = @"SessionId",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("768ecc55-e80e-4df8-837f-085fb32e001f"),
				ModifiedInSchemaUId = new Guid("768ecc55-e80e-4df8-837f-085fb32e001f"),
				CreatedInPackageId = new Guid("bac310da-8f6a-4932-87be-74eb3d9d7067")
			};
		}

		protected virtual EntitySchemaColumn CreateIsReadyToSyncColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("60266941-88a3-49b0-9402-5e0374d8f483"),
				Name = @"IsReadyToSync",
				CreatedInSchemaUId = new Guid("768ecc55-e80e-4df8-837f-085fb32e001f"),
				ModifiedInSchemaUId = new Guid("768ecc55-e80e-4df8-837f-085fb32e001f"),
				CreatedInPackageId = new Guid("bac310da-8f6a-4932-87be-74eb3d9d7067")
			};
		}

		protected virtual EntitySchemaColumn CreateInitialCampaignItemColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("8b71ab42-eae2-4ec6-8eb4-fb9ea747660a"),
				Name = @"InitialCampaignItem",
				ReferenceSchemaUId = new Guid("28045fad-1d04-4bb5-8600-ed4ca87b5650"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("768ecc55-e80e-4df8-837f-085fb32e001f"),
				ModifiedInSchemaUId = new Guid("768ecc55-e80e-4df8-837f-085fb32e001f"),
				CreatedInPackageId = new Guid("6c038aa0-46cd-4697-bc93-5c682e364aef")
			};
		}

		protected virtual EntitySchemaColumn CreateCampaignParticipantColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("3b685758-82b4-48b3-b4d7-76d8cb507607"),
				Name = @"CampaignParticipant",
				ReferenceSchemaUId = new Guid("d42c6b3f-5128-4a5f-9346-557b066db650"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("768ecc55-e80e-4df8-837f-085fb32e001f"),
				ModifiedInSchemaUId = new Guid("768ecc55-e80e-4df8-837f-085fb32e001f"),
				CreatedInPackageId = new Guid("6c038aa0-46cd-4697-bc93-5c682e364aef")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateCampaignParticipantOpEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateCampaignParticipantOpEventsProcessSchema() {
			var schema = new CampaignParticipantOpEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new CampaignParticipantOp(userConnection){Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new CampaignParticipantOp_CampaignsEventsProcess(userConnnection);
		}

		public override object Clone() {
			return new CampaignParticipantOpSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new CampaignParticipantOpSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("768ecc55-e80e-4df8-837f-085fb32e001f"));
		}

		#endregion

	}

	#endregion

	#region Class: CampaignParticipantOp

	/// <summary>
	/// SysCampaignParticipant (operating table).
	/// </summary>
	public class CampaignParticipantOp : Terrasoft.Configuration.CampaignParticipant
	{

		#region Constructors: Public

		public CampaignParticipantOp(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "CampaignParticipantOp";
		}

		public CampaignParticipantOp(CampaignParticipantOp source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// SessionId.
		/// </summary>
		public Guid SessionId {
			get {
				return GetTypedColumnValue<Guid>("SessionId");
			}
			set {
				SetColumnValue("SessionId", value);
			}
		}

		/// <summary>
		/// IsReadyToSync.
		/// </summary>
		public bool IsReadyToSync {
			get {
				return GetTypedColumnValue<bool>("IsReadyToSync");
			}
			set {
				SetColumnValue("IsReadyToSync", value);
			}
		}

		/// <exclude/>
		public Guid InitialCampaignItemId {
			get {
				return GetTypedColumnValue<Guid>("InitialCampaignItemId");
			}
			set {
				SetColumnValue("InitialCampaignItemId", value);
				_initialCampaignItem = null;
			}
		}

		/// <exclude/>
		public string InitialCampaignItemName {
			get {
				return GetTypedColumnValue<string>("InitialCampaignItemName");
			}
			set {
				SetColumnValue("InitialCampaignItemName", value);
				if (_initialCampaignItem != null) {
					_initialCampaignItem.Name = value;
				}
			}
		}

		private CampaignItem _initialCampaignItem;
		/// <summary>
		/// Initial participant's campaign item.
		/// </summary>
		public CampaignItem InitialCampaignItem {
			get {
				return _initialCampaignItem ??
					(_initialCampaignItem = LookupColumnEntities.GetEntity("InitialCampaignItem") as CampaignItem);
			}
		}

		/// <exclude/>
		public Guid CampaignParticipantId {
			get {
				return GetTypedColumnValue<Guid>("CampaignParticipantId");
			}
			set {
				SetColumnValue("CampaignParticipantId", value);
				_campaignParticipant = null;
			}
		}

		private CampaignParticipant _campaignParticipant;
		/// <summary>
		/// CampaignParticipant.
		/// </summary>
		public CampaignParticipant CampaignParticipant {
			get {
				return _campaignParticipant ??
					(_campaignParticipant = LookupColumnEntities.GetEntity("CampaignParticipant") as CampaignParticipant);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new CampaignParticipantOp_CampaignsEventsProcess(UserConnection);
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
			return new CampaignParticipantOp(this);
		}

		#endregion

	}

	#endregion

	#region Class: CampaignParticipantOp_CampaignsEventsProcess

	/// <exclude/>
	public class CampaignParticipantOp_CampaignsEventsProcess<TEntity> : Terrasoft.Configuration.CampaignParticipant_CampaignsEventsProcess<TEntity> where TEntity : CampaignParticipantOp
	{

		public CampaignParticipantOp_CampaignsEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "CampaignParticipantOp_CampaignsEventsProcess";
			SchemaUId = new Guid("768ecc55-e80e-4df8-837f-085fb32e001f");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("768ecc55-e80e-4df8-837f-085fb32e001f");
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

	#region Class: CampaignParticipantOp_CampaignsEventsProcess

	/// <exclude/>
	public class CampaignParticipantOp_CampaignsEventsProcess : CampaignParticipantOp_CampaignsEventsProcess<CampaignParticipantOp>
	{

		public CampaignParticipantOp_CampaignsEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: CampaignParticipantOpEventsProcessSchema

	/// <exclude/>
	public class CampaignParticipantOpEventsProcessSchema : Terrasoft.Configuration.CampaignParticipantEventsProcessSchema
	{

		#region Constructors: Public

		public CampaignParticipantOpEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public CampaignParticipantOpEventsProcessSchema(CampaignParticipantOpEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "CampaignParticipantOp_CampaignsEventsProcess";
			UId = new Guid("d0255124-58fe-4185-90ba-b7083ac31c7c");
			CreatedInPackageId = new Guid("bac310da-8f6a-4932-87be-74eb3d9d7067");
			CreatedInSchemaUId = Guid.Empty;
			CreatedInVersion = @"0.0.0.0";
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("4c8fab55-8034-4c0a-8b51-ef02135114fd");
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
				UId = new Guid("efa5b711-6092-4270-b54a-afe05a033700"),
				Name = "System.Linq",
				Alias = "",
				CreatedInPackageId = new Guid("0fa99f9a-3eca-422f-9a3c-3294c39b5190")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("540a2e64-5e86-4c5d-96de-35a2148ddede"),
				Name = "Terrasoft.Core.Campaign",
				Alias = "",
				CreatedInPackageId = new Guid("6c038aa0-46cd-4697-bc93-5c682e364aef")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("aca2294b-e209-4c40-9400-0d59d9ecd1ea"),
				Name = "Terrasoft.GlobalSearch.Indexing",
				Alias = "",
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			});
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new CampaignParticipantOpEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d0255124-58fe-4185-90ba-b7083ac31c7c"));
		}

		#endregion

	}

	#endregion


	#region Class: CampaignParticipantOpEventsProcess

	/// <exclude/>
	public class CampaignParticipantOpEventsProcess : CampaignParticipantOp_CampaignsEventsProcess
	{

		public CampaignParticipantOpEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

