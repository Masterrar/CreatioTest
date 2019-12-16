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

	#region Class: CaseOriginEditPageSchema

	/// <exclude/>
	public class CaseOriginEditPageSchema : Terrasoft.WebApp.BaseImageLookupEditPageSchema
	{

		#region Constructors: Public

		public CaseOriginEditPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public CaseOriginEditPageSchema(CaseOriginEditPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateNameEdit() {
			NameEdit.AjaxEvents.Change.IsProcessEventHandler = true;
			NameEdit.Image = new ControlImage {};
			NameEdit.ColumnUId = new Guid("4c5f74ff-d6b2-4503-b520-c9251c16b50f");
			NameEdit.ModifiedInSchemaUId = new Guid("9297fc98-2051-4cb4-b0b5-567ce182d8a6");
		}

		private void UpdateDescriptionEdit() {
			DescriptionEdit.ColumnUId = new Guid("b71b6cdc-cb67-48e3-92d6-99fef0668865");
			DescriptionEdit.ModifiedInSchemaUId = new Guid("9297fc98-2051-4cb4-b0b5-567ce182d8a6");
		}

		private void UpdateImageEdit() {
			ImageEdit.AjaxEvents.Change.IsProcessEventHandler = true;
			ImageEdit.Image = new ControlImage {};
			ImageEdit.ModifiedInSchemaUId = new Guid("9297fc98-2051-4cb4-b0b5-567ce182d8a6");
		}

		private void UpdateImageBox() {
			ImageBox.Image = new ControlImage {};
			ImageBox.ModifiedInSchemaUId = new Guid("9297fc98-2051-4cb4-b0b5-567ce182d8a6");
		}

		private void UpdateCustomControls() {
			CustomControls.Image = new ControlImage {};
			CustomControls.ModifiedInSchemaUId = new Guid("9297fc98-2051-4cb4-b0b5-567ce182d8a6");
		}

		private void UpdateMainControlLayout() {
			MainControlLayout.Image = new ControlImage {};
			MainControlLayout.ModifiedInSchemaUId = new Guid("9297fc98-2051-4cb4-b0b5-567ce182d8a6");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("9297fc98-2051-4cb4-b0b5-567ce182d8a6");
		}

		private void UpdateDesignerModeButton() {
			DesignerModeButton.AjaxEvents.Click.IsProcessEventHandler = true;
			DesignerModeButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("a5bcc8d7-215f-41c5-8f3c-f96f57d48c34"),
				ImageHash = @"682ad9264105b2170afb821fabf80415"
			};
			DesignerModeButton.ModifiedInSchemaUId = new Guid("9297fc98-2051-4cb4-b0b5-567ce182d8a6");
		}

		private void UpdateOKButton() {
			OKButton.AjaxEvents.Click.IsProcessEventHandler = true;
			OKButton.Image = new ControlImage {};
			OKButton.ModifiedInSchemaUId = new Guid("9297fc98-2051-4cb4-b0b5-567ce182d8a6");
		}

		private void UpdateCancelButton() {
			CancelButton.AjaxEvents.Click.IsProcessEventHandler = true;
			CancelButton.Image = new ControlImage {};
			CancelButton.ModifiedInSchemaUId = new Guid("9297fc98-2051-4cb4-b0b5-567ce182d8a6");
		}

		private void UpdateApplyChangesButton() {
			ApplyChangesButton.AjaxEvents.Click.IsProcessEventHandler = true;
			ApplyChangesButton.Image = new ControlImage {};
			ApplyChangesButton.ModifiedInSchemaUId = new Guid("9297fc98-2051-4cb4-b0b5-567ce182d8a6");
		}

		private void UpdateButtonsControlLayout() {
			ButtonsControlLayout.Image = new ControlImage {};
			ButtonsControlLayout.ModifiedInSchemaUId = new Guid("9297fc98-2051-4cb4-b0b5-567ce182d8a6");
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("9297fc98-2051-4cb4-b0b5-567ce182d8a6");
			RealUId = new Guid("9297fc98-2051-4cb4-b0b5-567ce182d8a6");
			Name = "CaseOriginEditPage";
			ParentSchemaUId = new Guid("f889f5ff-356c-41c7-bb8e-a37b1132f065");
			CreatedInPackageId = new Guid("475d20ed-7132-487d-a9d1-4fadc0bc9049");
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateCaseOriginEditPageEventsProcessSchema();
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
			MainControlLayout.MoveItem(1, DescriptionEdit);
			MainControlLayout.MoveItem(2, ImageEdit);
			MainControlLayout.MoveItem(3, ImageBox);
			MainControlLayout.MoveItem(4, CustomControls);
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

		protected virtual EmbeddedProcessSchema CreateCaseOriginEditPageEventsProcessSchema() {
			var schema = new CaseOriginEditPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected override void UpdateDataSource() {
			base.UpdateDataSource();
			DataSource.SchemaUId = new Guid("b17869fe-43f9-487a-af82-b7626f1fc810");
			DataSource.ModifiedInSchemaUId = new Guid("9297fc98-2051-4cb4-b0b5-567ce182d8a6");
			DataSourceStructureColumn column = null;
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ae0e45ca-c495-4fe7-a39d-3ab7278e1617");
			if (column != null) {
				column.UId = new Guid("5895eed1-2fa2-48bf-8275-a68cc43a629d");
				column.Name = @"Id";
				column.CreatedInSchemaUId = new Guid("9297fc98-2051-4cb4-b0b5-567ce182d8a6");
				column.ModifiedInSchemaUId = new Guid("9297fc98-2051-4cb4-b0b5-567ce182d8a6");
				column.CreatedInPackageId = Guid.Empty;
				column.IsAlwaysSelect = true;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("e80190a5-03b2-4095-90f7-a193a960adee");
			if (column != null) {
				column.UId = new Guid("8a4b0db8-2f2a-4454-805b-7bb71f627741");
				column.Name = @"CreatedOn";
				column.CreatedInSchemaUId = new Guid("9297fc98-2051-4cb4-b0b5-567ce182d8a6");
				column.ModifiedInSchemaUId = new Guid("9297fc98-2051-4cb4-b0b5-567ce182d8a6");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ebf6bb93-8aa6-4a01-900d-c6ea67affe21");
			if (column != null) {
				column.UId = new Guid("34f8451b-55a9-431e-a130-fc84c9eb5b86");
				column.Name = @"CreatedBy";
				column.CreatedInSchemaUId = new Guid("9297fc98-2051-4cb4-b0b5-567ce182d8a6");
				column.ModifiedInSchemaUId = new Guid("9297fc98-2051-4cb4-b0b5-567ce182d8a6");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9928edec-4272-425a-93bb-48743fee4b04");
			if (column != null) {
				column.UId = new Guid("c073e6ec-726d-49c9-99ad-a60c3809729b");
				column.Name = @"ModifiedOn";
				column.CreatedInSchemaUId = new Guid("9297fc98-2051-4cb4-b0b5-567ce182d8a6");
				column.ModifiedInSchemaUId = new Guid("9297fc98-2051-4cb4-b0b5-567ce182d8a6");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3015559e-cbc6-406a-88af-07f7930be832");
			if (column != null) {
				column.UId = new Guid("4a01b4a9-ecbd-4491-98f7-2c6fe2f8d665");
				column.Name = @"ModifiedBy";
				column.CreatedInSchemaUId = new Guid("9297fc98-2051-4cb4-b0b5-567ce182d8a6");
				column.ModifiedInSchemaUId = new Guid("9297fc98-2051-4cb4-b0b5-567ce182d8a6");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("736c30a7-c0ec-4fa9-b034-2552b319b633");
			if (column != null) {
				column.UId = new Guid("4c5f74ff-d6b2-4503-b520-c9251c16b50f");
				column.Name = @"Name";
				column.CreatedInSchemaUId = new Guid("9297fc98-2051-4cb4-b0b5-567ce182d8a6");
				column.ModifiedInSchemaUId = new Guid("9297fc98-2051-4cb4-b0b5-567ce182d8a6");
				column.CreatedInPackageId = Guid.Empty;
				column.OrderDirection = OrderDirection.Ascending;
				column.OrderPosition = 1;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9e53fd7c-dde4-4502-a64c-b9e34148108b");
			if (column != null) {
				column.UId = new Guid("b71b6cdc-cb67-48e3-92d6-99fef0668865");
				column.Name = @"Description";
				column.CreatedInSchemaUId = new Guid("9297fc98-2051-4cb4-b0b5-567ce182d8a6");
				column.ModifiedInSchemaUId = new Guid("9297fc98-2051-4cb4-b0b5-567ce182d8a6");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3fabd836-6a53-4d8d-9069-6df88d9dae1e");
			if (column != null) {
				column.UId = new Guid("c8d5ab6f-c5d7-4291-8f66-9be4b2d7dc35");
				column.Name = @"ProcessListeners";
				column.CreatedInSchemaUId = new Guid("9297fc98-2051-4cb4-b0b5-567ce182d8a6");
				column.ModifiedInSchemaUId = new Guid("9297fc98-2051-4cb4-b0b5-567ce182d8a6");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("c10d1607-c207-4070-add9-d683ac6f0b56");
			if (column != null) {
				column.UId = new Guid("d2462ccc-32b2-4221-8ed8-7d6283ca8670");
				column.Name = @"Image";
				column.CreatedInSchemaUId = new Guid("9297fc98-2051-4cb4-b0b5-567ce182d8a6");
				column.ModifiedInSchemaUId = new Guid("9297fc98-2051-4cb4-b0b5-567ce182d8a6");
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
			return new CaseOriginEditPageSchemaUserControl();
		}

		public override object Clone() {
			return new CaseOriginEditPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("9297fc98-2051-4cb4-b0b5-567ce182d8a6"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new CaseOriginEditPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: CaseOriginEditPageEventsProcess

	/// <exclude/>
	public class CaseOriginEditPageEventsProcess<TPage> : Terrasoft.WebApp.BaseImageLookupEditPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.CaseOriginEditPageSchemaUserControl
	{

		public CaseOriginEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "CaseOriginEditPageEventsProcess";
			SchemaUId = new Guid("9297fc98-2051-4cb4-b0b5-567ce182d8a6");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("9297fc98-2051-4cb4-b0b5-567ce182d8a6");
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

	#region Class: CaseOriginEditPageEventsProcess

	/// <exclude/>
	public class CaseOriginEditPageEventsProcess : CaseOriginEditPageEventsProcess<Terrasoft.WebApp.CaseOriginEditPageSchemaUserControl>
	{

		public CaseOriginEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: CaseOriginEditPageSchemaUserControl

	/// <exclude/>
	public partial class CaseOriginEditPageSchemaUserControl : Terrasoft.WebApp.BaseImageLookupEditPageSchemaUserControl
	{

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
			var process = (CaseOriginEditPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new CaseOriginEditPageEventsProcess(UserConnection);
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
			SchemaName = "CaseOriginEditPage";
		}

		#endregion

	}

	#endregion

	#region Class: CaseOriginEditPageEventsProcessSchema

	/// <exclude/>
	public class CaseOriginEditPageEventsProcessSchema : Terrasoft.WebApp.BaseImageLookupEditPageEventsProcessSchema
	{

		#region Constructors: Public

		public CaseOriginEditPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public CaseOriginEditPageEventsProcessSchema(CaseOriginEditPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "CaseOriginEditPageEventsProcess";
			UId = new Guid("2a15a723-2cc1-4c28-bebf-2ac11989d328");
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
			return new CaseOriginEditPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("2a15a723-2cc1-4c28-bebf-2ac11989d328"));
		}

		#endregion

	}

	#endregion

}

