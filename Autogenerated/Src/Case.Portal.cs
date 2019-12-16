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
	using Terrasoft.Configuration.RightsService;
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

	#region Class: Case_Portal_TerrasoftSchema

	/// <exclude/>
	public class Case_Portal_TerrasoftSchema : Terrasoft.Configuration.Case_SLMITILService_TerrasoftSchema
	{

		#region Constructors: Public

		public Case_Portal_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public Case_Portal_TerrasoftSchema(Case_Portal_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public Case_Portal_TerrasoftSchema(Case_Portal_TerrasoftSchema source)
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
			RealUId = new Guid("eb77295e-ed97-455b-9789-b59e647eaff4");
			Name = "Case_Portal_Terrasoft";
			ParentSchemaUId = new Guid("117d32f9-8275-4534-8411-1c66115ce9cd");
			ExtendParent = true;
			CreatedInPackageId = new Guid("45ba80cd-f9d9-41f0-bc12-0d4745b932db");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
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
			EventsProcessSchema = CreateCase_Portal_TerrasoftEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateCase_Portal_TerrasoftEventsProcessSchema() {
			var schema = new Case_Portal_TerrasoftEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new Case_Portal_Terrasoft(userConnection){Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new Case_PortalEventsProcess(userConnnection);
		}

		public override object Clone() {
			return new Case_Portal_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new Case_Portal_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("eb77295e-ed97-455b-9789-b59e647eaff4"));
		}

		#endregion

	}

	#endregion

	#region Class: Case_Portal_Terrasoft

	/// <summary>
	/// Case.
	/// </summary>
	public class Case_Portal_Terrasoft : Terrasoft.Configuration.Case_SLMITILService_Terrasoft
	{

		#region Constructors: Public

		public Case_Portal_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Case_Portal_Terrasoft";
		}

		public Case_Portal_Terrasoft(Case_Portal_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new Case_PortalEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Saved += (s, e) => ThrowEvent("Case_Portal_TerrasoftSaved", e);
			Saving += (s, e) => ThrowEvent("Case_Portal_TerrasoftSaving", e);
			Validating += (s, e) => ThrowEvent("Case_Portal_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new Case_Portal_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: Case_PortalEventsProcess

	/// <exclude/>
	public class Case_PortalEventsProcess<TEntity> : Terrasoft.Configuration.Case_SLMITILServiceEventsProcess<TEntity> where TEntity : Case_Portal_Terrasoft
	{

		public Case_PortalEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Case_PortalEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private  Guid InternalSchemaUId {
			get {
				return new Guid("eb77295e-ed97-455b-9789-b59e647eaff4");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		public  virtual Guid OldContactId {
			get;
			set;
		}

		private ProcessFlowElement _eventSubProcess4;
		public  ProcessFlowElement EventSubProcess4 {
			get {
				return _eventSubProcess4 ?? (_eventSubProcess4 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess4",
					SchemaElementUId = new Guid("6aa29e17-158b-418e-90ba-40126fef7dfe"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessage6;
		public  ProcessFlowElement StartMessage6 {
			get {
				return _startMessage6 ?? (_startMessage6 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessage6",
					SchemaElementUId = new Guid("61adac11-e0ce-400f-bc57-4a4e533e616c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessThrowMessageEvent _intermediateThrowMessageEvent1;
		public  ProcessThrowMessageEvent IntermediateThrowMessageEvent1 {
			get {
				return _intermediateThrowMessageEvent1 ?? (_intermediateThrowMessageEvent1 = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "IntermediateThrowMessageEvent1",
					SchemaElementUId = new Guid("55a59700-b6f2-45c2-95ac-36428422953e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "CaseInserting",
						ThrowToBase = true,
				});
			}
		}

		private ProcessScriptTask _setEmptyOwnerScriptTask;
		public  ProcessScriptTask SetEmptyOwnerScriptTask {
			get {
				return _setEmptyOwnerScriptTask ?? (_setEmptyOwnerScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "SetEmptyOwnerScriptTask",
					SchemaElementUId = new Guid("1c39d39d-39de-47ef-8787-2d7e3152c6dc"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = SetEmptyOwnerScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcess5;
		public  ProcessFlowElement EventSubProcess5 {
			get {
				return _eventSubProcess5 ?? (_eventSubProcess5 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess5",
					SchemaElementUId = new Guid("1782e20a-cce0-442f-a0ac-832bdf976ccc"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _caseSavedStartMessage;
		public  ProcessFlowElement CaseSavedStartMessage {
			get {
				return _caseSavedStartMessage ?? (_caseSavedStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "CaseSavedStartMessage",
					SchemaElementUId = new Guid("b461cd29-d3f1-4ce2-af6d-f94f62f5c037"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessThrowMessageEvent _baseCaseSaved;
		public  ProcessThrowMessageEvent BaseCaseSaved {
			get {
				return _baseCaseSaved ?? (_baseCaseSaved = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "BaseCaseSaved",
					SchemaElementUId = new Guid("5ee06747-a8ce-4fff-af35-7b652461e7af"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "CaseSaved",
						ThrowToBase = true,
				});
			}
		}

		private ProcessScriptTask _caseSavedScriptTask;
		public  ProcessScriptTask CaseSavedScriptTask {
			get {
				return _caseSavedScriptTask ?? (_caseSavedScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "CaseSavedScriptTask",
					SchemaElementUId = new Guid("609094a6-78ca-474b-8128-cbc58d434eef"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = CaseSavedScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcess6;
		public  ProcessFlowElement EventSubProcess6 {
			get {
				return _eventSubProcess6 ?? (_eventSubProcess6 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess6",
					SchemaElementUId = new Guid("907a17e3-36ea-4f4a-9a02-1e31adfa6f1c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _caseSavingStartMessage;
		public  ProcessFlowElement CaseSavingStartMessage {
			get {
				return _caseSavingStartMessage ?? (_caseSavingStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "CaseSavingStartMessage",
					SchemaElementUId = new Guid("07851372-07b8-4613-94cd-a3544cb65205"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessThrowMessageEvent _baseCaseSaving;
		public  ProcessThrowMessageEvent BaseCaseSaving {
			get {
				return _baseCaseSaving ?? (_baseCaseSaving = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "BaseCaseSaving",
					SchemaElementUId = new Guid("cb6c74a4-240c-4bf3-b1bb-054813817120"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "CaseSaving",
						ThrowToBase = true,
				});
			}
		}

		private ProcessScriptTask _portalCaseSavingScriptTask;
		public  ProcessScriptTask PortalCaseSavingScriptTask {
			get {
				return _portalCaseSavingScriptTask ?? (_portalCaseSavingScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "PortalCaseSavingScriptTask",
					SchemaElementUId = new Guid("fe7ac697-80e2-4a92-a45b-96e7b8eb6115"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = PortalCaseSavingScriptTaskExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess4.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess4 };
			FlowElements[StartMessage6.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage6 };
			FlowElements[IntermediateThrowMessageEvent1.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowMessageEvent1 };
			FlowElements[SetEmptyOwnerScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { SetEmptyOwnerScriptTask };
			FlowElements[EventSubProcess5.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess5 };
			FlowElements[CaseSavedStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { CaseSavedStartMessage };
			FlowElements[BaseCaseSaved.SchemaElementUId] = new Collection<ProcessFlowElement> { BaseCaseSaved };
			FlowElements[CaseSavedScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { CaseSavedScriptTask };
			FlowElements[EventSubProcess6.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess6 };
			FlowElements[CaseSavingStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { CaseSavingStartMessage };
			FlowElements[BaseCaseSaving.SchemaElementUId] = new Collection<ProcessFlowElement> { BaseCaseSaving };
			FlowElements[PortalCaseSavingScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { PortalCaseSavingScriptTask };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess4":
						break;
					case "StartMessage6":
						e.Context.QueueTasks.Enqueue("IntermediateThrowMessageEvent1");
						break;
					case "IntermediateThrowMessageEvent1":
						e.Context.QueueTasks.Enqueue("SetEmptyOwnerScriptTask");
						break;
					case "SetEmptyOwnerScriptTask":
						break;
					case "EventSubProcess5":
						break;
					case "CaseSavedStartMessage":
						e.Context.QueueTasks.Enqueue("BaseCaseSaved");
						break;
					case "BaseCaseSaved":
						e.Context.QueueTasks.Enqueue("CaseSavedScriptTask");
						break;
					case "CaseSavedScriptTask":
						break;
					case "EventSubProcess6":
						break;
					case "CaseSavingStartMessage":
						e.Context.QueueTasks.Enqueue("BaseCaseSaving");
						break;
					case "BaseCaseSaving":
						e.Context.QueueTasks.Enqueue("PortalCaseSavingScriptTask");
						break;
					case "PortalCaseSavingScriptTask":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("StartMessage6");
			ActivatedEventElements.Add("CaseSavedStartMessage");
			ActivatedEventElements.Add("CaseSavingStartMessage");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "EventSubProcess4":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage6":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage6";
					result = StartMessage6.Execute(context);
					break;
				case "IntermediateThrowMessageEvent1":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "CaseInserting");
					result = IntermediateThrowMessageEvent1.Execute(context);
					break;
				case "SetEmptyOwnerScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "SetEmptyOwnerScriptTask";
					result = SetEmptyOwnerScriptTask.Execute(context, SetEmptyOwnerScriptTaskExecute);
					break;
				case "EventSubProcess5":
					context.QueueTasks.Dequeue();
					break;
				case "CaseSavedStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "CaseSavedStartMessage";
					result = CaseSavedStartMessage.Execute(context);
					break;
				case "BaseCaseSaved":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "CaseSaved");
					result = BaseCaseSaved.Execute(context);
					break;
				case "CaseSavedScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "CaseSavedScriptTask";
					result = CaseSavedScriptTask.Execute(context, CaseSavedScriptTaskExecute);
					break;
				case "EventSubProcess6":
					context.QueueTasks.Dequeue();
					break;
				case "CaseSavingStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "CaseSavingStartMessage";
					result = CaseSavingStartMessage.Execute(context);
					break;
				case "BaseCaseSaving":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "CaseSaving");
					result = BaseCaseSaving.Execute(context);
					break;
				case "PortalCaseSavingScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "PortalCaseSavingScriptTask";
					result = PortalCaseSavingScriptTask.Execute(context, PortalCaseSavingScriptTaskExecute);
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
				case "OldContactId":
					OldContactId = reader.GetValue<System.Guid>();
				break;
			}
		}

		#endregion

		#region Methods: Public

		public virtual bool SetEmptyOwnerScriptTaskExecute(ProcessExecutingContext context) {
			if (UserConnection.CurrentUser.ConnectionType == UserType.SSP) {
				Entity.SetColumnValue("OwnerId", null);
			}
			return true;
		}

		public virtual bool CaseSavedScriptTaskExecute(ProcessExecutingContext context) {
			bool isUserConnection = UserConnection is SSPUserConnection;
			if(!isUserConnection) {
				SetPortalCaseRights();
			}
			return true;
		}

		public virtual bool PortalCaseSavingScriptTaskExecute(ProcessExecutingContext context) {
			OldContactId = Entity.GetTypedOldColumnValue<Guid>("ContactId");
			return true;
		}

		public virtual Guid GetContactSspUser(Guid ContactId) {
			var select = new Select(UserConnection)
				.Column("Id")
			.From("SysAdminUnit")
			.Where(Func.Upper("ContactId")).IsEqual(Func.Upper(Column.Parameter(ContactId)))
				.And("ConnectionType").IsEqual(Column.Parameter((int)Terrasoft.Core.UserType.SSP)) as Select;
			using (var dbExecutor = UserConnection.EnsureDBConnection()) {
				using (var reader = select.ExecuteReader(dbExecutor)) {
					while (reader.Read()) {
						return Guid.Parse(reader.GetValue(0).ToString());
					}
				}
			}
			return Guid.Empty;
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

		public virtual  Dictionary<Guid, Guid> GetSysAdminUnit(Guid contactId, Guid contactIdOld) {
			Dictionary<Guid, Guid> result = new Dictionary<Guid, Guid>();
			var sysAdminUnitSelect = new Select(UserConnection)
					.Column("Id")
					.Column("ContactId")
					.From("SysAdminUnit")
					.Where("ContactId").IsEqual(Column.Parameter(contactId))
					.Or("ContactId").IsEqual(Column.Parameter(contactIdOld)) as Select;
			using (DBExecutor dbExecutor = UserConnection.EnsureDBConnection()) {
				using (IDataReader dr = sysAdminUnitSelect.ExecuteReader(dbExecutor)) {
					while(dr.Read()){
						result[dr.GetColumnValue<Guid>("ContactId")] = dr.GetColumnValue<Guid>("Id");
					} 
				}
			}
			return result;
		}

		public virtual bool IsResolved(Guid caseStatusId) {
			var IsResolvedSelect = new Select(UserConnection)
					.Column("IsResolved")
					.From("CaseStatus")
					.Where("Id").IsEqual(Column.Parameter(caseStatusId)) as Select;
			using (DBExecutor dbExecutor = UserConnection.EnsureDBConnection()) {
				using (IDataReader dr = IsResolvedSelect.ExecuteReader(dbExecutor)) {
					if(dr.Read()){
						return dr.GetColumnValue<bool>("IsResolved");
					} else {
						return false;
					}
				}
			}
		}

		public virtual void SetPortalCaseRights() {
			Guid contactId = Entity.GetTypedColumnValue<Guid>("ContactId");
			Guid caseStatusId = Entity.GetTypedColumnValue<Guid>("StatusId");
			bool isResolved = IsResolved(caseStatusId);
			bool isContactChanged = contactId != OldContactId;
			var sysAdminUnitIds = GetSysAdminUnit(contactId, OldContactId);
			Guid contactUserId = contactId == Guid.Empty ? Guid.Empty : GetContactSspUser(contactId);
			Guid oldContactUserId = OldContactId == Guid.Empty ? Guid.Empty : GetContactSspUser(OldContactId);
			int read = 0;
			int allow = 1;
			int rightLevel = 2;
			if(isContactChanged) {
				if(oldContactUserId != Guid.Empty && sysAdminUnitIds.ContainsKey(OldContactId)){
					ActualizePortalUsersRights(false, Entity.PrimaryColumnValue, 
							sysAdminUnitIds[OldContactId], read, rightLevel);
				}
				if(contactUserId != Guid.Empty && sysAdminUnitIds.ContainsKey(contactId)){
					ActualizePortalUsersRights(true, Entity.PrimaryColumnValue, 
							sysAdminUnitIds[contactId], read, rightLevel);
				}
			}
			if(sysAdminUnitIds.ContainsKey(contactId) && IsPortalUser(contactId)) {
				if(isResolved) {
					ActualizePortalUsersRights(true, Entity.PrimaryColumnValue, 
							sysAdminUnitIds[contactId], allow, rightLevel);
				} else {
					ActualizePortalUsersRights(false, Entity.PrimaryColumnValue, 
							sysAdminUnitIds[contactId], allow, rightLevel);
				}
			}
		}

		public virtual bool IsPortalUser(Guid contactId) {
			var isPortalUserSelect = new Select(UserConnection)
					.Column("ConnectionType")
					.From("SysAdminUnit")
					.Where("ContactId").IsEqual(Column.Parameter(contactId)) as Select;
			using (DBExecutor dbExecutor = UserConnection.EnsureDBConnection()) {
				using (IDataReader dr = isPortalUserSelect.ExecuteReader(dbExecutor)) {
					if(dr.Read()){
						if (dr.GetColumnValue<int>("ConnectionType") == 1) {
							return true;
						}
						return false;
					}
				}
				return false;
			}
		}

		public virtual void ActualizePortalUsersRights(bool action, Guid recordId, Guid sysAdminUnitId, int operation, int rightLevel) {
			var storedProcedure = new StoredProcedure(UserConnection, "tsp_ActualizePortalUsersRights");
			storedProcedure.WithParameter("Action", action);
			storedProcedure.WithParameter("RecordId", recordId);
			storedProcedure.WithParameter("SysAdminUnitId", sysAdminUnitId);
			storedProcedure.WithParameter("Operation", operation);
			storedProcedure.WithParameter("RightLevel", rightLevel);
			storedProcedure.Execute();
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "CaseInserting":
							if (ActivatedEventElements.Contains("StartMessage6")) {
							context.QueueTasks.Enqueue("StartMessage6");
							ProcessQueue(context);
							return;
						}
						break;
					case "Case_Portal_TerrasoftSaved":
							if (ActivatedEventElements.Contains("CaseSavedStartMessage")) {
							context.QueueTasks.Enqueue("CaseSavedStartMessage");
							ProcessQueue(context);
							return;
							ProcessQueue(context);
							return;
						}
						break;
					case "Case_Portal_TerrasoftSaving":
							if (ActivatedEventElements.Contains("CaseSavingStartMessage")) {
							context.QueueTasks.Enqueue("CaseSavingStartMessage");
							ProcessQueue(context);
							return;
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
			if (!HasMapping("OldContactId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("OldContactId", OldContactId, Guid.Empty);
			}
		}

		public override object CloneShallow() {
			return base.CloneShallow();
		}

		#endregion

	}

	#endregion

	#region Class: Case_PortalEventsProcess

	/// <exclude/>
	public class Case_PortalEventsProcess : Case_PortalEventsProcess<Case_Portal_Terrasoft>
	{

		public Case_PortalEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: Case_Portal_TerrasoftEventsProcessSchema

	/// <exclude/>
	public class Case_Portal_TerrasoftEventsProcessSchema : Terrasoft.Configuration.Case_SLMITILService_TerrasoftEventsProcessSchema
	{

		#region Constructors: Public

		public Case_Portal_TerrasoftEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public Case_Portal_TerrasoftEventsProcessSchema(Case_Portal_TerrasoftEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "Case_PortalEventsProcess";
			UId = new Guid("4ac17888-4773-487c-92ef-2db0b1be4027");
			CreatedInPackageId = new Guid("45ba80cd-f9d9-41f0-bc12-0d4745b932db");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("a77405c5-9e6a-45a8-9f61-7f3e4a635c3f");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
		}

		protected virtual ProcessSchemaParameter CreateOldContactIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("e0485403-d681-4892-a817-9d15ab9af020"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("4ac17888-4773-487c-92ef-2db0b1be4027"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("4ac17888-4773-487c-92ef-2db0b1be4027"),
				Name = @"OldContactId",
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateOldContactIdParameter());
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet2 = CreateLaneSet2LaneSet();
			LaneSets.Add(schemaLaneSet2);
			ProcessSchemaLane schemaLane3 = CreateLane3Lane();
			schemaLaneSet2.Lanes.Add(schemaLane3);
			ProcessSchemaEventSubProcess eventsubprocess4 = CreateEventSubProcess4EventSubProcess();
			FlowElements.Add(eventsubprocess4);
			ProcessSchemaEventSubProcess eventsubprocess5 = CreateEventSubProcess5EventSubProcess();
			FlowElements.Add(eventsubprocess5);
			ProcessSchemaEventSubProcess eventsubprocess6 = CreateEventSubProcess6EventSubProcess();
			FlowElements.Add(eventsubprocess6);
			ProcessSchemaStartMessageEvent startmessage6 = CreateStartMessage6StartMessageEvent();
			eventsubprocess4.FlowElements.Add(startmessage6);
			ProcessSchemaIntermediateThrowMessageEvent intermediatethrowmessageevent1 = CreateIntermediateThrowMessageEvent1IntermediateThrowMessageEvent();
			eventsubprocess4.FlowElements.Add(intermediatethrowmessageevent1);
			ProcessSchemaScriptTask setemptyownerscripttask = CreateSetEmptyOwnerScriptTaskScriptTask();
			eventsubprocess4.FlowElements.Add(setemptyownerscripttask);
			ProcessSchemaStartMessageEvent casesavedstartmessage = CreateCaseSavedStartMessageStartMessageEvent();
			eventsubprocess5.FlowElements.Add(casesavedstartmessage);
			ProcessSchemaIntermediateThrowMessageEvent basecasesaved = CreateBaseCaseSavedIntermediateThrowMessageEvent();
			eventsubprocess5.FlowElements.Add(basecasesaved);
			ProcessSchemaScriptTask casesavedscripttask = CreateCaseSavedScriptTaskScriptTask();
			eventsubprocess5.FlowElements.Add(casesavedscripttask);
			ProcessSchemaStartMessageEvent casesavingstartmessage = CreateCaseSavingStartMessageStartMessageEvent();
			eventsubprocess6.FlowElements.Add(casesavingstartmessage);
			ProcessSchemaIntermediateThrowMessageEvent basecasesaving = CreateBaseCaseSavingIntermediateThrowMessageEvent();
			eventsubprocess6.FlowElements.Add(basecasesaving);
			ProcessSchemaScriptTask portalcasesavingscripttask = CreatePortalCaseSavingScriptTaskScriptTask();
			eventsubprocess6.FlowElements.Add(portalcasesavingscripttask);
			FlowElements.Add(CreateSequenceFlow117SequenceFlow());
			FlowElements.Add(CreateSequenceFlow18SequenceFlow());
			FlowElements.Add(CreateSequenceFlow19SequenceFlow());
			FlowElements.Add(CreateSequenceFlow20SequenceFlow());
			FlowElements.Add(CreateSequenceFlow21SequenceFlow());
			FlowElements.Add(CreateSequenceFlow22SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow117SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow117",
				UId = new Guid("c9343464-be16-4413-8739-bfe175e345c7"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("08d19c3e-cef5-4a07-9fae-18525efc876b"),
				CreatedInPackageId = new Guid("27ba0bc2-2394-44cd-a4ef-abfa585fb8a9"),
				CreatedInSchemaUId = new Guid("4ac17888-4773-487c-92ef-2db0b1be4027"),
				CurveCenterPosition = new Point(188, 91),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("4ac17888-4773-487c-92ef-2db0b1be4027"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("61adac11-e0ce-400f-bc57-4a4e533e616c"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("55a59700-b6f2-45c2-95ac-36428422953e"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow18SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow18",
				UId = new Guid("401f2cfb-d920-4fd6-8487-8a34da2ac1aa"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("08d19c3e-cef5-4a07-9fae-18525efc876b"),
				CreatedInPackageId = new Guid("27ba0bc2-2394-44cd-a4ef-abfa585fb8a9"),
				CreatedInSchemaUId = new Guid("4ac17888-4773-487c-92ef-2db0b1be4027"),
				CurveCenterPosition = new Point(284, 94),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("4ac17888-4773-487c-92ef-2db0b1be4027"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("55a59700-b6f2-45c2-95ac-36428422953e"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("1c39d39d-39de-47ef-8787-2d7e3152c6dc"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow19SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow19",
				UId = new Guid("6569e339-09ab-4dd0-a880-86f8912d7e54"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("08d19c3e-cef5-4a07-9fae-18525efc876b"),
				CreatedInPackageId = new Guid("b54a206c-0c3a-4346-bc7a-d3b009155be5"),
				CreatedInSchemaUId = new Guid("4ac17888-4773-487c-92ef-2db0b1be4027"),
				CurveCenterPosition = new Point(189, 310),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("4ac17888-4773-487c-92ef-2db0b1be4027"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("b461cd29-d3f1-4ce2-af6d-f94f62f5c037"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("5ee06747-a8ce-4fff-af35-7b652461e7af"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow20SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow20",
				UId = new Guid("19ddaf12-d6eb-4346-a834-838ffbefa87b"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("08d19c3e-cef5-4a07-9fae-18525efc876b"),
				CreatedInPackageId = new Guid("b54a206c-0c3a-4346-bc7a-d3b009155be5"),
				CreatedInSchemaUId = new Guid("4ac17888-4773-487c-92ef-2db0b1be4027"),
				CurveCenterPosition = new Point(292, 309),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("4ac17888-4773-487c-92ef-2db0b1be4027"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("5ee06747-a8ce-4fff-af35-7b652461e7af"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("609094a6-78ca-474b-8128-cbc58d434eef"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow21SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow21",
				UId = new Guid("5b5388d6-54b8-4bcf-a928-1460f824d4c7"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("08d19c3e-cef5-4a07-9fae-18525efc876b"),
				CreatedInPackageId = new Guid("b54a206c-0c3a-4346-bc7a-d3b009155be5"),
				CreatedInSchemaUId = new Guid("4ac17888-4773-487c-92ef-2db0b1be4027"),
				CurveCenterPosition = new Point(193, 502),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("4ac17888-4773-487c-92ef-2db0b1be4027"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("07851372-07b8-4613-94cd-a3544cb65205"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("cb6c74a4-240c-4bf3-b1bb-054813817120"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow22SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow22",
				UId = new Guid("a70ba63a-9a5f-410a-9b60-6c86e8fa7680"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("08d19c3e-cef5-4a07-9fae-18525efc876b"),
				CreatedInPackageId = new Guid("b54a206c-0c3a-4346-bc7a-d3b009155be5"),
				CreatedInSchemaUId = new Guid("4ac17888-4773-487c-92ef-2db0b1be4027"),
				CurveCenterPosition = new Point(283, 504),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("4ac17888-4773-487c-92ef-2db0b1be4027"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("cb6c74a4-240c-4bf3-b1bb-054813817120"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("fe7ac697-80e2-4a92-a45b-96e7b8eb6115"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet2LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet2 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("035d6fd4-1f66-4800-96b9-7cbd1ef39aa9"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("08d19c3e-cef5-4a07-9fae-18525efc876b"),
				CreatedInPackageId = new Guid("27ba0bc2-2394-44cd-a4ef-abfa585fb8a9"),
				CreatedInSchemaUId = new Guid("4ac17888-4773-487c-92ef-2db0b1be4027"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("4ac17888-4773-487c-92ef-2db0b1be4027"),
				Name = @"LaneSet2",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(5, 5),
				Size = new Size(1576, 198),
				UseBackgroundMode = false
			};
			return schemaLaneSet2;
		}

		protected virtual ProcessSchemaLane CreateLane3Lane() {
			ProcessSchemaLane schemaLane3 = new ProcessSchemaLane(this) {
				UId = new Guid("e3814424-97a2-492b-80ea-00df3ef74e8c"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("035d6fd4-1f66-4800-96b9-7cbd1ef39aa9"),
				CreatedInOwnerSchemaUId = new Guid("eb77295e-ed97-455b-9789-b59e647eaff4"),
				CreatedInPackageId = new Guid("27ba0bc2-2394-44cd-a4ef-abfa585fb8a9"),
				CreatedInSchemaUId = new Guid("4ac17888-4773-487c-92ef-2db0b1be4027"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("4ac17888-4773-487c-92ef-2db0b1be4027"),
				Name = @"Lane3",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(29, 0),
				Size = new Size(1547, 198),
				UseBackgroundMode = false
			};
			return schemaLane3;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess4EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess4 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("6aa29e17-158b-418e-90ba-40126fef7dfe"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e3814424-97a2-492b-80ea-00df3ef74e8c"),
				CreatedInOwnerSchemaUId = new Guid("08d19c3e-cef5-4a07-9fae-18525efc876b"),
				CreatedInPackageId = new Guid("27ba0bc2-2394-44cd-a4ef-abfa585fb8a9"),
				CreatedInSchemaUId = new Guid("4ac17888-4773-487c-92ef-2db0b1be4027"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("4ac17888-4773-487c-92ef-2db0b1be4027"),
				Name = @"EventSubProcess4",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(49, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(854, 177),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess4;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage6StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("61adac11-e0ce-400f-bc57-4a4e533e616c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6aa29e17-158b-418e-90ba-40126fef7dfe"),
				CreatedInOwnerSchemaUId = new Guid("08d19c3e-cef5-4a07-9fae-18525efc876b"),
				CreatedInPackageId = new Guid("27ba0bc2-2394-44cd-a4ef-abfa585fb8a9"),
				CreatedInSchemaUId = new Guid("4ac17888-4773-487c-92ef-2db0b1be4027"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"CaseInserting",
				ModifiedInSchemaUId = new Guid("4ac17888-4773-487c-92ef-2db0b1be4027"),
				Name = @"StartMessage6",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(43, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateIntermediateThrowMessageEvent1IntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("55a59700-b6f2-45c2-95ac-36428422953e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6aa29e17-158b-418e-90ba-40126fef7dfe"),
				CreatedInOwnerSchemaUId = new Guid("08d19c3e-cef5-4a07-9fae-18525efc876b"),
				CreatedInPackageId = new Guid("27ba0bc2-2394-44cd-a4ef-abfa585fb8a9"),
				CreatedInSchemaUId = new Guid("4ac17888-4773-487c-92ef-2db0b1be4027"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"CaseInserting",
				ModifiedInSchemaUId = new Guid("4ac17888-4773-487c-92ef-2db0b1be4027"),
				Name = @"IntermediateThrowMessageEvent1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(134, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateSetEmptyOwnerScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("1c39d39d-39de-47ef-8787-2d7e3152c6dc"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6aa29e17-158b-418e-90ba-40126fef7dfe"),
				CreatedInOwnerSchemaUId = new Guid("08d19c3e-cef5-4a07-9fae-18525efc876b"),
				CreatedInPackageId = new Guid("27ba0bc2-2394-44cd-a4ef-abfa585fb8a9"),
				CreatedInSchemaUId = new Guid("4ac17888-4773-487c-92ef-2db0b1be4027"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("4ac17888-4773-487c-92ef-2db0b1be4027"),
				Name = @"SetEmptyOwnerScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(232, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,69,200,177,10,194,48,16,6,224,217,64,222,225,232,212,130,228,5,74,167,224,224,164,16,235,46,122,66,32,254,145,235,29,82,164,239,46,153,220,62,190,252,164,126,94,88,98,5,248,174,185,34,68,19,97,104,219,240,239,203,250,102,154,38,106,221,28,82,58,15,244,245,110,119,128,102,93,67,98,141,181,216,11,215,91,49,238,187,211,7,44,199,71,183,39,88,41,195,232,221,230,157,176,154,128,84,140,199,31,172,217,78,253,123,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess5EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess5 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("1782e20a-cce0-442f-a0ac-832bdf976ccc"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e3814424-97a2-492b-80ea-00df3ef74e8c"),
				CreatedInOwnerSchemaUId = new Guid("08d19c3e-cef5-4a07-9fae-18525efc876b"),
				CreatedInPackageId = new Guid("b54a206c-0c3a-4346-bc7a-d3b009155be5"),
				CreatedInSchemaUId = new Guid("4ac17888-4773-487c-92ef-2db0b1be4027"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("4ac17888-4773-487c-92ef-2db0b1be4027"),
				Name = @"EventSubProcess5",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(49, 224),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(497, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess5;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateCaseSavedStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("b461cd29-d3f1-4ce2-af6d-f94f62f5c037"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1782e20a-cce0-442f-a0ac-832bdf976ccc"),
				CreatedInOwnerSchemaUId = new Guid("08d19c3e-cef5-4a07-9fae-18525efc876b"),
				CreatedInPackageId = new Guid("b54a206c-0c3a-4346-bc7a-d3b009155be5"),
				CreatedInSchemaUId = new Guid("4ac17888-4773-487c-92ef-2db0b1be4027"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"CaseSaved",
				ModifiedInSchemaUId = new Guid("4ac17888-4773-487c-92ef-2db0b1be4027"),
				Name = @"CaseSavedStartMessage",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(43, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateBaseCaseSavedIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("5ee06747-a8ce-4fff-af35-7b652461e7af"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1782e20a-cce0-442f-a0ac-832bdf976ccc"),
				CreatedInOwnerSchemaUId = new Guid("08d19c3e-cef5-4a07-9fae-18525efc876b"),
				CreatedInPackageId = new Guid("b54a206c-0c3a-4346-bc7a-d3b009155be5"),
				CreatedInSchemaUId = new Guid("4ac17888-4773-487c-92ef-2db0b1be4027"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"CaseSaved",
				ModifiedInSchemaUId = new Guid("4ac17888-4773-487c-92ef-2db0b1be4027"),
				Name = @"BaseCaseSaved",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(134, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateCaseSavedScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("609094a6-78ca-474b-8128-cbc58d434eef"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1782e20a-cce0-442f-a0ac-832bdf976ccc"),
				CreatedInOwnerSchemaUId = new Guid("08d19c3e-cef5-4a07-9fae-18525efc876b"),
				CreatedInPackageId = new Guid("b54a206c-0c3a-4346-bc7a-d3b009155be5"),
				CreatedInSchemaUId = new Guid("4ac17888-4773-487c-92ef-2db0b1be4027"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("4ac17888-4773-487c-92ef-2db0b1be4027"),
				Name = @"CaseSavedScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(232, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,75,202,207,207,81,200,44,14,45,78,45,114,206,207,203,75,77,46,201,204,207,83,176,85,64,19,200,44,86,8,14,14,64,21,180,230,229,202,76,211,80,68,215,172,169,80,205,203,197,25,156,90,18,144,95,84,146,152,227,156,88,156,26,148,153,158,81,82,172,161,9,212,81,203,203,85,148,90,82,90,148,167,80,82,84,154,106,13,0,27,119,207,7,127,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess6EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess6 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("907a17e3-36ea-4f4a-9a02-1e31adfa6f1c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e3814424-97a2-492b-80ea-00df3ef74e8c"),
				CreatedInOwnerSchemaUId = new Guid("08d19c3e-cef5-4a07-9fae-18525efc876b"),
				CreatedInPackageId = new Guid("b54a206c-0c3a-4346-bc7a-d3b009155be5"),
				CreatedInSchemaUId = new Guid("4ac17888-4773-487c-92ef-2db0b1be4027"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("4ac17888-4773-487c-92ef-2db0b1be4027"),
				Name = @"EventSubProcess6",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(49, 420),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(497, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess6;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateCaseSavingStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("07851372-07b8-4613-94cd-a3544cb65205"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("907a17e3-36ea-4f4a-9a02-1e31adfa6f1c"),
				CreatedInOwnerSchemaUId = new Guid("08d19c3e-cef5-4a07-9fae-18525efc876b"),
				CreatedInPackageId = new Guid("b54a206c-0c3a-4346-bc7a-d3b009155be5"),
				CreatedInSchemaUId = new Guid("4ac17888-4773-487c-92ef-2db0b1be4027"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"CaseSaving",
				ModifiedInSchemaUId = new Guid("4ac17888-4773-487c-92ef-2db0b1be4027"),
				Name = @"CaseSavingStartMessage",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(43, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateBaseCaseSavingIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("cb6c74a4-240c-4bf3-b1bb-054813817120"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("907a17e3-36ea-4f4a-9a02-1e31adfa6f1c"),
				CreatedInOwnerSchemaUId = new Guid("08d19c3e-cef5-4a07-9fae-18525efc876b"),
				CreatedInPackageId = new Guid("b54a206c-0c3a-4346-bc7a-d3b009155be5"),
				CreatedInSchemaUId = new Guid("4ac17888-4773-487c-92ef-2db0b1be4027"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"CaseSaving",
				ModifiedInSchemaUId = new Guid("4ac17888-4773-487c-92ef-2db0b1be4027"),
				Name = @"BaseCaseSaving",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(134, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreatePortalCaseSavingScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("fe7ac697-80e2-4a92-a45b-96e7b8eb6115"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("907a17e3-36ea-4f4a-9a02-1e31adfa6f1c"),
				CreatedInOwnerSchemaUId = new Guid("08d19c3e-cef5-4a07-9fae-18525efc876b"),
				CreatedInPackageId = new Guid("b54a206c-0c3a-4346-bc7a-d3b009155be5"),
				CreatedInSchemaUId = new Guid("4ac17888-4773-487c-92ef-2db0b1be4027"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("4ac17888-4773-487c-92ef-2db0b1be4027"),
				Name = @"PortalCaseSavingScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(225, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,243,207,73,113,206,207,43,73,76,46,241,76,81,176,85,112,205,43,201,44,169,212,115,79,45,9,169,44,72,77,241,7,201,230,148,230,230,133,37,230,148,166,218,184,151,102,166,216,105,40,193,53,40,105,90,243,114,21,165,150,148,22,229,41,148,20,149,166,90,3,0,155,197,145,184,78,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateGetContactSspUserMethod());
			Methods.Add(CreateGetSysAdminUnitMethod());
			Methods.Add(CreateIsResolvedMethod());
			Methods.Add(CreateSetPortalCaseRightsMethod());
			Methods.Add(CreateIsPortalUserMethod());
			Methods.Add(CreateActualizePortalUsersRightsMethod());
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
				UId = new Guid("3a878546-6372-4577-a405-2928ca61cb3f"),
				Name = "Terrasoft.Configuration.RightsService",
				Alias = "",
				CreatedInPackageId = new Guid("eac080e5-c7e6-4027-928f-bde13f5a1451")
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

		protected virtual SchemaMethod CreateGetContactSspUserMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("cc17136d-f04e-416b-8bc3-6aabfd51db0a"),
				Name = "GetContactSspUser",
				CreatedInSchemaUId = new Guid("4ac17888-4773-487c-92ef-2db0b1be4027"),
				CreatedInPackageId = new Guid("b54a206c-0c3a-4346-bc7a-d3b009155be5"),
				ResultValueTypeName = "Guid"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("7543bfa7-180a-48ce-9d13-2ee245caf86e"),
				Name = "ContactId",
				CreatedInSchemaUId = new Guid("4ac17888-4773-487c-92ef-2db0b1be4027"),
				ModifiedInSchemaUId = new Guid("4ac17888-4773-487c-92ef-2db0b1be4027"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("b54a206c-0c3a-4346-bc7a-d3b009155be5")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,101,144,193,110,194,48,12,64,207,69,226,31,162,158,146,75,180,59,218,129,177,130,184,161,181,108,231,172,53,35,82,235,116,78,2,67,211,254,125,78,91,4,211,164,166,74,28,191,23,219,39,67,194,67,11,117,16,143,2,225,44,202,225,32,247,30,104,229,16,121,111,29,170,249,44,211,43,215,198,14,101,190,109,114,62,235,53,185,78,230,229,197,47,155,206,226,30,109,24,194,111,71,32,144,235,136,181,222,247,61,144,204,89,19,76,29,18,166,244,214,23,159,209,180,247,9,163,87,239,12,153,14,194,16,152,0,165,134,135,151,216,12,150,169,152,234,210,67,126,51,253,195,165,197,160,42,32,50,222,29,2,151,77,160,83,59,137,211,101,185,83,74,24,63,245,185,152,207,162,183,248,33,228,137,7,209,188,23,95,80,199,224,136,135,241,119,2,186,64,31,9,158,159,110,33,201,162,111,174,239,78,64,96,26,72,240,56,82,61,234,224,101,8,203,155,126,34,179,243,209,182,32,228,136,233,148,118,149,102,25,65,136,132,98,19,109,147,154,243,112,77,219,64,120,53,109,4,249,160,116,229,202,64,252,60,99,139,68,253,240,143,23,127,247,120,209,245,225,194,247,191,98,115,111,66,237,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetSysAdminUnitMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("f5310e42-0676-40d3-8c69-c9119745f9d9"),
				Name = "GetSysAdminUnit",
				CreatedInSchemaUId = new Guid("4ac17888-4773-487c-92ef-2db0b1be4027"),
				CreatedInPackageId = new Guid("eac080e5-c7e6-4027-928f-bde13f5a1451"),
				ResultValueTypeName = " Dictionary<Guid, Guid>"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("985f74a0-8b60-4574-aa95-c7b2889c0cf7"),
				Name = "contactId",
				CreatedInSchemaUId = new Guid("4ac17888-4773-487c-92ef-2db0b1be4027"),
				ModifiedInSchemaUId = new Guid("4ac17888-4773-487c-92ef-2db0b1be4027"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("eac080e5-c7e6-4027-928f-bde13f5a1451")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("c3f75349-cb4a-4455-acf1-433644ce347c"),
				Name = "contactIdOld",
				CreatedInSchemaUId = new Guid("4ac17888-4773-487c-92ef-2db0b1be4027"),
				ModifiedInSchemaUId = new Guid("4ac17888-4773-487c-92ef-2db0b1be4027"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("eac080e5-c7e6-4027-928f-bde13f5a1451")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,146,223,106,195,32,20,198,175,19,200,59,72,174,12,12,95,32,237,96,173,89,201,85,199,74,183,139,177,11,27,15,171,96,12,59,234,186,50,250,238,51,53,253,19,182,93,12,228,160,159,223,249,29,143,202,85,227,84,103,4,238,39,11,175,228,13,233,227,45,65,176,94,59,50,37,6,118,132,255,234,161,69,153,165,31,2,137,221,219,59,217,42,179,54,202,173,64,67,115,202,139,11,186,182,128,243,206,24,56,82,138,44,77,18,54,239,180,111,13,205,107,153,143,133,96,116,162,113,103,253,30,187,150,230,171,171,18,195,198,243,22,16,70,126,86,219,234,221,11,77,35,139,61,8,20,45,56,64,218,156,76,69,204,93,226,127,19,151,58,228,18,97,135,158,66,231,222,42,243,70,40,159,85,159,208,120,215,33,145,155,243,116,74,198,77,179,202,88,143,192,103,23,137,6,222,87,56,205,192,169,185,112,226,17,132,132,0,234,1,63,111,149,69,60,68,23,189,148,27,72,201,110,171,52,80,137,172,119,4,254,81,76,226,83,190,4,121,1,46,118,248,36,180,135,73,124,197,235,139,120,13,117,255,244,245,134,178,39,30,72,136,135,44,13,3,193,121,52,195,111,41,191,1,92,227,150,116,76,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateIsResolvedMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("46761002-bfdd-45a1-91dc-0af486c83cf6"),
				Name = "IsResolved",
				CreatedInSchemaUId = new Guid("4ac17888-4773-487c-92ef-2db0b1be4027"),
				CreatedInPackageId = new Guid("eac080e5-c7e6-4027-928f-bde13f5a1451"),
				ResultValueTypeName = "bool"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("ad176457-2ca8-4157-8402-9e9f51eb9de9"),
				Name = "caseStatusId",
				CreatedInSchemaUId = new Guid("4ac17888-4773-487c-92ef-2db0b1be4027"),
				ModifiedInSchemaUId = new Guid("4ac17888-4773-487c-92ef-2db0b1be4027"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("eac080e5-c7e6-4027-928f-bde13f5a1451")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,93,144,193,110,131,48,12,134,207,84,234,59,88,156,194,37,47,208,118,135,2,155,184,85,173,182,157,93,112,59,164,144,104,78,210,77,154,250,238,51,11,42,98,135,68,246,111,255,95,28,223,144,161,241,71,242,206,220,168,59,145,161,54,192,14,44,125,65,74,212,171,39,46,157,181,18,247,206,22,235,85,150,233,210,153,56,88,149,207,206,60,21,158,217,13,42,47,209,211,41,96,136,126,146,223,63,136,73,218,165,77,55,190,254,140,104,84,98,232,3,50,14,20,136,85,251,112,53,93,81,0,250,105,130,205,122,21,125,111,175,160,170,125,253,77,109,12,142,161,59,63,194,29,44,71,212,181,245,145,169,218,207,146,18,222,143,76,50,113,154,10,3,30,9,59,18,208,8,248,191,1,157,224,148,122,212,252,216,196,201,250,139,234,88,143,101,65,255,41,25,83,136,108,133,167,95,40,164,207,189,161,137,180,61,59,103,158,150,187,218,140,142,59,144,241,4,11,247,5,69,74,85,185,228,220,127,1,104,75,4,199,161,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSetPortalCaseRightsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("59b54bfa-77d4-48c4-a3d3-171814362c86"),
				Name = "SetPortalCaseRights",
				CreatedInSchemaUId = new Guid("4ac17888-4773-487c-92ef-2db0b1be4027"),
				CreatedInPackageId = new Guid("eac080e5-c7e6-4027-928f-bde13f5a1451"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,181,83,95,107,194,48,16,127,174,176,239,16,125,144,10,69,182,61,110,115,67,68,74,217,96,162,115,47,99,15,89,27,53,144,38,146,75,29,221,240,187,47,137,182,77,235,195,58,97,143,119,185,251,253,185,187,132,25,77,80,44,184,194,177,138,18,52,66,83,174,168,202,135,33,81,47,249,150,36,19,193,178,148,191,98,150,145,187,80,215,222,251,189,73,81,221,27,220,94,116,66,11,128,129,44,20,86,25,180,196,40,138,45,196,135,16,12,81,152,19,16,108,71,12,64,84,6,190,11,237,20,31,69,76,54,152,175,109,75,229,161,59,66,207,44,41,85,234,158,29,150,8,114,24,39,41,229,75,78,117,18,116,135,150,183,112,146,126,137,16,212,250,43,147,135,204,18,136,140,234,140,35,13,166,43,134,211,116,171,114,244,224,6,55,134,230,136,181,128,173,105,174,136,74,104,81,242,149,232,174,132,191,18,52,229,83,174,144,36,216,192,94,30,67,204,152,248,212,241,85,241,76,215,27,245,68,118,132,233,228,181,73,174,252,230,148,7,232,251,162,227,233,135,19,185,221,154,190,126,191,57,237,161,45,167,28,30,73,94,87,55,48,144,222,56,86,25,102,244,139,204,132,84,152,25,84,152,27,69,224,175,48,3,18,20,39,53,147,52,197,50,119,46,42,64,6,192,243,26,140,111,46,203,123,96,237,7,142,75,51,22,111,127,176,19,159,239,37,110,111,68,201,236,28,31,113,11,19,123,187,174,118,58,141,163,8,42,121,174,133,98,191,213,95,60,164,254,217,150,189,197,83,95,136,232,205,255,202,127,238,125,180,16,96,7,251,3,54,196,215,238,33,5,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateIsPortalUserMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("66538f6e-858c-4dbf-8b67-c4cd54dc93eb"),
				Name = "IsPortalUser",
				CreatedInSchemaUId = new Guid("4ac17888-4773-487c-92ef-2db0b1be4027"),
				CreatedInPackageId = new Guid("7813c729-b035-4ac5-b2cb-fa0d7a681431"),
				ResultValueTypeName = "bool"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("e1f257f2-c5fd-4d93-abb0-e0c6069ba192"),
				Name = "contactId",
				CreatedInSchemaUId = new Guid("4ac17888-4773-487c-92ef-2db0b1be4027"),
				ModifiedInSchemaUId = new Guid("4ac17888-4773-487c-92ef-2db0b1be4027"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("7813c729-b035-4ac5-b2cb-fa0d7a681431")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,101,144,81,79,195,32,16,128,159,187,100,255,129,244,137,190,144,248,60,107,226,214,106,250,182,56,167,207,103,123,83,18,10,122,128,186,152,253,119,161,160,141,238,1,114,124,119,124,28,247,14,196,164,221,26,114,160,246,22,105,135,10,123,199,106,166,241,131,165,3,143,124,99,180,14,177,52,186,90,46,138,66,108,140,242,163,230,229,204,239,143,175,88,166,228,13,153,145,151,187,163,189,30,70,169,247,90,186,156,120,124,65,194,233,146,131,222,117,67,89,137,206,182,111,30,20,79,66,177,5,130,17,29,18,239,127,138,170,138,129,205,189,172,150,11,111,165,126,102,188,89,183,159,216,123,103,136,13,79,191,97,205,254,54,43,90,109,61,97,179,158,17,15,190,175,208,77,246,116,13,56,184,67,24,48,136,162,224,124,26,34,233,49,85,241,249,185,108,42,228,129,15,36,98,58,200,39,18,16,139,236,22,93,250,216,3,40,143,151,82,187,171,243,153,177,186,102,23,89,85,20,132,206,147,102,142,60,174,38,114,154,246,140,15,160,108,226,17,199,245,47,113,250,6,89,147,122,39,210,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateActualizePortalUsersRightsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("0d9f26b8-3042-4eed-a30f-bd8312c55c1c"),
				Name = "ActualizePortalUsersRights",
				CreatedInSchemaUId = new Guid("4ac17888-4773-487c-92ef-2db0b1be4027"),
				CreatedInPackageId = new Guid("7813c729-b035-4ac5-b2cb-fa0d7a681431"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("29d05699-a658-4e48-a099-68ca9628e6fe"),
				Name = "action",
				CreatedInSchemaUId = new Guid("4ac17888-4773-487c-92ef-2db0b1be4027"),
				ModifiedInSchemaUId = new Guid("4ac17888-4773-487c-92ef-2db0b1be4027"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "bool",
				CreatedInPackageId = new Guid("7813c729-b035-4ac5-b2cb-fa0d7a681431")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("502852aa-449b-4bcf-8fb0-7a0c85443de1"),
				Name = "recordId",
				CreatedInSchemaUId = new Guid("4ac17888-4773-487c-92ef-2db0b1be4027"),
				ModifiedInSchemaUId = new Guid("4ac17888-4773-487c-92ef-2db0b1be4027"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("7813c729-b035-4ac5-b2cb-fa0d7a681431")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("600deb76-3dbb-4dfa-a299-38449218ed51"),
				Name = "sysAdminUnitId",
				CreatedInSchemaUId = new Guid("4ac17888-4773-487c-92ef-2db0b1be4027"),
				ModifiedInSchemaUId = new Guid("4ac17888-4773-487c-92ef-2db0b1be4027"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("7813c729-b035-4ac5-b2cb-fa0d7a681431")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("e7b35e03-4ea7-4d42-80ee-53a4f9ef99d6"),
				Name = "operation",
				CreatedInSchemaUId = new Guid("4ac17888-4773-487c-92ef-2db0b1be4027"),
				ModifiedInSchemaUId = new Guid("4ac17888-4773-487c-92ef-2db0b1be4027"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "int",
				CreatedInPackageId = new Guid("7813c729-b035-4ac5-b2cb-fa0d7a681431")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("1968f716-894d-43a9-9153-6abb8e6bc6c1"),
				Name = "rightLevel",
				CreatedInSchemaUId = new Guid("4ac17888-4773-487c-92ef-2db0b1be4027"),
				ModifiedInSchemaUId = new Guid("4ac17888-4773-487c-92ef-2db0b1be4027"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "int",
				CreatedInPackageId = new Guid("7813c729-b035-4ac5-b2cb-fa0d7a681431")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,144,205,10,131,48,16,132,239,133,190,67,200,73,65,250,2,210,131,148,30,10,133,138,34,61,150,37,89,106,64,19,217,172,246,231,233,91,197,22,44,61,228,54,59,236,55,12,51,0,9,207,142,80,231,228,20,234,158,80,108,133,197,155,40,151,110,84,121,164,157,179,22,21,27,103,19,33,217,119,151,76,113,15,141,121,98,238,136,161,25,127,124,97,174,53,123,25,167,235,213,79,242,230,108,184,206,129,160,69,70,138,100,54,69,201,68,192,36,2,136,2,149,35,125,208,111,134,102,25,64,149,15,159,233,214,216,202,26,158,88,191,48,2,18,78,29,18,204,101,221,71,135,244,29,183,56,226,128,205,216,248,123,252,35,247,119,84,61,99,20,167,47,113,181,220,110,148,1,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new Case_Portal_TerrasoftEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("4ac17888-4773-487c-92ef-2db0b1be4027"));
		}

		#endregion

	}

	#endregion

}

