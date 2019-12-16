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
	using Terrasoft.GlobalSearch.Indexing;
	using Terrasoft.Messaging.Common;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities.Json.Converters;

	#region Class: MailServerSchema

	/// <exclude/>
	public class MailServerSchema : Terrasoft.Configuration.MailServer_Base_TerrasoftSchema
	{

		#region Constructors: Public

		public MailServerSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public MailServerSchema(MailServerSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public MailServerSchema(MailServerSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("ba3d9f48-19a3-446a-ab3a-4fffeeba7983");
			Name = "MailServer";
			ParentSchemaUId = new Guid("7ba8351f-9a61-49e6-9e0d-8b32ed25c4c4");
			ExtendParent = true;
			CreatedInPackageId = new Guid("24c6dcbf-ddce-46c1-876f-ee548e2ae17a");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("ff05d2f5-bc16-4d80-b361-13120a07867e")) == null) {
				Columns.Add(CreateExchangeEmailAddressColumn());
			}
			if (Columns.FindByUId(new Guid("5a1ceded-281a-4994-bf5f-5fe57b752e0b")) == null) {
				Columns.Add(CreateIsExchengeAutodiscoverColumn());
			}
			if (Columns.FindByUId(new Guid("411a2310-81f3-4a83-896e-87eccdbae77f")) == null) {
				Columns.Add(CreateTypeColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateExchangeEmailAddressColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("ff05d2f5-bc16-4d80-b361-13120a07867e"),
				Name = @"ExchangeEmailAddress",
				CreatedInSchemaUId = new Guid("ba3d9f48-19a3-446a-ab3a-4fffeeba7983"),
				ModifiedInSchemaUId = new Guid("ba3d9f48-19a3-446a-ab3a-4fffeeba7983"),
				CreatedInPackageId = new Guid("24c6dcbf-ddce-46c1-876f-ee548e2ae17a")
			};
		}

		protected virtual EntitySchemaColumn CreateIsExchengeAutodiscoverColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("5a1ceded-281a-4994-bf5f-5fe57b752e0b"),
				Name = @"IsExchengeAutodiscover",
				CreatedInSchemaUId = new Guid("ba3d9f48-19a3-446a-ab3a-4fffeeba7983"),
				ModifiedInSchemaUId = new Guid("ba3d9f48-19a3-446a-ab3a-4fffeeba7983"),
				CreatedInPackageId = new Guid("24c6dcbf-ddce-46c1-876f-ee548e2ae17a")
			};
		}

		protected virtual EntitySchemaColumn CreateTypeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("411a2310-81f3-4a83-896e-87eccdbae77f"),
				Name = @"Type",
				ReferenceSchemaUId = new Guid("2db96124-22df-41dd-a3ce-9c12e32a78be"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("ba3d9f48-19a3-446a-ab3a-4fffeeba7983"),
				ModifiedInSchemaUId = new Guid("ba3d9f48-19a3-446a-ab3a-4fffeeba7983"),
				CreatedInPackageId = new Guid("43a72267-b2f6-464f-af52-bc7506959e73")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateMailServerEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateMailServerEventsProcessSchema() {
			var schema = new MailServerEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new MailServer(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new MailServer_ExchangeEventsProcess(userConnection);
		}

		public override object Clone() {
			return new MailServerSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new MailServerSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ba3d9f48-19a3-446a-ab3a-4fffeeba7983"));
		}

		#endregion

	}

	#endregion

	#region Class: MailServer

	/// <summary>
	/// Email provider.
	/// </summary>
	public class MailServer : Terrasoft.Configuration.MailServer_Base_Terrasoft
	{

		#region Constructors: Public

		public MailServer(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "MailServer";
		}

		public MailServer(MailServer source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Server address.
		/// </summary>
		public string ExchangeEmailAddress {
			get {
				return GetTypedColumnValue<string>("ExchangeEmailAddress");
			}
			set {
				SetColumnValue("ExchangeEmailAddress", value);
			}
		}

		/// <summary>
		/// Autodetect.
		/// </summary>
		public bool IsExchengeAutodiscover {
			get {
				return GetTypedColumnValue<bool>("IsExchengeAutodiscover");
			}
			set {
				SetColumnValue("IsExchengeAutodiscover", value);
			}
		}

		/// <exclude/>
		public Guid TypeId {
			get {
				return GetTypedColumnValue<Guid>("TypeId");
			}
			set {
				SetColumnValue("TypeId", value);
				_type = null;
			}
		}

		/// <exclude/>
		public string TypeName {
			get {
				return GetTypedColumnValue<string>("TypeName");
			}
			set {
				SetColumnValue("TypeName", value);
				if (_type != null) {
					_type.Name = value;
				}
			}
		}

		private MailServerType _type;
		/// <summary>
		/// Mail service provider type.
		/// </summary>
		public MailServerType Type {
			get {
				return _type ??
					(_type = LookupColumnEntities.GetEntity("Type") as MailServerType);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new MailServer_ExchangeEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("MailServerDeleted", e);
			Inserting += (s, e) => ThrowEvent("MailServerInserting", e);
			Saved += (s, e) => ThrowEvent("MailServerSaved", e);
			Updated += (s, e) => ThrowEvent("MailServerUpdated", e);
			Validating += (s, e) => ThrowEvent("MailServerValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new MailServer(this);
		}

		#endregion

	}

	#endregion

	#region Class: MailServer_ExchangeEventsProcess

	/// <exclude/>
	public class MailServer_ExchangeEventsProcess<TEntity> : Terrasoft.Configuration.MailServer_BaseEventsProcess<TEntity> where TEntity : MailServer
	{

		public MailServer_ExchangeEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "MailServer_ExchangeEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("ba3d9f48-19a3-446a-ab3a-4fffeeba7983");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		private ProcessFlowElement _mailServerSavedMessageScriptTaskEventSubProcess;
		public ProcessFlowElement MailServerSavedMessageScriptTaskEventSubProcess {
			get {
				return _mailServerSavedMessageScriptTaskEventSubProcess ?? (_mailServerSavedMessageScriptTaskEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "MailServerSavedMessageScriptTaskEventSubProcess",
					SchemaElementUId = new Guid("5e344bce-7db3-42b7-a8fe-de9d5b6059bb"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _mailServerSavedMessage;
		public ProcessFlowElement MailServerSavedMessage {
			get {
				return _mailServerSavedMessage ?? (_mailServerSavedMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "MailServerSavedMessage",
					SchemaElementUId = new Guid("092c1d5c-f04d-41fc-a9ed-767c9f3689e3"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _mailServerSavedMessageScriptTask;
		public ProcessScriptTask MailServerSavedMessageScriptTask {
			get {
				return _mailServerSavedMessageScriptTask ?? (_mailServerSavedMessageScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "MailServerSavedMessageScriptTask",
					SchemaElementUId = new Guid("3e5f7719-c36f-45d3-b395-5a4db0c179a0"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = MailServerSavedMessageScriptTaskExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[MailServerSavedMessageScriptTaskEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { MailServerSavedMessageScriptTaskEventSubProcess };
			FlowElements[MailServerSavedMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { MailServerSavedMessage };
			FlowElements[MailServerSavedMessageScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { MailServerSavedMessageScriptTask };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "MailServerSavedMessageScriptTaskEventSubProcess":
						break;
					case "MailServerSavedMessage":
						e.Context.QueueTasks.Enqueue("MailServerSavedMessageScriptTask");
						break;
					case "MailServerSavedMessageScriptTask":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("MailServerSavedMessage");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "MailServerSavedMessageScriptTaskEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "MailServerSavedMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "MailServerSavedMessage";
					result = MailServerSavedMessage.Execute(context);
					break;
				case "MailServerSavedMessageScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "MailServerSavedMessageScriptTask";
					result = MailServerSavedMessageScriptTask.Execute(context, MailServerSavedMessageScriptTaskExecute);
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

		public virtual bool MailServerSavedMessageScriptTaskExecute(ProcessExecutingContext context) {
			if (Entity.AllowEmailDownloading == false) {
				Update allowEmailDownloadingUpdate = new Update(UserConnection, "MailboxSyncSettings")
					.Set("EnableMailSynhronization", Column.Parameter(false))
					.Where("MailServerId").IsEqual(Column.Parameter(Entity.Id)) as Update;
				allowEmailDownloadingUpdate.Execute();
				RemoveMailboxSyncSettingsJob();
			}
			if (Entity.AllowEmailSending == false) {
				Update allowEmailSendingUpdate = new Update(UserConnection, "MailboxSyncSettings")
					.Set("SendEmailsViaThisAccount", Column.Parameter(false))
					.Where("MailServerId").IsEqual(Column.Parameter(Entity.Id)) as Update;
				allowEmailSendingUpdate.Execute();
			}
			return true;
		}

		public virtual void RemoveMailboxSyncSettingsJob() {
			Select allowEmailDownloadingSelect = new Select(UserConnection)
				.Column("SenderEmailAddress")
			.From("MailboxSyncSettings")
			.Where("MailServerId").IsEqual(Column.Parameter(Entity.Id)) as Select;
			using (DBExecutor dbExecutor = UserConnection.EnsureDBConnection()) {
				using (IDataReader reader = allowEmailDownloadingSelect.ExecuteReader(dbExecutor)) {
					while (reader.Read()) {
						#if !NETSTANDARD2_0 //TODO CRM-46901
						string senderEmailAddress = reader.GetString(reader.GetOrdinal("SenderEmailAddress"));
						if (Entity.GetTypedColumnValue<Guid>("TypeId") == ExchangeConsts.ExchangeMailServerTypeId) {
							ExchangeUtility.RemoveSyncJob(UserConnection, senderEmailAddress,
								ExchangeUtility.MailSyncProcessName);
						} else if (Entity.GetTypedColumnValue<Guid>("TypeId") == ExchangeConsts.ImapMailServerTypeId) {
							var parameters = new Dictionary<string, object> {
								{ "SenderEmailAddress", senderEmailAddress },
								{ "CurrentUserId", UserConnection.CurrentUser.Id }
							};
							Mail.MailSynchronizer.RemoveSyncJob(UserConnection, parameters);
						}
						#endif
					}
				}
			}
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "MailServerSaved":
							if (ActivatedEventElements.Contains("MailServerSavedMessage")) {
							context.QueueTasks.Enqueue("MailServerSavedMessage");
							ProcessQueue(context);
							return;
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

	#region Class: MailServer_ExchangeEventsProcess

	/// <exclude/>
	public class MailServer_ExchangeEventsProcess : MailServer_ExchangeEventsProcess<MailServer>
	{

		public MailServer_ExchangeEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: MailServerEventsProcessSchema

	/// <exclude/>
	public class MailServerEventsProcessSchema : Terrasoft.Configuration.MailServer_Base_TerrasoftEventsProcessSchema
	{

		#region Constructors: Public

		public MailServerEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public MailServerEventsProcessSchema(MailServerEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "MailServer_ExchangeEventsProcess";
			UId = new Guid("d3284964-d6ed-4978-b429-52046d51454b");
			CreatedInPackageId = new Guid("24c6dcbf-ddce-46c1-876f-ee548e2ae17a");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("3aa74e03-9154-4ed7-afad-1236b271f67f");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet2_e7f0038783cd41e483c24f58e6fe8f22 = CreateLaneSet2_e7f0038783cd41e483c24f58e6fe8f22LaneSet();
			LaneSets.Add(schemaLaneSet2_e7f0038783cd41e483c24f58e6fe8f22);
			ProcessSchemaLane schemaLane1_6b62affead744774bd2843249a5982e0 = CreateLane1_6b62affead744774bd2843249a5982e0Lane();
			schemaLaneSet2_e7f0038783cd41e483c24f58e6fe8f22.Lanes.Add(schemaLane1_6b62affead744774bd2843249a5982e0);
			ProcessSchemaEventSubProcess mailserversavedmessagescripttaskeventsubprocess = CreateMailServerSavedMessageScriptTaskEventSubProcessEventSubProcess();
			FlowElements.Add(mailserversavedmessagescripttaskeventsubprocess);
			ProcessSchemaStartMessageEvent mailserversavedmessage = CreateMailServerSavedMessageStartMessageEvent();
			mailserversavedmessagescripttaskeventsubprocess.FlowElements.Add(mailserversavedmessage);
			ProcessSchemaScriptTask mailserversavedmessagescripttask = CreateMailServerSavedMessageScriptTaskScriptTask();
			mailserversavedmessagescripttaskeventsubprocess.FlowElements.Add(mailserversavedmessagescripttask);
			FlowElements.Add(CreateSequenceFlow8_492b0e69e15a4085818a78cb661a81ccSequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow8_492b0e69e15a4085818a78cb661a81ccSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow8_492b0e69e15a4085818a78cb661a81cc",
				UId = new Guid("492b0e69-e15a-4085-818a-78cb661a81cc"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("3aa74e03-9154-4ed7-afad-1236b271f67f"),
				CreatedInPackageId = new Guid("0dceaad6-a204-4806-b152-45288d90ce02"),
				CreatedInSchemaUId = new Guid("d3284964-d6ed-4978-b429-52046d51454b"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("d3284964-d6ed-4978-b429-52046d51454b"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("092c1d5c-f04d-41fc-a9ed-767c9f3689e3"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("3e5f7719-c36f-45d3-b395-5a4db0c179a0"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet2_e7f0038783cd41e483c24f58e6fe8f22LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet2_e7f0038783cd41e483c24f58e6fe8f22 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("e7f00387-83cd-41e4-83c2-4f58e6fe8f22"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("3aa74e03-9154-4ed7-afad-1236b271f67f"),
				CreatedInPackageId = new Guid("0dceaad6-a204-4806-b152-45288d90ce02"),
				CreatedInSchemaUId = new Guid("d3284964-d6ed-4978-b429-52046d51454b"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("d3284964-d6ed-4978-b429-52046d51454b"),
				Name = @"LaneSet2_e7f0038783cd41e483c24f58e6fe8f22",
				Position = new Point(0, 5),
				Size = new Size(0, 400),
				UseBackgroundMode = false
			};
			return schemaLaneSet2_e7f0038783cd41e483c24f58e6fe8f22;
		}

		protected virtual ProcessSchemaLane CreateLane1_6b62affead744774bd2843249a5982e0Lane() {
			ProcessSchemaLane schemaLane1_6b62affead744774bd2843249a5982e0 = new ProcessSchemaLane(this) {
				UId = new Guid("6b62affe-ad74-4774-bd28-43249a5982e0"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e7f00387-83cd-41e4-83c2-4f58e6fe8f22"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("0dceaad6-a204-4806-b152-45288d90ce02"),
				CreatedInSchemaUId = new Guid("d3284964-d6ed-4978-b429-52046d51454b"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("d3284964-d6ed-4978-b429-52046d51454b"),
				Name = @"Lane1_6b62affead744774bd2843249a5982e0",
				Position = new Point(0, 0),
				Size = new Size(700, 400),
				UseBackgroundMode = false
			};
			return schemaLane1_6b62affead744774bd2843249a5982e0;
		}

		protected virtual ProcessSchemaEventSubProcess CreateMailServerSavedMessageScriptTaskEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaMailServerSavedMessageScriptTaskEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("5e344bce-7db3-42b7-a8fe-de9d5b6059bb"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("6b62affe-ad74-4774-bd28-43249a5982e0"),
				CreatedInOwnerSchemaUId = new Guid("3aa74e03-9154-4ed7-afad-1236b271f67f"),
				CreatedInPackageId = new Guid("0dceaad6-a204-4806-b152-45288d90ce02"),
				CreatedInSchemaUId = new Guid("d3284964-d6ed-4978-b429-52046d51454b"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("d3284964-d6ed-4978-b429-52046d51454b"),
				Name = @"MailServerSavedMessageScriptTaskEventSubProcess",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(20, 20),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(500, 222),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaMailServerSavedMessageScriptTaskEventSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateMailServerSavedMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("092c1d5c-f04d-41fc-a9ed-767c9f3689e3"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5e344bce-7db3-42b7-a8fe-de9d5b6059bb"),
				CreatedInOwnerSchemaUId = new Guid("3aa74e03-9154-4ed7-afad-1236b271f67f"),
				CreatedInPackageId = new Guid("0dceaad6-a204-4806-b152-45288d90ce02"),
				CreatedInSchemaUId = new Guid("d3284964-d6ed-4978-b429-52046d51454b"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"MailServerSaved",
				ModifiedInSchemaUId = new Guid("d3284964-d6ed-4978-b429-52046d51454b"),
				Name = @"MailServerSavedMessage",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(86, 113),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateMailServerSavedMessageScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("3e5f7719-c36f-45d3-b395-5a4db0c179a0"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5e344bce-7db3-42b7-a8fe-de9d5b6059bb"),
				CreatedInOwnerSchemaUId = new Guid("3aa74e03-9154-4ed7-afad-1236b271f67f"),
				CreatedInPackageId = new Guid("0dceaad6-a204-4806-b152-45288d90ce02"),
				CreatedInSchemaUId = new Guid("d3284964-d6ed-4978-b429-52046d51454b"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("d3284964-d6ed-4978-b429-52046d51454b"),
				Name = @"MailServerSavedMessageScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(300, 99),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,189,144,205,74,195,64,20,133,215,201,83,12,179,154,129,146,23,40,89,148,154,69,4,65,140,213,245,77,114,107,6,38,119,116,126,154,86,233,187,59,73,179,80,12,226,66,186,60,220,239,28,238,57,106,207,68,65,94,249,83,182,209,218,12,69,15,74,223,152,129,180,129,86,209,11,203,115,182,7,237,80,178,143,52,217,189,182,224,145,193,18,57,223,114,70,56,176,139,16,59,135,118,107,136,176,241,202,208,138,241,187,232,169,205,177,58,81,83,161,247,209,230,184,76,147,36,139,74,240,130,160,214,56,50,17,232,172,33,245,14,163,145,175,216,214,232,208,83,118,15,22,122,244,104,197,229,169,201,251,220,161,69,49,101,87,104,15,104,203,150,203,172,116,197,91,0,45,126,56,231,186,101,43,37,3,55,191,186,78,147,95,90,101,197,17,155,16,11,201,200,61,96,111,14,184,208,228,214,212,35,112,78,213,210,168,21,210,31,6,157,169,127,24,115,76,154,34,221,147,130,199,78,185,77,211,152,64,254,218,99,126,107,244,117,200,115,106,209,7,75,204,219,128,235,79,253,147,24,96,137,2,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateRemoveMailboxSyncSettingsJobMethod());
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("fb7b81ba-7c3c-45a5-ae9e-c6c03dceb812"),
				Name = "Terrasoft.UI.WebControls.Controls",
				Alias = "",
				CreatedInPackageId = new Guid("24c6dcbf-ddce-46c1-876f-ee548e2ae17a")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("cde525cf-d220-4d2a-b963-e55254c639fc"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("24c6dcbf-ddce-46c1-876f-ee548e2ae17a")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5c9c82c6-ba6d-4a57-9a14-87fe8faa4ebb"),
				Name = "Terrasoft.Core.DB",
				Alias = "",
				CreatedInPackageId = new Guid("24c6dcbf-ddce-46c1-876f-ee548e2ae17a")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7821de68-c82b-4917-a6cd-add2adfbe400"),
				Name = "Terrasoft.Common",
				Alias = "",
				CreatedInPackageId = new Guid("24c6dcbf-ddce-46c1-876f-ee548e2ae17a")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d67de76f-9cbc-4bfc-babb-6f65cb89b973"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("24c6dcbf-ddce-46c1-876f-ee548e2ae17a")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("74160d3b-65e3-4694-b554-089f2d980e54"),
				Name = "Newtonsoft.Json",
				Alias = "",
				CreatedInPackageId = new Guid("24c6dcbf-ddce-46c1-876f-ee548e2ae17a")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e401300a-9f16-40c2-9788-cf310ae9d1c5"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("24c6dcbf-ddce-46c1-876f-ee548e2ae17a")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("80072450-3d71-495c-9a3b-4b5d23d693ca"),
				Name = "Terrasoft.Messaging.Common",
				Alias = "",
				CreatedInPackageId = new Guid("9dae2167-8d3b-4948-9812-c7a970f9490e")
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
			Usings.Add(new SchemaUsing() {
				UId = new Guid("aca2294b-e209-4c40-9400-0d59d9ecd1ea"),
				Name = "Terrasoft.GlobalSearch.Indexing",
				Alias = "",
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5410f06b-83f8-43fa-bc49-82a2dd508d3c"),
				Name = "System.Linq",
				Alias = "",
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			});
		}

		protected virtual SchemaMethod CreateRemoveMailboxSyncSettingsJobMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("412c5ba3-c9ee-457f-acc8-863c406db9cf"),
				Name = "RemoveMailboxSyncSettingsJob",
				CreatedInSchemaUId = new Guid("d3284964-d6ed-4978-b429-52046d51454b"),
				CreatedInPackageId = new Guid("0dceaad6-a204-4806-b152-45288d90ce02"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,165,83,77,111,219,48,12,61,219,191,130,245,46,50,144,185,221,48,12,24,218,20,72,99,175,240,128,38,69,156,110,199,65,137,217,70,131,44,101,146,156,143,22,254,239,147,37,39,233,218,172,151,157,44,137,228,227,123,143,116,129,28,231,6,40,231,114,157,85,148,241,84,174,5,151,180,100,226,161,240,177,62,8,92,131,191,144,59,141,106,40,133,176,103,38,69,28,6,201,80,242,186,18,36,42,80,148,168,28,198,160,44,21,106,29,197,97,242,85,201,138,68,55,246,113,38,55,197,86,204,11,52,198,98,187,224,143,5,42,244,209,2,213,10,85,94,70,113,146,235,236,119,77,57,241,192,201,45,85,180,66,131,138,100,194,48,179,77,242,50,142,129,234,142,209,121,88,107,139,7,36,189,202,54,56,175,141,84,80,206,246,199,62,252,205,56,201,132,174,21,166,87,135,39,98,225,158,194,160,131,201,83,106,232,4,169,213,2,202,127,250,111,217,147,248,86,232,75,200,161,181,71,13,214,11,198,17,136,135,74,218,172,174,95,16,188,99,247,112,50,202,166,197,116,48,74,7,147,244,227,207,51,56,61,157,142,211,49,12,39,55,239,63,125,254,114,246,161,205,211,70,181,212,244,43,131,45,179,14,247,26,77,225,178,200,225,97,172,44,75,235,227,209,201,196,231,45,178,37,176,115,213,22,76,183,75,44,189,235,223,41,175,241,226,186,102,229,37,137,218,247,118,50,208,239,67,182,153,47,168,120,64,107,159,54,58,217,93,15,35,244,201,157,194,96,23,191,51,140,183,93,38,88,201,21,182,123,240,77,206,94,44,83,239,136,194,158,67,121,5,227,218,89,144,91,37,231,54,107,100,23,196,11,106,0,185,70,248,111,93,121,69,151,255,210,180,162,10,150,187,165,212,221,239,145,50,167,129,170,237,133,31,87,15,228,236,151,21,118,217,85,5,79,112,108,16,199,68,67,211,219,151,12,107,165,80,152,214,41,75,181,247,114,155,159,133,237,127,1,141,171,107,156,21,65,203,127,239,212,66,73,193,30,221,6,190,53,129,131,174,206,79,183,167,150,33,187,15,221,173,9,155,63,48,115,194,126,51,4,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new MailServerEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d3284964-d6ed-4978-b429-52046d51454b"));
		}

		#endregion

	}

	#endregion


	#region Class: MailServerEventsProcess

	/// <exclude/>
	public class MailServerEventsProcess : MailServer_ExchangeEventsProcess
	{

		public MailServerEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

