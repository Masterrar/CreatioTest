namespace Terrasoft.Core.Process
{

	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Drawing;
	using System.Globalization;
	using System.Text;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;

	#region Class: Presentation780

	/// <exclude/>
	public class Presentation780 : Terrasoft.Core.Process.Process
	{

		#region Class: ProcessLane1

		/// <exclude/>
		public class ProcessLane1 : ProcessLane
		{

			public ProcessLane1(UserConnection userConnection, Presentation780 process)
				: base(userConnection) {
				Owner = process;
				IsUsedParentUserContexts = false;
			}

		}

		#endregion

		#region Class: ReadDataUserTask1FlowElement

		/// <exclude/>
		public class ReadDataUserTask1FlowElement : ReadDataUserTask
		{

			#region Constructors: Public

			public ReadDataUserTask1FlowElement(UserConnection userConnection, Presentation780 process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ReadDataUserTask1";
				IsLogging = true;
				SchemaElementUId = new Guid("de417865-e225-4e44-b0d3-f27a90d7fccc");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
			}

			#endregion

			#region Properties: Public

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,205,83,205,110,211,64,16,126,21,228,115,93,185,182,243,227,220,80,9,168,23,82,169,81,47,184,135,169,61,235,172,88,123,173,221,117,33,68,145,16,47,64,195,35,112,230,208,3,112,224,0,82,34,241,32,60,9,179,118,98,82,20,212,192,1,136,180,202,238,231,111,191,249,102,118,102,230,36,2,180,126,12,57,58,3,103,140,74,129,150,204,28,62,228,194,160,122,164,100,85,58,7,142,70,197,65,240,23,152,54,248,48,229,230,1,24,160,43,179,248,135,66,236,12,226,221,26,177,115,16,59,220,96,174,137,67,87,58,253,36,245,124,143,185,93,214,243,220,48,98,61,23,162,52,117,67,100,24,4,12,67,175,31,53,204,95,137,31,203,188,4,133,77,140,90,158,213,219,241,180,180,212,35,2,146,154,194,181,44,214,96,96,77,232,97,1,151,2,83,58,27,85,33,65,70,241,156,178,193,49,207,241,20,20,197,178,58,210,66,68,98,32,180,101,9,100,102,248,188,84,168,53,151,197,93,230,68,149,23,219,108,18,192,246,184,182,227,213,30,45,243,20,204,164,150,56,33,91,243,218,229,253,44,83,152,129,225,87,219,38,158,226,180,230,237,87,63,186,144,210,43,157,131,168,112,43,230,237,76,142,161,52,77,66,77,120,34,40,158,77,246,206,181,173,216,93,233,250,4,150,27,242,158,154,59,115,240,187,4,94,89,160,81,217,108,99,231,201,137,30,61,43,80,157,37,19,204,161,169,218,197,33,161,63,1,173,254,96,214,9,89,208,233,67,215,77,35,175,239,134,29,255,200,189,100,84,201,32,2,223,247,48,232,65,24,204,47,26,31,92,151,2,166,231,109,184,213,245,242,45,173,15,180,62,173,22,95,223,172,22,223,94,222,208,225,102,181,88,190,190,71,155,47,132,188,122,71,155,207,180,222,215,95,174,151,31,237,63,61,179,253,217,215,144,25,79,64,140,74,84,176,126,8,111,119,159,222,106,112,91,3,37,165,105,50,107,107,56,42,75,169,76,85,112,51,173,61,111,26,134,226,209,28,219,74,158,201,74,37,235,185,209,205,0,255,209,96,254,131,113,251,157,9,218,217,195,251,244,228,127,209,109,127,161,57,230,206,252,59,188,202,208,231,253,5,0,0 })));
				}
				set {
					_dataSourceFilters = value;
				}
			}

			private int _resultType = 0;
			public override int ResultType {
				get {
					return _resultType;
				}
				set {
					_resultType = value;
				}
			}

			private int _functionType = 0;
			public override int FunctionType {
				get {
					return _functionType;
				}
				set {
					_functionType = value;
				}
			}

			private string _orderInfo;
			public override string OrderInfo {
				get {
					return _orderInfo ?? (_orderInfo = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,11,201,44,201,73,181,50,176,50,4,0,118,95,90,255,9,0,0,0 })));
				}
				set {
					_orderInfo = value;
				}
			}

			private Entity _resultEntity;
			public override Entity ResultEntity {
				get {
					return _resultEntity ?? (_resultEntity =
						new Entity(UserConnection) {
							Schema = UserConnection.EntitySchemaManager.GetInstanceByUId(
								new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf")),
							UseAdminRights = false
						});
				}
				set {
					_resultEntity = value;
				}
			}

			private string _entityColumnMetaPathes;
			public override string EntityColumnMetaPathes {
				get {
					return _entityColumnMetaPathes ?? (_entityColumnMetaPathes = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,21,206,203,13,68,33,12,67,209,138,44,1,249,17,189,106,18,72,250,47,97,152,173,23,247,56,106,20,203,9,28,118,1,119,25,130,252,130,34,109,217,174,169,211,62,229,24,146,29,32,25,23,124,179,145,125,55,58,197,60,140,155,188,62,78,151,162,110,244,149,5,142,154,200,17,130,117,100,142,183,79,137,87,218,44,66,241,16,121,8,235,107,70,115,162,143,105,121,23,169,243,71,17,73,177,22,110,93,5,207,80,248,206,4,231,177,19,107,100,14,253,204,45,14,253,37,55,127,159,214,134,15,109,236,213,149,122,243,248,61,63,56,63,150,105,221,0,0,0 })));
				}
				set {
					_entityColumnMetaPathes = value;
				}
			}

			#endregion

		}

		#endregion

		#region Class: ActivityUserTask1FlowElement

		/// <exclude/>
		public class ActivityUserTask1FlowElement : ActivityUserTask
		{

			#region Constructors: Public

			public ActivityUserTask1FlowElement(UserConnection userConnection, Presentation780 process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ActivityUserTask1";
				IsLogging = true;
				SchemaElementUId = new Guid("e2ba9f8a-3b63-436d-930b-3720e5d305da");
				CreatedInSchemaUId = process.InternalSchemaUId;
				ProcessLane = process.Lane1;
				SerializeToDB = true;
				_ownerId = () => (Guid)(((process.ReadDataUserTask1.ResultEntity.IsColumnValueLoaded(process.ReadDataUserTask1.ResultEntity.Schema.Columns.GetByName("Owner").ColumnValueName) ? process.ReadDataUserTask1.ResultEntity.GetTypedColumnValue<Guid>("OwnerId") : Guid.Empty)));
				_duration = () => (int)(30);
				_remindBefore = () => (int)(1);
				_showExecutionPage = () => (bool)((process.OpenConductPresentationCard));
				_lead = () => (Guid)(((process.ReadDataUserTask2.ResultEntity.IsColumnValueLoaded(process.ReadDataUserTask2.ResultEntity.Schema.Columns.GetByName("Id").ColumnValueName) ? process.ReadDataUserTask2.ResultEntity.GetTypedColumnValue<Guid>("Id") : Guid.Empty)));
				_account = () => (Guid)(((process.ReadDataUserTask1.ResultEntity.IsColumnValueLoaded(process.ReadDataUserTask1.ResultEntity.Schema.Columns.GetByName("Account").ColumnValueName) ? process.ReadDataUserTask1.ResultEntity.GetTypedColumnValue<Guid>("AccountId") : Guid.Empty)));
				_contact = () => (Guid)(((process.ReadDataUserTask1.ResultEntity.IsColumnValueLoaded(process.ReadDataUserTask1.ResultEntity.Schema.Columns.GetByName("Contact").ColumnValueName) ? process.ReadDataUserTask1.ResultEntity.GetTypedColumnValue<Guid>("ContactId") : Guid.Empty)));
				_opportunity = () => (Guid)((process.OpportunityId));
			}

			#endregion

			#region Properties: Public

			private LocalizableString _recommendation;
			public override LocalizableString Recommendation {
				get {
					return _recommendation ?? (_recommendation = GetLocalizableString("6bf791ec1818465eaa0654135080911c",
						 "BaseElements.ActivityUserTask1.Parameters.Recommendation.Value"));
				}
				set {
					_recommendation = value;
				}
			}

			private Guid _activityCategory = new Guid("42c74c49-58e6-df11-971b-001d60e938c6");
			public override Guid ActivityCategory {
				get {
					return _activityCategory;
				}
				set {
					_activityCategory = value;
				}
			}

			internal Func<Guid> _ownerId;
			public override Guid OwnerId {
				get {
					return (_ownerId ?? (_ownerId = () => Guid.Empty)).Invoke();
				}
				set {
					_ownerId = () => { return value; };
				}
			}

			internal Func<int> _duration;
			public override int Duration {
				get {
					return (_duration ?? (_duration = () => 0)).Invoke();
				}
				set {
					_duration = () => { return value; };
				}
			}

			private int _durationPeriod = 0;
			public override int DurationPeriod {
				get {
					return _durationPeriod;
				}
				set {
					_durationPeriod = value;
				}
			}

			private int _startIn = 0;
			public override int StartIn {
				get {
					return _startIn;
				}
				set {
					_startIn = value;
				}
			}

			private int _startInPeriod = 0;
			public override int StartInPeriod {
				get {
					return _startInPeriod;
				}
				set {
					_startInPeriod = value;
				}
			}

			internal Func<int> _remindBefore;
			public override int RemindBefore {
				get {
					return (_remindBefore ?? (_remindBefore = () => 0)).Invoke();
				}
				set {
					_remindBefore = () => { return value; };
				}
			}

			private int _remindBeforePeriod = 0;
			public override int RemindBeforePeriod {
				get {
					return _remindBeforePeriod;
				}
				set {
					_remindBeforePeriod = value;
				}
			}

			private bool _showInScheduler = true;
			public override bool ShowInScheduler {
				get {
					return _showInScheduler;
				}
				set {
					_showInScheduler = value;
				}
			}

			internal Func<bool> _showExecutionPage;
			public override bool ShowExecutionPage {
				get {
					return (_showExecutionPage ?? (_showExecutionPage = () => false)).Invoke();
				}
				set {
					_showExecutionPage = () => { return value; };
				}
			}

			internal Func<Guid> _lead;
			public override Guid Lead {
				get {
					return (_lead ?? (_lead = () => Guid.Empty)).Invoke();
				}
				set {
					_lead = () => { return value; };
				}
			}

			internal Func<Guid> _account;
			public override Guid Account {
				get {
					return (_account ?? (_account = () => Guid.Empty)).Invoke();
				}
				set {
					_account = () => { return value; };
				}
			}

			internal Func<Guid> _contact;
			public override Guid Contact {
				get {
					return (_contact ?? (_contact = () => Guid.Empty)).Invoke();
				}
				set {
					_contact = () => { return value; };
				}
			}

			internal Func<Guid> _opportunity;
			public override Guid Opportunity {
				get {
					return (_opportunity ?? (_opportunity = () => Guid.Empty)).Invoke();
				}
				set {
					_opportunity = () => { return value; };
				}
			}

			private LocalizableString _informationOnStep;
			public override LocalizableString InformationOnStep {
				get {
					return _informationOnStep ?? (_informationOnStep = GetLocalizableString("6bf791ec1818465eaa0654135080911c",
						 "BaseElements.ActivityUserTask1.Parameters.InformationOnStep.Value"));
				}
				set {
					_informationOnStep = value;
				}
			}

			#endregion

			#region Methods: Public

			public override string GetResultAllowedValues() {
				return "[\"dbbf0e10-f46b-1410-6598-00155d043204\",\"632afdd2-f616-4ea6-87d2-8ed38eed8aff\"]";
			}

			#endregion

			#region Methods: Protected

			protected override void AfterActivitySaveScriptExecute(Entity activity) {
			}

			#endregion

		}

		#endregion

		#region Class: ActivityUserTask2FlowElement

		/// <exclude/>
		public class ActivityUserTask2FlowElement : ActivityUserTask
		{

			#region Constructors: Public

			public ActivityUserTask2FlowElement(UserConnection userConnection, Presentation780 process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ActivityUserTask2";
				IsLogging = true;
				SchemaElementUId = new Guid("de1cbaa9-ae2f-4b76-8aeb-8885bcd9ebdc");
				CreatedInSchemaUId = process.InternalSchemaUId;
				ProcessLane = process.Lane1;
				SerializeToDB = true;
				_ownerId = () => (Guid)(((process.ReadDataUserTask1.ResultEntity.IsColumnValueLoaded(process.ReadDataUserTask1.ResultEntity.Schema.Columns.GetByName("Owner").ColumnValueName) ? process.ReadDataUserTask1.ResultEntity.GetTypedColumnValue<Guid>("OwnerId") : Guid.Empty)));
				_duration = () => (int)(30);
				_remindBefore = () => (int)(15);
				_account = () => (Guid)(((process.ReadDataUserTask1.ResultEntity.IsColumnValueLoaded(process.ReadDataUserTask1.ResultEntity.Schema.Columns.GetByName("Account").ColumnValueName) ? process.ReadDataUserTask1.ResultEntity.GetTypedColumnValue<Guid>("AccountId") : Guid.Empty)));
				_contact = () => (Guid)(((process.ReadDataUserTask1.ResultEntity.IsColumnValueLoaded(process.ReadDataUserTask1.ResultEntity.Schema.Columns.GetByName("Contact").ColumnValueName) ? process.ReadDataUserTask1.ResultEntity.GetTypedColumnValue<Guid>("ContactId") : Guid.Empty)));
				_opportunity = () => (Guid)((process.OpportunityId));
			}

			#endregion

			#region Properties: Public

			private LocalizableString _recommendation;
			public override LocalizableString Recommendation {
				get {
					return _recommendation ?? (_recommendation = GetLocalizableString("6bf791ec1818465eaa0654135080911c",
						 "BaseElements.ActivityUserTask2.Parameters.Recommendation.Value"));
				}
				set {
					_recommendation = value;
				}
			}

			private Guid _activityCategory = new Guid("f51c4643-58e6-df11-971b-001d60e938c6");
			public override Guid ActivityCategory {
				get {
					return _activityCategory;
				}
				set {
					_activityCategory = value;
				}
			}

			internal Func<Guid> _ownerId;
			public override Guid OwnerId {
				get {
					return (_ownerId ?? (_ownerId = () => Guid.Empty)).Invoke();
				}
				set {
					_ownerId = () => { return value; };
				}
			}

			internal Func<int> _duration;
			public override int Duration {
				get {
					return (_duration ?? (_duration = () => 0)).Invoke();
				}
				set {
					_duration = () => { return value; };
				}
			}

			private int _durationPeriod = 0;
			public override int DurationPeriod {
				get {
					return _durationPeriod;
				}
				set {
					_durationPeriod = value;
				}
			}

			private int _startIn = 60;
			public override int StartIn {
				get {
					return _startIn;
				}
				set {
					_startIn = value;
				}
			}

			private int _startInPeriod = 0;
			public override int StartInPeriod {
				get {
					return _startInPeriod;
				}
				set {
					_startInPeriod = value;
				}
			}

			internal Func<int> _remindBefore;
			public override int RemindBefore {
				get {
					return (_remindBefore ?? (_remindBefore = () => 0)).Invoke();
				}
				set {
					_remindBefore = () => { return value; };
				}
			}

			private int _remindBeforePeriod = 0;
			public override int RemindBeforePeriod {
				get {
					return _remindBeforePeriod;
				}
				set {
					_remindBeforePeriod = value;
				}
			}

			private bool _showInScheduler = true;
			public override bool ShowInScheduler {
				get {
					return _showInScheduler;
				}
				set {
					_showInScheduler = value;
				}
			}

			private bool _showExecutionPage = false;
			public override bool ShowExecutionPage {
				get {
					return _showExecutionPage;
				}
				set {
					_showExecutionPage = value;
				}
			}

			internal Func<Guid> _account;
			public override Guid Account {
				get {
					return (_account ?? (_account = () => Guid.Empty)).Invoke();
				}
				set {
					_account = () => { return value; };
				}
			}

			internal Func<Guid> _contact;
			public override Guid Contact {
				get {
					return (_contact ?? (_contact = () => Guid.Empty)).Invoke();
				}
				set {
					_contact = () => { return value; };
				}
			}

			internal Func<Guid> _opportunity;
			public override Guid Opportunity {
				get {
					return (_opportunity ?? (_opportunity = () => Guid.Empty)).Invoke();
				}
				set {
					_opportunity = () => { return value; };
				}
			}

			private LocalizableString _informationOnStep;
			public override LocalizableString InformationOnStep {
				get {
					return _informationOnStep ?? (_informationOnStep = GetLocalizableString("6bf791ec1818465eaa0654135080911c",
						 "BaseElements.ActivityUserTask2.Parameters.InformationOnStep.Value"));
				}
				set {
					_informationOnStep = value;
				}
			}

			#endregion

			#region Methods: Public

			public override string GetResultAllowedValues() {
				return "[\"632afdd2-f616-4ea6-87d2-8ed38eed8aff\"]";
			}

			#endregion

			#region Methods: Protected

			protected override void AfterActivitySaveScriptExecute(Entity activity) {
			}

			#endregion

		}

		#endregion

		#region Class: CallUserTask1FlowElement

		/// <exclude/>
		public class CallUserTask1FlowElement : CallUserTask
		{

			#region Constructors: Public

			public CallUserTask1FlowElement(UserConnection userConnection, Presentation780 process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "CallUserTask1";
				IsLogging = true;
				SchemaElementUId = new Guid("7759b439-c26f-4535-b56f-174ac5737d38");
				CreatedInSchemaUId = process.InternalSchemaUId;
				ProcessLane = process.Lane1;
				SerializeToDB = true;
				_ownerId = () => (Guid)(((process.ReadDataUserTask1.ResultEntity.IsColumnValueLoaded(process.ReadDataUserTask1.ResultEntity.Schema.Columns.GetByName("Owner").ColumnValueName) ? process.ReadDataUserTask1.ResultEntity.GetTypedColumnValue<Guid>("OwnerId") : Guid.Empty)));
				_remindBefore = () => (int)(5);
				_account = () => (Guid)(((process.ReadDataUserTask1.ResultEntity.IsColumnValueLoaded(process.ReadDataUserTask1.ResultEntity.Schema.Columns.GetByName("Account").ColumnValueName) ? process.ReadDataUserTask1.ResultEntity.GetTypedColumnValue<Guid>("AccountId") : Guid.Empty)));
				_contact = () => (Guid)(((process.ReadDataUserTask1.ResultEntity.IsColumnValueLoaded(process.ReadDataUserTask1.ResultEntity.Schema.Columns.GetByName("Contact").ColumnValueName) ? process.ReadDataUserTask1.ResultEntity.GetTypedColumnValue<Guid>("ContactId") : Guid.Empty)));
				_opportunity = () => (Guid)((process.OpportunityId));
			}

			#endregion

			#region Properties: Public

			private LocalizableString _recommendation;
			public override LocalizableString Recommendation {
				get {
					return _recommendation ?? (_recommendation = GetLocalizableString("6bf791ec1818465eaa0654135080911c",
						 "BaseElements.CallUserTask1.Parameters.Recommendation.Value"));
				}
				set {
					_recommendation = value;
				}
			}

			internal Func<Guid> _ownerId;
			public override Guid OwnerId {
				get {
					return (_ownerId ?? (_ownerId = () => Guid.Empty)).Invoke();
				}
				set {
					_ownerId = () => { return value; };
				}
			}

			private int _duration = 5;
			public override int Duration {
				get {
					return _duration;
				}
				set {
					_duration = value;
				}
			}

			private int _durationPeriod = 0;
			public override int DurationPeriod {
				get {
					return _durationPeriod;
				}
				set {
					_durationPeriod = value;
				}
			}

			private int _startIn = 30;
			public override int StartIn {
				get {
					return _startIn;
				}
				set {
					_startIn = value;
				}
			}

			private int _startInPeriod = 0;
			public override int StartInPeriod {
				get {
					return _startInPeriod;
				}
				set {
					_startInPeriod = value;
				}
			}

			internal Func<int> _remindBefore;
			public override int RemindBefore {
				get {
					return (_remindBefore ?? (_remindBefore = () => 0)).Invoke();
				}
				set {
					_remindBefore = () => { return value; };
				}
			}

			private int _remindBeforePeriod = 0;
			public override int RemindBeforePeriod {
				get {
					return _remindBeforePeriod;
				}
				set {
					_remindBeforePeriod = value;
				}
			}

			private bool _showInScheduler = true;
			public override bool ShowInScheduler {
				get {
					return _showInScheduler;
				}
				set {
					_showInScheduler = value;
				}
			}

			private bool _showExecutionPage = false;
			public override bool ShowExecutionPage {
				get {
					return _showExecutionPage;
				}
				set {
					_showExecutionPage = value;
				}
			}

			internal Func<Guid> _account;
			public override Guid Account {
				get {
					return (_account ?? (_account = () => Guid.Empty)).Invoke();
				}
				set {
					_account = () => { return value; };
				}
			}

			internal Func<Guid> _contact;
			public override Guid Contact {
				get {
					return (_contact ?? (_contact = () => Guid.Empty)).Invoke();
				}
				set {
					_contact = () => { return value; };
				}
			}

			internal Func<Guid> _opportunity;
			public override Guid Opportunity {
				get {
					return (_opportunity ?? (_opportunity = () => Guid.Empty)).Invoke();
				}
				set {
					_opportunity = () => { return value; };
				}
			}

			private LocalizableString _informationOnStep;
			public override LocalizableString InformationOnStep {
				get {
					return _informationOnStep ?? (_informationOnStep = GetLocalizableString("6bf791ec1818465eaa0654135080911c",
						 "BaseElements.CallUserTask1.Parameters.InformationOnStep.Value"));
				}
				set {
					_informationOnStep = value;
				}
			}

			#endregion

			#region Methods: Public

			public override string GetResultAllowedValues() {
				return "[\"5fbd327e-f36b-1410-6598-00155d043204\",\"5f0704a8-1749-4f65-98d8-458e7563a23c\",\"fc7d2e5e-f36b-1410-6698-00155d043204\",\"ee2c489d-a4c0-470d-a188-bd76490f0957\"]";
			}

			#endregion

			#region Methods: Protected

			protected override void AfterActivitySaveScriptExecute(Entity activity) {
			}

			#endregion

		}

		#endregion

		#region Class: IntermediateCatchSignal1FlowElement

		/// <exclude/>
		public class IntermediateCatchSignal1FlowElement : ProcessIntermediateCatchSignalEvent
		{

			#region Constructors: Public

			public IntermediateCatchSignal1FlowElement(UserConnection userConnection, Presentation780 process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaIntermediateCatchSignalEvent";
				Name = "IntermediateCatchSignal1";
				IsLogging = true;
				SchemaElementUId = new Guid("66af5845-1e79-40eb-ad97-4fccd670cbdf");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
				Message = "";
				WaitingRandomSignal = false;
				WaitingEntitySignal = true;
				EntitySchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf");
				EntitySignal = EntityChangeType.Updated;
				HasEntityColumnChange = true;
				HasEntityFilters = true;
				EntityChangedColumns = @"{""$type"":""System.Collections.ObjectModel.Collection`1[[System.String, mscorlib]], mscorlib"",""$values"":[""797ac352-4979-4d28-906f-82feb6dbc9dc""]}";
				EntityFilters = @"{""className"":""Terrasoft.FilterGroup"",""serializedFilterEditData"":""{\""className\"":\""Terrasoft.FilterGroup\"",\""items\"":{\""36852a65-0f90-48aa-acc5-332aa012edd2\"":{\""className\"":\""Terrasoft.CompareFilter\"",\""filterType\"":1,\""comparisonType\"":7,\""isEnabled\"":true,\""trimDateTimeParameterToDate\"":false,\""leftExpression\"":{\""className\"":\""Terrasoft.ColumnExpression\"",\""expressionType\"":0,\""columnPath\"":\""Stage.Number\""},\""isAggregative\"":false,\""key\"":\""36852a65-0f90-48aa-acc5-332aa012edd2\"",\""dataValueType\"":4,\""leftExpressionCaption\"":\""Ð¡Ñ‚Ð°Ð´Ð¸Ñ.ÐŸÐ¾Ñ€ÑÐ´ÐºÐ¾Ð²Ñ‹Ð¹ Ð½Ð¾Ð¼ÐµÑ€\"",\""rightExpression\"":{\""className\"":\""Terrasoft.ParameterExpression\"",\""expressionType\"":2,\""parameter\"":{\""className\"":\""Terrasoft.Parameter\"",\""dataValueType\"":26,\""value\"":{\""value\"":\""[IsOwnerSchema:false].[IsSchema:false].[Element:{80cdca17-d9be-4a25-b531-ed4490bd630c}].[Parameter:{d1d0dafb-cdff-4c89-99f2-0973b6c94658}].[EntityColumn:{5cff1d37-c039-46ce-ac3e-a4d7abe49c5f}]\"",\""displayValue\"":\""Ð§Ð¸Ñ‚Ð°Ñ‚ÑŒ Ð½Ð¾Ð¼ÐµÑ€ ÑÑ‚Ð°Ð´Ð¸Ð¸ Ð¿Ñ€Ð¾Ð´Ð°Ð¶Ð¸.ÐŸÐµÑ€Ð²Ñ‹Ð¹ ÑÐ»ÐµÐ¼ÐµÐ½Ñ‚ Ñ€ÐµÐ·ÑƒÐ»ÑŒÑ‚Ð¸Ñ€ÑƒÑŽÑ‰ÐµÐ¹ ÐºÐ¾Ð»Ð»ÐµÐºÑ†Ð¸Ð¸.ÐŸÐ¾Ñ€ÑÐ´ÐºÐ¾Ð²Ñ‹Ð¹ Ð½Ð¾Ð¼ÐµÑ€\""}}}}},\""logicalOperation\"":0,\""isEnabled\"":true,\""filterType\"":6,\""rootSchemaName\"":\""Opportunity\"",\""key\"":\""\""}"",""dataSourceFilters"":""{\""items\"":{\""36852a65-0f90-48aa-acc5-332aa012edd2\"":{\""filterType\"":1,\""comparisonType\"":7,\""isEnabled\"":true,\""trimDateTimeParameterToDate\"":false,\""leftExpression\"":{\""expressionType\"":0,\""columnPath\"":\""Stage.Number\""},\""rightExpression\"":{\""expressionType\"":2,\""parameter\"":{\""dataValueType\"":26,\""value\"":{\""value\"":\""[IsOwnerSchema:false].[IsSchema:false].[Element:{80cdca17-d9be-4a25-b531-ed4490bd630c}].[Parameter:{d1d0dafb-cdff-4c89-99f2-0973b6c94658}].[EntityColumn:{5cff1d37-c039-46ce-ac3e-a4d7abe49c5f}]\""}}}}},\""logicalOperation\"":0,\""isEnabled\"":true,\""filterType\"":6,\""rootSchemaName\"":\""Opportunity\""}""}";
				_recordId = () => (Guid)((process.OpportunityId));
			}

			#endregion

			#region Properties: Public

			internal Func<Guid> _recordId;
			public override Guid RecordId {
				get {
					return (_recordId ?? (_recordId = () => Guid.Empty)).Invoke();
				}
				set {
					_recordId = () => { return value; };
				}
			}

			#endregion

		}

		#endregion

		#region Class: ChangeDataUserTask1FlowElement

		/// <exclude/>
		public class ChangeDataUserTask1FlowElement : ChangeDataUserTask
		{

			#region Constructors: Public

			public ChangeDataUserTask1FlowElement(UserConnection userConnection, Presentation780 process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ChangeDataUserTask1";
				IsLogging = true;
				SchemaElementUId = new Guid("a15a2f3b-7e5e-45fb-af2a-5eae9a70afcd");
				CreatedInSchemaUId = process.InternalSchemaUId;
				_recordColumnValues_Stage = () => (Guid)(new Guid("423774cb-5ae6-df11-971b-001d60e938c6"));
			}

			private Dictionary<string, Func<object>> _getColumnValueFunctions;
			private  Dictionary<string, Func<object>> GetColumnValueFunctions {
				get {
					if (_getColumnValueFunctions == null) {
						_getColumnValueFunctions = new Dictionary<string, Func<object>>();
						_getColumnValueFunctions.Add("_recordColumnValues_Stage", () => _recordColumnValues_Stage.Invoke());
					}
					return _getColumnValueFunctions;
				}
			}

			#endregion

			#region Fields: Internal

			internal Func<Guid> _recordColumnValues_Stage;

			#endregion

			#region Properties: Public

			private Guid _entitySchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf");
			public override Guid EntitySchemaUId {
				get {
					return _entitySchemaUId;
				}
				set {
					_entitySchemaUId = value;
				}
			}

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,205,83,205,110,211,64,16,126,21,228,115,183,242,218,78,98,231,134,74,64,189,144,74,141,122,193,61,140,237,113,178,194,127,218,93,23,66,20,9,241,2,52,125,4,206,28,122,0,14,28,64,74,36,30,132,39,97,214,78,210,22,5,53,112,168,136,180,202,238,231,111,191,249,102,118,102,102,197,25,40,245,28,114,180,250,214,8,165,4,85,166,250,240,169,200,52,202,103,178,172,43,235,192,82,40,5,100,226,13,38,45,62,72,132,126,2,26,232,202,44,188,81,8,173,126,184,91,35,180,14,66,75,104,204,21,113,232,10,239,57,16,185,190,195,128,119,56,243,144,35,139,208,182,25,250,24,39,221,196,78,253,128,183,204,63,137,31,149,121,5,18,219,24,141,124,218,108,71,211,202,80,57,1,113,67,17,170,44,214,160,107,76,168,65,1,81,134,9,157,181,172,145,32,45,69,78,217,224,72,228,120,2,146,98,25,157,210,64,55,164,12,83,61,120,93,73,84,74,148,197,125,222,178,58,47,110,179,73,0,183,199,181,27,187,177,104,152,39,160,39,141,196,49,185,154,55,38,31,143,199,18,199,160,197,133,161,166,144,41,99,226,37,78,27,222,126,229,163,11,9,61,210,25,100,53,222,138,121,55,147,35,168,116,155,80,27,158,8,82,140,39,123,231,186,45,216,125,233,58,4,86,27,242,158,154,59,115,112,186,4,94,24,160,85,217,108,67,235,197,177,26,190,42,80,158,198,19,204,161,173,218,249,33,161,191,1,91,253,254,172,227,165,110,199,135,46,75,2,219,103,94,199,225,44,74,147,132,185,1,56,142,141,110,15,60,119,126,222,250,16,170,202,96,122,182,13,183,186,92,126,160,245,153,214,215,213,226,199,213,106,241,243,237,53,29,174,87,139,229,251,71,180,249,78,200,187,143,180,249,70,235,83,243,229,114,249,197,252,211,51,155,159,121,141,114,44,98,200,134,21,74,88,63,132,189,187,77,239,244,183,169,129,44,75,221,102,182,173,225,176,170,74,169,235,66,232,105,227,121,211,48,62,247,93,112,121,202,184,231,81,195,120,126,196,130,52,238,178,192,235,5,169,223,117,108,14,29,242,68,163,110,170,125,90,214,50,94,143,150,106,103,252,159,102,247,225,39,242,111,134,108,103,155,239,211,182,255,69,67,62,64,255,204,173,249,47,194,157,180,80,31,6,0,0 })));
				}
				set {
					_dataSourceFilters = value;
				}
			}

			private EntityColumnMappingValues _recordColumnValues;
			public override EntityColumnMappingValues RecordColumnValues {
				get {
					if (_recordColumnValues == null) {
						var zippedData = new byte[] { 31,139,8,0,0,0,0,0,4,0,165,83,209,110,155,48,20,253,149,200,237,99,28,129,109,176,157,215,245,37,82,186,69,75,215,151,166,15,215,246,245,138,70,48,194,48,41,139,242,239,35,20,150,166,90,165,73,243,3,200,151,123,206,61,156,99,31,201,109,123,168,145,44,201,3,54,13,196,224,219,197,167,208,224,98,211,4,139,49,46,214,193,66,89,252,2,83,226,6,26,216,99,139,205,35,148,29,198,117,17,219,249,236,26,70,230,228,246,231,240,149,44,159,142,100,213,226,254,219,202,245,236,156,1,102,90,229,84,115,16,84,64,46,168,226,34,167,94,176,204,106,134,2,210,164,7,219,80,118,251,234,30,91,216,64,251,66,150,71,50,176,245,4,82,75,176,60,99,84,104,169,169,112,76,81,157,228,158,42,230,209,228,206,88,237,44,57,205,73,180,47,184,135,97,232,5,12,40,114,111,148,164,54,97,182,159,142,138,130,227,41,5,205,184,117,78,107,97,253,25,60,246,95,128,79,55,235,16,126,116,245,194,90,47,157,74,57,245,86,113,42,36,56,106,48,79,169,242,220,112,163,21,100,194,47,4,227,82,10,107,104,6,152,83,231,211,148,106,153,26,154,36,169,203,19,212,92,217,252,230,249,60,200,21,177,46,225,240,248,225,188,47,117,29,154,182,171,138,246,48,139,45,124,31,2,169,67,132,114,22,59,179,47,98,44,66,245,202,85,95,197,242,150,237,184,123,77,119,71,150,187,143,242,29,223,219,193,182,235,132,223,135,187,35,243,29,217,134,174,177,103,70,222,111,238,222,252,198,48,100,104,121,183,157,210,236,43,85,87,150,99,229,14,90,152,26,167,114,112,133,47,208,173,170,237,20,226,192,146,140,139,254,229,49,173,87,109,255,3,187,135,170,183,185,249,220,27,112,209,254,71,229,67,111,227,68,108,152,206,18,153,122,42,17,250,163,136,57,163,202,165,64,117,170,141,231,146,51,239,217,128,254,138,30,27,172,44,94,11,251,151,179,52,226,227,224,246,249,26,141,186,206,86,157,200,233,244,124,250,13,93,115,235,218,186,3,0,0 };
						string serializedData =
							Encoding.UTF8.GetString(Compressor.UnZip(zippedData));
						LocalizableParameterValuesList dataList =
							LocalizableParameterValuesList.DeserializeData(serializedData);
						dataList.InitializeLocalizableValues(Storage, "6bf791ec1818465eaa0654135080911c",
							"BaseElements.ChangeDataUserTask1.Parameters.RecordColumnValues.Value");
						dataList.LoadLocalizableValues();
						var packageUId = new Guid("75b64d44-f646-4025-b2dc-16a7526ff5fd");
						Func<string, object> getColumnValue = delegate(string memberName) {
							Func<object> getValueFunc = GetColumnValueFunctions[memberName];
							getValueFunc.CheckArgumentNull(memberName);
							return getValueFunc.Invoke();
						};
						_recordColumnValues = new EntityColumnMappingValues(UserConnection, packageUId,
							(EntityColumnMappingCollection)dataList, "RecordColumnValues", getColumnValue);
					}
					return _recordColumnValues;
				}
				set {
					_recordColumnValues = value;
				}
			}

			#endregion

		}

		#endregion

		#region Class: UserTask1FlowElement

		/// <exclude/>
		public class UserTask1FlowElement : GetIsProcessLinkedToEntityUserTask
		{

			#region Constructors: Public

			public UserTask1FlowElement(UserConnection userConnection, Presentation780 process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "UserTask1";
				IsLogging = true;
				SchemaElementUId = new Guid("d93177b9-4a71-48fa-b40b-c45ffc964876");
				CreatedInSchemaUId = process.InternalSchemaUId;
				_entitySchemaId = () => (Guid)(new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"));
				_recordId = () => (Guid)((process.OpportunityId));
				_processStatusId = () => (Guid)(new Guid("ed2ae277-b6e2-df11-971b-001d60e938c6"));
			}

			#endregion

			#region Properties: Public

			internal Func<Guid> _entitySchemaId;
			public override Guid EntitySchemaId {
				get {
					return (_entitySchemaId ?? (_entitySchemaId = () => Guid.Empty)).Invoke();
				}
				set {
					_entitySchemaId = () => { return value; };
				}
			}

			internal Func<Guid> _recordId;
			public override Guid RecordId {
				get {
					return (_recordId ?? (_recordId = () => Guid.Empty)).Invoke();
				}
				set {
					_recordId = () => { return value; };
				}
			}

			internal Func<Guid> _processStatusId;
			public override Guid ProcessStatusId {
				get {
					return (_processStatusId ?? (_processStatusId = () => Guid.Empty)).Invoke();
				}
				set {
					_processStatusId = () => { return value; };
				}
			}

			#endregion

		}

		#endregion

		#region Class: LinkEntityToProcessUserTask1FlowElement

		/// <exclude/>
		public class LinkEntityToProcessUserTask1FlowElement : LinkEntityToProcessUserTask
		{

			#region Constructors: Public

			public LinkEntityToProcessUserTask1FlowElement(UserConnection userConnection, Presentation780 process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "LinkEntityToProcessUserTask1";
				IsLogging = true;
				SchemaElementUId = new Guid("6d8833ce-91bf-44ae-815d-7a18351a12a0");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
				_entityId = () => (Guid)((process.OpportunityId));
			}

			#endregion

			#region Properties: Public

			internal Func<Guid> _entityId;
			public override Guid EntityId {
				get {
					return (_entityId ?? (_entityId = () => Guid.Empty)).Invoke();
				}
				set {
					_entityId = () => { return value; };
				}
			}

			private Guid _entitySchemaId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf");
			public override Guid EntitySchemaId {
				get {
					return _entitySchemaId;
				}
				set {
					_entitySchemaId = value;
				}
			}

			#endregion

		}

		#endregion

		#region Class: ReadDataUserTask2FlowElement

		/// <exclude/>
		public class ReadDataUserTask2FlowElement : ReadDataUserTask
		{

			#region Constructors: Public

			public ReadDataUserTask2FlowElement(UserConnection userConnection, Presentation780 process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ReadDataUserTask2";
				IsLogging = true;
				SchemaElementUId = new Guid("7d815e76-606e-4683-b397-8cc2c5366a79");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
			}

			#endregion

			#region Properties: Public

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,205,83,193,106,219,64,16,253,151,61,91,65,182,100,203,242,173,164,110,8,148,38,16,147,75,149,195,72,26,201,75,86,90,177,187,74,235,26,67,63,33,31,211,67,233,177,249,147,126,73,103,181,182,234,20,151,184,133,146,8,4,218,199,211,155,55,111,103,214,44,19,160,245,59,168,144,205,216,2,149,2,45,11,115,242,134,11,131,234,76,201,182,97,3,166,81,113,16,252,19,230,14,159,231,220,188,6,3,244,203,58,249,165,144,176,89,114,88,35,97,131,132,113,131,149,38,14,253,146,67,158,197,48,44,60,136,67,223,11,131,105,228,165,69,144,123,89,17,71,97,26,15,135,65,28,56,230,159,196,79,101,213,128,66,87,163,147,47,186,207,197,170,177,212,33,1,89,71,225,90,214,91,48,176,38,244,188,134,84,96,78,103,163,90,36,200,40,94,81,55,184,224,21,94,130,162,90,86,71,90,136,72,5,8,109,89,2,11,51,255,216,40,212,154,203,250,41,115,162,173,234,125,54,9,96,127,220,218,241,59,143,150,121,9,102,217,73,156,147,173,77,231,242,85,89,42,44,193,240,187,125,19,183,184,234,120,199,229,55,176,68,3,215,32,90,220,171,249,184,147,83,104,140,107,200,149,39,130,226,229,242,232,94,251,196,158,106,119,68,96,179,35,31,169,121,176,135,209,132,192,59,11,56,149,221,103,194,222,159,235,139,15,53,170,171,108,137,21,184,212,110,78,8,253,13,232,245,103,235,108,92,68,152,67,232,69,97,152,218,36,125,111,58,29,79,60,72,253,16,40,205,241,40,154,108,110,156,15,174,27,1,171,235,190,220,195,253,143,207,223,30,238,191,127,165,247,11,93,156,125,108,190,178,228,25,136,139,6,21,108,163,245,15,79,222,163,145,181,93,41,41,141,243,218,167,242,22,193,221,202,238,238,169,16,173,164,13,229,74,182,42,219,174,128,118,187,248,79,59,246,12,155,243,55,203,112,112,28,143,25,175,23,49,56,255,115,42,54,108,243,19,112,39,77,159,193,5,0,0 })));
				}
				set {
					_dataSourceFilters = value;
				}
			}

			private int _resultType = 0;
			public override int ResultType {
				get {
					return _resultType;
				}
				set {
					_resultType = value;
				}
			}

			private int _functionType = 0;
			public override int FunctionType {
				get {
					return _functionType;
				}
				set {
					_functionType = value;
				}
			}

			private string _orderInfo;
			public override string OrderInfo {
				get {
					return _orderInfo ?? (_orderInfo = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,243,73,77,76,241,75,204,77,181,50,180,50,4,0,148,131,179,106,12,0,0,0 })));
				}
				set {
					_orderInfo = value;
				}
			}

			private Entity _resultEntity;
			public override Entity ResultEntity {
				get {
					return _resultEntity ?? (_resultEntity =
						new Entity(UserConnection) {
							Schema = UserConnection.EntitySchemaManager.GetInstanceByUId(
								new Guid("41af89e9-750b-4ebb-8cac-ff39b64841ec")),
							UseAdminRights = false
						});
				}
				set {
					_resultEntity = value;
				}
			}

			private string _entityColumnMetaPathes;
			public override string EntityColumnMetaPathes {
				get {
					return _entityColumnMetaPathes ?? (_entityColumnMetaPathes = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,5,193,137,13,0,33,8,4,192,138,54,1,249,52,87,13,34,244,95,194,205,100,83,171,85,162,244,24,116,58,144,114,30,36,111,172,216,205,206,241,245,148,44,35,134,150,36,212,136,176,39,21,252,130,202,239,44,159,243,3,143,24,84,120,73,0,0,0 })));
				}
				set {
					_entityColumnMetaPathes = value;
				}
			}

			#endregion

		}

		#endregion

		#region Class: ReadDataUserTask3FlowElement

		/// <exclude/>
		public class ReadDataUserTask3FlowElement : ReadDataUserTask
		{

			#region Constructors: Public

			public ReadDataUserTask3FlowElement(UserConnection userConnection, Presentation780 process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ReadDataUserTask3";
				IsLogging = true;
				SchemaElementUId = new Guid("80cdca17-d9be-4a25-b531-ed4490bd630c");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
			}

			#endregion

			#region Properties: Public

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,205,83,205,110,211,64,16,126,21,228,115,93,217,177,155,196,185,161,18,80,47,164,82,162,94,112,15,99,123,236,172,176,189,214,238,186,16,162,72,136,23,128,94,57,193,157,3,7,16,92,184,52,226,69,250,36,204,122,29,55,69,65,13,28,128,72,171,204,126,254,230,155,159,157,89,90,113,14,82,62,134,2,173,145,53,67,33,64,242,84,29,62,100,185,66,241,72,240,186,178,14,44,137,130,65,206,94,96,98,240,113,194,212,3,80,64,46,203,240,70,33,180,70,225,110,141,208,58,8,45,166,176,144,196,33,151,8,142,60,39,232,247,109,72,130,161,237,247,189,35,59,240,134,190,237,4,241,112,224,186,232,249,126,100,152,191,18,63,230,69,5,2,77,140,70,62,109,204,217,162,210,84,151,128,184,161,48,201,203,22,244,116,18,114,92,66,148,99,66,119,37,106,36,72,9,86,80,53,56,99,5,158,130,160,88,90,135,107,136,72,41,228,82,179,114,76,213,248,121,37,80,74,198,203,187,146,203,235,162,220,102,147,0,118,215,54,29,167,201,81,51,79,65,205,27,137,19,74,107,213,100,121,63,203,4,102,160,216,197,118,18,79,113,209,240,246,235,31,57,36,244,74,103,144,215,184,21,243,118,37,199,80,41,83,144,9,79,4,193,178,249,222,181,118,29,187,171,220,30,129,213,134,188,167,230,206,26,122,125,2,47,52,96,84,54,102,104,61,57,145,147,103,37,138,105,60,199,2,76,215,206,15,9,253,9,232,244,71,203,40,112,156,120,224,58,118,207,113,2,219,31,244,92,27,226,97,106,187,67,23,49,136,28,24,196,233,234,220,228,193,100,149,195,226,172,11,183,126,115,245,126,125,121,253,242,45,25,31,233,124,162,243,117,125,121,245,250,94,24,234,175,223,233,114,253,234,3,161,159,233,124,105,255,191,221,184,144,241,110,227,163,93,232,241,245,79,191,17,207,88,12,249,164,66,1,237,243,56,187,167,247,214,216,235,206,8,206,149,169,183,235,236,164,170,184,80,117,201,212,98,170,32,195,166,156,205,44,81,80,90,113,221,228,41,175,69,220,174,148,52,187,253,71,59,251,15,54,241,119,150,107,231,120,239,51,174,255,197,32,254,173,9,89,89,171,31,120,185,102,91,29,6,0,0 })));
				}
				set {
					_dataSourceFilters = value;
				}
			}

			private int _functionType = 0;
			public override int FunctionType {
				get {
					return _functionType;
				}
				set {
					_functionType = value;
				}
			}

			private string _orderInfo;
			public override string OrderInfo {
				get {
					return _orderInfo ?? (_orderInfo = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,243,75,204,77,181,50,180,50,4,0,127,229,4,95,8,0,0,0 })));
				}
				set {
					_orderInfo = value;
				}
			}

			private Entity _resultEntity;
			public override Entity ResultEntity {
				get {
					return _resultEntity ?? (_resultEntity =
						new Entity(UserConnection) {
							Schema = UserConnection.EntitySchemaManager.GetInstanceByUId(
								new Guid("ccf7d813-fc83-47ad-be61-8f3b3b98a54f")),
							UseAdminRights = false
						});
				}
				set {
					_resultEntity = value;
				}
			}

			private string _entityColumnMetaPathes;
			public override string EntityColumnMetaPathes {
				get {
					return _entityColumnMetaPathes ?? (_entityColumnMetaPathes = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,51,77,78,75,51,76,49,54,215,77,54,48,182,212,53,49,75,78,213,77,76,54,6,18,38,41,230,137,73,169,38,150,201,166,105,0,224,247,196,235,36,0,0,0 })));
				}
				set {
					_entityColumnMetaPathes = value;
				}
			}

			#endregion

		}

		#endregion

		public Presentation780(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Presentation780";
			SchemaUId = new Guid("6bf791ec-1818-465e-aa06-54135080911c");
			Caption = Schema.Caption;
			SchemaManagerName = "ProcessSchemaManager";
			SerializeToDB = true;
			SerializeToMemory = true;
			IsLogging = true;
			_openConductPresentationCard = () => { return (bool)(false); };
			_startedManual = () => { return (bool)(false); };
			_presentationStageId = () => { return (Guid)(new Guid("325f0619-0ee0-df11-971b-001d60e938c6")); };
			InitializeFlowElements();
		}

		#region Properties: Private

		private  Guid InternalSchemaUId {
			get {
				return new Guid("6bf791ec-1818-465e-aa06-54135080911c");
			}
		}

		#endregion

		#region Properties: Public

		public  virtual Guid OpportunityId {
			get;
			set;
		}

		private Func<bool> _openConductPresentationCard;
		public  virtual bool OpenConductPresentationCard {
			get {
				return (_openConductPresentationCard ?? (_openConductPresentationCard = () => false)).Invoke();
			}
			set {
				_openConductPresentationCard = () => { return value; };
			}
		}

		private Func<bool> _startedManual;
		public  virtual bool StartedManual {
			get {
				return (_startedManual ?? (_startedManual = () => false)).Invoke();
			}
			set {
				_startedManual = () => { return value; };
			}
		}

		public  virtual Guid LeadId {
			get;
			set;
		}

		private Func<Guid> _presentationStageId;
		public  virtual Guid PresentationStageId {
			get {
				return (_presentationStageId ?? (_presentationStageId = () => Guid.Empty)).Invoke();
			}
			set {
				_presentationStageId = () => { return value; };
			}
		}

		private ProcessLane1 _lane1;
		public  ProcessLane1 Lane1 {
			get {
				return _lane1 ?? ((_lane1) = new ProcessLane1(UserConnection, this));
			}
		}

		private ProcessTerminateEvent _terminate1;
		public  ProcessTerminateEvent Terminate1 {
			get {
				return _terminate1 ?? (_terminate1 = new ProcessTerminateEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaTerminateEvent",
					Name = "Terminate1",
					SchemaElementUId = new Guid("adf0661a-bcec-43f2-b6d2-fa6de7d4b637"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
				});
			}
		}

		private ProcessStartSignalEvent _startSignal1;
		public  ProcessStartSignalEvent StartSignal1 {
			get {
				return _startSignal1 ?? (_startSignal1 = new ProcessStartSignalEvent(UserConnection) {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartSignalEvent",
					Name = "StartSignal1",
					SerializeToDB = false,
					IsLogging = true,
					SchemaElementUId = new Guid("c3900be2-f0ca-4a57-b036-4471b828d067"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ReadDataUserTask1FlowElement _readDataUserTask1;
		public  ReadDataUserTask1FlowElement ReadDataUserTask1 {
			get {
				return _readDataUserTask1 ?? (_readDataUserTask1 = new ReadDataUserTask1FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ActivityUserTask1FlowElement _activityUserTask1;
		public  ActivityUserTask1FlowElement ActivityUserTask1 {
			get {
				return _activityUserTask1 ?? (_activityUserTask1 = new ActivityUserTask1FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ActivityUserTask2FlowElement _activityUserTask2;
		public  ActivityUserTask2FlowElement ActivityUserTask2 {
			get {
				return _activityUserTask2 ?? (_activityUserTask2 = new ActivityUserTask2FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private CallUserTask1FlowElement _callUserTask1;
		public  CallUserTask1FlowElement CallUserTask1 {
			get {
				return _callUserTask1 ?? (_callUserTask1 = new CallUserTask1FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessExclusiveGateway _exclusiveGateway1;
		public  ProcessExclusiveGateway ExclusiveGateway1 {
			get {
				return _exclusiveGateway1 ?? (_exclusiveGateway1 = new ProcessExclusiveGateway() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaExclusiveGateway",
					Name = "ExclusiveGateway1",
					SchemaElementUId = new Guid("f760f191-07f1-4b82-8af0-f87fcba7fc5e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
						Question = GetLocalizableString(Schema.GetResourceManagerName(),
					"BaseElements.ExclusiveGateway1.Question"),
						IsDecisionRequired = false,
						BranchingMode = GatewayBranchingMode.Auto,
						DecisionMode = GetewayDecisionSelectionMode.Single,
						ShowUserDecisionDialog = (processId, gatewayName) => {},
				});
			}
		}

		private ProcessThrowMessageEvent _intermediateThrowMessage1;
		public  ProcessThrowMessageEvent IntermediateThrowMessage1 {
			get {
				return _intermediateThrowMessage1 ?? (_intermediateThrowMessage1 = new ProcessThrowMessageEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaIntermediateThrowMessageEvent",
					Name = "IntermediateThrowMessage1",
					SchemaElementUId = new Guid("b5f839ee-dda6-4552-93f7-fbaf0b0f5a69"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
						Message = "CallToCustomerCompleted",
				});
			}
		}

		private IntermediateCatchSignal1FlowElement _intermediateCatchSignal1;
		public  IntermediateCatchSignal1FlowElement IntermediateCatchSignal1 {
			get {
				return _intermediateCatchSignal1 ?? ((_intermediateCatchSignal1) = new IntermediateCatchSignal1FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ChangeDataUserTask1FlowElement _changeDataUserTask1;
		public  ChangeDataUserTask1FlowElement ChangeDataUserTask1 {
			get {
				return _changeDataUserTask1 ?? (_changeDataUserTask1 = new ChangeDataUserTask1FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessFlowElement _startEvent1;
		public  ProcessFlowElement StartEvent1 {
			get {
				return _startEvent1 ?? (_startEvent1 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartEvent",
					Name = "StartEvent1",
					SchemaElementUId = new Guid("5961ccfa-4fd2-4d36-86b0-1507776d52b0"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
				});
			}
		}

		private UserTask1FlowElement _userTask1;
		public  UserTask1FlowElement UserTask1 {
			get {
				return _userTask1 ?? (_userTask1 = new UserTask1FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessTerminateEvent _terminateEvent1;
		public  ProcessTerminateEvent TerminateEvent1 {
			get {
				return _terminateEvent1 ?? (_terminateEvent1 = new ProcessTerminateEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaTerminateEvent",
					Name = "TerminateEvent1",
					SchemaElementUId = new Guid("3e7a518a-a3c4-49c3-a510-0dce1af4673b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
				});
			}
		}

		private ProcessExclusiveGateway _exclusiveGateway2;
		public  ProcessExclusiveGateway ExclusiveGateway2 {
			get {
				return _exclusiveGateway2 ?? (_exclusiveGateway2 = new ProcessExclusiveGateway() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaExclusiveGateway",
					Name = "ExclusiveGateway2",
					SchemaElementUId = new Guid("6d2520dc-4a23-46a2-9c8e-9c87c53d7122"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
						Question = GetLocalizableString(Schema.GetResourceManagerName(),
					"BaseElements.ExclusiveGateway2.Question"),
						IsDecisionRequired = false,
						BranchingMode = GatewayBranchingMode.Auto,
						DecisionMode = GetewayDecisionSelectionMode.Single,
						ShowUserDecisionDialog = (processId, gatewayName) => {},
				});
			}
		}

		private LinkEntityToProcessUserTask1FlowElement _linkEntityToProcessUserTask1;
		public  LinkEntityToProcessUserTask1FlowElement LinkEntityToProcessUserTask1 {
			get {
				return _linkEntityToProcessUserTask1 ?? (_linkEntityToProcessUserTask1 = new LinkEntityToProcessUserTask1FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessScriptTask _formulaTask1;
		public  ProcessScriptTask FormulaTask1 {
			get {
				return _formulaTask1 ?? (_formulaTask1 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaFormulaTask",
					Name = "FormulaTask1",
					SchemaElementUId = new Guid("7d457367-cc40-4f57-aa8b-7c1445b59eaa"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
					Script = FormulaTask1Execute,
				});
			}
		}

		private ProcessInclusiveGateway _inclusiveGateway1;
		public  ProcessInclusiveGateway InclusiveGateway1 {
			get {
				return _inclusiveGateway1 ?? (_inclusiveGateway1 = new ProcessInclusiveGateway() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaInclusiveGateway",
					Name = "InclusiveGateway1",
					SchemaElementUId = new Guid("217a0c27-a555-476d-8c80-56a04be51471"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
						Question = GetLocalizableString(Schema.GetResourceManagerName(),
					"BaseElements.InclusiveGateway1.Question"),
						IsDecisionRequired = false,
						BranchingMode = GatewayBranchingMode.Auto,
						DecisionMode = GetewayDecisionSelectionMode.Single,
						ShowUserDecisionDialog = (processId, gatewayName) => {},
				});
			}
		}

		private ProcessScriptTask _formulaTask2;
		public  ProcessScriptTask FormulaTask2 {
			get {
				return _formulaTask2 ?? (_formulaTask2 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaFormulaTask",
					Name = "FormulaTask2",
					SchemaElementUId = new Guid("43cc328f-9956-44b2-a43a-2aa01ee60e2c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
					Script = FormulaTask2Execute,
				});
			}
		}

		private ReadDataUserTask2FlowElement _readDataUserTask2;
		public  ReadDataUserTask2FlowElement ReadDataUserTask2 {
			get {
				return _readDataUserTask2 ?? (_readDataUserTask2 = new ReadDataUserTask2FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessScriptTask _formulaTask3;
		public  ProcessScriptTask FormulaTask3 {
			get {
				return _formulaTask3 ?? (_formulaTask3 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaFormulaTask",
					Name = "FormulaTask3",
					SchemaElementUId = new Guid("543dccdd-4190-49e0-84c9-42de7b72ebfb"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
					Script = FormulaTask3Execute,
				});
			}
		}

		private ReadDataUserTask3FlowElement _readDataUserTask3;
		public  ReadDataUserTask3FlowElement ReadDataUserTask3 {
			get {
				return _readDataUserTask3 ?? (_readDataUserTask3 = new ReadDataUserTask3FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ProcessConditionalFlow _conditionalSequenceFlow2;
		public  ProcessConditionalFlow ConditionalSequenceFlow2 {
			get {
				return _conditionalSequenceFlow2 ?? (_conditionalSequenceFlow2 = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ConditionalSequenceFlow2",
					SchemaElementUId = new Guid("82eeeea3-4d91-49d1-bcbe-e62c6072a403"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
						ProcessActivitiesSelectedResults = new Dictionary<Guid, Collection<Guid>>() {
						{new Guid("7759b439-c26f-4535-b56f-174ac5737d38"), new Collection<Guid>() {
							new Guid("5fbd327e-f36b-1410-6598-00155d043204"),
							new Guid("5f0704a8-1749-4f65-98d8-458e7563a23c"),
						}},
					},
				});
			}
		}

		private ProcessConditionalFlow _conditionalSequenceFlow3;
		public  ProcessConditionalFlow ConditionalSequenceFlow3 {
			get {
				return _conditionalSequenceFlow3 ?? (_conditionalSequenceFlow3 = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ConditionalSequenceFlow3",
					SchemaElementUId = new Guid("d1db7147-09f9-4a12-ba37-8cdd11762d38"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
						ProcessActivitiesSelectedResults = new Dictionary<Guid, Collection<Guid>>() {
						{new Guid("7759b439-c26f-4535-b56f-174ac5737d38"), new Collection<Guid>() {
							new Guid("fc7d2e5e-f36b-1410-6698-00155d043204"),
							new Guid("ee2c489d-a4c0-470d-a188-bd76490f0957"),
						}},
					},
				});
			}
		}

		private ProcessConditionalFlow _conditionalSequenceFlow1;
		public  ProcessConditionalFlow ConditionalSequenceFlow1 {
			get {
				return _conditionalSequenceFlow1 ?? (_conditionalSequenceFlow1 = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ConditionalSequenceFlow1",
					SchemaElementUId = new Guid("71bb25a7-f391-44cb-b4f1-d29ff72d691f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
						ProcessActivitiesSelectedResults = new Dictionary<Guid, Collection<Guid>>() {
						{new Guid("de1cbaa9-ae2f-4b76-8aeb-8885bcd9ebdc"), new Collection<Guid>() {
							new Guid("632afdd2-f616-4ea6-87d2-8ed38eed8aff"),
						}},
					},
				});
			}
		}

		private ProcessConditionalFlow _conditionalSequenceFlow6;
		public  ProcessConditionalFlow ConditionalSequenceFlow6 {
			get {
				return _conditionalSequenceFlow6 ?? (_conditionalSequenceFlow6 = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ConditionalSequenceFlow6",
					SchemaElementUId = new Guid("0fb6a681-c7d1-4b81-88f7-cca180b05f9d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private ProcessConditionalFlow _conditionalSequenceFlow5;
		public  ProcessConditionalFlow ConditionalSequenceFlow5 {
			get {
				return _conditionalSequenceFlow5 ?? (_conditionalSequenceFlow5 = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ConditionalSequenceFlow5",
					SchemaElementUId = new Guid("78352338-9dff-4676-85ab-10cdfa4c20f8"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
						ProcessActivitiesSelectedResults = new Dictionary<Guid, Collection<Guid>>() {
						{new Guid("e2ba9f8a-3b63-436d-930b-3720e5d305da"), new Collection<Guid>() {
							new Guid("dbbf0e10-f46b-1410-6598-00155d043204"),
							new Guid("632afdd2-f616-4ea6-87d2-8ed38eed8aff"),
						}},
					},
				});
			}
		}

		private ProcessConditionalFlow _conditionalSequenceFlow4;
		public  ProcessConditionalFlow ConditionalSequenceFlow4 {
			get {
				return _conditionalSequenceFlow4 ?? (_conditionalSequenceFlow4 = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ConditionalSequenceFlow4",
					SchemaElementUId = new Guid("2baada81-5504-4eb4-b870-67c57c941b9d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		private ProcessConditionalFlow _conditionalSequenceFlow8;
		public  ProcessConditionalFlow ConditionalSequenceFlow8 {
			get {
				return _conditionalSequenceFlow8 ?? (_conditionalSequenceFlow8 = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ConditionalSequenceFlow8",
					SchemaElementUId = new Guid("bc08de7e-937e-41e0-a4ab-b0b9b1e58de6"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[Terminate1.SchemaElementUId] = new Collection<ProcessFlowElement> { Terminate1 };
			FlowElements[StartSignal1.SchemaElementUId] = new Collection<ProcessFlowElement> { StartSignal1 };
			FlowElements[ReadDataUserTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { ReadDataUserTask1 };
			FlowElements[ActivityUserTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { ActivityUserTask1 };
			FlowElements[ActivityUserTask2.SchemaElementUId] = new Collection<ProcessFlowElement> { ActivityUserTask2 };
			FlowElements[CallUserTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { CallUserTask1 };
			FlowElements[ExclusiveGateway1.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway1 };
			FlowElements[IntermediateThrowMessage1.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowMessage1 };
			FlowElements[IntermediateCatchSignal1.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateCatchSignal1 };
			FlowElements[ChangeDataUserTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { ChangeDataUserTask1 };
			FlowElements[StartEvent1.SchemaElementUId] = new Collection<ProcessFlowElement> { StartEvent1 };
			FlowElements[UserTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { UserTask1 };
			FlowElements[TerminateEvent1.SchemaElementUId] = new Collection<ProcessFlowElement> { TerminateEvent1 };
			FlowElements[ExclusiveGateway2.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway2 };
			FlowElements[LinkEntityToProcessUserTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { LinkEntityToProcessUserTask1 };
			FlowElements[FormulaTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { FormulaTask1 };
			FlowElements[InclusiveGateway1.SchemaElementUId] = new Collection<ProcessFlowElement> { InclusiveGateway1 };
			FlowElements[FormulaTask2.SchemaElementUId] = new Collection<ProcessFlowElement> { FormulaTask2 };
			FlowElements[ReadDataUserTask2.SchemaElementUId] = new Collection<ProcessFlowElement> { ReadDataUserTask2 };
			FlowElements[FormulaTask3.SchemaElementUId] = new Collection<ProcessFlowElement> { FormulaTask3 };
			FlowElements[ReadDataUserTask3.SchemaElementUId] = new Collection<ProcessFlowElement> { ReadDataUserTask3 };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "Terminate1":
						CompleteProcess();
						break;
					case "StartSignal1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("FormulaTask1", e.Context.SenderName));
						break;
					case "ReadDataUserTask1":
						if (ConditionalSequenceFlow8ExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ReadDataUserTask2", e.Context.SenderName));
							break;
						}
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ActivityUserTask1", e.Context.SenderName));
						break;
					case "ActivityUserTask1":
						if (ActivityUserTask1.ActivityResult == new Guid("dbbf0e10-f46b-1410-6598-00155d043204") || ActivityUserTask1.ActivityResult == new Guid("632afdd2-f616-4ea6-87d2-8ed38eed8aff")) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("InclusiveGateway1", e.Context.SenderName));
							break;
						}
						break;
					case "ActivityUserTask2":
						if (ActivityUserTask2.ActivityResult == new Guid("632afdd2-f616-4ea6-87d2-8ed38eed8aff")) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ChangeDataUserTask1", e.Context.SenderName));
							break;
						}
						break;
					case "CallUserTask1":
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ExclusiveGateway1", e.Context.SenderName));
						break;
					case "ExclusiveGateway1":
						if (CallUserTask1.ActivityResult == new Guid("5fbd327e-f36b-1410-6598-00155d043204") || CallUserTask1.ActivityResult == new Guid("5f0704a8-1749-4f65-98d8-458e7563a23c")) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("CallUserTask1", e.Context.SenderName));
							break;
						}
						if (CallUserTask1.ActivityResult == new Guid("fc7d2e5e-f36b-1410-6698-00155d043204") || CallUserTask1.ActivityResult == new Guid("ee2c489d-a4c0-470d-a188-bd76490f0957")) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("IntermediateThrowMessage1", e.Context.SenderName));
							break;
						}
						break;
					case "IntermediateThrowMessage1":
						break;
					case "IntermediateCatchSignal1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("Terminate1", e.Context.SenderName));
						break;
					case "ChangeDataUserTask1":
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("Terminate1", e.Context.SenderName));
						break;
					case "StartEvent1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("FormulaTask2", e.Context.SenderName));
						break;
					case "UserTask1":
						if (ConditionalSequenceFlow4ExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("TerminateEvent1", e.Context.SenderName));
							break;
						}
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("LinkEntityToProcessUserTask1", e.Context.SenderName));
						break;
					case "TerminateEvent1":
						CompleteProcess();
						break;
					case "ExclusiveGateway2":
						if (ConditionalSequenceFlow6ExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("UserTask1", e.Context.SenderName));
							break;
						}
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("TerminateEvent1", e.Context.SenderName));
						break;
					case "LinkEntityToProcessUserTask1":
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ReadDataUserTask1", e.Context.SenderName));
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ReadDataUserTask3", e.Context.SenderName));
						break;
					case "FormulaTask1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("UserTask1", e.Context.SenderName));
						break;
					case "InclusiveGateway1":
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ActivityUserTask2", e.Context.SenderName));
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("CallUserTask1", e.Context.SenderName));
						break;
					case "FormulaTask2":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ExclusiveGateway2", e.Context.SenderName));
						break;
					case "ReadDataUserTask2":
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("FormulaTask3", e.Context.SenderName));
						break;
					case "FormulaTask3":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ActivityUserTask1", e.Context.SenderName));
						break;
					case "ReadDataUserTask3":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("IntermediateCatchSignal1", e.Context.SenderName));
						break;
			}
		}

		private bool ConditionalSequenceFlow6ExpressionExecute() {
			return Convert.ToBoolean(Guid.Empty != (OpportunityId));
		}

		private bool ConditionalSequenceFlow4ExpressionExecute() {
			return Convert.ToBoolean((UserTask1.Result) == true);
		}

		private bool ConditionalSequenceFlow8ExpressionExecute() {
			return Convert.ToBoolean((LeadId)!= Guid.Empty);
		}

		private void WritePropertyValues(DataWriter writer, bool useAllValueSources) {
			if (!HasMapping("OpportunityId")) {
				writer.WriteValue("OpportunityId", OpportunityId, Guid.Empty);
			}
			if (!HasMapping("LeadId")) {
				writer.WriteValue("LeadId", LeadId, Guid.Empty);
			}
			if (!HasMapping("OpenConductPresentationCard")) {
				writer.WriteValue("OpenConductPresentationCard", OpenConductPresentationCard, false);
			}
			if (!HasMapping("StartedManual")) {
				writer.WriteValue("StartedManual", StartedManual, false);
			}
			if (!HasMapping("PresentationStageId")) {
				writer.WriteValue("PresentationStageId", PresentationStageId, Guid.Empty);
			}
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			if (IsProcessExecutedBySignal) {
				return;
			}
			context.QueueTasksV2.Enqueue(new ProcessQueueElement("StartEvent1", string.Empty));
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

		protected override void InitializeMetaPathParameterValues() {
			base.InitializeMetaPathParameterValues();
			MetaPathParameterValues.Add("54f358a6-d908-4521-bfdd-39a220e37a43", () => OpportunityId);
			MetaPathParameterValues.Add("674a8c2f-6066-425d-85da-4084bfbcc48b", () => OpenConductPresentationCard);
			MetaPathParameterValues.Add("f294f501-f808-49b5-884e-efdd695c82c8", () => StartedManual);
			MetaPathParameterValues.Add("c5f7eda4-744b-4380-8856-ab04af975276", () => LeadId);
			MetaPathParameterValues.Add("b900c710-2009-4721-ac8f-181ee9b0a7cf", () => PresentationStageId);
			MetaPathParameterValues.Add("2f6bb10d-22e8-4a68-bbec-7b5ab33f2398", () => StartSignal1.RecordId);
			MetaPathParameterValues.Add("2ebefc60-654c-418c-a9fd-809ddf2c820d", () => StartSignal1.EntitySchemaUId);
			MetaPathParameterValues.Add("cf36b3ed-ca42-4b3e-915b-1d7729c48fcb", () => ReadDataUserTask1.DataSourceFilters);
			MetaPathParameterValues.Add("0561607a-fe31-485c-bb28-7710b09b8d86", () => ReadDataUserTask1.ResultType);
			MetaPathParameterValues.Add("37e58031-5407-4518-82db-7650337e2fe7", () => ReadDataUserTask1.ReadSomeTopRecords);
			MetaPathParameterValues.Add("9067f099-405e-4975-8a97-61cd9dbf80a8", () => ReadDataUserTask1.NumberOfRecords);
			MetaPathParameterValues.Add("72a8ef56-315b-4bdb-970c-760efab949f2", () => ReadDataUserTask1.FunctionType);
			MetaPathParameterValues.Add("4ff0c814-077c-4816-bad1-34ddf8af5b97", () => ReadDataUserTask1.AggregationColumnName);
			MetaPathParameterValues.Add("268e41fb-13f7-41f9-8a1c-77845e3303dd", () => ReadDataUserTask1.OrderInfo);
			MetaPathParameterValues.Add("7aaf017b-9075-40ce-b3ec-a5810e428e0a", () => ReadDataUserTask1.ResultEntity);
			MetaPathParameterValues.Add("9ac99bf1-ed42-439b-a54e-3d8c73e1235f", () => ReadDataUserTask1.ResultCount);
			MetaPathParameterValues.Add("b62cd742-3ee6-4a65-9a8a-683ce7fb3a24", () => ReadDataUserTask1.ResultIntegerFunction);
			MetaPathParameterValues.Add("ca2b9a7a-a463-41c2-8d15-84e31bb02ab4", () => ReadDataUserTask1.ResultFloatFunction);
			MetaPathParameterValues.Add("dfd16f50-c4b7-4d1b-9171-32f4c7555ae8", () => ReadDataUserTask1.ResultDateTimeFunction);
			MetaPathParameterValues.Add("688f8e9b-8c7b-40f0-9fde-ce0b46a03e4a", () => ReadDataUserTask1.ResultRowsCount);
			MetaPathParameterValues.Add("0eab6e12-6a4b-4597-95cd-36f94b3dcab3", () => ReadDataUserTask1.CanReadUncommitedData);
			MetaPathParameterValues.Add("76f64d03-0a19-4d73-8b1a-060ef08db939", () => ReadDataUserTask1.ResultEntityCollection);
			MetaPathParameterValues.Add("1335481c-bebe-467e-98df-3baf057e3539", () => ReadDataUserTask1.EntityColumnMetaPathes);
			MetaPathParameterValues.Add("098a8d13-0e7d-4052-9501-d10b4fd8612e", () => ReadDataUserTask1.IgnoreDisplayValues);
			MetaPathParameterValues.Add("0bb121af-795b-4762-bc20-710653ad1054", () => ActivityUserTask1.Recommendation);
			MetaPathParameterValues.Add("d862b140-b851-42af-b35f-579425158140", () => ActivityUserTask1.ActivityCategory);
			MetaPathParameterValues.Add("c8616f19-e921-4612-a102-a62863f15885", () => ActivityUserTask1.OwnerId);
			MetaPathParameterValues.Add("4fbdbd24-3cb7-407f-9305-8414c6e21ac7", () => ActivityUserTask1.Duration);
			MetaPathParameterValues.Add("b4217293-d9e7-4ac2-9a17-4e91924c640d", () => ActivityUserTask1.DurationPeriod);
			MetaPathParameterValues.Add("dbdb457d-fadf-46ae-8e93-857088c827b2", () => ActivityUserTask1.StartIn);
			MetaPathParameterValues.Add("f57e4629-2c52-4088-8a7b-1e13f23acb96", () => ActivityUserTask1.StartInPeriod);
			MetaPathParameterValues.Add("b32cee1d-3d14-48b7-ab44-7b85228c874a", () => ActivityUserTask1.RemindBefore);
			MetaPathParameterValues.Add("9527f46d-258d-4d9e-be83-32c2882bb5b0", () => ActivityUserTask1.RemindBeforePeriod);
			MetaPathParameterValues.Add("7d7c12ac-f9b6-4201-9148-f42a96b635bc", () => ActivityUserTask1.ShowInScheduler);
			MetaPathParameterValues.Add("84bb24a4-25d4-4996-bd2f-5225f49503b1", () => ActivityUserTask1.ShowExecutionPage);
			MetaPathParameterValues.Add("037926e6-0267-4ac3-9980-12d372eceb3b", () => ActivityUserTask1.Lead);
			MetaPathParameterValues.Add("b8270135-7f35-4c83-937a-86d19d8fda59", () => ActivityUserTask1.Account);
			MetaPathParameterValues.Add("277ceee0-3113-46cd-ad53-b87fac0701c1", () => ActivityUserTask1.Contact);
			MetaPathParameterValues.Add("0263b88a-0913-4e1c-804a-d67cb04762ba", () => ActivityUserTask1.Opportunity);
			MetaPathParameterValues.Add("93445d87-fb7f-4199-82c6-ebd5c4310ee6", () => ActivityUserTask1.Invoice);
			MetaPathParameterValues.Add("71b1bb9d-8b74-45cc-a2d3-247b41cb0b15", () => ActivityUserTask1.Document);
			MetaPathParameterValues.Add("bdea626a-f73e-4410-9a8f-8a583f8b30e3", () => ActivityUserTask1.Incident);
			MetaPathParameterValues.Add("d5decb2c-95e6-4824-ad89-8b6518efc139", () => ActivityUserTask1.Case);
			MetaPathParameterValues.Add("6ad1a495-43ad-4234-bd57-59862625d894", () => ActivityUserTask1.ActivityResult);
			MetaPathParameterValues.Add("1f7ca167-5c23-43f6-bedc-9216dd4b6edb", () => ActivityUserTask1.CurrentActivityId);
			MetaPathParameterValues.Add("fc5ba1bd-e977-4c38-a328-48db35933c18", () => ActivityUserTask1.IsActivityCompleted);
			MetaPathParameterValues.Add("0d1a5f3e-ed0a-4b13-a164-303bdd42fb8f", () => ActivityUserTask1.ExecutionContext);
			MetaPathParameterValues.Add("c62771d1-6d27-4561-8715-a344336848a5", () => ActivityUserTask1.InformationOnStep);
			MetaPathParameterValues.Add("a7a43aca-5bec-43d7-9ced-4b7a661d5b7f", () => ActivityUserTask1.Order);
			MetaPathParameterValues.Add("f2bf80e4-2f71-48a0-be85-0b5aa4cfbad5", () => ActivityUserTask1.Requests);
			MetaPathParameterValues.Add("6611513d-8e32-4185-95cd-836270e4354b", () => ActivityUserTask1.Listing);
			MetaPathParameterValues.Add("ea5cec32-f8c3-44b9-9c21-6b5190acc022", () => ActivityUserTask1.Property);
			MetaPathParameterValues.Add("794ee685-48fe-4ae4-b049-9448793b3ec7", () => ActivityUserTask1.Contract);
			MetaPathParameterValues.Add("0775ccd2-1257-46b3-a513-3c5544df9cec", () => ActivityUserTask1.Project);
			MetaPathParameterValues.Add("d18ad733-a25d-4a4e-b7a3-213b662aec4e", () => ActivityUserTask1.Problem);
			MetaPathParameterValues.Add("23506c5d-f95c-4330-b9f7-b32c783e2df4", () => ActivityUserTask1.Change);
			MetaPathParameterValues.Add("ebd1f788-c35b-486d-a41e-d72667871102", () => ActivityUserTask1.Release);
			MetaPathParameterValues.Add("a65eae28-45bf-41a0-8e16-cdb5ee8e05b4", () => ActivityUserTask1.QueueItem);
			MetaPathParameterValues.Add("e99f54cf-1f2a-4173-8278-7dfdf25e7e9a", () => ActivityUserTask1.Application);
			MetaPathParameterValues.Add("0bde0ebd-bf3e-49fa-b5d8-5908ef67624b", () => ActivityUserTask1.FinApplication);
			MetaPathParameterValues.Add("4ed89671-4741-4e17-b233-2316404a449f", () => ActivityUserTask2.Recommendation);
			MetaPathParameterValues.Add("ff755c80-857d-415b-9e18-87c8bbd4bf95", () => ActivityUserTask2.ActivityCategory);
			MetaPathParameterValues.Add("35bec071-2378-4c91-aa02-cfd040d097bc", () => ActivityUserTask2.OwnerId);
			MetaPathParameterValues.Add("b9f7d3e5-c3f5-448b-a71c-e263441b0c3e", () => ActivityUserTask2.Duration);
			MetaPathParameterValues.Add("1534dcc6-455a-4ac4-a10e-8fd26fde91ca", () => ActivityUserTask2.DurationPeriod);
			MetaPathParameterValues.Add("44545ce9-c447-4145-ad2e-99b9af33acee", () => ActivityUserTask2.StartIn);
			MetaPathParameterValues.Add("5017db6c-cc7d-4f6c-9109-1f433fd5a32c", () => ActivityUserTask2.StartInPeriod);
			MetaPathParameterValues.Add("a82d4b4c-5f28-4a77-b08f-4e480fa600f1", () => ActivityUserTask2.RemindBefore);
			MetaPathParameterValues.Add("2fb6001d-e6a8-4000-8c38-7cc592914588", () => ActivityUserTask2.RemindBeforePeriod);
			MetaPathParameterValues.Add("2795ac5e-2392-4eb6-88c9-4b3ec9c62fcf", () => ActivityUserTask2.ShowInScheduler);
			MetaPathParameterValues.Add("db98afd9-e6f8-4006-860a-a79ded37e03f", () => ActivityUserTask2.ShowExecutionPage);
			MetaPathParameterValues.Add("4dbf1164-fa63-4412-b9aa-b7cf3a3b2b5f", () => ActivityUserTask2.Lead);
			MetaPathParameterValues.Add("dec7a72b-c61f-45f0-969c-c5c8a194678e", () => ActivityUserTask2.Account);
			MetaPathParameterValues.Add("c2af18f2-8891-40d6-811e-8731d6d14de2", () => ActivityUserTask2.Contact);
			MetaPathParameterValues.Add("e0c28006-67ce-420a-a796-915b074164c6", () => ActivityUserTask2.Opportunity);
			MetaPathParameterValues.Add("99d6c7de-97ed-4bf1-9098-87dab5bf3598", () => ActivityUserTask2.Invoice);
			MetaPathParameterValues.Add("f89b82b3-9efb-4c3e-bfd4-2ba2b23bd6fe", () => ActivityUserTask2.Document);
			MetaPathParameterValues.Add("aac71976-0f49-4fbb-90bb-f53927a2e845", () => ActivityUserTask2.Incident);
			MetaPathParameterValues.Add("bc6c1ec2-bd7d-478c-b96e-44dd3619216d", () => ActivityUserTask2.Case);
			MetaPathParameterValues.Add("7beae63e-d770-4a92-8623-f71c920a25ef", () => ActivityUserTask2.ActivityResult);
			MetaPathParameterValues.Add("8ef7ec46-e951-4056-a006-0c397f19edfc", () => ActivityUserTask2.CurrentActivityId);
			MetaPathParameterValues.Add("20ecdb23-3b68-4f8d-b02c-64391f5247bc", () => ActivityUserTask2.IsActivityCompleted);
			MetaPathParameterValues.Add("3bafe375-93f1-48e3-92e0-d8190451d0ce", () => ActivityUserTask2.ExecutionContext);
			MetaPathParameterValues.Add("82f1097b-1105-400c-aa5b-62a20a21c422", () => ActivityUserTask2.InformationOnStep);
			MetaPathParameterValues.Add("bdee0010-af22-492f-9cad-dc16ac80b166", () => ActivityUserTask2.Order);
			MetaPathParameterValues.Add("2097b936-82a8-4bf1-9dcc-d54654912ac3", () => ActivityUserTask2.Requests);
			MetaPathParameterValues.Add("01a3b2af-2015-4c60-bc7e-0dfb87f74902", () => ActivityUserTask2.Listing);
			MetaPathParameterValues.Add("eacc2b4d-3053-4117-a9eb-b1e699772758", () => ActivityUserTask2.Property);
			MetaPathParameterValues.Add("bbc8ca0e-0c70-407f-9a47-e91a077e1cbf", () => ActivityUserTask2.Contract);
			MetaPathParameterValues.Add("65d1c15d-6d2e-4503-9096-c033835cf6b2", () => ActivityUserTask2.Project);
			MetaPathParameterValues.Add("0239c10e-a776-4342-8e57-4279a51476bb", () => ActivityUserTask2.Problem);
			MetaPathParameterValues.Add("81a7713c-c63f-430d-8a95-79d96386874d", () => ActivityUserTask2.Change);
			MetaPathParameterValues.Add("8b1ca1b8-652c-4d7e-b13f-740138868999", () => ActivityUserTask2.Release);
			MetaPathParameterValues.Add("27dc575e-d2bc-459b-b017-b4b5d4491d6e", () => ActivityUserTask2.QueueItem);
			MetaPathParameterValues.Add("e4151c41-7177-4a41-a2ff-1c89af5b80fb", () => ActivityUserTask2.Application);
			MetaPathParameterValues.Add("a24ef5ec-31a4-407f-870f-674342f91359", () => ActivityUserTask2.FinApplication);
			MetaPathParameterValues.Add("8d6db4db-2d0d-4a3b-8eb0-bfa28f1238cb", () => CallUserTask1.Recommendation);
			MetaPathParameterValues.Add("525de2e9-3fac-4b47-a23b-a900100d07e6", () => CallUserTask1.ActivityCategory);
			MetaPathParameterValues.Add("7996acaa-8939-4ca6-b2c4-242e94121752", () => CallUserTask1.OwnerId);
			MetaPathParameterValues.Add("c3834030-02af-4acc-ab5c-92f3f7948ecc", () => CallUserTask1.Duration);
			MetaPathParameterValues.Add("9fbf6e60-dcda-4e45-8cd7-a2b71ad09376", () => CallUserTask1.DurationPeriod);
			MetaPathParameterValues.Add("1fcbbe7f-e376-4242-86a0-90fc7f234d6e", () => CallUserTask1.StartIn);
			MetaPathParameterValues.Add("65ff76c0-1d93-4a5e-816b-0795b0fd3597", () => CallUserTask1.StartInPeriod);
			MetaPathParameterValues.Add("9664f63a-1a72-4e0a-900b-9c9b8cae0b37", () => CallUserTask1.RemindBefore);
			MetaPathParameterValues.Add("19cb44f8-46f7-4f24-a7d7-cb1ed3f6f897", () => CallUserTask1.RemindBeforePeriod);
			MetaPathParameterValues.Add("44b454aa-8b64-4f69-a3b9-d9de5334625b", () => CallUserTask1.ShowInScheduler);
			MetaPathParameterValues.Add("7a674820-9ae9-43a8-8ce0-7ff0cbfd3206", () => CallUserTask1.ShowExecutionPage);
			MetaPathParameterValues.Add("366aff98-662c-4664-b3bd-90ade510df99", () => CallUserTask1.Lead);
			MetaPathParameterValues.Add("14022ba0-fb0b-4388-8036-21733e9d5e43", () => CallUserTask1.Account);
			MetaPathParameterValues.Add("454e49bf-5c3d-4f06-80d4-aca1b9c8ef2d", () => CallUserTask1.Contact);
			MetaPathParameterValues.Add("2b4a544c-6d59-44e8-8ffd-72e09b0366c4", () => CallUserTask1.Opportunity);
			MetaPathParameterValues.Add("5915743b-8147-48e9-9909-c059ee10c4b4", () => CallUserTask1.Invoice);
			MetaPathParameterValues.Add("c059f59e-468e-41a5-bec0-9595afd591e2", () => CallUserTask1.Document);
			MetaPathParameterValues.Add("01ae529a-3ef7-473f-86e6-df2fcd61c9ae", () => CallUserTask1.Incident);
			MetaPathParameterValues.Add("9eb70282-f3b4-4e05-bd0d-01c05f3385d1", () => CallUserTask1.Case);
			MetaPathParameterValues.Add("7f2adbee-5315-41c9-b5b9-fcc0cb9047f3", () => CallUserTask1.ActivityResult);
			MetaPathParameterValues.Add("a6a80d8a-23d1-41b6-a3c0-b9717718c832", () => CallUserTask1.CurrentActivityId);
			MetaPathParameterValues.Add("f8394ac3-012d-4741-815c-64a7cddaae80", () => CallUserTask1.IsActivityCompleted);
			MetaPathParameterValues.Add("1d14642d-fbd9-4823-8bfa-64634f780807", () => CallUserTask1.ExecutionContext);
			MetaPathParameterValues.Add("f4d83ca6-8b98-4197-b659-e175aea65f3a", () => CallUserTask1.InformationOnStep);
			MetaPathParameterValues.Add("65386f1f-0ccd-4984-b635-db7949eb51a7", () => CallUserTask1.Order);
			MetaPathParameterValues.Add("0b915432-5e4e-4276-b3a8-ea3184792519", () => CallUserTask1.Contract);
			MetaPathParameterValues.Add("a81a98ed-cb69-4aec-b364-5715572da655", () => CallUserTask1.Requests);
			MetaPathParameterValues.Add("088635a6-fba2-47b4-ad71-2908f5a3e257", () => CallUserTask1.Listing);
			MetaPathParameterValues.Add("787b474c-4e55-4966-b777-b91910a5730f", () => CallUserTask1.Property);
			MetaPathParameterValues.Add("3f34ed1c-d273-41a7-8d40-08206077100b", () => CallUserTask1.Project);
			MetaPathParameterValues.Add("64966fbb-41dd-42d0-9e17-06468502aaa3", () => CallUserTask1.Problem);
			MetaPathParameterValues.Add("6a451801-6fcf-4519-9fdf-0028b1771889", () => CallUserTask1.Release);
			MetaPathParameterValues.Add("d22b2bb7-8e73-4287-8728-2e67370fa2af", () => CallUserTask1.Change);
			MetaPathParameterValues.Add("f5540acb-9d9f-4e2a-a3d0-e4864f234fb7", () => CallUserTask1.QueueItem);
			MetaPathParameterValues.Add("e5fffd57-3c9f-4ccb-8e38-94adf736e8fd", () => IntermediateCatchSignal1.RecordId);
			MetaPathParameterValues.Add("fe4ad51f-1587-4182-b59e-ad9a16e51a34", () => ChangeDataUserTask1.EntitySchemaUId);
			MetaPathParameterValues.Add("bd61759e-d187-4d46-9666-f6e9a766f565", () => ChangeDataUserTask1.IsMatchConditions);
			MetaPathParameterValues.Add("228ff31b-2138-4d3b-a324-d365c47a8f3a", () => ChangeDataUserTask1.DataSourceFilters);
			MetaPathParameterValues.Add("6da7d8dd-943c-4c4b-9a7a-96dfd561ed8c", () => ChangeDataUserTask1.RecordColumnValues);
			MetaPathParameterValues.Add("02187313-3b57-48e9-a7ed-b15b4b5ac0a4", () => UserTask1.EntitySchemaId);
			MetaPathParameterValues.Add("89d03e2e-6bbb-4c7b-a8c5-df8881a810ff", () => UserTask1.RecordId);
			MetaPathParameterValues.Add("d1b83d84-f946-49f6-a0f0-598d4e0f4a17", () => UserTask1.Result);
			MetaPathParameterValues.Add("f9749434-ac3c-4091-ba21-f48b6621f1a6", () => UserTask1.ProcessStatusId);
			MetaPathParameterValues.Add("a1271d06-3f37-49f2-9369-3f00179cd090", () => LinkEntityToProcessUserTask1.EntityId);
			MetaPathParameterValues.Add("affcd197-29fd-48e4-ad21-12a29d3c7fdd", () => LinkEntityToProcessUserTask1.EntitySchemaId);
			MetaPathParameterValues.Add("7d2bb010-03f6-43ac-bb3c-94500e1e8657", () => ReadDataUserTask2.DataSourceFilters);
			MetaPathParameterValues.Add("43096b21-1f3d-4d09-b8d1-04bd2b273a2c", () => ReadDataUserTask2.ResultType);
			MetaPathParameterValues.Add("e23c91a4-c202-41af-93ff-759f65540e0b", () => ReadDataUserTask2.ReadSomeTopRecords);
			MetaPathParameterValues.Add("42a732ed-af4a-4a4d-97a0-d9140ac127db", () => ReadDataUserTask2.NumberOfRecords);
			MetaPathParameterValues.Add("a601a6fc-c49a-4317-8da8-ca8d9f34ab7a", () => ReadDataUserTask2.FunctionType);
			MetaPathParameterValues.Add("c7c68110-b7ab-4d9c-8ba7-81642b2f27ad", () => ReadDataUserTask2.AggregationColumnName);
			MetaPathParameterValues.Add("57ffc4c1-5b7c-419b-a8e3-d9359c2f36b7", () => ReadDataUserTask2.OrderInfo);
			MetaPathParameterValues.Add("d0f7a489-5d77-48eb-868d-1ad0fa5f95bd", () => ReadDataUserTask2.ResultEntity);
			MetaPathParameterValues.Add("84014da3-9f86-45f4-9c2a-f64ac009d34b", () => ReadDataUserTask2.ResultCount);
			MetaPathParameterValues.Add("9f0a3b38-457f-48a3-a81e-12771a09a9ca", () => ReadDataUserTask2.ResultIntegerFunction);
			MetaPathParameterValues.Add("c61bfb76-9ba5-4c33-a7bd-50e74b580370", () => ReadDataUserTask2.ResultFloatFunction);
			MetaPathParameterValues.Add("8ca06b05-cb16-4088-bc0c-bafc971d5097", () => ReadDataUserTask2.ResultDateTimeFunction);
			MetaPathParameterValues.Add("d845ad55-c878-409f-a330-9354717085a7", () => ReadDataUserTask2.ResultRowsCount);
			MetaPathParameterValues.Add("97e234ee-8976-47d7-89fa-51474032763e", () => ReadDataUserTask2.CanReadUncommitedData);
			MetaPathParameterValues.Add("7cd92ef6-9699-44f3-bd90-61c065f8e2eb", () => ReadDataUserTask2.ResultEntityCollection);
			MetaPathParameterValues.Add("408a91e4-af2b-4d34-9651-99df284b23b2", () => ReadDataUserTask2.EntityColumnMetaPathes);
			MetaPathParameterValues.Add("f59431ca-b459-4f6f-b620-d237fd62cb14", () => ReadDataUserTask2.IgnoreDisplayValues);
			MetaPathParameterValues.Add("28182a61-1f71-43b7-8092-7bdf1cf4f66c", () => ReadDataUserTask3.DataSourceFilters);
			MetaPathParameterValues.Add("102221d6-ae5c-44cf-82d6-b75493fa22d6", () => ReadDataUserTask3.ResultType);
			MetaPathParameterValues.Add("72ecf01b-4c3a-4012-b287-c6f142a8621a", () => ReadDataUserTask3.ReadSomeTopRecords);
			MetaPathParameterValues.Add("d8d82be0-7f27-47e2-9f01-1153288516f6", () => ReadDataUserTask3.NumberOfRecords);
			MetaPathParameterValues.Add("6389a854-001c-4cd4-8ace-76c6fb3fb1b5", () => ReadDataUserTask3.FunctionType);
			MetaPathParameterValues.Add("8fb2b5f4-a9ef-4872-9e10-129f885b7ba0", () => ReadDataUserTask3.AggregationColumnName);
			MetaPathParameterValues.Add("8a12209b-2f43-4d13-8fd4-d761f985e646", () => ReadDataUserTask3.OrderInfo);
			MetaPathParameterValues.Add("d1d0dafb-cdff-4c89-99f2-0973b6c94658", () => ReadDataUserTask3.ResultEntity);
			MetaPathParameterValues.Add("72a94f03-a43a-48a1-aff5-f56901615999", () => ReadDataUserTask3.ResultCount);
			MetaPathParameterValues.Add("6138af84-13c2-40f6-8b7c-740b5716978d", () => ReadDataUserTask3.ResultIntegerFunction);
			MetaPathParameterValues.Add("7102b005-369a-4e11-8157-e2d771254035", () => ReadDataUserTask3.ResultFloatFunction);
			MetaPathParameterValues.Add("0e1a74df-4f3b-44a5-9f8c-9feadbc11cca", () => ReadDataUserTask3.ResultDateTimeFunction);
			MetaPathParameterValues.Add("9ea51bc5-beb4-42f6-a28f-1328d35a2ad8", () => ReadDataUserTask3.ResultRowsCount);
			MetaPathParameterValues.Add("b790f1bd-6e5e-4c09-8bee-ef325c01a9af", () => ReadDataUserTask3.CanReadUncommitedData);
			MetaPathParameterValues.Add("06e15642-681a-4fc7-b047-253abbda7d49", () => ReadDataUserTask3.ResultEntityCollection);
			MetaPathParameterValues.Add("c5e605e2-8c49-40a5-a604-0b7d309b96c5", () => ReadDataUserTask3.EntityColumnMetaPathes);
			MetaPathParameterValues.Add("060dce7c-0481-4619-8195-9c2a50ee385b", () => ReadDataUserTask3.IgnoreDisplayValues);
		}

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			bool hasValueToRead = reader.HasValue();
			switch (reader.CurrentName) {
				case "OpportunityId":
					if (!hasValueToRead) break;
					OpportunityId = reader.GetValue<System.Guid>();
				break;
				case "LeadId":
					if (!hasValueToRead) break;
					LeadId = reader.GetValue<System.Guid>();
				break;
				case "OpenConductPresentationCard":
					if (!hasValueToRead) break;
					OpenConductPresentationCard = reader.GetValue<System.Boolean>();
				break;
				case "StartedManual":
					if (!hasValueToRead) break;
					StartedManual = reader.GetValue<System.Boolean>();
				break;
				case "PresentationStageId":
					if (!hasValueToRead) break;
					PresentationStageId = reader.GetValue<System.Guid>();
				break;
			}
		}

		protected override void WritePropertyValues(DataWriter writer) {
			base.WritePropertyValues(writer);
			WritePropertyValues(writer, true);
		}

		#endregion

		#region Methods: Public

		public virtual bool FormulaTask1Execute(ProcessExecutingContext context) {
			var localOpportunityId = (StartSignal1.RecordId);
			OpportunityId = (System.Guid)localOpportunityId;
			return true;
		}

		public virtual bool FormulaTask2Execute(ProcessExecutingContext context) {
			var localStartedManual = true;
			StartedManual = (System.Boolean)localStartedManual;
			return true;
		}

		public virtual bool FormulaTask3Execute(ProcessExecutingContext context) {
			var localActivityUserTask1_StartIn = (((ReadDataUserTask2.ResultEntity.IsColumnValueLoaded(ReadDataUserTask2.ResultEntity.Schema.Columns.GetByName("MeetingDate").ColumnValueName) ? ReadDataUserTask2.ResultEntity.GetTypedColumnValue<DateTime>("MeetingDate") : DateTime.ParseExact("01.01.0001 0:00", "dd.MM.yyyy H:mm", CultureInfo.InvariantCulture))) > DateTime.MinValue) ? Convert.ToInt32((((ReadDataUserTask2.ResultEntity.IsColumnValueLoaded(ReadDataUserTask2.ResultEntity.Schema.Columns.GetByName("MeetingDate").ColumnValueName) ? ReadDataUserTask2.ResultEntity.GetTypedColumnValue<DateTime>("MeetingDate") : DateTime.ParseExact("01.01.0001 0:00", "dd.MM.yyyy H:mm", CultureInfo.InvariantCulture))) - ((DateTime)UserConnection.SystemValueManager.GetValue(UserConnection, "CurrentDateTime"))).TotalMinutes) : (ActivityUserTask1.StartIn);
			ActivityUserTask1.StartIn = (System.Int32)localActivityUserTask1_StartIn;
			return true;
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			base.ThrowEvent(context, message);
		}

		public override void WritePropertiesData(DataWriter writer, bool writeFlowElements = true) {
			if (Status == Core.Process.ProcessStatus.Inactive) {
				return;
			}
			writer.WriteStartObject(Name);
			base.WritePropertiesData(writer, writeFlowElements);
			WritePropertyValues(writer, false);
			writer.WriteFinishObject();
		}

		public override object CloneShallow() {
			var cloneItem = (Presentation780)base.CloneShallow();
			cloneItem.ExecutedEventHandler = ExecutedEventHandler;
			return cloneItem;
		}

		#endregion

	}

	#endregion

}

