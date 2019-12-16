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

	#region Class: VwProcessDashboardSchema

	/// <exclude/>
	public class VwProcessDashboardSchema : Terrasoft.Configuration.VwProcessDashboard_ActionsDashboard_TerrasoftSchema
	{

		#region Constructors: Public

		public VwProcessDashboardSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public VwProcessDashboardSchema(VwProcessDashboardSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public VwProcessDashboardSchema(VwProcessDashboardSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("6061fc3f-7a19-4f8f-b847-eb9e4c15d999");
			Name = "VwProcessDashboard";
			ParentSchemaUId = new Guid("ef3a3dcb-5f88-4af4-9894-1e36c4876085");
			ExtendParent = true;
			CreatedInPackageId = new Guid("6e774b28-4cf2-458d-872b-08ef49cd87a7");
			IsDBView = true;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateVwProcessDashboardEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateVwProcessDashboardEventsProcessSchema() {
			var schema = new VwProcessDashboardEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new VwProcessDashboard(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new VwProcessDashboard_SSPEventsProcess(userConnection);
		}

		public override object Clone() {
			return new VwProcessDashboardSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new VwProcessDashboardSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("6061fc3f-7a19-4f8f-b847-eb9e4c15d999"));
		}

		#endregion

	}

	#endregion

	#region Class: VwProcessDashboard

	/// <summary>
	/// The process dashboard.
	/// </summary>
	public class VwProcessDashboard : Terrasoft.Configuration.VwProcessDashboard_ActionsDashboard_Terrasoft
	{

		#region Constructors: Public

		public VwProcessDashboard(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "VwProcessDashboard";
		}

		public VwProcessDashboard(VwProcessDashboard source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new VwProcessDashboard_SSPEventsProcess(UserConnection);
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
			return new VwProcessDashboard(this);
		}

		#endregion

	}

	#endregion

	#region Class: VwProcessDashboard_SSPEventsProcess

	/// <exclude/>
	public partial class VwProcessDashboard_SSPEventsProcess<TEntity> : Terrasoft.Configuration.VwProcessDashboard_ActionsDashboardEventsProcess<TEntity> where TEntity : VwProcessDashboard
	{

		public VwProcessDashboard_SSPEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "VwProcessDashboard_SSPEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("6061fc3f-7a19-4f8f-b847-eb9e4c15d999");
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

	#region Class: VwProcessDashboard_SSPEventsProcess

	/// <exclude/>
	public class VwProcessDashboard_SSPEventsProcess : VwProcessDashboard_SSPEventsProcess<VwProcessDashboard>
	{

		public VwProcessDashboard_SSPEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: VwProcessDashboard_SSPEventsProcess

	public partial class VwProcessDashboard_SSPEventsProcess<TEntity>
	{

		#region Methods: Public

		#endregion

	}

	#endregion

	#region Class: VwProcessDashboardEventsProcessSchema

	/// <exclude/>
	public class VwProcessDashboardEventsProcessSchema : Terrasoft.Configuration.VwProcessDashboard_ActionsDashboard_TerrasoftEventsProcessSchema
	{

		#region Constructors: Public

		public VwProcessDashboardEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public VwProcessDashboardEventsProcessSchema(VwProcessDashboardEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "VwProcessDashboard_SSPEventsProcess";
			UId = new Guid("d5d041b1-5d08-4c5b-942b-e08acc5867cc");
			CreatedInPackageId = new Guid("6e774b28-4cf2-458d-872b-08ef49cd87a7");
			CreatedInSchemaUId = Guid.Empty;
			CreatedInVersion = @"0.0.0.0";
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("4929fdeb-f5ef-44ad-a3b8-0f153cf4ff45");
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
			return new VwProcessDashboardEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d5d041b1-5d08-4c5b-942b-e08acc5867cc"));
		}

		#endregion

	}

	#endregion


	#region Class: VwProcessDashboardEventsProcess

	/// <exclude/>
	public class VwProcessDashboardEventsProcess : VwProcessDashboard_SSPEventsProcess
	{

		public VwProcessDashboardEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

