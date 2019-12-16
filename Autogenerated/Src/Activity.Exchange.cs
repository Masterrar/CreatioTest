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
	using Terrasoft.GlobalSearch.Indexing;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities.Json.Converters;

	#region Class: Activity_Exchange_TerrasoftSchema

	/// <exclude/>
	public class Activity_Exchange_TerrasoftSchema : Terrasoft.Configuration.Activity_NUI_TerrasoftSchema
	{

		#region Constructors: Public

		public Activity_Exchange_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public Activity_Exchange_TerrasoftSchema(Activity_Exchange_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public Activity_Exchange_TerrasoftSchema(Activity_Exchange_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("b1a0978e-fdeb-4695-abd3-1d07665d3124");
			Name = "Activity_Exchange_Terrasoft";
			ParentSchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89");
			ExtendParent = true;
			CreatedInPackageId = new Guid("1d769f70-a0f4-4e48-adff-8ec94813dc0e");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("024c7e3b-9ce7-4ec6-aaf5-bdedd07ac300")) == null) {
				Columns.Add(CreateUserEmailAddressColumn());
			}
			if (Columns.FindByUId(new Guid("be1d624b-b774-40ab-85cc-9364dacd6199")) == null) {
				Columns.Add(CreateLocationColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateUserEmailAddressColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("024c7e3b-9ce7-4ec6-aaf5-bdedd07ac300"),
				Name = @"UserEmailAddress",
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("b1a0978e-fdeb-4695-abd3-1d07665d3124"),
				ModifiedInSchemaUId = new Guid("b1a0978e-fdeb-4695-abd3-1d07665d3124"),
				CreatedInPackageId = new Guid("1d769f70-a0f4-4e48-adff-8ec94813dc0e")
			};
		}

		protected virtual EntitySchemaColumn CreateLocationColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("LongText")) {
				UId = new Guid("be1d624b-b774-40ab-85cc-9364dacd6199"),
				Name = @"Location",
				CreatedInSchemaUId = new Guid("b1a0978e-fdeb-4695-abd3-1d07665d3124"),
				ModifiedInSchemaUId = new Guid("b1a0978e-fdeb-4695-abd3-1d07665d3124"),
				CreatedInPackageId = new Guid("e8870aad-3989-43c9-a61d-2b65ea5ccd7e")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateActivity_Exchange_TerrasoftEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateActivity_Exchange_TerrasoftEventsProcessSchema() {
			var schema = new Activity_Exchange_TerrasoftEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new Activity_Exchange_Terrasoft(userConnection){Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new Activity_ExchangeEventsProcess(userConnnection);
		}

		public override object Clone() {
			return new Activity_Exchange_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new Activity_Exchange_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b1a0978e-fdeb-4695-abd3-1d07665d3124"));
		}

		#endregion

	}

	#endregion

	#region Class: Activity_Exchange_Terrasoft

	/// <summary>
	/// Activity.
	/// </summary>
	public class Activity_Exchange_Terrasoft : Terrasoft.Configuration.Activity_NUI_Terrasoft
	{

		#region Constructors: Public

		public Activity_Exchange_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Activity_Exchange_Terrasoft";
		}

		public Activity_Exchange_Terrasoft(Activity_Exchange_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// User email.
		/// </summary>
		public string UserEmailAddress {
			get {
				return GetTypedColumnValue<string>("UserEmailAddress");
			}
			set {
				SetColumnValue("UserEmailAddress", value);
			}
		}

		/// <summary>
		/// Location.
		/// </summary>
		public string Location {
			get {
				return GetTypedColumnValue<string>("Location");
			}
			set {
				SetColumnValue("Location", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new Activity_ExchangeEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("Activity_Exchange_TerrasoftDeleted", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new Activity_Exchange_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: Activity_ExchangeEventsProcess

	/// <exclude/>
	public class Activity_ExchangeEventsProcess<TEntity> : Terrasoft.Configuration.Activity_NUIEventsProcess<TEntity> where TEntity : Activity_Exchange_Terrasoft
	{

		public Activity_ExchangeEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Activity_ExchangeEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("b1a0978e-fdeb-4695-abd3-1d07665d3124");
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

		public override bool DoCollectEmailParticipants() {
			return Entity.GetTypedColumnValue<Guid>("TypeId") == Terrasoft.Configuration.ActivityConsts.EmailTypeUId
			|| Entity.GetTypedColumnValue<Guid>("ActivityCategoryId") == ExchangeConsts.ActivityMeetingCategoryId;
		}

		public override void PrepereSynchronizeSubjectRemindingUserTask(SynchronizeSubjectRemindingUserTask userTask, Guid contact, DateTime remindTime, bool active, Guid source) {
			base.PrepereSynchronizeSubjectRemindingUserTask(userTask, contact, remindTime, active, source);
			bool isFeatureEnabled = FeatureUtilities.GetIsFeatureEnabled(UserConnection, "NotificationV2");
			if (isFeatureEnabled && active) {
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

		public virtual void SynchronizeParticipants() {
			if (string.IsNullOrEmpty(Entity.Sender) && string.IsNullOrEmpty(Entity.Recepient)) {
				return;
			}
			if (Entity.GetTypedColumnValue<Guid>("ActivityCategoryId") == ExchangeConsts.ActivityMeetingCategoryId) {
				var recepientsEmails = (List<string>)RecepientsEmails;
				Dictionary<Guid, string> contactDictionary = ContactUtilities.GetContactsByEmails(UserConnection, recepientsEmails);
				if (contactDictionary.Count > 0) {
					var participantRoles = ActivityUtils.GetParticipantsRoles(UserConnection);
					foreach (var contactId in contactDictionary.Keys) {
						AddActivityParticipantToInsertedValues(
							contactId,
							new Dictionary<string, object> {
								{"RoleId", participantRoles["Participant"]}
							},
							false
						);
					}
					var insertedValues = InsertedValues as Dictionary<Guid, object>;
					if (insertedValues != null) {
						UpdateContactAndAccountByParticipant(insertedValues.Keys.ToList());
					}
				}
				Entity.SetColumnValue("Sender", string.Empty);
				Entity.SetColumnValue("Recepient", string.Empty);
			}
		}

		public virtual void UpdateContactAndAccountByParticipant(List<Guid> participants) {
			if (!Entity.GetIsColumnValueLoaded("ContactId") || !Entity.GetIsColumnValueLoaded("AccountId") 
					|| !Entity.GetIsColumnValueLoaded("OwnerId")) {
				return;
			}
			var contactId = Entity.GetTypedColumnValue<Guid>("ContactId");
			var accountId = Entity.GetTypedColumnValue<Guid>("AccountId");
			if ((contactId != Guid.Empty) || (accountId != Guid.Empty)) {
				return;
			}
			if (!IsNew) {
				var existingParticipantIds = new List<Guid>();
				var selectExistedParticipants =
					new Select(UserConnection).Column("ParticipantId")
						.From("ActivityParticipant")
						.Where("ActivityId")
						.IsEqual(Column.Parameter(Entity.Id));
				using (DBExecutor dbExecutor = UserConnection.EnsureDBConnection()) {
					using (
						var reader = dbExecutor.ExecuteReader(selectExistedParticipants.GetSqlText(),
							selectExistedParticipants.Parameters)) {
						while (reader.Read()) {
							existingParticipantIds.Add(reader.GetColumnValue<Guid>("ParticipantId"));
						}
					}
				}
				participants = participants.Union(existingParticipantIds).ToList();
			}
			int participantsCount = participants.Count();
			if ((participantsCount > 2) || (participantsCount == 0)) {
				return;
			}
			var ownerId = Entity.GetTypedColumnValue<Guid>("OwnerId");
			if ((participantsCount == 2) && !participants.Contains(ownerId)) {
				return;
			}
			contactId = participants.FirstOrDefault(participantId => participantId != ownerId);
			if (contactId == Guid.Empty) {
				return;
			}
			var update =
				new Update(UserConnection, "Activity").Set("ContactId", Column.Const(contactId))
					.Set("AccountId", 
						new Select(UserConnection).Column("AccountId")
							.From("Contact")
							.Where("Id").IsEqual(Column.Const(contactId)) as Select)
					.Where("Id").IsEqual(Column.Const(Entity.Id)) as Update;
			update.Execute();
		}

		public override bool OnActivitySaved(ProcessExecutingContext context) {
			SynchronizeParticipants();
			return base.OnActivitySaved(context);
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

	#region Class: Activity_ExchangeEventsProcess

	/// <exclude/>
	public class Activity_ExchangeEventsProcess : Activity_ExchangeEventsProcess<Activity_Exchange_Terrasoft>
	{

		public Activity_ExchangeEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: Activity_Exchange_TerrasoftEventsProcessSchema

	/// <exclude/>
	public class Activity_Exchange_TerrasoftEventsProcessSchema : Terrasoft.Configuration.Activity_NUI_TerrasoftEventsProcessSchema
	{

		#region Constructors: Public

		public Activity_Exchange_TerrasoftEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public Activity_Exchange_TerrasoftEventsProcessSchema(Activity_Exchange_TerrasoftEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "Activity_ExchangeEventsProcess";
			UId = new Guid("a13b3da4-0ea1-4343-b06e-ab127d2c641f");
			CreatedInPackageId = new Guid("1d769f70-a0f4-4e48-adff-8ec94813dc0e");
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
			ProcessSchemaLaneSet schemaLaneSet2_94dd151532f94afaaf3a5d029376fcd1 = CreateLaneSet2_94dd151532f94afaaf3a5d029376fcd1LaneSet();
			LaneSets.Add(schemaLaneSet2_94dd151532f94afaaf3a5d029376fcd1);
			ProcessSchemaLane schemaLane4_734ce6f44a3f4189993bcf25dda3cf56 = CreateLane4_734ce6f44a3f4189993bcf25dda3cf56Lane();
			schemaLaneSet2_94dd151532f94afaaf3a5d029376fcd1.Lanes.Add(schemaLane4_734ce6f44a3f4189993bcf25dda3cf56);
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet2_94dd151532f94afaaf3a5d029376fcd1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet2_94dd151532f94afaaf3a5d029376fcd1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("94dd1515-32f9-4afa-af3a-5d029376fcd1"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("ae0dbe8a-2abd-4db4-953a-1433786a2a68"),
				CreatedInPackageId = new Guid("2137d3bc-8953-4060-9df8-39c52dc22e74"),
				CreatedInSchemaUId = new Guid("a13b3da4-0ea1-4343-b06e-ab127d2c641f"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("a13b3da4-0ea1-4343-b06e-ab127d2c641f"),
				Name = @"LaneSet2_94dd151532f94afaaf3a5d029376fcd1",
				Position = new Point(0, 0),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaLaneSet2_94dd151532f94afaaf3a5d029376fcd1;
		}

		protected virtual ProcessSchemaLane CreateLane4_734ce6f44a3f4189993bcf25dda3cf56Lane() {
			ProcessSchemaLane schemaLane4_734ce6f44a3f4189993bcf25dda3cf56 = new ProcessSchemaLane(this) {
				UId = new Guid("734ce6f4-4a3f-4189-993b-cf25dda3cf56"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("94dd1515-32f9-4afa-af3a-5d029376fcd1"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("2137d3bc-8953-4060-9df8-39c52dc22e74"),
				CreatedInSchemaUId = new Guid("a13b3da4-0ea1-4343-b06e-ab127d2c641f"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("a13b3da4-0ea1-4343-b06e-ab127d2c641f"),
				Name = @"Lane4_734ce6f44a3f4189993bcf25dda3cf56",
				Position = new Point(0, 0),
				Size = new Size(700, 400),
				UseBackgroundMode = false
			};
			return schemaLane4_734ce6f44a3f4189993bcf25dda3cf56;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateSynchronizeParticipantsMethod());
			Methods.Add(CreateUpdateContactAndAccountByParticipantMethod());
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("f83cbea2-10c5-4739-96f1-116937efce77"),
				Name = "Terrasoft.Core.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("1d769f70-a0f4-4e48-adff-8ec94813dc0e")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("19024591-23ea-4b03-9800-93149198129b"),
				Name = "Terrasoft.Core.DB",
				Alias = "",
				CreatedInPackageId = new Guid("1d769f70-a0f4-4e48-adff-8ec94813dc0e")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("fb7b81ba-7c3c-45a5-ae9e-c6c03dceb812"),
				Name = "Terrasoft.UI.WebControls.Controls",
				Alias = "",
				CreatedInPackageId = new Guid("1d769f70-a0f4-4e48-adff-8ec94813dc0e")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("cde525cf-d220-4d2a-b963-e55254c639fc"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("1d769f70-a0f4-4e48-adff-8ec94813dc0e")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7821de68-c82b-4917-a6cd-add2adfbe400"),
				Name = "Terrasoft.Common",
				Alias = "",
				CreatedInPackageId = new Guid("1d769f70-a0f4-4e48-adff-8ec94813dc0e")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d67de76f-9cbc-4bfc-babb-6f65cb89b973"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("1d769f70-a0f4-4e48-adff-8ec94813dc0e")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("74160d3b-65e3-4694-b554-089f2d980e54"),
				Name = "Newtonsoft.Json",
				Alias = "",
				CreatedInPackageId = new Guid("1d769f70-a0f4-4e48-adff-8ec94813dc0e")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e401300a-9f16-40c2-9788-cf310ae9d1c5"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("1d769f70-a0f4-4e48-adff-8ec94813dc0e")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("ca241c6a-6bd2-4e33-ae26-164063bfb504"),
				Name = "System.Text",
				Alias = "",
				CreatedInPackageId = new Guid("1d769f70-a0f4-4e48-adff-8ec94813dc0e")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("ed374225-e41d-4643-8234-a4c89997d648"),
				Name = "System.Linq",
				Alias = "",
				CreatedInPackageId = new Guid("1d769f70-a0f4-4e48-adff-8ec94813dc0e")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("49a41b26-e223-4e0d-a40a-f81877cefa7a"),
				Name = "Terrasoft.Core.Store",
				Alias = "",
				CreatedInPackageId = new Guid("1d769f70-a0f4-4e48-adff-8ec94813dc0e")
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

		protected override SchemaMethod CreateDoCollectEmailParticipantsMethod() {
			SchemaMethod method = base.CreateDoCollectEmailParticipantsMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,141,65,10,194,48,16,69,247,158,162,116,165,155,92,64,43,72,9,165,11,119,213,125,104,166,113,32,157,148,201,68,12,244,240,182,96,117,235,246,241,254,251,12,146,152,10,77,130,146,85,3,210,229,9,108,29,124,26,233,110,124,130,83,147,208,158,247,229,202,91,91,30,138,170,42,58,96,54,49,12,162,234,64,3,186,196,70,48,144,186,244,130,207,165,179,208,40,81,233,209,160,95,119,183,214,238,230,249,143,147,111,192,8,184,192,121,59,212,175,254,97,200,193,39,188,105,87,0,65,114,63,251,248,6,84,176,58,212,207,0,0,0 };
			return method;
		}

		protected override SchemaMethod CreatePrepereSynchronizeSubjectRemindingUserTaskMethod() {
			SchemaMethod method = base.CreatePrepereSynchronizeSubjectRemindingUserTaskMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,146,95,79,194,48,20,197,159,183,79,209,236,129,148,164,225,193,87,129,4,7,24,18,67,136,12,223,203,118,193,202,214,187,244,143,58,9,223,221,118,27,50,212,196,248,180,238,246,158,211,223,185,237,150,107,24,172,20,148,160,96,93,201,244,89,161,20,31,176,182,219,23,72,205,35,20,66,102,66,238,55,26,84,194,245,129,218,118,193,72,138,210,240,212,48,162,234,166,68,20,192,136,43,136,87,247,213,104,85,10,253,219,112,139,152,19,161,231,192,141,85,48,147,124,155,67,70,70,164,45,108,140,200,133,17,160,7,247,96,22,223,218,168,63,53,70,41,29,137,64,201,72,180,68,35,118,34,229,254,247,233,38,114,254,98,71,232,15,251,94,175,5,233,147,99,24,44,190,82,36,240,110,230,168,10,80,196,92,150,35,18,231,92,235,185,147,160,170,60,200,112,226,213,194,84,191,40,199,52,12,2,9,111,196,129,105,163,172,23,77,212,222,22,32,13,141,236,21,113,196,200,117,132,190,35,14,156,202,57,58,194,20,173,52,75,94,128,67,112,167,62,32,30,108,57,21,186,204,121,21,99,110,11,249,196,115,11,116,38,141,99,113,241,39,141,36,234,184,180,183,240,31,151,184,145,116,93,220,78,238,245,77,143,31,65,82,149,144,117,228,195,166,115,76,163,196,247,214,226,243,91,24,180,175,37,230,165,15,233,124,46,211,245,94,119,152,85,212,143,108,42,234,41,112,85,181,118,140,96,173,28,251,123,10,142,231,128,62,77,196,186,19,58,177,122,63,190,164,141,88,55,123,187,223,176,177,38,207,41,12,78,87,152,43,44,109,153,180,81,175,17,235,234,31,140,212,223,222,233,19,120,187,20,90,49,3,0,0 };
			return method;
		}

		protected override SchemaMethod CreateOnActivitySavedMethod() {
			SchemaMethod method = base.CreateOnActivitySavedMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,174,204,75,206,40,202,207,203,172,74,13,72,44,42,201,76,206,44,72,204,43,41,214,208,180,230,229,42,74,45,41,45,202,83,72,74,44,78,213,243,207,115,76,46,201,44,203,44,169,12,78,44,75,77,209,72,206,207,43,73,173,40,209,180,6,0,38,93,6,70,65,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSynchronizeParticipantsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("a2672e5c-0d7d-49ba-8abd-d6933b727d8e"),
				Name = "SynchronizeParticipants",
				CreatedInSchemaUId = new Guid("a13b3da4-0ea1-4343-b06e-ab127d2c641f"),
				CreatedInPackageId = new Guid("eb86d77c-260d-4657-9505-b662a871d245"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,83,77,143,155,48,16,61,147,95,49,229,176,50,18,66,189,239,6,41,203,70,171,168,159,74,147,94,170,30,188,120,146,117,69,108,100,15,219,162,21,255,189,182,129,132,13,106,37,14,96,222,188,247,230,205,88,30,128,89,50,82,29,179,141,253,220,84,213,23,179,62,213,212,178,181,34,73,109,246,13,149,64,147,192,205,13,252,15,182,197,18,107,137,138,146,4,94,23,145,65,106,140,186,93,116,11,233,248,7,204,35,210,174,173,81,20,186,106,78,234,59,175,26,188,123,108,164,200,89,188,42,73,190,56,76,193,9,143,218,180,27,17,39,176,92,194,250,79,249,204,213,17,11,173,44,217,108,132,125,66,36,103,229,130,14,162,47,220,128,25,125,216,245,137,203,202,194,18,216,71,105,233,174,55,159,39,219,43,192,237,34,122,144,142,86,43,110,218,96,39,29,26,205,161,212,138,120,73,151,255,142,173,232,207,246,36,43,73,18,173,239,106,56,179,247,109,207,201,246,22,141,59,84,24,10,211,153,171,196,169,250,96,102,2,89,161,27,69,144,195,251,208,81,104,169,230,134,100,41,107,174,104,171,43,244,45,141,57,120,23,193,193,215,11,198,6,208,149,5,47,24,29,180,65,94,62,3,243,172,131,244,70,128,84,243,70,179,15,216,218,222,66,180,18,98,212,155,200,236,244,70,57,9,66,17,6,105,153,135,70,103,214,52,124,42,252,13,147,116,251,92,83,208,79,191,156,173,188,167,143,162,215,216,91,118,35,79,103,189,254,136,39,146,241,207,46,20,116,61,249,129,87,22,253,91,104,174,27,210,146,111,92,185,172,222,218,4,110,97,54,239,193,143,167,241,83,185,162,120,183,4,229,22,126,72,99,95,11,183,117,195,196,87,202,69,83,250,145,221,79,179,185,98,8,97,102,59,237,247,144,37,163,91,247,156,175,24,77,174,4,139,251,43,23,143,123,152,133,139,230,203,254,129,63,175,244,188,164,251,11,0,120,39,74,223,3,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateUpdateContactAndAccountByParticipantMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("1ed6829c-33dd-45e9-b081-4fa0b8c19b86"),
				Name = "UpdateContactAndAccountByParticipant",
				CreatedInSchemaUId = new Guid("a13b3da4-0ea1-4343-b06e-ab127d2c641f"),
				CreatedInPackageId = new Guid("eb86d77c-260d-4657-9505-b662a871d245"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("64dccf6a-ae74-48a5-ae17-3d8ff83b9e5c"),
				Name = "participants",
				CreatedInSchemaUId = new Guid("a13b3da4-0ea1-4343-b06e-ab127d2c641f"),
				ModifiedInSchemaUId = new Guid("a13b3da4-0ea1-4343-b06e-ab127d2c641f"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "List<Guid>",
				CreatedInPackageId = new Guid("eb86d77c-260d-4657-9505-b662a871d245")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,84,77,111,226,48,16,61,7,137,255,96,56,84,142,132,172,213,94,187,32,181,144,86,72,213,118,181,133,221,179,55,158,110,45,5,135,218,78,1,109,251,223,215,99,231,19,130,202,33,81,98,207,155,121,126,158,55,242,153,208,81,162,172,180,7,118,15,118,105,230,121,86,108,212,47,158,21,240,144,115,1,130,142,231,185,178,60,181,75,49,142,201,251,59,249,44,252,38,77,243,66,133,240,225,32,138,46,128,60,238,20,104,4,196,228,159,131,104,176,133,86,215,195,193,199,112,240,198,53,73,43,2,100,74,154,76,171,195,22,68,43,217,183,251,66,138,89,135,238,117,192,243,138,209,69,248,22,127,135,151,78,32,218,16,24,77,9,134,177,100,179,181,7,47,7,109,178,119,55,79,207,130,185,70,75,243,29,118,97,15,185,193,94,26,43,213,223,31,92,91,153,202,45,199,76,198,17,85,176,35,15,110,175,164,133,92,60,192,64,6,169,77,16,6,162,133,114,24,84,27,97,79,62,132,174,13,104,39,134,114,223,50,87,49,11,103,165,227,78,169,113,140,168,136,221,233,124,131,103,183,242,205,233,211,10,169,2,126,191,128,134,38,162,65,46,77,242,90,240,140,134,244,204,65,249,6,44,104,90,74,189,20,177,39,95,24,119,76,66,23,183,201,30,210,194,230,154,136,63,245,231,148,116,217,178,68,153,66,195,226,182,89,162,165,162,85,34,95,29,21,209,224,186,8,83,52,249,88,248,128,159,126,139,158,213,12,251,224,233,53,91,193,222,210,120,226,51,70,231,131,235,163,153,138,74,180,123,145,25,16,26,40,48,44,87,211,140,162,254,187,101,55,66,84,0,87,190,167,3,143,46,200,171,23,69,31,248,198,23,62,219,206,197,147,246,47,91,43,84,171,191,120,204,86,57,118,149,239,39,108,73,101,59,224,57,182,242,113,66,191,72,107,55,156,198,207,200,215,224,133,158,84,83,242,229,140,173,243,224,250,139,76,89,79,136,243,36,92,37,199,226,234,138,140,142,200,59,239,74,101,104,89,174,135,76,123,190,116,176,119,82,27,251,168,23,240,204,139,204,182,107,98,236,140,116,23,156,253,171,26,37,203,86,226,238,220,232,147,163,216,10,110,193,187,24,77,188,246,191,71,38,158,144,218,128,227,152,61,129,109,143,187,9,41,45,232,150,220,13,215,197,99,111,212,16,221,12,183,137,31,206,151,204,139,214,64,12,125,93,14,139,178,114,189,90,78,8,140,59,30,10,39,140,8,55,101,217,64,238,83,108,107,152,32,54,168,227,196,11,170,85,126,247,77,250,31,103,117,115,180,212,6,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new Activity_Exchange_TerrasoftEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a13b3da4-0ea1-4343-b06e-ab127d2c641f"));
		}

		#endregion

	}

	#endregion

}

