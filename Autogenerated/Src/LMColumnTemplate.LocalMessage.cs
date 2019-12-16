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

	#region Class: LMColumnTemplateSchema

	/// <exclude/>
	public class LMColumnTemplateSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public LMColumnTemplateSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public LMColumnTemplateSchema(LMColumnTemplateSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public LMColumnTemplateSchema(LMColumnTemplateSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("0efb7365-699f-4160-9fa0-95f45b0857b4");
			RealUId = new Guid("0efb7365-699f-4160-9fa0-95f45b0857b4");
			Name = "LMColumnTemplate";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("ca4727b2-fc6c-4ae4-bb8b-429fb21e5974");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializePrimaryDisplayColumn() {
			base.InitializePrimaryDisplayColumn();
			PrimaryDisplayColumn = CreateColumnNameColumn();
			if (Columns.FindByUId(PrimaryDisplayColumn.UId) == null) {
				Columns.Add(PrimaryDisplayColumn);
			}
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("bbf9090d-6e34-45ed-b811-c99612da9498")) == null) {
				Columns.Add(CreateIsLinkColumn());
			}
			if (Columns.FindByUId(new Guid("5fef24e8-6ff2-48f3-9cf0-20a61d00d4b6")) == null) {
				Columns.Add(CreateIsOnChangeColumn());
			}
			if (Columns.FindByUId(new Guid("0ae60add-73fc-42d1-a404-579e204d0e76")) == null) {
				Columns.Add(CreateLMStartEventColumn());
			}
			if (Columns.FindByUId(new Guid("d06f139d-f520-4de7-80c3-f7e31de5e41b")) == null) {
				Columns.Add(CreatePositionColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateColumnNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("f56bbfb6-de33-4e51-a455-c8fe7bcbf28f"),
				Name = @"ColumnName",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("0efb7365-699f-4160-9fa0-95f45b0857b4"),
				ModifiedInSchemaUId = new Guid("0efb7365-699f-4160-9fa0-95f45b0857b4"),
				CreatedInPackageId = new Guid("ca4727b2-fc6c-4ae4-bb8b-429fb21e5974")
			};
		}

		protected virtual EntitySchemaColumn CreateIsLinkColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("bbf9090d-6e34-45ed-b811-c99612da9498"),
				Name = @"IsLink",
				CreatedInSchemaUId = new Guid("0efb7365-699f-4160-9fa0-95f45b0857b4"),
				ModifiedInSchemaUId = new Guid("0efb7365-699f-4160-9fa0-95f45b0857b4"),
				CreatedInPackageId = new Guid("ca4727b2-fc6c-4ae4-bb8b-429fb21e5974")
			};
		}

		protected virtual EntitySchemaColumn CreateIsOnChangeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("5fef24e8-6ff2-48f3-9cf0-20a61d00d4b6"),
				Name = @"IsOnChange",
				CreatedInSchemaUId = new Guid("0efb7365-699f-4160-9fa0-95f45b0857b4"),
				ModifiedInSchemaUId = new Guid("0efb7365-699f-4160-9fa0-95f45b0857b4"),
				CreatedInPackageId = new Guid("ca4727b2-fc6c-4ae4-bb8b-429fb21e5974")
			};
		}

		protected virtual EntitySchemaColumn CreateLMStartEventColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("0ae60add-73fc-42d1-a404-579e204d0e76"),
				Name = @"LMStartEvent",
				ReferenceSchemaUId = new Guid("a1490766-e92b-413f-96c8-49bdd8058628"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("0efb7365-699f-4160-9fa0-95f45b0857b4"),
				ModifiedInSchemaUId = new Guid("0efb7365-699f-4160-9fa0-95f45b0857b4"),
				CreatedInPackageId = new Guid("ca4727b2-fc6c-4ae4-bb8b-429fb21e5974")
			};
		}

		protected virtual EntitySchemaColumn CreatePositionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("d06f139d-f520-4de7-80c3-f7e31de5e41b"),
				Name = @"Position",
				CreatedInSchemaUId = new Guid("0efb7365-699f-4160-9fa0-95f45b0857b4"),
				ModifiedInSchemaUId = new Guid("0efb7365-699f-4160-9fa0-95f45b0857b4"),
				CreatedInPackageId = new Guid("3644c994-8f85-41ec-8125-47013bac161f")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateLMColumnTemplateEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateLMColumnTemplateEventsProcessSchema() {
			var schema = new LMColumnTemplateEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new LMColumnTemplate(userConnection){Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new LMColumnTemplate_LocalMessageEventsProcess(userConnnection);
		}

		public override object Clone() {
			return new LMColumnTemplateSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new LMColumnTemplateSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("0efb7365-699f-4160-9fa0-95f45b0857b4"));
		}

		#endregion

	}

	#endregion

	#region Class: LMColumnTemplate

	/// <summary>
	/// Local message column template.
	/// </summary>
	public class LMColumnTemplate : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public LMColumnTemplate(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "LMColumnTemplate";
		}

		public LMColumnTemplate(LMColumnTemplate source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

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

		/// <summary>
		/// Is link.
		/// </summary>
		public  bool IsLink {
			get {
				return GetTypedColumnValue<bool>("IsLink");
			}
			set {
				SetColumnValue("IsLink", value);
			}
		}

		/// <summary>
		/// Is on change.
		/// </summary>
		public  bool IsOnChange {
			get {
				return GetTypedColumnValue<bool>("IsOnChange");
			}
			set {
				SetColumnValue("IsOnChange", value);
			}
		}

		/// <exclude/>
		public  Guid LMStartEventId {
			get {
				return GetTypedColumnValue<Guid>("LMStartEventId");
			}
			set {
				SetColumnValue("LMStartEventId", value);
				_lMStartEvent = null;
			}
		}

		/// <exclude/>
		public  string LMStartEventMessageTemplate {
			get {
				return GetTypedColumnValue<string>("LMStartEventMessageTemplate");
			}
			set {
				SetColumnValue("LMStartEventMessageTemplate", value);
				if (_lMStartEvent != null) {
					_lMStartEvent.MessageTemplate = value;
				}
			}
		}

		private LMStartEvent _lMStartEvent;
		/// <summary>
		/// Local message start event.
		/// </summary>
		public  LMStartEvent LMStartEvent {
			get {
				return _lMStartEvent ??
					(_lMStartEvent = LookupColumnEntities.GetEntity("LMStartEvent") as LMStartEvent);
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

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new LMColumnTemplate_LocalMessageEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Validating += (s, e) => ThrowEvent("LMColumnTemplateValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new LMColumnTemplate(this);
		}

		#endregion

	}

	#endregion

	#region Class: LMColumnTemplate_LocalMessageEventsProcess

	/// <exclude/>
	public class LMColumnTemplate_LocalMessageEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_LocalMessageEventsProcess<TEntity> where TEntity : LMColumnTemplate
	{

		public LMColumnTemplate_LocalMessageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "LMColumnTemplate_LocalMessageEventsProcess";
			SchemaUId = new Guid("0efb7365-699f-4160-9fa0-95f45b0857b4");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private  Guid InternalSchemaUId {
			get {
				return new Guid("0efb7365-699f-4160-9fa0-95f45b0857b4");
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

	#region Class: LMColumnTemplate_LocalMessageEventsProcess

	/// <exclude/>
	public class LMColumnTemplate_LocalMessageEventsProcess : LMColumnTemplate_LocalMessageEventsProcess<LMColumnTemplate>
	{

		public LMColumnTemplate_LocalMessageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: LMColumnTemplateEventsProcessSchema

	/// <exclude/>
	public class LMColumnTemplateEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public LMColumnTemplateEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public LMColumnTemplateEventsProcessSchema(LMColumnTemplateEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "LMColumnTemplate_LocalMessageEventsProcess";
			UId = new Guid("d695312a-5b48-4581-8c4e-9331f0ccf05b");
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
			return new LMColumnTemplateEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d695312a-5b48-4581-8c4e-9331f0ccf05b"));
		}

		#endregion

	}

	#endregion


	#region Class: LMColumnTemplateEventsProcess

	/// <exclude/>
	public class LMColumnTemplateEventsProcess : LMColumnTemplate_LocalMessageEventsProcess
	{

		public LMColumnTemplateEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

