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

	#region Class: Contracting780

	/// <exclude/>
	public class Contracting780 : Terrasoft.Core.Process.Process
	{

		#region Class: ProcessLane1

		/// <exclude/>
		public class ProcessLane1 : ProcessLane
		{

			public ProcessLane1(UserConnection userConnection, Contracting780 process)
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

			public ReadDataUserTask1FlowElement(UserConnection userConnection, Contracting780 process)
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
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,237,84,203,142,211,48,20,253,149,42,235,113,149,38,105,28,119,135,74,65,179,161,35,102,52,27,58,11,63,174,83,139,36,142,108,119,160,84,253,119,110,146,182,116,80,209,20,54,176,32,155,36,71,231,30,159,251,242,46,146,21,247,254,3,175,33,154,69,15,224,28,247,86,135,241,59,83,5,112,239,157,221,180,209,77,228,193,25,94,153,111,160,6,124,161,76,120,203,3,199,144,221,234,135,194,42,154,173,46,107,172,162,155,85,100,2,212,30,57,24,194,40,20,92,171,140,80,5,148,100,66,229,164,152,166,140,20,57,99,8,129,162,49,12,204,95,137,207,109,221,114,7,195,25,189,188,238,63,31,182,109,71,157,32,32,123,138,241,182,57,128,105,103,194,47,26,46,42,80,248,31,220,6,16,10,206,212,152,13,60,152,26,238,184,195,179,58,29,219,65,72,210,188,242,29,171,2,29,22,95,91,7,222,27,219,188,102,174,218,212,205,57,27,5,224,244,123,176,19,247,30,59,230,29,15,235,94,226,22,109,237,123,151,111,202,210,65,201,131,121,62,55,241,25,182,61,239,186,250,97,128,194,46,61,242,106,3,103,103,190,204,100,206,219,48,36,52,28,143,4,103,202,245,213,185,158,42,246,90,186,9,130,237,145,124,165,230,197,28,146,28,193,231,14,24,84,142,159,171,232,211,173,95,126,105,192,221,203,53,212,124,168,218,211,24,209,159,128,69,5,53,52,97,182,147,41,139,99,1,9,209,177,228,36,227,83,74,68,156,230,36,203,232,68,20,73,161,226,156,238,49,224,100,104,182,75,116,46,196,36,86,36,73,160,192,144,188,32,66,128,36,84,76,185,72,83,157,164,172,216,63,13,198,141,111,43,190,125,60,249,91,182,173,117,97,211,152,176,29,249,192,75,24,213,86,25,109,64,141,130,29,205,109,19,28,151,193,52,229,248,35,72,235,212,161,31,221,11,163,51,38,181,74,41,35,52,143,51,146,81,26,19,54,81,130,40,149,211,76,10,150,196,140,226,248,116,79,215,101,91,26,201,171,101,11,142,31,26,28,95,158,255,23,139,211,213,214,89,27,134,138,157,122,115,230,188,183,116,28,196,41,80,173,181,144,68,42,6,36,203,115,244,164,147,41,73,36,8,165,166,108,34,114,134,158,240,14,233,186,120,111,55,78,30,118,214,15,151,199,31,93,10,127,97,213,127,103,123,47,238,207,53,251,240,127,210,255,177,73,223,71,251,239,241,46,30,45,34,7,0,0 })));
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
					return _orderInfo ?? (_orderInfo = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,11,201,44,201,73,181,50,176,50,212,241,76,1,82,6,0,151,155,223,183,16,0,0,0 })));
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

			public ActivityUserTask1FlowElement(UserConnection userConnection, Contracting780 process)
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
				_account = () => (Guid)(((process.ReadDataUserTask1.ResultEntity.IsColumnValueLoaded(process.ReadDataUserTask1.ResultEntity.Schema.Columns.GetByName("Account").ColumnValueName) ? process.ReadDataUserTask1.ResultEntity.GetTypedColumnValue<Guid>("AccountId") : Guid.Empty)));
				_contact = () => (Guid)(((process.ReadDataUserTask1.ResultEntity.IsColumnValueLoaded(process.ReadDataUserTask1.ResultEntity.Schema.Columns.GetByName("Contact").ColumnValueName) ? process.ReadDataUserTask1.ResultEntity.GetTypedColumnValue<Guid>("ContactId") : Guid.Empty)));
				_opportunity = () => (Guid)(((process.ReadDataUserTask1.ResultEntity.IsColumnValueLoaded(process.ReadDataUserTask1.ResultEntity.Schema.Columns.GetByName("Id").ColumnValueName) ? process.ReadDataUserTask1.ResultEntity.GetTypedColumnValue<Guid>("Id") : Guid.Empty)));
			}

			#endregion

			#region Properties: Public

			private LocalizableString _recommendation;
			public override LocalizableString Recommendation {
				get {
					return _recommendation ?? (_recommendation = GetLocalizableString("3809be02394943de96d58a2ce750e791",
						 "BaseElements.ActivityUserTask1.Parameters.Recommendation.Value"));
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
					return _informationOnStep ?? (_informationOnStep = GetLocalizableString("3809be02394943de96d58a2ce750e791",
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

			public ActivityUserTask2FlowElement(UserConnection userConnection, Contracting780 process)
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
					return _recommendation ?? (_recommendation = GetLocalizableString("3809be02394943de96d58a2ce750e791",
						 "BaseElements.ActivityUserTask2.Parameters.Recommendation.Value"));
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
					return _informationOnStep ?? (_informationOnStep = GetLocalizableString("3809be02394943de96d58a2ce750e791",
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

			public ChangeDataUserTask1FlowElement(UserConnection userConnection, Contracting780 process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ChangeDataUserTask1";
				IsLogging = true;
				SchemaElementUId = new Guid("69876eb4-65b7-4ef4-8407-c62a197c6584");
				CreatedInSchemaUId = process.InternalSchemaUId;
				_recordColumnValues_Stage = () => (Guid)(new Guid("60d5310c-5be6-df11-971b-001d60e938c6"));
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
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,237,84,203,110,219,48,16,252,21,67,231,50,16,245,162,228,91,145,186,69,46,77,208,4,185,212,57,172,200,165,67,84,47,144,116,90,215,240,191,119,41,57,78,82,184,136,219,75,129,162,190,72,90,207,14,103,31,195,109,36,27,112,238,35,180,24,205,163,27,180,22,92,175,253,217,123,211,120,180,31,108,191,30,162,55,145,67,107,160,49,223,81,77,241,133,50,254,29,120,160,148,237,242,137,97,25,205,151,199,57,150,209,155,101,100,60,182,142,48,148,194,117,10,101,46,106,86,38,105,197,50,173,115,6,42,214,172,192,92,231,69,165,120,157,86,19,242,87,228,231,125,59,128,197,233,140,145,94,143,175,55,155,33,64,57,5,228,8,49,174,239,246,193,52,136,112,139,14,234,6,21,125,123,187,70,10,121,107,90,170,6,111,76,139,87,96,233,172,192,211,135,16,129,52,52,46,160,26,212,126,241,109,176,232,156,233,187,215,196,53,235,182,123,142,38,2,60,124,238,229,196,163,198,128,188,2,127,63,82,92,144,172,221,168,242,237,106,101,113,5,222,60,60,23,241,5,55,35,238,180,254,81,130,162,41,221,66,179,198,103,103,190,172,228,28,6,63,21,52,29,79,0,107,86,247,39,215,122,232,216,107,229,38,20,28,30,193,39,114,30,173,33,41,40,248,16,2,19,203,227,235,50,250,124,225,46,191,118,104,175,229,61,182,48,117,237,238,140,162,63,5,22,13,182,216,249,249,86,97,198,69,89,228,12,147,36,103,25,102,25,171,99,149,50,157,8,168,98,37,180,148,114,71,9,7,65,243,173,0,208,49,167,214,87,177,160,148,88,34,171,83,148,12,242,146,199,152,37,37,198,16,82,22,157,55,126,51,109,194,124,11,72,255,229,18,152,204,42,202,210,40,24,164,149,98,41,212,34,17,37,242,130,139,221,221,84,174,113,67,3,155,219,67,85,159,16,212,172,31,134,222,250,117,71,156,179,208,16,114,151,117,126,22,60,53,235,245,140,90,189,110,188,233,86,51,218,168,6,101,24,233,217,126,156,225,65,52,117,142,156,99,86,49,165,1,88,86,86,192,160,140,83,150,231,26,84,166,180,40,138,154,182,47,252,194,146,244,43,35,161,185,28,208,194,126,63,226,227,246,121,225,187,48,26,219,247,126,106,248,97,180,151,79,234,71,73,143,123,156,65,158,66,5,212,240,148,23,44,43,168,65,192,145,51,17,115,41,4,8,172,202,132,52,209,21,20,106,190,238,215,86,238,45,239,166,187,231,143,238,148,191,112,83,252,142,249,143,218,239,20,59,253,55,202,191,101,148,93,180,251,1,217,255,111,125,160,7,0,0 })));
				}
				set {
					_dataSourceFilters = value;
				}
			}

			private EntityColumnMappingValues _recordColumnValues;
			public override EntityColumnMappingValues RecordColumnValues {
				get {
					if (_recordColumnValues == null) {
						var zippedData = new byte[] { 31,139,8,0,0,0,0,0,4,0,165,83,209,110,155,48,20,253,149,200,237,99,140,48,38,54,206,107,251,18,41,221,162,165,235,75,233,195,197,190,94,209,8,70,96,54,101,81,254,125,14,129,165,169,86,105,210,252,0,242,181,207,185,135,115,46,7,114,235,247,13,146,37,121,196,182,133,206,89,31,221,185,22,163,77,235,52,118,93,180,118,26,170,242,23,20,21,110,160,133,29,122,108,159,160,234,177,91,151,157,159,207,174,97,100,78,110,127,12,167,100,249,124,32,43,143,187,175,43,19,216,83,35,98,41,56,82,198,210,152,166,86,38,52,75,50,160,134,9,174,11,9,137,200,210,0,214,174,234,119,245,3,122,216,128,127,37,203,3,25,216,2,129,84,18,52,95,36,52,85,82,209,212,36,25,85,177,176,129,197,98,33,76,161,149,209,228,56,39,157,126,197,29,12,77,47,96,192,84,216,34,147,84,199,137,166,41,96,70,193,112,70,65,37,92,27,163,84,170,237,9,60,222,191,0,159,111,214,206,125,239,155,72,107,43,77,198,56,181,58,227,52,149,96,104,129,130,209,204,242,130,23,42,131,69,106,35,17,155,5,103,177,166,139,112,70,141,101,140,42,201,10,26,199,44,124,62,42,158,105,113,243,114,106,100,202,174,169,96,255,244,97,191,207,77,227,90,223,215,165,223,207,58,15,223,48,186,171,92,135,102,246,211,213,103,138,230,42,141,183,36,135,252,28,106,78,150,249,71,177,142,239,237,224,214,117,176,239,51,205,201,60,39,91,215,183,250,196,200,195,230,254,141,250,161,201,112,229,221,118,10,49,84,234,190,170,198,202,61,120,152,46,78,101,103,74,91,162,89,213,219,41,187,129,37,30,23,253,203,99,90,103,109,255,3,123,128,58,184,219,126,10,6,92,180,255,81,249,24,108,156,136,139,68,45,98,201,44,149,8,97,2,81,132,17,54,12,168,98,170,176,92,242,196,218,100,64,127,65,139,45,214,26,175,133,253,203,8,141,248,110,112,251,244,247,140,186,78,86,29,201,241,248,114,252,13,149,27,9,55,177,3,0,0 };
						string serializedData =
							Encoding.UTF8.GetString(Compressor.UnZip(zippedData));
						LocalizableParameterValuesList dataList =
							LocalizableParameterValuesList.DeserializeData(serializedData);
						dataList.InitializeLocalizableValues(Storage, "3809be02394943de96d58a2ce750e791",
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

			public CallUserTask1FlowElement(UserConnection userConnection, Contracting780 process)
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
					return _recommendation ?? (_recommendation = GetLocalizableString("3809be02394943de96d58a2ce750e791",
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
					return _informationOnStep ?? (_informationOnStep = GetLocalizableString("3809be02394943de96d58a2ce750e791",
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

			public IntermediateCatchSignal1FlowElement(UserConnection userConnection, Contracting780 process)
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
				EntityFilters = @"{""className"":""Terrasoft.FilterGroup"",""serializedFilterEditData"":""{\""className\"":\""Terrasoft.FilterGroup\"",\""items\"":{\""afd9fc8b-a605-4b35-ac84-9ef02d6be94a\"":{\""className\"":\""Terrasoft.InFilter\"",\""filterType\"":4,\""comparisonType\"":4,\""isEnabled\"":true,\""trimDateTimeParameterToDate\"":false,\""leftExpression\"":{\""className\"":\""Terrasoft.ColumnExpression\"",\""expressionType\"":0,\""columnPath\"":\""Stage\""},\""isAggregative\"":false,\""key\"":\""afd9fc8b-a605-4b35-ac84-9ef02d6be94a\"",\""dataValueType\"":10,\""leftExpressionCaption\"":\""Stage\"",\""referenceSchemaName\"":\""OpportunityStage\"",\""rightExpressions\"":[{\""className\"":\""Terrasoft.ParameterExpression\"",\""expressionType\"":2,\""parameter\"":{\""className\"":\""Terrasoft.Parameter\"",\""dataValueType\"":10,\""value\"":{\""Id\"":\""fb563df2-5ae6-df11-971b-001d60e938c6\"",\""Name\"":\""Contracting\"",\""value\"":\""fb563df2-5ae6-df11-971b-001d60e938c6\"",\""displayValue\"":\""Contracting\""}}}]}},\""logicalOperation\"":0,\""isEnabled\"":true,\""filterType\"":6,\""rootSchemaName\"":\""Opportunity\"",\""key\"":\""25567ec2-267e-4309-bf46-820cb71d00f5\""}"",""dataSourceFilters"":""{\""items\"":{\""afd9fc8b-a605-4b35-ac84-9ef02d6be94a\"":{\""filterType\"":4,\""comparisonType\"":4,\""isEnabled\"":true,\""trimDateTimeParameterToDate\"":false,\""leftExpression\"":{\""expressionType\"":0,\""columnPath\"":\""Stage\""},\""rightExpressions\"":[{\""expressionType\"":2,\""parameter\"":{\""dataValueType\"":10,\""value\"":\""fb563df2-5ae6-df11-971b-001d60e938c6\""}}]}},\""logicalOperation\"":0,\""isEnabled\"":true,\""filterType\"":6,\""rootSchemaName\"":\""Opportunity\""}""}";
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

		public Contracting780(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Contracting780";
			SchemaUId = new Guid("3809be02-3949-43de-96d5-8a2ce750e791");
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
				return new Guid("3809be02-3949-43de-96d5-8a2ce750e791");
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

		private IntermediateCatchSignal1FlowElement _intermediateCatchSignal1;
		public  IntermediateCatchSignal1FlowElement IntermediateCatchSignal1 {
			get {
				return _intermediateCatchSignal1 ?? ((_intermediateCatchSignal1) = new IntermediateCatchSignal1FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
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
					SchemaElementUId = new Guid("699d4b79-5993-4d12-89b6-3adeb1d71948"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
						Message = "CallToCustomerCompleted",
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
					SchemaElementUId = new Guid("dcd0a9a0-afe3-45c3-a614-08f6fcbc6219"),
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
					SchemaElementUId = new Guid("414063d8-ce60-4f29-8d80-2347338d44e4"),
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
			FlowElements[IntermediateCatchSignal1.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateCatchSignal1 };
			FlowElements[IntermediateThrowMessage1.SchemaElementUId] = new Collection<ProcessFlowElement> { IntermediateThrowMessage1 };
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
					case "IntermediateCatchSignal1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("Terminate1", e.Context.SenderName));
						break;
					case "IntermediateThrowMessage1":
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
			MetaPathParameterValues.Add("96a8bffc-a804-4d41-a723-6575b2e2f84b", () => ActivityUserTask1.Application);
			MetaPathParameterValues.Add("1e77b3f7-c5e0-44b2-aac7-3c55fc5c6419", () => ActivityUserTask1.FinApplication);
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
			MetaPathParameterValues.Add("af4a5a14-3f52-4315-913b-4cae179c9f59", () => ActivityUserTask2.Application);
			MetaPathParameterValues.Add("e8a98399-42c1-42f1-927c-42666f810ed8", () => ActivityUserTask2.FinApplication);
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
			var cloneItem = (Contracting780)base.CloneShallow();
			cloneItem.ExecutedEventHandler = ExecutedEventHandler;
			return cloneItem;
		}

		#endregion

	}

	#endregion

}

