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

	#region Class: ConfItemRelationshipSchema

	/// <exclude/>
	public class ConfItemRelationshipSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public ConfItemRelationshipSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public ConfItemRelationshipSchema(ConfItemRelationshipSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public ConfItemRelationshipSchema(ConfItemRelationshipSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("8857f5ff-b876-481c-9c05-7d93c08f7704");
			RealUId = new Guid("8857f5ff-b876-481c-9c05-7d93c08f7704");
			Name = "ConfItemRelationship";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("4516643a-023b-4e8c-93a2-5f32ae9ffe7d");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("01612ecc-abf7-4399-af90-6e9e507fd2bd")) == null) {
				Columns.Add(CreateConfItemAColumn());
			}
			if (Columns.FindByUId(new Guid("e1c56d8a-583c-4067-bae7-420eade26979")) == null) {
				Columns.Add(CreateConfItemBColumn());
			}
			if (Columns.FindByUId(new Guid("611377a0-ae64-4d0f-b50e-c15db72bac75")) == null) {
				Columns.Add(CreateDependencyCategoryColumn());
			}
			if (Columns.FindByUId(new Guid("fc83d1eb-1845-4b41-b836-d6b2c8cadf6a")) == null) {
				Columns.Add(CreateDependencyTypeColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateConfItemAColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("01612ecc-abf7-4399-af90-6e9e507fd2bd"),
				Name = @"ConfItemA",
				ReferenceSchemaUId = new Guid("ad707075-cf25-40bf-85c1-f5da38cf0d5d"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("8857f5ff-b876-481c-9c05-7d93c08f7704"),
				ModifiedInSchemaUId = new Guid("8857f5ff-b876-481c-9c05-7d93c08f7704"),
				CreatedInPackageId = new Guid("4516643a-023b-4e8c-93a2-5f32ae9ffe7d")
			};
		}

		protected virtual EntitySchemaColumn CreateConfItemBColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("e1c56d8a-583c-4067-bae7-420eade26979"),
				Name = @"ConfItemB",
				ReferenceSchemaUId = new Guid("ad707075-cf25-40bf-85c1-f5da38cf0d5d"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("8857f5ff-b876-481c-9c05-7d93c08f7704"),
				ModifiedInSchemaUId = new Guid("8857f5ff-b876-481c-9c05-7d93c08f7704"),
				CreatedInPackageId = new Guid("4516643a-023b-4e8c-93a2-5f32ae9ffe7d")
			};
		}

		protected virtual EntitySchemaColumn CreateDependencyCategoryColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("611377a0-ae64-4d0f-b50e-c15db72bac75"),
				Name = @"DependencyCategory",
				ReferenceSchemaUId = new Guid("5624aa9d-ec9a-4ea9-bf68-1059ef974609"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("8857f5ff-b876-481c-9c05-7d93c08f7704"),
				ModifiedInSchemaUId = new Guid("8857f5ff-b876-481c-9c05-7d93c08f7704"),
				CreatedInPackageId = new Guid("4516643a-023b-4e8c-93a2-5f32ae9ffe7d"),
				IsSimpleLookup = true
			};
		}

		protected virtual EntitySchemaColumn CreateDependencyTypeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("fc83d1eb-1845-4b41-b836-d6b2c8cadf6a"),
				Name = @"DependencyType",
				ReferenceSchemaUId = new Guid("97de7670-a897-47d4-a2a5-68b9739ef7dc"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("8857f5ff-b876-481c-9c05-7d93c08f7704"),
				ModifiedInSchemaUId = new Guid("8857f5ff-b876-481c-9c05-7d93c08f7704"),
				CreatedInPackageId = new Guid("2acda023-1ff7-4efb-a488-cbf6ac347a40")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateConfItemRelationshipEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateConfItemRelationshipEventsProcessSchema() {
			var schema = new ConfItemRelationshipEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new ConfItemRelationship(userConnection){Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new ConfItemRelationship_ServiceModelEventsProcess(userConnnection);
		}

		public override object Clone() {
			return new ConfItemRelationshipSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new ConfItemRelationshipSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("8857f5ff-b876-481c-9c05-7d93c08f7704"));
		}

		#endregion

	}

	#endregion

	#region Class: ConfItemRelationship

	/// <summary>
	/// Connected configuration items.
	/// </summary>
	public class ConfItemRelationship : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public ConfItemRelationship(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "ConfItemRelationship";
		}

		public ConfItemRelationship(ConfItemRelationship source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public  Guid ConfItemAId {
			get {
				return GetTypedColumnValue<Guid>("ConfItemAId");
			}
			set {
				SetColumnValue("ConfItemAId", value);
				_confItemA = null;
			}
		}

		/// <exclude/>
		public  string ConfItemAName {
			get {
				return GetTypedColumnValue<string>("ConfItemAName");
			}
			set {
				SetColumnValue("ConfItemAName", value);
				if (_confItemA != null) {
					_confItemA.Name = value;
				}
			}
		}

		private ConfItem _confItemA;
		/// <summary>
		/// Configuration item A.
		/// </summary>
		public  ConfItem ConfItemA {
			get {
				return _confItemA ??
					(_confItemA = LookupColumnEntities.GetEntity("ConfItemA") as ConfItem);
			}
		}

		/// <exclude/>
		public  Guid ConfItemBId {
			get {
				return GetTypedColumnValue<Guid>("ConfItemBId");
			}
			set {
				SetColumnValue("ConfItemBId", value);
				_confItemB = null;
			}
		}

		/// <exclude/>
		public  string ConfItemBName {
			get {
				return GetTypedColumnValue<string>("ConfItemBName");
			}
			set {
				SetColumnValue("ConfItemBName", value);
				if (_confItemB != null) {
					_confItemB.Name = value;
				}
			}
		}

		private ConfItem _confItemB;
		/// <summary>
		/// Configuration item B.
		/// </summary>
		public  ConfItem ConfItemB {
			get {
				return _confItemB ??
					(_confItemB = LookupColumnEntities.GetEntity("ConfItemB") as ConfItem);
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

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new ConfItemRelationship_ServiceModelEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Validating += (s, e) => ThrowEvent("ConfItemRelationshipValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new ConfItemRelationship(this);
		}

		#endregion

	}

	#endregion

	#region Class: ConfItemRelationship_ServiceModelEventsProcess

	/// <exclude/>
	public class ConfItemRelationship_ServiceModelEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_LocalMessageEventsProcess<TEntity> where TEntity : ConfItemRelationship
	{

		public ConfItemRelationship_ServiceModelEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ConfItemRelationship_ServiceModelEventsProcess";
			SchemaUId = new Guid("8857f5ff-b876-481c-9c05-7d93c08f7704");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private  Guid InternalSchemaUId {
			get {
				return new Guid("8857f5ff-b876-481c-9c05-7d93c08f7704");
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

	#region Class: ConfItemRelationship_ServiceModelEventsProcess

	/// <exclude/>
	public class ConfItemRelationship_ServiceModelEventsProcess : ConfItemRelationship_ServiceModelEventsProcess<ConfItemRelationship>
	{

		public ConfItemRelationship_ServiceModelEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: ConfItemRelationshipEventsProcessSchema

	/// <exclude/>
	public class ConfItemRelationshipEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public ConfItemRelationshipEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public ConfItemRelationshipEventsProcessSchema(ConfItemRelationshipEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "ConfItemRelationship_ServiceModelEventsProcess";
			UId = new Guid("8590d802-7e2f-4465-b41f-04f2e910c85b");
			CreatedInPackageId = new Guid("4516643a-023b-4e8c-93a2-5f32ae9ffe7d");
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
			return new ConfItemRelationshipEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("8590d802-7e2f-4465-b41f-04f2e910c85b"));
		}

		#endregion

	}

	#endregion


	#region Class: ConfItemRelationshipEventsProcess

	/// <exclude/>
	public class ConfItemRelationshipEventsProcess : ConfItemRelationship_ServiceModelEventsProcess
	{

		public ConfItemRelationshipEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

