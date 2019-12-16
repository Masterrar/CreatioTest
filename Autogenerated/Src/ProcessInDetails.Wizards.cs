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

	#region Class: ProcessInDetailsSchema

	/// <exclude/>
	public class ProcessInDetailsSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public ProcessInDetailsSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public ProcessInDetailsSchema(ProcessInDetailsSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public ProcessInDetailsSchema(ProcessInDetailsSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("71b8901e-bf90-466c-95a2-7970888556f1");
			RealUId = new Guid("71b8901e-bf90-466c-95a2-7970888556f1");
			Name = "ProcessInDetails";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("b6dd8d56-fd8d-40e5-b50e-aecf2d262cac");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("84fb9a32-2aca-43ff-94b3-b4a4341a661c")) == null) {
				Columns.Add(CreateSysDetailColumn());
			}
			if (Columns.FindByUId(new Guid("7a2937e6-2e2a-490e-9dd9-861310dea9d5")) == null) {
				Columns.Add(CreateSysSchemaUIdColumn());
			}
			if (Columns.FindByUId(new Guid("5a304ad7-4188-4bd4-93d6-dcf9b208637b")) == null) {
				Columns.Add(CreateParameterUIdColumn());
			}
			if (Columns.FindByUId(new Guid("73b7150a-64e1-4276-bd2d-0841d946a4ab")) == null) {
				Columns.Add(CreatePositionColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateSysDetailColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("84fb9a32-2aca-43ff-94b3-b4a4341a661c"),
				Name = @"SysDetail",
				ReferenceSchemaUId = new Guid("363c2008-c733-407d-9b01-9e6a7cd9a77a"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("71b8901e-bf90-466c-95a2-7970888556f1"),
				ModifiedInSchemaUId = new Guid("71b8901e-bf90-466c-95a2-7970888556f1"),
				CreatedInPackageId = new Guid("b6dd8d56-fd8d-40e5-b50e-aecf2d262cac")
			};
		}

		protected virtual EntitySchemaColumn CreateSysSchemaUIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("7a2937e6-2e2a-490e-9dd9-861310dea9d5"),
				Name = @"SysSchemaUId",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("71b8901e-bf90-466c-95a2-7970888556f1"),
				ModifiedInSchemaUId = new Guid("71b8901e-bf90-466c-95a2-7970888556f1"),
				CreatedInPackageId = new Guid("b6dd8d56-fd8d-40e5-b50e-aecf2d262cac")
			};
		}

		protected virtual EntitySchemaColumn CreateParameterUIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("5a304ad7-4188-4bd4-93d6-dcf9b208637b"),
				Name = @"ParameterUId",
				CreatedInSchemaUId = new Guid("71b8901e-bf90-466c-95a2-7970888556f1"),
				ModifiedInSchemaUId = new Guid("71b8901e-bf90-466c-95a2-7970888556f1"),
				CreatedInPackageId = new Guid("b6dd8d56-fd8d-40e5-b50e-aecf2d262cac")
			};
		}

		protected virtual EntitySchemaColumn CreatePositionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("73b7150a-64e1-4276-bd2d-0841d946a4ab"),
				Name = @"Position",
				CreatedInSchemaUId = new Guid("71b8901e-bf90-466c-95a2-7970888556f1"),
				ModifiedInSchemaUId = new Guid("71b8901e-bf90-466c-95a2-7970888556f1"),
				CreatedInPackageId = new Guid("b6dd8d56-fd8d-40e5-b50e-aecf2d262cac")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateProcessInDetailsEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateProcessInDetailsEventsProcessSchema() {
			var schema = new ProcessInDetailsEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new ProcessInDetails(userConnection){Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new ProcessInDetails_WizardsEventsProcess(userConnnection);
		}

		public override object Clone() {
			return new ProcessInDetailsSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new ProcessInDetailsSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("71b8901e-bf90-466c-95a2-7970888556f1"));
		}

		#endregion

	}

	#endregion

	#region Class: ProcessInDetails

	/// <summary>
	/// ProcessInDetails.
	/// </summary>
	public class ProcessInDetails : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public ProcessInDetails(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "ProcessInDetails";
		}

		public ProcessInDetails(ProcessInDetails source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public  Guid SysDetailId {
			get {
				return GetTypedColumnValue<Guid>("SysDetailId");
			}
			set {
				SetColumnValue("SysDetailId", value);
				_sysDetail = null;
			}
		}

		/// <exclude/>
		public  string SysDetailCaption {
			get {
				return GetTypedColumnValue<string>("SysDetailCaption");
			}
			set {
				SetColumnValue("SysDetailCaption", value);
				if (_sysDetail != null) {
					_sysDetail.Caption = value;
				}
			}
		}

		private SysDetail _sysDetail;
		/// <summary>
		/// Detail.
		/// </summary>
		public  SysDetail SysDetail {
			get {
				return _sysDetail ??
					(_sysDetail = LookupColumnEntities.GetEntity("SysDetail") as SysDetail);
			}
		}

		/// <summary>
		/// Process.
		/// </summary>
		public  Guid SysSchemaUId {
			get {
				return GetTypedColumnValue<Guid>("SysSchemaUId");
			}
			set {
				SetColumnValue("SysSchemaUId", value);
			}
		}

		/// <summary>
		/// Parameter.
		/// </summary>
		public  Guid ParameterUId {
			get {
				return GetTypedColumnValue<Guid>("ParameterUId");
			}
			set {
				SetColumnValue("ParameterUId", value);
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

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new ProcessInDetails_WizardsEventsProcess(UserConnection);
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
			return new ProcessInDetails(this);
		}

		#endregion

	}

	#endregion

	#region Class: ProcessInDetails_WizardsEventsProcess

	/// <exclude/>
	public class ProcessInDetails_WizardsEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_LocalMessageEventsProcess<TEntity> where TEntity : ProcessInDetails
	{

		public ProcessInDetails_WizardsEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ProcessInDetails_WizardsEventsProcess";
			SchemaUId = new Guid("71b8901e-bf90-466c-95a2-7970888556f1");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private  Guid InternalSchemaUId {
			get {
				return new Guid("71b8901e-bf90-466c-95a2-7970888556f1");
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

	#region Class: ProcessInDetails_WizardsEventsProcess

	/// <exclude/>
	public class ProcessInDetails_WizardsEventsProcess : ProcessInDetails_WizardsEventsProcess<ProcessInDetails>
	{

		public ProcessInDetails_WizardsEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: ProcessInDetailsEventsProcessSchema

	/// <exclude/>
	public class ProcessInDetailsEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public ProcessInDetailsEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public ProcessInDetailsEventsProcessSchema(ProcessInDetailsEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "ProcessInDetails_WizardsEventsProcess";
			UId = new Guid("81be34b1-ccdb-499a-8ead-e5ef0bdd2457");
			CreatedInPackageId = new Guid("b6dd8d56-fd8d-40e5-b50e-aecf2d262cac");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
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
			return new ProcessInDetailsEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("81be34b1-ccdb-499a-8ead-e5ef0bdd2457"));
		}

		#endregion

	}

	#endregion


	#region Class: ProcessInDetailsEventsProcess

	/// <exclude/>
	public class ProcessInDetailsEventsProcess : ProcessInDetails_WizardsEventsProcess
	{

		public ProcessInDetailsEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

