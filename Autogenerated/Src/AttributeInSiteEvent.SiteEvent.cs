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

	#region Class: AttributeInSiteEvent_SiteEvent_TerrasoftSchema

	/// <exclude/>
	public class AttributeInSiteEvent_SiteEvent_TerrasoftSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public AttributeInSiteEvent_SiteEvent_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public AttributeInSiteEvent_SiteEvent_TerrasoftSchema(AttributeInSiteEvent_SiteEvent_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public AttributeInSiteEvent_SiteEvent_TerrasoftSchema(AttributeInSiteEvent_SiteEvent_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("6839c7b8-f847-4cef-81cd-6554e7502730");
			RealUId = new Guid("6839c7b8-f847-4cef-81cd-6554e7502730");
			Name = "AttributeInSiteEvent_SiteEvent_Terrasoft";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("2a23e39e-fab7-43e0-a89e-cc22e5c8d6ed");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializePrimaryDisplayColumn() {
			base.InitializePrimaryDisplayColumn();
			PrimaryDisplayColumn = CreateStringValueColumn();
			if (Columns.FindByUId(PrimaryDisplayColumn.UId) == null) {
				Columns.Add(PrimaryDisplayColumn);
			}
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("0090b19c-a4c7-4715-afb2-2fb6d716930a")) == null) {
				Columns.Add(CreateSiteEventAttributeColumn());
			}
			if (Columns.FindByUId(new Guid("dbab435f-266f-4e00-ba8b-ff4facac9f2a")) == null) {
				Columns.Add(CreateListItemValueColumn());
			}
			if (Columns.FindByUId(new Guid("4b78b2c5-72f6-4a34-ba9c-d4b0a2c61344")) == null) {
				Columns.Add(CreateIntValueColumn());
			}
			if (Columns.FindByUId(new Guid("c5411baa-4254-440c-9e1a-49a8d5ed1168")) == null) {
				Columns.Add(CreateFloatValueColumn());
			}
			if (Columns.FindByUId(new Guid("8beac038-2db4-4e2f-8355-626cd444bc4a")) == null) {
				Columns.Add(CreateBooleanValueColumn());
			}
			if (Columns.FindByUId(new Guid("ee940c14-92c8-46b4-a4d5-7ff3fd0d2c58")) == null) {
				Columns.Add(CreateProductValueColumn());
			}
			if (Columns.FindByUId(new Guid("bd85be31-baf9-4352-8755-6a7f426898e2")) == null) {
				Columns.Add(CreateSiteEventColumn());
			}
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.ModifiedInSchemaUId = new Guid("6839c7b8-f847-4cef-81cd-6554e7502730");
			column.CreatedInPackageId = new Guid("2a23e39e-fab7-43e0-a89e-cc22e5c8d6ed");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.ModifiedInSchemaUId = new Guid("6839c7b8-f847-4cef-81cd-6554e7502730");
			column.CreatedInPackageId = new Guid("2a23e39e-fab7-43e0-a89e-cc22e5c8d6ed");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.ModifiedInSchemaUId = new Guid("6839c7b8-f847-4cef-81cd-6554e7502730");
			column.CreatedInPackageId = new Guid("2a23e39e-fab7-43e0-a89e-cc22e5c8d6ed");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.ModifiedInSchemaUId = new Guid("6839c7b8-f847-4cef-81cd-6554e7502730");
			column.CreatedInPackageId = new Guid("2a23e39e-fab7-43e0-a89e-cc22e5c8d6ed");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.ModifiedInSchemaUId = new Guid("6839c7b8-f847-4cef-81cd-6554e7502730");
			column.CreatedInPackageId = new Guid("2a23e39e-fab7-43e0-a89e-cc22e5c8d6ed");
			return column;
		}

		protected override EntitySchemaColumn CreateProcessListenersColumn() {
			EntitySchemaColumn column = base.CreateProcessListenersColumn();
			column.ModifiedInSchemaUId = new Guid("6839c7b8-f847-4cef-81cd-6554e7502730");
			column.CreatedInPackageId = new Guid("2a23e39e-fab7-43e0-a89e-cc22e5c8d6ed");
			return column;
		}

		protected virtual EntitySchemaColumn CreateSiteEventAttributeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("0090b19c-a4c7-4715-afb2-2fb6d716930a"),
				Name = @"SiteEventAttribute",
				ReferenceSchemaUId = new Guid("f65a195e-31b6-4db8-93a8-e7985f482c14"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("6839c7b8-f847-4cef-81cd-6554e7502730"),
				ModifiedInSchemaUId = new Guid("6839c7b8-f847-4cef-81cd-6554e7502730"),
				CreatedInPackageId = new Guid("2a23e39e-fab7-43e0-a89e-cc22e5c8d6ed")
			};
		}

		protected virtual EntitySchemaColumn CreateListItemValueColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("dbab435f-266f-4e00-ba8b-ff4facac9f2a"),
				Name = @"ListItemValue",
				ReferenceSchemaUId = new Guid("0db0c5bb-0ff9-4e93-81a3-30451163dbb8"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("6839c7b8-f847-4cef-81cd-6554e7502730"),
				ModifiedInSchemaUId = new Guid("6839c7b8-f847-4cef-81cd-6554e7502730"),
				CreatedInPackageId = new Guid("2a23e39e-fab7-43e0-a89e-cc22e5c8d6ed")
			};
		}

		protected virtual EntitySchemaColumn CreateStringValueColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("LongText")) {
				UId = new Guid("77e7695a-bacb-4e76-8308-8e6a04a9476c"),
				Name = @"StringValue",
				CreatedInSchemaUId = new Guid("6839c7b8-f847-4cef-81cd-6554e7502730"),
				ModifiedInSchemaUId = new Guid("6839c7b8-f847-4cef-81cd-6554e7502730"),
				CreatedInPackageId = new Guid("2a23e39e-fab7-43e0-a89e-cc22e5c8d6ed")
			};
		}

		protected virtual EntitySchemaColumn CreateIntValueColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("4b78b2c5-72f6-4a34-ba9c-d4b0a2c61344"),
				Name = @"IntValue",
				CreatedInSchemaUId = new Guid("6839c7b8-f847-4cef-81cd-6554e7502730"),
				ModifiedInSchemaUId = new Guid("6839c7b8-f847-4cef-81cd-6554e7502730"),
				CreatedInPackageId = new Guid("2a23e39e-fab7-43e0-a89e-cc22e5c8d6ed")
			};
		}

		protected virtual EntitySchemaColumn CreateFloatValueColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float2")) {
				UId = new Guid("c5411baa-4254-440c-9e1a-49a8d5ed1168"),
				Name = @"FloatValue",
				CreatedInSchemaUId = new Guid("6839c7b8-f847-4cef-81cd-6554e7502730"),
				ModifiedInSchemaUId = new Guid("6839c7b8-f847-4cef-81cd-6554e7502730"),
				CreatedInPackageId = new Guid("2a23e39e-fab7-43e0-a89e-cc22e5c8d6ed")
			};
		}

		protected virtual EntitySchemaColumn CreateBooleanValueColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("8beac038-2db4-4e2f-8355-626cd444bc4a"),
				Name = @"BooleanValue",
				CreatedInSchemaUId = new Guid("6839c7b8-f847-4cef-81cd-6554e7502730"),
				ModifiedInSchemaUId = new Guid("6839c7b8-f847-4cef-81cd-6554e7502730"),
				CreatedInPackageId = new Guid("2a23e39e-fab7-43e0-a89e-cc22e5c8d6ed")
			};
		}

		protected virtual EntitySchemaColumn CreateProductValueColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("ee940c14-92c8-46b4-a4d5-7ff3fd0d2c58"),
				Name = @"ProductValue",
				ReferenceSchemaUId = new Guid("4c7a6ead-4eb8-4fc0-863e-98a664569fed"),
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("6839c7b8-f847-4cef-81cd-6554e7502730"),
				ModifiedInSchemaUId = new Guid("6839c7b8-f847-4cef-81cd-6554e7502730"),
				CreatedInPackageId = new Guid("2a23e39e-fab7-43e0-a89e-cc22e5c8d6ed")
			};
		}

		protected virtual EntitySchemaColumn CreateSiteEventColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("bd85be31-baf9-4352-8755-6a7f426898e2"),
				Name = @"SiteEvent",
				ReferenceSchemaUId = new Guid("93a880c8-dea8-47d5-9b79-1d7fd8259ca0"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("6839c7b8-f847-4cef-81cd-6554e7502730"),
				ModifiedInSchemaUId = new Guid("6839c7b8-f847-4cef-81cd-6554e7502730"),
				CreatedInPackageId = new Guid("2a23e39e-fab7-43e0-a89e-cc22e5c8d6ed")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateAttributeInSiteEvent_SiteEvent_TerrasoftEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateAttributeInSiteEvent_SiteEvent_TerrasoftEventsProcessSchema() {
			var schema = new AttributeInSiteEvent_SiteEvent_TerrasoftEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new AttributeInSiteEvent_SiteEvent_Terrasoft(userConnection){Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new AttributeInSiteEvent_SiteEventEventsProcess(userConnnection);
		}

		public override object Clone() {
			return new AttributeInSiteEvent_SiteEvent_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new AttributeInSiteEvent_SiteEvent_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("6839c7b8-f847-4cef-81cd-6554e7502730"));
		}

		#endregion

	}

	#endregion

	#region Class: AttributeInSiteEvent_SiteEvent_Terrasoft

	/// <summary>
	/// Attribute in site event.
	/// </summary>
	public class AttributeInSiteEvent_SiteEvent_Terrasoft : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public AttributeInSiteEvent_SiteEvent_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "AttributeInSiteEvent_SiteEvent_Terrasoft";
		}

		public AttributeInSiteEvent_SiteEvent_Terrasoft(AttributeInSiteEvent_SiteEvent_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public  Guid SiteEventAttributeId {
			get {
				return GetTypedColumnValue<Guid>("SiteEventAttributeId");
			}
			set {
				SetColumnValue("SiteEventAttributeId", value);
				_siteEventAttribute = null;
			}
		}

		/// <exclude/>
		public  string SiteEventAttributeName {
			get {
				return GetTypedColumnValue<string>("SiteEventAttributeName");
			}
			set {
				SetColumnValue("SiteEventAttributeName", value);
				if (_siteEventAttribute != null) {
					_siteEventAttribute.Name = value;
				}
			}
		}

		private SiteEventAttribute _siteEventAttribute;
		/// <summary>
		/// Attribute.
		/// </summary>
		public  SiteEventAttribute SiteEventAttribute {
			get {
				return _siteEventAttribute ??
					(_siteEventAttribute = LookupColumnEntities.GetEntity("SiteEventAttribute") as SiteEventAttribute);
			}
		}

		/// <exclude/>
		public  Guid ListItemValueId {
			get {
				return GetTypedColumnValue<Guid>("ListItemValueId");
			}
			set {
				SetColumnValue("ListItemValueId", value);
				_listItemValue = null;
			}
		}

		/// <exclude/>
		public  string ListItemValueName {
			get {
				return GetTypedColumnValue<string>("ListItemValueName");
			}
			set {
				SetColumnValue("ListItemValueName", value);
				if (_listItemValue != null) {
					_listItemValue.Name = value;
				}
			}
		}

		private SiteEventAttrListItem _listItemValue;
		/// <summary>
		/// Value(list).
		/// </summary>
		public  SiteEventAttrListItem ListItemValue {
			get {
				return _listItemValue ??
					(_listItemValue = LookupColumnEntities.GetEntity("ListItemValue") as SiteEventAttrListItem);
			}
		}

		/// <summary>
		/// Value.
		/// </summary>
		public  string StringValue {
			get {
				return GetTypedColumnValue<string>("StringValue");
			}
			set {
				SetColumnValue("StringValue", value);
			}
		}

		/// <summary>
		/// Value(numerical).
		/// </summary>
		public  int IntValue {
			get {
				return GetTypedColumnValue<int>("IntValue");
			}
			set {
				SetColumnValue("IntValue", value);
			}
		}

		/// <summary>
		/// Value(Decimal).
		/// </summary>
		public  Decimal FloatValue {
			get {
				return GetTypedColumnValue<Decimal>("FloatValue");
			}
			set {
				SetColumnValue("FloatValue", value);
			}
		}

		/// <summary>
		/// Value (Boolean).
		/// </summary>
		public  bool BooleanValue {
			get {
				return GetTypedColumnValue<bool>("BooleanValue");
			}
			set {
				SetColumnValue("BooleanValue", value);
			}
		}

		/// <exclude/>
		public  Guid ProductValueId {
			get {
				return GetTypedColumnValue<Guid>("ProductValueId");
			}
			set {
				SetColumnValue("ProductValueId", value);
				_productValue = null;
			}
		}

		/// <exclude/>
		public  string ProductValueName {
			get {
				return GetTypedColumnValue<string>("ProductValueName");
			}
			set {
				SetColumnValue("ProductValueName", value);
				if (_productValue != null) {
					_productValue.Name = value;
				}
			}
		}

		private Product _productValue;
		/// <summary>
		/// Connected to product.
		/// </summary>
		public  Product ProductValue {
			get {
				return _productValue ??
					(_productValue = LookupColumnEntities.GetEntity("ProductValue") as Product);
			}
		}

		/// <exclude/>
		public  Guid SiteEventId {
			get {
				return GetTypedColumnValue<Guid>("SiteEventId");
			}
			set {
				SetColumnValue("SiteEventId", value);
				_siteEvent = null;
			}
		}

		/// <exclude/>
		public  string SiteEventSource {
			get {
				return GetTypedColumnValue<string>("SiteEventSource");
			}
			set {
				SetColumnValue("SiteEventSource", value);
				if (_siteEvent != null) {
					_siteEvent.Source = value;
				}
			}
		}

		private SiteEvent _siteEvent;
		/// <summary>
		/// Website event.
		/// </summary>
		public  SiteEvent SiteEvent {
			get {
				return _siteEvent ??
					(_siteEvent = LookupColumnEntities.GetEntity("SiteEvent") as SiteEvent);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new AttributeInSiteEvent_SiteEventEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Saving += (s, e) => ThrowEvent("AttributeInSiteEvent_SiteEvent_TerrasoftSaving", e);
			Validating += (s, e) => ThrowEvent("AttributeInSiteEvent_SiteEvent_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new AttributeInSiteEvent_SiteEvent_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: AttributeInSiteEvent_SiteEventEventsProcess

	/// <exclude/>
	public class AttributeInSiteEvent_SiteEventEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_LocalMessageEventsProcess<TEntity> where TEntity : AttributeInSiteEvent_SiteEvent_Terrasoft
	{

		public AttributeInSiteEvent_SiteEventEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "AttributeInSiteEvent_SiteEventEventsProcess";
			SchemaUId = new Guid("6839c7b8-f847-4cef-81cd-6554e7502730");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private  Guid InternalSchemaUId {
			get {
				return new Guid("6839c7b8-f847-4cef-81cd-6554e7502730");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		private ProcessFlowElement _attributeInSiteEventSavingEventSubProcess;
		public  ProcessFlowElement AttributeInSiteEventSavingEventSubProcess {
			get {
				return _attributeInSiteEventSavingEventSubProcess ?? (_attributeInSiteEventSavingEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "AttributeInSiteEventSavingEventSubProcess",
					SchemaElementUId = new Guid("fd75d034-bfcc-4cfd-b167-d0b4571ec8f9"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _attributeInSiteEventSaving;
		public  ProcessFlowElement AttributeInSiteEventSaving {
			get {
				return _attributeInSiteEventSaving ?? (_attributeInSiteEventSaving = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "AttributeInSiteEventSaving",
					SchemaElementUId = new Guid("22021ce1-96a2-4e1a-880d-57ef0c34fba4"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _attributeInSiteEventSavingScriptTask;
		public  ProcessScriptTask AttributeInSiteEventSavingScriptTask {
			get {
				return _attributeInSiteEventSavingScriptTask ?? (_attributeInSiteEventSavingScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "AttributeInSiteEventSavingScriptTask",
					SchemaElementUId = new Guid("6803870e-dcee-4fbc-914d-dfcdf4a77a45"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = AttributeInSiteEventSavingScriptTaskExecute,
				});
			}
		}

		private LocalizableString _yes;
		public  LocalizableString Yes {
			get {
				return _yes ?? (_yes = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.Yes.Value"));
			}
		}

		private LocalizableString _no;
		public  LocalizableString No {
			get {
				return _no ?? (_no = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.No.Value"));
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[AttributeInSiteEventSavingEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { AttributeInSiteEventSavingEventSubProcess };
			FlowElements[AttributeInSiteEventSaving.SchemaElementUId] = new Collection<ProcessFlowElement> { AttributeInSiteEventSaving };
			FlowElements[AttributeInSiteEventSavingScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { AttributeInSiteEventSavingScriptTask };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "AttributeInSiteEventSavingEventSubProcess":
						break;
					case "AttributeInSiteEventSaving":
						e.Context.QueueTasks.Enqueue("AttributeInSiteEventSavingScriptTask");
						break;
					case "AttributeInSiteEventSavingScriptTask":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("AttributeInSiteEventSaving");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "AttributeInSiteEventSavingEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "AttributeInSiteEventSaving":
					context.QueueTasks.Dequeue();
					context.SenderName = "AttributeInSiteEventSaving";
					result = AttributeInSiteEventSaving.Execute(context);
					break;
				case "AttributeInSiteEventSavingScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "AttributeInSiteEventSavingScriptTask";
					result = AttributeInSiteEventSavingScriptTask.Execute(context, AttributeInSiteEventSavingScriptTaskExecute);
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

		public virtual bool AttributeInSiteEventSavingScriptTaskExecute(ProcessExecutingContext context) {
			FillStringValue();
			return true;
		}

		public virtual bool FillStringValue() {
			// Convert attribute value to StringValue
			var attributeTypeId = string.Empty;
			var attributeValue = string.Empty;
			
			if (Entity.SiteEventAttributeId == Guid.Empty) {
				return true;
			};
			
			var esqResult = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "SiteEventAttribute");
			esqResult.AddColumn("Type");
			var attributeEntity = esqResult.GetEntity(UserConnection, Entity.SiteEventAttributeId);
			attributeTypeId = attributeEntity.GetTypedColumnValue<string>("TypeId");
			
			// if not string value
			if (attributeTypeId != "e9da1be2-b0b9-478f-8290-b84a0091ec81") {
				Entity.SetColumnValue("StringValue", string.Empty);
			};
			
			switch(attributeTypeId) {
				// string type
				case ("e9da1be2-b0b9-478f-8290-b84a0091ec81"):
					Entity.SetColumnValue("IntValue", 0);
					Entity.SetColumnValue("FloatValue", 0.0);
					Entity.SetColumnValue("BooleanValue", false);
					Entity.SetColumnValue("ListItemValueId", null);
					Entity.SetColumnValue("ProductValueId", null);
					return true;
				// int type
				case ("30dc6786-9179-4e6c-9e09-3c00b98bd3ef"):
					attributeValue = Entity.GetTypedColumnValue<string>("IntValue");
					Entity.SetColumnValue("FloatValue", 0.0);
					Entity.SetColumnValue("BooleanValue", false);
					Entity.SetColumnValue("ListItemValueId", null);
					Entity.SetColumnValue("ProductValueId", null);
					break;
				// float type
				case ("21b7b386-0ce4-48d3-9b4d-6616407dedb0"):
					attributeValue = Entity.GetTypedColumnValue<string>("FloatValue");
					Entity.SetColumnValue("IntValue", 0);
					Entity.SetColumnValue("BooleanValue", false);
					Entity.SetColumnValue("ListItemValueId", null);
					Entity.SetColumnValue("ProductValueId", null);
					break;
				// boolean type
				case ("5762dce0-54fd-4da5-859d-323003b8a9e2"):
					if (Entity.GetTypedColumnValue<bool>("BooleanValue")) {
						attributeValue = Yes.ToString();
					} else {
						attributeValue = No.ToString();
					}
					Entity.SetColumnValue("FloatValue", 0.0);
					Entity.SetColumnValue("IntValue", 0);
					Entity.SetColumnValue("ListItemValueId", null);
					Entity.SetColumnValue("ProductValueId", null);
					break;
				// list item value
				case ("23332960-c76a-4c53-a4e6-f0447b8d0018"):
					Entity.SetColumnValue("IntValue", 0);
					Entity.SetColumnValue("FloatValue", 0.0);
					Entity.SetColumnValue("BooleanValue", false);
					Entity.SetColumnValue("ProductValueId", null);
					attributeValue = GetColumnDisplayValue("SiteEventAttrListItem", Entity.ListItemValueId);
					break;
				//product value
				case ("28979594-4b11-4bd8-86d2-f2252f508edd"):
					Entity.SetColumnValue("BooleanValue", false);
					Entity.SetColumnValue("FloatValue", 0.0);
					Entity.SetColumnValue("IntValue", 0);
					Entity.SetColumnValue("ListItemValueId", null);
					attributeValue = GetColumnDisplayValue("Product", Entity.ProductValueId);
					break;
				default: return true;
			};
			Entity.SetColumnValue("StringValue", attributeValue);
			return true;
		}

		public virtual string GetColumnDisplayValue(string schemaName, Guid schemaPrimaryColumnId) {
			EntitySchema schema = UserConnection.EntitySchemaManager.GetInstanceByName(schemaName);
			Entity entity = schema.CreateEntity(UserConnection);
			var columnsToFetch = new[] {
				schema.PrimaryColumn,
				schema.PrimaryDisplayColumn
			};
			if (entity.FetchFromDB(schema.PrimaryColumn, schemaPrimaryColumnId, columnsToFetch))
			{
				return entity.PrimaryDisplayColumnValue;
			}
			return String.Empty;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "AttributeInSiteEvent_SiteEvent_TerrasoftSaving":
							if (ActivatedEventElements.Contains("AttributeInSiteEventSaving")) {
							context.QueueTasks.Enqueue("AttributeInSiteEventSaving");
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

	#region Class: AttributeInSiteEvent_SiteEventEventsProcess

	/// <exclude/>
	public class AttributeInSiteEvent_SiteEventEventsProcess : AttributeInSiteEvent_SiteEventEventsProcess<AttributeInSiteEvent_SiteEvent_Terrasoft>
	{

		public AttributeInSiteEvent_SiteEventEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: AttributeInSiteEvent_SiteEvent_TerrasoftEventsProcessSchema

	/// <exclude/>
	public class AttributeInSiteEvent_SiteEvent_TerrasoftEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public AttributeInSiteEvent_SiteEvent_TerrasoftEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public AttributeInSiteEvent_SiteEvent_TerrasoftEventsProcessSchema(AttributeInSiteEvent_SiteEvent_TerrasoftEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "AttributeInSiteEvent_SiteEventEventsProcess";
			UId = new Guid("04a720c2-28c1-4507-aeb1-7555c4370f96");
			CreatedInPackageId = new Guid("2a23e39e-fab7-43e0-a89e-cc22e5c8d6ed");
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
			ProcessSchemaLaneSet schemaLaneSet1 = CreateLaneSet1LaneSet();
			LaneSets.Add(schemaLaneSet1);
			ProcessSchemaLane schemaAttributeInSiteEventSavingScriptTaskLane = CreateAttributeInSiteEventSavingScriptTaskLaneLane();
			schemaLaneSet1.Lanes.Add(schemaAttributeInSiteEventSavingScriptTaskLane);
			ProcessSchemaEventSubProcess attributeinsiteeventsavingeventsubprocess = CreateAttributeInSiteEventSavingEventSubProcessEventSubProcess();
			FlowElements.Add(attributeinsiteeventsavingeventsubprocess);
			ProcessSchemaStartMessageEvent attributeinsiteeventsaving = CreateAttributeInSiteEventSavingStartMessageEvent();
			attributeinsiteeventsavingeventsubprocess.FlowElements.Add(attributeinsiteeventsaving);
			ProcessSchemaScriptTask attributeinsiteeventsavingscripttask = CreateAttributeInSiteEventSavingScriptTaskScriptTask();
			attributeinsiteeventsavingeventsubprocess.FlowElements.Add(attributeinsiteeventsavingscripttask);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateYesLocalizableString());
			LocalizableStrings.Add(CreateNoLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateYesLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("61d575ee-253c-45f1-b878-5b783e96b706"),
				Name = "Yes",
				CreatedInPackageId = new Guid("2a23e39e-fab7-43e0-a89e-cc22e5c8d6ed"),
				CreatedInSchemaUId = new Guid("04a720c2-28c1-4507-aeb1-7555c4370f96"),
				ModifiedInSchemaUId = new Guid("04a720c2-28c1-4507-aeb1-7555c4370f96")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateNoLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("d56aa4d7-183d-443a-9c44-def789251042"),
				Name = "No",
				CreatedInPackageId = new Guid("2a23e39e-fab7-43e0-a89e-cc22e5c8d6ed"),
				CreatedInSchemaUId = new Guid("04a720c2-28c1-4507-aeb1-7555c4370f96"),
				ModifiedInSchemaUId = new Guid("04a720c2-28c1-4507-aeb1-7555c4370f96")
			};
			return localizableString;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("5e41b08c-cabf-4370-aedd-ecf50e514387"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("2a23e39e-fab7-43e0-a89e-cc22e5c8d6ed"),
				CreatedInSchemaUId = new Guid("04a720c2-28c1-4507-aeb1-7555c4370f96"),
				CurveCenterPosition = new Point(152, 104),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("04a720c2-28c1-4507-aeb1-7555c4370f96"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("22021ce1-96a2-4e1a-880d-57ef0c34fba4"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("6803870e-dcee-4fbc-914d-dfcdf4a77a45"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("b6da9981-5935-47bb-89a5-0c8cb679d6cd"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("2a23e39e-fab7-43e0-a89e-cc22e5c8d6ed"),
				CreatedInSchemaUId = new Guid("04a720c2-28c1-4507-aeb1-7555c4370f96"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("04a720c2-28c1-4507-aeb1-7555c4370f96"),
				Name = @"LaneSet1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(5, 5),
				Size = new Size(926, 186),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateAttributeInSiteEventSavingScriptTaskLaneLane() {
			ProcessSchemaLane schemaAttributeInSiteEventSavingScriptTaskLane = new ProcessSchemaLane(this) {
				UId = new Guid("aa8c840d-2379-4323-8fde-f4170b340580"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("b6da9981-5935-47bb-89a5-0c8cb679d6cd"),
				CreatedInOwnerSchemaUId = new Guid("6839c7b8-f847-4cef-81cd-6554e7502730"),
				CreatedInPackageId = new Guid("2a23e39e-fab7-43e0-a89e-cc22e5c8d6ed"),
				CreatedInSchemaUId = new Guid("04a720c2-28c1-4507-aeb1-7555c4370f96"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("04a720c2-28c1-4507-aeb1-7555c4370f96"),
				Name = @"AttributeInSiteEventSavingScriptTaskLane",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(29, 0),
				Size = new Size(897, 186),
				UseBackgroundMode = false
			};
			return schemaAttributeInSiteEventSavingScriptTaskLane;
		}

		protected virtual ProcessSchemaEventSubProcess CreateAttributeInSiteEventSavingEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaAttributeInSiteEventSavingEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("fd75d034-bfcc-4cfd-b167-d0b4571ec8f9"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("aa8c840d-2379-4323-8fde-f4170b340580"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("2a23e39e-fab7-43e0-a89e-cc22e5c8d6ed"),
				CreatedInSchemaUId = new Guid("04a720c2-28c1-4507-aeb1-7555c4370f96"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("04a720c2-28c1-4507-aeb1-7555c4370f96"),
				Name = @"AttributeInSiteEventSavingEventSubProcess",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(35, 14),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(322, 158),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaAttributeInSiteEventSavingEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateAttributeInSiteEventSavingStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("22021ce1-96a2-4e1a-880d-57ef0c34fba4"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("fd75d034-bfcc-4cfd-b167-d0b4571ec8f9"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("2a23e39e-fab7-43e0-a89e-cc22e5c8d6ed"),
				CreatedInSchemaUId = new Guid("04a720c2-28c1-4507-aeb1-7555c4370f96"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"AttributeInSiteEventSaving",
				ModifiedInSchemaUId = new Guid("04a720c2-28c1-4507-aeb1-7555c4370f96"),
				Name = @"AttributeInSiteEventSaving",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(22, 72),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateAttributeInSiteEventSavingScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("6803870e-dcee-4fbc-914d-dfcdf4a77a45"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("fd75d034-bfcc-4cfd-b167-d0b4571ec8f9"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("2a23e39e-fab7-43e0-a89e-cc22e5c8d6ed"),
				CreatedInSchemaUId = new Guid("04a720c2-28c1-4507-aeb1-7555c4370f96"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("04a720c2-28c1-4507-aeb1-7555c4370f96"),
				Name = @"AttributeInSiteEventSavingScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(106, 58),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,115,203,204,201,9,46,41,202,204,75,15,75,204,41,77,213,208,180,230,229,42,74,45,41,45,202,83,40,41,42,77,181,6,0,239,233,204,180,32,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateFillStringValueMethod());
			Methods.Add(CreateGetColumnDisplayValueMethod());
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("fb7b81ba-7c3c-45a5-ae9e-c6c03dceb812"),
				Name = "Terrasoft.UI.WebControls.Controls",
				Alias = "",
				CreatedInPackageId = new Guid("2a23e39e-fab7-43e0-a89e-cc22e5c8d6ed")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("cde525cf-d220-4d2a-b963-e55254c639fc"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("2a23e39e-fab7-43e0-a89e-cc22e5c8d6ed")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5c9c82c6-ba6d-4a57-9a14-87fe8faa4ebb"),
				Name = "Terrasoft.Core.DB",
				Alias = "",
				CreatedInPackageId = new Guid("2a23e39e-fab7-43e0-a89e-cc22e5c8d6ed")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7821de68-c82b-4917-a6cd-add2adfbe400"),
				Name = "Terrasoft.Common",
				Alias = "",
				CreatedInPackageId = new Guid("2a23e39e-fab7-43e0-a89e-cc22e5c8d6ed")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d67de76f-9cbc-4bfc-babb-6f65cb89b973"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("2a23e39e-fab7-43e0-a89e-cc22e5c8d6ed")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("74160d3b-65e3-4694-b554-089f2d980e54"),
				Name = "Newtonsoft.Json",
				Alias = "",
				CreatedInPackageId = new Guid("2a23e39e-fab7-43e0-a89e-cc22e5c8d6ed")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e401300a-9f16-40c2-9788-cf310ae9d1c5"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("2a23e39e-fab7-43e0-a89e-cc22e5c8d6ed")
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

		protected virtual SchemaMethod CreateFillStringValueMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("06961ef5-afc4-4c37-9d72-8f17c920505e"),
				Name = "FillStringValue",
				CreatedInSchemaUId = new Guid("04a720c2-28c1-4507-aeb1-7555c4370f96"),
				CreatedInPackageId = new Guid("2a23e39e-fab7-43e0-a89e-cc22e5c8d6ed"),
				ResultValueTypeName = "bool"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,221,150,91,111,155,48,24,134,175,203,175,240,184,74,164,56,49,103,211,174,149,186,174,139,34,109,211,182,118,147,118,105,227,143,22,141,152,12,76,170,104,234,127,159,129,156,32,77,148,105,7,85,187,65,194,188,254,252,250,121,141,237,209,8,93,101,114,14,185,66,76,169,60,225,165,2,52,103,105,9,72,101,232,70,183,200,187,47,213,171,49,103,249,70,114,187,152,193,68,160,115,84,212,138,225,245,116,166,22,103,109,77,221,109,71,98,36,49,234,93,75,149,168,197,240,38,81,112,61,7,169,46,87,125,170,154,231,104,92,38,162,209,247,209,15,227,36,7,85,230,18,169,188,132,51,227,81,151,168,134,129,226,251,39,40,202,84,233,17,36,60,160,166,228,77,116,15,83,246,177,132,124,209,251,92,64,174,231,38,33,82,73,38,135,219,130,119,76,178,59,200,7,200,220,181,96,246,207,140,117,241,225,165,16,87,89,90,78,101,207,172,230,92,125,108,77,178,169,170,61,108,186,140,65,53,173,29,7,3,116,96,218,186,238,46,220,206,40,85,229,234,219,210,81,205,247,101,67,247,162,177,55,17,149,65,99,52,66,154,178,204,212,146,125,19,104,77,190,59,200,139,115,100,66,40,152,197,193,198,156,240,16,187,1,141,49,181,67,130,57,117,25,33,161,5,17,181,204,58,137,213,4,64,109,89,232,153,91,203,196,28,180,242,238,55,129,21,15,137,138,238,187,131,215,37,181,215,165,73,165,27,141,147,136,21,128,122,71,122,58,53,78,246,121,154,72,181,50,68,180,139,189,186,55,105,198,54,202,225,65,237,171,44,75,129,201,149,58,102,105,1,135,244,111,147,66,77,20,76,235,87,157,205,0,201,50,77,15,245,248,144,103,162,140,212,19,29,90,63,65,69,45,145,170,141,204,33,34,242,3,234,227,208,10,52,50,240,35,28,2,9,177,19,17,205,144,114,225,64,220,32,219,249,69,143,89,95,107,160,255,3,77,158,3,251,214,112,140,43,203,109,146,182,197,3,238,104,146,36,2,23,187,84,56,56,228,174,192,190,111,249,46,9,4,8,78,126,131,228,22,164,67,238,143,93,193,207,132,35,111,108,180,73,122,129,111,139,8,8,246,220,88,96,87,48,15,83,47,20,216,177,29,66,28,78,89,8,118,67,114,235,88,120,10,94,85,253,162,51,215,126,189,129,60,17,194,87,40,134,183,89,179,43,245,106,159,143,8,52,149,61,242,247,89,87,253,103,22,248,177,1,254,165,64,82,93,22,233,163,102,186,220,254,215,171,219,113,28,59,244,9,142,2,159,97,55,242,28,204,244,110,129,99,226,186,1,167,130,16,139,62,251,173,117,63,129,157,120,199,171,174,175,147,98,150,178,197,234,208,218,62,133,87,17,152,235,67,186,19,74,7,238,172,25,190,75,150,134,65,232,133,122,203,224,150,165,31,130,98,234,11,27,199,182,237,217,177,71,40,8,113,144,236,175,82,248,199,171,241,88,180,203,112,54,48,219,105,181,88,10,136,153,190,53,157,162,238,45,239,168,187,70,219,145,46,188,93,229,39,111,188,26,89,220,10,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetColumnDisplayValueMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("5b988df7-053e-4689-9a13-74400bda298c"),
				Name = "GetColumnDisplayValue",
				CreatedInSchemaUId = new Guid("04a720c2-28c1-4507-aeb1-7555c4370f96"),
				CreatedInPackageId = new Guid("72185128-c0a4-4cc8-b540-87472706961a"),
				ResultValueTypeName = "string"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("4460fa1b-226f-44f4-a7bb-ea5dcbb06979"),
				Name = "schemaName",
				CreatedInSchemaUId = new Guid("04a720c2-28c1-4507-aeb1-7555c4370f96"),
				ModifiedInSchemaUId = new Guid("04a720c2-28c1-4507-aeb1-7555c4370f96"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("72185128-c0a4-4cc8-b540-87472706961a")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("39321e6a-e15c-4fa1-9de3-d56bd0649b23"),
				Name = "schemaPrimaryColumnId",
				CreatedInSchemaUId = new Guid("04a720c2-28c1-4507-aeb1-7555c4370f96"),
				ModifiedInSchemaUId = new Guid("04a720c2-28c1-4507-aeb1-7555c4370f96"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("72185128-c0a4-4cc8-b540-87472706961a")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,79,205,138,194,48,16,62,111,158,34,199,22,36,47,80,188,88,235,226,97,23,193,159,203,226,97,136,163,6,154,137,76,166,74,17,223,221,174,201,65,197,211,12,243,253,78,67,226,164,95,218,35,122,208,49,141,177,94,71,228,58,16,161,21,23,200,52,79,164,31,32,56,32,155,111,148,57,69,1,178,56,233,127,193,99,145,212,255,107,89,169,36,209,152,198,56,91,155,154,17,4,19,88,188,166,12,162,51,176,182,161,237,60,197,85,152,161,216,227,160,36,188,252,109,245,85,125,101,139,5,59,15,220,215,15,222,232,253,60,117,241,212,66,70,213,173,82,110,175,139,212,194,60,28,103,28,252,116,82,124,52,203,45,95,142,243,221,232,173,83,89,170,161,13,163,116,76,249,193,143,233,27,104,59,172,212,77,101,234,82,216,209,193,52,254,36,125,117,7,174,48,189,168,120,1,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new AttributeInSiteEvent_SiteEvent_TerrasoftEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("04a720c2-28c1-4507-aeb1-7555c4370f96"));
		}

		#endregion

	}

	#endregion

}

