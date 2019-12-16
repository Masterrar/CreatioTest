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
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;
	using Terrasoft.UI.WebControls;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities;

	#region Class: CreateLeadTestPageSchema

	/// <exclude/>
	public class CreateLeadTestPageSchema : Terrasoft.UI.WebControls.PageSchema
	{

		#region Properties: Public

		private Terrasoft.UI.WebControls.Controls.Button _button1;
		public  Terrasoft.UI.WebControls.Controls.Button Button1 {
			get {
				return _button1;
			}
		}

		#endregion

		#region Constructors: Public

		public CreateLeadTestPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public CreateLeadTestPageSchema(CreateLeadTestPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("814acfab-5d7f-4f39-b38d-5c9801c8bec5");
			RealUId = new Guid("814acfab-5d7f-4f39-b38d-5c9801c8bec5");
			Name = "CreateLeadTestPage";
			ParentSchemaUId = new Guid("2f55b628-9b95-4c32-a0ac-539eb4a9a8c8");
			CreatedInPackageId = new Guid("1ac017e5-6977-4f88-8d97-6d00b9321f95");
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateCreateLeadTestPageEventsProcessSchema();
		}

		protected override void InitializeControls() {
			base.InitializeControls();
			Controls.AddAt(0, CreateButton1());
			SetControlsDefInheritance(UId);
			InitializeLocalizableValues();
		}

		protected virtual EmbeddedProcessSchema CreateCreateLeadTestPageEventsProcessSchema() {
			var schema = new CreateLeadTestPageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		protected virtual Terrasoft.UI.WebControls.Controls.Button CreateButton1() {
			_button1 = new Terrasoft.UI.WebControls.Controls.Button();
			_button1.UId = new Guid("504c3e32-c266-4920-9e78-9f4063d24e3d");
			_button1.Name = "Button1";
			_button1.CreatedInSchemaUId = new Guid("814acfab-5d7f-4f39-b38d-5c9801c8bec5");
			_button1.ModifiedInSchemaUId = new Guid("814acfab-5d7f-4f39-b38d-5c9801c8bec5");
			_button1.CreatedInPackageId = new Guid("1ac017e5-6977-4f88-8d97-6d00b9321f95");
			_button1.AjaxEvents.Click.IsProcessEventHandler = true;
			_button1.Tag = "";
			_button1.Image = new ControlImage {};
			return _button1;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override PageSchemaUserControl CreateUserControl() {
			return new CreateLeadTestPageSchemaUserControl();
		}

		public override object Clone() {
			return new CreateLeadTestPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("814acfab-5d7f-4f39-b38d-5c9801c8bec5"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new CreateLeadTestPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: CreateLeadTestPageEventsProcess

	/// <exclude/>
	public class CreateLeadTestPageEventsProcess<TPage> : Terrasoft.Core.Process.EmbeddedProcess where TPage : Terrasoft.WebApp.CreateLeadTestPageSchemaUserControl
	{

		private TPage _page;
		public  TPage Page {
			get {
				return _page;
			}
			set {
				_page = value;
			}
		}

		public CreateLeadTestPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "CreateLeadTestPageEventsProcess";
			SchemaUId = new Guid("814acfab-5d7f-4f39-b38d-5c9801c8bec5");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private  Guid InternalSchemaUId {
			get {
				return new Guid("814acfab-5d7f-4f39-b38d-5c9801c8bec5");
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

		private ProcessFlowElement _eventSubProcess1;
		public  ProcessFlowElement EventSubProcess1 {
			get {
				return _eventSubProcess1 ?? (_eventSubProcess1 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess1",
					SchemaElementUId = new Guid("9c237489-7a4f-4ac1-81da-35025c998641"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _startMessage1;
		public  ProcessFlowElement StartMessage1 {
			get {
				return _startMessage1 ?? (_startMessage1 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessage1",
					SchemaElementUId = new Guid("6aab2f3f-6250-437a-b4f6-a65803889438"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTask1;
		public  ProcessScriptTask ScriptTask1 {
			get {
				return _scriptTask1 ?? (_scriptTask1 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask1",
					SchemaElementUId = new Guid("a11a4e81-6c06-44b4-a347-a3ddac4888e0"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask1Execute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess1.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess1 };
			FlowElements[StartMessage1.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage1 };
			FlowElements[ScriptTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask1 };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess1":
						break;
					case "StartMessage1":
						e.Context.QueueTasks.Enqueue("ScriptTask1");
						break;
					case "ScriptTask1":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("StartMessage1");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "EventSubProcess1":
					context.QueueTasks.Dequeue();
					break;
				case "StartMessage1":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage1";
					result = StartMessage1.Execute(context);
					break;
				case "ScriptTask1":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask1";
					result = ScriptTask1.Execute(context, ScriptTask1Execute);
					break;
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

		public virtual bool ScriptTask1Execute(ProcessExecutingContext context) {
						//CreateLeadTestPage
			
						List<Guid> contacts = new List<Guid>();
						contacts.Add(new Guid("9BFC41F1-E3AD-4B5C-8CF6-703DE58725F1"));
			
						Guid campaignStepId = new Guid("025B8ACE-5079-420F-B3B1-D9908BE14C1E");
			
			
			
					/// <summary>
					/// Десериализует значения фильтров шагов кампании.
					/// </summary>
					/// <param name="jsonVlaue">Контейнер фильтров в JSON формате.</param>
					/// <returns>Возвращает список уникальных идентификаторов.</returns>
					//private List<Guid> DeserializeRouteFilterIds(string jsonValue) {
			
						Entity leadTemplateEntity =
							UserConnection.EntitySchemaManager.GetInstanceByName("Lead").CreateEntity(UserConnection);
						leadTemplateEntity.SetDefColumnValues();
						var esq = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "CampaignStep");
						esq.AddColumn("JSON");
						var campaignStep = esq.GetEntity(UserConnection, campaignStepId);
						if (campaignStep == null) {
							return true;
						}
						var campaignStepJson = campaignStep.GetTypedColumnValue<string>("JSON");
						IList<Dictionary<string, object>> leadDefaultValues = new List<Dictionary<string, object>>();
						JObject jsonData = Terrasoft.Common.Json.Json.Deserialize(campaignStepJson) as JObject;
						if (jsonData == null) {
							return true;
						}
						JObject JsonInfoData = jsonData["addInfo"] as JObject;
						if (JsonInfoData != null) {
							JArray createLeadDefaultValues = JsonInfoData["CreateLeadDefaultValues"] as JArray;
							if (createLeadDefaultValues != null && createLeadDefaultValues.Count > 0) {
								leadDefaultValues = createLeadDefaultValues.ToObject<IList<Dictionary<string, object>>>();
							}
						}
						string columnNameKey = "ColumnName";
						string columnValueKey = "ColumnValue";
						foreach (Dictionary<string, object> leadDefaultValue in leadDefaultValues) {
							if (!leadDefaultValue.ContainsKey(columnNameKey) || !leadDefaultValue.ContainsKey(columnValueKey)) {
								continue;
							}
							string columnName = (string)leadDefaultValue[columnNameKey];
							object columnValue = (object)leadDefaultValue[columnValueKey];
							if (columnValue == null) {
								continue;
							}
							var leadTemplateColumn = leadTemplateEntity.Schema.Columns.FindByName(columnName);
							if (leadTemplateColumn == null) {
								continue;
							}
							leadTemplateEntity.SetColumnValue(leadTemplateColumn, columnValue);
						}
			
						foreach (Guid contactId in contacts) {
							Entity leadItem = (Entity)leadTemplateEntity.Clone();
							leadItem.SetColumnValue("Id", Guid.NewGuid());
							leadItem.SetColumnValue("QualifiedContactId", contactId);
							leadItem.Save();
							leadItem = null;
						}
						
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "Button1Click":
							if (ActivatedEventElements.Contains("StartMessage1")) {
							context.QueueTasks.Enqueue("StartMessage1");
						}
						break;
			}
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

	#region Class: CreateLeadTestPageEventsProcess

	/// <exclude/>
	public class CreateLeadTestPageEventsProcess : CreateLeadTestPageEventsProcess<Terrasoft.WebApp.CreateLeadTestPageSchemaUserControl>
	{

		public CreateLeadTestPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: CreateLeadTestPageSchemaUserControl

	/// <exclude/>
	public partial class CreateLeadTestPageSchemaUserControl : Terrasoft.UI.WebControls.PageSchemaUserControl
	{

		#region Properties: Public

		public  Terrasoft.UI.WebControls.Controls.Button Button1 {
			get {
				return (Terrasoft.UI.WebControls.Controls.Button)PageContainer.FindPageControl("Button1", true);
			}
		}

		private Terrasoft.UI.WebControls.Controls.ScriptManager _scriptManager;
		public  Terrasoft.UI.WebControls.Controls.ScriptManager ScriptManager {
			get {
				if (this._scriptManager != null) {
					return this._scriptManager;
				}
				if (!this.DesignMode && this.Page != null) {
					this._scriptManager = ScriptManager.GetCurrent(this.Page);
					if (this._scriptManager != null) {
						return this._scriptManager;
					}
				}
				if (this.Page != null) {
					this._scriptManager = ControlUtilities.FindControl(this.Page,
						"Terrasoft.UI.WebControls.ScriptManagerProxy") as ScriptManager;
					if (this._scriptManager != null) {
						return this._scriptManager;
					}
					this._scriptManager = (ScriptManager)ControlUtilities.FindControl(this.Page,
						"Terrasoft.UI.WebControls.ScriptManager");
					if (this.DesignMode && this._scriptManager == null) {
						this._scriptManager = new ScriptManager();
						this.Page.Controls.Add(this._scriptManager);
					}
				}
				if (this._scriptManager == null) {
					throw new InvalidOperationException("The Terrasoft Script Manager Control " +
						"is missing from this Page." +
						Environment.NewLine + Environment.NewLine +
						"Please add the following Script Manager tag inside the <body> or " +
						"<form> of this Page." +
						Environment.NewLine + Environment.NewLine + "Example" +
						Environment.NewLine + Environment.NewLine +
						" <ext:Script Manager runat=\"server\" />");
				}
				return this._scriptManager;
			}
		}

		#endregion

		#region Methods: Protected

		protected override void PageLoadComplete(object sender, EventArgs e) {
			if (!((PageContainer)PageContainer).IsPageLoadCompleted) {
				((PageContainer)PageContainer).IsPageLoadCompleted = true;
				ThrowEvent("PageLoadComplete");
			}
		}

		protected override void SubscribeOnControlEvents() {
			base.SubscribeOnControlEvents();
			Button1.AjaxEvents.Click.Event += Button1Click;
		}

		protected override void UnsubscribeOnControlEvents() {
			base.UnsubscribeOnControlEvents();
			Button1.AjaxEvents.Click.Event -= Button1Click;
		}

		protected override void InitializeEmbeddedProcess() {
			var instanceId = ((Terrasoft.UI.WebControls.Page)Page).InstanceId.ToString();
			string processUId = instanceId + PageContainer.UniqueID;
			var process = (CreateLeadTestPageEventsProcess)UserConnection.IProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new CreateLeadTestPageEventsProcess(UserConnection);
				process.Page = this;
				Process = process;
				UserConnection.IProcessEngine.SetProcess(process);
				process.Execute(UserConnection);
				UserConnection.IProcessEngine.SetProcessPropertiesData(process);
			} else {
				process.InternalContext = new ProcessExecutingContext(UserConnection) {
					Process = process
				};
				process.Page = this;
				Process = process;
				UserConnection.IProcessEngine.SetProcess(process);
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

		public virtual void Button1Click(object sender, EventArgs e) {
			object result = ThrowEvent("Button1Click");
		}

		public virtual void ThrowClientEvent(string message, params object[] parameters) {
			string key = CopyParameters(parameters);
			ScriptManager.AddScript("if (window.opener) { if (window.key) {window.opener.Terrasoft.AjaxMethods.ThrowClientEvent(window.key, '" + message + "', '" + key + "')}}");
		}

		public virtual void AjaxRefresh() {
			ScriptManager.AddScript("window.Terrasoft.AjaxMethods.ThrowClientEvent(null, null);");
		}

		public virtual void AddScript(string script) {
			this.ScriptManager.AddScript(script);
		}

		public virtual void RegisterClientScriptIncludeInternal(string key, string resourceName) {
			this.ScriptManager.RegisterClientScriptIncludeInternal(key, resourceName);
		}

		public virtual void RegisterClientScriptBlock(string key, string script) {
			this.ScriptManager.RegisterClientScriptBlock(key, script);
		}

		public override void SetSchemaName() {
			SchemaName = "CreateLeadTestPage";
		}

		#endregion

	}

	#endregion

	#region Class: CreateLeadTestPageEventsProcessSchema

	/// <exclude/>
	public class CreateLeadTestPageEventsProcessSchema : Terrasoft.Core.Process.EmbeddedProcessSchema
	{

		#region Constructors: Public

		public CreateLeadTestPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public CreateLeadTestPageEventsProcessSchema(CreateLeadTestPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "CreateLeadTestPageEventsProcess";
			UId = new Guid("d74c9e07-0deb-4eeb-9c0a-4a0b270db717");
			CreatedInPackageId = new Guid("1ac017e5-6977-4f88-8d97-6d00b9321f95");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet1 = CreateLaneSet1LaneSet();
			LaneSets.Add(schemaLaneSet1);
			ProcessSchemaLane schemaLane1 = CreateLane1Lane();
			schemaLaneSet1.Lanes.Add(schemaLane1);
			ProcessSchemaEventSubProcess eventsubprocess1 = CreateEventSubProcess1EventSubProcess();
			FlowElements.Add(eventsubprocess1);
			ProcessSchemaStartMessageEvent startmessage1 = CreateStartMessage1StartMessageEvent();
			eventsubprocess1.FlowElements.Add(startmessage1);
			ProcessSchemaScriptTask scripttask1 = CreateScriptTask1ScriptTask();
			eventsubprocess1.FlowElements.Add(scripttask1);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("1e2ed396-12d7-4703-b415-d33b85c8e7c3"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1ac017e5-6977-4f88-8d97-6d00b9321f95"),
				CreatedInSchemaUId = new Guid("d74c9e07-0deb-4eeb-9c0a-4a0b270db717"),
				CurveCenterPosition = new Point(380, 188),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("d74c9e07-0deb-4eeb-9c0a-4a0b270db717"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("6aab2f3f-6250-437a-b4f6-a65803889438"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("a11a4e81-6c06-44b4-a347-a3ddac4888e0"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("741900df-2d46-4f3e-93a7-9fe8033a369e"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1ac017e5-6977-4f88-8d97-6d00b9321f95"),
				CreatedInSchemaUId = new Guid("d74c9e07-0deb-4eeb-9c0a-4a0b270db717"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("d74c9e07-0deb-4eeb-9c0a-4a0b270db717"),
				Name = @"LaneSet1",
				Position = new Point(5, 5),
				Size = new Size(832, 159)
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("9d5fb6b3-cedf-4ab3-8a27-b5f89333a3a4"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("741900df-2d46-4f3e-93a7-9fe8033a369e"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("1ac017e5-6977-4f88-8d97-6d00b9321f95"),
				CreatedInSchemaUId = new Guid("d74c9e07-0deb-4eeb-9c0a-4a0b270db717"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("d74c9e07-0deb-4eeb-9c0a-4a0b270db717"),
				Name = @"Lane1",
				Position = new Point(29, 0),
				Size = new Size(803, 159)
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess1EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess1 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("9c237489-7a4f-4ac1-81da-35025c998641"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("9d5fb6b3-cedf-4ab3-8a27-b5f89333a3a4"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1ac017e5-6977-4f88-8d97-6d00b9321f95"),
				CreatedInSchemaUId = new Guid("d74c9e07-0deb-4eeb-9c0a-4a0b270db717"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("d74c9e07-0deb-4eeb-9c0a-4a0b270db717"),
				Name = @"EventSubProcess1",
				Position = new Point(36, 10),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(178, 135),
				TriggeredByEvent = true,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess1;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage1StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("6aab2f3f-6250-437a-b4f6-a65803889438"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("9c237489-7a4f-4ac1-81da-35025c998641"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1ac017e5-6977-4f88-8d97-6d00b9321f95"),
				CreatedInSchemaUId = new Guid("d74c9e07-0deb-4eeb-9c0a-4a0b270db717"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("429178f5-d44a-40d6-8b74-e72cad04ee73"),
				Message = @"Button1Click",
				ModifiedInSchemaUId = new Guid("d74c9e07-0deb-4eeb-9c0a-4a0b270db717"),
				Name = @"StartMessage1",
				Position = new Point(14, 49),
				SerializeToDB = false,
				Size = new Size(0, 0)
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask1ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("a11a4e81-6c06-44b4-a347-a3ddac4888e0"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("9c237489-7a4f-4ac1-81da-35025c998641"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("1ac017e5-6977-4f88-8d97-6d00b9321f95"),
				CreatedInSchemaUId = new Guid("d74c9e07-0deb-4eeb-9c0a-4a0b270db717"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("d74c9e07-0deb-4eeb-9c0a-4a0b270db717"),
				Name = @"ScriptTask1",
				Position = new Point(77, 35),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,86,219,110,219,70,16,125,150,1,255,195,134,15,1,9,72,148,100,91,181,141,200,2,44,74,10,228,166,78,83,187,125,49,252,176,21,87,14,3,114,169,146,75,7,106,83,160,113,91,180,69,11,20,40,250,212,175,48,210,6,118,157,196,249,5,242,143,58,123,161,180,162,168,198,128,76,75,187,51,231,156,153,61,28,178,82,169,212,235,78,68,48,35,143,8,118,143,73,204,62,197,103,100,125,109,125,173,82,169,60,242,98,214,126,152,120,110,7,141,66,202,240,136,197,104,15,81,242,28,205,119,76,235,129,136,205,3,236,125,215,53,121,8,223,53,141,221,238,192,217,106,14,154,181,254,230,126,175,182,213,109,57,181,29,103,240,81,109,187,177,217,235,183,118,182,55,90,131,166,97,113,12,129,194,147,208,8,7,19,236,157,209,35,70,38,67,87,49,74,184,198,70,171,187,179,239,244,107,173,198,246,110,109,107,163,49,168,117,55,187,205,90,111,119,183,177,211,237,55,183,156,102,223,144,104,18,177,94,175,163,118,156,4,1,142,166,157,124,33,253,51,125,157,189,132,191,239,210,235,244,50,125,3,215,171,236,123,248,125,129,210,171,244,93,122,153,253,148,190,134,255,215,217,239,40,251,1,118,223,100,191,101,23,16,125,155,190,66,217,207,144,242,183,248,154,222,192,215,183,233,123,184,66,112,122,109,207,24,235,69,202,246,4,71,56,64,20,7,100,207,120,22,135,244,11,31,39,196,232,164,127,1,210,187,236,2,248,254,5,16,144,180,204,8,159,131,163,199,135,124,227,22,150,222,130,62,136,183,219,117,129,57,167,136,8,75,34,26,119,210,63,32,237,42,125,5,177,151,217,47,32,142,23,6,245,190,135,130,94,194,214,13,130,98,185,96,46,31,136,128,255,215,236,71,4,11,255,240,178,1,252,90,104,184,17,68,183,82,5,208,229,248,146,112,18,121,231,96,27,205,10,168,71,98,18,121,216,247,190,38,159,133,9,35,3,207,103,36,26,186,177,25,179,200,163,103,72,20,142,253,132,88,232,27,117,226,125,202,60,54,69,190,112,95,48,241,1,82,45,237,137,253,202,231,128,233,132,148,146,17,243,66,106,203,205,163,209,83,18,224,79,48,5,179,70,246,67,194,134,52,102,152,142,72,119,122,8,45,54,13,238,102,195,178,165,181,101,142,185,136,164,124,187,76,108,31,17,214,35,99,39,244,147,64,170,141,115,147,159,227,8,145,248,43,101,73,93,202,147,132,68,69,134,50,173,85,100,56,154,189,13,5,12,160,252,198,145,156,166,193,143,219,208,56,245,59,2,200,121,52,212,92,90,86,181,112,251,40,20,111,140,204,69,20,168,33,241,125,113,16,188,205,242,112,17,139,18,34,51,190,45,101,63,128,19,4,5,250,18,151,114,60,157,16,87,235,88,91,30,120,103,177,148,161,240,74,207,19,66,225,238,80,81,85,20,126,249,12,212,119,58,194,6,208,123,156,248,76,118,94,159,55,255,147,152,31,208,193,99,177,32,140,214,195,12,67,250,49,137,34,28,135,99,102,59,97,16,192,169,240,18,228,69,243,171,89,44,210,66,56,70,10,110,222,194,57,238,221,218,151,235,225,136,67,58,14,149,166,28,230,196,192,174,203,215,141,211,82,186,133,180,123,5,202,131,125,40,108,138,70,179,233,93,108,156,158,125,98,56,229,113,138,89,96,73,98,233,149,21,168,74,4,186,127,127,21,49,180,57,161,12,117,80,99,166,180,82,118,172,171,210,143,67,217,133,246,7,221,50,59,117,213,108,121,85,163,102,36,204,200,135,193,199,4,102,9,220,118,179,5,227,193,114,160,32,95,136,20,43,42,116,28,130,216,209,83,100,174,86,179,100,93,228,209,101,59,207,90,194,123,124,175,184,13,173,131,135,168,71,99,16,98,46,20,96,161,23,47,208,93,226,243,58,172,121,243,249,147,217,163,185,47,85,151,150,219,4,149,171,49,109,21,121,78,22,180,156,42,32,89,184,222,63,14,33,87,87,65,228,242,78,117,171,233,0,5,143,175,16,207,167,146,62,184,229,137,1,125,217,52,23,227,215,150,33,177,61,240,168,171,30,18,243,170,44,77,78,25,238,221,84,149,63,74,52,55,149,96,87,245,254,89,179,209,177,232,58,249,86,36,95,176,224,133,8,140,149,191,109,205,36,105,143,209,33,35,1,63,9,185,100,149,168,114,252,144,146,217,205,147,231,20,197,26,67,215,168,138,247,46,251,144,60,23,239,95,214,7,115,158,36,48,78,199,30,127,24,40,185,70,117,46,125,57,29,159,47,11,65,178,221,250,28,93,95,211,7,236,127,79,167,156,205,182,10,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new CreateLeadTestPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d74c9e07-0deb-4eeb-9c0a-4a0b270db717"));
		}

		#endregion

	}

	#endregion

}

