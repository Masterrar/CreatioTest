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

	#region Class: ProblemStatusEditPageSchema

	/// <exclude/>
	public class ProblemStatusEditPageSchema : Terrasoft.WebApp.BaseLookupEditPageSchema
	{

		#region Properties: Public

		private Terrasoft.UI.WebControls.Controls.CheckBox _isFinalEdit;
		public Terrasoft.UI.WebControls.Controls.CheckBox IsFinalEdit {
			get {
				return _isFinalEdit;
			}
		}

		#endregion

		#region Constructors: Public

		public ProblemStatusEditPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public ProblemStatusEditPageSchema(ProblemStatusEditPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateNameEdit() {
			NameEdit.Image = new ControlImage {};
			NameEdit.ColumnUId = new Guid("aa6f042c-f6cf-4ac0-8ce3-16febe37c21a");
			NameEdit.ModifiedInSchemaUId = new Guid("f07de13c-7eca-4cab-97c9-7ee787b78ae8");
		}

		private void UpdateDescriptionEdit() {
			DescriptionEdit.ColumnUId = new Guid("bc42a671-470f-410c-8db4-b2806d86c8f1");
			DescriptionEdit.ModifiedInSchemaUId = new Guid("f07de13c-7eca-4cab-97c9-7ee787b78ae8");
		}

		private void UpdateCustomControls() {
			CustomControls.Image = new ControlImage {};
			CustomControls.ModifiedInSchemaUId = new Guid("f07de13c-7eca-4cab-97c9-7ee787b78ae8");
		}

		private void UpdateMainControlLayout() {
			MainControlLayout.Image = new ControlImage {};
			MainControlLayout.ModifiedInSchemaUId = new Guid("f07de13c-7eca-4cab-97c9-7ee787b78ae8");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("f07de13c-7eca-4cab-97c9-7ee787b78ae8");
		}

		private void UpdateDesignerModeButton() {
			DesignerModeButton.AjaxEvents.Click.IsProcessEventHandler = true;
			DesignerModeButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("a5bcc8d7-215f-41c5-8f3c-f96f57d48c34"),
				ImageHash = @"682ad9264105b2170afb821fabf80415"
			};
			DesignerModeButton.ModifiedInSchemaUId = new Guid("f07de13c-7eca-4cab-97c9-7ee787b78ae8");
		}

		private void UpdateOKButton() {
			OKButton.AjaxEvents.Click.IsProcessEventHandler = true;
			OKButton.Image = new ControlImage {};
			OKButton.ModifiedInSchemaUId = new Guid("f07de13c-7eca-4cab-97c9-7ee787b78ae8");
		}

		private void UpdateCancelButton() {
			CancelButton.AjaxEvents.Click.IsProcessEventHandler = true;
			CancelButton.Image = new ControlImage {};
			CancelButton.ModifiedInSchemaUId = new Guid("f07de13c-7eca-4cab-97c9-7ee787b78ae8");
		}

		private void UpdateApplyChangesButton() {
			ApplyChangesButton.AjaxEvents.Click.IsProcessEventHandler = true;
			ApplyChangesButton.Image = new ControlImage {};
			ApplyChangesButton.ModifiedInSchemaUId = new Guid("f07de13c-7eca-4cab-97c9-7ee787b78ae8");
		}

		private void UpdateButtonsControlLayout() {
			ButtonsControlLayout.Image = new ControlImage {};
			ButtonsControlLayout.ModifiedInSchemaUId = new Guid("f07de13c-7eca-4cab-97c9-7ee787b78ae8");
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f07de13c-7eca-4cab-97c9-7ee787b78ae8");
			RealUId = new Guid("f07de13c-7eca-4cab-97c9-7ee787b78ae8");
			Name = "ProblemStatusEditPage";
			ParentSchemaUId = new Guid("8c1db28c-4687-4b3b-b696-c32413d5825e");
			CreatedInPackageId = new Guid("305fcfca-4160-4398-90a9-d5e84be0ae12");
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateProblemStatusEditPageEventsProcessSchema();
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

		protected virtual EmbeddedProcessSchema CreateProblemStatusEditPageEventsProcessSchema() {
			var schema = new ProblemStatusEditPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.CheckBox CreateIsFinalEdit() {
			_isFinalEdit = new Terrasoft.UI.WebControls.Controls.CheckBox();
			_isFinalEdit.UId = new Guid("f2193d05-1e14-4ab7-9270-cfc1bbbb1d81");
			_isFinalEdit.Name = "IsFinalEdit";
			_isFinalEdit.CreatedInSchemaUId = new Guid("f07de13c-7eca-4cab-97c9-7ee787b78ae8");
			_isFinalEdit.ModifiedInSchemaUId = new Guid("f07de13c-7eca-4cab-97c9-7ee787b78ae8");
			_isFinalEdit.CreatedInPackageId = new Guid("305fcfca-4160-4398-90a9-d5e84be0ae12");
			_isFinalEdit.Tag = "";
			_isFinalEdit.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_isFinalEdit.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_isFinalEdit.CaptionPosition = Terrasoft.UI.WebControls.Controls.CheckBoxBaseCaptionPosition.Left;
			_isFinalEdit.DataSource = "DataSource";
			_isFinalEdit.ColumnUId = new Guid("acf7d1d3-59b0-4f83-9ba2-ebba5be5d15b");
			return _isFinalEdit;
		}

		protected override void UpdateDataSource() {
			base.UpdateDataSource();
			DataSource.SchemaUId = new Guid("221b40be-b93d-4ad7-be6f-f4c7b24552eb");
			DataSource.ModifiedInSchemaUId = new Guid("f07de13c-7eca-4cab-97c9-7ee787b78ae8");
			DataSourceStructureColumn column = null;
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ae0e45ca-c495-4fe7-a39d-3ab7278e1617");
			if (column != null) {
				column.UId = new Guid("03c6c584-da6d-4920-910f-37b890b969e8");
				column.Name = @"Id";
				column.CreatedInSchemaUId = new Guid("f07de13c-7eca-4cab-97c9-7ee787b78ae8");
				column.ModifiedInSchemaUId = new Guid("f07de13c-7eca-4cab-97c9-7ee787b78ae8");
				column.CreatedInPackageId = Guid.Empty;
				column.IsAlwaysSelect = true;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("736c30a7-c0ec-4fa9-b034-2552b319b633");
			if (column != null) {
				column.UId = new Guid("aa6f042c-f6cf-4ac0-8ce3-16febe37c21a");
				column.Name = @"Name";
				column.CreatedInSchemaUId = new Guid("f07de13c-7eca-4cab-97c9-7ee787b78ae8");
				column.ModifiedInSchemaUId = new Guid("f07de13c-7eca-4cab-97c9-7ee787b78ae8");
				column.CreatedInPackageId = Guid.Empty;
				column.OrderDirection = OrderDirection.Ascending;
				column.OrderPosition = 1;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("e80190a5-03b2-4095-90f7-a193a960adee");
			if (column != null) {
				column.UId = new Guid("4f89bddd-e7a4-4f28-aabe-de67f0dceb48");
				column.Name = @"CreatedOn";
				column.CreatedInSchemaUId = new Guid("f07de13c-7eca-4cab-97c9-7ee787b78ae8");
				column.ModifiedInSchemaUId = new Guid("f07de13c-7eca-4cab-97c9-7ee787b78ae8");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ebf6bb93-8aa6-4a01-900d-c6ea67affe21");
			if (column != null) {
				column.UId = new Guid("3bbeeccf-f33f-4ba6-b512-d6242cafc08a");
				column.Name = @"CreatedBy";
				column.CreatedInSchemaUId = new Guid("f07de13c-7eca-4cab-97c9-7ee787b78ae8");
				column.ModifiedInSchemaUId = new Guid("f07de13c-7eca-4cab-97c9-7ee787b78ae8");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9928edec-4272-425a-93bb-48743fee4b04");
			if (column != null) {
				column.UId = new Guid("5be0a09e-88a1-41ad-8558-2f50e4f3f26c");
				column.Name = @"ModifiedOn";
				column.CreatedInSchemaUId = new Guid("f07de13c-7eca-4cab-97c9-7ee787b78ae8");
				column.ModifiedInSchemaUId = new Guid("f07de13c-7eca-4cab-97c9-7ee787b78ae8");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3015559e-cbc6-406a-88af-07f7930be832");
			if (column != null) {
				column.UId = new Guid("8730dcd2-6ee6-4325-874f-55bb7b0dd62b");
				column.Name = @"ModifiedBy";
				column.CreatedInSchemaUId = new Guid("f07de13c-7eca-4cab-97c9-7ee787b78ae8");
				column.ModifiedInSchemaUId = new Guid("f07de13c-7eca-4cab-97c9-7ee787b78ae8");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3fabd836-6a53-4d8d-9069-6df88d9dae1e");
			if (column != null) {
				column.UId = new Guid("c579f525-65e3-4703-87bb-987dfa140d24");
				column.Name = @"ProcessListeners";
				column.CreatedInSchemaUId = new Guid("f07de13c-7eca-4cab-97c9-7ee787b78ae8");
				column.ModifiedInSchemaUId = new Guid("f07de13c-7eca-4cab-97c9-7ee787b78ae8");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9e53fd7c-dde4-4502-a64c-b9e34148108b");
			if (column != null) {
				column.UId = new Guid("bc42a671-470f-410c-8db4-b2806d86c8f1");
				column.Name = @"Description";
				column.CreatedInSchemaUId = new Guid("f07de13c-7eca-4cab-97c9-7ee787b78ae8");
				column.ModifiedInSchemaUId = new Guid("f07de13c-7eca-4cab-97c9-7ee787b78ae8");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("8f73370b-10be-4aa8-944b-af461bb82c47");
			if (column != null) {
				column.UId = new Guid("acf7d1d3-59b0-4f83-9ba2-ebba5be5d15b");
				column.Name = @"IsFinal";
				column.CreatedInSchemaUId = new Guid("f07de13c-7eca-4cab-97c9-7ee787b78ae8");
				column.ModifiedInSchemaUId = new Guid("f07de13c-7eca-4cab-97c9-7ee787b78ae8");
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
			return new ProblemStatusEditPageSchemaUserControl();
		}

		public override object Clone() {
			return new ProblemStatusEditPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f07de13c-7eca-4cab-97c9-7ee787b78ae8"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new ProblemStatusEditPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: ProblemStatusEditPageEventsProcess

	/// <exclude/>
	public class ProblemStatusEditPageEventsProcess<TPage> : Terrasoft.WebApp.BaseLookupEditPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.ProblemStatusEditPageSchemaUserControl
	{

		public ProblemStatusEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ProblemStatusEditPageEventsProcess";
			SchemaUId = new Guid("f07de13c-7eca-4cab-97c9-7ee787b78ae8");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("f07de13c-7eca-4cab-97c9-7ee787b78ae8");
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

	#region Class: ProblemStatusEditPageEventsProcess

	/// <exclude/>
	public class ProblemStatusEditPageEventsProcess : ProblemStatusEditPageEventsProcess<Terrasoft.WebApp.ProblemStatusEditPageSchemaUserControl>
	{

		public ProblemStatusEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: ProblemStatusEditPageSchemaUserControl

	/// <exclude/>
	public partial class ProblemStatusEditPageSchemaUserControl : Terrasoft.WebApp.BaseLookupEditPageSchemaUserControl
	{

		#region Properties: Public

		public Terrasoft.UI.WebControls.Controls.CheckBox IsFinalEdit {
			get {
				return (Terrasoft.UI.WebControls.Controls.CheckBox)PageContainer.FindPageControl("IsFinalEdit", true);
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
			var process = (ProblemStatusEditPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new ProblemStatusEditPageEventsProcess(UserConnection);
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
			SchemaName = "ProblemStatusEditPage";
		}

		#endregion

	}

	#endregion

	#region Class: ProblemStatusEditPageEventsProcessSchema

	/// <exclude/>
	public class ProblemStatusEditPageEventsProcessSchema : Terrasoft.WebApp.BaseLookupEditPageEventsProcessSchema
	{

		#region Constructors: Public

		public ProblemStatusEditPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public ProblemStatusEditPageEventsProcessSchema(ProblemStatusEditPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "ProblemStatusEditPageEventsProcess";
			UId = new Guid("ac21736f-ac75-4843-a731-6445f9273c39");
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
			return new ProblemStatusEditPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ac21736f-ac75-4843-a731-6445f9273c39"));
		}

		#endregion

	}

	#endregion

}

