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

	#region Class: Case_CMDB_TerrasoftSchema

	/// <exclude/>
	public class Case_CMDB_TerrasoftSchema : Terrasoft.Configuration.Case_Portal_TerrasoftSchema
	{

		#region Constructors: Public

		public Case_CMDB_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public Case_CMDB_TerrasoftSchema(Case_CMDB_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public Case_CMDB_TerrasoftSchema(Case_CMDB_TerrasoftSchema source)
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
			RealUId = new Guid("a439b26c-6979-4109-baf8-bfe15dccf646");
			Name = "Case_CMDB_Terrasoft";
			ParentSchemaUId = new Guid("117d32f9-8275-4534-8411-1c66115ce9cd");
			ExtendParent = true;
			CreatedInPackageId = new Guid("f903ed7d-efff-4bea-98a9-8ff46e81b434");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("7c5530e9-ca8e-4fa7-b4b1-c88631206e5a")) == null) {
				Columns.Add(CreateConfItemColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateConfItemColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("7c5530e9-ca8e-4fa7-b4b1-c88631206e5a"),
				Name = @"ConfItem",
				ReferenceSchemaUId = new Guid("ad707075-cf25-40bf-85c1-f5da38cf0d5d"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("a439b26c-6979-4109-baf8-bfe15dccf646"),
				ModifiedInSchemaUId = new Guid("a439b26c-6979-4109-baf8-bfe15dccf646"),
				CreatedInPackageId = new Guid("f903ed7d-efff-4bea-98a9-8ff46e81b434")
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
			EventsProcessSchema = CreateCase_CMDB_TerrasoftEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateCase_CMDB_TerrasoftEventsProcessSchema() {
			var schema = new Case_CMDB_TerrasoftEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new Case_CMDB_Terrasoft(userConnection){Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new Case_CMDBEventsProcess(userConnnection);
		}

		public override object Clone() {
			return new Case_CMDB_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new Case_CMDB_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a439b26c-6979-4109-baf8-bfe15dccf646"));
		}

		#endregion

	}

	#endregion

	#region Class: Case_CMDB_Terrasoft

	/// <summary>
	/// Case.
	/// </summary>
	public class Case_CMDB_Terrasoft : Terrasoft.Configuration.Case_Portal_Terrasoft
	{

		#region Constructors: Public

		public Case_CMDB_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Case_CMDB_Terrasoft";
		}

		public Case_CMDB_Terrasoft(Case_CMDB_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid ConfItemId {
			get {
				return GetTypedColumnValue<Guid>("ConfItemId");
			}
			set {
				SetColumnValue("ConfItemId", value);
				_confItem = null;
			}
		}

		/// <exclude/>
		public string ConfItemName {
			get {
				return GetTypedColumnValue<string>("ConfItemName");
			}
			set {
				SetColumnValue("ConfItemName", value);
				if (_confItem != null) {
					_confItem.Name = value;
				}
			}
		}

		private ConfItem _confItem;
		/// <summary>
		/// Configuration item.
		/// </summary>
		public ConfItem ConfItem {
			get {
				return _confItem ??
					(_confItem = LookupColumnEntities.GetEntity("ConfItem") as ConfItem);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new Case_CMDBEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("Case_CMDB_TerrasoftDeleted", e);
			Saved += (s, e) => ThrowEvent("Case_CMDB_TerrasoftSaved", e);
			Validating += (s, e) => ThrowEvent("Case_CMDB_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new Case_CMDB_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: Case_CMDBEventsProcess

	/// <exclude/>
	public class Case_CMDBEventsProcess<TEntity> : Terrasoft.Configuration.Case_PortalEventsProcess<TEntity> where TEntity : Case_CMDB_Terrasoft
	{

		public Case_CMDBEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Case_CMDBEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("a439b26c-6979-4109-baf8-bfe15dccf646");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		public virtual Guid NewConfItemId {
			get;
			set;
		}

		public virtual Guid OldConfItemId {
			get;
			set;
		}

		private ProcessFlowElement _eventSubProcessActualizeConfItems;
		public ProcessFlowElement EventSubProcessActualizeConfItems {
			get {
				return _eventSubProcessActualizeConfItems ?? (_eventSubProcessActualizeConfItems = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcessActualizeConfItems",
					SchemaElementUId = new Guid("800820ad-6447-4406-aaf9-af1d8723226b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessage1CaseSaved;
		public ProcessFlowElement StartMessage1CaseSaved {
			get {
				return _startMessage1CaseSaved ?? (_startMessage1CaseSaved = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessage1CaseSaved",
					SchemaElementUId = new Guid("388e2043-3f5b-48b7-8b6f-65f0298c0812"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _actulizeConfItemsInCaseScriptTask;
		public ProcessScriptTask ActulizeConfItemsInCaseScriptTask {
			get {
				return _actulizeConfItemsInCaseScriptTask ?? (_actulizeConfItemsInCaseScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ActulizeConfItemsInCaseScriptTask",
					SchemaElementUId = new Guid("e3939498-7c63-4e6d-aba2-3ec3520c41d8"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ActulizeConfItemsInCaseScriptTaskExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcessActualizeConfItems.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcessActualizeConfItems };
			FlowElements[StartMessage1CaseSaved.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage1CaseSaved };
			FlowElements[ActulizeConfItemsInCaseScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { ActulizeConfItemsInCaseScriptTask };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcessActualizeConfItems":
						break;
					case "StartMessage1CaseSaved":
						e.Context.QueueTasks.Enqueue("ActulizeConfItemsInCaseScriptTask");
						break;
					case "ActulizeConfItemsInCaseScriptTask":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("StartMessage1CaseSaved");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "EventSubProcessActualizeConfItems":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage1CaseSaved":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage1CaseSaved";
					result = StartMessage1CaseSaved.Execute(context);
					break;
				case "ActulizeConfItemsInCaseScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "ActulizeConfItemsInCaseScriptTask";
					result = ActulizeConfItemsInCaseScriptTask.Execute(context, ActulizeConfItemsInCaseScriptTaskExecute);
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
				case "OldConfItemId":
					OldConfItemId = reader.GetValue<System.Guid>();
				break;
				case "NewConfItemId":
					NewConfItemId = reader.GetValue<System.Guid>();
				break;
			}
		}

		#endregion

		#region Methods: Public

		public virtual bool ActulizeConfItemsInCaseScriptTaskExecute(ProcessExecutingContext context) {
			ActulizeConfItemsInCase();
			return true;
		}

		public override void SetProcessParameters() {
			base.SetProcessParameters();
			NewConfItemId = Entity.GetTypedColumnValue<Guid>("ConfItemId");
			OldConfItemId = Entity.GetTypedOldColumnValue<Guid>("ConfItemId");
		}

		public virtual void ActulizeConfItemsInCase() {
			if (NewConfItemId == OldConfItemId) {
				return;
			}
			var caseId = Entity.PrimaryColumnValue;
			var query = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "ConfItemInCase");
			query.PrimaryQueryColumn.IsAlwaysSelect = true;
			query.AddColumn("Major");
			var confItemColumn = query.AddColumn("ConfItem");
			query.Filters.Add(query.CreateFilterWithParameters(FilterComparisonType.Equal, "Case", caseId));
			var collection = query.GetEntityCollection(UserConnection);
			bool addNewItem = true;
			if (collection.Count > 0) {
				foreach(var entity in collection) {
					var currentConfItem  = entity.GetTypedColumnValue<Guid>(confItemColumn.Name + "Id");
					var isMajor = currentConfItem == NewConfItemId;
					if (isMajor) {
						addNewItem = false;
					}
					entity.SetColumnValue("Major", isMajor);
					entity.Save();
				}
			}
			if (!addNewItem || NewConfItemId == Guid.Empty) {
				return;
			}
			var schema = UserConnection.EntitySchemaManager.FindInstanceByName("ConfItemInCase");
			var сonfItemInCaseEntity = schema.CreateEntity(UserConnection);
			сonfItemInCaseEntity.SetDefColumnValues(); 
			сonfItemInCaseEntity.SetColumnValue("CaseId", caseId); 
			сonfItemInCaseEntity.SetColumnValue("ConfItemId", NewConfItemId);
			сonfItemInCaseEntity.SetColumnValue("Major", true);
			сonfItemInCaseEntity.Save(); 
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "Case_CMDB_TerrasoftSaved":
							if (ActivatedEventElements.Contains("StartMessage1CaseSaved")) {
							context.QueueTasks.Enqueue("StartMessage1CaseSaved");
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
			if (!HasMapping("OldConfItemId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("OldConfItemId", OldConfItemId, Guid.Empty);
			}
			if (!HasMapping("NewConfItemId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("NewConfItemId", NewConfItemId, Guid.Empty);
			}
		}

		public override object CloneShallow() {
			return base.CloneShallow();
		}

		#endregion

	}

	#endregion

	#region Class: Case_CMDBEventsProcess

	/// <exclude/>
	public class Case_CMDBEventsProcess : Case_CMDBEventsProcess<Case_CMDB_Terrasoft>
	{

		public Case_CMDBEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: Case_CMDB_TerrasoftEventsProcessSchema

	/// <exclude/>
	public class Case_CMDB_TerrasoftEventsProcessSchema : Terrasoft.Configuration.Case_Portal_TerrasoftEventsProcessSchema
	{

		#region Constructors: Public

		public Case_CMDB_TerrasoftEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public Case_CMDB_TerrasoftEventsProcessSchema(Case_CMDB_TerrasoftEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "Case_CMDBEventsProcess";
			UId = new Guid("517db3c0-43ad-4fe4-9182-36fac6738039");
			CreatedInPackageId = new Guid("f903ed7d-efff-4bea-98a9-8ff46e81b434");
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

		protected virtual ProcessSchemaParameter CreateNewConfItemIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("b728d780-0802-4055-b763-4a5884449c53"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("517db3c0-43ad-4fe4-9182-36fac6738039"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("517db3c0-43ad-4fe4-9182-36fac6738039"),
				Name = @"NewConfItemId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateOldConfItemIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("7c3b6928-19fd-46af-b7e4-bebf8b5c9e36"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("517db3c0-43ad-4fe4-9182-36fac6738039"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("517db3c0-43ad-4fe4-9182-36fac6738039"),
				Name = @"OldConfItemId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateNewConfItemIdParameter());
			Parameters.Add(CreateOldConfItemIdParameter());
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSetActualizeConfItem = CreateLaneSetActualizeConfItemLaneSet();
			LaneSets.Add(schemaLaneSetActualizeConfItem);
			ProcessSchemaLane schemaActulizeConfItemsInCaseLane = CreateActulizeConfItemsInCaseLaneLane();
			schemaLaneSetActualizeConfItem.Lanes.Add(schemaActulizeConfItemsInCaseLane);
			ProcessSchemaEventSubProcess eventsubprocessactualizeconfitems = CreateEventSubProcessActualizeConfItemsEventSubProcess();
			FlowElements.Add(eventsubprocessactualizeconfitems);
			ProcessSchemaStartMessageEvent startmessage1casesaved = CreateStartMessage1CaseSavedStartMessageEvent();
			eventsubprocessactualizeconfitems.FlowElements.Add(startmessage1casesaved);
			ProcessSchemaScriptTask actulizeconfitemsincasescripttask = CreateActulizeConfItemsInCaseScriptTaskScriptTask();
			eventsubprocessactualizeconfitems.FlowElements.Add(actulizeconfitemsincasescripttask);
			FlowElements.Add(CreateSequenceFlowActualizeConfItemSequenceFlow());
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlowActualizeConfItemSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlowActualizeConfItem",
				UId = new Guid("28d2d4f7-d846-46ff-9c7d-91ee4aa8316f"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("2e4ad2a2-869c-48da-b867-91374c625baa"),
				CreatedInPackageId = new Guid("f903ed7d-efff-4bea-98a9-8ff46e81b434"),
				CreatedInSchemaUId = new Guid("517db3c0-43ad-4fe4-9182-36fac6738039"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("517db3c0-43ad-4fe4-9182-36fac6738039"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("388e2043-3f5b-48b7-8b6f-65f0298c0812"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("e3939498-7c63-4e6d-aba2-3ec3520c41d8"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSetActualizeConfItemLaneSet() {
			ProcessSchemaLaneSet schemaLaneSetActualizeConfItem = new ProcessSchemaLaneSet(this) {
				UId = new Guid("f4b20f4c-e27e-45cd-bdb0-65df1baa0be8"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("2e4ad2a2-869c-48da-b867-91374c625baa"),
				CreatedInPackageId = new Guid("f903ed7d-efff-4bea-98a9-8ff46e81b434"),
				CreatedInSchemaUId = new Guid("517db3c0-43ad-4fe4-9182-36fac6738039"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("517db3c0-43ad-4fe4-9182-36fac6738039"),
				Name = @"LaneSetActualizeConfItem",
				Position = new Point(0, 5),
				Size = new Size(0, 400),
				UseBackgroundMode = false
			};
			return schemaLaneSetActualizeConfItem;
		}

		protected virtual ProcessSchemaLane CreateActulizeConfItemsInCaseLaneLane() {
			ProcessSchemaLane schemaActulizeConfItemsInCaseLane = new ProcessSchemaLane(this) {
				UId = new Guid("37a02908-8c34-4084-b417-3d6c245ad051"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f4b20f4c-e27e-45cd-bdb0-65df1baa0be8"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("f903ed7d-efff-4bea-98a9-8ff46e81b434"),
				CreatedInSchemaUId = new Guid("517db3c0-43ad-4fe4-9182-36fac6738039"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("517db3c0-43ad-4fe4-9182-36fac6738039"),
				Name = @"ActulizeConfItemsInCaseLane",
				Position = new Point(0, 0),
				Size = new Size(700, 400),
				UseBackgroundMode = false
			};
			return schemaActulizeConfItemsInCaseLane;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcessActualizeConfItemsEventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcessActualizeConfItems = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("800820ad-6447-4406-aaf9-af1d8723226b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("37a02908-8c34-4084-b417-3d6c245ad051"),
				CreatedInOwnerSchemaUId = new Guid("2e4ad2a2-869c-48da-b867-91374c625baa"),
				CreatedInPackageId = new Guid("f903ed7d-efff-4bea-98a9-8ff46e81b434"),
				CreatedInSchemaUId = new Guid("517db3c0-43ad-4fe4-9182-36fac6738039"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("517db3c0-43ad-4fe4-9182-36fac6738039"),
				Name = @"EventSubProcessActualizeConfItems",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(60, 260),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(460, 180),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcessActualizeConfItems;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage1CaseSavedStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("388e2043-3f5b-48b7-8b6f-65f0298c0812"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("800820ad-6447-4406-aaf9-af1d8723226b"),
				CreatedInOwnerSchemaUId = new Guid("2e4ad2a2-869c-48da-b867-91374c625baa"),
				CreatedInPackageId = new Guid("f903ed7d-efff-4bea-98a9-8ff46e81b434"),
				CreatedInSchemaUId = new Guid("517db3c0-43ad-4fe4-9182-36fac6738039"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"CaseSaved",
				ModifiedInSchemaUId = new Guid("517db3c0-43ad-4fe4-9182-36fac6738039"),
				Name = @"StartMessage1CaseSaved",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(40, 60),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateActulizeConfItemsInCaseScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("e3939498-7c63-4e6d-aba2-3ec3520c41d8"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("800820ad-6447-4406-aaf9-af1d8723226b"),
				CreatedInOwnerSchemaUId = new Guid("2e4ad2a2-869c-48da-b867-91374c625baa"),
				CreatedInPackageId = new Guid("f903ed7d-efff-4bea-98a9-8ff46e81b434"),
				CreatedInSchemaUId = new Guid("517db3c0-43ad-4fe4-9182-36fac6738039"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("517db3c0-43ad-4fe4-9182-36fac6738039"),
				Name = @"ActulizeConfItemsInCaseScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(271, 46),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,115,76,46,41,205,201,172,74,117,206,207,75,243,44,73,205,45,246,204,115,78,44,78,213,208,180,230,42,74,45,41,45,202,83,40,41,42,77,181,6,0,252,206,220,59,39,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateActulizeConfItemsInCaseMethod());
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("fb7b81ba-7c3c-45a5-ae9e-c6c03dceb812"),
				Name = "Terrasoft.UI.WebControls.Controls",
				Alias = "",
				CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("cde525cf-d220-4d2a-b963-e55254c639fc"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5c9c82c6-ba6d-4a57-9a14-87fe8faa4ebb"),
				Name = "Terrasoft.Core.DB",
				Alias = "",
				CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7821de68-c82b-4917-a6cd-add2adfbe400"),
				Name = "Terrasoft.Common",
				Alias = "",
				CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d67de76f-9cbc-4bfc-babb-6f65cb89b973"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("74160d3b-65e3-4694-b554-089f2d980e54"),
				Name = "Newtonsoft.Json",
				Alias = "",
				CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e401300a-9f16-40c2-9788-cf310ae9d1c5"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485")
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

		protected override SchemaMethod CreateSetProcessParametersMethod() {
			SchemaMethod method = base.CreateSetProcessParametersMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,75,74,44,78,213,11,78,45,9,40,202,79,78,45,46,14,72,44,74,204,77,45,73,45,42,214,208,180,230,242,75,45,119,206,207,75,243,44,73,205,245,76,81,176,85,112,205,43,201,44,169,212,115,79,45,9,169,44,72,77,113,206,207,41,205,205,11,75,204,41,77,181,113,47,205,76,177,211,80,66,40,87,2,234,247,207,73,193,167,31,44,77,192,8,0,200,211,218,135,160,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateActulizeConfItemsInCaseMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("a5e2bc7f-bc84-4198-9ac0-0d769eac9783"),
				Name = "ActulizeConfItemsInCase",
				CreatedInSchemaUId = new Guid("517db3c0-43ad-4fe4-9182-36fac6738039"),
				CreatedInPackageId = new Guid("f903ed7d-efff-4bea-98a9-8ff46e81b434"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,83,203,110,219,48,16,60,219,95,193,248,36,163,134,144,187,155,0,169,234,6,58,228,81,184,77,207,172,184,138,89,80,164,67,82,49,132,198,135,126,98,255,168,187,164,36,75,177,211,246,160,203,106,118,102,118,118,41,75,150,220,194,46,51,186,204,61,84,185,96,23,23,236,78,137,67,97,206,126,78,39,22,124,109,245,114,186,159,62,115,203,10,238,128,144,108,165,189,244,77,122,111,101,197,109,147,25,85,87,250,129,171,26,150,1,247,84,131,109,16,166,97,215,66,215,197,6,42,254,153,234,201,87,7,22,101,52,20,94,26,157,14,1,55,92,243,71,176,11,54,235,125,232,12,69,103,243,229,52,144,118,146,129,41,234,166,185,187,82,59,222,184,53,40,164,68,89,111,201,72,196,95,9,17,97,201,236,134,255,48,150,152,194,40,45,127,252,137,77,71,240,206,193,65,251,147,84,30,172,35,80,18,43,153,5,238,33,214,191,73,191,185,231,150,87,64,160,36,22,51,83,109,185,149,206,232,47,205,22,210,213,83,205,21,77,71,51,45,218,60,231,189,37,165,98,38,189,157,107,240,49,158,172,255,247,42,62,236,253,110,140,98,92,8,92,39,249,237,3,144,184,226,3,103,154,153,90,123,118,201,206,195,98,75,131,214,139,77,66,194,16,36,152,212,3,11,1,52,9,182,106,107,17,209,197,193,144,63,54,144,59,154,74,12,246,255,254,186,150,226,50,25,167,155,222,98,40,236,29,155,229,130,194,140,180,210,133,125,32,219,107,1,60,196,209,101,82,7,205,210,118,68,103,147,209,192,37,87,14,8,183,199,175,117,183,6,63,48,214,173,127,209,9,7,35,29,148,63,67,66,133,61,30,58,73,157,13,216,95,94,216,209,67,161,41,211,85,181,245,205,137,87,226,194,41,163,171,127,31,58,158,148,22,185,118,158,235,2,62,52,148,83,114,226,244,137,245,247,175,81,57,146,161,72,84,107,47,49,86,143,79,228,100,51,37,244,17,202,65,72,14,67,96,111,131,71,113,102,225,118,15,71,252,255,141,125,146,216,60,74,246,111,70,79,174,146,238,252,237,166,184,84,246,7,19,137,4,215,234,4,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new Case_CMDB_TerrasoftEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("517db3c0-43ad-4fe4-9182-36fac6738039"));
		}

		#endregion

	}

	#endregion

}

