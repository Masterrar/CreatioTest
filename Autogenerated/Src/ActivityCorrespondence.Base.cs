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

	#region Class: ActivityCorrespondenceSchema

	/// <exclude/>
	public class ActivityCorrespondenceSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public ActivityCorrespondenceSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public ActivityCorrespondenceSchema(ActivityCorrespondenceSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public ActivityCorrespondenceSchema(ActivityCorrespondenceSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private EntitySchemaIndex CreateIeFJD8RtBaf4fpaC6SeuObAJGmDEIndex() {
			EntitySchemaIndex index = new EntitySchemaIndex() {
				IsAutoName = true,
				IsClustered = false,
				IsUnique = true
			};
			index.UId = new Guid("fe3ac399-ce12-4aa2-b5a9-20eebba7e34f");
			index.Name = "IeFJD8RtBaf4fpaC6SeuObAJGmDE";
			index.CreatedInSchemaUId = new Guid("7265d096-3f9d-47c0-808f-4fafa5f2c675");
			index.ModifiedInSchemaUId = new Guid("7265d096-3f9d-47c0-808f-4fafa5f2c675");
			index.CreatedInPackageId = new Guid("45b7d114-643d-4217-a8b2-b9950d3eddb7");
			EntitySchemaIndexColumn sourceActivityIdIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("87a67c02-fb52-47c8-bd64-700e447579ca"),
				ColumnUId = new Guid("25cb72c8-08c4-485c-98a3-7644a10bdc52"),
				CreatedInSchemaUId = new Guid("7265d096-3f9d-47c0-808f-4fafa5f2c675"),
				ModifiedInSchemaUId = new Guid("7265d096-3f9d-47c0-808f-4fafa5f2c675"),
				CreatedInPackageId = new Guid("45b7d114-643d-4217-a8b2-b9950d3eddb7"),
				OrderDirection = OrderDirectionStrict.Ascending
			};
			index.Columns.Add(sourceActivityIdIndexColumn);
			return index;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("7265d096-3f9d-47c0-808f-4fafa5f2c675");
			RealUId = new Guid("7265d096-3f9d-47c0-808f-4fafa5f2c675");
			Name = "ActivityCorrespondence";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("ee0c6a70-2667-4686-aadb-aa9841569dc4")) == null) {
				Columns.Add(CreateActivityColumn());
			}
			if (Columns.FindByUId(new Guid("9370cc02-ae7e-421b-a4c5-7993692cc619")) == null) {
				Columns.Add(CreateIsDeletedColumn());
			}
			if (Columns.FindByUId(new Guid("25cb72c8-08c4-485c-98a3-7644a10bdc52")) == null) {
				Columns.Add(CreateSourceActivityIdColumn());
			}
			if (Columns.FindByUId(new Guid("033df125-ecf9-4c69-ac12-8a14df8c1ba8")) == null) {
				Columns.Add(CreateSourceAccountColumn());
			}
			if (Columns.FindByUId(new Guid("98d437c7-131e-4150-a21a-eaad97c17095")) == null) {
				Columns.Add(CreateCreatedInBPMonlineColumn());
			}
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.ModifiedInSchemaUId = new Guid("7265d096-3f9d-47c0-808f-4fafa5f2c675");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.ModifiedInSchemaUId = new Guid("7265d096-3f9d-47c0-808f-4fafa5f2c675");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.ModifiedInSchemaUId = new Guid("7265d096-3f9d-47c0-808f-4fafa5f2c675");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.ModifiedInSchemaUId = new Guid("7265d096-3f9d-47c0-808f-4fafa5f2c675");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.ModifiedInSchemaUId = new Guid("7265d096-3f9d-47c0-808f-4fafa5f2c675");
			return column;
		}

		protected override EntitySchemaColumn CreateProcessListenersColumn() {
			EntitySchemaColumn column = base.CreateProcessListenersColumn();
			column.ModifiedInSchemaUId = new Guid("7265d096-3f9d-47c0-808f-4fafa5f2c675");
			return column;
		}

		protected virtual EntitySchemaColumn CreateActivityColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("ee0c6a70-2667-4686-aadb-aa9841569dc4"),
				Name = @"Activity",
				ReferenceSchemaUId = new Guid("c449d832-a4cc-4b01-b9d5-8a12c42a9f89"),
				IsIndexed = true,
				IsWeakReference = true,
				CreatedInSchemaUId = new Guid("7265d096-3f9d-47c0-808f-4fafa5f2c675"),
				ModifiedInSchemaUId = new Guid("7265d096-3f9d-47c0-808f-4fafa5f2c675"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateIsDeletedColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("9370cc02-ae7e-421b-a4c5-7993692cc619"),
				Name = @"IsDeleted",
				CreatedInSchemaUId = new Guid("7265d096-3f9d-47c0-808f-4fafa5f2c675"),
				ModifiedInSchemaUId = new Guid("7265d096-3f9d-47c0-808f-4fafa5f2c675"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateSourceActivityIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("LongText")) {
				UId = new Guid("25cb72c8-08c4-485c-98a3-7644a10bdc52"),
				Name = @"SourceActivityId",
				CreatedInSchemaUId = new Guid("7265d096-3f9d-47c0-808f-4fafa5f2c675"),
				ModifiedInSchemaUId = new Guid("7265d096-3f9d-47c0-808f-4fafa5f2c675"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateSourceAccountColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("033df125-ecf9-4c69-ac12-8a14df8c1ba8"),
				Name = @"SourceAccount",
				ReferenceSchemaUId = new Guid("76e3d8e8-6c6b-48b5-9f43-3b361c368bff"),
				IsIndexed = true,
				IsWeakReference = true,
				CreatedInSchemaUId = new Guid("7265d096-3f9d-47c0-808f-4fafa5f2c675"),
				ModifiedInSchemaUId = new Guid("7265d096-3f9d-47c0-808f-4fafa5f2c675"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected virtual EntitySchemaColumn CreateCreatedInBPMonlineColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("98d437c7-131e-4150-a21a-eaad97c17095"),
				Name = @"CreatedInBPMonline",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("7265d096-3f9d-47c0-808f-4fafa5f2c675"),
				ModifiedInSchemaUId = new Guid("7265d096-3f9d-47c0-808f-4fafa5f2c675"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeIndexes() {
			base.InitializeIndexes();
			Indexes.Add(CreateIeFJD8RtBaf4fpaC6SeuObAJGmDEIndex());
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateActivityCorrespondenceEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateActivityCorrespondenceEventsProcessSchema() {
			var schema = new ActivityCorrespondenceEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new ActivityCorrespondence(userConnection){Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new ActivityCorrespondence_BaseEventsProcess(userConnnection);
		}

		public override object Clone() {
			return new ActivityCorrespondenceSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new ActivityCorrespondenceSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("7265d096-3f9d-47c0-808f-4fafa5f2c675"));
		}

		#endregion

	}

	#endregion

	#region Class: ActivityCorrespondence

	/// <summary>
	/// Activity in External Resources.
	/// </summary>
	public class ActivityCorrespondence : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public ActivityCorrespondence(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "ActivityCorrespondence";
		}

		public ActivityCorrespondence(ActivityCorrespondence source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public  Guid ActivityId {
			get {
				return GetTypedColumnValue<Guid>("ActivityId");
			}
			set {
				SetColumnValue("ActivityId", value);
				_activity = null;
			}
		}

		/// <exclude/>
		public  string ActivityTitle {
			get {
				return GetTypedColumnValue<string>("ActivityTitle");
			}
			set {
				SetColumnValue("ActivityTitle", value);
				if (_activity != null) {
					_activity.Title = value;
				}
			}
		}

		private Activity _activity;
		/// <summary>
		/// Activity.
		/// </summary>
		public  Activity Activity {
			get {
				return _activity ??
					(_activity = LookupColumnEntities.GetEntity("Activity") as Activity);
			}
		}

		/// <summary>
		/// Deleted.
		/// </summary>
		public  bool IsDeleted {
			get {
				return GetTypedColumnValue<bool>("IsDeleted");
			}
			set {
				SetColumnValue("IsDeleted", value);
			}
		}

		/// <summary>
		/// Activity Code in External Resource.
		/// </summary>
		public  string SourceActivityId {
			get {
				return GetTypedColumnValue<string>("SourceActivityId");
			}
			set {
				SetColumnValue("SourceActivityId", value);
			}
		}

		/// <exclude/>
		public  Guid SourceAccountId {
			get {
				return GetTypedColumnValue<Guid>("SourceAccountId");
			}
			set {
				SetColumnValue("SourceAccountId", value);
				_sourceAccount = null;
			}
		}

		/// <exclude/>
		public  string SourceAccountLogin {
			get {
				return GetTypedColumnValue<string>("SourceAccountLogin");
			}
			set {
				SetColumnValue("SourceAccountLogin", value);
				if (_sourceAccount != null) {
					_sourceAccount.Login = value;
				}
			}
		}

		private SocialAccount _sourceAccount;
		/// <summary>
		/// External Resource User Account ID.
		/// </summary>
		public  SocialAccount SourceAccount {
			get {
				return _sourceAccount ??
					(_sourceAccount = LookupColumnEntities.GetEntity("SourceAccount") as SocialAccount);
			}
		}

		/// <summary>
		/// Activity is created in bpm'online.
		/// </summary>
		public  bool CreatedInBPMonline {
			get {
				return GetTypedColumnValue<bool>("CreatedInBPMonline");
			}
			set {
				SetColumnValue("CreatedInBPMonline", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new ActivityCorrespondence_BaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Inserting += (s, e) => ThrowEvent("ActivityCorrespondenceInserting", e);
			Validating += (s, e) => ThrowEvent("ActivityCorrespondenceValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new ActivityCorrespondence(this);
		}

		#endregion

	}

	#endregion

	#region Class: ActivityCorrespondence_BaseEventsProcess

	/// <exclude/>
	public class ActivityCorrespondence_BaseEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_LocalMessageEventsProcess<TEntity> where TEntity : ActivityCorrespondence
	{

		public ActivityCorrespondence_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ActivityCorrespondence_BaseEventsProcess";
			SchemaUId = new Guid("7265d096-3f9d-47c0-808f-4fafa5f2c675");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private  Guid InternalSchemaUId {
			get {
				return new Guid("7265d096-3f9d-47c0-808f-4fafa5f2c675");
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

	#region Class: ActivityCorrespondence_BaseEventsProcess

	/// <exclude/>
	public class ActivityCorrespondence_BaseEventsProcess : ActivityCorrespondence_BaseEventsProcess<ActivityCorrespondence>
	{

		public ActivityCorrespondence_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: ActivityCorrespondenceEventsProcessSchema

	/// <exclude/>
	public class ActivityCorrespondenceEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public ActivityCorrespondenceEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public ActivityCorrespondenceEventsProcessSchema(ActivityCorrespondenceEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "ActivityCorrespondence_BaseEventsProcess";
			UId = new Guid("87224eab-2b1d-4a1b-813f-7cadd23374b1");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
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
			return new ActivityCorrespondenceEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("87224eab-2b1d-4a1b-813f-7cadd23374b1"));
		}

		#endregion

	}

	#endregion


	#region Class: ActivityCorrespondenceEventsProcess

	/// <exclude/>
	public class ActivityCorrespondenceEventsProcess : ActivityCorrespondence_BaseEventsProcess
	{

		public ActivityCorrespondenceEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

