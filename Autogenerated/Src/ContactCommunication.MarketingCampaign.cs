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
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.DcmProcess;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Factories;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;
	using Terrasoft.GlobalSearch.Indexing;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities.Json.Converters;

	#region Class: ContactCommunicationSchema

	/// <exclude/>
	public class ContactCommunicationSchema : Terrasoft.Configuration.ContactCommunication_SSP_TerrasoftSchema
	{

		#region Constructors: Public

		public ContactCommunicationSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public ContactCommunicationSchema(ContactCommunicationSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public ContactCommunicationSchema(ContactCommunicationSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("e8a3ae69-cdec-485b-b17c-0a9a38443d46");
			Name = "ContactCommunication";
			ParentSchemaUId = new Guid("004a9121-21f8-4a1e-8918-45c0f756ea41");
			ExtendParent = true;
			CreatedInPackageId = new Guid("06c5e2cb-107e-4211-a5bd-01241dc3944b");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("ad63b6ff-8842-4d58-ba4a-8e4ff366964b")) == null) {
				Columns.Add(CreateNonActualColumn());
			}
			if (Columns.FindByUId(new Guid("88fe3140-5c42-4b10-898a-95b988e40720")) == null) {
				Columns.Add(CreateNonActualReasonColumn());
			}
			if (Columns.FindByUId(new Guid("dfed1095-db33-4c53-9a03-6fa884b9cc3f")) == null) {
				Columns.Add(CreateDateSetNonActualColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateNonActualColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("ad63b6ff-8842-4d58-ba4a-8e4ff366964b"),
				Name = @"NonActual",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("e8a3ae69-cdec-485b-b17c-0a9a38443d46"),
				ModifiedInSchemaUId = new Guid("e8a3ae69-cdec-485b-b17c-0a9a38443d46"),
				CreatedInPackageId = new Guid("06c5e2cb-107e-4211-a5bd-01241dc3944b")
			};
		}

		protected virtual EntitySchemaColumn CreateNonActualReasonColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("88fe3140-5c42-4b10-898a-95b988e40720"),
				Name = @"NonActualReason",
				ReferenceSchemaUId = new Guid("88029a14-efa8-4fa9-9c87-e5131319caef"),
				IsValueCloneable = false,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("e8a3ae69-cdec-485b-b17c-0a9a38443d46"),
				ModifiedInSchemaUId = new Guid("e8a3ae69-cdec-485b-b17c-0a9a38443d46"),
				CreatedInPackageId = new Guid("23e6b872-7cf2-4336-8046-3b06c9b28cbc")
			};
		}

		protected virtual EntitySchemaColumn CreateDateSetNonActualColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Date")) {
				UId = new Guid("dfed1095-db33-4c53-9a03-6fa884b9cc3f"),
				Name = @"DateSetNonActual",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("e8a3ae69-cdec-485b-b17c-0a9a38443d46"),
				ModifiedInSchemaUId = new Guid("e8a3ae69-cdec-485b-b17c-0a9a38443d46"),
				CreatedInPackageId = new Guid("23e6b872-7cf2-4336-8046-3b06c9b28cbc")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateContactCommunicationEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateContactCommunicationEventsProcessSchema() {
			var schema = new ContactCommunicationEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new ContactCommunication(userConnection){Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new ContactCommunication_MarketingCampaignEventsProcess(userConnnection);
		}

		public override object Clone() {
			return new ContactCommunicationSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new ContactCommunicationSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e8a3ae69-cdec-485b-b17c-0a9a38443d46"));
		}

		#endregion

	}

	#endregion

	#region Class: ContactCommunication

	/// <summary>
	/// Contact communication option.
	/// </summary>
	public class ContactCommunication : Terrasoft.Configuration.ContactCommunication_SSP_Terrasoft
	{

		#region Constructors: Public

		public ContactCommunication(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "ContactCommunication";
		}

		public ContactCommunication(ContactCommunication source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Invalid.
		/// </summary>
		public bool NonActual {
			get {
				return GetTypedColumnValue<bool>("NonActual");
			}
			set {
				SetColumnValue("NonActual", value);
			}
		}

		/// <exclude/>
		public Guid NonActualReasonId {
			get {
				return GetTypedColumnValue<Guid>("NonActualReasonId");
			}
			set {
				SetColumnValue("NonActualReasonId", value);
				_nonActualReason = null;
			}
		}

		/// <exclude/>
		public string NonActualReasonName {
			get {
				return GetTypedColumnValue<string>("NonActualReasonName");
			}
			set {
				SetColumnValue("NonActualReasonName", value);
				if (_nonActualReason != null) {
					_nonActualReason.Name = value;
				}
			}
		}

		private NonActualReason _nonActualReason;
		/// <summary>
		/// Reason for irrelevance.
		/// </summary>
		public NonActualReason NonActualReason {
			get {
				return _nonActualReason ??
					(_nonActualReason = LookupColumnEntities.GetEntity("NonActualReason") as NonActualReason);
			}
		}

		/// <summary>
		/// Invalid since.
		/// </summary>
		public DateTime DateSetNonActual {
			get {
				return GetTypedColumnValue<DateTime>("DateSetNonActual");
			}
			set {
				SetColumnValue("DateSetNonActual", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new ContactCommunication_MarketingCampaignEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Inserting += (s, e) => ThrowEvent("ContactCommunicationInserting", e);
			Updating += (s, e) => ThrowEvent("ContactCommunicationUpdating", e);
			Validating += (s, e) => ThrowEvent("ContactCommunicationValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new ContactCommunication(this);
		}

		#endregion

	}

	#endregion

	#region Class: ContactCommunication_MarketingCampaignEventsProcess

	/// <exclude/>
	public class ContactCommunication_MarketingCampaignEventsProcess<TEntity> : Terrasoft.Configuration.ContactCommunication_SSPEventsProcess<TEntity> where TEntity : ContactCommunication
	{

		public ContactCommunication_MarketingCampaignEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ContactCommunication_MarketingCampaignEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("e8a3ae69-cdec-485b-b17c-0a9a38443d46");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		public virtual Guid OldCommunicationTypeId {
			get;
			set;
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

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			switch (reader.CurrentName) {
				case "OldCommunicationTypeId":
					OldCommunicationTypeId = reader.GetValue<System.Guid>();
				break;
			}
		}

		#endregion

		#region Methods: Public

		public override void SetNewContactCommunication() {
			var contactId = Entity.GetTypedColumnValue<Guid>("ContactId");
			var contactESQ = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "Contact");
			contactESQ.AddAllSchemaColumns();
			var contact = contactESQ.GetEntity(UserConnection, contactId);
			if (contact != null) {
				var communicationTypeId = Entity.GetTypedColumnValue<Guid>("CommunicationTypeId").ToString();
				var number = Entity.GetTypedColumnValue<string>("Number");
				var socialColumnValue = Entity.GetTypedColumnValue<string>("SocialMediaId");
				var isPrimary = Entity.GetTypedColumnValue<bool>("IsCreatedBySynchronization");
				var typeColumnName = string.Empty;
				var socialColumnName = string.Empty;
				switch (communicationTypeId) {
					case CommunicationTypeConsts.LinkedInId:
				 		typeColumnName = "LinkedIn";
						socialColumnName = "LinkedInId";
						break;
					case CommunicationTypeConsts.TwitterId:
						typeColumnName = "Twitter";
						socialColumnName = "TwitterId";
						break;
					case CommunicationTypeConsts.FacebookId:
						typeColumnName = "Facebook";
						socialColumnName = "FacebookId";
						break;
					case CommunicationTypeConsts.EmailId:
						typeColumnName = "Email";
						break;
					case CommunicationTypeConsts.SkypeId:
				 		typeColumnName = "Skype";
						break;
					case CommunicationTypeConsts.HomePhoneId:
						typeColumnName = "HomePhone";
						break;
					case CommunicationTypeConsts.MobilePhoneId:
						typeColumnName = "MobilePhone";
						break;
					case CommunicationTypeConsts.WorkPhoneId:
						typeColumnName = "Phone";
						break;
					case CommunicationTypeConsts.WebId:
						typeColumnName = "Web";
						break;
				}
				if (!typeColumnName.Equals(string.Empty)) {
					bool isCanEdit = GetCanEditColumn("Contact", typeColumnName);
					if (!isCanEdit) {
						return;
					}
					bool isCurrentTypeEmail = communicationTypeId.Equals(CommunicationTypeConsts.EmailId);
					bool isOldTypeEmail = OldCommunicationTypeId.ToString().Equals(CommunicationTypeConsts.EmailId);
					bool isCurrentTypeWeb = communicationTypeId.Equals(CommunicationTypeConsts.WebId);
					bool isNotEmailOrWeb = !isCurrentTypeEmail && !isCurrentTypeWeb;
					if (!(isCurrentTypeEmail || isOldTypeEmail) && !isNotEmailOrWeb) {
						return;
					}
					string currentContactCommunicationValue = contact.GetTypedColumnValue<string>(typeColumnName);
					var update = new Update(UserConnection, "Contact") as Update;
					if (isCurrentTypeEmail || isOldTypeEmail) {
							KeyValuePair<string, bool> kvp = GetActualContactEmail(contactId);
							if(!currentContactCommunicationValue.Equals(kvp.Key)) {
								update.Set("Email", Column.Parameter(kvp.Key));
							}
							update.Set("IsNonActualEmail", Column.Parameter(kvp.Value));
					}
					if (isNotEmailOrWeb) {
						if (!currentContactCommunicationValue.Equals(number) && isPrimary) {
							update.Set(typeColumnName, Column.Parameter(number));
							if (!socialColumnName.Equals(string.Empty)) {
								update.Set(socialColumnName, Column.Parameter(socialColumnValue));
							}
						} else if (!isOldTypeEmail) {
							return;
						}
					}
					update.Set("ModifiedOn", Column.Parameter(DateTime.UtcNow));
					update.Where("Id").IsEqual(Column.Parameter(contactId));
					update.Execute();
				}
			}
		}

		public override void ClearOldContactCommunication() {
			if (Entity.GetIsColumnValueLoaded("NonActual")) {
				bool nonActual = Entity.GetTypedColumnValue<bool>("NonActual");
				if (!nonActual) {
					Entity.SetColumnValue("NonActualReasonId", null);
					Entity.SetColumnValue("DateSetNonActual", null);
				} else {
					bool typeChanged = Entity.GetChangedColumnValues().Any(column => column.Name == "CommunicationTypeId");
					if (typeChanged) {
						Entity.SetColumnValue("NonActualReasonId", MarketingConsts.ManuallyNonActualReasonId);
					}
				}
			}
			OldCommunicationTypeId = Entity.GetTypedOldColumnValue<Guid>("CommunicationTypeId");
			base.ClearOldContactCommunication();
		}

		public override void OnContactCommunicationDeleted() {
			var contactESQ = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "Contact");
			EntitySchemaQueryColumn communicationColumn = null;
			EntitySchemaQueryColumn communicationIdColumn = null;
			var contactId = Entity.GetTypedColumnValue<Guid>("ContactId");
			var number = Entity.GetTypedColumnValue<string>("Number");
			var communicationTypeId = Entity.GetTypedColumnValue<Guid>("CommunicationTypeId").ToString();
			var isPrimary = Entity.GetTypedColumnValue<bool>("IsCreatedBySynchronization");
			switch (communicationTypeId) {
				case CommunicationTypeConsts.LinkedInId:
					communicationColumn = contactESQ.AddColumn("LinkedIn");
					communicationIdColumn = contactESQ.AddColumn("LinkedInId");
					break;
				case CommunicationTypeConsts.TwitterId:
					communicationColumn = contactESQ.AddColumn("Twitter");
					communicationIdColumn = contactESQ.AddColumn("TwitterId");
					break;
				case CommunicationTypeConsts.FacebookId:
					communicationColumn = contactESQ.AddColumn("Facebook");
					communicationIdColumn = contactESQ.AddColumn("FacebookId");
					break;
				case CommunicationTypeConsts.EmailId:
					communicationColumn = contactESQ.AddColumn("Email");
					break;
				case CommunicationTypeConsts.SkypeId:
					communicationColumn = contactESQ.AddColumn("Skype");
					break;
				case CommunicationTypeConsts.HomePhoneId:
					communicationColumn = contactESQ.AddColumn("HomePhone");
					break;
				case CommunicationTypeConsts.MobilePhoneId:
					communicationColumn = contactESQ.AddColumn("MobilePhone");
					break;
				case CommunicationTypeConsts.WorkPhoneId:
					communicationColumn = contactESQ.AddColumn("Phone");
					break;
				default:
					return;
			}
			contactESQ.AddAllSchemaColumns();
			var contactEntity = contactESQ.GetEntity(UserConnection, contactId);
			if (contactEntity != null) {
				var value = contactEntity.GetTypedColumnValue<string>(communicationColumn.Name);
				if (value.Equals(number)) {
					string contactCommunicationValue = string.Empty;
					if (communicationTypeId.Equals(CommunicationTypeConsts.EmailId)) {
						KeyValuePair<string, bool> kvp = GetActualContactEmail(contactId);
						contactCommunicationValue = kvp.Key;
						contactEntity.SetColumnValue("IsNonActualEmail", kvp.Value);
					}
					if (isPrimary) {
						contactEntity.SetColumnValue(communicationColumn.Name, contactCommunicationValue);
						if (communicationIdColumn != null) {
							contactEntity.SetColumnValue(communicationIdColumn.Name, string.Empty);
						}
					}
					contactEntity.Save();
				}
			}
		}

		public virtual KeyValuePair<string, bool> GetActualContactEmail(Guid contactId) {
			KeyValuePair<string, bool> result = new KeyValuePair<string, bool>(string.Empty, false);
			var esq = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "ContactCommunication");
			esq.RowCount = 1;
			EntitySchemaQueryColumn nonActualColumn = esq.AddColumn("NonActual").OrderByAsc(1);
			EntitySchemaQueryColumn orderByDescColumn = esq.AddColumn("CreatedOn").OrderByDesc(2);
			EntitySchemaQueryColumn numberColumn = esq.AddColumn("Number");
			esq.Filters.Add(esq.CreateFilterWithParameters(FilterComparisonType.Equal, "Contact", contactId));
			esq.Filters.Add(esq.CreateFilterWithParameters(FilterComparisonType.Equal, "CommunicationType", 
				CommunicationTypeConsts.EmailId));
			EntityCollection entityCollection = esq.GetEntityCollection(UserConnection);
			foreach (Entity entity in entityCollection) {
				return new KeyValuePair<string, bool>(entity.GetTypedColumnValue<string>(numberColumn.Name), 
					 entity.GetTypedColumnValue<bool>(nonActualColumn.Name));
			}
			return result;
		}

		public override void OnContactCommunicationSaving() {
			base.OnContactCommunicationSaving();
			if (Entity.GetTypedColumnValue<bool>("NonActual")) {
			                Entity.SetColumnValue("IsCreatedBySynchronization", false);
			}
		}

		public override void SetCommunicationParentEntityColumns(Entity parentEntity) {
			var communicationTypeId = Entity.GetTypedColumnValue<Guid>("CommunicationTypeId");
			Dictionary<string, string> columnNames = GetColumnNameByCommunicationType(communicationTypeId);
			string typedColumnName = columnNames["TypeColumnName"];
			string socialColumnName = columnNames["SocialColumnName"];
			var socialColumnValue = Entity.GetTypedColumnValue<string>("SocialMediaId");
			var isPrimary = Entity.GetTypedColumnValue<bool>("IsCreatedBySynchronization");
			if (string.IsNullOrEmpty(typedColumnName) || !isPrimary) {
				return;
			}
			var number = Entity.GetTypedColumnValue<string>("Number");
			parentEntity.SetColumnValue(typedColumnName, number);
			if (!string.IsNullOrEmpty(socialColumnName)) {
				parentEntity.SetColumnValue(socialColumnName, socialColumnValue);
			}
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			base.ThrowEvent(context, message);
			ProcessQueue(context);
		}

		public override void WritePropertiesData(DataWriter writer, bool writeFlowElements = true) {
			base.WritePropertiesData(writer, writeFlowElements);
			if (!HasMapping("OldCommunicationTypeId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("OldCommunicationTypeId", OldCommunicationTypeId, Guid.Empty);
			}
		}

		public override object CloneShallow() {
			return base.CloneShallow();
		}

		#endregion

	}

	#endregion

	#region Class: ContactCommunication_MarketingCampaignEventsProcess

	/// <exclude/>
	public class ContactCommunication_MarketingCampaignEventsProcess : ContactCommunication_MarketingCampaignEventsProcess<ContactCommunication>
	{

		public ContactCommunication_MarketingCampaignEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: ContactCommunicationEventsProcessSchema

	/// <exclude/>
	public class ContactCommunicationEventsProcessSchema : Terrasoft.Configuration.ContactCommunication_SSP_TerrasoftEventsProcessSchema
	{

		#region Constructors: Public

		public ContactCommunicationEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public ContactCommunicationEventsProcessSchema(ContactCommunicationEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "ContactCommunication_MarketingCampaignEventsProcess";
			UId = new Guid("805cac5f-dea9-42bb-a324-7a1296f1acff");
			CreatedInPackageId = new Guid("06c5e2cb-107e-4211-a5bd-01241dc3944b");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("cb324fcc-d158-43a8-8723-e59782577f7e");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
		}

		protected virtual ProcessSchemaParameter CreateOldCommunicationTypeIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("c27edd03-5f32-4f8a-b2b7-454fc8d8a2cc"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("805cac5f-dea9-42bb-a324-7a1296f1acff"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("805cac5f-dea9-42bb-a324-7a1296f1acff"),
				Name = @"OldCommunicationTypeId",
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateOldCommunicationTypeIdParameter());
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet1 = CreateLaneSet1LaneSet();
			LaneSets.Add(schemaLaneSet1);
			ProcessSchemaLane schemaLane1 = CreateLane1Lane();
			schemaLaneSet1.Lanes.Add(schemaLane1);
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("62d33586-ff38-4d71-9420-8c1be75d066f"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("cb324fcc-d158-43a8-8723-e59782577f7e"),
				CreatedInPackageId = new Guid("2bada33e-e916-4936-8b70-693fbba25856"),
				CreatedInSchemaUId = new Guid("805cac5f-dea9-42bb-a324-7a1296f1acff"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("805cac5f-dea9-42bb-a324-7a1296f1acff"),
				Name = @"LaneSet1",
				Position = new Point(0, 5),
				Size = new Size(0, 400),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("9905c155-71bb-48e7-b906-f262a30bbcf2"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("62d33586-ff38-4d71-9420-8c1be75d066f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("2bada33e-e916-4936-8b70-693fbba25856"),
				CreatedInSchemaUId = new Guid("805cac5f-dea9-42bb-a324-7a1296f1acff"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("805cac5f-dea9-42bb-a324-7a1296f1acff"),
				Name = @"Lane1",
				Position = new Point(0, 0),
				Size = new Size(700, 400),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateGetActualContactEmailMethod());
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("fb7b81ba-7c3c-45a5-ae9e-c6c03dceb812"),
				Name = "Terrasoft.UI.WebControls.Controls",
				Alias = "",
				CreatedInPackageId = new Guid("06c5e2cb-107e-4211-a5bd-01241dc3944b")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("cde525cf-d220-4d2a-b963-e55254c639fc"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("06c5e2cb-107e-4211-a5bd-01241dc3944b")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5c9c82c6-ba6d-4a57-9a14-87fe8faa4ebb"),
				Name = "Terrasoft.Core.DB",
				Alias = "",
				CreatedInPackageId = new Guid("06c5e2cb-107e-4211-a5bd-01241dc3944b")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7821de68-c82b-4917-a6cd-add2adfbe400"),
				Name = "Terrasoft.Common",
				Alias = "",
				CreatedInPackageId = new Guid("06c5e2cb-107e-4211-a5bd-01241dc3944b")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d67de76f-9cbc-4bfc-babb-6f65cb89b973"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("06c5e2cb-107e-4211-a5bd-01241dc3944b")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("74160d3b-65e3-4694-b554-089f2d980e54"),
				Name = "Newtonsoft.Json",
				Alias = "",
				CreatedInPackageId = new Guid("06c5e2cb-107e-4211-a5bd-01241dc3944b")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e401300a-9f16-40c2-9788-cf310ae9d1c5"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("06c5e2cb-107e-4211-a5bd-01241dc3944b")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("fadd6755-df51-4304-ac40-696bb22063b1"),
				Name = "Terrasoft.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("06c5e2cb-107e-4211-a5bd-01241dc3944b")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("84681f43-d1e8-42fa-9533-c2e87b3993eb"),
				Name = "System.Linq",
				Alias = "",
				CreatedInPackageId = new Guid("8ff9fe4f-03be-4db5-b64a-71abfee30f54")
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

		protected override SchemaMethod CreateSetNewContactCommunicationMethod() {
			SchemaMethod method = base.CreateSetNewContactCommunicationMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,86,75,115,155,48,16,62,227,95,129,57,100,240,140,135,31,208,180,157,73,93,154,122,90,59,206,216,105,206,50,108,98,141,65,114,133,72,74,27,255,247,174,36,222,224,87,14,62,96,246,123,236,174,216,213,11,17,118,192,153,36,129,156,134,246,39,219,103,146,202,204,187,5,185,202,118,16,78,120,148,198,236,23,137,82,248,120,155,210,240,179,235,76,138,104,103,116,61,120,169,224,254,242,30,241,12,94,115,142,101,176,129,152,220,167,32,50,247,33,1,129,56,6,129,164,156,121,245,128,25,97,228,25,196,216,46,136,21,109,69,233,221,132,225,77,20,153,88,227,38,113,155,194,168,90,139,71,231,134,190,37,58,174,210,68,56,125,178,221,2,62,68,215,105,20,141,236,127,3,203,208,198,113,202,104,64,20,76,85,225,236,194,116,112,206,200,91,241,165,20,148,61,43,211,154,158,165,241,26,196,113,198,68,67,144,115,174,131,157,2,155,240,128,146,168,22,121,38,205,82,227,102,16,82,98,250,166,217,104,178,16,52,38,34,59,206,178,230,60,66,142,105,50,17,64,36,132,95,178,101,198,130,141,224,140,254,213,185,150,132,18,161,6,57,39,177,242,102,12,120,126,188,147,89,79,10,253,81,201,43,149,193,70,245,167,83,79,221,35,43,32,9,216,157,106,99,171,19,153,120,63,41,219,66,56,101,211,240,195,192,178,45,171,227,201,41,34,28,212,178,172,30,63,78,197,97,98,214,152,248,246,250,148,242,10,125,75,16,90,184,79,55,127,127,88,182,36,184,68,245,27,9,0,59,180,61,40,91,4,28,214,173,40,46,17,246,99,66,163,131,170,250,237,37,116,203,173,238,240,161,166,233,215,151,240,125,231,49,44,54,156,193,65,139,101,196,37,180,51,190,166,209,9,226,90,204,37,212,143,92,108,143,19,95,78,9,235,131,100,248,174,73,181,31,88,106,44,14,155,161,158,255,59,37,81,226,214,63,210,145,249,14,213,96,192,33,50,33,204,15,169,26,195,56,61,242,7,131,47,151,133,51,110,205,6,53,49,140,90,137,55,156,150,0,153,10,166,94,239,107,18,169,16,192,244,104,210,7,75,143,252,206,116,40,172,158,56,177,90,59,39,190,139,194,58,41,62,246,76,241,218,12,127,135,68,205,59,150,252,125,206,117,31,235,164,115,46,181,212,157,48,156,195,158,26,93,93,181,254,198,208,178,236,110,15,224,237,173,85,145,81,206,209,80,235,237,147,57,29,118,96,40,243,174,55,178,41,214,85,190,117,143,238,171,158,179,162,86,71,186,11,113,255,228,151,140,7,253,208,89,242,213,45,194,38,73,30,84,36,125,94,202,58,59,235,7,100,218,211,130,80,145,251,26,219,122,19,218,219,151,157,57,235,55,129,76,213,44,53,119,15,133,118,235,119,12,69,67,159,220,225,169,162,20,205,71,94,15,101,71,133,5,203,228,235,45,65,186,249,60,29,219,166,44,222,130,8,172,12,46,139,10,101,4,247,131,54,114,138,237,99,198,234,81,18,237,197,208,236,203,130,245,117,94,159,159,115,147,50,183,29,125,144,202,235,70,145,96,205,101,179,227,61,14,115,158,178,172,104,161,189,202,142,76,170,166,88,27,216,35,215,185,104,53,234,187,183,33,194,169,155,207,175,190,227,83,125,29,26,161,126,245,158,204,120,72,159,40,132,119,172,175,27,95,49,110,69,49,161,7,25,204,249,171,145,206,225,143,27,16,128,77,85,87,203,105,162,51,118,59,4,213,41,172,67,253,63,16,164,248,201,140,244,172,223,255,7,166,239,197,68,250,11,0,0 };
			return method;
		}

		protected override SchemaMethod CreateClearOldContactCommunicationMethod() {
			SchemaMethod method = base.CreateClearOldContactCommunicationMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,145,79,75,195,64,16,197,207,45,244,59,140,57,37,32,249,2,53,133,18,165,20,108,5,21,239,211,236,88,23,55,179,210,157,61,4,233,119,119,243,71,187,161,246,80,200,33,12,111,126,239,189,29,253,14,233,3,139,150,38,95,145,172,93,105,141,175,249,13,141,167,71,139,138,84,154,108,45,47,43,241,104,146,44,131,239,217,116,178,179,214,0,255,78,161,128,19,224,181,249,34,21,49,238,90,237,98,196,152,7,130,14,174,55,127,132,158,58,25,40,47,36,17,32,90,125,38,116,150,215,42,185,5,246,198,116,160,75,75,247,40,20,102,39,219,104,231,8,100,28,245,158,93,21,9,161,203,15,228,61,169,81,153,97,22,129,93,154,229,75,110,210,170,27,65,177,128,254,47,223,98,77,80,20,144,148,182,174,61,235,10,69,91,110,95,35,228,237,147,182,157,35,167,161,244,53,173,55,120,248,36,209,188,47,45,59,113,249,6,57,8,76,115,166,237,13,143,109,215,217,52,124,79,70,253,147,235,252,112,157,238,116,187,149,215,42,220,238,82,165,29,58,202,75,67,120,232,246,88,176,146,145,54,205,230,63,97,12,41,55,95,2,0,0 };
			return method;
		}

		protected override SchemaMethod CreateOnContactCommunicationDeletedMethod() {
			SchemaMethod method = base.CreateOnContactCommunicationDeletedMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,149,93,111,155,48,20,134,175,137,148,255,192,114,5,18,226,7,180,219,164,44,202,218,104,107,148,138,172,187,118,224,180,177,48,118,102,76,42,54,229,191,207,95,16,8,249,40,220,26,191,239,243,158,99,115,188,71,220,141,25,21,40,22,243,232,217,253,226,82,120,119,231,84,96,81,70,241,22,50,244,92,0,47,189,95,57,240,25,163,20,98,129,25,13,155,27,158,16,69,111,192,3,119,50,51,62,19,255,126,60,234,88,204,24,41,50,42,89,89,86,80,28,35,229,99,215,36,180,32,228,163,162,69,114,42,219,31,107,88,36,114,217,216,132,15,32,214,229,14,236,246,23,68,10,248,252,80,224,228,171,87,37,93,36,58,171,210,211,34,219,0,191,46,206,5,199,244,77,202,151,122,115,173,109,197,83,170,15,167,232,232,38,126,184,102,145,230,120,149,61,206,87,28,103,136,151,215,77,55,140,17,105,186,200,103,28,144,128,228,91,25,149,52,222,114,70,241,95,77,208,121,243,119,44,226,173,235,157,201,236,187,255,198,35,39,70,57,184,157,100,178,97,185,200,195,159,152,166,144,44,228,25,220,201,173,206,249,195,60,94,167,112,154,216,136,222,164,146,234,20,39,210,198,145,94,23,219,3,115,156,141,172,49,189,191,21,119,45,139,21,192,7,164,181,202,65,97,107,106,175,172,223,81,12,242,8,211,1,97,43,233,160,180,71,110,175,184,243,12,97,50,32,171,214,245,34,69,169,190,157,189,73,90,215,139,244,200,50,88,109,25,29,66,171,181,189,136,79,108,131,201,96,102,67,221,139,250,155,241,116,40,243,44,45,129,87,84,16,161,205,56,136,130,83,185,122,24,143,218,22,83,66,204,104,55,94,185,231,183,103,183,153,109,109,178,28,116,102,249,228,5,10,142,3,95,185,224,87,53,209,154,46,159,204,235,96,102,154,130,236,213,144,108,152,223,30,243,103,218,18,46,81,6,186,120,69,212,150,225,252,79,129,72,238,153,7,196,55,64,199,120,84,176,214,65,188,216,32,102,139,252,145,118,162,212,237,52,69,116,198,114,5,184,241,39,86,100,231,7,148,26,177,66,152,219,90,2,87,63,14,110,186,223,73,176,172,121,26,11,233,105,95,65,109,224,181,250,233,168,75,113,57,186,244,9,37,166,181,209,54,52,2,209,232,165,122,142,150,140,26,156,249,245,3,173,214,95,13,233,80,213,94,191,115,85,37,87,157,47,157,78,112,185,233,182,178,78,159,235,25,217,186,52,189,2,84,22,54,66,243,108,45,245,80,215,122,226,138,246,160,255,4,245,241,240,31,149,100,125,201,143,9,0,0 };
			return method;
		}

		protected override SchemaMethod CreateOnContactCommunicationSavingMethod() {
			SchemaMethod method = base.CreateOnContactCommunicationSavingMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,93,142,49,10,2,49,16,69,251,156,34,164,202,130,236,5,20,65,131,136,141,22,43,246,179,217,89,13,36,51,178,153,8,81,188,187,34,22,226,239,223,123,191,135,140,237,129,28,147,128,23,199,41,21,10,30,36,48,117,112,11,116,182,205,92,133,81,219,13,73,144,218,110,81,142,245,138,131,227,88,18,157,32,22,92,244,204,113,105,205,158,105,229,165,64,52,77,163,31,74,255,237,43,232,80,126,88,107,118,217,77,8,130,195,186,118,149,252,101,98,10,247,79,223,204,244,8,49,227,251,192,83,189,0,137,152,77,149,168,0,0,0 };
			return method;
		}

		protected override SchemaMethod CreateSetCommunicationParentEntityColumnsMethod() {
			SchemaMethod method = base.CreateSetCommunicationParentEntityColumnsMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,145,203,106,195,48,20,68,215,13,228,31,20,175,108,48,249,129,166,89,196,13,193,139,186,5,151,110,74,23,138,173,182,23,244,48,122,4,212,38,255,94,73,118,30,216,137,233,74,112,117,231,204,104,180,195,18,85,130,49,195,161,194,26,4,127,181,13,201,107,244,128,214,92,131,182,243,13,209,126,84,103,130,26,198,223,48,53,100,177,49,80,47,227,40,27,234,162,228,126,58,121,132,202,79,176,180,11,165,37,240,175,20,181,231,210,89,121,74,129,25,81,206,194,177,179,211,96,101,7,188,248,74,50,111,208,210,144,62,231,242,0,7,188,192,191,71,126,255,124,27,125,156,133,74,84,128,233,109,101,217,187,15,218,157,107,234,82,24,170,24,239,169,123,117,220,1,159,72,13,184,235,200,211,64,189,72,96,174,166,113,202,86,8,234,24,185,202,36,193,154,212,43,91,90,94,125,75,193,225,39,20,19,128,240,137,226,214,111,158,171,194,80,250,44,215,172,209,54,238,181,148,160,253,30,205,78,214,9,250,157,78,238,36,209,70,114,71,57,180,201,184,97,91,34,255,249,184,34,44,135,16,13,150,132,235,78,84,30,127,55,236,247,115,164,157,201,49,251,236,106,248,254,79,37,109,222,49,159,190,36,29,254,154,247,60,252,1,43,129,108,137,250,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetActualContactEmailMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("c3565bee-a773-4e7e-8c1b-ee35b0311e79"),
				Name = "GetActualContactEmail",
				CreatedInSchemaUId = new Guid("805cac5f-dea9-42bb-a324-7a1296f1acff"),
				CreatedInPackageId = new Guid("b477c174-1d53-4a21-b489-a41e481a96a0"),
				ResultValueTypeName = "KeyValuePair<string, bool>"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("aca2e921-9626-43ff-ba65-b89397c50b1f"),
				Name = "contactId",
				CreatedInSchemaUId = new Guid("805cac5f-dea9-42bb-a324-7a1296f1acff"),
				ModifiedInSchemaUId = new Guid("805cac5f-dea9-42bb-a324-7a1296f1acff"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("b477c174-1d53-4a21-b489-a41e481a96a0")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,83,77,107,2,49,16,61,87,240,63,132,61,101,65,22,236,213,42,216,173,45,69,170,246,251,28,179,163,6,178,19,205,71,101,41,253,239,77,204,182,202,138,246,210,91,102,242,230,205,155,151,201,24,170,55,38,29,204,152,208,87,198,106,129,203,14,153,43,37,7,68,131,113,210,146,62,65,216,146,241,73,28,141,81,54,42,215,182,234,144,5,147,6,210,94,187,245,193,52,1,179,169,235,71,104,133,173,158,249,10,74,246,232,64,87,244,213,128,206,21,34,112,43,20,102,135,128,7,134,108,9,186,67,18,15,176,140,219,92,149,165,67,193,89,128,38,129,221,51,103,79,106,155,43,135,65,98,215,167,142,90,228,74,186,18,9,42,28,114,235,152,172,227,126,144,149,13,139,34,198,52,153,252,0,146,52,155,234,2,244,117,53,52,156,118,211,51,164,42,226,110,192,240,83,180,185,6,102,161,152,226,158,54,192,233,229,57,94,116,229,60,248,114,66,233,238,246,215,128,91,33,45,104,19,16,52,196,177,99,204,190,11,187,154,49,205,74,8,16,26,147,222,199,53,211,194,40,124,169,214,144,141,54,126,232,189,203,73,135,240,120,186,47,210,255,239,113,240,132,225,198,119,107,183,46,142,210,94,139,177,198,111,19,19,178,150,17,189,242,30,200,184,43,4,154,137,104,212,29,216,38,180,177,101,129,109,161,252,4,124,69,104,196,214,100,68,28,211,166,228,211,43,212,96,157,198,191,62,65,172,13,18,194,16,245,131,237,192,53,112,64,15,159,54,155,120,211,210,157,3,23,228,76,109,36,111,108,112,44,14,179,124,181,91,181,188,248,89,123,223,180,201,86,165,207,3,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new ContactCommunicationEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("805cac5f-dea9-42bb-a324-7a1296f1acff"));
		}

		#endregion

	}

	#endregion


	#region Class: ContactCommunicationEventsProcess

	/// <exclude/>
	public class ContactCommunicationEventsProcess : ContactCommunication_MarketingCampaignEventsProcess
	{

		public ContactCommunicationEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

