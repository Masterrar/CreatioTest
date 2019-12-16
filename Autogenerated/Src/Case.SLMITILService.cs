namespace Terrasoft.Configuration
{

	using CoreSysSettings = Terrasoft.Core.Configuration.SysSettings;
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
	using Terrasoft.Configuration;
	using Terrasoft.Configuration.CaseSequenceService;
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

	#region Class: Case_SLMITILService_TerrasoftSchema

	/// <exclude/>
	public class Case_SLMITILService_TerrasoftSchema : Terrasoft.Configuration.Case_SLM_TerrasoftSchema
	{

		#region Constructors: Public

		public Case_SLMITILService_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public Case_SLMITILService_TerrasoftSchema(Case_SLMITILService_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public Case_SLMITILService_TerrasoftSchema(Case_SLMITILService_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private EntitySchemaIndex CreateIX_RegisteredOn_DescIndex() {
			EntitySchemaIndex index = new EntitySchemaIndex() {
				IsAutoName = false,
				IsClustered = false,
				IsUnique = false
			};
			index.UId = new Guid("9ed6688c-3e02-47af-9124-e38e20904716");
			index.Name = "IX_RegisteredOn_Desc";
			index.CreatedInSchemaUId = new Guid("117d32f9-8275-4534-8411-1c66115ce9cd");
			index.ModifiedInSchemaUId = new Guid("117d32f9-8275-4534-8411-1c66115ce9cd");
			index.CreatedInPackageId = new Guid("a7919973-994c-4956-b846-530c9ef3b289");
			EntitySchemaIndexColumn registeredOnIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("aa03e37c-3527-4b5c-a16c-53fbc178b41e"),
				ColumnUId = new Guid("c91a9a6f-008d-4b2e-83d5-03868ad68c99"),
				CreatedInSchemaUId = new Guid("117d32f9-8275-4534-8411-1c66115ce9cd"),
				ModifiedInSchemaUId = new Guid("117d32f9-8275-4534-8411-1c66115ce9cd"),
				CreatedInPackageId = new Guid("a7919973-994c-4956-b846-530c9ef3b289"),
				OrderDirection = OrderDirectionStrict.Descending
			};
			index.Columns.Add(registeredOnIndexColumn);
			return index;
		}

		private EntitySchemaIndex CreateIX_SolutionOverdue_AttributesIndex() {
			EntitySchemaIndex index = new EntitySchemaIndex() {
				IsAutoName = false,
				IsClustered = false,
				IsUnique = false
			};
			index.UId = new Guid("9ad0ba05-3b32-4561-8bfc-870aee9c951c");
			index.Name = "IX_SolutionOverdue_Attributes";
			index.CreatedInSchemaUId = new Guid("7d80c5f8-f594-44e3-b87e-31b7f7432c4c");
			index.ModifiedInSchemaUId = new Guid("7d80c5f8-f594-44e3-b87e-31b7f7432c4c");
			index.CreatedInPackageId = new Guid("c3c90037-274c-4793-841e-197eb228d3cd");
			EntitySchemaIndexColumn solutionProvidedOnIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("4f3631c8-b14e-4591-a25a-b9207401cfa2"),
				ColumnUId = new Guid("81552f0a-fd92-4865-9533-f4c3ab2861a7"),
				CreatedInSchemaUId = new Guid("7d80c5f8-f594-44e3-b87e-31b7f7432c4c"),
				ModifiedInSchemaUId = new Guid("7d80c5f8-f594-44e3-b87e-31b7f7432c4c"),
				CreatedInPackageId = new Guid("c3c90037-274c-4793-841e-197eb228d3cd"),
				OrderDirection = OrderDirectionStrict.Descending
			};
			index.Columns.Add(solutionProvidedOnIndexColumn);
			EntitySchemaIndexColumn solutionDateIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("5de35510-255d-4f3f-8119-9a3f9b8082f5"),
				ColumnUId = new Guid("624839d1-3bd0-45e0-95d1-28326703f19c"),
				CreatedInSchemaUId = new Guid("7d80c5f8-f594-44e3-b87e-31b7f7432c4c"),
				ModifiedInSchemaUId = new Guid("7d80c5f8-f594-44e3-b87e-31b7f7432c4c"),
				CreatedInPackageId = new Guid("c3c90037-274c-4793-841e-197eb228d3cd"),
				OrderDirection = OrderDirectionStrict.Descending
			};
			index.Columns.Add(solutionDateIndexColumn);
			EntitySchemaIndexColumn solutionOverdueIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("8dab4368-f988-43de-a48e-bbf238fc3237"),
				ColumnUId = new Guid("0fa66efc-d2d0-47b9-abab-9e3ad2ea82d3"),
				CreatedInSchemaUId = new Guid("7d80c5f8-f594-44e3-b87e-31b7f7432c4c"),
				ModifiedInSchemaUId = new Guid("7d80c5f8-f594-44e3-b87e-31b7f7432c4c"),
				CreatedInPackageId = new Guid("c3c90037-274c-4793-841e-197eb228d3cd"),
				OrderDirection = OrderDirectionStrict.Ascending
			};
			index.Columns.Add(solutionOverdueIndexColumn);
			return index;
		}

		private EntitySchemaIndex CreateIX_ResponseOverdue_AttributesIndex() {
			EntitySchemaIndex index = new EntitySchemaIndex() {
				IsAutoName = false,
				IsClustered = false,
				IsUnique = false
			};
			index.UId = new Guid("8d002ad1-0715-4bdc-aa5e-8be1a5e39381");
			index.Name = "IX_ResponseOverdue_Attributes";
			index.CreatedInSchemaUId = new Guid("7d80c5f8-f594-44e3-b87e-31b7f7432c4c");
			index.ModifiedInSchemaUId = new Guid("7d80c5f8-f594-44e3-b87e-31b7f7432c4c");
			index.CreatedInPackageId = new Guid("c3c90037-274c-4793-841e-197eb228d3cd");
			EntitySchemaIndexColumn respondedOnIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("14abc9af-1b98-4ee2-b236-3a9576b1770f"),
				ColumnUId = new Guid("02612dc8-7243-4acb-b0bd-abbd19e24136"),
				CreatedInSchemaUId = new Guid("7d80c5f8-f594-44e3-b87e-31b7f7432c4c"),
				ModifiedInSchemaUId = new Guid("7d80c5f8-f594-44e3-b87e-31b7f7432c4c"),
				CreatedInPackageId = new Guid("c3c90037-274c-4793-841e-197eb228d3cd"),
				OrderDirection = OrderDirectionStrict.Descending
			};
			index.Columns.Add(respondedOnIndexColumn);
			EntitySchemaIndexColumn responseDateIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("c3226bd5-beb9-48ea-9383-30fb120d4f4d"),
				ColumnUId = new Guid("25280121-c075-441f-b4f8-feeb6cc7ca38"),
				CreatedInSchemaUId = new Guid("7d80c5f8-f594-44e3-b87e-31b7f7432c4c"),
				ModifiedInSchemaUId = new Guid("7d80c5f8-f594-44e3-b87e-31b7f7432c4c"),
				CreatedInPackageId = new Guid("c3c90037-274c-4793-841e-197eb228d3cd"),
				OrderDirection = OrderDirectionStrict.Descending
			};
			index.Columns.Add(responseDateIndexColumn);
			EntitySchemaIndexColumn responseOverdueIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("a4aaaa1e-d84e-48a2-84ac-04c35a6fad1e"),
				ColumnUId = new Guid("1ed4e080-0bf8-4f4f-97e8-b3e22f3240a0"),
				CreatedInSchemaUId = new Guid("7d80c5f8-f594-44e3-b87e-31b7f7432c4c"),
				ModifiedInSchemaUId = new Guid("7d80c5f8-f594-44e3-b87e-31b7f7432c4c"),
				CreatedInPackageId = new Guid("c3c90037-274c-4793-841e-197eb228d3cd"),
				OrderDirection = OrderDirectionStrict.Ascending
			};
			index.Columns.Add(responseOverdueIndexColumn);
			return index;
		}

		private EntitySchemaIndex CreateIDX_SubjectIndex() {
			EntitySchemaIndex index = new EntitySchemaIndex() {
				IsAutoName = false,
				IsClustered = false,
				IsUnique = false
			};
			index.UId = new Guid("e675ceca-ff2f-44c2-bd1a-f2c1af261cba");
			index.Name = "IDX_Subject";
			index.CreatedInSchemaUId = new Guid("117d32f9-8275-4534-8411-1c66115ce9cd");
			index.ModifiedInSchemaUId = new Guid("117d32f9-8275-4534-8411-1c66115ce9cd");
			index.CreatedInPackageId = new Guid("ff020f92-eb95-49ea-a251-6a0ed7e274a5");
			EntitySchemaIndexColumn subjectIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("5f164afe-e5a5-40a6-9e32-b7f83656bba8"),
				ColumnUId = new Guid("ffe8526d-044f-4222-a1ef-fca83a0772d8"),
				CreatedInSchemaUId = new Guid("117d32f9-8275-4534-8411-1c66115ce9cd"),
				ModifiedInSchemaUId = new Guid("117d32f9-8275-4534-8411-1c66115ce9cd"),
				CreatedInPackageId = new Guid("ff020f92-eb95-49ea-a251-6a0ed7e274a5"),
				OrderDirection = OrderDirectionStrict.Ascending
			};
			index.Columns.Add(subjectIndexColumn);
			return index;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("8568d092-83e6-4a24-8ab8-391fca7f750d");
			Name = "Case_SLMITILService_Terrasoft";
			ParentSchemaUId = new Guid("117d32f9-8275-4534-8411-1c66115ce9cd");
			ExtendParent = true;
			CreatedInPackageId = new Guid("20093be1-4c70-48d8-849b-123fc8391b10");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("6ab42472-7828-4d51-a3e6-c38b485f3252")) == null) {
				Columns.Add(CreateServicePactColumn());
			}
			if (Columns.FindByUId(new Guid("86567001-01f1-403b-8b2e-34ee5d17c811")) == null) {
				Columns.Add(CreateServiceCategoryColumn());
			}
			if (Columns.FindByUId(new Guid("6bc89a93-6a89-4d71-ad7c-df9d81c15978")) == null) {
				Columns.Add(CreateSolvedOnSupportLevelColumn());
			}
			if (Columns.FindByUId(new Guid("869fd0ea-052e-4107-b426-ea8176e370dc")) == null) {
				Columns.Add(CreateSupportLevelColumn());
			}
			if (Columns.FindByUId(new Guid("2042c68f-9121-4974-87fd-d7d8c8b596f0")) == null) {
				Columns.Add(CreateHolderColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateServicePactColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("6ab42472-7828-4d51-a3e6-c38b485f3252"),
				Name = @"ServicePact",
				ReferenceSchemaUId = new Guid("595ddbda-31ce-4cca-9bdd-862257ceaf23"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("8568d092-83e6-4a24-8ab8-391fca7f750d"),
				ModifiedInSchemaUId = new Guid("8568d092-83e6-4a24-8ab8-391fca7f750d"),
				CreatedInPackageId = new Guid("20093be1-4c70-48d8-849b-123fc8391b10")
			};
		}

		protected virtual EntitySchemaColumn CreateServiceCategoryColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("86567001-01f1-403b-8b2e-34ee5d17c811"),
				Name = @"ServiceCategory",
				ReferenceSchemaUId = new Guid("d76eaeaf-9ffc-4556-b8ad-87e2823e1e84"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("8568d092-83e6-4a24-8ab8-391fca7f750d"),
				ModifiedInSchemaUId = new Guid("8568d092-83e6-4a24-8ab8-391fca7f750d"),
				CreatedInPackageId = new Guid("8802bbbd-af3c-4897-a646-e8600063382a")
			};
		}

		protected virtual EntitySchemaColumn CreateSolvedOnSupportLevelColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("6bc89a93-6a89-4d71-ad7c-df9d81c15978"),
				Name = @"SolvedOnSupportLevel",
				ReferenceSchemaUId = new Guid("4c2e1b60-ee12-4846-a38e-04204de6fb14"),
				IsValueCloneable = false,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("8568d092-83e6-4a24-8ab8-391fca7f750d"),
				ModifiedInSchemaUId = new Guid("8568d092-83e6-4a24-8ab8-391fca7f750d"),
				CreatedInPackageId = new Guid("2ae03e06-9f1c-4d5c-b222-14d44604b4b1")
			};
		}

		protected virtual EntitySchemaColumn CreateSupportLevelColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("869fd0ea-052e-4107-b426-ea8176e370dc"),
				Name = @"SupportLevel",
				ReferenceSchemaUId = new Guid("4c2e1b60-ee12-4846-a38e-04204de6fb14"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("8568d092-83e6-4a24-8ab8-391fca7f750d"),
				ModifiedInSchemaUId = new Guid("8568d092-83e6-4a24-8ab8-391fca7f750d"),
				CreatedInPackageId = new Guid("2ae03e06-9f1c-4d5c-b222-14d44604b4b1"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Settings,
					ValueSource = @"CaseServiceLevelDef"
				}
			};
		}

		protected virtual EntitySchemaColumn CreateHolderColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("2042c68f-9121-4974-87fd-d7d8c8b596f0"),
				Name = @"Holder",
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("8568d092-83e6-4a24-8ab8-391fca7f750d"),
				ModifiedInSchemaUId = new Guid("8568d092-83e6-4a24-8ab8-391fca7f750d"),
				CreatedInPackageId = new Guid("2ae03e06-9f1c-4d5c-b222-14d44604b4b1")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeIndexes() {
			base.InitializeIndexes();
			Indexes.Add(CreateIX_RegisteredOn_DescIndex());
			Indexes.Add(CreateIX_SolutionOverdue_AttributesIndex());
			Indexes.Add(CreateIX_ResponseOverdue_AttributesIndex());
			Indexes.Add(CreateIDX_SubjectIndex());
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateCase_SLMITILService_TerrasoftEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateCase_SLMITILService_TerrasoftEventsProcessSchema() {
			var schema = new Case_SLMITILService_TerrasoftEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new Case_SLMITILService_Terrasoft(userConnection){Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new Case_SLMITILServiceEventsProcess(userConnnection);
		}

		public override object Clone() {
			return new Case_SLMITILService_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new Case_SLMITILService_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("8568d092-83e6-4a24-8ab8-391fca7f750d"));
		}

		#endregion

	}

	#endregion

	#region Class: Case_SLMITILService_Terrasoft

	/// <summary>
	/// Case.
	/// </summary>
	public class Case_SLMITILService_Terrasoft : Terrasoft.Configuration.Case_SLM_Terrasoft
	{

		#region Constructors: Public

		public Case_SLMITILService_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Case_SLMITILService_Terrasoft";
		}

		public Case_SLMITILService_Terrasoft(Case_SLMITILService_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public  Guid ServicePactId {
			get {
				return GetTypedColumnValue<Guid>("ServicePactId");
			}
			set {
				SetColumnValue("ServicePactId", value);
				_servicePact = null;
			}
		}

		/// <exclude/>
		public  string ServicePactName {
			get {
				return GetTypedColumnValue<string>("ServicePactName");
			}
			set {
				SetColumnValue("ServicePactName", value);
				if (_servicePact != null) {
					_servicePact.Name = value;
				}
			}
		}

		private ServicePact _servicePact;
		/// <summary>
		/// SLA.
		/// </summary>
		public  ServicePact ServicePact {
			get {
				return _servicePact ??
					(_servicePact = LookupColumnEntities.GetEntity("ServicePact") as ServicePact);
			}
		}

		/// <exclude/>
		public  Guid ServiceCategoryId {
			get {
				return GetTypedColumnValue<Guid>("ServiceCategoryId");
			}
			set {
				SetColumnValue("ServiceCategoryId", value);
				_serviceCategory = null;
			}
		}

		/// <exclude/>
		public  string ServiceCategoryName {
			get {
				return GetTypedColumnValue<string>("ServiceCategoryName");
			}
			set {
				SetColumnValue("ServiceCategoryName", value);
				if (_serviceCategory != null) {
					_serviceCategory.Name = value;
				}
			}
		}

		private ServiceCategory _serviceCategory;
		/// <summary>
		/// Service category.
		/// </summary>
		public  ServiceCategory ServiceCategory {
			get {
				return _serviceCategory ??
					(_serviceCategory = LookupColumnEntities.GetEntity("ServiceCategory") as ServiceCategory);
			}
		}

		/// <exclude/>
		public  Guid SolvedOnSupportLevelId {
			get {
				return GetTypedColumnValue<Guid>("SolvedOnSupportLevelId");
			}
			set {
				SetColumnValue("SolvedOnSupportLevelId", value);
				_solvedOnSupportLevel = null;
			}
		}

		/// <exclude/>
		public  string SolvedOnSupportLevelName {
			get {
				return GetTypedColumnValue<string>("SolvedOnSupportLevelName");
			}
			set {
				SetColumnValue("SolvedOnSupportLevelName", value);
				if (_solvedOnSupportLevel != null) {
					_solvedOnSupportLevel.Name = value;
				}
			}
		}

		private RoleInServiceTeam _solvedOnSupportLevel;
		/// <summary>
		/// Resolved by.
		/// </summary>
		public  RoleInServiceTeam SolvedOnSupportLevel {
			get {
				return _solvedOnSupportLevel ??
					(_solvedOnSupportLevel = LookupColumnEntities.GetEntity("SolvedOnSupportLevel") as RoleInServiceTeam);
			}
		}

		/// <exclude/>
		public  Guid SupportLevelId {
			get {
				return GetTypedColumnValue<Guid>("SupportLevelId");
			}
			set {
				SetColumnValue("SupportLevelId", value);
				_supportLevel = null;
			}
		}

		/// <exclude/>
		public  string SupportLevelName {
			get {
				return GetTypedColumnValue<string>("SupportLevelName");
			}
			set {
				SetColumnValue("SupportLevelName", value);
				if (_supportLevel != null) {
					_supportLevel.Name = value;
				}
			}
		}

		private RoleInServiceTeam _supportLevel;
		/// <summary>
		/// Support line.
		/// </summary>
		public  RoleInServiceTeam SupportLevel {
			get {
				return _supportLevel ??
					(_supportLevel = LookupColumnEntities.GetEntity("SupportLevel") as RoleInServiceTeam);
			}
		}

		/// <exclude/>
		public  Guid HolderId {
			get {
				return GetTypedColumnValue<Guid>("HolderId");
			}
			set {
				SetColumnValue("HolderId", value);
				_holder = null;
			}
		}

		/// <exclude/>
		public  string HolderName {
			get {
				return GetTypedColumnValue<string>("HolderName");
			}
			set {
				SetColumnValue("HolderName", value);
				if (_holder != null) {
					_holder.Name = value;
				}
			}
		}

		private Contact _holder;
		/// <summary>
		/// Holder.
		/// </summary>
		public  Contact Holder {
			get {
				return _holder ??
					(_holder = LookupColumnEntities.GetEntity("Holder") as Contact);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new Case_SLMITILServiceEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Saved += (s, e) => ThrowEvent("Case_SLMITILService_TerrasoftSaved", e);
			Saving += (s, e) => ThrowEvent("Case_SLMITILService_TerrasoftSaving", e);
			Validating += (s, e) => ThrowEvent("Case_SLMITILService_TerrasoftValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new Case_SLMITILService_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: Case_SLMITILServiceEventsProcess

	/// <exclude/>
	public class Case_SLMITILServiceEventsProcess<TEntity> : Terrasoft.Configuration.Case_SLMEventsProcess<TEntity> where TEntity : Case_SLMITILService_Terrasoft
	{

		public Case_SLMITILServiceEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Case_SLMITILServiceEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private  Guid InternalSchemaUId {
			get {
				return new Guid("8568d092-83e6-4a24-8ab8-391fca7f750d");
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

		public override void LocalMessageExecuting(EntityChangeType changeType) {
			var lmHelper = new Terrasoft.Configuration.LocalMessageHelper(this.Entity, UserConnection, changeType);
			lmHelper.CreateLocalMessage();
		}

		public override string GetServiceCaption() {
			var serviceItemId = Entity.GetTypedColumnValue<Guid>("ServiceItemId");
			var serviceQuery = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "ServiceItem");
			serviceQuery.AddColumn("Name"); 
			var service = serviceQuery .GetEntity(UserConnection, serviceItemId);
			if(service == null) {
				return string.Empty;
			} 
			return service.GetTypedColumnValue<string>("Name"); 
		}

		public override List<string> GetLoggingColumns() {
			var columns = base.GetLoggingColumns();
			columns.Add("SupportLevelId");
			return columns;
		}

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

	#region Class: Case_SLMITILServiceEventsProcess

	/// <exclude/>
	public class Case_SLMITILServiceEventsProcess : Case_SLMITILServiceEventsProcess<Case_SLMITILService_Terrasoft>
	{

		public Case_SLMITILServiceEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: Case_SLMITILService_TerrasoftEventsProcessSchema

	/// <exclude/>
	public class Case_SLMITILService_TerrasoftEventsProcessSchema : Terrasoft.Configuration.Case_SLM_TerrasoftEventsProcessSchema
	{

		#region Constructors: Public

		public Case_SLMITILService_TerrasoftEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public Case_SLMITILService_TerrasoftEventsProcessSchema(Case_SLMITILService_TerrasoftEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "Case_SLMITILServiceEventsProcess";
			UId = new Guid("34b20856-18a7-4713-95ec-eed3c4c96160");
			CreatedInPackageId = new Guid("20093be1-4c70-48d8-849b-123fc8391b10");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("2e4ad2a2-869c-48da-b867-91374c625baa");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaSLMITILService_LaneSet2 = CreateSLMITILService_LaneSet2LaneSet();
			LaneSets.Add(schemaSLMITILService_LaneSet2);
			ProcessSchemaLane schemaSLMITILService_Lane3 = CreateSLMITILService_Lane3Lane();
			schemaSLMITILService_LaneSet2.Lanes.Add(schemaSLMITILService_Lane3);
		}

		protected virtual ProcessSchemaLaneSet CreateSLMITILService_LaneSet2LaneSet() {
			ProcessSchemaLaneSet schemaSLMITILService_LaneSet2 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("3c7a480c-bc2c-4622-a29e-05825d57c737"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("08d19c3e-cef5-4a07-9fae-18525efc876b"),
				CreatedInPackageId = new Guid("5be0374d-f3b5-4c63-b887-7fd46e962c93"),
				CreatedInSchemaUId = new Guid("34b20856-18a7-4713-95ec-eed3c4c96160"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("34b20856-18a7-4713-95ec-eed3c4c96160"),
				Name = @"SLMITILService_LaneSet2",
				Position = new Point(0, 5),
				Size = new Size(0, 400),
				UseBackgroundMode = false
			};
			return schemaSLMITILService_LaneSet2;
		}

		protected virtual ProcessSchemaLane CreateSLMITILService_Lane3Lane() {
			ProcessSchemaLane schemaSLMITILService_Lane3 = new ProcessSchemaLane(this) {
				UId = new Guid("ddf125e6-8aa8-4ae5-b671-121f0a91c67f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("3c7a480c-bc2c-4622-a29e-05825d57c737"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("5be0374d-f3b5-4c63-b887-7fd46e962c93"),
				CreatedInSchemaUId = new Guid("34b20856-18a7-4713-95ec-eed3c4c96160"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("34b20856-18a7-4713-95ec-eed3c4c96160"),
				Name = @"SLMITILService_Lane3",
				Position = new Point(0, 0),
				Size = new Size(700, 400),
				UseBackgroundMode = false
			};
			return schemaSLMITILService_Lane3;
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
				CreatedInPackageId = new Guid("4bc36079-7dbb-41e6-9a4e-b85039bf2a70")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("cde525cf-d220-4d2a-b963-e55254c639fc"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("4bc36079-7dbb-41e6-9a4e-b85039bf2a70")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5c9c82c6-ba6d-4a57-9a14-87fe8faa4ebb"),
				Name = "Terrasoft.Core.DB",
				Alias = "",
				CreatedInPackageId = new Guid("4bc36079-7dbb-41e6-9a4e-b85039bf2a70")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7821de68-c82b-4917-a6cd-add2adfbe400"),
				Name = "Terrasoft.Common",
				Alias = "",
				CreatedInPackageId = new Guid("4bc36079-7dbb-41e6-9a4e-b85039bf2a70")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d67de76f-9cbc-4bfc-babb-6f65cb89b973"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("4bc36079-7dbb-41e6-9a4e-b85039bf2a70")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("74160d3b-65e3-4694-b554-089f2d980e54"),
				Name = "Newtonsoft.Json",
				Alias = "",
				CreatedInPackageId = new Guid("4bc36079-7dbb-41e6-9a4e-b85039bf2a70")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e401300a-9f16-40c2-9788-cf310ae9d1c5"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("4bc36079-7dbb-41e6-9a4e-b85039bf2a70")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("bed5e433-d5cb-4c18-9dbe-5d423c021d39"),
				Name = "Terrasoft.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("677baab4-893e-4898-b508-38190fd135a7")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d5bb3512-71e0-482a-9c7e-16bf22c586b7"),
				Name = "Terrasoft.Nui.ServiceModel.DataContract",
				Alias = "DataContract",
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("67f53755-c06e-485d-88cf-faa5ea95f5f3"),
				Name = "System.Linq",
				Alias = "",
				CreatedInPackageId = new Guid("c3c90037-274c-4793-841e-197eb228d3cd")
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
				UId = new Guid("b5657843-65bd-4915-8bd8-7e4ff6da55c4"),
				Name = "Terrasoft.Core",
				Alias = "",
				CreatedInPackageId = new Guid("c3c90037-274c-4793-841e-197eb228d3cd")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e686ca87-b149-46cb-b557-f1cd4001bd3c"),
				Name = "Terrasoft.Core.Configuration.SysSettings",
				Alias = "CoreSysSettings",
				CreatedInPackageId = new Guid("c3c90037-274c-4793-841e-197eb228d3cd")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("9ce71bdf-0d43-4122-aafb-d9cd53cc4b84"),
				Name = "Terrasoft.Configuration.CaseSequenceService",
				Alias = "",
				CreatedInPackageId = new Guid("c3c90037-274c-4793-841e-197eb228d3cd")
			});
		}

		protected override SchemaMethod CreateLocalMessageExecutingMethod() {
			SchemaMethod method = base.CreateLocalMessageExecutingMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,77,141,75,10,194,48,16,134,247,158,98,150,45,148,92,160,184,42,130,11,221,213,3,12,225,111,26,136,147,50,51,86,122,123,45,69,112,255,61,86,86,42,207,43,202,2,165,51,9,222,52,66,149,173,78,30,134,42,83,78,47,101,207,85,194,173,70,46,119,152,113,194,33,52,62,103,11,23,241,236,91,71,15,131,126,13,65,220,241,142,226,204,146,48,110,11,218,254,244,123,132,65,193,142,255,86,211,246,31,106,54,191,216,134,0,0,0 };
			return method;
		}

		protected override SchemaMethod CreateGetServiceCaptionMethod() {
			SchemaMethod method = base.CreateGetServiceCaptionMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,144,209,10,130,48,20,134,175,243,41,134,87,10,225,11,88,66,136,136,23,5,97,117,63,244,100,131,237,40,115,51,36,122,247,102,90,206,232,246,236,252,223,247,159,117,84,146,22,100,199,10,200,20,136,172,36,91,146,160,98,170,15,82,80,167,190,129,50,174,185,22,120,161,92,195,38,213,172,140,60,55,183,19,174,31,58,221,140,57,106,144,189,161,32,220,39,82,94,220,64,208,247,220,59,155,173,184,70,132,66,177,26,3,123,97,79,145,86,32,215,196,198,15,112,27,28,236,202,169,144,231,30,168,0,243,78,108,187,17,47,122,12,87,140,146,31,245,122,121,182,209,176,171,247,133,152,250,154,115,159,60,156,149,4,165,37,146,86,73,134,85,144,136,70,245,161,243,36,206,103,62,70,254,254,214,152,137,230,166,47,145,106,202,35,110,1,0,0 };
			return method;
		}

		protected override SchemaMethod CreateGetLoggingColumnsMethod() {
			SchemaMethod method = base.CreateGetLoggingColumnsMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,75,44,82,72,206,207,41,205,205,43,86,176,85,72,74,44,78,213,115,79,45,241,201,79,79,207,204,75,119,134,72,104,104,90,115,65,213,232,57,166,164,104,40,5,151,22,20,228,23,149,248,164,150,165,230,120,166,40,1,165,139,82,75,74,139,242,96,38,89,3,0,44,213,14,166,86,0,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new Case_SLMITILService_TerrasoftEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("34b20856-18a7-4713-95ec-eed3c4c96160"));
		}

		#endregion

	}

	#endregion

}

