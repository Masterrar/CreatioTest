﻿namespace Terrasoft.Configuration
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

	#region Class: Activity_Opportunity_TerrasoftSchema

	/// <exclude/>
	public class Activity_Opportunity_TerrasoftSchema : Terrasoft.Configuration.Activity_Invoice_TerrasoftSchema
	{

		#region Constructors: Public

		public Activity_Opportunity_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public Activity_Opportunity_TerrasoftSchema(Activity_Opportunity_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public Activity_Opportunity_TerrasoftSchema(Activity_Opportunity_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private EntitySchemaIndex CreateIX_Activity_SendDateIndex() {
			EntitySchemaIndex index = new EntitySchemaIndex() {
				IsAutoName = true,
				IsClustered = false,
				IsUnique = false
			};
			index.UId = new Guid("1e60c588-1264-4219-9f83-2a3e68bc54b6");
			index.Name = "IX_Activity_SendDate";
			index.CreatedInSchemaUId = new Guid("8a8f2187-7621-4d4b-904d-af660770442d");
			index.ModifiedInSchemaUId = new Guid("8a8f2187-7621-4d4b-904d-af660770442d");
			index.CreatedInPackageId = new Guid("d931fb95-07c0-4237-ab9a-64ecf34e5aed");
			EntitySchemaIndexColumn sendDateIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("b8f4292f-5ae6-43ca-9685-1301b31eba68"),
				ColumnUId = new Guid("6689a019-c904-4b25-a89d-d17f3f3767cc"),
				CreatedInSchemaUId = new Guid("8a8f2187-7621-4d4b-904d-af660770442d"),
				ModifiedInSchemaUId = new Guid("8a8f2187-7621-4d4b-904d-af660770442d"),
				CreatedInPackageId = new Guid("d931fb95-07c0-4237-ab9a-64ecf34e5aed"),
				OrderDirection = OrderDirectionStrict.Descending
			};
			index.Columns.Add(sendDateIndexColumn);
			return index;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("0478dd72-505e-45f5-ae36-5a51b63fd506");
			Name = "Activity_Opportunity_Terrasoft";
			ParentSchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89");
			ExtendParent = true;
			CreatedInPackageId = new Guid("14699c41-c4ed-4648-aec6-9ebffd3fcee6");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("4684d4ba-4b6b-4d1a-93fb-70ec2afed57f")) == null) {
				Columns.Add(CreateOpportunityColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateOpportunityColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("4684d4ba-4b6b-4d1a-93fb-70ec2afed57f"),
				Name = @"Opportunity",
				ReferenceSchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("0478dd72-505e-45f5-ae36-5a51b63fd506"),
				ModifiedInSchemaUId = new Guid("0478dd72-505e-45f5-ae36-5a51b63fd506"),
				CreatedInPackageId = new Guid("14699c41-c4ed-4648-aec6-9ebffd3fcee6")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeIndexes() {
			base.InitializeIndexes();
			Indexes.Add(CreateIX_Activity_SendDateIndex());
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateActivity_Opportunity_TerrasoftEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateActivity_Opportunity_TerrasoftEventsProcessSchema() {
			var schema = new Activity_Opportunity_TerrasoftEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new Activity_Opportunity_Terrasoft(userConnection){Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new Activity_OpportunityEventsProcess(userConnnection);
		}

		public override object Clone() {
			return new Activity_Opportunity_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new Activity_Opportunity_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("0478dd72-505e-45f5-ae36-5a51b63fd506"));
		}

		#endregion

	}

	#endregion

	#region Class: Activity_Opportunity_Terrasoft

	/// <summary>
	/// Activity.
	/// </summary>
	public class Activity_Opportunity_Terrasoft : Terrasoft.Configuration.Activity_Invoice_Terrasoft
	{

		#region Constructors: Public

		public Activity_Opportunity_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Activity_Opportunity_Terrasoft";
		}

		public Activity_Opportunity_Terrasoft(Activity_Opportunity_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public  Guid OpportunityId {
			get {
				return GetTypedColumnValue<Guid>("OpportunityId");
			}
			set {
				SetColumnValue("OpportunityId", value);
				_opportunity = null;
			}
		}

		/// <exclude/>
		public  string OpportunityTitle {
			get {
				return GetTypedColumnValue<string>("OpportunityTitle");
			}
			set {
				SetColumnValue("OpportunityTitle", value);
				if (_opportunity != null) {
					_opportunity.Title = value;
				}
			}
		}

		private Opportunity _opportunity;
		/// <summary>
		/// Opportunity.
		/// </summary>
		public  Opportunity Opportunity {
			get {
				return _opportunity ??
					(_opportunity = LookupColumnEntities.GetEntity("Opportunity") as Opportunity);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new Activity_OpportunityEventsProcess(UserConnection);
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
			return new Activity_Opportunity_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: Activity_OpportunityEventsProcess

	/// <exclude/>
	public class Activity_OpportunityEventsProcess<TEntity> : Terrasoft.Configuration.Activity_InvoiceEventsProcess<TEntity> where TEntity : Activity_Opportunity_Terrasoft
	{

		public Activity_OpportunityEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Activity_OpportunityEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private  Guid InternalSchemaUId {
			get {
				return new Guid("0478dd72-505e-45f5-ae36-5a51b63fd506");
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

		public override bool DoCollectEmailParticipants() {
			return Entity.GetTypedColumnValue<Guid>("TypeId") == Terrasoft.Configuration.ActivityConsts.EmailTypeUId
			|| Entity.GetTypedColumnValue<Guid>("ActivityCategoryId") == ExchangeConsts.ActivityMeetingCategoryId;
		}

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

	#region Class: Activity_OpportunityEventsProcess

	/// <exclude/>
	public class Activity_OpportunityEventsProcess : Activity_OpportunityEventsProcess<Activity_Opportunity_Terrasoft>
	{

		public Activity_OpportunityEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: Activity_Opportunity_TerrasoftEventsProcessSchema

	/// <exclude/>
	public class Activity_Opportunity_TerrasoftEventsProcessSchema : Terrasoft.Configuration.Activity_Invoice_TerrasoftEventsProcessSchema
	{

		#region Constructors: Public

		public Activity_Opportunity_TerrasoftEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public Activity_Opportunity_TerrasoftEventsProcessSchema(Activity_Opportunity_TerrasoftEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "Activity_OpportunityEventsProcess";
			UId = new Guid("598a61a2-e86d-4cf8-967f-fdd60abb6c73");
			CreatedInPackageId = new Guid("14699c41-c4ed-4648-aec6-9ebffd3fcee6");
			CreatedInSchemaUId = Guid.Empty;
			CreatedInVersion = @"0.0.0.0";
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("1e6b597a-7314-4042-bb1d-ab0ec5a9b9fd");
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

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("f83cbea2-10c5-4739-96f1-116937efce77"),
				Name = "Terrasoft.Core.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("14699c41-c4ed-4648-aec6-9ebffd3fcee6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("19024591-23ea-4b03-9800-93149198129b"),
				Name = "Terrasoft.Core.DB",
				Alias = "",
				CreatedInPackageId = new Guid("14699c41-c4ed-4648-aec6-9ebffd3fcee6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("fb7b81ba-7c3c-45a5-ae9e-c6c03dceb812"),
				Name = "Terrasoft.UI.WebControls.Controls",
				Alias = "",
				CreatedInPackageId = new Guid("14699c41-c4ed-4648-aec6-9ebffd3fcee6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("cde525cf-d220-4d2a-b963-e55254c639fc"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("14699c41-c4ed-4648-aec6-9ebffd3fcee6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7821de68-c82b-4917-a6cd-add2adfbe400"),
				Name = "Terrasoft.Common",
				Alias = "",
				CreatedInPackageId = new Guid("14699c41-c4ed-4648-aec6-9ebffd3fcee6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d67de76f-9cbc-4bfc-babb-6f65cb89b973"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("14699c41-c4ed-4648-aec6-9ebffd3fcee6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("74160d3b-65e3-4694-b554-089f2d980e54"),
				Name = "Newtonsoft.Json",
				Alias = "",
				CreatedInPackageId = new Guid("14699c41-c4ed-4648-aec6-9ebffd3fcee6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e401300a-9f16-40c2-9788-cf310ae9d1c5"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("14699c41-c4ed-4648-aec6-9ebffd3fcee6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("ca241c6a-6bd2-4e33-ae26-164063bfb504"),
				Name = "System.Text",
				Alias = "",
				CreatedInPackageId = new Guid("14699c41-c4ed-4648-aec6-9ebffd3fcee6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("ed374225-e41d-4643-8234-a4c89997d648"),
				Name = "System.Linq",
				Alias = "",
				CreatedInPackageId = new Guid("14699c41-c4ed-4648-aec6-9ebffd3fcee6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("49a41b26-e223-4e0d-a40a-f81877cefa7a"),
				Name = "Terrasoft.Core.Store",
				Alias = "",
				CreatedInPackageId = new Guid("14699c41-c4ed-4648-aec6-9ebffd3fcee6")
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

		protected override SchemaMethod CreateDoCollectEmailParticipantsMethod() {
			SchemaMethod method = base.CreateDoCollectEmailParticipantsMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,141,65,10,194,48,16,69,247,158,162,116,165,155,92,64,43,72,9,165,11,119,213,125,104,166,113,32,157,148,201,68,12,244,240,182,96,117,235,246,241,254,251,12,146,152,10,77,130,146,85,3,210,229,9,108,29,124,26,233,110,124,130,83,147,208,158,247,229,202,91,91,30,138,170,42,58,96,54,49,12,162,234,64,3,186,196,70,48,144,186,244,130,207,165,179,208,40,81,233,209,160,95,119,183,214,238,230,249,143,147,111,192,8,184,192,121,59,212,175,254,97,200,193,39,188,105,87,0,65,114,63,251,248,6,84,176,58,212,207,0,0,0 };
			return method;
		}

		protected override SchemaMethod CreatePrepereSynchronizeSubjectRemindingUserTaskMethod() {
			SchemaMethod method = base.CreatePrepereSynchronizeSubjectRemindingUserTaskMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,146,205,110,194,48,16,132,207,225,41,172,156,140,100,113,232,181,128,68,3,84,72,21,66,37,112,119,146,133,186,36,222,200,63,109,83,148,119,175,157,164,37,160,74,85,79,113,236,157,217,111,214,78,184,134,209,70,65,9,10,182,149,76,95,20,74,241,9,91,155,188,66,106,158,161,16,50,19,242,184,211,160,98,174,79,212,118,11,70,82,148,134,167,134,17,213,20,197,162,0,70,220,134,120,115,95,141,86,165,48,188,31,36,136,57,17,122,9,220,88,5,11,201,147,28,50,50,33,221,198,206,136,92,24,1,122,244,8,102,117,83,70,125,215,8,165,116,36,2,37,35,225,26,141,56,136,148,251,223,253,93,232,252,197,129,208,91,251,33,57,15,130,213,15,123,12,31,102,137,170,0,69,204,101,57,33,81,206,181,94,58,98,84,149,111,63,158,121,120,97,170,95,148,83,58,8,2,9,239,196,225,104,163,172,23,205,212,209,22,32,13,13,237,21,103,200,200,53,248,208,113,6,78,229,28,221,128,82,180,210,172,121,1,14,193,117,125,66,60,217,114,46,116,153,243,42,194,220,22,114,207,115,11,116,33,141,99,113,161,103,173,36,236,185,116,179,255,143,75,212,74,250,46,238,36,247,250,182,198,143,32,174,74,200,122,242,113,91,57,165,97,236,107,27,241,247,11,24,117,111,36,226,165,15,233,124,46,211,245,94,15,152,85,212,143,108,46,154,41,112,85,117,118,140,96,163,156,250,123,10,206,223,1,125,154,144,245,39,84,179,230,60,186,164,13,89,63,123,119,222,178,177,54,79,61,8,234,43,204,13,150,182,140,187,168,215,136,205,238,31,140,212,223,94,253,5,167,166,64,242,39,3,0,0 };
			return method;
		}

		protected override SchemaMethod CreateOnActivitySavedMethod() {
			SchemaMethod method = base.CreateOnActivitySavedMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,174,204,75,206,40,202,207,203,172,74,13,72,44,42,201,76,206,44,72,204,43,41,214,208,180,230,229,42,74,45,41,45,202,83,72,74,44,78,213,243,207,115,76,46,201,44,203,44,169,12,78,44,75,77,209,72,206,207,43,73,173,40,209,180,6,0,38,93,6,70,65,0,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new Activity_Opportunity_TerrasoftEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("598a61a2-e86d-4cf8-967f-fdd60abb6c73"));
		}

		#endregion

	}

	#endregion

}

