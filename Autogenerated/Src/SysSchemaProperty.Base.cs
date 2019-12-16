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

	#region Class: SysSchemaPropertySchema

	/// <exclude/>
	public class SysSchemaPropertySchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public SysSchemaPropertySchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public SysSchemaPropertySchema(SysSchemaPropertySchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public SysSchemaPropertySchema(SysSchemaPropertySchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("477e2c73-d48b-4a5d-9a46-d1ee851f1bde");
			RealUId = new Guid("477e2c73-d48b-4a5d-9a46-d1ee851f1bde");
			Name = "SysSchemaProperty";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("0903f9a6-9359-4827-87a5-bf44e36cd1a8")) == null) {
				Columns.Add(CreateNameColumn());
			}
			if (Columns.FindByUId(new Guid("c7c1ddcb-43be-4bdc-a986-3f87cc4e6f6d")) == null) {
				Columns.Add(CreateValueColumn());
			}
			if (Columns.FindByUId(new Guid("35e93a15-f107-4d17-a719-d0f8c6649531")) == null) {
				Columns.Add(CreateSysSchemaColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("0903f9a6-9359-4827-87a5-bf44e36cd1a8"),
				Name = @"Name",
				CreatedInSchemaUId = new Guid("477e2c73-d48b-4a5d-9a46-d1ee851f1bde"),
				ModifiedInSchemaUId = new Guid("477e2c73-d48b-4a5d-9a46-d1ee851f1bde"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			};
		}

		protected virtual EntitySchemaColumn CreateValueColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("LongText")) {
				UId = new Guid("c7c1ddcb-43be-4bdc-a986-3f87cc4e6f6d"),
				Name = @"Value",
				CreatedInSchemaUId = new Guid("477e2c73-d48b-4a5d-9a46-d1ee851f1bde"),
				ModifiedInSchemaUId = new Guid("477e2c73-d48b-4a5d-9a46-d1ee851f1bde"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			};
		}

		protected virtual EntitySchemaColumn CreateSysSchemaColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("35e93a15-f107-4d17-a719-d0f8c6649531"),
				Name = @"SysSchema",
				ReferenceSchemaUId = new Guid("6c7394db-06ff-4050-91ef-8278e21dce15"),
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("477e2c73-d48b-4a5d-9a46-d1ee851f1bde"),
				ModifiedInSchemaUId = new Guid("477e2c73-d48b-4a5d-9a46-d1ee851f1bde"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateSysSchemaPropertyEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateSysSchemaPropertyEventsProcessSchema() {
			var schema = new SysSchemaPropertyEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new SysSchemaProperty(userConnection){Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new SysSchemaProperty_BaseEventsProcess(userConnnection);
		}

		public override object Clone() {
			return new SysSchemaPropertySchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new SysSchemaPropertySchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("477e2c73-d48b-4a5d-9a46-d1ee851f1bde"));
		}

		#endregion

	}

	#endregion

	#region Class: SysSchemaProperty

	/// <summary>
	/// Schema property.
	/// </summary>
	public class SysSchemaProperty : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public SysSchemaProperty(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "SysSchemaProperty";
		}

		public SysSchemaProperty(SysSchemaProperty source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Name.
		/// </summary>
		public  string Name {
			get {
				return GetTypedColumnValue<string>("Name");
			}
			set {
				SetColumnValue("Name", value);
			}
		}

		/// <summary>
		/// Value.
		/// </summary>
		public  string Value {
			get {
				return GetTypedColumnValue<string>("Value");
			}
			set {
				SetColumnValue("Value", value);
			}
		}

		/// <exclude/>
		public  Guid SysSchemaId {
			get {
				return GetTypedColumnValue<Guid>("SysSchemaId");
			}
			set {
				SetColumnValue("SysSchemaId", value);
				_sysSchema = null;
			}
		}

		/// <exclude/>
		public  string SysSchemaCaption {
			get {
				return GetTypedColumnValue<string>("SysSchemaCaption");
			}
			set {
				SetColumnValue("SysSchemaCaption", value);
				if (_sysSchema != null) {
					_sysSchema.Caption = value;
				}
			}
		}

		private SysSchema _sysSchema;
		/// <summary>
		/// Schema.
		/// </summary>
		public  SysSchema SysSchema {
			get {
				return _sysSchema ??
					(_sysSchema = LookupColumnEntities.GetEntity("SysSchema") as SysSchema);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new SysSchemaProperty_BaseEventsProcess(UserConnection);
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
			return new SysSchemaProperty(this);
		}

		#endregion

	}

	#endregion

	#region Class: SysSchemaProperty_BaseEventsProcess

	/// <exclude/>
	public class SysSchemaProperty_BaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_LocalMessageEventsProcess<TEntity> where TEntity : SysSchemaProperty
	{

		public SysSchemaProperty_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SysSchemaProperty_BaseEventsProcess";
			SchemaUId = new Guid("477e2c73-d48b-4a5d-9a46-d1ee851f1bde");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private  Guid InternalSchemaUId {
			get {
				return new Guid("477e2c73-d48b-4a5d-9a46-d1ee851f1bde");
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

	#region Class: SysSchemaProperty_BaseEventsProcess

	/// <exclude/>
	public class SysSchemaProperty_BaseEventsProcess : SysSchemaProperty_BaseEventsProcess<SysSchemaProperty>
	{

		public SysSchemaProperty_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SysSchemaPropertyEventsProcessSchema

	/// <exclude/>
	public class SysSchemaPropertyEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public SysSchemaPropertyEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public SysSchemaPropertyEventsProcessSchema(SysSchemaPropertyEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "SysSchemaProperty_BaseEventsProcess";
			UId = new Guid("89f42716-cb8b-402f-a5c5-d6b1f8e466eb");
			CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2");
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
			return new SysSchemaPropertyEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("89f42716-cb8b-402f-a5c5-d6b1f8e466eb"));
		}

		#endregion

	}

	#endregion


	#region Class: SysSchemaPropertyEventsProcess

	/// <exclude/>
	public class SysSchemaPropertyEventsProcess : SysSchemaProperty_BaseEventsProcess
	{

		public SysSchemaPropertyEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

