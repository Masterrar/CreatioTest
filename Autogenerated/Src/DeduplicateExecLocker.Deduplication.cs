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

	#region Class: DeduplicateExecLockerSchema

	/// <exclude/>
	public class DeduplicateExecLockerSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public DeduplicateExecLockerSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public DeduplicateExecLockerSchema(DeduplicateExecLockerSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public DeduplicateExecLockerSchema(DeduplicateExecLockerSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("912f6630-b727-4b7d-aaf9-71ae8d1637cb");
			RealUId = new Guid("912f6630-b727-4b7d-aaf9-71ae8d1637cb");
			Name = "DeduplicateExecLocker";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("a2cb4b0a-72d7-4fbf-b57c-bc3bae7898e7");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializePrimaryDisplayColumn() {
			base.InitializePrimaryDisplayColumn();
			PrimaryDisplayColumn = CreateEntitySchemaNameColumn();
			if (Columns.FindByUId(PrimaryDisplayColumn.UId) == null) {
				Columns.Add(PrimaryDisplayColumn);
			}
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("efa1d59a-9306-4176-b1a1-16ab1e0c0822")) == null) {
				Columns.Add(CreateConversationColumn());
			}
			if (Columns.FindByUId(new Guid("ff672427-2b11-45d4-a32f-0568b7b0f4e0")) == null) {
				Columns.Add(CreateOperationColumn());
			}
			if (Columns.FindByUId(new Guid("f34d69e8-fd2f-4e9f-93ab-395a1bbc6537")) == null) {
				Columns.Add(CreateIsInProgressColumn());
			}
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.IsIndexed = false;
			column.ModifiedInSchemaUId = new Guid("912f6630-b727-4b7d-aaf9-71ae8d1637cb");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.IsIndexed = false;
			column.ModifiedInSchemaUId = new Guid("912f6630-b727-4b7d-aaf9-71ae8d1637cb");
			return column;
		}

		protected virtual EntitySchemaColumn CreateEntitySchemaNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("99f7f2f9-3e6a-40f6-9219-7c9bf8546b13"),
				Name = @"EntitySchemaName",
				CreatedInSchemaUId = new Guid("912f6630-b727-4b7d-aaf9-71ae8d1637cb"),
				ModifiedInSchemaUId = new Guid("912f6630-b727-4b7d-aaf9-71ae8d1637cb"),
				CreatedInPackageId = new Guid("a2cb4b0a-72d7-4fbf-b57c-bc3bae7898e7")
			};
		}

		protected virtual EntitySchemaColumn CreateConversationColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("efa1d59a-9306-4176-b1a1-16ab1e0c0822"),
				Name = @"Conversation",
				ReferenceSchemaUId = new Guid("16ffbae1-539a-45e3-96d5-a65dd1f6e045"),
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("912f6630-b727-4b7d-aaf9-71ae8d1637cb"),
				ModifiedInSchemaUId = new Guid("912f6630-b727-4b7d-aaf9-71ae8d1637cb"),
				CreatedInPackageId = new Guid("a2cb4b0a-72d7-4fbf-b57c-bc3bae7898e7")
			};
		}

		protected virtual EntitySchemaColumn CreateOperationColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("ff672427-2b11-45d4-a32f-0568b7b0f4e0"),
				Name = @"Operation",
				ReferenceSchemaUId = new Guid("34c91fed-b922-43f7-a0d4-03aed72f7833"),
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("912f6630-b727-4b7d-aaf9-71ae8d1637cb"),
				ModifiedInSchemaUId = new Guid("912f6630-b727-4b7d-aaf9-71ae8d1637cb"),
				CreatedInPackageId = new Guid("a2cb4b0a-72d7-4fbf-b57c-bc3bae7898e7")
			};
		}

		protected virtual EntitySchemaColumn CreateIsInProgressColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("f34d69e8-fd2f-4e9f-93ab-395a1bbc6537"),
				Name = @"IsInProgress",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("912f6630-b727-4b7d-aaf9-71ae8d1637cb"),
				ModifiedInSchemaUId = new Guid("912f6630-b727-4b7d-aaf9-71ae8d1637cb"),
				CreatedInPackageId = new Guid("a2cb4b0a-72d7-4fbf-b57c-bc3bae7898e7")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateDeduplicateExecLockerEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateDeduplicateExecLockerEventsProcessSchema() {
			var schema = new DeduplicateExecLockerEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new DeduplicateExecLocker(userConnection){Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new DeduplicateExecLocker_DeduplicationEventsProcess(userConnnection);
		}

		public override object Clone() {
			return new DeduplicateExecLockerSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new DeduplicateExecLockerSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("912f6630-b727-4b7d-aaf9-71ae8d1637cb"));
		}

		#endregion

	}

	#endregion

	#region Class: DeduplicateExecLocker

	/// <summary>
	/// Deduplication locker.
	/// </summary>
	public class DeduplicateExecLocker : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public DeduplicateExecLocker(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "DeduplicateExecLocker";
		}

		public DeduplicateExecLocker(DeduplicateExecLocker source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// EntitySchemaName.
		/// </summary>
		public string EntitySchemaName {
			get {
				return GetTypedColumnValue<string>("EntitySchemaName");
			}
			set {
				SetColumnValue("EntitySchemaName", value);
			}
		}

		/// <exclude/>
		public Guid ConversationId {
			get {
				return GetTypedColumnValue<Guid>("ConversationId");
			}
			set {
				SetColumnValue("ConversationId", value);
				_conversation = null;
			}
		}

		/// <exclude/>
		public string ConversationProcedureName {
			get {
				return GetTypedColumnValue<string>("ConversationProcedureName");
			}
			set {
				SetColumnValue("ConversationProcedureName", value);
				if (_conversation != null) {
					_conversation.ProcedureName = value;
				}
			}
		}

		private DeduplicateExecLog _conversation;
		/// <summary>
		/// Conversation.
		/// </summary>
		public DeduplicateExecLog Conversation {
			get {
				return _conversation ??
					(_conversation = LookupColumnEntities.GetEntity("Conversation") as DeduplicateExecLog);
			}
		}

		/// <exclude/>
		public Guid OperationId {
			get {
				return GetTypedColumnValue<Guid>("OperationId");
			}
			set {
				SetColumnValue("OperationId", value);
				_operation = null;
			}
		}

		/// <exclude/>
		public string OperationName {
			get {
				return GetTypedColumnValue<string>("OperationName");
			}
			set {
				SetColumnValue("OperationName", value);
				if (_operation != null) {
					_operation.Name = value;
				}
			}
		}

		private DeduplicateOperation _operation;
		/// <summary>
		/// Operation.
		/// </summary>
		public DeduplicateOperation Operation {
			get {
				return _operation ??
					(_operation = LookupColumnEntities.GetEntity("Operation") as DeduplicateOperation);
			}
		}

		/// <summary>
		/// IsInProgress.
		/// </summary>
		public bool IsInProgress {
			get {
				return GetTypedColumnValue<bool>("IsInProgress");
			}
			set {
				SetColumnValue("IsInProgress", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new DeduplicateExecLocker_DeduplicationEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Validating += (s, e) => ThrowEvent("DeduplicateExecLockerValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new DeduplicateExecLocker(this);
		}

		#endregion

	}

	#endregion

	#region Class: DeduplicateExecLocker_DeduplicationEventsProcess

	/// <exclude/>
	public class DeduplicateExecLocker_DeduplicationEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_LocalMessageEventsProcess<TEntity> where TEntity : DeduplicateExecLocker
	{

		public DeduplicateExecLocker_DeduplicationEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "DeduplicateExecLocker_DeduplicationEventsProcess";
			SchemaUId = new Guid("912f6630-b727-4b7d-aaf9-71ae8d1637cb");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("912f6630-b727-4b7d-aaf9-71ae8d1637cb");
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

	#region Class: DeduplicateExecLocker_DeduplicationEventsProcess

	/// <exclude/>
	public class DeduplicateExecLocker_DeduplicationEventsProcess : DeduplicateExecLocker_DeduplicationEventsProcess<DeduplicateExecLocker>
	{

		public DeduplicateExecLocker_DeduplicationEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: DeduplicateExecLockerEventsProcessSchema

	/// <exclude/>
	public class DeduplicateExecLockerEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public DeduplicateExecLockerEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public DeduplicateExecLockerEventsProcessSchema(DeduplicateExecLockerEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "DeduplicateExecLocker_DeduplicationEventsProcess";
			UId = new Guid("88e4071c-6571-4643-a123-dc03a4b88739");
			CreatedInPackageId = new Guid("a2cb4b0a-72d7-4fbf-b57c-bc3bae7898e7");
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
			return new DeduplicateExecLockerEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("88e4071c-6571-4643-a123-dc03a4b88739"));
		}

		#endregion

	}

	#endregion


	#region Class: DeduplicateExecLockerEventsProcess

	/// <exclude/>
	public class DeduplicateExecLockerEventsProcess : DeduplicateExecLocker_DeduplicationEventsProcess
	{

		public DeduplicateExecLockerEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

