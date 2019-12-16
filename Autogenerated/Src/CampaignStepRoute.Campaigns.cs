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
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities.Json.Converters;

	#region Class: CampaignStepRouteSchema

	/// <exclude/>
	public class CampaignStepRouteSchema : Terrasoft.Configuration.DiagramElementSchema
	{

		#region Constructors: Public

		public CampaignStepRouteSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public CampaignStepRouteSchema(CampaignStepRouteSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public CampaignStepRouteSchema(CampaignStepRouteSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("6191b3fe-c2d9-4283-964b-cba62823bc40");
			RealUId = new Guid("6191b3fe-c2d9-4283-964b-cba62823bc40");
			Name = "CampaignStepRoute";
			ParentSchemaUId = new Guid("e1b5b3fc-bd8e-4cba-b470-5c2e909dab3e");
			ExtendParent = false;
			CreatedInPackageId = new Guid("5ef8c1cb-e12d-44bb-94fb-8751249ccc2c");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializePrimaryDisplayColumn() {
			base.InitializePrimaryDisplayColumn();
			PrimaryDisplayColumn = CreateTitleColumn();
			if (Columns.FindByUId(PrimaryDisplayColumn.UId) == null) {
				Columns.Add(PrimaryDisplayColumn);
			}
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("a7e4d09c-bcf9-4eb2-bf56-8b82dc4e3be2")) == null) {
				Columns.Add(CreateSourceStepColumn());
			}
			if (Columns.FindByUId(new Guid("a13110b0-abc0-4447-b1c3-f259e8a190d4")) == null) {
				Columns.Add(CreateTargetStepColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateTitleColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("aa25c329-6b1d-4f32-a1f4-9334f24acac4"),
				Name = @"Title",
				CreatedInSchemaUId = new Guid("6191b3fe-c2d9-4283-964b-cba62823bc40"),
				ModifiedInSchemaUId = new Guid("6191b3fe-c2d9-4283-964b-cba62823bc40"),
				CreatedInPackageId = new Guid("5ef8c1cb-e12d-44bb-94fb-8751249ccc2c")
			};
		}

		protected virtual EntitySchemaColumn CreateSourceStepColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("a7e4d09c-bcf9-4eb2-bf56-8b82dc4e3be2"),
				Name = @"SourceStep",
				ReferenceSchemaUId = new Guid("1c6cda37-90f0-4b88-a13c-af0b11cc464f"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("6191b3fe-c2d9-4283-964b-cba62823bc40"),
				ModifiedInSchemaUId = new Guid("6191b3fe-c2d9-4283-964b-cba62823bc40"),
				CreatedInPackageId = new Guid("5ef8c1cb-e12d-44bb-94fb-8751249ccc2c")
			};
		}

		protected virtual EntitySchemaColumn CreateTargetStepColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("a13110b0-abc0-4447-b1c3-f259e8a190d4"),
				Name = @"TargetStep",
				ReferenceSchemaUId = new Guid("1c6cda37-90f0-4b88-a13c-af0b11cc464f"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("6191b3fe-c2d9-4283-964b-cba62823bc40"),
				ModifiedInSchemaUId = new Guid("6191b3fe-c2d9-4283-964b-cba62823bc40"),
				CreatedInPackageId = new Guid("5ef8c1cb-e12d-44bb-94fb-8751249ccc2c")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateCampaignStepRouteEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateCampaignStepRouteEventsProcessSchema() {
			var schema = new CampaignStepRouteEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new CampaignStepRoute(userConnection){Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new CampaignStepRoute_CampaignsEventsProcess(userConnnection);
		}

		public override object Clone() {
			return new CampaignStepRouteSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new CampaignStepRouteSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("6191b3fe-c2d9-4283-964b-cba62823bc40"));
		}

		#endregion

	}

	#endregion

	#region Class: CampaignStepRoute

	/// <summary>
	/// Campaign step guide.
	/// </summary>
	public class CampaignStepRoute : Terrasoft.Configuration.DiagramElement
	{

		#region Constructors: Public

		public CampaignStepRoute(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "CampaignStepRoute";
		}

		public CampaignStepRoute(CampaignStepRoute source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Title.
		/// </summary>
		public  string Title {
			get {
				return GetTypedColumnValue<string>("Title");
			}
			set {
				SetColumnValue("Title", value);
			}
		}

		/// <exclude/>
		public  Guid SourceStepId {
			get {
				return GetTypedColumnValue<Guid>("SourceStepId");
			}
			set {
				SetColumnValue("SourceStepId", value);
				_sourceStep = null;
			}
		}

		/// <exclude/>
		public  string SourceStepTitle {
			get {
				return GetTypedColumnValue<string>("SourceStepTitle");
			}
			set {
				SetColumnValue("SourceStepTitle", value);
				if (_sourceStep != null) {
					_sourceStep.Title = value;
				}
			}
		}

		private CampaignStep _sourceStep;
		/// <summary>
		/// Initial step.
		/// </summary>
		public  CampaignStep SourceStep {
			get {
				return _sourceStep ??
					(_sourceStep = LookupColumnEntities.GetEntity("SourceStep") as CampaignStep);
			}
		}

		/// <exclude/>
		public  Guid TargetStepId {
			get {
				return GetTypedColumnValue<Guid>("TargetStepId");
			}
			set {
				SetColumnValue("TargetStepId", value);
				_targetStep = null;
			}
		}

		/// <exclude/>
		public  string TargetStepTitle {
			get {
				return GetTypedColumnValue<string>("TargetStepTitle");
			}
			set {
				SetColumnValue("TargetStepTitle", value);
				if (_targetStep != null) {
					_targetStep.Title = value;
				}
			}
		}

		private CampaignStep _targetStep;
		/// <summary>
		/// Final step.
		/// </summary>
		public  CampaignStep TargetStep {
			get {
				return _targetStep ??
					(_targetStep = LookupColumnEntities.GetEntity("TargetStep") as CampaignStep);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new CampaignStepRoute_CampaignsEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Loaded += (s, e) => ThrowEvent("CampaignStepRouteLoaded", e);
			Saving += (s, e) => ThrowEvent("CampaignStepRouteSaving", e);
			Validating += (s, e) => ThrowEvent("CampaignStepRouteValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new CampaignStepRoute(this);
		}

		#endregion

	}

	#endregion

	#region Class: CampaignStepRoute_CampaignsEventsProcess

	/// <exclude/>
	public class CampaignStepRoute_CampaignsEventsProcess<TEntity> : Terrasoft.Configuration.DiagramElement_ProcessLibraryEventsProcess<TEntity> where TEntity : CampaignStepRoute
	{

		public CampaignStepRoute_CampaignsEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "CampaignStepRoute_CampaignsEventsProcess";
			SchemaUId = new Guid("6191b3fe-c2d9-4283-964b-cba62823bc40");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			_supportedProperties = () => {{ return "sourcePort,targetPort,addInfo,segments,targetPoint,sourcePoint"; }};
			InitializeFlowElements();
		}

		#region Properties: Private

		private  Guid InternalSchemaUId {
			get {
				return new Guid("6191b3fe-c2d9-4283-964b-cba62823bc40");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		private Func<string> _supportedProperties;
		public override string SupportedProperties {
			get {
				return (_supportedProperties ?? (_supportedProperties = () => null)).Invoke();
			}
			set {
				_supportedProperties = () => { return value; };
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

	#region Class: CampaignStepRoute_CampaignsEventsProcess

	/// <exclude/>
	public class CampaignStepRoute_CampaignsEventsProcess : CampaignStepRoute_CampaignsEventsProcess<CampaignStepRoute>
	{

		public CampaignStepRoute_CampaignsEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: CampaignStepRouteEventsProcessSchema

	/// <exclude/>
	public class CampaignStepRouteEventsProcessSchema : Terrasoft.Configuration.DiagramElementEventsProcessSchema
	{

		#region Constructors: Public

		public CampaignStepRouteEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public CampaignStepRouteEventsProcessSchema(CampaignStepRouteEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "CampaignStepRoute_CampaignsEventsProcess";
			UId = new Guid("7eceb090-5268-4cc3-9610-5a3fd6bd06d1");
			CreatedInPackageId = new Guid("5ef8c1cb-e12d-44bb-94fb-8751249ccc2c");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("e42c262c-387c-49a1-a30f-43fb7c4237a7");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
		}

		protected override ProcessSchemaParameter CreateSupportedPropertiesParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("ec29dad5-6924-41ff-8cf5-dcaf425bbe4e"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("e42c262c-387c-49a1-a30f-43fb7c4237a7"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("e42c262c-387c-49a1-a30f-43fb7c4237a7"),
				Name = @"SupportedProperties",
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("7eceb090-5268-4cc3-9610-5a3fd6bd06d1"),
				},
			};
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
				UId = new Guid("508f7fb7-a5c3-49dd-be14-119dec42069b"),
				Name = "Newtonsoft.Json.Linq",
				Alias = "",
				CreatedInPackageId = new Guid("5ef8c1cb-e12d-44bb-94fb-8751249ccc2c")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("6663ee52-2b09-4be7-94e3-45fb682acae9"),
				Name = "System.Linq",
				Alias = "",
				CreatedInPackageId = new Guid("5ef8c1cb-e12d-44bb-94fb-8751249ccc2c")
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
			return new CampaignStepRouteEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("7eceb090-5268-4cc3-9610-5a3fd6bd06d1"));
		}

		#endregion

	}

	#endregion


	#region Class: CampaignStepRouteEventsProcess

	/// <exclude/>
	public class CampaignStepRouteEventsProcess : CampaignStepRoute_CampaignsEventsProcess
	{

		public CampaignStepRouteEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

