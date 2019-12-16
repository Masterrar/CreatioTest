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
	using System.Web.UI.WebControls;
	using Terrasoft.Common;
	using Terrasoft.Common.Json;
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
	using Terrasoft.Web.Common;

	#region Class: SysModuleReportDevExpressEditPageSchema

	/// <exclude/>
	public class SysModuleReportDevExpressEditPageSchema : Terrasoft.WebApp.BaseEditPageSchema
	{

		#region Properties: Public

		private Terrasoft.UI.WebControls.Controls.LocalizableTextEdit _captionEdit;
		public Terrasoft.UI.WebControls.Controls.LocalizableTextEdit CaptionEdit {
			get {
				return _captionEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.LookupEdit _sysModuleEdit;
		public Terrasoft.UI.WebControls.Controls.LookupEdit SysModuleEdit {
			get {
				return _sysModuleEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.LookupEdit _sysPageSchemaEdit;
		public Terrasoft.UI.WebControls.Controls.LookupEdit SysPageSchemaEdit {
			get {
				return _sysPageSchemaEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.LookupEdit _reportTemplateEdit;
		public Terrasoft.UI.WebControls.Controls.LookupEdit ReportTemplateEdit {
			get {
				return _reportTemplateEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.LookupEdit _sysOptionsPageSchemaEdit;
		public Terrasoft.UI.WebControls.Controls.LookupEdit SysOptionsPageSchemaEdit {
			get {
				return _sysOptionsPageSchemaEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ControlLayout _controlLayout1;
		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout1 {
			get {
				return _controlLayout1;
			}
		}

		private Terrasoft.UI.WebControls.Controls.CheckBox _showInSectionEdit;
		public Terrasoft.UI.WebControls.Controls.CheckBox ShowInSectionEdit {
			get {
				return _showInSectionEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.CheckBox _showInCardEdit;
		public Terrasoft.UI.WebControls.Controls.CheckBox ShowInCardEdit {
			get {
				return _showInCardEdit;
			}
		}

		#endregion

		#region Constructors: Public

		public SysModuleReportDevExpressEditPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public SysModuleReportDevExpressEditPageSchema(SysModuleReportDevExpressEditPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateBaseMessagePanel() {
			BaseMessagePanel.Edges = "0 0 0 0";
			BaseMessagePanel.ModifiedInSchemaUId = new Guid("93efee4c-26ad-4e27-a98a-aa00d16bdbf6");
		}

		private void UpdateCustomControls() {
			CustomControls.Image = new ControlImage {};
			CustomControls.ModifiedInSchemaUId = new Guid("93efee4c-26ad-4e27-a98a-aa00d16bdbf6");
		}

		private void UpdateMainControlLayout() {
			MainControlLayout.Image = new ControlImage {};
			MainControlLayout.ModifiedInSchemaUId = new Guid("93efee4c-26ad-4e27-a98a-aa00d16bdbf6");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("93efee4c-26ad-4e27-a98a-aa00d16bdbf6");
		}

		private void UpdateDesignerModeButton() {
			DesignerModeButton.AjaxEvents.Click.IsProcessEventHandler = true;
			DesignerModeButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("a5bcc8d7-215f-41c5-8f3c-f96f57d48c34"),
				ImageHash = @"682ad9264105b2170afb821fabf80415"
			};
			DesignerModeButton.ModifiedInSchemaUId = new Guid("93efee4c-26ad-4e27-a98a-aa00d16bdbf6");
		}

		private void UpdateOKButton() {
			OKButton.AjaxEvents.Click.IsProcessEventHandler = true;
			OKButton.Image = new ControlImage {};
			OKButton.ModifiedInSchemaUId = new Guid("93efee4c-26ad-4e27-a98a-aa00d16bdbf6");
		}

		private void UpdateCancelButton() {
			CancelButton.AjaxEvents.Click.IsProcessEventHandler = true;
			CancelButton.Image = new ControlImage {};
			CancelButton.ModifiedInSchemaUId = new Guid("93efee4c-26ad-4e27-a98a-aa00d16bdbf6");
		}

		private void UpdateApplyChangesButton() {
			ApplyChangesButton.AjaxEvents.Click.IsProcessEventHandler = true;
			ApplyChangesButton.Image = new ControlImage {};
			ApplyChangesButton.ModifiedInSchemaUId = new Guid("93efee4c-26ad-4e27-a98a-aa00d16bdbf6");
		}

		private void UpdateButtonsControlLayout() {
			ButtonsControlLayout.Image = new ControlImage {};
			ButtonsControlLayout.ModifiedInSchemaUId = new Guid("93efee4c-26ad-4e27-a98a-aa00d16bdbf6");
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("93efee4c-26ad-4e27-a98a-aa00d16bdbf6");
			RealUId = new Guid("93efee4c-26ad-4e27-a98a-aa00d16bdbf6");
			Name = "SysModuleReportDevExpressEditPage";
			ParentSchemaUId = new Guid("a5bcc8d7-215f-41c5-8f3c-f96f57d48c34");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			Height = 240;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateSysModuleReportDevExpressEditPageEventsProcessSchema();
		}

		protected override void InitializeControls() {
			base.InitializeControls();
			UpdateButtonsControlLayout();
			UpdateApplyChangesButton();
			UpdateCancelButton();
			UpdateOKButton();
			UpdateDesignerModeButton();
			UpdateContextHelpButton();
			UpdateMainControlLayout();
			UpdateCustomControls();
			UpdateBaseMessagePanel();
			TopLevelControl.MoveItem(0, BaseMessagePanel);
			TopLevelControl.MoveItem(1, MainControlLayout);
			MainControlLayout.InsertItem(0, CreateCaptionEdit());
			MainControlLayout.InsertItem(1, CreateSysModuleEdit());
			MainControlLayout.InsertItem(2, CreateSysPageSchemaEdit());
			MainControlLayout.InsertItem(3, CreateReportTemplateEdit());
			MainControlLayout.InsertItem(4, CreateSysOptionsPageSchemaEdit());
			MainControlLayout.InsertItem(5, CreateControlLayout1());
			ControlLayout1.InsertItem(0, CreateShowInSectionEdit());
			ControlLayout1.InsertItem(1, CreateShowInCardEdit());
			MainControlLayout.MoveItem(6, CustomControls);
			TopLevelControl.MoveItem(2, ButtonsControlLayout);
			ButtonsControlLayout.MoveItem(0, ContextHelpButton);
			ButtonsControlLayout.MoveItem(1, DesignerModeButton);
			ButtonsControlLayout.MoveItem(2, SpacerButton);
			ButtonsControlLayout.MoveItem(3, OKButton);
			ButtonsControlLayout.MoveItem(4, CancelButton);
			ButtonsControlLayout.MoveItem(5, ApplyChangesButton);
			TopLevelControl.MoveItem(3, DataSource);
			SetControlsDefInheritance(UId);
			InitializeLocalizableValues();
		}

		protected virtual EmbeddedProcessSchema CreateSysModuleReportDevExpressEditPageEventsProcessSchema() {
			var schema = new SysModuleReportDevExpressEditPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.LocalizableTextEdit CreateCaptionEdit() {
			_captionEdit = new Terrasoft.UI.WebControls.Controls.LocalizableTextEdit();
			_captionEdit.UId = new Guid("e739bc2a-727c-4082-87eb-80d9980e3818");
			_captionEdit.Name = "CaptionEdit";
			_captionEdit.CreatedInSchemaUId = new Guid("93efee4c-26ad-4e27-a98a-aa00d16bdbf6");
			_captionEdit.ModifiedInSchemaUId = new Guid("93efee4c-26ad-4e27-a98a-aa00d16bdbf6");
			_captionEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_captionEdit.Tag = "";
			_captionEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_captionEdit.Image = new ControlImage {};
			_captionEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_captionEdit.Required = true;
			return _captionEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.LookupEdit CreateSysModuleEdit() {
			_sysModuleEdit = new Terrasoft.UI.WebControls.Controls.LookupEdit();
			_sysModuleEdit.UId = new Guid("e351773d-3614-47e3-b02c-a66e5d89dd33");
			_sysModuleEdit.Name = "SysModuleEdit";
			_sysModuleEdit.CreatedInSchemaUId = new Guid("93efee4c-26ad-4e27-a98a-aa00d16bdbf6");
			_sysModuleEdit.ModifiedInSchemaUId = new Guid("93efee4c-26ad-4e27-a98a-aa00d16bdbf6");
			_sysModuleEdit.CreatedInPackageId = new Guid("e98ccaae-0bf0-40d8-a40d-46418c204c90");
			_sysModuleEdit.Tag = "";
			_sysModuleEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_sysModuleEdit.Image = new ControlImage {};
			_sysModuleEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_sysModuleEdit.DataSource = "DataSource";
			_sysModuleEdit.ColumnUId = new Guid("edbcd345-f27a-40e5-a477-7e1f45da8373");
			_sysModuleEdit.Required = true;
			return _sysModuleEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.LookupEdit CreateSysPageSchemaEdit() {
			_sysPageSchemaEdit = new Terrasoft.UI.WebControls.Controls.LookupEdit();
			_sysPageSchemaEdit.UId = new Guid("efbaea79-5e37-4709-b5f6-44370a139843");
			_sysPageSchemaEdit.Name = "SysPageSchemaEdit";
			_sysPageSchemaEdit.CreatedInSchemaUId = new Guid("93efee4c-26ad-4e27-a98a-aa00d16bdbf6");
			_sysPageSchemaEdit.ModifiedInSchemaUId = new Guid("93efee4c-26ad-4e27-a98a-aa00d16bdbf6");
			_sysPageSchemaEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_sysPageSchemaEdit.AjaxEvents.Change.IsProcessEventHandler = true;
			_sysPageSchemaEdit.Tag = "";
			_sysPageSchemaEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_sysPageSchemaEdit.Image = new ControlImage {};
			_sysPageSchemaEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_sysPageSchemaEdit.Required = true;
			_sysPageSchemaEdit.LookupSchemaUId = new Guid("90fa6d02-3e93-45d6-a72b-58dcffa411ae");
			return _sysPageSchemaEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.LookupEdit CreateReportTemplateEdit() {
			_reportTemplateEdit = new Terrasoft.UI.WebControls.Controls.LookupEdit();
			_reportTemplateEdit.UId = new Guid("d1572f63-261c-449a-99e3-363d98f0bd72");
			_reportTemplateEdit.Name = "ReportTemplateEdit";
			_reportTemplateEdit.CreatedInSchemaUId = new Guid("93efee4c-26ad-4e27-a98a-aa00d16bdbf6");
			_reportTemplateEdit.ModifiedInSchemaUId = new Guid("93efee4c-26ad-4e27-a98a-aa00d16bdbf6");
			_reportTemplateEdit.CreatedInPackageId = new Guid("bcd7b40a-afa2-4631-8983-51d02c873b88");
			_reportTemplateEdit.AjaxEvents.Change.IsProcessEventHandler = true;
			_reportTemplateEdit.Tag = "";
			_reportTemplateEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_reportTemplateEdit.Image = new ControlImage {};
			_reportTemplateEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_reportTemplateEdit.Required = true;
			_reportTemplateEdit.LookupSchemaUId = new Guid("e0e6a44f-f3d4-423a-9d01-c5d0c9d3eb64");
			return _reportTemplateEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.LookupEdit CreateSysOptionsPageSchemaEdit() {
			_sysOptionsPageSchemaEdit = new Terrasoft.UI.WebControls.Controls.LookupEdit();
			_sysOptionsPageSchemaEdit.UId = new Guid("dae90b13-5aea-49d3-b8c8-9d6876ea2eb1");
			_sysOptionsPageSchemaEdit.Name = "SysOptionsPageSchemaEdit";
			_sysOptionsPageSchemaEdit.CreatedInSchemaUId = new Guid("93efee4c-26ad-4e27-a98a-aa00d16bdbf6");
			_sysOptionsPageSchemaEdit.ModifiedInSchemaUId = new Guid("93efee4c-26ad-4e27-a98a-aa00d16bdbf6");
			_sysOptionsPageSchemaEdit.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			_sysOptionsPageSchemaEdit.AjaxEvents.Change.IsProcessEventHandler = true;
			_sysOptionsPageSchemaEdit.Tag = "";
			_sysOptionsPageSchemaEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_sysOptionsPageSchemaEdit.Image = new ControlImage {};
			_sysOptionsPageSchemaEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_sysOptionsPageSchemaEdit.LookupSchemaUId = new Guid("90fa6d02-3e93-45d6-a72b-58dcffa411ae");
			return _sysOptionsPageSchemaEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.CheckBox CreateShowInSectionEdit() {
			_showInSectionEdit = new Terrasoft.UI.WebControls.Controls.CheckBox();
			_showInSectionEdit.UId = new Guid("77e5c649-9784-4707-97c1-cbabe435dabe");
			_showInSectionEdit.Name = "ShowInSectionEdit";
			_showInSectionEdit.CreatedInSchemaUId = new Guid("93efee4c-26ad-4e27-a98a-aa00d16bdbf6");
			_showInSectionEdit.ModifiedInSchemaUId = new Guid("93efee4c-26ad-4e27-a98a-aa00d16bdbf6");
			_showInSectionEdit.CreatedInPackageId = new Guid("e98ccaae-0bf0-40d8-a40d-46418c204c90");
			_showInSectionEdit.Tag = "";
			_showInSectionEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_showInSectionEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_showInSectionEdit.DataSource = "DataSource";
			_showInSectionEdit.ColumnUId = new Guid("b3898251-9146-4f96-a287-eb72d3235ba3");
			return _showInSectionEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.CheckBox CreateShowInCardEdit() {
			_showInCardEdit = new Terrasoft.UI.WebControls.Controls.CheckBox();
			_showInCardEdit.UId = new Guid("942c3eb7-49bd-4957-8ecb-d4821c2b85eb");
			_showInCardEdit.Name = "ShowInCardEdit";
			_showInCardEdit.CreatedInSchemaUId = new Guid("93efee4c-26ad-4e27-a98a-aa00d16bdbf6");
			_showInCardEdit.ModifiedInSchemaUId = new Guid("93efee4c-26ad-4e27-a98a-aa00d16bdbf6");
			_showInCardEdit.CreatedInPackageId = new Guid("e98ccaae-0bf0-40d8-a40d-46418c204c90");
			_showInCardEdit.Tag = "";
			_showInCardEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_showInCardEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_showInCardEdit.DataSource = "DataSource";
			_showInCardEdit.ColumnUId = new Guid("ef0845ed-42fb-4507-a3b2-4aa835673289");
			return _showInCardEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateControlLayout1() {
			_controlLayout1 = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_controlLayout1.UId = new Guid("e023bd21-aee2-48f4-b84c-679d7a0769a3");
			_controlLayout1.Name = "ControlLayout1";
			_controlLayout1.CreatedInSchemaUId = new Guid("93efee4c-26ad-4e27-a98a-aa00d16bdbf6");
			_controlLayout1.ModifiedInSchemaUId = new Guid("93efee4c-26ad-4e27-a98a-aa00d16bdbf6");
			_controlLayout1.CreatedInPackageId = new Guid("e98ccaae-0bf0-40d8-a40d-46418c204c90");
			_controlLayout1.Tag = "";
			_controlLayout1.Height = System.Web.UI.WebControls.Unit.Pixel(50);
			_controlLayout1.Direction = Terrasoft.UI.WebControls.Direction.Horizontal;
			_controlLayout1.FitHeightByContent = true;
			_controlLayout1.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_controlLayout1.StartNewAlignGroup = false;
			_controlLayout1.Image = new ControlImage {};
			_controlLayout1.Edges = "";
			return _controlLayout1;
		}

		protected override void UpdateDataSource() {
			base.UpdateDataSource();
			DataSource.SchemaUId = new Guid("0a62cd3d-6541-4c5c-903f-e5b0fc665297");
			DataSource.ModifiedInSchemaUId = new Guid("93efee4c-26ad-4e27-a98a-aa00d16bdbf6");
			DataSourceStructureColumn column = null;
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ae0e45ca-c495-4fe7-a39d-3ab7278e1617");
			if (column != null) {
				column.UId = new Guid("9730295f-09b1-483d-8c3a-70dbf3bbc207");
				column.Name = @"Id";
				column.CreatedInSchemaUId = new Guid("93efee4c-26ad-4e27-a98a-aa00d16bdbf6");
				column.ModifiedInSchemaUId = new Guid("93efee4c-26ad-4e27-a98a-aa00d16bdbf6");
				column.CreatedInPackageId = Guid.Empty;
				column.IsAlwaysSelect = true;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("e80190a5-03b2-4095-90f7-a193a960adee");
			if (column != null) {
				column.UId = new Guid("ae649978-46e1-4383-bd6b-6daf9992c071");
				column.Name = @"CreatedOn";
				column.CreatedInSchemaUId = new Guid("93efee4c-26ad-4e27-a98a-aa00d16bdbf6");
				column.ModifiedInSchemaUId = new Guid("93efee4c-26ad-4e27-a98a-aa00d16bdbf6");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ebf6bb93-8aa6-4a01-900d-c6ea67affe21");
			if (column != null) {
				column.UId = new Guid("570a573a-b1c2-4d8c-a520-d1f03b19e407");
				column.Name = @"CreatedBy";
				column.CreatedInSchemaUId = new Guid("93efee4c-26ad-4e27-a98a-aa00d16bdbf6");
				column.ModifiedInSchemaUId = new Guid("93efee4c-26ad-4e27-a98a-aa00d16bdbf6");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9928edec-4272-425a-93bb-48743fee4b04");
			if (column != null) {
				column.UId = new Guid("45558d3f-8af2-46fc-a2a8-6ef5aecf2997");
				column.Name = @"ModifiedOn";
				column.CreatedInSchemaUId = new Guid("93efee4c-26ad-4e27-a98a-aa00d16bdbf6");
				column.ModifiedInSchemaUId = new Guid("93efee4c-26ad-4e27-a98a-aa00d16bdbf6");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3015559e-cbc6-406a-88af-07f7930be832");
			if (column != null) {
				column.UId = new Guid("4287541f-09dd-426f-bea4-6c93f9f7dfa2");
				column.Name = @"ModifiedBy";
				column.CreatedInSchemaUId = new Guid("93efee4c-26ad-4e27-a98a-aa00d16bdbf6");
				column.ModifiedInSchemaUId = new Guid("93efee4c-26ad-4e27-a98a-aa00d16bdbf6");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3fb83606-040e-4fdb-aeb6-a9357886dcb3");
			if (column != null) {
				column.UId = new Guid("e031fd13-13cb-44f7-96b9-80456b885f5b");
				column.Name = @"Caption";
				column.CreatedInSchemaUId = new Guid("93efee4c-26ad-4e27-a98a-aa00d16bdbf6");
				column.ModifiedInSchemaUId = new Guid("93efee4c-26ad-4e27-a98a-aa00d16bdbf6");
				column.CreatedInPackageId = Guid.Empty;
				column.OrderDirection = OrderDirection.Ascending;
				column.OrderPosition = 1;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("b6607c22-ca01-41f0-8637-610221a869b6");
			if (column != null) {
				column.UId = new Guid("edbcd345-f27a-40e5-a477-7e1f45da8373");
				column.Name = @"SysModule";
				column.CreatedInSchemaUId = new Guid("93efee4c-26ad-4e27-a98a-aa00d16bdbf6");
				column.ModifiedInSchemaUId = new Guid("93efee4c-26ad-4e27-a98a-aa00d16bdbf6");
				column.CreatedInPackageId = Guid.Empty;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("b99f16cb-925d-48f2-94e9-98f9eb249048");
			if (column != null) {
				column.UId = new Guid("c3973b44-af77-4ad4-9c3f-0b125fe33053");
				column.Name = @"AutoPreview";
				column.CreatedInSchemaUId = new Guid("93efee4c-26ad-4e27-a98a-aa00d16bdbf6");
				column.ModifiedInSchemaUId = new Guid("93efee4c-26ad-4e27-a98a-aa00d16bdbf6");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("5c6855ee-1bce-4a62-901b-50482def049b");
			if (column != null) {
				column.UId = new Guid("6eb709b4-7daf-4173-96f2-48345ccb4b78");
				column.Name = @"HelpContextId";
				column.CreatedInSchemaUId = new Guid("93efee4c-26ad-4e27-a98a-aa00d16bdbf6");
				column.ModifiedInSchemaUId = new Guid("93efee4c-26ad-4e27-a98a-aa00d16bdbf6");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3fabd836-6a53-4d8d-9069-6df88d9dae1e");
			if (column != null) {
				column.UId = new Guid("1543e935-0c60-41de-84b8-92aa474df550");
				column.Name = @"ProcessListeners";
				column.CreatedInSchemaUId = new Guid("93efee4c-26ad-4e27-a98a-aa00d16bdbf6");
				column.ModifiedInSchemaUId = new Guid("93efee4c-26ad-4e27-a98a-aa00d16bdbf6");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("aba36b7e-96c2-4005-a9b9-64ceee36aaac");
			if (column != null) {
				column.UId = new Guid("3b828cce-263a-4116-9d75-f2a729a443d0");
				column.Name = @"MacrosList";
				column.CreatedInSchemaUId = new Guid("93efee4c-26ad-4e27-a98a-aa00d16bdbf6");
				column.ModifiedInSchemaUId = new Guid("93efee4c-26ad-4e27-a98a-aa00d16bdbf6");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("94f2a9f7-55c7-4ecf-9b64-17583ddc058b");
			if (column != null) {
				column.UId = new Guid("603b9fa6-8fe8-446e-ab12-a690b7aff81b");
				column.Name = @"Type";
				column.CreatedInSchemaUId = new Guid("93efee4c-26ad-4e27-a98a-aa00d16bdbf6");
				column.ModifiedInSchemaUId = new Guid("93efee4c-26ad-4e27-a98a-aa00d16bdbf6");
				column.CreatedInPackageId = Guid.Empty;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("cb6b495c-384d-4a40-9f93-35c6dfb79a3b");
			if (column != null) {
				column.UId = new Guid("bdae1215-2f33-4257-bfd5-5b36841ab6e1");
				column.Name = @"File";
				column.CreatedInSchemaUId = new Guid("93efee4c-26ad-4e27-a98a-aa00d16bdbf6");
				column.ModifiedInSchemaUId = new Guid("93efee4c-26ad-4e27-a98a-aa00d16bdbf6");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("362bb0b0-d3da-4b01-abe6-a617e1b1257f");
			if (column != null) {
				column.UId = new Guid("38bdc9c5-3ea0-4441-94dd-05aee2b8ec30");
				column.Name = @"FileName";
				column.CreatedInSchemaUId = new Guid("93efee4c-26ad-4e27-a98a-aa00d16bdbf6");
				column.ModifiedInSchemaUId = new Guid("93efee4c-26ad-4e27-a98a-aa00d16bdbf6");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("8e01622f-e04b-480a-859a-01df55c30729");
			if (column != null) {
				column.UId = new Guid("f2b3c762-27ad-449c-83b9-6a9bfa8ada0b");
				column.Name = @"SysReportSchemaUId";
				column.CreatedInSchemaUId = new Guid("93efee4c-26ad-4e27-a98a-aa00d16bdbf6");
				column.ModifiedInSchemaUId = new Guid("93efee4c-26ad-4e27-a98a-aa00d16bdbf6");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("1f17f6cb-8a86-408c-9207-d2f8b22ae1b7");
			if (column != null) {
				column.UId = new Guid("7d16473e-03b4-491a-839b-4c6d809af259");
				column.Name = @"SysOptionsPageSchemaUId";
				column.CreatedInSchemaUId = new Guid("93efee4c-26ad-4e27-a98a-aa00d16bdbf6");
				column.ModifiedInSchemaUId = new Guid("93efee4c-26ad-4e27-a98a-aa00d16bdbf6");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9a75dacc-e0b6-456c-af91-1a1a369eaa3b");
			if (column != null) {
				column.UId = new Guid("ef0845ed-42fb-4507-a3b2-4aa835673289");
				column.Name = @"ShowInCard";
				column.CreatedInSchemaUId = new Guid("93efee4c-26ad-4e27-a98a-aa00d16bdbf6");
				column.ModifiedInSchemaUId = new Guid("93efee4c-26ad-4e27-a98a-aa00d16bdbf6");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3b976c18-5bfe-482a-8ac1-a9377075a627");
			if (column != null) {
				column.UId = new Guid("b3898251-9146-4f96-a287-eb72d3235ba3");
				column.Name = @"ShowInSection";
				column.CreatedInSchemaUId = new Guid("93efee4c-26ad-4e27-a98a-aa00d16bdbf6");
				column.ModifiedInSchemaUId = new Guid("93efee4c-26ad-4e27-a98a-aa00d16bdbf6");
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
			return new SysModuleReportDevExpressEditPageSchemaUserControl();
		}

		public override object Clone() {
			return new SysModuleReportDevExpressEditPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("93efee4c-26ad-4e27-a98a-aa00d16bdbf6"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new SysModuleReportDevExpressEditPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: SysModuleReportDevExpressEditPageEventsProcess

	/// <exclude/>
	public class SysModuleReportDevExpressEditPageEventsProcess<TPage> : Terrasoft.WebApp.BaseEditPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.SysModuleReportDevExpressEditPageSchemaUserControl
	{

		public SysModuleReportDevExpressEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SysModuleReportDevExpressEditPageEventsProcess";
			SchemaUId = new Guid("93efee4c-26ad-4e27-a98a-aa00d16bdbf6");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("93efee4c-26ad-4e27-a98a-aa00d16bdbf6");
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

		private ProcessFlowElement _eventSubProcess3;
		public ProcessFlowElement EventSubProcess3 {
			get {
				return _eventSubProcess3 ?? (_eventSubProcess3 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess3",
					SchemaElementUId = new Guid("e1b6a391-da7b-4c2e-8231-539dc8d450bf"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _sysPageSchemaEditChangeMessage;
		public ProcessFlowElement SysPageSchemaEditChangeMessage {
			get {
				return _sysPageSchemaEditChangeMessage ?? (_sysPageSchemaEditChangeMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "SysPageSchemaEditChangeMessage",
					SchemaElementUId = new Guid("08c98535-fd11-4187-bc74-6e4dd9be4882"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _sysPageSchemaEditChangeScriptTask;
		public ProcessScriptTask SysPageSchemaEditChangeScriptTask {
			get {
				return _sysPageSchemaEditChangeScriptTask ?? (_sysPageSchemaEditChangeScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "SysPageSchemaEditChangeScriptTask",
					SchemaElementUId = new Guid("0fabdf68-6c20-46a2-8f2a-1cbfaf9c2bec"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = SysPageSchemaEditChangeScriptTaskExecute,
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
					SchemaElementUId = new Guid("048048fc-d6e1-4a7c-9f34-e7187182017a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _sysOptionsPageSchemaEditChangeMessage;
		public ProcessFlowElement SysOptionsPageSchemaEditChangeMessage {
			get {
				return _sysOptionsPageSchemaEditChangeMessage ?? (_sysOptionsPageSchemaEditChangeMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "SysOptionsPageSchemaEditChangeMessage",
					SchemaElementUId = new Guid("baca41cc-5771-480d-82eb-ace105774886"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _sysOptionsPageSchemaEditChangeScriptTask;
		public ProcessScriptTask SysOptionsPageSchemaEditChangeScriptTask {
			get {
				return _sysOptionsPageSchemaEditChangeScriptTask ?? (_sysOptionsPageSchemaEditChangeScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "SysOptionsPageSchemaEditChangeScriptTask",
					SchemaElementUId = new Guid("4410d489-a89b-4066-a44b-00058685f54a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = SysOptionsPageSchemaEditChangeScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcess6;
		public ProcessFlowElement EventSubProcess6 {
			get {
				return _eventSubProcess6 ?? (_eventSubProcess6 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess6",
					SchemaElementUId = new Guid("fb33e7d7-b193-46c5-b58a-8b55cd0df232"),
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
					SchemaElementUId = new Guid("d81e37bb-4e40-4e47-ab81-94ed8844a216"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTask3;
		public ProcessScriptTask ScriptTask3 {
			get {
				return _scriptTask3 ?? (_scriptTask3 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask3",
					SchemaElementUId = new Guid("55e1637c-b00c-4d89-ae69-34748a40eccd"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask3Execute,
				});
			}
		}

		private ProcessThrowMessageEvent _intermediateThrowMessageEvent1;
		public ProcessThrowMessageEvent IntermediateThrowMessageEvent1 {
			get {
				return _intermediateThrowMessageEvent1 ?? (_intermediateThrowMessageEvent1 = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "IntermediateThrowMessageEvent1",
					SchemaElementUId = new Guid("065375d1-d5ab-45da-801d-ff3ea621e2ab"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "PageLoadComplete",
						ThrowToBase = true,
				});
			}
		}

		private ProcessFlowElement _eventSubProcessChildInit;
		public ProcessFlowElement EventSubProcessChildInit {
			get {
				return _eventSubProcessChildInit ?? (_eventSubProcessChildInit = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcessChildInit",
					SchemaElementUId = new Guid("34cb8f3a-fb39-4628-b947-de9e46d9cfff"),
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
					SchemaElementUId = new Guid("03154a56-0fd8-41a8-9ed7-7a47a85fc1e1"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptChildInitExecute,
				});
			}
		}

		private ProcessThrowMessageEvent _baseInit;
		public ProcessThrowMessageEvent BaseInit {
			get {
				return _baseInit ?? (_baseInit = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "BaseInit",
					SchemaElementUId = new Guid("b11b8f7c-3bf3-41e7-8663-72184f063580"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "Init",
						ThrowToBase = true,
				});
			}
		}

		private ProcessFlowElement _childInit;
		public ProcessFlowElement ChildInit {
			get {
				return _childInit ?? (_childInit = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "ChildInit",
					SchemaElementUId = new Guid("29a0605f-4610-4390-8ace-129442026bc0"),
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
					SchemaElementUId = new Guid("3cafa6ea-f77e-4fef-bd01-3ffb47bf0ca8"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessageChildDataSourceSaved;
		public ProcessFlowElement StartMessageChildDataSourceSaved {
			get {
				return _startMessageChildDataSourceSaved ?? (_startMessageChildDataSourceSaved = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessageChildDataSourceSaved",
					SchemaElementUId = new Guid("258fe680-423d-46ea-91d8-6f9fd45f3cc6"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessThrowMessageEvent _startMessageBaseDataSourceSaved;
		public ProcessThrowMessageEvent StartMessageBaseDataSourceSaved {
			get {
				return _startMessageBaseDataSourceSaved ?? (_startMessageBaseDataSourceSaved = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "StartMessageBaseDataSourceSaved",
					SchemaElementUId = new Guid("ffa1896a-ab80-4a15-8702-a66caf88b009"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "DataSourceSaved",
						ThrowToBase = true,
				});
			}
		}

		private ProcessScriptTask _dataSourceSavedScriptTask;
		public ProcessScriptTask DataSourceSavedScriptTask {
			get {
				return _dataSourceSavedScriptTask ?? (_dataSourceSavedScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "DataSourceSavedScriptTask",
					SchemaElementUId = new Guid("180c0f81-9829-426f-83a2-3867f909a78c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = DataSourceSavedScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcess5_9007bcca390046fea55727290121bdab;
		public ProcessFlowElement EventSubProcess5_9007bcca390046fea55727290121bdab {
			get {
				return _eventSubProcess5_9007bcca390046fea55727290121bdab ?? (_eventSubProcess5_9007bcca390046fea55727290121bdab = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess5_9007bcca390046fea55727290121bdab",
					SchemaElementUId = new Guid("9007bcca-3900-46fe-a557-27290121bdab"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessage2_ee8740d298634857afa5a327d7f3b5af;
		public ProcessFlowElement StartMessage2_ee8740d298634857afa5a327d7f3b5af {
			get {
				return _startMessage2_ee8740d298634857afa5a327d7f3b5af ?? (_startMessage2_ee8740d298634857afa5a327d7f3b5af = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessage2_ee8740d298634857afa5a327d7f3b5af",
					SchemaElementUId = new Guid("ee8740d2-9863-4857-afa5-a327d7f3b5af"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTask4_7f7519259eb8429fbd804e51f07fac88;
		public ProcessScriptTask ScriptTask4_7f7519259eb8429fbd804e51f07fac88 {
			get {
				return _scriptTask4_7f7519259eb8429fbd804e51f07fac88 ?? (_scriptTask4_7f7519259eb8429fbd804e51f07fac88 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask4_7f7519259eb8429fbd804e51f07fac88",
					SchemaElementUId = new Guid("7f751925-9eb8-429f-bd80-4e51f07fac88"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask4_7f7519259eb8429fbd804e51f07fac88Execute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess3.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess3 };
			FlowElements[SysPageSchemaEditChangeMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { SysPageSchemaEditChangeMessage };
			FlowElements[SysPageSchemaEditChangeScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { SysPageSchemaEditChangeScriptTask };
			FlowElements[EventSubProcess2.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess2 };
			FlowElements[SysOptionsPageSchemaEditChangeMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { SysOptionsPageSchemaEditChangeMessage };
			FlowElements[SysOptionsPageSchemaEditChangeScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { SysOptionsPageSchemaEditChangeScriptTask };
			FlowElements[EventSubProcess6.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess6 };
			FlowElements[StartMessage3.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage3 };
			FlowElements[ScriptTask3.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask3 };
			FlowElements[IntermediateThrowMessageEvent1.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowMessageEvent1 };
			FlowElements[EventSubProcessChildInit.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcessChildInit };
			FlowElements[ScriptChildInit.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptChildInit };
			FlowElements[BaseInit.SchemaElementUId] = new Collection<ProcessFlowElement> { BaseInit };
			FlowElements[ChildInit.SchemaElementUId] = new Collection<ProcessFlowElement> { ChildInit };
			FlowElements[EventSubProcess1.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess1 };
			FlowElements[StartMessageChildDataSourceSaved.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessageChildDataSourceSaved };
			FlowElements[StartMessageBaseDataSourceSaved.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessageBaseDataSourceSaved };
			FlowElements[DataSourceSavedScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { DataSourceSavedScriptTask };
			FlowElements[EventSubProcess5_9007bcca390046fea55727290121bdab.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess5_9007bcca390046fea55727290121bdab };
			FlowElements[StartMessage2_ee8740d298634857afa5a327d7f3b5af.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage2_ee8740d298634857afa5a327d7f3b5af };
			FlowElements[ScriptTask4_7f7519259eb8429fbd804e51f07fac88.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask4_7f7519259eb8429fbd804e51f07fac88 };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess3":
						break;
					case "SysPageSchemaEditChangeMessage":
						e.Context.QueueTasks.Enqueue("SysPageSchemaEditChangeScriptTask");
						break;
					case "SysPageSchemaEditChangeScriptTask":
						break;
					case "EventSubProcess2":
						break;
					case "SysOptionsPageSchemaEditChangeMessage":
						e.Context.QueueTasks.Enqueue("SysOptionsPageSchemaEditChangeScriptTask");
						break;
					case "SysOptionsPageSchemaEditChangeScriptTask":
						break;
					case "EventSubProcess6":
						break;
					case "StartMessage3":
						e.Context.QueueTasks.Enqueue("IntermediateThrowMessageEvent1");
						break;
					case "ScriptTask3":
						break;
					case "IntermediateThrowMessageEvent1":
						e.Context.QueueTasks.Enqueue("ScriptTask3");
						break;
					case "EventSubProcessChildInit":
						break;
					case "ScriptChildInit":
						break;
					case "BaseInit":
						e.Context.QueueTasks.Enqueue("ScriptChildInit");
						break;
					case "ChildInit":
						e.Context.QueueTasks.Enqueue("BaseInit");
						break;
					case "EventSubProcess1":
						break;
					case "StartMessageChildDataSourceSaved":
						e.Context.QueueTasks.Enqueue("StartMessageBaseDataSourceSaved");
						break;
					case "StartMessageBaseDataSourceSaved":
						e.Context.QueueTasks.Enqueue("DataSourceSavedScriptTask");
						break;
					case "DataSourceSavedScriptTask":
						break;
					case "EventSubProcess5_9007bcca390046fea55727290121bdab":
						break;
					case "StartMessage2_ee8740d298634857afa5a327d7f3b5af":
						e.Context.QueueTasks.Enqueue("ScriptTask4_7f7519259eb8429fbd804e51f07fac88");
						break;
					case "ScriptTask4_7f7519259eb8429fbd804e51f07fac88":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("SysPageSchemaEditChangeMessage");
			ActivatedEventElements.Add("SysOptionsPageSchemaEditChangeMessage");
			ActivatedEventElements.Add("StartMessage3");
			ActivatedEventElements.Add("ChildInit");
			ActivatedEventElements.Add("StartMessageChildDataSourceSaved");
			ActivatedEventElements.Add("StartMessage2_ee8740d298634857afa5a327d7f3b5af");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "EventSubProcess3":
					context.QueueTasks.Dequeue();
					break;
				case "SysPageSchemaEditChangeMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "SysPageSchemaEditChangeMessage";
					result = SysPageSchemaEditChangeMessage.Execute(context);
					break;
				case "SysPageSchemaEditChangeScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "SysPageSchemaEditChangeScriptTask";
					result = SysPageSchemaEditChangeScriptTask.Execute(context, SysPageSchemaEditChangeScriptTaskExecute);
					break;
				case "EventSubProcess2":
					context.QueueTasks.Dequeue();
					break;
				case "SysOptionsPageSchemaEditChangeMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "SysOptionsPageSchemaEditChangeMessage";
					result = SysOptionsPageSchemaEditChangeMessage.Execute(context);
					break;
				case "SysOptionsPageSchemaEditChangeScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "SysOptionsPageSchemaEditChangeScriptTask";
					result = SysOptionsPageSchemaEditChangeScriptTask.Execute(context, SysOptionsPageSchemaEditChangeScriptTaskExecute);
					break;
				case "EventSubProcess6":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage3":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage3";
					result = StartMessage3.Execute(context);
					break;
				case "ScriptTask3":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask3";
					result = ScriptTask3.Execute(context, ScriptTask3Execute);
					break;
				case "IntermediateThrowMessageEvent1":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "PageLoadComplete");
					result = IntermediateThrowMessageEvent1.Execute(context);
					break;
				case "EventSubProcessChildInit":
					context.QueueTasks.Dequeue();
					break;
				case "ScriptChildInit":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptChildInit";
					result = ScriptChildInit.Execute(context, ScriptChildInitExecute);
					break;
				case "BaseInit":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "Init");
					result = BaseInit.Execute(context);
					break;
				case "ChildInit":
					context.QueueTasks.Dequeue();
					context.SenderName = "ChildInit";
					result = ChildInit.Execute(context);
					break;
				case "EventSubProcess1":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessageChildDataSourceSaved":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessageChildDataSourceSaved";
					result = StartMessageChildDataSourceSaved.Execute(context);
					break;
				case "StartMessageBaseDataSourceSaved":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "DataSourceSaved");
					result = StartMessageBaseDataSourceSaved.Execute(context);
					break;
				case "DataSourceSavedScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "DataSourceSavedScriptTask";
					result = DataSourceSavedScriptTask.Execute(context, DataSourceSavedScriptTaskExecute);
					break;
				case "EventSubProcess5_9007bcca390046fea55727290121bdab":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage2_ee8740d298634857afa5a327d7f3b5af":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage2_ee8740d298634857afa5a327d7f3b5af";
					result = StartMessage2_ee8740d298634857afa5a327d7f3b5af.Execute(context);
					break;
				case "ScriptTask4_7f7519259eb8429fbd804e51f07fac88":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask4_7f7519259eb8429fbd804e51f07fac88";
					result = ScriptTask4_7f7519259eb8429fbd804e51f07fac88.Execute(context, ScriptTask4_7f7519259eb8429fbd804e51f07fac88Execute);
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

		public virtual bool SysPageSchemaEditChangeScriptTaskExecute(ProcessExecutingContext context) {
			var row = Page.DataSource.ActiveRow;
			row.SetColumnValue("SysReportSchemaUId", Page.SysPageSchemaEdit.Value );
			return true;
		}

		public virtual bool SysOptionsPageSchemaEditChangeScriptTaskExecute(ProcessExecutingContext context) {
			var row = Page.DataSource.ActiveRow;
			row.SetColumnValue("SysOptionsPageSchemaUId", Page.SysOptionsPageSchemaEdit.Value );
			return true;
		}

		public virtual bool ScriptTask3Execute(ProcessExecutingContext context) {
			var useReportGenerationBasedOnSchema = GlobalAppSettings.UseReportGenerationBasedOnSchema;
			if (useReportGenerationBasedOnSchema) {
				Page.ReportTemplateEdit.Required = false;
				Page.ReportTemplateEdit.Hidden = true;
			} else {
				Page.SysPageSchemaEdit.Required = false;
				Page.SysPageSchemaEdit.Hidden = true;
			}
			if (Page.DataSource.ActiveRow != null) {
				Entity currentRow = Page.DataSource.ActiveRow;
				var schemaColumn = currentRow.Schema.Columns.GetByName("SysReportSchemaUId");
				var sysPageSchemaId  = currentRow.GetTypedColumnValue<Guid>(schemaColumn.ColumnValueName);
				if (useReportGenerationBasedOnSchema) {
					Page.SysPageSchemaEdit.SetValueAndText(sysPageSchemaId, GetSchemaDisplayValue(sysPageSchemaId));
				} else {
					var devExpressReport = new Terrasoft.Configuration.DevExpressReport(UserConnection);
					if (devExpressReport.FetchFromDB(sysPageSchemaId)) {
						Page.ReportTemplateEdit.SetValueAndText(sysPageSchemaId, devExpressReport.Caption);
					}
				}
				var optionsSchemaColumn = currentRow.Schema.Columns.GetByName("SysOptionsPageSchemaUId");
				var sysOptionsPageSchemaIdObj  = currentRow.GetColumnValue(optionsSchemaColumn.ColumnValueName);
				if (sysOptionsPageSchemaIdObj != null) {
					var sysOptionsPageSchemaId = (Guid)sysOptionsPageSchemaIdObj;
					Page.SysOptionsPageSchemaEdit.SetValueAndText(sysOptionsPageSchemaId, GetSchemaDisplayValue(sysOptionsPageSchemaId));
				}
			}
			Page.OKButton.AjaxEvents.Click.CausesValidation = true;
			Page.CaptionEdit.LocalizableText = 
				Terrasoft.Configuration.CommonUtilities.GetLocalizableValue(UserConnection, Page.DataSource.Schema.Name, "Caption", Page.DataSource.ActiveRowPrimaryColumnValue);
			return true;
		}

		public virtual bool ScriptChildInitExecute(ProcessExecutingContext context) {
			string reportSchemaManagerName = Page.UserConnection.GetReportSchemaManagerName();
			Page.SysPageSchemaEdit.PrepareLookupFilter += delegate (object sender, LookupEditEventArgs e) {
				Collection<Dictionary<string, object>> filters = e.Filters;
				//Код, который компилируется только в Workspace CR173606 173547
				filters.Add(new Dictionary<string, object> { 
					{"comparisonType", FilterComparisonType.Equal}, 
					{"leftExpressionColumnPath", "SysWorkspace.Id"},
					{"useDisplayValue", false}, 
					{"rightExpressionParameterValues", new object[] {Page.UserConnection.Workspace.Id}}});
				filters.Add(new Dictionary<string, object> { 
					{"comparisonType", FilterComparisonType.Equal}, 
					{"leftExpressionColumnPath", "ManagerName"},
					{"useDisplayValue", false}, 
					{"rightExpressionParameterValues", new object[] {reportSchemaManagerName}}});
			};
			
			Page.SysOptionsPageSchemaEdit.PrepareLookupFilter += delegate (object sender, LookupEditEventArgs e) {
				Collection<Dictionary<string, object>> filters = e.Filters;
				//Код, который компилируется только в Workspace CR173606 173547
				filters.Add(new Dictionary<string, object> { 
					{"comparisonType", FilterComparisonType.Equal}, 
					{"leftExpressionColumnPath", "SysWorkspace.Id"},
					{"useDisplayValue", false}, 
					{"rightExpressionParameterValues", new object[] {Page.UserConnection.Workspace.Id}}});
				filters.Add(new Dictionary<string, object> { 
					{"comparisonType", FilterComparisonType.Equal}, 
					{"leftExpressionColumnPath", "ManagerName"},
					{"useDisplayValue", false}, 
					{"rightExpressionParameterValues", new object[] {"PageSchemaManager"}}});
			};
			
			Page.DataSource.BeforeSaveRow +=
			 delegate(object sender, DataSourceEventArgs e) {
				e.Row.SetColumnValue("TypeId", new Guid("32F72C9C-72C7-44E0-8C84-34C9ED17CA50"));
			};
			
			
			return true;
		}

		public virtual bool DataSourceSavedScriptTaskExecute(ProcessExecutingContext context) {
			Terrasoft.Configuration.CommonUtilities.SaveLocalizableValue(Page.DataSource.ActiveRow, Page.CaptionEdit.LocalizableText, "Caption");
			Terrasoft.Configuration.SysModuleFolderUtilities.ResetModuleReportCache(UserConnection.SessionCache.WithLocalCaching(Terrasoft.Configuration.CacheUtilities.WorkspaceCacheGroup));
			return true;
		}

		public virtual bool ScriptTask4_7f7519259eb8429fbd804e51f07fac88Execute(ProcessExecutingContext context) {
			Page.DataSource.ActiveRow.SetColumnValue("SysReportSchemaUId", Page.ReportTemplateEdit.Value);
			return true;
		}

		public override void OkClickMethod() {
			var primaryCultureinfo = UserConnection.GetPrimaryCultureInfo();
			if(!Page.CaptionEdit.LocalizableText.HasCultureValue(primaryCultureinfo)) {
				Page.CaptionEdit.LocalizableText.SetCultureValue(primaryCultureinfo, Page.CaptionEdit.LocalizableText);
			}
			string caption = Page.CaptionEdit.LocalizableText.GetCultureValue(UserConnection.GetPrimaryCultureInfo());
			var converters = new JsonConverter[] {new GuidJsonConverter()};
			string id = Json.Serialize(Page.DataSource.ActiveRow.PrimaryColumnValue, converters[0]);
			Page.ScriptManager.AddScript(Page.DataSource.ClientID + 
					".onActiveRowColumnValuesChangedResponse(" 
					 + id + ",{\"Caption\" : {columnValue: "
					 + Json.Serialize(caption) + "}});");
			base.OkClickMethod();
		}

		public override bool GetIsContextHelpButtonHidden() {
			return false;
		}

		public virtual string GetSchemaDisplayValue(Guid recordId) {
			// TODO #170713
			var entitySchemaManager = Page.Schema.SchemaManagerProvider.GetManager("EntitySchemaManager") as Terrasoft.Core.Entities.EntitySchemaManager;
			var entitySchemaQuery = new EntitySchemaQuery(entitySchemaManager, "VwSysSchemaInfo");
			var captionColumnName = entitySchemaQuery.AddColumn("Caption").Name;
			entitySchemaQuery.Filters.Add(entitySchemaQuery.CreateFilterWithParameters(FilterComparisonType.Equal,
				entitySchemaQuery.RootSchema.GetPrimaryColumnName(), recordId));
			//Код, который компилируется только в Workspace CR173606
			entitySchemaQuery.Filters.Add(entitySchemaQuery.CreateFilterWithParameters(FilterComparisonType.Equal,
				"SysWorkspace", UserConnection.Workspace.Id));
			var entities = entitySchemaQuery.GetEntityCollection(UserConnection);
			if (entities.Count > 0) {
				return entities[0].GetTypedColumnValue<string>(captionColumnName);
			} else {
				return string.Empty;
			}
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "SysPageSchemaEditChange":
							if (ActivatedEventElements.Contains("SysPageSchemaEditChangeMessage")) {
							context.QueueTasks.Enqueue("SysPageSchemaEditChangeMessage");
						}
						break;
					case "SysOptionsPageSchemaEditChange":
							if (ActivatedEventElements.Contains("SysOptionsPageSchemaEditChangeMessage")) {
							context.QueueTasks.Enqueue("SysOptionsPageSchemaEditChangeMessage");
						}
						break;
					case "PageLoadComplete":
							if (ActivatedEventElements.Contains("StartMessage3")) {
							context.QueueTasks.Enqueue("StartMessage3");
							ProcessQueue(context);
							return;
						}
						break;
					case "Init":
							if (ActivatedEventElements.Contains("ChildInit")) {
							context.QueueTasks.Enqueue("ChildInit");
							ProcessQueue(context);
							return;
						}
						break;
					case "DataSourceSaved":
							if (ActivatedEventElements.Contains("StartMessageChildDataSourceSaved")) {
							context.QueueTasks.Enqueue("StartMessageChildDataSourceSaved");
							ProcessQueue(context);
							return;
						}
						break;
					case "ReportTemplateEditChange":
							if (ActivatedEventElements.Contains("StartMessage2_ee8740d298634857afa5a327d7f3b5af")) {
							context.QueueTasks.Enqueue("StartMessage2_ee8740d298634857afa5a327d7f3b5af");
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

	#region Class: SysModuleReportDevExpressEditPageEventsProcess

	/// <exclude/>
	public class SysModuleReportDevExpressEditPageEventsProcess : SysModuleReportDevExpressEditPageEventsProcess<Terrasoft.WebApp.SysModuleReportDevExpressEditPageSchemaUserControl>
	{

		public SysModuleReportDevExpressEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SysModuleReportDevExpressEditPageSchemaUserControl

	/// <exclude/>
	public partial class SysModuleReportDevExpressEditPageSchemaUserControl : Terrasoft.WebApp.BaseEditPageSchemaUserControl
	{

		#region Properties: Public

		public Terrasoft.UI.WebControls.Controls.LocalizableTextEdit CaptionEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.LocalizableTextEdit)PageContainer.FindPageControl("CaptionEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.LookupEdit SysModuleEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.LookupEdit)PageContainer.FindPageControl("SysModuleEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.LookupEdit SysPageSchemaEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.LookupEdit)PageContainer.FindPageControl("SysPageSchemaEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.LookupEdit ReportTemplateEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.LookupEdit)PageContainer.FindPageControl("ReportTemplateEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.LookupEdit SysOptionsPageSchemaEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.LookupEdit)PageContainer.FindPageControl("SysOptionsPageSchemaEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlLayout1 {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("ControlLayout1", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.CheckBox ShowInSectionEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.CheckBox)PageContainer.FindPageControl("ShowInSectionEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.CheckBox ShowInCardEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.CheckBox)PageContainer.FindPageControl("ShowInCardEdit", true);
			}
		}

		#endregion

		#region Methods: Protected

		protected override void SubscribeOnControlEvents() {
			base.SubscribeOnControlEvents();
			SysPageSchemaEdit.AjaxEvents.Change.Event += SysPageSchemaEditChange;
			ReportTemplateEdit.AjaxEvents.Change.Event += ReportTemplateEditChange;
			SysOptionsPageSchemaEdit.AjaxEvents.Change.Event += SysOptionsPageSchemaEditChange;
		}

		protected override void UnsubscribeOnControlEvents() {
			base.UnsubscribeOnControlEvents();
			SysPageSchemaEdit.AjaxEvents.Change.Event -= SysPageSchemaEditChange;
			ReportTemplateEdit.AjaxEvents.Change.Event -= ReportTemplateEditChange;
			SysOptionsPageSchemaEdit.AjaxEvents.Change.Event -= SysOptionsPageSchemaEditChange;
		}

		protected override void InitializeEmbeddedProcess() {
			var instanceId = ((Terrasoft.UI.WebControls.Page)Page).InstanceId.ToString();
			string processUId = instanceId + PageContainer.UniqueID;
			var process = (SysModuleReportDevExpressEditPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new SysModuleReportDevExpressEditPageEventsProcess(UserConnection);
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

		public virtual void SysPageSchemaEditChange(object sender, EventArgs e) {
			object result = ThrowEvent("SysPageSchemaEditChange");
		}

		public virtual void ReportTemplateEditChange(object sender, EventArgs e) {
			object result = ThrowEvent("ReportTemplateEditChange");
		}

		public virtual void SysOptionsPageSchemaEditChange(object sender, EventArgs e) {
			object result = ThrowEvent("SysOptionsPageSchemaEditChange");
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
			SchemaName = "SysModuleReportDevExpressEditPage";
		}

		#endregion

	}

	#endregion

	#region Class: SysModuleReportDevExpressEditPageEventsProcessSchema

	/// <exclude/>
	public class SysModuleReportDevExpressEditPageEventsProcessSchema : Terrasoft.WebApp.BaseEditPageEventsProcessSchema
	{

		#region Constructors: Public

		public SysModuleReportDevExpressEditPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public SysModuleReportDevExpressEditPageEventsProcessSchema(SysModuleReportDevExpressEditPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "SysModuleReportDevExpressEditPageEventsProcess";
			UId = new Guid("0fcda8f3-0a1b-447b-a958-742d6e51f209");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet156 = CreateLaneSet156LaneSet();
			LaneSets.Add(schemaLaneSet156);
			ProcessSchemaLane schemaLane3 = CreateLane3Lane();
			schemaLaneSet156.Lanes.Add(schemaLane3);
			ProcessSchemaEventSubProcess eventsubprocess3 = CreateEventSubProcess3EventSubProcess();
			FlowElements.Add(eventsubprocess3);
			ProcessSchemaEventSubProcess eventsubprocess2 = CreateEventSubProcess2EventSubProcess();
			FlowElements.Add(eventsubprocess2);
			ProcessSchemaEventSubProcess eventsubprocess6 = CreateEventSubProcess6EventSubProcess();
			FlowElements.Add(eventsubprocess6);
			ProcessSchemaEventSubProcess eventsubprocesschildinit = CreateEventSubProcessChildInitEventSubProcess();
			FlowElements.Add(eventsubprocesschildinit);
			ProcessSchemaEventSubProcess eventsubprocess1 = CreateEventSubProcess1EventSubProcess();
			FlowElements.Add(eventsubprocess1);
			ProcessSchemaEventSubProcess eventsubprocess5_9007bcca390046fea55727290121bdab = CreateEventSubProcess5_9007bcca390046fea55727290121bdabEventSubProcess();
			FlowElements.Add(eventsubprocess5_9007bcca390046fea55727290121bdab);
			ProcessSchemaStartMessageEvent syspageschemaeditchangemessage = CreateSysPageSchemaEditChangeMessageStartMessageEvent();
			eventsubprocess3.FlowElements.Add(syspageschemaeditchangemessage);
			ProcessSchemaScriptTask syspageschemaeditchangescripttask = CreateSysPageSchemaEditChangeScriptTaskScriptTask();
			eventsubprocess3.FlowElements.Add(syspageschemaeditchangescripttask);
			ProcessSchemaStartMessageEvent sysoptionspageschemaeditchangemessage = CreateSysOptionsPageSchemaEditChangeMessageStartMessageEvent();
			eventsubprocess2.FlowElements.Add(sysoptionspageschemaeditchangemessage);
			ProcessSchemaScriptTask sysoptionspageschemaeditchangescripttask = CreateSysOptionsPageSchemaEditChangeScriptTaskScriptTask();
			eventsubprocess2.FlowElements.Add(sysoptionspageschemaeditchangescripttask);
			ProcessSchemaStartMessageEvent startmessage3 = CreateStartMessage3StartMessageEvent();
			eventsubprocess6.FlowElements.Add(startmessage3);
			ProcessSchemaScriptTask scripttask3 = CreateScriptTask3ScriptTask();
			eventsubprocess6.FlowElements.Add(scripttask3);
			ProcessSchemaIntermediateThrowMessageEvent intermediatethrowmessageevent1 = CreateIntermediateThrowMessageEvent1IntermediateThrowMessageEvent();
			eventsubprocess6.FlowElements.Add(intermediatethrowmessageevent1);
			ProcessSchemaScriptTask scriptchildinit = CreateScriptChildInitScriptTask();
			eventsubprocesschildinit.FlowElements.Add(scriptchildinit);
			ProcessSchemaIntermediateThrowMessageEvent baseinit = CreateBaseInitIntermediateThrowMessageEvent();
			eventsubprocesschildinit.FlowElements.Add(baseinit);
			ProcessSchemaStartMessageEvent childinit = CreateChildInitStartMessageEvent();
			eventsubprocesschildinit.FlowElements.Add(childinit);
			ProcessSchemaStartMessageEvent startmessagechilddatasourcesaved = CreateStartMessageChildDataSourceSavedStartMessageEvent();
			eventsubprocess1.FlowElements.Add(startmessagechilddatasourcesaved);
			ProcessSchemaIntermediateThrowMessageEvent startmessagebasedatasourcesaved = CreateStartMessageBaseDataSourceSavedIntermediateThrowMessageEvent();
			eventsubprocess1.FlowElements.Add(startmessagebasedatasourcesaved);
			ProcessSchemaScriptTask datasourcesavedscripttask = CreateDataSourceSavedScriptTaskScriptTask();
			eventsubprocess1.FlowElements.Add(datasourcesavedscripttask);
			ProcessSchemaStartMessageEvent startmessage2_ee8740d298634857afa5a327d7f3b5af = CreateStartMessage2_ee8740d298634857afa5a327d7f3b5afStartMessageEvent();
			eventsubprocess5_9007bcca390046fea55727290121bdab.FlowElements.Add(startmessage2_ee8740d298634857afa5a327d7f3b5af);
			ProcessSchemaScriptTask scripttask4_7f7519259eb8429fbd804e51f07fac88 = CreateScriptTask4_7f7519259eb8429fbd804e51f07fac88ScriptTask();
			eventsubprocess5_9007bcca390046fea55727290121bdab.FlowElements.Add(scripttask4_7f7519259eb8429fbd804e51f07fac88);
			FlowElements.Add(CreateSequenceFlow2854SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2855SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2858SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2859SequenceFlow());
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
			FlowElements.Add(CreateSequenceFlow4SequenceFlow());
			FlowElements.Add(CreateSequenceFlow8_dd8df5d868a549ca9eaecd576bc428c3SequenceFlow());
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2854SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2854",
				UId = new Guid("d551260b-6f9c-4551-96bb-57cf78625742"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("0fcda8f3-0a1b-447b-a958-742d6e51f209"),
				CurveCenterPosition = new Point(169, 399),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("0fcda8f3-0a1b-447b-a958-742d6e51f209"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("065375d1-d5ab-45da-801d-ff3ea621e2ab"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("55e1637c-b00c-4d89-ae69-34748a40eccd"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2855SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2855",
				UId = new Guid("661fb702-47b1-4733-a4f4-b5b1ea9c4ab7"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("0fcda8f3-0a1b-447b-a958-742d6e51f209"),
				CurveCenterPosition = new Point(169, 399),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("0fcda8f3-0a1b-447b-a958-742d6e51f209"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("d81e37bb-4e40-4e47-ab81-94ed8844a216"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("065375d1-d5ab-45da-801d-ff3ea621e2ab"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2858SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2858",
				UId = new Guid("9c654753-1877-40be-90e2-5a0c6dfbc1d3"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("0fcda8f3-0a1b-447b-a958-742d6e51f209"),
				CurveCenterPosition = new Point(212, 572),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("0fcda8f3-0a1b-447b-a958-742d6e51f209"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("b11b8f7c-3bf3-41e7-8663-72184f063580"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("03154a56-0fd8-41a8-9ed7-7a47a85fc1e1"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2859SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2859",
				UId = new Guid("b3f1c09e-2d73-4539-81bb-f32efe24f87f"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("0fcda8f3-0a1b-447b-a958-742d6e51f209"),
				CurveCenterPosition = new Point(128, 574),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("0fcda8f3-0a1b-447b-a958-742d6e51f209"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("29a0605f-4610-4390-8ace-129442026bc0"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("b11b8f7c-3bf3-41e7-8663-72184f063580"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("1d432675-abcb-4040-9f4a-9467cb25f882"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("0fcda8f3-0a1b-447b-a958-742d6e51f209"),
				CurveCenterPosition = new Point(147, 486),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("0fcda8f3-0a1b-447b-a958-742d6e51f209"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("258fe680-423d-46ea-91d8-6f9fd45f3cc6"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("ffa1896a-ab80-4a15-8702-a66caf88b009"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("8b40d0e3-b8fd-4eb5-8199-a045dc76545b"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("0fcda8f3-0a1b-447b-a958-742d6e51f209"),
				CurveCenterPosition = new Point(237, 484),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("0fcda8f3-0a1b-447b-a958-742d6e51f209"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("ffa1896a-ab80-4a15-8702-a66caf88b009"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("180c0f81-9829-426f-83a2-3867f909a78c"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3",
				UId = new Guid("0ac6627e-ba5d-473e-9586-36fd752f897c"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("0fcda8f3-0a1b-447b-a958-742d6e51f209"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("0fcda8f3-0a1b-447b-a958-742d6e51f209"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("baca41cc-5771-480d-82eb-ace105774886"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("4410d489-a89b-4066-a44b-00058685f54a"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4",
				UId = new Guid("a6e1547e-4a9f-49e9-bcad-cc433b14b40b"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("0fcda8f3-0a1b-447b-a958-742d6e51f209"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("0fcda8f3-0a1b-447b-a958-742d6e51f209"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("08c98535-fd11-4187-bc74-6e4dd9be4882"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("0fabdf68-6c20-46a2-8f2a-1cbfaf9c2bec"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow8_dd8df5d868a549ca9eaecd576bc428c3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow8_dd8df5d868a549ca9eaecd576bc428c3",
				UId = new Guid("dd8df5d8-68a5-49ca-9eae-cd576bc428c3"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("bcd7b40a-afa2-4631-8983-51d02c873b88"),
				CreatedInSchemaUId = new Guid("0fcda8f3-0a1b-447b-a958-742d6e51f209"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("0fcda8f3-0a1b-447b-a958-742d6e51f209"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("ee8740d2-9863-4857-afa5-a327d7f3b5af"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("7f751925-9eb8-429f-bd80-4e51f07fac88"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet156LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet156 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("789a4ae3-ae42-4fca-b972-0cd5b66a2880"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("0fcda8f3-0a1b-447b-a958-742d6e51f209"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("0fcda8f3-0a1b-447b-a958-742d6e51f209"),
				Name = @"LaneSet156",
				Position = new Point(5, 5),
				Size = new Size(707, 159),
				UseBackgroundMode = false
			};
			return schemaLaneSet156;
		}

		protected virtual ProcessSchemaLane CreateLane3Lane() {
			ProcessSchemaLane schemaLane3 = new ProcessSchemaLane(this) {
				UId = new Guid("3ff2b8b2-d372-4a04-bb9f-5bfa7c508d2f"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("789a4ae3-ae42-4fca-b972-0cd5b66a2880"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("0fcda8f3-0a1b-447b-a958-742d6e51f209"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("0fcda8f3-0a1b-447b-a958-742d6e51f209"),
				Name = @"Lane3",
				Position = new Point(29, 0),
				Size = new Size(678, 159),
				UseBackgroundMode = false
			};
			return schemaLane3;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess3EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess3 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("e1b6a391-da7b-4c2e-8231-539dc8d450bf"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("3ff2b8b2-d372-4a04-bb9f-5bfa7c508d2f"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("0fcda8f3-0a1b-447b-a958-742d6e51f209"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("0fcda8f3-0a1b-447b-a958-742d6e51f209"),
				Name = @"EventSubProcess3",
				Position = new Point(36, 10),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(208, 135),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess3;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateSysPageSchemaEditChangeMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("08c98535-fd11-4187-bc74-6e4dd9be4882"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e1b6a391-da7b-4c2e-8231-539dc8d450bf"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("0fcda8f3-0a1b-447b-a958-742d6e51f209"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"SysPageSchemaEditChange",
				ModifiedInSchemaUId = new Guid("0fcda8f3-0a1b-447b-a958-742d6e51f209"),
				Name = @"SysPageSchemaEditChangeMessage",
				Position = new Point(21, 54),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateSysPageSchemaEditChangeScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("0fabdf68-6c20-46a2-8f2a-1cbfaf9c2bec"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e1b6a391-da7b-4c2e-8231-539dc8d450bf"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("0fcda8f3-0a1b-447b-a958-742d6e51f209"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("0fcda8f3-0a1b-447b-a958-742d6e51f209"),
				Name = @"SysPageSchemaEditChangeScriptTask",
				Position = new Point(96, 40),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,75,44,82,40,202,47,87,176,85,8,72,76,79,213,115,73,44,73,12,206,47,45,74,78,213,115,76,46,201,44,75,13,202,47,183,230,229,2,170,208,11,78,45,113,206,207,41,205,205,11,75,204,41,77,213,80,10,174,44,14,74,45,200,47,42,9,78,206,72,205,77,12,245,76,81,210,129,24,2,148,1,209,16,113,215,148,204,18,61,176,22,5,77,144,73,169,37,165,69,121,10,37,69,165,169,214,0,35,252,128,238,124,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess2EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess2 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("048048fc-d6e1-4a7c-9f34-e7187182017a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("3ff2b8b2-d372-4a04-bb9f-5bfa7c508d2f"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("0fcda8f3-0a1b-447b-a958-742d6e51f209"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("0fcda8f3-0a1b-447b-a958-742d6e51f209"),
				Name = @"EventSubProcess2",
				Position = new Point(20, 196),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(214, 164),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess2;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateSysOptionsPageSchemaEditChangeMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("baca41cc-5771-480d-82eb-ace105774886"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("048048fc-d6e1-4a7c-9f34-e7187182017a"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("0fcda8f3-0a1b-447b-a958-742d6e51f209"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"SysOptionsPageSchemaEditChange",
				ModifiedInSchemaUId = new Guid("0fcda8f3-0a1b-447b-a958-742d6e51f209"),
				Name = @"SysOptionsPageSchemaEditChangeMessage",
				Position = new Point(14, 52),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateSysOptionsPageSchemaEditChangeScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("4410d489-a89b-4066-a44b-00058685f54a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("048048fc-d6e1-4a7c-9f34-e7187182017a"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("0fcda8f3-0a1b-447b-a958-742d6e51f209"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("0fcda8f3-0a1b-447b-a958-742d6e51f209"),
				Name = @"SysOptionsPageSchemaEditChangeScriptTask",
				Position = new Point(93, 38),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,75,44,82,40,202,47,87,176,85,8,72,76,79,213,115,73,44,73,12,206,47,45,74,78,213,115,76,46,201,44,75,13,202,47,183,230,229,2,170,208,11,78,45,113,206,207,41,205,205,11,75,204,41,77,213,80,10,174,44,246,47,40,201,204,207,43,6,233,12,78,206,72,205,77,12,245,76,81,210,129,152,132,77,218,53,37,179,68,15,172,93,65,19,100,106,106,73,105,81,158,66,73,81,105,170,53,0,155,120,92,155,136,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess6EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess6 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("fb33e7d7-b193-46c5-b58a-8b55cd0df232"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("3ff2b8b2-d372-4a04-bb9f-5bfa7c508d2f"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("0fcda8f3-0a1b-447b-a958-742d6e51f209"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("0fcda8f3-0a1b-447b-a958-742d6e51f209"),
				Name = @"EventSubProcess6",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(36, 366),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(262, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess6;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage3StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("d81e37bb-4e40-4e47-ab81-94ed8844a216"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("fb33e7d7-b193-46c5-b58a-8b55cd0df232"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("0fcda8f3-0a1b-447b-a958-742d6e51f209"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("0fcda8f3-0a1b-447b-a958-742d6e51f209"),
				Name = @"StartMessage3",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(14, 63),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask3ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("55e1637c-b00c-4d89-ae69-34748a40eccd"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("fb33e7d7-b193-46c5-b58a-8b55cd0df232"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("0fcda8f3-0a1b-447b-a958-742d6e51f209"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("0fcda8f3-0a1b-447b-a958-742d6e51f209"),
				Name = @"ScriptTask3",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(161, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,84,219,142,218,48,16,125,238,74,251,15,46,79,65,66,249,1,74,37,110,75,81,171,178,90,160,239,38,30,88,111,29,59,245,133,37,173,246,223,59,182,163,37,16,2,85,159,162,196,103,206,156,153,115,226,61,213,196,25,120,130,66,105,59,3,9,154,90,174,228,136,26,96,11,185,204,158,33,167,100,64,102,66,109,168,24,22,197,18,172,229,114,103,210,245,141,162,254,253,29,223,146,228,22,119,151,252,185,191,251,240,72,119,144,70,220,10,242,66,80,11,83,198,45,126,250,229,184,6,134,10,182,84,24,232,95,193,126,225,140,129,68,164,213,206,3,223,8,96,197,145,126,89,26,255,140,109,175,179,55,161,13,242,56,93,64,79,168,165,75,229,116,6,233,48,179,124,15,79,234,149,124,28,16,233,132,136,227,77,165,229,182,36,153,211,26,164,245,199,3,210,90,234,85,236,209,21,19,186,143,149,112,185,111,124,44,78,163,174,52,30,153,116,6,118,84,126,167,57,36,29,20,30,55,19,33,235,57,235,116,223,249,234,67,205,25,57,229,68,146,85,89,0,139,164,63,168,112,240,105,230,56,251,156,212,117,164,181,99,223,49,144,255,187,205,109,219,197,80,5,202,161,100,43,56,216,228,76,106,143,160,186,248,50,225,6,29,47,3,250,28,214,13,106,106,182,135,177,25,236,167,135,66,131,169,54,131,99,75,120,37,43,208,154,26,181,181,56,146,220,242,157,139,162,211,201,25,60,193,156,107,132,72,200,252,121,104,17,38,62,231,77,31,192,102,207,15,90,229,147,81,83,89,212,211,154,221,155,11,104,116,27,211,226,168,231,205,207,93,217,172,194,119,179,252,191,244,44,98,245,177,249,121,132,26,128,57,91,108,94,154,97,170,5,37,185,32,169,53,72,237,45,78,254,168,43,114,80,74,226,147,219,109,165,234,215,163,216,128,180,25,114,129,235,74,48,47,160,171,124,134,203,35,116,95,124,29,57,107,49,116,195,23,122,152,238,113,121,38,29,11,158,253,68,119,241,135,50,72,198,89,136,229,241,226,9,133,149,249,65,233,55,149,33,236,55,221,8,240,74,17,137,77,218,210,61,86,121,174,228,218,114,193,45,135,96,126,173,62,138,63,13,124,175,113,81,85,249,241,174,245,72,167,146,210,105,226,222,47,180,71,205,115,170,203,154,227,126,17,26,172,211,50,142,245,23,127,71,109,76,133,6,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateIntermediateThrowMessageEvent1IntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("065375d1-d5ab-45da-801d-ff3ea621e2ab"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("fb33e7d7-b193-46c5-b58a-8b55cd0df232"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("0fcda8f3-0a1b-447b-a958-742d6e51f209"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("0fcda8f3-0a1b-447b-a958-742d6e51f209"),
				Name = @"IntermediateThrowMessageEvent1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(77, 63),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcessChildInitEventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcessChildInit = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("34cb8f3a-fb39-4628-b947-de9e46d9cfff"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("3ff2b8b2-d372-4a04-bb9f-5bfa7c508d2f"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("0fcda8f3-0a1b-447b-a958-742d6e51f209"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("0fcda8f3-0a1b-447b-a958-742d6e51f209"),
				Name = @"EventSubProcessChildInit",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(36, 555),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(266, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcessChildInit;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptChildInitScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("03154a56-0fd8-41a8-9ed7-7a47a85fc1e1"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("34cb8f3a-fb39-4628-b947-de9e46d9cfff"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("0fcda8f3-0a1b-447b-a958-742d6e51f209"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("0fcda8f3-0a1b-447b-a958-742d6e51f209"),
				Name = @"ScriptChildInit",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(161, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,237,83,203,110,211,64,20,93,39,82,254,225,202,171,68,56,110,218,184,77,43,218,74,193,113,43,36,30,81,194,99,129,88,12,241,77,98,234,120,204,204,184,37,138,44,65,89,130,196,158,207,64,32,21,138,202,47,140,255,136,107,59,74,2,109,151,72,72,116,49,30,123,116,207,61,231,30,207,145,74,248,225,8,4,70,92,168,254,96,140,19,118,159,133,108,132,226,1,155,32,236,65,151,222,173,199,18,133,195,195,16,7,202,231,161,117,136,170,119,53,160,90,187,93,41,231,144,254,84,102,123,81,225,122,190,178,186,68,194,4,222,227,252,40,142,14,252,64,161,128,91,123,224,97,128,35,166,16,170,252,197,75,34,0,137,161,135,194,132,162,48,131,186,199,24,170,182,24,73,192,26,204,42,229,146,195,131,160,208,178,219,241,243,157,137,233,174,204,103,49,161,232,179,191,15,195,156,68,210,20,104,21,132,146,228,149,214,214,244,39,125,161,191,152,160,191,235,139,244,148,214,155,244,189,254,150,127,234,31,250,167,62,211,231,250,140,14,223,233,175,233,105,250,54,253,8,89,149,62,79,63,100,37,160,63,195,83,46,142,100,196,6,8,78,111,189,213,220,106,108,1,109,155,118,139,250,207,105,173,182,231,85,67,60,129,235,37,194,12,168,190,52,51,6,124,66,222,248,146,135,143,166,17,26,38,20,114,157,223,142,45,247,85,204,130,196,156,99,2,28,42,247,117,36,80,74,234,78,150,196,147,176,203,212,152,208,6,185,191,80,104,221,245,140,196,44,48,177,196,142,47,163,128,77,159,176,32,206,136,134,44,144,184,232,41,252,209,120,165,105,151,9,250,169,36,36,175,150,84,158,205,83,136,127,246,28,102,87,93,142,85,222,36,73,178,11,241,47,56,178,114,73,255,150,27,215,132,104,110,66,66,107,153,141,135,81,102,192,77,68,110,34,242,95,69,196,88,94,248,57,155,113,57,30,29,166,88,159,199,130,252,185,131,67,46,176,207,142,177,199,79,40,10,149,242,34,12,127,102,97,137,186,148,5,180,8,109,245,81,21,243,230,218,170,70,230,14,253,247,66,226,97,236,123,85,163,185,113,208,218,112,118,156,58,61,91,117,219,118,27,245,109,103,219,174,55,109,103,199,237,172,183,156,246,102,195,168,45,229,86,202,2,85,44,66,80,34,70,58,249,5,103,1,67,6,78,7,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateBaseInitIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("b11b8f7c-3bf3-41e7-8663-72184f063580"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("34cb8f3a-fb39-4628-b947-de9e46d9cfff"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("0fcda8f3-0a1b-447b-a958-742d6e51f209"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("0fcda8f3-0a1b-447b-a958-742d6e51f209"),
				Name = @"BaseInit",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(85, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateChildInitStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("29a0605f-4610-4390-8ace-129442026bc0"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("34cb8f3a-fb39-4628-b947-de9e46d9cfff"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("0fcda8f3-0a1b-447b-a958-742d6e51f209"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("0fcda8f3-0a1b-447b-a958-742d6e51f209"),
				Name = @"ChildInit",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(8, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess1EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess1 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("3cafa6ea-f77e-4fef-bd01-3ffb47bf0ca8"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("3ff2b8b2-d372-4a04-bb9f-5bfa7c508d2f"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("0fcda8f3-0a1b-447b-a958-742d6e51f209"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("0fcda8f3-0a1b-447b-a958-742d6e51f209"),
				Name = @"EventSubProcess1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(35, 751),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(328, 156),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess1;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessageChildDataSourceSavedStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("258fe680-423d-46ea-91d8-6f9fd45f3cc6"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("3cafa6ea-f77e-4fef-bd01-3ffb47bf0ca8"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("0fcda8f3-0a1b-447b-a958-742d6e51f209"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"DataSourceSaved",
				ModifiedInSchemaUId = new Guid("0fcda8f3-0a1b-447b-a958-742d6e51f209"),
				Name = @"StartMessageChildDataSourceSaved",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(22, 70),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateStartMessageBaseDataSourceSavedIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("ffa1896a-ab80-4a15-8702-a66caf88b009"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("3cafa6ea-f77e-4fef-bd01-3ffb47bf0ca8"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("0fcda8f3-0a1b-447b-a958-742d6e51f209"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"DataSourceSaved",
				ModifiedInSchemaUId = new Guid("0fcda8f3-0a1b-447b-a958-742d6e51f209"),
				Name = @"StartMessageBaseDataSourceSaved",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(127, 70),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true,
				UseBackgroundMode = false
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateDataSourceSavedScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("180c0f81-9829-426f-83a2-3867f909a78c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("3cafa6ea-f77e-4fef-bd01-3ffb47bf0ca8"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("0fcda8f3-0a1b-447b-a958-742d6e51f209"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("0fcda8f3-0a1b-447b-a958-742d6e51f209"),
				Name = @"DataSourceSavedScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(225, 56),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,142,205,78,195,64,12,132,239,72,188,67,212,83,42,85,251,2,61,85,225,231,2,18,74,82,122,54,155,105,106,177,93,71,94,111,11,60,61,73,138,84,46,61,89,227,241,120,190,22,170,148,100,111,174,146,184,231,62,43,25,75,28,213,241,40,113,107,28,216,24,201,53,116,194,139,120,10,252,67,31,1,239,20,50,202,55,234,225,30,200,168,145,172,30,110,227,141,79,168,229,188,42,102,171,162,97,122,246,216,177,185,127,225,22,95,182,42,22,127,238,98,185,190,191,107,111,96,52,223,233,85,186,28,240,36,161,131,94,121,106,36,216,197,170,49,136,90,69,254,128,114,155,160,227,135,8,127,137,35,165,113,206,158,219,177,29,102,138,73,114,236,203,91,165,243,249,181,106,39,250,153,6,242,152,247,207,42,121,88,78,204,10,203,26,11,211,140,245,47,132,165,215,159,71,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess5_9007bcca390046fea55727290121bdabEventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess5_9007bcca390046fea55727290121bdab = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("9007bcca-3900-46fe-a557-27290121bdab"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("3ff2b8b2-d372-4a04-bb9f-5bfa7c508d2f"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("bcd7b40a-afa2-4631-8983-51d02c873b88"),
				CreatedInSchemaUId = new Guid("0fcda8f3-0a1b-447b-a958-742d6e51f209"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("0fcda8f3-0a1b-447b-a958-742d6e51f209"),
				Name = @"EventSubProcess5_9007bcca390046fea55727290121bdab",
				Position = new Point(20, 930),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(266, 135),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess5_9007bcca390046fea55727290121bdab;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage2_ee8740d298634857afa5a327d7f3b5afStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("ee8740d2-9863-4857-afa5-a327d7f3b5af"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("9007bcca-3900-46fe-a557-27290121bdab"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("bcd7b40a-afa2-4631-8983-51d02c873b88"),
				CreatedInSchemaUId = new Guid("0fcda8f3-0a1b-447b-a958-742d6e51f209"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"ReportTemplateEditChange",
				ModifiedInSchemaUId = new Guid("0fcda8f3-0a1b-447b-a958-742d6e51f209"),
				Name = @"StartMessage2_ee8740d298634857afa5a327d7f3b5af",
				Position = new Point(20, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask4_7f7519259eb8429fbd804e51f07fac88ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("7f751925-9eb8-429f-bd80-4e51f07fac88"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("9007bcca-3900-46fe-a557-27290121bdab"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("bcd7b40a-afa2-4631-8983-51d02c873b88"),
				CreatedInSchemaUId = new Guid("0fcda8f3-0a1b-447b-a958-742d6e51f209"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("0fcda8f3-0a1b-447b-a958-742d6e51f209"),
				Name = @"ScriptTask4_7f7519259eb8429fbd804e51f07fac88",
				Position = new Point(77, 35),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,72,76,79,213,115,73,44,73,12,206,47,45,74,78,213,115,76,46,201,44,75,13,202,47,215,11,78,45,113,206,207,41,205,205,11,75,204,41,77,213,80,10,174,44,14,74,45,200,47,42,9,78,206,72,205,77,12,245,76,81,210,81,8,0,105,135,8,135,164,230,22,228,36,150,164,186,166,100,150,232,129,245,104,90,243,114,21,165,150,148,22,229,41,148,20,149,166,90,3,0,64,227,227,47,108,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateGetSchemaDisplayValueMethod());
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("b22cedfd-39cd-46e5-b5c4-6f7cd276eb74"),
				Name = "Terrasoft.Core.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("0da240a7-6b5c-4da2-ab4b-e82287d805bd"),
				Name = "Terrasoft.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("2f50a15b-41f7-4f3a-bd8f-0eb6fecaf008"),
				Name = "Terrasoft.Web.Common",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("6637387a-de9e-4743-a106-2aa727176584"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("a3b4c35d-d0ae-4718-8947-a55e9b8474bf"),
				Name = "Terrasoft.Core.Store",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("cab74f0c-62c3-4f2a-bcc6-61cbc42722df"),
				Name = "Terrasoft.Reports",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
		}

		protected override SchemaMethod CreateOkClickMethodMethod() {
			SchemaMethod method = base.CreateOkClickMethodMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,146,63,111,194,48,16,197,103,144,248,14,174,167,68,32,171,51,168,3,10,21,165,42,42,130,182,11,48,24,251,0,139,96,71,182,19,218,70,249,238,181,67,74,249,51,164,163,207,239,221,251,221,217,25,213,40,209,98,79,245,87,148,198,54,213,32,228,90,161,7,244,110,64,71,74,74,96,86,40,73,134,96,39,23,178,145,147,5,97,175,213,20,235,224,110,66,55,64,34,154,120,233,35,23,150,188,40,70,99,241,77,87,49,188,193,167,37,79,212,84,190,15,26,167,16,220,70,134,33,202,91,205,70,109,167,25,216,154,78,29,84,215,196,99,23,173,166,177,90,200,13,98,71,161,155,185,54,124,120,21,254,191,37,249,184,204,237,153,41,153,129,182,160,141,203,146,112,64,207,70,201,232,183,56,95,162,220,23,135,169,224,23,23,65,88,244,78,176,130,59,175,191,118,139,208,194,195,65,80,98,15,168,165,51,149,106,6,164,239,104,50,152,170,3,249,165,81,113,186,151,37,114,231,140,98,126,191,244,104,165,125,198,180,72,236,152,74,119,208,164,207,249,177,112,211,59,138,5,72,59,26,160,54,114,175,213,192,68,201,83,220,89,140,137,182,84,110,128,79,193,36,74,26,8,112,41,119,46,55,64,27,225,78,190,192,213,162,23,24,117,81,206,254,188,93,132,43,237,213,156,213,67,133,190,65,81,132,61,236,233,87,212,0,121,221,57,46,182,27,131,221,42,238,126,229,15,98,249,191,8,214,2,0,0 };
			return method;
		}

		protected override SchemaMethod CreateGetIsContextHelpButtonHiddenMethod() {
			SchemaMethod method = base.CreateGetIsContextHelpButtonHiddenMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,72,75,204,41,78,181,6,0,112,193,6,27,13,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetSchemaDisplayValueMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("780b72af-2920-41e8-8174-0233c6f5158f"),
				Name = "GetSchemaDisplayValue",
				CreatedInSchemaUId = new Guid("0fcda8f3-0a1b-447b-a958-742d6e51f209"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				ResultValueTypeName = "string"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("14c0202e-3e53-47cc-8065-9c282ce6ef42"),
				Name = "recordId",
				CreatedInSchemaUId = new Guid("0fcda8f3-0a1b-447b-a958-742d6e51f209"),
				ModifiedInSchemaUId = new Guid("0fcda8f3-0a1b-447b-a958-742d6e51f209"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,189,146,77,107,212,64,24,199,207,22,250,29,30,226,37,129,48,187,75,161,123,104,45,72,92,165,7,237,218,174,237,65,60,12,201,179,237,96,50,19,159,153,180,4,41,104,61,42,244,238,199,16,11,125,145,250,21,38,223,200,153,38,174,214,236,217,67,24,242,159,255,243,155,231,109,48,128,217,206,147,29,120,56,26,15,199,163,181,213,149,99,78,128,210,8,83,239,165,71,88,240,231,92,242,67,36,120,4,83,119,178,86,100,247,238,166,164,142,69,134,196,158,161,233,164,48,152,244,25,65,4,92,195,12,137,184,86,115,195,18,69,200,238,124,2,53,91,18,176,209,79,231,101,133,84,187,100,36,158,192,228,95,61,92,146,120,12,193,254,201,94,173,91,113,91,206,85,16,117,220,148,151,70,40,153,168,188,42,228,11,94,160,227,246,222,98,143,179,172,117,132,65,210,6,4,17,243,110,71,233,187,159,138,220,32,105,31,21,246,111,19,66,110,176,245,28,8,115,52,229,228,64,62,32,108,197,68,21,37,39,161,149,156,213,165,107,206,187,138,231,241,234,202,131,62,106,87,41,211,13,195,181,125,74,162,224,84,255,41,37,140,98,32,76,21,101,219,89,228,11,30,12,236,87,123,107,191,199,96,175,237,109,115,230,190,15,205,103,123,117,247,107,127,216,159,246,210,222,216,75,39,126,178,23,205,89,243,177,57,7,239,178,55,205,23,111,1,251,13,14,20,189,213,37,79,17,146,221,209,120,109,125,184,254,31,91,16,184,33,46,18,8,98,120,165,189,87,74,76,253,76,216,226,138,117,5,47,54,199,45,215,210,193,186,182,181,27,228,186,150,183,148,240,62,212,99,196,28,194,223,24,183,177,149,52,176,5,195,8,222,187,148,8,77,69,114,241,202,235,225,27,15,245,105,119,43,179,207,243,10,55,181,33,33,15,183,194,222,190,121,254,41,96,174,241,111,92,107,103,147,162,52,181,55,252,2,62,153,59,20,163,3,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SysModuleReportDevExpressEditPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("0fcda8f3-0a1b-447b-a958-742d6e51f209"));
		}

		#endregion

	}

	#endregion

}

