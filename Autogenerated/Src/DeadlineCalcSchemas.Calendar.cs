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

	#region Class: DeadlineCalcSchemasSchema

	/// <exclude/>
	public class DeadlineCalcSchemasSchema : Terrasoft.Configuration.BaseLookupSchema
	{

		#region Constructors: Public

		public DeadlineCalcSchemasSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public DeadlineCalcSchemasSchema(DeadlineCalcSchemasSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public DeadlineCalcSchemasSchema(DeadlineCalcSchemasSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("109e54de-6e5b-4164-98d6-ca1c4e8a87d0");
			RealUId = new Guid("109e54de-6e5b-4164-98d6-ca1c4e8a87d0");
			Name = "DeadlineCalcSchemas";
			ParentSchemaUId = new Guid("11ab4bcb-9b23-4b6d-9c86-520fae925d75");
			ExtendParent = false;
			CreatedInPackageId = new Guid("f8ee96f6-dca0-4326-840f-e18786d18f9b");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("a82c1524-401e-435b-b432-05726f44d614")) == null) {
				Columns.Add(CreateDefaultColumn());
			}
			if (Columns.FindByUId(new Guid("a1a913a4-20ba-49bd-b142-0ce75abb64f7")) == null) {
				Columns.Add(CreateAlternativeRuleColumn());
			}
			if (Columns.FindByUId(new Guid("259b670f-a523-4e81-b1d2-f7c2448d6e3c")) == null) {
				Columns.Add(CreateHandlerColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateDefaultColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("a82c1524-401e-435b-b432-05726f44d614"),
				Name = @"Default",
				CreatedInSchemaUId = new Guid("109e54de-6e5b-4164-98d6-ca1c4e8a87d0"),
				ModifiedInSchemaUId = new Guid("109e54de-6e5b-4164-98d6-ca1c4e8a87d0"),
				CreatedInPackageId = new Guid("f8ee96f6-dca0-4326-840f-e18786d18f9b")
			};
		}

		protected virtual EntitySchemaColumn CreateAlternativeRuleColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("a1a913a4-20ba-49bd-b142-0ce75abb64f7"),
				Name = @"AlternativeRule",
				ReferenceSchemaUId = new Guid("109e54de-6e5b-4164-98d6-ca1c4e8a87d0"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("109e54de-6e5b-4164-98d6-ca1c4e8a87d0"),
				ModifiedInSchemaUId = new Guid("109e54de-6e5b-4164-98d6-ca1c4e8a87d0"),
				CreatedInPackageId = new Guid("f8ee96f6-dca0-4326-840f-e18786d18f9b")
			};
		}

		protected virtual EntitySchemaColumn CreateHandlerColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("259b670f-a523-4e81-b1d2-f7c2448d6e3c"),
				Name = @"Handler",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("109e54de-6e5b-4164-98d6-ca1c4e8a87d0"),
				ModifiedInSchemaUId = new Guid("109e54de-6e5b-4164-98d6-ca1c4e8a87d0"),
				CreatedInPackageId = new Guid("f8ee96f6-dca0-4326-840f-e18786d18f9b"),
				IsLocalizable = true
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateDeadlineCalcSchemasEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateDeadlineCalcSchemasEventsProcessSchema() {
			var schema = new DeadlineCalcSchemasEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new DeadlineCalcSchemas(userConnection){Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new DeadlineCalcSchemas_CalendarEventsProcess(userConnnection);
		}

		public override object Clone() {
			return new DeadlineCalcSchemasSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new DeadlineCalcSchemasSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("109e54de-6e5b-4164-98d6-ca1c4e8a87d0"));
		}

		#endregion

	}

	#endregion

	#region Class: DeadlineCalcSchemas

	/// <summary>
	/// Case deadline calculation schemas.
	/// </summary>
	public class DeadlineCalcSchemas : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public DeadlineCalcSchemas(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "DeadlineCalcSchemas";
		}

		public DeadlineCalcSchemas(DeadlineCalcSchemas source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Default.
		/// </summary>
		public  bool Default {
			get {
				return GetTypedColumnValue<bool>("Default");
			}
			set {
				SetColumnValue("Default", value);
			}
		}

		/// <exclude/>
		public  Guid AlternativeRuleId {
			get {
				return GetTypedColumnValue<Guid>("AlternativeRuleId");
			}
			set {
				SetColumnValue("AlternativeRuleId", value);
				_alternativeRule = null;
			}
		}

		/// <exclude/>
		public  string AlternativeRuleName {
			get {
				return GetTypedColumnValue<string>("AlternativeRuleName");
			}
			set {
				SetColumnValue("AlternativeRuleName", value);
				if (_alternativeRule != null) {
					_alternativeRule.Name = value;
				}
			}
		}

		private DeadlineCalcSchemas _alternativeRule;
		/// <summary>
		/// Alternative schema.
		/// </summary>
		public  DeadlineCalcSchemas AlternativeRule {
			get {
				return _alternativeRule ??
					(_alternativeRule = LookupColumnEntities.GetEntity("AlternativeRule") as DeadlineCalcSchemas);
			}
		}

		/// <summary>
		/// Handler.
		/// </summary>
		public  string Handler {
			get {
				return GetTypedColumnValue<string>("Handler");
			}
			set {
				SetColumnValue("Handler", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new DeadlineCalcSchemas_CalendarEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Validating += (s, e) => ThrowEvent("DeadlineCalcSchemasValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new DeadlineCalcSchemas(this);
		}

		#endregion

	}

	#endregion

	#region Class: DeadlineCalcSchemas_CalendarEventsProcess

	/// <exclude/>
	public class DeadlineCalcSchemas_CalendarEventsProcess<TEntity> : Terrasoft.Configuration.BaseLookup_BaseEventsProcess<TEntity> where TEntity : DeadlineCalcSchemas
	{

		public DeadlineCalcSchemas_CalendarEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "DeadlineCalcSchemas_CalendarEventsProcess";
			SchemaUId = new Guid("109e54de-6e5b-4164-98d6-ca1c4e8a87d0");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private  Guid InternalSchemaUId {
			get {
				return new Guid("109e54de-6e5b-4164-98d6-ca1c4e8a87d0");
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

	#region Class: DeadlineCalcSchemas_CalendarEventsProcess

	/// <exclude/>
	public class DeadlineCalcSchemas_CalendarEventsProcess : DeadlineCalcSchemas_CalendarEventsProcess<DeadlineCalcSchemas>
	{

		public DeadlineCalcSchemas_CalendarEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: DeadlineCalcSchemasEventsProcessSchema

	/// <exclude/>
	public class DeadlineCalcSchemasEventsProcessSchema : Terrasoft.Configuration.BaseLookupEventsProcessSchema
	{

		#region Constructors: Public

		public DeadlineCalcSchemasEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public DeadlineCalcSchemasEventsProcessSchema(DeadlineCalcSchemasEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "DeadlineCalcSchemas_CalendarEventsProcess";
			UId = new Guid("86bf808c-0def-4371-bcb7-41328f64ce6a");
			CreatedInPackageId = new Guid("f8ee96f6-dca0-4326-840f-e18786d18f9b");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("e20c0489-122a-4242-999c-169e8e866fc1");
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
			return new DeadlineCalcSchemasEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("86bf808c-0def-4371-bcb7-41328f64ce6a"));
		}

		#endregion

	}

	#endregion


	#region Class: DeadlineCalcSchemasEventsProcess

	/// <exclude/>
	public class DeadlineCalcSchemasEventsProcess : DeadlineCalcSchemas_CalendarEventsProcess
	{

		public DeadlineCalcSchemasEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

