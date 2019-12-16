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

	#region Class: ReleaseStatusEditPageSchema

	/// <exclude/>
	public class ReleaseStatusEditPageSchema : Terrasoft.WebApp.BaseLookupEditPageSchema
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

		public ReleaseStatusEditPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public ReleaseStatusEditPageSchema(ReleaseStatusEditPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateNameEdit() {
			NameEdit.Image = new ControlImage {};
			NameEdit.ColumnUId = new Guid("9137e600-9250-478d-81d4-8e5a769d9a17");
			NameEdit.ModifiedInSchemaUId = new Guid("3059c30f-9d76-4fa4-8e71-df170a521827");
		}

		private void UpdateDescriptionEdit() {
			DescriptionEdit.ColumnUId = new Guid("97ec3b0b-9e63-4603-b507-c80f1f5cb480");
			DescriptionEdit.ModifiedInSchemaUId = new Guid("3059c30f-9d76-4fa4-8e71-df170a521827");
		}

		private void UpdateCustomControls() {
			CustomControls.Image = new ControlImage {};
			CustomControls.ModifiedInSchemaUId = new Guid("3059c30f-9d76-4fa4-8e71-df170a521827");
		}

		private void UpdateMainControlLayout() {
			MainControlLayout.Image = new ControlImage {};
			MainControlLayout.ModifiedInSchemaUId = new Guid("3059c30f-9d76-4fa4-8e71-df170a521827");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("3059c30f-9d76-4fa4-8e71-df170a521827");
		}

		private void UpdateDesignerModeButton() {
			DesignerModeButton.AjaxEvents.Click.IsProcessEventHandler = true;
			DesignerModeButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("a5bcc8d7-215f-41c5-8f3c-f96f57d48c34"),
				ImageHash = @"682ad9264105b2170afb821fabf80415"
			};
			DesignerModeButton.ModifiedInSchemaUId = new Guid("3059c30f-9d76-4fa4-8e71-df170a521827");
		}

		private void UpdateOKButton() {
			OKButton.AjaxEvents.Click.IsProcessEventHandler = true;
			OKButton.Image = new ControlImage {};
			OKButton.ModifiedInSchemaUId = new Guid("3059c30f-9d76-4fa4-8e71-df170a521827");
		}

		private void UpdateCancelButton() {
			CancelButton.AjaxEvents.Click.IsProcessEventHandler = true;
			CancelButton.Image = new ControlImage {};
			CancelButton.ModifiedInSchemaUId = new Guid("3059c30f-9d76-4fa4-8e71-df170a521827");
		}

		private void UpdateApplyChangesButton() {
			ApplyChangesButton.AjaxEvents.Click.IsProcessEventHandler = true;
			ApplyChangesButton.Image = new ControlImage {};
			ApplyChangesButton.ModifiedInSchemaUId = new Guid("3059c30f-9d76-4fa4-8e71-df170a521827");
		}

		private void UpdateButtonsControlLayout() {
			ButtonsControlLayout.Image = new ControlImage {};
			ButtonsControlLayout.ModifiedInSchemaUId = new Guid("3059c30f-9d76-4fa4-8e71-df170a521827");
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("3059c30f-9d76-4fa4-8e71-df170a521827");
			RealUId = new Guid("3059c30f-9d76-4fa4-8e71-df170a521827");
			Name = "ReleaseStatusEditPage";
			ParentSchemaUId = new Guid("8c1db28c-4687-4b3b-b696-c32413d5825e");
			CreatedInPackageId = new Guid("6364546f-7b12-440c-84c2-926c09002599");
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateReleaseStatusEditPageEventsProcessSchema();
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

		protected virtual EmbeddedProcessSchema CreateReleaseStatusEditPageEventsProcessSchema() {
			var schema = new ReleaseStatusEditPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.CheckBox CreateIsFinalCheckBox() {
			_isFinalCheckBox = new Terrasoft.UI.WebControls.Controls.CheckBox();
			_isFinalCheckBox.UId = new Guid("ddb1a550-68c8-40d5-8496-4bd0ab12e4bc");
			_isFinalCheckBox.Name = "IsFinalCheckBox";
			_isFinalCheckBox.CreatedInSchemaUId = new Guid("3059c30f-9d76-4fa4-8e71-df170a521827");
			_isFinalCheckBox.ModifiedInSchemaUId = new Guid("3059c30f-9d76-4fa4-8e71-df170a521827");
			_isFinalCheckBox.CreatedInPackageId = new Guid("6364546f-7b12-440c-84c2-926c09002599");
			_isFinalCheckBox.Tag = "";
			_isFinalCheckBox.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_isFinalCheckBox.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_isFinalCheckBox.CaptionPosition = Terrasoft.UI.WebControls.Controls.CheckBoxBaseCaptionPosition.Left;
			_isFinalCheckBox.DataSource = "DataSource";
			_isFinalCheckBox.ColumnUId = new Guid("5bf61f37-6d9c-47bf-aefe-eeb8fdfebcf8");
			return _isFinalCheckBox;
		}

		protected override void UpdateDataSource() {
			base.UpdateDataSource();
			DataSource.SchemaUId = new Guid("597097ce-243d-49d2-90de-14bdf30391fb");
			DataSource.ModifiedInSchemaUId = new Guid("3059c30f-9d76-4fa4-8e71-df170a521827");
			DataSourceStructureColumn column = null;
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ae0e45ca-c495-4fe7-a39d-3ab7278e1617");
			if (column != null) {
				column.UId = new Guid("a0d3b73b-4ffe-4dfb-b1ac-2bfd52ba0395");
				column.Name = @"Id";
				column.CreatedInSchemaUId = new Guid("3059c30f-9d76-4fa4-8e71-df170a521827");
				column.ModifiedInSchemaUId = new Guid("3059c30f-9d76-4fa4-8e71-df170a521827");
				column.CreatedInPackageId = Guid.Empty;
				column.IsAlwaysSelect = true;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("e80190a5-03b2-4095-90f7-a193a960adee");
			if (column != null) {
				column.UId = new Guid("c438f8a9-65d3-4c19-8d10-b738f7faa513");
				column.Name = @"CreatedOn";
				column.CreatedInSchemaUId = new Guid("3059c30f-9d76-4fa4-8e71-df170a521827");
				column.ModifiedInSchemaUId = new Guid("3059c30f-9d76-4fa4-8e71-df170a521827");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ebf6bb93-8aa6-4a01-900d-c6ea67affe21");
			if (column != null) {
				column.UId = new Guid("1aea78ef-324e-4aa7-8c2f-ac350d3ef08d");
				column.Name = @"CreatedBy";
				column.CreatedInSchemaUId = new Guid("3059c30f-9d76-4fa4-8e71-df170a521827");
				column.ModifiedInSchemaUId = new Guid("3059c30f-9d76-4fa4-8e71-df170a521827");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9928edec-4272-425a-93bb-48743fee4b04");
			if (column != null) {
				column.UId = new Guid("6cac5123-0ebf-472b-9888-c130559ed6c9");
				column.Name = @"ModifiedOn";
				column.CreatedInSchemaUId = new Guid("3059c30f-9d76-4fa4-8e71-df170a521827");
				column.ModifiedInSchemaUId = new Guid("3059c30f-9d76-4fa4-8e71-df170a521827");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3015559e-cbc6-406a-88af-07f7930be832");
			if (column != null) {
				column.UId = new Guid("5981ccf0-e0ab-4541-b012-7f8c001627e3");
				column.Name = @"ModifiedBy";
				column.CreatedInSchemaUId = new Guid("3059c30f-9d76-4fa4-8e71-df170a521827");
				column.ModifiedInSchemaUId = new Guid("3059c30f-9d76-4fa4-8e71-df170a521827");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("736c30a7-c0ec-4fa9-b034-2552b319b633");
			if (column != null) {
				column.UId = new Guid("9137e600-9250-478d-81d4-8e5a769d9a17");
				column.Name = @"Name";
				column.CreatedInSchemaUId = new Guid("3059c30f-9d76-4fa4-8e71-df170a521827");
				column.ModifiedInSchemaUId = new Guid("3059c30f-9d76-4fa4-8e71-df170a521827");
				column.CreatedInPackageId = Guid.Empty;
				column.OrderDirection = OrderDirection.Ascending;
				column.OrderPosition = 1;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9e53fd7c-dde4-4502-a64c-b9e34148108b");
			if (column != null) {
				column.UId = new Guid("97ec3b0b-9e63-4603-b507-c80f1f5cb480");
				column.Name = @"Description";
				column.CreatedInSchemaUId = new Guid("3059c30f-9d76-4fa4-8e71-df170a521827");
				column.ModifiedInSchemaUId = new Guid("3059c30f-9d76-4fa4-8e71-df170a521827");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3fabd836-6a53-4d8d-9069-6df88d9dae1e");
			if (column != null) {
				column.UId = new Guid("a1ac0c64-82c0-4b65-95bb-0f33266be63c");
				column.Name = @"ProcessListeners";
				column.CreatedInSchemaUId = new Guid("3059c30f-9d76-4fa4-8e71-df170a521827");
				column.ModifiedInSchemaUId = new Guid("3059c30f-9d76-4fa4-8e71-df170a521827");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("e3ebb763-df72-42a8-a2f6-10d0b74b66e3");
			if (column != null) {
				column.UId = new Guid("5bf61f37-6d9c-47bf-aefe-eeb8fdfebcf8");
				column.Name = @"IsFinal";
				column.CreatedInSchemaUId = new Guid("3059c30f-9d76-4fa4-8e71-df170a521827");
				column.ModifiedInSchemaUId = new Guid("3059c30f-9d76-4fa4-8e71-df170a521827");
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
			return new ReleaseStatusEditPageSchemaUserControl();
		}

		public override object Clone() {
			return new ReleaseStatusEditPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("3059c30f-9d76-4fa4-8e71-df170a521827"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new ReleaseStatusEditPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: ReleaseStatusEditPageEventsProcess

	/// <exclude/>
	public class ReleaseStatusEditPageEventsProcess<TPage> : Terrasoft.WebApp.BaseLookupEditPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.ReleaseStatusEditPageSchemaUserControl
	{

		public ReleaseStatusEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ReleaseStatusEditPageEventsProcess";
			SchemaUId = new Guid("3059c30f-9d76-4fa4-8e71-df170a521827");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("3059c30f-9d76-4fa4-8e71-df170a521827");
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

	#region Class: ReleaseStatusEditPageEventsProcess

	/// <exclude/>
	public class ReleaseStatusEditPageEventsProcess : ReleaseStatusEditPageEventsProcess<Terrasoft.WebApp.ReleaseStatusEditPageSchemaUserControl>
	{

		public ReleaseStatusEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: ReleaseStatusEditPageSchemaUserControl

	/// <exclude/>
	public partial class ReleaseStatusEditPageSchemaUserControl : Terrasoft.WebApp.BaseLookupEditPageSchemaUserControl
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
			var process = (ReleaseStatusEditPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new ReleaseStatusEditPageEventsProcess(UserConnection);
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
			SchemaName = "ReleaseStatusEditPage";
		}

		#endregion

	}

	#endregion

	#region Class: ReleaseStatusEditPageEventsProcessSchema

	/// <exclude/>
	public class ReleaseStatusEditPageEventsProcessSchema : Terrasoft.WebApp.BaseLookupEditPageEventsProcessSchema
	{

		#region Constructors: Public

		public ReleaseStatusEditPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public ReleaseStatusEditPageEventsProcessSchema(ReleaseStatusEditPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "ReleaseStatusEditPageEventsProcess";
			UId = new Guid("937e2fe6-ea5b-40e4-984e-2010cbb28303");
			CreatedInPackageId = new Guid("6364546f-7b12-440c-84c2-926c09002599");
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
				CreatedInPackageId = new Guid("6364546f-7b12-440c-84c2-926c09002599")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("0da240a7-6b5c-4da2-ab4b-e82287d805bd"),
				Name = "Terrasoft.Configuration",
				Alias = "TSConfiguration",
				CreatedInPackageId = new Guid("6364546f-7b12-440c-84c2-926c09002599")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("2f50a15b-41f7-4f3a-bd8f-0eb6fecaf008"),
				Name = "Terrasoft.Web.Common",
				Alias = "",
				CreatedInPackageId = new Guid("6364546f-7b12-440c-84c2-926c09002599")
			});
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new ReleaseStatusEditPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("937e2fe6-ea5b-40e4-984e-2010cbb28303"));
		}

		#endregion

	}

	#endregion

}

