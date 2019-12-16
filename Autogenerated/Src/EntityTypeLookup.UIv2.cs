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

	#region Class: EntityTypeLookupSchema

	/// <exclude/>
	public class EntityTypeLookupSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public EntityTypeLookupSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public EntityTypeLookupSchema(EntityTypeLookupSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public EntityTypeLookupSchema(EntityTypeLookupSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("af2a225a-93db-4552-b08c-d134a5e9361a");
			RealUId = new Guid("af2a225a-93db-4552-b08c-d134a5e9361a");
			Name = "EntityTypeLookup";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("781ea0d0-6d7f-4b9d-8a06-13b9d6d7e7c2");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("b5c25dea-5ba9-4416-a7eb-4822982d5f6b")) == null) {
				Columns.Add(CreateEntityNameColumn());
			}
			if (Columns.FindByUId(new Guid("bb476184-47a2-4679-960f-71dce2f1fa15")) == null) {
				Columns.Add(CreateMenuItemCaptionColumn());
			}
			if (Columns.FindByUId(new Guid("65234ad8-7150-492e-aeee-7601cb33ea8e")) == null) {
				Columns.Add(CreateSysSettingImageColumn());
			}
			if (Columns.FindByUId(new Guid("80919e0b-9b0f-45cf-aed5-a37adf4fc53f")) == null) {
				Columns.Add(CreatePositionColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateEntityNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("b5c25dea-5ba9-4416-a7eb-4822982d5f6b"),
				Name = @"EntityName",
				CreatedInSchemaUId = new Guid("af2a225a-93db-4552-b08c-d134a5e9361a"),
				ModifiedInSchemaUId = new Guid("af2a225a-93db-4552-b08c-d134a5e9361a"),
				CreatedInPackageId = new Guid("781ea0d0-6d7f-4b9d-8a06-13b9d6d7e7c2")
			};
		}

		protected virtual EntitySchemaColumn CreateMenuItemCaptionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("bb476184-47a2-4679-960f-71dce2f1fa15"),
				Name = @"MenuItemCaption",
				CreatedInSchemaUId = new Guid("af2a225a-93db-4552-b08c-d134a5e9361a"),
				ModifiedInSchemaUId = new Guid("af2a225a-93db-4552-b08c-d134a5e9361a"),
				CreatedInPackageId = new Guid("781ea0d0-6d7f-4b9d-8a06-13b9d6d7e7c2"),
				IsLocalizable = true
			};
		}

		protected virtual EntitySchemaColumn CreateSysSettingImageColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("65234ad8-7150-492e-aeee-7601cb33ea8e"),
				Name = @"SysSettingImage",
				CreatedInSchemaUId = new Guid("af2a225a-93db-4552-b08c-d134a5e9361a"),
				ModifiedInSchemaUId = new Guid("af2a225a-93db-4552-b08c-d134a5e9361a"),
				CreatedInPackageId = new Guid("781ea0d0-6d7f-4b9d-8a06-13b9d6d7e7c2")
			};
		}

		protected virtual EntitySchemaColumn CreatePositionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("80919e0b-9b0f-45cf-aed5-a37adf4fc53f"),
				Name = @"Position",
				CreatedInSchemaUId = new Guid("af2a225a-93db-4552-b08c-d134a5e9361a"),
				ModifiedInSchemaUId = new Guid("af2a225a-93db-4552-b08c-d134a5e9361a"),
				CreatedInPackageId = new Guid("781ea0d0-6d7f-4b9d-8a06-13b9d6d7e7c2")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateEntityTypeLookupEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateEntityTypeLookupEventsProcessSchema() {
			var schema = new EntityTypeLookupEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new EntityTypeLookup(userConnection){Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new EntityTypeLookup_UIv2EventsProcess(userConnnection);
		}

		public override object Clone() {
			return new EntityTypeLookupSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new EntityTypeLookupSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("af2a225a-93db-4552-b08c-d134a5e9361a"));
		}

		#endregion

	}

	#endregion

	#region Class: EntityTypeLookup

	/// <summary>
	/// Attachment detail lookup.
	/// </summary>
	public class EntityTypeLookup : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public EntityTypeLookup(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "EntityTypeLookup";
		}

		public EntityTypeLookup(EntityTypeLookup source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Entity name.
		/// </summary>
		public  string EntityName {
			get {
				return GetTypedColumnValue<string>("EntityName");
			}
			set {
				SetColumnValue("EntityName", value);
			}
		}

		/// <summary>
		/// Menu item.
		/// </summary>
		public  string MenuItemCaption {
			get {
				return GetTypedColumnValue<string>("MenuItemCaption");
			}
			set {
				SetColumnValue("MenuItemCaption", value);
			}
		}

		/// <summary>
		/// Name of system setting with image.
		/// </summary>
		public  string SysSettingImage {
			get {
				return GetTypedColumnValue<string>("SysSettingImage");
			}
			set {
				SetColumnValue("SysSettingImage", value);
			}
		}

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

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new EntityTypeLookup_UIv2EventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Validating += (s, e) => ThrowEvent("EntityTypeLookupValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new EntityTypeLookup(this);
		}

		#endregion

	}

	#endregion

	#region Class: EntityTypeLookup_UIv2EventsProcess

	/// <exclude/>
	public class EntityTypeLookup_UIv2EventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_LocalMessageEventsProcess<TEntity> where TEntity : EntityTypeLookup
	{

		public EntityTypeLookup_UIv2EventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "EntityTypeLookup_UIv2EventsProcess";
			SchemaUId = new Guid("af2a225a-93db-4552-b08c-d134a5e9361a");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private  Guid InternalSchemaUId {
			get {
				return new Guid("af2a225a-93db-4552-b08c-d134a5e9361a");
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

	#region Class: EntityTypeLookup_UIv2EventsProcess

	/// <exclude/>
	public class EntityTypeLookup_UIv2EventsProcess : EntityTypeLookup_UIv2EventsProcess<EntityTypeLookup>
	{

		public EntityTypeLookup_UIv2EventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: EntityTypeLookupEventsProcessSchema

	/// <exclude/>
	public class EntityTypeLookupEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public EntityTypeLookupEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public EntityTypeLookupEventsProcessSchema(EntityTypeLookupEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "EntityTypeLookup_UIv2EventsProcess";
			UId = new Guid("e1f9b676-3ddc-4d5e-afac-de8934d3dcf1");
			CreatedInPackageId = new Guid("781ea0d0-6d7f-4b9d-8a06-13b9d6d7e7c2");
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
			return new EntityTypeLookupEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e1f9b676-3ddc-4d5e-afac-de8934d3dcf1"));
		}

		#endregion

	}

	#endregion


	#region Class: EntityTypeLookupEventsProcess

	/// <exclude/>
	public class EntityTypeLookupEventsProcess : EntityTypeLookup_UIv2EventsProcess
	{

		public EntityTypeLookupEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

