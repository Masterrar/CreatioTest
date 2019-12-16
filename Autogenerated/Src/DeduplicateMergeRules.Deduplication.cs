﻿namespace Terrasoft.Configuration
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

	#region Class: DeduplicateMergeRulesSchema

	/// <exclude/>
	public class DeduplicateMergeRulesSchema : Terrasoft.Configuration.BaseLookupSchema
	{

		#region Constructors: Public

		public DeduplicateMergeRulesSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public DeduplicateMergeRulesSchema(DeduplicateMergeRulesSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public DeduplicateMergeRulesSchema(DeduplicateMergeRulesSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("4cd81be3-384c-4ea4-abcf-50132df3a873");
			RealUId = new Guid("4cd81be3-384c-4ea4-abcf-50132df3a873");
			Name = "DeduplicateMergeRules";
			ParentSchemaUId = new Guid("11ab4bcb-9b23-4b6d-9c86-520fae925d75");
			ExtendParent = false;
			CreatedInPackageId = new Guid("2bccf296-28ac-4fb9-9305-bd0b56b97b98");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("dd137541-a236-4bd6-bc22-c957d93324f8")) == null) {
				Columns.Add(CreateSQLTextColumn());
			}
			if (Columns.FindByUId(new Guid("33f8e5da-0e0f-4c79-a83e-616c74cd469c")) == null) {
				Columns.Add(CreateAdditionalMergeConfigColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateSQLTextColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("dd137541-a236-4bd6-bc22-c957d93324f8"),
				Name = @"SQLText",
				CreatedInSchemaUId = new Guid("4cd81be3-384c-4ea4-abcf-50132df3a873"),
				ModifiedInSchemaUId = new Guid("4cd81be3-384c-4ea4-abcf-50132df3a873"),
				CreatedInPackageId = new Guid("2bccf296-28ac-4fb9-9305-bd0b56b97b98")
			};
		}

		protected virtual EntitySchemaColumn CreateAdditionalMergeConfigColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("33f8e5da-0e0f-4c79-a83e-616c74cd469c"),
				Name = @"AdditionalMergeConfig",
				CreatedInSchemaUId = new Guid("4cd81be3-384c-4ea4-abcf-50132df3a873"),
				ModifiedInSchemaUId = new Guid("4cd81be3-384c-4ea4-abcf-50132df3a873"),
				CreatedInPackageId = new Guid("ca0e9b58-391f-43cb-96ab-6943b000d1f4")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateDeduplicateMergeRulesEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateDeduplicateMergeRulesEventsProcessSchema() {
			var schema = new DeduplicateMergeRulesEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new DeduplicateMergeRules(userConnection){Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new DeduplicateMergeRules_DeduplicationEventsProcess(userConnnection);
		}

		public override object Clone() {
			return new DeduplicateMergeRulesSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new DeduplicateMergeRulesSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("4cd81be3-384c-4ea4-abcf-50132df3a873"));
		}

		#endregion

	}

	#endregion

	#region Class: DeduplicateMergeRules

	/// <summary>
	/// Deduplicate merge rules.
	/// </summary>
	public class DeduplicateMergeRules : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public DeduplicateMergeRules(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "DeduplicateMergeRules";
		}

		public DeduplicateMergeRules(DeduplicateMergeRules source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// SQL Text.
		/// </summary>
		public string SQLText {
			get {
				return GetTypedColumnValue<string>("SQLText");
			}
			set {
				SetColumnValue("SQLText", value);
			}
		}

		/// <summary>
		/// AdditionalMergeConfig.
		/// </summary>
		public string AdditionalMergeConfig {
			get {
				return GetTypedColumnValue<string>("AdditionalMergeConfig");
			}
			set {
				SetColumnValue("AdditionalMergeConfig", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new DeduplicateMergeRules_DeduplicationEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("DeduplicateMergeRulesDeleted", e);
			Validating += (s, e) => ThrowEvent("DeduplicateMergeRulesValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new DeduplicateMergeRules(this);
		}

		#endregion

	}

	#endregion

	#region Class: DeduplicateMergeRules_DeduplicationEventsProcess

	/// <exclude/>
	public class DeduplicateMergeRules_DeduplicationEventsProcess<TEntity> : Terrasoft.Configuration.BaseLookup_BaseEventsProcess<TEntity> where TEntity : DeduplicateMergeRules
	{

		public DeduplicateMergeRules_DeduplicationEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "DeduplicateMergeRules_DeduplicationEventsProcess";
			SchemaUId = new Guid("4cd81be3-384c-4ea4-abcf-50132df3a873");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("4cd81be3-384c-4ea4-abcf-50132df3a873");
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

	#region Class: DeduplicateMergeRules_DeduplicationEventsProcess

	/// <exclude/>
	public class DeduplicateMergeRules_DeduplicationEventsProcess : DeduplicateMergeRules_DeduplicationEventsProcess<DeduplicateMergeRules>
	{

		public DeduplicateMergeRules_DeduplicationEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: DeduplicateMergeRulesEventsProcessSchema

	/// <exclude/>
	public class DeduplicateMergeRulesEventsProcessSchema : Terrasoft.Configuration.BaseLookupEventsProcessSchema
	{

		#region Constructors: Public

		public DeduplicateMergeRulesEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public DeduplicateMergeRulesEventsProcessSchema(DeduplicateMergeRulesEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "DeduplicateMergeRules_DeduplicationEventsProcess";
			UId = new Guid("538a4185-ae4a-44f5-8f1e-150b181afc39");
			CreatedInPackageId = new Guid("2bccf296-28ac-4fb9-9305-bd0b56b97b98");
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
			return new DeduplicateMergeRulesEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("538a4185-ae4a-44f5-8f1e-150b181afc39"));
		}

		#endregion

	}

	#endregion


	#region Class: DeduplicateMergeRulesEventsProcess

	/// <exclude/>
	public class DeduplicateMergeRulesEventsProcess : DeduplicateMergeRules_DeduplicationEventsProcess
	{

		public DeduplicateMergeRulesEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}
