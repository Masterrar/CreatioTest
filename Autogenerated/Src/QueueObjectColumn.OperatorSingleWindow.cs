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

	#region Class: QueueObjectColumnSchema

	/// <exclude/>
	public class QueueObjectColumnSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public QueueObjectColumnSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public QueueObjectColumnSchema(QueueObjectColumnSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public QueueObjectColumnSchema(QueueObjectColumnSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("68bf7df2-6f74-431a-9122-e2cf5edf283b");
			RealUId = new Guid("68bf7df2-6f74-431a-9122-e2cf5edf283b");
			Name = "QueueObjectColumn";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("7be0af39-38cd-442a-b589-d8f3ef3f4d19");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("3222ab43-8455-4fa2-acae-0b760089364a")) == null) {
				Columns.Add(CreateNameColumn());
			}
			if (Columns.FindByUId(new Guid("530ff1cb-3a2d-440d-9e7e-f18b163aa2d4")) == null) {
				Columns.Add(CreateCaptionColumn());
			}
			if (Columns.FindByUId(new Guid("f4b3c5c2-f8ed-4bf6-96c0-a96c436daa12")) == null) {
				Columns.Add(CreateOrderDirectionColumn());
			}
			if (Columns.FindByUId(new Guid("2b3b281f-718b-43f4-a604-45ab2cb8cece")) == null) {
				Columns.Add(CreateQueueObjectColumn());
			}
			if (Columns.FindByUId(new Guid("e7c637f7-b666-48c3-b787-1bfe974ff55a")) == null) {
				Columns.Add(CreatePositionColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("3222ab43-8455-4fa2-acae-0b760089364a"),
				Name = @"Name",
				CreatedInSchemaUId = new Guid("68bf7df2-6f74-431a-9122-e2cf5edf283b"),
				ModifiedInSchemaUId = new Guid("68bf7df2-6f74-431a-9122-e2cf5edf283b"),
				CreatedInPackageId = new Guid("7be0af39-38cd-442a-b589-d8f3ef3f4d19")
			};
		}

		protected virtual EntitySchemaColumn CreateCaptionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("ShortText")) {
				UId = new Guid("530ff1cb-3a2d-440d-9e7e-f18b163aa2d4"),
				Name = @"Caption",
				CreatedInSchemaUId = new Guid("68bf7df2-6f74-431a-9122-e2cf5edf283b"),
				ModifiedInSchemaUId = new Guid("68bf7df2-6f74-431a-9122-e2cf5edf283b"),
				CreatedInPackageId = new Guid("7be0af39-38cd-442a-b589-d8f3ef3f4d19")
			};
		}

		protected virtual EntitySchemaColumn CreateOrderDirectionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("f4b3c5c2-f8ed-4bf6-96c0-a96c436daa12"),
				Name = @"OrderDirection",
				ReferenceSchemaUId = new Guid("a1198732-ee72-49a0-b9e7-2b61461f6122"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("68bf7df2-6f74-431a-9122-e2cf5edf283b"),
				ModifiedInSchemaUId = new Guid("68bf7df2-6f74-431a-9122-e2cf5edf283b"),
				CreatedInPackageId = new Guid("7be0af39-38cd-442a-b589-d8f3ef3f4d19")
			};
		}

		protected virtual EntitySchemaColumn CreateQueueObjectColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("2b3b281f-718b-43f4-a604-45ab2cb8cece"),
				Name = @"QueueObject",
				ReferenceSchemaUId = new Guid("3117ccf2-594f-437b-8ce9-2a97314af997"),
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("68bf7df2-6f74-431a-9122-e2cf5edf283b"),
				ModifiedInSchemaUId = new Guid("68bf7df2-6f74-431a-9122-e2cf5edf283b"),
				CreatedInPackageId = new Guid("7be0af39-38cd-442a-b589-d8f3ef3f4d19")
			};
		}

		protected virtual EntitySchemaColumn CreatePositionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("e7c637f7-b666-48c3-b787-1bfe974ff55a"),
				Name = @"Position",
				CreatedInSchemaUId = new Guid("68bf7df2-6f74-431a-9122-e2cf5edf283b"),
				ModifiedInSchemaUId = new Guid("68bf7df2-6f74-431a-9122-e2cf5edf283b"),
				CreatedInPackageId = new Guid("7be0af39-38cd-442a-b589-d8f3ef3f4d19")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateQueueObjectColumnEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateQueueObjectColumnEventsProcessSchema() {
			var schema = new QueueObjectColumnEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new QueueObjectColumn(userConnection){Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new QueueObjectColumn_OperatorSingleWindowEventsProcess(userConnnection);
		}

		public override object Clone() {
			return new QueueObjectColumnSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new QueueObjectColumnSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("68bf7df2-6f74-431a-9122-e2cf5edf283b"));
		}

		#endregion

	}

	#endregion

	#region Class: QueueObjectColumn

	/// <summary>
	/// Queue object column.
	/// </summary>
	public class QueueObjectColumn : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public QueueObjectColumn(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "QueueObjectColumn";
		}

		public QueueObjectColumn(QueueObjectColumn source)
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

		/// <summary>
		/// Title.
		/// </summary>
		public  string Caption {
			get {
				return GetTypedColumnValue<string>("Caption");
			}
			set {
				SetColumnValue("Caption", value);
			}
		}

		/// <exclude/>
		public  Guid OrderDirectionId {
			get {
				return GetTypedColumnValue<Guid>("OrderDirectionId");
			}
			set {
				SetColumnValue("OrderDirectionId", value);
				_orderDirection = null;
			}
		}

		/// <exclude/>
		public  string OrderDirectionName {
			get {
				return GetTypedColumnValue<string>("OrderDirectionName");
			}
			set {
				SetColumnValue("OrderDirectionName", value);
				if (_orderDirection != null) {
					_orderDirection.Name = value;
				}
			}
		}

		private SysOrderDirection _orderDirection;
		/// <summary>
		/// Sorting order.
		/// </summary>
		public  SysOrderDirection OrderDirection {
			get {
				return _orderDirection ??
					(_orderDirection = LookupColumnEntities.GetEntity("OrderDirection") as SysOrderDirection);
			}
		}

		/// <exclude/>
		public  Guid QueueObjectId {
			get {
				return GetTypedColumnValue<Guid>("QueueObjectId");
			}
			set {
				SetColumnValue("QueueObjectId", value);
				_queueObject = null;
			}
		}

		/// <exclude/>
		public  string QueueObjectEntitySchemaCaption {
			get {
				return GetTypedColumnValue<string>("QueueObjectEntitySchemaCaption");
			}
			set {
				SetColumnValue("QueueObjectEntitySchemaCaption", value);
				if (_queueObject != null) {
					_queueObject.EntitySchemaCaption = value;
				}
			}
		}

		private QueueObject _queueObject;
		/// <summary>
		/// Queue object.
		/// </summary>
		public  QueueObject QueueObject {
			get {
				return _queueObject ??
					(_queueObject = LookupColumnEntities.GetEntity("QueueObject") as QueueObject);
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
			var process = new QueueObjectColumn_OperatorSingleWindowEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Validating += (s, e) => ThrowEvent("QueueObjectColumnValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new QueueObjectColumn(this);
		}

		#endregion

	}

	#endregion

	#region Class: QueueObjectColumn_OperatorSingleWindowEventsProcess

	/// <exclude/>
	public class QueueObjectColumn_OperatorSingleWindowEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_LocalMessageEventsProcess<TEntity> where TEntity : QueueObjectColumn
	{

		public QueueObjectColumn_OperatorSingleWindowEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "QueueObjectColumn_OperatorSingleWindowEventsProcess";
			SchemaUId = new Guid("68bf7df2-6f74-431a-9122-e2cf5edf283b");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private  Guid InternalSchemaUId {
			get {
				return new Guid("68bf7df2-6f74-431a-9122-e2cf5edf283b");
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

	#region Class: QueueObjectColumn_OperatorSingleWindowEventsProcess

	/// <exclude/>
	public class QueueObjectColumn_OperatorSingleWindowEventsProcess : QueueObjectColumn_OperatorSingleWindowEventsProcess<QueueObjectColumn>
	{

		public QueueObjectColumn_OperatorSingleWindowEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: QueueObjectColumnEventsProcessSchema

	/// <exclude/>
	public class QueueObjectColumnEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public QueueObjectColumnEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public QueueObjectColumnEventsProcessSchema(QueueObjectColumnEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "QueueObjectColumn_OperatorSingleWindowEventsProcess";
			UId = new Guid("7b522a90-252e-48f4-a0a4-b3357ca04174");
			CreatedInPackageId = new Guid("7be0af39-38cd-442a-b589-d8f3ef3f4d19");
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
			return new QueueObjectColumnEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("7b522a90-252e-48f4-a0a4-b3357ca04174"));
		}

		#endregion

	}

	#endregion


	#region Class: QueueObjectColumnEventsProcess

	/// <exclude/>
	public class QueueObjectColumnEventsProcess : QueueObjectColumn_OperatorSingleWindowEventsProcess
	{

		public QueueObjectColumnEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

