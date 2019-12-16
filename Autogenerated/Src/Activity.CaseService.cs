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
	using System.Linq;
	using System.Text;
	using System.Text.RegularExpressions;
	using SystemSettings = Terrasoft.Core.Configuration.SysSettings;
	using Terrasoft.Common;
	using Terrasoft.Common.Json;
	using Terrasoft.Configuration.Packages.Case;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.DcmProcess;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Factories;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;
	using Terrasoft.Core.Store;
	using Terrasoft.GlobalSearch.Indexing;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities.Json.Converters;

	#region Class: Activity_CaseService_TerrasoftSchema

	/// <exclude/>
	public class Activity_CaseService_TerrasoftSchema : Terrasoft.Configuration.Activity_Lead_TerrasoftSchema
	{

		#region Constructors: Public

		public Activity_CaseService_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public Activity_CaseService_TerrasoftSchema(Activity_CaseService_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public Activity_CaseService_TerrasoftSchema(Activity_CaseService_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private EntitySchemaIndex CreateIX_Activity_SendDateIndex() {
			EntitySchemaIndex index = new EntitySchemaIndex() {
				IsAutoName = true,
				IsClustered = false,
				IsUnique = false
			};
			index.UId = new Guid("1e60c588-1264-4219-9f83-2a3e68bc54b6");
			index.Name = "IX_Activity_SendDate";
			index.CreatedInSchemaUId = new Guid("8a8f2187-7621-4d4b-904d-af660770442d");
			index.ModifiedInSchemaUId = new Guid("8a8f2187-7621-4d4b-904d-af660770442d");
			index.CreatedInPackageId = new Guid("d931fb95-07c0-4237-ab9a-64ecf34e5aed");
			EntitySchemaIndexColumn sendDateIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("b8f4292f-5ae6-43ca-9685-1301b31eba68"),
				ColumnUId = new Guid("6689a019-c904-4b25-a89d-d17f3f3767cc"),
				CreatedInSchemaUId = new Guid("8a8f2187-7621-4d4b-904d-af660770442d"),
				ModifiedInSchemaUId = new Guid("8a8f2187-7621-4d4b-904d-af660770442d"),
				CreatedInPackageId = new Guid("d931fb95-07c0-4237-ab9a-64ecf34e5aed"),
				OrderDirection = OrderDirectionStrict.Descending
			};
			index.Columns.Add(sendDateIndexColumn);
			return index;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("940f5ed1-3e44-4f78-8d2a-896cdff50f60");
			Name = "Activity_CaseService_Terrasoft";
			ParentSchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89");
			ExtendParent = true;
			CreatedInPackageId = new Guid("a8b8271f-5617-41e0-bbb4-0ac43169bb55");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("fe3732e9-7b58-4e30-afc3-b121bba13a8c")) == null) {
				Columns.Add(CreateIsNotPublishedColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateIsNotPublishedColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("fe3732e9-7b58-4e30-afc3-b121bba13a8c"),
				Name = @"IsNotPublished",
				CreatedInSchemaUId = new Guid("940f5ed1-3e44-4f78-8d2a-896cdff50f60"),
				ModifiedInSchemaUId = new Guid("940f5ed1-3e44-4f78-8d2a-896cdff50f60"),
				CreatedInPackageId = new Guid("3f3b9f1f-d04f-4426-ad64-9acca96812fe")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeIndexes() {
			base.InitializeIndexes();
			Indexes.Add(CreateIX_Activity_SendDateIndex());
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateActivity_CaseService_TerrasoftEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateActivity_CaseService_TerrasoftEventsProcessSchema() {
			var schema = new Activity_CaseService_TerrasoftEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new Activity_CaseService_Terrasoft(userConnection){Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new Activity_CaseServiceEventsProcess(userConnnection);
		}

		public override object Clone() {
			return new Activity_CaseService_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new Activity_CaseService_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("940f5ed1-3e44-4f78-8d2a-896cdff50f60"));
		}

		#endregion

	}

	#endregion

	#region Class: Activity_CaseService_Terrasoft

	/// <summary>
	/// Activity.
	/// </summary>
	public class Activity_CaseService_Terrasoft : Terrasoft.Configuration.Activity_Lead_Terrasoft
	{

		#region Constructors: Public

		public Activity_CaseService_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Activity_CaseService_Terrasoft";
		}

		public Activity_CaseService_Terrasoft(Activity_CaseService_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Is not published.
		/// </summary>
		public bool IsNotPublished {
			get {
				return GetTypedColumnValue<bool>("IsNotPublished");
			}
			set {
				SetColumnValue("IsNotPublished", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new Activity_CaseServiceEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("Activity_CaseService_TerrasoftDeleted", e);
			Saved += (s, e) => ThrowEvent("Activity_CaseService_TerrasoftSaved", e);
			Updated += (s, e) => ThrowEvent("Activity_CaseService_TerrasoftUpdated", e);
			Updating += (s, e) => ThrowEvent("Activity_CaseService_TerrasoftUpdating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new Activity_CaseService_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: Activity_CaseServiceEventsProcess

	/// <exclude/>
	public class Activity_CaseServiceEventsProcess<TEntity> : Terrasoft.Configuration.Activity_LeadEventsProcess<TEntity> where TEntity : Activity_CaseService_Terrasoft
	{

		public Activity_CaseServiceEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Activity_CaseServiceEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("940f5ed1-3e44-4f78-8d2a-896cdff50f60");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		private ProcessFlowElement _activityUpdatingEventSubProcess1;
		public ProcessFlowElement ActivityUpdatingEventSubProcess1 {
			get {
				return _activityUpdatingEventSubProcess1 ?? (_activityUpdatingEventSubProcess1 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "ActivityUpdatingEventSubProcess1",
					SchemaElementUId = new Guid("2b1fe841-bea6-459c-8253-c4a4d0048ec1"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _activityUpdatingStartMessage;
		public ProcessFlowElement ActivityUpdatingStartMessage {
			get {
				return _activityUpdatingStartMessage ?? (_activityUpdatingStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ActivityUpdatingStartMessage",
					SchemaElementUId = new Guid("5ec3f798-cf6f-4f34-b4f5-49252580c277"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _activityUpdatingScriptTask;
		public ProcessScriptTask ActivityUpdatingScriptTask {
			get {
				return _activityUpdatingScriptTask ?? (_activityUpdatingScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ActivityUpdatingScriptTask",
					SchemaElementUId = new Guid("8f3c45b6-4b5d-4023-88a1-0dc734deb856"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ActivityUpdatingScriptTaskExecute,
				});
			}
		}

		private ProcessScriptTask _activityInsertedStartMessageScriptTask;
		public ProcessScriptTask ActivityInsertedStartMessageScriptTask {
			get {
				return _activityInsertedStartMessageScriptTask ?? (_activityInsertedStartMessageScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ActivityInsertedStartMessageScriptTask",
					SchemaElementUId = new Guid("6d01caa4-acfe-44fc-8a73-fffb39bc00b4"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ActivityInsertedStartMessageScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _activityInsertedStartMessage;
		public ProcessFlowElement ActivityInsertedStartMessage {
			get {
				return _activityInsertedStartMessage ?? (_activityInsertedStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ActivityInsertedStartMessage",
					SchemaElementUId = new Guid("b80714b7-fff6-48b5-9b95-4e88352fc1be"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _activityUpdatedStartMessage;
		public ProcessFlowElement ActivityUpdatedStartMessage {
			get {
				return _activityUpdatedStartMessage ?? (_activityUpdatedStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ActivityUpdatedStartMessage",
					SchemaElementUId = new Guid("1f92bc7d-79dd-463b-abef-9632333ab2fa"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTask3_27f6989e78934513b0eb72559cae0133;
		public ProcessScriptTask ScriptTask3_27f6989e78934513b0eb72559cae0133 {
			get {
				return _scriptTask3_27f6989e78934513b0eb72559cae0133 ?? (_scriptTask3_27f6989e78934513b0eb72559cae0133 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask3_27f6989e78934513b0eb72559cae0133",
					SchemaElementUId = new Guid("27f6989e-7893-4513-b0eb-72559cae0133"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask3_27f6989e78934513b0eb72559cae0133Execute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[ActivityUpdatingEventSubProcess1.SchemaElementUId] = new Collection<ProcessFlowElement> { ActivityUpdatingEventSubProcess1 };
			FlowElements[ActivityUpdatingStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { ActivityUpdatingStartMessage };
			FlowElements[ActivityUpdatingScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { ActivityUpdatingScriptTask };
			FlowElements[ActivityInsertedStartMessageScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { ActivityInsertedStartMessageScriptTask };
			FlowElements[ActivityInsertedStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { ActivityInsertedStartMessage };
			FlowElements[ActivityUpdatedStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { ActivityUpdatedStartMessage };
			FlowElements[ScriptTask3_27f6989e78934513b0eb72559cae0133.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask3_27f6989e78934513b0eb72559cae0133 };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "ActivityUpdatingEventSubProcess1":
						break;
					case "ActivityUpdatingStartMessage":
						e.Context.QueueTasks.Enqueue("ActivityUpdatingScriptTask");
						break;
					case "ActivityUpdatingScriptTask":
						break;
					case "ActivityInsertedStartMessageScriptTask":
						break;
					case "ActivityInsertedStartMessage":
						e.Context.QueueTasks.Enqueue("ActivityInsertedStartMessageScriptTask");
						break;
					case "ActivityUpdatedStartMessage":
						e.Context.QueueTasks.Enqueue("ScriptTask3_27f6989e78934513b0eb72559cae0133");
						break;
					case "ScriptTask3_27f6989e78934513b0eb72559cae0133":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("ActivityUpdatingStartMessage");
			ActivatedEventElements.Add("ActivityInsertedStartMessage");
			ActivatedEventElements.Add("ActivityUpdatedStartMessage");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "ActivityUpdatingEventSubProcess1":
					context.QueueTasks.Dequeue();
					break;
				case "ActivityUpdatingStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "ActivityUpdatingStartMessage";
					result = ActivityUpdatingStartMessage.Execute(context);
					break;
				case "ActivityUpdatingScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "ActivityUpdatingScriptTask";
					result = ActivityUpdatingScriptTask.Execute(context, ActivityUpdatingScriptTaskExecute);
					break;
				case "ActivityInsertedStartMessageScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "ActivityInsertedStartMessageScriptTask";
					result = ActivityInsertedStartMessageScriptTask.Execute(context, ActivityInsertedStartMessageScriptTaskExecute);
					break;
				case "ActivityInsertedStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "ActivityInsertedStartMessage";
					result = ActivityInsertedStartMessage.Execute(context);
					break;
				case "ActivityUpdatedStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "ActivityUpdatedStartMessage";
					result = ActivityUpdatedStartMessage.Execute(context);
					break;
				case "ScriptTask3_27f6989e78934513b0eb72559cae0133":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask3_27f6989e78934513b0eb72559cae0133";
					result = ScriptTask3_27f6989e78934513b0eb72559cae0133.Execute(context, ScriptTask3_27f6989e78934513b0eb72559cae0133Execute);
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

		public virtual bool ActivityUpdatingScriptTaskExecute(ProcessExecutingContext context) {
			var caseId = Entity.GetTypedColumnValue<Guid>("CaseId");
			var activityId = Entity.PrimaryColumnValue;
			if (caseId != Guid.Empty){
				if (UseCategoryFilter()){
					var caseOldId = Entity.GetTypedOldColumnValue<Guid>("CaseId");
					if (caseOldId == Guid.Empty){
						if (IsRequiredFieldsValid(caseId)) {
							SetCaseCategory(caseId, activityId);
						}
					}
				}
				if(Entity.GetTypedColumnValue<bool>("IsNotPublished")){
					Entity.SetColumnValue("IsNotPublished", false);
					var copyUtilityDetail = new CaseEntityFileCopier(UserConnection);
					copyUtilityDetail.CopyAll("Activity", activityId, caseId);
				}
			}
			return true;
		}

		public virtual bool ActivityInsertedStartMessageScriptTaskExecute(ProcessExecutingContext context) {
			var caseId = Entity.GetTypedColumnValue<Guid>("CaseId");
			if(caseId != Guid.Empty){
				NotifyListeners();
			}
			return true;
		}

		public virtual bool ScriptTask3_27f6989e78934513b0eb72559cae0133Execute(ProcessExecutingContext context) {
			var caseId = Entity.GetTypedColumnValue<Guid>("CaseId");
			if(caseId != Guid.Empty && UserConnection.GetIsFeatureEnabled("CanUpdateHistoryMessage")){
				NotifyListeners();
			}
			return true;
		}

		public override void PrepereSynchronizeSubjectRemindingUserTask(SynchronizeSubjectRemindingUserTask userTask, Guid contact, DateTime remindTime, bool active, Guid source) {
			base.PrepereSynchronizeSubjectRemindingUserTask(userTask, contact, remindTime, active, source);
			bool isFeatureEnabled = FeatureUtilities.GetIsFeatureEnabled(UserConnection, "NotificationV2");
			if (isFeatureEnabled && active) {
				IRemindingTextFormer textFormer = ClassFactory.Get<ActivityRemindingTextFormer>(
					new ConstructorArgument("userConnection", UserConnection));
				string accountName = GetLookupDisplayColumnValue(Entity, "Account");
				string contactName = GetLookupDisplayColumnValue(Entity, "Contact");
				string title = Entity.GetTypedColumnValue<string>("Title");
				userTask.SubjectCaption = textFormer.GetBody(new Dictionary<string, object> {
					{"AccountName", accountName},
					{"ContactName", contactName},
					{"Title", title}
				});
				userTask.PopupTitle = textFormer.GetTitle(new Dictionary<string, object>());
			}
		}

		public override bool OnActivitySaving(ProcessExecutingContext context) {
			var isBaseSavingSuccess = base.OnActivitySaving(context);
			if(isBaseSavingSuccess && Entity.GetTypedColumnValue<Guid>("TypeId") == ActivityConsts.EmailTypeUId) {
				Guid caseValue = Entity.GetTypedColumnValue<Guid>("CaseId");
				Guid caseOldValue = Entity.GetTypedOldColumnValue<Guid>("CaseId");
				if(caseValue != Guid.Empty && caseValue != caseOldValue) {
					var notifier = new EmailMessageNotifier(this.Entity, UserConnection);
					var listener = new CaseMessageListener(UserConnection);
					listener.Update(notifier);
				}
			}
			return isBaseSavingSuccess;
		}

		public override void LocalMessageExecuting(EntityChangeType changeType) {
			var lmHelper = new Terrasoft.Configuration.LocalMessageHelper(this.Entity, UserConnection, changeType);
			lmHelper.CreateLocalMessage();
		}

		public virtual bool UseCategoryFilter() {
			bool getCategoryFromEmail = SystemSettings.GetValue(UserConnection, "DefineCaseCategoryFromMailBox", false);
			return getCategoryFromEmail && UserConnection.GetIsFeatureEnabled("CategoryFromMailBox");
		}

		public virtual bool IsRequiredFieldsValid(Guid caseId) {
			var selectQuery = new Select(UserConnection)
											.Column("c", "CategoryId")
											.Column("c", "ParentActivityId")
										.From("Case").As("c")
										.Where("c", "Id").IsEqual(Column.Const(caseId));
			using (DBExecutor dbExec = UserConnection.EnsureDBConnection()) {
				using (IDataReader reader = dbExec.ExecuteReader(selectQuery.GetSqlText())) {
					while (reader.Read()) {
						Guid categoryId = reader.GetColumnValue<Guid>("CategoryId");
						Guid parentActivityId = reader.GetColumnValue<Guid>("ParentActivityId");
						if (categoryId == Guid.Empty && parentActivityId == Guid.Empty){
							return true;
						}
					}
				}
			}
			return false;
		}

		public virtual string JoinRecipients(string recipients, string recipient) {
			if (!string.IsNullOrEmpty(recipient)) {
				recipients = string.Join(";", recipients, recipient);
			}
			return recipients;
		}

		public virtual string GetRecipients(Guid activityId) {
			string recipients = string.Empty;
			var selectQuery = new Select(UserConnection)
									.Column("a", "Recepient")
									.Column("a", "CopyRecepient")
									.Column("a", "BlindCopyRecepient")
									.From("Activity").As("a")
								.Where("a", "Id").IsEqual(Column.Const(activityId));
			using (DBExecutor dbExec = UserConnection.EnsureDBConnection()) {
				using (IDataReader reader = dbExec.ExecuteReader(selectQuery.GetSqlText())) {
					while (reader.Read()) {
						string recipient = reader.GetColumnValue<string>("Recepient");
						recipients = JoinRecipients(recipients, recipient);
						string copyRecipient = reader.GetColumnValue<string>("CopyRecepient");
						recipients = JoinRecipients(recipients, copyRecipient);
						string blindCopyRecipient = reader.GetColumnValue<string>("BlindCopyRecepient");
						recipients = JoinRecipients(recipients, blindCopyRecipient);
					}
				}
			}
			return recipients;
		}

		public virtual void SetCaseCategory(Guid caseId, Guid activityId) {
			var caseEntity = UserConnection.EntitySchemaManager.GetInstanceByName("Case").CreateEntity(UserConnection);
			caseEntity.FetchFromDB(caseId);
			caseEntity.SetColumnValue("ParentActivityId", activityId);
			string recipients = GetRecipients(activityId);
			CategoryFromSupportMailBox supportMailBoxStore = new CategoryFromSupportMailBox(UserConnection);
			CategoryProvider categoryProvider = new CategoryProvider(supportMailBoxStore);
			CategoryProviderWrapper categoryWrapper = new CategoryProviderWrapper(UserConnection);
			categoryWrapper.CategoryProvider = categoryProvider;
			Guid categoryId = categoryWrapper.GetCategoryFromSupportMailBox(recipients);
			if (categoryId == Guid.Empty){
				categoryId = SystemSettings.GetValue(UserConnection, CaseConsts.DefaultCaseCategory, Guid.Empty);
			}
			if (categoryId != Guid.Empty){
				caseEntity.SetColumnValue("CategoryId", categoryId);
			}
			caseEntity.Save(false);
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "Activity_CaseService_TerrasoftUpdating":
							if (ActivatedEventElements.Contains("ActivityUpdatingStartMessage")) {
							context.QueueTasks.Enqueue("ActivityUpdatingStartMessage");
						}
						break;
					case "ActivityInserted":
							if (ActivatedEventElements.Contains("ActivityInsertedStartMessage")) {
							context.QueueTasks.Enqueue("ActivityInsertedStartMessage");
							ProcessQueue(context);
							return;
						}
						break;
					case "Activity_CaseService_TerrasoftUpdated":
							if (ActivatedEventElements.Contains("ActivityUpdatedStartMessage")) {
							context.QueueTasks.Enqueue("ActivityUpdatedStartMessage");
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
		}

		public override object CloneShallow() {
			return base.CloneShallow();
		}

		#endregion

	}

	#endregion

	#region Class: Activity_CaseServiceEventsProcess

	/// <exclude/>
	public class Activity_CaseServiceEventsProcess : Activity_CaseServiceEventsProcess<Activity_CaseService_Terrasoft>
	{

		public Activity_CaseServiceEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: Activity_CaseService_TerrasoftEventsProcessSchema

	/// <exclude/>
	public class Activity_CaseService_TerrasoftEventsProcessSchema : Terrasoft.Configuration.Activity_Lead_TerrasoftEventsProcessSchema
	{

		#region Constructors: Public

		public Activity_CaseService_TerrasoftEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public Activity_CaseService_TerrasoftEventsProcessSchema(Activity_CaseService_TerrasoftEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "Activity_CaseServiceEventsProcess";
			UId = new Guid("331a6b10-aa63-4689-8fe0-695a1d2c6e27");
			CreatedInPackageId = new Guid("a8b8271f-5617-41e0-bbb4-0ac43169bb55");
			CreatedInSchemaUId = Guid.Empty;
			CreatedInVersion = @"0.0.0.0";
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("58b52121-53e1-417d-8032-2d115c495db8");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaCaseServiceActivityLaneSet = CreateCaseServiceActivityLaneSetLaneSet();
			LaneSets.Add(schemaCaseServiceActivityLaneSet);
			ProcessSchemaLane schemaCaseServiceActivityLane = CreateCaseServiceActivityLaneLane();
			schemaCaseServiceActivityLaneSet.Lanes.Add(schemaCaseServiceActivityLane);
			ProcessSchemaEventSubProcess activityupdatingeventsubprocess1 = CreateActivityUpdatingEventSubProcess1EventSubProcess();
			FlowElements.Add(activityupdatingeventsubprocess1);
			ProcessSchemaStartMessageEvent activityupdatingstartmessage = CreateActivityUpdatingStartMessageStartMessageEvent();
			activityupdatingeventsubprocess1.FlowElements.Add(activityupdatingstartmessage);
			ProcessSchemaScriptTask activityupdatingscripttask = CreateActivityUpdatingScriptTaskScriptTask();
			activityupdatingeventsubprocess1.FlowElements.Add(activityupdatingscripttask);
			ProcessSchemaScriptTask activityinsertedstartmessagescripttask = CreateActivityInsertedStartMessageScriptTaskScriptTask();
			activityupdatingeventsubprocess1.FlowElements.Add(activityinsertedstartmessagescripttask);
			ProcessSchemaStartMessageEvent activityinsertedstartmessage = CreateActivityInsertedStartMessageStartMessageEvent();
			activityupdatingeventsubprocess1.FlowElements.Add(activityinsertedstartmessage);
			ProcessSchemaStartMessageEvent activityupdatedstartmessage = CreateActivityUpdatedStartMessageStartMessageEvent();
			activityupdatingeventsubprocess1.FlowElements.Add(activityupdatedstartmessage);
			ProcessSchemaScriptTask scripttask3_27f6989e78934513b0eb72559cae0133 = CreateScriptTask3_27f6989e78934513b0eb72559cae0133ScriptTask();
			activityupdatingeventsubprocess1.FlowElements.Add(scripttask3_27f6989e78934513b0eb72559cae0133);
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
			FlowElements.Add(CreateSequenceFlow5SequenceFlow());
			FlowElements.Add(CreateSequenceFlow7_d819c62d0fad47ecbae1bee84e9dbdf8SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3",
				UId = new Guid("6bc058d1-9b76-41a0-a606-c1390919649e"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f3eebf06-e49c-4795-8233-d57fe88b16b0"),
				CreatedInPackageId = new Guid("3f3b9f1f-d04f-4426-ad64-9acca96812fe"),
				CreatedInSchemaUId = new Guid("331a6b10-aa63-4689-8fe0-695a1d2c6e27"),
				CurveCenterPosition = new Point(220, 144),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("331a6b10-aa63-4689-8fe0-695a1d2c6e27"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("5ec3f798-cf6f-4f34-b4f5-49252580c277"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("8f3c45b6-4b5d-4023-88a1-0dc734deb856"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow5SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow5",
				UId = new Guid("7ac76ac2-5181-496c-b080-40eb7b31ed88"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f3eebf06-e49c-4795-8233-d57fe88b16b0"),
				CreatedInPackageId = new Guid("063d07c5-b9e5-4e21-af41-1e4bee0f9f8a"),
				CreatedInSchemaUId = new Guid("331a6b10-aa63-4689-8fe0-695a1d2c6e27"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("331a6b10-aa63-4689-8fe0-695a1d2c6e27"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("b80714b7-fff6-48b5-9b95-4e88352fc1be"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("6d01caa4-acfe-44fc-8a73-fffb39bc00b4"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow7_d819c62d0fad47ecbae1bee84e9dbdf8SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow7_d819c62d0fad47ecbae1bee84e9dbdf8",
				UId = new Guid("d819c62d-0fad-47ec-bae1-bee84e9dbdf8"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f3eebf06-e49c-4795-8233-d57fe88b16b0"),
				CreatedInPackageId = new Guid("33bac096-c819-4c57-86af-fe71bbb0cb56"),
				CreatedInSchemaUId = new Guid("331a6b10-aa63-4689-8fe0-695a1d2c6e27"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("331a6b10-aa63-4689-8fe0-695a1d2c6e27"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("1f92bc7d-79dd-463b-abef-9632333ab2fa"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("27f6989e-7893-4513-b0eb-72559cae0133"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateCaseServiceActivityLaneSetLaneSet() {
			ProcessSchemaLaneSet schemaCaseServiceActivityLaneSet = new ProcessSchemaLaneSet(this) {
				UId = new Guid("ba07cc68-b378-494e-b597-57f726fffffd"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f3eebf06-e49c-4795-8233-d57fe88b16b0"),
				CreatedInPackageId = new Guid("a4038731-88ca-41b4-ad48-4e9eb4a06bfc"),
				CreatedInSchemaUId = new Guid("331a6b10-aa63-4689-8fe0-695a1d2c6e27"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("331a6b10-aa63-4689-8fe0-695a1d2c6e27"),
				Name = @"CaseServiceActivityLaneSet",
				Position = new Point(5, 5),
				Size = new Size(930, 400),
				UseBackgroundMode = false
			};
			return schemaCaseServiceActivityLaneSet;
		}

		protected virtual ProcessSchemaLane CreateCaseServiceActivityLaneLane() {
			ProcessSchemaLane schemaCaseServiceActivityLane = new ProcessSchemaLane(this) {
				UId = new Guid("5d95ca57-07fe-460e-b743-4c53c6796afd"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("ba07cc68-b378-494e-b597-57f726fffffd"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("a4038731-88ca-41b4-ad48-4e9eb4a06bfc"),
				CreatedInSchemaUId = new Guid("331a6b10-aa63-4689-8fe0-695a1d2c6e27"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("331a6b10-aa63-4689-8fe0-695a1d2c6e27"),
				Name = @"CaseServiceActivityLane",
				Position = new Point(29, 0),
				Size = new Size(901, 400),
				UseBackgroundMode = false
			};
			return schemaCaseServiceActivityLane;
		}

		protected virtual ProcessSchemaEventSubProcess CreateActivityUpdatingEventSubProcess1EventSubProcess() {
			ProcessSchemaEventSubProcess schemaActivityUpdatingEventSubProcess1 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("2b1fe841-bea6-459c-8253-c4a4d0048ec1"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5d95ca57-07fe-460e-b743-4c53c6796afd"),
				CreatedInOwnerSchemaUId = new Guid("f3eebf06-e49c-4795-8233-d57fe88b16b0"),
				CreatedInPackageId = new Guid("3f3b9f1f-d04f-4426-ad64-9acca96812fe"),
				CreatedInSchemaUId = new Guid("331a6b10-aa63-4689-8fe0-695a1d2c6e27"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("331a6b10-aa63-4689-8fe0-695a1d2c6e27"),
				Name = @"ActivityUpdatingEventSubProcess1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(22, 20),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(658, 480),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaActivityUpdatingEventSubProcess1;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateActivityUpdatingStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("5ec3f798-cf6f-4f34-b4f5-49252580c277"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("2b1fe841-bea6-459c-8253-c4a4d0048ec1"),
				CreatedInOwnerSchemaUId = new Guid("f3eebf06-e49c-4795-8233-d57fe88b16b0"),
				CreatedInPackageId = new Guid("3f3b9f1f-d04f-4426-ad64-9acca96812fe"),
				CreatedInSchemaUId = new Guid("331a6b10-aa63-4689-8fe0-695a1d2c6e27"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"ActivityUpdating",
				ModifiedInSchemaUId = new Guid("331a6b10-aa63-4689-8fe0-695a1d2c6e27"),
				Name = @"ActivityUpdatingStartMessage",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(43, 86),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateActivityUpdatingScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("8f3c45b6-4b5d-4023-88a1-0dc734deb856"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("2b1fe841-bea6-459c-8253-c4a4d0048ec1"),
				CreatedInOwnerSchemaUId = new Guid("f3eebf06-e49c-4795-8233-d57fe88b16b0"),
				CreatedInPackageId = new Guid("3f3b9f1f-d04f-4426-ad64-9acca96812fe"),
				CreatedInSchemaUId = new Guid("331a6b10-aa63-4689-8fe0-695a1d2c6e27"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("331a6b10-aa63-4689-8fe0-695a1d2c6e27"),
				Name = @"ActivityUpdatingScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(148, 72),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,146,193,110,194,48,16,68,207,201,87,184,57,37,82,196,15,80,42,161,20,16,151,22,181,165,119,131,151,118,37,99,167,182,147,202,170,242,239,93,27,163,70,5,113,200,37,187,51,243,118,146,158,27,182,231,22,214,130,205,216,66,57,116,126,178,2,247,230,91,16,141,150,221,81,189,115,217,193,253,170,67,241,80,22,77,92,45,170,105,222,147,144,239,29,246,164,24,139,55,6,143,220,248,145,118,154,227,129,149,41,228,110,198,130,213,100,113,108,157,175,126,242,44,204,182,22,26,238,224,67,27,191,68,233,192,148,85,24,101,125,130,123,150,226,26,31,189,190,137,152,101,231,224,100,240,63,251,180,176,182,47,240,213,161,1,177,68,144,194,146,27,138,196,91,85,44,238,101,175,224,130,241,25,51,141,235,81,5,49,48,27,242,248,12,225,176,242,70,159,59,173,37,193,174,237,147,118,155,110,39,209,126,2,65,71,170,36,11,145,127,138,139,221,154,29,184,180,16,99,99,81,186,245,91,135,146,164,143,224,56,74,42,76,193,55,11,216,39,71,234,22,26,221,34,245,75,141,155,70,43,5,132,175,85,244,184,208,79,104,215,207,165,44,139,121,58,178,24,223,91,167,255,38,136,135,124,200,13,184,206,40,230,12,125,241,95,212,148,202,172,86,2,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaScriptTask CreateActivityInsertedStartMessageScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("6d01caa4-acfe-44fc-8a73-fffb39bc00b4"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("2b1fe841-bea6-459c-8253-c4a4d0048ec1"),
				CreatedInOwnerSchemaUId = new Guid("f3eebf06-e49c-4795-8233-d57fe88b16b0"),
				CreatedInPackageId = new Guid("063d07c5-b9e5-4e21-af41-1e4bee0f9f8a"),
				CreatedInSchemaUId = new Guid("331a6b10-aa63-4689-8fe0-695a1d2c6e27"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("331a6b10-aa63-4689-8fe0-695a1d2c6e27"),
				Name = @"ActivityInsertedStartMessageScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(148, 186),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,75,44,82,72,78,44,78,245,76,81,176,85,112,205,43,201,44,169,212,115,79,45,9,169,44,72,77,113,206,207,41,205,205,11,75,204,41,77,181,113,47,205,76,177,211,80,114,6,43,85,210,180,230,202,76,211,128,234,83,180,85,0,201,234,185,230,22,148,84,106,86,115,113,250,229,151,100,166,85,250,100,22,151,164,230,165,22,21,107,0,85,215,114,21,165,150,148,22,229,41,148,20,149,166,90,3,0,60,135,186,92,117,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateActivityInsertedStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("b80714b7-fff6-48b5-9b95-4e88352fc1be"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("2b1fe841-bea6-459c-8253-c4a4d0048ec1"),
				CreatedInOwnerSchemaUId = new Guid("f3eebf06-e49c-4795-8233-d57fe88b16b0"),
				CreatedInPackageId = new Guid("063d07c5-b9e5-4e21-af41-1e4bee0f9f8a"),
				CreatedInSchemaUId = new Guid("331a6b10-aa63-4689-8fe0-695a1d2c6e27"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"ActivityInserted",
				ModifiedInSchemaUId = new Guid("331a6b10-aa63-4689-8fe0-695a1d2c6e27"),
				Name = @"ActivityInsertedStartMessage",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(41, 200),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateActivityUpdatedStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("1f92bc7d-79dd-463b-abef-9632333ab2fa"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("2b1fe841-bea6-459c-8253-c4a4d0048ec1"),
				CreatedInOwnerSchemaUId = new Guid("f3eebf06-e49c-4795-8233-d57fe88b16b0"),
				CreatedInPackageId = new Guid("33bac096-c819-4c57-86af-fe71bbb0cb56"),
				CreatedInSchemaUId = new Guid("331a6b10-aa63-4689-8fe0-695a1d2c6e27"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"ActivityUpdated",
				ModifiedInSchemaUId = new Guid("331a6b10-aa63-4689-8fe0-695a1d2c6e27"),
				Name = @"ActivityUpdatedStartMessage",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(41, 306),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask3_27f6989e78934513b0eb72559cae0133ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("27f6989e-7893-4513-b0eb-72559cae0133"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("2b1fe841-bea6-459c-8253-c4a4d0048ec1"),
				CreatedInOwnerSchemaUId = new Guid("f3eebf06-e49c-4795-8233-d57fe88b16b0"),
				CreatedInPackageId = new Guid("33bac096-c819-4c57-86af-fe71bbb0cb56"),
				CreatedInSchemaUId = new Guid("331a6b10-aa63-4689-8fe0-695a1d2c6e27"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("331a6b10-aa63-4689-8fe0-695a1d2c6e27"),
				Name = @"ScriptTask3_27f6989e78934513b0eb72559cae0133",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(148, 292),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,45,141,177,14,130,48,20,69,103,249,138,202,64,96,225,7,16,23,130,72,162,78,226,94,233,133,52,129,87,210,190,154,52,198,127,23,140,243,57,247,220,151,180,162,151,14,173,18,165,168,137,53,135,188,1,223,195,2,85,153,201,207,244,144,147,199,161,241,90,29,211,184,250,169,113,86,68,122,72,255,187,125,41,54,154,215,243,194,65,36,137,232,28,108,101,136,208,179,54,180,229,90,119,130,100,111,81,147,124,78,80,91,136,186,69,73,198,89,59,54,54,92,225,156,28,17,103,217,59,218,221,12,235,33,92,86,2,130,117,233,122,247,137,44,214,0,9,182,30,197,23,43,116,92,61,182,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateUseCategoryFilterMethod());
			Methods.Add(CreateIsRequiredFieldsValidMethod());
			Methods.Add(CreateJoinRecipientsMethod());
			Methods.Add(CreateGetRecipientsMethod());
			Methods.Add(CreateSetCaseCategoryMethod());
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("f83cbea2-10c5-4739-96f1-116937efce77"),
				Name = "Terrasoft.Core.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("ffa69c6a-c8bb-4a61-bc00-b0bcd40a9862")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("19024591-23ea-4b03-9800-93149198129b"),
				Name = "Terrasoft.Core.DB",
				Alias = "",
				CreatedInPackageId = new Guid("ffa69c6a-c8bb-4a61-bc00-b0bcd40a9862")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("fb7b81ba-7c3c-45a5-ae9e-c6c03dceb812"),
				Name = "Terrasoft.UI.WebControls.Controls",
				Alias = "",
				CreatedInPackageId = new Guid("ffa69c6a-c8bb-4a61-bc00-b0bcd40a9862")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("cde525cf-d220-4d2a-b963-e55254c639fc"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("ffa69c6a-c8bb-4a61-bc00-b0bcd40a9862")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7821de68-c82b-4917-a6cd-add2adfbe400"),
				Name = "Terrasoft.Common",
				Alias = "",
				CreatedInPackageId = new Guid("ffa69c6a-c8bb-4a61-bc00-b0bcd40a9862")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d67de76f-9cbc-4bfc-babb-6f65cb89b973"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("ffa69c6a-c8bb-4a61-bc00-b0bcd40a9862")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("74160d3b-65e3-4694-b554-089f2d980e54"),
				Name = "Newtonsoft.Json",
				Alias = "",
				CreatedInPackageId = new Guid("ffa69c6a-c8bb-4a61-bc00-b0bcd40a9862")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e401300a-9f16-40c2-9788-cf310ae9d1c5"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("ffa69c6a-c8bb-4a61-bc00-b0bcd40a9862")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("ca241c6a-6bd2-4e33-ae26-164063bfb504"),
				Name = "System.Text",
				Alias = "",
				CreatedInPackageId = new Guid("ffa69c6a-c8bb-4a61-bc00-b0bcd40a9862")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("ed374225-e41d-4643-8234-a4c89997d648"),
				Name = "System.Linq",
				Alias = "",
				CreatedInPackageId = new Guid("ffa69c6a-c8bb-4a61-bc00-b0bcd40a9862")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("49a41b26-e223-4e0d-a40a-f81877cefa7a"),
				Name = "Terrasoft.Core.Store",
				Alias = "",
				CreatedInPackageId = new Guid("ffa69c6a-c8bb-4a61-bc00-b0bcd40a9862")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("f1009d8d-2421-44b9-aae4-a6159b28fc60"),
				Name = "System.Text.RegularExpressions",
				Alias = "",
				CreatedInPackageId = new Guid("30de0e3b-0a22-4b21-aec2-eb5dee3a342f")
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
				UId = new Guid("44c2ca34-4641-4249-93e0-e11c641583b8"),
				Name = "Terrasoft.Core.Configuration.SysSettings",
				Alias = "SystemSettings",
				CreatedInPackageId = new Guid("77fa8847-960e-4748-ad77-e37bb90e03a0")
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
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d0e41fbb-a508-42f2-a460-48f0b41ed535"),
				Name = "Terrasoft.Configuration.Packages.Case",
				Alias = "",
				CreatedInPackageId = new Guid("33bac096-c819-4c57-86af-fe71bbb0cb56")
			});
		}

		protected override SchemaMethod CreatePrepereSynchronizeSubjectRemindingUserTaskMethod() {
			SchemaMethod method = base.CreatePrepereSynchronizeSubjectRemindingUserTaskMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,146,95,79,194,48,20,197,159,183,79,209,236,129,148,164,225,193,87,129,4,7,24,18,67,136,12,223,203,118,193,202,214,187,244,143,58,9,223,221,118,27,50,212,196,248,180,238,246,158,211,223,185,237,150,107,24,172,20,148,160,96,93,201,244,89,161,20,31,176,182,219,23,72,205,35,20,66,102,66,238,55,26,84,194,245,129,218,118,193,72,138,210,240,212,48,162,234,166,68,20,192,136,43,136,87,247,213,104,85,10,253,219,112,139,152,19,161,231,192,141,85,48,147,124,155,67,70,70,164,45,108,140,200,133,17,160,7,247,96,22,223,218,168,63,53,70,41,29,137,64,201,72,180,68,35,118,34,229,254,247,233,38,114,254,98,71,232,15,251,94,175,5,233,147,99,24,44,190,82,36,240,110,230,168,10,80,196,92,150,35,18,231,92,235,185,147,160,170,60,200,112,226,213,194,84,191,40,199,52,12,2,9,111,196,129,105,163,172,23,77,212,222,22,32,13,141,236,21,113,196,200,117,132,190,35,14,156,202,57,58,194,20,173,52,75,94,128,67,112,167,62,32,30,108,57,21,186,204,121,21,99,110,11,249,196,115,11,116,38,141,99,113,241,39,141,36,234,184,180,183,240,31,151,184,145,116,93,220,78,238,245,77,143,31,65,82,149,144,117,228,195,166,115,76,163,196,247,214,226,243,91,24,180,175,37,230,165,15,233,124,46,211,245,94,119,152,85,212,143,108,42,234,41,112,85,181,118,140,96,173,28,251,123,10,142,231,128,62,77,196,186,19,58,177,122,63,190,164,141,88,55,123,187,223,176,177,38,207,41,12,78,87,152,43,44,109,153,180,81,175,17,235,234,31,140,212,223,222,233,19,120,187,20,90,49,3,0,0 };
			return method;
		}

		protected override SchemaMethod CreateOnActivitySavingMethod() {
			SchemaMethod method = base.CreateOnActivitySavingMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,82,209,74,195,64,16,124,110,32,255,112,246,161,92,64,242,3,49,130,134,82,10,173,125,168,241,253,204,109,235,65,186,9,185,77,52,136,255,238,222,53,209,10,145,194,61,237,236,204,206,12,215,169,70,24,251,168,44,236,85,103,240,184,111,139,2,172,21,169,120,229,89,188,195,135,130,76,103,168,63,195,178,168,144,224,131,162,36,12,204,65,78,49,23,11,177,68,98,70,188,2,122,238,107,208,89,85,182,39,124,81,101,11,119,171,214,232,123,57,119,243,181,158,71,34,77,197,120,33,171,208,146,141,151,39,101,74,135,231,107,29,137,207,48,152,57,142,40,248,144,151,96,107,215,245,51,222,118,250,201,37,125,87,234,127,20,24,185,34,194,97,127,29,220,164,194,173,176,213,154,122,23,248,15,116,121,234,28,96,214,113,203,88,145,57,24,104,248,58,194,187,240,49,183,92,152,58,194,211,0,73,122,51,92,128,247,118,43,114,11,13,119,130,192,253,84,232,93,120,161,210,88,2,252,17,114,46,7,157,205,128,200,41,234,72,139,243,90,43,2,57,250,241,232,87,24,240,107,128,218,6,167,254,67,242,13,60,27,151,184,40,2,0,0 };
			return method;
		}

		protected override SchemaMethod CreateLocalMessageExecutingMethod() {
			SchemaMethod method = base.CreateLocalMessageExecutingMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,77,141,75,10,194,48,16,134,247,158,98,150,45,148,92,160,184,42,130,11,221,213,3,12,225,111,26,136,147,50,51,86,122,123,45,69,112,255,61,86,86,42,207,43,202,2,165,51,9,222,52,66,149,173,78,30,134,42,83,78,47,101,207,85,194,173,70,46,119,152,113,194,33,52,62,103,11,23,241,236,91,71,15,131,126,13,65,220,241,142,226,204,146,48,110,11,218,254,244,123,132,65,193,142,255,86,211,246,31,106,54,191,216,134,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateUseCategoryFilterMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("6923584b-9a54-4394-b106-a5f6492fcdfb"),
				Name = "UseCategoryFilter",
				CreatedInSchemaUId = new Guid("331a6b10-aa63-4689-8fe0-695a1d2c6e27"),
				CreatedInPackageId = new Guid("77fa8847-960e-4748-ad77-e37bb90e03a0"),
				ResultValueTypeName = "bool"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,205,65,10,131,48,16,70,225,125,79,17,178,16,5,233,5,164,155,166,42,93,116,37,237,126,108,127,67,32,206,64,50,66,189,125,237,174,5,15,240,190,55,138,68,227,161,142,20,94,210,218,37,153,219,153,66,52,39,51,172,89,49,15,80,13,236,243,177,135,62,40,46,40,239,25,201,9,51,158,26,132,107,99,47,152,2,195,81,198,47,115,219,148,179,188,109,109,38,138,25,85,115,72,208,37,241,254,174,40,204,191,251,253,93,115,7,218,26,180,76,99,196,171,180,123,131,170,249,0,37,65,86,253,198,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateIsRequiredFieldsValidMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("b846b749-33fa-47b7-a33e-7a6c3f808c33"),
				Name = "IsRequiredFieldsValid",
				CreatedInSchemaUId = new Guid("331a6b10-aa63-4689-8fe0-695a1d2c6e27"),
				CreatedInPackageId = new Guid("77fa8847-960e-4748-ad77-e37bb90e03a0"),
				ResultValueTypeName = "bool"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("cf9bdd65-cb45-4371-878c-75b69b7fd3b5"),
				Name = "caseId",
				CreatedInSchemaUId = new Guid("331a6b10-aa63-4689-8fe0-695a1d2c6e27"),
				ModifiedInSchemaUId = new Guid("331a6b10-aa63-4689-8fe0-695a1d2c6e27"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("77fa8847-960e-4748-ad77-e37bb90e03a0")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,145,203,110,194,48,16,69,215,65,226,31,70,89,32,91,170,252,3,148,74,16,82,148,93,91,250,88,155,100,128,72,198,129,177,205,67,85,255,189,118,157,150,208,135,26,37,142,229,185,247,220,204,100,47,9,12,42,44,237,189,67,58,193,8,52,30,96,254,113,194,158,12,82,214,104,237,247,117,163,121,191,151,180,151,200,26,229,54,154,165,101,122,5,105,38,45,174,26,58,21,85,250,167,230,78,18,106,59,246,160,125,109,47,149,226,150,154,13,243,20,131,41,23,99,19,28,157,234,203,26,9,91,74,240,137,194,228,59,39,21,139,124,31,163,141,101,165,119,23,21,231,195,126,207,153,90,175,128,77,39,249,17,75,103,27,130,106,17,182,190,183,203,134,68,174,141,35,156,78,206,71,140,115,120,245,217,45,163,152,74,43,31,80,86,72,64,241,53,106,105,34,210,49,86,89,103,134,98,134,118,190,83,143,120,180,30,23,121,201,97,93,43,4,22,33,34,152,62,163,146,100,230,234,10,202,175,33,250,136,86,230,65,177,201,103,169,28,94,7,221,13,187,24,247,240,12,216,126,155,240,127,152,159,127,36,194,234,37,176,238,199,140,32,24,68,190,217,218,19,12,6,191,228,116,21,60,182,148,16,90,71,26,44,57,140,216,183,176,134,197,63,254,110,235,75,169,12,14,223,1,121,89,95,204,133,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateJoinRecipientsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("2507789d-b275-47b4-b30c-0c75d3a55b85"),
				Name = "JoinRecipients",
				CreatedInSchemaUId = new Guid("331a6b10-aa63-4689-8fe0-695a1d2c6e27"),
				CreatedInPackageId = new Guid("77fa8847-960e-4748-ad77-e37bb90e03a0"),
				ResultValueTypeName = "string"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("e29b84a1-4877-49e4-bc43-7548b48c2c95"),
				Name = "recipients",
				CreatedInSchemaUId = new Guid("331a6b10-aa63-4689-8fe0-695a1d2c6e27"),
				ModifiedInSchemaUId = new Guid("331a6b10-aa63-4689-8fe0-695a1d2c6e27"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("77fa8847-960e-4748-ad77-e37bb90e03a0")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("0a53d151-5d23-41ca-9eeb-19baa934543b"),
				Name = "recipient",
				CreatedInSchemaUId = new Guid("331a6b10-aa63-4689-8fe0-695a1d2c6e27"),
				ModifiedInSchemaUId = new Guid("331a6b10-aa63-4689-8fe0-695a1d2c6e27"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("77fa8847-960e-4748-ad77-e37bb90e03a0")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,203,76,83,208,80,44,46,41,202,204,75,215,243,44,246,43,205,201,241,47,114,205,45,40,169,212,40,74,77,206,44,200,76,205,43,209,212,84,168,230,229,226,132,243,139,21,108,21,160,58,188,242,51,243,52,148,172,149,116,20,16,178,72,108,77,107,94,174,90,94,174,162,212,146,210,162,60,36,37,214,0,176,188,3,13,118,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetRecipientsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("9f270b7c-4b33-4732-a9d5-52e1506ab50e"),
				Name = "GetRecipients",
				CreatedInSchemaUId = new Guid("331a6b10-aa63-4689-8fe0-695a1d2c6e27"),
				CreatedInPackageId = new Guid("77fa8847-960e-4748-ad77-e37bb90e03a0"),
				ResultValueTypeName = "string"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("e4cd82d1-db70-4092-8b1b-11b200266beb"),
				Name = "activityId",
				CreatedInSchemaUId = new Guid("331a6b10-aa63-4689-8fe0-695a1d2c6e27"),
				ModifiedInSchemaUId = new Guid("331a6b10-aa63-4689-8fe0-695a1d2c6e27"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("77fa8847-960e-4748-ad77-e37bb90e03a0")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,83,201,110,194,48,16,61,7,137,127,176,114,114,36,228,31,160,84,98,73,171,244,86,232,114,54,201,168,88,50,54,120,1,162,170,255,222,73,28,74,66,139,10,81,22,107,230,205,123,179,197,58,35,212,7,49,144,139,141,0,229,44,25,17,91,219,88,186,222,184,114,216,239,237,184,33,22,36,228,238,217,131,41,17,160,96,79,22,181,133,190,90,48,83,173,20,158,133,86,73,191,23,213,23,155,106,233,215,138,198,60,30,144,120,14,57,212,236,241,5,192,84,111,202,127,65,19,41,84,113,9,249,96,244,154,198,99,204,98,39,92,25,39,108,108,171,176,35,128,189,175,192,64,67,148,21,232,207,108,186,245,92,210,32,129,74,202,58,202,155,248,172,72,18,172,220,219,170,55,116,54,73,15,144,123,167,13,41,150,213,17,91,208,173,155,165,202,122,3,179,201,201,68,147,132,124,162,122,195,145,205,184,227,115,224,5,24,108,118,253,25,53,108,44,176,67,240,210,86,171,217,35,184,197,86,190,192,193,33,93,224,139,246,43,33,129,208,64,194,170,160,163,84,20,217,179,105,162,70,131,67,166,80,233,27,151,30,238,2,240,158,182,71,51,172,41,58,155,240,164,133,154,255,24,232,201,55,56,105,52,113,141,116,30,230,115,173,252,217,56,111,75,161,163,213,77,99,217,218,149,107,115,249,107,191,110,75,232,183,106,32,248,194,23,62,120,27,112,222,168,214,239,54,252,6,236,0,103,70,129,3,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSetCaseCategoryMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("58f023ac-56af-4cb7-b486-3d38661bf47d"),
				Name = "SetCaseCategory",
				CreatedInSchemaUId = new Guid("331a6b10-aa63-4689-8fe0-695a1d2c6e27"),
				CreatedInPackageId = new Guid("77fa8847-960e-4748-ad77-e37bb90e03a0"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("bf5da045-33a5-47e1-a792-f63f846e55dd"),
				Name = "caseId",
				CreatedInSchemaUId = new Guid("331a6b10-aa63-4689-8fe0-695a1d2c6e27"),
				ModifiedInSchemaUId = new Guid("331a6b10-aa63-4689-8fe0-695a1d2c6e27"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("77fa8847-960e-4748-ad77-e37bb90e03a0")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("5db54768-b0af-4d40-be4b-b6510165ebd6"),
				Name = "activityId",
				CreatedInSchemaUId = new Guid("331a6b10-aa63-4689-8fe0-695a1d2c6e27"),
				ModifiedInSchemaUId = new Guid("331a6b10-aa63-4689-8fe0-695a1d2c6e27"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("77fa8847-960e-4748-ad77-e37bb90e03a0")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,146,75,111,130,64,16,199,207,229,83,108,61,97,98,248,2,198,67,197,71,56,216,152,146,182,231,9,140,186,9,236,146,221,129,150,52,253,238,29,84,144,21,236,113,94,191,249,207,163,2,35,18,176,184,86,36,169,22,11,241,110,209,132,90,41,76,72,106,21,92,252,113,114,194,28,118,160,224,136,38,216,34,69,202,18,168,4,151,245,43,228,232,79,66,70,76,166,65,104,16,232,202,242,93,210,116,238,221,250,4,27,164,228,180,49,58,95,45,253,198,29,165,110,60,70,10,117,86,230,234,3,178,146,249,123,48,168,232,133,73,21,135,163,116,50,19,208,25,92,106,201,72,117,20,6,19,89,72,206,180,60,9,203,124,235,108,223,73,15,89,229,81,155,186,81,16,151,69,161,13,237,64,102,75,253,45,172,99,198,164,13,50,75,225,151,120,92,52,28,181,205,221,27,93,201,20,155,29,223,57,92,102,235,246,71,218,143,224,62,13,20,69,143,218,218,227,208,107,116,236,32,78,121,48,80,189,24,232,158,123,219,82,166,157,59,74,123,57,45,134,23,255,207,174,110,55,98,5,242,32,252,62,139,175,198,248,96,157,23,84,79,127,188,39,167,79,92,91,194,156,95,131,248,214,182,105,115,249,14,119,174,153,104,158,145,109,75,54,88,225,1,202,140,206,158,43,106,214,111,49,247,126,239,53,60,15,53,60,124,203,176,43,227,135,188,49,206,216,126,25,84,232,31,32,179,124,203,63,160,14,130,177,113,3,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new Activity_CaseService_TerrasoftEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("331a6b10-aa63-4689-8fe0-695a1d2c6e27"));
		}

		#endregion

	}

	#endregion

}

