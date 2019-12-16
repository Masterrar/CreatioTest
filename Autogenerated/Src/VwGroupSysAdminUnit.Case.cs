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
	using Terrasoft.Core.OperationLog;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities.Json.Converters;

	#region Class: VwGroupSysAdminUnitSchema

	/// <exclude/>
	public class VwGroupSysAdminUnitSchema : Terrasoft.Configuration.SysAdminUnitSchema
	{

		#region Constructors: Public

		public VwGroupSysAdminUnitSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public VwGroupSysAdminUnitSchema(VwGroupSysAdminUnitSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public VwGroupSysAdminUnitSchema(VwGroupSysAdminUnitSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private EntitySchemaIndex CreateIUSysAdminUnitNameIndex() {
			EntitySchemaIndex index = new EntitySchemaIndex() {
				IsAutoName = false,
				IsClustered = false,
				IsUnique = true
			};
			index.UId = new Guid("e459c990-b248-488c-9ac8-8f0bab24ab77");
			index.Name = "IUSysAdminUnitName";
			index.CreatedInSchemaUId = new Guid("84f44b9a-4bc3-4cbf-a1a8-cec02c1c029c");
			index.ModifiedInSchemaUId = new Guid("84f44b9a-4bc3-4cbf-a1a8-cec02c1c029c");
			index.CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			EntitySchemaIndexColumn nameIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("5c950219-374c-425c-8082-7e7de785ba20"),
				ColumnUId = new Guid("736c30a7-c0ec-4fa9-b034-2552b319b633"),
				CreatedInSchemaUId = new Guid("84f44b9a-4bc3-4cbf-a1a8-cec02c1c029c"),
				ModifiedInSchemaUId = new Guid("84f44b9a-4bc3-4cbf-a1a8-cec02c1c029c"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				OrderDirection = OrderDirectionStrict.Ascending
			};
			index.Columns.Add(nameIndexColumn);
			return index;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("1ff32a7e-ed74-4fc7-948d-a3aa014d6e11");
			RealUId = new Guid("1ff32a7e-ed74-4fc7-948d-a3aa014d6e11");
			Name = "VwGroupSysAdminUnit";
			ParentSchemaUId = new Guid("84f44b9a-4bc3-4cbf-a1a8-cec02c1c029c");
			ExtendParent = false;
			CreatedInPackageId = new Guid("3148fb3e-f2dd-48f6-9b89-0b40779627d9");
			IsDBView = true;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.ModifiedInSchemaUId = new Guid("1ff32a7e-ed74-4fc7-948d-a3aa014d6e11");
			column.CreatedInPackageId = new Guid("3148fb3e-f2dd-48f6-9b89-0b40779627d9");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.ModifiedInSchemaUId = new Guid("1ff32a7e-ed74-4fc7-948d-a3aa014d6e11");
			column.CreatedInPackageId = new Guid("3148fb3e-f2dd-48f6-9b89-0b40779627d9");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.ModifiedInSchemaUId = new Guid("1ff32a7e-ed74-4fc7-948d-a3aa014d6e11");
			column.CreatedInPackageId = new Guid("3148fb3e-f2dd-48f6-9b89-0b40779627d9");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.ModifiedInSchemaUId = new Guid("1ff32a7e-ed74-4fc7-948d-a3aa014d6e11");
			column.CreatedInPackageId = new Guid("3148fb3e-f2dd-48f6-9b89-0b40779627d9");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.ModifiedInSchemaUId = new Guid("1ff32a7e-ed74-4fc7-948d-a3aa014d6e11");
			column.CreatedInPackageId = new Guid("3148fb3e-f2dd-48f6-9b89-0b40779627d9");
			return column;
		}

		protected override EntitySchemaColumn CreateNameColumn() {
			EntitySchemaColumn column = base.CreateNameColumn();
			column.ModifiedInSchemaUId = new Guid("1ff32a7e-ed74-4fc7-948d-a3aa014d6e11");
			column.CreatedInPackageId = new Guid("3148fb3e-f2dd-48f6-9b89-0b40779627d9");
			return column;
		}

		protected override EntitySchemaColumn CreateDescriptionColumn() {
			EntitySchemaColumn column = base.CreateDescriptionColumn();
			column.ModifiedInSchemaUId = new Guid("1ff32a7e-ed74-4fc7-948d-a3aa014d6e11");
			column.CreatedInPackageId = new Guid("3148fb3e-f2dd-48f6-9b89-0b40779627d9");
			return column;
		}

		protected override EntitySchemaColumn CreateSysAdminUnitTypeValueColumn() {
			EntitySchemaColumn column = base.CreateSysAdminUnitTypeValueColumn();
			column.ModifiedInSchemaUId = new Guid("1ff32a7e-ed74-4fc7-948d-a3aa014d6e11");
			column.CreatedInPackageId = new Guid("3148fb3e-f2dd-48f6-9b89-0b40779627d9");
			return column;
		}

		protected override EntitySchemaColumn CreateParentRoleColumn() {
			EntitySchemaColumn column = base.CreateParentRoleColumn();
			column.ReferenceSchemaUId = new Guid("1ff32a7e-ed74-4fc7-948d-a3aa014d6e11");
			column.ColumnValueName = @"ParentRoleId";
			column.DisplayColumnValueName = @"ParentRoleName";
			column.ModifiedInSchemaUId = new Guid("1ff32a7e-ed74-4fc7-948d-a3aa014d6e11");
			column.CreatedInPackageId = new Guid("3148fb3e-f2dd-48f6-9b89-0b40779627d9");
			return column;
		}

		protected override EntitySchemaColumn CreateContactColumn() {
			EntitySchemaColumn column = base.CreateContactColumn();
			column.ModifiedInSchemaUId = new Guid("1ff32a7e-ed74-4fc7-948d-a3aa014d6e11");
			column.CreatedInPackageId = new Guid("3148fb3e-f2dd-48f6-9b89-0b40779627d9");
			return column;
		}

		protected override EntitySchemaColumn CreateAccountColumn() {
			EntitySchemaColumn column = base.CreateAccountColumn();
			column.ModifiedInSchemaUId = new Guid("1ff32a7e-ed74-4fc7-948d-a3aa014d6e11");
			column.CreatedInPackageId = new Guid("3148fb3e-f2dd-48f6-9b89-0b40779627d9");
			return column;
		}

		protected override EntitySchemaColumn CreateIsDirectoryEntryColumn() {
			EntitySchemaColumn column = base.CreateIsDirectoryEntryColumn();
			column.ModifiedInSchemaUId = new Guid("1ff32a7e-ed74-4fc7-948d-a3aa014d6e11");
			column.CreatedInPackageId = new Guid("3148fb3e-f2dd-48f6-9b89-0b40779627d9");
			return column;
		}

		protected override EntitySchemaColumn CreateTimeZoneIdColumn() {
			EntitySchemaColumn column = base.CreateTimeZoneIdColumn();
			column.ModifiedInSchemaUId = new Guid("1ff32a7e-ed74-4fc7-948d-a3aa014d6e11");
			column.CreatedInPackageId = new Guid("3148fb3e-f2dd-48f6-9b89-0b40779627d9");
			return column;
		}

		protected override EntitySchemaColumn CreateUserPasswordColumn() {
			EntitySchemaColumn column = base.CreateUserPasswordColumn();
			column.ModifiedInSchemaUId = new Guid("1ff32a7e-ed74-4fc7-948d-a3aa014d6e11");
			column.CreatedInPackageId = new Guid("3148fb3e-f2dd-48f6-9b89-0b40779627d9");
			return column;
		}

		protected override EntitySchemaColumn CreateActiveColumn() {
			EntitySchemaColumn column = base.CreateActiveColumn();
			column.ModifiedInSchemaUId = new Guid("1ff32a7e-ed74-4fc7-948d-a3aa014d6e11");
			column.CreatedInPackageId = new Guid("3148fb3e-f2dd-48f6-9b89-0b40779627d9");
			return column;
		}

		protected override EntitySchemaColumn CreateSynchronizeWithLDAPColumn() {
			EntitySchemaColumn column = base.CreateSynchronizeWithLDAPColumn();
			column.ModifiedInSchemaUId = new Guid("1ff32a7e-ed74-4fc7-948d-a3aa014d6e11");
			column.CreatedInPackageId = new Guid("3148fb3e-f2dd-48f6-9b89-0b40779627d9");
			return column;
		}

		protected override EntitySchemaColumn CreateLDAPEntryColumn() {
			EntitySchemaColumn column = base.CreateLDAPEntryColumn();
			column.ModifiedInSchemaUId = new Guid("1ff32a7e-ed74-4fc7-948d-a3aa014d6e11");
			column.CreatedInPackageId = new Guid("3148fb3e-f2dd-48f6-9b89-0b40779627d9");
			return column;
		}

		protected override EntitySchemaColumn CreateLDAPEntryIdColumn() {
			EntitySchemaColumn column = base.CreateLDAPEntryIdColumn();
			column.ModifiedInSchemaUId = new Guid("1ff32a7e-ed74-4fc7-948d-a3aa014d6e11");
			column.CreatedInPackageId = new Guid("3148fb3e-f2dd-48f6-9b89-0b40779627d9");
			return column;
		}

		protected override EntitySchemaColumn CreateLDAPEntryDNColumn() {
			EntitySchemaColumn column = base.CreateLDAPEntryDNColumn();
			column.ModifiedInSchemaUId = new Guid("1ff32a7e-ed74-4fc7-948d-a3aa014d6e11");
			column.CreatedInPackageId = new Guid("3148fb3e-f2dd-48f6-9b89-0b40779627d9");
			return column;
		}

		protected override EntitySchemaColumn CreateLoggedInColumn() {
			EntitySchemaColumn column = base.CreateLoggedInColumn();
			column.ModifiedInSchemaUId = new Guid("1ff32a7e-ed74-4fc7-948d-a3aa014d6e11");
			column.CreatedInPackageId = new Guid("3148fb3e-f2dd-48f6-9b89-0b40779627d9");
			return column;
		}

		protected override EntitySchemaColumn CreateProcessListenersColumn() {
			EntitySchemaColumn column = base.CreateProcessListenersColumn();
			column.ModifiedInSchemaUId = new Guid("1ff32a7e-ed74-4fc7-948d-a3aa014d6e11");
			column.CreatedInPackageId = new Guid("3148fb3e-f2dd-48f6-9b89-0b40779627d9");
			return column;
		}

		protected override EntitySchemaColumn CreateSysCultureColumn() {
			EntitySchemaColumn column = base.CreateSysCultureColumn();
			column.ModifiedInSchemaUId = new Guid("1ff32a7e-ed74-4fc7-948d-a3aa014d6e11");
			column.CreatedInPackageId = new Guid("3148fb3e-f2dd-48f6-9b89-0b40779627d9");
			return column;
		}

		protected override EntitySchemaColumn CreateLoginAttemptCountColumn() {
			EntitySchemaColumn column = base.CreateLoginAttemptCountColumn();
			column.ModifiedInSchemaUId = new Guid("1ff32a7e-ed74-4fc7-948d-a3aa014d6e11");
			column.CreatedInPackageId = new Guid("3148fb3e-f2dd-48f6-9b89-0b40779627d9");
			return column;
		}

		protected override EntitySchemaColumn CreateSourceControlLoginColumn() {
			EntitySchemaColumn column = base.CreateSourceControlLoginColumn();
			column.ModifiedInSchemaUId = new Guid("1ff32a7e-ed74-4fc7-948d-a3aa014d6e11");
			column.CreatedInPackageId = new Guid("3148fb3e-f2dd-48f6-9b89-0b40779627d9");
			return column;
		}

		protected override EntitySchemaColumn CreateSourceControlPasswordColumn() {
			EntitySchemaColumn column = base.CreateSourceControlPasswordColumn();
			column.ModifiedInSchemaUId = new Guid("1ff32a7e-ed74-4fc7-948d-a3aa014d6e11");
			column.CreatedInPackageId = new Guid("3148fb3e-f2dd-48f6-9b89-0b40779627d9");
			return column;
		}

		protected override EntitySchemaColumn CreatePasswordExpireDateColumn() {
			EntitySchemaColumn column = base.CreatePasswordExpireDateColumn();
			column.ModifiedInSchemaUId = new Guid("1ff32a7e-ed74-4fc7-948d-a3aa014d6e11");
			column.CreatedInPackageId = new Guid("3148fb3e-f2dd-48f6-9b89-0b40779627d9");
			return column;
		}

		protected override EntitySchemaColumn CreateHomePageColumn() {
			EntitySchemaColumn column = base.CreateHomePageColumn();
			column.ModifiedInSchemaUId = new Guid("1ff32a7e-ed74-4fc7-948d-a3aa014d6e11");
			column.CreatedInPackageId = new Guid("3148fb3e-f2dd-48f6-9b89-0b40779627d9");
			return column;
		}

		protected override EntitySchemaColumn CreateConnectionTypeColumn() {
			EntitySchemaColumn column = base.CreateConnectionTypeColumn();
			column.ModifiedInSchemaUId = new Guid("1ff32a7e-ed74-4fc7-948d-a3aa014d6e11");
			column.CreatedInPackageId = new Guid("3148fb3e-f2dd-48f6-9b89-0b40779627d9");
			return column;
		}

		protected override EntitySchemaColumn CreateUnblockTimeColumn() {
			EntitySchemaColumn column = base.CreateUnblockTimeColumn();
			column.ModifiedInSchemaUId = new Guid("1ff32a7e-ed74-4fc7-948d-a3aa014d6e11");
			column.CreatedInPackageId = new Guid("3148fb3e-f2dd-48f6-9b89-0b40779627d9");
			return column;
		}

		protected override EntitySchemaColumn CreateForceChangePasswordColumn() {
			EntitySchemaColumn column = base.CreateForceChangePasswordColumn();
			column.ModifiedInSchemaUId = new Guid("1ff32a7e-ed74-4fc7-948d-a3aa014d6e11");
			column.CreatedInPackageId = new Guid("3148fb3e-f2dd-48f6-9b89-0b40779627d9");
			return column;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeIndexes() {
			base.InitializeIndexes();
			Indexes.Add(CreateIUSysAdminUnitNameIndex());
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateVwGroupSysAdminUnitEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateVwGroupSysAdminUnitEventsProcessSchema() {
			var schema = new VwGroupSysAdminUnitEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new VwGroupSysAdminUnit(userConnection){Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new VwGroupSysAdminUnit_CaseEventsProcess(userConnnection);
		}

		public override object Clone() {
			return new VwGroupSysAdminUnitSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new VwGroupSysAdminUnitSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("1ff32a7e-ed74-4fc7-948d-a3aa014d6e11"));
		}

		#endregion

	}

	#endregion

	#region Class: VwGroupSysAdminUnit

	/// <summary>
	/// Folder - Administration object (view).
	/// </summary>
	public class VwGroupSysAdminUnit : Terrasoft.Configuration.SysAdminUnit
	{

		#region Constructors: Public

		public VwGroupSysAdminUnit(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "VwGroupSysAdminUnit";
		}

		public VwGroupSysAdminUnit(VwGroupSysAdminUnit source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new VwGroupSysAdminUnit_CaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Saving += (s, e) => ThrowEvent("VwGroupSysAdminUnitSaving", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new VwGroupSysAdminUnit(this);
		}

		#endregion

	}

	#endregion

	#region Class: VwGroupSysAdminUnit_CaseEventsProcess

	/// <exclude/>
	public class VwGroupSysAdminUnit_CaseEventsProcess<TEntity> : Terrasoft.Configuration.SysAdminUnit_SSPEventsProcess<TEntity> where TEntity : VwGroupSysAdminUnit
	{

		public VwGroupSysAdminUnit_CaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "VwGroupSysAdminUnit_CaseEventsProcess";
			SchemaUId = new Guid("1ff32a7e-ed74-4fc7-948d-a3aa014d6e11");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private  Guid InternalSchemaUId {
			get {
				return new Guid("1ff32a7e-ed74-4fc7-948d-a3aa014d6e11");
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

	#region Class: VwGroupSysAdminUnit_CaseEventsProcess

	/// <exclude/>
	public class VwGroupSysAdminUnit_CaseEventsProcess : VwGroupSysAdminUnit_CaseEventsProcess<VwGroupSysAdminUnit>
	{

		public VwGroupSysAdminUnit_CaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: VwGroupSysAdminUnitEventsProcessSchema

	/// <exclude/>
	public class VwGroupSysAdminUnitEventsProcessSchema : Terrasoft.Configuration.SysAdminUnitEventsProcessSchema
	{

		#region Constructors: Public

		public VwGroupSysAdminUnitEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public VwGroupSysAdminUnitEventsProcessSchema(VwGroupSysAdminUnitEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "VwGroupSysAdminUnit_CaseEventsProcess";
			UId = new Guid("1807ffb1-1986-4e90-a591-b44444d7b161");
			CreatedInPackageId = new Guid("3148fb3e-f2dd-48f6-9b89-0b40779627d9");
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
				CreatedInPackageId = new Guid("3148fb3e-f2dd-48f6-9b89-0b40779627d9")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("cde525cf-d220-4d2a-b963-e55254c639fc"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("3148fb3e-f2dd-48f6-9b89-0b40779627d9")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5c9c82c6-ba6d-4a57-9a14-87fe8faa4ebb"),
				Name = "Terrasoft.Core.DB",
				Alias = "",
				CreatedInPackageId = new Guid("3148fb3e-f2dd-48f6-9b89-0b40779627d9")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7821de68-c82b-4917-a6cd-add2adfbe400"),
				Name = "Terrasoft.Common",
				Alias = "",
				CreatedInPackageId = new Guid("3148fb3e-f2dd-48f6-9b89-0b40779627d9")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d67de76f-9cbc-4bfc-babb-6f65cb89b973"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("3148fb3e-f2dd-48f6-9b89-0b40779627d9")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("74160d3b-65e3-4694-b554-089f2d980e54"),
				Name = "Newtonsoft.Json",
				Alias = "",
				CreatedInPackageId = new Guid("3148fb3e-f2dd-48f6-9b89-0b40779627d9")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e401300a-9f16-40c2-9788-cf310ae9d1c5"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("3148fb3e-f2dd-48f6-9b89-0b40779627d9")
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
				UId = new Guid("a1f8c6a6-798f-4d77-9ab8-0688bc1d077a"),
				Name = "Terrasoft.Core.OperationLog",
				Alias = "",
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			});
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new VwGroupSysAdminUnitEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("1807ffb1-1986-4e90-a591-b44444d7b161"));
		}

		#endregion

	}

	#endregion


	#region Class: VwGroupSysAdminUnitEventsProcess

	/// <exclude/>
	public class VwGroupSysAdminUnitEventsProcess : VwGroupSysAdminUnit_CaseEventsProcess
	{

		public VwGroupSysAdminUnitEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

