﻿namespace Terrasoft.Configuration
{

	using DataContract = Terrasoft.Nui.ServiceModel.DataContract;
	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Data;
	using System.Drawing;
	using System.Globalization;
	using System.IO;
	using System.Linq;
	using Terrasoft.Common;
	using Terrasoft.Common.Json;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.DcmProcess;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Factories;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities.Json.Converters;

	#region Class: File_LinkPreview_TerrasoftSchema

	/// <exclude/>
	public class File_LinkPreview_TerrasoftSchema : Terrasoft.Configuration.File_Base_TerrasoftSchema
	{

		#region Constructors: Public

		public File_LinkPreview_TerrasoftSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public File_LinkPreview_TerrasoftSchema(File_LinkPreview_TerrasoftSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public File_LinkPreview_TerrasoftSchema(File_LinkPreview_TerrasoftSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			RealUId = new Guid("08733c65-57eb-48ac-8170-aef1c0d0bdfd");
			Name = "File_LinkPreview_Terrasoft";
			ParentSchemaUId = new Guid("556c5867-60a7-4456-aae1-a57a122bef70");
			ExtendParent = true;
			CreatedInPackageId = new Guid("8a6b5719-da97-4634-8f04-4375bc29ffcf");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateFile_LinkPreview_TerrasoftEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateFile_LinkPreview_TerrasoftEventsProcessSchema() {
			var schema = new File_LinkPreview_TerrasoftEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new File_LinkPreview_Terrasoft(userConnection){Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new File_LinkPreviewEventsProcess(userConnnection);
		}

		public override object Clone() {
			return new File_LinkPreview_TerrasoftSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new File_LinkPreview_TerrasoftSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("08733c65-57eb-48ac-8170-aef1c0d0bdfd"));
		}

		#endregion

	}

	#endregion

	#region Class: File_LinkPreview_Terrasoft

	/// <summary>
	/// File.
	/// </summary>
	public class File_LinkPreview_Terrasoft : Terrasoft.Configuration.File_Base_Terrasoft
	{

		#region Constructors: Public

		public File_LinkPreview_Terrasoft(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "File_LinkPreview_Terrasoft";
		}

		public File_LinkPreview_Terrasoft(File_LinkPreview_Terrasoft source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new File_LinkPreviewEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("File_LinkPreview_TerrasoftDeleted", e);
			Updated += (s, e) => ThrowEvent("File_LinkPreview_TerrasoftUpdated", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new File_LinkPreview_Terrasoft(this);
		}

		#endregion

	}

	#endregion

	#region Class: File_LinkPreviewEventsProcess

	/// <exclude/>
	public class File_LinkPreviewEventsProcess<TEntity> : Terrasoft.Configuration.File_BaseEventsProcess<TEntity> where TEntity : File_LinkPreview_Terrasoft
	{

		public File_LinkPreviewEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "File_LinkPreviewEventsProcess";
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("08733c65-57eb-48ac-8170-aef1c0d0bdfd");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
			}
			if (!result && context.QueueTasks.Count > 0) {
				ProcessQueue(context);
			}
			return result;
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

		#endregion

		#region Methods: Public

		public virtual bool IsURLValid(string url) {
			Uri uriResult;
			return Uri.TryCreate(url, UriKind.Absolute, out uriResult) && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);
		}

		public override void OnFileSaved() {
			base.OnFileSaved();
			
			if (!UserConnection.GetIsFeatureEnabled("LinkPreview")) {
				return;
			}
			
			var fileType = Entity.GetTypedColumnValue<Guid>("TypeId");
			if (fileType == Terrasoft.WebApp.FileConsts.LinkTypeUId) {
				var url = Entity.GetTypedColumnValue<string>("Name").Trim();
				if (IsURLValid(url)) {
					LinkPreview linkPreview = new LinkPreview();
					LinkPreviewInfo linkPreviewInfo = linkPreview.GetWebPageLinkPreview(url);
					if (linkPreviewInfo != null) {
						LinkPreviewProvider linkPreviewProvider = new LinkPreviewProvider(UserConnection);
						linkPreviewProvider.SaveLinkPreviewInfo(linkPreviewInfo, Entity.PrimaryColumnValue);
					}
				}
			}
		}

		public override void OnFileDeleted() {
			base.OnFileDeleted();
			
			if (!UserConnection.GetIsFeatureEnabled("LinkPreview")) {
				return;
			}
			
			var fileType = Entity.GetTypedColumnValue<Guid>("TypeId");
			if (fileType == Terrasoft.WebApp.FileConsts.LinkTypeUId) {
				LinkPreviewProvider linkPreviewProvider = new LinkPreviewProvider(UserConnection);
				linkPreviewProvider.DeleteLinkPreviewInfo(Entity.PrimaryColumnValue);
			}
		}

		public override void OnFileUpdated() {
			base.OnFileUpdated();
			
			if (!UserConnection.GetIsFeatureEnabled("LinkPreview")) {
				return;
			}
			
			var fileType = Entity.GetTypedColumnValue<Guid>("TypeId");
			string oldUrl = (string)Entity.GetColumnOldValue("Name");
			if (fileType == Terrasoft.WebApp.FileConsts.LinkTypeUId && IsURLValid(oldUrl)) {
				LinkPreviewProvider linkPreviewProvider = new LinkPreviewProvider(UserConnection);
				linkPreviewProvider.DeleteLinkPreviewInfo(Entity.PrimaryColumnValue);
			}
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			base.ThrowEvent(context, message);
			ProcessQueue(context);
		}

		public override void WritePropertiesData(DataWriter writer, bool writeFlowElements = true) {
			base.WritePropertiesData(writer, writeFlowElements);
		}

		public override object CloneShallow() {
			return base.CloneShallow();
		}

		#endregion

	}

	#endregion

	#region Class: File_LinkPreviewEventsProcess

	/// <exclude/>
	public class File_LinkPreviewEventsProcess : File_LinkPreviewEventsProcess<File_LinkPreview_Terrasoft>
	{

		public File_LinkPreviewEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: File_LinkPreview_TerrasoftEventsProcessSchema

	/// <exclude/>
	public class File_LinkPreview_TerrasoftEventsProcessSchema : Terrasoft.Configuration.File_Base_TerrasoftEventsProcessSchema
	{

		#region Constructors: Public

		public File_LinkPreview_TerrasoftEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public File_LinkPreview_TerrasoftEventsProcessSchema(File_LinkPreview_TerrasoftEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "File_LinkPreviewEventsProcess";
			UId = new Guid("ea891993-927a-4357-843d-3b4864355587");
			CreatedInPackageId = new Guid("8a6b5719-da97-4634-8f04-4375bc29ffcf");
			CreatedInSchemaUId = Guid.Empty;
			CreatedInVersion = @"0.0.0.0";
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("46370786-d48d-4d24-916a-dc11d551add9");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet2_e63e175ae09d4c529e3a647db841c8ff = CreateLaneSet2_e63e175ae09d4c529e3a647db841c8ffLaneSet();
			LaneSets.Add(schemaLaneSet2_e63e175ae09d4c529e3a647db841c8ff);
			ProcessSchemaLane schemaLane3_31593a4720f3426ab062fa94cf624785 = CreateLane3_31593a4720f3426ab062fa94cf624785Lane();
			schemaLaneSet2_e63e175ae09d4c529e3a647db841c8ff.Lanes.Add(schemaLane3_31593a4720f3426ab062fa94cf624785);
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet2_e63e175ae09d4c529e3a647db841c8ffLaneSet() {
			ProcessSchemaLaneSet schemaLaneSet2_e63e175ae09d4c529e3a647db841c8ff = new ProcessSchemaLaneSet(this) {
				UId = new Guid("e63e175a-e09d-4c52-9e3a-647db841c8ff"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("46370786-d48d-4d24-916a-dc11d551add9"),
				CreatedInPackageId = new Guid("8a6b5719-da97-4634-8f04-4375bc29ffcf"),
				CreatedInSchemaUId = new Guid("ea891993-927a-4357-843d-3b4864355587"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("ea891993-927a-4357-843d-3b4864355587"),
				Name = @"LaneSet2_e63e175ae09d4c529e3a647db841c8ff",
				Position = new Point(0, 5),
				Size = new Size(0, 400),
				UseBackgroundMode = false
			};
			return schemaLaneSet2_e63e175ae09d4c529e3a647db841c8ff;
		}

		protected virtual ProcessSchemaLane CreateLane3_31593a4720f3426ab062fa94cf624785Lane() {
			ProcessSchemaLane schemaLane3_31593a4720f3426ab062fa94cf624785 = new ProcessSchemaLane(this) {
				UId = new Guid("31593a47-20f3-426a-b062-fa94cf624785"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("e63e175a-e09d-4c52-9e3a-647db841c8ff"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("8a6b5719-da97-4634-8f04-4375bc29ffcf"),
				CreatedInSchemaUId = new Guid("ea891993-927a-4357-843d-3b4864355587"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("ea891993-927a-4357-843d-3b4864355587"),
				Name = @"Lane3_31593a4720f3426ab062fa94cf624785",
				Position = new Point(0, 0),
				Size = new Size(700, 400),
				UseBackgroundMode = false
			};
			return schemaLane3_31593a4720f3426ab062fa94cf624785;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateIsURLValidMethod());
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("fb7b81ba-7c3c-45a5-ae9e-c6c03dceb812"),
				Name = "Terrasoft.UI.WebControls.Controls",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("cde525cf-d220-4d2a-b963-e55254c639fc"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5c9c82c6-ba6d-4a57-9a14-87fe8faa4ebb"),
				Name = "Terrasoft.Core.DB",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7821de68-c82b-4917-a6cd-add2adfbe400"),
				Name = "Terrasoft.Common",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d67de76f-9cbc-4bfc-babb-6f65cb89b973"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("74160d3b-65e3-4694-b554-089f2d980e54"),
				Name = "Newtonsoft.Json",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e401300a-9f16-40c2-9788-cf310ae9d1c5"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("8344487b-4f62-45ad-a3a1-e073f07b2ef2"),
				Name = "System.Collections.Generic",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e33423da-6c95-41fd-bf98-97c4161975e5"),
				Name = "System.Linq",
				Alias = "",
				CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d5bb3512-71e0-482a-9c7e-16bf22c586b7"),
				Name = "Terrasoft.Nui.ServiceModel.DataContract",
				Alias = "DataContract",
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("b261d1c9-cc98-44e8-aabd-7806d1dc26ed"),
				Name = "Terrasoft.Core.Factories",
				Alias = "",
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("c261d1c9-cc98-44e8-aabd-7806d1dc26ec"),
				Name = "Terrasoft.Core.DcmProcess",
				Alias = "",
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("36db9306-521c-4d94-87c4-a02688862caa"),
				Name = "Terrasoft.Configuration",
				Alias = "",
				CreatedInPackageId = new Guid("8a6b5719-da97-4634-8f04-4375bc29ffcf")
			});
		}

		protected override SchemaMethod CreateOnFileSavedMethod() {
			SchemaMethod method = base.CreateOnFileSavedMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,146,97,75,195,48,16,134,63,55,191,34,235,167,22,36,127,96,86,16,217,70,97,104,209,77,63,103,230,58,130,89,58,46,105,101,200,254,187,119,29,211,56,69,40,165,189,188,247,190,207,93,187,209,1,212,131,159,91,7,79,122,0,83,148,83,33,108,43,139,201,58,0,222,117,222,195,107,180,157,87,11,136,117,152,131,142,61,194,204,235,141,35,109,190,180,254,173,65,24,44,188,231,101,41,63,68,134,64,2,63,21,71,33,6,141,178,37,223,213,97,15,178,146,51,31,109,60,176,15,23,204,93,231,250,157,127,214,174,135,235,69,111,205,77,145,115,189,54,57,17,48,192,119,107,37,87,128,168,67,215,70,245,2,155,219,253,94,49,47,193,133,24,20,51,176,110,93,155,145,128,99,123,116,255,39,134,136,214,111,41,243,94,239,32,47,213,10,237,142,71,207,56,185,14,235,199,37,233,172,41,200,232,52,87,150,140,42,93,242,92,73,79,247,228,116,180,73,229,181,111,187,180,101,124,175,210,10,35,210,96,141,222,66,106,196,225,236,197,76,151,253,19,202,237,157,59,177,165,105,13,118,131,53,128,169,255,87,237,23,236,249,164,248,249,181,199,216,236,15,7,197,63,201,197,108,151,108,87,231,197,55,180,84,141,135,100,239,163,239,81,208,117,252,4,151,226,200,158,121,2,0,0 };
			return method;
		}

		protected override SchemaMethod CreateOnFileDeletedMethod() {
			SchemaMethod method = base.CreateOnFileDeletedMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,144,193,106,195,48,24,131,207,245,83,120,57,37,23,191,64,151,193,232,218,18,24,44,135,118,59,59,179,2,102,238,239,240,219,73,9,163,239,62,123,27,44,131,92,133,36,62,169,211,1,234,133,14,214,225,9,14,17,166,172,182,66,216,94,150,119,231,0,222,121,34,188,71,235,73,29,17,155,112,128,142,35,99,79,186,115,201,91,60,91,250,104,25,147,197,181,168,42,249,41,54,140,100,160,173,184,9,49,105,150,125,106,62,205,3,100,45,247,20,109,156,115,79,22,204,206,187,241,66,175,218,141,184,63,142,214,60,148,69,214,27,83,36,130,12,240,23,173,229,9,204,58,248,62,170,55,116,143,195,160,50,113,130,11,49,168,204,144,125,231,198,124,19,44,152,90,246,147,53,96,233,86,180,90,18,174,114,197,93,254,95,158,112,54,43,121,245,115,216,34,223,80,239,203,223,149,45,219,139,230,121,49,50,213,220,190,0,132,181,32,12,111,1,0,0 };
			return method;
		}

		protected override SchemaMethod CreateOnFileUpdatedMethod() {
			SchemaMethod method = base.CreateOnFileUpdatedMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,144,193,106,195,48,16,68,207,241,87,108,125,8,242,69,63,144,186,80,210,36,24,66,99,74,220,158,229,104,93,68,101,201,172,100,7,83,242,239,149,234,66,92,240,117,152,121,59,179,181,112,200,79,102,175,52,86,157,20,30,37,203,54,73,162,26,96,15,149,67,218,90,99,240,226,149,53,252,128,190,112,123,20,190,39,220,25,81,235,224,77,143,202,124,149,132,131,194,107,154,101,240,157,172,8,131,193,108,146,91,146,12,130,160,9,228,243,216,33,228,176,51,94,249,49,114,162,32,183,86,247,173,121,23,186,199,199,67,175,228,19,75,163,94,200,52,52,112,158,148,249,4,171,101,69,58,100,217,36,100,119,198,20,63,105,249,75,96,233,171,104,49,38,99,245,251,209,28,206,72,36,156,109,60,255,192,250,185,235,120,220,26,102,57,239,120,108,31,125,85,33,97,189,134,194,85,111,199,128,83,146,77,135,167,69,179,141,37,217,65,73,36,208,11,90,14,6,175,176,224,102,255,63,25,74,174,22,242,252,5,53,122,156,229,11,211,88,246,183,184,36,213,10,26,103,79,11,152,219,15,145,52,136,152,191,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateIsURLValidMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("30531931-bc96-4c47-9ee8-43f0b0726637"),
				Name = "IsURLValid",
				CreatedInSchemaUId = new Guid("ea891993-927a-4357-843d-3b4864355587"),
				CreatedInPackageId = new Guid("8a6b5719-da97-4634-8f04-4375bc29ffcf"),
				ResultValueTypeName = "bool"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("4b1eb36f-7711-4c02-83d4-0982d7360417"),
				Name = "url",
				CreatedInSchemaUId = new Guid("ea891993-927a-4357-843d-3b4864355587"),
				ModifiedInSchemaUId = new Guid("ea891993-927a-4357-843d-3b4864355587"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("8a6b5719-da97-4634-8f04-4375bc29ffcf")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,45,202,84,40,45,202,12,74,45,46,205,41,177,230,229,42,74,45,41,45,202,83,8,45,202,212,11,41,170,116,46,74,77,44,73,213,40,45,202,209,1,9,121,103,230,165,232,57,38,21,231,231,148,150,164,234,40,228,151,150,32,244,106,42,168,169,41,104,192,185,122,193,201,25,169,185,169,10,182,182,96,179,128,24,34,224,81,82,82,160,80,83,163,64,148,194,98,77,107,0,248,66,180,230,160,0,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new File_LinkPreview_TerrasoftEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ea891993-927a-4357-843d-3b4864355587"));
		}

		#endregion

	}

	#endregion

}

