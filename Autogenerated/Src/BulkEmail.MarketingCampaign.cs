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
	using Terrasoft.Configuration.DynamicContent;
	using Terrasoft.Configuration.DynamicContent.Models;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.DcmProcess;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Factories;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;
	using Terrasoft.GlobalSearch.Indexing;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities.Json.Converters;

	#region Class: BulkEmailSchema

	/// <exclude/>
	public class BulkEmailSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public BulkEmailSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public BulkEmailSchema(BulkEmailSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public BulkEmailSchema(BulkEmailSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("95fbcf9c-e36d-4acd-8b5a-d657de6e30a8");
			RealUId = new Guid("95fbcf9c-e36d-4acd-8b5a-d657de6e30a8");
			Name = "BulkEmail";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("b827f319-d8b8-41a8-9645-da32137f000d");
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
			if (Columns.FindByUId(new Guid("179852a9-99a4-40d7-9a0d-1b1354528eab")) == null) {
				Columns.Add(CreateOwnerColumn());
			}
			if (Columns.FindByUId(new Guid("ba9154c4-cbaf-44bc-a613-fc75abe5d0e4")) == null) {
				Columns.Add(CreateTypeColumn());
			}
			if (Columns.FindByUId(new Guid("61488596-901e-457a-b02d-c2fea49f75c3")) == null) {
				Columns.Add(CreateStatusColumn());
			}
			if (Columns.FindByUId(new Guid("eedcc192-9bd0-4870-b471-e2935e03e269")) == null) {
				Columns.Add(CreateStartDateColumn());
			}
			if (Columns.FindByUId(new Guid("bb7976b3-0b0a-4623-bf51-f7d5d7127b24")) == null) {
				Columns.Add(CreateSenderNameColumn());
			}
			if (Columns.FindByUId(new Guid("a7b7ea13-8870-409d-8dec-d91dcef2770f")) == null) {
				Columns.Add(CreateSenderEmailColumn());
			}
			if (Columns.FindByUId(new Guid("ea0bf113-a0a3-4b5c-b3b7-c82f8f10c610")) == null) {
				Columns.Add(CreateNotesColumn());
			}
			if (Columns.FindByUId(new Guid("93fd7ba3-6f59-4bb6-b242-54fbb8c960a8")) == null) {
				Columns.Add(CreateSendStartDateColumn());
			}
			if (Columns.FindByUId(new Guid("4098b376-f4a4-43b9-9c2a-83a0ed5bb111")) == null) {
				Columns.Add(CreateSendDueDateColumn());
			}
			if (Columns.FindByUId(new Guid("ea77b054-19e8-4f5a-acad-426389d56b27")) == null) {
				Columns.Add(CreateClicksColumn());
			}
			if (Columns.FindByUId(new Guid("2b38e45b-4d3e-4f8b-94e6-e2f6a2286c9b")) == null) {
				Columns.Add(CreateOpensColumn());
			}
			if (Columns.FindByUId(new Guid("f220825a-b9e8-439b-9379-a9abc4784ecb")) == null) {
				Columns.Add(CreateSoftBounceColumn());
			}
			if (Columns.FindByUId(new Guid("08ad2aad-2a2f-485c-a056-3575826d5856")) == null) {
				Columns.Add(CreateHardBounceColumn());
			}
			if (Columns.FindByUId(new Guid("538a2dca-73f7-4535-bc5c-80d2a1dac4d7")) == null) {
				Columns.Add(CreateUnsubscribeColumn());
			}
			if (Columns.FindByUId(new Guid("60c0d829-5d8b-4b3c-9941-5ea47ba88aa5")) == null) {
				Columns.Add(CreateSpamColumn());
			}
			if (Columns.FindByUId(new Guid("69026123-bf84-463f-b512-d0e138aaa535")) == null) {
				Columns.Add(CreateClicksCountColumn());
			}
			if (Columns.FindByUId(new Guid("0b997f26-118b-422c-85c8-665334844ad5")) == null) {
				Columns.Add(CreateOpensCountColumn());
			}
			if (Columns.FindByUId(new Guid("7340a01b-ae07-471d-96f0-c3e59cb5a506")) == null) {
				Columns.Add(CreateSoftBounceCountColumn());
			}
			if (Columns.FindByUId(new Guid("93d105bd-60a0-44bd-9d51-82e5b55c0b28")) == null) {
				Columns.Add(CreateHardBounceCountColumn());
			}
			if (Columns.FindByUId(new Guid("c19c69e9-a4f5-4967-82fc-c4ae2169e56f")) == null) {
				Columns.Add(CreateUnsubscribeCountColumn());
			}
			if (Columns.FindByUId(new Guid("3ad234c8-e65c-4261-bd4f-dd5153614592")) == null) {
				Columns.Add(CreateSpamCountColumn());
			}
			if (Columns.FindByUId(new Guid("31c0c36e-2d17-41fb-b60a-9ced9d6114da")) == null) {
				Columns.Add(CreateSegmentsStatusColumn());
			}
			if (Columns.FindByUId(new Guid("2c873902-d974-4c19-8ff7-b33beebe0337")) == null) {
				Columns.Add(CreateRecipientCountColumn());
			}
			if (Columns.FindByUId(new Guid("da45936d-12c4-44f5-9dbf-93dccfcb27bc")) == null) {
				Columns.Add(CreateLastActualizeDateColumn());
			}
			if (Columns.FindByUId(new Guid("3e65fbaf-d5dd-431d-a2b9-2badabbaacf5")) == null) {
				Columns.Add(CreateTemplateSubjectColumn());
			}
			if (Columns.FindByUId(new Guid("9ec4de0a-6c4f-4634-b5af-df256380edb7")) == null) {
				Columns.Add(CreateTemplateBodyColumn());
			}
			if (Columns.FindByUId(new Guid("b5ee5edb-5d5b-4438-be3c-ba043ef3f561")) == null) {
				Columns.Add(CreateDeliveredCountColumn());
			}
			if (Columns.FindByUId(new Guid("46e0c161-0fd6-4300-9bdd-eb4f68dcbe34")) == null) {
				Columns.Add(CreateNotDeliveredCountColumn());
			}
			if (Columns.FindByUId(new Guid("d224320e-5b42-4e13-afe3-27eb41d49285")) == null) {
				Columns.Add(CreateInQueueCountColumn());
			}
			if (Columns.FindByUId(new Guid("4084cb33-7820-4578-b8b9-87ced0ca3b9d")) == null) {
				Columns.Add(CreateCanceledCountColumn());
			}
			if (Columns.FindByUId(new Guid("b1896082-56f9-4cf8-aedb-25ff3dfc2727")) == null) {
				Columns.Add(CreateBlankEmailCountColumn());
			}
			if (Columns.FindByUId(new Guid("9d65ede6-b98b-455a-821b-90cf0e7cd064")) == null) {
				Columns.Add(CreateIncorrectEmailCountColumn());
			}
			if (Columns.FindByUId(new Guid("ca45c924-d210-40ce-9b87-b720a73a3040")) == null) {
				Columns.Add(CreateUnreachableEmailCountColumn());
			}
			if (Columns.FindByUId(new Guid("e2a193cf-9dd4-4246-9d53-49daeadf5892")) == null) {
				Columns.Add(CreateDoNotUseEmailCountColumn());
			}
			if (Columns.FindByUId(new Guid("efa2e7d3-8633-4a52-a400-30924f08f0f4")) == null) {
				Columns.Add(CreateDuplicateEmailCountColumn());
			}
			if (Columns.FindByUId(new Guid("89232498-d4f6-4b83-b20d-2572c1571f85")) == null) {
				Columns.Add(CreateRejectedCountColumn());
			}
			if (Columns.FindByUId(new Guid("2a285982-5a92-48f1-b639-8479545c4721")) == null) {
				Columns.Add(CreateCommonErrorCountColumn());
			}
			if (Columns.FindByUId(new Guid("2c1e0609-ac0a-4c38-b860-8f5388f297d7")) == null) {
				Columns.Add(CreateInvalidAddresseeCountColumn());
			}
			if (Columns.FindByUId(new Guid("eae57226-68ed-4856-8246-c5ec4606529b")) == null) {
				Columns.Add(CreatePercentWeightColumn());
			}
			if (Columns.FindByUId(new Guid("c2a9de1b-9bd4-44bb-b3ac-7d4448d346d0")) == null) {
				Columns.Add(CreatePercentActiveWeightColumn());
			}
			if (Columns.FindByUId(new Guid("d785e098-20e4-438e-9a96-ac93fb86a156")) == null) {
				Columns.Add(CreatePercentInactiveWeightColumn());
			}
			if (Columns.FindByUId(new Guid("2a905616-fe78-440c-b1fb-d046b98410ee")) == null) {
				Columns.Add(CreateSendCountColumn());
			}
			if (Columns.FindByUId(new Guid("0006f192-a00c-4372-82d8-24df40e8782e")) == null) {
				Columns.Add(CreateCommunicationLimitCountColumn());
			}
			if (Columns.FindByUId(new Guid("b2d54128-352b-409c-8d9f-864222172044")) == null) {
				Columns.Add(CreateUtmSourceColumn());
			}
			if (Columns.FindByUId(new Guid("545c4f53-5c13-4c18-99b3-12713feafb07")) == null) {
				Columns.Add(CreateUtmMediumColumn());
			}
			if (Columns.FindByUId(new Guid("6a54fc79-6db3-495e-8752-c15f3de1371f")) == null) {
				Columns.Add(CreateUtmCampaignColumn());
			}
			if (Columns.FindByUId(new Guid("d145dfd4-03eb-4bd1-ae1a-ec1046c2290c")) == null) {
				Columns.Add(CreateUtmTermColumn());
			}
			if (Columns.FindByUId(new Guid("c0ecb652-be4e-4e14-91a1-dc17c4eabe25")) == null) {
				Columns.Add(CreateUtmContentColumn());
			}
			if (Columns.FindByUId(new Guid("c38d1340-1f04-4106-893b-c123256082ed")) == null) {
				Columns.Add(CreateDomainsColumn());
			}
			if (Columns.FindByUId(new Guid("71c597c9-94dd-4efe-b2d9-d6989621653a")) == null) {
				Columns.Add(CreateUseUtmColumn());
			}
			if (Columns.FindByUId(new Guid("6f3b2c62-03a2-4a6a-802b-5c3445e6b534")) == null) {
				Columns.Add(CreateCampaignColumn());
			}
			if (Columns.FindByUId(new Guid("271d3ef0-6520-479c-8067-5b212d91e534")) == null) {
				Columns.Add(CreateStatisticDateColumn());
			}
			if (Columns.FindByUId(new Guid("5d100c2f-01b7-4216-9bf7-6bf20af49d30")) == null) {
				Columns.Add(CreateResponseProcessingCompletedColumn());
			}
			if (Columns.FindByUId(new Guid("70e14aa1-d9f5-4b73-b59e-22d5513d3dd8")) == null) {
				Columns.Add(CreateSplitTestColumn());
			}
			if (Columns.FindByUId(new Guid("e38eb3e2-20d5-4b11-aa34-c2fe23348070")) == null) {
				Columns.Add(CreateCategoryColumn());
			}
			if (Columns.FindByUId(new Guid("c5bf86d5-4624-4470-b6b1-0d3d8755dba1")) == null) {
				Columns.Add(CreateLaunchOptionColumn());
			}
			if (Columns.FindByUId(new Guid("167e049c-00ae-41c5-bfc2-856eae2880c9")) == null) {
				Columns.Add(CreateTemplateConfigColumn());
			}
			if (Columns.FindByUId(new Guid("7030ab07-36cf-4227-8bce-55f97a1e5120")) == null) {
				Columns.Add(CreateDeliveryErrorColumn());
			}
			if (Columns.FindByUId(new Guid("467b5d60-a7b3-4cf2-b607-0b77bc504ff9")) == null) {
				Columns.Add(CreateIsSystemEmailColumn());
			}
			if (Columns.FindByUId(new Guid("f986de1b-eccd-4409-a145-a7ef9d4116c3")) == null) {
				Columns.Add(CreateTemplateNotFoundCountColumn());
			}
			if (Columns.FindByUId(new Guid("1f2d242f-785a-4c0f-9942-6caac23d668a")) == null) {
				Columns.Add(CreateSendersDomainNotVerifiedCountColumn());
			}
			if (Columns.FindByUId(new Guid("2d960dec-c57c-4412-8667-022cbacf5373")) == null) {
				Columns.Add(CreateSendersNameNotValidCountColumn());
			}
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.ModifiedInSchemaUId = new Guid("95fbcf9c-e36d-4acd-8b5a-d657de6e30a8");
			column.CreatedInPackageId = new Guid("b827f319-d8b8-41a8-9645-da32137f000d");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.ModifiedInSchemaUId = new Guid("95fbcf9c-e36d-4acd-8b5a-d657de6e30a8");
			column.CreatedInPackageId = new Guid("b827f319-d8b8-41a8-9645-da32137f000d");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.ModifiedInSchemaUId = new Guid("95fbcf9c-e36d-4acd-8b5a-d657de6e30a8");
			column.CreatedInPackageId = new Guid("b827f319-d8b8-41a8-9645-da32137f000d");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.ModifiedInSchemaUId = new Guid("95fbcf9c-e36d-4acd-8b5a-d657de6e30a8");
			column.CreatedInPackageId = new Guid("b827f319-d8b8-41a8-9645-da32137f000d");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.ModifiedInSchemaUId = new Guid("95fbcf9c-e36d-4acd-8b5a-d657de6e30a8");
			column.CreatedInPackageId = new Guid("b827f319-d8b8-41a8-9645-da32137f000d");
			return column;
		}

		protected override EntitySchemaColumn CreateProcessListenersColumn() {
			EntitySchemaColumn column = base.CreateProcessListenersColumn();
			column.ModifiedInSchemaUId = new Guid("95fbcf9c-e36d-4acd-8b5a-d657de6e30a8");
			column.CreatedInPackageId = new Guid("b827f319-d8b8-41a8-9645-da32137f000d");
			return column;
		}

		protected virtual EntitySchemaColumn CreateNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("975137ab-181c-4e96-b4d9-66e55474b28d"),
				Name = @"Name",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("95fbcf9c-e36d-4acd-8b5a-d657de6e30a8"),
				ModifiedInSchemaUId = new Guid("95fbcf9c-e36d-4acd-8b5a-d657de6e30a8"),
				CreatedInPackageId = new Guid("b827f319-d8b8-41a8-9645-da32137f000d")
			};
		}

		protected virtual EntitySchemaColumn CreateOwnerColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("179852a9-99a4-40d7-9a0d-1b1354528eab"),
				Name = @"Owner",
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("95fbcf9c-e36d-4acd-8b5a-d657de6e30a8"),
				ModifiedInSchemaUId = new Guid("95fbcf9c-e36d-4acd-8b5a-d657de6e30a8"),
				CreatedInPackageId = new Guid("b827f319-d8b8-41a8-9645-da32137f000d"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.SystemValue,
					ValueSource = SystemValueManager.GetInstanceByName(@"CurrentUserContact")
				}
			};
		}

		protected virtual EntitySchemaColumn CreateTypeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("ba9154c4-cbaf-44bc-a613-fc75abe5d0e4"),
				Name = @"Type",
				ReferenceSchemaUId = new Guid("708702c2-7d97-4702-879a-39aa5f6eef8f"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("95fbcf9c-e36d-4acd-8b5a-d657de6e30a8"),
				ModifiedInSchemaUId = new Guid("95fbcf9c-e36d-4acd-8b5a-d657de6e30a8"),
				CreatedInPackageId = new Guid("b827f319-d8b8-41a8-9645-da32137f000d"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"2909d41f-2797-4c45-9f3f-9835eb88e515"
				}
			};
		}

		protected virtual EntitySchemaColumn CreateStatusColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("61488596-901e-457a-b02d-c2fea49f75c3"),
				Name = @"Status",
				ReferenceSchemaUId = new Guid("6018ff01-89b1-4826-9173-9b38cb29b6f3"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("95fbcf9c-e36d-4acd-8b5a-d657de6e30a8"),
				ModifiedInSchemaUId = new Guid("95fbcf9c-e36d-4acd-8b5a-d657de6e30a8"),
				CreatedInPackageId = new Guid("b827f319-d8b8-41a8-9645-da32137f000d"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"32848D61-3792-4B06-A183-EAF1D1769897"
				}
			};
		}

		protected virtual EntitySchemaColumn CreateStartDateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("DateTime")) {
				UId = new Guid("eedcc192-9bd0-4870-b471-e2935e03e269"),
				Name = @"StartDate",
				IsValueCloneable = false,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("95fbcf9c-e36d-4acd-8b5a-d657de6e30a8"),
				ModifiedInSchemaUId = new Guid("95fbcf9c-e36d-4acd-8b5a-d657de6e30a8"),
				CreatedInPackageId = new Guid("b827f319-d8b8-41a8-9645-da32137f000d")
			};
		}

		protected virtual EntitySchemaColumn CreateSenderNameColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("bb7976b3-0b0a-4623-bf51-f7d5d7127b24"),
				Name = @"SenderName",
				CreatedInSchemaUId = new Guid("95fbcf9c-e36d-4acd-8b5a-d657de6e30a8"),
				ModifiedInSchemaUId = new Guid("95fbcf9c-e36d-4acd-8b5a-d657de6e30a8"),
				CreatedInPackageId = new Guid("b827f319-d8b8-41a8-9645-da32137f000d")
			};
		}

		protected virtual EntitySchemaColumn CreateSenderEmailColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("a7b7ea13-8870-409d-8dec-d91dcef2770f"),
				Name = @"SenderEmail",
				CreatedInSchemaUId = new Guid("95fbcf9c-e36d-4acd-8b5a-d657de6e30a8"),
				ModifiedInSchemaUId = new Guid("95fbcf9c-e36d-4acd-8b5a-d657de6e30a8"),
				CreatedInPackageId = new Guid("b827f319-d8b8-41a8-9645-da32137f000d")
			};
		}

		protected virtual EntitySchemaColumn CreateNotesColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("ea0bf113-a0a3-4b5c-b3b7-c82f8f10c610"),
				Name = @"Notes",
				CreatedInSchemaUId = new Guid("95fbcf9c-e36d-4acd-8b5a-d657de6e30a8"),
				ModifiedInSchemaUId = new Guid("95fbcf9c-e36d-4acd-8b5a-d657de6e30a8"),
				CreatedInPackageId = new Guid("b827f319-d8b8-41a8-9645-da32137f000d")
			};
		}

		protected virtual EntitySchemaColumn CreateSendStartDateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("DateTime")) {
				UId = new Guid("93fd7ba3-6f59-4bb6-b242-54fbb8c960a8"),
				Name = @"SendStartDate",
				IsValueCloneable = false,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("95fbcf9c-e36d-4acd-8b5a-d657de6e30a8"),
				ModifiedInSchemaUId = new Guid("95fbcf9c-e36d-4acd-8b5a-d657de6e30a8"),
				CreatedInPackageId = new Guid("b477c174-1d53-4a21-b489-a41e481a96a0")
			};
		}

		protected virtual EntitySchemaColumn CreateSendDueDateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("DateTime")) {
				UId = new Guid("4098b376-f4a4-43b9-9c2a-83a0ed5bb111"),
				Name = @"SendDueDate",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("95fbcf9c-e36d-4acd-8b5a-d657de6e30a8"),
				ModifiedInSchemaUId = new Guid("95fbcf9c-e36d-4acd-8b5a-d657de6e30a8"),
				CreatedInPackageId = new Guid("b477c174-1d53-4a21-b489-a41e481a96a0")
			};
		}

		protected virtual EntitySchemaColumn CreateClicksColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float2")) {
				UId = new Guid("ea77b054-19e8-4f5a-acad-426389d56b27"),
				Name = @"Clicks",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("95fbcf9c-e36d-4acd-8b5a-d657de6e30a8"),
				ModifiedInSchemaUId = new Guid("95fbcf9c-e36d-4acd-8b5a-d657de6e30a8"),
				CreatedInPackageId = new Guid("48513af2-42ae-4933-a664-64fbd4224266")
			};
		}

		protected virtual EntitySchemaColumn CreateOpensColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float2")) {
				UId = new Guid("2b38e45b-4d3e-4f8b-94e6-e2f6a2286c9b"),
				Name = @"Opens",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("95fbcf9c-e36d-4acd-8b5a-d657de6e30a8"),
				ModifiedInSchemaUId = new Guid("95fbcf9c-e36d-4acd-8b5a-d657de6e30a8"),
				CreatedInPackageId = new Guid("48513af2-42ae-4933-a664-64fbd4224266")
			};
		}

		protected virtual EntitySchemaColumn CreateSoftBounceColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float2")) {
				UId = new Guid("f220825a-b9e8-439b-9379-a9abc4784ecb"),
				Name = @"SoftBounce",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("95fbcf9c-e36d-4acd-8b5a-d657de6e30a8"),
				ModifiedInSchemaUId = new Guid("95fbcf9c-e36d-4acd-8b5a-d657de6e30a8"),
				CreatedInPackageId = new Guid("48513af2-42ae-4933-a664-64fbd4224266")
			};
		}

		protected virtual EntitySchemaColumn CreateHardBounceColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float2")) {
				UId = new Guid("08ad2aad-2a2f-485c-a056-3575826d5856"),
				Name = @"HardBounce",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("95fbcf9c-e36d-4acd-8b5a-d657de6e30a8"),
				ModifiedInSchemaUId = new Guid("95fbcf9c-e36d-4acd-8b5a-d657de6e30a8"),
				CreatedInPackageId = new Guid("48513af2-42ae-4933-a664-64fbd4224266")
			};
		}

		protected virtual EntitySchemaColumn CreateUnsubscribeColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float2")) {
				UId = new Guid("538a2dca-73f7-4535-bc5c-80d2a1dac4d7"),
				Name = @"Unsubscribe",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("95fbcf9c-e36d-4acd-8b5a-d657de6e30a8"),
				ModifiedInSchemaUId = new Guid("95fbcf9c-e36d-4acd-8b5a-d657de6e30a8"),
				CreatedInPackageId = new Guid("48513af2-42ae-4933-a664-64fbd4224266")
			};
		}

		protected virtual EntitySchemaColumn CreateSpamColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float2")) {
				UId = new Guid("60c0d829-5d8b-4b3c-9941-5ea47ba88aa5"),
				Name = @"Spam",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("95fbcf9c-e36d-4acd-8b5a-d657de6e30a8"),
				ModifiedInSchemaUId = new Guid("95fbcf9c-e36d-4acd-8b5a-d657de6e30a8"),
				CreatedInPackageId = new Guid("48513af2-42ae-4933-a664-64fbd4224266")
			};
		}

		protected virtual EntitySchemaColumn CreateClicksCountColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("69026123-bf84-463f-b512-d0e138aaa535"),
				Name = @"ClicksCount",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("95fbcf9c-e36d-4acd-8b5a-d657de6e30a8"),
				ModifiedInSchemaUId = new Guid("95fbcf9c-e36d-4acd-8b5a-d657de6e30a8"),
				CreatedInPackageId = new Guid("48513af2-42ae-4933-a664-64fbd4224266")
			};
		}

		protected virtual EntitySchemaColumn CreateOpensCountColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("0b997f26-118b-422c-85c8-665334844ad5"),
				Name = @"OpensCount",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("95fbcf9c-e36d-4acd-8b5a-d657de6e30a8"),
				ModifiedInSchemaUId = new Guid("95fbcf9c-e36d-4acd-8b5a-d657de6e30a8"),
				CreatedInPackageId = new Guid("48513af2-42ae-4933-a664-64fbd4224266")
			};
		}

		protected virtual EntitySchemaColumn CreateSoftBounceCountColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("7340a01b-ae07-471d-96f0-c3e59cb5a506"),
				Name = @"SoftBounceCount",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("95fbcf9c-e36d-4acd-8b5a-d657de6e30a8"),
				ModifiedInSchemaUId = new Guid("95fbcf9c-e36d-4acd-8b5a-d657de6e30a8"),
				CreatedInPackageId = new Guid("48513af2-42ae-4933-a664-64fbd4224266")
			};
		}

		protected virtual EntitySchemaColumn CreateHardBounceCountColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("93d105bd-60a0-44bd-9d51-82e5b55c0b28"),
				Name = @"HardBounceCount",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("95fbcf9c-e36d-4acd-8b5a-d657de6e30a8"),
				ModifiedInSchemaUId = new Guid("95fbcf9c-e36d-4acd-8b5a-d657de6e30a8"),
				CreatedInPackageId = new Guid("48513af2-42ae-4933-a664-64fbd4224266")
			};
		}

		protected virtual EntitySchemaColumn CreateUnsubscribeCountColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("c19c69e9-a4f5-4967-82fc-c4ae2169e56f"),
				Name = @"UnsubscribeCount",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("95fbcf9c-e36d-4acd-8b5a-d657de6e30a8"),
				ModifiedInSchemaUId = new Guid("95fbcf9c-e36d-4acd-8b5a-d657de6e30a8"),
				CreatedInPackageId = new Guid("48513af2-42ae-4933-a664-64fbd4224266")
			};
		}

		protected virtual EntitySchemaColumn CreateSpamCountColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("3ad234c8-e65c-4261-bd4f-dd5153614592"),
				Name = @"SpamCount",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("95fbcf9c-e36d-4acd-8b5a-d657de6e30a8"),
				ModifiedInSchemaUId = new Guid("95fbcf9c-e36d-4acd-8b5a-d657de6e30a8"),
				CreatedInPackageId = new Guid("48513af2-42ae-4933-a664-64fbd4224266")
			};
		}

		protected virtual EntitySchemaColumn CreateSegmentsStatusColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("31c0c36e-2d17-41fb-b60a-9ced9d6114da"),
				Name = @"SegmentsStatus",
				ReferenceSchemaUId = new Guid("80ea7f5b-3991-42c6-bc29-f101d9757c70"),
				IsValueCloneable = false,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("95fbcf9c-e36d-4acd-8b5a-d657de6e30a8"),
				ModifiedInSchemaUId = new Guid("95fbcf9c-e36d-4acd-8b5a-d657de6e30a8"),
				CreatedInPackageId = new Guid("8ff9fe4f-03be-4db5-b64a-71abfee30f54"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"fa360d2c-1658-49ad-9152-22479fdc0c12"
				}
			};
		}

		protected virtual EntitySchemaColumn CreateRecipientCountColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("2c873902-d974-4c19-8ff7-b33beebe0337"),
				Name = @"RecipientCount",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("95fbcf9c-e36d-4acd-8b5a-d657de6e30a8"),
				ModifiedInSchemaUId = new Guid("95fbcf9c-e36d-4acd-8b5a-d657de6e30a8"),
				CreatedInPackageId = new Guid("8ff9fe4f-03be-4db5-b64a-71abfee30f54"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"0"
				}
			};
		}

		protected virtual EntitySchemaColumn CreateLastActualizeDateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("DateTime")) {
				UId = new Guid("da45936d-12c4-44f5-9dbf-93dccfcb27bc"),
				Name = @"LastActualizeDate",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("95fbcf9c-e36d-4acd-8b5a-d657de6e30a8"),
				ModifiedInSchemaUId = new Guid("95fbcf9c-e36d-4acd-8b5a-d657de6e30a8"),
				CreatedInPackageId = new Guid("8ff9fe4f-03be-4db5-b64a-71abfee30f54")
			};
		}

		protected virtual EntitySchemaColumn CreateTemplateSubjectColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("LongText")) {
				UId = new Guid("3e65fbaf-d5dd-431d-a2b9-2badabbaacf5"),
				Name = @"TemplateSubject",
				CreatedInSchemaUId = new Guid("95fbcf9c-e36d-4acd-8b5a-d657de6e30a8"),
				ModifiedInSchemaUId = new Guid("95fbcf9c-e36d-4acd-8b5a-d657de6e30a8"),
				CreatedInPackageId = new Guid("23e6b872-7cf2-4336-8046-3b06c9b28cbc")
			};
		}

		protected virtual EntitySchemaColumn CreateTemplateBodyColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("9ec4de0a-6c4f-4634-b5af-df256380edb7"),
				Name = @"TemplateBody",
				CreatedInSchemaUId = new Guid("95fbcf9c-e36d-4acd-8b5a-d657de6e30a8"),
				ModifiedInSchemaUId = new Guid("95fbcf9c-e36d-4acd-8b5a-d657de6e30a8"),
				CreatedInPackageId = new Guid("f00632d3-aaec-4e50-866a-0cdd26a022a6"),
				IsMultiLineText = true
			};
		}

		protected virtual EntitySchemaColumn CreateDeliveredCountColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("b5ee5edb-5d5b-4438-be3c-ba043ef3f561"),
				Name = @"DeliveredCount",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("95fbcf9c-e36d-4acd-8b5a-d657de6e30a8"),
				ModifiedInSchemaUId = new Guid("95fbcf9c-e36d-4acd-8b5a-d657de6e30a8"),
				CreatedInPackageId = new Guid("2c3183e7-3de0-4a25-b7f0-d9d1c3360565")
			};
		}

		protected virtual EntitySchemaColumn CreateNotDeliveredCountColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("46e0c161-0fd6-4300-9bdd-eb4f68dcbe34"),
				Name = @"NotDeliveredCount",
				IsValueCloneable = false,
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("95fbcf9c-e36d-4acd-8b5a-d657de6e30a8"),
				ModifiedInSchemaUId = new Guid("95fbcf9c-e36d-4acd-8b5a-d657de6e30a8"),
				CreatedInPackageId = new Guid("2c3183e7-3de0-4a25-b7f0-d9d1c3360565")
			};
		}

		protected virtual EntitySchemaColumn CreateInQueueCountColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("d224320e-5b42-4e13-afe3-27eb41d49285"),
				Name = @"InQueueCount",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("95fbcf9c-e36d-4acd-8b5a-d657de6e30a8"),
				ModifiedInSchemaUId = new Guid("95fbcf9c-e36d-4acd-8b5a-d657de6e30a8"),
				CreatedInPackageId = new Guid("2c3183e7-3de0-4a25-b7f0-d9d1c3360565")
			};
		}

		protected virtual EntitySchemaColumn CreateCanceledCountColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("4084cb33-7820-4578-b8b9-87ced0ca3b9d"),
				Name = @"CanceledCount",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("95fbcf9c-e36d-4acd-8b5a-d657de6e30a8"),
				ModifiedInSchemaUId = new Guid("95fbcf9c-e36d-4acd-8b5a-d657de6e30a8"),
				CreatedInPackageId = new Guid("a2630389-bac5-4784-8917-9f3e3f8725d4")
			};
		}

		protected virtual EntitySchemaColumn CreateBlankEmailCountColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("b1896082-56f9-4cf8-aedb-25ff3dfc2727"),
				Name = @"BlankEmailCount",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("95fbcf9c-e36d-4acd-8b5a-d657de6e30a8"),
				ModifiedInSchemaUId = new Guid("95fbcf9c-e36d-4acd-8b5a-d657de6e30a8"),
				CreatedInPackageId = new Guid("c92d8fca-4a0d-4385-86d2-4f5717aa816e")
			};
		}

		protected virtual EntitySchemaColumn CreateIncorrectEmailCountColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("9d65ede6-b98b-455a-821b-90cf0e7cd064"),
				Name = @"IncorrectEmailCount",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("95fbcf9c-e36d-4acd-8b5a-d657de6e30a8"),
				ModifiedInSchemaUId = new Guid("95fbcf9c-e36d-4acd-8b5a-d657de6e30a8"),
				CreatedInPackageId = new Guid("c92d8fca-4a0d-4385-86d2-4f5717aa816e")
			};
		}

		protected virtual EntitySchemaColumn CreateUnreachableEmailCountColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("ca45c924-d210-40ce-9b87-b720a73a3040"),
				Name = @"UnreachableEmailCount",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("95fbcf9c-e36d-4acd-8b5a-d657de6e30a8"),
				ModifiedInSchemaUId = new Guid("95fbcf9c-e36d-4acd-8b5a-d657de6e30a8"),
				CreatedInPackageId = new Guid("c92d8fca-4a0d-4385-86d2-4f5717aa816e")
			};
		}

		protected virtual EntitySchemaColumn CreateDoNotUseEmailCountColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("e2a193cf-9dd4-4246-9d53-49daeadf5892"),
				Name = @"DoNotUseEmailCount",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("95fbcf9c-e36d-4acd-8b5a-d657de6e30a8"),
				ModifiedInSchemaUId = new Guid("95fbcf9c-e36d-4acd-8b5a-d657de6e30a8"),
				CreatedInPackageId = new Guid("c92d8fca-4a0d-4385-86d2-4f5717aa816e")
			};
		}

		protected virtual EntitySchemaColumn CreateDuplicateEmailCountColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("efa2e7d3-8633-4a52-a400-30924f08f0f4"),
				Name = @"DuplicateEmailCount",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("95fbcf9c-e36d-4acd-8b5a-d657de6e30a8"),
				ModifiedInSchemaUId = new Guid("95fbcf9c-e36d-4acd-8b5a-d657de6e30a8"),
				CreatedInPackageId = new Guid("c92d8fca-4a0d-4385-86d2-4f5717aa816e")
			};
		}

		protected virtual EntitySchemaColumn CreateRejectedCountColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("89232498-d4f6-4b83-b20d-2572c1571f85"),
				Name = @"RejectedCount",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("95fbcf9c-e36d-4acd-8b5a-d657de6e30a8"),
				ModifiedInSchemaUId = new Guid("95fbcf9c-e36d-4acd-8b5a-d657de6e30a8"),
				CreatedInPackageId = new Guid("a2630389-bac5-4784-8917-9f3e3f8725d4")
			};
		}

		protected virtual EntitySchemaColumn CreateCommonErrorCountColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("2a285982-5a92-48f1-b639-8479545c4721"),
				Name = @"CommonErrorCount",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("95fbcf9c-e36d-4acd-8b5a-d657de6e30a8"),
				ModifiedInSchemaUId = new Guid("95fbcf9c-e36d-4acd-8b5a-d657de6e30a8"),
				CreatedInPackageId = new Guid("a2630389-bac5-4784-8917-9f3e3f8725d4")
			};
		}

		protected virtual EntitySchemaColumn CreateInvalidAddresseeCountColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("2c1e0609-ac0a-4c38-b860-8f5388f297d7"),
				Name = @"InvalidAddresseeCount",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("95fbcf9c-e36d-4acd-8b5a-d657de6e30a8"),
				ModifiedInSchemaUId = new Guid("95fbcf9c-e36d-4acd-8b5a-d657de6e30a8"),
				CreatedInPackageId = new Guid("a2630389-bac5-4784-8917-9f3e3f8725d4")
			};
		}

		protected virtual EntitySchemaColumn CreatePercentWeightColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float2")) {
				UId = new Guid("eae57226-68ed-4856-8246-c5ec4606529b"),
				Name = @"PercentWeight",
				IsValueCloneable = false,
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("95fbcf9c-e36d-4acd-8b5a-d657de6e30a8"),
				ModifiedInSchemaUId = new Guid("95fbcf9c-e36d-4acd-8b5a-d657de6e30a8"),
				CreatedInPackageId = new Guid("a2630389-bac5-4784-8917-9f3e3f8725d4")
			};
		}

		protected virtual EntitySchemaColumn CreatePercentActiveWeightColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float2")) {
				UId = new Guid("c2a9de1b-9bd4-44bb-b3ac-7d4448d346d0"),
				Name = @"PercentActiveWeight",
				IsValueCloneable = false,
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("95fbcf9c-e36d-4acd-8b5a-d657de6e30a8"),
				ModifiedInSchemaUId = new Guid("95fbcf9c-e36d-4acd-8b5a-d657de6e30a8"),
				CreatedInPackageId = new Guid("a2630389-bac5-4784-8917-9f3e3f8725d4")
			};
		}

		protected virtual EntitySchemaColumn CreatePercentInactiveWeightColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Float2")) {
				UId = new Guid("d785e098-20e4-438e-9a96-ac93fb86a156"),
				Name = @"PercentInactiveWeight",
				IsValueCloneable = false,
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("95fbcf9c-e36d-4acd-8b5a-d657de6e30a8"),
				ModifiedInSchemaUId = new Guid("95fbcf9c-e36d-4acd-8b5a-d657de6e30a8"),
				CreatedInPackageId = new Guid("a2630389-bac5-4784-8917-9f3e3f8725d4")
			};
		}

		protected virtual EntitySchemaColumn CreateSendCountColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("2a905616-fe78-440c-b1fb-d046b98410ee"),
				Name = @"SendCount",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("95fbcf9c-e36d-4acd-8b5a-d657de6e30a8"),
				ModifiedInSchemaUId = new Guid("95fbcf9c-e36d-4acd-8b5a-d657de6e30a8"),
				CreatedInPackageId = new Guid("a2630389-bac5-4784-8917-9f3e3f8725d4")
			};
		}

		protected virtual EntitySchemaColumn CreateCommunicationLimitCountColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("0006f192-a00c-4372-82d8-24df40e8782e"),
				Name = @"CommunicationLimitCount",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("95fbcf9c-e36d-4acd-8b5a-d657de6e30a8"),
				ModifiedInSchemaUId = new Guid("95fbcf9c-e36d-4acd-8b5a-d657de6e30a8"),
				CreatedInPackageId = new Guid("9892593b-d041-45d0-95a7-d3a6e875d1a5")
			};
		}

		protected virtual EntitySchemaColumn CreateUtmSourceColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("LongText")) {
				UId = new Guid("b2d54128-352b-409c-8d9f-864222172044"),
				Name = @"UtmSource",
				CreatedInSchemaUId = new Guid("95fbcf9c-e36d-4acd-8b5a-d657de6e30a8"),
				ModifiedInSchemaUId = new Guid("95fbcf9c-e36d-4acd-8b5a-d657de6e30a8"),
				CreatedInPackageId = new Guid("adf55717-cd89-44d1-9a17-d38a4b5e7c12")
			};
		}

		protected virtual EntitySchemaColumn CreateUtmMediumColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("LongText")) {
				UId = new Guid("545c4f53-5c13-4c18-99b3-12713feafb07"),
				Name = @"UtmMedium",
				CreatedInSchemaUId = new Guid("95fbcf9c-e36d-4acd-8b5a-d657de6e30a8"),
				ModifiedInSchemaUId = new Guid("95fbcf9c-e36d-4acd-8b5a-d657de6e30a8"),
				CreatedInPackageId = new Guid("adf55717-cd89-44d1-9a17-d38a4b5e7c12")
			};
		}

		protected virtual EntitySchemaColumn CreateUtmCampaignColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("LongText")) {
				UId = new Guid("6a54fc79-6db3-495e-8752-c15f3de1371f"),
				Name = @"UtmCampaign",
				CreatedInSchemaUId = new Guid("95fbcf9c-e36d-4acd-8b5a-d657de6e30a8"),
				ModifiedInSchemaUId = new Guid("95fbcf9c-e36d-4acd-8b5a-d657de6e30a8"),
				CreatedInPackageId = new Guid("adf55717-cd89-44d1-9a17-d38a4b5e7c12")
			};
		}

		protected virtual EntitySchemaColumn CreateUtmTermColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("LongText")) {
				UId = new Guid("d145dfd4-03eb-4bd1-ae1a-ec1046c2290c"),
				Name = @"UtmTerm",
				CreatedInSchemaUId = new Guid("95fbcf9c-e36d-4acd-8b5a-d657de6e30a8"),
				ModifiedInSchemaUId = new Guid("95fbcf9c-e36d-4acd-8b5a-d657de6e30a8"),
				CreatedInPackageId = new Guid("adf55717-cd89-44d1-9a17-d38a4b5e7c12")
			};
		}

		protected virtual EntitySchemaColumn CreateUtmContentColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("LongText")) {
				UId = new Guid("c0ecb652-be4e-4e14-91a1-dc17c4eabe25"),
				Name = @"UtmContent",
				CreatedInSchemaUId = new Guid("95fbcf9c-e36d-4acd-8b5a-d657de6e30a8"),
				ModifiedInSchemaUId = new Guid("95fbcf9c-e36d-4acd-8b5a-d657de6e30a8"),
				CreatedInPackageId = new Guid("adf55717-cd89-44d1-9a17-d38a4b5e7c12")
			};
		}

		protected virtual EntitySchemaColumn CreateDomainsColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("LongText")) {
				UId = new Guid("c38d1340-1f04-4106-893b-c123256082ed"),
				Name = @"Domains",
				CreatedInSchemaUId = new Guid("95fbcf9c-e36d-4acd-8b5a-d657de6e30a8"),
				ModifiedInSchemaUId = new Guid("95fbcf9c-e36d-4acd-8b5a-d657de6e30a8"),
				CreatedInPackageId = new Guid("adf55717-cd89-44d1-9a17-d38a4b5e7c12")
			};
		}

		protected virtual EntitySchemaColumn CreateUseUtmColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("71c597c9-94dd-4efe-b2d9-d6989621653a"),
				Name = @"UseUtm",
				CreatedInSchemaUId = new Guid("95fbcf9c-e36d-4acd-8b5a-d657de6e30a8"),
				ModifiedInSchemaUId = new Guid("95fbcf9c-e36d-4acd-8b5a-d657de6e30a8"),
				CreatedInPackageId = new Guid("adf55717-cd89-44d1-9a17-d38a4b5e7c12")
			};
		}

		protected virtual EntitySchemaColumn CreateCampaignColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("6f3b2c62-03a2-4a6a-802b-5c3445e6b534"),
				Name = @"Campaign",
				ReferenceSchemaUId = new Guid("1f9bb71a-eb9c-4220-a40e-9b623eacfec8"),
				IsValueCloneable = false,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("95fbcf9c-e36d-4acd-8b5a-d657de6e30a8"),
				ModifiedInSchemaUId = new Guid("95fbcf9c-e36d-4acd-8b5a-d657de6e30a8"),
				CreatedInPackageId = new Guid("33ac637b-a93c-4dbe-96cf-f1afd79bdc1c")
			};
		}

		protected virtual EntitySchemaColumn CreateStatisticDateColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("DateTime")) {
				UId = new Guid("271d3ef0-6520-479c-8067-5b212d91e534"),
				Name = @"StatisticDate",
				IsValueCloneable = false,
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("95fbcf9c-e36d-4acd-8b5a-d657de6e30a8"),
				ModifiedInSchemaUId = new Guid("95fbcf9c-e36d-4acd-8b5a-d657de6e30a8"),
				CreatedInPackageId = new Guid("a71cf908-541e-4deb-89f8-9de8aba93b8f")
			};
		}

		protected virtual EntitySchemaColumn CreateResponseProcessingCompletedColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("5d100c2f-01b7-4216-9bf7-6bf20af49d30"),
				Name = @"ResponseProcessingCompleted",
				IsValueCloneable = false,
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("95fbcf9c-e36d-4acd-8b5a-d657de6e30a8"),
				ModifiedInSchemaUId = new Guid("95fbcf9c-e36d-4acd-8b5a-d657de6e30a8"),
				CreatedInPackageId = new Guid("196dac4c-8195-4488-a569-0010bfda9cdc")
			};
		}

		protected virtual EntitySchemaColumn CreateSplitTestColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("70e14aa1-d9f5-4b73-b59e-22d5513d3dd8"),
				Name = @"SplitTest",
				ReferenceSchemaUId = new Guid("9682719a-2ac0-47c8-af3a-f988a778988b"),
				IsValueCloneable = false,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("95fbcf9c-e36d-4acd-8b5a-d657de6e30a8"),
				ModifiedInSchemaUId = new Guid("95fbcf9c-e36d-4acd-8b5a-d657de6e30a8"),
				CreatedInPackageId = new Guid("a71cf908-541e-4deb-89f8-9de8aba93b8f")
			};
		}

		protected virtual EntitySchemaColumn CreateCategoryColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("e38eb3e2-20d5-4b11-aa34-c2fe23348070"),
				Name = @"Category",
				ReferenceSchemaUId = new Guid("13cffa88-d296-4202-8bee-d023d51a8454"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("95fbcf9c-e36d-4acd-8b5a-d657de6e30a8"),
				ModifiedInSchemaUId = new Guid("95fbcf9c-e36d-4acd-8b5a-d657de6e30a8"),
				CreatedInPackageId = new Guid("d6fec08a-2746-46b6-a96c-0a31e271957f"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"8cec06ed-2643-46f7-ab00-352acbc3bd8a"
				}
			};
		}

		protected virtual EntitySchemaColumn CreateLaunchOptionColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("c5bf86d5-4624-4470-b6b1-0d3d8755dba1"),
				Name = @"LaunchOption",
				ReferenceSchemaUId = new Guid("03f7cbaa-4ed0-42d8-99ae-724f0b680fe7"),
				IsIndexed = true,
				CreatedInSchemaUId = new Guid("95fbcf9c-e36d-4acd-8b5a-d657de6e30a8"),
				ModifiedInSchemaUId = new Guid("95fbcf9c-e36d-4acd-8b5a-d657de6e30a8"),
				CreatedInPackageId = new Guid("196dac4c-8195-4488-a569-0010bfda9cdc")
			};
		}

		protected virtual EntitySchemaColumn CreateTemplateConfigColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MaxSizeText")) {
				UId = new Guid("167e049c-00ae-41c5-bfc2-856eae2880c9"),
				Name = @"TemplateConfig",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("95fbcf9c-e36d-4acd-8b5a-d657de6e30a8"),
				ModifiedInSchemaUId = new Guid("95fbcf9c-e36d-4acd-8b5a-d657de6e30a8"),
				CreatedInPackageId = new Guid("b7874c9a-6e65-41ca-b21f-5fb1f6a22855")
			};
		}

		protected virtual EntitySchemaColumn CreateDeliveryErrorColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("7030ab07-36cf-4227-8bce-55f97a1e5120"),
				Name = @"DeliveryError",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("95fbcf9c-e36d-4acd-8b5a-d657de6e30a8"),
				ModifiedInSchemaUId = new Guid("95fbcf9c-e36d-4acd-8b5a-d657de6e30a8"),
				CreatedInPackageId = new Guid("fa13654a-18fd-4552-95cb-2194666647a5"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"0"
				}
			};
		}

		protected virtual EntitySchemaColumn CreateIsSystemEmailColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Boolean")) {
				UId = new Guid("467b5d60-a7b3-4cf2-b607-0b77bc504ff9"),
				Name = @"IsSystemEmail",
				CreatedInSchemaUId = new Guid("95fbcf9c-e36d-4acd-8b5a-d657de6e30a8"),
				ModifiedInSchemaUId = new Guid("95fbcf9c-e36d-4acd-8b5a-d657de6e30a8"),
				CreatedInPackageId = new Guid("fa13654a-18fd-4552-95cb-2194666647a5")
			};
		}

		protected virtual EntitySchemaColumn CreateTemplateNotFoundCountColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("f986de1b-eccd-4409-a145-a7ef9d4116c3"),
				Name = @"TemplateNotFoundCount",
				IsValueCloneable = false,
				CreatedInSchemaUId = new Guid("95fbcf9c-e36d-4acd-8b5a-d657de6e30a8"),
				ModifiedInSchemaUId = new Guid("95fbcf9c-e36d-4acd-8b5a-d657de6e30a8"),
				CreatedInPackageId = new Guid("9892593b-d041-45d0-95a7-d3a6e875d1a5")
			};
		}

		protected virtual EntitySchemaColumn CreateSendersDomainNotVerifiedCountColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("1f2d242f-785a-4c0f-9942-6caac23d668a"),
				Name = @"SendersDomainNotVerifiedCount",
				CreatedInSchemaUId = new Guid("95fbcf9c-e36d-4acd-8b5a-d657de6e30a8"),
				ModifiedInSchemaUId = new Guid("95fbcf9c-e36d-4acd-8b5a-d657de6e30a8"),
				CreatedInPackageId = new Guid("9892593b-d041-45d0-95a7-d3a6e875d1a5")
			};
		}

		protected virtual EntitySchemaColumn CreateSendersNameNotValidCountColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("2d960dec-c57c-4412-8667-022cbacf5373"),
				Name = @"SendersNameNotValidCount",
				CreatedInSchemaUId = new Guid("95fbcf9c-e36d-4acd-8b5a-d657de6e30a8"),
				ModifiedInSchemaUId = new Guid("95fbcf9c-e36d-4acd-8b5a-d657de6e30a8"),
				CreatedInPackageId = new Guid("9892593b-d041-45d0-95a7-d3a6e875d1a5")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateBulkEmailEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateBulkEmailEventsProcessSchema() {
			var schema = new BulkEmailEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new BulkEmail(userConnection) {Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnection) {
			return new BulkEmail_MarketingCampaignEventsProcess(userConnection);
		}

		public override object Clone() {
			return new BulkEmailSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new BulkEmailSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("95fbcf9c-e36d-4acd-8b5a-d657de6e30a8"));
		}

		#endregion

	}

	#endregion

	#region Class: BulkEmail

	/// <summary>
	/// Email.
	/// </summary>
	public class BulkEmail : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public BulkEmail(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "BulkEmail";
		}

		public BulkEmail(BulkEmail source)
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

		private BulkEmailType _type;
		/// <summary>
		/// Email type.
		/// </summary>
		public BulkEmailType Type {
			get {
				return _type ??
					(_type = LookupColumnEntities.GetEntity("Type") as BulkEmailType);
			}
		}

		/// <exclude/>
		public Guid StatusId {
			get {
				return GetTypedColumnValue<Guid>("StatusId");
			}
			set {
				SetColumnValue("StatusId", value);
				_status = null;
			}
		}

		/// <exclude/>
		public string StatusName {
			get {
				return GetTypedColumnValue<string>("StatusName");
			}
			set {
				SetColumnValue("StatusName", value);
				if (_status != null) {
					_status.Name = value;
				}
			}
		}

		private BulkEmailStatus _status;
		/// <summary>
		/// Status.
		/// </summary>
		public BulkEmailStatus Status {
			get {
				return _status ??
					(_status = LookupColumnEntities.GetEntity("Status") as BulkEmailStatus);
			}
		}

		/// <summary>
		/// Start.
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
		/// Sender's name.
		/// </summary>
		public string SenderName {
			get {
				return GetTypedColumnValue<string>("SenderName");
			}
			set {
				SetColumnValue("SenderName", value);
			}
		}

		/// <summary>
		/// Sender's email.
		/// </summary>
		public string SenderEmail {
			get {
				return GetTypedColumnValue<string>("SenderEmail");
			}
			set {
				SetColumnValue("SenderEmail", value);
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
		/// Started on.
		/// </summary>
		public DateTime SendStartDate {
			get {
				return GetTypedColumnValue<DateTime>("SendStartDate");
			}
			set {
				SetColumnValue("SendStartDate", value);
			}
		}

		/// <summary>
		/// Finished on.
		/// </summary>
		public DateTime SendDueDate {
			get {
				return GetTypedColumnValue<DateTime>("SendDueDate");
			}
			set {
				SetColumnValue("SendDueDate", value);
			}
		}

		/// <summary>
		/// Click rate, %.
		/// </summary>
		public Decimal Clicks {
			get {
				return GetTypedColumnValue<Decimal>("Clicks");
			}
			set {
				SetColumnValue("Clicks", value);
			}
		}

		/// <summary>
		/// Open rate, %.
		/// </summary>
		public Decimal Opens {
			get {
				return GetTypedColumnValue<Decimal>("Opens");
			}
			set {
				SetColumnValue("Opens", value);
			}
		}

		/// <summary>
		/// Soft Bounce, %.
		/// </summary>
		public Decimal SoftBounce {
			get {
				return GetTypedColumnValue<Decimal>("SoftBounce");
			}
			set {
				SetColumnValue("SoftBounce", value);
			}
		}

		/// <summary>
		/// Hard Bounce, %.
		/// </summary>
		public Decimal HardBounce {
			get {
				return GetTypedColumnValue<Decimal>("HardBounce");
			}
			set {
				SetColumnValue("HardBounce", value);
			}
		}

		/// <summary>
		/// Unsubscribe rate, %.
		/// </summary>
		public Decimal Unsubscribe {
			get {
				return GetTypedColumnValue<Decimal>("Unsubscribe");
			}
			set {
				SetColumnValue("Unsubscribe", value);
			}
		}

		/// <summary>
		/// Spam rate, %.
		/// </summary>
		public Decimal Spam {
			get {
				return GetTypedColumnValue<Decimal>("Spam");
			}
			set {
				SetColumnValue("Spam", value);
			}
		}

		/// <summary>
		/// Number of clicks.
		/// </summary>
		public int ClicksCount {
			get {
				return GetTypedColumnValue<int>("ClicksCount");
			}
			set {
				SetColumnValue("ClicksCount", value);
			}
		}

		/// <summary>
		/// No. of opens.
		/// </summary>
		public int OpensCount {
			get {
				return GetTypedColumnValue<int>("OpensCount");
			}
			set {
				SetColumnValue("OpensCount", value);
			}
		}

		/// <summary>
		/// No. of "Soft bounce".
		/// </summary>
		public int SoftBounceCount {
			get {
				return GetTypedColumnValue<int>("SoftBounceCount");
			}
			set {
				SetColumnValue("SoftBounceCount", value);
			}
		}

		/// <summary>
		/// No. of "Hard bounce".
		/// </summary>
		public int HardBounceCount {
			get {
				return GetTypedColumnValue<int>("HardBounceCount");
			}
			set {
				SetColumnValue("HardBounceCount", value);
			}
		}

		/// <summary>
		/// No. of unsubscribes.
		/// </summary>
		public int UnsubscribeCount {
			get {
				return GetTypedColumnValue<int>("UnsubscribeCount");
			}
			set {
				SetColumnValue("UnsubscribeCount", value);
			}
		}

		/// <summary>
		/// No. of spam complaints.
		/// </summary>
		public int SpamCount {
			get {
				return GetTypedColumnValue<int>("SpamCount");
			}
			set {
				SetColumnValue("SpamCount", value);
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
		/// Recipients.
		/// </summary>
		public int RecipientCount {
			get {
				return GetTypedColumnValue<int>("RecipientCount");
			}
			set {
				SetColumnValue("RecipientCount", value);
			}
		}

		/// <summary>
		/// Last updated on.
		/// </summary>
		public DateTime LastActualizeDate {
			get {
				return GetTypedColumnValue<DateTime>("LastActualizeDate");
			}
			set {
				SetColumnValue("LastActualizeDate", value);
			}
		}

		/// <summary>
		/// Subject.
		/// </summary>
		public string TemplateSubject {
			get {
				return GetTypedColumnValue<string>("TemplateSubject");
			}
			set {
				SetColumnValue("TemplateSubject", value);
			}
		}

		/// <summary>
		/// Template text.
		/// </summary>
		public string TemplateBody {
			get {
				return GetTypedColumnValue<string>("TemplateBody");
			}
			set {
				SetColumnValue("TemplateBody", value);
			}
		}

		/// <summary>
		/// Delivered.
		/// </summary>
		public int DeliveredCount {
			get {
				return GetTypedColumnValue<int>("DeliveredCount");
			}
			set {
				SetColumnValue("DeliveredCount", value);
			}
		}

		/// <summary>
		/// Not delivered.
		/// </summary>
		public int NotDeliveredCount {
			get {
				return GetTypedColumnValue<int>("NotDeliveredCount");
			}
			set {
				SetColumnValue("NotDeliveredCount", value);
			}
		}

		/// <summary>
		/// Queued.
		/// </summary>
		public int InQueueCount {
			get {
				return GetTypedColumnValue<int>("InQueueCount");
			}
			set {
				SetColumnValue("InQueueCount", value);
			}
		}

		/// <summary>
		/// No. of cancels.
		/// </summary>
		public int CanceledCount {
			get {
				return GetTypedColumnValue<int>("CanceledCount");
			}
			set {
				SetColumnValue("CanceledCount", value);
			}
		}

		/// <summary>
		/// Blank email.
		/// </summary>
		public int BlankEmailCount {
			get {
				return GetTypedColumnValue<int>("BlankEmailCount");
			}
			set {
				SetColumnValue("BlankEmailCount", value);
			}
		}

		/// <summary>
		/// Incorrect email.
		/// </summary>
		public int IncorrectEmailCount {
			get {
				return GetTypedColumnValue<int>("IncorrectEmailCount");
			}
			set {
				SetColumnValue("IncorrectEmailCount", value);
			}
		}

		/// <summary>
		/// Unreachable email.
		/// </summary>
		public int UnreachableEmailCount {
			get {
				return GetTypedColumnValue<int>("UnreachableEmailCount");
			}
			set {
				SetColumnValue("UnreachableEmailCount", value);
			}
		}

		/// <summary>
		/// Do not use email.
		/// </summary>
		public int DoNotUseEmailCount {
			get {
				return GetTypedColumnValue<int>("DoNotUseEmailCount");
			}
			set {
				SetColumnValue("DoNotUseEmailCount", value);
			}
		}

		/// <summary>
		/// Duplicate email.
		/// </summary>
		public int DuplicateEmailCount {
			get {
				return GetTypedColumnValue<int>("DuplicateEmailCount");
			}
			set {
				SetColumnValue("DuplicateEmailCount", value);
			}
		}

		/// <summary>
		/// No. of rejects.
		/// </summary>
		public int RejectedCount {
			get {
				return GetTypedColumnValue<int>("RejectedCount");
			}
			set {
				SetColumnValue("RejectedCount", value);
			}
		}

		/// <summary>
		/// No. of general request errors.
		/// </summary>
		public int CommonErrorCount {
			get {
				return GetTypedColumnValue<int>("CommonErrorCount");
			}
			set {
				SetColumnValue("CommonErrorCount", value);
			}
		}

		/// <summary>
		/// No. of invalid email addresses.
		/// </summary>
		public int InvalidAddresseeCount {
			get {
				return GetTypedColumnValue<int>("InvalidAddresseeCount");
			}
			set {
				SetColumnValue("InvalidAddresseeCount", value);
			}
		}

		/// <summary>
		/// PercentWeight.
		/// </summary>
		public Decimal PercentWeight {
			get {
				return GetTypedColumnValue<Decimal>("PercentWeight");
			}
			set {
				SetColumnValue("PercentWeight", value);
			}
		}

		/// <summary>
		/// PercentActiveWeight.
		/// </summary>
		public Decimal PercentActiveWeight {
			get {
				return GetTypedColumnValue<Decimal>("PercentActiveWeight");
			}
			set {
				SetColumnValue("PercentActiveWeight", value);
			}
		}

		/// <summary>
		/// PercentInactiveWeight.
		/// </summary>
		public Decimal PercentInactiveWeight {
			get {
				return GetTypedColumnValue<Decimal>("PercentInactiveWeight");
			}
			set {
				SetColumnValue("PercentInactiveWeight", value);
			}
		}

		/// <summary>
		/// Sent count.
		/// </summary>
		public int SendCount {
			get {
				return GetTypedColumnValue<int>("SendCount");
			}
			set {
				SetColumnValue("SendCount", value);
			}
		}

		/// <summary>
		/// Cancelled (communication limit).
		/// </summary>
		public int CommunicationLimitCount {
			get {
				return GetTypedColumnValue<int>("CommunicationLimitCount");
			}
			set {
				SetColumnValue("CommunicationLimitCount", value);
			}
		}

		/// <summary>
		/// utm_source.
		/// </summary>
		public string UtmSource {
			get {
				return GetTypedColumnValue<string>("UtmSource");
			}
			set {
				SetColumnValue("UtmSource", value);
			}
		}

		/// <summary>
		/// utm_medium.
		/// </summary>
		public string UtmMedium {
			get {
				return GetTypedColumnValue<string>("UtmMedium");
			}
			set {
				SetColumnValue("UtmMedium", value);
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
		/// utm_term.
		/// </summary>
		public string UtmTerm {
			get {
				return GetTypedColumnValue<string>("UtmTerm");
			}
			set {
				SetColumnValue("UtmTerm", value);
			}
		}

		/// <summary>
		/// utm_content.
		/// </summary>
		public string UtmContent {
			get {
				return GetTypedColumnValue<string>("UtmContent");
			}
			set {
				SetColumnValue("UtmContent", value);
			}
		}

		/// <summary>
		/// List of domains.
		/// </summary>
		public string Domains {
			get {
				return GetTypedColumnValue<string>("Domains");
			}
			set {
				SetColumnValue("Domains", value);
			}
		}

		/// <summary>
		/// Use UTM tracking codes.
		/// </summary>
		public bool UseUtm {
			get {
				return GetTypedColumnValue<bool>("UseUtm");
			}
			set {
				SetColumnValue("UseUtm", value);
			}
		}

		/// <exclude/>
		public Guid CampaignId {
			get {
				return GetTypedColumnValue<Guid>("CampaignId");
			}
			set {
				SetColumnValue("CampaignId", value);
				_campaign = null;
			}
		}

		/// <exclude/>
		public string CampaignName {
			get {
				return GetTypedColumnValue<string>("CampaignName");
			}
			set {
				SetColumnValue("CampaignName", value);
				if (_campaign != null) {
					_campaign.Name = value;
				}
			}
		}

		private Campaign _campaign;
		/// <summary>
		/// Campaign.
		/// </summary>
		public Campaign Campaign {
			get {
				return _campaign ??
					(_campaign = LookupColumnEntities.GetEntity("Campaign") as Campaign);
			}
		}

		/// <summary>
		/// StatisticDate.
		/// </summary>
		public DateTime StatisticDate {
			get {
				return GetTypedColumnValue<DateTime>("StatisticDate");
			}
			set {
				SetColumnValue("StatisticDate", value);
			}
		}

		/// <summary>
		/// Click handling complete.
		/// </summary>
		public bool ResponseProcessingCompleted {
			get {
				return GetTypedColumnValue<bool>("ResponseProcessingCompleted");
			}
			set {
				SetColumnValue("ResponseProcessingCompleted", value);
			}
		}

		/// <exclude/>
		public Guid SplitTestId {
			get {
				return GetTypedColumnValue<Guid>("SplitTestId");
			}
			set {
				SetColumnValue("SplitTestId", value);
				_splitTest = null;
			}
		}

		/// <exclude/>
		public string SplitTestName {
			get {
				return GetTypedColumnValue<string>("SplitTestName");
			}
			set {
				SetColumnValue("SplitTestName", value);
				if (_splitTest != null) {
					_splitTest.Name = value;
				}
			}
		}

		private BulkEmailSplit _splitTest;
		/// <summary>
		/// Split test.
		/// </summary>
		public BulkEmailSplit SplitTest {
			get {
				return _splitTest ??
					(_splitTest = LookupColumnEntities.GetEntity("SplitTest") as BulkEmailSplit);
			}
		}

		/// <exclude/>
		public Guid CategoryId {
			get {
				return GetTypedColumnValue<Guid>("CategoryId");
			}
			set {
				SetColumnValue("CategoryId", value);
				_category = null;
			}
		}

		/// <exclude/>
		public string CategoryName {
			get {
				return GetTypedColumnValue<string>("CategoryName");
			}
			set {
				SetColumnValue("CategoryName", value);
				if (_category != null) {
					_category.Name = value;
				}
			}
		}

		private BulkEmailCategory _category;
		/// <summary>
		/// Category.
		/// </summary>
		public BulkEmailCategory Category {
			get {
				return _category ??
					(_category = LookupColumnEntities.GetEntity("Category") as BulkEmailCategory);
			}
		}

		/// <exclude/>
		public Guid LaunchOptionId {
			get {
				return GetTypedColumnValue<Guid>("LaunchOptionId");
			}
			set {
				SetColumnValue("LaunchOptionId", value);
				_launchOption = null;
			}
		}

		/// <exclude/>
		public string LaunchOptionName {
			get {
				return GetTypedColumnValue<string>("LaunchOptionName");
			}
			set {
				SetColumnValue("LaunchOptionName", value);
				if (_launchOption != null) {
					_launchOption.Name = value;
				}
			}
		}

		private BulkEmailLaunchOption _launchOption;
		/// <summary>
		/// Start mode.
		/// </summary>
		public BulkEmailLaunchOption LaunchOption {
			get {
				return _launchOption ??
					(_launchOption = LookupColumnEntities.GetEntity("LaunchOption") as BulkEmailLaunchOption);
			}
		}

		/// <summary>
		/// Template config.
		/// </summary>
		public string TemplateConfig {
			get {
				return GetTypedColumnValue<string>("TemplateConfig");
			}
			set {
				SetColumnValue("TemplateConfig", value);
			}
		}

		/// <summary>
		/// Delivery errors count.
		/// </summary>
		public int DeliveryError {
			get {
				return GetTypedColumnValue<int>("DeliveryError");
			}
			set {
				SetColumnValue("DeliveryError", value);
			}
		}

		/// <summary>
		/// System email.
		/// </summary>
		public bool IsSystemEmail {
			get {
				return GetTypedColumnValue<bool>("IsSystemEmail");
			}
			set {
				SetColumnValue("IsSystemEmail", value);
			}
		}

		/// <summary>
		/// Template not found.
		/// </summary>
		public int TemplateNotFoundCount {
			get {
				return GetTypedColumnValue<int>("TemplateNotFoundCount");
			}
			set {
				SetColumnValue("TemplateNotFoundCount", value);
			}
		}

		/// <summary>
		/// Sender's domain is not verified.
		/// </summary>
		public int SendersDomainNotVerifiedCount {
			get {
				return GetTypedColumnValue<int>("SendersDomainNotVerifiedCount");
			}
			set {
				SetColumnValue("SendersDomainNotVerifiedCount", value);
			}
		}

		/// <summary>
		/// Sender's name is not valid.
		/// </summary>
		public int SendersNameNotValidCount {
			get {
				return GetTypedColumnValue<int>("SendersNameNotValidCount");
			}
			set {
				SetColumnValue("SendersNameNotValidCount", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new BulkEmail_MarketingCampaignEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("BulkEmailDeleted", e);
			Deleting += (s, e) => ThrowEvent("BulkEmailDeleting", e);
			Inserting += (s, e) => ThrowEvent("BulkEmailInserting", e);
			Saved += (s, e) => ThrowEvent("BulkEmailSaved", e);
			Saving += (s, e) => ThrowEvent("BulkEmailSaving", e);
			Validating += (s, e) => ThrowEvent("BulkEmailValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new BulkEmail(this);
		}

		#endregion

	}

	#endregion

	#region Class: BulkEmail_MarketingCampaignEventsProcess

	/// <exclude/>
	public class BulkEmail_MarketingCampaignEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_LocalMessageEventsProcess<TEntity> where TEntity : BulkEmail
	{

		public BulkEmail_MarketingCampaignEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "BulkEmail_MarketingCampaignEventsProcess";
			SchemaUId = new Guid("95fbcf9c-e36d-4acd-8b5a-d657de6e30a8");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("95fbcf9c-e36d-4acd-8b5a-d657de6e30a8");
			}
		}

		#endregion

		#region Properties: Public

		public override string InstanceUId {
			get {
				return Entity.InstanceUId.ToString();
			}
		}

		public virtual bool IsTemplateBodyChanged {
			get;
			set;
		}

		public virtual int EntityRId {
			get;
			set;
		}

		public virtual bool IsCopy {
			get;
			set;
		}

		public virtual Guid SourceBulkEmailId {
			get;
			set;
		}

		private ProcessFlowElement _bulkEmailInsertingStartMessageEventSubProcess;
		public ProcessFlowElement BulkEmailInsertingStartMessageEventSubProcess {
			get {
				return _bulkEmailInsertingStartMessageEventSubProcess ?? (_bulkEmailInsertingStartMessageEventSubProcess = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "BulkEmailInsertingStartMessageEventSubProcess",
					SchemaElementUId = new Guid("bfa3f852-95e0-43b6-a88e-0d4e0a14cce7"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _bulkEmailInsertingStartMessageScriptTask;
		public ProcessScriptTask BulkEmailInsertingStartMessageScriptTask {
			get {
				return _bulkEmailInsertingStartMessageScriptTask ?? (_bulkEmailInsertingStartMessageScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "BulkEmailInsertingStartMessageScriptTask",
					SchemaElementUId = new Guid("909f355c-72fa-4512-9198-1dd649b4be2f"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = BulkEmailInsertingStartMessageScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _bulkEmailInsertingStartMessage;
		public ProcessFlowElement BulkEmailInsertingStartMessage {
			get {
				return _bulkEmailInsertingStartMessage ?? (_bulkEmailInsertingStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "BulkEmailInsertingStartMessage",
					SchemaElementUId = new Guid("77eef246-adde-4746-baa0-8c43f45c9e91"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _eventSubProcess1;
		public ProcessFlowElement EventSubProcess1 {
			get {
				return _eventSubProcess1 ?? (_eventSubProcess1 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess1",
					SchemaElementUId = new Guid("1c17b7d0-53cd-4e1e-80a0-d273013bcf78"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _bulkEmailSavedStartMessage;
		public ProcessFlowElement BulkEmailSavedStartMessage {
			get {
				return _bulkEmailSavedStartMessage ?? (_bulkEmailSavedStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "BulkEmailSavedStartMessage",
					SchemaElementUId = new Guid("3efa3683-63a7-433a-a91a-f91b30902d67"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _bulkEmailSavedScriptTask;
		public ProcessScriptTask BulkEmailSavedScriptTask {
			get {
				return _bulkEmailSavedScriptTask ?? (_bulkEmailSavedScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "BulkEmailSavedScriptTask",
					SchemaElementUId = new Guid("ac808fe5-89f8-4089-b4c0-a1fa19a956b3"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = BulkEmailSavedScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcess2;
		public ProcessFlowElement EventSubProcess2 {
			get {
				return _eventSubProcess2 ?? (_eventSubProcess2 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess2",
					SchemaElementUId = new Guid("5384c573-e924-43fc-8f5b-a2f33ed87318"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _bulkEmailSavingStartMessage;
		public ProcessFlowElement BulkEmailSavingStartMessage {
			get {
				return _bulkEmailSavingStartMessage ?? (_bulkEmailSavingStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "BulkEmailSavingStartMessage",
					SchemaElementUId = new Guid("aa6911e5-eb04-4e0c-bb09-6a49b788d31d"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _bulkEmailSavingScriptTask;
		public ProcessScriptTask BulkEmailSavingScriptTask {
			get {
				return _bulkEmailSavingScriptTask ?? (_bulkEmailSavingScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "BulkEmailSavingScriptTask",
					SchemaElementUId = new Guid("1435242c-1d2d-493f-be0c-09a3f08257a3"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = BulkEmailSavingScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcess3;
		public ProcessFlowElement EventSubProcess3 {
			get {
				return _eventSubProcess3 ?? (_eventSubProcess3 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess3",
					SchemaElementUId = new Guid("ceff2bdf-c695-472c-a1b4-626707842379"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _bulkEmailDeletedStartMessage;
		public ProcessFlowElement BulkEmailDeletedStartMessage {
			get {
				return _bulkEmailDeletedStartMessage ?? (_bulkEmailDeletedStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "BulkEmailDeletedStartMessage",
					SchemaElementUId = new Guid("683c8b5a-dc29-4f59-b24f-bd9ee357c840"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _bulkEmailDeletedScriptTask;
		public ProcessScriptTask BulkEmailDeletedScriptTask {
			get {
				return _bulkEmailDeletedScriptTask ?? (_bulkEmailDeletedScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "BulkEmailDeletedScriptTask",
					SchemaElementUId = new Guid("597a6100-6597-4b98-b5d0-e8976a8a06d2"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = BulkEmailDeletedScriptTaskExecute,
				});
			}
		}

		private ProcessFlowElement _eventSubProcess4;
		public ProcessFlowElement EventSubProcess4 {
			get {
				return _eventSubProcess4 ?? (_eventSubProcess4 = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaEventSubProcess",
					Name = "EventSubProcess4",
					SchemaElementUId = new Guid("eda2b2b0-bed7-44bc-aff7-22561620ddc9"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessFlowElement _bulkEmailDeletingStartMessage;
		public ProcessFlowElement BulkEmailDeletingStartMessage {
			get {
				return _bulkEmailDeletingStartMessage ?? (_bulkEmailDeletingStartMessage = new ProcessFlowElement() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaStartMessageEvent",
					Name = "BulkEmailDeletingStartMessage",
					SchemaElementUId = new Guid("d3103f32-ca32-4bb5-92b0-44317f62b35e"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
				});
			}
		}

		private ProcessScriptTask _bulkEmailDeletingStartMessageScriptTask;
		public ProcessScriptTask BulkEmailDeletingStartMessageScriptTask {
			get {
				return _bulkEmailDeletingStartMessageScriptTask ?? (_bulkEmailDeletingStartMessageScriptTask = new ProcessScriptTask() {
					UId = Guid.NewGuid(),
					Owner = this,
					Type = "ProcessSchemaScriptTask",
					Name = "BulkEmailDeletingStartMessageScriptTask",
					SchemaElementUId = new Guid("0ff3235e-52ab-45fd-a817-ad2bfb182c07"),
					CreatedInSchemaUId = InternalSchemaUId,
					ExecutedEventHandler = OnExecuted,
						Script = BulkEmailDeletingStartMessageScriptTaskExecute,
				});
			}
		}

		#endregion

		#region Methods: Private

		private void InitializeFlowElements() {
			FlowElements[BulkEmailInsertingStartMessageEventSubProcess.SchemaElementUId] = new Collection<ProcessFlowElement> { BulkEmailInsertingStartMessageEventSubProcess };
			FlowElements[BulkEmailInsertingStartMessageScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { BulkEmailInsertingStartMessageScriptTask };
			FlowElements[BulkEmailInsertingStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { BulkEmailInsertingStartMessage };
			FlowElements[EventSubProcess1.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess1 };
			FlowElements[BulkEmailSavedStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { BulkEmailSavedStartMessage };
			FlowElements[BulkEmailSavedScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { BulkEmailSavedScriptTask };
			FlowElements[EventSubProcess2.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess2 };
			FlowElements[BulkEmailSavingStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { BulkEmailSavingStartMessage };
			FlowElements[BulkEmailSavingScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { BulkEmailSavingScriptTask };
			FlowElements[EventSubProcess3.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess3 };
			FlowElements[BulkEmailDeletedStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { BulkEmailDeletedStartMessage };
			FlowElements[BulkEmailDeletedScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { BulkEmailDeletedScriptTask };
			FlowElements[EventSubProcess4.SchemaElementUId] = new Collection<ProcessFlowElement> { EventSubProcess4 };
			FlowElements[BulkEmailDeletingStartMessage.SchemaElementUId] = new Collection<ProcessFlowElement> { BulkEmailDeletingStartMessage };
			FlowElements[BulkEmailDeletingStartMessageScriptTask.SchemaElementUId] = new Collection<ProcessFlowElement> { BulkEmailDeletingStartMessageScriptTask };
		}

		private void OnExecuted(object sender, ProcessActivityAfterEventArgs e) {
			switch (e.Context.SenderName) {
					case "BulkEmailInsertingStartMessageEventSubProcess":
						break;
					case "BulkEmailInsertingStartMessageScriptTask":
						break;
					case "BulkEmailInsertingStartMessage":
						e.Context.QueueTasks.Enqueue("BulkEmailInsertingStartMessageScriptTask");
						break;
					case "EventSubProcess1":
						break;
					case "BulkEmailSavedStartMessage":
						e.Context.QueueTasks.Enqueue("BulkEmailSavedScriptTask");
						break;
					case "BulkEmailSavedScriptTask":
						break;
					case "EventSubProcess2":
						break;
					case "BulkEmailSavingStartMessage":
						e.Context.QueueTasks.Enqueue("BulkEmailSavingScriptTask");
						break;
					case "BulkEmailSavingScriptTask":
						break;
					case "EventSubProcess3":
						break;
					case "BulkEmailDeletedStartMessage":
						e.Context.QueueTasks.Enqueue("BulkEmailDeletedScriptTask");
						break;
					case "BulkEmailDeletedScriptTask":
						break;
					case "EventSubProcess4":
						break;
					case "BulkEmailDeletingStartMessage":
						e.Context.QueueTasks.Enqueue("BulkEmailDeletingStartMessageScriptTask");
						break;
					case "BulkEmailDeletingStartMessageScriptTask":
						break;
			}
			ProcessQueue(e.Context);
		}

		#endregion

		#region Methods: Protected

		protected override void PrepareStart(ProcessExecutingContext context) {
			base.PrepareStart(context);
			context.Process = this;
			ActivatedEventElements.Add("BulkEmailInsertingStartMessage");
			ActivatedEventElements.Add("BulkEmailSavedStartMessage");
			ActivatedEventElements.Add("BulkEmailSavingStartMessage");
			ActivatedEventElements.Add("BulkEmailDeletedStartMessage");
			ActivatedEventElements.Add("BulkEmailDeletingStartMessage");
		}

		protected override bool ProcessQueue(ProcessExecutingContext context) {
			bool result = base.ProcessQueue(context);
			if (context.QueueTasks.Count == 0) {
				return result;
			}
			switch (context.QueueTasks.Peek()) {
				case "BulkEmailInsertingStartMessageEventSubProcess":
					context.QueueTasks.Dequeue();
					break;
				case "BulkEmailInsertingStartMessageScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "BulkEmailInsertingStartMessageScriptTask";
					result = BulkEmailInsertingStartMessageScriptTask.Execute(context, BulkEmailInsertingStartMessageScriptTaskExecute);
					break;
				case "BulkEmailInsertingStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "BulkEmailInsertingStartMessage";
					result = BulkEmailInsertingStartMessage.Execute(context);
					break;
				case "EventSubProcess1":
					context.QueueTasks.Dequeue();
					break;
				case "BulkEmailSavedStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "BulkEmailSavedStartMessage";
					result = BulkEmailSavedStartMessage.Execute(context);
					break;
				case "BulkEmailSavedScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "BulkEmailSavedScriptTask";
					result = BulkEmailSavedScriptTask.Execute(context, BulkEmailSavedScriptTaskExecute);
					break;
				case "EventSubProcess2":
					context.QueueTasks.Dequeue();
					break;
				case "BulkEmailSavingStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "BulkEmailSavingStartMessage";
					result = BulkEmailSavingStartMessage.Execute(context);
					break;
				case "BulkEmailSavingScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "BulkEmailSavingScriptTask";
					result = BulkEmailSavingScriptTask.Execute(context, BulkEmailSavingScriptTaskExecute);
					break;
				case "EventSubProcess3":
					context.QueueTasks.Dequeue();
					break;
				case "BulkEmailDeletedStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "BulkEmailDeletedStartMessage";
					result = BulkEmailDeletedStartMessage.Execute(context);
					break;
				case "BulkEmailDeletedScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "BulkEmailDeletedScriptTask";
					result = BulkEmailDeletedScriptTask.Execute(context, BulkEmailDeletedScriptTaskExecute);
					break;
				case "EventSubProcess4":
					context.QueueTasks.Dequeue();
					break;
				case "BulkEmailDeletingStartMessage":
					context.QueueTasks.Dequeue();
					context.SenderName = "BulkEmailDeletingStartMessage";
					result = BulkEmailDeletingStartMessage.Execute(context);
					break;
				case "BulkEmailDeletingStartMessageScriptTask":
					context.QueueTasks.Dequeue();
					context.SenderName = "BulkEmailDeletingStartMessageScriptTask";
					result = BulkEmailDeletingStartMessageScriptTask.Execute(context, BulkEmailDeletingStartMessageScriptTaskExecute);
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
				case "SourceBulkEmailId":
					SourceBulkEmailId = reader.GetValue<System.Guid>();
				break;
				case "IsCopy":
					IsCopy = reader.GetValue<System.Boolean>();
				break;
				case "EntityRId":
					EntityRId = reader.GetValue<System.Int32>();
				break;
				case "IsTemplateBodyChanged":
					IsTemplateBodyChanged = reader.GetValue<System.Boolean>();
				break;
			}
		}

		#endregion

		#region Methods: Public

		public virtual bool BulkEmailInsertingStartMessageScriptTaskExecute(ProcessExecutingContext context) {
			BulkEmailInserting();
			return true;
		}

		public virtual bool BulkEmailSavedScriptTaskExecute(ProcessExecutingContext context) {
			BulkEmailSaved();
			return true;
		}

		public virtual bool BulkEmailSavingScriptTaskExecute(ProcessExecutingContext context) {
			var bulkEmailId = Entity.GetTypedColumnValue<Guid>("Id");
			var oldBulkEmailId = Entity.GetTypedOldColumnValue<Guid>("Id");
			IsCopy = bulkEmailId != oldBulkEmailId;
			SourceBulkEmailId = IsCopy ? oldBulkEmailId : default(Guid);
			var templateBody = Entity.GetTypedColumnValue<string>("TemplateBody");
			var oldTemplateBody = Entity.GetTypedOldColumnValue<string>("TemplateBody");
			IsTemplateBodyChanged = !templateBody.Equals(oldTemplateBody, StringComparison.OrdinalIgnoreCase);
			if (IsCopy) {
				SetBulkEmailStatus();
			}
			return true;
		}

		public virtual bool BulkEmailDeletedScriptTaskExecute(ProcessExecutingContext context) {
			BulkEmailDeleted();
			return true;
		}

		public virtual bool BulkEmailDeletingStartMessageScriptTaskExecute(ProcessExecutingContext context) {
			BulkEmailDeleting();
			return true;
		}

		public virtual void BulkEmailInserting() {
			if (!Entity.GetIsColumnValueLoaded("CategoryId") ||
				(!Entity.GetIsColumnValueLoaded("LaunchOptionId") || !Entity.LaunchOptionId.IsEmpty())) {
				return;
			}
			
			if(Entity.CategoryId == MarketingConsts.MassmailingBulkEmailCategoryId) {
				Entity.SetColumnValue("LaunchOptionId", MarketingConsts.BulkEmailManaulLaunchOptionId);
			} 
			
			if(Entity.CategoryId == MarketingConsts.TriggeredEmailBulkEmailCategoryId) {
				Entity.SetColumnValue("LaunchOptionId", MarketingConsts.TriggerEmailScheduledLaunchOptionId);
				Entity.SetColumnValue("StartDate", DateTime.UtcNow.AddMinutes(15));
			}
		}

		public virtual void BulkEmailSaved() {
			var isDCFeatureEnabled = UserConnection.GetIsFeatureEnabled("BulkEmailDynamicContentBuilder");
			if (isDCFeatureEnabled && IsCopy && SourceBulkEmailId.IsNotEmpty()) {
				var hasTemplateSource = HasTemplate(SourceBulkEmailId);
				if (hasTemplateSource) {
					CopyBulkEmailTemplate();
				} else {
					CopyBulkEmailWithoutTemplate();
				}
			}
			if (!isDCFeatureEnabled && (IsCopy || IsTemplateBodyChanged)) {
				CopyBulkEmailWithoutTemplate();
			}
		}

		public virtual void BulkEmailDeleted() {
			var isDCFeatureEnabled = UserConnection.GetIsFeatureEnabled("BulkEmailDynamicContentBuilder");
			if (Entity.GetIsColumnValueLoaded("StatusId") && EntityRId > 0) {
				Guid statusColumnValue = Entity.GetTypedColumnValue<Guid>("StatusId");
				if(statusColumnValue == MarketingConsts.BulkEmailStatusPlannedId) {
					var delete = new Delete(UserConnection)
							.From("MandrillRecipient")
							.Where("BulkEmailRId").IsEqual(Column.Parameter(EntityRId));
					delete.Execute();
				}
			}
			if (isDCFeatureEnabled) {
				DeleteBulkEmailTemplate();
			}
		}

		public virtual int GetBulkEmailRId(Guid bulkEmailId) {
			var select = new Select(UserConnection)
				.Column("RId")
				.From("BulkEmail")
				.Where("Id").IsEqual(Column.Parameter(bulkEmailId)) as Select;
			return select.ExecuteScalar<int>();
		}

		public virtual void BulkEmailDeleting() {
			EntityRId = GetBulkEmailRId(Entity.Id);
		}

		public virtual void CopyBulkEmailTemplate() {
			var templateRepository = new DCTemplateRepository<DCTemplateModel>(UserConnection);
			var repositoryReadOptions = new DCRepositoryReadOptions<DCTemplateModel, DCReplicaModel> {
				TemplateReadOptions = DCTemplateReadOption.ExcludeAttributes
					| DCTemplateReadOption.ExcludeReplicaHtmlContent
			};
			var existingTemplate = templateRepository.ReadByRecordId(SourceBulkEmailId, repositoryReadOptions);
			if (existingTemplate != null && existingTemplate.Id.IsNotEmpty()) {
				var templateCopyId = templateRepository.Copy(existingTemplate.Id);
				LinkTemplateWithBulkEmail(templateCopyId);
				CopyHyperlinks();
				CopyHeaders();
			}
		}

		public virtual void LinkTemplateWithBulkEmail(Guid templateCopyId) {
			if (templateCopyId.IsNotEmpty()) {
				var bulkEmailId = Entity.GetTypedColumnValue<Guid>("Id");
				var templateEntitySchema = UserConnection.EntitySchemaManager.GetInstanceByName(nameof(DCTemplate));
				var templateEntity = templateEntitySchema.CreateEntity(UserConnection);
				if (templateEntity.FetchFromDB(templateCopyId)) {
					templateEntity.SetColumnValue("RecordId", bulkEmailId);
					templateEntity.Save();
				}
			}
		}

		public virtual void DeleteBulkEmailTemplate() {
			var bulkEmailId = Entity.GetTypedColumnValue<Guid>("Id");
			var templateRepository = new DCTemplateRepository<DCTemplateModel>(UserConnection);
			var repositoryReadOptions = new DCRepositoryReadOptions<DCTemplateModel, DCReplicaModel> {
				TemplateReadOptions = DCTemplateReadOption.ExcludeAttributes
					| DCTemplateReadOption.ExcludeReplicaHtmlContent
			};
			var existingTemplate = templateRepository.ReadByRecordId(bulkEmailId, repositoryReadOptions);
			if (existingTemplate != null && existingTemplate.Id.IsNotEmpty()) {
				templateRepository.Delete(existingTemplate.Id);
			}
		}

		public virtual void CopyHyperlinks() {
			var bulkEmailId = Entity.GetTypedColumnValue<Guid>("Id");
			var hyperlinksRepository = new BulkEmailHyperlinkRepository(UserConnection);
			hyperlinksRepository.CopyBulkEmailHyperlinks(SourceBulkEmailId, bulkEmailId);
		}

		public virtual void CopyBulkEmailWithoutTemplate() {
			var bulkEmailId = Entity.GetTypedColumnValue<Guid>("Id");
			var templateBody = Entity.GetTypedColumnValue<string>("TemplateBody");
			var statusId = Entity.GetTypedColumnValue<Guid>("StatusId");
			bool replaseHyperlinks = (statusId == MarketingConsts.BulkEmailStatusPlannedId);
			BulkEmailHyperlinkHelper.SaveBulkEmailHyperlinks(bulkEmailId, templateBody, replaseHyperlinks, UserConnection);
		}

		public virtual bool HasTemplate(Guid bulkEmailId) {
			var templateRepository = new DCTemplateRepository<DCTemplateModel>(UserConnection);
			var repositoryReadOptions = new DCRepositoryReadOptions<DCTemplateModel, DCReplicaModel> {
				TemplateReadOptions = DCTemplateReadOption.ExcludeAttributes
					| DCTemplateReadOption.ExcludeReplicaHtmlContent
			};
			var existingTemplate = templateRepository.ReadByRecordId(bulkEmailId, repositoryReadOptions);
			return existingTemplate != null && existingTemplate.Id.IsNotEmpty();
		}

		public virtual void CopyHeaders() {
			var bulkEmailId = Entity.GetTypedColumnValue<Guid>("Id");
			var templateRepository = new BulkEmailTemplateRepository(UserConnection);
			templateRepository.CopyBulkEmailReplicaHeaders(SourceBulkEmailId, bulkEmailId);
		}

		public virtual void SetBulkEmailStatus() {
			var isWizardFeatureEnabled = UserConnection.GetIsFeatureEnabled("MarketingContentBuilderWizard");
			var isCurrentStatusDraft = Entity.GetTypedColumnValue<Guid>("StatusId") == MailingConsts.BulkEmailStatusDraftId;
			var defaultStatus = isWizardFeatureEnabled && isCurrentStatusDraft 
				? MailingConsts.BulkEmailStatusDraftId 
				: MailingConsts.BulkEmailStatusPlannedId;
			Entity.SetColumnValue("StatusId", defaultStatus);
		}

		public override void ThrowEvent(ProcessExecutingContext context, string message) {
			switch(message) {
					case "BulkEmailInserting":
							if (ActivatedEventElements.Contains("BulkEmailInsertingStartMessage")) {
							context.QueueTasks.Enqueue("BulkEmailInsertingStartMessage");
						}
						break;
					case "BulkEmailSaved":
							if (ActivatedEventElements.Contains("BulkEmailSavedStartMessage")) {
							context.QueueTasks.Enqueue("BulkEmailSavedStartMessage");
						}
						break;
					case "BulkEmailSaving":
							if (ActivatedEventElements.Contains("BulkEmailSavingStartMessage")) {
							context.QueueTasks.Enqueue("BulkEmailSavingStartMessage");
						}
						break;
					case "BulkEmailDeleted":
							if (ActivatedEventElements.Contains("BulkEmailDeletedStartMessage")) {
							context.QueueTasks.Enqueue("BulkEmailDeletedStartMessage");
						}
						break;
					case "BulkEmailDeleting":
							if (ActivatedEventElements.Contains("BulkEmailDeletingStartMessage")) {
							context.QueueTasks.Enqueue("BulkEmailDeletingStartMessage");
						}
						break;
			}
			base.ThrowEvent(context, message);
			ProcessQueue(context);
		}

		public override void WritePropertiesData(DataWriter writer, bool writeFlowElements = true) {
			base.WritePropertiesData(writer, writeFlowElements);
			if (!HasMapping("SourceBulkEmailId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("SourceBulkEmailId", SourceBulkEmailId, Guid.Empty);
			}
			if (!HasMapping("IsCopy") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("IsCopy", IsCopy, false);
			}
			if (!HasMapping("EntityRId") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("EntityRId", EntityRId, 0);
			}
			if (!HasMapping("IsTemplateBodyChanged") || Status != Core.Process.ProcessStatus.Inactive) {
				writer.WriteValue("IsTemplateBodyChanged", IsTemplateBodyChanged, false);
			}
		}

		public override object CloneShallow() {
			return base.CloneShallow();
		}

		#endregion

	}

	#endregion

	#region Class: BulkEmail_MarketingCampaignEventsProcess

	/// <exclude/>
	public class BulkEmail_MarketingCampaignEventsProcess : BulkEmail_MarketingCampaignEventsProcess<BulkEmail>
	{

		public BulkEmail_MarketingCampaignEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: BulkEmailEventsProcessSchema

	/// <exclude/>
	public class BulkEmailEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public BulkEmailEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public BulkEmailEventsProcessSchema(BulkEmailEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "BulkEmail_MarketingCampaignEventsProcess";
			UId = new Guid("66467afc-4a7f-4190-8553-57e87f8fb285");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("bb4d6607-026b-4b27-b640-8f5c77c1e89d");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
		}

		protected override ProcessSchemaParameter CreateNextProcessElementReadyParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("d9e67329-fde2-4fbd-aa49-2d69ca3d2b5b"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				Name = @"NextProcessElementReady",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected override ProcessSchemaParameter CreateIsProcessModeSaveParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("4cb16350-d39b-4247-9da5-33032cf8667d"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				Name = @"IsProcessModeSave",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateIsTemplateBodyChangedParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("df5a2ad6-cfe1-46d2-8ce1-dfdc28533340"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("66467afc-4a7f-4190-8553-57e87f8fb285"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("66467afc-4a7f-4190-8553-57e87f8fb285"),
				Name = @"IsTemplateBodyChanged",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateEntityRIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("42cee202-cac8-4909-8830-1192733c07f3"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("66467afc-4a7f-4190-8553-57e87f8fb285"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("66467afc-4a7f-4190-8553-57e87f8fb285"),
				Name = @"EntityRId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Integer"),
			};
		}

		protected virtual ProcessSchemaParameter CreateIsCopyParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("52955ee6-d6c9-46af-8e84-e8a911e0c1b3"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("66467afc-4a7f-4190-8553-57e87f8fb285"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("66467afc-4a7f-4190-8553-57e87f8fb285"),
				Name = @"IsCopy",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Boolean"),
			};
		}

		protected virtual ProcessSchemaParameter CreateSourceBulkEmailIdParameter() {
			return new ProcessSchemaParameter(this) {
			UId = new Guid("4acae98a-84a8-4f2c-85c2-eb014a2fae1e"),
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = Guid.Empty,
				CreatedInPackageId = Guid.Empty,
				CreatedInSchemaUId = new Guid("66467afc-4a7f-4190-8553-57e87f8fb285"),
				Direction = ProcessSchemaParameterDirection.Variable,
				IsCopyValue = false,
				IsLazy = false,
				IsPerformer = false,
				IsRequired = false,
				IsResult = false,
				IsValueSerializable = true,
				ModifiedInSchemaUId = new Guid("66467afc-4a7f-4190-8553-57e87f8fb285"),
				Name = @"SourceBulkEmailId",
				SourceParameterUId = Guid.Empty,
				Tag = @"",
				UseBackgroundMode = false,
				DataValueType = DataValueTypeManager.GetInstanceByName("Guid"),
			};
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
			Parameters.Add(CreateIsTemplateBodyChangedParameter());
			Parameters.Add(CreateEntityRIdParameter());
			Parameters.Add(CreateIsCopyParameter());
			Parameters.Add(CreateSourceBulkEmailIdParameter());
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
			ProcessSchemaLaneSet schemaLaneSet1 = CreateLaneSet1LaneSet();
			LaneSets.Add(schemaLaneSet1);
			ProcessSchemaLane schemaLane1 = CreateLane1Lane();
			schemaLaneSet1.Lanes.Add(schemaLane1);
			ProcessSchemaEventSubProcess bulkemailinsertingstartmessageeventsubprocess = CreateBulkEmailInsertingStartMessageEventSubProcessEventSubProcess();
			FlowElements.Add(bulkemailinsertingstartmessageeventsubprocess);
			ProcessSchemaEventSubProcess eventsubprocess1 = CreateEventSubProcess1EventSubProcess();
			FlowElements.Add(eventsubprocess1);
			ProcessSchemaEventSubProcess eventsubprocess2 = CreateEventSubProcess2EventSubProcess();
			FlowElements.Add(eventsubprocess2);
			ProcessSchemaEventSubProcess eventsubprocess3 = CreateEventSubProcess3EventSubProcess();
			FlowElements.Add(eventsubprocess3);
			ProcessSchemaEventSubProcess eventsubprocess4 = CreateEventSubProcess4EventSubProcess();
			FlowElements.Add(eventsubprocess4);
			ProcessSchemaScriptTask bulkemailinsertingstartmessagescripttask = CreateBulkEmailInsertingStartMessageScriptTaskScriptTask();
			bulkemailinsertingstartmessageeventsubprocess.FlowElements.Add(bulkemailinsertingstartmessagescripttask);
			ProcessSchemaStartMessageEvent bulkemailinsertingstartmessage = CreateBulkEmailInsertingStartMessageStartMessageEvent();
			bulkemailinsertingstartmessageeventsubprocess.FlowElements.Add(bulkemailinsertingstartmessage);
			ProcessSchemaStartMessageEvent bulkemailsavedstartmessage = CreateBulkEmailSavedStartMessageStartMessageEvent();
			eventsubprocess1.FlowElements.Add(bulkemailsavedstartmessage);
			ProcessSchemaScriptTask bulkemailsavedscripttask = CreateBulkEmailSavedScriptTaskScriptTask();
			eventsubprocess1.FlowElements.Add(bulkemailsavedscripttask);
			ProcessSchemaStartMessageEvent bulkemailsavingstartmessage = CreateBulkEmailSavingStartMessageStartMessageEvent();
			eventsubprocess2.FlowElements.Add(bulkemailsavingstartmessage);
			ProcessSchemaScriptTask bulkemailsavingscripttask = CreateBulkEmailSavingScriptTaskScriptTask();
			eventsubprocess2.FlowElements.Add(bulkemailsavingscripttask);
			ProcessSchemaStartMessageEvent bulkemaildeletedstartmessage = CreateBulkEmailDeletedStartMessageStartMessageEvent();
			eventsubprocess3.FlowElements.Add(bulkemaildeletedstartmessage);
			ProcessSchemaScriptTask bulkemaildeletedscripttask = CreateBulkEmailDeletedScriptTaskScriptTask();
			eventsubprocess3.FlowElements.Add(bulkemaildeletedscripttask);
			ProcessSchemaStartMessageEvent bulkemaildeletingstartmessage = CreateBulkEmailDeletingStartMessageStartMessageEvent();
			eventsubprocess4.FlowElements.Add(bulkemaildeletingstartmessage);
			ProcessSchemaScriptTask bulkemaildeletingstartmessagescripttask = CreateBulkEmailDeletingStartMessageScriptTaskScriptTask();
			eventsubprocess4.FlowElements.Add(bulkemaildeletingstartmessagescripttask);
			FlowElements.Add(CreateSequenceFlow1SequenceFlow());
			FlowElements.Add(CreateBulkEmailSavedSequenceFlowSequenceFlow());
			FlowElements.Add(CreateSequenceFlow2SequenceFlow());
			FlowElements.Add(CreateSequenceFlow3SequenceFlow());
			FlowElements.Add(CreateSequenceFlow4SequenceFlow());
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow1SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow1",
				UId = new Guid("73dc7ebb-d7fb-43cf-aa60-eca5f538b890"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("196dac4c-8195-4488-a569-0010bfda9cdc"),
				CreatedInSchemaUId = new Guid("66467afc-4a7f-4190-8553-57e87f8fb285"),
				CurveCenterPosition = new Point(168, 91),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("66467afc-4a7f-4190-8553-57e87f8fb285"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("77eef246-adde-4746-baa0-8c43f45c9e91"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("909f355c-72fa-4512-9198-1dd649b4be2f"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateBulkEmailSavedSequenceFlowSequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "BulkEmailSavedSequenceFlow",
				UId = new Guid("7d0a6204-422e-4952-970f-a9d531d9af6f"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("b55c3d06-2f74-49c8-80fe-9c31696de305"),
				CreatedInSchemaUId = new Guid("66467afc-4a7f-4190-8553-57e87f8fb285"),
				CurveCenterPosition = new Point(533, 92),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("66467afc-4a7f-4190-8553-57e87f8fb285"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("3efa3683-63a7-433a-a91a-f91b30902d67"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("ac808fe5-89f8-4089-b4c0-a1fa19a956b3"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow2SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow2",
				UId = new Guid("aa16e2c4-36f4-4695-a824-9d40c6a5297a"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("b55c3d06-2f74-49c8-80fe-9c31696de305"),
				CreatedInSchemaUId = new Guid("66467afc-4a7f-4190-8553-57e87f8fb285"),
				CurveCenterPosition = new Point(807, 93),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("66467afc-4a7f-4190-8553-57e87f8fb285"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("aa6911e5-eb04-4e0c-bb09-6a49b788d31d"),
				SourceSequenceFlowPointLocalPosition = new Point(1, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("1435242c-1d2d-493f-be0c-09a3f08257a3"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow3SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow3",
				UId = new Guid("0dc6c01e-66d4-4962-b47a-01328856d257"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("677810ac-7ee6-4da7-8797-3256f167b0d5"),
				CreatedInSchemaUId = new Guid("66467afc-4a7f-4190-8553-57e87f8fb285"),
				CurveCenterPosition = new Point(164, 274),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("66467afc-4a7f-4190-8553-57e87f8fb285"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("683c8b5a-dc29-4f59-b24f-bd9ee357c840"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("597a6100-6597-4b98-b5d0-e8976a8a06d2"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			return schemaFlow;
		}

		protected virtual ProcessSchemaSequenceFlow CreateSequenceFlow4SequenceFlow() {
			ProcessSchemaSequenceFlow schemaFlow = new ProcessSchemaSequenceFlow(this, ProcessSchemaEditSequenceFlowType.Sequence) {
				Name = "SequenceFlow4",
				UId = new Guid("7bbd2242-e54d-483c-8dc8-d03a1f383303"),
				ContainerItemIndex = 0,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("677810ac-7ee6-4da7-8797-3256f167b0d5"),
				CreatedInSchemaUId = new Guid("66467afc-4a7f-4190-8553-57e87f8fb285"),
				CurveCenterPosition = new Point(497, 275),
				DragGroupName = @"SequenceFlow",
				FlowType = ProcessSchemaEditSequenceFlowType.Sequence,
				ManagerItemUId = new Guid("0d8351f6-c2f4-4737-bdd9-6fbfe0837fec"),
				ModifiedInSchemaUId = new Guid("66467afc-4a7f-4190-8553-57e87f8fb285"),
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Size = new Size(0, 0),
				SourceRefUId = new Guid("d3103f32-ca32-4bb5-92b0-44317f62b35e"),
				SourceSequenceFlowPointLocalPosition = new Point(0, 0),
				StrokeColor = Color.FromArgb(-7105128),
				TargetRefUId = new Guid("0ff3235e-52ab-45fd-a817-ad2bfb182c07"),
				TargetSequenceFlowPointLocalPosition = new Point(-1, 0),
				UseBackgroundMode = false,
				VisualType = ProcessSchemaSequenceFlowVisualType.AutoPolyline
			};
			schemaFlow.PolylinePointPositions.Add(new Point(473, 266));
			schemaFlow.PolylinePointPositions.Add(new Point(473, 267));
			return schemaFlow;
		}

		protected virtual ProcessSchemaLaneSet CreateLaneSet1LaneSet() {
			ProcessSchemaLaneSet schemaLaneSet1 = new ProcessSchemaLaneSet(this) {
				UId = new Guid("007355b8-81ff-4921-9fcb-f74130a40f3e"),
				ContainerItemIndex = 1,
				ContainerUId = Guid.Empty,
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("196dac4c-8195-4488-a569-0010bfda9cdc"),
				CreatedInSchemaUId = new Guid("66467afc-4a7f-4190-8553-57e87f8fb285"),
				Direction = ProcessSchemaPoolDirectionType.Vertical,
				DragGroupName = @"LaneSet",
				ManagerItemUId = new Guid("11a47caf-a0d5-41fa-a274-a0b11f77447a"),
				ModifiedInSchemaUId = new Guid("66467afc-4a7f-4190-8553-57e87f8fb285"),
				Name = @"LaneSet1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(5, 5),
				Size = new Size(1139, 443),
				UseBackgroundMode = false
			};
			return schemaLaneSet1;
		}

		protected virtual ProcessSchemaLane CreateLane1Lane() {
			ProcessSchemaLane schemaLane1 = new ProcessSchemaLane(this) {
				UId = new Guid("da2cefaa-72ef-4a32-b3ee-af3ad7f68be5"),
				ContainerItemIndex = 1,
				ContainerUId = new Guid("007355b8-81ff-4921-9fcb-f74130a40f3e"),
				CreatedInOwnerSchemaUId = new Guid("95fbcf9c-e36d-4acd-8b5a-d657de6e30a8"),
				CreatedInPackageId = new Guid("196dac4c-8195-4488-a569-0010bfda9cdc"),
				CreatedInSchemaUId = new Guid("66467afc-4a7f-4190-8553-57e87f8fb285"),
				DragGroupName = @"Lane",
				ManagerItemUId = new Guid("abcd74b9-5912-414b-82ac-f1aa4dcd554e"),
				ModifiedInSchemaUId = new Guid("66467afc-4a7f-4190-8553-57e87f8fb285"),
				Name = @"Lane1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(29, 0),
				Size = new Size(1110, 443),
				UseBackgroundMode = false
			};
			return schemaLane1;
		}

		protected virtual ProcessSchemaEventSubProcess CreateBulkEmailInsertingStartMessageEventSubProcessEventSubProcess() {
			ProcessSchemaEventSubProcess schemaBulkEmailInsertingStartMessageEventSubProcess = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("bfa3f852-95e0-43b6-a88e-0d4e0a14cce7"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("da2cefaa-72ef-4a32-b3ee-af3ad7f68be5"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("196dac4c-8195-4488-a569-0010bfda9cdc"),
				CreatedInSchemaUId = new Guid("66467afc-4a7f-4190-8553-57e87f8fb285"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("66467afc-4a7f-4190-8553-57e87f8fb285"),
				Name = @"BulkEmailInsertingStartMessageEventSubProcess",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(43, 9),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(308, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaBulkEmailInsertingStartMessageEventSubProcess;
		}

		protected virtual ProcessSchemaScriptTask CreateBulkEmailInsertingStartMessageScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("909f355c-72fa-4512-9198-1dd649b4be2f"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("bfa3f852-95e0-43b6-a88e-0d4e0a14cce7"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("196dac4c-8195-4488-a569-0010bfda9cdc"),
				CreatedInSchemaUId = new Guid("66467afc-4a7f-4190-8553-57e87f8fb285"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("66467afc-4a7f-4190-8553-57e87f8fb285"),
				Name = @"BulkEmailInsertingStartMessageScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(126, 49),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,115,42,205,201,118,205,77,204,204,241,204,43,78,45,42,201,204,75,215,208,180,230,229,42,74,45,41,45,202,83,40,41,42,77,181,6,0,58,241,209,46,35,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateBulkEmailInsertingStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("77eef246-adde-4746-baa0-8c43f45c9e91"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("bfa3f852-95e0-43b6-a88e-0d4e0a14cce7"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("196dac4c-8195-4488-a569-0010bfda9cdc"),
				CreatedInSchemaUId = new Guid("66467afc-4a7f-4190-8553-57e87f8fb285"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"BulkEmailInserting",
				ModifiedInSchemaUId = new Guid("66467afc-4a7f-4190-8553-57e87f8fb285"),
				Name = @"BulkEmailInsertingStartMessage",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(21, 63),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess1EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess1 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("1c17b7d0-53cd-4e1e-80a0-d273013bcf78"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("da2cefaa-72ef-4a32-b3ee-af3ad7f68be5"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("b55c3d06-2f74-49c8-80fe-9c31696de305"),
				CreatedInSchemaUId = new Guid("66467afc-4a7f-4190-8553-57e87f8fb285"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("66467afc-4a7f-4190-8553-57e87f8fb285"),
				Name = @"EventSubProcess1",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(364, 7),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(296, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess1;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateBulkEmailSavedStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("3efa3683-63a7-433a-a91a-f91b30902d67"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1c17b7d0-53cd-4e1e-80a0-d273013bcf78"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("b55c3d06-2f74-49c8-80fe-9c31696de305"),
				CreatedInSchemaUId = new Guid("66467afc-4a7f-4190-8553-57e87f8fb285"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"BulkEmailSaved",
				ModifiedInSchemaUId = new Guid("66467afc-4a7f-4190-8553-57e87f8fb285"),
				Name = @"BulkEmailSavedStartMessage",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(50, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateBulkEmailSavedScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("ac808fe5-89f8-4089-b4c0-a1fa19a956b3"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("1c17b7d0-53cd-4e1e-80a0-d273013bcf78"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("b55c3d06-2f74-49c8-80fe-9c31696de305"),
				CreatedInSchemaUId = new Guid("66467afc-4a7f-4190-8553-57e87f8fb285"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("66467afc-4a7f-4190-8553-57e87f8fb285"),
				Name = @"BulkEmailSavedScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(190, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,115,42,205,201,118,205,77,204,204,9,78,44,75,77,209,208,180,230,229,42,74,45,41,45,202,83,40,41,42,77,181,6,0,215,192,103,15,31,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess2EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess2 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("5384c573-e924-43fc-8f5b-a2f33ed87318"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("da2cefaa-72ef-4a32-b3ee-af3ad7f68be5"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("b55c3d06-2f74-49c8-80fe-9c31696de305"),
				CreatedInSchemaUId = new Guid("66467afc-4a7f-4190-8553-57e87f8fb285"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("66467afc-4a7f-4190-8553-57e87f8fb285"),
				Name = @"EventSubProcess2",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(665, 0),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(343, 158),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess2;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateBulkEmailSavingStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("aa6911e5-eb04-4e0c-bb09-6a49b788d31d"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5384c573-e924-43fc-8f5b-a2f33ed87318"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("b55c3d06-2f74-49c8-80fe-9c31696de305"),
				CreatedInSchemaUId = new Guid("66467afc-4a7f-4190-8553-57e87f8fb285"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"BulkEmailSaving",
				ModifiedInSchemaUId = new Guid("66467afc-4a7f-4190-8553-57e87f8fb285"),
				Name = @"BulkEmailSavingStartMessage",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(29, 72),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateBulkEmailSavingScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("1435242c-1d2d-493f-be0c-09a3f08257a3"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("5384c573-e924-43fc-8f5b-a2f33ed87318"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("b55c3d06-2f74-49c8-80fe-9c31696de305"),
				CreatedInSchemaUId = new Guid("66467afc-4a7f-4190-8553-57e87f8fb285"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("66467afc-4a7f-4190-8553-57e87f8fb285"),
				Name = @"BulkEmailSavingScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(148, 58),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,144,203,106,195,48,16,69,215,53,248,31,148,172,28,40,254,128,164,105,33,194,4,173,178,176,233,126,90,77,92,81,89,114,164,153,128,41,253,247,218,125,161,26,234,237,48,247,220,199,21,130,120,98,251,90,117,96,172,210,98,47,42,71,134,134,242,136,212,12,61,106,233,45,119,238,17,44,227,221,145,141,190,47,214,74,175,55,187,60,187,142,82,111,245,97,73,125,178,11,0,21,165,239,135,81,148,6,88,237,103,208,241,177,246,28,158,241,175,209,183,248,97,30,97,43,52,158,129,45,21,147,217,79,78,194,174,183,64,120,240,122,88,238,24,41,24,215,142,33,155,68,146,246,109,22,81,179,194,255,211,84,76,79,242,5,92,139,83,175,85,26,181,172,46,12,54,22,51,219,91,81,127,114,165,239,122,8,38,122,87,158,130,54,14,172,106,157,15,40,33,226,228,97,206,162,248,218,105,35,222,242,236,166,70,250,157,170,38,32,142,197,244,246,158,103,1,137,131,19,20,24,119,31,173,215,171,227,19,2,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess3EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess3 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("ceff2bdf-c695-472c-a1b4-626707842379"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("da2cefaa-72ef-4a32-b3ee-af3ad7f68be5"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("677810ac-7ee6-4da7-8797-3256f167b0d5"),
				CreatedInSchemaUId = new Guid("66467afc-4a7f-4190-8553-57e87f8fb285"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("66467afc-4a7f-4190-8553-57e87f8fb285"),
				Name = @"EventSubProcess3",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(42, 189),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(308, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess3;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateBulkEmailDeletedStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("683c8b5a-dc29-4f59-b24f-bd9ee357c840"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ceff2bdf-c695-472c-a1b4-626707842379"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("677810ac-7ee6-4da7-8797-3256f167b0d5"),
				CreatedInSchemaUId = new Guid("66467afc-4a7f-4190-8553-57e87f8fb285"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"BulkEmailDeleted",
				ModifiedInSchemaUId = new Guid("66467afc-4a7f-4190-8553-57e87f8fb285"),
				Name = @"BulkEmailDeletedStartMessage",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(22, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateBulkEmailDeletedScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("597a6100-6597-4b98-b5d0-e8976a8a06d2"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("ceff2bdf-c695-472c-a1b4-626707842379"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("677810ac-7ee6-4da7-8797-3256f167b0d5"),
				CreatedInSchemaUId = new Guid("66467afc-4a7f-4190-8553-57e87f8fb285"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("66467afc-4a7f-4190-8553-57e87f8fb285"),
				Name = @"BulkEmailDeletedScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(120, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,115,42,205,201,118,205,77,204,204,113,73,205,73,45,73,77,209,208,180,230,229,42,74,45,41,45,202,83,40,41,42,77,181,6,0,46,236,173,4,33,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected virtual ProcessSchemaEventSubProcess CreateEventSubProcess4EventSubProcess() {
			ProcessSchemaEventSubProcess schemaEventSubProcess4 = new ProcessSchemaEventSubProcess(this) {
				UId = new Guid("eda2b2b0-bed7-44bc-aff7-22561620ddc9"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("da2cefaa-72ef-4a32-b3ee-af3ad7f68be5"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("677810ac-7ee6-4da7-8797-3256f167b0d5"),
				CreatedInSchemaUId = new Guid("66467afc-4a7f-4190-8553-57e87f8fb285"),
				DragGroupName = @"EventSubProcess",
				EntitySchemaUId = Guid.Empty,
				IsExpanded = true,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0824af03-1340-47a3-8787-ef542f566992"),
				ModifiedInSchemaUId = new Guid("66467afc-4a7f-4190-8553-57e87f8fb285"),
				Name = @"EventSubProcess4",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(371, 189),
				SchemaUId = Guid.Empty,
				SerializeToDB = false,
				Size = new Size(287, 154),
				TriggeredByEvent = true,
				UseBackgroundMode = false,
				UseLastSchemaVersion = false
			};
			
			return schemaEventSubProcess4;
		}

		protected virtual ProcessSchemaStartMessageEvent CreateBulkEmailDeletingStartMessageStartMessageEvent() {
			ProcessSchemaStartMessageEvent schemaStartMessageEvent = new ProcessSchemaStartMessageEvent(this) {
				UId = new Guid("d3103f32-ca32-4bb5-92b0-44317f62b35e"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("eda2b2b0-bed7-44bc-aff7-22561620ddc9"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("677810ac-7ee6-4da7-8797-3256f167b0d5"),
				CreatedInSchemaUId = new Guid("66467afc-4a7f-4190-8553-57e87f8fb285"),
				DragGroupName = @"Event",
				EntitySchemaUId = Guid.Empty,
				ImageList = null,
				ImageName = null,
				IsInterrupting = false,
				IsLogging = false,
				ManagerItemUId = new Guid("02340c80-8e75-4f7a-917b-04125bc07192"),
				Message = @"BulkEmailDeleting",
				ModifiedInSchemaUId = new Guid("66467afc-4a7f-4190-8553-57e87f8fb285"),
				Name = @"BulkEmailDeletingStartMessage",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(29, 65),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false
			};
			
			return schemaStartMessageEvent;
		}

		protected virtual ProcessSchemaScriptTask CreateBulkEmailDeletingStartMessageScriptTaskScriptTask() {
			ProcessSchemaScriptTask ScriptTask = new ProcessSchemaScriptTask(this) {
				UId = new Guid("0ff3235e-52ab-45fd-a817-ad2bfb182c07"),
				ContainerItemIndex = 0,
				ContainerUId = new Guid("eda2b2b0-bed7-44bc-aff7-22561620ddc9"),
				CreatedInOwnerSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165"),
				CreatedInPackageId = new Guid("677810ac-7ee6-4da7-8797-3256f167b0d5"),
				CreatedInSchemaUId = new Guid("66467afc-4a7f-4190-8553-57e87f8fb285"),
				DragGroupName = @"Task",
				EntitySchemaUId = Guid.Empty,
				FillColor = Color.FromArgb(-1),
				ImageList = null,
				ImageName = null,
				IsForCompensation = false,
				IsLogging = false,
				ManagerItemUId = new Guid("0e490dda-e140-4441-b600-6f5c64d024df"),
				ModifiedInSchemaUId = new Guid("66467afc-4a7f-4190-8553-57e87f8fb285"),
				Name = @"BulkEmailDeletingStartMessageScriptTask",
				OwnerSchemaManagerName = @"EntitySchemaManager",
				Position = new Point(148, 51),
				SerializeToDB = false,
				Size = new Size(0, 0),
				UseBackgroundMode = false,
				UseFlowEngineScriptVersion = false,
				ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,115,42,205,201,118,205,77,204,204,113,73,205,73,45,201,204,75,215,208,180,230,229,42,74,45,41,45,202,83,40,41,42,77,181,6,0,52,147,161,206,34,0,0,0 }
			};
			
			return ScriptTask;
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
			Methods.Add(CreateBulkEmailInsertingMethod());
			Methods.Add(CreateBulkEmailSavedMethod());
			Methods.Add(CreateBulkEmailDeletedMethod());
			Methods.Add(CreateGetBulkEmailRIdMethod());
			Methods.Add(CreateBulkEmailDeletingMethod());
			Methods.Add(CreateCopyBulkEmailTemplateMethod());
			Methods.Add(CreateLinkTemplateWithBulkEmailMethod());
			Methods.Add(CreateDeleteBulkEmailTemplateMethod());
			Methods.Add(CreateCopyHyperlinksMethod());
			Methods.Add(CreateCopyBulkEmailWithoutTemplateMethod());
			Methods.Add(CreateHasTemplateMethod());
			Methods.Add(CreateCopyHeadersMethod());
			Methods.Add(CreateSetBulkEmailStatusMethod());
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
			Usings.Add(new SchemaUsing() {
				UId = new Guid("3fa4a890-e893-4d10-8698-3dbd27f27276"),
				Name = "Terrasoft.Configuration.DynamicContent",
				Alias = "",
				CreatedInPackageId = new Guid("c92d8fca-4a0d-4385-86d2-4f5717aa816e")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e0bb1255-324a-4065-ab73-fa11a036b8dd"),
				Name = "Terrasoft.Configuration.DynamicContent.Models",
				Alias = "",
				CreatedInPackageId = new Guid("c92d8fca-4a0d-4385-86d2-4f5717aa816e")
			});
		}

		protected virtual SchemaMethod CreateBulkEmailInsertingMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("a897c3dc-69f1-4949-8d39-ce30a1bbc109"),
				Name = "BulkEmailInserting",
				CreatedInSchemaUId = new Guid("66467afc-4a7f-4190-8553-57e87f8fb285"),
				CreatedInPackageId = new Guid("196dac4c-8195-4488-a569-0010bfda9cdc"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,173,143,65,75,195,48,20,128,207,22,250,31,226,78,9,72,192,131,39,217,65,107,145,194,170,135,78,239,143,230,173,11,75,147,145,188,32,197,249,223,109,107,117,142,34,34,120,202,227,37,223,199,23,189,97,252,60,183,164,169,147,247,72,69,200,156,137,173,125,6,19,113,229,64,161,226,139,12,8,27,231,187,66,45,4,59,28,210,228,236,87,100,5,209,214,219,199,61,105,103,39,140,125,50,167,119,178,8,121,187,167,142,11,33,216,107,239,246,72,209,219,235,52,121,75,147,52,209,27,62,97,199,10,182,92,178,18,252,14,73,219,38,115,54,80,144,37,132,208,130,54,253,230,54,154,93,62,204,71,226,195,60,137,42,164,111,197,179,214,139,153,251,75,88,130,133,104,78,223,139,161,148,253,37,117,237,117,211,160,71,53,58,255,189,118,210,143,206,170,222,162,138,6,213,188,249,39,127,69,224,233,174,111,233,213,195,177,214,45,202,39,170,31,220,139,188,81,170,212,54,18,6,126,121,37,198,159,191,3,95,199,245,255,64,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateBulkEmailSavedMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("5ce95fd6-1ac7-40d4-a259-c31d266cc0a0"),
				Name = "BulkEmailSaved",
				CreatedInSchemaUId = new Guid("66467afc-4a7f-4190-8553-57e87f8fb285"),
				CreatedInPackageId = new Guid("b55c3d06-2f74-49c8-80fe-9c31696de305"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,143,189,110,131,48,20,133,103,144,120,7,135,33,50,75,94,32,234,194,79,18,150,44,105,213,217,197,183,193,138,177,145,125,141,132,10,239,94,40,148,170,5,169,155,117,117,206,231,243,53,204,16,97,211,228,4,12,157,129,76,177,55,9,156,60,145,23,11,38,209,74,65,129,66,171,195,25,48,183,191,67,52,140,157,124,100,21,19,50,109,21,171,68,49,228,17,20,198,78,72,14,38,140,142,129,47,222,9,221,224,239,247,36,183,137,174,219,241,117,211,206,20,176,192,114,126,200,237,85,99,86,213,216,210,40,34,31,129,239,53,195,206,146,217,103,168,106,201,16,166,202,48,243,242,115,163,43,206,56,192,27,23,172,154,19,212,27,23,44,249,133,243,85,235,9,72,11,27,177,87,129,165,118,248,39,29,248,253,36,187,219,182,165,179,110,215,13,226,223,221,88,243,54,41,153,186,3,159,53,255,253,169,255,4,66,106,13,120,177,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateBulkEmailDeletedMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("2067abd0-cfb1-409c-8bd5-e6194932936a"),
				Name = "BulkEmailDeleted",
				CreatedInSchemaUId = new Guid("66467afc-4a7f-4190-8553-57e87f8fb285"),
				CreatedInPackageId = new Guid("677810ac-7ee6-4da7-8797-3256f167b0d5"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,145,205,110,194,48,16,132,207,137,196,59,88,57,32,231,18,245,222,194,1,18,80,164,34,33,74,219,243,54,94,218,21,142,147,250,135,22,85,188,123,157,184,133,160,246,104,123,118,246,155,241,1,52,35,147,207,23,8,214,105,44,20,188,72,20,108,194,30,13,234,121,163,20,86,150,26,149,45,209,150,230,90,196,147,153,147,251,162,6,146,249,81,65,77,149,215,91,84,118,230,72,10,212,73,122,59,138,105,199,120,161,44,217,99,176,152,55,210,213,234,9,164,195,251,6,68,231,242,96,189,171,41,69,146,178,241,152,5,241,166,20,108,202,110,82,246,53,138,163,165,35,193,76,175,26,140,123,198,139,241,246,216,162,24,60,222,117,51,211,161,183,103,137,104,199,255,177,153,176,21,232,61,90,82,175,62,128,177,38,59,231,10,227,107,9,190,7,81,138,128,19,29,124,103,2,37,218,142,65,225,7,203,251,3,191,174,44,237,164,81,148,45,116,83,243,100,5,74,104,146,114,131,21,181,228,75,74,126,223,159,223,80,227,160,203,77,71,155,149,166,120,119,32,121,32,205,214,160,161,246,59,52,63,247,147,246,145,162,0,146,21,159,88,57,207,208,95,158,70,241,41,84,255,247,107,67,134,64,124,222,185,197,186,149,240,51,126,250,6,65,83,158,213,20,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateGetBulkEmailRIdMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("f3d7efd9-192a-404f-999e-f7543016190b"),
				Name = "GetBulkEmailRId",
				CreatedInSchemaUId = new Guid("66467afc-4a7f-4190-8553-57e87f8fb285"),
				CreatedInPackageId = new Guid("677810ac-7ee6-4da7-8797-3256f167b0d5"),
				ResultValueTypeName = "int"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("bc0d7a28-971b-4a35-b05d-0d01748c46a1"),
				Name = "bulkEmailId",
				CreatedInSchemaUId = new Guid("66467afc-4a7f-4190-8553-57e87f8fb285"),
				ModifiedInSchemaUId = new Guid("66467afc-4a7f-4190-8553-57e87f8fb285"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("677810ac-7ee6-4da7-8797-3256f167b0d5")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,53,142,177,14,194,48,16,67,103,250,21,81,166,203,146,31,40,48,80,21,41,27,162,66,204,71,123,18,21,201,69,189,36,192,231,67,75,217,252,44,91,246,19,69,37,242,212,103,181,83,76,47,213,45,0,151,68,210,68,230,175,30,35,155,106,99,155,232,75,96,208,103,55,232,153,143,18,3,232,67,241,143,54,224,232,23,239,122,39,33,208,115,194,186,212,78,5,61,252,122,246,132,130,129,50,9,220,254,21,55,24,163,48,173,147,117,37,148,139,240,122,199,182,111,234,75,166,174,71,143,178,29,57,239,193,212,213,7,201,128,109,227,176,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateBulkEmailDeletingMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("d98080ce-e617-4867-ab02-b92f5e2a8bb3"),
				Name = "BulkEmailDeleting",
				CreatedInSchemaUId = new Guid("66467afc-4a7f-4190-8553-57e87f8fb285"),
				CreatedInPackageId = new Guid("677810ac-7ee6-4da7-8797-3256f167b0d5"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,115,205,43,201,44,169,12,242,76,81,176,85,112,79,45,113,42,205,201,118,205,77,204,204,1,138,104,184,130,229,244,60,83,52,173,1,10,177,96,68,39,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCopyBulkEmailTemplateMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("6eb9ad4d-c9f3-4377-bdc2-f8559fafa842"),
				Name = "CopyBulkEmailTemplate",
				CreatedInSchemaUId = new Guid("66467afc-4a7f-4190-8553-57e87f8fb285"),
				CreatedInPackageId = new Guid("c92d8fca-4a0d-4385-86d2-4f5717aa816e"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,81,219,78,132,48,16,125,134,175,168,47,155,146,108,248,1,47,137,139,36,75,226,37,65,141,207,72,71,109,182,180,77,59,197,37,186,255,110,43,194,162,16,223,232,156,153,115,163,173,12,65,104,180,168,16,74,208,202,114,84,166,35,231,68,194,59,185,202,30,102,208,217,113,120,163,24,136,11,250,104,193,100,74,74,168,145,43,153,156,198,173,231,52,227,65,9,21,187,211,1,178,35,109,185,132,254,101,94,247,139,130,215,85,175,68,62,226,232,104,104,202,58,53,58,204,211,124,95,11,199,224,18,209,240,103,135,96,227,40,250,252,119,245,71,109,139,141,240,129,16,36,198,135,62,14,236,185,69,46,95,135,91,175,57,111,45,13,140,27,31,169,86,134,21,140,222,43,103,106,216,56,177,203,155,138,139,130,173,151,107,241,149,241,23,66,103,26,39,190,46,39,4,89,173,102,250,105,193,210,194,222,42,204,27,141,29,77,146,208,77,59,249,151,153,210,93,193,150,109,6,108,166,230,25,189,143,232,154,203,221,48,122,226,248,54,186,167,191,153,195,110,248,218,118,26,140,240,71,150,142,35,159,12,204,247,251,16,127,1,166,69,178,220,96,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateLinkTemplateWithBulkEmailMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("0913db11-284f-4609-9e1b-91522b5fdcc4"),
				Name = "LinkTemplateWithBulkEmail",
				CreatedInSchemaUId = new Guid("66467afc-4a7f-4190-8553-57e87f8fb285"),
				CreatedInPackageId = new Guid("c92d8fca-4a0d-4385-86d2-4f5717aa816e"),
				ResultValueTypeName = "void"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("ad0d7a28-971b-4a35-b045-0d02768c46a2"),
				Name = "templateCopyId",
				CreatedInSchemaUId = new Guid("66467afc-4a7f-4190-8553-57e87f8fb285"),
				ModifiedInSchemaUId = new Guid("66467afc-4a7f-4190-8553-57e87f8fb285"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("c92d8fca-4a0d-4385-86d2-4f5717aa816e")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,144,177,110,194,48,16,134,103,120,10,43,147,35,85,121,129,210,14,152,128,60,148,1,104,247,171,125,20,171,246,57,114,46,72,86,197,187,55,81,104,149,82,22,15,62,255,223,127,254,220,81,72,198,208,120,96,84,177,201,218,86,186,221,70,174,67,195,89,150,165,248,154,207,206,144,196,123,231,63,235,0,206,107,43,158,68,77,236,56,87,27,228,67,110,208,170,232,187,64,111,224,59,92,108,58,103,159,101,161,109,81,62,142,209,31,252,24,218,155,19,6,232,25,175,45,38,21,137,208,176,139,84,77,167,47,64,240,129,105,224,107,106,25,200,224,50,111,33,160,164,254,136,71,185,82,135,43,180,188,223,210,243,239,213,86,42,225,239,149,252,187,193,0,114,19,27,215,63,174,145,205,105,157,98,88,45,111,68,141,114,102,55,239,247,200,19,29,178,216,161,137,201,246,58,30,166,14,135,178,127,73,56,163,28,6,151,249,229,27,88,21,113,205,151,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateDeleteBulkEmailTemplateMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("5902bb17-ae65-4e3f-ace0-bdfc0a2f7f78"),
				Name = "DeleteBulkEmailTemplate",
				CreatedInSchemaUId = new Guid("66467afc-4a7f-4190-8553-57e87f8fb285"),
				CreatedInPackageId = new Guid("c92d8fca-4a0d-4385-86d2-4f5717aa816e"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,145,193,78,195,48,12,134,207,171,212,119,8,59,76,173,52,245,5,24,147,160,171,70,15,128,84,13,238,89,99,80,132,155,84,137,51,86,193,222,157,148,173,91,181,86,92,109,255,223,111,255,222,113,195,182,14,63,179,138,75,204,5,187,99,153,34,73,77,178,6,218,52,53,136,84,163,171,212,27,71,7,139,181,147,98,25,77,115,49,141,111,195,96,231,165,4,85,141,156,160,128,90,91,73,218,52,158,160,224,139,173,210,205,160,181,184,20,159,180,0,92,70,175,22,76,170,149,130,146,164,86,29,212,156,21,5,112,241,82,183,61,123,230,22,99,221,107,244,252,56,136,178,228,71,43,246,29,6,147,203,74,125,108,127,213,174,158,100,251,18,157,128,123,34,35,183,142,192,122,249,228,231,223,217,147,223,35,85,232,111,34,80,20,6,135,211,73,176,151,150,164,250,232,212,222,118,24,93,210,50,31,252,89,165,54,34,23,81,239,47,243,241,80,218,196,228,59,139,6,248,27,159,150,67,100,179,217,192,58,201,69,146,219,103,77,89,85,83,19,197,241,95,52,35,219,172,0,129,96,192,246,250,214,246,240,11,61,185,253,134,58,2,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCopyHyperlinksMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("a9ed3186-4355-448e-b4ba-d3facad8e514"),
				Name = "CopyHyperlinks",
				CreatedInSchemaUId = new Guid("66467afc-4a7f-4190-8553-57e87f8fb285"),
				CreatedInPackageId = new Guid("c92d8fca-4a0d-4385-86d2-4f5717aa816e"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,109,207,203,10,194,48,16,133,225,189,224,59,132,174,82,144,190,64,213,69,67,169,221,122,219,199,102,192,208,116,38,228,82,201,219,27,23,165,130,238,255,249,56,51,75,199,30,209,140,237,36,181,233,21,59,176,22,131,14,169,234,32,92,147,5,37,200,196,9,239,210,68,216,119,81,171,35,47,122,85,148,245,118,51,231,211,103,78,156,209,56,250,51,88,242,58,144,75,217,64,120,177,102,81,79,75,179,38,252,230,193,9,66,132,33,104,194,143,246,79,170,4,217,244,235,120,126,161,232,6,104,214,221,187,239,39,202,250,13,213,31,76,68,214,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCopyBulkEmailWithoutTemplateMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("a5ca99b5-900f-417f-80de-70b8714c98d2"),
				Name = "CopyBulkEmailWithoutTemplate",
				CreatedInSchemaUId = new Guid("66467afc-4a7f-4190-8553-57e87f8fb285"),
				CreatedInPackageId = new Guid("c92d8fca-4a0d-4385-86d2-4f5717aa816e"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,144,203,10,194,64,12,69,247,126,197,224,170,133,210,31,240,177,80,68,187,16,4,31,251,209,9,50,52,205,200,36,83,232,223,27,81,171,34,136,187,192,205,57,121,180,54,154,99,194,122,209,88,143,149,51,19,179,32,241,210,149,75,144,93,119,1,55,15,152,26,58,88,76,48,94,38,239,166,217,176,114,195,124,52,104,149,20,104,46,104,5,102,193,117,191,81,150,232,233,172,240,238,13,121,106,88,172,36,254,115,250,246,209,124,131,143,33,160,137,160,66,134,149,246,71,244,84,179,106,178,151,114,98,214,54,214,32,58,126,30,136,133,203,217,243,222,187,106,131,150,8,92,229,84,216,71,189,109,5,168,85,185,181,45,124,135,156,189,253,174,248,120,71,241,189,87,97,246,12,81,151,32,56,137,15,148,143,174,58,196,250,63,126,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateHasTemplateMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("19e9a7fc-09aa-4490-a9ad-0b42be401c82"),
				Name = "HasTemplate",
				CreatedInSchemaUId = new Guid("66467afc-4a7f-4190-8553-57e87f8fb285"),
				CreatedInPackageId = new Guid("c92d8fca-4a0d-4385-86d2-4f5717aa816e"),
				ResultValueTypeName = "bool"
			};
			method.Arguments.Add(new SchemaMethodArgument() {
				UId = new Guid("c1f5f188-f921-446e-a674-7abe7e3e0eb8"),
				Name = "bulkEmailId",
				CreatedInSchemaUId = new Guid("66467afc-4a7f-4190-8553-57e87f8fb285"),
				ModifiedInSchemaUId = new Guid("66467afc-4a7f-4190-8553-57e87f8fb285"),
				Direction = Terrasoft.Common.ParameterDirection.Input,
				ValueTypeName = "Guid",
				CreatedInPackageId = new Guid("c92d8fca-4a0d-4385-86d2-4f5717aa816e")
			});
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,125,144,203,10,194,48,16,69,215,237,87,196,77,169,32,253,1,31,224,163,96,23,42,20,253,128,216,12,18,156,38,37,153,168,69,253,119,35,245,133,21,183,115,103,206,157,123,15,220,48,130,178,66,78,144,67,165,173,36,109,106,54,100,10,142,108,54,93,183,164,193,123,184,208,2,112,20,111,44,152,169,86,10,10,146,90,117,251,225,193,51,205,235,32,7,46,86,213,93,178,47,108,254,75,253,38,247,154,69,148,5,111,156,216,57,12,222,15,125,82,63,31,125,206,147,244,84,160,19,48,38,50,114,235,8,108,24,4,151,191,171,15,183,57,149,232,3,17,40,10,175,77,28,56,73,75,82,237,158,183,222,179,221,90,114,39,78,124,164,66,27,145,137,120,235,112,159,150,92,98,38,122,191,11,241,101,25,32,103,84,219,160,227,187,114,136,44,138,90,90,146,137,36,179,75,77,105,89,81,29,123,200,13,193,194,76,134,198,1,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateCopyHeadersMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("4542daf6-eb99-46b4-a4c6-425c83f22dfc"),
				Name = "CopyHeaders",
				CreatedInSchemaUId = new Guid("66467afc-4a7f-4190-8553-57e87f8fb285"),
				CreatedInPackageId = new Guid("9892593b-d041-45d0-95a7-d3a6e875d1a5"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,101,207,77,10,194,48,16,5,224,189,224,29,66,87,41,72,47,80,117,209,82,106,183,90,221,199,100,22,193,36,19,146,73,37,183,55,46,252,129,110,135,247,62,222,44,34,176,123,50,143,193,10,109,38,197,14,108,112,164,41,55,35,208,156,61,168,30,77,178,238,38,76,130,253,152,180,58,242,106,82,85,221,110,55,75,169,18,88,111,4,193,25,60,70,77,24,114,17,28,60,89,247,49,231,85,130,95,35,132,30,157,3,73,26,221,155,90,51,77,143,62,127,145,114,55,90,138,19,8,5,33,242,11,166,32,161,251,205,222,253,255,80,183,47,191,197,86,43,213,0,0,0 };
			return method;
		}

		protected virtual SchemaMethod CreateSetBulkEmailStatusMethod() {
			SchemaMethod method = new SchemaMethod() {
				UId = new Guid("73e12acf-67cf-4ad5-b332-d99a6238992d"),
				Name = "SetBulkEmailStatus",
				CreatedInSchemaUId = new Guid("66467afc-4a7f-4190-8553-57e87f8fb285"),
				CreatedInPackageId = new Guid("9892593b-d041-45d0-95a7-d3a6e875d1a5"),
				ResultValueTypeName = "void"
			};
			method.ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,144,203,10,194,48,16,69,215,246,43,66,23,162,32,126,128,90,5,107,149,46,4,193,215,122,52,163,4,211,84,38,19,65,191,222,209,186,168,160,226,54,57,185,231,222,92,128,148,241,91,115,3,210,83,4,14,132,153,131,157,69,173,18,181,246,72,105,233,28,238,217,148,174,59,67,206,253,59,212,138,231,64,39,100,227,142,2,50,58,30,7,99,53,82,149,24,183,251,209,229,105,72,3,145,220,46,89,94,251,9,193,129,37,63,115,108,248,250,200,93,93,207,168,211,210,134,194,109,192,6,28,204,130,209,195,86,92,241,185,4,169,36,81,115,48,182,50,121,246,221,113,176,167,172,144,163,90,104,174,43,161,198,3,4,251,210,137,233,203,196,102,243,115,181,168,49,250,75,38,96,239,55,184,176,32,255,167,31,189,94,107,151,200,181,161,181,137,157,247,214,237,254,29,27,223,22,142,156,1,0,0 };
			return method;
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new BulkEmailEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("66467afc-4a7f-4190-8553-57e87f8fb285"));
		}

		#endregion

	}

	#endregion


	#region Class: BulkEmailEventsProcess

	/// <exclude/>
	public class BulkEmailEventsProcess : BulkEmail_MarketingCampaignEventsProcess
	{

		public BulkEmailEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

