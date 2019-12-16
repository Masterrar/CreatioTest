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

	#region Class: Case_Case_TerrasoftSchema

	/// <exclude/>
	public class Case_Case_TerrasoftSchema : Terrasoft.Configuration.BaseCaseSchema
	{

		#region Constructors: Public

		public Case_Case_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public Case_Case_TerrasoftSchema(Case_Case_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public Case_Case_TerrasoftSchema(Case_Case_TerrasoftSchema source)
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
			UId = new Guid("117d32f9-8275-4534-8411-1c66115ce9cd");
			RealUId = new Guid("117d32f9-8275-4534-8411-1c66115ce9cd");
			Name = "Case_Case_Terrasoft";
			ParentSchemaUId = new Guid("7d80c5f8-f594-44e3-b87e-31b7f7432c4c");
			ExtendParent = false;
			CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("a587b494-47f3-4b27-be42-a259e579f061")) == null) {
				Columns.Add(CreateParentCaseColumn());
			}
			if (Columns.FindByUId(new Guid("b59a15ea-751e-4fd8-8281-f1a3dc7190ff")) == null) {
				Columns.Add(CreateParentActivityColumn());
			}
		}

		protected override EntitySchemaColumn CreateNumberColumn() {
			EntitySchemaColumn column = base.CreateNumberColumn();
			column.IsIndexed = true;
			column.ModifiedInSchemaUId = new Guid("117d32f9-8275-4534-8411-1c66115ce9cd");
			return column;
		}

		protected override EntitySchemaColumn CreateStatusColumn() {
			EntitySchemaColumn column = base.CreateStatusColumn();
			column.ModifiedInSchemaUId = new Guid("117d32f9-8275-4534-8411-1c66115ce9cd");
			return column;
		}

		protected override EntitySchemaColumn CreatePriorityColumn() {
			EntitySchemaColumn column = base.CreatePriorityColumn();
			column.ModifiedInSchemaUId = new Guid("117d32f9-8275-4534-8411-1c66115ce9cd");
			return column;
		}

		protected override EntitySchemaColumn CreateOriginColumn() {
			EntitySchemaColumn column = base.CreateOriginColumn();
			column.ModifiedInSchemaUId = new Guid("117d32f9-8275-4534-8411-1c66115ce9cd");
			return column;
		}

		protected override EntitySchemaColumn CreateCategoryColumn() {
			EntitySchemaColumn column = base.CreateCategoryColumn();
			column.ModifiedInSchemaUId = new Guid("117d32f9-8275-4534-8411-1c66115ce9cd");
			return column;
		}

		protected override EntitySchemaColumn CreateSatisfactionLevelCommentColumn() {
			EntitySchemaColumn column = base.CreateSatisfactionLevelCommentColumn();
			column.IsValueCloneable = false;
			column.ModifiedInSchemaUId = new Guid("117d32f9-8275-4534-8411-1c66115ce9cd");
			return column;
		}

		protected virtual EntitySchemaColumn CreateParentCaseColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("a587b494-47f3-4b27-be42-a259e579f061"),
				Name = @"ParentCase",
				ReferenceSchemaUId = new Guid("117d32f9-8275-4534-8411-1c66115ce9cd"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("117d32f9-8275-4534-8411-1c66115ce9cd"),
				ModifiedInSchemaUId = new Guid("117d32f9-8275-4534-8411-1c66115ce9cd"),
				CreatedInPackageId = new Guid("ff020f92-eb95-49ea-a251-6a0ed7e274a5")
			};
		}

		protected virtual EntitySchemaColumn CreateParentActivityColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("b59a15ea-751e-4fd8-8281-f1a3dc7190ff"),
				Name = @"ParentActivity",
				ReferenceSchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("117d32f9-8275-4534-8411-1c66115ce9cd"),
				ModifiedInSchemaUId = new Guid("117d32f9-8275-4534-8411-1c66115ce9cd"),
				CreatedInPackageId = new Guid("c3c90037-274c-4793-841e-197eb228d3cd")
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
			EventsProcessSchema = CreateCase_Case_TerrasoftEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateCase_Case_TerrasoftEventsProcessSchema() {
			var schema = new Case_Case_TerrasoftEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new Case_Case_Terrasoft(userConnection){Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new Case_CaseEventsProcess(userConnnection);
		}

		public override object Clone() {
			return new Case_Case_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new Case_Case_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("117d32f9-8275-4534-8411-1c66115ce9cd"));
		}

		#endregion

	}

	#endregion

	#region Class: Case_Case_Terrasoft

	/// <summary>
	/// Case.
	/// </summary>
	public class Case_Case_Terrasoft : Terrasoft.Configuration.BaseCase
	{

		#region Constructors: Public

		public Case_Case_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Case_Case_Terrasoft";
		}

		public Case_Case_Terrasoft(Case_Case_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid ParentCaseId {
			get {
				return GetTypedColumnValue<Guid>("ParentCaseId");
			}
			set {
				SetColumnValue("ParentCaseId", value);
				_parentCase = null;
			}
		}

		/// <exclude/>
		public string ParentCaseNumber {
			get {
				return GetTypedColumnValue<string>("ParentCaseNumber");
			}
			set {
				SetColumnValue("ParentCaseNumber", value);
				if (_parentCase != null) {
					_parentCase.Number = value;
				}
			}
		}

		private Case _parentCase;
		/// <summary>
		/// Parent case.
		/// </summary>
		public Case ParentCase {
			get {
				return _parentCase ??
					(_parentCase = LookupColumnEntities.GetEntity("ParentCase") as Case);
			}
		}

		/// <exclude/>
		public Guid ParentActivityId {
			get {
				return GetTypedColumnValue<Guid>("ParentActivityId");
			}
			set {
				SetColumnValue("ParentActivityId", value);
				_parentActivity = null;
			}
		}

		/// <exclude/>
		public string ParentActivityTitle {
			get {
				return GetTypedColumnValue<string>("ParentActivityTitle");
			}
			set {
				SetColumnValue("ParentActivityTitle", value);
				if (_parentActivity != null) {
					_parentActivity.Title = value;
				}
			}
		}

		private Activity _parentActivity;
		/// <summary>
		/// Parent activity.
		/// </summary>
		public Activity ParentActivity {
			get {
				return _parentActivity ??
					(_parentActivity = LookupColumnEntities.GetEntity("ParentActivity") as Activity);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new Case_CaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("Case_Case_TerrasoftDeleted", e);
			Deleting += (s, e) => ThrowEvent("Case_Case_TerrasoftDeleting", e);
			Inserting += (s, e) => ThrowEvent("Case_Case_TerrasoftInserting", e);
			Saved += (s, e) => ThrowEvent("Case_Case_TerrasoftSaved", e);
			Saving += (s, e) => ThrowEvent("Case_Case_TerrasoftSaving", e);
			Validating += (s, e) => ThrowEvent("Case_Case_TerrasoftValidating", e);
			DefColumnValuesSet += (s, e) => ThrowEvent("Case_Case_TerrasoftDefColumnValuesSet", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new Case_Case_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: Case_CaseEventsProcess

	/// <exclude/>
	public class Case_CaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseCase_CaseEventsProcess<TEntity> where TEntity : Case_Case_Terrasoft
	{

		#region Class: OldOwnerSynchronizeSubjectRemindingFlowElement

		/// <exclude/>
		public class OldOwnerSynchronizeSubjectRemindingFlowElement : SynchronizeSubjectRemindingUserTask
		{

			public OldOwnerSynchronizeSubjectRemindingFlowElement(UserConnection userConnection, Case_CaseEventsProcess<TEntity> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "OldOwnerSynchronizeSubjectReminding";
				IsLogging = false;
				SchemaElementUId = new Guid("d56b15a9-c6cc-40d1-aace-33874aa8dbab");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		#region Class: NewOwnerSynchronizeSubjectRemindingFlowElement

		/// <exclude/>
		public class NewOwnerSynchronizeSubjectRemindingFlowElement : SynchronizeSubjectRemindingUserTask
		{

			public NewOwnerSynchronizeSubjectRemindingFlowElement(UserConnection userConnection, Case_CaseEventsProcess<TEntity> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "NewOwnerSynchronizeSubjectReminding";
				IsLogging = false;
				SchemaElementUId = new Guid("95526637-cde5-4a0e-bb85-f806fcc8b881");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		#region Class: GenerateNumberUserTaskFlowElement

		/// <exclude/>
		public class GenerateNumberUserTaskFlowElement : GenerateSequenseNumberUserTask
		{

			public GenerateNumberUserTaskFlowElement(UserConnection userConnection, Case_CaseEventsProcess<TEntity> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "GenerateNumberUserTask";
				IsLogging = false;
				SchemaElementUId = new Guid("a12485ee-3852-431a-9e82-0ba099749841");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		public Case_CaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Case_CaseEventsProcess";
			SchemaUId = new Guid("117d32f9-8275-4534-8411-1c66115ce9cd");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("117d32f9-8275-4534-8411-1c66115ce9cd");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		public virtual Guid OldOwnerId {
			get;
			set;
		}

		public virtual Guid NewOwnerId {
			get;
			set;
		}

		public virtual bool IsNeedSendRemind {
			get;
			set;
		}

		public virtual bool SendToOldOwner {
			get;
			set;
		}

		public virtual bool SendToNewOwner {
			get;
			set;
		}

		private ProcessFlowElement _eventSubProcess1;
		public ProcessFlowElement EventSubProcess1 {
			get {
				return _eventSubProcess1 ?? (_eventSubProcess1 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess1",
					SchemaElementUId = new Guid("e9dc6350-b621-40d0-971c-27b294f57e3b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessage1;
		public ProcessFlowElement StartMessage1 {
			get {
				return _startMessage1 ?? (_startMessage1 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessage1",
					SchemaElementUId = new Guid("e46e3222-04fa-4aee-b53f-4c8ba8116818"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _oldScriptPrepareSynchronizeRemindings;
		public ProcessScriptTask OldScriptPrepareSynchronizeRemindings {
			get {
				return _oldScriptPrepareSynchronizeRemindings ?? (_oldScriptPrepareSynchronizeRemindings = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "OldScriptPrepareSynchronizeRemindings",
					SchemaElementUId = new Guid("1ff4178d-b591-4f0d-a302-073fe18b95a3"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = OldScriptPrepareSynchronizeRemindingsExecute,
				});
			}
		}

		private OldOwnerSynchronizeSubjectRemindingFlowElement _oldOwnerSynchronizeSubjectReminding;
		public OldOwnerSynchronizeSubjectRemindingFlowElement OldOwnerSynchronizeSubjectReminding {
			get {
				return _oldOwnerSynchronizeSubjectReminding ?? (_oldOwnerSynchronizeSubjectReminding = new OldOwnerSynchronizeSubjectRemindingFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessInclusiveGateway _inclusiveGateway1;
		public ProcessInclusiveGateway InclusiveGateway1 {
			get {
				return _inclusiveGateway1 ?? (_inclusiveGateway1 = new ProcessInclusiveGateway() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaInclusiveGateway",
					Name = "InclusiveGateway1",
					SchemaElementUId = new Guid("9e5c2e36-2fa2-407a-8905-d8f0e4135dcb"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Question = new LocalizableString(Storage, Schema.GetResourceManagerName(),
					"EventsProcessSchema.BaseElements.InclusiveGateway1.Question"),
						IsDecisionRequired = false,
						BranchingMode = GatewayBranchingMode.Auto,
						DecisionMode = GetewayDecisionSelectionMode.Single,
						ShowUserDecisionDialog = (processId, gatewayName) => {},
				});
			}
		}

		private NewOwnerSynchronizeSubjectRemindingFlowElement _newOwnerSynchronizeSubjectReminding;
		public NewOwnerSynchronizeSubjectRemindingFlowElement NewOwnerSynchronizeSubjectReminding {
			get {
				return _newOwnerSynchronizeSubjectReminding ?? (_newOwnerSynchronizeSubjectReminding = new NewOwnerSynchronizeSubjectRemindingFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessScriptTask _newScriptPrepareSynchronizeRemindings;
		public ProcessScriptTask NewScriptPrepareSynchronizeRemindings {
			get {
				return _newScriptPrepareSynchronizeRemindings ?? (_newScriptPrepareSynchronizeRemindings = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "NewScriptPrepareSynchronizeRemindings",
					SchemaElementUId = new Guid("10307809-1e7d-4af7-b2db-4ce4e948355e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = NewScriptPrepareSynchronizeRemindingsExecute,
				});
			}
		}

		private ProcessThrowMessageEvent _intermediateThrowMessageEvent4;
		public ProcessThrowMessageEvent IntermediateThrowMessageEvent4 {
			get {
				return _intermediateThrowMessageEvent4 ?? (_intermediateThrowMessageEvent4 = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "IntermediateThrowMessageEvent4",
					SchemaElementUId = new Guid("de7d5aff-ef1e-4de2-bbea-1aca03bebcd8"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "SynchronizeRemindings",
				});
			}
		}

		private ProcessFlowElement _startMessage4;
		public ProcessFlowElement StartMessage4 {
			get {
				return _startMessage4 ?? (_startMessage4 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessage4",
					SchemaElementUId = new Guid("39414ca4-8f12-4a14-9f96-55552793d9a5"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _emptyScriptTask;
		public ProcessScriptTask EmptyScriptTask {
			get {
				return _emptyScriptTask ?? (_emptyScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "EmptyScriptTask",
					SchemaElementUId = new Guid("db4aa9ae-1774-459b-b980-2fa818185cba"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = EmptyScriptTaskExecute,
				});
			}
		}

		private ProcessExclusiveGateway _exclusiveGateway1;
		public ProcessExclusiveGateway ExclusiveGateway1 {
			get {
				return _exclusiveGateway1 ?? (_exclusiveGateway1 = new ProcessExclusiveGateway() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaExclusiveGateway",
					Name = "ExclusiveGateway1",
					SchemaElementUId = new Guid("25b3a2b3-1b9d-4e6b-a42a-d73683447b25"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Question = new LocalizableString(Storage, Schema.GetResourceManagerName(),
					"EventsProcessSchema.BaseElements.ExclusiveGateway1.Question"),
						IsDecisionRequired = false,
						BranchingMode = GatewayBranchingMode.Auto,
						DecisionMode = GetewayDecisionSelectionMode.Single,
						ShowUserDecisionDialog = (processId, gatewayName) => {},
				});
			}
		}

		private ProcessFlowElement _startMessage5;
		public ProcessFlowElement StartMessage5 {
			get {
				return _startMessage5 ?? (_startMessage5 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessage5",
					SchemaElementUId = new Guid("b02d6fc6-2f15-4205-8852-288ad6387947"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _caseValidatingScriptTask;
		public ProcessScriptTask CaseValidatingScriptTask {
			get {
				return _caseValidatingScriptTask ?? (_caseValidatingScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "CaseValidatingScriptTask",
					SchemaElementUId = new Guid("3c19423a-d705-48e0-a38a-f6859ba5b636"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = CaseValidatingScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcess2;
		public ProcessFlowElement EventSubProcess2 {
			get {
				return _eventSubProcess2 ?? (_eventSubProcess2 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess2",
					SchemaElementUId = new Guid("c60cd728-87a7-4489-bcc4-1662b51c8f74"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessage2;
		public ProcessFlowElement StartMessage2 {
			get {
				return _startMessage2 ?? (_startMessage2 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessage2",
					SchemaElementUId = new Guid("575fdd36-3e2c-4ccc-91e0-965fec1451d4"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessage3;
		public ProcessFlowElement StartMessage3 {
			get {
				return _startMessage3 ?? (_startMessage3 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessage3",
					SchemaElementUId = new Guid("b089b5d0-c1c7-462d-b3b4-22378f8cfce8"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _caseSavingScriptTask;
		public ProcessScriptTask CaseSavingScriptTask {
			get {
				return _caseSavingScriptTask ?? (_caseSavingScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "CaseSavingScriptTask",
					SchemaElementUId = new Guid("b3f7a8a0-9776-4556-97ae-b15ebe58306e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = CaseSavingScriptTaskExecute,
				});
			}
		}

		private ProcessThrowMessageEvent _intermediateThrowMessageEvent5;
		public ProcessThrowMessageEvent IntermediateThrowMessageEvent5 {
			get {
				return _intermediateThrowMessageEvent5 ?? (_intermediateThrowMessageEvent5 = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "IntermediateThrowMessageEvent5",
					SchemaElementUId = new Guid("f0926220-9df1-41a6-89a5-0212529dd0e8"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "SynchronizeRemindings",
				});
			}
		}

		private ProcessScriptTask _setProcessParametersScriptTask;
		public ProcessScriptTask SetProcessParametersScriptTask {
			get {
				return _setProcessParametersScriptTask ?? (_setProcessParametersScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "SetProcessParametersScriptTask",
					SchemaElementUId = new Guid("7d1ffbbc-421d-4b33-99c0-2c3e68e755ff"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = SetProcessParametersScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcess3;
		public ProcessFlowElement EventSubProcess3 {
			get {
				return _eventSubProcess3 ?? (_eventSubProcess3 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess3",
					SchemaElementUId = new Guid("d17bc44d-05ce-41a4-b6db-f9e9eccea1cd"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _caseInsertingStartMessage;
		public ProcessFlowElement CaseInsertingStartMessage {
			get {
				return _caseInsertingStartMessage ?? (_caseInsertingStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "CaseInsertingStartMessage",
					SchemaElementUId = new Guid("b98917cf-2f76-4258-b9b8-d955cfd80800"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessExclusiveGateway _needGenerateExclusiveGateway;
		public ProcessExclusiveGateway NeedGenerateExclusiveGateway {
			get {
				return _needGenerateExclusiveGateway ?? (_needGenerateExclusiveGateway = new ProcessExclusiveGateway() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaExclusiveGateway",
					Name = "NeedGenerateExclusiveGateway",
					SchemaElementUId = new Guid("d220fa56-b3b1-4e4e-af86-7af24cfe9041"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Question = new LocalizableString(Storage, Schema.GetResourceManagerName(),
					"EventsProcessSchema.BaseElements.NeedGenerateExclusiveGateway.Question"),
						IsDecisionRequired = false,
						BranchingMode = GatewayBranchingMode.Auto,
						DecisionMode = GetewayDecisionSelectionMode.Single,
						ShowUserDecisionDialog = (processId, gatewayName) => {},
				});
			}
		}

		private ProcessExclusiveGateway _exclusiveGateway2;
		public ProcessExclusiveGateway ExclusiveGateway2 {
			get {
				return _exclusiveGateway2 ?? (_exclusiveGateway2 = new ProcessExclusiveGateway() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaExclusiveGateway",
					Name = "ExclusiveGateway2",
					SchemaElementUId = new Guid("f99ca610-4bc6-4ea5-814c-68852f20e20b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Question = new LocalizableString(Storage, Schema.GetResourceManagerName(),
					"EventsProcessSchema.BaseElements.ExclusiveGateway2.Question"),
						IsDecisionRequired = false,
						BranchingMode = GatewayBranchingMode.Auto,
						DecisionMode = GetewayDecisionSelectionMode.Single,
						ShowUserDecisionDialog = (processId, gatewayName) => {},
				});
			}
		}

		private ProcessScriptTask _setNumberScriptTask;
		public ProcessScriptTask SetNumberScriptTask {
			get {
				return _setNumberScriptTask ?? (_setNumberScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "SetNumberScriptTask",
					SchemaElementUId = new Guid("c87893b2-1b9c-4691-a509-d3f6f9e5631f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = SetNumberScriptTaskExecute,
				});
			}
		}

		private ProcessScriptTask _setGeneratedNumberScript;
		public ProcessScriptTask SetGeneratedNumberScript {
			get {
				return _setGeneratedNumberScript ?? (_setGeneratedNumberScript = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "SetGeneratedNumberScript",
					SchemaElementUId = new Guid("3f9056e8-5ead-4880-bd13-c030019ec8f8"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = SetGeneratedNumberScriptExecute,
				});
			}
		}

		private GenerateNumberUserTaskFlowElement _generateNumberUserTask;
		public GenerateNumberUserTaskFlowElement GenerateNumberUserTask {
			get {
				return _generateNumberUserTask ?? (_generateNumberUserTask = new GenerateNumberUserTaskFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessScriptTask _setPortalNumberScriptTask;
		public ProcessScriptTask SetPortalNumberScriptTask {
			get {
				return _setPortalNumberScriptTask ?? (_setPortalNumberScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "SetPortalNumberScriptTask",
					SchemaElementUId = new Guid("b98e3401-639c-4df5-a402-4214ccb8edbe"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = SetPortalNumberScriptTaskExecute,
				});
			}
		}

		private ProcessTerminateEvent _terminate1;
		public ProcessTerminateEvent Terminate1 {
			get {
				return _terminate1 ?? (_terminate1 = new ProcessTerminateEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaTerminateEvent",
					Name = "Terminate1",
					SchemaElementUId = new Guid("4886fa94-41d9-4422-bd9c-a271ab80a0b2"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _setSymptomsScriptTask;
		public ProcessScriptTask SetSymptomsScriptTask {
			get {
				return _setSymptomsScriptTask ?? (_setSymptomsScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "SetSymptomsScriptTask",
					SchemaElementUId = new Guid("f233228e-9fb3-4a6a-8328-765813405eda"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = SetSymptomsScriptTaskExecute,
				});
			}
		}

		private ProcessConditionalFlow _conditionalFlow1;
		public ProcessConditionalFlow ConditionalFlow1 {
			get {
				return _conditionalFlow1 ?? (_conditionalFlow1 = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ConditionalFlow1",
					SchemaElementUId = new Guid("109bded3-a3b0-4a70-b267-436bb84135b9"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private ProcessConditionalFlow _conditionalFlow2;
		public ProcessConditionalFlow ConditionalFlow2 {
			get {
				return _conditionalFlow2 ?? (_conditionalFlow2 = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ConditionalFlow2",
					SchemaElementUId = new Guid("681e6224-86ca-4074-b5cd-ea90d495e5dd"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private ProcessConditionalFlow _conditionalFlow3;
		public ProcessConditionalFlow ConditionalFlow3 {
			get {
				return _conditionalFlow3 ?? (_conditionalFlow3 = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ConditionalFlow3",
					SchemaElementUId = new Guid("c6de67fa-22af-471e-9325-1ba18a90c9ab"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private ProcessConditionalFlow _conditionalFlow4;
		public ProcessConditionalFlow ConditionalFlow4 {
			get {
				return _conditionalFlow4 ?? (_conditionalFlow4 = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ConditionalFlow4",
					SchemaElementUId = new Guid("fab3c8e7-86fb-45c5-a0f1-18da3ef32360"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private ProcessConditionalFlow _conditionalFlow5;
		public ProcessConditionalFlow ConditionalFlow5 {
			get {
				return _conditionalFlow5 ?? (_conditionalFlow5 = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ConditionalFlow5",
					SchemaElementUId = new Guid("96f257c1-5a8d-4255-9ca8-255f97f700d5"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private LocalizableString _serviceRequestName;
		public LocalizableString ServiceRequestName {
			get {
				return _serviceRequestName ?? (_serviceRequestName = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.ServiceRequestName.Value"));
			}
		}

		private LocalizableString _newOwnerCaption;
		public LocalizableString NewOwnerCaption {
			get {
				return _newOwnerCaption ?? (_newOwnerCaption = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.NewOwnerCaption.Value"));
			}
		}

		private LocalizableString _newOwnerMessage;
		public LocalizableString NewOwnerMessage {
			get {
				return _newOwnerMessage ?? (_newOwnerMessage = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.NewOwnerMessage.Value"));
			}
		}

		private LocalizableString _oldOwnerCaption;
		public LocalizableString OldOwnerCaption {
			get {
				return _oldOwnerCaption ?? (_oldOwnerCaption = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.OldOwnerCaption.Value"));
			}
		}

		private LocalizableString _oldOwnerMessage;
		public LocalizableString OldOwnerMessage {
			get {
				return _oldOwnerMessage ?? (_oldOwnerMessage = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.OldOwnerMessage.Value"));
			}
		}

		private LocalizableString _subjectByString;
		public LocalizableString SubjectByString {
			get {
				return _subjectByString ?? (_subjectByString = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.SubjectByString.Value"));
			}
		}

		private LocalizableString _subjectForString;
		public LocalizableString SubjectForString {
			get {
				return _subjectForString ?? (_subjectForString = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.SubjectForString.Value"));
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess1.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess1 };
			FlowElements[StartMessage1.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage1 };
			FlowElements[OldScriptPrepareSynchronizeRemindings.SchemaElementUId] = new Collection<ProcessFlowElement> { OldScriptPrepareSynchronizeRemindings };
			FlowElements[OldOwnerSynchronizeSubjectReminding.SchemaElementUId] = new Collection<ProcessFlowElement> { OldOwnerSynchronizeSubjectReminding };
			FlowElements[InclusiveGateway1.SchemaElementUId] = new Collection<ProcessFlowElement> { InclusiveGateway1 };
			FlowElements[NewOwnerSynchronizeSubjectReminding.SchemaElementUId] = new Collection<ProcessFlowElement> { NewOwnerSynchronizeSubjectReminding };
			FlowElements[NewScriptPrepareSynchronizeRemindings.SchemaElementUId] = new Collection<ProcessFlowElement> { NewScriptPrepareSynchronizeRemindings };
			FlowElements[IntermediateThrowMessageEvent4.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowMessageEvent4 };
			FlowElements[StartMessage4.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage4 };
			FlowElements[EmptyScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { EmptyScriptTask };
			FlowElements[ExclusiveGateway1.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway1 };
			FlowElements[StartMessage5.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage5 };
			FlowElements[CaseValidatingScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { CaseValidatingScriptTask };
			FlowElements[EventSubProcess2.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess2 };
			FlowElements[StartMessage2.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage2 };
			FlowElements[StartMessage3.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage3 };
			FlowElements[CaseSavingScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { CaseSavingScriptTask };
			FlowElements[IntermediateThrowMessageEvent5.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowMessageEvent5 };
			FlowElements[SetProcessParametersScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { SetProcessParametersScriptTask };
			FlowElements[EventSubProcess3.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess3 };
			FlowElements[CaseInsertingStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { CaseInsertingStartMessage };
			FlowElements[NeedGenerateExclusiveGateway.SchemaElementUId] = new Collection<ProcessFlowElement> { NeedGenerateExclusiveGateway };
			FlowElements[ExclusiveGateway2.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway2 };
			FlowElements[SetNumberScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { SetNumberScriptTask };
			FlowElements[SetGeneratedNumberScript.SchemaElementUId] = new Collection<ProcessFlowElement> { SetGeneratedNumberScript };
			FlowElements[GenerateNumberUserTask.SchemaElementUId] = new Collection<ProcessFlowElement> { GenerateNumberUserTask };
			FlowElements[SetPortalNumberScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { SetPortalNumberScriptTask };
			FlowElements[Terminate1.SchemaElementUId] = new Collection<ProcessFlowElement> { Terminate1 };
			FlowElements[SetSymptomsScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { SetSymptomsScriptTask };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess1":
						break;
					case "StartMessage1":
						e.Context.QueueTasks.Enqueue("IntermediateThrowMessageEvent4");
						break;
					case "OldScriptPrepareSynchronizeRemindings":
						e.Context.QueueTasks.Enqueue("OldOwnerSynchronizeSubjectReminding");
						break;
					case "OldOwnerSynchronizeSubjectReminding":
							e.Context.QueueTasks.Enqueue("EmptyScriptTask");
						break;
					case "InclusiveGateway1":
						bool isInclusiveGateway1ConditionsEvulateted = false;
						if (ConditionalFlow2ExpressionExecute()) {
							e.Context.QueueTasks.Enqueue("OldScriptPrepareSynchronizeRemindings");
							isInclusiveGateway1ConditionsEvulateted = true;
						} 
						if (ConditionalFlow3ExpressionExecute()) {
							e.Context.QueueTasks.Enqueue("NewScriptPrepareSynchronizeRemindings");
							isInclusiveGateway1ConditionsEvulateted = true;
						} 
						if (!isInclusiveGateway1ConditionsEvulateted) {
							e.Context.QueueTasks.Enqueue("EmptyScriptTask");
						} 
						break;
					case "NewOwnerSynchronizeSubjectReminding":
							e.Context.QueueTasks.Enqueue("EmptyScriptTask");
						break;
					case "NewScriptPrepareSynchronizeRemindings":
						e.Context.QueueTasks.Enqueue("NewOwnerSynchronizeSubjectReminding");
						break;
					case "IntermediateThrowMessageEvent4":
						break;
					case "StartMessage4":
						e.Context.QueueTasks.Enqueue("ExclusiveGateway1");
						break;
					case "EmptyScriptTask":
						break;
					case "ExclusiveGateway1":
						if (ConditionalFlow1ExpressionExecute()) {
							e.Context.QueueTasks.Enqueue("InclusiveGateway1");
							break;
						}
						e.Context.QueueTasks.Enqueue("EmptyScriptTask");
						break;
					case "StartMessage5":
						e.Context.QueueTasks.Enqueue("CaseValidatingScriptTask");
						break;
					case "CaseValidatingScriptTask":
						break;
					case "EventSubProcess2":
						break;
					case "StartMessage2":
						e.Context.QueueTasks.Enqueue("SetProcessParametersScriptTask");
						break;
					case "StartMessage3":
						e.Context.QueueTasks.Enqueue("CaseSavingScriptTask");
						break;
					case "CaseSavingScriptTask":
						break;
					case "IntermediateThrowMessageEvent5":
						break;
					case "SetProcessParametersScriptTask":
						e.Context.QueueTasks.Enqueue("IntermediateThrowMessageEvent5");
						break;
					case "EventSubProcess3":
						break;
					case "CaseInsertingStartMessage":
						e.Context.QueueTasks.Enqueue("SetSymptomsScriptTask");
						break;
					case "NeedGenerateExclusiveGateway":
						if (ConditionalFlow4ExpressionExecute()) {
							e.Context.QueueTasks.Enqueue("ExclusiveGateway2");
							break;
						}
						e.Context.QueueTasks.Enqueue("Terminate1");
						break;
					case "ExclusiveGateway2":
						if (ConditionalFlow5ExpressionExecute()) {
							e.Context.QueueTasks.Enqueue("SetNumberScriptTask");
							break;
						}
						e.Context.QueueTasks.Enqueue("SetPortalNumberScriptTask");
						break;
					case "SetNumberScriptTask":
						e.Context.QueueTasks.Enqueue("GenerateNumberUserTask");
						break;
					case "SetGeneratedNumberScript":
						break;
					case "GenerateNumberUserTask":
							e.Context.QueueTasks.Enqueue("SetGeneratedNumberScript");
						break;
					case "SetPortalNumberScriptTask":
						break;
					case "Terminate1":
						break;
					case "SetSymptomsScriptTask":
						e.Context.QueueTasks.Enqueue("NeedGenerateExclusiveGateway");
						break;
			}
			ProcessQueue(e.Context);
		}

		private bool ConditionalFlow1ExpressionExecute() {
			return Convert.ToBoolean(IsNeedSendRemind || Entity.IsInDeleting);
		}

		private bool ConditionalFlow2ExpressionExecute() {
			return Convert.ToBoolean(UserConnection.CurrentUser.ConnectionType != UserType.SSP && (SendToOldOwner || Entity.IsInDeleting));
		}

		private bool ConditionalFlow3ExpressionExecute() {
			return Convert.ToBoolean(SendToNewOwner || Entity.IsInDeleting);
		}

		private bool ConditionalFlow4ExpressionExecute() {
			return Convert.ToBoolean(string.IsNullOrEmpty(Entity.GetTypedColumnValue<string>("Number")));
		}

		private bool ConditionalFlow5ExpressionExecute() {
			return Convert.ToBoolean(UserConnection.CurrentUser.ConnectionType != UserType.SSP);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("StartMessage1");
			ActivatedEventElements.Add("StartMessage4");
			ActivatedEventElements.Add("StartMessage5");
			ActivatedEventElements.Add("StartMessage2");
			ActivatedEventElements.Add("StartMessage3");
			ActivatedEventElements.Add("CaseInsertingStartMessage");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "EventSubProcess1":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage1":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage1";
					result = StartMessage1.Execute(context);
					break;
				case "OldScriptPrepareSynchronizeRemindings":
					context.QueueTasks.Dequeue();
					context.SenderName = "OldScriptPrepareSynchronizeRemindings";
					result = OldScriptPrepareSynchronizeRemindings.Execute(context, OldScriptPrepareSynchronizeRemindingsExecute);
					break;
				case "OldOwnerSynchronizeSubjectReminding":
					context.QueueTasks.Dequeue();
					context.SenderName = "OldOwnerSynchronizeSubjectReminding";
					result = OldOwnerSynchronizeSubjectReminding.Execute(context);
					break;
				case "InclusiveGateway1":
					context.QueueTasks.Dequeue();
					context.SenderName = "InclusiveGateway1";
					result = InclusiveGateway1.Execute(context);
					break;
				case "NewOwnerSynchronizeSubjectReminding":
					context.QueueTasks.Dequeue();
					context.SenderName = "NewOwnerSynchronizeSubjectReminding";
					result = NewOwnerSynchronizeSubjectReminding.Execute(context);
					break;
				case "NewScriptPrepareSynchronizeRemindings":
					context.QueueTasks.Dequeue();
					context.SenderName = "NewScriptPrepareSynchronizeRemindings";
					result = NewScriptPrepareSynchronizeRemindings.Execute(context, NewScriptPrepareSynchronizeRemindingsExecute);
					break;
				case "IntermediateThrowMessageEvent4":
					context.QueueTasks.Dequeue();
					result = IntermediateThrowMessageEvent4.Execute(context);
					break;
				case "StartMessage4":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage4";
					result = StartMessage4.Execute(context);
					break;
				case "EmptyScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "EmptyScriptTask";
					result = EmptyScriptTask.Execute(context, EmptyScriptTaskExecute);
					break;
				case "ExclusiveGateway1":
					context.QueueTasks.Dequeue();
					context.SenderName = "ExclusiveGateway1";
					result = ExclusiveGateway1.Execute(context);
					break;
				case "StartMessage5":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage5";
					result = StartMessage5.Execute(context);
					break;
				case "CaseValidatingScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "CaseValidatingScriptTask";
					result = CaseValidatingScriptTask.Execute(context, CaseValidatingScriptTaskExecute);
					break;
				case "EventSubProcess2":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage2":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage2";
					result = StartMessage2.Execute(context);
					break;
				case "StartMessage3":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage3";
					result = StartMessage3.Execute(context);
					break;
				case "CaseSavingScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "CaseSavingScriptTask";
					result = CaseSavingScriptTask.Execute(context, CaseSavingScriptTaskExecute);
					break;
				case "IntermediateThrowMessageEvent5":
					context.QueueTasks.Dequeue();
					result = IntermediateThrowMessageEvent5.Execute(context);
					break;
				case "SetProcessParametersScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "SetProcessParametersScriptTask";
					result = SetProcessParametersScriptTask.Execute(context, SetProcessParametersScriptTaskExecute);
					break;
				case "EventSubProcess3":
					context.QueueTasks.Dequeue();
					break;
				case "CaseInsertingStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "CaseInsertingStartMessage";
					result = CaseInsertingStartMessage.Execute(context);
					break;
				case "NeedGenerateExclusiveGateway":
					context.QueueTasks.Dequeue();
					context.SenderName = "NeedGenerateExclusiveGateway";
					result = NeedGenerateExclusiveGateway.Execute(context);
					break;
				case "ExclusiveGateway2":
					context.QueueTasks.Dequeue();
					context.SenderName = "ExclusiveGateway2";
					result = ExclusiveGateway2.Execute(context);
					break;
				case "SetNumberScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "SetNumberScriptTask";
					result = SetNumberScriptTask.Execute(context, SetNumberScriptTaskExecute);
					break;
				case "SetGeneratedNumberScript":
					context.QueueTasks.Dequeue();
					context.SenderName = "SetGeneratedNumberScript";
					result = SetGeneratedNumberScript.Execute(context, SetGeneratedNumberScriptExecute);
					break;
				case "GenerateNumberUserTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "GenerateNumberUserTask";
					result = GenerateNumberUserTask.Execute(context);
					break;
				case "SetPortalNumberScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "SetPortalNumberScriptTask";
					result = SetPortalNumberScriptTask.Execute(context, SetPortalNumberScriptTaskExecute);
					break;
				case "Terminate1":
					context.QueueTasks.Dequeue();
					break;
				case "SetSymptomsScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "SetSymptomsScriptTask";
					result = SetSymptomsScriptTask.Execute(context, SetSymptomsScriptTaskExecute);
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
				case "SendToNewOwner":
					SendToNewOwner = reader.GetValue<System.Boolean>();
				break;
				case "SendToOldOwner":
					SendToOldOwner = reader.GetValue<System.Boolean>();
				break;
				case "IsNeedSendRemind":
					IsNeedSendRemind = reader.GetValue<System.Boolean>();
				break;
				case "NewOwnerId":
					NewOwnerId = reader.GetValue<System.Guid>();
				break;
				case "OldOwnerId":
					OldOwnerId = reader.GetValue<System.Guid>();
				break;
			}
		}

		#endregion

		#region Methods: Public

		public virtual bool OldScriptPrepareSynchronizeRemindingsExecute(ProcessExecutingContext context) {
			OldOwnerSynchronizeSubjectReminding.IsSubjectDelete = Entity.IsInDeleting;
			OldOwnerSynchronizeSubjectReminding.IsListSubjectReminds = true;
			OldOwnerSynchronizeSubjectReminding.TypeCaption = string.Format(ServiceRequestName, Entity.GetTypedColumnValue<string>("Number"));
			OldOwnerSynchronizeSubjectReminding.Active = !Entity.IsInDeleting;
			OldOwnerSynchronizeSubjectReminding.SubjectPrimaryColumnValue = Entity.GetTypedColumnValue<Guid>("Id");
			OldOwnerSynchronizeSubjectReminding.Contact = OldOwnerId;
			OldOwnerSynchronizeSubjectReminding.Source = RemindingConsts.RemindingSourceOwnerId;
			OldOwnerSynchronizeSubjectReminding.RemindTime = UserConnection.CurrentUser.GetCurrentDateTime();
			OldOwnerSynchronizeSubjectReminding.SysEntitySchema = Entity.Schema.UId;
			OldOwnerSynchronizeSubjectReminding.SubjectCaption = string.Format(OldOwnerMessage, 
				Entity.GetTypedColumnValue<string>("Number"), Entity.GetTypedColumnValue<string>("Subject"));
			OldOwnerSynchronizeSubjectReminding.NotificationType = CaseConsts.NotificationTypeNotificationId;
			return true;
		}

		public virtual bool NewScriptPrepareSynchronizeRemindingsExecute(ProcessExecutingContext context) {
			NewOwnerSynchronizeSubjectReminding.IsSubjectDelete = Entity.IsInDeleting;
			NewOwnerSynchronizeSubjectReminding.IsListSubjectReminds = true;
			NewOwnerSynchronizeSubjectReminding.TypeCaption = string.Format(ServiceRequestName, Entity.GetTypedColumnValue<string>("Number"));
			NewOwnerSynchronizeSubjectReminding.Active = !Entity.IsInDeleting;
			NewOwnerSynchronizeSubjectReminding.SubjectPrimaryColumnValue = Entity.GetTypedColumnValue<Guid>("Id");
			NewOwnerSynchronizeSubjectReminding.Contact = NewOwnerId;
			NewOwnerSynchronizeSubjectReminding.Source = RemindingConsts.RemindingSourceOwnerId;
			NewOwnerSynchronizeSubjectReminding.RemindTime = UserConnection.CurrentUser.GetCurrentDateTime();
			NewOwnerSynchronizeSubjectReminding.SysEntitySchema = Entity.Schema.UId;
			NewOwnerSynchronizeSubjectReminding.SubjectCaption = string.Format(NewOwnerMessage, 
				Entity.GetTypedColumnValue<string>("Number"), Entity.GetTypedColumnValue<string>("Subject"));
			NewOwnerSynchronizeSubjectReminding.NotificationType = CaseConsts.NotificationTypeNotificationId;
			return true;
		}

		public virtual bool EmptyScriptTaskExecute(ProcessExecutingContext context) {
			return true;
		}

		public virtual bool CaseValidatingScriptTaskExecute(ProcessExecutingContext context) {
			if (Entity.GetChangedColumnValues().Any(c =>
					((c.Name == "SatisfactionLevelId" && c.OldValue != c.Value) 
					|| (c.Name == "SatisfactionLevelComment" 
					&& !(String.IsNullOrEmpty(c.OldValue as string) && String.IsNullOrEmpty(c.Value as string)))))) {
				if(!UserConnection.DBSecurityEngine.GetCanExecuteOperation("CanChangeCaseSatisfactionLevel")) {
					string validationMessageText = new LocalizableString(UserConnection.Workspace.ResourceStorage,
						"CasePage", "LocalizableStrings.SatisfactionLevelTip.Value");
					Entity.ValidationMessages.Add(
						new EntityValidationMessage {
							Text = validationMessageText
						});
					return false;
				}
			}
			return true;
		}

		public virtual bool CaseSavingScriptTaskExecute(ProcessExecutingContext context) {
			SetProcessParameters();
			if(IsStatusChanged(Entity) && UserConnection.GetIsFeatureEnabled("CaseRuleApplier")) {
				CaseRuleApplier ruleApplier = new CaseRuleApplier(UserConnection);
				ruleApplier.Execute(Entity);
			}
			return true;
		}

		public virtual bool SetProcessParametersScriptTaskExecute(ProcessExecutingContext context) {
			SetProcessParameters();
			return true;
		}

		public virtual bool SetNumberScriptTaskExecute(ProcessExecutingContext context) {
			Entity.Schema.Name = "Case";
			GenerateNumberUserTask.EntitySchema = Entity.Schema;
			return true;
		}

		public virtual bool SetGeneratedNumberScriptExecute(ProcessExecutingContext context) {
			string code = string.Empty;
			code = GenerateNumberUserTask.ResultCode;
			if(!string.IsNullOrEmpty(code)) {
				Entity.SetColumnValue("Number", code);
			}
			return true;
		}

		public virtual bool SetPortalNumberScriptTaskExecute(ProcessExecutingContext context) {
			Entity.Schema.Name = "Case";
			string code = string.Empty;
			var systemUserConnection = UserConnection.AppConnection.SystemUserConnection;
			var generateNumberUserTask = 
				new Terrasoft.Core.Process.Configuration.GenerateSequenseNumberUserTask(systemUserConnection);
			generateNumberUserTask.EntitySchema = Entity.Schema;
			generateNumberUserTask.UId = Guid.NewGuid();
			generateNumberUserTask.Owner = this;
			generateNumberUserTask.Name = "SetPortalNumberScriptTaskExecute";
			code = generateNumberUserTask.GenerateSequenseNumber(Entity.Schema, systemUserConnection);
			if(!string.IsNullOrEmpty(code)) {
				Entity.SetColumnValue("Number", code);
			}
			SetPortalCaseSubject();
			return true;
		}

		public virtual bool SetSymptomsScriptTaskExecute(ProcessExecutingContext context) {
			if(string.IsNullOrEmpty(Entity.GetTypedColumnValue<string>("Symptoms"))) {
			 var subject = Entity.GetTypedColumnValue<string>("Subject");
			 Entity.SetColumnValue("Symptoms", subject);
			}
			return true;
		}

		public virtual void SetProcessParameters() {
			var currentContactId = UserConnection.CurrentUser.ContactId;
			NewOwnerId = Entity.GetTypedColumnValue<Guid>("OwnerId");
			OldOwnerId = Entity.GetTypedOldColumnValue<Guid>("OwnerId");
			IsNeedSendRemind = NewOwnerId != OldOwnerId;
			SendToOldOwner = OldOwnerId != currentContactId && OldOwnerId != Guid.Empty;
			SendToNewOwner = NewOwnerId != currentContactId && NewOwnerId != Guid.Empty;
		}

		public virtual void SetPortalCaseSubject() {
			var subject = Entity.GetTypedColumnValue<string>("Subject"); 
			if (!string.IsNullOrEmpty(subject)) {
				return;
			}
			var number = Entity.GetTypedColumnValue<string>("Number"); 
			var categoryId = Entity.GetTypedColumnValue<Guid>("CategoryId");
			var categoryCaption = GetCaseGategoryCaption(categoryId);
			var byCaption = categoryId != CaseConsts.CaseCategoryServiceCallId ? SubjectByString : SubjectForString;
			var serviceCaption = GetServiceCaption();
			var generatedSubject = string.Format("{0} {1} {2} {3} ", number, categoryCaption, byCaption, serviceCaption);
			Entity.SetColumnValue("Subject", generatedSubject);
		}

		public virtual string GetServiceCaption() {
			return string.Empty; 
		}

		public virtual string GetCaseGategoryCaption(Guid categoryId) {
			var categoryQuery = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "CaseCategory");
			categoryQuery.AddColumn("Name"); 
			var category = categoryQuery .GetEntity(UserConnection, categoryId);
			if(category == null) {
				return string.Empty; 
			} 
			return category.GetTypedColumnValue<string>("Name"); 
		}

		public virtual bool IsStatusChanged(Entity entity) {
			Guid? value = entity.GetTypedColumnValue<Guid>("StatusId");
			Guid? oldValue = entity.GetTypedOldColumnValue<Guid>("StatusId");
			return ((value != null) && !value.Equals(oldValue)) ||
				((value == null) && oldValue != null);
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "Case_Case_TerrasoftSaved":
							if (ActivatedEventElements.Contains("StartMessage1")) {
							context.QueueTasks.Enqueue("StartMessage1");
						}
						break;
					case "SynchronizeRemindings":
							if (ActivatedEventElements.Contains("StartMessage4")) {
							context.QueueTasks.Enqueue("StartMessage4");
						}
						break;
					case "Case_Case_TerrasoftValidating":
							if (ActivatedEventElements.Contains("StartMessage5")) {
							context.QueueTasks.Enqueue("StartMessage5");
						}
						break;
					case "Case_Case_TerrasoftDeleting":
							if (ActivatedEventElements.Contains("StartMessage2")) {
							context.QueueTasks.Enqueue("StartMessage2");
						}
						break;
					case "Case_Case_TerrasoftSaving":
							if (ActivatedEventElements.Contains("StartMessage3")) {
							context.QueueTasks.Enqueue("StartMessage3");
						}
						break;
					case "Case_Case_TerrasoftInserting":
							if (ActivatedEventElements.Contains("CaseInsertingStartMessage")) {
							context.QueueTasks.Enqueue("CaseInsertingStartMessage");
						}
						break;
			}
			base.ThrowEvent(context, message);
			ProcessQueue(context);
		}

		public override void WritePropertiesData(DataWriter writer, bool writeFlowElements = true) {
			base.WritePropertiesData(writer, writeFlowElements);
			if (!HasMapping("SendToNewOwner") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("SendToNewOwner", SendToNewOwner, false);
			}
			if (!HasMapping("SendToOldOwner") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("SendToOldOwner", SendToOldOwner, false);
			}
			if (!HasMapping("IsNeedSendRemind") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("IsNeedSendRemind", IsNeedSendRemind, false);
			}
			if (!HasMapping("NewOwnerId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("NewOwnerId", NewOwnerId, Guid.Empty);
			}
			if (!HasMapping("OldOwnerId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("OldOwnerId", OldOwnerId, Guid.Empty);
			}
		}

		public override object CloneShallow() {
			return base.CloneShallow();
		}

		#endregion

	}

	#endregion

	#region Class: Case_CaseEventsProcess

	/// <exclude/>
	public class Case_CaseEventsProcess : Case_CaseEventsProcess<Case_Case_Terrasoft>
	{

		public Case_CaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: Case_Case_TerrasoftEventsProcessSchema

	/// <exclude/>
	public class Case_Case_TerrasoftEventsProcessSchema : Terrasoft.Configuration.BaseCaseEventsProcessSchema
	{

		#region Constructors: Public

		public Case_Case_TerrasoftEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public Case_Case_TerrasoftEventsProcessSchema(Case_Case_TerrasoftEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "Case_CaseEventsProcess";
			UId = new Guid("2e4ad2a2-869c-48da-b867-91374c625baa");
			CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("c732b900-2d9a-4129-96fa-06c57b24c6ea");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
		}

		protected virtual ProcessSchemaParameter CreateOldOwnerIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("9bb6afb9-6bf9-453c-b34e-0c41ba45b20e"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("2e4ad2a2-869c-48da-b867-91374c625baa"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("2e4ad2a2-869c-48da-b867-91374c625baa"),
				Name = @"OldOwnerId",
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateNewOwnerIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("8e8639ff-0450-4d99-aec3-f1160d4edfa2"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("2e4ad2a2-869c-48da-b867-91374c625baa"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("2e4ad2a2-869c-48da-b867-91374c625baa"),
				Name = @"NewOwnerId",
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateIsNeedSendRemindParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("0e7a4172-73a2-408d-a620-56b477472cd1"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("2e4ad2a2-869c-48da-b867-91374c625baa"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("2e4ad2a2-869c-48da-b867-91374c625baa"),
				Name = @"IsNeedSendRemind",
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateSendToOldOwnerParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("a9bfcd4c-2b43-4962-90f1-0d9e9e0cbdca"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("2e4ad2a2-869c-48da-b867-91374c625baa"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("2e4ad2a2-869c-48da-b867-91374c625baa"),
				Name = @"SendToOldOwner",
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateSendToNewOwnerParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("0eb64ec2-8035-49f6-bf2c-ef0d1fed708f"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("2e4ad2a2-869c-48da-b867-91374c625baa"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("2e4ad2a2-869c-48da-b867-91374c625baa"),
				Name = @"SendToNewOwner",
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateOldOwnerIdParameter());
			Parameters.Add(CreateNewOwnerIdParameter());
			Parameters.Add(CreateIsNeedSendRemindParameter());
			Parameters.Add(CreateSendToOldOwnerParameter());
			Parameters.Add(CreateSendToNewOwnerParameter());
		}

		protected virtual void InitializeOldOwnerSynchronizeSubjectRemindingParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("13b67190-fed7-4139-a8a1-21218a9de0ae"),
				ContainerUId = new Guid("d56b15a9-c6cc-40d1-aace-33874aa8dbab"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("30392711-0c15-40b6-8b03-9e3232660270"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = true,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("30392711-0c15-40b6-8b03-9e3232660270"),
				Name = @"Active",
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					Value = null,
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			});
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("1a32b749-c11b-4800-92e7-9648be75e1ee"),
				ContainerUId = new Guid("d56b15a9-c6cc-40d1-aace-33874aa8dbab"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("30392711-0c15-40b6-8b03-9e3232660270"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = true,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("30392711-0c15-40b6-8b03-9e3232660270"),
				Name = @"SubjectPrimaryColumnValue",
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					Value = null,
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			});
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("42a2cf94-67d7-407e-9977-0f80183c0773"),
				ContainerUId = new Guid("d56b15a9-c6cc-40d1-aace-33874aa8dbab"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("30392711-0c15-40b6-8b03-9e3232660270"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("30392711-0c15-40b6-8b03-9e3232660270"),
				Name = @"Author",
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					Value = null,
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			});
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("e481e39a-9928-4580-81df-716444f2738a"),
				ContainerUId = new Guid("d56b15a9-c6cc-40d1-aace-33874aa8dbab"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("30392711-0c15-40b6-8b03-9e3232660270"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = true,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("30392711-0c15-40b6-8b03-9e3232660270"),
				Name = @"Contact",
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					Value = null,
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			});
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("ac078eed-858f-4bad-ae93-395c1a4eb8a3"),
				ContainerUId = new Guid("d56b15a9-c6cc-40d1-aace-33874aa8dbab"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("30392711-0c15-40b6-8b03-9e3232660270"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = true,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("30392711-0c15-40b6-8b03-9e3232660270"),
				Name = @"Source",
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					Value = null,
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			});
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("dc8c5b85-26ca-4ac4-a0ba-2bb1cf56995f"),
				ContainerUId = new Guid("d56b15a9-c6cc-40d1-aace-33874aa8dbab"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("30392711-0c15-40b6-8b03-9e3232660270"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = true,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("30392711-0c15-40b6-8b03-9e3232660270"),
				Name = @"RemindTime",
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					Value = null,
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("DateTime"),
			});
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("f35da398-492b-4909-b93e-d835c47667d8"),
				ContainerUId = new Guid("d56b15a9-c6cc-40d1-aace-33874aa8dbab"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("30392711-0c15-40b6-8b03-9e3232660270"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = true,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("30392711-0c15-40b6-8b03-9e3232660270"),
				Name = @"Description",
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MediumText"),
			});
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("94a575df-6a28-499b-99b3-f6a47073b630"),
				ContainerUId = new Guid("d56b15a9-c6cc-40d1-aace-33874aa8dbab"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("30392711-0c15-40b6-8b03-9e3232660270"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = true,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("30392711-0c15-40b6-8b03-9e3232660270"),
				Name = @"SysEntitySchema",
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					Value = null,
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			});
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("3f9595e1-3977-4a7d-92cd-0556e2491f56"),
				ContainerUId = new Guid("d56b15a9-c6cc-40d1-aace-33874aa8dbab"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("30392711-0c15-40b6-8b03-9e3232660270"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("30392711-0c15-40b6-8b03-9e3232660270"),
				Name = @"SubjectCaption",
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
			});
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("781ca607-f064-49a1-94f0-0bdfca1210f6"),
				ContainerUId = new Guid("d56b15a9-c6cc-40d1-aace-33874aa8dbab"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("30392711-0c15-40b6-8b03-9e3232660270"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("30392711-0c15-40b6-8b03-9e3232660270"),
				Name = @"TypeCaption",
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
			});
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("685820b5-f001-4fd9-ab45-c4c2fc03290d"),
				ContainerUId = new Guid("d56b15a9-c6cc-40d1-aace-33874aa8dbab"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("30392711-0c15-40b6-8b03-9e3232660270"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("30392711-0c15-40b6-8b03-9e3232660270"),
				Name = @"IsListSubjectReminds",
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					Value = @"",
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			});
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("34507a78-3cae-48f1-9eac-ce1ba321bdad"),
				ContainerUId = new Guid("d56b15a9-c6cc-40d1-aace-33874aa8dbab"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("30392711-0c15-40b6-8b03-9e3232660270"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("30392711-0c15-40b6-8b03-9e3232660270"),
				Name = @"IsSubjectDelete",
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					Value = @"",
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			});
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("15bab635-400c-4b86-8cf7-27f218a205cd"),
				ContainerUId = new Guid("d56b15a9-c6cc-40d1-aace-33874aa8dbab"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("30392711-0c15-40b6-8b03-9e3232660270"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("30392711-0c15-40b6-8b03-9e3232660270"),
				Name = @"NotificationType",
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					Value = @"",
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			});
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("994adaf8-3bd6-4180-bb7d-ff0e4070aa17"),
				ContainerUId = new Guid("d56b15a9-c6cc-40d1-aace-33874aa8dbab"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("30392711-0c15-40b6-8b03-9e3232660270"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("30392711-0c15-40b6-8b03-9e3232660270"),
				Name = @"PopupTitle",
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
			});
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("96fa8ef4-3fbc-4b6c-913c-b99f00123789"),
				ContainerUId = new Guid("d56b15a9-c6cc-40d1-aace-33874aa8dbab"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("30392711-0c15-40b6-8b03-9e3232660270"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("30392711-0c15-40b6-8b03-9e3232660270"),
				Name = @"IsSingleReminder",
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					Value = @"",
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			});
		}

		protected virtual void InitializeNewOwnerSynchronizeSubjectRemindingParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("190a32fa-5600-4658-846a-6497002cbcea"),
				ContainerUId = new Guid("95526637-cde5-4a0e-bb85-f806fcc8b881"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("30392711-0c15-40b6-8b03-9e3232660270"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = true,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("30392711-0c15-40b6-8b03-9e3232660270"),
				Name = @"Active",
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					Value = null,
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			});
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("1d541668-ea33-4303-9dcf-a9f98ea496e2"),
				ContainerUId = new Guid("95526637-cde5-4a0e-bb85-f806fcc8b881"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("30392711-0c15-40b6-8b03-9e3232660270"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = true,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("30392711-0c15-40b6-8b03-9e3232660270"),
				Name = @"SubjectPrimaryColumnValue",
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					Value = null,
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			});
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("125685ec-7d83-4930-802e-c130b8bca687"),
				ContainerUId = new Guid("95526637-cde5-4a0e-bb85-f806fcc8b881"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("30392711-0c15-40b6-8b03-9e3232660270"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("30392711-0c15-40b6-8b03-9e3232660270"),
				Name = @"Author",
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					Value = null,
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			});
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("977d7541-3b11-4280-91b7-2ef346dcfdbb"),
				ContainerUId = new Guid("95526637-cde5-4a0e-bb85-f806fcc8b881"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("30392711-0c15-40b6-8b03-9e3232660270"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = true,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("30392711-0c15-40b6-8b03-9e3232660270"),
				Name = @"Contact",
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					Value = null,
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			});
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("066807db-fe75-429f-aec9-0f19b4d30fc1"),
				ContainerUId = new Guid("95526637-cde5-4a0e-bb85-f806fcc8b881"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("30392711-0c15-40b6-8b03-9e3232660270"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = true,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("30392711-0c15-40b6-8b03-9e3232660270"),
				Name = @"Source",
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					Value = null,
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			});
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("29032568-5436-408e-b700-7b299b57f9a8"),
				ContainerUId = new Guid("95526637-cde5-4a0e-bb85-f806fcc8b881"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("30392711-0c15-40b6-8b03-9e3232660270"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = true,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("30392711-0c15-40b6-8b03-9e3232660270"),
				Name = @"RemindTime",
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					Value = null,
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("DateTime"),
			});
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("ec3b1669-1ae8-492e-8e48-d146db06528d"),
				ContainerUId = new Guid("95526637-cde5-4a0e-bb85-f806fcc8b881"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("30392711-0c15-40b6-8b03-9e3232660270"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = true,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("30392711-0c15-40b6-8b03-9e3232660270"),
				Name = @"Description",
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MediumText"),
			});
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("9930af69-d3f5-42eb-aa3b-c83726535ae3"),
				ContainerUId = new Guid("95526637-cde5-4a0e-bb85-f806fcc8b881"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("30392711-0c15-40b6-8b03-9e3232660270"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = true,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("30392711-0c15-40b6-8b03-9e3232660270"),
				Name = @"SysEntitySchema",
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					Value = null,
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			});
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("7cff28cd-d5bc-4f6b-a1b5-dc2a635923c5"),
				ContainerUId = new Guid("95526637-cde5-4a0e-bb85-f806fcc8b881"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("30392711-0c15-40b6-8b03-9e3232660270"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("30392711-0c15-40b6-8b03-9e3232660270"),
				Name = @"SubjectCaption",
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
			});
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("b9e8070e-904e-4c27-825d-889381d50f89"),
				ContainerUId = new Guid("95526637-cde5-4a0e-bb85-f806fcc8b881"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("30392711-0c15-40b6-8b03-9e3232660270"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("30392711-0c15-40b6-8b03-9e3232660270"),
				Name = @"TypeCaption",
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
			});
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("8765a23c-2a22-428a-b579-09ae30507cb0"),
				ContainerUId = new Guid("95526637-cde5-4a0e-bb85-f806fcc8b881"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("30392711-0c15-40b6-8b03-9e3232660270"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("30392711-0c15-40b6-8b03-9e3232660270"),
				Name = @"IsListSubjectReminds",
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					Value = @"",
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			});
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("29a7938d-a59a-4ef5-84f7-058a432251c9"),
				ContainerUId = new Guid("95526637-cde5-4a0e-bb85-f806fcc8b881"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("30392711-0c15-40b6-8b03-9e3232660270"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("30392711-0c15-40b6-8b03-9e3232660270"),
				Name = @"IsSubjectDelete",
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					Value = @"",
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			});
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("a6e697ad-b19e-471e-82e7-b3463e6366d4"),
				ContainerUId = new Guid("95526637-cde5-4a0e-bb85-f806fcc8b881"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("30392711-0c15-40b6-8b03-9e3232660270"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("30392711-0c15-40b6-8b03-9e3232660270"),
				Name = @"NotificationType",
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					Value = @"",
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			});
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("89bbfcc2-cb93-46b9-89ea-27df19c7bf84"),
				ContainerUId = new Guid("95526637-cde5-4a0e-bb85-f806fcc8b881"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("30392711-0c15-40b6-8b03-9e3232660270"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("30392711-0c15-40b6-8b03-9e3232660270"),
				Name = @"PopupTitle",
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
			});
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("2b110d4e-4d6b-4a4f-b82a-597013e6dcec"),
				ContainerUId = new Guid("95526637-cde5-4a0e-bb85-f806fcc8b881"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("30392711-0c15-40b6-8b03-9e3232660270"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("30392711-0c15-40b6-8b03-9e3232660270"),
				Name = @"IsSingleReminder",
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					Value = @"",
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			});
		}

		protected virtual void InitializeGenerateNumberUserTaskParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("e83cde03-2d68-4c05-aa41-2ae9e4dfc175"),
				ContainerUId = new Guid("a12485ee-3852-431a-9e82-0ba099749841"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b9b23348-b89c-4836-8c5b-283ef5ed8666"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b9b23348-b89c-4836-8c5b-283ef5ed8666"),
				Name = @"ResultCode",
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
			});
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("bb9fee46-0c53-437a-be8e-f4b0d0e1471b"),
				ContainerUId = new Guid("a12485ee-3852-431a-9e82-0ba099749841"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b9b23348-b89c-4836-8c5b-283ef5ed8666"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = true,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b9b23348-b89c-4836-8c5b-283ef5ed8666"),
				Name = @"EntitySchema",
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					Value = null,
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			});
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet1 = CreateLaneSet1LaneSet();
			LaneSets.Add(schemaLaneSet1);
			ProcessSchemaLane schemaLane1 = CreateLane1Lane();
			schemaLaneSet1.Lanes.Add(schemaLane1);
			ProcessSchemaEventSubProcess eventsubprocess1 = CreateEventSubProcess1EventSubProcess();
			FlowElements.Add(eventsubprocess1);
			ProcessSchemaEventSubProcess eventsubprocess2 = CreateEventSubProcess2EventSubProcess();
			FlowElements.Add(eventsubprocess2);
			ProcessSchemaEventSubProcess eventsubprocess3 = CreateEventSubProcess3EventSubProcess();
			FlowElements.Add(eventsubprocess3);
			ProcessSchemaStartMessageEvent startmessage1 = CreateStartMessage1StartMessageEvent();
			eventsubprocess1.FlowElements.Add(startmessage1);
			ProcessSchemaScriptTask oldscriptpreparesynchronizeremindings = CreateOldScriptPrepareSynchronizeRemindingsScriptTask();
			eventsubprocess1.FlowElements.Add(oldscriptpreparesynchronizeremindings);
			ProcessSchemaUserTask oldownersynchronizesubjectreminding = CreateOldOwnerSynchronizeSubjectRemindingUserTask();
			eventsubprocess1.FlowElements.Add(oldownersynchronizesubjectreminding);
			ProcessSchemaInclusiveGateway inclusivegateway1 = CreateInclusiveGateway1InclusiveGateway();
			eventsubprocess1.FlowElements.Add(inclusivegateway1);
			ProcessSchemaUserTask newownersynchronizesubjectreminding = CreateNewOwnerSynchronizeSubjectRemindingUserTask();
			eventsubprocess1.FlowElements.Add(newownersynchronizesubjectreminding);
			ProcessSchemaScriptTask newscriptpreparesynchronizeremindings = CreateNewScriptPrepareSynchronizeRemindingsScriptTask();
			eventsubprocess1.FlowElements.Add(newscriptpreparesynchronizeremindings);
			ProcessSchemaIntermediateThrowMessageEvent intermediatethrowmessageevent4 = CreateIntermediateThrowMessageEvent4IntermediateThrowMessageEvent();
			eventsubprocess1.FlowElements.Add(intermediatethrowmessageevent4);
			ProcessSchemaStartMessageEvent startmessage4 = CreateStartMessage4StartMessageEvent();
			eventsubprocess1.FlowElements.Add(startmessage4);
			ProcessSchemaScriptTask emptyscripttask = CreateEmptyScriptTaskScriptTask();
			eventsubprocess1.FlowElements.Add(emptyscripttask);
			ProcessSchemaExclusiveGateway exclusivegateway1 = CreateExclusiveGateway1ExclusiveGateway();
			eventsubprocess1.FlowElements.Add(exclusivegateway1);
			ProcessSchemaStartMessageEvent startmessage5 = CreateStartMessage5StartMessageEvent();
			eventsubprocess1.FlowElements.Add(startmessage5);
			ProcessSchemaScriptTask casevalidatingscripttask = CreateCaseValidatingScriptTaskScriptTask();
			eventsubprocess1.FlowElements.Add(casevalidatingscripttask);
			ProcessSchemaStartMessageEvent startmessage2 = CreateStartMessage2StartMessageEvent();
			eventsubprocess2.FlowElements.Add(startmessage2);
			ProcessSchemaStartMessageEvent startmessage3 = CreateStartMessage3StartMessageEvent();
			eventsubprocess2.FlowElements.Add(startmessage3);
			ProcessSchemaScriptTask casesavingscripttask = CreateCaseSavingScriptTaskScriptTask();
			eventsubprocess2.FlowElements.Add(casesavingscripttask);
			ProcessSchemaIntermediateThrowMessageEvent intermediatethrowmessageevent5 = CreateIntermediateThrowMessageEvent5IntermediateThrowMessageEvent();
			eventsubprocess2.FlowElements.Add(intermediatethrowmessageevent5);
			ProcessSchemaScriptTask setprocessparametersscripttask = CreateSetProcessParametersScriptTaskScriptTask();
			eventsubprocess2.FlowElements.Add(setprocessparametersscripttask);
			ProcessSchemaStartMessageEvent caseinsertingstartmessage = CreateCaseInsertingStartMessageStartMessageEvent();
			eventsubprocess3.FlowElements.Add(caseinsertingstartmessage);
			ProcessSchemaExclusiveGateway needgenerateexclusivegateway = CreateNeedGenerateExclusiveGatewayExclusiveGateway();
			eventsubprocess3.FlowElements.Add(needgenerateexclusivegateway);
			ProcessSchemaExclusiveGateway exclusivegateway2 = CreateExclusiveGateway2ExclusiveGateway();
			eventsubprocess3.FlowElements.Add(exclusivegateway2);
			ProcessSchemaScriptTask setnumberscripttask = CreateSetNumberScriptTaskScriptTask();
			eventsubprocess3.FlowElements.Add(setnumberscripttask);
			ProcessSchemaScriptTask setgeneratednumberscript = CreateSetGeneratedNumberScriptScriptTask();
			eventsubprocess3.FlowElements.Add(setgeneratednumberscript);
			ProcessSchemaUserTask generatenumberusertask = CreateGenerateNumberUserTaskUserTask();
			eventsubprocess3.FlowElements.Add(generatenumberusertask);
			ProcessSchemaScriptTask setportalnumberscripttask = CreateSetPortalNumberScriptTaskScriptTask();
			eventsubprocess3.FlowElements.Add(setportalnumberscripttask);
			ProcessSchemaTerminateEvent terminate1 = CreateTerminate1TerminateEvent();
			eventsubprocess3.FlowElements.Add(terminate1);
			ProcessSchemaScriptTask setsymptomsscripttask = CreateSetSymptomsScriptTaskScriptTask();
			eventsubprocess3.FlowElements.Add(setsymptomsscripttask);
			FlowElements.Add(CreateConditionalFlow1ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateSequenceFlow5SequenceFlow());
			FlowElements.Add(CreateSequenceFlow7SequenceFlow());
			FlowElements.Add(CreateConditionalFlow2ConditionalFlow());
			FlowElements.Add(CreateConditionalFlow3ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow10SequenceFlow());
			FlowElements.Add(CreateSequenceFlow4SequenceFlow());
			FlowElements.Add(CreateSequenceFlow6SequenceFlow());
			FlowElements.Add(CreateSequenceFlow9SequenceFlow());
			FlowElements.Add(CreateSequenceFlow11SequenceFlow());
			FlowElements.Add(CreateSequenceFlow12SequenceFlow());
			FlowElements.Add(CreateSequenceFlow13SequenceFlow());
			FlowElements.Add(CreateConditionalFlow4ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow15SequenceFlow());
			FlowElements.Add(CreateConditionalFlow5ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow16SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
			FlowElements.Add(CreateSequenceFlow17SequenceFlow());
			FlowElements.Add(CreateCaseValidatingFlowSequenceFlow());
			FlowElements.Add(CreateSequenceFlow8SequenceFlow());
			FlowElements.Add(CreateSequenceFlow14SequenceFlow());
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateServiceRequestNameLocalizableString());
			LocalizableStrings.Add(CreateNewOwnerCaptionLocalizableString());
			LocalizableStrings.Add(CreateNewOwnerMessageLocalizableString());
			LocalizableStrings.Add(CreateOldOwnerCaptionLocalizableString());
			LocalizableStrings.Add(CreateOldOwnerMessageLocalizableString());
			LocalizableStrings.Add(CreateSubjectByStringLocalizableString());
			LocalizableStrings.Add(CreateSubjectForStringLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateServiceRequestNameLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("93063512-204a-4a6d-a244-90c975699828"),
				Name = "ServiceRequestName",
				CreatedInPackageId = new Guid("305fcfca-4160-4398-90a9-d5e84be0ae12"),
				CreatedInSchemaUId = new Guid("2e4ad2a2-869c-48da-b867-91374c625baa"),
				ModifiedInSchemaUId = new Guid("2e4ad2a2-869c-48da-b867-91374c625baa")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateNewOwnerCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("755091aa-f8fc-486d-afe4-40eb11d792d2"),
				Name = "NewOwnerCaption",
				CreatedInPackageId = new Guid("305fcfca-4160-4398-90a9-d5e84be0ae12"),
				CreatedInSchemaUId = new Guid("2e4ad2a2-869c-48da-b867-91374c625baa"),
				ModifiedInSchemaUId = new Guid("2e4ad2a2-869c-48da-b867-91374c625baa")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateNewOwnerMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("38717c5f-b118-49a4-b38c-08e876235292"),
				Name = "NewOwnerMessage",
				CreatedInPackageId = new Guid("305fcfca-4160-4398-90a9-d5e84be0ae12"),
				CreatedInSchemaUId = new Guid("2e4ad2a2-869c-48da-b867-91374c625baa"),
				ModifiedInSchemaUId = new Guid("2e4ad2a2-869c-48da-b867-91374c625baa")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateOldOwnerCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("86cfc1fe-c52e-4e75-b0c2-d6608030fc49"),
				Name = "OldOwnerCaption",
				CreatedInPackageId = new Guid("305fcfca-4160-4398-90a9-d5e84be0ae12"),
				CreatedInSchemaUId = new Guid("2e4ad2a2-869c-48da-b867-91374c625baa"),
				ModifiedInSchemaUId = new Guid("2e4ad2a2-869c-48da-b867-91374c625baa")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateOldOwnerMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("16f641d2-3faf-4773-9464-c818592caf0d"),
				Name = "OldOwnerMessage",
				CreatedInPackageId = new Guid("305fcfca-4160-4398-90a9-d5e84be0ae12"),
				CreatedInSchemaUId = new Guid("2e4ad2a2-869c-48da-b867-91374c625baa"),
				ModifiedInSchemaUId = new Guid("2e4ad2a2-869c-48da-b867-91374c625baa")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateSubjectByStringLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("2210cf8f-f280-42cc-a766-029526fe8518"),
				Name = "SubjectByString",
				CreatedInPackageId = new Guid("c3c90037-274c-4793-841e-197eb228d3cd"),
				CreatedInSchemaUId = new Guid("2e4ad2a2-869c-48da-b867-91374c625baa"),
				ModifiedInSchemaUId = new Guid("2e4ad2a2-869c-48da-b867-91374c625baa")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateSubjectForStringLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("e5ab7899-f469-4bab-abb3-d8994c8e984e"),
				Name = "SubjectForString",
				CreatedInPackageId = new Guid("c3c90037-274c-4793-841e-197eb228d3cd"),
				CreatedInSchemaUId = new Guid("2e4ad2a2-869c-48da-b867-91374c625baa"),
				ModifiedInSchemaUId = new Guid("2e4ad2a2-869c-48da-b867-91374c625baa")
			};
			return localizableString;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow1ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow1",
				UId = new Guid("109bded3-a3b0-4a70-b267-436bb84135b9"),
				ConditionExpression = @"IsNeedSendRemind || Entity.IsInDeleting",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c732b900-2d9a-4129-96fa-06c57b24c6ea"),
				CreatedInPackageId = new Guid("305fcfca-4160-4398-90a9-d5e84be0ae12"),
				CreatedInSchemaUId = new Guid("2e4ad2a2-869c-48da-b867-91374c625baa"),
				CurveCenterPosition = new Point(181, 94),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("2e4ad2a2-869c-48da-b867-91374c625baa"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("25b3a2b3-1b9d-4e6b-a42a-d73683447b25"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("9e5c2e36-2fa2-407a-8905-d8f0e4135dcb"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("37d3ce1b-903d-4784-8cc1-b6235681e5df"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c732b900-2d9a-4129-96fa-06c57b24c6ea"),
				CreatedInPackageId = new Guid("305fcfca-4160-4398-90a9-d5e84be0ae12"),
				CreatedInSchemaUId = new Guid("2e4ad2a2-869c-48da-b867-91374c625baa"),
				CurveCenterPosition = new Point(329, 96),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("2e4ad2a2-869c-48da-b867-91374c625baa"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("1ff4178d-b591-4f0d-a302-073fe18b95a3"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("d56b15a9-c6cc-40d1-aace-33874aa8dbab"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("d04479f8-aa8b-43d2-80fe-e2f25f5e4d49"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c732b900-2d9a-4129-96fa-06c57b24c6ea"),
				CreatedInPackageId = new Guid("305fcfca-4160-4398-90a9-d5e84be0ae12"),
				CreatedInSchemaUId = new Guid("2e4ad2a2-869c-48da-b867-91374c625baa"),
				CurveCenterPosition = new Point(116, 169),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("2e4ad2a2-869c-48da-b867-91374c625baa"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("e46e3222-04fa-4aee-b53f-4c8ba8116818"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("de7d5aff-ef1e-4de2-bbea-1aca03bebcd8"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow5SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow5",
				UId = new Guid("aa76a1c3-7676-46ff-a502-662812d1bb5d"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c732b900-2d9a-4129-96fa-06c57b24c6ea"),
				CreatedInPackageId = new Guid("305fcfca-4160-4398-90a9-d5e84be0ae12"),
				CreatedInSchemaUId = new Guid("2e4ad2a2-869c-48da-b867-91374c625baa"),
				CurveCenterPosition = new Point(679, 96),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("2e4ad2a2-869c-48da-b867-91374c625baa"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("575fdd36-3e2c-4ccc-91e0-965fec1451d4"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("7d1ffbbc-421d-4b33-99c0-2c3e68e755ff"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow7SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow7",
				UId = new Guid("20af0c71-7284-409f-874f-8b6252a9093a"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c732b900-2d9a-4129-96fa-06c57b24c6ea"),
				CreatedInPackageId = new Guid("305fcfca-4160-4398-90a9-d5e84be0ae12"),
				CreatedInSchemaUId = new Guid("2e4ad2a2-869c-48da-b867-91374c625baa"),
				CurveCenterPosition = new Point(792, 223),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("2e4ad2a2-869c-48da-b867-91374c625baa"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("b089b5d0-c1c7-462d-b3b4-22378f8cfce8"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("b3f7a8a0-9776-4556-97ae-b15ebe58306e"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow2ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow2",
				UId = new Guid("681e6224-86ca-4074-b5cd-ea90d495e5dd"),
				ConditionExpression = @"UserConnection.CurrentUser.ConnectionType != UserType.SSP && (SendToOldOwner || Entity.IsInDeleting)",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c732b900-2d9a-4129-96fa-06c57b24c6ea"),
				CreatedInPackageId = new Guid("305fcfca-4160-4398-90a9-d5e84be0ae12"),
				CreatedInSchemaUId = new Guid("2e4ad2a2-869c-48da-b867-91374c625baa"),
				CurveCenterPosition = new Point(435, 149),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("2e4ad2a2-869c-48da-b867-91374c625baa"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("9e5c2e36-2fa2-407a-8905-d8f0e4135dcb"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("1ff4178d-b591-4f0d-a302-073fe18b95a3"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			schemaFlow.PolylinePointPositions.Add(new Point(302, 77));
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow3ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow3",
				UId = new Guid("c6de67fa-22af-471e-9325-1ba18a90c9ab"),
				ConditionExpression = @"SendToNewOwner || Entity.IsInDeleting",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c732b900-2d9a-4129-96fa-06c57b24c6ea"),
				CreatedInPackageId = new Guid("305fcfca-4160-4398-90a9-d5e84be0ae12"),
				CreatedInSchemaUId = new Guid("2e4ad2a2-869c-48da-b867-91374c625baa"),
				CurveCenterPosition = new Point(432, 222),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("2e4ad2a2-869c-48da-b867-91374c625baa"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("9e5c2e36-2fa2-407a-8905-d8f0e4135dcb"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("10307809-1e7d-4af7-b2db-4ce4e948355e"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			schemaFlow.PolylinePointPositions.Add(new Point(302, 357));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow10SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow10",
				UId = new Guid("6902450e-957d-4d99-91d4-c27feb4e0cce"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c732b900-2d9a-4129-96fa-06c57b24c6ea"),
				CreatedInPackageId = new Guid("305fcfca-4160-4398-90a9-d5e84be0ae12"),
				CreatedInSchemaUId = new Guid("2e4ad2a2-869c-48da-b867-91374c625baa"),
				CurveCenterPosition = new Point(574, 222),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("2e4ad2a2-869c-48da-b867-91374c625baa"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("10307809-1e7d-4af7-b2db-4ce4e948355e"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("95526637-cde5-4a0e-bb85-f806fcc8b881"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlow4",
				UId = new Guid("ccced8dc-edd2-4f40-bfb8-f6874eccd0b0"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c732b900-2d9a-4129-96fa-06c57b24c6ea"),
				CreatedInPackageId = new Guid("305fcfca-4160-4398-90a9-d5e84be0ae12"),
				CreatedInSchemaUId = new Guid("2e4ad2a2-869c-48da-b867-91374c625baa"),
				CurveCenterPosition = new Point(423, 217),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("2e4ad2a2-869c-48da-b867-91374c625baa"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("9e5c2e36-2fa2-407a-8905-d8f0e4135dcb"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("db4aa9ae-1774-459b-b980-2fa818185cba"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow6SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow6",
				UId = new Guid("6d064a13-3e9f-4d80-a459-615767af7b0e"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c732b900-2d9a-4129-96fa-06c57b24c6ea"),
				CreatedInPackageId = new Guid("305fcfca-4160-4398-90a9-d5e84be0ae12"),
				CreatedInSchemaUId = new Guid("2e4ad2a2-869c-48da-b867-91374c625baa"),
				CurveCenterPosition = new Point(726, 304),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("2e4ad2a2-869c-48da-b867-91374c625baa"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("95526637-cde5-4a0e-bb85-f806fcc8b881"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("db4aa9ae-1774-459b-b980-2fa818185cba"),
				TargetSequenceFlowPointLocalPosition = new Point(0, -1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(610, 282));
			schemaFlow.PolylinePointPositions.Add(new Point(736, 282));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow9SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow9",
				UId = new Guid("6a38ac60-cba4-411c-a88f-607a0c4e4e91"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c732b900-2d9a-4129-96fa-06c57b24c6ea"),
				CreatedInPackageId = new Guid("305fcfca-4160-4398-90a9-d5e84be0ae12"),
				CreatedInSchemaUId = new Guid("2e4ad2a2-869c-48da-b867-91374c625baa"),
				CurveCenterPosition = new Point(722, 140),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("2e4ad2a2-869c-48da-b867-91374c625baa"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("d56b15a9-c6cc-40d1-aace-33874aa8dbab"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("db4aa9ae-1774-459b-b980-2fa818185cba"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(610, 135));
			schemaFlow.PolylinePointPositions.Add(new Point(736, 135));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow11SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlow11",
				UId = new Guid("5dff99b7-a675-44f8-a912-9b62349548da"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c732b900-2d9a-4129-96fa-06c57b24c6ea"),
				CreatedInPackageId = new Guid("305fcfca-4160-4398-90a9-d5e84be0ae12"),
				CreatedInSchemaUId = new Guid("2e4ad2a2-869c-48da-b867-91374c625baa"),
				CurveCenterPosition = new Point(522, 227),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("2e4ad2a2-869c-48da-b867-91374c625baa"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("25b3a2b3-1b9d-4e6b-a42a-d73683447b25"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("db4aa9ae-1774-459b-b980-2fa818185cba"),
				TargetSequenceFlowPointLocalPosition = new Point(1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(176, 282));
			schemaFlow.PolylinePointPositions.Add(new Point(801, 282));
			schemaFlow.PolylinePointPositions.Add(new Point(801, 224));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow12SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow12",
				UId = new Guid("39eb52e4-e6b9-4f11-9920-0e017c3ecf0b"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c732b900-2d9a-4129-96fa-06c57b24c6ea"),
				CreatedInPackageId = new Guid("305fcfca-4160-4398-90a9-d5e84be0ae12"),
				CreatedInSchemaUId = new Guid("2e4ad2a2-869c-48da-b867-91374c625baa"),
				CurveCenterPosition = new Point(166, 222),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("2e4ad2a2-869c-48da-b867-91374c625baa"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("39414ca4-8f12-4a14-9f96-55552793d9a5"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("25b3a2b3-1b9d-4e6b-a42a-d73683447b25"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow13SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow13",
				UId = new Guid("71134491-e4ad-4a2c-a121-c5f68081d0ac"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c732b900-2d9a-4129-96fa-06c57b24c6ea"),
				CreatedInPackageId = new Guid("305fcfca-4160-4398-90a9-d5e84be0ae12"),
				CreatedInSchemaUId = new Guid("2e4ad2a2-869c-48da-b867-91374c625baa"),
				CurveCenterPosition = new Point(679, 96),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("2e4ad2a2-869c-48da-b867-91374c625baa"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("7d1ffbbc-421d-4b33-99c0-2c3e68e755ff"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("f0926220-9df1-41a6-89a5-0212529dd0e8"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow4ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow4",
				UId = new Guid("fab3c8e7-86fb-45c5-a0f1-18da3ef32360"),
				ConditionExpression = @"string.IsNullOrEmpty(Entity.GetTypedColumnValue<string>(""Number""))",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c732b900-2d9a-4129-96fa-06c57b24c6ea"),
				CreatedInPackageId = new Guid("5cde2e00-3a14-4cc5-9d2d-f1cd6c0c33c5"),
				CreatedInSchemaUId = new Guid("2e4ad2a2-869c-48da-b867-91374c625baa"),
				CurveCenterPosition = new Point(654, 649),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("2e4ad2a2-869c-48da-b867-91374c625baa"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("d220fa56-b3b1-4e4e-af86-7af24cfe9041"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("f99ca610-4bc6-4ea5-814c-68852f20e20b"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow15SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlow15",
				UId = new Guid("224b8b47-60c2-4b7b-be3e-9e51ee3534ea"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c732b900-2d9a-4129-96fa-06c57b24c6ea"),
				CreatedInPackageId = new Guid("5cde2e00-3a14-4cc5-9d2d-f1cd6c0c33c5"),
				CreatedInSchemaUId = new Guid("2e4ad2a2-869c-48da-b867-91374c625baa"),
				CurveCenterPosition = new Point(820, 664),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("2e4ad2a2-869c-48da-b867-91374c625baa"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("d220fa56-b3b1-4e4e-af86-7af24cfe9041"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("4886fa94-41d9-4422-bd9c-a271ab80a0b2"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(592, 587));
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow5ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow5",
				UId = new Guid("96f257c1-5a8d-4255-9ca8-255f97f700d5"),
				ConditionExpression = @"UserConnection.CurrentUser.ConnectionType != UserType.SSP",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c732b900-2d9a-4129-96fa-06c57b24c6ea"),
				CreatedInPackageId = new Guid("677baab4-893e-4898-b508-38190fd135a7"),
				CreatedInSchemaUId = new Guid("2e4ad2a2-869c-48da-b867-91374c625baa"),
				CurveCenterPosition = new Point(772, 624),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("2e4ad2a2-869c-48da-b867-91374c625baa"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("f99ca610-4bc6-4ea5-814c-68852f20e20b"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("c87893b2-1b9c-4691-a509-d3f6f9e5631f"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			schemaFlow.PolylinePointPositions.Add(new Point(762, 657));
			schemaFlow.PolylinePointPositions.Add(new Point(762, 658));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow16SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlow16",
				UId = new Guid("4d36473f-ab88-4977-8a24-6f17b430457f"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c732b900-2d9a-4129-96fa-06c57b24c6ea"),
				CreatedInPackageId = new Guid("677baab4-893e-4898-b508-38190fd135a7"),
				CreatedInSchemaUId = new Guid("2e4ad2a2-869c-48da-b867-91374c625baa"),
				CurveCenterPosition = new Point(785, 673),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("2e4ad2a2-869c-48da-b867-91374c625baa"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("f99ca610-4bc6-4ea5-814c-68852f20e20b"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("b98e3401-639c-4df5-a402-4214ccb8edbe"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(686, 759));
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3",
				UId = new Guid("58d602f8-00d2-426a-84b1-45fdd5d8b937"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c732b900-2d9a-4129-96fa-06c57b24c6ea"),
				CreatedInPackageId = new Guid("c2657f9d-1b86-4f69-b0c1-b23085f13744"),
				CreatedInSchemaUId = new Guid("2e4ad2a2-869c-48da-b867-91374c625baa"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("2e4ad2a2-869c-48da-b867-91374c625baa"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("b98917cf-2f76-4258-b9b8-d955cfd80800"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("f233228e-9fb3-4a6a-8328-765813405eda"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow17SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow17",
				UId = new Guid("1b63f0e0-723b-4566-9d9f-834324f2ba87"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c732b900-2d9a-4129-96fa-06c57b24c6ea"),
				CreatedInPackageId = new Guid("c2657f9d-1b86-4f69-b0c1-b23085f13744"),
				CreatedInSchemaUId = new Guid("2e4ad2a2-869c-48da-b867-91374c625baa"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("2e4ad2a2-869c-48da-b867-91374c625baa"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("f233228e-9fb3-4a6a-8328-765813405eda"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("d220fa56-b3b1-4e4e-af86-7af24cfe9041"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateCaseValidatingFlowSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "CaseValidatingFlow",
				UId = new Guid("e43b4e68-c709-4e66-91cb-a944fad4b6b2"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c732b900-2d9a-4129-96fa-06c57b24c6ea"),
				CreatedInPackageId = new Guid("c3c90037-274c-4793-841e-197eb228d3cd"),
				CreatedInSchemaUId = new Guid("2e4ad2a2-869c-48da-b867-91374c625baa"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("2e4ad2a2-869c-48da-b867-91374c625baa"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("b02d6fc6-2f15-4205-8852-288ad6387947"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("3c19423a-d705-48e0-a38a-f6859ba5b636"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow8SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow8",
				UId = new Guid("83bfb15e-fd25-42fd-bfed-2189aa03418c"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c732b900-2d9a-4129-96fa-06c57b24c6ea"),
				CreatedInPackageId = new Guid("c3c90037-274c-4793-841e-197eb228d3cd"),
				CreatedInSchemaUId = new Guid("2e4ad2a2-869c-48da-b867-91374c625baa"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("2e4ad2a2-869c-48da-b867-91374c625baa"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("c87893b2-1b9c-4691-a509-d3f6f9e5631f"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("a12485ee-3852-431a-9e82-0ba099749841"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow14SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow14",
				UId = new Guid("d848d8df-d949-4c20-b322-5a4a11dc25e0"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c732b900-2d9a-4129-96fa-06c57b24c6ea"),
				CreatedInPackageId = new Guid("c3c90037-274c-4793-841e-197eb228d3cd"),
				CreatedInSchemaUId = new Guid("2e4ad2a2-869c-48da-b867-91374c625baa"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("2e4ad2a2-869c-48da-b867-91374c625baa"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("a12485ee-3852-431a-9e82-0ba099749841"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("3f9056e8-5ead-4880-bd13-c030019ec8f8"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("d88452f9-13fc-4212-9f29-715230cc05fc"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c732b900-2d9a-4129-96fa-06c57b24c6ea"),
				CreatedInPackageId = new Guid("305fcfca-4160-4398-90a9-d5e84be0ae12"),
				CreatedInSchemaUId = new Guid("2e4ad2a2-869c-48da-b867-91374c625baa"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("2e4ad2a2-869c-48da-b867-91374c625baa"),
				Name = @"LaneSet1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(5, 5),
				Size = new Size(1297, 532),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("151b65ad-df20-4b28-955f-7f5e129bd65d"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("d88452f9-13fc-4212-9f29-715230cc05fc"),
				CreatedInOwnerSchemaUId = new Guid("117d32f9-8275-4534-8411-1c66115ce9cd"),
				CreatedInPackageId = new Guid("305fcfca-4160-4398-90a9-d5e84be0ae12"),
				CreatedInSchemaUId = new Guid("2e4ad2a2-869c-48da-b867-91374c625baa"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("2e4ad2a2-869c-48da-b867-91374c625baa"),
				Name = @"Lane1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(29, 0),
				Size = new Size(1268, 532),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess1EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess1 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("e9dc6350-b621-40d0-971c-27b294f57e3b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("151b65ad-df20-4b28-955f-7f5e129bd65d"),
				CreatedInOwnerSchemaUId = new Guid("c732b900-2d9a-4129-96fa-06c57b24c6ea"),
				CreatedInPackageId = new Guid("305fcfca-4160-4398-90a9-d5e84be0ae12"),
				CreatedInSchemaUId = new Guid("2e4ad2a2-869c-48da-b867-91374c625baa"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("2e4ad2a2-869c-48da-b867-91374c625baa"),
				Name = @"EventSubProcess1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(36, 20),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(767, 520),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess1;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage1StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("e46e3222-04fa-4aee-b53f-4c8ba8116818"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e9dc6350-b621-40d0-971c-27b294f57e3b"),
				CreatedInOwnerSchemaUId = new Guid("c732b900-2d9a-4129-96fa-06c57b24c6ea"),
				CreatedInPackageId = new Guid("305fcfca-4160-4398-90a9-d5e84be0ae12"),
				CreatedInSchemaUId = new Guid("2e4ad2a2-869c-48da-b867-91374c625baa"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"CaseSaved",
				ModifiedInSchemaUId = new Guid("2e4ad2a2-869c-48da-b867-91374c625baa"),
				Name = @"StartMessage1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(36, 44),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateOldScriptPrepareSynchronizeRemindingsScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("1ff4178d-b591-4f0d-a302-073fe18b95a3"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e9dc6350-b621-40d0-971c-27b294f57e3b"),
				CreatedInOwnerSchemaUId = new Guid("c732b900-2d9a-4129-96fa-06c57b24c6ea"),
				CreatedInPackageId = new Guid("305fcfca-4160-4398-90a9-d5e84be0ae12"),
				CreatedInSchemaUId = new Guid("2e4ad2a2-869c-48da-b867-91374c625baa"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("2e4ad2a2-869c-48da-b867-91374c625baa"),
				Name = @"OldScriptPrepareSynchronizeRemindings",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(393, 30),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,147,221,78,2,49,16,133,175,37,225,29,144,43,72,204,190,128,63,137,89,149,108,162,96,88,240,190,116,71,24,179,109,113,58,197,172,79,111,75,151,31,141,38,197,187,157,211,153,147,175,167,179,147,186,154,124,104,160,178,209,114,69,70,227,39,148,110,241,6,146,167,160,80,87,168,151,89,97,91,233,14,106,96,232,93,247,238,53,35,55,254,160,208,91,205,119,93,118,59,147,36,175,71,180,252,77,182,222,144,201,65,162,195,172,89,67,46,214,140,70,251,65,203,20,196,7,67,74,240,160,4,218,160,132,41,188,59,176,60,22,10,46,118,172,35,224,48,89,229,166,118,74,191,136,218,193,85,28,190,25,244,199,78,45,128,250,195,97,34,195,173,100,220,132,32,206,255,159,68,43,60,19,42,65,205,17,214,33,223,223,152,71,14,43,79,92,84,253,84,216,220,104,22,146,189,237,174,187,168,82,25,141,35,25,128,246,146,55,179,108,179,125,29,59,78,115,141,95,51,84,193,121,110,129,188,169,246,29,254,69,179,220,17,129,230,160,134,235,183,229,157,96,8,253,131,212,59,151,141,141,25,150,114,5,74,28,34,141,117,54,79,143,32,10,127,109,220,206,226,9,172,21,75,191,110,221,206,217,41,27,151,182,159,45,68,250,130,142,13,227,43,74,17,152,131,173,231,206,133,133,246,245,126,158,30,215,219,96,8,216,145,142,127,229,23,6,78,190,50,34,4,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaUserTask CreateOldOwnerSynchronizeSubjectRemindingUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("d56b15a9-c6cc-40d1-aace-33874aa8dbab"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e9dc6350-b621-40d0-971c-27b294f57e3b"),
				CreatedInOwnerSchemaUId = new Guid("c732b900-2d9a-4129-96fa-06c57b24c6ea"),
				CreatedInPackageId = new Guid("305fcfca-4160-4398-90a9-d5e84be0ae12"),
				CreatedInSchemaUId = new Guid("2e4ad2a2-869c-48da-b867-91374c625baa"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("2e4ad2a2-869c-48da-b867-91374c625baa"),
				Name = @"OldOwnerSynchronizeSubjectReminding",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(540, 30),
				SchemaUId = new Guid("30392711-0c15-40b6-8b03-9e3232660270"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				TaskSchemaManagerName = @"ProcessUserTaskSchemaManager",
				UseBackgroundMode = false
			};
			InitializeOldOwnerSynchronizeSubjectRemindingParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaInclusiveGateway CreateInclusiveGateway1InclusiveGateway() {
			ProcessSchemaInclusiveGateway gateway = new ProcessSchemaInclusiveGateway(this) {
				UId = new Guid("9e5c2e36-2fa2-407a-8905-d8f0e4135dcb"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e9dc6350-b621-40d0-971c-27b294f57e3b"),
				CreatedInOwnerSchemaUId = new Guid("c732b900-2d9a-4129-96fa-06c57b24c6ea"),
				CreatedInPackageId = new Guid("305fcfca-4160-4398-90a9-d5e84be0ae12"),
				CreatedInSchemaUId = new Guid("2e4ad2a2-869c-48da-b867-91374c625baa"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("ffa4a06a-5747-49d4-96c2-c32a727a3b14"),
				ModifiedInSchemaUId = new Guid("2e4ad2a2-869c-48da-b867-91374c625baa"),
				Name = @"InclusiveGateway1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(239, 177),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaUserTask CreateNewOwnerSynchronizeSubjectRemindingUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("95526637-cde5-4a0e-bb85-f806fcc8b881"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e9dc6350-b621-40d0-971c-27b294f57e3b"),
				CreatedInOwnerSchemaUId = new Guid("c732b900-2d9a-4129-96fa-06c57b24c6ea"),
				CreatedInPackageId = new Guid("305fcfca-4160-4398-90a9-d5e84be0ae12"),
				CreatedInSchemaUId = new Guid("2e4ad2a2-869c-48da-b867-91374c625baa"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("2e4ad2a2-869c-48da-b867-91374c625baa"),
				Name = @"NewOwnerSynchronizeSubjectReminding",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(540, 310),
				SchemaUId = new Guid("30392711-0c15-40b6-8b03-9e3232660270"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				TaskSchemaManagerName = @"ProcessUserTaskSchemaManager",
				UseBackgroundMode = false
			};
			InitializeNewOwnerSynchronizeSubjectRemindingParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaScriptTask CreateNewScriptPrepareSynchronizeRemindingsScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("10307809-1e7d-4af7-b2db-4ce4e948355e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e9dc6350-b621-40d0-971c-27b294f57e3b"),
				CreatedInOwnerSchemaUId = new Guid("c732b900-2d9a-4129-96fa-06c57b24c6ea"),
				CreatedInPackageId = new Guid("305fcfca-4160-4398-90a9-d5e84be0ae12"),
				CreatedInSchemaUId = new Guid("2e4ad2a2-869c-48da-b867-91374c625baa"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("2e4ad2a2-869c-48da-b867-91374c625baa"),
				Name = @"NewScriptPrepareSynchronizeRemindings",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(393, 310),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,147,221,78,2,49,16,133,175,37,225,29,144,43,72,204,190,128,63,137,89,149,108,162,171,97,193,251,210,29,97,12,109,113,58,133,172,79,111,75,151,31,141,38,197,187,157,211,153,147,175,167,179,37,108,158,55,26,168,106,180,92,144,209,248,9,149,155,189,131,228,49,40,212,53,234,121,86,216,86,186,131,37,48,244,174,123,247,154,145,27,127,80,232,173,230,187,46,187,157,50,201,235,17,45,127,147,173,55,100,114,144,232,48,105,86,144,139,21,163,209,126,208,50,5,241,193,144,18,60,168,128,214,40,97,12,31,14,44,151,66,193,197,142,117,4,28,38,235,220,44,157,210,175,98,233,224,42,14,223,12,250,165,83,51,160,254,112,152,200,112,43,25,215,33,136,243,255,39,209,10,47,132,74,80,115,132,117,200,247,55,230,145,195,218,19,23,117,63,21,54,55,154,133,100,111,187,235,46,234,84,70,227,72,6,160,189,228,205,44,219,108,95,199,142,211,92,227,215,4,85,112,158,90,32,111,170,125,135,127,209,44,119,68,160,57,168,225,250,109,121,39,24,66,255,32,245,206,85,99,99,134,149,92,128,18,135,72,99,157,77,211,35,136,194,95,27,183,179,120,2,107,197,220,175,91,183,115,118,202,198,165,237,103,11,145,190,160,165,97,124,67,41,2,115,176,245,220,185,176,208,190,222,207,211,227,122,27,12,1,59,210,241,175,252,2,117,205,135,164,34,4,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateIntermediateThrowMessageEvent4IntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("de7d5aff-ef1e-4de2-bbea-1aca03bebcd8"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e9dc6350-b621-40d0-971c-27b294f57e3b"),
				CreatedInOwnerSchemaUId = new Guid("c732b900-2d9a-4129-96fa-06c57b24c6ea"),
				CreatedInPackageId = new Guid("305fcfca-4160-4398-90a9-d5e84be0ae12"),
				CreatedInSchemaUId = new Guid("2e4ad2a2-869c-48da-b867-91374c625baa"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"SynchronizeRemindings",
				ModifiedInSchemaUId = new Guid("2e4ad2a2-869c-48da-b867-91374c625baa"),
				Name = @"IntermediateThrowMessageEvent4",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(120, 44),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage4StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("39414ca4-8f12-4a14-9f96-55552793d9a5"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e9dc6350-b621-40d0-971c-27b294f57e3b"),
				CreatedInOwnerSchemaUId = new Guid("c732b900-2d9a-4129-96fa-06c57b24c6ea"),
				CreatedInPackageId = new Guid("305fcfca-4160-4398-90a9-d5e84be0ae12"),
				CreatedInSchemaUId = new Guid("2e4ad2a2-869c-48da-b867-91374c625baa"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"SynchronizeRemindings",
				ModifiedInSchemaUId = new Guid("2e4ad2a2-869c-48da-b867-91374c625baa"),
				Name = @"StartMessage4",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(36, 191),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateEmptyScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("db4aa9ae-1774-459b-b980-2fa818185cba"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e9dc6350-b621-40d0-971c-27b294f57e3b"),
				CreatedInOwnerSchemaUId = new Guid("c732b900-2d9a-4129-96fa-06c57b24c6ea"),
				CreatedInPackageId = new Guid("305fcfca-4160-4398-90a9-d5e84be0ae12"),
				CreatedInSchemaUId = new Guid("2e4ad2a2-869c-48da-b867-91374c625baa"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("2e4ad2a2-869c-48da-b867-91374c625baa"),
				Name = @"EmptyScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(666, 177),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,40,41,42,77,181,6,0,0,22,62,211,12,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGateway1ExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("25b3a2b3-1b9d-4e6b-a42a-d73683447b25"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e9dc6350-b621-40d0-971c-27b294f57e3b"),
				CreatedInOwnerSchemaUId = new Guid("c732b900-2d9a-4129-96fa-06c57b24c6ea"),
				CreatedInPackageId = new Guid("305fcfca-4160-4398-90a9-d5e84be0ae12"),
				CreatedInSchemaUId = new Guid("2e4ad2a2-869c-48da-b867-91374c625baa"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("2e4ad2a2-869c-48da-b867-91374c625baa"),
				Name = @"ExclusiveGateway1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(113, 177),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage5StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("b02d6fc6-2f15-4205-8852-288ad6387947"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e9dc6350-b621-40d0-971c-27b294f57e3b"),
				CreatedInOwnerSchemaUId = new Guid("c732b900-2d9a-4129-96fa-06c57b24c6ea"),
				CreatedInPackageId = new Guid("c3c90037-274c-4793-841e-197eb228d3cd"),
				CreatedInSchemaUId = new Guid("2e4ad2a2-869c-48da-b867-91374c625baa"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"CaseValidating",
				ModifiedInSchemaUId = new Guid("2e4ad2a2-869c-48da-b867-91374c625baa"),
				Name = @"StartMessage5",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(50, 429),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateCaseValidatingScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("3c19423a-d705-48e0-a38a-f6859ba5b636"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e9dc6350-b621-40d0-971c-27b294f57e3b"),
				CreatedInOwnerSchemaUId = new Guid("c732b900-2d9a-4129-96fa-06c57b24c6ea"),
				CreatedInPackageId = new Guid("c3c90037-274c-4793-841e-197eb228d3cd"),
				CreatedInSchemaUId = new Guid("2e4ad2a2-869c-48da-b867-91374c625baa"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("2e4ad2a2-869c-48da-b867-91374c625baa"),
				Name = @"CaseValidatingScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(156, 415),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,82,221,106,194,48,20,190,174,224,59,28,115,33,41,72,94,64,58,112,93,25,130,211,49,157,187,206,218,211,46,44,77,75,146,58,221,244,221,151,166,133,129,221,22,114,145,156,124,231,251,57,68,228,64,19,101,133,61,177,123,180,241,27,87,5,102,113,37,155,82,237,185,108,208,208,144,45,212,137,166,16,221,140,71,65,64,105,202,214,188,68,136,34,32,91,110,133,201,121,106,69,165,86,120,64,185,204,8,76,167,144,178,141,204,124,59,76,34,119,243,199,16,218,254,243,25,254,101,136,171,178,68,101,137,7,59,170,9,221,90,45,84,193,150,102,221,72,185,209,73,89,91,103,231,71,129,27,48,30,18,182,210,127,160,175,161,126,193,151,19,17,57,157,60,27,212,113,165,20,122,31,236,238,118,139,105,163,221,76,18,85,8,133,126,50,92,37,71,87,181,184,169,81,243,22,71,137,43,118,19,139,185,193,65,20,210,43,4,157,38,28,184,20,153,239,124,64,99,120,129,59,60,90,136,64,225,7,172,170,212,189,126,242,87,137,93,2,122,229,233,165,210,239,166,230,41,178,39,52,85,163,83,135,171,180,35,153,181,10,1,105,29,60,186,43,153,1,25,144,25,54,48,183,19,117,55,20,18,206,91,134,254,15,236,175,61,26,182,200,50,234,53,90,159,29,108,128,234,114,6,65,159,232,215,164,30,113,233,212,52,218,70,43,200,185,52,216,22,46,227,145,219,125,213,234,6,231,223,211,255,60,192,152,2,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess2EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess2 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("c60cd728-87a7-4489-bcc4-1662b51c8f74"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("151b65ad-df20-4b28-955f-7f5e129bd65d"),
				CreatedInOwnerSchemaUId = new Guid("c732b900-2d9a-4129-96fa-06c57b24c6ea"),
				CreatedInPackageId = new Guid("305fcfca-4160-4398-90a9-d5e84be0ae12"),
				CreatedInSchemaUId = new Guid("2e4ad2a2-869c-48da-b867-91374c625baa"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("2e4ad2a2-869c-48da-b867-91374c625baa"),
				Name = @"EventSubProcess2",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(36, 555),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(344, 275),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess2;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage2StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("575fdd36-3e2c-4ccc-91e0-965fec1451d4"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c60cd728-87a7-4489-bcc4-1662b51c8f74"),
				CreatedInOwnerSchemaUId = new Guid("c732b900-2d9a-4129-96fa-06c57b24c6ea"),
				CreatedInPackageId = new Guid("305fcfca-4160-4398-90a9-d5e84be0ae12"),
				CreatedInSchemaUId = new Guid("2e4ad2a2-869c-48da-b867-91374c625baa"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"CaseDeleting",
				ModifiedInSchemaUId = new Guid("2e4ad2a2-869c-48da-b867-91374c625baa"),
				Name = @"StartMessage2",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(42, 70),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage3StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("b089b5d0-c1c7-462d-b3b4-22378f8cfce8"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c60cd728-87a7-4489-bcc4-1662b51c8f74"),
				CreatedInOwnerSchemaUId = new Guid("c732b900-2d9a-4129-96fa-06c57b24c6ea"),
				CreatedInPackageId = new Guid("305fcfca-4160-4398-90a9-d5e84be0ae12"),
				CreatedInSchemaUId = new Guid("2e4ad2a2-869c-48da-b867-91374c625baa"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"CaseSaving",
				ModifiedInSchemaUId = new Guid("2e4ad2a2-869c-48da-b867-91374c625baa"),
				Name = @"StartMessage3",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(43, 191),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateCaseSavingScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("b3f7a8a0-9776-4556-97ae-b15ebe58306e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c60cd728-87a7-4489-bcc4-1662b51c8f74"),
				CreatedInOwnerSchemaUId = new Guid("c732b900-2d9a-4129-96fa-06c57b24c6ea"),
				CreatedInPackageId = new Guid("305fcfca-4160-4398-90a9-d5e84be0ae12"),
				CreatedInSchemaUId = new Guid("2e4ad2a2-869c-48da-b867-91374c625baa"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("2e4ad2a2-869c-48da-b867-91374c625baa"),
				Name = @"CaseSavingScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(127, 177),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,93,142,65,10,194,48,16,69,215,45,244,14,161,139,146,108,122,129,226,66,74,149,238,138,197,3,196,250,213,64,77,203,204,4,21,241,238,198,133,80,221,13,127,222,231,191,30,210,209,52,128,185,179,100,175,16,16,107,83,101,169,59,233,150,123,177,18,184,190,88,127,198,81,55,94,156,60,140,42,10,181,103,80,61,121,143,65,220,228,203,45,164,229,13,34,76,104,188,61,140,145,206,107,203,216,133,17,235,121,30,29,40,55,70,61,179,52,249,139,21,45,238,149,242,184,169,63,66,255,142,125,228,146,69,169,108,238,24,130,224,171,23,223,175,44,37,68,23,175,132,2,170,55,39,24,236,211,228,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateIntermediateThrowMessageEvent5IntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("f0926220-9df1-41a6-89a5-0212529dd0e8"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c60cd728-87a7-4489-bcc4-1662b51c8f74"),
				CreatedInOwnerSchemaUId = new Guid("c732b900-2d9a-4129-96fa-06c57b24c6ea"),
				CreatedInPackageId = new Guid("305fcfca-4160-4398-90a9-d5e84be0ae12"),
				CreatedInSchemaUId = new Guid("2e4ad2a2-869c-48da-b867-91374c625baa"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"SynchronizeRemindings",
				ModifiedInSchemaUId = new Guid("2e4ad2a2-869c-48da-b867-91374c625baa"),
				Name = @"IntermediateThrowMessageEvent5",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(267, 67),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateSetProcessParametersScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("7d1ffbbc-421d-4b33-99c0-2c3e68e755ff"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c60cd728-87a7-4489-bcc4-1662b51c8f74"),
				CreatedInOwnerSchemaUId = new Guid("c732b900-2d9a-4129-96fa-06c57b24c6ea"),
				CreatedInPackageId = new Guid("305fcfca-4160-4398-90a9-d5e84be0ae12"),
				CreatedInSchemaUId = new Guid("2e4ad2a2-869c-48da-b867-91374c625baa"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("2e4ad2a2-869c-48da-b867-91374c625baa"),
				Name = @"SetProcessParametersScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(127, 53),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,78,45,9,40,202,79,78,45,46,14,72,44,74,204,77,45,73,45,42,214,208,180,230,229,42,74,45,41,45,202,83,40,41,42,77,181,6,0,62,217,32,75,37,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess3EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess3 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("d17bc44d-05ce-41a4-b6db-f9e9eccea1cd"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("151b65ad-df20-4b28-955f-7f5e129bd65d"),
				CreatedInOwnerSchemaUId = new Guid("c732b900-2d9a-4129-96fa-06c57b24c6ea"),
				CreatedInPackageId = new Guid("7f95598d-e92c-4476-951a-e2d14090dd62"),
				CreatedInSchemaUId = new Guid("2e4ad2a2-869c-48da-b867-91374c625baa"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("2e4ad2a2-869c-48da-b867-91374c625baa"),
				Name = @"EventSubProcess3",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(392, 556),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(802, 273),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess3;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateCaseInsertingStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("b98917cf-2f76-4258-b9b8-d955cfd80800"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d17bc44d-05ce-41a4-b6db-f9e9eccea1cd"),
				CreatedInOwnerSchemaUId = new Guid("c732b900-2d9a-4129-96fa-06c57b24c6ea"),
				CreatedInPackageId = new Guid("7f95598d-e92c-4476-951a-e2d14090dd62"),
				CreatedInSchemaUId = new Guid("2e4ad2a2-869c-48da-b867-91374c625baa"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"CaseInserting",
				ModifiedInSchemaUId = new Guid("2e4ad2a2-869c-48da-b867-91374c625baa"),
				Name = @"CaseInsertingStartMessage",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(21, 88),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateNeedGenerateExclusiveGatewayExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("d220fa56-b3b1-4e4e-af86-7af24cfe9041"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d17bc44d-05ce-41a4-b6db-f9e9eccea1cd"),
				CreatedInOwnerSchemaUId = new Guid("c732b900-2d9a-4129-96fa-06c57b24c6ea"),
				CreatedInPackageId = new Guid("5cde2e00-3a14-4cc5-9d2d-f1cd6c0c33c5"),
				CreatedInSchemaUId = new Guid("2e4ad2a2-869c-48da-b867-91374c625baa"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("2e4ad2a2-869c-48da-b867-91374c625baa"),
				Name = @"NeedGenerateExclusiveGateway",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(173, 74),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGateway2ExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("f99ca610-4bc6-4ea5-814c-68852f20e20b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d17bc44d-05ce-41a4-b6db-f9e9eccea1cd"),
				CreatedInOwnerSchemaUId = new Guid("c732b900-2d9a-4129-96fa-06c57b24c6ea"),
				CreatedInPackageId = new Guid("677baab4-893e-4898-b508-38190fd135a7"),
				CreatedInSchemaUId = new Guid("2e4ad2a2-869c-48da-b867-91374c625baa"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("2e4ad2a2-869c-48da-b867-91374c625baa"),
				Name = @"ExclusiveGateway2",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(267, 74),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaScriptTask CreateSetNumberScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("c87893b2-1b9c-4691-a509-d3f6f9e5631f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d17bc44d-05ce-41a4-b6db-f9e9eccea1cd"),
				CreatedInOwnerSchemaUId = new Guid("c732b900-2d9a-4129-96fa-06c57b24c6ea"),
				CreatedInPackageId = new Guid("7f95598d-e92c-4476-951a-e2d14090dd62"),
				CreatedInSchemaUId = new Guid("2e4ad2a2-869c-48da-b867-91374c625baa"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("2e4ad2a2-869c-48da-b867-91374c625baa"),
				Name = @"SetNumberScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(419, 75),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,115,205,43,201,44,169,212,11,78,206,72,205,77,212,243,75,204,77,85,176,85,80,114,78,44,78,85,178,230,229,114,79,205,75,45,74,44,73,245,43,205,77,74,45,10,45,78,45,10,73,44,206,214,115,5,107,130,232,1,42,119,69,54,3,168,171,40,181,164,180,40,79,161,164,168,52,213,26,0,97,97,90,166,96,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaScriptTask CreateSetGeneratedNumberScriptScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("3f9056e8-5ead-4880-bd13-c030019ec8f8"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d17bc44d-05ce-41a4-b6db-f9e9eccea1cd"),
				CreatedInOwnerSchemaUId = new Guid("c732b900-2d9a-4129-96fa-06c57b24c6ea"),
				CreatedInPackageId = new Guid("7f95598d-e92c-4476-951a-e2d14090dd62"),
				CreatedInSchemaUId = new Guid("2e4ad2a2-869c-48da-b867-91374c625baa"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("2e4ad2a2-869c-48da-b867-91374c625baa"),
				Name = @"SetGeneratedNumberScript",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(688, 75),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,45,142,187,10,2,49,20,68,107,3,251,15,113,171,4,36,63,176,88,201,34,54,43,248,234,163,94,37,152,68,185,143,98,17,255,221,24,183,156,97,206,97,136,49,228,187,190,60,175,160,151,154,106,114,125,122,241,216,53,106,106,215,144,1,61,195,32,233,12,120,36,192,131,167,135,219,1,73,228,85,217,148,105,184,153,249,68,111,104,144,24,183,88,45,230,231,176,86,191,27,53,235,51,7,30,221,30,10,20,37,229,147,143,2,166,253,107,219,69,61,97,139,235,211,40,4,22,204,154,81,160,251,2,168,231,62,209,163,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaUserTask CreateGenerateNumberUserTaskUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("a12485ee-3852-431a-9e82-0ba099749841"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d17bc44d-05ce-41a4-b6db-f9e9eccea1cd"),
				CreatedInOwnerSchemaUId = new Guid("c732b900-2d9a-4129-96fa-06c57b24c6ea"),
				CreatedInPackageId = new Guid("7f95598d-e92c-4476-951a-e2d14090dd62"),
				CreatedInSchemaUId = new Guid("2e4ad2a2-869c-48da-b867-91374c625baa"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("2e4ad2a2-869c-48da-b867-91374c625baa"),
				Name = @"GenerateNumberUserTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(548, 75),
				SchemaUId = new Guid("b9b23348-b89c-4836-8c5b-283ef5ed8666"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				TaskSchemaManagerName = @"ProcessUserTaskSchemaManager",
				UseBackgroundMode = false
			};
			InitializeGenerateNumberUserTaskParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaScriptTask CreateSetPortalNumberScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("b98e3401-639c-4df5-a402-4214ccb8edbe"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d17bc44d-05ce-41a4-b6db-f9e9eccea1cd"),
				CreatedInOwnerSchemaUId = new Guid("c732b900-2d9a-4129-96fa-06c57b24c6ea"),
				CreatedInPackageId = new Guid("677baab4-893e-4898-b508-38190fd135a7"),
				CreatedInSchemaUId = new Guid("2e4ad2a2-869c-48da-b867-91374c625baa"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("2e4ad2a2-869c-48da-b867-91374c625baa"),
				Name = @"SetPortalNumberScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(411, 176),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,82,193,110,194,48,12,61,15,169,255,144,245,84,36,148,31,64,59,76,85,133,184,20,164,194,238,161,117,33,91,147,116,142,51,134,166,253,251,146,182,76,48,181,59,69,118,158,223,179,159,157,105,146,116,225,69,121,2,37,120,46,20,176,39,22,167,194,66,188,140,102,150,80,234,35,43,77,21,210,125,196,51,213,210,197,127,126,8,100,246,98,9,212,222,2,166,70,107,40,73,26,237,145,247,9,254,220,182,55,81,49,82,51,208,29,65,3,10,130,220,169,3,96,128,236,132,125,243,132,209,236,65,195,153,237,0,81,88,83,19,79,13,2,223,162,41,193,90,31,232,90,30,157,175,12,252,171,129,164,128,119,7,218,254,33,75,198,90,158,123,253,113,109,158,117,6,245,254,248,70,178,91,191,166,171,246,235,202,131,87,78,86,60,135,115,120,147,127,52,54,103,159,246,120,58,73,59,141,186,46,167,0,218,26,36,209,244,255,69,137,178,165,128,200,62,161,116,212,45,110,216,216,4,211,184,67,201,221,108,139,209,221,134,33,100,157,60,14,167,176,182,185,107,154,13,118,39,145,4,209,249,156,125,249,101,93,169,128,82,211,56,165,95,68,227,32,137,123,161,120,209,93,84,224,250,142,102,191,227,132,163,43,220,225,213,43,117,102,33,144,67,205,8,29,44,127,0,240,1,50,127,167,2,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaTerminateEvent CreateTerminate1TerminateEvent() {
			ProcessSchemaTerminateEvent schemaTerminateEvent = new ProcessSchemaTerminateEvent(this) {
				UId = new Guid("4886fa94-41d9-4422-bd9c-a271ab80a0b2"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d17bc44d-05ce-41a4-b6db-f9e9eccea1cd"),
				CreatedInOwnerSchemaUId = new Guid("c732b900-2d9a-4129-96fa-06c57b24c6ea"),
				CreatedInPackageId = new Guid("5cc48622-4103-4a13-8edf-d5dc889f11f2"),
				CreatedInSchemaUId = new Guid("2e4ad2a2-869c-48da-b867-91374c625baa"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = false,
				ManagerItemUId = new Guid("1bd93619-0574-454e-bb4e-cf53b9eb9470"),
				ModifiedInSchemaUId = new Guid("2e4ad2a2-869c-48da-b867-91374c625baa"),
				Name = @"Terminate1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(267, 18),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaTerminateEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateSetSymptomsScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("f233228e-9fb3-4a6a-8328-765813405eda"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d17bc44d-05ce-41a4-b6db-f9e9eccea1cd"),
				CreatedInOwnerSchemaUId = new Guid("c732b900-2d9a-4129-96fa-06c57b24c6ea"),
				CreatedInPackageId = new Guid("c2657f9d-1b86-4f69-b0c1-b23085f13744"),
				CreatedInSchemaUId = new Guid("2e4ad2a2-869c-48da-b867-91374c625baa"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("2e4ad2a2-869c-48da-b867-91374c625baa"),
				Name = @"SetSymptomsScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(83, 74),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,203,76,211,40,46,41,202,204,75,215,243,44,246,43,205,201,241,47,114,205,45,40,169,212,112,205,43,201,44,169,212,115,79,45,9,169,44,72,77,113,206,207,41,205,205,11,75,204,41,77,181,129,168,183,211,80,10,174,4,42,205,207,45,86,210,212,212,84,168,230,82,40,75,44,82,40,46,77,202,74,77,46,81,176,85,32,202,4,136,106,37,77,107,46,152,250,224,212,18,36,165,72,150,232,192,204,6,42,174,229,42,74,45,41,45,202,83,40,41,42,77,181,6,0,226,31,171,76,196,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateSetProcessParametersMethod());
			Methods.Add(CreateSetPortalCaseSubjectMethod());
			Methods.Add(CreateGetServiceCaptionMethod());
			Methods.Add(CreateGetCaseGategoryCaptionMethod());
			Methods.Add(CreateIsStatusChangedMethod());
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

		protected virtual SchemaMethod CreateSetProcessParametersMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("9836fe77-75e4-4eef-855a-a6a36b521f53"),
				Name = "SetProcessParameters",
				CreatedInSchemaUId = new Guid("2e4ad2a2-869c-48da-b867-91374c625baa"),
				CreatedInPackageId = new Guid("305fcfca-4160-4398-90a9-d5e84be0ae12"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,143,177,14,130,48,16,134,119,158,162,50,16,93,250,2,136,11,33,132,5,18,69,247,134,222,208,4,174,164,92,33,188,189,84,69,81,212,177,119,223,255,253,215,94,24,86,89,99,0,41,214,72,162,162,76,178,136,157,59,48,211,27,161,34,165,145,199,119,194,77,249,19,11,189,28,134,98,64,48,183,72,130,164,104,228,41,80,57,182,32,99,93,219,6,47,162,182,176,79,173,146,135,173,255,96,253,93,232,21,181,252,153,156,118,255,195,89,151,3,200,19,160,60,66,163,208,41,22,151,108,34,246,178,135,158,195,74,61,79,216,114,233,208,213,223,131,224,131,112,253,60,105,90,26,103,217,92,182,234,253,38,123,39,22,178,43,55,176,224,203,122,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSetPortalCaseSubjectMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("0f289d94-47bb-47ff-8eca-1b45d9cd178e"),
				Name = "SetPortalCaseSubject",
				CreatedInSchemaUId = new Guid("2e4ad2a2-869c-48da-b867-91374c625baa"),
				CreatedInPackageId = new Guid("c3c90037-274c-4793-841e-197eb228d3cd"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,82,203,106,132,48,20,93,215,175,200,184,138,32,210,199,174,211,105,161,50,149,217,76,23,41,221,71,77,37,37,38,146,135,32,226,191,247,142,102,70,157,66,233,34,144,220,123,207,35,39,105,169,70,198,229,223,172,176,104,135,246,210,114,219,37,25,179,31,93,195,202,84,9,87,203,79,42,28,123,50,86,115,89,61,227,144,76,211,97,180,69,1,255,66,120,51,117,146,131,57,58,33,222,245,190,110,108,135,61,103,20,161,62,184,209,204,58,45,183,193,16,180,32,39,93,157,51,253,79,181,227,56,60,138,157,176,5,181,172,82,186,59,148,127,227,51,199,75,64,167,151,113,96,88,17,164,180,177,92,73,96,1,120,74,13,203,214,13,60,43,121,100,190,192,44,108,108,118,232,4,79,149,52,214,36,227,214,55,9,211,45,47,224,40,4,204,189,32,31,220,107,71,198,203,161,199,115,229,77,233,169,52,9,153,51,110,225,144,172,106,216,91,170,152,100,26,212,74,114,121,65,255,24,64,89,83,139,195,254,118,64,253,29,172,123,88,15,3,10,99,31,127,124,157,68,60,95,48,190,178,0,106,62,106,2,89,205,41,207,127,33,254,101,5,48,63,121,162,136,1,91,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetServiceCaptionMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("bc8f6aac-4eb6-47fe-99dd-4d8202b29159"),
				Name = "GetServiceCaption",
				CreatedInSchemaUId = new Guid("2e4ad2a2-869c-48da-b867-91374c625baa"),
				CreatedInPackageId = new Guid("c3c90037-274c-4793-841e-197eb228d3cd"),
				ResultValueTypeName = "string"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,40,46,41,202,204,75,215,115,205,45,40,169,180,86,0,0,173,78,104,227,21,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetCaseGategoryCaptionMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("7b74c14e-ac7a-4eb8-9c16-9f529c0ed4e3"),
				Name = "GetCaseGategoryCaption",
				CreatedInSchemaUId = new Guid("2e4ad2a2-869c-48da-b867-91374c625baa"),
				CreatedInPackageId = new Guid("c3c90037-274c-4793-841e-197eb228d3cd"),
				ResultValueTypeName = "string"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("07e6b900-b546-4b24-8b30-b9d5fe2ab674"),
				Name = "categoryId",
				CreatedInSchemaUId = new Guid("2e4ad2a2-869c-48da-b867-91374c625baa"),
				ModifiedInSchemaUId = new Guid("2e4ad2a2-869c-48da-b867-91374c625baa"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("c3c90037-274c-4793-841e-197eb228d3cd")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,93,143,219,10,130,64,16,134,175,243,41,6,175,20,196,23,232,0,33,18,93,20,68,135,251,65,39,19,118,71,89,119,141,37,122,247,182,180,212,110,103,254,249,191,111,90,84,144,161,166,162,82,246,96,72,89,88,2,211,29,82,214,165,182,199,236,70,18,63,243,224,220,144,74,42,102,202,116,89,113,60,14,236,144,177,32,21,129,159,96,67,73,95,231,135,115,111,82,29,175,243,60,169,132,145,28,248,123,148,228,2,224,181,35,1,199,158,186,196,27,210,29,232,15,31,253,130,219,220,97,202,107,48,116,184,7,140,16,33,60,188,153,34,109,20,67,163,85,201,69,156,202,90,91,135,124,130,215,47,190,71,111,206,201,214,212,235,93,80,24,90,116,87,171,193,245,5,129,229,40,131,44,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateIsStatusChangedMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("c273b8e8-eb20-4940-ab06-62cdaa947531"),
				Name = "IsStatusChanged",
				CreatedInSchemaUId = new Guid("2e4ad2a2-869c-48da-b867-91374c625baa"),
				CreatedInPackageId = new Guid("c3c90037-274c-4793-841e-197eb228d3cd"),
				ResultValueTypeName = "bool"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("3bb709f3-4b60-4fe0-9da6-0f95e608d679"),
				Name = "entity",
				CreatedInSchemaUId = new Guid("2e4ad2a2-869c-48da-b867-91374c625baa"),
				ModifiedInSchemaUId = new Guid("2e4ad2a2-869c-48da-b867-91374c625baa"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Entity",
				CreatedInPackageId = new Guid("c3c90037-274c-4793-841e-197eb228d3cd")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,115,47,205,76,177,87,40,75,204,41,77,85,176,85,72,205,43,201,44,169,212,115,79,45,9,169,44,72,77,113,206,207,41,205,205,11,3,73,218,184,3,21,218,105,40,5,151,36,150,148,22,123,166,40,105,90,243,114,185,131,53,231,231,164,132,97,215,239,159,67,208,136,162,212,146,210,162,60,5,13,13,136,19,20,109,21,242,74,115,114,52,21,212,212,20,20,193,66,122,174,133,165,137,57,197,26,48,91,52,53,21,106,106,120,185,56,97,58,108,145,116,192,93,2,51,198,26,0,46,81,111,16,223,0,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new Case_Case_TerrasoftEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("2e4ad2a2-869c-48da-b867-91374c625baa"));
		}

		#endregion

	}

	#endregion

}

