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

	#region Class: CTISearchResultSchema

	/// <exclude/>
	public class CTISearchResultSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public CTISearchResultSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public CTISearchResultSchema(CTISearchResultSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public CTISearchResultSchema(CTISearchResultSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("5698a84b-4500-4a6e-ada2-e6b293327c24");
			RealUId = new Guid("5698a84b-4500-4a6e-ada2-e6b293327c24");
			Name = "CTISearchResult";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("8db6947f-a1e0-41fa-b344-e271842ea6ea");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("d5c928d2-ad4e-49cd-8dbb-4a87679f863d")) == null) {
				Columns.Add(CreateContactColumn());
			}
			if (Columns.FindByUId(new Guid("59c44c04-8ad3-42c2-9c62-37800f62f399")) == null) {
				Columns.Add(CreateAccountColumn());
			}
			if (Columns.FindByUId(new Guid("84e5e215-316b-43d7-a5c3-3838e2f7aa35")) == null) {
				Columns.Add(CreateSearchIdColumn());
			}
			if (Columns.FindByUId(new Guid("c499ab1a-e8d9-4d9e-865b-e72dbfb71847")) == null) {
				Columns.Add(CreateCommunicationTypeColumn());
			}
			if (Columns.FindByUId(new Guid("ed1e7965-6099-4a96-8215-67e87a9f0b38")) == null) {
				Columns.Add(CreateNumberColumn());
			}
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.ModifiedInSchemaUId = new Guid("5698a84b-4500-4a6e-ada2-e6b293327c24");
			column.CreatedInPackageId = new Guid("8db6947f-a1e0-41fa-b344-e271842ea6ea");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.ModifiedInSchemaUId = new Guid("5698a84b-4500-4a6e-ada2-e6b293327c24");
			column.CreatedInPackageId = new Guid("8db6947f-a1e0-41fa-b344-e271842ea6ea");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.ModifiedInSchemaUId = new Guid("5698a84b-4500-4a6e-ada2-e6b293327c24");
			column.CreatedInPackageId = new Guid("8db6947f-a1e0-41fa-b344-e271842ea6ea");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.ModifiedInSchemaUId = new Guid("5698a84b-4500-4a6e-ada2-e6b293327c24");
			column.CreatedInPackageId = new Guid("8db6947f-a1e0-41fa-b344-e271842ea6ea");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.ModifiedInSchemaUId = new Guid("5698a84b-4500-4a6e-ada2-e6b293327c24");
			column.CreatedInPackageId = new Guid("8db6947f-a1e0-41fa-b344-e271842ea6ea");
			return column;
		}

		protected override EntitySchemaColumn CreateProcessListenersColumn() {
			EntitySchemaColumn column = base.CreateProcessListenersColumn();
			column.ModifiedInSchemaUId = new Guid("5698a84b-4500-4a6e-ada2-e6b293327c24");
			column.CreatedInPackageId = new Guid("8db6947f-a1e0-41fa-b344-e271842ea6ea");
			return column;
		}

		protected virtual EntitySchemaColumn CreateContactColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("d5c928d2-ad4e-49cd-8dbb-4a87679f863d"),
				Name = @"Contact",
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("5698a84b-4500-4a6e-ada2-e6b293327c24"),
				ModifiedInSchemaUId = new Guid("5698a84b-4500-4a6e-ada2-e6b293327c24"),
				CreatedInPackageId = new Guid("8db6947f-a1e0-41fa-b344-e271842ea6ea")
			};
		}

		protected virtual EntitySchemaColumn CreateAccountColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("59c44c04-8ad3-42c2-9c62-37800f62f399"),
				Name = @"Account",
				ReferenceSchemaUId = new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e"),
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("5698a84b-4500-4a6e-ada2-e6b293327c24"),
				ModifiedInSchemaUId = new Guid("5698a84b-4500-4a6e-ada2-e6b293327c24"),
				CreatedInPackageId = new Guid("8db6947f-a1e0-41fa-b344-e271842ea6ea")
			};
		}

		protected virtual EntitySchemaColumn CreateSearchIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("84e5e215-316b-43d7-a5c3-3838e2f7aa35"),
				Name = @"SearchId",
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("5698a84b-4500-4a6e-ada2-e6b293327c24"),
				ModifiedInSchemaUId = new Guid("5698a84b-4500-4a6e-ada2-e6b293327c24"),
				CreatedInPackageId = new Guid("8db6947f-a1e0-41fa-b344-e271842ea6ea")
			};
		}

		protected virtual EntitySchemaColumn CreateCommunicationTypeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("c499ab1a-e8d9-4d9e-865b-e72dbfb71847"),
				Name = @"CommunicationType",
				ReferenceSchemaUId = new Guid("d846cb4f-f18d-469e-83ff-e961f3fba873"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("5698a84b-4500-4a6e-ada2-e6b293327c24"),
				ModifiedInSchemaUId = new Guid("5698a84b-4500-4a6e-ada2-e6b293327c24"),
				CreatedInPackageId = new Guid("e19d0b53-b1c2-4c69-a493-d6c3bb8ab730")
			};
		}

		protected virtual EntitySchemaColumn CreateNumberColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("ed1e7965-6099-4a96-8215-67e87a9f0b38"),
				Name = @"Number",
				CreatedInSchemaUId = new Guid("5698a84b-4500-4a6e-ada2-e6b293327c24"),
				ModifiedInSchemaUId = new Guid("5698a84b-4500-4a6e-ada2-e6b293327c24"),
				CreatedInPackageId = new Guid("e19d0b53-b1c2-4c69-a493-d6c3bb8ab730")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateCTISearchResultEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateCTISearchResultEventsProcessSchema() {
			var schema = new CTISearchResultEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new CTISearchResult(userConnection){Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new CTISearchResult_CTIBaseEventsProcess(userConnnection);
		}

		public override object Clone() {
			return new CTISearchResultSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new CTISearchResultSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5698a84b-4500-4a6e-ada2-e6b293327c24"));
		}

		#endregion

	}

	#endregion

	#region Class: CTISearchResult

	/// <summary>
	/// Search result.
	/// </summary>
	public class CTISearchResult : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public CTISearchResult(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "CTISearchResult";
		}

		public CTISearchResult(CTISearchResult source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public  Guid ContactId {
			get {
				return GetTypedColumnValue<Guid>("ContactId");
			}
			set {
				SetColumnValue("ContactId", value);
				_contact = null;
			}
		}

		/// <exclude/>
		public  string ContactName {
			get {
				return GetTypedColumnValue<string>("ContactName");
			}
			set {
				SetColumnValue("ContactName", value);
				if (_contact != null) {
					_contact.Name = value;
				}
			}
		}

		private Contact _contact;
		/// <summary>
		/// Contact.
		/// </summary>
		public  Contact Contact {
			get {
				return _contact ??
					(_contact = LookupColumnEntities.GetEntity("Contact") as Contact);
			}
		}

		/// <exclude/>
		public  Guid AccountId {
			get {
				return GetTypedColumnValue<Guid>("AccountId");
			}
			set {
				SetColumnValue("AccountId", value);
				_account = null;
			}
		}

		/// <exclude/>
		public  string AccountName {
			get {
				return GetTypedColumnValue<string>("AccountName");
			}
			set {
				SetColumnValue("AccountName", value);
				if (_account != null) {
					_account.Name = value;
				}
			}
		}

		private Account _account;
		/// <summary>
		/// Account.
		/// </summary>
		public  Account Account {
			get {
				return _account ??
					(_account = LookupColumnEntities.GetEntity("Account") as Account);
			}
		}

		/// <summary>
		/// Search Id.
		/// </summary>
		public  Guid SearchId {
			get {
				return GetTypedColumnValue<Guid>("SearchId");
			}
			set {
				SetColumnValue("SearchId", value);
			}
		}

		/// <exclude/>
		public  Guid CommunicationTypeId {
			get {
				return GetTypedColumnValue<Guid>("CommunicationTypeId");
			}
			set {
				SetColumnValue("CommunicationTypeId", value);
				_communicationType = null;
			}
		}

		/// <exclude/>
		public  string CommunicationTypeName {
			get {
				return GetTypedColumnValue<string>("CommunicationTypeName");
			}
			set {
				SetColumnValue("CommunicationTypeName", value);
				if (_communicationType != null) {
					_communicationType.Name = value;
				}
			}
		}

		private CommunicationType _communicationType;
		/// <summary>
		/// Communication option type.
		/// </summary>
		public  CommunicationType CommunicationType {
			get {
				return _communicationType ??
					(_communicationType = LookupColumnEntities.GetEntity("CommunicationType") as CommunicationType);
			}
		}

		/// <summary>
		/// Number.
		/// </summary>
		public  string Number {
			get {
				return GetTypedColumnValue<string>("Number");
			}
			set {
				SetColumnValue("Number", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new CTISearchResult_CTIBaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Inserting += (s, e) => ThrowEvent("CTISearchResultInserting", e);
			Validating += (s, e) => ThrowEvent("CTISearchResultValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new CTISearchResult(this);
		}

		#endregion

	}

	#endregion

	#region Class: CTISearchResult_CTIBaseEventsProcess

	/// <exclude/>
	public class CTISearchResult_CTIBaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_LocalMessageEventsProcess<TEntity> where TEntity : CTISearchResult
	{

		public CTISearchResult_CTIBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "CTISearchResult_CTIBaseEventsProcess";
			SchemaUId = new Guid("5698a84b-4500-4a6e-ada2-e6b293327c24");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private  Guid InternalSchemaUId {
			get {
				return new Guid("5698a84b-4500-4a6e-ada2-e6b293327c24");
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

	#region Class: CTISearchResult_CTIBaseEventsProcess

	/// <exclude/>
	public class CTISearchResult_CTIBaseEventsProcess : CTISearchResult_CTIBaseEventsProcess<CTISearchResult>
	{

		public CTISearchResult_CTIBaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: CTISearchResultEventsProcessSchema

	/// <exclude/>
	public class CTISearchResultEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public CTISearchResultEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public CTISearchResultEventsProcessSchema(CTISearchResultEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "CTISearchResult_CTIBaseEventsProcess";
			UId = new Guid("be8dd1d7-de5c-420f-bc8e-4101a9e947c9");
			CreatedInPackageId = new Guid("8db6947f-a1e0-41fa-b344-e271842ea6ea");
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
				CreatedInPackageId = new Guid("8db6947f-a1e0-41fa-b344-e271842ea6ea")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("cde525cf-d220-4d2a-b963-e55254c639fc"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("8db6947f-a1e0-41fa-b344-e271842ea6ea")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5c9c82c6-ba6d-4a57-9a14-87fe8faa4ebb"),
				Name = "Terrasoft.Core.DB",
				Alias = "",
				CreatedInPackageId = new Guid("8db6947f-a1e0-41fa-b344-e271842ea6ea")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7821de68-c82b-4917-a6cd-add2adfbe400"),
				Name = "Terrasoft.Common",
				Alias = "",
				CreatedInPackageId = new Guid("8db6947f-a1e0-41fa-b344-e271842ea6ea")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d67de76f-9cbc-4bfc-babb-6f65cb89b973"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("8db6947f-a1e0-41fa-b344-e271842ea6ea")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("74160d3b-65e3-4694-b554-089f2d980e54"),
				Name = "Newtonsoft.Json",
				Alias = "",
				CreatedInPackageId = new Guid("8db6947f-a1e0-41fa-b344-e271842ea6ea")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e401300a-9f16-40c2-9788-cf310ae9d1c5"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("8db6947f-a1e0-41fa-b344-e271842ea6ea")
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
			return new CTISearchResultEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("be8dd1d7-de5c-420f-bc8e-4101a9e947c9"));
		}

		#endregion

	}

	#endregion


	#region Class: CTISearchResultEventsProcess

	/// <exclude/>
	public class CTISearchResultEventsProcess : CTISearchResult_CTIBaseEventsProcess
	{

		public CTISearchResultEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

