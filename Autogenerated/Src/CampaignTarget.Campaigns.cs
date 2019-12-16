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
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities.Json.Converters;

	#region Class: CampaignTargetSchema

	/// <exclude/>
	public class CampaignTargetSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public CampaignTargetSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public CampaignTargetSchema(CampaignTargetSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public CampaignTargetSchema(CampaignTargetSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private EntitySchemaIndex CreateIihaGX41KCSArfXeqMVcTw0d7rgIndex() {
			EntitySchemaIndex index = new EntitySchemaIndex() {
				IsAutoName = true,
				IsClustered = false,
				IsUnique = false
			};
			index.UId = new Guid("3d6fc53a-21f9-430a-9546-0301bccc910b");
			index.Name = "IihaGX41KCSArfXeqMVcTw0d7rg";
			index.CreatedInSchemaUId = new Guid("8643c3cf-f6be-43f4-9b93-fe14ba3b9123");
			index.ModifiedInSchemaUId = new Guid("8643c3cf-f6be-43f4-9b93-fe14ba3b9123");
			index.CreatedInPackageId = new Guid("9a2ba413-fb27-45c1-a487-c3fec273d0a5");
			EntitySchemaIndexColumn campaignIdIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("a00e2c05-14b7-4b5a-b48e-c092f472586d"),
				ColumnUId = new Guid("373a994c-09db-47cc-9953-57f8ba5a9fa8"),
				CreatedInSchemaUId = new Guid("8643c3cf-f6be-43f4-9b93-fe14ba3b9123"),
				ModifiedInSchemaUId = new Guid("8643c3cf-f6be-43f4-9b93-fe14ba3b9123"),
				CreatedInPackageId = new Guid("9a2ba413-fb27-45c1-a487-c3fec273d0a5"),
				OrderDirection = OrderDirectionStrict.Ascending
			};
			index.Columns.Add(campaignIdIndexColumn);
			EntitySchemaIndexColumn currentStepIdIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("50633eba-5dc3-470b-aa74-4836fed19cbb"),
				ColumnUId = new Guid("69e4019d-d797-4d93-ab91-ba2a63d19935"),
				CreatedInSchemaUId = new Guid("8643c3cf-f6be-43f4-9b93-fe14ba3b9123"),
				ModifiedInSchemaUId = new Guid("8643c3cf-f6be-43f4-9b93-fe14ba3b9123"),
				CreatedInPackageId = new Guid("9a2ba413-fb27-45c1-a487-c3fec273d0a5"),
				OrderDirection = OrderDirectionStrict.Ascending
			};
			index.Columns.Add(currentStepIdIndexColumn);
			EntitySchemaIndexColumn nextStepIdIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("b1d5dede-c11d-4246-b6cf-fe49e63ce028"),
				ColumnUId = new Guid("8e52df9c-1881-4c74-8fc6-1fe051ddf153"),
				CreatedInSchemaUId = new Guid("8643c3cf-f6be-43f4-9b93-fe14ba3b9123"),
				ModifiedInSchemaUId = new Guid("8643c3cf-f6be-43f4-9b93-fe14ba3b9123"),
				CreatedInPackageId = new Guid("9a2ba413-fb27-45c1-a487-c3fec273d0a5"),
				OrderDirection = OrderDirectionStrict.Ascending
			};
			index.Columns.Add(nextStepIdIndexColumn);
			EntitySchemaIndexColumn modifiedOnIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("027172a6-510c-459e-9af1-cec214d86c4a"),
				ColumnUId = new Guid("9928edec-4272-425a-93bb-48743fee4b04"),
				CreatedInSchemaUId = new Guid("8643c3cf-f6be-43f4-9b93-fe14ba3b9123"),
				ModifiedInSchemaUId = new Guid("8643c3cf-f6be-43f4-9b93-fe14ba3b9123"),
				CreatedInPackageId = new Guid("9a2ba413-fb27-45c1-a487-c3fec273d0a5"),
				OrderDirection = OrderDirectionStrict.Ascending
			};
			index.Columns.Add(modifiedOnIndexColumn);
			return index;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("8643c3cf-f6be-43f4-9b93-fe14ba3b9123");
			RealUId = new Guid("8643c3cf-f6be-43f4-9b93-fe14ba3b9123");
			Name = "CampaignTarget";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("c130e4bc-accb-4cd0-8b02-dd2e4506d5d1");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("373a994c-09db-47cc-9953-57f8ba5a9fa8")) == null) {
				Columns.Add(CreateCampaignColumn());
			}
			if (Columns.FindByUId(new Guid("b1866cfa-30c5-4016-b11e-f6a3df6d1837")) == null) {
				Columns.Add(CreateContactColumn());
			}
			if (Columns.FindByUId(new Guid("a3d475bc-ae39-45d9-9ea2-c3e391d797b0")) == null) {
				Columns.Add(CreateCampaignTargetStatusColumn());
			}
			if (Columns.FindByUId(new Guid("55fe2b63-fa1f-4427-a2e1-8595019dcb07")) == null) {
				Columns.Add(CreateIsFromGroupColumn());
			}
			if (Columns.FindByUId(new Guid("69e4019d-d797-4d93-ab91-ba2a63d19935")) == null) {
				Columns.Add(CreateCurrentStepColumn());
			}
			if (Columns.FindByUId(new Guid("8e52df9c-1881-4c74-8fc6-1fe051ddf153")) == null) {
				Columns.Add(CreateNextStepColumn());
			}
			if (Columns.FindByUId(new Guid("477f1784-e46b-4626-a4f6-de520a1322ac")) == null) {
				Columns.Add(CreatePassedStepColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateCampaignColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("373a994c-09db-47cc-9953-57f8ba5a9fa8"),
				Name = @"Campaign",
				ReferenceSchemaUId = new Guid("1f9bb71a-eb9c-4220-a40e-9b623eacfec8"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsValueCloneable = false,
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("8643c3cf-f6be-43f4-9b93-fe14ba3b9123"),
				ModifiedInSchemaUId = new Guid("8643c3cf-f6be-43f4-9b93-fe14ba3b9123"),
				CreatedInPackageId = new Guid("c130e4bc-accb-4cd0-8b02-dd2e4506d5d1")
			};
		}

		protected virtual EntitySchemaColumn CreateContactColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("b1866cfa-30c5-4016-b11e-f6a3df6d1837"),
				Name = @"Contact",
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsValueCloneable = false,
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("8643c3cf-f6be-43f4-9b93-fe14ba3b9123"),
				ModifiedInSchemaUId = new Guid("8643c3cf-f6be-43f4-9b93-fe14ba3b9123"),
				CreatedInPackageId = new Guid("c130e4bc-accb-4cd0-8b02-dd2e4506d5d1")
			};
		}

		protected virtual EntitySchemaColumn CreateCampaignTargetStatusColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("a3d475bc-ae39-45d9-9ea2-c3e391d797b0"),
				Name = @"CampaignTargetStatus",
				ReferenceSchemaUId = new Guid("4632eea4-8425-48a6-a698-c5088b2884f1"),
				IsIndexed = true,
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("8643c3cf-f6be-43f4-9b93-fe14ba3b9123"),
				ModifiedInSchemaUId = new Guid("8643c3cf-f6be-43f4-9b93-fe14ba3b9123"),
				CreatedInPackageId = new Guid("781fc653-c4cb-4c1b-b941-83a6b0fc8787"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"7d7ef797-cda6-4bd8-be03-bac67fbf73d7"
				}
			};
		}

		protected virtual EntitySchemaColumn CreateIsFromGroupColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("55fe2b63-fa1f-4427-a2e1-8595019dcb07"),
				Name = @"IsFromGroup",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("8643c3cf-f6be-43f4-9b93-fe14ba3b9123"),
				ModifiedInSchemaUId = new Guid("8643c3cf-f6be-43f4-9b93-fe14ba3b9123"),
				CreatedInPackageId = new Guid("781fc653-c4cb-4c1b-b941-83a6b0fc8787"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"False"
				}
			};
		}

		protected virtual EntitySchemaColumn CreateCurrentStepColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("69e4019d-d797-4d93-ab91-ba2a63d19935"),
				Name = @"CurrentStep",
				ReferenceSchemaUId = new Guid("1c6cda37-90f0-4b88-a13c-af0b11cc464f"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("8643c3cf-f6be-43f4-9b93-fe14ba3b9123"),
				ModifiedInSchemaUId = new Guid("8643c3cf-f6be-43f4-9b93-fe14ba3b9123"),
				CreatedInPackageId = new Guid("5ef8c1cb-e12d-44bb-94fb-8751249ccc2c")
			};
		}

		protected virtual EntitySchemaColumn CreateNextStepColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("8e52df9c-1881-4c74-8fc6-1fe051ddf153"),
				Name = @"NextStep",
				ReferenceSchemaUId = new Guid("1c6cda37-90f0-4b88-a13c-af0b11cc464f"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("8643c3cf-f6be-43f4-9b93-fe14ba3b9123"),
				ModifiedInSchemaUId = new Guid("8643c3cf-f6be-43f4-9b93-fe14ba3b9123"),
				CreatedInPackageId = new Guid("5ef8c1cb-e12d-44bb-94fb-8751249ccc2c")
			};
		}

		protected virtual EntitySchemaColumn CreatePassedStepColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("477f1784-e46b-4626-a4f6-de520a1322ac"),
				Name = @"PassedStep",
				ReferenceSchemaUId = new Guid("1c6cda37-90f0-4b88-a13c-af0b11cc464f"),
				IsIndexed = true,
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("8643c3cf-f6be-43f4-9b93-fe14ba3b9123"),
				ModifiedInSchemaUId = new Guid("8643c3cf-f6be-43f4-9b93-fe14ba3b9123"),
				CreatedInPackageId = new Guid("2def6958-6e0c-463c-8c46-5a65b8967369")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeIndexes() {
			base.InitializeIndexes();
			Indexes.Add(CreateIihaGX41KCSArfXeqMVcTw0d7rgIndex());
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateCampaignTargetEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateCampaignTargetEventsProcessSchema() {
			var schema = new CampaignTargetEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new CampaignTarget(userConnection){Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new CampaignTarget_CampaignsEventsProcess(userConnnection);
		}

		public override object Clone() {
			return new CampaignTargetSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new CampaignTargetSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("8643c3cf-f6be-43f4-9b93-fe14ba3b9123"));
		}

		#endregion

	}

	#endregion

	#region Class: CampaignTarget

	/// <summary>
	/// Campaign participant (previous version).
	/// </summary>
	public class CampaignTarget : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public CampaignTarget(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "CampaignTarget";
		}

		public CampaignTarget(CampaignTarget source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public  Guid CampaignId {
			get {
				return GetTypedColumnValue<Guid>("CampaignId");
			}
			set {
				SetColumnValue("CampaignId", value);
				_campaign = null;
			}
		}

		/// <exclude/>
		public  string CampaignName {
			get {
				return GetTypedColumnValue<string>("CampaignName");
			}
			set {
				SetColumnValue("CampaignName", value);
				if (_campaign != null) {
					_campaign.Name = value;
				}
			}
		}

		private Campaign _campaign;
		/// <summary>
		/// Campaign.
		/// </summary>
		public  Campaign Campaign {
			get {
				return _campaign ??
					(_campaign = LookupColumnEntities.GetEntity("Campaign") as Campaign);
			}
		}

		/// <exclude/>
		public  Guid ContactId {
			get {
				return GetTypedColumnValue<Guid>("ContactId");
			}
			set {
				SetColumnValue("ContactId", value);
				_contact = null;
			}
		}

		/// <exclude/>
		public  string ContactName {
			get {
				return GetTypedColumnValue<string>("ContactName");
			}
			set {
				SetColumnValue("ContactName", value);
				if (_contact != null) {
					_contact.Name = value;
				}
			}
		}

		private Contact _contact;
		/// <summary>
		/// Contact.
		/// </summary>
		public  Contact Contact {
			get {
				return _contact ??
					(_contact = LookupColumnEntities.GetEntity("Contact") as Contact);
			}
		}

		/// <exclude/>
		public  Guid CampaignTargetStatusId {
			get {
				return GetTypedColumnValue<Guid>("CampaignTargetStatusId");
			}
			set {
				SetColumnValue("CampaignTargetStatusId", value);
				_campaignTargetStatus = null;
			}
		}

		/// <exclude/>
		public  string CampaignTargetStatusName {
			get {
				return GetTypedColumnValue<string>("CampaignTargetStatusName");
			}
			set {
				SetColumnValue("CampaignTargetStatusName", value);
				if (_campaignTargetStatus != null) {
					_campaignTargetStatus.Name = value;
				}
			}
		}

		private CampaignTargetStatus _campaignTargetStatus;
		/// <summary>
		/// Campaign involvement.
		/// </summary>
		public  CampaignTargetStatus CampaignTargetStatus {
			get {
				return _campaignTargetStatus ??
					(_campaignTargetStatus = LookupColumnEntities.GetEntity("CampaignTargetStatus") as CampaignTargetStatus);
			}
		}

		/// <summary>
		/// IsFromGroup.
		/// </summary>
		public  bool IsFromGroup {
			get {
				return GetTypedColumnValue<bool>("IsFromGroup");
			}
			set {
				SetColumnValue("IsFromGroup", value);
			}
		}

		/// <exclude/>
		public  Guid CurrentStepId {
			get {
				return GetTypedColumnValue<Guid>("CurrentStepId");
			}
			set {
				SetColumnValue("CurrentStepId", value);
				_currentStep = null;
			}
		}

		/// <exclude/>
		public  string CurrentStepTitle {
			get {
				return GetTypedColumnValue<string>("CurrentStepTitle");
			}
			set {
				SetColumnValue("CurrentStepTitle", value);
				if (_currentStep != null) {
					_currentStep.Title = value;
				}
			}
		}

		private CampaignStep _currentStep;
		/// <summary>
		/// Current step.
		/// </summary>
		public  CampaignStep CurrentStep {
			get {
				return _currentStep ??
					(_currentStep = LookupColumnEntities.GetEntity("CurrentStep") as CampaignStep);
			}
		}

		/// <exclude/>
		public  Guid NextStepId {
			get {
				return GetTypedColumnValue<Guid>("NextStepId");
			}
			set {
				SetColumnValue("NextStepId", value);
				_nextStep = null;
			}
		}

		/// <exclude/>
		public  string NextStepTitle {
			get {
				return GetTypedColumnValue<string>("NextStepTitle");
			}
			set {
				SetColumnValue("NextStepTitle", value);
				if (_nextStep != null) {
					_nextStep.Title = value;
				}
			}
		}

		private CampaignStep _nextStep;
		/// <summary>
		/// Next step.
		/// </summary>
		public  CampaignStep NextStep {
			get {
				return _nextStep ??
					(_nextStep = LookupColumnEntities.GetEntity("NextStep") as CampaignStep);
			}
		}

		/// <exclude/>
		public  Guid PassedStepId {
			get {
				return GetTypedColumnValue<Guid>("PassedStepId");
			}
			set {
				SetColumnValue("PassedStepId", value);
				_passedStep = null;
			}
		}

		/// <exclude/>
		public  string PassedStepTitle {
			get {
				return GetTypedColumnValue<string>("PassedStepTitle");
			}
			set {
				SetColumnValue("PassedStepTitle", value);
				if (_passedStep != null) {
					_passedStep.Title = value;
				}
			}
		}

		private CampaignStep _passedStep;
		/// <summary>
		/// Completed step.
		/// </summary>
		public  CampaignStep PassedStep {
			get {
				return _passedStep ??
					(_passedStep = LookupColumnEntities.GetEntity("PassedStep") as CampaignStep);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new CampaignTarget_CampaignsEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("CampaignTargetDeleted", e);
			Inserted += (s, e) => ThrowEvent("CampaignTargetInserted", e);
			Validating += (s, e) => ThrowEvent("CampaignTargetValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new CampaignTarget(this);
		}

		#endregion

	}

	#endregion

	#region Class: CampaignTarget_CampaignsEventsProcess

	/// <exclude/>
	public class CampaignTarget_CampaignsEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_LocalMessageEventsProcess<TEntity> where TEntity : CampaignTarget
	{

		public CampaignTarget_CampaignsEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "CampaignTarget_CampaignsEventsProcess";
			SchemaUId = new Guid("8643c3cf-f6be-43f4-9b93-fe14ba3b9123");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private  Guid InternalSchemaUId {
			get {
				return new Guid("8643c3cf-f6be-43f4-9b93-fe14ba3b9123");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
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
					SchemaElementUId = new Guid("0a088dce-5fdb-40f4-b947-8853000b1670"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _campaignTargetInserted;
		public  ProcessFlowElement CampaignTargetInserted {
			get {
				return _campaignTargetInserted ?? (_campaignTargetInserted = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "CampaignTargetInserted",
					SchemaElementUId = new Guid("4622b3b5-e3c1-47e4-ab4e-d5280c985008"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _campaignTargetInsertedScriptTask;
		public  ProcessScriptTask CampaignTargetInsertedScriptTask {
			get {
				return _campaignTargetInsertedScriptTask ?? (_campaignTargetInsertedScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "CampaignTargetInsertedScriptTask",
					SchemaElementUId = new Guid("5afedccf-9e10-44e9-b3ee-b67388821817"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = CampaignTargetInsertedScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcess2;
		public  ProcessFlowElement EventSubProcess2 {
			get {
				return _eventSubProcess2 ?? (_eventSubProcess2 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess2",
					SchemaElementUId = new Guid("57aed1c6-038c-49c3-a557-3a5b73ed016e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _campaignTargetDeleted;
		public  ProcessFlowElement CampaignTargetDeleted {
			get {
				return _campaignTargetDeleted ?? (_campaignTargetDeleted = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "CampaignTargetDeleted",
					SchemaElementUId = new Guid("2765b473-9238-40af-858a-a1294fc1f185"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _campaignTargetDeletedScriptTask;
		public  ProcessScriptTask CampaignTargetDeletedScriptTask {
			get {
				return _campaignTargetDeletedScriptTask ?? (_campaignTargetDeletedScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "CampaignTargetDeletedScriptTask",
					SchemaElementUId = new Guid("ba67467c-b9d4-45e6-95a7-c89720754d20"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = CampaignTargetDeletedScriptTaskExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[EventSubProcess1.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess1 };
			FlowElements[CampaignTargetInserted.SchemaElementUId] = new Collection<ProcessFlowElement> { CampaignTargetInserted };
			FlowElements[CampaignTargetInsertedScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { CampaignTargetInsertedScriptTask };
			FlowElements[EventSubProcess2.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess2 };
			FlowElements[CampaignTargetDeleted.SchemaElementUId] = new Collection<ProcessFlowElement> { CampaignTargetDeleted };
			FlowElements[CampaignTargetDeletedScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { CampaignTargetDeletedScriptTask };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "EventSubProcess1":
						break;
					case "CampaignTargetInserted":
						e.Context.QueueTasks.Enqueue("CampaignTargetInsertedScriptTask");
						break;
					case "CampaignTargetInsertedScriptTask":
						break;
					case "EventSubProcess2":
						break;
					case "CampaignTargetDeleted":
						e.Context.QueueTasks.Enqueue("CampaignTargetDeletedScriptTask");
						break;
					case "CampaignTargetDeletedScriptTask":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("CampaignTargetInserted");
			ActivatedEventElements.Add("CampaignTargetDeleted");
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
				case "CampaignTargetInserted":
					context.QueueTasks.Dequeue();
					context.SenderName = "CampaignTargetInserted";
					result = CampaignTargetInserted.Execute(context);
					break;
				case "CampaignTargetInsertedScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "CampaignTargetInsertedScriptTask";
					result = CampaignTargetInsertedScriptTask.Execute(context, CampaignTargetInsertedScriptTaskExecute);
					break;
				case "EventSubProcess2":
					context.QueueTasks.Dequeue();
					break;
				case "CampaignTargetDeleted":
					context.QueueTasks.Dequeue();
					context.SenderName = "CampaignTargetDeleted";
					result = CampaignTargetDeleted.Execute(context);
					break;
				case "CampaignTargetDeletedScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "CampaignTargetDeletedScriptTask";
					result = CampaignTargetDeletedScriptTask.Execute(context, CampaignTargetDeletedScriptTaskExecute);
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

		public virtual bool CampaignTargetInsertedScriptTaskExecute(ProcessExecutingContext context) {
			UpdateTargetTotal(1);
			return true;
		}

		public virtual bool CampaignTargetDeletedScriptTaskExecute(ProcessExecutingContext context) {
			UpdateTargetTotal(-1);
			return true;
		}

		public virtual void UpdateTargetTotal(int intCount) {
			Guid campaignId = Entity.GetTypedColumnValue<Guid>("CampaignId");
			if (campaignId == Guid.Empty) {
				return;
			}
			var update = new Update(UserConnection, "Campaign")
				.Set("ModifiedOn", Column.Parameter(DateTime.UtcNow))
				.Set("ModifiedById", Column.Parameter(UserConnection.CurrentUser.ContactId))
				.Set("TargetTotal", QueryColumnExpression.Add(new QueryColumnExpression("TargetTotal"),
					Column.Parameter(intCount)))
				.Where("Id").IsEqual(Column.Parameter(campaignId)) as Update;
			update.Execute();
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "CampaignTargetInserted":
							if (ActivatedEventElements.Contains("CampaignTargetInserted")) {
							context.QueueTasks.Enqueue("CampaignTargetInserted");
						}
						break;
					case "CampaignTargetDeleted":
							if (ActivatedEventElements.Contains("CampaignTargetDeleted")) {
							context.QueueTasks.Enqueue("CampaignTargetDeleted");
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

	#region Class: CampaignTarget_CampaignsEventsProcess

	/// <exclude/>
	public class CampaignTarget_CampaignsEventsProcess : CampaignTarget_CampaignsEventsProcess<CampaignTarget>
	{

		public CampaignTarget_CampaignsEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: CampaignTargetEventsProcessSchema

	/// <exclude/>
	public class CampaignTargetEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public CampaignTargetEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public CampaignTargetEventsProcessSchema(CampaignTargetEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "CampaignTarget_CampaignsEventsProcess";
			UId = new Guid("ab66a6bd-823d-4d5c-b63e-0b867262b0f6");
			CreatedInPackageId = new Guid("c130e4bc-accb-4cd0-8b02-dd2e4506d5d1");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165");
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
			ProcessSchemaLane schemaLane2 = CreateLane2Lane();
			schemaLaneSet1.Lanes.Add(schemaLane2);
			ProcessSchemaEventSubProcess eventsubprocess1 = CreateEventSubProcess1EventSubProcess();
			FlowElements.Add(eventsubprocess1);
			ProcessSchemaEventSubProcess eventsubprocess2 = CreateEventSubProcess2EventSubProcess();
			FlowElements.Add(eventsubprocess2);
			ProcessSchemaStartMessageEvent campaigntargetinserted = CreateCampaignTargetInsertedStartMessageEvent();
			eventsubprocess1.FlowElements.Add(campaigntargetinserted);
			ProcessSchemaScriptTask campaigntargetinsertedscripttask = CreateCampaignTargetInsertedScriptTaskScriptTask();
			eventsubprocess1.FlowElements.Add(campaigntargetinsertedscripttask);
			ProcessSchemaStartMessageEvent campaigntargetdeleted = CreateCampaignTargetDeletedStartMessageEvent();
			eventsubprocess2.FlowElements.Add(campaigntargetdeleted);
			ProcessSchemaScriptTask campaigntargetdeletedscripttask = CreateCampaignTargetDeletedScriptTaskScriptTask();
			eventsubprocess2.FlowElements.Add(campaigntargetdeletedscripttask);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("958ceebe-d495-4dec-beab-fad03c002a0d"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("c130e4bc-accb-4cd0-8b02-dd2e4506d5d1"),
				CreatedInSchemaUId = new Guid("ab66a6bd-823d-4d5c-b63e-0b867262b0f6"),
				CurveCenterPosition = new Point(262, 76),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("ab66a6bd-823d-4d5c-b63e-0b867262b0f6"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("4622b3b5-e3c1-47e4-ab4e-d5280c985008"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("5afedccf-9e10-44e9-b3ee-b67388821817"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("2269a19e-eb54-419c-bb5d-23f7b8625421"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("c130e4bc-accb-4cd0-8b02-dd2e4506d5d1"),
				CreatedInSchemaUId = new Guid("ab66a6bd-823d-4d5c-b63e-0b867262b0f6"),
				CurveCenterPosition = new Point(270, 231),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("ab66a6bd-823d-4d5c-b63e-0b867262b0f6"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("2765b473-9238-40af-858a-a1294fc1f185"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("ba67467c-b9d4-45e6-95a7-c89720754d20"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("1cbad604-f575-4768-a377-8353b6e89f83"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("c130e4bc-accb-4cd0-8b02-dd2e4506d5d1"),
				CreatedInSchemaUId = new Guid("ab66a6bd-823d-4d5c-b63e-0b867262b0f6"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("ab66a6bd-823d-4d5c-b63e-0b867262b0f6"),
				Name = @"LaneSet1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(5, 5),
				Size = new Size(912, 359),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("41c32662-6aa6-43f3-8f53-75bd4746c416"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("1cbad604-f575-4768-a377-8353b6e89f83"),
				CreatedInOwnerSchemaUId = new Guid("8643c3cf-f6be-43f4-9b93-fe14ba3b9123"),
				CreatedInPackageId = new Guid("c130e4bc-accb-4cd0-8b02-dd2e4506d5d1"),
				CreatedInSchemaUId = new Guid("ab66a6bd-823d-4d5c-b63e-0b867262b0f6"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("ab66a6bd-823d-4d5c-b63e-0b867262b0f6"),
				Name = @"Lane1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(29, 0),
				Size = new Size(883, 177),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaLane CreateLane2Lane() {
			ProcessSchemaLane schemaLane2 = new ProcessSchemaLane(this) {
				UId = new Guid("d81fa8db-9f7c-4c58-837c-ec9550ad7ec9"),
				ContainerItemIndex = 2,
				ContainerUId = new Guid("1cbad604-f575-4768-a377-8353b6e89f83"),
				CreatedInOwnerSchemaUId = new Guid("8643c3cf-f6be-43f4-9b93-fe14ba3b9123"),
				CreatedInPackageId = new Guid("c130e4bc-accb-4cd0-8b02-dd2e4506d5d1"),
				CreatedInSchemaUId = new Guid("ab66a6bd-823d-4d5c-b63e-0b867262b0f6"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("ab66a6bd-823d-4d5c-b63e-0b867262b0f6"),
				Name = @"Lane2",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(29, 182),
				Size = new Size(883, 177),
				UseBackgroundMode = false
			};
			return schemaLane2;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess1EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess1 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("0a088dce-5fdb-40f4-b947-8853000b1670"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("41c32662-6aa6-43f3-8f53-75bd4746c416"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("c130e4bc-accb-4cd0-8b02-dd2e4506d5d1"),
				CreatedInSchemaUId = new Guid("ab66a6bd-823d-4d5c-b63e-0b867262b0f6"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("ab66a6bd-823d-4d5c-b63e-0b867262b0f6"),
				Name = @"EventSubProcess1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(42, 14),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(495, 140),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess1;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateCampaignTargetInsertedStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("4622b3b5-e3c1-47e4-ab4e-d5280c985008"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0a088dce-5fdb-40f4-b947-8853000b1670"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("c130e4bc-accb-4cd0-8b02-dd2e4506d5d1"),
				CreatedInSchemaUId = new Guid("ab66a6bd-823d-4d5c-b63e-0b867262b0f6"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"CampaignTargetInserted",
				ModifiedInSchemaUId = new Guid("ab66a6bd-823d-4d5c-b63e-0b867262b0f6"),
				Name = @"CampaignTargetInserted",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(50, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateCampaignTargetInsertedScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("5afedccf-9e10-44e9-b3ee-b67388821817"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0a088dce-5fdb-40f4-b947-8853000b1670"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("c130e4bc-accb-4cd0-8b02-dd2e4506d5d1"),
				CreatedInSchemaUId = new Guid("ab66a6bd-823d-4d5c-b63e-0b867262b0f6"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("ab66a6bd-823d-4d5c-b63e-0b867262b0f6"),
				Name = @"CampaignTargetInsertedScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(358, 37),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,45,72,73,44,73,13,73,44,74,79,45,9,201,47,73,204,209,48,212,180,230,229,42,74,45,41,45,202,83,40,41,42,77,181,6,0,19,64,128,40,35,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess2EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess2 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("57aed1c6-038c-49c3-a557-3a5b73ed016e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d81fa8db-9f7c-4c58-837c-ec9550ad7ec9"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("c130e4bc-accb-4cd0-8b02-dd2e4506d5d1"),
				CreatedInSchemaUId = new Guid("ab66a6bd-823d-4d5c-b63e-0b867262b0f6"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("ab66a6bd-823d-4d5c-b63e-0b867262b0f6"),
				Name = @"EventSubProcess2",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(43, 16),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(501, 140),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess2;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateCampaignTargetDeletedStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("2765b473-9238-40af-858a-a1294fc1f185"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("57aed1c6-038c-49c3-a557-3a5b73ed016e"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("c130e4bc-accb-4cd0-8b02-dd2e4506d5d1"),
				CreatedInSchemaUId = new Guid("ab66a6bd-823d-4d5c-b63e-0b867262b0f6"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"CampaignTargetDeleted",
				ModifiedInSchemaUId = new Guid("ab66a6bd-823d-4d5c-b63e-0b867262b0f6"),
				Name = @"CampaignTargetDeleted",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(63, 42),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateCampaignTargetDeletedScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("ba67467c-b9d4-45e6-95a7-c89720754d20"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("57aed1c6-038c-49c3-a557-3a5b73ed016e"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("c130e4bc-accb-4cd0-8b02-dd2e4506d5d1"),
				CreatedInSchemaUId = new Guid("ab66a6bd-823d-4d5c-b63e-0b867262b0f6"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("ab66a6bd-823d-4d5c-b63e-0b867262b0f6"),
				Name = @"CampaignTargetDeletedScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(357, 28),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,45,72,73,44,73,13,73,44,74,79,45,9,201,47,73,204,209,208,53,212,180,230,229,42,74,45,41,45,202,83,40,41,42,77,181,6,0,172,56,137,48,36,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateUpdateTargetTotalMethod());
		}

		protected override void InitializeUsings() {
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
				UId = new Guid("5c9c82c6-ba6d-4a57-9a14-87fe8faa4ebb"),
				Name = "Terrasoft.Core.DB",
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

		protected virtual SchemaMethod CreateUpdateTargetTotalMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("2924540a-a761-4c89-a18d-8124665b4f8d"),
				Name = "UpdateTargetTotal",
				CreatedInSchemaUId = new Guid("ab66a6bd-823d-4d5c-b63e-0b867262b0f6"),
				CreatedInPackageId = new Guid("c130e4bc-accb-4cd0-8b02-dd2e4506d5d1"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("b656a357-c66f-47fc-a1a8-df848d3784af"),
				Name = "intCount",
				CreatedInSchemaUId = new Guid("ab66a6bd-823d-4d5c-b63e-0b867262b0f6"),
				ModifiedInSchemaUId = new Guid("ab66a6bd-823d-4d5c-b63e-0b867262b0f6"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "int",
				CreatedInPackageId = new Guid("c130e4bc-accb-4cd0-8b02-dd2e4506d5d1")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,145,205,110,131,48,16,132,207,65,226,29,44,78,182,132,252,2,105,42,181,20,33,14,253,83,161,61,91,120,147,90,130,53,53,235,38,168,234,187,215,148,42,77,68,142,94,207,126,51,30,23,222,104,214,168,174,87,102,135,165,102,27,150,35,25,26,101,1,84,141,61,232,204,182,190,195,87,213,122,184,42,130,248,154,39,217,81,158,136,117,28,153,45,227,167,132,13,155,116,50,239,122,26,5,251,138,163,149,3,242,14,131,244,59,142,62,149,99,190,215,138,32,120,33,236,89,253,123,224,245,0,46,179,136,208,144,177,152,178,163,75,34,2,65,190,0,241,228,222,106,179,53,160,31,49,73,217,28,76,62,41,167,58,32,112,252,46,96,42,211,129,172,169,121,176,123,177,220,187,29,67,228,11,155,231,222,50,243,206,1,210,52,149,97,76,170,161,82,159,224,42,229,118,161,29,75,170,13,180,103,15,110,156,145,249,161,119,48,12,19,227,70,107,62,189,238,226,237,57,66,164,129,188,90,132,50,72,153,245,72,98,118,126,123,7,7,60,153,58,151,229,144,127,120,213,242,197,206,255,55,8,193,212,240,215,109,40,126,110,92,230,7,104,124,40,91,172,127,0,162,61,102,77,248,1,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new CampaignTargetEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ab66a6bd-823d-4d5c-b63e-0b867262b0f6"));
		}

		#endregion

	}

	#endregion


	#region Class: CampaignTargetEventsProcess

	/// <exclude/>
	public class CampaignTargetEventsProcess : CampaignTarget_CampaignsEventsProcess
	{

		public CampaignTargetEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

