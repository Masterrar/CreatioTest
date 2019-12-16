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

	#region Class: OppManagementNeedAnalysis

	/// <exclude/>
	public class OppManagementNeedAnalysis : Terrasoft.Core.Process.Process
	{

		#region Class: ProcessSalesManager

		/// <exclude/>
		public class ProcessSalesManager : ProcessLane
		{

			public ProcessSalesManager(UserConnection userConnection, OppManagementNeedAnalysis process)
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

			public ReadDataUserTask1FlowElement(UserConnection userConnection, OppManagementNeedAnalysis process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ReadDataUserTask1";
				IsLogging = true;
				SchemaElementUId = new Guid("3198802b-8dbb-49c7-8a19-34b517dcd9c0");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
			}

			#endregion

			#region Properties: Public

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,213,83,77,107,220,48,20,252,43,69,135,158,172,98,75,178,44,57,199,101,91,246,146,6,154,150,66,178,4,89,122,202,10,252,21,89,162,89,204,254,247,202,235,108,10,57,148,66,79,1,29,164,39,205,188,153,225,105,126,112,211,103,215,6,240,181,85,237,4,89,220,153,26,73,16,212,216,82,96,155,115,134,89,165,10,44,120,14,56,39,92,128,100,74,114,46,80,214,171,14,106,180,162,183,198,5,148,185,0,221,84,223,205,127,72,131,143,144,61,216,243,225,155,62,64,167,190,47,13,20,48,110,27,81,97,157,19,141,153,2,129,149,161,5,86,146,80,109,140,148,76,91,180,106,161,141,36,74,148,22,231,37,77,79,133,110,176,208,208,224,82,74,10,50,55,4,180,65,89,11,54,108,159,71,15,211,228,134,190,158,225,117,127,123,28,147,202,181,247,102,104,99,215,163,172,131,160,110,84,56,44,66,114,96,165,86,88,51,89,98,102,161,194,138,74,131,169,106,42,82,9,40,120,81,161,76,171,49,44,180,104,151,90,25,21,212,15,213,70,56,51,207,46,105,36,52,47,68,201,19,182,88,52,82,146,167,188,146,59,107,184,149,64,185,148,141,185,228,245,37,186,180,119,211,117,236,192,59,253,18,59,164,252,6,95,207,122,232,131,31,218,133,250,250,252,252,22,158,195,26,238,203,213,207,213,80,72,245,5,132,78,89,156,96,211,58,232,195,182,215,131,113,253,227,202,121,58,37,72,55,42,239,166,75,10,219,167,168,90,148,121,247,120,248,107,90,155,56,133,161,123,71,86,179,100,51,113,164,33,59,203,93,102,208,184,105,108,213,241,124,174,209,199,167,56,132,171,77,244,62,129,63,12,227,56,248,16,123,23,142,235,5,122,67,80,163,123,100,36,16,11,90,98,222,72,153,102,212,18,44,203,130,224,130,51,176,60,183,156,209,242,30,37,81,255,223,234,110,55,125,253,213,95,126,200,234,105,255,41,85,223,20,110,46,200,122,254,23,117,167,253,162,111,127,74,235,55,86,173,119,102,232,3,0,0 })));
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

			private bool _readSomeTopRecords = true;
			public override bool ReadSomeTopRecords {
				get {
					return _readSomeTopRecords;
				}
				set {
					_readSomeTopRecords = value;
				}
			}

			private int _numberOfRecords = 1;
			public override int NumberOfRecords {
				get {
					return _numberOfRecords;
				}
				set {
					_numberOfRecords = value;
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
					return _orderInfo ?? (_orderInfo = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,243,76,177,50,176,50,208,9,201,44,201,73,181,50,180,50,4,0,57,183,224,50,16,0,0,0 })));
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

			private EntityCollection _resultEntityCollection;
			public override EntityCollection ResultEntityCollection {
				get {
					if (_resultEntityCollection == null) {
						_resultEntityCollection = new EntityCollection(UserConnection, new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf"));
					}
					return _resultEntityCollection;
				}
				set {
					_resultEntityCollection = value;
				}
			}

			#endregion

		}

		#endregion

		#region Class: OpenEditPageUserTask1FlowElement

		/// <exclude/>
		public class OpenEditPageUserTask1FlowElement : OpenEditPageUserTask
		{

			#region Constructors: Public

			public OpenEditPageUserTask1FlowElement(UserConnection userConnection, OppManagementNeedAnalysis process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "OpenEditPageUserTask1";
				IsLogging = true;
				SchemaElementUId = new Guid("ed605ac0-a8f8-4aab-a3eb-00eef52791e3");
				CreatedInSchemaUId = process.InternalSchemaUId;
				ProcessLane = process.SalesManager;
				SerializeToDB = true;
				_recordId = () => (Guid)(((process.ReadDataUserTask1.ResultEntity.IsColumnValueLoaded(process.ReadDataUserTask1.ResultEntity.Schema.Columns.GetByName("Account").ColumnValueName) ? process.ReadDataUserTask1.ResultEntity.GetTypedColumnValue<Guid>("AccountId") : Guid.Empty)));
				_ownerId = () => (Guid)(((process.ReadDataUserTask1.ResultEntity.IsColumnValueLoaded(process.ReadDataUserTask1.ResultEntity.Schema.Columns.GetByName("Owner").ColumnValueName) ? process.ReadDataUserTask1.ResultEntity.GetTypedColumnValue<Guid>("OwnerId") : Guid.Empty)));
				_account = () => (Guid)(((process.ReadDataUserTask1.ResultEntity.IsColumnValueLoaded(process.ReadDataUserTask1.ResultEntity.Schema.Columns.GetByName("Account").ColumnValueName) ? process.ReadDataUserTask1.ResultEntity.GetTypedColumnValue<Guid>("AccountId") : Guid.Empty)));
				_contact = () => (Guid)((process.MainContact));
				_opportunity = () => (Guid)((process.CurrentOpportunity));
			}

			#endregion

			#region Properties: Public

			private Guid _objectSchemaId = new Guid("25d7c1ab-1de0-4501-b402-02e0e5a72d6e");
			public override Guid ObjectSchemaId {
				get {
					return _objectSchemaId;
				}
				set {
					_objectSchemaId = value;
				}
			}

			private Guid _pageSchemaId = new Guid("f5edc79d-8d39-4e51-a255-57ccf3f1349e");
			public override Guid PageSchemaId {
				get {
					return _pageSchemaId;
				}
				set {
					_pageSchemaId = value;
				}
			}

			private int _editMode = 1;
			public override int EditMode {
				get {
					return _editMode;
				}
				set {
					_editMode = value;
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

			private bool _isMatchConditions = false;
			public override bool IsMatchConditions {
				get {
					return _isMatchConditions;
				}
				set {
					_isMatchConditions = value;
				}
			}

			private bool _generateDecisionsFromColumn = false;
			public override bool GenerateDecisionsFromColumn {
				get {
					return _generateDecisionsFromColumn;
				}
				set {
					_generateDecisionsFromColumn = value;
				}
			}

			private LocalizableString _recommendation;
			public override LocalizableString Recommendation {
				get {
					return _recommendation ?? (_recommendation = GetLocalizableString("2c360bc748e645caa60fa813cacd4299",
						 "BaseElements.OpenEditPageUserTask1.Parameters.Recommendation.Value"));
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

			private int _duration = 60;
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

			private int _startInPeriod = 0;
			public override int StartInPeriod {
				get {
					return _startInPeriod;
				}
				set {
					_startInPeriod = value;
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
					return _informationOnStep ?? (_informationOnStep = GetLocalizableString("2c360bc748e645caa60fa813cacd4299",
						 "BaseElements.OpenEditPageUserTask1.Parameters.InformationOnStep.Value"));
				}
				set {
					_informationOnStep = value;
				}
			}

			#endregion

		}

		#endregion

		#region Class: IntermediateCatchSignalEvent1FlowElement

		/// <exclude/>
		public class IntermediateCatchSignalEvent1FlowElement : ProcessIntermediateCatchSignalEvent
		{

			#region Constructors: Public

			public IntermediateCatchSignalEvent1FlowElement(UserConnection userConnection, OppManagementNeedAnalysis process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaIntermediateCatchSignalEvent";
				Name = "IntermediateCatchSignalEvent1";
				IsLogging = false;
				SchemaElementUId = new Guid("37ce0c6d-187c-4e0b-a7b4-47759dc5ea75");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
				Message = "";
				WaitingRandomSignal = false;
				WaitingEntitySignal = true;
				EntitySchemaUId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf");
				EntitySignal = EntityChangeType.Updated;
				HasEntityColumnChange = true;
				HasEntityFilters = false;
				EntityChangedColumns = @"{""$type"":""System.Collections.ObjectModel.Collection`1[[System.String, mscorlib]], mscorlib"",""$values"":[""797ac352-4979-4d28-906f-82feb6dbc9dc""]}";
				EntityFilters = @"{_isFilter:false,uId:""dfc59dd7-de9a-4f76-9060-3c41fc4607ee"",name:""FilterEdit"",items:[]}";
				_recordId = () => (Guid)((process.CurrentOpportunity));
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

		#region Class: CallUserTask2FlowElement

		/// <exclude/>
		public class CallUserTask2FlowElement : CallUserTask
		{

			#region Constructors: Public

			public CallUserTask2FlowElement(UserConnection userConnection, OppManagementNeedAnalysis process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "CallUserTask2";
				IsLogging = true;
				SchemaElementUId = new Guid("d858e27f-a3fd-4013-b016-5b5fe86b19da");
				CreatedInSchemaUId = process.InternalSchemaUId;
				ProcessLane = process.SalesManager;
				SerializeToDB = true;
				_ownerId = () => (Guid)(((process.ReadDataUserTask1.ResultEntity.IsColumnValueLoaded(process.ReadDataUserTask1.ResultEntity.Schema.Columns.GetByName("Owner").ColumnValueName) ? process.ReadDataUserTask1.ResultEntity.GetTypedColumnValue<Guid>("OwnerId") : Guid.Empty)));
				_account = () => (Guid)(((process.ReadDataUserTask1.ResultEntity.IsColumnValueLoaded(process.ReadDataUserTask1.ResultEntity.Schema.Columns.GetByName("Account").ColumnValueName) ? process.ReadDataUserTask1.ResultEntity.GetTypedColumnValue<Guid>("AccountId") : Guid.Empty)));
				_contact = () => (Guid)((process.MainContact));
				_opportunity = () => (Guid)((process.CurrentOpportunity));
			}

			#endregion

			#region Properties: Public

			private LocalizableString _recommendation;
			public override LocalizableString Recommendation {
				get {
					return _recommendation ?? (_recommendation = GetLocalizableString("2c360bc748e645caa60fa813cacd4299",
						 "BaseElements.CallUserTask2.Parameters.Recommendation.Value"));
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

			private int _duration = 60;
			public override int Duration {
				get {
					return _duration;
				}
				set {
					_duration = value;
				}
			}

			private int _remindBefore = 5;
			public override int RemindBefore {
				get {
					return _remindBefore;
				}
				set {
					_remindBefore = value;
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
					return _informationOnStep ?? (_informationOnStep = GetLocalizableString("2c360bc748e645caa60fa813cacd4299",
						 "BaseElements.CallUserTask2.Parameters.InformationOnStep.Value"));
				}
				set {
					_informationOnStep = value;
				}
			}

			#endregion

			#region Methods: Protected

			protected override void AfterActivitySaveScriptExecute(Entity activity) {
			}

			#endregion

		}

		#endregion

		#region Class: OpenEditPageUserTask2FlowElement

		/// <exclude/>
		public class OpenEditPageUserTask2FlowElement : OpenEditPageUserTask
		{

			#region Constructors: Public

			public OpenEditPageUserTask2FlowElement(UserConnection userConnection, OppManagementNeedAnalysis process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "OpenEditPageUserTask2";
				IsLogging = true;
				SchemaElementUId = new Guid("9a60fed5-178c-47ab-92b6-4862970f0ea3");
				CreatedInSchemaUId = process.InternalSchemaUId;
				ProcessLane = process.SalesManager;
				SerializeToDB = true;
				_recordId = () => (Guid)(((process.ReadDataUserTask1.ResultEntity.IsColumnValueLoaded(process.ReadDataUserTask1.ResultEntity.Schema.Columns.GetByName("Contact").ColumnValueName) ? process.ReadDataUserTask1.ResultEntity.GetTypedColumnValue<Guid>("ContactId") : Guid.Empty)));
				_ownerId = () => (Guid)(((process.ReadDataUserTask1.ResultEntity.IsColumnValueLoaded(process.ReadDataUserTask1.ResultEntity.Schema.Columns.GetByName("Owner").ColumnValueName) ? process.ReadDataUserTask1.ResultEntity.GetTypedColumnValue<Guid>("OwnerId") : Guid.Empty)));
				_account = () => (Guid)(((process.ReadDataUserTask1.ResultEntity.IsColumnValueLoaded(process.ReadDataUserTask1.ResultEntity.Schema.Columns.GetByName("Account").ColumnValueName) ? process.ReadDataUserTask1.ResultEntity.GetTypedColumnValue<Guid>("AccountId") : Guid.Empty)));
				_contact = () => (Guid)((process.MainContact));
				_opportunity = () => (Guid)((process.CurrentOpportunity));
			}

			#endregion

			#region Properties: Public

			private Guid _objectSchemaId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3");
			public override Guid ObjectSchemaId {
				get {
					return _objectSchemaId;
				}
				set {
					_objectSchemaId = value;
				}
			}

			private Guid _pageSchemaId = new Guid("8737e39c-ac08-4903-acd0-11570570691d");
			public override Guid PageSchemaId {
				get {
					return _pageSchemaId;
				}
				set {
					_pageSchemaId = value;
				}
			}

			private int _editMode = 1;
			public override int EditMode {
				get {
					return _editMode;
				}
				set {
					_editMode = value;
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

			private bool _isMatchConditions = false;
			public override bool IsMatchConditions {
				get {
					return _isMatchConditions;
				}
				set {
					_isMatchConditions = value;
				}
			}

			private bool _generateDecisionsFromColumn = false;
			public override bool GenerateDecisionsFromColumn {
				get {
					return _generateDecisionsFromColumn;
				}
				set {
					_generateDecisionsFromColumn = value;
				}
			}

			private LocalizableString _recommendation;
			public override LocalizableString Recommendation {
				get {
					return _recommendation ?? (_recommendation = GetLocalizableString("2c360bc748e645caa60fa813cacd4299",
						 "BaseElements.OpenEditPageUserTask2.Parameters.Recommendation.Value"));
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

			private int _duration = 60;
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

			private int _startInPeriod = 0;
			public override int StartInPeriod {
				get {
					return _startInPeriod;
				}
				set {
					_startInPeriod = value;
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
					return _informationOnStep ?? (_informationOnStep = GetLocalizableString("2c360bc748e645caa60fa813cacd4299",
						 "BaseElements.OpenEditPageUserTask2.Parameters.InformationOnStep.Value"));
				}
				set {
					_informationOnStep = value;
				}
			}

			#endregion

		}

		#endregion

		#region Class: CallUserTask1FlowElement

		/// <exclude/>
		public class CallUserTask1FlowElement : CallUserTask
		{

			#region Constructors: Public

			public CallUserTask1FlowElement(UserConnection userConnection, OppManagementNeedAnalysis process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "CallUserTask1";
				IsLogging = true;
				SchemaElementUId = new Guid("227fa863-0be2-40bc-b39b-fba80ec78753");
				CreatedInSchemaUId = process.InternalSchemaUId;
				ProcessLane = process.SalesManager;
				SerializeToDB = true;
				_ownerId = () => (Guid)(((process.ReadDataUserTask1.ResultEntity.IsColumnValueLoaded(process.ReadDataUserTask1.ResultEntity.Schema.Columns.GetByName("Owner").ColumnValueName) ? process.ReadDataUserTask1.ResultEntity.GetTypedColumnValue<Guid>("OwnerId") : Guid.Empty)));
				_account = () => (Guid)((process.OpenEditPageUserTask2.Account));
				_contact = () => (Guid)(((process.ReadDataUserTask1.ResultEntity.IsColumnValueLoaded(process.ReadDataUserTask1.ResultEntity.Schema.Columns.GetByName("Contact").ColumnValueName) ? process.ReadDataUserTask1.ResultEntity.GetTypedColumnValue<Guid>("ContactId") : Guid.Empty)));
				_opportunity = () => (Guid)((process.CurrentOpportunity));
			}

			#endregion

			#region Properties: Public

			private LocalizableString _recommendation;
			public override LocalizableString Recommendation {
				get {
					return _recommendation ?? (_recommendation = GetLocalizableString("2c360bc748e645caa60fa813cacd4299",
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

			private int _duration = 60;
			public override int Duration {
				get {
					return _duration;
				}
				set {
					_duration = value;
				}
			}

			private int _remindBefore = 5;
			public override int RemindBefore {
				get {
					return _remindBefore;
				}
				set {
					_remindBefore = value;
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
					return _informationOnStep ?? (_informationOnStep = GetLocalizableString("2c360bc748e645caa60fa813cacd4299",
						 "BaseElements.CallUserTask1.Parameters.InformationOnStep.Value"));
				}
				set {
					_informationOnStep = value;
				}
			}

			#endregion

			#region Methods: Protected

			protected override void AfterActivitySaveScriptExecute(Entity activity) {
			}

			#endregion

		}

		#endregion

		public OppManagementNeedAnalysis(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "OppManagementNeedAnalysis";
			SchemaUId = new Guid("2c360bc7-48e6-45ca-a60f-a813cacd4299");
			Caption = Schema.Caption;
			SchemaManagerName = "ProcessSchemaManager";
			SerializeToDB = true;
			SerializeToMemory = true;
			IsLogging = true;
			InitializeFlowElements();
		}

		#region Properties: Private

		private  Guid InternalSchemaUId {
			get {
				return new Guid("2c360bc7-48e6-45ca-a60f-a813cacd4299");
			}
		}

		#endregion

		#region Properties: Public

		public  virtual Guid CurrentOpportunity {
			get;
			set;
		}

		public  virtual bool OpportunityStageChanged {
			get;
			set;
		}

		public  virtual Guid MainContact {
			get;
			set;
		}

		private ProcessSalesManager _salesManager;
		public  ProcessSalesManager SalesManager {
			get {
				return _salesManager ?? ((_salesManager) = new ProcessSalesManager(UserConnection, this));
			}
		}

		private ProcessFlowElement _start1;
		public  ProcessFlowElement Start1 {
			get {
				return _start1 ?? (_start1 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartEvent",
					Name = "Start1",
					SchemaElementUId = new Guid("4dd51b2a-e833-44ef-a384-ac9767357180"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
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
					SchemaElementUId = new Guid("610607fd-5aa0-484a-a502-1d72a0948466"),
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

		private OpenEditPageUserTask1FlowElement _openEditPageUserTask1;
		public  OpenEditPageUserTask1FlowElement OpenEditPageUserTask1 {
			get {
				return _openEditPageUserTask1 ?? (_openEditPageUserTask1 = new OpenEditPageUserTask1FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private IntermediateCatchSignalEvent1FlowElement _intermediateCatchSignalEvent1;
		public  IntermediateCatchSignalEvent1FlowElement IntermediateCatchSignalEvent1 {
			get {
				return _intermediateCatchSignalEvent1 ?? ((_intermediateCatchSignalEvent1) = new IntermediateCatchSignalEvent1FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
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
					SchemaElementUId = new Guid("5c455098-3d0b-43a4-bf86-08a7e3717db1"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					Script = FormulaTask1Execute,
				});
			}
		}

		private CallUserTask2FlowElement _callUserTask2;
		public  CallUserTask2FlowElement CallUserTask2 {
			get {
				return _callUserTask2 ?? (_callUserTask2 = new CallUserTask2FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private OpenEditPageUserTask2FlowElement _openEditPageUserTask2;
		public  OpenEditPageUserTask2FlowElement OpenEditPageUserTask2 {
			get {
				return _openEditPageUserTask2 ?? (_openEditPageUserTask2 = new OpenEditPageUserTask2FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
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
					SchemaElementUId = new Guid("b89c3bf7-8446-47bf-909b-87177c2208bb"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Question = GetLocalizableString(Schema.GetResourceManagerName(),
					"BaseElements.ExclusiveGateway1.Question"),
						IsDecisionRequired = false,
						BranchingMode = GatewayBranchingMode.Auto,
						DecisionMode = GetewayDecisionSelectionMode.Single,
						ShowUserDecisionDialog = (processId, gatewayName) => {},
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
					SchemaElementUId = new Guid("77703124-1e43-4299-8095-c986d9973e3d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Question = GetLocalizableString(Schema.GetResourceManagerName(),
					"BaseElements.ExclusiveGateway2.Question"),
						IsDecisionRequired = false,
						BranchingMode = GatewayBranchingMode.Auto,
						DecisionMode = GetewayDecisionSelectionMode.Single,
						ShowUserDecisionDialog = (processId, gatewayName) => {},
				});
			}
		}

		private ProcessExclusiveGateway _exclusiveGateway3;
		public  ProcessExclusiveGateway ExclusiveGateway3 {
			get {
				return _exclusiveGateway3 ?? (_exclusiveGateway3 = new ProcessExclusiveGateway() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaExclusiveGateway",
					Name = "ExclusiveGateway3",
					SchemaElementUId = new Guid("f66944ab-180b-4db3-8c96-f773b21bce4b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Question = GetLocalizableString(Schema.GetResourceManagerName(),
					"BaseElements.ExclusiveGateway3.Question"),
						IsDecisionRequired = false,
						BranchingMode = GatewayBranchingMode.Auto,
						DecisionMode = GetewayDecisionSelectionMode.Single,
						ShowUserDecisionDialog = (processId, gatewayName) => {},
				});
			}
		}

		private ProcessConditionalFlow _conditionalFlow3;
		public  ProcessConditionalFlow ConditionalFlow3 {
			get {
				return _conditionalFlow3 ?? (_conditionalFlow3 = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ConditionalFlow3",
					SchemaElementUId = new Guid("2ae5160e-4b0f-4342-93a6-1840059e7042"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
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
					SchemaElementUId = new Guid("e9eb21ed-a54e-4ed2-89d0-9216760332a7"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
						ProcessActivitiesSelectedResults = new Dictionary<Guid, Collection<Guid>>() {
						{new Guid("d858e27f-a3fd-4013-b016-5b5fe86b19da"), new Collection<Guid>() {
							new Guid("5fbd327e-f36b-1410-6598-00155d043204"),
							new Guid("5f0704a8-1749-4f65-98d8-458e7563a23c"),
						}},
					},
				});
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
					SchemaElementUId = new Guid("3e35e249-ce90-47e7-b9fa-fd64130d2925"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
						ProcessActivitiesSelectedResults = new Dictionary<Guid, Collection<Guid>>() {
						{new Guid("227fa863-0be2-40bc-b39b-fba80ec78753"), new Collection<Guid>() {
							new Guid("5fbd327e-f36b-1410-6598-00155d043204"),
							new Guid("5f0704a8-1749-4f65-98d8-458e7563a23c"),
						}},
					},
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[Start1.SchemaElementUId] = new Collection<ProcessFlowElement> { Start1 };
			FlowElements[Terminate1.SchemaElementUId] = new Collection<ProcessFlowElement> { Terminate1 };
			FlowElements[ReadDataUserTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { ReadDataUserTask1 };
			FlowElements[OpenEditPageUserTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { OpenEditPageUserTask1 };
			FlowElements[IntermediateCatchSignalEvent1.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateCatchSignalEvent1 };
			FlowElements[FormulaTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { FormulaTask1 };
			FlowElements[CallUserTask2.SchemaElementUId] = new Collection<ProcessFlowElement> { CallUserTask2 };
			FlowElements[OpenEditPageUserTask2.SchemaElementUId] = new Collection<ProcessFlowElement> { OpenEditPageUserTask2 };
			FlowElements[CallUserTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { CallUserTask1 };
			FlowElements[ExclusiveGateway1.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway1 };
			FlowElements[ExclusiveGateway2.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway2 };
			FlowElements[ExclusiveGateway3.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway3 };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "Start1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ReadDataUserTask1", e.Context.SenderName));
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("IntermediateCatchSignalEvent1", e.Context.SenderName));
						break;
					case "Terminate1":
						CompleteProcess();
						break;
					case "ReadDataUserTask1":
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ExclusiveGateway1", e.Context.SenderName));
						break;
					case "OpenEditPageUserTask1":
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("CallUserTask2", e.Context.SenderName));
						break;
					case "IntermediateCatchSignalEvent1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("FormulaTask1", e.Context.SenderName));
						break;
					case "FormulaTask1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("Terminate1", e.Context.SenderName));
						break;
					case "CallUserTask2":
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ExclusiveGateway2", e.Context.SenderName));
						break;
					case "OpenEditPageUserTask2":
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("CallUserTask1", e.Context.SenderName));
						break;
					case "CallUserTask1":
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ExclusiveGateway3", e.Context.SenderName));
						break;
					case "ExclusiveGateway1":
						if (ConditionalFlow3ExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("OpenEditPageUserTask2", e.Context.SenderName));
							break;
						}
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("OpenEditPageUserTask1", e.Context.SenderName));
						break;
					case "ExclusiveGateway2":
						if (CallUserTask2.ActivityResult == new Guid("5fbd327e-f36b-1410-6598-00155d043204") || CallUserTask2.ActivityResult == new Guid("5f0704a8-1749-4f65-98d8-458e7563a23c")) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("CallUserTask2", e.Context.SenderName));
							break;
						}
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("Terminate1", e.Context.SenderName));
						break;
					case "ExclusiveGateway3":
						if (CallUserTask1.ActivityResult == new Guid("5fbd327e-f36b-1410-6598-00155d043204") || CallUserTask1.ActivityResult == new Guid("5f0704a8-1749-4f65-98d8-458e7563a23c")) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("CallUserTask1", e.Context.SenderName));
							break;
						}
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("Terminate1", e.Context.SenderName));
						break;
			}
		}

		private bool ConditionalFlow3ExpressionExecute() {
			return Convert.ToBoolean(((ReadDataUserTask1.ResultEntity.IsColumnValueLoaded(ReadDataUserTask1.ResultEntity.Schema.Columns.GetByName("Account").ColumnValueName) ? ReadDataUserTask1.ResultEntity.GetTypedColumnValue<Guid>("AccountId") : Guid.Empty)) == Guid.Empty);
		}

		private void WritePropertyValues(DataWriter writer, bool useAllValueSources) {
			if (!HasMapping("CurrentOpportunity")) {
				writer.WriteValue("CurrentOpportunity", CurrentOpportunity, Guid.Empty);
			}
			if (!HasMapping("MainContact")) {
				writer.WriteValue("MainContact", MainContact, Guid.Empty);
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
			context.QueueTasksV2.Enqueue(new ProcessQueueElement("Start1", string.Empty));
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
			MetaPathParameterValues.Add("d9e2fec9-6b99-4af2-9512-164ef60f6435", () => CurrentOpportunity);
			MetaPathParameterValues.Add("a198fd0b-123c-4a5a-86c9-a7a0560c1597", () => OpportunityStageChanged);
			MetaPathParameterValues.Add("83ed6e29-4e08-48cd-ab03-9c8fd82e3559", () => MainContact);
			MetaPathParameterValues.Add("c50a62a2-f15c-4cb1-b0b8-a928af635be4", () => ReadDataUserTask1.DataSourceFilters);
			MetaPathParameterValues.Add("098a20ba-5871-4bfa-875a-05ded028bd8f", () => ReadDataUserTask1.ResultType);
			MetaPathParameterValues.Add("1d74b1be-c1df-47df-86b1-f78e2a4371ff", () => ReadDataUserTask1.ReadSomeTopRecords);
			MetaPathParameterValues.Add("a6eec97e-68bb-4f85-8b1b-de2bb4e054b5", () => ReadDataUserTask1.NumberOfRecords);
			MetaPathParameterValues.Add("ee2838c5-6624-421f-b214-ab7a27e2bf7f", () => ReadDataUserTask1.FunctionType);
			MetaPathParameterValues.Add("120026f4-9a7c-4442-9a4a-dee943bda3e0", () => ReadDataUserTask1.AggregationColumnName);
			MetaPathParameterValues.Add("307c5efd-0916-4722-93f6-b5db421d20d2", () => ReadDataUserTask1.OrderInfo);
			MetaPathParameterValues.Add("b2896add-81b8-4978-8e68-3ed974bf978a", () => ReadDataUserTask1.ResultEntity);
			MetaPathParameterValues.Add("6ea58202-3f03-495d-9a4b-9efc4dfbb031", () => ReadDataUserTask1.ResultCount);
			MetaPathParameterValues.Add("1bcc1394-ef01-4aa7-93be-58f56d836794", () => ReadDataUserTask1.ResultIntegerFunction);
			MetaPathParameterValues.Add("2de237da-2636-4c03-af12-35fb2ab365b8", () => ReadDataUserTask1.ResultFloatFunction);
			MetaPathParameterValues.Add("3381b81c-ba19-40bc-8629-73e847705f9b", () => ReadDataUserTask1.ResultDateTimeFunction);
			MetaPathParameterValues.Add("eb51fe6c-f31e-42b3-80b3-f890e5c3f89a", () => ReadDataUserTask1.ResultRowsCount);
			MetaPathParameterValues.Add("1f6ecdec-4c10-402a-8f49-d0374082ca74", () => ReadDataUserTask1.CanReadUncommitedData);
			MetaPathParameterValues.Add("4fccfda3-d5eb-4429-b83a-e5014ef81b3a", () => ReadDataUserTask1.ResultEntityCollection);
			MetaPathParameterValues.Add("99ff6228-49ff-4ce3-ab02-a95199677a52", () => ReadDataUserTask1.EntityColumnMetaPathes);
			MetaPathParameterValues.Add("7643c3b9-36c4-4629-9086-978549bb8c0e", () => ReadDataUserTask1.IgnoreDisplayValues);
			MetaPathParameterValues.Add("c5ef368e-f29e-4609-b090-f46fed2144f9", () => OpenEditPageUserTask1.ObjectSchemaId);
			MetaPathParameterValues.Add("f3db1886-d810-4a9a-bfa1-43f9e50a36c0", () => OpenEditPageUserTask1.PageSchemaId);
			MetaPathParameterValues.Add("d5392d7e-c8de-44d9-826e-9db0008edfc8", () => OpenEditPageUserTask1.EditMode);
			MetaPathParameterValues.Add("a0ea5fdd-49e6-4642-b6c1-c71aaef26de4", () => OpenEditPageUserTask1.RecordColumnValues);
			MetaPathParameterValues.Add("b51d5944-1de0-485e-9b15-fea2eb4cdf38", () => OpenEditPageUserTask1.RecordId);
			MetaPathParameterValues.Add("b44e3b08-32cd-44f5-97df-b38b9eb34ab5", () => OpenEditPageUserTask1.ExecutedMode);
			MetaPathParameterValues.Add("1441d4a2-ec2b-4198-9902-6640a1e95f73", () => OpenEditPageUserTask1.IsMatchConditions);
			MetaPathParameterValues.Add("8d6c51fd-c701-4146-b784-7861c51e4ded", () => OpenEditPageUserTask1.DataSourceFilters);
			MetaPathParameterValues.Add("07d6177a-7a42-45f0-8878-76b0682a9ba1", () => OpenEditPageUserTask1.GenerateDecisionsFromColumn);
			MetaPathParameterValues.Add("dd2508d4-cf5e-4492-8064-99d10bd680f3", () => OpenEditPageUserTask1.DecisionalColumnMetaPath);
			MetaPathParameterValues.Add("a95cb399-f306-408f-98c4-2cd47ed83258", () => OpenEditPageUserTask1.ResultParameter);
			MetaPathParameterValues.Add("89a8defb-3692-4607-acd1-00f5a61323dd", () => OpenEditPageUserTask1.IsReexecution);
			MetaPathParameterValues.Add("1b918e24-bf38-400c-b5ce-ac4631ea9670", () => OpenEditPageUserTask1.Recommendation);
			MetaPathParameterValues.Add("3b5369d2-5add-4a23-8c03-7a96b1d3487b", () => OpenEditPageUserTask1.ActivityCategory);
			MetaPathParameterValues.Add("f9d0d6dc-07db-4858-af71-80b76e455fed", () => OpenEditPageUserTask1.OwnerId);
			MetaPathParameterValues.Add("e95942bf-4a25-49c6-87e1-65aa643005c5", () => OpenEditPageUserTask1.Duration);
			MetaPathParameterValues.Add("9d184b18-3ea1-4310-a880-bb85619ad691", () => OpenEditPageUserTask1.DurationPeriod);
			MetaPathParameterValues.Add("4734616f-7e8a-4dea-aff6-81b8cb07b4be", () => OpenEditPageUserTask1.StartIn);
			MetaPathParameterValues.Add("ff4235f2-d1d9-4592-9e85-58a838ebf289", () => OpenEditPageUserTask1.StartInPeriod);
			MetaPathParameterValues.Add("0ec2fcb1-ef1c-4d42-80c2-45d35820c49b", () => OpenEditPageUserTask1.RemindBefore);
			MetaPathParameterValues.Add("09465cc1-81ef-4a61-a7d8-aa887268c0e2", () => OpenEditPageUserTask1.RemindBeforePeriod);
			MetaPathParameterValues.Add("060a0d16-fa7e-4c3a-a0da-c4647e9682cb", () => OpenEditPageUserTask1.ShowInScheduler);
			MetaPathParameterValues.Add("b30a0a1a-497d-4003-9214-e37098817a3c", () => OpenEditPageUserTask1.ShowExecutionPage);
			MetaPathParameterValues.Add("f728edc3-8115-4874-b97b-c9f74094d768", () => OpenEditPageUserTask1.Lead);
			MetaPathParameterValues.Add("f63fbcb1-e961-4c62-bd0a-13b27c9e6c99", () => OpenEditPageUserTask1.Account);
			MetaPathParameterValues.Add("bf154839-614a-4a9e-8e27-d4821510a2aa", () => OpenEditPageUserTask1.Contact);
			MetaPathParameterValues.Add("0f9ce4b7-0e66-47b7-9e8c-d7e95f2d814a", () => OpenEditPageUserTask1.Opportunity);
			MetaPathParameterValues.Add("0fa14ade-0cda-48a9-843a-cb61192c3041", () => OpenEditPageUserTask1.Invoice);
			MetaPathParameterValues.Add("179047ac-d34c-41c9-aaf2-874e7687efe1", () => OpenEditPageUserTask1.Document);
			MetaPathParameterValues.Add("1d9a092e-3d96-40ac-a2a3-2b0c70dea6f7", () => OpenEditPageUserTask1.Incident);
			MetaPathParameterValues.Add("73a5e20b-4257-45e5-a23f-2d3a8076e295", () => OpenEditPageUserTask1.Case);
			MetaPathParameterValues.Add("772bc638-2055-488f-8eee-c3f14ca82775", () => OpenEditPageUserTask1.ActivityResult);
			MetaPathParameterValues.Add("b527efcd-7fde-49c9-b60c-df25b87f1ddd", () => OpenEditPageUserTask1.CurrentActivityId);
			MetaPathParameterValues.Add("dba1d496-993d-4f82-b459-1de10b83d56b", () => OpenEditPageUserTask1.IsActivityCompleted);
			MetaPathParameterValues.Add("92b52a25-6cf5-4c63-bb74-89ac9ed2ef37", () => OpenEditPageUserTask1.ExecutionContext);
			MetaPathParameterValues.Add("43c25fb8-5d06-4b28-bf2b-bdcc7953d564", () => OpenEditPageUserTask1.PageTypeUId);
			MetaPathParameterValues.Add("00821c85-ac51-4c12-a375-fdec8d5b68dd", () => OpenEditPageUserTask1.ActivitySchemaUId);
			MetaPathParameterValues.Add("6485c34a-361c-4a68-84be-94da0a537e96", () => OpenEditPageUserTask1.InformationOnStep);
			MetaPathParameterValues.Add("2b43f22c-dd7d-4acb-9ce8-35e6f528f4f8", () => OpenEditPageUserTask1.Order);
			MetaPathParameterValues.Add("c3572ac8-37c2-452c-8bf0-e2889b1199d2", () => OpenEditPageUserTask1.Requests);
			MetaPathParameterValues.Add("b13ad9d4-98ea-4988-ae10-a63d19241b41", () => OpenEditPageUserTask1.Listing);
			MetaPathParameterValues.Add("3fb628d0-e4df-4d32-815c-084ef121e565", () => OpenEditPageUserTask1.Property);
			MetaPathParameterValues.Add("7fb996fd-1910-4956-ad12-e3f29c3c3070", () => OpenEditPageUserTask1.Contract);
			MetaPathParameterValues.Add("c315b53a-817b-4851-91c2-e96483189f41", () => OpenEditPageUserTask1.Problem);
			MetaPathParameterValues.Add("dfae4266-5fd2-40dd-9b5e-ebf03661dda4", () => OpenEditPageUserTask1.Change);
			MetaPathParameterValues.Add("0e4f1c88-26f3-47ba-9c5d-79f8c95d12b4", () => OpenEditPageUserTask1.Release);
			MetaPathParameterValues.Add("c3a6de37-afa3-4a77-a8ea-497c153baf50", () => OpenEditPageUserTask1.Project);
			MetaPathParameterValues.Add("9717722a-d625-45a0-a235-0d379df72a5c", () => IntermediateCatchSignalEvent1.RecordId);
			MetaPathParameterValues.Add("86b9f7bb-2145-4318-a480-f18a39abed21", () => CallUserTask2.Recommendation);
			MetaPathParameterValues.Add("dbeaeba2-76bd-4c00-ab66-45feb1ccd88d", () => CallUserTask2.ActivityCategory);
			MetaPathParameterValues.Add("e51fd076-5e09-4616-858e-c4df079dc40f", () => CallUserTask2.OwnerId);
			MetaPathParameterValues.Add("9c801542-6f75-415b-ac53-e9f88b9c0738", () => CallUserTask2.Duration);
			MetaPathParameterValues.Add("b98adc90-8c91-408b-875e-84c7936f5c45", () => CallUserTask2.DurationPeriod);
			MetaPathParameterValues.Add("e4587491-2ebe-4c0c-b3a8-c706e2692c2f", () => CallUserTask2.StartIn);
			MetaPathParameterValues.Add("63f58158-62b6-443a-bc44-527d19787634", () => CallUserTask2.StartInPeriod);
			MetaPathParameterValues.Add("45189475-2656-486a-a835-2585604781d1", () => CallUserTask2.RemindBefore);
			MetaPathParameterValues.Add("319036aa-ce1d-437e-9a69-81f81e94798d", () => CallUserTask2.RemindBeforePeriod);
			MetaPathParameterValues.Add("04d06bd0-6e57-4159-9f1b-e4298bcb4685", () => CallUserTask2.ShowInScheduler);
			MetaPathParameterValues.Add("4c0d6a83-ad5d-4758-ab10-f153d68d523a", () => CallUserTask2.ShowExecutionPage);
			MetaPathParameterValues.Add("587484a9-21cf-43f6-8787-f46a317883a8", () => CallUserTask2.Lead);
			MetaPathParameterValues.Add("e48178e8-6603-475a-9f18-1a537438ac52", () => CallUserTask2.Account);
			MetaPathParameterValues.Add("3194faba-c432-475f-9b27-d47c399fb664", () => CallUserTask2.Contact);
			MetaPathParameterValues.Add("3d7b48d5-692b-4fea-8645-8acad86e4afb", () => CallUserTask2.Opportunity);
			MetaPathParameterValues.Add("3d9ad39e-b41c-4f96-a399-6112e2935f33", () => CallUserTask2.Invoice);
			MetaPathParameterValues.Add("93c86950-1fa5-4e4e-8b58-0b89c40d8978", () => CallUserTask2.Document);
			MetaPathParameterValues.Add("3924b8a9-87f4-458a-aa48-afd9f0cec095", () => CallUserTask2.Incident);
			MetaPathParameterValues.Add("4c59ba3a-b761-4bac-a71e-67b269d3284d", () => CallUserTask2.Case);
			MetaPathParameterValues.Add("b357a482-1c9c-4ca5-bdc0-92cc6eb7a7bd", () => CallUserTask2.ActivityResult);
			MetaPathParameterValues.Add("a1754d1e-52ba-463d-b0f5-c60e858a1a62", () => CallUserTask2.CurrentActivityId);
			MetaPathParameterValues.Add("0ca73211-92fd-4f1a-b3e5-a666c97ce081", () => CallUserTask2.IsActivityCompleted);
			MetaPathParameterValues.Add("01229e71-fa80-4d09-ab2e-3dee37ee897f", () => CallUserTask2.ExecutionContext);
			MetaPathParameterValues.Add("abf485f8-06c7-4327-834f-dcc28faeb08f", () => CallUserTask2.InformationOnStep);
			MetaPathParameterValues.Add("e5b94e3c-97e9-4b65-843e-b4aef90114a1", () => CallUserTask2.Order);
			MetaPathParameterValues.Add("6e7b622a-dba1-4cc6-956b-396f7b3eed01", () => CallUserTask2.Contract);
			MetaPathParameterValues.Add("f66145d8-87a9-406f-9dc7-ff9e876acec0", () => CallUserTask2.Requests);
			MetaPathParameterValues.Add("e83987a2-5ae6-4556-af2e-fbc11d532a10", () => CallUserTask2.Listing);
			MetaPathParameterValues.Add("272bd6f2-1057-4a80-880a-433148e06167", () => CallUserTask2.Property);
			MetaPathParameterValues.Add("289fc85d-a3c8-40b0-a007-c1be5102fe77", () => CallUserTask2.Project);
			MetaPathParameterValues.Add("0835d9f7-52b0-4bc2-b316-b6a691f94a93", () => CallUserTask2.Problem);
			MetaPathParameterValues.Add("4a3fa708-d92d-4d95-a3f8-7049a08105f7", () => CallUserTask2.Release);
			MetaPathParameterValues.Add("3db1e319-1d4f-40fe-a156-98992301f4a5", () => CallUserTask2.Change);
			MetaPathParameterValues.Add("87313886-0c2a-4305-a1ac-bb4b2a0c90ed", () => CallUserTask2.QueueItem);
			MetaPathParameterValues.Add("23c9077c-400a-40d3-acf5-4f08cab55d60", () => OpenEditPageUserTask2.ObjectSchemaId);
			MetaPathParameterValues.Add("f05b5fd1-68dd-48a1-ae15-d5d84055e575", () => OpenEditPageUserTask2.PageSchemaId);
			MetaPathParameterValues.Add("133a8d3a-88e5-4dc4-9ff2-3345f5de2dad", () => OpenEditPageUserTask2.EditMode);
			MetaPathParameterValues.Add("46fa724d-b214-481d-ae7c-95d13d5b1f90", () => OpenEditPageUserTask2.RecordColumnValues);
			MetaPathParameterValues.Add("af59f681-30d9-4642-9d41-d21ce527fd52", () => OpenEditPageUserTask2.RecordId);
			MetaPathParameterValues.Add("0e720c68-4d88-42f2-af51-797188504566", () => OpenEditPageUserTask2.ExecutedMode);
			MetaPathParameterValues.Add("9985e080-df74-4303-8132-c1f31dc4d2ae", () => OpenEditPageUserTask2.IsMatchConditions);
			MetaPathParameterValues.Add("51fc0574-ee26-4e8f-895b-ecf4e957b0b3", () => OpenEditPageUserTask2.DataSourceFilters);
			MetaPathParameterValues.Add("e4c17576-9aca-49dc-9404-f4bed31bd0f6", () => OpenEditPageUserTask2.GenerateDecisionsFromColumn);
			MetaPathParameterValues.Add("1f45c548-3dc4-466b-9d29-9c01c58011c5", () => OpenEditPageUserTask2.DecisionalColumnMetaPath);
			MetaPathParameterValues.Add("f3948c77-8a6f-4e62-9538-33d55dad8daa", () => OpenEditPageUserTask2.ResultParameter);
			MetaPathParameterValues.Add("220640bb-1f2b-4d4d-9248-3b874ffb6496", () => OpenEditPageUserTask2.IsReexecution);
			MetaPathParameterValues.Add("1abbdcab-e867-4d13-8f36-b11cda57819a", () => OpenEditPageUserTask2.Recommendation);
			MetaPathParameterValues.Add("6edaddce-143d-4f34-9f83-9bcc21b8ffd6", () => OpenEditPageUserTask2.ActivityCategory);
			MetaPathParameterValues.Add("2aa42839-99f6-4d0c-82e5-71ee175813d1", () => OpenEditPageUserTask2.OwnerId);
			MetaPathParameterValues.Add("fb48ec94-afae-49a4-839d-07e39e2f3ce0", () => OpenEditPageUserTask2.Duration);
			MetaPathParameterValues.Add("87b90437-f0b5-417a-a77e-e58bc1f24cff", () => OpenEditPageUserTask2.DurationPeriod);
			MetaPathParameterValues.Add("0ffc68ec-0c91-4be0-907a-9cd2f87efc7e", () => OpenEditPageUserTask2.StartIn);
			MetaPathParameterValues.Add("303a8ffc-0592-402b-91b6-04637d930309", () => OpenEditPageUserTask2.StartInPeriod);
			MetaPathParameterValues.Add("38820ec9-ac12-4dca-9ed4-27f3a6bfeb4d", () => OpenEditPageUserTask2.RemindBefore);
			MetaPathParameterValues.Add("65713008-78ee-46b6-9eea-d006a91e7aa7", () => OpenEditPageUserTask2.RemindBeforePeriod);
			MetaPathParameterValues.Add("c3a39246-ba75-4b07-8564-b3116a844e5b", () => OpenEditPageUserTask2.ShowInScheduler);
			MetaPathParameterValues.Add("918d791d-83b7-47c8-873f-3060fa5e65f6", () => OpenEditPageUserTask2.ShowExecutionPage);
			MetaPathParameterValues.Add("25f20926-48ae-493d-8990-c4f903a186cc", () => OpenEditPageUserTask2.Lead);
			MetaPathParameterValues.Add("eb708d27-8dc9-4c55-9c06-7efb7196845e", () => OpenEditPageUserTask2.Account);
			MetaPathParameterValues.Add("d6374909-7a41-456d-8469-4238460508cc", () => OpenEditPageUserTask2.Contact);
			MetaPathParameterValues.Add("cda9bb9c-e33f-42ef-a29e-64278a504a97", () => OpenEditPageUserTask2.Opportunity);
			MetaPathParameterValues.Add("28877e53-5106-405d-a170-5ecbbcf693a4", () => OpenEditPageUserTask2.Invoice);
			MetaPathParameterValues.Add("877b2e51-67de-4c60-af6a-0b19d23ad40e", () => OpenEditPageUserTask2.Document);
			MetaPathParameterValues.Add("9a8bf37c-8914-4638-b836-5ab10144690a", () => OpenEditPageUserTask2.Incident);
			MetaPathParameterValues.Add("06f2eeb7-ff87-4661-ba43-aed71553dbb1", () => OpenEditPageUserTask2.Case);
			MetaPathParameterValues.Add("21439752-42e4-449d-86ad-b6069441dfdc", () => OpenEditPageUserTask2.ActivityResult);
			MetaPathParameterValues.Add("d51bff08-a985-4395-8d6b-3fe09a475593", () => OpenEditPageUserTask2.CurrentActivityId);
			MetaPathParameterValues.Add("511fd544-af23-48b9-89dd-92dc931bc7ba", () => OpenEditPageUserTask2.IsActivityCompleted);
			MetaPathParameterValues.Add("0bc613a4-bab9-4304-8de9-b5172c7e0008", () => OpenEditPageUserTask2.ExecutionContext);
			MetaPathParameterValues.Add("4da046a7-0e00-419f-a42e-0c5cd1c990dc", () => OpenEditPageUserTask2.PageTypeUId);
			MetaPathParameterValues.Add("6f888b49-9063-4a36-909e-dec51cabdd6c", () => OpenEditPageUserTask2.ActivitySchemaUId);
			MetaPathParameterValues.Add("b140520a-19e4-4a75-b023-ae9b0ab01735", () => OpenEditPageUserTask2.InformationOnStep);
			MetaPathParameterValues.Add("68b62de9-63c5-4cd4-8cd9-610d400be854", () => OpenEditPageUserTask2.Order);
			MetaPathParameterValues.Add("dfd08bba-2bd7-4b29-9879-bc145deb523b", () => OpenEditPageUserTask2.Requests);
			MetaPathParameterValues.Add("e5707992-c741-4c5b-874d-b72606c1432b", () => OpenEditPageUserTask2.Listing);
			MetaPathParameterValues.Add("7eb1d1f1-fef9-41e4-9f1a-e237b614a179", () => OpenEditPageUserTask2.Property);
			MetaPathParameterValues.Add("ce75580f-ce51-49aa-a18b-bea0e1b47d6a", () => OpenEditPageUserTask2.Contract);
			MetaPathParameterValues.Add("d6594398-179d-4aaf-be49-1d4a0b2ed06c", () => OpenEditPageUserTask2.Problem);
			MetaPathParameterValues.Add("6a9c96b5-8428-4b45-9ad1-188a856c9cfa", () => OpenEditPageUserTask2.Change);
			MetaPathParameterValues.Add("d04ccbf7-971d-479a-b227-57c9a551491a", () => OpenEditPageUserTask2.Release);
			MetaPathParameterValues.Add("dd29f49d-f5d9-4c0f-9356-944e02107758", () => OpenEditPageUserTask2.Project);
			MetaPathParameterValues.Add("583d1b9d-8c1c-4dd6-9981-c09ae23e3549", () => CallUserTask1.Recommendation);
			MetaPathParameterValues.Add("c36dd9e8-76eb-4070-a5e2-d71472d2a635", () => CallUserTask1.ActivityCategory);
			MetaPathParameterValues.Add("b7a51e66-2269-4a4b-8464-a984e73ec63a", () => CallUserTask1.OwnerId);
			MetaPathParameterValues.Add("b41e63fb-644e-4081-8084-31da283625b8", () => CallUserTask1.Duration);
			MetaPathParameterValues.Add("44c707b1-b574-4e0f-8da8-024acf95d87f", () => CallUserTask1.DurationPeriod);
			MetaPathParameterValues.Add("4ef0de44-de50-4a79-a4a3-685c78677c11", () => CallUserTask1.StartIn);
			MetaPathParameterValues.Add("2f722407-cdcd-4961-8ddd-8dbb319e5e11", () => CallUserTask1.StartInPeriod);
			MetaPathParameterValues.Add("2ebca60d-6f5a-4930-95d7-4b6a3f2262fb", () => CallUserTask1.RemindBefore);
			MetaPathParameterValues.Add("5ccac83d-2665-4614-ae25-41beeb79732f", () => CallUserTask1.RemindBeforePeriod);
			MetaPathParameterValues.Add("68856e02-a0b0-4d45-a066-3fe89a62fd69", () => CallUserTask1.ShowInScheduler);
			MetaPathParameterValues.Add("e6c83a48-4915-41e4-9e25-abe120d327ef", () => CallUserTask1.ShowExecutionPage);
			MetaPathParameterValues.Add("a008f39a-d2ad-454d-a550-1e605db7019e", () => CallUserTask1.Lead);
			MetaPathParameterValues.Add("88f581ab-28da-4f42-ba50-73e73eda1940", () => CallUserTask1.Account);
			MetaPathParameterValues.Add("76d40dbc-7546-4fe6-b6cf-4cfa94b5f2a3", () => CallUserTask1.Contact);
			MetaPathParameterValues.Add("d8c30d45-7596-4f6f-9d77-29ec5446f997", () => CallUserTask1.Opportunity);
			MetaPathParameterValues.Add("ac989d0c-6ef0-44a6-83a4-8a0b2de475ae", () => CallUserTask1.Invoice);
			MetaPathParameterValues.Add("0216a5ce-f2f1-41ba-8da7-318fa2e1f4e6", () => CallUserTask1.Document);
			MetaPathParameterValues.Add("5a15ccfe-5d8a-4440-b85e-0664f836d7c2", () => CallUserTask1.Incident);
			MetaPathParameterValues.Add("25a277cd-6cc7-465e-bde5-994cdd6f4cb3", () => CallUserTask1.Case);
			MetaPathParameterValues.Add("e1c44df1-444e-4ea6-b095-9c55f8596190", () => CallUserTask1.ActivityResult);
			MetaPathParameterValues.Add("71501822-3e64-4c59-af81-ba55a92c1704", () => CallUserTask1.CurrentActivityId);
			MetaPathParameterValues.Add("f02aed8d-81c7-4d8c-91a8-4d46def30995", () => CallUserTask1.IsActivityCompleted);
			MetaPathParameterValues.Add("85a14033-7efe-436c-b126-44c41d88fcab", () => CallUserTask1.ExecutionContext);
			MetaPathParameterValues.Add("9c8d47f9-d4d0-4ed8-b0d0-5c9360bc4543", () => CallUserTask1.InformationOnStep);
			MetaPathParameterValues.Add("0cb31e2e-6562-4665-bae7-92b7dc9784d5", () => CallUserTask1.Order);
			MetaPathParameterValues.Add("8b299ae0-9f52-471a-9f09-2ea39bcd5140", () => CallUserTask1.Contract);
			MetaPathParameterValues.Add("cf0d82a2-8934-44cc-bea9-2ad198a2185b", () => CallUserTask1.Requests);
			MetaPathParameterValues.Add("e1c73a5b-7bf5-44ad-86da-3cca37f8eb22", () => CallUserTask1.Listing);
			MetaPathParameterValues.Add("9f9255b5-5050-431d-bc90-c07fb7bc5f2f", () => CallUserTask1.Property);
			MetaPathParameterValues.Add("a3b46c8b-51b6-4920-85d1-a8e2818cb188", () => CallUserTask1.Project);
			MetaPathParameterValues.Add("652bd3a7-d39c-4f03-a18e-d099b73969ab", () => CallUserTask1.Problem);
			MetaPathParameterValues.Add("76e4f558-542a-4d68-b4d6-39818a94c01e", () => CallUserTask1.Release);
			MetaPathParameterValues.Add("bcddd381-1200-44b9-b25f-173bb44d2404", () => CallUserTask1.Change);
			MetaPathParameterValues.Add("0af03e53-ea16-46d5-8377-21be556cedff", () => CallUserTask1.QueueItem);
		}

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			bool hasValueToRead = reader.HasValue();
			switch (reader.CurrentName) {
				case "CurrentOpportunity":
					if (!hasValueToRead) break;
					CurrentOpportunity = reader.GetValue<System.Guid>();
				break;
				case "MainContact":
					if (!hasValueToRead) break;
					MainContact = reader.GetValue<System.Guid>();
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
			var localOpportunityStageChanged = true;
			OpportunityStageChanged = (System.Boolean)localOpportunityStageChanged;
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
			var cloneItem = (OppManagementNeedAnalysis)base.CloneShallow();
			cloneItem.ExecutedEventHandler = ExecutedEventHandler;
			return cloneItem;
		}

		#endregion

	}

	#endregion

}

