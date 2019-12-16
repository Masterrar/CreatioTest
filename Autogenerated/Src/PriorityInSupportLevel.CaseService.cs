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

	#region Class: PriorityInSupportLevelSchema

	/// <exclude/>
	public class PriorityInSupportLevelSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public PriorityInSupportLevelSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public PriorityInSupportLevelSchema(PriorityInSupportLevelSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public PriorityInSupportLevelSchema(PriorityInSupportLevelSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("a63cee74-1ee5-4f52-98c9-61e796d604fa");
			RealUId = new Guid("a63cee74-1ee5-4f52-98c9-61e796d604fa");
			Name = "PriorityInSupportLevel";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("0e69a91d-b86d-4cf2-b98c-7f690db56e3a");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("86064d4e-7b99-47d8-8a88-eb06b3f3958b")) == null) {
				Columns.Add(CreateCasePriorityColumn());
			}
			if (Columns.FindByUId(new Guid("c154eff2-3642-416e-aa3d-90d48fd69d1e")) == null) {
				Columns.Add(CreateReactionTimeUnitColumn());
			}
			if (Columns.FindByUId(new Guid("85daa4cb-c035-44c0-b826-7aaaa503e038")) == null) {
				Columns.Add(CreateReactionTimeValueColumn());
			}
			if (Columns.FindByUId(new Guid("6ef9343f-8d5d-42ea-899e-3375d64720df")) == null) {
				Columns.Add(CreateSolutionTimeUnitColumn());
			}
			if (Columns.FindByUId(new Guid("e8a56037-7f53-4be9-b780-1d2f64edea1f")) == null) {
				Columns.Add(CreateSolutionTimeValueColumn());
			}
			if (Columns.FindByUId(new Guid("a2f4a02d-ebd3-4e2c-a61f-45c2360d1956")) == null) {
				Columns.Add(CreateSupportLevelColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateCasePriorityColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("86064d4e-7b99-47d8-8a88-eb06b3f3958b"),
				Name = @"CasePriority",
				ReferenceSchemaUId = new Guid("e662865c-728f-40db-b3dd-15dcf46d47df"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("a63cee74-1ee5-4f52-98c9-61e796d604fa"),
				ModifiedInSchemaUId = new Guid("a63cee74-1ee5-4f52-98c9-61e796d604fa"),
				CreatedInPackageId = new Guid("0e69a91d-b86d-4cf2-b98c-7f690db56e3a")
			};
		}

		protected virtual EntitySchemaColumn CreateReactionTimeUnitColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("c154eff2-3642-416e-aa3d-90d48fd69d1e"),
				Name = @"ReactionTimeUnit",
				ReferenceSchemaUId = new Guid("a9432d40-f95f-4d31-9f48-0444ebba77ab"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("a63cee74-1ee5-4f52-98c9-61e796d604fa"),
				ModifiedInSchemaUId = new Guid("a63cee74-1ee5-4f52-98c9-61e796d604fa"),
				CreatedInPackageId = new Guid("0e69a91d-b86d-4cf2-b98c-7f690db56e3a")
			};
		}

		protected virtual EntitySchemaColumn CreateReactionTimeValueColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("85daa4cb-c035-44c0-b826-7aaaa503e038"),
				Name = @"ReactionTimeValue",
				CreatedInSchemaUId = new Guid("a63cee74-1ee5-4f52-98c9-61e796d604fa"),
				ModifiedInSchemaUId = new Guid("a63cee74-1ee5-4f52-98c9-61e796d604fa"),
				CreatedInPackageId = new Guid("0e69a91d-b86d-4cf2-b98c-7f690db56e3a")
			};
		}

		protected virtual EntitySchemaColumn CreateSolutionTimeUnitColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("6ef9343f-8d5d-42ea-899e-3375d64720df"),
				Name = @"SolutionTimeUnit",
				ReferenceSchemaUId = new Guid("a9432d40-f95f-4d31-9f48-0444ebba77ab"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("a63cee74-1ee5-4f52-98c9-61e796d604fa"),
				ModifiedInSchemaUId = new Guid("a63cee74-1ee5-4f52-98c9-61e796d604fa"),
				CreatedInPackageId = new Guid("0e69a91d-b86d-4cf2-b98c-7f690db56e3a")
			};
		}

		protected virtual EntitySchemaColumn CreateSolutionTimeValueColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("e8a56037-7f53-4be9-b780-1d2f64edea1f"),
				Name = @"SolutionTimeValue",
				CreatedInSchemaUId = new Guid("a63cee74-1ee5-4f52-98c9-61e796d604fa"),
				ModifiedInSchemaUId = new Guid("a63cee74-1ee5-4f52-98c9-61e796d604fa"),
				CreatedInPackageId = new Guid("0e69a91d-b86d-4cf2-b98c-7f690db56e3a")
			};
		}

		protected virtual EntitySchemaColumn CreateSupportLevelColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("a2f4a02d-ebd3-4e2c-a61f-45c2360d1956"),
				Name = @"SupportLevel",
				ReferenceSchemaUId = new Guid("c30bd3d7-e9ea-4165-bedd-a23be5d59050"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("a63cee74-1ee5-4f52-98c9-61e796d604fa"),
				ModifiedInSchemaUId = new Guid("a63cee74-1ee5-4f52-98c9-61e796d604fa"),
				CreatedInPackageId = new Guid("0e69a91d-b86d-4cf2-b98c-7f690db56e3a")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreatePriorityInSupportLevelEventsProcessSchema();
		}

		protected virtual ProcessSchema CreatePriorityInSupportLevelEventsProcessSchema() {
			var schema = new PriorityInSupportLevelEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new PriorityInSupportLevel(userConnection){Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new PriorityInSupportLevel_CaseServiceEventsProcess(userConnnection);
		}

		public override object Clone() {
			return new PriorityInSupportLevelSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new PriorityInSupportLevelSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a63cee74-1ee5-4f52-98c9-61e796d604fa"));
		}

		#endregion

	}

	#endregion

	#region Class: PriorityInSupportLevel

	/// <summary>
	/// Priority in support level - detail.
	/// </summary>
	public class PriorityInSupportLevel : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public PriorityInSupportLevel(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "PriorityInSupportLevel";
		}

		public PriorityInSupportLevel(PriorityInSupportLevel source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public  Guid CasePriorityId {
			get {
				return GetTypedColumnValue<Guid>("CasePriorityId");
			}
			set {
				SetColumnValue("CasePriorityId", value);
				_casePriority = null;
			}
		}

		/// <exclude/>
		public  string CasePriorityName {
			get {
				return GetTypedColumnValue<string>("CasePriorityName");
			}
			set {
				SetColumnValue("CasePriorityName", value);
				if (_casePriority != null) {
					_casePriority.Name = value;
				}
			}
		}

		private CasePriority _casePriority;
		/// <summary>
		/// Case priority.
		/// </summary>
		public  CasePriority CasePriority {
			get {
				return _casePriority ??
					(_casePriority = LookupColumnEntities.GetEntity("CasePriority") as CasePriority);
			}
		}

		/// <exclude/>
		public  Guid ReactionTimeUnitId {
			get {
				return GetTypedColumnValue<Guid>("ReactionTimeUnitId");
			}
			set {
				SetColumnValue("ReactionTimeUnitId", value);
				_reactionTimeUnit = null;
			}
		}

		/// <exclude/>
		public  string ReactionTimeUnitName {
			get {
				return GetTypedColumnValue<string>("ReactionTimeUnitName");
			}
			set {
				SetColumnValue("ReactionTimeUnitName", value);
				if (_reactionTimeUnit != null) {
					_reactionTimeUnit.Name = value;
				}
			}
		}

		private TimeUnit _reactionTimeUnit;
		/// <summary>
		/// Response time unit.
		/// </summary>
		public  TimeUnit ReactionTimeUnit {
			get {
				return _reactionTimeUnit ??
					(_reactionTimeUnit = LookupColumnEntities.GetEntity("ReactionTimeUnit") as TimeUnit);
			}
		}

		/// <summary>
		/// Response time value.
		/// </summary>
		public  int ReactionTimeValue {
			get {
				return GetTypedColumnValue<int>("ReactionTimeValue");
			}
			set {
				SetColumnValue("ReactionTimeValue", value);
			}
		}

		/// <exclude/>
		public  Guid SolutionTimeUnitId {
			get {
				return GetTypedColumnValue<Guid>("SolutionTimeUnitId");
			}
			set {
				SetColumnValue("SolutionTimeUnitId", value);
				_solutionTimeUnit = null;
			}
		}

		/// <exclude/>
		public  string SolutionTimeUnitName {
			get {
				return GetTypedColumnValue<string>("SolutionTimeUnitName");
			}
			set {
				SetColumnValue("SolutionTimeUnitName", value);
				if (_solutionTimeUnit != null) {
					_solutionTimeUnit.Name = value;
				}
			}
		}

		private TimeUnit _solutionTimeUnit;
		/// <summary>
		/// Resolution time unit.
		/// </summary>
		public  TimeUnit SolutionTimeUnit {
			get {
				return _solutionTimeUnit ??
					(_solutionTimeUnit = LookupColumnEntities.GetEntity("SolutionTimeUnit") as TimeUnit);
			}
		}

		/// <summary>
		/// Resolution time value.
		/// </summary>
		public  int SolutionTimeValue {
			get {
				return GetTypedColumnValue<int>("SolutionTimeValue");
			}
			set {
				SetColumnValue("SolutionTimeValue", value);
			}
		}

		/// <exclude/>
		public  Guid SupportLevelId {
			get {
				return GetTypedColumnValue<Guid>("SupportLevelId");
			}
			set {
				SetColumnValue("SupportLevelId", value);
				_supportLevel = null;
			}
		}

		/// <exclude/>
		public  string SupportLevelName {
			get {
				return GetTypedColumnValue<string>("SupportLevelName");
			}
			set {
				SetColumnValue("SupportLevelName", value);
				if (_supportLevel != null) {
					_supportLevel.Name = value;
				}
			}
		}

		private SupportLevel _supportLevel;
		/// <summary>
		/// Support level.
		/// </summary>
		public  SupportLevel SupportLevel {
			get {
				return _supportLevel ??
					(_supportLevel = LookupColumnEntities.GetEntity("SupportLevel") as SupportLevel);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new PriorityInSupportLevel_CaseServiceEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Validating += (s, e) => ThrowEvent("PriorityInSupportLevelValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new PriorityInSupportLevel(this);
		}

		#endregion

	}

	#endregion

	#region Class: PriorityInSupportLevel_CaseServiceEventsProcess

	/// <exclude/>
	public class PriorityInSupportLevel_CaseServiceEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_LocalMessageEventsProcess<TEntity> where TEntity : PriorityInSupportLevel
	{

		public PriorityInSupportLevel_CaseServiceEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "PriorityInSupportLevel_CaseServiceEventsProcess";
			SchemaUId = new Guid("a63cee74-1ee5-4f52-98c9-61e796d604fa");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private  Guid InternalSchemaUId {
			get {
				return new Guid("a63cee74-1ee5-4f52-98c9-61e796d604fa");
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

	#region Class: PriorityInSupportLevel_CaseServiceEventsProcess

	/// <exclude/>
	public class PriorityInSupportLevel_CaseServiceEventsProcess : PriorityInSupportLevel_CaseServiceEventsProcess<PriorityInSupportLevel>
	{

		public PriorityInSupportLevel_CaseServiceEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: PriorityInSupportLevelEventsProcessSchema

	/// <exclude/>
	public class PriorityInSupportLevelEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public PriorityInSupportLevelEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public PriorityInSupportLevelEventsProcessSchema(PriorityInSupportLevelEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "PriorityInSupportLevel_CaseServiceEventsProcess";
			UId = new Guid("c52a92a6-1ec8-44a7-9863-9e80106c6023");
			CreatedInPackageId = new Guid("0e69a91d-b86d-4cf2-b98c-7f690db56e3a");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("66f58f21-6ed1-4e29-b506-6b9f6426d463");
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
			return new PriorityInSupportLevelEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c52a92a6-1ec8-44a7-9863-9e80106c6023"));
		}

		#endregion

	}

	#endregion


	#region Class: PriorityInSupportLevelEventsProcess

	/// <exclude/>
	public class PriorityInSupportLevelEventsProcess : PriorityInSupportLevel_CaseServiceEventsProcess
	{

		public PriorityInSupportLevelEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

