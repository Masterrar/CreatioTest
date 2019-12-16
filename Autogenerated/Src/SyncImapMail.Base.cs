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
	using Terrasoft.Mail;

	#region Class: SyncImapMailSchema

	/// <exclude/>
	public class SyncImapMailSchema : Terrasoft.Core.Process.ProcessSchema
	{

		#region Constructors: Public

		public SyncImapMailSchema(ProcessSchemaManager processSchemaManager)
			: base(processSchemaManager) {
		}

		public SyncImapMailSchema(SyncImapMailSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "SyncImapMail";
			UId = new Guid("237dd150-53cf-4801-bd72-d517975107f8");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			CreatedInSchemaUId = Guid.Empty;
			CreatedInVersion = @"0.0.0.0";
			CultureName = @"en-US";
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsLogging = false;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			SerializeToDB = false;
			SerializeToMemory = true;
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
			ZipMethodsBody = new byte[] {  };
			ZipCompiledMethodsBody = new byte[] {  };
			RealUId = new Guid("237dd150-53cf-4801-bd72-d517975107f8");
			Version = 0;
			PackageUId = new Guid("5be3998b-c5c3-42bb-a01c-2e4149059a97");
			UseSystemSecurityContext = false;
		}

		protected virtual ProcessSchemaParameter CreatePageInstanceIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("a54165a0-7744-4599-95de-a742bd292b40"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("237dd150-53cf-4801-bd72-d517975107f8"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("237dd150-53cf-4801-bd72-d517975107f8"),
				Name = @"PageInstanceId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text"),
			};
		}

		protected virtual ProcessSchemaParameter CreateActiveTreeGridCurrentRowIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("57e04ecc-eb57-43da-bb56-54c46c31c8d3"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("237dd150-53cf-4801-bd72-d517975107f8"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("237dd150-53cf-4801-bd72-d517975107f8"),
				Name = @"ActiveTreeGridCurrentRowId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateMailUserNameParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("97325781-b945-49f7-8732-c6cfdd3aebc1"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("237dd150-53cf-4801-bd72-d517975107f8"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("237dd150-53cf-4801-bd72-d517975107f8"),
				Name = @"MailUserName",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("LongText"),
			};
		}

		protected virtual ProcessSchemaParameter CreateSenderEmailAddressParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("5cda26a9-50cc-4292-9c8a-84b7533a2e06"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("237dd150-53cf-4801-bd72-d517975107f8"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("237dd150-53cf-4801-bd72-d517975107f8"),
				Name = @"SenderEmailAddress",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MediumText"),
			};
		}

		protected virtual ProcessSchemaParameter CreateCurrentUserIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("294c50f3-a39f-4a40-a91e-58e6766978b9"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("237dd150-53cf-4801-bd72-d517975107f8"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("237dd150-53cf-4801-bd72-d517975107f8"),
				Name = @"CurrentUserId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreatePageInstanceIdParameter());
			Parameters.Add(CreateActiveTreeGridCurrentRowIdParameter());
			Parameters.Add(CreateMailUserNameParameter());
			Parameters.Add(CreateSenderEmailAddressParameter());
			Parameters.Add(CreateCurrentUserIdParameter());
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet1 = CreateLaneSet1LaneSet();
			LaneSets.Add(schemaLaneSet1);
			ProcessSchemaLane schemaLane1 = CreateLane1Lane();
			schemaLaneSet1.Lanes.Add(schemaLane1);
			ProcessSchemaStartEvent start1 = CreateStart1StartEvent();
			FlowElements.Add(start1);
			ProcessSchemaEndEvent end1 = CreateEnd1EndEvent();
			FlowElements.Add(end1);
			ProcessSchemaScriptTask scripttask1 = CreateScriptTask1ScriptTask();
			FlowElements.Add(scripttask1);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("adfc9151-77b2-4fe4-a87b-92ae60725da1"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("237dd150-53cf-4801-bd72-d517975107f8"),
				CurveCenterPosition = new Point(373, 199),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("237dd150-53cf-4801-bd72-d517975107f8"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("1edb1620-1236-4a0a-91ef-2612ae3a0993"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("8727a659-1a61-4eec-87bc-f4e360329497"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("1910142d-434b-41cb-9592-e2c24eee63bd"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("237dd150-53cf-4801-bd72-d517975107f8"),
				CurveCenterPosition = new Point(373, 199),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("237dd150-53cf-4801-bd72-d517975107f8"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("9ac7eaae-3d0b-4972-89fe-e58baaedcc67"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("1edb1620-1236-4a0a-91ef-2612ae3a0993"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("5d241632-5559-4887-b0c1-a279e8a744cf"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("237dd150-53cf-4801-bd72-d517975107f8"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("237dd150-53cf-4801-bd72-d517975107f8"),
				Name = @"LaneSet1",
				Position = new Point(5, 5),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("13ec4d62-a0e8-4c2f-8f8a-cfefd74363e3"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("5d241632-5559-4887-b0c1-a279e8a744cf"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("237dd150-53cf-4801-bd72-d517975107f8"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("237dd150-53cf-4801-bd72-d517975107f8"),
				Name = @"Lane1",
				Position = new Point(29, 0),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaStartEvent CreateStart1StartEvent() {
			ProcessSchemaStartEvent schemaStartEvent = new ProcessSchemaStartEvent(this) {
				UId = new Guid("9ac7eaae-3d0b-4972-89fe-e58baaedcc67"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("13ec4d62-a0e8-4c2f-8f8a-cfefd74363e3"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("237dd150-53cf-4801-bd72-d517975107f8"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsInterrupting = false,
				IsLogging = true,
				ManagerItemUId = new Guid("53818048-7868-48f6-ada0-0ebaa65af628"),
				ModifiedInSchemaUId = new Guid("237dd150-53cf-4801-bd72-d517975107f8"),
				Name = @"Start1",
				Position = new Point(57, 44),
				SerializeToDB = false,
				Size = new Size(27, 27),
				UseBackgroundMode = false
			};
			
			return schemaStartEvent;
		}

		protected virtual ProcessSchemaEndEvent CreateEnd1EndEvent() {
			ProcessSchemaEndEvent schemaEndEvent = new ProcessSchemaEndEvent(this) {
				UId = new Guid("8727a659-1a61-4eec-87bc-f4e360329497"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("13ec4d62-a0e8-4c2f-8f8a-cfefd74363e3"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("237dd150-53cf-4801-bd72-d517975107f8"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = true,
				ManagerItemUId = new Guid("45ceaae2-4e1f-4c0c-86aa-cd4aeb4da913"),
				ModifiedInSchemaUId = new Guid("237dd150-53cf-4801-bd72-d517975107f8"),
				Name = @"End1",
				Position = new Point(246, 44),
				SerializeToDB = false,
				Size = new Size(27, 27),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaEndEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask1ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("1edb1620-1236-4a0a-91ef-2612ae3a0993"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("13ec4d62-a0e8-4c2f-8f8a-cfefd74363e3"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6"),
				CreatedInSchemaUId = new Guid("237dd150-53cf-4801-bd72-d517975107f8"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("237dd150-53cf-4801-bd72-d517975107f8"),
				Name = @"ScriptTask1",
				Position = new Point(134, 30),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,181,85,77,83,219,48,16,61,39,51,252,7,17,46,246,76,106,40,5,14,165,208,9,73,160,233,64,160,56,180,199,142,98,11,162,142,44,5,73,78,226,50,249,239,93,73,14,113,236,100,104,14,92,2,94,237,190,183,31,218,167,61,250,136,118,251,221,65,56,104,245,59,173,251,206,225,239,3,180,191,143,6,183,157,91,212,190,191,249,112,116,120,124,116,178,83,159,96,137,20,137,82,73,6,100,166,209,25,66,15,138,200,182,224,156,68,154,10,30,116,176,198,63,49,75,201,32,27,147,27,204,241,19,145,193,21,209,61,174,52,230,17,185,200,250,56,33,94,35,124,5,105,248,8,43,180,252,94,65,56,117,148,112,38,9,215,134,171,23,3,107,123,229,123,247,12,93,165,52,14,186,201,88,103,232,107,233,244,115,57,197,194,113,208,139,129,161,203,53,213,89,24,141,72,130,127,164,68,102,232,217,254,158,33,78,166,168,114,234,149,240,138,14,121,197,77,180,83,175,213,26,55,152,178,161,152,133,25,143,66,162,53,229,79,170,225,3,161,133,15,90,113,220,22,44,77,184,215,48,136,166,47,155,79,239,176,82,83,33,227,245,30,134,40,36,114,2,21,129,85,18,181,129,167,224,119,39,164,126,211,9,152,195,240,250,77,183,158,10,53,150,122,192,54,208,134,132,199,68,118,19,136,168,166,119,73,153,38,82,25,127,207,89,218,146,96,77,156,253,23,213,163,59,44,161,55,198,201,115,198,182,72,198,88,82,37,184,185,35,65,247,57,197,204,182,188,17,102,170,21,39,148,63,112,170,97,184,141,230,234,213,241,223,137,182,216,127,198,196,212,150,218,17,83,206,4,142,97,236,144,135,150,41,121,47,250,46,199,67,70,108,18,25,31,73,193,233,95,108,174,230,59,211,174,25,107,19,85,141,150,222,9,7,131,149,129,181,114,204,160,10,161,181,172,219,42,19,179,83,55,37,65,130,49,12,144,98,166,80,84,248,223,109,103,201,195,51,113,169,130,150,35,207,80,198,195,238,12,148,69,11,9,254,149,189,85,32,57,157,139,165,201,243,125,244,2,149,21,0,160,59,80,14,4,187,228,3,7,71,238,173,217,91,194,231,145,53,144,81,111,215,5,5,198,105,1,89,171,25,180,241,107,115,243,244,59,212,18,99,153,125,81,90,2,107,19,137,225,31,32,58,207,163,106,47,232,127,251,140,230,205,215,144,21,9,44,111,1,154,91,191,249,169,253,147,95,155,200,221,27,155,118,34,38,196,152,190,139,97,105,44,205,66,9,190,139,215,16,56,181,197,180,228,83,154,0,75,119,22,145,177,237,103,35,133,104,20,11,162,16,23,26,141,240,132,32,147,49,194,81,36,82,238,4,8,50,49,63,133,217,6,11,61,132,46,229,189,132,203,226,212,196,62,13,121,179,206,189,229,169,125,86,14,124,7,232,142,145,196,211,133,110,110,139,244,49,71,114,243,92,226,128,214,245,83,198,110,165,125,108,150,211,45,103,95,224,93,190,151,6,221,178,94,10,121,13,202,80,105,110,129,200,15,6,34,180,185,121,27,154,244,77,40,189,109,89,135,121,89,69,28,243,18,108,196,161,92,87,64,62,173,1,49,47,133,98,27,97,134,66,176,10,206,209,26,156,197,67,178,29,210,241,58,164,234,130,108,217,172,19,135,10,141,159,231,162,98,37,33,41,45,76,65,137,138,230,202,112,11,201,229,215,166,140,20,64,58,52,6,57,238,37,120,220,102,20,188,221,240,43,142,230,195,56,25,82,235,2,25,238,65,193,244,113,167,46,137,78,37,183,202,127,250,15,53,135,118,227,215,9,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("699b2038-adc5-418a-bdd1-d4d0f094a7b3"),
				Name = "Terrasoft.Mail",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("2a014b6d-9ec5-48df-a642-6190afc95cc5"),
				Name = "Terrasoft.Core",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d3124134-245b-4f52-9d71-d7d3dc858b19"),
				Name = "Terrasoft.Core.Entities",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
		}

		#endregion

		#region Methods: Public

		public override Process CreateProcess(UserConnection userConnection) {
			return new SyncImapMail(userConnection);
		}

		public override object Clone() {
			return new SyncImapMailSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("237dd150-53cf-4801-bd72-d517975107f8"));
		}

		#endregion

	}

	#endregion

	#region Class: SyncImapMail

	/// <exclude/>
	public class SyncImapMail : Terrasoft.Core.Process.Process
	{

		#region Class: ProcessLane1

		/// <exclude/>
		public class ProcessLane1 : ProcessLane
		{

			public ProcessLane1(UserConnection userConnection, SyncImapMail process)
				: base(userConnection) {
				Owner = process;
				IsUsedParentUserContexts = false;
			}

		}

		#endregion

		public SyncImapMail(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SyncImapMail";
			SchemaUId = new Guid("237dd150-53cf-4801-bd72-d517975107f8");
			Caption = Schema.Caption;
			SchemaManagerName = "ProcessSchemaManager";
			SerializeToDB = false;
			SerializeToMemory = true;
			IsLogging = false;
			UseSystemSecurityContext = false;
			_notificationCaption = () => { return new LocalizableString((Caption)); };
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("237dd150-53cf-4801-bd72-d517975107f8");
			}
		}

		private string ConditionalExpressionLogMessage {
			get {
				return "Process: SyncImapMail, Source element: {0}, Conditional flow: {1}, Expression: {2}, Result: {3}";
			}
		}

		private string DeadEndGatewayLogMessage {
			get {
				return "Process: SyncImapMail, Source element: {0}, None of the exclusive gateway conditions are met!";
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

		public virtual string PageInstanceId {
			get;
			set;
		}

		public virtual Guid ActiveTreeGridCurrentRowId {
			get;
			set;
		}

		public virtual string MailUserName {
			get;
			set;
		}

		public virtual string SenderEmailAddress {
			get;
			set;
		}

		public virtual Guid CurrentUserId {
			get;
			set;
		}

		private ProcessLane1 _lane1;
		public ProcessLane1 Lane1 {
			get {
				return _lane1 ?? ((_lane1) = new ProcessLane1(UserConnection, this));
			}
		}

		private ProcessFlowElement _start1;
		public ProcessFlowElement Start1 {
			get {
				return _start1 ?? (_start1 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartEvent",
					Name = "Start1",
					SchemaElementUId = new Guid("9ac7eaae-3d0b-4972-89fe-e58baaedcc67"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
				});
			}
		}

		private ProcessEndEvent _end1;
		public ProcessEndEvent End1 {
			get {
				return _end1 ?? (_end1 = new ProcessEndEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEndEvent",
					Name = "End1",
					SchemaElementUId = new Guid("8727a659-1a61-4eec-87bc-f4e360329497"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
				});
			}
		}

		private ProcessScriptTask _scriptTask1;
		public ProcessScriptTask ScriptTask1 {
			get {
				return _scriptTask1 ?? (_scriptTask1 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask1",
					SchemaElementUId = new Guid("1edb1620-1236-4a0a-91ef-2612ae3a0993"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
					Script = ScriptTask1Execute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[Start1.SchemaElementUId] = new Collection<ProcessFlowElement> { Start1 };
			FlowElements[End1.SchemaElementUId] = new Collection<ProcessFlowElement> { End1 };
			FlowElements[ScriptTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask1 };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "Start1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ScriptTask1", e.Context.SenderName));
						break;
					case "End1":
						CompleteProcess();
						break;
					case "ScriptTask1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("End1", e.Context.SenderName));
						break;
			}
		}

		private void WritePropertyValues(DataWriter writer, bool useAllValueSources) {
			if (!HasMapping("PageInstanceId")) {
				writer.WriteValue("PageInstanceId", PageInstanceId, null);
			}
			if (!HasMapping("ActiveTreeGridCurrentRowId")) {
				writer.WriteValue("ActiveTreeGridCurrentRowId", ActiveTreeGridCurrentRowId, Guid.Empty);
			}
			if (!HasMapping("MailUserName")) {
				writer.WriteValue("MailUserName", MailUserName, null);
			}
			if (!HasMapping("SenderEmailAddress")) {
				writer.WriteValue("SenderEmailAddress", SenderEmailAddress, null);
			}
			if (!HasMapping("CurrentUserId")) {
				writer.WriteValue("CurrentUserId", CurrentUserId, Guid.Empty);
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
			MetaPathParameterValues.Add("a54165a0-7744-4599-95de-a742bd292b40", () => PageInstanceId);
			MetaPathParameterValues.Add("57e04ecc-eb57-43da-bb56-54c46c31c8d3", () => ActiveTreeGridCurrentRowId);
			MetaPathParameterValues.Add("97325781-b945-49f7-8732-c6cfdd3aebc1", () => MailUserName);
			MetaPathParameterValues.Add("5cda26a9-50cc-4292-9c8a-84b7533a2e06", () => SenderEmailAddress);
			MetaPathParameterValues.Add("294c50f3-a39f-4a40-a91e-58e6766978b9", () => CurrentUserId);
		}

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			bool hasValueToRead = reader.HasValue();
			switch (reader.CurrentName) {
				case "PageInstanceId":
					if (!hasValueToRead) break;
					PageInstanceId = reader.GetValue<System.String>();
				break;
				case "ActiveTreeGridCurrentRowId":
					if (!hasValueToRead) break;
					ActiveTreeGridCurrentRowId = reader.GetValue<System.Guid>();
				break;
				case "MailUserName":
					if (!hasValueToRead) break;
					MailUserName = reader.GetValue<System.String>();
				break;
				case "SenderEmailAddress":
					if (!hasValueToRead) break;
					SenderEmailAddress = reader.GetValue<System.String>();
				break;
				case "CurrentUserId":
					if (!hasValueToRead) break;
					CurrentUserId = reader.GetValue<System.Guid>();
				break;
			}
		}

		protected override void WritePropertyValues(DataWriter writer) {
			base.WritePropertyValues(writer);
			WritePropertyValues(writer, true);
		}

		#endregion

		#region Methods: Public

		public virtual bool ScriptTask1Execute(ProcessExecutingContext context) {
			#if !NETSTANDARD2_0 // TODO CRM-42546
			var secureText =  UserConnection.DataValueTypeManager.GetInstanceByName("SecureText") as SecureTextDataValueType;
			var currentUserId = CurrentUserId != Guid.Empty ? CurrentUserId : UserConnection.CurrentUser.Id;
			EntitySchemaQuery query = new EntitySchemaQuery(UserConnection.EntitySchemaManager, 
					"MailboxSyncSettings");
			query.AddColumn("UserName");
			query.AddColumn("UserPassword");
			query.AddColumn("MailServer.Address");
			query.AddColumn("MailServer.Port");
			query.AddColumn("MailServer.UseSSL");
			query.AddColumn("MailServer.IsStartTls");
			query.AddColumn("SenderEmailAddress");
			query.Filters.Add(query.CreateFilterWithParameters(FilterComparisonType.Equal, 
				"SysAdminUnit.Id", currentUserId));
			query.Filters.Add(query.CreateFilterWithParameters(FilterComparisonType.Equal, 
				"MailServer.AllowEmailDownloading", true));
			query.Filters.Add(query.CreateFilterWithParameters(FilterComparisonType.Equal, 
				"EnableMailSynhronization", true));
			query.Filters.Add(query.CreateFilterWithParameters(FilterComparisonType.Equal, 
				"SenderEmailAddress", SenderEmailAddress));
			var select = query.GetSelectQuery(UserConnection);
			
			MailCredentials credentials = new MailCredentials();
			using (var dbExecutor = UserConnection.EnsureDBConnection()) {
				using (var reader = select.ExecuteReader(dbExecutor)) {
					if (!reader.Read()) {
						var parameters = new Dictionary<string, object> {
							{ "SenderEmailAddress", SenderEmailAddress },
							{ "CurrentUserId", currentUserId }
						};
						MailSynchronizer.RemoveSyncJob(UserConnection, parameters);
						throw new ArgumentException("user does not have mail account");
					}
					credentials.UserName = reader.GetColumnValue<string>(reader.GetName(0));
					string rawPassword = reader.GetColumnValue<string>(reader.GetName(1));
					if (!rawPassword.IsNullOrEmpty()) {
						credentials.UserPassword = secureText.GetValueForLoad(UserConnection, rawPassword).ToString();
					}
					credentials.Host = reader.GetColumnValue<string>(reader.GetName(2));
					credentials.Port = reader.GetColumnValue<int>(reader.GetName(3));
					credentials.UseSsl = reader.GetColumnValue<bool>(reader.GetName(4));
					credentials.StartTls = reader.GetColumnValue<bool>(reader.GetName(5));
					credentials.SenderEmailAddress = reader.GetColumnValue<string>(reader.GetName(6));
				}
			}
			using(var mailSynchronizer = new MailSynchronizer(UserConnection, credentials)) {
				mailSynchronizer.ValidateImapClient();
				mailSynchronizer.SyncImapMail();
			}
			#endif
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
			var cloneItem = (SyncImapMail)base.CloneShallow();
			cloneItem.ExecutedEventHandler = ExecutedEventHandler;
			return cloneItem;
		}

		#endregion

	}

	#endregion

}

