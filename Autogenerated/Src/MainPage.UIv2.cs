﻿namespace Terrasoft.WebApp
{

	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.ComponentModel;
	using System.Data;
	using System.Drawing;
	using System.Globalization;
	using System.IO;
	using System.Linq;
	using System.Net;
	using System.Text;
	using System.Web;
	using System.Web.UI.HtmlControls;
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
	using Terrasoft.Sync;
	using Terrasoft.UI.WebControls;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities;
	using Terrasoft.Web.Common;
	using TSConfiguration = Terrasoft.Configuration;
	using WebControls = Terrasoft.UI.WebControls.Controls;

	#region Class: MainPage_UIv2_TerrasoftSchema

	/// <exclude/>
	public class MainPage_UIv2_TerrasoftSchema : Terrasoft.WebApp.MainPage_Base_TerrasoftSchema
	{

		#region Constructors: Public

		public MainPage_UIv2_TerrasoftSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public MainPage_UIv2_TerrasoftSchema(MainPage_UIv2_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateImageBox1() {
			ImageBox1.Image = new ControlImage {};
			ImageBox1.ModifiedInSchemaUId = new Guid("1f833e8a-4943-4bae-8b39-d759569a1f7f");
		}

		private void UpdateLogoControlLayout() {
			LogoControlLayout.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("5e5f9a9e-aa7d-407d-9e1e-1c24c3f9b59a"),
				ImageHash = @"eecd27fb9c59102f31f7b17d2d3a9098"
			};
			LogoControlLayout.ModifiedInSchemaUId = new Guid("1f833e8a-4943-4bae-8b39-d759569a1f7f");
		}

		private void UpdateAddButton() {
			AddButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("5e5f9a9e-aa7d-407d-9e1e-1c24c3f9b59a"),
				ImageHash = @"732f25c71e8e82b8f33e9015fb2761c3"
			};
			AddButton.ModifiedInSchemaUId = new Guid("1f833e8a-4943-4bae-8b39-d759569a1f7f");
		}

		private void UpdateUnreadEmailCountButton() {
			UnreadEmailCountButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("5e5f9a9e-aa7d-407d-9e1e-1c24c3f9b59a"),
				ImageHash = @"d80456e7ae9ddcaaba5be150e40430f6"
			};
			UnreadEmailCountButton.ModifiedInSchemaUId = new Guid("1f833e8a-4943-4bae-8b39-d759569a1f7f");
		}

		private void UpdateNewRemindingsCountButton() {
			NewRemindingsCountButton.AjaxEvents.Click.IsProcessEventHandler = true;
			NewRemindingsCountButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("5e5f9a9e-aa7d-407d-9e1e-1c24c3f9b59a"),
				ImageHash = @"ffb30c2b39b9af8d378949afa88bf6fe"
			};
			NewRemindingsCountButton.ModifiedInSchemaUId = new Guid("1f833e8a-4943-4bae-8b39-d759569a1f7f");
		}

		private void UpdateRunProcessButton() {
			RunProcessButton.Image = new ControlImage {};
			RunProcessButton.ModifiedInSchemaUId = new Guid("1f833e8a-4943-4bae-8b39-d759569a1f7f");
		}

		private void UpdateControlLayout1() {
			ControlLayout1.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("5e5f9a9e-aa7d-407d-9e1e-1c24c3f9b59a"),
				ImageHash = @"eecd27fb9c59102f31f7b17d2d3a9098"
			};
			ControlLayout1.ModifiedInSchemaUId = new Guid("1f833e8a-4943-4bae-8b39-d759569a1f7f");
		}

		private void UpdateNavigationButtonsControlLayout() {
			NavigationButtonsControlLayout.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("5e5f9a9e-aa7d-407d-9e1e-1c24c3f9b59a"),
				ImageHash = @"eecd27fb9c59102f31f7b17d2d3a9098"
			};
			NavigationButtonsControlLayout.ModifiedInSchemaUId = new Guid("1f833e8a-4943-4bae-8b39-d759569a1f7f");
		}

		private void UpdateNavigationControlLayout() {
			NavigationControlLayout.Image = new ControlImage {};
			NavigationControlLayout.ModifiedInSchemaUId = new Guid("1f833e8a-4943-4bae-8b39-d759569a1f7f");
		}

		private void UpdateTopLeftControlLayout() {
			TopLeftControlLayout.Image = new ControlImage {};
			TopLeftControlLayout.ModifiedInSchemaUId = new Guid("1f833e8a-4943-4bae-8b39-d759569a1f7f");
		}

		private void UpdateClearToolButton() {
			ClearToolButton.AjaxEvents.Click.IsProcessEventHandler = true;
			ClearToolButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("5e5f9a9e-aa7d-407d-9e1e-1c24c3f9b59a"),
				ImageHash = @"cfdf940c3b92339e9ae166ea4f337539"
			};
			ClearToolButton.ModifiedInSchemaUId = new Guid("1f833e8a-4943-4bae-8b39-d759569a1f7f");
		}

		private void UpdateModulesToolButton() {
			ModulesToolButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("5e5f9a9e-aa7d-407d-9e1e-1c24c3f9b59a"),
				ImageHash = @"1a9fc7e6fb874b752a26daed50999694"
			};
			ModulesToolButton.ModifiedInSchemaUId = new Guid("1f833e8a-4943-4bae-8b39-d759569a1f7f");
		}

		private void UpdateSearchToolButton() {
			SearchToolButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("5e5f9a9e-aa7d-407d-9e1e-1c24c3f9b59a"),
				ImageHash = @"1a9fc7e6fb874b752a26daed50999694"
			};
			SearchToolButton.ModifiedInSchemaUId = new Guid("1f833e8a-4943-4bae-8b39-d759569a1f7f");
		}

		private void UpdateSearchEdit() {
			SearchEdit.Image = new ControlImage {};
			SearchEdit.ModifiedInSchemaUId = new Guid("1f833e8a-4943-4bae-8b39-d759569a1f7f");
		}

		private void UpdateSettingsButton() {
			SettingsButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("5e5f9a9e-aa7d-407d-9e1e-1c24c3f9b59a"),
				ImageHash = @"1a9fc7e6fb874b752a26daed50999694"
			};
			SettingsButton.ModifiedInSchemaUId = new Guid("1f833e8a-4943-4bae-8b39-d759569a1f7f");
		}

		private void UpdateUserSettingsButton() {
			UserSettingsButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("5e5f9a9e-aa7d-407d-9e1e-1c24c3f9b59a"),
				ImageHash = @"1a9fc7e6fb874b752a26daed50999694"
			};
			UserSettingsButton.ModifiedInSchemaUId = new Guid("1f833e8a-4943-4bae-8b39-d759569a1f7f");
		}

		private void UpdateOpenContextHelp() {
			OpenContextHelp.Image = new ControlImage {};
			OpenContextHelp.ModifiedInSchemaUId = new Guid("1f833e8a-4943-4bae-8b39-d759569a1f7f");
		}

		private void UpdateOpenModuleHelp() {
			OpenModuleHelp.Image = new ControlImage {};
			OpenModuleHelp.ModifiedInSchemaUId = new Guid("1f833e8a-4943-4bae-8b39-d759569a1f7f");
		}

		private void UpdateShowWelcomeScreen() {
			ShowWelcomeScreen.AjaxEvents.Click.IsProcessEventHandler = true;
			ShowWelcomeScreen.Image = new ControlImage {};
			ShowWelcomeScreen.ModifiedInSchemaUId = new Guid("1f833e8a-4943-4bae-8b39-d759569a1f7f");
		}

		private void UpdateContextHelpButton() {
			ContextHelpButton.Image = new ControlImage {};
			ContextHelpButton.ModifiedInSchemaUId = new Guid("1f833e8a-4943-4bae-8b39-d759569a1f7f");
		}

		private void UpdateExitButton() {
			ExitButton.AjaxEvents.Click.IsProcessEventHandler = true;
			ExitButton.Image = new ControlImage {
				Source = ControlImageSource.Image,
				SchemaUId = new Guid("5e5f9a9e-aa7d-407d-9e1e-1c24c3f9b59a"),
				ImageHash = @"ffaca02094dc513963a5b2bc892e55c8"
			};
			ExitButton.ModifiedInSchemaUId = new Guid("1f833e8a-4943-4bae-8b39-d759569a1f7f");
		}

		private void UpdateMultiLevelTabs() {
			MultiLevelTabs.AjaxEvents.TabChange.ShowLoadMask = true;
		}

		private void UpdateTopRightControlLayout() {
			TopRightControlLayout.Image = new ControlImage {};
			TopRightControlLayout.ModifiedInSchemaUId = new Guid("1f833e8a-4943-4bae-8b39-d759569a1f7f");
		}

		private void UpdateTopControlLayout() {
			TopControlLayout.Image = new ControlImage {};
			TopControlLayout.ModifiedInSchemaUId = new Guid("1f833e8a-4943-4bae-8b39-d759569a1f7f");
		}

		private void UpdateNavigationControlsImageList() {
			NavigationControlsImageList.MoveItem(0, FindDesignItemByUId(new Guid("119cb018-92e5-46c3-be18-eafe3dc04e9f")));
			NavigationControlsImageList.MoveItem(1, FindDesignItemByUId(new Guid("cbda301e-94b5-4aa0-a4e7-cbc0a98c9ed8")));
			NavigationControlsImageList.MoveItem(2, FindDesignItemByUId(new Guid("ffd3ed0c-7d0b-4461-a203-fc2bf1f32b6e")));
			NavigationControlsImageList.MoveItem(3, FindDesignItemByUId(new Guid("95406dce-3a0b-4637-916c-aeffb656d154")));
			NavigationControlsImageList.MoveItem(4, FindDesignItemByUId(new Guid("64e16144-e92f-4be1-87eb-de2d7f44ac09")));
		}

		private void UpdateContentControlLayout() {
			ContentControlLayout.Image = new ControlImage {};
			ContentControlLayout.ModifiedInSchemaUId = new Guid("1f833e8a-4943-4bae-8b39-d759569a1f7f");
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("1f833e8a-4943-4bae-8b39-d759569a1f7f");
			Name = "MainPage_UIv2_Terrasoft";
			ParentSchemaUId = new Guid("5e5f9a9e-aa7d-407d-9e1e-1c24c3f9b59a");
			CreatedInPackageId = new Guid("6cd322b4-3e01-484f-a2c2-ed1ccee14365");
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateMainPage_UIv2_TerrasoftEventsProcessSchema();
		}

		protected override void InitializeControls() {
			base.InitializeControls();
			UpdateContentControlLayout();
			UpdateNavigationControlsImageList();
			UpdateTopControlLayout();
			UpdateTopRightControlLayout();
			UpdateMultiLevelTabs();
			UpdateExitButton();
			UpdateContextHelpButton();
			UpdateShowWelcomeScreen();
			UpdateOpenModuleHelp();
			UpdateOpenContextHelp();
			UpdateUserSettingsButton();
			UpdateSettingsButton();
			UpdateSearchEdit();
			UpdateSearchToolButton();
			UpdateModulesToolButton();
			UpdateClearToolButton();
			UpdateTopLeftControlLayout();
			UpdateNavigationControlLayout();
			UpdateNavigationButtonsControlLayout();
			UpdateControlLayout1();
			UpdateRunProcessButton();
			UpdateNewRemindingsCountButton();
			UpdateUnreadEmailCountButton();
			UpdateAddButton();
			UpdateLogoControlLayout();
			UpdateImageBox1();
			TopLevelControl.MoveItem(0, TopControlLayout);
			TopControlLayout.MoveItem(0, TopLeftControlLayout);
			TopLeftControlLayout.MoveItem(0, LogoControlLayout);
			LogoControlLayout.MoveItem(0, ImageBox1);
			TopLeftControlLayout.MoveItem(1, NavigationControlLayout);
			NavigationControlLayout.MoveItem(0, NavigationButtonsControlLayout);
			NavigationButtonsControlLayout.MoveItem(0, AddButton);
			NavigationButtonsControlLayout.MoveItem(1, UnreadEmailCountButton);
			NavigationButtonsControlLayout.MoveItem(2, NewRemindingsCountButton);
			NavigationButtonsControlLayout.MoveItem(3, RunProcessButton);
			NavigationButtonsControlLayout.MoveItem(4, Spacer1);
			NavigationButtonsControlLayout.MoveItem(5, ControlLayout1);
			TopControlLayout.MoveItem(1, TopRightControlLayout);
			TopRightControlLayout.MoveItem(0, MultiLevelTabs);
			MultiLevelTabs.MoveItem(0, SearchEdit);
			SearchEdit.MoveItem(0, ClearToolButton);
			SearchEdit.MoveItem(1, ModulesToolButton);
			SearchEdit.MoveItem(2, SearchToolButton);
			MultiLevelTabs.MoveItem(1, SettingsButton);
			MultiLevelTabs.MoveItem(2, UserSettingsButton);
			MultiLevelTabs.MoveItem(3, ContextHelpButton);
			ContextHelpButton.MoveItem(0, OpenContextHelp);
			ContextHelpButton.MoveItem(1, OpenModuleHelp);
			ContextHelpButton.MoveItem(2, ShowWelcomeScreen);
			MultiLevelTabs.MoveItem(4, ExitButton);
			TopLevelControl.MoveItem(1, BaseMessagePanel);
			TopLevelControl.MoveItem(2, NavigationControlsImageList);
			TopLevelControl.MoveItem(3, ContentControlLayout);
			SetControlsDefInheritance(UId);
			InitializeLocalizableValues();
		}

		protected virtual EmbeddedProcessSchema CreateMainPage_UIv2_TerrasoftEventsProcessSchema() {
			var schema = new MainPage_UIv2_TerrasoftEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override PageSchemaUserControl CreateUserControl() {
			return new MainPage_UIv2_TerrasoftSchemaUserControl();
		}

		public override object Clone() {
			return new MainPage_UIv2_TerrasoftSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("1f833e8a-4943-4bae-8b39-d759569a1f7f"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new MainPage_UIv2_TerrasoftEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: MainPage_UIv2_TerrasoftEventsProcess

	/// <exclude/>
	public class MainPage_UIv2_TerrasoftEventsProcess<TPage> : Terrasoft.WebApp.MainPage_Base_TerrasoftEventsProcess<TPage> where TPage : Terrasoft.WebApp.MainPage_UIv2_TerrasoftSchemaUserControl
	{

		public MainPage_UIv2_TerrasoftEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "MainPage_UIv2_TerrasoftEventsProcess";
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("1f833e8a-4943-4bae-8b39-d759569a1f7f");
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

		public override bool CheckModuleReadingRights(Guid entitySchemaId) {
			var hiddenModuleList = new List <string> {
				"VwSysAdminUnit",
				"SysAdminOperation",
				"SysSettings"
			};
			if (Terrasoft.Configuration.FeatureUtilities.GetIsFeatureEnabled(UserConnection, "NewRightsManagementUI")) {
				hiddenModuleList.Add("VwAdministrativeObjects");
			}
			EntitySchemaManager entitySchemaManager = Page.Schema.SchemaManagerProvider.GetManager("EntitySchemaManager") as EntitySchemaManager;
			string schemaName = entitySchemaManager.FindItemByUId(entitySchemaId).Name;
			if (hiddenModuleList.Contains(schemaName)) {
				return false;
			}
			return base.CheckModuleReadingRights(entitySchemaId);
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

	#region Class: MainPage_UIv2_TerrasoftEventsProcess

	/// <exclude/>
	public class MainPage_UIv2_TerrasoftEventsProcess : MainPage_UIv2_TerrasoftEventsProcess<Terrasoft.WebApp.MainPage_UIv2_TerrasoftSchemaUserControl>
	{

		public MainPage_UIv2_TerrasoftEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: MainPage_UIv2_TerrasoftSchemaUserControl

	/// <exclude/>
	public partial class MainPage_UIv2_TerrasoftSchemaUserControl : Terrasoft.WebApp.MainPage_Base_TerrasoftSchemaUserControl
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
			var process = (MainPage_UIv2_TerrasoftEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new MainPage_UIv2_TerrasoftEventsProcess(UserConnection);
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
			SchemaName = "MainPage_UIv2_Terrasoft";
		}

		#endregion

	}

	#endregion

	#region Class: MainPage_UIv2_TerrasoftEventsProcessSchema

	/// <exclude/>
	public class MainPage_UIv2_TerrasoftEventsProcessSchema : Terrasoft.WebApp.MainPage_Base_TerrasoftEventsProcessSchema
	{

		#region Constructors: Public

		public MainPage_UIv2_TerrasoftEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public MainPage_UIv2_TerrasoftEventsProcessSchema(MainPage_UIv2_TerrasoftEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "MainPage_UIv2_TerrasoftEventsProcess";
			UId = new Guid("08f2494e-d96c-4626-bcbc-10dcf2ae6933");
			CreatedInPackageId = new Guid("6cd322b4-3e01-484f-a2c2-ed1ccee14365");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet1_8eb8e707d20749cbb378e5103e03fda8 = CreateLaneSet1_8eb8e707d20749cbb378e5103e03fda8LaneSet();
			LaneSets.Add(schemaLaneSet1_8eb8e707d20749cbb378e5103e03fda8);
			ProcessSchemaLane schemaLane1_09c1550124f44697bc59197b686533db = CreateLane1_09c1550124f44697bc59197b686533dbLane();
			schemaLaneSet1_8eb8e707d20749cbb378e5103e03fda8.Lanes.Add(schemaLane1_09c1550124f44697bc59197b686533db);
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1_8eb8e707d20749cbb378e5103e03fda8LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1_8eb8e707d20749cbb378e5103e03fda8 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("8eb8e707-d207-49cb-b378-e5103e03fda8"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("ff486f76-1530-4091-b65a-6b5a3dd670b4"),
				CreatedInPackageId = new Guid("b63e03f3-0276-45b2-a3b1-45072bb5d77c"),
				CreatedInSchemaUId = new Guid("08f2494e-d96c-4626-bcbc-10dcf2ae6933"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("08f2494e-d96c-4626-bcbc-10dcf2ae6933"),
				Name = @"LaneSet1_8eb8e707d20749cbb378e5103e03fda8",
				Position = new Point(0, 5),
				Size = new Size(0, 400),
				UseBackgroundMode = false
			};
			return schemaLaneSet1_8eb8e707d20749cbb378e5103e03fda8;
		}

		protected virtual ProcessSchemaLane CreateLane1_09c1550124f44697bc59197b686533dbLane() {
			ProcessSchemaLane schemaLane1_09c1550124f44697bc59197b686533db = new ProcessSchemaLane(this) {
				UId = new Guid("09c15501-24f4-4697-bc59-197b686533db"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("8eb8e707-d207-49cb-b378-e5103e03fda8"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("b63e03f3-0276-45b2-a3b1-45072bb5d77c"),
				CreatedInSchemaUId = new Guid("08f2494e-d96c-4626-bcbc-10dcf2ae6933"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("08f2494e-d96c-4626-bcbc-10dcf2ae6933"),
				Name = @"Lane1_09c1550124f44697bc59197b686533db",
				Position = new Point(0, 0),
				Size = new Size(700, 400),
				UseBackgroundMode = false
			};
			return schemaLane1_09c1550124f44697bc59197b686533db;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("368a8430-9e48-4ca8-a404-c27647a0e6aa"),
				Name = "Terrasoft.Core.DB",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("ab6ee143-6600-4750-b499-efce30694d41"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("50ba7521-25e0-4a80-9b8b-699987de4665"),
				Name = "Terrasoft.Core.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("508099d5-5266-4168-b0f4-cfa21c83b073"),
				Name = "System.Text",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e6d29217-eef2-4009-b532-d82c537df6f1"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d5dee138-c82f-469a-a5fe-5a1d2eef8d21"),
				Name = "System.Web",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("1e6d6115-4b1e-40be-9e6c-ebe4cd56d454"),
				Name = "System.Linq",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("3898550f-2487-4196-9186-1514514959aa"),
				Name = "Terrasoft.UI.WebControls.Controls",
				Alias = "WebControls",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("2f544447-f3a7-4d3b-a05e-25c6215b95a4"),
				Name = "Terrasoft.Web.Common",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d97aaed2-0df3-4aee-8171-b031b9f99028"),
				Name = "Terrasoft.Configuration",
				Alias = "TSConfiguration",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("de7da21c-9b1e-4660-b06c-149b9a3dab12"),
				Name = "Terrasoft.Core.Store",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("3f452131-56a5-44e8-b8cf-9b972a3432d8"),
				Name = "Terrasoft.Sync",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("0f15370c-7b03-47e1-bfec-26023ed88ae5"),
				Name = "System.IO",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("aec44efd-5e6c-4ddd-9733-13fdad5b8d55"),
				Name = "System.Net",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("da309d20-39b2-4841-aa6d-3ea3e4840b3c"),
				Name = "System.Web.UI.HtmlControls",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("f5a0e52c-74a7-4f9b-b109-ed77b81d0aa7"),
				Name = "Newtonsoft.Json.Linq",
				Alias = "",
				CreatedInPackageId = new Guid("c42d95b3-a17f-45a6-9dff-a6ab283daf22")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("4dc2d041-a3b6-4c84-b22d-60918e4765cc"),
				Name = "Newtonsoft.Json",
				Alias = "",
				CreatedInPackageId = new Guid("c42d95b3-a17f-45a6-9dff-a6ab283daf22")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("2665ae57-86c8-4b23-b90b-ef1d75ac20fa"),
				Name = "Terrasoft.Core.Entities",
				Alias = "",
				CreatedInPackageId = new Guid("6cd322b4-3e01-484f-a2c2-ed1ccee14365")
			});
		}

		protected override SchemaMethod CreateCheckModuleReadingRightsMethod() {
			SchemaMethod method = base.CreateCheckModuleReadingRightsMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,145,203,110,194,48,16,69,215,141,148,127,176,188,74,36,228,31,160,84,162,8,170,72,229,33,104,186,55,120,146,76,155,56,149,103,0,161,138,127,175,243,232,59,43,219,199,190,51,119,174,79,218,137,2,141,1,187,172,205,177,132,71,36,22,19,97,225,44,218,237,45,177,67,155,223,137,247,48,184,145,207,231,221,133,166,166,66,155,90,100,57,106,216,39,89,191,129,211,140,181,253,194,59,96,246,90,146,97,112,29,135,1,102,34,122,2,231,52,213,25,171,89,109,51,204,143,157,68,45,64,243,209,65,202,88,34,35,144,122,0,78,168,167,115,171,247,37,152,40,37,112,94,102,225,208,104,70,66,174,224,188,197,188,96,90,106,171,115,168,192,114,154,200,56,110,205,254,157,74,77,141,137,252,4,173,89,127,110,58,159,96,189,127,241,229,72,198,222,224,53,12,230,150,145,47,187,67,1,149,238,138,58,1,3,108,34,54,126,85,29,84,191,238,54,174,62,161,1,215,140,208,163,72,14,212,149,177,208,36,6,46,188,147,46,116,65,45,94,233,10,124,195,1,27,106,129,214,36,12,213,253,37,77,76,244,243,69,98,98,213,8,251,220,255,133,225,115,100,141,150,162,239,30,125,110,14,124,230,86,100,186,36,232,66,233,201,94,19,168,89,1,135,215,174,206,22,180,241,46,187,31,248,219,124,252,1,7,204,75,15,89,2,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new MainPage_UIv2_TerrasoftEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("08f2494e-d96c-4626-bcbc-10dcf2ae6933"));
		}

		#endregion

	}

	#endregion

}

