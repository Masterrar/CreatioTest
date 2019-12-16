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
	using Terrasoft.Configuration;
	using Terrasoft.Configuration.Calendars;
	using Terrasoft.Configuration.TermCalculationService;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Factories;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;

	#region Class: ActualizeCalculationTermsAfterStatusChangeSchema

	/// <exclude/>
	public class ActualizeCalculationTermsAfterStatusChangeSchema : Terrasoft.Core.Process.ProcessSchema
	{

		#region Constructors: Public

		public ActualizeCalculationTermsAfterStatusChangeSchema(ProcessSchemaManager processSchemaManager)
			: base(processSchemaManager) {
		}

		public ActualizeCalculationTermsAfterStatusChangeSchema(ActualizeCalculationTermsAfterStatusChangeSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "ActualizeCalculationTermsAfterStatusChange";
			UId = new Guid("12ed463d-51aa-4d38-a7ff-929a9bc8beee");
			CreatedInPackageId = new Guid("c4b72b51-b2ae-4127-a458-608f5464622c");
			CreatedInSchemaUId = Guid.Empty;
			CreatedInVersion = @"0.0.0.0";
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsLogging = false;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			SerializeToDB = false;
			SerializeToMemory = true;
			Tag = @"Business Process";
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
			ZipMethodsBody = new byte[] {  };
			ZipCompiledMethodsBody = new byte[] {  };
			RealUId = new Guid("12ed463d-51aa-4d38-a7ff-929a9bc8beee");
			Version = 0;
			PackageUId = new Guid("c3887e9c-ceb4-497a-8efb-e174aa1bf5c4");
		}

		protected virtual ProcessSchemaParameter CreateCaseRecordIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("5ba3b2b0-c2db-44e1-bf19-e058ea310f85"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("12ed463d-51aa-4d38-a7ff-929a9bc8beee"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("12ed463d-51aa-4d38-a7ff-929a9bc8beee"),
				Name = @"CaseRecordId",
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateCaseRecordIdParameter());
		}

		protected virtual void InitializeStartSignal1Parameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var recordIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("36f4dbcc-6d57-4748-9968-0246e02c237a"),
				ContainerUId = new Guid("1c01f230-4666-435f-8da3-235234c5161f"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("12ed463d-51aa-4d38-a7ff-929a9bc8beee"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("12ed463d-51aa-4d38-a7ff-929a9bc8beee"),
				Name = @"RecordId",
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			recordIdParameter.SourceValue = new ProcessSchemaParameterValue(recordIdParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(recordIdParameter);
		}

		protected virtual void InitializeStartSignal2Parameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var recordIdParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("39910edb-c399-4a13-885f-46917fb764cf"),
				ContainerUId = new Guid("8b7c37ff-f3d2-4834-907b-952c0d815039"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("12ed463d-51aa-4d38-a7ff-929a9bc8beee"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("12ed463d-51aa-4d38-a7ff-929a9bc8beee"),
				Name = @"RecordId",
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid")
			};
			recordIdParameter.SourceValue = new ProcessSchemaParameterValue(recordIdParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"",
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(recordIdParameter);
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
			ProcessSchemaScriptTask scripttask1 = CreateScriptTask1ScriptTask();
			FlowElements.Add(scripttask1);
			ProcessSchemaStartSignalEvent startsignal2 = CreateStartSignal2StartSignalEvent();
			FlowElements.Add(startsignal2);
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("257986d2-a8ba-4d76-ba8c-9f0e519ca699"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("c3887e9c-ceb4-497a-8efb-e174aa1bf5c4"),
				CreatedInSchemaUId = new Guid("12ed463d-51aa-4d38-a7ff-929a9bc8beee"),
				CurveCenterPosition = new Point(0, 0),
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("12ed463d-51aa-4d38-a7ff-929a9bc8beee"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("1c01f230-4666-435f-8da3-235234c5161f"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("162d1904-7c40-4313-8c25-e5f44d73777a"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("ad18dab0-8b0c-4346-87fd-efcbec3397be"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("c3887e9c-ceb4-497a-8efb-e174aa1bf5c4"),
				CreatedInSchemaUId = new Guid("12ed463d-51aa-4d38-a7ff-929a9bc8beee"),
				CurveCenterPosition = new Point(0, 0),
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("12ed463d-51aa-4d38-a7ff-929a9bc8beee"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("162d1904-7c40-4313-8c25-e5f44d73777a"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("e58a168a-5c48-45e1-81bd-524ca5198111"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3",
				UId = new Guid("d7441161-8a76-4f69-8caa-abfc6b5ce7a9"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("c3887e9c-ceb4-497a-8efb-e174aa1bf5c4"),
				CreatedInSchemaUId = new Guid("12ed463d-51aa-4d38-a7ff-929a9bc8beee"),
				CurveCenterPosition = new Point(0, 0),
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("12ed463d-51aa-4d38-a7ff-929a9bc8beee"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("8b7c37ff-f3d2-4834-907b-952c0d815039"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("162d1904-7c40-4313-8c25-e5f44d73777a"),
				TargetSequenceFlowPointLocalPosition = new Point(0, -1),
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(362, 293));
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("8e74ef7a-e4d0-49c7-a6ab-71859ce761e3"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("c3887e9c-ceb4-497a-8efb-e174aa1bf5c4"),
				CreatedInSchemaUId = new Guid("12ed463d-51aa-4d38-a7ff-929a9bc8beee"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("12ed463d-51aa-4d38-a7ff-929a9bc8beee"),
				Name = @"LaneSet1",
				Position = new Point(0, 0),
				Size = new Size(0, 0)
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("9368e760-06e3-4a5f-a5fb-ccb80b19301b"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("8e74ef7a-e4d0-49c7-a6ab-71859ce761e3"),
				CreatedInOwnerSchemaUId = new Guid("12ed463d-51aa-4d38-a7ff-929a9bc8beee"),
				CreatedInPackageId = new Guid("c3887e9c-ceb4-497a-8efb-e174aa1bf5c4"),
				CreatedInSchemaUId = new Guid("12ed463d-51aa-4d38-a7ff-929a9bc8beee"),
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("12ed463d-51aa-4d38-a7ff-929a9bc8beee"),
				Name = @"Lane1",
				Position = new Point(0, 0),
				Size = new Size(0, 0)
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaTerminateEvent CreateTerminateEvent1TerminateEvent() {
			ProcessSchemaTerminateEvent schemaTerminateEvent = new ProcessSchemaTerminateEvent(this) {
				UId = new Guid("e58a168a-5c48-45e1-81bd-524ca5198111"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("9368e760-06e3-4a5f-a5fb-ccb80b19301b"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("c3887e9c-ceb4-497a-8efb-e174aa1bf5c4"),
				CreatedInSchemaUId = new Guid("12ed463d-51aa-4d38-a7ff-929a9bc8beee"),
				EntitySchemaUId = Guid.Empty,
				IsLogging = true,
				ManagerItemUId = new Guid("1bd93619-0574-454e-bb4e-cf53b9eb9470"),
				ModifiedInSchemaUId = new Guid("12ed463d-51aa-4d38-a7ff-929a9bc8beee"),
				Name = @"TerminateEvent1",
				Position = new Point(600, 184),
				SerializeToDB = false,
				Size = new Size(27, 27),
				ThrowToBase = false
			};
			
			return schemaTerminateEvent;
		}

		protected virtual ProcessSchemaStartSignalEvent CreateStartSignal1StartSignalEvent() {
			ProcessSchemaStartSignalEvent schemaStartSignalEvent = new ProcessSchemaStartSignalEvent(this) {	UId = new Guid("1c01f230-4666-435f-8da3-235234c5161f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("9368e760-06e3-4a5f-a5fb-ccb80b19301b"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("c3887e9c-ceb4-497a-8efb-e174aa1bf5c4"),
				CreatedInSchemaUId = new Guid("12ed463d-51aa-4d38-a7ff-929a9bc8beee"),
				EntitySchemaUId = new Guid("117d32f9-8275-4534-8411-1c66115ce9cd"),
				EntitySignal = EntityChangeType.Updated,
				HasEntityColumnChange = true,
				HasEntityFilters = true,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = true,
				ManagerItemUId = new Guid("1129e72f-0e8c-445a-b2ea-463517e86395"),
				ModifiedInSchemaUId = new Guid("12ed463d-51aa-4d38-a7ff-929a9bc8beee"),
				Name = @"StartSignal1",
				NewEntityChangedColumns = false,
				Position = new Point(73, 184),
				SerializeToDB = false,
				Size = new Size(27, 27),
				WaitingEntitySignal = true,
				WaitingRandomSignal = false
			};
			schemaStartSignalEvent.EntityChangedColumns.Add("a71adaea-3464-4dee-bb4f-c7a535450ad7");
			InitializeStartSignal1Parameters(schemaStartSignalEvent);
			return schemaStartSignalEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateScriptTask1ScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("162d1904-7c40-4313-8c25-e5f44d73777a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("9368e760-06e3-4a5f-a5fb-ccb80b19301b"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("c3887e9c-ceb4-497a-8efb-e174aa1bf5c4"),
				CreatedInSchemaUId = new Guid("12ed463d-51aa-4d38-a7ff-929a9bc8beee"),
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("12ed463d-51aa-4d38-a7ff-929a9bc8beee"),
				Name = @"ScriptTask1",
				Position = new Point(328, 170),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,83,77,79,195,48,12,61,211,95,17,118,202,36,84,9,174,99,72,80,182,137,3,8,173,192,221,74,189,17,169,77,39,55,25,170,16,255,29,123,91,7,203,62,14,136,158,154,23,191,103,251,217,153,4,91,168,12,26,156,162,169,169,120,40,212,80,21,56,131,80,122,61,225,187,254,32,177,51,165,115,15,228,115,59,119,80,94,166,219,208,243,161,146,152,116,84,45,124,219,87,159,201,89,164,116,144,54,72,190,98,205,171,191,105,94,237,104,46,129,212,2,8,42,244,72,83,132,2,137,195,179,18,154,102,12,198,215,212,166,19,244,215,34,151,65,105,66,9,222,214,238,121,151,113,163,147,51,249,28,126,168,172,118,141,167,32,212,91,154,135,10,157,215,189,208,32,241,133,67,35,236,222,133,122,221,1,250,108,152,20,82,216,213,17,168,93,37,104,184,146,168,54,41,102,125,167,127,119,184,225,27,134,94,144,170,174,82,28,57,207,90,181,117,254,88,83,71,194,255,163,163,28,105,105,205,42,195,20,155,5,171,160,162,238,103,120,170,216,116,139,73,64,163,99,95,226,108,105,22,136,184,44,65,165,179,205,241,94,4,108,133,186,243,151,49,235,219,220,188,99,5,143,224,96,190,26,118,164,53,218,15,218,103,51,237,128,152,228,126,96,179,192,25,188,107,159,120,112,186,39,38,247,56,255,90,118,195,18,48,146,72,51,194,181,9,12,233,200,205,245,123,250,225,166,99,244,230,125,76,117,117,127,183,187,8,253,132,151,255,87,96,206,110,212,101,168,220,27,148,129,203,201,249,32,146,226,13,79,173,155,71,218,225,226,23,167,59,37,209,13,51,150,224,13,53,199,36,96,201,83,144,247,70,232,3,57,197,251,132,131,111,215,174,183,126,71,4,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaStartSignalEvent CreateStartSignal2StartSignalEvent() {
			ProcessSchemaStartSignalEvent schemaStartSignalEvent = new ProcessSchemaStartSignalEvent(this) {	UId = new Guid("8b7c37ff-f3d2-4834-907b-952c0d815039"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("9368e760-06e3-4a5f-a5fb-ccb80b19301b"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("c3887e9c-ceb4-497a-8efb-e174aa1bf5c4"),
				CreatedInSchemaUId = new Guid("12ed463d-51aa-4d38-a7ff-929a9bc8beee"),
				EntitySchemaUId = new Guid("117d32f9-8275-4534-8411-1c66115ce9cd"),
				EntitySignal = EntityChangeType.Inserted,
				HasEntityColumnChange = false,
				HasEntityFilters = true,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = true,
				ManagerItemUId = new Guid("1129e72f-0e8c-445a-b2ea-463517e86395"),
				ModifiedInSchemaUId = new Guid("12ed463d-51aa-4d38-a7ff-929a9bc8beee"),
				Name = @"StartSignal2",
				NewEntityChangedColumns = false,
				Position = new Point(73, 280),
				SerializeToDB = false,
				Size = new Size(27, 27),
				WaitingEntitySignal = true,
				WaitingRandomSignal = false
			};
			InitializeStartSignal2Parameters(schemaStartSignalEvent);
			return schemaStartSignalEvent;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("a5186d3c-ea57-4045-a2d2-e151dc44a44d"),
				Name = "Terrasoft.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("c4b72b51-b2ae-4127-a458-608f5464622c")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("bc8d9945-ef06-4931-a611-57ed410d5cec"),
				Name = "Terrasoft.Core.Factories",
				Alias = "",
				CreatedInPackageId = new Guid("c4b72b51-b2ae-4127-a458-608f5464622c")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("f939aa76-5111-42e9-9ef2-3cb58255e74a"),
				Name = "Terrasoft.Configuration.TermCalculationService",
				Alias = "",
				CreatedInPackageId = new Guid("c4b72b51-b2ae-4127-a458-608f5464622c")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("844f89bb-2c63-4486-a373-26af8150884b"),
				Name = "Terrasoft.Core",
				Alias = "",
				CreatedInPackageId = new Guid("c4b72b51-b2ae-4127-a458-608f5464622c")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("b014b92f-05c4-4e71-827a-e779ce1bcbc1"),
				Name = "System",
				Alias = "",
				CreatedInPackageId = new Guid("c4b72b51-b2ae-4127-a458-608f5464622c")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("cd749e26-028e-4427-9d4d-f4c5ee9c4de8"),
				Name = "System.Collections.Generic",
				Alias = "",
				CreatedInPackageId = new Guid("c4b72b51-b2ae-4127-a458-608f5464622c")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("57b0a18a-68e6-475c-b9d5-9ea901f77c8e"),
				Name = "Terrasoft.Configuration.Calendars",
				Alias = "",
				CreatedInPackageId = new Guid("c4b72b51-b2ae-4127-a458-608f5464622c")
			});
		}

		#endregion

		#region Methods: Public

		public override Process CreateProcess(UserConnection userConnection) {
			return new ActualizeCalculationTermsAfterStatusChange(userConnection);
		}

		public override object Clone() {
			return new ActualizeCalculationTermsAfterStatusChangeSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("12ed463d-51aa-4d38-a7ff-929a9bc8beee"));
		}

		#endregion

	}

	#endregion

	#region Class: ActualizeCalculationTermsAfterStatusChange

	/// <exclude/>
	public class ActualizeCalculationTermsAfterStatusChange : Terrasoft.Core.Process.Process
	{

		#region Class: ProcessLane1

		/// <exclude/>
		public class ProcessLane1 : ProcessLane
		{

			public ProcessLane1(UserConnection userConnection, ActualizeCalculationTermsAfterStatusChange process)
				: base(userConnection) {
				Owner = process;
				IsUsedParentUserContexts = false;
			}

		}

		#endregion

		public ActualizeCalculationTermsAfterStatusChange(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "ActualizeCalculationTermsAfterStatusChange";
			SchemaUId = new Guid("12ed463d-51aa-4d38-a7ff-929a9bc8beee");
			Caption = Schema.Caption;
			SchemaManagerName = "ProcessSchemaManager";
			SerializeToDB = false;
			SerializeToMemory = true;
			IsLogging = false;
			_notificationCaption = () => { return new LocalizableString((Caption)); };
			InitializeFlowElements();
		}

		#region Properties: Private

		private  Guid InternalSchemaUId {
			get {
				return new Guid("12ed463d-51aa-4d38-a7ff-929a9bc8beee");
			}
		}

		#endregion

		#region Properties: Public

		private Func<string> _notificationCaption;
		public  virtual string NotificationCaption {
			get {
				return (_notificationCaption ?? (_notificationCaption = () => null)).Invoke();
			}
			set {
				_notificationCaption = () => { return value; };
			}
		}

		public  virtual Guid CaseRecordId {
			get;
			set;
		}

		private ProcessLane1 _lane1;
		public  ProcessLane1 Lane1 {
			get {
				return _lane1 ?? ((_lane1) = new ProcessLane1(UserConnection, this));
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
					SchemaElementUId = new Guid("e58a168a-5c48-45e1-81bd-524ca5198111"),
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
					SchemaElementUId = new Guid("1c01f230-4666-435f-8da3-235234c5161f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _scriptTask1;
		public  ProcessScriptTask ScriptTask1 {
			get {
				return _scriptTask1 ?? (_scriptTask1 = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "ScriptTask1",
					SchemaElementUId = new Guid("162d1904-7c40-4313-8c25-e5f44d73777a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
					Script = ScriptTask1Execute,
				});
			}
		}

		private ProcessStartSignalEvent _startSignal2;
		public  ProcessStartSignalEvent StartSignal2 {
			get {
				return _startSignal2 ?? (_startSignal2 = new ProcessStartSignalEvent(UserConnection) {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartSignalEvent",
					Name = "StartSignal2",
					SerializeToDB = false,
					IsLogging = true,
					SchemaElementUId = new Guid("8b7c37ff-f3d2-4834-907b-952c0d815039"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[TerminateEvent1.SchemaElementUId] = new Collection<ProcessFlowElement> { TerminateEvent1 };
			FlowElements[StartSignal1.SchemaElementUId] = new Collection<ProcessFlowElement> { StartSignal1 };
			FlowElements[ScriptTask1.SchemaElementUId] = new Collection<ProcessFlowElement> { ScriptTask1 };
			FlowElements[StartSignal2.SchemaElementUId] = new Collection<ProcessFlowElement> { StartSignal2 };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "TerminateEvent1":
						CompleteProcess();
						break;
					case "StartSignal1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ScriptTask1", e.Context.SenderName));
						break;
					case "ScriptTask1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("TerminateEvent1", e.Context.SenderName));
						break;
					case "StartSignal2":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("ScriptTask1", e.Context.SenderName));
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
			MetaPathParameterValues.Add("5ba3b2b0-c2db-44e1-bf19-e058ea310f85", () => CaseRecordId);
			MetaPathParameterValues.Add("36f4dbcc-6d57-4748-9968-0246e02c237a", () => StartSignal1.RecordId);
			MetaPathParameterValues.Add("39910edb-c399-4a13-885f-46917fb764cf", () => StartSignal2.RecordId);
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

		public virtual bool ScriptTask1Execute(ProcessExecutingContext context) {
			Guid CaseRecordId = default(Guid);
			if (StartSignal1.RecordId != Guid.Empty) {
				CaseRecordId = StartSignal1.RecordId;
			}
			if (StartSignal2.RecordId != Guid.Empty) {
				CaseRecordId = StartSignal2.RecordId;
			}
			var parameterReader = ClassFactory.Get<CaseCalculationParameterReader>(
								new ConstructorArgument("userConnection", UserConnection));
			var dictionaryParams = parameterReader.GetParams(CaseRecordId);
			var caseTermCalculateEntryPoint = ClassFactory.Get<CaseTermCalculateEntryPoint>(
								new ConstructorArgument("userConnection", UserConnection));
			ServiceTermResponse response = caseTermCalculateEntryPoint.CalculateTerms(dictionaryParams, UserConnection.CurrentUser.GetCurrentDateTime());
			var entitySchemaManager = UserConnection.EntitySchemaManager;
			var entitySchema = entitySchemaManager.GetInstanceByName("Case");
			Entity entityCase = entitySchema.CreateEntity(UserConnection);
			if (entityCase.FetchFromDB(CaseRecordId))
			{
				entityCase.SetColumnValue("SolutionDate", response.SolutionTime);
				entityCase.SetColumnValue("ResponseDate", response.ReactionTime);
				entityCase.Save();
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
			var cloneItem = (ActualizeCalculationTermsAfterStatusChange)base.CloneShallow();
			cloneItem.ExecutedEventHandler = ExecutedEventHandler;
			return cloneItem;
		}

		#endregion

	}

	#endregion

}

