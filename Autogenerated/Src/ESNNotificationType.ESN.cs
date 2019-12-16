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

	#region Class: ESNNotificationTypeSchema

	/// <exclude/>
	public class ESNNotificationTypeSchema : Terrasoft.Configuration.BaseLookupSchema
	{

		#region Constructors: Public

		public ESNNotificationTypeSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public ESNNotificationTypeSchema(ESNNotificationTypeSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public ESNNotificationTypeSchema(ESNNotificationTypeSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("50ccb888-a445-4deb-95d1-452c96fcd984");
			RealUId = new Guid("50ccb888-a445-4deb-95d1-452c96fcd984");
			Name = "ESNNotificationType";
			ParentSchemaUId = new Guid("11ab4bcb-9b23-4b6d-9c86-520fae925d75");
			ExtendParent = false;
			CreatedInPackageId = new Guid("85692de8-da76-4104-833d-8e3ae998c1d9");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializePrimaryDisplayColumn() {
			base.InitializePrimaryDisplayColumn();
			PrimaryDisplayColumn = CreateActionColumn();
			if (Columns.FindByUId(PrimaryDisplayColumn.UId) == null) {
				Columns.Add(PrimaryDisplayColumn);
			}
		}

		protected override void InitializePrimaryImageColumn() {
			base.InitializePrimaryImageColumn();
			PrimaryImageColumn = CreateIconColumn();
			if (Columns.FindByUId(PrimaryImageColumn.UId) == null) {
				Columns.Add(PrimaryImageColumn);
			}
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.ModifiedInSchemaUId = new Guid("50ccb888-a445-4deb-95d1-452c96fcd984");
			column.CreatedInPackageId = new Guid("85692de8-da76-4104-833d-8e3ae998c1d9");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.ModifiedInSchemaUId = new Guid("50ccb888-a445-4deb-95d1-452c96fcd984");
			column.CreatedInPackageId = new Guid("85692de8-da76-4104-833d-8e3ae998c1d9");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.ModifiedInSchemaUId = new Guid("50ccb888-a445-4deb-95d1-452c96fcd984");
			column.CreatedInPackageId = new Guid("85692de8-da76-4104-833d-8e3ae998c1d9");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.ModifiedInSchemaUId = new Guid("50ccb888-a445-4deb-95d1-452c96fcd984");
			column.CreatedInPackageId = new Guid("85692de8-da76-4104-833d-8e3ae998c1d9");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.ModifiedInSchemaUId = new Guid("50ccb888-a445-4deb-95d1-452c96fcd984");
			column.CreatedInPackageId = new Guid("85692de8-da76-4104-833d-8e3ae998c1d9");
			return column;
		}

		protected override EntitySchemaColumn CreateNameColumn() {
			EntitySchemaColumn column = base.CreateNameColumn();
			column.IsLocalizable = false;
			column.ModifiedInSchemaUId = new Guid("50ccb888-a445-4deb-95d1-452c96fcd984");
			column.CreatedInPackageId = new Guid("85692de8-da76-4104-833d-8e3ae998c1d9");
			return column;
		}

		protected override EntitySchemaColumn CreateDescriptionColumn() {
			EntitySchemaColumn column = base.CreateDescriptionColumn();
			column.ModifiedInSchemaUId = new Guid("50ccb888-a445-4deb-95d1-452c96fcd984");
			column.CreatedInPackageId = new Guid("85692de8-da76-4104-833d-8e3ae998c1d9");
			return column;
		}

		protected override EntitySchemaColumn CreateProcessListenersColumn() {
			EntitySchemaColumn column = base.CreateProcessListenersColumn();
			column.ModifiedInSchemaUId = new Guid("50ccb888-a445-4deb-95d1-452c96fcd984");
			column.CreatedInPackageId = new Guid("85692de8-da76-4104-833d-8e3ae998c1d9");
			return column;
		}

		protected virtual EntitySchemaColumn CreateActionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("LongText")) {
				UId = new Guid("a4de0840-eb56-4d68-a52a-50dd4e7e115c"),
				Name = @"Action",
				CreatedInSchemaUId = new Guid("50ccb888-a445-4deb-95d1-452c96fcd984"),
				ModifiedInSchemaUId = new Guid("50ccb888-a445-4deb-95d1-452c96fcd984"),
				CreatedInPackageId = new Guid("85692de8-da76-4104-833d-8e3ae998c1d9"),
				IsLocalizable = true
			};
		}

		protected virtual EntitySchemaColumn CreateIconColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ImageLookup")) {
				UId = new Guid("66faaed4-c85e-4322-b1b4-5ac530206f23"),
				Name = @"Icon",
				ReferenceSchemaUId = new Guid("93986bfe-2dbd-46bc-9bf9-d03dfefbf3b8"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("50ccb888-a445-4deb-95d1-452c96fcd984"),
				ModifiedInSchemaUId = new Guid("50ccb888-a445-4deb-95d1-452c96fcd984"),
				CreatedInPackageId = new Guid("85692de8-da76-4104-833d-8e3ae998c1d9")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateESNNotificationTypeEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateESNNotificationTypeEventsProcessSchema() {
			var schema = new ESNNotificationTypeEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new ESNNotificationType(userConnection){Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new ESNNotificationType_ESNEventsProcess(userConnnection);
		}

		public override object Clone() {
			return new ESNNotificationTypeSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new ESNNotificationTypeSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("50ccb888-a445-4deb-95d1-452c96fcd984"));
		}

		#endregion

	}

	#endregion

	#region Class: ESNNotificationType

	/// <summary>
	/// ESN notification type.
	/// </summary>
	public class ESNNotificationType : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public ESNNotificationType(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "ESNNotificationType";
		}

		public ESNNotificationType(ESNNotificationType source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Task.
		/// </summary>
		public  string Action {
			get {
				return GetTypedColumnValue<string>("Action");
			}
			set {
				SetColumnValue("Action", value);
			}
		}

		/// <exclude/>
		public  Guid IconId {
			get {
				return GetTypedColumnValue<Guid>("IconId");
			}
			set {
				SetColumnValue("IconId", value);
				_icon = null;
			}
		}

		/// <exclude/>
		public  string IconName {
			get {
				return GetTypedColumnValue<string>("IconName");
			}
			set {
				SetColumnValue("IconName", value);
				if (_icon != null) {
					_icon.Name = value;
				}
			}
		}

		private SysImage _icon;
		/// <summary>
		/// Type icon.
		/// </summary>
		public  SysImage Icon {
			get {
				return _icon ??
					(_icon = LookupColumnEntities.GetEntity("Icon") as SysImage);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new ESNNotificationType_ESNEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Inserting += (s, e) => ThrowEvent("ESNNotificationTypeInserting", e);
			Validating += (s, e) => ThrowEvent("ESNNotificationTypeValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new ESNNotificationType(this);
		}

		#endregion

	}

	#endregion

	#region Class: ESNNotificationType_ESNEventsProcess

	/// <exclude/>
	public class ESNNotificationType_ESNEventsProcess<TEntity> : Terrasoft.Configuration.BaseLookup_BaseEventsProcess<TEntity> where TEntity : ESNNotificationType
	{

		public ESNNotificationType_ESNEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ESNNotificationType_ESNEventsProcess";
			SchemaUId = new Guid("50ccb888-a445-4deb-95d1-452c96fcd984");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private  Guid InternalSchemaUId {
			get {
				return new Guid("50ccb888-a445-4deb-95d1-452c96fcd984");
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

	#region Class: ESNNotificationType_ESNEventsProcess

	/// <exclude/>
	public class ESNNotificationType_ESNEventsProcess : ESNNotificationType_ESNEventsProcess<ESNNotificationType>
	{

		public ESNNotificationType_ESNEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: ESNNotificationTypeEventsProcessSchema

	/// <exclude/>
	public class ESNNotificationTypeEventsProcessSchema : Terrasoft.Configuration.BaseLookupEventsProcessSchema
	{

		#region Constructors: Public

		public ESNNotificationTypeEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public ESNNotificationTypeEventsProcessSchema(ESNNotificationTypeEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "ESNNotificationType_ESNEventsProcess";
			UId = new Guid("93823596-eebc-4659-b8fb-47d523e30272");
			CreatedInPackageId = new Guid("85692de8-da76-4104-833d-8e3ae998c1d9");
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
				CreatedInPackageId = new Guid("85692de8-da76-4104-833d-8e3ae998c1d9")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("cde525cf-d220-4d2a-b963-e55254c639fc"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("85692de8-da76-4104-833d-8e3ae998c1d9")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5c9c82c6-ba6d-4a57-9a14-87fe8faa4ebb"),
				Name = "Terrasoft.Core.DB",
				Alias = "",
				CreatedInPackageId = new Guid("85692de8-da76-4104-833d-8e3ae998c1d9")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7821de68-c82b-4917-a6cd-add2adfbe400"),
				Name = "Terrasoft.Common",
				Alias = "",
				CreatedInPackageId = new Guid("85692de8-da76-4104-833d-8e3ae998c1d9")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d67de76f-9cbc-4bfc-babb-6f65cb89b973"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("85692de8-da76-4104-833d-8e3ae998c1d9")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("74160d3b-65e3-4694-b554-089f2d980e54"),
				Name = "Newtonsoft.Json",
				Alias = "",
				CreatedInPackageId = new Guid("85692de8-da76-4104-833d-8e3ae998c1d9")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e401300a-9f16-40c2-9788-cf310ae9d1c5"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("85692de8-da76-4104-833d-8e3ae998c1d9")
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
			return new ESNNotificationTypeEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("93823596-eebc-4659-b8fb-47d523e30272"));
		}

		#endregion

	}

	#endregion


	#region Class: ESNNotificationTypeEventsProcess

	/// <exclude/>
	public class ESNNotificationTypeEventsProcess : ESNNotificationType_ESNEventsProcess
	{

		public ESNNotificationTypeEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

