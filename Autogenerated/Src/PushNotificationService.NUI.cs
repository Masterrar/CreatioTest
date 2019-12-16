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

	#region Class: PushNotificationServiceSchema

	/// <exclude/>
	public class PushNotificationServiceSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public PushNotificationServiceSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public PushNotificationServiceSchema(PushNotificationServiceSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public PushNotificationServiceSchema(PushNotificationServiceSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("823395a1-42be-4826-ad71-0ab38f575d57");
			RealUId = new Guid("823395a1-42be-4826-ad71-0ab38f575d57");
			Name = "PushNotificationService";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("62eca4a1-acc6-4a36-b0ab-f43c90a8a369");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("86b64869-43ab-462a-a1d0-ce1c27fcd07d")) == null) {
				Columns.Add(CreateNameColumn());
			}
			if (Columns.FindByUId(new Guid("2c07fa2c-d664-4638-9c43-ae6a1ae89678")) == null) {
				Columns.Add(CreateSettingsColumn());
			}
			if (Columns.FindByUId(new Guid("8a8fad30-c514-493f-8b0b-01d2aca7f667")) == null) {
				Columns.Add(CreateEnabledColumn());
			}
			if (Columns.FindByUId(new Guid("6d98a794-2938-4d30-8095-f9cbec57705f")) == null) {
				Columns.Add(CreateClassNameColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("86b64869-43ab-462a-a1d0-ce1c27fcd07d"),
				Name = @"Name",
				CreatedInSchemaUId = new Guid("823395a1-42be-4826-ad71-0ab38f575d57"),
				ModifiedInSchemaUId = new Guid("823395a1-42be-4826-ad71-0ab38f575d57"),
				CreatedInPackageId = new Guid("62eca4a1-acc6-4a36-b0ab-f43c90a8a369")
			};
		}

		protected virtual EntitySchemaColumn CreateSettingsColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("2c07fa2c-d664-4638-9c43-ae6a1ae89678"),
				Name = @"Settings",
				CreatedInSchemaUId = new Guid("823395a1-42be-4826-ad71-0ab38f575d57"),
				ModifiedInSchemaUId = new Guid("823395a1-42be-4826-ad71-0ab38f575d57"),
				CreatedInPackageId = new Guid("62eca4a1-acc6-4a36-b0ab-f43c90a8a369")
			};
		}

		protected virtual EntitySchemaColumn CreateEnabledColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("8a8fad30-c514-493f-8b0b-01d2aca7f667"),
				Name = @"Enabled",
				CreatedInSchemaUId = new Guid("823395a1-42be-4826-ad71-0ab38f575d57"),
				ModifiedInSchemaUId = new Guid("823395a1-42be-4826-ad71-0ab38f575d57"),
				CreatedInPackageId = new Guid("62eca4a1-acc6-4a36-b0ab-f43c90a8a369")
			};
		}

		protected virtual EntitySchemaColumn CreateClassNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("6d98a794-2938-4d30-8095-f9cbec57705f"),
				Name = @"ClassName",
				CreatedInSchemaUId = new Guid("823395a1-42be-4826-ad71-0ab38f575d57"),
				ModifiedInSchemaUId = new Guid("823395a1-42be-4826-ad71-0ab38f575d57"),
				CreatedInPackageId = new Guid("62eca4a1-acc6-4a36-b0ab-f43c90a8a369")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreatePushNotificationServiceEventsProcessSchema();
		}

		protected virtual ProcessSchema CreatePushNotificationServiceEventsProcessSchema() {
			var schema = new PushNotificationServiceEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new PushNotificationService(userConnection){Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new PushNotificationService_NUIEventsProcess(userConnnection);
		}

		public override object Clone() {
			return new PushNotificationServiceSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new PushNotificationServiceSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("823395a1-42be-4826-ad71-0ab38f575d57"));
		}

		#endregion

	}

	#endregion

	#region Class: PushNotificationService

	/// <summary>
	/// Push notification service.
	/// </summary>
	public class PushNotificationService : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public PushNotificationService(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "PushNotificationService";
		}

		public PushNotificationService(PushNotificationService source)
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
		/// Settings.
		/// </summary>
		public  string Settings {
			get {
				return GetTypedColumnValue<string>("Settings");
			}
			set {
				SetColumnValue("Settings", value);
			}
		}

		/// <summary>
		/// Enabled.
		/// </summary>
		public  bool Enabled {
			get {
				return GetTypedColumnValue<bool>("Enabled");
			}
			set {
				SetColumnValue("Enabled", value);
			}
		}

		/// <summary>
		/// ClassName.
		/// </summary>
		public  string ClassName {
			get {
				return GetTypedColumnValue<string>("ClassName");
			}
			set {
				SetColumnValue("ClassName", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new PushNotificationService_NUIEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Validating += (s, e) => ThrowEvent("PushNotificationServiceValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new PushNotificationService(this);
		}

		#endregion

	}

	#endregion

	#region Class: PushNotificationService_NUIEventsProcess

	/// <exclude/>
	public class PushNotificationService_NUIEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_LocalMessageEventsProcess<TEntity> where TEntity : PushNotificationService
	{

		public PushNotificationService_NUIEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "PushNotificationService_NUIEventsProcess";
			SchemaUId = new Guid("823395a1-42be-4826-ad71-0ab38f575d57");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private  Guid InternalSchemaUId {
			get {
				return new Guid("823395a1-42be-4826-ad71-0ab38f575d57");
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

	#region Class: PushNotificationService_NUIEventsProcess

	/// <exclude/>
	public class PushNotificationService_NUIEventsProcess : PushNotificationService_NUIEventsProcess<PushNotificationService>
	{

		public PushNotificationService_NUIEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: PushNotificationServiceEventsProcessSchema

	/// <exclude/>
	public class PushNotificationServiceEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public PushNotificationServiceEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public PushNotificationServiceEventsProcessSchema(PushNotificationServiceEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "PushNotificationService_NUIEventsProcess";
			UId = new Guid("b4a2255b-e234-4c51-a867-c8d695e4b5b8");
			CreatedInPackageId = new Guid("62eca4a1-acc6-4a36-b0ab-f43c90a8a369");
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
			return new PushNotificationServiceEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b4a2255b-e234-4c51-a867-c8d695e4b5b8"));
		}

		#endregion

	}

	#endregion


	#region Class: PushNotificationServiceEventsProcess

	/// <exclude/>
	public class PushNotificationServiceEventsProcess : PushNotificationService_NUIEventsProcess
	{

		public PushNotificationServiceEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

