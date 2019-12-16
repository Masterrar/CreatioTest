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
	using System.Text.RegularExpressions;
	using SystemSettings = Terrasoft.Core.Configuration.SysSettings;
	using Terrasoft.Common;
	using Terrasoft.Common.Json;
	using Terrasoft.Configuration.Packages.Case;
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

	#region Class: Activity_Portal_TerrasoftSchema

	/// <exclude/>
	public class Activity_Portal_TerrasoftSchema : Terrasoft.Configuration.Activity_OperatorSingleWindow_TerrasoftSchema
	{

		#region Constructors: Public

		public Activity_Portal_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public Activity_Portal_TerrasoftSchema(Activity_Portal_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public Activity_Portal_TerrasoftSchema(Activity_Portal_TerrasoftSchema source)
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
			RealUId = new Guid("952da2bb-c1f6-4185-bf54-3d20c36ba072");
			Name = "Activity_Portal_Terrasoft";
			ParentSchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89");
			ExtendParent = true;
			CreatedInPackageId = new Guid("eac080e5-c7e6-4027-928f-bde13f5a1451");
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

		protected override void InitializeIndexes() {
			base.InitializeIndexes();
			Indexes.Add(CreateIX_Activity_SendDateIndex());
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateActivity_Portal_TerrasoftEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateActivity_Portal_TerrasoftEventsProcessSchema() {
			var schema = new Activity_Portal_TerrasoftEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new Activity_Portal_Terrasoft(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new Activity_PortalEventsProcess(userConnection);
		}

		public override object Clone() {
			return new Activity_Portal_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new Activity_Portal_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("952da2bb-c1f6-4185-bf54-3d20c36ba072"));
		}

		#endregion

	}

	#endregion

	#region Class: Activity_Portal_Terrasoft

	/// <summary>
	/// Activity.
	/// </summary>
	public class Activity_Portal_Terrasoft : Terrasoft.Configuration.Activity_OperatorSingleWindow_Terrasoft
	{

		#region Constructors: Public

		public Activity_Portal_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Activity_Portal_Terrasoft";
		}

		public Activity_Portal_Terrasoft(Activity_Portal_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new Activity_PortalEventsProcess(UserConnection);
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
			return new Activity_Portal_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: Activity_PortalEventsProcess

	/// <exclude/>
	public class Activity_PortalEventsProcess<TEntity> : Terrasoft.Configuration.Activity_OperatorSingleWindowEventsProcess<TEntity> where TEntity : Activity_Portal_Terrasoft
	{

		public Activity_PortalEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Activity_PortalEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("952da2bb-c1f6-4185-bf54-3d20c36ba072");
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

		public override void NotifyListeners() {
			base.NotifyListeners();
			bool isNeedShowEmail = Entity.GetTypedColumnValue<Guid>("CaseId") != Guid.Empty
							&& Entity.GetTypedColumnValue<DateTime>("SendDate") != default(DateTime)
							&& !Entity.GetTypedColumnValue<bool>("IsAutoSubmitted")
							&& Entity.UserConnection.GetIsFeatureEnabled("ShowEmailOnPortalByCaseContact")
							&& IsUniquePortalEmailMessage(Entity);
			if (isNeedShowEmail) {
				PortalEmailMessageUtilities.ShowOnPortal(Entity);
			}
		}

		public virtual bool IsUniquePortalEmailMessage(Entity activity) {
			var select = new Select(activity.UserConnection)
							.Column(Func.Count("PortalEmailMessage", "Id"))
							.From("PortalEmailMessage")
							.Join(JoinType.Inner, "CaseMessageHistory")
								.On("PortalEmailMessage", "CaseMessageHistoryId")
								.IsEqual("CaseMessageHistory", "Id")
							.Where("CaseMessageHistory", "RecordId")
								.IsEqual(Column.Parameter(activity.PrimaryColumnValue)) as Select;
						var count = select.ExecuteScalar<int>();
						return count == 0;
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

	#region Class: Activity_PortalEventsProcess

	/// <exclude/>
	public class Activity_PortalEventsProcess : Activity_PortalEventsProcess<Activity_Portal_Terrasoft>
	{

		public Activity_PortalEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: Activity_Portal_TerrasoftEventsProcessSchema

	/// <exclude/>
	public class Activity_Portal_TerrasoftEventsProcessSchema : Terrasoft.Configuration.Activity_OperatorSingleWindow_TerrasoftEventsProcessSchema
	{

		#region Constructors: Public

		public Activity_Portal_TerrasoftEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public Activity_Portal_TerrasoftEventsProcessSchema(Activity_Portal_TerrasoftEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "Activity_PortalEventsProcess";
			UId = new Guid("38732d9b-faf5-446d-80a2-940ab5b1cc54");
			CreatedInPackageId = new Guid("eac080e5-c7e6-4027-928f-bde13f5a1451");
			CreatedInSchemaUId = Guid.Empty;
			CreatedInVersion = @"0.0.0.0";
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("331a6b10-aa63-4689-8fe0-695a1d2c6e27");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet4_1c99799fd06e41ebb2eb5f27c198064c = CreateLaneSet4_1c99799fd06e41ebb2eb5f27c198064cLaneSet();
			LaneSets.Add(schemaLaneSet4_1c99799fd06e41ebb2eb5f27c198064c);
			ProcessSchemaLane schemaLane5_b4f70d334d1c4436b6051307dc248f3b = CreateLane5_b4f70d334d1c4436b6051307dc248f3bLane();
			schemaLaneSet4_1c99799fd06e41ebb2eb5f27c198064c.Lanes.Add(schemaLane5_b4f70d334d1c4436b6051307dc248f3b);
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet4_1c99799fd06e41ebb2eb5f27c198064cLaneSet() {
			ProcessSchemaLaneSet schemaLaneSet4_1c99799fd06e41ebb2eb5f27c198064c = new ProcessSchemaLaneSet(this) {
				UId = new Guid("1c99799f-d06e-41eb-b2eb-5f27c198064c"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("331a6b10-aa63-4689-8fe0-695a1d2c6e27"),
				CreatedInPackageId = new Guid("eac080e5-c7e6-4027-928f-bde13f5a1451"),
				CreatedInSchemaUId = new Guid("38732d9b-faf5-446d-80a2-940ab5b1cc54"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("38732d9b-faf5-446d-80a2-940ab5b1cc54"),
				Name = @"LaneSet4_1c99799fd06e41ebb2eb5f27c198064c",
				Position = new Point(0, 5),
				Size = new Size(0, 400),
				UseBackgroundMode = false
			};
			return schemaLaneSet4_1c99799fd06e41ebb2eb5f27c198064c;
		}

		protected virtual ProcessSchemaLane CreateLane5_b4f70d334d1c4436b6051307dc248f3bLane() {
			ProcessSchemaLane schemaLane5_b4f70d334d1c4436b6051307dc248f3b = new ProcessSchemaLane(this) {
				UId = new Guid("b4f70d33-4d1c-4436-b605-1307dc248f3b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1c99799f-d06e-41eb-b2eb-5f27c198064c"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("eac080e5-c7e6-4027-928f-bde13f5a1451"),
				CreatedInSchemaUId = new Guid("38732d9b-faf5-446d-80a2-940ab5b1cc54"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("38732d9b-faf5-446d-80a2-940ab5b1cc54"),
				Name = @"Lane5_b4f70d334d1c4436b6051307dc248f3b",
				Position = new Point(0, 0),
				Size = new Size(700, 400),
				UseBackgroundMode = false
			};
			return schemaLane5_b4f70d334d1c4436b6051307dc248f3b;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateIsUniquePortalEmailMessageMethod());
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("f83cbea2-10c5-4739-96f1-116937efce77"),
				Name = "Terrasoft.Core.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("ffa69c6a-c8bb-4a61-bc00-b0bcd40a9862")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("19024591-23ea-4b03-9800-93149198129b"),
				Name = "Terrasoft.Core.DB",
				Alias = "",
				CreatedInPackageId = new Guid("ffa69c6a-c8bb-4a61-bc00-b0bcd40a9862")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("fb7b81ba-7c3c-45a5-ae9e-c6c03dceb812"),
				Name = "Terrasoft.UI.WebControls.Controls",
				Alias = "",
				CreatedInPackageId = new Guid("ffa69c6a-c8bb-4a61-bc00-b0bcd40a9862")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("cde525cf-d220-4d2a-b963-e55254c639fc"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("ffa69c6a-c8bb-4a61-bc00-b0bcd40a9862")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7821de68-c82b-4917-a6cd-add2adfbe400"),
				Name = "Terrasoft.Common",
				Alias = "",
				CreatedInPackageId = new Guid("ffa69c6a-c8bb-4a61-bc00-b0bcd40a9862")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d67de76f-9cbc-4bfc-babb-6f65cb89b973"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("ffa69c6a-c8bb-4a61-bc00-b0bcd40a9862")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("74160d3b-65e3-4694-b554-089f2d980e54"),
				Name = "Newtonsoft.Json",
				Alias = "",
				CreatedInPackageId = new Guid("ffa69c6a-c8bb-4a61-bc00-b0bcd40a9862")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e401300a-9f16-40c2-9788-cf310ae9d1c5"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("ffa69c6a-c8bb-4a61-bc00-b0bcd40a9862")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("ca241c6a-6bd2-4e33-ae26-164063bfb504"),
				Name = "System.Text",
				Alias = "",
				CreatedInPackageId = new Guid("ffa69c6a-c8bb-4a61-bc00-b0bcd40a9862")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("ed374225-e41d-4643-8234-a4c89997d648"),
				Name = "System.Linq",
				Alias = "",
				CreatedInPackageId = new Guid("ffa69c6a-c8bb-4a61-bc00-b0bcd40a9862")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("49a41b26-e223-4e0d-a40a-f81877cefa7a"),
				Name = "Terrasoft.Core.Store",
				Alias = "",
				CreatedInPackageId = new Guid("ffa69c6a-c8bb-4a61-bc00-b0bcd40a9862")
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
			Usings.Add(new SchemaUsing() {
				UId = new Guid("aca2294b-e209-4c40-9400-0d59d9ecd1ea"),
				Name = "Terrasoft.GlobalSearch.Indexing",
				Alias = "",
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d0e41fbb-a508-42f2-a460-48f0b41ed535"),
				Name = "Terrasoft.Configuration.Packages.Case",
				Alias = "",
				CreatedInPackageId = new Guid("33bac096-c819-4c57-86af-fe71bbb0cb56")
			});
		}

		protected override SchemaMethod CreateNotifyListenersMethod() {
			SchemaMethod method = base.CreateNotifyListenersMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,144,65,75,195,64,16,133,207,205,175,216,246,80,146,75,254,128,86,208,52,150,128,86,33,141,247,77,247,69,7,54,187,53,59,139,4,241,191,187,107,8,133,10,157,219,12,239,125,243,102,90,233,144,239,45,83,55,62,145,99,24,12,46,205,110,146,214,90,45,200,237,1,85,127,216,175,178,151,164,197,70,148,134,137,199,124,7,62,140,39,168,194,106,223,155,55,169,61,110,119,158,212,93,186,42,2,176,82,171,76,44,55,34,142,242,178,63,241,152,44,66,173,215,215,252,91,201,56,80,143,192,168,97,84,108,39,138,66,39,189,230,116,22,100,51,108,121,133,22,243,7,82,229,238,61,219,218,183,61,49,35,196,186,8,210,56,12,133,53,6,71,38,107,34,169,114,143,144,236,7,148,70,182,26,42,164,153,239,127,49,175,118,96,169,31,198,120,100,176,177,60,242,25,89,185,198,208,167,199,36,250,115,60,195,57,249,142,116,218,22,222,74,157,72,47,190,154,137,239,100,241,223,211,48,105,98,130,203,163,114,94,125,38,253,252,2,178,102,163,2,186,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateIsUniquePortalEmailMessageMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("88573c2e-2b6f-440d-954f-e14d9175e29c"),
				Name = "IsUniquePortalEmailMessage",
				CreatedInSchemaUId = new Guid("38732d9b-faf5-446d-80a2-940ab5b1cc54"),
				CreatedInPackageId = new Guid("eac080e5-c7e6-4027-928f-bde13f5a1451"),
				ResultValueTypeName = "bool"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("85cf9dd8-eb66-4fcd-85fe-87510e1d5226"),
				Name = "activity",
				CreatedInSchemaUId = new Guid("38732d9b-faf5-446d-80a2-940ab5b1cc54"),
				ModifiedInSchemaUId = new Guid("38732d9b-faf5-446d-80a2-940ab5b1cc54"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Entity",
				CreatedInPackageId = new Guid("eac080e5-c7e6-4027-928f-bde13f5a1451")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,117,145,77,75,196,48,16,134,207,235,175,8,61,37,32,193,251,186,94,74,23,43,136,197,245,227,60,100,7,13,36,19,157,36,213,254,123,211,109,196,131,221,28,66,62,158,247,157,225,157,17,88,68,116,104,146,216,9,194,47,113,56,93,36,152,100,71,155,38,253,28,145,219,64,84,30,109,32,117,177,41,75,183,193,101,79,114,159,201,148,115,166,36,155,33,112,2,215,121,176,238,30,99,132,55,108,46,69,211,31,27,85,53,123,14,126,21,171,255,119,193,146,156,183,167,233,3,117,95,42,114,49,104,33,98,5,111,109,76,129,167,202,111,244,3,157,171,250,95,52,247,81,101,125,236,62,51,56,185,102,93,59,94,26,122,125,71,198,115,216,35,154,192,199,21,219,37,26,61,0,131,199,132,252,151,228,192,214,3,79,11,240,2,46,163,82,2,98,77,124,59,251,140,101,26,102,206,179,12,99,153,138,238,190,209,228,132,7,3,14,248,218,82,186,145,234,196,50,166,204,244,139,239,196,213,246,7,106,176,60,139,204,1,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new Activity_Portal_TerrasoftEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("38732d9b-faf5-446d-80a2-940ab5b1cc54"));
		}

		#endregion

	}

	#endregion

}

