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
	using System.Linq;
	using System.Text;
	using System.Threading;
	using System.Web.UI.WebControls;
	using Terrasoft.Common;
	using Terrasoft.Common.Json;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;
	using Terrasoft.Core.Store;
	using Terrasoft.Reports;
	using Terrasoft.UI.WebControls;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities;
	using Terrasoft.UI.WebControls.Utilities.Json.Converters;
	using TSConfiguration = Terrasoft.Configuration;
	using TSWebControls = Terrasoft.UI.WebControls;
	using web = System.Web;
	using WebControls = Terrasoft.UI.WebControls.Controls;

	#region Class: SysModuleReportsGridPageSchema

	/// <exclude/>
	public class SysModuleReportsGridPageSchema : Terrasoft.WebApp.SysModuleReportsGridPage_Base_TerrasoftSchema
	{

		#region Constructors: Public

		public SysModuleReportsGridPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public SysModuleReportsGridPageSchema(SysModuleReportsGridPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateAddButton() {
			AddButton.Image = new ControlImage {};
			AddButton.ModifiedInSchemaUId = new Guid("d51435c2-7f90-4d2e-8cf4-9f24e1192d39");
		}

		private void UpdateCopyButton() {
			CopyButton.Image = new ControlImage {};
			CopyButton.ModifiedInSchemaUId = new Guid("d51435c2-7f90-4d2e-8cf4-9f24e1192d39");
		}

		private void UpdateEditButton() {
			EditButton.Image = new ControlImage {};
			EditButton.ModifiedInSchemaUId = new Guid("d51435c2-7f90-4d2e-8cf4-9f24e1192d39");
		}

		private void UpdateDeleteButton() {
			DeleteButton.Image = new ControlImage {};
			DeleteButton.ModifiedInSchemaUId = new Guid("d51435c2-7f90-4d2e-8cf4-9f24e1192d39");
		}

		private void UpdateSaveToFileButton() {
			SaveToFileButton.AjaxEvents.Click.IsProcessEventHandler = true;
			SaveToFileButton.Image = new ControlImage {};
			SaveToFileButton.ModifiedInSchemaUId = new Guid("d51435c2-7f90-4d2e-8cf4-9f24e1192d39");
		}

		private void UpdateActionButton() {
			ActionButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73"),
				ImageHash = @"388b646e5dc8d8c8203aeeb3f25b057e"
			};
			ActionButton.ModifiedInSchemaUId = new Guid("d51435c2-7f90-4d2e-8cf4-9f24e1192d39");
		}

		private void UpdatePrintButton() {
			PrintButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("96384a2c-cd4f-4c29-acda-49d24ea3ef73"),
				ImageHash = @"6e713359f7daa6706f06f1a8f5f065f7"
			};
			PrintButton.ModifiedInSchemaUId = new Guid("d51435c2-7f90-4d2e-8cf4-9f24e1192d39");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("d51435c2-7f90-4d2e-8cf4-9f24e1192d39");
		}

		private void UpdateFakeSaveToFileButton() {
			FakeSaveToFileButton.AjaxEvents.Click.IsProcessEventHandler = true;
			FakeSaveToFileButton.Image = new ControlImage {};
			FakeSaveToFileButton.ModifiedInSchemaUId = new Guid("d51435c2-7f90-4d2e-8cf4-9f24e1192d39");
		}

		private void UpdateButtonsControlLayout() {
			ButtonsControlLayout.Image = new ControlImage {};
			ButtonsControlLayout.ModifiedInSchemaUId = new Guid("d51435c2-7f90-4d2e-8cf4-9f24e1192d39");
		}

		private void UpdateSendEmailMenuItem() {
			SendEmailMenuItem.Image = new ControlImage {};
			SendEmailMenuItem.ModifiedInSchemaUId = new Guid("d51435c2-7f90-4d2e-8cf4-9f24e1192d39");
		}

		private void UpdateSendTemplateEmailMenuItem() {
			SendTemplateEmailMenuItem.Image = new ControlImage {};
			SendTemplateEmailMenuItem.ModifiedInSchemaUId = new Guid("d51435c2-7f90-4d2e-8cf4-9f24e1192d39");
		}

		private void UpdateCallMenuItem() {
			CallMenuItem.AjaxEvents.PrepareMenu.IsProcessEventHandler = true;
			CallMenuItem.Image = new ControlImage {};
			CallMenuItem.ModifiedInSchemaUId = new Guid("d51435c2-7f90-4d2e-8cf4-9f24e1192d39");
		}

		private void UpdateShowChangelogMenuItem() {
			ShowChangelogMenuItem.AjaxEvents.Click.IsProcessEventHandler = true;
			ShowChangelogMenuItem.Image = new ControlImage {};
			ShowChangelogMenuItem.ModifiedInSchemaUId = new Guid("d51435c2-7f90-4d2e-8cf4-9f24e1192d39");
		}

		private void UpdateTreeGrid() {
			TreeGrid.AjaxEvents.ContextMenu.IsProcessEventHandler = true;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("d51435c2-7f90-4d2e-8cf4-9f24e1192d39");
			Name = "SysModuleReportsGridPage";
			ParentSchemaUId = new Guid("5b320a95-d018-4807-ac8c-f5b4e6a3965e");
			CreatedInPackageId = new Guid("bcd7b40a-afa2-4631-8983-51d02c873b88");
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateSysModuleReportsGridPageEventsProcessSchema();
		}

		protected override void InitializeControls() {
			base.InitializeControls();
			UpdateTreeGrid();
			UpdateShowChangelogMenuItem();
			UpdateCallMenuItem();
			UpdateSendTemplateEmailMenuItem();
			UpdateSendEmailMenuItem();
			UpdateButtonsControlLayout();
			UpdateFakeSaveToFileButton();
			UpdateContextHelpButton();
			UpdatePrintButton();
			UpdateActionButton();
			UpdateSaveToFileButton();
			UpdateDeleteButton();
			UpdateEditButton();
			UpdateCopyButton();
			UpdateAddButton();
			TopLevelControl.MoveItem(0, ButtonsControlLayout);
			ButtonsControlLayout.MoveItem(0, AddButton);
			ButtonsControlLayout.MoveItem(1, CopyButton);
			ButtonsControlLayout.MoveItem(2, EditButton);
			ButtonsControlLayout.MoveItem(3, DeleteButton);
			ButtonsControlLayout.MoveItem(4, SaveToFileButton);
			ButtonsControlLayout.MoveItem(5, SpacerPrintButton);
			ButtonsControlLayout.MoveItem(6, ActionButton);
			ButtonsControlLayout.MoveItem(7, PrintButton);
			ButtonsControlLayout.MoveItem(8, ContextHelpButton);
			ButtonsControlLayout.MoveItem(9, FakeSaveToFileButton);
			TopLevelControl.MoveItem(1, TreeGrid);
			TreeGrid.MoveItem(0, SendEmailMenuItem);
			TreeGrid.MoveItem(1, SendTemplateEmailMenuItem);
			TreeGrid.MoveItem(2, CallMenuItem);
			TreeGrid.MoveItem(3, ShowChangelogMenuItem);
			TopLevelControl.MoveItem(2, DataSource);
			SetControlsDefInheritance(UId);
			InitializeLocalizableValues();
		}

		protected virtual EmbeddedProcessSchema CreateSysModuleReportsGridPageEventsProcessSchema() {
			var schema = new SysModuleReportsGridPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected override void UpdateDataSource() {
			base.UpdateDataSource();
			DataSourceStructureColumn column = null;
			column = DataSource.DefStructure.Columns.FindByMetaPath("ae0e45ca-c495-4fe7-a39d-3ab7278e1617");
			if (column != null) {
				column.IsVisible = false;
				column.IsAlwaysSelect = true;
				column.Required = true;
				column.ModifiedInSchemaUId = new Guid("d51435c2-7f90-4d2e-8cf4-9f24e1192d39");
			}
			column = DataSource.DefStructure.Columns.FindByMetaPath("e80190a5-03b2-4095-90f7-a193a960adee");
			if (column != null) {
				column.IsVisible = false;
				column.ModifiedInSchemaUId = new Guid("d51435c2-7f90-4d2e-8cf4-9f24e1192d39");
			}
			column = DataSource.DefStructure.Columns.FindByMetaPath("ebf6bb93-8aa6-4a01-900d-c6ea67affe21");
			if (column != null) {
				column.IsVisible = false;
				column.ModifiedInSchemaUId = new Guid("d51435c2-7f90-4d2e-8cf4-9f24e1192d39");
			}
			column = DataSource.DefStructure.Columns.FindByMetaPath("9928edec-4272-425a-93bb-48743fee4b04");
			if (column != null) {
				column.IsVisible = false;
				column.ModifiedInSchemaUId = new Guid("d51435c2-7f90-4d2e-8cf4-9f24e1192d39");
			}
			column = DataSource.DefStructure.Columns.FindByMetaPath("3015559e-cbc6-406a-88af-07f7930be832");
			if (column != null) {
				column.IsVisible = false;
				column.ModifiedInSchemaUId = new Guid("d51435c2-7f90-4d2e-8cf4-9f24e1192d39");
			}
			column = DataSource.DefStructure.Columns.FindByMetaPath("3fb83606-040e-4fdb-aeb6-a9357886dcb3");
			if (column != null) {
				column.Required = true;
				column.ModifiedInSchemaUId = new Guid("d51435c2-7f90-4d2e-8cf4-9f24e1192d39");
			}
			column = DataSource.DefStructure.Columns.FindByMetaPath("b6607c22-ca01-41f0-8637-610221a869b6");
			if (column != null) {
				column.Required = true;
				column.ModifiedInSchemaUId = new Guid("d51435c2-7f90-4d2e-8cf4-9f24e1192d39");
			}
			column = DataSource.DefStructure.Columns.FindByMetaPath("cb6b495c-384d-4a40-9f93-35c6dfb79a3b");
			if (column != null) {
				column.IsVisible = false;
				column.IsAlwaysSelect = true;
				column.ModifiedInSchemaUId = new Guid("d51435c2-7f90-4d2e-8cf4-9f24e1192d39");
			}
			column = DataSource.DefStructure.Columns.FindByMetaPath("94f2a9f7-55c7-4ecf-9b64-17583ddc058b");
			if (column != null) {
				column.IsAlwaysSelect = true;
				column.Required = true;
				column.ModifiedInSchemaUId = new Guid("d51435c2-7f90-4d2e-8cf4-9f24e1192d39");
			}
			column = DataSource.DefStructure.Columns.FindByMetaPath("362bb0b0-d3da-4b01-abe6-a617e1b1257f");
			if (column != null) {
				column.IsVisible = false;
				column.IsAlwaysSelect = true;
				column.ModifiedInSchemaUId = new Guid("d51435c2-7f90-4d2e-8cf4-9f24e1192d39");
			}
			column = DataSource.DefStructure.Columns.FindByMetaPath("1f17f6cb-8a86-408c-9207-d2f8b22ae1b7");
			if (column != null) {
				column.IsVisible = false;
				column.ModifiedInSchemaUId = new Guid("d51435c2-7f90-4d2e-8cf4-9f24e1192d39");
			}
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override PageSchemaUserControl CreateUserControl() {
			return new SysModuleReportsGridPageSchemaUserControl();
		}

		public override object Clone() {
			return new SysModuleReportsGridPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d51435c2-7f90-4d2e-8cf4-9f24e1192d39"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new SysModuleReportsGridPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: SysModuleReportsGridPageEventsProcess

	/// <exclude/>
	public class SysModuleReportsGridPageEventsProcess<TPage> : Terrasoft.WebApp.SysModuleReportsGridPage_Base_TerrasoftEventsProcess<TPage> where TPage : Terrasoft.WebApp.SysModuleReportsGridPageSchemaUserControl
	{

		public SysModuleReportsGridPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SysModuleReportsGridPageEventsProcess";
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("d51435c2-7f90-4d2e-8cf4-9f24e1192d39");
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

		private LocalizableString _devExpressCaption;
		public LocalizableString DevExpressCaption {
			get {
				return _devExpressCaption ?? (_devExpressCaption = new LocalizableString(Storage, Schema.GetResourceManagerName(), "EventsProcessSchema.LocalizableStrings.DevExpressCaption.Value"));
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

		public override Dictionary<string, string> GetEditPages() {
			var listEditPages = base.GetEditPages();
			var typeEditPageUIds = (Dictionary<Guid, Dictionary<string, Guid>>)TypeEditPageUIds;
			typeEditPageUIds.Add(new Guid("32F72C9C-72C7-44E0-8C84-34C9ED17CA50"),
				new Dictionary <string, Guid>() {
					{"EditPageUId", new Guid("93efee4c-26ad-4e27-a98a-aa00d16bdbf6")},
					{"SysModuleEditId", Guid.Empty}
				}
			);
			var key = "93efee4c-26ad-4e27-a98a-aa00d16bdbf6&32F72C9C-72C7-44E0-8C84-34C9ED17CA50";
			listEditPages[key] = DevExpressCaption.Value;
			return listEditPages;
		}

		public override List<Guid> GetReportTypeUIds() {
			var result = base.GetReportTypeUIds();
			result.Add(new Guid("32F72C9C-72C7-44E0-8C84-34C9ED17CA50"));
			return result;
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

	#region Class: SysModuleReportsGridPageEventsProcess

	/// <exclude/>
	public class SysModuleReportsGridPageEventsProcess : SysModuleReportsGridPageEventsProcess<Terrasoft.WebApp.SysModuleReportsGridPageSchemaUserControl>
	{

		public SysModuleReportsGridPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SysModuleReportsGridPageSchemaUserControl

	/// <exclude/>
	public partial class SysModuleReportsGridPageSchemaUserControl : Terrasoft.WebApp.SysModuleReportsGridPage_Base_TerrasoftSchemaUserControl
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
			var process = (SysModuleReportsGridPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new SysModuleReportsGridPageEventsProcess(UserConnection);
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
			SchemaName = "SysModuleReportsGridPage";
		}

		#endregion

	}

	#endregion

	#region Class: SysModuleReportsGridPageEventsProcessSchema

	/// <exclude/>
	public class SysModuleReportsGridPageEventsProcessSchema : Terrasoft.WebApp.SysModuleReportsGridPage_Base_TerrasoftEventsProcessSchema
	{

		#region Constructors: Public

		public SysModuleReportsGridPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public SysModuleReportsGridPageEventsProcessSchema(SysModuleReportsGridPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "SysModuleReportsGridPageEventsProcess";
			UId = new Guid("a46fa72d-9d26-4cd9-9e45-b72bf9d8529f");
			CreatedInPackageId = new Guid("bcd7b40a-afa2-4631-8983-51d02c873b88");
			CreatedInSchemaUId = Guid.Empty;
			CreatedInVersion = @"0.0.0.0";
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("6995e340-0fb2-4e8f-9174-ab1743ab9cef");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet1_1fc11a39eec647dcae63eb3286191f7f = CreateLaneSet1_1fc11a39eec647dcae63eb3286191f7fLaneSet();
			LaneSets.Add(schemaLaneSet1_1fc11a39eec647dcae63eb3286191f7f);
			ProcessSchemaLane schemaLane1_c8fec8a8383a4ecd98cc66be2a02c431 = CreateLane1_c8fec8a8383a4ecd98cc66be2a02c431Lane();
			schemaLaneSet1_1fc11a39eec647dcae63eb3286191f7f.Lanes.Add(schemaLane1_c8fec8a8383a4ecd98cc66be2a02c431);
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateDevExpressCaptionLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateDevExpressCaptionLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("b76b9c77-0128-4dc4-a788-1e412ab3c80f"),
				Name = "DevExpressCaption",
				CreatedInPackageId = new Guid("bcd7b40a-afa2-4631-8983-51d02c873b88"),
				CreatedInSchemaUId = new Guid("a46fa72d-9d26-4cd9-9e45-b72bf9d8529f"),
				ModifiedInSchemaUId = new Guid("a46fa72d-9d26-4cd9-9e45-b72bf9d8529f")
			};
			return localizableString;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1_1fc11a39eec647dcae63eb3286191f7fLaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1_1fc11a39eec647dcae63eb3286191f7f = new ProcessSchemaLaneSet(this) {
				UId = new Guid("1fc11a39-eec6-47dc-ae63-eb3286191f7f"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("6995e340-0fb2-4e8f-9174-ab1743ab9cef"),
				CreatedInPackageId = new Guid("bcd7b40a-afa2-4631-8983-51d02c873b88"),
				CreatedInSchemaUId = new Guid("a46fa72d-9d26-4cd9-9e45-b72bf9d8529f"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("a46fa72d-9d26-4cd9-9e45-b72bf9d8529f"),
				Name = @"LaneSet1_1fc11a39eec647dcae63eb3286191f7f",
				Position = new Point(0, 5),
				Size = new Size(0, 400),
				UseBackgroundMode = false
			};
			return schemaLaneSet1_1fc11a39eec647dcae63eb3286191f7f;
		}

		protected virtual ProcessSchemaLane CreateLane1_c8fec8a8383a4ecd98cc66be2a02c431Lane() {
			ProcessSchemaLane schemaLane1_c8fec8a8383a4ecd98cc66be2a02c431 = new ProcessSchemaLane(this) {
				UId = new Guid("c8fec8a8-383a-4ecd-98cc-66be2a02c431"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1fc11a39-eec6-47dc-ae63-eb3286191f7f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("bcd7b40a-afa2-4631-8983-51d02c873b88"),
				CreatedInSchemaUId = new Guid("a46fa72d-9d26-4cd9-9e45-b72bf9d8529f"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("a46fa72d-9d26-4cd9-9e45-b72bf9d8529f"),
				Name = @"Lane1_c8fec8a8383a4ecd98cc66be2a02c431",
				Position = new Point(0, 0),
				Size = new Size(700, 400),
				UseBackgroundMode = false
			};
			return schemaLane1_c8fec8a8383a4ecd98cc66be2a02c431;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("9d7efbbf-8549-484c-9592-82bf90843f5d"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("95c66740-e509-4ca4-b1ef-c7a6bb406ec0"),
				Name = "Terrasoft.UI.WebControls.Controls",
				Alias = "WebControls",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7c7fbab2-546c-4dd3-ba02-c8f1ddbc356d"),
				Name = "System.Linq",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5869487f-ebcd-414c-9fb2-40b8f070b351"),
				Name = "System.Web",
				Alias = "web",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("41c60d94-6edf-44e4-9edb-0e16c226d725"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("92dceabc-4c2b-49a1-baa4-e5bdfa59f339"),
				Name = "Terrasoft.Core.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("f759fd7f-c235-4aad-9f86-46ed65d3d366"),
				Name = "Terrasoft.UI.WebControls",
				Alias = "TSWebControls",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("aa8aa1ac-15e9-42cc-9636-16aa514d5797"),
				Name = "System.Text",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("10a2ccab-756c-4712-b1b8-f4ebab9f54a0"),
				Name = "Terrasoft.Configuration",
				Alias = "TSConfiguration",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e450a1d1-32d4-48db-a086-f5426a1a7722"),
				Name = "Terrasoft.Core.Store",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("6f5452a8-39be-4d73-aff7-044da2a7684d"),
				Name = "System.Threading",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("0655a6cd-c0cc-42ef-b029-8e7b7f8cbd5b"),
				Name = "Terrasoft.Reports",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
		}

		protected override SchemaMethod CreateGetEditPagesMethod() {
			SchemaMethod method = base.CreateGetEditPagesMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,145,205,107,131,48,24,198,207,230,175,8,30,134,130,17,171,206,15,220,10,37,186,178,195,96,176,143,203,216,33,54,111,75,152,179,98,162,155,148,254,239,85,217,176,246,212,75,14,79,222,231,249,37,207,219,178,26,23,66,170,140,11,245,204,118,32,241,61,206,153,4,123,13,147,102,152,9,106,251,65,213,85,240,47,190,61,242,97,214,72,197,70,137,125,201,234,238,110,221,8,110,225,51,65,170,90,148,59,11,15,23,203,165,249,122,97,79,208,101,160,189,226,220,40,225,103,116,24,186,231,62,132,46,141,41,233,207,144,248,126,230,144,136,70,62,241,124,26,103,233,34,164,171,91,71,55,45,164,13,150,137,139,231,96,195,196,7,164,105,7,253,140,164,91,120,194,196,30,108,1,252,13,113,3,198,137,15,110,72,88,28,49,194,152,227,240,69,144,243,124,27,232,230,209,26,67,94,58,249,180,231,77,49,190,123,12,26,66,236,236,187,82,221,17,105,71,244,215,213,23,116,125,61,87,101,223,92,245,207,4,205,246,244,209,3,62,123,66,10,109,246,91,213,32,37,101,213,80,128,253,206,138,6,18,84,131,106,234,114,190,220,228,4,101,96,124,77,239,1,0,0 };
			return method;
		}

		protected override SchemaMethod CreateGetReportTypeUIdsMethod() {
			SchemaMethod method = base.CreateGetReportTypeUIdsMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,75,44,82,40,74,45,46,205,41,81,176,85,72,74,44,78,213,115,79,45,9,74,45,200,47,42,9,169,44,72,13,245,76,41,214,208,180,230,130,40,209,115,76,73,209,200,75,45,87,112,47,205,76,209,80,50,54,114,51,55,114,182,116,214,5,146,230,186,38,38,174,6,186,22,206,22,38,186,198,38,206,150,174,46,134,230,206,142,166,6,74,154,96,221,37,165,69,121,80,123,172,1,174,249,153,17,115,0,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SysModuleReportsGridPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a46fa72d-9d26-4cd9-9e45-b72bf9d8529f"));
		}

		#endregion

	}

	#endregion

}

