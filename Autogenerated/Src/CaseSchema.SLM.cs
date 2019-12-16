namespace Terrasoft.Configuration
{

	using CoreSysSettings = Terrasoft.Core.Configuration.SysSettings;
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
	using Terrasoft.Configuration;
	using Terrasoft.Configuration.CaseSequenceService;
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

	#region Class: Case_SLM_TerrasoftSchema

	/// <exclude/>
	public class Case_SLM_TerrasoftSchema : Terrasoft.Configuration.Case_Case_TerrasoftSchema
	{

		#region Constructors: Public

		public Case_SLM_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public Case_SLM_TerrasoftSchema(Case_SLM_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public Case_SLM_TerrasoftSchema(Case_SLM_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private EntitySchemaIndex CreateIX_RegisteredOn_DescIndex() {
			EntitySchemaIndex index = new EntitySchemaIndex() {
				IsAutoName = false,
				IsClustered = false,
				IsUnique = false
			};
			index.UId = new Guid("9ed6688c-3e02-47af-9124-e38e20904716");
			index.Name = "IX_RegisteredOn_Desc";
			index.CreatedInSchemaUId = new Guid("117d32f9-8275-4534-8411-1c66115ce9cd");
			index.ModifiedInSchemaUId = new Guid("117d32f9-8275-4534-8411-1c66115ce9cd");
			index.CreatedInPackageId = new Guid("a7919973-994c-4956-b846-530c9ef3b289");
			EntitySchemaIndexColumn registeredOnIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("aa03e37c-3527-4b5c-a16c-53fbc178b41e"),
				ColumnUId = new Guid("c91a9a6f-008d-4b2e-83d5-03868ad68c99"),
				CreatedInSchemaUId = new Guid("117d32f9-8275-4534-8411-1c66115ce9cd"),
				ModifiedInSchemaUId = new Guid("117d32f9-8275-4534-8411-1c66115ce9cd"),
				CreatedInPackageId = new Guid("a7919973-994c-4956-b846-530c9ef3b289"),
				OrderDirection = OrderDirectionStrict.Descending
			};
			index.Columns.Add(registeredOnIndexColumn);
			return index;
		}

		private EntitySchemaIndex CreateIX_SolutionOverdue_AttributesIndex() {
			EntitySchemaIndex index = new EntitySchemaIndex() {
				IsAutoName = false,
				IsClustered = false,
				IsUnique = false
			};
			index.UId = new Guid("9ad0ba05-3b32-4561-8bfc-870aee9c951c");
			index.Name = "IX_SolutionOverdue_Attributes";
			index.CreatedInSchemaUId = new Guid("7d80c5f8-f594-44e3-b87e-31b7f7432c4c");
			index.ModifiedInSchemaUId = new Guid("7d80c5f8-f594-44e3-b87e-31b7f7432c4c");
			index.CreatedInPackageId = new Guid("c3c90037-274c-4793-841e-197eb228d3cd");
			EntitySchemaIndexColumn solutionProvidedOnIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("4f3631c8-b14e-4591-a25a-b9207401cfa2"),
				ColumnUId = new Guid("81552f0a-fd92-4865-9533-f4c3ab2861a7"),
				CreatedInSchemaUId = new Guid("7d80c5f8-f594-44e3-b87e-31b7f7432c4c"),
				ModifiedInSchemaUId = new Guid("7d80c5f8-f594-44e3-b87e-31b7f7432c4c"),
				CreatedInPackageId = new Guid("c3c90037-274c-4793-841e-197eb228d3cd"),
				OrderDirection = OrderDirectionStrict.Descending
			};
			index.Columns.Add(solutionProvidedOnIndexColumn);
			EntitySchemaIndexColumn solutionDateIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("5de35510-255d-4f3f-8119-9a3f9b8082f5"),
				ColumnUId = new Guid("624839d1-3bd0-45e0-95d1-28326703f19c"),
				CreatedInSchemaUId = new Guid("7d80c5f8-f594-44e3-b87e-31b7f7432c4c"),
				ModifiedInSchemaUId = new Guid("7d80c5f8-f594-44e3-b87e-31b7f7432c4c"),
				CreatedInPackageId = new Guid("c3c90037-274c-4793-841e-197eb228d3cd"),
				OrderDirection = OrderDirectionStrict.Descending
			};
			index.Columns.Add(solutionDateIndexColumn);
			EntitySchemaIndexColumn solutionOverdueIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("8dab4368-f988-43de-a48e-bbf238fc3237"),
				ColumnUId = new Guid("0fa66efc-d2d0-47b9-abab-9e3ad2ea82d3"),
				CreatedInSchemaUId = new Guid("7d80c5f8-f594-44e3-b87e-31b7f7432c4c"),
				ModifiedInSchemaUId = new Guid("7d80c5f8-f594-44e3-b87e-31b7f7432c4c"),
				CreatedInPackageId = new Guid("c3c90037-274c-4793-841e-197eb228d3cd"),
				OrderDirection = OrderDirectionStrict.Ascending
			};
			index.Columns.Add(solutionOverdueIndexColumn);
			return index;
		}

		private EntitySchemaIndex CreateIX_ResponseOverdue_AttributesIndex() {
			EntitySchemaIndex index = new EntitySchemaIndex() {
				IsAutoName = false,
				IsClustered = false,
				IsUnique = false
			};
			index.UId = new Guid("8d002ad1-0715-4bdc-aa5e-8be1a5e39381");
			index.Name = "IX_ResponseOverdue_Attributes";
			index.CreatedInSchemaUId = new Guid("7d80c5f8-f594-44e3-b87e-31b7f7432c4c");
			index.ModifiedInSchemaUId = new Guid("7d80c5f8-f594-44e3-b87e-31b7f7432c4c");
			index.CreatedInPackageId = new Guid("c3c90037-274c-4793-841e-197eb228d3cd");
			EntitySchemaIndexColumn respondedOnIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("14abc9af-1b98-4ee2-b236-3a9576b1770f"),
				ColumnUId = new Guid("02612dc8-7243-4acb-b0bd-abbd19e24136"),
				CreatedInSchemaUId = new Guid("7d80c5f8-f594-44e3-b87e-31b7f7432c4c"),
				ModifiedInSchemaUId = new Guid("7d80c5f8-f594-44e3-b87e-31b7f7432c4c"),
				CreatedInPackageId = new Guid("c3c90037-274c-4793-841e-197eb228d3cd"),
				OrderDirection = OrderDirectionStrict.Descending
			};
			index.Columns.Add(respondedOnIndexColumn);
			EntitySchemaIndexColumn responseDateIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("c3226bd5-beb9-48ea-9383-30fb120d4f4d"),
				ColumnUId = new Guid("25280121-c075-441f-b4f8-feeb6cc7ca38"),
				CreatedInSchemaUId = new Guid("7d80c5f8-f594-44e3-b87e-31b7f7432c4c"),
				ModifiedInSchemaUId = new Guid("7d80c5f8-f594-44e3-b87e-31b7f7432c4c"),
				CreatedInPackageId = new Guid("c3c90037-274c-4793-841e-197eb228d3cd"),
				OrderDirection = OrderDirectionStrict.Descending
			};
			index.Columns.Add(responseDateIndexColumn);
			EntitySchemaIndexColumn responseOverdueIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("a4aaaa1e-d84e-48a2-84ac-04c35a6fad1e"),
				ColumnUId = new Guid("1ed4e080-0bf8-4f4f-97e8-b3e22f3240a0"),
				CreatedInSchemaUId = new Guid("7d80c5f8-f594-44e3-b87e-31b7f7432c4c"),
				ModifiedInSchemaUId = new Guid("7d80c5f8-f594-44e3-b87e-31b7f7432c4c"),
				CreatedInPackageId = new Guid("c3c90037-274c-4793-841e-197eb228d3cd"),
				OrderDirection = OrderDirectionStrict.Ascending
			};
			index.Columns.Add(responseOverdueIndexColumn);
			return index;
		}

		private EntitySchemaIndex CreateIDX_SubjectIndex() {
			EntitySchemaIndex index = new EntitySchemaIndex() {
				IsAutoName = false,
				IsClustered = false,
				IsUnique = false
			};
			index.UId = new Guid("e675ceca-ff2f-44c2-bd1a-f2c1af261cba");
			index.Name = "IDX_Subject";
			index.CreatedInSchemaUId = new Guid("117d32f9-8275-4534-8411-1c66115ce9cd");
			index.ModifiedInSchemaUId = new Guid("117d32f9-8275-4534-8411-1c66115ce9cd");
			index.CreatedInPackageId = new Guid("ff020f92-eb95-49ea-a251-6a0ed7e274a5");
			EntitySchemaIndexColumn subjectIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("5f164afe-e5a5-40a6-9e32-b7f83656bba8"),
				ColumnUId = new Guid("ffe8526d-044f-4222-a1ef-fca83a0772d8"),
				CreatedInSchemaUId = new Guid("117d32f9-8275-4534-8411-1c66115ce9cd"),
				ModifiedInSchemaUId = new Guid("117d32f9-8275-4534-8411-1c66115ce9cd"),
				CreatedInPackageId = new Guid("ff020f92-eb95-49ea-a251-6a0ed7e274a5"),
				OrderDirection = OrderDirectionStrict.Ascending
			};
			index.Columns.Add(subjectIndexColumn);
			return index;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("3179e425-d87c-4c9c-a201-53e19a977f6d");
			Name = "Case_SLM_Terrasoft";
			ParentSchemaUId = new Guid("117d32f9-8275-4534-8411-1c66115ce9cd");
			ExtendParent = true;
			CreatedInPackageId = new Guid("4bc36079-7dbb-41e6-9a4e-b85039bf2a70");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("61ccdc6d-f9dc-4b22-a86d-212127e717a6")) == null) {
				Columns.Add(CreateServiceItemColumn());
			}
			if (Columns.FindByUId(new Guid("58cec386-8fdf-42e3-8014-ca4001c615ec")) == null) {
				Columns.Add(CreateProcessingTimeUnitColumn());
			}
			if (Columns.FindByUId(new Guid("28dfd64f-463a-449c-9fcd-a9bfed4a5686")) == null) {
				Columns.Add(CreateProcessingTimeUnitValueColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateServiceItemColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("61ccdc6d-f9dc-4b22-a86d-212127e717a6"),
				Name = @"ServiceItem",
				ReferenceSchemaUId = new Guid("c6c44f0a-193e-4b5c-b35e-220a60c06898"),
				IsValueCloneable = false,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("3179e425-d87c-4c9c-a201-53e19a977f6d"),
				ModifiedInSchemaUId = new Guid("3179e425-d87c-4c9c-a201-53e19a977f6d"),
				CreatedInPackageId = new Guid("4bc36079-7dbb-41e6-9a4e-b85039bf2a70")
			};
		}

		protected virtual EntitySchemaColumn CreateProcessingTimeUnitColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("58cec386-8fdf-42e3-8014-ca4001c615ec"),
				Name = @"ProcessingTimeUnit",
				ReferenceSchemaUId = new Guid("a9432d40-f95f-4d31-9f48-0444ebba77ab"),
				IsValueCloneable = false,
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("3179e425-d87c-4c9c-a201-53e19a977f6d"),
				ModifiedInSchemaUId = new Guid("3179e425-d87c-4c9c-a201-53e19a977f6d"),
				CreatedInPackageId = new Guid("b11d550e-0087-4f53-ae17-fb00d41102cf")
			};
		}

		protected virtual EntitySchemaColumn CreateProcessingTimeUnitValueColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("28dfd64f-463a-449c-9fcd-a9bfed4a5686"),
				Name = @"ProcessingTimeUnitValue",
				IsValueCloneable = false,
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("3179e425-d87c-4c9c-a201-53e19a977f6d"),
				ModifiedInSchemaUId = new Guid("3179e425-d87c-4c9c-a201-53e19a977f6d"),
				CreatedInPackageId = new Guid("b11d550e-0087-4f53-ae17-fb00d41102cf")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeIndexes() {
			base.InitializeIndexes();
			Indexes.Add(CreateIX_RegisteredOn_DescIndex());
			Indexes.Add(CreateIX_SolutionOverdue_AttributesIndex());
			Indexes.Add(CreateIX_ResponseOverdue_AttributesIndex());
			Indexes.Add(CreateIDX_SubjectIndex());
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateCase_SLM_TerrasoftEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateCase_SLM_TerrasoftEventsProcessSchema() {
			var schema = new Case_SLM_TerrasoftEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new Case_SLM_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new Case_SLMEventsProcess(userConnection);
		}

		public override object Clone() {
			return new Case_SLM_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new Case_SLM_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("3179e425-d87c-4c9c-a201-53e19a977f6d"));
		}

		#endregion

	}

	#endregion

	#region Class: Case_SLM_Terrasoft

	/// <summary>
	/// Case.
	/// </summary>
	public class Case_SLM_Terrasoft : Terrasoft.Configuration.Case_Case_Terrasoft
	{

		#region Constructors: Public

		public Case_SLM_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Case_SLM_Terrasoft";
		}

		public Case_SLM_Terrasoft(Case_SLM_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid ServiceItemId {
			get {
				return GetTypedColumnValue<Guid>("ServiceItemId");
			}
			set {
				SetColumnValue("ServiceItemId", value);
				_serviceItem = null;
			}
		}

		/// <exclude/>
		public string ServiceItemName {
			get {
				return GetTypedColumnValue<string>("ServiceItemName");
			}
			set {
				SetColumnValue("ServiceItemName", value);
				if (_serviceItem != null) {
					_serviceItem.Name = value;
				}
			}
		}

		private ServiceItem _serviceItem;
		/// <summary>
		/// Service.
		/// </summary>
		public ServiceItem ServiceItem {
			get {
				return _serviceItem ??
					(_serviceItem = LookupColumnEntities.GetEntity("ServiceItem") as ServiceItem);
			}
		}

		/// <exclude/>
		public Guid ProcessingTimeUnitId {
			get {
				return GetTypedColumnValue<Guid>("ProcessingTimeUnitId");
			}
			set {
				SetColumnValue("ProcessingTimeUnitId", value);
				_processingTimeUnit = null;
			}
		}

		/// <exclude/>
		public string ProcessingTimeUnitName {
			get {
				return GetTypedColumnValue<string>("ProcessingTimeUnitName");
			}
			set {
				SetColumnValue("ProcessingTimeUnitName", value);
				if (_processingTimeUnit != null) {
					_processingTimeUnit.Name = value;
				}
			}
		}

		private TimeUnit _processingTimeUnit;
		/// <summary>
		/// Processing time unit.
		/// </summary>
		public TimeUnit ProcessingTimeUnit {
			get {
				return _processingTimeUnit ??
					(_processingTimeUnit = LookupColumnEntities.GetEntity("ProcessingTimeUnit") as TimeUnit);
			}
		}

		/// <summary>
		/// Processing time unit value.
		/// </summary>
		public int ProcessingTimeUnitValue {
			get {
				return GetTypedColumnValue<int>("ProcessingTimeUnitValue");
			}
			set {
				SetColumnValue("ProcessingTimeUnitValue", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new Case_SLMEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("Case_SLM_TerrasoftDeleted", e);
			Saved += (s, e) => ThrowEvent("Case_SLM_TerrasoftSaved", e);
			Saving += (s, e) => ThrowEvent("Case_SLM_TerrasoftSaving", e);
			Validating += (s, e) => ThrowEvent("Case_SLM_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new Case_SLM_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: Case_SLMEventsProcess

	/// <exclude/>
	public class Case_SLMEventsProcess<TEntity> : Terrasoft.Configuration.Case_CaseEventsProcess<TEntity> where TEntity : Case_SLM_Terrasoft
	{

		public Case_SLMEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Case_SLMEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("3179e425-d87c-4c9c-a201-53e19a977f6d");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		public virtual bool NeedSaveLifecycle {
			get;
			set;
		}

		private ProcessFlowElement _sLM_EventSubProcess4;
		public ProcessFlowElement SLM_EventSubProcess4 {
			get {
				return _sLM_EventSubProcess4 ?? (_sLM_EventSubProcess4 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "SLM_EventSubProcess4",
					SchemaElementUId = new Guid("7acc5824-a8d2-4916-b0bb-74950db35337"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _logChangesScriptTask;
		public ProcessScriptTask LogChangesScriptTask {
			get {
				return _logChangesScriptTask ?? (_logChangesScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "LogChangesScriptTask",
					SchemaElementUId = new Guid("00a4ff68-2b07-4d54-99c3-f51fa625c33c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = LogChangesScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _sLM_CaseSavingStartMessage;
		public ProcessFlowElement SLM_CaseSavingStartMessage {
			get {
				return _sLM_CaseSavingStartMessage ?? (_sLM_CaseSavingStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "SLM_CaseSavingStartMessage",
					SchemaElementUId = new Guid("9dda909c-699b-4cc1-b336-773e8cb64ce8"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessThrowMessageEvent _sLM_CaseSavingIntermediateThrowMessage;
		public ProcessThrowMessageEvent SLM_CaseSavingIntermediateThrowMessage {
			get {
				return _sLM_CaseSavingIntermediateThrowMessage ?? (_sLM_CaseSavingIntermediateThrowMessage = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "SLM_CaseSavingIntermediateThrowMessage",
					SchemaElementUId = new Guid("795470b7-437d-4498-bf31-19d87954dc1b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "CaseSaving",
						ThrowToBase = true,
				});
			}
		}

		private ProcessThrowMessageEvent _sLM_CaseSavedIntermediateThrowMessage;
		public ProcessThrowMessageEvent SLM_CaseSavedIntermediateThrowMessage {
			get {
				return _sLM_CaseSavedIntermediateThrowMessage ?? (_sLM_CaseSavedIntermediateThrowMessage = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "SLM_CaseSavedIntermediateThrowMessage",
					SchemaElementUId = new Guid("223892fd-ea8a-4fb3-b606-902ceae69017"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "CaseSaved",
						ThrowToBase = true,
				});
			}
		}

		private ProcessScriptTask _sLM_SetIsNeedToLogLifecycleScriptTask;
		public ProcessScriptTask SLM_SetIsNeedToLogLifecycleScriptTask {
			get {
				return _sLM_SetIsNeedToLogLifecycleScriptTask ?? (_sLM_SetIsNeedToLogLifecycleScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "SLM_SetIsNeedToLogLifecycleScriptTask",
					SchemaElementUId = new Guid("23046b50-e6cf-40ab-89bf-8b4fbd15d222"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = SLM_SetIsNeedToLogLifecycleScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _sLM_CaseSavedStartMessage;
		public ProcessFlowElement SLM_CaseSavedStartMessage {
			get {
				return _sLM_CaseSavedStartMessage ?? (_sLM_CaseSavedStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "SLM_CaseSavedStartMessage",
					SchemaElementUId = new Guid("8438da09-4b2b-423a-98e7-01d26e53994e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _sLM_UpdateColumnsScriptTask;
		public ProcessScriptTask SLM_UpdateColumnsScriptTask {
			get {
				return _sLM_UpdateColumnsScriptTask ?? (_sLM_UpdateColumnsScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "SLM_UpdateColumnsScriptTask",
					SchemaElementUId = new Guid("a73f848f-f46c-477a-9e32-98f6bcb4d9f6"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = SLM_UpdateColumnsScriptTaskExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[SLM_EventSubProcess4.SchemaElementUId] = new Collection<ProcessFlowElement> { SLM_EventSubProcess4 };
			FlowElements[LogChangesScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { LogChangesScriptTask };
			FlowElements[SLM_CaseSavingStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { SLM_CaseSavingStartMessage };
			FlowElements[SLM_CaseSavingIntermediateThrowMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { SLM_CaseSavingIntermediateThrowMessage };
			FlowElements[SLM_CaseSavedIntermediateThrowMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { SLM_CaseSavedIntermediateThrowMessage };
			FlowElements[SLM_SetIsNeedToLogLifecycleScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { SLM_SetIsNeedToLogLifecycleScriptTask };
			FlowElements[SLM_CaseSavedStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { SLM_CaseSavedStartMessage };
			FlowElements[SLM_UpdateColumnsScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { SLM_UpdateColumnsScriptTask };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "SLM_EventSubProcess4":
						break;
					case "LogChangesScriptTask":
						e.Context.QueueTasks.Enqueue("SLM_CaseSavedIntermediateThrowMessage");
						break;
					case "SLM_CaseSavingStartMessage":
						e.Context.QueueTasks.Enqueue("SLM_UpdateColumnsScriptTask");
						break;
					case "SLM_CaseSavingIntermediateThrowMessage":
						break;
					case "SLM_CaseSavedIntermediateThrowMessage":
						break;
					case "SLM_SetIsNeedToLogLifecycleScriptTask":
						e.Context.QueueTasks.Enqueue("SLM_CaseSavingIntermediateThrowMessage");
						break;
					case "SLM_CaseSavedStartMessage":
						e.Context.QueueTasks.Enqueue("LogChangesScriptTask");
						break;
					case "SLM_UpdateColumnsScriptTask":
						e.Context.QueueTasks.Enqueue("SLM_SetIsNeedToLogLifecycleScriptTask");
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("SLM_CaseSavingStartMessage");
			ActivatedEventElements.Add("SLM_CaseSavedStartMessage");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "SLM_EventSubProcess4":
					context.QueueTasks.Dequeue();
					break;
				case "LogChangesScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "LogChangesScriptTask";
					result = LogChangesScriptTask.Execute(context, LogChangesScriptTaskExecute);
					break;
				case "SLM_CaseSavingStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "SLM_CaseSavingStartMessage";
					result = SLM_CaseSavingStartMessage.Execute(context);
					break;
				case "SLM_CaseSavingIntermediateThrowMessage":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "CaseSaving");
					result = SLM_CaseSavingIntermediateThrowMessage.Execute(context);
					break;
				case "SLM_CaseSavedIntermediateThrowMessage":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "CaseSaved");
					result = SLM_CaseSavedIntermediateThrowMessage.Execute(context);
					break;
				case "SLM_SetIsNeedToLogLifecycleScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "SLM_SetIsNeedToLogLifecycleScriptTask";
					result = SLM_SetIsNeedToLogLifecycleScriptTask.Execute(context, SLM_SetIsNeedToLogLifecycleScriptTaskExecute);
					break;
				case "SLM_CaseSavedStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "SLM_CaseSavedStartMessage";
					result = SLM_CaseSavedStartMessage.Execute(context);
					break;
				case "SLM_UpdateColumnsScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "SLM_UpdateColumnsScriptTask";
					result = SLM_UpdateColumnsScriptTask.Execute(context, SLM_UpdateColumnsScriptTaskExecute);
					break;
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

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			switch (reader.CurrentName) {
				case "NeedSaveLifecycle":
					NeedSaveLifecycle = reader.GetValue<System.Boolean>();
				break;
			}
		}

		#endregion

		#region Methods: Public

		public virtual bool LogChangesScriptTaskExecute(ProcessExecutingContext context) {
			if (NeedSaveLifecycle) {
				SaveLifecycle();
			}
			return true;
		}

		public virtual bool SLM_SetIsNeedToLogLifecycleScriptTaskExecute(ProcessExecutingContext context) {
			NeedSaveLifecycle = GetIsNeedToLogLifecycle();
			return true;
		}

		public virtual bool SLM_UpdateColumnsScriptTaskExecute(ProcessExecutingContext context) {
			UpdateResponse();
			UpdateSolution();
			UpdateClosureDate();
			return true;
		}

		public override void LocalMessageExecuting(EntityChangeType changeType) {
			var lmHelper = new Terrasoft.Configuration.LocalMessageHelper(this.Entity, UserConnection, changeType);
			lmHelper.CreateLocalMessage();
		}

		public override string GetServiceCaption() {
			var serviceItemId = Entity.GetTypedColumnValue<Guid>("ServiceItemId");
			var serviceQuery = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "ServiceItem");
			serviceQuery.AddColumn("Name"); 
			var service = serviceQuery .GetEntity(UserConnection, serviceItemId);
			if(service == null) {
				return string.Empty;
			} 
			return service.GetTypedColumnValue<string>("Name"); 
		}

		public virtual void SaveLifecycle() {
			DateTime actionDate = UserConnection.CurrentUser.GetCurrentDateTime();
			bool isNotFirstDate = ClosePreviousInterval(Entity.GetTypedColumnValue<Guid>("Id"), actionDate);
			actionDate = isNotFirstDate ? UserConnection.CurrentUser.GetCurrentDateTime() : Entity.GetTypedColumnValue<DateTime>("RegisteredOn");
			OpenNewInterval(actionDate);
		}

		public virtual List<string> GetLoggingColumns() {
			return new List<string>() {
				"StatusId",
				"PriorityId",
				"ServiceItemId",
				"OwnerId",
				"GroupId",
				"SolutionDate",
				"SolutionProvidedOn"
			};
		}

		public virtual bool ClosePreviousInterval(Guid CaseId, DateTime Date) {
			var previousIntervalESQ = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "CaseLifecycle");
			previousIntervalESQ.AddAllSchemaColumns();
			previousIntervalESQ.AddColumn("StartDate").OrderByDesc();
			previousIntervalESQ.Filters.Add(previousIntervalESQ.CreateFilterWithParameters(
				FilterComparisonType.Equal, "Case", CaseId));
			previousIntervalESQ.Filters.Add(previousIntervalESQ.CreateIsNullFilter("EndDate"));
			var previousIntervals = previousIntervalESQ.GetEntityCollection(UserConnection);
			if (previousIntervals.Count == 0) {
				return false;
			}
			var lastInterval = previousIntervals[0];
			lastInterval.UseAdminRights = false;
			DateTime startDate = lastInterval.GetTypedColumnValue<DateTime>("StartDate");
			TimeSpan difference = (TimeSpan)(Date-startDate);
			lastInterval.SetColumnValue("EndDate", Date);
			lastInterval.SetColumnValue("StateDurationInMinutes", difference.TotalMinutes);
			lastInterval.SetColumnValue("StateDurationInHours", difference.TotalHours);
			lastInterval.SetColumnValue("StateDurationInDays", difference.TotalDays);
			lastInterval.Save();
			return true;
		}

		public virtual void OpenNewInterval(DateTime Date) {
			var entitySchemaCaseLifecycle = UserConnection.EntitySchemaManager.GetInstanceByName("CaseLifecycle");
			var entitySchemaCase = UserConnection.EntitySchemaManager.GetInstanceByName("Case");
			
			var newCaseLifecycle = entitySchemaCaseLifecycle.CreateEntity(UserConnection);
			newCaseLifecycle.UseAdminRights = false;
			newCaseLifecycle.SetDefColumnValues();
			
			var disableCommonColumns = new List<string>() {
				"Id",
				"CreatedOn",
				"CreatedById"
			};
			var commonColumns = entitySchemaCaseLifecycle.Columns
				.Select(c=>new {Name = c.ColumnValueName, DataValueType = c.DataValueType})
				.Intersect(entitySchemaCase.Columns.Select(c=>new {Name = c.ColumnValueName, DataValueType = c.DataValueType}))
				.Select(c => c.Name)
				.Except(disableCommonColumns);
			
			foreach(string columnName in commonColumns) {
				newCaseLifecycle.SetColumnValue(columnName, Entity.GetColumnValue(columnName));
			}
			
			newCaseLifecycle.SetColumnValue("CaseId", Entity.GetColumnValue("Id"));
			newCaseLifecycle.SetColumnValue("StartDate", Date);
			
			newCaseLifecycle.Save();
		}

		public virtual bool GetIsNeedToLogLifecycle() {
			var logColumns =(IEnumerable<string>) GetLoggingColumns();
			var changedValues = Entity.GetChangedColumnValues().Where(v => 
				((v.Value != null) && !v.Value.Equals(v.OldValue)) ||
				((v.Value == null) && v.OldValue != null)
			);
			return changedValues.Select(v => v.Name).Intersect(logColumns).Any();
		}

		public virtual bool GetIsStatusActive(Guid statusId) {
			var columns = new [] {
				"IsPaused",
				"IsFinal",
				"IsResolved"
			};
			return !GetStatusIs(statusId, columns);
		}

		public virtual void UpdateResponse() {
			var statusIdColumnName = "StatusId";
			var oldStatusId = Entity.GetTypedOldColumnValue<Guid>(statusIdColumnName);
			var statusId = Entity.GetTypedColumnValue<Guid>(statusIdColumnName);
			if (oldStatusId == Guid.Empty || oldStatusId == statusId) {
				return;
			}
			var respondedOnColumnName = "RespondedOn";
			var respondedOn = Entity.GetTypedColumnValue<DateTime>(respondedOnColumnName);
			if (respondedOn == default(DateTime)) {
				var dateTimeNow = GetDateTimeInCurrentTimeZone();
				Entity.SetColumnValue(respondedOnColumnName, dateTimeNow);
			}
		}

		public virtual void UpdateSolution() {
			var statusIdColumnName = "StatusId";
			var oldStatusId = Entity.GetTypedOldColumnValue<Guid>(statusIdColumnName);
			var statusId = Entity.GetTypedColumnValue<Guid>(statusIdColumnName);
			if(oldStatusId == statusId) {
				return;
			}
			DateTime? nullValue = null;
			var isNewStatusFinalOrResolved = GetIsStatusFinalOrResolved(statusId);
			if (UserConnection.GetIsFeatureEnabled("CaseRuleApplier")) {
				if (!GetIsStatusActive(oldStatusId)) {
					var isOldStatusFinalOrResolved = GetIsStatusFinalOrResolved(oldStatusId);
					DateTime? dateTimeNow;
					if (isNewStatusFinalOrResolved || GetIsStatusPaused(statusId)) {
						if (isOldStatusFinalOrResolved) {
							return;
						}
						dateTimeNow = GetDateTimeInCurrentTimeZone();
					} else {
						dateTimeNow = nullValue;
					}
					Entity.SetColumnValue("SolutionProvidedOn", dateTimeNow);
				}
				if (GetIsStatusPaused(statusId) && !GetIsStatusResolved(oldStatusId)) {
					Entity.SetColumnValue("SolutionDate", nullValue);
				}
			} else {
				if (GetIsStatusPaused(statusId)) {
					Entity.SetColumnValue("SolutionDate", nullValue);
				}
				if (!GetIsStatusFinal(statusId) && GetIsStatusResolved(oldStatusId)) {
					Entity.SetColumnValue("SolutionProvidedOn", nullValue);
					if (UserConnection.GetIsFeatureEnabled("ClearSolutionDateAfterReopenCase")) {
						Entity.SetColumnValue("SolutionDate", nullValue);
					}
				}
				if (!GetIsStatusActive(oldStatusId)) {
					var isOldStatusFinalOrResolved = GetIsStatusFinalOrResolved(oldStatusId);
					DateTime? dateTimeNow;
					if (isNewStatusFinalOrResolved) {
						if (isOldStatusFinalOrResolved) {
							return;
						}
						dateTimeNow = GetDateTimeInCurrentTimeZone();
					} else {
						dateTimeNow = nullValue;
					}
					Entity.SetColumnValue("SolutionProvidedOn", dateTimeNow);
				}
			}
			if (isNewStatusFinalOrResolved) {
				SetCurrentDateTime("FirstSolutionProvidedOn");
				SetCurrentDateTime("SolutionProvidedOn");
			}
		}

		public virtual bool GetStatusIs(Guid statusId, params string [] columns) {
			var result = false;
						if (!UserConnection.GetIsFeatureEnabled("UseCaseStatusStore")) {
							var store = new CaseStatusStore(UserConnection);
							foreach (string column in columns) {
								switch (column) {
									case "IsPaused":
										result |= store.StatusIsPaused(statusId);
										break;
									case "IsFinal":
										result |= store.StatusIsFinal(statusId);
										break;
									case "IsResolved":
										result |= store.StatusIsResolved(statusId);
										break;
								}
							}
						} else {
							var select = new Select(UserConnection)
								.From("CaseStatus")
								.Where("Id").IsEqual(Column.Parameter(statusId)) as Select;
							foreach (var column in columns) {
								select = select.Column(column);
							}
							using (var dbExecutor = UserConnection.EnsureDBConnection()) {
								using (IDataReader dr = select.ExecuteReader(dbExecutor)) {
									if (dr.Read()) {
										foreach (var column in columns) {
											result |= dr.GetColumnValue<bool>(column);
										}
									}
								}
							}
						}
			return result;
		}

		public virtual bool GetIsStatusPaused(Guid statusId) {
			return GetStatusIs(statusId, "IsPaused");
		}

		public virtual bool GetIsStatusResolved(Guid statusId) {
			return GetStatusIs(statusId, "IsResolved");
		}

		public virtual bool GetIsStatusFinal(Guid statusId) {
			return GetStatusIs(statusId, "IsFinal");
		}

		public virtual bool GetIsStatusFinalOrResolved(Guid id) {
			var columns = new [] {
				"IsFinal",
				"IsResolved"
			};
			return GetStatusIs(id, columns);
		}

		public virtual DateTime GetDateTimeInCurrentTimeZone() {
			return TimeZoneInfo.ConvertTime(DateTime.UtcNow, TimeZoneInfo.Utc, UserConnection.CurrentUser.TimeZone);
		}

		public virtual void UpdateClosureDate() {
			var statusId = Entity.GetTypedColumnValue<Guid>("StatusId");
			var closureDate = Entity.GetTypedColumnValue<DateTime>("ClosureDate");
			if (IsStatusChanged(Entity) && GetIsStatusFinal(statusId) && closureDate == default(DateTime)) {
				var currentUserDateTime = 
				CaseTimezoneHelper.GetContactTimezone(UserConnection, UserConnection.CurrentUser.ContactId.ToString());
				if (currentUserDateTime != null) {
					Entity.SetColumnValue("ClosureDate", DateTime.Parse(currentUserDateTime));
				}
			}
		}

		public virtual void SetCurrentDateTime(string dateTimeField) {
			if (Entity.GetTypedColumnValue<DateTime>(dateTimeField) == default(DateTime)) {
				var currentUserDateTime = 
				CaseTimezoneHelper.GetContactTimezone(UserConnection, UserConnection.CurrentUser.ContactId.ToString());
				if (currentUserDateTime != null) {
					Entity.SetColumnValue(dateTimeField, DateTime.Parse(currentUserDateTime));
				}
			}
		}

		public virtual bool GetIsStatusWaiting(Guid statusId) {
			Guid waitingForResponseId = Guid.Parse("3859C6E7-CBCB-486B-BA53-77808FE6E593"); 
			return statusId.Equals(waitingForResponseId);
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "Case_SLM_TerrasoftSaving":
							if (ActivatedEventElements.Contains("SLM_CaseSavingStartMessage")) {
							context.QueueTasks.Enqueue("SLM_CaseSavingStartMessage");
							ProcessQueue(context);
							return;
						}
						break;
					case "Case_SLM_TerrasoftSaved":
							if (ActivatedEventElements.Contains("SLM_CaseSavedStartMessage")) {
							context.QueueTasks.Enqueue("SLM_CaseSavedStartMessage");
							ProcessQueue(context);
							return;
						}
						break;
			}
			base.ThrowEvent(context, message);
			ProcessQueue(context);
		}

		public override void WritePropertiesData(DataWriter writer, bool writeFlowElements = true) {
			base.WritePropertiesData(writer, writeFlowElements);
			if (!HasMapping("NeedSaveLifecycle") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("NeedSaveLifecycle", NeedSaveLifecycle, false);
			}
		}

		public override object CloneShallow() {
			return base.CloneShallow();
		}

		#endregion

	}

	#endregion

	#region Class: Case_SLMEventsProcess

	/// <exclude/>
	public class Case_SLMEventsProcess : Case_SLMEventsProcess<Case_SLM_Terrasoft>
	{

		public Case_SLMEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: Case_SLM_TerrasoftEventsProcessSchema

	/// <exclude/>
	public class Case_SLM_TerrasoftEventsProcessSchema : Terrasoft.Configuration.Case_Case_TerrasoftEventsProcessSchema
	{

		#region Constructors: Public

		public Case_SLM_TerrasoftEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public Case_SLM_TerrasoftEventsProcessSchema(Case_SLM_TerrasoftEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "Case_SLMEventsProcess";
			UId = new Guid("08d19c3e-cef5-4a07-9fae-18525efc876b");
			CreatedInPackageId = new Guid("4bc36079-7dbb-41e6-9a4e-b85039bf2a70");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("2e4ad2a2-869c-48da-b867-91374c625baa");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
		}

		protected virtual ProcessSchemaParameter CreateNeedSaveLifecycleParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("8a815a9d-3295-41cd-89f6-b7429383b442"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("08d19c3e-cef5-4a07-9fae-18525efc876b"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("08d19c3e-cef5-4a07-9fae-18525efc876b"),
				Name = @"NeedSaveLifecycle",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateNeedSaveLifecycleParameter());
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet_2 = CreateLaneSet_2LaneSet();
			LaneSets.Add(schemaLaneSet_2);
			ProcessSchemaLane schemaLane2 = CreateLane2Lane();
			schemaLaneSet_2.Lanes.Add(schemaLane2);
			ProcessSchemaEventSubProcess slm_eventsubprocess4 = CreateSLM_EventSubProcess4EventSubProcess();
			FlowElements.Add(slm_eventsubprocess4);
			ProcessSchemaScriptTask logchangesscripttask = CreateLogChangesScriptTaskScriptTask();
			slm_eventsubprocess4.FlowElements.Add(logchangesscripttask);
			ProcessSchemaStartMessageEvent slm_casesavingstartmessage = CreateSLM_CaseSavingStartMessageStartMessageEvent();
			slm_eventsubprocess4.FlowElements.Add(slm_casesavingstartmessage);
			ProcessSchemaIntermediateThrowMessageEvent slm_casesavingintermediatethrowmessage = CreateSLM_CaseSavingIntermediateThrowMessageIntermediateThrowMessageEvent();
			slm_eventsubprocess4.FlowElements.Add(slm_casesavingintermediatethrowmessage);
			ProcessSchemaIntermediateThrowMessageEvent slm_casesavedintermediatethrowmessage = CreateSLM_CaseSavedIntermediateThrowMessageIntermediateThrowMessageEvent();
			slm_eventsubprocess4.FlowElements.Add(slm_casesavedintermediatethrowmessage);
			ProcessSchemaScriptTask slm_setisneedtologlifecyclescripttask = CreateSLM_SetIsNeedToLogLifecycleScriptTaskScriptTask();
			slm_eventsubprocess4.FlowElements.Add(slm_setisneedtologlifecyclescripttask);
			ProcessSchemaStartMessageEvent slm_casesavedstartmessage = CreateSLM_CaseSavedStartMessageStartMessageEvent();
			slm_eventsubprocess4.FlowElements.Add(slm_casesavedstartmessage);
			ProcessSchemaScriptTask slm_updatecolumnsscripttask = CreateSLM_UpdateColumnsScriptTaskScriptTask();
			slm_eventsubprocess4.FlowElements.Add(slm_updatecolumnsscripttask);
			FlowElements.Add(CreateSLM_SequenceFlow18SequenceFlow());
			FlowElements.Add(CreateSLM_SequenceFlow19SequenceFlow());
			FlowElements.Add(CreateSLM_SequenceFlow20SequenceFlow());
			FlowElements.Add(CreateSLM_SequenceFlow21SequenceFlow());
			FlowElements.Add(CreateSequenceFlow144SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSLM_SequenceFlow18SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SLM_SequenceFlow18",
				UId = new Guid("717f4ae5-072c-4af9-80ab-6c479c58547f"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("2e4ad2a2-869c-48da-b867-91374c625baa"),
				CreatedInPackageId = new Guid("c4b72b51-b2ae-4127-a458-608f5464622c"),
				CreatedInSchemaUId = new Guid("08d19c3e-cef5-4a07-9fae-18525efc876b"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("08d19c3e-cef5-4a07-9fae-18525efc876b"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("8438da09-4b2b-423a-98e7-01d26e53994e"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("00a4ff68-2b07-4d54-99c3-f51fa625c33c"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSLM_SequenceFlow19SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SLM_SequenceFlow19",
				UId = new Guid("680a9cd4-ecfa-476f-9d5b-2b6b26090c94"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("2e4ad2a2-869c-48da-b867-91374c625baa"),
				CreatedInPackageId = new Guid("c4b72b51-b2ae-4127-a458-608f5464622c"),
				CreatedInSchemaUId = new Guid("08d19c3e-cef5-4a07-9fae-18525efc876b"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("08d19c3e-cef5-4a07-9fae-18525efc876b"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("00a4ff68-2b07-4d54-99c3-f51fa625c33c"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("223892fd-ea8a-4fb3-b606-902ceae69017"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSLM_SequenceFlow20SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SLM_SequenceFlow20",
				UId = new Guid("c5802d06-e097-4c51-8da6-b94171aca243"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("2e4ad2a2-869c-48da-b867-91374c625baa"),
				CreatedInPackageId = new Guid("c4b72b51-b2ae-4127-a458-608f5464622c"),
				CreatedInSchemaUId = new Guid("08d19c3e-cef5-4a07-9fae-18525efc876b"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("08d19c3e-cef5-4a07-9fae-18525efc876b"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("9dda909c-699b-4cc1-b336-773e8cb64ce8"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("a73f848f-f46c-477a-9e32-98f6bcb4d9f6"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSLM_SequenceFlow21SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SLM_SequenceFlow21",
				UId = new Guid("8bbad64e-fb62-4bba-b2e6-a1e5ae518733"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("2e4ad2a2-869c-48da-b867-91374c625baa"),
				CreatedInPackageId = new Guid("c4b72b51-b2ae-4127-a458-608f5464622c"),
				CreatedInSchemaUId = new Guid("08d19c3e-cef5-4a07-9fae-18525efc876b"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("08d19c3e-cef5-4a07-9fae-18525efc876b"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("23046b50-e6cf-40ab-89bf-8b4fbd15d222"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("795470b7-437d-4498-bf31-19d87954dc1b"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow144SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow144",
				UId = new Guid("e0672f19-94d0-4061-9b78-4b7afe9aa100"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("2e4ad2a2-869c-48da-b867-91374c625baa"),
				CreatedInPackageId = new Guid("b11d550e-0087-4f53-ae17-fb00d41102cf"),
				CreatedInSchemaUId = new Guid("08d19c3e-cef5-4a07-9fae-18525efc876b"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("08d19c3e-cef5-4a07-9fae-18525efc876b"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("a73f848f-f46c-477a-9e32-98f6bcb4d9f6"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("23046b50-e6cf-40ab-89bf-8b4fbd15d222"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet_2LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet_2 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("c235aabb-1929-423d-aef5-0f7b76a39cb0"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("2e4ad2a2-869c-48da-b867-91374c625baa"),
				CreatedInPackageId = new Guid("b11d550e-0087-4f53-ae17-fb00d41102cf"),
				CreatedInSchemaUId = new Guid("08d19c3e-cef5-4a07-9fae-18525efc876b"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("08d19c3e-cef5-4a07-9fae-18525efc876b"),
				Name = @"LaneSet_2",
				Position = new Point(0, 5),
				Size = new Size(0, 400),
				UseBackgroundMode = false
			};
			return schemaLaneSet_2;
		}

		protected virtual ProcessSchemaLane CreateLane2Lane() {
			ProcessSchemaLane schemaLane2 = new ProcessSchemaLane(this) {
				UId = new Guid("06ef5ed1-1e20-4df4-9a01-b01fa2ab4416"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c235aabb-1929-423d-aef5-0f7b76a39cb0"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("b11d550e-0087-4f53-ae17-fb00d41102cf"),
				CreatedInSchemaUId = new Guid("08d19c3e-cef5-4a07-9fae-18525efc876b"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("08d19c3e-cef5-4a07-9fae-18525efc876b"),
				Name = @"Lane2",
				Position = new Point(0, 0),
				Size = new Size(700, 400),
				UseBackgroundMode = false
			};
			return schemaLane2;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSLM_EventSubProcess4EventSubProcess() {
			ProcessSchemaEventSubProcess schemaSLM_EventSubProcess4 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("7acc5824-a8d2-4916-b0bb-74950db35337"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("06ef5ed1-1e20-4df4-9a01-b01fa2ab4416"),
				CreatedInOwnerSchemaUId = new Guid("2e4ad2a2-869c-48da-b867-91374c625baa"),
				CreatedInPackageId = new Guid("c4b72b51-b2ae-4127-a458-608f5464622c"),
				CreatedInSchemaUId = new Guid("08d19c3e-cef5-4a07-9fae-18525efc876b"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("08d19c3e-cef5-4a07-9fae-18525efc876b"),
				Name = @"SLM_EventSubProcess4",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(120, 20),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(620, 340),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSLM_EventSubProcess4;
		}

		protected virtual ProcessSchemaScriptTask CreateLogChangesScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("00a4ff68-2b07-4d54-99c3-f51fa625c33c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7acc5824-a8d2-4916-b0bb-74950db35337"),
				CreatedInOwnerSchemaUId = new Guid("2e4ad2a2-869c-48da-b867-91374c625baa"),
				CreatedInPackageId = new Guid("c4b72b51-b2ae-4127-a458-608f5464622c"),
				CreatedInSchemaUId = new Guid("08d19c3e-cef5-4a07-9fae-18525efc876b"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("08d19c3e-cef5-4a07-9fae-18525efc876b"),
				Name = @"LogChangesScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(131, 200),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,203,76,83,208,240,75,77,77,9,78,44,75,245,201,76,75,77,174,76,206,73,213,84,168,230,226,68,17,209,208,180,230,170,229,42,74,45,41,45,202,83,40,41,42,77,181,6,0,254,189,64,45,57,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateSLM_CaseSavingStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("9dda909c-699b-4cc1-b336-773e8cb64ce8"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7acc5824-a8d2-4916-b0bb-74950db35337"),
				CreatedInOwnerSchemaUId = new Guid("2e4ad2a2-869c-48da-b867-91374c625baa"),
				CreatedInPackageId = new Guid("c4b72b51-b2ae-4127-a458-608f5464622c"),
				CreatedInSchemaUId = new Guid("08d19c3e-cef5-4a07-9fae-18525efc876b"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"CaseSaving",
				ModifiedInSchemaUId = new Guid("08d19c3e-cef5-4a07-9fae-18525efc876b"),
				Name = @"SLM_CaseSavingStartMessage",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(33, 71),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateSLM_CaseSavingIntermediateThrowMessageIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("795470b7-437d-4498-bf31-19d87954dc1b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7acc5824-a8d2-4916-b0bb-74950db35337"),
				CreatedInOwnerSchemaUId = new Guid("2e4ad2a2-869c-48da-b867-91374c625baa"),
				CreatedInPackageId = new Guid("c4b72b51-b2ae-4127-a458-608f5464622c"),
				CreatedInSchemaUId = new Guid("08d19c3e-cef5-4a07-9fae-18525efc876b"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"CaseSaving",
				ModifiedInSchemaUId = new Guid("08d19c3e-cef5-4a07-9fae-18525efc876b"),
				Name = @"SLM_CaseSavingIntermediateThrowMessage",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(420, 71),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateSLM_CaseSavedIntermediateThrowMessageIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("223892fd-ea8a-4fb3-b606-902ceae69017"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7acc5824-a8d2-4916-b0bb-74950db35337"),
				CreatedInOwnerSchemaUId = new Guid("2e4ad2a2-869c-48da-b867-91374c625baa"),
				CreatedInPackageId = new Guid("c4b72b51-b2ae-4127-a458-608f5464622c"),
				CreatedInSchemaUId = new Guid("08d19c3e-cef5-4a07-9fae-18525efc876b"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"CaseSaved",
				ModifiedInSchemaUId = new Guid("08d19c3e-cef5-4a07-9fae-18525efc876b"),
				Name = @"SLM_CaseSavedIntermediateThrowMessage",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(280, 214),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateSLM_SetIsNeedToLogLifecycleScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("23046b50-e6cf-40ab-89bf-8b4fbd15d222"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7acc5824-a8d2-4916-b0bb-74950db35337"),
				CreatedInOwnerSchemaUId = new Guid("2e4ad2a2-869c-48da-b867-91374c625baa"),
				CreatedInPackageId = new Guid("c4b72b51-b2ae-4127-a458-608f5464622c"),
				CreatedInSchemaUId = new Guid("08d19c3e-cef5-4a07-9fae-18525efc876b"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("08d19c3e-cef5-4a07-9fae-18525efc876b"),
				Name = @"SLM_SetIsNeedToLogLifecycleScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(275, 57),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,243,75,77,77,9,78,44,75,245,201,76,75,77,174,76,206,73,85,176,85,112,79,45,241,44,246,3,74,132,228,251,228,167,195,101,52,52,173,185,138,82,75,74,139,242,20,74,138,74,83,173,1,90,13,8,216,59,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateSLM_CaseSavedStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("8438da09-4b2b-423a-98e7-01d26e53994e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7acc5824-a8d2-4916-b0bb-74950db35337"),
				CreatedInOwnerSchemaUId = new Guid("2e4ad2a2-869c-48da-b867-91374c625baa"),
				CreatedInPackageId = new Guid("c4b72b51-b2ae-4127-a458-608f5464622c"),
				CreatedInSchemaUId = new Guid("08d19c3e-cef5-4a07-9fae-18525efc876b"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"CaseSaved",
				ModifiedInSchemaUId = new Guid("08d19c3e-cef5-4a07-9fae-18525efc876b"),
				Name = @"SLM_CaseSavedStartMessage",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(33, 214),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateSLM_UpdateColumnsScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("a73f848f-f46c-477a-9e32-98f6bcb4d9f6"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("7acc5824-a8d2-4916-b0bb-74950db35337"),
				CreatedInOwnerSchemaUId = new Guid("2e4ad2a2-869c-48da-b867-91374c625baa"),
				CreatedInPackageId = new Guid("b11d550e-0087-4f53-ae17-fb00d41102cf"),
				CreatedInSchemaUId = new Guid("08d19c3e-cef5-4a07-9fae-18525efc876b"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("08d19c3e-cef5-4a07-9fae-18525efc876b"),
				Name = @"SLM_UpdateColumnsScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(131, 57),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,45,72,73,44,73,13,74,45,46,200,207,43,78,213,208,180,230,10,5,139,4,231,231,148,150,100,230,231,33,68,156,115,242,139,75,139,82,93,128,76,144,96,81,106,73,105,81,158,66,73,81,105,170,53,0,172,108,250,167,69,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateSaveLifecycleMethod());
			Methods.Add(CreateGetLoggingColumnsMethod());
			Methods.Add(CreateClosePreviousIntervalMethod());
			Methods.Add(CreateOpenNewIntervalMethod());
			Methods.Add(CreateGetIsNeedToLogLifecycleMethod());
			Methods.Add(CreateGetIsStatusActiveMethod());
			Methods.Add(CreateUpdateResponseMethod());
			Methods.Add(CreateUpdateSolutionMethod());
			Methods.Add(CreateGetStatusIsMethod());
			Methods.Add(CreateGetIsStatusPausedMethod());
			Methods.Add(CreateGetIsStatusResolvedMethod());
			Methods.Add(CreateGetIsStatusFinalMethod());
			Methods.Add(CreateGetIsStatusFinalOrResolvedMethod());
			Methods.Add(CreateGetDateTimeInCurrentTimeZoneMethod());
			Methods.Add(CreateUpdateClosureDateMethod());
			Methods.Add(CreateSetCurrentDateTimeMethod());
			Methods.Add(CreateGetIsStatusWaitingMethod());
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("fb7b81ba-7c3c-45a5-ae9e-c6c03dceb812"),
				Name = "Terrasoft.UI.WebControls.Controls",
				Alias = "",
				CreatedInPackageId = new Guid("4bc36079-7dbb-41e6-9a4e-b85039bf2a70")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("cde525cf-d220-4d2a-b963-e55254c639fc"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("4bc36079-7dbb-41e6-9a4e-b85039bf2a70")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5c9c82c6-ba6d-4a57-9a14-87fe8faa4ebb"),
				Name = "Terrasoft.Core.DB",
				Alias = "",
				CreatedInPackageId = new Guid("4bc36079-7dbb-41e6-9a4e-b85039bf2a70")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7821de68-c82b-4917-a6cd-add2adfbe400"),
				Name = "Terrasoft.Common",
				Alias = "",
				CreatedInPackageId = new Guid("4bc36079-7dbb-41e6-9a4e-b85039bf2a70")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d67de76f-9cbc-4bfc-babb-6f65cb89b973"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("4bc36079-7dbb-41e6-9a4e-b85039bf2a70")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("74160d3b-65e3-4694-b554-089f2d980e54"),
				Name = "Newtonsoft.Json",
				Alias = "",
				CreatedInPackageId = new Guid("4bc36079-7dbb-41e6-9a4e-b85039bf2a70")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e401300a-9f16-40c2-9788-cf310ae9d1c5"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("4bc36079-7dbb-41e6-9a4e-b85039bf2a70")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("bed5e433-d5cb-4c18-9dbe-5d423c021d39"),
				Name = "Terrasoft.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("677baab4-893e-4898-b508-38190fd135a7")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d5bb3512-71e0-482a-9c7e-16bf22c586b7"),
				Name = "Terrasoft.Nui.ServiceModel.DataContract",
				Alias = "DataContract",
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("67f53755-c06e-485d-88cf-faa5ea95f5f3"),
				Name = "System.Linq",
				Alias = "",
				CreatedInPackageId = new Guid("c3c90037-274c-4793-841e-197eb228d3cd")
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
				UId = new Guid("b5657843-65bd-4915-8bd8-7e4ff6da55c4"),
				Name = "Terrasoft.Core",
				Alias = "",
				CreatedInPackageId = new Guid("c3c90037-274c-4793-841e-197eb228d3cd")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e686ca87-b149-46cb-b557-f1cd4001bd3c"),
				Name = "Terrasoft.Core.Configuration.SysSettings",
				Alias = "CoreSysSettings",
				CreatedInPackageId = new Guid("c3c90037-274c-4793-841e-197eb228d3cd")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("9ce71bdf-0d43-4122-aafb-d9cd53cc4b84"),
				Name = "Terrasoft.Configuration.CaseSequenceService",
				Alias = "",
				CreatedInPackageId = new Guid("c3c90037-274c-4793-841e-197eb228d3cd")
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

		protected override SchemaMethod CreateLocalMessageExecutingMethod() {
			SchemaMethod method = base.CreateLocalMessageExecutingMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,77,141,75,10,194,48,16,134,247,158,98,150,45,148,92,160,184,42,130,11,221,213,3,12,225,111,26,136,147,50,51,86,122,123,45,69,112,255,61,86,86,42,207,43,202,2,165,51,9,222,52,66,149,173,78,30,134,42,83,78,47,101,207,85,194,173,70,46,119,152,113,194,33,52,62,103,11,23,241,236,91,71,15,131,126,13,65,220,241,142,226,204,146,48,110,11,218,254,244,123,132,65,193,142,255,86,211,246,31,106,54,191,216,134,0,0,0 };
			return method;
		}

		protected override SchemaMethod CreateGetServiceCaptionMethod() {
			SchemaMethod method = base.CreateGetServiceCaptionMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,144,209,10,130,48,20,134,175,243,41,134,87,10,225,11,88,66,136,136,23,5,97,117,63,244,100,131,237,40,115,51,36,122,247,102,90,206,232,246,236,252,223,247,159,117,84,146,22,100,199,10,200,20,136,172,36,91,146,160,98,170,15,82,80,167,190,129,50,174,185,22,120,161,92,195,38,213,172,140,60,55,183,19,174,31,58,221,140,57,106,144,189,161,32,220,39,82,94,220,64,208,247,220,59,155,173,184,70,132,66,177,26,3,123,97,79,145,86,32,215,196,198,15,112,27,28,236,202,169,144,231,30,168,0,243,78,108,187,17,47,122,12,87,140,146,31,245,122,121,182,209,176,171,247,133,152,250,154,115,159,60,156,149,4,165,37,146,86,73,134,85,144,136,70,245,161,243,36,206,103,62,70,254,254,214,152,137,230,166,47,145,106,202,35,110,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSaveLifecycleMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("2cb7e81b-7235-4cd8-bbbc-0a3454cc1016"),
				Name = "SaveLifecycle",
				CreatedInSchemaUId = new Guid("08d19c3e-cef5-4a07-9fae-18525efc876b"),
				CreatedInPackageId = new Guid("c4b72b51-b2ae-4127-a458-608f5464622c"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,207,75,10,194,48,16,6,224,189,167,8,93,181,32,61,128,207,69,170,165,155,86,164,186,143,102,144,64,58,41,201,164,210,219,155,74,149,234,66,112,57,63,243,248,38,19,4,181,106,128,137,43,41,131,89,40,217,154,157,28,88,110,16,225,25,166,220,91,11,72,67,154,230,64,99,153,141,163,113,178,156,93,140,209,76,185,210,208,94,89,71,227,26,174,141,131,131,133,78,25,239,10,36,176,157,208,241,14,73,81,63,44,170,251,22,36,55,218,55,120,22,218,195,42,247,74,110,226,168,144,81,50,159,136,194,129,15,222,215,161,237,191,94,182,96,63,16,175,190,0,57,194,77,185,192,6,89,97,20,20,85,11,88,194,253,253,202,148,248,0,209,181,234,148,74,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetLoggingColumnsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("7a3e9468-44c7-4b22-b87b-eee01f8de29f"),
				Name = "GetLoggingColumns",
				CreatedInSchemaUId = new Guid("08d19c3e-cef5-4a07-9fae-18525efc876b"),
				CreatedInPackageId = new Guid("c4b72b51-b2ae-4127-a458-608f5464622c"),
				ResultValueTypeName = "List<string>"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,200,75,45,87,240,201,44,46,177,41,46,41,202,204,75,183,211,208,84,168,230,226,84,10,46,73,44,41,45,246,76,81,210,1,114,2,138,50,243,139,50,75,42,161,220,224,212,162,178,204,228,84,207,146,212,92,168,136,127,121,94,106,17,148,237,94,148,95,90,0,83,153,159,83,90,146,153,159,231,146,88,146,138,34,16,80,148,95,150,153,146,154,226,159,167,196,85,107,13,0,98,128,142,103,139,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateClosePreviousIntervalMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("339a3b27-324d-438e-ae4c-4dd3e9db7904"),
				Name = "ClosePreviousInterval",
				CreatedInSchemaUId = new Guid("08d19c3e-cef5-4a07-9fae-18525efc876b"),
				CreatedInPackageId = new Guid("c4b72b51-b2ae-4127-a458-608f5464622c"),
				ResultValueTypeName = "bool"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("d1f7b37f-7a53-445d-bfb2-705848105825"),
				Name = "CaseId",
				CreatedInSchemaUId = new Guid("08d19c3e-cef5-4a07-9fae-18525efc876b"),
				ModifiedInSchemaUId = new Guid("08d19c3e-cef5-4a07-9fae-18525efc876b"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("c4b72b51-b2ae-4127-a458-608f5464622c")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("befc8f8e-f62e-4493-899d-aa756a6970c3"),
				Name = "Date",
				CreatedInSchemaUId = new Guid("08d19c3e-cef5-4a07-9fae-18525efc876b"),
				ModifiedInSchemaUId = new Guid("08d19c3e-cef5-4a07-9fae-18525efc876b"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "DateTime",
				CreatedInPackageId = new Guid("c4b72b51-b2ae-4127-a458-608f5464622c")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,165,83,193,78,219,64,16,61,227,175,88,249,100,75,193,226,110,82,41,117,210,54,82,129,82,7,56,32,14,35,123,76,86,90,239,166,179,179,70,86,213,127,239,46,118,74,0,35,129,122,178,60,243,222,155,55,243,236,14,72,236,8,59,105,156,93,107,70,234,64,173,202,75,49,23,26,31,196,74,179,228,190,172,182,216,194,165,67,234,147,43,139,84,24,173,177,98,105,116,118,8,56,3,13,247,72,51,17,23,96,241,187,108,176,234,43,133,113,154,71,19,19,178,69,93,47,148,26,168,133,81,174,213,54,121,27,58,32,146,184,100,32,94,2,123,217,236,130,106,164,207,253,18,109,245,22,243,139,84,254,197,6,133,100,170,95,16,122,173,1,117,35,121,251,3,8,90,12,148,36,58,26,202,133,105,119,64,210,26,189,233,119,152,173,126,57,80,227,142,241,76,132,199,186,78,255,107,252,218,158,59,165,6,108,18,175,116,61,236,231,53,187,137,116,172,207,102,74,235,43,242,144,134,63,149,26,226,121,145,150,23,148,141,120,101,196,102,133,113,154,197,124,46,78,82,241,59,58,34,100,71,90,52,190,133,121,244,231,209,133,2,203,123,194,132,1,123,123,114,151,71,135,160,204,207,94,212,173,212,63,229,253,150,131,233,81,47,44,183,145,45,10,187,143,210,247,158,49,253,38,225,212,99,230,215,160,28,158,238,89,159,158,125,2,121,20,106,229,14,180,168,101,211,32,161,174,130,92,178,47,167,73,0,30,255,27,149,190,48,89,34,31,76,121,58,254,76,188,7,237,157,48,46,29,65,184,238,90,159,73,237,24,173,39,63,153,201,54,134,65,141,157,15,234,125,51,142,166,212,30,235,31,212,90,66,63,37,21,202,175,148,160,195,240,63,141,159,1,147,195,252,47,94,227,36,231,39,4,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateOpenNewIntervalMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("c9353839-0d47-4368-81c5-7a82178f8584"),
				Name = "OpenNewInterval",
				CreatedInSchemaUId = new Guid("08d19c3e-cef5-4a07-9fae-18525efc876b"),
				CreatedInPackageId = new Guid("c4b72b51-b2ae-4127-a458-608f5464622c"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("6ccb8b84-30ff-48fb-9205-0c39de65dd54"),
				Name = "Date",
				CreatedInSchemaUId = new Guid("08d19c3e-cef5-4a07-9fae-18525efc876b"),
				ModifiedInSchemaUId = new Guid("08d19c3e-cef5-4a07-9fae-18525efc876b"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "DateTime",
				CreatedInPackageId = new Guid("c4b72b51-b2ae-4127-a458-608f5464622c")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,146,81,79,194,48,20,133,159,37,225,63,52,123,234,18,178,63,160,144,200,32,134,4,53,17,245,189,118,119,208,100,187,35,235,5,93,8,255,221,222,85,195,54,134,62,232,211,178,246,244,187,167,167,103,175,74,1,72,134,170,149,222,64,174,98,101,97,105,82,208,149,206,64,140,197,139,133,50,46,16,65,147,41,48,154,55,164,247,10,213,26,202,232,14,104,129,150,20,106,152,86,15,42,7,25,180,40,65,120,61,28,236,123,230,252,9,95,83,61,23,225,189,107,251,226,149,162,184,4,69,224,7,201,246,120,38,118,89,145,147,220,38,185,193,39,179,222,144,117,232,84,101,22,250,148,43,160,25,164,113,145,237,114,124,85,217,14,172,60,121,76,140,85,111,25,196,69,158,23,232,53,12,115,16,177,52,150,110,44,149,6,215,19,25,138,195,112,112,21,44,146,96,196,95,239,54,121,196,214,239,180,114,251,195,193,241,43,87,221,129,254,112,121,175,113,40,231,54,115,183,150,122,60,97,15,7,14,214,29,213,81,195,63,175,141,196,76,145,170,127,159,171,173,151,180,86,142,33,211,22,72,80,90,6,118,135,127,207,252,199,129,97,211,191,24,79,156,130,79,214,203,243,15,13,91,146,125,113,251,199,72,11,151,161,222,72,31,184,203,142,247,106,51,6,219,73,250,167,232,123,230,134,101,121,2,140,132,111,21,55,182,95,17,178,133,35,187,248,141,90,87,156,75,112,129,201,5,9,123,251,218,5,173,72,149,228,2,132,160,78,22,124,10,231,199,212,30,92,93,63,1,157,150,95,5,15,4,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetIsNeedToLogLifecycleMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("f1506e8d-a08e-46af-8ca3-5f917c33bffa"),
				Name = "GetIsNeedToLogLifecycle",
				CreatedInSchemaUId = new Guid("08d19c3e-cef5-4a07-9fae-18525efc876b"),
				CreatedInPackageId = new Guid("c4b72b51-b2ae-4127-a458-608f5464622c"),
				ResultValueTypeName = "bool"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,85,144,203,10,2,49,12,69,215,206,87,196,205,208,110,250,3,90,65,100,16,65,116,33,232,186,106,168,66,38,131,125,193,192,124,188,213,14,62,150,201,61,55,185,73,50,14,168,179,171,142,98,203,30,180,216,52,28,91,116,230,76,56,247,193,221,217,46,36,172,49,108,59,107,115,49,130,66,206,170,148,173,151,155,97,139,215,163,161,136,217,13,13,135,123,232,85,230,87,69,41,124,209,133,84,167,27,58,20,9,244,2,170,137,16,73,189,21,152,106,224,72,36,161,174,97,58,54,85,243,136,134,124,102,246,84,22,72,9,195,240,107,211,63,182,47,246,153,86,229,144,14,67,116,252,159,83,29,144,240,18,74,140,164,118,166,69,169,54,28,208,249,87,251,251,14,169,150,220,231,83,159,175,139,129,19,37,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetIsStatusActiveMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("3bfef842-b502-48f2-9cec-42ed221aa868"),
				Name = "GetIsStatusActive",
				CreatedInSchemaUId = new Guid("08d19c3e-cef5-4a07-9fae-18525efc876b"),
				CreatedInPackageId = new Guid("b11d550e-0087-4f53-ae17-fb00d41102cf"),
				ResultValueTypeName = "bool"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("25d4b440-6d74-4bf8-a82f-d4596dd5d7a6"),
				Name = "statusId",
				CreatedInSchemaUId = new Guid("08d19c3e-cef5-4a07-9fae-18525efc876b"),
				ModifiedInSchemaUId = new Guid("08d19c3e-cef5-4a07-9fae-18525efc876b"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("b11d550e-0087-4f53-ae17-fb00d41102cf")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,75,44,82,72,206,207,41,205,205,43,86,176,85,200,75,45,87,136,142,85,168,230,226,84,242,44,14,72,44,45,78,77,81,210,1,115,220,50,243,18,115,160,236,160,212,226,252,156,50,160,20,87,173,53,87,81,106,73,105,81,158,130,162,123,106,73,112,73,98,73,105,177,103,177,70,49,132,145,162,3,51,90,211,26,0,218,212,32,52,104,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateUpdateResponseMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("d9cb4d93-2eab-4ded-8442-cd7021cd6295"),
				Name = "UpdateResponse",
				CreatedInSchemaUId = new Guid("08d19c3e-cef5-4a07-9fae-18525efc876b"),
				CreatedInPackageId = new Guid("b11d550e-0087-4f53-ae17-fb00d41102cf"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,144,207,10,194,48,12,135,207,238,41,130,167,14,196,23,208,121,81,25,94,20,220,240,224,173,208,8,131,174,29,93,170,12,183,119,183,211,14,55,255,225,177,201,47,95,190,244,204,13,148,196,201,150,27,177,212,210,230,106,203,115,132,8,198,137,175,142,103,193,217,133,180,20,93,197,117,215,138,50,170,166,49,82,90,21,40,118,210,15,31,184,180,56,143,109,38,22,236,29,27,62,80,229,87,206,159,144,236,4,108,224,19,65,155,158,174,243,130,42,168,107,120,105,118,144,16,174,193,200,32,89,163,102,65,115,119,49,88,22,90,9,119,130,26,158,191,127,54,252,15,244,162,191,205,87,156,48,205,114,92,176,143,116,127,192,0,23,129,192,19,183,146,88,55,28,222,101,219,189,194,87,182,250,226,246,186,133,93,100,163,150,214,24,84,212,62,142,90,33,115,232,145,23,75,144,122,78,159,77,38,125,182,155,109,110,209,29,139,118,14,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateUpdateSolutionMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("282267ee-4152-4617-a993-d0d398443963"),
				Name = "UpdateSolution",
				CreatedInSchemaUId = new Guid("08d19c3e-cef5-4a07-9fae-18525efc876b"),
				CreatedInPackageId = new Guid("b11d550e-0087-4f53-ae17-fb00d41102cf"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,221,148,201,110,194,48,16,134,207,32,241,14,110,14,85,144,42,94,160,155,80,10,136,11,32,160,61,244,230,54,131,100,201,216,200,75,80,85,242,238,181,99,39,117,68,88,186,28,170,94,34,39,30,255,243,253,51,227,100,88,32,169,176,210,114,156,38,156,234,53,155,224,53,160,91,20,45,252,215,232,186,211,206,76,20,167,105,249,201,108,15,152,34,234,173,55,2,181,124,219,64,58,165,254,244,19,166,26,110,70,154,164,119,241,190,110,215,107,201,131,66,231,170,144,85,92,3,186,173,52,187,232,189,211,110,9,80,90,48,19,152,119,218,15,88,193,146,172,225,30,49,77,105,161,109,18,219,181,199,33,114,2,91,167,53,36,12,211,169,152,131,228,52,3,11,104,200,198,178,113,179,66,115,64,40,126,148,32,18,206,24,188,42,194,89,175,56,57,4,19,35,96,192,240,11,53,71,162,4,75,152,107,10,253,205,134,18,16,81,215,241,218,227,23,65,170,190,145,200,32,244,232,3,91,14,120,90,110,124,9,56,148,187,182,98,159,165,73,253,106,194,183,197,142,5,58,82,151,221,46,204,51,195,90,134,245,240,168,94,228,16,107,25,245,217,44,179,206,139,103,64,227,28,149,160,99,150,104,33,128,41,251,242,204,25,196,206,72,142,128,74,240,130,245,211,85,211,93,160,125,248,161,91,128,10,230,45,142,22,230,197,118,110,38,120,70,82,51,213,44,186,10,11,83,164,202,125,183,142,216,71,151,151,40,108,102,99,253,189,251,19,40,214,183,129,168,60,148,8,129,223,19,48,63,203,179,55,152,69,15,235,86,127,199,105,173,232,117,142,214,217,151,139,2,22,161,165,254,74,129,153,55,190,1,102,47,94,84,77,230,119,202,81,212,163,169,38,127,252,178,254,243,219,152,187,159,239,41,255,86,222,193,150,244,113,52,36,66,170,134,60,133,116,211,129,3,177,249,7,140,226,178,96,71,7,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetStatusIsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("e66847bc-0e28-44f4-9c53-c9fd7b5765de"),
				Name = "GetStatusIs",
				CreatedInSchemaUId = new Guid("08d19c3e-cef5-4a07-9fae-18525efc876b"),
				CreatedInPackageId = new Guid("b11d550e-0087-4f53-ae17-fb00d41102cf"),
				ResultValueTypeName = "bool"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("434b82f5-34f7-4688-83ab-81c2a2cbd6f1"),
				Name = "statusId",
				CreatedInSchemaUId = new Guid("08d19c3e-cef5-4a07-9fae-18525efc876b"),
				ModifiedInSchemaUId = new Guid("08d19c3e-cef5-4a07-9fae-18525efc876b"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("b11d550e-0087-4f53-ae17-fb00d41102cf")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("ad0e202b-ef64-401f-8d83-a1952c4dc2f7"),
				Name = "columns",
				CreatedInSchemaUId = new Guid("08d19c3e-cef5-4a07-9fae-18525efc876b"),
				ModifiedInSchemaUId = new Guid("08d19c3e-cef5-4a07-9fae-18525efc876b"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string []",
				CreatedInPackageId = new Guid("b11d550e-0087-4f53-ae17-fb00d41102cf"),
				IsParams = true
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,147,189,82,195,48,12,199,103,247,41,140,167,100,201,3,16,202,64,155,114,217,122,237,1,179,147,168,52,135,107,31,150,221,114,7,188,59,74,156,143,54,3,109,134,196,150,149,159,36,255,165,163,180,220,2,122,229,248,156,239,164,66,72,103,140,177,122,199,163,187,23,4,187,48,90,67,233,106,163,147,103,112,57,174,64,58,111,33,211,178,80,80,69,130,124,22,18,97,235,200,140,91,103,44,136,56,230,223,13,131,29,137,141,141,137,208,26,78,124,226,24,93,242,227,54,48,219,209,137,44,247,60,66,103,107,253,206,75,163,252,65,243,90,119,43,236,233,12,79,181,107,28,131,125,48,179,146,194,112,145,227,90,122,132,74,220,119,102,214,149,249,51,15,73,37,33,149,222,143,226,181,219,170,203,131,158,130,50,249,72,39,212,85,173,165,186,14,109,221,110,101,110,0,141,58,222,146,107,239,121,133,252,59,27,222,191,28,72,212,115,69,64,209,133,119,146,108,219,205,84,137,0,73,86,214,28,34,49,170,38,250,131,183,61,144,124,34,175,68,156,228,152,125,122,42,117,209,170,144,172,165,149,7,112,96,199,12,99,46,177,11,52,145,184,73,231,31,125,251,68,195,34,9,17,122,185,211,177,68,230,177,233,148,22,87,21,217,23,148,158,46,141,126,156,52,112,166,145,90,119,249,52,154,162,161,87,123,70,190,148,78,110,64,86,64,44,59,6,15,84,8,39,209,24,101,4,180,51,83,217,164,113,57,227,222,92,238,133,234,196,161,113,11,21,191,74,229,225,161,48,70,61,94,22,63,212,63,124,207,117,159,89,160,73,213,221,116,167,127,180,222,16,56,233,3,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetIsStatusPausedMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("c8744216-1c0d-4f29-bb29-072621f67219"),
				Name = "GetIsStatusPaused",
				CreatedInSchemaUId = new Guid("08d19c3e-cef5-4a07-9fae-18525efc876b"),
				CreatedInPackageId = new Guid("b11d550e-0087-4f53-ae17-fb00d41102cf"),
				ResultValueTypeName = "bool"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("fea151ea-496e-4173-bbbd-683a7e3ca3e1"),
				Name = "statusId",
				CreatedInSchemaUId = new Guid("08d19c3e-cef5-4a07-9fae-18525efc876b"),
				ModifiedInSchemaUId = new Guid("08d19c3e-cef5-4a07-9fae-18525efc876b"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("b11d550e-0087-4f53-ae17-fb00d41102cf")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,112,79,45,9,46,73,44,41,45,246,44,214,40,134,48,82,116,20,148,60,139,3,18,75,139,83,83,148,52,173,1,21,150,8,212,41,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetIsStatusResolvedMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("b36abfb5-1856-44ad-84f5-91d28cb00cc9"),
				Name = "GetIsStatusResolved",
				CreatedInSchemaUId = new Guid("08d19c3e-cef5-4a07-9fae-18525efc876b"),
				CreatedInPackageId = new Guid("b11d550e-0087-4f53-ae17-fb00d41102cf"),
				ResultValueTypeName = "bool"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("347318c5-f863-417a-9a24-4379f75bd6d8"),
				Name = "statusId",
				CreatedInSchemaUId = new Guid("08d19c3e-cef5-4a07-9fae-18525efc876b"),
				ModifiedInSchemaUId = new Guid("08d19c3e-cef5-4a07-9fae-18525efc876b"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("b11d550e-0087-4f53-ae17-fb00d41102cf")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,112,79,45,9,46,73,44,41,45,246,44,214,40,134,48,82,116,20,148,60,139,131,82,139,243,115,202,82,83,148,52,173,1,13,94,24,216,43,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetIsStatusFinalMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("9eb4abd0-80d2-4f0f-b428-932d0c451ac7"),
				Name = "GetIsStatusFinal",
				CreatedInSchemaUId = new Guid("08d19c3e-cef5-4a07-9fae-18525efc876b"),
				CreatedInPackageId = new Guid("b11d550e-0087-4f53-ae17-fb00d41102cf"),
				ResultValueTypeName = "bool"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("989f1776-2b5a-4a17-a628-fc17e065b5ed"),
				Name = "statusId",
				CreatedInSchemaUId = new Guid("08d19c3e-cef5-4a07-9fae-18525efc876b"),
				ModifiedInSchemaUId = new Guid("08d19c3e-cef5-4a07-9fae-18525efc876b"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("b11d550e-0087-4f53-ae17-fb00d41102cf")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,112,79,45,9,46,73,44,41,45,246,44,214,40,134,48,82,116,20,148,60,139,221,50,243,18,115,148,52,173,1,116,209,148,95,40,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetIsStatusFinalOrResolvedMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("f6b8e585-86eb-4a2b-adc2-68497b07a4d9"),
				Name = "GetIsStatusFinalOrResolved",
				CreatedInSchemaUId = new Guid("08d19c3e-cef5-4a07-9fae-18525efc876b"),
				CreatedInPackageId = new Guid("b11d550e-0087-4f53-ae17-fb00d41102cf"),
				ResultValueTypeName = "bool"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("01d4b889-c7a5-4bd8-a878-d757264807e9"),
				Name = "id",
				CreatedInSchemaUId = new Guid("08d19c3e-cef5-4a07-9fae-18525efc876b"),
				ModifiedInSchemaUId = new Guid("08d19c3e-cef5-4a07-9fae-18525efc876b"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("b11d550e-0087-4f53-ae17-fb00d41102cf")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,75,44,82,72,206,207,41,205,205,43,86,176,85,200,75,45,87,136,142,85,168,230,226,84,242,44,118,203,204,75,204,81,210,1,179,131,82,139,243,115,202,82,83,148,184,106,173,185,138,82,75,74,139,242,20,220,83,75,130,75,18,75,74,139,61,139,53,50,83,116,96,198,104,90,3,0,63,66,109,221,84,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetDateTimeInCurrentTimeZoneMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("46cd4868-1758-4c58-b945-5802e97ddce7"),
				Name = "GetDateTimeInCurrentTimeZone",
				CreatedInSchemaUId = new Guid("08d19c3e-cef5-4a07-9fae-18525efc876b"),
				CreatedInPackageId = new Guid("b11d550e-0087-4f53-ae17-fb00d41102cf"),
				ResultValueTypeName = "DateTime"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,8,201,204,77,141,202,207,75,245,204,75,203,215,115,206,207,43,75,45,42,1,137,105,184,36,150,164,130,24,122,161,37,201,126,249,229,58,168,42,129,130,58,10,161,197,169,69,64,45,121,169,201,37,153,249,121,122,206,165,69,69,169,121,37,32,81,61,152,98,77,107,0,227,241,15,217,104,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateUpdateClosureDateMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("0f599aea-9f98-4904-9907-0546e7c07125"),
				Name = "UpdateClosureDate",
				CreatedInSchemaUId = new Guid("08d19c3e-cef5-4a07-9fae-18525efc876b"),
				CreatedInPackageId = new Guid("b11d550e-0087-4f53-ae17-fb00d41102cf"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,144,193,106,195,48,12,134,207,9,228,29,188,30,138,13,37,47,176,101,23,111,235,114,27,36,219,221,196,106,107,112,237,98,203,133,110,244,221,103,39,241,74,160,236,40,253,250,63,253,210,89,56,226,81,96,240,173,36,13,121,53,168,240,82,111,1,251,203,9,36,183,58,28,205,151,208,1,158,182,65,201,103,186,234,230,225,21,123,172,202,115,116,15,218,250,224,224,69,32,252,15,72,19,189,58,66,132,240,155,103,228,168,29,161,173,159,208,252,32,204,30,36,157,72,140,172,215,36,210,178,250,166,140,208,52,39,30,213,69,128,134,72,216,137,160,145,230,117,140,145,159,170,44,198,168,193,57,48,248,233,193,101,53,70,142,34,23,126,172,190,173,129,119,208,39,112,233,2,110,13,138,1,179,64,147,47,246,12,12,168,172,217,144,101,93,243,27,189,158,173,173,172,123,219,161,83,102,79,89,58,180,72,151,222,139,241,208,16,19,180,158,178,22,243,23,187,148,225,239,129,203,183,109,72,246,214,31,194,121,184,71,157,86,94,171,242,250,11,160,162,40,204,231,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSetCurrentDateTimeMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("94d80b35-c8c5-4fd6-82db-831f96688f19"),
				Name = "SetCurrentDateTime",
				CreatedInSchemaUId = new Guid("08d19c3e-cef5-4a07-9fae-18525efc876b"),
				CreatedInPackageId = new Guid("b11d550e-0087-4f53-ae17-fb00d41102cf"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("0d69681e-dc5b-4633-b7fd-c9e333d52a1c"),
				Name = "dateTimeField",
				CreatedInSchemaUId = new Guid("08d19c3e-cef5-4a07-9fae-18525efc876b"),
				ModifiedInSchemaUId = new Guid("08d19c3e-cef5-4a07-9fae-18525efc876b"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("b11d550e-0087-4f53-ae17-fb00d41102cf")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,79,203,10,194,48,16,60,91,240,31,214,91,2,146,31,208,122,169,207,155,96,245,30,154,85,2,113,35,233,70,80,241,223,109,109,171,20,122,219,217,217,217,153,177,103,16,43,98,203,15,181,65,206,31,55,52,153,119,241,74,39,237,34,206,151,154,49,183,87,92,8,211,78,107,139,206,72,72,83,48,120,214,209,177,232,110,164,132,215,56,25,221,117,128,34,134,128,196,199,18,67,199,66,10,21,153,233,242,139,158,158,112,139,238,134,161,182,205,60,177,46,184,35,68,173,171,118,132,5,91,79,83,232,99,149,253,191,171,86,186,51,42,247,7,14,150,46,66,202,89,229,100,171,98,67,49,38,41,80,116,174,201,58,106,171,31,234,12,191,214,253,174,83,232,180,106,175,67,137,67,95,27,203,247,56,121,127,0,224,56,212,136,80,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetIsStatusWaitingMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("79fcfc12-b8c0-450e-80a4-f2ada75bf5ea"),
				Name = "GetIsStatusWaiting",
				CreatedInSchemaUId = new Guid("08d19c3e-cef5-4a07-9fae-18525efc876b"),
				CreatedInPackageId = new Guid("b11d550e-0087-4f53-ae17-fb00d41102cf"),
				ResultValueTypeName = "bool"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("04b47c30-552b-4d1a-a8fb-6bb8b79472da"),
				Name = "statusId",
				CreatedInSchemaUId = new Guid("08d19c3e-cef5-4a07-9fae-18525efc876b"),
				ModifiedInSchemaUId = new Guid("08d19c3e-cef5-4a07-9fae-18525efc876b"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("b11d550e-0087-4f53-ae17-fb00d41102cf")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,115,47,205,76,81,40,79,204,44,201,204,75,119,203,47,10,74,45,46,200,207,43,78,245,76,81,176,85,112,7,202,233,5,36,22,21,167,106,40,25,91,152,90,58,155,185,154,235,58,59,57,59,233,154,88,152,57,233,58,57,154,26,235,154,155,91,24,88,184,185,154,185,154,90,26,43,105,90,43,112,21,165,150,148,22,229,41,20,151,36,150,148,22,123,166,232,185,22,150,38,230,20,107,96,179,66,211,26,0,141,142,23,141,126,0,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new Case_SLM_TerrasoftEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("08d19c3e-cef5-4a07-9fae-18525efc876b"));
		}

		#endregion

	}

	#endregion

}

