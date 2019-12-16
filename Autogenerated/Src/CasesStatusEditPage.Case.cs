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

	#region Class: CasesStatusEditPageSchema

	/// <exclude/>
	public class CasesStatusEditPageSchema : Terrasoft.WebApp.BaseLookupEditPageSchema
	{

		#region Properties: Public

		private Terrasoft.UI.WebControls.Controls.CheckBox _isFinalEdit;
		public Terrasoft.UI.WebControls.Controls.CheckBox IsFinalEdit {
			get {
				return _isFinalEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.CheckBox _isResolvedEdit;
		public Terrasoft.UI.WebControls.Controls.CheckBox IsResolvedEdit {
			get {
				return _isResolvedEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.CheckBox _isPausedEdit;
		public Terrasoft.UI.WebControls.Controls.CheckBox IsPausedEdit {
			get {
				return _isPausedEdit;
			}
		}

		#endregion

		#region Constructors: Public

		public CasesStatusEditPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public CasesStatusEditPageSchema(CasesStatusEditPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateNameEdit() {
			NameEdit.Image = new ControlImage {};
			NameEdit.ColumnUId = new Guid("cdf5052d-1675-4762-b1c9-2c0b9ee146c2");
			NameEdit.ModifiedInSchemaUId = new Guid("90892f5b-749c-496a-a9b8-616fd9ff959e");
		}

		private void UpdateDescriptionEdit() {
			DescriptionEdit.ColumnUId = new Guid("3d0e39e2-50e1-49da-9e2d-0a20020bca09");
			DescriptionEdit.ModifiedInSchemaUId = new Guid("90892f5b-749c-496a-a9b8-616fd9ff959e");
		}

		private void UpdateCustomControls() {
			CustomControls.Image = new ControlImage {};
			CustomControls.ModifiedInSchemaUId = new Guid("90892f5b-749c-496a-a9b8-616fd9ff959e");
		}

		private void UpdateMainControlLayout() {
			MainControlLayout.Image = new ControlImage {};
			MainControlLayout.ModifiedInSchemaUId = new Guid("90892f5b-749c-496a-a9b8-616fd9ff959e");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("90892f5b-749c-496a-a9b8-616fd9ff959e");
		}

		private void UpdateDesignerModeButton() {
			DesignerModeButton.AjaxEvents.Click.IsProcessEventHandler = true;
			DesignerModeButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("a5bcc8d7-215f-41c5-8f3c-f96f57d48c34"),
				ImageHash = @"682ad9264105b2170afb821fabf80415"
			};
			DesignerModeButton.ModifiedInSchemaUId = new Guid("90892f5b-749c-496a-a9b8-616fd9ff959e");
		}

		private void UpdateOKButton() {
			OKButton.AjaxEvents.Click.IsProcessEventHandler = true;
			OKButton.Image = new ControlImage {};
			OKButton.ModifiedInSchemaUId = new Guid("90892f5b-749c-496a-a9b8-616fd9ff959e");
		}

		private void UpdateCancelButton() {
			CancelButton.AjaxEvents.Click.IsProcessEventHandler = true;
			CancelButton.Image = new ControlImage {};
			CancelButton.ModifiedInSchemaUId = new Guid("90892f5b-749c-496a-a9b8-616fd9ff959e");
		}

		private void UpdateApplyChangesButton() {
			ApplyChangesButton.AjaxEvents.Click.IsProcessEventHandler = true;
			ApplyChangesButton.Image = new ControlImage {};
			ApplyChangesButton.ModifiedInSchemaUId = new Guid("90892f5b-749c-496a-a9b8-616fd9ff959e");
		}

		private void UpdateButtonsControlLayout() {
			ButtonsControlLayout.Image = new ControlImage {};
			ButtonsControlLayout.ModifiedInSchemaUId = new Guid("90892f5b-749c-496a-a9b8-616fd9ff959e");
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("90892f5b-749c-496a-a9b8-616fd9ff959e");
			RealUId = new Guid("90892f5b-749c-496a-a9b8-616fd9ff959e");
			Name = "CasesStatusEditPage";
			ParentSchemaUId = new Guid("8c1db28c-4687-4b3b-b696-c32413d5825e");
			CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485");
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateCasesStatusEditPageEventsProcessSchema();
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
			MainControlLayout.InsertItem(2, CreateIsFinalEdit());
			MainControlLayout.InsertItem(3, CreateIsResolvedEdit());
			MainControlLayout.InsertItem(4, CreateIsPausedEdit());
			MainControlLayout.MoveItem(5, CustomControls);
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

		protected virtual EmbeddedProcessSchema CreateCasesStatusEditPageEventsProcessSchema() {
			var schema = new CasesStatusEditPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.CheckBox CreateIsFinalEdit() {
			_isFinalEdit = new Terrasoft.UI.WebControls.Controls.CheckBox();
			_isFinalEdit.UId = new Guid("604ba90e-feb7-47e6-98fe-02557574fd7a");
			_isFinalEdit.Name = "IsFinalEdit";
			_isFinalEdit.CreatedInSchemaUId = new Guid("90892f5b-749c-496a-a9b8-616fd9ff959e");
			_isFinalEdit.ModifiedInSchemaUId = new Guid("90892f5b-749c-496a-a9b8-616fd9ff959e");
			_isFinalEdit.CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485");
			_isFinalEdit.Tag = "";
			_isFinalEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_isFinalEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_isFinalEdit.DataSource = "DataSource";
			_isFinalEdit.ColumnUId = new Guid("d9e64cfb-2fa8-404b-87a1-f6defa8bd8bc");
			return _isFinalEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.CheckBox CreateIsResolvedEdit() {
			_isResolvedEdit = new Terrasoft.UI.WebControls.Controls.CheckBox();
			_isResolvedEdit.UId = new Guid("433426fa-fc8b-42a7-a1eb-b5f382e96f5b");
			_isResolvedEdit.Name = "IsResolvedEdit";
			_isResolvedEdit.CreatedInSchemaUId = new Guid("90892f5b-749c-496a-a9b8-616fd9ff959e");
			_isResolvedEdit.ModifiedInSchemaUId = new Guid("90892f5b-749c-496a-a9b8-616fd9ff959e");
			_isResolvedEdit.CreatedInPackageId = new Guid("ffa69c6a-c8bb-4a61-bc00-b0bcd40a9862");
			_isResolvedEdit.Tag = "";
			_isResolvedEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_isResolvedEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_isResolvedEdit.DataSource = "DataSource";
			_isResolvedEdit.ColumnUId = new Guid("45a8257e-7f8a-4f00-a02d-683567fa0d46");
			return _isResolvedEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.CheckBox CreateIsPausedEdit() {
			_isPausedEdit = new Terrasoft.UI.WebControls.Controls.CheckBox();
			_isPausedEdit.UId = new Guid("8cb5395a-197c-4c03-b20d-a6b265cf1c70");
			_isPausedEdit.Name = "IsPausedEdit";
			_isPausedEdit.CreatedInSchemaUId = new Guid("90892f5b-749c-496a-a9b8-616fd9ff959e");
			_isPausedEdit.ModifiedInSchemaUId = new Guid("90892f5b-749c-496a-a9b8-616fd9ff959e");
			_isPausedEdit.CreatedInPackageId = new Guid("d7034329-b0c9-4f8a-ab80-129b052eadf0");
			_isPausedEdit.Tag = "";
			_isPausedEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_isPausedEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_isPausedEdit.DataSource = "DataSource";
			_isPausedEdit.ColumnUId = new Guid("af73cee3-fabf-4abf-a184-1a03b25429e8");
			return _isPausedEdit;
		}

		protected override void UpdateDataSource() {
			base.UpdateDataSource();
			DataSource.SchemaUId = new Guid("99f35013-6b7a-47d6-b440-e3f1a0ba991c");
			DataSource.ModifiedInSchemaUId = new Guid("90892f5b-749c-496a-a9b8-616fd9ff959e");
			DataSourceStructureColumn column = null;
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ae0e45ca-c495-4fe7-a39d-3ab7278e1617");
			if (column != null) {
				column.UId = new Guid("dad763ea-6e9b-4ff9-b84b-ea5ee0a653ba");
				column.Name = @"Id";
				column.CreatedInSchemaUId = new Guid("90892f5b-749c-496a-a9b8-616fd9ff959e");
				column.ModifiedInSchemaUId = new Guid("90892f5b-749c-496a-a9b8-616fd9ff959e");
				column.CreatedInPackageId = Guid.Empty;
				column.IsAlwaysSelect = true;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("e80190a5-03b2-4095-90f7-a193a960adee");
			if (column != null) {
				column.UId = new Guid("fd259cb8-a99a-48bc-8ccb-6a1e2906bb0a");
				column.Name = @"CreatedOn";
				column.CreatedInSchemaUId = new Guid("90892f5b-749c-496a-a9b8-616fd9ff959e");
				column.ModifiedInSchemaUId = new Guid("90892f5b-749c-496a-a9b8-616fd9ff959e");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ebf6bb93-8aa6-4a01-900d-c6ea67affe21");
			if (column != null) {
				column.UId = new Guid("01c8c7e9-c9ab-47f4-96e1-f50c758768d5");
				column.Name = @"CreatedBy";
				column.CreatedInSchemaUId = new Guid("90892f5b-749c-496a-a9b8-616fd9ff959e");
				column.ModifiedInSchemaUId = new Guid("90892f5b-749c-496a-a9b8-616fd9ff959e");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9928edec-4272-425a-93bb-48743fee4b04");
			if (column != null) {
				column.UId = new Guid("ae13f7b6-95f8-4762-9419-f54d605cfff4");
				column.Name = @"ModifiedOn";
				column.CreatedInSchemaUId = new Guid("90892f5b-749c-496a-a9b8-616fd9ff959e");
				column.ModifiedInSchemaUId = new Guid("90892f5b-749c-496a-a9b8-616fd9ff959e");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3015559e-cbc6-406a-88af-07f7930be832");
			if (column != null) {
				column.UId = new Guid("93e3bb1a-7b43-47b0-9fce-0378db48e368");
				column.Name = @"ModifiedBy";
				column.CreatedInSchemaUId = new Guid("90892f5b-749c-496a-a9b8-616fd9ff959e");
				column.ModifiedInSchemaUId = new Guid("90892f5b-749c-496a-a9b8-616fd9ff959e");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("736c30a7-c0ec-4fa9-b034-2552b319b633");
			if (column != null) {
				column.UId = new Guid("cdf5052d-1675-4762-b1c9-2c0b9ee146c2");
				column.Name = @"Name";
				column.CreatedInSchemaUId = new Guid("90892f5b-749c-496a-a9b8-616fd9ff959e");
				column.ModifiedInSchemaUId = new Guid("90892f5b-749c-496a-a9b8-616fd9ff959e");
				column.CreatedInPackageId = Guid.Empty;
				column.OrderDirection = OrderDirection.Ascending;
				column.OrderPosition = 1;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9e53fd7c-dde4-4502-a64c-b9e34148108b");
			if (column != null) {
				column.UId = new Guid("3d0e39e2-50e1-49da-9e2d-0a20020bca09");
				column.Name = @"Description";
				column.CreatedInSchemaUId = new Guid("90892f5b-749c-496a-a9b8-616fd9ff959e");
				column.ModifiedInSchemaUId = new Guid("90892f5b-749c-496a-a9b8-616fd9ff959e");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3fabd836-6a53-4d8d-9069-6df88d9dae1e");
			if (column != null) {
				column.UId = new Guid("7093ca4c-8aa0-4687-9d08-77e1e543048a");
				column.Name = @"ProcessListeners";
				column.CreatedInSchemaUId = new Guid("90892f5b-749c-496a-a9b8-616fd9ff959e");
				column.ModifiedInSchemaUId = new Guid("90892f5b-749c-496a-a9b8-616fd9ff959e");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("b78647f6-76db-4d25-b665-00fce475324e");
			if (column != null) {
				column.UId = new Guid("d9e64cfb-2fa8-404b-87a1-f6defa8bd8bc");
				column.Name = @"IsFinal";
				column.CreatedInSchemaUId = new Guid("90892f5b-749c-496a-a9b8-616fd9ff959e");
				column.ModifiedInSchemaUId = new Guid("90892f5b-749c-496a-a9b8-616fd9ff959e");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("98771b3f-7dbe-4b12-a017-0ab8d406a02a");
			if (column != null) {
				column.UId = new Guid("45a8257e-7f8a-4f00-a02d-683567fa0d46");
				column.Name = @"IsResolved";
				column.CreatedInSchemaUId = new Guid("90892f5b-749c-496a-a9b8-616fd9ff959e");
				column.ModifiedInSchemaUId = new Guid("90892f5b-749c-496a-a9b8-616fd9ff959e");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("0a97a9ee-3cf1-4e17-ae9c-b06583f4b46e");
			if (column != null) {
				column.UId = new Guid("af73cee3-fabf-4abf-a184-1a03b25429e8");
				column.Name = @"IsPaused";
				column.CreatedInSchemaUId = new Guid("90892f5b-749c-496a-a9b8-616fd9ff959e");
				column.ModifiedInSchemaUId = new Guid("90892f5b-749c-496a-a9b8-616fd9ff959e");
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
			return new CasesStatusEditPageSchemaUserControl();
		}

		public override object Clone() {
			return new CasesStatusEditPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("90892f5b-749c-496a-a9b8-616fd9ff959e"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new CasesStatusEditPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: CasesStatusEditPageEventsProcess

	/// <exclude/>
	public class CasesStatusEditPageEventsProcess<TPage> : Terrasoft.WebApp.BaseLookupEditPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.CasesStatusEditPageSchemaUserControl
	{

		public CasesStatusEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "CasesStatusEditPageEventsProcess";
			SchemaUId = new Guid("90892f5b-749c-496a-a9b8-616fd9ff959e");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("90892f5b-749c-496a-a9b8-616fd9ff959e");
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

	#region Class: CasesStatusEditPageEventsProcess

	/// <exclude/>
	public class CasesStatusEditPageEventsProcess : CasesStatusEditPageEventsProcess<Terrasoft.WebApp.CasesStatusEditPageSchemaUserControl>
	{

		public CasesStatusEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: CasesStatusEditPageSchemaUserControl

	/// <exclude/>
	public partial class CasesStatusEditPageSchemaUserControl : Terrasoft.WebApp.BaseLookupEditPageSchemaUserControl
	{

		#region Properties: Public

		public Terrasoft.UI.WebControls.Controls.CheckBox IsFinalEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.CheckBox)PageContainer.FindPageControl("IsFinalEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.CheckBox IsResolvedEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.CheckBox)PageContainer.FindPageControl("IsResolvedEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.CheckBox IsPausedEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.CheckBox)PageContainer.FindPageControl("IsPausedEdit", true);
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
			var process = (CasesStatusEditPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new CasesStatusEditPageEventsProcess(UserConnection);
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
			SchemaName = "CasesStatusEditPage";
		}

		#endregion

	}

	#endregion

	#region Class: CasesStatusEditPageEventsProcessSchema

	/// <exclude/>
	public class CasesStatusEditPageEventsProcessSchema : Terrasoft.WebApp.BaseLookupEditPageEventsProcessSchema
	{

		#region Constructors: Public

		public CasesStatusEditPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public CasesStatusEditPageEventsProcessSchema(CasesStatusEditPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "CasesStatusEditPageEventsProcess";
			UId = new Guid("63ca5651-39d5-4783-99c9-64551f93955a");
			CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485");
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
				CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("0da240a7-6b5c-4da2-ab4b-e82287d805bd"),
				Name = "Terrasoft.Configuration",
				Alias = "TSConfiguration",
				CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("2f50a15b-41f7-4f3a-bd8f-0eb6fecaf008"),
				Name = "Terrasoft.Web.Common",
				Alias = "",
				CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485")
			});
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new CasesStatusEditPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("63ca5651-39d5-4783-99c9-64551f93955a"));
		}

		#endregion

	}

	#endregion

}

