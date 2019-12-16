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

	#region Class: VwServiceRelationshipSchema

	/// <exclude/>
	public class VwServiceRelationshipSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public VwServiceRelationshipSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public VwServiceRelationshipSchema(VwServiceRelationshipSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public VwServiceRelationshipSchema(VwServiceRelationshipSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("3708db29-d754-44ad-95ce-aaf09d2a6138");
			RealUId = new Guid("3708db29-d754-44ad-95ce-aaf09d2a6138");
			Name = "VwServiceRelationship";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("2acda023-1ff7-4efb-a488-cbf6ac347a40");
			IsDBView = true;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("b8e4c88a-40bc-45b3-95c2-e86a16b8c171")) == null) {
				Columns.Add(CreateServiceItemAColumn());
			}
			if (Columns.FindByUId(new Guid("084788d9-7402-4915-a184-d2055ec901ca")) == null) {
				Columns.Add(CreateServiceItemBColumn());
			}
			if (Columns.FindByUId(new Guid("2f4c5305-cdf0-42e4-9d80-2771c71a71b5")) == null) {
				Columns.Add(CreateDependencyCategoryColumn());
			}
			if (Columns.FindByUId(new Guid("e366773d-03be-4eda-9610-28e02598f4cb")) == null) {
				Columns.Add(CreateDependencyTypeColumn());
			}
			if (Columns.FindByUId(new Guid("7f69409e-99e2-4124-ba84-5e34db4f5da4")) == null) {
				Columns.Add(CreateDependencyTypeCategoryColumn());
			}
			if (Columns.FindByUId(new Guid("e14c3235-52f9-4667-ae7c-4538c3fff7cb")) == null) {
				Columns.Add(CreateDependencyTypeReverseNameColumn());
			}
			if (Columns.FindByUId(new Guid("77bd3e91-ad4e-4623-90f5-0012628bd25d")) == null) {
				Columns.Add(CreateIsCopyColumn());
			}
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.IsValueCloneable = true;
			column.ModifiedInSchemaUId = new Guid("3708db29-d754-44ad-95ce-aaf09d2a6138");
			return column;
		}

		protected override EntitySchemaColumn CreateProcessListenersColumn() {
			EntitySchemaColumn column = base.CreateProcessListenersColumn();
			column.IsValueCloneable = false;
			column.ModifiedInSchemaUId = new Guid("3708db29-d754-44ad-95ce-aaf09d2a6138");
			return column;
		}

		protected virtual EntitySchemaColumn CreateServiceItemAColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("b8e4c88a-40bc-45b3-95c2-e86a16b8c171"),
				Name = @"ServiceItemA",
				ReferenceSchemaUId = new Guid("c6c44f0a-193e-4b5c-b35e-220a60c06898"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsValueCloneable = false,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("3708db29-d754-44ad-95ce-aaf09d2a6138"),
				ModifiedInSchemaUId = new Guid("3708db29-d754-44ad-95ce-aaf09d2a6138"),
				CreatedInPackageId = new Guid("2acda023-1ff7-4efb-a488-cbf6ac347a40")
			};
		}

		protected virtual EntitySchemaColumn CreateServiceItemBColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("084788d9-7402-4915-a184-d2055ec901ca"),
				Name = @"ServiceItemB",
				ReferenceSchemaUId = new Guid("c6c44f0a-193e-4b5c-b35e-220a60c06898"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsValueCloneable = false,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("3708db29-d754-44ad-95ce-aaf09d2a6138"),
				ModifiedInSchemaUId = new Guid("3708db29-d754-44ad-95ce-aaf09d2a6138"),
				CreatedInPackageId = new Guid("2acda023-1ff7-4efb-a488-cbf6ac347a40")
			};
		}

		protected virtual EntitySchemaColumn CreateDependencyCategoryColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("2f4c5305-cdf0-42e4-9d80-2771c71a71b5"),
				Name = @"DependencyCategory",
				ReferenceSchemaUId = new Guid("5624aa9d-ec9a-4ea9-bf68-1059ef974609"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsValueCloneable = false,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("3708db29-d754-44ad-95ce-aaf09d2a6138"),
				ModifiedInSchemaUId = new Guid("3708db29-d754-44ad-95ce-aaf09d2a6138"),
				CreatedInPackageId = new Guid("2acda023-1ff7-4efb-a488-cbf6ac347a40"),
				IsSimpleLookup = true
			};
		}

		protected virtual EntitySchemaColumn CreateDependencyTypeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("e366773d-03be-4eda-9610-28e02598f4cb"),
				Name = @"DependencyType",
				ReferenceSchemaUId = new Guid("97de7670-a897-47d4-a2a5-68b9739ef7dc"),
				IsValueCloneable = false,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("3708db29-d754-44ad-95ce-aaf09d2a6138"),
				ModifiedInSchemaUId = new Guid("3708db29-d754-44ad-95ce-aaf09d2a6138"),
				CreatedInPackageId = new Guid("2acda023-1ff7-4efb-a488-cbf6ac347a40"),
				IsSimpleLookup = true
			};
		}

		protected virtual EntitySchemaColumn CreateDependencyTypeCategoryColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("7f69409e-99e2-4124-ba84-5e34db4f5da4"),
				Name = @"DependencyTypeCategory",
				ReferenceSchemaUId = new Guid("5624aa9d-ec9a-4ea9-bf68-1059ef974609"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("3708db29-d754-44ad-95ce-aaf09d2a6138"),
				ModifiedInSchemaUId = new Guid("3708db29-d754-44ad-95ce-aaf09d2a6138"),
				CreatedInPackageId = new Guid("2acda023-1ff7-4efb-a488-cbf6ac347a40")
			};
		}

		protected virtual EntitySchemaColumn CreateDependencyTypeReverseNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("e14c3235-52f9-4667-ae7c-4538c3fff7cb"),
				Name = @"DependencyTypeReverseName",
				CreatedInSchemaUId = new Guid("3708db29-d754-44ad-95ce-aaf09d2a6138"),
				ModifiedInSchemaUId = new Guid("3708db29-d754-44ad-95ce-aaf09d2a6138"),
				CreatedInPackageId = new Guid("2acda023-1ff7-4efb-a488-cbf6ac347a40")
			};
		}

		protected virtual EntitySchemaColumn CreateIsCopyColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("77bd3e91-ad4e-4623-90f5-0012628bd25d"),
				Name = @"IsCopy",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("3708db29-d754-44ad-95ce-aaf09d2a6138"),
				ModifiedInSchemaUId = new Guid("3708db29-d754-44ad-95ce-aaf09d2a6138"),
				CreatedInPackageId = new Guid("2acda023-1ff7-4efb-a488-cbf6ac347a40")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateVwServiceRelationshipEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateVwServiceRelationshipEventsProcessSchema() {
			var schema = new VwServiceRelationshipEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new VwServiceRelationship(userConnection){Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new VwServiceRelationship_ServiceModelEventsProcess(userConnnection);
		}

		public override object Clone() {
			return new VwServiceRelationshipSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new VwServiceRelationshipSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("3708db29-d754-44ad-95ce-aaf09d2a6138"));
		}

		#endregion

	}

	#endregion

	#region Class: VwServiceRelationship

	/// <summary>
	/// Related services (view).
	/// </summary>
	public class VwServiceRelationship : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public VwServiceRelationship(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "VwServiceRelationship";
		}

		public VwServiceRelationship(VwServiceRelationship source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public  Guid ServiceItemAId {
			get {
				return GetTypedColumnValue<Guid>("ServiceItemAId");
			}
			set {
				SetColumnValue("ServiceItemAId", value);
				_serviceItemA = null;
			}
		}

		/// <exclude/>
		public  string ServiceItemAName {
			get {
				return GetTypedColumnValue<string>("ServiceItemAName");
			}
			set {
				SetColumnValue("ServiceItemAName", value);
				if (_serviceItemA != null) {
					_serviceItemA.Name = value;
				}
			}
		}

		private ServiceItem _serviceItemA;
		/// <summary>
		/// Service A.
		/// </summary>
		public  ServiceItem ServiceItemA {
			get {
				return _serviceItemA ??
					(_serviceItemA = LookupColumnEntities.GetEntity("ServiceItemA") as ServiceItem);
			}
		}

		/// <exclude/>
		public  Guid ServiceItemBId {
			get {
				return GetTypedColumnValue<Guid>("ServiceItemBId");
			}
			set {
				SetColumnValue("ServiceItemBId", value);
				_serviceItemB = null;
			}
		}

		/// <exclude/>
		public  string ServiceItemBName {
			get {
				return GetTypedColumnValue<string>("ServiceItemBName");
			}
			set {
				SetColumnValue("ServiceItemBName", value);
				if (_serviceItemB != null) {
					_serviceItemB.Name = value;
				}
			}
		}

		private ServiceItem _serviceItemB;
		/// <summary>
		/// Service B.
		/// </summary>
		public  ServiceItem ServiceItemB {
			get {
				return _serviceItemB ??
					(_serviceItemB = LookupColumnEntities.GetEntity("ServiceItemB") as ServiceItem);
			}
		}

		/// <exclude/>
		public  Guid DependencyCategoryId {
			get {
				return GetTypedColumnValue<Guid>("DependencyCategoryId");
			}
			set {
				SetColumnValue("DependencyCategoryId", value);
				_dependencyCategory = null;
			}
		}

		/// <exclude/>
		public  string DependencyCategoryName {
			get {
				return GetTypedColumnValue<string>("DependencyCategoryName");
			}
			set {
				SetColumnValue("DependencyCategoryName", value);
				if (_dependencyCategory != null) {
					_dependencyCategory.Name = value;
				}
			}
		}

		private DependencyCategory _dependencyCategory;
		/// <summary>
		/// Category.
		/// </summary>
		public  DependencyCategory DependencyCategory {
			get {
				return _dependencyCategory ??
					(_dependencyCategory = LookupColumnEntities.GetEntity("DependencyCategory") as DependencyCategory);
			}
		}

		/// <exclude/>
		public  Guid DependencyTypeId {
			get {
				return GetTypedColumnValue<Guid>("DependencyTypeId");
			}
			set {
				SetColumnValue("DependencyTypeId", value);
				_dependencyType = null;
			}
		}

		/// <exclude/>
		public  string DependencyTypeName {
			get {
				return GetTypedColumnValue<string>("DependencyTypeName");
			}
			set {
				SetColumnValue("DependencyTypeName", value);
				if (_dependencyType != null) {
					_dependencyType.Name = value;
				}
			}
		}

		private DependencyType _dependencyType;
		/// <summary>
		/// Type.
		/// </summary>
		public  DependencyType DependencyType {
			get {
				return _dependencyType ??
					(_dependencyType = LookupColumnEntities.GetEntity("DependencyType") as DependencyType);
			}
		}

		/// <exclude/>
		public  Guid DependencyTypeCategoryId {
			get {
				return GetTypedColumnValue<Guid>("DependencyTypeCategoryId");
			}
			set {
				SetColumnValue("DependencyTypeCategoryId", value);
				_dependencyTypeCategory = null;
			}
		}

		/// <exclude/>
		public  string DependencyTypeCategoryName {
			get {
				return GetTypedColumnValue<string>("DependencyTypeCategoryName");
			}
			set {
				SetColumnValue("DependencyTypeCategoryName", value);
				if (_dependencyTypeCategory != null) {
					_dependencyTypeCategory.Name = value;
				}
			}
		}

		private DependencyCategory _dependencyTypeCategory;
		/// <summary>
		/// Object dependency type category.
		/// </summary>
		public  DependencyCategory DependencyTypeCategory {
			get {
				return _dependencyTypeCategory ??
					(_dependencyTypeCategory = LookupColumnEntities.GetEntity("DependencyTypeCategory") as DependencyCategory);
			}
		}

		/// <summary>
		/// Reverse dependency name.
		/// </summary>
		public  string DependencyTypeReverseName {
			get {
				return GetTypedColumnValue<string>("DependencyTypeReverseName");
			}
			set {
				SetColumnValue("DependencyTypeReverseName", value);
			}
		}

		/// <summary>
		/// Cc.
		/// </summary>
		public  bool IsCopy {
			get {
				return GetTypedColumnValue<bool>("IsCopy");
			}
			set {
				SetColumnValue("IsCopy", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new VwServiceRelationship_ServiceModelEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Validating += (s, e) => ThrowEvent("VwServiceRelationshipValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new VwServiceRelationship(this);
		}

		#endregion

	}

	#endregion

	#region Class: VwServiceRelationship_ServiceModelEventsProcess

	/// <exclude/>
	public class VwServiceRelationship_ServiceModelEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_LocalMessageEventsProcess<TEntity> where TEntity : VwServiceRelationship
	{

		public VwServiceRelationship_ServiceModelEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "VwServiceRelationship_ServiceModelEventsProcess";
			SchemaUId = new Guid("3708db29-d754-44ad-95ce-aaf09d2a6138");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private  Guid InternalSchemaUId {
			get {
				return new Guid("3708db29-d754-44ad-95ce-aaf09d2a6138");
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

	#region Class: VwServiceRelationship_ServiceModelEventsProcess

	/// <exclude/>
	public class VwServiceRelationship_ServiceModelEventsProcess : VwServiceRelationship_ServiceModelEventsProcess<VwServiceRelationship>
	{

		public VwServiceRelationship_ServiceModelEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: VwServiceRelationshipEventsProcessSchema

	/// <exclude/>
	public class VwServiceRelationshipEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public VwServiceRelationshipEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public VwServiceRelationshipEventsProcessSchema(VwServiceRelationshipEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "VwServiceRelationship_ServiceModelEventsProcess";
			UId = new Guid("a8b23040-fa6a-48f2-be09-6cb7b7886316");
			CreatedInPackageId = new Guid("2acda023-1ff7-4efb-a488-cbf6ac347a40");
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

		protected override SchemaMethod CreateLocalMessageExecutingMethod() {
			SchemaMethod method = base.CreateLocalMessageExecutingMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,77,141,75,10,194,48,16,134,247,158,98,150,45,148,92,160,184,42,130,11,221,213,3,12,225,111,26,136,147,50,51,86,122,123,45,69,112,255,61,86,86,42,207,43,202,2,165,51,9,222,52,66,149,173,78,30,134,42,83,78,47,101,207,85,194,173,70,46,119,152,113,194,33,52,62,103,11,23,241,236,91,71,15,131,126,13,65,220,241,142,226,204,146,48,110,11,218,254,244,123,132,65,193,142,255,86,211,246,31,106,54,191,216,134,0,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new VwServiceRelationshipEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a8b23040-fa6a-48f2-be09-6cb7b7886316"));
		}

		#endregion

	}

	#endregion


	#region Class: VwServiceRelationshipEventsProcess

	/// <exclude/>
	public class VwServiceRelationshipEventsProcess : VwServiceRelationship_ServiceModelEventsProcess
	{

		public VwServiceRelationshipEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

