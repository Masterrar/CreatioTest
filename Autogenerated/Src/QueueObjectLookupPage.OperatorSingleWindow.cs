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

	#region Class: QueueObjectLookupPageSchema

	/// <exclude/>
	public class QueueObjectLookupPageSchema : Terrasoft.WebApp.BaseManyToManyGridPageSchema
	{

		#region Constructors: Public

		public QueueObjectLookupPageSchema(PageSchemaManager pageSchemaManager)
			: base(pageSchemaManager) {
		}

		public QueueObjectLookupPageSchema(QueueObjectLookupPageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private void UpdateParentTab() {
			ParentTab.Image = new ControlImage {};
			ParentTab.ModifiedInSchemaUId = new Guid("06adf5f6-7f9a-45cf-a58a-31832290afbd");
		}

		private void UpdateDetailTab() {
			DetailTab.Image = new ControlImage {};
			DetailTab.ModifiedInSchemaUId = new Guid("06adf5f6-7f9a-45cf-a58a-31832290afbd");
		}

		private void UpdateCloseButton() {
			CloseButton.AjaxEvents.Click.IsProcessEventHandler = true;
			CloseButton.Image = new ControlImage {};
			CloseButton.ModifiedInSchemaUId = new Guid("06adf5f6-7f9a-45cf-a58a-31832290afbd");
		}

		private void UpdateButtonsControlLayout() {
			ButtonsControlLayout.Image = new ControlImage {};
			ButtonsControlLayout.ModifiedInSchemaUId = new Guid("06adf5f6-7f9a-45cf-a58a-31832290afbd");
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("06adf5f6-7f9a-45cf-a58a-31832290afbd");
			RealUId = new Guid("06adf5f6-7f9a-45cf-a58a-31832290afbd");
			Name = "QueueObjectLookupPage";
			ParentSchemaUId = new Guid("52f8c0bc-211e-42e7-a3cc-62a947032cf3");
			CreatedInPackageId = new Guid("7be0af39-38cd-442a-b589-d8f3ef3f4d19");
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateQueueObjectLookupPageEventsProcessSchema();
		}

		protected override void InitializeControls() {
			base.InitializeControls();
			UpdateButtonsControlLayout();
			UpdateCloseButton();
			UpdateDetailTab();
			UpdateParentTab();
			TopLevelControl.MoveItem(0, BaseMessagePanel);
			TopLevelControl.MoveItem(1, ParentTabPanel);
			ParentTabPanel.MoveItem(0, ParentTab);
			TopLevelControl.MoveItem(2, DetailTabPanel);
			DetailTabPanel.MoveItem(0, DetailTab);
			TopLevelControl.MoveItem(3, ButtonsControlLayout);
			ButtonsControlLayout.MoveItem(0, Spacer1);
			ButtonsControlLayout.MoveItem(1, CloseButton);
			SetControlsDefInheritance(UId);
			InitializeLocalizableValues();
		}

		protected virtual EmbeddedProcessSchema CreateQueueObjectLookupPageEventsProcessSchema() {
			var schema = new QueueObjectLookupPageEventsProcessSchema(ProcessSchemaManager, this);
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
			return new QueueObjectLookupPageSchemaUserControl();
		}

		public override object Clone() {
			return new QueueObjectLookupPageSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("06adf5f6-7f9a-45cf-a58a-31832290afbd"));
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new QueueObjectLookupPageEventsProcess(userConnnection);
		}

		#endregion

	}

	#endregion

	#region Class: QueueObjectLookupPageEventsProcess

	/// <exclude/>
	public class QueueObjectLookupPageEventsProcess<TPage> : Terrasoft.WebApp.BaseManyToManyGridPageEventsProcess<TPage> where TPage : Terrasoft.WebApp.QueueObjectLookupPageSchemaUserControl
	{

		public QueueObjectLookupPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "QueueObjectLookupPageEventsProcess";
			SchemaUId = new Guid("06adf5f6-7f9a-45cf-a58a-31832290afbd");
			SchemaManagerName = "PageSchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			_detailEntitySchemaId = () => {{ return new Guid("68bf7df2-6f74-431a-9122-e2cf5edf283b"); }};
			_parentEntitySchemaId = () => {{ return new Guid("3117ccf2-594f-437b-8ce9-2a97314af997"); }};
			_detailGridPageSchemaId = () => {{ return new Guid("32cbddab-ac8b-49a1-9e58-342ffd5603c1"); }};
			_parentGridPageSchemaId = () => {{ return new Guid("87dc5a23-1ee4-4d29-8f8f-a8e81a2d484f"); }};
			_detailAssociationColumnUId = () => {{ return new Guid("2b3b281f-718b-43f4-a604-45ab2cb8cece"); }};
			_isEntityDetail = () => {{ return true; }};
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("06adf5f6-7f9a-45cf-a58a-31832290afbd");
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

		private Func<Guid> _detailEntitySchemaId;
		public override Guid DetailEntitySchemaId {
			get {
				return (_detailEntitySchemaId ?? (_detailEntitySchemaId = () => Guid.Empty)).Invoke();
			}
			set {
				_detailEntitySchemaId = () => { return value; };
			}
		}

		private Func<Guid> _parentEntitySchemaId;
		public override Guid ParentEntitySchemaId {
			get {
				return (_parentEntitySchemaId ?? (_parentEntitySchemaId = () => Guid.Empty)).Invoke();
			}
			set {
				_parentEntitySchemaId = () => { return value; };
			}
		}

		private Func<Guid> _detailGridPageSchemaId;
		public override Guid DetailGridPageSchemaId {
			get {
				return (_detailGridPageSchemaId ?? (_detailGridPageSchemaId = () => Guid.Empty)).Invoke();
			}
			set {
				_detailGridPageSchemaId = () => { return value; };
			}
		}

		private Func<Guid> _parentGridPageSchemaId;
		public override Guid ParentGridPageSchemaId {
			get {
				return (_parentGridPageSchemaId ?? (_parentGridPageSchemaId = () => Guid.Empty)).Invoke();
			}
			set {
				_parentGridPageSchemaId = () => { return value; };
			}
		}

		private Func<Guid> _detailAssociationColumnUId;
		public override Guid DetailAssociationColumnUId {
			get {
				return (_detailAssociationColumnUId ?? (_detailAssociationColumnUId = () => Guid.Empty)).Invoke();
			}
			set {
				_detailAssociationColumnUId = () => { return value; };
			}
		}

		private Func<bool> _isEntityDetail;
		public override bool IsEntityDetail {
			get {
				return (_isEntityDetail ?? (_isEntityDetail = () => false)).Invoke();
			}
			set {
				_isEntityDetail = () => { return value; };
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

	#region Class: QueueObjectLookupPageEventsProcess

	/// <exclude/>
	public class QueueObjectLookupPageEventsProcess : QueueObjectLookupPageEventsProcess<Terrasoft.WebApp.QueueObjectLookupPageSchemaUserControl>
	{

		public QueueObjectLookupPageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: QueueObjectLookupPageSchemaUserControl

	/// <exclude/>
	public partial class QueueObjectLookupPageSchemaUserControl : Terrasoft.WebApp.BaseManyToManyGridPageSchemaUserControl
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
			var process = (QueueObjectLookupPageEventsProcess)UserConnection.ProcessEngine.FindProcessByUId(processUId);
			if (process == null) {
				process = new QueueObjectLookupPageEventsProcess(UserConnection);
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
			SchemaName = "QueueObjectLookupPage";
		}

		#endregion

	}

	#endregion

	#region Class: QueueObjectLookupPageEventsProcessSchema

	/// <exclude/>
	public class QueueObjectLookupPageEventsProcessSchema : Terrasoft.WebApp.BaseManyToManyGridPageEventsProcessSchema
	{

		#region Constructors: Public

		public QueueObjectLookupPageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public QueueObjectLookupPageEventsProcessSchema(QueueObjectLookupPageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "QueueObjectLookupPageEventsProcess";
			UId = new Guid("4acff4e9-4765-41a1-b0c1-5976779072a5");
			CreatedInPackageId = new Guid("7be0af39-38cd-442a-b589-d8f3ef3f4d19");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsActiveVersion = false;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("cee0fdd2-3755-478a-968f-cef13f4d8106");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
		}

		protected override ProcessSchemaParameter CreateDetailEntitySchemaIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("3cf599b4-f243-4acd-9d67-a0292daae811"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cee0fdd2-3755-478a-968f-cef13f4d8106"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cee0fdd2-3755-478a-968f-cef13f4d8106"),
				Name = @"DetailEntitySchemaId",
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					Value = @"new Guid(""68bf7df2-6f74-431a-9122-e2cf5edf283b"")",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("4acff4e9-4765-41a1-b0c1-5976779072a5"),
				},
			};
		}

		protected override ProcessSchemaParameter CreateParentEntitySchemaIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("a829d18d-51e5-4958-ad5e-e7550829314e"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cee0fdd2-3755-478a-968f-cef13f4d8106"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cee0fdd2-3755-478a-968f-cef13f4d8106"),
				Name = @"ParentEntitySchemaId",
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					Value = @"new Guid(""3117ccf2-594f-437b-8ce9-2a97314af997"")",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("4acff4e9-4765-41a1-b0c1-5976779072a5"),
				},
			};
		}

		protected override ProcessSchemaParameter CreateDetailGridPageSchemaIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("5679387a-88f4-467c-a86c-ddf43c026d22"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cee0fdd2-3755-478a-968f-cef13f4d8106"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cee0fdd2-3755-478a-968f-cef13f4d8106"),
				Name = @"DetailGridPageSchemaId",
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					Value = @"new Guid(""32cbddab-ac8b-49a1-9e58-342ffd5603c1"")",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("4acff4e9-4765-41a1-b0c1-5976779072a5"),
				},
			};
		}

		protected override ProcessSchemaParameter CreateParentGridPageSchemaIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("7e22cecf-d803-48ad-8b21-7e36649a91f2"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cee0fdd2-3755-478a-968f-cef13f4d8106"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cee0fdd2-3755-478a-968f-cef13f4d8106"),
				Name = @"ParentGridPageSchemaId",
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					Value = @"new Guid(""87dc5a23-1ee4-4d29-8f8f-a8e81a2d484f"")",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("4acff4e9-4765-41a1-b0c1-5976779072a5"),
				},
			};
		}

		protected override ProcessSchemaParameter CreateDetailAssociationColumnUIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("36e305b7-8b19-40b1-905c-5a707a6a27a1"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cee0fdd2-3755-478a-968f-cef13f4d8106"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cee0fdd2-3755-478a-968f-cef13f4d8106"),
				Name = @"DetailAssociationColumnUId",
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					Value = @"new Guid(""2b3b281f-718b-43f4-a604-45ab2cb8cece"")",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("4acff4e9-4765-41a1-b0c1-5976779072a5"),
				},
			};
		}

		protected override ProcessSchemaParameter CreateIsEntityDetailParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("4e5280bb-bb86-4f36-bd05-e0d2920dbbd5"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("cee0fdd2-3755-478a-968f-cef13f4d8106"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("cee0fdd2-3755-478a-968f-cef13f4d8106"),
				Name = @"IsEntityDetail",
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					Value = @"true",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("4acff4e9-4765-41a1-b0c1-5976779072a5"),
				},
			};
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
				UId = new Guid("46b4da2e-0028-4749-9503-d1d38c64a418"),
				Name = "System.Linq",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new QueueObjectLookupPageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("4acff4e9-4765-41a1-b0c1-5976779072a5"));
		}

		#endregion

	}

	#endregion

}

