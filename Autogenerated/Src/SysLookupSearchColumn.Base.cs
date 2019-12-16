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

	#region Class: SysLookupSearchColumnSchema

	/// <exclude/>
	public class SysLookupSearchColumnSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public SysLookupSearchColumnSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public SysLookupSearchColumnSchema(SysLookupSearchColumnSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public SysLookupSearchColumnSchema(SysLookupSearchColumnSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("91353b2b-6f92-4ad2-bfa1-bda3b93bd690");
			RealUId = new Guid("91353b2b-6f92-4ad2-bfa1-bda3b93bd690");
			Name = "SysLookupSearchColumn";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("dfcb0d52-6d2f-499f-aedd-f189dd4db0dc")) == null) {
				Columns.Add(CreateSysLookupColumn());
			}
			if (Columns.FindByUId(new Guid("e7138fd6-89b1-4aab-9838-8f7b33e8633f")) == null) {
				Columns.Add(CreateMetaPathColumn());
			}
			if (Columns.FindByUId(new Guid("20e6666c-a813-49ed-b4ac-f927f9936d2b")) == null) {
				Columns.Add(CreatePositionColumn());
			}
			if (Columns.FindByUId(new Guid("f0ef986d-aa55-4583-a24e-9331b41526b5")) == null) {
				Columns.Add(CreateMetaCaptionColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateSysLookupColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("dfcb0d52-6d2f-499f-aedd-f189dd4db0dc"),
				Name = @"SysLookup",
				ReferenceSchemaUId = new Guid("aa3cc352-3095-43c9-ace8-6301f50a0a80"),
				IsCascade = true,
				CreatedInSchemaUId = new Guid("91353b2b-6f92-4ad2-bfa1-bda3b93bd690"),
				ModifiedInSchemaUId = new Guid("91353b2b-6f92-4ad2-bfa1-bda3b93bd690"),
				CreatedInPackageId = new Guid("c692daa9-de5e-4e96-afd3-e992ed86681c")
			};
		}

		protected virtual EntitySchemaColumn CreateMetaPathColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("e7138fd6-89b1-4aab-9838-8f7b33e8633f"),
				Name = @"MetaPath",
				CreatedInSchemaUId = new Guid("91353b2b-6f92-4ad2-bfa1-bda3b93bd690"),
				ModifiedInSchemaUId = new Guid("91353b2b-6f92-4ad2-bfa1-bda3b93bd690"),
				CreatedInPackageId = new Guid("c692daa9-de5e-4e96-afd3-e992ed86681c")
			};
		}

		protected virtual EntitySchemaColumn CreatePositionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("20e6666c-a813-49ed-b4ac-f927f9936d2b"),
				Name = @"Position",
				CreatedInSchemaUId = new Guid("91353b2b-6f92-4ad2-bfa1-bda3b93bd690"),
				ModifiedInSchemaUId = new Guid("91353b2b-6f92-4ad2-bfa1-bda3b93bd690"),
				CreatedInPackageId = new Guid("c692daa9-de5e-4e96-afd3-e992ed86681c")
			};
		}

		protected virtual EntitySchemaColumn CreateMetaCaptionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("f0ef986d-aa55-4583-a24e-9331b41526b5"),
				Name = @"MetaCaption",
				CreatedInSchemaUId = new Guid("91353b2b-6f92-4ad2-bfa1-bda3b93bd690"),
				ModifiedInSchemaUId = new Guid("91353b2b-6f92-4ad2-bfa1-bda3b93bd690"),
				CreatedInPackageId = new Guid("c692daa9-de5e-4e96-afd3-e992ed86681c")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateSysLookupSearchColumnEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateSysLookupSearchColumnEventsProcessSchema() {
			var schema = new SysLookupSearchColumnEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new SysLookupSearchColumn(userConnection){Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new SysLookupSearchColumn_BaseEventsProcess(userConnnection);
		}

		public override object Clone() {
			return new SysLookupSearchColumnSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new SysLookupSearchColumnSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("91353b2b-6f92-4ad2-bfa1-bda3b93bd690"));
		}

		#endregion

	}

	#endregion

	#region Class: SysLookupSearchColumn

	/// <summary>
	/// Columns for search in lookup.
	/// </summary>
	public class SysLookupSearchColumn : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public SysLookupSearchColumn(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "SysLookupSearchColumn";
		}

		public SysLookupSearchColumn(SysLookupSearchColumn source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public  Guid SysLookupId {
			get {
				return GetTypedColumnValue<Guid>("SysLookupId");
			}
			set {
				SetColumnValue("SysLookupId", value);
				_sysLookup = null;
			}
		}

		/// <exclude/>
		public  string SysLookupName {
			get {
				return GetTypedColumnValue<string>("SysLookupName");
			}
			set {
				SetColumnValue("SysLookupName", value);
				if (_sysLookup != null) {
					_sysLookup.Name = value;
				}
			}
		}

		private SysLookup _sysLookup;
		/// <summary>
		/// Lookup.
		/// </summary>
		public  SysLookup SysLookup {
			get {
				return _sysLookup ??
					(_sysLookup = LookupColumnEntities.GetEntity("SysLookup") as SysLookup);
			}
		}

		/// <summary>
		/// Column.
		/// </summary>
		public  string MetaPath {
			get {
				return GetTypedColumnValue<string>("MetaPath");
			}
			set {
				SetColumnValue("MetaPath", value);
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

		/// <summary>
		/// Column name.
		/// </summary>
		public  string MetaCaption {
			get {
				return GetTypedColumnValue<string>("MetaCaption");
			}
			set {
				SetColumnValue("MetaCaption", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new SysLookupSearchColumn_BaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleting += (s, e) => ThrowEvent("SysLookupSearchColumnDeleting", e);
			Inserted += (s, e) => ThrowEvent("SysLookupSearchColumnInserted", e);
			Inserting += (s, e) => ThrowEvent("SysLookupSearchColumnInserting", e);
			Saved += (s, e) => ThrowEvent("SysLookupSearchColumnSaved", e);
			Saving += (s, e) => ThrowEvent("SysLookupSearchColumnSaving", e);
			Validating += (s, e) => ThrowEvent("SysLookupSearchColumnValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SysLookupSearchColumn(this);
		}

		#endregion

	}

	#endregion

	#region Class: SysLookupSearchColumn_BaseEventsProcess

	/// <exclude/>
	public class SysLookupSearchColumn_BaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_LocalMessageEventsProcess<TEntity> where TEntity : SysLookupSearchColumn
	{

		public SysLookupSearchColumn_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SysLookupSearchColumn_BaseEventsProcess";
			SchemaUId = new Guid("91353b2b-6f92-4ad2-bfa1-bda3b93bd690");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private  Guid InternalSchemaUId {
			get {
				return new Guid("91353b2b-6f92-4ad2-bfa1-bda3b93bd690");
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

	#region Class: SysLookupSearchColumn_BaseEventsProcess

	/// <exclude/>
	public class SysLookupSearchColumn_BaseEventsProcess : SysLookupSearchColumn_BaseEventsProcess<SysLookupSearchColumn>
	{

		public SysLookupSearchColumn_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SysLookupSearchColumnEventsProcessSchema

	/// <exclude/>
	public class SysLookupSearchColumnEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public SysLookupSearchColumnEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public SysLookupSearchColumnEventsProcessSchema(SysLookupSearchColumnEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "SysLookupSearchColumn_BaseEventsProcess";
			UId = new Guid("6d4e9789-a76f-4cb8-bd94-bc7582e6616c");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = Guid.Empty;
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
			return new SysLookupSearchColumnEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("6d4e9789-a76f-4cb8-bd94-bc7582e6616c"));
		}

		#endregion

	}

	#endregion


	#region Class: SysLookupSearchColumnEventsProcess

	/// <exclude/>
	public class SysLookupSearchColumnEventsProcess : SysLookupSearchColumn_BaseEventsProcess
	{

		public SysLookupSearchColumnEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

