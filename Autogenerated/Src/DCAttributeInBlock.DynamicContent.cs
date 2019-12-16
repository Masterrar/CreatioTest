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

	#region Class: DCAttributeInBlockSchema

	/// <exclude/>
	public class DCAttributeInBlockSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public DCAttributeInBlockSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public DCAttributeInBlockSchema(DCAttributeInBlockSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public DCAttributeInBlockSchema(DCAttributeInBlockSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("ab22bcbe-a1fe-4e6c-b018-7454c04dae78");
			RealUId = new Guid("ab22bcbe-a1fe-4e6c-b018-7454c04dae78");
			Name = "DCAttributeInBlock";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("9f77887e-50a7-49c4-86e4-3ef2d36a21a8");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("39a5348f-04d0-4552-8184-959923b1d9ef")) == null) {
				Columns.Add(CreateDCAttributeColumn());
			}
			if (Columns.FindByUId(new Guid("defedd59-badb-48fe-9157-e1f7e55aeb68")) == null) {
				Columns.Add(CreateDCTemplateBlockColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateDCAttributeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("39a5348f-04d0-4552-8184-959923b1d9ef"),
				Name = @"DCAttribute",
				ReferenceSchemaUId = new Guid("7d79cef7-2211-44e0-a70a-b5f14f7304c3"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("ab22bcbe-a1fe-4e6c-b018-7454c04dae78"),
				ModifiedInSchemaUId = new Guid("ab22bcbe-a1fe-4e6c-b018-7454c04dae78"),
				CreatedInPackageId = new Guid("9f77887e-50a7-49c4-86e4-3ef2d36a21a8")
			};
		}

		protected virtual EntitySchemaColumn CreateDCTemplateBlockColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("defedd59-badb-48fe-9157-e1f7e55aeb68"),
				Name = @"DCTemplateBlock",
				ReferenceSchemaUId = new Guid("152c2238-d6e5-44d5-bcff-de341ff641ad"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("ab22bcbe-a1fe-4e6c-b018-7454c04dae78"),
				ModifiedInSchemaUId = new Guid("ab22bcbe-a1fe-4e6c-b018-7454c04dae78"),
				CreatedInPackageId = new Guid("9f77887e-50a7-49c4-86e4-3ef2d36a21a8")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateDCAttributeInBlockEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateDCAttributeInBlockEventsProcessSchema() {
			var schema = new DCAttributeInBlockEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new DCAttributeInBlock(userConnection){Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new DCAttributeInBlock_DynamicContentEventsProcess(userConnnection);
		}

		public override object Clone() {
			return new DCAttributeInBlockSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new DCAttributeInBlockSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ab22bcbe-a1fe-4e6c-b018-7454c04dae78"));
		}

		#endregion

	}

	#endregion

	#region Class: DCAttributeInBlock

	/// <summary>
	/// DCAttributeInBlock.
	/// </summary>
	public class DCAttributeInBlock : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public DCAttributeInBlock(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "DCAttributeInBlock";
		}

		public DCAttributeInBlock(DCAttributeInBlock source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid DCAttributeId {
			get {
				return GetTypedColumnValue<Guid>("DCAttributeId");
			}
			set {
				SetColumnValue("DCAttributeId", value);
				_dCAttribute = null;
			}
		}

		private DCAttribute _dCAttribute;
		/// <summary>
		/// DCAttribute.
		/// </summary>
		public DCAttribute DCAttribute {
			get {
				return _dCAttribute ??
					(_dCAttribute = LookupColumnEntities.GetEntity("DCAttribute") as DCAttribute);
			}
		}

		/// <exclude/>
		public Guid DCTemplateBlockId {
			get {
				return GetTypedColumnValue<Guid>("DCTemplateBlockId");
			}
			set {
				SetColumnValue("DCTemplateBlockId", value);
				_dCTemplateBlock = null;
			}
		}

		private DCTemplateBlock _dCTemplateBlock;
		/// <summary>
		/// DCTemplateBlock.
		/// </summary>
		public DCTemplateBlock DCTemplateBlock {
			get {
				return _dCTemplateBlock ??
					(_dCTemplateBlock = LookupColumnEntities.GetEntity("DCTemplateBlock") as DCTemplateBlock);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new DCAttributeInBlock_DynamicContentEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new DCAttributeInBlock(this);
		}

		#endregion

	}

	#endregion

	#region Class: DCAttributeInBlock_DynamicContentEventsProcess

	/// <exclude/>
	public class DCAttributeInBlock_DynamicContentEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_LocalMessageEventsProcess<TEntity> where TEntity : DCAttributeInBlock
	{

		public DCAttributeInBlock_DynamicContentEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "DCAttributeInBlock_DynamicContentEventsProcess";
			SchemaUId = new Guid("ab22bcbe-a1fe-4e6c-b018-7454c04dae78");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("ab22bcbe-a1fe-4e6c-b018-7454c04dae78");
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

	#region Class: DCAttributeInBlock_DynamicContentEventsProcess

	/// <exclude/>
	public class DCAttributeInBlock_DynamicContentEventsProcess : DCAttributeInBlock_DynamicContentEventsProcess<DCAttributeInBlock>
	{

		public DCAttributeInBlock_DynamicContentEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: DCAttributeInBlockEventsProcessSchema

	/// <exclude/>
	public class DCAttributeInBlockEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public DCAttributeInBlockEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public DCAttributeInBlockEventsProcessSchema(DCAttributeInBlockEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "DCAttributeInBlock_DynamicContentEventsProcess";
			UId = new Guid("130cb43e-18ff-49eb-850a-72a4778188a7");
			CreatedInPackageId = new Guid("9f77887e-50a7-49c4-86e4-3ef2d36a21a8");
			CreatedInSchemaUId = Guid.Empty;
			CreatedInVersion = @"0.0.0.0";
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
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
			return new DCAttributeInBlockEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("130cb43e-18ff-49eb-850a-72a4778188a7"));
		}

		#endregion

	}

	#endregion


	#region Class: DCAttributeInBlockEventsProcess

	/// <exclude/>
	public class DCAttributeInBlockEventsProcess : DCAttributeInBlock_DynamicContentEventsProcess
	{

		public DCAttributeInBlockEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

