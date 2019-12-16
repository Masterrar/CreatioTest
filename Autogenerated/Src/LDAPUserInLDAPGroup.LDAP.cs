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

	#region Class: LDAPUserInLDAPGroupSchema

	/// <exclude/>
	public class LDAPUserInLDAPGroupSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public LDAPUserInLDAPGroupSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public LDAPUserInLDAPGroupSchema(LDAPUserInLDAPGroupSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public LDAPUserInLDAPGroupSchema(LDAPUserInLDAPGroupSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("5b4fa189-8f4e-44e7-b0b9-2bb16ed96ab6");
			RealUId = new Guid("5b4fa189-8f4e-44e7-b0b9-2bb16ed96ab6");
			Name = "LDAPUserInLDAPGroup";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("e430cf7d-0a41-4669-8668-da1aca11ad49");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("10e3f151-1fb0-4f3a-9c3a-02a77792882c")) == null) {
				Columns.Add(CreateLDAPUserColumn());
			}
			if (Columns.FindByUId(new Guid("55927007-3e61-4aae-a3c8-89576ae87b06")) == null) {
				Columns.Add(CreateLDAPGroupColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateLDAPUserColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("10e3f151-1fb0-4f3a-9c3a-02a77792882c"),
				Name = @"LDAPUser",
				ReferenceSchemaUId = new Guid("2811d726-f327-44be-9548-c8d90edee2cb"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("5b4fa189-8f4e-44e7-b0b9-2bb16ed96ab6"),
				ModifiedInSchemaUId = new Guid("5b4fa189-8f4e-44e7-b0b9-2bb16ed96ab6"),
				CreatedInPackageId = new Guid("e430cf7d-0a41-4669-8668-da1aca11ad49")
			};
		}

		protected virtual EntitySchemaColumn CreateLDAPGroupColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("55927007-3e61-4aae-a3c8-89576ae87b06"),
				Name = @"LDAPGroup",
				ReferenceSchemaUId = new Guid("2811d726-f327-44be-9548-c8d90edee2cb"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("5b4fa189-8f4e-44e7-b0b9-2bb16ed96ab6"),
				ModifiedInSchemaUId = new Guid("5b4fa189-8f4e-44e7-b0b9-2bb16ed96ab6"),
				CreatedInPackageId = new Guid("e430cf7d-0a41-4669-8668-da1aca11ad49")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateLDAPUserInLDAPGroupEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateLDAPUserInLDAPGroupEventsProcessSchema() {
			var schema = new LDAPUserInLDAPGroupEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new LDAPUserInLDAPGroup(userConnection){Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new LDAPUserInLDAPGroup_LDAPEventsProcess(userConnnection);
		}

		public override object Clone() {
			return new LDAPUserInLDAPGroupSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new LDAPUserInLDAPGroupSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5b4fa189-8f4e-44e7-b0b9-2bb16ed96ab6"));
		}

		#endregion

	}

	#endregion

	#region Class: LDAPUserInLDAPGroup

	/// <summary>
	/// LDAP user in LDAP group.
	/// </summary>
	public class LDAPUserInLDAPGroup : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public LDAPUserInLDAPGroup(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "LDAPUserInLDAPGroup";
		}

		public LDAPUserInLDAPGroup(LDAPUserInLDAPGroup source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public  Guid LDAPUserId {
			get {
				return GetTypedColumnValue<Guid>("LDAPUserId");
			}
			set {
				SetColumnValue("LDAPUserId", value);
				_lDAPUser = null;
			}
		}

		/// <exclude/>
		public  string LDAPUserName {
			get {
				return GetTypedColumnValue<string>("LDAPUserName");
			}
			set {
				SetColumnValue("LDAPUserName", value);
				if (_lDAPUser != null) {
					_lDAPUser.Name = value;
				}
			}
		}

		private LDAPElement _lDAPUser;
		/// <summary>
		/// LDAP user.
		/// </summary>
		public  LDAPElement LDAPUser {
			get {
				return _lDAPUser ??
					(_lDAPUser = LookupColumnEntities.GetEntity("LDAPUser") as LDAPElement);
			}
		}

		/// <exclude/>
		public  Guid LDAPGroupId {
			get {
				return GetTypedColumnValue<Guid>("LDAPGroupId");
			}
			set {
				SetColumnValue("LDAPGroupId", value);
				_lDAPGroup = null;
			}
		}

		/// <exclude/>
		public  string LDAPGroupName {
			get {
				return GetTypedColumnValue<string>("LDAPGroupName");
			}
			set {
				SetColumnValue("LDAPGroupName", value);
				if (_lDAPGroup != null) {
					_lDAPGroup.Name = value;
				}
			}
		}

		private LDAPElement _lDAPGroup;
		/// <summary>
		/// LDAP group.
		/// </summary>
		public  LDAPElement LDAPGroup {
			get {
				return _lDAPGroup ??
					(_lDAPGroup = LookupColumnEntities.GetEntity("LDAPGroup") as LDAPElement);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new LDAPUserInLDAPGroup_LDAPEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Validating += (s, e) => ThrowEvent("LDAPUserInLDAPGroupValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new LDAPUserInLDAPGroup(this);
		}

		#endregion

	}

	#endregion

	#region Class: LDAPUserInLDAPGroup_LDAPEventsProcess

	/// <exclude/>
	public class LDAPUserInLDAPGroup_LDAPEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_LocalMessageEventsProcess<TEntity> where TEntity : LDAPUserInLDAPGroup
	{

		public LDAPUserInLDAPGroup_LDAPEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "LDAPUserInLDAPGroup_LDAPEventsProcess";
			SchemaUId = new Guid("5b4fa189-8f4e-44e7-b0b9-2bb16ed96ab6");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private  Guid InternalSchemaUId {
			get {
				return new Guid("5b4fa189-8f4e-44e7-b0b9-2bb16ed96ab6");
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

	#region Class: LDAPUserInLDAPGroup_LDAPEventsProcess

	/// <exclude/>
	public class LDAPUserInLDAPGroup_LDAPEventsProcess : LDAPUserInLDAPGroup_LDAPEventsProcess<LDAPUserInLDAPGroup>
	{

		public LDAPUserInLDAPGroup_LDAPEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: LDAPUserInLDAPGroupEventsProcessSchema

	/// <exclude/>
	public class LDAPUserInLDAPGroupEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public LDAPUserInLDAPGroupEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public LDAPUserInLDAPGroupEventsProcessSchema(LDAPUserInLDAPGroupEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "LDAPUserInLDAPGroup_LDAPEventsProcess";
			UId = new Guid("a278cc45-88fd-4a7c-b68b-f2b7fd355781");
			CreatedInPackageId = new Guid("e430cf7d-0a41-4669-8668-da1aca11ad49");
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
			return new LDAPUserInLDAPGroupEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a278cc45-88fd-4a7c-b68b-f2b7fd355781"));
		}

		#endregion

	}

	#endregion


	#region Class: LDAPUserInLDAPGroupEventsProcess

	/// <exclude/>
	public class LDAPUserInLDAPGroupEventsProcess : LDAPUserInLDAPGroup_LDAPEventsProcess
	{

		public LDAPUserInLDAPGroupEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

