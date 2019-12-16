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

	#region Class: CTIProcessActionSchema

	/// <exclude/>
	public class CTIProcessActionSchema : Terrasoft.Configuration.BaseLookupSchema
	{

		#region Constructors: Public

		public CTIProcessActionSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public CTIProcessActionSchema(CTIProcessActionSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public CTIProcessActionSchema(CTIProcessActionSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("b0245e67-492f-4805-b212-5ba4b722ef01");
			RealUId = new Guid("b0245e67-492f-4805-b212-5ba4b722ef01");
			Name = "CTIProcessAction";
			ParentSchemaUId = new Guid("11ab4bcb-9b23-4b6d-9c86-520fae925d75");
			ExtendParent = false;
			CreatedInPackageId = new Guid("ccb8f7c7-6ff2-443f-9c1f-d56a09d4a46e");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("4ae77582-8fe4-4bfd-a257-d702ec30eedb")) == null) {
				Columns.Add(CreateProcessSchemaColumn());
			}
			if (Columns.FindByUId(new Guid("d4084ad4-f993-438f-a2f7-6caf85cf845e")) == null) {
				Columns.Add(CreatePositionColumn());
			}
		}

		protected override EntitySchemaColumn CreateNameColumn() {
			EntitySchemaColumn column = base.CreateNameColumn();
			column.ModifiedInSchemaUId = new Guid("b0245e67-492f-4805-b212-5ba4b722ef01");
			return column;
		}

		protected override EntitySchemaColumn CreateDescriptionColumn() {
			EntitySchemaColumn column = base.CreateDescriptionColumn();
			column.ModifiedInSchemaUId = new Guid("b0245e67-492f-4805-b212-5ba4b722ef01");
			return column;
		}

		protected virtual EntitySchemaColumn CreateProcessSchemaColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("4ae77582-8fe4-4bfd-a257-d702ec30eedb"),
				Name = @"ProcessSchema",
				ReferenceSchemaUId = new Guid("842e74a2-e737-476c-b3d0-8aa3d5ddd229"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				IsWeakReference = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("b0245e67-492f-4805-b212-5ba4b722ef01"),
				ModifiedInSchemaUId = new Guid("b0245e67-492f-4805-b212-5ba4b722ef01"),
				CreatedInPackageId = new Guid("ccb8f7c7-6ff2-443f-9c1f-d56a09d4a46e")
			};
		}

		protected virtual EntitySchemaColumn CreatePositionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("d4084ad4-f993-438f-a2f7-6caf85cf845e"),
				Name = @"Position",
				CreatedInSchemaUId = new Guid("b0245e67-492f-4805-b212-5ba4b722ef01"),
				ModifiedInSchemaUId = new Guid("b0245e67-492f-4805-b212-5ba4b722ef01"),
				CreatedInPackageId = new Guid("ccb8f7c7-6ff2-443f-9c1f-d56a09d4a46e"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"1"
				}
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateCTIProcessActionEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateCTIProcessActionEventsProcessSchema() {
			var schema = new CTIProcessActionEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new CTIProcessAction(userConnection){Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new CTIProcessAction_CTIProcessActionsEventsProcess(userConnnection);
		}

		public override object Clone() {
			return new CTIProcessActionSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new CTIProcessActionSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b0245e67-492f-4805-b212-5ba4b722ef01"));
		}

		#endregion

	}

	#endregion

	#region Class: CTIProcessAction

	/// <summary>
	/// CTI panel action.
	/// </summary>
	public class CTIProcessAction : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public CTIProcessAction(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "CTIProcessAction";
		}

		public CTIProcessAction(CTIProcessAction source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public  Guid ProcessSchemaId {
			get {
				return GetTypedColumnValue<Guid>("ProcessSchemaId");
			}
			set {
				SetColumnValue("ProcessSchemaId", value);
				_processSchema = null;
			}
		}

		/// <exclude/>
		public  string ProcessSchemaCaption {
			get {
				return GetTypedColumnValue<string>("ProcessSchemaCaption");
			}
			set {
				SetColumnValue("ProcessSchemaCaption", value);
				if (_processSchema != null) {
					_processSchema.Caption = value;
				}
			}
		}

		private VwSysProcess _processSchema;
		/// <summary>
		/// Process.
		/// </summary>
		public  VwSysProcess ProcessSchema {
			get {
				return _processSchema ??
					(_processSchema = LookupColumnEntities.GetEntity("ProcessSchema") as VwSysProcess);
			}
		}

		/// <summary>
		/// Sorting position.
		/// </summary>
		public  int Position {
			get {
				return GetTypedColumnValue<int>("Position");
			}
			set {
				SetColumnValue("Position", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new CTIProcessAction_CTIProcessActionsEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Validating += (s, e) => ThrowEvent("CTIProcessActionValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new CTIProcessAction(this);
		}

		#endregion

	}

	#endregion

	#region Class: CTIProcessAction_CTIProcessActionsEventsProcess

	/// <exclude/>
	public class CTIProcessAction_CTIProcessActionsEventsProcess<TEntity> : Terrasoft.Configuration.BaseLookup_BaseEventsProcess<TEntity> where TEntity : CTIProcessAction
	{

		public CTIProcessAction_CTIProcessActionsEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "CTIProcessAction_CTIProcessActionsEventsProcess";
			SchemaUId = new Guid("b0245e67-492f-4805-b212-5ba4b722ef01");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private  Guid InternalSchemaUId {
			get {
				return new Guid("b0245e67-492f-4805-b212-5ba4b722ef01");
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

	#region Class: CTIProcessAction_CTIProcessActionsEventsProcess

	/// <exclude/>
	public class CTIProcessAction_CTIProcessActionsEventsProcess : CTIProcessAction_CTIProcessActionsEventsProcess<CTIProcessAction>
	{

		public CTIProcessAction_CTIProcessActionsEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: CTIProcessActionEventsProcessSchema

	/// <exclude/>
	public class CTIProcessActionEventsProcessSchema : Terrasoft.Configuration.BaseLookupEventsProcessSchema
	{

		#region Constructors: Public

		public CTIProcessActionEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public CTIProcessActionEventsProcessSchema(CTIProcessActionEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "CTIProcessAction_CTIProcessActionsEventsProcess";
			UId = new Guid("13ffd41b-7f35-47bb-a995-c436c21f25b7");
			CreatedInPackageId = new Guid("ccb8f7c7-6ff2-443f-9c1f-d56a09d4a46e");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
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
			return new CTIProcessActionEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("13ffd41b-7f35-47bb-a995-c436c21f25b7"));
		}

		#endregion

	}

	#endregion


	#region Class: CTIProcessActionEventsProcess

	/// <exclude/>
	public class CTIProcessActionEventsProcess : CTIProcessAction_CTIProcessActionsEventsProcess
	{

		public CTIProcessActionEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

