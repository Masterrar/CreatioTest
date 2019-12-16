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

	#region Class: SearchSettingSchema

	/// <exclude/>
	public class SearchSettingSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public SearchSettingSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public SearchSettingSchema(SearchSettingSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public SearchSettingSchema(SearchSettingSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("d2a3ad5c-12b6-46a5-8593-94e59c4fc1c6");
			RealUId = new Guid("d2a3ad5c-12b6-46a5-8593-94e59c4fc1c6");
			Name = "SearchSetting";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("4f1a03e7-b704-4e8f-b18d-5d9d9b146893");
			IsDBView = false;
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
			if (Columns.FindByUId(new Guid("306b9536-f683-4c92-876d-fec0e0ba45ce")) == null) {
				Columns.Add(CreateSettingsColumn());
			}
			if (Columns.FindByUId(new Guid("ed3da4aa-18d2-48f9-be2a-eb9c1331e5b0")) == null) {
				Columns.Add(CreateSearchEntityColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateSettingsColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("306b9536-f683-4c92-876d-fec0e0ba45ce"),
				Name = @"Settings",
				CreatedInSchemaUId = new Guid("d2a3ad5c-12b6-46a5-8593-94e59c4fc1c6"),
				ModifiedInSchemaUId = new Guid("d2a3ad5c-12b6-46a5-8593-94e59c4fc1c6"),
				CreatedInPackageId = new Guid("4f1a03e7-b704-4e8f-b18d-5d9d9b146893")
			};
		}

		protected virtual EntitySchemaColumn CreateSearchEntityColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("ed3da4aa-18d2-48f9-be2a-eb9c1331e5b0"),
				Name = @"SearchEntity",
				ReferenceSchemaUId = new Guid("90fa6d02-3e93-45d6-a72b-58dcffa411ae"),
				IsIndexed = true,
				IsWeakReference = true,
				CreatedInSchemaUId = new Guid("d2a3ad5c-12b6-46a5-8593-94e59c4fc1c6"),
				ModifiedInSchemaUId = new Guid("d2a3ad5c-12b6-46a5-8593-94e59c4fc1c6"),
				CreatedInPackageId = new Guid("4f1a03e7-b704-4e8f-b18d-5d9d9b146893")
			};
		}

		protected virtual EntitySchemaColumn CreateNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("7a5e77fd-b75e-4d28-a82b-68e18593c68e"),
				Name = @"Name",
				CreatedInSchemaUId = new Guid("d2a3ad5c-12b6-46a5-8593-94e59c4fc1c6"),
				ModifiedInSchemaUId = new Guid("d2a3ad5c-12b6-46a5-8593-94e59c4fc1c6"),
				CreatedInPackageId = new Guid("4f1a03e7-b704-4e8f-b18d-5d9d9b146893")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateSearchSettingEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateSearchSettingEventsProcessSchema() {
			var schema = new SearchSettingEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new SearchSetting(userConnection){Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new SearchSetting_GlobalSearchEventsProcess(userConnnection);
		}

		public override object Clone() {
			return new SearchSettingSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new SearchSettingSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d2a3ad5c-12b6-46a5-8593-94e59c4fc1c6"));
		}

		#endregion

	}

	#endregion

	#region Class: SearchSetting

	/// <summary>
	/// Global search setting.
	/// </summary>
	public class SearchSetting : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public SearchSetting(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "SearchSetting";
		}

		public SearchSetting(SearchSetting source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Search config.
		/// </summary>
		public  string Settings {
			get {
				return GetTypedColumnValue<string>("Settings");
			}
			set {
				SetColumnValue("Settings", value);
			}
		}

		/// <exclude/>
		public  Guid SearchEntityId {
			get {
				return GetTypedColumnValue<Guid>("SearchEntityId");
			}
			set {
				SetColumnValue("SearchEntityId", value);
				_searchEntity = null;
			}
		}

		/// <exclude/>
		public  string SearchEntityCaption {
			get {
				return GetTypedColumnValue<string>("SearchEntityCaption");
			}
			set {
				SetColumnValue("SearchEntityCaption", value);
				if (_searchEntity != null) {
					_searchEntity.Caption = value;
				}
			}
		}

		private VwSysSchemaInfo _searchEntity;
		/// <summary>
		/// Search entity.
		/// </summary>
		public  VwSysSchemaInfo SearchEntity {
			get {
				return _searchEntity ??
					(_searchEntity = LookupColumnEntities.GetEntity("SearchEntity") as VwSysSchemaInfo);
			}
		}

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

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new SearchSetting_GlobalSearchEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Validating += (s, e) => ThrowEvent("SearchSettingValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new SearchSetting(this);
		}

		#endregion

	}

	#endregion

	#region Class: SearchSetting_GlobalSearchEventsProcess

	/// <exclude/>
	public class SearchSetting_GlobalSearchEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_LocalMessageEventsProcess<TEntity> where TEntity : SearchSetting
	{

		public SearchSetting_GlobalSearchEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SearchSetting_GlobalSearchEventsProcess";
			SchemaUId = new Guid("d2a3ad5c-12b6-46a5-8593-94e59c4fc1c6");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private  Guid InternalSchemaUId {
			get {
				return new Guid("d2a3ad5c-12b6-46a5-8593-94e59c4fc1c6");
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

	#region Class: SearchSetting_GlobalSearchEventsProcess

	/// <exclude/>
	public class SearchSetting_GlobalSearchEventsProcess : SearchSetting_GlobalSearchEventsProcess<SearchSetting>
	{

		public SearchSetting_GlobalSearchEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: SearchSettingEventsProcessSchema

	/// <exclude/>
	public class SearchSettingEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public SearchSettingEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public SearchSettingEventsProcessSchema(SearchSettingEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "SearchSetting_GlobalSearchEventsProcess";
			UId = new Guid("303f6f1d-e9b3-40fc-a1c5-ab6a58024612");
			CreatedInPackageId = new Guid("4f1a03e7-b704-4e8f-b18d-5d9d9b146893");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
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
			return new SearchSettingEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("303f6f1d-e9b3-40fc-a1c5-ab6a58024612"));
		}

		#endregion

	}

	#endregion


	#region Class: SearchSettingEventsProcess

	/// <exclude/>
	public class SearchSettingEventsProcess : SearchSetting_GlobalSearchEventsProcess
	{

		public SearchSettingEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

