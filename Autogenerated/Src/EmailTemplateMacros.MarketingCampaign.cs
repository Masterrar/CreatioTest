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

	#region Class: EmailTemplateMacrosSchema

	/// <exclude/>
	public class EmailTemplateMacrosSchema : Terrasoft.Configuration.EmailTemplateMacros_Base_TerrasoftSchema
	{

		#region Constructors: Public

		public EmailTemplateMacrosSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public EmailTemplateMacrosSchema(EmailTemplateMacrosSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public EmailTemplateMacrosSchema(EmailTemplateMacrosSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("3454c58c-8bdd-4536-8aff-9451b62cac67");
			Name = "EmailTemplateMacros";
			ParentSchemaUId = new Guid("e92a62ec-f0bb-422f-9a33-6d79532edc21");
			ExtendParent = true;
			CreatedInPackageId = new Guid("b477c174-1d53-4a21-b489-a41e481a96a0");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("31f443f0-9862-45d4-82b1-3646b7be7e80")) == null) {
				Columns.Add(CreateTemplateColumn());
			}
		}

		protected override EntitySchemaColumn CreateParentColumn() {
			EntitySchemaColumn column = base.CreateParentColumn();
			column.ModifiedInSchemaUId = new Guid("3454c58c-8bdd-4536-8aff-9451b62cac67");
			column.CreatedInPackageId = new Guid("b477c174-1d53-4a21-b489-a41e481a96a0");
			return column;
		}

		protected virtual EntitySchemaColumn CreateTemplateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("31f443f0-9862-45d4-82b1-3646b7be7e80"),
				Name = @"Template",
				CreatedInSchemaUId = new Guid("3454c58c-8bdd-4536-8aff-9451b62cac67"),
				ModifiedInSchemaUId = new Guid("3454c58c-8bdd-4536-8aff-9451b62cac67"),
				CreatedInPackageId = new Guid("b477c174-1d53-4a21-b489-a41e481a96a0")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateEmailTemplateMacrosEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateEmailTemplateMacrosEventsProcessSchema() {
			var schema = new EmailTemplateMacrosEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new EmailTemplateMacros(userConnection){Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new EmailTemplateMacros_MarketingCampaignEventsProcess(userConnnection);
		}

		public override object Clone() {
			return new EmailTemplateMacrosSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new EmailTemplateMacrosSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("3454c58c-8bdd-4536-8aff-9451b62cac67"));
		}

		#endregion

	}

	#endregion

	#region Class: EmailTemplateMacros

	/// <summary>
	/// Message template macro.
	/// </summary>
	public class EmailTemplateMacros : Terrasoft.Configuration.EmailTemplateMacros_Base_Terrasoft
	{

		#region Constructors: Public

		public EmailTemplateMacros(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "EmailTemplateMacros";
		}

		public EmailTemplateMacros(EmailTemplateMacros source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Template.
		/// </summary>
		public  string Template {
			get {
				return GetTypedColumnValue<string>("Template");
			}
			set {
				SetColumnValue("Template", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new EmailTemplateMacros_MarketingCampaignEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Inserting += (s, e) => ThrowEvent("EmailTemplateMacrosInserting", e);
			Validating += (s, e) => ThrowEvent("EmailTemplateMacrosValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new EmailTemplateMacros(this);
		}

		#endregion

	}

	#endregion

	#region Class: EmailTemplateMacros_MarketingCampaignEventsProcess

	/// <exclude/>
	public class EmailTemplateMacros_MarketingCampaignEventsProcess<TEntity> : Terrasoft.Configuration.EmailTemplateMacros_BaseEventsProcess<TEntity> where TEntity : EmailTemplateMacros
	{

		public EmailTemplateMacros_MarketingCampaignEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "EmailTemplateMacros_MarketingCampaignEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private  Guid InternalSchemaUId {
			get {
				return new Guid("3454c58c-8bdd-4536-8aff-9451b62cac67");
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

	#region Class: EmailTemplateMacros_MarketingCampaignEventsProcess

	/// <exclude/>
	public class EmailTemplateMacros_MarketingCampaignEventsProcess : EmailTemplateMacros_MarketingCampaignEventsProcess<EmailTemplateMacros>
	{

		public EmailTemplateMacros_MarketingCampaignEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: EmailTemplateMacrosEventsProcessSchema

	/// <exclude/>
	public class EmailTemplateMacrosEventsProcessSchema : Terrasoft.Configuration.EmailTemplateMacros_Base_TerrasoftEventsProcessSchema
	{

		#region Constructors: Public

		public EmailTemplateMacrosEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public EmailTemplateMacrosEventsProcessSchema(EmailTemplateMacrosEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "EmailTemplateMacros_MarketingCampaignEventsProcess";
			UId = new Guid("00ea7b6a-2970-42ea-9f9c-a95e75ae25d7");
			CreatedInPackageId = new Guid("b477c174-1d53-4a21-b489-a41e481a96a0");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("121c0b1e-893b-4d05-afdb-70b8cea66c90");
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
				CreatedInPackageId = new Guid("b477c174-1d53-4a21-b489-a41e481a96a0")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("cde525cf-d220-4d2a-b963-e55254c639fc"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("b477c174-1d53-4a21-b489-a41e481a96a0")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5c9c82c6-ba6d-4a57-9a14-87fe8faa4ebb"),
				Name = "Terrasoft.Core.DB",
				Alias = "",
				CreatedInPackageId = new Guid("b477c174-1d53-4a21-b489-a41e481a96a0")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7821de68-c82b-4917-a6cd-add2adfbe400"),
				Name = "Terrasoft.Common",
				Alias = "",
				CreatedInPackageId = new Guid("b477c174-1d53-4a21-b489-a41e481a96a0")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d67de76f-9cbc-4bfc-babb-6f65cb89b973"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("b477c174-1d53-4a21-b489-a41e481a96a0")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("74160d3b-65e3-4694-b554-089f2d980e54"),
				Name = "Newtonsoft.Json",
				Alias = "",
				CreatedInPackageId = new Guid("b477c174-1d53-4a21-b489-a41e481a96a0")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e401300a-9f16-40c2-9788-cf310ae9d1c5"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("b477c174-1d53-4a21-b489-a41e481a96a0")
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
			return new EmailTemplateMacrosEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("00ea7b6a-2970-42ea-9f9c-a95e75ae25d7"));
		}

		#endregion

	}

	#endregion


	#region Class: EmailTemplateMacrosEventsProcess

	/// <exclude/>
	public class EmailTemplateMacrosEventsProcess : EmailTemplateMacros_MarketingCampaignEventsProcess
	{

		public EmailTemplateMacrosEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

