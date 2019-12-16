﻿namespace Terrasoft.Configuration
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

	#region Class: SysFuncRoleInOrgRoleSchema

	/// <exclude/>
	public class SysFuncRoleInOrgRoleSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public SysFuncRoleInOrgRoleSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public SysFuncRoleInOrgRoleSchema(SysFuncRoleInOrgRoleSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public SysFuncRoleInOrgRoleSchema(SysFuncRoleInOrgRoleSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("d9bf8007-9380-4ef1-ac05-a27b9b44fc63");
			RealUId = new Guid("d9bf8007-9380-4ef1-ac05-a27b9b44fc63");
			Name = "SysFuncRoleInOrgRole";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("2e284f91-c9c3-4061-a0d7-d57d0e7e0e3f");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("a413f58f-4d46-4bb9-9824-b723c40af619")) == null) {
				Columns.Add(CreateOrgRoleColumn());
			}
			if (Columns.FindByUId(new Guid("99361ab4-386d-4c13-a0f4-19253b9f207f")) == null) {
				Columns.Add(CreateFuncRoleColumn());
			}
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.ModifiedInSchemaUId = new Guid("d9bf8007-9380-4ef1-ac05-a27b9b44fc63");
			column.CreatedInPackageId = new Guid("2e284f91-c9c3-4061-a0d7-d57d0e7e0e3f");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.ModifiedInSchemaUId = new Guid("d9bf8007-9380-4ef1-ac05-a27b9b44fc63");
			column.CreatedInPackageId = new Guid("2e284f91-c9c3-4061-a0d7-d57d0e7e0e3f");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.ModifiedInSchemaUId = new Guid("d9bf8007-9380-4ef1-ac05-a27b9b44fc63");
			column.CreatedInPackageId = new Guid("2e284f91-c9c3-4061-a0d7-d57d0e7e0e3f");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.ModifiedInSchemaUId = new Guid("d9bf8007-9380-4ef1-ac05-a27b9b44fc63");
			column.CreatedInPackageId = new Guid("2e284f91-c9c3-4061-a0d7-d57d0e7e0e3f");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.ModifiedInSchemaUId = new Guid("d9bf8007-9380-4ef1-ac05-a27b9b44fc63");
			column.CreatedInPackageId = new Guid("2e284f91-c9c3-4061-a0d7-d57d0e7e0e3f");
			return column;
		}

		protected override EntitySchemaColumn CreateProcessListenersColumn() {
			EntitySchemaColumn column = base.CreateProcessListenersColumn();
			column.ModifiedInSchemaUId = new Guid("d9bf8007-9380-4ef1-ac05-a27b9b44fc63");
			column.CreatedInPackageId = new Guid("2e284f91-c9c3-4061-a0d7-d57d0e7e0e3f");
			return column;
		}

		protected virtual EntitySchemaColumn CreateOrgRoleColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("a413f58f-4d46-4bb9-9824-b723c40af619"),
				Name = @"OrgRole",
				ReferenceSchemaUId = new Guid("84f44b9a-4bc3-4cbf-a1a8-cec02c1c029c"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("d9bf8007-9380-4ef1-ac05-a27b9b44fc63"),
				ModifiedInSchemaUId = new Guid("d9bf8007-9380-4ef1-ac05-a27b9b44fc63"),
				CreatedInPackageId = new Guid("2e284f91-c9c3-4061-a0d7-d57d0e7e0e3f")
			};
		}

		protected virtual EntitySchemaColumn CreateFuncRoleColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("99361ab4-386d-4c13-a0f4-19253b9f207f"),
				Name = @"FuncRole",
				ReferenceSchemaUId = new Guid("84f44b9a-4bc3-4cbf-a1a8-cec02c1c029c"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("d9bf8007-9380-4ef1-ac05-a27b9b44fc63"),
				ModifiedInSchemaUId = new Guid("d9bf8007-9380-4ef1-ac05-a27b9b44fc63"),
				CreatedInPackageId = new Guid("2e284f91-c9c3-4061-a0d7-d57d0e7e0e3f")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateSysFuncRoleInOrgRoleEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateSysFuncRoleInOrgRoleEventsProcessSchema() {
			var schema = new SysFuncRoleInOrgRoleEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new SysFuncRoleInOrgRole(userConnection){Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new SysFuncRoleInOrgRole_UIv2EventsProcess(userConnnection);
		}

		public override object Clone() {
			return new SysFuncRoleInOrgRoleSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new SysFuncRoleInOrgRoleSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d9bf8007-9380-4ef1-ac05-a27b9b44fc63"));
		}

		#endregion

	}

	#endregion

	#region Class: SysFuncRoleInOrgRole

	/// <summary>
	/// Functional role in organizational role.
	/// </summary>
	public class SysFuncRoleInOrgRole : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public SysFuncRoleInOrgRole(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "SysFuncRoleInOrgRole";
		}

		public SysFuncRoleInOrgRole(SysFuncRoleInOrgRole source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public  Guid OrgRoleId {
			get {
				return GetTypedColumnValue<Guid>("OrgRoleId");
			}
			set {
				SetColumnValue("OrgRoleId", value);
				_orgRole = null;
			}
		}

		/// <exclude/>
		public  string OrgRoleName {
			get {
				return GetTypedColumnValue<string>("OrgRoleName");
			}
			set {
				SetColumnValue("OrgRoleName", value);
				if (_orgRole != null) {
					_orgRole.Name = value;
				}
			}
		}

		private SysAdminUnit _orgRole;
		/// <summary>
		/// Organizational role.
		/// </summary>
		public  SysAdminUnit OrgRole {
			get {
				return _orgRole ??
					(_orgRole = LookupColumnEntities.GetEntity("OrgRole") as SysAdminUnit);
			}
		}

		/// <exclude/>
		public  Guid FuncRoleId {
			get {
				return GetTypedColumnValue<Guid>("FuncRoleId");
			}
			set {
				SetColumnValue("FuncRoleId", value);
				_funcRole = null;
			}
		}

		/// <exclude/>
		public  string FuncRoleName {
			get {
				return GetTypedColumnValue<string>("FuncRoleName");
			}
			set {
				SetColumnValue("FuncRoleName", value);
				if (_funcRole != null) {
					_funcRole.Name = value;
				}
			}
		}

		private SysAdminUnit _funcRole;
		/// <summary>
		/// Functional role.
		/// </summary>
		public  SysAdminUnit FuncRole {
			get {
				return _funcRole ??
					(_funcRole = LookupColumnEntities.GetEntity("FuncRole") as SysAdminUnit);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new SysFuncRoleInOrgRole_UIv2EventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Validating += (s, e) => ThrowEvent("SysFuncRoleInOrgRoleValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SysFuncRoleInOrgRole(this);
		}

		#endregion

	}

	#endregion

	#region Class: SysFuncRoleInOrgRole_UIv2EventsProcess

	/// <exclude/>
	public class SysFuncRoleInOrgRole_UIv2EventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_LocalMessageEventsProcess<TEntity> where TEntity : SysFuncRoleInOrgRole
	{

		public SysFuncRoleInOrgRole_UIv2EventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SysFuncRoleInOrgRole_UIv2EventsProcess";
			SchemaUId = new Guid("d9bf8007-9380-4ef1-ac05-a27b9b44fc63");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private  Guid InternalSchemaUId {
			get {
				return new Guid("d9bf8007-9380-4ef1-ac05-a27b9b44fc63");
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

	#region Class: SysFuncRoleInOrgRole_UIv2EventsProcess

	/// <exclude/>
	public class SysFuncRoleInOrgRole_UIv2EventsProcess : SysFuncRoleInOrgRole_UIv2EventsProcess<SysFuncRoleInOrgRole>
	{

		public SysFuncRoleInOrgRole_UIv2EventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SysFuncRoleInOrgRoleEventsProcessSchema

	/// <exclude/>
	public class SysFuncRoleInOrgRoleEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public SysFuncRoleInOrgRoleEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public SysFuncRoleInOrgRoleEventsProcessSchema(SysFuncRoleInOrgRoleEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "SysFuncRoleInOrgRole_UIv2EventsProcess";
			UId = new Guid("52ada749-c30b-459c-b76c-0e50afe59509");
			CreatedInPackageId = new Guid("2e284f91-c9c3-4061-a0d7-d57d0e7e0e3f");
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
				CreatedInPackageId = new Guid("2e284f91-c9c3-4061-a0d7-d57d0e7e0e3f")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("cde525cf-d220-4d2a-b963-e55254c639fc"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("2e284f91-c9c3-4061-a0d7-d57d0e7e0e3f")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5c9c82c6-ba6d-4a57-9a14-87fe8faa4ebb"),
				Name = "Terrasoft.Core.DB",
				Alias = "",
				CreatedInPackageId = new Guid("2e284f91-c9c3-4061-a0d7-d57d0e7e0e3f")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7821de68-c82b-4917-a6cd-add2adfbe400"),
				Name = "Terrasoft.Common",
				Alias = "",
				CreatedInPackageId = new Guid("2e284f91-c9c3-4061-a0d7-d57d0e7e0e3f")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d67de76f-9cbc-4bfc-babb-6f65cb89b973"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("2e284f91-c9c3-4061-a0d7-d57d0e7e0e3f")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("74160d3b-65e3-4694-b554-089f2d980e54"),
				Name = "Newtonsoft.Json",
				Alias = "",
				CreatedInPackageId = new Guid("2e284f91-c9c3-4061-a0d7-d57d0e7e0e3f")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e401300a-9f16-40c2-9788-cf310ae9d1c5"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("2e284f91-c9c3-4061-a0d7-d57d0e7e0e3f")
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
			return new SysFuncRoleInOrgRoleEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("52ada749-c30b-459c-b76c-0e50afe59509"));
		}

		#endregion

	}

	#endregion


	#region Class: SysFuncRoleInOrgRoleEventsProcess

	/// <exclude/>
	public class SysFuncRoleInOrgRoleEventsProcess : SysFuncRoleInOrgRole_UIv2EventsProcess
	{

		public SysFuncRoleInOrgRoleEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

