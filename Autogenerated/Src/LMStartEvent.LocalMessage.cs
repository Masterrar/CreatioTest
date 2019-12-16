namespace Terrasoft.Configuration
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

	#region Class: LMStartEventSchema

	/// <exclude/>
	public class LMStartEventSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public LMStartEventSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public LMStartEventSchema(LMStartEventSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public LMStartEventSchema(LMStartEventSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("a1490766-e92b-413f-96c8-49bdd8058628");
			RealUId = new Guid("a1490766-e92b-413f-96c8-49bdd8058628");
			Name = "LMStartEvent";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("ca4727b2-fc6c-4ae4-bb8b-429fb21e5974");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializePrimaryDisplayColumn() {
			base.InitializePrimaryDisplayColumn();
			PrimaryDisplayColumn = CreateMessageTemplateColumn();
			if (Columns.FindByUId(PrimaryDisplayColumn.UId) == null) {
				Columns.Add(PrimaryDisplayColumn);
			}
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("9752e130-9a7d-458a-b3f4-7956151b83b9")) == null) {
				Columns.Add(CreateEntitySchemaUIdColumn());
			}
			if (Columns.FindByUId(new Guid("b535a968-f015-42b2-b3ae-99959a146032")) == null) {
				Columns.Add(CreateRecordChangeTypeColumn());
			}
			if (Columns.FindByUId(new Guid("891bcf17-9c1b-4f5b-b60d-b4947c294054")) == null) {
				Columns.Add(CreateConditionDataColumn());
			}
			if (Columns.FindByUId(new Guid("0c65e42f-3c79-45d9-9117-2f0b2a409019")) == null) {
				Columns.Add(CreateChangedColumnsColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateEntitySchemaUIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("9752e130-9a7d-458a-b3f4-7956151b83b9"),
				Name = @"EntitySchemaUId",
				CreatedInSchemaUId = new Guid("a1490766-e92b-413f-96c8-49bdd8058628"),
				ModifiedInSchemaUId = new Guid("a1490766-e92b-413f-96c8-49bdd8058628"),
				CreatedInPackageId = new Guid("ca4727b2-fc6c-4ae4-bb8b-429fb21e5974")
			};
		}

		protected virtual EntitySchemaColumn CreateMessageTemplateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("LongText")) {
				UId = new Guid("0c61b48e-525b-422b-9f27-23bd201a1a88"),
				Name = @"MessageTemplate",
				CreatedInSchemaUId = new Guid("a1490766-e92b-413f-96c8-49bdd8058628"),
				ModifiedInSchemaUId = new Guid("a1490766-e92b-413f-96c8-49bdd8058628"),
				CreatedInPackageId = new Guid("ca4727b2-fc6c-4ae4-bb8b-429fb21e5974"),
				IsLocalizable = true
			};
		}

		protected virtual EntitySchemaColumn CreateRecordChangeTypeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("b535a968-f015-42b2-b3ae-99959a146032"),
				Name = @"RecordChangeType",
				CreatedInSchemaUId = new Guid("a1490766-e92b-413f-96c8-49bdd8058628"),
				ModifiedInSchemaUId = new Guid("a1490766-e92b-413f-96c8-49bdd8058628"),
				CreatedInPackageId = new Guid("ca4727b2-fc6c-4ae4-bb8b-429fb21e5974")
			};
		}

		protected virtual EntitySchemaColumn CreateConditionDataColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("891bcf17-9c1b-4f5b-b60d-b4947c294054"),
				Name = @"ConditionData",
				CreatedInSchemaUId = new Guid("a1490766-e92b-413f-96c8-49bdd8058628"),
				ModifiedInSchemaUId = new Guid("a1490766-e92b-413f-96c8-49bdd8058628"),
				CreatedInPackageId = new Guid("ca4727b2-fc6c-4ae4-bb8b-429fb21e5974")
			};
		}

		protected virtual EntitySchemaColumn CreateChangedColumnsColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("0c65e42f-3c79-45d9-9117-2f0b2a409019"),
				Name = @"ChangedColumns",
				CreatedInSchemaUId = new Guid("a1490766-e92b-413f-96c8-49bdd8058628"),
				ModifiedInSchemaUId = new Guid("a1490766-e92b-413f-96c8-49bdd8058628"),
				CreatedInPackageId = new Guid("ca4727b2-fc6c-4ae4-bb8b-429fb21e5974")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateLMStartEventEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateLMStartEventEventsProcessSchema() {
			var schema = new LMStartEventEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new LMStartEvent(userConnection){Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new LMStartEvent_LocalMessageEventsProcess(userConnnection);
		}

		public override object Clone() {
			return new LMStartEventSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new LMStartEventSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a1490766-e92b-413f-96c8-49bdd8058628"));
		}

		#endregion

	}

	#endregion

	#region Class: LMStartEvent

	/// <summary>
	/// Local message start event.
	/// </summary>
	public class LMStartEvent : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public LMStartEvent(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "LMStartEvent";
		}

		public LMStartEvent(LMStartEvent source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Object schema.
		/// </summary>
		public  Guid EntitySchemaUId {
			get {
				return GetTypedColumnValue<Guid>("EntitySchemaUId");
			}
			set {
				SetColumnValue("EntitySchemaUId", value);
			}
		}

		/// <summary>
		/// Message template.
		/// </summary>
		public  string MessageTemplate {
			get {
				return GetTypedColumnValue<string>("MessageTemplate");
			}
			set {
				SetColumnValue("MessageTemplate", value);
			}
		}

		/// <summary>
		/// Modification type.
		/// </summary>
		public  int RecordChangeType {
			get {
				return GetTypedColumnValue<int>("RecordChangeType");
			}
			set {
				SetColumnValue("RecordChangeType", value);
			}
		}

		/// <summary>
		/// Event start conditions.
		/// </summary>
		public  string ConditionData {
			get {
				return GetTypedColumnValue<string>("ConditionData");
			}
			set {
				SetColumnValue("ConditionData", value);
			}
		}

		/// <summary>
		/// Event start conditions by changed columns.
		/// </summary>
		public  string ChangedColumns {
			get {
				return GetTypedColumnValue<string>("ChangedColumns");
			}
			set {
				SetColumnValue("ChangedColumns", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new LMStartEvent_LocalMessageEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Validating += (s, e) => ThrowEvent("LMStartEventValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new LMStartEvent(this);
		}

		#endregion

	}

	#endregion

	#region Class: LMStartEvent_LocalMessageEventsProcess

	/// <exclude/>
	public class LMStartEvent_LocalMessageEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_LocalMessageEventsProcess<TEntity> where TEntity : LMStartEvent
	{

		public LMStartEvent_LocalMessageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "LMStartEvent_LocalMessageEventsProcess";
			SchemaUId = new Guid("a1490766-e92b-413f-96c8-49bdd8058628");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private  Guid InternalSchemaUId {
			get {
				return new Guid("a1490766-e92b-413f-96c8-49bdd8058628");
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

		public override void LocalMessageExecuting(EntityChangeType changeType) {
			var lmHelper = new Terrasoft.Configuration.LocalMessageHelper(this.Entity, UserConnection, changeType);
			lmHelper.CreateLocalMessage();
		}

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

	#region Class: LMStartEvent_LocalMessageEventsProcess

	/// <exclude/>
	public class LMStartEvent_LocalMessageEventsProcess : LMStartEvent_LocalMessageEventsProcess<LMStartEvent>
	{

		public LMStartEvent_LocalMessageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: LMStartEventEventsProcessSchema

	/// <exclude/>
	public class LMStartEventEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public LMStartEventEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public LMStartEventEventsProcessSchema(LMStartEventEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "LMStartEvent_LocalMessageEventsProcess";
			UId = new Guid("efb97e3f-5f57-4749-baac-056f9c8a1a71");
			CreatedInPackageId = new Guid("ca4727b2-fc6c-4ae4-bb8b-429fb21e5974");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
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

		protected override SchemaMethod CreateLocalMessageExecutingMethod() {
			SchemaMethod method = base.CreateLocalMessageExecutingMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,77,141,75,10,194,48,16,134,247,158,98,150,45,148,92,160,184,42,130,11,221,213,3,12,225,111,26,136,147,50,51,86,122,123,45,69,112,255,61,86,86,42,207,43,202,2,165,51,9,222,52,66,149,173,78,30,134,42,83,78,47,101,207,85,194,173,70,46,119,152,113,194,33,52,62,103,11,23,241,236,91,71,15,131,126,13,65,220,241,142,226,204,146,48,110,11,218,254,244,123,132,65,193,142,255,86,211,246,31,106,54,191,216,134,0,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new LMStartEventEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("efb97e3f-5f57-4749-baac-056f9c8a1a71"));
		}

		#endregion

	}

	#endregion


	#region Class: LMStartEventEventsProcess

	/// <exclude/>
	public class LMStartEventEventsProcess : LMStartEvent_LocalMessageEventsProcess
	{

		public LMStartEventEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

