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

	#region Class: KnowledgeBaseTagSchema

	/// <exclude/>
	public class KnowledgeBaseTagSchema : Terrasoft.Configuration.BaseLookupSchema
	{

		#region Constructors: Public

		public KnowledgeBaseTagSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public KnowledgeBaseTagSchema(KnowledgeBaseTagSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public KnowledgeBaseTagSchema(KnowledgeBaseTagSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("48c6d215-5f38-4967-8482-6b04ba8c0ede");
			RealUId = new Guid("48c6d215-5f38-4967-8482-6b04ba8c0ede");
			Name = "KnowledgeBaseTag";
			ParentSchemaUId = new Guid("11ab4bcb-9b23-4b6d-9c86-520fae925d75");
			ExtendParent = false;
			CreatedInPackageId = new Guid("eb96f059-97b4-4cc9-b308-10d25043227f");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("db4796f0-df36-4617-b0ee-528010b6d262")) == null) {
				Columns.Add(CreateNameENUColumn());
			}
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.ModifiedInSchemaUId = new Guid("48c6d215-5f38-4967-8482-6b04ba8c0ede");
			column.CreatedInPackageId = new Guid("eb96f059-97b4-4cc9-b308-10d25043227f");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.ModifiedInSchemaUId = new Guid("48c6d215-5f38-4967-8482-6b04ba8c0ede");
			column.CreatedInPackageId = new Guid("eb96f059-97b4-4cc9-b308-10d25043227f");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.ModifiedInSchemaUId = new Guid("48c6d215-5f38-4967-8482-6b04ba8c0ede");
			column.CreatedInPackageId = new Guid("eb96f059-97b4-4cc9-b308-10d25043227f");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.ModifiedInSchemaUId = new Guid("48c6d215-5f38-4967-8482-6b04ba8c0ede");
			column.CreatedInPackageId = new Guid("eb96f059-97b4-4cc9-b308-10d25043227f");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.ModifiedInSchemaUId = new Guid("48c6d215-5f38-4967-8482-6b04ba8c0ede");
			column.CreatedInPackageId = new Guid("eb96f059-97b4-4cc9-b308-10d25043227f");
			return column;
		}

		protected override EntitySchemaColumn CreateNameColumn() {
			EntitySchemaColumn column = base.CreateNameColumn();
			column.ModifiedInSchemaUId = new Guid("48c6d215-5f38-4967-8482-6b04ba8c0ede");
			column.CreatedInPackageId = new Guid("eb96f059-97b4-4cc9-b308-10d25043227f");
			return column;
		}

		protected override EntitySchemaColumn CreateDescriptionColumn() {
			EntitySchemaColumn column = base.CreateDescriptionColumn();
			column.ModifiedInSchemaUId = new Guid("48c6d215-5f38-4967-8482-6b04ba8c0ede");
			column.CreatedInPackageId = new Guid("eb96f059-97b4-4cc9-b308-10d25043227f");
			return column;
		}

		protected override EntitySchemaColumn CreateProcessListenersColumn() {
			EntitySchemaColumn column = base.CreateProcessListenersColumn();
			column.ModifiedInSchemaUId = new Guid("48c6d215-5f38-4967-8482-6b04ba8c0ede");
			column.CreatedInPackageId = new Guid("eb96f059-97b4-4cc9-b308-10d25043227f");
			return column;
		}

		protected virtual EntitySchemaColumn CreateNameENUColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("db4796f0-df36-4617-b0ee-528010b6d262"),
				Name = @"NameENU",
				CreatedInSchemaUId = new Guid("48c6d215-5f38-4967-8482-6b04ba8c0ede"),
				ModifiedInSchemaUId = new Guid("48c6d215-5f38-4967-8482-6b04ba8c0ede"),
				CreatedInPackageId = new Guid("eb96f059-97b4-4cc9-b308-10d25043227f")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateKnowledgeBaseTagEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateKnowledgeBaseTagEventsProcessSchema() {
			var schema = new KnowledgeBaseTagEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new KnowledgeBaseTag(userConnection){Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new KnowledgeBaseTag_BaseEventsProcess(userConnnection);
		}

		public override object Clone() {
			return new KnowledgeBaseTagSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new KnowledgeBaseTagSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("48c6d215-5f38-4967-8482-6b04ba8c0ede"));
		}

		#endregion

	}

	#endregion

	#region Class: KnowledgeBaseTag

	/// <summary>
	/// Knowledge base article tag.
	/// </summary>
	public class KnowledgeBaseTag : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public KnowledgeBaseTag(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "KnowledgeBaseTag";
		}

		public KnowledgeBaseTag(KnowledgeBaseTag source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Name ENU.
		/// </summary>
		public  string NameENU {
			get {
				return GetTypedColumnValue<string>("NameENU");
			}
			set {
				SetColumnValue("NameENU", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new KnowledgeBaseTag_BaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Inserting += (s, e) => ThrowEvent("KnowledgeBaseTagInserting", e);
			Validating += (s, e) => ThrowEvent("KnowledgeBaseTagValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new KnowledgeBaseTag(this);
		}

		#endregion

	}

	#endregion

	#region Class: KnowledgeBaseTag_BaseEventsProcess

	/// <exclude/>
	public class KnowledgeBaseTag_BaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseLookup_BaseEventsProcess<TEntity> where TEntity : KnowledgeBaseTag
	{

		public KnowledgeBaseTag_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "KnowledgeBaseTag_BaseEventsProcess";
			SchemaUId = new Guid("48c6d215-5f38-4967-8482-6b04ba8c0ede");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private  Guid InternalSchemaUId {
			get {
				return new Guid("48c6d215-5f38-4967-8482-6b04ba8c0ede");
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

	#region Class: KnowledgeBaseTag_BaseEventsProcess

	/// <exclude/>
	public class KnowledgeBaseTag_BaseEventsProcess : KnowledgeBaseTag_BaseEventsProcess<KnowledgeBaseTag>
	{

		public KnowledgeBaseTag_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: KnowledgeBaseTagEventsProcessSchema

	/// <exclude/>
	public class KnowledgeBaseTagEventsProcessSchema : Terrasoft.Configuration.BaseLookupEventsProcessSchema
	{

		#region Constructors: Public

		public KnowledgeBaseTagEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public KnowledgeBaseTagEventsProcessSchema(KnowledgeBaseTagEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "KnowledgeBaseTag_BaseEventsProcess";
			UId = new Guid("d218a78a-d47d-4c3b-8ab8-58994112e76e");
			CreatedInPackageId = new Guid("eb96f059-97b4-4cc9-b308-10d25043227f");
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
				CreatedInPackageId = new Guid("eb96f059-97b4-4cc9-b308-10d25043227f")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("cde525cf-d220-4d2a-b963-e55254c639fc"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("eb96f059-97b4-4cc9-b308-10d25043227f")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5c9c82c6-ba6d-4a57-9a14-87fe8faa4ebb"),
				Name = "Terrasoft.Core.DB",
				Alias = "",
				CreatedInPackageId = new Guid("eb96f059-97b4-4cc9-b308-10d25043227f")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7821de68-c82b-4917-a6cd-add2adfbe400"),
				Name = "Terrasoft.Common",
				Alias = "",
				CreatedInPackageId = new Guid("eb96f059-97b4-4cc9-b308-10d25043227f")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d67de76f-9cbc-4bfc-babb-6f65cb89b973"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("eb96f059-97b4-4cc9-b308-10d25043227f")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("74160d3b-65e3-4694-b554-089f2d980e54"),
				Name = "Newtonsoft.Json",
				Alias = "",
				CreatedInPackageId = new Guid("eb96f059-97b4-4cc9-b308-10d25043227f")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e401300a-9f16-40c2-9788-cf310ae9d1c5"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("eb96f059-97b4-4cc9-b308-10d25043227f")
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
			return new KnowledgeBaseTagEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d218a78a-d47d-4c3b-8ab8-58994112e76e"));
		}

		#endregion

	}

	#endregion


	#region Class: KnowledgeBaseTagEventsProcess

	/// <exclude/>
	public class KnowledgeBaseTagEventsProcess : KnowledgeBaseTag_BaseEventsProcess
	{

		public KnowledgeBaseTagEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

