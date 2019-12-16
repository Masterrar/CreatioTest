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

	#region Class: VwSiteEventSchema

	/// <exclude/>
	public class VwSiteEventSchema : Terrasoft.Configuration.SiteEventSchema
	{

		#region Constructors: Public

		public VwSiteEventSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public VwSiteEventSchema(VwSiteEventSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public VwSiteEventSchema(VwSiteEventSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private EntitySchemaIndex CreateIvY8DJLJ6yOkP6AquJay1kSPHJvcIndex() {
			EntitySchemaIndex index = new EntitySchemaIndex() {
				IsAutoName = true,
				IsClustered = false,
				IsUnique = false
			};
			index.UId = new Guid("50a6761f-fda2-4605-ac06-19506850fbba");
			index.Name = "IvY8DJLJ6yOkP6AquJay1kSPHJvc";
			index.CreatedInSchemaUId = new Guid("aae17d34-795d-4103-bfd4-837fcbc766b2");
			index.ModifiedInSchemaUId = new Guid("aae17d34-795d-4103-bfd4-837fcbc766b2");
			index.CreatedInPackageId = new Guid("895fb87d-7418-4883-85be-9c84b0af23bd");
			EntitySchemaIndexColumn bpmSessionIdIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("2ee219b8-918d-4bec-9c5e-8ab9e8761e8a"),
				ColumnUId = new Guid("4333c2b2-9461-4c1f-bb79-2634671b5368"),
				CreatedInSchemaUId = new Guid("aae17d34-795d-4103-bfd4-837fcbc766b2"),
				ModifiedInSchemaUId = new Guid("aae17d34-795d-4103-bfd4-837fcbc766b2"),
				CreatedInPackageId = new Guid("895fb87d-7418-4883-85be-9c84b0af23bd"),
				OrderDirection = OrderDirectionStrict.Ascending
			};
			index.Columns.Add(bpmSessionIdIndexColumn);
			return index;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("05d5c19a-1456-4783-ba8f-69ad2cf5c046");
			RealUId = new Guid("05d5c19a-1456-4783-ba8f-69ad2cf5c046");
			Name = "VwSiteEvent";
			ParentSchemaUId = new Guid("93a880c8-dea8-47d5-9b79-1d7fd8259ca0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("47949cd8-6780-414e-8fda-4fa996b6db3c");
			IsDBView = true;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("baf174ee-94ee-4ee5-914b-781e0687dcd7")) == null) {
				Columns.Add(CreateLeadColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateLeadColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("baf174ee-94ee-4ee5-914b-781e0687dcd7"),
				Name = @"Lead",
				ReferenceSchemaUId = new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("05d5c19a-1456-4783-ba8f-69ad2cf5c046"),
				ModifiedInSchemaUId = new Guid("05d5c19a-1456-4783-ba8f-69ad2cf5c046"),
				CreatedInPackageId = new Guid("0b806dce-f27a-40de-a645-9f9ac66bf798")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeIndexes() {
			base.InitializeIndexes();
			Indexes.Add(CreateIvY8DJLJ6yOkP6AquJay1kSPHJvcIndex());
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateVwSiteEventEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateVwSiteEventEventsProcessSchema() {
			var schema = new VwSiteEventEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new VwSiteEvent(userConnection){Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new VwSiteEvent_EventTrackingEventsProcess(userConnnection);
		}

		public override object Clone() {
			return new VwSiteEventSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new VwSiteEventSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("05d5c19a-1456-4783-ba8f-69ad2cf5c046"));
		}

		#endregion

	}

	#endregion

	#region Class: VwSiteEvent

	/// <summary>
	/// Website tracking event in customer profile (view).
	/// </summary>
	public class VwSiteEvent : Terrasoft.Configuration.SiteEvent
	{

		#region Constructors: Public

		public VwSiteEvent(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "VwSiteEvent";
		}

		public VwSiteEvent(VwSiteEvent source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid LeadId {
			get {
				return GetTypedColumnValue<Guid>("LeadId");
			}
			set {
				SetColumnValue("LeadId", value);
				_lead = null;
			}
		}

		/// <exclude/>
		public string LeadLeadName {
			get {
				return GetTypedColumnValue<string>("LeadLeadName");
			}
			set {
				SetColumnValue("LeadLeadName", value);
				if (_lead != null) {
					_lead.LeadName = value;
				}
			}
		}

		private Lead _lead;
		/// <summary>
		/// Lead.
		/// </summary>
		public Lead Lead {
			get {
				return _lead ??
					(_lead = LookupColumnEntities.GetEntity("Lead") as Lead);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new VwSiteEvent_EventTrackingEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("VwSiteEventDeleted", e);
			Validating += (s, e) => ThrowEvent("VwSiteEventValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new VwSiteEvent(this);
		}

		#endregion

	}

	#endregion

	#region Class: VwSiteEvent_EventTrackingEventsProcess

	/// <exclude/>
	public class VwSiteEvent_EventTrackingEventsProcess<TEntity> : Terrasoft.Configuration.SiteEvent_EventTrackingEventsProcess<TEntity> where TEntity : VwSiteEvent
	{

		public VwSiteEvent_EventTrackingEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "VwSiteEvent_EventTrackingEventsProcess";
			SchemaUId = new Guid("05d5c19a-1456-4783-ba8f-69ad2cf5c046");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("05d5c19a-1456-4783-ba8f-69ad2cf5c046");
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

	#region Class: VwSiteEvent_EventTrackingEventsProcess

	/// <exclude/>
	public class VwSiteEvent_EventTrackingEventsProcess : VwSiteEvent_EventTrackingEventsProcess<VwSiteEvent>
	{

		public VwSiteEvent_EventTrackingEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: VwSiteEventEventsProcessSchema

	/// <exclude/>
	public class VwSiteEventEventsProcessSchema : Terrasoft.Configuration.SiteEventEventsProcessSchema
	{

		#region Constructors: Public

		public VwSiteEventEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public VwSiteEventEventsProcessSchema(VwSiteEventEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "VwSiteEvent_EventTrackingEventsProcess";
			UId = new Guid("66919952-daed-4537-ba42-cbadcf86467d");
			CreatedInPackageId = new Guid("47949cd8-6780-414e-8fda-4fa996b6db3c");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("a129bcac-2054-42dd-99ad-9932efd017ed");
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
				CreatedInPackageId = new Guid("c65af0e3-7594-46d5-990b-d36fcba84a2a")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("cde525cf-d220-4d2a-b963-e55254c639fc"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("c65af0e3-7594-46d5-990b-d36fcba84a2a")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5c9c82c6-ba6d-4a57-9a14-87fe8faa4ebb"),
				Name = "Terrasoft.Core.DB",
				Alias = "",
				CreatedInPackageId = new Guid("c65af0e3-7594-46d5-990b-d36fcba84a2a")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7821de68-c82b-4917-a6cd-add2adfbe400"),
				Name = "Terrasoft.Common",
				Alias = "",
				CreatedInPackageId = new Guid("c65af0e3-7594-46d5-990b-d36fcba84a2a")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d67de76f-9cbc-4bfc-babb-6f65cb89b973"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("c65af0e3-7594-46d5-990b-d36fcba84a2a")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("74160d3b-65e3-4694-b554-089f2d980e54"),
				Name = "Newtonsoft.Json",
				Alias = "",
				CreatedInPackageId = new Guid("c65af0e3-7594-46d5-990b-d36fcba84a2a")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e401300a-9f16-40c2-9788-cf310ae9d1c5"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("c65af0e3-7594-46d5-990b-d36fcba84a2a")
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
			return new VwSiteEventEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("66919952-daed-4537-ba42-cbadcf86467d"));
		}

		#endregion

	}

	#endregion


	#region Class: VwSiteEventEventsProcess

	/// <exclude/>
	public class VwSiteEventEventsProcess : VwSiteEvent_EventTrackingEventsProcess
	{

		public VwSiteEventEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

