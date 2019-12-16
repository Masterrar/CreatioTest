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

	#region Class: VwRemindingsSchema

	/// <exclude/>
	public class VwRemindingsSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public VwRemindingsSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public VwRemindingsSchema(VwRemindingsSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public VwRemindingsSchema(VwRemindingsSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("9e350f30-bb86-4705-953c-b9782d674a71");
			RealUId = new Guid("9e350f30-bb86-4705-953c-b9782d674a71");
			Name = "VwRemindings";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("03471644-00c7-4a31-9ef3-75f255a23c85");
			IsDBView = true;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializePrimaryDisplayColumn() {
			base.InitializePrimaryDisplayColumn();
			PrimaryDisplayColumn = CreateSubjectCaptionColumn();
			if (Columns.FindByUId(PrimaryDisplayColumn.UId) == null) {
				Columns.Add(PrimaryDisplayColumn);
			}
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("6c9806b7-b828-4c39-8669-3f658a4a3ad9")) == null) {
				Columns.Add(CreateContactColumn());
			}
			if (Columns.FindByUId(new Guid("0a71ab58-3ef3-4586-b242-42a240ce0ddb")) == null) {
				Columns.Add(CreateRemindTimeColumn());
			}
			if (Columns.FindByUId(new Guid("eb350498-e740-4ea6-903e-3594053f70ca")) == null) {
				Columns.Add(CreateDescriptionColumn());
			}
			if (Columns.FindByUId(new Guid("7d750350-ae76-4ced-a908-9dd00cda6299")) == null) {
				Columns.Add(CreateSysEntitySchemaIdColumn());
			}
			if (Columns.FindByUId(new Guid("b2b3b857-f90a-43c8-a0f5-6c19925c7e15")) == null) {
				Columns.Add(CreateSubjectIdColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateContactColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("6c9806b7-b828-4c39-8669-3f658a4a3ad9"),
				Name = @"Contact",
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("9e350f30-bb86-4705-953c-b9782d674a71"),
				ModifiedInSchemaUId = new Guid("9e350f30-bb86-4705-953c-b9782d674a71"),
				CreatedInPackageId = new Guid("03471644-00c7-4a31-9ef3-75f255a23c85")
			};
		}

		protected virtual EntitySchemaColumn CreateRemindTimeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("DateTime")) {
				UId = new Guid("0a71ab58-3ef3-4586-b242-42a240ce0ddb"),
				Name = @"RemindTime",
				CreatedInSchemaUId = new Guid("9e350f30-bb86-4705-953c-b9782d674a71"),
				ModifiedInSchemaUId = new Guid("9e350f30-bb86-4705-953c-b9782d674a71"),
				CreatedInPackageId = new Guid("03471644-00c7-4a31-9ef3-75f255a23c85")
			};
		}

		protected virtual EntitySchemaColumn CreateDescriptionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("eb350498-e740-4ea6-903e-3594053f70ca"),
				Name = @"Description",
				CreatedInSchemaUId = new Guid("9e350f30-bb86-4705-953c-b9782d674a71"),
				ModifiedInSchemaUId = new Guid("9e350f30-bb86-4705-953c-b9782d674a71"),
				CreatedInPackageId = new Guid("03471644-00c7-4a31-9ef3-75f255a23c85")
			};
		}

		protected virtual EntitySchemaColumn CreateSysEntitySchemaIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("7d750350-ae76-4ced-a908-9dd00cda6299"),
				Name = @"SysEntitySchemaId",
				CreatedInSchemaUId = new Guid("9e350f30-bb86-4705-953c-b9782d674a71"),
				ModifiedInSchemaUId = new Guid("9e350f30-bb86-4705-953c-b9782d674a71"),
				CreatedInPackageId = new Guid("03471644-00c7-4a31-9ef3-75f255a23c85")
			};
		}

		protected virtual EntitySchemaColumn CreateSubjectCaptionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("LongText")) {
				UId = new Guid("26932511-b06a-483d-8d17-712ebc9dffab"),
				Name = @"SubjectCaption",
				CreatedInSchemaUId = new Guid("9e350f30-bb86-4705-953c-b9782d674a71"),
				ModifiedInSchemaUId = new Guid("9e350f30-bb86-4705-953c-b9782d674a71"),
				CreatedInPackageId = new Guid("03471644-00c7-4a31-9ef3-75f255a23c85")
			};
		}

		protected virtual EntitySchemaColumn CreateSubjectIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("b2b3b857-f90a-43c8-a0f5-6c19925c7e15"),
				Name = @"SubjectId",
				CreatedInSchemaUId = new Guid("9e350f30-bb86-4705-953c-b9782d674a71"),
				ModifiedInSchemaUId = new Guid("9e350f30-bb86-4705-953c-b9782d674a71"),
				CreatedInPackageId = new Guid("03471644-00c7-4a31-9ef3-75f255a23c85")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateVwRemindingsEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateVwRemindingsEventsProcessSchema() {
			var schema = new VwRemindingsEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new VwRemindings(userConnection){Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new VwRemindings_MobileEventsProcess(userConnnection);
		}

		public override object Clone() {
			return new VwRemindingsSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new VwRemindingsSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("9e350f30-bb86-4705-953c-b9782d674a71"));
		}

		#endregion

	}

	#endregion

	#region Class: VwRemindings

	/// <summary>
	/// Notifications (view).
	/// </summary>
	public class VwRemindings : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public VwRemindings(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "VwRemindings";
		}

		public VwRemindings(VwRemindings source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public  Guid ContactId {
			get {
				return GetTypedColumnValue<Guid>("ContactId");
			}
			set {
				SetColumnValue("ContactId", value);
				_contact = null;
			}
		}

		/// <exclude/>
		public  string ContactName {
			get {
				return GetTypedColumnValue<string>("ContactName");
			}
			set {
				SetColumnValue("ContactName", value);
				if (_contact != null) {
					_contact.Name = value;
				}
			}
		}

		private Contact _contact;
		/// <summary>
		/// Contact.
		/// </summary>
		public  Contact Contact {
			get {
				return _contact ??
					(_contact = LookupColumnEntities.GetEntity("Contact") as Contact);
			}
		}

		/// <summary>
		/// Time of reminder.
		/// </summary>
		public  DateTime RemindTime {
			get {
				return GetTypedColumnValue<DateTime>("RemindTime");
			}
			set {
				SetColumnValue("RemindTime", value);
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
		/// Unique identifier of object.
		/// </summary>
		public  Guid SysEntitySchemaId {
			get {
				return GetTypedColumnValue<Guid>("SysEntitySchemaId");
			}
			set {
				SetColumnValue("SysEntitySchemaId", value);
			}
		}

		/// <summary>
		/// Title.
		/// </summary>
		public  string SubjectCaption {
			get {
				return GetTypedColumnValue<string>("SubjectCaption");
			}
			set {
				SetColumnValue("SubjectCaption", value);
			}
		}

		/// <summary>
		/// Unique caption Id.
		/// </summary>
		public  Guid SubjectId {
			get {
				return GetTypedColumnValue<Guid>("SubjectId");
			}
			set {
				SetColumnValue("SubjectId", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new VwRemindings_MobileEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Validating += (s, e) => ThrowEvent("VwRemindingsValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new VwRemindings(this);
		}

		#endregion

	}

	#endregion

	#region Class: VwRemindings_MobileEventsProcess

	/// <exclude/>
	public class VwRemindings_MobileEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_LocalMessageEventsProcess<TEntity> where TEntity : VwRemindings
	{

		public VwRemindings_MobileEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "VwRemindings_MobileEventsProcess";
			SchemaUId = new Guid("9e350f30-bb86-4705-953c-b9782d674a71");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private  Guid InternalSchemaUId {
			get {
				return new Guid("9e350f30-bb86-4705-953c-b9782d674a71");
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

	#region Class: VwRemindings_MobileEventsProcess

	/// <exclude/>
	public class VwRemindings_MobileEventsProcess : VwRemindings_MobileEventsProcess<VwRemindings>
	{

		public VwRemindings_MobileEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: VwRemindingsEventsProcessSchema

	/// <exclude/>
	public class VwRemindingsEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public VwRemindingsEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public VwRemindingsEventsProcessSchema(VwRemindingsEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "VwRemindings_MobileEventsProcess";
			UId = new Guid("8d3aa104-6ba2-423a-b50c-a3b0ef8bc71e");
			CreatedInPackageId = new Guid("03471644-00c7-4a31-9ef3-75f255a23c85");
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
			return new VwRemindingsEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("8d3aa104-6ba2-423a-b50c-a3b0ef8bc71e"));
		}

		#endregion

	}

	#endregion


	#region Class: VwRemindingsEventsProcess

	/// <exclude/>
	public class VwRemindingsEventsProcess : VwRemindings_MobileEventsProcess
	{

		public VwRemindingsEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

