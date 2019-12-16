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

	#region Class: ReleaseSchema

	/// <exclude/>
	public class ReleaseSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public ReleaseSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public ReleaseSchema(ReleaseSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public ReleaseSchema(ReleaseSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("0bf3a274-e5da-4fc7-94c4-3ae233598714");
			RealUId = new Guid("0bf3a274-e5da-4fc7-94c4-3ae233598714");
			Name = "Release";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("6364546f-7b12-440c-84c2-926c09002599");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializePrimaryDisplayColumn() {
			base.InitializePrimaryDisplayColumn();
			PrimaryDisplayColumn = CreateNumberColumn();
			if (Columns.FindByUId(PrimaryDisplayColumn.UId) == null) {
				Columns.Add(PrimaryDisplayColumn);
			}
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("01b5fe20-d534-4f5b-a29c-68919cf82187")) == null) {
				Columns.Add(CreateNameColumn());
			}
			if (Columns.FindByUId(new Guid("2ce63b1d-2436-4cf9-9fa2-1af60486e97c")) == null) {
				Columns.Add(CreateDescriptionColumn());
			}
			if (Columns.FindByUId(new Guid("6e6c9702-4579-44c9-b3e1-3292bcdd76a9")) == null) {
				Columns.Add(CreateScheduledReleaseDateColumn());
			}
			if (Columns.FindByUId(new Guid("848384a8-996a-43d0-8a7c-d4ac370d927d")) == null) {
				Columns.Add(CreatePlannedLaborColumn());
			}
			if (Columns.FindByUId(new Guid("ed1ac00a-35d0-49cf-a98b-c7727a743407")) == null) {
				Columns.Add(CreateReleasedOnColumn());
			}
			if (Columns.FindByUId(new Guid("1351f672-5491-4478-b989-c14ca07fc932")) == null) {
				Columns.Add(CreateDevelopmentFinishedOnColumn());
			}
			if (Columns.FindByUId(new Guid("676954b6-2543-40d6-a7c7-c66a16f30f20")) == null) {
				Columns.Add(CreateTestingFinishedOnColumn());
			}
			if (Columns.FindByUId(new Guid("2593ddf4-7121-451e-8ab3-c7930ae36a16")) == null) {
				Columns.Add(CreateDeploymentFinishedOnColumn());
			}
			if (Columns.FindByUId(new Guid("26913998-0c91-4ec2-8ea7-a5056e318c11")) == null) {
				Columns.Add(CreateActualLaborColumn());
			}
			if (Columns.FindByUId(new Guid("85a73cbf-9bfe-46fa-aeb1-ca38b8071b36")) == null) {
				Columns.Add(CreateActualDevelopmentLaborColumn());
			}
			if (Columns.FindByUId(new Guid("7c4c7e8d-fa44-477c-9f39-64161076afe8")) == null) {
				Columns.Add(CreateActualTestingLaborColumn());
			}
			if (Columns.FindByUId(new Guid("07f0e60b-e26b-492d-bdd3-38fc356a8e15")) == null) {
				Columns.Add(CreateActualDeploymentLaborColumn());
			}
			if (Columns.FindByUId(new Guid("b5bd8c19-aeea-4e9b-893e-a17447e80c13")) == null) {
				Columns.Add(CreateStatusColumn());
			}
			if (Columns.FindByUId(new Guid("2db0a991-0c65-4cde-b77e-de49aa699b69")) == null) {
				Columns.Add(CreateTypeColumn());
			}
			if (Columns.FindByUId(new Guid("6cc600e8-2a43-45a8-9d9e-8c99fbb066d5")) == null) {
				Columns.Add(CreatePriorityColumn());
			}
			if (Columns.FindByUId(new Guid("e2bab1e9-4524-466c-afe8-f154160fbe4f")) == null) {
				Columns.Add(CreateNotesColumn());
			}
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.ModifiedInSchemaUId = new Guid("0bf3a274-e5da-4fc7-94c4-3ae233598714");
			column.CreatedInPackageId = new Guid("6364546f-7b12-440c-84c2-926c09002599");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.ModifiedInSchemaUId = new Guid("0bf3a274-e5da-4fc7-94c4-3ae233598714");
			column.CreatedInPackageId = new Guid("6364546f-7b12-440c-84c2-926c09002599");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.ModifiedInSchemaUId = new Guid("0bf3a274-e5da-4fc7-94c4-3ae233598714");
			column.CreatedInPackageId = new Guid("6364546f-7b12-440c-84c2-926c09002599");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.ModifiedInSchemaUId = new Guid("0bf3a274-e5da-4fc7-94c4-3ae233598714");
			column.CreatedInPackageId = new Guid("6364546f-7b12-440c-84c2-926c09002599");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.ModifiedInSchemaUId = new Guid("0bf3a274-e5da-4fc7-94c4-3ae233598714");
			column.CreatedInPackageId = new Guid("6364546f-7b12-440c-84c2-926c09002599");
			return column;
		}

		protected override EntitySchemaColumn CreateProcessListenersColumn() {
			EntitySchemaColumn column = base.CreateProcessListenersColumn();
			column.ModifiedInSchemaUId = new Guid("0bf3a274-e5da-4fc7-94c4-3ae233598714");
			column.CreatedInPackageId = new Guid("6364546f-7b12-440c-84c2-926c09002599");
			return column;
		}

		protected virtual EntitySchemaColumn CreateNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("01b5fe20-d534-4f5b-a29c-68919cf82187"),
				Name = @"Name",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("0bf3a274-e5da-4fc7-94c4-3ae233598714"),
				ModifiedInSchemaUId = new Guid("0bf3a274-e5da-4fc7-94c4-3ae233598714"),
				CreatedInPackageId = new Guid("6364546f-7b12-440c-84c2-926c09002599")
			};
		}

		protected virtual EntitySchemaColumn CreateNumberColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("cde36d11-02ce-4432-b7f2-d47e6bdd4a5e"),
				Name = @"Number",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("0bf3a274-e5da-4fc7-94c4-3ae233598714"),
				ModifiedInSchemaUId = new Guid("0bf3a274-e5da-4fc7-94c4-3ae233598714"),
				CreatedInPackageId = new Guid("6364546f-7b12-440c-84c2-926c09002599")
			};
		}

		protected virtual EntitySchemaColumn CreateDescriptionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("LongText")) {
				UId = new Guid("2ce63b1d-2436-4cf9-9fa2-1af60486e97c"),
				Name = @"Description",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("0bf3a274-e5da-4fc7-94c4-3ae233598714"),
				ModifiedInSchemaUId = new Guid("0bf3a274-e5da-4fc7-94c4-3ae233598714"),
				CreatedInPackageId = new Guid("6364546f-7b12-440c-84c2-926c09002599")
			};
		}

		protected virtual EntitySchemaColumn CreateScheduledReleaseDateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Date")) {
				UId = new Guid("6e6c9702-4579-44c9-b3e1-3292bcdd76a9"),
				Name = @"ScheduledReleaseDate",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("0bf3a274-e5da-4fc7-94c4-3ae233598714"),
				ModifiedInSchemaUId = new Guid("0bf3a274-e5da-4fc7-94c4-3ae233598714"),
				CreatedInPackageId = new Guid("6364546f-7b12-440c-84c2-926c09002599")
			};
		}

		protected virtual EntitySchemaColumn CreatePlannedLaborColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("848384a8-996a-43d0-8a7c-d4ac370d927d"),
				Name = @"PlannedLabor",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("0bf3a274-e5da-4fc7-94c4-3ae233598714"),
				ModifiedInSchemaUId = new Guid("0bf3a274-e5da-4fc7-94c4-3ae233598714"),
				CreatedInPackageId = new Guid("6364546f-7b12-440c-84c2-926c09002599")
			};
		}

		protected virtual EntitySchemaColumn CreateReleasedOnColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Date")) {
				UId = new Guid("ed1ac00a-35d0-49cf-a98b-c7727a743407"),
				Name = @"ReleasedOn",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("0bf3a274-e5da-4fc7-94c4-3ae233598714"),
				ModifiedInSchemaUId = new Guid("0bf3a274-e5da-4fc7-94c4-3ae233598714"),
				CreatedInPackageId = new Guid("6364546f-7b12-440c-84c2-926c09002599")
			};
		}

		protected virtual EntitySchemaColumn CreateDevelopmentFinishedOnColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Date")) {
				UId = new Guid("1351f672-5491-4478-b989-c14ca07fc932"),
				Name = @"DevelopmentFinishedOn",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("0bf3a274-e5da-4fc7-94c4-3ae233598714"),
				ModifiedInSchemaUId = new Guid("0bf3a274-e5da-4fc7-94c4-3ae233598714"),
				CreatedInPackageId = new Guid("6364546f-7b12-440c-84c2-926c09002599")
			};
		}

		protected virtual EntitySchemaColumn CreateTestingFinishedOnColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Date")) {
				UId = new Guid("676954b6-2543-40d6-a7c7-c66a16f30f20"),
				Name = @"TestingFinishedOn",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("0bf3a274-e5da-4fc7-94c4-3ae233598714"),
				ModifiedInSchemaUId = new Guid("0bf3a274-e5da-4fc7-94c4-3ae233598714"),
				CreatedInPackageId = new Guid("6364546f-7b12-440c-84c2-926c09002599")
			};
		}

		protected virtual EntitySchemaColumn CreateDeploymentFinishedOnColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Date")) {
				UId = new Guid("2593ddf4-7121-451e-8ab3-c7930ae36a16"),
				Name = @"DeploymentFinishedOn",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("0bf3a274-e5da-4fc7-94c4-3ae233598714"),
				ModifiedInSchemaUId = new Guid("0bf3a274-e5da-4fc7-94c4-3ae233598714"),
				CreatedInPackageId = new Guid("6364546f-7b12-440c-84c2-926c09002599")
			};
		}

		protected virtual EntitySchemaColumn CreateActualLaborColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("26913998-0c91-4ec2-8ea7-a5056e318c11"),
				Name = @"ActualLabor",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("0bf3a274-e5da-4fc7-94c4-3ae233598714"),
				ModifiedInSchemaUId = new Guid("0bf3a274-e5da-4fc7-94c4-3ae233598714"),
				CreatedInPackageId = new Guid("6364546f-7b12-440c-84c2-926c09002599")
			};
		}

		protected virtual EntitySchemaColumn CreateActualDevelopmentLaborColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("85a73cbf-9bfe-46fa-aeb1-ca38b8071b36"),
				Name = @"ActualDevelopmentLabor",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("0bf3a274-e5da-4fc7-94c4-3ae233598714"),
				ModifiedInSchemaUId = new Guid("0bf3a274-e5da-4fc7-94c4-3ae233598714"),
				CreatedInPackageId = new Guid("6364546f-7b12-440c-84c2-926c09002599")
			};
		}

		protected virtual EntitySchemaColumn CreateActualTestingLaborColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("7c4c7e8d-fa44-477c-9f39-64161076afe8"),
				Name = @"ActualTestingLabor",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("0bf3a274-e5da-4fc7-94c4-3ae233598714"),
				ModifiedInSchemaUId = new Guid("0bf3a274-e5da-4fc7-94c4-3ae233598714"),
				CreatedInPackageId = new Guid("6364546f-7b12-440c-84c2-926c09002599")
			};
		}

		protected virtual EntitySchemaColumn CreateActualDeploymentLaborColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("07f0e60b-e26b-492d-bdd3-38fc356a8e15"),
				Name = @"ActualDeploymentLabor",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("0bf3a274-e5da-4fc7-94c4-3ae233598714"),
				ModifiedInSchemaUId = new Guid("0bf3a274-e5da-4fc7-94c4-3ae233598714"),
				CreatedInPackageId = new Guid("6364546f-7b12-440c-84c2-926c09002599")
			};
		}

		protected virtual EntitySchemaColumn CreateStatusColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("b5bd8c19-aeea-4e9b-893e-a17447e80c13"),
				Name = @"Status",
				ReferenceSchemaUId = new Guid("597097ce-243d-49d2-90de-14bdf30391fb"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsValueCloneable = false,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("0bf3a274-e5da-4fc7-94c4-3ae233598714"),
				ModifiedInSchemaUId = new Guid("0bf3a274-e5da-4fc7-94c4-3ae233598714"),
				CreatedInPackageId = new Guid("6364546f-7b12-440c-84c2-926c09002599"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Settings,
					ValueSource = @"ReleaseStatusDef"
				}
			};
		}

		protected virtual EntitySchemaColumn CreateTypeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("2db0a991-0c65-4cde-b77e-de49aa699b69"),
				Name = @"Type",
				ReferenceSchemaUId = new Guid("3ec95a26-9a7d-4c16-afcf-fbda028e75b5"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("0bf3a274-e5da-4fc7-94c4-3ae233598714"),
				ModifiedInSchemaUId = new Guid("0bf3a274-e5da-4fc7-94c4-3ae233598714"),
				CreatedInPackageId = new Guid("6364546f-7b12-440c-84c2-926c09002599"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Settings,
					ValueSource = @"ReleaseTypeDef"
				}
			};
		}

		protected virtual EntitySchemaColumn CreatePriorityColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("6cc600e8-2a43-45a8-9d9e-8c99fbb066d5"),
				Name = @"Priority",
				ReferenceSchemaUId = new Guid("392e4b61-5160-4e90-a66b-89d6bb814c25"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("0bf3a274-e5da-4fc7-94c4-3ae233598714"),
				ModifiedInSchemaUId = new Guid("0bf3a274-e5da-4fc7-94c4-3ae233598714"),
				CreatedInPackageId = new Guid("6364546f-7b12-440c-84c2-926c09002599"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Settings,
					ValueSource = @"ReleasePriorityDef"
				}
			};
		}

		protected virtual EntitySchemaColumn CreateNotesColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("e2bab1e9-4524-466c-afe8-f154160fbe4f"),
				Name = @"Notes",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("0bf3a274-e5da-4fc7-94c4-3ae233598714"),
				ModifiedInSchemaUId = new Guid("0bf3a274-e5da-4fc7-94c4-3ae233598714"),
				CreatedInPackageId = new Guid("6364546f-7b12-440c-84c2-926c09002599")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateReleaseEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateReleaseEventsProcessSchema() {
			var schema = new ReleaseEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new Release(userConnection){Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new Release_ReleaseEventsProcess(userConnnection);
		}

		public override object Clone() {
			return new ReleaseSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new ReleaseSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("0bf3a274-e5da-4fc7-94c4-3ae233598714"));
		}

		#endregion

	}

	#endregion

	#region Class: Release

	/// <summary>
	/// Release.
	/// </summary>
	public class Release : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public Release(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Release";
		}

		public Release(Release source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Title.
		/// </summary>
		public  string Name {
			get {
				return GetTypedColumnValue<string>("Name");
			}
			set {
				SetColumnValue("Name", value);
			}
		}

		/// <summary>
		/// Number.
		/// </summary>
		public  string Number {
			get {
				return GetTypedColumnValue<string>("Number");
			}
			set {
				SetColumnValue("Number", value);
			}
		}

		/// <summary>
		/// Description.
		/// </summary>
		public  string Description {
			get {
				return GetTypedColumnValue<string>("Description");
			}
			set {
				SetColumnValue("Description", value);
			}
		}

		/// <summary>
		/// Scheduled release date.
		/// </summary>
		public  DateTime ScheduledReleaseDate {
			get {
				return GetTypedColumnValue<DateTime>("ScheduledReleaseDate");
			}
			set {
				SetColumnValue("ScheduledReleaseDate", value);
			}
		}

		/// <summary>
		/// Estimated working time (hours).
		/// </summary>
		public  int PlannedLabor {
			get {
				return GetTypedColumnValue<int>("PlannedLabor");
			}
			set {
				SetColumnValue("PlannedLabor", value);
			}
		}

		/// <summary>
		/// Actual release date.
		/// </summary>
		public  DateTime ReleasedOn {
			get {
				return GetTypedColumnValue<DateTime>("ReleasedOn");
			}
			set {
				SetColumnValue("ReleasedOn", value);
			}
		}

		/// <summary>
		/// Actual end of development.
		/// </summary>
		public  DateTime DevelopmentFinishedOn {
			get {
				return GetTypedColumnValue<DateTime>("DevelopmentFinishedOn");
			}
			set {
				SetColumnValue("DevelopmentFinishedOn", value);
			}
		}

		/// <summary>
		/// Actual end of testing.
		/// </summary>
		public  DateTime TestingFinishedOn {
			get {
				return GetTypedColumnValue<DateTime>("TestingFinishedOn");
			}
			set {
				SetColumnValue("TestingFinishedOn", value);
			}
		}

		/// <summary>
		/// Actual end of deployment.
		/// </summary>
		public  DateTime DeploymentFinishedOn {
			get {
				return GetTypedColumnValue<DateTime>("DeploymentFinishedOn");
			}
			set {
				SetColumnValue("DeploymentFinishedOn", value);
			}
		}

		/// <summary>
		/// Actual working time.
		/// </summary>
		public  int ActualLabor {
			get {
				return GetTypedColumnValue<int>("ActualLabor");
			}
			set {
				SetColumnValue("ActualLabor", value);
			}
		}

		/// <summary>
		/// Actual development time.
		/// </summary>
		public  int ActualDevelopmentLabor {
			get {
				return GetTypedColumnValue<int>("ActualDevelopmentLabor");
			}
			set {
				SetColumnValue("ActualDevelopmentLabor", value);
			}
		}

		/// <summary>
		/// Actual testing time.
		/// </summary>
		public  int ActualTestingLabor {
			get {
				return GetTypedColumnValue<int>("ActualTestingLabor");
			}
			set {
				SetColumnValue("ActualTestingLabor", value);
			}
		}

		/// <summary>
		/// Actual deployment time.
		/// </summary>
		public  int ActualDeploymentLabor {
			get {
				return GetTypedColumnValue<int>("ActualDeploymentLabor");
			}
			set {
				SetColumnValue("ActualDeploymentLabor", value);
			}
		}

		/// <exclude/>
		public  Guid StatusId {
			get {
				return GetTypedColumnValue<Guid>("StatusId");
			}
			set {
				SetColumnValue("StatusId", value);
				_status = null;
			}
		}

		/// <exclude/>
		public  string StatusName {
			get {
				return GetTypedColumnValue<string>("StatusName");
			}
			set {
				SetColumnValue("StatusName", value);
				if (_status != null) {
					_status.Name = value;
				}
			}
		}

		private ReleaseStatus _status;
		/// <summary>
		/// Status.
		/// </summary>
		public  ReleaseStatus Status {
			get {
				return _status ??
					(_status = LookupColumnEntities.GetEntity("Status") as ReleaseStatus);
			}
		}

		/// <exclude/>
		public  Guid TypeId {
			get {
				return GetTypedColumnValue<Guid>("TypeId");
			}
			set {
				SetColumnValue("TypeId", value);
				_type = null;
			}
		}

		/// <exclude/>
		public  string TypeName {
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

		private ReleaseType _type;
		/// <summary>
		/// Type.
		/// </summary>
		public  ReleaseType Type {
			get {
				return _type ??
					(_type = LookupColumnEntities.GetEntity("Type") as ReleaseType);
			}
		}

		/// <exclude/>
		public  Guid PriorityId {
			get {
				return GetTypedColumnValue<Guid>("PriorityId");
			}
			set {
				SetColumnValue("PriorityId", value);
				_priority = null;
			}
		}

		/// <exclude/>
		public  string PriorityName {
			get {
				return GetTypedColumnValue<string>("PriorityName");
			}
			set {
				SetColumnValue("PriorityName", value);
				if (_priority != null) {
					_priority.Name = value;
				}
			}
		}

		private ReleasePriority _priority;
		/// <summary>
		/// Priority.
		/// </summary>
		public  ReleasePriority Priority {
			get {
				return _priority ??
					(_priority = LookupColumnEntities.GetEntity("Priority") as ReleasePriority);
			}
		}

		/// <summary>
		/// Notes.
		/// </summary>
		public  string Notes {
			get {
				return GetTypedColumnValue<string>("Notes");
			}
			set {
				SetColumnValue("Notes", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new Release_ReleaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Validating += (s, e) => ThrowEvent("ReleaseValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new Release(this);
		}

		#endregion

	}

	#endregion

	#region Class: Release_ReleaseEventsProcess

	/// <exclude/>
	public class Release_ReleaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_LocalMessageEventsProcess<TEntity> where TEntity : Release
	{

		#region Class: GenerateNumberUserTaskFlowElement

		/// <exclude/>
		public class GenerateNumberUserTaskFlowElement : GenerateSequenseNumberUserTask
		{

			public GenerateNumberUserTaskFlowElement(UserConnection userConnection, Release_ReleaseEventsProcess<TEntity> process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "GenerateNumberUserTask";
				IsLogging = false;
				SchemaElementUId = new Guid("7964da2c-bc3f-4238-9e36-bfb4c8fd8676");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

		}

		#endregion

		public Release_ReleaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Release_ReleaseEventsProcess";
			SchemaUId = new Guid("0bf3a274-e5da-4fc7-94c4-3ae233598714");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private  Guid InternalSchemaUId {
			get {
				return new Guid("0bf3a274-e5da-4fc7-94c4-3ae233598714");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		private ProcessFlowElement _startMessage1;
		public  ProcessFlowElement StartMessage1 {
			get {
				return _startMessage1 ?? (_startMessage1 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "StartMessage1",
					SchemaElementUId = new Guid("256595bc-5fe1-4330-9a94-09c0ecc4fe03"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessTerminateEvent _terminate1;
		public  ProcessTerminateEvent Terminate1 {
			get {
				return _terminate1 ?? (_terminate1 = new ProcessTerminateEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaTerminateEvent",
					Name = "Terminate1",
					SchemaElementUId = new Guid("570269de-ad70-4fdf-b900-76d687058e82"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessExclusiveGateway _exclusiveGateway1;
		public  ProcessExclusiveGateway ExclusiveGateway1 {
			get {
				return _exclusiveGateway1 ?? (_exclusiveGateway1 = new ProcessExclusiveGateway() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaExclusiveGateway",
					Name = "ExclusiveGateway1",
					SchemaElementUId = new Guid("ea7d164d-078a-454f-8310-67d0ec11c85e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Question = new LocalizableString(Storage, Schema.GetResourceManagerName(),
					"EventsProcessSchema.BaseElements.ExclusiveGateway1.Question"),
						IsDecisionRequired = false,
						BranchingMode = GatewayBranchingMode.Auto,
						DecisionMode = GetewayDecisionSelectionMode.Single,
						ShowUserDecisionDialog = (processId, gatewayName) => {},
				});
			}
		}

		private ProcessScriptTask _scriptTask1;
		public  ProcessScriptTask ScriptTask1 {
			get {
				return _scriptTask1 ?? (_scriptTask1 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask1",
					SchemaElementUId = new Guid("72925bb0-b2b5-4a04-b81a-d0dd8f4d0fe0"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask1Execute,
				});
			}
		}

		private GenerateNumberUserTaskFlowElement _generateNumberUserTask;
		public  GenerateNumberUserTaskFlowElement GenerateNumberUserTask {
			get {
				return _generateNumberUserTask ?? (_generateNumberUserTask = new GenerateNumberUserTaskFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessScriptTask _scriptTask2;
		public  ProcessScriptTask ScriptTask2 {
			get {
				return _scriptTask2 ?? (_scriptTask2 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask2",
					SchemaElementUId = new Guid("86b0c6ed-93f2-4470-b27e-d98d13295b43"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = ScriptTask2Execute,
				});
			}
		}

		private ProcessConditionalFlow _conditionalFlow1;
		public  ProcessConditionalFlow ConditionalFlow1 {
			get {
				return _conditionalFlow1 ?? (_conditionalFlow1 = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ConditionalFlow1",
					SchemaElementUId = new Guid("7f2f8e6d-5e7f-4749-a080-22c80c1405c6"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[StartMessage1.SchemaElementUId] = new Collection<ProcessFlowElement> { StartMessage1 };
			FlowElements[Terminate1.SchemaElementUId] = new Collection<ProcessFlowElement> { Terminate1 };
			FlowElements[ExclusiveGateway1.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway1 };
			FlowElements[ScriptTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask1 };
			FlowElements[GenerateNumberUserTask.SchemaElementUId] = new Collection<ProcessFlowElement> { GenerateNumberUserTask };
			FlowElements[ScriptTask2.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask2 };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "StartMessage1":
						e.Context.QueueTasks.Enqueue("ExclusiveGateway1");
						break;
					case "Terminate1":
						break;
					case "ExclusiveGateway1":
						if (ConditionalFlow1ExpressionExecute()) {
							e.Context.QueueTasks.Enqueue("ScriptTask1");
							break;
						}
						e.Context.QueueTasks.Enqueue("Terminate1");
						break;
					case "ScriptTask1":
						e.Context.QueueTasks.Enqueue("GenerateNumberUserTask");
						break;
					case "GenerateNumberUserTask":
							e.Context.QueueTasks.Enqueue("ScriptTask2");
						break;
					case "ScriptTask2":
						e.Context.QueueTasks.Enqueue("Terminate1");
						break;
			}
			ProcessQueue(e.Context);
		}

		private bool ConditionalFlow1ExpressionExecute() {
			return Convert.ToBoolean(string.IsNullOrEmpty(Entity.GetTypedColumnValue<string>("Number")));
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
				case "StartMessage1":
					context.QueueTasks.Dequeue();
					context.SenderName = "StartMessage1";
					result = StartMessage1.Execute(context);
					break;
				case "Terminate1":
					context.QueueTasks.Dequeue();
					break;
				case "ExclusiveGateway1":
					context.QueueTasks.Dequeue();
					context.SenderName = "ExclusiveGateway1";
					result = ExclusiveGateway1.Execute(context);
					break;
				case "ScriptTask1":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask1";
					result = ScriptTask1.Execute(context, ScriptTask1Execute);
					break;
				case "GenerateNumberUserTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "GenerateNumberUserTask";
					result = GenerateNumberUserTask.Execute(context);
					break;
				case "ScriptTask2":
					context.QueueTasks.Dequeue();
					context.SenderName = "ScriptTask2";
					result = ScriptTask2.Execute(context, ScriptTask2Execute);
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

		public virtual bool ScriptTask1Execute(ProcessExecutingContext context) {
			GenerateNumberUserTask.EntitySchema = Entity.Schema;
			return true;
		}

		public virtual bool ScriptTask2Execute(ProcessExecutingContext context) {
			string code = GenerateNumberUserTask.ResultCode;
			if(!string.IsNullOrEmpty(code)) {
				Entity.SetColumnValue("Number", code);
				Entity.Save(false);
			}
			return true;
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

	#region Class: Release_ReleaseEventsProcess

	/// <exclude/>
	public class Release_ReleaseEventsProcess : Release_ReleaseEventsProcess<Release>
	{

		public Release_ReleaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: ReleaseEventsProcessSchema

	/// <exclude/>
	public class ReleaseEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public ReleaseEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public ReleaseEventsProcessSchema(ReleaseEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "Release_ReleaseEventsProcess";
			UId = new Guid("d73af896-a897-4311-bd2c-d97643d1346f");
			CreatedInPackageId = new Guid("3644c994-8f85-41ec-8125-47013bac161f");
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

		protected override ProcessSchemaParameter CreateNextProcessElementReadyParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("d9e67329-fde2-4fbd-aa49-2d69ca3d2b5b"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				Name = @"NextProcessElementReady",
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected override ProcessSchemaParameter CreateIsProcessModeSaveParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("4cb16350-d39b-4247-9da5-33032cf8667d"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				Name = @"IsProcessModeSave",
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected virtual void InitializeGenerateNumberUserTaskParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("76e55bd4-80fd-4304-b7ac-135d6df9e767"),
				ContainerUId = new Guid("7964da2c-bc3f-4238-9e36-bfb4c8fd8676"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b9b23348-b89c-4836-8c5b-283ef5ed8666"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b9b23348-b89c-4836-8c5b-283ef5ed8666"),
				Name = @"ResultCode",
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
			});
			parametrizedElement.Parameters.Add(new ProcessSchemaParameter(this) {
				UId = new Guid("817ff5f1-ea24-4eb5-8aa4-ca3e96cb3129"),
				ContainerUId = new Guid("7964da2c-bc3f-4238-9e36-bfb4c8fd8676"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("b9b23348-b89c-4836-8c5b-283ef5ed8666"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = true,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("b9b23348-b89c-4836-8c5b-283ef5ed8666"),
				Name = @"EntitySchema",
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.None,
					Value = null,
					MetaPath = null,
				},
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			});
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet1 = CreateLaneSet1LaneSet();
			LaneSets.Add(schemaLaneSet1);
			ProcessSchemaLane schemaLane1 = CreateLane1Lane();
			schemaLaneSet1.Lanes.Add(schemaLane1);
			ProcessSchemaStartMessageEvent startmessage1 = CreateStartMessage1StartMessageEvent();
			FlowElements.Add(startmessage1);
			ProcessSchemaTerminateEvent terminate1 = CreateTerminate1TerminateEvent();
			FlowElements.Add(terminate1);
			ProcessSchemaExclusiveGateway exclusivegateway1 = CreateExclusiveGateway1ExclusiveGateway();
			FlowElements.Add(exclusivegateway1);
			ProcessSchemaScriptTask scripttask1 = CreateScriptTask1ScriptTask();
			FlowElements.Add(scripttask1);
			ProcessSchemaUserTask generatenumberusertask = CreateGenerateNumberUserTaskUserTask();
			FlowElements.Add(generatenumberusertask);
			ProcessSchemaScriptTask scripttask2 = CreateScriptTask2ScriptTask();
			FlowElements.Add(scripttask2);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
			FlowElements.Add(CreateConditionalFlow1ConditionalFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateSequenceFlow4SequenceFlow());
			FlowElements.Add(CreateSequenceFlow5SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("361e0454-018a-4530-997f-f8b1b8cc7b93"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("66f58f21-6ed1-4e29-b506-6b9f6426d463"),
				CreatedInPackageId = new Guid("6364546f-7b12-440c-84c2-926c09002599"),
				CreatedInSchemaUId = new Guid("d73af896-a897-4311-bd2c-d97643d1346f"),
				CurveCenterPosition = new Point(586, 140),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("d73af896-a897-4311-bd2c-d97643d1346f"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("256595bc-5fe1-4330-9a94-09c0ecc4fe03"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("ea7d164d-078a-454f-8310-67d0ec11c85e"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3",
				UId = new Guid("f58bebef-5e94-4fed-85f8-1fd6f13822d4"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("66f58f21-6ed1-4e29-b506-6b9f6426d463"),
				CreatedInPackageId = new Guid("6364546f-7b12-440c-84c2-926c09002599"),
				CreatedInSchemaUId = new Guid("d73af896-a897-4311-bd2c-d97643d1346f"),
				CurveCenterPosition = new Point(586, 140),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("d73af896-a897-4311-bd2c-d97643d1346f"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("72925bb0-b2b5-4a04-b81a-d0dd8f4d0fe0"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("7964da2c-bc3f-4238-9e36-bfb4c8fd8676"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaConditionalFlow CreateConditionalFlow1ConditionalFlow() {
			ProcessSchemaConditionalFlow schemaFlow = new ProcessSchemaConditionalFlow(this) {
				Name = "ConditionalFlow1",
				UId = new Guid("7f2f8e6d-5e7f-4749-a080-22c80c1405c6"),
				ConditionExpression = @"string.IsNullOrEmpty(Entity.GetTypedColumnValue<string>(""Number""))",
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("66f58f21-6ed1-4e29-b506-6b9f6426d463"),
				CreatedInPackageId = new Guid("6364546f-7b12-440c-84c2-926c09002599"),
				CreatedInSchemaUId = new Guid("d73af896-a897-4311-bd2c-d97643d1346f"),
				CurveCenterPosition = new Point(240, 143),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Conditional,
				ManagerItemUId = new Guid("dac675d4-ea84-4e44-9056-38bf918618e9"),
				ModifiedInSchemaUId = new Guid("d73af896-a897-4311-bd2c-d97643d1346f"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("ea7d164d-078a-454f-8310-67d0ec11c85e"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("72925bb0-b2b5-4a04-b81a-d0dd8f4d0fe0"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline,
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("8a90a121-cd72-4bbd-906a-414ace6dddad"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("66f58f21-6ed1-4e29-b506-6b9f6426d463"),
				CreatedInPackageId = new Guid("6364546f-7b12-440c-84c2-926c09002599"),
				CreatedInSchemaUId = new Guid("d73af896-a897-4311-bd2c-d97643d1346f"),
				CurveCenterPosition = new Point(586, 140),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("d73af896-a897-4311-bd2c-d97643d1346f"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("7964da2c-bc3f-4238-9e36-bfb4c8fd8676"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("86b0c6ed-93f2-4470-b27e-d98d13295b43"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4",
				UId = new Guid("e5972be5-6fdc-484e-9c3b-4fecc2fb7eca"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("66f58f21-6ed1-4e29-b506-6b9f6426d463"),
				CreatedInPackageId = new Guid("6364546f-7b12-440c-84c2-926c09002599"),
				CreatedInSchemaUId = new Guid("d73af896-a897-4311-bd2c-d97643d1346f"),
				CurveCenterPosition = new Point(586, 140),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("d73af896-a897-4311-bd2c-d97643d1346f"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("86b0c6ed-93f2-4470-b27e-d98d13295b43"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("570269de-ad70-4fdf-b900-76d687058e82"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow5SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Default) {
				Name = "SequenceFlow5",
				UId = new Guid("63d9dd24-5801-42be-a295-257ac2b7dd0e"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("66f58f21-6ed1-4e29-b506-6b9f6426d463"),
				CreatedInPackageId = new Guid("6364546f-7b12-440c-84c2-926c09002599"),
				CreatedInSchemaUId = new Guid("d73af896-a897-4311-bd2c-d97643d1346f"),
				CurveCenterPosition = new Point(437, 134),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Default,
				ManagerItemUId = new Guid("573ed909-e069-4161-b193-ae8dd9437c68"),
				ModifiedInSchemaUId = new Guid("d73af896-a897-4311-bd2c-d97643d1346f"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("ea7d164d-078a-454f-8310-67d0ec11c85e"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 1),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("570269de-ad70-4fdf-b900-76d687058e82"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 1),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("ea7908a0-1671-487e-9289-8d7edf964b9f"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("66f58f21-6ed1-4e29-b506-6b9f6426d463"),
				CreatedInPackageId = new Guid("6364546f-7b12-440c-84c2-926c09002599"),
				CreatedInSchemaUId = new Guid("d73af896-a897-4311-bd2c-d97643d1346f"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("d73af896-a897-4311-bd2c-d97643d1346f"),
				Name = @"LaneSet1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(5, 5),
				Size = new Size(1277, 311),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("dd57ca9c-d48f-4c41-9272-a834333c5d87"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("ea7908a0-1671-487e-9289-8d7edf964b9f"),
				CreatedInOwnerSchemaUId = new Guid("0bf3a274-e5da-4fc7-94c4-3ae233598714"),
				CreatedInPackageId = new Guid("6364546f-7b12-440c-84c2-926c09002599"),
				CreatedInSchemaUId = new Guid("d73af896-a897-4311-bd2c-d97643d1346f"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("d73af896-a897-4311-bd2c-d97643d1346f"),
				Name = @"Lane1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(29, 0),
				Size = new Size(1248, 311),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateStartMessage1StartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("256595bc-5fe1-4330-9a94-09c0ecc4fe03"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("dd57ca9c-d48f-4c41-9272-a834333c5d87"),
				CreatedInOwnerSchemaUId = new Guid("66f58f21-6ed1-4e29-b506-6b9f6426d463"),
				CreatedInPackageId = new Guid("6364546f-7b12-440c-84c2-926c09002599"),
				CreatedInSchemaUId = new Guid("d73af896-a897-4311-bd2c-d97643d1346f"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"ReleaseInserting",
				ModifiedInSchemaUId = new Guid("d73af896-a897-4311-bd2c-d97643d1346f"),
				Name = @"StartMessage1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(43, 121),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaTerminateEvent CreateTerminate1TerminateEvent() {
			ProcessSchemaTerminateEvent schemaTerminateEvent = new ProcessSchemaTerminateEvent(this) {
				UId = new Guid("570269de-ad70-4fdf-b900-76d687058e82"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("dd57ca9c-d48f-4c41-9272-a834333c5d87"),
				CreatedInOwnerSchemaUId = new Guid("66f58f21-6ed1-4e29-b506-6b9f6426d463"),
				CreatedInPackageId = new Guid("6364546f-7b12-440c-84c2-926c09002599"),
				CreatedInSchemaUId = new Guid("d73af896-a897-4311-bd2c-d97643d1346f"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = false,
				ManagerItemUId = new Guid("1bd93619-0574-454e-bb4e-cf53b9eb9470"),
				ModifiedInSchemaUId = new Guid("d73af896-a897-4311-bd2c-d97643d1346f"),
				Name = @"Terminate1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(617, 121),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaTerminateEvent;
		}

		protected virtual ProcessSchemaExclusiveGateway CreateExclusiveGateway1ExclusiveGateway() {
			ProcessSchemaExclusiveGateway gateway = new ProcessSchemaExclusiveGateway(this) {
				UId = new Guid("ea7d164d-078a-454f-8310-67d0ec11c85e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("dd57ca9c-d48f-4c41-9272-a834333c5d87"),
				CreatedInOwnerSchemaUId = new Guid("66f58f21-6ed1-4e29-b506-6b9f6426d463"),
				CreatedInPackageId = new Guid("6364546f-7b12-440c-84c2-926c09002599"),
				CreatedInSchemaUId = new Guid("d73af896-a897-4311-bd2c-d97643d1346f"),
				DragGroupName = @"Gateway",
				ImageList = null,
				ImageName = null,
				IsLogging = false,
				ManagerItemUId = new Guid("bd9f7570-6c97-4f16-90e5-663a190c6c7c"),
				ModifiedInSchemaUId = new Guid("d73af896-a897-4311-bd2c-d97643d1346f"),
				Name = @"ExclusiveGateway1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(120, 107),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return gateway;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask1ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("72925bb0-b2b5-4a04-b81a-d0dd8f4d0fe0"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("dd57ca9c-d48f-4c41-9272-a834333c5d87"),
				CreatedInOwnerSchemaUId = new Guid("66f58f21-6ed1-4e29-b506-6b9f6426d463"),
				CreatedInPackageId = new Guid("6364546f-7b12-440c-84c2-926c09002599"),
				CreatedInSchemaUId = new Guid("d73af896-a897-4311-bd2c-d97643d1346f"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("d73af896-a897-4311-bd2c-d97643d1346f"),
				Name = @"ScriptTask1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(232, 107),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,115,79,205,75,45,74,44,73,245,43,205,77,74,45,10,45,78,45,10,73,44,206,214,115,205,43,201,44,169,12,78,206,72,205,77,84,176,85,128,112,245,32,124,107,94,174,162,212,146,210,162,60,133,146,162,210,84,107,0,137,141,144,78,66,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaUserTask CreateGenerateNumberUserTaskUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("7964da2c-bc3f-4238-9e36-bfb4c8fd8676"),
				AfterActivitySaveScript = @"",
				ContainerItemIndex = 0,
				ContainerUId = new Guid("dd57ca9c-d48f-4c41-9272-a834333c5d87"),
				CreatedInOwnerSchemaUId = new Guid("66f58f21-6ed1-4e29-b506-6b9f6426d463"),
				CreatedInPackageId = new Guid("6364546f-7b12-440c-84c2-926c09002599"),
				CreatedInSchemaUId = new Guid("d73af896-a897-4311-bd2c-d97643d1346f"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("d73af896-a897-4311-bd2c-d97643d1346f"),
				Name = @"GenerateNumberUserTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(365, 107),
				SchemaUId = new Guid("b9b23348-b89c-4836-8c5b-283ef5ed8666"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				TaskSchemaManagerName = @"ProcessUserTaskSchemaManager",
				UseBackgroundMode = false
			};
			InitializeGenerateNumberUserTaskParameters(schemaTask);
			return schemaTask;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask2ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("86b0c6ed-93f2-4470-b27e-d98d13295b43"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("dd57ca9c-d48f-4c41-9272-a834333c5d87"),
				CreatedInOwnerSchemaUId = new Guid("66f58f21-6ed1-4e29-b506-6b9f6426d463"),
				CreatedInPackageId = new Guid("6364546f-7b12-440c-84c2-926c09002599"),
				CreatedInSchemaUId = new Guid("d73af896-a897-4311-bd2c-d97643d1346f"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("d73af896-a897-4311-bd2c-d97643d1346f"),
				Name = @"ScriptTask2",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(491, 107),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,77,141,203,10,194,48,16,69,215,22,242,15,177,171,4,164,63,80,92,73,17,55,21,124,237,163,78,37,116,18,101,30,66,17,255,221,90,55,110,47,231,156,203,66,49,223,236,229,126,5,187,180,107,200,64,65,160,213,116,6,58,50,208,33,112,95,237,128,21,101,53,50,181,41,98,231,230,60,89,213,134,91,69,220,82,147,30,50,184,111,195,123,251,50,197,172,201,18,101,168,246,48,74,168,41,159,2,42,184,242,151,45,23,211,157,175,255,192,240,4,215,5,228,105,125,155,130,64,148,178,21,82,168,63,49,212,234,204,163,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
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

		protected override SchemaMethod CreateLocalMessageExecutingMethod() {
			SchemaMethod method = base.CreateLocalMessageExecutingMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,77,141,75,10,194,48,16,134,247,158,98,150,45,148,92,160,184,42,130,11,221,213,3,12,225,111,26,136,147,50,51,86,122,123,45,69,112,255,61,86,86,42,207,43,202,2,165,51,9,222,52,66,149,173,78,30,134,42,83,78,47,101,207,85,194,173,70,46,119,152,113,194,33,52,62,103,11,23,241,236,91,71,15,131,126,13,65,220,241,142,226,204,146,48,110,11,218,254,244,123,132,65,193,142,255,86,211,246,31,106,54,191,216,134,0,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new ReleaseEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d73af896-a897-4311-bd2c-d97643d1346f"));
		}

		#endregion

	}

	#endregion


	#region Class: ReleaseEventsProcess

	/// <exclude/>
	public class ReleaseEventsProcess : Release_ReleaseEventsProcess
	{

		public ReleaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

