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

	#region Class: CampaignFilterSchema

	/// <exclude/>
	public class CampaignFilterSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public CampaignFilterSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public CampaignFilterSchema(CampaignFilterSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public CampaignFilterSchema(CampaignFilterSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("9244f0c0-0d7d-42a2-849d-e4f1c573f6f1");
			RealUId = new Guid("9244f0c0-0d7d-42a2-849d-e4f1c573f6f1");
			Name = "CampaignFilter";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("c130e4bc-accb-4cd0-8b02-dd2e4506d5d1");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("b52717ed-5515-4b11-931b-8a4b7b1026f8")) == null) {
				Columns.Add(CreateTitleColumn());
			}
			if (Columns.FindByUId(new Guid("c638c75d-cf1b-4f8b-8b25-003663acfd8c")) == null) {
				Columns.Add(CreateStepTypeColumn());
			}
			if (Columns.FindByUId(new Guid("269cb8ee-66e8-4068-b216-d50b2dfead77")) == null) {
				Columns.Add(CreatePriorityColumn());
			}
			if (Columns.FindByUId(new Guid("c03a5deb-4894-45ea-a669-7070cb88870c")) == null) {
				Columns.Add(CreateSearchDataColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateTitleColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("b52717ed-5515-4b11-931b-8a4b7b1026f8"),
				Name = @"Title",
				CreatedInSchemaUId = new Guid("9244f0c0-0d7d-42a2-849d-e4f1c573f6f1"),
				ModifiedInSchemaUId = new Guid("9244f0c0-0d7d-42a2-849d-e4f1c573f6f1"),
				CreatedInPackageId = new Guid("c130e4bc-accb-4cd0-8b02-dd2e4506d5d1"),
				IsLocalizable = true
			};
		}

		protected virtual EntitySchemaColumn CreateStepTypeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("c638c75d-cf1b-4f8b-8b25-003663acfd8c"),
				Name = @"StepType",
				ReferenceSchemaUId = new Guid("92569be4-cc39-48a3-a577-0bdb22f31441"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("9244f0c0-0d7d-42a2-849d-e4f1c573f6f1"),
				ModifiedInSchemaUId = new Guid("9244f0c0-0d7d-42a2-849d-e4f1c573f6f1"),
				CreatedInPackageId = new Guid("c130e4bc-accb-4cd0-8b02-dd2e4506d5d1")
			};
		}

		protected virtual EntitySchemaColumn CreatePriorityColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("269cb8ee-66e8-4068-b216-d50b2dfead77"),
				Name = @"Priority",
				CreatedInSchemaUId = new Guid("9244f0c0-0d7d-42a2-849d-e4f1c573f6f1"),
				ModifiedInSchemaUId = new Guid("9244f0c0-0d7d-42a2-849d-e4f1c573f6f1"),
				CreatedInPackageId = new Guid("c130e4bc-accb-4cd0-8b02-dd2e4506d5d1")
			};
		}

		protected virtual EntitySchemaColumn CreateSearchDataColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Binary")) {
				UId = new Guid("c03a5deb-4894-45ea-a669-7070cb88870c"),
				Name = @"SearchData",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("9244f0c0-0d7d-42a2-849d-e4f1c573f6f1"),
				ModifiedInSchemaUId = new Guid("9244f0c0-0d7d-42a2-849d-e4f1c573f6f1"),
				CreatedInPackageId = new Guid("c130e4bc-accb-4cd0-8b02-dd2e4506d5d1")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateCampaignFilterEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateCampaignFilterEventsProcessSchema() {
			var schema = new CampaignFilterEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new CampaignFilter(userConnection){Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new CampaignFilter_CampaignsEventsProcess(userConnnection);
		}

		public override object Clone() {
			return new CampaignFilterSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new CampaignFilterSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("9244f0c0-0d7d-42a2-849d-e4f1c573f6f1"));
		}

		#endregion

	}

	#endregion

	#region Class: CampaignFilter

	/// <summary>
	/// Campaign filter.
	/// </summary>
	public class CampaignFilter : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public CampaignFilter(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "CampaignFilter";
		}

		public CampaignFilter(CampaignFilter source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Name.
		/// </summary>
		public  string Title {
			get {
				return GetTypedColumnValue<string>("Title");
			}
			set {
				SetColumnValue("Title", value);
			}
		}

		/// <exclude/>
		public  Guid StepTypeId {
			get {
				return GetTypedColumnValue<Guid>("StepTypeId");
			}
			set {
				SetColumnValue("StepTypeId", value);
				_stepType = null;
			}
		}

		/// <exclude/>
		public  string StepTypeName {
			get {
				return GetTypedColumnValue<string>("StepTypeName");
			}
			set {
				SetColumnValue("StepTypeName", value);
				if (_stepType != null) {
					_stepType.Name = value;
				}
			}
		}

		private CampaignStepType _stepType;
		/// <summary>
		/// Campaign stage type.
		/// </summary>
		public  CampaignStepType StepType {
			get {
				return _stepType ??
					(_stepType = LookupColumnEntities.GetEntity("StepType") as CampaignStepType);
			}
		}

		/// <summary>
		/// Priority.
		/// </summary>
		public  int Priority {
			get {
				return GetTypedColumnValue<int>("Priority");
			}
			set {
				SetColumnValue("Priority", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new CampaignFilter_CampaignsEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Validating += (s, e) => ThrowEvent("CampaignFilterValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new CampaignFilter(this);
		}

		#endregion

	}

	#endregion

	#region Class: CampaignFilter_CampaignsEventsProcess

	/// <exclude/>
	public class CampaignFilter_CampaignsEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_LocalMessageEventsProcess<TEntity> where TEntity : CampaignFilter
	{

		public CampaignFilter_CampaignsEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "CampaignFilter_CampaignsEventsProcess";
			SchemaUId = new Guid("9244f0c0-0d7d-42a2-849d-e4f1c573f6f1");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private  Guid InternalSchemaUId {
			get {
				return new Guid("9244f0c0-0d7d-42a2-849d-e4f1c573f6f1");
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

	#region Class: CampaignFilter_CampaignsEventsProcess

	/// <exclude/>
	public class CampaignFilter_CampaignsEventsProcess : CampaignFilter_CampaignsEventsProcess<CampaignFilter>
	{

		public CampaignFilter_CampaignsEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: CampaignFilterEventsProcessSchema

	/// <exclude/>
	public class CampaignFilterEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public CampaignFilterEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public CampaignFilterEventsProcessSchema(CampaignFilterEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "CampaignFilter_CampaignsEventsProcess";
			UId = new Guid("e6885fc0-f0b0-4a9f-8770-d91009322842");
			CreatedInPackageId = new Guid("c130e4bc-accb-4cd0-8b02-dd2e4506d5d1");
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
			return new CampaignFilterEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e6885fc0-f0b0-4a9f-8770-d91009322842"));
		}

		#endregion

	}

	#endregion


	#region Class: CampaignFilterEventsProcess

	/// <exclude/>
	public class CampaignFilterEventsProcess : CampaignFilter_CampaignsEventsProcess
	{

		public CampaignFilterEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

