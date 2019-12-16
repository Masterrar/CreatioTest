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
	using System.IO;
	using System.Linq;
	using System.Runtime.InteropServices;
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

	#region Class: BaseFileEntryGridPageSchema

	/// <exclude/>
	public class BaseFileEntryGridPageSchema : Terrasoft.WebApp.BaseGridPageSchema
	{

		#region Properties: Public

		private Terrasoft.UI.WebControls.Controls.MenuItem _addFileMenuItem;
		public Terrasoft.UI.WebControls.Controls.MenuItem AddFileMenuItem {
			get {
				return _addFileMenuItem;
			}
		}

		private Terrasoft.UI.WebControls.Controls.MenuItem _addLinkMenuItem;
		public Terrasoft.UI.WebControls.Controls.MenuItem AddLinkMenuItem {
			get {
				return _addLinkMenuItem;
			}
		}

		private Terrasoft.UI.WebControls.Controls.MenuItem _addReportMenuItem;
		public Terrasoft.UI.WebControls.Controls.MenuItem AddReportMenuItem {
			get {
				return _addReportMenuItem;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Spacer _editSpacer;
		public Terrasoft.UI.WebControls.Controls.Spacer EditSpacer {
			get {
				return _editSpacer;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Button _saveToFileButton;
		public Terrasoft.UI.WebControls.Controls.Button SaveToFileButton {
			get {
				return _saveToFileButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Button _operationsButton;
		public Terrasoft.UI.WebControls.Controls.Button OperationsButton {
			get {
				return _operationsButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.MenuItem _lockMenuItem;
		public Terrasoft.UI.WebControls.Controls.MenuItem LockMenuItem {
			get {
				return _lockMenuItem;
			}
		}

		private Terrasoft.UI.WebControls.Controls.MenuItem _unlockMenuItem;
		public Terrasoft.UI.WebControls.Controls.MenuItem UnlockMenuItem {
			get {
				return _unlockMenuItem;
			}
		}

		private Terrasoft.UI.WebControls.Controls.MenuItem _showHistoryMenuItem;
		public Terrasoft.UI.WebControls.Controls.MenuItem ShowHistoryMenuItem {
			get {
				return _showHistoryMenuItem;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Button _saveChangesButton;
		public Terrasoft.UI.WebControls.Controls.Button SaveChangesButton {
			get {
				return _saveChangesButton;
			}
		}

		private Terrasoft.UI.WebControls.Controls.Button _reportButton;
		public Terrasoft.UI.WebControls.Controls.Button ReportButton {
			get {
				return _reportButton;
			}
		}

		#endregion

		#region Constructors: Public

		public BaseFileEntryGridPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public BaseFileEntryGridPageSchema(BaseFileEntryGridPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateAddButton() {
			AddButton.Image = new ControlImage {};
			AddButton.ModifiedInSchemaUId = new Guid("8866d1de-f0c0-43d3-a380-c8c5c58df5b6");
		}

		private void UpdateCopyButton() {
			CopyButton.Image = new ControlImage {};
			CopyButton.Hidden = true;
			CopyButton.ModifiedInSchemaUId = new Guid("8866d1de-f0c0-43d3-a380-c8c5c58df5b6");
		}

		private void UpdateEditButton() {
			EditButton.Image = new ControlImage {};
			EditButton.ModifiedInSchemaUId = new Guid("8866d1de-f0c0-43d3-a380-c8c5c58df5b6");
		}

		private void UpdateDeleteButton() {
			DeleteButton.Image = new ControlImage {};
			DeleteButton.ModifiedInSchemaUId = new Guid("8866d1de-f0c0-43d3-a380-c8c5c58df5b6");
		}

		private void UpdatePrintButton() {
			PrintButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73"),
				ImageHash = @"6e713359f7daa6706f06f1a8f5f065f7"
			};
			PrintButton.ModifiedInSchemaUId = new Guid("8866d1de-f0c0-43d3-a380-c8c5c58df5b6");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("8866d1de-f0c0-43d3-a380-c8c5c58df5b6");
		}

		private void UpdateActionButton() {
			ActionButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73"),
				ImageHash = @"388b646e5dc8d8c8203aeeb3f25b057e"
			};
			ActionButton.ModifiedInSchemaUId = new Guid("8866d1de-f0c0-43d3-a380-c8c5c58df5b6");
		}

		private void UpdateButtonsControlLayout() {
			ButtonsControlLayout.Image = new ControlImage {};
			ButtonsControlLayout.ModifiedInSchemaUId = new Guid("8866d1de-f0c0-43d3-a380-c8c5c58df5b6");
		}

		private void UpdateSendEmailMenuItem() {
			SendEmailMenuItem.Image = new ControlImage {};
			SendEmailMenuItem.ModifiedInSchemaUId = new Guid("8866d1de-f0c0-43d3-a380-c8c5c58df5b6");
		}

		private void UpdateSendTemplateEmailMenuItem() {
			SendTemplateEmailMenuItem.Image = new ControlImage {};
			SendTemplateEmailMenuItem.ModifiedInSchemaUId = new Guid("8866d1de-f0c0-43d3-a380-c8c5c58df5b6");
		}

		private void UpdateCallMenuItem() {
			CallMenuItem.AjaxEvents.PrepareMenu.IsProcessEventHandler = true;
			CallMenuItem.Image = new ControlImage {};
			CallMenuItem.ModifiedInSchemaUId = new Guid("8866d1de-f0c0-43d3-a380-c8c5c58df5b6");
		}

		private void UpdateShowChangelogMenuItem() {
			ShowChangelogMenuItem.AjaxEvents.Click.IsProcessEventHandler = true;
			ShowChangelogMenuItem.Image = new ControlImage {};
			ShowChangelogMenuItem.ModifiedInSchemaUId = new Guid("8866d1de-f0c0-43d3-a380-c8c5c58df5b6");
		}

		private void UpdateTreeGrid() {
			TreeGrid.AjaxEvents.ContextMenu.IsProcessEventHandler = true;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("8866d1de-f0c0-43d3-a380-c8c5c58df5b6");
			RealUId = new Guid("8866d1de-f0c0-43d3-a380-c8c5c58df5b6");
			Name = "BaseFileEntryGridPage";
			ParentSchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateBaseFileEntryGridPageEventsProcessSchema();
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
			UpdateContextHelpButton();
			UpdatePrintButton();
			UpdateDeleteButton();
			UpdateEditButton();
			UpdateCopyButton();
			UpdateAddButton();
			TopLevelControl.MoveItem(0, ButtonsControlLayout);
			ButtonsControlLayout.MoveItem(0, AddButton);
			AddButton.InsertItem(0, CreateAddFileMenuItem());
			AddButton.InsertItem(1, CreateAddLinkMenuItem());
			AddButton.InsertItem(2, CreateAddReportMenuItem());
			ButtonsControlLayout.MoveItem(1, CopyButton);
			ButtonsControlLayout.MoveItem(2, EditButton);
			ButtonsControlLayout.MoveItem(3, DeleteButton);
			ButtonsControlLayout.InsertItem(4, CreateEditSpacer());
			ButtonsControlLayout.InsertItem(5, CreateSaveToFileButton());
			ButtonsControlLayout.InsertItem(6, CreateOperationsButton());
			OperationsButton.InsertItem(0, CreateLockMenuItem());
			OperationsButton.InsertItem(1, CreateUnlockMenuItem());
			OperationsButton.InsertItem(2, CreateShowHistoryMenuItem());
			ButtonsControlLayout.InsertItem(7, CreateSaveChangesButton());
			ButtonsControlLayout.InsertItem(8, CreateReportButton());
			ButtonsControlLayout.MoveItem(9, SpacerPrintButton);
			ButtonsControlLayout.MoveItem(10, PrintButton);
			ButtonsControlLayout.MoveItem(11, ContextHelpButton);
			ButtonsControlLayout.MoveItem(12, ActionButton);
			TopLevelControl.MoveItem(1, TreeGrid);
			TreeGrid.MoveItem(0, SendEmailMenuItem);
			TreeGrid.MoveItem(1, SendTemplateEmailMenuItem);
			TreeGrid.MoveItem(2, CallMenuItem);
			TreeGrid.MoveItem(3, ShowChangelogMenuItem);
			TopLevelControl.MoveItem(2, DataSource);
			SetControlsDefInheritance(UId);
			InitializeLocalizableValues();
		}

		protected virtual EmbeddedProcessSchema CreateBaseFileEntryGridPageEventsProcessSchema() {
			var schema = new BaseFileEntryGridPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.MenuItem CreateAddFileMenuItem() {
			_addFileMenuItem = new Terrasoft.UI.WebControls.Controls.MenuItem();
			_addFileMenuItem.UId = new Guid("e415c8be-841f-4d72-bb90-b0d7b58ec534");
			_addFileMenuItem.Name = "AddFileMenuItem";
			_addFileMenuItem.CreatedInSchemaUId = new Guid("8866d1de-f0c0-43d3-a380-c8c5c58df5b6");
			_addFileMenuItem.ModifiedInSchemaUId = new Guid("8866d1de-f0c0-43d3-a380-c8c5c58df5b6");
			_addFileMenuItem.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_addFileMenuItem.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_addFileMenuItem.Image = new ControlImage {};
			_addFileMenuItem.Tag = "";
			return _addFileMenuItem;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.MenuItem CreateAddLinkMenuItem() {
			_addLinkMenuItem = new Terrasoft.UI.WebControls.Controls.MenuItem();
			_addLinkMenuItem.UId = new Guid("037d03a6-9539-4205-8242-2817e8e3ee66");
			_addLinkMenuItem.Name = "AddLinkMenuItem";
			_addLinkMenuItem.CreatedInSchemaUId = new Guid("8866d1de-f0c0-43d3-a380-c8c5c58df5b6");
			_addLinkMenuItem.ModifiedInSchemaUId = new Guid("8866d1de-f0c0-43d3-a380-c8c5c58df5b6");
			_addLinkMenuItem.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_addLinkMenuItem.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_addLinkMenuItem.Image = new ControlImage {};
			_addLinkMenuItem.Tag = "";
			return _addLinkMenuItem;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.MenuItem CreateAddReportMenuItem() {
			_addReportMenuItem = new Terrasoft.UI.WebControls.Controls.MenuItem();
			_addReportMenuItem.UId = new Guid("135dc4a8-f793-4b0e-989e-021bc913970a");
			_addReportMenuItem.Name = "AddReportMenuItem";
			_addReportMenuItem.CreatedInSchemaUId = new Guid("8866d1de-f0c0-43d3-a380-c8c5c58df5b6");
			_addReportMenuItem.ModifiedInSchemaUId = new Guid("8866d1de-f0c0-43d3-a380-c8c5c58df5b6");
			_addReportMenuItem.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_addReportMenuItem.AjaxEvents.Click.IsProcessEventHandler = true;
			_addReportMenuItem.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_addReportMenuItem.Image = new ControlImage {};
			_addReportMenuItem.Tag = "";
			_addReportMenuItem.Hidden = true;
			return _addReportMenuItem;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Spacer CreateEditSpacer() {
			_editSpacer = new Terrasoft.UI.WebControls.Controls.Spacer();
			_editSpacer.UId = new Guid("999c13ed-4be8-44d7-8093-e051442ff839");
			_editSpacer.Name = "EditSpacer";
			_editSpacer.CreatedInSchemaUId = new Guid("8866d1de-f0c0-43d3-a380-c8c5c58df5b6");
			_editSpacer.ModifiedInSchemaUId = new Guid("8866d1de-f0c0-43d3-a380-c8c5c58df5b6");
			_editSpacer.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_editSpacer.Tag = "";
			_editSpacer.Size = System.Web.UI.WebControls.Unit.Pixel(20);
			return _editSpacer;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateSaveToFileButton() {
			_saveToFileButton = new Terrasoft.UI.WebControls.Controls.Button();
			_saveToFileButton.UId = new Guid("61f0b995-6323-492e-87c8-343140154903");
			_saveToFileButton.Name = "SaveToFileButton";
			_saveToFileButton.CreatedInSchemaUId = new Guid("8866d1de-f0c0-43d3-a380-c8c5c58df5b6");
			_saveToFileButton.ModifiedInSchemaUId = new Guid("8866d1de-f0c0-43d3-a380-c8c5c58df5b6");
			_saveToFileButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_saveToFileButton.AjaxEvents.Click.IsProcessEventHandler = true;
			_saveToFileButton.Tag = "";
			_saveToFileButton.Image = new ControlImage {};
			_saveToFileButton.Enabled = false;
			return _saveToFileButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.MenuItem CreateLockMenuItem() {
			_lockMenuItem = new Terrasoft.UI.WebControls.Controls.MenuItem();
			_lockMenuItem.UId = new Guid("208ef6df-9444-451d-8eab-a15aaf859882");
			_lockMenuItem.Name = "LockMenuItem";
			_lockMenuItem.CreatedInSchemaUId = new Guid("8866d1de-f0c0-43d3-a380-c8c5c58df5b6");
			_lockMenuItem.ModifiedInSchemaUId = new Guid("8866d1de-f0c0-43d3-a380-c8c5c58df5b6");
			_lockMenuItem.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_lockMenuItem.AjaxEvents.Click.IsProcessEventHandler = true;
			_lockMenuItem.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_lockMenuItem.Image = new ControlImage {};
			_lockMenuItem.Tag = "";
			_lockMenuItem.Enabled = false;
			return _lockMenuItem;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.MenuItem CreateUnlockMenuItem() {
			_unlockMenuItem = new Terrasoft.UI.WebControls.Controls.MenuItem();
			_unlockMenuItem.UId = new Guid("e232ebfa-efd8-4e05-95b2-4f7eb30792c8");
			_unlockMenuItem.Name = "UnlockMenuItem";
			_unlockMenuItem.CreatedInSchemaUId = new Guid("8866d1de-f0c0-43d3-a380-c8c5c58df5b6");
			_unlockMenuItem.ModifiedInSchemaUId = new Guid("8866d1de-f0c0-43d3-a380-c8c5c58df5b6");
			_unlockMenuItem.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_unlockMenuItem.AjaxEvents.Click.IsProcessEventHandler = true;
			_unlockMenuItem.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_unlockMenuItem.Image = new ControlImage {};
			_unlockMenuItem.Tag = "";
			_unlockMenuItem.Enabled = false;
			return _unlockMenuItem;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.MenuItem CreateShowHistoryMenuItem() {
			_showHistoryMenuItem = new Terrasoft.UI.WebControls.Controls.MenuItem();
			_showHistoryMenuItem.UId = new Guid("5a5131c3-012b-4a65-9896-b487ea01c792");
			_showHistoryMenuItem.Name = "ShowHistoryMenuItem";
			_showHistoryMenuItem.CreatedInSchemaUId = new Guid("8866d1de-f0c0-43d3-a380-c8c5c58df5b6");
			_showHistoryMenuItem.ModifiedInSchemaUId = new Guid("8866d1de-f0c0-43d3-a380-c8c5c58df5b6");
			_showHistoryMenuItem.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_showHistoryMenuItem.AjaxEvents.Click.IsProcessEventHandler = true;
			_showHistoryMenuItem.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_showHistoryMenuItem.Image = new ControlImage {};
			_showHistoryMenuItem.Tag = "";
			return _showHistoryMenuItem;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateOperationsButton() {
			_operationsButton = new Terrasoft.UI.WebControls.Controls.Button();
			_operationsButton.UId = new Guid("722403e8-2be5-461e-bb50-92389ecaf468");
			_operationsButton.Name = "OperationsButton";
			_operationsButton.CreatedInSchemaUId = new Guid("8866d1de-f0c0-43d3-a380-c8c5c58df5b6");
			_operationsButton.ModifiedInSchemaUId = new Guid("8866d1de-f0c0-43d3-a380-c8c5c58df5b6");
			_operationsButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_operationsButton.AjaxEvents.MenuShow.IsProcessEventHandler = true;
			_operationsButton.Tag = "";
			_operationsButton.Image = new ControlImage {};
			_operationsButton.Enabled = false;
			return _operationsButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateSaveChangesButton() {
			_saveChangesButton = new Terrasoft.UI.WebControls.Controls.Button();
			_saveChangesButton.UId = new Guid("c186f7b3-9164-4a83-9bc8-55c765791cc6");
			_saveChangesButton.Name = "SaveChangesButton";
			_saveChangesButton.CreatedInSchemaUId = new Guid("8866d1de-f0c0-43d3-a380-c8c5c58df5b6");
			_saveChangesButton.ModifiedInSchemaUId = new Guid("8866d1de-f0c0-43d3-a380-c8c5c58df5b6");
			_saveChangesButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_saveChangesButton.Tag = "";
			_saveChangesButton.Image = new ControlImage {};
			_saveChangesButton.Hidden = true;
			return _saveChangesButton;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateReportButton() {
			_reportButton = new Terrasoft.UI.WebControls.Controls.Button();
			_reportButton.UId = new Guid("e0ffe5e2-0d44-442a-9f49-1b1f68a335c4");
			_reportButton.Name = "ReportButton";
			_reportButton.CreatedInSchemaUId = new Guid("8866d1de-f0c0-43d3-a380-c8c5c58df5b6");
			_reportButton.ModifiedInSchemaUId = new Guid("8866d1de-f0c0-43d3-a380-c8c5c58df5b6");
			_reportButton.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_reportButton.Tag = "";
			_reportButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("8866d1de-f0c0-43d3-a380-c8c5c58df5b6"),
				ImageHash = @"1caec8007e792e2068cf9b51e1f8da01"
			};
			_reportButton.Hidden = true;
			return _reportButton;
		}

		protected override void UpdateDataSource() {
			base.UpdateDataSource();
			DataSource.SchemaUId = new Guid("556c5867-60a7-4456-aae1-a57a122bef70");
			DataSource.ModifiedInSchemaUId = new Guid("8866d1de-f0c0-43d3-a380-c8c5c58df5b6");
			DataSourceStructureColumn column = null;
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ae0e45ca-c495-4fe7-a39d-3ab7278e1617");
			if (column != null) {
				column.UId = new Guid("4d85bc14-cd6c-4d3d-8e6e-b96ef751160e");
				column.Name = @"Id";
				column.CreatedInSchemaUId = new Guid("8866d1de-f0c0-43d3-a380-c8c5c58df5b6");
				column.ModifiedInSchemaUId = new Guid("8866d1de-f0c0-43d3-a380-c8c5c58df5b6");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
				column.IsAlwaysSelect = true;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("4a35bb09-6c8c-4de8-8773-4e9e3b3cf3b0");
			if (column != null) {
				column.UId = new Guid("709b1de0-4f56-49b9-96b6-0236f1e54d20");
				column.Name = @"Name";
				column.CreatedInSchemaUId = new Guid("8866d1de-f0c0-43d3-a380-c8c5c58df5b6");
				column.ModifiedInSchemaUId = new Guid("8866d1de-f0c0-43d3-a380-c8c5c58df5b6");
				column.CreatedInPackageId = Guid.Empty;
				column.IsAlwaysSelect = true;
				column.OrderDirection = OrderDirection.Ascending;
				column.OrderPosition = 1;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("e80190a5-03b2-4095-90f7-a193a960adee");
			if (column != null) {
				column.UId = new Guid("c3e67ffb-bafb-453c-91e0-9e80e6fc731e");
				column.Name = @"CreatedOn";
				column.CreatedInSchemaUId = new Guid("8866d1de-f0c0-43d3-a380-c8c5c58df5b6");
				column.ModifiedInSchemaUId = new Guid("8866d1de-f0c0-43d3-a380-c8c5c58df5b6");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ebf6bb93-8aa6-4a01-900d-c6ea67affe21");
			if (column != null) {
				column.UId = new Guid("4291ec03-1dab-409a-b624-a2ee0a88fdce");
				column.Name = @"CreatedBy";
				column.CreatedInSchemaUId = new Guid("8866d1de-f0c0-43d3-a380-c8c5c58df5b6");
				column.ModifiedInSchemaUId = new Guid("8866d1de-f0c0-43d3-a380-c8c5c58df5b6");
				column.CreatedInPackageId = Guid.Empty;
				column.IsVisible = false;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("8d8676ce-6974-4157-9a96-841d4499fccb");
			if (column != null) {
				column.UId = new Guid("10a737b7-62aa-4efd-b335-8227f57537b3");
				column.Name = @"Version";
				column.CreatedInSchemaUId = new Guid("8866d1de-f0c0-43d3-a380-c8c5c58df5b6");
				column.ModifiedInSchemaUId = new Guid("8866d1de-f0c0-43d3-a380-c8c5c58df5b6");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("6b37344b-b460-44c5-9fd7-a623689bba4c");
			if (column != null) {
				column.UId = new Guid("2f22f7ed-a282-4bbe-92ca-6c8002384b02");
				column.Name = @"LockedBy";
				column.CreatedInSchemaUId = new Guid("8866d1de-f0c0-43d3-a380-c8c5c58df5b6");
				column.ModifiedInSchemaUId = new Guid("8866d1de-f0c0-43d3-a380-c8c5c58df5b6");
				column.CreatedInPackageId = Guid.Empty;
			}
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override PageSchemaUserControl CreateUserControl() {
			return new BaseFileEntryGridPageSchemaUserControl();
		}

		public override object Clone() {
			return new BaseFileEntryGridPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("8866d1de-f0c0-43d3-a380-c8c5c58df5b6"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new BaseFileEntryGridPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: BaseFileEntryGridPageEventsProcess

	/// <exclude/>
	public class BaseFileEntryGridPageEventsProcess<TPage> : Terrasoft.WebApp.BaseGridPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.BaseFileEntryGridPageSchemaUserControl
	{

		#region Class: OpenFileHistoryPageUserTaskFlowElement

		/// <exclude/>
		public class OpenFileHistoryPageUserTaskFlowElement : OpenPageUserTask
		{

			public OpenFileHistoryPageUserTaskFlowElement(UserConnection userConnection, BaseFileEntryGridPageEventsProcess<TPage> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "OpenFileHistoryPageUserTask";
				IsLogging = false;
				SchemaElementUId = new Guid("5ca3b58e-c921-405b-9e56-b536cb2f0275");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		#region Class: OpenMessageUserTaskFlowElement

		/// <exclude/>
		public class OpenMessageUserTaskFlowElement : QuestionUserTask
		{

			public OpenMessageUserTaskFlowElement(UserConnection userConnection, BaseFileEntryGridPageEventsProcess<TPage> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "OpenMessageUserTask";
				IsLogging = false;
				SchemaElementUId = new Guid("74950f4a-71ec-4fd2-944c-71b653fc35f6");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		#region Class: OpenLookupUserTaskFlowElement

		/// <exclude/>
		public class OpenLookupUserTaskFlowElement : OpenLookupUserTask
		{

			public OpenLookupUserTaskFlowElement(UserConnection userConnection, BaseFileEntryGridPageEventsProcess<TPage> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "OpenLookupUserTask";
				IsLogging = false;
				SchemaElementUId = new Guid("406bcbc9-8cd3-4389-85e9-419bc1d1f108");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		#region Class: AskForceFileUnlockUserTaskFlowElement

		/// <exclude/>
		public class AskForceFileUnlockUserTaskFlowElement : QuestionUserTask
		{

			public AskForceFileUnlockUserTaskFlowElement(UserConnection userConnection, BaseFileEntryGridPageEventsProcess<TPage> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "AskForceFileUnlockUserTask";
				IsLogging = false;
				SchemaElementUId = new Guid("3974ecaa-1475-487c-8132-a33d4b5482aa");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		public BaseFileEntryGridPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "BaseFileEntryGridPageEventsProcess";
			SchemaUId = new Guid("8866d1de-f0c0-43d3-a380-c8c5c58df5b6");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("8866d1de-f0c0-43d3-a380-c8c5c58df5b6");
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

		public virtual Guid FileTypeId {
			get;
			set;
		}

		public virtual bool DoProposeForceFileUnlock {
			get;
			set;
		}

		public virtual Guid LockedById {
			get;
			set;
		}

		public virtual Object ReportDictionary {
			get;
			set;
		}

		public virtual bool IsTrackChanges {
			get;
			set;
		}

		private ProcessFlowElement _eventSubProcess10;
		public ProcessFlowElement EventSubProcess10 {
			get {
				return _eventSubProcess10 ?? (_eventSubProcess10 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess10",
					SchemaElementUId = new Guid("dc5b582e-655e-45c0-b97a-4c77abf9323f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessage1234598;
		public ProcessFlowElement StartMessage1234598 {
			get {
				return _startMessage1234598 ?? (_startMessage1234598 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessage1234598",
					SchemaElementUId = new Guid("c84991ce-afd6-4fb5-afcf-322226a59c9a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _setOpenPageParametersScriptTask;
		public ProcessScriptTask SetOpenPageParametersScriptTask {
			get {
				return _setOpenPageParametersScriptTask ?? (_setOpenPageParametersScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "SetOpenPageParametersScriptTask",
					SchemaElementUId = new Guid("785886ee-9551-4937-888b-4bd7470f43d3"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = SetOpenPageParametersScriptTaskExecute,
				});
			}
		}

		private OpenFileHistoryPageUserTaskFlowElement _openFileHistoryPageUserTask;
		public OpenFileHistoryPageUserTaskFlowElement OpenFileHistoryPageUserTask {
			get {
				return _openFileHistoryPageUserTask ?? (_openFileHistoryPageUserTask = new OpenFileHistoryPageUserTaskFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessExclusiveGateway _exclusiveGateway;
		public ProcessExclusiveGateway ExclusiveGateway {
			get {
				return _exclusiveGateway ?? (_exclusiveGateway = new ProcessExclusiveGateway() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaExclusiveGateway",
					Name = "ExclusiveGateway",
					SchemaElementUId = new Guid("4e1cc226-33f7-4325-9bdd-2340b1850a29"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Question = new LocalizableString(Storage, Schema.GetResourceManagerName(),
					"EventsProcessSchema.BaseElements.ExclusiveGateway.Question"),
						IsDecisionRequired = false,
						BranchingMode = GatewayBranchingMode.Auto,
						DecisionMode = GetewayDecisionSelectionMode.Single,
						ShowUserDecisionDialog = (processId, gatewayName) => {},
				});
			}
		}

		private ProcessScriptTask _setMessageParametersScriptTask;
		public ProcessScriptTask SetMessageParametersScriptTask {
			get {
				return _setMessageParametersScriptTask ?? (_setMessageParametersScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "SetMessageParametersScriptTask",
					SchemaElementUId = new Guid("7c9a5058-83d4-42f6-ad3d-2c996ef0059b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = SetMessageParametersScriptTaskExecute,
				});
			}
		}

		private OpenMessageUserTaskFlowElement _openMessageUserTask;
		public OpenMessageUserTaskFlowElement OpenMessageUserTask {
			get {
				return _openMessageUserTask ?? (_openMessageUserTask = new OpenMessageUserTaskFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessFlowElement _eventSubProcess8;
		public ProcessFlowElement EventSubProcess8 {
			get {
				return _eventSubProcess8 ?? (_eventSubProcess8 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess8",
					SchemaElementUId = new Guid("de442f50-57e2-4e06-9993-b4fa459d605a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _reportButtonClickScript;
		public ProcessScriptTask ReportButtonClickScript {
			get {
				return _reportButtonClickScript ?? (_reportButtonClickScript = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ReportButtonClickScript",
					SchemaElementUId = new Guid("d6470104-6356-4636-9321-cde4191f24c9"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ReportButtonClickScriptExecute,
				});
			}
		}

		private OpenLookupUserTaskFlowElement _openLookupUserTask;
		public OpenLookupUserTaskFlowElement OpenLookupUserTask {
			get {
				return _openLookupUserTask ?? (_openLookupUserTask = new OpenLookupUserTaskFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessScriptTask _afterLookupGridPageClosedScript;
		public ProcessScriptTask AfterLookupGridPageClosedScript {
			get {
				return _afterLookupGridPageClosedScript ?? (_afterLookupGridPageClosedScript = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "AfterLookupGridPageClosedScript",
					SchemaElementUId = new Guid("e03184fb-b499-4fbe-9c0c-19edc0066a28"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = AfterLookupGridPageClosedScriptExecute,
				});
			}
		}

		private ProcessIntermediateCatchMessageEvent _lookupGridPageClosed;
		public ProcessIntermediateCatchMessageEvent LookupGridPageClosed {
			get {
				return _lookupGridPageClosed ?? (_lookupGridPageClosed = new ProcessIntermediateCatchMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateCatchMessageEvent",
					Name = "LookupGridPageClosed",
					SchemaElementUId = new Guid("e652d634-d8f2-4b20-a1f4-992290eccf05"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "LookupGridPageClosed",
				});
			}
		}

		private ProcessFlowElement _addReportMenuItemClickStartMessage;
		public ProcessFlowElement AddReportMenuItemClickStartMessage {
			get {
				return _addReportMenuItemClickStartMessage ?? (_addReportMenuItemClickStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "AddReportMenuItemClickStartMessage",
					SchemaElementUId = new Guid("32145160-76c9-46cf-83af-d9048b3ca47a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
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
					SchemaElementUId = new Guid("0dbd02d5-aa5d-4b71-90e3-581e4d666cc7"),
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
					SchemaElementUId = new Guid("24c53539-bb2c-4a58-9831-1a1ee8bd4b26"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessThrowMessageEvent _intermediateThrowMessageEvent2;
		public ProcessThrowMessageEvent IntermediateThrowMessageEvent2 {
			get {
				return _intermediateThrowMessageEvent2 ?? (_intermediateThrowMessageEvent2 = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "IntermediateThrowMessageEvent2",
					SchemaElementUId = new Guid("9bbbf65c-4038-4367-bdb0-bac59611c0d6"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "DataSourceActiveRowChanged",
						ThrowToBase = true,
				});
			}
		}

		private ProcessScriptTask _scriptTask1;
		public ProcessScriptTask ScriptTask1 {
			get {
				return _scriptTask1 ?? (_scriptTask1 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask1",
					SchemaElementUId = new Guid("45d08d2a-3e34-447b-9369-88157cc7728c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask1Execute,
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
					SchemaElementUId = new Guid("dc76a0f0-b446-4243-8dd1-9af06d400920"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessThrowMessageEvent _intermediateThrowMessageEvent3;
		public ProcessThrowMessageEvent IntermediateThrowMessageEvent3 {
			get {
				return _intermediateThrowMessageEvent3 ?? (_intermediateThrowMessageEvent3 = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "IntermediateThrowMessageEvent3",
					SchemaElementUId = new Guid("34d32e98-37a3-411c-a963-97699a600797"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "DataSourceLoadRowsResponseRegistered",
						ThrowToBase = true,
				});
			}
		}

		private ProcessScriptTask _lockUnlockEditButtonsScriptTask;
		public ProcessScriptTask LockUnlockEditButtonsScriptTask {
			get {
				return _lockUnlockEditButtonsScriptTask ?? (_lockUnlockEditButtonsScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "LockUnlockEditButtonsScriptTask",
					SchemaElementUId = new Guid("03954345-2078-46cc-a908-d97f3844c326"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = LockUnlockEditButtonsScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcessChildDataSourceLoadRows;
		public ProcessFlowElement EventSubProcessChildDataSourceLoadRows {
			get {
				return _eventSubProcessChildDataSourceLoadRows ?? (_eventSubProcessChildDataSourceLoadRows = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcessChildDataSourceLoadRows",
					SchemaElementUId = new Guid("6d9278ee-564e-4e0c-9e02-8f1d6b133436"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessageChildDataSourceLoadRows;
		public ProcessFlowElement StartMessageChildDataSourceLoadRows {
			get {
				return _startMessageChildDataSourceLoadRows ?? (_startMessageChildDataSourceLoadRows = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessageChildDataSourceLoadRows",
					SchemaElementUId = new Guid("528d55a6-7803-416c-b55a-e4e2fd46fd88"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessThrowMessageEvent _intermediateThrowBaseDataSourceLoadRows;
		public ProcessThrowMessageEvent IntermediateThrowBaseDataSourceLoadRows {
			get {
				return _intermediateThrowBaseDataSourceLoadRows ?? (_intermediateThrowBaseDataSourceLoadRows = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "IntermediateThrowBaseDataSourceLoadRows",
					SchemaElementUId = new Guid("184eeaa4-b6f1-474e-bacd-c5ee4f5f8c3a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "DataSourceLoadRows",
						ThrowToBase = true,
				});
			}
		}

		private ProcessScriptTask _scriptChildDataSourceLoadRows;
		public ProcessScriptTask ScriptChildDataSourceLoadRows {
			get {
				return _scriptChildDataSourceLoadRows ?? (_scriptChildDataSourceLoadRows = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptChildDataSourceLoadRows",
					SchemaElementUId = new Guid("48fbed24-86b8-43e7-adf4-ad5ccf5cedaa"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptChildDataSourceLoadRowsExecute,
				});
			}
		}

		private ProcessFlowElement _subProcessPageLoadCompleteChield;
		public ProcessFlowElement SubProcessPageLoadCompleteChield {
			get {
				return _subProcessPageLoadCompleteChield ?? (_subProcessPageLoadCompleteChield = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "SubProcessPageLoadCompleteChield",
					SchemaElementUId = new Guid("1c7c6df3-9053-4f09-97eb-7491f1fcbc2f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _pageLoadCompleteChield;
		public ProcessFlowElement PageLoadCompleteChield {
			get {
				return _pageLoadCompleteChield ?? (_pageLoadCompleteChield = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "PageLoadCompleteChield",
					SchemaElementUId = new Guid("a6e910f3-0d4b-46e9-9108-479a5b5f3ba9"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptPageLoadCompleteChield;
		public ProcessScriptTask ScriptPageLoadCompleteChield {
			get {
				return _scriptPageLoadCompleteChield ?? (_scriptPageLoadCompleteChield = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptPageLoadCompleteChield",
					SchemaElementUId = new Guid("bda281f8-00b2-475d-9a23-5ee929b94e52"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptPageLoadCompleteChieldExecute,
				});
			}
		}

		private ProcessThrowMessageEvent _pageLoadCompleteBase;
		public ProcessThrowMessageEvent PageLoadCompleteBase {
			get {
				return _pageLoadCompleteBase ?? (_pageLoadCompleteBase = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "PageLoadCompleteBase",
					SchemaElementUId = new Guid("832dfb6c-6e91-4b49-a6fb-c2e36bdcdc61"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "PageLoadComplete",
						ThrowToBase = true,
				});
			}
		}

		private ProcessFlowElement _subProcessSaveToFileButton;
		public ProcessFlowElement SubProcessSaveToFileButton {
			get {
				return _subProcessSaveToFileButton ?? (_subProcessSaveToFileButton = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "SubProcessSaveToFileButton",
					SchemaElementUId = new Guid("1480ccd5-a143-4a11-8f0e-eea62cf79569"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _saveToFileButtonClick;
		public ProcessFlowElement SaveToFileButtonClick {
			get {
				return _saveToFileButtonClick ?? (_saveToFileButtonClick = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "SaveToFileButtonClick",
					SchemaElementUId = new Guid("b41f38ca-9d39-4c20-8624-31f5368a2262"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptSaveToFileButtonClick;
		public ProcessScriptTask ScriptSaveToFileButtonClick {
			get {
				return _scriptSaveToFileButtonClick ?? (_scriptSaveToFileButtonClick = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptSaveToFileButtonClick",
					SchemaElementUId = new Guid("2d530126-f3de-419e-8188-9d384cada59f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptSaveToFileButtonClickExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcessInit;
		public ProcessFlowElement EventSubProcessInit {
			get {
				return _eventSubProcessInit ?? (_eventSubProcessInit = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcessInit",
					SchemaElementUId = new Guid("f68810d9-5022-4295-9628-bd922589469b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessageChildInit;
		public ProcessFlowElement StartMessageChildInit {
			get {
				return _startMessageChildInit ?? (_startMessageChildInit = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessageChildInit",
					SchemaElementUId = new Guid("33530ebf-cc11-423c-bd57-c2e56ed8fa3e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptChildInit;
		public ProcessScriptTask ScriptChildInit {
			get {
				return _scriptChildInit ?? (_scriptChildInit = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptChildInit",
					SchemaElementUId = new Guid("8cf10a47-e666-4d0d-9a7a-8baa75f9468b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptChildInitExecute,
				});
			}
		}

		private ProcessThrowMessageEvent _intermediateThrowBaseInit;
		public ProcessThrowMessageEvent IntermediateThrowBaseInit {
			get {
				return _intermediateThrowBaseInit ?? (_intermediateThrowBaseInit = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "IntermediateThrowBaseInit",
					SchemaElementUId = new Guid("2ce010a1-2a2d-427b-9f38-a02cb548295f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "Init",
						ThrowToBase = true,
				});
			}
		}

		private ProcessFlowElement _subProcessOperationsButtonMenu;
		public ProcessFlowElement SubProcessOperationsButtonMenu {
			get {
				return _subProcessOperationsButtonMenu ?? (_subProcessOperationsButtonMenu = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "SubProcessOperationsButtonMenu",
					SchemaElementUId = new Guid("c622eccb-4351-4479-b306-29d851859192"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _operationsButtonMenuShow;
		public ProcessFlowElement OperationsButtonMenuShow {
			get {
				return _operationsButtonMenuShow ?? (_operationsButtonMenuShow = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "OperationsButtonMenuShow",
					SchemaElementUId = new Guid("a77ae3ec-adb3-4a76-a058-040da22e0b32"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptOperationsButtonMenuShow;
		public ProcessScriptTask ScriptOperationsButtonMenuShow {
			get {
				return _scriptOperationsButtonMenuShow ?? (_scriptOperationsButtonMenuShow = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptOperationsButtonMenuShow",
					SchemaElementUId = new Guid("08cb2815-45df-47ac-9b3a-bac7ff97576c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptOperationsButtonMenuShowExecute,
				});
			}
		}

		private ProcessFlowElement _subProcessLockMenu;
		public ProcessFlowElement SubProcessLockMenu {
			get {
				return _subProcessLockMenu ?? (_subProcessLockMenu = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "SubProcessLockMenu",
					SchemaElementUId = new Guid("c6a92f44-b23d-4810-88b1-7952a8330905"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _lockMenuItemClick;
		public ProcessFlowElement LockMenuItemClick {
			get {
				return _lockMenuItemClick ?? (_lockMenuItemClick = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "LockMenuItemClick",
					SchemaElementUId = new Guid("ac66c420-0ee7-45ff-8340-41545f1c4f9c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptLockMenuItemClick;
		public ProcessScriptTask ScriptLockMenuItemClick {
			get {
				return _scriptLockMenuItemClick ?? (_scriptLockMenuItemClick = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptLockMenuItemClick",
					SchemaElementUId = new Guid("02f76589-794c-4327-9bb6-a1c1084e8615"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptLockMenuItemClickExecute,
				});
			}
		}

		private ProcessFlowElement _subProcessUnlockMenu;
		public ProcessFlowElement SubProcessUnlockMenu {
			get {
				return _subProcessUnlockMenu ?? (_subProcessUnlockMenu = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "SubProcessUnlockMenu",
					SchemaElementUId = new Guid("0fe0afde-2d40-41a6-b3de-d923e593e7ff"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _unlockMenuItemClick;
		public ProcessFlowElement UnlockMenuItemClick {
			get {
				return _unlockMenuItemClick ?? (_unlockMenuItemClick = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "UnlockMenuItemClick",
					SchemaElementUId = new Guid("63e218ae-a0f1-4657-a2fe-7855ce751ca1"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptUnlockMenuItemClick;
		public ProcessScriptTask ScriptUnlockMenuItemClick {
			get {
				return _scriptUnlockMenuItemClick ?? (_scriptUnlockMenuItemClick = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptUnlockMenuItemClick",
					SchemaElementUId = new Guid("836b5838-1d8f-4bf9-8319-585bae79bfad"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptUnlockMenuItemClickExecute,
				});
			}
		}

		private AskForceFileUnlockUserTaskFlowElement _askForceFileUnlockUserTask;
		public AskForceFileUnlockUserTaskFlowElement AskForceFileUnlockUserTask {
			get {
				return _askForceFileUnlockUserTask ?? (_askForceFileUnlockUserTask = new AskForceFileUnlockUserTaskFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessScriptTask _scriptEmpty;
		public ProcessScriptTask ScriptEmpty {
			get {
				return _scriptEmpty ?? (_scriptEmpty = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptEmpty",
					SchemaElementUId = new Guid("8a5be461-e2c8-4639-8d98-d677c1f054f3"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptEmptyExecute,
				});
			}
		}

		private ProcessScriptTask _scriptYesUnlockFileMessage;
		public ProcessScriptTask ScriptYesUnlockFileMessage {
			get {
				return _scriptYesUnlockFileMessage ?? (_scriptYesUnlockFileMessage = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptYesUnlockFileMessage",
					SchemaElementUId = new Guid("343c563a-f75c-4ef4-b956-18cf4bf914a8"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptYesUnlockFileMessageExecute,
				});
			}
		}

		private ProcessFlowElement _yesUnlockFileMessage;
		public ProcessFlowElement YesUnlockFileMessage {
			get {
				return _yesUnlockFileMessage ?? (_yesUnlockFileMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "YesUnlockFileMessage",
					SchemaElementUId = new Guid("c3874dc1-5995-4a24-bc88-0256214e1873"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessConditionalFlow _sequenceFlow8589;
		public ProcessConditionalFlow SequenceFlow8589 {
			get {
				return _sequenceFlow8589 ?? (_sequenceFlow8589 = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "SequenceFlow8589",
					SchemaElementUId = new Guid("c4502ed5-5dc1-4a13-b37f-cf8f8a5ced66"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
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
					SchemaElementUId = new Guid("aa7b4c8d-29c6-49bb-9a32-1f3b2f3fba8c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private LocalizableString _selectFile;
		public LocalizableString SelectFile {
			get {
				return _selectFile ?? (_selectFile = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.SelectFile.Value"));
			}
		}

		private LocalizableString _askForceFileUnlock;
		public LocalizableString AskForceFileUnlock {
			get {
				return _askForceFileUnlock ?? (_askForceFileUnlock = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.AskForceFileUnlock.Value"));
			}
		}

		private LocalizableString _defaultReportFileName;
		public LocalizableString DefaultReportFileName {
			get {
				return _defaultReportFileName ?? (_defaultReportFileName = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.DefaultReportFileName.Value"));
			}
		}

		private LocalizableString _notLookupValuesMessage;
		public LocalizableString NotLookupValuesMessage {
			get {
				return _notLookupValuesMessage ?? (_notLookupValuesMessage = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.NotLookupValuesMessage.Value"));
			}
		}

		private LocalizableString _reportWindowCaption;
		public LocalizableString ReportWindowCaption {
			get {
				return _reportWindowCaption ?? (_reportWindowCaption = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.ReportWindowCaption.Value"));
			}
		}

		private LocalizableString _noChangesTrackingInDBMessage;
		public LocalizableString NoChangesTrackingInDBMessage {
			get {
				return _noChangesTrackingInDBMessage ?? (_noChangesTrackingInDBMessage = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.NoChangesTrackingInDBMessage.Value"));
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess10.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess10 };
			FlowElements[StartMessage1234598.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage1234598 };
			FlowElements[SetOpenPageParametersScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { SetOpenPageParametersScriptTask };
			FlowElements[OpenFileHistoryPageUserTask.SchemaElementUId] = new Collection<ProcessFlowElement> { OpenFileHistoryPageUserTask };
			FlowElements[ExclusiveGateway.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway };
			FlowElements[SetMessageParametersScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { SetMessageParametersScriptTask };
			FlowElements[OpenMessageUserTask.SchemaElementUId] = new Collection<ProcessFlowElement> { OpenMessageUserTask };
			FlowElements[EventSubProcess8.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess8 };
			FlowElements[ReportButtonClickScript.SchemaElementUId] = new Collection<ProcessFlowElement> { ReportButtonClickScript };
			FlowElements[OpenLookupUserTask.SchemaElementUId] = new Collection<ProcessFlowElement> { OpenLookupUserTask };
			FlowElements[AfterLookupGridPageClosedScript.SchemaElementUId] = new Collection<ProcessFlowElement> { AfterLookupGridPageClosedScript };
			FlowElements[LookupGridPageClosed.SchemaElementUId] = new Collection<ProcessFlowElement> { LookupGridPageClosed };
			FlowElements[AddReportMenuItemClickStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { AddReportMenuItemClickStartMessage };
			FlowElements[EventSubProcess1.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess1 };
			FlowElements[StartMessage2.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage2 };
			FlowElements[IntermediateThrowMessageEvent2.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowMessageEvent2 };
			FlowElements[ScriptTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask1 };
			FlowElements[StartMessage3.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage3 };
			FlowElements[IntermediateThrowMessageEvent3.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowMessageEvent3 };
			FlowElements[LockUnlockEditButtonsScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { LockUnlockEditButtonsScriptTask };
			FlowElements[EventSubProcessChildDataSourceLoadRows.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcessChildDataSourceLoadRows };
			FlowElements[StartMessageChildDataSourceLoadRows.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessageChildDataSourceLoadRows };
			FlowElements[IntermediateThrowBaseDataSourceLoadRows.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowBaseDataSourceLoadRows };
			FlowElements[ScriptChildDataSourceLoadRows.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptChildDataSourceLoadRows };
			FlowElements[SubProcessPageLoadCompleteChield.SchemaElementUId] = new Collection<ProcessFlowElement> { SubProcessPageLoadCompleteChield };
			FlowElements[PageLoadCompleteChield.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadCompleteChield };
			FlowElements[ScriptPageLoadCompleteChield.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptPageLoadCompleteChield };
			FlowElements[PageLoadCompleteBase.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadCompleteBase };
			FlowElements[SubProcessSaveToFileButton.SchemaElementUId] = new Collection<ProcessFlowElement> { SubProcessSaveToFileButton };
			FlowElements[SaveToFileButtonClick.SchemaElementUId] = new Collection<ProcessFlowElement> { SaveToFileButtonClick };
			FlowElements[ScriptSaveToFileButtonClick.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptSaveToFileButtonClick };
			FlowElements[EventSubProcessInit.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcessInit };
			FlowElements[StartMessageChildInit.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessageChildInit };
			FlowElements[ScriptChildInit.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptChildInit };
			FlowElements[IntermediateThrowBaseInit.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowBaseInit };
			FlowElements[SubProcessOperationsButtonMenu.SchemaElementUId] = new Collection<ProcessFlowElement> { SubProcessOperationsButtonMenu };
			FlowElements[OperationsButtonMenuShow.SchemaElementUId] = new Collection<ProcessFlowElement> { OperationsButtonMenuShow };
			FlowElements[ScriptOperationsButtonMenuShow.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptOperationsButtonMenuShow };
			FlowElements[SubProcessLockMenu.SchemaElementUId] = new Collection<ProcessFlowElement> { SubProcessLockMenu };
			FlowElements[LockMenuItemClick.SchemaElementUId] = new Collection<ProcessFlowElement> { LockMenuItemClick };
			FlowElements[ScriptLockMenuItemClick.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptLockMenuItemClick };
			FlowElements[SubProcessUnlockMenu.SchemaElementUId] = new Collection<ProcessFlowElement> { SubProcessUnlockMenu };
			FlowElements[UnlockMenuItemClick.SchemaElementUId] = new Collection<ProcessFlowElement> { UnlockMenuItemClick };
			FlowElements[ScriptUnlockMenuItemClick.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptUnlockMenuItemClick };
			FlowElements[AskForceFileUnlockUserTask.SchemaElementUId] = new Collection<ProcessFlowElement> { AskForceFileUnlockUserTask };
			FlowElements[ScriptEmpty.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptEmpty };
			FlowElements[ScriptYesUnlockFileMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptYesUnlockFileMessage };
			FlowElements[YesUnlockFileMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { YesUnlockFileMessage };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess10":
						break;
					case "StartMessage1234598":
						e.Context.QueueTasks.Enqueue("SetOpenPageParametersScriptTask");
						break;
					case "SetOpenPageParametersScriptTask":
						e.Context.QueueTasks.Enqueue("ExclusiveGateway");
						break;
					case "OpenFileHistoryPageUserTask":
						break;
					case "ExclusiveGateway":
						if (ConditionalFlow1ExpressionExecute()) {
							e.Context.QueueTasks.Enqueue("OpenFileHistoryPageUserTask");
							break;
						}
						e.Context.QueueTasks.Enqueue("SetMessageParametersScriptTask");
						break;
					case "SetMessageParametersScriptTask":
						e.Context.QueueTasks.Enqueue("OpenMessageUserTask");
						break;
					case "OpenMessageUserTask":
						break;
					case "EventSubProcess8":
						break;
					case "ReportButtonClickScript":
						e.Context.QueueTasks.Enqueue("OpenLookupUserTask");
						break;
					case "OpenLookupUserTask":
						ActivatedEventElements.Add("LookupGridPageClosed");
						break;
					case "AfterLookupGridPageClosedScript":
						break;
					case "LookupGridPageClosed":
						e.Context.QueueTasks.Enqueue("AfterLookupGridPageClosedScript");
						break;
					case "AddReportMenuItemClickStartMessage":
						e.Context.QueueTasks.Enqueue("ReportButtonClickScript");
						break;
					case "EventSubProcess1":
						break;
					case "StartMessage2":
						e.Context.QueueTasks.Enqueue("IntermediateThrowMessageEvent2");
						break;
					case "IntermediateThrowMessageEvent2":
						e.Context.QueueTasks.Enqueue("ScriptTask1");
						break;
					case "ScriptTask1":
						e.Context.QueueTasks.Enqueue("LockUnlockEditButtonsScriptTask");
						break;
					case "StartMessage3":
						e.Context.QueueTasks.Enqueue("IntermediateThrowMessageEvent3");
						break;
					case "IntermediateThrowMessageEvent3":
						e.Context.QueueTasks.Enqueue("ScriptTask1");
						break;
					case "LockUnlockEditButtonsScriptTask":
						break;
					case "EventSubProcessChildDataSourceLoadRows":
						break;
					case "StartMessageChildDataSourceLoadRows":
						e.Context.QueueTasks.Enqueue("IntermediateThrowBaseDataSourceLoadRows");
						break;
					case "IntermediateThrowBaseDataSourceLoadRows":
						e.Context.QueueTasks.Enqueue("ScriptChildDataSourceLoadRows");
						break;
					case "ScriptChildDataSourceLoadRows":
						break;
					case "SubProcessPageLoadCompleteChield":
						break;
					case "PageLoadCompleteChield":
						e.Context.QueueTasks.Enqueue("ScriptPageLoadCompleteChield");
						break;
					case "ScriptPageLoadCompleteChield":
						e.Context.QueueTasks.Enqueue("PageLoadCompleteBase");
						break;
					case "PageLoadCompleteBase":
						break;
					case "SubProcessSaveToFileButton":
						break;
					case "SaveToFileButtonClick":
						e.Context.QueueTasks.Enqueue("ScriptSaveToFileButtonClick");
						break;
					case "ScriptSaveToFileButtonClick":
						break;
					case "EventSubProcessInit":
						break;
					case "StartMessageChildInit":
						e.Context.QueueTasks.Enqueue("ScriptChildInit");
						break;
					case "ScriptChildInit":
						e.Context.QueueTasks.Enqueue("IntermediateThrowBaseInit");
						break;
					case "IntermediateThrowBaseInit":
						break;
					case "SubProcessOperationsButtonMenu":
						break;
					case "OperationsButtonMenuShow":
						e.Context.QueueTasks.Enqueue("ScriptOperationsButtonMenuShow");
						break;
					case "ScriptOperationsButtonMenuShow":
						break;
					case "SubProcessLockMenu":
						break;
					case "LockMenuItemClick":
						e.Context.QueueTasks.Enqueue("ScriptLockMenuItemClick");
						break;
					case "ScriptLockMenuItemClick":
						break;
					case "SubProcessUnlockMenu":
						break;
					case "UnlockMenuItemClick":
						e.Context.QueueTasks.Enqueue("ScriptUnlockMenuItemClick");
						break;
					case "ScriptUnlockMenuItemClick":
						if (SequenceFlow8589ExpressionExecute()) {
						e.Context.QueueTasks.Enqueue("AskForceFileUnlockUserTask");
							break;
						}
						e.Context.QueueTasks.Enqueue("ScriptEmpty");
						break;
					case "AskForceFileUnlockUserTask":
						break;
					case "ScriptEmpty":
						break;
					case "ScriptYesUnlockFileMessage":
						break;
					case "YesUnlockFileMessage":
						e.Context.QueueTasks.Enqueue("ScriptYesUnlockFileMessage");
						break;
			}
			ProcessQueue(e.Context);
		}

		private bool SequenceFlow8589ExpressionExecute() {
			return Convert.ToBoolean(DoProposeForceFileUnlock);
		}

		private bool ConditionalFlow1ExpressionExecute() {
			return Convert.ToBoolean(IsTrackChanges);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("StartMessage1234598");
			ActivatedEventElements.Add("AddReportMenuItemClickStartMessage");
			ActivatedEventElements.Add("StartMessage2");
			ActivatedEventElements.Add("StartMessage3");
			ActivatedEventElements.Add("StartMessageChildDataSourceLoadRows");
			ActivatedEventElements.Add("PageLoadCompleteChield");
			ActivatedEventElements.Add("SaveToFileButtonClick");
			ActivatedEventElements.Add("StartMessageChildInit");
			ActivatedEventElements.Add("OperationsButtonMenuShow");
			ActivatedEventElements.Add("LockMenuItemClick");
			ActivatedEventElements.Add("UnlockMenuItemClick");
			ActivatedEventElements.Add("YesUnlockFileMessage");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "EventSubProcess10":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage1234598":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage1234598";
					result = StartMessage1234598.Execute(context);
					break;
				case "SetOpenPageParametersScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "SetOpenPageParametersScriptTask";
					result = SetOpenPageParametersScriptTask.Execute(context, SetOpenPageParametersScriptTaskExecute);
					break;
				case "OpenFileHistoryPageUserTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "OpenFileHistoryPageUserTask";
					result = OpenFileHistoryPageUserTask.Execute(context);
					break;
				case "ExclusiveGateway":
					context.QueueTasks.Dequeue();
					context.SenderName = "ExclusiveGateway";
					result = ExclusiveGateway.Execute(context);
					break;
				case "SetMessageParametersScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "SetMessageParametersScriptTask";
					result = SetMessageParametersScriptTask.Execute(context, SetMessageParametersScriptTaskExecute);
					break;
				case "OpenMessageUserTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "OpenMessageUserTask";
					result = OpenMessageUserTask.Execute(context);
					break;
				case "EventSubProcess8":
					context.QueueTasks.Dequeue();
					break;
				case "ReportButtonClickScript":
					context.QueueTasks.Dequeue();
					context.SenderName = "ReportButtonClickScript";
					result = ReportButtonClickScript.Execute(context, ReportButtonClickScriptExecute);
					break;
				case "OpenLookupUserTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "OpenLookupUserTask";
					result = OpenLookupUserTask.Execute(context);
					break;
				case "AfterLookupGridPageClosedScript":
					context.QueueTasks.Dequeue();
					context.SenderName = "AfterLookupGridPageClosedScript";
					result = AfterLookupGridPageClosedScript.Execute(context, AfterLookupGridPageClosedScriptExecute);
					break;
				case "LookupGridPageClosed":
					context.QueueTasks.Dequeue();
					context.SenderName = "LookupGridPageClosed";
					result = LookupGridPageClosed.Execute(context);
					break;
				case "AddReportMenuItemClickStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "AddReportMenuItemClickStartMessage";
					result = AddReportMenuItemClickStartMessage.Execute(context);
					break;
				case "EventSubProcess1":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage2":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage2";
					result = StartMessage2.Execute(context);
					break;
				case "IntermediateThrowMessageEvent2":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "DataSourceActiveRowChanged");
					result = IntermediateThrowMessageEvent2.Execute(context);
					break;
				case "ScriptTask1":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask1";
					result = ScriptTask1.Execute(context, ScriptTask1Execute);
					break;
				case "StartMessage3":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage3";
					result = StartMessage3.Execute(context);
					break;
				case "IntermediateThrowMessageEvent3":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "DataSourceLoadRowsResponseRegistered");
					result = IntermediateThrowMessageEvent3.Execute(context);
					break;
				case "LockUnlockEditButtonsScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "LockUnlockEditButtonsScriptTask";
					result = LockUnlockEditButtonsScriptTask.Execute(context, LockUnlockEditButtonsScriptTaskExecute);
					break;
				case "EventSubProcessChildDataSourceLoadRows":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessageChildDataSourceLoadRows":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessageChildDataSourceLoadRows";
					result = StartMessageChildDataSourceLoadRows.Execute(context);
					break;
				case "IntermediateThrowBaseDataSourceLoadRows":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "DataSourceLoadRows");
					result = IntermediateThrowBaseDataSourceLoadRows.Execute(context);
					break;
				case "ScriptChildDataSourceLoadRows":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptChildDataSourceLoadRows";
					result = ScriptChildDataSourceLoadRows.Execute(context, ScriptChildDataSourceLoadRowsExecute);
					break;
				case "SubProcessPageLoadCompleteChield":
					context.QueueTasks.Dequeue();
					break;
				case "PageLoadCompleteChield":
					context.QueueTasks.Dequeue();
					context.SenderName = "PageLoadCompleteChield";
					result = PageLoadCompleteChield.Execute(context);
					break;
				case "ScriptPageLoadCompleteChield":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptPageLoadCompleteChield";
					result = ScriptPageLoadCompleteChield.Execute(context, ScriptPageLoadCompleteChieldExecute);
					break;
				case "PageLoadCompleteBase":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "PageLoadComplete");
					result = PageLoadCompleteBase.Execute(context);
					break;
				case "SubProcessSaveToFileButton":
					context.QueueTasks.Dequeue();
					break;
				case "SaveToFileButtonClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "SaveToFileButtonClick";
					result = SaveToFileButtonClick.Execute(context);
					break;
				case "ScriptSaveToFileButtonClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptSaveToFileButtonClick";
					result = ScriptSaveToFileButtonClick.Execute(context, ScriptSaveToFileButtonClickExecute);
					break;
				case "EventSubProcessInit":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessageChildInit":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessageChildInit";
					result = StartMessageChildInit.Execute(context);
					break;
				case "ScriptChildInit":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptChildInit";
					result = ScriptChildInit.Execute(context, ScriptChildInitExecute);
					break;
				case "IntermediateThrowBaseInit":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "Init");
					result = IntermediateThrowBaseInit.Execute(context);
					break;
				case "SubProcessOperationsButtonMenu":
					context.QueueTasks.Dequeue();
					break;
				case "OperationsButtonMenuShow":
					context.QueueTasks.Dequeue();
					context.SenderName = "OperationsButtonMenuShow";
					result = OperationsButtonMenuShow.Execute(context);
					break;
				case "ScriptOperationsButtonMenuShow":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptOperationsButtonMenuShow";
					result = ScriptOperationsButtonMenuShow.Execute(context, ScriptOperationsButtonMenuShowExecute);
					break;
				case "SubProcessLockMenu":
					context.QueueTasks.Dequeue();
					break;
				case "LockMenuItemClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "LockMenuItemClick";
					result = LockMenuItemClick.Execute(context);
					break;
				case "ScriptLockMenuItemClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptLockMenuItemClick";
					result = ScriptLockMenuItemClick.Execute(context, ScriptLockMenuItemClickExecute);
					break;
				case "SubProcessUnlockMenu":
					context.QueueTasks.Dequeue();
					break;
				case "UnlockMenuItemClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "UnlockMenuItemClick";
					result = UnlockMenuItemClick.Execute(context);
					break;
				case "ScriptUnlockMenuItemClick":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptUnlockMenuItemClick";
					result = ScriptUnlockMenuItemClick.Execute(context, ScriptUnlockMenuItemClickExecute);
					break;
				case "AskForceFileUnlockUserTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "AskForceFileUnlockUserTask";
					result = AskForceFileUnlockUserTask.Execute(context);
					break;
				case "ScriptEmpty":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptEmpty";
					result = ScriptEmpty.Execute(context, ScriptEmptyExecute);
					break;
				case "ScriptYesUnlockFileMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptYesUnlockFileMessage";
					result = ScriptYesUnlockFileMessage.Execute(context, ScriptYesUnlockFileMessageExecute);
					break;
				case "YesUnlockFileMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "YesUnlockFileMessage";
					result = YesUnlockFileMessage.Execute(context);
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
				case "IsTrackChanges":
					IsTrackChanges = reader.GetValue<System.Boolean>();
				break;
				case "ReportDictionary":
					ReportDictionary = reader.GetSerializableObjectValue();
				break;
				case "LockedById":
					LockedById = reader.GetValue<System.Guid>();
				break;
				case "DoProposeForceFileUnlock":
					DoProposeForceFileUnlock = reader.GetValue<System.Boolean>();
				break;
				case "FileTypeId":
					FileTypeId = reader.GetValue<System.Guid>();
				break;
			}
		}

		#endregion

		#region Methods: Public

		public virtual bool SetOpenPageParametersScriptTaskExecute(ProcessExecutingContext context) {
			OpenFileHistoryPageUserTask.PageUId = Terrasoft.WebApp.FileConsts.FileVersionsGridPageUId;
			var recordId = Page.DataSource.ActiveRowPrimaryColumnValue;
			var recordType = Guid.Empty;
			if(recordId != Guid.Empty) {
				var recordEntitySchema = UserConnection.EntitySchemaManager.GetInstanceByName(Page.DataSource.Schema.Name);
				var recordEntity = recordEntitySchema.CreateEntity(UserConnection);
				var fetchResult = recordEntity.FetchFromDB("Id", recordId, new List<string> {"Type"}); 
				if(fetchResult) {
					recordType = recordEntity.GetTypedColumnValue<Guid>("TypeId");
				}
			}
			var fileSchema = Page.DataSource.Schema;
			var fileLogSchema = UserConnection.EntitySchemaManager.FindInstanceByUId(fileSchema.UId).GetTrackChangesInDBSchema();
			IsTrackChanges = fileLogSchema != null &&
							 fileSchema.GetSchemaColumnByPath("Data").IsTrackChangesInDB &&
							 fileSchema.GetSchemaColumnByPath("Version").IsTrackChangesInDB &&
							 fileSchema.GetSchemaColumnByPath("Name").IsTrackChangesInDB;
			var parameters = new Dictionary<string, string>();
			if(recordId != null) {
				parameters.Add("recordId", recordId.ToString());
				parameters.Add("recordType", recordType.ToString());
				parameters.Add("recordSchemaUId", Page.DataSource.Schema.UId.ToString());
			}
			OpenFileHistoryPageUserTask.PageParameters = parameters;
			return true;
		}

		public virtual bool SetMessageParametersScriptTaskExecute(ProcessExecutingContext context) {
			OpenMessageUserTask.Page = Page;
			var schemaCaption = Page.DataSource.Schema.Caption;
			OpenMessageUserTask.MessageText = string.Format(NoChangesTrackingInDBMessage.Value, schemaCaption);
			OpenMessageUserTask.Icon = "WARNING";
			OpenMessageUserTask.Buttons = "OK";
			return true;
		}

		public virtual bool ReportButtonClickScriptExecute(ProcessExecutingContext context) {
			var activity = UserConnection.EntitySchemaManager.GetInstanceByName("Activity").CreateEntity(UserConnection);
			if (activity.FetchFromDB(SelectedNodePrimaryColumnValue)) {
				var columns = activity.Schema.Columns;
				OpenLookupUserTask.ProcessKey = InstanceUId;
				var pageParameters = new Dictionary<string, object>();
				pageParameters.Add("schemaName", "SysModuleReport");
				pageParameters.Add("showColumns", new List<string>(){"SysModule", "Caption"});
				pageParameters.Add("useHierarchy", false);
				pageParameters.Add("logicalOperation", LogicalOperation.Or);
				pageParameters.Add("lookupGridPageCaption", ReportWindowCaption.Value);
				Collection<Dictionary<string, object>> filters = new Collection<Dictionary<string, object>>();
				List<string> listColumn = new List<string>();
				foreach(var column in columns) {
					if(Terrasoft.Configuration.ActivityConsts.listColumnName.Contains(column.Name) &&
						activity.GetColumnValue(column)!= null) {
							listColumn.Add(column.ReferenceSchemaUId.ToString());
					}
				}
				OpenLookupUserTask.PageParameters = pageParameters;
				if(listColumn.Count==0) {
					MessagePanel messagePanel = ControlUtilities.FindControl(Page.AspPage.Controls[0], 
						"BaseMessagePanel", true) as MessagePanel;
					if (messagePanel != null) {
						messagePanel.Remove("NotLookupValuesMessage");
					}
					messagePanel.AddMessage("NotLookupValuesMessage",
						Warning, NotLookupValuesMessage, MessageType.Information);
					return false;
				}
				filters.Add(new Dictionary<string, object> {
								{"comparisonType", FilterComparisonType.Equal},
								{"leftExpressionColumnPath", "SysModule.SysModuleEntity.SysEntitySchemaUId"},
								{"useDisplayValue", false},
								{"rightExpressionParameterValues", (object[])listColumn.ToArray()}}
							);
				if(filters.Count > 0) {
					pageParameters.Add("LookupFilters", filters);	
				}
			}
			return true;
		}

		public virtual bool AfterLookupGridPageClosedScriptExecute(ProcessExecutingContext context) {
			var values = (Dictionary <string, object>)OpenLookupUserTask.GetSelectedValues(UserConnection);
			if (values.Count.Equals(0)) {
				return true;
			}
			Guid entitySchemaUId = Guid.Empty;
			Guid columnValue = Guid.Empty;
			string columnDisplayValue = string.Empty;
			
			Guid reportUId = new Guid(values.First().Key);
			string reportCaption = ((Dictionary <string, object>)values.First().Value).FirstOrDefault(x => x.Key == "Caption").Value.ToString();
			
			string reportName = GetReportNameByUId(reportUId);
			string columnName  = GetColumnNameBySysModuleReportId(reportUId);
			
			var activity = UserConnection.EntitySchemaManager.GetInstanceByName("Activity").CreateEntity(UserConnection);
			//if (activity.FetchFromDB(SelectedNodePrimaryColumnValue) && columnUId != Guid.Empty) {
			//	EntitySchemaColumn curentESC = activity.Schema.Columns.FindByUId(columnUId);
			if (activity.FetchFromDB(SelectedNodePrimaryColumnValue) && columnName != string.Empty) {
				EntitySchemaColumn curentESC = activity.Schema.Columns.FindByName(columnName);
				entitySchemaUId = curentESC.ReferenceSchema.UId;
				columnValue = activity.GetTypedColumnValue<Guid>(curentESC);
				columnDisplayValue = activity.GetColumnDisplayValue(curentESC); 
			} else {
				return false;	
			}
			
			var manager = new ReportSchemaManager();
			var schema = new ReportSchema(manager);
			schema.Name = reportName;
			schema.UId = reportUId;
			
			using (var reportStream = new MemoryStream()) {
				var dataSource = new EntityDataSource();
				dataSource.SchemaUId = entitySchemaUId;
				Terrasoft.UI.WebControls.Utilities.EntityDataSourceUtilities.InitializeAutoDefStructure(dataSource);
				var jsonConverter = new DataSourceFiltersJsonConverter(UserConnection, dataSource){
											PreventRegisteringClientScript = true
										};
				
				dataSource.CurrentStructure.Filters.Add(dataSource.CreateFilterWithParameters(
												FilterComparisonType.Equal,
												"Id",
												columnValue));
			
				var filters = Json.Serialize(dataSource.CurrentStructure.Filters, jsonConverter);
			
				var report = schema.CreateReport(UserConnection);
				report.Parameters["Filters"].Value = filters;
				report.ExportToPdf(reportStream);
				
				var activityFileSchema = UserConnection.EntitySchemaManager.GetInstanceByName("ActivityFile");
				var activityFile = activityFileSchema.CreateEntity(UserConnection);
				activityFile.SetDefColumnValues();
				activityFile.SetColumnValue("ActivityId", SelectedNodePrimaryColumnValue);
				var fileName = columnDisplayValue + " " + reportCaption;
				activityFile.SetColumnValue(
					"Name", 
					fileName.Equals(string.Empty) ? 
					string.Format("{0}.pdf", DefaultReportFileName.Value) : 
					string.Format("{0}.pdf", fileName)
				);
				activityFile.SetColumnValue("TypeId", "529BC2F8-0EE0-DF11-971B-001D60E938C6"); //File
				activityFile.SetColumnValue("Size", reportStream.Length); 
				activityFile.SetStreamValue("Data", reportStream);
				activityFile.Save();
				Page.TreeGrid.Clear();
				Page.DataSource.LoadRows();	
			}
			return true;
		}

		public virtual bool ScriptTask1Execute(ProcessExecutingContext context) {
			EnableDisableSaveToFileButton();
			return true;
		}

		public virtual bool LockUnlockEditButtonsScriptTaskExecute(ProcessExecutingContext context) {
			LockUnlockEditButtons();
			return true;
		}

		public virtual bool ScriptChildDataSourceLoadRowsExecute(ProcessExecutingContext context) {
			if (Page.DataSource.Rows.Count > 0) {
				var currentRow = Page.DataSource.Rows[0];
				var fileTypeId = Terrasoft.WebApp.FileConsts.FileTypeUId;
				var typeId = currentRow.GetTypedColumnValue<Guid>("TypeId");
				bool isFileType = (typeId.Equals(fileTypeId));
				Page.SaveToFileButton.Enabled = isFileType;
				return Page.SaveToFileButton.Enabled;
			} else {
				Page.SaveToFileButton.Enabled = false;
				return Page.SaveToFileButton.Enabled;
			}
		}

		public virtual bool ScriptPageLoadCompleteChieldExecute(ProcessExecutingContext context) {
			EditPageUId = new Guid("0CDB5A1A-1587-4C1B-8CE8-83F61167AC6D");
			FileTypeId = new Guid("539BC2F8-0EE0-DF11-971B-001D60E938C6");
			string formatString = "{0}.on('click', function(el) {{ {1} }}, this)";
			var script = GetRegisterAddPageScript(EditPageUId, SysModuleEditId, Guid.Empty);	
			if (!string.IsNullOrEmpty(script)) {
				Page.AddScript(string.Format(formatString, Page.AddLinkMenuItem.ClientID, script));
			}
			FileTypeId = new Guid("529BC2F8-0EE0-DF11-971B-001D60E938C6");
			script = GetRegisterAddPageScript(EditPageUId, SysModuleEditId, Guid.Empty);	
			if (!string.IsNullOrEmpty(script)) {
				Page.AddScript(string.Format(formatString, Page.AddFileMenuItem.ClientID, script));
			}
			
			if(UserConnection.IProcessEngine.FindProcessByUId(ListenerPageProcessUId).Schema.Name == "ActivitiesModulePage" ||
					UserConnection.IProcessEngine.FindProcessByUId(ListenerPageProcessUId).Schema.Name == "EmailEditPage") {
				Page.AddButton.Menu[2].Hidden = false;
				Page.AddButton.AjaxEvents.Click.IsProcessEventHandler = true;
				Page.AddButton.AjaxEvents.Click.ShowLoadMask = true;
				Page.AddButton.AjaxEvents.Click.ShowOpaqueMask = true;
			
			}
			
			return true;
		}

		public virtual bool ScriptSaveToFileButtonClickExecute(ProcessExecutingContext context) {
			var selectedNodes = Page.TreeGrid.SelectedNodes;
			if (selectedNodes.Count < 1) {
				return true;
			}
			Page.DataSource.LoadRow(new Guid(selectedNodes[0].Values["Id"].ToString()));
			if (Page.DataSource.Rows.Count < 1) {
				return true;
			}
			var currentRow = Page.DataSource.Rows[0];
			var data = currentRow.GetColumnValue("Data") as byte[];
			var Response = Page.Response;
			
			String fileName = (String)currentRow.GetColumnValue("Name");
			TSConfiguration.PageResponse.Write(Response, data, fileName, TSConfiguration.ContentType.StreamType);
			return true;
		}

		public virtual bool ScriptChildInitExecute(ProcessExecutingContext context) {
			SynchronizeDataSourceStructure = true;
			Page.SaveToFileButton.AjaxEvents.Click.IsUpload = true;
			return true;
		}

		public virtual bool ScriptOperationsButtonMenuShowExecute(ProcessExecutingContext context) {
			var selectedNodes = Page.TreeGrid.SelectedNodes;
			bool canLock = false;
			bool canUnlock = false;
			if (selectedNodes.Count < 1) {
				canLock = false;
				canUnlock = false;
			} else {
				var selectedId = new Guid(selectedNodes[0].Values["Id"].ToString());
				var currentRow = Page.DataSource.Schema.CreateEntity(UserConnection);
				if (currentRow.FetchFromDB(selectedId)) {
					LockedById = currentRow.GetTypedColumnValue<Guid>("LockedById");
					canLock = (LockedById.Equals(Guid.Empty));
					canUnlock = !LockedById.Equals(Guid.Empty) && (LockedById.Equals(UserConnection.CurrentUser.ContactId) 
						|| UserConnection.DBSecurityEngine.GetCanExecuteOperation("CanForceUnlockFile"));
				}
			}
			Page.LockMenuItem.Enabled = canLock;
			Page.UnlockMenuItem.Enabled = canUnlock;
			return true;
		}

		public virtual bool ScriptLockMenuItemClickExecute(ProcessExecutingContext context) {
			SetLockFieldsValues(true);
			return true;
		}

		public virtual bool ScriptUnlockMenuItemClickExecute(ProcessExecutingContext context) {
			if (!LockedById.Equals(UserConnection.CurrentUser.ContactId) && UserConnection.DBSecurityEngine.GetCanExecuteOperation("CanForceUnlockFile")) {
				DoProposeForceFileUnlock = true;
				AskForceFileUnlockUserTask.Page = Page;
				AskForceFileUnlockUserTask.MessageText = AskForceFileUnlock;
				AskForceFileUnlockUserTask.Icon = "QUESTION";
				AskForceFileUnlockUserTask.Buttons = "YESNO";
				AskForceFileUnlockUserTask.ResponseMessages = new Dictionary<string, string>{{"yes", "YesUnlockFile"}, {"no", "NoUnlockFile"}};
			} else {
				SetLockFieldsValues(false);
			}
			return true;
		}

		public virtual bool ScriptEmptyExecute(ProcessExecutingContext context) {
			return true;
		}

		public virtual bool ScriptYesUnlockFileMessageExecute(ProcessExecutingContext context) {
			SetLockFieldsValues(false);
			return true;
		}

		public override System.Collections.Generic.List<string> GetButtons() {
			var buttons = base.GetButtons();
			buttons.Add(Page.OperationsButton.Name);
			buttons.Add(Page.SaveToFileButton.Name);
			buttons.Add(Page.SaveChangesButton.Name);
			return buttons;
		}

		public override void SetAdditionalDataSourceProperties() {
			var currentStructure = Page.DataSource.CurrentStructure;
			List<string> columnNames = new List<string>{ "Name", "CreatedBy", "CreatedOn", "Version", "Size" };
			foreach (var column in currentStructure.Columns) {
				column.IsVisible = columnNames.Contains(column.Name);
			}
			foreach (var name in columnNames) {
				var currentColumn = currentStructure.Columns.GetByName(name);
				currentStructure.Columns.Move(currentStructure.Columns.IndexOf(currentColumn), columnNames.IndexOf(name));
			}
			return;
		}

		public override bool GetIsContextHelpButtonHidden() {
			return false;
		}

		public override void ModifyAddPageParameters(Dictionary<string, object> openPageParameters, Dictionary<string, string> queryStringParameters) {
			queryStringParameters["typeId"] = Json.Serialize(FileTypeId);
			var typeColumnUId = Page.DataSource.Schema.Columns.GetByName("Type").UId;
			queryStringParameters["typeColumnUId"] = Json.Serialize(typeColumnUId);
		}

		public virtual bool SetLockFieldsValues(bool NeedLock) {
			var selectedNodes = Page.TreeGrid.SelectedNodes;
			if (selectedNodes.Count < 1) {
				return true;
			}
			var selectedId = new Guid(selectedNodes[0].Values["Id"].ToString());
			var currentRow = Page.DataSource.Schema.CreateEntity(UserConnection);
			if (!currentRow.FetchFromDB(selectedId)) {
				return true;
			}
			Nullable<Guid> newLockedById = null;
			Nullable<DateTime> newLockedOn = null;
			Guid lockedById = (currentRow.GetColumnValue("LockedById") == null) ? Guid.Empty : new Guid(currentRow.GetColumnValue("LockedById").ToString());
			if (NeedLock) {
				if (!lockedById.Equals(Guid.Empty)) {
					return true;
				}
			} else {
				bool canUnlock = (!lockedById.Equals(Guid.Empty)) && (lockedById.Equals(UserConnection.CurrentUser.ContactId)
					|| UserConnection.DBSecurityEngine.GetCanExecuteOperation("CanForceUnlockFile"));
				if (!canUnlock) {
					return true;
				}  
			}
			if (NeedLock) {
				newLockedById = UserConnection.CurrentUser.ContactId;
				newLockedOn = DateTime.Now;
			}
			currentRow.SetColumnValue("LockedById", newLockedById);
			currentRow.SetColumnValue("LockedOn", newLockedOn);
			currentRow.Save();
			Page.DataSource.LoadRow(currentRow.PrimaryColumnValue);
			//Page.TreeGrid.RefreshSelectedNode();
			Page.LockMenuItem.Enabled = false;
			Page.UnlockMenuItem.Enabled = false;
			return true;
		}

		public virtual bool EnableDisableSaveToFileButton() {
			if (Page.DataSource.ActiveRowPrimaryColumnValue != Guid.Empty) {
				var entitySchemaManager = UserConnection.EntitySchemaManager;
				var entitySchema = Page.DataSource.Schema;
				var entitySchemaQuery = new EntitySchemaQuery(entitySchemaManager, entitySchema.Name);
				var typeColumn = entitySchemaQuery.AddColumn("Type");
				entitySchemaQuery.Filters.Add(entitySchemaQuery.CreateFilterWithParameters(
					FilterComparisonType.Equal, entitySchema.PrimaryColumn.Name, Page.DataSource.ActiveRowPrimaryColumnValue));
			
				var entityCollection = entitySchemaQuery.GetEntityCollection(UserConnection);
				var typeId = Guid.Empty;
				if (entityCollection.Count > 0) {
					typeId = entityCollection[0].GetTypedColumnValue<Guid>("TypeId");
				}
				var fileTypeId = new Guid("529BC2F8-0EE0-DF11-971B-001D60E938C6");
				Page.SaveToFileButton.Enabled = typeId.Equals(fileTypeId);
				return Page.SaveToFileButton.Enabled;
			} else {
				Page.SaveToFileButton.Enabled = false;
				return Page.SaveToFileButton.Enabled;
			}
		}

		public virtual string GetColumnNameBySysModuleReportId(Guid sysModuleReportId) {
			/*var sysModuleReport = UserConnection.EntitySchemaManager.GetInstanceByName("SysModuleReport").CreateEntity(UserConnection);
			if (sysModuleReport.FetchFromDB("Id", sysModuleReportId, new Collection<string> {
								"SysModule"})) {
				var sysModuleId = sysModuleReport.GetTypedColumnValue<Guid>("SysModuleId");		
				if(((Dictionary<Guid, Guid>)ReportDictionary).ContainsKey(sysModuleId)) {
					return ((Dictionary<Guid, Guid>)ReportDictionary)[sysModuleId];
				}
			}
			return Guid.Empty;
			*/					
								
			var entitySchemaManager = UserConnection.EntitySchemaManager;
			var reportES = entitySchemaManager.GetInstanceByName("SysModuleReport"); 
			var reportESQ = new EntitySchemaQuery(entitySchemaManager, reportES.Name);
			var reportIdColumn = reportESQ.AddColumn(reportES.GetPrimaryColumnName());
			var moduleColumn = reportESQ.AddColumn("SysModule");
			var entitySchemaColumnName = reportESQ.AddColumn("SysModule.SysModuleEntity.SysEntitySchemaUId").Name;
			reportESQ.Filters.Clear();
			reportESQ.Filters.Add(
			reportESQ.CreateFilterWithParameters(
				FilterComparisonType.Equal,
				"Id",
				sysModuleReportId));
			
			var reportCollection = reportESQ.GetEntityCollection(UserConnection);
			if(reportCollection.Count > 0) {
				var reportEntity  = reportCollection[0];
				var regionColumnName = reportEntity.Schema.Columns.GetByName(entitySchemaColumnName);
				var d= reportEntity.GetTypedColumnValue<object>(regionColumnName);
				return entitySchemaManager.GetInstanceByUId(new Guid(d.ToString())).Name;
			}
			return string.Empty;
		}

		public virtual string GetReportNameByUId(Guid reportUId) {
			var report = UserConnection.EntitySchemaManager.GetInstanceByName("SysModuleReport").CreateEntity(UserConnection);
			if (report.FetchFromDB("Id", reportUId, new Collection<string> {
								"SysReportSchemaUId",
								"SysModule.SysModuleEntity.SysEntitySchemaUId"})) {
				Guid sysReportSchemaUId = report.GetTypedColumnValue<Guid>("SysReportSchemaUId");
				var reportSchemaManager = UserConnection.GetReportSchemaManager();
				//var d= reportSchemaManager.FindItemByUId(sysReportSchemaUId);
				return reportSchemaManager.GetInstanceByUId(sysReportSchemaUId).Name;
			}
			return null;
		}

		public virtual void LockUnlockEditButtons() {
			var activeRowId = Page.DataSource.ActiveRowPrimaryColumnValue;
			if (activeRowId != Guid.Empty) {	
				var entitySchemaManager = UserConnection.EntitySchemaManager;
				var entitySchema = Page.DataSource.Schema;
				var entitySchemaQuery = new EntitySchemaQuery(entitySchemaManager, entitySchema.Name);
				var lockedByIdColumn = entitySchemaQuery.AddColumn("LockedBy");
				var entity = entitySchemaQuery.GetEntity(UserConnection, activeRowId);
				var lockedByIdSchemaColumn = entity.Schema.Columns.GetByName(lockedByIdColumn.Name);
				var lockedById = entity.GetTypedColumnValue<Guid>(lockedByIdSchemaColumn.ColumnValueName);
				if (lockedById != Guid.Empty && lockedById != UserConnection.CurrentUser.ContactId) {
					Page.EditButton.SuspendAjaxEvents();
					Page.EditButton.Enabled = false;
					Page.EditButton.ResumeAjaxEvents();
					Page.DeleteButton.SuspendAjaxEvents();
					Page.DeleteButton.Enabled = false;
					Page.DeleteButton.ResumeAjaxEvents();
				} else {
					Page.EditButton.SuspendAjaxEvents();
					Page.EditButton.Enabled = true;
					Page.EditButton.ResumeAjaxEvents();
					Page.DeleteButton.SuspendAjaxEvents();
					Page.DeleteButton.Enabled = true;
					Page.DeleteButton.ResumeAjaxEvents();
				}
			}
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "ShowHistoryMenuItemClick":
							if (ActivatedEventElements.Contains("StartMessage1234598")) {
							context.QueueTasks.Enqueue("StartMessage1234598");
						}
						break;
					case "LookupGridPageClosed":
					if (ActivatedEventElements.Remove("LookupGridPageClosed")) {
						context.QueueTasks.Enqueue("LookupGridPageClosed");
					}
					break;
					case "AddReportMenuItemClick":
							if (ActivatedEventElements.Contains("AddReportMenuItemClickStartMessage")) {
							context.QueueTasks.Enqueue("AddReportMenuItemClickStartMessage");
						}
						break;
					case "DataSourceActiveRowChanged":
							if (ActivatedEventElements.Contains("StartMessage2")) {
							context.QueueTasks.Enqueue("StartMessage2");
							ProcessQueue(context);
							return;
						}
						break;
					case "DataSourceLoadRowsResponseRegistered":
							if (ActivatedEventElements.Contains("StartMessage3")) {
							context.QueueTasks.Enqueue("StartMessage3");
							ProcessQueue(context);
							return;
						}
						break;
					case "DataSourceLoadRows":
							if (ActivatedEventElements.Contains("StartMessageChildDataSourceLoadRows")) {
							context.QueueTasks.Enqueue("StartMessageChildDataSourceLoadRows");
						}
						break;
					case "PageLoadComplete":
							if (ActivatedEventElements.Contains("PageLoadCompleteChield")) {
							context.QueueTasks.Enqueue("PageLoadCompleteChield");
							ProcessQueue(context);
							return;
						}
						break;
					case "SaveToFileButtonClick":
							if (ActivatedEventElements.Contains("SaveToFileButtonClick")) {
							context.QueueTasks.Enqueue("SaveToFileButtonClick");
						}
						break;
					case "Init":
							if (ActivatedEventElements.Contains("StartMessageChildInit")) {
							context.QueueTasks.Enqueue("StartMessageChildInit");
							ProcessQueue(context);
							return;
						}
						break;
					case "OperationsButtonMenuShow":
							if (ActivatedEventElements.Contains("OperationsButtonMenuShow")) {
							context.QueueTasks.Enqueue("OperationsButtonMenuShow");
						}
						break;
					case "LockMenuItemClick":
							if (ActivatedEventElements.Contains("LockMenuItemClick")) {
							context.QueueTasks.Enqueue("LockMenuItemClick");
						}
						break;
					case "UnlockMenuItemClick":
							if (ActivatedEventElements.Contains("UnlockMenuItemClick")) {
							context.QueueTasks.Enqueue("UnlockMenuItemClick");
						}
						break;
					case "YesUnlockFile":
							if (ActivatedEventElements.Contains("YesUnlockFileMessage")) {
							context.QueueTasks.Enqueue("YesUnlockFileMessage");
						}
						break;
			}
			base.ThrowEvent(context, message);
			ProcessQueue(context);
		}

		public override void WritePropertiesData(DataWriter writer, bool writeFlowElements = true) {
			base.WritePropertiesData(writer, writeFlowElements);
			if (!HasMapping("IsTrackChanges") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("IsTrackChanges", IsTrackChanges, false);
			}
			if (ReportDictionary != null) {
				if (ReportDictionary.GetType().IsSerializable ||
					ReportDictionary.GetType().GetInterface("ISerializable") != null) {
					writer.WriteSerializableObjectValue("ReportDictionary", ReportDictionary, null);
				}
			}
			if (!HasMapping("LockedById") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("LockedById", LockedById, Guid.Empty);
			}
			if (!HasMapping("DoProposeForceFileUnlock") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("DoProposeForceFileUnlock", DoProposeForceFileUnlock, false);
			}
			if (!HasMapping("FileTypeId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("FileTypeId", FileTypeId, Guid.Empty);
			}
		}

		public override object CloneShallow() {
			return base.CloneShallow();
		}

		#endregion

	}

	#endregion

	#region Class: BaseFileEntryGridPageEventsProcess

	/// <exclude/>
	public class BaseFileEntryGridPageEventsProcess : BaseFileEntryGridPageEventsProcess<Terrasoft.WebApp.BaseFileEntryGridPageSchemaUserControl>
	{

		public BaseFileEntryGridPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: BaseFileEntryGridPageSchemaUserControl

	/// <exclude/>
	public partial class BaseFileEntryGridPageSchemaUserControl : Terrasoft.WebApp.BaseGridPageSchemaUserControl
	{

		#region Properties: Public

		public Terrasoft.UI.WebControls.Controls.MenuItem AddFileMenuItem {
			get {
				return (Terrasoft.UI.WebControls.Controls.MenuItem)PageContainer.FindPageControl("AddFileMenuItem", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.MenuItem AddLinkMenuItem {
			get {
				return (Terrasoft.UI.WebControls.Controls.MenuItem)PageContainer.FindPageControl("AddLinkMenuItem", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.MenuItem AddReportMenuItem {
			get {
				return (Terrasoft.UI.WebControls.Controls.MenuItem)PageContainer.FindPageControl("AddReportMenuItem", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Spacer EditSpacer {
			get {
				return (Terrasoft.UI.WebControls.Controls.Spacer)PageContainer.FindPageControl("EditSpacer", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Button SaveToFileButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.Button)PageContainer.FindPageControl("SaveToFileButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Button OperationsButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.Button)PageContainer.FindPageControl("OperationsButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.MenuItem LockMenuItem {
			get {
				return (Terrasoft.UI.WebControls.Controls.MenuItem)PageContainer.FindPageControl("LockMenuItem", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.MenuItem UnlockMenuItem {
			get {
				return (Terrasoft.UI.WebControls.Controls.MenuItem)PageContainer.FindPageControl("UnlockMenuItem", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.MenuItem ShowHistoryMenuItem {
			get {
				return (Terrasoft.UI.WebControls.Controls.MenuItem)PageContainer.FindPageControl("ShowHistoryMenuItem", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Button SaveChangesButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.Button)PageContainer.FindPageControl("SaveChangesButton", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.Button ReportButton {
			get {
				return (Terrasoft.UI.WebControls.Controls.Button)PageContainer.FindPageControl("ReportButton", true);
			}
		}

		#endregion

		#region Methods: Protected

		protected override void SubscribeOnControlEvents() {
			base.SubscribeOnControlEvents();
			AddReportMenuItem.AjaxEvents.Click.Event += AddReportMenuItemClick;
			SaveToFileButton.AjaxEvents.Click.Event += SaveToFileButtonClick;
			OperationsButton.AjaxEvents.MenuShow.Event += OperationsButtonMenuShow;
			LockMenuItem.AjaxEvents.Click.Event += LockMenuItemClick;
			UnlockMenuItem.AjaxEvents.Click.Event += UnlockMenuItemClick;
			ShowHistoryMenuItem.AjaxEvents.Click.Event += ShowHistoryMenuItemClick;
		}

		protected override void UnsubscribeOnControlEvents() {
			base.UnsubscribeOnControlEvents();
			AddReportMenuItem.AjaxEvents.Click.Event -= AddReportMenuItemClick;
			SaveToFileButton.AjaxEvents.Click.Event -= SaveToFileButtonClick;
			OperationsButton.AjaxEvents.MenuShow.Event -= OperationsButtonMenuShow;
			LockMenuItem.AjaxEvents.Click.Event -= LockMenuItemClick;
			UnlockMenuItem.AjaxEvents.Click.Event -= UnlockMenuItemClick;
			ShowHistoryMenuItem.AjaxEvents.Click.Event -= ShowHistoryMenuItemClick;
		}

		protected override void InitializeEmbeddedProcess() {
			var instanceId = ((Terrasoft.UI.WebControls.Page)Page).InstanceId.ToString();
			string processUId = instanceId + PageContainer.UniqueID;
			var process = (BaseFileEntryGridPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new BaseFileEntryGridPageEventsProcess(UserConnection);
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

		public virtual void AddReportMenuItemClick(object sender, EventArgs e) {
			object result = ThrowEvent("AddReportMenuItemClick");
		}

		public virtual void SaveToFileButtonClick(object sender, EventArgs e) {
			object result = ThrowEvent("SaveToFileButtonClick");
		}

		public virtual void OperationsButtonMenuShow(object sender, EventArgs e) {
			object result = ThrowEvent("OperationsButtonMenuShow");
		}

		public virtual void LockMenuItemClick(object sender, EventArgs e) {
			object result = ThrowEvent("LockMenuItemClick");
		}

		public virtual void UnlockMenuItemClick(object sender, EventArgs e) {
			object result = ThrowEvent("UnlockMenuItemClick");
		}

		public virtual void ShowHistoryMenuItemClick(object sender, EventArgs e) {
			object result = ThrowEvent("ShowHistoryMenuItemClick");
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
			SchemaName = "BaseFileEntryGridPage";
		}

		#endregion

	}

	#endregion

	#region Class: BaseFileEntryGridPageEventsProcessSchema

	/// <exclude/>
	public class BaseFileEntryGridPageEventsProcessSchema : Terrasoft.WebApp.BaseGridPageEventsProcessSchema
	{

		#region Constructors: Public

		public BaseFileEntryGridPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public BaseFileEntryGridPageEventsProcessSchema(BaseFileEntryGridPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "BaseFileEntryGridPageEventsProcess";
			UId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
		}

		protected virtual ProcessSchemaParameter CreateFileTypeIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("7949dc02-67da-403d-aa4f-e592c84a8f31"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				Name = @"FileTypeId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateDoProposeForceFileUnlockParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("79370f70-8678-4025-b32b-964449ddcccc"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				Name = @"DoProposeForceFileUnlock",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateLockedByIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("64647f40-947b-415f-9688-46371eb2ac30"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				Name = @"LockedById",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateReportDictionaryParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("53502492-8d75-4c63-ba95-a373a80d5325"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				Name = @"ReportDictionary",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			};
		}

		protected virtual ProcessSchemaParameter CreateIsTrackChangesParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("782d0570-16ae-44ac-98e3-022ed57e5daf"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				Name = @"IsTrackChanges",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateFileTypeIdParameter());
			Parameters.Add(CreateDoProposeForceFileUnlockParameter());
			Parameters.Add(CreateLockedByIdParameter());
			Parameters.Add(CreateReportDictionaryParameter());
			Parameters.Add(CreateIsTrackChangesParameter());
		}

		protected virtual void InitializeOpenFileHistoryPageUserTaskParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("30b4c07d-9429-43f1-8cda-0d0d7d80c9ac"),
				ContainerUId = new Guid("5ca3b58e-c921-405b-9e56-b536cb2f0275"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Name = @"PageUId",
				SourceParameterUId = Guid.Empty,
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
				UId = new Guid("e0b892a3-b594-41af-aa36-a0d23ca197b8"),
				ContainerUId = new Guid("5ca3b58e-c921-405b-9e56-b536cb2f0275"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Name = @"PageUrl",
				SourceParameterUId = Guid.Empty,
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
			});
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("dc4e3516-02aa-484e-9286-341a5dfc2aa4"),
				ContainerUId = new Guid("5ca3b58e-c921-405b-9e56-b536cb2f0275"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Name = @"OpenerInstanceId",
				SourceParameterUId = Guid.Empty,
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
			});
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("f658bbdc-83a8-4e85-bb09-e25209851dd6"),
				ContainerUId = new Guid("5ca3b58e-c921-405b-9e56-b536cb2f0275"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Name = @"CloseOpenerOnLoad",
				SourceParameterUId = Guid.Empty,
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
				UId = new Guid("9a90bddd-2be4-4d10-accc-9d303a9ab1fc"),
				ContainerUId = new Guid("5ca3b58e-c921-405b-9e56-b536cb2f0275"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Name = @"PageParameters",
				SourceParameterUId = Guid.Empty,
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
				UId = new Guid("edb0fb9a-c30b-42cf-b5a2-c63a1e02380f"),
				ContainerUId = new Guid("5ca3b58e-c921-405b-9e56-b536cb2f0275"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Name = @"Width",
				SourceParameterUId = Guid.Empty,
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					Value = null,
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer"),
			});
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("a450273c-94d0-4895-8a20-713c96e0844e"),
				ContainerUId = new Guid("5ca3b58e-c921-405b-9e56-b536cb2f0275"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Name = @"CloseMessage",
				SourceParameterUId = Guid.Empty,
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
			});
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("8cb6b0f9-370b-4f8c-8567-9b5622c6e3f0"),
				ContainerUId = new Guid("5ca3b58e-c921-405b-9e56-b536cb2f0275"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Name = @"Height",
				SourceParameterUId = Guid.Empty,
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					Value = null,
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer"),
			});
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("c8a1d36c-a5b6-433e-b79c-c9354af4c889"),
				ContainerUId = new Guid("5ca3b58e-c921-405b-9e56-b536cb2f0275"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Name = @"Centered",
				SourceParameterUId = Guid.Empty,
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
				UId = new Guid("942577a4-40a8-46ca-9d0e-89d767dde8df"),
				ContainerUId = new Guid("5ca3b58e-c921-405b-9e56-b536cb2f0275"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Name = @"UseOpenerRegisterScript",
				SourceParameterUId = Guid.Empty,
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
				UId = new Guid("89d6ddb6-b235-4be5-816c-8510ae31fbb7"),
				ContainerUId = new Guid("5ca3b58e-c921-405b-9e56-b536cb2f0275"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Name = @"UseCurrentActivePage",
				SourceParameterUId = Guid.Empty,
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
				UId = new Guid("f7429cd8-4b28-44bd-955e-16aa28a558cd"),
				ContainerUId = new Guid("5ca3b58e-c921-405b-9e56-b536cb2f0275"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				Name = @"IgnoreProfile",
				SourceParameterUId = Guid.Empty,
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					Value = null,
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			});
		}

		protected virtual void InitializeOpenMessageUserTaskParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("ecb08d44-1623-4ba8-b126-be6ff194f559"),
				ContainerUId = new Guid("74950f4a-71ec-4fd2-944c-71b653fc35f6"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = true,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				Name = @"Page",
				SourceParameterUId = Guid.Empty,
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
				UId = new Guid("f5d1a65c-d92a-424a-97bc-a9dabc128a1d"),
				ContainerUId = new Guid("74950f4a-71ec-4fd2-944c-71b653fc35f6"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				Name = @"Icon",
				SourceParameterUId = Guid.Empty,
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
			});
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("7b74a21d-bbca-42ea-93f4-7f3f95e92256"),
				ContainerUId = new Guid("74950f4a-71ec-4fd2-944c-71b653fc35f6"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				Name = @"Buttons",
				SourceParameterUId = Guid.Empty,
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
			});
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("d973cbab-26ae-4e84-adb5-1a8e11963fa1"),
				ContainerUId = new Guid("74950f4a-71ec-4fd2-944c-71b653fc35f6"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				Name = @"WindowCaption",
				SourceParameterUId = Guid.Empty,
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
			});
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("3b9e84e4-67df-42d9-8dbd-755bf5bdfa7b"),
				ContainerUId = new Guid("74950f4a-71ec-4fd2-944c-71b653fc35f6"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = true,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				Name = @"MessageText",
				SourceParameterUId = Guid.Empty,
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
			});
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("938df6e7-53a1-4178-b1a1-33da910537c5"),
				ContainerUId = new Guid("74950f4a-71ec-4fd2-944c-71b653fc35f6"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				Name = @"ResponseMessages",
				SourceParameterUId = Guid.Empty,
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
				UId = new Guid("0ce4454a-7002-4e14-b3b4-739d351da84c"),
				ContainerUId = new Guid("74950f4a-71ec-4fd2-944c-71b653fc35f6"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				Name = @"ProcessInstanceId",
				SourceParameterUId = Guid.Empty,
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
			});
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("e544cdec-e778-4eb6-ac4e-a106c9ca3f62"),
				ContainerUId = new Guid("74950f4a-71ec-4fd2-944c-71b653fc35f6"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				Name = @"PageParameters",
				SourceParameterUId = Guid.Empty,
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

		protected virtual void InitializeOpenLookupUserTaskParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("c156813f-4f7b-44a5-a72d-026fcbdd3c88"),
				ContainerUId = new Guid("406bcbc9-8cd3-4389-85e9-419bc1d1f108"),
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
				SourceParameterUId = Guid.Empty,
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
				UId = new Guid("e2d433f8-40a2-40ec-839e-20ff188bd9d8"),
				ContainerUId = new Guid("406bcbc9-8cd3-4389-85e9-419bc1d1f108"),
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
				SourceParameterUId = Guid.Empty,
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
			});
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("226878e8-8e7b-4c23-a35d-a907afebd150"),
				ContainerUId = new Guid("406bcbc9-8cd3-4389-85e9-419bc1d1f108"),
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
				SourceParameterUId = Guid.Empty,
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
			});
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("419bb107-ce6f-4864-8917-9dfbeabacb6d"),
				ContainerUId = new Guid("406bcbc9-8cd3-4389-85e9-419bc1d1f108"),
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
				SourceParameterUId = Guid.Empty,
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					Value = null,
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			});
		}

		protected virtual void InitializeAskForceFileUnlockUserTaskParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("5c53074e-dcd2-4f0a-846f-7c23e8212aca"),
				ContainerUId = new Guid("3974ecaa-1475-487c-8132-a33d4b5482aa"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = true,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				Name = @"Page",
				SourceParameterUId = Guid.Empty,
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
				UId = new Guid("1ebec861-5ef7-42e0-a932-699b65dce0cb"),
				ContainerUId = new Guid("3974ecaa-1475-487c-8132-a33d4b5482aa"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				Name = @"Icon",
				SourceParameterUId = Guid.Empty,
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
			});
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("4b68ce92-6616-455d-8fbd-c07957c6a6f9"),
				ContainerUId = new Guid("3974ecaa-1475-487c-8132-a33d4b5482aa"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				Name = @"Buttons",
				SourceParameterUId = Guid.Empty,
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
			});
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("29072fa4-27aa-4812-8cdf-817fbb21ff64"),
				ContainerUId = new Guid("3974ecaa-1475-487c-8132-a33d4b5482aa"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				Name = @"WindowCaption",
				SourceParameterUId = Guid.Empty,
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
			});
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("f4bb2116-a640-4a5b-9873-59b9c36c8e46"),
				ContainerUId = new Guid("3974ecaa-1475-487c-8132-a33d4b5482aa"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = true,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				Name = @"MessageText",
				SourceParameterUId = Guid.Empty,
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
			});
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("4b33bb35-a6cd-455c-8726-a27cf9c3bd26"),
				ContainerUId = new Guid("3974ecaa-1475-487c-8132-a33d4b5482aa"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				Name = @"ResponseMessages",
				SourceParameterUId = Guid.Empty,
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
				UId = new Guid("e30520c7-052c-4d6e-987a-c603beca74a1"),
				ContainerUId = new Guid("3974ecaa-1475-487c-8132-a33d4b5482aa"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				Name = @"ProcessInstanceId",
				SourceParameterUId = Guid.Empty,
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
			});
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("7439c3fd-6f3d-4e97-9a81-183ef202b8f3"),
				ContainerUId = new Guid("3974ecaa-1475-487c-8132-a33d4b5482aa"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				Name = @"PageParameters",
				SourceParameterUId = Guid.Empty,
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
			ProcessSchemaLaneSet schemaLaneSet463 = CreateLaneSet463LaneSet();
			LaneSets.Add(schemaLaneSet463);
			ProcessSchemaLane schemaLane3 = CreateLane3Lane();
			schemaLaneSet463.Lanes.Add(schemaLane3);
			ProcessSchemaEventSubProcess eventsubprocess10 = CreateEventSubProcess10EventSubProcess();
			FlowElements.Add(eventsubprocess10);
			ProcessSchemaEventSubProcess eventsubprocess8 = CreateEventSubProcess8EventSubProcess();
			FlowElements.Add(eventsubprocess8);
			ProcessSchemaEventSubProcess eventsubprocess1 = CreateEventSubProcess1EventSubProcess();
			FlowElements.Add(eventsubprocess1);
			ProcessSchemaEventSubProcess eventsubprocesschilddatasourceloadrows = CreateEventSubProcessChildDataSourceLoadRowsEventSubProcess();
			FlowElements.Add(eventsubprocesschilddatasourceloadrows);
			ProcessSchemaEventSubProcess subprocesspageloadcompletechield = CreateSubProcessPageLoadCompleteChieldEventSubProcess();
			FlowElements.Add(subprocesspageloadcompletechield);
			ProcessSchemaEventSubProcess subprocesssavetofilebutton = CreateSubProcessSaveToFileButtonEventSubProcess();
			FlowElements.Add(subprocesssavetofilebutton);
			ProcessSchemaEventSubProcess eventsubprocessinit = CreateEventSubProcessInitEventSubProcess();
			FlowElements.Add(eventsubprocessinit);
			ProcessSchemaEventSubProcess subprocessoperationsbuttonmenu = CreateSubProcessOperationsButtonMenuEventSubProcess();
			FlowElements.Add(subprocessoperationsbuttonmenu);
			ProcessSchemaEventSubProcess subprocesslockmenu = CreateSubProcessLockMenuEventSubProcess();
			FlowElements.Add(subprocesslockmenu);
			ProcessSchemaEventSubProcess subprocessunlockmenu = CreateSubProcessUnlockMenuEventSubProcess();
			FlowElements.Add(subprocessunlockmenu);
			ProcessSchemaStartMessageEvent startmessage1234598 = CreateStartMessage1234598StartMessageEvent();
			eventsubprocess10.FlowElements.Add(startmessage1234598);
			ProcessSchemaScriptTask setopenpageparametersscripttask = CreateSetOpenPageParametersScriptTaskScriptTask();
			eventsubprocess10.FlowElements.Add(setopenpageparametersscripttask);
			ProcessSchemaUserTask openfilehistorypageusertask = CreateOpenFileHistoryPageUserTaskUserTask();
			eventsubprocess10.FlowElements.Add(openfilehistorypageusertask);
			ProcessSchemaExclusiveGateway exclusivegateway = CreateExclusiveGatewayExclusiveGateway();
			eventsubprocess10.FlowElements.Add(exclusivegateway);
			ProcessSchemaScriptTask setmessageparametersscripttask = CreateSetMessageParametersScriptTaskScriptTask();
			eventsubprocess10.FlowElements.Add(setmessageparametersscripttask);
			ProcessSchemaUserTask openmessageusertask = CreateOpenMessageUserTaskUserTask();
			eventsubprocess10.FlowElements.Add(openmessageusertask);
			ProcessSchemaScriptTask reportbuttonclickscript = CreateReportButtonClickScriptScriptTask();
			eventsubprocess8.FlowElements.Add(reportbuttonclickscript);
			ProcessSchemaUserTask openlookupusertask = CreateOpenLookupUserTaskUserTask();
			eventsubprocess8.FlowElements.Add(openlookupusertask);
			ProcessSchemaScriptTask afterlookupgridpageclosedscript = CreateAfterLookupGridPageClosedScriptScriptTask();
			eventsubprocess8.FlowElements.Add(afterlookupgridpageclosedscript);
			ProcessSchemaIntermediateCatchMessageEvent lookupgridpageclosed = CreateLookupGridPageClosedIntermediateCatchMessageEvent();
			eventsubprocess8.FlowElements.Add(lookupgridpageclosed);
			ProcessSchemaStartMessageEvent addreportmenuitemclickstartmessage = CreateAddReportMenuItemClickStartMessageStartMessageEvent();
			eventsubprocess8.FlowElements.Add(addreportmenuitemclickstartmessage);
			ProcessSchemaStartMessageEvent startmessage2 = CreateStartMessage2StartMessageEvent();
			eventsubprocess1.FlowElements.Add(startmessage2);
			ProcessSchemaIntermediateThrowMessageEvent intermediatethrowmessageevent2 = CreateIntermediateThrowMessageEvent2IntermediateThrowMessageEvent();
			eventsubprocess1.FlowElements.Add(intermediatethrowmessageevent2);
			ProcessSchemaScriptTask scripttask1 = CreateScriptTask1ScriptTask();
			eventsubprocess1.FlowElements.Add(scripttask1);
			ProcessSchemaStartMessageEvent startmessage3 = CreateStartMessage3StartMessageEvent();
			eventsubprocess1.FlowElements.Add(startmessage3);
			ProcessSchemaIntermediateThrowMessageEvent intermediatethrowmessageevent3 = CreateIntermediateThrowMessageEvent3IntermediateThrowMessageEvent();
			eventsubprocess1.FlowElements.Add(intermediatethrowmessageevent3);
			ProcessSchemaScriptTask lockunlockeditbuttonsscripttask = CreateLockUnlockEditButtonsScriptTaskScriptTask();
			eventsubprocess1.FlowElements.Add(lockunlockeditbuttonsscripttask);
			ProcessSchemaStartMessageEvent startmessagechilddatasourceloadrows = CreateStartMessageChildDataSourceLoadRowsStartMessageEvent();
			eventsubprocesschilddatasourceloadrows.FlowElements.Add(startmessagechilddatasourceloadrows);
			ProcessSchemaIntermediateThrowMessageEvent intermediatethrowbasedatasourceloadrows = CreateIntermediateThrowBaseDataSourceLoadRowsIntermediateThrowMessageEvent();
			eventsubprocesschilddatasourceloadrows.FlowElements.Add(intermediatethrowbasedatasourceloadrows);
			ProcessSchemaScriptTask scriptchilddatasourceloadrows = CreateScriptChildDataSourceLoadRowsScriptTask();
			eventsubprocesschilddatasourceloadrows.FlowElements.Add(scriptchilddatasourceloadrows);
			ProcessSchemaStartMessageEvent pageloadcompletechield = CreatePageLoadCompleteChieldStartMessageEvent();
			subprocesspageloadcompletechield.FlowElements.Add(pageloadcompletechield);
			ProcessSchemaScriptTask scriptpageloadcompletechield = CreateScriptPageLoadCompleteChieldScriptTask();
			subprocesspageloadcompletechield.FlowElements.Add(scriptpageloadcompletechield);
			ProcessSchemaIntermediateThrowMessageEvent pageloadcompletebase = CreatePageLoadCompleteBaseIntermediateThrowMessageEvent();
			subprocesspageloadcompletechield.FlowElements.Add(pageloadcompletebase);
			ProcessSchemaStartMessageEvent savetofilebuttonclick = CreateSaveToFileButtonClickStartMessageEvent();
			subprocesssavetofilebutton.FlowElements.Add(savetofilebuttonclick);
			ProcessSchemaScriptTask scriptsavetofilebuttonclick = CreateScriptSaveToFileButtonClickScriptTask();
			subprocesssavetofilebutton.FlowElements.Add(scriptsavetofilebuttonclick);
			ProcessSchemaStartMessageEvent startmessagechildinit = CreateStartMessageChildInitStartMessageEvent();
			eventsubprocessinit.FlowElements.Add(startmessagechildinit);
			ProcessSchemaScriptTask scriptchildinit = CreateScriptChildInitScriptTask();
			eventsubprocessinit.FlowElements.Add(scriptchildinit);
			ProcessSchemaIntermediateThrowMessageEvent intermediatethrowbaseinit = CreateIntermediateThrowBaseInitIntermediateThrowMessageEvent();
			eventsubprocessinit.FlowElements.Add(intermediatethrowbaseinit);
			ProcessSchemaStartMessageEvent operationsbuttonmenushow = CreateOperationsButtonMenuShowStartMessageEvent();
			subprocessoperationsbuttonmenu.FlowElements.Add(operationsbuttonmenushow);
			ProcessSchemaScriptTask scriptoperationsbuttonmenushow = CreateScriptOperationsButtonMenuShowScriptTask();
			subprocessoperationsbuttonmenu.FlowElements.Add(scriptoperationsbuttonmenushow);
			ProcessSchemaStartMessageEvent lockmenuitemclick = CreateLockMenuItemClickStartMessageEvent();
			subprocesslockmenu.FlowElements.Add(lockmenuitemclick);
			ProcessSchemaScriptTask scriptlockmenuitemclick = CreateScriptLockMenuItemClickScriptTask();
			subprocesslockmenu.FlowElements.Add(scriptlockmenuitemclick);
			ProcessSchemaStartMessageEvent unlockmenuitemclick = CreateUnlockMenuItemClickStartMessageEvent();
			subprocessunlockmenu.FlowElements.Add(unlockmenuitemclick);
			ProcessSchemaScriptTask scriptunlockmenuitemclick = CreateScriptUnlockMenuItemClickScriptTask();
			subprocessunlockmenu.FlowElements.Add(scriptunlockmenuitemclick);
			ProcessSchemaUserTask askforcefileunlockusertask = CreateAskForceFileUnlockUserTaskUserTask();
			subprocessunlockmenu.FlowElements.Add(askforcefileunlockusertask);
			ProcessSchemaScriptTask scriptempty = CreateScriptEmptyScriptTask();
			subprocessunlockmenu.FlowElements.Add(scriptempty);
			ProcessSchemaScriptTask scriptyesunlockfilemessage = CreateScriptYesUnlockFileMessageScriptTask();
			subprocessunlockmenu.FlowElements.Add(scriptyesunlockfilemessage);
			ProcessSchemaStartMessageEvent yesunlockfilemessage = CreateYesUnlockFileMessageStartMessageEvent();
			subprocessunlockmenu.FlowElements.Add(yesunlockfilemessage);
			FlowElements.Add(CreateSequenceFlow8585SequenceFlow());
			FlowElements.Add(CreateSequenceFlow8586SequenceFlow());
			FlowElements.Add(CreateSequenceFlow8587SequenceFlow());
			FlowElements.Add(CreateSequenceFlow8588SequenceFlow());
			FlowElements.Add(CreateSequenceFlow8589ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow8590SequenceFlow());
			FlowElements.Add(CreateSequenceFlow8591SequenceFlow());
			FlowElements.Add(CreateSequenceFlow8592SequenceFlow());
			FlowElements.Add(CreateSequenceFlow8598SequenceFlow());
			FlowElements.Add(CreateSequenceFlow8599SequenceFlow());
			FlowElements.Add(CreateSequenceFlow8602SequenceFlow());
			FlowElements.Add(CreateSequenceFlow8603SequenceFlow());
			FlowElements.Add(CreateSequenceFlow8607SequenceFlow());
			FlowElements.Add(CreateSequenceFlow8608SequenceFlow());
			FlowElements.Add(CreateSequenceFlow8609SequenceFlow());
			FlowElements.Add(CreateSequenceFlow8610SequenceFlow());
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
			FlowElements.Add(CreateSequenceFlow4SequenceFlow());
			FlowElements.Add(CreateSequenceFlow5SequenceFlow());
			FlowElements.Add(CreateSequenceFlow6SequenceFlow());
			FlowElements.Add(CreateSequenceFlow234567879SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2346883SequenceFlow());
			FlowElements.Add(CreateConditionalFlow1ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateSequenceFlow7SequenceFlow());
			FlowElements.Add(CreateSequenceFlow8678989SequenceFlow());
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateSelectFileLocalizableString());
			LocalizableStrings.Add(CreateAskForceFileUnlockLocalizableString());
			LocalizableStrings.Add(CreateDefaultReportFileNameLocalizableString());
			LocalizableStrings.Add(CreateNotLookupValuesMessageLocalizableString());
			LocalizableStrings.Add(CreateReportWindowCaptionLocalizableString());
			LocalizableStrings.Add(CreateNoChangesTrackingInDBMessageLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateSelectFileLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("e93da9cb-13bb-4880-b088-88dd6588740a"),
				Name = "SelectFile",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				ModifiedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateAskForceFileUnlockLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("28026099-6c38-4c97-bc1d-24d779564d01"),
				Name = "AskForceFileUnlock",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				ModifiedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateDefaultReportFileNameLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("57b59306-7bfd-4b85-b7b7-fcf420a8ef5d"),
				Name = "DefaultReportFileName",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				ModifiedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateNotLookupValuesMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("15932be0-a748-4e46-aa72-974b9756419f"),
				Name = "NotLookupValuesMessage",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				ModifiedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateReportWindowCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("9d98fd37-5849-404e-91c5-7c55c03c1b84"),
				Name = "ReportWindowCaption",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				ModifiedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601")
			};
			return localizableString;
		}

		protected virtual SchemaLocalizableString CreateNoChangesTrackingInDBMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("2029e85c-da38-4126-8b0f-492518c5496f"),
				Name = "NoChangesTrackingInDBMessage",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				ModifiedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601")
			};
			return localizableString;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow8585SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow8585",
				UId = new Guid("a4628659-9045-4fa7-8b0e-5d1c40963835"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("ac66c420-0ee7-45ff-8340-41545f1c4f9c"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("02f76589-794c-4327-9bb6-a1c1084e8615"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow8586SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow8586",
				UId = new Guid("e9ee8d99-23d1-45fc-9b5c-69b19539f249"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("63e218ae-a0f1-4657-a2fe-7855ce751ca1"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("836b5838-1d8f-4bf9-8319-585bae79bfad"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow8587SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow8587",
				UId = new Guid("a3825eb8-7633-4af4-9b38-25a2ef6296c5"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("a77ae3ec-adb3-4a76-a058-040da22e0b32"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("08cb2815-45df-47ac-9b3a-bac7ff97576c"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow8588SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow8588",
				UId = new Guid("da03ac5d-d383-4560-8b2a-6dbc71a4df62"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("b41f38ca-9d39-4c20-8624-31f5368a2262"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("2d530126-f3de-419e-8188-9d384cada59f"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateSequenceFlow8589ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "SequenceFlow8589",
				UId = new Guid("c4502ed5-5dc1-4a13-b37f-cf8f8a5ced66"),
				ConditionExpression = @"DoProposeForceFileUnlock",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				CurveCenterPosition = new Point(442, 414),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("836b5838-1d8f-4bf9-8319-585bae79bfad"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("3974ecaa-1475-487c-8132-a33d4b5482aa"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow8590SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlow8590",
				UId = new Guid("f0063059-9400-4c13-8c5e-7cdccb3bb6bf"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				CurveCenterPosition = new Point(378, 436),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("836b5838-1d8f-4bf9-8319-585bae79bfad"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("8a5be461-e2c8-4639-8d98-d677c1f054f3"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow8591SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow8591",
				UId = new Guid("7785b4be-8027-4ef7-bb86-e7d5ca47be2c"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				CurveCenterPosition = new Point(534, 480),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("c3874dc1-5995-4a24-bc88-0256214e1873"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("343c563a-f75c-4ef4-b956-18cf4bf914a8"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow8592SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow8592",
				UId = new Guid("8b22e973-97ca-43bf-9222-df7724d90a56"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				CurveCenterPosition = new Point(134, 96),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("bda281f8-00b2-475d-9a23-5ee929b94e52"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("832dfb6c-6e91-4b49-a6fb-c2e36bdcdc61"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow8598SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow8598",
				UId = new Guid("821025d8-67ea-4724-a916-a8091ae58a29"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				CurveCenterPosition = new Point(394, 618),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("33530ebf-cc11-423c-bd57-c2e56ed8fa3e"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("8cf10a47-e666-4d0d-9a7a-8baa75f9468b"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow8599SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow8599",
				UId = new Guid("81295415-9695-46f2-beb9-18fa86eb7ccb"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				CurveCenterPosition = new Point(535, 615),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("8cf10a47-e666-4d0d-9a7a-8baa75f9468b"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("2ce010a1-2a2d-427b-9f38-a02cb548295f"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow8602SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow8602",
				UId = new Guid("9c24878a-db76-4cb7-af7d-578a6e739bef"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("528d55a6-7803-416c-b55a-e4e2fd46fd88"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("184eeaa4-b6f1-474e-bacd-c5ee4f5f8c3a"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow8603SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow8603",
				UId = new Guid("0a8888e2-e63e-4707-b269-95b4b6fd818a"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				CurveCenterPosition = new Point(217, 69),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("184eeaa4-b6f1-474e-bacd-c5ee4f5f8c3a"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("48fbed24-86b8-43e7-adf4-ad5ccf5cedaa"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow8607SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow8607",
				UId = new Guid("ea16e44d-6783-4ef7-a6a2-9b240964f3dc"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("24c53539-bb2c-4a58-9831-1a1ee8bd4b26"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("9bbbf65c-4038-4367-bdb0-bac59611c0d6"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow8608SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow8608",
				UId = new Guid("133e4f01-d6df-4024-a3ac-c5de6516184e"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				CurveCenterPosition = new Point(198, 76),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("9bbbf65c-4038-4367-bdb0-bac59611c0d6"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("45d08d2a-3e34-447b-9369-88157cc7728c"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow8609SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow8609",
				UId = new Guid("629efaf4-869c-4eb5-8d21-17821a64028d"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				CurveCenterPosition = new Point(161, 82),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("dc76a0f0-b446-4243-8dd1-9af06d400920"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("34d32e98-37a3-411c-a963-97699a600797"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow8610SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow8610",
				UId = new Guid("88b1e966-85ec-4a00-976d-41b4b03b5ddc"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				CurveCenterPosition = new Point(256, 69),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("34d32e98-37a3-411c-a963-97699a600797"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("45d08d2a-3e34-447b-9369-88157cc7728c"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("c20ab0d7-e13a-4e55-92a2-4d85e52513f3"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				CurveCenterPosition = new Point(134, 96),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("a6e910f3-0d4b-46e9-9108-479a5b5f3ba9"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("bda281f8-00b2-475d-9a23-5ee929b94e52"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3",
				UId = new Guid("85c50a9f-b22a-4896-8a08-1206cca163a6"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				CurveCenterPosition = new Point(255, 76),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("d6470104-6356-4636-9321-cde4191f24c9"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("406bcbc9-8cd3-4389-85e9-419bc1d1f108"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4",
				UId = new Guid("c3cd7ab2-2147-4650-a719-a08459144155"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				CurveCenterPosition = new Point(208, 200),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("e652d634-d8f2-4b20-a1f4-992290eccf05"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("e03184fb-b499-4fbe-9c0c-19edc0066a28"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow5SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow5",
				UId = new Guid("dad6bb46-d9c8-46c2-8f13-468fae66e9b7"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				CurveCenterPosition = new Point(200, 133),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("406bcbc9-8cd3-4389-85e9-419bc1d1f108"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("e652d634-d8f2-4b20-a1f4-992290eccf05"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow6SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow6",
				UId = new Guid("a39de93d-c07e-4a94-b64f-2832a386efab"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("32145160-76c9-46cf-83af-d9048b3ca47a"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("d6470104-6356-4636-9321-cde4191f24c9"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow234567879SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow234567879",
				UId = new Guid("fd12d87f-2226-444c-b6ac-5e9d92a4c9f8"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("c84991ce-afd6-4fb5-afcf-322226a59c9a"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("785886ee-9551-4937-888b-4bd7470f43d3"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2346883SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2346883",
				UId = new Guid("b5a996f8-7a50-419b-8980-28339ab56cb4"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				CurveCenterPosition = new Point(310, 78),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("785886ee-9551-4937-888b-4bd7470f43d3"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("4e1cc226-33f7-4325-9bdd-2340b1850a29"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow1ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow1",
				UId = new Guid("aa7b4c8d-29c6-49bb-9a32-1f3b2f3fba8c"),
				ConditionExpression = @"IsTrackChanges",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				CurveCenterPosition = new Point(478, 76),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("4e1cc226-33f7-4325-9bdd-2340b1850a29"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("5ca3b58e-c921-405b-9e56-b536cb2f0275"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlow2",
				UId = new Guid("d0fc0d6a-9966-40ab-a31e-35ad6ad56351"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				CurveCenterPosition = new Point(434, 126),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("4e1cc226-33f7-4325-9bdd-2340b1850a29"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("7c9a5058-83d4-42f6-ad3d-2c996ef0059b"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow7SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow7",
				UId = new Guid("14055325-9004-4d80-ac54-5a849acd315d"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				CurveCenterPosition = new Point(521, 154),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("7c9a5058-83d4-42f6-ad3d-2c996ef0059b"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("74950f4a-71ec-4fd2-944c-71b653fc35f6"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow8678989SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow8678989",
				UId = new Guid("97f5d868-7404-465d-9fdb-427546d016aa"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				CurveCenterPosition = new Point(408, 640),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("45d08d2a-3e34-447b-9369-88157cc7728c"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("03954345-2078-46cc-a908-d97f3844c326"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet463LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet463 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("76ff8ecf-bd6b-46c1-a352-0dde1ecaf89c"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				Name = @"LaneSet463",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(5, 5),
				Size = new Size(846, 235),
				UseBackgroundMode = false
			};
			return schemaLaneSet463;
		}

		protected virtual ProcessSchemaLane CreateLane3Lane() {
			ProcessSchemaLane schemaLane3 = new ProcessSchemaLane(this) {
				UId = new Guid("efd8861c-d241-4b47-8fee-9baf76f35a27"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("76ff8ecf-bd6b-46c1-a352-0dde1ecaf89c"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				Name = @"Lane3",
				Position = new Point(29, 0),
				Size = new Size(817, 235),
				UseBackgroundMode = false
			};
			return schemaLane3;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess10EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess10 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("dc5b582e-655e-45c0-b97a-4c77abf9323f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("efd8861c-d241-4b47-8fee-9baf76f35a27"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				Name = @"EventSubProcess10",
				Position = new Point(35, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(605, 214),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess10;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage1234598StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("c84991ce-afd6-4fb5-afcf-322226a59c9a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("dc5b582e-655e-45c0-b97a-4c77abf9323f"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"ShowHistoryMenuItemClick",
				ModifiedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				Name = @"StartMessage1234598",
				Position = new Point(22, 72),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateSetOpenPageParametersScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("785886ee-9551-4937-888b-4bd7470f43d3"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("dc5b582e-655e-45c0-b97a-4c77abf9323f"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				Name = @"SetOpenPageParametersScriptTask",
				Position = new Point(113, 58),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,165,84,219,110,226,48,16,125,6,137,127,240,230,161,74,36,228,31,160,91,137,75,97,145,186,91,84,160,251,236,38,3,88,77,236,104,236,180,138,42,254,125,199,78,74,18,202,170,91,237,91,156,241,156,51,115,230,140,239,115,80,115,153,194,15,105,172,198,114,37,246,176,53,128,27,97,158,185,63,44,19,246,157,109,0,81,24,189,179,252,55,60,141,243,156,187,148,169,86,198,26,255,249,8,104,36,29,23,40,147,58,107,52,232,191,8,100,8,177,198,196,131,184,0,159,9,43,214,186,192,24,248,56,182,242,5,30,244,235,10,101,38,176,156,234,180,200,212,163,72,11,232,36,111,202,28,40,125,81,200,132,223,102,185,45,41,42,119,225,9,249,91,59,22,177,183,65,191,215,36,223,42,43,109,185,142,15,144,9,2,113,189,81,221,10,136,91,43,222,142,254,20,138,10,68,190,0,187,164,198,132,138,97,82,254,18,25,132,231,133,87,247,185,139,69,163,11,108,196,243,145,156,79,17,132,133,234,87,216,173,227,132,178,3,27,31,30,192,20,169,61,3,225,115,23,154,163,206,102,147,48,88,38,193,240,36,237,144,41,120,101,119,52,192,107,99,81,170,253,13,123,11,156,104,193,49,26,49,66,38,177,90,192,149,66,189,142,182,29,38,18,192,253,78,90,243,184,118,2,223,132,30,149,184,125,189,199,65,255,88,141,105,71,14,56,41,124,89,172,81,115,243,78,239,191,50,142,185,84,73,51,15,50,86,216,208,113,58,70,190,94,20,241,243,244,32,212,30,204,82,205,38,85,56,116,117,46,77,59,72,156,221,26,200,60,170,72,83,118,117,229,68,233,245,90,205,56,224,234,171,82,98,66,219,97,15,97,224,154,11,34,222,5,118,172,95,1,169,55,230,191,113,156,9,47,130,212,138,231,2,233,134,37,54,106,221,249,100,38,189,214,180,111,181,91,134,172,118,141,151,235,108,177,156,54,149,97,26,32,62,78,146,48,120,191,213,50,34,223,232,181,135,10,35,239,144,203,41,222,153,195,214,110,255,91,90,213,252,214,19,254,101,33,183,31,74,32,131,222,127,242,192,173,218,2,53,212,148,140,96,11,84,204,34,189,71,127,0,252,175,167,0,39,5,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaUserTask CreateOpenFileHistoryPageUserTaskUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("5ca3b58e-c921-405b-9e56-b536cb2f0275"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("dc5b582e-655e-45c0-b97a-4c77abf9323f"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				Name = @"OpenFileHistoryPageUserTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(406, 7),
				SchemaUId = new Guid("b7042ef4-f468-443e-b3ea-39ebbda1c828"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			InitializeOpenFileHistoryPageUserTaskParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGatewayExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("4e1cc226-33f7-4325-9bdd-2340b1850a29"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("dc5b582e-655e-45c0-b97a-4c77abf9323f"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				Name = @"ExclusiveGateway",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(260, 58),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaScriptTask CreateSetMessageParametersScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("7c9a5058-83d4-42f6-ad3d-2c996ef0059b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("dc5b582e-655e-45c0-b97a-4c77abf9323f"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				Name = @"SetMessageParametersScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(351, 114),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,142,65,11,130,64,16,133,239,65,255,97,241,84,16,251,7,164,67,42,133,68,26,105,117,30,150,65,197,220,149,217,217,232,231,183,202,94,130,60,13,143,247,189,55,175,28,81,95,208,90,104,240,110,145,106,176,189,188,122,33,246,98,58,241,122,245,6,18,86,181,56,64,10,35,119,70,7,75,102,192,80,25,71,10,101,53,251,50,0,62,84,254,169,13,186,198,15,251,10,203,212,233,70,30,13,13,192,155,194,164,45,232,6,109,77,160,122,111,228,58,75,66,64,62,224,229,112,247,59,98,187,240,36,87,243,192,232,121,184,21,121,113,138,22,176,196,49,27,109,39,178,60,79,16,33,59,210,130,201,97,252,5,203,90,233,70,20,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaUserTask CreateOpenMessageUserTaskUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("74950f4a-71ec-4fd2-944c-71b653fc35f6"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("dc5b582e-655e-45c0-b97a-4c77abf9323f"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				Name = @"OpenMessageUserTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(463, 114),
				SchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			InitializeOpenMessageUserTaskParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess8EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess8 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("de442f50-57e2-4e06-9993-b4fa459d605a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("efd8861c-d241-4b47-8fee-9baf76f35a27"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				Name = @"EventSubProcess8",
				Position = new Point(36, 249),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(593, 144),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess8;
		}

		protected virtual ProcessSchemaScriptTask CreateReportButtonClickScriptScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("d6470104-6356-4636-9321-cde4191f24c9"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("de442f50-57e2-4e06-9993-b4fa459d605a"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				Name = @"ReportButtonClickScript",
				Position = new Point(119, 35),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,85,77,79,34,65,16,61,143,137,255,161,119,14,102,38,33,29,239,168,9,162,184,102,253,32,130,235,193,120,232,29,106,160,215,158,238,217,238,30,92,98,248,239,91,253,49,48,24,49,155,16,96,138,170,87,85,175,94,21,75,166,9,43,44,95,114,187,34,167,228,209,128,30,42,41,1,77,74,210,75,105,209,62,41,22,80,177,91,38,217,28,52,189,2,123,45,141,101,178,128,243,213,29,171,32,75,7,17,32,205,233,80,3,179,16,226,178,93,180,188,127,120,192,75,146,181,233,232,8,108,177,24,105,85,93,156,103,19,16,232,5,179,59,53,131,177,230,21,211,171,161,18,77,37,127,50,209,64,158,147,247,195,131,100,137,197,22,222,106,176,214,13,78,168,143,6,127,131,89,146,251,26,228,141,82,175,77,237,74,152,50,243,74,199,90,21,96,204,15,112,109,182,13,60,94,207,250,17,183,198,230,198,76,99,63,22,180,131,151,240,70,46,184,175,28,139,57,49,86,115,57,239,17,245,235,55,22,122,150,185,110,146,221,32,58,152,205,178,212,248,106,28,49,105,143,164,147,149,185,85,179,70,192,3,212,74,219,116,127,216,66,189,197,14,48,206,37,191,225,198,198,180,152,238,125,11,229,112,135,172,118,149,165,235,189,128,141,129,239,28,52,211,197,98,133,17,37,19,6,246,58,11,53,231,5,19,200,155,102,30,183,71,110,62,152,232,189,254,34,220,113,125,165,249,108,140,191,182,181,245,72,104,250,137,203,25,54,23,172,52,12,212,33,97,187,34,72,227,100,63,209,103,164,228,162,51,146,255,11,10,227,233,50,72,4,62,4,130,35,210,46,191,206,191,84,168,222,98,145,109,117,70,184,108,21,23,36,152,240,50,155,130,214,204,168,210,162,228,100,201,231,77,36,168,93,3,180,26,107,232,54,161,19,131,243,181,140,75,147,5,60,234,140,57,57,58,114,160,201,70,203,184,93,29,221,71,223,252,27,86,220,8,17,75,72,146,45,180,231,63,34,62,64,9,26,80,214,97,33,80,220,116,170,38,190,193,44,247,13,38,107,124,91,239,89,144,143,11,176,59,104,23,142,189,119,50,15,85,35,237,233,233,113,172,234,22,183,203,71,72,16,164,234,62,156,18,215,187,86,226,209,114,193,45,7,67,71,40,137,104,204,92,98,58,48,181,255,140,70,243,124,252,210,35,190,217,244,156,25,232,130,163,174,172,70,9,17,102,72,215,222,15,227,33,217,78,242,15,212,117,127,67,194,42,181,196,251,117,167,108,32,195,147,110,34,104,186,165,108,55,12,41,143,46,123,67,123,62,217,19,211,210,203,242,115,175,94,91,254,116,85,3,189,150,40,191,138,181,151,50,73,52,216,70,203,176,184,253,56,183,184,11,126,234,95,31,168,86,42,201,123,90,168,170,102,154,27,37,93,34,164,111,228,81,134,59,102,122,249,167,97,98,221,219,68,9,40,237,229,223,90,99,137,152,33,204,124,204,236,98,231,170,209,205,183,112,242,221,115,247,79,3,53,152,118,48,241,38,93,112,83,11,182,242,68,180,103,169,227,161,249,124,209,73,187,209,95,32,14,3,178,208,223,243,75,222,145,226,84,13,112,37,87,89,190,94,7,164,60,202,181,229,203,107,149,156,145,86,172,159,29,177,48,161,192,141,203,20,99,243,126,18,200,199,87,28,137,147,95,255,31,63,201,61,197,58,7,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaUserTask CreateOpenLookupUserTaskUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("406bcbc9-8cd3-4389-85e9-419bc1d1f108"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("de442f50-57e2-4e06-9993-b4fa459d605a"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				Name = @"OpenLookupUserTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(252, 35),
				SchemaUId = new Guid("1aac6458-2318-40e5-8592-778f3a94fdae"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			InitializeOpenLookupUserTaskParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaScriptTask CreateAfterLookupGridPageClosedScriptScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("e03184fb-b499-4fbe-9c0c-19edc0066a28"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("de442f50-57e2-4e06-9993-b4fa459d605a"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				Name = @"AfterLookupGridPageClosedScript",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(483, 35),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,165,86,93,79,219,72,20,125,14,18,255,97,234,135,106,172,194,36,116,181,221,178,20,86,196,73,16,93,104,35,18,182,15,171,125,152,218,55,224,214,246,100,199,227,20,183,226,191,239,157,15,219,147,16,53,43,1,15,73,60,231,158,251,117,238,29,175,184,36,43,158,85,80,146,83,66,71,105,172,82,81,112,89,147,119,165,146,105,113,119,64,196,231,47,16,171,179,240,227,18,138,43,33,190,86,203,219,18,228,156,151,95,217,5,168,25,100,120,10,201,95,134,131,234,163,72,20,5,24,158,240,100,127,47,93,16,106,29,176,72,84,133,98,227,127,43,158,149,116,16,134,228,199,254,94,79,130,170,100,65,148,172,0,209,143,251,123,23,85,154,16,40,84,170,234,89,124,15,57,191,189,76,48,54,253,152,141,243,165,170,79,28,38,22,89,149,23,198,241,230,185,141,221,33,70,105,185,204,120,221,0,237,89,11,117,100,18,150,66,42,235,170,128,111,134,174,137,123,146,202,82,209,144,253,9,117,216,145,91,139,136,47,117,166,186,120,63,173,222,6,149,9,38,180,63,63,202,17,44,120,149,41,250,64,78,207,200,131,246,67,78,79,73,224,184,3,7,103,115,49,51,172,52,52,113,175,197,241,129,231,166,10,160,110,218,223,195,26,243,161,109,102,225,102,97,140,141,53,138,218,7,195,122,86,151,215,34,169,50,176,76,155,20,251,123,43,212,12,199,84,87,216,34,52,95,239,57,27,123,173,187,230,5,191,3,169,133,114,89,148,138,23,49,242,107,47,52,56,119,4,152,93,36,129,43,176,118,91,20,212,239,107,13,53,14,217,4,84,124,63,145,34,31,13,105,163,190,15,34,129,169,76,115,44,125,212,169,34,36,47,95,186,84,117,99,95,248,34,49,226,235,247,123,126,180,214,148,196,149,68,249,141,103,17,230,214,122,181,8,102,33,186,143,69,98,203,219,242,55,98,127,94,160,166,39,47,214,85,106,7,229,89,145,154,154,119,30,116,172,189,167,51,214,242,177,27,88,0,126,143,193,177,225,185,54,89,31,185,214,37,182,119,94,47,33,241,82,122,167,75,125,70,91,198,176,51,223,152,71,159,37,122,2,240,25,8,238,7,2,89,9,254,226,88,224,50,129,147,158,89,29,86,154,185,21,157,27,100,43,226,53,57,154,249,209,200,210,60,221,2,164,142,195,140,140,173,128,27,176,110,218,186,35,91,188,118,72,204,140,84,165,158,51,170,189,216,3,28,93,224,185,243,117,13,185,144,181,125,68,221,34,212,208,132,43,62,19,149,140,193,1,109,211,71,237,99,19,122,175,131,49,191,125,27,13,213,200,57,72,201,75,177,80,24,36,251,4,159,113,178,148,20,89,201,110,85,154,165,42,197,149,180,233,162,59,185,44,240,147,103,233,119,56,175,148,192,37,133,1,87,49,86,29,104,23,129,9,72,199,254,165,20,5,210,175,64,170,182,248,29,235,36,205,240,113,249,222,7,109,204,250,129,151,126,168,43,226,254,166,18,86,152,218,13,220,165,37,90,97,93,163,44,197,7,179,88,166,75,133,158,244,221,209,194,31,117,60,235,53,138,42,169,53,212,70,207,92,48,236,60,73,168,143,51,123,200,30,126,74,213,253,148,75,236,179,70,210,46,154,158,61,143,68,190,228,50,197,116,180,242,237,165,118,224,161,130,203,36,240,127,123,147,19,218,45,106,138,182,176,145,96,18,186,50,108,134,233,153,130,211,255,17,254,193,122,201,61,86,171,56,125,215,185,93,96,18,179,2,223,178,96,123,22,207,186,124,255,14,156,143,224,31,214,204,169,11,213,195,143,31,244,199,92,76,147,5,245,69,30,186,22,248,247,4,242,185,93,242,236,27,67,83,5,173,236,124,7,222,54,233,252,237,186,94,122,190,9,118,64,161,208,189,69,86,210,173,32,15,209,69,166,123,78,118,172,250,147,174,243,224,118,202,150,181,248,138,4,248,255,106,253,37,99,87,28,90,110,129,230,196,40,244,247,198,69,243,202,181,126,167,252,97,48,238,217,68,200,156,43,26,252,24,60,178,101,178,64,2,247,78,98,69,51,105,152,220,117,245,251,207,109,27,199,33,162,118,87,79,15,144,169,92,240,235,235,227,97,244,122,242,246,112,48,30,15,14,71,147,163,163,195,227,223,142,134,135,131,193,209,232,205,96,124,252,203,219,232,13,118,158,244,251,154,104,23,239,12,231,8,89,125,101,178,43,40,238,212,189,185,74,158,24,91,136,51,214,155,107,195,120,75,38,124,229,54,242,20,69,203,230,18,224,66,226,27,70,148,1,151,222,65,183,6,217,149,224,201,141,248,166,85,101,239,44,255,253,247,63,1,110,232,43,141,11,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaIntermediateCatchMessageEvent CreateLookupGridPageClosedIntermediateCatchMessageEvent() {
			ProcessSchemaIntermediateCatchMessageEvent schemaCatchMessageEvent = new ProcessSchemaIntermediateCatchMessageEvent(this) {
				UId = new Guid("e652d634-d8f2-4b20-a1f4-992290eccf05"),
				AttachedToUId = Guid.Empty,
				BoundaryItemAlignment = ProcessSchemaEditItemAlignment.None,
				CancelActivity = true,
				ContainerItemIndex = 0,
				ContainerUId = new Guid("de442f50-57e2-4e06-9993-b4fa459d605a"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("3cb9d737-779e-4085-ab4b-db590853e266"),
				Message = @"LookupGridPageClosed",
				ModifiedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				Name = @"LookupGridPageClosed",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(385, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaCatchMessageEvent;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateAddReportMenuItemClickStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("32145160-76c9-46cf-83af-d9048b3ca47a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("de442f50-57e2-4e06-9993-b4fa459d605a"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"AddReportMenuItemClick",
				ModifiedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				Name = @"AddReportMenuItemClickStartMessage",
				Position = new Point(28, 46),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess1EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess1 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("0dbd02d5-aa5d-4b71-90e3-581e4d666cc7"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("efd8861c-d241-4b47-8fee-9baf76f35a27"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				Name = @"EventSubProcess1",
				Position = new Point(35, 419),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(545, 214),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess1;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage2StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("24c53539-bb2c-4a58-9831-1a1ee8bd4b26"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0dbd02d5-aa5d-4b71-90e3-581e4d666cc7"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"DataSourceActiveRowChanged",
				ModifiedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				Name = @"StartMessage2",
				Position = new Point(36, 107),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateIntermediateThrowMessageEvent2IntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("9bbbf65c-4038-4367-bdb0-bac59611c0d6"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0dbd02d5-aa5d-4b71-90e3-581e4d666cc7"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"DataSourceActiveRowChanged",
				ModifiedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				Name = @"IntermediateThrowMessageEvent2",
				Position = new Point(127, 107),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask1ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("45d08d2a-3e34-447b-9369-88157cc7728c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0dbd02d5-aa5d-4b71-90e3-581e4d666cc7"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				Name = @"ScriptTask1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(239, 21),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,115,205,75,76,202,73,117,201,44,6,81,193,137,101,169,33,249,110,153,57,169,78,165,37,37,249,121,26,154,214,92,69,169,37,165,69,121,10,37,69,165,169,214,0,152,178,34,176,45,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage3StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("dc76a0f0-b446-4243-8dd1-9af06d400920"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0dbd02d5-aa5d-4b71-90e3-581e4d666cc7"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"DataSourceLoadRowsResponseRegistered",
				ModifiedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				Name = @"StartMessage3",
				Position = new Point(29, 37),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateIntermediateThrowMessageEvent3IntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("34d32e98-37a3-411c-a963-97699a600797"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0dbd02d5-aa5d-4b71-90e3-581e4d666cc7"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"DataSourceLoadRowsResponseRegistered",
				ModifiedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				Name = @"IntermediateThrowMessageEvent3",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(106, 37),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateLockUnlockEditButtonsScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("03954345-2078-46cc-a908-d97f3844c326"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0dbd02d5-aa5d-4b71-90e3-581e4d666cc7"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				Name = @"LockUnlockEditButtonsScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(400, 21),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,243,201,79,206,14,205,203,1,146,174,41,153,37,78,165,37,37,249,121,197,26,154,214,188,92,69,169,37,165,69,121,10,37,69,165,169,214,0,149,59,176,47,38,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcessChildDataSourceLoadRowsEventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcessChildDataSourceLoadRows = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("6d9278ee-564e-4e0c-9e02-8f1d6b133436"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("efd8861c-d241-4b47-8fee-9baf76f35a27"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				Name = @"EventSubProcessChildDataSourceLoadRows",
				Position = new Point(35, 659),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(318, 130),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcessChildDataSourceLoadRows;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessageChildDataSourceLoadRowsStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("528d55a6-7803-416c-b55a-e4e2fd46fd88"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6d9278ee-564e-4e0c-9e02-8f1d6b133436"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"DataSourceLoadRows",
				ModifiedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				Name = @"StartMessageChildDataSourceLoadRows",
				Position = new Point(15, 44),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateIntermediateThrowBaseDataSourceLoadRowsIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("184eeaa4-b6f1-474e-bacd-c5ee4f5f8c3a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6d9278ee-564e-4e0c-9e02-8f1d6b133436"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"DataSourceLoadRows",
				ModifiedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				Name = @"IntermediateThrowBaseDataSourceLoadRows",
				Position = new Point(85, 44),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptChildDataSourceLoadRowsScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("48fbed24-86b8-43e7-adf4-ad5ccf5cedaa"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6d9278ee-564e-4e0c-9e02-8f1d6b133436"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				Name = @"ScriptChildDataSourceLoadRows",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(176, 30),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,144,193,74,195,64,16,134,207,10,190,195,208,83,114,89,122,87,11,26,219,210,91,105,163,30,196,195,164,153,72,96,187,19,119,103,90,138,248,238,238,166,134,92,68,241,182,48,223,247,207,63,219,54,144,173,241,141,204,3,10,110,89,253,142,204,134,143,193,20,172,78,96,6,211,28,62,174,46,47,14,232,97,167,222,147,147,56,134,91,248,73,122,153,190,94,127,179,77,107,169,60,117,180,170,35,91,146,247,24,184,17,243,76,213,93,215,153,69,156,22,236,130,132,254,153,192,199,85,61,184,50,120,227,66,179,36,73,84,93,176,213,189,123,66,171,116,179,212,182,158,101,147,243,154,73,158,244,138,217,66,27,134,208,152,145,157,211,204,252,93,209,134,108,236,149,247,66,127,198,22,15,84,114,146,238,85,132,157,153,59,172,44,165,10,99,86,162,61,137,122,7,191,74,145,251,4,178,129,250,127,251,43,191,137,165,254,21,253,5,99,207,47,149,177,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSubProcessPageLoadCompleteChieldEventSubProcess() {
			ProcessSchemaEventSubProcess schemaSubProcessPageLoadCompleteChield = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("1c7c6df3-9053-4f09-97eb-7491f1fcbc2f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("efd8861c-d241-4b47-8fee-9baf76f35a27"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				Name = @"SubProcessPageLoadCompleteChield",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(36, 829),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(355, 168),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSubProcessPageLoadCompleteChield;
		}

		protected virtual ProcessSchemaStartMessageEvent CreatePageLoadCompleteChieldStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("a6e910f3-0d4b-46e9-9108-479a5b5f3ba9"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1c7c6df3-9053-4f09-97eb-7491f1fcbc2f"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				Name = @"PageLoadCompleteChield",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(15, 68),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptPageLoadCompleteChieldScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("bda281f8-00b2-475d-9a23-5ee929b94e52"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1c7c6df3-9053-4f09-97eb-7491f1fcbc2f"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				Name = @"ScriptPageLoadCompleteChield",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(112, 59),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,213,82,193,110,218,64,16,61,131,196,63,108,125,137,45,217,150,13,197,24,33,14,198,216,137,37,72,162,208,156,170,30,86,222,1,182,216,107,186,187,38,65,132,127,239,46,24,165,105,85,53,61,244,208,227,190,153,247,102,222,155,77,8,149,247,120,5,143,25,65,99,196,224,9,93,215,148,152,134,23,79,39,253,200,143,28,191,31,14,156,143,177,63,113,194,56,9,157,176,151,6,190,31,12,162,56,152,26,214,168,211,78,105,1,159,246,91,248,137,223,239,13,39,113,55,13,29,47,73,60,103,154,250,190,51,28,40,17,207,243,167,129,151,12,123,97,28,156,248,66,114,202,86,104,89,241,18,203,197,249,49,70,198,193,59,186,21,51,175,242,130,230,155,43,27,45,107,150,75,170,16,40,44,116,56,160,131,127,68,199,163,141,228,154,10,203,80,58,59,204,145,200,57,221,74,69,191,6,249,0,43,42,36,240,136,16,237,111,113,42,153,201,171,93,27,45,246,98,94,145,186,0,141,106,64,175,238,38,229,86,238,173,81,171,211,166,75,100,126,56,239,231,102,226,182,46,138,59,126,170,154,231,65,150,218,164,211,110,105,61,87,141,105,70,52,132,244,100,200,252,209,151,141,46,173,51,202,54,115,96,117,38,161,116,227,130,2,147,217,212,70,23,89,101,231,248,251,100,187,239,77,246,127,73,67,27,253,99,26,122,1,243,81,0,143,43,198,224,244,23,220,236,158,87,57,8,145,176,21,101,224,166,148,145,6,153,236,149,39,115,166,61,51,224,122,80,83,80,176,229,46,242,53,148,216,189,197,37,160,177,250,108,145,146,219,81,73,161,73,64,247,27,232,229,69,217,105,253,163,145,73,137,105,113,201,223,120,27,221,164,150,82,141,210,145,124,238,126,113,111,40,33,192,212,29,151,184,16,48,250,181,49,250,138,159,147,157,74,77,232,244,242,141,58,207,101,75,141,222,96,70,10,224,74,64,242,250,93,252,197,186,122,154,85,152,204,177,216,252,37,237,110,139,191,213,240,150,216,220,143,131,172,57,59,131,223,1,197,34,27,76,119,4,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreatePageLoadCompleteBaseIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("832dfb6c-6e91-4b49-a6fb-c2e36bdcdc61"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1c7c6df3-9053-4f09-97eb-7491f1fcbc2f"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				Name = @"PageLoadCompleteBase",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(246, 68),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSubProcessSaveToFileButtonEventSubProcess() {
			ProcessSchemaEventSubProcess schemaSubProcessSaveToFileButton = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("1480ccd5-a143-4a11-8f0e-eea62cf79569"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("efd8861c-d241-4b47-8fee-9baf76f35a27"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				Name = @"SubProcessSaveToFileButton",
				Position = new Point(36, 1035),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(188, 136),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSubProcessSaveToFileButton;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateSaveToFileButtonClickStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("b41f38ca-9d39-4c20-8624-31f5368a2262"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1480ccd5-a143-4a11-8f0e-eea62cf79569"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"SaveToFileButtonClick",
				ModifiedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				Name = @"SaveToFileButtonClick",
				Position = new Point(14, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptSaveToFileButtonClickScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("2d530126-f3de-419e-8188-9d384cada59f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1480ccd5-a143-4a11-8f0e-eea62cf79569"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				Name = @"ScriptSaveToFileButtonClick",
				Position = new Point(77, 36),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,80,79,75,195,48,20,63,91,232,119,120,244,212,64,9,122,158,158,42,20,65,134,172,69,15,99,135,216,188,150,64,155,140,244,101,99,136,223,221,100,53,186,245,160,183,247,242,126,127,115,16,22,38,28,176,37,148,107,35,113,130,7,120,17,61,242,198,34,86,86,73,94,95,94,87,105,162,58,200,175,24,188,52,78,19,220,195,29,131,143,52,185,177,72,206,106,32,235,208,195,63,211,228,172,247,40,72,212,198,217,22,249,179,17,114,99,142,185,198,35,84,78,201,107,185,237,237,142,191,138,193,249,41,123,146,217,142,55,166,38,171,116,159,51,198,190,253,151,138,94,237,255,24,7,95,181,117,214,162,38,143,143,61,23,42,222,125,53,67,165,63,120,208,47,131,87,72,165,25,220,168,207,241,242,44,80,51,6,98,130,247,19,225,54,18,55,56,237,141,158,48,58,196,221,159,211,100,174,2,157,26,112,45,198,128,201,231,39,246,135,81,64,102,161,123,83,151,70,119,170,119,86,144,50,154,7,253,40,207,223,172,34,204,227,90,156,11,20,63,78,5,44,201,126,35,111,216,156,246,200,125,6,20,99,24,131,205,229,215,125,1,197,115,207,94,33,2,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcessInitEventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcessInit = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("f68810d9-5022-4295-9628-bd922589469b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("efd8861c-d241-4b47-8fee-9baf76f35a27"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				Name = @"EventSubProcessInit",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(245, 1023),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(357, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcessInit;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessageChildInitStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("33530ebf-cc11-423c-bd57-c2e56ed8fa3e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f68810d9-5022-4295-9628-bd922589469b"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				Name = @"StartMessageChildInit",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 63),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptChildInitScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("8cf10a47-e666-4d0d-9a7a-8baa75f9468b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f68810d9-5022-4295-9628-bd922589469b"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				Name = @"ScriptChildInit",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(141, 48),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,174,204,75,206,40,202,207,203,172,74,117,73,44,73,12,206,47,45,74,78,13,46,41,42,77,46,41,45,74,85,176,85,0,50,83,173,185,2,18,211,83,245,130,19,203,82,67,242,221,50,115,82,157,74,75,74,242,243,244,28,179,18,43,92,203,82,243,74,138,245,156,115,50,147,179,245,60,139,67,11,114,242,19,83,224,250,138,82,129,198,228,65,56,0,185,49,117,132,107,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateIntermediateThrowBaseInitIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("2ce010a1-2a2d-427b-9f38-a02cb548295f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f68810d9-5022-4295-9628-bd922589469b"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				Name = @"IntermediateThrowBaseInit",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(281, 63),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSubProcessOperationsButtonMenuEventSubProcess() {
			ProcessSchemaEventSubProcess schemaSubProcessOperationsButtonMenu = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("c622eccb-4351-4479-b306-29d851859192"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("efd8861c-d241-4b47-8fee-9baf76f35a27"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				Name = @"SubProcessOperationsButtonMenu",
				Position = new Point(35, 1203),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(256, 146),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSubProcessOperationsButtonMenu;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateOperationsButtonMenuShowStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("a77ae3ec-adb3-4a76-a058-040da22e0b32"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c622eccb-4351-4479-b306-29d851859192"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"OperationsButtonMenuShow",
				ModifiedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				Name = @"OperationsButtonMenuShow",
				Position = new Point(14, 52),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptOperationsButtonMenuShowScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("08cb2815-45df-47ac-9b3a-bac7ff97576c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c622eccb-4351-4479-b306-29d851859192"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				Name = @"ScriptOperationsButtonMenuShow",
				Position = new Point(127, 39),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,81,77,111,130,64,20,60,203,175,216,114,48,112,217,180,103,108,15,34,24,147,126,165,104,47,141,135,21,158,74,10,111,237,250,86,107,170,255,189,187,16,11,180,166,39,200,188,121,243,102,102,119,66,177,45,20,144,18,100,143,50,131,45,187,101,207,98,5,124,170,0,198,42,207,120,210,158,6,206,66,202,130,165,2,239,101,250,110,184,75,81,108,161,65,103,88,116,240,124,201,188,142,60,15,165,70,98,3,118,227,179,47,167,247,71,168,119,65,228,196,192,124,45,125,215,114,59,201,12,3,97,207,198,58,207,186,71,222,174,231,252,85,20,218,252,185,147,204,157,243,169,76,72,229,184,242,124,63,168,85,82,173,20,32,189,200,253,57,240,72,144,72,164,86,41,240,36,93,67,41,120,168,64,16,68,72,57,29,188,217,22,84,40,17,205,149,92,162,149,177,217,26,25,30,3,165,235,88,201,114,52,244,26,143,126,21,179,103,67,66,54,60,84,166,91,75,99,160,233,97,3,89,40,11,93,98,229,121,96,243,220,121,110,179,226,218,107,173,170,188,102,196,163,15,109,74,242,236,14,143,202,13,29,252,51,249,167,197,171,127,233,172,223,191,36,216,141,203,195,218,178,69,205,11,34,137,148,76,54,102,46,245,142,71,246,139,60,26,38,96,50,154,214,34,92,229,8,54,101,40,48,250,52,40,193,211,6,148,176,60,207,53,96,44,77,225,181,213,56,47,192,173,236,159,156,147,83,189,137,245,245,0,168,39,4,37,143,80,44,10,168,10,172,171,8,106,82,189,125,153,86,207,2,71,1,105,133,140,148,134,224,27,220,227,85,16,243,2,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSubProcessLockMenuEventSubProcess() {
			ProcessSchemaEventSubProcess schemaSubProcessLockMenu = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("c6a92f44-b23d-4810-88b1-7952a8330905"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("efd8861c-d241-4b47-8fee-9baf76f35a27"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				Name = @"SubProcessLockMenu",
				Position = new Point(36, 1382),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(186, 122),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSubProcessLockMenu;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateLockMenuItemClickStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("ac66c420-0ee7-45ff-8340-41545f1c4f9c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c6a92f44-b23d-4810-88b1-7952a8330905"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"LockMenuItemClick",
				ModifiedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				Name = @"LockMenuItemClick",
				Position = new Point(14, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptLockMenuItemClickScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("02f76589-794c-4327-9bb6-a1c1084e8615"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c6a92f44-b23d-4810-88b1-7952a8330905"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				Name = @"ScriptLockMenuItemClick",
				Position = new Point(77, 35),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,78,45,241,201,79,206,118,203,76,205,73,41,14,75,204,41,77,45,214,40,41,42,77,213,180,230,42,74,45,41,45,202,83,0,241,172,1,241,187,78,75,39,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateSubProcessUnlockMenuEventSubProcess() {
			ProcessSchemaEventSubProcess schemaSubProcessUnlockMenu = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("0fe0afde-2d40-41a6-b3de-d923e593e7ff"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("efd8861c-d241-4b47-8fee-9baf76f35a27"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				Name = @"SubProcessUnlockMenu",
				Position = new Point(232, 1375),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(392, 205),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaSubProcessUnlockMenu;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateUnlockMenuItemClickStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("63e218ae-a0f1-4657-a2fe-7855ce751ca1"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0fe0afde-2d40-41a6-b3de-d923e593e7ff"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"UnlockMenuItemClick",
				ModifiedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				Name = @"UnlockMenuItemClick",
				Position = new Point(14, 28),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptUnlockMenuItemClickScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("836b5838-1d8f-4bf9-8319-585bae79bfad"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0fe0afde-2d40-41a6-b3de-d923e593e7ff"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				Name = @"ScriptUnlockMenuItemClick",
				Position = new Point(77, 14),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,146,81,107,194,48,20,133,159,237,175,200,250,32,45,72,255,128,219,96,106,29,5,167,110,213,193,30,67,123,148,96,185,113,185,9,179,20,255,251,18,221,131,40,184,167,11,231,124,39,185,28,174,218,136,228,97,166,171,29,234,81,91,212,89,254,237,100,195,201,154,97,198,154,8,149,85,154,178,177,51,6,100,131,154,121,217,202,202,22,117,42,250,125,113,5,78,70,37,42,103,148,109,115,218,42,66,246,10,59,150,148,31,188,106,177,216,195,200,192,37,177,23,167,218,84,88,83,227,63,159,170,6,113,154,138,46,234,77,244,210,232,189,102,156,236,96,156,17,241,36,172,113,24,70,189,23,222,93,121,97,137,149,228,93,182,148,91,120,48,140,251,224,27,152,61,180,194,193,122,254,22,188,159,46,42,77,62,22,191,175,243,114,85,44,230,241,125,124,228,172,213,196,33,241,149,151,243,197,63,248,7,120,239,113,252,237,24,114,132,31,49,81,167,138,165,105,31,217,26,69,219,129,56,207,231,174,139,91,112,60,240,207,131,47,10,61,14,68,23,147,14,198,92,95,234,199,97,116,20,104,24,161,240,18,118,118,114,208,212,252,41,27,7,78,54,254,6,144,122,42,50,176,206,208,185,250,95,145,138,213,254,44,2,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaUserTask CreateAskForceFileUnlockUserTaskUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("3974ecaa-1475-487c-8132-a33d4b5482aa"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0fe0afde-2d40-41a6-b3de-d923e593e7ff"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				Name = @"AskForceFileUnlockUserTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(203, 14),
				SchemaUId = new Guid("496a664f-3aab-43d7-ab1b-2521ab601aab"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			InitializeAskForceFileUnlockUserTaskParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptEmptyScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("8a5be461-e2c8-4639-8d98-d677c1f054f3"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0fe0afde-2d40-41a6-b3de-d923e593e7ff"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				Name = @"ScriptEmpty",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(77, 105),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,40,41,42,77,181,6,0,0,22,62,211,12,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptYesUnlockFileMessageScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("343c563a-f75c-4ef4-b956-18cf4bf914a8"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0fe0afde-2d40-41a6-b3de-d923e593e7ff"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				Name = @"ScriptYesUnlockFileMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(280, 105),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,78,45,241,201,79,206,118,203,76,205,73,41,14,75,204,41,77,45,214,72,75,204,41,78,213,180,230,42,74,45,41,45,202,83,40,41,42,77,181,6,0,72,230,90,248,40,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateYesUnlockFileMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("c3874dc1-5995-4a24-bc88-0256214e1873"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0fe0afde-2d40-41a6-b3de-d923e593e7ff"),
				CreatedInOwnerSchemaUId = new Guid("c843575b-2184-40d3-bbdd-1ecc25f0b33f"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"YesUnlockFile",
				ModifiedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				Name = @"YesUnlockFileMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(189, 119),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateSetLockFieldsValuesMethod());
			Methods.Add(CreateEnableDisableSaveToFileButtonMethod());
			Methods.Add(CreateGetColumnNameBySysModuleReportIdMethod());
			Methods.Add(CreateGetReportNameByUIdMethod());
			Methods.Add(CreateLockUnlockEditButtonsMethod());
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("a2902ca9-2e40-4e2f-9d1e-79d6058eff66"),
				Name = "System.Runtime.InteropServices",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("100fee50-fe5e-484a-9c25-b5e0fe2c6c19"),
				Name = "System",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("9d7efbbf-8549-484c-9592-82bf90843f5d"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("95c66740-e509-4ca4-b1ef-c7a6bb406ec0"),
				Name = "Terrasoft.UI.WebControls.Controls",
				Alias = "WebControls",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7c7fbab2-546c-4dd3-ba02-c8f1ddbc356d"),
				Name = "System.Linq",
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
				UId = new Guid("a1aa763b-db2b-4afc-b72b-6b97d29056dc"),
				Name = "System.Text",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("10a2ccab-756c-4712-b1b8-f4ebab9f54a0"),
				Name = "Terrasoft.Configuration",
				Alias = "TSConfiguration",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e450a1d1-32d4-48db-a086-f5426a1a7722"),
				Name = "Terrasoft.Core.Store",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("014c78ec-88db-4b05-9740-f93c1db6ec5a"),
				Name = "System.IO",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("191f9f85-3ea1-46e0-aad9-dfeb7ab89309"),
				Name = "Terrasoft.Reports",
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

		protected override SchemaMethod CreateGetButtonsMethod() {
			SchemaMethod method = base.CreateGetButtonsMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,75,44,82,72,42,45,41,201,207,43,86,176,85,72,74,44,78,213,115,79,45,113,130,136,104,104,90,115,65,37,245,28,83,82,52,2,18,211,83,245,252,11,82,139,18,75,50,129,98,16,85,122,126,137,185,169,216,20,6,39,150,165,134,228,187,101,230,164,18,161,208,57,35,49,47,61,21,205,200,162,212,146,210,162,60,152,251,172,1,217,141,174,20,172,0,0,0 };
			return method;
		}

		protected override SchemaMethod CreateSetAdditionalDataSourcePropertiesMethod() {
			SchemaMethod method = base.CreateSetAdditionalDataSourcePropertiesMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,144,221,106,2,49,16,133,175,21,124,135,97,175,178,32,121,129,214,94,184,133,34,180,181,176,224,125,26,71,27,208,9,76,146,173,63,248,238,38,217,45,174,150,189,155,201,57,51,223,153,52,138,65,7,102,36,95,123,14,218,7,70,152,193,151,218,162,124,85,94,213,54,176,70,89,61,88,158,38,227,119,227,252,179,243,108,104,251,2,218,238,194,158,62,213,30,93,156,38,252,133,190,124,134,34,73,197,20,138,138,81,121,92,207,143,189,102,73,169,89,33,59,99,115,89,155,19,22,112,137,144,141,141,22,253,3,162,73,57,51,4,12,253,75,44,171,44,185,18,206,147,241,168,245,201,133,91,25,103,190,119,233,158,94,190,232,37,175,12,57,209,249,210,107,25,89,151,7,28,197,247,12,187,205,182,251,155,219,159,181,220,4,24,72,36,223,208,207,143,105,88,80,199,25,13,122,63,108,131,98,80,93,208,26,15,203,141,184,67,151,211,187,219,254,60,153,213,29,197,24,215,80,172,175,79,150,49,244,236,1,0,0 };
			return method;
		}

		protected override SchemaMethod CreateGetIsContextHelpButtonHiddenMethod() {
			SchemaMethod method = base.CreateGetIsContextHelpButtonHiddenMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,72,75,204,41,78,181,6,0,112,193,6,27,13,0,0,0 };
			return method;
		}

		protected override SchemaMethod CreateModifyAddPageParametersMethod() {
			SchemaMethod method = base.CreateModifyAddPageParametersMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,44,77,45,170,12,46,41,202,204,75,15,72,44,74,204,77,45,73,45,42,142,86,42,169,44,72,245,76,81,138,85,176,85,240,42,206,207,211,11,78,45,202,76,204,201,172,74,213,112,203,204,73,13,1,203,106,90,115,149,37,22,41,128,148,58,231,231,148,230,230,133,122,166,0,213,7,36,166,167,234,185,36,150,36,6,231,151,22,37,167,234,5,39,103,164,230,38,234,65,148,20,235,185,167,150,56,85,250,1,45,210,80,2,25,163,164,169,7,212,102,205,85,136,219,29,112,195,177,57,7,69,129,166,53,0,209,206,27,184,207,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSetLockFieldsValuesMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("ee321e5f-193a-484a-8ff2-47baa554f82b"),
				Name = "SetLockFieldsValues",
				CreatedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "bool"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("a7ababa9-f25f-412e-af11-4e7cd89bca9b"),
				Name = "NeedLock",
				CreatedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				ModifiedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "bool",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,84,203,110,219,48,16,60,199,95,193,234,16,80,64,193,180,215,42,15,192,178,108,24,72,237,32,114,122,41,114,96,164,181,77,148,90,166,20,105,215,104,252,239,37,165,198,162,156,4,201,77,88,238,14,103,102,135,218,112,77,106,144,80,24,40,103,170,132,154,92,144,27,190,2,182,208,0,19,45,74,150,135,167,201,64,44,9,237,13,176,84,89,52,228,156,124,141,201,223,193,137,6,99,53,18,163,45,36,131,253,96,19,224,79,75,7,142,176,37,19,43,202,62,200,207,47,247,236,7,151,214,125,69,211,50,186,103,11,149,27,45,112,69,227,56,105,64,10,171,53,160,185,85,219,103,134,35,110,120,174,172,46,128,229,197,26,42,206,82,13,220,64,134,70,152,29,189,171,65,167,10,209,93,34,20,198,45,243,79,29,12,27,131,41,214,99,173,170,209,144,118,20,227,215,84,204,172,148,252,65,194,185,103,126,233,53,92,171,226,23,148,195,93,171,201,29,39,93,147,35,6,11,81,65,208,56,199,67,155,135,32,50,28,167,1,169,9,152,84,73,91,97,227,6,141,186,123,162,152,92,180,24,49,185,106,44,100,89,245,104,118,228,91,231,233,7,129,250,238,122,95,102,0,165,239,104,196,55,70,117,12,89,246,219,114,89,211,238,202,214,163,190,73,39,251,193,158,128,172,193,31,61,40,37,73,193,241,14,61,140,151,248,30,222,233,41,161,47,91,250,59,100,105,43,207,87,93,234,208,240,194,184,133,57,38,79,79,228,168,117,52,204,193,185,225,130,144,225,74,32,52,126,112,204,254,184,170,129,249,35,104,238,251,104,228,138,99,229,50,212,82,29,11,9,145,55,165,53,225,32,225,85,193,132,184,104,188,112,239,56,28,31,209,144,4,99,77,84,158,35,196,102,106,235,3,24,44,54,127,123,177,159,251,201,116,50,222,157,155,99,56,53,199,163,25,190,1,234,74,199,239,237,90,241,210,157,135,121,187,209,162,226,122,23,92,225,230,206,206,250,255,146,91,88,106,168,215,225,47,229,0,239,25,124,7,180,83,3,21,203,208,191,36,111,223,210,229,0,254,183,180,187,120,187,41,220,207,63,115,169,30,252,217,4,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateEnableDisableSaveToFileButtonMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("63624924-bfe1-452e-a7a4-c16e765ca7fc"),
				Name = "EnableDisableSaveToFileButton",
				CreatedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "bool"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,82,77,79,194,64,16,61,151,95,177,114,42,9,109,90,140,8,81,72,160,20,194,65,131,130,122,48,30,86,58,200,38,237,46,110,119,33,141,225,191,187,219,245,163,180,4,189,206,188,247,230,205,188,33,43,100,207,240,27,184,35,44,240,156,73,190,4,119,176,20,100,11,247,108,55,227,36,193,60,11,88,44,19,250,136,99,9,232,172,135,38,146,68,110,152,108,68,214,64,31,53,107,139,57,2,42,136,200,230,203,53,36,248,6,83,165,199,81,15,61,164,192,3,70,41,40,61,70,221,176,10,186,170,210,21,175,236,199,52,142,96,239,36,240,76,17,40,236,80,88,174,219,71,76,53,15,232,238,45,78,160,241,165,43,178,13,152,69,149,96,101,136,59,136,34,211,181,235,11,133,172,107,90,21,53,38,177,0,158,106,180,93,237,6,28,176,0,131,121,34,98,61,195,92,25,208,4,187,102,89,166,30,176,100,131,57,73,25,213,99,220,240,93,226,184,228,250,32,149,124,135,102,229,100,39,34,108,40,235,197,83,170,86,108,18,58,186,248,4,68,88,194,217,135,193,22,47,56,141,80,241,65,84,135,168,7,43,15,114,3,38,169,64,125,228,229,31,100,253,48,203,192,103,239,69,27,208,167,136,10,43,92,235,9,125,147,196,52,202,179,216,27,15,43,18,195,226,91,77,191,133,70,218,245,139,86,119,24,180,198,29,199,11,67,207,25,141,125,223,233,94,250,67,199,243,252,81,219,11,187,231,157,160,157,203,228,119,156,227,45,44,152,202,3,134,82,136,252,115,241,107,12,90,210,56,53,177,164,246,239,52,205,229,32,36,167,232,164,196,85,109,143,32,78,65,175,253,215,172,149,26,1,255,215,253,4,235,65,247,192,202,3,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetColumnNameBySysModuleReportIdMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("e27bed5d-2a38-4b18-8628-9a82f5bbc876"),
				Name = "GetColumnNameBySysModuleReportId",
				CreatedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "string"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("d3323e99-9ca5-4eec-81c2-4e7e8a2a0403"),
				Name = "sysModuleReportId",
				CreatedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				ModifiedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,148,93,79,219,48,20,134,175,83,169,255,193,202,149,131,34,195,125,88,165,81,90,20,77,76,176,194,118,129,118,97,154,67,235,41,177,59,199,217,20,77,252,247,29,219,105,190,136,160,21,82,139,143,207,115,62,95,159,159,253,225,154,148,117,121,171,178,42,135,111,112,80,218,144,79,228,177,4,189,84,82,194,214,8,37,217,74,26,97,234,205,118,15,5,191,229,146,239,64,179,27,48,169,44,13,151,91,184,170,191,242,2,104,184,25,114,194,136,45,53,112,3,222,157,14,161,81,50,159,137,23,66,71,193,217,26,204,118,191,214,170,184,190,162,97,154,133,241,56,189,52,139,137,132,191,100,169,242,220,163,46,75,163,133,220,45,200,191,249,44,176,159,46,147,240,53,138,220,241,160,206,52,195,26,199,129,177,160,135,250,0,25,114,171,66,126,231,121,5,151,55,149,200,22,189,194,48,159,40,9,2,228,137,23,74,233,181,112,241,185,174,221,205,152,184,251,145,7,118,70,236,131,146,134,11,89,126,129,154,246,178,104,114,11,52,152,74,75,114,58,240,169,7,249,137,141,12,94,231,51,252,107,56,214,137,173,138,131,169,209,116,118,238,90,210,116,102,62,179,141,128,183,243,60,105,232,137,119,215,46,157,213,6,125,38,72,39,109,70,66,134,168,123,100,217,161,246,131,222,87,160,107,58,17,33,110,221,152,197,71,131,180,210,102,128,8,108,225,236,115,214,156,210,214,19,179,188,211,162,192,110,122,139,75,52,58,178,10,151,237,187,164,222,146,29,189,250,185,118,212,15,253,89,251,203,151,111,255,239,55,226,209,174,157,43,53,177,51,62,162,214,34,55,160,75,182,204,129,107,26,77,218,48,28,237,159,123,65,122,235,15,97,246,119,92,35,214,94,197,107,129,63,95,170,226,192,181,40,149,180,122,96,171,223,21,207,99,180,58,53,226,247,27,61,186,174,245,103,208,73,115,80,59,182,220,151,213,217,39,31,5,58,166,160,126,42,105,200,130,92,116,98,110,176,142,71,218,48,157,207,211,133,19,134,191,186,195,131,169,129,52,237,118,93,102,254,66,105,211,108,246,118,122,158,209,145,155,141,56,83,47,136,122,254,133,249,44,232,56,7,7,105,244,250,161,136,112,1,168,85,135,21,54,205,216,131,218,184,7,15,215,181,93,139,78,253,254,49,108,244,255,31,36,46,220,154,225,5,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetReportNameByUIdMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("39f258dc-4a0c-47d9-85c5-bd1c4484f453"),
				Name = "GetReportNameByUId",
				CreatedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "string"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("c594ccc3-390c-4aa7-8a77-69b864baea86"),
				Name = "reportUId",
				CreatedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				ModifiedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,145,205,138,195,32,20,133,215,13,228,29,36,43,3,197,62,64,127,22,205,76,74,22,157,69,59,153,189,196,59,173,96,174,197,104,135,48,244,221,39,198,80,26,146,113,165,232,249,206,185,199,59,55,196,192,77,27,75,182,164,108,192,100,26,17,42,43,53,178,119,180,210,182,231,234,10,53,63,114,228,23,48,236,0,182,192,198,114,172,96,223,126,240,26,104,114,110,155,163,22,78,193,169,231,36,41,203,12,112,11,65,78,199,208,116,29,71,242,155,208,224,201,114,176,213,53,55,186,126,219,211,164,16,201,114,8,83,22,98,73,16,126,72,166,149,10,202,77,99,141,196,203,142,252,198,209,194,47,111,28,44,67,196,210,235,95,238,66,40,246,220,133,60,254,252,58,152,87,61,210,180,167,30,156,20,164,153,80,187,102,134,184,221,244,159,237,13,68,151,202,213,248,197,149,131,141,23,237,232,92,24,63,235,226,254,44,120,84,228,180,237,142,125,154,190,163,61,100,181,242,24,177,157,35,177,92,162,40,44,212,251,182,51,165,211,248,61,193,128,117,6,103,245,163,47,253,7,193,252,87,119,156,71,28,13,36,116,74,173,255,0,16,4,65,127,62,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateLockUnlockEditButtonsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("63656f04-0838-481f-8adc-0149297427e0"),
				Name = "LockUnlockEditButtons",
				CreatedInSchemaUId = new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,197,82,221,106,194,48,20,190,86,240,29,50,47,36,130,228,5,156,3,127,138,8,219,112,186,121,159,53,199,173,91,155,74,154,212,5,241,221,119,106,117,107,106,4,47,6,187,205,249,126,79,78,206,21,225,161,142,114,88,164,219,153,32,3,50,231,111,192,38,92,243,101,106,84,8,108,120,154,206,85,148,112,101,199,105,108,18,185,226,177,129,126,171,25,173,9,173,242,111,6,100,106,34,193,130,100,163,109,151,236,26,173,102,35,71,15,144,58,210,118,25,190,67,194,31,184,68,15,133,94,47,25,168,113,42,37,160,66,42,89,112,14,234,123,248,158,144,229,192,7,126,50,160,44,50,36,108,73,80,127,167,158,88,61,135,206,30,121,2,221,147,112,156,134,159,32,70,118,38,202,45,160,238,153,23,27,138,227,148,182,239,143,248,118,215,141,230,229,77,65,151,1,169,187,150,94,245,131,60,81,74,141,90,160,227,70,88,249,156,21,226,35,91,116,161,245,14,151,26,254,74,33,247,217,110,64,84,126,254,182,248,228,59,234,15,193,42,192,31,241,226,80,42,226,206,157,144,78,135,184,179,218,97,140,141,82,24,166,120,69,113,169,113,33,184,10,178,67,221,198,225,20,2,17,233,145,209,26,177,75,147,109,64,138,225,7,255,10,114,36,101,244,224,127,134,11,36,127,141,161,168,185,230,113,6,94,204,2,50,147,128,95,106,2,49,104,184,198,212,65,94,180,117,80,126,227,61,1,164,252,85,109,173,204,63,180,118,93,175,41,221,106,238,191,1,165,174,25,142,166,4,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new BaseFileEntryGridPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("2bc54c7d-86c3-4f80-8f58-49905fffe601"));
		}

		#endregion

	}

	#endregion

}

