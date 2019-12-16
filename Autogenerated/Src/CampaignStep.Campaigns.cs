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
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities.Json.Converters;

	#region Class: CampaignStepSchema

	/// <exclude/>
	public class CampaignStepSchema : Terrasoft.Configuration.DiagramElementSchema
	{

		#region Constructors: Public

		public CampaignStepSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public CampaignStepSchema(CampaignStepSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public CampaignStepSchema(CampaignStepSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("1c6cda37-90f0-4b88-a13c-af0b11cc464f");
			RealUId = new Guid("1c6cda37-90f0-4b88-a13c-af0b11cc464f");
			Name = "CampaignStep";
			ParentSchemaUId = new Guid("e1b5b3fc-bd8e-4cba-b470-5c2e909dab3e");
			ExtendParent = false;
			CreatedInPackageId = new Guid("5ef8c1cb-e12d-44bb-94fb-8751249ccc2c");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializePrimaryDisplayColumn() {
			base.InitializePrimaryDisplayColumn();
			PrimaryDisplayColumn = CreateTitleColumn();
			if (Columns.FindByUId(PrimaryDisplayColumn.UId) == null) {
				Columns.Add(PrimaryDisplayColumn);
			}
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("04330cae-abcc-4e56-9ebd-0db346d46b31")) == null) {
				Columns.Add(CreateRecordIdColumn());
			}
			if (Columns.FindByUId(new Guid("6408c73b-b88d-430e-90a5-ac12523903c5")) == null) {
				Columns.Add(CreateCampaignColumn());
			}
			if (Columns.FindByUId(new Guid("f3b54709-35b3-43c6-b09e-44dc88c87426")) == null) {
				Columns.Add(CreateTypeColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateTitleColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("4421e9b5-6af9-43ab-a54d-f0938cc28db8"),
				Name = @"Title",
				CreatedInSchemaUId = new Guid("1c6cda37-90f0-4b88-a13c-af0b11cc464f"),
				ModifiedInSchemaUId = new Guid("1c6cda37-90f0-4b88-a13c-af0b11cc464f"),
				CreatedInPackageId = new Guid("5ef8c1cb-e12d-44bb-94fb-8751249ccc2c")
			};
		}

		protected virtual EntitySchemaColumn CreateRecordIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("04330cae-abcc-4e56-9ebd-0db346d46b31"),
				Name = @"RecordId",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("1c6cda37-90f0-4b88-a13c-af0b11cc464f"),
				ModifiedInSchemaUId = new Guid("1c6cda37-90f0-4b88-a13c-af0b11cc464f"),
				CreatedInPackageId = new Guid("5ef8c1cb-e12d-44bb-94fb-8751249ccc2c")
			};
		}

		protected virtual EntitySchemaColumn CreateCampaignColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("6408c73b-b88d-430e-90a5-ac12523903c5"),
				Name = @"Campaign",
				ReferenceSchemaUId = new Guid("1f9bb71a-eb9c-4220-a40e-9b623eacfec8"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("1c6cda37-90f0-4b88-a13c-af0b11cc464f"),
				ModifiedInSchemaUId = new Guid("1c6cda37-90f0-4b88-a13c-af0b11cc464f"),
				CreatedInPackageId = new Guid("5ef8c1cb-e12d-44bb-94fb-8751249ccc2c")
			};
		}

		protected virtual EntitySchemaColumn CreateTypeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("f3b54709-35b3-43c6-b09e-44dc88c87426"),
				Name = @"Type",
				ReferenceSchemaUId = new Guid("92569be4-cc39-48a3-a577-0bdb22f31441"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("1c6cda37-90f0-4b88-a13c-af0b11cc464f"),
				ModifiedInSchemaUId = new Guid("1c6cda37-90f0-4b88-a13c-af0b11cc464f"),
				CreatedInPackageId = new Guid("5ef8c1cb-e12d-44bb-94fb-8751249ccc2c")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateCampaignStepEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateCampaignStepEventsProcessSchema() {
			var schema = new CampaignStepEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new CampaignStep(userConnection){Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new CampaignStep_CampaignsEventsProcess(userConnnection);
		}

		public override object Clone() {
			return new CampaignStepSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new CampaignStepSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("1c6cda37-90f0-4b88-a13c-af0b11cc464f"));
		}

		#endregion

	}

	#endregion

	#region Class: CampaignStep

	/// <summary>
	/// Campaign step.
	/// </summary>
	public class CampaignStep : Terrasoft.Configuration.DiagramElement
	{

		#region Constructors: Public

		public CampaignStep(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "CampaignStep";
		}

		public CampaignStep(CampaignStep source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Title.
		/// </summary>
		public  string Title {
			get {
				return GetTypedColumnValue<string>("Title");
			}
			set {
				SetColumnValue("Title", value);
			}
		}

		/// <summary>
		/// RecordId.
		/// </summary>
		public  Guid RecordId {
			get {
				return GetTypedColumnValue<Guid>("RecordId");
			}
			set {
				SetColumnValue("RecordId", value);
			}
		}

		/// <exclude/>
		public  Guid CampaignId {
			get {
				return GetTypedColumnValue<Guid>("CampaignId");
			}
			set {
				SetColumnValue("CampaignId", value);
				_campaign = null;
			}
		}

		/// <exclude/>
		public  string CampaignName {
			get {
				return GetTypedColumnValue<string>("CampaignName");
			}
			set {
				SetColumnValue("CampaignName", value);
				if (_campaign != null) {
					_campaign.Name = value;
				}
			}
		}

		private Campaign _campaign;
		/// <summary>
		/// Campaign.
		/// </summary>
		public  Campaign Campaign {
			get {
				return _campaign ??
					(_campaign = LookupColumnEntities.GetEntity("Campaign") as Campaign);
			}
		}

		/// <exclude/>
		public  Guid TypeId {
			get {
				return GetTypedColumnValue<Guid>("TypeId");
			}
			set {
				SetColumnValue("TypeId", value);
				_type = null;
			}
		}

		/// <exclude/>
		public  string TypeName {
			get {
				return GetTypedColumnValue<string>("TypeName");
			}
			set {
				SetColumnValue("TypeName", value);
				if (_type != null) {
					_type.Name = value;
				}
			}
		}

		private CampaignStepType _type;
		/// <summary>
		/// Type.
		/// </summary>
		public  CampaignStepType Type {
			get {
				return _type ??
					(_type = LookupColumnEntities.GetEntity("Type") as CampaignStepType);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new CampaignStep_CampaignsEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Loaded += (s, e) => ThrowEvent("CampaignStepLoaded", e);
			Saved += (s, e) => ThrowEvent("CampaignStepSaved", e);
			Saving += (s, e) => ThrowEvent("CampaignStepSaving", e);
			Validating += (s, e) => ThrowEvent("CampaignStepValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new CampaignStep(this);
		}

		#endregion

	}

	#endregion

	#region Class: CampaignStep_CampaignsEventsProcess

	/// <exclude/>
	public class CampaignStep_CampaignsEventsProcess<TEntity> : Terrasoft.Configuration.DiagramElement_ProcessLibraryEventsProcess<TEntity> where TEntity : CampaignStep
	{

		public CampaignStep_CampaignsEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "CampaignStep_CampaignsEventsProcess";
			SchemaUId = new Guid("1c6cda37-90f0-4b88-a13c-af0b11cc464f");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			_supportedProperties = () => {{ return "offsetX,offsetY,addInfo"; }};
			InitializeFlowElements();
		}

		#region Properties: Private

		private  Guid InternalSchemaUId {
			get {
				return new Guid("1c6cda37-90f0-4b88-a13c-af0b11cc464f");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		private Func<string> _supportedProperties;
		public override string SupportedProperties {
			get {
				return (_supportedProperties ?? (_supportedProperties = () => null)).Invoke();
			}
			set {
				_supportedProperties = () => { return value; };
			}
		}

		private ProcessFlowElement _eventSubProcess1;
		public  ProcessFlowElement EventSubProcess1 {
			get {
				return _eventSubProcess1 ?? (_eventSubProcess1 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess1",
					SchemaElementUId = new Guid("d105a583-dbbc-4e70-8a93-4138ca14e16b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _campaignStepSaving;
		public  ProcessFlowElement CampaignStepSaving {
			get {
				return _campaignStepSaving ?? (_campaignStepSaving = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "CampaignStepSaving",
					SchemaElementUId = new Guid("f0483cd5-3d24-4ac1-ab9a-1fec1bce9ffc"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _campaignStepObjSavedScriptTask;
		public  ProcessScriptTask CampaignStepObjSavedScriptTask {
			get {
				return _campaignStepObjSavedScriptTask ?? (_campaignStepObjSavedScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "CampaignStepObjSavedScriptTask",
					SchemaElementUId = new Guid("251eb785-dbc8-4eac-b98e-1c1c120cbf9a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = CampaignStepObjSavedScriptTaskExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess1.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess1 };
			FlowElements[CampaignStepSaving.SchemaElementUId] = new Collection<ProcessFlowElement> { CampaignStepSaving };
			FlowElements[CampaignStepObjSavedScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { CampaignStepObjSavedScriptTask };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess1":
						break;
					case "CampaignStepSaving":
						e.Context.QueueTasks.Enqueue("CampaignStepObjSavedScriptTask");
						break;
					case "CampaignStepObjSavedScriptTask":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("CampaignStepSaving");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "EventSubProcess1":
					context.QueueTasks.Dequeue();
					break;
				case "CampaignStepSaving":
					context.QueueTasks.Dequeue();
					context.SenderName = "CampaignStepSaving";
					result = CampaignStepSaving.Execute(context);
					break;
				case "CampaignStepObjSavedScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "CampaignStepObjSavedScriptTask";
					result = CampaignStepObjSavedScriptTask.Execute(context, CampaignStepObjSavedScriptTaskExecute);
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

		public virtual bool CampaignStepObjSavedScriptTaskExecute(ProcessExecutingContext context) {
			return SavedMethod(context);
		}

		public virtual bool SavedMethod(ProcessExecutingContext context) {
			if (!Entity.Schema.Columns.Any(column => column.Name == "RecordId")) {
				return true;
			}
			Guid oldRecordId = Entity.GetTypedOldColumnValue<Guid>("RecordId");
			Guid newRecordId = Entity.GetTypedColumnValue<Guid>("RecordId");
			if(oldRecordId == newRecordId) {
				return true;
			}
			var typeUId = Entity.GetTypedColumnValue<Guid>("TypeId");
			if(typeUId.Equals(CampaignConsts.LendingCampaignStepTypeId)) {
				return true;
			}
			var campaignTypeSysSchemaUIdQuery = new Select(UserConnection)
				.Column("SysSchemaUId")
				.From("CampaignStepType")
				.Where("Id").IsEqual(Column.Parameter(typeUId));
			
			Guid sysSchemaUId = (campaignTypeSysSchemaUIdQuery as Select).ExecuteScalar<Guid>();
			var schema = UserConnection.EntitySchemaManager.GetInstanceByUId(sysSchemaUId);
			
			if(oldRecordId != Guid.Empty) {
				var updateOldQuery = new Update(UserConnection, schema.Name)
					.Set("CampaignId", Column.Const(null))
					.Where(schema.PrimaryColumn.Name).IsEqual(Column.Parameter(oldRecordId));
				updateOldQuery.Execute();
			}
			
			if(newRecordId != Guid.Empty) {
				var updateNewQuery = new Update(UserConnection, schema.Name)
					.Set("CampaignId", Column.Parameter(Entity.GetTypedColumnValue<Guid>("CampaignId")))
					.Where(schema.PrimaryColumn.Name).IsEqual(Column.Parameter(newRecordId));
				updateNewQuery.Execute();
			}
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "CampaignStepSaving":
							if (ActivatedEventElements.Contains("CampaignStepSaving")) {
							context.QueueTasks.Enqueue("CampaignStepSaving");
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

	#region Class: CampaignStep_CampaignsEventsProcess

	/// <exclude/>
	public class CampaignStep_CampaignsEventsProcess : CampaignStep_CampaignsEventsProcess<CampaignStep>
	{

		public CampaignStep_CampaignsEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: CampaignStepEventsProcessSchema

	/// <exclude/>
	public class CampaignStepEventsProcessSchema : Terrasoft.Configuration.DiagramElementEventsProcessSchema
	{

		#region Constructors: Public

		public CampaignStepEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public CampaignStepEventsProcessSchema(CampaignStepEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "CampaignStep_CampaignsEventsProcess";
			UId = new Guid("6bab6b48-1b11-48d5-b319-9cfed3d7462e");
			CreatedInPackageId = new Guid("5ef8c1cb-e12d-44bb-94fb-8751249ccc2c");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("e42c262c-387c-49a1-a30f-43fb7c4237a7");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
		}

		protected override ProcessSchemaParameter CreateSupportedPropertiesParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("ec29dad5-6924-41ff-8cf5-dcaf425bbe4e"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("e42c262c-387c-49a1-a30f-43fb7c4237a7"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("e42c262c-387c-49a1-a30f-43fb7c4237a7"),
				Name = @"SupportedProperties",
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("6bab6b48-1b11-48d5-b319-9cfed3d7462e"),
				},
			};
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
			ProcessSchemaEventSubProcess eventsubprocess1 = CreateEventSubProcess1EventSubProcess();
			FlowElements.Add(eventsubprocess1);
			ProcessSchemaStartMessageEvent campaignstepsaving = CreateCampaignStepSavingStartMessageEvent();
			eventsubprocess1.FlowElements.Add(campaignstepsaving);
			ProcessSchemaScriptTask campaignstepobjsavedscripttask = CreateCampaignStepObjSavedScriptTaskScriptTask();
			eventsubprocess1.FlowElements.Add(campaignstepobjsavedscripttask);
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("425fcbe9-d952-4826-8df6-290abe34ce01"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("e42c262c-387c-49a1-a30f-43fb7c4237a7"),
				CreatedInPackageId = new Guid("99b5f9a8-cf5d-45be-a343-69b2dafeaaa7"),
				CreatedInSchemaUId = new Guid("6bab6b48-1b11-48d5-b319-9cfed3d7462e"),
				CurveCenterPosition = new Point(204, 78),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("6bab6b48-1b11-48d5-b319-9cfed3d7462e"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("f0483cd5-3d24-4ac1-ab9a-1fec1bce9ffc"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("251eb785-dbc8-4eac-b98e-1c1c120cbf9a"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("93aaeb4f-fc4b-4dfa-8159-0c892e95d72d"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("e42c262c-387c-49a1-a30f-43fb7c4237a7"),
				CreatedInPackageId = new Guid("99b5f9a8-cf5d-45be-a343-69b2dafeaaa7"),
				CreatedInSchemaUId = new Guid("6bab6b48-1b11-48d5-b319-9cfed3d7462e"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("6bab6b48-1b11-48d5-b319-9cfed3d7462e"),
				Name = @"LaneSet1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(5, 5),
				Size = new Size(1039, 177),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("e3e68752-81c8-4d12-8c9b-0c22640bef34"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("93aaeb4f-fc4b-4dfa-8159-0c892e95d72d"),
				CreatedInOwnerSchemaUId = new Guid("1c6cda37-90f0-4b88-a13c-af0b11cc464f"),
				CreatedInPackageId = new Guid("99b5f9a8-cf5d-45be-a343-69b2dafeaaa7"),
				CreatedInSchemaUId = new Guid("6bab6b48-1b11-48d5-b319-9cfed3d7462e"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("6bab6b48-1b11-48d5-b319-9cfed3d7462e"),
				Name = @"Lane1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(29, 0),
				Size = new Size(1010, 177),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess1EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess1 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("d105a583-dbbc-4e70-8a93-4138ca14e16b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e3e68752-81c8-4d12-8c9b-0c22640bef34"),
				CreatedInOwnerSchemaUId = new Guid("e42c262c-387c-49a1-a30f-43fb7c4237a7"),
				CreatedInPackageId = new Guid("99b5f9a8-cf5d-45be-a343-69b2dafeaaa7"),
				CreatedInSchemaUId = new Guid("6bab6b48-1b11-48d5-b319-9cfed3d7462e"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("6bab6b48-1b11-48d5-b319-9cfed3d7462e"),
				Name = @"EventSubProcess1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(36, 9),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(315, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess1;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateCampaignStepSavingStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("f0483cd5-3d24-4ac1-ab9a-1fec1bce9ffc"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d105a583-dbbc-4e70-8a93-4138ca14e16b"),
				CreatedInOwnerSchemaUId = new Guid("e42c262c-387c-49a1-a30f-43fb7c4237a7"),
				CreatedInPackageId = new Guid("99b5f9a8-cf5d-45be-a343-69b2dafeaaa7"),
				CreatedInSchemaUId = new Guid("6bab6b48-1b11-48d5-b319-9cfed3d7462e"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"CampaignStepSaving",
				ModifiedInSchemaUId = new Guid("6bab6b48-1b11-48d5-b319-9cfed3d7462e"),
				Name = @"CampaignStepSaving",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(36, 58),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateCampaignStepObjSavedScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("251eb785-dbc8-4eac-b98e-1c1c120cbf9a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d105a583-dbbc-4e70-8a93-4138ca14e16b"),
				CreatedInOwnerSchemaUId = new Guid("e42c262c-387c-49a1-a30f-43fb7c4237a7"),
				CreatedInPackageId = new Guid("99b5f9a8-cf5d-45be-a343-69b2dafeaaa7"),
				CreatedInSchemaUId = new Guid("6bab6b48-1b11-48d5-b319-9cfed3d7462e"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("6bab6b48-1b11-48d5-b319-9cfed3d7462e"),
				Name = @"CampaignStepObjSavedScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(197, 44),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,8,78,44,75,77,241,77,45,201,200,79,209,72,206,207,43,73,173,40,209,180,6,0,187,253,203,9,28,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateSavedMethodMethod());
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
				UId = new Guid("508f7fb7-a5c3-49dd-be14-119dec42069b"),
				Name = "Newtonsoft.Json.Linq",
				Alias = "",
				CreatedInPackageId = new Guid("5ef8c1cb-e12d-44bb-94fb-8751249ccc2c")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("6663ee52-2b09-4be7-94e3-45fb682acae9"),
				Name = "System.Linq",
				Alias = "",
				CreatedInPackageId = new Guid("5ef8c1cb-e12d-44bb-94fb-8751249ccc2c")
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

		protected virtual SchemaMethod CreateSavedMethodMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("ce238c86-0387-4b9a-a2b7-1eacc72476e8"),
				Name = "SavedMethod",
				CreatedInSchemaUId = new Guid("6bab6b48-1b11-48d5-b319-9cfed3d7462e"),
				CreatedInPackageId = new Guid("99b5f9a8-cf5d-45be-a343-69b2dafeaaa7"),
				ResultValueTypeName = "bool"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("bdc3ed47-59e2-4165-bd14-a6f56d7bc297"),
				Name = "context",
				CreatedInSchemaUId = new Guid("6bab6b48-1b11-48d5-b319-9cfed3d7462e"),
				ModifiedInSchemaUId = new Guid("6bab6b48-1b11-48d5-b319-9cfed3d7462e"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "ProcessExecutingContext",
				CreatedInPackageId = new Guid("99b5f9a8-cf5d-45be-a343-69b2dafeaaa7")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,83,91,75,195,48,20,126,222,96,255,33,246,41,5,201,31,152,29,232,152,99,224,101,90,167,207,161,61,206,66,154,214,92,156,69,246,223,205,173,44,27,108,10,250,22,146,115,190,219,201,169,94,17,62,155,113,85,169,142,228,197,27,212,148,76,27,166,107,46,201,37,239,112,225,206,40,155,32,127,34,119,180,6,148,101,40,121,132,162,17,229,162,76,210,20,125,141,134,3,1,74,11,142,148,208,48,30,13,183,163,225,92,87,37,106,88,217,23,162,12,5,158,57,168,167,174,133,242,158,149,158,235,153,50,13,23,182,97,130,35,224,113,0,225,176,57,14,242,19,66,245,138,247,68,100,49,220,17,233,31,84,32,101,192,87,191,36,180,247,59,186,208,73,102,239,154,50,137,167,180,110,105,181,230,211,134,75,37,201,13,240,178,226,235,254,54,87,208,250,246,99,57,90,49,69,168,182,149,121,39,253,160,12,199,131,6,209,33,103,9,229,192,160,80,120,37,65,24,42,110,206,85,195,83,131,24,6,138,147,184,51,113,47,215,162,169,113,114,168,197,191,189,188,129,0,156,216,82,178,144,206,12,246,72,100,73,133,249,6,10,68,239,53,181,214,195,180,100,196,98,164,225,211,218,169,12,194,83,50,251,132,66,43,200,11,202,168,8,209,90,92,27,128,116,93,6,110,223,30,241,179,241,152,183,148,211,53,8,59,168,133,137,154,242,2,174,58,67,132,99,69,94,232,193,167,56,203,144,165,35,179,186,85,157,31,131,37,213,109,73,21,152,95,26,199,188,114,151,7,49,159,7,129,110,61,108,122,3,146,131,218,37,107,66,60,71,33,60,247,15,48,215,140,165,190,210,7,29,0,150,162,170,169,232,166,187,109,59,145,126,228,193,77,96,176,175,184,79,212,165,184,13,190,227,101,58,233,251,14,54,255,234,123,39,251,231,133,138,250,211,63,167,20,239,123,148,82,239,239,48,165,120,1,191,1,39,173,177,200,30,5,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new CampaignStepEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("6bab6b48-1b11-48d5-b319-9cfed3d7462e"));
		}

		#endregion

	}

	#endregion


	#region Class: CampaignStepEventsProcess

	/// <exclude/>
	public class CampaignStepEventsProcess : CampaignStep_CampaignsEventsProcess
	{

		public CampaignStepEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

