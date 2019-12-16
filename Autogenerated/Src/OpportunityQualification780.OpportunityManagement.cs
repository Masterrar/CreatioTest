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
	using Terrasoft.Configuration.OpportunityManagement;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;

	#region Class: OpportunityQualification780

	/// <exclude/>
	public class OpportunityQualification780 : Terrasoft.Core.Process.Process
	{

		#region Class: ProcessLane1

		/// <exclude/>
		public class ProcessLane1 : ProcessLane
		{

			public ProcessLane1(UserConnection userConnection, OpportunityQualification780 process)
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

			public ReadDataUserTask1FlowElement(UserConnection userConnection, OpportunityQualification780 process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ReadDataUserTask1";
				IsLogging = true;
				SchemaElementUId = new Guid("efc2e1d1-e27f-4be8-a832-6f989b095441");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
			}

			#endregion

			#region Properties: Public

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,237,85,201,110,219,48,16,253,21,67,231,48,208,190,248,86,164,110,145,75,147,54,65,46,113,14,35,114,104,19,149,68,129,164,210,186,134,255,189,35,201,113,157,192,65,156,30,186,0,209,65,144,6,143,143,111,150,71,174,61,94,129,181,159,160,70,111,234,93,163,49,96,181,116,167,31,84,229,208,124,52,186,107,189,19,207,162,81,80,169,31,40,198,248,76,40,247,30,28,208,146,245,252,23,195,220,155,206,15,115,204,189,147,185,167,28,214,150,48,180,36,202,125,46,33,73,152,0,14,44,14,233,5,34,147,172,76,101,24,241,88,96,150,133,35,242,57,242,51,93,183,96,112,220,99,160,151,195,231,245,170,237,161,1,5,248,0,81,86,55,219,96,212,139,176,179,6,202,10,5,253,59,211,33,133,156,81,53,101,131,215,170,198,75,48,180,87,207,163,251,16,129,36,84,182,71,85,40,221,236,123,107,208,90,165,155,151,196,85,93,221,236,163,137,0,119,191,91,57,254,160,177,71,94,130,91,14,20,231,36,107,51,168,124,183,88,24,92,128,83,247,251,34,190,226,106,192,29,87,63,90,32,168,75,55,80,117,184,183,231,227,76,206,160,117,99,66,227,246,4,48,106,177,60,58,215,93,197,94,74,55,164,96,251,0,62,146,243,96,14,97,74,193,251,62,48,178,60,124,206,189,219,115,123,241,173,65,115,197,151,88,195,88,181,187,83,138,62,9,204,42,172,177,113,211,117,9,146,39,33,6,204,231,49,82,29,253,156,21,244,102,41,74,233,151,88,148,113,206,55,180,96,39,104,186,206,35,63,19,61,70,70,144,177,88,4,130,229,65,82,48,8,211,164,136,37,53,4,243,205,221,40,92,217,182,130,213,205,78,223,69,219,106,227,186,70,185,213,196,58,88,224,164,214,66,73,133,98,226,244,228,115,71,30,147,138,67,223,143,211,47,200,181,17,147,97,34,232,33,186,68,164,126,26,69,156,149,17,22,44,46,227,190,233,178,100,144,113,148,152,150,97,30,240,55,211,60,111,154,227,234,247,102,154,151,76,147,132,65,20,37,84,61,44,5,153,70,36,25,203,57,85,212,207,49,21,165,159,165,73,142,79,76,147,10,44,138,130,44,22,100,65,202,226,24,82,150,11,122,197,190,140,184,95,166,60,14,228,115,166,153,53,68,49,113,75,156,232,61,251,8,116,160,42,251,212,38,253,28,84,122,65,38,170,46,90,52,176,237,82,112,120,136,31,77,127,95,32,163,181,27,211,222,21,120,207,179,131,190,135,105,162,253,232,102,236,203,124,165,59,195,183,166,178,227,149,248,91,87,221,95,240,226,107,236,117,112,192,143,25,216,255,243,252,126,245,161,251,214,190,127,233,36,249,3,135,193,198,219,252,4,45,152,154,86,63,11,0,0 })));
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

			#endregion

		}

		#endregion

		#region Class: OpenEditPageUserTask1FlowElement

		/// <exclude/>
		public class OpenEditPageUserTask1FlowElement : OpenEditPageUserTask
		{

			#region Constructors: Public

			public OpenEditPageUserTask1FlowElement(UserConnection userConnection, OpportunityQualification780 process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "OpenEditPageUserTask1";
				IsLogging = true;
				SchemaElementUId = new Guid("5213354a-ebde-4d57-8ce9-08e6db07658e");
				CreatedInSchemaUId = process.InternalSchemaUId;
				ProcessLane = process.Lane1;
				SerializeToDB = true;
				_recordColumnValues_ByProcess = () => (bool)(true);
				_ownerId = () => (Guid)(((Guid)UserConnection.SystemValueManager.GetValue(UserConnection, "CurrentUserContact")));
			}

			private Dictionary<string, Func<object>> _getColumnValueFunctions;
			private  Dictionary<string, Func<object>> GetColumnValueFunctions {
				get {
					if (_getColumnValueFunctions == null) {
						_getColumnValueFunctions = new Dictionary<string, Func<object>>();
						_getColumnValueFunctions.Add("_recordColumnValues_ByProcess", () => _recordColumnValues_ByProcess.Invoke());
					}
					return _getColumnValueFunctions;
				}
			}

			#endregion

			#region Fields: Internal

			internal Func<bool> _recordColumnValues_ByProcess;

			#endregion

			#region Properties: Public

			private Guid _objectSchemaId = new Guid("ae46fb87-c02c-4ae8-ad31-a923cdd994cf");
			public override Guid ObjectSchemaId {
				get {
					return _objectSchemaId;
				}
				set {
					_objectSchemaId = value;
				}
			}

			private Guid _pageSchemaId = new Guid("df249c13-df7a-48d2-b128-85183c4a0e10");
			public override Guid PageSchemaId {
				get {
					return _pageSchemaId;
				}
				set {
					_pageSchemaId = value;
				}
			}

			private int _editMode = 0;
			public override int EditMode {
				get {
					return _editMode;
				}
				set {
					_editMode = value;
				}
			}

			private EntityColumnMappingValues _recordColumnValues;
			public override EntityColumnMappingValues RecordColumnValues {
				get {
					if (_recordColumnValues == null) {
						var zippedData = new byte[] { 31,139,8,0,0,0,0,0,4,0,165,146,203,78,195,48,16,69,127,5,89,93,214,149,157,56,175,110,233,166,18,160,138,66,55,132,197,196,30,67,164,52,169,28,23,9,170,252,59,174,155,208,135,232,6,188,136,237,241,220,235,171,19,239,200,200,126,110,144,76,201,19,26,3,109,163,237,228,182,49,56,89,152,70,98,219,78,238,26,9,85,249,5,69,133,11,48,176,70,139,102,5,213,22,219,187,178,181,227,155,115,25,25,147,209,135,63,37,211,151,29,153,91,92,63,207,149,115,231,82,9,86,36,25,229,28,145,10,45,24,5,30,23,52,86,113,32,85,156,38,168,83,39,150,77,181,93,215,247,104,97,1,246,157,76,119,196,187,57,131,12,165,98,12,19,154,22,50,114,6,81,64,139,48,230,84,36,73,26,114,37,130,40,202,72,55,38,173,124,199,53,248,75,143,98,64,17,235,34,77,168,100,129,164,2,48,165,160,66,78,33,11,66,169,84,150,9,169,247,226,190,255,40,180,198,77,238,64,149,237,166,130,207,213,181,243,205,25,154,211,142,93,126,32,156,147,105,126,141,113,63,47,125,244,115,202,151,128,115,50,206,201,178,217,26,185,119,12,221,102,118,18,205,95,226,91,46,182,3,81,87,169,183,85,213,87,102,96,97,104,28,202,141,42,117,137,106,94,47,7,144,222,133,245,131,254,242,25,198,33,219,127,100,247,80,195,27,154,7,7,224,152,253,39,229,147,195,56,24,103,172,136,163,66,167,148,105,237,254,40,23,156,166,137,123,94,129,8,152,91,128,206,88,226,213,143,168,209,96,45,241,143,193,30,177,245,180,247,79,185,207,181,71,213,145,174,123,237,190,1,101,104,148,191,62,3,0,0 };
						string serializedData =
							Encoding.UTF8.GetString(Compressor.UnZip(zippedData));
						LocalizableParameterValuesList dataList =
							LocalizableParameterValuesList.DeserializeData(serializedData);
						dataList.InitializeLocalizableValues(Storage, "d9478b097ffe45d6a020ada822382894",
							"BaseElements.OpenEditPageUserTask1.Parameters.RecordColumnValues.Value");
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
					return _recommendation ?? (_recommendation = GetLocalizableString("d9478b097ffe45d6a020ada822382894",
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

			private int _startIn = 0;
			public override int StartIn {
				get {
					return _startIn;
				}
				set {
					_startIn = value;
				}
			}

			private int _remindBefore = 0;
			public override int RemindBefore {
				get {
					return _remindBefore;
				}
				set {
					_remindBefore = value;
				}
			}

			private bool _showInScheduler = false;
			public override bool ShowInScheduler {
				get {
					return _showInScheduler;
				}
				set {
					_showInScheduler = value;
				}
			}

			private bool _showExecutionPage = true;
			public override bool ShowExecutionPage {
				get {
					return _showExecutionPage;
				}
				set {
					_showExecutionPage = value;
				}
			}

			private LocalizableString _informationOnStep;
			public override LocalizableString InformationOnStep {
				get {
					return _informationOnStep ?? (_informationOnStep = GetLocalizableString("d9478b097ffe45d6a020ada822382894",
						 "BaseElements.OpenEditPageUserTask1.Parameters.InformationOnStep.Value"));
				}
				set {
					_informationOnStep = value;
				}
			}

			#endregion

		}

		#endregion

		#region Class: ParallelGateway1FlowElement

		/// <exclude/>
		public class ParallelGateway1FlowElement : ProcessParallelGateway
		{

			public ParallelGateway1FlowElement(UserConnection userConnection, OpportunityQualification780 process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessParallelGateway";
				Name = "ParallelGateway1";
				IsLogging = true;
				SchemaElementUId = new Guid("7f62c75e-e7ed-4efc-bb07-d9536c60161d");
				CreatedInSchemaUId = process.InternalSchemaUId;
				IncomingTokens = new Dictionary<string, bool> { { "ReadDataUserTask1", false }, };
				SerializeToDB = Owner.SerializeToDB;
			}

		}

		#endregion

		#region Class: ActivityUserTask2FlowElement

		/// <exclude/>
		public class ActivityUserTask2FlowElement : ActivityUserTask
		{

			#region Constructors: Public

			public ActivityUserTask2FlowElement(UserConnection userConnection, OpportunityQualification780 process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ActivityUserTask2";
				IsLogging = true;
				SchemaElementUId = new Guid("7efcef17-9492-4d59-ac94-3c8c5f2766b5");
				CreatedInSchemaUId = process.InternalSchemaUId;
				ProcessLane = process.Lane1;
				SerializeToDB = true;
				_ownerId = () => (Guid)(((process.ReadDataUserTask1.ResultEntity.IsColumnValueLoaded(process.ReadDataUserTask1.ResultEntity.Schema.Columns.GetByName("Owner").ColumnValueName) ? process.ReadDataUserTask1.ResultEntity.GetTypedColumnValue<Guid>("OwnerId") : Guid.Empty)));
				_duration = () => (int)(30);
				_remindBefore = () => (int)(15);
				_account = () => (Guid)(((process.ReadDataUserTask1.ResultEntity.IsColumnValueLoaded(process.ReadDataUserTask1.ResultEntity.Schema.Columns.GetByName("Account").ColumnValueName) ? process.ReadDataUserTask1.ResultEntity.GetTypedColumnValue<Guid>("AccountId") : Guid.Empty)));
				_contact = () => (Guid)(((process.ReadDataUserTask1.ResultEntity.IsColumnValueLoaded(process.ReadDataUserTask1.ResultEntity.Schema.Columns.GetByName("Contact").ColumnValueName) ? process.ReadDataUserTask1.ResultEntity.GetTypedColumnValue<Guid>("ContactId") : Guid.Empty)));
				_opportunity = () => (Guid)(((process.ReadDataUserTask1.ResultEntity.IsColumnValueLoaded(process.ReadDataUserTask1.ResultEntity.Schema.Columns.GetByName("Id").ColumnValueName) ? process.ReadDataUserTask1.ResultEntity.GetTypedColumnValue<Guid>("Id") : Guid.Empty)));
			}

			#endregion

			#region Properties: Public

			private LocalizableString _recommendation;
			public override LocalizableString Recommendation {
				get {
					return _recommendation ?? (_recommendation = GetLocalizableString("d9478b097ffe45d6a020ada822382894",
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
					return _informationOnStep ?? (_informationOnStep = GetLocalizableString("d9478b097ffe45d6a020ada822382894",
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

		#region Class: ChangeDataUserTask1FlowElement

		/// <exclude/>
		public class ChangeDataUserTask1FlowElement : ChangeDataUserTask
		{

			#region Constructors: Public

			public ChangeDataUserTask1FlowElement(UserConnection userConnection, OpportunityQualification780 process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ChangeDataUserTask1";
				IsLogging = true;
				SchemaElementUId = new Guid("5c0caf9a-7be9-4622-a600-6daed03a2c87");
				CreatedInSchemaUId = process.InternalSchemaUId;
				_recordColumnValues_Stage = () => (Guid)(new Guid("325f0619-0ee0-df11-971b-001d60e938c6"));
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
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,237,84,75,107,219,64,16,254,43,65,231,108,208,203,178,229,91,73,221,146,75,19,72,200,165,206,97,181,26,57,75,245,98,181,78,235,26,67,233,189,96,231,152,83,110,189,244,16,74,31,121,244,1,54,233,15,233,47,233,236,74,114,157,226,18,183,20,122,137,65,120,246,219,111,102,191,217,157,153,161,193,98,90,20,143,104,2,70,219,216,3,33,104,145,69,114,227,1,143,37,136,135,34,235,231,198,186,81,128,224,52,230,207,33,44,241,78,200,229,125,42,41,186,12,187,63,35,116,141,118,119,121,140,174,177,222,53,184,132,164,64,14,186,120,118,192,66,207,49,137,235,51,143,184,52,180,137,31,250,46,49,125,112,35,59,242,130,160,97,151,204,223,5,223,204,146,156,10,40,207,208,225,35,109,238,13,114,69,181,16,96,154,194,139,44,173,64,71,137,40,58,41,13,98,8,113,45,69,31,16,146,130,39,152,13,236,241,4,118,168,192,179,84,156,76,65,72,138,104,92,40,86,12,145,236,60,203,5,20,5,207,210,219,196,197,253,36,93,100,99,0,152,47,43,57,166,214,168,152,59,84,30,234,16,91,40,107,164,85,222,235,245,4,244,168,228,71,139,34,158,192,64,243,86,187,63,116,8,241,149,246,105,220,135,133,51,111,102,178,73,115,89,38,84,30,143,4,193,123,135,43,231,58,191,177,219,210,181,17,204,107,242,138,49,151,230,96,123,8,30,41,160,140,82,155,93,227,241,86,177,253,52,5,177,203,14,33,161,229,173,29,108,32,250,11,208,137,33,129,84,182,135,16,49,27,172,208,34,96,55,35,226,6,208,34,180,229,216,196,139,252,150,31,152,126,195,117,173,17,58,204,5,181,135,158,109,250,142,107,59,196,15,66,7,175,158,50,66,131,166,71,194,86,43,180,24,0,115,220,64,185,116,82,201,229,160,172,132,246,144,130,9,110,131,81,194,92,191,65,220,8,154,132,58,126,72,28,244,181,155,45,176,60,171,57,58,40,211,229,69,30,211,193,254,60,171,217,120,250,26,191,243,217,228,251,139,19,52,206,74,99,114,125,188,134,171,119,26,25,79,63,235,15,119,46,208,120,175,118,190,226,234,229,27,52,190,44,208,62,168,72,27,179,241,245,185,162,213,140,183,181,227,197,218,108,50,125,133,198,149,222,30,79,63,85,255,58,244,201,90,237,160,160,143,179,201,183,99,77,69,41,181,184,243,146,161,118,38,215,218,233,172,162,95,40,77,151,149,156,171,133,35,46,21,235,84,251,42,109,186,7,212,79,149,106,214,227,140,198,219,57,8,90,85,169,185,188,137,111,116,191,42,16,145,101,178,124,246,121,129,109,231,121,38,100,63,197,119,209,55,93,119,19,158,135,67,78,149,217,110,214,23,172,26,42,69,57,221,254,106,106,253,135,89,244,39,227,101,105,131,175,210,176,119,173,120,215,138,255,190,21,71,198,232,7,56,12,197,118,136,8,0,0 })));
				}
				set {
					_dataSourceFilters = value;
				}
			}

			private EntityColumnMappingValues _recordColumnValues;
			public override EntityColumnMappingValues RecordColumnValues {
				get {
					if (_recordColumnValues == null) {
						var zippedData = new byte[] { 31,139,8,0,0,0,0,0,4,0,165,83,203,110,219,48,16,252,149,128,201,209,52,248,144,37,210,215,230,98,192,105,141,58,205,37,206,97,73,46,27,161,178,36,72,84,1,215,240,191,151,146,165,58,14,26,160,64,121,144,192,213,206,236,104,134,60,146,187,112,168,145,44,201,35,54,13,180,149,15,243,79,85,131,243,77,83,89,108,219,249,186,178,80,228,191,192,20,184,129,6,246,24,176,121,130,162,195,118,157,183,97,118,115,13,35,51,114,247,115,248,74,150,207,71,178,10,184,255,182,114,145,29,12,151,124,225,25,21,94,91,154,40,165,168,214,206,83,239,116,202,156,95,24,155,234,8,182,85,209,237,203,7,12,176,129,240,74,150,71,50,176,69,130,76,103,96,229,66,208,68,103,154,38,78,68,2,150,122,170,132,71,147,58,99,181,179,228,52,35,173,125,197,61,12,67,47,96,192,36,245,70,101,212,50,17,167,3,42,10,78,114,10,90,72,235,156,214,137,245,61,120,236,191,0,159,111,215,85,245,163,171,231,214,250,204,41,46,169,183,74,210,36,3,71,13,166,156,42,47,141,52,90,193,34,241,115,41,226,31,166,92,83,134,200,168,243,156,83,157,113,67,25,227,46,101,168,165,178,233,237,75,63,200,229,109,93,192,225,233,195,121,95,234,186,106,66,87,230,225,112,211,6,248,222,7,130,45,150,1,66,94,149,103,146,250,42,143,183,52,199,221,57,214,29,89,238,62,10,118,124,111,7,191,174,163,125,159,234,142,204,118,100,91,117,141,237,25,101,220,220,191,209,63,12,25,90,222,109,167,24,99,165,236,138,98,172,220,67,128,169,113,42,87,46,247,57,186,85,185,157,210,27,88,216,184,232,95,30,211,58,107,251,31,216,3,148,209,223,230,115,52,224,162,253,143,202,199,104,227,68,108,132,94,176,140,123,154,33,196,51,136,169,160,202,113,160,154,107,227,101,38,133,247,98,64,127,69,143,13,150,22,175,133,253,203,33,26,241,237,224,118,127,127,70,93,189,85,39,114,58,189,156,126,3,209,135,47,70,179,3,0,0 };
						string serializedData =
							Encoding.UTF8.GetString(Compressor.UnZip(zippedData));
						LocalizableParameterValuesList dataList =
							LocalizableParameterValuesList.DeserializeData(serializedData);
						dataList.InitializeLocalizableValues(Storage, "d9478b097ffe45d6a020ada822382894",
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

		#region Class: IntermediateCatchSignal1FlowElement

		/// <exclude/>
		public class IntermediateCatchSignal1FlowElement : ProcessIntermediateCatchSignalEvent
		{

			#region Constructors: Public

			public IntermediateCatchSignal1FlowElement(UserConnection userConnection, OpportunityQualification780 process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaIntermediateCatchSignalEvent";
				Name = "IntermediateCatchSignal1";
				IsLogging = true;
				SchemaElementUId = new Guid("14b6eadb-8ff8-419f-9264-b0cc3b892244");
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
				EntityFilters = @"{""className"":""Terrasoft.FilterGroup"",""serializedFilterEditData"":""{\""className\"":\""Terrasoft.FilterGroup\"",\""items\"":{\""49ce241b-3c4f-48d0-9d8d-736ccf66017d\"":{\""className\"":\""Terrasoft.InFilter\"",\""filterType\"":4,\""comparisonType\"":4,\""isEnabled\"":true,\""trimDateTimeParameterToDate\"":false,\""leftExpression\"":{\""className\"":\""Terrasoft.ColumnExpression\"",\""expressionType\"":0,\""columnPath\"":\""Stage\""},\""isAggregative\"":false,\""key\"":\""49ce241b-3c4f-48d0-9d8d-736ccf66017d\"",\""dataValueType\"":10,\""leftExpressionCaption\"":\""Stage\"",\""referenceSchemaName\"":\""OpportunityStage\"",\""rightExpressions\"":[{\""className\"":\""Terrasoft.ParameterExpression\"",\""expressionType\"":2,\""parameter\"":{\""className\"":\""Terrasoft.Parameter\"",\""dataValueType\"":10,\""value\"":{\""Id\"":\""c2067b11-0ee0-df11-971b-001d60e938c6\"",\""Name\"":\""Qualification\"",\""value\"":\""c2067b11-0ee0-df11-971b-001d60e938c6\"",\""displayValue\"":\""Qualification\""}}}]}},\""logicalOperation\"":0,\""isEnabled\"":true,\""filterType\"":6,\""rootSchemaName\"":\""Opportunity\"",\""key\"":\""17c0a3c8-5502-44f7-b107-9b21796767b3\""}"",""dataSourceFilters"":""{\""items\"":{\""49ce241b-3c4f-48d0-9d8d-736ccf66017d\"":{\""filterType\"":4,\""comparisonType\"":4,\""isEnabled\"":true,\""trimDateTimeParameterToDate\"":false,\""leftExpression\"":{\""expressionType\"":0,\""columnPath\"":\""Stage\""},\""rightExpressions\"":[{\""expressionType\"":2,\""parameter\"":{\""dataValueType\"":10,\""value\"":\""c2067b11-0ee0-df11-971b-001d60e938c6\""}}]}},\""logicalOperation\"":0,\""isEnabled\"":true,\""filterType\"":6,\""rootSchemaName\"":\""Opportunity\""}""}";
				_recordId = () => (Guid)(((process.ReadDataUserTask1.ResultEntity.IsColumnValueLoaded(process.ReadDataUserTask1.ResultEntity.Schema.Columns.GetByName("Id").ColumnValueName) ? process.ReadDataUserTask1.ResultEntity.GetTypedColumnValue<Guid>("Id") : Guid.Empty)));
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

		#region Class: CallUserTask1FlowElement

		/// <exclude/>
		public class CallUserTask1FlowElement : CallUserTask
		{

			#region Constructors: Public

			public CallUserTask1FlowElement(UserConnection userConnection, OpportunityQualification780 process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "CallUserTask1";
				IsLogging = true;
				SchemaElementUId = new Guid("8ede2191-30d2-4999-bc6c-c2b979930273");
				CreatedInSchemaUId = process.InternalSchemaUId;
				ProcessLane = process.Lane1;
				SerializeToDB = true;
				_ownerId = () => (Guid)(((process.ReadDataUserTask1.ResultEntity.IsColumnValueLoaded(process.ReadDataUserTask1.ResultEntity.Schema.Columns.GetByName("Owner").ColumnValueName) ? process.ReadDataUserTask1.ResultEntity.GetTypedColumnValue<Guid>("OwnerId") : Guid.Empty)));
				_remindBefore = () => (int)(1);
				_showExecutionPage = () => (bool)((process.OpenCallCustomerPage));
				_account = () => (Guid)(((process.ReadDataUserTask1.ResultEntity.IsColumnValueLoaded(process.ReadDataUserTask1.ResultEntity.Schema.Columns.GetByName("Account").ColumnValueName) ? process.ReadDataUserTask1.ResultEntity.GetTypedColumnValue<Guid>("AccountId") : Guid.Empty)));
				_contact = () => (Guid)(((process.ReadDataUserTask1.ResultEntity.IsColumnValueLoaded(process.ReadDataUserTask1.ResultEntity.Schema.Columns.GetByName("Contact").ColumnValueName) ? process.ReadDataUserTask1.ResultEntity.GetTypedColumnValue<Guid>("ContactId") : Guid.Empty)));
				_opportunity = () => (Guid)(((process.ReadDataUserTask1.ResultEntity.IsColumnValueLoaded(process.ReadDataUserTask1.ResultEntity.Schema.Columns.GetByName("Id").ColumnValueName) ? process.ReadDataUserTask1.ResultEntity.GetTypedColumnValue<Guid>("Id") : Guid.Empty)));
			}

			#endregion

			#region Properties: Public

			private LocalizableString _recommendation;
			public override LocalizableString Recommendation {
				get {
					return _recommendation ?? (_recommendation = GetLocalizableString("d9478b097ffe45d6a020ada822382894",
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
					return _informationOnStep ?? (_informationOnStep = GetLocalizableString("d9478b097ffe45d6a020ada822382894",
						 "BaseElements.CallUserTask1.Parameters.InformationOnStep.Value"));
				}
				set {
					_informationOnStep = value;
				}
			}

			#endregion

			#region Methods: Public

			public override string GetResultAllowedValues() {
				return "[\"ee2e1f86-f36b-1410-8f8f-485b39b2edcc\",\"5fbd327e-f36b-1410-6598-00155d043204\"]";
			}

			#endregion

			#region Methods: Protected

			protected override void AfterActivitySaveScriptExecute(Entity activity) {
			}

			#endregion

		}

		#endregion

		#region Class: UserTask1FlowElement

		/// <exclude/>
		public class UserTask1FlowElement : StartOpportunityManagementProcessUserTask
		{

			#region Constructors: Public

			public UserTask1FlowElement(UserConnection userConnection, OpportunityQualification780 process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "UserTask1";
				IsLogging = true;
				SchemaElementUId = new Guid("9b423a46-df83-48db-add0-1fdca3646596");
				CreatedInSchemaUId = process.InternalSchemaUId;
				_processSchemaUId = () => (Guid)(new Guid("6bf791ec-1818-465e-aa06-54135080911c"));
				_opportunityId = () => (Guid)(((process.ReadDataUserTask1.ResultEntity.IsColumnValueLoaded(process.ReadDataUserTask1.ResultEntity.Schema.Columns.GetByName("Id").ColumnValueName) ? process.ReadDataUserTask1.ResultEntity.GetTypedColumnValue<Guid>("Id") : Guid.Empty)));
			}

			#endregion

			#region Properties: Public

			internal Func<Guid> _processSchemaUId;
			public override Guid ProcessSchemaUId {
				get {
					return (_processSchemaUId ?? (_processSchemaUId = () => Guid.Empty)).Invoke();
				}
				set {
					_processSchemaUId = () => { return value; };
				}
			}

			internal Func<Guid> _opportunityId;
			public override Guid OpportunityId {
				get {
					return (_opportunityId ?? (_opportunityId = () => Guid.Empty)).Invoke();
				}
				set {
					_opportunityId = () => { return value; };
				}
			}

			private string _customPropertyValues;
			public override string CustomPropertyValues {
				get {
					return _customPropertyValues ?? (_customPropertyValues = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,171,86,242,47,72,205,115,206,207,75,41,77,46,9,40,74,45,78,205,43,73,44,201,204,207,115,78,44,74,81,178,42,41,42,77,173,5,0,127,4,247,211,36,0,0,0 })));
				}
				set {
					_customPropertyValues = value;
				}
			}

			#endregion

		}

		#endregion

		public OpportunityQualification780(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "OpportunityQualification780";
			SchemaUId = new Guid("d9478b09-7ffe-45d6-a020-ada822382894");
			Caption = Schema.Caption;
			SchemaManagerName = "ProcessSchemaManager";
			SerializeToDB = true;
			SerializeToMemory = true;
			IsLogging = true;
			_openCallCustomerPage = () => { return (bool)(false); };
			InitializeFlowElements();
		}

		#region Properties: Private

		private  Guid InternalSchemaUId {
			get {
				return new Guid("d9478b09-7ffe-45d6-a020-ada822382894");
			}
		}

		#endregion

		#region Properties: Public

		private Func<bool> _openCallCustomerPage;
		public  virtual bool OpenCallCustomerPage {
			get {
				return (_openCallCustomerPage ?? (_openCallCustomerPage = () => false)).Invoke();
			}
			set {
				_openCallCustomerPage = () => { return value; };
			}
		}

		private ProcessLane1 _lane1;
		public  ProcessLane1 Lane1 {
			get {
				return _lane1 ?? ((_lane1) = new ProcessLane1(UserConnection, this));
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
					SchemaElementUId = new Guid("f52d5c0d-3680-4057-ac43-d0c0f5731c04"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
				});
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
					SchemaElementUId = new Guid("7a571283-46df-4d9f-ad2b-724d4bac9ea7"),
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
					SchemaElementUId = new Guid("bafc52e1-0c4e-4208-9420-6eff0be9b48c"),
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

		private ParallelGateway1FlowElement _parallelGateway1;
		public  ParallelGateway1FlowElement ParallelGateway1 {
			get {
				return _parallelGateway1 ?? ((_parallelGateway1) = new ParallelGateway1FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ActivityUserTask2FlowElement _activityUserTask2;
		public  ActivityUserTask2FlowElement ActivityUserTask2 {
			get {
				return _activityUserTask2 ?? (_activityUserTask2 = new ActivityUserTask2FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ChangeDataUserTask1FlowElement _changeDataUserTask1;
		public  ChangeDataUserTask1FlowElement ChangeDataUserTask1 {
			get {
				return _changeDataUserTask1 ?? (_changeDataUserTask1 = new ChangeDataUserTask1FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private IntermediateCatchSignal1FlowElement _intermediateCatchSignal1;
		public  IntermediateCatchSignal1FlowElement IntermediateCatchSignal1 {
			get {
				return _intermediateCatchSignal1 ?? ((_intermediateCatchSignal1) = new IntermediateCatchSignal1FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
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
					SchemaElementUId = new Guid("40649017-e64d-4f6b-8a6d-0a75be2f4fe1"),
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
					SchemaElementUId = new Guid("e95539ec-9b6a-4ff7-b2ef-2e21e766a349"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
						Message = "CallToCustomerCompleted",
				});
			}
		}

		private UserTask1FlowElement _userTask1;
		public  UserTask1FlowElement UserTask1 {
			get {
				return _userTask1 ?? (_userTask1 = new UserTask1FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
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
					SchemaElementUId = new Guid("f5e9489a-3f43-49fb-90c4-3ae4542b5879"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
					Script = FormulaTask1Execute,
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
					SchemaElementUId = new Guid("fb6994ae-ea59-42fe-906d-8923e72a7977"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
						ProcessActivitiesSelectedResults = new Dictionary<Guid, Collection<Guid>>() {
						{new Guid("7efcef17-9492-4d59-ac94-3c8c5f2766b5"), new Collection<Guid>() {
							new Guid("632afdd2-f616-4ea6-87d2-8ed38eed8aff"),
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
					SchemaElementUId = new Guid("0efa81da-444f-430e-a05e-9d34d984556b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
						ProcessActivitiesSelectedResults = new Dictionary<Guid, Collection<Guid>>() {
						{new Guid("8ede2191-30d2-4999-bc6c-c2b979930273"), new Collection<Guid>() {
							new Guid("ee2e1f86-f36b-1410-8f8f-485b39b2edcc"),
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
					SchemaElementUId = new Guid("cbea6889-ef7c-4826-9f64-a66c1c854028"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
						ProcessActivitiesSelectedResults = new Dictionary<Guid, Collection<Guid>>() {
						{new Guid("8ede2191-30d2-4999-bc6c-c2b979930273"), new Collection<Guid>() {
							new Guid("5fbd327e-f36b-1410-6598-00155d043204"),
						}},
					},
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[StartEvent1.SchemaElementUId] = new Collection<ProcessFlowElement> { StartEvent1 };
			FlowElements[TerminateEvent1.SchemaElementUId] = new Collection<ProcessFlowElement> { TerminateEvent1 };
			FlowElements[StartSignal1.SchemaElementUId] = new Collection<ProcessFlowElement> { StartSignal1 };
			FlowElements[ReadDataUserTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { ReadDataUserTask1 };
			FlowElements[OpenEditPageUserTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { OpenEditPageUserTask1 };
			FlowElements[ParallelGateway1.SchemaElementUId] = new Collection<ProcessFlowElement> { ParallelGateway1 };
			FlowElements[ActivityUserTask2.SchemaElementUId] = new Collection<ProcessFlowElement> { ActivityUserTask2 };
			FlowElements[ChangeDataUserTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { ChangeDataUserTask1 };
			FlowElements[IntermediateCatchSignal1.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateCatchSignal1 };
			FlowElements[CallUserTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { CallUserTask1 };
			FlowElements[ExclusiveGateway1.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway1 };
			FlowElements[IntermediateThrowMessage1.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowMessage1 };
			FlowElements[UserTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { UserTask1 };
			FlowElements[FormulaTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { FormulaTask1 };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "StartEvent1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("OpenEditPageUserTask1", e.Context.SenderName));
						break;
					case "TerminateEvent1":
						CompleteProcess();
						break;
					case "StartSignal1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ReadDataUserTask1", e.Context.SenderName));
						break;
					case "ReadDataUserTask1":
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ParallelGateway1", e.Context.SenderName));
						break;
					case "OpenEditPageUserTask1":
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ReadDataUserTask1", e.Context.SenderName));
						break;
					case "ParallelGateway1":
						if (ParallelGateway1.IsAllPreviousFlowElementsExecuted()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ActivityUserTask2", e.Context.SenderName));
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("IntermediateCatchSignal1", e.Context.SenderName));
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("CallUserTask1", e.Context.SenderName));
						}
						break;
					case "ActivityUserTask2":
						if (ActivityUserTask2.ActivityResult == new Guid("632afdd2-f616-4ea6-87d2-8ed38eed8aff")) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ChangeDataUserTask1", e.Context.SenderName));
							break;
						}
						break;
					case "ChangeDataUserTask1":
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("TerminateEvent1", e.Context.SenderName));
						break;
					case "IntermediateCatchSignal1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("TerminateEvent1", e.Context.SenderName));
						break;
					case "CallUserTask1":
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ExclusiveGateway1", e.Context.SenderName));
						break;
					case "ExclusiveGateway1":
						if (CallUserTask1.ActivityResult == new Guid("ee2e1f86-f36b-1410-8f8f-485b39b2edcc")) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("UserTask1", e.Context.SenderName));
							break;
						}
						if (CallUserTask1.ActivityResult == new Guid("5fbd327e-f36b-1410-6598-00155d043204")) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("FormulaTask1", e.Context.SenderName));
							break;
						}
						break;
					case "IntermediateThrowMessage1":
						break;
					case "UserTask1":
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("IntermediateThrowMessage1", e.Context.SenderName));
						break;
					case "FormulaTask1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("CallUserTask1", e.Context.SenderName));
						break;
			}
		}

		private void WritePropertyValues(DataWriter writer, bool useAllValueSources) {
			if (!HasMapping("OpenCallCustomerPage")) {
				writer.WriteValue("OpenCallCustomerPage", OpenCallCustomerPage, false);
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
			MetaPathParameterValues.Add("f49e5b57-3ed6-4739-a75d-b52c5d5f57df", () => OpenCallCustomerPage);
			MetaPathParameterValues.Add("8307d420-f3a7-4d1d-8159-a26594fdace8", () => StartSignal1.RecordId);
			MetaPathParameterValues.Add("a5ec017a-d83d-41ba-b04a-41cd432e4ff0", () => StartSignal1.EntitySchemaUId);
			MetaPathParameterValues.Add("8afecaed-ec80-4286-ab96-478b2df98b21", () => ReadDataUserTask1.DataSourceFilters);
			MetaPathParameterValues.Add("667a85b8-8bea-4942-9ca4-b452b4f70614", () => ReadDataUserTask1.ResultType);
			MetaPathParameterValues.Add("edbb613b-12d0-4326-96ef-aeb41f4fda3a", () => ReadDataUserTask1.ReadSomeTopRecords);
			MetaPathParameterValues.Add("ed0bbb55-321b-4834-9666-b5f43b6092ed", () => ReadDataUserTask1.NumberOfRecords);
			MetaPathParameterValues.Add("46130a08-1f9b-4b0a-81f0-eb92d739d062", () => ReadDataUserTask1.FunctionType);
			MetaPathParameterValues.Add("7cd95afa-7dd0-43f3-9a54-c64ff5465148", () => ReadDataUserTask1.AggregationColumnName);
			MetaPathParameterValues.Add("95d7aafc-8f68-4000-9fb1-8c339ef0354e", () => ReadDataUserTask1.OrderInfo);
			MetaPathParameterValues.Add("62093423-9bd3-4aac-ab76-d88d1ceec34b", () => ReadDataUserTask1.ResultEntity);
			MetaPathParameterValues.Add("e8062460-c9ed-41e1-8c8e-0811ebd0ff8d", () => ReadDataUserTask1.ResultCount);
			MetaPathParameterValues.Add("e5255b93-b96d-4b4b-a49d-bc33f567b4c0", () => ReadDataUserTask1.ResultIntegerFunction);
			MetaPathParameterValues.Add("66f48462-d1ed-4847-9070-af7cd65e1500", () => ReadDataUserTask1.ResultFloatFunction);
			MetaPathParameterValues.Add("476031ca-d5d6-4ce7-b327-a090704a984a", () => ReadDataUserTask1.ResultDateTimeFunction);
			MetaPathParameterValues.Add("ef6fb2b4-64c9-4887-823f-b3e52c51c627", () => ReadDataUserTask1.ResultRowsCount);
			MetaPathParameterValues.Add("ae0759e7-9c44-4856-995c-e79564c149a0", () => ReadDataUserTask1.CanReadUncommitedData);
			MetaPathParameterValues.Add("fb810667-a172-4cd6-a956-da6baedd09e3", () => ReadDataUserTask1.ResultEntityCollection);
			MetaPathParameterValues.Add("50273b42-eed0-4f2f-980d-64b17969d0b2", () => ReadDataUserTask1.EntityColumnMetaPathes);
			MetaPathParameterValues.Add("9f5e0f24-3bc9-42a2-9608-d1ce6c6ff290", () => ReadDataUserTask1.IgnoreDisplayValues);
			MetaPathParameterValues.Add("85464f7b-ebc1-46a3-9ac5-1012da140b9d", () => OpenEditPageUserTask1.ObjectSchemaId);
			MetaPathParameterValues.Add("ee3e00bf-d548-4ebb-b41c-29bea45e1ff0", () => OpenEditPageUserTask1.PageSchemaId);
			MetaPathParameterValues.Add("b449a16c-c1fa-4999-b42b-80ec509256f8", () => OpenEditPageUserTask1.EditMode);
			MetaPathParameterValues.Add("e1edf905-8f74-4446-bf56-b964739497ac", () => OpenEditPageUserTask1.RecordColumnValues);
			MetaPathParameterValues.Add("6de9994e-1716-44a6-8da6-40f3c0b6c41f", () => OpenEditPageUserTask1.RecordId);
			MetaPathParameterValues.Add("02cb671e-f164-4ba9-a005-7c95586d3257", () => OpenEditPageUserTask1.ExecutedMode);
			MetaPathParameterValues.Add("de665ee1-1b07-4933-b6c6-540dc5f0c49b", () => OpenEditPageUserTask1.IsMatchConditions);
			MetaPathParameterValues.Add("2d75911f-a655-43af-bfc7-dec36539d692", () => OpenEditPageUserTask1.DataSourceFilters);
			MetaPathParameterValues.Add("5a93c40c-3d1c-4991-81dc-509e063fbda2", () => OpenEditPageUserTask1.GenerateDecisionsFromColumn);
			MetaPathParameterValues.Add("f0209383-3120-44c4-a5a6-d6f3961042ea", () => OpenEditPageUserTask1.DecisionalColumnMetaPath);
			MetaPathParameterValues.Add("228f1d5c-4a6f-4db7-ae95-05082bddbd6c", () => OpenEditPageUserTask1.ResultParameter);
			MetaPathParameterValues.Add("a7839859-2510-4009-915c-8f5f3cbeed10", () => OpenEditPageUserTask1.IsReexecution);
			MetaPathParameterValues.Add("999155d0-5d77-44ad-b8bd-0c4b7297e5fd", () => OpenEditPageUserTask1.Recommendation);
			MetaPathParameterValues.Add("651a67ce-4040-41f1-b0ac-80bcbe0deabe", () => OpenEditPageUserTask1.ActivityCategory);
			MetaPathParameterValues.Add("e9c6f821-0b8e-46af-9290-156e68e21181", () => OpenEditPageUserTask1.OwnerId);
			MetaPathParameterValues.Add("055cdea9-99db-4d21-af57-f5f04a72a1ac", () => OpenEditPageUserTask1.Duration);
			MetaPathParameterValues.Add("9c117fe9-7134-47fd-abe9-658ae098cd5b", () => OpenEditPageUserTask1.DurationPeriod);
			MetaPathParameterValues.Add("b3e38439-d07c-4fbd-b336-ac2752ae4ab0", () => OpenEditPageUserTask1.StartIn);
			MetaPathParameterValues.Add("42e22761-b247-4ac2-b029-ba5e46ee0d8a", () => OpenEditPageUserTask1.StartInPeriod);
			MetaPathParameterValues.Add("2ef9666a-4a5d-4a0a-8843-d2da2dd8f329", () => OpenEditPageUserTask1.RemindBefore);
			MetaPathParameterValues.Add("54adec75-514d-45f2-b45b-8bbc1cc8a1c3", () => OpenEditPageUserTask1.RemindBeforePeriod);
			MetaPathParameterValues.Add("e5c525fe-baa7-4cfb-bb8d-102e07413842", () => OpenEditPageUserTask1.ShowInScheduler);
			MetaPathParameterValues.Add("b0d98c5b-cff3-4cbe-a3a2-815d9b973273", () => OpenEditPageUserTask1.ShowExecutionPage);
			MetaPathParameterValues.Add("11a74a6b-52e4-4233-b97c-2788b403f6ba", () => OpenEditPageUserTask1.Lead);
			MetaPathParameterValues.Add("8e51933f-29af-4a63-932d-4a79f4c79076", () => OpenEditPageUserTask1.Account);
			MetaPathParameterValues.Add("b857d733-56f5-41ab-a4c1-c81f67a62265", () => OpenEditPageUserTask1.Contact);
			MetaPathParameterValues.Add("9069ae6d-db54-4b81-a1d9-03c584d8c1c9", () => OpenEditPageUserTask1.Opportunity);
			MetaPathParameterValues.Add("d1ecbd87-16a4-4185-8563-e83a64a1f721", () => OpenEditPageUserTask1.Invoice);
			MetaPathParameterValues.Add("89d9571f-d000-48a8-84e3-424d8becc567", () => OpenEditPageUserTask1.Document);
			MetaPathParameterValues.Add("b22ff4eb-e659-4f15-bfbb-9af6c7418d55", () => OpenEditPageUserTask1.Incident);
			MetaPathParameterValues.Add("50f7bebb-2c11-4250-8d9d-be478376db3b", () => OpenEditPageUserTask1.Case);
			MetaPathParameterValues.Add("3c9cd508-251b-4720-bea1-283a0bc33839", () => OpenEditPageUserTask1.ActivityResult);
			MetaPathParameterValues.Add("967e5d38-a9f9-44fd-b56f-1592f77a76f9", () => OpenEditPageUserTask1.CurrentActivityId);
			MetaPathParameterValues.Add("4e25db75-bafd-4adf-9502-d7cd9c1040b3", () => OpenEditPageUserTask1.IsActivityCompleted);
			MetaPathParameterValues.Add("8ad52373-577e-4a7c-b62c-36d0eb79fc80", () => OpenEditPageUserTask1.ExecutionContext);
			MetaPathParameterValues.Add("763bfef2-c773-4b0e-b598-7926fe62aff9", () => OpenEditPageUserTask1.PageTypeUId);
			MetaPathParameterValues.Add("85889473-14e7-448d-804a-6f0b8de8c732", () => OpenEditPageUserTask1.ActivitySchemaUId);
			MetaPathParameterValues.Add("6f19bceb-b335-48be-b81c-266ab819de03", () => OpenEditPageUserTask1.InformationOnStep);
			MetaPathParameterValues.Add("af0ba0c4-2021-4d10-bea5-a8dd4e046327", () => OpenEditPageUserTask1.Order);
			MetaPathParameterValues.Add("256468e3-9e8a-4c33-a350-2c84fd8d8f74", () => OpenEditPageUserTask1.Requests);
			MetaPathParameterValues.Add("2490172f-d5b3-4684-9785-70c720cff3cb", () => OpenEditPageUserTask1.Listing);
			MetaPathParameterValues.Add("d60c3f04-1282-42e5-970c-64d5c432ee2e", () => OpenEditPageUserTask1.Property);
			MetaPathParameterValues.Add("3d11ad8f-6843-4af5-a6a0-f83071a55175", () => OpenEditPageUserTask1.Contract);
			MetaPathParameterValues.Add("57941d01-5fde-4c9b-b650-32e88335cb8e", () => OpenEditPageUserTask1.Problem);
			MetaPathParameterValues.Add("f03b8a64-190f-497f-8354-ac59da75843f", () => OpenEditPageUserTask1.Change);
			MetaPathParameterValues.Add("bbe5f02c-f7d4-43df-808d-fbd9f2428e65", () => OpenEditPageUserTask1.Release);
			MetaPathParameterValues.Add("47a5dacf-c276-4c81-a214-3a11bbb0456e", () => OpenEditPageUserTask1.Project);
			MetaPathParameterValues.Add("7dbf9948-4712-4e71-bb5f-1e151e4d74ff", () => ActivityUserTask2.Recommendation);
			MetaPathParameterValues.Add("6d9471de-3905-423d-b2cc-5b80ea82fa01", () => ActivityUserTask2.ActivityCategory);
			MetaPathParameterValues.Add("2763418f-b125-4add-aa5d-6e6f544b0021", () => ActivityUserTask2.OwnerId);
			MetaPathParameterValues.Add("1965fcbc-3746-4ee7-8c5b-c8456564fd69", () => ActivityUserTask2.Duration);
			MetaPathParameterValues.Add("53ba906a-b6c8-43cb-b63f-4f465fdc00aa", () => ActivityUserTask2.DurationPeriod);
			MetaPathParameterValues.Add("58502524-d3ef-4bfe-9aef-daac9ddf1240", () => ActivityUserTask2.StartIn);
			MetaPathParameterValues.Add("52c25dfe-5b38-4c99-98a5-c9f2ba537c71", () => ActivityUserTask2.StartInPeriod);
			MetaPathParameterValues.Add("bbcc3169-e2e4-4413-a108-44032fcf07b1", () => ActivityUserTask2.RemindBefore);
			MetaPathParameterValues.Add("2b6951f0-3571-40e3-8bf6-f258d6d6cbd5", () => ActivityUserTask2.RemindBeforePeriod);
			MetaPathParameterValues.Add("2659fd4b-f258-4f59-89ba-f50aa3010ea7", () => ActivityUserTask2.ShowInScheduler);
			MetaPathParameterValues.Add("5eca43d4-6dbb-4bda-9431-8d370f012042", () => ActivityUserTask2.ShowExecutionPage);
			MetaPathParameterValues.Add("d8b11ab8-1cab-4e43-b3a3-3df04312184b", () => ActivityUserTask2.Lead);
			MetaPathParameterValues.Add("4f833d67-306a-49d0-b696-b6dc3ecb396d", () => ActivityUserTask2.Account);
			MetaPathParameterValues.Add("86d41a34-2192-414b-8580-07d4ade773da", () => ActivityUserTask2.Contact);
			MetaPathParameterValues.Add("254e86c7-e049-4a64-a722-c1b2860dfd34", () => ActivityUserTask2.Opportunity);
			MetaPathParameterValues.Add("d2c35a6b-70e8-4ac5-9077-f6d37c7efdcf", () => ActivityUserTask2.Invoice);
			MetaPathParameterValues.Add("3a2b4154-ed3e-4c4d-8732-e1f5db9a036b", () => ActivityUserTask2.Document);
			MetaPathParameterValues.Add("3dcb7473-26f6-4c95-9b0c-1f7dc1c04bbb", () => ActivityUserTask2.Incident);
			MetaPathParameterValues.Add("56ca14fa-1f1e-4e35-b6a0-10e8ec333265", () => ActivityUserTask2.Case);
			MetaPathParameterValues.Add("2803c085-9930-4f59-8485-a7040bc96c9f", () => ActivityUserTask2.ActivityResult);
			MetaPathParameterValues.Add("b41776f8-ba32-4ff7-b04a-a4d795c62659", () => ActivityUserTask2.CurrentActivityId);
			MetaPathParameterValues.Add("07921dbb-03f3-4585-a711-509624e98dcb", () => ActivityUserTask2.IsActivityCompleted);
			MetaPathParameterValues.Add("cb96e4d7-1329-4458-affc-13edea4950cf", () => ActivityUserTask2.ExecutionContext);
			MetaPathParameterValues.Add("2d7f3b6d-c675-4ebe-b05b-d6099b06a7d1", () => ActivityUserTask2.InformationOnStep);
			MetaPathParameterValues.Add("28eb5c24-cb41-4064-a183-f482902fd976", () => ActivityUserTask2.Order);
			MetaPathParameterValues.Add("55222b9c-c380-479d-a29f-9946b4beb322", () => ActivityUserTask2.Requests);
			MetaPathParameterValues.Add("02f19e5c-e15b-429c-8265-db059b0c8e7a", () => ActivityUserTask2.Listing);
			MetaPathParameterValues.Add("cf327b83-3fdd-4c67-9eff-58fbe4ca20bc", () => ActivityUserTask2.Property);
			MetaPathParameterValues.Add("b24d7ad7-605b-42b7-882d-da9bd184fdd1", () => ActivityUserTask2.Contract);
			MetaPathParameterValues.Add("793715e0-91c0-454b-9006-47a8841e1baa", () => ActivityUserTask2.Project);
			MetaPathParameterValues.Add("59f8f32d-bf14-45a3-9842-5df195a936c8", () => ActivityUserTask2.Problem);
			MetaPathParameterValues.Add("7cea8113-48e6-4437-87ca-83967b00b6f3", () => ActivityUserTask2.Change);
			MetaPathParameterValues.Add("871ae086-f9a8-4931-ae8f-122bfec48b16", () => ActivityUserTask2.Release);
			MetaPathParameterValues.Add("c73fd79c-4d1e-42d2-b190-5eae517b8b8c", () => ActivityUserTask2.QueueItem);
			MetaPathParameterValues.Add("1684cbb9-a4f0-41b7-95ec-e121ad6f352c", () => ActivityUserTask2.Application);
			MetaPathParameterValues.Add("89776307-ec67-4267-bb06-eae01ce00609", () => ActivityUserTask2.FinApplication);
			MetaPathParameterValues.Add("4f67bcfc-d8b8-4b05-8dab-fe4cc66ddbc2", () => ChangeDataUserTask1.EntitySchemaUId);
			MetaPathParameterValues.Add("7c819fba-4460-49c2-88b7-650675f2b972", () => ChangeDataUserTask1.IsMatchConditions);
			MetaPathParameterValues.Add("31f23021-731d-4523-b6ed-b9db8aa073f7", () => ChangeDataUserTask1.DataSourceFilters);
			MetaPathParameterValues.Add("9afab25c-935c-4ebb-87c4-dec58a11997b", () => ChangeDataUserTask1.RecordColumnValues);
			MetaPathParameterValues.Add("ff5b942b-f8af-432a-8723-53a29cdcb21a", () => IntermediateCatchSignal1.RecordId);
			MetaPathParameterValues.Add("c9117b70-5b5d-423e-b862-f68b2e1aa2c6", () => CallUserTask1.Recommendation);
			MetaPathParameterValues.Add("c106b3a0-4584-48f6-a019-fd7d7eccd5af", () => CallUserTask1.ActivityCategory);
			MetaPathParameterValues.Add("62d704b8-26e2-433a-aaed-31cbed4c2949", () => CallUserTask1.OwnerId);
			MetaPathParameterValues.Add("72904128-c29e-436e-8997-ce679e9eb2e3", () => CallUserTask1.Duration);
			MetaPathParameterValues.Add("297c1a2d-24f4-4664-a60b-c7f497c7b25f", () => CallUserTask1.DurationPeriod);
			MetaPathParameterValues.Add("dff06883-a753-4218-b240-06750723618d", () => CallUserTask1.StartIn);
			MetaPathParameterValues.Add("a18a0890-dfa2-459f-8060-ef16e5183dcb", () => CallUserTask1.StartInPeriod);
			MetaPathParameterValues.Add("886c439a-b16a-4707-810d-77215e3c11ab", () => CallUserTask1.RemindBefore);
			MetaPathParameterValues.Add("1a2ff12f-0759-43a7-a2b7-d44b04376e86", () => CallUserTask1.RemindBeforePeriod);
			MetaPathParameterValues.Add("9d0966e1-0464-4d74-9d32-b7f9a377f3d1", () => CallUserTask1.ShowInScheduler);
			MetaPathParameterValues.Add("811a9345-f77e-48e0-9cc6-a72892476921", () => CallUserTask1.ShowExecutionPage);
			MetaPathParameterValues.Add("ec72cb00-d049-4978-a038-fac31ba9921a", () => CallUserTask1.Lead);
			MetaPathParameterValues.Add("5ba66c93-38ae-4d96-98a3-f5bc71bdd3a7", () => CallUserTask1.Account);
			MetaPathParameterValues.Add("65714982-1c3c-4d20-87e8-9bd62cb377ae", () => CallUserTask1.Contact);
			MetaPathParameterValues.Add("96942896-b4ac-4a4c-94a6-09484a46faeb", () => CallUserTask1.Opportunity);
			MetaPathParameterValues.Add("209f0236-d226-4aa2-ae50-89df0f0fe994", () => CallUserTask1.Invoice);
			MetaPathParameterValues.Add("1c9ef90d-636f-40f4-a1a8-45913edfb4b3", () => CallUserTask1.Document);
			MetaPathParameterValues.Add("265db42b-2a5e-423a-921c-20490a01ff4d", () => CallUserTask1.Incident);
			MetaPathParameterValues.Add("c91d4af2-a881-474f-a2db-05a0dda3940c", () => CallUserTask1.Case);
			MetaPathParameterValues.Add("07d8bb57-81c5-4406-a796-41de55b30092", () => CallUserTask1.ActivityResult);
			MetaPathParameterValues.Add("2ec08381-4dfa-42ab-b27c-f057ac9cc50d", () => CallUserTask1.CurrentActivityId);
			MetaPathParameterValues.Add("5e3ad581-abdd-4b59-9330-9cb5b3477c70", () => CallUserTask1.IsActivityCompleted);
			MetaPathParameterValues.Add("5bae4177-edf2-4549-9c97-8952f2644844", () => CallUserTask1.ExecutionContext);
			MetaPathParameterValues.Add("c52fe93f-1469-4c99-bc45-56917f7129b3", () => CallUserTask1.InformationOnStep);
			MetaPathParameterValues.Add("900c2d6d-076b-4625-89e8-97fe7929f061", () => CallUserTask1.Order);
			MetaPathParameterValues.Add("fc6314f7-57b5-44ee-92e5-61e0fb6b5e63", () => CallUserTask1.Contract);
			MetaPathParameterValues.Add("7addf626-66d5-466d-a22c-a4cc040880d3", () => CallUserTask1.Requests);
			MetaPathParameterValues.Add("2cc41e9b-0821-4abd-8445-fa29555cc0f7", () => CallUserTask1.Listing);
			MetaPathParameterValues.Add("3cbfd4ff-01a8-4be7-a32b-69b3b9cef7d1", () => CallUserTask1.Property);
			MetaPathParameterValues.Add("0d29ab43-0278-4900-a920-135abf5fcd10", () => CallUserTask1.Project);
			MetaPathParameterValues.Add("fe0607cd-59fd-4a78-8430-f55018aed85b", () => CallUserTask1.Problem);
			MetaPathParameterValues.Add("c867d70e-9835-4eb8-8a6e-eeea35789ea0", () => CallUserTask1.Release);
			MetaPathParameterValues.Add("6c1b8795-651f-40f0-b376-87941e6d1a29", () => CallUserTask1.Change);
			MetaPathParameterValues.Add("b20007ff-a08d-481d-bd96-be8ce553bccd", () => CallUserTask1.QueueItem);
			MetaPathParameterValues.Add("fb67000c-49a2-4a90-ab5b-56873c5fdf94", () => UserTask1.ProcessSchemaUId);
			MetaPathParameterValues.Add("f2c10342-440c-4ee1-8913-5a6d09adeae0", () => UserTask1.OpportunityId);
			MetaPathParameterValues.Add("5615e6f4-5141-4ad6-9bfb-9c01c12464b9", () => UserTask1.CustomPropertyValues);
		}

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			bool hasValueToRead = reader.HasValue();
			switch (reader.CurrentName) {
				case "OpenCallCustomerPage":
					if (!hasValueToRead) break;
					OpenCallCustomerPage = reader.GetValue<System.Boolean>();
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
			var localOpenCallCustomerPage = true;
			OpenCallCustomerPage = (System.Boolean)localOpenCallCustomerPage;
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
			var cloneItem = (OpportunityQualification780)base.CloneShallow();
			cloneItem.ExecutedEventHandler = ExecutedEventHandler;
			return cloneItem;
		}

		#endregion

	}

	#endregion

}

