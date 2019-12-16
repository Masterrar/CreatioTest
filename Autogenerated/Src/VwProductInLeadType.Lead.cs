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

	#region Class: VwProductInLeadTypeSchema

	/// <exclude/>
	public class VwProductInLeadTypeSchema : Terrasoft.Configuration.ProductInLeadTypeSchema
	{

		#region Constructors: Public

		public VwProductInLeadTypeSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public VwProductInLeadTypeSchema(VwProductInLeadTypeSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public VwProductInLeadTypeSchema(VwProductInLeadTypeSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("af9496ac-dd52-4411-b90f-1c5270f59bd7");
			RealUId = new Guid("af9496ac-dd52-4411-b90f-1c5270f59bd7");
			Name = "VwProductInLeadType";
			ParentSchemaUId = new Guid("05d4a3f0-34be-4465-aa10-db18f9ec10d1");
			ExtendParent = false;
			CreatedInPackageId = new Guid("f56ba749-b4df-4ded-b740-db30fa3555ae");
			IsDBView = true;
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
			if (Columns.FindByUId(new Guid("d5291c1a-2394-4f21-b24b-e7607cb2b9cf")) == null) {
				Columns.Add(CreateProductTypeInLeadTypeColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("637345a6-9354-4561-a1f7-48702546ff5f"),
				Name = @"Name",
				CreatedInSchemaUId = new Guid("af9496ac-dd52-4411-b90f-1c5270f59bd7"),
				ModifiedInSchemaUId = new Guid("af9496ac-dd52-4411-b90f-1c5270f59bd7"),
				CreatedInPackageId = new Guid("f56ba749-b4df-4ded-b740-db30fa3555ae")
			};
		}

		protected virtual EntitySchemaColumn CreateProductTypeInLeadTypeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("d5291c1a-2394-4f21-b24b-e7607cb2b9cf"),
				Name = @"ProductTypeInLeadType",
				ReferenceSchemaUId = new Guid("50576f45-9a5e-4df8-b7ad-76bcfe5b5073"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("af9496ac-dd52-4411-b90f-1c5270f59bd7"),
				ModifiedInSchemaUId = new Guid("af9496ac-dd52-4411-b90f-1c5270f59bd7"),
				CreatedInPackageId = new Guid("f56ba749-b4df-4ded-b740-db30fa3555ae")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateVwProductInLeadTypeEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateVwProductInLeadTypeEventsProcessSchema() {
			var schema = new VwProductInLeadTypeEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new VwProductInLeadType(userConnection){Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new VwProductInLeadType_LeadEventsProcess(userConnnection);
		}

		public override object Clone() {
			return new VwProductInLeadTypeSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new VwProductInLeadTypeSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("af9496ac-dd52-4411-b90f-1c5270f59bd7"));
		}

		#endregion

	}

	#endregion

	#region Class: VwProductInLeadType

	/// <summary>
	/// Product in need type (view).
	/// </summary>
	public class VwProductInLeadType : Terrasoft.Configuration.ProductInLeadType
	{

		#region Constructors: Public

		public VwProductInLeadType(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "VwProductInLeadType";
		}

		public VwProductInLeadType(VwProductInLeadType source)
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
		public  Guid ProductTypeInLeadTypeId {
			get {
				return GetTypedColumnValue<Guid>("ProductTypeInLeadTypeId");
			}
			set {
				SetColumnValue("ProductTypeInLeadTypeId", value);
				_productTypeInLeadType = null;
			}
		}

		/// <exclude/>
		public  string ProductTypeInLeadTypeName {
			get {
				return GetTypedColumnValue<string>("ProductTypeInLeadTypeName");
			}
			set {
				SetColumnValue("ProductTypeInLeadTypeName", value);
				if (_productTypeInLeadType != null) {
					_productTypeInLeadType.Name = value;
				}
			}
		}

		private ProductTypeInLeadType _productTypeInLeadType;
		/// <summary>
		/// Record type.
		/// </summary>
		public  ProductTypeInLeadType ProductTypeInLeadType {
			get {
				return _productTypeInLeadType ??
					(_productTypeInLeadType = LookupColumnEntities.GetEntity("ProductTypeInLeadType") as ProductTypeInLeadType);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new VwProductInLeadType_LeadEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Inserting += (s, e) => ThrowEvent("VwProductInLeadTypeInserting", e);
			Validating += (s, e) => ThrowEvent("VwProductInLeadTypeValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new VwProductInLeadType(this);
		}

		#endregion

	}

	#endregion

	#region Class: VwProductInLeadType_LeadEventsProcess

	/// <exclude/>
	public class VwProductInLeadType_LeadEventsProcess<TEntity> : Terrasoft.Configuration.ProductInLeadType_LeadEventsProcess<TEntity> where TEntity : VwProductInLeadType
	{

		public VwProductInLeadType_LeadEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "VwProductInLeadType_LeadEventsProcess";
			SchemaUId = new Guid("af9496ac-dd52-4411-b90f-1c5270f59bd7");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private  Guid InternalSchemaUId {
			get {
				return new Guid("af9496ac-dd52-4411-b90f-1c5270f59bd7");
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

	#region Class: VwProductInLeadType_LeadEventsProcess

	/// <exclude/>
	public class VwProductInLeadType_LeadEventsProcess : VwProductInLeadType_LeadEventsProcess<VwProductInLeadType>
	{

		public VwProductInLeadType_LeadEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: VwProductInLeadTypeEventsProcessSchema

	/// <exclude/>
	public class VwProductInLeadTypeEventsProcessSchema : Terrasoft.Configuration.ProductInLeadTypeEventsProcessSchema
	{

		#region Constructors: Public

		public VwProductInLeadTypeEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public VwProductInLeadTypeEventsProcessSchema(VwProductInLeadTypeEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "VwProductInLeadType_LeadEventsProcess";
			UId = new Guid("8cba2e66-b91a-434d-93fa-3439339365fc");
			CreatedInPackageId = new Guid("f56ba749-b4df-4ded-b740-db30fa3555ae");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("357b0e3e-08c8-49a6-b2a1-276202927dd0");
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
				CreatedInPackageId = new Guid("f56ba749-b4df-4ded-b740-db30fa3555ae")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("cde525cf-d220-4d2a-b963-e55254c639fc"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("f56ba749-b4df-4ded-b740-db30fa3555ae")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5c9c82c6-ba6d-4a57-9a14-87fe8faa4ebb"),
				Name = "Terrasoft.Core.DB",
				Alias = "",
				CreatedInPackageId = new Guid("f56ba749-b4df-4ded-b740-db30fa3555ae")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7821de68-c82b-4917-a6cd-add2adfbe400"),
				Name = "Terrasoft.Common",
				Alias = "",
				CreatedInPackageId = new Guid("f56ba749-b4df-4ded-b740-db30fa3555ae")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d67de76f-9cbc-4bfc-babb-6f65cb89b973"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("f56ba749-b4df-4ded-b740-db30fa3555ae")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("74160d3b-65e3-4694-b554-089f2d980e54"),
				Name = "Newtonsoft.Json",
				Alias = "",
				CreatedInPackageId = new Guid("f56ba749-b4df-4ded-b740-db30fa3555ae")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e401300a-9f16-40c2-9788-cf310ae9d1c5"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("f56ba749-b4df-4ded-b740-db30fa3555ae")
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
			return new VwProductInLeadTypeEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("8cba2e66-b91a-434d-93fa-3439339365fc"));
		}

		#endregion

	}

	#endregion


	#region Class: VwProductInLeadTypeEventsProcess

	/// <exclude/>
	public class VwProductInLeadTypeEventsProcess : VwProductInLeadType_LeadEventsProcess
	{

		public VwProductInLeadTypeEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

