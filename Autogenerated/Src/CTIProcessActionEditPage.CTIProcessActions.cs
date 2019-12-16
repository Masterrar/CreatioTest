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

	#region Class: CTIProcessActionEditPageSchema

	/// <exclude/>
	public class CTIProcessActionEditPageSchema : Terrasoft.WebApp.BaseLookupEditPageSchema
	{

		#region Properties: Public

		private Terrasoft.UI.WebControls.Controls.LookupEdit _processSchemaEdit;
		public Terrasoft.UI.WebControls.Controls.LookupEdit ProcessSchemaEdit {
			get {
				return _processSchemaEdit;
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

		public CTIProcessActionEditPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public CTIProcessActionEditPageSchema(CTIProcessActionEditPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateNameEdit() {
			NameEdit.Image = new ControlImage {};
			NameEdit.ColumnUId = new Guid("1d590de5-e6fa-4f95-99d0-c20773e12a28");
			NameEdit.ModifiedInSchemaUId = new Guid("ec45eeb7-6c61-4712-a626-07416c4b6bcc");
		}

		private void UpdateDescriptionEdit() {
			DescriptionEdit.ColumnUId = new Guid("39ef3f66-ce9e-4742-9416-7f18ae10894d");
			DescriptionEdit.ModifiedInSchemaUId = new Guid("ec45eeb7-6c61-4712-a626-07416c4b6bcc");
		}

		private void UpdateCustomControls() {
			CustomControls.Image = new ControlImage {};
			CustomControls.ModifiedInSchemaUId = new Guid("ec45eeb7-6c61-4712-a626-07416c4b6bcc");
		}

		private void UpdateMainControlLayout() {
			MainControlLayout.Image = new ControlImage {};
			MainControlLayout.ModifiedInSchemaUId = new Guid("ec45eeb7-6c61-4712-a626-07416c4b6bcc");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("ec45eeb7-6c61-4712-a626-07416c4b6bcc");
		}

		private void UpdateDesignerModeButton() {
			DesignerModeButton.AjaxEvents.Click.IsProcessEventHandler = true;
			DesignerModeButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("a5bcc8d7-215f-41c5-8f3c-f96f57d48c34"),
				ImageHash = @"682ad9264105b2170afb821fabf80415"
			};
			DesignerModeButton.ModifiedInSchemaUId = new Guid("ec45eeb7-6c61-4712-a626-07416c4b6bcc");
		}

		private void UpdateOKButton() {
			OKButton.AjaxEvents.Click.IsProcessEventHandler = true;
			OKButton.Image = new ControlImage {};
			OKButton.ModifiedInSchemaUId = new Guid("ec45eeb7-6c61-4712-a626-07416c4b6bcc");
		}

		private void UpdateCancelButton() {
			CancelButton.AjaxEvents.Click.IsProcessEventHandler = true;
			CancelButton.Image = new ControlImage {};
			CancelButton.ModifiedInSchemaUId = new Guid("ec45eeb7-6c61-4712-a626-07416c4b6bcc");
		}

		private void UpdateApplyChangesButton() {
			ApplyChangesButton.AjaxEvents.Click.IsProcessEventHandler = true;
			ApplyChangesButton.Image = new ControlImage {};
			ApplyChangesButton.ModifiedInSchemaUId = new Guid("ec45eeb7-6c61-4712-a626-07416c4b6bcc");
		}

		private void UpdateButtonsControlLayout() {
			ButtonsControlLayout.Image = new ControlImage {};
			ButtonsControlLayout.ModifiedInSchemaUId = new Guid("ec45eeb7-6c61-4712-a626-07416c4b6bcc");
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("ec45eeb7-6c61-4712-a626-07416c4b6bcc");
			RealUId = new Guid("ec45eeb7-6c61-4712-a626-07416c4b6bcc");
			Name = "CTIProcessActionEditPage";
			ParentSchemaUId = new Guid("8c1db28c-4687-4b3b-b696-c32413d5825e");
			CreatedInPackageId = new Guid("ccb8f7c7-6ff2-443f-9c1f-d56a09d4a46e");
			Height = 230;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateCTIProcessActionEditPageEventsProcessSchema();
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
			UpdateDescriptionEdit();
			UpdateNameEdit();
			TopLevelControl.MoveItem(0, BaseMessagePanel);
			TopLevelControl.MoveItem(1, MainControlLayout);
			MainControlLayout.MoveItem(0, NameEdit);
			MainControlLayout.InsertItem(1, CreateProcessSchemaEdit());
			MainControlLayout.InsertItem(2, CreatePositionEdit());
			MainControlLayout.MoveItem(3, DescriptionEdit);
			MainControlLayout.MoveItem(4, CustomControls);
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

		protected virtual EmbeddedProcessSchema CreateCTIProcessActionEditPageEventsProcessSchema() {
			var schema = new CTIProcessActionEditPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.LookupEdit CreateProcessSchemaEdit() {
			_processSchemaEdit = new Terrasoft.UI.WebControls.Controls.LookupEdit();
			_processSchemaEdit.UId = new Guid("deb1f3e6-57a2-49f7-afbd-fb9df245ff06");
			_processSchemaEdit.Name = "ProcessSchemaEdit";
			_processSchemaEdit.CreatedInSchemaUId = new Guid("ec45eeb7-6c61-4712-a626-07416c4b6bcc");
			_processSchemaEdit.ModifiedInSchemaUId = new Guid("ec45eeb7-6c61-4712-a626-07416c4b6bcc");
			_processSchemaEdit.CreatedInPackageId = new Guid("ccb8f7c7-6ff2-443f-9c1f-d56a09d4a46e");
			_processSchemaEdit.Tag = "";
			_processSchemaEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_processSchemaEdit.Image = new ControlImage {};
			_processSchemaEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_processSchemaEdit.DataSource = "DataSource";
			_processSchemaEdit.ColumnUId = new Guid("ff6903c8-4c61-42bb-9538-7bf9d43e0c5b");
			return _processSchemaEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.IntegerEdit CreatePositionEdit() {
			_positionEdit = new Terrasoft.UI.WebControls.Controls.IntegerEdit();
			_positionEdit.UId = new Guid("71baeae0-ada6-46c1-898a-5436b656a12d");
			_positionEdit.Name = "PositionEdit";
			_positionEdit.CreatedInSchemaUId = new Guid("ec45eeb7-6c61-4712-a626-07416c4b6bcc");
			_positionEdit.ModifiedInSchemaUId = new Guid("ec45eeb7-6c61-4712-a626-07416c4b6bcc");
			_positionEdit.CreatedInPackageId = new Guid("ccb8f7c7-6ff2-443f-9c1f-d56a09d4a46e");
			_positionEdit.Tag = "";
			_positionEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_positionEdit.Image = new ControlImage {};
			_positionEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_positionEdit.DataSource = "DataSource";
			_positionEdit.ColumnUId = new Guid("3cba50cc-0916-48f5-8ae0-495e2d6485ce");
			return _positionEdit;
		}

		protected override void UpdateDataSource() {
			base.UpdateDataSource();
			DataSource.SchemaUId = new Guid("b0245e67-492f-4805-b212-5ba4b722ef01");
			DataSource.ModifiedInSchemaUId = new Guid("ec45eeb7-6c61-4712-a626-07416c4b6bcc");
			DataSourceStructureColumn column = null;
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ae0e45ca-c495-4fe7-a39d-3ab7278e1617");
			if (column != null) {
				column.UId = new Guid("2eef7d8d-caf4-4eff-bc86-e12852f78c61");
				column.Name = @"Id";
				column.CreatedInSchemaUId = new Guid("ec45eeb7-6c61-4712-a626-07416c4b6bcc");
				column.ModifiedInSchemaUId = new Guid("ec45eeb7-6c61-4712-a626-07416c4b6bcc");
				column.CreatedInPackageId = Guid.Empty;
				column.IsAlwaysSelect = true;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("e80190a5-03b2-4095-90f7-a193a960adee");
			if (column != null) {
				column.UId = new Guid("25f54589-70a4-4325-b95f-2f3fdc812f1d");
				column.Name = @"CreatedOn";
				column.CreatedInSchemaUId = new Guid("ec45eeb7-6c61-4712-a626-07416c4b6bcc");
				column.ModifiedInSchemaUId = new Guid("ec45eeb7-6c61-4712-a626-07416c4b6bcc");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ebf6bb93-8aa6-4a01-900d-c6ea67affe21");
			if (column != null) {
				column.UId = new Guid("c49a7b8f-e40a-45e1-863c-7ae6bf46bbcc");
				column.Name = @"CreatedBy";
				column.CreatedInSchemaUId = new Guid("ec45eeb7-6c61-4712-a626-07416c4b6bcc");
				column.ModifiedInSchemaUId = new Guid("ec45eeb7-6c61-4712-a626-07416c4b6bcc");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9928edec-4272-425a-93bb-48743fee4b04");
			if (column != null) {
				column.UId = new Guid("21d1ba39-01d6-488b-9a8c-d69d51dfe7a4");
				column.Name = @"ModifiedOn";
				column.CreatedInSchemaUId = new Guid("ec45eeb7-6c61-4712-a626-07416c4b6bcc");
				column.ModifiedInSchemaUId = new Guid("ec45eeb7-6c61-4712-a626-07416c4b6bcc");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3015559e-cbc6-406a-88af-07f7930be832");
			if (column != null) {
				column.UId = new Guid("4b775845-b092-4f5b-a19e-c01e17c3c406");
				column.Name = @"ModifiedBy";
				column.CreatedInSchemaUId = new Guid("ec45eeb7-6c61-4712-a626-07416c4b6bcc");
				column.ModifiedInSchemaUId = new Guid("ec45eeb7-6c61-4712-a626-07416c4b6bcc");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("736c30a7-c0ec-4fa9-b034-2552b319b633");
			if (column != null) {
				column.UId = new Guid("1d590de5-e6fa-4f95-99d0-c20773e12a28");
				column.Name = @"Name";
				column.CreatedInSchemaUId = new Guid("ec45eeb7-6c61-4712-a626-07416c4b6bcc");
				column.ModifiedInSchemaUId = new Guid("ec45eeb7-6c61-4712-a626-07416c4b6bcc");
				column.CreatedInPackageId = Guid.Empty;
				column.OrderDirection = OrderDirection.Ascending;
				column.OrderPosition = 1;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9e53fd7c-dde4-4502-a64c-b9e34148108b");
			if (column != null) {
				column.UId = new Guid("39ef3f66-ce9e-4742-9416-7f18ae10894d");
				column.Name = @"Description";
				column.CreatedInSchemaUId = new Guid("ec45eeb7-6c61-4712-a626-07416c4b6bcc");
				column.ModifiedInSchemaUId = new Guid("ec45eeb7-6c61-4712-a626-07416c4b6bcc");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3fabd836-6a53-4d8d-9069-6df88d9dae1e");
			if (column != null) {
				column.UId = new Guid("c0db4ad9-212b-45a9-b84b-0f25eb0e86c1");
				column.Name = @"ProcessListeners";
				column.CreatedInSchemaUId = new Guid("ec45eeb7-6c61-4712-a626-07416c4b6bcc");
				column.ModifiedInSchemaUId = new Guid("ec45eeb7-6c61-4712-a626-07416c4b6bcc");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("4ae77582-8fe4-4bfd-a257-d702ec30eedb");
			if (column != null) {
				column.UId = new Guid("ff6903c8-4c61-42bb-9538-7bf9d43e0c5b");
				column.Name = @"ProcessSchema";
				column.CreatedInSchemaUId = new Guid("ec45eeb7-6c61-4712-a626-07416c4b6bcc");
				column.ModifiedInSchemaUId = new Guid("ec45eeb7-6c61-4712-a626-07416c4b6bcc");
				column.CreatedInPackageId = Guid.Empty;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("d4084ad4-f993-438f-a2f7-6caf85cf845e");
			if (column != null) {
				column.UId = new Guid("3cba50cc-0916-48f5-8ae0-495e2d6485ce");
				column.Name = @"Position";
				column.CreatedInSchemaUId = new Guid("ec45eeb7-6c61-4712-a626-07416c4b6bcc");
				column.ModifiedInSchemaUId = new Guid("ec45eeb7-6c61-4712-a626-07416c4b6bcc");
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
			return new CTIProcessActionEditPageSchemaUserControl();
		}

		public override object Clone() {
			return new CTIProcessActionEditPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ec45eeb7-6c61-4712-a626-07416c4b6bcc"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new CTIProcessActionEditPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: CTIProcessActionEditPageEventsProcess

	/// <exclude/>
	public class CTIProcessActionEditPageEventsProcess<TPage> : Terrasoft.WebApp.BaseLookupEditPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.CTIProcessActionEditPageSchemaUserControl
	{

		public CTIProcessActionEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "CTIProcessActionEditPageEventsProcess";
			SchemaUId = new Guid("ec45eeb7-6c61-4712-a626-07416c4b6bcc");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("ec45eeb7-6c61-4712-a626-07416c4b6bcc");
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

		public virtual Object InvalidParameters {
			get;
			set;
		}

		public virtual bool IsParametersValid {
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
					SchemaElementUId = new Guid("986bde30-711a-412d-9cad-1cd9a3198899"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _initMessage;
		public ProcessFlowElement InitMessage {
			get {
				return _initMessage ?? (_initMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "InitMessage",
					SchemaElementUId = new Guid("b02d9cdb-2ede-4a04-8f81-5f491242c4ca"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _prepareFiltersScriptTask;
		public ProcessScriptTask PrepareFiltersScriptTask {
			get {
				return _prepareFiltersScriptTask ?? (_prepareFiltersScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "PrepareFiltersScriptTask",
					SchemaElementUId = new Guid("14f01944-622b-4c6d-9f95-362186eb763e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = PrepareFiltersScriptTaskExecute,
				});
			}
		}

		private ProcessThrowMessageEvent _parentInit;
		public ProcessThrowMessageEvent ParentInit {
			get {
				return _parentInit ?? (_parentInit = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "ParentInit",
					SchemaElementUId = new Guid("8f6b8a51-43a3-4534-987d-7238f06b010f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "Init",
						ThrowToBase = true,
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
					SchemaElementUId = new Guid("10ff5e5f-14c1-4d71-a38b-00b8f2215d0c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _oKButtonClickMessage;
		public ProcessFlowElement OKButtonClickMessage {
			get {
				return _oKButtonClickMessage ?? (_oKButtonClickMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "OKButtonClickMessage",
					SchemaElementUId = new Guid("5b5604f8-8807-4075-acf7-a01be1a006bb"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _checkParametersScriptTask;
		public ProcessScriptTask CheckParametersScriptTask {
			get {
				return _checkParametersScriptTask ?? (_checkParametersScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "CheckParametersScriptTask",
					SchemaElementUId = new Guid("18031a4d-ef12-4743-965b-1ba519688059"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = CheckParametersScriptTaskExecute,
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
					SchemaElementUId = new Guid("d92c75e6-9d75-42b7-bdb0-11a990d4ae4a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "OKButtonClick",
						ThrowToBase = true,
				});
			}
		}

		private ProcessScriptTask _printCheckParametersResultScriptTask;
		public ProcessScriptTask PrintCheckParametersResultScriptTask {
			get {
				return _printCheckParametersResultScriptTask ?? (_printCheckParametersResultScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "PrintCheckParametersResultScriptTask",
					SchemaElementUId = new Guid("12bce938-1ffe-4562-9132-bd6f15fd30ee"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = PrintCheckParametersResultScriptTaskExecute,
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
					SchemaElementUId = new Guid("3840e383-b03c-4af7-856f-8f14ae3a10c1"),
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

		private ProcessConditionalFlow _conditionalFlow1;
		public ProcessConditionalFlow ConditionalFlow1 {
			get {
				return _conditionalFlow1 ?? (_conditionalFlow1 = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ConditionalFlow1",
					SchemaElementUId = new Guid("d32cade9-c16d-47e3-96f3-5879c2c00b6f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private LocalizableString _invalidParametersMessage;
		public LocalizableString InvalidParametersMessage {
			get {
				return _invalidParametersMessage ?? (_invalidParametersMessage = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.InvalidParametersMessage.Value"));
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess1.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess1 };
			FlowElements[InitMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { InitMessage };
			FlowElements[PrepareFiltersScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { PrepareFiltersScriptTask };
			FlowElements[ParentInit.SchemaElementUId] = new Collection<ProcessFlowElement> { ParentInit };
			FlowElements[EventSubProcess2.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess2 };
			FlowElements[OKButtonClickMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { OKButtonClickMessage };
			FlowElements[CheckParametersScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { CheckParametersScriptTask };
			FlowElements[IntermediateThrowMessageEvent1.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowMessageEvent1 };
			FlowElements[PrintCheckParametersResultScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { PrintCheckParametersResultScriptTask };
			FlowElements[ExclusiveGateway2.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway2 };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess1":
						break;
					case "InitMessage":
						e.Context.QueueTasks.Enqueue("ParentInit");
						break;
					case "PrepareFiltersScriptTask":
						break;
					case "ParentInit":
						e.Context.QueueTasks.Enqueue("PrepareFiltersScriptTask");
						break;
					case "EventSubProcess2":
						break;
					case "OKButtonClickMessage":
						e.Context.QueueTasks.Enqueue("CheckParametersScriptTask");
						break;
					case "CheckParametersScriptTask":
						e.Context.QueueTasks.Enqueue("ExclusiveGateway2");
						break;
					case "IntermediateThrowMessageEvent1":
						break;
					case "PrintCheckParametersResultScriptTask":
						break;
					case "ExclusiveGateway2":
						if (ConditionalFlow1ExpressionExecute()) {
							e.Context.QueueTasks.Enqueue("PrintCheckParametersResultScriptTask");
							break;
						}
						e.Context.QueueTasks.Enqueue("IntermediateThrowMessageEvent1");
						break;
			}
			ProcessQueue(e.Context);
		}

		private bool ConditionalFlow1ExpressionExecute() {
			return Convert.ToBoolean(!IsParametersValid);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("InitMessage");
			ActivatedEventElements.Add("OKButtonClickMessage");
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
				case "InitMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "InitMessage";
					result = InitMessage.Execute(context);
					break;
				case "PrepareFiltersScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "PrepareFiltersScriptTask";
					result = PrepareFiltersScriptTask.Execute(context, PrepareFiltersScriptTaskExecute);
					break;
				case "ParentInit":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "Init");
					result = ParentInit.Execute(context);
					break;
				case "EventSubProcess2":
					context.QueueTasks.Dequeue();
					break;
				case "OKButtonClickMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "OKButtonClickMessage";
					result = OKButtonClickMessage.Execute(context);
					break;
				case "CheckParametersScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "CheckParametersScriptTask";
					result = CheckParametersScriptTask.Execute(context, CheckParametersScriptTaskExecute);
					break;
				case "IntermediateThrowMessageEvent1":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "OKButtonClick");
					result = IntermediateThrowMessageEvent1.Execute(context);
					break;
				case "PrintCheckParametersResultScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "PrintCheckParametersResultScriptTask";
					result = PrintCheckParametersResultScriptTask.Execute(context, PrintCheckParametersResultScriptTaskExecute);
					break;
				case "ExclusiveGateway2":
					context.QueueTasks.Dequeue();
					context.SenderName = "ExclusiveGateway2";
					result = ExclusiveGateway2.Execute(context);
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
				case "InvalidParameters":
					InvalidParameters = reader.GetSerializableObjectValue();
				break;
				case "IsParametersValid":
					IsParametersValid = reader.GetValue<System.Boolean>();
				break;
			}
		}

		#endregion

		#region Methods: Public

		public virtual bool PrepareFiltersScriptTaskExecute(ProcessExecutingContext context) {
			Page.ProcessSchemaEdit.PrepareLookupFilter += delegate (object sender, LookupEditEventArgs e) {
	e.Filters.Add(new Dictionary<string, object> {
		{"comparisonType", FilterComparisonType.Equal},
		{"leftExpressionColumnPath", "SysWorkspace.Id"},
		{"useDisplayValue", false},
		{"rightExpressionParameterValues", new object[] { UserConnection.Workspace.Id }}
	});
	e.Filters.Add(new Dictionary<string, object> {
		{"comparisonType", FilterComparisonType.Equal},
		{"leftExpressionColumnPath", "IsMaxVersion"},
		{"useDisplayValue", false},
		{"rightExpressionParameterValues", new object[] { 1 }}
	});
	e.Filters.Add(new Dictionary<string, object> {
		{"comparisonType", FilterComparisonType.Equal},
		{"leftExpressionColumnPath", "TagProperty"},
		{"useDisplayValue", false},
		{"rightExpressionParameterValues", new object[] { "Business Process" }}
	});
};
return true;
		}

		public virtual bool CheckParametersScriptTaskExecute(ProcessExecutingContext context) {
			List<TSConfiguration.ProcessValidationService.ProcessCheckParameter> checkParameters = 
	new List<TSConfiguration.ProcessValidationService.ProcessCheckParameter>() {
		new TSConfiguration.ProcessValidationService.ProcessCheckParameter() {
			Name = "ContactId",
			DataValueTypes = new List<string>(2) {
				"Guid",
				"Lookup"
			}
		},
		new TSConfiguration.ProcessValidationService.ProcessCheckParameter() {
			Name = "AccountId",
			DataValueTypes = new List<string>(2) {
				"Guid",
				"Lookup"
			}
		},
		new TSConfiguration.ProcessValidationService.ProcessCheckParameter() {
			Name = "PhoneNumber",
			DataValueTypes = new List<string>(4) {
				"Text",
				"ShortText",
				"MediumText",
				"LongText"
			}
		}
	};
TSConfiguration.ProcessValidationService service = 
	new TSConfiguration.ProcessValidationService();
TSConfiguration.ProcessValidationService.ProcessCheckResult checkResult = 
	service.CheckParameters((Guid)Page.ProcessSchemaEdit.Value, checkParameters);
IsParametersValid = checkResult.IsValid;
if (!IsParametersValid) {
	InvalidParameters = checkResult.InvalidParameters;
}
return true;
		}

		public virtual bool PrintCheckParametersResultScriptTaskExecute(ProcessExecutingContext context) {
			var messagePanelMessage = InvalidParametersMessage.Value;
string parametersNames = "";
var invalidParameters = InvalidParameters as 
	List<TSConfiguration.ProcessValidationService.ProcessCheckParameter>;
foreach (var parameter in invalidParameters) {
	if (parametersNames == "") {
		parametersNames = parameter.Name;
	} else {
		parametersNames += ", " + parameter.Name;
	}
}
messagePanelMessage = string.Format(messagePanelMessage, 
	Page.ProcessSchemaEdit.Text, parametersNames);
Page.BaseMessagePanel.AddMessage(Warning, messagePanelMessage, MessageType.Warning);
return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "Init":
							if (ActivatedEventElements.Contains("InitMessage")) {
							context.QueueTasks.Enqueue("InitMessage");
							ProcessQueue(context);
							return;
						}
						break;
					case "OKButtonClick":
							if (ActivatedEventElements.Contains("OKButtonClickMessage")) {
							context.QueueTasks.Enqueue("OKButtonClickMessage");
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
			if (InvalidParameters != null) {
				if (InvalidParameters.GetType().IsSerializable ||
					InvalidParameters.GetType().GetInterface("ISerializable") != null) {
					writer.WriteSerializableObjectValue("InvalidParameters", InvalidParameters, null);
				}
			}
			if (!HasMapping("IsParametersValid") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("IsParametersValid", IsParametersValid, false);
			}
		}

		public override object CloneShallow() {
			return base.CloneShallow();
		}

		#endregion

	}

	#endregion

	#region Class: CTIProcessActionEditPageEventsProcess

	/// <exclude/>
	public class CTIProcessActionEditPageEventsProcess : CTIProcessActionEditPageEventsProcess<Terrasoft.WebApp.CTIProcessActionEditPageSchemaUserControl>
	{

		public CTIProcessActionEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: CTIProcessActionEditPageSchemaUserControl

	/// <exclude/>
	public partial class CTIProcessActionEditPageSchemaUserControl : Terrasoft.WebApp.BaseLookupEditPageSchemaUserControl
	{

		#region Properties: Public

		public Terrasoft.UI.WebControls.Controls.LookupEdit ProcessSchemaEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.LookupEdit)PageContainer.FindPageControl("ProcessSchemaEdit", true);
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
		}

		protected override void UnsubscribeOnControlEvents() {
			base.UnsubscribeOnControlEvents();
		}

		protected override void InitializeEmbeddedProcess() {
			var instanceId = ((Terrasoft.UI.WebControls.Page)Page).InstanceId.ToString();
			string processUId = instanceId + PageContainer.UniqueID;
			var process = (CTIProcessActionEditPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new CTIProcessActionEditPageEventsProcess(UserConnection);
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
			SchemaName = "CTIProcessActionEditPage";
		}

		#endregion

	}

	#endregion

	#region Class: CTIProcessActionEditPageEventsProcessSchema

	/// <exclude/>
	public class CTIProcessActionEditPageEventsProcessSchema : Terrasoft.WebApp.BaseLookupEditPageEventsProcessSchema
	{

		#region Constructors: Public

		public CTIProcessActionEditPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public CTIProcessActionEditPageEventsProcessSchema(CTIProcessActionEditPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "CTIProcessActionEditPageEventsProcess";
			UId = new Guid("49450b90-1fba-47b2-b606-faa8d1c1a33a");
			CreatedInPackageId = new Guid("ccb8f7c7-6ff2-443f-9c1f-d56a09d4a46e");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsActiveVersion = false;
			IsCreatedInSvg = true;
			IsInterpretable = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("a9025da9-8220-4758-a93e-a034578ef23b");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
		}

		protected virtual ProcessSchemaParameter CreateInvalidParametersParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("61892b7e-888a-4568-a505-8d0e3a1be45a"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("49450b90-1fba-47b2-b606-faa8d1c1a33a"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("49450b90-1fba-47b2-b606-faa8d1c1a33a"),
				Name = @"InvalidParameters",
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			};
		}

		protected virtual ProcessSchemaParameter CreateIsParametersValidParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("edb22401-b841-42c1-8cff-32700fe33670"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("49450b90-1fba-47b2-b606-faa8d1c1a33a"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("49450b90-1fba-47b2-b606-faa8d1c1a33a"),
				Name = @"IsParametersValid",
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateInvalidParametersParameter());
			Parameters.Add(CreateIsParametersValidParameter());
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
			ProcessSchemaStartMessageEvent initmessage = CreateInitMessageStartMessageEvent();
			eventsubprocess1.FlowElements.Add(initmessage);
			ProcessSchemaScriptTask preparefiltersscripttask = CreatePrepareFiltersScriptTaskScriptTask();
			eventsubprocess1.FlowElements.Add(preparefiltersscripttask);
			ProcessSchemaIntermediateThrowMessageEvent parentinit = CreateParentInitIntermediateThrowMessageEvent();
			eventsubprocess1.FlowElements.Add(parentinit);
			ProcessSchemaStartMessageEvent okbuttonclickmessage = CreateOKButtonClickMessageStartMessageEvent();
			eventsubprocess2.FlowElements.Add(okbuttonclickmessage);
			ProcessSchemaScriptTask checkparametersscripttask = CreateCheckParametersScriptTaskScriptTask();
			eventsubprocess2.FlowElements.Add(checkparametersscripttask);
			ProcessSchemaIntermediateThrowMessageEvent intermediatethrowmessageevent1 = CreateIntermediateThrowMessageEvent1IntermediateThrowMessageEvent();
			eventsubprocess2.FlowElements.Add(intermediatethrowmessageevent1);
			ProcessSchemaScriptTask printcheckparametersresultscripttask = CreatePrintCheckParametersResultScriptTaskScriptTask();
			eventsubprocess2.FlowElements.Add(printcheckparametersresultscripttask);
			ProcessSchemaExclusiveGateway exclusivegateway2 = CreateExclusiveGateway2ExclusiveGateway();
			eventsubprocess2.FlowElements.Add(exclusivegateway2);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
			FlowElements.Add(CreateSequenceFlow4SequenceFlow());
			FlowElements.Add(CreateConditionalFlow1ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow5SequenceFlow());
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateInvalidParametersMessageLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateInvalidParametersMessageLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("7a323690-232d-437b-bb5d-a83a09ccebc7"),
				Name = "InvalidParametersMessage",
				CreatedInPackageId = new Guid("46ee4246-9818-4ab4-aafa-debf00e7c2f7"),
				CreatedInSchemaUId = new Guid("49450b90-1fba-47b2-b606-faa8d1c1a33a"),
				ModifiedInSchemaUId = new Guid("49450b90-1fba-47b2-b606-faa8d1c1a33a")
			};
			return localizableString;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("d30d26d6-eb4e-4903-802a-fade6ef6c46b"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("a9025da9-8220-4758-a93e-a034578ef23b"),
				CreatedInPackageId = new Guid("ccb8f7c7-6ff2-443f-9c1f-d56a09d4a46e"),
				CreatedInSchemaUId = new Guid("49450b90-1fba-47b2-b606-faa8d1c1a33a"),
				CurveCenterPosition = new Point(170, 94),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("49450b90-1fba-47b2-b606-faa8d1c1a33a"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("b02d9cdb-2ede-4a04-8f81-5f491242c4ca"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("8f6b8a51-43a3-4534-987d-7238f06b010f"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("46e2be0b-7b8b-4bcb-b6a1-8c8d14726db2"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("a9025da9-8220-4758-a93e-a034578ef23b"),
				CreatedInPackageId = new Guid("ccb8f7c7-6ff2-443f-9c1f-d56a09d4a46e"),
				CreatedInSchemaUId = new Guid("49450b90-1fba-47b2-b606-faa8d1c1a33a"),
				CurveCenterPosition = new Point(170, 94),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("49450b90-1fba-47b2-b606-faa8d1c1a33a"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("8f6b8a51-43a3-4534-987d-7238f06b010f"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("14f01944-622b-4c6d-9f95-362186eb763e"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlow3",
				UId = new Guid("ac88ae45-5ff8-4b21-ba59-7cbd47205e17"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("a9025da9-8220-4758-a93e-a034578ef23b"),
				CreatedInPackageId = new Guid("46ee4246-9818-4ab4-aafa-debf00e7c2f7"),
				CreatedInSchemaUId = new Guid("49450b90-1fba-47b2-b606-faa8d1c1a33a"),
				CurveCenterPosition = new Point(220, 340),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("49450b90-1fba-47b2-b606-faa8d1c1a33a"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("3840e383-b03c-4af7-856f-8f14ae3a10c1"),
				SourceSequenceFlowPointLocalPosition = new Point(0, -1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("d92c75e6-9d75-42b7-bdb0-11a990d4ae4a"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4",
				UId = new Guid("42063b06-1580-45bf-ad8d-cf70289ea0d4"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("a9025da9-8220-4758-a93e-a034578ef23b"),
				CreatedInPackageId = new Guid("46ee4246-9818-4ab4-aafa-debf00e7c2f7"),
				CreatedInSchemaUId = new Guid("49450b90-1fba-47b2-b606-faa8d1c1a33a"),
				CurveCenterPosition = new Point(158, 256),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("49450b90-1fba-47b2-b606-faa8d1c1a33a"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("5b5604f8-8807-4075-acf7-a01be1a006bb"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("18031a4d-ef12-4743-965b-1ba519688059"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow1ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow1",
				UId = new Guid("d32cade9-c16d-47e3-96f3-5879c2c00b6f"),
				ConditionExpression = @"!IsParametersValid",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("a9025da9-8220-4758-a93e-a034578ef23b"),
				CreatedInPackageId = new Guid("46ee4246-9818-4ab4-aafa-debf00e7c2f7"),
				CreatedInSchemaUId = new Guid("49450b90-1fba-47b2-b606-faa8d1c1a33a"),
				CurveCenterPosition = new Point(311, 260),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("49450b90-1fba-47b2-b606-faa8d1c1a33a"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("3840e383-b03c-4af7-856f-8f14ae3a10c1"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("12bce938-1ffe-4562-9132-bd6f15fd30ee"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow5SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow5",
				UId = new Guid("e7fa2c4c-0a4e-40ab-b58f-ac6959de922c"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("a9025da9-8220-4758-a93e-a034578ef23b"),
				CreatedInPackageId = new Guid("46ee4246-9818-4ab4-aafa-debf00e7c2f7"),
				CreatedInSchemaUId = new Guid("49450b90-1fba-47b2-b606-faa8d1c1a33a"),
				CurveCenterPosition = new Point(272, 248),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("49450b90-1fba-47b2-b606-faa8d1c1a33a"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("18031a4d-ef12-4743-965b-1ba519688059"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("3840e383-b03c-4af7-856f-8f14ae3a10c1"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("acaa8495-5c87-479f-9ee2-057863d365b4"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("a9025da9-8220-4758-a93e-a034578ef23b"),
				CreatedInPackageId = new Guid("ccb8f7c7-6ff2-443f-9c1f-d56a09d4a46e"),
				CreatedInSchemaUId = new Guid("49450b90-1fba-47b2-b606-faa8d1c1a33a"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("49450b90-1fba-47b2-b606-faa8d1c1a33a"),
				Name = @"LaneSet1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(5, 5),
				Size = new Size(644, 492)
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("9a01aff2-171b-4394-b465-e86c61b6e323"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("acaa8495-5c87-479f-9ee2-057863d365b4"),
				CreatedInOwnerSchemaUId = new Guid("ec45eeb7-6c61-4712-a626-07416c4b6bcc"),
				CreatedInPackageId = new Guid("ccb8f7c7-6ff2-443f-9c1f-d56a09d4a46e"),
				CreatedInSchemaUId = new Guid("49450b90-1fba-47b2-b606-faa8d1c1a33a"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("49450b90-1fba-47b2-b606-faa8d1c1a33a"),
				Name = @"Lane1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 0),
				Size = new Size(615, 492)
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess1EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess1 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("986bde30-711a-412d-9cad-1cd9a3198899"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("9a01aff2-171b-4394-b465-e86c61b6e323"),
				CreatedInOwnerSchemaUId = new Guid("a9025da9-8220-4758-a93e-a034578ef23b"),
				CreatedInPackageId = new Guid("ccb8f7c7-6ff2-443f-9c1f-d56a09d4a46e"),
				CreatedInSchemaUId = new Guid("49450b90-1fba-47b2-b606-faa8d1c1a33a"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("49450b90-1fba-47b2-b606-faa8d1c1a33a"),
				Name = @"EventSubProcess1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(28, 14),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(350, 154),
				TriggeredByEvent = true,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess1;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateInitMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("b02d9cdb-2ede-4a04-8f81-5f491242c4ca"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("986bde30-711a-412d-9cad-1cd9a3198899"),
				CreatedInOwnerSchemaUId = new Guid("a9025da9-8220-4758-a93e-a034578ef23b"),
				CreatedInPackageId = new Guid("ccb8f7c7-6ff2-443f-9c1f-d56a09d4a46e"),
				CreatedInSchemaUId = new Guid("49450b90-1fba-47b2-b606-faa8d1c1a33a"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("49450b90-1fba-47b2-b606-faa8d1c1a33a"),
				Name = @"InitMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(8, 51),
				SerializeToDB = false,
				Size = new Size(0, 0)
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreatePrepareFiltersScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("14f01944-622b-4c6d-9f95-362186eb763e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("986bde30-711a-412d-9cad-1cd9a3198899"),
				CreatedInOwnerSchemaUId = new Guid("a9025da9-8220-4758-a93e-a034578ef23b"),
				CreatedInPackageId = new Guid("ccb8f7c7-6ff2-443f-9c1f-d56a09d4a46e"),
				CreatedInSchemaUId = new Guid("49450b90-1fba-47b2-b606-faa8d1c1a33a"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("49450b90-1fba-47b2-b606-faa8d1c1a33a"),
				Name = @"PrepareFiltersScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(197, 37),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,205,83,193,74,195,64,16,61,87,240,31,134,156,90,12,1,207,85,65,219,8,5,133,64,107,61,136,135,49,153,166,107,55,187,113,102,87,27,74,254,221,77,99,161,126,64,161,135,189,204,188,247,230,189,97,54,195,146,146,140,109,78,34,243,124,77,21,166,133,114,161,66,53,50,61,89,187,241,245,163,210,142,24,174,110,161,32,77,37,58,130,161,253,248,164,220,129,144,41,136,99,232,129,29,53,253,38,227,238,185,20,160,17,236,46,47,6,148,244,124,73,238,139,98,104,232,7,166,42,119,202,26,228,230,70,28,43,83,198,208,203,221,237,9,131,93,148,219,42,140,87,98,205,162,169,41,138,161,151,152,252,43,39,233,151,71,221,198,61,69,211,202,165,219,154,67,142,160,61,177,218,87,38,67,183,14,228,104,222,200,171,229,141,212,152,83,50,43,162,3,199,11,77,149,212,26,155,37,106,223,205,89,161,22,58,180,89,149,235,35,205,12,25,43,10,54,246,96,9,232,46,76,239,252,237,29,118,240,34,157,69,99,104,31,47,57,30,9,109,27,52,219,209,248,60,22,50,147,103,220,46,131,133,208,57,213,54,174,207,44,243,2,203,112,231,53,177,107,78,21,57,122,240,162,76,0,195,223,143,138,142,118,208,134,199,228,60,27,112,236,105,252,11,58,207,144,147,122,3,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateParentInitIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("8f6b8a51-43a3-4534-987d-7238f06b010f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("986bde30-711a-412d-9cad-1cd9a3198899"),
				CreatedInOwnerSchemaUId = new Guid("a9025da9-8220-4758-a93e-a034578ef23b"),
				CreatedInPackageId = new Guid("ccb8f7c7-6ff2-443f-9c1f-d56a09d4a46e"),
				CreatedInSchemaUId = new Guid("49450b90-1fba-47b2-b606-faa8d1c1a33a"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("49450b90-1fba-47b2-b606-faa8d1c1a33a"),
				Name = @"ParentInit",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(78, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess2EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess2 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("10ff5e5f-14c1-4d71-a38b-00b8f2215d0c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("9a01aff2-171b-4394-b465-e86c61b6e323"),
				CreatedInOwnerSchemaUId = new Guid("a9025da9-8220-4758-a93e-a034578ef23b"),
				CreatedInPackageId = new Guid("46ee4246-9818-4ab4-aafa-debf00e7c2f7"),
				CreatedInSchemaUId = new Guid("49450b90-1fba-47b2-b606-faa8d1c1a33a"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("49450b90-1fba-47b2-b606-faa8d1c1a33a"),
				Name = @"EventSubProcess2",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(28, 175),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(529, 273),
				TriggeredByEvent = true,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess2;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateOKButtonClickMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("5b5604f8-8807-4075-acf7-a01be1a006bb"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("10ff5e5f-14c1-4d71-a38b-00b8f2215d0c"),
				CreatedInOwnerSchemaUId = new Guid("a9025da9-8220-4758-a93e-a034578ef23b"),
				CreatedInPackageId = new Guid("46ee4246-9818-4ab4-aafa-debf00e7c2f7"),
				CreatedInSchemaUId = new Guid("49450b90-1fba-47b2-b606-faa8d1c1a33a"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"OKButtonClick",
				ModifiedInSchemaUId = new Guid("49450b90-1fba-47b2-b606-faa8d1c1a33a"),
				Name = @"OKButtonClickMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 58),
				SerializeToDB = false,
				Size = new Size(0, 0)
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateCheckParametersScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("18031a4d-ef12-4743-965b-1ba519688059"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("10ff5e5f-14c1-4d71-a38b-00b8f2215d0c"),
				CreatedInOwnerSchemaUId = new Guid("a9025da9-8220-4758-a93e-a034578ef23b"),
				CreatedInPackageId = new Guid("46ee4246-9818-4ab4-aafa-debf00e7c2f7"),
				CreatedInSchemaUId = new Guid("49450b90-1fba-47b2-b606-faa8d1c1a33a"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("49450b90-1fba-47b2-b606-faa8d1c1a33a"),
				Name = @"CheckParametersScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(105, 44),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,213,83,193,78,195,48,12,61,119,210,254,33,244,212,74,83,15,136,219,96,18,26,8,85,42,83,69,39,238,33,245,186,104,107,50,37,206,0,161,253,59,105,182,118,203,184,20,1,7,46,73,252,18,63,63,219,113,198,53,94,207,139,169,20,11,94,25,69,145,75,145,228,74,50,208,250,153,174,121,233,144,2,212,150,51,104,47,166,75,96,171,156,42,90,3,130,154,16,230,217,154,220,144,225,32,16,240,74,178,95,96,143,98,242,97,233,28,223,207,168,90,166,96,102,109,43,50,180,100,72,25,166,101,56,114,248,29,69,106,185,12,204,223,55,208,164,209,229,160,81,113,81,77,162,203,150,34,8,31,12,111,253,130,48,147,114,101,54,161,179,118,205,186,27,253,145,230,91,198,164,17,255,75,115,190,148,2,102,166,126,1,213,91,245,213,81,245,28,222,176,83,93,44,165,66,15,121,132,146,155,218,131,50,41,42,7,156,36,103,151,221,120,56,232,155,26,209,135,189,251,204,125,61,163,248,27,97,188,10,62,129,54,107,220,143,211,225,236,162,31,164,36,126,153,117,20,53,253,140,115,90,117,52,133,245,173,233,125,201,49,113,229,29,157,207,102,163,45,213,71,219,9,178,81,78,98,38,233,30,181,47,249,130,68,23,95,158,239,59,147,138,109,99,120,99,239,177,156,223,91,62,219,4,5,104,148,32,168,12,140,63,1,34,35,68,147,125,4,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreateIntermediateThrowMessageEvent1IntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("d92c75e6-9d75-42b7-bdb0-11a990d4ae4a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("10ff5e5f-14c1-4d71-a38b-00b8f2215d0c"),
				CreatedInOwnerSchemaUId = new Guid("a9025da9-8220-4758-a93e-a034578ef23b"),
				CreatedInPackageId = new Guid("46ee4246-9818-4ab4-aafa-debf00e7c2f7"),
				CreatedInSchemaUId = new Guid("49450b90-1fba-47b2-b606-faa8d1c1a33a"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"OKButtonClick",
				ModifiedInSchemaUId = new Guid("49450b90-1fba-47b2-b606-faa8d1c1a33a"),
				Name = @"IntermediateThrowMessageEvent1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(239, 163),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreatePrintCheckParametersResultScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("12bce938-1ffe-4562-9132-bd6f15fd30ee"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("10ff5e5f-14c1-4d71-a38b-00b8f2215d0c"),
				CreatedInOwnerSchemaUId = new Guid("a9025da9-8220-4758-a93e-a034578ef23b"),
				CreatedInPackageId = new Guid("46ee4246-9818-4ab4-aafa-debf00e7c2f7"),
				CreatedInSchemaUId = new Guid("49450b90-1fba-47b2-b606-faa8d1c1a33a"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("49450b90-1fba-47b2-b606-faa8d1c1a33a"),
				Name = @"PrintCheckParametersResultScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(407, 44),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,82,219,106,195,48,12,125,110,33,255,32,242,148,210,224,31,216,5,182,178,193,96,29,129,132,238,89,36,74,106,150,56,69,118,194,198,216,191,79,110,179,48,26,131,193,178,116,116,142,36,107,68,134,142,172,197,134,50,52,212,238,47,54,220,193,139,25,177,213,85,134,140,29,57,98,59,133,212,1,219,129,110,162,181,117,172,77,3,167,25,240,38,183,149,204,56,150,232,40,196,250,154,34,68,11,104,33,90,175,94,181,117,183,69,190,235,77,173,155,129,209,233,222,168,140,251,82,84,15,62,227,236,201,137,71,93,210,95,96,119,164,242,99,166,186,23,217,186,103,194,242,8,137,215,159,75,147,74,150,197,108,224,91,116,117,13,201,162,5,223,195,37,188,90,182,55,123,148,247,136,230,234,7,168,181,20,198,111,133,43,133,24,182,161,188,104,45,39,60,254,203,116,213,115,207,29,186,36,128,73,253,212,50,255,33,211,48,242,242,72,29,62,85,218,169,130,62,93,122,253,51,27,145,60,227,31,209,210,254,31,161,122,168,170,233,157,188,35,27,209,77,67,75,145,194,100,20,95,39,82,19,210,179,50,185,129,13,56,150,189,248,5,229,2,30,177,81,2,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGateway2ExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("3840e383-b03c-4af7-856f-8f14ae3a10c1"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("10ff5e5f-14c1-4d71-a38b-00b8f2215d0c"),
				CreatedInOwnerSchemaUId = new Guid("a9025da9-8220-4758-a93e-a034578ef23b"),
				CreatedInPackageId = new Guid("46ee4246-9818-4ab4-aafa-debf00e7c2f7"),
				CreatedInSchemaUId = new Guid("49450b90-1fba-47b2-b606-faa8d1c1a33a"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("49450b90-1fba-47b2-b606-faa8d1c1a33a"),
				Name = @"ExclusiveGateway2",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(225, 44),
				SerializeToDB = false,
				Size = new Size(0, 0)
			};
			return gateway;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
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
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new CTIProcessActionEditPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("49450b90-1fba-47b2-b606-faa8d1c1a33a"));
		}

		#endregion

	}

	#endregion

}

