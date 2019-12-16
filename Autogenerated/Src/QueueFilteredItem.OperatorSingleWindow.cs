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

	#region Class: QueueFilteredItemSchema

	/// <exclude/>
	public class QueueFilteredItemSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public QueueFilteredItemSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public QueueFilteredItemSchema(QueueFilteredItemSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public QueueFilteredItemSchema(QueueFilteredItemSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private EntitySchemaIndex CreateQueueFilteredEntityIdIndex() {
			EntitySchemaIndex index = new EntitySchemaIndex() {
				IsAutoName = false,
				IsClustered = false,
				IsUnique = false
			};
			index.UId = new Guid("f1e958a3-180e-44de-a210-244b2b32fca7");
			index.Name = "QueueFilteredEntityId";
			index.CreatedInSchemaUId = new Guid("1c3432d0-cd59-4e76-abe7-9a36c698a03e");
			index.ModifiedInSchemaUId = new Guid("1c3432d0-cd59-4e76-abe7-9a36c698a03e");
			index.CreatedInPackageId = new Guid("17d3ccf0-1ef7-49ce-9023-b1aec1bd39b7");
			EntitySchemaIndexColumn entityRecordIdIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("9651e66b-c4b3-48a8-8c5f-6ef2e923d4f7"),
				ColumnUId = new Guid("eb5d3f2f-82cf-42a8-8bbd-e7c98ec69ac4"),
				CreatedInSchemaUId = new Guid("1c3432d0-cd59-4e76-abe7-9a36c698a03e"),
				ModifiedInSchemaUId = new Guid("1c3432d0-cd59-4e76-abe7-9a36c698a03e"),
				CreatedInPackageId = new Guid("17d3ccf0-1ef7-49ce-9023-b1aec1bd39b7"),
				OrderDirection = OrderDirectionStrict.Ascending
			};
			index.Columns.Add(entityRecordIdIndexColumn);
			return index;
		}

		private EntitySchemaIndex CreateQueueFilteredUpdateSessionIdIndex() {
			EntitySchemaIndex index = new EntitySchemaIndex() {
				IsAutoName = false,
				IsClustered = false,
				IsUnique = false
			};
			index.UId = new Guid("1201ede1-36eb-4c7d-b6ca-ccefdf203862");
			index.Name = "QueueFilteredUpdateSessionId";
			index.CreatedInSchemaUId = new Guid("1c3432d0-cd59-4e76-abe7-9a36c698a03e");
			index.ModifiedInSchemaUId = new Guid("1c3432d0-cd59-4e76-abe7-9a36c698a03e");
			index.CreatedInPackageId = new Guid("17d3ccf0-1ef7-49ce-9023-b1aec1bd39b7");
			EntitySchemaIndexColumn updateSessionIdIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("0a1e8edd-3a2d-4eb8-9ee1-991a69d3684e"),
				ColumnUId = new Guid("ab9a7720-1e71-4af1-8af8-3da1d0b8de60"),
				CreatedInSchemaUId = new Guid("1c3432d0-cd59-4e76-abe7-9a36c698a03e"),
				ModifiedInSchemaUId = new Guid("1c3432d0-cd59-4e76-abe7-9a36c698a03e"),
				CreatedInPackageId = new Guid("17d3ccf0-1ef7-49ce-9023-b1aec1bd39b7"),
				OrderDirection = OrderDirectionStrict.Ascending
			};
			index.Columns.Add(updateSessionIdIndexColumn);
			return index;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("1c3432d0-cd59-4e76-abe7-9a36c698a03e");
			RealUId = new Guid("1c3432d0-cd59-4e76-abe7-9a36c698a03e");
			Name = "QueueFilteredItem";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("17d3ccf0-1ef7-49ce-9023-b1aec1bd39b7");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("eb5d3f2f-82cf-42a8-8bbd-e7c98ec69ac4")) == null) {
				Columns.Add(CreateEntityRecordIdColumn());
			}
			if (Columns.FindByUId(new Guid("e2c2d058-141f-413c-8524-ee53b1f5c104")) == null) {
				Columns.Add(CreateQueueColumn());
			}
			if (Columns.FindByUId(new Guid("ab9a7720-1e71-4af1-8af8-3da1d0b8de60")) == null) {
				Columns.Add(CreateUpdateSessionIdColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateEntityRecordIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("eb5d3f2f-82cf-42a8-8bbd-e7c98ec69ac4"),
				Name = @"EntityRecordId",
				CreatedInSchemaUId = new Guid("1c3432d0-cd59-4e76-abe7-9a36c698a03e"),
				ModifiedInSchemaUId = new Guid("1c3432d0-cd59-4e76-abe7-9a36c698a03e"),
				CreatedInPackageId = new Guid("17d3ccf0-1ef7-49ce-9023-b1aec1bd39b7")
			};
		}

		protected virtual EntitySchemaColumn CreateQueueColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("e2c2d058-141f-413c-8524-ee53b1f5c104"),
				Name = @"Queue",
				ReferenceSchemaUId = new Guid("c434cf4e-85f5-48e3-b545-bd3fe9c882ab"),
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("1c3432d0-cd59-4e76-abe7-9a36c698a03e"),
				ModifiedInSchemaUId = new Guid("1c3432d0-cd59-4e76-abe7-9a36c698a03e"),
				CreatedInPackageId = new Guid("17d3ccf0-1ef7-49ce-9023-b1aec1bd39b7")
			};
		}

		protected virtual EntitySchemaColumn CreateUpdateSessionIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("ab9a7720-1e71-4af1-8af8-3da1d0b8de60"),
				Name = @"UpdateSessionId",
				CreatedInSchemaUId = new Guid("1c3432d0-cd59-4e76-abe7-9a36c698a03e"),
				ModifiedInSchemaUId = new Guid("1c3432d0-cd59-4e76-abe7-9a36c698a03e"),
				CreatedInPackageId = new Guid("17d3ccf0-1ef7-49ce-9023-b1aec1bd39b7")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeIndexes() {
			base.InitializeIndexes();
			Indexes.Add(CreateQueueFilteredEntityIdIndex());
			Indexes.Add(CreateQueueFilteredUpdateSessionIdIndex());
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateQueueFilteredItemEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateQueueFilteredItemEventsProcessSchema() {
			var schema = new QueueFilteredItemEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new QueueFilteredItem(userConnection){Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new QueueFilteredItem_OperatorSingleWindowEventsProcess(userConnnection);
		}

		public override object Clone() {
			return new QueueFilteredItemSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new QueueFilteredItemSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("1c3432d0-cd59-4e76-abe7-9a36c698a03e"));
		}

		#endregion

	}

	#endregion

	#region Class: QueueFilteredItem

	/// <summary>
	/// Selected element for queuing.
	/// </summary>
	public class QueueFilteredItem : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public QueueFilteredItem(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "QueueFilteredItem";
		}

		public QueueFilteredItem(QueueFilteredItem source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Related object record Id.
		/// </summary>
		public  Guid EntityRecordId {
			get {
				return GetTypedColumnValue<Guid>("EntityRecordId");
			}
			set {
				SetColumnValue("EntityRecordId", value);
			}
		}

		/// <exclude/>
		public  Guid QueueId {
			get {
				return GetTypedColumnValue<Guid>("QueueId");
			}
			set {
				SetColumnValue("QueueId", value);
				_queue = null;
			}
		}

		/// <exclude/>
		public  string QueueName {
			get {
				return GetTypedColumnValue<string>("QueueName");
			}
			set {
				SetColumnValue("QueueName", value);
				if (_queue != null) {
					_queue.Name = value;
				}
			}
		}

		private Queue _queue;
		/// <summary>
		/// Queue.
		/// </summary>
		public  Queue Queue {
			get {
				return _queue ??
					(_queue = LookupColumnEntities.GetEntity("Queue") as Queue);
			}
		}

		/// <summary>
		/// Queue upload session Id.
		/// </summary>
		public  Guid UpdateSessionId {
			get {
				return GetTypedColumnValue<Guid>("UpdateSessionId");
			}
			set {
				SetColumnValue("UpdateSessionId", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new QueueFilteredItem_OperatorSingleWindowEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Validating += (s, e) => ThrowEvent("QueueFilteredItemValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new QueueFilteredItem(this);
		}

		#endregion

	}

	#endregion

	#region Class: QueueFilteredItem_OperatorSingleWindowEventsProcess

	/// <exclude/>
	public class QueueFilteredItem_OperatorSingleWindowEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_LocalMessageEventsProcess<TEntity> where TEntity : QueueFilteredItem
	{

		public QueueFilteredItem_OperatorSingleWindowEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "QueueFilteredItem_OperatorSingleWindowEventsProcess";
			SchemaUId = new Guid("1c3432d0-cd59-4e76-abe7-9a36c698a03e");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private  Guid InternalSchemaUId {
			get {
				return new Guid("1c3432d0-cd59-4e76-abe7-9a36c698a03e");
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

	#region Class: QueueFilteredItem_OperatorSingleWindowEventsProcess

	/// <exclude/>
	public class QueueFilteredItem_OperatorSingleWindowEventsProcess : QueueFilteredItem_OperatorSingleWindowEventsProcess<QueueFilteredItem>
	{

		public QueueFilteredItem_OperatorSingleWindowEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: QueueFilteredItemEventsProcessSchema

	/// <exclude/>
	public class QueueFilteredItemEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public QueueFilteredItemEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public QueueFilteredItemEventsProcessSchema(QueueFilteredItemEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "QueueFilteredItem_OperatorSingleWindowEventsProcess";
			UId = new Guid("d11caf3e-b8c3-4f3b-8371-a595dd95897b");
			CreatedInPackageId = new Guid("17d3ccf0-1ef7-49ce-9023-b1aec1bd39b7");
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
			return new QueueFilteredItemEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d11caf3e-b8c3-4f3b-8371-a595dd95897b"));
		}

		#endregion

	}

	#endregion


	#region Class: QueueFilteredItemEventsProcess

	/// <exclude/>
	public class QueueFilteredItemEventsProcess : QueueFilteredItem_OperatorSingleWindowEventsProcess
	{

		public QueueFilteredItemEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

