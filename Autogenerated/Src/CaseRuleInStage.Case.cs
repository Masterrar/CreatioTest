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

	#region Class: CaseRuleInStageSchema

	/// <exclude/>
	public class CaseRuleInStageSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public CaseRuleInStageSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public CaseRuleInStageSchema(CaseRuleInStageSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public CaseRuleInStageSchema(CaseRuleInStageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("306d12c2-6f43-4e30-9265-448e3fe36474");
			RealUId = new Guid("306d12c2-6f43-4e30-9265-448e3fe36474");
			Name = "CaseRuleInStage";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("a7919973-994c-4956-b846-530c9ef3b289");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("205da7bf-0ec7-4ed1-a68a-871deb13b77a")) == null) {
				Columns.Add(CreatePositionColumn());
			}
			if (Columns.FindByUId(new Guid("db00a017-b3c3-4508-b2f9-70d4ad74a6d2")) == null) {
				Columns.Add(CreateActiveColumn());
			}
			if (Columns.FindByUId(new Guid("77443fe5-f234-44f3-87b6-b1395e92173a")) == null) {
				Columns.Add(CreateCaseRuleHandlerColumn());
			}
			if (Columns.FindByUId(new Guid("cdff65f8-a47e-4e78-8ebf-8b8b0c32a437")) == null) {
				Columns.Add(CreateCaseNextStatusColumn());
			}
		}

		protected virtual EntitySchemaColumn CreatePositionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("205da7bf-0ec7-4ed1-a68a-871deb13b77a"),
				Name = @"Position",
				CreatedInSchemaUId = new Guid("306d12c2-6f43-4e30-9265-448e3fe36474"),
				ModifiedInSchemaUId = new Guid("306d12c2-6f43-4e30-9265-448e3fe36474"),
				CreatedInPackageId = new Guid("a7919973-994c-4956-b846-530c9ef3b289")
			};
		}

		protected virtual EntitySchemaColumn CreateActiveColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("db00a017-b3c3-4508-b2f9-70d4ad74a6d2"),
				Name = @"Active",
				CreatedInSchemaUId = new Guid("306d12c2-6f43-4e30-9265-448e3fe36474"),
				ModifiedInSchemaUId = new Guid("306d12c2-6f43-4e30-9265-448e3fe36474"),
				CreatedInPackageId = new Guid("a7919973-994c-4956-b846-530c9ef3b289")
			};
		}

		protected virtual EntitySchemaColumn CreateCaseRuleHandlerColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("77443fe5-f234-44f3-87b6-b1395e92173a"),
				Name = @"CaseRuleHandler",
				ReferenceSchemaUId = new Guid("6a2df2cb-bf84-4136-9edc-500f0b94a3d3"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("306d12c2-6f43-4e30-9265-448e3fe36474"),
				ModifiedInSchemaUId = new Guid("306d12c2-6f43-4e30-9265-448e3fe36474"),
				CreatedInPackageId = new Guid("a7919973-994c-4956-b846-530c9ef3b289")
			};
		}

		protected virtual EntitySchemaColumn CreateCaseNextStatusColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("cdff65f8-a47e-4e78-8ebf-8b8b0c32a437"),
				Name = @"CaseNextStatus",
				ReferenceSchemaUId = new Guid("e43e673d-fdd2-45d5-8672-a2bca1a14f00"),
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("306d12c2-6f43-4e30-9265-448e3fe36474"),
				ModifiedInSchemaUId = new Guid("306d12c2-6f43-4e30-9265-448e3fe36474"),
				CreatedInPackageId = new Guid("a7919973-994c-4956-b846-530c9ef3b289")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateCaseRuleInStageEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateCaseRuleInStageEventsProcessSchema() {
			var schema = new CaseRuleInStageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new CaseRuleInStage(userConnection){Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new CaseRuleInStage_CaseEventsProcess(userConnnection);
		}

		public override object Clone() {
			return new CaseRuleInStageSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new CaseRuleInStageSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("306d12c2-6f43-4e30-9265-448e3fe36474"));
		}

		#endregion

	}

	#endregion

	#region Class: CaseRuleInStage

	/// <summary>
	/// Case rule handler in stage.
	/// </summary>
	public class CaseRuleInStage : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public CaseRuleInStage(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "CaseRuleInStage";
		}

		public CaseRuleInStage(CaseRuleInStage source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Position.
		/// </summary>
		public  int Position {
			get {
				return GetTypedColumnValue<int>("Position");
			}
			set {
				SetColumnValue("Position", value);
			}
		}

		/// <summary>
		/// Active.
		/// </summary>
		public  bool Active {
			get {
				return GetTypedColumnValue<bool>("Active");
			}
			set {
				SetColumnValue("Active", value);
			}
		}

		/// <exclude/>
		public  Guid CaseRuleHandlerId {
			get {
				return GetTypedColumnValue<Guid>("CaseRuleHandlerId");
			}
			set {
				SetColumnValue("CaseRuleHandlerId", value);
				_caseRuleHandler = null;
			}
		}

		/// <exclude/>
		public  string CaseRuleHandlerName {
			get {
				return GetTypedColumnValue<string>("CaseRuleHandlerName");
			}
			set {
				SetColumnValue("CaseRuleHandlerName", value);
				if (_caseRuleHandler != null) {
					_caseRuleHandler.Name = value;
				}
			}
		}

		private CaseRuleHandler _caseRuleHandler;
		/// <summary>
		/// Case rule handler.
		/// </summary>
		public  CaseRuleHandler CaseRuleHandler {
			get {
				return _caseRuleHandler ??
					(_caseRuleHandler = LookupColumnEntities.GetEntity("CaseRuleHandler") as CaseRuleHandler);
			}
		}

		/// <exclude/>
		public  Guid CaseNextStatusId {
			get {
				return GetTypedColumnValue<Guid>("CaseNextStatusId");
			}
			set {
				SetColumnValue("CaseNextStatusId", value);
				_caseNextStatus = null;
			}
		}

		/// <exclude/>
		public  string CaseNextStatusName {
			get {
				return GetTypedColumnValue<string>("CaseNextStatusName");
			}
			set {
				SetColumnValue("CaseNextStatusName", value);
				if (_caseNextStatus != null) {
					_caseNextStatus.Name = value;
				}
			}
		}

		private CaseNextStatus _caseNextStatus;
		/// <summary>
		/// Case next status.
		/// </summary>
		public  CaseNextStatus CaseNextStatus {
			get {
				return _caseNextStatus ??
					(_caseNextStatus = LookupColumnEntities.GetEntity("CaseNextStatus") as CaseNextStatus);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new CaseRuleInStage_CaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Validating += (s, e) => ThrowEvent("CaseRuleInStageValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new CaseRuleInStage(this);
		}

		#endregion

	}

	#endregion

	#region Class: CaseRuleInStage_CaseEventsProcess

	/// <exclude/>
	public class CaseRuleInStage_CaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_LocalMessageEventsProcess<TEntity> where TEntity : CaseRuleInStage
	{

		public CaseRuleInStage_CaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "CaseRuleInStage_CaseEventsProcess";
			SchemaUId = new Guid("306d12c2-6f43-4e30-9265-448e3fe36474");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private  Guid InternalSchemaUId {
			get {
				return new Guid("306d12c2-6f43-4e30-9265-448e3fe36474");
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

	#region Class: CaseRuleInStage_CaseEventsProcess

	/// <exclude/>
	public class CaseRuleInStage_CaseEventsProcess : CaseRuleInStage_CaseEventsProcess<CaseRuleInStage>
	{

		public CaseRuleInStage_CaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: CaseRuleInStageEventsProcessSchema

	/// <exclude/>
	public class CaseRuleInStageEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public CaseRuleInStageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public CaseRuleInStageEventsProcessSchema(CaseRuleInStageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "CaseRuleInStage_CaseEventsProcess";
			UId = new Guid("4452f610-09a2-4940-a8bb-3f7f54636929");
			CreatedInPackageId = new Guid("a7919973-994c-4956-b846-530c9ef3b289");
			CreatedInSchemaUId = Guid.Empty;
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
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new CaseRuleInStageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("4452f610-09a2-4940-a8bb-3f7f54636929"));
		}

		#endregion

	}

	#endregion


	#region Class: CaseRuleInStageEventsProcess

	/// <exclude/>
	public class CaseRuleInStageEventsProcess : CaseRuleInStage_CaseEventsProcess
	{

		public CaseRuleInStageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

