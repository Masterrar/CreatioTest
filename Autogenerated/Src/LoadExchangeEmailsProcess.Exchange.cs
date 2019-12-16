namespace Terrasoft.Core.Process
{

	using IntegrationApi.Interfaces;
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

	#region Class: LoadExchangeEmailsProcessSchema

	/// <exclude/>
	public class LoadExchangeEmailsProcessSchema : Terrasoft.Core.Process.ProcessSchema
	{

		#region Constructors: Public

		public LoadExchangeEmailsProcessSchema(ProcessSchemaManager processSchemaManager)
			: base(processSchemaManager) {
		}

		public LoadExchangeEmailsProcessSchema(LoadExchangeEmailsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "LoadExchangeEmailsProcess";
			UId = new Guid("ed2b4c2d-5943-4145-8448-7d829df84c42");
			CreatedInPackageId = new Guid("db389f08-56ad-464d-83c5-5e18ef486d93");
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
			ZipCompiledMethodsBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,181,84,193,110,19,49,16,61,167,82,255,193,152,203,70,90,69,192,17,218,74,33,36,40,130,164,40,219,194,129,112,112,119,167,169,133,215,174,236,113,104,136,246,223,25,239,110,104,54,49,202,9,237,197,122,126,126,51,243,102,102,207,207,30,253,157,146,57,91,75,139,94,40,182,54,178,96,217,70,231,15,214,104,249,27,146,62,219,158,159,245,228,61,75,28,90,169,87,131,169,155,123,165,174,237,184,124,196,77,146,129,46,128,206,66,170,97,81,88,112,174,223,188,232,77,140,45,5,46,192,121,133,201,28,160,200,0,111,29,216,29,237,93,32,89,64,111,117,56,86,109,148,64,25,25,173,33,71,105,244,224,35,224,212,77,64,16,13,198,90,220,41,40,18,94,135,155,106,132,149,21,129,245,245,13,223,69,93,11,203,28,165,159,81,8,186,97,151,108,164,132,115,19,145,163,177,155,32,119,49,205,158,239,175,90,49,158,50,13,191,24,5,166,42,125,224,14,237,202,151,160,49,225,62,167,219,110,90,253,52,196,234,253,243,137,59,114,133,36,98,86,213,38,236,229,59,200,80,88,76,98,230,188,36,119,230,227,155,201,98,56,27,127,187,94,124,34,168,233,8,179,181,199,51,82,16,43,8,116,169,145,41,147,11,53,122,16,122,5,110,100,188,198,148,120,165,65,216,199,2,121,252,148,215,200,45,74,37,113,51,8,238,236,176,41,66,233,14,90,18,43,36,101,33,95,154,149,203,171,99,191,223,11,7,59,193,32,254,197,154,181,36,129,224,125,11,215,90,251,119,252,132,193,190,147,210,127,235,207,9,25,101,68,81,243,221,196,154,242,131,64,32,153,207,71,224,41,153,80,12,45,7,82,47,67,30,154,214,171,223,188,49,30,187,221,77,89,128,34,189,109,152,135,253,173,69,14,27,60,123,246,58,39,213,185,40,161,158,183,176,125,47,162,75,222,73,33,186,223,93,70,108,122,201,92,121,79,135,191,48,161,225,139,253,127,58,210,237,144,151,173,118,29,60,54,248,180,234,109,242,205,243,132,111,183,75,254,19,54,75,254,150,45,249,246,85,181,36,115,151,188,21,106,209,215,132,86,85,202,155,9,142,77,118,185,87,84,232,109,147,86,44,26,233,181,185,184,160,254,157,66,254,96,85,197,83,118,100,79,93,252,31,111,19,139,166,125,5,0,0 };
			RealUId = new Guid("ed2b4c2d-5943-4145-8448-7d829df84c42");
			Version = 0;
			PackageUId = new Guid("b8c22230-2173-426f-959e-be736709a63f");
			UseSystemSecurityContext = false;
		}

		protected virtual ProcessSchemaParameter CreateSenderEmailAddressParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("82543a97-c9a8-4beb-941d-8ef4b3f14761"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("ed2b4c2d-5943-4145-8448-7d829df84c42"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ed2b4c2d-5943-4145-8448-7d829df84c42"),
				Name = @"SenderEmailAddress",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MediumText"),
			};
		}

		protected virtual ProcessSchemaParameter CreateLoadResultParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("378fb237-3b1a-409e-a4b7-b409772eb5d8"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("ed2b4c2d-5943-4145-8448-7d829df84c42"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ed2b4c2d-5943-4145-8448-7d829df84c42"),
				Name = @"LoadResult",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText"),
			};
		}

		protected virtual ProcessSchemaParameter CreateCreateRemindingParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("e736a65f-4d19-4d0b-be8f-fba81c125580"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("ed2b4c2d-5943-4145-8448-7d829df84c42"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ed2b4c2d-5943-4145-8448-7d829df84c42"),
				Name = @"CreateReminding",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateNeedSetUserAddressParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("7468e799-61c5-41b3-9071-7396ff10fa12"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("db389f08-56ad-464d-83c5-5e18ef486d93"),
				CreatedInSchemaUId = new Guid("ed2b4c2d-5943-4145-8448-7d829df84c42"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ed2b4c2d-5943-4145-8448-7d829df84c42"),
				Name = @"NeedSetUserAddress",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("LocalizableStringDataValueType"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("ed2b4c2d-5943-4145-8448-7d829df84c42"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateSuccessLoadEmailsMessageParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("68c595cd-9fa1-477c-bdbc-d7a5686bdcff"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("43a72267-b2f6-464f-af52-bc7506959e73"),
				CreatedInSchemaUId = new Guid("ed2b4c2d-5943-4145-8448-7d829df84c42"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ed2b4c2d-5943-4145-8448-7d829df84c42"),
				Name = @"SuccessLoadEmailsMessage",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("LocalizableStringDataValueType"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.ConstValue,
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("ed2b4c2d-5943-4145-8448-7d829df84c42"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateLoadEmailsFromDateParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("23032bb7-f14e-4c42-8f0e-f0de93e358ae"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("ed2b4c2d-5943-4145-8448-7d829df84c42"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("ed2b4c2d-5943-4145-8448-7d829df84c42"),
				Name = @"LoadEmailsFromDate",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("DateTime"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateSenderEmailAddressParameter());
			Parameters.Add(CreateLoadResultParameter());
			Parameters.Add(CreateCreateRemindingParameter());
			Parameters.Add(CreateNeedSetUserAddressParameter());
			Parameters.Add(CreateSuccessLoadEmailsMessageParameter());
			Parameters.Add(CreateLoadEmailsFromDateParameter());
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
			ProcessSchemaScriptTask loadexchangeemailscripttask = CreateLoadExchangeEmailScriptTaskScriptTask();
			FlowElements.Add(loadexchangeemailscripttask);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("2178232f-0167-4c4f-8412-e10940f40071"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("db389f08-56ad-464d-83c5-5e18ef486d93"),
				CreatedInSchemaUId = new Guid("ed2b4c2d-5943-4145-8448-7d829df84c42"),
				CurveCenterPosition = new Point(373, 203),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("ed2b4c2d-5943-4145-8448-7d829df84c42"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("c810b5c3-95d5-43bb-93e2-f16b7b84f0a3"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("ceaf2735-60b0-4ba1-8c27-a604399b7531"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("fc9c113d-852c-4c28-a48a-79195b92ef4a"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("db389f08-56ad-464d-83c5-5e18ef486d93"),
				CreatedInSchemaUId = new Guid("ed2b4c2d-5943-4145-8448-7d829df84c42"),
				CurveCenterPosition = new Point(373, 203),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("ed2b4c2d-5943-4145-8448-7d829df84c42"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("ceaf2735-60b0-4ba1-8c27-a604399b7531"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("3c7ed91d-008c-4351-b8ab-13fff632de5a"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("deba005a-95f2-4bf3-b2c9-7320be29feda"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("db389f08-56ad-464d-83c5-5e18ef486d93"),
				CreatedInSchemaUId = new Guid("ed2b4c2d-5943-4145-8448-7d829df84c42"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("ed2b4c2d-5943-4145-8448-7d829df84c42"),
				Name = @"LaneSet1",
				Position = new Point(5, 5),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("366e12ec-8725-426c-9436-7be163ac6e66"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("deba005a-95f2-4bf3-b2c9-7320be29feda"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("db389f08-56ad-464d-83c5-5e18ef486d93"),
				CreatedInSchemaUId = new Guid("ed2b4c2d-5943-4145-8448-7d829df84c42"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("ed2b4c2d-5943-4145-8448-7d829df84c42"),
				Name = @"Lane1",
				Position = new Point(29, 0),
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaStartEvent CreateStart1StartEvent() {
			ProcessSchemaStartEvent schemaStartEvent = new ProcessSchemaStartEvent(this) {
				UId = new Guid("c810b5c3-95d5-43bb-93e2-f16b7b84f0a3"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("366e12ec-8725-426c-9436-7be163ac6e66"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("db389f08-56ad-464d-83c5-5e18ef486d93"),
				CreatedInSchemaUId = new Guid("ed2b4c2d-5943-4145-8448-7d829df84c42"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsInterrupting = false,
				IsLogging = true,
				ManagerItemUId = new Guid("53818048-7868-48f6-ada0-0ebaa65af628"),
				ModifiedInSchemaUId = new Guid("ed2b4c2d-5943-4145-8448-7d829df84c42"),
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
				UId = new Guid("3c7ed91d-008c-4351-b8ab-13fff632de5a"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("366e12ec-8725-426c-9436-7be163ac6e66"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("db389f08-56ad-464d-83c5-5e18ef486d93"),
				CreatedInSchemaUId = new Guid("ed2b4c2d-5943-4145-8448-7d829df84c42"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = true,
				ManagerItemUId = new Guid("1bd93619-0574-454e-bb4e-cf53b9eb9470"),
				ModifiedInSchemaUId = new Guid("ed2b4c2d-5943-4145-8448-7d829df84c42"),
				Name = @"Terminate1",
				Position = new Point(600, 184),
				SerializeToDB = false,
				Size = new Size(27, 27),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaTerminateEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateLoadExchangeEmailScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("ceaf2735-60b0-4ba1-8c27-a604399b7531"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("366e12ec-8725-426c-9436-7be163ac6e66"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("db389f08-56ad-464d-83c5-5e18ef486d93"),
				CreatedInSchemaUId = new Guid("ed2b4c2d-5943-4145-8448-7d829df84c42"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = true,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("ed2b4c2d-5943-4145-8448-7d829df84c42"),
				Name = @"LoadExchangeEmailScriptTask",
				Position = new Point(274, 170),
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
				UId = new Guid("7ef76fa2-afb6-4ff1-b0d8-05122e2a708b"),
				Name = "Terrasoft.Sync.Exchange",
				Alias = "",
				CreatedInPackageId = new Guid("db389f08-56ad-464d-83c5-5e18ef486d93")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("da06c9d8-9a38-4073-bc77-89b836cb6504"),
				Name = "Terrasoft.Sync",
				Alias = "",
				CreatedInPackageId = new Guid("db389f08-56ad-464d-83c5-5e18ef486d93")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("261eafa1-808b-4377-aeb5-67d29bcc8923"),
				Name = "System.Linq",
				Alias = "",
				CreatedInPackageId = new Guid("43a72267-b2f6-464f-af52-bc7506959e73")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("bf52bc50-6b05-4e41-90f3-592b01faa181"),
				Name = "System.Collections.Generic",
				Alias = "",
				CreatedInPackageId = new Guid("43a72267-b2f6-464f-af52-bc7506959e73")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("1e203cd8-80e1-4a0d-a0e2-4733b9d9e4d4"),
				Name = "Terrasoft.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("43a72267-b2f6-464f-af52-bc7506959e73")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("a87ff3b8-7f79-4ef2-8410-8ae2fea47c7e"),
				Name = "Terrasoft.Core.Factories",
				Alias = "",
				CreatedInPackageId = new Guid("db389f08-56ad-464d-83c5-5e18ef486d93")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("af45d813-3b4d-4c55-bf0a-04fba228af5d"),
				Name = "IntegrationApi.Interfaces",
				Alias = "",
				CreatedInPackageId = new Guid("db389f08-56ad-464d-83c5-5e18ef486d93")
			});
		}

		#endregion

		#region Methods: Public

		public override Process CreateProcess(UserConnection userConnection) {
			return new LoadExchangeEmailsProcess(userConnection);
		}

		public override object Clone() {
			return new LoadExchangeEmailsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ed2b4c2d-5943-4145-8448-7d829df84c42"));
		}

		#endregion

	}

	#endregion

	#region Class: LoadExchangeEmailsProcess

	/// <exclude/>
	public class LoadExchangeEmailsProcess : Terrasoft.Core.Process.Process
	{

		#region Class: ProcessLane1

		/// <exclude/>
		public class ProcessLane1 : ProcessLane
		{

			public ProcessLane1(UserConnection userConnection, LoadExchangeEmailsProcess process)
				: base(userConnection) {
				Owner = process;
				IsUsedParentUserContexts = false;
			}

		}

		#endregion

		public LoadExchangeEmailsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "LoadExchangeEmailsProcess";
			SchemaUId = new Guid("ed2b4c2d-5943-4145-8448-7d829df84c42");
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
				return new Guid("ed2b4c2d-5943-4145-8448-7d829df84c42");
			}
		}

		private string ConditionalExpressionLogMessage {
			get {
				return "Process: LoadExchangeEmailsProcess, Source element: {0}, Conditional flow: {1}, Expression: {2}, Result: {3}";
			}
		}

		private string DeadEndGatewayLogMessage {
			get {
				return "Process: LoadExchangeEmailsProcess, Source element: {0}, None of the exclusive gateway conditions are met!";
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
				return _needSetUserAddress ?? (_needSetUserAddress = GetLocalizableString("ed2b4c2d5943414584487d829df84c42",
						 "Parameters.NeedSetUserAddress.Value"));
			}
			set {
				_needSetUserAddress = value;
			}
		}

		private LocalizableString _successLoadEmailsMessage;
		public virtual LocalizableString SuccessLoadEmailsMessage {
			get {
				return _successLoadEmailsMessage ?? (_successLoadEmailsMessage = GetLocalizableString("ed2b4c2d5943414584487d829df84c42",
						 "Parameters.SuccessLoadEmailsMessage.Value"));
			}
			set {
				_successLoadEmailsMessage = value;
			}
		}

		public virtual DateTime LoadEmailsFromDate {
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
					SchemaElementUId = new Guid("c810b5c3-95d5-43bb-93e2-f16b7b84f0a3"),
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
					SchemaElementUId = new Guid("3c7ed91d-008c-4351-b8ab-13fff632de5a"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
				});
			}
		}

		private ProcessScriptTask _loadExchangeEmailScriptTask;
		public ProcessScriptTask LoadExchangeEmailScriptTask {
			get {
				return _loadExchangeEmailScriptTask ?? (_loadExchangeEmailScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "LoadExchangeEmailScriptTask",
					SchemaElementUId = new Guid("ceaf2735-60b0-4ba1-8c27-a604399b7531"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
					IsLogging = true,
					Script = LoadExchangeEmailScriptTaskExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[Start1.SchemaElementUId] = new Collection<ProcessFlowElement> { Start1 };
			FlowElements[Terminate1.SchemaElementUId] = new Collection<ProcessFlowElement> { Terminate1 };
			FlowElements[LoadExchangeEmailScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { LoadExchangeEmailScriptTask };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "Start1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("LoadExchangeEmailScriptTask", e.Context.SenderName));
						break;
					case "Terminate1":
						CompleteProcess();
						break;
					case "LoadExchangeEmailScriptTask":
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
			if (!HasMapping("LoadEmailsFromDate")) {
				writer.WriteValue("LoadEmailsFromDate", LoadEmailsFromDate, DateTime.ParseExact("01.01.0001 0:00", "dd.MM.yyyy H:mm", CultureInfo.InvariantCulture));
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
			MetaPathParameterValues.Add("82543a97-c9a8-4beb-941d-8ef4b3f14761", () => SenderEmailAddress);
			MetaPathParameterValues.Add("378fb237-3b1a-409e-a4b7-b409772eb5d8", () => LoadResult);
			MetaPathParameterValues.Add("e736a65f-4d19-4d0b-be8f-fba81c125580", () => CreateReminding);
			MetaPathParameterValues.Add("7468e799-61c5-41b3-9071-7396ff10fa12", () => NeedSetUserAddress);
			MetaPathParameterValues.Add("68c595cd-9fa1-477c-bdbc-d7a5686bdcff", () => SuccessLoadEmailsMessage);
			MetaPathParameterValues.Add("23032bb7-f14e-4c42-8f0e-f0de93e358ae", () => LoadEmailsFromDate);
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
				case "LoadEmailsFromDate":
					if (!hasValueToRead) break;
					LoadEmailsFromDate = reader.GetValue<System.DateTime>();
				break;
			}
		}

		protected override void WritePropertyValues(DataWriter writer) {
			base.WritePropertyValues(writer);
			WritePropertyValues(writer, true);
		}

		#endregion

		#region Methods: Public

		public virtual bool LoadExchangeEmailScriptTaskExecute(ProcessExecutingContext context) {
			Synchronize();
			return true;
		}

			
			public virtual void Synchronize() {
				if (string.IsNullOrEmpty(SenderEmailAddress)) {
					FormatResult(NeedSetUserAddress);
					return;
				}
				if (UserConnection.GetIsFeatureEnabled("EmailIntegrationV2")) {
					var syncSession = ClassFactory.Get<ISyncSession>("Email", new ConstructorArgument("uc", UserConnection),
						new ConstructorArgument("senderEmailAddress", SenderEmailAddress));
					syncSession.Start();
					return;
				}
				#if NETFRAMEWORK
				string resultMessage;
				int localChangesCount, remoteChangesCount;
				ExchangeUtility.SyncExchangeItems(UserConnection, SenderEmailAddress, 
					() => ClassFactory.Get<BaseExchangeSyncProvider>("ExchangeEmailSyncProvider",
						new ConstructorArgument("userConnection", UserConnection),
						new ConstructorArgument("senderEmailAddress", SenderEmailAddress),
						new ConstructorArgument("loadEmailsFromDate", LoadEmailsFromDate),
						new ConstructorArgument("userSettings", null)),
					out resultMessage, out localChangesCount, out remoteChangesCount,
					ExchangeUtility.MailSyncProcessName);
				if (!string.IsNullOrEmpty(resultMessage)) {
					FormatResult(resultMessage);
					return;
				}
				#endif
				return;
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
			var cloneItem = (LoadExchangeEmailsProcess)base.CloneShallow();
			cloneItem.ExecutedEventHandler = ExecutedEventHandler;
			return cloneItem;
		}

		#endregion

	}

	#endregion

}

