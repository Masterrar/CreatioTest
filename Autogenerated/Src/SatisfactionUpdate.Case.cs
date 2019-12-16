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

	#region Class: SatisfactionUpdateSchema

	/// <exclude/>
	public class SatisfactionUpdateSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public SatisfactionUpdateSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public SatisfactionUpdateSchema(SatisfactionUpdateSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public SatisfactionUpdateSchema(SatisfactionUpdateSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("baf02fa5-bd26-45bf-b78d-c5eefbffdb24");
			RealUId = new Guid("baf02fa5-bd26-45bf-b78d-c5eefbffdb24");
			Name = "SatisfactionUpdate";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("9141d462-7675-4656-8ea8-25b81010cd22");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("c7d63a2b-e6a8-408b-8bb7-87df2d90fe9f")) == null) {
				Columns.Add(CreateCaseColumn());
			}
			if (Columns.FindByUId(new Guid("5cf5a8e7-42a0-4465-9198-0df25f0f30ee")) == null) {
				Columns.Add(CreatePointColumn());
			}
			if (Columns.FindByUId(new Guid("bbc97078-3ca2-4845-9cb4-c1229e427c92")) == null) {
				Columns.Add(CreateCommentColumn());
			}
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.ModifiedInSchemaUId = new Guid("baf02fa5-bd26-45bf-b78d-c5eefbffdb24");
			column.CreatedInPackageId = new Guid("9141d462-7675-4656-8ea8-25b81010cd22");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.ModifiedInSchemaUId = new Guid("baf02fa5-bd26-45bf-b78d-c5eefbffdb24");
			column.CreatedInPackageId = new Guid("9141d462-7675-4656-8ea8-25b81010cd22");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.ModifiedInSchemaUId = new Guid("baf02fa5-bd26-45bf-b78d-c5eefbffdb24");
			column.CreatedInPackageId = new Guid("9141d462-7675-4656-8ea8-25b81010cd22");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.ModifiedInSchemaUId = new Guid("baf02fa5-bd26-45bf-b78d-c5eefbffdb24");
			column.CreatedInPackageId = new Guid("9141d462-7675-4656-8ea8-25b81010cd22");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.ModifiedInSchemaUId = new Guid("baf02fa5-bd26-45bf-b78d-c5eefbffdb24");
			column.CreatedInPackageId = new Guid("9141d462-7675-4656-8ea8-25b81010cd22");
			return column;
		}

		protected override EntitySchemaColumn CreateProcessListenersColumn() {
			EntitySchemaColumn column = base.CreateProcessListenersColumn();
			column.ModifiedInSchemaUId = new Guid("baf02fa5-bd26-45bf-b78d-c5eefbffdb24");
			column.CreatedInPackageId = new Guid("9141d462-7675-4656-8ea8-25b81010cd22");
			return column;
		}

		protected virtual EntitySchemaColumn CreateCaseColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("c7d63a2b-e6a8-408b-8bb7-87df2d90fe9f"),
				Name = @"Case",
				ReferenceSchemaUId = new Guid("117d32f9-8275-4534-8411-1c66115ce9cd"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("baf02fa5-bd26-45bf-b78d-c5eefbffdb24"),
				ModifiedInSchemaUId = new Guid("baf02fa5-bd26-45bf-b78d-c5eefbffdb24"),
				CreatedInPackageId = new Guid("9141d462-7675-4656-8ea8-25b81010cd22")
			};
		}

		protected virtual EntitySchemaColumn CreatePointColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("5cf5a8e7-42a0-4465-9198-0df25f0f30ee"),
				Name = @"Point",
				CreatedInSchemaUId = new Guid("baf02fa5-bd26-45bf-b78d-c5eefbffdb24"),
				ModifiedInSchemaUId = new Guid("baf02fa5-bd26-45bf-b78d-c5eefbffdb24"),
				CreatedInPackageId = new Guid("9141d462-7675-4656-8ea8-25b81010cd22")
			};
		}

		protected virtual EntitySchemaColumn CreateCommentColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("bbc97078-3ca2-4845-9cb4-c1229e427c92"),
				Name = @"Comment",
				CreatedInSchemaUId = new Guid("baf02fa5-bd26-45bf-b78d-c5eefbffdb24"),
				ModifiedInSchemaUId = new Guid("baf02fa5-bd26-45bf-b78d-c5eefbffdb24"),
				CreatedInPackageId = new Guid("c3c90037-274c-4793-841e-197eb228d3cd")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateSatisfactionUpdateEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateSatisfactionUpdateEventsProcessSchema() {
			var schema = new SatisfactionUpdateEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new SatisfactionUpdate(userConnection){Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new SatisfactionUpdate_CaseEventsProcess(userConnnection);
		}

		public override object Clone() {
			return new SatisfactionUpdateSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new SatisfactionUpdateSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("baf02fa5-bd26-45bf-b78d-c5eefbffdb24"));
		}

		#endregion

	}

	#endregion

	#region Class: SatisfactionUpdate

	/// <summary>
	/// Setting up satisfaction level.
	/// </summary>
	public class SatisfactionUpdate : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public SatisfactionUpdate(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "SatisfactionUpdate";
		}

		public SatisfactionUpdate(SatisfactionUpdate source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public  Guid CaseId {
			get {
				return GetTypedColumnValue<Guid>("CaseId");
			}
			set {
				SetColumnValue("CaseId", value);
				_case = null;
			}
		}

		/// <exclude/>
		public  string CaseNumber {
			get {
				return GetTypedColumnValue<string>("CaseNumber");
			}
			set {
				SetColumnValue("CaseNumber", value);
				if (_case != null) {
					_case.Number = value;
				}
			}
		}

		private Case _case;
		/// <summary>
		/// Case.
		/// </summary>
		public  Case Case {
			get {
				return _case ??
					(_case = LookupColumnEntities.GetEntity("Case") as Case);
			}
		}

		/// <summary>
		/// Rating.
		/// </summary>
		public  int Point {
			get {
				return GetTypedColumnValue<int>("Point");
			}
			set {
				SetColumnValue("Point", value);
			}
		}

		/// <summary>
		/// Comment.
		/// </summary>
		public  string Comment {
			get {
				return GetTypedColumnValue<string>("Comment");
			}
			set {
				SetColumnValue("Comment", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new SatisfactionUpdate_CaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Inserting += (s, e) => ThrowEvent("SatisfactionUpdateInserting", e);
			Validating += (s, e) => ThrowEvent("SatisfactionUpdateValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SatisfactionUpdate(this);
		}

		#endregion

	}

	#endregion

	#region Class: SatisfactionUpdate_CaseEventsProcess

	/// <exclude/>
	public class SatisfactionUpdate_CaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_LocalMessageEventsProcess<TEntity> where TEntity : SatisfactionUpdate
	{

		public SatisfactionUpdate_CaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SatisfactionUpdate_CaseEventsProcess";
			SchemaUId = new Guid("baf02fa5-bd26-45bf-b78d-c5eefbffdb24");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private  Guid InternalSchemaUId {
			get {
				return new Guid("baf02fa5-bd26-45bf-b78d-c5eefbffdb24");
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

	#region Class: SatisfactionUpdate_CaseEventsProcess

	/// <exclude/>
	public class SatisfactionUpdate_CaseEventsProcess : SatisfactionUpdate_CaseEventsProcess<SatisfactionUpdate>
	{

		public SatisfactionUpdate_CaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SatisfactionUpdateEventsProcessSchema

	/// <exclude/>
	public class SatisfactionUpdateEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public SatisfactionUpdateEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public SatisfactionUpdateEventsProcessSchema(SatisfactionUpdateEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "SatisfactionUpdate_CaseEventsProcess";
			UId = new Guid("2b5e0dc5-e77e-471c-8a4b-c8ff8d69438b");
			CreatedInPackageId = new Guid("9141d462-7675-4656-8ea8-25b81010cd22");
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
				CreatedInPackageId = new Guid("9141d462-7675-4656-8ea8-25b81010cd22")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("cde525cf-d220-4d2a-b963-e55254c639fc"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("9141d462-7675-4656-8ea8-25b81010cd22")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5c9c82c6-ba6d-4a57-9a14-87fe8faa4ebb"),
				Name = "Terrasoft.Core.DB",
				Alias = "",
				CreatedInPackageId = new Guid("9141d462-7675-4656-8ea8-25b81010cd22")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7821de68-c82b-4917-a6cd-add2adfbe400"),
				Name = "Terrasoft.Common",
				Alias = "",
				CreatedInPackageId = new Guid("9141d462-7675-4656-8ea8-25b81010cd22")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d67de76f-9cbc-4bfc-babb-6f65cb89b973"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("9141d462-7675-4656-8ea8-25b81010cd22")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("74160d3b-65e3-4694-b554-089f2d980e54"),
				Name = "Newtonsoft.Json",
				Alias = "",
				CreatedInPackageId = new Guid("9141d462-7675-4656-8ea8-25b81010cd22")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e401300a-9f16-40c2-9788-cf310ae9d1c5"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("9141d462-7675-4656-8ea8-25b81010cd22")
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
			return new SatisfactionUpdateEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("2b5e0dc5-e77e-471c-8a4b-c8ff8d69438b"));
		}

		#endregion

	}

	#endregion


	#region Class: SatisfactionUpdateEventsProcess

	/// <exclude/>
	public class SatisfactionUpdateEventsProcess : SatisfactionUpdate_CaseEventsProcess
	{

		public SatisfactionUpdateEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

