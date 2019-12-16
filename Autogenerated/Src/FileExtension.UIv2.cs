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

	#region Class: FileExtensionSchema

	/// <exclude/>
	public class FileExtensionSchema : Terrasoft.Configuration.BaseLookupSchema
	{

		#region Constructors: Public

		public FileExtensionSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public FileExtensionSchema(FileExtensionSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public FileExtensionSchema(FileExtensionSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f38efa52-ca4b-4d43-bae4-0f52fda57daf");
			RealUId = new Guid("f38efa52-ca4b-4d43-bae4-0f52fda57daf");
			Name = "FileExtension";
			ParentSchemaUId = new Guid("11ab4bcb-9b23-4b6d-9c86-520fae925d75");
			ExtendParent = false;
			CreatedInPackageId = new Guid("605bfcc9-12b3-4d76-9818-dcfc2bec6a40");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("bfd868fd-dabd-469b-8c9b-d7b1e81cdf24")) == null) {
				Columns.Add(CreateDataColumn());
			}
			if (Columns.FindByUId(new Guid("0e83b942-0bff-4334-bb22-dc4dd2099f0d")) == null) {
				Columns.Add(CreateFileNameColumn());
			}
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.ModifiedInSchemaUId = new Guid("f38efa52-ca4b-4d43-bae4-0f52fda57daf");
			column.CreatedInPackageId = new Guid("605bfcc9-12b3-4d76-9818-dcfc2bec6a40");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.ModifiedInSchemaUId = new Guid("f38efa52-ca4b-4d43-bae4-0f52fda57daf");
			column.CreatedInPackageId = new Guid("605bfcc9-12b3-4d76-9818-dcfc2bec6a40");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.ModifiedInSchemaUId = new Guid("f38efa52-ca4b-4d43-bae4-0f52fda57daf");
			column.CreatedInPackageId = new Guid("605bfcc9-12b3-4d76-9818-dcfc2bec6a40");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.ModifiedInSchemaUId = new Guid("f38efa52-ca4b-4d43-bae4-0f52fda57daf");
			column.CreatedInPackageId = new Guid("605bfcc9-12b3-4d76-9818-dcfc2bec6a40");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.ModifiedInSchemaUId = new Guid("f38efa52-ca4b-4d43-bae4-0f52fda57daf");
			column.CreatedInPackageId = new Guid("605bfcc9-12b3-4d76-9818-dcfc2bec6a40");
			return column;
		}

		protected override EntitySchemaColumn CreateNameColumn() {
			EntitySchemaColumn column = base.CreateNameColumn();
			column.ModifiedInSchemaUId = new Guid("f38efa52-ca4b-4d43-bae4-0f52fda57daf");
			column.CreatedInPackageId = new Guid("605bfcc9-12b3-4d76-9818-dcfc2bec6a40");
			return column;
		}

		protected override EntitySchemaColumn CreateDescriptionColumn() {
			EntitySchemaColumn column = base.CreateDescriptionColumn();
			column.ModifiedInSchemaUId = new Guid("f38efa52-ca4b-4d43-bae4-0f52fda57daf");
			column.CreatedInPackageId = new Guid("605bfcc9-12b3-4d76-9818-dcfc2bec6a40");
			return column;
		}

		protected override EntitySchemaColumn CreateProcessListenersColumn() {
			EntitySchemaColumn column = base.CreateProcessListenersColumn();
			column.ModifiedInSchemaUId = new Guid("f38efa52-ca4b-4d43-bae4-0f52fda57daf");
			column.CreatedInPackageId = new Guid("605bfcc9-12b3-4d76-9818-dcfc2bec6a40");
			return column;
		}

		protected virtual EntitySchemaColumn CreateDataColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Image")) {
				UId = new Guid("bfd868fd-dabd-469b-8c9b-d7b1e81cdf24"),
				Name = @"Data",
				CreatedInSchemaUId = new Guid("f38efa52-ca4b-4d43-bae4-0f52fda57daf"),
				ModifiedInSchemaUId = new Guid("f38efa52-ca4b-4d43-bae4-0f52fda57daf"),
				CreatedInPackageId = new Guid("605bfcc9-12b3-4d76-9818-dcfc2bec6a40")
			};
		}

		protected virtual EntitySchemaColumn CreateFileNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("LongText")) {
				UId = new Guid("0e83b942-0bff-4334-bb22-dc4dd2099f0d"),
				Name = @"FileName",
				CreatedInSchemaUId = new Guid("f38efa52-ca4b-4d43-bae4-0f52fda57daf"),
				ModifiedInSchemaUId = new Guid("f38efa52-ca4b-4d43-bae4-0f52fda57daf"),
				CreatedInPackageId = new Guid("605bfcc9-12b3-4d76-9818-dcfc2bec6a40")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateFileExtensionEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateFileExtensionEventsProcessSchema() {
			var schema = new FileExtensionEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new FileExtension(userConnection){Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new FileExtension_UIv2EventsProcess(userConnnection);
		}

		public override object Clone() {
			return new FileExtensionSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new FileExtensionSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f38efa52-ca4b-4d43-bae4-0f52fda57daf"));
		}

		#endregion

	}

	#endregion

	#region Class: FileExtension

	/// <summary>
	/// File resolution.
	/// </summary>
	public class FileExtension : Terrasoft.Configuration.BaseLookup
	{

		#region Constructors: Public

		public FileExtension(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "FileExtension";
		}

		public FileExtension(FileExtension source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// File name.
		/// </summary>
		public  string FileName {
			get {
				return GetTypedColumnValue<string>("FileName");
			}
			set {
				SetColumnValue("FileName", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new FileExtension_UIv2EventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Inserting += (s, e) => ThrowEvent("FileExtensionInserting", e);
			Validating += (s, e) => ThrowEvent("FileExtensionValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new FileExtension(this);
		}

		#endregion

	}

	#endregion

	#region Class: FileExtension_UIv2EventsProcess

	/// <exclude/>
	public class FileExtension_UIv2EventsProcess<TEntity> : Terrasoft.Configuration.BaseLookup_BaseEventsProcess<TEntity> where TEntity : FileExtension
	{

		public FileExtension_UIv2EventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "FileExtension_UIv2EventsProcess";
			SchemaUId = new Guid("f38efa52-ca4b-4d43-bae4-0f52fda57daf");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private  Guid InternalSchemaUId {
			get {
				return new Guid("f38efa52-ca4b-4d43-bae4-0f52fda57daf");
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

	#region Class: FileExtension_UIv2EventsProcess

	/// <exclude/>
	public class FileExtension_UIv2EventsProcess : FileExtension_UIv2EventsProcess<FileExtension>
	{

		public FileExtension_UIv2EventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: FileExtensionEventsProcessSchema

	/// <exclude/>
	public class FileExtensionEventsProcessSchema : Terrasoft.Configuration.BaseLookupEventsProcessSchema
	{

		#region Constructors: Public

		public FileExtensionEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public FileExtensionEventsProcessSchema(FileExtensionEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "FileExtension_UIv2EventsProcess";
			UId = new Guid("cf8736ef-56c2-4c84-91b9-7fc5f5cc9ac6");
			CreatedInPackageId = new Guid("605bfcc9-12b3-4d76-9818-dcfc2bec6a40");
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
				CreatedInPackageId = new Guid("605bfcc9-12b3-4d76-9818-dcfc2bec6a40")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("cde525cf-d220-4d2a-b963-e55254c639fc"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("605bfcc9-12b3-4d76-9818-dcfc2bec6a40")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5c9c82c6-ba6d-4a57-9a14-87fe8faa4ebb"),
				Name = "Terrasoft.Core.DB",
				Alias = "",
				CreatedInPackageId = new Guid("605bfcc9-12b3-4d76-9818-dcfc2bec6a40")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7821de68-c82b-4917-a6cd-add2adfbe400"),
				Name = "Terrasoft.Common",
				Alias = "",
				CreatedInPackageId = new Guid("605bfcc9-12b3-4d76-9818-dcfc2bec6a40")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d67de76f-9cbc-4bfc-babb-6f65cb89b973"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("605bfcc9-12b3-4d76-9818-dcfc2bec6a40")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("74160d3b-65e3-4694-b554-089f2d980e54"),
				Name = "Newtonsoft.Json",
				Alias = "",
				CreatedInPackageId = new Guid("605bfcc9-12b3-4d76-9818-dcfc2bec6a40")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e401300a-9f16-40c2-9788-cf310ae9d1c5"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("605bfcc9-12b3-4d76-9818-dcfc2bec6a40")
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
			return new FileExtensionEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("cf8736ef-56c2-4c84-91b9-7fc5f5cc9ac6"));
		}

		#endregion

	}

	#endregion


	#region Class: FileExtensionEventsProcess

	/// <exclude/>
	public class FileExtensionEventsProcess : FileExtension_UIv2EventsProcess
	{

		public FileExtensionEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

