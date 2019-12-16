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
	using System.Linq;
	using System.Runtime.Remoting;
	using Terrasoft.Common;
	using Terrasoft.Common.Json;
	using Terrasoft.Configuration;
	using Terrasoft.Configuration.EntitySynchronization;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.DcmProcess;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Factories;
	using Terrasoft.Core.ImageAPI;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;
	using Terrasoft.Messaging.Common;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities.Json.Converters;

	#region Class: Contact_MarketingCampaign_TerrasoftSchema

	/// <exclude/>
	public class Contact_MarketingCampaign_TerrasoftSchema : Terrasoft.Configuration.Contact_Lead_TerrasoftSchema
	{

		#region Constructors: Public

		public Contact_MarketingCampaign_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public Contact_MarketingCampaign_TerrasoftSchema(Contact_MarketingCampaign_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public Contact_MarketingCampaign_TerrasoftSchema(Contact_MarketingCampaign_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private EntitySchemaIndex CreateI84ciI9ljAEY9JBteoJcHEeIc1KUIndex() {
			EntitySchemaIndex index = new EntitySchemaIndex() {
				IsAutoName = true,
				IsClustered = false,
				IsUnique = false
			};
			index.UId = new Guid("606284af-5c43-4e46-b7d4-a01d00ffe9bc");
			index.Name = "I84ciI9ljAEY9JBteoJcHEeIc1KU";
			index.CreatedInSchemaUId = new Guid("1182f753-e867-4869-93a2-69d7a9eef7ae");
			index.ModifiedInSchemaUId = new Guid("1182f753-e867-4869-93a2-69d7a9eef7ae");
			index.CreatedInPackageId = new Guid("5b53fbff-9be6-434d-a91a-0bac8907d8d7");
			EntitySchemaIndexColumn emailIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("72478faa-6bb8-4b94-8e73-064baf7d1017"),
				ColumnUId = new Guid("dbf202ec-c444-479b-bcf4-d8e5b1863201"),
				CreatedInSchemaUId = new Guid("1182f753-e867-4869-93a2-69d7a9eef7ae"),
				ModifiedInSchemaUId = new Guid("1182f753-e867-4869-93a2-69d7a9eef7ae"),
				CreatedInPackageId = new Guid("5b53fbff-9be6-434d-a91a-0bac8907d8d7"),
				OrderDirection = OrderDirectionStrict.Ascending
			};
			index.Columns.Add(emailIndexColumn);
			EntitySchemaIndexColumn doNotUseEmailIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("437041e4-308e-4f07-8bf3-edd30fa9cc9c"),
				ColumnUId = new Guid("1b1d8f33-4d26-4353-a1ed-07e11fc82112"),
				CreatedInSchemaUId = new Guid("1182f753-e867-4869-93a2-69d7a9eef7ae"),
				ModifiedInSchemaUId = new Guid("1182f753-e867-4869-93a2-69d7a9eef7ae"),
				CreatedInPackageId = new Guid("5b53fbff-9be6-434d-a91a-0bac8907d8d7"),
				OrderDirection = OrderDirectionStrict.Ascending
			};
			index.Columns.Add(doNotUseEmailIndexColumn);
			EntitySchemaIndexColumn isNonActualEmailIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("3fd12b70-0a1c-4bc7-92c5-c165ddfc5ebe"),
				ColumnUId = new Guid("65db5bf4-c253-4bd3-8988-ca1c6397a7ee"),
				CreatedInSchemaUId = new Guid("1182f753-e867-4869-93a2-69d7a9eef7ae"),
				ModifiedInSchemaUId = new Guid("1182f753-e867-4869-93a2-69d7a9eef7ae"),
				CreatedInPackageId = new Guid("5b53fbff-9be6-434d-a91a-0bac8907d8d7"),
				OrderDirection = OrderDirectionStrict.Ascending
			};
			index.Columns.Add(isNonActualEmailIndexColumn);
			return index;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("1182f753-e867-4869-93a2-69d7a9eef7ae");
			Name = "Contact_MarketingCampaign_Terrasoft";
			ParentSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3");
			ExtendParent = true;
			CreatedInPackageId = new Guid("ad50bca2-4b1b-4d20-9ed9-9c5500cdd145");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("65db5bf4-c253-4bd3-8988-ca1c6397a7ee")) == null) {
				Columns.Add(CreateIsNonActualEmailColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateIsNonActualEmailColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("65db5bf4-c253-4bd3-8988-ca1c6397a7ee"),
				Name = @"IsNonActualEmail",
				CreatedInSchemaUId = new Guid("1182f753-e867-4869-93a2-69d7a9eef7ae"),
				ModifiedInSchemaUId = new Guid("1182f753-e867-4869-93a2-69d7a9eef7ae"),
				CreatedInPackageId = new Guid("ad50bca2-4b1b-4d20-9ed9-9c5500cdd145")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeIndexes() {
			base.InitializeIndexes();
			Indexes.Add(CreateI84ciI9ljAEY9JBteoJcHEeIc1KUIndex());
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateContact_MarketingCampaign_TerrasoftEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateContact_MarketingCampaign_TerrasoftEventsProcessSchema() {
			var schema = new Contact_MarketingCampaign_TerrasoftEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new Contact_MarketingCampaign_Terrasoft(userConnection){Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new Contact_MarketingCampaignEventsProcess(userConnnection);
		}

		public override object Clone() {
			return new Contact_MarketingCampaign_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new Contact_MarketingCampaign_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("1182f753-e867-4869-93a2-69d7a9eef7ae"));
		}

		#endregion

	}

	#endregion

	#region Class: Contact_MarketingCampaign_Terrasoft

	/// <summary>
	/// Contact.
	/// </summary>
	public class Contact_MarketingCampaign_Terrasoft : Terrasoft.Configuration.Contact_Lead_Terrasoft
	{

		#region Constructors: Public

		public Contact_MarketingCampaign_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Contact_MarketingCampaign_Terrasoft";
		}

		public Contact_MarketingCampaign_Terrasoft(Contact_MarketingCampaign_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Invalid email.
		/// </summary>
		public  bool IsNonActualEmail {
			get {
				return GetTypedColumnValue<bool>("IsNonActualEmail");
			}
			set {
				SetColumnValue("IsNonActualEmail", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new Contact_MarketingCampaignEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("Contact_MarketingCampaign_TerrasoftDeleted", e);
			Deleting += (s, e) => ThrowEvent("Contact_MarketingCampaign_TerrasoftDeleting", e);
			Validating += (s, e) => ThrowEvent("Contact_MarketingCampaign_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new Contact_MarketingCampaign_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: Contact_MarketingCampaignEventsProcess

	/// <exclude/>
	public class Contact_MarketingCampaignEventsProcess<TEntity> : Terrasoft.Configuration.Contact_LeadEventsProcess<TEntity> where TEntity : Contact_MarketingCampaign_Terrasoft
	{

		public Contact_MarketingCampaignEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Contact_MarketingCampaignEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private  Guid InternalSchemaUId {
			get {
				return new Guid("1182f753-e867-4869-93a2-69d7a9eef7ae");
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

	#region Class: Contact_MarketingCampaignEventsProcess

	/// <exclude/>
	public class Contact_MarketingCampaignEventsProcess : Contact_MarketingCampaignEventsProcess<Contact_MarketingCampaign_Terrasoft>
	{

		public Contact_MarketingCampaignEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: Contact_MarketingCampaign_TerrasoftEventsProcessSchema

	/// <exclude/>
	public class Contact_MarketingCampaign_TerrasoftEventsProcessSchema : Terrasoft.Configuration.Contact_Lead_TerrasoftEventsProcessSchema
	{

		#region Constructors: Public

		public Contact_MarketingCampaign_TerrasoftEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public Contact_MarketingCampaign_TerrasoftEventsProcessSchema(Contact_MarketingCampaign_TerrasoftEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "Contact_MarketingCampaignEventsProcess";
			UId = new Guid("29c142b1-866a-43a5-bcdf-42299173d2f4");
			CreatedInPackageId = new Guid("ad50bca2-4b1b-4d20-9ed9-9c5500cdd145");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("0c5bf711-06c2-40c3-8e70-4fd2a53c953d");
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
				UId = new Guid("73bbc987-2ab8-4ce5-b0ec-c0299d1e72fc"),
				Name = "Terrasoft.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("f56ba749-b4df-4ded-b740-db30fa3555ae")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("c6864213-e7e8-465d-9b94-a5a82f858e94"),
				Name = "System.Linq",
				Alias = "",
				CreatedInPackageId = new Guid("b8cfc307-6cc7-46a0-adc5-c5052e6561f5")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("3ae3ffad-15b4-47e6-a1e7-da480e16ae8a"),
				Name = "Terrasoft.Core.ImageAPI",
				Alias = "",
				CreatedInPackageId = new Guid("b8cfc307-6cc7-46a0-adc5-c5052e6561f5")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("0017f56e-396d-4e72-a989-2c9800690b07"),
				Name = "Terrasoft.Messaging.Common",
				Alias = "",
				CreatedInPackageId = new Guid("f56ba749-b4df-4ded-b740-db30fa3555ae")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("169a8f30-18f7-46d5-9a44-edcbb48f0929"),
				Name = "System.Runtime.Remoting",
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
			Usings.Add(new SchemaUsing() {
				UId = new Guid("03538de8-86d4-4eea-8c1d-8051bbb379ed"),
				Name = "Terrasoft.Configuration.EntitySynchronization",
				Alias = "",
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			});
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new Contact_MarketingCampaign_TerrasoftEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("29c142b1-866a-43a5-bcdf-42299173d2f4"));
		}

		#endregion

	}

	#endregion

}

