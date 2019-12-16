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

	#region Class: ServiceEngineerSchema

	/// <exclude/>
	public class ServiceEngineerSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public ServiceEngineerSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public ServiceEngineerSchema(ServiceEngineerSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public ServiceEngineerSchema(ServiceEngineerSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("4820c826-ab51-488c-9f03-edf8ca7c6d6a");
			RealUId = new Guid("4820c826-ab51-488c-9f03-edf8ca7c6d6a");
			Name = "ServiceEngineer";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("a2fc2e06-4c85-4afa-ac7e-48c4edb4a538");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("929f87ac-5314-4b35-9d8c-725f55c9caec")) == null) {
				Columns.Add(CreateServiceItemColumn());
			}
			if (Columns.FindByUId(new Guid("64ee0d0a-cae1-41d9-992f-706e9156a790")) == null) {
				Columns.Add(CreateEngineerColumn());
			}
			if (Columns.FindByUId(new Guid("cd8535dd-d62a-4723-a8bc-8f9efa79e26c")) == null) {
				Columns.Add(CreateSupportLevelColumn());
			}
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.ModifiedInSchemaUId = new Guid("4820c826-ab51-488c-9f03-edf8ca7c6d6a");
			column.CreatedInPackageId = new Guid("a2fc2e06-4c85-4afa-ac7e-48c4edb4a538");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.ModifiedInSchemaUId = new Guid("4820c826-ab51-488c-9f03-edf8ca7c6d6a");
			column.CreatedInPackageId = new Guid("a2fc2e06-4c85-4afa-ac7e-48c4edb4a538");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.ModifiedInSchemaUId = new Guid("4820c826-ab51-488c-9f03-edf8ca7c6d6a");
			column.CreatedInPackageId = new Guid("a2fc2e06-4c85-4afa-ac7e-48c4edb4a538");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.ModifiedInSchemaUId = new Guid("4820c826-ab51-488c-9f03-edf8ca7c6d6a");
			column.CreatedInPackageId = new Guid("a2fc2e06-4c85-4afa-ac7e-48c4edb4a538");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.ModifiedInSchemaUId = new Guid("4820c826-ab51-488c-9f03-edf8ca7c6d6a");
			column.CreatedInPackageId = new Guid("a2fc2e06-4c85-4afa-ac7e-48c4edb4a538");
			return column;
		}

		protected override EntitySchemaColumn CreateProcessListenersColumn() {
			EntitySchemaColumn column = base.CreateProcessListenersColumn();
			column.ModifiedInSchemaUId = new Guid("4820c826-ab51-488c-9f03-edf8ca7c6d6a");
			column.CreatedInPackageId = new Guid("a2fc2e06-4c85-4afa-ac7e-48c4edb4a538");
			return column;
		}

		protected virtual EntitySchemaColumn CreateServiceItemColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("929f87ac-5314-4b35-9d8c-725f55c9caec"),
				Name = @"ServiceItem",
				ReferenceSchemaUId = new Guid("c6c44f0a-193e-4b5c-b35e-220a60c06898"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("4820c826-ab51-488c-9f03-edf8ca7c6d6a"),
				ModifiedInSchemaUId = new Guid("4820c826-ab51-488c-9f03-edf8ca7c6d6a"),
				CreatedInPackageId = new Guid("a2fc2e06-4c85-4afa-ac7e-48c4edb4a538")
			};
		}

		protected virtual EntitySchemaColumn CreateEngineerColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("64ee0d0a-cae1-41d9-992f-706e9156a790"),
				Name = @"Engineer",
				ReferenceSchemaUId = new Guid("84f44b9a-4bc3-4cbf-a1a8-cec02c1c029c"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("4820c826-ab51-488c-9f03-edf8ca7c6d6a"),
				ModifiedInSchemaUId = new Guid("4820c826-ab51-488c-9f03-edf8ca7c6d6a"),
				CreatedInPackageId = new Guid("a2fc2e06-4c85-4afa-ac7e-48c4edb4a538")
			};
		}

		protected virtual EntitySchemaColumn CreateSupportLevelColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("cd8535dd-d62a-4723-a8bc-8f9efa79e26c"),
				Name = @"SupportLevel",
				ReferenceSchemaUId = new Guid("4c2e1b60-ee12-4846-a38e-04204de6fb14"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("4820c826-ab51-488c-9f03-edf8ca7c6d6a"),
				ModifiedInSchemaUId = new Guid("4820c826-ab51-488c-9f03-edf8ca7c6d6a"),
				CreatedInPackageId = new Guid("a2fc2e06-4c85-4afa-ac7e-48c4edb4a538")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateServiceEngineerEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateServiceEngineerEventsProcessSchema() {
			var schema = new ServiceEngineerEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new ServiceEngineer(userConnection){Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new ServiceEngineer_SLMITILServiceEventsProcess(userConnnection);
		}

		public override object Clone() {
			return new ServiceEngineerSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new ServiceEngineerSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("4820c826-ab51-488c-9f03-edf8ca7c6d6a"));
		}

		#endregion

	}

	#endregion

	#region Class: ServiceEngineer

	/// <summary>
	/// Service team member.
	/// </summary>
	public class ServiceEngineer : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public ServiceEngineer(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "ServiceEngineer";
		}

		public ServiceEngineer(ServiceEngineer source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public  Guid ServiceItemId {
			get {
				return GetTypedColumnValue<Guid>("ServiceItemId");
			}
			set {
				SetColumnValue("ServiceItemId", value);
				_serviceItem = null;
			}
		}

		/// <exclude/>
		public  string ServiceItemName {
			get {
				return GetTypedColumnValue<string>("ServiceItemName");
			}
			set {
				SetColumnValue("ServiceItemName", value);
				if (_serviceItem != null) {
					_serviceItem.Name = value;
				}
			}
		}

		private ServiceItem _serviceItem;
		/// <summary>
		/// Service.
		/// </summary>
		public  ServiceItem ServiceItem {
			get {
				return _serviceItem ??
					(_serviceItem = LookupColumnEntities.GetEntity("ServiceItem") as ServiceItem);
			}
		}

		/// <exclude/>
		public  Guid EngineerId {
			get {
				return GetTypedColumnValue<Guid>("EngineerId");
			}
			set {
				SetColumnValue("EngineerId", value);
				_engineer = null;
			}
		}

		/// <exclude/>
		public  string EngineerName {
			get {
				return GetTypedColumnValue<string>("EngineerName");
			}
			set {
				SetColumnValue("EngineerName", value);
				if (_engineer != null) {
					_engineer.Name = value;
				}
			}
		}

		private SysAdminUnit _engineer;
		/// <summary>
		/// Member/team.
		/// </summary>
		public  SysAdminUnit Engineer {
			get {
				return _engineer ??
					(_engineer = LookupColumnEntities.GetEntity("Engineer") as SysAdminUnit);
			}
		}

		/// <exclude/>
		public  Guid SupportLevelId {
			get {
				return GetTypedColumnValue<Guid>("SupportLevelId");
			}
			set {
				SetColumnValue("SupportLevelId", value);
				_supportLevel = null;
			}
		}

		/// <exclude/>
		public  string SupportLevelName {
			get {
				return GetTypedColumnValue<string>("SupportLevelName");
			}
			set {
				SetColumnValue("SupportLevelName", value);
				if (_supportLevel != null) {
					_supportLevel.Name = value;
				}
			}
		}

		private RoleInServiceTeam _supportLevel;
		/// <summary>
		/// Support line.
		/// </summary>
		public  RoleInServiceTeam SupportLevel {
			get {
				return _supportLevel ??
					(_supportLevel = LookupColumnEntities.GetEntity("SupportLevel") as RoleInServiceTeam);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new ServiceEngineer_SLMITILServiceEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Validating += (s, e) => ThrowEvent("ServiceEngineerValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new ServiceEngineer(this);
		}

		#endregion

	}

	#endregion

	#region Class: ServiceEngineer_SLMITILServiceEventsProcess

	/// <exclude/>
	public class ServiceEngineer_SLMITILServiceEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_LocalMessageEventsProcess<TEntity> where TEntity : ServiceEngineer
	{

		public ServiceEngineer_SLMITILServiceEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ServiceEngineer_SLMITILServiceEventsProcess";
			SchemaUId = new Guid("4820c826-ab51-488c-9f03-edf8ca7c6d6a");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private  Guid InternalSchemaUId {
			get {
				return new Guid("4820c826-ab51-488c-9f03-edf8ca7c6d6a");
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

		public override void LocalMessageExecuting(EntityChangeType changeType) {
			var lmHelper = new Terrasoft.Configuration.LocalMessageHelper(this.Entity, UserConnection, changeType);
			lmHelper.CreateLocalMessage();
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

	#region Class: ServiceEngineer_SLMITILServiceEventsProcess

	/// <exclude/>
	public class ServiceEngineer_SLMITILServiceEventsProcess : ServiceEngineer_SLMITILServiceEventsProcess<ServiceEngineer>
	{

		public ServiceEngineer_SLMITILServiceEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: ServiceEngineerEventsProcessSchema

	/// <exclude/>
	public class ServiceEngineerEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public ServiceEngineerEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public ServiceEngineerEventsProcessSchema(ServiceEngineerEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "ServiceEngineer_SLMITILServiceEventsProcess";
			UId = new Guid("ba17bbcb-c0e8-4cf1-adf0-cd222d04c1af");
			CreatedInPackageId = new Guid("a2fc2e06-4c85-4afa-ac7e-48c4edb4a538");
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
				CreatedInPackageId = new Guid("a2fc2e06-4c85-4afa-ac7e-48c4edb4a538")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("cde525cf-d220-4d2a-b963-e55254c639fc"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("a2fc2e06-4c85-4afa-ac7e-48c4edb4a538")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5c9c82c6-ba6d-4a57-9a14-87fe8faa4ebb"),
				Name = "Terrasoft.Core.DB",
				Alias = "",
				CreatedInPackageId = new Guid("a2fc2e06-4c85-4afa-ac7e-48c4edb4a538")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7821de68-c82b-4917-a6cd-add2adfbe400"),
				Name = "Terrasoft.Common",
				Alias = "",
				CreatedInPackageId = new Guid("a2fc2e06-4c85-4afa-ac7e-48c4edb4a538")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d67de76f-9cbc-4bfc-babb-6f65cb89b973"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("a2fc2e06-4c85-4afa-ac7e-48c4edb4a538")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("74160d3b-65e3-4694-b554-089f2d980e54"),
				Name = "Newtonsoft.Json",
				Alias = "",
				CreatedInPackageId = new Guid("a2fc2e06-4c85-4afa-ac7e-48c4edb4a538")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e401300a-9f16-40c2-9788-cf310ae9d1c5"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("a2fc2e06-4c85-4afa-ac7e-48c4edb4a538")
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

		protected override SchemaMethod CreateLocalMessageExecutingMethod() {
			SchemaMethod method = base.CreateLocalMessageExecutingMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,77,141,75,10,194,48,16,134,247,158,98,150,45,148,92,160,184,42,130,11,221,213,3,12,225,111,26,136,147,50,51,86,122,123,45,69,112,255,61,86,86,42,207,43,202,2,165,51,9,222,52,66,149,173,78,30,134,42,83,78,47,101,207,85,194,173,70,46,119,152,113,194,33,52,62,103,11,23,241,236,91,71,15,131,126,13,65,220,241,142,226,204,146,48,110,11,218,254,244,123,132,65,193,142,255,86,211,246,31,106,54,191,216,134,0,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new ServiceEngineerEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ba17bbcb-c0e8-4cf1-adf0-cd222d04c1af"));
		}

		#endregion

	}

	#endregion


	#region Class: ServiceEngineerEventsProcess

	/// <exclude/>
	public class ServiceEngineerEventsProcess : ServiceEngineer_SLMITILServiceEventsProcess
	{

		public ServiceEngineerEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

