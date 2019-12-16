namespace Terrasoft.Configuration
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
	using Terrasoft.Core;
	using Terrasoft.Core.Campaign;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.DcmProcess;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Factories;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;
	using Terrasoft.GlobalSearch.Indexing;
	using Terrasoft.Nui.ServiceModel.WebService;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities.Json.Converters;

	#region Class: CampaignSchema

	/// <exclude/>
	public class CampaignSchema : Terrasoft.Configuration.DiagramSchema
	{

		#region Constructors: Public

		public CampaignSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public CampaignSchema(CampaignSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public CampaignSchema(CampaignSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("1f9bb71a-eb9c-4220-a40e-9b623eacfec8");
			RealUId = new Guid("1f9bb71a-eb9c-4220-a40e-9b623eacfec8");
			Name = "Campaign";
			ParentSchemaUId = new Guid("92dc123e-a3cc-4430-8c79-127fee51cee8");
			ExtendParent = false;
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializePrimaryDisplayColumn() {
			base.InitializePrimaryDisplayColumn();
			PrimaryDisplayColumn = CreateNameColumn();
			if (Columns.FindByUId(PrimaryDisplayColumn.UId) == null) {
				Columns.Add(PrimaryDisplayColumn);
			}
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("da323fb1-f216-4cb7-8a4c-e785dda94b8a")) == null) {
				Columns.Add(CreateCampaignStatusColumn());
			}
			if (Columns.FindByUId(new Guid("814b1db4-05bf-46a1-9dbf-78f4000f35e6")) == null) {
				Columns.Add(CreateSegmentsStatusColumn());
			}
			if (Columns.FindByUId(new Guid("5346e7fe-738c-4806-8fb5-131b63df3659")) == null) {
				Columns.Add(CreateSchemaDataColumn());
			}
			if (Columns.FindByUId(new Guid("6bfcc02e-0a48-450d-af48-78fb42719710")) == null) {
				Columns.Add(CreateNotesColumn());
			}
			if (Columns.FindByUId(new Guid("fc244e14-7755-4afb-85bf-b52dee45082f")) == null) {
				Columns.Add(CreateTargetDescriptionColumn());
			}
			if (Columns.FindByUId(new Guid("7f7bacd5-5a9f-4ba6-b189-f8ee9cad5bbc")) == null) {
				Columns.Add(CreateTargetPercentColumn());
			}
			if (Columns.FindByUId(new Guid("200745d2-e08f-4375-9510-a56f6ec2ef68")) == null) {
				Columns.Add(CreateTargetTotalColumn());
			}
			if (Columns.FindByUId(new Guid("ddaedc58-c72e-4027-b6a4-49e8e1779d18")) == null) {
				Columns.Add(CreateTargetAchieveColumn());
			}
			if (Columns.FindByUId(new Guid("42be20e4-c94e-49c8-b5aa-8ebd934e402d")) == null) {
				Columns.Add(CreateStartDateColumn());
			}
			if (Columns.FindByUId(new Guid("ca4b78ea-def8-47f4-ab1a-5a886f374021")) == null) {
				Columns.Add(CreateEndDateColumn());
			}
			if (Columns.FindByUId(new Guid("d02e2ad3-6260-4fda-bdf7-6f36c8d72ee1")) == null) {
				Columns.Add(CreateOwnerColumn());
			}
			if (Columns.FindByUId(new Guid("e8bce7c6-2069-431b-9468-44d3bb0853c6")) == null) {
				Columns.Add(CreateUtmCampaignColumn());
			}
			if (Columns.FindByUId(new Guid("d5626c7f-75cd-4e01-8b4c-b87f18c0116c")) == null) {
				Columns.Add(CreateNextFireTimeColumn());
			}
			if (Columns.FindByUId(new Guid("1e3155d5-4d30-4251-9702-c2e1f26604be")) == null) {
				Columns.Add(CreateFirePeriodColumn());
			}
			if (Columns.FindByUId(new Guid("9d8bfd00-c71e-4b1d-9c46-bf271d18ef8f")) == null) {
				Columns.Add(CreateCampaignSchemaUIdColumn());
			}
			if (Columns.FindByUId(new Guid("876c6749-2c05-4861-856e-efd51b847904")) == null) {
				Columns.Add(CreateTypeColumn());
			}
			if (Columns.FindByUId(new Guid("6bb1e198-a9f2-44a7-a1eb-1ca3d38fc56c")) == null) {
				Columns.Add(CreateInProgressColumn());
			}
			if (Columns.FindByUId(new Guid("056c8a67-d92e-419f-aa9c-66a9c951ecaa")) == null) {
				Columns.Add(CreateScheduledStartModeColumn());
			}
			if (Columns.FindByUId(new Guid("e36a7fc0-326d-4dd8-ace7-78adc5fcd3bd")) == null) {
				Columns.Add(CreateScheduledStopModeColumn());
			}
			if (Columns.FindByUId(new Guid("5b85977f-dfdb-4d0b-b273-b36934d188e0")) == null) {
				Columns.Add(CreateScheduledStartDateColumn());
			}
			if (Columns.FindByUId(new Guid("aa365456-c611-43df-9d05-12b828091983")) == null) {
				Columns.Add(CreateScheduledStopDateColumn());
			}
			if (Columns.FindByUId(new Guid("80b80b2f-8cae-4b3b-b449-a647a503f3a6")) == null) {
				Columns.Add(CreatePrevExecutedOnColumn());
			}
		}

		protected virtual EntitySchemaColumn CreateNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("64744600-327d-4490-9dd8-2ed70e4ecb16"),
				Name = @"Name",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("1f9bb71a-eb9c-4220-a40e-9b623eacfec8"),
				ModifiedInSchemaUId = new Guid("1f9bb71a-eb9c-4220-a40e-9b623eacfec8"),
				CreatedInPackageId = new Guid("c130e4bc-accb-4cd0-8b02-dd2e4506d5d1")
			};
		}

		protected virtual EntitySchemaColumn CreateCampaignStatusColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("da323fb1-f216-4cb7-8a4c-e785dda94b8a"),
				Name = @"CampaignStatus",
				ReferenceSchemaUId = new Guid("24e4fd5c-7bd2-436e-90b3-01d658f659e5"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsValueCloneable = false,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("1f9bb71a-eb9c-4220-a40e-9b623eacfec8"),
				ModifiedInSchemaUId = new Guid("1f9bb71a-eb9c-4220-a40e-9b623eacfec8"),
				CreatedInPackageId = new Guid("c130e4bc-accb-4cd0-8b02-dd2e4506d5d1"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"24b80784-2172-4903-94ad-ca1fddf368dd"
				}
			};
		}

		protected virtual EntitySchemaColumn CreateSegmentsStatusColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("814b1db4-05bf-46a1-9dbf-78f4000f35e6"),
				Name = @"SegmentsStatus",
				ReferenceSchemaUId = new Guid("80ea7f5b-3991-42c6-bc29-f101d9757c70"),
				IsValueCloneable = false,
				IsIndexed = true,
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("1f9bb71a-eb9c-4220-a40e-9b623eacfec8"),
				ModifiedInSchemaUId = new Guid("1f9bb71a-eb9c-4220-a40e-9b623eacfec8"),
				CreatedInPackageId = new Guid("781fc653-c4cb-4c1b-b941-83a6b0fc8787")
			};
		}

		protected virtual EntitySchemaColumn CreateSchemaDataColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("5346e7fe-738c-4806-8fb5-131b63df3659"),
				Name = @"SchemaData",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("1f9bb71a-eb9c-4220-a40e-9b623eacfec8"),
				ModifiedInSchemaUId = new Guid("1f9bb71a-eb9c-4220-a40e-9b623eacfec8"),
				CreatedInPackageId = new Guid("781fc653-c4cb-4c1b-b941-83a6b0fc8787")
			};
		}

		protected virtual EntitySchemaColumn CreateNotesColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("6bfcc02e-0a48-450d-af48-78fb42719710"),
				Name = @"Notes",
				CreatedInSchemaUId = new Guid("1f9bb71a-eb9c-4220-a40e-9b623eacfec8"),
				ModifiedInSchemaUId = new Guid("1f9bb71a-eb9c-4220-a40e-9b623eacfec8"),
				CreatedInPackageId = new Guid("c130e4bc-accb-4cd0-8b02-dd2e4506d5d1")
			};
		}

		protected virtual EntitySchemaColumn CreateTargetDescriptionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("LongText")) {
				UId = new Guid("fc244e14-7755-4afb-85bf-b52dee45082f"),
				Name = @"TargetDescription",
				CreatedInSchemaUId = new Guid("1f9bb71a-eb9c-4220-a40e-9b623eacfec8"),
				ModifiedInSchemaUId = new Guid("1f9bb71a-eb9c-4220-a40e-9b623eacfec8"),
				CreatedInPackageId = new Guid("4599b6ca-e1c5-4079-81de-c3db847907d5")
			};
		}

		protected virtual EntitySchemaColumn CreateTargetPercentColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float1")) {
				UId = new Guid("7f7bacd5-5a9f-4ba6-b189-f8ee9cad5bbc"),
				Name = @"TargetPercent",
				CreatedInSchemaUId = new Guid("1f9bb71a-eb9c-4220-a40e-9b623eacfec8"),
				ModifiedInSchemaUId = new Guid("1f9bb71a-eb9c-4220-a40e-9b623eacfec8"),
				CreatedInPackageId = new Guid("4599b6ca-e1c5-4079-81de-c3db847907d5"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"20"
				}
			};
		}

		protected virtual EntitySchemaColumn CreateTargetTotalColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("200745d2-e08f-4375-9510-a56f6ec2ef68"),
				Name = @"TargetTotal",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("1f9bb71a-eb9c-4220-a40e-9b623eacfec8"),
				ModifiedInSchemaUId = new Guid("1f9bb71a-eb9c-4220-a40e-9b623eacfec8"),
				CreatedInPackageId = new Guid("4599b6ca-e1c5-4079-81de-c3db847907d5")
			};
		}

		protected virtual EntitySchemaColumn CreateTargetAchieveColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("ddaedc58-c72e-4027-b6a4-49e8e1779d18"),
				Name = @"TargetAchieve",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("1f9bb71a-eb9c-4220-a40e-9b623eacfec8"),
				ModifiedInSchemaUId = new Guid("1f9bb71a-eb9c-4220-a40e-9b623eacfec8"),
				CreatedInPackageId = new Guid("4599b6ca-e1c5-4079-81de-c3db847907d5")
			};
		}

		protected virtual EntitySchemaColumn CreateStartDateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("DateTime")) {
				UId = new Guid("42be20e4-c94e-49c8-b5aa-8ebd934e402d"),
				Name = @"StartDate",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("1f9bb71a-eb9c-4220-a40e-9b623eacfec8"),
				ModifiedInSchemaUId = new Guid("1f9bb71a-eb9c-4220-a40e-9b623eacfec8"),
				CreatedInPackageId = new Guid("42d0960f-8407-46cb-ba61-91a196c15c22")
			};
		}

		protected virtual EntitySchemaColumn CreateEndDateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("DateTime")) {
				UId = new Guid("ca4b78ea-def8-47f4-ab1a-5a886f374021"),
				Name = @"EndDate",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("1f9bb71a-eb9c-4220-a40e-9b623eacfec8"),
				ModifiedInSchemaUId = new Guid("1f9bb71a-eb9c-4220-a40e-9b623eacfec8"),
				CreatedInPackageId = new Guid("42d0960f-8407-46cb-ba61-91a196c15c22")
			};
		}

		protected virtual EntitySchemaColumn CreateOwnerColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("d02e2ad3-6260-4fda-bdf7-6f36c8d72ee1"),
				Name = @"Owner",
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("1f9bb71a-eb9c-4220-a40e-9b623eacfec8"),
				ModifiedInSchemaUId = new Guid("1f9bb71a-eb9c-4220-a40e-9b623eacfec8"),
				CreatedInPackageId = new Guid("0de0e6ea-5e2d-4477-ae5d-f5fee951a20a"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.SystemValue,
					ValueSource = SystemValueManager.GetInstanceByName(@"CurrentUserContact")
				}
			};
		}

		protected virtual EntitySchemaColumn CreateUtmCampaignColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("e8bce7c6-2069-431b-9468-44d3bb0853c6"),
				Name = @"UtmCampaign",
				CreatedInSchemaUId = new Guid("1f9bb71a-eb9c-4220-a40e-9b623eacfec8"),
				ModifiedInSchemaUId = new Guid("1f9bb71a-eb9c-4220-a40e-9b623eacfec8"),
				CreatedInPackageId = new Guid("f0968537-4bb9-4c0d-9a09-6db8469be2f9")
			};
		}

		protected virtual EntitySchemaColumn CreateNextFireTimeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("DateTime")) {
				UId = new Guid("d5626c7f-75cd-4e01-8b4c-b87f18c0116c"),
				Name = @"NextFireTime",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("1f9bb71a-eb9c-4220-a40e-9b623eacfec8"),
				ModifiedInSchemaUId = new Guid("1f9bb71a-eb9c-4220-a40e-9b623eacfec8"),
				CreatedInPackageId = new Guid("d85e35ee-2806-46ef-b091-5e59d47f9067")
			};
		}

		protected virtual EntitySchemaColumn CreateFirePeriodColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("1e3155d5-4d30-4251-9702-c2e1f26604be"),
				Name = @"FirePeriod",
				CreatedInSchemaUId = new Guid("1f9bb71a-eb9c-4220-a40e-9b623eacfec8"),
				ModifiedInSchemaUId = new Guid("1f9bb71a-eb9c-4220-a40e-9b623eacfec8"),
				CreatedInPackageId = new Guid("d85e35ee-2806-46ef-b091-5e59d47f9067")
			};
		}

		protected virtual EntitySchemaColumn CreateCampaignSchemaUIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("9d8bfd00-c71e-4b1d-9c46-bf271d18ef8f"),
				Name = @"CampaignSchemaUId",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("1f9bb71a-eb9c-4220-a40e-9b623eacfec8"),
				ModifiedInSchemaUId = new Guid("1f9bb71a-eb9c-4220-a40e-9b623eacfec8"),
				CreatedInPackageId = new Guid("0fa99f9a-3eca-422f-9a3c-3294c39b5190")
			};
		}

		protected virtual EntitySchemaColumn CreateTypeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("876c6749-2c05-4861-856e-efd51b847904"),
				Name = @"Type",
				ReferenceSchemaUId = new Guid("c108f0cd-e885-45c8-8f15-3a0929c05a70"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("1f9bb71a-eb9c-4220-a40e-9b623eacfec8"),
				ModifiedInSchemaUId = new Guid("1f9bb71a-eb9c-4220-a40e-9b623eacfec8"),
				CreatedInPackageId = new Guid("0fa99f9a-3eca-422f-9a3c-3294c39b5190"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"389eb587-52d4-4ab6-b4ad-e7e2f0d62eac"
				}
			};
		}

		protected virtual EntitySchemaColumn CreateInProgressColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("6bb1e198-a9f2-44a7-a1eb-1ca3d38fc56c"),
				Name = @"InProgress",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("1f9bb71a-eb9c-4220-a40e-9b623eacfec8"),
				ModifiedInSchemaUId = new Guid("1f9bb71a-eb9c-4220-a40e-9b623eacfec8"),
				CreatedInPackageId = new Guid("0fa99f9a-3eca-422f-9a3c-3294c39b5190"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"False"
				}
			};
		}

		protected virtual EntitySchemaColumn CreateScheduledStartModeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("056c8a67-d92e-419f-aa9c-66a9c951ecaa"),
				Name = @"ScheduledStartMode",
				ReferenceSchemaUId = new Guid("5335288b-38c7-456e-902b-e5768c03b448"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("1f9bb71a-eb9c-4220-a40e-9b623eacfec8"),
				ModifiedInSchemaUId = new Guid("1f9bb71a-eb9c-4220-a40e-9b623eacfec8"),
				CreatedInPackageId = new Guid("6c038aa0-46cd-4697-bc93-5c682e364aef"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"229d71cf-80c8-4158-ae9d-b0da644ed6a8"
				}
			};
		}

		protected virtual EntitySchemaColumn CreateScheduledStopModeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("e36a7fc0-326d-4dd8-ace7-78adc5fcd3bd"),
				Name = @"ScheduledStopMode",
				ReferenceSchemaUId = new Guid("5335288b-38c7-456e-902b-e5768c03b448"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("1f9bb71a-eb9c-4220-a40e-9b623eacfec8"),
				ModifiedInSchemaUId = new Guid("1f9bb71a-eb9c-4220-a40e-9b623eacfec8"),
				CreatedInPackageId = new Guid("6c038aa0-46cd-4697-bc93-5c682e364aef"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"229d71cf-80c8-4158-ae9d-b0da644ed6a8"
				}
			};
		}

		protected virtual EntitySchemaColumn CreateScheduledStartDateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("DateTime")) {
				UId = new Guid("5b85977f-dfdb-4d0b-b273-b36934d188e0"),
				Name = @"ScheduledStartDate",
				CreatedInSchemaUId = new Guid("1f9bb71a-eb9c-4220-a40e-9b623eacfec8"),
				ModifiedInSchemaUId = new Guid("1f9bb71a-eb9c-4220-a40e-9b623eacfec8"),
				CreatedInPackageId = new Guid("6c038aa0-46cd-4697-bc93-5c682e364aef")
			};
		}

		protected virtual EntitySchemaColumn CreateScheduledStopDateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("DateTime")) {
				UId = new Guid("aa365456-c611-43df-9d05-12b828091983"),
				Name = @"ScheduledStopDate",
				CreatedInSchemaUId = new Guid("1f9bb71a-eb9c-4220-a40e-9b623eacfec8"),
				ModifiedInSchemaUId = new Guid("1f9bb71a-eb9c-4220-a40e-9b623eacfec8"),
				CreatedInPackageId = new Guid("6c038aa0-46cd-4697-bc93-5c682e364aef")
			};
		}

		protected virtual EntitySchemaColumn CreatePrevExecutedOnColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("DateTime")) {
				UId = new Guid("80b80b2f-8cae-4b3b-b449-a647a503f3a6"),
				Name = @"PrevExecutedOn",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("1f9bb71a-eb9c-4220-a40e-9b623eacfec8"),
				ModifiedInSchemaUId = new Guid("1f9bb71a-eb9c-4220-a40e-9b623eacfec8"),
				CreatedInPackageId = new Guid("6c038aa0-46cd-4697-bc93-5c682e364aef")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateCampaignEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateCampaignEventsProcessSchema() {
			var schema = new CampaignEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new Campaign(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new Campaign_CampaignsEventsProcess(userConnection);
		}

		public override object Clone() {
			return new CampaignSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new CampaignSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("1f9bb71a-eb9c-4220-a40e-9b623eacfec8"));
		}

		#endregion

	}

	#endregion

	#region Class: Campaign

	/// <summary>
	/// Campaign.
	/// </summary>
	public class Campaign : Terrasoft.Configuration.Diagram
	{

		#region Constructors: Public

		public Campaign(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "Campaign";
		}

		public Campaign(Campaign source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Name.
		/// </summary>
		public string Name {
			get {
				return GetTypedColumnValue<string>("Name");
			}
			set {
				SetColumnValue("Name", value);
			}
		}

		/// <exclude/>
		public Guid CampaignStatusId {
			get {
				return GetTypedColumnValue<Guid>("CampaignStatusId");
			}
			set {
				SetColumnValue("CampaignStatusId", value);
				_campaignStatus = null;
			}
		}

		/// <exclude/>
		public string CampaignStatusName {
			get {
				return GetTypedColumnValue<string>("CampaignStatusName");
			}
			set {
				SetColumnValue("CampaignStatusName", value);
				if (_campaignStatus != null) {
					_campaignStatus.Name = value;
				}
			}
		}

		private CampaignStatus _campaignStatus;
		/// <summary>
		/// Status.
		/// </summary>
		public CampaignStatus CampaignStatus {
			get {
				return _campaignStatus ??
					(_campaignStatus = LookupColumnEntities.GetEntity("CampaignStatus") as CampaignStatus);
			}
		}

		/// <exclude/>
		public Guid SegmentsStatusId {
			get {
				return GetTypedColumnValue<Guid>("SegmentsStatusId");
			}
			set {
				SetColumnValue("SegmentsStatusId", value);
				_segmentsStatus = null;
			}
		}

		/// <exclude/>
		public string SegmentsStatusName {
			get {
				return GetTypedColumnValue<string>("SegmentsStatusName");
			}
			set {
				SetColumnValue("SegmentsStatusName", value);
				if (_segmentsStatus != null) {
					_segmentsStatus.Name = value;
				}
			}
		}

		private SegmentStatus _segmentsStatus;
		/// <summary>
		/// List of contacts.
		/// </summary>
		public SegmentStatus SegmentsStatus {
			get {
				return _segmentsStatus ??
					(_segmentsStatus = LookupColumnEntities.GetEntity("SegmentsStatus") as SegmentStatus);
			}
		}

		/// <summary>
		/// Campaign workflow.
		/// </summary>
		public string SchemaData {
			get {
				return GetTypedColumnValue<string>("SchemaData");
			}
			set {
				SetColumnValue("SchemaData", value);
			}
		}

		/// <summary>
		/// Notes.
		/// </summary>
		public string Notes {
			get {
				return GetTypedColumnValue<string>("Notes");
			}
			set {
				SetColumnValue("Notes", value);
			}
		}

		/// <summary>
		/// Goal description.
		/// </summary>
		public string TargetDescription {
			get {
				return GetTypedColumnValue<string>("TargetDescription");
			}
			set {
				SetColumnValue("TargetDescription", value);
			}
		}

		/// <summary>
		/// Goal.
		/// </summary>
		public Decimal TargetPercent {
			get {
				return GetTypedColumnValue<Decimal>("TargetPercent");
			}
			set {
				SetColumnValue("TargetPercent", value);
			}
		}

		/// <summary>
		/// Participants.
		/// </summary>
		public int TargetTotal {
			get {
				return GetTypedColumnValue<int>("TargetTotal");
			}
			set {
				SetColumnValue("TargetTotal", value);
			}
		}

		/// <summary>
		/// Reached the goal.
		/// </summary>
		public int TargetAchieve {
			get {
				return GetTypedColumnValue<int>("TargetAchieve");
			}
			set {
				SetColumnValue("TargetAchieve", value);
			}
		}

		/// <summary>
		/// Start date.
		/// </summary>
		public DateTime StartDate {
			get {
				return GetTypedColumnValue<DateTime>("StartDate");
			}
			set {
				SetColumnValue("StartDate", value);
			}
		}

		/// <summary>
		/// End date.
		/// </summary>
		public DateTime EndDate {
			get {
				return GetTypedColumnValue<DateTime>("EndDate");
			}
			set {
				SetColumnValue("EndDate", value);
			}
		}

		/// <exclude/>
		public Guid OwnerId {
			get {
				return GetTypedColumnValue<Guid>("OwnerId");
			}
			set {
				SetColumnValue("OwnerId", value);
				_owner = null;
			}
		}

		/// <exclude/>
		public string OwnerName {
			get {
				return GetTypedColumnValue<string>("OwnerName");
			}
			set {
				SetColumnValue("OwnerName", value);
				if (_owner != null) {
					_owner.Name = value;
				}
			}
		}

		private Contact _owner;
		/// <summary>
		/// Owner.
		/// </summary>
		public Contact Owner {
			get {
				return _owner ??
					(_owner = LookupColumnEntities.GetEntity("Owner") as Contact);
			}
		}

		/// <summary>
		/// utm_campaign.
		/// </summary>
		public string UtmCampaign {
			get {
				return GetTypedColumnValue<string>("UtmCampaign");
			}
			set {
				SetColumnValue("UtmCampaign", value);
			}
		}

		/// <summary>
		/// Next run.
		/// </summary>
		public DateTime NextFireTime {
			get {
				return GetTypedColumnValue<DateTime>("NextFireTime");
			}
			set {
				SetColumnValue("NextFireTime", value);
			}
		}

		/// <summary>
		/// Fire Period (min).
		/// </summary>
		public int FirePeriod {
			get {
				return GetTypedColumnValue<int>("FirePeriod");
			}
			set {
				SetColumnValue("FirePeriod", value);
			}
		}

		/// <summary>
		/// CampaignSchemaUId.
		/// </summary>
		public Guid CampaignSchemaUId {
			get {
				return GetTypedColumnValue<Guid>("CampaignSchemaUId");
			}
			set {
				SetColumnValue("CampaignSchemaUId", value);
			}
		}

		/// <exclude/>
		public Guid TypeId {
			get {
				return GetTypedColumnValue<Guid>("TypeId");
			}
			set {
				SetColumnValue("TypeId", value);
				_type = null;
			}
		}

		/// <exclude/>
		public string TypeName {
			get {
				return GetTypedColumnValue<string>("TypeName");
			}
			set {
				SetColumnValue("TypeName", value);
				if (_type != null) {
					_type.Name = value;
				}
			}
		}

		private CampaignType _type;
		/// <summary>
		/// Type.
		/// </summary>
		public CampaignType Type {
			get {
				return _type ??
					(_type = LookupColumnEntities.GetEntity("Type") as CampaignType);
			}
		}

		/// <summary>
		/// In progress.
		/// </summary>
		public bool InProgress {
			get {
				return GetTypedColumnValue<bool>("InProgress");
			}
			set {
				SetColumnValue("InProgress", value);
			}
		}

		/// <exclude/>
		public Guid ScheduledStartModeId {
			get {
				return GetTypedColumnValue<Guid>("ScheduledStartModeId");
			}
			set {
				SetColumnValue("ScheduledStartModeId", value);
				_scheduledStartMode = null;
			}
		}

		/// <exclude/>
		public string ScheduledStartModeName {
			get {
				return GetTypedColumnValue<string>("ScheduledStartModeName");
			}
			set {
				SetColumnValue("ScheduledStartModeName", value);
				if (_scheduledStartMode != null) {
					_scheduledStartMode.Name = value;
				}
			}
		}

		private CampaignScheduledMode _scheduledStartMode;
		/// <summary>
		/// Start mode.
		/// </summary>
		public CampaignScheduledMode ScheduledStartMode {
			get {
				return _scheduledStartMode ??
					(_scheduledStartMode = LookupColumnEntities.GetEntity("ScheduledStartMode") as CampaignScheduledMode);
			}
		}

		/// <exclude/>
		public Guid ScheduledStopModeId {
			get {
				return GetTypedColumnValue<Guid>("ScheduledStopModeId");
			}
			set {
				SetColumnValue("ScheduledStopModeId", value);
				_scheduledStopMode = null;
			}
		}

		/// <exclude/>
		public string ScheduledStopModeName {
			get {
				return GetTypedColumnValue<string>("ScheduledStopModeName");
			}
			set {
				SetColumnValue("ScheduledStopModeName", value);
				if (_scheduledStopMode != null) {
					_scheduledStopMode.Name = value;
				}
			}
		}

		private CampaignScheduledMode _scheduledStopMode;
		/// <summary>
		/// End mode.
		/// </summary>
		public CampaignScheduledMode ScheduledStopMode {
			get {
				return _scheduledStopMode ??
					(_scheduledStopMode = LookupColumnEntities.GetEntity("ScheduledStopMode") as CampaignScheduledMode);
			}
		}

		/// <summary>
		/// Scheduled start date.
		/// </summary>
		public DateTime ScheduledStartDate {
			get {
				return GetTypedColumnValue<DateTime>("ScheduledStartDate");
			}
			set {
				SetColumnValue("ScheduledStartDate", value);
			}
		}

		/// <summary>
		/// Scheduled end date.
		/// </summary>
		public DateTime ScheduledStopDate {
			get {
				return GetTypedColumnValue<DateTime>("ScheduledStopDate");
			}
			set {
				SetColumnValue("ScheduledStopDate", value);
			}
		}

		/// <summary>
		/// Last run.
		/// </summary>
		public DateTime PrevExecutedOn {
			get {
				return GetTypedColumnValue<DateTime>("PrevExecutedOn");
			}
			set {
				SetColumnValue("PrevExecutedOn", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new Campaign_CampaignsEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("CampaignDeleted", e);
			Deleting += (s, e) => ThrowEvent("CampaignDeleting", e);
			Inserted += (s, e) => ThrowEvent("CampaignInserted", e);
			Inserting += (s, e) => ThrowEvent("CampaignInserting", e);
			Saving += (s, e) => ThrowEvent("CampaignSaving", e);
			Validating += (s, e) => ThrowEvent("CampaignValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new Campaign(this);
		}

		#endregion

	}

	#endregion

	#region Class: Campaign_CampaignsEventsProcess

	/// <exclude/>
	public class Campaign_CampaignsEventsProcess<TEntity> : Terrasoft.Configuration.Diagram_ProcessLibraryEventsProcess<TEntity> where TEntity : Campaign
	{

		public Campaign_CampaignsEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "Campaign_CampaignsEventsProcess";
			SchemaUId = new Guid("1f9bb71a-eb9c-4220-a40e-9b623eacfec8");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			_nodesSchemaName = () => {{ return "CampaignStep"; }};
			_connectorsSchemaName = () => {{ return "CampaignStepRoute"; }};
			_diagramStorageColumnName = () => {{ return "SchemaData"; }};
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("1f9bb71a-eb9c-4220-a40e-9b623eacfec8");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		private Func<string> _nodesSchemaName;
		public override string NodesSchemaName {
			get {
				return (_nodesSchemaName ?? (_nodesSchemaName = () => null)).Invoke();
			}
			set {
				_nodesSchemaName = () => { return value; };
			}
		}

		private Func<string> _connectorsSchemaName;
		public override string ConnectorsSchemaName {
			get {
				return (_connectorsSchemaName ?? (_connectorsSchemaName = () => null)).Invoke();
			}
			set {
				_connectorsSchemaName = () => { return value; };
			}
		}

		private Func<string> _diagramStorageColumnName;
		public override string DiagramStorageColumnName {
			get {
				return (_diagramStorageColumnName ?? (_diagramStorageColumnName = () => null)).Invoke();
			}
			set {
				_diagramStorageColumnName = () => { return value; };
			}
		}

		public virtual Object ChangedValues {
			get;
			set;
		}

		private ProcessFlowElement _beforeAddSubProcess;
		public ProcessFlowElement BeforeAddSubProcess {
			get {
				return _beforeAddSubProcess ?? (_beforeAddSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "BeforeAddSubProcess",
					SchemaElementUId = new Guid("1839d90c-fdf8-4763-a021-de4d40d3443f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _addCampaignMessage;
		public ProcessFlowElement AddCampaignMessage {
			get {
				return _addCampaignMessage ?? (_addCampaignMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "AddCampaignMessage",
					SchemaElementUId = new Guid("71fbf84f-7523-4d12-ae3c-a8fb62712df9"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _insertingTask;
		public ProcessScriptTask InsertingTask {
			get {
				return _insertingTask ?? (_insertingTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "InsertingTask",
					SchemaElementUId = new Guid("b534212c-fe1b-4502-80d4-821437900ab6"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = InsertingTaskExecute,
				});
			}
		}

		private ProcessFlowElement _afterDeletedCampaignSubProcess;
		public ProcessFlowElement AfterDeletedCampaignSubProcess {
			get {
				return _afterDeletedCampaignSubProcess ?? (_afterDeletedCampaignSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "AfterDeletedCampaignSubProcess",
					SchemaElementUId = new Guid("c9bea1c7-ebb4-41f4-bc87-8b54f7bbbcb9"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _deletedMessage;
		public ProcessFlowElement DeletedMessage {
			get {
				return _deletedMessage ?? (_deletedMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "DeletedMessage",
					SchemaElementUId = new Guid("80ae56f4-8c9e-45a4-98fe-2ad251accaa0"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _deletedScriptTask;
		public ProcessScriptTask DeletedScriptTask {
			get {
				return _deletedScriptTask ?? (_deletedScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "DeletedScriptTask",
					SchemaElementUId = new Guid("16c11682-2a43-4c2c-8efe-1d80cd2f6041"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = DeletedScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _beforeDeletedCampaignSubProcess;
		public ProcessFlowElement BeforeDeletedCampaignSubProcess {
			get {
				return _beforeDeletedCampaignSubProcess ?? (_beforeDeletedCampaignSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "BeforeDeletedCampaignSubProcess",
					SchemaElementUId = new Guid("f1cf7144-651d-4eb5-9cb3-f77d6686006d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _deletingScriptTask;
		public ProcessScriptTask DeletingScriptTask {
			get {
				return _deletingScriptTask ?? (_deletingScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "DeletingScriptTask",
					SchemaElementUId = new Guid("4f5a130b-6f93-43d7-b853-7a02a4a6f754"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = DeletingScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _deletingMessage;
		public ProcessFlowElement DeletingMessage {
			get {
				return _deletingMessage ?? (_deletingMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "DeletingMessage",
					SchemaElementUId = new Guid("9c973651-bfaf-413a-b592-0d055892aec5"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _afterAddSubProcess;
		public ProcessFlowElement AfterAddSubProcess {
			get {
				return _afterAddSubProcess ?? (_afterAddSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "AfterAddSubProcess",
					SchemaElementUId = new Guid("8a8d2cc0-9cfe-40ea-b3b6-ad5881a724dc"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _insertedCampaignMessage;
		public ProcessFlowElement InsertedCampaignMessage {
			get {
				return _insertedCampaignMessage ?? (_insertedCampaignMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "InsertedCampaignMessage",
					SchemaElementUId = new Guid("95a614a2-3afd-4db2-b114-a2257ce2cf93"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _insertedTask;
		public ProcessScriptTask InsertedTask {
			get {
				return _insertedTask ?? (_insertedTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "InsertedTask",
					SchemaElementUId = new Guid("4ccc1b15-e1d5-4695-ad32-cb850c503495"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = InsertedTaskExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[BeforeAddSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { BeforeAddSubProcess };
			FlowElements[AddCampaignMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { AddCampaignMessage };
			FlowElements[InsertingTask.SchemaElementUId] = new Collection<ProcessFlowElement> { InsertingTask };
			FlowElements[AfterDeletedCampaignSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { AfterDeletedCampaignSubProcess };
			FlowElements[DeletedMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { DeletedMessage };
			FlowElements[DeletedScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { DeletedScriptTask };
			FlowElements[BeforeDeletedCampaignSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { BeforeDeletedCampaignSubProcess };
			FlowElements[DeletingScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { DeletingScriptTask };
			FlowElements[DeletingMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { DeletingMessage };
			FlowElements[AfterAddSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { AfterAddSubProcess };
			FlowElements[InsertedCampaignMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { InsertedCampaignMessage };
			FlowElements[InsertedTask.SchemaElementUId] = new Collection<ProcessFlowElement> { InsertedTask };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "BeforeAddSubProcess":
						break;
					case "AddCampaignMessage":
						e.Context.QueueTasks.Enqueue("InsertingTask");
						break;
					case "InsertingTask":
						break;
					case "AfterDeletedCampaignSubProcess":
						break;
					case "DeletedMessage":
						e.Context.QueueTasks.Enqueue("DeletedScriptTask");
						break;
					case "DeletedScriptTask":
						break;
					case "BeforeDeletedCampaignSubProcess":
						break;
					case "DeletingScriptTask":
						break;
					case "DeletingMessage":
						e.Context.QueueTasks.Enqueue("DeletingScriptTask");
						break;
					case "AfterAddSubProcess":
						break;
					case "InsertedCampaignMessage":
						e.Context.QueueTasks.Enqueue("InsertedTask");
						break;
					case "InsertedTask":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("AddCampaignMessage");
			ActivatedEventElements.Add("DeletedMessage");
			ActivatedEventElements.Add("DeletingMessage");
			ActivatedEventElements.Add("InsertedCampaignMessage");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "BeforeAddSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "AddCampaignMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "AddCampaignMessage";
					result = AddCampaignMessage.Execute(context);
					break;
				case "InsertingTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "InsertingTask";
					result = InsertingTask.Execute(context, InsertingTaskExecute);
					break;
				case "AfterDeletedCampaignSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "DeletedMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "DeletedMessage";
					result = DeletedMessage.Execute(context);
					break;
				case "DeletedScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "DeletedScriptTask";
					result = DeletedScriptTask.Execute(context, DeletedScriptTaskExecute);
					break;
				case "BeforeDeletedCampaignSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "DeletingScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "DeletingScriptTask";
					result = DeletingScriptTask.Execute(context, DeletingScriptTaskExecute);
					break;
				case "DeletingMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "DeletingMessage";
					result = DeletingMessage.Execute(context);
					break;
				case "AfterAddSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "InsertedCampaignMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "InsertedCampaignMessage";
					result = InsertedCampaignMessage.Execute(context);
					break;
				case "InsertedTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "InsertedTask";
					result = InsertedTask.Execute(context, InsertedTaskExecute);
					break;
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

		protected override void ApplyPropertiesDataValues(DataReader reader) {
			base.ApplyPropertiesDataValues(reader);
			switch (reader.CurrentName) {
				case "ChangedValues":
					ChangedValues = reader.GetSerializableObjectValue();
				break;
			}
		}

		#endregion

		#region Methods: Public

		public virtual bool InsertingTaskExecute(ProcessExecutingContext context) {
			OnCampaignInserting();
			return true;
		}

		public virtual bool DeletedScriptTaskExecute(ProcessExecutingContext context) {
			DeleteCampaignSchema();
			return true;
		}

		public virtual bool DeletingScriptTaskExecute(ProcessExecutingContext context) {
			UnlinkCampaignSchemaElements();
			return true;
		}

		public virtual bool InsertedTaskExecute(ProcessExecutingContext context) {
			OnCampaignInserted();
			return true;
		}

		public override bool DiagramSavedMethod(ProcessExecutingContext  context) {
			if (GetCampaignType() == CampaignConsts.OldCampaignTypeId) {
				return base.DiagramSavedMethod(context);
			}
			return true;
		}

		public override void SaveDiagram() {
			if (!Entity.Schema.Columns.Any(column => column.Name == DiagramStorageColumnName)) {
				return;
			}
			string json = Entity.GetTypedColumnValue<string>(DiagramStorageColumnName);
			Guid recordId = Entity.PrimaryColumnValue;
			JObject diagram = JObject.Parse(json);
			JToken nodes = diagram["nodes"];
			JToken connectors = diagram["connectors"];
			var map = new DiagramElementMap(string.Empty, new DiagramElementMapPointer[] {});
			string leadStepType = CampaignConsts.CreateLeadCampaignStepTypeId.ToString();
			string emailStepType = CampaignConsts.BulkEmailCampaignStepTypeId.ToString();
			Dictionary<string, Guid> recordsToCheck = new Dictionary<string, Guid>();
			foreach (JToken connector in connectors) {
				string sourceNodeName = map.GetJTokenValueByPath(connector, "sourceNode");
				JToken sourceNode = FindItemByProperty(nodes, "name", sourceNodeName, map);
				if (sourceNode == null) {
					continue;
				}
				string sourceNodeType = map.GetJTokenValueByPath(sourceNode, "stepType");
				if (sourceNodeType == leadStepType) {
					continue;
				}
				JToken targetNode = FindTargetNode(nodes, connectors, connector);
				if (targetNode == null) {
					continue;
				}
				string targetNodeType = map.GetJTokenValueByPath(targetNode, "stepType");
				if (targetNodeType == emailStepType) {
					string targetNodeRecord = map.GetJTokenValueByPath(targetNode, "addInfo.RecordId");
					Guid targetNodeRecordId = Guid.Empty;
					Guid.TryParse(targetNodeRecord, out targetNodeRecordId);
					if (!targetNodeRecordId.IsEmpty()) {
						string connectorName = map.GetJTokenValueByPath(connector, "name");
						recordsToCheck[connectorName] = targetNodeRecordId;
						string launchOption = map.GetJTokenValueByPath(connector, "addInfo.LaunchOptionRadio");
						string startDate = map.GetJTokenValueByPath(connector, "addInfo.StartDate");
						UpdateBulkEmail(targetNodeRecordId, launchOption, startDate);
					}
				}
			}
			//check recordsToCheck.Vaues
			/*List<string> checkedConnectors = GetCheckedConnectors(recordsToCheck);
			foreach (JToken connector in connectors) {
				//reset all unchecked connectors to -1
				string connectorName = map.GetJTokenValueByPath(connector, "name");
				if (!checkedConnectors.Contains(connectorName)) {
					map.SetJObjectValueByPath(connector, "addInfo.DayTransitionCount", -1);
				}
			}*/
			SaveNodes(recordId, nodes);
			SaveConnectors(recordId, connectors);
		}

		public override void SaveNodes(Guid parentId, JToken nodes) {
			DiagramElementMap nodesMap = GetNodesMap();
			List<Guid> records = SaveItems(parentId, nodes, nodesMap);
			UpdateReferences("Event", parentId, records);
			UpdateReferences("BulkEmail", parentId, records);
			if (records.Count > 0) {
				new Delete(UserConnection)
					.From(nodesMap.SchemaName)
					.Where("Id").Not().In(Column.Parameters(records))
					.And(nodesMap.ReferenceColumnValueName + "Id").IsEqual(Column.Parameter(parentId))
					.Execute();
			} else {
				new Delete(UserConnection)
					.From(nodesMap.SchemaName)
					.Where(nodesMap.ReferenceColumnValueName + "Id").IsEqual(Column.Parameter(parentId))
					.Execute();
			}
		}

		public override DiagramElementMap GetConnectorsMap() {
			return new DiagramElementMap(ConnectorsSchemaName, new DiagramElementMapPointer[] {
				new DiagramElementMapPointer("labels..text", "Title", typeof(String)),
				new DiagramElementMapPointer("sourceNode", "SourceStepId", typeof(Guid)),
				new DiagramElementMapPointer("targetNode", "TargetStepId", typeof(Guid))
			});
		}

		public override DiagramElementMap GetNodesMap() {
			return new DiagramElementMap(NodesSchemaName, new DiagramElementMapPointer[] {
				new DiagramElementMapPointer("labels..text", "Title", typeof(String)),
				new DiagramElementMapPointer("stepType", "TypeId", typeof(Guid)),
				new DiagramElementMapPointer("addInfo.RecordId", "RecordId", typeof(Guid))
			}, "Campaign");
		}

		public override bool DiagramLoadedMethod(ProcessExecutingContext  context) {
			if (GetCampaignType() == CampaignConsts.OldCampaignTypeId) {
				return base.DiagramLoadedMethod(context);
			}
			return true;
		}

		public virtual JToken FindTargetNode(JToken nodes, JToken connectors, JToken connector) {
			if (connector == null) {
				return null;
			}
			var map = new DiagramElementMap(string.Empty, new DiagramElementMapPointer[] {});
			string targetNodeName = map.GetJTokenValueByPath(connector, "targetNode");
			JToken targetNode = FindItemByProperty(nodes, "name", targetNodeName, map);
			if (targetNode == null) {
				return null;
			}
			string targetNodeType = map.GetJTokenValueByPath(targetNode, "stepType");
			if (targetNodeType == CampaignConsts.CreateLeadCampaignStepTypeId.ToString()) {
				JToken nextConnector = FindItemByProperty(connectors, "sourceNode", targetNodeName, map);
				return FindTargetNode(nodes, connectors, nextConnector);
			}
			return targetNode;
		}

		public virtual JToken FindItemByProperty(JToken items, string propertyName, string propertyValue, DiagramElementMap map) {
			foreach (JToken item in items) {
				string itemValue = map.GetJTokenValueByPath(item, propertyName);
				if (itemValue == propertyValue) {
					return item;
				}
			}
			return null;
		}

		public virtual List<string> GetCheckedConnectors(Dictionary<string, Guid> connectorsToCheck) {
			List<string> result = new List<string>();
			if (connectorsToCheck.Count() == 0) {
				return result;
			}
			var checkSelect = new Select(UserConnection)
				.Column("Id")
				.From("BulkEmail")
				.Where("Id").In(Column.Parameters(connectorsToCheck.Values))
				.And("CategoryId").IsEqual(Column.Const(MarketingConsts.TriggeredEmailBulkEmailCategoryId))
				.And("LaunchOptionId").IsEqual(Column.Const(MarketingConsts.TriggerEmailScheduledLaunchOptionId)) as Select;
			using (var dbExecutor = UserConnection.EnsureDBConnection()) {
				using (var reader = checkSelect.ExecuteReader(dbExecutor)) {
					while (reader.Read()) {
						Guid recordId = UserConnection.DBTypeConverter.DBValueToGuid(reader[0]);
						result.AddRange(
							connectorsToCheck.Where(item => item.Value == recordId).Select(item => item.Key)
						);
					}
				}
			}
			return result;
		}

		public virtual void UpdateBulkEmail(Guid bulkEmailId, string launchOption, string startDate) {
			var bulkEmailSchema = UserConnection.EntitySchemaManager.GetInstanceByName("BulkEmail");
			var bulkEmailEntity = bulkEmailSchema.CreateEntity(UserConnection);
			if (bulkEmailEntity.FetchFromDB(bulkEmailId)) {
				Guid bulkEmailCategoryId = bulkEmailEntity.GetTypedColumnValue<Guid>("CategoryId");
				if (bulkEmailCategoryId != MailingConsts.TriggeredEmailBulkEmailCategoryId) {
					return;
				}
				Guid statusId = bulkEmailEntity.GetTypedColumnValue<Guid>("StatusId");
				if (statusId != MailingConsts.BulkEmailStatusPlannedId && statusId != MailingConsts.BulkEmailStatusStartPlanedId) {
					return;
				}
				Guid launchOptionId = Guid.Empty;
				if (Guid.TryParse(launchOption, out launchOptionId)) {
					bulkEmailEntity.SetColumnValue("LaunchOptionId", launchOptionId);
				}
				DateTimeOffset dateTimeOffset;
				if (DateTimeOffset.TryParse(startDate, null as IFormatProvider, DateTimeStyles.AdjustToUniversal,
						out dateTimeOffset)) {
					DateTime dateTimeUtc = DateTime.SpecifyKind(dateTimeOffset.DateTime, DateTimeKind.Utc);
					bulkEmailEntity.SetColumnValue("StartDate", dateTimeUtc);
				}
				bulkEmailEntity.Save();
			}
		}

		public virtual void UpdateReferences(string schemaNames, Guid campaignId, List<Guid> records) {
			var innerSelect = new Select(UserConnection)
				.Column("RecordId")
				.From("CampaignStep")
				.Where("CampaignId").IsEqual(Column.Const(campaignId))
				.And("RecordId").Not().IsNull() as Select;
			if (records.Any()) {
				innerSelect.And("Id").Not().In(Column.Parameters(records));
			}
			new Update(UserConnection, schemaNames)
				.Set("CampaignId", Column.Const(null))
				.Where("CampaignId").IsEqual(Column.Const(campaignId))
				.And("Id").In(
					innerSelect
				).Execute();
		}

		public virtual void OnCampaignInserting() {
			var campaignSchemaUId = GetCampaignSchemaUId();
			if (campaignSchemaUId == Guid.Empty) {
				Entity.SetColumnValue("CampaignSchemaUId", null);
			}
		}

		public virtual bool IsColumnValueChanged(string columnName) {
			return Entity.GetIsColumnValueLoaded(columnName) && 
				Entity.GetChangedColumnValues().Any(_ => _.Name == columnName);
		}

		public virtual Guid GetCampaignSchemaUId() {
			Guid campaignSchemaUId = Guid.Empty;
			if (Entity.GetIsColumnValueLoaded("CampaignSchemaUId")) {
				campaignSchemaUId = Entity.GetTypedColumnValue<Guid>("CampaignSchemaUId");
			}
			return campaignSchemaUId;
		}

		public virtual Guid GetCampaignType() {
			Guid typeId = Guid.Empty;
			if (Entity.Schema.Columns.Any(_ => _.Name == "Type") && Entity.GetIsColumnValueLoaded("TypeId")) {
				typeId = Entity.GetTypedColumnValue<Guid>("TypeId");
			}
			return typeId;
		}

		public virtual void DeleteCampaignSchema() {
			Guid campaignSchemaUId = GetCampaignSchemaUId();
			if (campaignSchemaUId.IsEmpty()) {
				return;
			}
			var campaignSchemaManager = (CampaignSchemaManager)UserConnection.GetSchemaManager("CampaignSchemaManager");
			var item = campaignSchemaManager.FindItemByUId(campaignSchemaUId);
			if (item == null) {
				return;
			}
			campaignSchemaManager.RemoveItemByUId(campaignSchemaUId, UserConnection);
		}

		public virtual void UnlinkCampaignSchemaElements() {
			Guid campaignSchemaUId = GetCampaignSchemaUId();
			if (campaignSchemaUId.IsEmpty()) {
				return;
			}
			var campaignSchemaManager = (CampaignSchemaManager)UserConnection.GetSchemaManager("CampaignSchemaManager");
			try {
				Terrasoft.Core.Campaign.CampaignSchema schema = campaignSchemaManager.GetSchemaInstance(campaignSchemaUId);
				if (schema == null) {
					return;
				}
				CampaignEventFacade.Delete(UserConnection, schema);
			} catch (Exception e) {
				return;
			}
		}

		public virtual void OnCampaignInserted() {
			var campaignSchemaUId = GetCampaignSchemaUId();
			if (campaignSchemaUId == Guid.Empty) {
				Entity.SetColumnValue("CampaignSchemaUId", null);
				return;
			}
			try {
				CampaignEventFacade.Copy(UserConnection, Entity.Id, campaignSchemaUId);
			} catch (Exception e) {
				RemoveCampaignFromDb(Entity.Id);
				throw;
			}
		}

		public virtual void RemoveCampaignFromDb(Guid entityId) {
			new Delete(UserConnection)
				.From("Campaign")
				.Where("Id").IsEqual(Column.Parameter(entityId))
				.Execute();
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "CampaignInserting":
							if (ActivatedEventElements.Contains("AddCampaignMessage")) {
							context.QueueTasks.Enqueue("AddCampaignMessage");
						}
						break;
					case "CampaignDeleted":
							if (ActivatedEventElements.Contains("DeletedMessage")) {
							context.QueueTasks.Enqueue("DeletedMessage");
						}
						break;
					case "CampaignDeleting":
							if (ActivatedEventElements.Contains("DeletingMessage")) {
							context.QueueTasks.Enqueue("DeletingMessage");
						}
						break;
					case "CampaignInserted":
							if (ActivatedEventElements.Contains("InsertedCampaignMessage")) {
							context.QueueTasks.Enqueue("InsertedCampaignMessage");
						}
						break;
			}
			base.ThrowEvent(context, message);
			ProcessQueue(context);
		}

		public override void WritePropertiesData(DataWriter writer, bool writeFlowElements = true) {
			base.WritePropertiesData(writer, writeFlowElements);
			if (ChangedValues != null) {
				if (ChangedValues.GetType().IsSerializable ||
					ChangedValues.GetType().GetInterface("ISerializable") != null) {
					writer.WriteSerializableObjectValue("ChangedValues", ChangedValues, null);
				}
			}
		}

		public override object CloneShallow() {
			return base.CloneShallow();
		}

		#endregion

	}

	#endregion

	#region Class: Campaign_CampaignsEventsProcess

	/// <exclude/>
	public class Campaign_CampaignsEventsProcess : Campaign_CampaignsEventsProcess<Campaign>
	{

		public Campaign_CampaignsEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: CampaignEventsProcessSchema

	/// <exclude/>
	public class CampaignEventsProcessSchema : Terrasoft.Configuration.DiagramEventsProcessSchema
	{

		#region Constructors: Public

		public CampaignEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public CampaignEventsProcessSchema(CampaignEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "Campaign_CampaignsEventsProcess";
			UId = new Guid("8875bc04-b5ec-4ef7-93bc-d81b1f792b05");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("a1507d4b-5505-46d1-8d0c-efecff370732");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
		}

		protected override ProcessSchemaParameter CreateNodesSchemaNameParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("9e2e99a4-eca6-41a5-b676-3b61a8c5b4db"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("a1507d4b-5505-46d1-8d0c-efecff370732"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("a1507d4b-5505-46d1-8d0c-efecff370732"),
				Name = @"NodesSchemaName",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("8875bc04-b5ec-4ef7-93bc-d81b1f792b05"),
				},
			};
		}

		protected override ProcessSchemaParameter CreateConnectorsSchemaNameParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("40295c4e-ccf7-4222-8f02-4606971c67e0"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("a1507d4b-5505-46d1-8d0c-efecff370732"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("a1507d4b-5505-46d1-8d0c-efecff370732"),
				Name = @"ConnectorsSchemaName",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("8875bc04-b5ec-4ef7-93bc-d81b1f792b05"),
				},
			};
		}

		protected override ProcessSchemaParameter CreateDiagramStorageColumnNameParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("947ff92c-6073-41a6-8a90-184df5ba0a8b"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("a1507d4b-5505-46d1-8d0c-efecff370732"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("a1507d4b-5505-46d1-8d0c-efecff370732"),
				Name = @"DiagramStorageColumnName",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("MaxSizeText"),
				SourceValue = new ProcessSchemaParameterValue() {
					Source = ProcessSchemaParameterValueSource.Script,
					MetaPath = null,
					ModifiedInSchemaUId = new Guid("8875bc04-b5ec-4ef7-93bc-d81b1f792b05"),
				},
			};
		}

		protected virtual ProcessSchemaParameter CreateChangedValuesParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("2b66f150-82fa-407c-bbd1-817807cd0045"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("8875bc04-b5ec-4ef7-93bc-d81b1f792b05"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("8875bc04-b5ec-4ef7-93bc-d81b1f792b05"),
				Name = @"ChangedValues",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Object"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateChangedValuesParameter());
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet1 = CreateLaneSet1LaneSet();
			LaneSets.Add(schemaLaneSet1);
			ProcessSchemaLane schemaLane1 = CreateLane1Lane();
			schemaLaneSet1.Lanes.Add(schemaLane1);
			ProcessSchemaEventSubProcess beforeaddsubprocess = CreateBeforeAddSubProcessEventSubProcess();
			FlowElements.Add(beforeaddsubprocess);
			ProcessSchemaEventSubProcess afterdeletedcampaignsubprocess = CreateAfterDeletedCampaignSubProcessEventSubProcess();
			FlowElements.Add(afterdeletedcampaignsubprocess);
			ProcessSchemaEventSubProcess beforedeletedcampaignsubprocess = CreateBeforeDeletedCampaignSubProcessEventSubProcess();
			FlowElements.Add(beforedeletedcampaignsubprocess);
			ProcessSchemaEventSubProcess afteraddsubprocess = CreateAfterAddSubProcessEventSubProcess();
			FlowElements.Add(afteraddsubprocess);
			ProcessSchemaStartMessageEvent addcampaignmessage = CreateAddCampaignMessageStartMessageEvent();
			beforeaddsubprocess.FlowElements.Add(addcampaignmessage);
			ProcessSchemaScriptTask insertingtask = CreateInsertingTaskScriptTask();
			beforeaddsubprocess.FlowElements.Add(insertingtask);
			ProcessSchemaStartMessageEvent deletedmessage = CreateDeletedMessageStartMessageEvent();
			afterdeletedcampaignsubprocess.FlowElements.Add(deletedmessage);
			ProcessSchemaScriptTask deletedscripttask = CreateDeletedScriptTaskScriptTask();
			afterdeletedcampaignsubprocess.FlowElements.Add(deletedscripttask);
			ProcessSchemaScriptTask deletingscripttask = CreateDeletingScriptTaskScriptTask();
			beforedeletedcampaignsubprocess.FlowElements.Add(deletingscripttask);
			ProcessSchemaStartMessageEvent deletingmessage = CreateDeletingMessageStartMessageEvent();
			beforedeletedcampaignsubprocess.FlowElements.Add(deletingmessage);
			ProcessSchemaStartMessageEvent insertedcampaignmessage = CreateInsertedCampaignMessageStartMessageEvent();
			afteraddsubprocess.FlowElements.Add(insertedcampaignmessage);
			ProcessSchemaScriptTask insertedtask = CreateInsertedTaskScriptTask();
			afteraddsubprocess.FlowElements.Add(insertedtask);
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
			FlowElements.Add(CreateSequenceFlow5SequenceFlow());
			FlowElements.Add(CreateSequenceFlow4SequenceFlow());
			FlowElements.Add(CreateSequenceFlow6_e391be5b7020421d888abc22a38da384SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3",
				UId = new Guid("6d2f0451-d11b-4e05-96d3-693a29dfa1fd"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("a1507d4b-5505-46d1-8d0c-efecff370732"),
				CreatedInPackageId = new Guid("0fa99f9a-3eca-422f-9a3c-3294c39b5190"),
				CreatedInSchemaUId = new Guid("8875bc04-b5ec-4ef7-93bc-d81b1f792b05"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("8875bc04-b5ec-4ef7-93bc-d81b1f792b05"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("71fbf84f-7523-4d12-ae3c-a8fb62712df9"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("b534212c-fe1b-4502-80d4-821437900ab6"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow5SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow5",
				UId = new Guid("ce945b55-9309-4e9c-b7e8-2cb2707dded0"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("a1507d4b-5505-46d1-8d0c-efecff370732"),
				CreatedInPackageId = new Guid("0fa99f9a-3eca-422f-9a3c-3294c39b5190"),
				CreatedInSchemaUId = new Guid("8875bc04-b5ec-4ef7-93bc-d81b1f792b05"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("8875bc04-b5ec-4ef7-93bc-d81b1f792b05"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("80ae56f4-8c9e-45a4-98fe-2ad251accaa0"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("16c11682-2a43-4c2c-8efe-1d80cd2f6041"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4",
				UId = new Guid("7a46320a-4bd3-4186-9e89-c9b148662b18"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("a1507d4b-5505-46d1-8d0c-efecff370732"),
				CreatedInPackageId = new Guid("bac310da-8f6a-4932-87be-74eb3d9d7067"),
				CreatedInSchemaUId = new Guid("8875bc04-b5ec-4ef7-93bc-d81b1f792b05"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("8875bc04-b5ec-4ef7-93bc-d81b1f792b05"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("9c973651-bfaf-413a-b592-0d055892aec5"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("4f5a130b-6f93-43d7-b853-7a02a4a6f754"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow6_e391be5b7020421d888abc22a38da384SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow6_e391be5b7020421d888abc22a38da384",
				UId = new Guid("e391be5b-7020-421d-888a-bc22a38da384"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("a1507d4b-5505-46d1-8d0c-efecff370732"),
				CreatedInPackageId = new Guid("6c038aa0-46cd-4697-bc93-5c682e364aef"),
				CreatedInSchemaUId = new Guid("8875bc04-b5ec-4ef7-93bc-d81b1f792b05"),
				CurveCenterPosition = new Point(0, 0),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("8875bc04-b5ec-4ef7-93bc-d81b1f792b05"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("95a614a2-3afd-4db2-b114-a2257ce2cf93"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("4ccc1b15-e1d5-4695-ad32-cb850c503495"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("2292801e-31ac-4f9d-8584-a89b17728200"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("a1507d4b-5505-46d1-8d0c-efecff370732"),
				CreatedInPackageId = new Guid("2eef8cec-00f6-49b9-a9a8-273926f614a8"),
				CreatedInSchemaUId = new Guid("8875bc04-b5ec-4ef7-93bc-d81b1f792b05"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("8875bc04-b5ec-4ef7-93bc-d81b1f792b05"),
				Name = @"LaneSet1",
				Position = new Point(0, 5),
				Size = new Size(0, 400),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("684c4d51-73ed-46a8-89ee-7e7e53ca5e96"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("2292801e-31ac-4f9d-8584-a89b17728200"),
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = new Guid("2eef8cec-00f6-49b9-a9a8-273926f614a8"),
				CreatedInSchemaUId = new Guid("8875bc04-b5ec-4ef7-93bc-d81b1f792b05"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("8875bc04-b5ec-4ef7-93bc-d81b1f792b05"),
				Name = @"Lane1",
				Position = new Point(0, 0),
				Size = new Size(700, 400),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaEventSubProcess CreateBeforeAddSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaBeforeAddSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("1839d90c-fdf8-4763-a021-de4d40d3443f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("684c4d51-73ed-46a8-89ee-7e7e53ca5e96"),
				CreatedInOwnerSchemaUId = new Guid("a1507d4b-5505-46d1-8d0c-efecff370732"),
				CreatedInPackageId = new Guid("0fa99f9a-3eca-422f-9a3c-3294c39b5190"),
				CreatedInSchemaUId = new Guid("8875bc04-b5ec-4ef7-93bc-d81b1f792b05"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("8875bc04-b5ec-4ef7-93bc-d81b1f792b05"),
				Name = @"BeforeAddSubProcess",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(20, 70),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(289, 130),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaBeforeAddSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateAddCampaignMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("71fbf84f-7523-4d12-ae3c-a8fb62712df9"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1839d90c-fdf8-4763-a021-de4d40d3443f"),
				CreatedInOwnerSchemaUId = new Guid("a1507d4b-5505-46d1-8d0c-efecff370732"),
				CreatedInPackageId = new Guid("0fa99f9a-3eca-422f-9a3c-3294c39b5190"),
				CreatedInSchemaUId = new Guid("8875bc04-b5ec-4ef7-93bc-d81b1f792b05"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"CampaignInserting",
				ModifiedInSchemaUId = new Guid("8875bc04-b5ec-4ef7-93bc-d81b1f792b05"),
				Name = @"AddCampaignMessage",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(40, 45),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateInsertingTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("b534212c-fe1b-4502-80d4-821437900ab6"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1839d90c-fdf8-4763-a021-de4d40d3443f"),
				CreatedInOwnerSchemaUId = new Guid("a1507d4b-5505-46d1-8d0c-efecff370732"),
				CreatedInPackageId = new Guid("0fa99f9a-3eca-422f-9a3c-3294c39b5190"),
				CreatedInSchemaUId = new Guid("8875bc04-b5ec-4ef7-93bc-d81b1f792b05"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("8875bc04-b5ec-4ef7-93bc-d81b1f792b05"),
				Name = @"InsertingTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(180, 31),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,243,207,115,78,204,45,72,204,76,207,243,204,43,78,45,42,201,204,75,215,208,180,230,42,74,45,41,45,202,83,40,41,42,77,181,6,0,25,74,97,27,35,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateAfterDeletedCampaignSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaAfterDeletedCampaignSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("c9bea1c7-ebb4-41f4-bc87-8b54f7bbbcb9"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("684c4d51-73ed-46a8-89ee-7e7e53ca5e96"),
				CreatedInOwnerSchemaUId = new Guid("a1507d4b-5505-46d1-8d0c-efecff370732"),
				CreatedInPackageId = new Guid("0fa99f9a-3eca-422f-9a3c-3294c39b5190"),
				CreatedInSchemaUId = new Guid("8875bc04-b5ec-4ef7-93bc-d81b1f792b05"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("8875bc04-b5ec-4ef7-93bc-d81b1f792b05"),
				Name = @"AfterDeletedCampaignSubProcess",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(400, 234),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(289, 126),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaAfterDeletedCampaignSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateDeletedMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("80ae56f4-8c9e-45a4-98fe-2ad251accaa0"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c9bea1c7-ebb4-41f4-bc87-8b54f7bbbcb9"),
				CreatedInOwnerSchemaUId = new Guid("a1507d4b-5505-46d1-8d0c-efecff370732"),
				CreatedInPackageId = new Guid("0fa99f9a-3eca-422f-9a3c-3294c39b5190"),
				CreatedInSchemaUId = new Guid("8875bc04-b5ec-4ef7-93bc-d81b1f792b05"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"CampaignDeleted",
				ModifiedInSchemaUId = new Guid("8875bc04-b5ec-4ef7-93bc-d81b1f792b05"),
				Name = @"DeletedMessage",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(40, 34),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateDeletedScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("16c11682-2a43-4c2c-8efe-1d80cd2f6041"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("c9bea1c7-ebb4-41f4-bc87-8b54f7bbbcb9"),
				CreatedInOwnerSchemaUId = new Guid("a1507d4b-5505-46d1-8d0c-efecff370732"),
				CreatedInPackageId = new Guid("0fa99f9a-3eca-422f-9a3c-3294c39b5190"),
				CreatedInSchemaUId = new Guid("8875bc04-b5ec-4ef7-93bc-d81b1f792b05"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("8875bc04-b5ec-4ef7-93bc-d81b1f792b05"),
				Name = @"DeletedScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(180, 20),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,115,73,205,73,45,73,117,78,204,45,72,204,76,207,11,78,206,72,205,77,212,208,180,230,42,74,45,41,45,202,83,40,41,42,77,181,6,0,166,204,89,173,36,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateBeforeDeletedCampaignSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaBeforeDeletedCampaignSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("f1cf7144-651d-4eb5-9cb3-f77d6686006d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("684c4d51-73ed-46a8-89ee-7e7e53ca5e96"),
				CreatedInOwnerSchemaUId = new Guid("a1507d4b-5505-46d1-8d0c-efecff370732"),
				CreatedInPackageId = new Guid("bac310da-8f6a-4932-87be-74eb3d9d7067"),
				CreatedInSchemaUId = new Guid("8875bc04-b5ec-4ef7-93bc-d81b1f792b05"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("8875bc04-b5ec-4ef7-93bc-d81b1f792b05"),
				Name = @"BeforeDeletedCampaignSubProcess",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(400, 80),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(289, 134),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaBeforeDeletedCampaignSubProcess;
		}

		protected virtual ProcessSchemaScriptTask CreateDeletingScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("4f5a130b-6f93-43d7-b853-7a02a4a6f754"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f1cf7144-651d-4eb5-9cb3-f77d6686006d"),
				CreatedInOwnerSchemaUId = new Guid("a1507d4b-5505-46d1-8d0c-efecff370732"),
				CreatedInPackageId = new Guid("bac310da-8f6a-4932-87be-74eb3d9d7067"),
				CreatedInSchemaUId = new Guid("8875bc04-b5ec-4ef7-93bc-d81b1f792b05"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("8875bc04-b5ec-4ef7-93bc-d81b1f792b05"),
				Name = @"DeletingScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(180, 31),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,11,205,203,201,204,203,118,78,204,45,72,204,76,207,11,78,206,72,205,77,116,205,73,205,77,205,43,41,214,208,180,230,42,74,45,41,45,202,83,40,41,42,77,181,6,0,101,84,55,47,44,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateDeletingMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("9c973651-bfaf-413a-b592-0d055892aec5"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("f1cf7144-651d-4eb5-9cb3-f77d6686006d"),
				CreatedInOwnerSchemaUId = new Guid("a1507d4b-5505-46d1-8d0c-efecff370732"),
				CreatedInPackageId = new Guid("bac310da-8f6a-4932-87be-74eb3d9d7067"),
				CreatedInSchemaUId = new Guid("8875bc04-b5ec-4ef7-93bc-d81b1f792b05"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"CampaignDeleting",
				ModifiedInSchemaUId = new Guid("8875bc04-b5ec-4ef7-93bc-d81b1f792b05"),
				Name = @"DeletingMessage",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(40, 45),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateAfterAddSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaAfterAddSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("8a8d2cc0-9cfe-40ea-b3b6-ad5881a724dc"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("684c4d51-73ed-46a8-89ee-7e7e53ca5e96"),
				CreatedInOwnerSchemaUId = new Guid("a1507d4b-5505-46d1-8d0c-efecff370732"),
				CreatedInPackageId = new Guid("6c038aa0-46cd-4697-bc93-5c682e364aef"),
				CreatedInSchemaUId = new Guid("8875bc04-b5ec-4ef7-93bc-d81b1f792b05"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("8875bc04-b5ec-4ef7-93bc-d81b1f792b05"),
				Name = @"AfterAddSubProcess",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(20, 233),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(299, 127),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaAfterAddSubProcess;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateInsertedCampaignMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("95a614a2-3afd-4db2-b114-a2257ce2cf93"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("8a8d2cc0-9cfe-40ea-b3b6-ad5881a724dc"),
				CreatedInOwnerSchemaUId = new Guid("a1507d4b-5505-46d1-8d0c-efecff370732"),
				CreatedInPackageId = new Guid("6c038aa0-46cd-4697-bc93-5c682e364aef"),
				CreatedInSchemaUId = new Guid("8875bc04-b5ec-4ef7-93bc-d81b1f792b05"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"CampaignInserted",
				ModifiedInSchemaUId = new Guid("8875bc04-b5ec-4ef7-93bc-d81b1f792b05"),
				Name = @"InsertedCampaignMessage",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(40, 48),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateInsertedTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("4ccc1b15-e1d5-4695-ad32-cb850c503495"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("8a8d2cc0-9cfe-40ea-b3b6-ad5881a724dc"),
				CreatedInOwnerSchemaUId = new Guid("a1507d4b-5505-46d1-8d0c-efecff370732"),
				CreatedInPackageId = new Guid("6c038aa0-46cd-4697-bc93-5c682e364aef"),
				CreatedInSchemaUId = new Guid("8875bc04-b5ec-4ef7-93bc-d81b1f792b05"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("8875bc04-b5ec-4ef7-93bc-d81b1f792b05"),
				Name = @"InsertedTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(180, 34),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,243,207,115,78,204,45,72,204,76,207,243,204,43,78,45,42,73,77,209,208,180,230,42,74,45,41,45,202,83,40,41,42,77,181,6,0,192,48,223,203,34,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateFindTargetNodeMethod());
			Methods.Add(CreateFindItemByPropertyMethod());
			Methods.Add(CreateGetCheckedConnectorsMethod());
			Methods.Add(CreateUpdateBulkEmailMethod());
			Methods.Add(CreateUpdateReferencesMethod());
			Methods.Add(CreateOnCampaignInsertingMethod());
			Methods.Add(CreateIsColumnValueChangedMethod());
			Methods.Add(CreateGetCampaignSchemaUIdMethod());
			Methods.Add(CreateGetCampaignTypeMethod());
			Methods.Add(CreateDeleteCampaignSchemaMethod());
			Methods.Add(CreateUnlinkCampaignSchemaElementsMethod());
			Methods.Add(CreateOnCampaignInsertedMethod());
			Methods.Add(CreateRemoveCampaignFromDbMethod());
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
				UId = new Guid("27462e27-06fb-4f93-af2e-0fbabb35073a"),
				Name = "System.Linq",
				Alias = "",
				CreatedInPackageId = new Guid("67ca742a-491c-42e4-bed9-36e7f4e73ff4")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("63ac7a2a-6577-4a9a-957e-8dd6e14aaac9"),
				Name = "Newtonsoft.Json.Linq",
				Alias = "",
				CreatedInPackageId = new Guid("67ca742a-491c-42e4-bed9-36e7f4e73ff4")
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
				UId = new Guid("139210de-920c-4217-8b8d-8476763e5d0e"),
				Name = "Terrasoft.Core.Campaign",
				Alias = "",
				CreatedInPackageId = new Guid("0fa99f9a-3eca-422f-9a3c-3294c39b5190")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e322566e-0935-43d1-8eb1-0de61b94cf0e"),
				Name = "Terrasoft.Nui.ServiceModel.WebService",
				Alias = "",
				CreatedInPackageId = new Guid("6c038aa0-46cd-4697-bc93-5c682e364aef")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("aca2294b-e209-4c40-9400-0d59d9ecd1ea"),
				Name = "Terrasoft.GlobalSearch.Indexing",
				Alias = "",
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5410f06b-83f8-43fa-bc49-82a2dd508d3c"),
				Name = "System.Linq",
				Alias = "",
				CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2")
			});
		}

		protected override SchemaMethod CreateDiagramSavedMethodMethod() {
			SchemaMethod method = base.CreateDiagramSavedMethodMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,203,76,83,208,112,79,45,113,78,204,45,72,204,76,207,11,169,44,72,213,208,84,176,181,85,128,137,56,231,231,21,151,20,235,249,231,164,32,171,241,76,209,84,168,230,226,44,74,45,41,45,202,83,72,74,44,78,213,115,201,76,76,47,74,204,13,78,44,75,77,241,77,45,201,200,79,209,72,206,207,43,73,173,40,209,180,230,170,229,130,42,45,41,42,77,181,6,0,193,126,33,131,117,0,0,0 };
			return method;
		}

		protected override SchemaMethod CreateSaveDiagramMethod() {
			SchemaMethod method = base.CreateSaveDiagramMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,86,77,79,227,48,16,61,55,191,194,244,20,80,72,197,185,91,164,37,237,162,34,22,42,146,229,130,56,120,19,211,26,18,59,178,29,86,209,170,255,125,199,31,249,106,139,10,210,222,82,251,205,123,126,51,227,113,233,11,242,79,22,76,81,85,135,113,186,33,5,14,35,158,87,5,147,225,119,86,251,169,249,70,179,75,100,191,194,59,92,16,52,155,161,57,197,107,129,139,88,113,129,215,196,134,232,189,211,83,244,215,27,9,162,42,193,166,222,214,147,74,80,182,70,175,146,3,11,114,66,215,68,37,117,73,50,27,246,136,243,138,124,179,192,75,255,67,226,169,119,93,209,12,9,146,114,145,45,179,142,109,37,104,129,69,221,35,155,122,55,247,191,95,73,170,80,102,217,0,236,86,194,21,22,146,248,250,60,192,120,147,240,55,194,16,227,25,145,128,113,232,167,177,89,24,63,183,128,148,51,6,193,92,12,80,221,170,134,190,99,129,10,92,2,128,145,63,77,126,22,57,41,8,83,63,113,233,91,131,225,162,40,85,29,28,198,172,56,101,138,136,167,103,244,119,11,167,115,185,203,9,206,98,69,74,157,50,96,143,112,81,98,186,102,17,103,82,201,48,18,4,43,114,11,152,102,163,193,46,179,48,225,177,225,240,59,54,168,48,205,63,166,187,170,242,183,133,134,28,97,155,211,84,81,206,32,239,174,114,1,210,229,185,116,245,145,9,143,54,36,125,107,179,113,24,173,153,94,56,56,72,55,200,223,205,53,162,253,196,155,190,114,30,36,175,68,74,238,160,72,182,29,117,222,117,83,89,6,211,2,87,245,10,171,141,223,198,7,104,220,69,141,65,118,228,228,186,85,224,249,65,89,182,84,164,128,104,193,75,34,84,237,155,86,128,104,6,74,227,96,71,58,208,202,154,140,194,53,234,51,129,237,42,207,205,153,71,112,6,69,153,238,202,209,246,128,5,87,135,15,45,116,72,237,193,85,99,188,47,106,121,102,131,118,57,116,0,231,91,97,177,38,170,231,59,105,23,26,207,93,242,123,223,141,112,63,254,168,219,14,124,204,109,135,60,228,118,151,103,54,108,103,123,130,61,205,7,211,146,159,86,197,89,182,100,47,60,124,112,147,198,168,143,204,240,217,229,52,99,72,239,216,107,221,224,194,68,212,118,206,236,6,4,136,87,234,0,141,145,208,14,79,246,247,194,165,52,236,190,157,173,173,193,182,36,95,185,4,166,141,141,218,104,120,83,159,6,116,207,192,183,127,146,105,79,61,199,21,75,55,247,165,190,215,159,21,111,50,123,219,139,125,192,25,229,238,68,205,221,0,101,53,135,169,246,85,222,184,9,116,124,191,202,12,126,180,35,109,175,26,75,168,71,223,71,208,73,27,130,173,238,225,173,55,153,164,102,150,13,19,22,62,226,138,72,111,114,118,75,165,106,158,47,100,144,250,101,235,61,24,112,254,104,119,217,31,146,125,113,14,78,38,130,72,162,16,206,115,164,143,111,200,251,175,148,226,232,252,194,251,63,157,98,218,114,207,23,252,77,96,10,83,38,253,1,187,235,81,173,16,131,130,125,116,143,213,109,142,235,68,96,38,169,46,66,196,43,166,96,210,158,95,156,154,25,178,61,155,120,49,126,55,51,174,73,155,46,156,25,82,0,209,123,123,121,213,128,94,206,166,255,0,3,247,192,215,231,8,0,0 };
			return method;
		}

		protected override SchemaMethod CreateSaveNodesMethod() {
			SchemaMethod method = base.CreateSaveNodesMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,181,144,77,75,195,64,16,134,207,201,175,24,114,218,197,176,120,87,11,154,198,18,208,32,150,234,121,201,78,237,226,126,196,253,168,130,248,223,221,54,105,122,168,222,244,54,195,188,239,51,243,206,92,242,23,199,117,173,80,163,9,247,188,7,99,5,250,93,113,5,11,12,237,216,17,122,145,223,73,31,46,23,81,138,25,56,236,172,19,62,105,150,124,139,77,64,237,73,207,93,66,52,162,28,16,229,68,74,214,85,47,120,192,71,92,99,210,116,232,73,81,111,147,184,40,225,232,26,153,63,170,111,162,122,173,53,151,234,23,135,92,3,25,59,86,217,104,2,204,224,156,194,103,158,25,124,135,57,42,12,72,86,30,93,101,141,193,46,72,107,104,158,101,236,214,89,77,14,119,178,101,183,65,205,91,174,113,63,124,222,164,253,164,104,68,65,89,107,3,161,172,49,164,178,42,106,195,30,120,250,90,130,58,127,216,75,247,158,107,35,142,188,41,193,96,122,226,42,226,142,14,103,48,80,27,95,191,69,174,78,160,211,47,7,104,253,129,93,76,1,82,208,47,64,229,241,79,130,253,235,153,223,200,37,95,228,88,2,0,0 };
			return method;
		}

		protected override SchemaMethod CreateGetConnectorsMapMethod() {
			SchemaMethod method = base.CreateGetConnectorsMapMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,204,177,10,194,48,24,4,224,217,62,69,200,212,66,233,11,56,170,136,131,69,72,55,113,136,237,89,3,201,159,242,247,47,42,226,187,171,5,113,17,117,187,131,187,143,33,3,147,34,156,212,220,217,150,109,88,120,4,144,172,109,151,206,34,17,106,137,220,155,250,136,96,75,27,144,127,222,110,162,35,1,111,119,234,154,76,190,45,82,237,237,30,190,47,10,193,89,116,174,116,229,196,227,17,228,210,33,30,82,35,236,168,205,178,252,151,211,199,129,107,148,177,121,158,181,25,155,17,116,171,230,141,45,7,215,252,65,137,229,22,242,162,170,177,125,166,146,91,54,189,3,18,3,198,120,52,1,0,0 };
			return method;
		}

		protected override SchemaMethod CreateGetNodesMapMethod() {
			SchemaMethod method = base.CreateGetNodesMapMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,204,177,10,194,48,16,6,224,217,62,69,200,212,66,233,11,56,170,72,7,139,216,110,226,112,54,215,26,72,46,33,189,162,34,190,187,161,139,10,162,78,247,195,253,255,23,144,199,64,130,240,44,150,26,250,0,118,101,208,34,241,6,124,90,57,133,67,221,158,208,66,5,22,243,207,181,173,211,196,24,246,7,113,75,102,223,26,169,52,112,68,51,20,5,227,133,101,46,100,163,217,96,12,124,245,232,186,180,230,160,169,207,178,252,151,51,48,250,38,110,38,35,222,82,61,145,245,168,213,31,4,40,85,82,231,138,29,182,46,168,9,144,47,249,13,75,238,241,185,0,235,65,247,36,179,249,3,110,95,154,114,53,1,0,0 };
			return method;
		}

		protected override SchemaMethod CreateDiagramLoadedMethodMethod() {
			SchemaMethod method = base.CreateDiagramLoadedMethodMethod();
			method.IsOverride = true;
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,203,76,83,208,112,79,45,113,78,204,45,72,204,76,207,11,169,44,72,213,208,84,176,181,85,128,137,56,231,231,21,151,20,235,249,231,164,32,171,241,76,209,84,168,230,226,44,74,45,41,45,202,83,72,74,44,78,213,115,201,76,76,47,74,204,245,201,79,76,73,77,241,77,45,201,200,79,209,72,206,207,43,73,173,40,209,180,230,170,229,130,170,45,41,42,77,181,6,0,128,49,233,142,118,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateFindTargetNodeMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("4c5eb486-7eee-4311-ab0e-2a12819a0232"),
				Name = "FindTargetNode",
				CreatedInSchemaUId = new Guid("8875bc04-b5ec-4ef7-93bc-d81b1f792b05"),
				CreatedInPackageId = new Guid("e0b7cef6-31de-4a48-86d2-3ce1d3a84b40"),
				ResultValueTypeName = "JToken"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("44fc4680-1707-48cc-ba7c-001b63c0c4ae"),
				Name = "nodes",
				CreatedInSchemaUId = new Guid("8875bc04-b5ec-4ef7-93bc-d81b1f792b05"),
				ModifiedInSchemaUId = new Guid("8875bc04-b5ec-4ef7-93bc-d81b1f792b05"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "JToken",
				CreatedInPackageId = new Guid("e0b7cef6-31de-4a48-86d2-3ce1d3a84b40")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("23f55a6e-aea3-410a-a6bc-987aaa7f0316"),
				Name = "connectors",
				CreatedInSchemaUId = new Guid("8875bc04-b5ec-4ef7-93bc-d81b1f792b05"),
				ModifiedInSchemaUId = new Guid("8875bc04-b5ec-4ef7-93bc-d81b1f792b05"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "JToken",
				CreatedInPackageId = new Guid("e0b7cef6-31de-4a48-86d2-3ce1d3a84b40")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("248ab9d7-ca57-4fd4-a184-610cfc609509"),
				Name = "connector",
				CreatedInSchemaUId = new Guid("8875bc04-b5ec-4ef7-93bc-d81b1f792b05"),
				ModifiedInSchemaUId = new Guid("8875bc04-b5ec-4ef7-93bc-d81b1f792b05"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "JToken",
				CreatedInPackageId = new Guid("e0b7cef6-31de-4a48-86d2-3ce1d3a84b40")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,145,65,78,195,48,16,69,215,228,20,86,86,137,20,229,2,85,55,132,130,138,160,170,212,136,13,98,49,74,166,193,34,30,91,246,4,136,170,222,29,39,109,154,64,91,150,150,231,191,63,126,150,91,17,21,154,8,11,214,86,204,231,130,154,186,142,197,46,184,177,200,141,165,254,60,11,246,193,39,88,161,192,8,63,129,95,226,78,66,101,65,45,106,84,72,252,12,38,114,108,37,85,233,66,25,110,147,203,51,107,45,137,209,190,190,137,221,62,158,5,135,132,96,176,21,242,74,151,184,2,133,158,239,91,210,7,228,199,92,127,32,189,64,221,224,109,187,6,126,31,247,76,68,56,166,66,143,58,204,78,80,30,115,47,169,92,50,42,31,182,218,160,229,54,34,127,227,124,152,124,81,152,252,105,78,186,98,207,146,222,200,20,116,93,201,217,3,242,214,252,251,128,113,210,47,225,24,77,23,8,207,58,15,152,185,200,64,25,144,21,101,154,28,187,52,179,8,140,79,8,229,112,177,57,34,150,101,154,235,77,191,77,20,247,155,30,133,16,126,115,54,254,238,37,39,39,169,157,24,167,27,91,96,111,245,154,158,65,66,135,202,79,19,131,218,41,237,87,121,220,9,59,70,71,240,236,7,67,132,75,44,127,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateFindItemByPropertyMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("28aa387c-cca9-4938-a025-3b39408c4ae2"),
				Name = "FindItemByProperty",
				CreatedInSchemaUId = new Guid("8875bc04-b5ec-4ef7-93bc-d81b1f792b05"),
				CreatedInPackageId = new Guid("e0b7cef6-31de-4a48-86d2-3ce1d3a84b40"),
				ResultValueTypeName = "JToken"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("c749f495-63a7-4950-bc65-d73e91c24814"),
				Name = "items",
				CreatedInSchemaUId = new Guid("8875bc04-b5ec-4ef7-93bc-d81b1f792b05"),
				ModifiedInSchemaUId = new Guid("8875bc04-b5ec-4ef7-93bc-d81b1f792b05"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "JToken",
				CreatedInPackageId = new Guid("e0b7cef6-31de-4a48-86d2-3ce1d3a84b40")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("b0f0f8e8-bedd-4716-bdc4-2aff7302a5e7"),
				Name = "propertyName",
				CreatedInSchemaUId = new Guid("8875bc04-b5ec-4ef7-93bc-d81b1f792b05"),
				ModifiedInSchemaUId = new Guid("8875bc04-b5ec-4ef7-93bc-d81b1f792b05"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("e0b7cef6-31de-4a48-86d2-3ce1d3a84b40")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("daa7d701-d579-4d85-a304-09f0a8eb8373"),
				Name = "propertyValue",
				CreatedInSchemaUId = new Guid("8875bc04-b5ec-4ef7-93bc-d81b1f792b05"),
				ModifiedInSchemaUId = new Guid("8875bc04-b5ec-4ef7-93bc-d81b1f792b05"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("e0b7cef6-31de-4a48-86d2-3ce1d3a84b40")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("008eb73a-9107-480b-8567-bafe589cde63"),
				Name = "map",
				CreatedInSchemaUId = new Guid("8875bc04-b5ec-4ef7-93bc-d81b1f792b05"),
				ModifiedInSchemaUId = new Guid("8875bc04-b5ec-4ef7-93bc-d81b1f792b05"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "DiagramElementMap",
				CreatedInPackageId = new Guid("e0b7cef6-31de-4a48-86d2-3ce1d3a84b40")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,75,203,47,74,77,76,206,80,208,240,10,201,207,78,205,83,200,44,73,205,85,200,132,208,197,154,10,213,92,156,197,37,69,153,121,233,96,129,176,196,156,210,84,5,91,133,220,196,2,61,247,212,18,136,22,176,160,83,101,64,98,73,134,6,72,145,142,66,65,81,126,65,106,81,73,165,95,98,110,170,166,53,23,103,102,154,130,6,146,118,91,184,2,176,0,216,18,206,162,212,146,210,34,136,181,64,29,181,92,181,92,80,145,188,210,156,28,107,0,190,163,78,171,166,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetCheckedConnectorsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("d279958a-2768-47c1-a72b-e05c6ebc27c3"),
				Name = "GetCheckedConnectors",
				CreatedInSchemaUId = new Guid("8875bc04-b5ec-4ef7-93bc-d81b1f792b05"),
				CreatedInPackageId = new Guid("e0b7cef6-31de-4a48-86d2-3ce1d3a84b40"),
				ResultValueTypeName = "List<string>"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("bd18f33d-df1b-4527-b6f7-6e830b5f7203"),
				Name = "connectorsToCheck",
				CreatedInSchemaUId = new Guid("8875bc04-b5ec-4ef7-93bc-d81b1f792b05"),
				ModifiedInSchemaUId = new Guid("8875bc04-b5ec-4ef7-93bc-d81b1f792b05"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Dictionary<string, Guid>",
				CreatedInPackageId = new Guid("e0b7cef6-31de-4a48-86d2-3ce1d3a84b40")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,146,77,79,2,49,16,134,207,187,191,162,225,212,94,26,239,136,137,32,26,34,70,3,168,7,227,161,110,199,165,161,219,234,180,5,137,225,191,219,110,87,129,232,197,100,147,205,76,231,125,230,115,170,156,63,117,30,149,169,207,8,130,11,218,147,1,49,176,33,211,131,23,202,250,165,122,37,180,178,198,64,229,45,186,133,29,45,161,90,241,145,13,198,83,70,6,3,114,194,200,103,89,32,248,128,166,67,245,203,93,185,22,72,170,20,59,7,29,181,29,61,27,244,222,1,142,50,84,89,195,202,34,2,117,104,12,237,77,100,47,153,151,104,27,218,27,6,189,26,55,66,233,214,247,184,4,132,28,193,39,134,102,5,191,19,40,26,240,128,238,143,50,31,132,14,224,88,82,159,27,73,123,35,225,161,182,184,205,12,55,126,15,66,127,131,98,61,206,211,27,129,43,240,177,249,214,116,124,129,170,174,99,94,217,214,241,83,208,30,180,135,79,69,48,213,242,246,45,181,244,239,4,45,117,30,7,38,131,6,121,140,98,140,8,215,141,174,95,6,23,197,132,166,249,202,151,241,7,84,33,118,28,199,123,60,83,62,54,46,32,92,12,247,46,202,218,77,29,232,17,132,132,164,61,88,20,207,72,152,181,111,116,159,34,171,139,205,82,105,32,52,75,121,138,234,184,69,113,21,148,140,204,202,162,156,200,223,21,93,12,23,219,55,136,142,53,96,220,87,180,219,245,44,108,210,117,192,167,147,231,120,115,145,149,15,137,159,75,57,19,166,6,154,124,197,239,5,231,155,80,30,26,50,56,35,233,159,119,158,14,243,187,18,198,187,171,59,10,187,134,45,75,208,54,221,174,140,223,174,60,62,226,47,182,168,40,94,36,3,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateUpdateBulkEmailMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("710eaddb-89fe-4e69-a99f-5f5559617a36"),
				Name = "UpdateBulkEmail",
				CreatedInSchemaUId = new Guid("8875bc04-b5ec-4ef7-93bc-d81b1f792b05"),
				CreatedInPackageId = new Guid("d85e35ee-2806-46ef-b091-5e59d47f9067"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("e5197216-5efd-41de-9cfa-666b16c28aca"),
				Name = "bulkEmailId",
				CreatedInSchemaUId = new Guid("8875bc04-b5ec-4ef7-93bc-d81b1f792b05"),
				ModifiedInSchemaUId = new Guid("8875bc04-b5ec-4ef7-93bc-d81b1f792b05"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("d85e35ee-2806-46ef-b091-5e59d47f9067")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("55273be1-b753-404a-9d4d-ee52b6e28b4a"),
				Name = "launchOption",
				CreatedInSchemaUId = new Guid("8875bc04-b5ec-4ef7-93bc-d81b1f792b05"),
				ModifiedInSchemaUId = new Guid("8875bc04-b5ec-4ef7-93bc-d81b1f792b05"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("d85e35ee-2806-46ef-b091-5e59d47f9067")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("ff4ef309-cedf-439c-8cd9-828677a8a0b8"),
				Name = "startDate",
				CreatedInSchemaUId = new Guid("8875bc04-b5ec-4ef7-93bc-d81b1f792b05"),
				ModifiedInSchemaUId = new Guid("8875bc04-b5ec-4ef7-93bc-d81b1f792b05"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("d85e35ee-2806-46ef-b091-5e59d47f9067")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,149,81,205,138,219,48,16,62,123,159,66,245,97,113,192,232,5,218,45,52,217,100,9,237,118,3,118,122,87,173,73,162,86,150,131,52,50,152,178,239,222,81,108,199,63,161,116,247,98,240,204,124,191,170,133,101,63,189,254,189,46,133,210,89,113,130,82,176,7,182,119,96,87,149,49,80,160,170,12,95,27,84,216,180,219,103,97,196,17,44,127,2,220,26,135,194,20,176,108,190,139,18,146,120,217,243,196,139,143,119,245,152,184,37,32,226,153,20,95,89,16,8,237,58,153,170,18,135,58,176,100,198,193,55,128,197,105,99,171,242,113,57,236,182,114,177,96,127,238,162,39,175,228,160,177,34,234,99,101,155,173,28,43,119,60,228,63,111,206,32,87,149,246,165,249,33,180,135,79,1,254,57,137,7,92,8,18,77,92,140,56,63,60,176,103,154,40,115,36,211,14,29,207,173,58,82,53,32,47,151,203,91,200,197,99,100,1,189,53,68,252,218,25,166,22,209,187,247,186,204,58,212,213,227,149,230,198,216,213,74,139,217,105,65,37,75,186,188,191,103,111,70,209,215,98,128,6,228,63,146,104,225,77,113,122,57,135,247,187,228,9,83,190,46,207,216,116,38,47,131,220,54,59,97,29,36,227,251,148,85,30,103,12,237,171,70,243,86,50,192,81,33,73,252,109,2,138,211,57,75,235,240,145,222,33,87,37,188,28,14,14,144,201,201,111,103,111,122,51,24,117,33,124,88,166,204,120,173,153,112,108,187,169,108,41,112,103,171,90,73,176,41,235,177,25,54,26,28,255,34,127,121,135,121,181,55,170,6,235,132,78,41,73,20,50,78,149,187,140,61,250,186,221,99,65,5,246,99,158,157,161,80,135,230,171,50,50,153,18,240,254,102,176,16,174,56,17,132,228,255,109,47,235,179,81,113,35,241,174,181,27,180,168,33,161,221,235,95,35,255,204,111,58,4,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateUpdateReferencesMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("cac97240-a9f0-4c4f-860e-2f645f8ef3db"),
				Name = "UpdateReferences",
				CreatedInSchemaUId = new Guid("8875bc04-b5ec-4ef7-93bc-d81b1f792b05"),
				CreatedInPackageId = new Guid("2eef8cec-00f6-49b9-a9a8-273926f614a8"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("c4e625ae-8a0b-46cc-a404-03097dd9787b"),
				Name = "schemaNames",
				CreatedInSchemaUId = new Guid("8875bc04-b5ec-4ef7-93bc-d81b1f792b05"),
				ModifiedInSchemaUId = new Guid("8875bc04-b5ec-4ef7-93bc-d81b1f792b05"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("2eef8cec-00f6-49b9-a9a8-273926f614a8")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("fc7807c6-51b3-4bae-a6b5-fa26fe42a981"),
				Name = "campaignId",
				CreatedInSchemaUId = new Guid("8875bc04-b5ec-4ef7-93bc-d81b1f792b05"),
				ModifiedInSchemaUId = new Guid("8875bc04-b5ec-4ef7-93bc-d81b1f792b05"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("2eef8cec-00f6-49b9-a9a8-273926f614a8")
			});
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("0c25b5e5-e557-412f-bf07-025752d5cd74"),
				Name = "records",
				CreatedInSchemaUId = new Guid("8875bc04-b5ec-4ef7-93bc-d81b1f792b05"),
				ModifiedInSchemaUId = new Guid("8875bc04-b5ec-4ef7-93bc-d81b1f792b05"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "List<Guid>",
				CreatedInPackageId = new Guid("2eef8cec-00f6-49b9-a9a8-273926f614a8")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,165,144,193,106,195,48,16,68,207,214,87,8,159,118,33,248,7,76,14,197,36,144,139,41,53,33,103,33,111,27,131,180,114,36,57,105,41,253,247,74,113,211,58,189,230,168,213,204,236,188,61,43,47,7,102,242,29,25,210,81,174,37,211,69,206,15,216,7,242,141,75,191,58,14,142,81,20,85,227,204,100,25,202,23,210,206,247,187,190,204,195,173,119,22,202,70,217,81,13,111,220,69,26,175,227,195,145,60,253,205,179,184,218,133,205,105,82,6,230,156,20,199,33,130,254,85,96,246,61,113,191,92,80,181,46,66,118,182,147,49,128,82,133,159,122,181,24,94,37,248,171,48,36,215,7,32,202,79,81,44,112,230,172,101,10,223,86,63,43,175,44,69,242,225,22,129,88,139,47,145,241,247,99,175,34,253,195,95,201,160,143,100,85,155,108,33,247,236,40,222,209,173,228,29,21,167,186,248,240,29,102,53,131,40,150,92,162,192,106,243,78,122,74,45,177,254,6,113,66,158,55,196,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateOnCampaignInsertingMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("a20215b8-c6d2-4b4e-82bf-9b0a13caf32b"),
				Name = "OnCampaignInserting",
				CreatedInSchemaUId = new Guid("8875bc04-b5ec-4ef7-93bc-d81b1f792b05"),
				CreatedInPackageId = new Guid("0fa99f9a-3eca-422f-9a3c-3294c39b5190"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,75,44,82,72,78,204,45,72,204,76,207,11,78,206,72,205,77,12,245,76,81,176,85,112,79,45,113,70,23,214,208,180,230,229,202,76,83,208,192,162,1,168,163,52,51,69,207,53,183,160,164,82,83,161,154,151,139,211,53,175,36,179,164,82,47,24,104,80,126,78,105,110,94,88,98,78,105,170,134,18,134,169,74,58,10,121,165,57,57,32,179,107,1,6,83,233,67,142,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateIsColumnValueChangedMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("763cc6eb-3714-40c1-a7ef-dfba1e4a74f1"),
				Name = "IsColumnValueChanged",
				CreatedInSchemaUId = new Guid("8875bc04-b5ec-4ef7-93bc-d81b1f792b05"),
				CreatedInPackageId = new Guid("0fa99f9a-3eca-422f-9a3c-3294c39b5190"),
				ResultValueTypeName = "bool"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("ff4d103c-cb93-4a90-a89e-93de9e90bb8a"),
				Name = "columnName",
				CreatedInSchemaUId = new Guid("8875bc04-b5ec-4ef7-93bc-d81b1f792b05"),
				ModifiedInSchemaUId = new Guid("8875bc04-b5ec-4ef7-93bc-d81b1f792b05"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "string",
				CreatedInPackageId = new Guid("0fa99f9a-3eca-422f-9a3c-3294c39b5190")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,43,74,45,41,45,202,83,112,205,43,201,44,169,212,115,79,45,241,44,118,206,207,41,205,205,11,75,204,41,77,245,201,79,76,73,77,209,72,6,139,248,37,230,166,106,42,168,169,41,112,113,34,148,59,103,36,230,165,167,166,32,233,41,214,208,212,115,204,171,212,136,87,176,181,83,136,215,3,233,82,176,181,85,64,50,195,26,0,122,34,110,6,117,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetCampaignSchemaUIdMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("d477955b-547e-4286-819f-458c9c3c256d"),
				Name = "GetCampaignSchemaUId",
				CreatedInSchemaUId = new Guid("8875bc04-b5ec-4ef7-93bc-d81b1f792b05"),
				CreatedInPackageId = new Guid("0fa99f9a-3eca-422f-9a3c-3294c39b5190"),
				ResultValueTypeName = "Guid"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,115,47,205,76,81,72,78,204,45,72,204,76,207,11,78,206,72,205,77,12,245,76,81,176,85,112,7,74,232,185,230,22,148,84,90,115,101,166,41,104,184,230,149,100,150,84,234,185,167,150,120,22,59,231,231,148,230,230,133,37,230,148,166,250,228,39,166,164,166,104,40,57,163,27,161,164,169,169,80,205,197,137,205,104,132,81,33,149,5,169,41,72,166,217,128,108,181,195,106,154,53,87,45,87,81,106,73,105,81,30,166,115,173,1,219,125,233,204,198,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetCampaignTypeMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("bb7c0e78-4c22-410b-9dd6-3a46a8f738a2"),
				Name = "GetCampaignType",
				CreatedInSchemaUId = new Guid("8875bc04-b5ec-4ef7-93bc-d81b1f792b05"),
				CreatedInPackageId = new Guid("0fa99f9a-3eca-422f-9a3c-3294c39b5190"),
				ResultValueTypeName = "Guid"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,115,47,205,76,81,40,169,44,72,245,76,81,176,85,112,7,242,244,92,115,11,74,42,173,185,50,211,20,52,92,243,74,50,75,42,245,130,147,51,82,115,19,245,156,243,115,74,115,243,138,245,28,243,42,53,226,21,108,237,20,226,245,252,18,115,83,21,108,109,21,148,66,128,70,40,105,42,168,169,41,64,245,184,167,150,120,22,67,116,132,37,230,148,166,250,228,39,166,164,166,104,128,21,122,166,40,105,106,42,84,115,113,194,45,70,104,2,201,167,32,233,179,1,185,201,14,161,207,154,171,150,171,40,181,164,180,40,15,234,108,107,0,139,47,127,246,195,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateDeleteCampaignSchemaMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("684391d7-f0e1-490c-a14d-9979b3df5c88"),
				Name = "DeleteCampaignSchema",
				CreatedInSchemaUId = new Guid("8875bc04-b5ec-4ef7-93bc-d81b1f792b05"),
				CreatedInPackageId = new Guid("0fa99f9a-3eca-422f-9a3c-3294c39b5190"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,143,65,10,131,48,16,69,215,205,41,6,87,9,20,47,32,110,42,173,184,232,166,197,3,4,51,181,1,51,74,140,130,148,222,189,145,118,99,12,221,206,159,121,127,94,57,105,5,141,52,131,212,45,221,155,39,26,89,87,10,114,40,209,21,225,152,139,140,233,7,240,221,126,90,141,103,51,184,133,11,1,47,118,176,232,38,75,25,123,179,89,218,128,126,149,36,91,180,190,129,23,177,64,212,35,218,162,39,194,198,233,158,82,255,199,38,231,73,244,44,241,175,173,101,218,161,241,236,104,103,122,209,164,42,191,112,90,86,153,157,197,207,238,139,200,129,166,174,11,116,226,216,27,154,126,198,63,224,35,108,165,68,246,1,88,80,175,202,119,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateUnlinkCampaignSchemaElementsMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("2ce769d1-c954-48d5-be78-7e88db026c3b"),
				Name = "UnlinkCampaignSchemaElements",
				CreatedInSchemaUId = new Guid("8875bc04-b5ec-4ef7-93bc-d81b1f792b05"),
				CreatedInPackageId = new Guid("bac310da-8f6a-4932-87be-74eb3d9d7067"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,144,65,110,131,64,12,69,215,204,41,172,172,6,169,154,11,68,172,40,141,88,116,213,230,0,214,224,36,72,96,144,199,68,141,42,238,222,33,9,169,72,88,141,52,223,254,239,251,239,134,186,2,143,109,143,245,145,191,252,137,90,220,151,21,100,176,35,205,159,191,109,186,53,245,1,236,203,188,43,67,209,246,122,177,105,10,191,38,17,210,65,120,107,70,115,70,121,114,255,68,198,35,73,36,216,124,77,72,247,129,36,239,152,201,107,221,177,139,57,22,186,221,172,174,109,98,52,149,203,68,255,38,17,12,221,65,93,222,9,185,121,220,45,247,32,220,158,108,61,223,63,183,228,160,200,158,94,175,142,200,100,170,99,118,202,128,135,166,185,54,240,168,32,25,77,50,131,139,51,177,126,160,199,138,220,59,53,164,100,151,199,190,221,67,69,227,49,198,82,127,2,91,252,120,234,39,17,104,217,237,31,163,126,58,208,186,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateOnCampaignInsertedMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("5ea791b3-a8a1-4c18-b5ef-1f6854ef0dac"),
				Name = "OnCampaignInserted",
				CreatedInSchemaUId = new Guid("8875bc04-b5ec-4ef7-93bc-d81b1f792b05"),
				CreatedInPackageId = new Guid("6c038aa0-46cd-4697-bc93-5c682e364aef"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,143,193,14,130,48,16,68,207,240,21,27,78,37,33,252,128,241,132,96,184,106,240,94,203,42,77,232,150,212,45,74,12,255,110,49,234,65,189,78,102,222,204,140,210,129,146,102,144,250,76,123,213,161,145,77,221,194,26,182,200,197,183,44,210,85,172,79,32,254,248,67,192,235,54,47,205,192,83,10,247,56,42,137,53,79,249,62,96,108,239,13,29,100,239,81,36,63,204,36,3,242,125,31,200,145,67,246,142,86,241,28,179,155,22,198,219,92,142,72,92,73,37,91,204,11,59,76,162,185,160,43,44,17,42,214,150,50,120,149,213,109,246,251,37,144,231,160,178,234,64,148,55,133,195,18,1,124,142,220,161,177,35,190,107,42,103,205,230,40,62,176,101,19,119,206,94,151,73,15,190,138,206,236,40,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateRemoveCampaignFromDbMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("06c58ce1-4b9d-42b4-80f6-33b6b8b44773"),
				Name = "RemoveCampaignFromDb",
				CreatedInSchemaUId = new Guid("8875bc04-b5ec-4ef7-93bc-d81b1f792b05"),
				CreatedInPackageId = new Guid("6c038aa0-46cd-4697-bc93-5c682e364aef"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("9ca5bf8d-503c-40bc-9074-cc179c74b789"),
				Name = "entityId",
				CreatedInSchemaUId = new Guid("8875bc04-b5ec-4ef7-93bc-d81b1f792b05"),
				ModifiedInSchemaUId = new Guid("8875bc04-b5ec-4ef7-93bc-d81b1f792b05"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("6c038aa0-46cd-4697-bc93-5c682e364aef")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,21,204,49,14,131,48,16,5,209,58,156,34,114,181,110,124,1,74,7,36,119,105,34,234,21,124,17,75,246,58,89,108,65,110,31,104,71,154,39,216,239,15,36,84,208,107,131,250,34,130,185,198,34,182,187,185,81,75,38,227,57,127,56,174,98,174,52,189,161,32,19,22,99,93,216,134,111,227,68,190,164,150,197,61,89,57,159,144,18,164,198,250,11,139,189,142,225,192,220,78,222,246,127,205,89,103,48,108,0,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new CampaignEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("8875bc04-b5ec-4ef7-93bc-d81b1f792b05"));
		}

		#endregion

	}

	#endregion


	#region Class: CampaignEventsProcess

	/// <exclude/>
	public class CampaignEventsProcess : Campaign_CampaignsEventsProcess
	{

		public CampaignEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

