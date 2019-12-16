namespace Terrasoft.Configuration
{

	using DataContract = Terrasoft.Nui.ServiceModel.DataContract;
	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Data;
	using System.Drawing;
	using System.Globalization;
	using System.IO;
	using System.Linq;
	using System.Text;
	using Terrasoft.Common;
	using Terrasoft.Common.Json;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.DcmProcess;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Factories;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;
	using Terrasoft.Core.Store;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities.Json.Converters;

	#region Class: Activity_OperatorSingleWindow_TerrasoftSchema

	/// <exclude/>
	public class Activity_OperatorSingleWindow_TerrasoftSchema : Terrasoft.Configuration.Activity_CaseService_TerrasoftSchema
	{

		#region Constructors: Public

		public Activity_OperatorSingleWindow_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public Activity_OperatorSingleWindow_TerrasoftSchema(Activity_OperatorSingleWindow_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public Activity_OperatorSingleWindow_TerrasoftSchema(Activity_OperatorSingleWindow_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private EntitySchemaIndex CreateIMBQHMXCKGjle42hQVBJkGeeQSBAIndex() {
			EntitySchemaIndex index = new EntitySchemaIndex() {
				IsAutoName = true,
				IsClustered = false,
				IsUnique = false
			};
			index.UId = new Guid("cfe2f65b-f8e3-4b11-a0cd-25fdc94133b8");
			index.Name = "IMBQHMXCKGjle42hQVBJkGeeQSBA";
			index.CreatedInSchemaUId = new Guid("9be065d4-2265-401d-a052-a4af3beb90ba");
			index.ModifiedInSchemaUId = new Guid("9be065d4-2265-401d-a052-a4af3beb90ba");
			index.CreatedInPackageId = new Guid("5e667a77-85ba-48fd-906c-e2f7f26b8e6d");
			EntitySchemaIndexColumn createdOnIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("149ae115-9ed5-42dc-9fdb-ec2cd31bcc9e"),
				ColumnUId = new Guid("e80190a5-03b2-4095-90f7-a193a960adee"),
				CreatedInSchemaUId = new Guid("9be065d4-2265-401d-a052-a4af3beb90ba"),
				ModifiedInSchemaUId = new Guid("9be065d4-2265-401d-a052-a4af3beb90ba"),
				CreatedInPackageId = new Guid("5e667a77-85ba-48fd-906c-e2f7f26b8e6d"),
				OrderDirection = OrderDirectionStrict.Descending
			};
			index.Columns.Add(createdOnIndexColumn);
			return index;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("9be065d4-2265-401d-a052-a4af3beb90ba");
			Name = "Activity_OperatorSingleWindow_Terrasoft";
			ParentSchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89");
			ExtendParent = true;
			CreatedInPackageId = new Guid("5e667a77-85ba-48fd-906c-e2f7f26b8e6d");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("8235b9b7-a369-44f2-98e4-aa7d291da2c9")) == null) {
				Columns.Add(CreateQueueItemColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateQueueItemColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("8235b9b7-a369-44f2-98e4-aa7d291da2c9"),
				Name = @"QueueItem",
				ReferenceSchemaUId = new Guid("aadf2fcd-684b-4414-8317-bf9879e97569"),
				IsIndexed = true,
				IsWeakReference = true,
				CreatedInSchemaUId = new Guid("9be065d4-2265-401d-a052-a4af3beb90ba"),
				ModifiedInSchemaUId = new Guid("9be065d4-2265-401d-a052-a4af3beb90ba"),
				CreatedInPackageId = new Guid("5e667a77-85ba-48fd-906c-e2f7f26b8e6d")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeIndexes() {
			base.InitializeIndexes();
			Indexes.Add(CreateIMBQHMXCKGjle42hQVBJkGeeQSBAIndex());
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateActivity_OperatorSingleWindow_TerrasoftEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateActivity_OperatorSingleWindow_TerrasoftEventsProcessSchema() {
			var schema = new Activity_OperatorSingleWindow_TerrasoftEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new Activity_OperatorSingleWindow_Terrasoft(userConnection){Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new Activity_OperatorSingleWindowEventsProcess(userConnnection);
		}

		public override object Clone() {
			return new Activity_OperatorSingleWindow_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new Activity_OperatorSingleWindow_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("9be065d4-2265-401d-a052-a4af3beb90ba"));
		}

		#endregion

	}

	#endregion

	#region Class: Activity_OperatorSingleWindow_Terrasoft

	/// <summary>
	/// Activity.
	/// </summary>
	public class Activity_OperatorSingleWindow_Terrasoft : Terrasoft.Configuration.Activity_CaseService_Terrasoft
	{

		#region Constructors: Public

		public Activity_OperatorSingleWindow_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Activity_OperatorSingleWindow_Terrasoft";
		}

		public Activity_OperatorSingleWindow_Terrasoft(Activity_OperatorSingleWindow_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public  Guid QueueItemId {
			get {
				return GetTypedColumnValue<Guid>("QueueItemId");
			}
			set {
				SetColumnValue("QueueItemId", value);
				_queueItem = null;
			}
		}

		/// <exclude/>
		public  string QueueItemCaption {
			get {
				return GetTypedColumnValue<string>("QueueItemCaption");
			}
			set {
				SetColumnValue("QueueItemCaption", value);
				if (_queueItem != null) {
					_queueItem.Caption = value;
				}
			}
		}

		private VwQueueItem _queueItem;
		/// <summary>
		/// Queue item.
		/// </summary>
		public  VwQueueItem QueueItem {
			get {
				return _queueItem ??
					(_queueItem = LookupColumnEntities.GetEntity("QueueItem") as VwQueueItem);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new Activity_OperatorSingleWindowEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new Activity_OperatorSingleWindow_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: Activity_OperatorSingleWindowEventsProcess

	/// <exclude/>
	public class Activity_OperatorSingleWindowEventsProcess<TEntity> : Terrasoft.Configuration.Activity_CaseServiceEventsProcess<TEntity> where TEntity : Activity_OperatorSingleWindow_Terrasoft
	{

		public Activity_OperatorSingleWindowEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Activity_OperatorSingleWindowEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private  Guid InternalSchemaUId {
			get {
				return new Guid("9be065d4-2265-401d-a052-a4af3beb90ba");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
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

		public override void PrepereSynchronizeSubjectRemindingUserTask(SynchronizeSubjectRemindingUserTask userTask, Guid contact, DateTime remindTime, bool active, Guid source) {
			base.PrepereSynchronizeSubjectRemindingUserTask(userTask, contact, remindTime, active, source);
			bool isFeatureEnabled = FeatureUtilities.GetIsFeatureEnabled(UserConnection, "NotificationV2");
			if (isFeatureEnabled) {
				IRemindingTextFormer textFormer = ClassFactory.Get<ActivityRemindingTextFormer>(
					new ConstructorArgument("userConnection", UserConnection));
				string accountName = GetLookupDisplayColumnValue(Entity, "Account");
				string contactName = GetLookupDisplayColumnValue(Entity, "Contact");
				string title = Entity.GetTypedColumnValue<string>("Title");
				userTask.SubjectCaption = textFormer.GetBody(new Dictionary<string, object> {
					{"AccountName", accountName},
					{"ContactName", contactName},
					{"Title", title}
				});
				userTask.PopupTitle = textFormer.GetTitle(new Dictionary<string, object>());
			}
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

	#region Class: Activity_OperatorSingleWindowEventsProcess

	/// <exclude/>
	public class Activity_OperatorSingleWindowEventsProcess : Activity_OperatorSingleWindowEventsProcess<Activity_OperatorSingleWindow_Terrasoft>
	{

		public Activity_OperatorSingleWindowEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: Activity_OperatorSingleWindow_TerrasoftEventsProcessSchema

	/// <exclude/>
	public class Activity_OperatorSingleWindow_TerrasoftEventsProcessSchema : Terrasoft.Configuration.Activity_CaseService_TerrasoftEventsProcessSchema
	{

		#region Constructors: Public

		public Activity_OperatorSingleWindow_TerrasoftEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public Activity_OperatorSingleWindow_TerrasoftEventsProcessSchema(Activity_OperatorSingleWindow_TerrasoftEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "Activity_OperatorSingleWindowEventsProcess";
			UId = new Guid("b65772ff-73e6-4430-a293-a7844465cd1d");
			CreatedInPackageId = new Guid("5e667a77-85ba-48fd-906c-e2f7f26b8e6d");
			CreatedInSchemaUId = Guid.Empty;
			CreatedInVersion = @"0.0.0.0";
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797");
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
				UId = new Guid("f83cbea2-10c5-4739-96f1-116937efce77"),
				Name = "Terrasoft.Core.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("19024591-23ea-4b03-9800-93149198129b"),
				Name = "Terrasoft.Core.DB",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("fb7b81ba-7c3c-45a5-ae9e-c6c03dceb812"),
				Name = "Terrasoft.UI.WebControls.Controls",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("cde525cf-d220-4d2a-b963-e55254c639fc"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7821de68-c82b-4917-a6cd-add2adfbe400"),
				Name = "Terrasoft.Common",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d67de76f-9cbc-4bfc-babb-6f65cb89b973"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("74160d3b-65e3-4694-b554-089f2d980e54"),
				Name = "Newtonsoft.Json",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e401300a-9f16-40c2-9788-cf310ae9d1c5"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("ca241c6a-6bd2-4e33-ae26-164063bfb504"),
				Name = "System.Text",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("ed374225-e41d-4643-8234-a4c89997d648"),
				Name = "System.Linq",
				Alias = "",
				CreatedInPackageId = new Guid("9b2ffa7b-51c7-46d9-b749-4bade78db945")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("49a41b26-e223-4e0d-a40a-f81877cefa7a"),
				Name = "Terrasoft.Core.Store",
				Alias = "",
				CreatedInPackageId = new Guid("a99d7388-fb0e-4870-87fc-76975bec5847")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d5bb3512-71e0-482a-9c7e-16bf22c586b7"),
				Name = "Terrasoft.Nui.ServiceModel.DataContract",
				Alias = "DataContract",
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("b261d1c9-cc98-44e8-aabd-7806d1dc26ed"),
				Name = "Terrasoft.Core.Factories",
				Alias = "",
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("c261d1c9-cc98-44e8-aabd-7806d1dc26ec"),
				Name = "Terrasoft.Core.DcmProcess",
				Alias = "",
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			});
		}

		protected override SchemaMethod CreatePrepereSynchronizeSubjectRemindingUserTaskMethod() {
			SchemaMethod method = base.CreatePrepereSynchronizeSubjectRemindingUserTaskMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,146,205,110,194,48,16,132,207,225,41,172,156,140,100,113,232,181,128,68,3,84,72,21,66,37,112,119,146,133,186,36,222,200,63,109,83,148,119,175,157,164,37,160,74,85,79,113,236,157,217,111,214,78,184,134,209,70,65,9,10,182,149,76,95,20,74,241,9,91,155,188,66,106,158,161,16,50,19,242,184,211,160,98,174,79,212,118,11,70,82,148,134,167,134,17,213,20,197,162,0,70,220,134,120,115,95,141,86,165,48,188,31,36,136,57,17,122,9,220,88,5,11,201,147,28,50,50,33,221,198,206,136,92,24,1,122,244,8,102,117,83,70,125,215,8,165,116,36,2,37,35,225,26,141,56,136,148,251,223,253,93,232,252,197,129,208,91,251,33,57,15,130,213,15,123,12,31,102,137,170,0,69,204,101,57,33,81,206,181,94,58,98,84,149,111,63,158,121,120,97,170,95,148,83,58,8,2,9,239,196,225,104,163,172,23,205,212,209,22,32,13,13,237,21,103,200,200,53,248,208,113,6,78,229,28,221,128,82,180,210,172,121,1,14,193,117,125,66,60,217,114,46,116,153,243,42,194,220,22,114,207,115,11,116,33,141,99,113,161,103,173,36,236,185,116,179,255,143,75,212,74,250,46,238,36,247,250,182,198,143,32,174,74,200,122,242,113,91,57,165,97,236,107,27,241,247,11,24,117,111,36,226,165,15,233,124,46,211,245,94,15,152,85,212,143,108,46,154,41,112,85,117,118,140,96,163,156,250,123,10,206,223,1,125,154,144,245,39,84,179,230,60,186,164,13,89,63,123,119,222,178,177,54,79,61,8,234,43,204,13,150,182,140,187,168,215,136,205,238,31,140,212,223,94,253,5,167,166,64,242,39,3,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new Activity_OperatorSingleWindow_TerrasoftEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b65772ff-73e6-4430-a293-a7844465cd1d"));
		}

		#endregion

	}

	#endregion

}

