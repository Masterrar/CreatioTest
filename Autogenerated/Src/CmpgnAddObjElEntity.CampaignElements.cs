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

	#region Class: CmpgnAddObjElEntitySchema

	/// <exclude/>
	public class CmpgnAddObjElEntitySchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public CmpgnAddObjElEntitySchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public CmpgnAddObjElEntitySchema(CmpgnAddObjElEntitySchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public CmpgnAddObjElEntitySchema(CmpgnAddObjElEntitySchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("35a6bc7c-0078-42e0-a312-1b15fd2badbb");
			RealUId = new Guid("35a6bc7c-0078-42e0-a312-1b15fd2badbb");
			Name = "CmpgnAddObjElEntity";
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
			if (Columns.FindByUId(new Guid("4c85864c-315f-4c06-be53-c2dde63a0ab3")) == null) {
				Columns.Add(CreateEntityNameColumn());
			}
			if (Columns.FindByUId(new Guid("51aa7387-4ca8-41f6-bce2-52ed4186d87d")) == null) {
				Columns.Add(CreateColumnsColumn());
			}
			if (Columns.FindByUId(new Guid("3d26fa3d-a11b-4aa8-a62a-658f60ab1746")) == null) {
				Columns.Add(CreateContactColumnPathColumn());
			}
			if (Columns.FindByUId(new Guid("8f0251b7-55b5-4c7d-bd2d-73248268b5f0")) == null) {
				Columns.Add(CreateRestrictedColumnsColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateCaptionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("dca3e6e3-7988-49c5-9d9a-09be131230e4"),
				Name = @"Caption",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("35a6bc7c-0078-42e0-a312-1b15fd2badbb"),
				ModifiedInSchemaUId = new Guid("35a6bc7c-0078-42e0-a312-1b15fd2badbb"),
				CreatedInPackageId = new Guid("d0bba11f-3986-4819-81ab-1d3ddbfc1f48"),
				IsLocalizable = true
			};
		}

		protected virtual EntitySchemaColumn CreateEntityNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("4c85864c-315f-4c06-be53-c2dde63a0ab3"),
				Name = @"EntityName",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("35a6bc7c-0078-42e0-a312-1b15fd2badbb"),
				ModifiedInSchemaUId = new Guid("35a6bc7c-0078-42e0-a312-1b15fd2badbb"),
				CreatedInPackageId = new Guid("d0bba11f-3986-4819-81ab-1d3ddbfc1f48")
			};
		}

		protected virtual EntitySchemaColumn CreateColumnsColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("51aa7387-4ca8-41f6-bce2-52ed4186d87d"),
				Name = @"Columns",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("35a6bc7c-0078-42e0-a312-1b15fd2badbb"),
				ModifiedInSchemaUId = new Guid("35a6bc7c-0078-42e0-a312-1b15fd2badbb"),
				CreatedInPackageId = new Guid("d0bba11f-3986-4819-81ab-1d3ddbfc1f48")
			};
		}

		protected virtual EntitySchemaColumn CreateContactColumnPathColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("3d26fa3d-a11b-4aa8-a62a-658f60ab1746"),
				Name = @"ContactColumnPath",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("35a6bc7c-0078-42e0-a312-1b15fd2badbb"),
				ModifiedInSchemaUId = new Guid("35a6bc7c-0078-42e0-a312-1b15fd2badbb"),
				CreatedInPackageId = new Guid("d0bba11f-3986-4819-81ab-1d3ddbfc1f48")
			};
		}

		protected virtual EntitySchemaColumn CreateRestrictedColumnsColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("8f0251b7-55b5-4c7d-bd2d-73248268b5f0"),
				Name = @"RestrictedColumns",
				CreatedInSchemaUId = new Guid("35a6bc7c-0078-42e0-a312-1b15fd2badbb"),
				ModifiedInSchemaUId = new Guid("35a6bc7c-0078-42e0-a312-1b15fd2badbb"),
				CreatedInPackageId = new Guid("d0bba11f-3986-4819-81ab-1d3ddbfc1f48")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateCmpgnAddObjElEntityEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateCmpgnAddObjElEntityEventsProcessSchema() {
			var schema = new CmpgnAddObjElEntityEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new CmpgnAddObjElEntity(userConnection){Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new CmpgnAddObjElEntity_CampaignElementsEventsProcess(userConnnection);
		}

		public override object Clone() {
			return new CmpgnAddObjElEntitySchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new CmpgnAddObjElEntitySchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("35a6bc7c-0078-42e0-a312-1b15fd2badbb"));
		}

		#endregion

	}

	#endregion

	#region Class: CmpgnAddObjElEntity

	/// <summary>
	/// Entity settings for campaign element "Add Data".
	/// </summary>
	public class CmpgnAddObjElEntity : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public CmpgnAddObjElEntity(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "CmpgnAddObjElEntity";
		}

		public CmpgnAddObjElEntity(CmpgnAddObjElEntity source)
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
			var process = new CmpgnAddObjElEntity_CampaignElementsEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Inserting += (s, e) => ThrowEvent("CmpgnAddObjElEntityInserting", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new CmpgnAddObjElEntity(this);
		}

		#endregion

	}

	#endregion

	#region Class: CmpgnAddObjElEntity_CampaignElementsEventsProcess

	/// <exclude/>
	public class CmpgnAddObjElEntity_CampaignElementsEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_LocalMessageEventsProcess<TEntity> where TEntity : CmpgnAddObjElEntity
	{

		public CmpgnAddObjElEntity_CampaignElementsEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "CmpgnAddObjElEntity_CampaignElementsEventsProcess";
			SchemaUId = new Guid("35a6bc7c-0078-42e0-a312-1b15fd2badbb");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("35a6bc7c-0078-42e0-a312-1b15fd2badbb");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		private ProcessFlowElement _eventSubProcess3_01b90be06e74438bb9559f196ebfb1e5;
		public ProcessFlowElement EventSubProcess3_01b90be06e74438bb9559f196ebfb1e5 {
			get {
				return _eventSubProcess3_01b90be06e74438bb9559f196ebfb1e5 ?? (_eventSubProcess3_01b90be06e74438bb9559f196ebfb1e5 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess3_01b90be06e74438bb9559f196ebfb1e5",
					SchemaElementUId = new Guid("01b90be0-6e74-438b-b955-9f196ebfb1e5"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTask3_033cc5a96b2c44b69c5f2ab8fd081acd;
		public ProcessScriptTask ScriptTask3_033cc5a96b2c44b69c5f2ab8fd081acd {
			get {
				return _scriptTask3_033cc5a96b2c44b69c5f2ab8fd081acd ?? (_scriptTask3_033cc5a96b2c44b69c5f2ab8fd081acd = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask3_033cc5a96b2c44b69c5f2ab8fd081acd",
					SchemaElementUId = new Guid("033cc5a9-6b2c-44b6-9c5f-2ab8fd081acd"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask3_033cc5a96b2c44b69c5f2ab8fd081acdExecute,
				});
			}
		}

		private ProcessFlowElement _startMessage3_a3a9887c584c4567b88593b40e1c362c;
		public ProcessFlowElement StartMessage3_a3a9887c584c4567b88593b40e1c362c {
			get {
				return _startMessage3_a3a9887c584c4567b88593b40e1c362c ?? (_startMessage3_a3a9887c584c4567b88593b40e1c362c = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessage3_a3a9887c584c4567b88593b40e1c362c",
					SchemaElementUId = new Guid("a3a9887c-584c-4567-b885-93b40e1c362c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
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
			FlowElements[EventSubProcess3_01b90be06e74438bb9559f196ebfb1e5.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess3_01b90be06e74438bb9559f196ebfb1e5 };
			FlowElements[ScriptTask3_033cc5a96b2c44b69c5f2ab8fd081acd.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask3_033cc5a96b2c44b69c5f2ab8fd081acd };
			FlowElements[StartMessage3_a3a9887c584c4567b88593b40e1c362c.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage3_a3a9887c584c4567b88593b40e1c362c };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess3_01b90be06e74438bb9559f196ebfb1e5":
						break;
					case "ScriptTask3_033cc5a96b2c44b69c5f2ab8fd081acd":
						break;
					case "StartMessage3_a3a9887c584c4567b88593b40e1c362c":
						e.Context.QueueTasks.Enqueue("ScriptTask3_033cc5a96b2c44b69c5f2ab8fd081acd");
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("StartMessage3_a3a9887c584c4567b88593b40e1c362c");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "EventSubProcess3_01b90be06e74438bb9559f196ebfb1e5":
					context.QueueTasks.Dequeue();
					break;
				case "ScriptTask3_033cc5a96b2c44b69c5f2ab8fd081acd":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask3_033cc5a96b2c44b69c5f2ab8fd081acd";
					result = ScriptTask3_033cc5a96b2c44b69c5f2ab8fd081acd.Execute(context, ScriptTask3_033cc5a96b2c44b69c5f2ab8fd081acdExecute);
					break;
				case "StartMessage3_a3a9887c584c4567b88593b40e1c362c":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage3_a3a9887c584c4567b88593b40e1c362c";
					result = StartMessage3_a3a9887c584c4567b88593b40e1c362c.Execute(context);
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

		public virtual bool ScriptTask3_033cc5a96b2c44b69c5f2ab8fd081acdExecute(ProcessExecutingContext context) {
			if (Entity.ExistInDB("EntityName", Entity.EntityName)) {
				throw new Exception(UniqueConstraintMessageText.Value);
			}
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "CmpgnAddObjElEntityInserting":
							if (ActivatedEventElements.Contains("StartMessage3_a3a9887c584c4567b88593b40e1c362c")) {
							context.QueueTasks.Enqueue("StartMessage3_a3a9887c584c4567b88593b40e1c362c");
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

	#region Class: CmpgnAddObjElEntity_CampaignElementsEventsProcess

	/// <exclude/>
	public class CmpgnAddObjElEntity_CampaignElementsEventsProcess : CmpgnAddObjElEntity_CampaignElementsEventsProcess<CmpgnAddObjElEntity>
	{

		public CmpgnAddObjElEntity_CampaignElementsEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: CmpgnAddObjElEntityEventsProcessSchema

	/// <exclude/>
	public class CmpgnAddObjElEntityEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public CmpgnAddObjElEntityEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public CmpgnAddObjElEntityEventsProcessSchema(CmpgnAddObjElEntityEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "CmpgnAddObjElEntity_CampaignElementsEventsProcess";
			UId = new Guid("a3fdbcd1-42c4-48a3-8041-d6366437830d");
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
			ProcessSchemaLaneSet schemaLaneSet2_94e1a97807e341eab3ac85d8361eb09e = CreateLaneSet2_94e1a97807e341eab3ac85d8361eb09eLaneSet();
			LaneSets.Add(schemaLaneSet2_94e1a97807e341eab3ac85d8361eb09e);
			ProcessSchemaLane schemaLane1_a1b855e93cc445a3af6c6ad638577c01 = CreateLane1_a1b855e93cc445a3af6c6ad638577c01Lane();
			schemaLaneSet2_94e1a97807e341eab3ac85d8361eb09e.Lanes.Add(schemaLane1_a1b855e93cc445a3af6c6ad638577c01);
			ProcessSchemaEventSubProcess eventsubprocess3_01b90be06e74438bb9559f196ebfb1e5 = CreateEventSubProcess3_01b90be06e74438bb9559f196ebfb1e5EventSubProcess();
			FlowElements.Add(eventsubprocess3_01b90be06e74438bb9559f196ebfb1e5);
			ProcessSchemaScriptTask scripttask3_033cc5a96b2c44b69c5f2ab8fd081acd = CreateScriptTask3_033cc5a96b2c44b69c5f2ab8fd081acdScriptTask();
			eventsubprocess3_01b90be06e74438bb9559f196ebfb1e5.FlowElements.Add(scripttask3_033cc5a96b2c44b69c5f2ab8fd081acd);
			ProcessSchemaStartMessageEvent startmessage3_a3a9887c584c4567b88593b40e1c362c = CreateStartMessage3_a3a9887c584c4567b88593b40e1c362cStartMessageEvent();
			eventsubprocess3_01b90be06e74438bb9559f196ebfb1e5.FlowElements.Add(startmessage3_a3a9887c584c4567b88593b40e1c362c);
			FlowElements.Add(CreateSequenceFlow4_d96f3a44e47e415fb6003c3dc76f2a57SequenceFlow());
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateUniqueConstraintMessageTextLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateUniqueConstraintMessageTextLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("97dfc486-c4ff-4b20-802a-d3e89452edce"),
				Name = "UniqueConstraintMessageText",
				CreatedInPackageId = new Guid("d0bba11f-3986-4819-81ab-1d3ddbfc1f48"),
				CreatedInSchemaUId = new Guid("a3fdbcd1-42c4-48a3-8041-d6366437830d"),
				ModifiedInSchemaUId = new Guid("a3fdbcd1-42c4-48a3-8041-d6366437830d")
			};
			return localizableString;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4_d96f3a44e47e415fb6003c3dc76f2a57SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4_d96f3a44e47e415fb6003c3dc76f2a57",
				UId = new Guid("d96f3a44-e47e-415f-b600-3c3dc76f2a57"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("d0bba11f-3986-4819-81ab-1d3ddbfc1f48"),
				CreatedInSchemaUId = new Guid("a3fdbcd1-42c4-48a3-8041-d6366437830d"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("a3fdbcd1-42c4-48a3-8041-d6366437830d"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("a3a9887c-584c-4567-b885-93b40e1c362c"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("033cc5a9-6b2c-44b6-9c5f-2ab8fd081acd"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet2_94e1a97807e341eab3ac85d8361eb09eLaneSet() {
			ProcessSchemaLaneSet schemaLaneSet2_94e1a97807e341eab3ac85d8361eb09e = new ProcessSchemaLaneSet(this) {
				UId = new Guid("94e1a978-07e3-41ea-b3ac-85d8361eb09e"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("d0bba11f-3986-4819-81ab-1d3ddbfc1f48"),
				CreatedInSchemaUId = new Guid("a3fdbcd1-42c4-48a3-8041-d6366437830d"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("a3fdbcd1-42c4-48a3-8041-d6366437830d"),
				Name = @"LaneSet2_94e1a97807e341eab3ac85d8361eb09e",
				Position = new Point(0, 5),
				Size = new Size(0, 400),
				UseBackgroundMode = false
			};
			return schemaLaneSet2_94e1a97807e341eab3ac85d8361eb09e;
		}

		protected virtual ProcessSchemaLane CreateLane1_a1b855e93cc445a3af6c6ad638577c01Lane() {
			ProcessSchemaLane schemaLane1_a1b855e93cc445a3af6c6ad638577c01 = new ProcessSchemaLane(this) {
				UId = new Guid("a1b855e9-3cc4-45a3-af6c-6ad638577c01"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("94e1a978-07e3-41ea-b3ac-85d8361eb09e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("d0bba11f-3986-4819-81ab-1d3ddbfc1f48"),
				CreatedInSchemaUId = new Guid("a3fdbcd1-42c4-48a3-8041-d6366437830d"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("a3fdbcd1-42c4-48a3-8041-d6366437830d"),
				Name = @"Lane1_a1b855e93cc445a3af6c6ad638577c01",
				Position = new Point(0, 0),
				Size = new Size(700, 400),
				UseBackgroundMode = false
			};
			return schemaLane1_a1b855e93cc445a3af6c6ad638577c01;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess3_01b90be06e74438bb9559f196ebfb1e5EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess3_01b90be06e74438bb9559f196ebfb1e5 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("01b90be0-6e74-438b-b955-9f196ebfb1e5"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("a1b855e9-3cc4-45a3-af6c-6ad638577c01"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("d0bba11f-3986-4819-81ab-1d3ddbfc1f48"),
				CreatedInSchemaUId = new Guid("a3fdbcd1-42c4-48a3-8041-d6366437830d"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("a3fdbcd1-42c4-48a3-8041-d6366437830d"),
				Name = @"EventSubProcess3_01b90be06e74438bb9559f196ebfb1e5",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(60, 240),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(320, 160),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess3_01b90be06e74438bb9559f196ebfb1e5;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask3_033cc5a96b2c44b69c5f2ab8fd081acdScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("033cc5a9-6b2c-44b6-9c5f-2ab8fd081acd"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("01b90be0-6e74-438b-b955-9f196ebfb1e5"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("d0bba11f-3986-4819-81ab-1d3ddbfc1f48"),
				CreatedInSchemaUId = new Guid("a3fdbcd1-42c4-48a3-8041-d6366437830d"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("a3fdbcd1-42c4-48a3-8041-d6366437830d"),
				Name = @"ScriptTask3_033cc5a96b2c44b69c5f2ab8fd081acd",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(211, 45),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,61,201,49,10,2,49,16,5,208,218,156,98,216,42,1,217,11,108,167,166,176,208,74,183,15,50,234,128,78,116,242,195,102,17,239,110,33,218,190,39,103,242,81,33,152,251,216,164,96,171,155,149,239,190,178,79,119,238,150,244,235,191,133,64,47,183,192,213,242,68,202,19,197,118,226,7,36,171,63,170,60,43,175,179,22,88,18,197,142,75,73,23,62,112,67,63,166,91,229,48,184,183,51,70,53,37,88,229,225,3,169,245,69,205,128,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage3_a3a9887c584c4567b88593b40e1c362cStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("a3a9887c-584c-4567-b885-93b40e1c362c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("01b90be0-6e74-438b-b955-9f196ebfb1e5"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("d0bba11f-3986-4819-81ab-1d3ddbfc1f48"),
				CreatedInSchemaUId = new Guid("a3fdbcd1-42c4-48a3-8041-d6366437830d"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"CmpgnAddObjElEntityInserting",
				ModifiedInSchemaUId = new Guid("a3fdbcd1-42c4-48a3-8041-d6366437830d"),
				Name = @"StartMessage3_a3a9887c584c4567b88593b40e1c362c",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(40, 59),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
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
			return new CmpgnAddObjElEntityEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a3fdbcd1-42c4-48a3-8041-d6366437830d"));
		}

		#endregion

	}

	#endregion


	#region Class: CmpgnAddObjElEntityEventsProcess

	/// <exclude/>
	public class CmpgnAddObjElEntityEventsProcess : CmpgnAddObjElEntity_CampaignElementsEventsProcess
	{

		public CmpgnAddObjElEntityEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

