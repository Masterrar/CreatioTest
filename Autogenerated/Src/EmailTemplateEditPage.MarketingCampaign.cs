namespace Terrasoft.WebApp
{

	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Collections.Specialized;
	using System.ComponentModel;
	using System.Data;
	using System.Drawing;
	using System.Globalization;
	using System.Linq;
	using System.Text;
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
	using Terrasoft.UI.WebControls;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities;
	using TSConfiguration = Terrasoft.Configuration;
	using TSWebControls = Terrasoft.UI.WebControls;

	#region Class: EmailTemplateEditPageSchema

	/// <exclude/>
	public class EmailTemplateEditPageSchema : Terrasoft.WebApp.EmailTemplateEditPage_Base_TerrasoftSchema
	{

		#region Constructors: Public

		public EmailTemplateEditPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public EmailTemplateEditPageSchema(EmailTemplateEditPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateProcessButton() {
			ProcessButton.AjaxEvents.Click.IsProcessEventHandler = true;
			ProcessButton.Image = new ControlImage {};
			ProcessButton.ModifiedInSchemaUId = new Guid("16d64721-88e3-450c-af3a-41370e23dd83");
		}

		private void UpdateActionButton() {
			ActionButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("d291b989-e737-4e5d-883f-ff3a6d5aea01"),
				ImageHash = @"388b646e5dc8d8c8203aeeb3f25b057e"
			};
			ActionButton.ModifiedInSchemaUId = new Guid("16d64721-88e3-450c-af3a-41370e23dd83");
		}

		private void UpdatePrintReportButton() {
			PrintReportButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("d291b989-e737-4e5d-883f-ff3a6d5aea01"),
				ImageHash = @"6e713359f7daa6706f06f1a8f5f065f7"
			};
			PrintReportButton.ModifiedInSchemaUId = new Guid("16d64721-88e3-450c-af3a-41370e23dd83");
		}

		private void UpdateDesignerModeButton() {
			DesignerModeButton.AjaxEvents.Click.IsProcessEventHandler = true;
			DesignerModeButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("d291b989-e737-4e5d-883f-ff3a6d5aea01"),
				ImageHash = @"682ad9264105b2170afb821fabf80415"
			};
			DesignerModeButton.ModifiedInSchemaUId = new Guid("16d64721-88e3-450c-af3a-41370e23dd83");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("16d64721-88e3-450c-af3a-41370e23dd83");
		}

		private void UpdateButtonsControlLayout() {
			ButtonsControlLayout.Image = new ControlImage {};
			ButtonsControlLayout.ModifiedInSchemaUId = new Guid("16d64721-88e3-450c-af3a-41370e23dd83");
		}

		private void UpdateNameEdit() {
			NameEdit.Image = new ControlImage {};
			NameEdit.ModifiedInSchemaUId = new Guid("16d64721-88e3-450c-af3a-41370e23dd83");
		}

		private void UpdateControlLayout1() {
			ControlLayout1.Image = new ControlImage {};
			ControlLayout1.ModifiedInSchemaUId = new Guid("16d64721-88e3-450c-af3a-41370e23dd83");
		}

		private void UpdateObjectEdit() {
			ObjectEdit.AjaxEvents.Change.IsProcessEventHandler = true;
			ObjectEdit.Image = new ControlImage {};
			ObjectEdit.ModifiedInSchemaUId = new Guid("16d64721-88e3-450c-af3a-41370e23dd83");
		}

		private void UpdateControlLayout2() {
			ControlLayout2.Image = new ControlImage {};
			ControlLayout2.ModifiedInSchemaUId = new Guid("16d64721-88e3-450c-af3a-41370e23dd83");
		}

		private void UpdateNameControlLayout() {
			NameControlLayout.Image = new ControlImage {};
			NameControlLayout.ModifiedInSchemaUId = new Guid("16d64721-88e3-450c-af3a-41370e23dd83");
		}

		private void UpdateAddRecipientToolButton() {
			AddRecipientToolButton.AjaxEvents.Click.IsProcessEventHandler = true;
			AddRecipientToolButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("709151d1-328a-4279-898a-b90fe94f0567"),
				ImageHash = @"2967f46dffb3953a687d347e4791ebf9"
			};
			AddRecipientToolButton.ModifiedInSchemaUId = new Guid("16d64721-88e3-450c-af3a-41370e23dd83");
		}

		private void UpdateRecipientEdit() {
			RecipientEdit.Image = new ControlImage {};
			RecipientEdit.ModifiedInSchemaUId = new Guid("16d64721-88e3-450c-af3a-41370e23dd83");
		}

		private void UpdateCopyRecipientToolButton() {
			CopyRecipientToolButton.AjaxEvents.Click.IsProcessEventHandler = true;
			CopyRecipientToolButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("709151d1-328a-4279-898a-b90fe94f0567"),
				ImageHash = @"2967f46dffb3953a687d347e4791ebf9"
			};
			CopyRecipientToolButton.ModifiedInSchemaUId = new Guid("16d64721-88e3-450c-af3a-41370e23dd83");
		}

		private void UpdateCopyRecipientEdit() {
			CopyRecipientEdit.Image = new ControlImage {};
			CopyRecipientEdit.ModifiedInSchemaUId = new Guid("16d64721-88e3-450c-af3a-41370e23dd83");
		}

		private void UpdateBlindCopyRecipientToolButton() {
			BlindCopyRecipientToolButton.AjaxEvents.Click.IsProcessEventHandler = true;
			BlindCopyRecipientToolButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("709151d1-328a-4279-898a-b90fe94f0567"),
				ImageHash = @"2967f46dffb3953a687d347e4791ebf9"
			};
			BlindCopyRecipientToolButton.ModifiedInSchemaUId = new Guid("16d64721-88e3-450c-af3a-41370e23dd83");
		}

		private void UpdateBlindCopyRecipientEdit() {
			BlindCopyRecipientEdit.Image = new ControlImage {};
			BlindCopyRecipientEdit.ModifiedInSchemaUId = new Guid("16d64721-88e3-450c-af3a-41370e23dd83");
		}

		private void UpdateAddMacrosToolButton() {
			AddMacrosToolButton.Image = new ControlImage {};
			AddMacrosToolButton.ModifiedInSchemaUId = new Guid("16d64721-88e3-450c-af3a-41370e23dd83");
		}

		private void UpdateSubjectEdit() {
			SubjectEdit.Image = new ControlImage {};
			SubjectEdit.ModifiedInSchemaUId = new Guid("16d64721-88e3-450c-af3a-41370e23dd83");
		}

		private void UpdatePriorityButton() {
			PriorityButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("709151d1-328a-4279-898a-b90fe94f0567"),
				ImageHash = @"ee7456bf8f8cb3fc24aa1f3d6dd7615f"
			};
			PriorityButton.ModifiedInSchemaUId = new Guid("16d64721-88e3-450c-af3a-41370e23dd83");
		}

		private void UpdateSubjectControlLayout() {
			SubjectControlLayout.Image = new ControlImage {};
			SubjectControlLayout.ModifiedInSchemaUId = new Guid("16d64721-88e3-450c-af3a-41370e23dd83");
		}

		private void UpdateEmailControlLayout() {
			EmailControlLayout.Image = new ControlImage {};
			EmailControlLayout.ModifiedInSchemaUId = new Guid("16d64721-88e3-450c-af3a-41370e23dd83");
		}

		private void UpdatePutTemplateToBodyButton() {
			PutTemplateToBodyButton.AjaxEvents.Click.IsProcessEventHandler = true;
			PutTemplateToBodyButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("709151d1-328a-4279-898a-b90fe94f0567"),
				ImageHash = @"012f06e2ee1dc8d32d3959105560eacd"
			};
			PutTemplateToBodyButton.ModifiedInSchemaUId = new Guid("16d64721-88e3-450c-af3a-41370e23dd83");
		}

		private void UpdateRecipientMenuItem() {
			RecipientMenuItem.AjaxEvents.Click.IsProcessEventHandler = true;
			RecipientMenuItem.Image = new ControlImage {};
			RecipientMenuItem.ModifiedInSchemaUId = new Guid("16d64721-88e3-450c-af3a-41370e23dd83");
		}

		private void UpdateCurrentUserMenuItem() {
			CurrentUserMenuItem.AjaxEvents.Click.IsProcessEventHandler = true;
			CurrentUserMenuItem.Image = new ControlImage {};
			CurrentUserMenuItem.ModifiedInSchemaUId = new Guid("16d64721-88e3-450c-af3a-41370e23dd83");
		}

		private void UpdateObjectMenuItem() {
			ObjectMenuItem.AjaxEvents.Click.IsProcessEventHandler = true;
			ObjectMenuItem.Image = new ControlImage {};
			ObjectMenuItem.ModifiedInSchemaUId = new Guid("16d64721-88e3-450c-af3a-41370e23dd83");
		}

		private void UpdateSetFieldsButton() {
			SetFieldsButton.Image = new ControlImage {};
			SetFieldsButton.ModifiedInSchemaUId = new Guid("16d64721-88e3-450c-af3a-41370e23dd83");
		}

		private void UpdateMacrosTreeGrid() {
			MacrosTreeGrid.AjaxEvents.DblClick.IsProcessEventHandler = true;
		}

		private void UpdateMacrosControlLayout() {
			MacrosControlLayout.Image = new ControlImage {};
			MacrosControlLayout.ModifiedInSchemaUId = new Guid("16d64721-88e3-450c-af3a-41370e23dd83");
		}

		private void UpdateBodyControlLayout() {
			BodyControlLayout.Image = new ControlImage {};
			BodyControlLayout.ModifiedInSchemaUId = new Guid("16d64721-88e3-450c-af3a-41370e23dd83");
		}

		private void UpdateSendIndividualEmailEdit() {
			SendIndividualEmailEdit.Image = new ControlImage {};
			SendIndividualEmailEdit.ModifiedInSchemaUId = new Guid("16d64721-88e3-450c-af3a-41370e23dd83");
		}

		private void UpdateObjectFieldInActivityEdit() {
			ObjectFieldInActivityEdit.Image = new ControlImage {};
			ObjectFieldInActivityEdit.ModifiedInSchemaUId = new Guid("16d64721-88e3-450c-af3a-41370e23dd83");
		}

		private void UpdateCustomControlsLeft() {
			CustomControlsLeft.Image = new ControlImage {};
			CustomControlsLeft.ModifiedInSchemaUId = new Guid("16d64721-88e3-450c-af3a-41370e23dd83");
		}

		private void UpdateCustomControlsRight() {
			CustomControlsRight.Image = new ControlImage {};
			CustomControlsRight.ModifiedInSchemaUId = new Guid("16d64721-88e3-450c-af3a-41370e23dd83");
		}

		private void UpdateCustomControls() {
			CustomControls.Image = new ControlImage {};
			CustomControls.ModifiedInSchemaUId = new Guid("16d64721-88e3-450c-af3a-41370e23dd83");
		}

		private void UpdateDataControlLayout() {
			DataControlLayout.Image = new ControlImage {};
			DataControlLayout.ModifiedInSchemaUId = new Guid("16d64721-88e3-450c-af3a-41370e23dd83");
		}

		private void UpdateDataTab() {
			DataTab.Image = new ControlImage {};
			DataTab.ModifiedInSchemaUId = new Guid("16d64721-88e3-450c-af3a-41370e23dd83");
		}

		private void UpdateDataTabPanel() {
			DataTabPanel.AjaxEvents.TabChange.IsProcessEventHandler = true;
			DataTabPanel.AjaxEvents.TabChange.ShowLoadMask = true;
		}

		private void UpdateOKButton() {
			OKButton.AjaxEvents.Click.IsProcessEventHandler = true;
			OKButton.Image = new ControlImage {};
			OKButton.ModifiedInSchemaUId = new Guid("16d64721-88e3-450c-af3a-41370e23dd83");
		}

		private void UpdateCancelButton() {
			CancelButton.Image = new ControlImage {};
			CancelButton.ModifiedInSchemaUId = new Guid("16d64721-88e3-450c-af3a-41370e23dd83");
		}

		private void UpdateButtomButtonLayout() {
			ButtomButtonLayout.Image = new ControlImage {};
			ButtomButtonLayout.ModifiedInSchemaUId = new Guid("16d64721-88e3-450c-af3a-41370e23dd83");
		}

		private void UpdateRightControlLayout() {
			RightControlLayout.Image = new ControlImage {};
			RightControlLayout.ModifiedInSchemaUId = new Guid("16d64721-88e3-450c-af3a-41370e23dd83");
		}

		private void UpdateMainControlLayout() {
			MainControlLayout.Image = new ControlImage {};
			MainControlLayout.ModifiedInSchemaUId = new Guid("16d64721-88e3-450c-af3a-41370e23dd83");
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("16d64721-88e3-450c-af3a-41370e23dd83");
			Name = "EmailTemplateEditPage";
			ParentSchemaUId = new Guid("709151d1-328a-4279-898a-b90fe94f0567");
			CreatedInPackageId = new Guid("b477c174-1d53-4a21-b489-a41e481a96a0");
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateEmailTemplateEditPageEventsProcessSchema();
		}

		protected override void InitializeControls() {
			base.InitializeControls();
			UpdateMainControlLayout();
			UpdateRightControlLayout();
			UpdateButtomButtonLayout();
			UpdateCancelButton();
			UpdateOKButton();
			UpdateDataTabPanel();
			UpdateDataTab();
			UpdateDataControlLayout();
			UpdateCustomControls();
			UpdateCustomControlsRight();
			UpdateCustomControlsLeft();
			UpdateObjectFieldInActivityEdit();
			UpdateSendIndividualEmailEdit();
			UpdateBodyControlLayout();
			UpdateMacrosControlLayout();
			UpdateMacrosTreeGrid();
			UpdateSetFieldsButton();
			UpdateObjectMenuItem();
			UpdateCurrentUserMenuItem();
			UpdateRecipientMenuItem();
			UpdatePutTemplateToBodyButton();
			UpdateEmailControlLayout();
			UpdateSubjectControlLayout();
			UpdatePriorityButton();
			UpdateSubjectEdit();
			UpdateAddMacrosToolButton();
			UpdateBlindCopyRecipientEdit();
			UpdateBlindCopyRecipientToolButton();
			UpdateCopyRecipientEdit();
			UpdateCopyRecipientToolButton();
			UpdateRecipientEdit();
			UpdateAddRecipientToolButton();
			UpdateNameControlLayout();
			UpdateControlLayout2();
			UpdateObjectEdit();
			UpdateControlLayout1();
			UpdateNameEdit();
			UpdateButtonsControlLayout();
			UpdateContextHelpButton();
			UpdateDesignerModeButton();
			UpdatePrintReportButton();
			UpdateActionButton();
			UpdateProcessButton();
			TopLevelControl.MoveItem(0, BaseMessagePanel);
			TopLevelControl.MoveItem(1, MainControlLayout);
			MainControlLayout.MoveItem(0, RightControlLayout);
			RightControlLayout.MoveItem(0, DataTabPanel);
			DataTabPanel.MoveItem(0, DataTab);
			DataTab.MoveItem(0, ButtonsControlLayout);
			ButtonsControlLayout.MoveItem(0, ProcessButton);
			ButtonsControlLayout.MoveItem(1, PrintReportSpacer);
			ButtonsControlLayout.MoveItem(2, ActionButton);
			ButtonsControlLayout.MoveItem(3, PrintReportButton);
			ButtonsControlLayout.MoveItem(4, DesignerModeButton);
			ButtonsControlLayout.MoveItem(5, ContextHelpButton);
			DataTab.MoveItem(1, DataControlLayout);
			DataControlLayout.MoveItem(0, NameControlLayout);
			NameControlLayout.MoveItem(0, ControlLayout1);
			ControlLayout1.MoveItem(0, NameEdit);
			NameControlLayout.MoveItem(1, ControlLayout2);
			ControlLayout2.MoveItem(0, ObjectEdit);
			DataControlLayout.MoveItem(1, EmailControlLayout);
			EmailControlLayout.MoveItem(0, RecipientEdit);
			RecipientEdit.MoveItem(0, AddRecipientToolButton);
			EmailControlLayout.MoveItem(1, CopyRecipientEdit);
			CopyRecipientEdit.MoveItem(0, CopyRecipientToolButton);
			EmailControlLayout.MoveItem(2, BlindCopyRecipientEdit);
			BlindCopyRecipientEdit.MoveItem(0, BlindCopyRecipientToolButton);
			EmailControlLayout.MoveItem(3, SubjectControlLayout);
			SubjectControlLayout.MoveItem(0, SubjectEdit);
			SubjectEdit.MoveItem(0, AddMacrosToolButton);
			SubjectControlLayout.MoveItem(1, PriorityButton);
			DataControlLayout.MoveItem(2, BodyControlLayout);
			BodyControlLayout.MoveItem(0, BodyEdit);
			BodyControlLayout.MoveItem(1, PutTemplateToBodyButton);
			BodyControlLayout.MoveItem(2, MacrosControlLayout);
			MacrosControlLayout.MoveItem(0, SetFieldsButton);
			SetFieldsButton.MoveItem(0, RecipientMenuItem);
			SetFieldsButton.MoveItem(1, CurrentUserMenuItem);
			SetFieldsButton.MoveItem(2, ObjectMenuItem);
			MacrosControlLayout.MoveItem(1, MacrosTreeGrid);
			DataControlLayout.MoveItem(3, SendIndividualEmailEdit);
			DataControlLayout.MoveItem(4, SaveAsActivityEdit);
			DataControlLayout.MoveItem(5, ObjectFieldInActivityEdit);
			DataControlLayout.MoveItem(6, ShowBeforeSendingEdit);
			DataControlLayout.MoveItem(7, CustomControls);
			CustomControls.MoveItem(0, CustomControlsLeft);
			CustomControls.MoveItem(1, CustomControlsRight);
			RightControlLayout.MoveItem(1, ButtomButtonLayout);
			ButtomButtonLayout.MoveItem(0, ButtomSpacer);
			ButtomButtonLayout.MoveItem(1, OKButton);
			ButtomButtonLayout.MoveItem(2, CancelButton);
			TopLevelControl.MoveItem(2, DataSource);
			SetControlsDefInheritance(UId);
			InitializeLocalizableValues();
		}

		protected virtual EmbeddedProcessSchema CreateEmailTemplateEditPageEventsProcessSchema() {
			var schema = new EmailTemplateEditPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected override void UpdateDataSource() {
			base.UpdateDataSource();
			DataSourceStructureColumn column = null;
			column = DataSource.DefStructure.Columns.FindByMetaPath("ae0e45ca-c495-4fe7-a39d-3ab7278e1617");
			if (column != null) {
				column.IsAlwaysSelect = true;
				column.Required = true;
				column.ModifiedInSchemaUId = new Guid("16d64721-88e3-450c-af3a-41370e23dd83");
			}
			column = DataSource.DefStructure.Columns.FindByMetaPath("ca53e2c8-0767-4f2c-8a18-2ee5821f134e");
			if (column != null) {
				column.OrderDirection = OrderDirection.Ascending;
				column.OrderPosition = 1;
				column.Required = true;
				column.ModifiedInSchemaUId = new Guid("16d64721-88e3-450c-af3a-41370e23dd83");
			}
			column = DataSource.DefStructure.Columns.FindByMetaPath("26bd9f25-0d50-4c47-829f-8b286576317c");
			if (column != null) {
				column.Required = true;
				column.ModifiedInSchemaUId = new Guid("16d64721-88e3-450c-af3a-41370e23dd83");
			}
			column = DataSource.DefStructure.Columns.FindByMetaPath("2e7c35e3-0774-4a4a-bea5-6ce4c8de1465");
			if (column != null) {
				column.Required = true;
				column.ModifiedInSchemaUId = new Guid("16d64721-88e3-450c-af3a-41370e23dd83");
			}
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override PageSchemaUserControl CreateUserControl() {
			return new EmailTemplateEditPageSchemaUserControl();
		}

		public override object Clone() {
			return new EmailTemplateEditPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("16d64721-88e3-450c-af3a-41370e23dd83"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new EmailTemplateEditPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: EmailTemplateEditPageEventsProcess

	/// <exclude/>
	public class EmailTemplateEditPageEventsProcess<TPage> : Terrasoft.WebApp.EmailTemplateEditPage_Base_TerrasoftEventsProcess<TPage> where TPage : Terrasoft.WebApp.EmailTemplateEditPageSchemaUserControl
	{

		public EmailTemplateEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "EmailTemplateEditPageEventsProcess";
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("16d64721-88e3-450c-af3a-41370e23dd83");
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

		public virtual Guid CopyEntityId {
			get;
			set;
		}

		private ProcessFlowElement _eventSubProcess9;
		public ProcessFlowElement EventSubProcess9 {
			get {
				return _eventSubProcess9 ?? (_eventSubProcess9 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess9",
					SchemaElementUId = new Guid("198ea53b-a22d-4911-80df-f1d211856f8d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _initScriptTaskChild;
		public ProcessScriptTask InitScriptTaskChild {
			get {
				return _initScriptTaskChild ?? (_initScriptTaskChild = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "InitScriptTaskChild",
					SchemaElementUId = new Guid("5e7a3179-817b-4b1f-a7ea-1c57ef847d6d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = InitScriptTaskChildExecute,
				});
			}
		}

		private ProcessFlowElement _initEmailTemplateEditPageMarketing;
		public ProcessFlowElement InitEmailTemplateEditPageMarketing {
			get {
				return _initEmailTemplateEditPageMarketing ?? (_initEmailTemplateEditPageMarketing = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "InitEmailTemplateEditPageMarketing",
					SchemaElementUId = new Guid("1c9bd460-28dc-4d41-8b74-e8539b6451f0"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _baseModuleInit;
		public ProcessScriptTask BaseModuleInit {
			get {
				return _baseModuleInit ?? (_baseModuleInit = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "BaseModuleInit",
					SchemaElementUId = new Guid("d35f5d15-bbff-4efe-9310-977c2af530ec"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = BaseModuleInitExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcess10;
		public ProcessFlowElement EventSubProcess10 {
			get {
				return _eventSubProcess10 ?? (_eventSubProcess10 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess10",
					SchemaElementUId = new Guid("34d68da9-18a8-460b-a4cf-7306ba51754a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _pageLoadCompleteEmailTemplate;
		public ProcessFlowElement PageLoadCompleteEmailTemplate {
			get {
				return _pageLoadCompleteEmailTemplate ?? (_pageLoadCompleteEmailTemplate = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "PageLoadCompleteEmailTemplate",
					SchemaElementUId = new Guid("d233ee72-156e-4e47-96ca-27d0489df79e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessThrowMessageEvent _pageLoadCompleteEmailTemplateParent;
		public ProcessThrowMessageEvent PageLoadCompleteEmailTemplateParent {
			get {
				return _pageLoadCompleteEmailTemplateParent ?? (_pageLoadCompleteEmailTemplateParent = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "PageLoadCompleteEmailTemplateParent",
					SchemaElementUId = new Guid("010bc99d-dfab-4b42-aa47-2305918ac95e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Message = "PageLoadComplete",
						ThrowToBase = true,
				});
			}
		}

		private ProcessScriptTask _pageLoadCompleteScriptTaskEmailTemplate;
		public ProcessScriptTask PageLoadCompleteScriptTaskEmailTemplate {
			get {
				return _pageLoadCompleteScriptTaskEmailTemplate ?? (_pageLoadCompleteScriptTaskEmailTemplate = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "PageLoadCompleteScriptTaskEmailTemplate",
					SchemaElementUId = new Guid("5ccbcaba-70d2-4a8d-922a-03e9b6cafc4c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = PageLoadCompleteScriptTaskEmailTemplateExecute,
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
					SchemaElementUId = new Guid("c2a3ce58-ae9d-451a-a071-7d9bab71a6af"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask3Execute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcess11;
		public ProcessFlowElement EventSubProcess11 {
			get {
				return _eventSubProcess11 ?? (_eventSubProcess11 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess11",
					SchemaElementUId = new Guid("2d976e3a-0e3f-4304-8309-7318054c1a80"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _putTemplateToBodyButtonClickMarketingStartMessage;
		public ProcessFlowElement PutTemplateToBodyButtonClickMarketingStartMessage {
			get {
				return _putTemplateToBodyButtonClickMarketingStartMessage ?? (_putTemplateToBodyButtonClickMarketingStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "PutTemplateToBodyButtonClickMarketingStartMessage",
					SchemaElementUId = new Guid("63ac82de-4785-4425-8628-f28402849601"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _putTemplateToBodyButtonClickMarketingScriptTask;
		public ProcessScriptTask PutTemplateToBodyButtonClickMarketingScriptTask {
			get {
				return _putTemplateToBodyButtonClickMarketingScriptTask ?? (_putTemplateToBodyButtonClickMarketingScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "PutTemplateToBodyButtonClickMarketingScriptTask",
					SchemaElementUId = new Guid("2012328e-bdae-44da-9eb8-6c299b4a0085"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = PutTemplateToBodyButtonClickMarketingScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _macrosTreeGridDblClickMarketingStartMessage;
		public ProcessFlowElement MacrosTreeGridDblClickMarketingStartMessage {
			get {
				return _macrosTreeGridDblClickMarketingStartMessage ?? (_macrosTreeGridDblClickMarketingStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "MacrosTreeGridDblClickMarketingStartMessage",
					SchemaElementUId = new Guid("b3cc7049-21b0-4c8b-926e-f9144f48399d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess9.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess9 };
			FlowElements[InitScriptTaskChild.SchemaElementUId] = new Collection<ProcessFlowElement> { InitScriptTaskChild };
			FlowElements[InitEmailTemplateEditPageMarketing.SchemaElementUId] = new Collection<ProcessFlowElement> { InitEmailTemplateEditPageMarketing };
			FlowElements[BaseModuleInit.SchemaElementUId] = new Collection<ProcessFlowElement> { BaseModuleInit };
			FlowElements[EventSubProcess10.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess10 };
			FlowElements[PageLoadCompleteEmailTemplate.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadCompleteEmailTemplate };
			FlowElements[PageLoadCompleteEmailTemplateParent.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadCompleteEmailTemplateParent };
			FlowElements[PageLoadCompleteScriptTaskEmailTemplate.SchemaElementUId] = new Collection<ProcessFlowElement> { PageLoadCompleteScriptTaskEmailTemplate };
			FlowElements[ScriptTask3.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask3 };
			FlowElements[EventSubProcess11.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess11 };
			FlowElements[PutTemplateToBodyButtonClickMarketingStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { PutTemplateToBodyButtonClickMarketingStartMessage };
			FlowElements[PutTemplateToBodyButtonClickMarketingScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { PutTemplateToBodyButtonClickMarketingScriptTask };
			FlowElements[MacrosTreeGridDblClickMarketingStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { MacrosTreeGridDblClickMarketingStartMessage };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess9":
						break;
					case "InitScriptTaskChild":
						break;
					case "InitEmailTemplateEditPageMarketing":
						e.Context.QueueTasks.Enqueue("BaseModuleInit");
						break;
					case "BaseModuleInit":
						e.Context.QueueTasks.Enqueue("InitScriptTaskChild");
						break;
					case "EventSubProcess10":
						break;
					case "PageLoadCompleteEmailTemplate":
						e.Context.QueueTasks.Enqueue("ScriptTask3");
						break;
					case "PageLoadCompleteEmailTemplateParent":
						e.Context.QueueTasks.Enqueue("PageLoadCompleteScriptTaskEmailTemplate");
						break;
					case "PageLoadCompleteScriptTaskEmailTemplate":
						break;
					case "ScriptTask3":
						e.Context.QueueTasks.Enqueue("PageLoadCompleteEmailTemplateParent");
						break;
					case "EventSubProcess11":
						break;
					case "PutTemplateToBodyButtonClickMarketingStartMessage":
						e.Context.QueueTasks.Enqueue("PutTemplateToBodyButtonClickMarketingScriptTask");
						break;
					case "PutTemplateToBodyButtonClickMarketingScriptTask":
						break;
					case "MacrosTreeGridDblClickMarketingStartMessage":
						e.Context.QueueTasks.Enqueue("PutTemplateToBodyButtonClickMarketingScriptTask");
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("InitEmailTemplateEditPageMarketing");
			ActivatedEventElements.Add("PageLoadCompleteEmailTemplate");
			ActivatedEventElements.Add("PutTemplateToBodyButtonClickMarketingStartMessage");
			ActivatedEventElements.Add("MacrosTreeGridDblClickMarketingStartMessage");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "EventSubProcess9":
					context.QueueTasks.Dequeue();
					break;
				case "InitScriptTaskChild":
					context.QueueTasks.Dequeue();
					context.SenderName = "InitScriptTaskChild";
					result = InitScriptTaskChild.Execute(context, InitScriptTaskChildExecute);
					break;
				case "InitEmailTemplateEditPageMarketing":
					context.QueueTasks.Dequeue();
					context.SenderName = "InitEmailTemplateEditPageMarketing";
					result = InitEmailTemplateEditPageMarketing.Execute(context);
					break;
				case "BaseModuleInit":
					context.QueueTasks.Dequeue();
					context.SenderName = "BaseModuleInit";
					result = BaseModuleInit.Execute(context, BaseModuleInitExecute);
					break;
				case "EventSubProcess10":
					context.QueueTasks.Dequeue();
					break;
				case "PageLoadCompleteEmailTemplate":
					context.QueueTasks.Dequeue();
					context.SenderName = "PageLoadCompleteEmailTemplate";
					result = PageLoadCompleteEmailTemplate.Execute(context);
					break;
				case "PageLoadCompleteEmailTemplateParent":
					context.QueueTasks.Dequeue();
					base.ThrowEvent(context, "PageLoadComplete");
					result = PageLoadCompleteEmailTemplateParent.Execute(context);
					break;
				case "PageLoadCompleteScriptTaskEmailTemplate":
					context.QueueTasks.Dequeue();
					context.SenderName = "PageLoadCompleteScriptTaskEmailTemplate";
					result = PageLoadCompleteScriptTaskEmailTemplate.Execute(context, PageLoadCompleteScriptTaskEmailTemplateExecute);
					break;
				case "ScriptTask3":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask3";
					result = ScriptTask3.Execute(context, ScriptTask3Execute);
					break;
				case "EventSubProcess11":
					context.QueueTasks.Dequeue();
					break;
				case "PutTemplateToBodyButtonClickMarketingStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "PutTemplateToBodyButtonClickMarketingStartMessage";
					result = PutTemplateToBodyButtonClickMarketingStartMessage.Execute(context);
					break;
				case "PutTemplateToBodyButtonClickMarketingScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "PutTemplateToBodyButtonClickMarketingScriptTask";
					result = PutTemplateToBodyButtonClickMarketingScriptTask.Execute(context, PutTemplateToBodyButtonClickMarketingScriptTaskExecute);
					break;
				case "MacrosTreeGridDblClickMarketingStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "MacrosTreeGridDblClickMarketingStartMessage";
					result = MacrosTreeGridDblClickMarketingStartMessage.Execute(context);
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
				case "CopyEntityId":
					CopyEntityId = reader.GetValue<System.Guid>();
				break;
			}
		}

		#endregion

		#region Methods: Public

		public virtual bool InitScriptTaskChildExecute(ProcessExecutingContext context) {
			Page.DataSource.BeforeLoad += delegate(object sender, DataSourceEventArgs e) {
	var dataSource = ((DataSource)sender);
	dataSource.PageRowsCount = 0;
	var bodyColumn = dataSource.CurrentStructure.Columns.FindByName("Body");
	dataSource.CurrentStructure.Columns.Remove(bodyColumn);
};
if (ColumnStructureExplorerCreated) {
	CreateColumnStructureExplorer();
}
Page.ObjectEdit.PrepareLookupFilter += PrepareObjectEditFilter;
if (Ext.IsAjaxRequest) {
	FillMenuPriority();
}
VirtualDataSourceID = "MacrosVirtualDataSource";
var virtualDataSource = new VirtualDataSource() {
	ID = VirtualDataSourceID
};
Page.PageContainer.Controls.Add(virtualDataSource);
Page.MacrosTreeGrid.DataSourceId = virtualDataSource.ID;
DataSourceStructure defStructure = virtualDataSource.DefStructure;
defStructure.PrimaryColumnName = "Id";
defStructure.PrimaryDisplayColumnName = "Name";
var dataValueTypeManager = (DataValueTypeManager)
	Page.UserConnection.AppManagerProvider.GetManager("DataValueTypeManager");
var column = new DataSourceStructureColumn {
	Name = "Id",
	ValueColumnName = "Id",
	DataValueType = dataValueTypeManager.GetInstanceByName("Guid"),
	Caption = "Id",
	IsVisible = false,
	IsSortable = false
};
defStructure.AddColumn(column);
column = new DataSourceStructureColumn {
	Name = "Name",
	ValueColumnName = "Name",
	DataValueType = dataValueTypeManager.GetInstanceByName("Text"),
	Caption = "Name",
	IsVisible = true,
	IsSortable = false
};
defStructure.AddColumn(column);
column = new DataSourceStructureColumn {
	Name = "ParentId",
	ValueColumnName = "ParentId",
	DataValueType = dataValueTypeManager.GetInstanceByName("Guid"),
	Caption = "ParentId",
	IsVisible = false,
	IsSortable = false
};
defStructure.AddColumn(column);
column = new DataSourceStructureColumn {
	Name = "Template",
	ValueColumnName = "Template",
	DataValueType = dataValueTypeManager.GetInstanceByName("Text"),
	Caption = "Template",
	IsVisible = false,
	IsSortable = false
};
defStructure.AddColumn(column);
defStructure.IsHierarchical = true;
defStructure.HierarchicalColumnName = "ParentId";	
virtualDataSource.Loaded += Page.MacrosTreeGrid.DataLoaded;
Page.MacrosTreeGrid.GetRowConfigHandler +=
delegate(Terrasoft.Core.Entities.Entity row) {
	string primaryColumnName = row.Schema.PrimaryColumn.Name;
	string primaryColumnValue = row.GetColumnValue(primaryColumnName).ToString();
	var config = new DataSourceRowConfig(primaryColumnValue);
	if (row.GetTypedColumnValue<Guid>("ParentId") != null) {
		config.AddConfig(new DataSourceRowIsExpandableConfigValue(false));
	}
	return config;
};
Page.DataSource.BeforeSaveRow += delegate(object sender, DataSourceEventArgs e) {
	SetEntityBinaryColumnValues(e.Row);
	ResetCache();
};
Page.DataSource.SaveRow += delegate(object sender, DataSourceEventArgs e) {
	SetEntityBodyColumnValue(e.Row);
};
Page.AddMacrosToolButton.AjaxEvents.Click.Event += delegate(object sender, AjaxEventArgs e) {
	var macrosCollection = MacrosCollection as OrderedDictionary;
	if (macrosCollection != null) {
		foreach(var macrosGroup in macrosCollection) {
			var rootMenuItem = new Terrasoft.UI.WebControls.Controls.MenuItem();
			rootMenuItem.CreatedByAjax = true;
			rootMenuItem.Caption = ((DictionaryEntry)macrosGroup).Key.ToString();
			rootMenuItem.ID = string.Format("{0}_{1}", Page.AddMacrosToolButton.ClientID, Guid.NewGuid().ToString("N"));
			rootMenuItem.Page = (Page.AspPage as System.Web.UI.Page);
			Page.AddMacrosToolButton.Menu.AddCaptionItem(rootMenuItem);		
			foreach(var macros in ((DictionaryEntry)macrosGroup).Value as JArray) {
				var menuItem = new Terrasoft.UI.WebControls.Controls.MenuItem();
				menuItem.CreatedByAjax = true;
				menuItem.Caption = macros["caption"].ToString();
				menuItem.ID = string.Format("{0}_{1}", rootMenuItem.ID, Guid.NewGuid().ToString("N"));
				rootMenuItem.Menu.AddCaptionItem(menuItem);
				var menuItemClickScript = string.Format(
					@"{0}.on('click', {1}.customMenuItemClickHandler);",
					menuItem.ClientID,
					Page.AddMacrosToolButton.ClientID
				);
				Page.ScriptManager.AddScript(menuItemClickScript);
			}
		}
	}
	var showMenuScript = string.Format("{0}.menu.show({0}.el, {0}.menuAlign);", Page.AddMacrosToolButton.ClientID);
	Page.ScriptManager.AddScript(showMenuScript);
};
var removeMenuScript = string.Format("if ({0}.menu){{{0}.menu.destroy();{0}.menu = null;}}", Page.AddMacrosToolButton.ClientID);
Page.ScriptManager.AddScript(removeMenuScript);
Page.BodyEdit.AjaxEvents.ImageLoaded.Event += (sender, e) => {
	EntitySchemaManager esm = UserConnection.EntitySchemaManager;
	var entitySchema = esm.FindInstanceByUId(Page.DataSource.SchemaUId);
	if (entitySchema == null) {
		return;
	}
	InsertImageAsBase64();
};
return true;
		}

		public virtual bool BaseModuleInitExecute(ProcessExecutingContext context) {
			if (EntityPrimaryColumnValue == Guid.Empty) {
	var isNew = Page.GetParameterValue("recordId");
	if (isNew != null) {
		IsNew = (new Guid(isNew.ToString()) == Guid.Empty);
	}
	var isCopy = Page.GetParameterValue("Copy");
	if (isCopy != null) {
		IsCopy = (isCopy.ToString().ToLower() == "true");
	}
}
HasDetails = true;
Page.OKButton.AjaxEvents.Click.CausesValidation = true;
Page.PreviousButton.AjaxEvents.Click.CausesValidation = true;
Page.NextButton.AjaxEvents.Click.CausesValidation = true;

if (!ParametersInitialized) {
	UseModuleDetails = true;
	if (Page.GetParameterValue("SysModuleEditId") != null) {
		var sysModuleEditUId = new Guid(Page.GetParameterValue("SysModuleEditId").ToString());
		var entitySchemaManager = UserConnection.EntitySchemaManager;
		var entitySchemaQuery = new EntitySchemaQuery(entitySchemaManager, "SysModuleEdit");
		var useModuleDetailsColumnName = entitySchemaQuery.AddColumn("UseModuleDetails").Name;
		var helpContextIdColumnName = entitySchemaQuery.AddColumn("HelpContextId").Name;
		entitySchemaQuery.Filters.Add(entitySchemaQuery.CreateFilterWithParameters(FilterComparisonType.Equal, 
			entitySchemaQuery.RootSchema.GetPrimaryColumnName(), sysModuleEditUId));
		var entities = entitySchemaQuery.GetEntityCollection(UserConnection);
		if (entities.Count > 0) {
			UseModuleDetails = entities[0].GetTypedColumnValue<bool>(useModuleDetailsColumnName);
			if (!UseModuleDetails) {
				EditInitializeDetails.SysModuleEditId = sysModuleEditUId;
			}
			string helpContextId = entities[0].GetTypedColumnValue<string>(helpContextIdColumnName);
			if (!string.IsNullOrEmpty(helpContextId)) {
				((TSWebControls.WebControl)Page.PageContainer).HelpContextId = helpContextId;
			}
		}
	}
	if (Page.GetParameterValue("SysModuleId") != null) {
		var sysModuleId = new Guid(Page.GetParameterValue("SysModuleId").ToString());
		if (sysModuleId != Guid.Empty) {
			SysModuleId = sysModuleId;
		}
	} else {
		SysModuleId = GetSysModuleId();
	}
}
EditInitializeDetails.SysModuleId = SysModuleId;
EditInitializeDetails.DetailTabPanel = Page.DataTabPanel;
EditInitializeDetails.InModuleEdit = true;
EditInitializeDetails.UseModuleDetails = UseModuleDetails;
EditInitializeDetails.ParentSysEntitySchemaId = Page.DataSource.SchemaUId;
EditInitializeDetails.DefaultCollapsed = Page.DataTabPanel.Collapsed;
Page.DataSource.BeforeSaveRow += 
delegate(object sender, DataSourceEventArgs e) {
	e.Cancel = !AreConditionsCorrect(e.Row);
};
Page.DataSource.BeforeInsert += 
delegate(object sender, DataSourceEventArgs e) {
	var entity = e.Row;
	var bodyColumn = entity.Schema.FindSchemaColumnByPath("Body");
	entity.Schema.Columns.Remove(bodyColumn);
};
Page.DataSource.SaveError +=
delegate(object sender, DataSourceEventArgs e) {
	ShowErrorMessage(e.Exception.Message);
	e.IsHandled = true;
};
Page.DataSource.RemoveError +=
delegate(object sender, DataSourceEventArgs e) {
	ShowErrorMessage(e.Exception.Message);
	e.IsHandled = true;
};
var AspPage = Page.AspPage as Terrasoft.UI.WebControls.Page;
if (AspPage.UseProfile) {
	AspPage.InitializeProfile(new ProfileKeyEventArgs());
	if (!Ext.IsAjaxRequest) {
		Page.DataTabPanel.UseProfile = false;
	}
}
return true;
		}

		public virtual bool PageLoadCompleteScriptTaskEmailTemplateExecute(ProcessExecutingContext context) {
			RegisterObjectMenuItemStateScript();
RegisterNameSubjectRelationScript();
RegisterSaveAsActivityLogicScript();
FillMenuPriority();
OrderedDictionary macrosCollection = new OrderedDictionary();
if (IsNew) {
	var schemasCollection = new Dictionary<string, object>();
	var contactSchema = UserConnection.EntitySchemaManager.GetInstanceByName("Contact");
	var parentIdNameDictionary = new Dictionary<Guid, string>();
	var esq = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "EmailTemplateMacros");
	esq.PrimaryQueryColumn.IsAlwaysSelect = true;
	esq.AddColumn("Name");
	esq.AddColumn("Parent").OrderByAsc(1);
	esq.AddColumn("ColumnPath");
	esq.AddColumn("Position").OrderByAsc(2);
	esq.AddColumn("Template");
	esq.Filters.Add(
		esq.CreateIsNullFilter("AccountCommunicationType")
	);
	var entityCollection = esq.GetEntityCollection(UserConnection);
	if (entityCollection.Count > 0) {
		var parentColumnValueName = esq.RootSchema.Columns.FindByName("Parent").ColumnValueName;
		foreach(var entity in entityCollection) {
			var path = entity.GetTypedColumnValue<string>("ColumnPath");
			var parentId = entity.GetTypedColumnValue<Guid>(parentColumnValueName);
			var template = entity.GetTypedColumnValue<string>("Template");
			/*
			if (string.IsNullOrEmpty(path) && parentId != Guid.Empty) {
				continue;
			}
			*/
			if (parentId == Guid.Empty) {
				parentIdNameDictionary.Add(entity.PrimaryColumnValue, entity.PrimaryDisplayColumnValue);
				macrosCollection.Add(entity.PrimaryDisplayColumnValue, new JArray());
			} else {
				var name = entity.GetTypedColumnValue<string>("Name");
				var macros = new JObject();
				macros.Add(
					new JProperty(
						"caption", 
						name
					)
				);
				macros.Add(
					new JProperty(
						"metaPath", 
						string.IsNullOrEmpty(path) ? string.Empty : contactSchema.GetSchemaColumnMetaPathByPath(path)
					)
				);
				macros.Add(
					new JProperty(
						"template",
						template
					)
				);
				(macrosCollection[parentIdNameDictionary[parentId]] as JArray).Add(macros);
			}
		}
	}
	MacrosCollection = macrosCollection;
	IsMacrosCollectionChanged = true;
	ParentIdNameDictionary = parentIdNameDictionary;
	LoadVirtualDataSourceRows(macrosCollection);
	SetPriorityValue("AB96FA02-7FE6-DF11-971B-001D60E938C6");//Normal
} else {
	var activeRow = IsCopy ? Page.DataSource.Rows[0] : Page.DataSource.ActiveRow;	
	var macrosBytes = activeRow.GetBytesValue("Macros");
	var deserializedList = Json.Deserialize<List<DictionaryEntry>>(
		System.Text.Encoding.UTF8.GetString(macrosBytes)
	);
	foreach(var item in deserializedList) {
		macrosCollection.Add(item.Key, item.Value);
	}
	LoadVirtualDataSourceRows(macrosCollection);
	if (macrosCollection.Count == 3) {
		var objectSchemaColumn = activeRow.Schema.Columns.FindByName("Object");
		var objectId = activeRow.GetTypedColumnValue<Guid>(objectSchemaColumn.ColumnValueName);
		var objectCaption = activeRow.GetTypedColumnValue<string>(objectSchemaColumn.DisplayColumnValueName);
		Page.ObjectMenuItem.Caption = objectCaption;
		Page.ObjectMenuItem.Hidden = false;
		CurrentObjectSchemaId = objectId;
		CurrentObjectSchemaName = objectCaption;
	}
	MacrosCollection = macrosCollection;
	if (IsCopy) {
		IsMacrosCollectionChanged = true;
	}
	var recipientBytes = activeRow.GetBytesValue("Recipient");
	var recipient = Json.Deserialize<string>(System.Text.Encoding.UTF8.GetString(recipientBytes));
	Page.RecipientEdit.SuspendAjaxEvents();
	Page.RecipientEdit.SetValue(GetDisplayValues(recipient));
	Page.RecipientEdit.ResumeAjaxEvents();
	var copyRecipientBytes = activeRow.GetBytesValue("CopyRecipient");
	var copyRecipient = Json.Deserialize<string>(System.Text.Encoding.UTF8.GetString(copyRecipientBytes));
	Page.CopyRecipientEdit.SuspendAjaxEvents();
	Page.CopyRecipientEdit.SetValue(GetDisplayValues(copyRecipient));
	Page.CopyRecipientEdit.ResumeAjaxEvents();
	var blindCopyRecipientBytes = activeRow.GetBytesValue("BlindCopyRecipient");
	var blindCopyRecipient = Json.Deserialize<string>(System.Text.Encoding.UTF8.GetString(blindCopyRecipientBytes));
	Page.BlindCopyRecipientEdit.SuspendAjaxEvents();
	Page.BlindCopyRecipientEdit.SetValue(GetDisplayValues(blindCopyRecipient));
	Page.BlindCopyRecipientEdit.ResumeAjaxEvents();
	if (!IsCopy) {
		Recipient = recipient;
		CopyRecipient = copyRecipient;
		BlindCopyRecipient = blindCopyRecipient;
	}
	var saveAsActivity = Page.DataSource.ActiveRow.GetTypedColumnValue<bool>("SaveAsActivity");
	if (saveAsActivity) {
		Page.ObjectFieldInActivityEdit.Enable();
	}
	AddtObjectFieldInActivityValues(CurrentObjectSchemaId);
	var selectedColumnId = activeRow.GetTypedColumnValue<Guid>("ObjectFieldInActivity");
	if (selectedColumnId != Guid.Empty) {
		var activitySchema = UserConnection.EntitySchemaManager.GetInstanceByName("Activity");		
		var activityColumn = activitySchema.Columns.FindByUId(selectedColumnId);
		Page.ObjectFieldInActivityEdit.SetValueAndText(activityColumn.UId, activityColumn.Caption);
		Page.ObjectFieldInActivityEdit.ListPrepared = true;	
		ObjectFieldInActivityId = selectedColumnId;
	}
	SetPriorityValue(activeRow.GetTypedColumnValue<Guid>("PriorityId").ToString());
}
var menuItemClickHandlerScript = string.Format(
	@"{0}.customMenuItemClickHandler = function(){{
		{1}.setValue({1}.getValue() + '[#' + this.parentMenu.owner.caption + '.' + this.caption + '#]');
	}}",
	Page.AddMacrosToolButton.ClientID,
	Page.SubjectEdit.ClientID
);
Page.ScriptManager.AddScript(menuItemClickHandlerScript);
string setReadOnlyScript = string.Format(
	@"{0}.setReadOnly('true'); {1}.setReadOnly('true'); {2}.setReadOnly('true');",
	Page.RecipientEdit.ClientID,
	Page.CopyRecipientEdit.ClientID,
	Page.BlindCopyRecipientEdit.ClientID
);
Page.ScriptManager.AddScript(setReadOnlyScript);

if (IsNew || IsCopy) {
	var aspPage = Page.AspPage as Terrasoft.UI.WebControls.Page;
	aspPage.CustomData["needAddDetailRequest"] = false;
}
Entity dsActiveRow = Page.DataSource.ActiveRow;
Guid primaryColumnValue = 
	(CopyEntityId != Guid.Empty) ? CopyEntityId : dsActiveRow.PrimaryColumnValue;
string schemaName = Page.DataSource.Schema.Name;
var selectBody = new Select(UserConnection)
	.Column("Body")
	.From(schemaName)
	.Where("Id").IsEqual(Column.Parameter(primaryColumnValue.ToString())) as Select;
string emailTemplateBody = string.Empty;
using (DBExecutor dbExecutor = UserConnection.EnsureDBConnection()) {
	using (IDataReader rd = selectBody.ExecuteReader(dbExecutor)) {
		while (rd.Read()) {
			emailTemplateBody = (string)rd["Body"];
		}
	}
}
string body = Json.Serialize(emailTemplateBody);
StringBuilder sb = new StringBuilder();
sb.AppendLine("(function(){");
sb.AppendLine("var tId = setInterval(function(){ if(window.CKEDITOR) { onComplete()} }, 500);");
sb.AppendLine("function onComplete(){");
sb.AppendLine("clearInterval(tId); ");
sb.Append(string.Format("CKEDITOR.instances['{0}'].setData(", Page.BodyEdit.ClientID));
sb.Append(body);
sb.AppendLine(");");
sb.AppendLine("};");
sb.AppendLine("})()");
Page.ScriptManager.AddScript(sb.ToString());
return true;
		}

		public virtual bool ScriptTask3Execute(ProcessExecutingContext context) {
			if (IsCopy) {
	string queryString = Page.Request.QueryString.ToString();
	if (queryString.Contains("recordId")) {
		CopyEntityId = new Guid(Page.Request.QueryString["recordId"].ToString());
	}
}
if (ActivatedEventElements.Contains("PageLoadCompleteStartMessage")) {
	ActivatedEventElements.Remove("PageLoadCompleteStartMessage");
}
return true;

		}

		public virtual bool PutTemplateToBodyButtonClickMarketingScriptTaskExecute(ProcessExecutingContext context) {
			var selectedNodes = Page.MacrosTreeGrid.SelectedNodes;
if (selectedNodes.Count > 0) {
	if (!selectedNodes[0].Values.ContainsKey("ParentId")) {
		return true;
	}
	var parentIdNameDictionary = ParentIdNameDictionary as Dictionary<Guid, string>;
	var parentId = new Guid(selectedNodes[0].Values["ParentId"].ToString());
	var template = selectedNodes[0].Values.ContainsKey("Template") ? selectedNodes[0].Values["Template"].ToString() : string.Empty;
	var textMacros = string.Format("[#{0}.{1}#]", parentIdNameDictionary[parentId], selectedNodes[0].Values["Name"]);
	if (string.IsNullOrEmpty(template)) {
		Page.BodyEdit.InsertText(textMacros);
	} else {
		Page.BodyEdit.InsertTextAsSource(template.Replace("[##]", textMacros));
	}
}
return true;
		}

		public override void LoadVirtualDataSourceRows(OrderedDictionary macrosCollection) {
			Page.MacrosTreeGrid.Clear();
var virtualDataSource = Page.PageContainer.FindPageControl(VirtualDataSourceID) as VirtualDataSource;
virtualDataSource.Clear();
var parentIdNameDictionary = new Dictionary<Guid, string>();
foreach(var macrosGroup in macrosCollection) {
	var row = virtualDataSource.CreateRow();
	var parentId = Guid.NewGuid();
	row.SetColumnValue("Id", parentId);
	row.SetColumnValue("Name", ((DictionaryEntry)macrosGroup).Key);
	row.SetColumnValue("ParentId", null);
	row.SetColumnValue("Template", string.Empty);
	virtualDataSource.Add(row);
	parentIdNameDictionary[parentId] = ((DictionaryEntry)macrosGroup).Key.ToString();
	foreach(var macros in ((DictionaryEntry)macrosGroup).Value as JArray) {
		row = virtualDataSource.CreateRow();
		row.SetColumnValue("Id", Guid.NewGuid());
		row.SetColumnValue("Name", macros["caption"]);
		row.SetColumnValue("ParentId", parentId);
		row.SetColumnValue("Template", macros["template"]);
		virtualDataSource.Add(row);
	}
}
virtualDataSource.LoadRows();
ParentIdNameDictionary = parentIdNameDictionary;
		}

		public virtual bool InsertImageAsBase64() {
			string fileFieldName = Page.BodyEdit.ClientID + "_loadedImage-file";
if (!Page.Request.Files.AllKeys.Contains(fileFieldName)) {
	return false;
}
string fileName = Page.Request.Files[fileFieldName].FileName;

System.IO.Stream fileContent = Page.Request.Files[fileFieldName].InputStream;
fileContent.Position = 0;
int FileSize = (int)fileContent.Length;
byte[] fileData = new byte[fileContent.Length];
fileContent.Read(fileData, 0, fileData.Length);

string imgExtension = System.IO.Path.GetExtension(fileName);
imgExtension = imgExtension.Replace(".", string.Empty);
string imgSrc = System.Convert.ToBase64String(fileData);
string imgPattern = "\"data:image/{1};base64,{0}\"";
string jImage = String.Format(imgPattern, imgSrc, imgExtension);

StringBuilder sb = new StringBuilder();
sb.Append("(function(){var cke=");
sb.Append(Page.BodyEdit.ClientID);
sb.Append(".ckEditor;var img=cke.document.createElement('img');img.setAttribute('alt','');img.setAttribute('src',");
sb.Append(jImage);
sb.Append(");cke.insertElement(img);})();");
Page.AddScript(sb.ToString());

return true;
		}

		public virtual void SetEntityBodyColumnValue(Entity entity) {
			var body = Page.BodyEdit.Text;
var schemaName = entity.SchemaName;
var primaryColumnValue = entity.PrimaryColumnValue;
(new Update(UserConnection, schemaName)
	.Set("Body", Column.Parameter(body))
	.Where("Id").IsEqual(Column.Parameter(primaryColumnValue))).Execute();
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "Init":
							if (ActivatedEventElements.Contains("InitEmailTemplateEditPageMarketing")) {
							context.QueueTasks.Enqueue("InitEmailTemplateEditPageMarketing");
							ProcessQueue(context);
							return;
							ProcessQueue(context);
							return;
						}
						break;
					case "PageLoadComplete":
							if (ActivatedEventElements.Contains("PageLoadCompleteEmailTemplate")) {
							context.QueueTasks.Enqueue("PageLoadCompleteEmailTemplate");
							ProcessQueue(context);
							return;
							ProcessQueue(context);
							return;
						}
						break;
					case "PutTemplateToBodyButtonClick":
							if (ActivatedEventElements.Contains("PutTemplateToBodyButtonClickMarketingStartMessage")) {
							context.QueueTasks.Enqueue("PutTemplateToBodyButtonClickMarketingStartMessage");
							ProcessQueue(context);
							return;
						}
						break;
					case "MacrosTreeGridDblClick":
							if (ActivatedEventElements.Contains("MacrosTreeGridDblClickMarketingStartMessage")) {
							context.QueueTasks.Enqueue("MacrosTreeGridDblClickMarketingStartMessage");
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
			if (!HasMapping("CopyEntityId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("CopyEntityId", CopyEntityId, Guid.Empty);
			}
		}

		public override object CloneShallow() {
			return base.CloneShallow();
		}

		#endregion

	}

	#endregion

	#region Class: EmailTemplateEditPageEventsProcess

	/// <exclude/>
	public class EmailTemplateEditPageEventsProcess : EmailTemplateEditPageEventsProcess<Terrasoft.WebApp.EmailTemplateEditPageSchemaUserControl>
	{

		public EmailTemplateEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: EmailTemplateEditPageSchemaUserControl

	/// <exclude/>
	public partial class EmailTemplateEditPageSchemaUserControl : Terrasoft.WebApp.EmailTemplateEditPage_Base_TerrasoftSchemaUserControl
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
			var process = (EmailTemplateEditPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new EmailTemplateEditPageEventsProcess(UserConnection);
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
			SchemaName = "EmailTemplateEditPage";
		}

		#endregion

	}

	#endregion

	#region Class: EmailTemplateEditPageEventsProcessSchema

	/// <exclude/>
	public class EmailTemplateEditPageEventsProcessSchema : Terrasoft.WebApp.EmailTemplateEditPage_Base_TerrasoftEventsProcessSchema
	{

		#region Constructors: Public

		public EmailTemplateEditPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public EmailTemplateEditPageEventsProcessSchema(EmailTemplateEditPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "EmailTemplateEditPageEventsProcess";
			UId = new Guid("5f6201ed-f63b-47de-bf2f-50f74571e281");
			CreatedInPackageId = new Guid("b477c174-1d53-4a21-b489-a41e481a96a0");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
		}

		protected virtual ProcessSchemaParameter CreateCopyEntityIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("9aa3a64b-a7e2-4fc8-b04c-5f0e091e5be4"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("5f6201ed-f63b-47de-bf2f-50f74571e281"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("5f6201ed-f63b-47de-bf2f-50f74571e281"),
				Name = @"CopyEntityId",
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateCopyEntityIdParameter());
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet1 = CreateLaneSet1LaneSet();
			LaneSets.Add(schemaLaneSet1);
			ProcessSchemaLane schemaLane3 = CreateLane3Lane();
			schemaLaneSet1.Lanes.Add(schemaLane3);
			ProcessSchemaLane schemaLane4 = CreateLane4Lane();
			schemaLaneSet1.Lanes.Add(schemaLane4);
			ProcessSchemaLane schemaLane5 = CreateLane5Lane();
			schemaLaneSet1.Lanes.Add(schemaLane5);
			ProcessSchemaEventSubProcess eventsubprocess9 = CreateEventSubProcess9EventSubProcess();
			FlowElements.Add(eventsubprocess9);
			ProcessSchemaEventSubProcess eventsubprocess10 = CreateEventSubProcess10EventSubProcess();
			FlowElements.Add(eventsubprocess10);
			ProcessSchemaEventSubProcess eventsubprocess11 = CreateEventSubProcess11EventSubProcess();
			FlowElements.Add(eventsubprocess11);
			ProcessSchemaScriptTask initscripttaskchild = CreateInitScriptTaskChildScriptTask();
			eventsubprocess9.FlowElements.Add(initscripttaskchild);
			ProcessSchemaStartMessageEvent initemailtemplateeditpagemarketing = CreateInitEmailTemplateEditPageMarketingStartMessageEvent();
			eventsubprocess9.FlowElements.Add(initemailtemplateeditpagemarketing);
			ProcessSchemaScriptTask basemoduleinit = CreateBaseModuleInitScriptTask();
			eventsubprocess9.FlowElements.Add(basemoduleinit);
			ProcessSchemaStartMessageEvent pageloadcompleteemailtemplate = CreatePageLoadCompleteEmailTemplateStartMessageEvent();
			eventsubprocess10.FlowElements.Add(pageloadcompleteemailtemplate);
			ProcessSchemaIntermediateThrowMessageEvent pageloadcompleteemailtemplateparent = CreatePageLoadCompleteEmailTemplateParentIntermediateThrowMessageEvent();
			eventsubprocess10.FlowElements.Add(pageloadcompleteemailtemplateparent);
			ProcessSchemaScriptTask pageloadcompletescripttaskemailtemplate = CreatePageLoadCompleteScriptTaskEmailTemplateScriptTask();
			eventsubprocess10.FlowElements.Add(pageloadcompletescripttaskemailtemplate);
			ProcessSchemaScriptTask scripttask3 = CreateScriptTask3ScriptTask();
			eventsubprocess10.FlowElements.Add(scripttask3);
			ProcessSchemaStartMessageEvent puttemplatetobodybuttonclickmarketingstartmessage = CreatePutTemplateToBodyButtonClickMarketingStartMessageStartMessageEvent();
			eventsubprocess11.FlowElements.Add(puttemplatetobodybuttonclickmarketingstartmessage);
			ProcessSchemaScriptTask puttemplatetobodybuttonclickmarketingscripttask = CreatePutTemplateToBodyButtonClickMarketingScriptTaskScriptTask();
			eventsubprocess11.FlowElements.Add(puttemplatetobodybuttonclickmarketingscripttask);
			ProcessSchemaStartMessageEvent macrostreegriddblclickmarketingstartmessage = CreateMacrosTreeGridDblClickMarketingStartMessageStartMessageEvent();
			eventsubprocess11.FlowElements.Add(macrostreegriddblclickmarketingstartmessage);
			FlowElements.Add(CreateSequenceFlow23SequenceFlow());
			FlowElements.Add(CreateSequenceFlow28SequenceFlow());
			FlowElements.Add(CreateSequenceFlow24SequenceFlow());
			FlowElements.Add(CreateSequenceFlow25SequenceFlow());
			FlowElements.Add(CreateSequenceFlow26SequenceFlow());
			FlowElements.Add(CreateSequenceFlow27SequenceFlow());
			FlowElements.Add(CreateSequenceFlow29SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow23SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow23",
				UId = new Guid("dc9760de-6c49-47e1-9a8d-a154d1efe954"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				CreatedInPackageId = new Guid("b477c174-1d53-4a21-b489-a41e481a96a0"),
				CreatedInSchemaUId = new Guid("5f6201ed-f63b-47de-bf2f-50f74571e281"),
				CurveCenterPosition = new Point(192, 88),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("5f6201ed-f63b-47de-bf2f-50f74571e281"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("1c9bd460-28dc-4d41-8b74-e8539b6451f0"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("d35f5d15-bbff-4efe-9310-977c2af530ec"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow28SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow28",
				UId = new Guid("f011b8f9-6a36-4287-9c1c-cc4f42033657"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				CreatedInPackageId = new Guid("b477c174-1d53-4a21-b489-a41e481a96a0"),
				CreatedInSchemaUId = new Guid("5f6201ed-f63b-47de-bf2f-50f74571e281"),
				CurveCenterPosition = new Point(192, 88),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("5f6201ed-f63b-47de-bf2f-50f74571e281"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("d35f5d15-bbff-4efe-9310-977c2af530ec"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("5e7a3179-817b-4b1f-a7ea-1c57ef847d6d"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow24SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow24",
				UId = new Guid("01c5e167-3533-40eb-bfb0-0f97f37d0266"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				CreatedInPackageId = new Guid("b477c174-1d53-4a21-b489-a41e481a96a0"),
				CreatedInSchemaUId = new Guid("5f6201ed-f63b-47de-bf2f-50f74571e281"),
				CurveCenterPosition = new Point(219, 294),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("5f6201ed-f63b-47de-bf2f-50f74571e281"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("d233ee72-156e-4e47-96ca-27d0489df79e"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("c2a3ce58-ae9d-451a-a071-7d9bab71a6af"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow25SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow25",
				UId = new Guid("41fba8ad-01c0-4e11-8464-52b558a966ad"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				CreatedInPackageId = new Guid("b477c174-1d53-4a21-b489-a41e481a96a0"),
				CreatedInSchemaUId = new Guid("5f6201ed-f63b-47de-bf2f-50f74571e281"),
				CurveCenterPosition = new Point(376, 294),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("5f6201ed-f63b-47de-bf2f-50f74571e281"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("010bc99d-dfab-4b42-aa47-2305918ac95e"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("5ccbcaba-70d2-4a8d-922a-03e9b6cafc4c"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow26SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow26",
				UId = new Guid("b96873f5-888d-4356-9113-bceb70e95db8"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				CreatedInPackageId = new Guid("b477c174-1d53-4a21-b489-a41e481a96a0"),
				CreatedInSchemaUId = new Guid("5f6201ed-f63b-47de-bf2f-50f74571e281"),
				CurveCenterPosition = new Point(219, 294),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("5f6201ed-f63b-47de-bf2f-50f74571e281"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("c2a3ce58-ae9d-451a-a071-7d9bab71a6af"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("010bc99d-dfab-4b42-aa47-2305918ac95e"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow27SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow27",
				UId = new Guid("6ce89ca0-9d23-410d-af50-34da03523699"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				CreatedInPackageId = new Guid("b477c174-1d53-4a21-b489-a41e481a96a0"),
				CreatedInSchemaUId = new Guid("5f6201ed-f63b-47de-bf2f-50f74571e281"),
				CurveCenterPosition = new Point(210, 498),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("5f6201ed-f63b-47de-bf2f-50f74571e281"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("63ac82de-4785-4425-8628-f28402849601"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("2012328e-bdae-44da-9eb8-6c299b4a0085"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow29SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow29",
				UId = new Guid("84999374-a070-408c-8e97-e3c7c0afc98d"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				CreatedInPackageId = new Guid("b477c174-1d53-4a21-b489-a41e481a96a0"),
				CreatedInSchemaUId = new Guid("5f6201ed-f63b-47de-bf2f-50f74571e281"),
				CurveCenterPosition = new Point(375, 498),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("5f6201ed-f63b-47de-bf2f-50f74571e281"),
				OwnerSchemaManagerName = @"PageSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("b3cc7049-21b0-4c8b-926e-f9144f48399d"),
				SourceSequenceFlowPointLocalPosition = new Point(-1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("2012328e-bdae-44da-9eb8-6c299b4a0085"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("347b4f67-9734-4bb3-887a-0387acd20be1"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				CreatedInPackageId = new Guid("b477c174-1d53-4a21-b489-a41e481a96a0"),
				CreatedInSchemaUId = new Guid("5f6201ed-f63b-47de-bf2f-50f74571e281"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("5f6201ed-f63b-47de-bf2f-50f74571e281"),
				Name = @"LaneSet1",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(5, 5),
				Size = new Size(1185, 578)
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane3Lane() {
			ProcessSchemaLane schemaLane3 = new ProcessSchemaLane(this) {
				UId = new Guid("2f9fb0a2-1641-40b2-86a8-712b93074e1b"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("347b4f67-9734-4bb3-887a-0387acd20be1"),
				CreatedInOwnerSchemaUId = new Guid("16d64721-88e3-450c-af3a-41370e23dd83"),
				CreatedInPackageId = new Guid("b477c174-1d53-4a21-b489-a41e481a96a0"),
				CreatedInSchemaUId = new Guid("5f6201ed-f63b-47de-bf2f-50f74571e281"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("5f6201ed-f63b-47de-bf2f-50f74571e281"),
				Name = @"Lane3",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 0),
				Size = new Size(1156, 191)
			};
			return schemaLane3;
		}

		protected virtual ProcessSchemaLane CreateLane4Lane() {
			ProcessSchemaLane schemaLane4 = new ProcessSchemaLane(this) {
				UId = new Guid("83ace29f-882b-4d01-b931-9e4dc28e5adb"),
				ContainerItemIndex = 2,
				ContainerUId = new Guid("347b4f67-9734-4bb3-887a-0387acd20be1"),
				CreatedInOwnerSchemaUId = new Guid("16d64721-88e3-450c-af3a-41370e23dd83"),
				CreatedInPackageId = new Guid("b477c174-1d53-4a21-b489-a41e481a96a0"),
				CreatedInSchemaUId = new Guid("5f6201ed-f63b-47de-bf2f-50f74571e281"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("5f6201ed-f63b-47de-bf2f-50f74571e281"),
				Name = @"Lane4",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 196),
				Size = new Size(1156, 196)
			};
			return schemaLane4;
		}

		protected virtual ProcessSchemaLane CreateLane5Lane() {
			ProcessSchemaLane schemaLane5 = new ProcessSchemaLane(this) {
				UId = new Guid("99a02600-1c6d-4ef2-b770-d62335ce62ba"),
				ContainerItemIndex = 3,
				ContainerUId = new Guid("347b4f67-9734-4bb3-887a-0387acd20be1"),
				CreatedInOwnerSchemaUId = new Guid("16d64721-88e3-450c-af3a-41370e23dd83"),
				CreatedInPackageId = new Guid("b477c174-1d53-4a21-b489-a41e481a96a0"),
				CreatedInSchemaUId = new Guid("5f6201ed-f63b-47de-bf2f-50f74571e281"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("5f6201ed-f63b-47de-bf2f-50f74571e281"),
				Name = @"Lane5",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(29, 397),
				Size = new Size(1156, 181)
			};
			return schemaLane5;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess9EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess9 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("198ea53b-a22d-4911-80df-f1d211856f8d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("2f9fb0a2-1641-40b2-86a8-712b93074e1b"),
				CreatedInOwnerSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				CreatedInPackageId = new Guid("b477c174-1d53-4a21-b489-a41e481a96a0"),
				CreatedInSchemaUId = new Guid("5f6201ed-f63b-47de-bf2f-50f74571e281"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("5f6201ed-f63b-47de-bf2f-50f74571e281"),
				Name = @"EventSubProcess9",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(42, 14),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(1012, 161),
				TriggeredByEvent = true,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess9;
		}

		protected virtual ProcessSchemaScriptTask CreateInitScriptTaskChildScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("5e7a3179-817b-4b1f-a7ea-1c57ef847d6d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("198ea53b-a22d-4911-80df-f1d211856f8d"),
				CreatedInOwnerSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				CreatedInPackageId = new Guid("b477c174-1d53-4a21-b489-a41e481a96a0"),
				CreatedInSchemaUId = new Guid("5f6201ed-f63b-47de-bf2f-50f74571e281"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("5f6201ed-f63b-47de-bf2f-50f74571e281"),
				Name = @"InitScriptTaskChild",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(351, 37),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,197,88,75,111,219,70,16,62,43,64,254,3,203,75,72,212,88,164,64,209,139,234,160,122,56,14,155,218,17,44,57,61,20,69,177,38,71,246,38,36,87,221,93,202,22,12,255,247,206,236,242,41,138,118,224,26,237,193,178,184,59,143,111,222,67,45,248,53,176,57,55,124,41,11,21,3,155,194,90,42,248,77,242,196,251,254,216,75,32,133,107,110,32,144,87,95,32,54,158,134,60,1,117,228,53,12,39,91,200,205,68,93,107,15,66,239,254,245,171,209,150,43,47,169,175,189,99,47,8,26,234,208,9,8,199,72,216,16,177,5,130,184,144,183,122,38,139,220,32,203,219,113,41,232,74,38,187,153,76,139,44,199,211,22,195,172,80,10,245,46,141,42,98,83,40,60,176,68,154,189,23,121,50,221,157,243,12,2,127,138,204,254,190,170,65,206,11,200,228,22,130,70,35,113,62,224,159,88,123,129,59,169,153,78,238,54,41,122,73,205,20,160,115,18,103,184,123,24,160,12,172,180,215,175,200,82,246,201,58,243,36,17,134,45,20,108,56,249,91,126,45,54,239,69,106,64,145,223,203,227,134,208,93,149,104,78,238,12,139,244,228,11,191,187,128,191,11,208,198,1,64,154,244,12,242,98,161,132,84,194,236,42,157,159,133,50,5,79,155,40,68,115,244,166,127,198,99,37,117,239,210,71,38,114,253,118,255,2,121,114,184,245,122,12,129,211,110,133,30,80,229,156,104,237,166,143,153,204,13,23,57,40,70,223,148,76,53,155,36,73,208,211,22,86,76,14,230,74,1,156,42,145,180,82,53,74,80,97,143,143,69,115,228,108,158,235,72,96,46,175,155,135,67,156,243,22,1,202,104,211,99,156,68,198,85,153,25,148,94,228,193,40,241,7,232,230,66,111,82,190,71,78,255,43,239,82,70,126,230,105,1,171,221,6,206,120,142,150,42,170,149,249,129,243,16,189,107,93,113,169,49,229,100,158,99,78,8,153,179,201,102,83,82,44,148,220,10,172,43,118,10,166,60,10,252,67,162,108,57,144,254,184,42,42,10,233,1,111,149,69,71,129,109,89,123,132,143,86,100,207,15,116,211,81,88,214,235,62,0,66,24,229,218,240,60,134,170,78,79,11,145,248,33,73,152,241,13,89,214,146,25,97,130,106,113,149,146,188,53,79,53,184,195,165,84,134,183,78,93,146,117,34,129,89,229,80,6,113,93,206,207,176,218,6,109,192,238,250,238,185,150,175,224,206,244,44,175,165,182,109,71,132,255,185,233,11,78,157,114,56,236,157,251,23,13,126,71,242,255,158,2,43,200,176,152,205,96,26,116,238,95,52,21,58,146,95,214,15,29,130,72,127,16,160,184,138,111,68,204,211,50,221,246,137,218,36,3,137,48,30,97,119,233,245,85,90,38,192,174,19,67,13,221,81,12,116,124,116,22,238,6,216,247,214,226,250,3,207,147,212,142,72,2,87,238,38,43,80,138,107,185,54,56,82,16,231,73,110,132,17,160,221,151,157,167,228,173,155,80,218,40,145,95,123,155,3,173,28,105,216,50,190,129,140,119,59,61,163,251,241,0,175,13,107,201,140,32,91,135,65,79,71,200,86,114,105,101,216,169,60,114,61,152,76,234,165,98,109,108,208,215,102,121,105,5,40,117,82,82,37,173,251,159,169,156,222,5,77,68,66,239,59,148,95,164,169,115,193,200,233,116,25,97,117,244,116,71,26,119,22,116,51,229,148,163,113,38,217,228,10,45,0,220,41,70,10,48,41,242,210,134,113,107,200,247,118,201,37,223,146,220,103,174,147,75,48,46,142,83,145,119,125,161,3,96,40,215,34,186,0,141,1,224,24,193,32,28,0,243,82,48,234,253,208,185,165,198,80,235,68,223,150,25,44,101,58,45,140,161,81,141,187,154,149,169,217,44,21,241,87,102,31,30,195,82,115,236,239,214,153,149,141,16,82,183,6,96,254,156,237,31,113,237,125,82,40,6,146,185,176,39,232,185,42,115,122,252,221,4,161,136,161,31,131,70,213,169,146,197,198,19,121,79,115,201,97,81,41,41,13,237,158,145,129,172,204,232,166,44,47,35,246,59,92,213,251,94,253,165,98,112,37,49,26,181,133,176,114,183,158,238,200,19,77,75,234,145,213,221,18,223,51,106,99,49,86,106,23,182,240,135,236,35,236,246,106,112,79,146,93,96,93,157,179,247,82,101,220,4,254,253,219,135,191,238,127,120,240,143,188,193,208,98,60,169,212,230,71,30,213,30,59,135,91,250,31,180,10,222,63,247,195,67,10,73,36,225,118,162,245,198,62,99,232,150,59,77,215,232,50,242,28,157,150,220,131,24,72,164,173,105,231,12,235,211,182,170,112,60,26,89,9,253,232,82,96,159,240,156,235,115,8,236,215,9,70,116,87,133,221,101,227,191,141,249,40,123,58,224,45,154,58,218,14,225,31,126,236,78,252,63,123,193,109,184,30,143,236,94,18,124,83,28,187,129,60,228,254,172,118,125,223,89,182,5,44,99,37,54,166,7,204,81,143,126,33,128,76,230,193,155,152,136,223,28,121,8,150,197,133,54,50,59,107,139,41,39,98,56,182,59,66,215,89,85,102,150,23,79,166,176,163,171,16,91,114,135,178,218,91,144,217,29,4,7,76,41,249,104,56,216,143,135,178,97,233,27,121,75,144,7,12,182,134,146,56,70,132,1,61,65,138,230,150,167,147,84,92,231,100,221,211,21,104,1,60,138,186,11,165,234,218,182,127,217,183,255,199,96,82,239,172,64,133,247,247,53,234,4,223,191,149,164,151,237,234,200,115,13,117,252,240,77,125,163,126,209,29,2,189,15,173,102,160,81,100,127,68,104,77,151,40,195,27,183,78,53,51,38,168,134,10,142,145,227,119,182,124,221,48,115,43,79,245,250,9,154,202,120,239,37,243,0,97,181,191,64,235,10,25,145,221,254,252,210,108,182,151,81,18,244,198,176,37,199,155,122,149,233,138,233,12,35,183,100,84,43,7,10,6,101,172,133,19,61,229,26,126,250,177,158,246,229,58,98,123,198,63,126,29,129,197,211,18,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateInitEmailTemplateEditPageMarketingStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("1c9bd460-28dc-4d41-8b74-e8539b6451f0"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("198ea53b-a22d-4911-80df-f1d211856f8d"),
				CreatedInOwnerSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				CreatedInPackageId = new Guid("b477c174-1d53-4a21-b489-a41e481a96a0"),
				CreatedInSchemaUId = new Guid("5f6201ed-f63b-47de-bf2f-50f74571e281"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"Init",
				ModifiedInSchemaUId = new Guid("5f6201ed-f63b-47de-bf2f-50f74571e281"),
				Name = @"InitEmailTemplateEditPageMarketing",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(50, 51),
				SerializeToDB = false,
				Size = new Size(0, 0)
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateBaseModuleInitScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("d35f5d15-bbff-4efe-9310-977c2af530ec"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("198ea53b-a22d-4911-80df-f1d211856f8d"),
				CreatedInOwnerSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				CreatedInPackageId = new Guid("b477c174-1d53-4a21-b489-a41e481a96a0"),
				CreatedInSchemaUId = new Guid("5f6201ed-f63b-47de-bf2f-50f74571e281"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("5f6201ed-f63b-47de-bf2f-50f74571e281"),
				Name = @"BaseModuleInit",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(176, 37),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,197,86,223,111,26,57,16,126,166,82,255,135,133,39,163,139,86,125,167,68,34,116,175,65,109,82,154,37,215,135,211,61,24,60,4,247,140,77,109,47,132,86,249,223,111,108,239,111,150,54,205,203,73,8,22,123,230,155,111,198,227,111,150,175,35,146,72,203,237,113,174,249,150,234,227,84,137,108,43,255,162,34,131,104,60,142,222,103,156,197,201,118,103,143,195,232,199,235,87,189,61,213,17,55,183,112,136,198,209,156,62,64,252,30,236,156,106,186,5,11,218,123,145,129,134,149,210,108,198,6,195,17,122,112,140,16,60,250,227,72,102,66,4,160,222,44,71,33,18,127,92,152,96,21,47,84,106,53,151,15,100,56,108,17,112,104,79,37,135,169,218,29,127,66,194,109,215,9,120,243,54,131,28,35,223,174,133,198,199,143,234,0,154,120,14,3,171,51,24,20,241,241,115,77,205,59,176,148,11,131,222,110,19,183,60,145,79,31,174,50,107,149,140,39,95,233,99,178,7,105,77,60,21,124,245,111,60,165,153,1,131,228,56,163,150,43,217,114,156,107,216,115,149,153,23,186,223,194,163,253,125,215,215,175,92,109,250,101,233,204,76,114,203,209,240,59,176,80,163,123,3,55,138,101,2,78,210,245,101,61,87,252,244,104,130,91,194,184,117,141,208,170,188,59,65,83,183,185,159,49,132,46,59,225,217,184,245,110,25,21,200,224,251,57,93,109,96,75,111,168,68,44,141,224,152,138,158,42,41,97,229,138,16,39,167,70,157,0,159,51,208,199,156,91,210,94,39,29,161,46,162,38,205,65,69,44,107,85,51,220,181,91,76,17,3,156,4,141,39,140,5,11,50,104,159,3,102,238,220,74,228,13,136,29,38,103,177,13,102,236,249,176,215,117,183,58,230,169,215,159,92,184,14,113,222,228,116,119,170,129,90,8,54,95,184,221,84,45,69,194,226,84,109,119,84,115,163,228,226,184,131,56,249,150,81,113,17,185,80,29,177,238,148,178,225,191,111,130,186,48,57,134,100,120,113,210,61,237,227,231,96,58,147,71,188,112,138,8,39,66,43,144,102,103,4,32,215,221,5,80,60,85,153,180,209,101,244,38,111,223,174,107,81,24,255,253,230,31,23,196,101,201,106,90,250,118,169,148,184,36,231,59,32,132,245,113,251,109,248,34,108,207,183,125,121,71,243,221,184,117,43,144,76,187,58,1,251,201,127,27,127,95,154,29,243,12,254,193,237,146,156,233,180,58,253,96,26,163,192,227,141,255,164,189,120,55,253,134,101,70,132,44,210,47,176,116,59,90,97,46,213,243,48,232,34,126,185,5,202,37,232,97,124,221,98,221,64,173,101,249,148,143,138,103,137,212,175,4,234,55,181,169,83,151,28,145,58,96,255,116,180,246,122,105,35,98,205,124,84,230,20,129,48,16,204,155,214,200,168,182,64,106,195,234,23,77,227,189,211,70,172,110,143,240,187,160,203,57,149,32,138,209,251,142,90,90,172,157,117,157,201,170,29,171,17,210,109,219,113,183,218,75,103,125,241,76,176,143,49,153,186,82,251,4,75,174,169,202,244,10,226,176,117,255,211,116,215,52,19,214,233,4,221,25,96,93,9,199,229,110,49,136,107,33,174,96,173,52,164,116,15,119,234,16,253,49,70,181,99,32,224,1,133,146,168,229,87,84,155,200,128,100,110,98,84,94,126,114,79,244,131,137,32,116,5,224,252,150,43,95,239,254,68,187,187,128,108,81,166,80,58,52,190,104,89,2,40,151,7,119,220,79,103,57,204,36,42,156,125,49,133,106,36,58,157,112,225,70,249,234,82,177,92,151,75,177,205,43,139,243,66,178,240,24,12,174,142,115,106,55,100,112,133,46,97,36,54,237,131,149,137,239,96,171,246,64,42,228,115,169,185,194,38,90,43,141,121,189,40,173,116,163,14,30,224,6,140,65,112,172,100,242,184,130,157,127,61,200,215,2,81,148,178,107,42,153,240,77,144,55,111,23,165,192,253,127,38,229,206,101,98,118,142,91,209,178,197,95,106,162,5,104,77,141,90,219,248,126,22,215,133,215,25,140,194,11,97,110,238,110,226,92,171,53,23,57,183,98,189,186,43,249,182,127,133,207,159,63,192,177,76,42,23,63,63,20,146,71,139,140,221,203,233,29,124,203,192,216,92,244,78,239,84,21,22,249,175,41,234,93,165,101,26,108,166,101,72,247,63,194,152,36,151,187,12,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess10EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess10 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("34d68da9-18a8-460b-a4cf-7306ba51754a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("83ace29f-882b-4d01-b931-9e4dc28e5adb"),
				CreatedInOwnerSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				CreatedInPackageId = new Guid("b477c174-1d53-4a21-b489-a41e481a96a0"),
				CreatedInSchemaUId = new Guid("5f6201ed-f63b-47de-bf2f-50f74571e281"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("5f6201ed-f63b-47de-bf2f-50f74571e281"),
				Name = @"EventSubProcess10",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(42, 14),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(812, 168),
				TriggeredByEvent = true,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess10;
		}

		protected virtual ProcessSchemaStartMessageEvent CreatePageLoadCompleteEmailTemplateStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("d233ee72-156e-4e47-96ca-27d0489df79e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("34d68da9-18a8-460b-a4cf-7306ba51754a"),
				CreatedInOwnerSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				CreatedInPackageId = new Guid("b477c174-1d53-4a21-b489-a41e481a96a0"),
				CreatedInSchemaUId = new Guid("5f6201ed-f63b-47de-bf2f-50f74571e281"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("5f6201ed-f63b-47de-bf2f-50f74571e281"),
				Name = @"PageLoadCompleteEmailTemplate",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(50, 65),
				SerializeToDB = false,
				Size = new Size(0, 0)
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaIntermediateThrowMessageEvent CreatePageLoadCompleteEmailTemplateParentIntermediateThrowMessageEvent() {
			ProcessSchemaIntermediateThrowMessageEvent schemaThrowMessageEvent = new ProcessSchemaIntermediateThrowMessageEvent(this) {
				UId = new Guid("010bc99d-dfab-4b42-aa47-2305918ac95e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("34d68da9-18a8-460b-a4cf-7306ba51754a"),
				CreatedInOwnerSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				CreatedInPackageId = new Guid("b477c174-1d53-4a21-b489-a41e481a96a0"),
				CreatedInSchemaUId = new Guid("5f6201ed-f63b-47de-bf2f-50f74571e281"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("7b8b16fb-d4c6-4e8b-a519-988250ac636f"),
				Message = @"PageLoadComplete",
				ModifiedInSchemaUId = new Guid("5f6201ed-f63b-47de-bf2f-50f74571e281"),
				Name = @"PageLoadCompleteEmailTemplateParent",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(372, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = true
			};
			
			return schemaThrowMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreatePageLoadCompleteScriptTaskEmailTemplateScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("5ccbcaba-70d2-4a8d-922a-03e9b6cafc4c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("34d68da9-18a8-460b-a4cf-7306ba51754a"),
				CreatedInOwnerSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				CreatedInPackageId = new Guid("b477c174-1d53-4a21-b489-a41e481a96a0"),
				CreatedInSchemaUId = new Guid("5f6201ed-f63b-47de-bf2f-50f74571e281"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("5f6201ed-f63b-47de-bf2f-50f74571e281"),
				Name = @"PageLoadCompleteScriptTaskEmailTemplate",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(540, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,165,88,89,115,219,54,16,126,86,102,242,31,88,118,166,166,90,133,145,211,105,218,52,169,83,93,110,149,198,177,43,57,237,131,199,15,16,9,219,104,121,40,0,104,71,77,245,223,187,11,128,36,72,66,62,154,204,196,146,128,189,119,241,237,2,11,122,201,132,164,252,120,245,23,141,228,17,205,138,185,164,233,82,18,73,151,17,103,107,25,244,95,62,126,180,48,84,239,72,74,151,133,34,93,208,132,72,150,103,14,170,37,185,166,35,49,138,36,187,102,114,243,54,191,100,145,69,117,200,146,4,245,156,112,150,115,216,87,139,199,60,166,156,198,83,22,161,76,194,55,94,74,34,158,139,73,158,36,84,173,121,63,121,25,189,241,58,132,138,157,93,120,193,92,188,163,55,125,239,211,227,71,189,107,194,61,17,93,209,148,116,5,212,156,175,132,228,44,187,28,120,185,114,232,64,73,82,188,81,158,73,18,201,165,18,1,124,239,5,229,147,60,203,180,160,112,150,73,176,91,239,30,145,140,92,82,30,254,66,229,60,19,146,100,17,29,111,48,76,129,63,209,82,252,74,236,154,112,154,201,121,140,219,150,167,29,187,126,41,88,60,240,180,117,150,85,84,124,48,180,182,1,191,23,20,130,112,183,133,3,207,159,165,132,37,167,52,93,67,230,232,145,138,175,54,14,36,135,144,142,20,148,43,113,16,180,34,205,194,185,24,37,55,100,35,150,20,67,8,186,37,47,104,73,63,138,99,77,22,248,232,79,45,200,218,56,81,14,251,253,80,101,109,188,25,137,40,216,119,17,234,207,19,34,175,220,114,114,193,208,175,166,164,103,46,210,210,189,90,14,212,27,212,164,64,162,0,150,212,218,132,83,160,129,138,41,146,68,239,7,254,40,138,242,34,147,147,60,77,139,140,69,170,184,79,55,107,144,4,92,117,18,84,100,27,85,133,2,33,253,179,214,78,43,39,74,2,214,105,91,66,56,65,181,222,129,55,212,197,107,149,138,118,234,15,146,20,20,99,108,116,45,242,220,148,102,168,9,4,248,152,197,101,217,85,65,111,113,163,254,222,69,14,158,71,87,65,237,138,199,178,142,83,198,16,99,137,188,66,197,138,4,253,196,152,196,150,236,87,101,161,118,178,216,107,84,253,237,66,176,230,15,2,167,219,150,44,105,178,123,79,131,154,197,208,235,61,253,90,125,96,22,52,77,168,75,224,152,207,210,53,32,17,250,218,247,190,250,170,182,249,139,159,60,180,44,84,251,101,88,122,136,15,44,211,103,161,215,219,170,191,95,63,173,100,215,30,59,185,221,48,160,234,211,56,101,206,162,229,211,192,107,110,77,153,0,207,108,10,227,98,175,141,155,14,185,93,230,129,130,149,55,35,206,9,0,170,17,181,245,104,34,104,105,53,134,63,51,69,120,143,208,215,152,96,120,181,93,6,192,222,232,118,19,52,141,174,142,40,252,83,84,39,60,95,83,14,137,49,139,61,63,34,107,5,4,3,175,92,66,155,204,247,190,254,124,176,208,148,74,162,170,182,150,122,75,121,188,54,200,172,179,234,253,216,236,22,24,21,253,77,135,229,200,200,30,111,240,175,22,241,153,230,150,135,192,31,148,75,229,138,91,112,208,46,137,51,119,5,86,203,231,231,30,17,166,26,250,202,32,45,161,111,213,59,254,193,255,71,221,54,221,86,135,92,115,209,38,156,92,145,236,146,198,86,87,57,217,213,30,221,230,34,203,219,156,196,127,48,46,11,146,76,137,36,203,188,224,17,93,228,55,162,227,179,178,125,73,101,57,117,168,114,5,208,31,191,120,126,56,26,62,123,242,253,225,236,249,147,233,225,254,254,147,23,223,239,143,159,12,135,251,211,231,195,217,139,111,127,152,60,135,50,126,250,244,93,206,83,146,60,126,100,29,10,172,106,130,67,14,106,4,51,231,160,110,189,129,250,56,129,126,27,214,246,132,104,208,217,240,28,74,165,189,51,42,217,95,246,140,64,109,247,120,35,41,158,149,74,60,150,149,90,52,118,219,221,27,217,98,10,205,134,145,132,253,67,227,183,48,132,1,239,27,1,135,127,90,175,191,194,245,87,117,252,160,95,241,205,193,129,170,171,229,6,230,182,52,60,165,31,37,204,14,81,30,99,125,191,63,61,252,65,149,179,42,247,192,178,172,234,136,118,59,97,32,1,155,73,219,20,131,123,78,92,66,158,240,55,186,25,40,238,176,6,178,237,195,147,139,200,219,81,162,123,43,224,240,183,86,115,213,243,158,125,74,27,161,190,165,183,106,216,50,184,86,139,82,205,173,145,171,29,253,173,171,185,221,165,219,162,39,26,240,238,148,95,2,175,67,67,23,238,107,69,170,32,155,179,127,88,171,108,152,176,147,254,87,22,199,20,201,47,8,28,13,69,54,41,56,30,217,99,203,24,21,163,50,92,187,136,204,148,211,209,251,0,164,209,87,1,60,137,38,227,247,129,158,173,57,70,156,70,108,205,192,168,59,15,224,162,164,172,207,96,197,236,58,124,101,126,238,115,210,154,86,232,118,172,2,95,41,157,197,76,134,203,66,172,105,22,143,254,34,31,103,215,176,40,130,157,148,84,106,179,65,135,169,6,245,91,212,170,118,106,89,80,81,164,180,173,68,223,146,214,155,197,189,3,54,177,169,125,183,144,207,13,92,215,34,203,173,134,1,119,6,208,65,189,51,136,13,181,183,106,220,29,204,85,2,48,51,121,80,68,199,29,22,255,22,113,159,27,219,29,6,90,238,118,237,185,51,202,187,88,118,134,186,107,197,221,6,184,131,142,56,241,69,3,40,236,80,85,231,66,35,85,43,144,141,132,43,138,174,106,32,235,26,107,99,141,104,188,146,0,249,206,225,192,9,248,171,60,79,96,206,110,190,181,248,149,107,77,233,198,67,11,189,15,25,77,226,121,86,18,168,64,205,50,178,74,104,80,53,96,232,208,210,73,109,146,225,68,249,170,4,133,122,53,40,141,190,119,139,244,157,26,45,199,218,98,93,87,180,106,52,171,94,65,254,247,43,142,101,65,175,215,150,221,156,30,42,113,173,217,225,253,60,238,152,221,105,191,174,132,148,231,96,148,197,120,54,131,166,218,16,228,14,90,166,148,205,251,94,226,113,58,59,225,20,199,235,170,25,42,23,157,44,42,131,109,55,202,82,233,76,214,247,74,117,201,50,143,253,126,120,154,27,164,81,39,26,132,170,113,216,12,25,147,132,69,127,255,74,178,56,161,92,191,37,162,49,250,30,118,136,163,185,196,57,246,103,255,211,112,27,70,133,144,121,122,228,224,196,25,165,200,244,235,76,255,147,170,148,79,251,219,80,148,112,131,63,46,203,31,125,239,27,111,239,236,203,61,248,144,87,76,132,250,22,130,98,195,252,38,131,98,49,119,81,36,11,43,42,107,241,203,243,61,125,148,182,234,166,166,146,1,71,74,79,35,167,112,124,199,133,148,56,163,38,8,13,243,105,69,100,94,88,85,142,202,205,199,143,80,150,222,86,254,151,37,11,18,205,227,234,238,88,33,171,14,22,36,80,46,40,137,143,179,100,115,87,28,45,210,96,15,139,3,220,241,76,188,28,27,207,220,27,181,239,77,84,238,120,221,5,238,14,201,14,128,127,64,140,58,238,35,135,245,126,236,253,251,175,103,55,5,117,216,197,26,101,150,8,61,50,63,225,138,124,74,225,138,44,242,11,9,71,49,252,147,174,240,197,151,231,137,8,145,0,83,111,88,195,137,42,73,196,246,51,63,163,52,6,131,166,84,18,150,44,232,7,64,82,233,159,91,227,51,148,190,198,38,47,22,85,15,184,173,63,0,15,30,40,111,221,121,54,2,46,176,34,64,127,180,200,46,94,190,246,26,187,63,218,74,29,15,81,86,37,217,19,123,219,54,131,131,230,221,177,110,7,227,60,46,31,188,245,171,114,251,149,20,204,13,203,183,92,36,86,175,175,225,33,207,211,160,86,168,214,254,188,162,28,240,89,97,199,92,204,62,192,53,49,48,32,120,66,56,80,225,171,110,55,36,54,206,244,49,137,218,142,218,47,106,191,146,27,123,237,23,31,160,44,4,18,6,211,241,236,35,141,10,153,195,253,123,85,125,117,52,26,81,112,58,29,215,75,160,90,85,151,145,51,199,192,97,89,2,66,241,26,101,81,119,168,197,82,189,27,212,106,140,132,222,205,21,75,168,23,240,56,68,146,82,112,175,231,242,194,60,122,246,121,124,166,99,123,254,210,122,202,217,86,17,88,105,114,53,46,46,203,97,49,232,72,196,163,163,67,57,46,88,130,198,139,85,153,91,123,89,13,20,98,21,142,214,56,7,190,101,25,100,45,176,112,216,119,236,171,199,94,211,113,160,37,67,42,175,33,189,22,147,199,46,130,27,64,3,40,210,201,111,179,233,252,244,120,1,174,123,112,185,203,193,66,200,125,208,223,122,219,129,247,221,112,8,24,228,208,80,202,106,176,56,109,137,18,74,120,101,131,196,222,237,53,233,130,38,130,250,165,69,33,51,195,132,56,219,3,68,221,59,71,132,196,100,7,254,64,31,25,140,99,3,195,250,77,193,43,19,231,150,73,110,151,182,238,213,126,208,247,239,6,198,85,171,1,115,42,11,158,233,161,224,63,81,75,225,176,37,28,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask3ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("c2a3ce58-ae9d-451a-a071-7d9bab71a6af"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("34d68da9-18a8-460b-a4cf-7306ba51754a"),
				CreatedInOwnerSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				CreatedInPackageId = new Guid("b477c174-1d53-4a21-b489-a41e481a96a0"),
				CreatedInSchemaUId = new Guid("5f6201ed-f63b-47de-bf2f-50f74571e281"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("5f6201ed-f63b-47de-bf2f-50f74571e281"),
				Name = @"ScriptTask3",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(176, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,142,65,10,131,48,16,69,215,10,222,33,184,210,77,46,32,93,20,145,34,180,208,106,119,165,139,96,166,18,208,196,38,19,139,148,222,189,81,41,186,145,66,32,195,31,230,189,47,30,36,202,77,170,186,33,38,239,192,247,12,106,33,107,242,180,160,135,114,158,119,228,204,106,160,5,184,208,32,189,44,43,122,85,243,16,197,137,187,21,142,181,58,164,169,146,200,132,52,81,168,161,82,154,231,60,140,103,139,55,10,51,137,2,135,156,59,129,132,23,57,88,193,163,45,211,109,65,220,87,214,73,251,9,124,247,70,249,190,66,209,51,4,158,245,32,49,107,160,117,159,89,245,24,241,71,197,120,170,218,174,1,132,18,153,198,19,24,227,242,95,183,13,72,1,173,234,225,31,34,153,186,104,64,171,37,65,109,193,5,95,14,116,37,149,99,1,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess11EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess11 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("2d976e3a-0e3f-4304-8309-7318054c1a80"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("99a02600-1c6d-4ef2-b770-d62335ce62ba"),
				CreatedInOwnerSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				CreatedInPackageId = new Guid("b477c174-1d53-4a21-b489-a41e481a96a0"),
				CreatedInSchemaUId = new Guid("5f6201ed-f63b-47de-bf2f-50f74571e281"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("5f6201ed-f63b-47de-bf2f-50f74571e281"),
				Name = @"EventSubProcess11",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(42, 14),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(812, 153),
				TriggeredByEvent = true,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess11;
		}

		protected virtual ProcessSchemaStartMessageEvent CreatePutTemplateToBodyButtonClickMarketingStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("63ac82de-4785-4425-8628-f28402849601"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("2d976e3a-0e3f-4304-8309-7318054c1a80"),
				CreatedInOwnerSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				CreatedInPackageId = new Guid("b477c174-1d53-4a21-b489-a41e481a96a0"),
				CreatedInSchemaUId = new Guid("5f6201ed-f63b-47de-bf2f-50f74571e281"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"PutTemplateToBodyButtonClick",
				ModifiedInSchemaUId = new Guid("5f6201ed-f63b-47de-bf2f-50f74571e281"),
				Name = @"PutTemplateToBodyButtonClickMarketingStartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(50, 67),
				SerializeToDB = false,
				Size = new Size(0, 0)
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreatePutTemplateToBodyButtonClickMarketingScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("2012328e-bdae-44da-9eb8-6c299b4a0085"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("2d976e3a-0e3f-4304-8309-7318054c1a80"),
				CreatedInOwnerSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				CreatedInPackageId = new Guid("b477c174-1d53-4a21-b489-a41e481a96a0"),
				CreatedInSchemaUId = new Guid("5f6201ed-f63b-47de-bf2f-50f74571e281"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("5f6201ed-f63b-47de-bf2f-50f74571e281"),
				Name = @"PutTemplateToBodyButtonClickMarketingScriptTask",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(176, 53),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,146,95,107,131,48,20,197,159,91,232,119,200,236,139,66,9,221,235,186,117,236,79,87,202,88,87,90,217,139,248,16,244,174,4,52,41,201,181,155,20,191,251,98,212,105,199,28,3,69,18,207,57,247,119,147,123,100,138,104,72,32,66,136,215,50,6,77,110,200,134,237,129,190,176,72,73,237,43,128,165,226,49,221,117,53,179,209,144,191,19,247,204,71,31,100,38,144,204,201,212,35,167,209,112,80,10,46,206,20,193,52,164,111,44,201,172,86,32,227,66,63,67,238,58,27,166,64,224,42,118,188,202,57,80,128,153,18,4,85,6,166,210,160,48,239,209,96,30,106,221,154,165,240,200,35,228,82,48,149,91,222,95,127,48,77,218,213,245,50,227,241,132,104,84,92,236,231,179,31,145,38,68,192,7,41,53,110,15,115,208,114,134,212,151,59,27,228,122,94,19,133,144,30,18,134,96,162,254,213,181,95,235,29,143,220,246,57,130,86,213,173,73,174,234,62,232,34,61,96,222,18,124,98,117,107,37,67,37,120,146,42,101,232,58,193,248,52,45,232,233,178,24,135,206,164,231,36,131,102,59,156,244,3,149,22,39,180,93,219,17,168,202,172,244,58,75,146,87,101,121,220,230,40,154,251,180,243,116,47,227,124,17,115,164,43,161,65,161,111,96,221,150,216,6,22,4,18,13,127,123,238,244,78,102,42,130,239,34,116,11,230,107,54,76,143,182,185,78,168,87,143,143,121,186,51,245,5,246,87,2,169,244,2,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateMacrosTreeGridDblClickMarketingStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("b3cc7049-21b0-4c8b-926e-f9144f48399d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("2d976e3a-0e3f-4304-8309-7318054c1a80"),
				CreatedInOwnerSchemaUId = new Guid("fb70424d-efdc-4263-8e0e-ca672bc0bc4b"),
				CreatedInPackageId = new Guid("b477c174-1d53-4a21-b489-a41e481a96a0"),
				CreatedInSchemaUId = new Guid("5f6201ed-f63b-47de-bf2f-50f74571e281"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"MacrosTreeGridDblClick",
				ModifiedInSchemaUId = new Guid("5f6201ed-f63b-47de-bf2f-50f74571e281"),
				Name = @"MacrosTreeGridDblClickMarketingStartMessage",
				OwnerSchemaManagerName = @"PageSchemaManager",
				Position = new Point(372, 67),
				SerializeToDB = false,
				Size = new Size(0, 0)
			};
			
			return schemaStartMessageEvent;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateInsertImageAsBase64Method());
			Methods.Add(CreateSetEntityBodyColumnValueMethod());
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("6f83ce94-cebc-400c-954c-bcb0fa73c690"),
				Name = "Terrasoft.UI.WebControls.Controls",
				Alias = "",
				CreatedInPackageId = new Guid("b477c174-1d53-4a21-b489-a41e481a96a0")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("ec535512-952e-4f67-b052-d83dd8cbca7f"),
				Name = "Terrasoft.Core.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("b477c174-1d53-4a21-b489-a41e481a96a0")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5375dee1-bc17-46f5-9908-be2eaf10ece0"),
				Name = "Terrasoft.UI.WebControls",
				Alias = "TSWebControls",
				CreatedInPackageId = new Guid("b477c174-1d53-4a21-b489-a41e481a96a0")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("6859a846-19bc-45e6-8ad5-b6c619db02aa"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("b477c174-1d53-4a21-b489-a41e481a96a0")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("8dee24f2-ec02-4125-a8b6-88b3d5ae47c2"),
				Name = "Terrasoft.Configuration",
				Alias = "TSConfiguration",
				CreatedInPackageId = new Guid("b477c174-1d53-4a21-b489-a41e481a96a0")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("4d5c769a-260c-4913-9dfd-5f7a68a5f440"),
				Name = "Terrasoft.Core.Store",
				Alias = "",
				CreatedInPackageId = new Guid("b477c174-1d53-4a21-b489-a41e481a96a0")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("f8edb689-e2d8-463d-a704-b7e060156d18"),
				Name = "Terrasoft.Core",
				Alias = "",
				CreatedInPackageId = new Guid("b477c174-1d53-4a21-b489-a41e481a96a0")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("9b5b0d1b-9b97-4589-af55-1c6fb98fe533"),
				Name = "System.Linq",
				Alias = "",
				CreatedInPackageId = new Guid("b477c174-1d53-4a21-b489-a41e481a96a0")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("2c218d10-9fee-44b9-9d01-ffd4b263a355"),
				Name = "System.Text",
				Alias = "",
				CreatedInPackageId = new Guid("b477c174-1d53-4a21-b489-a41e481a96a0")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5be5b08a-f619-4ffb-8cee-461181ee9377"),
				Name = "System.Collections.Specialized",
				Alias = "",
				CreatedInPackageId = new Guid("b477c174-1d53-4a21-b489-a41e481a96a0")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("145d22c5-8ae3-4f84-872d-ade4f79c7308"),
				Name = "System.Collections",
				Alias = "",
				CreatedInPackageId = new Guid("b477c174-1d53-4a21-b489-a41e481a96a0")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("ce40284b-c751-42d2-86e6-dde8bc60bae9"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("b477c174-1d53-4a21-b489-a41e481a96a0")
			});
		}

		protected override SchemaMethod CreateLoadVirtualDataSourceRowsMethod() {
			SchemaMethod method = base.CreateLoadVirtualDataSourceRowsMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,83,219,106,194,64,16,125,86,240,31,150,60,37,32,249,1,219,130,168,21,123,145,80,197,23,241,97,72,166,118,97,179,27,38,27,67,40,254,123,119,115,169,183,164,246,37,33,147,51,231,156,153,179,27,192,30,253,119,8,73,165,107,66,156,19,143,252,137,64,32,215,27,13,250,7,32,118,224,164,51,16,83,208,176,82,25,133,200,30,89,96,187,236,99,162,164,6,46,145,252,103,46,163,166,66,74,184,155,235,182,197,212,99,144,178,155,186,149,185,174,93,89,72,128,80,234,69,180,132,24,167,60,212,92,73,160,194,248,144,152,179,83,225,97,158,241,104,200,82,77,92,238,159,202,238,79,69,8,225,151,107,89,226,114,202,57,169,44,97,92,214,159,19,37,4,150,4,30,251,30,244,123,22,72,42,55,220,45,166,12,151,198,15,149,151,212,189,115,103,6,111,197,253,37,230,246,93,1,12,143,191,66,109,36,178,88,110,64,100,232,58,139,200,25,254,118,117,162,236,160,6,231,186,167,225,102,102,173,133,119,54,131,231,191,98,209,201,16,212,18,134,69,102,66,116,226,214,24,39,194,76,229,52,123,243,103,113,162,43,222,219,13,140,163,200,53,44,229,223,246,80,182,77,121,103,86,114,223,191,191,86,171,82,182,218,216,109,92,54,169,59,52,229,36,246,104,189,140,137,160,168,114,236,253,51,196,238,144,46,243,236,6,215,89,85,150,182,78,8,137,181,234,236,186,59,206,178,185,56,9,247,2,106,36,116,83,170,53,254,206,233,56,232,31,219,174,216,155,130,200,172,33,45,247,16,116,221,176,246,148,71,63,144,116,185,52,55,4,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateInsertImageAsBase64Method() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("0b5a7432-6905-4233-8968-cf06c1b31d06"),
				Name = "InsertImageAsBase64",
				CreatedInSchemaUId = new Guid("5f6201ed-f63b-47de-bf2f-50f74571e281"),
				CreatedInPackageId = new Guid("b477c174-1d53-4a21-b489-a41e481a96a0"),
				ResultValueTypeName = "bool"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,83,75,143,211,48,16,62,83,169,255,193,228,18,71,4,83,36,196,129,168,135,118,183,69,21,8,170,205,222,118,43,228,198,211,174,217,188,176,39,187,148,170,255,157,113,146,54,77,217,3,151,40,158,153,239,49,51,182,69,163,243,45,219,232,20,230,26,82,245,77,102,192,198,108,41,183,32,166,133,218,205,148,70,113,149,106,200,113,113,205,222,48,239,71,90,72,5,106,145,81,197,91,7,243,162,225,64,111,24,127,93,99,110,224,87,5,22,197,156,50,86,76,210,244,11,236,172,184,42,114,148,58,183,188,167,19,4,108,63,28,188,50,128,149,201,217,70,166,22,136,235,48,28,216,206,212,185,159,30,247,93,143,106,85,7,221,31,49,12,7,241,206,34,100,98,241,93,196,104,64,102,53,149,51,65,109,252,23,219,34,47,43,108,176,68,120,134,22,203,194,106,212,69,78,52,35,215,57,17,58,134,88,255,113,62,57,157,131,243,242,175,144,111,241,129,10,215,59,132,187,85,109,228,90,162,164,218,28,158,89,29,253,183,126,117,33,122,3,82,241,35,52,100,163,240,196,211,2,130,186,237,118,110,58,219,206,126,19,206,54,54,187,97,44,37,62,136,207,128,167,44,63,142,216,225,47,96,231,71,50,80,166,50,1,238,9,47,100,141,140,152,101,37,238,28,176,147,141,77,210,9,146,249,39,48,40,110,139,169,180,240,241,67,92,151,157,218,232,35,201,26,130,113,186,222,189,167,40,253,73,187,27,246,110,255,254,16,173,107,120,184,31,29,238,61,175,67,253,172,239,160,211,107,252,204,11,147,73,228,29,89,216,90,10,123,189,52,163,106,48,211,74,167,10,12,179,235,118,31,189,48,175,45,174,197,164,44,33,87,220,227,155,42,79,220,238,121,176,127,146,134,37,143,48,246,250,53,47,191,155,11,30,145,60,186,116,97,34,199,66,222,198,196,36,84,145,84,153,91,118,66,183,14,97,150,130,59,113,159,242,126,16,209,87,88,192,9,146,193,117,133,192,125,153,162,31,250,47,166,172,73,252,240,194,89,51,173,11,39,65,228,148,233,97,210,158,142,130,68,23,68,135,128,154,175,25,234,142,38,74,197,137,209,37,114,2,223,22,237,38,131,102,148,237,251,69,83,65,244,23,64,212,12,53,79,4,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSetEntityBodyColumnValueMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("ab716886-e756-4aa3-aed1-fa1d950c0530"),
				Name = "SetEntityBodyColumnValue",
				CreatedInSchemaUId = new Guid("5f6201ed-f63b-47de-bf2f-50f74571e281"),
				CreatedInPackageId = new Guid("b477c174-1d53-4a21-b489-a41e481a96a0"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("cff9778f-ccbe-460e-848b-13752c75053f"),
				Name = "entity",
				CreatedInSchemaUId = new Guid("5f6201ed-f63b-47de-bf2f-50f74571e281"),
				ModifiedInSchemaUId = new Guid("5f6201ed-f63b-47de-bf2f-50f74571e281"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Entity",
				CreatedInPackageId = new Guid("b477c174-1d53-4a21-b489-a41e481a96a0")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,101,142,65,10,131,48,16,69,215,21,188,67,200,42,1,201,5,164,155,138,11,55,69,176,182,235,169,25,170,96,18,27,19,171,183,111,108,75,17,220,13,243,223,159,121,19,88,114,55,114,33,71,82,194,3,197,41,204,185,236,156,184,224,236,210,56,154,66,62,54,45,42,56,131,194,64,161,118,157,91,68,245,223,253,160,193,118,10,236,146,153,222,43,125,133,222,111,224,114,151,133,18,211,248,34,245,32,193,33,171,71,180,153,209,26,27,215,25,157,108,62,242,56,58,136,10,29,163,171,25,77,200,247,136,40,193,134,212,161,101,171,61,255,96,183,22,45,50,90,72,202,69,49,230,79,15,61,219,225,123,79,206,185,200,103,108,124,16,225,233,27,153,179,199,198,17,1,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new EmailTemplateEditPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5f6201ed-f63b-47de-bf2f-50f74571e281"));
		}

		#endregion

	}

	#endregion

}

