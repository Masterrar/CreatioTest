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

	#region Class: Activity_NUI_TerrasoftSchema

	/// <exclude/>
	public class Activity_NUI_TerrasoftSchema : Terrasoft.Configuration.Activity_Base_TerrasoftSchema
	{

		#region Constructors: Public

		public Activity_NUI_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public Activity_NUI_TerrasoftSchema(Activity_NUI_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public Activity_NUI_TerrasoftSchema(Activity_NUI_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("1b116491-abef-40e6-b627-93ff5c45ab7e");
			Name = "Activity_NUI_Terrasoft";
			ParentSchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89");
			ExtendParent = true;
			CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateActivity_NUI_TerrasoftEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateActivity_NUI_TerrasoftEventsProcessSchema() {
			var schema = new Activity_NUI_TerrasoftEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new Activity_NUI_Terrasoft(userConnection){Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new Activity_NUIEventsProcess(userConnnection);
		}

		public override object Clone() {
			return new Activity_NUI_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new Activity_NUI_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("1b116491-abef-40e6-b627-93ff5c45ab7e"));
		}

		#endregion

	}

	#endregion

	#region Class: Activity_NUI_Terrasoft

	/// <summary>
	/// Activity.
	/// </summary>
	public class Activity_NUI_Terrasoft : Terrasoft.Configuration.Activity_Base_Terrasoft
	{

		#region Constructors: Public

		public Activity_NUI_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Activity_NUI_Terrasoft";
		}

		public Activity_NUI_Terrasoft(Activity_NUI_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new Activity_NUIEventsProcess(UserConnection);
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
			return new Activity_NUI_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: Activity_NUIEventsProcess

	/// <exclude/>
	public class Activity_NUIEventsProcess<TEntity> : Terrasoft.Configuration.Activity_BaseEventsProcess<TEntity> where TEntity : Activity_NUI_Terrasoft
	{

		public Activity_NUIEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Activity_NUIEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("1b116491-abef-40e6-b627-93ff5c45ab7e");
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

		public virtual string GetLookupDisplayColumnValue(Entity entity, string lookupName) {
			var rootEntitySchema = entity.Schema;
			var result = string.Empty;
			try {
				var rootEntityColumn = rootEntitySchema.Columns.GetByName(lookupName);
				var recordId = entity.GetTypedColumnValue<Guid>(rootEntityColumn.ColumnValueName);
				result = recordId.IsNotEmpty() 
					? GetFetchedDisplayColumnValue(entity, lookupName, recordId)
					: string.Empty;
			} catch (Exception ex) {
				result = string.Empty;
			}
			return result;
		}

		public virtual string GetFetchedDisplayColumnValue(Entity entity, string lookupName, Guid recordId) {
			var userConnection = entity.UserConnection;
			var lookupEntitySchema = userConnection.EntitySchemaManager.FindInstanceByName(lookupName);
			var lookupEntity = lookupEntitySchema.CreateEntity(userConnection);
			lookupEntity.FetchPrimaryInfoFromDB(lookupEntitySchema.GetPrimaryColumnName(), recordId);
			return lookupEntity.PrimaryDisplayColumnValue;
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

	#region Class: Activity_NUIEventsProcess

	/// <exclude/>
	public class Activity_NUIEventsProcess : Activity_NUIEventsProcess<Activity_NUI_Terrasoft>
	{

		public Activity_NUIEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: Activity_NUI_TerrasoftEventsProcessSchema

	/// <exclude/>
	public class Activity_NUI_TerrasoftEventsProcessSchema : Terrasoft.Configuration.Activity_Base_TerrasoftEventsProcessSchema
	{

		#region Constructors: Public

		public Activity_NUI_TerrasoftEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public Activity_NUI_TerrasoftEventsProcessSchema(Activity_NUI_TerrasoftEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "Activity_NUIEventsProcess";
			UId = new Guid("ae0dbe8a-2abd-4db4-953a-1433786a2a68");
			CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa");
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
			ProcessSchemaLaneSet schemaLaneSet1_d83e88f0a11d48f580aa39b656256203 = CreateLaneSet1_d83e88f0a11d48f580aa39b656256203LaneSet();
			LaneSets.Add(schemaLaneSet1_d83e88f0a11d48f580aa39b656256203);
			ProcessSchemaLane schemaLane3_cc13f5c1982a44989f21d018655afd49 = CreateLane3_cc13f5c1982a44989f21d018655afd49Lane();
			schemaLaneSet1_d83e88f0a11d48f580aa39b656256203.Lanes.Add(schemaLane3_cc13f5c1982a44989f21d018655afd49);
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1_d83e88f0a11d48f580aa39b656256203LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1_d83e88f0a11d48f580aa39b656256203 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("d83e88f0-a11d-48f5-80aa-39b656256203"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("402a0d89-2ee2-4795-9391-05e13257c797"),
				CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa"),
				CreatedInSchemaUId = new Guid("ae0dbe8a-2abd-4db4-953a-1433786a2a68"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("ae0dbe8a-2abd-4db4-953a-1433786a2a68"),
				Name = @"LaneSet1_d83e88f0a11d48f580aa39b656256203",
				Position = new Point(0, 5),
				Size = new Size(0, 400),
				UseBackgroundMode = false
			};
			return schemaLaneSet1_d83e88f0a11d48f580aa39b656256203;
		}

		protected virtual ProcessSchemaLane CreateLane3_cc13f5c1982a44989f21d018655afd49Lane() {
			ProcessSchemaLane schemaLane3_cc13f5c1982a44989f21d018655afd49 = new ProcessSchemaLane(this) {
				UId = new Guid("cc13f5c1-982a-4498-9f21-d018655afd49"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d83e88f0-a11d-48f5-80aa-39b656256203"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa"),
				CreatedInSchemaUId = new Guid("ae0dbe8a-2abd-4db4-953a-1433786a2a68"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("ae0dbe8a-2abd-4db4-953a-1433786a2a68"),
				Name = @"Lane3_cc13f5c1982a44989f21d018655afd49",
				Position = new Point(0, 0),
				Size = new Size(700, 400),
				UseBackgroundMode = false
			};
			return schemaLane3_cc13f5c1982a44989f21d018655afd49;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateGetLookupDisplayColumnValueMethod());
			Methods.Add(CreateGetFetchedDisplayColumnValueMethod());
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
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,146,95,79,194,48,20,197,159,183,79,209,236,129,148,164,225,193,87,129,4,7,24,18,67,136,12,223,203,118,193,202,214,187,244,143,58,9,223,221,118,27,50,212,196,248,180,238,246,158,211,223,185,237,150,107,24,172,20,148,160,96,93,201,244,89,161,20,31,176,182,219,23,72,205,35,20,66,102,66,238,55,26,84,194,245,129,218,118,193,72,138,210,240,212,48,162,234,166,68,20,192,136,43,136,87,247,213,104,85,10,253,219,112,139,152,19,161,231,192,141,85,48,147,124,155,67,70,70,164,45,108,140,200,133,17,160,7,247,96,22,223,218,168,63,53,70,41,29,137,64,201,72,180,68,35,118,34,229,254,247,233,38,114,254,98,71,232,15,251,94,175,5,233,147,99,24,44,190,82,36,240,110,230,168,10,80,196,92,150,35,18,231,92,235,185,147,160,170,60,200,112,226,213,194,84,191,40,199,52,12,2,9,111,196,129,105,163,172,23,77,212,222,22,32,13,141,236,21,113,196,200,117,132,190,35,14,156,202,57,58,194,20,173,52,75,94,128,67,112,167,62,32,30,108,57,21,186,204,121,21,99,110,11,249,196,115,11,116,38,141,99,113,241,39,141,36,234,184,180,183,240,31,151,184,145,116,93,220,78,238,245,77,143,31,65,82,149,144,117,228,195,166,115,76,163,196,247,214,226,243,91,24,180,175,37,230,165,15,233,124,46,211,245,94,119,152,85,212,143,108,42,234,41,112,85,181,118,140,96,173,28,251,123,10,142,231,128,62,77,196,186,19,58,177,122,63,190,164,141,88,55,123,187,223,176,177,38,207,41,12,78,87,152,43,44,109,153,180,81,175,17,235,234,31,140,212,223,222,233,19,120,187,20,90,49,3,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetLookupDisplayColumnValueMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("f0629f97-adb4-4743-bf7e-97318b13bd31"),
				Name = "GetLookupDisplayColumnValue",
				CreatedInSchemaUId = new Guid("ae0dbe8a-2abd-4db4-953a-1433786a2a68"),
				CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa"),
				ResultValueTypeName = "string"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("4dc010b4-9704-49fb-b7e9-1f1a724c3110"),
				Name = "entity",
				CreatedInSchemaUId = new Guid("ae0dbe8a-2abd-4db4-953a-1433786a2a68"),
				ModifiedInSchemaUId = new Guid("ae0dbe8a-2abd-4db4-953a-1433786a2a68"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Entity",
				CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("fc36f0b4-51b7-40d6-b44c-f19821e2d4f5"),
				Name = "lookupName",
				CreatedInSchemaUId = new Guid("ae0dbe8a-2abd-4db4-953a-1433786a2a68"),
				ModifiedInSchemaUId = new Guid("ae0dbe8a-2abd-4db4-953a-1433786a2a68"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,144,207,106,195,48,12,198,207,13,228,29,116,116,160,248,1,214,253,129,109,89,233,165,151,141,221,77,44,54,51,199,54,182,28,106,70,223,125,74,179,166,93,96,55,203,250,244,211,167,111,80,17,162,247,212,58,50,84,94,187,79,236,21,220,1,158,74,57,213,155,186,26,70,25,166,108,137,155,137,162,113,31,178,237,3,21,238,81,44,240,93,87,171,225,15,234,201,219,220,59,86,47,233,114,234,36,185,69,122,44,123,213,163,176,222,127,229,48,62,155,205,25,132,157,143,122,167,47,94,88,254,86,2,234,105,252,93,217,140,183,219,108,244,189,88,46,149,87,146,25,58,187,63,147,229,46,237,121,110,60,66,52,192,138,213,3,240,142,23,36,182,169,159,77,10,86,149,43,146,152,124,172,225,226,118,61,195,154,113,254,102,153,204,17,58,197,52,16,237,161,195,64,198,59,192,67,115,10,235,191,48,143,117,21,145,114,116,191,113,243,215,15,23,113,205,94,163,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetFetchedDisplayColumnValueMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("93298ca5-dd1d-40bf-b651-cf79b7a293eb"),
				Name = "GetFetchedDisplayColumnValue",
				CreatedInSchemaUId = new Guid("ae0dbe8a-2abd-4db4-953a-1433786a2a68"),
				CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa"),
				ResultValueTypeName = "string"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("6aa8fc83-d25a-4a6d-ae83-44bc71c7a1bd"),
				Name = "entity",
				CreatedInSchemaUId = new Guid("ae0dbe8a-2abd-4db4-953a-1433786a2a68"),
				ModifiedInSchemaUId = new Guid("ae0dbe8a-2abd-4db4-953a-1433786a2a68"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Entity",
				CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("2efd5c6b-9b48-470e-bfe5-53fc6f45630d"),
				Name = "lookupName",
				CreatedInSchemaUId = new Guid("ae0dbe8a-2abd-4db4-953a-1433786a2a68"),
				ModifiedInSchemaUId = new Guid("ae0dbe8a-2abd-4db4-953a-1433786a2a68"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("22bf97b3-668a-450a-bf6a-756ade98d17b"),
				Name = "recordId",
				CreatedInSchemaUId = new Guid("ae0dbe8a-2abd-4db4-953a-1433786a2a68"),
				ModifiedInSchemaUId = new Guid("ae0dbe8a-2abd-4db4-953a-1433786a2a68"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,142,193,14,130,48,16,68,239,126,69,143,144,152,254,128,241,2,136,225,160,49,49,122,223,148,85,26,233,150,44,45,9,127,111,5,14,52,120,219,204,206,188,153,1,88,248,30,57,183,68,168,156,182,36,142,2,201,105,55,202,71,164,31,118,67,240,182,214,126,124,119,154,12,119,213,160,129,224,143,1,114,253,189,0,193,27,89,150,154,234,138,122,7,164,48,27,175,96,48,153,81,191,51,221,178,3,117,91,37,115,70,112,56,75,73,220,26,24,235,128,44,209,169,230,198,218,0,143,21,189,108,201,214,20,89,242,7,122,70,183,248,114,219,122,67,211,184,116,47,24,149,229,186,170,3,153,209,121,166,104,145,92,50,133,238,187,22,150,232,19,90,143,135,47,224,132,19,69,84,1,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new Activity_NUI_TerrasoftEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ae0dbe8a-2abd-4db4-953a-1433786a2a68"));
		}

		#endregion

	}

	#endregion

}

