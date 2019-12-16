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

	#region Class: DuplicatesReferenceSchema

	/// <exclude/>
	public class DuplicatesReferenceSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public DuplicatesReferenceSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public DuplicatesReferenceSchema(DuplicatesReferenceSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public DuplicatesReferenceSchema(DuplicatesReferenceSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f408bfb2-1d02-427a-b13e-c98248d23983");
			RealUId = new Guid("f408bfb2-1d02-427a-b13e-c98248d23983");
			Name = "DuplicatesReference";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("3a9b3622-1aee-4236-a76a-37f568d4d4b8");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("46750261-7ebc-43f3-99fe-60e4e55781f7")) == null) {
				Columns.Add(CreateObjectNameColumn());
			}
			if (Columns.FindByUId(new Guid("e04a931a-93d2-422f-9501-8dec37de14c5")) == null) {
				Columns.Add(CreateTableNameColumn());
			}
			if (Columns.FindByUId(new Guid("f2d78916-f6ec-4832-9d7f-b33191fa533a")) == null) {
				Columns.Add(CreateColumnNameColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateObjectNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("46750261-7ebc-43f3-99fe-60e4e55781f7"),
				Name = @"ObjectName",
				CreatedInSchemaUId = new Guid("f408bfb2-1d02-427a-b13e-c98248d23983"),
				ModifiedInSchemaUId = new Guid("f408bfb2-1d02-427a-b13e-c98248d23983"),
				CreatedInPackageId = new Guid("3a9b3622-1aee-4236-a76a-37f568d4d4b8")
			};
		}

		protected virtual EntitySchemaColumn CreateTableNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("e04a931a-93d2-422f-9501-8dec37de14c5"),
				Name = @"TableName",
				CreatedInSchemaUId = new Guid("f408bfb2-1d02-427a-b13e-c98248d23983"),
				ModifiedInSchemaUId = new Guid("f408bfb2-1d02-427a-b13e-c98248d23983"),
				CreatedInPackageId = new Guid("3a9b3622-1aee-4236-a76a-37f568d4d4b8")
			};
		}

		protected virtual EntitySchemaColumn CreateColumnNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("LongText")) {
				UId = new Guid("f2d78916-f6ec-4832-9d7f-b33191fa533a"),
				Name = @"ColumnName",
				CreatedInSchemaUId = new Guid("f408bfb2-1d02-427a-b13e-c98248d23983"),
				ModifiedInSchemaUId = new Guid("f408bfb2-1d02-427a-b13e-c98248d23983"),
				CreatedInPackageId = new Guid("3a9b3622-1aee-4236-a76a-37f568d4d4b8")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateDuplicatesReferenceEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateDuplicatesReferenceEventsProcessSchema() {
			var schema = new DuplicatesReferenceEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new DuplicatesReference(userConnection){Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new DuplicatesReference_DeduplicationEventsProcess(userConnnection);
		}

		public override object Clone() {
			return new DuplicatesReferenceSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new DuplicatesReferenceSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f408bfb2-1d02-427a-b13e-c98248d23983"));
		}

		#endregion

	}

	#endregion

	#region Class: DuplicatesReference

	/// <summary>
	/// Duplicates reference.
	/// </summary>
	public class DuplicatesReference : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public DuplicatesReference(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "DuplicatesReference";
		}

		public DuplicatesReference(DuplicatesReference source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Object name.
		/// </summary>
		public  string ObjectName {
			get {
				return GetTypedColumnValue<string>("ObjectName");
			}
			set {
				SetColumnValue("ObjectName", value);
			}
		}

		/// <summary>
		/// Table name.
		/// </summary>
		public  string TableName {
			get {
				return GetTypedColumnValue<string>("TableName");
			}
			set {
				SetColumnValue("TableName", value);
			}
		}

		/// <summary>
		/// Column name.
		/// </summary>
		public  string ColumnName {
			get {
				return GetTypedColumnValue<string>("ColumnName");
			}
			set {
				SetColumnValue("ColumnName", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new DuplicatesReference_DeduplicationEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Validating += (s, e) => ThrowEvent("DuplicatesReferenceValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new DuplicatesReference(this);
		}

		#endregion

	}

	#endregion

	#region Class: DuplicatesReference_DeduplicationEventsProcess

	/// <exclude/>
	public class DuplicatesReference_DeduplicationEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_LocalMessageEventsProcess<TEntity> where TEntity : DuplicatesReference
	{

		public DuplicatesReference_DeduplicationEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "DuplicatesReference_DeduplicationEventsProcess";
			SchemaUId = new Guid("f408bfb2-1d02-427a-b13e-c98248d23983");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private  Guid InternalSchemaUId {
			get {
				return new Guid("f408bfb2-1d02-427a-b13e-c98248d23983");
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

	#region Class: DuplicatesReference_DeduplicationEventsProcess

	/// <exclude/>
	public class DuplicatesReference_DeduplicationEventsProcess : DuplicatesReference_DeduplicationEventsProcess<DuplicatesReference>
	{

		public DuplicatesReference_DeduplicationEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: DuplicatesReferenceEventsProcessSchema

	/// <exclude/>
	public class DuplicatesReferenceEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public DuplicatesReferenceEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public DuplicatesReferenceEventsProcessSchema(DuplicatesReferenceEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "DuplicatesReference_DeduplicationEventsProcess";
			UId = new Guid("65660645-a70f-4e40-96d8-8c0c50068363");
			CreatedInPackageId = new Guid("3a9b3622-1aee-4236-a76a-37f568d4d4b8");
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
			return new DuplicatesReferenceEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("65660645-a70f-4e40-96d8-8c0c50068363"));
		}

		#endregion

	}

	#endregion


	#region Class: DuplicatesReferenceEventsProcess

	/// <exclude/>
	public class DuplicatesReferenceEventsProcess : DuplicatesReference_DeduplicationEventsProcess
	{

		public DuplicatesReferenceEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

