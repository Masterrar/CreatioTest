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
	using System.Web;
	using Terrasoft.Common;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Factories;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;

	#region Class: SendImmediatelyTriggeredEmailProcessSchema

	/// <exclude/>
	public class SendImmediatelyTriggeredEmailProcessSchema : Terrasoft.Core.Process.ProcessSchema
	{

		#region Constructors: Public

		public SendImmediatelyTriggeredEmailProcessSchema(ProcessSchemaManager processSchemaManager)
			: base(processSchemaManager) {
		}

		public SendImmediatelyTriggeredEmailProcessSchema(SendImmediatelyTriggeredEmailProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "SendImmediatelyTriggeredEmailProcess";
			UId = new Guid("a09dcafb-d873-4cb8-a919-bd00c88e4ae9");
			CreatedInPackageId = new Guid("c0cb070c-6408-4a02-b2a7-9cfd918167e4");
			CreatedInSchemaUId = Guid.Empty;
			CreatedInVersion = @"7.6.0.0";
			CultureName = @"en-US";
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsLogging = false;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			SerializeToDB = false;
			SerializeToMemory = false;
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
			ZipMethodsBody = new byte[] {  };
			ZipCompiledMethodsBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,84,223,111,218,48,16,126,166,82,255,7,139,39,71,138,172,109,143,180,171,196,24,237,208,128,73,80,158,166,61,184,201,53,181,230,31,145,237,208,33,196,255,190,179,19,19,178,117,19,72,38,247,221,125,247,221,119,14,215,87,117,243,36,69,65,246,194,250,134,75,178,55,162,36,91,208,229,92,113,33,105,70,142,215,87,35,111,15,241,220,115,75,28,98,159,185,7,242,145,132,227,81,40,96,59,95,172,205,235,77,151,97,161,16,181,0,237,29,230,104,120,37,75,225,252,237,167,70,254,140,156,155,4,47,244,179,185,163,89,40,235,75,216,180,44,105,40,122,59,63,202,24,45,74,100,158,25,237,121,225,23,101,30,66,49,21,107,45,56,215,131,49,26,241,46,176,185,44,197,7,132,78,89,18,174,176,150,87,16,251,180,202,23,218,121,174,253,170,7,58,71,70,211,186,70,219,184,23,70,239,172,196,244,97,32,246,76,101,161,229,121,156,78,111,135,109,134,224,166,67,55,151,22,246,230,4,181,103,177,152,46,116,181,5,187,23,69,216,198,76,114,231,238,113,44,99,15,236,1,252,237,106,144,113,23,93,197,201,157,183,77,72,154,218,170,81,200,74,199,141,3,139,128,134,34,168,31,231,100,55,8,100,209,160,97,63,22,174,72,55,3,189,240,45,166,206,184,170,185,168,244,23,144,53,88,182,2,91,65,218,150,246,38,193,116,216,38,39,9,64,19,122,75,182,30,234,16,56,175,59,180,56,17,116,186,120,33,116,254,171,128,58,84,19,104,23,179,52,213,220,90,99,233,56,30,241,186,18,161,20,148,2,111,171,60,164,37,51,28,19,34,85,252,134,207,31,111,66,37,205,19,151,147,201,204,40,101,52,67,226,10,231,103,11,252,65,208,222,240,12,182,187,14,97,33,50,6,112,17,45,66,184,251,31,5,118,22,207,132,166,34,188,110,141,148,45,217,153,232,31,229,120,174,184,198,25,44,235,117,248,23,225,216,154,171,56,211,104,153,40,90,174,118,204,208,15,151,31,21,184,53,182,251,102,231,170,246,7,186,69,75,208,194,175,112,200,90,5,125,0,41,30,26,81,178,53,188,134,147,102,236,209,108,35,7,29,175,199,157,127,22,124,99,245,160,215,27,126,198,127,150,243,122,90,33,105,27,57,249,107,145,3,75,47,252,70,254,54,204,46,137,216,189,177,138,227,93,62,190,59,77,200,247,227,251,211,15,114,252,112,186,193,45,159,157,201,73,63,87,158,58,103,89,18,252,27,89,5,121,44,11,5,0,0 };
			RealUId = new Guid("a09dcafb-d873-4cb8-a919-bd00c88e4ae9");
			Version = 0;
			PackageUId = new Guid("f96c8402-9614-48d5-988e-1f34fea20081");
		}

		protected virtual ProcessSchemaParameter CreateCampaignIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("85d945df-7ab5-4264-a3c7-f611954a399a"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("a09dcafb-d873-4cb8-a919-bd00c88e4ae9"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("a09dcafb-d873-4cb8-a919-bd00c88e4ae9"),
				Name = @"CampaignId",
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateBulkEmailIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("e60bee11-c357-4094-b80e-1e60dc4ffd76"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("a09dcafb-d873-4cb8-a919-bd00c88e4ae9"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("a09dcafb-d873-4cb8-a919-bd00c88e4ae9"),
				Name = @"BulkEmailId",
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateBulkEmailStepIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("3b00293a-64b5-44ae-9a0f-7b6b6d58aa1d"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("a09dcafb-d873-4cb8-a919-bd00c88e4ae9"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("a09dcafb-d873-4cb8-a919-bd00c88e4ae9"),
				Name = @"BulkEmailStepId",
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateContactIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("2544c42e-6fc8-4a6e-b641-d732f7f86c4a"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("a09dcafb-d873-4cb8-a919-bd00c88e4ae9"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("a09dcafb-d873-4cb8-a919-bd00c88e4ae9"),
				Name = @"ContactId",
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected virtual ProcessSchemaParameter CreateContactEmailParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("2f6dcf43-aa4d-43f8-964b-e1058549db84"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("a09dcafb-d873-4cb8-a919-bd00c88e4ae9"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("a09dcafb-d873-4cb8-a919-bd00c88e4ae9"),
				Name = @"ContactEmail",
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText"),
			};
		}

		protected virtual ProcessSchemaParameter CreateBulkEmailRIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("bd524a10-c122-4d51-b9eb-818c1cfe77be"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("a09dcafb-d873-4cb8-a919-bd00c88e4ae9"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("a09dcafb-d873-4cb8-a919-bd00c88e4ae9"),
				Name = @"BulkEmailRId",
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer"),
			};
		}

		protected virtual ProcessSchemaParameter CreateContactRIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("f780e797-a0f6-48e5-99ec-d7eace686960"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("a09dcafb-d873-4cb8-a919-bd00c88e4ae9"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("a09dcafb-d873-4cb8-a919-bd00c88e4ae9"),
				Name = @"ContactRId",
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer"),
			};
		}

		protected virtual ProcessSchemaParameter CreateApplicationUrlParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("387d31a1-145f-4f8d-8f19-f74c35ddce78"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("a09dcafb-d873-4cb8-a919-bd00c88e4ae9"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("a09dcafb-d873-4cb8-a919-bd00c88e4ae9"),
				Name = @"ApplicationUrl",
				DataValueType = DataValueTypeManager.GetInstanceByName("MediumText"),
			};
		}

		protected virtual ProcessSchemaParameter CreateLoggerParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("2963f4f8-9d7b-492a-961c-75325ea3f492"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("a09dcafb-d873-4cb8-a919-bd00c88e4ae9"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("a09dcafb-d873-4cb8-a919-bd00c88e4ae9"),
				Name = @"Logger",
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			};
		}

		protected virtual ProcessSchemaParameter CreateSessionKeyParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("a62e66d5-5e14-42e0-8b16-1104efe6697a"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("a09dcafb-d873-4cb8-a919-bd00c88e4ae9"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("a09dcafb-d873-4cb8-a919-bd00c88e4ae9"),
				Name = @"SessionKey",
				DataValueType = DataValueTypeManager.GetInstanceByName("ShortText"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateCampaignIdParameter());
			Parameters.Add(CreateBulkEmailIdParameter());
			Parameters.Add(CreateBulkEmailStepIdParameter());
			Parameters.Add(CreateContactIdParameter());
			Parameters.Add(CreateContactEmailParameter());
			Parameters.Add(CreateBulkEmailRIdParameter());
			Parameters.Add(CreateContactRIdParameter());
			Parameters.Add(CreateApplicationUrlParameter());
			Parameters.Add(CreateLoggerParameter());
			Parameters.Add(CreateSessionKeyParameter());
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet1 = CreateLaneSet1LaneSet();
			LaneSets.Add(schemaLaneSet1);
			ProcessSchemaLane schemaLane1 = CreateLane1Lane();
			schemaLaneSet1.Lanes.Add(schemaLane1);
			ProcessSchemaStartEvent start1 = CreateStart1StartEvent();
			FlowElements.Add(start1);
			ProcessSchemaTerminateEvent terminate1 = CreateTerminate1TerminateEvent();
			FlowElements.Add(terminate1);
			ProcessSchemaScriptTask sendemailscripttask = CreateSendEmailScriptTaskScriptTask();
			FlowElements.Add(sendemailscripttask);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("f42246f1-51de-4704-bd65-76426cca40a0"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("c0cb070c-6408-4a02-b2a7-9cfd918167e4"),
				CreatedInSchemaUId = new Guid("a09dcafb-d873-4cb8-a919-bd00c88e4ae9"),
				CurveCenterPosition = new Point(373, 203),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("a09dcafb-d873-4cb8-a919-bd00c88e4ae9"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("eb76617b-474b-40d3-8f2e-3580df6254e1"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("c0156357-39c0-4c85-8b78-768090cc9239"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("02fc9bfb-6221-4bd2-b64c-882120920eff"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("c0cb070c-6408-4a02-b2a7-9cfd918167e4"),
				CreatedInSchemaUId = new Guid("a09dcafb-d873-4cb8-a919-bd00c88e4ae9"),
				CurveCenterPosition = new Point(373, 203),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("a09dcafb-d873-4cb8-a919-bd00c88e4ae9"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("c0156357-39c0-4c85-8b78-768090cc9239"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("0fd9a01d-d611-490c-8896-6ce8b5c06573"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("414c22c4-4416-4668-9b85-458fb0254378"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("c0cb070c-6408-4a02-b2a7-9cfd918167e4"),
				CreatedInSchemaUId = new Guid("a09dcafb-d873-4cb8-a919-bd00c88e4ae9"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("a09dcafb-d873-4cb8-a919-bd00c88e4ae9"),
				Name = @"LaneSet1",
				Position = new Point(5, 5),
				Size = new Size(0, 0)
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("d5325679-4d7f-4d02-9ad6-c8452f19c750"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("414c22c4-4416-4668-9b85-458fb0254378"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("c0cb070c-6408-4a02-b2a7-9cfd918167e4"),
				CreatedInSchemaUId = new Guid("a09dcafb-d873-4cb8-a919-bd00c88e4ae9"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("a09dcafb-d873-4cb8-a919-bd00c88e4ae9"),
				Name = @"Lane1",
				Position = new Point(29, 0),
				Size = new Size(0, 0)
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaStartEvent CreateStart1StartEvent() {
			ProcessSchemaStartEvent schemaStartEvent = new ProcessSchemaStartEvent(this) {
				UId = new Guid("eb76617b-474b-40d3-8f2e-3580df6254e1"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d5325679-4d7f-4d02-9ad6-c8452f19c750"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("c0cb070c-6408-4a02-b2a7-9cfd918167e4"),
				CreatedInSchemaUId = new Guid("a09dcafb-d873-4cb8-a919-bd00c88e4ae9"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsInterrupting = false,
				IsLogging = true,
				ManagerItemUId = new Guid("53818048-7868-48f6-ada0-0ebaa65af628"),
				ModifiedInSchemaUId = new Guid("a09dcafb-d873-4cb8-a919-bd00c88e4ae9"),
				Name = @"Start1",
				Position = new Point(50, 184),
				SerializeToDB = false,
				Size = new Size(27, 27)
			};
			
			return schemaStartEvent;
		}

		protected virtual ProcessSchemaTerminateEvent CreateTerminate1TerminateEvent() {
			ProcessSchemaTerminateEvent schemaTerminateEvent = new ProcessSchemaTerminateEvent(this) {
				UId = new Guid("0fd9a01d-d611-490c-8896-6ce8b5c06573"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d5325679-4d7f-4d02-9ad6-c8452f19c750"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("c0cb070c-6408-4a02-b2a7-9cfd918167e4"),
				CreatedInSchemaUId = new Guid("a09dcafb-d873-4cb8-a919-bd00c88e4ae9"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = true,
				ManagerItemUId = new Guid("1bd93619-0574-454e-bb4e-cf53b9eb9470"),
				ModifiedInSchemaUId = new Guid("a09dcafb-d873-4cb8-a919-bd00c88e4ae9"),
				Name = @"Terminate1",
				Position = new Point(600, 184),
				SerializeToDB = false,
				Size = new Size(27, 27),
				ThrowToBase = false
			};
			
			return schemaTerminateEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateSendEmailScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("c0156357-39c0-4c85-8b78-768090cc9239"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("d5325679-4d7f-4d02-9ad6-c8452f19c750"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("c0cb070c-6408-4a02-b2a7-9cfd918167e4"),
				CreatedInSchemaUId = new Guid("a09dcafb-d873-4cb8-a919-bd00c88e4ae9"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("a09dcafb-d873-4cb8-a919-bd00c88e4ae9"),
				Name = @"SendEmailScriptTask",
				Position = new Point(295, 170),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,78,205,75,113,205,77,204,204,209,208,180,230,229,42,74,45,41,45,202,83,40,41,42,77,181,6,0,60,56,4,160,26,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e4d8fa67-fff7-4036-bd67-61e03d6e2b54"),
				Name = "Terrasoft.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("c0cb070c-6408-4a02-b2a7-9cfd918167e4")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("2d11a6f5-135b-474d-9c77-28e78be687aa"),
				Name = "Terrasoft.Core.Factories",
				Alias = "",
				CreatedInPackageId = new Guid("c0cb070c-6408-4a02-b2a7-9cfd918167e4")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("2248d4cd-8afa-4dcd-9f6e-3dc03a4c041f"),
				Name = "System.Web",
				Alias = "",
				CreatedInPackageId = new Guid("16671048-241e-49b4-b1e7-a6fbc820ffe7")
			});
		}

		#endregion

		#region Methods: Public

		public override Process CreateProcess(UserConnection userConnection) {
			return new SendImmediatelyTriggeredEmailProcess(userConnection);
		}

		public override object Clone() {
			return new SendImmediatelyTriggeredEmailProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a09dcafb-d873-4cb8-a919-bd00c88e4ae9"));
		}

		#endregion

	}

	#endregion

	#region Class: SendImmediatelyTriggeredEmailProcess

	/// <exclude/>
	public class SendImmediatelyTriggeredEmailProcess : Terrasoft.Core.Process.Process
	{

		#region Class: ProcessLane1

		/// <exclude/>
		public class ProcessLane1 : ProcessLane
		{

			public ProcessLane1(UserConnection userConnection, SendImmediatelyTriggeredEmailProcess process)
				: base(userConnection) {
				Owner = process;
				IsUsedParentUserContexts = false;
			}

		}

		#endregion

		public SendImmediatelyTriggeredEmailProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SendImmediatelyTriggeredEmailProcess";
			SchemaUId = new Guid("a09dcafb-d873-4cb8-a919-bd00c88e4ae9");
			Caption = Schema.Caption;
			SchemaManagerName = "ProcessSchemaManager";
			SerializeToDB = false;
			SerializeToMemory = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private  Guid InternalSchemaUId {
			get {
				return new Guid("a09dcafb-d873-4cb8-a919-bd00c88e4ae9");
			}
		}

		#endregion

		#region Properties: Public

		public  virtual Guid CampaignId {
			get;
			set;
		}

		public  virtual Guid BulkEmailId {
			get;
			set;
		}

		public  virtual Guid BulkEmailStepId {
			get;
			set;
		}

		public  virtual Guid ContactId {
			get;
			set;
		}

		public  virtual string ContactEmail {
			get;
			set;
		}

		public  virtual int BulkEmailRId {
			get;
			set;
		}

		public  virtual int ContactRId {
			get;
			set;
		}

		public  virtual string ApplicationUrl {
			get;
			set;
		}

		public  virtual Object Logger {
			get;
			set;
		}

		public  virtual string SessionKey {
			get;
			set;
		}

		private ProcessLane1 _lane1;
		public  ProcessLane1 Lane1 {
			get {
				return _lane1 ?? ((_lane1) = new ProcessLane1(UserConnection, this));
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
					SchemaElementUId = new Guid("eb76617b-474b-40d3-8f2e-3580df6254e1"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
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
					SchemaElementUId = new Guid("0fd9a01d-d611-490c-8896-6ce8b5c06573"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
				});
			}
		}

		private ProcessScriptTask _sendEmailScriptTask;
		public  ProcessScriptTask SendEmailScriptTask {
			get {
				return _sendEmailScriptTask ?? (_sendEmailScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "SendEmailScriptTask",
					SchemaElementUId = new Guid("c0156357-39c0-4c85-8b78-768090cc9239"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
					Script = SendEmailScriptTaskExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[Start1.SchemaElementUId] = new Collection<ProcessFlowElement> { Start1 };
			FlowElements[Terminate1.SchemaElementUId] = new Collection<ProcessFlowElement> { Terminate1 };
			FlowElements[SendEmailScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { SendEmailScriptTask };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "Start1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("SendEmailScriptTask", e.Context.SenderName));
						break;
					case "Terminate1":
						CompleteProcess();
						break;
					case "SendEmailScriptTask":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("Terminate1", e.Context.SenderName));
						break;
			}
		}

		private void WritePropertyValues(DataWriter writer, bool useAllValueSources) {
			if (!HasMapping("CampaignId")) {
				writer.WriteValue("CampaignId", CampaignId, Guid.Empty);
			}
			if (!HasMapping("BulkEmailId")) {
				writer.WriteValue("BulkEmailId", BulkEmailId, Guid.Empty);
			}
			if (!HasMapping("BulkEmailStepId")) {
				writer.WriteValue("BulkEmailStepId", BulkEmailStepId, Guid.Empty);
			}
			if (!HasMapping("ContactId")) {
				writer.WriteValue("ContactId", ContactId, Guid.Empty);
			}
			if (!HasMapping("ContactEmail")) {
				writer.WriteValue("ContactEmail", ContactEmail, null);
			}
			if (!HasMapping("BulkEmailRId")) {
				writer.WriteValue("BulkEmailRId", BulkEmailRId, 0);
			}
			if (!HasMapping("ContactRId")) {
				writer.WriteValue("ContactRId", ContactRId, 0);
			}
			if (!HasMapping("ApplicationUrl")) {
				writer.WriteValue("ApplicationUrl", ApplicationUrl, null);
			}
			if (Logger != null) {
				if (Logger.GetType().IsSerializable ||
					Logger.GetType().GetInterface("ISerializable") != null) {
					writer.WriteSerializableObjectValue("Logger", Logger, null);
				}
			}
			if (!HasMapping("SessionKey")) {
				writer.WriteValue("SessionKey", SessionKey, null);
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
			MetaPathParameterValues.Add("85d945df-7ab5-4264-a3c7-f611954a399a", () => CampaignId);
			MetaPathParameterValues.Add("e60bee11-c357-4094-b80e-1e60dc4ffd76", () => BulkEmailId);
			MetaPathParameterValues.Add("3b00293a-64b5-44ae-9a0f-7b6b6d58aa1d", () => BulkEmailStepId);
			MetaPathParameterValues.Add("2544c42e-6fc8-4a6e-b641-d732f7f86c4a", () => ContactId);
			MetaPathParameterValues.Add("2f6dcf43-aa4d-43f8-964b-e1058549db84", () => ContactEmail);
			MetaPathParameterValues.Add("bd524a10-c122-4d51-b9eb-818c1cfe77be", () => BulkEmailRId);
			MetaPathParameterValues.Add("f780e797-a0f6-48e5-99ec-d7eace686960", () => ContactRId);
			MetaPathParameterValues.Add("387d31a1-145f-4f8d-8f19-f74c35ddce78", () => ApplicationUrl);
			MetaPathParameterValues.Add("2963f4f8-9d7b-492a-961c-75325ea3f492", () => Logger);
			MetaPathParameterValues.Add("a62e66d5-5e14-42e0-8b16-1104efe6697a", () => SessionKey);
		}

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			bool hasValueToRead = reader.HasValue();
			switch (reader.CurrentName) {
				case "CampaignId":
					if (!hasValueToRead) break;
					CampaignId = reader.GetValue<System.Guid>();
				break;
				case "BulkEmailId":
					if (!hasValueToRead) break;
					BulkEmailId = reader.GetValue<System.Guid>();
				break;
				case "BulkEmailStepId":
					if (!hasValueToRead) break;
					BulkEmailStepId = reader.GetValue<System.Guid>();
				break;
				case "ContactId":
					if (!hasValueToRead) break;
					ContactId = reader.GetValue<System.Guid>();
				break;
				case "ContactEmail":
					if (!hasValueToRead) break;
					ContactEmail = reader.GetValue<System.String>();
				break;
				case "BulkEmailRId":
					if (!hasValueToRead) break;
					BulkEmailRId = reader.GetValue<System.Int32>();
				break;
				case "ContactRId":
					if (!hasValueToRead) break;
					ContactRId = reader.GetValue<System.Int32>();
				break;
				case "ApplicationUrl":
					if (!hasValueToRead) break;
					ApplicationUrl = reader.GetValue<System.String>();
				break;
				case "Logger":
					if (!hasValueToRead) break;
					Logger = reader.GetSerializableObjectValue();
				break;
				case "SessionKey":
					if (!hasValueToRead) break;
					SessionKey = reader.GetValue<System.String>();
				break;
			}
		}

		protected override void WritePropertyValues(DataWriter writer) {
			base.WritePropertyValues(writer);
			WritePropertyValues(writer, true);
		}

		#endregion

		#region Methods: Public

		public virtual bool SendEmailScriptTaskExecute(ProcessExecutingContext context) {
			SendEmail();
			return true;
		}

			
			public virtual void SendEmail() {
				try {
				var sendDate = DateTime.UtcNow;
				var recipients = new List<BulkEmailRecipientInfo>();
				recipients.Add(new BulkEmailRecipientInfo {
					Id = ContactId,
					EmailAddress = ContactEmail,
					ContactRId = ContactRId
				});
				var messageInfo = new InstantMessageInfo() {
					ApplicationUrl = ApplicationUrl,
					MessageId = BulkEmailId,
					MessageRId = BulkEmailRId,
					Recipients = recipients
				};
				var mailingService = ClassFactory.Get<MailingService>(new ConstructorArgument("userConnection", UserConnection));
				mailingService.SendMessage(messageInfo);
				CampaignHelper.MergeContactIntoCampaign(UserConnection, CampaignId, BulkEmailStepId, ContactId);
			} catch (Exception e) {
				LogError("Error send immediately message.", e);
			}
			}
			
			
			public virtual global::Common.Logging.ILog GetLogger() {
				var logger = Logger as global::Common.Logging.ILog;
			if (logger == null) {
				logger = global::Common.Logging.LogManager.GetLogger(this.Name);
				Logger = logger;
			}
			if (string.IsNullOrEmpty(SessionKey)) {
				SessionKey = Guid.NewGuid().ToString("N");
			}
			return logger;
			}
			
			
			public virtual void LogError(string message, Exception e) {
				var logger = GetLogger();
			logger.Error(string.Format("{0}: [{1}] {2};", this.Name, SessionKey, message));
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
			var cloneItem = (SendImmediatelyTriggeredEmailProcess)base.CloneShallow();
			cloneItem.ExecutedEventHandler = ExecutedEventHandler;
			cloneItem.Logger = Logger;
			return cloneItem;
		}

		#endregion

	}

	#endregion

}

