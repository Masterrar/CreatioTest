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
	using System.Linq;
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
	using Terrasoft.GlobalSearch.Indexing;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities.Json.Converters;

	#region Class: ReportResourcesSchema

	/// <exclude/>
	public class ReportResourcesSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public ReportResourcesSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public ReportResourcesSchema(ReportResourcesSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public ReportResourcesSchema(ReportResourcesSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("221b168d-c2c7-48e1-89a8-6b8a36a48259");
			RealUId = new Guid("221b168d-c2c7-48e1-89a8-6b8a36a48259");
			Name = "ReportResources";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("bcd7b40a-afa2-4631-8983-51d02c873b88");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("18cd2dcd-c79c-4ad0-8a49-e18317c48161")) == null) {
				Columns.Add(CreateNameColumn());
			}
			if (Columns.FindByUId(new Guid("f2a6338a-e17b-4bf0-a6d7-94bf0dd492bc")) == null) {
				Columns.Add(CreateValueColumn());
			}
			if (Columns.FindByUId(new Guid("79529b13-cf66-4e29-ab25-2bbcfe15d090")) == null) {
				Columns.Add(CreateDevExpressReportColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("18cd2dcd-c79c-4ad0-8a49-e18317c48161"),
				Name = @"Name",
				CreatedInSchemaUId = new Guid("221b168d-c2c7-48e1-89a8-6b8a36a48259"),
				ModifiedInSchemaUId = new Guid("221b168d-c2c7-48e1-89a8-6b8a36a48259"),
				CreatedInPackageId = new Guid("bcd7b40a-afa2-4631-8983-51d02c873b88")
			};
		}

		protected virtual EntitySchemaColumn CreateValueColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("f2a6338a-e17b-4bf0-a6d7-94bf0dd492bc"),
				Name = @"Value",
				CreatedInSchemaUId = new Guid("221b168d-c2c7-48e1-89a8-6b8a36a48259"),
				ModifiedInSchemaUId = new Guid("221b168d-c2c7-48e1-89a8-6b8a36a48259"),
				CreatedInPackageId = new Guid("bcd7b40a-afa2-4631-8983-51d02c873b88"),
				IsLocalizable = true
			};
		}

		protected virtual EntitySchemaColumn CreateDevExpressReportColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("79529b13-cf66-4e29-ab25-2bbcfe15d090"),
				Name = @"DevExpressReport",
				ReferenceSchemaUId = new Guid("e0e6a44f-f3d4-423a-9d01-c5d0c9d3eb64"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("221b168d-c2c7-48e1-89a8-6b8a36a48259"),
				ModifiedInSchemaUId = new Guid("221b168d-c2c7-48e1-89a8-6b8a36a48259"),
				CreatedInPackageId = new Guid("bcd7b40a-afa2-4631-8983-51d02c873b88")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateReportResourcesEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateReportResourcesEventsProcessSchema() {
			var schema = new ReportResourcesEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new ReportResources(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new ReportResources_DevExpressEventsProcess(userConnection);
		}

		public override object Clone() {
			return new ReportResourcesSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new ReportResourcesSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("221b168d-c2c7-48e1-89a8-6b8a36a48259"));
		}

		#endregion

	}

	#endregion

	#region Class: ReportResources

	/// <summary>
	/// DevExpress report resources.
	/// </summary>
	public class ReportResources : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public ReportResources(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "ReportResources";
		}

		public ReportResources(ReportResources source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Name.
		/// </summary>
		public string Name {
			get {
				return GetTypedColumnValue<string>("Name");
			}
			set {
				SetColumnValue("Name", value);
			}
		}

		/// <summary>
		/// Value.
		/// </summary>
		public string Value {
			get {
				return GetTypedColumnValue<string>("Value");
			}
			set {
				SetColumnValue("Value", value);
			}
		}

		/// <exclude/>
		public Guid DevExpressReportId {
			get {
				return GetTypedColumnValue<Guid>("DevExpressReportId");
			}
			set {
				SetColumnValue("DevExpressReportId", value);
				_devExpressReport = null;
			}
		}

		/// <exclude/>
		public string DevExpressReportCaption {
			get {
				return GetTypedColumnValue<string>("DevExpressReportCaption");
			}
			set {
				SetColumnValue("DevExpressReportCaption", value);
				if (_devExpressReport != null) {
					_devExpressReport.Caption = value;
				}
			}
		}

		private DevExpressReport _devExpressReport;
		/// <summary>
		/// DevExpress report.
		/// </summary>
		public DevExpressReport DevExpressReport {
			get {
				return _devExpressReport ??
					(_devExpressReport = LookupColumnEntities.GetEntity("DevExpressReport") as DevExpressReport);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new ReportResources_DevExpressEventsProcess(UserConnection);
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
			return new ReportResources(this);
		}

		#endregion

	}

	#endregion

	#region Class: ReportResources_DevExpressEventsProcess

	/// <exclude/>
	public class ReportResources_DevExpressEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_LocalMessageEventsProcess<TEntity> where TEntity : ReportResources
	{

		public ReportResources_DevExpressEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ReportResources_DevExpressEventsProcess";
			SchemaUId = new Guid("221b168d-c2c7-48e1-89a8-6b8a36a48259");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("221b168d-c2c7-48e1-89a8-6b8a36a48259");
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

	#region Class: ReportResources_DevExpressEventsProcess

	/// <exclude/>
	public class ReportResources_DevExpressEventsProcess : ReportResources_DevExpressEventsProcess<ReportResources>
	{

		public ReportResources_DevExpressEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: ReportResourcesEventsProcessSchema

	/// <exclude/>
	public class ReportResourcesEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public ReportResourcesEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public ReportResourcesEventsProcessSchema(ReportResourcesEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "ReportResources_DevExpressEventsProcess";
			UId = new Guid("1dbd9e11-1b24-4109-ad05-4da41d90413d");
			CreatedInPackageId = new Guid("bcd7b40a-afa2-4631-8983-51d02c873b88");
			CreatedInSchemaUId = Guid.Empty;
			CreatedInVersion = @"0.0.0.0";
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
			Usings.Add(new SchemaUsing() {
				UId = new Guid("aca2294b-e209-4c40-9400-0d59d9ecd1ea"),
				Name = "Terrasoft.GlobalSearch.Indexing",
				Alias = "",
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5410f06b-83f8-43fa-bc49-82a2dd508d3c"),
				Name = "System.Linq",
				Alias = "",
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			});
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new ReportResourcesEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("1dbd9e11-1b24-4109-ad05-4da41d90413d"));
		}

		#endregion

	}

	#endregion


	#region Class: ReportResourcesEventsProcess

	/// <exclude/>
	public class ReportResourcesEventsProcess : ReportResources_DevExpressEventsProcess
	{

		public ReportResourcesEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

