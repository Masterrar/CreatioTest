﻿namespace Terrasoft.WebApp
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

	#region Class: UnitEditPageSchema

	/// <exclude/>
	public class UnitEditPageSchema : Terrasoft.WebApp.BaseLookupEditPageSchema
	{

		#region Properties: Public

		private Terrasoft.UI.WebControls.Controls.TextEdit _shortNameEdit;
		public Terrasoft.UI.WebControls.Controls.TextEdit ShortNameEdit {
			get {
				return _shortNameEdit;
			}
		}

		#endregion

		#region Constructors: Public

		public UnitEditPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public UnitEditPageSchema(UnitEditPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateNameEdit() {
			NameEdit.Image = new ControlImage {};
			NameEdit.ColumnUId = new Guid("36f0e3f9-9204-4282-b340-76cdf804dab0");
			NameEdit.ModifiedInSchemaUId = new Guid("82a6e9da-0ea6-4646-87b3-47a238432175");
		}

		private void UpdateDescriptionEdit() {
			DescriptionEdit.ColumnUId = new Guid("70748e29-05d1-4cee-a3d7-77f8ef185d6c");
			DescriptionEdit.ModifiedInSchemaUId = new Guid("82a6e9da-0ea6-4646-87b3-47a238432175");
		}

		private void UpdateCustomControls() {
			CustomControls.Image = new ControlImage {};
			CustomControls.ModifiedInSchemaUId = new Guid("82a6e9da-0ea6-4646-87b3-47a238432175");
		}

		private void UpdateMainControlLayout() {
			MainControlLayout.Image = new ControlImage {};
			MainControlLayout.ModifiedInSchemaUId = new Guid("82a6e9da-0ea6-4646-87b3-47a238432175");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("82a6e9da-0ea6-4646-87b3-47a238432175");
		}

		private void UpdateDesignerModeButton() {
			DesignerModeButton.AjaxEvents.Click.IsProcessEventHandler = true;
			DesignerModeButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("a5bcc8d7-215f-41c5-8f3c-f96f57d48c34"),
				ImageHash = @"682ad9264105b2170afb821fabf80415"
			};
			DesignerModeButton.ModifiedInSchemaUId = new Guid("82a6e9da-0ea6-4646-87b3-47a238432175");
		}

		private void UpdateOKButton() {
			OKButton.AjaxEvents.Click.IsProcessEventHandler = true;
			OKButton.Image = new ControlImage {};
			OKButton.ModifiedInSchemaUId = new Guid("82a6e9da-0ea6-4646-87b3-47a238432175");
		}

		private void UpdateCancelButton() {
			CancelButton.AjaxEvents.Click.IsProcessEventHandler = true;
			CancelButton.Image = new ControlImage {};
			CancelButton.ModifiedInSchemaUId = new Guid("82a6e9da-0ea6-4646-87b3-47a238432175");
		}

		private void UpdateApplyChangesButton() {
			ApplyChangesButton.AjaxEvents.Click.IsProcessEventHandler = true;
			ApplyChangesButton.Image = new ControlImage {};
			ApplyChangesButton.ModifiedInSchemaUId = new Guid("82a6e9da-0ea6-4646-87b3-47a238432175");
		}

		private void UpdateButtonsControlLayout() {
			ButtonsControlLayout.Image = new ControlImage {};
			ButtonsControlLayout.ModifiedInSchemaUId = new Guid("82a6e9da-0ea6-4646-87b3-47a238432175");
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("82a6e9da-0ea6-4646-87b3-47a238432175");
			RealUId = new Guid("82a6e9da-0ea6-4646-87b3-47a238432175");
			Name = "UnitEditPage";
			ParentSchemaUId = new Guid("8c1db28c-4687-4b3b-b696-c32413d5825e");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			Height = 320;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateUnitEditPageEventsProcessSchema();
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
			MainControlLayout.InsertItem(1, CreateShortNameEdit());
			MainControlLayout.MoveItem(2, DescriptionEdit);
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

		protected virtual EmbeddedProcessSchema CreateUnitEditPageEventsProcessSchema() {
			var schema = new UnitEditPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.TextEdit CreateShortNameEdit() {
			_shortNameEdit = new Terrasoft.UI.WebControls.Controls.TextEdit();
			_shortNameEdit.UId = new Guid("0e45a76b-982d-482e-a617-246e36d072f5");
			_shortNameEdit.Name = "ShortNameEdit";
			_shortNameEdit.CreatedInSchemaUId = new Guid("82a6e9da-0ea6-4646-87b3-47a238432175");
			_shortNameEdit.ModifiedInSchemaUId = new Guid("82a6e9da-0ea6-4646-87b3-47a238432175");
			_shortNameEdit.CreatedInPackageId = Guid.Empty;
			_shortNameEdit.Tag = "";
			_shortNameEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_shortNameEdit.Image = new ControlImage {};
			_shortNameEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_shortNameEdit.DataSource = "DataSource";
			_shortNameEdit.ColumnUId = new Guid("bf7362a9-6b71-4f68-9dcc-281cc771032a");
			return _shortNameEdit;
		}

		protected override void UpdateDataSource() {
			base.UpdateDataSource();
			DataSource.SchemaUId = new Guid("38f2220e-7085-494d-b4c9-396666b6327b");
			DataSource.ModifiedInSchemaUId = new Guid("82a6e9da-0ea6-4646-87b3-47a238432175");
			DataSourceStructureColumn column = null;
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ae0e45ca-c495-4fe7-a39d-3ab7278e1617");
			if (column != null) {
				column.UId = new Guid("c8057ac8-c22c-4c51-99d2-2d74014d585b");
				column.Name = @"Id";
				column.CreatedInSchemaUId = new Guid("82a6e9da-0ea6-4646-87b3-47a238432175");
				column.ModifiedInSchemaUId = new Guid("82a6e9da-0ea6-4646-87b3-47a238432175");
				column.CreatedInPackageId = Guid.Empty;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("736c30a7-c0ec-4fa9-b034-2552b319b633");
			if (column != null) {
				column.UId = new Guid("36f0e3f9-9204-4282-b340-76cdf804dab0");
				column.Name = @"Name";
				column.CreatedInSchemaUId = new Guid("82a6e9da-0ea6-4646-87b3-47a238432175");
				column.ModifiedInSchemaUId = new Guid("82a6e9da-0ea6-4646-87b3-47a238432175");
				column.CreatedInPackageId = Guid.Empty;
				column.OrderDirection = OrderDirection.Ascending;
				column.OrderPosition = 1;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("e80190a5-03b2-4095-90f7-a193a960adee");
			if (column != null) {
				column.UId = new Guid("e9a39030-dce4-4c33-85e8-1bb10b2b20b7");
				column.Name = @"CreatedOn";
				column.CreatedInSchemaUId = new Guid("82a6e9da-0ea6-4646-87b3-47a238432175");
				column.ModifiedInSchemaUId = new Guid("82a6e9da-0ea6-4646-87b3-47a238432175");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ebf6bb93-8aa6-4a01-900d-c6ea67affe21");
			if (column != null) {
				column.UId = new Guid("9fcd9eb7-6e2c-4ffc-84bf-c5095f35c0b1");
				column.Name = @"CreatedBy";
				column.CreatedInSchemaUId = new Guid("82a6e9da-0ea6-4646-87b3-47a238432175");
				column.ModifiedInSchemaUId = new Guid("82a6e9da-0ea6-4646-87b3-47a238432175");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9928edec-4272-425a-93bb-48743fee4b04");
			if (column != null) {
				column.UId = new Guid("e086626a-c767-456c-bd67-99116b3c77f1");
				column.Name = @"ModifiedOn";
				column.CreatedInSchemaUId = new Guid("82a6e9da-0ea6-4646-87b3-47a238432175");
				column.ModifiedInSchemaUId = new Guid("82a6e9da-0ea6-4646-87b3-47a238432175");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3015559e-cbc6-406a-88af-07f7930be832");
			if (column != null) {
				column.UId = new Guid("fb8222d8-9bcc-43b7-9fdf-15a04f4e9805");
				column.Name = @"ModifiedBy";
				column.CreatedInSchemaUId = new Guid("82a6e9da-0ea6-4646-87b3-47a238432175");
				column.ModifiedInSchemaUId = new Guid("82a6e9da-0ea6-4646-87b3-47a238432175");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9e53fd7c-dde4-4502-a64c-b9e34148108b");
			if (column != null) {
				column.UId = new Guid("70748e29-05d1-4cee-a3d7-77f8ef185d6c");
				column.Name = @"Description";
				column.CreatedInSchemaUId = new Guid("82a6e9da-0ea6-4646-87b3-47a238432175");
				column.ModifiedInSchemaUId = new Guid("82a6e9da-0ea6-4646-87b3-47a238432175");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("4a41775a-ee6f-4bb5-9725-025397d02775");
			if (column != null) {
				column.UId = new Guid("bf7362a9-6b71-4f68-9dcc-281cc771032a");
				column.Name = @"ShortName";
				column.CreatedInSchemaUId = new Guid("82a6e9da-0ea6-4646-87b3-47a238432175");
				column.ModifiedInSchemaUId = new Guid("82a6e9da-0ea6-4646-87b3-47a238432175");
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
			return new UnitEditPageSchemaUserControl();
		}

		public override object Clone() {
			return new UnitEditPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("82a6e9da-0ea6-4646-87b3-47a238432175"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new UnitEditPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: UnitEditPageEventsProcess

	/// <exclude/>
	public class UnitEditPageEventsProcess<TPage> : Terrasoft.WebApp.BaseLookupEditPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.UnitEditPageSchemaUserControl
	{

		public UnitEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "UnitEditPageEventsProcess";
			SchemaUId = new Guid("82a6e9da-0ea6-4646-87b3-47a238432175");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("82a6e9da-0ea6-4646-87b3-47a238432175");
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

	#region Class: UnitEditPageEventsProcess

	/// <exclude/>
	public class UnitEditPageEventsProcess : UnitEditPageEventsProcess<Terrasoft.WebApp.UnitEditPageSchemaUserControl>
	{

		public UnitEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: UnitEditPageSchemaUserControl

	/// <exclude/>
	public partial class UnitEditPageSchemaUserControl : Terrasoft.WebApp.BaseLookupEditPageSchemaUserControl
	{

		#region Properties: Public

		public Terrasoft.UI.WebControls.Controls.TextEdit ShortNameEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.TextEdit)PageContainer.FindPageControl("ShortNameEdit", true);
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
			var process = (UnitEditPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new UnitEditPageEventsProcess(UserConnection);
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
			SchemaName = "UnitEditPage";
		}

		#endregion

	}

	#endregion

	#region Class: UnitEditPageEventsProcessSchema

	/// <exclude/>
	public class UnitEditPageEventsProcessSchema : Terrasoft.WebApp.BaseLookupEditPageEventsProcessSchema
	{

		#region Constructors: Public

		public UnitEditPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public UnitEditPageEventsProcessSchema(UnitEditPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "UnitEditPageEventsProcess";
			UId = new Guid("cd7cd0b4-9a46-4f8a-b2db-b77233458ac8");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
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
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new UnitEditPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("cd7cd0b4-9a46-4f8a-b2db-b77233458ac8"));
		}

		#endregion

	}

	#endregion

}

