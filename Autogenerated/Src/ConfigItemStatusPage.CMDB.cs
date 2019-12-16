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

	#region Class: ConfigItemStatusPageSchema

	/// <exclude/>
	public class ConfigItemStatusPageSchema : Terrasoft.WebApp.BaseLookupEditPageSchema
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

		public ConfigItemStatusPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public ConfigItemStatusPageSchema(ConfigItemStatusPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateNameEdit() {
			NameEdit.Image = new ControlImage {};
			NameEdit.ColumnUId = new Guid("d35ad132-fcdf-4da5-b87a-a8b236668eb6");
			NameEdit.ModifiedInSchemaUId = new Guid("5ff59ea6-83da-4277-a2d2-a7a77d14c18c");
		}

		private void UpdateDescriptionEdit() {
			DescriptionEdit.ColumnUId = new Guid("a918ac66-97d2-49ad-9f33-d6cc17343eed");
			DescriptionEdit.ModifiedInSchemaUId = new Guid("5ff59ea6-83da-4277-a2d2-a7a77d14c18c");
		}

		private void UpdateCustomControls() {
			CustomControls.Image = new ControlImage {};
			CustomControls.ModifiedInSchemaUId = new Guid("5ff59ea6-83da-4277-a2d2-a7a77d14c18c");
		}

		private void UpdateMainControlLayout() {
			MainControlLayout.Image = new ControlImage {};
			MainControlLayout.ModifiedInSchemaUId = new Guid("5ff59ea6-83da-4277-a2d2-a7a77d14c18c");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("5ff59ea6-83da-4277-a2d2-a7a77d14c18c");
		}

		private void UpdateDesignerModeButton() {
			DesignerModeButton.AjaxEvents.Click.IsProcessEventHandler = true;
			DesignerModeButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("a5bcc8d7-215f-41c5-8f3c-f96f57d48c34"),
				ImageHash = @"682ad9264105b2170afb821fabf80415"
			};
			DesignerModeButton.ModifiedInSchemaUId = new Guid("5ff59ea6-83da-4277-a2d2-a7a77d14c18c");
		}

		private void UpdateOKButton() {
			OKButton.AjaxEvents.Click.IsProcessEventHandler = true;
			OKButton.Image = new ControlImage {};
			OKButton.ModifiedInSchemaUId = new Guid("5ff59ea6-83da-4277-a2d2-a7a77d14c18c");
		}

		private void UpdateCancelButton() {
			CancelButton.AjaxEvents.Click.IsProcessEventHandler = true;
			CancelButton.Image = new ControlImage {};
			CancelButton.ModifiedInSchemaUId = new Guid("5ff59ea6-83da-4277-a2d2-a7a77d14c18c");
		}

		private void UpdateApplyChangesButton() {
			ApplyChangesButton.AjaxEvents.Click.IsProcessEventHandler = true;
			ApplyChangesButton.Image = new ControlImage {};
			ApplyChangesButton.ModifiedInSchemaUId = new Guid("5ff59ea6-83da-4277-a2d2-a7a77d14c18c");
		}

		private void UpdateButtonsControlLayout() {
			ButtonsControlLayout.Image = new ControlImage {};
			ButtonsControlLayout.ModifiedInSchemaUId = new Guid("5ff59ea6-83da-4277-a2d2-a7a77d14c18c");
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("5ff59ea6-83da-4277-a2d2-a7a77d14c18c");
			RealUId = new Guid("5ff59ea6-83da-4277-a2d2-a7a77d14c18c");
			Name = "ConfigItemStatusPage";
			ParentSchemaUId = new Guid("8c1db28c-4687-4b3b-b696-c32413d5825e");
			CreatedInPackageId = new Guid("305fcfca-4160-4398-90a9-d5e84be0ae12");
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateConfigItemStatusPageEventsProcessSchema();
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

		protected virtual EmbeddedProcessSchema CreateConfigItemStatusPageEventsProcessSchema() {
			var schema = new ConfigItemStatusPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.CheckBox CreateIsFinalCheckBox() {
			_isFinalCheckBox = new Terrasoft.UI.WebControls.Controls.CheckBox();
			_isFinalCheckBox.UId = new Guid("3fd68b7d-6576-4a36-91b4-e144f174da72");
			_isFinalCheckBox.Name = "IsFinalCheckBox";
			_isFinalCheckBox.CreatedInSchemaUId = new Guid("5ff59ea6-83da-4277-a2d2-a7a77d14c18c");
			_isFinalCheckBox.ModifiedInSchemaUId = new Guid("5ff59ea6-83da-4277-a2d2-a7a77d14c18c");
			_isFinalCheckBox.CreatedInPackageId = new Guid("305fcfca-4160-4398-90a9-d5e84be0ae12");
			_isFinalCheckBox.Tag = "";
			_isFinalCheckBox.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_isFinalCheckBox.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_isFinalCheckBox.CaptionPosition = Terrasoft.UI.WebControls.Controls.CheckBoxBaseCaptionPosition.Left;
			_isFinalCheckBox.DataSource = "DataSource";
			_isFinalCheckBox.ColumnUId = new Guid("a9a57f40-6475-4503-8b92-ee414821cc2d");
			return _isFinalCheckBox;
		}

		protected override void UpdateDataSource() {
			base.UpdateDataSource();
			DataSource.SchemaUId = new Guid("0f634f04-a6ca-42b3-abe9-3d780c7e9b34");
			DataSource.ModifiedInSchemaUId = new Guid("5ff59ea6-83da-4277-a2d2-a7a77d14c18c");
			DataSourceStructureColumn column = null;
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ae0e45ca-c495-4fe7-a39d-3ab7278e1617");
			if (column != null) {
				column.UId = new Guid("6d9fe2c2-7b88-4cb6-b10f-e725b5531dc2");
				column.Name = @"Id";
				column.CreatedInSchemaUId = new Guid("5ff59ea6-83da-4277-a2d2-a7a77d14c18c");
				column.ModifiedInSchemaUId = new Guid("5ff59ea6-83da-4277-a2d2-a7a77d14c18c");
				column.CreatedInPackageId = Guid.Empty;
				column.IsAlwaysSelect = true;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("e80190a5-03b2-4095-90f7-a193a960adee");
			if (column != null) {
				column.UId = new Guid("fd412d01-2ce4-447f-b5e3-fab01788de00");
				column.Name = @"CreatedOn";
				column.CreatedInSchemaUId = new Guid("5ff59ea6-83da-4277-a2d2-a7a77d14c18c");
				column.ModifiedInSchemaUId = new Guid("5ff59ea6-83da-4277-a2d2-a7a77d14c18c");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ebf6bb93-8aa6-4a01-900d-c6ea67affe21");
			if (column != null) {
				column.UId = new Guid("6868bb8d-12fb-4fa6-8aa0-7012307d78df");
				column.Name = @"CreatedBy";
				column.CreatedInSchemaUId = new Guid("5ff59ea6-83da-4277-a2d2-a7a77d14c18c");
				column.ModifiedInSchemaUId = new Guid("5ff59ea6-83da-4277-a2d2-a7a77d14c18c");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9928edec-4272-425a-93bb-48743fee4b04");
			if (column != null) {
				column.UId = new Guid("f5429109-08ad-4bd6-b927-d6426ba1eb78");
				column.Name = @"ModifiedOn";
				column.CreatedInSchemaUId = new Guid("5ff59ea6-83da-4277-a2d2-a7a77d14c18c");
				column.ModifiedInSchemaUId = new Guid("5ff59ea6-83da-4277-a2d2-a7a77d14c18c");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3015559e-cbc6-406a-88af-07f7930be832");
			if (column != null) {
				column.UId = new Guid("88919a14-e6bb-4a9f-8134-a5aea596c468");
				column.Name = @"ModifiedBy";
				column.CreatedInSchemaUId = new Guid("5ff59ea6-83da-4277-a2d2-a7a77d14c18c");
				column.ModifiedInSchemaUId = new Guid("5ff59ea6-83da-4277-a2d2-a7a77d14c18c");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("736c30a7-c0ec-4fa9-b034-2552b319b633");
			if (column != null) {
				column.UId = new Guid("d35ad132-fcdf-4da5-b87a-a8b236668eb6");
				column.Name = @"Name";
				column.CreatedInSchemaUId = new Guid("5ff59ea6-83da-4277-a2d2-a7a77d14c18c");
				column.ModifiedInSchemaUId = new Guid("5ff59ea6-83da-4277-a2d2-a7a77d14c18c");
				column.CreatedInPackageId = Guid.Empty;
				column.OrderDirection = OrderDirection.Ascending;
				column.OrderPosition = 1;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9e53fd7c-dde4-4502-a64c-b9e34148108b");
			if (column != null) {
				column.UId = new Guid("a918ac66-97d2-49ad-9f33-d6cc17343eed");
				column.Name = @"Description";
				column.CreatedInSchemaUId = new Guid("5ff59ea6-83da-4277-a2d2-a7a77d14c18c");
				column.ModifiedInSchemaUId = new Guid("5ff59ea6-83da-4277-a2d2-a7a77d14c18c");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3fabd836-6a53-4d8d-9069-6df88d9dae1e");
			if (column != null) {
				column.UId = new Guid("b8ebe178-1419-430c-9817-9beb687ccc30");
				column.Name = @"ProcessListeners";
				column.CreatedInSchemaUId = new Guid("5ff59ea6-83da-4277-a2d2-a7a77d14c18c");
				column.ModifiedInSchemaUId = new Guid("5ff59ea6-83da-4277-a2d2-a7a77d14c18c");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("14d8fc5b-9e90-4d95-bf9f-7f40c7e06957");
			if (column != null) {
				column.UId = new Guid("a9a57f40-6475-4503-8b92-ee414821cc2d");
				column.Name = @"IsFinal";
				column.CreatedInSchemaUId = new Guid("5ff59ea6-83da-4277-a2d2-a7a77d14c18c");
				column.ModifiedInSchemaUId = new Guid("5ff59ea6-83da-4277-a2d2-a7a77d14c18c");
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
			return new ConfigItemStatusPageSchemaUserControl();
		}

		public override object Clone() {
			return new ConfigItemStatusPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5ff59ea6-83da-4277-a2d2-a7a77d14c18c"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new ConfigItemStatusPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: ConfigItemStatusPageEventsProcess

	/// <exclude/>
	public class ConfigItemStatusPageEventsProcess<TPage> : Terrasoft.WebApp.BaseLookupEditPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.ConfigItemStatusPageSchemaUserControl
	{

		public ConfigItemStatusPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ConfigItemStatusPageEventsProcess";
			SchemaUId = new Guid("5ff59ea6-83da-4277-a2d2-a7a77d14c18c");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("5ff59ea6-83da-4277-a2d2-a7a77d14c18c");
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

	#region Class: ConfigItemStatusPageEventsProcess

	/// <exclude/>
	public class ConfigItemStatusPageEventsProcess : ConfigItemStatusPageEventsProcess<Terrasoft.WebApp.ConfigItemStatusPageSchemaUserControl>
	{

		public ConfigItemStatusPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: ConfigItemStatusPageSchemaUserControl

	/// <exclude/>
	public partial class ConfigItemStatusPageSchemaUserControl : Terrasoft.WebApp.BaseLookupEditPageSchemaUserControl
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
			var process = (ConfigItemStatusPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new ConfigItemStatusPageEventsProcess(UserConnection);
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
			SchemaName = "ConfigItemStatusPage";
		}

		#endregion

	}

	#endregion

	#region Class: ConfigItemStatusPageEventsProcessSchema

	/// <exclude/>
	public class ConfigItemStatusPageEventsProcessSchema : Terrasoft.WebApp.BaseLookupEditPageEventsProcessSchema
	{

		#region Constructors: Public

		public ConfigItemStatusPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public ConfigItemStatusPageEventsProcessSchema(ConfigItemStatusPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "ConfigItemStatusPageEventsProcess";
			UId = new Guid("9a4cb706-a0d4-4cf5-8693-8857af76d6fc");
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
			return new ConfigItemStatusPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("9a4cb706-a0d4-4cf5-8693-8857af76d6fc"));
		}

		#endregion

	}

	#endregion

}

