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
	using System.Text.RegularExpressions;
	using SystemSettings = Terrasoft.Core.Configuration.SysSettings;
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

	#region Class: Activity_Change_TerrasoftSchema

	/// <exclude/>
	public class Activity_Change_TerrasoftSchema : Terrasoft.Configuration.Activity_Problem_TerrasoftSchema
	{

		#region Constructors: Public

		public Activity_Change_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public Activity_Change_TerrasoftSchema(Activity_Change_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public Activity_Change_TerrasoftSchema(Activity_Change_TerrasoftSchema source)
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
			RealUId = new Guid("b16aedee-7629-4b9c-815f-d59f0f5f1e56");
			Name = "Activity_Change_Terrasoft";
			ParentSchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89");
			ExtendParent = true;
			CreatedInPackageId = new Guid("2496861e-1f72-4434-ab9e-c42503decf6d");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("555043b5-fac8-41b9-9bb2-3703acb0f447")) == null) {
				Columns.Add(CreateChangeColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateChangeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("555043b5-fac8-41b9-9bb2-3703acb0f447"),
				Name = @"Change",
				ReferenceSchemaUId = new Guid("de5c8d59-d372-407d-8c09-f0523e057e40"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("b16aedee-7629-4b9c-815f-d59f0f5f1e56"),
				ModifiedInSchemaUId = new Guid("b16aedee-7629-4b9c-815f-d59f0f5f1e56"),
				CreatedInPackageId = new Guid("2496861e-1f72-4434-ab9e-c42503decf6d")
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
			EventsProcessSchema = CreateActivity_Change_TerrasoftEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateActivity_Change_TerrasoftEventsProcessSchema() {
			var schema = new Activity_Change_TerrasoftEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new Activity_Change_Terrasoft(userConnection){Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new Activity_ChangeEventsProcess(userConnnection);
		}

		public override object Clone() {
			return new Activity_Change_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new Activity_Change_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b16aedee-7629-4b9c-815f-d59f0f5f1e56"));
		}

		#endregion

	}

	#endregion

	#region Class: Activity_Change_Terrasoft

	/// <summary>
	/// Activity.
	/// </summary>
	public class Activity_Change_Terrasoft : Terrasoft.Configuration.Activity_Problem_Terrasoft
	{

		#region Constructors: Public

		public Activity_Change_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Activity_Change_Terrasoft";
		}

		public Activity_Change_Terrasoft(Activity_Change_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public  Guid ChangeId {
			get {
				return GetTypedColumnValue<Guid>("ChangeId");
			}
			set {
				SetColumnValue("ChangeId", value);
				_change = null;
			}
		}

		/// <exclude/>
		public  string ChangeNumber {
			get {
				return GetTypedColumnValue<string>("ChangeNumber");
			}
			set {
				SetColumnValue("ChangeNumber", value);
				if (_change != null) {
					_change.Number = value;
				}
			}
		}

		private Change _change;
		/// <summary>
		/// Change.
		/// </summary>
		public  Change Change {
			get {
				return _change ??
					(_change = LookupColumnEntities.GetEntity("Change") as Change);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new Activity_ChangeEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Updated += (s, e) => ThrowEvent("Activity_Change_TerrasoftUpdated", e);
			Updating += (s, e) => ThrowEvent("Activity_Change_TerrasoftUpdating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new Activity_Change_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: Activity_ChangeEventsProcess

	/// <exclude/>
	public class Activity_ChangeEventsProcess<TEntity> : Terrasoft.Configuration.Activity_ProblemEventsProcess<TEntity> where TEntity : Activity_Change_Terrasoft
	{

		public Activity_ChangeEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Activity_ChangeEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private  Guid InternalSchemaUId {
			get {
				return new Guid("b16aedee-7629-4b9c-815f-d59f0f5f1e56");
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

		public override bool OnActivitySaving(ProcessExecutingContext context) {
			return base.OnActivitySaving(context);
		}

		public override void LocalMessageExecuting(EntityChangeType changeType) {
			var lmHelper = new Terrasoft.Configuration.LocalMessageHelper(this.Entity, UserConnection, changeType);
			lmHelper.CreateLocalMessage();
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

	#region Class: Activity_ChangeEventsProcess

	/// <exclude/>
	public class Activity_ChangeEventsProcess : Activity_ChangeEventsProcess<Activity_Change_Terrasoft>
	{

		public Activity_ChangeEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: Activity_Change_TerrasoftEventsProcessSchema

	/// <exclude/>
	public class Activity_Change_TerrasoftEventsProcessSchema : Terrasoft.Configuration.Activity_Problem_TerrasoftEventsProcessSchema
	{

		#region Constructors: Public

		public Activity_Change_TerrasoftEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public Activity_Change_TerrasoftEventsProcessSchema(Activity_Change_TerrasoftEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "Activity_ChangeEventsProcess";
			UId = new Guid("b9f1c003-5431-4562-8444-77d42102c3a7");
			CreatedInPackageId = new Guid("2496861e-1f72-4434-ab9e-c42503decf6d");
			CreatedInSchemaUId = Guid.Empty;
			CreatedInVersion = @"0.0.0.0";
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("f3eebf06-e49c-4795-8233-d57fe88b16b0");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet2 = CreateLaneSet2LaneSet();
			LaneSets.Add(schemaLaneSet2);
			ProcessSchemaLane schemaLane3 = CreateLane3Lane();
			schemaLaneSet2.Lanes.Add(schemaLane3);
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet2LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet2 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("11a42e54-0d5c-44d4-80bf-a22dd88cf782"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("4b1ec56d-c726-428c-9282-48075c275922"),
				CreatedInPackageId = new Guid("717610d4-7765-4b8f-9632-2b1f76214cb5"),
				CreatedInSchemaUId = new Guid("b9f1c003-5431-4562-8444-77d42102c3a7"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("b9f1c003-5431-4562-8444-77d42102c3a7"),
				Name = @"LaneSet2",
				Position = new Point(0, 0),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaLaneSet2;
		}

		protected virtual ProcessSchemaLane CreateLane3Lane() {
			ProcessSchemaLane schemaLane3 = new ProcessSchemaLane(this) {
				UId = new Guid("dd5aac66-1b84-4d47-9fb5-77392c74fdb3"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("11a42e54-0d5c-44d4-80bf-a22dd88cf782"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("717610d4-7765-4b8f-9632-2b1f76214cb5"),
				CreatedInSchemaUId = new Guid("b9f1c003-5431-4562-8444-77d42102c3a7"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("b9f1c003-5431-4562-8444-77d42102c3a7"),
				Name = @"Lane3",
				Position = new Point(0, 0),
				Size = new Size(700, 400),
				UseBackgroundMode = false
			};
			return schemaLane3;
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
				CreatedInPackageId = new Guid("2496861e-1f72-4434-ab9e-c42503decf6d")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("19024591-23ea-4b03-9800-93149198129b"),
				Name = "Terrasoft.Core.DB",
				Alias = "",
				CreatedInPackageId = new Guid("2496861e-1f72-4434-ab9e-c42503decf6d")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("fb7b81ba-7c3c-45a5-ae9e-c6c03dceb812"),
				Name = "Terrasoft.UI.WebControls.Controls",
				Alias = "",
				CreatedInPackageId = new Guid("2496861e-1f72-4434-ab9e-c42503decf6d")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("cde525cf-d220-4d2a-b963-e55254c639fc"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("2496861e-1f72-4434-ab9e-c42503decf6d")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7821de68-c82b-4917-a6cd-add2adfbe400"),
				Name = "Terrasoft.Common",
				Alias = "",
				CreatedInPackageId = new Guid("2496861e-1f72-4434-ab9e-c42503decf6d")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d67de76f-9cbc-4bfc-babb-6f65cb89b973"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("2496861e-1f72-4434-ab9e-c42503decf6d")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("74160d3b-65e3-4694-b554-089f2d980e54"),
				Name = "Newtonsoft.Json",
				Alias = "",
				CreatedInPackageId = new Guid("2496861e-1f72-4434-ab9e-c42503decf6d")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e401300a-9f16-40c2-9788-cf310ae9d1c5"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("2496861e-1f72-4434-ab9e-c42503decf6d")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("ca241c6a-6bd2-4e33-ae26-164063bfb504"),
				Name = "System.Text",
				Alias = "",
				CreatedInPackageId = new Guid("2496861e-1f72-4434-ab9e-c42503decf6d")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("ed374225-e41d-4643-8234-a4c89997d648"),
				Name = "System.Linq",
				Alias = "",
				CreatedInPackageId = new Guid("2496861e-1f72-4434-ab9e-c42503decf6d")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("49a41b26-e223-4e0d-a40a-f81877cefa7a"),
				Name = "Terrasoft.Core.Store",
				Alias = "",
				CreatedInPackageId = new Guid("2496861e-1f72-4434-ab9e-c42503decf6d")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("f1009d8d-2421-44b9-aae4-a6159b28fc60"),
				Name = "System.Text.RegularExpressions",
				Alias = "",
				CreatedInPackageId = new Guid("30de0e3b-0a22-4b21-aec2-eb5dee3a342f")
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
				UId = new Guid("44c2ca34-4641-4249-93e0-e11c641583b8"),
				Name = "Terrasoft.Core.Configuration.SysSettings",
				Alias = "SystemSettings",
				CreatedInPackageId = new Guid("77fa8847-960e-4748-ad77-e37bb90e03a0")
			});
		}

		protected override SchemaMethod CreatePrepereSynchronizeSubjectRemindingUserTaskMethod() {
			SchemaMethod method = base.CreatePrepereSynchronizeSubjectRemindingUserTaskMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,146,205,110,194,48,16,132,207,225,41,172,156,140,100,113,232,181,128,68,3,84,72,21,66,37,112,119,146,133,186,36,222,200,63,109,83,148,119,175,157,164,37,160,74,85,79,113,236,157,217,111,214,78,184,134,209,70,65,9,10,182,149,76,95,20,74,241,9,91,155,188,66,106,158,161,16,50,19,242,184,211,160,98,174,79,212,118,11,70,82,148,134,167,134,17,213,20,197,162,0,70,220,134,120,115,95,141,86,165,48,188,31,36,136,57,17,122,9,220,88,5,11,201,147,28,50,50,33,221,198,206,136,92,24,1,122,244,8,102,117,83,70,125,215,8,165,116,36,2,37,35,225,26,141,56,136,148,251,223,253,93,232,252,197,129,208,91,251,33,57,15,130,213,15,123,12,31,102,137,170,0,69,204,101,57,33,81,206,181,94,58,98,84,149,111,63,158,121,120,97,170,95,148,83,58,8,2,9,239,196,225,104,163,172,23,205,212,209,22,32,13,13,237,21,103,200,200,53,248,208,113,6,78,229,28,221,128,82,180,210,172,121,1,14,193,117,125,66,60,217,114,46,116,153,243,42,194,220,22,114,207,115,11,116,33,141,99,113,161,103,173,36,236,185,116,179,255,143,75,212,74,250,46,238,36,247,250,182,198,143,32,174,74,200,122,242,113,91,57,165,97,236,107,27,241,247,11,24,117,111,36,226,165,15,233,124,46,211,245,94,15,152,85,212,143,108,46,154,41,112,85,117,118,140,96,163,156,250,123,10,206,223,1,125,154,144,245,39,84,179,230,60,186,164,13,89,63,123,119,222,178,177,54,79,61,8,234,43,204,13,150,182,140,187,168,215,136,205,238,31,140,212,223,94,253,5,167,166,64,242,39,3,0,0 };
			return method;
		}

		protected override SchemaMethod CreateOnActivitySavingMethod() {
			SchemaMethod method = base.CreateOnActivitySavingMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,72,74,44,78,213,243,207,115,76,46,201,44,203,44,169,12,78,44,203,204,75,215,72,206,207,43,73,173,40,209,180,6,0,241,141,15,165,38,0,0,0 };
			return method;
		}

		protected override SchemaMethod CreateLocalMessageExecutingMethod() {
			SchemaMethod method = base.CreateLocalMessageExecutingMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,77,141,75,10,194,48,16,134,247,158,98,150,45,148,92,160,184,42,130,11,221,213,3,12,225,111,26,136,147,50,51,86,122,123,45,69,112,255,61,86,86,42,207,43,202,2,165,51,9,222,52,66,149,173,78,30,134,42,83,78,47,101,207,85,194,173,70,46,119,152,113,194,33,52,62,103,11,23,241,236,91,71,15,131,126,13,65,220,241,142,226,204,146,48,110,11,218,254,244,123,132,65,193,142,255,86,211,246,31,106,54,191,216,134,0,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new Activity_Change_TerrasoftEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b9f1c003-5431-4562-8444-77d42102c3a7"));
		}

		#endregion

	}

	#endregion

}

