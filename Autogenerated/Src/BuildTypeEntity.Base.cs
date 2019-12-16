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

	#region Class: BuildTypeEntitySchema

	/// <exclude/>
	public class BuildTypeEntitySchema : Terrasoft.Configuration.BaseLookupSchema
	{

		#region Constructors: Public

		public BuildTypeEntitySchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public BuildTypeEntitySchema(BuildTypeEntitySchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public BuildTypeEntitySchema(BuildTypeEntitySchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("5efab9d3-ebd4-4b5d-acc2-b8f3d04b45a7");
			RealUId = new Guid("5efab9d3-ebd4-4b5d-acc2-b8f3d04b45a7");
			Name = "BuildTypeEntity";
			ParentSchemaUId = new Guid("11ab4bcb-9b23-4b6d-9c86-520fae925d75");
			ExtendParent = false;
			CreatedInPackageId = new Guid("d8b043ab-1ada-4e1f-9921-a7610c352117");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.ModifiedInSchemaUId = new Guid("5efab9d3-ebd4-4b5d-acc2-b8f3d04b45a7");
			column.CreatedInPackageId = new Guid("d8b043ab-1ada-4e1f-9921-a7610c352117");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.ModifiedInSchemaUId = new Guid("5efab9d3-ebd4-4b5d-acc2-b8f3d04b45a7");
			column.CreatedInPackageId = new Guid("d8b043ab-1ada-4e1f-9921-a7610c352117");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.ModifiedInSchemaUId = new Guid("5efab9d3-ebd4-4b5d-acc2-b8f3d04b45a7");
			column.CreatedInPackageId = new Guid("d8b043ab-1ada-4e1f-9921-a7610c352117");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.ModifiedInSchemaUId = new Guid("5efab9d3-ebd4-4b5d-acc2-b8f3d04b45a7");
			column.CreatedInPackageId = new Guid("d8b043ab-1ada-4e1f-9921-a7610c352117");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.ModifiedInSchemaUId = new Guid("5efab9d3-ebd4-4b5d-acc2-b8f3d04b45a7");
			column.CreatedInPackageId = new Guid("d8b043ab-1ada-4e1f-9921-a7610c352117");
			return column;
		}

		protected override EntitySchemaColumn CreateNameColumn() {
			EntitySchemaColumn column = base.CreateNameColumn();
			column.ModifiedInSchemaUId = new Guid("5efab9d3-ebd4-4b5d-acc2-b8f3d04b45a7");
			column.CreatedInPackageId = new Guid("d8b043ab-1ada-4e1f-9921-a7610c352117");
			return column;
		}

		protected override EntitySchemaColumn CreateDescriptionColumn() {
			EntitySchemaColumn column = base.CreateDescriptionColumn();
			column.ModifiedInSchemaUId = new Guid("5efab9d3-ebd4-4b5d-acc2-b8f3d04b45a7");
			column.CreatedInPackageId = new Guid("d8b043ab-1ada-4e1f-9921-a7610c352117");
			return column;
		}

		protected override EntitySchemaColumn CreateProcessListenersColumn() {
			EntitySchemaColumn column = base.CreateProcessListenersColumn();
			column.ModifiedInSchemaUId = new Guid("5efab9d3-ebd4-4b5d-acc2-b8f3d04b45a7");
			column.CreatedInPackageId = new Guid("d8b043ab-1ada-4e1f-9921-a7610c352117");
			return column;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateBuildTypeEntityEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateBuildTypeEntityEventsProcessSchema() {
			var schema = new BuildTypeEntityEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new BuildTypeEntity(userConnection){Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new BuildTypeEntity_BaseEventsProcess(userConnnection);
		}

		public override object Clone() {
			return new BuildTypeEntitySchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new BuildTypeEntitySchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5efab9d3-ebd4-4b5d-acc2-b8f3d04b45a7"));
		}

		#endregion

	}

	#endregion

	#region Class: BuildTypeEntity

	/// <summary>
	/// Build type.
	/// </summary>
	public class BuildTypeEntity : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public BuildTypeEntity(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "BuildTypeEntity";
		}

		public BuildTypeEntity(BuildTypeEntity source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new BuildTypeEntity_BaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Inserting += (s, e) => ThrowEvent("BuildTypeEntityInserting", e);
			Validating += (s, e) => ThrowEvent("BuildTypeEntityValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new BuildTypeEntity(this);
		}

		#endregion

	}

	#endregion

	#region Class: BuildTypeEntity_BaseEventsProcess

	/// <exclude/>
	public class BuildTypeEntity_BaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseLookup_BaseEventsProcess<TEntity> where TEntity : BuildTypeEntity
	{

		public BuildTypeEntity_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "BuildTypeEntity_BaseEventsProcess";
			SchemaUId = new Guid("5efab9d3-ebd4-4b5d-acc2-b8f3d04b45a7");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private  Guid InternalSchemaUId {
			get {
				return new Guid("5efab9d3-ebd4-4b5d-acc2-b8f3d04b45a7");
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

	#region Class: BuildTypeEntity_BaseEventsProcess

	/// <exclude/>
	public class BuildTypeEntity_BaseEventsProcess : BuildTypeEntity_BaseEventsProcess<BuildTypeEntity>
	{

		public BuildTypeEntity_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: BuildTypeEntityEventsProcessSchema

	/// <exclude/>
	public class BuildTypeEntityEventsProcessSchema : Terrasoft.Configuration.BaseLookupEventsProcessSchema
	{

		#region Constructors: Public

		public BuildTypeEntityEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public BuildTypeEntityEventsProcessSchema(BuildTypeEntityEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "BuildTypeEntity_BaseEventsProcess";
			UId = new Guid("9a48e9d8-068b-4c44-9365-6cd16c5df802");
			CreatedInPackageId = new Guid("d8b043ab-1ada-4e1f-9921-a7610c352117");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("e20c0489-122a-4242-999c-169e8e866fc1");
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
				CreatedInPackageId = new Guid("d8b043ab-1ada-4e1f-9921-a7610c352117")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("cde525cf-d220-4d2a-b963-e55254c639fc"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("d8b043ab-1ada-4e1f-9921-a7610c352117")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5c9c82c6-ba6d-4a57-9a14-87fe8faa4ebb"),
				Name = "Terrasoft.Core.DB",
				Alias = "",
				CreatedInPackageId = new Guid("d8b043ab-1ada-4e1f-9921-a7610c352117")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7821de68-c82b-4917-a6cd-add2adfbe400"),
				Name = "Terrasoft.Common",
				Alias = "",
				CreatedInPackageId = new Guid("d8b043ab-1ada-4e1f-9921-a7610c352117")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d67de76f-9cbc-4bfc-babb-6f65cb89b973"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("d8b043ab-1ada-4e1f-9921-a7610c352117")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("74160d3b-65e3-4694-b554-089f2d980e54"),
				Name = "Newtonsoft.Json",
				Alias = "",
				CreatedInPackageId = new Guid("d8b043ab-1ada-4e1f-9921-a7610c352117")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e401300a-9f16-40c2-9788-cf310ae9d1c5"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("d8b043ab-1ada-4e1f-9921-a7610c352117")
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
			return new BuildTypeEntityEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("9a48e9d8-068b-4c44-9365-6cd16c5df802"));
		}

		#endregion

	}

	#endregion


	#region Class: BuildTypeEntityEventsProcess

	/// <exclude/>
	public class BuildTypeEntityEventsProcess : BuildTypeEntity_BaseEventsProcess
	{

		public BuildTypeEntityEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

