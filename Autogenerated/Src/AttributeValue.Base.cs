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

	#region Class: AttributeValueSchema

	/// <exclude/>
	public class AttributeValueSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public AttributeValueSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public AttributeValueSchema(AttributeValueSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public AttributeValueSchema(AttributeValueSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("525c7ade-87a9-4869-b1cb-7c328e9e2338");
			RealUId = new Guid("525c7ade-87a9-4869-b1cb-7c328e9e2338");
			Name = "AttributeValue";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("84b77eaf-13e6-4519-93a8-d0b0954b9dcf")) == null) {
				Columns.Add(CreateRecordColumn());
			}
			if (Columns.FindByUId(new Guid("63d08b83-f226-40f0-8f9f-7e19b75eea5d")) == null) {
				Columns.Add(CreateAttributeColumn());
			}
			if (Columns.FindByUId(new Guid("996b590b-f458-433f-901b-aae9ad08e188")) == null) {
				Columns.Add(CreateTextValueColumn());
			}
			if (Columns.FindByUId(new Guid("713122a3-4d82-41cd-a7a2-2d14ecbb5246")) == null) {
				Columns.Add(CreateIntegerValueColumn());
			}
			if (Columns.FindByUId(new Guid("bb81296f-c5ab-48a2-a49d-3e5bfae7f6dd")) == null) {
				Columns.Add(CreateFloatValueColumn());
			}
			if (Columns.FindByUId(new Guid("cc6ec93d-8501-4554-818d-d8d24198e684")) == null) {
				Columns.Add(CreateBooleanValueColumn());
			}
			if (Columns.FindByUId(new Guid("63943f07-734d-4661-8ca9-92acc9515ff1")) == null) {
				Columns.Add(CreateDateTimeValueColumn());
			}
			if (Columns.FindByUId(new Guid("3312d29c-4a93-4d28-a4e6-ca901a535bb3")) == null) {
				Columns.Add(CreateGuidValueColumn());
			}
			if (Columns.FindByUId(new Guid("c8a8672f-9956-4854-93a3-adc7d6e09407")) == null) {
				Columns.Add(CreateBinaryValueColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateRecordColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("84b77eaf-13e6-4519-93a8-d0b0954b9dcf"),
				Name = @"Record",
				CreatedInSchemaUId = new Guid("525c7ade-87a9-4869-b1cb-7c328e9e2338"),
				ModifiedInSchemaUId = new Guid("525c7ade-87a9-4869-b1cb-7c328e9e2338"),
				CreatedInPackageId = new Guid("773ffacd-4a58-4934-8cb2-5bf23386d08f")
			};
		}

		protected virtual EntitySchemaColumn CreateAttributeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("63d08b83-f226-40f0-8f9f-7e19b75eea5d"),
				Name = @"Attribute",
				ReferenceSchemaUId = new Guid("d37a89fc-7355-4900-aba8-94c22235a9fe"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("525c7ade-87a9-4869-b1cb-7c328e9e2338"),
				ModifiedInSchemaUId = new Guid("525c7ade-87a9-4869-b1cb-7c328e9e2338"),
				CreatedInPackageId = new Guid("773ffacd-4a58-4934-8cb2-5bf23386d08f")
			};
		}

		protected virtual EntitySchemaColumn CreateTextValueColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("996b590b-f458-433f-901b-aae9ad08e188"),
				Name = @"TextValue",
				CreatedInSchemaUId = new Guid("525c7ade-87a9-4869-b1cb-7c328e9e2338"),
				ModifiedInSchemaUId = new Guid("525c7ade-87a9-4869-b1cb-7c328e9e2338"),
				CreatedInPackageId = new Guid("773ffacd-4a58-4934-8cb2-5bf23386d08f")
			};
		}

		protected virtual EntitySchemaColumn CreateIntegerValueColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("713122a3-4d82-41cd-a7a2-2d14ecbb5246"),
				Name = @"IntegerValue",
				CreatedInSchemaUId = new Guid("525c7ade-87a9-4869-b1cb-7c328e9e2338"),
				ModifiedInSchemaUId = new Guid("525c7ade-87a9-4869-b1cb-7c328e9e2338"),
				CreatedInPackageId = new Guid("773ffacd-4a58-4934-8cb2-5bf23386d08f")
			};
		}

		protected virtual EntitySchemaColumn CreateFloatValueColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float2")) {
				UId = new Guid("bb81296f-c5ab-48a2-a49d-3e5bfae7f6dd"),
				Name = @"FloatValue",
				CreatedInSchemaUId = new Guid("525c7ade-87a9-4869-b1cb-7c328e9e2338"),
				ModifiedInSchemaUId = new Guid("525c7ade-87a9-4869-b1cb-7c328e9e2338"),
				CreatedInPackageId = new Guid("773ffacd-4a58-4934-8cb2-5bf23386d08f")
			};
		}

		protected virtual EntitySchemaColumn CreateBooleanValueColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("cc6ec93d-8501-4554-818d-d8d24198e684"),
				Name = @"BooleanValue",
				CreatedInSchemaUId = new Guid("525c7ade-87a9-4869-b1cb-7c328e9e2338"),
				ModifiedInSchemaUId = new Guid("525c7ade-87a9-4869-b1cb-7c328e9e2338"),
				CreatedInPackageId = new Guid("773ffacd-4a58-4934-8cb2-5bf23386d08f")
			};
		}

		protected virtual EntitySchemaColumn CreateDateTimeValueColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("DateTime")) {
				UId = new Guid("63943f07-734d-4661-8ca9-92acc9515ff1"),
				Name = @"DateTimeValue",
				CreatedInSchemaUId = new Guid("525c7ade-87a9-4869-b1cb-7c328e9e2338"),
				ModifiedInSchemaUId = new Guid("525c7ade-87a9-4869-b1cb-7c328e9e2338"),
				CreatedInPackageId = new Guid("773ffacd-4a58-4934-8cb2-5bf23386d08f")
			};
		}

		protected virtual EntitySchemaColumn CreateGuidValueColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("3312d29c-4a93-4d28-a4e6-ca901a535bb3"),
				Name = @"GuidValue",
				CreatedInSchemaUId = new Guid("525c7ade-87a9-4869-b1cb-7c328e9e2338"),
				ModifiedInSchemaUId = new Guid("525c7ade-87a9-4869-b1cb-7c328e9e2338"),
				CreatedInPackageId = new Guid("773ffacd-4a58-4934-8cb2-5bf23386d08f")
			};
		}

		protected virtual EntitySchemaColumn CreateBinaryValueColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Binary")) {
				UId = new Guid("c8a8672f-9956-4854-93a3-adc7d6e09407"),
				Name = @"BinaryValue",
				CreatedInSchemaUId = new Guid("525c7ade-87a9-4869-b1cb-7c328e9e2338"),
				ModifiedInSchemaUId = new Guid("525c7ade-87a9-4869-b1cb-7c328e9e2338"),
				CreatedInPackageId = new Guid("773ffacd-4a58-4934-8cb2-5bf23386d08f")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateAttributeValueEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateAttributeValueEventsProcessSchema() {
			var schema = new AttributeValueEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new AttributeValue(userConnection){Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new AttributeValue_BaseEventsProcess(userConnnection);
		}

		public override object Clone() {
			return new AttributeValueSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new AttributeValueSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("525c7ade-87a9-4869-b1cb-7c328e9e2338"));
		}

		#endregion

	}

	#endregion

	#region Class: AttributeValue

	/// <summary>
	/// Checkbox value.
	/// </summary>
	public class AttributeValue : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public AttributeValue(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "AttributeValue";
		}

		public AttributeValue(AttributeValue source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Record.
		/// </summary>
		public  Guid Record {
			get {
				return GetTypedColumnValue<Guid>("Record");
			}
			set {
				SetColumnValue("Record", value);
			}
		}

		/// <exclude/>
		public  Guid AttributeId {
			get {
				return GetTypedColumnValue<Guid>("AttributeId");
			}
			set {
				SetColumnValue("AttributeId", value);
				_attribute = null;
			}
		}

		/// <exclude/>
		public  string AttributeName {
			get {
				return GetTypedColumnValue<string>("AttributeName");
			}
			set {
				SetColumnValue("AttributeName", value);
				if (_attribute != null) {
					_attribute.Name = value;
				}
			}
		}

		private Attribute _attribute;
		/// <summary>
		/// Checkbox.
		/// </summary>
		public  Attribute Attribute {
			get {
				return _attribute ??
					(_attribute = LookupColumnEntities.GetEntity("Attribute") as Attribute);
			}
		}

		/// <summary>
		/// Text value.
		/// </summary>
		public  string TextValue {
			get {
				return GetTypedColumnValue<string>("TextValue");
			}
			set {
				SetColumnValue("TextValue", value);
			}
		}

		/// <summary>
		/// Integer.
		/// </summary>
		public  int IntegerValue {
			get {
				return GetTypedColumnValue<int>("IntegerValue");
			}
			set {
				SetColumnValue("IntegerValue", value);
			}
		}

		/// <summary>
		/// Decimal value.
		/// </summary>
		public  Decimal FloatValue {
			get {
				return GetTypedColumnValue<Decimal>("FloatValue");
			}
			set {
				SetColumnValue("FloatValue", value);
			}
		}

		/// <summary>
		/// Logic value.
		/// </summary>
		public  bool BooleanValue {
			get {
				return GetTypedColumnValue<bool>("BooleanValue");
			}
			set {
				SetColumnValue("BooleanValue", value);
			}
		}

		/// <summary>
		/// Date and time.
		/// </summary>
		public  DateTime DateTimeValue {
			get {
				return GetTypedColumnValue<DateTime>("DateTimeValue");
			}
			set {
				SetColumnValue("DateTimeValue", value);
			}
		}

		/// <summary>
		/// Unique identifier.
		/// </summary>
		public  Guid GuidValue {
			get {
				return GetTypedColumnValue<Guid>("GuidValue");
			}
			set {
				SetColumnValue("GuidValue", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new AttributeValue_BaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleting += (s, e) => ThrowEvent("AttributeValueDeleting", e);
			Inserted += (s, e) => ThrowEvent("AttributeValueInserted", e);
			Inserting += (s, e) => ThrowEvent("AttributeValueInserting", e);
			Saved += (s, e) => ThrowEvent("AttributeValueSaved", e);
			Saving += (s, e) => ThrowEvent("AttributeValueSaving", e);
			Validating += (s, e) => ThrowEvent("AttributeValueValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new AttributeValue(this);
		}

		#endregion

	}

	#endregion

	#region Class: AttributeValue_BaseEventsProcess

	/// <exclude/>
	public class AttributeValue_BaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_LocalMessageEventsProcess<TEntity> where TEntity : AttributeValue
	{

		public AttributeValue_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "AttributeValue_BaseEventsProcess";
			SchemaUId = new Guid("525c7ade-87a9-4869-b1cb-7c328e9e2338");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private  Guid InternalSchemaUId {
			get {
				return new Guid("525c7ade-87a9-4869-b1cb-7c328e9e2338");
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

	#region Class: AttributeValue_BaseEventsProcess

	/// <exclude/>
	public class AttributeValue_BaseEventsProcess : AttributeValue_BaseEventsProcess<AttributeValue>
	{

		public AttributeValue_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: AttributeValueEventsProcessSchema

	/// <exclude/>
	public class AttributeValueEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public AttributeValueEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public AttributeValueEventsProcessSchema(AttributeValueEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "AttributeValue_BaseEventsProcess";
			UId = new Guid("b772690f-1cf1-457a-ac25-7811f1055130");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = Guid.Empty;
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
			return new AttributeValueEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b772690f-1cf1-457a-ac25-7811f1055130"));
		}

		#endregion

	}

	#endregion


	#region Class: AttributeValueEventsProcess

	/// <exclude/>
	public class AttributeValueEventsProcess : AttributeValue_BaseEventsProcess
	{

		public AttributeValueEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

