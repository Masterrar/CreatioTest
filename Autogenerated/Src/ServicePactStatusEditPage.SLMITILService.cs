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

	#region Class: ServicePactStatusEditPageSchema

	/// <exclude/>
	public class ServicePactStatusEditPageSchema : Terrasoft.WebApp.BaseLookupEditPageSchema
	{

		#region Properties: Public

		private Terrasoft.UI.WebControls.Controls.CheckBox _isActiveEdit;
		public Terrasoft.UI.WebControls.Controls.CheckBox IsActiveEdit {
			get {
				return _isActiveEdit;
			}
		}

		#endregion

		#region Constructors: Public

		public ServicePactStatusEditPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public ServicePactStatusEditPageSchema(ServicePactStatusEditPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateNameEdit() {
			NameEdit.Image = new ControlImage {};
			NameEdit.ColumnUId = new Guid("75549459-9b84-43fb-bd64-ea8b9ab9cdba");
			NameEdit.ModifiedInSchemaUId = new Guid("679ad6ad-643e-4a34-8469-b437f0a2551a");
		}

		private void UpdateDescriptionEdit() {
			DescriptionEdit.ColumnUId = new Guid("1cb9f878-a874-4840-94d8-476569fa0d8b");
			DescriptionEdit.ModifiedInSchemaUId = new Guid("679ad6ad-643e-4a34-8469-b437f0a2551a");
		}

		private void UpdateCustomControls() {
			CustomControls.Image = new ControlImage {};
			CustomControls.ModifiedInSchemaUId = new Guid("679ad6ad-643e-4a34-8469-b437f0a2551a");
		}

		private void UpdateMainControlLayout() {
			MainControlLayout.Image = new ControlImage {};
			MainControlLayout.ModifiedInSchemaUId = new Guid("679ad6ad-643e-4a34-8469-b437f0a2551a");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("679ad6ad-643e-4a34-8469-b437f0a2551a");
		}

		private void UpdateDesignerModeButton() {
			DesignerModeButton.AjaxEvents.Click.IsProcessEventHandler = true;
			DesignerModeButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("a5bcc8d7-215f-41c5-8f3c-f96f57d48c34"),
				ImageHash = @"682ad9264105b2170afb821fabf80415"
			};
			DesignerModeButton.ModifiedInSchemaUId = new Guid("679ad6ad-643e-4a34-8469-b437f0a2551a");
		}

		private void UpdateOKButton() {
			OKButton.AjaxEvents.Click.IsProcessEventHandler = true;
			OKButton.Image = new ControlImage {};
			OKButton.ModifiedInSchemaUId = new Guid("679ad6ad-643e-4a34-8469-b437f0a2551a");
		}

		private void UpdateCancelButton() {
			CancelButton.AjaxEvents.Click.IsProcessEventHandler = true;
			CancelButton.Image = new ControlImage {};
			CancelButton.ModifiedInSchemaUId = new Guid("679ad6ad-643e-4a34-8469-b437f0a2551a");
		}

		private void UpdateApplyChangesButton() {
			ApplyChangesButton.AjaxEvents.Click.IsProcessEventHandler = true;
			ApplyChangesButton.Image = new ControlImage {};
			ApplyChangesButton.ModifiedInSchemaUId = new Guid("679ad6ad-643e-4a34-8469-b437f0a2551a");
		}

		private void UpdateButtonsControlLayout() {
			ButtonsControlLayout.Image = new ControlImage {};
			ButtonsControlLayout.ModifiedInSchemaUId = new Guid("679ad6ad-643e-4a34-8469-b437f0a2551a");
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("679ad6ad-643e-4a34-8469-b437f0a2551a");
			RealUId = new Guid("679ad6ad-643e-4a34-8469-b437f0a2551a");
			Name = "ServicePactStatusEditPage";
			ParentSchemaUId = new Guid("8c1db28c-4687-4b3b-b696-c32413d5825e");
			CreatedInPackageId = new Guid("ffa69c6a-c8bb-4a61-bc00-b0bcd40a9862");
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateServicePactStatusEditPageEventsProcessSchema();
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
			MainControlLayout.InsertItem(2, CreateIsActiveEdit());
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

		protected virtual EmbeddedProcessSchema CreateServicePactStatusEditPageEventsProcessSchema() {
			var schema = new ServicePactStatusEditPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.CheckBox CreateIsActiveEdit() {
			_isActiveEdit = new Terrasoft.UI.WebControls.Controls.CheckBox();
			_isActiveEdit.UId = new Guid("6f6cc5d1-b1e9-4dc0-8870-c2bdea831b8e");
			_isActiveEdit.Name = "IsActiveEdit";
			_isActiveEdit.CreatedInSchemaUId = new Guid("679ad6ad-643e-4a34-8469-b437f0a2551a");
			_isActiveEdit.ModifiedInSchemaUId = new Guid("679ad6ad-643e-4a34-8469-b437f0a2551a");
			_isActiveEdit.CreatedInPackageId = new Guid("ffa69c6a-c8bb-4a61-bc00-b0bcd40a9862");
			_isActiveEdit.Tag = "";
			_isActiveEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_isActiveEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_isActiveEdit.CaptionPosition = Terrasoft.UI.WebControls.Controls.CheckBoxBaseCaptionPosition.Left;
			_isActiveEdit.DataSource = "DataSource";
			_isActiveEdit.ColumnUId = new Guid("c5c0184b-11f3-4281-8d1c-c7ed598250ec");
			return _isActiveEdit;
		}

		protected override void UpdateDataSource() {
			base.UpdateDataSource();
			DataSource.SchemaUId = new Guid("ada4cb8a-7b7d-48ae-96c0-fedfa6de3c78");
			DataSource.ModifiedInSchemaUId = new Guid("679ad6ad-643e-4a34-8469-b437f0a2551a");
			DataSourceStructureColumn column = null;
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ae0e45ca-c495-4fe7-a39d-3ab7278e1617");
			if (column != null) {
				column.UId = new Guid("4c87819a-aa12-4db3-af20-d22ceca97b41");
				column.Name = @"Id";
				column.CreatedInSchemaUId = new Guid("679ad6ad-643e-4a34-8469-b437f0a2551a");
				column.ModifiedInSchemaUId = new Guid("679ad6ad-643e-4a34-8469-b437f0a2551a");
				column.CreatedInPackageId = Guid.Empty;
				column.IsAlwaysSelect = true;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("e80190a5-03b2-4095-90f7-a193a960adee");
			if (column != null) {
				column.UId = new Guid("d2a8fe2d-3a6b-4cbb-8059-f728c51ef62b");
				column.Name = @"CreatedOn";
				column.CreatedInSchemaUId = new Guid("679ad6ad-643e-4a34-8469-b437f0a2551a");
				column.ModifiedInSchemaUId = new Guid("679ad6ad-643e-4a34-8469-b437f0a2551a");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ebf6bb93-8aa6-4a01-900d-c6ea67affe21");
			if (column != null) {
				column.UId = new Guid("603e33e3-e063-4c09-82e1-8ecb2795e80f");
				column.Name = @"CreatedBy";
				column.CreatedInSchemaUId = new Guid("679ad6ad-643e-4a34-8469-b437f0a2551a");
				column.ModifiedInSchemaUId = new Guid("679ad6ad-643e-4a34-8469-b437f0a2551a");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9928edec-4272-425a-93bb-48743fee4b04");
			if (column != null) {
				column.UId = new Guid("4d511828-71c9-4b34-bb49-27bfdbe63119");
				column.Name = @"ModifiedOn";
				column.CreatedInSchemaUId = new Guid("679ad6ad-643e-4a34-8469-b437f0a2551a");
				column.ModifiedInSchemaUId = new Guid("679ad6ad-643e-4a34-8469-b437f0a2551a");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3015559e-cbc6-406a-88af-07f7930be832");
			if (column != null) {
				column.UId = new Guid("bf96ed6b-5712-4c08-b6e4-1ddac8c1bff7");
				column.Name = @"ModifiedBy";
				column.CreatedInSchemaUId = new Guid("679ad6ad-643e-4a34-8469-b437f0a2551a");
				column.ModifiedInSchemaUId = new Guid("679ad6ad-643e-4a34-8469-b437f0a2551a");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("736c30a7-c0ec-4fa9-b034-2552b319b633");
			if (column != null) {
				column.UId = new Guid("75549459-9b84-43fb-bd64-ea8b9ab9cdba");
				column.Name = @"Name";
				column.CreatedInSchemaUId = new Guid("679ad6ad-643e-4a34-8469-b437f0a2551a");
				column.ModifiedInSchemaUId = new Guid("679ad6ad-643e-4a34-8469-b437f0a2551a");
				column.CreatedInPackageId = Guid.Empty;
				column.OrderDirection = OrderDirection.Ascending;
				column.OrderPosition = 1;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9e53fd7c-dde4-4502-a64c-b9e34148108b");
			if (column != null) {
				column.UId = new Guid("1cb9f878-a874-4840-94d8-476569fa0d8b");
				column.Name = @"Description";
				column.CreatedInSchemaUId = new Guid("679ad6ad-643e-4a34-8469-b437f0a2551a");
				column.ModifiedInSchemaUId = new Guid("679ad6ad-643e-4a34-8469-b437f0a2551a");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3fabd836-6a53-4d8d-9069-6df88d9dae1e");
			if (column != null) {
				column.UId = new Guid("fcb8557b-8cbf-4f52-b373-01c43191f34e");
				column.Name = @"ProcessListeners";
				column.CreatedInSchemaUId = new Guid("679ad6ad-643e-4a34-8469-b437f0a2551a");
				column.ModifiedInSchemaUId = new Guid("679ad6ad-643e-4a34-8469-b437f0a2551a");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9b3fb41d-c75a-4a0a-88a1-016a55b32ec0");
			if (column != null) {
				column.UId = new Guid("c5c0184b-11f3-4281-8d1c-c7ed598250ec");
				column.Name = @"IsActive";
				column.CreatedInSchemaUId = new Guid("679ad6ad-643e-4a34-8469-b437f0a2551a");
				column.ModifiedInSchemaUId = new Guid("679ad6ad-643e-4a34-8469-b437f0a2551a");
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
			return new ServicePactStatusEditPageSchemaUserControl();
		}

		public override object Clone() {
			return new ServicePactStatusEditPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("679ad6ad-643e-4a34-8469-b437f0a2551a"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new ServicePactStatusEditPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: ServicePactStatusEditPageEventsProcess

	/// <exclude/>
	public class ServicePactStatusEditPageEventsProcess<TPage> : Terrasoft.WebApp.BaseLookupEditPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.ServicePactStatusEditPageSchemaUserControl
	{

		public ServicePactStatusEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ServicePactStatusEditPageEventsProcess";
			SchemaUId = new Guid("679ad6ad-643e-4a34-8469-b437f0a2551a");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("679ad6ad-643e-4a34-8469-b437f0a2551a");
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

	#region Class: ServicePactStatusEditPageEventsProcess

	/// <exclude/>
	public class ServicePactStatusEditPageEventsProcess : ServicePactStatusEditPageEventsProcess<Terrasoft.WebApp.ServicePactStatusEditPageSchemaUserControl>
	{

		public ServicePactStatusEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: ServicePactStatusEditPageSchemaUserControl

	/// <exclude/>
	public partial class ServicePactStatusEditPageSchemaUserControl : Terrasoft.WebApp.BaseLookupEditPageSchemaUserControl
	{

		#region Properties: Public

		public Terrasoft.UI.WebControls.Controls.CheckBox IsActiveEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.CheckBox)PageContainer.FindPageControl("IsActiveEdit", true);
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
			var process = (ServicePactStatusEditPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new ServicePactStatusEditPageEventsProcess(UserConnection);
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
			SchemaName = "ServicePactStatusEditPage";
		}

		#endregion

	}

	#endregion

	#region Class: ServicePactStatusEditPageEventsProcessSchema

	/// <exclude/>
	public class ServicePactStatusEditPageEventsProcessSchema : Terrasoft.WebApp.BaseLookupEditPageEventsProcessSchema
	{

		#region Constructors: Public

		public ServicePactStatusEditPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public ServicePactStatusEditPageEventsProcessSchema(ServicePactStatusEditPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "ServicePactStatusEditPageEventsProcess";
			UId = new Guid("620ab72a-28eb-4b6d-8c3b-caf401e4e598");
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
			return new ServicePactStatusEditPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("620ab72a-28eb-4b6d-8c3b-caf401e4e598"));
		}

		#endregion

	}

	#endregion

}

