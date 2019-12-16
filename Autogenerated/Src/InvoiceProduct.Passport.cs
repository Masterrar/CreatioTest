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

	#region Class: InvoiceProduct_Passport_TerrasoftSchema

	/// <exclude/>
	public class InvoiceProduct_Passport_TerrasoftSchema : Terrasoft.Configuration.InvoiceProduct_Invoice_TerrasoftSchema
	{

		#region Constructors: Public

		public InvoiceProduct_Passport_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public InvoiceProduct_Passport_TerrasoftSchema(InvoiceProduct_Passport_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public InvoiceProduct_Passport_TerrasoftSchema(InvoiceProduct_Passport_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("c9772d92-257a-4e85-b21d-d892bb114e8d");
			Name = "InvoiceProduct_Passport_Terrasoft";
			ParentSchemaUId = new Guid("732baa21-890b-4894-a457-623630e33a6f");
			ExtendParent = true;
			CreatedInPackageId = new Guid("a002bd5f-14f1-4196-ac19-0a0feddeb334");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("be3d1171-3682-44ed-b358-9047a1b13301")) == null) {
				Columns.Add(CreateSupplyPaymentProductColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateSupplyPaymentProductColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("be3d1171-3682-44ed-b358-9047a1b13301"),
				Name = @"SupplyPaymentProduct",
				ReferenceSchemaUId = new Guid("5e50c5fa-41cc-4c91-a04f-9d7888236c1c"),
				IsValueCloneable = false,
				IsIndexed = true,
				IsCascade = true,
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("c9772d92-257a-4e85-b21d-d892bb114e8d"),
				ModifiedInSchemaUId = new Guid("c9772d92-257a-4e85-b21d-d892bb114e8d"),
				CreatedInPackageId = new Guid("a002bd5f-14f1-4196-ac19-0a0feddeb334")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateInvoiceProduct_Passport_TerrasoftEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateInvoiceProduct_Passport_TerrasoftEventsProcessSchema() {
			var schema = new InvoiceProduct_Passport_TerrasoftEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new InvoiceProduct_Passport_Terrasoft(userConnection){Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new InvoiceProduct_PassportEventsProcess(userConnnection);
		}

		public override object Clone() {
			return new InvoiceProduct_Passport_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new InvoiceProduct_Passport_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c9772d92-257a-4e85-b21d-d892bb114e8d"));
		}

		#endregion

	}

	#endregion

	#region Class: InvoiceProduct_Passport_Terrasoft

	/// <summary>
	/// Product in invoice.
	/// </summary>
	public class InvoiceProduct_Passport_Terrasoft : Terrasoft.Configuration.InvoiceProduct_Invoice_Terrasoft
	{

		#region Constructors: Public

		public InvoiceProduct_Passport_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "InvoiceProduct_Passport_Terrasoft";
		}

		public InvoiceProduct_Passport_Terrasoft(InvoiceProduct_Passport_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public  Guid SupplyPaymentProductId {
			get {
				return GetTypedColumnValue<Guid>("SupplyPaymentProductId");
			}
			set {
				SetColumnValue("SupplyPaymentProductId", value);
				_supplyPaymentProduct = null;
			}
		}

		private SupplyPaymentProduct _supplyPaymentProduct;
		/// <summary>
		/// Product in step.
		/// </summary>
		public  SupplyPaymentProduct SupplyPaymentProduct {
			get {
				return _supplyPaymentProduct ??
					(_supplyPaymentProduct = LookupColumnEntities.GetEntity("SupplyPaymentProduct") as SupplyPaymentProduct);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new InvoiceProduct_PassportEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Validating += (s, e) => ThrowEvent("InvoiceProduct_Passport_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new InvoiceProduct_Passport_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: InvoiceProduct_PassportEventsProcess

	/// <exclude/>
	public class InvoiceProduct_PassportEventsProcess<TEntity> : Terrasoft.Configuration.InvoiceProduct_InvoiceEventsProcess<TEntity> where TEntity : InvoiceProduct_Passport_Terrasoft
	{

		public InvoiceProduct_PassportEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "InvoiceProduct_PassportEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private  Guid InternalSchemaUId {
			get {
				return new Guid("c9772d92-257a-4e85-b21d-d892bb114e8d");
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

	#region Class: InvoiceProduct_PassportEventsProcess

	/// <exclude/>
	public class InvoiceProduct_PassportEventsProcess : InvoiceProduct_PassportEventsProcess<InvoiceProduct_Passport_Terrasoft>
	{

		public InvoiceProduct_PassportEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: InvoiceProduct_Passport_TerrasoftEventsProcessSchema

	/// <exclude/>
	public class InvoiceProduct_Passport_TerrasoftEventsProcessSchema : Terrasoft.Configuration.InvoiceProduct_Invoice_TerrasoftEventsProcessSchema
	{

		#region Constructors: Public

		public InvoiceProduct_Passport_TerrasoftEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public InvoiceProduct_Passport_TerrasoftEventsProcessSchema(InvoiceProduct_Passport_TerrasoftEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "InvoiceProduct_PassportEventsProcess";
			UId = new Guid("4e65da61-6844-49e4-8cc6-9f537cd6607e");
			CreatedInPackageId = new Guid("a002bd5f-14f1-4196-ac19-0a0feddeb334");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("e5abce64-9c3a-4284-a869-521d249be745");
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
				UId = new Guid("26b07f07-893c-4fe1-9d1b-dba389348fb5"),
				Name = "Terrasoft.Core.DB",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
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
			return new InvoiceProduct_Passport_TerrasoftEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("4e65da61-6844-49e4-8cc6-9f537cd6607e"));
		}

		#endregion

	}

	#endregion

}

