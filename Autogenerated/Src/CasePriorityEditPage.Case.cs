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
	using System.IO;
	using System.Linq;
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

	#region Class: CasePriorityEditPageSchema

	/// <exclude/>
	public class CasePriorityEditPageSchema : Terrasoft.WebApp.BaseImageLookupEditPageSchema
	{

		#region Properties: Public

		private Terrasoft.UI.WebControls.Controls.IntegerEdit _priorityEdit;
		public Terrasoft.UI.WebControls.Controls.IntegerEdit PriorityEdit {
			get {
				return _priorityEdit;
			}
		}

		#endregion

		#region Constructors: Public

		public CasePriorityEditPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public CasePriorityEditPageSchema(CasePriorityEditPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateNameEdit() {
			NameEdit.AjaxEvents.Change.IsProcessEventHandler = true;
			NameEdit.Image = new ControlImage {};
			NameEdit.ColumnUId = new Guid("edb53342-2e55-4940-8b6c-676038caddd1");
			NameEdit.ModifiedInSchemaUId = new Guid("d0f02595-4ec6-41c8-a7ca-5d91cab8a5d3");
		}

		private void UpdateDescriptionEdit() {
			DescriptionEdit.ColumnUId = new Guid("de125807-804d-433a-bdba-e527c2c3008c");
			DescriptionEdit.ModifiedInSchemaUId = new Guid("d0f02595-4ec6-41c8-a7ca-5d91cab8a5d3");
		}

		private void UpdateImageEdit() {
			ImageEdit.AjaxEvents.Change.IsProcessEventHandler = true;
			ImageEdit.Image = new ControlImage {};
			ImageEdit.ModifiedInSchemaUId = new Guid("d0f02595-4ec6-41c8-a7ca-5d91cab8a5d3");
		}

		private void UpdateImageBox() {
			ImageBox.Image = new ControlImage {};
			ImageBox.ModifiedInSchemaUId = new Guid("d0f02595-4ec6-41c8-a7ca-5d91cab8a5d3");
		}

		private void UpdateCustomControls() {
			CustomControls.Image = new ControlImage {};
			CustomControls.ModifiedInSchemaUId = new Guid("d0f02595-4ec6-41c8-a7ca-5d91cab8a5d3");
		}

		private void UpdateMainControlLayout() {
			MainControlLayout.Image = new ControlImage {};
			MainControlLayout.ModifiedInSchemaUId = new Guid("d0f02595-4ec6-41c8-a7ca-5d91cab8a5d3");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("d0f02595-4ec6-41c8-a7ca-5d91cab8a5d3");
		}

		private void UpdateDesignerModeButton() {
			DesignerModeButton.AjaxEvents.Click.IsProcessEventHandler = true;
			DesignerModeButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("a5bcc8d7-215f-41c5-8f3c-f96f57d48c34"),
				ImageHash = @"682ad9264105b2170afb821fabf80415"
			};
			DesignerModeButton.ModifiedInSchemaUId = new Guid("d0f02595-4ec6-41c8-a7ca-5d91cab8a5d3");
		}

		private void UpdateOKButton() {
			OKButton.AjaxEvents.Click.IsProcessEventHandler = true;
			OKButton.Image = new ControlImage {};
			OKButton.ModifiedInSchemaUId = new Guid("d0f02595-4ec6-41c8-a7ca-5d91cab8a5d3");
		}

		private void UpdateCancelButton() {
			CancelButton.AjaxEvents.Click.IsProcessEventHandler = true;
			CancelButton.Image = new ControlImage {};
			CancelButton.ModifiedInSchemaUId = new Guid("d0f02595-4ec6-41c8-a7ca-5d91cab8a5d3");
		}

		private void UpdateApplyChangesButton() {
			ApplyChangesButton.AjaxEvents.Click.IsProcessEventHandler = true;
			ApplyChangesButton.Image = new ControlImage {};
			ApplyChangesButton.ModifiedInSchemaUId = new Guid("d0f02595-4ec6-41c8-a7ca-5d91cab8a5d3");
		}

		private void UpdateButtonsControlLayout() {
			ButtonsControlLayout.Image = new ControlImage {};
			ButtonsControlLayout.ModifiedInSchemaUId = new Guid("d0f02595-4ec6-41c8-a7ca-5d91cab8a5d3");
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("d0f02595-4ec6-41c8-a7ca-5d91cab8a5d3");
			RealUId = new Guid("d0f02595-4ec6-41c8-a7ca-5d91cab8a5d3");
			Name = "CasePriorityEditPage";
			ParentSchemaUId = new Guid("f889f5ff-356c-41c7-bb8e-a37b1132f065");
			CreatedInPackageId = new Guid("475d20ed-7132-487d-a9d1-4fadc0bc9049");
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateCasePriorityEditPageEventsProcessSchema();
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
			UpdateImageBox();
			UpdateImageEdit();
			UpdateDescriptionEdit();
			UpdateNameEdit();
			TopLevelControl.MoveItem(0, BaseMessagePanel);
			TopLevelControl.MoveItem(1, MainControlLayout);
			MainControlLayout.MoveItem(0, NameEdit);
			MainControlLayout.InsertItem(1, CreatePriorityEdit());
			MainControlLayout.MoveItem(2, DescriptionEdit);
			MainControlLayout.MoveItem(3, ImageEdit);
			MainControlLayout.MoveItem(4, ImageBox);
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

		protected virtual EmbeddedProcessSchema CreateCasePriorityEditPageEventsProcessSchema() {
			var schema = new CasePriorityEditPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.IntegerEdit CreatePriorityEdit() {
			_priorityEdit = new Terrasoft.UI.WebControls.Controls.IntegerEdit();
			_priorityEdit.UId = new Guid("3379632d-8265-44f9-a3bc-2c526abb7fc8");
			_priorityEdit.Name = "PriorityEdit";
			_priorityEdit.CreatedInSchemaUId = new Guid("d0f02595-4ec6-41c8-a7ca-5d91cab8a5d3");
			_priorityEdit.ModifiedInSchemaUId = new Guid("d0f02595-4ec6-41c8-a7ca-5d91cab8a5d3");
			_priorityEdit.CreatedInPackageId = new Guid("475d20ed-7132-487d-a9d1-4fadc0bc9049");
			_priorityEdit.Tag = "";
			_priorityEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_priorityEdit.Image = new ControlImage {};
			_priorityEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_priorityEdit.DataSource = "DataSource";
			_priorityEdit.ColumnUId = new Guid("251345f6-cb5d-4157-b20b-6e10cae9aa49");
			return _priorityEdit;
		}

		protected override void UpdateDataSource() {
			base.UpdateDataSource();
			DataSource.SchemaUId = new Guid("e662865c-728f-40db-b3dd-15dcf46d47df");
			DataSource.ModifiedInSchemaUId = new Guid("d0f02595-4ec6-41c8-a7ca-5d91cab8a5d3");
			DataSourceStructureColumn column = null;
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ae0e45ca-c495-4fe7-a39d-3ab7278e1617");
			if (column != null) {
				column.UId = new Guid("3ab8fe63-d638-4bf5-94d3-d0566e602be9");
				column.Name = @"Id";
				column.CreatedInSchemaUId = new Guid("d0f02595-4ec6-41c8-a7ca-5d91cab8a5d3");
				column.ModifiedInSchemaUId = new Guid("d0f02595-4ec6-41c8-a7ca-5d91cab8a5d3");
				column.CreatedInPackageId = Guid.Empty;
				column.IsAlwaysSelect = true;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("e80190a5-03b2-4095-90f7-a193a960adee");
			if (column != null) {
				column.UId = new Guid("b3d4fdae-5366-4edd-8fd8-3de37d626740");
				column.Name = @"CreatedOn";
				column.CreatedInSchemaUId = new Guid("d0f02595-4ec6-41c8-a7ca-5d91cab8a5d3");
				column.ModifiedInSchemaUId = new Guid("d0f02595-4ec6-41c8-a7ca-5d91cab8a5d3");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ebf6bb93-8aa6-4a01-900d-c6ea67affe21");
			if (column != null) {
				column.UId = new Guid("3048c3d6-f1ee-4336-a60e-fdb26dc6d8bb");
				column.Name = @"CreatedBy";
				column.CreatedInSchemaUId = new Guid("d0f02595-4ec6-41c8-a7ca-5d91cab8a5d3");
				column.ModifiedInSchemaUId = new Guid("d0f02595-4ec6-41c8-a7ca-5d91cab8a5d3");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9928edec-4272-425a-93bb-48743fee4b04");
			if (column != null) {
				column.UId = new Guid("e1ab79a5-c95e-4bf6-9c46-7392fe65cb12");
				column.Name = @"ModifiedOn";
				column.CreatedInSchemaUId = new Guid("d0f02595-4ec6-41c8-a7ca-5d91cab8a5d3");
				column.ModifiedInSchemaUId = new Guid("d0f02595-4ec6-41c8-a7ca-5d91cab8a5d3");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3015559e-cbc6-406a-88af-07f7930be832");
			if (column != null) {
				column.UId = new Guid("02806eb1-8c3f-4580-8502-30752d6f490a");
				column.Name = @"ModifiedBy";
				column.CreatedInSchemaUId = new Guid("d0f02595-4ec6-41c8-a7ca-5d91cab8a5d3");
				column.ModifiedInSchemaUId = new Guid("d0f02595-4ec6-41c8-a7ca-5d91cab8a5d3");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("736c30a7-c0ec-4fa9-b034-2552b319b633");
			if (column != null) {
				column.UId = new Guid("edb53342-2e55-4940-8b6c-676038caddd1");
				column.Name = @"Name";
				column.CreatedInSchemaUId = new Guid("d0f02595-4ec6-41c8-a7ca-5d91cab8a5d3");
				column.ModifiedInSchemaUId = new Guid("d0f02595-4ec6-41c8-a7ca-5d91cab8a5d3");
				column.CreatedInPackageId = Guid.Empty;
				column.OrderDirection = OrderDirection.Ascending;
				column.OrderPosition = 1;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9e53fd7c-dde4-4502-a64c-b9e34148108b");
			if (column != null) {
				column.UId = new Guid("de125807-804d-433a-bdba-e527c2c3008c");
				column.Name = @"Description";
				column.CreatedInSchemaUId = new Guid("d0f02595-4ec6-41c8-a7ca-5d91cab8a5d3");
				column.ModifiedInSchemaUId = new Guid("d0f02595-4ec6-41c8-a7ca-5d91cab8a5d3");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3fabd836-6a53-4d8d-9069-6df88d9dae1e");
			if (column != null) {
				column.UId = new Guid("e19b7352-34d7-4972-ad03-b15558e3ecb1");
				column.Name = @"ProcessListeners";
				column.CreatedInSchemaUId = new Guid("d0f02595-4ec6-41c8-a7ca-5d91cab8a5d3");
				column.ModifiedInSchemaUId = new Guid("d0f02595-4ec6-41c8-a7ca-5d91cab8a5d3");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("49e05c9f-1241-4bc7-aafd-cd48592c8d6a");
			if (column != null) {
				column.UId = new Guid("251345f6-cb5d-4157-b20b-6e10cae9aa49");
				column.Name = @"Priority";
				column.CreatedInSchemaUId = new Guid("d0f02595-4ec6-41c8-a7ca-5d91cab8a5d3");
				column.ModifiedInSchemaUId = new Guid("d0f02595-4ec6-41c8-a7ca-5d91cab8a5d3");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("469c1088-a13d-49cc-90ff-f663e094b1ad");
			if (column != null) {
				column.UId = new Guid("85b01e14-6d68-4b15-897b-9cb3b63e8633");
				column.Name = @"Image";
				column.CreatedInSchemaUId = new Guid("d0f02595-4ec6-41c8-a7ca-5d91cab8a5d3");
				column.ModifiedInSchemaUId = new Guid("d0f02595-4ec6-41c8-a7ca-5d91cab8a5d3");
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
			return new CasePriorityEditPageSchemaUserControl();
		}

		public override object Clone() {
			return new CasePriorityEditPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d0f02595-4ec6-41c8-a7ca-5d91cab8a5d3"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new CasePriorityEditPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: CasePriorityEditPageEventsProcess

	/// <exclude/>
	public class CasePriorityEditPageEventsProcess<TPage> : Terrasoft.WebApp.BaseImageLookupEditPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.CasePriorityEditPageSchemaUserControl
	{

		public CasePriorityEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "CasePriorityEditPageEventsProcess";
			SchemaUId = new Guid("d0f02595-4ec6-41c8-a7ca-5d91cab8a5d3");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("d0f02595-4ec6-41c8-a7ca-5d91cab8a5d3");
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

	#region Class: CasePriorityEditPageEventsProcess

	/// <exclude/>
	public class CasePriorityEditPageEventsProcess : CasePriorityEditPageEventsProcess<Terrasoft.WebApp.CasePriorityEditPageSchemaUserControl>
	{

		public CasePriorityEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: CasePriorityEditPageSchemaUserControl

	/// <exclude/>
	public partial class CasePriorityEditPageSchemaUserControl : Terrasoft.WebApp.BaseImageLookupEditPageSchemaUserControl
	{

		#region Properties: Public

		public Terrasoft.UI.WebControls.Controls.IntegerEdit PriorityEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.IntegerEdit)PageContainer.FindPageControl("PriorityEdit", true);
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
			var process = (CasePriorityEditPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new CasePriorityEditPageEventsProcess(UserConnection);
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
			SchemaName = "CasePriorityEditPage";
		}

		#endregion

	}

	#endregion

	#region Class: CasePriorityEditPageEventsProcessSchema

	/// <exclude/>
	public class CasePriorityEditPageEventsProcessSchema : Terrasoft.WebApp.BaseImageLookupEditPageEventsProcessSchema
	{

		#region Constructors: Public

		public CasePriorityEditPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public CasePriorityEditPageEventsProcessSchema(CasePriorityEditPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "CasePriorityEditPageEventsProcess";
			UId = new Guid("b04f1e4d-cb15-4f6f-9c47-7181e04a35e0");
			CreatedInPackageId = new Guid("475d20ed-7132-487d-a9d1-4fadc0bc9049");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsActiveVersion = false;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("8abfdfca-dc4c-4b09-8a80-efcffb0ec3d0");
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
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("0da240a7-6b5c-4da2-ab4b-e82287d805bd"),
				Name = "Terrasoft.Configuration",
				Alias = "TSConfiguration",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("2f50a15b-41f7-4f3a-bd8f-0eb6fecaf008"),
				Name = "Terrasoft.Web.Common",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("afe423c4-8cce-4471-9bed-65f28b69e1b4"),
				Name = "System.IO",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("4ccf419f-1986-439e-ac12-e87aa0332379"),
				Name = "System.Linq",
				Alias = "",
				CreatedInPackageId = new Guid("078da7ea-fc82-43ac-b58f-9d45baa0b50c")
			});
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new CasePriorityEditPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b04f1e4d-cb15-4f6f-9c47-7181e04a35e0"));
		}

		#endregion

	}

	#endregion

}

