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

	#region Class: TimeToPrioritizeSchema

	/// <exclude/>
	public class TimeToPrioritizeSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public TimeToPrioritizeSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public TimeToPrioritizeSchema(TimeToPrioritizeSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public TimeToPrioritizeSchema(TimeToPrioritizeSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f0740e3e-3dce-4594-9495-b306e3d1751c");
			RealUId = new Guid("f0740e3e-3dce-4594-9495-b306e3d1751c");
			Name = "TimeToPrioritize";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("ad5b74fb-5a18-4ed5-aefb-d72c560aee61");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("b1b5135e-fd3e-44e4-800e-77e2e4ea1dc7")) == null) {
				Columns.Add(CreateCasePriorityColumn());
			}
			if (Columns.FindByUId(new Guid("063dffcd-c5db-49d4-be17-325e1933c532")) == null) {
				Columns.Add(CreateReactionTimeUnitColumn());
			}
			if (Columns.FindByUId(new Guid("90bded78-97f2-4922-a5c5-b7dbed3b2fa2")) == null) {
				Columns.Add(CreateReactionTimeValueColumn());
			}
			if (Columns.FindByUId(new Guid("eab15b3f-a9be-4d9f-893a-ed4637ea145f")) == null) {
				Columns.Add(CreateSolutionTimeUnitColumn());
			}
			if (Columns.FindByUId(new Guid("7d9d92cb-2044-4e16-8ad8-0674199646c0")) == null) {
				Columns.Add(CreateSolutionTimeValueColumn());
			}
			if (Columns.FindByUId(new Guid("6a37ee82-3cac-42a4-859f-64998d01f90e")) == null) {
				Columns.Add(CreateServiceInServicePactColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateCasePriorityColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("b1b5135e-fd3e-44e4-800e-77e2e4ea1dc7"),
				Name = @"CasePriority",
				ReferenceSchemaUId = new Guid("e662865c-728f-40db-b3dd-15dcf46d47df"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("f0740e3e-3dce-4594-9495-b306e3d1751c"),
				ModifiedInSchemaUId = new Guid("f0740e3e-3dce-4594-9495-b306e3d1751c"),
				CreatedInPackageId = new Guid("ad5b74fb-5a18-4ed5-aefb-d72c560aee61")
			};
		}

		protected virtual EntitySchemaColumn CreateReactionTimeUnitColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("063dffcd-c5db-49d4-be17-325e1933c532"),
				Name = @"ReactionTimeUnit",
				ReferenceSchemaUId = new Guid("a9432d40-f95f-4d31-9f48-0444ebba77ab"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("f0740e3e-3dce-4594-9495-b306e3d1751c"),
				ModifiedInSchemaUId = new Guid("f0740e3e-3dce-4594-9495-b306e3d1751c"),
				CreatedInPackageId = new Guid("ad5b74fb-5a18-4ed5-aefb-d72c560aee61")
			};
		}

		protected virtual EntitySchemaColumn CreateReactionTimeValueColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("90bded78-97f2-4922-a5c5-b7dbed3b2fa2"),
				Name = @"ReactionTimeValue",
				CreatedInSchemaUId = new Guid("f0740e3e-3dce-4594-9495-b306e3d1751c"),
				ModifiedInSchemaUId = new Guid("f0740e3e-3dce-4594-9495-b306e3d1751c"),
				CreatedInPackageId = new Guid("ad5b74fb-5a18-4ed5-aefb-d72c560aee61")
			};
		}

		protected virtual EntitySchemaColumn CreateSolutionTimeUnitColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("eab15b3f-a9be-4d9f-893a-ed4637ea145f"),
				Name = @"SolutionTimeUnit",
				ReferenceSchemaUId = new Guid("a9432d40-f95f-4d31-9f48-0444ebba77ab"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("f0740e3e-3dce-4594-9495-b306e3d1751c"),
				ModifiedInSchemaUId = new Guid("f0740e3e-3dce-4594-9495-b306e3d1751c"),
				CreatedInPackageId = new Guid("ad5b74fb-5a18-4ed5-aefb-d72c560aee61")
			};
		}

		protected virtual EntitySchemaColumn CreateSolutionTimeValueColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("7d9d92cb-2044-4e16-8ad8-0674199646c0"),
				Name = @"SolutionTimeValue",
				CreatedInSchemaUId = new Guid("f0740e3e-3dce-4594-9495-b306e3d1751c"),
				ModifiedInSchemaUId = new Guid("f0740e3e-3dce-4594-9495-b306e3d1751c"),
				CreatedInPackageId = new Guid("ad5b74fb-5a18-4ed5-aefb-d72c560aee61")
			};
		}

		protected virtual EntitySchemaColumn CreateServiceInServicePactColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("6a37ee82-3cac-42a4-859f-64998d01f90e"),
				Name = @"ServiceInServicePact",
				ReferenceSchemaUId = new Guid("d01c9dd6-2cb2-41d6-8fcd-29b86ed70b1b"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("f0740e3e-3dce-4594-9495-b306e3d1751c"),
				ModifiedInSchemaUId = new Guid("f0740e3e-3dce-4594-9495-b306e3d1751c"),
				CreatedInPackageId = new Guid("ad5b74fb-5a18-4ed5-aefb-d72c560aee61")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateTimeToPrioritizeEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateTimeToPrioritizeEventsProcessSchema() {
			var schema = new TimeToPrioritizeEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new TimeToPrioritize(userConnection){Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new TimeToPrioritize_SLMITILServiceEventsProcess(userConnnection);
		}

		public override object Clone() {
			return new TimeToPrioritizeSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new TimeToPrioritizeSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f0740e3e-3dce-4594-9495-b306e3d1751c"));
		}

		#endregion

	}

	#endregion

	#region Class: TimeToPrioritize

	/// <summary>
	/// Time to prioritize.
	/// </summary>
	public class TimeToPrioritize : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public TimeToPrioritize(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "TimeToPrioritize";
		}

		public TimeToPrioritize(TimeToPrioritize source)
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
		public  Guid ServiceInServicePactId {
			get {
				return GetTypedColumnValue<Guid>("ServiceInServicePactId");
			}
			set {
				SetColumnValue("ServiceInServicePactId", value);
				_serviceInServicePact = null;
			}
		}

		/// <exclude/>
		public  string ServiceInServicePactConcatName {
			get {
				return GetTypedColumnValue<string>("ServiceInServicePactConcatName");
			}
			set {
				SetColumnValue("ServiceInServicePactConcatName", value);
				if (_serviceInServicePact != null) {
					_serviceInServicePact.ConcatName = value;
				}
			}
		}

		private ServiceInServicePact _serviceInServicePact;
		/// <summary>
		/// Service in service pact.
		/// </summary>
		public  ServiceInServicePact ServiceInServicePact {
			get {
				return _serviceInServicePact ??
					(_serviceInServicePact = LookupColumnEntities.GetEntity("ServiceInServicePact") as ServiceInServicePact);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new TimeToPrioritize_SLMITILServiceEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Validating += (s, e) => ThrowEvent("TimeToPrioritizeValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new TimeToPrioritize(this);
		}

		#endregion

	}

	#endregion

	#region Class: TimeToPrioritize_SLMITILServiceEventsProcess

	/// <exclude/>
	public class TimeToPrioritize_SLMITILServiceEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_LocalMessageEventsProcess<TEntity> where TEntity : TimeToPrioritize
	{

		public TimeToPrioritize_SLMITILServiceEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "TimeToPrioritize_SLMITILServiceEventsProcess";
			SchemaUId = new Guid("f0740e3e-3dce-4594-9495-b306e3d1751c");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private  Guid InternalSchemaUId {
			get {
				return new Guid("f0740e3e-3dce-4594-9495-b306e3d1751c");
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

	#region Class: TimeToPrioritize_SLMITILServiceEventsProcess

	/// <exclude/>
	public class TimeToPrioritize_SLMITILServiceEventsProcess : TimeToPrioritize_SLMITILServiceEventsProcess<TimeToPrioritize>
	{

		public TimeToPrioritize_SLMITILServiceEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: TimeToPrioritizeEventsProcessSchema

	/// <exclude/>
	public class TimeToPrioritizeEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public TimeToPrioritizeEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public TimeToPrioritizeEventsProcessSchema(TimeToPrioritizeEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "TimeToPrioritize_SLMITILServiceEventsProcess";
			UId = new Guid("99c245b4-04f5-4e55-a48f-01cebb87458a");
			CreatedInPackageId = new Guid("ad5b74fb-5a18-4ed5-aefb-d72c560aee61");
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
			return new TimeToPrioritizeEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("99c245b4-04f5-4e55-a48f-01cebb87458a"));
		}

		#endregion

	}

	#endregion


	#region Class: TimeToPrioritizeEventsProcess

	/// <exclude/>
	public class TimeToPrioritizeEventsProcess : TimeToPrioritize_SLMITILServiceEventsProcess
	{

		public TimeToPrioritizeEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

