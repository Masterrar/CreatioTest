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

	#region Class: LDAPAuthTypeSchema

	/// <exclude/>
	public class LDAPAuthTypeSchema : Terrasoft.Configuration.BaseValueLookupSchema
	{

		#region Constructors: Public

		public LDAPAuthTypeSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public LDAPAuthTypeSchema(LDAPAuthTypeSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public LDAPAuthTypeSchema(LDAPAuthTypeSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("8f37c41d-9573-4c01-9d4d-41949787839d");
			RealUId = new Guid("8f37c41d-9573-4c01-9d4d-41949787839d");
			Name = "LDAPAuthType";
			ParentSchemaUId = new Guid("04f67f0c-0a27-4616-987e-60e378854b0f");
			ExtendParent = false;
			CreatedInPackageId = new Guid("c2d4e316-12f0-4097-be61-b2c5e6ccc44f");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.ModifiedInSchemaUId = new Guid("8f37c41d-9573-4c01-9d4d-41949787839d");
			column.CreatedInPackageId = new Guid("c2d4e316-12f0-4097-be61-b2c5e6ccc44f");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.ModifiedInSchemaUId = new Guid("8f37c41d-9573-4c01-9d4d-41949787839d");
			column.CreatedInPackageId = new Guid("c2d4e316-12f0-4097-be61-b2c5e6ccc44f");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.ModifiedInSchemaUId = new Guid("8f37c41d-9573-4c01-9d4d-41949787839d");
			column.CreatedInPackageId = new Guid("c2d4e316-12f0-4097-be61-b2c5e6ccc44f");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.ModifiedInSchemaUId = new Guid("8f37c41d-9573-4c01-9d4d-41949787839d");
			column.CreatedInPackageId = new Guid("c2d4e316-12f0-4097-be61-b2c5e6ccc44f");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.ModifiedInSchemaUId = new Guid("8f37c41d-9573-4c01-9d4d-41949787839d");
			column.CreatedInPackageId = new Guid("c2d4e316-12f0-4097-be61-b2c5e6ccc44f");
			return column;
		}

		protected override EntitySchemaColumn CreateNameColumn() {
			EntitySchemaColumn column = base.CreateNameColumn();
			column.IsLocalizable = false;
			column.ModifiedInSchemaUId = new Guid("8f37c41d-9573-4c01-9d4d-41949787839d");
			column.CreatedInPackageId = new Guid("c2d4e316-12f0-4097-be61-b2c5e6ccc44f");
			return column;
		}

		protected override EntitySchemaColumn CreateDescriptionColumn() {
			EntitySchemaColumn column = base.CreateDescriptionColumn();
			column.ModifiedInSchemaUId = new Guid("8f37c41d-9573-4c01-9d4d-41949787839d");
			column.CreatedInPackageId = new Guid("c2d4e316-12f0-4097-be61-b2c5e6ccc44f");
			return column;
		}

		protected override EntitySchemaColumn CreateValueColumn() {
			EntitySchemaColumn column = base.CreateValueColumn();
			column.ModifiedInSchemaUId = new Guid("8f37c41d-9573-4c01-9d4d-41949787839d");
			column.CreatedInPackageId = new Guid("c2d4e316-12f0-4097-be61-b2c5e6ccc44f");
			return column;
		}

		protected override EntitySchemaColumn CreateProcessListenersColumn() {
			EntitySchemaColumn column = base.CreateProcessListenersColumn();
			column.ModifiedInSchemaUId = new Guid("8f37c41d-9573-4c01-9d4d-41949787839d");
			column.CreatedInPackageId = new Guid("c2d4e316-12f0-4097-be61-b2c5e6ccc44f");
			return column;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateLDAPAuthTypeEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateLDAPAuthTypeEventsProcessSchema() {
			var schema = new LDAPAuthTypeEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new LDAPAuthType(userConnection){Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new LDAPAuthType_BaseEventsProcess(userConnnection);
		}

		public override object Clone() {
			return new LDAPAuthTypeSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new LDAPAuthTypeSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("8f37c41d-9573-4c01-9d4d-41949787839d"));
		}

		#endregion

	}

	#endregion

	#region Class: LDAPAuthType

	/// <summary>
	/// LDAP authentication type.
	/// </summary>
	public class LDAPAuthType : Terrasoft.Configuration.BaseValueLookup
	{

		#region Constructors: Public

		public LDAPAuthType(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "LDAPAuthType";
		}

		public LDAPAuthType(LDAPAuthType source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new LDAPAuthType_BaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Inserting += (s, e) => ThrowEvent("LDAPAuthTypeInserting", e);
			Validating += (s, e) => ThrowEvent("LDAPAuthTypeValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new LDAPAuthType(this);
		}

		#endregion

	}

	#endregion

	#region Class: LDAPAuthType_BaseEventsProcess

	/// <exclude/>
	public class LDAPAuthType_BaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseValueLookup_BaseEventsProcess<TEntity> where TEntity : LDAPAuthType
	{

		public LDAPAuthType_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "LDAPAuthType_BaseEventsProcess";
			SchemaUId = new Guid("8f37c41d-9573-4c01-9d4d-41949787839d");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private  Guid InternalSchemaUId {
			get {
				return new Guid("8f37c41d-9573-4c01-9d4d-41949787839d");
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

	#region Class: LDAPAuthType_BaseEventsProcess

	/// <exclude/>
	public class LDAPAuthType_BaseEventsProcess : LDAPAuthType_BaseEventsProcess<LDAPAuthType>
	{

		public LDAPAuthType_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: LDAPAuthTypeEventsProcessSchema

	/// <exclude/>
	public class LDAPAuthTypeEventsProcessSchema : Terrasoft.Configuration.BaseValueLookupEventsProcessSchema
	{

		#region Constructors: Public

		public LDAPAuthTypeEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public LDAPAuthTypeEventsProcessSchema(LDAPAuthTypeEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "LDAPAuthType_BaseEventsProcess";
			UId = new Guid("5946e5ef-6106-4e27-afbf-c47132dfd16d");
			CreatedInPackageId = new Guid("c2d4e316-12f0-4097-be61-b2c5e6ccc44f");
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
				CreatedInPackageId = new Guid("c2d4e316-12f0-4097-be61-b2c5e6ccc44f")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("cde525cf-d220-4d2a-b963-e55254c639fc"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("c2d4e316-12f0-4097-be61-b2c5e6ccc44f")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5c9c82c6-ba6d-4a57-9a14-87fe8faa4ebb"),
				Name = "Terrasoft.Core.DB",
				Alias = "",
				CreatedInPackageId = new Guid("c2d4e316-12f0-4097-be61-b2c5e6ccc44f")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7821de68-c82b-4917-a6cd-add2adfbe400"),
				Name = "Terrasoft.Common",
				Alias = "",
				CreatedInPackageId = new Guid("c2d4e316-12f0-4097-be61-b2c5e6ccc44f")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d67de76f-9cbc-4bfc-babb-6f65cb89b973"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("c2d4e316-12f0-4097-be61-b2c5e6ccc44f")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("74160d3b-65e3-4694-b554-089f2d980e54"),
				Name = "Newtonsoft.Json",
				Alias = "",
				CreatedInPackageId = new Guid("c2d4e316-12f0-4097-be61-b2c5e6ccc44f")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e401300a-9f16-40c2-9788-cf310ae9d1c5"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("c2d4e316-12f0-4097-be61-b2c5e6ccc44f")
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
			return new LDAPAuthTypeEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5946e5ef-6106-4e27-afbf-c47132dfd16d"));
		}

		#endregion

	}

	#endregion


	#region Class: LDAPAuthTypeEventsProcess

	/// <exclude/>
	public class LDAPAuthTypeEventsProcess : LDAPAuthType_BaseEventsProcess
	{

		public LDAPAuthTypeEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

