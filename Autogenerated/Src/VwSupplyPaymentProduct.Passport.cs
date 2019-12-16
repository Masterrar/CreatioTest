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

	#region Class: VwSupplyPaymentProduct_Passport_TerrasoftSchema

	/// <exclude/>
	public class VwSupplyPaymentProduct_Passport_TerrasoftSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public VwSupplyPaymentProduct_Passport_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public VwSupplyPaymentProduct_Passport_TerrasoftSchema(VwSupplyPaymentProduct_Passport_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public VwSupplyPaymentProduct_Passport_TerrasoftSchema(VwSupplyPaymentProduct_Passport_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("69fe7c6b-e6cf-4f60-af51-5dede58906cb");
			RealUId = new Guid("69fe7c6b-e6cf-4f60-af51-5dede58906cb");
			Name = "VwSupplyPaymentProduct_Passport_Terrasoft";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("a0538e5b-8885-491e-bb6b-658d0c2fee8a");
			IsDBView = true;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("485aad79-d61d-41d3-b43a-702c4d517eb8")) == null) {
				Columns.Add(CreateSupplyPaymentElementColumn());
			}
			if (Columns.FindByUId(new Guid("35d1dcfa-9043-4353-af77-eb122f227453")) == null) {
				Columns.Add(CreateSupplyPaymentProductColumn());
			}
			if (Columns.FindByUId(new Guid("2a863b50-214c-41f0-8d20-bb9042a7571b")) == null) {
				Columns.Add(CreateOrderProductColumn());
			}
			if (Columns.FindByUId(new Guid("b1141a69-1c47-4263-af95-ba3ca3e54d8b")) == null) {
				Columns.Add(CreateUsedQuantityColumn());
			}
			if (Columns.FindByUId(new Guid("1333adb9-3cef-450c-8d98-7bca3090571b")) == null) {
				Columns.Add(CreateUsedAmountColumn());
			}
			if (Columns.FindByUId(new Guid("98b768be-0360-481e-b3e6-9ca26ddf6769")) == null) {
				Columns.Add(CreateMaxQuantityColumn());
			}
			if (Columns.FindByUId(new Guid("3444fc14-c107-4926-a893-90913f9028f1")) == null) {
				Columns.Add(CreateIsDistributedColumn());
			}
			if (Columns.FindByUId(new Guid("a5fcdcaa-1f34-4030-aa1e-08f2cf5b5237")) == null) {
				Columns.Add(CreatePriceColumn());
			}
			if (Columns.FindByUId(new Guid("92d9c377-2a35-494f-b44c-c7406cb6c795")) == null) {
				Columns.Add(CreateDiscountPercentColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateSupplyPaymentElementColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("485aad79-d61d-41d3-b43a-702c4d517eb8"),
				Name = @"SupplyPaymentElement",
				ReferenceSchemaUId = new Guid("28cc5afa-2b40-49e9-b516-ed35cbc4203e"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("69fe7c6b-e6cf-4f60-af51-5dede58906cb"),
				ModifiedInSchemaUId = new Guid("69fe7c6b-e6cf-4f60-af51-5dede58906cb"),
				CreatedInPackageId = new Guid("a0538e5b-8885-491e-bb6b-658d0c2fee8a")
			};
		}

		protected virtual EntitySchemaColumn CreateSupplyPaymentProductColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("35d1dcfa-9043-4353-af77-eb122f227453"),
				Name = @"SupplyPaymentProduct",
				ReferenceSchemaUId = new Guid("5e50c5fa-41cc-4c91-a04f-9d7888236c1c"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("69fe7c6b-e6cf-4f60-af51-5dede58906cb"),
				ModifiedInSchemaUId = new Guid("69fe7c6b-e6cf-4f60-af51-5dede58906cb"),
				CreatedInPackageId = new Guid("a0538e5b-8885-491e-bb6b-658d0c2fee8a")
			};
		}

		protected virtual EntitySchemaColumn CreateOrderProductColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("2a863b50-214c-41f0-8d20-bb9042a7571b"),
				Name = @"OrderProduct",
				ReferenceSchemaUId = new Guid("a31247aa-b718-40ed-982e-5b569d7d7b0e"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("69fe7c6b-e6cf-4f60-af51-5dede58906cb"),
				ModifiedInSchemaUId = new Guid("69fe7c6b-e6cf-4f60-af51-5dede58906cb"),
				CreatedInPackageId = new Guid("a0538e5b-8885-491e-bb6b-658d0c2fee8a")
			};
		}

		protected virtual EntitySchemaColumn CreateUsedQuantityColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float2")) {
				UId = new Guid("b1141a69-1c47-4263-af95-ba3ca3e54d8b"),
				Name = @"UsedQuantity",
				CreatedInSchemaUId = new Guid("69fe7c6b-e6cf-4f60-af51-5dede58906cb"),
				ModifiedInSchemaUId = new Guid("69fe7c6b-e6cf-4f60-af51-5dede58906cb"),
				CreatedInPackageId = new Guid("a0538e5b-8885-491e-bb6b-658d0c2fee8a")
			};
		}

		protected virtual EntitySchemaColumn CreateUsedAmountColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Money")) {
				UId = new Guid("1333adb9-3cef-450c-8d98-7bca3090571b"),
				Name = @"UsedAmount",
				CreatedInSchemaUId = new Guid("69fe7c6b-e6cf-4f60-af51-5dede58906cb"),
				ModifiedInSchemaUId = new Guid("69fe7c6b-e6cf-4f60-af51-5dede58906cb"),
				CreatedInPackageId = new Guid("a0538e5b-8885-491e-bb6b-658d0c2fee8a")
			};
		}

		protected virtual EntitySchemaColumn CreateMaxQuantityColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float2")) {
				UId = new Guid("98b768be-0360-481e-b3e6-9ca26ddf6769"),
				Name = @"MaxQuantity",
				CreatedInSchemaUId = new Guid("69fe7c6b-e6cf-4f60-af51-5dede58906cb"),
				ModifiedInSchemaUId = new Guid("69fe7c6b-e6cf-4f60-af51-5dede58906cb"),
				CreatedInPackageId = new Guid("a0538e5b-8885-491e-bb6b-658d0c2fee8a")
			};
		}

		protected virtual EntitySchemaColumn CreateIsDistributedColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("3444fc14-c107-4926-a893-90913f9028f1"),
				Name = @"IsDistributed",
				CreatedInSchemaUId = new Guid("69fe7c6b-e6cf-4f60-af51-5dede58906cb"),
				ModifiedInSchemaUId = new Guid("69fe7c6b-e6cf-4f60-af51-5dede58906cb"),
				CreatedInPackageId = new Guid("ea2e3ae4-7b44-4850-bdfa-8147ce4d763d")
			};
		}

		protected virtual EntitySchemaColumn CreatePriceColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Money")) {
				UId = new Guid("a5fcdcaa-1f34-4030-aa1e-08f2cf5b5237"),
				Name = @"Price",
				CreatedInSchemaUId = new Guid("69fe7c6b-e6cf-4f60-af51-5dede58906cb"),
				ModifiedInSchemaUId = new Guid("69fe7c6b-e6cf-4f60-af51-5dede58906cb"),
				CreatedInPackageId = new Guid("6f755330-bde3-4969-8b89-b0bc46685fbc")
			};
		}

		protected virtual EntitySchemaColumn CreateDiscountPercentColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Money")) {
				UId = new Guid("92d9c377-2a35-494f-b44c-c7406cb6c795"),
				Name = @"DiscountPercent",
				CreatedInSchemaUId = new Guid("69fe7c6b-e6cf-4f60-af51-5dede58906cb"),
				ModifiedInSchemaUId = new Guid("69fe7c6b-e6cf-4f60-af51-5dede58906cb"),
				CreatedInPackageId = new Guid("6f755330-bde3-4969-8b89-b0bc46685fbc")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateVwSupplyPaymentProduct_Passport_TerrasoftEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateVwSupplyPaymentProduct_Passport_TerrasoftEventsProcessSchema() {
			var schema = new VwSupplyPaymentProduct_Passport_TerrasoftEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new VwSupplyPaymentProduct_Passport_Terrasoft(userConnection){Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new VwSupplyPaymentProduct_PassportEventsProcess(userConnnection);
		}

		public override object Clone() {
			return new VwSupplyPaymentProduct_Passport_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new VwSupplyPaymentProduct_Passport_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("69fe7c6b-e6cf-4f60-af51-5dede58906cb"));
		}

		#endregion

	}

	#endregion

	#region Class: VwSupplyPaymentProduct_Passport_Terrasoft

	/// <summary>
	/// Products available in the installment plan.
	/// </summary>
	public class VwSupplyPaymentProduct_Passport_Terrasoft : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public VwSupplyPaymentProduct_Passport_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "VwSupplyPaymentProduct_Passport_Terrasoft";
		}

		public VwSupplyPaymentProduct_Passport_Terrasoft(VwSupplyPaymentProduct_Passport_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public  Guid SupplyPaymentElementId {
			get {
				return GetTypedColumnValue<Guid>("SupplyPaymentElementId");
			}
			set {
				SetColumnValue("SupplyPaymentElementId", value);
				_supplyPaymentElement = null;
			}
		}

		/// <exclude/>
		public  string SupplyPaymentElementName {
			get {
				return GetTypedColumnValue<string>("SupplyPaymentElementName");
			}
			set {
				SetColumnValue("SupplyPaymentElementName", value);
				if (_supplyPaymentElement != null) {
					_supplyPaymentElement.Name = value;
				}
			}
		}

		private SupplyPaymentElement _supplyPaymentElement;
		/// <summary>
		/// Installment plan.
		/// </summary>
		public  SupplyPaymentElement SupplyPaymentElement {
			get {
				return _supplyPaymentElement ??
					(_supplyPaymentElement = LookupColumnEntities.GetEntity("SupplyPaymentElement") as SupplyPaymentElement);
			}
		}

		/// <exclude/>
		public  Guid SupplyPaymentProductId {
			get {
				return GetTypedColumnValue<Guid>("SupplyPaymentProductId");
			}
			set {
				SetColumnValue("SupplyPaymentProductId", value);
				_supplyPaymentProduct = null;
			}
		}

		private SupplyPaymentProduct _supplyPaymentProduct;
		/// <summary>
		/// Product in the installment plan.
		/// </summary>
		public  SupplyPaymentProduct SupplyPaymentProduct {
			get {
				return _supplyPaymentProduct ??
					(_supplyPaymentProduct = LookupColumnEntities.GetEntity("SupplyPaymentProduct") as SupplyPaymentProduct);
			}
		}

		/// <exclude/>
		public  Guid OrderProductId {
			get {
				return GetTypedColumnValue<Guid>("OrderProductId");
			}
			set {
				SetColumnValue("OrderProductId", value);
				_orderProduct = null;
			}
		}

		/// <exclude/>
		public  string OrderProductName {
			get {
				return GetTypedColumnValue<string>("OrderProductName");
			}
			set {
				SetColumnValue("OrderProductName", value);
				if (_orderProduct != null) {
					_orderProduct.Name = value;
				}
			}
		}

		private OrderProduct _orderProduct;
		/// <summary>
		/// Product.
		/// </summary>
		public  OrderProduct OrderProduct {
			get {
				return _orderProduct ??
					(_orderProduct = LookupColumnEntities.GetEntity("OrderProduct") as OrderProduct);
			}
		}

		/// <summary>
		/// Quantity.
		/// </summary>
		public  Decimal UsedQuantity {
			get {
				return GetTypedColumnValue<Decimal>("UsedQuantity");
			}
			set {
				SetColumnValue("UsedQuantity", value);
			}
		}

		/// <summary>
		/// Amount.
		/// </summary>
		public  Decimal UsedAmount {
			get {
				return GetTypedColumnValue<Decimal>("UsedAmount");
			}
			set {
				SetColumnValue("UsedAmount", value);
			}
		}

		/// <summary>
		/// Available.
		/// </summary>
		public  Decimal MaxQuantity {
			get {
				return GetTypedColumnValue<Decimal>("MaxQuantity");
			}
			set {
				SetColumnValue("MaxQuantity", value);
			}
		}

		/// <summary>
		/// Distributed.
		/// </summary>
		public  int IsDistributed {
			get {
				return GetTypedColumnValue<int>("IsDistributed");
			}
			set {
				SetColumnValue("IsDistributed", value);
			}
		}

		/// <summary>
		/// Price.
		/// </summary>
		public  Decimal Price {
			get {
				return GetTypedColumnValue<Decimal>("Price");
			}
			set {
				SetColumnValue("Price", value);
			}
		}

		/// <summary>
		/// Discount, %.
		/// </summary>
		public  Decimal DiscountPercent {
			get {
				return GetTypedColumnValue<Decimal>("DiscountPercent");
			}
			set {
				SetColumnValue("DiscountPercent", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new VwSupplyPaymentProduct_PassportEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Validating += (s, e) => ThrowEvent("VwSupplyPaymentProduct_Passport_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new VwSupplyPaymentProduct_Passport_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: VwSupplyPaymentProduct_PassportEventsProcess

	/// <exclude/>
	public class VwSupplyPaymentProduct_PassportEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_LocalMessageEventsProcess<TEntity> where TEntity : VwSupplyPaymentProduct_Passport_Terrasoft
	{

		public VwSupplyPaymentProduct_PassportEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "VwSupplyPaymentProduct_PassportEventsProcess";
			SchemaUId = new Guid("69fe7c6b-e6cf-4f60-af51-5dede58906cb");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private  Guid InternalSchemaUId {
			get {
				return new Guid("69fe7c6b-e6cf-4f60-af51-5dede58906cb");
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

	#region Class: VwSupplyPaymentProduct_PassportEventsProcess

	/// <exclude/>
	public class VwSupplyPaymentProduct_PassportEventsProcess : VwSupplyPaymentProduct_PassportEventsProcess<VwSupplyPaymentProduct_Passport_Terrasoft>
	{

		public VwSupplyPaymentProduct_PassportEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: VwSupplyPaymentProduct_Passport_TerrasoftEventsProcessSchema

	/// <exclude/>
	public class VwSupplyPaymentProduct_Passport_TerrasoftEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public VwSupplyPaymentProduct_Passport_TerrasoftEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public VwSupplyPaymentProduct_Passport_TerrasoftEventsProcessSchema(VwSupplyPaymentProduct_Passport_TerrasoftEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "VwSupplyPaymentProduct_PassportEventsProcess";
			UId = new Guid("4ea7e9d4-ea1c-4a70-a367-ecb6e21886de");
			CreatedInPackageId = new Guid("a0538e5b-8885-491e-bb6b-658d0c2fee8a");
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
			return new VwSupplyPaymentProduct_Passport_TerrasoftEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("4ea7e9d4-ea1c-4a70-a367-ecb6e21886de"));
		}

		#endregion

	}

	#endregion

}

