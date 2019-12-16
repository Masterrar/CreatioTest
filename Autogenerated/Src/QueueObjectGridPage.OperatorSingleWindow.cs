namespace Terrasoft.WebApp
{

	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.ComponentModel;
	using System.Data;
	using System.Drawing;
	using System.Globalization;
	using System.IO;
	using System.Text;
	using System.Threading;
	using System.Web.UI.WebControls;
	using Terrasoft.Common;
	using Terrasoft.Configuration;
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
	using web = System.Web;

	#region Class: QueueObjectGridPageSchema

	/// <exclude/>
	public class QueueObjectGridPageSchema : Terrasoft.WebApp.BaseLookupGridPageSchema
	{

		#region Constructors: Public

		public QueueObjectGridPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public QueueObjectGridPageSchema(QueueObjectGridPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateAddButton() {
			AddButton.Image = new ControlImage {};
			AddButton.ModifiedInSchemaUId = new Guid("87dc5a23-1ee4-4d29-8f8f-a8e81a2d484f");
		}

		private void UpdateCopyButton() {
			CopyButton.Image = new ControlImage {};
			CopyButton.Hidden = true;
			CopyButton.ModifiedInSchemaUId = new Guid("87dc5a23-1ee4-4d29-8f8f-a8e81a2d484f");
		}

		private void UpdateEditButton() {
			EditButton.Image = new ControlImage {};
			EditButton.ModifiedInSchemaUId = new Guid("87dc5a23-1ee4-4d29-8f8f-a8e81a2d484f");
		}

		private void UpdateDeleteButton() {
			DeleteButton.Image = new ControlImage {};
			DeleteButton.ModifiedInSchemaUId = new Guid("87dc5a23-1ee4-4d29-8f8f-a8e81a2d484f");
		}

		private void UpdatePrintButton() {
			PrintButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73"),
				ImageHash = @"6e713359f7daa6706f06f1a8f5f065f7"
			};
			PrintButton.ModifiedInSchemaUId = new Guid("87dc5a23-1ee4-4d29-8f8f-a8e81a2d484f");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("87dc5a23-1ee4-4d29-8f8f-a8e81a2d484f");
		}

		private void UpdateDownloadTemplateForImportProductsButton() {
			DownloadTemplateForImportProductsButton.AjaxEvents.Click.IsProcessEventHandler = true;
			DownloadTemplateForImportProductsButton.Image = new ControlImage {};
			DownloadTemplateForImportProductsButton.ModifiedInSchemaUId = new Guid("87dc5a23-1ee4-4d29-8f8f-a8e81a2d484f");
		}

		private void UpdateImportProductsButton() {
			ImportProductsButton.AjaxEvents.Click.IsProcessEventHandler = true;
			ImportProductsButton.Image = new ControlImage {};
			ImportProductsButton.ModifiedInSchemaUId = new Guid("87dc5a23-1ee4-4d29-8f8f-a8e81a2d484f");
		}

		private void UpdateActionButton() {
			ActionButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73"),
				ImageHash = @"388b646e5dc8d8c8203aeeb3f25b057e"
			};
			ActionButton.ModifiedInSchemaUId = new Guid("87dc5a23-1ee4-4d29-8f8f-a8e81a2d484f");
		}

		private void UpdateButtonsControlLayout() {
			ButtonsControlLayout.Image = new ControlImage {};
			ButtonsControlLayout.ModifiedInSchemaUId = new Guid("87dc5a23-1ee4-4d29-8f8f-a8e81a2d484f");
		}

		private void UpdateSendEmailMenuItem() {
			SendEmailMenuItem.Image = new ControlImage {};
			SendEmailMenuItem.ModifiedInSchemaUId = new Guid("87dc5a23-1ee4-4d29-8f8f-a8e81a2d484f");
		}

		private void UpdateSendTemplateEmailMenuItem() {
			SendTemplateEmailMenuItem.Image = new ControlImage {};
			SendTemplateEmailMenuItem.ModifiedInSchemaUId = new Guid("87dc5a23-1ee4-4d29-8f8f-a8e81a2d484f");
		}

		private void UpdateCallMenuItem() {
			CallMenuItem.AjaxEvents.PrepareMenu.IsProcessEventHandler = true;
			CallMenuItem.Image = new ControlImage {};
			CallMenuItem.ModifiedInSchemaUId = new Guid("87dc5a23-1ee4-4d29-8f8f-a8e81a2d484f");
		}

		private void UpdateShowChangelogMenuItem() {
			ShowChangelogMenuItem.AjaxEvents.Click.IsProcessEventHandler = true;
			ShowChangelogMenuItem.Image = new ControlImage {};
			ShowChangelogMenuItem.ModifiedInSchemaUId = new Guid("87dc5a23-1ee4-4d29-8f8f-a8e81a2d484f");
		}

		private void UpdateTreeGrid() {
			TreeGrid.AjaxEvents.ContextMenu.IsProcessEventHandler = true;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("87dc5a23-1ee4-4d29-8f8f-a8e81a2d484f");
			RealUId = new Guid("87dc5a23-1ee4-4d29-8f8f-a8e81a2d484f");
			Name = "QueueObjectGridPage";
			ParentSchemaUId = new Guid("39f129b6-b225-4949-95a6-820d78cf6294");
			CreatedInPackageId = new Guid("7be0af39-38cd-442a-b589-d8f3ef3f4d19");
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateQueueObjectGridPageEventsProcessSchema();
		}

		protected override void InitializeControls() {
			base.InitializeControls();
			UpdateTreeGrid();
			UpdateShowChangelogMenuItem();
			UpdateCallMenuItem();
			UpdateSendTemplateEmailMenuItem();
			UpdateSendEmailMenuItem();
			UpdateButtonsControlLayout();
			UpdateActionButton();
			UpdateImportProductsButton();
			UpdateDownloadTemplateForImportProductsButton();
			UpdateContextHelpButton();
			UpdatePrintButton();
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
			ButtonsControlLayout.MoveItem(5, PrintButton);
			ButtonsControlLayout.MoveItem(6, ContextHelpButton);
			ButtonsControlLayout.MoveItem(7, DownloadTemplateForImportProductsButton);
			ButtonsControlLayout.MoveItem(8, ImportProductsButton);
			ButtonsControlLayout.MoveItem(9, ActionButton);
			TopLevelControl.MoveItem(1, TreeGrid);
			TreeGrid.MoveItem(0, SendEmailMenuItem);
			TreeGrid.MoveItem(1, SendTemplateEmailMenuItem);
			TreeGrid.MoveItem(2, CallMenuItem);
			TreeGrid.MoveItem(3, ShowChangelogMenuItem);
			TopLevelControl.MoveItem(2, DataSource);
			SetControlsDefInheritance(UId);
			InitializeLocalizableValues();
		}

		protected virtual EmbeddedProcessSchema CreateQueueObjectGridPageEventsProcessSchema() {
			var schema = new QueueObjectGridPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected override void UpdateDataSource() {
			base.UpdateDataSource();
			DataSource.SchemaUId = new Guid("3117ccf2-594f-437b-8ce9-2a97314af997");
			DataSource.ModifiedInSchemaUId = new Guid("87dc5a23-1ee4-4d29-8f8f-a8e81a2d484f");
			DataSourceStructureColumn column = null;
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ae0e45ca-c495-4fe7-a39d-3ab7278e1617");
			if (column != null) {
				column.UId = new Guid("328263ff-c68b-4e6c-92bd-b32b1496cfd3");
				column.Name = @"Id";
				column.CreatedInSchemaUId = new Guid("87dc5a23-1ee4-4d29-8f8f-a8e81a2d484f");
				column.ModifiedInSchemaUId = new Guid("87dc5a23-1ee4-4d29-8f8f-a8e81a2d484f");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
				column.IsAlwaysSelect = true;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("e80190a5-03b2-4095-90f7-a193a960adee");
			if (column != null) {
				column.UId = new Guid("c5ac72ce-da44-4ca2-8aaa-2ec94deca100");
				column.Name = @"CreatedOn";
				column.CreatedInSchemaUId = new Guid("87dc5a23-1ee4-4d29-8f8f-a8e81a2d484f");
				column.ModifiedInSchemaUId = new Guid("87dc5a23-1ee4-4d29-8f8f-a8e81a2d484f");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ebf6bb93-8aa6-4a01-900d-c6ea67affe21");
			if (column != null) {
				column.UId = new Guid("bf7042d5-e4f2-455d-9fcc-3268bde810b1");
				column.Name = @"CreatedBy";
				column.CreatedInSchemaUId = new Guid("87dc5a23-1ee4-4d29-8f8f-a8e81a2d484f");
				column.ModifiedInSchemaUId = new Guid("87dc5a23-1ee4-4d29-8f8f-a8e81a2d484f");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9928edec-4272-425a-93bb-48743fee4b04");
			if (column != null) {
				column.UId = new Guid("14b5aaac-52a1-4dd4-8e73-08fc4c5e79bf");
				column.Name = @"ModifiedOn";
				column.CreatedInSchemaUId = new Guid("87dc5a23-1ee4-4d29-8f8f-a8e81a2d484f");
				column.ModifiedInSchemaUId = new Guid("87dc5a23-1ee4-4d29-8f8f-a8e81a2d484f");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3015559e-cbc6-406a-88af-07f7930be832");
			if (column != null) {
				column.UId = new Guid("9617af24-80ef-47e7-9bf5-1d9fa788c9ab");
				column.Name = @"ModifiedBy";
				column.CreatedInSchemaUId = new Guid("87dc5a23-1ee4-4d29-8f8f-a8e81a2d484f");
				column.ModifiedInSchemaUId = new Guid("87dc5a23-1ee4-4d29-8f8f-a8e81a2d484f");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3fabd836-6a53-4d8d-9069-6df88d9dae1e");
			if (column != null) {
				column.UId = new Guid("6d1caad8-4bd5-4cf1-b852-d456e9a78f2b");
				column.Name = @"ProcessListeners";
				column.CreatedInSchemaUId = new Guid("87dc5a23-1ee4-4d29-8f8f-a8e81a2d484f");
				column.ModifiedInSchemaUId = new Guid("87dc5a23-1ee4-4d29-8f8f-a8e81a2d484f");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3d9651ba-a619-4e15-bea4-88c03f624f40");
			if (column != null) {
				column.UId = new Guid("e9f7f8f3-577a-44fe-be8b-e268b0d68fd4");
				column.Name = @"EntitySchemaUId";
				column.CreatedInSchemaUId = new Guid("87dc5a23-1ee4-4d29-8f8f-a8e81a2d484f");
				column.ModifiedInSchemaUId = new Guid("87dc5a23-1ee4-4d29-8f8f-a8e81a2d484f");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("744e6a8f-4792-4153-a7af-d913c8aab620");
			if (column != null) {
				column.UId = new Guid("25433eeb-6dc5-4826-801c-592ef5abb860");
				column.Name = @"EntitySchemaCaption";
				column.CreatedInSchemaUId = new Guid("87dc5a23-1ee4-4d29-8f8f-a8e81a2d484f");
				column.ModifiedInSchemaUId = new Guid("87dc5a23-1ee4-4d29-8f8f-a8e81a2d484f");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override PageSchemaUserControl CreateUserControl() {
			return new QueueObjectGridPageSchemaUserControl();
		}

		public override object Clone() {
			return new QueueObjectGridPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("87dc5a23-1ee4-4d29-8f8f-a8e81a2d484f"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new QueueObjectGridPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: QueueObjectGridPageEventsProcess

	/// <exclude/>
	public class QueueObjectGridPageEventsProcess<TPage> : Terrasoft.WebApp.BaseLookupGridPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.QueueObjectGridPageSchemaUserControl
	{

		#region Class: OpenLookupUserTaskFlowElement

		/// <exclude/>
		public class OpenLookupUserTaskFlowElement : OpenLookupUserTask
		{

			public OpenLookupUserTaskFlowElement(UserConnection userConnection, QueueObjectGridPageEventsProcess<TPage> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "OpenLookupUserTask";
				IsLogging = false;
				SchemaElementUId = new Guid("44296743-afb6-43d0-949d-e9f9f586e31b");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		public QueueObjectGridPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "QueueObjectGridPageEventsProcess";
			SchemaUId = new Guid("87dc5a23-1ee4-4d29-8f8f-a8e81a2d484f");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			_vwSysSchemaInfoUId = () => {{ return "90FA6D02-3E93-45D6-A72B-58DCFFA411AE"; }};
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("87dc5a23-1ee4-4d29-8f8f-a8e81a2d484f");
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

		private Func<Object> _vwSysSchemaInfoUId;
		public virtual Object VwSysSchemaInfoUId {
			get {
				return (_vwSysSchemaInfoUId ?? (_vwSysSchemaInfoUId = () => null)).Invoke();
			}
			set {
				_vwSysSchemaInfoUId = () => { return value; };
			}
		}

		private ProcessFlowElement _queueObjectGridPageAddButtonEventSubProcess;
		public ProcessFlowElement QueueObjectGridPageAddButtonEventSubProcess {
			get {
				return _queueObjectGridPageAddButtonEventSubProcess ?? (_queueObjectGridPageAddButtonEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "QueueObjectGridPageAddButtonEventSubProcess",
					SchemaElementUId = new Guid("971e021d-0fc6-4f47-8ee4-10cb2870595e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _queueObjectGridPageAddButtonClickStartMessage;
		public ProcessFlowElement QueueObjectGridPageAddButtonClickStartMessage {
			get {
				return _queueObjectGridPageAddButtonClickStartMessage ?? (_queueObjectGridPageAddButtonClickStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "QueueObjectGridPageAddButtonClickStartMessage",
					SchemaElementUId = new Guid("104cbfb5-a97a-4abd-9960-ce8b92d409de"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _queueObjectGridPageAddButtonPrepareLookupPageParametersScriptTask;
		public ProcessScriptTask QueueObjectGridPageAddButtonPrepareLookupPageParametersScriptTask {
			get {
				return _queueObjectGridPageAddButtonPrepareLookupPageParametersScriptTask ?? (_queueObjectGridPageAddButtonPrepareLookupPageParametersScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "QueueObjectGridPageAddButtonPrepareLookupPageParametersScriptTask",
					SchemaElementUId = new Guid("6ec51867-0091-4d26-b2d4-f626352c5183"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = QueueObjectGridPageAddButtonPrepareLookupPageParametersScriptTaskExecute,
				});
			}
		}

		private OpenLookupUserTaskFlowElement _openLookupUserTask;
		public OpenLookupUserTaskFlowElement OpenLookupUserTask {
			get {
				return _openLookupUserTask ?? (_openLookupUserTask = new OpenLookupUserTaskFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessIntermediateCatchMessageEvent _queueObjectGridPageLookupGridPageClosedIntermediateCatchMessageEvent;
		public ProcessIntermediateCatchMessageEvent QueueObjectGridPageLookupGridPageClosedIntermediateCatchMessageEvent {
			get {
				return _queueObjectGridPageLookupGridPageClosedIntermediateCatchMessageEvent ?? (_queueObjectGridPageLookupGridPageClosedIntermediateCatchMessageEvent = new ProcessIntermediateCatchMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateCatchMessageEvent",
					Name = "QueueObjectGridPageLookupGridPageClosedIntermediateCatchMessageEvent",
					SchemaElementUId = new Guid("7219f4d3-3262-458c-a8c5-b579a9d8436d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "LookupGridPageClosed",
				});
			}
		}

		private ProcessScriptTask _queueObjectGridPageInsertQueueObjectScriptTask;
		public ProcessScriptTask QueueObjectGridPageInsertQueueObjectScriptTask {
			get {
				return _queueObjectGridPageInsertQueueObjectScriptTask ?? (_queueObjectGridPageInsertQueueObjectScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "QueueObjectGridPageInsertQueueObjectScriptTask",
					SchemaElementUId = new Guid("830b8115-b4dd-437d-8f2d-ffbfc871aa03"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = QueueObjectGridPageInsertQueueObjectScriptTaskExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[QueueObjectGridPageAddButtonEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { QueueObjectGridPageAddButtonEventSubProcess };
			FlowElements[QueueObjectGridPageAddButtonClickStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { QueueObjectGridPageAddButtonClickStartMessage };
			FlowElements[QueueObjectGridPageAddButtonPrepareLookupPageParametersScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { QueueObjectGridPageAddButtonPrepareLookupPageParametersScriptTask };
			FlowElements[OpenLookupUserTask.SchemaElementUId] = new Collection<ProcessFlowElement> { OpenLookupUserTask };
			FlowElements[QueueObjectGridPageLookupGridPageClosedIntermediateCatchMessageEvent.SchemaElementUId] = new Collection<ProcessFlowElement> { QueueObjectGridPageLookupGridPageClosedIntermediateCatchMessageEvent };
			FlowElements[QueueObjectGridPageInsertQueueObjectScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { QueueObjectGridPageInsertQueueObjectScriptTask };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "QueueObjectGridPageAddButtonEventSubProcess":
						break;
					case "QueueObjectGridPageAddButtonClickStartMessage":
						e.Context.QueueTasks.Enqueue("QueueObjectGridPageAddButtonPrepareLookupPageParametersScriptTask");
						break;
					case "QueueObjectGridPageAddButtonPrepareLookupPageParametersScriptTask":
						e.Context.QueueTasks.Enqueue("OpenLookupUserTask");
						break;
					case "OpenLookupUserTask":
						ActivatedEventElements.Add("QueueObjectGridPageLookupGridPageClosedIntermediateCatchMessageEvent");
						break;
					case "QueueObjectGridPageLookupGridPageClosedIntermediateCatchMessageEvent":
						e.Context.QueueTasks.Enqueue("QueueObjectGridPageInsertQueueObjectScriptTask");
						break;
					case "QueueObjectGridPageInsertQueueObjectScriptTask":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("QueueObjectGridPageAddButtonClickStartMessage");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "QueueObjectGridPageAddButtonEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "QueueObjectGridPageAddButtonClickStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "QueueObjectGridPageAddButtonClickStartMessage";
					result = QueueObjectGridPageAddButtonClickStartMessage.Execute(context);
					break;
				case "QueueObjectGridPageAddButtonPrepareLookupPageParametersScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "QueueObjectGridPageAddButtonPrepareLookupPageParametersScriptTask";
					result = QueueObjectGridPageAddButtonPrepareLookupPageParametersScriptTask.Execute(context, QueueObjectGridPageAddButtonPrepareLookupPageParametersScriptTaskExecute);
					break;
				case "OpenLookupUserTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "OpenLookupUserTask";
					result = OpenLookupUserTask.Execute(context);
					break;
				case "QueueObjectGridPageLookupGridPageClosedIntermediateCatchMessageEvent":
					context.QueueTasks.Dequeue();
					context.SenderName = "QueueObjectGridPageLookupGridPageClosedIntermediateCatchMessageEvent";
					result = QueueObjectGridPageLookupGridPageClosedIntermediateCatchMessageEvent.Execute(context);
					break;
				case "QueueObjectGridPageInsertQueueObjectScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "QueueObjectGridPageInsertQueueObjectScriptTask";
					result = QueueObjectGridPageInsertQueueObjectScriptTask.Execute(context, QueueObjectGridPageInsertQueueObjectScriptTaskExecute);
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

		public virtual bool QueueObjectGridPageAddButtonPrepareLookupPageParametersScriptTaskExecute(ProcessExecutingContext context) {
			string instanceId = ((Terrasoft.UI.WebControls.Page)Page.AspPage).InstanceId.ToString();
OpenLookupUserTask.ProcessKey = instanceId + Page.PageContainer.UniqueID;
OpenLookupUserTask.PageParameters = new Dictionary <string, object>();
var pageParameters = (Dictionary <string, object>)OpenLookupUserTask.PageParameters;
pageParameters.Add("schemaUId", VwSysSchemaInfoUId);
var lookupFilters = new Collection<Dictionary<string, object>>();
var entitySchemaManagerFilter = new Dictionary<string, object> {
	{"comparisonType", FilterComparisonType.Equal},
	{"leftExpressionColumnPath", "ManagerName"},
	{"useDisplayValue", false},
	{"rightExpressionParameterValues", new object[] {"EntitySchemaManager"}}};
lookupFilters.Add(entitySchemaManagerFilter);
pageParameters.Add("LookupFilters", lookupFilters);
return true;
		}

		public virtual bool QueueObjectGridPageInsertQueueObjectScriptTaskExecute(ProcessExecutingContext context) {
			var selectedValues = OpenLookupUserTask.GetSelectedValues(UserConnection) as System.Collections.IDictionary;
var items = selectedValues.Keys as Dictionary<string,object>.KeyCollection;
foreach (string item in items) {
	if (string.IsNullOrEmpty(item)) {
		continue;
	}
	var esq = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "SysSchema");
	esq.RowCount = 1;
	string nameColumn = esq.AddColumn("Caption").Name;
	esq.Filters.Add(esq.CreateFilterWithParameters(FilterComparisonType.Equal,
		"UId", new Guid(item)));
	EntityCollection entityCollection = esq.GetEntityCollection(UserConnection);
	if (entityCollection.Count == 1) {
		Entity entity = Page.DataSource.Schema.CreateEntity(UserConnection);
		entity.SetDefColumnValues();
		entity.SetColumnValue("EntitySchemaUId", new Guid(item));
		entity.SetColumnValue("EntitySchemaCaption", entityCollection[0].GetTypedColumnValue<string>(nameColumn));
		entity.Save();
		Page.DataSource.LoadRow(entity.PrimaryColumnValue);
	}
}

return true;
		}

		public override string GetRegisterAddPageScript(Guid editPageUId, Guid sysModuleEditId, Guid typeId) {
			Page.AddButton.AjaxEvents.Click.SignalName = "AddButtonClick";
return string.Empty;

		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "AddButtonClick":
							if (ActivatedEventElements.Contains("QueueObjectGridPageAddButtonClickStartMessage")) {
							context.QueueTasks.Enqueue("QueueObjectGridPageAddButtonClickStartMessage");
							ProcessQueue(context);
							return;
						}
						break;
					case "LookupGridPageClosed":
					if (ActivatedEventElements.Remove("QueueObjectGridPageLookupGridPageClosedIntermediateCatchMessageEvent")) {
						context.QueueTasks.Enqueue("QueueObjectGridPageLookupGridPageClosedIntermediateCatchMessageEvent");
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

	#region Class: QueueObjectGridPageEventsProcess

	/// <exclude/>
	public class QueueObjectGridPageEventsProcess : QueueObjectGridPageEventsProcess<Terrasoft.WebApp.QueueObjectGridPageSchemaUserControl>
	{

		public QueueObjectGridPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: QueueObjectGridPageSchemaUserControl

	/// <exclude/>
	public partial class QueueObjectGridPageSchemaUserControl : Terrasoft.WebApp.BaseLookupGridPageSchemaUserControl
	{

		#region Methods: Protected

		protected override void SubscribeOnControlEvents() {
			base.SubscribeOnControlEvents();
		}

		protected override void UnsubscribeOnControlEvents() {
			base.UnsubscribeOnControlEvents();
		}

		protected override void InitializeEmbeddedProcess() {
			var instanceId = ((Terrasoft.UI.WebControls.Page)Page).InstanceId.ToString();
			string processUId = instanceId + PageContainer.UniqueID;
			var process = (QueueObjectGridPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new QueueObjectGridPageEventsProcess(UserConnection);
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
			SchemaName = "QueueObjectGridPage";
		}

		#endregion

	}

	#endregion

	#region Class: QueueObjectGridPageEventsProcessSchema

	/// <exclude/>
	public class QueueObjectGridPageEventsProcessSchema : Terrasoft.WebApp.BaseLookupGridPageEventsProcessSchema
	{

		#region Constructors: Public

		public QueueObjectGridPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public QueueObjectGridPageEventsProcessSchema(QueueObjectGridPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "QueueObjectGridPageEventsProcess";
			UId = new Guid("c0356468-62f8-449f-838e-3331955dcbfa");
			CreatedInPackageId = new Guid("7be0af39-38cd-442a-b589-d8f3ef3f4d19");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsActiveVersion = false;
			IsCreatedInSvg = true;
			IsInterpretable = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
		}

		protected virtual ProcessSchemaParameter CreateVwSysSchemaInfoUIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("c8d6af95-1863-48a8-bfd2-0f14720c88b1"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("c0356468-62f8-449f-838e-3331955dcbfa"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("c0356468-62f8-449f-838e-3331955dcbfa"),
				Name = @"VwSysSchemaInfoUId",
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					Value = @"""90FA6D02-3E93-45D6-A72B-58DCFFA411AE""",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("c0356468-62f8-449f-838e-3331955dcbfa"),
				},
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateVwSysSchemaInfoUIdParameter());
		}

		protected virtual void InitializeOpenLookupUserTaskParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("ca731428-4562-422f-a5bd-11859f046ee4"),
				ContainerUId = new Guid("44296743-afb6-43d0-949d-e9f9f586e31b"),
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
				UId = new Guid("3a4ecc92-f23d-4365-8576-0b03a17d0c9c"),
				ContainerUId = new Guid("44296743-afb6-43d0-949d-e9f9f586e31b"),
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
				UId = new Guid("03ef8fcb-6bff-4053-9b0c-fa97a53f2e1e"),
				ContainerUId = new Guid("44296743-afb6-43d0-949d-e9f9f586e31b"),
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
				UId = new Guid("aeceee89-9a99-4c3c-b484-b1c8ce2abb55"),
				ContainerUId = new Guid("44296743-afb6-43d0-949d-e9f9f586e31b"),
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
			ProcessSchemaLaneSet schemaQueueObjectGridPageLaneSet = CreateQueueObjectGridPageLaneSetLaneSet();
			LaneSets.Add(schemaQueueObjectGridPageLaneSet);
			ProcessSchemaLane schemaQueueObjectGridPageButtonsLane = CreateQueueObjectGridPageButtonsLaneLane();
			schemaQueueObjectGridPageLaneSet.Lanes.Add(schemaQueueObjectGridPageButtonsLane);
			ProcessSchemaEventSubProcess queueobjectgridpageaddbuttoneventsubprocess = CreateQueueObjectGridPageAddButtonEventSubProcessEventSubProcess();
			FlowElements.Add(queueobjectgridpageaddbuttoneventsubprocess);
			ProcessSchemaStartMessageEvent queueobjectgridpageaddbuttonclickstartmessage = CreateQueueObjectGridPageAddButtonClickStartMessageStartMessageEvent();
			queueobjectgridpageaddbuttoneventsubprocess.FlowElements.Add(queueobjectgridpageaddbuttonclickstartmessage);
			ProcessSchemaScriptTask queueobjectgridpageaddbuttonpreparelookuppageparametersscripttask = CreateQueueObjectGridPageAddButtonPrepareLookupPageParametersScriptTaskScriptTask();
			queueobjectgridpageaddbuttoneventsubprocess.FlowElements.Add(queueobjectgridpageaddbuttonpreparelookuppageparametersscripttask);
			ProcessSchemaUserTask openlookupusertask = CreateOpenLookupUserTaskUserTask();
			queueobjectgridpageaddbuttoneventsubprocess.FlowElements.Add(openlookupusertask);
			ProcessSchemaIntermediateCatchMessageEvent queueobjectgridpagelookupgridpageclosedintermediatecatchmessageevent = CreateQueueObjectGridPageLookupGridPageClosedIntermediateCatchMessageEventIntermediateCatchMessageEvent();
			queueobjectgridpageaddbuttoneventsubprocess.FlowElements.Add(queueobjectgridpagelookupgridpageclosedintermediatecatchmessageevent);
			ProcessSchemaScriptTask queueobjectgridpageinsertqueueobjectscripttask = CreateQueueObjectGridPageInsertQueueObjectScriptTaskScriptTask();
			queueobjectgridpageaddbuttoneventsubprocess.FlowElements.Add(queueobjectgridpageinsertqueueobjectscripttask);
			FlowElements.Add(CreateSequenceFlow13SequenceFlow());
			FlowElements.Add(CreateSequenceFlow14SequenceFlow());
			FlowElements.Add(CreateSequenceFlow15SequenceFlow());
			FlowElements.Add(CreateSequenceFlow16SequenceFlow());
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow13SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow13",
				UId = new Guid("db7190a7-80a7-4a77-9d0f-cec3ecbe9675"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				CreatedInPackageId = new Guid("7be0af39-38cd-442a-b589-d8f3ef3f4d19"),
				CreatedInSchemaUId = new Guid("c0356468-62f8-449f-838e-3331955dcbfa"),
				CurveCenterPosition = new Point(226, 98),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("c0356468-62f8-449f-838e-3331955dcbfa"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("104cbfb5-a97a-4abd-9960-ce8b92d409de"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("6ec51867-0091-4d26-b2d4-f626352c5183"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow14SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow14",
				UId = new Guid("8691d777-c9f8-490b-8e82-1c0f4782772c"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				CreatedInPackageId = new Guid("7be0af39-38cd-442a-b589-d8f3ef3f4d19"),
				CreatedInSchemaUId = new Guid("c0356468-62f8-449f-838e-3331955dcbfa"),
				CurveCenterPosition = new Point(382, 102),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("c0356468-62f8-449f-838e-3331955dcbfa"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("6ec51867-0091-4d26-b2d4-f626352c5183"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("44296743-afb6-43d0-949d-e9f9f586e31b"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow15SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow15",
				UId = new Guid("66458236-f75a-4de1-8140-d1a7348ddb70"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				CreatedInPackageId = new Guid("7be0af39-38cd-442a-b589-d8f3ef3f4d19"),
				CreatedInSchemaUId = new Guid("c0356468-62f8-449f-838e-3331955dcbfa"),
				CurveCenterPosition = new Point(543, 98),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("c0356468-62f8-449f-838e-3331955dcbfa"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("44296743-afb6-43d0-949d-e9f9f586e31b"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("7219f4d3-3262-458c-a8c5-b579a9d8436d"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow16SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow16",
				UId = new Guid("e91c109f-765a-4038-aaac-c572d8d68eca"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				CreatedInPackageId = new Guid("7be0af39-38cd-442a-b589-d8f3ef3f4d19"),
				CreatedInSchemaUId = new Guid("c0356468-62f8-449f-838e-3331955dcbfa"),
				CurveCenterPosition = new Point(642, 93),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("c0356468-62f8-449f-838e-3331955dcbfa"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("7219f4d3-3262-458c-a8c5-b579a9d8436d"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("830b8115-b4dd-437d-8f2d-ffbfc871aa03"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateQueueObjectGridPageLaneSetLaneSet() {
			ProcessSchemaLaneSet schemaQueueObjectGridPageLaneSet = new ProcessSchemaLaneSet(this) {
				UId = new Guid("ddcbb3d0-2a5b-4fae-8a30-66c67c56a9c9"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				CreatedInPackageId = new Guid("7be0af39-38cd-442a-b589-d8f3ef3f4d19"),
				CreatedInSchemaUId = new Guid("c0356468-62f8-449f-838e-3331955dcbfa"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("c0356468-62f8-449f-838e-3331955dcbfa"),
				Name = @"QueueObjectGridPageLaneSet",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(5, 5),
				Size = new Size(911, 205)
			};
			return schemaQueueObjectGridPageLaneSet;
		}

		protected virtual ProcessSchemaLane CreateQueueObjectGridPageButtonsLaneLane() {
			ProcessSchemaLane schemaQueueObjectGridPageButtonsLane = new ProcessSchemaLane(this) {
				UId = new Guid("8d5818b7-6deb-461c-b75c-2932964764c3"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("ddcbb3d0-2a5b-4fae-8a30-66c67c56a9c9"),
				CreatedInOwnerSchemaUId = new Guid("87dc5a23-1ee4-4d29-8f8f-a8e81a2d484f"),
				CreatedInPackageId = new Guid("7be0af39-38cd-442a-b589-d8f3ef3f4d19"),
				CreatedInSchemaUId = new Guid("c0356468-62f8-449f-838e-3331955dcbfa"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("c0356468-62f8-449f-838e-3331955dcbfa"),
				Name = @"QueueObjectGridPageButtonsLane",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 0),
				Size = new Size(882, 205)
			};
			return schemaQueueObjectGridPageButtonsLane;
		}

		protected virtual ProcessSchemaEventSubProcess CreateQueueObjectGridPageAddButtonEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaQueueObjectGridPageAddButtonEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("971e021d-0fc6-4f47-8ee4-10cb2870595e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("8d5818b7-6deb-461c-b75c-2932964764c3"),
				CreatedInOwnerSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				CreatedInPackageId = new Guid("7be0af39-38cd-442a-b589-d8f3ef3f4d19"),
				CreatedInSchemaUId = new Guid("c0356468-62f8-449f-838e-3331955dcbfa"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("c0356468-62f8-449f-838e-3331955dcbfa"),
				Name = @"QueueObjectGridPageAddButtonEventSubProcess",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(63, 14),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(700, 177),
				TriggeredByEvent = true,
				UseLastSchemaVersion = false
			};
			
			return schemaQueueObjectGridPageAddButtonEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateQueueObjectGridPageAddButtonClickStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("104cbfb5-a97a-4abd-9960-ce8b92d409de"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("971e021d-0fc6-4f47-8ee4-10cb2870595e"),
				CreatedInOwnerSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				CreatedInPackageId = new Guid("7be0af39-38cd-442a-b589-d8f3ef3f4d19"),
				CreatedInSchemaUId = new Guid("c0356468-62f8-449f-838e-3331955dcbfa"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"AddButtonClick",
				ModifiedInSchemaUId = new Guid("c0356468-62f8-449f-838e-3331955dcbfa"),
				Name = @"QueueObjectGridPageAddButtonClickStartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(50, 65),
				SerializeToDB = false,
				Size = new Size(0, 0)
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateQueueObjectGridPageAddButtonPrepareLookupPageParametersScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("6ec51867-0091-4d26-b2d4-f626352c5183"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("971e021d-0fc6-4f47-8ee4-10cb2870595e"),
				CreatedInOwnerSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				CreatedInPackageId = new Guid("7be0af39-38cd-442a-b589-d8f3ef3f4d19"),
				CreatedInSchemaUId = new Guid("c0356468-62f8-449f-838e-3331955dcbfa"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("c0356468-62f8-449f-838e-3331955dcbfa"),
				Name = @"QueueObjectGridPageAddButtonPrepareLookupPageParametersScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(155, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,145,221,78,194,64,16,133,175,37,241,29,54,189,106,35,217,23,16,77,12,96,210,248,71,2,232,133,241,98,44,3,172,46,187,117,102,43,54,132,119,119,187,69,164,16,244,102,147,78,231,124,231,204,12,59,82,102,38,148,97,7,38,195,116,34,46,68,28,143,144,8,216,78,157,28,167,242,9,95,187,214,56,178,154,229,0,102,152,84,143,188,226,60,124,200,116,43,149,35,59,12,184,56,57,63,109,61,228,104,110,173,125,47,242,49,35,141,128,223,229,128,108,134,204,55,88,122,151,29,203,51,17,144,213,83,57,129,50,72,114,108,212,71,129,105,239,8,202,247,14,128,96,129,14,137,61,206,224,82,244,84,230,148,53,64,165,232,112,72,210,22,246,245,13,51,119,25,34,125,2,137,124,95,24,255,161,74,254,117,246,212,38,81,94,77,38,113,196,217,28,23,48,78,39,81,91,60,46,135,37,15,67,33,53,83,235,139,63,89,116,32,95,43,189,51,67,215,106,141,33,80,231,55,216,126,174,223,113,208,56,229,202,154,126,7,198,71,161,154,119,176,146,125,134,88,157,182,78,86,81,102,23,57,144,98,107,70,101,142,62,110,45,239,54,202,178,255,81,128,94,183,131,66,227,212,245,191,114,242,151,244,100,159,183,88,152,1,184,185,215,70,155,8,247,126,25,209,166,189,96,236,41,206,53,148,143,160,139,202,97,10,154,113,243,151,212,108,190,67,219,238,49,244,178,111,174,134,168,19,63,191,136,85,212,63,156,55,90,175,215,126,27,141,101,134,43,28,221,77,114,228,106,183,187,8,239,221,64,86,34,66,87,144,17,142,10,60,255,6,184,27,55,83,58,3,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaUserTask CreateOpenLookupUserTaskUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("44296743-afb6-43d0-949d-e9f9f586e31b"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("971e021d-0fc6-4f47-8ee4-10cb2870595e"),
				CreatedInOwnerSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				CreatedInPackageId = new Guid("7be0af39-38cd-442a-b589-d8f3ef3f4d19"),
				CreatedInSchemaUId = new Guid("c0356468-62f8-449f-838e-3331955dcbfa"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("c0356468-62f8-449f-838e-3331955dcbfa"),
				Name = @"OpenLookupUserTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(316, 51),
				SchemaUId = new Guid("1aac6458-2318-40e5-8592-778f3a94fdae"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				TaskSchemaManagerName = @"ProcessUserTaskSchemaManager"
			};
			InitializeOpenLookupUserTaskParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaIntermediateCatchMessageEvent CreateQueueObjectGridPageLookupGridPageClosedIntermediateCatchMessageEventIntermediateCatchMessageEvent() {
			ProcessSchemaIntermediateCatchMessageEvent schemaCatchMessageEvent = new ProcessSchemaIntermediateCatchMessageEvent(this) {
				UId = new Guid("7219f4d3-3262-458c-a8c5-b579a9d8436d"),
				AttachedToUId = Guid.Empty,
				BoundaryItemAlignment = ProcessSchemaEditItemAlignment.None,
				CancelActivity = true,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("971e021d-0fc6-4f47-8ee4-10cb2870595e"),
				CreatedInOwnerSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				CreatedInPackageId = new Guid("7be0af39-38cd-442a-b589-d8f3ef3f4d19"),
				CreatedInSchemaUId = new Guid("c0356468-62f8-449f-838e-3331955dcbfa"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("3cb9d737-779e-4085-ab4b-db590853e266"),
				Message = @"LookupGridPageClosed",
				ModifiedInSchemaUId = new Guid("c0356468-62f8-449f-838e-3331955dcbfa"),
				Name = @"QueueObjectGridPageLookupGridPageClosedIntermediateCatchMessageEvent",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(470, 65),
				SerializeToDB = false,
				Size = new Size(0, 0)
			};
			
			return schemaCatchMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateQueueObjectGridPageInsertQueueObjectScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("830b8115-b4dd-437d-8f2d-ffbfc871aa03"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("971e021d-0fc6-4f47-8ee4-10cb2870595e"),
				CreatedInOwnerSchemaUId = new Guid("70874486-32ba-4e24-8dd1-cd97fa9c11cd"),
				CreatedInPackageId = new Guid("7be0af39-38cd-442a-b589-d8f3ef3f4d19"),
				CreatedInSchemaUId = new Guid("c0356468-62f8-449f-838e-3331955dcbfa"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("c0356468-62f8-449f-838e-3331955dcbfa"),
				Name = @"QueueObjectGridPageInsertQueueObjectScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(582, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,83,77,79,219,64,16,61,39,82,254,195,202,39,91,178,86,244,12,69,170,156,128,162,82,8,117,40,7,212,195,96,79,200,22,123,215,236,71,144,85,245,191,51,155,221,40,198,229,128,100,75,222,153,183,239,205,188,25,239,64,51,131,13,86,22,235,95,208,56,52,236,43,187,233,80,94,41,245,236,186,59,131,122,13,230,153,95,162,45,223,193,82,159,42,148,148,20,19,74,102,12,12,43,123,99,177,229,133,106,154,16,53,124,57,23,251,47,208,253,233,108,186,35,53,65,16,47,242,94,149,127,199,222,120,142,35,254,204,88,45,228,83,174,30,255,16,240,220,35,142,204,68,182,81,26,161,218,178,52,224,246,196,76,200,32,144,177,191,179,233,68,108,14,89,190,52,215,174,105,110,244,162,237,108,159,122,76,22,48,147,74,73,43,164,67,162,156,252,163,215,23,137,230,133,74,148,248,202,22,148,180,125,89,109,177,133,91,135,186,31,53,206,135,128,31,32,225,9,117,206,18,178,34,132,146,204,243,18,31,255,169,94,11,229,164,37,226,47,62,22,203,150,208,34,245,229,90,73,9,143,251,86,215,225,156,38,5,116,94,35,201,248,53,161,14,68,23,162,177,168,141,7,166,254,92,144,15,22,67,244,94,216,237,10,52,161,61,36,13,193,66,181,29,104,97,148,92,247,29,242,197,139,131,38,247,173,39,119,203,58,201,247,125,94,58,81,71,91,246,21,135,182,142,134,51,28,7,66,181,180,24,99,232,120,53,78,227,36,198,12,60,218,65,126,196,81,4,166,40,69,2,43,114,147,207,193,66,169,156,174,144,7,75,99,195,1,252,145,216,36,16,240,18,237,28,55,193,204,184,181,227,252,32,153,38,195,81,126,232,204,103,47,31,230,150,255,231,218,195,201,111,111,153,159,67,61,184,30,119,253,60,61,110,195,72,13,118,24,139,31,155,114,165,160,166,221,138,246,242,149,22,45,253,61,3,242,44,110,54,61,179,169,70,235,180,100,86,211,194,191,1,198,53,38,185,253,3,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("2ec18d58-d5ad-4b15-9d7a-8ac963b89dfd"),
				Name = "Terrasoft.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5869487f-ebcd-414c-9fb2-40b8f070b351"),
				Name = "System.Web",
				Alias = "web",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("41c60d94-6edf-44e4-9edb-0e16c226d725"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("92dceabc-4c2b-49a1-baa4-e5bdfa59f339"),
				Name = "Terrasoft.Core.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("aa8aa1ac-15e9-42cc-9636-16aa514d5797"),
				Name = "System.Text",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("775363c7-62ae-4a8d-b363-4350699b5cf2"),
				Name = "System.IO",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("51e927e4-70cf-41b6-867a-8768292a856e"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e450a1d1-32d4-48db-a086-f5426a1a7722"),
				Name = "Terrasoft.Core.Store",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("6f5452a8-39be-4d73-aff7-044da2a7684d"),
				Name = "System.Threading",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("0655a6cd-c0cc-42ef-b029-8e7b7f8cbd5b"),
				Name = "Terrasoft.Reports",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
		}

		protected override SchemaMethod CreateGetRegisterAddPageScriptMethod() {
			SchemaMethod method = base.CreateGetRegisterAddPageScriptMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,72,76,79,213,115,76,73,113,42,45,41,201,207,211,115,204,74,172,112,45,75,205,43,41,214,115,206,201,76,206,214,11,206,76,207,75,204,241,75,204,77,85,176,85,80,130,43,4,75,42,89,115,21,165,150,148,22,229,41,20,151,20,101,230,165,235,185,230,22,148,84,90,115,1,0,39,107,236,215,84,0,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new QueueObjectGridPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c0356468-62f8-449f-838e-3331955dcbfa"));
		}

		#endregion

	}

	#endregion

}

