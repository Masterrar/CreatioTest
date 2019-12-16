namespace Terrasoft.WebApp
{

	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.ComponentModel;
	using System.Drawing;
	using System.Globalization;
	using System.Linq;
	using System.Text;
	using System.Threading;
	using System.Web.UI.WebControls;
	using Terrasoft.Common;
	using Terrasoft.Common.Json;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;
	using Terrasoft.Core.Store;
	using Terrasoft.Reports;
	using Terrasoft.UI.WebControls;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities;
	using Terrasoft.UI.WebControls.Utilities.Json.Converters;
	using TSConfiguration = Terrasoft.Configuration;
	using web = System.Web;
	using WebControls = Terrasoft.UI.WebControls.Controls;

	#region Class: CaseNextStatusesGridPageSchema

	/// <exclude/>
	public class CaseNextStatusesGridPageSchema : Terrasoft.WebApp.BaseGridPageSchema
	{

		#region Constructors: Public

		public CaseNextStatusesGridPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public CaseNextStatusesGridPageSchema(CaseNextStatusesGridPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateAddButton() {
			AddButton.AjaxEvents.Click.IsProcessEventHandler = true;
			AddButton.Image = new ControlImage {};
			AddButton.ModifiedInSchemaUId = new Guid("a2b5a788-03e7-4bd7-af51-b57a7326d148");
		}

		private void UpdateCopyButton() {
			CopyButton.Image = new ControlImage {};
			CopyButton.Hidden = true;
			CopyButton.ModifiedInSchemaUId = new Guid("a2b5a788-03e7-4bd7-af51-b57a7326d148");
		}

		private void UpdateEditButton() {
			EditButton.Image = new ControlImage {};
			EditButton.Hidden = true;
			EditButton.ModifiedInSchemaUId = new Guid("a2b5a788-03e7-4bd7-af51-b57a7326d148");
		}

		private void UpdateDeleteButton() {
			DeleteButton.Image = new ControlImage {};
			DeleteButton.ModifiedInSchemaUId = new Guid("a2b5a788-03e7-4bd7-af51-b57a7326d148");
		}

		private void UpdateActionButton() {
			ActionButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73"),
				ImageHash = @"388b646e5dc8d8c8203aeeb3f25b057e"
			};
			ActionButton.ModifiedInSchemaUId = new Guid("a2b5a788-03e7-4bd7-af51-b57a7326d148");
		}

		private void UpdatePrintButton() {
			PrintButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73"),
				ImageHash = @"6e713359f7daa6706f06f1a8f5f065f7"
			};
			PrintButton.ModifiedInSchemaUId = new Guid("a2b5a788-03e7-4bd7-af51-b57a7326d148");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("a2b5a788-03e7-4bd7-af51-b57a7326d148");
		}

		private void UpdateButtonsControlLayout() {
			ButtonsControlLayout.Image = new ControlImage {};
			ButtonsControlLayout.ModifiedInSchemaUId = new Guid("a2b5a788-03e7-4bd7-af51-b57a7326d148");
		}

		private void UpdateSendEmailMenuItem() {
			SendEmailMenuItem.Image = new ControlImage {};
			SendEmailMenuItem.ModifiedInSchemaUId = new Guid("a2b5a788-03e7-4bd7-af51-b57a7326d148");
		}

		private void UpdateSendTemplateEmailMenuItem() {
			SendTemplateEmailMenuItem.Image = new ControlImage {};
			SendTemplateEmailMenuItem.ModifiedInSchemaUId = new Guid("a2b5a788-03e7-4bd7-af51-b57a7326d148");
		}

		private void UpdateCallMenuItem() {
			CallMenuItem.AjaxEvents.PrepareMenu.IsProcessEventHandler = true;
			CallMenuItem.Image = new ControlImage {};
			CallMenuItem.ModifiedInSchemaUId = new Guid("a2b5a788-03e7-4bd7-af51-b57a7326d148");
		}

		private void UpdateShowChangelogMenuItem() {
			ShowChangelogMenuItem.AjaxEvents.Click.IsProcessEventHandler = true;
			ShowChangelogMenuItem.Image = new ControlImage {};
			ShowChangelogMenuItem.ModifiedInSchemaUId = new Guid("a2b5a788-03e7-4bd7-af51-b57a7326d148");
		}

		private void UpdateTreeGrid() {
			TreeGrid.AjaxEvents.ContextMenu.IsProcessEventHandler = true;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("a2b5a788-03e7-4bd7-af51-b57a7326d148");
			RealUId = new Guid("a2b5a788-03e7-4bd7-af51-b57a7326d148");
			Name = "CaseNextStatusesGridPage";
			ParentSchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73");
			CreatedInPackageId = new Guid("305fcfca-4160-4398-90a9-d5e84be0ae12");
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateCaseNextStatusesGridPageEventsProcessSchema();
		}

		protected override void InitializeControls() {
			base.InitializeControls();
			UpdateTreeGrid();
			UpdateShowChangelogMenuItem();
			UpdateCallMenuItem();
			UpdateSendTemplateEmailMenuItem();
			UpdateSendEmailMenuItem();
			UpdateButtonsControlLayout();
			UpdateContextHelpButton();
			UpdatePrintButton();
			UpdateActionButton();
			UpdateDeleteButton();
			UpdateEditButton();
			UpdateCopyButton();
			UpdateAddButton();
			TopLevelControl.MoveItem(0, ButtonsControlLayout);
			ButtonsControlLayout.MoveItem(0, AddButton);
			ButtonsControlLayout.MoveItem(1, CopyButton);
			ButtonsControlLayout.MoveItem(2, EditButton);
			ButtonsControlLayout.MoveItem(3, DeleteButton);
			ButtonsControlLayout.MoveItem(4, SpacerPrintButton);
			ButtonsControlLayout.MoveItem(5, ActionButton);
			ButtonsControlLayout.MoveItem(6, PrintButton);
			ButtonsControlLayout.MoveItem(7, ContextHelpButton);
			TopLevelControl.MoveItem(1, TreeGrid);
			TreeGrid.MoveItem(0, SendEmailMenuItem);
			TreeGrid.MoveItem(1, SendTemplateEmailMenuItem);
			TreeGrid.MoveItem(2, CallMenuItem);
			TreeGrid.MoveItem(3, ShowChangelogMenuItem);
			TopLevelControl.MoveItem(2, DataSource);
			SetControlsDefInheritance(UId);
			InitializeLocalizableValues();
		}

		protected virtual EmbeddedProcessSchema CreateCaseNextStatusesGridPageEventsProcessSchema() {
			var schema = new CaseNextStatusesGridPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected override void UpdateDataSource() {
			base.UpdateDataSource();
			DataSource.SchemaUId = new Guid("e43e673d-fdd2-45d5-8672-a2bca1a14f00");
			DataSource.ModifiedInSchemaUId = new Guid("a2b5a788-03e7-4bd7-af51-b57a7326d148");
			DataSourceStructureColumn column = null;
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ae0e45ca-c495-4fe7-a39d-3ab7278e1617");
			if (column != null) {
				column.UId = new Guid("241e2cfc-3652-42b9-a70a-d73cf8f04f6c");
				column.Name = @"Id";
				column.CreatedInSchemaUId = new Guid("a2b5a788-03e7-4bd7-af51-b57a7326d148");
				column.ModifiedInSchemaUId = new Guid("a2b5a788-03e7-4bd7-af51-b57a7326d148");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
				column.IsAlwaysSelect = true;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("e80190a5-03b2-4095-90f7-a193a960adee");
			if (column != null) {
				column.UId = new Guid("bdcd2043-bf6f-4585-be45-181f3977aa28");
				column.Name = @"CreatedOn";
				column.CreatedInSchemaUId = new Guid("a2b5a788-03e7-4bd7-af51-b57a7326d148");
				column.ModifiedInSchemaUId = new Guid("a2b5a788-03e7-4bd7-af51-b57a7326d148");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ebf6bb93-8aa6-4a01-900d-c6ea67affe21");
			if (column != null) {
				column.UId = new Guid("3b8d33b9-84ab-4221-b6fe-cf6cfca1f845");
				column.Name = @"CreatedBy";
				column.CreatedInSchemaUId = new Guid("a2b5a788-03e7-4bd7-af51-b57a7326d148");
				column.ModifiedInSchemaUId = new Guid("a2b5a788-03e7-4bd7-af51-b57a7326d148");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9928edec-4272-425a-93bb-48743fee4b04");
			if (column != null) {
				column.UId = new Guid("81bc46fd-0eed-43b8-a1ee-ea69eda4c5e2");
				column.Name = @"ModifiedOn";
				column.CreatedInSchemaUId = new Guid("a2b5a788-03e7-4bd7-af51-b57a7326d148");
				column.ModifiedInSchemaUId = new Guid("a2b5a788-03e7-4bd7-af51-b57a7326d148");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3015559e-cbc6-406a-88af-07f7930be832");
			if (column != null) {
				column.UId = new Guid("70833a24-fa46-4f6e-8129-7407e6bb7e65");
				column.Name = @"ModifiedBy";
				column.CreatedInSchemaUId = new Guid("a2b5a788-03e7-4bd7-af51-b57a7326d148");
				column.ModifiedInSchemaUId = new Guid("a2b5a788-03e7-4bd7-af51-b57a7326d148");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3fabd836-6a53-4d8d-9069-6df88d9dae1e");
			if (column != null) {
				column.UId = new Guid("74fb89d6-5219-4a1a-8522-83ea12512e4a");
				column.Name = @"ProcessListeners";
				column.CreatedInSchemaUId = new Guid("a2b5a788-03e7-4bd7-af51-b57a7326d148");
				column.ModifiedInSchemaUId = new Guid("a2b5a788-03e7-4bd7-af51-b57a7326d148");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("4ae71ddd-d8a1-4a88-8e05-068a24d34eb3");
			if (column != null) {
				column.UId = new Guid("bf3bae85-1956-464b-bd9f-12ee5073ccfc");
				column.Name = @"Status";
				column.CreatedInSchemaUId = new Guid("a2b5a788-03e7-4bd7-af51-b57a7326d148");
				column.ModifiedInSchemaUId = new Guid("a2b5a788-03e7-4bd7-af51-b57a7326d148");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("85863593-1a81-4909-8eed-62ce3f43b196");
			if (column != null) {
				column.UId = new Guid("2b41b39d-b26c-4657-bf5b-5211201d1567");
				column.Name = @"NextStatus";
				column.CreatedInSchemaUId = new Guid("a2b5a788-03e7-4bd7-af51-b57a7326d148");
				column.ModifiedInSchemaUId = new Guid("a2b5a788-03e7-4bd7-af51-b57a7326d148");
				column.CreatedInPackageId = Guid.Empty;
				column.Required = true;
			column.Caption.SetResourceInfo("a2b5a78803e74bd7af51b57a7326d148", "Controls.DataSource.DefStructure.Columns.NextStatus.Caption");
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("85863593-1a81-4909-8eed-62ce3f43b196.b78647f6-76db-4d25-b665-00fce475324e");
			if (column != null) {
				column.UId = new Guid("896b23aa-85a3-4ce1-b76b-97396785d671");
				column.Name = @"NextStatus_IsFinal";
				column.CreatedInSchemaUId = new Guid("a2b5a788-03e7-4bd7-af51-b57a7326d148");
				column.ModifiedInSchemaUId = new Guid("a2b5a788-03e7-4bd7-af51-b57a7326d148");
				column.CreatedInPackageId = Guid.Empty;
			column.Caption.SetResourceInfo("a2b5a78803e74bd7af51b57a7326d148", "Controls.DataSource.DefStructure.Columns.NextStatus_IsFinal.Caption");
			}
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override PageSchemaUserControl CreateUserControl() {
			return new CaseNextStatusesGridPageSchemaUserControl();
		}

		public override object Clone() {
			return new CaseNextStatusesGridPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a2b5a788-03e7-4bd7-af51-b57a7326d148"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new CaseNextStatusesGridPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: CaseNextStatusesGridPageEventsProcess

	/// <exclude/>
	public class CaseNextStatusesGridPageEventsProcess<TPage> : Terrasoft.WebApp.BaseGridPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.CaseNextStatusesGridPageSchemaUserControl
	{

		#region Class: SelectStatusUserTaskFlowElement

		/// <exclude/>
		public class SelectStatusUserTaskFlowElement : OpenLookupUserTask
		{

			public SelectStatusUserTaskFlowElement(UserConnection userConnection, CaseNextStatusesGridPageEventsProcess<TPage> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "SelectStatusUserTask";
				IsLogging = false;
				SchemaElementUId = new Guid("b6b6e98f-4e52-4996-88be-34aeb67050a8");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		public CaseNextStatusesGridPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "CaseNextStatusesGridPageEventsProcess";
			SchemaUId = new Guid("a2b5a788-03e7-4bd7-af51-b57a7326d148");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("a2b5a788-03e7-4bd7-af51-b57a7326d148");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return ((Terrasoft.UI.WebControls.Page)Page.AspPage).InstanceId.ToString() + 
				Page.PageContainer.UniqueID;
			}
		}

		private ProcessFlowElement _eventSubProcess1;
		public ProcessFlowElement EventSubProcess1 {
			get {
				return _eventSubProcess1 ?? (_eventSubProcess1 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess1",
					SchemaElementUId = new Guid("892ed4eb-fbf7-40bc-be3c-db34caec239b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _child_AddButtonClickScriptTask2;
		public ProcessScriptTask Child_AddButtonClickScriptTask2 {
			get {
				return _child_AddButtonClickScriptTask2 ?? (_child_AddButtonClickScriptTask2 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "Child_AddButtonClickScriptTask2",
					SchemaElementUId = new Guid("524c299d-a783-4673-958a-1288e4ef6c3d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = Child_AddButtonClickScriptTask2Execute,
				});
			}
		}

		private ProcessScriptTask _child_AddButtonClickScriptTask;
		public ProcessScriptTask Child_AddButtonClickScriptTask {
			get {
				return _child_AddButtonClickScriptTask ?? (_child_AddButtonClickScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "Child_AddButtonClickScriptTask",
					SchemaElementUId = new Guid("034ca056-1721-4e71-b014-61832cb0a68a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = Child_AddButtonClickScriptTaskExecute,
				});
			}
		}

		private SelectStatusUserTaskFlowElement _selectStatusUserTask;
		public SelectStatusUserTaskFlowElement SelectStatusUserTask {
			get {
				return _selectStatusUserTask ?? (_selectStatusUserTask = new SelectStatusUserTaskFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessIntermediateCatchMessageEvent _intermediateCatchMessageEvent1;
		public ProcessIntermediateCatchMessageEvent IntermediateCatchMessageEvent1 {
			get {
				return _intermediateCatchMessageEvent1 ?? (_intermediateCatchMessageEvent1 = new ProcessIntermediateCatchMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateCatchMessageEvent",
					Name = "IntermediateCatchMessageEvent1",
					SchemaElementUId = new Guid("d3980343-3d0a-459b-9f36-2ecc0fae9014"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "LookupGridPageClosed",
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
					SchemaElementUId = new Guid("453b9fd8-6983-4d45-8ac2-eacabb45bac5"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess1.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess1 };
			FlowElements[Child_AddButtonClickScriptTask2.SchemaElementUId] = new Collection<ProcessFlowElement> { Child_AddButtonClickScriptTask2 };
			FlowElements[Child_AddButtonClickScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { Child_AddButtonClickScriptTask };
			FlowElements[SelectStatusUserTask.SchemaElementUId] = new Collection<ProcessFlowElement> { SelectStatusUserTask };
			FlowElements[IntermediateCatchMessageEvent1.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateCatchMessageEvent1 };
			FlowElements[StartMessage2.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage2 };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess1":
						break;
					case "Child_AddButtonClickScriptTask2":
						break;
					case "Child_AddButtonClickScriptTask":
						e.Context.QueueTasks.Enqueue("SelectStatusUserTask");
						break;
					case "SelectStatusUserTask":
						ActivatedEventElements.Add("IntermediateCatchMessageEvent1");
						break;
					case "IntermediateCatchMessageEvent1":
						e.Context.QueueTasks.Enqueue("Child_AddButtonClickScriptTask2");
						break;
					case "StartMessage2":
						e.Context.QueueTasks.Enqueue("Child_AddButtonClickScriptTask");
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("StartMessage2");
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
				case "Child_AddButtonClickScriptTask2":
					context.QueueTasks.Dequeue();
					context.SenderName = "Child_AddButtonClickScriptTask2";
					result = Child_AddButtonClickScriptTask2.Execute(context, Child_AddButtonClickScriptTask2Execute);
					break;
				case "Child_AddButtonClickScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "Child_AddButtonClickScriptTask";
					result = Child_AddButtonClickScriptTask.Execute(context, Child_AddButtonClickScriptTaskExecute);
					break;
				case "SelectStatusUserTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "SelectStatusUserTask";
					result = SelectStatusUserTask.Execute(context);
					break;
				case "IntermediateCatchMessageEvent1":
					context.QueueTasks.Dequeue();
					context.SenderName = "IntermediateCatchMessageEvent1";
					result = IntermediateCatchMessageEvent1.Execute(context);
					break;
				case "StartMessage2":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage2";
					result = StartMessage2.Execute(context);
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

		public virtual bool Child_AddButtonClickScriptTask2Execute(ProcessExecutingContext context) {
			var selectedStatuses = (Dictionary<string, object>)(SelectStatusUserTask.GetSelectedValues(UserConnection));
foreach (var keyValuePair in selectedStatuses) {
	var selectedStatusId = new Guid(keyValuePair.Key);
	var caseNextStatus = Page.DataSource.Schema.CreateEntity(UserConnection);
	var id = Guid.NewGuid();
	caseNextStatus.SetColumnValue("Id", id);
	caseNextStatus.SetColumnValue("StatusId", SelectedNodePrimaryColumnValue);
	caseNextStatus.SetColumnValue("NextStatusId", selectedStatusId);
	caseNextStatus.Save();
	Page.DataSource.LoadRow(id);
	break;
}
return true;
		}

		public virtual bool Child_AddButtonClickScriptTaskExecute(ProcessExecutingContext context) {
			string schemaUId = "99F35013-6B7A-47D6-B440-E3F1A0BA991C";
SelectStatusUserTask.ProcessKey = InstanceUId;
SelectStatusUserTask.PageParameters = new Dictionary <string, object>();
var pageParameters = (Dictionary <string, object>)SelectStatusUserTask.PageParameters;
pageParameters.Add("schemaUId", schemaUId);
pageParameters.Add("editMode", false);
var filters = new Collection<Dictionary<string, object>>();
var nextStatusIds = GetCaseNextStatuses(SelectedNodePrimaryColumnValue);
object[] nextStatusIdObjs = new object[nextStatusIds.Length + 1];
for (var i = 0; i < nextStatusIds.Length; i++) {
	nextStatusIdObjs[i] = nextStatusIds[i];
}
nextStatusIdObjs[nextStatusIds.Length] = SelectedNodePrimaryColumnValue;
filters.Add(new Dictionary<string, object> {
	{ "comparisonType", FilterComparisonType.NotEqual },
	{ "leftExpressionColumnPath", "Id" },
	{ "useDisplayValue", false }, 
	{ "rightExpressionParameterValues", nextStatusIdObjs }});
pageParameters.Add("LookupFilters", filters);
return true;
		}

		public override void ActivateButtons(bool activate) {
			var buttons = GetButtons();
var dataSourceRowsCount = Page.DataSource.ActiveRowPrimaryColumnValue == Guid.Empty || !activate ? 0 : 1;
bool addButtonEnabledByRights = true;
bool deleteButtonEnabledByRights = true;
bool editButtonEnabledByRights = true;
bool copyButtonEnabledByRights = true;
var entitySchema = Page.DataSource.Schema;
if (entitySchema != null) {
	var dbSecurityEngine = Page.UserConnection.DBSecurityEngine;
	string schemaName = entitySchema.Name;
	deleteButtonEnabledByRights = dbSecurityEngine.GetIsEntitySchemaDeletingAllowed(schemaName);
	addButtonEnabledByRights = dbSecurityEngine.GetIsEntitySchemaAppendingAllowed(schemaName);
	copyButtonEnabledByRights = dbSecurityEngine.GetIsEntitySchemaAppendingAllowed(schemaName);
	editButtonEnabledByRights = dbSecurityEngine.GetIsEntitySchemaEditingAllowed(schemaName);
}
foreach (var control in Page.ButtonsControlLayout.Controls) {
	var button = control as Terrasoft.UI.WebControls.Controls.Button;
	if (button != null && string.CompareOrdinal(button.Name, "ContextHelpButton") != 0) {
		if (buttons.Contains(button.Name)) {
			switch (button.Name) {
				case "AddButton":
					button.Enabled = addButtonEnabledByRights;
					if (button.Enabled) {
						if (SelectedNodePrimaryColumnValue != Guid.Empty && IsFinalState(SelectedNodePrimaryColumnValue)) {
							button.Enabled = false;
						}
					}
				break;
				case "DeleteButton":
					button.Enabled = (dataSourceRowsCount > 0) && deleteButtonEnabledByRights;
				break;
				default :
					button.Enabled = (dataSourceRowsCount > 0);
				break;
			}
		} else {
			button.Enabled = true;
		}
	}
}
if (IsDetailGrid && SelectedNodePrimaryColumnValue == Guid.Empty) {
	foreach(var control in Page.ButtonsControlLayout.Controls) {
		var button = control as Terrasoft.UI.WebControls.Controls.Button;
		if (button != null && string.CompareOrdinal(button.Name, "ContextHelpButton") != 0) {
			button.Enabled = false;		
		}
	}
}
		}

		public override string GetRegisterEditPageScript(Guid editPageUId, Guid sysModuleEditId) {
			return string.Empty;
		}

		public override string GetRegisterAddPageScript(Guid editPageUId, Guid sysModuleEditId, Guid typeId) {
			return string.Empty;
		}

		public override string GetRegisterTreeGridDblClickScript(string defaultScript) {
			return string.Empty;
		}

		public virtual bool IsFinalState(Guid caseStatusId) {
			var entitySchemaManager = UserConnection.GetSchemaManager("EntitySchemaManager") as EntitySchemaManager;
var caseStatusSchema = entitySchemaManager.GetInstanceByName("CaseStatus");
var caseStatus = caseStatusSchema.CreateEntity(UserConnection);
if (caseStatus.FetchFromDB(caseStatusId)) {
	return caseStatus.GetTypedColumnValue<bool>("IsFinal");
}
else {
	return false;
}
		}

		public virtual Guid[] GetCaseNextStatuses(Guid caseStatusId) {
			var resultList = new List<Guid>();
var nextStatusSchema = Page.DataSource.Schema;
var nextStatusSchemaQuery = new EntitySchemaQuery(nextStatusSchema);
nextStatusSchemaQuery.AddColumn("NextStatus");	
var statusIdFilter = nextStatusSchemaQuery.CreateFilterWithParameters(FilterComparisonType.Equal, "Status", caseStatusId);
nextStatusSchemaQuery.Filters.Add(statusIdFilter);	
var nextStatuses = nextStatusSchemaQuery.GetEntityCollection(UserConnection);
foreach (var nextStatus in nextStatuses) {
	var nextStatusId = nextStatus.GetTypedColumnValue<Guid>("NextStatusId");
	if (!resultList.Contains(nextStatusId)) {
		resultList.Add(nextStatusId);
	}
}
return resultList.ToArray();
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "LookupGridPageClosed":
					if (ActivatedEventElements.Remove("IntermediateCatchMessageEvent1")) {
						context.QueueTasks.Enqueue("IntermediateCatchMessageEvent1");
					}
					break;
					case "AddButtonClick":
							if (ActivatedEventElements.Contains("StartMessage2")) {
							context.QueueTasks.Enqueue("StartMessage2");
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

	#region Class: CaseNextStatusesGridPageEventsProcess

	/// <exclude/>
	public class CaseNextStatusesGridPageEventsProcess : CaseNextStatusesGridPageEventsProcess<Terrasoft.WebApp.CaseNextStatusesGridPageSchemaUserControl>
	{

		public CaseNextStatusesGridPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: CaseNextStatusesGridPageSchemaUserControl

	/// <exclude/>
	public partial class CaseNextStatusesGridPageSchemaUserControl : Terrasoft.WebApp.BaseGridPageSchemaUserControl
	{

		#region Methods: Protected

		protected override void SubscribeOnControlEvents() {
			base.SubscribeOnControlEvents();
			AddButton.AjaxEvents.Click.Event += AddButtonClick;
		}

		protected override void UnsubscribeOnControlEvents() {
			base.UnsubscribeOnControlEvents();
			AddButton.AjaxEvents.Click.Event -= AddButtonClick;
		}

		protected override void InitializeEmbeddedProcess() {
			var instanceId = ((Terrasoft.UI.WebControls.Page)Page).InstanceId.ToString();
			string processUId = instanceId + PageContainer.UniqueID;
			var process = (CaseNextStatusesGridPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new CaseNextStatusesGridPageEventsProcess(UserConnection);
				process.Page = this;
				Process = process;
				UserConnection.ProcessEngine.SetProcess(process);
				process.Execute(UserConnection);
				UserConnection.ProcessEngine.SetProcessPropertiesData(process);
			} else {
				process.InternalContext = new ProcessExecutingContext(UserConnection) {
					Process = process
				};
				process.Page = this;
				Process = process;
				UserConnection.ProcessEngine.SetProcess(process);
			}
		}

		protected override void InitializePageSchemaControls() {
			base.InitializePageSchemaControls();
			if (!PageContainer.IsDesignMode) {
					InitializeEmbeddedProcess();
				}
		}

		#endregion

		#region Methods: Public

		public virtual void AddButtonClick(object sender, EventArgs e) {
			object result = ThrowEvent("AddButtonClick");
		}

		public override void AddScript(string script) {
			this.ScriptManager.AddScript(script);
		}

		public override void RegisterClientScriptIncludeInternal(string key, string resourceName) {
			this.ScriptManager.RegisterClientScriptIncludeInternal(key, resourceName);
		}

		public override void RegisterClientScriptBlock(string key, string script) {
			this.ScriptManager.RegisterClientScriptBlock(key, script);
		}

		public override void SetSchemaName() {
			SchemaName = "CaseNextStatusesGridPage";
		}

		#endregion

	}

	#endregion

	#region Class: CaseNextStatusesGridPageEventsProcessSchema

	/// <exclude/>
	public class CaseNextStatusesGridPageEventsProcessSchema : Terrasoft.WebApp.BaseGridPageEventsProcessSchema
	{

		#region Constructors: Public

		public CaseNextStatusesGridPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public CaseNextStatusesGridPageEventsProcessSchema(CaseNextStatusesGridPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "CaseNextStatusesGridPageEventsProcess";
			UId = new Guid("12736474-f32f-4295-a7c5-0bc7da28d014");
			CreatedInPackageId = new Guid("305fcfca-4160-4398-90a9-d5e84be0ae12");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsActiveVersion = false;
			IsCreatedInSvg = true;
			IsInterpretable = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected virtual void InitializeSelectStatusUserTaskParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("f8202c01-c1c8-447c-ac00-89fd7065354c"),
				ContainerUId = new Guid("b6b6e98f-4e52-4996-88be-34aeb67050a8"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("1aac6458-2318-40e5-8592-778f3a94fdae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("1aac6458-2318-40e5-8592-778f3a94fdae"),
				Name = @"PageParameters",
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					Value = null,
					MetaPath = null,
				},
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			});
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("0051d734-9318-4ca1-b86c-46e0bf9c96f6"),
				ContainerUId = new Guid("b6b6e98f-4e52-4996-88be-34aeb67050a8"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("1aac6458-2318-40e5-8592-778f3a94fdae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("1aac6458-2318-40e5-8592-778f3a94fdae"),
				Name = @"ProcessKey",
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					MetaPath = null,
				},
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
			});
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("802a18a7-c9ab-4fdd-b639-2127bb6bad20"),
				ContainerUId = new Guid("b6b6e98f-4e52-4996-88be-34aeb67050a8"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("1aac6458-2318-40e5-8592-778f3a94fdae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("1aac6458-2318-40e5-8592-778f3a94fdae"),
				Name = @"UserContextKey",
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					MetaPath = null,
				},
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
			});
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("3aa76b62-6d17-4c82-9c3b-2b5fa796d2ff"),
				ContainerUId = new Guid("b6b6e98f-4e52-4996-88be-34aeb67050a8"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("1aac6458-2318-40e5-8592-778f3a94fdae"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("1aac6458-2318-40e5-8592-778f3a94fdae"),
				Name = @"UseCurrentActivePage",
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					Value = @"",
					MetaPath = null,
				},
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
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
			ProcessSchemaScriptTask child_addbuttonclickscripttask2 = CreateChild_AddButtonClickScriptTask2ScriptTask();
			eventsubprocess1.FlowElements.Add(child_addbuttonclickscripttask2);
			ProcessSchemaScriptTask child_addbuttonclickscripttask = CreateChild_AddButtonClickScriptTaskScriptTask();
			eventsubprocess1.FlowElements.Add(child_addbuttonclickscripttask);
			ProcessSchemaUserTask selectstatususertask = CreateSelectStatusUserTaskUserTask();
			eventsubprocess1.FlowElements.Add(selectstatususertask);
			ProcessSchemaIntermediateCatchMessageEvent intermediatecatchmessageevent1 = CreateIntermediateCatchMessageEvent1IntermediateCatchMessageEvent();
			eventsubprocess1.FlowElements.Add(intermediatecatchmessageevent1);
			ProcessSchemaStartMessageEvent startmessage2 = CreateStartMessage2StartMessageEvent();
			eventsubprocess1.FlowElements.Add(startmessage2);
			FlowElements.Add(CreateSequenceFlow2222SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3333SequenceFlow());
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2222SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2222",
				UId = new Guid("407fcf07-806c-4a02-a9e3-932a0f59ded3"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("305fcfca-4160-4398-90a9-d5e84be0ae12"),
				CreatedInSchemaUId = new Guid("12736474-f32f-4295-a7c5-0bc7da28d014"),
				CurveCenterPosition = new Point(346, 86),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("12736474-f32f-4295-a7c5-0bc7da28d014"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("034ca056-1721-4e71-b014-61832cb0a68a"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("b6b6e98f-4e52-4996-88be-34aeb67050a8"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3333SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3333",
				UId = new Guid("b46d4329-65cb-4d82-9270-784d561f29b8"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("305fcfca-4160-4398-90a9-d5e84be0ae12"),
				CreatedInSchemaUId = new Guid("12736474-f32f-4295-a7c5-0bc7da28d014"),
				CurveCenterPosition = new Point(346, 86),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("12736474-f32f-4295-a7c5-0bc7da28d014"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("b6b6e98f-4e52-4996-88be-34aeb67050a8"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("d3980343-3d0a-459b-9f36-2ecc0fae9014"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("6d4b04c9-8b3d-4b07-9a43-253825eb7a11"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("305fcfca-4160-4398-90a9-d5e84be0ae12"),
				CreatedInSchemaUId = new Guid("12736474-f32f-4295-a7c5-0bc7da28d014"),
				CurveCenterPosition = new Point(510, 88),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("12736474-f32f-4295-a7c5-0bc7da28d014"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("d3980343-3d0a-459b-9f36-2ecc0fae9014"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("524c299d-a783-4673-958a-1288e4ef6c3d"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("a747f0f0-de57-4d74-a38c-294fee21616a"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("305fcfca-4160-4398-90a9-d5e84be0ae12"),
				CreatedInSchemaUId = new Guid("12736474-f32f-4295-a7c5-0bc7da28d014"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("12736474-f32f-4295-a7c5-0bc7da28d014"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("453b9fd8-6983-4d45-8ac2-eacabb45bac5"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("034ca056-1721-4e71-b014-61832cb0a68a"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("e787d00c-b862-4188-8046-fccdbddce29e"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("305fcfca-4160-4398-90a9-d5e84be0ae12"),
				CreatedInSchemaUId = new Guid("12736474-f32f-4295-a7c5-0bc7da28d014"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("12736474-f32f-4295-a7c5-0bc7da28d014"),
				Name = @"LaneSet1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(5, 5),
				Size = new Size(1102, 184)
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("067d3a2e-abed-4c9c-9de0-9fe7cdcb2718"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("e787d00c-b862-4188-8046-fccdbddce29e"),
				CreatedInOwnerSchemaUId = new Guid("a2b5a788-03e7-4bd7-af51-b57a7326d148"),
				CreatedInPackageId = new Guid("305fcfca-4160-4398-90a9-d5e84be0ae12"),
				CreatedInSchemaUId = new Guid("12736474-f32f-4295-a7c5-0bc7da28d014"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("12736474-f32f-4295-a7c5-0bc7da28d014"),
				Name = @"Lane1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 0),
				Size = new Size(1073, 184)
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess1EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess1 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("892ed4eb-fbf7-40bc-be3c-db34caec239b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("067d3a2e-abed-4c9c-9de0-9fe7cdcb2718"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("305fcfca-4160-4398-90a9-d5e84be0ae12"),
				CreatedInSchemaUId = new Guid("12736474-f32f-4295-a7c5-0bc7da28d014"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("12736474-f32f-4295-a7c5-0bc7da28d014"),
				Name = @"EventSubProcess1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(42, 14),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(574, 154),
				TriggeredByEvent = true,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess1;
		}

		protected virtual ProcessSchemaScriptTask CreateChild_AddButtonClickScriptTask2ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("524c299d-a783-4673-958a-1288e4ef6c3d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("892ed4eb-fbf7-40bc-be3c-db34caec239b"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("305fcfca-4160-4398-90a9-d5e84be0ae12"),
				CreatedInSchemaUId = new Guid("12736474-f32f-4295-a7c5-0bc7da28d014"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("12736474-f32f-4295-a7c5-0bc7da28d014"),
				Name = @"Child_AddButtonClickScriptTask2",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(442, 44),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,81,79,75,195,48,20,63,91,216,119,8,59,165,48,242,5,166,94,58,25,67,41,197,170,247,183,246,185,197,182,9,36,47,173,69,252,238,166,89,139,179,243,176,91,224,253,254,167,5,195,44,214,88,16,150,57,1,57,139,150,221,49,190,145,5,73,173,192,244,183,150,140,84,135,21,211,251,15,15,187,143,121,30,240,39,244,171,69,243,2,182,18,91,164,124,212,121,131,218,161,229,195,41,209,74,97,80,138,227,245,34,122,215,6,161,56,50,222,122,219,10,251,128,204,64,26,38,213,69,140,152,125,45,162,155,246,34,224,174,244,1,21,118,108,235,100,201,207,85,196,35,246,131,77,32,21,96,49,197,207,49,167,167,100,112,64,177,1,130,92,59,83,160,200,139,35,54,32,18,31,137,240,65,145,164,126,158,121,210,146,131,229,96,39,82,236,130,109,56,253,181,16,57,82,162,107,215,168,16,136,47,119,229,114,229,169,215,64,167,102,158,48,173,152,234,18,51,35,27,255,5,103,208,107,196,126,79,65,112,190,222,191,18,208,226,169,211,124,165,39,13,229,179,238,248,216,99,239,215,170,252,227,123,17,25,36,103,20,35,227,112,253,3,123,44,223,88,71,2,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaScriptTask CreateChild_AddButtonClickScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("034ca056-1721-4e71-b014-61832cb0a68a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("892ed4eb-fbf7-40bc-be3c-db34caec239b"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("305fcfca-4160-4398-90a9-d5e84be0ae12"),
				CreatedInSchemaUId = new Guid("12736474-f32f-4295-a7c5-0bc7da28d014"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("12736474-f32f-4295-a7c5-0bc7da28d014"),
				Name = @"Child_AddButtonClickScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(120, 44),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,146,91,79,194,64,16,133,159,37,225,63,108,250,84,194,37,16,80,66,68,19,174,134,168,72,2,248,98,120,88,218,161,93,104,119,235,238,86,37,134,255,238,180,229,86,20,226,211,38,187,231,124,115,102,118,148,150,140,59,68,89,46,248,116,58,176,201,29,49,26,141,126,245,186,92,169,22,111,218,245,86,177,86,239,222,20,219,181,90,185,216,171,246,43,173,114,187,213,104,84,58,198,109,54,51,6,15,44,61,214,84,135,106,170,64,78,168,90,149,70,82,88,160,212,35,172,17,53,224,74,83,110,1,130,207,234,169,3,35,42,169,15,26,164,66,15,135,79,210,101,150,102,130,83,185,38,77,21,39,44,16,49,95,162,251,222,204,33,233,131,74,18,156,26,205,11,174,220,63,106,35,55,205,44,181,108,219,52,246,163,49,10,135,49,229,206,136,193,102,250,89,216,128,218,5,245,20,236,194,46,152,119,212,94,71,120,81,26,204,218,60,100,62,141,124,232,148,195,215,54,249,192,142,16,15,160,59,84,193,112,127,13,202,76,250,3,123,136,197,71,146,249,8,196,42,161,207,95,169,23,198,49,18,236,219,44,133,123,153,47,119,161,182,239,169,98,165,39,224,142,118,73,158,84,102,136,88,8,73,204,40,17,67,79,249,22,143,38,249,75,143,47,249,124,142,124,103,51,87,167,197,222,216,44,174,119,100,194,43,100,111,178,153,95,218,191,216,145,253,114,179,81,208,100,220,241,159,164,247,233,116,202,113,200,111,98,88,194,15,168,100,74,240,201,58,136,190,175,31,35,58,169,235,210,80,232,222,123,72,61,178,41,36,54,15,22,186,247,21,72,220,120,228,39,33,70,84,187,8,48,112,99,246,58,252,163,46,83,129,71,215,113,196,221,122,224,59,73,4,146,57,238,17,105,191,87,177,92,161,254,215,175,109,54,231,150,240,73,136,85,24,36,13,68,214,237,52,34,185,4,29,74,78,180,196,49,253,0,5,231,144,54,251,3,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaUserTask CreateSelectStatusUserTaskUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("b6b6e98f-4e52-4996-88be-34aeb67050a8"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("892ed4eb-fbf7-40bc-be3c-db34caec239b"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("305fcfca-4160-4398-90a9-d5e84be0ae12"),
				CreatedInSchemaUId = new Guid("12736474-f32f-4295-a7c5-0bc7da28d014"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("12736474-f32f-4295-a7c5-0bc7da28d014"),
				Name = @"SelectStatusUserTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(246, 44),
				SchemaUId = new Guid("1aac6458-2318-40e5-8592-778f3a94fdae"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				TaskSchemaManagerName = @"ProcessUserTaskSchemaManager"
			};
			InitializeSelectStatusUserTaskParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaIntermediateCatchMessageEvent CreateIntermediateCatchMessageEvent1IntermediateCatchMessageEvent() {
			ProcessSchemaIntermediateCatchMessageEvent schemaCatchMessageEvent = new ProcessSchemaIntermediateCatchMessageEvent(this) {
				UId = new Guid("d3980343-3d0a-459b-9f36-2ecc0fae9014"),
				AttachedToUId = Guid.Empty,
				BoundaryItemAlignment = ProcessSchemaEditItemAlignment.None,
				CancelActivity = true,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("892ed4eb-fbf7-40bc-be3c-db34caec239b"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("305fcfca-4160-4398-90a9-d5e84be0ae12"),
				CreatedInSchemaUId = new Guid("12736474-f32f-4295-a7c5-0bc7da28d014"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("3cb9d737-779e-4085-ab4b-db590853e266"),
				Message = @"LookupGridPageClosed",
				ModifiedInSchemaUId = new Guid("12736474-f32f-4295-a7c5-0bc7da28d014"),
				Name = @"IntermediateCatchMessageEvent1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(365, 58),
				SerializeToDB = false,
				Size = new Size(0, 0)
			};
			
			return schemaCatchMessageEvent;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage2StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("453b9fd8-6983-4d45-8ac2-eacabb45bac5"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("892ed4eb-fbf7-40bc-be3c-db34caec239b"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("305fcfca-4160-4398-90a9-d5e84be0ae12"),
				CreatedInSchemaUId = new Guid("12736474-f32f-4295-a7c5-0bc7da28d014"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"AddButtonClick",
				ModifiedInSchemaUId = new Guid("12736474-f32f-4295-a7c5-0bc7da28d014"),
				Name = @"StartMessage2",
				Position = new Point(22, 55),
				SerializeToDB = false,
				Size = new Size(0, 0)
			};
			
			return schemaStartMessageEvent;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateIsFinalStateMethod());
			Methods.Add(CreateGetCaseNextStatusesMethod());
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("9d7efbbf-8549-484c-9592-82bf90843f5d"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("305fcfca-4160-4398-90a9-d5e84be0ae12")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("95c66740-e509-4ca4-b1ef-c7a6bb406ec0"),
				Name = "Terrasoft.UI.WebControls.Controls",
				Alias = "WebControls",
				CreatedInPackageId = new Guid("305fcfca-4160-4398-90a9-d5e84be0ae12")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7c7fbab2-546c-4dd3-ba02-c8f1ddbc356d"),
				Name = "System.Linq",
				Alias = "",
				CreatedInPackageId = new Guid("305fcfca-4160-4398-90a9-d5e84be0ae12")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5869487f-ebcd-414c-9fb2-40b8f070b351"),
				Name = "System.Web",
				Alias = "web",
				CreatedInPackageId = new Guid("305fcfca-4160-4398-90a9-d5e84be0ae12")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("41c60d94-6edf-44e4-9edb-0e16c226d725"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("305fcfca-4160-4398-90a9-d5e84be0ae12")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("92dceabc-4c2b-49a1-baa4-e5bdfa59f339"),
				Name = "Terrasoft.Core.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("305fcfca-4160-4398-90a9-d5e84be0ae12")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("aa8aa1ac-15e9-42cc-9636-16aa514d5797"),
				Name = "System.Text",
				Alias = "",
				CreatedInPackageId = new Guid("305fcfca-4160-4398-90a9-d5e84be0ae12")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("10a2ccab-756c-4712-b1b8-f4ebab9f54a0"),
				Name = "Terrasoft.Configuration",
				Alias = "TSConfiguration",
				CreatedInPackageId = new Guid("305fcfca-4160-4398-90a9-d5e84be0ae12")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e450a1d1-32d4-48db-a086-f5426a1a7722"),
				Name = "Terrasoft.Core.Store",
				Alias = "",
				CreatedInPackageId = new Guid("305fcfca-4160-4398-90a9-d5e84be0ae12")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("6f5452a8-39be-4d73-aff7-044da2a7684d"),
				Name = "System.Threading",
				Alias = "",
				CreatedInPackageId = new Guid("305fcfca-4160-4398-90a9-d5e84be0ae12")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("0655a6cd-c0cc-42ef-b029-8e7b7f8cbd5b"),
				Name = "Terrasoft.Reports",
				Alias = "",
				CreatedInPackageId = new Guid("305fcfca-4160-4398-90a9-d5e84be0ae12")
			});
		}

		protected override SchemaMethod CreateActivateButtonsMethod() {
			SchemaMethod method = base.CreateActivateButtonsMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,181,85,219,142,218,48,16,125,14,210,254,131,225,97,5,82,21,109,95,23,209,138,91,183,72,213,118,181,116,219,103,39,30,192,170,99,71,182,3,141,186,252,251,142,177,3,161,220,182,183,39,72,124,230,204,248,204,153,201,146,106,146,20,214,42,105,72,143,220,129,29,248,135,118,167,123,213,88,226,33,163,150,78,85,161,83,120,84,43,51,84,133,180,8,124,160,115,136,71,219,163,184,159,90,190,116,136,7,205,51,170,203,161,18,69,38,191,82,81,0,233,33,111,193,89,60,206,114,91,146,231,103,210,164,14,77,45,144,247,228,134,220,146,183,152,42,81,74,16,202,152,79,63,150,52,17,192,6,229,35,159,47,172,171,204,234,2,42,24,3,1,22,94,131,4,198,237,107,112,169,202,203,11,56,167,5,72,203,109,57,77,23,144,209,35,34,248,3,196,242,25,105,239,97,155,61,34,11,33,58,228,231,85,35,218,168,154,76,33,45,52,34,198,114,206,37,84,108,79,6,244,80,73,9,168,144,146,241,104,176,15,67,238,200,88,205,229,156,152,13,243,61,205,92,108,61,89,236,222,57,224,121,153,126,173,32,198,222,79,204,184,70,52,114,241,152,170,47,132,90,1,107,239,50,58,111,68,103,154,117,153,187,159,231,32,217,105,242,115,13,249,123,246,115,182,184,204,62,198,232,147,220,235,171,198,76,105,160,233,130,180,93,163,83,37,173,70,135,113,233,27,28,198,107,232,95,127,162,165,42,108,28,158,204,206,31,126,36,177,156,42,158,26,242,5,180,166,70,205,108,252,52,137,191,65,82,69,109,195,3,185,187,161,115,96,224,8,222,35,215,215,196,91,7,241,89,78,53,124,214,40,17,21,1,183,177,205,27,210,114,100,240,195,126,4,145,123,186,86,199,81,220,248,218,106,196,62,47,229,184,43,106,12,157,128,139,204,138,91,39,66,253,44,28,69,41,53,64,90,253,202,64,173,91,255,58,10,216,208,20,188,253,41,143,117,67,192,174,154,42,104,155,195,31,78,209,195,169,5,118,175,24,28,89,77,205,189,213,132,10,77,204,7,167,201,212,226,118,186,16,220,169,165,58,172,124,70,133,129,170,204,104,29,254,132,223,4,13,242,189,91,215,98,84,155,213,211,114,180,143,45,227,119,174,55,88,250,153,113,239,30,166,101,48,163,133,176,228,247,115,29,146,109,110,181,38,128,55,14,146,28,176,133,37,234,177,235,205,152,184,246,76,204,8,208,66,226,78,115,230,238,112,161,93,123,95,18,47,127,24,182,63,157,181,127,50,108,255,111,218,78,249,42,138,234,90,190,0,7,59,43,161,196,7,0,0 };
			return method;
		}

		protected override SchemaMethod CreateGetRegisterEditPageScriptMethod() {
			SchemaMethod method = base.CreateGetRegisterEditPageScriptMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,40,46,41,202,204,75,215,115,205,45,40,169,180,6,0,142,207,47,4,20,0,0,0 };
			return method;
		}

		protected override SchemaMethod CreateGetRegisterAddPageScriptMethod() {
			SchemaMethod method = base.CreateGetRegisterAddPageScriptMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,40,46,41,202,204,75,215,115,205,45,40,169,180,6,0,142,207,47,4,20,0,0,0 };
			return method;
		}

		protected override SchemaMethod CreateGetRegisterTreeGridDblClickScriptMethod() {
			SchemaMethod method = base.CreateGetRegisterTreeGridDblClickScriptMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,40,46,41,202,204,75,215,115,205,45,40,169,180,6,0,142,207,47,4,20,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateIsFinalStateMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("acf3a438-8738-4552-9678-3424c185b3e2"),
				Name = "IsFinalState",
				CreatedInSchemaUId = new Guid("12736474-f32f-4295-a7c5-0bc7da28d014"),
				CreatedInPackageId = new Guid("305fcfca-4160-4398-90a9-d5e84be0ae12"),
				ResultValueTypeName = "bool"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("8b45d143-0250-4d91-b114-c87d3f00dee5"),
				Name = "caseStatusId",
				CreatedInSchemaUId = new Guid("12736474-f32f-4295-a7c5-0bc7da28d014"),
				ModifiedInSchemaUId = new Guid("12736474-f32f-4295-a7c5-0bc7da28d014"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("305fcfca-4160-4398-90a9-d5e84be0ae12")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,143,205,110,194,48,16,132,207,205,83,88,62,57,151,188,64,41,7,66,83,229,80,46,252,220,23,51,64,36,103,93,217,27,164,168,226,221,113,132,4,225,231,184,179,59,243,205,158,40,40,176,52,210,47,237,17,45,253,18,211,1,65,125,169,117,68,40,61,51,172,52,158,139,31,200,195,133,209,223,175,54,157,43,138,234,205,226,51,59,37,144,165,136,165,144,116,241,186,76,148,55,236,1,85,115,20,98,139,89,191,160,22,70,151,55,167,206,159,179,82,202,115,112,81,6,144,224,90,196,60,126,146,252,205,94,153,187,165,168,32,246,88,5,223,206,103,35,185,222,229,185,250,207,62,2,164,11,60,66,12,253,86,253,31,118,165,119,93,203,27,114,29,38,91,239,221,212,232,58,86,13,147,27,74,158,51,184,136,81,194,158,210,156,244,11,204,62,55,158,115,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetCaseNextStatusesMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("97eb4bb1-42b2-4b0e-a419-fddd9f471398"),
				Name = "GetCaseNextStatuses",
				CreatedInSchemaUId = new Guid("12736474-f32f-4295-a7c5-0bc7da28d014"),
				CreatedInPackageId = new Guid("305fcfca-4160-4398-90a9-d5e84be0ae12"),
				ResultValueTypeName = "Guid[]"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("d2606252-4037-4a29-89fd-548dea9db8cd"),
				Name = "caseStatusId",
				CreatedInSchemaUId = new Guid("12736474-f32f-4295-a7c5-0bc7da28d014"),
				ModifiedInSchemaUId = new Guid("12736474-f32f-4295-a7c5-0bc7da28d014"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("305fcfca-4160-4398-90a9-d5e84be0ae12")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,82,203,78,195,48,16,60,39,95,97,114,114,164,42,63,80,64,170,66,169,34,33,84,148,2,231,85,188,37,150,18,187,216,235,66,132,250,239,56,15,104,82,165,55,175,61,158,153,29,205,17,12,51,104,93,69,79,210,18,187,99,10,191,88,123,188,221,56,41,238,121,188,12,143,30,162,240,155,114,2,114,54,47,74,172,193,3,183,240,129,201,3,16,228,218,153,2,147,254,97,30,254,226,208,52,3,249,90,145,164,102,116,207,47,209,94,115,150,32,89,9,145,234,202,213,138,71,207,255,128,40,94,6,157,168,237,198,76,60,202,138,208,116,106,115,36,169,65,32,236,65,239,146,202,45,24,168,209,15,150,247,151,169,174,15,96,164,213,106,215,28,48,89,127,58,168,22,44,26,212,22,172,0,139,249,160,117,213,106,79,101,91,203,124,106,236,207,238,249,31,218,171,102,55,72,125,94,126,239,10,11,146,90,241,87,219,122,84,170,31,189,131,189,246,43,21,37,227,83,90,38,213,68,36,102,63,97,48,133,100,98,162,220,202,181,59,15,41,191,65,229,112,232,193,40,240,76,248,200,195,64,238,25,191,57,87,39,241,150,8,164,178,124,76,31,119,162,193,8,214,6,50,65,120,170,83,120,10,13,146,51,106,212,197,100,167,87,198,64,227,43,248,11,211,66,46,56,165,2,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new CaseNextStatusesGridPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("12736474-f32f-4295-a7c5-0bc7da28d014"));
		}

		#endregion

	}

	#endregion

}

