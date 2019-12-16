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
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities.Json.Converters;

	#region Class: SiteEventAttributeSchema

	/// <exclude/>
	public class SiteEventAttributeSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public SiteEventAttributeSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public SiteEventAttributeSchema(SiteEventAttributeSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public SiteEventAttributeSchema(SiteEventAttributeSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f65a195e-31b6-4db8-93a8-e7985f482c14");
			RealUId = new Guid("f65a195e-31b6-4db8-93a8-e7985f482c14");
			Name = "SiteEventAttribute";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("2a23e39e-fab7-43e0-a89e-cc22e5c8d6ed");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializePrimaryDisplayColumn() {
			base.InitializePrimaryDisplayColumn();
			PrimaryDisplayColumn = CreateNameColumn();
			if (Columns.FindByUId(PrimaryDisplayColumn.UId) == null) {
				Columns.Add(PrimaryDisplayColumn);
			}
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("b6b6df82-cfa4-4c02-8a75-3ed7eb1e7ce8")) == null) {
				Columns.Add(CreateTypeColumn());
			}
			if (Columns.FindByUId(new Guid("558b3551-e5d6-438f-b64e-8adc56dac7bf")) == null) {
				Columns.Add(CreateDescriptionColumn());
			}
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.ModifiedInSchemaUId = new Guid("f65a195e-31b6-4db8-93a8-e7985f482c14");
			column.CreatedInPackageId = new Guid("2a23e39e-fab7-43e0-a89e-cc22e5c8d6ed");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.ModifiedInSchemaUId = new Guid("f65a195e-31b6-4db8-93a8-e7985f482c14");
			column.CreatedInPackageId = new Guid("2a23e39e-fab7-43e0-a89e-cc22e5c8d6ed");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.ModifiedInSchemaUId = new Guid("f65a195e-31b6-4db8-93a8-e7985f482c14");
			column.CreatedInPackageId = new Guid("2a23e39e-fab7-43e0-a89e-cc22e5c8d6ed");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.ModifiedInSchemaUId = new Guid("f65a195e-31b6-4db8-93a8-e7985f482c14");
			column.CreatedInPackageId = new Guid("2a23e39e-fab7-43e0-a89e-cc22e5c8d6ed");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.ModifiedInSchemaUId = new Guid("f65a195e-31b6-4db8-93a8-e7985f482c14");
			column.CreatedInPackageId = new Guid("2a23e39e-fab7-43e0-a89e-cc22e5c8d6ed");
			return column;
		}

		protected override EntitySchemaColumn CreateProcessListenersColumn() {
			EntitySchemaColumn column = base.CreateProcessListenersColumn();
			column.ModifiedInSchemaUId = new Guid("f65a195e-31b6-4db8-93a8-e7985f482c14");
			column.CreatedInPackageId = new Guid("2a23e39e-fab7-43e0-a89e-cc22e5c8d6ed");
			return column;
		}

		protected virtual EntitySchemaColumn CreateNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("1ba51632-d95e-42d8-a756-e8bc2fc0bf2e"),
				Name = @"Name",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("f65a195e-31b6-4db8-93a8-e7985f482c14"),
				ModifiedInSchemaUId = new Guid("f65a195e-31b6-4db8-93a8-e7985f482c14"),
				CreatedInPackageId = new Guid("2a23e39e-fab7-43e0-a89e-cc22e5c8d6ed")
			};
		}

		protected virtual EntitySchemaColumn CreateTypeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("b6b6df82-cfa4-4c02-8a75-3ed7eb1e7ce8"),
				Name = @"Type",
				ReferenceSchemaUId = new Guid("32d760d3-5121-4add-97bb-7f8cf2974b52"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("f65a195e-31b6-4db8-93a8-e7985f482c14"),
				ModifiedInSchemaUId = new Guid("f65a195e-31b6-4db8-93a8-e7985f482c14"),
				CreatedInPackageId = new Guid("2a23e39e-fab7-43e0-a89e-cc22e5c8d6ed")
			};
		}

		protected virtual EntitySchemaColumn CreateDescriptionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("LongText")) {
				UId = new Guid("558b3551-e5d6-438f-b64e-8adc56dac7bf"),
				Name = @"Description",
				CreatedInSchemaUId = new Guid("f65a195e-31b6-4db8-93a8-e7985f482c14"),
				ModifiedInSchemaUId = new Guid("f65a195e-31b6-4db8-93a8-e7985f482c14"),
				CreatedInPackageId = new Guid("2a23e39e-fab7-43e0-a89e-cc22e5c8d6ed")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateSiteEventAttributeEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateSiteEventAttributeEventsProcessSchema() {
			var schema = new SiteEventAttributeEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new SiteEventAttribute(userConnection){Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new SiteEventAttribute_SiteEventEventsProcess(userConnnection);
		}

		public override object Clone() {
			return new SiteEventAttributeSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new SiteEventAttributeSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f65a195e-31b6-4db8-93a8-e7985f482c14"));
		}

		#endregion

	}

	#endregion

	#region Class: SiteEventAttribute

	/// <summary>
	/// Website event attribute.
	/// </summary>
	public class SiteEventAttribute : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public SiteEventAttribute(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "SiteEventAttribute";
		}

		public SiteEventAttribute(SiteEventAttribute source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Name.
		/// </summary>
		public  string Name {
			get {
				return GetTypedColumnValue<string>("Name");
			}
			set {
				SetColumnValue("Name", value);
			}
		}

		/// <exclude/>
		public  Guid TypeId {
			get {
				return GetTypedColumnValue<Guid>("TypeId");
			}
			set {
				SetColumnValue("TypeId", value);
				_type = null;
			}
		}

		/// <exclude/>
		public  string TypeName {
			get {
				return GetTypedColumnValue<string>("TypeName");
			}
			set {
				SetColumnValue("TypeName", value);
				if (_type != null) {
					_type.Name = value;
				}
			}
		}

		private SiteEventAttributeType _type;
		/// <summary>
		/// Value type.
		/// </summary>
		public  SiteEventAttributeType Type {
			get {
				return _type ??
					(_type = LookupColumnEntities.GetEntity("Type") as SiteEventAttributeType);
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

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new SiteEventAttribute_SiteEventEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Validating += (s, e) => ThrowEvent("SiteEventAttributeValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SiteEventAttribute(this);
		}

		#endregion

	}

	#endregion

	#region Class: SiteEventAttribute_SiteEventEventsProcess

	/// <exclude/>
	public class SiteEventAttribute_SiteEventEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_LocalMessageEventsProcess<TEntity> where TEntity : SiteEventAttribute
	{

		public SiteEventAttribute_SiteEventEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SiteEventAttribute_SiteEventEventsProcess";
			SchemaUId = new Guid("f65a195e-31b6-4db8-93a8-e7985f482c14");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private  Guid InternalSchemaUId {
			get {
				return new Guid("f65a195e-31b6-4db8-93a8-e7985f482c14");
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

	#region Class: SiteEventAttribute_SiteEventEventsProcess

	/// <exclude/>
	public class SiteEventAttribute_SiteEventEventsProcess : SiteEventAttribute_SiteEventEventsProcess<SiteEventAttribute>
	{

		public SiteEventAttribute_SiteEventEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SiteEventAttributeEventsProcessSchema

	/// <exclude/>
	public class SiteEventAttributeEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public SiteEventAttributeEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public SiteEventAttributeEventsProcessSchema(SiteEventAttributeEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "SiteEventAttribute_SiteEventEventsProcess";
			UId = new Guid("a7865cf7-58ec-4534-9539-efdb522536b5");
			CreatedInPackageId = new Guid("2a23e39e-fab7-43e0-a89e-cc22e5c8d6ed");
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
				CreatedInPackageId = new Guid("2a23e39e-fab7-43e0-a89e-cc22e5c8d6ed")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("cde525cf-d220-4d2a-b963-e55254c639fc"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("2a23e39e-fab7-43e0-a89e-cc22e5c8d6ed")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5c9c82c6-ba6d-4a57-9a14-87fe8faa4ebb"),
				Name = "Terrasoft.Core.DB",
				Alias = "",
				CreatedInPackageId = new Guid("2a23e39e-fab7-43e0-a89e-cc22e5c8d6ed")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7821de68-c82b-4917-a6cd-add2adfbe400"),
				Name = "Terrasoft.Common",
				Alias = "",
				CreatedInPackageId = new Guid("2a23e39e-fab7-43e0-a89e-cc22e5c8d6ed")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d67de76f-9cbc-4bfc-babb-6f65cb89b973"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("2a23e39e-fab7-43e0-a89e-cc22e5c8d6ed")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("74160d3b-65e3-4694-b554-089f2d980e54"),
				Name = "Newtonsoft.Json",
				Alias = "",
				CreatedInPackageId = new Guid("2a23e39e-fab7-43e0-a89e-cc22e5c8d6ed")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e401300a-9f16-40c2-9788-cf310ae9d1c5"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("2a23e39e-fab7-43e0-a89e-cc22e5c8d6ed")
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
			return new SiteEventAttributeEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a7865cf7-58ec-4534-9539-efdb522536b5"));
		}

		#endregion

	}

	#endregion


	#region Class: SiteEventAttributeEventsProcess

	/// <exclude/>
	public class SiteEventAttributeEventsProcess : SiteEventAttribute_SiteEventEventsProcess
	{

		public SiteEventAttributeEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

