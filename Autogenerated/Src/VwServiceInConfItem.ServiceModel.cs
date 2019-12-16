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

	#region Class: VwServiceInConfItemSchema

	/// <exclude/>
	public class VwServiceInConfItemSchema : Terrasoft.Configuration.ServiceInConfItemSchema
	{

		#region Constructors: Public

		public VwServiceInConfItemSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public VwServiceInConfItemSchema(VwServiceInConfItemSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public VwServiceInConfItemSchema(VwServiceInConfItemSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f352fdd7-1847-46e6-a7bc-cd3772b42761");
			RealUId = new Guid("f352fdd7-1847-46e6-a7bc-cd3772b42761");
			Name = "VwServiceInConfItem";
			ParentSchemaUId = new Guid("ef0acf4c-0272-4e3b-9391-e12cf13cec33");
			ExtendParent = false;
			CreatedInPackageId = new Guid("4516643a-023b-4e8c-93a2-5f32ae9ffe7d");
			IsDBView = true;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("582f8b4a-aec6-4bfc-aa4b-6c0752cf9ede")) == null) {
				Columns.Add(CreateDependencyCategoryReverseColumn());
			}
			if (Columns.FindByUId(new Guid("fb18483d-ee4b-4bd2-b0e3-2fc96e3c32f2")) == null) {
				Columns.Add(CreateDependencyTypeCategoryColumn());
			}
			if (Columns.FindByUId(new Guid("70e64548-4af6-4245-88c6-aa88dfc02606")) == null) {
				Columns.Add(CreateDependencyTypeReverseNameColumn());
			}
		}

		protected override EntitySchemaColumn CreateDependencyTypeColumn() {
			EntitySchemaColumn column = base.CreateDependencyTypeColumn();
			column.IsSimpleLookup = true;
			column.ModifiedInSchemaUId = new Guid("f352fdd7-1847-46e6-a7bc-cd3772b42761");
			return column;
		}

		protected virtual EntitySchemaColumn CreateDependencyCategoryReverseColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("582f8b4a-aec6-4bfc-aa4b-6c0752cf9ede"),
				Name = @"DependencyCategoryReverse",
				ReferenceSchemaUId = new Guid("5624aa9d-ec9a-4ea9-bf68-1059ef974609"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("f352fdd7-1847-46e6-a7bc-cd3772b42761"),
				ModifiedInSchemaUId = new Guid("f352fdd7-1847-46e6-a7bc-cd3772b42761"),
				CreatedInPackageId = new Guid("4516643a-023b-4e8c-93a2-5f32ae9ffe7d"),
				IsSimpleLookup = true
			};
		}

		protected virtual EntitySchemaColumn CreateDependencyTypeCategoryColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("fb18483d-ee4b-4bd2-b0e3-2fc96e3c32f2"),
				Name = @"DependencyTypeCategory",
				ReferenceSchemaUId = new Guid("5624aa9d-ec9a-4ea9-bf68-1059ef974609"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("f352fdd7-1847-46e6-a7bc-cd3772b42761"),
				ModifiedInSchemaUId = new Guid("f352fdd7-1847-46e6-a7bc-cd3772b42761"),
				CreatedInPackageId = new Guid("2acda023-1ff7-4efb-a488-cbf6ac347a40")
			};
		}

		protected virtual EntitySchemaColumn CreateDependencyTypeReverseNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("70e64548-4af6-4245-88c6-aa88dfc02606"),
				Name = @"DependencyTypeReverseName",
				CreatedInSchemaUId = new Guid("f352fdd7-1847-46e6-a7bc-cd3772b42761"),
				ModifiedInSchemaUId = new Guid("f352fdd7-1847-46e6-a7bc-cd3772b42761"),
				CreatedInPackageId = new Guid("2acda023-1ff7-4efb-a488-cbf6ac347a40")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateVwServiceInConfItemEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateVwServiceInConfItemEventsProcessSchema() {
			var schema = new VwServiceInConfItemEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new VwServiceInConfItem(userConnection){Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new VwServiceInConfItem_ServiceModelEventsProcess(userConnnection);
		}

		public override object Clone() {
			return new VwServiceInConfItemSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new VwServiceInConfItemSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f352fdd7-1847-46e6-a7bc-cd3772b42761"));
		}

		#endregion

	}

	#endregion

	#region Class: VwServiceInConfItem

	/// <summary>
	/// Service in configuration item (view).
	/// </summary>
	public class VwServiceInConfItem : Terrasoft.Configuration.ServiceInConfItem
	{

		#region Constructors: Public

		public VwServiceInConfItem(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "VwServiceInConfItem";
		}

		public VwServiceInConfItem(VwServiceInConfItem source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public  Guid DependencyCategoryReverseId {
			get {
				return GetTypedColumnValue<Guid>("DependencyCategoryReverseId");
			}
			set {
				SetColumnValue("DependencyCategoryReverseId", value);
				_dependencyCategoryReverse = null;
			}
		}

		/// <exclude/>
		public  string DependencyCategoryReverseName {
			get {
				return GetTypedColumnValue<string>("DependencyCategoryReverseName");
			}
			set {
				SetColumnValue("DependencyCategoryReverseName", value);
				if (_dependencyCategoryReverse != null) {
					_dependencyCategoryReverse.Name = value;
				}
			}
		}

		private DependencyCategory _dependencyCategoryReverse;
		/// <summary>
		/// Reverse category.
		/// </summary>
		public  DependencyCategory DependencyCategoryReverse {
			get {
				return _dependencyCategoryReverse ??
					(_dependencyCategoryReverse = LookupColumnEntities.GetEntity("DependencyCategoryReverse") as DependencyCategory);
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

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new VwServiceInConfItem_ServiceModelEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Validating += (s, e) => ThrowEvent("VwServiceInConfItemValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new VwServiceInConfItem(this);
		}

		#endregion

	}

	#endregion

	#region Class: VwServiceInConfItem_ServiceModelEventsProcess

	/// <exclude/>
	public class VwServiceInConfItem_ServiceModelEventsProcess<TEntity> : Terrasoft.Configuration.ServiceInConfItem_ServiceModelEventsProcess<TEntity> where TEntity : VwServiceInConfItem
	{

		public VwServiceInConfItem_ServiceModelEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "VwServiceInConfItem_ServiceModelEventsProcess";
			SchemaUId = new Guid("f352fdd7-1847-46e6-a7bc-cd3772b42761");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private  Guid InternalSchemaUId {
			get {
				return new Guid("f352fdd7-1847-46e6-a7bc-cd3772b42761");
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

	#region Class: VwServiceInConfItem_ServiceModelEventsProcess

	/// <exclude/>
	public class VwServiceInConfItem_ServiceModelEventsProcess : VwServiceInConfItem_ServiceModelEventsProcess<VwServiceInConfItem>
	{

		public VwServiceInConfItem_ServiceModelEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: VwServiceInConfItemEventsProcessSchema

	/// <exclude/>
	public class VwServiceInConfItemEventsProcessSchema : Terrasoft.Configuration.ServiceInConfItemEventsProcessSchema
	{

		#region Constructors: Public

		public VwServiceInConfItemEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public VwServiceInConfItemEventsProcessSchema(VwServiceInConfItemEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "VwServiceInConfItem_ServiceModelEventsProcess";
			UId = new Guid("ddf99762-05ec-4ef9-8a93-d9223b8f1792");
			CreatedInPackageId = new Guid("4516643a-023b-4e8c-93a2-5f32ae9ffe7d");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("5e5526b8-8156-48c1-ba79-7352f68f6841");
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
			return new VwServiceInConfItemEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ddf99762-05ec-4ef9-8a93-d9223b8f1792"));
		}

		#endregion

	}

	#endregion


	#region Class: VwServiceInConfItemEventsProcess

	/// <exclude/>
	public class VwServiceInConfItemEventsProcess : VwServiceInConfItem_ServiceModelEventsProcess
	{

		public VwServiceInConfItemEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

