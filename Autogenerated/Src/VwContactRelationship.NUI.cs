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

	#region Class: VwContactRelationshipSchema

	/// <exclude/>
	public class VwContactRelationshipSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public VwContactRelationshipSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public VwContactRelationshipSchema(VwContactRelationshipSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public VwContactRelationshipSchema(VwContactRelationshipSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("81743394-e90f-4827-916b-099a9e3e362d");
			RealUId = new Guid("81743394-e90f-4827-916b-099a9e3e362d");
			Name = "VwContactRelationship";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("cd322293-860d-4ac9-8e55-034f9e973ce3");
			IsDBView = true;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("88b2f7d4-a797-4a1b-a99a-a06157360d2e")) == null) {
				Columns.Add(CreateContactColumn());
			}
			if (Columns.FindByUId(new Guid("f6c12ad8-a4b1-4b4b-afc0-632068e1cb76")) == null) {
				Columns.Add(CreateRelatedAccountColumn());
			}
			if (Columns.FindByUId(new Guid("2ae5c9e9-1722-42b6-a15b-23d3612798c7")) == null) {
				Columns.Add(CreateRelatedContactColumn());
			}
			if (Columns.FindByUId(new Guid("dfcd4482-a132-465f-ad8f-7722e95e59b2")) == null) {
				Columns.Add(CreateRelationTypeColumn());
			}
			if (Columns.FindByUId(new Guid("07f57b7f-0c83-4abb-9f9d-90676a5973e4")) == null) {
				Columns.Add(CreateReverseRelationTypeColumn());
			}
			if (Columns.FindByUId(new Guid("27fc328b-e858-4198-8132-3761011c4648")) == null) {
				Columns.Add(CreateActiveColumn());
			}
			if (Columns.FindByUId(new Guid("1fd5a106-dee7-46c9-ba9d-180fe2600e0f")) == null) {
				Columns.Add(CreateDescriptionColumn());
			}
			if (Columns.FindByUId(new Guid("359485d8-203b-43b1-b06b-03cd5beb978c")) == null) {
				Columns.Add(CreateRelatedObjectNameColumn());
			}
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.ModifiedInSchemaUId = new Guid("81743394-e90f-4827-916b-099a9e3e362d");
			column.CreatedInPackageId = new Guid("cd322293-860d-4ac9-8e55-034f9e973ce3");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.ModifiedInSchemaUId = new Guid("81743394-e90f-4827-916b-099a9e3e362d");
			column.CreatedInPackageId = new Guid("cd322293-860d-4ac9-8e55-034f9e973ce3");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.ModifiedInSchemaUId = new Guid("81743394-e90f-4827-916b-099a9e3e362d");
			column.CreatedInPackageId = new Guid("cd322293-860d-4ac9-8e55-034f9e973ce3");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.ModifiedInSchemaUId = new Guid("81743394-e90f-4827-916b-099a9e3e362d");
			column.CreatedInPackageId = new Guid("cd322293-860d-4ac9-8e55-034f9e973ce3");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.ModifiedInSchemaUId = new Guid("81743394-e90f-4827-916b-099a9e3e362d");
			column.CreatedInPackageId = new Guid("cd322293-860d-4ac9-8e55-034f9e973ce3");
			return column;
		}

		protected override EntitySchemaColumn CreateProcessListenersColumn() {
			EntitySchemaColumn column = base.CreateProcessListenersColumn();
			column.ModifiedInSchemaUId = new Guid("81743394-e90f-4827-916b-099a9e3e362d");
			column.CreatedInPackageId = new Guid("cd322293-860d-4ac9-8e55-034f9e973ce3");
			return column;
		}

		protected virtual EntitySchemaColumn CreateContactColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("88b2f7d4-a797-4a1b-a99a-a06157360d2e"),
				Name = @"Contact",
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("81743394-e90f-4827-916b-099a9e3e362d"),
				ModifiedInSchemaUId = new Guid("81743394-e90f-4827-916b-099a9e3e362d"),
				CreatedInPackageId = new Guid("cd322293-860d-4ac9-8e55-034f9e973ce3")
			};
		}

		protected virtual EntitySchemaColumn CreateRelatedAccountColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("f6c12ad8-a4b1-4b4b-afc0-632068e1cb76"),
				Name = @"RelatedAccount",
				ReferenceSchemaUId = new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("81743394-e90f-4827-916b-099a9e3e362d"),
				ModifiedInSchemaUId = new Guid("81743394-e90f-4827-916b-099a9e3e362d"),
				CreatedInPackageId = new Guid("cd322293-860d-4ac9-8e55-034f9e973ce3")
			};
		}

		protected virtual EntitySchemaColumn CreateRelatedContactColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("2ae5c9e9-1722-42b6-a15b-23d3612798c7"),
				Name = @"RelatedContact",
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("81743394-e90f-4827-916b-099a9e3e362d"),
				ModifiedInSchemaUId = new Guid("81743394-e90f-4827-916b-099a9e3e362d"),
				CreatedInPackageId = new Guid("cd322293-860d-4ac9-8e55-034f9e973ce3")
			};
		}

		protected virtual EntitySchemaColumn CreateRelationTypeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("dfcd4482-a132-465f-ad8f-7722e95e59b2"),
				Name = @"RelationType",
				ReferenceSchemaUId = new Guid("fd62ea78-5401-4cbc-8a6c-c87d0c097e23"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("81743394-e90f-4827-916b-099a9e3e362d"),
				ModifiedInSchemaUId = new Guid("81743394-e90f-4827-916b-099a9e3e362d"),
				CreatedInPackageId = new Guid("cd322293-860d-4ac9-8e55-034f9e973ce3")
			};
		}

		protected virtual EntitySchemaColumn CreateReverseRelationTypeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("07f57b7f-0c83-4abb-9f9d-90676a5973e4"),
				Name = @"ReverseRelationType",
				ReferenceSchemaUId = new Guid("fd62ea78-5401-4cbc-8a6c-c87d0c097e23"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("81743394-e90f-4827-916b-099a9e3e362d"),
				ModifiedInSchemaUId = new Guid("81743394-e90f-4827-916b-099a9e3e362d"),
				CreatedInPackageId = new Guid("cd322293-860d-4ac9-8e55-034f9e973ce3")
			};
		}

		protected virtual EntitySchemaColumn CreateActiveColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("27fc328b-e858-4198-8132-3761011c4648"),
				Name = @"Active",
				CreatedInSchemaUId = new Guid("81743394-e90f-4827-916b-099a9e3e362d"),
				ModifiedInSchemaUId = new Guid("81743394-e90f-4827-916b-099a9e3e362d"),
				CreatedInPackageId = new Guid("cd322293-860d-4ac9-8e55-034f9e973ce3")
			};
		}

		protected virtual EntitySchemaColumn CreateDescriptionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("LongText")) {
				UId = new Guid("1fd5a106-dee7-46c9-ba9d-180fe2600e0f"),
				Name = @"Description",
				CreatedInSchemaUId = new Guid("81743394-e90f-4827-916b-099a9e3e362d"),
				ModifiedInSchemaUId = new Guid("81743394-e90f-4827-916b-099a9e3e362d"),
				CreatedInPackageId = new Guid("cd322293-860d-4ac9-8e55-034f9e973ce3")
			};
		}

		protected virtual EntitySchemaColumn CreateRelatedObjectNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("359485d8-203b-43b1-b06b-03cd5beb978c"),
				Name = @"RelatedObjectName",
				CreatedInSchemaUId = new Guid("81743394-e90f-4827-916b-099a9e3e362d"),
				ModifiedInSchemaUId = new Guid("81743394-e90f-4827-916b-099a9e3e362d"),
				CreatedInPackageId = new Guid("6919e88d-10ea-487b-a245-20d0cd99bafd")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateVwContactRelationshipEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateVwContactRelationshipEventsProcessSchema() {
			var schema = new VwContactRelationshipEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new VwContactRelationship(userConnection){Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new VwContactRelationship_NUIEventsProcess(userConnnection);
		}

		public override object Clone() {
			return new VwContactRelationshipSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new VwContactRelationshipSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("81743394-e90f-4827-916b-099a9e3e362d"));
		}

		#endregion

	}

	#endregion

	#region Class: VwContactRelationship

	/// <summary>
	/// Relationship of contact (view).
	/// </summary>
	public class VwContactRelationship : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public VwContactRelationship(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "VwContactRelationship";
		}

		public VwContactRelationship(VwContactRelationship source)
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
		public  Guid RelatedAccountId {
			get {
				return GetTypedColumnValue<Guid>("RelatedAccountId");
			}
			set {
				SetColumnValue("RelatedAccountId", value);
				_relatedAccount = null;
			}
		}

		/// <exclude/>
		public  string RelatedAccountName {
			get {
				return GetTypedColumnValue<string>("RelatedAccountName");
			}
			set {
				SetColumnValue("RelatedAccountName", value);
				if (_relatedAccount != null) {
					_relatedAccount.Name = value;
				}
			}
		}

		private Account _relatedAccount;
		/// <summary>
		/// Connected account.
		/// </summary>
		public  Account RelatedAccount {
			get {
				return _relatedAccount ??
					(_relatedAccount = LookupColumnEntities.GetEntity("RelatedAccount") as Account);
			}
		}

		/// <exclude/>
		public  Guid RelatedContactId {
			get {
				return GetTypedColumnValue<Guid>("RelatedContactId");
			}
			set {
				SetColumnValue("RelatedContactId", value);
				_relatedContact = null;
			}
		}

		/// <exclude/>
		public  string RelatedContactName {
			get {
				return GetTypedColumnValue<string>("RelatedContactName");
			}
			set {
				SetColumnValue("RelatedContactName", value);
				if (_relatedContact != null) {
					_relatedContact.Name = value;
				}
			}
		}

		private Contact _relatedContact;
		/// <summary>
		/// Connected contact.
		/// </summary>
		public  Contact RelatedContact {
			get {
				return _relatedContact ??
					(_relatedContact = LookupColumnEntities.GetEntity("RelatedContact") as Contact);
			}
		}

		/// <exclude/>
		public  Guid RelationTypeId {
			get {
				return GetTypedColumnValue<Guid>("RelationTypeId");
			}
			set {
				SetColumnValue("RelationTypeId", value);
				_relationType = null;
			}
		}

		/// <exclude/>
		public  string RelationTypeName {
			get {
				return GetTypedColumnValue<string>("RelationTypeName");
			}
			set {
				SetColumnValue("RelationTypeName", value);
				if (_relationType != null) {
					_relationType.Name = value;
				}
			}
		}

		private RelationType _relationType;
		/// <summary>
		/// Relationship type.
		/// </summary>
		public  RelationType RelationType {
			get {
				return _relationType ??
					(_relationType = LookupColumnEntities.GetEntity("RelationType") as RelationType);
			}
		}

		/// <exclude/>
		public  Guid ReverseRelationTypeId {
			get {
				return GetTypedColumnValue<Guid>("ReverseRelationTypeId");
			}
			set {
				SetColumnValue("ReverseRelationTypeId", value);
				_reverseRelationType = null;
			}
		}

		/// <exclude/>
		public  string ReverseRelationTypeName {
			get {
				return GetTypedColumnValue<string>("ReverseRelationTypeName");
			}
			set {
				SetColumnValue("ReverseRelationTypeName", value);
				if (_reverseRelationType != null) {
					_reverseRelationType.Name = value;
				}
			}
		}

		private RelationType _reverseRelationType;
		/// <summary>
		/// Inverse relationship type.
		/// </summary>
		public  RelationType ReverseRelationType {
			get {
				return _reverseRelationType ??
					(_reverseRelationType = LookupColumnEntities.GetEntity("ReverseRelationType") as RelationType);
			}
		}

		/// <summary>
		/// Actual.
		/// </summary>
		public  bool Active {
			get {
				return GetTypedColumnValue<bool>("Active");
			}
			set {
				SetColumnValue("Active", value);
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

		/// <summary>
		/// Connected object.
		/// </summary>
		public  string RelatedObjectName {
			get {
				return GetTypedColumnValue<string>("RelatedObjectName");
			}
			set {
				SetColumnValue("RelatedObjectName", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new VwContactRelationship_NUIEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Inserting += (s, e) => ThrowEvent("VwContactRelationshipInserting", e);
			Validating += (s, e) => ThrowEvent("VwContactRelationshipValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new VwContactRelationship(this);
		}

		#endregion

	}

	#endregion

	#region Class: VwContactRelationship_NUIEventsProcess

	/// <exclude/>
	public class VwContactRelationship_NUIEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_LocalMessageEventsProcess<TEntity> where TEntity : VwContactRelationship
	{

		public VwContactRelationship_NUIEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "VwContactRelationship_NUIEventsProcess";
			SchemaUId = new Guid("81743394-e90f-4827-916b-099a9e3e362d");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private  Guid InternalSchemaUId {
			get {
				return new Guid("81743394-e90f-4827-916b-099a9e3e362d");
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

	#region Class: VwContactRelationship_NUIEventsProcess

	/// <exclude/>
	public class VwContactRelationship_NUIEventsProcess : VwContactRelationship_NUIEventsProcess<VwContactRelationship>
	{

		public VwContactRelationship_NUIEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: VwContactRelationshipEventsProcessSchema

	/// <exclude/>
	public class VwContactRelationshipEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public VwContactRelationshipEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public VwContactRelationshipEventsProcessSchema(VwContactRelationshipEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "VwContactRelationship_NUIEventsProcess";
			UId = new Guid("344db3f7-7857-4869-8f3b-935073aa40ae");
			CreatedInPackageId = new Guid("cd322293-860d-4ac9-8e55-034f9e973ce3");
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
				CreatedInPackageId = new Guid("cd322293-860d-4ac9-8e55-034f9e973ce3")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("cde525cf-d220-4d2a-b963-e55254c639fc"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("cd322293-860d-4ac9-8e55-034f9e973ce3")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5c9c82c6-ba6d-4a57-9a14-87fe8faa4ebb"),
				Name = "Terrasoft.Core.DB",
				Alias = "",
				CreatedInPackageId = new Guid("cd322293-860d-4ac9-8e55-034f9e973ce3")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7821de68-c82b-4917-a6cd-add2adfbe400"),
				Name = "Terrasoft.Common",
				Alias = "",
				CreatedInPackageId = new Guid("cd322293-860d-4ac9-8e55-034f9e973ce3")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d67de76f-9cbc-4bfc-babb-6f65cb89b973"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("cd322293-860d-4ac9-8e55-034f9e973ce3")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("74160d3b-65e3-4694-b554-089f2d980e54"),
				Name = "Newtonsoft.Json",
				Alias = "",
				CreatedInPackageId = new Guid("cd322293-860d-4ac9-8e55-034f9e973ce3")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e401300a-9f16-40c2-9788-cf310ae9d1c5"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("cd322293-860d-4ac9-8e55-034f9e973ce3")
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
			return new VwContactRelationshipEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("344db3f7-7857-4869-8f3b-935073aa40ae"));
		}

		#endregion

	}

	#endregion


	#region Class: VwContactRelationshipEventsProcess

	/// <exclude/>
	public class VwContactRelationshipEventsProcess : VwContactRelationship_NUIEventsProcess
	{

		public VwContactRelationshipEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

