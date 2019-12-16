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

	#region Class: ConfItemSchema

	/// <exclude/>
	public class ConfItemSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public ConfItemSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public ConfItemSchema(ConfItemSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public ConfItemSchema(ConfItemSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("ad707075-cf25-40bf-85c1-f5da38cf0d5d");
			RealUId = new Guid("ad707075-cf25-40bf-85c1-f5da38cf0d5d");
			Name = "ConfItem";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("305fcfca-4160-4398-90a9-d5e84be0ae12");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializePrimaryDisplayColumn() {
			base.InitializePrimaryDisplayColumn();
			PrimaryDisplayColumn = CreateNameColumn();
			if (Columns.FindByUId(PrimaryDisplayColumn.UId) == null) {
				Columns.Add(PrimaryDisplayColumn);
			}
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("527ad368-46be-41f3-9e14-2032eb0740f4")) == null) {
				Columns.Add(CreateTypeColumn());
			}
			if (Columns.FindByUId(new Guid("e2f4f7d7-6bbc-4ef7-a49e-f7822d8b1764")) == null) {
				Columns.Add(CreateModelColumn());
			}
			if (Columns.FindByUId(new Guid("f6afc6ee-bf06-40c0-8017-268324098d4c")) == null) {
				Columns.Add(CreateSerialNumberColumn());
			}
			if (Columns.FindByUId(new Guid("48b3f5ba-fe8d-43cf-9e57-2ba888714986")) == null) {
				Columns.Add(CreateInventoryNumberColumn());
			}
			if (Columns.FindByUId(new Guid("c45e1755-3c1f-4b0d-bd6b-c602aac23cbf")) == null) {
				Columns.Add(CreateStatusColumn());
			}
			if (Columns.FindByUId(new Guid("43b4722d-6adc-4b8a-b14a-864d13d4d579")) == null) {
				Columns.Add(CreatePurchaseDateColumn());
			}
			if (Columns.FindByUId(new Guid("80540aed-fffb-41bc-96e4-ac16b34e51c8")) == null) {
				Columns.Add(CreateCancelDateColumn());
			}
			if (Columns.FindByUId(new Guid("3582c7f2-22db-47d1-99f7-92606faa635e")) == null) {
				Columns.Add(CreateWarrantyUntilColumn());
			}
			if (Columns.FindByUId(new Guid("dc05841e-7887-4c81-abde-19d16764ff88")) == null) {
				Columns.Add(CreateOwnerColumn());
			}
			if (Columns.FindByUId(new Guid("eca77133-6ed4-4215-96df-5ff5332bfa0a")) == null) {
				Columns.Add(CreateParentConfItemColumn());
			}
			if (Columns.FindByUId(new Guid("4a483263-4df5-41ac-907d-44ac80791399")) == null) {
				Columns.Add(CreateCategoryColumn());
			}
			if (Columns.FindByUId(new Guid("b341a593-74f0-46d2-8f57-9b3167a1513b")) == null) {
				Columns.Add(CreateNotesColumn());
			}
			if (Columns.FindByUId(new Guid("4d9aba72-ae48-40dc-93d8-f185f5db8e24")) == null) {
				Columns.Add(CreateCountryColumn());
			}
			if (Columns.FindByUId(new Guid("fe477f7c-fac9-43fb-b3be-60c2365f58ae")) == null) {
				Columns.Add(CreateRegionColumn());
			}
			if (Columns.FindByUId(new Guid("457b1dc5-10f6-4f7c-98f3-9cbc12f7f6af")) == null) {
				Columns.Add(CreateCityColumn());
			}
			if (Columns.FindByUId(new Guid("63a0ae99-7719-48cc-a857-0389e7f8d0cd")) == null) {
				Columns.Add(CreateStreetColumn());
			}
			if (Columns.FindByUId(new Guid("0da4fb4f-9441-4bf2-a7fb-5ec07a5de470")) == null) {
				Columns.Add(CreateAddressColumn());
			}
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.ModifiedInSchemaUId = new Guid("ad707075-cf25-40bf-85c1-f5da38cf0d5d");
			column.CreatedInPackageId = new Guid("305fcfca-4160-4398-90a9-d5e84be0ae12");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.ModifiedInSchemaUId = new Guid("ad707075-cf25-40bf-85c1-f5da38cf0d5d");
			column.CreatedInPackageId = new Guid("305fcfca-4160-4398-90a9-d5e84be0ae12");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.ModifiedInSchemaUId = new Guid("ad707075-cf25-40bf-85c1-f5da38cf0d5d");
			column.CreatedInPackageId = new Guid("305fcfca-4160-4398-90a9-d5e84be0ae12");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.ModifiedInSchemaUId = new Guid("ad707075-cf25-40bf-85c1-f5da38cf0d5d");
			column.CreatedInPackageId = new Guid("305fcfca-4160-4398-90a9-d5e84be0ae12");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.ModifiedInSchemaUId = new Guid("ad707075-cf25-40bf-85c1-f5da38cf0d5d");
			column.CreatedInPackageId = new Guid("305fcfca-4160-4398-90a9-d5e84be0ae12");
			return column;
		}

		protected override EntitySchemaColumn CreateProcessListenersColumn() {
			EntitySchemaColumn column = base.CreateProcessListenersColumn();
			column.ModifiedInSchemaUId = new Guid("ad707075-cf25-40bf-85c1-f5da38cf0d5d");
			column.CreatedInPackageId = new Guid("305fcfca-4160-4398-90a9-d5e84be0ae12");
			return column;
		}

		protected virtual EntitySchemaColumn CreateNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("4ea61b17-b7e6-4e10-942f-246339e0ff07"),
				Name = @"Name",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("ad707075-cf25-40bf-85c1-f5da38cf0d5d"),
				ModifiedInSchemaUId = new Guid("ad707075-cf25-40bf-85c1-f5da38cf0d5d"),
				CreatedInPackageId = new Guid("305fcfca-4160-4398-90a9-d5e84be0ae12")
			};
		}

		protected virtual EntitySchemaColumn CreateTypeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("527ad368-46be-41f3-9e14-2032eb0740f4"),
				Name = @"Type",
				ReferenceSchemaUId = new Guid("da6e81b8-7237-4bb1-b5b1-b1e80977025e"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("ad707075-cf25-40bf-85c1-f5da38cf0d5d"),
				ModifiedInSchemaUId = new Guid("ad707075-cf25-40bf-85c1-f5da38cf0d5d"),
				CreatedInPackageId = new Guid("305fcfca-4160-4398-90a9-d5e84be0ae12")
			};
		}

		protected virtual EntitySchemaColumn CreateModelColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("e2f4f7d7-6bbc-4ef7-a49e-f7822d8b1764"),
				Name = @"Model",
				ReferenceSchemaUId = new Guid("763b998e-00b3-4b83-90c4-bed9c7715dc7"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("ad707075-cf25-40bf-85c1-f5da38cf0d5d"),
				ModifiedInSchemaUId = new Guid("ad707075-cf25-40bf-85c1-f5da38cf0d5d"),
				CreatedInPackageId = new Guid("305fcfca-4160-4398-90a9-d5e84be0ae12")
			};
		}

		protected virtual EntitySchemaColumn CreateSerialNumberColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("f6afc6ee-bf06-40c0-8017-268324098d4c"),
				Name = @"SerialNumber",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("ad707075-cf25-40bf-85c1-f5da38cf0d5d"),
				ModifiedInSchemaUId = new Guid("ad707075-cf25-40bf-85c1-f5da38cf0d5d"),
				CreatedInPackageId = new Guid("305fcfca-4160-4398-90a9-d5e84be0ae12")
			};
		}

		protected virtual EntitySchemaColumn CreateInventoryNumberColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("48b3f5ba-fe8d-43cf-9e57-2ba888714986"),
				Name = @"InventoryNumber",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("ad707075-cf25-40bf-85c1-f5da38cf0d5d"),
				ModifiedInSchemaUId = new Guid("ad707075-cf25-40bf-85c1-f5da38cf0d5d"),
				CreatedInPackageId = new Guid("305fcfca-4160-4398-90a9-d5e84be0ae12")
			};
		}

		protected virtual EntitySchemaColumn CreateStatusColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("c45e1755-3c1f-4b0d-bd6b-c602aac23cbf"),
				Name = @"Status",
				ReferenceSchemaUId = new Guid("0f634f04-a6ca-42b3-abe9-3d780c7e9b34"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("ad707075-cf25-40bf-85c1-f5da38cf0d5d"),
				ModifiedInSchemaUId = new Guid("ad707075-cf25-40bf-85c1-f5da38cf0d5d"),
				CreatedInPackageId = new Guid("305fcfca-4160-4398-90a9-d5e84be0ae12"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Settings,
					ValueSource = @"ConfigurationItemStatusDef"
				}
			};
		}

		protected virtual EntitySchemaColumn CreatePurchaseDateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Date")) {
				UId = new Guid("43b4722d-6adc-4b8a-b14a-864d13d4d579"),
				Name = @"PurchaseDate",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("ad707075-cf25-40bf-85c1-f5da38cf0d5d"),
				ModifiedInSchemaUId = new Guid("ad707075-cf25-40bf-85c1-f5da38cf0d5d"),
				CreatedInPackageId = new Guid("305fcfca-4160-4398-90a9-d5e84be0ae12")
			};
		}

		protected virtual EntitySchemaColumn CreateCancelDateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Date")) {
				UId = new Guid("80540aed-fffb-41bc-96e4-ac16b34e51c8"),
				Name = @"CancelDate",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("ad707075-cf25-40bf-85c1-f5da38cf0d5d"),
				ModifiedInSchemaUId = new Guid("ad707075-cf25-40bf-85c1-f5da38cf0d5d"),
				CreatedInPackageId = new Guid("305fcfca-4160-4398-90a9-d5e84be0ae12")
			};
		}

		protected virtual EntitySchemaColumn CreateWarrantyUntilColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Date")) {
				UId = new Guid("3582c7f2-22db-47d1-99f7-92606faa635e"),
				Name = @"WarrantyUntil",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("ad707075-cf25-40bf-85c1-f5da38cf0d5d"),
				ModifiedInSchemaUId = new Guid("ad707075-cf25-40bf-85c1-f5da38cf0d5d"),
				CreatedInPackageId = new Guid("305fcfca-4160-4398-90a9-d5e84be0ae12")
			};
		}

		protected virtual EntitySchemaColumn CreateOwnerColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("dc05841e-7887-4c81-abde-19d16764ff88"),
				Name = @"Owner",
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("ad707075-cf25-40bf-85c1-f5da38cf0d5d"),
				ModifiedInSchemaUId = new Guid("ad707075-cf25-40bf-85c1-f5da38cf0d5d"),
				CreatedInPackageId = new Guid("305fcfca-4160-4398-90a9-d5e84be0ae12"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.SystemValue,
					ValueSource = SystemValueManager.GetInstanceByName(@"CurrentUserContact")
				}
			};
		}

		protected virtual EntitySchemaColumn CreateParentConfItemColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("eca77133-6ed4-4215-96df-5ff5332bfa0a"),
				Name = @"ParentConfItem",
				ReferenceSchemaUId = new Guid("ad707075-cf25-40bf-85c1-f5da38cf0d5d"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("ad707075-cf25-40bf-85c1-f5da38cf0d5d"),
				ModifiedInSchemaUId = new Guid("ad707075-cf25-40bf-85c1-f5da38cf0d5d"),
				CreatedInPackageId = new Guid("ffa69c6a-c8bb-4a61-bc00-b0bcd40a9862")
			};
		}

		protected virtual EntitySchemaColumn CreateCategoryColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("4a483263-4df5-41ac-907d-44ac80791399"),
				Name = @"Category",
				ReferenceSchemaUId = new Guid("f3a5c486-27e1-46aa-b693-148bffe3b87c"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("ad707075-cf25-40bf-85c1-f5da38cf0d5d"),
				ModifiedInSchemaUId = new Guid("ad707075-cf25-40bf-85c1-f5da38cf0d5d"),
				CreatedInPackageId = new Guid("3bc94b8f-9e47-4d1d-84d1-651293d36a8b")
			};
		}

		protected virtual EntitySchemaColumn CreateNotesColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("b341a593-74f0-46d2-8f57-9b3167a1513b"),
				Name = @"Notes",
				CreatedInSchemaUId = new Guid("ad707075-cf25-40bf-85c1-f5da38cf0d5d"),
				ModifiedInSchemaUId = new Guid("ad707075-cf25-40bf-85c1-f5da38cf0d5d"),
				CreatedInPackageId = new Guid("3bc94b8f-9e47-4d1d-84d1-651293d36a8b")
			};
		}

		protected virtual EntitySchemaColumn CreateCountryColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("4d9aba72-ae48-40dc-93d8-f185f5db8e24"),
				Name = @"Country",
				ReferenceSchemaUId = new Guid("09fce1f8-515c-4296-95cd-8cd93f79a6cf"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("ad707075-cf25-40bf-85c1-f5da38cf0d5d"),
				ModifiedInSchemaUId = new Guid("ad707075-cf25-40bf-85c1-f5da38cf0d5d"),
				CreatedInPackageId = new Guid("0a82de9d-1b49-4c10-947c-0386e85def78")
			};
		}

		protected virtual EntitySchemaColumn CreateRegionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("fe477f7c-fac9-43fb-b3be-60c2365f58ae"),
				Name = @"Region",
				ReferenceSchemaUId = new Guid("fa4eb497-e6a3-4f8c-8568-5df4bd2a8b91"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("ad707075-cf25-40bf-85c1-f5da38cf0d5d"),
				ModifiedInSchemaUId = new Guid("ad707075-cf25-40bf-85c1-f5da38cf0d5d"),
				CreatedInPackageId = new Guid("0a82de9d-1b49-4c10-947c-0386e85def78")
			};
		}

		protected virtual EntitySchemaColumn CreateCityColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("457b1dc5-10f6-4f7c-98f3-9cbc12f7f6af"),
				Name = @"City",
				ReferenceSchemaUId = new Guid("5ca90b6a-93e7-4448-befe-ab5166ec2cfe"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("ad707075-cf25-40bf-85c1-f5da38cf0d5d"),
				ModifiedInSchemaUId = new Guid("ad707075-cf25-40bf-85c1-f5da38cf0d5d"),
				CreatedInPackageId = new Guid("0a82de9d-1b49-4c10-947c-0386e85def78")
			};
		}

		protected virtual EntitySchemaColumn CreateStreetColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("63a0ae99-7719-48cc-a857-0389e7f8d0cd"),
				Name = @"Street",
				CreatedInSchemaUId = new Guid("ad707075-cf25-40bf-85c1-f5da38cf0d5d"),
				ModifiedInSchemaUId = new Guid("ad707075-cf25-40bf-85c1-f5da38cf0d5d"),
				CreatedInPackageId = new Guid("0a82de9d-1b49-4c10-947c-0386e85def78")
			};
		}

		protected virtual EntitySchemaColumn CreateAddressColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("0da4fb4f-9441-4bf2-a7fb-5ec07a5de470"),
				Name = @"Address",
				CreatedInSchemaUId = new Guid("ad707075-cf25-40bf-85c1-f5da38cf0d5d"),
				ModifiedInSchemaUId = new Guid("ad707075-cf25-40bf-85c1-f5da38cf0d5d"),
				CreatedInPackageId = new Guid("0a82de9d-1b49-4c10-947c-0386e85def78")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateConfItemEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateConfItemEventsProcessSchema() {
			var schema = new ConfItemEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new ConfItem(userConnection){Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new ConfItem_CMDBEventsProcess(userConnnection);
		}

		public override object Clone() {
			return new ConfItemSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new ConfItemSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ad707075-cf25-40bf-85c1-f5da38cf0d5d"));
		}

		#endregion

	}

	#endregion

	#region Class: ConfItem

	/// <summary>
	/// Configuration item.
	/// </summary>
	public class ConfItem : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public ConfItem(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "ConfItem";
		}

		public ConfItem(ConfItem source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Name.
		/// </summary>
		public  string Name {
			get {
				return GetTypedColumnValue<string>("Name");
			}
			set {
				SetColumnValue("Name", value);
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

		private ConfigItemType _type;
		/// <summary>
		/// Type.
		/// </summary>
		public  ConfigItemType Type {
			get {
				return _type ??
					(_type = LookupColumnEntities.GetEntity("Type") as ConfigItemType);
			}
		}

		/// <exclude/>
		public  Guid ModelId {
			get {
				return GetTypedColumnValue<Guid>("ModelId");
			}
			set {
				SetColumnValue("ModelId", value);
				_model = null;
			}
		}

		/// <exclude/>
		public  string ModelName {
			get {
				return GetTypedColumnValue<string>("ModelName");
			}
			set {
				SetColumnValue("ModelName", value);
				if (_model != null) {
					_model.Name = value;
				}
			}
		}

		private ConfigItemModel _model;
		/// <summary>
		/// Model.
		/// </summary>
		public  ConfigItemModel Model {
			get {
				return _model ??
					(_model = LookupColumnEntities.GetEntity("Model") as ConfigItemModel);
			}
		}

		/// <summary>
		/// Serial number.
		/// </summary>
		public  string SerialNumber {
			get {
				return GetTypedColumnValue<string>("SerialNumber");
			}
			set {
				SetColumnValue("SerialNumber", value);
			}
		}

		/// <summary>
		/// Inventory number.
		/// </summary>
		public  string InventoryNumber {
			get {
				return GetTypedColumnValue<string>("InventoryNumber");
			}
			set {
				SetColumnValue("InventoryNumber", value);
			}
		}

		/// <exclude/>
		public  Guid StatusId {
			get {
				return GetTypedColumnValue<Guid>("StatusId");
			}
			set {
				SetColumnValue("StatusId", value);
				_status = null;
			}
		}

		/// <exclude/>
		public  string StatusName {
			get {
				return GetTypedColumnValue<string>("StatusName");
			}
			set {
				SetColumnValue("StatusName", value);
				if (_status != null) {
					_status.Name = value;
				}
			}
		}

		private ConfigItemStatus _status;
		/// <summary>
		/// Status.
		/// </summary>
		public  ConfigItemStatus Status {
			get {
				return _status ??
					(_status = LookupColumnEntities.GetEntity("Status") as ConfigItemStatus);
			}
		}

		/// <summary>
		/// Purchased on.
		/// </summary>
		public  DateTime PurchaseDate {
			get {
				return GetTypedColumnValue<DateTime>("PurchaseDate");
			}
			set {
				SetColumnValue("PurchaseDate", value);
			}
		}

		/// <summary>
		/// Retired on.
		/// </summary>
		public  DateTime CancelDate {
			get {
				return GetTypedColumnValue<DateTime>("CancelDate");
			}
			set {
				SetColumnValue("CancelDate", value);
			}
		}

		/// <summary>
		/// Warranty valid until.
		/// </summary>
		public  DateTime WarrantyUntil {
			get {
				return GetTypedColumnValue<DateTime>("WarrantyUntil");
			}
			set {
				SetColumnValue("WarrantyUntil", value);
			}
		}

		/// <exclude/>
		public  Guid OwnerId {
			get {
				return GetTypedColumnValue<Guid>("OwnerId");
			}
			set {
				SetColumnValue("OwnerId", value);
				_owner = null;
			}
		}

		/// <exclude/>
		public  string OwnerName {
			get {
				return GetTypedColumnValue<string>("OwnerName");
			}
			set {
				SetColumnValue("OwnerName", value);
				if (_owner != null) {
					_owner.Name = value;
				}
			}
		}

		private Contact _owner;
		/// <summary>
		/// Owner.
		/// </summary>
		public  Contact Owner {
			get {
				return _owner ??
					(_owner = LookupColumnEntities.GetEntity("Owner") as Contact);
			}
		}

		/// <exclude/>
		public  Guid ParentConfItemId {
			get {
				return GetTypedColumnValue<Guid>("ParentConfItemId");
			}
			set {
				SetColumnValue("ParentConfItemId", value);
				_parentConfItem = null;
			}
		}

		/// <exclude/>
		public  string ParentConfItemName {
			get {
				return GetTypedColumnValue<string>("ParentConfItemName");
			}
			set {
				SetColumnValue("ParentConfItemName", value);
				if (_parentConfItem != null) {
					_parentConfItem.Name = value;
				}
			}
		}

		private ConfItem _parentConfItem;
		/// <summary>
		/// Parent CI.
		/// </summary>
		public  ConfItem ParentConfItem {
			get {
				return _parentConfItem ??
					(_parentConfItem = LookupColumnEntities.GetEntity("ParentConfItem") as ConfItem);
			}
		}

		/// <exclude/>
		public  Guid CategoryId {
			get {
				return GetTypedColumnValue<Guid>("CategoryId");
			}
			set {
				SetColumnValue("CategoryId", value);
				_category = null;
			}
		}

		/// <exclude/>
		public  string CategoryName {
			get {
				return GetTypedColumnValue<string>("CategoryName");
			}
			set {
				SetColumnValue("CategoryName", value);
				if (_category != null) {
					_category.Name = value;
				}
			}
		}

		private ConfigItemCategory _category;
		/// <summary>
		/// Category.
		/// </summary>
		public  ConfigItemCategory Category {
			get {
				return _category ??
					(_category = LookupColumnEntities.GetEntity("Category") as ConfigItemCategory);
			}
		}

		/// <summary>
		/// Notes.
		/// </summary>
		public  string Notes {
			get {
				return GetTypedColumnValue<string>("Notes");
			}
			set {
				SetColumnValue("Notes", value);
			}
		}

		/// <exclude/>
		public  Guid CountryId {
			get {
				return GetTypedColumnValue<Guid>("CountryId");
			}
			set {
				SetColumnValue("CountryId", value);
				_country = null;
			}
		}

		/// <exclude/>
		public  string CountryName {
			get {
				return GetTypedColumnValue<string>("CountryName");
			}
			set {
				SetColumnValue("CountryName", value);
				if (_country != null) {
					_country.Name = value;
				}
			}
		}

		private Country _country;
		/// <summary>
		/// Country.
		/// </summary>
		public  Country Country {
			get {
				return _country ??
					(_country = LookupColumnEntities.GetEntity("Country") as Country);
			}
		}

		/// <exclude/>
		public  Guid RegionId {
			get {
				return GetTypedColumnValue<Guid>("RegionId");
			}
			set {
				SetColumnValue("RegionId", value);
				_region = null;
			}
		}

		/// <exclude/>
		public  string RegionName {
			get {
				return GetTypedColumnValue<string>("RegionName");
			}
			set {
				SetColumnValue("RegionName", value);
				if (_region != null) {
					_region.Name = value;
				}
			}
		}

		private Region _region;
		/// <summary>
		/// Region.
		/// </summary>
		public  Region Region {
			get {
				return _region ??
					(_region = LookupColumnEntities.GetEntity("Region") as Region);
			}
		}

		/// <exclude/>
		public  Guid CityId {
			get {
				return GetTypedColumnValue<Guid>("CityId");
			}
			set {
				SetColumnValue("CityId", value);
				_city = null;
			}
		}

		/// <exclude/>
		public  string CityName {
			get {
				return GetTypedColumnValue<string>("CityName");
			}
			set {
				SetColumnValue("CityName", value);
				if (_city != null) {
					_city.Name = value;
				}
			}
		}

		private City _city;
		/// <summary>
		/// City.
		/// </summary>
		public  City City {
			get {
				return _city ??
					(_city = LookupColumnEntities.GetEntity("City") as City);
			}
		}

		/// <summary>
		/// Street.
		/// </summary>
		public  string Street {
			get {
				return GetTypedColumnValue<string>("Street");
			}
			set {
				SetColumnValue("Street", value);
			}
		}

		/// <summary>
		/// Address.
		/// </summary>
		public  string Address {
			get {
				return GetTypedColumnValue<string>("Address");
			}
			set {
				SetColumnValue("Address", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new ConfItem_CMDBEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Inserting += (s, e) => ThrowEvent("ConfItemInserting", e);
			Validating += (s, e) => ThrowEvent("ConfItemValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new ConfItem(this);
		}

		#endregion

	}

	#endregion

	#region Class: ConfItem_CMDBEventsProcess

	/// <exclude/>
	public class ConfItem_CMDBEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_LocalMessageEventsProcess<TEntity> where TEntity : ConfItem
	{

		public ConfItem_CMDBEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ConfItem_CMDBEventsProcess";
			SchemaUId = new Guid("ad707075-cf25-40bf-85c1-f5da38cf0d5d");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private  Guid InternalSchemaUId {
			get {
				return new Guid("ad707075-cf25-40bf-85c1-f5da38cf0d5d");
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

	#region Class: ConfItem_CMDBEventsProcess

	/// <exclude/>
	public class ConfItem_CMDBEventsProcess : ConfItem_CMDBEventsProcess<ConfItem>
	{

		public ConfItem_CMDBEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: ConfItemEventsProcessSchema

	/// <exclude/>
	public class ConfItemEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public ConfItemEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public ConfItemEventsProcessSchema(ConfItemEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "ConfItem_CMDBEventsProcess";
			UId = new Guid("7a8bcd20-8325-4f5f-aae7-bf77b6fb9b1f");
			CreatedInPackageId = new Guid("305fcfca-4160-4398-90a9-d5e84be0ae12");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
		}

		protected override ProcessSchemaParameter CreateNextProcessElementReadyParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("d9e67329-fde2-4fbd-aa49-2d69ca3d2b5b"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				Name = @"NextProcessElementReady",
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected override ProcessSchemaParameter CreateIsProcessModeSaveParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("4cb16350-d39b-4247-9da5-33032cf8667d"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				Name = @"IsProcessModeSave",
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
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
				CreatedInPackageId = new Guid("305fcfca-4160-4398-90a9-d5e84be0ae12")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("cde525cf-d220-4d2a-b963-e55254c639fc"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("305fcfca-4160-4398-90a9-d5e84be0ae12")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5c9c82c6-ba6d-4a57-9a14-87fe8faa4ebb"),
				Name = "Terrasoft.Core.DB",
				Alias = "",
				CreatedInPackageId = new Guid("305fcfca-4160-4398-90a9-d5e84be0ae12")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7821de68-c82b-4917-a6cd-add2adfbe400"),
				Name = "Terrasoft.Common",
				Alias = "",
				CreatedInPackageId = new Guid("305fcfca-4160-4398-90a9-d5e84be0ae12")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d67de76f-9cbc-4bfc-babb-6f65cb89b973"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("305fcfca-4160-4398-90a9-d5e84be0ae12")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("74160d3b-65e3-4694-b554-089f2d980e54"),
				Name = "Newtonsoft.Json",
				Alias = "",
				CreatedInPackageId = new Guid("305fcfca-4160-4398-90a9-d5e84be0ae12")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e401300a-9f16-40c2-9788-cf310ae9d1c5"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("305fcfca-4160-4398-90a9-d5e84be0ae12")
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
			return new ConfItemEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("7a8bcd20-8325-4f5f-aae7-bf77b6fb9b1f"));
		}

		#endregion

	}

	#endregion


	#region Class: ConfItemEventsProcess

	/// <exclude/>
	public class ConfItemEventsProcess : ConfItem_CMDBEventsProcess
	{

		public ConfItemEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

