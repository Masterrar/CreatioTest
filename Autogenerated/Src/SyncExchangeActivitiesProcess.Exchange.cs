namespace Terrasoft.Core.Process
{

	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Drawing;
	using System.Globalization;
	using System.Linq;
	using System.Text;
	using Terrasoft.Common;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Factories;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;
	using Terrasoft.Sync;
	using Terrasoft.Sync.Exchange;

	#region Class: SyncExchangeActivitiesProcessSchema

	/// <exclude/>
	public class SyncExchangeActivitiesProcessSchema : Terrasoft.Core.Process.ProcessSchema
	{

		#region Constructors: Public

		public SyncExchangeActivitiesProcessSchema(ProcessSchemaManager processSchemaManager)
			: base(processSchemaManager) {
		}

		public SyncExchangeActivitiesProcessSchema(SyncExchangeActivitiesProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "SyncExchangeActivitiesProcess";
			UId = new Guid("e5873837-7f4e-4bce-93c3-0179fb72eb6a");
			CreatedInPackageId = new Guid("3033db6d-23fb-435c-94e5-8f4806c46ba3");
			CreatedInSchemaUId = Guid.Empty;
			CreatedInVersion = @"0.0.0.0";
			CultureName = @"ru-RU";
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsLogging = false;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			SerializeToDB = false;
			SerializeToMemory = false;
			Tag = @"Business Process";
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
			ZipMethodsBody = new byte[] {  };
			ZipCompiledMethodsBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,205,85,77,111,218,64,16,61,7,137,255,176,221,147,81,44,210,94,155,18,137,82,104,145,82,82,133,112,42,61,108,237,41,88,89,239,90,187,99,90,130,252,223,59,107,27,225,47,232,161,151,220,236,217,153,55,111,222,27,175,251,189,36,253,41,163,128,237,34,131,169,144,108,167,163,144,45,247,42,216,26,173,162,23,240,6,236,208,239,93,69,191,152,183,4,21,130,153,198,34,146,227,48,52,96,237,112,110,23,169,148,15,20,76,112,239,13,138,220,153,54,177,192,71,176,169,68,111,1,16,46,1,87,22,76,89,52,184,165,28,3,152,26,69,79,89,191,183,19,134,109,65,38,96,216,136,41,248,205,166,10,35,220,87,72,152,47,249,177,231,74,139,204,225,68,130,48,237,68,207,53,154,104,165,32,192,72,43,87,112,115,51,253,19,108,133,218,192,10,35,73,249,67,226,51,150,114,156,36,58,82,24,131,66,251,96,54,226,92,125,179,250,19,72,64,200,39,30,83,210,142,98,51,163,227,227,243,5,54,62,59,38,81,204,162,29,62,9,251,252,180,79,96,53,15,93,39,98,195,196,137,213,189,14,132,156,228,189,237,68,167,10,253,234,233,35,196,26,161,122,76,8,22,77,164,54,245,52,103,195,87,210,93,108,160,99,26,71,247,24,155,35,196,182,197,185,109,187,207,200,65,90,140,209,29,155,72,97,237,76,4,168,205,126,248,25,240,195,71,97,225,136,231,176,191,25,189,139,168,254,206,227,199,112,69,248,106,6,247,9,245,202,249,159,171,99,82,7,58,54,155,212,37,122,60,173,209,226,62,107,56,117,185,218,182,134,224,93,147,13,114,24,157,226,89,9,125,214,56,237,112,169,85,223,116,42,23,176,233,68,117,129,72,147,128,250,45,68,12,110,49,138,213,64,218,150,142,110,46,124,105,25,138,243,87,183,5,110,247,95,157,253,255,66,65,36,69,93,173,162,107,239,180,44,45,137,139,29,56,99,216,169,226,127,247,162,116,216,52,220,173,189,211,157,122,225,58,112,247,250,155,2,166,113,153,183,102,42,111,247,58,248,245,136,241,91,198,217,117,231,154,101,151,26,152,14,240,218,175,163,158,208,252,107,100,238,179,232,119,254,190,106,40,165,70,113,9,147,183,233,210,141,116,42,105,22,229,30,63,28,214,252,25,246,107,254,158,173,249,225,109,182,38,223,215,188,4,42,163,239,40,154,101,62,207,157,235,250,70,226,19,253,123,45,194,130,84,87,47,66,43,153,88,135,253,157,26,254,96,89,70,200,45,29,242,209,255,2,247,218,0,197,186,7,0,0 };
			RealUId = new Guid("e5873837-7f4e-4bce-93c3-0179fb72eb6a");
			Version = 0;
			PackageUId = new Guid("b8c22230-2173-426f-959e-be736709a63f");
			UseSystemSecurityContext = false;
		}

		protected virtual ProcessSchemaParameter CreateSenderEmailAddressParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("1706a8e4-a8db-40dd-bcfe-70083813c584"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("e5873837-7f4e-4bce-93c3-0179fb72eb6a"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("e5873837-7f4e-4bce-93c3-0179fb72eb6a"),
				Name = @"SenderEmailAddress",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MediumText"),
			};
		}

		protected virtual ProcessSchemaParameter CreateLoadResultParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("f363e086-ca54-4a07-b6a4-f2d793380738"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("e5873837-7f4e-4bce-93c3-0179fb72eb6a"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("e5873837-7f4e-4bce-93c3-0179fb72eb6a"),
				Name = @"LoadResult",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText"),
			};
		}

		protected virtual ProcessSchemaParameter CreateCreateRemindingParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("f4f43cc4-e123-4ce2-9acd-20ddaba5c641"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("e5873837-7f4e-4bce-93c3-0179fb72eb6a"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("e5873837-7f4e-4bce-93c3-0179fb72eb6a"),
				Name = @"CreateReminding",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateNeedSetUserAddressParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("264bbae8-6f36-4dcf-94e7-82abf4ec9e24"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("3033db6d-23fb-435c-94e5-8f4806c46ba3"),
				CreatedInSchemaUId = new Guid("e5873837-7f4e-4bce-93c3-0179fb72eb6a"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("e5873837-7f4e-4bce-93c3-0179fb72eb6a"),
				Name = @"NeedSetUserAddress",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("LocalizableStringDataValueType"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("e5873837-7f4e-4bce-93c3-0179fb72eb6a"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateSyncActivitySuccessMessageParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("d17b41bd-be12-494e-934a-ba442230f54f"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("3033db6d-23fb-435c-94e5-8f4806c46ba3"),
				CreatedInSchemaUId = new Guid("e5873837-7f4e-4bce-93c3-0179fb72eb6a"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("e5873837-7f4e-4bce-93c3-0179fb72eb6a"),
				Name = @"SyncActivitySuccessMessage",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("LocalizableStringDataValueType"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("e5873837-7f4e-4bce-93c3-0179fb72eb6a"),
				},
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateSenderEmailAddressParameter());
			Parameters.Add(CreateLoadResultParameter());
			Parameters.Add(CreateCreateRemindingParameter());
			Parameters.Add(CreateNeedSetUserAddressParameter());
			Parameters.Add(CreateSyncActivitySuccessMessageParameter());
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
			ProcessSchemaScriptTask mainscripttask = CreateMainScriptTaskScriptTask();
			FlowElements.Add(mainscripttask);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("41f16446-2ae5-4ea4-ac7d-30b3c1e71a02"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("3033db6d-23fb-435c-94e5-8f4806c46ba3"),
				CreatedInSchemaUId = new Guid("e5873837-7f4e-4bce-93c3-0179fb72eb6a"),
				CurveCenterPosition = new Point(373, 203),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("e5873837-7f4e-4bce-93c3-0179fb72eb6a"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("01fff802-295f-4649-9bca-a1af184a280f"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("143c11fd-593c-4449-b58c-0f5cf0393adb"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("e4a99538-e8d9-4f6d-a8d2-c4de8277151e"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("3033db6d-23fb-435c-94e5-8f4806c46ba3"),
				CreatedInSchemaUId = new Guid("e5873837-7f4e-4bce-93c3-0179fb72eb6a"),
				CurveCenterPosition = new Point(373, 203),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("e5873837-7f4e-4bce-93c3-0179fb72eb6a"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("143c11fd-593c-4449-b58c-0f5cf0393adb"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("49cf4a4b-4e8c-49da-a7bb-669368c326fc"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("9fc02540-1342-4ae4-bf1f-3768b697dea1"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("3033db6d-23fb-435c-94e5-8f4806c46ba3"),
				CreatedInSchemaUId = new Guid("e5873837-7f4e-4bce-93c3-0179fb72eb6a"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("e5873837-7f4e-4bce-93c3-0179fb72eb6a"),
				Name = @"LaneSet1",
				Position = new Point(5, 5),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("0744a239-2513-49f9-b6fa-459d7ee83ba3"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("9fc02540-1342-4ae4-bf1f-3768b697dea1"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("3033db6d-23fb-435c-94e5-8f4806c46ba3"),
				CreatedInSchemaUId = new Guid("e5873837-7f4e-4bce-93c3-0179fb72eb6a"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("e5873837-7f4e-4bce-93c3-0179fb72eb6a"),
				Name = @"Lane1",
				Position = new Point(29, 0),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaStartEvent CreateStart1StartEvent() {
			ProcessSchemaStartEvent schemaStartEvent = new ProcessSchemaStartEvent(this) {
				UId = new Guid("01fff802-295f-4649-9bca-a1af184a280f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0744a239-2513-49f9-b6fa-459d7ee83ba3"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("3033db6d-23fb-435c-94e5-8f4806c46ba3"),
				CreatedInSchemaUId = new Guid("e5873837-7f4e-4bce-93c3-0179fb72eb6a"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsInterrupting = false,
				IsLogging = true,
				ManagerItemUId = new Guid("53818048-7868-48f6-ada0-0ebaa65af628"),
				ModifiedInSchemaUId = new Guid("e5873837-7f4e-4bce-93c3-0179fb72eb6a"),
				Name = @"Start1",
				Position = new Point(50, 184),
				SerializeToDB = false,
				Size = new Size(27, 27),
				UseBackgroundMode = false
			};
			
			return schemaStartEvent;
		}

		protected virtual ProcessSchemaTerminateEvent CreateTerminate1TerminateEvent() {
			ProcessSchemaTerminateEvent schemaTerminateEvent = new ProcessSchemaTerminateEvent(this) {
				UId = new Guid("49cf4a4b-4e8c-49da-a7bb-669368c326fc"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0744a239-2513-49f9-b6fa-459d7ee83ba3"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("3033db6d-23fb-435c-94e5-8f4806c46ba3"),
				CreatedInSchemaUId = new Guid("e5873837-7f4e-4bce-93c3-0179fb72eb6a"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = true,
				ManagerItemUId = new Guid("1bd93619-0574-454e-bb4e-cf53b9eb9470"),
				ModifiedInSchemaUId = new Guid("e5873837-7f4e-4bce-93c3-0179fb72eb6a"),
				Name = @"Terminate1",
				Position = new Point(600, 184),
				SerializeToDB = false,
				Size = new Size(27, 27),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaTerminateEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateMainScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("143c11fd-593c-4449-b58c-0f5cf0393adb"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("0744a239-2513-49f9-b6fa-459d7ee83ba3"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("3033db6d-23fb-435c-94e5-8f4806c46ba3"),
				CreatedInSchemaUId = new Guid("e5873837-7f4e-4bce-93c3-0179fb72eb6a"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("e5873837-7f4e-4bce-93c3-0179fb72eb6a"),
				Name = @"MainScriptTask",
				Position = new Point(295, 170),
				SerializeToDB = false,
				Size = new Size(69, 55),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,174,204,75,206,40,202,207,203,172,74,213,208,180,230,229,42,74,45,41,45,202,83,40,41,42,77,181,6,0,209,75,113,44,28,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("ccf59d5b-a728-418e-9389-ed5f74140b3b"),
				Name = "Terrasoft.Sync.Exchange",
				Alias = "",
				CreatedInPackageId = new Guid("3033db6d-23fb-435c-94e5-8f4806c46ba3")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e1699d33-d81c-428e-ab95-b9519e811946"),
				Name = "Terrasoft.Sync",
				Alias = "",
				CreatedInPackageId = new Guid("3033db6d-23fb-435c-94e5-8f4806c46ba3")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("2cc2de4d-4a49-4023-84e0-87f513f606fd"),
				Name = "System.Linq",
				Alias = "",
				CreatedInPackageId = new Guid("3033db6d-23fb-435c-94e5-8f4806c46ba3")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7d06a26f-7484-42fa-a34a-a289a78da842"),
				Name = "System.Collections.Generic",
				Alias = "",
				CreatedInPackageId = new Guid("3033db6d-23fb-435c-94e5-8f4806c46ba3")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7835e741-23c7-4f92-bfad-db3d847fa2ad"),
				Name = "Terrasoft.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("3033db6d-23fb-435c-94e5-8f4806c46ba3")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("c25553c6-8f82-4df6-aa2e-7aa7bdef3c27"),
				Name = "Terrasoft.Common",
				Alias = "",
				CreatedInPackageId = new Guid("405cd56e-8293-41da-83e9-a9cf9867a065")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("23df5e27-0cfa-4ef6-b0b4-19e72992cfcc"),
				Name = "Terrasoft.Core.Factories",
				Alias = "",
				CreatedInPackageId = new Guid("3033db6d-23fb-435c-94e5-8f4806c46ba3")
			});
		}

		#endregion

		#region Methods: Public

		public override Process CreateProcess(UserConnection userConnection) {
			return new SyncExchangeActivitiesProcess(userConnection);
		}

		public override object Clone() {
			return new SyncExchangeActivitiesProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e5873837-7f4e-4bce-93c3-0179fb72eb6a"));
		}

		#endregion

	}

	#endregion

	#region Class: SyncExchangeActivitiesProcess

	/// <exclude/>
	public class SyncExchangeActivitiesProcess : Terrasoft.Core.Process.Process
	{

		#region Class: ProcessLane1

		/// <exclude/>
		public class ProcessLane1 : ProcessLane
		{

			public ProcessLane1(UserConnection userConnection, SyncExchangeActivitiesProcess process)
				: base(userConnection) {
				Owner = process;
				IsUsedParentUserContexts = false;
			}

		}

		#endregion

		public SyncExchangeActivitiesProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "SyncExchangeActivitiesProcess";
			SchemaUId = new Guid("e5873837-7f4e-4bce-93c3-0179fb72eb6a");
			Caption = Schema.Caption;
			SchemaManagerName = "ProcessSchemaManager";
			SerializeToDB = false;
			SerializeToMemory = false;
			IsLogging = false;
			UseSystemSecurityContext = false;
			_notificationCaption = () => { return new LocalizableString((Caption)); };
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("e5873837-7f4e-4bce-93c3-0179fb72eb6a");
			}
		}

		private string ConditionalExpressionLogMessage {
			get {
				return "Process: SyncExchangeActivitiesProcess, Source element: {0}, Conditional flow: {1}, Expression: {2}, Result: {3}";
			}
		}

		private string DeadEndGatewayLogMessage {
			get {
				return "Process: SyncExchangeActivitiesProcess, Source element: {0}, None of the exclusive gateway conditions are met!";
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

		public virtual string SenderEmailAddress {
			get;
			set;
		}

		public virtual string LoadResult {
			get;
			set;
		}

		public virtual bool CreateReminding {
			get;
			set;
		}

		private LocalizableString _needSetUserAddress;
		public virtual LocalizableString NeedSetUserAddress {
			get {
				return _needSetUserAddress ?? (_needSetUserAddress = GetLocalizableString("e58738377f4e4bce93c30179fb72eb6a",
						 "Parameters.NeedSetUserAddress.Value"));
			}
			set {
				_needSetUserAddress = value;
			}
		}

		private LocalizableString _syncActivitySuccessMessage;
		public virtual LocalizableString SyncActivitySuccessMessage {
			get {
				return _syncActivitySuccessMessage ?? (_syncActivitySuccessMessage = GetLocalizableString("e58738377f4e4bce93c30179fb72eb6a",
						 "Parameters.SyncActivitySuccessMessage.Value"));
			}
			set {
				_syncActivitySuccessMessage = value;
			}
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
					SchemaElementUId = new Guid("01fff802-295f-4649-9bca-a1af184a280f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
				});
			}
		}

		private ProcessTerminateEvent _terminate1;
		public ProcessTerminateEvent Terminate1 {
			get {
				return _terminate1 ?? (_terminate1 = new ProcessTerminateEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaTerminateEvent",
					Name = "Terminate1",
					SchemaElementUId = new Guid("49cf4a4b-4e8c-49da-a7bb-669368c326fc"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
				});
			}
		}

		private ProcessScriptTask _mainScriptTask;
		public ProcessScriptTask MainScriptTask {
			get {
				return _mainScriptTask ?? (_mainScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "MainScriptTask",
					SchemaElementUId = new Guid("143c11fd-593c-4449-b58c-0f5cf0393adb"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
					Script = MainScriptTaskExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[Start1.SchemaElementUId] = new Collection<ProcessFlowElement> { Start1 };
			FlowElements[Terminate1.SchemaElementUId] = new Collection<ProcessFlowElement> { Terminate1 };
			FlowElements[MainScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { MainScriptTask };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "Start1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("MainScriptTask", e.Context.SenderName));
						break;
					case "Terminate1":
						CompleteProcess();
						break;
					case "MainScriptTask":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("Terminate1", e.Context.SenderName));
						break;
			}
		}

		private void WritePropertyValues(DataWriter writer, bool useAllValueSources) {
			if (!HasMapping("SenderEmailAddress")) {
				writer.WriteValue("SenderEmailAddress", SenderEmailAddress, null);
			}
			if (!HasMapping("LoadResult")) {
				writer.WriteValue("LoadResult", LoadResult, null);
			}
			if (!HasMapping("CreateReminding")) {
				writer.WriteValue("CreateReminding", CreateReminding, false);
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
			MetaPathParameterValues.Add("1706a8e4-a8db-40dd-bcfe-70083813c584", () => SenderEmailAddress);
			MetaPathParameterValues.Add("f363e086-ca54-4a07-b6a4-f2d793380738", () => LoadResult);
			MetaPathParameterValues.Add("f4f43cc4-e123-4ce2-9acd-20ddaba5c641", () => CreateReminding);
			MetaPathParameterValues.Add("264bbae8-6f36-4dcf-94e7-82abf4ec9e24", () => NeedSetUserAddress);
			MetaPathParameterValues.Add("d17b41bd-be12-494e-934a-ba442230f54f", () => SyncActivitySuccessMessage);
		}

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			bool hasValueToRead = reader.HasValue();
			switch (reader.CurrentName) {
				case "SenderEmailAddress":
					if (!hasValueToRead) break;
					SenderEmailAddress = reader.GetValue<System.String>();
				break;
				case "LoadResult":
					if (!hasValueToRead) break;
					LoadResult = reader.GetValue<System.String>();
				break;
				case "CreateReminding":
					if (!hasValueToRead) break;
					CreateReminding = reader.GetValue<System.Boolean>();
				break;
			}
		}

		protected override void WritePropertyValues(DataWriter writer) {
			base.WritePropertyValues(writer);
			WritePropertyValues(writer, true);
		}

		#endregion

		#region Methods: Public

		public virtual bool MainScriptTaskExecute(ProcessExecutingContext context) {
			Synchronize();
			return true;
		}

			
			public virtual void Synchronize() {
				if (SenderEmailAddress.IsNullOrEmpty()) {
				FormatResult(NeedSetUserAddress);
				return;
			}
			var helper = new EntitySynchronizerHelper();
			helper.ClearEntitySynchronizer(UserConnection);
			//ExchangeUtility.SetAllAppointmentsOrganizer(UserConnection);
			ExchangeUtility.DeleteEmptyActivityFromActivitySynchronizer(UserConnection, ActivityConsts.TaskTypeUId);
			int appointmentLocalChangesCount, appointmentRemoteChangesCount;
			string appointmentResultMessage;
			ExchangeUtility.SyncExchangeItems(UserConnection, SenderEmailAddress, 
				() => ClassFactory.Get<BaseExchangeSyncProvider>("ExchangeAppointmentSyncProvider",
					new ConstructorArgument("userConnection", UserConnection),
					new ConstructorArgument("senderEmailAddress", SenderEmailAddress)),
				out appointmentResultMessage, out appointmentLocalChangesCount, out appointmentRemoteChangesCount, 
				ExchangeUtility.ActivitySyncProcessName);
			
			int taskLocalChangesCount, taskRemoteChangesCount;
			string taskResultMessage;
			ExchangeUtility.SyncExchangeItems(UserConnection, SenderEmailAddress, 
				() => ClassFactory.Get<BaseExchangeSyncProvider>("ExchangeTaskSyncProvider",
					new ConstructorArgument("userConnection", UserConnection),
					new ConstructorArgument("senderEmailAddress", SenderEmailAddress),
					new ConstructorArgument("settings", null)),
				out taskResultMessage, out taskLocalChangesCount, out taskRemoteChangesCount, 
				ExchangeUtility.ActivitySyncProcessName);
			string resultMessage;
			resultMessage = appointmentResultMessage;
			if (!string.IsNullOrEmpty(taskResultMessage)) {
				resultMessage += "; " + taskResultMessage;
			}
			if (!string.IsNullOrEmpty(resultMessage)) {
				FormatResult(resultMessage);
				return;
			}
			}
			
			
			public virtual void FormatResult(string message) {
				string resultMessage = string.Format("{{\"key\": \"{0}\", \"message\": \"{1}\"}},", 
				SenderEmailAddress, message);
			LoadResult = string.Format("{{ \"Messages\": [{0}] }}", resultMessage);
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
			var cloneItem = (SyncExchangeActivitiesProcess)base.CloneShallow();
			cloneItem.ExecutedEventHandler = ExecutedEventHandler;
			return cloneItem;
		}

		#endregion

	}

	#endregion

}

