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

	#region Class: Proposal780

	/// <exclude/>
	public class Proposal780 : Terrasoft.Core.Process.Process
	{

		#region Class: ProcessLane1

		/// <exclude/>
		public class ProcessLane1 : ProcessLane
		{

			public ProcessLane1(UserConnection userConnection, Proposal780 process)
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

			public ReadDataUserTask1FlowElement(UserConnection userConnection, Proposal780 process)
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
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,237,83,193,142,218,48,16,253,21,148,243,26,153,36,36,129,91,181,165,213,94,10,234,162,189,52,123,152,196,227,96,213,137,35,219,217,150,34,254,189,118,2,148,173,168,150,238,97,123,105,78,206,211,243,155,55,207,51,187,160,148,96,204,39,168,49,152,7,107,212,26,140,226,118,252,65,72,139,250,163,86,93,27,220,4,6,181,0,41,126,32,27,240,5,19,246,61,88,112,87,118,249,47,133,60,152,231,151,53,242,224,38,15,132,197,218,56,142,187,50,205,74,70,67,202,73,194,83,74,226,25,79,9,204,24,35,49,114,140,34,142,49,205,102,3,243,79,226,183,170,110,65,227,80,163,151,231,253,113,189,109,61,117,226,128,178,167,8,163,154,3,24,121,19,102,209,64,33,145,185,127,171,59,116,144,213,162,118,221,224,90,212,184,2,237,106,121,29,229,33,71,226,32,141,103,73,228,118,241,189,213,104,140,80,205,75,230,100,87,55,231,108,39,128,167,223,131,29,218,123,244,204,21,216,77,47,113,231,108,237,123,151,239,170,74,99,5,86,60,157,155,248,138,219,158,119,93,126,238,2,115,175,244,0,178,195,179,154,207,59,185,133,214,14,13,13,229,29,65,139,106,115,117,175,167,196,94,106,55,116,96,123,36,95,169,121,177,135,48,113,224,147,7,6,149,227,49,15,190,220,153,229,183,6,245,125,185,193,26,134,212,30,199,14,253,13,88,72,172,177,177,243,93,25,205,40,45,48,36,156,150,64,98,152,166,164,160,81,66,226,56,157,20,89,152,49,154,164,123,119,225,100,104,190,11,121,82,20,19,202,72,24,98,230,174,36,25,41,10,44,73,90,76,161,112,217,135,209,44,219,63,14,198,133,105,37,108,31,78,254,150,109,171,180,237,26,97,183,35,99,161,194,81,173,152,224,2,217,200,170,209,74,171,86,25,144,35,211,21,181,232,163,27,127,198,82,105,214,143,133,255,252,235,169,74,148,32,151,45,106,56,60,28,189,60,215,207,22,194,103,166,149,178,67,18,167,204,207,28,245,150,143,3,230,234,185,189,247,201,223,171,78,151,135,61,51,195,194,191,106,145,255,193,122,254,205,198,93,156,249,107,102,248,255,116,190,209,116,238,131,253,79,133,17,137,63,174,6,0,0 })));
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

		#region Class: ActivityUserTask1FlowElement

		/// <exclude/>
		public class ActivityUserTask1FlowElement : ActivityUserTask
		{

			#region Constructors: Public

			public ActivityUserTask1FlowElement(UserConnection userConnection, Proposal780 process)
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
				_remindBefore = () => (int)(1);
				_account = () => (Guid)(((process.ReadDataUserTask1.ResultEntity.IsColumnValueLoaded(process.ReadDataUserTask1.ResultEntity.Schema.Columns.GetByName("Account").ColumnValueName) ? process.ReadDataUserTask1.ResultEntity.GetTypedColumnValue<Guid>("AccountId") : Guid.Empty)));
				_contact = () => (Guid)(((process.ReadDataUserTask1.ResultEntity.IsColumnValueLoaded(process.ReadDataUserTask1.ResultEntity.Schema.Columns.GetByName("Contact").ColumnValueName) ? process.ReadDataUserTask1.ResultEntity.GetTypedColumnValue<Guid>("ContactId") : Guid.Empty)));
				_opportunity = () => (Guid)(((process.ReadDataUserTask1.ResultEntity.IsColumnValueLoaded(process.ReadDataUserTask1.ResultEntity.Schema.Columns.GetByName("Id").ColumnValueName) ? process.ReadDataUserTask1.ResultEntity.GetTypedColumnValue<Guid>("Id") : Guid.Empty)));
			}

			#endregion

			#region Properties: Public

			private LocalizableString _recommendation;
			public override LocalizableString Recommendation {
				get {
					return _recommendation ?? (_recommendation = GetLocalizableString("b56d5e4f26544089861c73562efe590f",
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

			private int _duration = 30;
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
					return _informationOnStep ?? (_informationOnStep = GetLocalizableString("b56d5e4f26544089861c73562efe590f",
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

			public ActivityUserTask2FlowElement(UserConnection userConnection, Proposal780 process)
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
				_opportunity = () => (Guid)(((process.ReadDataUserTask1.ResultEntity.IsColumnValueLoaded(process.ReadDataUserTask1.ResultEntity.Schema.Columns.GetByName("Id").ColumnValueName) ? process.ReadDataUserTask1.ResultEntity.GetTypedColumnValue<Guid>("Id") : Guid.Empty)));
			}

			#endregion

			#region Properties: Public

			private LocalizableString _recommendation;
			public override LocalizableString Recommendation {
				get {
					return _recommendation ?? (_recommendation = GetLocalizableString("b56d5e4f26544089861c73562efe590f",
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
					return _informationOnStep ?? (_informationOnStep = GetLocalizableString("b56d5e4f26544089861c73562efe590f",
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

			public ChangeDataUserTask1FlowElement(UserConnection userConnection, Proposal780 process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ChangeDataUserTask1";
				IsLogging = true;
				SchemaElementUId = new Guid("69876eb4-65b7-4ef4-8407-c62a197c6584");
				CreatedInSchemaUId = process.InternalSchemaUId;
				_recordColumnValues_Stage = () => (Guid)(new Guid("fb563df2-5ae6-df11-971b-001d60e938c6"));
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
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,237,84,203,110,219,48,16,252,21,67,231,50,160,158,164,124,43,82,183,200,165,9,154,32,151,58,135,21,185,116,136,234,5,138,78,235,26,254,247,46,37,199,73,10,23,113,123,41,80,212,23,73,227,217,217,7,119,184,141,84,13,195,240,17,26,140,230,209,13,58,7,67,103,252,217,123,91,123,116,31,92,183,238,163,55,209,128,206,66,109,191,163,158,240,133,182,254,29,120,160,144,237,242,73,97,25,205,151,199,53,150,209,155,101,100,61,54,3,113,40,164,224,121,145,233,74,49,99,16,88,102,74,195,74,110,18,86,37,185,134,50,147,169,214,217,196,252,149,248,121,215,244,224,112,202,49,202,155,241,245,102,211,7,106,76,128,26,41,118,232,218,61,152,134,34,134,69,11,85,141,154,190,189,91,35,65,222,217,134,186,193,27,219,224,21,56,202,21,116,186,0,17,201,64,61,4,86,141,198,47,190,245,14,135,193,118,237,107,197,213,235,166,125,206,38,1,60,124,238,203,225,99,141,129,121,5,254,126,148,184,160,178,118,99,149,111,87,43,135,43,240,246,225,121,17,95,112,51,242,78,155,31,5,104,58,165,91,168,215,248,44,231,203,78,206,161,247,83,67,83,122,34,56,187,186,63,185,215,195,196,94,107,55,33,176,127,36,159,168,121,180,135,164,32,240,33,0,147,202,227,235,50,250,124,49,92,126,109,209,93,171,123,108,96,154,218,221,25,161,63,1,139,26,27,108,253,124,171,49,139,133,44,114,134,73,146,179,12,179,140,85,92,167,204,36,2,74,174,133,81,74,237,40,224,80,208,124,43,0,12,143,69,69,3,23,20,194,21,178,42,69,197,32,151,49,199,44,145,200,33,132,44,90,111,253,102,218,132,249,22,144,254,203,21,48,149,149,20,101,80,48,72,75,205,82,168,68,34,36,198,69,44,118,119,83,187,118,232,107,216,220,30,186,250,132,160,103,93,223,119,206,175,91,210,156,133,129,144,187,220,224,103,193,83,179,206,204,104,212,235,218,219,118,53,163,141,170,81,133,35,61,219,31,103,120,144,140,84,85,37,13,167,196,34,206,88,166,100,202,74,163,145,229,132,43,25,139,52,70,69,219,23,126,97,73,186,149,85,80,95,246,232,96,191,31,252,184,125,94,248,46,28,141,235,58,63,13,252,112,180,151,79,213,143,37,61,238,49,47,84,92,200,84,50,148,133,96,153,46,20,147,186,224,44,150,60,49,128,177,200,203,224,8,186,130,66,207,215,221,218,169,189,229,135,233,238,249,163,59,229,47,220,20,191,99,254,163,246,59,197,78,255,141,242,111,25,101,23,237,126,0,79,98,87,67,160,7,0,0 })));
				}
				set {
					_dataSourceFilters = value;
				}
			}

			private EntityColumnMappingValues _recordColumnValues;
			public override EntityColumnMappingValues RecordColumnValues {
				get {
					if (_recordColumnValues == null) {
						var zippedData = new byte[] { 31,139,8,0,0,0,0,0,4,0,165,83,65,110,219,48,16,252,74,192,228,232,53,68,81,18,73,95,155,139,1,167,53,234,52,151,56,135,37,185,76,132,202,146,32,81,5,92,195,127,175,172,72,113,28,52,64,129,242,32,130,171,157,217,193,12,121,96,55,97,95,19,91,176,123,106,26,108,43,31,230,95,170,134,230,235,166,178,212,182,243,85,101,177,200,127,163,41,104,141,13,238,40,80,243,128,69,71,237,42,111,195,236,234,18,198,102,236,230,215,240,151,45,30,15,108,25,104,247,99,233,122,118,227,48,227,42,117,224,108,162,32,161,152,131,137,165,3,155,58,169,149,72,165,145,186,7,219,170,232,118,229,29,5,92,99,120,97,139,3,27,216,122,2,169,37,90,145,198,144,104,169,33,113,177,2,29,101,30,84,236,201,100,206,88,237,44,59,206,88,107,95,104,135,195,208,51,24,41,201,188,81,18,108,20,91,72,144,20,160,19,28,80,199,194,58,167,117,98,253,9,60,246,159,129,143,215,171,170,250,217,213,115,107,189,116,138,11,240,86,9,72,36,58,48,148,113,80,94,24,97,180,194,52,241,115,111,210,76,56,31,67,138,148,129,243,156,131,150,220,64,20,113,151,69,164,133,178,217,245,211,105,144,203,219,186,192,253,195,167,243,190,213,117,213,132,174,204,195,254,170,13,248,76,189,189,101,104,208,134,188,124,126,229,168,47,226,120,207,114,216,190,166,186,101,139,237,103,185,142,251,102,176,235,50,217,143,161,110,217,108,203,54,85,215,216,19,163,232,15,183,239,228,15,67,134,150,15,199,41,197,190,82,118,69,49,86,110,49,224,212,56,149,43,151,251,156,220,178,220,76,225,13,44,209,184,224,47,159,105,189,106,251,31,216,29,150,189,189,205,215,222,128,179,246,55,149,247,189,141,19,177,137,117,26,73,238,65,18,246,87,144,178,24,148,227,8,154,107,227,133,20,177,247,241,128,254,78,158,26,42,45,93,10,251,151,59,52,226,219,193,237,211,243,25,117,157,172,58,178,227,241,233,248,7,79,187,236,7,178,3,0,0 };
						string serializedData =
							Encoding.UTF8.GetString(Compressor.UnZip(zippedData));
						LocalizableParameterValuesList dataList =
							LocalizableParameterValuesList.DeserializeData(serializedData);
						dataList.InitializeLocalizableValues(Storage, "b56d5e4f26544089861c73562efe590f",
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

		#region Class: CallUserTask1FlowElement

		/// <exclude/>
		public class CallUserTask1FlowElement : CallUserTask
		{

			#region Constructors: Public

			public CallUserTask1FlowElement(UserConnection userConnection, Proposal780 process)
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
				_opportunity = () => (Guid)(((process.ReadDataUserTask1.ResultEntity.IsColumnValueLoaded(process.ReadDataUserTask1.ResultEntity.Schema.Columns.GetByName("Id").ColumnValueName) ? process.ReadDataUserTask1.ResultEntity.GetTypedColumnValue<Guid>("Id") : Guid.Empty)));
			}

			#endregion

			#region Properties: Public

			private LocalizableString _recommendation;
			public override LocalizableString Recommendation {
				get {
					return _recommendation ?? (_recommendation = GetLocalizableString("b56d5e4f26544089861c73562efe590f",
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
					return _informationOnStep ?? (_informationOnStep = GetLocalizableString("b56d5e4f26544089861c73562efe590f",
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

			public IntermediateCatchSignal1FlowElement(UserConnection userConnection, Proposal780 process)
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
				EntityChangedColumns = @"{""$type"":""System.Collections.ObjectModel.Collection`1[[System.String, mscorlib]], mscorlib"",""$values"":[""797ac352-4979-4d28-906f-82feb6dbc9dc"",""9ecd00e7-8bc5-4f52-b361-477831d42559""]}";
				EntityFilters = @"{""className"":""Terrasoft.FilterGroup"",""serializedFilterEditData"":""{\""className\"":\""Terrasoft.FilterGroup\"",\""items\"":{\""218259d5-ddd6-4ecf-8655-fec1e9aed9cf\"":{\""className\"":\""Terrasoft.InFilter\"",\""filterType\"":4,\""comparisonType\"":4,\""isEnabled\"":true,\""trimDateTimeParameterToDate\"":false,\""leftExpression\"":{\""className\"":\""Terrasoft.ColumnExpression\"",\""expressionType\"":0,\""columnPath\"":\""Stage\""},\""isAggregative\"":false,\""key\"":\""218259d5-ddd6-4ecf-8655-fec1e9aed9cf\"",\""dataValueType\"":10,\""leftExpressionCaption\"":\""Stage\"",\""referenceSchemaName\"":\""OpportunityStage\"",\""rightExpressions\"":[{\""className\"":\""Terrasoft.ParameterExpression\"",\""expressionType\"":2,\""parameter\"":{\""className\"":\""Terrasoft.Parameter\"",\""dataValueType\"":10,\""value\"":{\""Name\"":\""Proposal\"",\""Id\"":\""423774cb-5ae6-df11-971b-001d60e938c6\"",\""value\"":\""423774cb-5ae6-df11-971b-001d60e938c6\"",\""displayValue\"":\""Proposal\""}}}]},\""20698a84-dc06-4fd6-84f7-286e46a1897d\"":{\""className\"":\""Terrasoft.CompareFilter\"",\""filterType\"":1,\""comparisonType\"":3,\""isEnabled\"":true,\""trimDateTimeParameterToDate\"":false,\""leftExpression\"":{\""className\"":\""Terrasoft.ColumnExpression\"",\""expressionType\"":0,\""columnPath\"":\""ByProcess\""},\""isAggregative\"":false,\""key\"":\""20698a84-dc06-4fd6-84f7-286e46a1897d\"",\""dataValueType\"":12,\""leftExpressionCaption\"":\""By process\"",\""rightExpression\"":{\""className\"":\""Terrasoft.ParameterExpression\"",\""expressionType\"":2,\""parameter\"":{\""className\"":\""Terrasoft.Parameter\"",\""dataValueType\"":12,\""value\"":false}}}},\""logicalOperation\"":1,\""isEnabled\"":true,\""filterType\"":6,\""rootSchemaName\"":\""Opportunity\"",\""key\"":\""\""}"",""dataSourceFilters"":""{\""items\"":{\""218259d5-ddd6-4ecf-8655-fec1e9aed9cf\"":{\""filterType\"":4,\""comparisonType\"":4,\""isEnabled\"":true,\""trimDateTimeParameterToDate\"":false,\""leftExpression\"":{\""expressionType\"":0,\""columnPath\"":\""Stage\""},\""rightExpressions\"":[{\""expressionType\"":2,\""parameter\"":{\""dataValueType\"":10,\""value\"":\""423774cb-5ae6-df11-971b-001d60e938c6\""}}]},\""20698a84-dc06-4fd6-84f7-286e46a1897d\"":{\""filterType\"":1,\""comparisonType\"":3,\""isEnabled\"":true,\""trimDateTimeParameterToDate\"":false,\""leftExpression\"":{\""expressionType\"":0,\""columnPath\"":\""ByProcess\""},\""rightExpression\"":{\""expressionType\"":2,\""parameter\"":{\""dataValueType\"":12,\""value\"":false}}}},\""logicalOperation\"":1,\""isEnabled\"":true,\""filterType\"":6,\""rootSchemaName\"":\""Opportunity\""}""}";
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

		public Proposal780(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Proposal780";
			SchemaUId = new Guid("b56d5e4f-2654-4089-861c-73562efe590f");
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
				return new Guid("b56d5e4f-2654-4089-861c-73562efe590f");
			}
		}

		#endregion

		#region Properties: Public

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

		private ChangeDataUserTask1FlowElement _changeDataUserTask1;
		public  ChangeDataUserTask1FlowElement ChangeDataUserTask1 {
			get {
				return _changeDataUserTask1 ?? (_changeDataUserTask1 = new ChangeDataUserTask1FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
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

		private ProcessConditionalFlow _conditionalSequenceFlow1;
		public  ProcessConditionalFlow ConditionalSequenceFlow1 {
			get {
				return _conditionalSequenceFlow1 ?? (_conditionalSequenceFlow1 = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ConditionalSequenceFlow1",
					SchemaElementUId = new Guid("1cf16887-8ea2-4c6a-8c98-d9976bbf059d"),
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

		private ProcessConditionalFlow _conditionalSequenceFlow4;
		public  ProcessConditionalFlow ConditionalSequenceFlow4 {
			get {
				return _conditionalSequenceFlow4 ?? (_conditionalSequenceFlow4 = new ProcessConditionalFlow() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaConditionalFlow",
					Name = "ConditionalSequenceFlow4",
					SchemaElementUId = new Guid("dc702a52-e81c-4155-9222-3d7016c8d781"),
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

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[Terminate1.SchemaElementUId] = new Collection<ProcessFlowElement> { Terminate1 };
			FlowElements[StartSignal1.SchemaElementUId] = new Collection<ProcessFlowElement> { StartSignal1 };
			FlowElements[ReadDataUserTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { ReadDataUserTask1 };
			FlowElements[ActivityUserTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { ActivityUserTask1 };
			FlowElements[ActivityUserTask2.SchemaElementUId] = new Collection<ProcessFlowElement> { ActivityUserTask2 };
			FlowElements[ChangeDataUserTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { ChangeDataUserTask1 };
			FlowElements[CallUserTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { CallUserTask1 };
			FlowElements[ExclusiveGateway1.SchemaElementUId] = new Collection<ProcessFlowElement> { ExclusiveGateway1 };
			FlowElements[IntermediateThrowMessage1.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowMessage1 };
			FlowElements[IntermediateCatchSignal1.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateCatchSignal1 };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "Terminate1":
						CompleteProcess();
						break;
					case "StartSignal1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ReadDataUserTask1", e.Context.SenderName));
						break;
					case "ReadDataUserTask1":
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ActivityUserTask1", e.Context.SenderName));
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ActivityUserTask2", e.Context.SenderName));
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("CallUserTask1", e.Context.SenderName));
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("IntermediateCatchSignal1", e.Context.SenderName));
						break;
					case "ActivityUserTask1":
						if (ActivityUserTask1.ActivityResult == new Guid("dbbf0e10-f46b-1410-6598-00155d043204") || ActivityUserTask1.ActivityResult == new Guid("632afdd2-f616-4ea6-87d2-8ed38eed8aff")) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("IntermediateThrowMessage1", e.Context.SenderName));
							break;
						}
						break;
					case "ActivityUserTask2":
						if (ActivityUserTask2.ActivityResult == new Guid("632afdd2-f616-4ea6-87d2-8ed38eed8aff")) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ChangeDataUserTask1", e.Context.SenderName));
							break;
						}
						break;
					case "ChangeDataUserTask1":
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("Terminate1", e.Context.SenderName));
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
			}
		}

		private void WritePropertyValues(DataWriter writer, bool useAllValueSources) {
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			if (IsProcessExecutedBySignal) {
				return;
			}
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
			MetaPathParameterValues.Add("abbaf017-1209-4a28-be35-0fc755f37d14", () => ActivityUserTask1.Application);
			MetaPathParameterValues.Add("f25d8462-f50a-401f-81af-dafc8dd5ce1c", () => ActivityUserTask1.FinApplication);
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
			MetaPathParameterValues.Add("f2ae123c-e70d-43ee-a290-34a1e2f95fb4", () => ActivityUserTask2.Application);
			MetaPathParameterValues.Add("5dc2e884-b41c-4814-8e51-29ae8f78c96e", () => ActivityUserTask2.FinApplication);
			MetaPathParameterValues.Add("04a1b382-86e4-4cbd-b4b2-9369b8476411", () => ChangeDataUserTask1.EntitySchemaUId);
			MetaPathParameterValues.Add("dccd68d4-6ce0-4cce-8606-16277256e232", () => ChangeDataUserTask1.IsMatchConditions);
			MetaPathParameterValues.Add("44e80631-b3fa-4e14-8afe-1523199a668f", () => ChangeDataUserTask1.DataSourceFilters);
			MetaPathParameterValues.Add("adc8d389-514f-41db-9e8c-6e152eaf84c7", () => ChangeDataUserTask1.RecordColumnValues);
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
		}

		protected override void WritePropertyValues(DataWriter writer) {
			base.WritePropertyValues(writer);
			WritePropertyValues(writer, true);
		}

		#endregion

		#region Methods: Public

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
			var cloneItem = (Proposal780)base.CloneShallow();
			cloneItem.ExecutedEventHandler = ExecutedEventHandler;
			return cloneItem;
		}

		#endregion

	}

	#endregion

}

