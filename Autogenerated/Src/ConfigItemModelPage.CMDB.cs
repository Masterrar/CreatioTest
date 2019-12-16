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

	#region Class: ConfigItemModelPageSchema

	/// <exclude/>
	public class ConfigItemModelPageSchema : Terrasoft.WebApp.BaseLookupEditPageSchema
	{

		#region Properties: Public

		private Terrasoft.UI.WebControls.Controls.LookupEdit _configItemTypeEdit;
		public Terrasoft.UI.WebControls.Controls.LookupEdit ConfigItemTypeEdit {
			get {
				return _configItemTypeEdit;
			}
		}

		#endregion

		#region Constructors: Public

		public ConfigItemModelPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public ConfigItemModelPageSchema(ConfigItemModelPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateNameEdit() {
			NameEdit.Image = new ControlImage {};
			NameEdit.ColumnUId = new Guid("43a41770-428d-4f3b-9793-c7029abe0455");
			NameEdit.ModifiedInSchemaUId = new Guid("8ee64f30-ced9-46d4-a6d4-cbd8b4e66b3c");
		}

		private void UpdateDescriptionEdit() {
			DescriptionEdit.ColumnUId = new Guid("26411608-3037-43ea-8c6e-4e6d916a4f9c");
			DescriptionEdit.ModifiedInSchemaUId = new Guid("8ee64f30-ced9-46d4-a6d4-cbd8b4e66b3c");
		}

		private void UpdateCustomControls() {
			CustomControls.Image = new ControlImage {};
			CustomControls.ModifiedInSchemaUId = new Guid("8ee64f30-ced9-46d4-a6d4-cbd8b4e66b3c");
		}

		private void UpdateMainControlLayout() {
			MainControlLayout.Image = new ControlImage {};
			MainControlLayout.ModifiedInSchemaUId = new Guid("8ee64f30-ced9-46d4-a6d4-cbd8b4e66b3c");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("8ee64f30-ced9-46d4-a6d4-cbd8b4e66b3c");
		}

		private void UpdateDesignerModeButton() {
			DesignerModeButton.AjaxEvents.Click.IsProcessEventHandler = true;
			DesignerModeButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("a5bcc8d7-215f-41c5-8f3c-f96f57d48c34"),
				ImageHash = @"682ad9264105b2170afb821fabf80415"
			};
			DesignerModeButton.ModifiedInSchemaUId = new Guid("8ee64f30-ced9-46d4-a6d4-cbd8b4e66b3c");
		}

		private void UpdateOKButton() {
			OKButton.AjaxEvents.Click.IsProcessEventHandler = true;
			OKButton.Image = new ControlImage {};
			OKButton.ModifiedInSchemaUId = new Guid("8ee64f30-ced9-46d4-a6d4-cbd8b4e66b3c");
		}

		private void UpdateCancelButton() {
			CancelButton.AjaxEvents.Click.IsProcessEventHandler = true;
			CancelButton.Image = new ControlImage {};
			CancelButton.ModifiedInSchemaUId = new Guid("8ee64f30-ced9-46d4-a6d4-cbd8b4e66b3c");
		}

		private void UpdateApplyChangesButton() {
			ApplyChangesButton.AjaxEvents.Click.IsProcessEventHandler = true;
			ApplyChangesButton.Image = new ControlImage {};
			ApplyChangesButton.ModifiedInSchemaUId = new Guid("8ee64f30-ced9-46d4-a6d4-cbd8b4e66b3c");
		}

		private void UpdateButtonsControlLayout() {
			ButtonsControlLayout.Image = new ControlImage {};
			ButtonsControlLayout.ModifiedInSchemaUId = new Guid("8ee64f30-ced9-46d4-a6d4-cbd8b4e66b3c");
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("8ee64f30-ced9-46d4-a6d4-cbd8b4e66b3c");
			RealUId = new Guid("8ee64f30-ced9-46d4-a6d4-cbd8b4e66b3c");
			Name = "ConfigItemModelPage";
			ParentSchemaUId = new Guid("8c1db28c-4687-4b3b-b696-c32413d5825e");
			CreatedInPackageId = new Guid("ffa69c6a-c8bb-4a61-bc00-b0bcd40a9862");
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateConfigItemModelPageEventsProcessSchema();
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
			MainControlLayout.InsertItem(2, CreateConfigItemTypeEdit());
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

		protected virtual EmbeddedProcessSchema CreateConfigItemModelPageEventsProcessSchema() {
			var schema = new ConfigItemModelPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.LookupEdit CreateConfigItemTypeEdit() {
			_configItemTypeEdit = new Terrasoft.UI.WebControls.Controls.LookupEdit();
			_configItemTypeEdit.UId = new Guid("6ffda32f-f911-4005-a0ba-2e75c81eff9f");
			_configItemTypeEdit.Name = "ConfigItemTypeEdit";
			_configItemTypeEdit.CreatedInSchemaUId = new Guid("8ee64f30-ced9-46d4-a6d4-cbd8b4e66b3c");
			_configItemTypeEdit.ModifiedInSchemaUId = new Guid("8ee64f30-ced9-46d4-a6d4-cbd8b4e66b3c");
			_configItemTypeEdit.CreatedInPackageId = new Guid("ffa69c6a-c8bb-4a61-bc00-b0bcd40a9862");
			_configItemTypeEdit.Tag = "";
			_configItemTypeEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_configItemTypeEdit.Image = new ControlImage {};
			_configItemTypeEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_configItemTypeEdit.DataSource = "DataSource";
			_configItemTypeEdit.ColumnUId = new Guid("e43bc2e4-0474-42f2-98f2-c8f79ef2628f");
			return _configItemTypeEdit;
		}

		protected override void UpdateDataSource() {
			base.UpdateDataSource();
			DataSource.SchemaUId = new Guid("763b998e-00b3-4b83-90c4-bed9c7715dc7");
			DataSource.ModifiedInSchemaUId = new Guid("8ee64f30-ced9-46d4-a6d4-cbd8b4e66b3c");
			DataSourceStructureColumn column = null;
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ae0e45ca-c495-4fe7-a39d-3ab7278e1617");
			if (column != null) {
				column.UId = new Guid("0a245770-685b-4a6c-b872-b6f535f6e01b");
				column.Name = @"Id";
				column.CreatedInSchemaUId = new Guid("8ee64f30-ced9-46d4-a6d4-cbd8b4e66b3c");
				column.ModifiedInSchemaUId = new Guid("8ee64f30-ced9-46d4-a6d4-cbd8b4e66b3c");
				column.CreatedInPackageId = Guid.Empty;
				column.IsAlwaysSelect = true;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("e80190a5-03b2-4095-90f7-a193a960adee");
			if (column != null) {
				column.UId = new Guid("aed2bbad-7f0e-4337-a019-bc979b660fcd");
				column.Name = @"CreatedOn";
				column.CreatedInSchemaUId = new Guid("8ee64f30-ced9-46d4-a6d4-cbd8b4e66b3c");
				column.ModifiedInSchemaUId = new Guid("8ee64f30-ced9-46d4-a6d4-cbd8b4e66b3c");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ebf6bb93-8aa6-4a01-900d-c6ea67affe21");
			if (column != null) {
				column.UId = new Guid("0b5a68b7-9447-45cd-be21-72bf368010a5");
				column.Name = @"CreatedBy";
				column.CreatedInSchemaUId = new Guid("8ee64f30-ced9-46d4-a6d4-cbd8b4e66b3c");
				column.ModifiedInSchemaUId = new Guid("8ee64f30-ced9-46d4-a6d4-cbd8b4e66b3c");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9928edec-4272-425a-93bb-48743fee4b04");
			if (column != null) {
				column.UId = new Guid("383ab1f4-94cf-4bcf-8d23-23deae5e73ce");
				column.Name = @"ModifiedOn";
				column.CreatedInSchemaUId = new Guid("8ee64f30-ced9-46d4-a6d4-cbd8b4e66b3c");
				column.ModifiedInSchemaUId = new Guid("8ee64f30-ced9-46d4-a6d4-cbd8b4e66b3c");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3015559e-cbc6-406a-88af-07f7930be832");
			if (column != null) {
				column.UId = new Guid("4ef6b1c2-654f-4213-894a-cc134a416811");
				column.Name = @"ModifiedBy";
				column.CreatedInSchemaUId = new Guid("8ee64f30-ced9-46d4-a6d4-cbd8b4e66b3c");
				column.ModifiedInSchemaUId = new Guid("8ee64f30-ced9-46d4-a6d4-cbd8b4e66b3c");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("736c30a7-c0ec-4fa9-b034-2552b319b633");
			if (column != null) {
				column.UId = new Guid("43a41770-428d-4f3b-9793-c7029abe0455");
				column.Name = @"Name";
				column.CreatedInSchemaUId = new Guid("8ee64f30-ced9-46d4-a6d4-cbd8b4e66b3c");
				column.ModifiedInSchemaUId = new Guid("8ee64f30-ced9-46d4-a6d4-cbd8b4e66b3c");
				column.CreatedInPackageId = Guid.Empty;
				column.OrderDirection = OrderDirection.Ascending;
				column.OrderPosition = 1;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9e53fd7c-dde4-4502-a64c-b9e34148108b");
			if (column != null) {
				column.UId = new Guid("26411608-3037-43ea-8c6e-4e6d916a4f9c");
				column.Name = @"Description";
				column.CreatedInSchemaUId = new Guid("8ee64f30-ced9-46d4-a6d4-cbd8b4e66b3c");
				column.ModifiedInSchemaUId = new Guid("8ee64f30-ced9-46d4-a6d4-cbd8b4e66b3c");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3fabd836-6a53-4d8d-9069-6df88d9dae1e");
			if (column != null) {
				column.UId = new Guid("6c534293-968b-40bd-aa0e-21126a1ab97c");
				column.Name = @"ProcessListeners";
				column.CreatedInSchemaUId = new Guid("8ee64f30-ced9-46d4-a6d4-cbd8b4e66b3c");
				column.ModifiedInSchemaUId = new Guid("8ee64f30-ced9-46d4-a6d4-cbd8b4e66b3c");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("95e22dd5-ec6e-479d-9c97-83cd33a6ca2b");
			if (column != null) {
				column.UId = new Guid("e43bc2e4-0474-42f2-98f2-c8f79ef2628f");
				column.Name = @"ConfItemType";
				column.CreatedInSchemaUId = new Guid("8ee64f30-ced9-46d4-a6d4-cbd8b4e66b3c");
				column.ModifiedInSchemaUId = new Guid("8ee64f30-ced9-46d4-a6d4-cbd8b4e66b3c");
				column.CreatedInPackageId = Guid.Empty;
				column.Required = true;
			}
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override PageSchemaUserControl CreateUserControl() {
			return new ConfigItemModelPageSchemaUserControl();
		}

		public override object Clone() {
			return new ConfigItemModelPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("8ee64f30-ced9-46d4-a6d4-cbd8b4e66b3c"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new ConfigItemModelPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: ConfigItemModelPageEventsProcess

	/// <exclude/>
	public class ConfigItemModelPageEventsProcess<TPage> : Terrasoft.WebApp.BaseLookupEditPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.ConfigItemModelPageSchemaUserControl
	{

		public ConfigItemModelPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ConfigItemModelPageEventsProcess";
			SchemaUId = new Guid("8ee64f30-ced9-46d4-a6d4-cbd8b4e66b3c");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("8ee64f30-ced9-46d4-a6d4-cbd8b4e66b3c");
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

	#region Class: ConfigItemModelPageEventsProcess

	/// <exclude/>
	public class ConfigItemModelPageEventsProcess : ConfigItemModelPageEventsProcess<Terrasoft.WebApp.ConfigItemModelPageSchemaUserControl>
	{

		public ConfigItemModelPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: ConfigItemModelPageSchemaUserControl

	/// <exclude/>
	public partial class ConfigItemModelPageSchemaUserControl : Terrasoft.WebApp.BaseLookupEditPageSchemaUserControl
	{

		#region Properties: Public

		public Terrasoft.UI.WebControls.Controls.LookupEdit ConfigItemTypeEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.LookupEdit)PageContainer.FindPageControl("ConfigItemTypeEdit", true);
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
			var process = (ConfigItemModelPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new ConfigItemModelPageEventsProcess(UserConnection);
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
			SchemaName = "ConfigItemModelPage";
		}

		#endregion

	}

	#endregion

	#region Class: ConfigItemModelPageEventsProcessSchema

	/// <exclude/>
	public class ConfigItemModelPageEventsProcessSchema : Terrasoft.WebApp.BaseLookupEditPageEventsProcessSchema
	{

		#region Constructors: Public

		public ConfigItemModelPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public ConfigItemModelPageEventsProcessSchema(ConfigItemModelPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "ConfigItemModelPageEventsProcess";
			UId = new Guid("e5d105a3-2418-490e-b265-877d16b23f0b");
			CreatedInPackageId = new Guid("ffa69c6a-c8bb-4a61-bc00-b0bcd40a9862");
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
				CreatedInPackageId = new Guid("ffa69c6a-c8bb-4a61-bc00-b0bcd40a9862")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("0da240a7-6b5c-4da2-ab4b-e82287d805bd"),
				Name = "Terrasoft.Configuration",
				Alias = "TSConfiguration",
				CreatedInPackageId = new Guid("ffa69c6a-c8bb-4a61-bc00-b0bcd40a9862")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("2f50a15b-41f7-4f3a-bd8f-0eb6fecaf008"),
				Name = "Terrasoft.Web.Common",
				Alias = "",
				CreatedInPackageId = new Guid("ffa69c6a-c8bb-4a61-bc00-b0bcd40a9862")
			});
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new ConfigItemModelPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e5d105a3-2418-490e-b265-877d16b23f0b"));
		}

		#endregion

	}

	#endregion

}

