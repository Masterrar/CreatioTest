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

	#region Class: PeriodicitySettingsSchema

	/// <exclude/>
	public class PeriodicitySettingsSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public PeriodicitySettingsSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public PeriodicitySettingsSchema(PeriodicitySettingsSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public PeriodicitySettingsSchema(PeriodicitySettingsSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e97f02c2-58d9-4e2e-842a-4520d4ca0ce8");
			RealUId = new Guid("e97f02c2-58d9-4e2e-842a-4520d4ca0ce8");
			Name = "PeriodicitySettings";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("47d763a9-8466-4603-9d1d-8b002ce224e7")) == null) {
				Columns.Add(CreateIsDailyColumn());
			}
			if (Columns.FindByUId(new Guid("4519971c-ef6a-4093-9ac2-815cba012376")) == null) {
				Columns.Add(CreateDailyPeriodColumn());
			}
			if (Columns.FindByUId(new Guid("12380ad3-9811-408f-a2ae-41d8824aff28")) == null) {
				Columns.Add(CreateIsWeeklyColumn());
			}
			if (Columns.FindByUId(new Guid("3c403256-b627-45e2-ae0c-a2b8287fc9fe")) == null) {
				Columns.Add(CreateDayOfWeekColumn());
			}
			if (Columns.FindByUId(new Guid("c4c846c0-4f99-4c7b-96f2-96d0c2cebeb1")) == null) {
				Columns.Add(CreateIsMonthlyColumn());
			}
			if (Columns.FindByUId(new Guid("52b22af7-46c5-483b-9a75-03b93d4ec7a7")) == null) {
				Columns.Add(CreateIsMonthlyCustomColumn());
			}
			if (Columns.FindByUId(new Guid("7fd3d658-9f16-4d63-816a-a7b825256605")) == null) {
				Columns.Add(CreateDayOfMonthColumn());
			}
			if (Columns.FindByUId(new Guid("e2d8c2fb-a4c7-4b5c-8d9f-bfc3ab4128d6")) == null) {
				Columns.Add(CreateIsMonthlyLastDayColumn());
			}
			if (Columns.FindByUId(new Guid("69cbd451-c173-48d2-9a7f-b0e67bbd0269")) == null) {
				Columns.Add(CreateIsOnceColumn());
			}
			if (Columns.FindByUId(new Guid("7817b396-8b15-4bb4-9248-7264b7a54ffa")) == null) {
				Columns.Add(CreateOnceAtColumn());
			}
			if (Columns.FindByUId(new Guid("71cd487f-f25f-4202-9965-4beb10ee76a4")) == null) {
				Columns.Add(CreateIsCustomColumn());
			}
			if (Columns.FindByUId(new Guid("87be6e44-0210-469f-86d1-1e1d19414706")) == null) {
				Columns.Add(CreateCustomPeriodColumn());
			}
			if (Columns.FindByUId(new Guid("5523cb12-f07f-4c73-b366-900c6860b9ab")) == null) {
				Columns.Add(CreateCustomPeriodTypeColumn());
			}
			if (Columns.FindByUId(new Guid("09b2ad89-826f-4806-869f-d4454507cb45")) == null) {
				Columns.Add(CreateCustomFromColumn());
			}
			if (Columns.FindByUId(new Guid("2b6dfefc-6012-4039-896c-f0b539b78d4e")) == null) {
				Columns.Add(CreateCustomTillColumn());
			}
			if (Columns.FindByUId(new Guid("ef6ae8b8-d210-4da8-8025-a47a9204f8a7")) == null) {
				Columns.Add(CreateSchedulerStartColumn());
			}
			if (Columns.FindByUId(new Guid("89965a50-cf91-4b73-8ea6-41814f699f55")) == null) {
				Columns.Add(CreateSchedulerFinishColumn());
			}
			if (Columns.FindByUId(new Guid("4cc31fdf-ec3c-43cb-b0f4-c2fe2b5d4928")) == null) {
				Columns.Add(CreateIsSchedulerEndlessColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateIsDailyColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("47d763a9-8466-4603-9d1d-8b002ce224e7"),
				Name = @"IsDaily",
				CreatedInSchemaUId = new Guid("e97f02c2-58d9-4e2e-842a-4520d4ca0ce8"),
				ModifiedInSchemaUId = new Guid("e97f02c2-58d9-4e2e-842a-4520d4ca0ce8"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateDailyPeriodColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("4519971c-ef6a-4093-9ac2-815cba012376"),
				Name = @"DailyPeriod",
				CreatedInSchemaUId = new Guid("e97f02c2-58d9-4e2e-842a-4520d4ca0ce8"),
				ModifiedInSchemaUId = new Guid("e97f02c2-58d9-4e2e-842a-4520d4ca0ce8"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateIsWeeklyColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("12380ad3-9811-408f-a2ae-41d8824aff28"),
				Name = @"IsWeekly",
				CreatedInSchemaUId = new Guid("e97f02c2-58d9-4e2e-842a-4520d4ca0ce8"),
				ModifiedInSchemaUId = new Guid("e97f02c2-58d9-4e2e-842a-4520d4ca0ce8"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateDayOfWeekColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("3c403256-b627-45e2-ae0c-a2b8287fc9fe"),
				Name = @"DayOfWeek",
				CreatedInSchemaUId = new Guid("e97f02c2-58d9-4e2e-842a-4520d4ca0ce8"),
				ModifiedInSchemaUId = new Guid("e97f02c2-58d9-4e2e-842a-4520d4ca0ce8"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateIsMonthlyColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("c4c846c0-4f99-4c7b-96f2-96d0c2cebeb1"),
				Name = @"IsMonthly",
				CreatedInSchemaUId = new Guid("e97f02c2-58d9-4e2e-842a-4520d4ca0ce8"),
				ModifiedInSchemaUId = new Guid("e97f02c2-58d9-4e2e-842a-4520d4ca0ce8"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateIsMonthlyCustomColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("52b22af7-46c5-483b-9a75-03b93d4ec7a7"),
				Name = @"IsMonthlyCustom",
				CreatedInSchemaUId = new Guid("e97f02c2-58d9-4e2e-842a-4520d4ca0ce8"),
				ModifiedInSchemaUId = new Guid("e97f02c2-58d9-4e2e-842a-4520d4ca0ce8"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateDayOfMonthColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("7fd3d658-9f16-4d63-816a-a7b825256605"),
				Name = @"DayOfMonth",
				CreatedInSchemaUId = new Guid("e97f02c2-58d9-4e2e-842a-4520d4ca0ce8"),
				ModifiedInSchemaUId = new Guid("e97f02c2-58d9-4e2e-842a-4520d4ca0ce8"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateIsMonthlyLastDayColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("e2d8c2fb-a4c7-4b5c-8d9f-bfc3ab4128d6"),
				Name = @"IsMonthlyLastDay",
				CreatedInSchemaUId = new Guid("e97f02c2-58d9-4e2e-842a-4520d4ca0ce8"),
				ModifiedInSchemaUId = new Guid("e97f02c2-58d9-4e2e-842a-4520d4ca0ce8"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateIsOnceColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("69cbd451-c173-48d2-9a7f-b0e67bbd0269"),
				Name = @"IsOnce",
				CreatedInSchemaUId = new Guid("e97f02c2-58d9-4e2e-842a-4520d4ca0ce8"),
				ModifiedInSchemaUId = new Guid("e97f02c2-58d9-4e2e-842a-4520d4ca0ce8"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateOnceAtColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Time")) {
				UId = new Guid("7817b396-8b15-4bb4-9248-7264b7a54ffa"),
				Name = @"OnceAt",
				CreatedInSchemaUId = new Guid("e97f02c2-58d9-4e2e-842a-4520d4ca0ce8"),
				ModifiedInSchemaUId = new Guid("e97f02c2-58d9-4e2e-842a-4520d4ca0ce8"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateIsCustomColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("71cd487f-f25f-4202-9965-4beb10ee76a4"),
				Name = @"IsCustom",
				CreatedInSchemaUId = new Guid("e97f02c2-58d9-4e2e-842a-4520d4ca0ce8"),
				ModifiedInSchemaUId = new Guid("e97f02c2-58d9-4e2e-842a-4520d4ca0ce8"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateCustomPeriodColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("87be6e44-0210-469f-86d1-1e1d19414706"),
				Name = @"CustomPeriod",
				CreatedInSchemaUId = new Guid("e97f02c2-58d9-4e2e-842a-4520d4ca0ce8"),
				ModifiedInSchemaUId = new Guid("e97f02c2-58d9-4e2e-842a-4520d4ca0ce8"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateCustomPeriodTypeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("5523cb12-f07f-4c73-b366-900c6860b9ab"),
				Name = @"CustomPeriodType",
				CreatedInSchemaUId = new Guid("e97f02c2-58d9-4e2e-842a-4520d4ca0ce8"),
				ModifiedInSchemaUId = new Guid("e97f02c2-58d9-4e2e-842a-4520d4ca0ce8"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateCustomFromColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Time")) {
				UId = new Guid("09b2ad89-826f-4806-869f-d4454507cb45"),
				Name = @"CustomFrom",
				CreatedInSchemaUId = new Guid("e97f02c2-58d9-4e2e-842a-4520d4ca0ce8"),
				ModifiedInSchemaUId = new Guid("e97f02c2-58d9-4e2e-842a-4520d4ca0ce8"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateCustomTillColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Time")) {
				UId = new Guid("2b6dfefc-6012-4039-896c-f0b539b78d4e"),
				Name = @"CustomTill",
				CreatedInSchemaUId = new Guid("e97f02c2-58d9-4e2e-842a-4520d4ca0ce8"),
				ModifiedInSchemaUId = new Guid("e97f02c2-58d9-4e2e-842a-4520d4ca0ce8"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateSchedulerStartColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("DateTime")) {
				UId = new Guid("ef6ae8b8-d210-4da8-8025-a47a9204f8a7"),
				Name = @"SchedulerStart",
				CreatedInSchemaUId = new Guid("e97f02c2-58d9-4e2e-842a-4520d4ca0ce8"),
				ModifiedInSchemaUId = new Guid("e97f02c2-58d9-4e2e-842a-4520d4ca0ce8"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateSchedulerFinishColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("DateTime")) {
				UId = new Guid("89965a50-cf91-4b73-8ea6-41814f699f55"),
				Name = @"SchedulerFinish",
				CreatedInSchemaUId = new Guid("e97f02c2-58d9-4e2e-842a-4520d4ca0ce8"),
				ModifiedInSchemaUId = new Guid("e97f02c2-58d9-4e2e-842a-4520d4ca0ce8"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateIsSchedulerEndlessColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("4cc31fdf-ec3c-43cb-b0f4-c2fe2b5d4928"),
				Name = @"IsSchedulerEndless",
				CreatedInSchemaUId = new Guid("e97f02c2-58d9-4e2e-842a-4520d4ca0ce8"),
				ModifiedInSchemaUId = new Guid("e97f02c2-58d9-4e2e-842a-4520d4ca0ce8"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreatePeriodicitySettingsEventsProcessSchema();
		}

		protected virtual ProcessSchema CreatePeriodicitySettingsEventsProcessSchema() {
			var schema = new PeriodicitySettingsEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new PeriodicitySettings(userConnection){Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new PeriodicitySettings_BaseEventsProcess(userConnnection);
		}

		public override object Clone() {
			return new PeriodicitySettingsSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new PeriodicitySettingsSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e97f02c2-58d9-4e2e-842a-4520d4ca0ce8"));
		}

		#endregion

	}

	#endregion

	#region Class: PeriodicitySettings

	/// <summary>
	/// Synchronization frequency settings.
	/// </summary>
	public class PeriodicitySettings : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public PeriodicitySettings(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "PeriodicitySettings";
		}

		public PeriodicitySettings(PeriodicitySettings source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// IsDaily.
		/// </summary>
		public  bool IsDaily {
			get {
				return GetTypedColumnValue<bool>("IsDaily");
			}
			set {
				SetColumnValue("IsDaily", value);
			}
		}

		/// <summary>
		/// DailyPeriod.
		/// </summary>
		public  int DailyPeriod {
			get {
				return GetTypedColumnValue<int>("DailyPeriod");
			}
			set {
				SetColumnValue("DailyPeriod", value);
			}
		}

		/// <summary>
		/// IsWeekly.
		/// </summary>
		public  bool IsWeekly {
			get {
				return GetTypedColumnValue<bool>("IsWeekly");
			}
			set {
				SetColumnValue("IsWeekly", value);
			}
		}

		/// <summary>
		/// DayOfWeek.
		/// </summary>
		public  int DayOfWeek {
			get {
				return GetTypedColumnValue<int>("DayOfWeek");
			}
			set {
				SetColumnValue("DayOfWeek", value);
			}
		}

		/// <summary>
		/// IsMonthly.
		/// </summary>
		public  bool IsMonthly {
			get {
				return GetTypedColumnValue<bool>("IsMonthly");
			}
			set {
				SetColumnValue("IsMonthly", value);
			}
		}

		/// <summary>
		/// IsMonthlyCustom.
		/// </summary>
		public  bool IsMonthlyCustom {
			get {
				return GetTypedColumnValue<bool>("IsMonthlyCustom");
			}
			set {
				SetColumnValue("IsMonthlyCustom", value);
			}
		}

		/// <summary>
		/// DayOfMonth.
		/// </summary>
		public  int DayOfMonth {
			get {
				return GetTypedColumnValue<int>("DayOfMonth");
			}
			set {
				SetColumnValue("DayOfMonth", value);
			}
		}

		/// <summary>
		/// IsMonthlyLastDay.
		/// </summary>
		public  bool IsMonthlyLastDay {
			get {
				return GetTypedColumnValue<bool>("IsMonthlyLastDay");
			}
			set {
				SetColumnValue("IsMonthlyLastDay", value);
			}
		}

		/// <summary>
		/// IsOnce.
		/// </summary>
		public  bool IsOnce {
			get {
				return GetTypedColumnValue<bool>("IsOnce");
			}
			set {
				SetColumnValue("IsOnce", value);
			}
		}

		/// <summary>
		/// OnceAt.
		/// </summary>
		public  DateTime OnceAt {
			get {
				return GetTypedColumnValue<DateTime>("OnceAt");
			}
			set {
				SetColumnValue("OnceAt", value);
			}
		}

		/// <summary>
		/// IsCustom.
		/// </summary>
		public  bool IsCustom {
			get {
				return GetTypedColumnValue<bool>("IsCustom");
			}
			set {
				SetColumnValue("IsCustom", value);
			}
		}

		/// <summary>
		/// CustomPeriod.
		/// </summary>
		public  int CustomPeriod {
			get {
				return GetTypedColumnValue<int>("CustomPeriod");
			}
			set {
				SetColumnValue("CustomPeriod", value);
			}
		}

		/// <summary>
		/// CustomPeriodType.
		/// </summary>
		public  int CustomPeriodType {
			get {
				return GetTypedColumnValue<int>("CustomPeriodType");
			}
			set {
				SetColumnValue("CustomPeriodType", value);
			}
		}

		/// <summary>
		/// CustomFrom.
		/// </summary>
		public  DateTime CustomFrom {
			get {
				return GetTypedColumnValue<DateTime>("CustomFrom");
			}
			set {
				SetColumnValue("CustomFrom", value);
			}
		}

		/// <summary>
		/// CustomTill.
		/// </summary>
		public  DateTime CustomTill {
			get {
				return GetTypedColumnValue<DateTime>("CustomTill");
			}
			set {
				SetColumnValue("CustomTill", value);
			}
		}

		/// <summary>
		/// SchedulerStart.
		/// </summary>
		public  DateTime SchedulerStart {
			get {
				return GetTypedColumnValue<DateTime>("SchedulerStart");
			}
			set {
				SetColumnValue("SchedulerStart", value);
			}
		}

		/// <summary>
		/// SchedulerFinish.
		/// </summary>
		public  DateTime SchedulerFinish {
			get {
				return GetTypedColumnValue<DateTime>("SchedulerFinish");
			}
			set {
				SetColumnValue("SchedulerFinish", value);
			}
		}

		/// <summary>
		/// IsSchedulerEndless.
		/// </summary>
		public  bool IsSchedulerEndless {
			get {
				return GetTypedColumnValue<bool>("IsSchedulerEndless");
			}
			set {
				SetColumnValue("IsSchedulerEndless", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new PeriodicitySettings_BaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Inserting += (s, e) => ThrowEvent("PeriodicitySettingsInserting", e);
			Validating += (s, e) => ThrowEvent("PeriodicitySettingsValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new PeriodicitySettings(this);
		}

		#endregion

	}

	#endregion

	#region Class: PeriodicitySettings_BaseEventsProcess

	/// <exclude/>
	public class PeriodicitySettings_BaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_LocalMessageEventsProcess<TEntity> where TEntity : PeriodicitySettings
	{

		public PeriodicitySettings_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "PeriodicitySettings_BaseEventsProcess";
			SchemaUId = new Guid("e97f02c2-58d9-4e2e-842a-4520d4ca0ce8");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private  Guid InternalSchemaUId {
			get {
				return new Guid("e97f02c2-58d9-4e2e-842a-4520d4ca0ce8");
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

	#region Class: PeriodicitySettings_BaseEventsProcess

	/// <exclude/>
	public class PeriodicitySettings_BaseEventsProcess : PeriodicitySettings_BaseEventsProcess<PeriodicitySettings>
	{

		public PeriodicitySettings_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: PeriodicitySettingsEventsProcessSchema

	/// <exclude/>
	public class PeriodicitySettingsEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public PeriodicitySettingsEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public PeriodicitySettingsEventsProcessSchema(PeriodicitySettingsEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "PeriodicitySettings_BaseEventsProcess";
			UId = new Guid("37d3aaab-bde5-440c-b364-f6dafd2cd2af");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
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

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new PeriodicitySettingsEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("37d3aaab-bde5-440c-b364-f6dafd2cd2af"));
		}

		#endregion

	}

	#endregion


	#region Class: PeriodicitySettingsEventsProcess

	/// <exclude/>
	public class PeriodicitySettingsEventsProcess : PeriodicitySettings_BaseEventsProcess
	{

		public PeriodicitySettingsEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

