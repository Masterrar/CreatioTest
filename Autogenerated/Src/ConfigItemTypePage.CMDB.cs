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

	#region Class: ConfigItemTypePageSchema

	/// <exclude/>
	public class ConfigItemTypePageSchema : Terrasoft.WebApp.BaseLookupEditPageSchema
	{

		#region Properties: Public

		private Terrasoft.UI.WebControls.Controls.LookupEdit _configItemCategoryEdit;
		public Terrasoft.UI.WebControls.Controls.LookupEdit ConfigItemCategoryEdit {
			get {
				return _configItemCategoryEdit;
			}
		}

		#endregion

		#region Constructors: Public

		public ConfigItemTypePageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public ConfigItemTypePageSchema(ConfigItemTypePageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateNameEdit() {
			NameEdit.Image = new ControlImage {};
			NameEdit.ColumnUId = new Guid("d7e5536b-de09-4ddd-977a-774c79e27bdb");
			NameEdit.ModifiedInSchemaUId = new Guid("a27ff05f-04e8-4032-9c4b-1ebf43fa287a");
		}

		private void UpdateDescriptionEdit() {
			DescriptionEdit.ColumnUId = new Guid("5bb52f5c-5095-4a8c-b9a5-f910efcb6ab9");
			DescriptionEdit.ModifiedInSchemaUId = new Guid("a27ff05f-04e8-4032-9c4b-1ebf43fa287a");
		}

		private void UpdateCustomControls() {
			CustomControls.Image = new ControlImage {};
			CustomControls.ModifiedInSchemaUId = new Guid("a27ff05f-04e8-4032-9c4b-1ebf43fa287a");
		}

		private void UpdateMainControlLayout() {
			MainControlLayout.Image = new ControlImage {};
			MainControlLayout.ModifiedInSchemaUId = new Guid("a27ff05f-04e8-4032-9c4b-1ebf43fa287a");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("a27ff05f-04e8-4032-9c4b-1ebf43fa287a");
		}

		private void UpdateDesignerModeButton() {
			DesignerModeButton.AjaxEvents.Click.IsProcessEventHandler = true;
			DesignerModeButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("a5bcc8d7-215f-41c5-8f3c-f96f57d48c34"),
				ImageHash = @"682ad9264105b2170afb821fabf80415"
			};
			DesignerModeButton.ModifiedInSchemaUId = new Guid("a27ff05f-04e8-4032-9c4b-1ebf43fa287a");
		}

		private void UpdateOKButton() {
			OKButton.AjaxEvents.Click.IsProcessEventHandler = true;
			OKButton.Image = new ControlImage {};
			OKButton.ModifiedInSchemaUId = new Guid("a27ff05f-04e8-4032-9c4b-1ebf43fa287a");
		}

		private void UpdateCancelButton() {
			CancelButton.AjaxEvents.Click.IsProcessEventHandler = true;
			CancelButton.Image = new ControlImage {};
			CancelButton.ModifiedInSchemaUId = new Guid("a27ff05f-04e8-4032-9c4b-1ebf43fa287a");
		}

		private void UpdateApplyChangesButton() {
			ApplyChangesButton.AjaxEvents.Click.IsProcessEventHandler = true;
			ApplyChangesButton.Image = new ControlImage {};
			ApplyChangesButton.ModifiedInSchemaUId = new Guid("a27ff05f-04e8-4032-9c4b-1ebf43fa287a");
		}

		private void UpdateButtonsControlLayout() {
			ButtonsControlLayout.Image = new ControlImage {};
			ButtonsControlLayout.ModifiedInSchemaUId = new Guid("a27ff05f-04e8-4032-9c4b-1ebf43fa287a");
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("a27ff05f-04e8-4032-9c4b-1ebf43fa287a");
			RealUId = new Guid("a27ff05f-04e8-4032-9c4b-1ebf43fa287a");
			Name = "ConfigItemTypePage";
			ParentSchemaUId = new Guid("8c1db28c-4687-4b3b-b696-c32413d5825e");
			CreatedInPackageId = new Guid("3bc94b8f-9e47-4d1d-84d1-651293d36a8b");
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateConfigItemTypePageEventsProcessSchema();
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
			MainControlLayout.InsertItem(2, CreateConfigItemCategoryEdit());
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

		protected virtual EmbeddedProcessSchema CreateConfigItemTypePageEventsProcessSchema() {
			var schema = new ConfigItemTypePageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.LookupEdit CreateConfigItemCategoryEdit() {
			_configItemCategoryEdit = new Terrasoft.UI.WebControls.Controls.LookupEdit();
			_configItemCategoryEdit.UId = new Guid("882cac2a-fbbf-419a-a8be-53e4b9eacf68");
			_configItemCategoryEdit.Name = "ConfigItemCategoryEdit";
			_configItemCategoryEdit.CreatedInSchemaUId = new Guid("a27ff05f-04e8-4032-9c4b-1ebf43fa287a");
			_configItemCategoryEdit.ModifiedInSchemaUId = new Guid("a27ff05f-04e8-4032-9c4b-1ebf43fa287a");
			_configItemCategoryEdit.CreatedInPackageId = new Guid("3bc94b8f-9e47-4d1d-84d1-651293d36a8b");
			_configItemCategoryEdit.Tag = "";
			_configItemCategoryEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_configItemCategoryEdit.Image = new ControlImage {};
			_configItemCategoryEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_configItemCategoryEdit.DataSource = "DataSource";
			_configItemCategoryEdit.ColumnUId = new Guid("06ed71f1-5c73-4c52-9664-f22ffc7119fd");
			_configItemCategoryEdit.Required = true;
			return _configItemCategoryEdit;
		}

		protected override void UpdateDataSource() {
			base.UpdateDataSource();
			DataSource.SchemaUId = new Guid("da6e81b8-7237-4bb1-b5b1-b1e80977025e");
			DataSource.ModifiedInSchemaUId = new Guid("a27ff05f-04e8-4032-9c4b-1ebf43fa287a");
			DataSourceStructureColumn column = null;
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ae0e45ca-c495-4fe7-a39d-3ab7278e1617");
			if (column != null) {
				column.UId = new Guid("c56149f7-3164-4a8c-9ef8-f93fd0cef043");
				column.Name = @"Id";
				column.CreatedInSchemaUId = new Guid("a27ff05f-04e8-4032-9c4b-1ebf43fa287a");
				column.ModifiedInSchemaUId = new Guid("a27ff05f-04e8-4032-9c4b-1ebf43fa287a");
				column.CreatedInPackageId = Guid.Empty;
				column.IsAlwaysSelect = true;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("e80190a5-03b2-4095-90f7-a193a960adee");
			if (column != null) {
				column.UId = new Guid("1fa3da96-32f7-4caf-8247-f6e35d5e994d");
				column.Name = @"CreatedOn";
				column.CreatedInSchemaUId = new Guid("a27ff05f-04e8-4032-9c4b-1ebf43fa287a");
				column.ModifiedInSchemaUId = new Guid("a27ff05f-04e8-4032-9c4b-1ebf43fa287a");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ebf6bb93-8aa6-4a01-900d-c6ea67affe21");
			if (column != null) {
				column.UId = new Guid("53f3e205-ac75-498c-86a1-25d50b4d51c8");
				column.Name = @"CreatedBy";
				column.CreatedInSchemaUId = new Guid("a27ff05f-04e8-4032-9c4b-1ebf43fa287a");
				column.ModifiedInSchemaUId = new Guid("a27ff05f-04e8-4032-9c4b-1ebf43fa287a");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9928edec-4272-425a-93bb-48743fee4b04");
			if (column != null) {
				column.UId = new Guid("bfa2afe1-a5a6-488c-bd85-f06c1adfca80");
				column.Name = @"ModifiedOn";
				column.CreatedInSchemaUId = new Guid("a27ff05f-04e8-4032-9c4b-1ebf43fa287a");
				column.ModifiedInSchemaUId = new Guid("a27ff05f-04e8-4032-9c4b-1ebf43fa287a");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3015559e-cbc6-406a-88af-07f7930be832");
			if (column != null) {
				column.UId = new Guid("bce448fd-016f-4698-adbd-9755c1a449b0");
				column.Name = @"ModifiedBy";
				column.CreatedInSchemaUId = new Guid("a27ff05f-04e8-4032-9c4b-1ebf43fa287a");
				column.ModifiedInSchemaUId = new Guid("a27ff05f-04e8-4032-9c4b-1ebf43fa287a");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("736c30a7-c0ec-4fa9-b034-2552b319b633");
			if (column != null) {
				column.UId = new Guid("d7e5536b-de09-4ddd-977a-774c79e27bdb");
				column.Name = @"Name";
				column.CreatedInSchemaUId = new Guid("a27ff05f-04e8-4032-9c4b-1ebf43fa287a");
				column.ModifiedInSchemaUId = new Guid("a27ff05f-04e8-4032-9c4b-1ebf43fa287a");
				column.CreatedInPackageId = Guid.Empty;
				column.OrderDirection = OrderDirection.Ascending;
				column.OrderPosition = 1;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9e53fd7c-dde4-4502-a64c-b9e34148108b");
			if (column != null) {
				column.UId = new Guid("5bb52f5c-5095-4a8c-b9a5-f910efcb6ab9");
				column.Name = @"Description";
				column.CreatedInSchemaUId = new Guid("a27ff05f-04e8-4032-9c4b-1ebf43fa287a");
				column.ModifiedInSchemaUId = new Guid("a27ff05f-04e8-4032-9c4b-1ebf43fa287a");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3fabd836-6a53-4d8d-9069-6df88d9dae1e");
			if (column != null) {
				column.UId = new Guid("3276d7fb-e604-431b-9d1f-e4e6ccabd940");
				column.Name = @"ProcessListeners";
				column.CreatedInSchemaUId = new Guid("a27ff05f-04e8-4032-9c4b-1ebf43fa287a");
				column.ModifiedInSchemaUId = new Guid("a27ff05f-04e8-4032-9c4b-1ebf43fa287a");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("b2e80537-a48f-40af-90bf-915bcfb0ecbc");
			if (column != null) {
				column.UId = new Guid("06ed71f1-5c73-4c52-9664-f22ffc7119fd");
				column.Name = @"ConfItemCategory";
				column.CreatedInSchemaUId = new Guid("a27ff05f-04e8-4032-9c4b-1ebf43fa287a");
				column.ModifiedInSchemaUId = new Guid("a27ff05f-04e8-4032-9c4b-1ebf43fa287a");
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
			return new ConfigItemTypePageSchemaUserControl();
		}

		public override object Clone() {
			return new ConfigItemTypePageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a27ff05f-04e8-4032-9c4b-1ebf43fa287a"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new ConfigItemTypePageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: ConfigItemTypePageEventsProcess

	/// <exclude/>
	public class ConfigItemTypePageEventsProcess<TPage> : Terrasoft.WebApp.BaseLookupEditPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.ConfigItemTypePageSchemaUserControl
	{

		public ConfigItemTypePageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ConfigItemTypePageEventsProcess";
			SchemaUId = new Guid("a27ff05f-04e8-4032-9c4b-1ebf43fa287a");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("a27ff05f-04e8-4032-9c4b-1ebf43fa287a");
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

	#region Class: ConfigItemTypePageEventsProcess

	/// <exclude/>
	public class ConfigItemTypePageEventsProcess : ConfigItemTypePageEventsProcess<Terrasoft.WebApp.ConfigItemTypePageSchemaUserControl>
	{

		public ConfigItemTypePageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: ConfigItemTypePageSchemaUserControl

	/// <exclude/>
	public partial class ConfigItemTypePageSchemaUserControl : Terrasoft.WebApp.BaseLookupEditPageSchemaUserControl
	{

		#region Properties: Public

		public Terrasoft.UI.WebControls.Controls.LookupEdit ConfigItemCategoryEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.LookupEdit)PageContainer.FindPageControl("ConfigItemCategoryEdit", true);
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
			var process = (ConfigItemTypePageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new ConfigItemTypePageEventsProcess(UserConnection);
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
			SchemaName = "ConfigItemTypePage";
		}

		#endregion

	}

	#endregion

	#region Class: ConfigItemTypePageEventsProcessSchema

	/// <exclude/>
	public class ConfigItemTypePageEventsProcessSchema : Terrasoft.WebApp.BaseLookupEditPageEventsProcessSchema
	{

		#region Constructors: Public

		public ConfigItemTypePageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public ConfigItemTypePageEventsProcessSchema(ConfigItemTypePageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "ConfigItemTypePageEventsProcess";
			UId = new Guid("7922e956-693d-42a6-93f0-0579c814e568");
			CreatedInPackageId = new Guid("3bc94b8f-9e47-4d1d-84d1-651293d36a8b");
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
				CreatedInPackageId = new Guid("3bc94b8f-9e47-4d1d-84d1-651293d36a8b")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("0da240a7-6b5c-4da2-ab4b-e82287d805bd"),
				Name = "Terrasoft.Configuration",
				Alias = "TSConfiguration",
				CreatedInPackageId = new Guid("3bc94b8f-9e47-4d1d-84d1-651293d36a8b")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("2f50a15b-41f7-4f3a-bd8f-0eb6fecaf008"),
				Name = "Terrasoft.Web.Common",
				Alias = "",
				CreatedInPackageId = new Guid("3bc94b8f-9e47-4d1d-84d1-651293d36a8b")
			});
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new ConfigItemTypePageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("7922e956-693d-42a6-93f0-0579c814e568"));
		}

		#endregion

	}

	#endregion

}

