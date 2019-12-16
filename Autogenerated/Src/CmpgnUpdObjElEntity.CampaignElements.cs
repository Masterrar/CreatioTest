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
	using System.Linq;
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
	using Terrasoft.GlobalSearch.Indexing;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities.Json.Converters;

	#region Class: CmpgnUpdObjElEntitySchema

	/// <exclude/>
	public class CmpgnUpdObjElEntitySchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public CmpgnUpdObjElEntitySchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public CmpgnUpdObjElEntitySchema(CmpgnUpdObjElEntitySchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public CmpgnUpdObjElEntitySchema(CmpgnUpdObjElEntitySchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("63066f37-db22-4ccf-8af9-f12190c06248");
			RealUId = new Guid("63066f37-db22-4ccf-8af9-f12190c06248");
			Name = "CmpgnUpdObjElEntity";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("d0bba11f-3986-4819-81ab-1d3ddbfc1f48");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializePrimaryDisplayColumn() {
			base.InitializePrimaryDisplayColumn();
			PrimaryDisplayColumn = CreateCaptionColumn();
			if (Columns.FindByUId(PrimaryDisplayColumn.UId) == null) {
				Columns.Add(PrimaryDisplayColumn);
			}
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("148620fd-8549-4493-a323-f91110808ff9")) == null) {
				Columns.Add(CreateEntityNameColumn());
			}
			if (Columns.FindByUId(new Guid("cc3debdb-76b3-4c2e-91cb-a054b5815652")) == null) {
				Columns.Add(CreateColumnsColumn());
			}
			if (Columns.FindByUId(new Guid("2ed8c490-42aa-4eb5-8afb-57d95c543991")) == null) {
				Columns.Add(CreateContactColumnPathColumn());
			}
			if (Columns.FindByUId(new Guid("6ea67f3c-d593-4549-ab51-fb220366be12")) == null) {
				Columns.Add(CreateRestrictedColumnsColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateCaptionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("443e473e-d9f8-4745-9094-2904919e1bdb"),
				Name = @"Caption",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("63066f37-db22-4ccf-8af9-f12190c06248"),
				ModifiedInSchemaUId = new Guid("63066f37-db22-4ccf-8af9-f12190c06248"),
				CreatedInPackageId = new Guid("d0bba11f-3986-4819-81ab-1d3ddbfc1f48"),
				IsLocalizable = true
			};
		}

		protected virtual EntitySchemaColumn CreateEntityNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("148620fd-8549-4493-a323-f91110808ff9"),
				Name = @"EntityName",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("63066f37-db22-4ccf-8af9-f12190c06248"),
				ModifiedInSchemaUId = new Guid("63066f37-db22-4ccf-8af9-f12190c06248"),
				CreatedInPackageId = new Guid("d0bba11f-3986-4819-81ab-1d3ddbfc1f48")
			};
		}

		protected virtual EntitySchemaColumn CreateColumnsColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("cc3debdb-76b3-4c2e-91cb-a054b5815652"),
				Name = @"Columns",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("63066f37-db22-4ccf-8af9-f12190c06248"),
				ModifiedInSchemaUId = new Guid("63066f37-db22-4ccf-8af9-f12190c06248"),
				CreatedInPackageId = new Guid("d0bba11f-3986-4819-81ab-1d3ddbfc1f48")
			};
		}

		protected virtual EntitySchemaColumn CreateContactColumnPathColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("2ed8c490-42aa-4eb5-8afb-57d95c543991"),
				Name = @"ContactColumnPath",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("63066f37-db22-4ccf-8af9-f12190c06248"),
				ModifiedInSchemaUId = new Guid("63066f37-db22-4ccf-8af9-f12190c06248"),
				CreatedInPackageId = new Guid("d0bba11f-3986-4819-81ab-1d3ddbfc1f48")
			};
		}

		protected virtual EntitySchemaColumn CreateRestrictedColumnsColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("6ea67f3c-d593-4549-ab51-fb220366be12"),
				Name = @"RestrictedColumns",
				CreatedInSchemaUId = new Guid("63066f37-db22-4ccf-8af9-f12190c06248"),
				ModifiedInSchemaUId = new Guid("63066f37-db22-4ccf-8af9-f12190c06248"),
				CreatedInPackageId = new Guid("d0bba11f-3986-4819-81ab-1d3ddbfc1f48")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateCmpgnUpdObjElEntityEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateCmpgnUpdObjElEntityEventsProcessSchema() {
			var schema = new CmpgnUpdObjElEntityEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new CmpgnUpdObjElEntity(userConnection){Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new CmpgnUpdObjElEntity_CampaignElementsEventsProcess(userConnnection);
		}

		public override object Clone() {
			return new CmpgnUpdObjElEntitySchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new CmpgnUpdObjElEntitySchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("63066f37-db22-4ccf-8af9-f12190c06248"));
		}

		#endregion

	}

	#endregion

	#region Class: CmpgnUpdObjElEntity

	/// <summary>
	/// Entity settings for campaign element "Modify Data".
	/// </summary>
	public class CmpgnUpdObjElEntity : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public CmpgnUpdObjElEntity(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "CmpgnUpdObjElEntity";
		}

		public CmpgnUpdObjElEntity(CmpgnUpdObjElEntity source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Caption.
		/// </summary>
		public string Caption {
			get {
				return GetTypedColumnValue<string>("Caption");
			}
			set {
				SetColumnValue("Caption", value);
			}
		}

		/// <summary>
		/// Object.
		/// </summary>
		public string EntityName {
			get {
				return GetTypedColumnValue<string>("EntityName");
			}
			set {
				SetColumnValue("EntityName", value);
			}
		}

		/// <summary>
		/// Allowed columns.
		/// </summary>
		public string Columns {
			get {
				return GetTypedColumnValue<string>("Columns");
			}
			set {
				SetColumnValue("Columns", value);
			}
		}

		/// <summary>
		/// Path to Contact column.
		/// </summary>
		public string ContactColumnPath {
			get {
				return GetTypedColumnValue<string>("ContactColumnPath");
			}
			set {
				SetColumnValue("ContactColumnPath", value);
			}
		}

		/// <summary>
		/// Restricted columns.
		/// </summary>
		public string RestrictedColumns {
			get {
				return GetTypedColumnValue<string>("RestrictedColumns");
			}
			set {
				SetColumnValue("RestrictedColumns", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new CmpgnUpdObjElEntity_CampaignElementsEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Inserting += (s, e) => ThrowEvent("CmpgnUpdObjElEntityInserting", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new CmpgnUpdObjElEntity(this);
		}

		#endregion

	}

	#endregion

	#region Class: CmpgnUpdObjElEntity_CampaignElementsEventsProcess

	/// <exclude/>
	public class CmpgnUpdObjElEntity_CampaignElementsEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_LocalMessageEventsProcess<TEntity> where TEntity : CmpgnUpdObjElEntity
	{

		public CmpgnUpdObjElEntity_CampaignElementsEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "CmpgnUpdObjElEntity_CampaignElementsEventsProcess";
			SchemaUId = new Guid("63066f37-db22-4ccf-8af9-f12190c06248");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("63066f37-db22-4ccf-8af9-f12190c06248");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		private ProcessFlowElement _eventSubProcess3_2a4cdccc67764770acc1e9f7a59f3332;
		public ProcessFlowElement EventSubProcess3_2a4cdccc67764770acc1e9f7a59f3332 {
			get {
				return _eventSubProcess3_2a4cdccc67764770acc1e9f7a59f3332 ?? (_eventSubProcess3_2a4cdccc67764770acc1e9f7a59f3332 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess3_2a4cdccc67764770acc1e9f7a59f3332",
					SchemaElementUId = new Guid("2a4cdccc-6776-4770-acc1-e9f7a59f3332"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessage3_93442f6f6c1146d49680717655e24e9a;
		public ProcessFlowElement StartMessage3_93442f6f6c1146d49680717655e24e9a {
			get {
				return _startMessage3_93442f6f6c1146d49680717655e24e9a ?? (_startMessage3_93442f6f6c1146d49680717655e24e9a = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessage3_93442f6f6c1146d49680717655e24e9a",
					SchemaElementUId = new Guid("93442f6f-6c11-46d4-9680-717655e24e9a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTask3_f8f0b33a33da46b3ab71455320ffb458;
		public ProcessScriptTask ScriptTask3_f8f0b33a33da46b3ab71455320ffb458 {
			get {
				return _scriptTask3_f8f0b33a33da46b3ab71455320ffb458 ?? (_scriptTask3_f8f0b33a33da46b3ab71455320ffb458 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask3_f8f0b33a33da46b3ab71455320ffb458",
					SchemaElementUId = new Guid("f8f0b33a-33da-46b3-ab71-455320ffb458"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask3_f8f0b33a33da46b3ab71455320ffb458Execute,
				});
			}
		}

		private LocalizableString _uniqueConstraintMessageText;
		public LocalizableString UniqueConstraintMessageText {
			get {
				return _uniqueConstraintMessageText ?? (_uniqueConstraintMessageText = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.UniqueConstraintMessageText.Value"));
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess3_2a4cdccc67764770acc1e9f7a59f3332.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess3_2a4cdccc67764770acc1e9f7a59f3332 };
			FlowElements[StartMessage3_93442f6f6c1146d49680717655e24e9a.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage3_93442f6f6c1146d49680717655e24e9a };
			FlowElements[ScriptTask3_f8f0b33a33da46b3ab71455320ffb458.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask3_f8f0b33a33da46b3ab71455320ffb458 };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess3_2a4cdccc67764770acc1e9f7a59f3332":
						break;
					case "StartMessage3_93442f6f6c1146d49680717655e24e9a":
						e.Context.QueueTasks.Enqueue("ScriptTask3_f8f0b33a33da46b3ab71455320ffb458");
						break;
					case "ScriptTask3_f8f0b33a33da46b3ab71455320ffb458":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("StartMessage3_93442f6f6c1146d49680717655e24e9a");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "EventSubProcess3_2a4cdccc67764770acc1e9f7a59f3332":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage3_93442f6f6c1146d49680717655e24e9a":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage3_93442f6f6c1146d49680717655e24e9a";
					result = StartMessage3_93442f6f6c1146d49680717655e24e9a.Execute(context);
					break;
				case "ScriptTask3_f8f0b33a33da46b3ab71455320ffb458":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask3_f8f0b33a33da46b3ab71455320ffb458";
					result = ScriptTask3_f8f0b33a33da46b3ab71455320ffb458.Execute(context, ScriptTask3_f8f0b33a33da46b3ab71455320ffb458Execute);
					break;
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

		public virtual bool ScriptTask3_f8f0b33a33da46b3ab71455320ffb458Execute(ProcessExecutingContext context) {
			if (Entity.ExistInDB("EntityName", Entity.EntityName)) {
				throw new Exception(UniqueConstraintMessageText.Value);
			}
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "CmpgnUpdObjElEntityInserting":
							if (ActivatedEventElements.Contains("StartMessage3_93442f6f6c1146d49680717655e24e9a")) {
							context.QueueTasks.Enqueue("StartMessage3_93442f6f6c1146d49680717655e24e9a");
						}
						break;
			}
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

	#region Class: CmpgnUpdObjElEntity_CampaignElementsEventsProcess

	/// <exclude/>
	public class CmpgnUpdObjElEntity_CampaignElementsEventsProcess : CmpgnUpdObjElEntity_CampaignElementsEventsProcess<CmpgnUpdObjElEntity>
	{

		public CmpgnUpdObjElEntity_CampaignElementsEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: CmpgnUpdObjElEntityEventsProcessSchema

	/// <exclude/>
	public class CmpgnUpdObjElEntityEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public CmpgnUpdObjElEntityEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public CmpgnUpdObjElEntityEventsProcessSchema(CmpgnUpdObjElEntityEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "CmpgnUpdObjElEntity_CampaignElementsEventsProcess";
			UId = new Guid("79e3adfd-bdad-4bf9-9eaa-d8bffc183cce");
			CreatedInPackageId = new Guid("d0bba11f-3986-4819-81ab-1d3ddbfc1f48");
			CreatedInSchemaUId = Guid.Empty;
			CreatedInVersion = @"0.0.0.0";
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
			ProcessSchemaLaneSet schemaLaneSet2_88c35abf1d7f446ca6850a0744d58b31 = CreateLaneSet2_88c35abf1d7f446ca6850a0744d58b31LaneSet();
			LaneSets.Add(schemaLaneSet2_88c35abf1d7f446ca6850a0744d58b31);
			ProcessSchemaLane schemaLane1_ef77114083d540368ec72f783e081916 = CreateLane1_ef77114083d540368ec72f783e081916Lane();
			schemaLaneSet2_88c35abf1d7f446ca6850a0744d58b31.Lanes.Add(schemaLane1_ef77114083d540368ec72f783e081916);
			ProcessSchemaEventSubProcess eventsubprocess3_2a4cdccc67764770acc1e9f7a59f3332 = CreateEventSubProcess3_2a4cdccc67764770acc1e9f7a59f3332EventSubProcess();
			FlowElements.Add(eventsubprocess3_2a4cdccc67764770acc1e9f7a59f3332);
			ProcessSchemaStartMessageEvent startmessage3_93442f6f6c1146d49680717655e24e9a = CreateStartMessage3_93442f6f6c1146d49680717655e24e9aStartMessageEvent();
			eventsubprocess3_2a4cdccc67764770acc1e9f7a59f3332.FlowElements.Add(startmessage3_93442f6f6c1146d49680717655e24e9a);
			ProcessSchemaScriptTask scripttask3_f8f0b33a33da46b3ab71455320ffb458 = CreateScriptTask3_f8f0b33a33da46b3ab71455320ffb458ScriptTask();
			eventsubprocess3_2a4cdccc67764770acc1e9f7a59f3332.FlowElements.Add(scripttask3_f8f0b33a33da46b3ab71455320ffb458);
			FlowElements.Add(CreateSequenceFlow4_d9973046d5434f94ac61d356c69d0f93SequenceFlow());
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateUniqueConstraintMessageTextLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateUniqueConstraintMessageTextLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("fdeee2ac-2a66-4d0e-a75a-e997c0a91934"),
				Name = "UniqueConstraintMessageText",
				CreatedInPackageId = new Guid("d0bba11f-3986-4819-81ab-1d3ddbfc1f48"),
				CreatedInSchemaUId = new Guid("79e3adfd-bdad-4bf9-9eaa-d8bffc183cce"),
				ModifiedInSchemaUId = new Guid("79e3adfd-bdad-4bf9-9eaa-d8bffc183cce")
			};
			return localizableString;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4_d9973046d5434f94ac61d356c69d0f93SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4_d9973046d5434f94ac61d356c69d0f93",
				UId = new Guid("d9973046-d543-4f94-ac61-d356c69d0f93"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("d0bba11f-3986-4819-81ab-1d3ddbfc1f48"),
				CreatedInSchemaUId = new Guid("79e3adfd-bdad-4bf9-9eaa-d8bffc183cce"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("79e3adfd-bdad-4bf9-9eaa-d8bffc183cce"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("93442f6f-6c11-46d4-9680-717655e24e9a"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("f8f0b33a-33da-46b3-ab71-455320ffb458"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(330, 188));
			schemaFlow.PolylinePointPositions.Add(new Point(330, 187));
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet2_88c35abf1d7f446ca6850a0744d58b31LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet2_88c35abf1d7f446ca6850a0744d58b31 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("88c35abf-1d7f-446c-a685-0a0744d58b31"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("d0bba11f-3986-4819-81ab-1d3ddbfc1f48"),
				CreatedInSchemaUId = new Guid("79e3adfd-bdad-4bf9-9eaa-d8bffc183cce"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("79e3adfd-bdad-4bf9-9eaa-d8bffc183cce"),
				Name = @"LaneSet2_88c35abf1d7f446ca6850a0744d58b31",
				Position = new Point(0, 5),
				Size = new Size(0, 400),
				UseBackgroundMode = false
			};
			return schemaLaneSet2_88c35abf1d7f446ca6850a0744d58b31;
		}

		protected virtual ProcessSchemaLane CreateLane1_ef77114083d540368ec72f783e081916Lane() {
			ProcessSchemaLane schemaLane1_ef77114083d540368ec72f783e081916 = new ProcessSchemaLane(this) {
				UId = new Guid("ef771140-83d5-4036-8ec7-2f783e081916"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("88c35abf-1d7f-446c-a685-0a0744d58b31"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("d0bba11f-3986-4819-81ab-1d3ddbfc1f48"),
				CreatedInSchemaUId = new Guid("79e3adfd-bdad-4bf9-9eaa-d8bffc183cce"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("79e3adfd-bdad-4bf9-9eaa-d8bffc183cce"),
				Name = @"Lane1_ef77114083d540368ec72f783e081916",
				Position = new Point(0, 0),
				Size = new Size(700, 400),
				UseBackgroundMode = false
			};
			return schemaLane1_ef77114083d540368ec72f783e081916;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess3_2a4cdccc67764770acc1e9f7a59f3332EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess3_2a4cdccc67764770acc1e9f7a59f3332 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("2a4cdccc-6776-4770-acc1-e9f7a59f3332"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ef771140-83d5-4036-8ec7-2f783e081916"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("d0bba11f-3986-4819-81ab-1d3ddbfc1f48"),
				CreatedInSchemaUId = new Guid("79e3adfd-bdad-4bf9-9eaa-d8bffc183cce"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("79e3adfd-bdad-4bf9-9eaa-d8bffc183cce"),
				Name = @"EventSubProcess3_2a4cdccc67764770acc1e9f7a59f3332",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(199, 96),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(308, 184),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess3_2a4cdccc67764770acc1e9f7a59f3332;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage3_93442f6f6c1146d49680717655e24e9aStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("93442f6f-6c11-46d4-9680-717655e24e9a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("2a4cdccc-6776-4770-acc1-e9f7a59f3332"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("d0bba11f-3986-4819-81ab-1d3ddbfc1f48"),
				CreatedInSchemaUId = new Guid("79e3adfd-bdad-4bf9-9eaa-d8bffc183cce"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"CmpgnUpdObjElEntityInserting",
				ModifiedInSchemaUId = new Guid("79e3adfd-bdad-4bf9-9eaa-d8bffc183cce"),
				Name = @"StartMessage3_93442f6f6c1146d49680717655e24e9a",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(33, 78),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask3_f8f0b33a33da46b3ab71455320ffb458ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("f8f0b33a-33da-46b3-ab71-455320ffb458"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("2a4cdccc-6776-4770-acc1-e9f7a59f3332"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("d0bba11f-3986-4819-81ab-1d3ddbfc1f48"),
				CreatedInSchemaUId = new Guid("79e3adfd-bdad-4bf9-9eaa-d8bffc183cce"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("79e3adfd-bdad-4bf9-9eaa-d8bffc183cce"),
				Name = @"ScriptTask3_f8f0b33a33da46b3ab71455320ffb458",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(200, 64),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,61,201,49,10,2,49,16,5,208,218,156,98,216,42,1,217,11,108,167,166,176,208,74,183,15,50,234,128,78,116,242,195,102,17,239,110,33,218,190,39,103,242,81,33,152,251,216,164,96,171,155,149,239,190,178,79,119,238,150,244,235,191,133,64,47,183,192,213,242,68,202,19,197,118,226,7,36,171,63,170,60,43,175,179,22,88,18,197,142,75,73,23,62,112,67,63,166,91,229,48,184,183,51,70,53,37,88,229,225,3,169,245,69,205,128,0,0,0 }
			};
			
			return ScriptTask;
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
			Usings.Add(new SchemaUsing() {
				UId = new Guid("aca2294b-e209-4c40-9400-0d59d9ecd1ea"),
				Name = "Terrasoft.GlobalSearch.Indexing",
				Alias = "",
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5410f06b-83f8-43fa-bc49-82a2dd508d3c"),
				Name = "System.Linq",
				Alias = "",
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			});
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new CmpgnUpdObjElEntityEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("79e3adfd-bdad-4bf9-9eaa-d8bffc183cce"));
		}

		#endregion

	}

	#endregion


	#region Class: CmpgnUpdObjElEntityEventsProcess

	/// <exclude/>
	public class CmpgnUpdObjElEntityEventsProcess : CmpgnUpdObjElEntity_CampaignElementsEventsProcess
	{

		public CmpgnUpdObjElEntityEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

