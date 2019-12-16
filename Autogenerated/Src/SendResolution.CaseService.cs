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

	#region Class: SendResolution

	/// <exclude/>
	public class SendResolution : Terrasoft.Core.Process.Process
	{

		#region Class: ProcessLane1

		/// <exclude/>
		public class ProcessLane1 : ProcessLane
		{

			public ProcessLane1(UserConnection userConnection, SendResolution process)
				: base(userConnection) {
				Owner = process;
				IsUsedParentUserContexts = false;
			}

		}

		#endregion

		#region Class: ReadDataUserTask2FlowElement

		/// <exclude/>
		public class ReadDataUserTask2FlowElement : ReadDataUserTask
		{

			#region Constructors: Public

			public ReadDataUserTask2FlowElement(UserConnection userConnection, SendResolution process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ReadDataUserTask2";
				IsLogging = true;
				SchemaElementUId = new Guid("6503c95a-e7ae-4569-827f-6a9bbe826a81");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
			}

			#endregion

			#region Properties: Public

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,213,83,77,107,220,48,16,253,43,69,135,158,172,197,99,203,31,114,143,203,182,236,37,13,221,180,4,146,16,198,154,81,34,240,199,198,150,105,130,217,255,94,237,58,219,66,14,37,135,94,10,58,72,35,189,55,239,61,70,243,189,27,63,187,198,243,80,89,108,70,142,166,45,85,34,195,18,72,3,74,4,74,164,2,74,101,93,212,32,107,197,138,108,81,144,49,137,136,58,108,185,18,11,122,67,206,139,200,121,110,199,234,102,254,67,234,135,137,163,123,123,58,236,204,35,183,248,253,216,0,160,160,52,177,90,150,73,145,73,149,165,74,150,10,64,130,201,115,128,204,176,54,36,22,45,4,204,148,233,68,2,104,45,21,35,72,157,216,88,18,26,149,33,228,218,146,17,81,195,214,111,158,247,3,143,163,235,187,106,230,223,251,171,151,125,80,185,244,94,247,205,212,118,34,106,217,227,37,250,199,74,32,199,172,50,131,210,40,29,132,88,46,36,166,154,100,138,117,145,20,37,67,14,133,136,12,238,253,145,86,108,131,42,66,143,63,176,153,248,196,60,187,160,49,73,99,40,179,60,96,33,53,82,165,73,44,203,188,44,164,165,220,106,78,115,173,107,58,231,245,101,114,97,239,198,139,169,229,193,153,215,216,57,228,215,15,213,108,250,206,15,125,115,164,190,56,61,191,226,103,191,132,251,122,117,189,24,242,161,126,4,137,67,52,141,188,110,28,119,126,211,153,158,92,247,176,112,30,14,1,210,238,113,112,227,57,133,205,211,132,141,136,6,247,240,248,215,180,214,211,232,251,246,63,178,26,5,155,129,35,12,217,73,238,113,6,201,141,251,6,95,78,231,74,124,124,154,122,255,105,231,113,240,59,247,208,97,3,171,111,108,250,129,62,108,105,185,19,111,56,42,113,43,226,196,90,195,132,18,74,93,75,165,178,96,86,103,32,153,168,128,50,38,3,218,174,82,50,185,49,49,75,195,117,24,33,226,240,79,210,48,218,24,199,64,5,166,89,174,234,91,17,196,255,19,73,55,219,241,235,207,238,252,153,22,251,119,171,80,125,83,216,52,220,134,156,170,249,61,30,14,1,112,121,110,85,205,239,113,116,184,59,122,186,59,132,245,11,37,121,167,175,68,4,0,0 })));
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

			private bool _readSomeTopRecords = false;
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
					return _orderInfo ?? (_orderInfo = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,243,76,177,50,176,50,208,241,43,205,77,74,45,178,50,180,50,4,0,178,212,123,197,17,0,0,0 })));
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
								new Guid("117d32f9-8275-4534-8411-1c66115ce9cd")),
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
						_resultEntityCollection = new EntityCollection(UserConnection, new Guid("117d32f9-8275-4534-8411-1c66115ce9cd"));
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

		#region Class: ReadDataUserTask1FlowElement

		/// <exclude/>
		public class ReadDataUserTask1FlowElement : ReadDataUserTask
		{

			#region Constructors: Public

			public ReadDataUserTask1FlowElement(UserConnection userConnection, SendResolution process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "ReadDataUserTask1";
				IsLogging = true;
				SchemaElementUId = new Guid("b353e4ff-8ce6-4c2a-8277-0ae2d39af093");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
			}

			#endregion

			#region Properties: Public

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,213,83,77,107,220,48,16,253,43,197,135,158,60,65,178,37,203,118,143,203,22,2,37,13,77,91,10,33,132,145,52,202,138,250,99,99,203,180,193,248,191,87,187,222,109,67,14,37,135,94,10,62,88,26,191,247,230,189,25,207,247,126,124,239,155,64,67,237,176,25,41,157,46,109,157,24,33,165,206,185,6,195,42,9,2,179,2,202,66,149,192,28,102,74,23,2,177,52,73,218,97,75,117,178,162,183,214,135,36,245,129,218,177,190,157,255,144,134,97,162,244,222,29,15,55,102,71,45,126,57,8,112,35,37,58,35,161,176,104,65,20,86,131,214,34,7,86,40,169,168,204,133,37,74,214,94,172,201,148,80,10,33,39,169,64,84,60,7,237,72,128,201,144,97,174,69,41,48,126,218,144,11,219,159,251,129,198,209,247,93,61,211,239,247,207,79,251,216,229,170,189,233,155,169,237,146,180,165,128,215,24,118,145,157,113,37,25,183,96,172,113,145,93,59,40,115,165,193,74,174,141,85,220,33,99,73,106,112,31,14,180,201,6,199,40,54,144,163,129,58,67,207,29,113,101,243,204,85,80,102,42,70,38,115,1,165,224,28,184,41,10,206,165,161,202,216,36,181,24,240,43,54,19,29,187,154,125,4,234,172,146,44,10,129,34,172,64,80,145,65,105,57,66,197,99,51,185,138,156,46,59,103,253,161,239,191,79,251,152,243,120,53,181,52,120,115,26,26,197,244,251,161,158,77,223,133,161,111,14,228,87,207,0,235,112,78,197,111,107,32,205,177,114,0,38,75,58,141,180,105,60,117,97,219,153,222,250,238,225,56,183,101,137,152,118,143,131,31,207,49,110,31,39,108,98,0,254,97,247,215,184,55,211,24,250,246,127,243,155,70,175,145,38,174,234,177,231,195,38,91,63,238,27,124,58,158,235,228,237,227,212,135,119,55,1,135,112,227,31,58,108,248,197,39,50,253,96,223,92,218,181,150,188,224,56,99,88,180,101,200,34,240,178,210,32,132,100,80,86,146,3,217,184,100,37,179,134,87,238,34,183,166,48,134,17,24,210,113,135,44,113,208,121,92,169,184,131,220,42,204,101,33,244,73,102,73,255,89,107,183,151,227,199,31,221,249,247,92,19,190,187,136,183,47,46,182,13,181,49,178,122,126,141,151,37,2,174,207,114,245,252,26,103,203,221,217,219,221,18,159,95,143,57,51,37,154,4,0,0 })));
				}
				set {
					_dataSourceFilters = value;
				}
			}

			private int _resultType = 1;
			public override int ResultType {
				get {
					return _resultType;
				}
				set {
					_resultType = value;
				}
			}

			private bool _readSomeTopRecords = false;
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

			private string _aggregationColumnName;
			public override string AggregationColumnName {
				get {
					return _aggregationColumnName ?? (_aggregationColumnName = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,243,76,1,0,242,67,189,42,2,0,0,0 })));
				}
				set {
					_aggregationColumnName = value;
				}
			}

			private string _orderInfo;
			public override string OrderInfo {
				get {
					return _orderInfo ?? (_orderInfo = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,243,206,203,47,207,73,77,73,79,117,74,44,78,181,50,180,50,212,241,76,177,50,176,50,0,0,77,236,146,224,24,0,0,0 })));
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
								new Guid("1c55afc5-6dad-46db-bb43-06757e834dee")),
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
						_resultEntityCollection = new EntityCollection(UserConnection, new Guid("1c55afc5-6dad-46db-bb43-06757e834dee"));
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

		#region Class: UserQuestionUserTask1FlowElement

		/// <exclude/>
		public class UserQuestionUserTask1FlowElement : UserQuestionUserTask
		{

			#region Constructors: Public

			public UserQuestionUserTask1FlowElement(UserConnection userConnection, SendResolution process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "UserQuestionUserTask1";
				IsLogging = true;
				SchemaElementUId = new Guid("e0631f09-5515-4867-8c42-2410057f9ef6");
				CreatedInSchemaUId = process.InternalSchemaUId;
				ProcessLane = process.Lane1;
				SerializeToDB = true;
				_recommendation = () => new LocalizableString("Create a knowledge base article based on case " + ((process.ReadDataUserTask2.ResultEntity.IsColumnValueLoaded(process.ReadDataUserTask2.ResultEntity.Schema.Columns.GetByName("Number").ColumnValueName) ? process.ReadDataUserTask2.ResultEntity.GetTypedColumnValue<string>("Number") : null)));
			}

			#endregion

			#region Properties: Public

			private LocalizableString _branchingDecisions;
			public override LocalizableString BranchingDecisions {
				get {
					if (_branchingDecisions == null) {
						var zippedData = new byte[] { 31,139,8,0,0,0,0,0,4,0,157,143,61,107,195,48,16,134,255,74,17,25,45,163,111,201,89,19,10,129,80,50,164,89,74,7,73,62,81,83,167,14,146,82,104,140,255,123,229,116,73,40,116,232,118,186,231,222,211,61,35,90,228,175,19,160,37,218,67,140,54,13,33,215,171,33,66,189,139,131,135,148,234,237,224,109,223,93,172,235,97,103,163,61,66,134,120,176,253,25,210,182,75,185,122,184,143,161,10,45,62,175,20,45,95,70,180,201,112,124,222,180,101,187,2,171,141,19,128,3,163,128,69,128,22,91,78,12,118,94,5,33,149,33,134,169,18,158,103,71,116,221,80,66,148,183,28,84,75,177,118,74,98,33,153,195,141,214,45,230,188,52,41,87,129,151,208,84,161,167,114,214,109,110,13,190,75,221,240,65,102,184,178,167,92,234,153,119,105,235,47,135,159,161,28,207,80,232,26,194,234,13,252,59,220,125,188,47,16,77,83,117,107,160,129,105,201,52,197,70,53,229,24,67,40,118,164,97,56,24,201,140,119,140,24,241,219,64,208,86,58,233,2,86,204,241,162,45,37,54,94,187,242,228,138,27,2,50,24,241,151,1,253,175,193,163,237,211,172,240,58,125,3,1,244,216,118,226,1,0,0 };
						string serializedData =
							Encoding.UTF8.GetString(Compressor.UnZip(zippedData));
						LocalizableParameterValuesList dataList =
							LocalizableParameterValuesList.DeserializeData(serializedData);
						dataList.InitializeLocalizableValues(Storage, "0a135608617642f7b44e1d26f4c07253",
							"BaseElements.UserQuestionUserTask1.Parameters.BranchingDecisions.Value");
						dataList.LoadLocalizableValues();
						_branchingDecisions = dataList.GetSerializedItems();
						};
					return _branchingDecisions;
				}
				set {
					_branchingDecisions = value;
				}
			}

			private int _decisionMode = 0;
			public override int DecisionMode {
				get {
					return _decisionMode;
				}
				set {
					_decisionMode = value;
				}
			}

			private bool _isDecisionRequired = true;
			public override bool IsDecisionRequired {
				get {
					return _isDecisionRequired;
				}
				set {
					_isDecisionRequired = value;
				}
			}

			private LocalizableString _question;
			public override LocalizableString Question {
				get {
					return _question ?? (_question = GetLocalizableString("0a135608617642f7b44e1d26f4c07253",
						 "BaseElements.UserQuestionUserTask1.Parameters.Question.Value"));
				}
				set {
					_question = value;
				}
			}

			private LocalizableString _windowCaption;
			public override LocalizableString WindowCaption {
				get {
					return _windowCaption ?? (_windowCaption = GetLocalizableString("0a135608617642f7b44e1d26f4c07253",
						 "BaseElements.UserQuestionUserTask1.Parameters.WindowCaption.Value"));
				}
				set {
					_windowCaption = value;
				}
			}

			internal Func<LocalizableString> _recommendation;
			public override LocalizableString Recommendation {
				get {
					return (_recommendation ?? (_recommendation = () => null)).Invoke();
				}
				set {
					_recommendation = () => { return value; };
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

			#endregion

			#region Methods: Public

			public override string GetResultAllowedValues() {
				return "[\"41d5b5bf-62b3-4f55-8c7b-6236380e5f84\",\"13d3e6d1-7b65-452b-977d-336d1136f326\"]";
			}

			#endregion

		}

		#endregion

		#region Class: OpenEditPageUserTask1FlowElement

		/// <exclude/>
		public class OpenEditPageUserTask1FlowElement : OpenEditPageUserTask
		{

			#region Constructors: Public

			public OpenEditPageUserTask1FlowElement(UserConnection userConnection, SendResolution process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "OpenEditPageUserTask1";
				IsLogging = true;
				SchemaElementUId = new Guid("c1d98a52-3627-4c08-a5cd-71ab92bf22fb");
				CreatedInSchemaUId = process.InternalSchemaUId;
				ProcessLane = process.Lane1;
				SerializeToDB = true;
			}

			#endregion

			#region Properties: Public

			private Guid _objectSchemaId = new Guid("0326868c-ce5e-4934-8f1f-178801bfe6c3");
			public override Guid ObjectSchemaId {
				get {
					return _objectSchemaId;
				}
				set {
					_objectSchemaId = value;
				}
			}

			private Guid _pageSchemaId = new Guid("9dbd0611-fa52-4a90-9542-e5fd997b4afd");
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

			private bool _isMatchConditions = true;
			public override bool IsMatchConditions {
				get {
					return _isMatchConditions;
				}
				set {
					_isMatchConditions = value;
				}
			}

			private string _dataSourceFilters;
			public override string DataSourceFilters {
				get {
					return _dataSourceFilters ?? (_dataSourceFilters = Encoding.UTF8.GetString(Compressor.UnZip(new byte[] { 31,139,8,0,0,0,0,0,4,0,69,144,201,106,197,32,20,134,223,197,181,130,38,106,76,182,229,22,186,104,40,116,160,80,74,113,56,182,130,73,46,209,64,75,200,187,215,228,118,216,169,199,127,56,223,250,22,210,117,136,25,230,206,235,152,0,47,55,174,67,74,88,85,215,194,144,74,25,73,184,172,12,105,43,207,136,48,190,169,152,213,220,210,26,225,81,15,208,161,139,250,228,66,70,56,100,24,82,247,178,254,155,230,121,1,252,230,143,203,189,253,128,65,63,238,1,180,174,164,146,202,18,11,2,8,111,107,78,148,103,158,176,70,41,202,140,7,105,75,192,209,165,228,53,158,113,70,172,163,148,112,103,60,209,13,83,229,43,107,139,154,138,86,58,132,35,248,124,250,60,207,144,82,152,198,110,133,191,243,195,215,185,180,188,100,95,77,113,25,70,132,7,200,250,78,231,143,14,73,193,157,170,181,32,85,173,139,187,16,130,40,202,21,1,176,141,180,222,42,207,13,194,86,159,243,110,139,250,178,50,194,78,103,253,164,227,2,135,247,26,74,75,231,76,173,25,0,161,13,168,210,82,86,196,52,186,37,142,130,100,202,80,234,141,251,37,118,11,46,44,195,3,124,238,196,82,191,12,48,7,251,131,191,140,242,52,119,171,157,198,60,79,113,15,232,15,209,254,253,2,249,103,244,124,89,44,151,247,93,132,54,188,36,184,138,1,198,124,26,237,228,194,248,126,208,223,182,162,24,206,122,14,233,23,198,77,234,167,220,47,49,162,237,117,251,6,195,19,72,255,2,2,0,0 })));
				}
				set {
					_dataSourceFilters = value;
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
					return _recommendation ?? (_recommendation = GetLocalizableString("0a135608617642f7b44e1d26f4c07253",
						 "BaseElements.OpenEditPageUserTask1.Parameters.Recommendation.Value"));
				}
				set {
					_recommendation = value;
				}
			}

			#endregion

		}

		#endregion

		#region Class: AddDataUserTask1FlowElement

		/// <exclude/>
		public class AddDataUserTask1FlowElement : AddDataUserTask
		{

			#region Constructors: Public

			public AddDataUserTask1FlowElement(UserConnection userConnection, SendResolution process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "AddDataUserTask1";
				IsLogging = true;
				SchemaElementUId = new Guid("a38fb2c3-852b-493e-8759-b76d112d94db");
				CreatedInSchemaUId = process.InternalSchemaUId;
				SerializeToDB = true;
				_recordDefValues_KnowledgeBase = () => (Guid)((process.OpenEditPageUserTask1.RecordId));
				_recordDefValues_Case = () => (Guid)((process.StartSignal1.RecordId));
			}

			private Dictionary<string, Func<object>> _getColumnValueFunctions;
			private  Dictionary<string, Func<object>> GetColumnValueFunctions {
				get {
					if (_getColumnValueFunctions == null) {
						_getColumnValueFunctions = new Dictionary<string, Func<object>>();
						_getColumnValueFunctions.Add("_recordDefValues_KnowledgeBase", () => _recordDefValues_KnowledgeBase.Invoke());
						_getColumnValueFunctions.Add("_recordDefValues_Case", () => _recordDefValues_Case.Invoke());
					}
					return _getColumnValueFunctions;
				}
			}

			#endregion

			#region Fields: Internal

			internal Func<Guid> _recordDefValues_KnowledgeBase;
			internal Func<Guid> _recordDefValues_Case;

			#endregion

			#region Properties: Public

			private Guid _entitySchemaId = new Guid("1c55afc5-6dad-46db-bb43-06757e834dee");
			public override Guid EntitySchemaId {
				get {
					return _entitySchemaId;
				}
				set {
					_entitySchemaId = value;
				}
			}

			private EntityColumnMappingValues _recordDefValues;
			public override EntityColumnMappingValues RecordDefValues {
				get {
					if (_recordDefValues == null) {
						var zippedData = new byte[] { 31,139,8,0,0,0,0,0,4,0,237,84,201,110,219,48,16,253,21,67,205,209,99,112,95,124,109,122,48,208,37,104,218,92,226,28,72,206,48,53,42,75,134,164,52,72,13,255,123,105,197,105,150,110,104,79,57,84,7,9,34,249,222,188,89,30,183,213,209,112,179,161,106,94,125,160,174,11,125,155,135,217,203,182,163,217,73,215,38,234,251,217,235,54,133,122,245,53,196,154,78,66,23,214,52,80,119,22,234,43,234,95,175,250,97,58,121,12,171,166,213,209,151,113,183,154,159,111,171,197,64,235,143,11,44,236,76,89,105,184,145,224,60,6,80,152,5,68,195,56,100,203,53,41,38,69,16,172,128,83,91,95,173,155,55,52,132,147,48,124,170,230,219,106,100,43,4,154,199,64,218,59,112,146,89,80,153,103,136,138,60,48,35,180,35,210,154,113,81,237,166,85,159,62,209,58,140,65,239,193,60,105,29,114,210,96,48,32,40,131,17,98,84,178,128,173,182,228,164,66,162,61,248,112,254,30,120,254,226,124,209,191,187,110,168,59,29,121,231,57,212,61,93,204,202,234,147,133,87,53,173,169,25,230,219,196,209,187,160,5,72,35,138,208,196,28,4,157,16,44,15,209,139,152,133,200,113,87,0,223,171,57,223,102,167,109,204,136,96,184,87,160,52,49,8,81,103,200,132,209,106,225,2,25,190,187,120,113,177,151,136,171,126,83,135,155,179,31,149,190,219,80,51,249,220,180,215,53,225,37,77,98,232,105,66,184,26,38,155,112,73,179,247,148,218,14,39,11,188,165,217,60,234,229,67,162,237,242,118,36,150,213,124,249,171,161,56,124,111,75,240,120,44,158,78,196,178,154,46,171,211,246,170,75,123,70,185,255,185,235,208,24,129,29,30,248,201,235,238,185,229,24,97,111,66,83,178,233,222,150,136,35,124,220,58,14,67,24,131,127,40,186,239,136,163,240,154,217,50,38,150,130,7,69,70,128,67,30,192,115,31,179,180,82,228,44,70,244,123,202,212,81,147,232,137,48,41,140,51,46,65,34,77,160,188,84,224,246,83,199,173,115,140,199,76,38,201,17,63,70,190,23,115,55,188,101,165,185,170,235,49,64,63,230,191,119,195,65,248,97,231,248,65,51,31,48,180,184,202,43,194,69,243,47,165,218,85,187,221,244,161,245,40,162,23,14,9,184,227,17,84,73,30,66,74,18,140,64,165,74,142,42,71,243,91,235,33,227,182,216,11,33,97,202,165,18,49,23,19,218,8,88,60,153,176,148,56,48,246,44,172,199,74,79,19,149,251,133,59,95,50,85,154,149,235,70,115,32,44,42,29,195,196,125,126,98,61,137,201,164,196,168,116,57,234,114,47,17,135,40,179,135,146,18,71,27,164,54,42,254,217,122,167,67,232,134,211,213,101,19,106,254,223,105,127,235,52,206,45,150,67,30,156,176,165,7,122,239,52,197,57,240,100,12,231,58,145,79,248,92,157,118,177,251,6,206,238,79,177,66,7,0,0 };
						string serializedData =
							Encoding.UTF8.GetString(Compressor.UnZip(zippedData));
						LocalizableParameterValuesList dataList =
							LocalizableParameterValuesList.DeserializeData(serializedData);
						dataList.InitializeLocalizableValues(Storage, "0a135608617642f7b44e1d26f4c07253",
							"BaseElements.AddDataUserTask1.Parameters.RecordDefValues.Value");
						dataList.LoadLocalizableValues();
						var packageUId = new Guid("1f513d05-8e3f-4989-92ce-3af40e5127d6");
						Func<string, object> getColumnValue = delegate(string memberName) {
							Func<object> getValueFunc = GetColumnValueFunctions[memberName];
							getValueFunc.CheckArgumentNull(memberName);
							return getValueFunc.Invoke();
						};
						_recordDefValues = new EntityColumnMappingValues(UserConnection, packageUId,
							(EntityColumnMappingCollection)dataList, "RecordDefValues", getColumnValue);
					}
					return _recordDefValues;
				}
				set {
					_recordDefValues = value;
				}
			}

			#endregion

		}

		#endregion

		public SendResolution(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SendResolution";
			SchemaUId = new Guid("0a135608-6176-42f7-b44e-1d26f4c07253");
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
				return new Guid("0a135608-6176-42f7-b44e-1d26f4c07253");
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

		private ReadDataUserTask2FlowElement _readDataUserTask2;
		public  ReadDataUserTask2FlowElement ReadDataUserTask2 {
			get {
				return _readDataUserTask2 ?? (_readDataUserTask2 = new ReadDataUserTask2FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private ReadDataUserTask1FlowElement _readDataUserTask1;
		public  ReadDataUserTask1FlowElement ReadDataUserTask1 {
			get {
				return _readDataUserTask1 ?? (_readDataUserTask1 = new ReadDataUserTask1FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private UserQuestionUserTask1FlowElement _userQuestionUserTask1;
		public  UserQuestionUserTask1FlowElement UserQuestionUserTask1 {
			get {
				return _userQuestionUserTask1 ?? (_userQuestionUserTask1 = new UserQuestionUserTask1FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private OpenEditPageUserTask1FlowElement _openEditPageUserTask1;
		public  OpenEditPageUserTask1FlowElement OpenEditPageUserTask1 {
			get {
				return _openEditPageUserTask1 ?? (_openEditPageUserTask1 = new OpenEditPageUserTask1FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		private AddDataUserTask1FlowElement _addDataUserTask1;
		public  AddDataUserTask1FlowElement AddDataUserTask1 {
			get {
				return _addDataUserTask1 ?? (_addDataUserTask1 = new AddDataUserTask1FlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
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
					SchemaElementUId = new Guid("c740a718-c789-4ab3-bde4-32ea673b29e4"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
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
					IsLogging = false,
					SchemaElementUId = new Guid("02ffceda-189b-4450-8951-edd7180dc19f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
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
					SchemaElementUId = new Guid("64a02397-3b18-43b5-bb6d-e373c8b1082e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
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
					SchemaElementUId = new Guid("ebe44f3b-2c67-4d0e-84a4-691c5e0082b0"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
						ProcessActivitiesSelectedResults = new Dictionary<Guid, Collection<Guid>>() {
						{new Guid("e0631f09-5515-4867-8c42-2410057f9ef6"), new Collection<Guid>() {
							new Guid("41d5b5bf-62b3-4f55-8c7b-6236380e5f84"),
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
					SchemaElementUId = new Guid("f2aa3e3b-945c-4f15-a47d-af9420fa112a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						MatchBranchingDecisions = new BranchingDecisionCollection() {
				},
						ProcessActivitiesSelectedResults = new Dictionary<Guid, Collection<Guid>>() {
						{new Guid("e0631f09-5515-4867-8c42-2410057f9ef6"), new Collection<Guid>() {
							new Guid("13d3e6d1-7b65-452b-977d-336d1136f326"),
						}},
					},
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[ReadDataUserTask2.SchemaElementUId] = new Collection<ProcessFlowElement> { ReadDataUserTask2 };
			FlowElements[ReadDataUserTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { ReadDataUserTask1 };
			FlowElements[UserQuestionUserTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { UserQuestionUserTask1 };
			FlowElements[OpenEditPageUserTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { OpenEditPageUserTask1 };
			FlowElements[AddDataUserTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { AddDataUserTask1 };
			FlowElements[Terminate1.SchemaElementUId] = new Collection<ProcessFlowElement> { Terminate1 };
			FlowElements[StartSignal1.SchemaElementUId] = new Collection<ProcessFlowElement> { StartSignal1 };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "ReadDataUserTask2":
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ReadDataUserTask1", e.Context.SenderName));
						break;
					case "ReadDataUserTask1":
						if (ConditionalSequenceFlow1ExpressionExecute()) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("Terminate1", e.Context.SenderName));
							break;
						}
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("UserQuestionUserTask1", e.Context.SenderName));
						break;
					case "UserQuestionUserTask1":
						if (System.Linq.Enumerable.Count(System.Linq.Enumerable.Intersect(JsonConvert.DeserializeObject<Collection<Guid>>(UserQuestionUserTask1.ResultDecisions), ConditionalSequenceFlow2.ProcessActivitiesSelectedResults[new Guid("e0631f09-5515-4867-8c42-2410057f9ef6")])) != 0) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("Terminate1", e.Context.SenderName));
							break;
						}
						if (System.Linq.Enumerable.Count(System.Linq.Enumerable.Intersect(JsonConvert.DeserializeObject<Collection<Guid>>(UserQuestionUserTask1.ResultDecisions), ConditionalSequenceFlow3.ProcessActivitiesSelectedResults[new Guid("e0631f09-5515-4867-8c42-2410057f9ef6")])) != 0) {
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("OpenEditPageUserTask1", e.Context.SenderName));
							break;
						}
						break;
					case "OpenEditPageUserTask1":
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("AddDataUserTask1", e.Context.SenderName));
						break;
					case "AddDataUserTask1":
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("Terminate1", e.Context.SenderName));
						break;
					case "Terminate1":
						CompleteProcess();
						break;
					case "StartSignal1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ReadDataUserTask2", e.Context.SenderName));
						break;
			}
		}

		private bool ConditionalSequenceFlow1ExpressionExecute() {
			return Convert.ToBoolean((ReadDataUserTask1.ResultCount) > 0);
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
			MetaPathParameterValues.Add("e778688f-21a1-43de-b9d2-db0fbc18b703", () => ReadDataUserTask2.DataSourceFilters);
			MetaPathParameterValues.Add("3fa39942-757f-4f91-8cc5-05f0c388f5ba", () => ReadDataUserTask2.ResultType);
			MetaPathParameterValues.Add("8212ecfa-53c9-41d7-8f4d-e5ca32463915", () => ReadDataUserTask2.ReadSomeTopRecords);
			MetaPathParameterValues.Add("f7a38839-ac2c-44f5-bf83-745b36f0d524", () => ReadDataUserTask2.NumberOfRecords);
			MetaPathParameterValues.Add("cc712ba6-e16c-42d4-b9ec-a1a8b4f81efe", () => ReadDataUserTask2.FunctionType);
			MetaPathParameterValues.Add("661f4f7e-5513-4b93-89b5-f5b144274d4a", () => ReadDataUserTask2.AggregationColumnName);
			MetaPathParameterValues.Add("f36aeeeb-b3ee-4403-9357-db44b5188b75", () => ReadDataUserTask2.OrderInfo);
			MetaPathParameterValues.Add("f0ce55fa-ffbb-46b5-9062-2a58c3b9f376", () => ReadDataUserTask2.ResultEntity);
			MetaPathParameterValues.Add("6f24e390-72c1-4c58-9375-be6b9038cf6e", () => ReadDataUserTask2.ResultCount);
			MetaPathParameterValues.Add("fb217c53-ec30-418a-97c4-3fd4184b4055", () => ReadDataUserTask2.ResultIntegerFunction);
			MetaPathParameterValues.Add("15edb30c-60a2-4aed-a36f-c7c219d1271a", () => ReadDataUserTask2.ResultFloatFunction);
			MetaPathParameterValues.Add("e33d3ea4-ac05-420e-842a-36d0fc97ae05", () => ReadDataUserTask2.ResultDateTimeFunction);
			MetaPathParameterValues.Add("8d10372c-c998-4767-909b-82070da889d3", () => ReadDataUserTask2.ResultRowsCount);
			MetaPathParameterValues.Add("6f04e8eb-ca06-4fb6-846a-d95645cef096", () => ReadDataUserTask2.CanReadUncommitedData);
			MetaPathParameterValues.Add("649761d4-ef8f-4ce0-9877-8997ea05ccc2", () => ReadDataUserTask2.ResultEntityCollection);
			MetaPathParameterValues.Add("b200835e-6cf4-4e93-a99a-8f33ba4b5ffb", () => ReadDataUserTask2.EntityColumnMetaPathes);
			MetaPathParameterValues.Add("e033541f-a6b9-49d4-8731-4ecb1858f796", () => ReadDataUserTask2.IgnoreDisplayValues);
			MetaPathParameterValues.Add("c290e3eb-e210-42ed-8012-8af20d430770", () => ReadDataUserTask1.DataSourceFilters);
			MetaPathParameterValues.Add("c4a33438-67ad-4bd4-ae77-cf88caf0b2b2", () => ReadDataUserTask1.ResultType);
			MetaPathParameterValues.Add("50c21b98-e938-4e5e-b8cc-9bd135bfa0bd", () => ReadDataUserTask1.ReadSomeTopRecords);
			MetaPathParameterValues.Add("fdfea3e7-64b5-41d8-ac26-ae76e8d81ba1", () => ReadDataUserTask1.NumberOfRecords);
			MetaPathParameterValues.Add("2f0e2c82-c694-4e08-bbab-afc4fbf46ce6", () => ReadDataUserTask1.FunctionType);
			MetaPathParameterValues.Add("bdecbfec-16b0-44f3-8bd0-139633d308cf", () => ReadDataUserTask1.AggregationColumnName);
			MetaPathParameterValues.Add("3c141bba-73b6-4c8b-a422-2c40018b2a88", () => ReadDataUserTask1.OrderInfo);
			MetaPathParameterValues.Add("dc733213-160d-4f0f-acfc-ec4f081afe9c", () => ReadDataUserTask1.ResultEntity);
			MetaPathParameterValues.Add("45c2ca06-7d7a-4927-9223-11439a287ee3", () => ReadDataUserTask1.ResultCount);
			MetaPathParameterValues.Add("15679745-cc73-4dd2-8491-74184f7b079b", () => ReadDataUserTask1.ResultIntegerFunction);
			MetaPathParameterValues.Add("be6dc48f-687e-4d21-abbc-7518b1d0cb72", () => ReadDataUserTask1.ResultFloatFunction);
			MetaPathParameterValues.Add("d13c9c85-c7be-44d9-a32c-68017b0ded9d", () => ReadDataUserTask1.ResultDateTimeFunction);
			MetaPathParameterValues.Add("ad31d98a-0337-4bf0-a00b-b05dded5e2c8", () => ReadDataUserTask1.ResultRowsCount);
			MetaPathParameterValues.Add("cd3a2f18-91a8-491f-abe1-64b3961b49ba", () => ReadDataUserTask1.CanReadUncommitedData);
			MetaPathParameterValues.Add("8e25e89b-71b0-4f56-8c2f-0434ea357476", () => ReadDataUserTask1.ResultEntityCollection);
			MetaPathParameterValues.Add("0e47c166-ffd6-43cf-96e4-272a8ad0f7b7", () => ReadDataUserTask1.EntityColumnMetaPathes);
			MetaPathParameterValues.Add("fc9fc8dc-6e57-4fc4-bebe-0200aedd6ef9", () => ReadDataUserTask1.IgnoreDisplayValues);
			MetaPathParameterValues.Add("23481a37-5406-4226-b86a-b1a2572b8cde", () => UserQuestionUserTask1.BranchingDecisions);
			MetaPathParameterValues.Add("23e9ca3b-5051-48b6-aeb7-10d6bc75028e", () => UserQuestionUserTask1.ResultDecisions);
			MetaPathParameterValues.Add("57b7a942-1da6-4781-82b6-5f2d765f60f6", () => UserQuestionUserTask1.DecisionMode);
			MetaPathParameterValues.Add("45e071eb-b2ad-45b3-a1bc-8efd87759133", () => UserQuestionUserTask1.IsDecisionRequired);
			MetaPathParameterValues.Add("a58975c2-8dfe-4f7d-b4b5-efc760a6e2c4", () => UserQuestionUserTask1.Question);
			MetaPathParameterValues.Add("e276ca42-4778-4d1e-bad5-547838ddb192", () => UserQuestionUserTask1.WindowCaption);
			MetaPathParameterValues.Add("9cf316d9-54eb-47a6-a50c-78cac14b7011", () => UserQuestionUserTask1.Recommendation);
			MetaPathParameterValues.Add("58bff061-857a-462d-a6a2-602704721b18", () => UserQuestionUserTask1.ActivityCategory);
			MetaPathParameterValues.Add("4e784215-ea3c-4234-b1cc-ca418613364a", () => UserQuestionUserTask1.OwnerId);
			MetaPathParameterValues.Add("bb158d16-c4f2-41fb-9e15-4bc246b6c77f", () => UserQuestionUserTask1.Duration);
			MetaPathParameterValues.Add("36c52634-b619-4b33-a026-84862ae9b6a5", () => UserQuestionUserTask1.DurationPeriod);
			MetaPathParameterValues.Add("47f4e13a-9858-4aab-a338-5cdd5eec8e4a", () => UserQuestionUserTask1.StartIn);
			MetaPathParameterValues.Add("4e401590-cc54-45ba-9921-c2aca0384c32", () => UserQuestionUserTask1.StartInPeriod);
			MetaPathParameterValues.Add("aa81585f-b382-42ee-9bf5-54ff5bdbc344", () => UserQuestionUserTask1.RemindBefore);
			MetaPathParameterValues.Add("955ec237-80aa-4b89-a29a-9f90486dca4a", () => UserQuestionUserTask1.RemindBeforePeriod);
			MetaPathParameterValues.Add("a26b5a85-3d85-4178-a11a-a9ee85ccd1a3", () => UserQuestionUserTask1.ShowInScheduler);
			MetaPathParameterValues.Add("10c6f14e-de1b-4262-a590-5fe5c2753435", () => UserQuestionUserTask1.ShowExecutionPage);
			MetaPathParameterValues.Add("e16f21e0-59c4-4053-8a06-776e43863e63", () => UserQuestionUserTask1.Lead);
			MetaPathParameterValues.Add("4108602c-36a3-4981-8ab0-8a68691c219b", () => UserQuestionUserTask1.Account);
			MetaPathParameterValues.Add("f3210e70-9da5-46bc-9351-691d8b42c44d", () => UserQuestionUserTask1.Contact);
			MetaPathParameterValues.Add("1d96b24e-4038-4a8c-8db9-0572665a4886", () => UserQuestionUserTask1.Opportunity);
			MetaPathParameterValues.Add("822ec918-a265-4294-a554-1e71a4fc596d", () => UserQuestionUserTask1.Invoice);
			MetaPathParameterValues.Add("278492d8-ee15-4904-9b49-f363c7276f73", () => UserQuestionUserTask1.Document);
			MetaPathParameterValues.Add("01a7661e-c4d5-4b92-b676-55d74cb695e8", () => UserQuestionUserTask1.Incident);
			MetaPathParameterValues.Add("ee333566-6afe-4c7c-ba3c-741b4017f46b", () => UserQuestionUserTask1.Case);
			MetaPathParameterValues.Add("5792f47d-60c8-4621-b974-7352706c8e7e", () => UserQuestionUserTask1.ActivityResult);
			MetaPathParameterValues.Add("dad0125c-44d9-4c92-b77b-db2669300c07", () => UserQuestionUserTask1.CurrentActivityId);
			MetaPathParameterValues.Add("52e8a231-8fc9-4a14-8290-3c1fd60a177b", () => UserQuestionUserTask1.IsActivityCompleted);
			MetaPathParameterValues.Add("b3ac526b-fe42-4421-8b56-80047397f537", () => UserQuestionUserTask1.ExecutionContext);
			MetaPathParameterValues.Add("5e23dc09-ba79-49c9-b8c0-8d97e151341d", () => UserQuestionUserTask1.InformationOnStep);
			MetaPathParameterValues.Add("a3114887-c576-48bd-a363-87dca2e37348", () => UserQuestionUserTask1.Order);
			MetaPathParameterValues.Add("d0d4b578-0997-44d1-a4e4-9d67439a6cf0", () => UserQuestionUserTask1.Requests);
			MetaPathParameterValues.Add("75c7da84-4542-4698-9c9d-88b5f47fd4b6", () => UserQuestionUserTask1.Listing);
			MetaPathParameterValues.Add("971d5835-1213-40e5-930b-5e29cd8609f8", () => UserQuestionUserTask1.Property);
			MetaPathParameterValues.Add("e58c6ba0-f8a1-4717-a1ef-1467144d7fb8", () => UserQuestionUserTask1.Contract);
			MetaPathParameterValues.Add("1fbed755-0636-4ca3-8a45-a3380e8a353f", () => UserQuestionUserTask1.Project);
			MetaPathParameterValues.Add("5dc9adc3-9cf3-4ee6-80c6-5b695a483fac", () => UserQuestionUserTask1.Problem);
			MetaPathParameterValues.Add("c8747ded-af2d-4852-9eaf-6bbc6daa517f", () => UserQuestionUserTask1.Change);
			MetaPathParameterValues.Add("403d4d95-ddbc-4304-9554-255e032614bf", () => UserQuestionUserTask1.Release);
			MetaPathParameterValues.Add("80e94470-2f90-4d8e-8161-31d20f017ff7", () => OpenEditPageUserTask1.ObjectSchemaId);
			MetaPathParameterValues.Add("d78497f6-fca2-46fb-ac22-fe4f11ff73cb", () => OpenEditPageUserTask1.PageSchemaId);
			MetaPathParameterValues.Add("15469f50-5e5b-4adb-b87c-ee0e9fda696e", () => OpenEditPageUserTask1.EditMode);
			MetaPathParameterValues.Add("b16fbf23-4283-4e07-8fef-4bdbc63478f7", () => OpenEditPageUserTask1.RecordColumnValues);
			MetaPathParameterValues.Add("f857bfdd-6194-45e0-ab5f-fedb7528ae61", () => OpenEditPageUserTask1.RecordId);
			MetaPathParameterValues.Add("e5c52503-1f92-4b2c-bbd5-6754b764be17", () => OpenEditPageUserTask1.ExecutedMode);
			MetaPathParameterValues.Add("98769d2c-a36d-4353-b6be-b67527716c95", () => OpenEditPageUserTask1.IsMatchConditions);
			MetaPathParameterValues.Add("00b724d2-2791-4827-9c34-3fff4cd35aef", () => OpenEditPageUserTask1.DataSourceFilters);
			MetaPathParameterValues.Add("1c67d59e-4140-415b-b8a7-c4d23f5794ce", () => OpenEditPageUserTask1.GenerateDecisionsFromColumn);
			MetaPathParameterValues.Add("06b3c24b-68a0-47b3-bdf3-c5c392c68d91", () => OpenEditPageUserTask1.DecisionalColumnMetaPath);
			MetaPathParameterValues.Add("f0c3f2e7-610d-4a5d-8638-459103929ff9", () => OpenEditPageUserTask1.ResultParameter);
			MetaPathParameterValues.Add("d0859106-3558-4ea8-9845-ce897016d853", () => OpenEditPageUserTask1.IsReexecution);
			MetaPathParameterValues.Add("cb9c0db3-924c-41a4-96be-5330e042584a", () => OpenEditPageUserTask1.Recommendation);
			MetaPathParameterValues.Add("ecaa6298-1c10-4103-8ec3-a5c77ebdbd0d", () => OpenEditPageUserTask1.ActivityCategory);
			MetaPathParameterValues.Add("319c4095-5245-4bd3-a6d0-d121e9cb7c1c", () => OpenEditPageUserTask1.OwnerId);
			MetaPathParameterValues.Add("48e95c86-7612-4aa1-9f00-70d455cd6805", () => OpenEditPageUserTask1.Duration);
			MetaPathParameterValues.Add("b2104bce-08c6-4d3e-9bbd-9c6a828bed34", () => OpenEditPageUserTask1.DurationPeriod);
			MetaPathParameterValues.Add("19f9d8e4-507e-4747-9578-6f4530f44e13", () => OpenEditPageUserTask1.StartIn);
			MetaPathParameterValues.Add("58914c85-c54f-4368-a9a6-4bc35498eebd", () => OpenEditPageUserTask1.StartInPeriod);
			MetaPathParameterValues.Add("e71a557a-1e94-46c3-a67e-29ba8f323dd8", () => OpenEditPageUserTask1.RemindBefore);
			MetaPathParameterValues.Add("3cc1c02a-4399-427b-8862-adff07882076", () => OpenEditPageUserTask1.RemindBeforePeriod);
			MetaPathParameterValues.Add("085ed94c-041e-4f25-b614-31343cb99a3e", () => OpenEditPageUserTask1.ShowInScheduler);
			MetaPathParameterValues.Add("da73a7a2-94a5-4e19-8700-b71b44815ead", () => OpenEditPageUserTask1.ShowExecutionPage);
			MetaPathParameterValues.Add("5228090a-4221-4eb4-9bdb-c145725c9d51", () => OpenEditPageUserTask1.Lead);
			MetaPathParameterValues.Add("30190859-2815-4433-8745-bc3145a07e45", () => OpenEditPageUserTask1.Account);
			MetaPathParameterValues.Add("d9c76f77-2a25-4519-8733-70b0849e36a8", () => OpenEditPageUserTask1.Contact);
			MetaPathParameterValues.Add("8fdb8eb4-7745-4878-83c3-00af0a43a401", () => OpenEditPageUserTask1.Opportunity);
			MetaPathParameterValues.Add("3bacfb77-f318-43d9-a98d-8825b4256f0e", () => OpenEditPageUserTask1.Invoice);
			MetaPathParameterValues.Add("3a77931e-e654-479c-b8cd-2d7b8220106a", () => OpenEditPageUserTask1.Document);
			MetaPathParameterValues.Add("c9012c39-a97b-4498-87d0-efb3a8392760", () => OpenEditPageUserTask1.Incident);
			MetaPathParameterValues.Add("a942f1c7-db58-4441-93e6-e80967c64774", () => OpenEditPageUserTask1.Case);
			MetaPathParameterValues.Add("80e251c5-4f2e-4db6-a17f-aecd38ed9c38", () => OpenEditPageUserTask1.ActivityResult);
			MetaPathParameterValues.Add("693e92b8-2fc0-439e-a459-8b0f7d80ff74", () => OpenEditPageUserTask1.CurrentActivityId);
			MetaPathParameterValues.Add("ef6c53ee-e4c4-483b-9e4b-2a02f5ef2413", () => OpenEditPageUserTask1.IsActivityCompleted);
			MetaPathParameterValues.Add("698cd781-c1c5-4726-a0c1-3bc5c8ab7666", () => OpenEditPageUserTask1.ExecutionContext);
			MetaPathParameterValues.Add("ac4fffee-16bb-45bf-b726-7f09122eb4fd", () => OpenEditPageUserTask1.PageTypeUId);
			MetaPathParameterValues.Add("54a9e484-9ab4-4d0e-8232-2e13dd624875", () => OpenEditPageUserTask1.ActivitySchemaUId);
			MetaPathParameterValues.Add("e2e84552-7dd2-47a8-8a10-16aea65850fa", () => OpenEditPageUserTask1.InformationOnStep);
			MetaPathParameterValues.Add("cd395ccc-7329-4825-a3f0-455dd574f91d", () => OpenEditPageUserTask1.Order);
			MetaPathParameterValues.Add("1fcbf079-68cc-421f-9cf7-f16829982feb", () => OpenEditPageUserTask1.Requests);
			MetaPathParameterValues.Add("71a53f2b-8b5a-4575-91b5-78728d880805", () => OpenEditPageUserTask1.Listing);
			MetaPathParameterValues.Add("bef8d961-a294-45a2-86d7-e596ac1d40aa", () => OpenEditPageUserTask1.Property);
			MetaPathParameterValues.Add("8b9f2ecb-0f28-4947-8cdc-6249dbfc9046", () => OpenEditPageUserTask1.Contract);
			MetaPathParameterValues.Add("ad8453ea-4bcb-4fb2-a1e3-db482e287fa8", () => OpenEditPageUserTask1.Problem);
			MetaPathParameterValues.Add("d0dbfa07-ebd0-44b8-a617-a2a660052793", () => OpenEditPageUserTask1.Change);
			MetaPathParameterValues.Add("cc9fbec2-5b7b-45e7-9811-3044ad2be41a", () => OpenEditPageUserTask1.Release);
			MetaPathParameterValues.Add("a86b1df8-bd55-4f87-ab9f-4620c59d5c66", () => OpenEditPageUserTask1.Project);
			MetaPathParameterValues.Add("649421c3-199e-4ead-9148-4772b3a77ae2", () => AddDataUserTask1.EntitySchemaId);
			MetaPathParameterValues.Add("535757b9-634a-4b56-8359-fb743dfeed48", () => AddDataUserTask1.DataSourceFilters);
			MetaPathParameterValues.Add("0a589bf1-d2a7-4cde-8429-faf309d6e742", () => AddDataUserTask1.RecordAddMode);
			MetaPathParameterValues.Add("4bf2c65c-d411-4ec4-a322-b872ae629f13", () => AddDataUserTask1.FilterEntitySchemaId);
			MetaPathParameterValues.Add("a9d5af6a-121b-4ce6-a80c-6625e7f1124b", () => AddDataUserTask1.RecordDefValues);
			MetaPathParameterValues.Add("fef21881-12c4-4660-ad5d-6783032a1e8b", () => AddDataUserTask1.RecordId);
			MetaPathParameterValues.Add("3dc6cc0e-ceb5-4de1-b3f9-a001d7a3564b", () => StartSignal1.RecordId);
			MetaPathParameterValues.Add("68d9497a-7faa-4d07-b5b9-835f3bc75d3d", () => StartSignal1.EntitySchemaUId);
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
			var cloneItem = (SendResolution)base.CloneShallow();
			cloneItem.ExecutedEventHandler = ExecutedEventHandler;
			return cloneItem;
		}

		#endregion

	}

	#endregion

}

