﻿namespace Terrasoft.Configuration
{

	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Drawing;
	using System.Globalization;
	using System.IO;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;

	#region Class: VwRecepientEmailSchema

	/// <exclude/>
	public class VwRecepientEmailSchema : Terrasoft.Core.Entities.EntitySchema
	{

		#region Constructors: Public

		public VwRecepientEmailSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public VwRecepientEmailSchema(VwRecepientEmailSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public VwRecepientEmailSchema(VwRecepientEmailSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("7f331863-eb75-41aa-985a-b10e46816ff1");
			RealUId = new Guid("7f331863-eb75-41aa-985a-b10e46816ff1");
			Name = "VwRecepientEmail";
			ParentSchemaUId = new Guid("1b56b061-4e91-4974-9038-df8340e534f2");
			ExtendParent = false;
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			IsDBView = true;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializePrimaryColumn() {
			base.InitializePrimaryColumn();
			PrimaryColumn = CreateIdColumn();
			if (Columns.FindByUId(PrimaryColumn.UId) == null) {
				Columns.Add(PrimaryColumn);
			}
		}

		protected override void InitializePrimaryDisplayColumn() {
			base.InitializePrimaryDisplayColumn();
			PrimaryDisplayColumn = CreateEmailColumn();
			if (Columns.FindByUId(PrimaryDisplayColumn.UId) == null) {
				Columns.Add(PrimaryDisplayColumn);
			}
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("1db938f3-2f12-443e-b910-7413a5b181fd")) == null) {
				Columns.Add(CreateUseEmailColumn());
			}
			if (Columns.FindByUId(new Guid("7854e7eb-ca7f-440b-85e1-fa127ad32ad0")) == null) {
				Columns.Add(CreateContactIdColumn());
			}
			if (Columns.FindByUId(new Guid("16715b3e-14a3-4765-99ee-672af06912e9")) == null) {
				Columns.Add(CreateNumberColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("25081e50-6a41-4795-90b0-f2c5f28c0a42"),
				Name = @"Id",
				CreatedInSchemaUId = new Guid("7f331863-eb75-41aa-985a-b10e46816ff1"),
				ModifiedInSchemaUId = new Guid("7f331863-eb75-41aa-985a-b10e46816ff1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateEmailColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("LongText")) {
				UId = new Guid("cca0c9f5-fc2b-4af2-8e43-324ca65ef9f4"),
				Name = @"Email",
				CreatedInSchemaUId = new Guid("7f331863-eb75-41aa-985a-b10e46816ff1"),
				ModifiedInSchemaUId = new Guid("7f331863-eb75-41aa-985a-b10e46816ff1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateUseEmailColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("1db938f3-2f12-443e-b910-7413a5b181fd"),
				Name = @"UseEmail",
				CreatedInSchemaUId = new Guid("7f331863-eb75-41aa-985a-b10e46816ff1"),
				ModifiedInSchemaUId = new Guid("7f331863-eb75-41aa-985a-b10e46816ff1"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateContactIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("7854e7eb-ca7f-440b-85e1-fa127ad32ad0"),
				Name = @"ContactId",
				CreatedInSchemaUId = new Guid("7f331863-eb75-41aa-985a-b10e46816ff1"),
				ModifiedInSchemaUId = new Guid("7f331863-eb75-41aa-985a-b10e46816ff1"),
				CreatedInPackageId = new Guid("8ffb8aae-210f-49ba-bc7e-e5169edd80e6")
			};
		}

		protected virtual EntitySchemaColumn CreateNumberColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("LongText")) {
				UId = new Guid("16715b3e-14a3-4765-99ee-672af06912e9"),
				Name = @"Number",
				CreatedInSchemaUId = new Guid("7f331863-eb75-41aa-985a-b10e46816ff1"),
				ModifiedInSchemaUId = new Guid("7f331863-eb75-41aa-985a-b10e46816ff1"),
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateVwRecepientEmailEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateVwRecepientEmailEventsProcessSchema() {
			var schema = new VwRecepientEmailEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new VwRecepientEmail(userConnection){Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new VwRecepientEmail_BaseEventsProcess(userConnnection);
		}

		public override object Clone() {
			return new VwRecepientEmailSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new VwRecepientEmailSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("7f331863-eb75-41aa-985a-b10e46816ff1"));
		}

		#endregion

	}

	#endregion

	#region Class: VwRecepientEmail

	/// <summary>
	/// Email addresses.
	/// </summary>
	public class VwRecepientEmail : Terrasoft.Core.Entities.Entity
	{

		#region Constructors: Public

		public VwRecepientEmail(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "VwRecepientEmail";
		}

		public VwRecepientEmail(VwRecepientEmail source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Id.
		/// </summary>
		public  Guid Id {
			get {
				return GetTypedColumnValue<Guid>("Id");
			}
			set {
				SetColumnValue("Id", value);
			}
		}

		/// <summary>
		/// Email.
		/// </summary>
		public  string Email {
			get {
				return GetTypedColumnValue<string>("Email");
			}
			set {
				SetColumnValue("Email", value);
			}
		}

		/// <summary>
		/// Use email.
		/// </summary>
		public  bool UseEmail {
			get {
				return GetTypedColumnValue<bool>("UseEmail");
			}
			set {
				SetColumnValue("UseEmail", value);
			}
		}

		/// <summary>
		/// Contact.
		/// </summary>
		public  Guid ContactId {
			get {
				return GetTypedColumnValue<Guid>("ContactId");
			}
			set {
				SetColumnValue("ContactId", value);
			}
		}

		/// <summary>
		/// Mail address.
		/// </summary>
		public  string Number {
			get {
				return GetTypedColumnValue<string>("Number");
			}
			set {
				SetColumnValue("Number", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new VwRecepientEmail_BaseEventsProcess(UserConnection);
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
			return new VwRecepientEmail(this);
		}

		#endregion

	}

	#endregion

	#region Class: VwRecepientEmail_BaseEventsProcess

	/// <exclude/>
	public class VwRecepientEmail_BaseEventsProcess<TEntity> : Terrasoft.Core.Process.EmbeddedProcess where TEntity : VwRecepientEmail
	{

		private TEntity _entity;
		public  TEntity Entity {
			get {
				return _entity;
			}
			set {
				_entity = value;
			}
		}

		public VwRecepientEmail_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "VwRecepientEmail_BaseEventsProcess";
			SchemaUId = new Guid("7f331863-eb75-41aa-985a-b10e46816ff1");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private  Guid InternalSchemaUId {
			get {
				return new Guid("7f331863-eb75-41aa-985a-b10e46816ff1");
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

	#region Class: VwRecepientEmail_BaseEventsProcess

	/// <exclude/>
	public class VwRecepientEmail_BaseEventsProcess : VwRecepientEmail_BaseEventsProcess<VwRecepientEmail>
	{

		public VwRecepientEmail_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: VwRecepientEmailEventsProcessSchema

	/// <exclude/>
	public class VwRecepientEmailEventsProcessSchema : Terrasoft.Core.Process.EmbeddedProcessSchema
	{

		#region Constructors: Public

		public VwRecepientEmailEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public VwRecepientEmailEventsProcessSchema(VwRecepientEmailEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "VwRecepientEmail_BaseEventsProcess";
			UId = new Guid("a106cbdb-220b-4fb5-a8af-a75711941d86");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d");
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

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new VwRecepientEmailEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a106cbdb-220b-4fb5-a8af-a75711941d86"));
		}

		#endregion

	}

	#endregion


	#region Class: VwRecepientEmailEventsProcess

	/// <exclude/>
	public class VwRecepientEmailEventsProcess : VwRecepientEmail_BaseEventsProcess
	{

		public VwRecepientEmailEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

