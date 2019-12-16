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

	#region Class: BulkEmailCountLimitEditPageSchema

	/// <exclude/>
	public class BulkEmailCountLimitEditPageSchema : Terrasoft.WebApp.BaseEditPageSchema
	{

		#region Properties: Public

		private Terrasoft.UI.WebControls.Controls.TextEdit _titleTextEdit;
		public Terrasoft.UI.WebControls.Controls.TextEdit TitleTextEdit {
			get {
				return _titleTextEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.IntegerEdit _limitCountEdit;
		public Terrasoft.UI.WebControls.Controls.IntegerEdit LimitCountEdit {
			get {
				return _limitCountEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.IntegerEdit _limitPeriodEdit;
		public Terrasoft.UI.WebControls.Controls.IntegerEdit LimitPeriodEdit {
			get {
				return _limitPeriodEdit;
			}
		}

		#endregion

		#region Constructors: Public

		public BulkEmailCountLimitEditPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public BulkEmailCountLimitEditPageSchema(BulkEmailCountLimitEditPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateCustomControls() {
			CustomControls.Height = System.Web.UI.WebControls.Unit.Pixel(100);
			CustomControls.Image = new ControlImage {};
			CustomControls.ModifiedInSchemaUId = new Guid("7cc1c029-8931-43cf-b053-b13432edb497");
		}

		private void UpdateMainControlLayout() {
			MainControlLayout.Image = new ControlImage {};
			MainControlLayout.ModifiedInSchemaUId = new Guid("7cc1c029-8931-43cf-b053-b13432edb497");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("7cc1c029-8931-43cf-b053-b13432edb497");
		}

		private void UpdateDesignerModeButton() {
			DesignerModeButton.AjaxEvents.Click.IsProcessEventHandler = true;
			DesignerModeButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("a5bcc8d7-215f-41c5-8f3c-f96f57d48c34"),
				ImageHash = @"682ad9264105b2170afb821fabf80415"
			};
			DesignerModeButton.ModifiedInSchemaUId = new Guid("7cc1c029-8931-43cf-b053-b13432edb497");
		}

		private void UpdateOKButton() {
			OKButton.AjaxEvents.Click.IsProcessEventHandler = true;
			OKButton.Image = new ControlImage {};
			OKButton.ModifiedInSchemaUId = new Guid("7cc1c029-8931-43cf-b053-b13432edb497");
		}

		private void UpdateCancelButton() {
			CancelButton.AjaxEvents.Click.IsProcessEventHandler = true;
			CancelButton.Image = new ControlImage {};
			CancelButton.ModifiedInSchemaUId = new Guid("7cc1c029-8931-43cf-b053-b13432edb497");
		}

		private void UpdateApplyChangesButton() {
			ApplyChangesButton.AjaxEvents.Click.IsProcessEventHandler = true;
			ApplyChangesButton.Image = new ControlImage {};
			ApplyChangesButton.ModifiedInSchemaUId = new Guid("7cc1c029-8931-43cf-b053-b13432edb497");
		}

		private void UpdateButtonsControlLayout() {
			ButtonsControlLayout.Image = new ControlImage {};
			ButtonsControlLayout.ModifiedInSchemaUId = new Guid("7cc1c029-8931-43cf-b053-b13432edb497");
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("7cc1c029-8931-43cf-b053-b13432edb497");
			RealUId = new Guid("7cc1c029-8931-43cf-b053-b13432edb497");
			Name = "BulkEmailCountLimitEditPage";
			ParentSchemaUId = new Guid("a5bcc8d7-215f-41c5-8f3c-f96f57d48c34");
			CreatedInPackageId = new Guid("1b2ed76b-60ba-43f6-add0-9227ee7a78e8");
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateBulkEmailCountLimitEditPageEventsProcessSchema();
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
			MainControlLayout.MoveItem(0, CustomControls);
			CustomControls.InsertItem(0, CreateTitleTextEdit());
			CustomControls.InsertItem(1, CreateLimitCountEdit());
			CustomControls.InsertItem(2, CreateLimitPeriodEdit());
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

		protected virtual EmbeddedProcessSchema CreateBulkEmailCountLimitEditPageEventsProcessSchema() {
			var schema = new BulkEmailCountLimitEditPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.TextEdit CreateTitleTextEdit() {
			_titleTextEdit = new Terrasoft.UI.WebControls.Controls.TextEdit();
			_titleTextEdit.UId = new Guid("4b6f07c7-36e1-4ace-92d0-eedc2adcd5aa");
			_titleTextEdit.Name = "TitleTextEdit";
			_titleTextEdit.CreatedInSchemaUId = new Guid("7cc1c029-8931-43cf-b053-b13432edb497");
			_titleTextEdit.ModifiedInSchemaUId = new Guid("7cc1c029-8931-43cf-b053-b13432edb497");
			_titleTextEdit.CreatedInPackageId = new Guid("f2d6ee4a-452c-4a57-a15d-2c28192530e2");
			_titleTextEdit.Tag = "";
			_titleTextEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_titleTextEdit.Image = new ControlImage {};
			_titleTextEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_titleTextEdit.DataSource = "DataSource";
			_titleTextEdit.ColumnUId = new Guid("1437f08c-4b44-4e8f-a64e-f94ed0682127");
			return _titleTextEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.IntegerEdit CreateLimitCountEdit() {
			_limitCountEdit = new Terrasoft.UI.WebControls.Controls.IntegerEdit();
			_limitCountEdit.UId = new Guid("cbe9b4b3-d688-47c5-8c89-05c832ea4e7a");
			_limitCountEdit.Name = "LimitCountEdit";
			_limitCountEdit.CreatedInSchemaUId = new Guid("7cc1c029-8931-43cf-b053-b13432edb497");
			_limitCountEdit.ModifiedInSchemaUId = new Guid("7cc1c029-8931-43cf-b053-b13432edb497");
			_limitCountEdit.CreatedInPackageId = new Guid("1b2ed76b-60ba-43f6-add0-9227ee7a78e8");
			_limitCountEdit.Tag = "";
			_limitCountEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_limitCountEdit.Image = new ControlImage {};
			_limitCountEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_limitCountEdit.DataSource = "DataSource";
			_limitCountEdit.ColumnUId = new Guid("72fd90a4-fe7c-483b-83dc-928cb68ae100");
			return _limitCountEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.IntegerEdit CreateLimitPeriodEdit() {
			_limitPeriodEdit = new Terrasoft.UI.WebControls.Controls.IntegerEdit();
			_limitPeriodEdit.UId = new Guid("33793c98-ead6-4a3e-82b3-3fbfba56c154");
			_limitPeriodEdit.Name = "LimitPeriodEdit";
			_limitPeriodEdit.CreatedInSchemaUId = new Guid("7cc1c029-8931-43cf-b053-b13432edb497");
			_limitPeriodEdit.ModifiedInSchemaUId = new Guid("7cc1c029-8931-43cf-b053-b13432edb497");
			_limitPeriodEdit.CreatedInPackageId = new Guid("1b2ed76b-60ba-43f6-add0-9227ee7a78e8");
			_limitPeriodEdit.Tag = "";
			_limitPeriodEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_limitPeriodEdit.Image = new ControlImage {};
			_limitPeriodEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_limitPeriodEdit.DataSource = "DataSource";
			_limitPeriodEdit.ColumnUId = new Guid("176338df-0c17-4db1-885c-0ba64c08fdd2");
			return _limitPeriodEdit;
		}

		protected override void UpdateDataSource() {
			base.UpdateDataSource();
			DataSource.SchemaUId = new Guid("635902af-649c-4b18-a2d3-d6abdf0a5b29");
			DataSource.ModifiedInSchemaUId = new Guid("7cc1c029-8931-43cf-b053-b13432edb497");
			DataSourceStructureColumn column = null;
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ae0e45ca-c495-4fe7-a39d-3ab7278e1617");
			if (column != null) {
				column.UId = new Guid("df7ba91f-7b79-4b8d-9943-13c794b36874");
				column.Name = @"Id";
				column.CreatedInSchemaUId = new Guid("7cc1c029-8931-43cf-b053-b13432edb497");
				column.ModifiedInSchemaUId = new Guid("7cc1c029-8931-43cf-b053-b13432edb497");
				column.CreatedInPackageId = Guid.Empty;
				column.IsAlwaysSelect = true;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("e80190a5-03b2-4095-90f7-a193a960adee");
			if (column != null) {
				column.UId = new Guid("dedadb91-4c0d-42a0-8a24-3875113194ad");
				column.Name = @"CreatedOn";
				column.CreatedInSchemaUId = new Guid("7cc1c029-8931-43cf-b053-b13432edb497");
				column.ModifiedInSchemaUId = new Guid("7cc1c029-8931-43cf-b053-b13432edb497");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ebf6bb93-8aa6-4a01-900d-c6ea67affe21");
			if (column != null) {
				column.UId = new Guid("05bbd1d1-da7d-425c-a5fd-3c05a80e3f36");
				column.Name = @"CreatedBy";
				column.CreatedInSchemaUId = new Guid("7cc1c029-8931-43cf-b053-b13432edb497");
				column.ModifiedInSchemaUId = new Guid("7cc1c029-8931-43cf-b053-b13432edb497");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9928edec-4272-425a-93bb-48743fee4b04");
			if (column != null) {
				column.UId = new Guid("23093987-215c-48b4-8047-5c0adbd1f40c");
				column.Name = @"ModifiedOn";
				column.CreatedInSchemaUId = new Guid("7cc1c029-8931-43cf-b053-b13432edb497");
				column.ModifiedInSchemaUId = new Guid("7cc1c029-8931-43cf-b053-b13432edb497");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3015559e-cbc6-406a-88af-07f7930be832");
			if (column != null) {
				column.UId = new Guid("3d0f774a-a521-4f20-ab7c-7e5c33341d9b");
				column.Name = @"ModifiedBy";
				column.CreatedInSchemaUId = new Guid("7cc1c029-8931-43cf-b053-b13432edb497");
				column.ModifiedInSchemaUId = new Guid("7cc1c029-8931-43cf-b053-b13432edb497");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3fabd836-6a53-4d8d-9069-6df88d9dae1e");
			if (column != null) {
				column.UId = new Guid("5984aa6f-6029-493d-a0f4-8932ab87dc37");
				column.Name = @"ProcessListeners";
				column.CreatedInSchemaUId = new Guid("7cc1c029-8931-43cf-b053-b13432edb497");
				column.ModifiedInSchemaUId = new Guid("7cc1c029-8931-43cf-b053-b13432edb497");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("165781e6-c772-469c-8dad-a597d5e734c9");
			if (column != null) {
				column.UId = new Guid("72fd90a4-fe7c-483b-83dc-928cb68ae100");
				column.Name = @"MailingLimitCount";
				column.CreatedInSchemaUId = new Guid("7cc1c029-8931-43cf-b053-b13432edb497");
				column.ModifiedInSchemaUId = new Guid("7cc1c029-8931-43cf-b053-b13432edb497");
				column.CreatedInPackageId = Guid.Empty;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("df3ef0f1-42e5-42cb-8002-7d00ac9d8e8c");
			if (column != null) {
				column.UId = new Guid("176338df-0c17-4db1-885c-0ba64c08fdd2");
				column.Name = @"MailingLimitPeriod";
				column.CreatedInSchemaUId = new Guid("7cc1c029-8931-43cf-b053-b13432edb497");
				column.ModifiedInSchemaUId = new Guid("7cc1c029-8931-43cf-b053-b13432edb497");
				column.CreatedInPackageId = Guid.Empty;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9c375abd-a5cd-494e-a611-a6088f8382f0");
			if (column != null) {
				column.UId = new Guid("9950068f-4a82-446d-aaba-c228cab134b2");
				column.Name = @"OverlimitResponse";
				column.CreatedInSchemaUId = new Guid("7cc1c029-8931-43cf-b053-b13432edb497");
				column.ModifiedInSchemaUId = new Guid("7cc1c029-8931-43cf-b053-b13432edb497");
				column.CreatedInPackageId = Guid.Empty;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("276dfd4d-44fd-4ba3-b8ec-2445871ce373");
			if (column != null) {
				column.UId = new Guid("1437f08c-4b44-4e8f-a64e-f94ed0682127");
				column.Name = @"Title";
				column.CreatedInSchemaUId = new Guid("7cc1c029-8931-43cf-b053-b13432edb497");
				column.ModifiedInSchemaUId = new Guid("7cc1c029-8931-43cf-b053-b13432edb497");
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
			return new BulkEmailCountLimitEditPageSchemaUserControl();
		}

		public override object Clone() {
			return new BulkEmailCountLimitEditPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("7cc1c029-8931-43cf-b053-b13432edb497"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new BulkEmailCountLimitEditPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: BulkEmailCountLimitEditPageEventsProcess

	/// <exclude/>
	public class BulkEmailCountLimitEditPageEventsProcess<TPage> : Terrasoft.WebApp.BaseEditPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.BulkEmailCountLimitEditPageSchemaUserControl
	{

		public BulkEmailCountLimitEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "BulkEmailCountLimitEditPageEventsProcess";
			SchemaUId = new Guid("7cc1c029-8931-43cf-b053-b13432edb497");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("7cc1c029-8931-43cf-b053-b13432edb497");
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

		private LocalizableString _fieldsZeroValidation;
		public LocalizableString FieldsZeroValidation {
			get {
				return _fieldsZeroValidation ?? (_fieldsZeroValidation = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.FieldsZeroValidation.Value"));
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

		public override void OkClickMethod() {
			var activeRow = Page.DataSource.ActiveRow;
if (activeRow != null) {
	if(activeRow.GetTypedColumnValue<int>("MailingLimitCount") < 1 ||
		activeRow.GetTypedColumnValue<int>("MailingLimitPeriod") < 1) {
		ShowErrorMessage(FieldsZeroValidation);
		return;
	}
}
base.OkClickMethod();
		}

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

	#region Class: BulkEmailCountLimitEditPageEventsProcess

	/// <exclude/>
	public class BulkEmailCountLimitEditPageEventsProcess : BulkEmailCountLimitEditPageEventsProcess<Terrasoft.WebApp.BulkEmailCountLimitEditPageSchemaUserControl>
	{

		public BulkEmailCountLimitEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: BulkEmailCountLimitEditPageSchemaUserControl

	/// <exclude/>
	public partial class BulkEmailCountLimitEditPageSchemaUserControl : Terrasoft.WebApp.BaseEditPageSchemaUserControl
	{

		#region Properties: Public

		public Terrasoft.UI.WebControls.Controls.TextEdit TitleTextEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.TextEdit)PageContainer.FindPageControl("TitleTextEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.IntegerEdit LimitCountEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.IntegerEdit)PageContainer.FindPageControl("LimitCountEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.IntegerEdit LimitPeriodEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.IntegerEdit)PageContainer.FindPageControl("LimitPeriodEdit", true);
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
			var process = (BulkEmailCountLimitEditPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new BulkEmailCountLimitEditPageEventsProcess(UserConnection);
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
			SchemaName = "BulkEmailCountLimitEditPage";
		}

		#endregion

	}

	#endregion

	#region Class: BulkEmailCountLimitEditPageEventsProcessSchema

	/// <exclude/>
	public class BulkEmailCountLimitEditPageEventsProcessSchema : Terrasoft.WebApp.BaseEditPageEventsProcessSchema
	{

		#region Constructors: Public

		public BulkEmailCountLimitEditPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public BulkEmailCountLimitEditPageEventsProcessSchema(BulkEmailCountLimitEditPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "BulkEmailCountLimitEditPageEventsProcess";
			UId = new Guid("8834a013-5de2-4126-a0e2-0abbff470a38");
			CreatedInPackageId = new Guid("1b2ed76b-60ba-43f6-add0-9227ee7a78e8");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
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
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateFieldsZeroValidationLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateFieldsZeroValidationLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("ca966e66-d048-41b3-a9ef-978ea7be4723"),
				Name = "FieldsZeroValidation",
				CreatedInPackageId = new Guid("92490ccb-e39c-40b6-960b-2de441c77b5c"),
				CreatedInSchemaUId = new Guid("8834a013-5de2-4126-a0e2-0abbff470a38"),
				ModifiedInSchemaUId = new Guid("8834a013-5de2-4126-a0e2-0abbff470a38")
			};
			return localizableString;
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
				CreatedInPackageId = new Guid("1b2ed76b-60ba-43f6-add0-9227ee7a78e8")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("0da240a7-6b5c-4da2-ab4b-e82287d805bd"),
				Name = "Terrasoft.Configuration",
				Alias = "TSConfiguration",
				CreatedInPackageId = new Guid("1b2ed76b-60ba-43f6-add0-9227ee7a78e8")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("2f50a15b-41f7-4f3a-bd8f-0eb6fecaf008"),
				Name = "Terrasoft.Web.Common",
				Alias = "",
				CreatedInPackageId = new Guid("1b2ed76b-60ba-43f6-add0-9227ee7a78e8")
			});
		}

		protected override SchemaMethod CreateOkClickMethodMethod() {
			SchemaMethod method = base.CreateOkClickMethodMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,143,65,107,194,64,16,133,207,217,95,49,245,148,92,2,158,163,130,196,214,75,131,82,75,15,189,141,217,81,7,215,29,153,204,42,165,250,223,27,44,226,217,219,131,239,241,241,222,9,21,176,53,62,209,135,156,97,12,75,220,82,57,67,195,149,36,109,169,156,222,89,229,120,3,249,163,250,50,134,152,66,40,224,215,101,188,121,128,114,78,246,249,115,36,95,75,72,135,248,133,33,209,136,163,77,242,65,131,28,56,110,223,249,192,86,75,138,54,40,96,4,67,184,92,92,150,61,43,88,146,178,248,127,195,109,68,182,218,201,249,85,85,180,161,174,235,111,228,111,76,193,119,223,164,210,75,216,163,177,196,162,234,155,74,150,52,246,233,234,174,110,141,29,149,139,125,29,184,221,55,100,59,241,121,81,253,1,138,122,242,253,23,1,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new BulkEmailCountLimitEditPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("8834a013-5de2-4126-a0e2-0abbff470a38"));
		}

		#endregion

	}

	#endregion

}

