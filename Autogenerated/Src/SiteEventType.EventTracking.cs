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
	using Terrasoft.Configuration.EventTypePostProcess;
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

	#region Class: SiteEventTypeSchema

	/// <exclude/>
	public class SiteEventTypeSchema : Terrasoft.Configuration.SiteEventType_SiteEvent_TerrasoftSchema
	{

		#region Constructors: Public

		public SiteEventTypeSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public SiteEventTypeSchema(SiteEventTypeSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public SiteEventTypeSchema(SiteEventTypeSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("381d5c8e-7c61-4c5b-ad0a-5c2c05ea7751");
			Name = "SiteEventType";
			ParentSchemaUId = new Guid("e7274000-f0ef-4995-991a-37f0ace69fe3");
			ExtendParent = true;
			CreatedInPackageId = new Guid("2a529963-f0d0-492d-98de-b7a4c61033e2");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("24d403b3-30c6-4bb0-9d5c-59839df24194")) == null) {
				Columns.Add(CreateSelectorTypeColumn());
			}
			if (Columns.FindByUId(new Guid("bf9e6aef-7fd8-43c8-bd90-2f6c9e58f20c")) == null) {
				Columns.Add(CreateWebsiteEventTypeColumn());
			}
			if (Columns.FindByUId(new Guid("0f1649c7-bc5a-4c7f-815e-b6450b7d55fa")) == null) {
				Columns.Add(CreateIsActiveColumn());
			}
			if (Columns.FindByUId(new Guid("c71e4e08-5f92-4e94-8702-52e4eda27ffa")) == null) {
				Columns.Add(CreateIdentifierColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateSelectorTypeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("24d403b3-30c6-4bb0-9d5c-59839df24194"),
				Name = @"SelectorType",
				ReferenceSchemaUId = new Guid("a68f8a18-acad-491f-90fe-af5cd59191cc"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("381d5c8e-7c61-4c5b-ad0a-5c2c05ea7751"),
				ModifiedInSchemaUId = new Guid("381d5c8e-7c61-4c5b-ad0a-5c2c05ea7751"),
				CreatedInPackageId = new Guid("2a529963-f0d0-492d-98de-b7a4c61033e2")
			};
		}

		protected virtual EntitySchemaColumn CreateWebsiteEventTypeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("bf9e6aef-7fd8-43c8-bd90-2f6c9e58f20c"),
				Name = @"WebsiteEventType",
				ReferenceSchemaUId = new Guid("b7962cd4-c1b4-4937-846a-0e54fe403d84"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("381d5c8e-7c61-4c5b-ad0a-5c2c05ea7751"),
				ModifiedInSchemaUId = new Guid("381d5c8e-7c61-4c5b-ad0a-5c2c05ea7751"),
				CreatedInPackageId = new Guid("2a529963-f0d0-492d-98de-b7a4c61033e2"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"91f91131-7edf-4238-abec-113ff689ba84"
				}
			};
		}

		protected virtual EntitySchemaColumn CreateIsActiveColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("0f1649c7-bc5a-4c7f-815e-b6450b7d55fa"),
				Name = @"IsActive",
				CreatedInSchemaUId = new Guid("381d5c8e-7c61-4c5b-ad0a-5c2c05ea7751"),
				ModifiedInSchemaUId = new Guid("381d5c8e-7c61-4c5b-ad0a-5c2c05ea7751"),
				CreatedInPackageId = new Guid("2a529963-f0d0-492d-98de-b7a4c61033e2"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"True"
				}
			};
		}

		protected virtual EntitySchemaColumn CreateIdentifierColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("c71e4e08-5f92-4e94-8702-52e4eda27ffa"),
				Name = @"Identifier",
				CreatedInSchemaUId = new Guid("381d5c8e-7c61-4c5b-ad0a-5c2c05ea7751"),
				ModifiedInSchemaUId = new Guid("381d5c8e-7c61-4c5b-ad0a-5c2c05ea7751"),
				CreatedInPackageId = new Guid("2a529963-f0d0-492d-98de-b7a4c61033e2")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateSiteEventTypeEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateSiteEventTypeEventsProcessSchema() {
			var schema = new SiteEventTypeEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new SiteEventType(userConnection){Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new SiteEventType_EventTrackingEventsProcess(userConnnection);
		}

		public override object Clone() {
			return new SiteEventTypeSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new SiteEventTypeSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("381d5c8e-7c61-4c5b-ad0a-5c2c05ea7751"));
		}

		#endregion

	}

	#endregion

	#region Class: SiteEventType

	/// <summary>
	/// Website tracking event.
	/// </summary>
	public class SiteEventType : Terrasoft.Configuration.SiteEventType_SiteEvent_Terrasoft
	{

		#region Constructors: Public

		public SiteEventType(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "SiteEventType";
		}

		public SiteEventType(SiteEventType source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid SelectorTypeId {
			get {
				return GetTypedColumnValue<Guid>("SelectorTypeId");
			}
			set {
				SetColumnValue("SelectorTypeId", value);
				_selectorType = null;
			}
		}

		/// <exclude/>
		public string SelectorTypeName {
			get {
				return GetTypedColumnValue<string>("SelectorTypeName");
			}
			set {
				SetColumnValue("SelectorTypeName", value);
				if (_selectorType != null) {
					_selectorType.Name = value;
				}
			}
		}

		private SelectorType _selectorType;
		/// <summary>
		/// How to identify elements.
		/// </summary>
		public SelectorType SelectorType {
			get {
				return _selectorType ??
					(_selectorType = LookupColumnEntities.GetEntity("SelectorType") as SelectorType);
			}
		}

		/// <exclude/>
		public Guid WebsiteEventTypeId {
			get {
				return GetTypedColumnValue<Guid>("WebsiteEventTypeId");
			}
			set {
				SetColumnValue("WebsiteEventTypeId", value);
				_websiteEventType = null;
			}
		}

		/// <exclude/>
		public string WebsiteEventTypeName {
			get {
				return GetTypedColumnValue<string>("WebsiteEventTypeName");
			}
			set {
				SetColumnValue("WebsiteEventTypeName", value);
				if (_websiteEventType != null) {
					_websiteEventType.Name = value;
				}
			}
		}

		private WebsiteEventType _websiteEventType;
		/// <summary>
		/// Website event type.
		/// </summary>
		public WebsiteEventType WebsiteEventType {
			get {
				return _websiteEventType ??
					(_websiteEventType = LookupColumnEntities.GetEntity("WebsiteEventType") as WebsiteEventType);
			}
		}

		/// <summary>
		/// Active.
		/// </summary>
		public bool IsActive {
			get {
				return GetTypedColumnValue<bool>("IsActive");
			}
			set {
				SetColumnValue("IsActive", value);
			}
		}

		/// <summary>
		/// Element identifier.
		/// </summary>
		public string Identifier {
			get {
				return GetTypedColumnValue<string>("Identifier");
			}
			set {
				SetColumnValue("Identifier", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new SiteEventType_EventTrackingEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("SiteEventTypeDeleted", e);
			Saved += (s, e) => ThrowEvent("SiteEventTypeSaved", e);
			Validating += (s, e) => ThrowEvent("SiteEventTypeValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SiteEventType(this);
		}

		#endregion

	}

	#endregion

	#region Class: SiteEventType_EventTrackingEventsProcess

	/// <exclude/>
	public class SiteEventType_EventTrackingEventsProcess<TEntity> : Terrasoft.Configuration.SiteEventType_SiteEventEventsProcess<TEntity> where TEntity : SiteEventType
	{

		public SiteEventType_EventTrackingEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SiteEventType_EventTrackingEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("381d5c8e-7c61-4c5b-ad0a-5c2c05ea7751");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		private ProcessFlowElement _savedEventSubProcess;
		public ProcessFlowElement SavedEventSubProcess {
			get {
				return _savedEventSubProcess ?? (_savedEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "SavedEventSubProcess",
					SchemaElementUId = new Guid("3ac999a9-cf9f-4ee6-951e-dafa1e96bae9"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _savedScriptTask;
		public ProcessScriptTask SavedScriptTask {
			get {
				return _savedScriptTask ?? (_savedScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "SavedScriptTask",
					SchemaElementUId = new Guid("d9d655b7-c434-4a76-b0e2-da15a2100853"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = SavedScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _startMessageSiteEventTypeSaved;
		public ProcessFlowElement StartMessageSiteEventTypeSaved {
			get {
				return _startMessageSiteEventTypeSaved ?? (_startMessageSiteEventTypeSaved = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessageSiteEventTypeSaved",
					SchemaElementUId = new Guid("698b7eed-ae70-4203-9cb5-5a88879793ed"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[SavedEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { SavedEventSubProcess };
			FlowElements[SavedScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { SavedScriptTask };
			FlowElements[StartMessageSiteEventTypeSaved.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessageSiteEventTypeSaved };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "SavedEventSubProcess":
						break;
					case "SavedScriptTask":
						break;
					case "StartMessageSiteEventTypeSaved":
						e.Context.QueueTasks.Enqueue("SavedScriptTask");
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("StartMessageSiteEventTypeSaved");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "SavedEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "SavedScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "SavedScriptTask";
					result = SavedScriptTask.Execute(context, SavedScriptTaskExecute);
					break;
				case "StartMessageSiteEventTypeSaved":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessageSiteEventTypeSaved";
					result = StartMessageSiteEventTypeSaved.Execute(context);
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

		public virtual bool SavedScriptTaskExecute(ProcessExecutingContext context) {
			EventTypePostProcess.EventTypePostProcess.SetEventType(UserConnection);
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "SiteEventTypeSaved":
							if (ActivatedEventElements.Contains("StartMessageSiteEventTypeSaved")) {
							context.QueueTasks.Enqueue("StartMessageSiteEventTypeSaved");
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

	#region Class: SiteEventType_EventTrackingEventsProcess

	/// <exclude/>
	public class SiteEventType_EventTrackingEventsProcess : SiteEventType_EventTrackingEventsProcess<SiteEventType>
	{

		public SiteEventType_EventTrackingEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SiteEventTypeEventsProcessSchema

	/// <exclude/>
	public class SiteEventTypeEventsProcessSchema : Terrasoft.Configuration.SiteEventType_SiteEvent_TerrasoftEventsProcessSchema
	{

		#region Constructors: Public

		public SiteEventTypeEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public SiteEventTypeEventsProcessSchema(SiteEventTypeEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "SiteEventType_EventTrackingEventsProcess";
			UId = new Guid("cefaca62-4116-488d-854a-7554c9af6df4");
			CreatedInPackageId = new Guid("2a529963-f0d0-492d-98de-b7a4c61033e2");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("d2f21d6a-22a7-4a54-80c9-af48d4c6b4c1");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet1 = CreateLaneSet1LaneSet();
			LaneSets.Add(schemaLaneSet1);
			ProcessSchemaLane schemaLane1 = CreateLane1Lane();
			schemaLaneSet1.Lanes.Add(schemaLane1);
			ProcessSchemaEventSubProcess savedeventsubprocess = CreateSavedEventSubProcessEventSubProcess();
			FlowElements.Add(savedeventsubprocess);
			ProcessSchemaScriptTask savedscripttask = CreateSavedScriptTaskScriptTask();
			savedeventsubprocess.FlowElements.Add(savedscripttask);
			ProcessSchemaStartMessageEvent startmessagesiteeventtypesaved = CreateStartMessageSiteEventTypeSavedStartMessageEvent();
			savedeventsubprocess.FlowElements.Add(startmessagesiteeventtypesaved);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("5128ba83-547c-41ac-9d2a-bd38c390715b"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("d2f21d6a-22a7-4a54-80c9-af48d4c6b4c1"),
				CreatedInPackageId = new Guid("2a529963-f0d0-492d-98de-b7a4c61033e2"),
				CreatedInSchemaUId = new Guid("cefaca62-4116-488d-854a-7554c9af6df4"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("cefaca62-4116-488d-854a-7554c9af6df4"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("698b7eed-ae70-4203-9cb5-5a88879793ed"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("d9d655b7-c434-4a76-b0e2-da15a2100853"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("555ab527-bcdc-4697-9734-9dfe09457d57"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("d2f21d6a-22a7-4a54-80c9-af48d4c6b4c1"),
				CreatedInPackageId = new Guid("2a529963-f0d0-492d-98de-b7a4c61033e2"),
				CreatedInSchemaUId = new Guid("cefaca62-4116-488d-854a-7554c9af6df4"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("cefaca62-4116-488d-854a-7554c9af6df4"),
				Name = @"LaneSet1",
				Position = new Point(0, 5),
				Size = new Size(0, 400),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("cd31fe9a-1af7-4526-933b-5691358dddb4"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("555ab527-bcdc-4697-9734-9dfe09457d57"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("2a529963-f0d0-492d-98de-b7a4c61033e2"),
				CreatedInSchemaUId = new Guid("cefaca62-4116-488d-854a-7554c9af6df4"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("cefaca62-4116-488d-854a-7554c9af6df4"),
				Name = @"Lane1",
				Position = new Point(0, 0),
				Size = new Size(700, 400),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSavedEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaSavedEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("3ac999a9-cf9f-4ee6-951e-dafa1e96bae9"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("cd31fe9a-1af7-4526-933b-5691358dddb4"),
				CreatedInOwnerSchemaUId = new Guid("d2f21d6a-22a7-4a54-80c9-af48d4c6b4c1"),
				CreatedInPackageId = new Guid("2a529963-f0d0-492d-98de-b7a4c61033e2"),
				CreatedInSchemaUId = new Guid("cefaca62-4116-488d-854a-7554c9af6df4"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("cefaca62-4116-488d-854a-7554c9af6df4"),
				Name = @"SavedEventSubProcess",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(60, 40),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(310, 140),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSavedEventSubProcess;
		}

		protected virtual ProcessSchemaScriptTask CreateSavedScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("d9d655b7-c434-4a76-b0e2-da15a2100853"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("3ac999a9-cf9f-4ee6-951e-dafa1e96bae9"),
				CreatedInOwnerSchemaUId = new Guid("d2f21d6a-22a7-4a54-80c9-af48d4c6b4c1"),
				CreatedInPackageId = new Guid("2a529963-f0d0-492d-98de-b7a4c61033e2"),
				CreatedInSchemaUId = new Guid("cefaca62-4116-488d-854a-7554c9af6df4"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("cefaca62-4116-488d-854a-7554c9af6df4"),
				Name = @"SavedScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(181, 33),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,115,45,75,205,43,9,169,44,72,13,200,47,46,9,40,202,79,78,45,46,214,115,197,38,24,156,90,2,23,215,8,45,78,45,114,206,207,203,75,77,46,201,204,207,211,180,230,42,74,45,41,45,202,83,40,41,42,77,181,6,0,3,100,193,200,84,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessageSiteEventTypeSavedStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("698b7eed-ae70-4203-9cb5-5a88879793ed"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("3ac999a9-cf9f-4ee6-951e-dafa1e96bae9"),
				CreatedInOwnerSchemaUId = new Guid("d2f21d6a-22a7-4a54-80c9-af48d4c6b4c1"),
				CreatedInPackageId = new Guid("2a529963-f0d0-492d-98de-b7a4c61033e2"),
				CreatedInSchemaUId = new Guid("cefaca62-4116-488d-854a-7554c9af6df4"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"SiteEventTypeSaved",
				ModifiedInSchemaUId = new Guid("cefaca62-4116-488d-854a-7554c9af6df4"),
				Name = @"StartMessageSiteEventTypeSaved",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(53, 47),
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
				CreatedInPackageId = new Guid("c65af0e3-7594-46d5-990b-d36fcba84a2a")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("cde525cf-d220-4d2a-b963-e55254c639fc"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("c65af0e3-7594-46d5-990b-d36fcba84a2a")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5c9c82c6-ba6d-4a57-9a14-87fe8faa4ebb"),
				Name = "Terrasoft.Core.DB",
				Alias = "",
				CreatedInPackageId = new Guid("c65af0e3-7594-46d5-990b-d36fcba84a2a")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7821de68-c82b-4917-a6cd-add2adfbe400"),
				Name = "Terrasoft.Common",
				Alias = "",
				CreatedInPackageId = new Guid("c65af0e3-7594-46d5-990b-d36fcba84a2a")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d67de76f-9cbc-4bfc-babb-6f65cb89b973"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("c65af0e3-7594-46d5-990b-d36fcba84a2a")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("74160d3b-65e3-4694-b554-089f2d980e54"),
				Name = "Newtonsoft.Json",
				Alias = "",
				CreatedInPackageId = new Guid("c65af0e3-7594-46d5-990b-d36fcba84a2a")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e401300a-9f16-40c2-9788-cf310ae9d1c5"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("c65af0e3-7594-46d5-990b-d36fcba84a2a")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e10b8079-ec46-4a43-af20-26e44ea73db9"),
				Name = "Terrasoft.Configuration.EventTypePostProcess",
				Alias = "",
				CreatedInPackageId = new Guid("2a529963-f0d0-492d-98de-b7a4c61033e2")
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
			return new SiteEventTypeEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("cefaca62-4116-488d-854a-7554c9af6df4"));
		}

		#endregion

	}

	#endregion


	#region Class: SiteEventTypeEventsProcess

	/// <exclude/>
	public class SiteEventTypeEventsProcess : SiteEventType_EventTrackingEventsProcess
	{

		public SiteEventTypeEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

