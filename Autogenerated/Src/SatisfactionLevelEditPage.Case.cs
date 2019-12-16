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

	#region Class: SatisfactionLevelEditPageSchema

	/// <exclude/>
	public class SatisfactionLevelEditPageSchema : Terrasoft.WebApp.BaseLookupEditPageSchema
	{

		#region Properties: Public

		private Terrasoft.UI.WebControls.Controls.IntegerEdit _pointEdit;
		public Terrasoft.UI.WebControls.Controls.IntegerEdit PointEdit {
			get {
				return _pointEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.LookupEdit _lookupEdit1;
		public Terrasoft.UI.WebControls.Controls.LookupEdit LookupEdit1 {
			get {
				return _lookupEdit1;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ColorEdit _colorEdit;
		public Terrasoft.UI.WebControls.Controls.ColorEdit ColorEdit {
			get {
				return _colorEdit;
			}
		}

		private Terrasoft.UI.WebControls.Controls.ColorEdit _colourEdit;
		public Terrasoft.UI.WebControls.Controls.ColorEdit ColourEdit {
			get {
				return _colourEdit;
			}
		}

		#endregion

		#region Constructors: Public

		public SatisfactionLevelEditPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public SatisfactionLevelEditPageSchema(SatisfactionLevelEditPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateNameEdit() {
			NameEdit.Image = new ControlImage {};
			NameEdit.ColumnUId = new Guid("d9303894-9581-45c8-8821-97d5fc6057bb");
			NameEdit.ModifiedInSchemaUId = new Guid("722916fb-5b5c-4dca-bca2-61834c9091a9");
		}

		private void UpdateDescriptionEdit() {
			DescriptionEdit.ColumnUId = new Guid("5e854a21-7b92-4ffc-8562-eb4348d1abbe");
			DescriptionEdit.ModifiedInSchemaUId = new Guid("722916fb-5b5c-4dca-bca2-61834c9091a9");
		}

		private void UpdateCustomControls() {
			CustomControls.Image = new ControlImage {};
			CustomControls.ModifiedInSchemaUId = new Guid("722916fb-5b5c-4dca-bca2-61834c9091a9");
		}

		private void UpdateMainControlLayout() {
			MainControlLayout.Image = new ControlImage {};
			MainControlLayout.ModifiedInSchemaUId = new Guid("722916fb-5b5c-4dca-bca2-61834c9091a9");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("722916fb-5b5c-4dca-bca2-61834c9091a9");
		}

		private void UpdateDesignerModeButton() {
			DesignerModeButton.AjaxEvents.Click.IsProcessEventHandler = true;
			DesignerModeButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("a5bcc8d7-215f-41c5-8f3c-f96f57d48c34"),
				ImageHash = @"682ad9264105b2170afb821fabf80415"
			};
			DesignerModeButton.ModifiedInSchemaUId = new Guid("722916fb-5b5c-4dca-bca2-61834c9091a9");
		}

		private void UpdateOKButton() {
			OKButton.AjaxEvents.Click.IsProcessEventHandler = true;
			OKButton.Image = new ControlImage {};
			OKButton.ModifiedInSchemaUId = new Guid("722916fb-5b5c-4dca-bca2-61834c9091a9");
		}

		private void UpdateCancelButton() {
			CancelButton.AjaxEvents.Click.IsProcessEventHandler = true;
			CancelButton.Image = new ControlImage {};
			CancelButton.ModifiedInSchemaUId = new Guid("722916fb-5b5c-4dca-bca2-61834c9091a9");
		}

		private void UpdateApplyChangesButton() {
			ApplyChangesButton.AjaxEvents.Click.IsProcessEventHandler = true;
			ApplyChangesButton.Image = new ControlImage {};
			ApplyChangesButton.ModifiedInSchemaUId = new Guid("722916fb-5b5c-4dca-bca2-61834c9091a9");
		}

		private void UpdateButtonsControlLayout() {
			ButtonsControlLayout.Image = new ControlImage {};
			ButtonsControlLayout.ModifiedInSchemaUId = new Guid("722916fb-5b5c-4dca-bca2-61834c9091a9");
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("722916fb-5b5c-4dca-bca2-61834c9091a9");
			RealUId = new Guid("722916fb-5b5c-4dca-bca2-61834c9091a9");
			Name = "SatisfactionLevelEditPage";
			ParentSchemaUId = new Guid("8c1db28c-4687-4b3b-b696-c32413d5825e");
			CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485");
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateSatisfactionLevelEditPageEventsProcessSchema();
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
			MainControlLayout.InsertItem(1, CreatePointEdit());
			MainControlLayout.InsertItem(2, CreateLookupEdit1());
			MainControlLayout.InsertItem(3, CreateColorEdit());
			MainControlLayout.InsertItem(4, CreateColourEdit());
			MainControlLayout.MoveItem(5, DescriptionEdit);
			MainControlLayout.MoveItem(6, CustomControls);
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

		protected virtual EmbeddedProcessSchema CreateSatisfactionLevelEditPageEventsProcessSchema() {
			var schema = new SatisfactionLevelEditPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.IntegerEdit CreatePointEdit() {
			_pointEdit = new Terrasoft.UI.WebControls.Controls.IntegerEdit();
			_pointEdit.UId = new Guid("44f8c20d-e443-44d7-9ab9-fa2088102cfd");
			_pointEdit.Name = "PointEdit";
			_pointEdit.CreatedInSchemaUId = new Guid("722916fb-5b5c-4dca-bca2-61834c9091a9");
			_pointEdit.ModifiedInSchemaUId = new Guid("722916fb-5b5c-4dca-bca2-61834c9091a9");
			_pointEdit.CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485");
			_pointEdit.Tag = "";
			_pointEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_pointEdit.Image = new ControlImage {};
			_pointEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_pointEdit.DataSource = "DataSource";
			_pointEdit.ColumnUId = new Guid("671f3c18-34a9-464f-87f7-da1c9ee278b2");
			return _pointEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.LookupEdit CreateLookupEdit1() {
			_lookupEdit1 = new Terrasoft.UI.WebControls.Controls.LookupEdit();
			_lookupEdit1.UId = new Guid("1faaf481-3092-4a08-9c7d-116721586494");
			_lookupEdit1.Name = "LookupEdit1";
			_lookupEdit1.CreatedInSchemaUId = new Guid("722916fb-5b5c-4dca-bca2-61834c9091a9");
			_lookupEdit1.ModifiedInSchemaUId = new Guid("722916fb-5b5c-4dca-bca2-61834c9091a9");
			_lookupEdit1.CreatedInPackageId = new Guid("c3c90037-274c-4793-841e-197eb228d3cd");
			_lookupEdit1.Tag = "";
			_lookupEdit1.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_lookupEdit1.Image = new ControlImage {};
			_lookupEdit1.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_lookupEdit1.DataSource = "DataSource";
			_lookupEdit1.ColumnUId = new Guid("111797ff-645f-47f6-a95e-d7e74220042f");
			return _lookupEdit1;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ColorEdit CreateColorEdit() {
			_colorEdit = new Terrasoft.UI.WebControls.Controls.ColorEdit();
			_colorEdit.UId = new Guid("2596892e-52da-4540-8b92-1369de007146");
			_colorEdit.Name = "ColorEdit";
			_colorEdit.CreatedInSchemaUId = new Guid("722916fb-5b5c-4dca-bca2-61834c9091a9");
			_colorEdit.ModifiedInSchemaUId = new Guid("722916fb-5b5c-4dca-bca2-61834c9091a9");
			_colorEdit.CreatedInPackageId = new Guid("5cde2e00-3a14-4cc5-9d2d-f1cd6c0c33c5");
			_colorEdit.Tag = "";
			_colorEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_colorEdit.Image = new ControlImage {};
			_colorEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_colorEdit.DataSource = "DataSource";
			_colorEdit.ColumnUId = new Guid("c2f1f4af-b71f-45db-bfce-f57024935091");
			return _colorEdit;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.ColorEdit CreateColourEdit() {
			_colourEdit = new Terrasoft.UI.WebControls.Controls.ColorEdit();
			_colourEdit.UId = new Guid("27ae8a59-777b-4755-a5b3-02f775a02d4b");
			_colourEdit.Name = "ColourEdit";
			_colourEdit.CreatedInSchemaUId = new Guid("722916fb-5b5c-4dca-bca2-61834c9091a9");
			_colourEdit.ModifiedInSchemaUId = new Guid("722916fb-5b5c-4dca-bca2-61834c9091a9");
			_colourEdit.CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485");
			_colourEdit.Tag = "";
			_colourEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_colourEdit.Image = new ControlImage {};
			_colourEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_colourEdit.DataSource = "DataSource";
			_colourEdit.ColumnUId = new Guid("c2f1f4af-b71f-45db-bfce-f57024935091");
			_colourEdit.Hidden = true;
			return _colourEdit;
		}

		protected override void UpdateDataSource() {
			base.UpdateDataSource();
			DataSource.SchemaUId = new Guid("82b9bea0-0053-40fc-8232-85f47d8d17da");
			DataSource.ModifiedInSchemaUId = new Guid("722916fb-5b5c-4dca-bca2-61834c9091a9");
			DataSourceStructureColumn column = null;
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ae0e45ca-c495-4fe7-a39d-3ab7278e1617");
			if (column != null) {
				column.UId = new Guid("5154bda4-0055-4402-a0f0-c2864b4b47b0");
				column.Name = @"Id";
				column.CreatedInSchemaUId = new Guid("722916fb-5b5c-4dca-bca2-61834c9091a9");
				column.ModifiedInSchemaUId = new Guid("722916fb-5b5c-4dca-bca2-61834c9091a9");
				column.CreatedInPackageId = Guid.Empty;
				column.IsAlwaysSelect = true;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("e80190a5-03b2-4095-90f7-a193a960adee");
			if (column != null) {
				column.UId = new Guid("f8b9c301-fc22-472f-a1d0-cf57a64f7564");
				column.Name = @"CreatedOn";
				column.CreatedInSchemaUId = new Guid("722916fb-5b5c-4dca-bca2-61834c9091a9");
				column.ModifiedInSchemaUId = new Guid("722916fb-5b5c-4dca-bca2-61834c9091a9");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ebf6bb93-8aa6-4a01-900d-c6ea67affe21");
			if (column != null) {
				column.UId = new Guid("be857050-18e0-4785-8bbd-dd4e0791286e");
				column.Name = @"CreatedBy";
				column.CreatedInSchemaUId = new Guid("722916fb-5b5c-4dca-bca2-61834c9091a9");
				column.ModifiedInSchemaUId = new Guid("722916fb-5b5c-4dca-bca2-61834c9091a9");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9928edec-4272-425a-93bb-48743fee4b04");
			if (column != null) {
				column.UId = new Guid("7bd560e5-e86d-46b2-91f5-ee2f38ec2247");
				column.Name = @"ModifiedOn";
				column.CreatedInSchemaUId = new Guid("722916fb-5b5c-4dca-bca2-61834c9091a9");
				column.ModifiedInSchemaUId = new Guid("722916fb-5b5c-4dca-bca2-61834c9091a9");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3015559e-cbc6-406a-88af-07f7930be832");
			if (column != null) {
				column.UId = new Guid("b7db2269-5efd-48f1-97d4-07ba811f9abc");
				column.Name = @"ModifiedBy";
				column.CreatedInSchemaUId = new Guid("722916fb-5b5c-4dca-bca2-61834c9091a9");
				column.ModifiedInSchemaUId = new Guid("722916fb-5b5c-4dca-bca2-61834c9091a9");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("736c30a7-c0ec-4fa9-b034-2552b319b633");
			if (column != null) {
				column.UId = new Guid("d9303894-9581-45c8-8821-97d5fc6057bb");
				column.Name = @"Name";
				column.CreatedInSchemaUId = new Guid("722916fb-5b5c-4dca-bca2-61834c9091a9");
				column.ModifiedInSchemaUId = new Guid("722916fb-5b5c-4dca-bca2-61834c9091a9");
				column.CreatedInPackageId = Guid.Empty;
				column.OrderDirection = OrderDirection.Ascending;
				column.OrderPosition = 1;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9e53fd7c-dde4-4502-a64c-b9e34148108b");
			if (column != null) {
				column.UId = new Guid("5e854a21-7b92-4ffc-8562-eb4348d1abbe");
				column.Name = @"Description";
				column.CreatedInSchemaUId = new Guid("722916fb-5b5c-4dca-bca2-61834c9091a9");
				column.ModifiedInSchemaUId = new Guid("722916fb-5b5c-4dca-bca2-61834c9091a9");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3fabd836-6a53-4d8d-9069-6df88d9dae1e");
			if (column != null) {
				column.UId = new Guid("e2dd7d1a-deb6-44c3-bc70-e33d3b7ceb3d");
				column.Name = @"ProcessListeners";
				column.CreatedInSchemaUId = new Guid("722916fb-5b5c-4dca-bca2-61834c9091a9");
				column.ModifiedInSchemaUId = new Guid("722916fb-5b5c-4dca-bca2-61834c9091a9");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ceda6e1a-cdf9-46b0-858b-32646d065136");
			if (column != null) {
				column.UId = new Guid("671f3c18-34a9-464f-87f7-da1c9ee278b2");
				column.Name = @"Point";
				column.CreatedInSchemaUId = new Guid("722916fb-5b5c-4dca-bca2-61834c9091a9");
				column.ModifiedInSchemaUId = new Guid("722916fb-5b5c-4dca-bca2-61834c9091a9");
				column.CreatedInPackageId = Guid.Empty;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("41c56be9-adf6-4ece-a539-4294ead150ad");
			if (column != null) {
				column.UId = new Guid("c2f1f4af-b71f-45db-bfce-f57024935091");
				column.Name = @"Colour";
				column.CreatedInSchemaUId = new Guid("722916fb-5b5c-4dca-bca2-61834c9091a9");
				column.ModifiedInSchemaUId = new Guid("722916fb-5b5c-4dca-bca2-61834c9091a9");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("519e64ec-c30f-4bea-b0d7-6e193095640e");
			if (column != null) {
				column.UId = new Guid("111797ff-645f-47f6-a95e-d7e74220042f");
				column.Name = @"Status";
				column.CreatedInSchemaUId = new Guid("722916fb-5b5c-4dca-bca2-61834c9091a9");
				column.ModifiedInSchemaUId = new Guid("722916fb-5b5c-4dca-bca2-61834c9091a9");
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
			return new SatisfactionLevelEditPageSchemaUserControl();
		}

		public override object Clone() {
			return new SatisfactionLevelEditPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("722916fb-5b5c-4dca-bca2-61834c9091a9"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new SatisfactionLevelEditPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: SatisfactionLevelEditPageEventsProcess

	/// <exclude/>
	public class SatisfactionLevelEditPageEventsProcess<TPage> : Terrasoft.WebApp.BaseLookupEditPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.SatisfactionLevelEditPageSchemaUserControl
	{

		public SatisfactionLevelEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SatisfactionLevelEditPageEventsProcess";
			SchemaUId = new Guid("722916fb-5b5c-4dca-bca2-61834c9091a9");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("722916fb-5b5c-4dca-bca2-61834c9091a9");
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

	#region Class: SatisfactionLevelEditPageEventsProcess

	/// <exclude/>
	public class SatisfactionLevelEditPageEventsProcess : SatisfactionLevelEditPageEventsProcess<Terrasoft.WebApp.SatisfactionLevelEditPageSchemaUserControl>
	{

		public SatisfactionLevelEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SatisfactionLevelEditPageSchemaUserControl

	/// <exclude/>
	public partial class SatisfactionLevelEditPageSchemaUserControl : Terrasoft.WebApp.BaseLookupEditPageSchemaUserControl
	{

		#region Properties: Public

		public Terrasoft.UI.WebControls.Controls.IntegerEdit PointEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.IntegerEdit)PageContainer.FindPageControl("PointEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.LookupEdit LookupEdit1 {
			get {
				return (Terrasoft.UI.WebControls.Controls.LookupEdit)PageContainer.FindPageControl("LookupEdit1", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ColorEdit ColorEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.ColorEdit)PageContainer.FindPageControl("ColorEdit", true);
			}
		}

		public Terrasoft.UI.WebControls.Controls.ColorEdit ColourEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.ColorEdit)PageContainer.FindPageControl("ColourEdit", true);
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
			var process = (SatisfactionLevelEditPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new SatisfactionLevelEditPageEventsProcess(UserConnection);
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
			SchemaName = "SatisfactionLevelEditPage";
		}

		#endregion

	}

	#endregion

	#region Class: SatisfactionLevelEditPageEventsProcessSchema

	/// <exclude/>
	public class SatisfactionLevelEditPageEventsProcessSchema : Terrasoft.WebApp.BaseLookupEditPageEventsProcessSchema
	{

		#region Constructors: Public

		public SatisfactionLevelEditPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public SatisfactionLevelEditPageEventsProcessSchema(SatisfactionLevelEditPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "SatisfactionLevelEditPageEventsProcess";
			UId = new Guid("25b3d3a7-6455-48a2-a176-724395595b14");
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
			return new SatisfactionLevelEditPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("25b3d3a7-6455-48a2-a176-724395595b14"));
		}

		#endregion

	}

	#endregion

}

