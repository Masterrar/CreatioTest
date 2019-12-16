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

	#region Class: QueueObjectEditPageSchema

	/// <exclude/>
	public class QueueObjectEditPageSchema : Terrasoft.WebApp.BaseLookupEditPageSchema
	{

		#region Properties: Public

		private Terrasoft.UI.WebControls.Controls.CheckBox _isClosedQueueCheckBox;
		public Terrasoft.UI.WebControls.Controls.CheckBox IsClosedQueueCheckBox {
			get {
				return _isClosedQueueCheckBox;
			}
		}

		#endregion

		#region Constructors: Public

		public QueueObjectEditPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public QueueObjectEditPageSchema(QueueObjectEditPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateNameEdit() {
			NameEdit.Image = new ControlImage {};
			NameEdit.ColumnUId = new Guid("ea3b3999-c097-42de-a7f7-41cd845b68b1");
			NameEdit.Enabled = false;
			NameEdit.ModifiedInSchemaUId = new Guid("09ab3fa2-b8f9-4a7e-b353-7a665f98e377");
		}

		private void UpdateDescriptionEdit() {
			DescriptionEdit.Hidden = true;
			DescriptionEdit.ModifiedInSchemaUId = new Guid("09ab3fa2-b8f9-4a7e-b353-7a665f98e377");
		}

		private void UpdateCustomControls() {
			CustomControls.Image = new ControlImage {};
			CustomControls.ModifiedInSchemaUId = new Guid("09ab3fa2-b8f9-4a7e-b353-7a665f98e377");
		}

		private void UpdateMainControlLayout() {
			MainControlLayout.Image = new ControlImage {};
			MainControlLayout.ModifiedInSchemaUId = new Guid("09ab3fa2-b8f9-4a7e-b353-7a665f98e377");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("09ab3fa2-b8f9-4a7e-b353-7a665f98e377");
		}

		private void UpdateDesignerModeButton() {
			DesignerModeButton.AjaxEvents.Click.IsProcessEventHandler = true;
			DesignerModeButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("a5bcc8d7-215f-41c5-8f3c-f96f57d48c34"),
				ImageHash = @"682ad9264105b2170afb821fabf80415"
			};
			DesignerModeButton.ModifiedInSchemaUId = new Guid("09ab3fa2-b8f9-4a7e-b353-7a665f98e377");
		}

		private void UpdateOKButton() {
			OKButton.AjaxEvents.Click.IsProcessEventHandler = true;
			OKButton.Image = new ControlImage {};
			OKButton.ModifiedInSchemaUId = new Guid("09ab3fa2-b8f9-4a7e-b353-7a665f98e377");
		}

		private void UpdateCancelButton() {
			CancelButton.AjaxEvents.Click.IsProcessEventHandler = true;
			CancelButton.Image = new ControlImage {};
			CancelButton.ModifiedInSchemaUId = new Guid("09ab3fa2-b8f9-4a7e-b353-7a665f98e377");
		}

		private void UpdateApplyChangesButton() {
			ApplyChangesButton.AjaxEvents.Click.IsProcessEventHandler = true;
			ApplyChangesButton.Image = new ControlImage {};
			ApplyChangesButton.ModifiedInSchemaUId = new Guid("09ab3fa2-b8f9-4a7e-b353-7a665f98e377");
		}

		private void UpdateButtonsControlLayout() {
			ButtonsControlLayout.Image = new ControlImage {};
			ButtonsControlLayout.ModifiedInSchemaUId = new Guid("09ab3fa2-b8f9-4a7e-b353-7a665f98e377");
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("09ab3fa2-b8f9-4a7e-b353-7a665f98e377");
			RealUId = new Guid("09ab3fa2-b8f9-4a7e-b353-7a665f98e377");
			Name = "QueueObjectEditPage";
			ParentSchemaUId = new Guid("8c1db28c-4687-4b3b-b696-c32413d5825e");
			CreatedInPackageId = new Guid("ac7b57d1-4018-44a2-bf70-c6c0ac8d5a0d");
			Width = 400;
			Height = 200;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateQueueObjectEditPageEventsProcessSchema();
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
			MainControlLayout.MoveItem(2, CustomControls);
			CustomControls.InsertItem(0, CreateIsClosedQueueCheckBox());
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

		protected virtual EmbeddedProcessSchema CreateQueueObjectEditPageEventsProcessSchema() {
			var schema = new QueueObjectEditPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.CheckBox CreateIsClosedQueueCheckBox() {
			_isClosedQueueCheckBox = new Terrasoft.UI.WebControls.Controls.CheckBox();
			_isClosedQueueCheckBox.UId = new Guid("bd1f97b4-bb83-44a6-81e3-11de08c197eb");
			_isClosedQueueCheckBox.Name = "IsClosedQueueCheckBox";
			_isClosedQueueCheckBox.CreatedInSchemaUId = new Guid("09ab3fa2-b8f9-4a7e-b353-7a665f98e377");
			_isClosedQueueCheckBox.ModifiedInSchemaUId = new Guid("09ab3fa2-b8f9-4a7e-b353-7a665f98e377");
			_isClosedQueueCheckBox.CreatedInPackageId = new Guid("ac7b57d1-4018-44a2-bf70-c6c0ac8d5a0d");
			_isClosedQueueCheckBox.Tag = "";
			_isClosedQueueCheckBox.CaptionColor = System.Drawing.Color.FromArgb(0,2,77,156);
			_isClosedQueueCheckBox.Width = System.Web.UI.WebControls.Unit.Percentage(100);
			_isClosedQueueCheckBox.DataSource = "DataSource";
			_isClosedQueueCheckBox.ColumnUId = new Guid("f18fadb7-ab06-49bb-8f67-405acb200eac");
			return _isClosedQueueCheckBox;
		}

		protected override void UpdateDataSource() {
			base.UpdateDataSource();
			DataSource.SchemaUId = new Guid("3117ccf2-594f-437b-8ce9-2a97314af997");
			DataSource.ModifiedInSchemaUId = new Guid("09ab3fa2-b8f9-4a7e-b353-7a665f98e377");
			DataSourceStructureColumn column = null;
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ae0e45ca-c495-4fe7-a39d-3ab7278e1617");
			if (column != null) {
				column.UId = new Guid("3e664c62-5d4a-421e-ac9e-686e83926434");
				column.Name = @"Id";
				column.CreatedInSchemaUId = new Guid("09ab3fa2-b8f9-4a7e-b353-7a665f98e377");
				column.ModifiedInSchemaUId = new Guid("09ab3fa2-b8f9-4a7e-b353-7a665f98e377");
				column.CreatedInPackageId = Guid.Empty;
				column.IsAlwaysSelect = true;
				column.Required = true;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("e80190a5-03b2-4095-90f7-a193a960adee");
			if (column != null) {
				column.UId = new Guid("75a94346-f340-43c1-ac19-693c43c2a8ca");
				column.Name = @"CreatedOn";
				column.CreatedInSchemaUId = new Guid("09ab3fa2-b8f9-4a7e-b353-7a665f98e377");
				column.ModifiedInSchemaUId = new Guid("09ab3fa2-b8f9-4a7e-b353-7a665f98e377");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("ebf6bb93-8aa6-4a01-900d-c6ea67affe21");
			if (column != null) {
				column.UId = new Guid("973670ca-3eab-40dd-aed1-ac9eab8e9ea3");
				column.Name = @"CreatedBy";
				column.CreatedInSchemaUId = new Guid("09ab3fa2-b8f9-4a7e-b353-7a665f98e377");
				column.ModifiedInSchemaUId = new Guid("09ab3fa2-b8f9-4a7e-b353-7a665f98e377");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("9928edec-4272-425a-93bb-48743fee4b04");
			if (column != null) {
				column.UId = new Guid("9345abf5-0c4f-4862-aad6-315dbac47060");
				column.Name = @"ModifiedOn";
				column.CreatedInSchemaUId = new Guid("09ab3fa2-b8f9-4a7e-b353-7a665f98e377");
				column.ModifiedInSchemaUId = new Guid("09ab3fa2-b8f9-4a7e-b353-7a665f98e377");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3015559e-cbc6-406a-88af-07f7930be832");
			if (column != null) {
				column.UId = new Guid("51ebd9f7-7d1b-4d89-9b51-90d96bbe2191");
				column.Name = @"ModifiedBy";
				column.CreatedInSchemaUId = new Guid("09ab3fa2-b8f9-4a7e-b353-7a665f98e377");
				column.ModifiedInSchemaUId = new Guid("09ab3fa2-b8f9-4a7e-b353-7a665f98e377");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3fabd836-6a53-4d8d-9069-6df88d9dae1e");
			if (column != null) {
				column.UId = new Guid("56d4c990-09a5-464a-a21f-92976e91913c");
				column.Name = @"ProcessListeners";
				column.CreatedInSchemaUId = new Guid("09ab3fa2-b8f9-4a7e-b353-7a665f98e377");
				column.ModifiedInSchemaUId = new Guid("09ab3fa2-b8f9-4a7e-b353-7a665f98e377");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("3d9651ba-a619-4e15-bea4-88c03f624f40");
			if (column != null) {
				column.UId = new Guid("0503d253-07e7-4d03-827e-77476309d2eb");
				column.Name = @"EntitySchemaUId";
				column.CreatedInSchemaUId = new Guid("09ab3fa2-b8f9-4a7e-b353-7a665f98e377");
				column.ModifiedInSchemaUId = new Guid("09ab3fa2-b8f9-4a7e-b353-7a665f98e377");
				column.CreatedInPackageId = Guid.Empty;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("744e6a8f-4792-4153-a7af-d913c8aab620");
			if (column != null) {
				column.UId = new Guid("ea3b3999-c097-42de-a7f7-41cd845b68b1");
				column.Name = @"EntitySchemaCaption";
				column.CreatedInSchemaUId = new Guid("09ab3fa2-b8f9-4a7e-b353-7a665f98e377");
				column.ModifiedInSchemaUId = new Guid("09ab3fa2-b8f9-4a7e-b353-7a665f98e377");
				column.CreatedInPackageId = Guid.Empty;
				column.OrderDirection = OrderDirection.Ascending;
				column.OrderPosition = 1;
			}
			column = DataSource.DefStructure.TryAddColumnByMetaPath("4bbc9bbf-2d29-4b8f-a9b2-a57deb7f4587");
			if (column != null) {
				column.UId = new Guid("f18fadb7-ab06-49bb-8f67-405acb200eac");
				column.Name = @"IsClosedQueue";
				column.CreatedInSchemaUId = new Guid("09ab3fa2-b8f9-4a7e-b353-7a665f98e377");
				column.ModifiedInSchemaUId = new Guid("09ab3fa2-b8f9-4a7e-b353-7a665f98e377");
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
			return new QueueObjectEditPageSchemaUserControl();
		}

		public override object Clone() {
			return new QueueObjectEditPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("09ab3fa2-b8f9-4a7e-b353-7a665f98e377"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new QueueObjectEditPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: QueueObjectEditPageEventsProcess

	/// <exclude/>
	public class QueueObjectEditPageEventsProcess<TPage> : Terrasoft.WebApp.BaseLookupEditPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.QueueObjectEditPageSchemaUserControl
	{

		public QueueObjectEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "QueueObjectEditPageEventsProcess";
			SchemaUId = new Guid("09ab3fa2-b8f9-4a7e-b353-7a665f98e377");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("09ab3fa2-b8f9-4a7e-b353-7a665f98e377");
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

	#region Class: QueueObjectEditPageEventsProcess

	/// <exclude/>
	public class QueueObjectEditPageEventsProcess : QueueObjectEditPageEventsProcess<Terrasoft.WebApp.QueueObjectEditPageSchemaUserControl>
	{

		public QueueObjectEditPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: QueueObjectEditPageSchemaUserControl

	/// <exclude/>
	public partial class QueueObjectEditPageSchemaUserControl : Terrasoft.WebApp.BaseLookupEditPageSchemaUserControl
	{

		#region Properties: Public

		public Terrasoft.UI.WebControls.Controls.CheckBox IsClosedQueueCheckBox {
			get {
				return (Terrasoft.UI.WebControls.Controls.CheckBox)PageContainer.FindPageControl("IsClosedQueueCheckBox", true);
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
			var process = (QueueObjectEditPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new QueueObjectEditPageEventsProcess(UserConnection);
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
			SchemaName = "QueueObjectEditPage";
		}

		#endregion

	}

	#endregion

	#region Class: QueueObjectEditPageEventsProcessSchema

	/// <exclude/>
	public class QueueObjectEditPageEventsProcessSchema : Terrasoft.WebApp.BaseLookupEditPageEventsProcessSchema
	{

		#region Constructors: Public

		public QueueObjectEditPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public QueueObjectEditPageEventsProcessSchema(QueueObjectEditPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "QueueObjectEditPageEventsProcess";
			UId = new Guid("4f427681-abf0-4d2f-9be3-4e227d9b627b");
			CreatedInPackageId = new Guid("ac7b57d1-4018-44a2-bf70-c6c0ac8d5a0d");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
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
			return new QueueObjectEditPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("4f427681-abf0-4d2f-9be3-4e227d9b627b"));
		}

		#endregion

	}

	#endregion

}

