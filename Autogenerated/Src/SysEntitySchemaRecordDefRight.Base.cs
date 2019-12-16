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

	#region Class: SysEntitySchemaRecordDefRightSchema

	/// <exclude/>
	[IsVirtual]
	public class SysEntitySchemaRecordDefRightSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public SysEntitySchemaRecordDefRightSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public SysEntitySchemaRecordDefRightSchema(SysEntitySchemaRecordDefRightSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public SysEntitySchemaRecordDefRightSchema(SysEntitySchemaRecordDefRightSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("2023116e-cdb5-49ab-9e44-315deba610b8");
			RealUId = new Guid("2023116e-cdb5-49ab-9e44-315deba610b8");
			Name = "SysEntitySchemaRecordDefRight";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("da2e27e4-45dc-4041-949e-25041f52bc84")) == null) {
				Columns.Add(CreateAuthorColumn());
			}
			if (Columns.FindByUId(new Guid("4d59ed87-eb02-40c1-a313-093a1d56427d")) == null) {
				Columns.Add(CreateGranteeColumn());
			}
			if (Columns.FindByUId(new Guid("aad5dad3-f79d-4259-b41e-28091d8ba81a")) == null) {
				Columns.Add(CreateOperationColumn());
			}
			if (Columns.FindByUId(new Guid("dfe9fd43-db84-4526-8206-131381e9effa")) == null) {
				Columns.Add(CreateRightLevelColumn());
			}
			if (Columns.FindByUId(new Guid("04aaec36-56c3-44a5-8e2c-49a52c23d99b")) == null) {
				Columns.Add(CreatePositionColumn());
			}
			if (Columns.FindByUId(new Guid("0e13b37d-f7ae-4127-8749-01c1e67487b9")) == null) {
				Columns.Add(CreateSubjectSchemaUIdColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateAuthorColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("da2e27e4-45dc-4041-949e-25041f52bc84"),
				Name = @"Author",
				ReferenceSchemaUId = new Guid("d5d01fcd-6d8c-4b29-9e58-cca3ffe62364"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("2023116e-cdb5-49ab-9e44-315deba610b8"),
				ModifiedInSchemaUId = new Guid("2023116e-cdb5-49ab-9e44-315deba610b8"),
				CreatedInPackageId = new Guid("06ab5269-0eb4-4ce1-a02d-5953e0f92289")
			};
		}

		protected virtual EntitySchemaColumn CreateGranteeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("4d59ed87-eb02-40c1-a313-093a1d56427d"),
				Name = @"Grantee",
				ReferenceSchemaUId = new Guid("d5d01fcd-6d8c-4b29-9e58-cca3ffe62364"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("2023116e-cdb5-49ab-9e44-315deba610b8"),
				ModifiedInSchemaUId = new Guid("2023116e-cdb5-49ab-9e44-315deba610b8"),
				CreatedInPackageId = new Guid("06ab5269-0eb4-4ce1-a02d-5953e0f92289")
			};
		}

		protected virtual EntitySchemaColumn CreateOperationColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("aad5dad3-f79d-4259-b41e-28091d8ba81a"),
				Name = @"Operation",
				ReferenceSchemaUId = new Guid("01618739-cd25-41bf-9cda-86594ea9f512"),
				CreatedInSchemaUId = new Guid("2023116e-cdb5-49ab-9e44-315deba610b8"),
				ModifiedInSchemaUId = new Guid("2023116e-cdb5-49ab-9e44-315deba610b8"),
				CreatedInPackageId = new Guid("06ab5269-0eb4-4ce1-a02d-5953e0f92289")
			};
		}

		protected virtual EntitySchemaColumn CreateRightLevelColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("dfe9fd43-db84-4526-8206-131381e9effa"),
				Name = @"RightLevel",
				ReferenceSchemaUId = new Guid("0305bb65-8332-47b3-8550-3d5c3e59cb3e"),
				CreatedInSchemaUId = new Guid("2023116e-cdb5-49ab-9e44-315deba610b8"),
				ModifiedInSchemaUId = new Guid("2023116e-cdb5-49ab-9e44-315deba610b8"),
				CreatedInPackageId = new Guid("06ab5269-0eb4-4ce1-a02d-5953e0f92289")
			};
		}

		protected virtual EntitySchemaColumn CreatePositionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("04aaec36-56c3-44a5-8e2c-49a52c23d99b"),
				Name = @"Position",
				CreatedInSchemaUId = new Guid("2023116e-cdb5-49ab-9e44-315deba610b8"),
				ModifiedInSchemaUId = new Guid("2023116e-cdb5-49ab-9e44-315deba610b8"),
				CreatedInPackageId = new Guid("06ab5269-0eb4-4ce1-a02d-5953e0f92289")
			};
		}

		protected virtual EntitySchemaColumn CreateSubjectSchemaUIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("0e13b37d-f7ae-4127-8749-01c1e67487b9"),
				Name = @"SubjectSchemaUId",
				CreatedInSchemaUId = new Guid("2023116e-cdb5-49ab-9e44-315deba610b8"),
				ModifiedInSchemaUId = new Guid("2023116e-cdb5-49ab-9e44-315deba610b8"),
				CreatedInPackageId = new Guid("06ab5269-0eb4-4ce1-a02d-5953e0f92289")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateSysEntitySchemaRecordDefRightEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateSysEntitySchemaRecordDefRightEventsProcessSchema() {
			var schema = new SysEntitySchemaRecordDefRightEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new SysEntitySchemaRecordDefRight(userConnection){Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new SysEntitySchemaRecordDefRight_BaseEventsProcess(userConnnection);
		}

		public override object Clone() {
			return new SysEntitySchemaRecordDefRightSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new SysEntitySchemaRecordDefRightSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("2023116e-cdb5-49ab-9e44-315deba610b8"));
		}

		#endregion

	}

	#endregion

	#region Class: SysEntitySchemaRecordDefRight

	/// <summary>
	/// Default permissions.
	/// </summary>
	public class SysEntitySchemaRecordDefRight : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public SysEntitySchemaRecordDefRight(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "SysEntitySchemaRecordDefRight";
		}

		public SysEntitySchemaRecordDefRight(SysEntitySchemaRecordDefRight source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public  Guid AuthorId {
			get {
				return GetTypedColumnValue<Guid>("AuthorId");
			}
			set {
				SetColumnValue("AuthorId", value);
				_author = null;
			}
		}

		/// <exclude/>
		public  string AuthorName {
			get {
				return GetTypedColumnValue<string>("AuthorName");
			}
			set {
				SetColumnValue("AuthorName", value);
				if (_author != null) {
					_author.Name = value;
				}
			}
		}

		private VwSysAdminUnit _author;
		/// <summary>
		/// Created by.
		/// </summary>
		public  VwSysAdminUnit Author {
			get {
				return _author ??
					(_author = LookupColumnEntities.GetEntity("Author") as VwSysAdminUnit);
			}
		}

		/// <exclude/>
		public  Guid GranteeId {
			get {
				return GetTypedColumnValue<Guid>("GranteeId");
			}
			set {
				SetColumnValue("GranteeId", value);
				_grantee = null;
			}
		}

		/// <exclude/>
		public  string GranteeName {
			get {
				return GetTypedColumnValue<string>("GranteeName");
			}
			set {
				SetColumnValue("GranteeName", value);
				if (_grantee != null) {
					_grantee.Name = value;
				}
			}
		}

		private VwSysAdminUnit _grantee;
		/// <summary>
		/// User/role.
		/// </summary>
		public  VwSysAdminUnit Grantee {
			get {
				return _grantee ??
					(_grantee = LookupColumnEntities.GetEntity("Grantee") as VwSysAdminUnit);
			}
		}

		/// <exclude/>
		public  Guid OperationId {
			get {
				return GetTypedColumnValue<Guid>("OperationId");
			}
			set {
				SetColumnValue("OperationId", value);
				_operation = null;
			}
		}

		/// <exclude/>
		public  string OperationName {
			get {
				return GetTypedColumnValue<string>("OperationName");
			}
			set {
				SetColumnValue("OperationName", value);
				if (_operation != null) {
					_operation.Name = value;
				}
			}
		}

		private EntitySchemaRecRightOperation _operation;
		/// <summary>
		/// Cash flow.
		/// </summary>
		public  EntitySchemaRecRightOperation Operation {
			get {
				return _operation ??
					(_operation = LookupColumnEntities.GetEntity("Operation") as EntitySchemaRecRightOperation);
			}
		}

		/// <exclude/>
		public  Guid RightLevelId {
			get {
				return GetTypedColumnValue<Guid>("RightLevelId");
			}
			set {
				SetColumnValue("RightLevelId", value);
				_rightLevel = null;
			}
		}

		/// <exclude/>
		public  string RightLevelName {
			get {
				return GetTypedColumnValue<string>("RightLevelName");
			}
			set {
				SetColumnValue("RightLevelName", value);
				if (_rightLevel != null) {
					_rightLevel.Name = value;
				}
			}
		}

		private SysEntitySchemaRecOprRightLvl _rightLevel;
		/// <summary>
		/// Access level.
		/// </summary>
		public  SysEntitySchemaRecOprRightLvl RightLevel {
			get {
				return _rightLevel ??
					(_rightLevel = LookupColumnEntities.GetEntity("RightLevel") as SysEntitySchemaRecOprRightLvl);
			}
		}

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

		/// <summary>
		/// Unique identifier of schema in workspace.
		/// </summary>
		public  Guid SubjectSchemaUId {
			get {
				return GetTypedColumnValue<Guid>("SubjectSchemaUId");
			}
			set {
				SetColumnValue("SubjectSchemaUId", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new SysEntitySchemaRecordDefRight_BaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleting += (s, e) => ThrowEvent("SysEntitySchemaRecordDefRightDeleting", e);
			Inserted += (s, e) => ThrowEvent("SysEntitySchemaRecordDefRightInserted", e);
			Inserting += (s, e) => ThrowEvent("SysEntitySchemaRecordDefRightInserting", e);
			Saved += (s, e) => ThrowEvent("SysEntitySchemaRecordDefRightSaved", e);
			Saving += (s, e) => ThrowEvent("SysEntitySchemaRecordDefRightSaving", e);
			Validating += (s, e) => ThrowEvent("SysEntitySchemaRecordDefRightValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SysEntitySchemaRecordDefRight(this);
		}

		#endregion

	}

	#endregion

	#region Class: SysEntitySchemaRecordDefRight_BaseEventsProcess

	/// <exclude/>
	public class SysEntitySchemaRecordDefRight_BaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_LocalMessageEventsProcess<TEntity> where TEntity : SysEntitySchemaRecordDefRight
	{

		public SysEntitySchemaRecordDefRight_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SysEntitySchemaRecordDefRight_BaseEventsProcess";
			SchemaUId = new Guid("2023116e-cdb5-49ab-9e44-315deba610b8");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private  Guid InternalSchemaUId {
			get {
				return new Guid("2023116e-cdb5-49ab-9e44-315deba610b8");
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

	#region Class: SysEntitySchemaRecordDefRight_BaseEventsProcess

	/// <exclude/>
	public class SysEntitySchemaRecordDefRight_BaseEventsProcess : SysEntitySchemaRecordDefRight_BaseEventsProcess<SysEntitySchemaRecordDefRight>
	{

		public SysEntitySchemaRecordDefRight_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SysEntitySchemaRecordDefRightEventsProcessSchema

	/// <exclude/>
	public class SysEntitySchemaRecordDefRightEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public SysEntitySchemaRecordDefRightEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public SysEntitySchemaRecordDefRightEventsProcessSchema(SysEntitySchemaRecordDefRightEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "SysEntitySchemaRecordDefRight_BaseEventsProcess";
			UId = new Guid("cd114db0-fac9-4f87-b04a-6b4876560ab4");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = Guid.Empty;
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
			return new SysEntitySchemaRecordDefRightEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("cd114db0-fac9-4f87-b04a-6b4876560ab4"));
		}

		#endregion

	}

	#endregion


	#region Class: SysEntitySchemaRecordDefRightEventsProcess

	/// <exclude/>
	public class SysEntitySchemaRecordDefRightEventsProcess : SysEntitySchemaRecordDefRight_BaseEventsProcess
	{

		public SysEntitySchemaRecordDefRightEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

