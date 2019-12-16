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

	#region Class: RunAnalyzeCaseSatisfactionLevelSchema

	/// <exclude/>
	public class RunAnalyzeCaseSatisfactionLevelSchema : Terrasoft.Core.Process.ProcessSchema
	{

		#region Constructors: Public

		public RunAnalyzeCaseSatisfactionLevelSchema(ProcessSchemaManager processSchemaManager)
			: base(processSchemaManager) {
		}

		public RunAnalyzeCaseSatisfactionLevelSchema(RunAnalyzeCaseSatisfactionLevelSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "RunAnalyzeCaseSatisfactionLevel";
			UId = new Guid("4898f7ea-06ca-401a-9cd3-bbb193f916c1");
			CreatedInPackageId = new Guid("30de0e3b-0a22-4b21-aec2-eb5dee3a342f");
			CreatedInSchemaUId = Guid.Empty;
			CreatedInVersion = @"7.8.0.0";
			CultureName = @"en-US";
			EntitySchemaUId = Guid.Empty;
			IsActiveVersion = false;
			IsCreatedInSvg = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			SerializeToDB = true;
			SerializeToMemory = true;
			Tag = @"Business Process";
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
			UseForceCompile = true;
			ZipMethodsBody = new byte[] {  };
			ZipCompiledMethodsBody = new byte[] {  };
			RealUId = new Guid("4898f7ea-06ca-401a-9cd3-bbb193f916c1");
			Version = 0;
			PackageUId = new Guid("1f513d05-8e3f-4989-92ce-3af40e5127d6");
			UseSystemSecurityContext = false;
		}

		protected virtual ProcessSchemaParameter CreateCaseRecordIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("c38a0af2-cfe7-436f-8d64-87341f47d144"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("4898f7ea-06ca-401a-9cd3-bbb193f916c1"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("4898f7ea-06ca-401a-9cd3-bbb193f916c1"),
				Name = @"CaseRecordId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					Value = @"[#[IsOwnerSchema:false].[IsSchema:false].[Element:{73da230b-c3b0-4648-b931-60aef0bc046c}].[Parameter:{5984f6fb-289e-4980-aea6-b57aa1779872}]#]",
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("4898f7ea-06ca-401a-9cd3-bbb193f916c1"),
				},
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateCaseRecordIdParameter());
		}

		protected virtual void InitializeStartSignal1Parameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var recordIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("5984f6fb-289e-4980-aea6-b57aa1779872"),
				ContainerUId = new Guid("73da230b-c3b0-4648-b931-60aef0bc046c"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("4898f7ea-06ca-401a-9cd3-bbb193f916c1"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("4898f7ea-06ca-401a-9cd3-bbb193f916c1"),
				Name = @"RecordId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			recordIdParameter.SourceValue = new ProcessSchemaParameterValue(recordIdParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(recordIdParameter);
			var entitySchemaUIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("e9f654a3-168a-4e03-958d-43d8e77b1431"),
				ContainerUId = new Guid("73da230b-c3b0-4648-b931-60aef0bc046c"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("73da230b-c3b0-4648-b931-60aef0bc046c"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("4898f7ea-06ca-401a-9cd3-bbb193f916c1"),
				Name = @"EntitySchemaUId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			entitySchemaUIdParameter.SourceValue = new ProcessSchemaParameterValue(entitySchemaUIdParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"117d32f9-8275-4534-8411-1c66115ce9cd",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(entitySchemaUIdParameter);
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet1 = CreateLaneSet1LaneSet();
			LaneSets.Add(schemaLaneSet1);
			ProcessSchemaLane schemaLane1 = CreateLane1Lane();
			schemaLaneSet1.Lanes.Add(schemaLane1);
			ProcessSchemaTerminateEvent terminateevent1 = CreateTerminateEvent1TerminateEvent();
			FlowElements.Add(terminateevent1);
			ProcessSchemaStartSignalEvent startsignal1 = CreateStartSignal1StartSignalEvent();
			FlowElements.Add(startsignal1);
			ProcessSchemaScriptTask runprocess = CreateRunProcessScriptTask();
			FlowElements.Add(runprocess);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("58c48669-2996-455f-8128-3c393ebe0a43"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("10cb6199-40c6-4b6d-9d0e-500310d45f57"),
				CreatedInSchemaUId = new Guid("4898f7ea-06ca-401a-9cd3-bbb193f916c1"),
				CurveCenterPosition = new Point(0, 0),
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("4898f7ea-06ca-401a-9cd3-bbb193f916c1"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("73da230b-c3b0-4648-b931-60aef0bc046c"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("0b998ab2-94c4-48c4-9555-71041042693b"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("072884ec-d907-4c9c-9716-1d042fe62b58"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("10cb6199-40c6-4b6d-9d0e-500310d45f57"),
				CreatedInSchemaUId = new Guid("4898f7ea-06ca-401a-9cd3-bbb193f916c1"),
				CurveCenterPosition = new Point(0, 0),
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("4898f7ea-06ca-401a-9cd3-bbb193f916c1"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("0b998ab2-94c4-48c4-9555-71041042693b"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("d85c2283-ddfa-4265-a558-c22d2429128a"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("5a8d38cc-2217-4e06-aae6-58dbe1e2d7cb"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("10cb6199-40c6-4b6d-9d0e-500310d45f57"),
				CreatedInSchemaUId = new Guid("4898f7ea-06ca-401a-9cd3-bbb193f916c1"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("4898f7ea-06ca-401a-9cd3-bbb193f916c1"),
				Name = @"LaneSet1",
				Position = new Point(0, 0),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("cde03cbb-c778-4c8e-a9a0-f1dd4b69874c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5a8d38cc-2217-4e06-aae6-58dbe1e2d7cb"),
				CreatedInOwnerSchemaUId = new Guid("4898f7ea-06ca-401a-9cd3-bbb193f916c1"),
				CreatedInPackageId = new Guid("10cb6199-40c6-4b6d-9d0e-500310d45f57"),
				CreatedInSchemaUId = new Guid("4898f7ea-06ca-401a-9cd3-bbb193f916c1"),
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("4898f7ea-06ca-401a-9cd3-bbb193f916c1"),
				Name = @"Lane1",
				Position = new Point(0, 0),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaTerminateEvent CreateTerminateEvent1TerminateEvent() {
			ProcessSchemaTerminateEvent schemaTerminateEvent = new ProcessSchemaTerminateEvent(this) {
				UId = new Guid("d85c2283-ddfa-4265-a558-c22d2429128a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("cde03cbb-c778-4c8e-a9a0-f1dd4b69874c"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("10cb6199-40c6-4b6d-9d0e-500310d45f57"),
				CreatedInSchemaUId = new Guid("4898f7ea-06ca-401a-9cd3-bbb193f916c1"),
				EntitySchemaUId = Guid.Empty,
				IsLogging = true,
				ManagerItemUId = new Guid("1bd93619-0574-454e-bb4e-cf53b9eb9470"),
				ModifiedInSchemaUId = new Guid("4898f7ea-06ca-401a-9cd3-bbb193f916c1"),
				Name = @"TerminateEvent1",
				Position = new Point(600, 184),
				SerializeToDB = false,
				Size = new Size(27, 27),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaTerminateEvent;
		}

		protected virtual ProcessSchemaStartSignalEvent CreateStartSignal1StartSignalEvent() {
			ProcessSchemaStartSignalEvent schemaStartSignalEvent = new ProcessSchemaStartSignalEvent(this) {	UId = new Guid("73da230b-c3b0-4648-b931-60aef0bc046c"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("cde03cbb-c778-4c8e-a9a0-f1dd4b69874c"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("10cb6199-40c6-4b6d-9d0e-500310d45f57"),
				CreatedInSchemaUId = new Guid("4898f7ea-06ca-401a-9cd3-bbb193f916c1"),
				EntitySchemaUId = new Guid("117d32f9-8275-4534-8411-1c66115ce9cd"),
				EntitySignal = EntityChangeType.Updated,
				HasEntityColumnChange = true,
				HasEntityFilters = true,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = true,
				ManagerItemUId = new Guid("1129e72f-0e8c-445a-b2ea-463517e86395"),
				ModifiedInSchemaUId = new Guid("4898f7ea-06ca-401a-9cd3-bbb193f916c1"),
				Name = @"StartSignal1",
				NewEntityChangedColumns = false,
				Position = new Point(53, 184),
				SerializeToDB = false,
				Size = new Size(27, 27),
				UseBackgroundMode = true,
				WaitingEntitySignal = true,
				WaitingRandomSignal = false
			};
			schemaStartSignalEvent.EntityChangedColumns.Add("ccfc5fbf-4dc9-47e4-91f3-54ea9251ab18");
			InitializeStartSignal1Parameters(schemaStartSignalEvent);
			return schemaStartSignalEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateRunProcessScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("0b998ab2-94c4-48c4-9555-71041042693b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("cde03cbb-c778-4c8e-a9a0-f1dd4b69874c"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("10cb6199-40c6-4b6d-9d0e-500310d45f57"),
				CreatedInSchemaUId = new Guid("4898f7ea-06ca-401a-9cd3-bbb193f916c1"),
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("4898f7ea-06ca-401a-9cd3-bbb193f916c1"),
				Name = @"RunProcess",
				Position = new Point(322, 170),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,165,84,203,110,219,48,16,60,219,95,193,232,16,200,128,193,31,232,3,72,100,57,16,208,6,173,237,182,103,86,90,197,4,40,202,230,67,173,208,248,223,187,36,37,91,86,157,186,143,163,184,220,217,153,217,161,26,166,8,232,61,121,67,36,124,35,169,52,220,180,235,124,11,21,251,104,65,181,241,39,13,42,169,165,132,220,240,90,210,225,133,247,76,178,39,80,115,18,37,76,67,52,123,53,109,16,76,27,102,172,78,106,97,43,249,200,42,64,100,55,128,222,21,69,56,140,163,53,51,92,151,204,35,190,131,6,4,93,251,38,154,21,209,140,186,166,33,84,166,151,92,50,17,154,17,237,143,193,66,223,57,175,76,175,64,215,162,129,226,69,188,190,187,191,56,18,134,82,175,49,186,56,63,199,198,224,94,215,241,0,38,124,143,60,158,19,55,99,5,121,173,138,172,192,110,94,146,120,208,125,131,171,178,66,204,200,143,233,196,1,115,207,201,207,66,228,211,69,55,96,211,238,122,165,159,153,176,240,250,107,93,139,183,241,11,82,188,245,56,176,131,237,13,248,59,212,177,195,71,80,39,99,200,245,249,153,220,156,134,120,57,19,5,198,42,73,140,178,24,129,201,33,48,193,96,186,174,96,235,117,50,15,150,23,71,137,199,24,246,178,96,16,96,196,186,30,111,55,35,147,8,39,115,184,111,29,84,124,204,251,164,91,137,2,109,133,113,167,110,183,3,12,154,40,96,6,46,238,185,247,228,212,76,151,96,242,237,82,213,213,226,62,62,11,1,185,189,29,217,128,41,112,66,105,90,237,76,219,155,119,4,90,131,25,88,210,71,18,159,215,252,28,198,113,232,182,253,15,1,186,28,158,110,209,190,20,136,253,142,89,34,106,109,21,44,208,37,36,55,90,71,98,149,66,59,221,169,35,211,125,186,187,27,142,123,152,249,113,158,127,1,2,12,116,127,177,133,255,24,219,237,174,82,103,110,28,225,5,214,66,241,88,27,94,242,156,185,114,20,234,95,182,160,186,5,251,159,81,166,211,189,101,34,238,52,126,96,10,85,26,80,231,235,9,189,119,178,136,163,180,98,92,108,160,218,9,100,25,32,100,236,202,147,95,32,54,160,20,211,117,105,40,178,44,249,147,85,44,168,118,235,1,213,240,28,176,160,141,166,254,145,88,87,28,82,222,236,4,206,158,147,255,69,79,181,225,149,47,174,96,111,65,155,0,236,96,131,193,193,92,154,126,135,220,162,175,254,240,48,10,28,107,32,46,153,208,62,2,135,233,97,58,124,202,63,1,3,45,210,121,101,6,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Process CreateProcess(UserConnection userConnection) {
			return new RunAnalyzeCaseSatisfactionLevel(userConnection);
		}

		public override object Clone() {
			return new RunAnalyzeCaseSatisfactionLevelSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("4898f7ea-06ca-401a-9cd3-bbb193f916c1"));
		}

		#endregion

	}

	#endregion

	#region Class: RunAnalyzeCaseSatisfactionLevel

	/// <exclude/>
	public class RunAnalyzeCaseSatisfactionLevel : Terrasoft.Core.Process.Process
	{

		#region Class: ProcessLane1

		/// <exclude/>
		public class ProcessLane1 : ProcessLane
		{

			public ProcessLane1(UserConnection userConnection, RunAnalyzeCaseSatisfactionLevel process)
				: base(userConnection) {
				Owner = process;
				IsUsedParentUserContexts = false;
			}

		}

		#endregion

		public RunAnalyzeCaseSatisfactionLevel(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "RunAnalyzeCaseSatisfactionLevel";
			SchemaUId = new Guid("4898f7ea-06ca-401a-9cd3-bbb193f916c1");
			Caption = Schema.Caption;
			SchemaManagerName = "ProcessSchemaManager";
			SerializeToDB = true;
			SerializeToMemory = true;
			IsLogging = true;
			UseSystemSecurityContext = false;
			_notificationCaption = () => { return new LocalizableString((Caption)); };
			_caseRecordId = () => { return (Guid)((StartSignal1.RecordId)); };
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("4898f7ea-06ca-401a-9cd3-bbb193f916c1");
			}
		}

		private string ConditionalExpressionLogMessage {
			get {
				return "Process: RunAnalyzeCaseSatisfactionLevel, Source element: {0}, Conditional flow: {1}, Expression: {2}, Result: {3}";
			}
		}

		private string DeadEndGatewayLogMessage {
			get {
				return "Process: RunAnalyzeCaseSatisfactionLevel, Source element: {0}, None of the exclusive gateway conditions are met!";
			}
		}

		#endregion

		#region Properties: Public

		private Func<string> _notificationCaption;
		public virtual string NotificationCaption {
			get {
				return (_notificationCaption ?? (_notificationCaption = () => null)).Invoke();
			}
			set {
				_notificationCaption = () => { return value; };
			}
		}

		private Func<Guid> _caseRecordId;
		public virtual Guid CaseRecordId {
			get {
				return (_caseRecordId ?? (_caseRecordId = () => Guid.Empty)).Invoke();
			}
			set {
				_caseRecordId = () => { return value; };
			}
		}

		private ProcessLane1 _lane1;
		public ProcessLane1 Lane1 {
			get {
				return _lane1 ?? ((_lane1) = new ProcessLane1(UserConnection, this));
			}
		}

		private ProcessTerminateEvent _terminateEvent1;
		public ProcessTerminateEvent TerminateEvent1 {
			get {
				return _terminateEvent1 ?? (_terminateEvent1 = new ProcessTerminateEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaTerminateEvent",
					Name = "TerminateEvent1",
					SchemaElementUId = new Guid("d85c2283-ddfa-4265-a558-c22d2429128a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
				});
			}
		}

		private ProcessStartSignalEvent _startSignal1;
		public ProcessStartSignalEvent StartSignal1 {
			get {
				return _startSignal1 ?? (_startSignal1 = new ProcessStartSignalEvent(UserConnection) {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartSignalEvent",
					Name = "StartSignal1",
					SerializeToDB = false,
					IsLogging = true,
					SchemaElementUId = new Guid("73da230b-c3b0-4648-b931-60aef0bc046c"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _runProcess;
		public ProcessScriptTask RunProcess {
			get {
				return _runProcess ?? (_runProcess = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "RunProcess",
					SchemaElementUId = new Guid("0b998ab2-94c4-48c4-9555-71041042693b"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
					Script = RunProcessExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[TerminateEvent1.SchemaElementUId] = new Collection<ProcessFlowElement> { TerminateEvent1 };
			FlowElements[StartSignal1.SchemaElementUId] = new Collection<ProcessFlowElement> { StartSignal1 };
			FlowElements[RunProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { RunProcess };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "TerminateEvent1":
						CompleteProcess();
						break;
					case "StartSignal1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("RunProcess", e.Context.SenderName));
						break;
					case "RunProcess":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("TerminateEvent1", e.Context.SenderName));
						break;
			}
		}

		private void WritePropertyValues(DataWriter writer, bool useAllValueSources) {
			if (!HasMapping("CaseRecordId")) {
				writer.WriteValue("CaseRecordId", CaseRecordId, Guid.Empty);
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
			MetaPathParameterValues.Add("c38a0af2-cfe7-436f-8d64-87341f47d144", () => CaseRecordId);
			MetaPathParameterValues.Add("5984f6fb-289e-4980-aea6-b57aa1779872", () => StartSignal1.RecordId);
			MetaPathParameterValues.Add("e9f654a3-168a-4e03-958d-43d8e77b1431", () => StartSignal1.EntitySchemaUId);
		}

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			bool hasValueToRead = reader.HasValue();
			switch (reader.CurrentName) {
				case "CaseRecordId":
					if (!hasValueToRead) break;
					CaseRecordId = reader.GetValue<System.Guid>();
				break;
			}
		}

		protected override void WritePropertyValues(DataWriter writer) {
			base.WritePropertyValues(writer);
			WritePropertyValues(writer, true);
		}

		#endregion

		#region Methods: Public

		public virtual bool RunProcessExecute(ProcessExecutingContext context) {
			var esq = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "Case");
			var statusColumnName =  esq.AddColumn("SatisfactionLevel.Status.Id").Name;
			var statusIsFinalColumn = esq.AddColumn("SatisfactionLevel.Status.IsFinal");
			var statusIsResolvedColumn = esq.AddColumn("Status.IsResolved");
			var statusCaseIsFinalColumn = esq.AddColumn("Status.IsFinal");
			var caseEntity = esq.GetEntity(UserConnection, CaseRecordId);
			if (caseEntity != null) {
				var isCaseFinal = caseEntity.GetTypedColumnValue<bool>(statusCaseIsFinalColumn.Name);
				var isResolved = caseEntity.GetTypedColumnValue<bool>(statusIsResolvedColumn.Name);
				if (isCaseFinal || !isResolved) {
					return true;
				}
				var newCaseStatus = caseEntity.GetTypedColumnValue<Guid>(statusColumnName);
				var entitySchema = UserConnection.EntitySchemaManager.GetInstanceByName("Case");
				Entity resultCase = entitySchema.CreateEntity(UserConnection);
				if (resultCase.FetchFromDB(CaseRecordId) && newCaseStatus != Guid.Empty) {
					resultCase.SetColumnValue("StatusId", newCaseStatus);
					var isFinal = caseEntity.GetTypedColumnValue<bool>(statusIsFinalColumn.Name);
					if (isFinal) {
						resultCase.SetColumnValue("ClosureDate", UserConnection.CurrentUser.GetCurrentDateTime());
						var delete = new Delete(UserConnection)
						.From("DelayedNotification")
						.Where("CaseId").IsEqual(Column.Parameter(CaseRecordId))
						.And("EmailTemplateId").In(
							Column.Parameter(Terrasoft.Configuration.CaseServiceConsts.ResolutionNotificationTplId), 
							Column.Parameter(Terrasoft.Configuration.CaseServiceConsts.EstimationRequestTplId)
						);
						delete.Execute();
					}
					resultCase.Save(false);
				}
			}
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
			var cloneItem = (RunAnalyzeCaseSatisfactionLevel)base.CloneShallow();
			cloneItem.ExecutedEventHandler = ExecutedEventHandler;
			return cloneItem;
		}

		#endregion

	}

	#endregion

}

