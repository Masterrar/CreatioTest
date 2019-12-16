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

	#region Class: ProblemInCaseSchema

	/// <exclude/>
	public class ProblemInCaseSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public ProblemInCaseSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public ProblemInCaseSchema(ProblemInCaseSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public ProblemInCaseSchema(ProblemInCaseSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("fb6dab95-e48a-425d-8131-aa6eb0a63da7");
			RealUId = new Guid("fb6dab95-e48a-425d-8131-aa6eb0a63da7");
			Name = "ProblemInCase";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("3c33fea4-8dbf-4aca-bdb3-74630a448d22");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("66aa964a-d680-4bf5-b83f-b4e80dd16cc3")) == null) {
				Columns.Add(CreateCaseColumn());
			}
			if (Columns.FindByUId(new Guid("3eff4921-de34-47d7-8db8-772caac9ffe8")) == null) {
				Columns.Add(CreateProblemColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateCaseColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("66aa964a-d680-4bf5-b83f-b4e80dd16cc3"),
				Name = @"Case",
				ReferenceSchemaUId = new Guid("117d32f9-8275-4534-8411-1c66115ce9cd"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("fb6dab95-e48a-425d-8131-aa6eb0a63da7"),
				ModifiedInSchemaUId = new Guid("fb6dab95-e48a-425d-8131-aa6eb0a63da7"),
				CreatedInPackageId = new Guid("3c33fea4-8dbf-4aca-bdb3-74630a448d22")
			};
		}

		protected virtual EntitySchemaColumn CreateProblemColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("3eff4921-de34-47d7-8db8-772caac9ffe8"),
				Name = @"Problem",
				ReferenceSchemaUId = new Guid("7ec5366d-8edf-4b7d-b94b-2bc2655cf230"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("fb6dab95-e48a-425d-8131-aa6eb0a63da7"),
				ModifiedInSchemaUId = new Guid("fb6dab95-e48a-425d-8131-aa6eb0a63da7"),
				CreatedInPackageId = new Guid("3c33fea4-8dbf-4aca-bdb3-74630a448d22")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateProblemInCaseEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateProblemInCaseEventsProcessSchema() {
			var schema = new ProblemInCaseEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new ProblemInCase(userConnection){Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new ProblemInCase_ProblemEventsProcess(userConnnection);
		}

		public override object Clone() {
			return new ProblemInCaseSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new ProblemInCaseSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("fb6dab95-e48a-425d-8131-aa6eb0a63da7"));
		}

		#endregion

	}

	#endregion

	#region Class: ProblemInCase

	/// <summary>
	/// Problem in case.
	/// </summary>
	public class ProblemInCase : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public ProblemInCase(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "ProblemInCase";
		}

		public ProblemInCase(ProblemInCase source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public  Guid CaseId {
			get {
				return GetTypedColumnValue<Guid>("CaseId");
			}
			set {
				SetColumnValue("CaseId", value);
				_case = null;
			}
		}

		/// <exclude/>
		public  string CaseNumber {
			get {
				return GetTypedColumnValue<string>("CaseNumber");
			}
			set {
				SetColumnValue("CaseNumber", value);
				if (_case != null) {
					_case.Number = value;
				}
			}
		}

		private Case _case;
		/// <summary>
		/// Case.
		/// </summary>
		public  Case Case {
			get {
				return _case ??
					(_case = LookupColumnEntities.GetEntity("Case") as Case);
			}
		}

		/// <exclude/>
		public  Guid ProblemId {
			get {
				return GetTypedColumnValue<Guid>("ProblemId");
			}
			set {
				SetColumnValue("ProblemId", value);
				_problem = null;
			}
		}

		/// <exclude/>
		public  string ProblemNumber {
			get {
				return GetTypedColumnValue<string>("ProblemNumber");
			}
			set {
				SetColumnValue("ProblemNumber", value);
				if (_problem != null) {
					_problem.Number = value;
				}
			}
		}

		private Problem _problem;
		/// <summary>
		/// Problem.
		/// </summary>
		public  Problem Problem {
			get {
				return _problem ??
					(_problem = LookupColumnEntities.GetEntity("Problem") as Problem);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new ProblemInCase_ProblemEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("ProblemInCaseDeleted", e);
			Saved += (s, e) => ThrowEvent("ProblemInCaseSaved", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new ProblemInCase(this);
		}

		#endregion

	}

	#endregion

	#region Class: ProblemInCase_ProblemEventsProcess

	/// <exclude/>
	public class ProblemInCase_ProblemEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_LocalMessageEventsProcess<TEntity> where TEntity : ProblemInCase
	{

		public ProblemInCase_ProblemEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ProblemInCase_ProblemEventsProcess";
			SchemaUId = new Guid("fb6dab95-e48a-425d-8131-aa6eb0a63da7");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private  Guid InternalSchemaUId {
			get {
				return new Guid("fb6dab95-e48a-425d-8131-aa6eb0a63da7");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		private ProcessFlowElement _eventSubProcess3_3ea87d9f46474996b971e9667a407d8a;
		public  ProcessFlowElement EventSubProcess3_3ea87d9f46474996b971e9667a407d8a {
			get {
				return _eventSubProcess3_3ea87d9f46474996b971e9667a407d8a ?? (_eventSubProcess3_3ea87d9f46474996b971e9667a407d8a = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess3_3ea87d9f46474996b971e9667a407d8a",
					SchemaElementUId = new Guid("3ea87d9f-4647-4996-b971-e9667a407d8a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _problemInCaseSavedMessage;
		public  ProcessFlowElement ProblemInCaseSavedMessage {
			get {
				return _problemInCaseSavedMessage ?? (_problemInCaseSavedMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ProblemInCaseSavedMessage",
					SchemaElementUId = new Guid("10ef34d8-b4a3-4d4f-b3d2-3e21bc1b228a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _updateCaseScriptTask;
		public  ProcessScriptTask UpdateCaseScriptTask {
			get {
				return _updateCaseScriptTask ?? (_updateCaseScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "UpdateCaseScriptTask",
					SchemaElementUId = new Guid("9ef8ce3a-0d2b-4ee6-a63b-13fb52d8debe"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = UpdateCaseScriptTaskExecute,
				});
			}
		}

		private ProcessThrowMessageEvent _parentBaseEntitySaved;
		public  ProcessThrowMessageEvent ParentBaseEntitySaved {
			get {
				return _parentBaseEntitySaved ?? (_parentBaseEntitySaved = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "ParentBaseEntitySaved",
					SchemaElementUId = new Guid("3bf1ecb5-4197-4476-9e16-b3f2c2fb3869"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "BaseEntitySaved",
						ThrowToBase = true,
				});
			}
		}

		private ProcessFlowElement _problemInCaseDeletedEventSubProcess;
		public  ProcessFlowElement ProblemInCaseDeletedEventSubProcess {
			get {
				return _problemInCaseDeletedEventSubProcess ?? (_problemInCaseDeletedEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "ProblemInCaseDeletedEventSubProcess",
					SchemaElementUId = new Guid("e62c02f6-c874-43b5-83e2-5247eb07f5bc"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _problemInCaseDeletedMessage;
		public  ProcessFlowElement ProblemInCaseDeletedMessage {
			get {
				return _problemInCaseDeletedMessage ?? (_problemInCaseDeletedMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ProblemInCaseDeletedMessage",
					SchemaElementUId = new Guid("0f1889fa-8558-4c67-9be7-8d7c773267bc"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _updateProblemInCaseScript;
		public  ProcessScriptTask UpdateProblemInCaseScript {
			get {
				return _updateProblemInCaseScript ?? (_updateProblemInCaseScript = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "UpdateProblemInCaseScript",
					SchemaElementUId = new Guid("9c2a46d7-376c-4e66-a59b-9c6de90b3c29"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = UpdateProblemInCaseScriptExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess3_3ea87d9f46474996b971e9667a407d8a.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess3_3ea87d9f46474996b971e9667a407d8a };
			FlowElements[ProblemInCaseSavedMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { ProblemInCaseSavedMessage };
			FlowElements[UpdateCaseScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { UpdateCaseScriptTask };
			FlowElements[ParentBaseEntitySaved.SchemaElementUId] = new Collection<ProcessFlowElement> { ParentBaseEntitySaved };
			FlowElements[ProblemInCaseDeletedEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { ProblemInCaseDeletedEventSubProcess };
			FlowElements[ProblemInCaseDeletedMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { ProblemInCaseDeletedMessage };
			FlowElements[UpdateProblemInCaseScript.SchemaElementUId] = new Collection<ProcessFlowElement> { UpdateProblemInCaseScript };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess3_3ea87d9f46474996b971e9667a407d8a":
						break;
					case "ProblemInCaseSavedMessage":
						e.Context.QueueTasks.Enqueue("UpdateCaseScriptTask");
						break;
					case "UpdateCaseScriptTask":
						e.Context.QueueTasks.Enqueue("ParentBaseEntitySaved");
						break;
					case "ParentBaseEntitySaved":
						break;
					case "ProblemInCaseDeletedEventSubProcess":
						break;
					case "ProblemInCaseDeletedMessage":
						e.Context.QueueTasks.Enqueue("UpdateProblemInCaseScript");
						break;
					case "UpdateProblemInCaseScript":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("ProblemInCaseSavedMessage");
			ActivatedEventElements.Add("ProblemInCaseDeletedMessage");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "EventSubProcess3_3ea87d9f46474996b971e9667a407d8a":
					context.QueueTasks.Dequeue();
					break;
				case "ProblemInCaseSavedMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "ProblemInCaseSavedMessage";
					result = ProblemInCaseSavedMessage.Execute(context);
					break;
				case "UpdateCaseScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "UpdateCaseScriptTask";
					result = UpdateCaseScriptTask.Execute(context, UpdateCaseScriptTaskExecute);
					break;
				case "ParentBaseEntitySaved":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "BaseEntitySaved");
					result = ParentBaseEntitySaved.Execute(context);
					break;
				case "ProblemInCaseDeletedEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "ProblemInCaseDeletedMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "ProblemInCaseDeletedMessage";
					result = ProblemInCaseDeletedMessage.Execute(context);
					break;
				case "UpdateProblemInCaseScript":
					context.QueueTasks.Dequeue();
					context.SenderName = "UpdateProblemInCaseScript";
					result = UpdateProblemInCaseScript.Execute(context, UpdateProblemInCaseScriptExecute);
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

		#endregion

		#region Methods: Public

		public virtual bool UpdateCaseScriptTaskExecute(ProcessExecutingContext context) {
			if (Entity.IsColumnValueLoaded("CaseId") && Entity.IsColumnValueLoaded("ProblemId")){
				var caseId = Entity.GetTypedColumnValue<Guid>("CaseId");
				var problemId = Entity.GetTypedColumnValue<Guid>("ProblemId");
				var caseEntity = UserConnection.EntitySchemaManager.GetInstanceByName("Case").CreateEntity(UserConnection);
				if (caseEntity.FetchFromDB(caseId)){
					caseEntity.SetColumnValue("ProblemId", problemId);
					caseEntity.Save(false);
				}
			}
			return true;
		}

		public virtual bool UpdateProblemInCaseScriptExecute(ProcessExecutingContext context) {
			if (Entity.IsColumnValueLoaded("CaseId")){
				var caseId = Entity.GetTypedColumnValue<Guid>("CaseId");
				var caseEntity = UserConnection.EntitySchemaManager.GetInstanceByName("Case").CreateEntity(UserConnection);
				if (caseEntity.FetchFromDB(caseId)){
					Guid? actualProblemId = GetLastProblemAddedToCase(caseId);
					caseEntity.SetColumnValue("ProblemId", actualProblemId);
					caseEntity.Save(false);
				}
			}
			return true;
		}

		public virtual Guid? GetLastProblemAddedToCase(Guid caseId) {
			Guid? actualProblemId = null;
			if (caseId != Guid.Empty){
				var select = new Select(UserConnection)
							.Column("ProblemId")
							.From("ProblemInCase")
							.Top(1)
							.Where("CaseId")
							.IsEqual(Column.Const(caseId))
							.OrderByDesc("CreatedOn") as Select;
				using (DBExecutor dbExecutor = UserConnection.EnsureDBConnection()) {
					using (IDataReader reader = dbExecutor.ExecuteReader(select.GetSqlText())) {
						while (reader.Read()) {
							actualProblemId = reader.GetColumnValue<Guid>("ProblemId");
						}
					}
				}
			}
			return actualProblemId;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "ProblemInCaseSaved":
							if (ActivatedEventElements.Contains("ProblemInCaseSavedMessage")) {
							context.QueueTasks.Enqueue("ProblemInCaseSavedMessage");
						}
						break;
					case "ProblemInCaseDeleted":
							if (ActivatedEventElements.Contains("ProblemInCaseDeletedMessage")) {
							context.QueueTasks.Enqueue("ProblemInCaseDeletedMessage");
						}
						break;
			}
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

	#region Class: ProblemInCase_ProblemEventsProcess

	/// <exclude/>
	public class ProblemInCase_ProblemEventsProcess : ProblemInCase_ProblemEventsProcess<ProblemInCase>
	{

		public ProblemInCase_ProblemEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: ProblemInCaseEventsProcessSchema

	/// <exclude/>
	public class ProblemInCaseEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public ProblemInCaseEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public ProblemInCaseEventsProcessSchema(ProblemInCaseEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "ProblemInCase_ProblemEventsProcess";
			UId = new Guid("433ede31-e4bd-4390-b1ac-8bbc040206c0");
			CreatedInPackageId = new Guid("3c33fea4-8dbf-4aca-bdb3-74630a448d22");
			CreatedInSchemaUId = Guid.Empty;
			CreatedInVersion = @"0.0.0.0";
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
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
			ProcessSchemaLaneSet schemaLaneSet2_334e008956914c7e92e68664bf4a087a = CreateLaneSet2_334e008956914c7e92e68664bf4a087aLaneSet();
			LaneSets.Add(schemaLaneSet2_334e008956914c7e92e68664bf4a087a);
			ProcessSchemaLane schemaLane3_5a2caffcd9e1497e90f90bf194c125b0 = CreateLane3_5a2caffcd9e1497e90f90bf194c125b0Lane();
			schemaLaneSet2_334e008956914c7e92e68664bf4a087a.Lanes.Add(schemaLane3_5a2caffcd9e1497e90f90bf194c125b0);
			ProcessSchemaEventSubProcess eventsubprocess3_3ea87d9f46474996b971e9667a407d8a = CreateEventSubProcess3_3ea87d9f46474996b971e9667a407d8aEventSubProcess();
			FlowElements.Add(eventsubprocess3_3ea87d9f46474996b971e9667a407d8a);
			ProcessSchemaEventSubProcess problemincasedeletedeventsubprocess = CreateProblemInCaseDeletedEventSubProcessEventSubProcess();
			FlowElements.Add(problemincasedeletedeventsubprocess);
			ProcessSchemaStartMessageEvent problemincasesavedmessage = CreateProblemInCaseSavedMessageStartMessageEvent();
			eventsubprocess3_3ea87d9f46474996b971e9667a407d8a.FlowElements.Add(problemincasesavedmessage);
			ProcessSchemaScriptTask updatecasescripttask = CreateUpdateCaseScriptTaskScriptTask();
			eventsubprocess3_3ea87d9f46474996b971e9667a407d8a.FlowElements.Add(updatecasescripttask);
			ProcessSchemaIntermediateThrowMessageEvent parentbaseentitysaved = CreateParentBaseEntitySavedIntermediateThrowMessageEvent();
			eventsubprocess3_3ea87d9f46474996b971e9667a407d8a.FlowElements.Add(parentbaseentitysaved);
			ProcessSchemaStartMessageEvent problemincasedeletedmessage = CreateProblemInCaseDeletedMessageStartMessageEvent();
			problemincasedeletedeventsubprocess.FlowElements.Add(problemincasedeletedmessage);
			ProcessSchemaScriptTask updateproblemincasescript = CreateUpdateProblemInCaseScriptScriptTask();
			problemincasedeletedeventsubprocess.FlowElements.Add(updateproblemincasescript);
			FlowElements.Add(CreateSequenceFlow2_7467f8bfce5847fd83fe3feb67c10e49SequenceFlow());
			FlowElements.Add(CreateDefaultSequenceFlow1_e80a0b80ddfb47298feb91d06aff33d4SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3_452ccad4d4f24825976f2fb022710b3dSequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2_7467f8bfce5847fd83fe3feb67c10e49SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2_7467f8bfce5847fd83fe3feb67c10e49",
				UId = new Guid("7467f8bf-ce58-47fd-83fe-3feb67c10e49"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("66f58f21-6ed1-4e29-b506-6b9f6426d463"),
				CreatedInPackageId = new Guid("3c33fea4-8dbf-4aca-bdb3-74630a448d22"),
				CreatedInSchemaUId = new Guid("433ede31-e4bd-4390-b1ac-8bbc040206c0"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("433ede31-e4bd-4390-b1ac-8bbc040206c0"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("10ef34d8-b4a3-4d4f-b3d2-3e21bc1b228a"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("9ef8ce3a-0d2b-4ee6-a63b-13fb52d8debe"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateDefaultSequenceFlow1_e80a0b80ddfb47298feb91d06aff33d4SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "DefaultSequenceFlow1_e80a0b80ddfb47298feb91d06aff33d4",
				UId = new Guid("e80a0b80-ddfb-4729-8feb-91d06aff33d4"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("66f58f21-6ed1-4e29-b506-6b9f6426d463"),
				CreatedInPackageId = new Guid("3c33fea4-8dbf-4aca-bdb3-74630a448d22"),
				CreatedInSchemaUId = new Guid("433ede31-e4bd-4390-b1ac-8bbc040206c0"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("433ede31-e4bd-4390-b1ac-8bbc040206c0"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("9ef8ce3a-0d2b-4ee6-a63b-13fb52d8debe"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("3bf1ecb5-4197-4476-9e16-b3f2c2fb3869"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3_452ccad4d4f24825976f2fb022710b3dSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3_452ccad4d4f24825976f2fb022710b3d",
				UId = new Guid("452ccad4-d4f2-4825-976f-2fb022710b3d"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("66f58f21-6ed1-4e29-b506-6b9f6426d463"),
				CreatedInPackageId = new Guid("3c33fea4-8dbf-4aca-bdb3-74630a448d22"),
				CreatedInSchemaUId = new Guid("433ede31-e4bd-4390-b1ac-8bbc040206c0"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("433ede31-e4bd-4390-b1ac-8bbc040206c0"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("0f1889fa-8558-4c67-9be7-8d7c773267bc"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("9c2a46d7-376c-4e66-a59b-9c6de90b3c29"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet2_334e008956914c7e92e68664bf4a087aLaneSet() {
			ProcessSchemaLaneSet schemaLaneSet2_334e008956914c7e92e68664bf4a087a = new ProcessSchemaLaneSet(this) {
				UId = new Guid("334e0089-5691-4c7e-92e6-8664bf4a087a"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("66f58f21-6ed1-4e29-b506-6b9f6426d463"),
				CreatedInPackageId = new Guid("3c33fea4-8dbf-4aca-bdb3-74630a448d22"),
				CreatedInSchemaUId = new Guid("433ede31-e4bd-4390-b1ac-8bbc040206c0"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("433ede31-e4bd-4390-b1ac-8bbc040206c0"),
				Name = @"LaneSet2_334e008956914c7e92e68664bf4a087a",
				Position = new Point(0, 5),
				Size = new Size(0, 400),
				UseBackgroundMode = false
			};
			return schemaLaneSet2_334e008956914c7e92e68664bf4a087a;
		}

		protected virtual ProcessSchemaLane CreateLane3_5a2caffcd9e1497e90f90bf194c125b0Lane() {
			ProcessSchemaLane schemaLane3_5a2caffcd9e1497e90f90bf194c125b0 = new ProcessSchemaLane(this) {
				UId = new Guid("5a2caffc-d9e1-497e-90f9-0bf194c125b0"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("334e0089-5691-4c7e-92e6-8664bf4a087a"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("3c33fea4-8dbf-4aca-bdb3-74630a448d22"),
				CreatedInSchemaUId = new Guid("433ede31-e4bd-4390-b1ac-8bbc040206c0"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("433ede31-e4bd-4390-b1ac-8bbc040206c0"),
				Name = @"Lane3_5a2caffcd9e1497e90f90bf194c125b0",
				Position = new Point(0, 0),
				Size = new Size(700, 400),
				UseBackgroundMode = false
			};
			return schemaLane3_5a2caffcd9e1497e90f90bf194c125b0;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess3_3ea87d9f46474996b971e9667a407d8aEventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess3_3ea87d9f46474996b971e9667a407d8a = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("3ea87d9f-4647-4996-b971-e9667a407d8a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5a2caffc-d9e1-497e-90f9-0bf194c125b0"),
				CreatedInOwnerSchemaUId = new Guid("66f58f21-6ed1-4e29-b506-6b9f6426d463"),
				CreatedInPackageId = new Guid("3c33fea4-8dbf-4aca-bdb3-74630a448d22"),
				CreatedInSchemaUId = new Guid("433ede31-e4bd-4390-b1ac-8bbc040206c0"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("433ede31-e4bd-4390-b1ac-8bbc040206c0"),
				Name = @"EventSubProcess3_3ea87d9f46474996b971e9667a407d8a",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(200, 100),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(408, 220),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess3_3ea87d9f46474996b971e9667a407d8a;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateProblemInCaseSavedMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("10ef34d8-b4a3-4d4f-b3d2-3e21bc1b228a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("3ea87d9f-4647-4996-b971-e9667a407d8a"),
				CreatedInOwnerSchemaUId = new Guid("66f58f21-6ed1-4e29-b506-6b9f6426d463"),
				CreatedInPackageId = new Guid("3c33fea4-8dbf-4aca-bdb3-74630a448d22"),
				CreatedInSchemaUId = new Guid("433ede31-e4bd-4390-b1ac-8bbc040206c0"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"ProblemInCaseSaved",
				ModifiedInSchemaUId = new Guid("433ede31-e4bd-4390-b1ac-8bbc040206c0"),
				Name = @"ProblemInCaseSavedMessage",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(29, 103),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateUpdateCaseScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("9ef8ce3a-0d2b-4ee6-a63b-13fb52d8debe"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("3ea87d9f-4647-4996-b971-e9667a407d8a"),
				CreatedInOwnerSchemaUId = new Guid("66f58f21-6ed1-4e29-b506-6b9f6426d463"),
				CreatedInPackageId = new Guid("3c33fea4-8dbf-4aca-bdb3-74630a448d22"),
				CreatedInSchemaUId = new Guid("433ede31-e4bd-4390-b1ac-8bbc040206c0"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("433ede31-e4bd-4390-b1ac-8bbc040206c0"),
				Name = @"UpdateCaseScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(130, 89),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,144,193,106,2,49,16,134,207,238,83,132,61,72,22,202,190,192,218,30,220,86,89,80,17,108,123,159,38,99,13,108,18,73,38,194,34,190,123,141,169,108,188,148,94,147,249,190,127,254,81,123,198,223,12,41,26,234,206,183,182,15,218,124,66,31,112,101,65,162,228,101,11,30,59,89,86,108,58,101,127,205,109,157,253,234,81,199,209,234,92,76,78,224,152,184,161,236,249,206,45,145,222,135,35,202,140,158,45,131,146,47,99,74,147,200,227,93,246,47,56,139,110,198,228,196,93,5,31,30,93,107,141,65,65,202,154,58,189,239,196,1,53,172,193,192,55,186,40,239,140,39,48,2,231,195,6,52,166,141,202,170,110,29,2,253,186,248,163,41,134,169,235,245,198,176,122,129,36,14,11,103,245,235,156,167,246,183,99,76,178,145,29,82,86,33,95,254,105,172,29,213,15,16,156,144,239,161,247,24,127,46,197,165,112,72,193,25,70,46,96,243,3,114,79,198,232,195,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateParentBaseEntitySavedIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("3bf1ecb5-4197-4476-9e16-b3f2c2fb3869"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("3ea87d9f-4647-4996-b971-e9667a407d8a"),
				CreatedInOwnerSchemaUId = new Guid("66f58f21-6ed1-4e29-b506-6b9f6426d463"),
				CreatedInPackageId = new Guid("3c33fea4-8dbf-4aca-bdb3-74630a448d22"),
				CreatedInSchemaUId = new Guid("433ede31-e4bd-4390-b1ac-8bbc040206c0"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"BaseEntitySaved",
				ModifiedInSchemaUId = new Guid("433ede31-e4bd-4390-b1ac-8bbc040206c0"),
				Name = @"ParentBaseEntitySaved",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(336, 103),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateProblemInCaseDeletedEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaProblemInCaseDeletedEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("e62c02f6-c874-43b5-83e2-5247eb07f5bc"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5a2caffc-d9e1-497e-90f9-0bf194c125b0"),
				CreatedInOwnerSchemaUId = new Guid("66f58f21-6ed1-4e29-b506-6b9f6426d463"),
				CreatedInPackageId = new Guid("3c33fea4-8dbf-4aca-bdb3-74630a448d22"),
				CreatedInSchemaUId = new Guid("433ede31-e4bd-4390-b1ac-8bbc040206c0"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("433ede31-e4bd-4390-b1ac-8bbc040206c0"),
				Name = @"ProblemInCaseDeletedEventSubProcess",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(201, 412),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(389, 300),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaProblemInCaseDeletedEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateProblemInCaseDeletedMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("0f1889fa-8558-4c67-9be7-8d7c773267bc"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e62c02f6-c874-43b5-83e2-5247eb07f5bc"),
				CreatedInOwnerSchemaUId = new Guid("66f58f21-6ed1-4e29-b506-6b9f6426d463"),
				CreatedInPackageId = new Guid("3c33fea4-8dbf-4aca-bdb3-74630a448d22"),
				CreatedInSchemaUId = new Guid("433ede31-e4bd-4390-b1ac-8bbc040206c0"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"ProblemInCaseDeleted",
				ModifiedInSchemaUId = new Guid("433ede31-e4bd-4390-b1ac-8bbc040206c0"),
				Name = @"ProblemInCaseDeletedMessage",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(28, 123),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateUpdateProblemInCaseScriptScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("9c2a46d7-376c-4e66-a59b-9c6de90b3c29"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e62c02f6-c874-43b5-83e2-5247eb07f5bc"),
				CreatedInOwnerSchemaUId = new Guid("66f58f21-6ed1-4e29-b506-6b9f6426d463"),
				CreatedInPackageId = new Guid("3c33fea4-8dbf-4aca-bdb3-74630a448d22"),
				CreatedInSchemaUId = new Guid("433ede31-e4bd-4390-b1ac-8bbc040206c0"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("433ede31-e4bd-4390-b1ac-8bbc040206c0"),
				Name = @"UpdateProblemInCaseScript",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(129, 109),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,101,144,203,106,195,48,16,69,215,246,87,8,175,100,40,254,129,244,65,227,38,193,144,150,66,210,238,167,210,164,17,232,17,164,81,192,148,252,123,229,71,107,183,89,106,196,57,119,238,168,3,227,43,75,138,218,170,9,181,211,209,216,119,208,17,183,14,36,74,94,212,16,176,145,69,89,126,229,217,25,60,19,253,155,221,177,17,218,32,237,219,19,202,25,122,187,137,74,222,79,232,98,34,7,40,209,111,1,125,237,172,69,65,202,217,106,152,239,196,17,13,60,131,133,79,244,157,185,177,129,192,10,92,182,47,96,112,48,22,101,85,123,4,26,93,252,175,169,11,83,169,210,20,86,173,145,196,113,237,157,121,90,242,97,251,190,76,214,109,249,192,64,80,4,253,234,221,135,70,211,23,75,185,91,8,52,142,30,101,58,195,222,117,201,63,116,138,200,102,254,29,210,172,60,47,126,93,197,205,127,251,21,10,103,228,7,208,1,187,159,75,126,201,61,82,244,150,145,143,184,248,6,6,22,251,243,155,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateGetLastProblemAddedToCaseMethod());
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

		protected virtual SchemaMethod CreateGetLastProblemAddedToCaseMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("4f9fe632-e4fb-4c1a-b1d9-06d17c47b23e"),
				Name = "GetLastProblemAddedToCase",
				CreatedInSchemaUId = new Guid("433ede31-e4bd-4390-b1ac-8bbc040206c0"),
				CreatedInPackageId = new Guid("3c33fea4-8dbf-4aca-bdb3-74630a448d22"),
				ResultValueTypeName = "Guid?"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("6f3d2d11-220b-4ccd-8607-2de6093dd965"),
				Name = "caseId",
				CreatedInSchemaUId = new Guid("433ede31-e4bd-4390-b1ac-8bbc040206c0"),
				ModifiedInSchemaUId = new Guid("433ede31-e4bd-4390-b1ac-8bbc040206c0"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("3c33fea4-8dbf-4aca-bdb3-74630a448d22")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,101,82,77,79,195,48,12,61,55,191,194,244,148,94,42,113,46,5,105,109,153,118,26,98,3,206,89,107,88,165,52,217,156,132,109,66,251,239,164,75,187,15,136,20,197,177,159,223,115,236,76,93,219,60,129,168,173,19,242,133,244,74,98,55,107,32,7,229,164,204,88,251,9,188,22,6,189,235,46,135,169,199,166,85,183,177,135,228,135,69,223,130,192,160,196,218,246,112,220,193,226,116,225,111,6,169,208,74,121,187,213,42,97,145,95,105,161,165,235,20,143,207,18,241,16,120,38,221,93,220,170,240,98,99,104,169,55,252,126,176,63,214,72,200,227,226,84,203,8,152,153,106,235,203,230,129,220,107,40,99,135,114,147,1,50,167,6,105,114,40,209,212,62,155,80,88,108,230,42,78,64,152,161,222,140,69,206,180,234,11,120,57,169,246,88,59,171,9,154,213,217,204,225,246,65,105,165,140,35,44,39,23,23,79,18,240,13,25,121,102,165,176,226,21,133,87,6,10,71,126,197,152,6,3,3,130,135,22,166,83,180,139,173,92,226,222,122,182,64,23,237,214,173,68,224,129,35,237,241,163,82,20,253,159,216,0,243,68,161,31,239,66,58,124,232,103,246,120,211,247,172,207,63,178,211,62,178,35,35,180,142,212,223,47,144,253,2,161,86,85,41,25,2,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new ProblemInCaseEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("433ede31-e4bd-4390-b1ac-8bbc040206c0"));
		}

		#endregion

	}

	#endregion


	#region Class: ProblemInCaseEventsProcess

	/// <exclude/>
	public class ProblemInCaseEventsProcess : ProblemInCase_ProblemEventsProcess
	{

		public ProblemInCaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

