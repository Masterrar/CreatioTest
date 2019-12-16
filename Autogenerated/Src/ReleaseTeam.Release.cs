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

	#region Class: ReleaseTeamSchema

	/// <exclude/>
	public class ReleaseTeamSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public ReleaseTeamSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public ReleaseTeamSchema(ReleaseTeamSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public ReleaseTeamSchema(ReleaseTeamSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e0cf8e90-5727-48de-82f7-1eb15ecbadd0");
			RealUId = new Guid("e0cf8e90-5727-48de-82f7-1eb15ecbadd0");
			Name = "ReleaseTeam";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("485eb89f-9ee2-4473-81ec-293d7fe1a9d3");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("f7d0868f-17c4-48bc-87b1-2130cf66a9bf")) == null) {
				Columns.Add(CreateStatusColumn());
			}
			if (Columns.FindByUId(new Guid("0c7c7aa6-9948-460f-8cdc-8427669f0ab5")) == null) {
				Columns.Add(CreateResponsibleColumn());
			}
			if (Columns.FindByUId(new Guid("38cdfeea-ca86-4489-8a72-52fa3bc3f70b")) == null) {
				Columns.Add(CreateReleaseColumn());
			}
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.ModifiedInSchemaUId = new Guid("e0cf8e90-5727-48de-82f7-1eb15ecbadd0");
			column.CreatedInPackageId = new Guid("485eb89f-9ee2-4473-81ec-293d7fe1a9d3");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.ModifiedInSchemaUId = new Guid("e0cf8e90-5727-48de-82f7-1eb15ecbadd0");
			column.CreatedInPackageId = new Guid("485eb89f-9ee2-4473-81ec-293d7fe1a9d3");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.ModifiedInSchemaUId = new Guid("e0cf8e90-5727-48de-82f7-1eb15ecbadd0");
			column.CreatedInPackageId = new Guid("485eb89f-9ee2-4473-81ec-293d7fe1a9d3");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.ModifiedInSchemaUId = new Guid("e0cf8e90-5727-48de-82f7-1eb15ecbadd0");
			column.CreatedInPackageId = new Guid("485eb89f-9ee2-4473-81ec-293d7fe1a9d3");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.ModifiedInSchemaUId = new Guid("e0cf8e90-5727-48de-82f7-1eb15ecbadd0");
			column.CreatedInPackageId = new Guid("485eb89f-9ee2-4473-81ec-293d7fe1a9d3");
			return column;
		}

		protected override EntitySchemaColumn CreateProcessListenersColumn() {
			EntitySchemaColumn column = base.CreateProcessListenersColumn();
			column.ModifiedInSchemaUId = new Guid("e0cf8e90-5727-48de-82f7-1eb15ecbadd0");
			column.CreatedInPackageId = new Guid("485eb89f-9ee2-4473-81ec-293d7fe1a9d3");
			return column;
		}

		protected virtual EntitySchemaColumn CreateStatusColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("f7d0868f-17c4-48bc-87b1-2130cf66a9bf"),
				Name = @"Status",
				ReferenceSchemaUId = new Guid("597097ce-243d-49d2-90de-14bdf30391fb"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("e0cf8e90-5727-48de-82f7-1eb15ecbadd0"),
				ModifiedInSchemaUId = new Guid("e0cf8e90-5727-48de-82f7-1eb15ecbadd0"),
				CreatedInPackageId = new Guid("485eb89f-9ee2-4473-81ec-293d7fe1a9d3"),
				IsSimpleLookup = true
			};
		}

		protected virtual EntitySchemaColumn CreateResponsibleColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("0c7c7aa6-9948-460f-8cdc-8427669f0ab5"),
				Name = @"Responsible",
				ReferenceSchemaUId = new Guid("84f44b9a-4bc3-4cbf-a1a8-cec02c1c029c"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("e0cf8e90-5727-48de-82f7-1eb15ecbadd0"),
				ModifiedInSchemaUId = new Guid("e0cf8e90-5727-48de-82f7-1eb15ecbadd0"),
				CreatedInPackageId = new Guid("485eb89f-9ee2-4473-81ec-293d7fe1a9d3")
			};
		}

		protected virtual EntitySchemaColumn CreateReleaseColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("38cdfeea-ca86-4489-8a72-52fa3bc3f70b"),
				Name = @"Release",
				ReferenceSchemaUId = new Guid("0bf3a274-e5da-4fc7-94c4-3ae233598714"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("e0cf8e90-5727-48de-82f7-1eb15ecbadd0"),
				ModifiedInSchemaUId = new Guid("e0cf8e90-5727-48de-82f7-1eb15ecbadd0"),
				CreatedInPackageId = new Guid("485eb89f-9ee2-4473-81ec-293d7fe1a9d3")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateReleaseTeamEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateReleaseTeamEventsProcessSchema() {
			var schema = new ReleaseTeamEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new ReleaseTeam(userConnection){Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new ReleaseTeam_ReleaseEventsProcess(userConnnection);
		}

		public override object Clone() {
			return new ReleaseTeamSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new ReleaseTeamSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e0cf8e90-5727-48de-82f7-1eb15ecbadd0"));
		}

		#endregion

	}

	#endregion

	#region Class: ReleaseTeam

	/// <summary>
	/// Team.
	/// </summary>
	public class ReleaseTeam : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public ReleaseTeam(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "ReleaseTeam";
		}

		public ReleaseTeam(ReleaseTeam source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public  Guid StatusId {
			get {
				return GetTypedColumnValue<Guid>("StatusId");
			}
			set {
				SetColumnValue("StatusId", value);
				_status = null;
			}
		}

		/// <exclude/>
		public  string StatusName {
			get {
				return GetTypedColumnValue<string>("StatusName");
			}
			set {
				SetColumnValue("StatusName", value);
				if (_status != null) {
					_status.Name = value;
				}
			}
		}

		private ReleaseStatus _status;
		/// <summary>
		/// Stage.
		/// </summary>
		public  ReleaseStatus Status {
			get {
				return _status ??
					(_status = LookupColumnEntities.GetEntity("Status") as ReleaseStatus);
			}
		}

		/// <exclude/>
		public  Guid ResponsibleId {
			get {
				return GetTypedColumnValue<Guid>("ResponsibleId");
			}
			set {
				SetColumnValue("ResponsibleId", value);
				_responsible = null;
			}
		}

		/// <exclude/>
		public  string ResponsibleName {
			get {
				return GetTypedColumnValue<string>("ResponsibleName");
			}
			set {
				SetColumnValue("ResponsibleName", value);
				if (_responsible != null) {
					_responsible.Name = value;
				}
			}
		}

		private SysAdminUnit _responsible;
		/// <summary>
		/// Assignee / Assigned team.
		/// </summary>
		public  SysAdminUnit Responsible {
			get {
				return _responsible ??
					(_responsible = LookupColumnEntities.GetEntity("Responsible") as SysAdminUnit);
			}
		}

		/// <exclude/>
		public  Guid ReleaseId {
			get {
				return GetTypedColumnValue<Guid>("ReleaseId");
			}
			set {
				SetColumnValue("ReleaseId", value);
				_release = null;
			}
		}

		/// <exclude/>
		public  string ReleaseNumber {
			get {
				return GetTypedColumnValue<string>("ReleaseNumber");
			}
			set {
				SetColumnValue("ReleaseNumber", value);
				if (_release != null) {
					_release.Number = value;
				}
			}
		}

		private Release _release;
		/// <summary>
		/// Release.
		/// </summary>
		public  Release Release {
			get {
				return _release ??
					(_release = LookupColumnEntities.GetEntity("Release") as Release);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new ReleaseTeam_ReleaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Validating += (s, e) => ThrowEvent("ReleaseTeamValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new ReleaseTeam(this);
		}

		#endregion

	}

	#endregion

	#region Class: ReleaseTeam_ReleaseEventsProcess

	/// <exclude/>
	public class ReleaseTeam_ReleaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_LocalMessageEventsProcess<TEntity> where TEntity : ReleaseTeam
	{

		public ReleaseTeam_ReleaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ReleaseTeam_ReleaseEventsProcess";
			SchemaUId = new Guid("e0cf8e90-5727-48de-82f7-1eb15ecbadd0");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private  Guid InternalSchemaUId {
			get {
				return new Guid("e0cf8e90-5727-48de-82f7-1eb15ecbadd0");
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

	#region Class: ReleaseTeam_ReleaseEventsProcess

	/// <exclude/>
	public class ReleaseTeam_ReleaseEventsProcess : ReleaseTeam_ReleaseEventsProcess<ReleaseTeam>
	{

		public ReleaseTeam_ReleaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: ReleaseTeamEventsProcessSchema

	/// <exclude/>
	public class ReleaseTeamEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public ReleaseTeamEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public ReleaseTeamEventsProcessSchema(ReleaseTeamEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "ReleaseTeam_ReleaseEventsProcess";
			UId = new Guid("19068e49-23cd-4f20-801f-8b5c3c03ef61");
			CreatedInPackageId = new Guid("485eb89f-9ee2-4473-81ec-293d7fe1a9d3");
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
				CreatedInPackageId = new Guid("485eb89f-9ee2-4473-81ec-293d7fe1a9d3")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("cde525cf-d220-4d2a-b963-e55254c639fc"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("485eb89f-9ee2-4473-81ec-293d7fe1a9d3")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5c9c82c6-ba6d-4a57-9a14-87fe8faa4ebb"),
				Name = "Terrasoft.Core.DB",
				Alias = "",
				CreatedInPackageId = new Guid("485eb89f-9ee2-4473-81ec-293d7fe1a9d3")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7821de68-c82b-4917-a6cd-add2adfbe400"),
				Name = "Terrasoft.Common",
				Alias = "",
				CreatedInPackageId = new Guid("485eb89f-9ee2-4473-81ec-293d7fe1a9d3")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d67de76f-9cbc-4bfc-babb-6f65cb89b973"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("485eb89f-9ee2-4473-81ec-293d7fe1a9d3")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("74160d3b-65e3-4694-b554-089f2d980e54"),
				Name = "Newtonsoft.Json",
				Alias = "",
				CreatedInPackageId = new Guid("485eb89f-9ee2-4473-81ec-293d7fe1a9d3")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e401300a-9f16-40c2-9788-cf310ae9d1c5"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("485eb89f-9ee2-4473-81ec-293d7fe1a9d3")
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
			return new ReleaseTeamEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("19068e49-23cd-4f20-801f-8b5c3c03ef61"));
		}

		#endregion

	}

	#endregion


	#region Class: ReleaseTeamEventsProcess

	/// <exclude/>
	public class ReleaseTeamEventsProcess : ReleaseTeam_ReleaseEventsProcess
	{

		public ReleaseTeamEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

