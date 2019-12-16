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

	#region Class: CaseStatusEditPageSchema

	/// <exclude/>
	public class CaseStatusEditPageSchema : Terrasoft.WebApp.BaseLookupEditPageSchema
	{

		#region Properties: Public

		private Terrasoft.UI.WebControls.Controls.CheckBox _isFinalCheckBox;
		public Terrasoft.UI.WebControls.Controls.CheckBox IsFinalCheckBox {
			get {
				return _isFinalCheckBox;
			}
		}

		#endregion

		#region Constructors: Public

		public CaseStatusEditPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public CaseStatusEditPageSchema(CaseStatusEditPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateNameEdit() {
			NameEdit.Image = new ControlImage {};
			NameEdit.ColumnUId = new Guid("90215b49-0ec9-487b-9b98-ef4867f9aa69");
			NameEdit.ModifiedInSchemaUId = new Guid("72b3c5a9-cb4c-48e0-b207-3c4d095dbec7");
		}

		private void UpdateDescriptionEdit() {
			DescriptionEdit.ColumnUId = new Guid("a015cae2-d958-4096-b91e-4fb5a356a238");
			DescriptionEdit.ModifiedInSchemaUId = new Guid("72b3c5a9-cb4c-48e0-b207-3c4d095dbec7");
		}

		private void UpdateCustomControls() {
			CustomControls.Image = new ControlImage {};
			CustomControls.ModifiedInSchemaUId = new Guid("72b3c5a9-cb4c-48e0-b207-3c4d095dbec7");
		}

		private void UpdateMainControlLayout() {
			MainControlLayout.Image = new ControlImage {};
			MainControlLayout.ModifiedInSchemaUId = new Guid("72b3c5a9-cb4c-48e0-b207-3c4d095dbec7");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("72b3c5a9-cb4c-48e0-b207-3c4d095dbec7");
		}

		private void UpdateDesignerModeButton() {
			DesignerModeButton.AjaxEvents.Click.IsProcessEventHandler = true;
			DesignerModeButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("a5bcc8d7-215f-41c5-8f3c-f96f57d48c34"),
				ImageHash = @"682ad9264105b2170afb821fabf80415"
			};
			DesignerModeButton.ModifiedInSchemaUId = new Guid("72b3c5a9-cb4c-48e0-b207-3c4d095dbec7");
		}

		private void UpdateOKButton() {
			OKButton.AjaxEvents.Click.IsProcessEventHandler = true;
			OKButton.Image = new ControlImage {};
			OKButton.ModifiedInSchemaUId = new Guid("72b3c5a9-cb4c-48e0-b207-3c4d095dbec7");
		}

		private void UpdateCancelButton() {
			CancelButton.AjaxEvents.Click.IsProcessEventHandler = true;
			CancelButton.Image = new ControlImage {};
			CancelButton.ModifiedInSchemaUId = new Guid("72b3c5a9-cb4c-48e0-b207-3c4d095dbec7");
		}

		private void UpdateApplyChangesButton() {
			ApplyChangesButton.AjaxEvents.Click.IsProcessEventHandler = true;
			ApplyChangesButton.Image = new ControlImage {};
			ApplyChangesButton.ModifiedInSchemaUId = new Guid("72b3c5a9-cb4c-48e0-b207-3c4d095dbec7");
		}

		private void UpdateButtonsControlLayout() {
			ButtonsControlLayout.Image = new ControlImage {};
			ButtonsControlLayout.ModifiedInSchemaUId = new Guid("72b3c5a9-cb4c-48e0-b207-3c4d095dbec7");
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("72b3c5a9-cb4c-48e0-b207-3c4d095dbec7");
			RealUId = new Guid("72b3c5a9-cb4c-48e0-b207-3c4d095dbec7");
			Name = "CaseStatusEditPage";
			ParentSchemaUId = new Guid("8c1db28c-4687-4b3b-b696-c32413d5825e");
			CreatedInPackageId = new Guid("305fcfca-4160-4398-90a9-d5e84be0ae12");
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateCaseStatusEditPageEventsProcessSchema();
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
			MainControlLayout.MoveItem(1, DescriptionEdit);
			MainControlLayout.InsertItem(2, CreateIsFinalCheckBox());
			MainControlLayout.MoveItem(3, CustomControls);
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

		protected virtual EmbeddedProcessSchema CreateCaseStatusEditPageEventsProcessSchema() {
			var schema = new CaseStatusEditPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.CheckBox CreateIsFinalCheckBox() {
			_isFinalCheckBox = new Terrasoft.UI.WebControls.Controls.CheckBox();
			_isFinalCheckBox.UId = new Guid("79753e6e-9f8b-4600-bc28-d5d200c0a6fd");
			_isFinalCheckBox.Name = "IsFinalCheckBox";
			_isFinalCheckBox.CreatedInSchemaUId = new Guid("72b3c5a9-cb4c-48e0-b207-3c4d095dbec7");
			_isFinalCheckBox.ModifiedInSchemaUId = new Guid("72b3c5a9-cb4c-48e0-b207-3c4d095dbec7");
			_isFinalCheckBox.CreatedInPackageId = new Guid("305fcfca-4160-4398-90a9-d5e84be0ae12");
			_isFinalCheckBox.Tag = "";
			_isFinalCheckBox.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_isFinalCheckBox.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_isFinalCheckBox.CaptionPosition = Terrasoft.UI.WebControls.Controls.CheckBoxBaseCaptionPosition.Left;
			_isFinalCheckBox.DataSource = "DataSource";
			_isFinalCheckBox.ColumnUId = new Guid("3fc0633d-9498-4e5e-889e-0391c499dbd8");
			return _isFinalCheckBox;
		}

		protected override void UpdateDataSource() {
			base.UpdateDataSource();
			DataSource.SchemaUId = new Guid("99f35013-6b7a-47d6-b440-e3f1a0ba991c");
			DataSource.ModifiedInSchemaUId = new Guid("72b3c5a9-cb4c-48e0-b207-3c4d095dbec7");
			DataSourceStructureColumn column = null;
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ae0e45ca-c495-4fe7-a39d-3ab7278e1617");
			if (column != null) {
				column.UId = new Guid("bdefaacd-043e-4dae-863b-06fa7989e64c");
				column.Name = @"Id";
				column.CreatedInSchemaUId = new Guid("72b3c5a9-cb4c-48e0-b207-3c4d095dbec7");
				column.ModifiedInSchemaUId = new Guid("72b3c5a9-cb4c-48e0-b207-3c4d095dbec7");
				column.CreatedInPackageId = Guid.Empty;
				column.IsAlwaysSelect = true;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("e80190a5-03b2-4095-90f7-a193a960adee");
			if (column != null) {
				column.UId = new Guid("9bf5416b-d8cb-4e4b-a28c-966b86d15a71");
				column.Name = @"CreatedOn";
				column.CreatedInSchemaUId = new Guid("72b3c5a9-cb4c-48e0-b207-3c4d095dbec7");
				column.ModifiedInSchemaUId = new Guid("72b3c5a9-cb4c-48e0-b207-3c4d095dbec7");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ebf6bb93-8aa6-4a01-900d-c6ea67affe21");
			if (column != null) {
				column.UId = new Guid("f86ee8a4-d2a1-4018-ad6f-9f8a502d6260");
				column.Name = @"CreatedBy";
				column.CreatedInSchemaUId = new Guid("72b3c5a9-cb4c-48e0-b207-3c4d095dbec7");
				column.ModifiedInSchemaUId = new Guid("72b3c5a9-cb4c-48e0-b207-3c4d095dbec7");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9928edec-4272-425a-93bb-48743fee4b04");
			if (column != null) {
				column.UId = new Guid("b3b9c499-123e-446d-8918-a66dac465583");
				column.Name = @"ModifiedOn";
				column.CreatedInSchemaUId = new Guid("72b3c5a9-cb4c-48e0-b207-3c4d095dbec7");
				column.ModifiedInSchemaUId = new Guid("72b3c5a9-cb4c-48e0-b207-3c4d095dbec7");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3015559e-cbc6-406a-88af-07f7930be832");
			if (column != null) {
				column.UId = new Guid("aa859d02-e596-4f9a-bb5a-c49a9093409f");
				column.Name = @"ModifiedBy";
				column.CreatedInSchemaUId = new Guid("72b3c5a9-cb4c-48e0-b207-3c4d095dbec7");
				column.ModifiedInSchemaUId = new Guid("72b3c5a9-cb4c-48e0-b207-3c4d095dbec7");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("736c30a7-c0ec-4fa9-b034-2552b319b633");
			if (column != null) {
				column.UId = new Guid("90215b49-0ec9-487b-9b98-ef4867f9aa69");
				column.Name = @"Name";
				column.CreatedInSchemaUId = new Guid("72b3c5a9-cb4c-48e0-b207-3c4d095dbec7");
				column.ModifiedInSchemaUId = new Guid("72b3c5a9-cb4c-48e0-b207-3c4d095dbec7");
				column.CreatedInPackageId = Guid.Empty;
				column.OrderDirection = OrderDirection.Ascending;
				column.OrderPosition = 1;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9e53fd7c-dde4-4502-a64c-b9e34148108b");
			if (column != null) {
				column.UId = new Guid("a015cae2-d958-4096-b91e-4fb5a356a238");
				column.Name = @"Description";
				column.CreatedInSchemaUId = new Guid("72b3c5a9-cb4c-48e0-b207-3c4d095dbec7");
				column.ModifiedInSchemaUId = new Guid("72b3c5a9-cb4c-48e0-b207-3c4d095dbec7");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3fabd836-6a53-4d8d-9069-6df88d9dae1e");
			if (column != null) {
				column.UId = new Guid("77caca39-b946-4034-a916-041e4f35542e");
				column.Name = @"ProcessListeners";
				column.CreatedInSchemaUId = new Guid("72b3c5a9-cb4c-48e0-b207-3c4d095dbec7");
				column.ModifiedInSchemaUId = new Guid("72b3c5a9-cb4c-48e0-b207-3c4d095dbec7");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("b78647f6-76db-4d25-b665-00fce475324e");
			if (column != null) {
				column.UId = new Guid("3fc0633d-9498-4e5e-889e-0391c499dbd8");
				column.Name = @"IsFinal";
				column.CreatedInSchemaUId = new Guid("72b3c5a9-cb4c-48e0-b207-3c4d095dbec7");
				column.ModifiedInSchemaUId = new Guid("72b3c5a9-cb4c-48e0-b207-3c4d095dbec7");
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
			return new CaseStatusEditPageSchemaUserControl();
		}

		public override object Clone() {
			return new CaseStatusEditPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("72b3c5a9-cb4c-48e0-b207-3c4d095dbec7"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new CaseStatusEditPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: CaseStatusEditPageEventsProcess

	/// <exclude/>
	public class CaseStatusEditPageEventsProcess<TPage> : Terrasoft.WebApp.BaseLookupEditPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.CaseStatusEditPageSchemaUserControl
	{

		public CaseStatusEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "CaseStatusEditPageEventsProcess";
			SchemaUId = new Guid("72b3c5a9-cb4c-48e0-b207-3c4d095dbec7");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("72b3c5a9-cb4c-48e0-b207-3c4d095dbec7");
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

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
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

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
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

	#region Class: CaseStatusEditPageEventsProcess

	/// <exclude/>
	public class CaseStatusEditPageEventsProcess : CaseStatusEditPageEventsProcess<Terrasoft.WebApp.CaseStatusEditPageSchemaUserControl>
	{

		public CaseStatusEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: CaseStatusEditPageSchemaUserControl

	/// <exclude/>
	public partial class CaseStatusEditPageSchemaUserControl : Terrasoft.WebApp.BaseLookupEditPageSchemaUserControl
	{

		#region Properties: Public

		public Terrasoft.UI.WebControls.Controls.CheckBox IsFinalCheckBox {
			get {
				return (Terrasoft.UI.WebControls.Controls.CheckBox)PageContainer.FindPageControl("IsFinalCheckBox", true);
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
			var process = (CaseStatusEditPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new CaseStatusEditPageEventsProcess(UserConnection);
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
			SchemaName = "CaseStatusEditPage";
		}

		#endregion

	}

	#endregion

	#region Class: CaseStatusEditPageEventsProcessSchema

	/// <exclude/>
	public class CaseStatusEditPageEventsProcessSchema : Terrasoft.WebApp.BaseLookupEditPageEventsProcessSchema
	{

		#region Constructors: Public

		public CaseStatusEditPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public CaseStatusEditPageEventsProcessSchema(CaseStatusEditPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "CaseStatusEditPageEventsProcess";
			UId = new Guid("c57bb336-39ac-44cc-82a3-b0249683cd3e");
			CreatedInPackageId = new Guid("305fcfca-4160-4398-90a9-d5e84be0ae12");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsActiveVersion = false;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("a9025da9-8220-4758-a93e-a034578ef23b");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
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
				CreatedInPackageId = new Guid("305fcfca-4160-4398-90a9-d5e84be0ae12")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("0da240a7-6b5c-4da2-ab4b-e82287d805bd"),
				Name = "Terrasoft.Configuration",
				Alias = "TSConfiguration",
				CreatedInPackageId = new Guid("305fcfca-4160-4398-90a9-d5e84be0ae12")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("2f50a15b-41f7-4f3a-bd8f-0eb6fecaf008"),
				Name = "Terrasoft.Web.Common",
				Alias = "",
				CreatedInPackageId = new Guid("305fcfca-4160-4398-90a9-d5e84be0ae12")
			});
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new CaseStatusEditPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c57bb336-39ac-44cc-82a3-b0249683cd3e"));
		}

		#endregion

	}

	#endregion

}

