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
	using System.Web.UI.WebControls;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;
	using Terrasoft.UI.WebControls;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities;
	using Terrasoft.Web.Common;
	using TSConfiguration = Terrasoft.Configuration;

	#region Class: QueueObjectColumnEditPageSchema

	/// <exclude/>
	public class QueueObjectColumnEditPageSchema : Terrasoft.WebApp.BaseEditPageSchema
	{

		#region Properties: Public

		private Terrasoft.UI.WebControls.Controls.ControlLayout _controlsControlLayout;
		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlsControlLayout {
			get {
				return _controlsControlLayout;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ComboBoxEdit _captionEdit;
		public Terrasoft.UI.WebControls.Controls.ComboBoxEdit CaptionEdit {
			get {
				return _captionEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ComboBoxEdit _orderDirectionEdit;
		public Terrasoft.UI.WebControls.Controls.ComboBoxEdit OrderDirectionEdit {
			get {
				return _orderDirectionEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.IntegerEdit _positionEdit;
		public Terrasoft.UI.WebControls.Controls.IntegerEdit PositionEdit {
			get {
				return _positionEdit;
			}
		}

		#endregion

		#region Constructors: Public

		public QueueObjectColumnEditPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public QueueObjectColumnEditPageSchema(QueueObjectColumnEditPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateCustomControls() {
			CustomControls.Image = new ControlImage {};
			CustomControls.ModifiedInSchemaUId = new Guid("adbd57ce-303c-472a-b08a-37a41d556f17");
		}

		private void UpdateMainControlLayout() {
			MainControlLayout.Image = new ControlImage {};
			MainControlLayout.AutoScroll = false;
			MainControlLayout.ModifiedInSchemaUId = new Guid("adbd57ce-303c-472a-b08a-37a41d556f17");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("adbd57ce-303c-472a-b08a-37a41d556f17");
		}

		private void UpdateDesignerModeButton() {
			DesignerModeButton.AjaxEvents.Click.IsProcessEventHandler = true;
			DesignerModeButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("a5bcc8d7-215f-41c5-8f3c-f96f57d48c34"),
				ImageHash = @"682ad9264105b2170afb821fabf80415"
			};
			DesignerModeButton.ModifiedInSchemaUId = new Guid("adbd57ce-303c-472a-b08a-37a41d556f17");
		}

		private void UpdateOKButton() {
			OKButton.AjaxEvents.Click.IsProcessEventHandler = true;
			OKButton.Image = new ControlImage {};
			OKButton.ModifiedInSchemaUId = new Guid("adbd57ce-303c-472a-b08a-37a41d556f17");
		}

		private void UpdateCancelButton() {
			CancelButton.AjaxEvents.Click.IsProcessEventHandler = true;
			CancelButton.Image = new ControlImage {};
			CancelButton.ModifiedInSchemaUId = new Guid("adbd57ce-303c-472a-b08a-37a41d556f17");
		}

		private void UpdateApplyChangesButton() {
			ApplyChangesButton.AjaxEvents.Click.IsProcessEventHandler = true;
			ApplyChangesButton.Image = new ControlImage {};
			ApplyChangesButton.ModifiedInSchemaUId = new Guid("adbd57ce-303c-472a-b08a-37a41d556f17");
		}

		private void UpdateButtonsControlLayout() {
			ButtonsControlLayout.Image = new ControlImage {};
			ButtonsControlLayout.ModifiedInSchemaUId = new Guid("adbd57ce-303c-472a-b08a-37a41d556f17");
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("adbd57ce-303c-472a-b08a-37a41d556f17");
			RealUId = new Guid("adbd57ce-303c-472a-b08a-37a41d556f17");
			Name = "QueueObjectColumnEditPage";
			ParentSchemaUId = new Guid("a5bcc8d7-215f-41c5-8f3c-f96f57d48c34");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			Width = 300;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateQueueObjectColumnEditPageEventsProcessSchema();
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
			TopLevelControl.MoveItem(0, BaseMessagePanel);
			TopLevelControl.MoveItem(1, MainControlLayout);
			MainControlLayout.InsertItem(0, CreateControlsControlLayout());
			ControlsControlLayout.InsertItem(0, CreateCaptionEdit());
			ControlsControlLayout.InsertItem(1, CreateOrderDirectionEdit());
			ControlsControlLayout.InsertItem(2, CreatePositionEdit());
			MainControlLayout.MoveItem(1, CustomControls);
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

		protected virtual EmbeddedProcessSchema CreateQueueObjectColumnEditPageEventsProcessSchema() {
			var schema = new QueueObjectColumnEditPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ComboBoxEdit CreateCaptionEdit() {
			_captionEdit = new Terrasoft.UI.WebControls.Controls.ComboBoxEdit();
			_captionEdit.UId = new Guid("929298bb-dad4-4f4f-a959-1e5cafb7c943");
			_captionEdit.Name = "CaptionEdit";
			_captionEdit.CreatedInSchemaUId = new Guid("adbd57ce-303c-472a-b08a-37a41d556f17");
			_captionEdit.ModifiedInSchemaUId = new Guid("adbd57ce-303c-472a-b08a-37a41d556f17");
			_captionEdit.CreatedInPackageId = new Guid("7be0af39-38cd-442a-b589-d8f3ef3f4d19");
			_captionEdit.AjaxEvents.Change.IsProcessEventHandler = true;
			_captionEdit.Tag = "";
			_captionEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_captionEdit.Image = new ControlImage {};
			_captionEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_captionEdit.Required = true;
			return _captionEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ComboBoxEdit CreateOrderDirectionEdit() {
			_orderDirectionEdit = new Terrasoft.UI.WebControls.Controls.ComboBoxEdit();
			_orderDirectionEdit.UId = new Guid("98ab77e8-716c-4895-b5e0-ad2d2b9eddc1");
			_orderDirectionEdit.Name = "OrderDirectionEdit";
			_orderDirectionEdit.CreatedInSchemaUId = new Guid("adbd57ce-303c-472a-b08a-37a41d556f17");
			_orderDirectionEdit.ModifiedInSchemaUId = new Guid("adbd57ce-303c-472a-b08a-37a41d556f17");
			_orderDirectionEdit.CreatedInPackageId = new Guid("7be0af39-38cd-442a-b589-d8f3ef3f4d19");
			_orderDirectionEdit.Tag = "";
			_orderDirectionEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_orderDirectionEdit.Image = new ControlImage {};
			_orderDirectionEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_orderDirectionEdit.DataSource = "DataSource";
			_orderDirectionEdit.ColumnUId = new Guid("1919de63-4948-4ad2-b1c1-0d2aa6d8f88a");
			_orderDirectionEdit.Required = true;
			return _orderDirectionEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.IntegerEdit CreatePositionEdit() {
			_positionEdit = new Terrasoft.UI.WebControls.Controls.IntegerEdit();
			_positionEdit.UId = new Guid("ed0d7489-7f1d-4d2c-9056-ee1b2a788d2a");
			_positionEdit.Name = "PositionEdit";
			_positionEdit.CreatedInSchemaUId = new Guid("adbd57ce-303c-472a-b08a-37a41d556f17");
			_positionEdit.ModifiedInSchemaUId = new Guid("adbd57ce-303c-472a-b08a-37a41d556f17");
			_positionEdit.CreatedInPackageId = new Guid("7be0af39-38cd-442a-b589-d8f3ef3f4d19");
			_positionEdit.Tag = "";
			_positionEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_positionEdit.Image = new ControlImage {};
			_positionEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_positionEdit.DataSource = "DataSource";
			_positionEdit.ColumnUId = new Guid("25508bcf-30d2-42e1-9f8a-18b3383034be");
			return _positionEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ControlLayout CreateControlsControlLayout() {
			_controlsControlLayout = new Terrasoft.UI.WebControls.Controls.ControlLayout();
			_controlsControlLayout.UId = new Guid("27821597-9873-4eb3-909f-87b5926aaea4");
			_controlsControlLayout.Name = "ControlsControlLayout";
			_controlsControlLayout.CreatedInSchemaUId = new Guid("adbd57ce-303c-472a-b08a-37a41d556f17");
			_controlsControlLayout.ModifiedInSchemaUId = new Guid("adbd57ce-303c-472a-b08a-37a41d556f17");
			_controlsControlLayout.CreatedInPackageId = new Guid("7be0af39-38cd-442a-b589-d8f3ef3f4d19");
			_controlsControlLayout.Tag = "";
			_controlsControlLayout.Height = System.Web.UI.WebControls.Unit.Pixel(50);
			_controlsControlLayout.DisplayStyle = Terrasoft.UI.WebControls.Controls.ControlLayoutDisplayStyle.Controls;
			_controlsControlLayout.FitHeightByContent = true;
			_controlsControlLayout.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_controlsControlLayout.StartNewAlignGroup = false;
			_controlsControlLayout.Image = new ControlImage {};
			_controlsControlLayout.Edges = "";
			return _controlsControlLayout;
		}

		protected override void UpdateDataSource() {
			base.UpdateDataSource();
			DataSource.SchemaUId = new Guid("68bf7df2-6f74-431a-9122-e2cf5edf283b");
			DataSource.ModifiedInSchemaUId = new Guid("adbd57ce-303c-472a-b08a-37a41d556f17");
			DataSourceStructureColumn column = null;
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ae0e45ca-c495-4fe7-a39d-3ab7278e1617");
			if (column != null) {
				column.UId = new Guid("7df77b8a-3018-412d-a6e5-3b0498432c85");
				column.Name = @"Id";
				column.CreatedInSchemaUId = new Guid("adbd57ce-303c-472a-b08a-37a41d556f17");
				column.ModifiedInSchemaUId = new Guid("adbd57ce-303c-472a-b08a-37a41d556f17");
				column.CreatedInPackageId = Guid.Empty;
				column.IsAlwaysSelect = true;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("e80190a5-03b2-4095-90f7-a193a960adee");
			if (column != null) {
				column.UId = new Guid("6a194d3a-6403-4dc2-864d-74934b9d971e");
				column.Name = @"CreatedOn";
				column.CreatedInSchemaUId = new Guid("adbd57ce-303c-472a-b08a-37a41d556f17");
				column.ModifiedInSchemaUId = new Guid("adbd57ce-303c-472a-b08a-37a41d556f17");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ebf6bb93-8aa6-4a01-900d-c6ea67affe21");
			if (column != null) {
				column.UId = new Guid("c421f8f2-6fef-42e2-80df-c9b4a3d72548");
				column.Name = @"CreatedBy";
				column.CreatedInSchemaUId = new Guid("adbd57ce-303c-472a-b08a-37a41d556f17");
				column.ModifiedInSchemaUId = new Guid("adbd57ce-303c-472a-b08a-37a41d556f17");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9928edec-4272-425a-93bb-48743fee4b04");
			if (column != null) {
				column.UId = new Guid("63a5fe97-5459-4d6f-aa7c-d60b9dca388f");
				column.Name = @"ModifiedOn";
				column.CreatedInSchemaUId = new Guid("adbd57ce-303c-472a-b08a-37a41d556f17");
				column.ModifiedInSchemaUId = new Guid("adbd57ce-303c-472a-b08a-37a41d556f17");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3015559e-cbc6-406a-88af-07f7930be832");
			if (column != null) {
				column.UId = new Guid("16b40ff8-3e6c-484e-b4d3-39c62ce73af5");
				column.Name = @"ModifiedBy";
				column.CreatedInSchemaUId = new Guid("adbd57ce-303c-472a-b08a-37a41d556f17");
				column.ModifiedInSchemaUId = new Guid("adbd57ce-303c-472a-b08a-37a41d556f17");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3fabd836-6a53-4d8d-9069-6df88d9dae1e");
			if (column != null) {
				column.UId = new Guid("1dc27426-538c-4735-84e5-fc5418092fbe");
				column.Name = @"ProcessListeners";
				column.CreatedInSchemaUId = new Guid("adbd57ce-303c-472a-b08a-37a41d556f17");
				column.ModifiedInSchemaUId = new Guid("adbd57ce-303c-472a-b08a-37a41d556f17");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("2b32f492-cf44-4e4d-8a4f-d4376006956a");
			if (column != null) {
				column.UId = new Guid("3defe156-0ba9-4271-92f3-535c377c7f1f");
				column.Name = @"Name";
				column.CreatedInSchemaUId = new Guid("adbd57ce-303c-472a-b08a-37a41d556f17");
				column.ModifiedInSchemaUId = new Guid("adbd57ce-303c-472a-b08a-37a41d556f17");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("f4b3c5c2-f8ed-4bf6-96c0-a96c436daa12");
			if (column != null) {
				column.UId = new Guid("1919de63-4948-4ad2-b1c1-0d2aa6d8f88a");
				column.Name = @"OrderDirection";
				column.CreatedInSchemaUId = new Guid("adbd57ce-303c-472a-b08a-37a41d556f17");
				column.ModifiedInSchemaUId = new Guid("adbd57ce-303c-472a-b08a-37a41d556f17");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("2b3b281f-718b-43f4-a604-45ab2cb8cece");
			if (column != null) {
				column.UId = new Guid("d28b0d3c-b30d-46c5-99ee-c8969840c68f");
				column.Name = @"QueueObject";
				column.CreatedInSchemaUId = new Guid("adbd57ce-303c-472a-b08a-37a41d556f17");
				column.ModifiedInSchemaUId = new Guid("adbd57ce-303c-472a-b08a-37a41d556f17");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("e7c637f7-b666-48c3-b787-1bfe974ff55a");
			if (column != null) {
				column.UId = new Guid("25508bcf-30d2-42e1-9f8a-18b3383034be");
				column.Name = @"Position";
				column.CreatedInSchemaUId = new Guid("adbd57ce-303c-472a-b08a-37a41d556f17");
				column.ModifiedInSchemaUId = new Guid("adbd57ce-303c-472a-b08a-37a41d556f17");
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
			return new QueueObjectColumnEditPageSchemaUserControl();
		}

		public override object Clone() {
			return new QueueObjectColumnEditPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("adbd57ce-303c-472a-b08a-37a41d556f17"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new QueueObjectColumnEditPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: QueueObjectColumnEditPageEventsProcess

	/// <exclude/>
	public class QueueObjectColumnEditPageEventsProcess<TPage> : Terrasoft.WebApp.BaseEditPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.QueueObjectColumnEditPageSchemaUserControl
	{

		public QueueObjectColumnEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "QueueObjectColumnEditPageEventsProcess";
			SchemaUId = new Guid("adbd57ce-303c-472a-b08a-37a41d556f17");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("adbd57ce-303c-472a-b08a-37a41d556f17");
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

		public virtual Guid QueueObjectSchemaUId {
			get;
			set;
		}

		private ProcessFlowElement _queueObjectColumnEditPageInitEventSubProcess;
		public ProcessFlowElement QueueObjectColumnEditPageInitEventSubProcess {
			get {
				return _queueObjectColumnEditPageInitEventSubProcess ?? (_queueObjectColumnEditPageInitEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "QueueObjectColumnEditPageInitEventSubProcess",
					SchemaElementUId = new Guid("ffa9f5fa-8bec-47f1-bc80-76004d116053"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _queueObjectColumnEditPageInitStartMessage;
		public ProcessFlowElement QueueObjectColumnEditPageInitStartMessage {
			get {
				return _queueObjectColumnEditPageInitStartMessage ?? (_queueObjectColumnEditPageInitStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "QueueObjectColumnEditPageInitStartMessage",
					SchemaElementUId = new Guid("43348fba-3753-4ef8-a02e-1b7fb0d26365"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _queueObjectColumnEditPageInitScriptTask;
		public ProcessScriptTask QueueObjectColumnEditPageInitScriptTask {
			get {
				return _queueObjectColumnEditPageInitScriptTask ?? (_queueObjectColumnEditPageInitScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "QueueObjectColumnEditPageInitScriptTask",
					SchemaElementUId = new Guid("93c26f79-2ef9-4d2b-926d-19848879a252"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = QueueObjectColumnEditPageInitScriptTaskExecute,
				});
			}
		}

		private ProcessThrowMessageEvent _queueObjectColumnEditPageInitIntermediateThrowMessageEvent;
		public ProcessThrowMessageEvent QueueObjectColumnEditPageInitIntermediateThrowMessageEvent {
			get {
				return _queueObjectColumnEditPageInitIntermediateThrowMessageEvent ?? (_queueObjectColumnEditPageInitIntermediateThrowMessageEvent = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "QueueObjectColumnEditPageInitIntermediateThrowMessageEvent",
					SchemaElementUId = new Guid("d248114f-1d6f-4252-b115-1d6ff1dd3d99"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "Init",
						ThrowToBase = true,
				});
			}
		}

		private ProcessFlowElement _queueObjectColumnEditPagePageLoadCompleteEventSubProcess;
		public ProcessFlowElement QueueObjectColumnEditPagePageLoadCompleteEventSubProcess {
			get {
				return _queueObjectColumnEditPagePageLoadCompleteEventSubProcess ?? (_queueObjectColumnEditPagePageLoadCompleteEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "QueueObjectColumnEditPagePageLoadCompleteEventSubProcess",
					SchemaElementUId = new Guid("02ae54af-3619-49ff-bac7-7db6a6f96d5f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _queueObjectColumnEditPagePageLoadCompleteStartMessage;
		public ProcessFlowElement QueueObjectColumnEditPagePageLoadCompleteStartMessage {
			get {
				return _queueObjectColumnEditPagePageLoadCompleteStartMessage ?? (_queueObjectColumnEditPagePageLoadCompleteStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "QueueObjectColumnEditPagePageLoadCompleteStartMessage",
					SchemaElementUId = new Guid("69d0bfa6-0f17-40c2-8f75-b6b52ee6a9be"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _queueObjectColumnEditPagePageLoadCompleteScriptTask;
		public ProcessScriptTask QueueObjectColumnEditPagePageLoadCompleteScriptTask {
			get {
				return _queueObjectColumnEditPagePageLoadCompleteScriptTask ?? (_queueObjectColumnEditPagePageLoadCompleteScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "QueueObjectColumnEditPagePageLoadCompleteScriptTask",
					SchemaElementUId = new Guid("4ec35cfe-a23d-4208-b0bc-81e396986ace"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = QueueObjectColumnEditPagePageLoadCompleteScriptTaskExecute,
				});
			}
		}

		private ProcessThrowMessageEvent _queueObjectColumnEditPagePageLoadCompleteIntermediateThrowMessageEvent;
		public ProcessThrowMessageEvent QueueObjectColumnEditPagePageLoadCompleteIntermediateThrowMessageEvent {
			get {
				return _queueObjectColumnEditPagePageLoadCompleteIntermediateThrowMessageEvent ?? (_queueObjectColumnEditPagePageLoadCompleteIntermediateThrowMessageEvent = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "QueueObjectColumnEditPagePageLoadCompleteIntermediateThrowMessageEvent",
					SchemaElementUId = new Guid("aa2592b6-bb00-452f-bcba-fd7c56e9e4e5"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "PageLoadComplete",
						ThrowToBase = true,
				});
			}
		}

		private ProcessFlowElement _captionEditChangeEventSubProcess;
		public ProcessFlowElement CaptionEditChangeEventSubProcess {
			get {
				return _captionEditChangeEventSubProcess ?? (_captionEditChangeEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "CaptionEditChangeEventSubProcess",
					SchemaElementUId = new Guid("c5ed15f7-562d-45b1-9f31-f9e8a786c4c2"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _captionEditChangeStartMessage;
		public ProcessFlowElement CaptionEditChangeStartMessage {
			get {
				return _captionEditChangeStartMessage ?? (_captionEditChangeStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "CaptionEditChangeStartMessage",
					SchemaElementUId = new Guid("a462ea07-e11f-4b54-b08a-96171695f911"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _captionEditChangeScriptTask;
		public ProcessScriptTask CaptionEditChangeScriptTask {
			get {
				return _captionEditChangeScriptTask ?? (_captionEditChangeScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "CaptionEditChangeScriptTask",
					SchemaElementUId = new Guid("3f5a47a0-2f7b-4779-8e3c-574cae72f20e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = CaptionEditChangeScriptTaskExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[QueueObjectColumnEditPageInitEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { QueueObjectColumnEditPageInitEventSubProcess };
			FlowElements[QueueObjectColumnEditPageInitStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { QueueObjectColumnEditPageInitStartMessage };
			FlowElements[QueueObjectColumnEditPageInitScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { QueueObjectColumnEditPageInitScriptTask };
			FlowElements[QueueObjectColumnEditPageInitIntermediateThrowMessageEvent.SchemaElementUId] = new Collection<ProcessFlowElement> { QueueObjectColumnEditPageInitIntermediateThrowMessageEvent };
			FlowElements[QueueObjectColumnEditPagePageLoadCompleteEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { QueueObjectColumnEditPagePageLoadCompleteEventSubProcess };
			FlowElements[QueueObjectColumnEditPagePageLoadCompleteStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { QueueObjectColumnEditPagePageLoadCompleteStartMessage };
			FlowElements[QueueObjectColumnEditPagePageLoadCompleteScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { QueueObjectColumnEditPagePageLoadCompleteScriptTask };
			FlowElements[QueueObjectColumnEditPagePageLoadCompleteIntermediateThrowMessageEvent.SchemaElementUId] = new Collection<ProcessFlowElement> { QueueObjectColumnEditPagePageLoadCompleteIntermediateThrowMessageEvent };
			FlowElements[CaptionEditChangeEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { CaptionEditChangeEventSubProcess };
			FlowElements[CaptionEditChangeStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { CaptionEditChangeStartMessage };
			FlowElements[CaptionEditChangeScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { CaptionEditChangeScriptTask };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "QueueObjectColumnEditPageInitEventSubProcess":
						break;
					case "QueueObjectColumnEditPageInitStartMessage":
						e.Context.QueueTasks.Enqueue("QueueObjectColumnEditPageInitScriptTask");
						break;
					case "QueueObjectColumnEditPageInitScriptTask":
						e.Context.QueueTasks.Enqueue("QueueObjectColumnEditPageInitIntermediateThrowMessageEvent");
						break;
					case "QueueObjectColumnEditPageInitIntermediateThrowMessageEvent":
						break;
					case "QueueObjectColumnEditPagePageLoadCompleteEventSubProcess":
						break;
					case "QueueObjectColumnEditPagePageLoadCompleteStartMessage":
						e.Context.QueueTasks.Enqueue("QueueObjectColumnEditPagePageLoadCompleteIntermediateThrowMessageEvent");
						break;
					case "QueueObjectColumnEditPagePageLoadCompleteScriptTask":
						break;
					case "QueueObjectColumnEditPagePageLoadCompleteIntermediateThrowMessageEvent":
						e.Context.QueueTasks.Enqueue("QueueObjectColumnEditPagePageLoadCompleteScriptTask");
						break;
					case "CaptionEditChangeEventSubProcess":
						break;
					case "CaptionEditChangeStartMessage":
						e.Context.QueueTasks.Enqueue("CaptionEditChangeScriptTask");
						break;
					case "CaptionEditChangeScriptTask":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("QueueObjectColumnEditPageInitStartMessage");
			ActivatedEventElements.Add("QueueObjectColumnEditPagePageLoadCompleteStartMessage");
			ActivatedEventElements.Add("CaptionEditChangeStartMessage");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "QueueObjectColumnEditPageInitEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "QueueObjectColumnEditPageInitStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "QueueObjectColumnEditPageInitStartMessage";
					result = QueueObjectColumnEditPageInitStartMessage.Execute(context);
					break;
				case "QueueObjectColumnEditPageInitScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "QueueObjectColumnEditPageInitScriptTask";
					result = QueueObjectColumnEditPageInitScriptTask.Execute(context, QueueObjectColumnEditPageInitScriptTaskExecute);
					break;
				case "QueueObjectColumnEditPageInitIntermediateThrowMessageEvent":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "Init");
					result = QueueObjectColumnEditPageInitIntermediateThrowMessageEvent.Execute(context);
					break;
				case "QueueObjectColumnEditPagePageLoadCompleteEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "QueueObjectColumnEditPagePageLoadCompleteStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "QueueObjectColumnEditPagePageLoadCompleteStartMessage";
					result = QueueObjectColumnEditPagePageLoadCompleteStartMessage.Execute(context);
					break;
				case "QueueObjectColumnEditPagePageLoadCompleteScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "QueueObjectColumnEditPagePageLoadCompleteScriptTask";
					result = QueueObjectColumnEditPagePageLoadCompleteScriptTask.Execute(context, QueueObjectColumnEditPagePageLoadCompleteScriptTaskExecute);
					break;
				case "QueueObjectColumnEditPagePageLoadCompleteIntermediateThrowMessageEvent":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "PageLoadComplete");
					result = QueueObjectColumnEditPagePageLoadCompleteIntermediateThrowMessageEvent.Execute(context);
					break;
				case "CaptionEditChangeEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "CaptionEditChangeStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "CaptionEditChangeStartMessage";
					result = CaptionEditChangeStartMessage.Execute(context);
					break;
				case "CaptionEditChangeScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "CaptionEditChangeScriptTask";
					result = CaptionEditChangeScriptTask.Execute(context, CaptionEditChangeScriptTaskExecute);
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
				case "QueueObjectSchemaUId":
					QueueObjectSchemaUId = reader.GetValue<System.Guid>();
				break;
			}
		}

		#endregion

		#region Methods: Public

		public virtual bool QueueObjectColumnEditPageInitScriptTaskExecute(ProcessExecutingContext context) {
			Page.DataSource.BeforeSaveRow += delegate(object sender, DataSourceEventArgs e) {
	ComboBoxEdit captionEdit = Page.CaptionEdit;
	Guid uid;
	if (!Guid.TryParse(captionEdit.Value.ToString(), out uid) || QueueObjectSchemaUId == Guid.Empty) {
		return;
	}
	EntitySchemaManager entitySchemaManager = UserConnection.EntitySchemaManager;
	EntitySchema schema = entitySchemaManager.GetInstanceByUId(QueueObjectSchemaUId);
	Entity activeRow = Page.DataSource.ActiveRow;
	EntitySchemaColumnCollection columns = schema.Columns;
	EntitySchemaColumn column = columns.GetByUId(uid);
	activeRow.SetColumnValue("Name", column.Name);
};
return true;
		}

		public virtual bool QueueObjectColumnEditPagePageLoadCompleteScriptTaskExecute(ProcessExecutingContext context) {
			Guid queueObjectId;
if (Guid.TryParse(Page.Request.QueryString["ParentEntityId"], out queueObjectId)) {
	Page.DataSource.ActiveRow.SetColumnValue("QueueObjectId", queueObjectId);
}
FillQueueObjectColumnList();
return true;
		}

		public virtual bool CaptionEditChangeScriptTaskExecute(ProcessExecutingContext context) {
			Entity activeRow = Page.DataSource.ActiveRow;
ComboBoxEdit captionEdit = Page.CaptionEdit;
activeRow.SetColumnValue("Caption", captionEdit.Text);
return true;
		}

		public virtual void FillQueueObjectColumnList() {
			ComboBoxEdit captionEdit = Page.CaptionEdit;
captionEdit.Clear();
Entity activeRow = Page.DataSource.ActiveRow;
Guid queueObjectId = activeRow.GetTypedColumnValue<Guid>("QueueObjectId");
if (queueObjectId == Guid.Empty) {
	return;
}
EntitySchemaManager entitySchemaManager = UserConnection.EntitySchemaManager;
EntitySchema queueObjectSchema = entitySchemaManager.GetInstanceByName("QueueObject");
Entity queueObjectEntity = queueObjectSchema.CreateEntity(UserConnection);
Guid entitySchemaUId = Guid.Empty;
if (queueObjectEntity.FetchFromDB(queueObjectSchema.GetPrimaryColumnName(), queueObjectId,
	new List<string>{"EntitySchemaUId"})) {
	entitySchemaUId = queueObjectEntity.GetTypedColumnValue<Guid>("EntitySchemaUId");
	QueueObjectSchemaUId = entitySchemaUId;
}
if (entitySchemaUId == Guid.Empty) {
	return;
}
Guid uid = Guid.Empty;
string caption = string.Empty;
EntitySchema schema  = entitySchemaManager.GetInstanceByUId(entitySchemaUId);
var columns = new Dictionary<Guid, string>();
for (int i = 0; i < schema.Columns.Count; i++) {
	EntitySchemaColumn column = schema.Columns[i]; 
	columns.Add(column.UId, column.Caption);
	if (activeRow.GetTypedColumnValue<string>("Name") == column.Name) {
		uid = column.UId;
		caption = column.Caption;
	}
}
IOrderedEnumerable<KeyValuePair<System.Guid,string>> sortedColumnCollection =
	from column in columns orderby column.Value ascending select column;
Dictionary<Guid, string> sortedColumns = sortedColumnCollection.ToDictionary(pair => pair.Key, pair => pair.Value);
foreach (KeyValuePair<Guid, string> column in sortedColumns) {
	captionEdit.AddItem(column.Key, column.Value);
}
if (uid != Guid.Empty) {
	captionEdit.SetValueAndText(uid, caption);
} else if (sortedColumns.Count == 1){
	KeyValuePair<Guid, string> value = sortedColumns.First();
	captionEdit.SetValueAndText(value.Key, value.Value);
}
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "Init":
							if (ActivatedEventElements.Contains("QueueObjectColumnEditPageInitStartMessage")) {
							context.QueueTasks.Enqueue("QueueObjectColumnEditPageInitStartMessage");
							ProcessQueue(context);
							return;
						}
						break;
					case "PageLoadComplete":
							if (ActivatedEventElements.Contains("QueueObjectColumnEditPagePageLoadCompleteStartMessage")) {
							context.QueueTasks.Enqueue("QueueObjectColumnEditPagePageLoadCompleteStartMessage");
							ProcessQueue(context);
							return;
						}
						break;
					case "CaptionEditChange":
							if (ActivatedEventElements.Contains("CaptionEditChangeStartMessage")) {
							context.QueueTasks.Enqueue("CaptionEditChangeStartMessage");
						}
						break;
			}
			base.ThrowEvent(context, message);
			ProcessQueue(context);
		}

		public override void WritePropertiesData(DataWriter writer, bool writeFlowElements = true) {
			base.WritePropertiesData(writer, writeFlowElements);
			if (!HasMapping("QueueObjectSchemaUId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("QueueObjectSchemaUId", QueueObjectSchemaUId, Guid.Empty);
			}
		}

		public override object CloneShallow() {
			return base.CloneShallow();
		}

		#endregion

	}

	#endregion

	#region Class: QueueObjectColumnEditPageEventsProcess

	/// <exclude/>
	public class QueueObjectColumnEditPageEventsProcess : QueueObjectColumnEditPageEventsProcess<Terrasoft.WebApp.QueueObjectColumnEditPageSchemaUserControl>
	{

		public QueueObjectColumnEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: QueueObjectColumnEditPageSchemaUserControl

	/// <exclude/>
	public partial class QueueObjectColumnEditPageSchemaUserControl : Terrasoft.WebApp.BaseEditPageSchemaUserControl
	{

		#region Properties: Public

		public Terrasoft.UI.WebControls.Controls.ControlLayout ControlsControlLayout {
			get {
				return (Terrasoft.UI.WebControls.Controls.ControlLayout)PageContainer.FindPageControl("ControlsControlLayout", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ComboBoxEdit CaptionEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.ComboBoxEdit)PageContainer.FindPageControl("CaptionEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ComboBoxEdit OrderDirectionEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.ComboBoxEdit)PageContainer.FindPageControl("OrderDirectionEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.IntegerEdit PositionEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.IntegerEdit)PageContainer.FindPageControl("PositionEdit", true);
			}
		}

		#endregion

		#region Methods: Protected

		protected override void SubscribeOnControlEvents() {
			base.SubscribeOnControlEvents();
			CaptionEdit.AjaxEvents.Change.Event += CaptionEditChange;
		}

		protected override void UnsubscribeOnControlEvents() {
			base.UnsubscribeOnControlEvents();
			CaptionEdit.AjaxEvents.Change.Event -= CaptionEditChange;
		}

		protected override void InitializeEmbeddedProcess() {
			var instanceId = ((Terrasoft.UI.WebControls.Page)Page).InstanceId.ToString();
			string processUId = instanceId + PageContainer.UniqueID;
			var process = (QueueObjectColumnEditPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new QueueObjectColumnEditPageEventsProcess(UserConnection);
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

		public virtual void CaptionEditChange(object sender, EventArgs e) {
			object result = ThrowEvent("CaptionEditChange");
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
			SchemaName = "QueueObjectColumnEditPage";
		}

		#endregion

	}

	#endregion

	#region Class: QueueObjectColumnEditPageEventsProcessSchema

	/// <exclude/>
	public class QueueObjectColumnEditPageEventsProcessSchema : Terrasoft.WebApp.BaseEditPageEventsProcessSchema
	{

		#region Constructors: Public

		public QueueObjectColumnEditPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public QueueObjectColumnEditPageEventsProcessSchema(QueueObjectColumnEditPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "QueueObjectColumnEditPageEventsProcess";
			UId = new Guid("827c3a82-3068-42d2-89b6-32a40208f63f");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsActiveVersion = false;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
		}

		protected virtual ProcessSchemaParameter CreateQueueObjectSchemaUIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("54b14b85-4aa2-4df0-8717-019c7b6360cf"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("827c3a82-3068-42d2-89b6-32a40208f63f"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("827c3a82-3068-42d2-89b6-32a40208f63f"),
				Name = @"QueueObjectSchemaUId",
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateQueueObjectSchemaUIdParameter());
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaQueueObjectColumnEditPageLaneSet = CreateQueueObjectColumnEditPageLaneSetLaneSet();
			LaneSets.Add(schemaQueueObjectColumnEditPageLaneSet);
			ProcessSchemaLane schemaQueueObjectColumnEditPageEventsLane = CreateQueueObjectColumnEditPageEventsLaneLane();
			schemaQueueObjectColumnEditPageLaneSet.Lanes.Add(schemaQueueObjectColumnEditPageEventsLane);
			ProcessSchemaLane schemaCaptionEditLane = CreateCaptionEditLaneLane();
			schemaQueueObjectColumnEditPageLaneSet.Lanes.Add(schemaCaptionEditLane);
			ProcessSchemaEventSubProcess queueobjectcolumneditpageiniteventsubprocess = CreateQueueObjectColumnEditPageInitEventSubProcessEventSubProcess();
			FlowElements.Add(queueobjectcolumneditpageiniteventsubprocess);
			ProcessSchemaEventSubProcess queueobjectcolumneditpagepageloadcompleteeventsubprocess = CreateQueueObjectColumnEditPagePageLoadCompleteEventSubProcessEventSubProcess();
			FlowElements.Add(queueobjectcolumneditpagepageloadcompleteeventsubprocess);
			ProcessSchemaEventSubProcess captioneditchangeeventsubprocess = CreateCaptionEditChangeEventSubProcessEventSubProcess();
			FlowElements.Add(captioneditchangeeventsubprocess);
			ProcessSchemaStartMessageEvent queueobjectcolumneditpageinitstartmessage = CreateQueueObjectColumnEditPageInitStartMessageStartMessageEvent();
			queueobjectcolumneditpageiniteventsubprocess.FlowElements.Add(queueobjectcolumneditpageinitstartmessage);
			ProcessSchemaScriptTask queueobjectcolumneditpageinitscripttask = CreateQueueObjectColumnEditPageInitScriptTaskScriptTask();
			queueobjectcolumneditpageiniteventsubprocess.FlowElements.Add(queueobjectcolumneditpageinitscripttask);
			ProcessSchemaIntermediateThrowMessageEvent queueobjectcolumneditpageinitintermediatethrowmessageevent = CreateQueueObjectColumnEditPageInitIntermediateThrowMessageEventIntermediateThrowMessageEvent();
			queueobjectcolumneditpageiniteventsubprocess.FlowElements.Add(queueobjectcolumneditpageinitintermediatethrowmessageevent);
			ProcessSchemaStartMessageEvent queueobjectcolumneditpagepageloadcompletestartmessage = CreateQueueObjectColumnEditPagePageLoadCompleteStartMessageStartMessageEvent();
			queueobjectcolumneditpagepageloadcompleteeventsubprocess.FlowElements.Add(queueobjectcolumneditpagepageloadcompletestartmessage);
			ProcessSchemaScriptTask queueobjectcolumneditpagepageloadcompletescripttask = CreateQueueObjectColumnEditPagePageLoadCompleteScriptTaskScriptTask();
			queueobjectcolumneditpagepageloadcompleteeventsubprocess.FlowElements.Add(queueobjectcolumneditpagepageloadcompletescripttask);
			ProcessSchemaIntermediateThrowMessageEvent queueobjectcolumneditpagepageloadcompleteintermediatethrowmessageevent = CreateQueueObjectColumnEditPagePageLoadCompleteIntermediateThrowMessageEventIntermediateThrowMessageEvent();
			queueobjectcolumneditpagepageloadcompleteeventsubprocess.FlowElements.Add(queueobjectcolumneditpagepageloadcompleteintermediatethrowmessageevent);
			ProcessSchemaStartMessageEvent captioneditchangestartmessage = CreateCaptionEditChangeStartMessageStartMessageEvent();
			captioneditchangeeventsubprocess.FlowElements.Add(captioneditchangestartmessage);
			ProcessSchemaScriptTask captioneditchangescripttask = CreateCaptionEditChangeScriptTaskScriptTask();
			captioneditchangeeventsubprocess.FlowElements.Add(captioneditchangescripttask);
			FlowElements.Add(CreateSequenceFlow4087SequenceFlow());
			FlowElements.Add(CreateSequenceFlow4088SequenceFlow());
			FlowElements.Add(CreateSequenceFlow4089SequenceFlow());
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4087SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4087",
				UId = new Guid("76c21413-183a-4c83-a3d6-9d84d82cf0f2"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("7be0af39-38cd-442a-b589-d8f3ef3f4d19"),
				CreatedInSchemaUId = new Guid("827c3a82-3068-42d2-89b6-32a40208f63f"),
				CurveCenterPosition = new Point(168, 252),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("827c3a82-3068-42d2-89b6-32a40208f63f"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("43348fba-3753-4ef8-a02e-1b7fb0d26365"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("93c26f79-2ef9-4d2b-926d-19848879a252"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4088SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4088",
				UId = new Guid("9dc56d83-8fbf-43b8-98f9-6fdd640a0253"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("7be0af39-38cd-442a-b589-d8f3ef3f4d19"),
				CreatedInSchemaUId = new Guid("827c3a82-3068-42d2-89b6-32a40208f63f"),
				CurveCenterPosition = new Point(215, 252),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("827c3a82-3068-42d2-89b6-32a40208f63f"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("aa2592b6-bb00-452f-bcba-fd7c56e9e4e5"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("4ec35cfe-a23d-4208-b0bc-81e396986ace"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4089SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4089",
				UId = new Guid("bdd88def-415f-4e6f-bfe1-1b92935aa241"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("7be0af39-38cd-442a-b589-d8f3ef3f4d19"),
				CreatedInSchemaUId = new Guid("827c3a82-3068-42d2-89b6-32a40208f63f"),
				CurveCenterPosition = new Point(215, 252),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("827c3a82-3068-42d2-89b6-32a40208f63f"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("69d0bfa6-0f17-40c2-8f75-b6b52ee6a9be"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("aa2592b6-bb00-452f-bcba-fd7c56e9e4e5"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("26357628-1478-445e-bfca-dee8e922b505"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("7be0af39-38cd-442a-b589-d8f3ef3f4d19"),
				CreatedInSchemaUId = new Guid("827c3a82-3068-42d2-89b6-32a40208f63f"),
				CurveCenterPosition = new Point(344, 81),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("827c3a82-3068-42d2-89b6-32a40208f63f"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("93c26f79-2ef9-4d2b-926d-19848879a252"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("d248114f-1d6f-4252-b115-1d6ff1dd3d99"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("1d121615-da6b-4f2e-a8b2-04addef88565"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("7be0af39-38cd-442a-b589-d8f3ef3f4d19"),
				CreatedInSchemaUId = new Guid("827c3a82-3068-42d2-89b6-32a40208f63f"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("827c3a82-3068-42d2-89b6-32a40208f63f"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("a462ea07-e11f-4b54-b08a-96171695f911"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("3f5a47a0-2f7b-4779-8e3c-574cae72f20e"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateQueueObjectColumnEditPageLaneSetLaneSet() {
			ProcessSchemaLaneSet schemaQueueObjectColumnEditPageLaneSet = new ProcessSchemaLaneSet(this) {
				UId = new Guid("06170736-1f5c-4bb2-95c2-0e0bd5974fc4"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("7be0af39-38cd-442a-b589-d8f3ef3f4d19"),
				CreatedInSchemaUId = new Guid("827c3a82-3068-42d2-89b6-32a40208f63f"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("827c3a82-3068-42d2-89b6-32a40208f63f"),
				Name = @"QueueObjectColumnEditPageLaneSet",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(5, 5),
				Size = new Size(921, 508)
			};
			return schemaQueueObjectColumnEditPageLaneSet;
		}

		protected virtual ProcessSchemaLane CreateQueueObjectColumnEditPageEventsLaneLane() {
			ProcessSchemaLane schemaQueueObjectColumnEditPageEventsLane = new ProcessSchemaLane(this) {
				UId = new Guid("ca0cbac0-7350-40e4-bdf6-3714dce8c81c"),
				ContainerItemIndex = 2,
				ContainerUId = new Guid("06170736-1f5c-4bb2-95c2-0e0bd5974fc4"),
				CreatedInOwnerSchemaUId = new Guid("adbd57ce-303c-472a-b08a-37a41d556f17"),
				CreatedInPackageId = new Guid("7be0af39-38cd-442a-b589-d8f3ef3f4d19"),
				CreatedInSchemaUId = new Guid("827c3a82-3068-42d2-89b6-32a40208f63f"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("827c3a82-3068-42d2-89b6-32a40208f63f"),
				Name = @"QueueObjectColumnEditPageEventsLane",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 170),
				Size = new Size(892, 338)
			};
			return schemaQueueObjectColumnEditPageEventsLane;
		}

		protected virtual ProcessSchemaLane CreateCaptionEditLaneLane() {
			ProcessSchemaLane schemaCaptionEditLane = new ProcessSchemaLane(this) {
				UId = new Guid("e437b9fc-8418-4ee8-a87a-b05427f6da87"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("06170736-1f5c-4bb2-95c2-0e0bd5974fc4"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("7be0af39-38cd-442a-b589-d8f3ef3f4d19"),
				CreatedInSchemaUId = new Guid("827c3a82-3068-42d2-89b6-32a40208f63f"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("827c3a82-3068-42d2-89b6-32a40208f63f"),
				Name = @"CaptionEditLane",
				Position = new Point(29, 0),
				Size = new Size(892, 165)
			};
			return schemaCaptionEditLane;
		}

		protected virtual ProcessSchemaEventSubProcess CreateQueueObjectColumnEditPageInitEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaQueueObjectColumnEditPageInitEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("ffa9f5fa-8bec-47f1-bc80-76004d116053"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ca0cbac0-7350-40e4-bdf6-3714dce8c81c"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("7be0af39-38cd-442a-b589-d8f3ef3f4d19"),
				CreatedInSchemaUId = new Guid("827c3a82-3068-42d2-89b6-32a40208f63f"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("827c3a82-3068-42d2-89b6-32a40208f63f"),
				Name = @"QueueObjectColumnEditPageInitEventSubProcess",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(35, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(561, 147),
				TriggeredByEvent = true,
				UseLastSchemaVersion = false
			};
			
			return schemaQueueObjectColumnEditPageInitEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateQueueObjectColumnEditPageInitStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("43348fba-3753-4ef8-a02e-1b7fb0d26365"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ffa9f5fa-8bec-47f1-bc80-76004d116053"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("7be0af39-38cd-442a-b589-d8f3ef3f4d19"),
				CreatedInSchemaUId = new Guid("827c3a82-3068-42d2-89b6-32a40208f63f"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("827c3a82-3068-42d2-89b6-32a40208f63f"),
				Name = @"QueueObjectColumnEditPageInitStartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(15, 58),
				SerializeToDB = false,
				Size = new Size(0, 0)
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateQueueObjectColumnEditPageInitScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("93c26f79-2ef9-4d2b-926d-19848879a252"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ffa9f5fa-8bec-47f1-bc80-76004d116053"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("7be0af39-38cd-442a-b589-d8f3ef3f4d19"),
				CreatedInSchemaUId = new Guid("827c3a82-3068-42d2-89b6-32a40208f63f"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("827c3a82-3068-42d2-89b6-32a40208f63f"),
				Name = @"QueueObjectColumnEditPageInitScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(148, 44),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,145,193,110,131,48,12,134,207,157,180,119,240,122,2,13,229,5,42,14,45,67,85,15,219,216,104,119,79,193,101,76,144,84,137,211,13,173,125,247,37,132,181,85,197,193,33,49,254,127,127,137,51,94,33,123,226,196,115,105,84,129,108,129,59,169,48,231,7,124,151,223,240,24,67,137,13,86,156,48,144,219,47,44,8,52,138,18,85,4,23,77,122,64,65,115,85,105,192,16,126,239,239,38,137,108,183,114,33,127,210,178,38,40,248,158,106,41,250,125,12,153,107,151,92,82,51,91,190,52,117,9,54,220,190,222,65,240,224,18,108,173,186,140,43,141,193,149,1,251,224,141,65,182,150,57,169,90,84,65,24,129,52,228,180,33,28,143,240,102,208,224,107,143,153,23,159,216,242,205,170,132,56,134,222,47,109,247,212,121,190,137,66,50,74,184,126,39,27,169,160,154,58,175,120,230,194,18,42,192,145,92,12,27,141,42,145,66,216,6,150,136,141,8,103,55,126,160,253,39,30,115,100,75,164,149,208,196,69,129,139,206,194,6,99,55,8,47,158,192,109,99,63,153,225,41,175,38,55,255,255,119,203,144,200,198,180,194,174,141,231,134,162,79,104,235,225,233,152,175,208,227,194,161,220,86,15,58,135,237,113,221,195,59,209,25,139,229,72,94,213,79,42,152,190,240,22,167,209,160,100,238,228,4,39,27,126,6,64,202,224,236,15,192,161,136,234,133,2,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateQueueObjectColumnEditPageInitIntermediateThrowMessageEventIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("d248114f-1d6f-4252-b115-1d6ff1dd3d99"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ffa9f5fa-8bec-47f1-bc80-76004d116053"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("7be0af39-38cd-442a-b589-d8f3ef3f4d19"),
				CreatedInSchemaUId = new Guid("827c3a82-3068-42d2-89b6-32a40208f63f"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("827c3a82-3068-42d2-89b6-32a40208f63f"),
				Name = @"QueueObjectColumnEditPageInitIntermediateThrowMessageEvent",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(330, 58),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateQueueObjectColumnEditPagePageLoadCompleteEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaQueueObjectColumnEditPagePageLoadCompleteEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("02ae54af-3619-49ff-bac7-7db6a6f96d5f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ca0cbac0-7350-40e4-bdf6-3714dce8c81c"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("7be0af39-38cd-442a-b589-d8f3ef3f4d19"),
				CreatedInSchemaUId = new Guid("827c3a82-3068-42d2-89b6-32a40208f63f"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("827c3a82-3068-42d2-89b6-32a40208f63f"),
				Name = @"QueueObjectColumnEditPagePageLoadCompleteEventSubProcess",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(35, 168),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(348, 154),
				TriggeredByEvent = true,
				UseLastSchemaVersion = false
			};
			
			return schemaQueueObjectColumnEditPagePageLoadCompleteEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateQueueObjectColumnEditPagePageLoadCompleteStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("69d0bfa6-0f17-40c2-8f75-b6b52ee6a9be"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("02ae54af-3619-49ff-bac7-7db6a6f96d5f"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("7be0af39-38cd-442a-b589-d8f3ef3f4d19"),
				CreatedInSchemaUId = new Guid("827c3a82-3068-42d2-89b6-32a40208f63f"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("827c3a82-3068-42d2-89b6-32a40208f63f"),
				Name = @"QueueObjectColumnEditPagePageLoadCompleteStartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(15, 65),
				SerializeToDB = false,
				Size = new Size(0, 0)
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateQueueObjectColumnEditPagePageLoadCompleteScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("4ec35cfe-a23d-4208-b0bc-81e396986ace"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("02ae54af-3619-49ff-bac7-7db6a6f96d5f"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("7be0af39-38cd-442a-b589-d8f3ef3f4d19"),
				CreatedInSchemaUId = new Guid("827c3a82-3068-42d2-89b6-32a40208f63f"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("827c3a82-3068-42d2-89b6-32a40208f63f"),
				Name = @"QueueObjectColumnEditPagePageLoadCompleteScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(246, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,93,142,203,10,194,48,16,69,215,22,250,15,33,171,8,37,63,208,149,248,40,5,193,62,196,141,184,136,237,88,34,49,193,116,70,41,226,191,27,117,83,93,159,115,15,55,35,221,178,43,1,193,230,120,134,6,243,54,141,35,125,98,34,11,64,110,253,80,40,223,131,40,84,7,178,130,32,246,40,75,2,63,212,232,181,237,246,60,112,176,184,180,168,113,200,91,126,72,152,35,252,45,78,167,236,17,71,147,79,99,161,80,213,142,124,3,114,214,160,190,65,229,238,178,6,156,59,67,23,187,83,134,64,240,114,188,230,201,95,45,28,124,198,209,74,27,51,242,190,251,181,238,81,188,5,15,72,222,50,244,4,233,11,199,158,186,11,227,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateQueueObjectColumnEditPagePageLoadCompleteIntermediateThrowMessageEventIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("aa2592b6-bb00-452f-bcba-fd7c56e9e4e5"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("02ae54af-3619-49ff-bac7-7db6a6f96d5f"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("7be0af39-38cd-442a-b589-d8f3ef3f4d19"),
				CreatedInSchemaUId = new Guid("827c3a82-3068-42d2-89b6-32a40208f63f"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("827c3a82-3068-42d2-89b6-32a40208f63f"),
				Name = @"QueueObjectColumnEditPagePageLoadCompleteIntermediateThrowMessageEvent",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(120, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateCaptionEditChangeEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaCaptionEditChangeEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("c5ed15f7-562d-45b1-9f31-f9e8a786c4c2"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e437b9fc-8418-4ee8-a87a-b05427f6da87"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("7be0af39-38cd-442a-b589-d8f3ef3f4d19"),
				CreatedInSchemaUId = new Guid("827c3a82-3068-42d2-89b6-32a40208f63f"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("827c3a82-3068-42d2-89b6-32a40208f63f"),
				Name = @"CaptionEditChangeEventSubProcess",
				Position = new Point(35, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(374, 144),
				TriggeredByEvent = true,
				UseLastSchemaVersion = false
			};
			
			return schemaCaptionEditChangeEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateCaptionEditChangeStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("a462ea07-e11f-4b54-b08a-96171695f911"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c5ed15f7-562d-45b1-9f31-f9e8a786c4c2"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("7be0af39-38cd-442a-b589-d8f3ef3f4d19"),
				CreatedInSchemaUId = new Guid("827c3a82-3068-42d2-89b6-32a40208f63f"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"CaptionEditChange",
				ModifiedInSchemaUId = new Guid("827c3a82-3068-42d2-89b6-32a40208f63f"),
				Name = @"CaptionEditChangeStartMessage",
				Position = new Point(36, 51),
				SerializeToDB = false,
				Size = new Size(0, 0)
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateCaptionEditChangeScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("3f5a47a0-2f7b-4779-8e3c-574cae72f20e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c5ed15f7-562d-45b1-9f31-f9e8a786c4c2"),
				CreatedInOwnerSchemaUId = new Guid("f2cbd3e3-c9d6-4eba-8389-0f8630aa78f1"),
				CreatedInPackageId = new Guid("7be0af39-38cd-442a-b589-d8f3ef3f4d19"),
				CreatedInSchemaUId = new Guid("827c3a82-3068-42d2-89b6-32a40208f63f"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("827c3a82-3068-42d2-89b6-32a40208f63f"),
				Name = @"CaptionEditChangeScriptTask",
				Position = new Point(211, 37),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,115,205,43,201,44,169,84,72,76,46,201,44,75,13,202,47,87,176,85,8,72,76,79,213,115,73,44,73,12,206,47,45,74,78,213,115,132,201,89,243,114,57,231,231,38,229,59,229,87,184,166,100,150,40,36,39,22,148,100,230,231,129,217,80,109,206,8,33,160,106,184,169,122,193,169,37,206,249,57,165,185,121,97,137,57,165,169,26,74,80,117,74,58,200,134,232,133,164,86,148,104,2,245,21,165,150,148,22,229,41,148,20,149,166,90,3,0,246,238,232,54,161,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateFillQueueObjectColumnListMethod());
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
				Alias = "TSConfiguration",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("2f50a15b-41f7-4f3a-bd8f-0eb6fecaf008"),
				Name = "Terrasoft.Web.Common",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("9583f8a5-5143-49b3-9f04-2a885857cda4"),
				Name = "System.Linq",
				Alias = "",
				CreatedInPackageId = new Guid("7be0af39-38cd-442a-b589-d8f3ef3f4d19")
			});
		}

		protected virtual SchemaMethod CreateFillQueueObjectColumnListMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("19620c0b-d166-4124-bc15-a7a15d37bcd1"),
				Name = "FillQueueObjectColumnList",
				CreatedInSchemaUId = new Guid("827c3a82-3068-42d2-89b6-32a40208f63f"),
				CreatedInPackageId = new Guid("7be0af39-38cd-442a-b589-d8f3ef3f4d19"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,85,91,111,218,48,20,126,166,82,255,131,151,167,68,69,214,246,12,65,106,129,86,104,151,182,131,238,101,218,131,73,14,173,39,98,51,219,105,27,85,252,247,29,219,73,19,19,134,246,0,137,108,159,239,124,151,99,152,202,98,45,175,228,235,60,231,134,100,108,103,184,20,238,61,37,119,236,17,232,180,93,26,157,159,117,14,208,233,22,152,138,19,92,157,11,195,77,69,88,102,248,51,124,151,47,77,237,140,25,182,148,165,202,128,94,54,123,120,252,166,228,57,249,83,66,9,183,235,223,144,153,69,142,5,239,197,244,6,204,170,218,65,62,149,219,178,16,63,216,182,132,177,45,153,196,209,125,183,40,178,173,249,134,196,7,80,41,177,167,233,188,216,153,42,33,111,231,103,3,5,166,84,2,79,239,27,174,203,236,9,10,246,149,9,164,169,8,28,89,75,201,131,6,53,149,66,32,44,74,166,71,10,71,33,92,87,83,189,146,30,195,182,10,23,66,27,38,50,184,170,190,177,2,2,101,81,199,210,14,98,189,146,246,187,208,169,2,102,192,31,136,67,218,73,227,119,151,199,131,115,188,117,169,239,163,199,162,215,96,178,167,107,37,139,217,85,220,111,139,50,238,20,47,152,170,124,84,78,73,50,12,163,29,162,255,2,94,200,23,174,205,88,27,197,197,227,228,45,154,135,108,162,125,226,147,234,179,236,147,58,49,31,135,176,86,253,224,254,144,184,7,62,104,229,167,195,218,208,227,112,122,160,156,187,246,115,224,168,215,218,92,41,220,245,11,239,251,193,228,104,255,248,159,121,65,74,135,20,173,204,103,166,72,230,28,209,136,98,29,159,113,55,1,24,143,179,103,88,19,152,184,43,187,145,138,196,92,24,194,241,244,199,17,62,198,53,9,234,125,213,248,44,133,193,157,139,11,47,186,75,216,159,169,27,90,109,65,233,79,254,107,68,176,162,230,67,47,243,60,246,239,20,217,14,235,178,230,167,197,133,100,141,63,253,19,208,176,143,236,152,69,137,141,165,198,177,11,158,226,192,231,208,246,178,208,131,54,130,176,177,221,220,187,12,23,183,42,7,5,249,92,148,5,40,182,222,194,248,51,84,174,239,29,227,106,188,172,180,129,130,58,27,107,30,19,162,165,50,13,69,252,222,250,11,71,82,68,221,224,149,105,204,225,226,61,23,105,187,172,171,134,134,195,39,76,103,32,114,59,42,26,44,70,189,139,228,254,21,96,208,217,166,125,156,9,93,201,22,33,222,161,14,146,78,136,125,82,20,55,36,193,138,227,82,15,6,176,236,137,196,129,1,97,255,86,89,192,196,103,208,253,139,192,224,23,104,92,19,190,107,219,21,159,180,183,206,38,247,161,127,211,186,104,75,48,174,234,82,228,43,120,53,177,227,148,181,67,180,39,176,213,64,44,90,192,203,79,178,29,152,79,137,197,60,161,236,217,69,18,58,170,233,53,87,218,184,107,115,146,143,43,246,34,253,107,171,241,47,70,123,233,121,102,7,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new QueueObjectColumnEditPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("827c3a82-3068-42d2-89b6-32a40208f63f"));
		}

		#endregion

	}

	#endregion

}

