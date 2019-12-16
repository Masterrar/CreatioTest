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

	#region Class: DelayedNotificationSchema

	/// <exclude/>
	public class DelayedNotificationSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public DelayedNotificationSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public DelayedNotificationSchema(DelayedNotificationSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public DelayedNotificationSchema(DelayedNotificationSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("5d0a968b-8809-40b1-b8a6-cff1a57942f5");
			RealUId = new Guid("5d0a968b-8809-40b1-b8a6-cff1a57942f5");
			Name = "DelayedNotification";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("33bac096-c819-4c57-86af-fe71bbb0cb56");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("2048a62b-8d61-41be-b497-6d7cd54de9f1")) == null) {
				Columns.Add(CreateCaseColumn());
			}
			if (Columns.FindByUId(new Guid("e19fe873-1dd9-415c-ae62-493afb3c8eda")) == null) {
				Columns.Add(CreateEmailTemplateIdColumn());
			}
			if (Columns.FindByUId(new Guid("66a0c0f7-e346-4f7d-9fce-421fd4d335bc")) == null) {
				Columns.Add(CreateSendDateColumn());
			}
			if (Columns.FindByUId(new Guid("66724952-a182-4adb-b149-87660e94fd5e")) == null) {
				Columns.Add(CreateActualSendDateColumn());
			}
			if (Columns.FindByUId(new Guid("cb4e796d-2aef-49e6-9423-0c841b3e4fb6")) == null) {
				Columns.Add(CreateErrorColumn());
			}
			if (Columns.FindByUId(new Guid("f254b071-50f6-4503-8407-c5e6b46fe3d5")) == null) {
				Columns.Add(CreateDelayColumn());
			}
			if (Columns.FindByUId(new Guid("aebe2ac0-14aa-4539-9073-7624c2a83132")) == null) {
				Columns.Add(CreateAssemblyQualifiedManagerNameColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateCaseColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("2048a62b-8d61-41be-b497-6d7cd54de9f1"),
				Name = @"Case",
				ReferenceSchemaUId = new Guid("117d32f9-8275-4534-8411-1c66115ce9cd"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("5d0a968b-8809-40b1-b8a6-cff1a57942f5"),
				ModifiedInSchemaUId = new Guid("5d0a968b-8809-40b1-b8a6-cff1a57942f5"),
				CreatedInPackageId = new Guid("33bac096-c819-4c57-86af-fe71bbb0cb56")
			};
		}

		protected virtual EntitySchemaColumn CreateEmailTemplateIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("e19fe873-1dd9-415c-ae62-493afb3c8eda"),
				Name = @"EmailTemplateId",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("5d0a968b-8809-40b1-b8a6-cff1a57942f5"),
				ModifiedInSchemaUId = new Guid("5d0a968b-8809-40b1-b8a6-cff1a57942f5"),
				CreatedInPackageId = new Guid("33bac096-c819-4c57-86af-fe71bbb0cb56")
			};
		}

		protected virtual EntitySchemaColumn CreateSendDateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("DateTime")) {
				UId = new Guid("66a0c0f7-e346-4f7d-9fce-421fd4d335bc"),
				Name = @"SendDate",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("5d0a968b-8809-40b1-b8a6-cff1a57942f5"),
				ModifiedInSchemaUId = new Guid("5d0a968b-8809-40b1-b8a6-cff1a57942f5"),
				CreatedInPackageId = new Guid("33bac096-c819-4c57-86af-fe71bbb0cb56")
			};
		}

		protected virtual EntitySchemaColumn CreateActualSendDateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("DateTime")) {
				UId = new Guid("66724952-a182-4adb-b149-87660e94fd5e"),
				Name = @"ActualSendDate",
				CreatedInSchemaUId = new Guid("5d0a968b-8809-40b1-b8a6-cff1a57942f5"),
				ModifiedInSchemaUId = new Guid("5d0a968b-8809-40b1-b8a6-cff1a57942f5"),
				CreatedInPackageId = new Guid("33bac096-c819-4c57-86af-fe71bbb0cb56")
			};
		}

		protected virtual EntitySchemaColumn CreateErrorColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("cb4e796d-2aef-49e6-9423-0c841b3e4fb6"),
				Name = @"Error",
				CreatedInSchemaUId = new Guid("5d0a968b-8809-40b1-b8a6-cff1a57942f5"),
				ModifiedInSchemaUId = new Guid("5d0a968b-8809-40b1-b8a6-cff1a57942f5"),
				CreatedInPackageId = new Guid("33bac096-c819-4c57-86af-fe71bbb0cb56"),
				IsMultiLineText = true
			};
		}

		protected virtual EntitySchemaColumn CreateDelayColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("f254b071-50f6-4503-8407-c5e6b46fe3d5"),
				Name = @"Delay",
				CreatedInSchemaUId = new Guid("5d0a968b-8809-40b1-b8a6-cff1a57942f5"),
				ModifiedInSchemaUId = new Guid("5d0a968b-8809-40b1-b8a6-cff1a57942f5"),
				CreatedInPackageId = new Guid("33bac096-c819-4c57-86af-fe71bbb0cb56")
			};
		}

		protected virtual EntitySchemaColumn CreateAssemblyQualifiedManagerNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("LongText")) {
				UId = new Guid("aebe2ac0-14aa-4539-9073-7624c2a83132"),
				Name = @"AssemblyQualifiedManagerName",
				CreatedInSchemaUId = new Guid("5d0a968b-8809-40b1-b8a6-cff1a57942f5"),
				ModifiedInSchemaUId = new Guid("5d0a968b-8809-40b1-b8a6-cff1a57942f5"),
				CreatedInPackageId = new Guid("77fa8847-960e-4748-ad77-e37bb90e03a0")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateDelayedNotificationEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateDelayedNotificationEventsProcessSchema() {
			var schema = new DelayedNotificationEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new DelayedNotification(userConnection){Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new DelayedNotification_CaseServiceEventsProcess(userConnnection);
		}

		public override object Clone() {
			return new DelayedNotificationSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new DelayedNotificationSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5d0a968b-8809-40b1-b8a6-cff1a57942f5"));
		}

		#endregion

	}

	#endregion

	#region Class: DelayedNotification

	/// <summary>
	/// Delayed notification.
	/// </summary>
	public class DelayedNotification : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public DelayedNotification(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "DelayedNotification";
		}

		public DelayedNotification(DelayedNotification source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public  Guid CaseId {
			get {
				return GetTypedColumnValue<Guid>("CaseId");
			}
			set {
				SetColumnValue("CaseId", value);
				_case = null;
			}
		}

		/// <exclude/>
		public  string CaseNumber {
			get {
				return GetTypedColumnValue<string>("CaseNumber");
			}
			set {
				SetColumnValue("CaseNumber", value);
				if (_case != null) {
					_case.Number = value;
				}
			}
		}

		private Case _case;
		/// <summary>
		/// Case.
		/// </summary>
		public  Case Case {
			get {
				return _case ??
					(_case = LookupColumnEntities.GetEntity("Case") as Case);
			}
		}

		/// <summary>
		/// Email message template.
		/// </summary>
		public  Guid EmailTemplateId {
			get {
				return GetTypedColumnValue<Guid>("EmailTemplateId");
			}
			set {
				SetColumnValue("EmailTemplateId", value);
			}
		}

		/// <summary>
		/// When sends.
		/// </summary>
		public  DateTime SendDate {
			get {
				return GetTypedColumnValue<DateTime>("SendDate");
			}
			set {
				SetColumnValue("SendDate", value);
			}
		}

		/// <summary>
		/// Actual send date.
		/// </summary>
		public  DateTime ActualSendDate {
			get {
				return GetTypedColumnValue<DateTime>("ActualSendDate");
			}
			set {
				SetColumnValue("ActualSendDate", value);
			}
		}

		/// <summary>
		/// Error.
		/// </summary>
		public  string Error {
			get {
				return GetTypedColumnValue<string>("Error");
			}
			set {
				SetColumnValue("Error", value);
			}
		}

		/// <summary>
		/// Delay.
		/// </summary>
		public  int Delay {
			get {
				return GetTypedColumnValue<int>("Delay");
			}
			set {
				SetColumnValue("Delay", value);
			}
		}

		/// <summary>
		/// Assembly Qualified Manager Name.
		/// </summary>
		public  string AssemblyQualifiedManagerName {
			get {
				return GetTypedColumnValue<string>("AssemblyQualifiedManagerName");
			}
			set {
				SetColumnValue("AssemblyQualifiedManagerName", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new DelayedNotification_CaseServiceEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Validating += (s, e) => ThrowEvent("DelayedNotificationValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new DelayedNotification(this);
		}

		#endregion

	}

	#endregion

	#region Class: DelayedNotification_CaseServiceEventsProcess

	/// <exclude/>
	public class DelayedNotification_CaseServiceEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_LocalMessageEventsProcess<TEntity> where TEntity : DelayedNotification
	{

		public DelayedNotification_CaseServiceEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "DelayedNotification_CaseServiceEventsProcess";
			SchemaUId = new Guid("5d0a968b-8809-40b1-b8a6-cff1a57942f5");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private  Guid InternalSchemaUId {
			get {
				return new Guid("5d0a968b-8809-40b1-b8a6-cff1a57942f5");
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

	#region Class: DelayedNotification_CaseServiceEventsProcess

	/// <exclude/>
	public class DelayedNotification_CaseServiceEventsProcess : DelayedNotification_CaseServiceEventsProcess<DelayedNotification>
	{

		public DelayedNotification_CaseServiceEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: DelayedNotificationEventsProcessSchema

	/// <exclude/>
	public class DelayedNotificationEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public DelayedNotificationEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public DelayedNotificationEventsProcessSchema(DelayedNotificationEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "DelayedNotification_CaseServiceEventsProcess";
			UId = new Guid("7597a1e7-c0d7-4074-aec0-fefb01ae36e6");
			CreatedInPackageId = new Guid("33bac096-c819-4c57-86af-fe71bbb0cb56");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("66f58f21-6ed1-4e29-b506-6b9f6426d463");
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
			return new DelayedNotificationEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("7597a1e7-c0d7-4074-aec0-fefb01ae36e6"));
		}

		#endregion

	}

	#endregion


	#region Class: DelayedNotificationEventsProcess

	/// <exclude/>
	public class DelayedNotificationEventsProcess : DelayedNotification_CaseServiceEventsProcess
	{

		public DelayedNotificationEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

