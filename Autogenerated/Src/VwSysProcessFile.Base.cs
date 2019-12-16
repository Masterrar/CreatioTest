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
	using System.Linq;
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

	#region Class: VwSysProcessFileSchema

	/// <exclude/>
	public class VwSysProcessFileSchema : Terrasoft.Configuration.FileSchema
	{

		#region Constructors: Public

		public VwSysProcessFileSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public VwSysProcessFileSchema(VwSysProcessFileSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public VwSysProcessFileSchema(VwSysProcessFileSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("45e3e868-0867-4e64-99fc-e03a63c57aa5");
			RealUId = new Guid("45e3e868-0867-4e64-99fc-e03a63c57aa5");
			Name = "VwSysProcessFile";
			ParentSchemaUId = new Guid("556c5867-60a7-4456-aae1-a57a122bef70");
			ExtendParent = false;
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("b89763dc-b135-47fc-9b6b-3224cfc5c09b")) == null) {
				Columns.Add(CreateVwSysProcessColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateVwSysProcessColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("b89763dc-b135-47fc-9b6b-3224cfc5c09b"),
				Name = @"VwSysProcess",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("45e3e868-0867-4e64-99fc-e03a63c57aa5"),
				ModifiedInSchemaUId = new Guid("45e3e868-0867-4e64-99fc-e03a63c57aa5"),
				CreatedInPackageId = new Guid("47d9f451-70d6-4014-b0c9-4ad37a1eb8b7")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateVwSysProcessFileEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateVwSysProcessFileEventsProcessSchema() {
			var schema = new VwSysProcessFileEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new VwSysProcessFile(userConnection){Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new VwSysProcessFile_BaseEventsProcess(userConnnection);
		}

		public override object Clone() {
			return new VwSysProcessFileSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new VwSysProcessFileSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("45e3e868-0867-4e64-99fc-e03a63c57aa5"));
		}

		#endregion

	}

	#endregion

	#region Class: VwSysProcessFile

	/// <summary>
	/// Process attachment.
	/// </summary>
	public class VwSysProcessFile : Terrasoft.Configuration.File
	{

		#region Constructors: Public

		public VwSysProcessFile(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "VwSysProcessFile";
		}

		public VwSysProcessFile(VwSysProcessFile source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Process (view).
		/// </summary>
		public  Guid VwSysProcess {
			get {
				return GetTypedColumnValue<Guid>("VwSysProcess");
			}
			set {
				SetColumnValue("VwSysProcess", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new VwSysProcessFile_BaseEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("VwSysProcessFileDeleted", e);
			Inserting += (s, e) => ThrowEvent("VwSysProcessFileInserting", e);
			Validating += (s, e) => ThrowEvent("VwSysProcessFileValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new VwSysProcessFile(this);
		}

		#endregion

	}

	#endregion

	#region Class: VwSysProcessFile_BaseEventsProcess

	/// <exclude/>
	public class VwSysProcessFile_BaseEventsProcess<TEntity> : Terrasoft.Configuration.File_PRMPortalEventsProcess<TEntity> where TEntity : VwSysProcessFile
	{

		public VwSysProcessFile_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "VwSysProcessFile_BaseEventsProcess";
			SchemaUId = new Guid("45e3e868-0867-4e64-99fc-e03a63c57aa5");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private  Guid InternalSchemaUId {
			get {
				return new Guid("45e3e868-0867-4e64-99fc-e03a63c57aa5");
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

	#region Class: VwSysProcessFile_BaseEventsProcess

	/// <exclude/>
	public class VwSysProcessFile_BaseEventsProcess : VwSysProcessFile_BaseEventsProcess<VwSysProcessFile>
	{

		public VwSysProcessFile_BaseEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: VwSysProcessFileEventsProcessSchema

	/// <exclude/>
	public class VwSysProcessFileEventsProcessSchema : Terrasoft.Configuration.FileEventsProcessSchema
	{

		#region Constructors: Public

		public VwSysProcessFileEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public VwSysProcessFileEventsProcessSchema(VwSysProcessFileEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "VwSysProcessFile_BaseEventsProcess";
			UId = new Guid("a93487aa-862d-4d61-9121-c84b547259ef");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("46370786-d48d-4d24-916a-dc11d551add9");
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
				UId = new Guid("8344487b-4f62-45ad-a3a1-e073f07b2ef2"),
				Name = "System.Collections.Generic",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e33423da-6c95-41fd-bf98-97c4161975e5"),
				Name = "System.Linq",
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
			return new VwSysProcessFileEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a93487aa-862d-4d61-9121-c84b547259ef"));
		}

		#endregion

	}

	#endregion


	#region Class: VwSysProcessFileEventsProcess

	/// <exclude/>
	public class VwSysProcessFileEventsProcess : VwSysProcessFile_BaseEventsProcess
	{

		public VwSysProcessFileEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

