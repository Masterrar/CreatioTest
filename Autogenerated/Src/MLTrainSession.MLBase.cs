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

	#region Class: MLTrainSessionSchema

	/// <exclude/>
	public class MLTrainSessionSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public MLTrainSessionSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public MLTrainSessionSchema(MLTrainSessionSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public MLTrainSessionSchema(MLTrainSessionSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("9e22a1b5-8cc6-4b5a-abc8-19e2b5b06841");
			RealUId = new Guid("9e22a1b5-8cc6-4b5a-abc8-19e2b5b06841");
			Name = "MLTrainSession";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("7e80e3e9-e3bc-4e71-8b35-80232abfe92e");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("ab69353e-097f-4ae5-8487-d2b8dea7e6e3")) == null) {
				Columns.Add(CreateMLModelColumn());
			}
			if (Columns.FindByUId(new Guid("024b70b5-aae8-4fd6-8b58-06724a1ef3d0")) == null) {
				Columns.Add(CreateStateColumn());
			}
			if (Columns.FindByUId(new Guid("24cfe166-850a-4015-9a53-b98641ebce11")) == null) {
				Columns.Add(CreateInUseColumn());
			}
			if (Columns.FindByUId(new Guid("915e3530-e76d-4689-9ec7-6b895411bce4")) == null) {
				Columns.Add(CreateErrorColumn());
			}
			if (Columns.FindByUId(new Guid("2110c3a1-3066-4622-a8d5-19ec57eb34dd")) == null) {
				Columns.Add(CreateTrainedOnColumn());
			}
			if (Columns.FindByUId(new Guid("b9515ea5-ae59-4bc2-b680-2af2306db31f")) == null) {
				Columns.Add(CreateTrainSetSizeColumn());
			}
			if (Columns.FindByUId(new Guid("8dc69e3b-d749-4458-89ea-aa431194f98e")) == null) {
				Columns.Add(CreateInstanceMetricColumn());
			}
			if (Columns.FindByUId(new Guid("fdbedcd2-4e1f-4b69-bec2-dfa4e3075597")) == null) {
				Columns.Add(CreateTrainingTimeMinutesColumn());
			}
			if (Columns.FindByUId(new Guid("2c68f9b3-b19e-48cd-bc2f-0648f8f8154c")) == null) {
				Columns.Add(CreateIgnoreMetricThresholdColumn());
			}
			if (Columns.FindByUId(new Guid("0892c988-7771-46b6-bdc4-159597eb3869")) == null) {
				Columns.Add(CreateFeatureImportancesColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateMLModelColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("ab69353e-097f-4ae5-8487-d2b8dea7e6e3"),
				Name = @"MLModel",
				ReferenceSchemaUId = new Guid("f0d58f4a-303d-477c-8cf9-d00eaf04f32b"),
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("9e22a1b5-8cc6-4b5a-abc8-19e2b5b06841"),
				ModifiedInSchemaUId = new Guid("9e22a1b5-8cc6-4b5a-abc8-19e2b5b06841"),
				CreatedInPackageId = new Guid("7e80e3e9-e3bc-4e71-8b35-80232abfe92e")
			};
		}

		protected virtual EntitySchemaColumn CreateStateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("024b70b5-aae8-4fd6-8b58-06724a1ef3d0"),
				Name = @"State",
				ReferenceSchemaUId = new Guid("83a4b85c-3c8f-45c5-bb2c-ee6a45ba8cdc"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("9e22a1b5-8cc6-4b5a-abc8-19e2b5b06841"),
				ModifiedInSchemaUId = new Guid("9e22a1b5-8cc6-4b5a-abc8-19e2b5b06841"),
				CreatedInPackageId = new Guid("7e80e3e9-e3bc-4e71-8b35-80232abfe92e")
			};
		}

		protected virtual EntitySchemaColumn CreateInUseColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("24cfe166-850a-4015-9a53-b98641ebce11"),
				Name = @"InUse",
				CreatedInSchemaUId = new Guid("9e22a1b5-8cc6-4b5a-abc8-19e2b5b06841"),
				ModifiedInSchemaUId = new Guid("9e22a1b5-8cc6-4b5a-abc8-19e2b5b06841"),
				CreatedInPackageId = new Guid("7e80e3e9-e3bc-4e71-8b35-80232abfe92e")
			};
		}

		protected virtual EntitySchemaColumn CreateErrorColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("915e3530-e76d-4689-9ec7-6b895411bce4"),
				Name = @"Error",
				CreatedInSchemaUId = new Guid("9e22a1b5-8cc6-4b5a-abc8-19e2b5b06841"),
				ModifiedInSchemaUId = new Guid("9e22a1b5-8cc6-4b5a-abc8-19e2b5b06841"),
				CreatedInPackageId = new Guid("7e80e3e9-e3bc-4e71-8b35-80232abfe92e")
			};
		}

		protected virtual EntitySchemaColumn CreateTrainedOnColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("DateTime")) {
				UId = new Guid("2110c3a1-3066-4622-a8d5-19ec57eb34dd"),
				Name = @"TrainedOn",
				CreatedInSchemaUId = new Guid("9e22a1b5-8cc6-4b5a-abc8-19e2b5b06841"),
				ModifiedInSchemaUId = new Guid("9e22a1b5-8cc6-4b5a-abc8-19e2b5b06841"),
				CreatedInPackageId = new Guid("7e80e3e9-e3bc-4e71-8b35-80232abfe92e")
			};
		}

		protected virtual EntitySchemaColumn CreateTrainSetSizeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("b9515ea5-ae59-4bc2-b680-2af2306db31f"),
				Name = @"TrainSetSize",
				CreatedInSchemaUId = new Guid("9e22a1b5-8cc6-4b5a-abc8-19e2b5b06841"),
				ModifiedInSchemaUId = new Guid("9e22a1b5-8cc6-4b5a-abc8-19e2b5b06841"),
				CreatedInPackageId = new Guid("7e80e3e9-e3bc-4e71-8b35-80232abfe92e")
			};
		}

		protected virtual EntitySchemaColumn CreateInstanceMetricColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float2")) {
				UId = new Guid("8dc69e3b-d749-4458-89ea-aa431194f98e"),
				Name = @"InstanceMetric",
				CreatedInSchemaUId = new Guid("9e22a1b5-8cc6-4b5a-abc8-19e2b5b06841"),
				ModifiedInSchemaUId = new Guid("9e22a1b5-8cc6-4b5a-abc8-19e2b5b06841"),
				CreatedInPackageId = new Guid("7e80e3e9-e3bc-4e71-8b35-80232abfe92e")
			};
		}

		protected virtual EntitySchemaColumn CreateTrainingTimeMinutesColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("fdbedcd2-4e1f-4b69-bec2-dfa4e3075597"),
				Name = @"TrainingTimeMinutes",
				CreatedInSchemaUId = new Guid("9e22a1b5-8cc6-4b5a-abc8-19e2b5b06841"),
				ModifiedInSchemaUId = new Guid("9e22a1b5-8cc6-4b5a-abc8-19e2b5b06841"),
				CreatedInPackageId = new Guid("7e80e3e9-e3bc-4e71-8b35-80232abfe92e")
			};
		}

		protected virtual EntitySchemaColumn CreateIgnoreMetricThresholdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("2c68f9b3-b19e-48cd-bc2f-0648f8f8154c"),
				Name = @"IgnoreMetricThreshold",
				CreatedInSchemaUId = new Guid("9e22a1b5-8cc6-4b5a-abc8-19e2b5b06841"),
				ModifiedInSchemaUId = new Guid("9e22a1b5-8cc6-4b5a-abc8-19e2b5b06841"),
				CreatedInPackageId = new Guid("8bab9e12-6ef4-4d97-ae92-182a028c5592")
			};
		}

		protected virtual EntitySchemaColumn CreateFeatureImportancesColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("0892c988-7771-46b6-bdc4-159597eb3869"),
				Name = @"FeatureImportances",
				CreatedInSchemaUId = new Guid("9e22a1b5-8cc6-4b5a-abc8-19e2b5b06841"),
				ModifiedInSchemaUId = new Guid("9e22a1b5-8cc6-4b5a-abc8-19e2b5b06841"),
				CreatedInPackageId = new Guid("8bab9e12-6ef4-4d97-ae92-182a028c5592"),
				IsMultiLineText = true,
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"{ }"
				}
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateMLTrainSessionEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateMLTrainSessionEventsProcessSchema() {
			var schema = new MLTrainSessionEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new MLTrainSession(userConnection){Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new MLTrainSession_MLBaseEventsProcess(userConnnection);
		}

		public override object Clone() {
			return new MLTrainSessionSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new MLTrainSessionSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("9e22a1b5-8cc6-4b5a-abc8-19e2b5b06841"));
		}

		#endregion

	}

	#endregion

	#region Class: MLTrainSession

	/// <summary>
	/// ML train session.
	/// </summary>
	public class MLTrainSession : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public MLTrainSession(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "MLTrainSession";
		}

		public MLTrainSession(MLTrainSession source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid MLModelId {
			get {
				return GetTypedColumnValue<Guid>("MLModelId");
			}
			set {
				SetColumnValue("MLModelId", value);
				_mLModel = null;
			}
		}

		/// <exclude/>
		public string MLModelName {
			get {
				return GetTypedColumnValue<string>("MLModelName");
			}
			set {
				SetColumnValue("MLModelName", value);
				if (_mLModel != null) {
					_mLModel.Name = value;
				}
			}
		}

		private MLModel _mLModel;
		/// <summary>
		/// Model.
		/// </summary>
		public MLModel MLModel {
			get {
				return _mLModel ??
					(_mLModel = LookupColumnEntities.GetEntity("MLModel") as MLModel);
			}
		}

		/// <exclude/>
		public Guid StateId {
			get {
				return GetTypedColumnValue<Guid>("StateId");
			}
			set {
				SetColumnValue("StateId", value);
				_state = null;
			}
		}

		/// <exclude/>
		public string StateName {
			get {
				return GetTypedColumnValue<string>("StateName");
			}
			set {
				SetColumnValue("StateName", value);
				if (_state != null) {
					_state.Name = value;
				}
			}
		}

		private MLModelState _state;
		/// <summary>
		/// Status.
		/// </summary>
		public MLModelState State {
			get {
				return _state ??
					(_state = LookupColumnEntities.GetEntity("State") as MLModelState);
			}
		}

		/// <summary>
		/// Model in use.
		/// </summary>
		public bool InUse {
			get {
				return GetTypedColumnValue<bool>("InUse");
			}
			set {
				SetColumnValue("InUse", value);
			}
		}

		/// <summary>
		/// Error message text.
		/// </summary>
		public string Error {
			get {
				return GetTypedColumnValue<string>("Error");
			}
			set {
				SetColumnValue("Error", value);
			}
		}

		/// <summary>
		/// Trained on.
		/// </summary>
		public DateTime TrainedOn {
			get {
				return GetTypedColumnValue<DateTime>("TrainedOn");
			}
			set {
				SetColumnValue("TrainedOn", value);
			}
		}

		/// <summary>
		/// Train set size.
		/// </summary>
		public int TrainSetSize {
			get {
				return GetTypedColumnValue<int>("TrainSetSize");
			}
			set {
				SetColumnValue("TrainSetSize", value);
			}
		}

		/// <summary>
		/// Evaluation metric.
		/// </summary>
		public Decimal InstanceMetric {
			get {
				return GetTypedColumnValue<Decimal>("InstanceMetric");
			}
			set {
				SetColumnValue("InstanceMetric", value);
			}
		}

		/// <summary>
		/// Training time (min.).
		/// </summary>
		public int TrainingTimeMinutes {
			get {
				return GetTypedColumnValue<int>("TrainingTimeMinutes");
			}
			set {
				SetColumnValue("TrainingTimeMinutes", value);
			}
		}

		/// <summary>
		/// Ignore metric threshold mode.
		/// </summary>
		public bool IgnoreMetricThreshold {
			get {
				return GetTypedColumnValue<bool>("IgnoreMetricThreshold");
			}
			set {
				SetColumnValue("IgnoreMetricThreshold", value);
			}
		}

		/// <summary>
		/// Importance of model input columns.
		/// </summary>
		public string FeatureImportances {
			get {
				return GetTypedColumnValue<string>("FeatureImportances");
			}
			set {
				SetColumnValue("FeatureImportances", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new MLTrainSession_MLBaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("MLTrainSessionDeleted", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new MLTrainSession(this);
		}

		#endregion

	}

	#endregion

	#region Class: MLTrainSession_MLBaseEventsProcess

	/// <exclude/>
	public class MLTrainSession_MLBaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_LocalMessageEventsProcess<TEntity> where TEntity : MLTrainSession
	{

		public MLTrainSession_MLBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "MLTrainSession_MLBaseEventsProcess";
			SchemaUId = new Guid("9e22a1b5-8cc6-4b5a-abc8-19e2b5b06841");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("9e22a1b5-8cc6-4b5a-abc8-19e2b5b06841");
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

	#region Class: MLTrainSession_MLBaseEventsProcess

	/// <exclude/>
	public class MLTrainSession_MLBaseEventsProcess : MLTrainSession_MLBaseEventsProcess<MLTrainSession>
	{

		public MLTrainSession_MLBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: MLTrainSessionEventsProcessSchema

	/// <exclude/>
	public class MLTrainSessionEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public MLTrainSessionEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public MLTrainSessionEventsProcessSchema(MLTrainSessionEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "MLTrainSession_MLBaseEventsProcess";
			UId = new Guid("f9ea1508-c9ec-40c5-a1be-1d1a9633625a");
			CreatedInPackageId = new Guid("7e80e3e9-e3bc-4e71-8b35-80232abfe92e");
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
			return new MLTrainSessionEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f9ea1508-c9ec-40c5-a1be-1d1a9633625a"));
		}

		#endregion

	}

	#endregion


	#region Class: MLTrainSessionEventsProcess

	/// <exclude/>
	public class MLTrainSessionEventsProcess : MLTrainSession_MLBaseEventsProcess
	{

		public MLTrainSessionEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

