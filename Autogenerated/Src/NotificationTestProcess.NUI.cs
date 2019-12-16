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

	#region Class: NotificationTestProcessSchema

	/// <exclude/>
	public class NotificationTestProcessSchema : Terrasoft.Core.Process.ProcessSchema
	{

		#region Constructors: Public

		public NotificationTestProcessSchema(ProcessSchemaManager processSchemaManager)
			: base(processSchemaManager) {
		}

		public NotificationTestProcessSchema(NotificationTestProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "NotificationTestProcess";
			UId = new Guid("b469eddc-e461-48b7-a02a-0131706ea155");
			CreatedInPackageId = new Guid("d5227176-6716-4fb5-bba8-cc5a2de7deeb");
			CreatedInSchemaUId = Guid.Empty;
			CreatedInVersion = @"7.11.2.1633";
			CultureName = @"en-US";
			EntitySchemaUId = Guid.Empty;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			SerializeToDB = true;
			SerializeToMemory = true;
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
			ZipMethodsBody = new byte[] {  };
			ZipCompiledMethodsBody = new byte[] {  };
			RealUId = new Guid("b469eddc-e461-48b7-a02a-0131706ea155");
			Version = 0;
			PackageUId = new Guid("a7d9c356-450c-46d7-bc85-72dca4e280ba");
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected virtual void InitializeSayHiToAllConnectedUsersUserTaskParameters(IParametrizedProcessSchemaElement parametrizedElement) {
			var sendForAllParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("f1e72eb5-f171-4b5c-967b-4aeeada71896"),
				ContainerUId = new Guid("8373d1ca-61b4-4119-929b-e52ef624f718"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("4b1606b8-26b2-466b-9135-1167317fea23"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("4b1606b8-26b2-466b-9135-1167317fea23"),
				Name = @"SendForAll",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean")
			};
			sendForAllParameter.SourceValue = new ProcessSchemaParameterValue(sendForAllParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"True",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("b469eddc-e461-48b7-a02a-0131706ea155")
			};
			parametrizedElement.Parameters.Add(sendForAllParameter);
			var targetUserIdsKeyParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("37ef9b0a-e392-47a7-ad6a-4dacf134f636"),
				ContainerUId = new Guid("8373d1ca-61b4-4119-929b-e52ef624f718"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("4b1606b8-26b2-466b-9135-1167317fea23"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("4b1606b8-26b2-466b-9135-1167317fea23"),
				Name = @"TargetUserIdsKey",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text")
			};
			targetUserIdsKeyParameter.SourceValue = new ProcessSchemaParameterValue(targetUserIdsKeyParameter) {
				Source = ProcessSchemaParameterValueSource.None,
				Value = null,
				MetaPath = null,
				ModifiedInSchemaUId = Guid.Empty
			};
			parametrizedElement.Parameters.Add(targetUserIdsKeyParameter);
			var senderNameParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("c526d4de-f583-4991-9958-36c1b4a80141"),
				ContainerUId = new Guid("8373d1ca-61b4-4119-929b-e52ef624f718"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("4b1606b8-26b2-466b-9135-1167317fea23"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("4b1606b8-26b2-466b-9135-1167317fea23"),
				Name = @"SenderName",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text")
			};
			senderNameParameter.SourceValue = new ProcessSchemaParameterValue(senderNameParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"NotificationTestProcess",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("b469eddc-e461-48b7-a02a-0131706ea155")
			};
			parametrizedElement.Parameters.Add(senderNameParameter);
			var messageTextParameter = new ProcessSchemaParameter(this) {
				UId = new Guid("077529b0-043e-458b-acaf-8dcb10bc6db4"),
				ContainerUId = new Guid("8373d1ca-61b4-4119-929b-e52ef624f718"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("4b1606b8-26b2-466b-9135-1167317fea23"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("4b1606b8-26b2-466b-9135-1167317fea23"),
				Name = @"MessageText",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Text")
			};
			messageTextParameter.SourceValue = new ProcessSchemaParameterValue(messageTextParameter) {
				Source = ProcessSchemaParameterValueSource.ConstValue,
				Value = @"Everybody, say HI!",
				MetaPath = null,
				ModifiedInSchemaUId = new Guid("b469eddc-e461-48b7-a02a-0131706ea155")
			};
			parametrizedElement.Parameters.Add(messageTextParameter);
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
			ProcessSchemaUserTask sayhitoallconnectedusersusertask = CreateSayHiToAllConnectedUsersUserTaskUserTask();
			FlowElements.Add(sayhitoallconnectedusersusertask);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("aff3dd9e-7c02-4432-b305-f59363dc54d1"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("d5227176-6716-4fb5-bba8-cc5a2de7deeb"),
				CreatedInSchemaUId = new Guid("b469eddc-e461-48b7-a02a-0131706ea155"),
				CurveCenterPosition = new Point(262, 203),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("b469eddc-e461-48b7-a02a-0131706ea155"),
				Size = new Size(0, 0),
				SourceRefUId = new Guid("39122d5b-9f6f-463a-9e0a-b07813f54dca"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("8373d1ca-61b4-4119-929b-e52ef624f718"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("0329447c-3969-4a02-99c9-b6542e43b9e8"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("d5227176-6716-4fb5-bba8-cc5a2de7deeb"),
				CreatedInSchemaUId = new Guid("b469eddc-e461-48b7-a02a-0131706ea155"),
				CurveCenterPosition = new Point(373, 203),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("b469eddc-e461-48b7-a02a-0131706ea155"),
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("8373d1ca-61b4-4119-929b-e52ef624f718"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("59291c97-2e44-4c07-a3c5-da52619495a1"),
				TargetSequenceFlowPointLocalPosition = new Point(0, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("56a547fd-3b26-46f9-a657-96e0ca1a24ba"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("d5227176-6716-4fb5-bba8-cc5a2de7deeb"),
				CreatedInSchemaUId = new Guid("b469eddc-e461-48b7-a02a-0131706ea155"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("b469eddc-e461-48b7-a02a-0131706ea155"),
				Name = @"LaneSet1",
				Position = new Point(5, 5),
				Size = new Size(732, 400),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("e1585419-9dea-4c3e-b0ac-eda4bca86b8b"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("56a547fd-3b26-46f9-a657-96e0ca1a24ba"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("d5227176-6716-4fb5-bba8-cc5a2de7deeb"),
				CreatedInSchemaUId = new Guid("b469eddc-e461-48b7-a02a-0131706ea155"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("b469eddc-e461-48b7-a02a-0131706ea155"),
				Name = @"Lane1",
				Position = new Point(29, 0),
				Size = new Size(703, 400),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaStartEvent CreateStart1StartEvent() {
			ProcessSchemaStartEvent schemaStartEvent = new ProcessSchemaStartEvent(this) {
				UId = new Guid("39122d5b-9f6f-463a-9e0a-b07813f54dca"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e1585419-9dea-4c3e-b0ac-eda4bca86b8b"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("d5227176-6716-4fb5-bba8-cc5a2de7deeb"),
				CreatedInSchemaUId = new Guid("b469eddc-e461-48b7-a02a-0131706ea155"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("53818048-7868-48f6-ada0-0ebaa65af628"),
				ModifiedInSchemaUId = new Guid("b469eddc-e461-48b7-a02a-0131706ea155"),
				Name = @"Start1",
				Position = new Point(50, 184),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartEvent;
		}

		protected virtual ProcessSchemaEndEvent CreateEnd1EndEvent() {
			ProcessSchemaEndEvent schemaEndEvent = new ProcessSchemaEndEvent(this) {
				UId = new Guid("59291c97-2e44-4c07-a3c5-da52619495a1"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e1585419-9dea-4c3e-b0ac-eda4bca86b8b"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("d5227176-6716-4fb5-bba8-cc5a2de7deeb"),
				CreatedInSchemaUId = new Guid("b469eddc-e461-48b7-a02a-0131706ea155"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				IsLogging = false,
				ManagerItemUId = new Guid("45ceaae2-4e1f-4c0c-86aa-cd4aeb4da913"),
				ModifiedInSchemaUId = new Guid("b469eddc-e461-48b7-a02a-0131706ea155"),
				Name = @"End1",
				Position = new Point(421, 184),
				SerializeToDB = false,
				Size = new Size(0, 0),
				ThrowToBase = false,
				UseBackgroundMode = false
			};
			
			return schemaEndEvent;
		}

		protected virtual ProcessSchemaUserTask CreateSayHiToAllConnectedUsersUserTaskUserTask() {
			ProcessSchemaUserTask schemaTask = new ProcessSchemaUserTask(this) {
				UId = new Guid("8373d1ca-61b4-4119-929b-e52ef624f718"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e1585419-9dea-4c3e-b0ac-eda4bca86b8b"),
				CreatedInOwnerSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d"),
				CreatedInPackageId = new Guid("d5227176-6716-4fb5-bba8-cc5a2de7deeb"),
				CreatedInSchemaUId = new Guid("b469eddc-e461-48b7-a02a-0131706ea155"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("1418e61a-82c3-403e-8221-01088f52c125"),
				ModifiedInSchemaUId = new Guid("b469eddc-e461-48b7-a02a-0131706ea155"),
				Name = @"SayHiToAllConnectedUsersUserTask",
				OwnerSchemaManagerName = @"ProcessSchemaManager",
				Position = new Point(232, 170),
				SchemaUId = new Guid("4b1606b8-26b2-466b-9135-1167317fea23"),
				SerializeToDB = false,
				Size = new Size(0, 0),
				TaskSchemaManagerName = @"ProcessUserTaskSchemaManager",
				UseBackgroundMode = false,
				ZipAfterActivitySaveScript = new byte[] {  }
			};
			InitializeSayHiToAllConnectedUsersUserTaskParameters(schemaTask);
			return schemaTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		#endregion

		#region Methods: Public

		public override Process CreateProcess(UserConnection userConnection) {
			return new NotificationTestProcess(userConnection);
		}

		public override object Clone() {
			return new NotificationTestProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b469eddc-e461-48b7-a02a-0131706ea155"));
		}

		#endregion

	}

	#endregion

	#region Class: NotificationTestProcess

	/// <exclude/>
	public class NotificationTestProcess : Terrasoft.Core.Process.Process
	{

		#region Class: ProcessLane1

		/// <exclude/>
		public class ProcessLane1 : ProcessLane
		{

			public ProcessLane1(UserConnection userConnection, NotificationTestProcess process)
				: base(userConnection) {
				Owner = process;
				IsUsedParentUserContexts = false;
			}

		}

		#endregion

		#region Class: SayHiToAllConnectedUsersUserTaskFlowElement

		/// <exclude/>
		public class SayHiToAllConnectedUsersUserTaskFlowElement : PostUserMessageUserTask
		{

			#region Constructors: Public

			public SayHiToAllConnectedUsersUserTaskFlowElement(UserConnection userConnection, NotificationTestProcess process)
				: base(userConnection) {
				UId = Guid.NewGuid();
				Owner = process;
				Type = "ProcessSchemaUserTask";
				Name = "SayHiToAllConnectedUsersUserTask";
				IsLogging = false;
				SchemaElementUId = new Guid("8373d1ca-61b4-4119-929b-e52ef624f718");
				CreatedInSchemaUId = process.InternalSchemaUId;
			}

			#endregion

			#region Properties: Public

			private bool _sendForAll = true;
			public override bool SendForAll {
				get {
					return _sendForAll;
				}
				set {
					_sendForAll = value;
				}
			}

			private string _senderName;
			public override string SenderName {
				get {
					return _senderName ?? (_senderName = GetLocalizableString("b469eddce46148b7a02a0131706ea155",
						 "BaseElements.SayHiToAllConnectedUsersUserTask.Parameters.SenderName.Value"));
				}
				set {
					_senderName = value;
				}
			}

			private string _messageText;
			public override string MessageText {
				get {
					return _messageText ?? (_messageText = GetLocalizableString("b469eddce46148b7a02a0131706ea155",
						 "BaseElements.SayHiToAllConnectedUsersUserTask.Parameters.MessageText.Value"));
				}
				set {
					_messageText = value;
				}
			}

			#endregion

		}

		#endregion

		public NotificationTestProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "NotificationTestProcess";
			SchemaUId = new Guid("b469eddc-e461-48b7-a02a-0131706ea155");
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
				return new Guid("b469eddc-e461-48b7-a02a-0131706ea155");
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

		private ProcessFlowElement _start1;
		public  ProcessFlowElement Start1 {
			get {
				return _start1 ?? (_start1 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartEvent",
					Name = "Start1",
					SchemaElementUId = new Guid("39122d5b-9f6f-463a-9e0a-b07813f54dca"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessEndEvent _end1;
		public  ProcessEndEvent End1 {
			get {
				return _end1 ?? (_end1 = new ProcessEndEvent() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEndEvent",
					Name = "End1",
					SchemaElementUId = new Guid("59291c97-2e44-4c07-a3c5-da52619495a1"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private SayHiToAllConnectedUsersUserTaskFlowElement _sayHiToAllConnectedUsersUserTask;
		public  SayHiToAllConnectedUsersUserTaskFlowElement SayHiToAllConnectedUsersUserTask {
			get {
				return _sayHiToAllConnectedUsersUserTask ?? (_sayHiToAllConnectedUsersUserTask = new SayHiToAllConnectedUsersUserTaskFlowElement(UserConnection, this) { ExecutedEventHandler = OnExecuted });
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[Start1.SchemaElementUId] = new Collection<ProcessFlowElement> { Start1 };
			FlowElements[End1.SchemaElementUId] = new Collection<ProcessFlowElement> { End1 };
			FlowElements[SayHiToAllConnectedUsersUserTask.SchemaElementUId] = new Collection<ProcessFlowElement> { SayHiToAllConnectedUsersUserTask };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "Start1":
						e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("SayHiToAllConnectedUsersUserTask", e.Context.SenderName));
						break;
					case "End1":
						CompleteProcess();
						break;
					case "SayHiToAllConnectedUsersUserTask":
							e.Context.QueueTasksV2.Enqueue(new ProcessQueueElement("End1", e.Context.SenderName));
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
			MetaPathParameterValues.Add("f1e72eb5-f171-4b5c-967b-4aeeada71896", () => SayHiToAllConnectedUsersUserTask.SendForAll);
			MetaPathParameterValues.Add("37ef9b0a-e392-47a7-ad6a-4dacf134f636", () => SayHiToAllConnectedUsersUserTask.TargetUserIdsKey);
			MetaPathParameterValues.Add("c526d4de-f583-4991-9958-36c1b4a80141", () => SayHiToAllConnectedUsersUserTask.SenderName);
			MetaPathParameterValues.Add("077529b0-043e-458b-acaf-8dcb10bc6db4", () => SayHiToAllConnectedUsersUserTask.MessageText);
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
			var cloneItem = (NotificationTestProcess)base.CloneShallow();
			cloneItem.ExecutedEventHandler = ExecutedEventHandler;
			return cloneItem;
		}

		#endregion

	}

	#endregion

}

