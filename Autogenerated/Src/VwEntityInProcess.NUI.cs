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

	#region Class: VwEntityInProcessSchema

	/// <exclude/>
	public class VwEntityInProcessSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public VwEntityInProcessSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public VwEntityInProcessSchema(VwEntityInProcessSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public VwEntityInProcessSchema(VwEntityInProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("0195d99c-c259-45e1-b27f-d2145a8838e2");
			RealUId = new Guid("0195d99c-c259-45e1-b27f-d2145a8838e2");
			Name = "VwEntityInProcess";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("edbaf284-b37c-4101-84cb-76a44645334f");
			IsDBView = true;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("573faf8d-eac5-46bd-a14e-bfa97ad3578e")) == null) {
				Columns.Add(CreateProcessCaptionColumn());
			}
			if (Columns.FindByUId(new Guid("1005cc47-4026-4088-8409-7c2b64ef34a6")) == null) {
				Columns.Add(CreateProcessDescriptionColumn());
			}
			if (Columns.FindByUId(new Guid("fea5dcb2-0e6a-4d97-bd0d-0a92a6fb359d")) == null) {
				Columns.Add(CreateRecordIdColumn());
			}
			if (Columns.FindByUId(new Guid("fed365ce-80f0-4ce1-9490-4db37237fcb8")) == null) {
				Columns.Add(CreateEntitySchemaNameColumn());
			}
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.ReferenceSchemaUId = new Guid("a195aa99-8c5b-47e0-a9a6-9bac0ddd5bd0");
			column.DefValue = new EntitySchemaColumnDef() {
				Source = EntitySchemaColumnDefSource.None,
				ValueSource = @""
			};
			column.ModifiedInSchemaUId = new Guid("0195d99c-c259-45e1-b27f-d2145a8838e2");
			return column;
		}

		protected virtual EntitySchemaColumn CreateProcessCaptionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("573faf8d-eac5-46bd-a14e-bfa97ad3578e"),
				Name = @"ProcessCaption",
				CreatedInSchemaUId = new Guid("0195d99c-c259-45e1-b27f-d2145a8838e2"),
				ModifiedInSchemaUId = new Guid("0195d99c-c259-45e1-b27f-d2145a8838e2"),
				CreatedInPackageId = new Guid("edbaf284-b37c-4101-84cb-76a44645334f")
			};
		}

		protected virtual EntitySchemaColumn CreateProcessDescriptionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("1005cc47-4026-4088-8409-7c2b64ef34a6"),
				Name = @"ProcessDescription",
				CreatedInSchemaUId = new Guid("0195d99c-c259-45e1-b27f-d2145a8838e2"),
				ModifiedInSchemaUId = new Guid("0195d99c-c259-45e1-b27f-d2145a8838e2"),
				CreatedInPackageId = new Guid("edbaf284-b37c-4101-84cb-76a44645334f")
			};
		}

		protected virtual EntitySchemaColumn CreateRecordIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("fea5dcb2-0e6a-4d97-bd0d-0a92a6fb359d"),
				Name = @"RecordId",
				CreatedInSchemaUId = new Guid("0195d99c-c259-45e1-b27f-d2145a8838e2"),
				ModifiedInSchemaUId = new Guid("0195d99c-c259-45e1-b27f-d2145a8838e2"),
				CreatedInPackageId = new Guid("edbaf284-b37c-4101-84cb-76a44645334f")
			};
		}

		protected virtual EntitySchemaColumn CreateEntitySchemaNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("fed365ce-80f0-4ce1-9490-4db37237fcb8"),
				Name = @"EntitySchemaName",
				CreatedInSchemaUId = new Guid("0195d99c-c259-45e1-b27f-d2145a8838e2"),
				ModifiedInSchemaUId = new Guid("0195d99c-c259-45e1-b27f-d2145a8838e2"),
				CreatedInPackageId = new Guid("edbaf284-b37c-4101-84cb-76a44645334f")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateVwEntityInProcessEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateVwEntityInProcessEventsProcessSchema() {
			var schema = new VwEntityInProcessEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new VwEntityInProcess(userConnection){Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new VwEntityInProcess_NUIEventsProcess(userConnnection);
		}

		public override object Clone() {
			return new VwEntityInProcessSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new VwEntityInProcessSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("0195d99c-c259-45e1-b27f-d2145a8838e2"));
		}

		#endregion

	}

	#endregion

	#region Class: VwEntityInProcess

	/// <summary>
	/// Used entities in the processes.
	/// </summary>
	public class VwEntityInProcess : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public VwEntityInProcess(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "VwEntityInProcess";
		}

		public VwEntityInProcess(VwEntityInProcess source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Caption of the process.
		/// </summary>
		public  string ProcessCaption {
			get {
				return GetTypedColumnValue<string>("ProcessCaption");
			}
			set {
				SetColumnValue("ProcessCaption", value);
			}
		}

		/// <summary>
		/// Description of the process.
		/// </summary>
		public  string ProcessDescription {
			get {
				return GetTypedColumnValue<string>("ProcessDescription");
			}
			set {
				SetColumnValue("ProcessDescription", value);
			}
		}

		/// <summary>
		/// RecordId.
		/// </summary>
		public  Guid RecordId {
			get {
				return GetTypedColumnValue<Guid>("RecordId");
			}
			set {
				SetColumnValue("RecordId", value);
			}
		}

		/// <summary>
		/// Entity schema name.
		/// </summary>
		public  string EntitySchemaName {
			get {
				return GetTypedColumnValue<string>("EntitySchemaName");
			}
			set {
				SetColumnValue("EntitySchemaName", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new VwEntityInProcess_NUIEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Validating += (s, e) => ThrowEvent("VwEntityInProcessValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new VwEntityInProcess(this);
		}

		#endregion

	}

	#endregion

	#region Class: VwEntityInProcess_NUIEventsProcess

	/// <exclude/>
	public class VwEntityInProcess_NUIEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_LocalMessageEventsProcess<TEntity> where TEntity : VwEntityInProcess
	{

		public VwEntityInProcess_NUIEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "VwEntityInProcess_NUIEventsProcess";
			SchemaUId = new Guid("0195d99c-c259-45e1-b27f-d2145a8838e2");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private  Guid InternalSchemaUId {
			get {
				return new Guid("0195d99c-c259-45e1-b27f-d2145a8838e2");
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

	#region Class: VwEntityInProcess_NUIEventsProcess

	/// <exclude/>
	public class VwEntityInProcess_NUIEventsProcess : VwEntityInProcess_NUIEventsProcess<VwEntityInProcess>
	{

		public VwEntityInProcess_NUIEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: VwEntityInProcessEventsProcessSchema

	/// <exclude/>
	public class VwEntityInProcessEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public VwEntityInProcessEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public VwEntityInProcessEventsProcessSchema(VwEntityInProcessEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "VwEntityInProcess_NUIEventsProcess";
			UId = new Guid("ae37fe6d-eab6-44ff-8b82-19d32b9f78d9");
			CreatedInPackageId = new Guid("edbaf284-b37c-4101-84cb-76a44645334f");
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
			return new VwEntityInProcessEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ae37fe6d-eab6-44ff-8b82-19d32b9f78d9"));
		}

		#endregion

	}

	#endregion


	#region Class: VwEntityInProcessEventsProcess

	/// <exclude/>
	public class VwEntityInProcessEventsProcess : VwEntityInProcess_NUIEventsProcess
	{

		public VwEntityInProcessEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

