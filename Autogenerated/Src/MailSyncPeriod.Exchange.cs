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

	#region Class: MailSyncPeriodSchema

	/// <exclude/>
	public class MailSyncPeriodSchema : Terrasoft.Configuration.BaseCodeLookupSchema
	{

		#region Constructors: Public

		public MailSyncPeriodSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public MailSyncPeriodSchema(MailSyncPeriodSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public MailSyncPeriodSchema(MailSyncPeriodSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("53c6a358-61c6-4679-a4c3-04d002f423e5");
			RealUId = new Guid("53c6a358-61c6-4679-a4c3-04d002f423e5");
			Name = "MailSyncPeriod";
			ParentSchemaUId = new Guid("2681062b-df59-4e52-89ed-f9b7dc909ab2");
			ExtendParent = false;
			CreatedInPackageId = new Guid("43a72267-b2f6-464f-af52-bc7506959e73");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("35f1cb11-2561-4729-8ddb-51fde1dc9648")) == null) {
				Columns.Add(CreateNumberColumn());
			}
			if (Columns.FindByUId(new Guid("eec3522f-31d8-473e-9469-baaf6cf58b33")) == null) {
				Columns.Add(CreatePositionColumn());
			}
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.ModifiedInSchemaUId = new Guid("53c6a358-61c6-4679-a4c3-04d002f423e5");
			column.CreatedInPackageId = new Guid("43a72267-b2f6-464f-af52-bc7506959e73");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.ModifiedInSchemaUId = new Guid("53c6a358-61c6-4679-a4c3-04d002f423e5");
			column.CreatedInPackageId = new Guid("43a72267-b2f6-464f-af52-bc7506959e73");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.ModifiedInSchemaUId = new Guid("53c6a358-61c6-4679-a4c3-04d002f423e5");
			column.CreatedInPackageId = new Guid("43a72267-b2f6-464f-af52-bc7506959e73");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.ModifiedInSchemaUId = new Guid("53c6a358-61c6-4679-a4c3-04d002f423e5");
			column.CreatedInPackageId = new Guid("43a72267-b2f6-464f-af52-bc7506959e73");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.ModifiedInSchemaUId = new Guid("53c6a358-61c6-4679-a4c3-04d002f423e5");
			column.CreatedInPackageId = new Guid("43a72267-b2f6-464f-af52-bc7506959e73");
			return column;
		}

		protected override EntitySchemaColumn CreateNameColumn() {
			EntitySchemaColumn column = base.CreateNameColumn();
			column.ModifiedInSchemaUId = new Guid("53c6a358-61c6-4679-a4c3-04d002f423e5");
			column.CreatedInPackageId = new Guid("43a72267-b2f6-464f-af52-bc7506959e73");
			return column;
		}

		protected override EntitySchemaColumn CreateDescriptionColumn() {
			EntitySchemaColumn column = base.CreateDescriptionColumn();
			column.ModifiedInSchemaUId = new Guid("53c6a358-61c6-4679-a4c3-04d002f423e5");
			column.CreatedInPackageId = new Guid("43a72267-b2f6-464f-af52-bc7506959e73");
			return column;
		}

		protected override EntitySchemaColumn CreateCodeColumn() {
			EntitySchemaColumn column = base.CreateCodeColumn();
			column.ModifiedInSchemaUId = new Guid("53c6a358-61c6-4679-a4c3-04d002f423e5");
			column.CreatedInPackageId = new Guid("43a72267-b2f6-464f-af52-bc7506959e73");
			return column;
		}

		protected override EntitySchemaColumn CreateProcessListenersColumn() {
			EntitySchemaColumn column = base.CreateProcessListenersColumn();
			column.ModifiedInSchemaUId = new Guid("53c6a358-61c6-4679-a4c3-04d002f423e5");
			column.CreatedInPackageId = new Guid("43a72267-b2f6-464f-af52-bc7506959e73");
			return column;
		}

		protected virtual EntitySchemaColumn CreateNumberColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("35f1cb11-2561-4729-8ddb-51fde1dc9648"),
				Name = @"Number",
				CreatedInSchemaUId = new Guid("53c6a358-61c6-4679-a4c3-04d002f423e5"),
				ModifiedInSchemaUId = new Guid("53c6a358-61c6-4679-a4c3-04d002f423e5"),
				CreatedInPackageId = new Guid("43a72267-b2f6-464f-af52-bc7506959e73")
			};
		}

		protected virtual EntitySchemaColumn CreatePositionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("eec3522f-31d8-473e-9469-baaf6cf58b33"),
				Name = @"Position",
				CreatedInSchemaUId = new Guid("53c6a358-61c6-4679-a4c3-04d002f423e5"),
				ModifiedInSchemaUId = new Guid("53c6a358-61c6-4679-a4c3-04d002f423e5"),
				CreatedInPackageId = new Guid("43a72267-b2f6-464f-af52-bc7506959e73")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateMailSyncPeriodEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateMailSyncPeriodEventsProcessSchema() {
			var schema = new MailSyncPeriodEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new MailSyncPeriod(userConnection){Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new MailSyncPeriod_ExchangeEventsProcess(userConnnection);
		}

		public override object Clone() {
			return new MailSyncPeriodSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new MailSyncPeriodSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("53c6a358-61c6-4679-a4c3-04d002f423e5"));
		}

		#endregion

	}

	#endregion

	#region Class: MailSyncPeriod

	/// <summary>
	/// Email synchronization period.
	/// </summary>
	public class MailSyncPeriod : Terrasoft.Configuration.BaseCodeLookup
	{

		#region Constructors: Public

		public MailSyncPeriod(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "MailSyncPeriod";
		}

		public MailSyncPeriod(MailSyncPeriod source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Quantity.
		/// </summary>
		public  int Number {
			get {
				return GetTypedColumnValue<int>("Number");
			}
			set {
				SetColumnValue("Number", value);
			}
		}

		/// <summary>
		/// Position in the list.
		/// </summary>
		public  int Position {
			get {
				return GetTypedColumnValue<int>("Position");
			}
			set {
				SetColumnValue("Position", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new MailSyncPeriod_ExchangeEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Inserting += (s, e) => ThrowEvent("MailSyncPeriodInserting", e);
			Validating += (s, e) => ThrowEvent("MailSyncPeriodValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new MailSyncPeriod(this);
		}

		#endregion

	}

	#endregion

	#region Class: MailSyncPeriod_ExchangeEventsProcess

	/// <exclude/>
	public class MailSyncPeriod_ExchangeEventsProcess<TEntity> : Terrasoft.Configuration.BaseCodeLookup_BaseEventsProcess<TEntity> where TEntity : MailSyncPeriod
	{

		public MailSyncPeriod_ExchangeEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "MailSyncPeriod_ExchangeEventsProcess";
			SchemaUId = new Guid("53c6a358-61c6-4679-a4c3-04d002f423e5");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private  Guid InternalSchemaUId {
			get {
				return new Guid("53c6a358-61c6-4679-a4c3-04d002f423e5");
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

	#region Class: MailSyncPeriod_ExchangeEventsProcess

	/// <exclude/>
	public class MailSyncPeriod_ExchangeEventsProcess : MailSyncPeriod_ExchangeEventsProcess<MailSyncPeriod>
	{

		public MailSyncPeriod_ExchangeEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: MailSyncPeriodEventsProcessSchema

	/// <exclude/>
	public class MailSyncPeriodEventsProcessSchema : Terrasoft.Configuration.BaseCodeLookupEventsProcessSchema
	{

		#region Constructors: Public

		public MailSyncPeriodEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public MailSyncPeriodEventsProcessSchema(MailSyncPeriodEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "MailSyncPeriod_ExchangeEventsProcess";
			UId = new Guid("68006a0c-b73e-46f0-9eb0-9162c3b74dfa");
			CreatedInPackageId = new Guid("43a72267-b2f6-464f-af52-bc7506959e73");
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
				CreatedInPackageId = new Guid("43a72267-b2f6-464f-af52-bc7506959e73")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("cde525cf-d220-4d2a-b963-e55254c639fc"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("43a72267-b2f6-464f-af52-bc7506959e73")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5c9c82c6-ba6d-4a57-9a14-87fe8faa4ebb"),
				Name = "Terrasoft.Core.DB",
				Alias = "",
				CreatedInPackageId = new Guid("43a72267-b2f6-464f-af52-bc7506959e73")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7821de68-c82b-4917-a6cd-add2adfbe400"),
				Name = "Terrasoft.Common",
				Alias = "",
				CreatedInPackageId = new Guid("43a72267-b2f6-464f-af52-bc7506959e73")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d67de76f-9cbc-4bfc-babb-6f65cb89b973"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("43a72267-b2f6-464f-af52-bc7506959e73")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("74160d3b-65e3-4694-b554-089f2d980e54"),
				Name = "Newtonsoft.Json",
				Alias = "",
				CreatedInPackageId = new Guid("43a72267-b2f6-464f-af52-bc7506959e73")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e401300a-9f16-40c2-9788-cf310ae9d1c5"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("43a72267-b2f6-464f-af52-bc7506959e73")
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
			return new MailSyncPeriodEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("68006a0c-b73e-46f0-9eb0-9162c3b74dfa"));
		}

		#endregion

	}

	#endregion


	#region Class: MailSyncPeriodEventsProcess

	/// <exclude/>
	public class MailSyncPeriodEventsProcess : MailSyncPeriod_ExchangeEventsProcess
	{

		public MailSyncPeriodEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

