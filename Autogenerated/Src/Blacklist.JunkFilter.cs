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

	#region Class: BlacklistSchema

	/// <exclude/>
	public class BlacklistSchema : Terrasoft.Configuration.BaseLookupSchema
	{

		#region Constructors: Public

		public BlacklistSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public BlacklistSchema(BlacklistSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public BlacklistSchema(BlacklistSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("ec0d54ee-357d-4367-8ea1-badd64dedcd4");
			RealUId = new Guid("ec0d54ee-357d-4367-8ea1-badd64dedcd4");
			Name = "Blacklist";
			ParentSchemaUId = new Guid("11ab4bcb-9b23-4b6d-9c86-520fae925d75");
			ExtendParent = false;
			CreatedInPackageId = new Guid("974b9298-2413-4f75-b309-a858d37c307a");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("19b4b42d-72f0-465a-80b3-599a54ede88f")) == null) {
				Columns.Add(CreateTypeOfFieldColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateTypeOfFieldColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("19b4b42d-72f0-465a-80b3-599a54ede88f"),
				Name = @"TypeOfField",
				ReferenceSchemaUId = new Guid("ba7ed54f-f565-4b27-a99d-99fe6a130b3e"),
				IsIndexed = true,
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("ec0d54ee-357d-4367-8ea1-badd64dedcd4"),
				ModifiedInSchemaUId = new Guid("ec0d54ee-357d-4367-8ea1-badd64dedcd4"),
				CreatedInPackageId = new Guid("974b9298-2413-4f75-b309-a858d37c307a"),
				IsSimpleLookup = true
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateBlacklistEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateBlacklistEventsProcessSchema() {
			var schema = new BlacklistEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new Blacklist(userConnection){Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new Blacklist_JunkFilterEventsProcess(userConnnection);
		}

		public override object Clone() {
			return new BlacklistSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new BlacklistSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ec0d54ee-357d-4367-8ea1-badd64dedcd4"));
		}

		#endregion

	}

	#endregion

	#region Class: Blacklist

	/// <summary>
	/// Blacklist of email addresses and domains for case registration.
	/// </summary>
	public class Blacklist : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public Blacklist(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Blacklist";
		}

		public Blacklist(Blacklist source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public  Guid TypeOfFieldId {
			get {
				return GetTypedColumnValue<Guid>("TypeOfFieldId");
			}
			set {
				SetColumnValue("TypeOfFieldId", value);
				_typeOfField = null;
			}
		}

		/// <exclude/>
		public  string TypeOfFieldName {
			get {
				return GetTypedColumnValue<string>("TypeOfFieldName");
			}
			set {
				SetColumnValue("TypeOfFieldName", value);
				if (_typeOfField != null) {
					_typeOfField.Name = value;
				}
			}
		}

		private JunkFilterTypeOfField _typeOfField;
		/// <summary>
		/// Type of field.
		/// </summary>
		public  JunkFilterTypeOfField TypeOfField {
			get {
				return _typeOfField ??
					(_typeOfField = LookupColumnEntities.GetEntity("TypeOfField") as JunkFilterTypeOfField);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new Blacklist_JunkFilterEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Validating += (s, e) => ThrowEvent("BlacklistValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new Blacklist(this);
		}

		#endregion

	}

	#endregion

	#region Class: Blacklist_JunkFilterEventsProcess

	/// <exclude/>
	public class Blacklist_JunkFilterEventsProcess<TEntity> : Terrasoft.Configuration.BaseLookup_BaseEventsProcess<TEntity> where TEntity : Blacklist
	{

		public Blacklist_JunkFilterEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Blacklist_JunkFilterEventsProcess";
			SchemaUId = new Guid("ec0d54ee-357d-4367-8ea1-badd64dedcd4");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private  Guid InternalSchemaUId {
			get {
				return new Guid("ec0d54ee-357d-4367-8ea1-badd64dedcd4");
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

	#region Class: Blacklist_JunkFilterEventsProcess

	/// <exclude/>
	public class Blacklist_JunkFilterEventsProcess : Blacklist_JunkFilterEventsProcess<Blacklist>
	{

		public Blacklist_JunkFilterEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: BlacklistEventsProcessSchema

	/// <exclude/>
	public class BlacklistEventsProcessSchema : Terrasoft.Configuration.BaseLookupEventsProcessSchema
	{

		#region Constructors: Public

		public BlacklistEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public BlacklistEventsProcessSchema(BlacklistEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "Blacklist_JunkFilterEventsProcess";
			UId = new Guid("0409d9fa-ab06-46a2-ab1b-59d0491e9a1c");
			CreatedInPackageId = new Guid("974b9298-2413-4f75-b309-a858d37c307a");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
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
			return new BlacklistEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("0409d9fa-ab06-46a2-ab1b-59d0491e9a1c"));
		}

		#endregion

	}

	#endregion


	#region Class: BlacklistEventsProcess

	/// <exclude/>
	public class BlacklistEventsProcess : Blacklist_JunkFilterEventsProcess
	{

		public BlacklistEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

