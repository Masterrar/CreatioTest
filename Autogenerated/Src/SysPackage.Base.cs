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

	#region Class: SysPackageSchema

	/// <exclude/>
	public class SysPackageSchema : Terrasoft.Configuration.BaseLookupSchema
	{

		#region Constructors: Public

		public SysPackageSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public SysPackageSchema(SysPackageSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public SysPackageSchema(SysPackageSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("ca400a85-ec48-4b42-8e50-271929d27871");
			RealUId = new Guid("ca400a85-ec48-4b42-8e50-271929d27871");
			Name = "SysPackage";
			ParentSchemaUId = new Guid("11ab4bcb-9b23-4b6d-9c86-520fae925d75");
			ExtendParent = false;
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("e03016f1-5bd9-4d03-b0b7-c70f2611d858")) == null) {
				Columns.Add(CreatePositionColumn());
			}
			if (Columns.FindByUId(new Guid("09bda14c-4c99-4334-872c-7025d4f4a145")) == null) {
				Columns.Add(CreateSysWorkspaceColumn());
			}
			if (Columns.FindByUId(new Guid("e8c58bad-c061-4a6e-ad33-25e51205860a")) == null) {
				Columns.Add(CreateUIdColumn());
			}
			if (Columns.FindByUId(new Guid("a7fa1c71-7f71-4e78-bf0c-c6a9f1d63245")) == null) {
				Columns.Add(CreateVersionColumn());
			}
			if (Columns.FindByUId(new Guid("6c8f3e62-61d0-4889-a19f-ee2cf3467dcd")) == null) {
				Columns.Add(CreateMaintainerColumn());
			}
			if (Columns.FindByUId(new Guid("5dbf61d3-1bde-48c1-8ed7-836780c51069")) == null) {
				Columns.Add(CreateEssentialColumn());
			}
			if (Columns.FindByUId(new Guid("6f511af8-4931-4609-9edc-47286628d7b7")) == null) {
				Columns.Add(CreateAnnotationColumn());
			}
			if (Columns.FindByUId(new Guid("200dbe3f-6fee-4d72-ae37-db9368d945ff")) == null) {
				Columns.Add(CreateIsChangedColumn());
			}
			if (Columns.FindByUId(new Guid("15f84493-7451-483a-879d-6264318b48c1")) == null) {
				Columns.Add(CreateIsLockedColumn());
			}
			if (Columns.FindByUId(new Guid("da13df0d-2e17-4ac7-8742-0c8e4fc47e42")) == null) {
				Columns.Add(CreateInstallTypeColumn());
			}
			if (Columns.FindByUId(new Guid("ce5b9115-e2df-4bf2-8b8f-d17919332833")) == null) {
				Columns.Add(CreateRepositoryRevisionNumberColumn());
			}
			if (Columns.FindByUId(new Guid("b3fd86b4-8cb4-4c5d-b5c5-426f6aba3f0b")) == null) {
				Columns.Add(CreateSysRepositoryColumn());
			}
		}

		protected override EntitySchemaColumn CreateNameColumn() {
			EntitySchemaColumn column = base.CreateNameColumn();
			column.IsLocalizable = false;
			column.ModifiedInSchemaUId = new Guid("ca400a85-ec48-4b42-8e50-271929d27871");
			column.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			return column;
		}

		protected override EntitySchemaColumn CreateDescriptionColumn() {
			EntitySchemaColumn column = base.CreateDescriptionColumn();
			column.IsLocalizable = false;
			column.ModifiedInSchemaUId = new Guid("ca400a85-ec48-4b42-8e50-271929d27871");
			column.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			return column;
		}

		protected virtual EntitySchemaColumn CreatePositionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("e03016f1-5bd9-4d03-b0b7-c70f2611d858"),
				Name = @"Position",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("ca400a85-ec48-4b42-8e50-271929d27871"),
				ModifiedInSchemaUId = new Guid("ca400a85-ec48-4b42-8e50-271929d27871"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateSysWorkspaceColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("09bda14c-4c99-4334-872c-7025d4f4a145"),
				Name = @"SysWorkspace",
				ReferenceSchemaUId = new Guid("7f9653ec-2e91-4aaa-a065-7b1d46edd292"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("ca400a85-ec48-4b42-8e50-271929d27871"),
				ModifiedInSchemaUId = new Guid("ca400a85-ec48-4b42-8e50-271929d27871"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateUIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("e8c58bad-c061-4a6e-ad33-25e51205860a"),
				Name = @"UId",
				CreatedInSchemaUId = new Guid("ca400a85-ec48-4b42-8e50-271929d27871"),
				ModifiedInSchemaUId = new Guid("ca400a85-ec48-4b42-8e50-271929d27871"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateVersionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("a7fa1c71-7f71-4e78-bf0c-c6a9f1d63245"),
				Name = @"Version",
				CreatedInSchemaUId = new Guid("ca400a85-ec48-4b42-8e50-271929d27871"),
				ModifiedInSchemaUId = new Guid("ca400a85-ec48-4b42-8e50-271929d27871"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateMaintainerColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("6c8f3e62-61d0-4889-a19f-ee2cf3467dcd"),
				Name = @"Maintainer",
				CreatedInSchemaUId = new Guid("ca400a85-ec48-4b42-8e50-271929d27871"),
				ModifiedInSchemaUId = new Guid("ca400a85-ec48-4b42-8e50-271929d27871"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateEssentialColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("5dbf61d3-1bde-48c1-8ed7-836780c51069"),
				Name = @"Essential",
				CreatedInSchemaUId = new Guid("ca400a85-ec48-4b42-8e50-271929d27871"),
				ModifiedInSchemaUId = new Guid("ca400a85-ec48-4b42-8e50-271929d27871"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateAnnotationColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("LongText")) {
				UId = new Guid("6f511af8-4931-4609-9edc-47286628d7b7"),
				Name = @"Annotation",
				CreatedInSchemaUId = new Guid("ca400a85-ec48-4b42-8e50-271929d27871"),
				ModifiedInSchemaUId = new Guid("ca400a85-ec48-4b42-8e50-271929d27871"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateIsChangedColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("200dbe3f-6fee-4d72-ae37-db9368d945ff"),
				Name = @"IsChanged",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("ca400a85-ec48-4b42-8e50-271929d27871"),
				ModifiedInSchemaUId = new Guid("ca400a85-ec48-4b42-8e50-271929d27871"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"False"
				}
			};
		}

		protected virtual EntitySchemaColumn CreateIsLockedColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("15f84493-7451-483a-879d-6264318b48c1"),
				Name = @"IsLocked",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("ca400a85-ec48-4b42-8e50-271929d27871"),
				ModifiedInSchemaUId = new Guid("ca400a85-ec48-4b42-8e50-271929d27871"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"False"
				}
			};
		}

		protected virtual EntitySchemaColumn CreateInstallTypeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ValueList")) {
				UId = new Guid("da13df0d-2e17-4ac7-8742-0c8e4fc47e42"),
				Name = @"InstallType",
				ReferenceValueListSchemaUId = new Guid("999bec5a-7aa1-4347-9040-d3421732352f"),
				CreatedInSchemaUId = new Guid("ca400a85-ec48-4b42-8e50-271929d27871"),
				ModifiedInSchemaUId = new Guid("ca400a85-ec48-4b42-8e50-271929d27871"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateRepositoryRevisionNumberColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("ce5b9115-e2df-4bf2-8b8f-d17919332833"),
				Name = @"RepositoryRevisionNumber",
				CreatedInSchemaUId = new Guid("ca400a85-ec48-4b42-8e50-271929d27871"),
				ModifiedInSchemaUId = new Guid("ca400a85-ec48-4b42-8e50-271929d27871"),
				CreatedInPackageId = new Guid("ae30d032-d762-4543-9b23-f4ddeb135bae")
			};
		}

		protected virtual EntitySchemaColumn CreateSysRepositoryColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("b3fd86b4-8cb4-4c5d-b5c5-426f6aba3f0b"),
				Name = @"SysRepository",
				ReferenceSchemaUId = new Guid("7b8d899e-40bf-4430-9665-908f653acf41"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("ca400a85-ec48-4b42-8e50-271929d27871"),
				ModifiedInSchemaUId = new Guid("ca400a85-ec48-4b42-8e50-271929d27871"),
				CreatedInPackageId = new Guid("18101200-c6ba-4ebd-a649-786a47318866")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateSysPackageEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateSysPackageEventsProcessSchema() {
			var schema = new SysPackageEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new SysPackage(userConnection){Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new SysPackage_BaseEventsProcess(userConnnection);
		}

		public override object Clone() {
			return new SysPackageSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new SysPackageSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ca400a85-ec48-4b42-8e50-271929d27871"));
		}

		#endregion

	}

	#endregion

	#region Class: SysPackage

	/// <summary>
	/// Package.
	/// </summary>
	public class SysPackage : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public SysPackage(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "SysPackage";
		}

		public SysPackage(SysPackage source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Position.
		/// </summary>
		public  int Position {
			get {
				return GetTypedColumnValue<int>("Position");
			}
			set {
				SetColumnValue("Position", value);
			}
		}

		/// <exclude/>
		public  Guid SysWorkspaceId {
			get {
				return GetTypedColumnValue<Guid>("SysWorkspaceId");
			}
			set {
				SetColumnValue("SysWorkspaceId", value);
				_sysWorkspace = null;
			}
		}

		/// <exclude/>
		public  string SysWorkspaceName {
			get {
				return GetTypedColumnValue<string>("SysWorkspaceName");
			}
			set {
				SetColumnValue("SysWorkspaceName", value);
				if (_sysWorkspace != null) {
					_sysWorkspace.Name = value;
				}
			}
		}

		private SysWorkspace _sysWorkspace;
		/// <summary>
		/// Workspace.
		/// </summary>
		public  SysWorkspace SysWorkspace {
			get {
				return _sysWorkspace ??
					(_sysWorkspace = LookupColumnEntities.GetEntity("SysWorkspace") as SysWorkspace);
			}
		}

		/// <summary>
		/// UId.
		/// </summary>
		public  Guid UId {
			get {
				return GetTypedColumnValue<Guid>("UId");
			}
			set {
				SetColumnValue("UId", value);
			}
		}

		/// <summary>
		/// Version.
		/// </summary>
		public  string Version {
			get {
				return GetTypedColumnValue<string>("Version");
			}
			set {
				SetColumnValue("Version", value);
			}
		}

		/// <summary>
		/// Maintainer.
		/// </summary>
		public  string Maintainer {
			get {
				return GetTypedColumnValue<string>("Maintainer");
			}
			set {
				SetColumnValue("Maintainer", value);
			}
		}

		/// <summary>
		/// Essentially.
		/// </summary>
		public  bool Essential {
			get {
				return GetTypedColumnValue<bool>("Essential");
			}
			set {
				SetColumnValue("Essential", value);
			}
		}

		/// <summary>
		/// Annotation.
		/// </summary>
		public  string Annotation {
			get {
				return GetTypedColumnValue<string>("Annotation");
			}
			set {
				SetColumnValue("Annotation", value);
			}
		}

		/// <summary>
		/// Package changed.
		/// </summary>
		public  bool IsChanged {
			get {
				return GetTypedColumnValue<bool>("IsChanged");
			}
			set {
				SetColumnValue("IsChanged", value);
			}
		}

		/// <summary>
		/// Package locked.
		/// </summary>
		public  bool IsLocked {
			get {
				return GetTypedColumnValue<bool>("IsLocked");
			}
			set {
				SetColumnValue("IsLocked", value);
			}
		}

		/// <summary>
		/// Installation type.
		/// </summary>
		public  SysPackageInstallType? InstallType {
			get {
				return GetTypedColumnValue<SysPackageInstallType>("InstallType");
			}
			set {
				SetColumnValue("InstallType", value);
			}
		}

		/// <summary>
		/// Storage revision current number.
		/// </summary>
		public  int RepositoryRevisionNumber {
			get {
				return GetTypedColumnValue<int>("RepositoryRevisionNumber");
			}
			set {
				SetColumnValue("RepositoryRevisionNumber", value);
			}
		}

		/// <exclude/>
		public  Guid SysRepositoryId {
			get {
				return GetTypedColumnValue<Guid>("SysRepositoryId");
			}
			set {
				SetColumnValue("SysRepositoryId", value);
				_sysRepository = null;
			}
		}

		/// <exclude/>
		public  string SysRepositoryName {
			get {
				return GetTypedColumnValue<string>("SysRepositoryName");
			}
			set {
				SetColumnValue("SysRepositoryName", value);
				if (_sysRepository != null) {
					_sysRepository.Name = value;
				}
			}
		}

		private SysRepository _sysRepository;
		/// <summary>
		/// Versions control storage.
		/// </summary>
		public  SysRepository SysRepository {
			get {
				return _sysRepository ??
					(_sysRepository = LookupColumnEntities.GetEntity("SysRepository") as SysRepository);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new SysPackage_BaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Inserting += (s, e) => ThrowEvent("SysPackageInserting", e);
			Validating += (s, e) => ThrowEvent("SysPackageValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SysPackage(this);
		}

		#endregion

	}

	#endregion

	#region Class: SysPackage_BaseEventsProcess

	/// <exclude/>
	public class SysPackage_BaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseLookup_BaseEventsProcess<TEntity> where TEntity : SysPackage
	{

		public SysPackage_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SysPackage_BaseEventsProcess";
			SchemaUId = new Guid("ca400a85-ec48-4b42-8e50-271929d27871");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private  Guid InternalSchemaUId {
			get {
				return new Guid("ca400a85-ec48-4b42-8e50-271929d27871");
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

		public override void CheckCanManageLookups() {
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

	#region Class: SysPackage_BaseEventsProcess

	/// <exclude/>
	public class SysPackage_BaseEventsProcess : SysPackage_BaseEventsProcess<SysPackage>
	{

		public SysPackage_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SysPackageEventsProcessSchema

	/// <exclude/>
	public class SysPackageEventsProcessSchema : Terrasoft.Configuration.BaseLookupEventsProcessSchema
	{

		#region Constructors: Public

		public SysPackageEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public SysPackageEventsProcessSchema(SysPackageEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "SysPackage_BaseEventsProcess";
			UId = new Guid("fb0b8db8-a05a-4af5-9185-59565d9d80e4");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("e20c0489-122a-4242-999c-169e8e866fc1");
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

		protected override SchemaMethod CreateCheckCanManageLookupsMethod() {
			SchemaMethod method = base.CreateCheckCanManageLookupsMethod();
			method.IsOverride = true;
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SysPackageEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("fb0b8db8-a05a-4af5-9185-59565d9d80e4"));
		}

		#endregion

	}

	#endregion


	#region Class: SysPackageEventsProcess

	/// <exclude/>
	public class SysPackageEventsProcess : SysPackage_BaseEventsProcess
	{

		public SysPackageEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

