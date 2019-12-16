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

	#region Class: AttributeInSiteEventSchema

	/// <exclude/>
	public class AttributeInSiteEventSchema : Terrasoft.Configuration.AttributeInSiteEvent_SiteEvent_TerrasoftSchema
	{

		#region Constructors: Public

		public AttributeInSiteEventSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public AttributeInSiteEventSchema(AttributeInSiteEventSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public AttributeInSiteEventSchema(AttributeInSiteEventSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("a8b78ad0-d62f-4f36-ac6e-9201eb77f027");
			Name = "AttributeInSiteEvent";
			ParentSchemaUId = new Guid("6839c7b8-f847-4cef-81cd-6554e7502730");
			ExtendParent = true;
			CreatedInPackageId = new Guid("57561044-f3ca-479f-8adf-c3fca7561cde");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("be1d261c-c90a-4a78-b454-1f72cad994d5")) == null) {
				Columns.Add(CreateProductTypeValueColumn());
			}
			if (Columns.FindByUId(new Guid("be3e38da-56de-4be6-8e1c-b38fff609cc9")) == null) {
				Columns.Add(CreateProductCategoryValueColumn());
			}
			if (Columns.FindByUId(new Guid("1257872a-31e1-4602-8b78-671f31ae39be")) == null) {
				Columns.Add(CreateProductTradeMarkValueColumn());
			}
		}

		protected override EntitySchemaColumn CreateSiteEventAttributeColumn() {
			EntitySchemaColumn column = base.CreateSiteEventAttributeColumn();
			column.ModifiedInSchemaUId = new Guid("a8b78ad0-d62f-4f36-ac6e-9201eb77f027");
			column.CreatedInPackageId = new Guid("57561044-f3ca-479f-8adf-c3fca7561cde");
			return column;
		}

		protected override EntitySchemaColumn CreateListItemValueColumn() {
			EntitySchemaColumn column = base.CreateListItemValueColumn();
			column.UsageType = EntitySchemaColumnUsageType.None;
			column.ModifiedInSchemaUId = new Guid("a8b78ad0-d62f-4f36-ac6e-9201eb77f027");
			column.CreatedInPackageId = new Guid("57561044-f3ca-479f-8adf-c3fca7561cde");
			return column;
		}

		protected override EntitySchemaColumn CreateIntValueColumn() {
			EntitySchemaColumn column = base.CreateIntValueColumn();
			column.UsageType = EntitySchemaColumnUsageType.None;
			column.ModifiedInSchemaUId = new Guid("a8b78ad0-d62f-4f36-ac6e-9201eb77f027");
			column.CreatedInPackageId = new Guid("57561044-f3ca-479f-8adf-c3fca7561cde");
			return column;
		}

		protected override EntitySchemaColumn CreateFloatValueColumn() {
			EntitySchemaColumn column = base.CreateFloatValueColumn();
			column.UsageType = EntitySchemaColumnUsageType.None;
			column.ModifiedInSchemaUId = new Guid("a8b78ad0-d62f-4f36-ac6e-9201eb77f027");
			column.CreatedInPackageId = new Guid("57561044-f3ca-479f-8adf-c3fca7561cde");
			return column;
		}

		protected override EntitySchemaColumn CreateBooleanValueColumn() {
			EntitySchemaColumn column = base.CreateBooleanValueColumn();
			column.UsageType = EntitySchemaColumnUsageType.None;
			column.ModifiedInSchemaUId = new Guid("a8b78ad0-d62f-4f36-ac6e-9201eb77f027");
			column.CreatedInPackageId = new Guid("57561044-f3ca-479f-8adf-c3fca7561cde");
			return column;
		}

		protected virtual EntitySchemaColumn CreateProductTypeValueColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("be1d261c-c90a-4a78-b454-1f72cad994d5"),
				Name = @"ProductTypeValue",
				ReferenceSchemaUId = new Guid("41663f5e-affb-406e-b92d-4d72eea6f8a8"),
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("a8b78ad0-d62f-4f36-ac6e-9201eb77f027"),
				ModifiedInSchemaUId = new Guid("a8b78ad0-d62f-4f36-ac6e-9201eb77f027"),
				CreatedInPackageId = new Guid("57561044-f3ca-479f-8adf-c3fca7561cde")
			};
		}

		protected virtual EntitySchemaColumn CreateProductCategoryValueColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("be3e38da-56de-4be6-8e1c-b38fff609cc9"),
				Name = @"ProductCategoryValue",
				ReferenceSchemaUId = new Guid("3e22e8d3-36f6-4c32-adbe-678155527541"),
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("a8b78ad0-d62f-4f36-ac6e-9201eb77f027"),
				ModifiedInSchemaUId = new Guid("a8b78ad0-d62f-4f36-ac6e-9201eb77f027"),
				CreatedInPackageId = new Guid("57561044-f3ca-479f-8adf-c3fca7561cde")
			};
		}

		protected virtual EntitySchemaColumn CreateProductTradeMarkValueColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("1257872a-31e1-4602-8b78-671f31ae39be"),
				Name = @"ProductTradeMarkValue",
				ReferenceSchemaUId = new Guid("d1084b21-51c3-4fb4-b8b8-158895fbdebc"),
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("a8b78ad0-d62f-4f36-ac6e-9201eb77f027"),
				ModifiedInSchemaUId = new Guid("a8b78ad0-d62f-4f36-ac6e-9201eb77f027"),
				CreatedInPackageId = new Guid("57561044-f3ca-479f-8adf-c3fca7561cde")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateAttributeInSiteEventEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateAttributeInSiteEventEventsProcessSchema() {
			var schema = new AttributeInSiteEventEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new AttributeInSiteEvent(userConnection){Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new AttributeInSiteEvent_SiteEventProductOmnichannelEventsProcess(userConnnection);
		}

		public override object Clone() {
			return new AttributeInSiteEventSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new AttributeInSiteEventSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a8b78ad0-d62f-4f36-ac6e-9201eb77f027"));
		}

		#endregion

	}

	#endregion

	#region Class: AttributeInSiteEvent

	/// <summary>
	/// Attribute in site event.
	/// </summary>
	public class AttributeInSiteEvent : Terrasoft.Configuration.AttributeInSiteEvent_SiteEvent_Terrasoft
	{

		#region Constructors: Public

		public AttributeInSiteEvent(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "AttributeInSiteEvent";
		}

		public AttributeInSiteEvent(AttributeInSiteEvent source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public  Guid ProductTypeValueId {
			get {
				return GetTypedColumnValue<Guid>("ProductTypeValueId");
			}
			set {
				SetColumnValue("ProductTypeValueId", value);
				_productTypeValue = null;
			}
		}

		/// <exclude/>
		public  string ProductTypeValueName {
			get {
				return GetTypedColumnValue<string>("ProductTypeValueName");
			}
			set {
				SetColumnValue("ProductTypeValueName", value);
				if (_productTypeValue != null) {
					_productTypeValue.Name = value;
				}
			}
		}

		private ProductType _productTypeValue;
		/// <summary>
		/// Product type.
		/// </summary>
		public  ProductType ProductTypeValue {
			get {
				return _productTypeValue ??
					(_productTypeValue = LookupColumnEntities.GetEntity("ProductTypeValue") as ProductType);
			}
		}

		/// <exclude/>
		public  Guid ProductCategoryValueId {
			get {
				return GetTypedColumnValue<Guid>("ProductCategoryValueId");
			}
			set {
				SetColumnValue("ProductCategoryValueId", value);
				_productCategoryValue = null;
			}
		}

		/// <exclude/>
		public  string ProductCategoryValueName {
			get {
				return GetTypedColumnValue<string>("ProductCategoryValueName");
			}
			set {
				SetColumnValue("ProductCategoryValueName", value);
				if (_productCategoryValue != null) {
					_productCategoryValue.Name = value;
				}
			}
		}

		private ProductCategory _productCategoryValue;
		/// <summary>
		/// Product category.
		/// </summary>
		public  ProductCategory ProductCategoryValue {
			get {
				return _productCategoryValue ??
					(_productCategoryValue = LookupColumnEntities.GetEntity("ProductCategoryValue") as ProductCategory);
			}
		}

		/// <exclude/>
		public  Guid ProductTradeMarkValueId {
			get {
				return GetTypedColumnValue<Guid>("ProductTradeMarkValueId");
			}
			set {
				SetColumnValue("ProductTradeMarkValueId", value);
				_productTradeMarkValue = null;
			}
		}

		/// <exclude/>
		public  string ProductTradeMarkValueName {
			get {
				return GetTypedColumnValue<string>("ProductTradeMarkValueName");
			}
			set {
				SetColumnValue("ProductTradeMarkValueName", value);
				if (_productTradeMarkValue != null) {
					_productTradeMarkValue.Name = value;
				}
			}
		}

		private TradeMark _productTradeMarkValue;
		/// <summary>
		/// Brand.
		/// </summary>
		public  TradeMark ProductTradeMarkValue {
			get {
				return _productTradeMarkValue ??
					(_productTradeMarkValue = LookupColumnEntities.GetEntity("ProductTradeMarkValue") as TradeMark);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new AttributeInSiteEvent_SiteEventProductOmnichannelEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Validating += (s, e) => ThrowEvent("AttributeInSiteEventValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new AttributeInSiteEvent(this);
		}

		#endregion

	}

	#endregion

	#region Class: AttributeInSiteEvent_SiteEventProductOmnichannelEventsProcess

	/// <exclude/>
	public class AttributeInSiteEvent_SiteEventProductOmnichannelEventsProcess<TEntity> : Terrasoft.Configuration.AttributeInSiteEvent_SiteEventEventsProcess<TEntity> where TEntity : AttributeInSiteEvent
	{

		public AttributeInSiteEvent_SiteEventProductOmnichannelEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "AttributeInSiteEvent_SiteEventProductOmnichannelEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private  Guid InternalSchemaUId {
			get {
				return new Guid("a8b78ad0-d62f-4f36-ac6e-9201eb77f027");
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

		public override bool FillStringValue() {
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
			
			switch (attributeTypeId) {
				// string type
				case ("e9da1be2-b0b9-478f-8290-b84a0091ec81"):
					Entity.SetColumnValue("IntValue", 0);
					Entity.SetColumnValue("FloatValue", 0.0);
					Entity.SetColumnValue("BooleanValue", false);
					Entity.SetColumnValue("ListItemValueId", null);
					Entity.SetColumnValue("ProductValueId", null);
					Entity.SetColumnValue("ProductTypeValueId", null);
					Entity.SetColumnValue("ProductCategoryValueId", null);
					Entity.SetColumnValue("ProductTradeMarkValueId", null);
					return true;
				// int type
				case ("30dc6786-9179-4e6c-9e09-3c00b98bd3ef"):
					attributeValue = Entity.GetTypedColumnValue<string>("IntValue");
					Entity.SetColumnValue("FloatValue", 0.0);
					Entity.SetColumnValue("BooleanValue", false);
					Entity.SetColumnValue("ListItemValueId", null);
					Entity.SetColumnValue("ProductValueId", null);
					Entity.SetColumnValue("ProductTypeValueId", null);
					Entity.SetColumnValue("ProductCategoryValueId", null);
					Entity.SetColumnValue("ProductTradeMarkValueId", null);
					break;
				// float type
				case ("21b7b386-0ce4-48d3-9b4d-6616407dedb0"):
					attributeValue = Entity.GetTypedColumnValue<string>("FloatValue");
					Entity.SetColumnValue("IntValue", 0);
					Entity.SetColumnValue("BooleanValue", false);
					Entity.SetColumnValue("ListItemValueId", null);
					Entity.SetColumnValue("ProductValueId", null);
					Entity.SetColumnValue("ProductTypeValueId", null);
					Entity.SetColumnValue("ProductCategoryValueId", null);
					Entity.SetColumnValue("ProductTradeMarkValueId", null);
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
					Entity.SetColumnValue("ProductTypeValueId", null);
					Entity.SetColumnValue("ProductCategoryValueId", null);
					Entity.SetColumnValue("ProductTradeMarkValueId", null);
					break;
				// list item value
				case ("23332960-c76a-4c53-a4e6-f0447b8d0018"):
					Entity.SetColumnValue("IntValue", 0);
					Entity.SetColumnValue("FloatValue", 0.0);
					Entity.SetColumnValue("BooleanValue", false);
					Entity.SetColumnValue("ProductValueId", null);
					Entity.SetColumnValue("ProductTypeValueId", null);
					Entity.SetColumnValue("ProductCategoryValueId", null);
					Entity.SetColumnValue("ProductTradeMarkValueId", null);
					attributeValue = GetColumnDisplayValue("SiteEventAttrListItem", Entity.ListItemValueId);
					break;
				// product item value
				case ("28979594-4b11-4bd8-86d2-f2252f508edd"):
					Entity.SetColumnValue("BooleanValue", false);
					Entity.SetColumnValue("FloatValue", 0.0);
					Entity.SetColumnValue("IntValue", 0);
					Entity.SetColumnValue("ListItemValueId", null);
					Entity.SetColumnValue("ProductTypeValueId", null);
					Entity.SetColumnValue("ProductCategoryValueId", null);
					Entity.SetColumnValue("ProductTradeMarkValueId", null);
					attributeValue = GetColumnDisplayValue("Product", Entity.ProductValueId);
					break;
				// product trademark item value 
				case ("5262af16-0914-4f73-a1e9-20cbebd766f9"):
					Entity.SetColumnValue("BooleanValue", false);
					Entity.SetColumnValue("FloatValue", 0.0);
					Entity.SetColumnValue("IntValue", 0);
					Entity.SetColumnValue("ListItemValueId", null);
					Entity.SetColumnValue("ProductTypeValueId", null);
					Entity.SetColumnValue("ProductTradeMarkValueId", null);
					attributeValue = GetColumnDisplayValue("ProductCategory", Entity.ProductCategoryValueId);
					break;
				// product type item value 
				case ("e29b09bb-0f52-4eb4-847d-3b6235f5424a"):
					Entity.SetColumnValue("BooleanValue", false);
					Entity.SetColumnValue("FloatValue", 0.0);
					Entity.SetColumnValue("IntValue", 0);
					Entity.SetColumnValue("ListItemValueId", null);
					Entity.SetColumnValue("ProductCategoryValueId", null);
					Entity.SetColumnValue("ProductTradeMarkValueId", null);
					attributeValue = GetColumnDisplayValue("ProductType", Entity.ProductTypeValueId);
					break;
				// product trademark item value 
				case ("71fae7e0-2a9c-4aea-9a87-e23eee66b01d"):
					Entity.SetColumnValue("BooleanValue", false);
					Entity.SetColumnValue("FloatValue", 0.0);
					Entity.SetColumnValue("IntValue", 0);
					Entity.SetColumnValue("ListItemValueId", null);
					Entity.SetColumnValue("ProductTypeValueId", null);
					Entity.SetColumnValue("ProductCategoryValueId", null);
					attributeValue = GetColumnDisplayValue("TradeMark", Entity.ProductTradeMarkValueId);
					break;
				default: return true;
			};
			Entity.SetColumnValue("StringValue", attributeValue);
			return true;
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

	#region Class: AttributeInSiteEvent_SiteEventProductOmnichannelEventsProcess

	/// <exclude/>
	public class AttributeInSiteEvent_SiteEventProductOmnichannelEventsProcess : AttributeInSiteEvent_SiteEventProductOmnichannelEventsProcess<AttributeInSiteEvent>
	{

		public AttributeInSiteEvent_SiteEventProductOmnichannelEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: AttributeInSiteEventEventsProcessSchema

	/// <exclude/>
	public class AttributeInSiteEventEventsProcessSchema : Terrasoft.Configuration.AttributeInSiteEvent_SiteEvent_TerrasoftEventsProcessSchema
	{

		#region Constructors: Public

		public AttributeInSiteEventEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public AttributeInSiteEventEventsProcessSchema(AttributeInSiteEventEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "AttributeInSiteEvent_SiteEventProductOmnichannelEventsProcess";
			UId = new Guid("46b8b995-27b6-40e3-aad7-9c3b5863e87a");
			CreatedInPackageId = new Guid("57561044-f3ca-479f-8adf-c3fca7561cde");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("04a720c2-28c1-4507-aeb1-7555c4370f96");
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
				CreatedInPackageId = new Guid("57561044-f3ca-479f-8adf-c3fca7561cde")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("cde525cf-d220-4d2a-b963-e55254c639fc"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("57561044-f3ca-479f-8adf-c3fca7561cde")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5c9c82c6-ba6d-4a57-9a14-87fe8faa4ebb"),
				Name = "Terrasoft.Core.DB",
				Alias = "",
				CreatedInPackageId = new Guid("57561044-f3ca-479f-8adf-c3fca7561cde")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7821de68-c82b-4917-a6cd-add2adfbe400"),
				Name = "Terrasoft.Common",
				Alias = "",
				CreatedInPackageId = new Guid("57561044-f3ca-479f-8adf-c3fca7561cde")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d67de76f-9cbc-4bfc-babb-6f65cb89b973"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("57561044-f3ca-479f-8adf-c3fca7561cde")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("74160d3b-65e3-4694-b554-089f2d980e54"),
				Name = "Newtonsoft.Json",
				Alias = "",
				CreatedInPackageId = new Guid("57561044-f3ca-479f-8adf-c3fca7561cde")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e401300a-9f16-40c2-9788-cf310ae9d1c5"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("57561044-f3ca-479f-8adf-c3fca7561cde")
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

		protected override SchemaMethod CreateFillStringValueMethod() {
			SchemaMethod method = base.CreateFillStringValueMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,237,152,93,79,219,48,20,134,175,233,175,240,122,85,36,92,28,231,203,134,129,180,49,134,144,198,180,13,54,105,151,118,124,2,17,105,194,18,7,84,77,252,247,57,73,91,146,244,67,237,190,4,27,55,149,154,30,31,191,62,207,107,251,52,183,34,67,66,235,44,146,133,134,139,241,13,156,42,116,128,114,243,32,185,28,30,143,110,244,120,191,119,219,140,249,34,226,2,230,66,162,16,13,142,19,29,233,241,240,60,210,112,124,11,137,126,53,29,82,166,60,64,39,69,164,234,240,109,244,189,183,149,129,46,178,4,233,172,128,253,222,125,61,9,228,223,62,65,94,196,218,228,79,224,14,213,25,207,131,43,24,137,143,5,100,227,193,231,28,178,163,52,73,32,208,81,154,12,155,1,103,34,17,151,144,237,160,254,188,130,254,246,126,111,150,124,248,74,169,163,52,46,70,201,160,95,174,184,252,177,181,196,58,171,209,240,48,228,4,116,253,180,163,96,7,173,88,181,201,59,95,218,206,44,101,230,242,183,137,162,170,186,47,235,218,30,214,242,78,85,41,176,183,187,139,76,145,147,84,79,42,143,110,203,208,170,240,221,73,94,28,160,62,112,37,44,9,20,75,34,57,118,124,22,98,70,57,193,146,57,130,16,110,65,192,172,126,5,98,186,0,208,13,9,131,254,121,53,75,245,165,191,211,162,189,93,241,234,229,119,145,14,174,230,102,175,114,26,177,19,149,218,60,236,109,5,34,7,52,88,83,212,94,111,107,153,168,211,68,79,21,17,35,99,105,220,219,56,21,15,145,195,149,177,175,211,52,6,145,76,163,67,17,231,176,42,254,93,148,235,83,13,163,234,171,129,179,131,146,34,142,87,141,248,144,165,170,8,244,198,3,202,130,110,60,232,72,104,184,76,179,241,230,179,101,66,193,153,200,174,23,140,108,109,214,146,110,148,232,54,90,155,168,192,243,153,135,185,229,27,180,224,5,152,3,225,216,14,136,97,205,164,178,33,172,209,206,157,36,235,108,132,25,248,103,234,127,143,186,204,64,92,215,188,195,178,180,109,226,212,146,190,180,13,113,18,128,131,29,166,108,204,165,163,176,231,89,158,67,124,5,74,146,95,32,222,128,185,106,25,235,158,8,207,188,55,226,45,235,114,181,137,187,190,71,85,0,4,187,78,168,176,163,132,139,153,203,21,182,169,77,136,45,153,224,64,107,226,141,118,96,17,228,50,251,97,135,201,118,117,113,44,48,203,87,200,135,23,105,125,29,13,42,157,247,8,12,189,37,225,239,211,110,244,239,57,48,214,53,218,127,110,156,216,44,31,153,94,104,52,233,79,102,167,133,109,219,148,123,4,7,190,39,176,19,184,54,22,230,150,192,33,113,28,95,50,69,136,197,30,253,213,255,244,73,205,109,151,147,105,142,55,81,126,19,139,241,180,251,107,182,179,83,75,247,103,221,110,199,228,93,19,220,212,66,22,250,128,113,159,187,220,92,24,210,178,204,135,98,152,121,138,226,144,82,151,134,46,97,160,212,74,31,108,202,236,81,237,241,167,103,132,73,170,7,244,237,61,176,140,188,46,167,30,153,169,27,30,64,15,23,9,245,168,8,45,211,58,112,203,56,33,244,205,97,96,1,199,148,4,18,164,242,61,47,228,207,38,248,83,44,167,126,154,99,218,49,218,82,182,70,255,66,172,64,185,36,92,74,76,66,151,154,255,0,210,193,204,241,77,127,32,61,106,187,161,235,80,71,252,187,88,31,195,54,173,94,103,116,177,54,252,246,115,219,213,183,66,1,190,233,251,168,224,1,118,4,8,204,5,243,49,80,27,0,60,79,18,235,249,204,94,219,12,235,34,157,217,98,30,104,199,48,45,170,10,66,81,196,122,15,117,95,176,173,245,158,167,45,206,36,110,102,249,1,198,157,221,213,44,20,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new AttributeInSiteEventEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("46b8b995-27b6-40e3-aad7-9c3b5863e87a"));
		}

		#endregion

	}

	#endregion


	#region Class: AttributeInSiteEventEventsProcess

	/// <exclude/>
	public class AttributeInSiteEventEventsProcess : AttributeInSiteEvent_SiteEventProductOmnichannelEventsProcess
	{

		public AttributeInSiteEventEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

