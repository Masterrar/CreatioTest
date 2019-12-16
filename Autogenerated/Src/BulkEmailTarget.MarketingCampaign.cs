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

	#region Class: BulkEmailTargetSchema

	/// <exclude/>
	public class BulkEmailTargetSchema : Terrasoft.Configuration.BaseEntitySchema
	{

		#region Constructors: Public

		public BulkEmailTargetSchema(EntitySchemaManager entitySchemaManager)
			: base(entitySchemaManager) {
		}

		public BulkEmailTargetSchema(BulkEmailTargetSchema source, bool isShallowClone)
			: base(source, isShallowClone) {
		}

		public BulkEmailTargetSchema(BulkEmailTargetSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Private

		private EntitySchemaIndex CreateIz3ZNsqNDC7R9KMZoEDNjjOoX60Index() {
			EntitySchemaIndex index = new EntitySchemaIndex() {
				IsAutoName = true,
				IsClustered = false,
				IsUnique = false
			};
			index.UId = new Guid("69202b53-edb4-40ee-9fdf-5524932802b2");
			index.Name = "Iz3ZNsqNDC7R9KMZoEDNjjOoX60";
			index.CreatedInSchemaUId = new Guid("bcc8d07b-aed8-400b-9bee-a8415c9c81a0");
			index.ModifiedInSchemaUId = new Guid("bcc8d07b-aed8-400b-9bee-a8415c9c81a0");
			index.CreatedInPackageId = new Guid("ad2d5243-f3e1-4196-99cf-d5d7d1dcc487");
			EntitySchemaIndexColumn mandrillIdIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("2015b707-8e92-403a-89f4-afad59da826b"),
				ColumnUId = new Guid("357bfa16-8ce0-4384-9903-8a654a337c88"),
				CreatedInSchemaUId = new Guid("bcc8d07b-aed8-400b-9bee-a8415c9c81a0"),
				ModifiedInSchemaUId = new Guid("bcc8d07b-aed8-400b-9bee-a8415c9c81a0"),
				CreatedInPackageId = new Guid("ad2d5243-f3e1-4196-99cf-d5d7d1dcc487"),
				OrderDirection = OrderDirectionStrict.Ascending
			};
			index.Columns.Add(mandrillIdIndexColumn);
			return index;
		}

		private EntitySchemaIndex CreateIbUkCjRUBPrSECidIkGlST9IQkIndex() {
			EntitySchemaIndex index = new EntitySchemaIndex() {
				IsAutoName = true,
				IsClustered = false,
				IsUnique = false
			};
			index.UId = new Guid("7168fc8b-5d3e-4a2c-a09c-f86b9aa6ad1c");
			index.Name = "IbUkCjRUBPrSECidIkGlST9IQk";
			index.CreatedInSchemaUId = new Guid("bcc8d07b-aed8-400b-9bee-a8415c9c81a0");
			index.ModifiedInSchemaUId = new Guid("bcc8d07b-aed8-400b-9bee-a8415c9c81a0");
			index.CreatedInPackageId = new Guid("196dac4c-8195-4488-a569-0010bfda9cdc");
			EntitySchemaIndexColumn bulkEmailIdIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("edf2c262-06cc-458a-b2fb-e36ac612d97a"),
				ColumnUId = new Guid("c0c04f91-bec0-4c97-a3e3-341610a1ae2f"),
				CreatedInSchemaUId = new Guid("bcc8d07b-aed8-400b-9bee-a8415c9c81a0"),
				ModifiedInSchemaUId = new Guid("bcc8d07b-aed8-400b-9bee-a8415c9c81a0"),
				CreatedInPackageId = new Guid("196dac4c-8195-4488-a569-0010bfda9cdc"),
				OrderDirection = OrderDirectionStrict.Ascending
			};
			index.Columns.Add(bulkEmailIdIndexColumn);
			EntitySchemaIndexColumn bulkEmailResponseIdIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("97f41f79-138a-4242-b4e2-f87ce7cb7dd4"),
				ColumnUId = new Guid("91b87361-603a-4602-b7dc-09b46423343e"),
				CreatedInSchemaUId = new Guid("bcc8d07b-aed8-400b-9bee-a8415c9c81a0"),
				ModifiedInSchemaUId = new Guid("bcc8d07b-aed8-400b-9bee-a8415c9c81a0"),
				CreatedInPackageId = new Guid("196dac4c-8195-4488-a569-0010bfda9cdc"),
				OrderDirection = OrderDirectionStrict.Ascending
			};
			index.Columns.Add(bulkEmailResponseIdIndexColumn);
			EntitySchemaIndexColumn opensIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("166ddde7-028b-4fab-b8ad-73e98c9e83a8"),
				ColumnUId = new Guid("78e6abd9-ae00-45df-9a15-89e0319c58c8"),
				CreatedInSchemaUId = new Guid("bcc8d07b-aed8-400b-9bee-a8415c9c81a0"),
				ModifiedInSchemaUId = new Guid("bcc8d07b-aed8-400b-9bee-a8415c9c81a0"),
				CreatedInPackageId = new Guid("196dac4c-8195-4488-a569-0010bfda9cdc"),
				OrderDirection = OrderDirectionStrict.Ascending
			};
			index.Columns.Add(opensIndexColumn);
			EntitySchemaIndexColumn clicksIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("eb407152-de53-4d07-a710-1c516ea895d1"),
				ColumnUId = new Guid("d49bd700-f47a-4b08-9922-cd4f490b6489"),
				CreatedInSchemaUId = new Guid("bcc8d07b-aed8-400b-9bee-a8415c9c81a0"),
				ModifiedInSchemaUId = new Guid("bcc8d07b-aed8-400b-9bee-a8415c9c81a0"),
				CreatedInPackageId = new Guid("196dac4c-8195-4488-a569-0010bfda9cdc"),
				OrderDirection = OrderDirectionStrict.Ascending
			};
			index.Columns.Add(clicksIndexColumn);
			EntitySchemaIndexColumn contactIdIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("2d820df5-295e-4cc3-92f1-bd53680e1364"),
				ColumnUId = new Guid("8b85ee02-7cd9-4f86-a938-d44f8fc1d41a"),
				CreatedInSchemaUId = new Guid("bcc8d07b-aed8-400b-9bee-a8415c9c81a0"),
				ModifiedInSchemaUId = new Guid("bcc8d07b-aed8-400b-9bee-a8415c9c81a0"),
				CreatedInPackageId = new Guid("196dac4c-8195-4488-a569-0010bfda9cdc"),
				OrderDirection = OrderDirectionStrict.Ascending
			};
			index.Columns.Add(contactIdIndexColumn);
			return index;
		}

		private EntitySchemaIndex CreateIZfLXi755xdiFC1HcgmoZE6bRiA0Index() {
			EntitySchemaIndex index = new EntitySchemaIndex() {
				IsAutoName = true,
				IsClustered = false,
				IsUnique = false
			};
			index.UId = new Guid("d294278b-b232-49f9-b878-c5f6052a72b4");
			index.Name = "IZfLXi755xdiFC1HcgmoZE6bRiA0";
			index.CreatedInSchemaUId = new Guid("bcc8d07b-aed8-400b-9bee-a8415c9c81a0");
			index.ModifiedInSchemaUId = new Guid("bcc8d07b-aed8-400b-9bee-a8415c9c81a0");
			index.CreatedInPackageId = new Guid("5b53fbff-9be6-434d-a91a-0bac8907d8d7");
			EntitySchemaIndexColumn bulkEmailIdIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("7c4d1a62-cf45-42ff-9e40-cf4929afa934"),
				ColumnUId = new Guid("c0c04f91-bec0-4c97-a3e3-341610a1ae2f"),
				CreatedInSchemaUId = new Guid("bcc8d07b-aed8-400b-9bee-a8415c9c81a0"),
				ModifiedInSchemaUId = new Guid("bcc8d07b-aed8-400b-9bee-a8415c9c81a0"),
				CreatedInPackageId = new Guid("5b53fbff-9be6-434d-a91a-0bac8907d8d7"),
				OrderDirection = OrderDirectionStrict.Ascending
			};
			index.Columns.Add(bulkEmailIdIndexColumn);
			EntitySchemaIndexColumn contactIdIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("e2b4ddfa-0e85-4a5d-be99-7128056a8010"),
				ColumnUId = new Guid("8b85ee02-7cd9-4f86-a938-d44f8fc1d41a"),
				CreatedInSchemaUId = new Guid("bcc8d07b-aed8-400b-9bee-a8415c9c81a0"),
				ModifiedInSchemaUId = new Guid("bcc8d07b-aed8-400b-9bee-a8415c9c81a0"),
				CreatedInPackageId = new Guid("5b53fbff-9be6-434d-a91a-0bac8907d8d7"),
				OrderDirection = OrderDirectionStrict.Ascending
			};
			index.Columns.Add(contactIdIndexColumn);
			EntitySchemaIndexColumn mandrillIdIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("66cfe438-ef6e-483c-873c-d43be9820b9d"),
				ColumnUId = new Guid("357bfa16-8ce0-4384-9903-8a654a337c88"),
				CreatedInSchemaUId = new Guid("bcc8d07b-aed8-400b-9bee-a8415c9c81a0"),
				ModifiedInSchemaUId = new Guid("bcc8d07b-aed8-400b-9bee-a8415c9c81a0"),
				CreatedInPackageId = new Guid("5b53fbff-9be6-434d-a91a-0bac8907d8d7"),
				OrderDirection = OrderDirectionStrict.Ascending
			};
			index.Columns.Add(mandrillIdIndexColumn);
			return index;
		}

		private EntitySchemaIndex CreateIQrPp4zTyUVLdnbTxS6T92jDf4kIndex() {
			EntitySchemaIndex index = new EntitySchemaIndex() {
				IsAutoName = true,
				IsClustered = false,
				IsUnique = false
			};
			index.UId = new Guid("5e174560-0ab8-4543-802e-2f252d8d5e7f");
			index.Name = "IQrPp4zTyUVLdnbTxS6T92jDf4k";
			index.CreatedInSchemaUId = new Guid("bcc8d07b-aed8-400b-9bee-a8415c9c81a0");
			index.ModifiedInSchemaUId = new Guid("bcc8d07b-aed8-400b-9bee-a8415c9c81a0");
			index.CreatedInPackageId = new Guid("c92d8fca-4a0d-4385-86d2-4f5717aa816e");
			EntitySchemaIndexColumn createdOnIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("bc8c86c5-3744-4ecc-9abb-0c9279cdbb9a"),
				ColumnUId = new Guid("e80190a5-03b2-4095-90f7-a193a960adee"),
				CreatedInSchemaUId = new Guid("bcc8d07b-aed8-400b-9bee-a8415c9c81a0"),
				ModifiedInSchemaUId = new Guid("bcc8d07b-aed8-400b-9bee-a8415c9c81a0"),
				CreatedInPackageId = new Guid("c92d8fca-4a0d-4385-86d2-4f5717aa816e"),
				OrderDirection = OrderDirectionStrict.Descending
			};
			index.Columns.Add(createdOnIndexColumn);
			EntitySchemaIndexColumn bulkEmailIdIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("b5f751ac-4123-4c90-af19-0ec7f8bc6533"),
				ColumnUId = new Guid("c0c04f91-bec0-4c97-a3e3-341610a1ae2f"),
				CreatedInSchemaUId = new Guid("bcc8d07b-aed8-400b-9bee-a8415c9c81a0"),
				ModifiedInSchemaUId = new Guid("bcc8d07b-aed8-400b-9bee-a8415c9c81a0"),
				CreatedInPackageId = new Guid("c92d8fca-4a0d-4385-86d2-4f5717aa816e"),
				OrderDirection = OrderDirectionStrict.Ascending
			};
			index.Columns.Add(bulkEmailIdIndexColumn);
			EntitySchemaIndexColumn bulkEmailResponseIdIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("8aeecc95-54dd-470c-9071-c8559e853710"),
				ColumnUId = new Guid("91b87361-603a-4602-b7dc-09b46423343e"),
				CreatedInSchemaUId = new Guid("bcc8d07b-aed8-400b-9bee-a8415c9c81a0"),
				ModifiedInSchemaUId = new Guid("bcc8d07b-aed8-400b-9bee-a8415c9c81a0"),
				CreatedInPackageId = new Guid("c92d8fca-4a0d-4385-86d2-4f5717aa816e"),
				OrderDirection = OrderDirectionStrict.Ascending
			};
			index.Columns.Add(bulkEmailResponseIdIndexColumn);
			EntitySchemaIndexColumn contactIdIndexColumn = new EntitySchemaIndexColumn() {
				UId = new Guid("a825c71d-e3cb-4e30-951d-7fc044ba1738"),
				ColumnUId = new Guid("8b85ee02-7cd9-4f86-a938-d44f8fc1d41a"),
				CreatedInSchemaUId = new Guid("bcc8d07b-aed8-400b-9bee-a8415c9c81a0"),
				ModifiedInSchemaUId = new Guid("bcc8d07b-aed8-400b-9bee-a8415c9c81a0"),
				CreatedInPackageId = new Guid("c92d8fca-4a0d-4385-86d2-4f5717aa816e"),
				OrderDirection = OrderDirectionStrict.Ascending
			};
			index.Columns.Add(contactIdIndexColumn);
			return index;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("bcc8d07b-aed8-400b-9bee-a8415c9c81a0");
			RealUId = new Guid("bcc8d07b-aed8-400b-9bee-a8415c9c81a0");
			Name = "BulkEmailTarget";
			ParentSchemaUId = new Guid("1bab9dcf-17d5-49f8-9536-8e0064f1dce0");
			ExtendParent = false;
			CreatedInPackageId = new Guid("b827f319-d8b8-41a8-9645-da32137f000d");
			IsDBView = false;
			UseDenyRecordRights = false;
			UseRecordDeactivation = false;
		}

		protected override void InitializeColumns() {
			base.InitializeColumns();
			if (Columns.FindByUId(new Guid("c0c04f91-bec0-4c97-a3e3-341610a1ae2f")) == null) {
				Columns.Add(CreateBulkEmailColumn());
			}
			if (Columns.FindByUId(new Guid("8b85ee02-7cd9-4f86-a938-d44f8fc1d41a")) == null) {
				Columns.Add(CreateContactColumn());
			}
			if (Columns.FindByUId(new Guid("b7bd7279-4f36-41f7-8b24-d0db933828ee")) == null) {
				Columns.Add(CreateEmailAddressColumn());
			}
			if (Columns.FindByUId(new Guid("91b87361-603a-4602-b7dc-09b46423343e")) == null) {
				Columns.Add(CreateBulkEmailResponseColumn());
			}
			if (Columns.FindByUId(new Guid("78e6abd9-ae00-45df-9a15-89e0319c58c8")) == null) {
				Columns.Add(CreateOpensColumn());
			}
			if (Columns.FindByUId(new Guid("d49bd700-f47a-4b08-9922-cd4f490b6489")) == null) {
				Columns.Add(CreateClicksColumn());
			}
			if (Columns.FindByUId(new Guid("357bfa16-8ce0-4384-9903-8a654a337c88")) == null) {
				Columns.Add(CreateMandrillIdColumn());
			}
		}

		protected override EntitySchemaColumn CreateIdColumn() {
			EntitySchemaColumn column = base.CreateIdColumn();
			column.ModifiedInSchemaUId = new Guid("bcc8d07b-aed8-400b-9bee-a8415c9c81a0");
			column.CreatedInPackageId = new Guid("b827f319-d8b8-41a8-9645-da32137f000d");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedOnColumn() {
			EntitySchemaColumn column = base.CreateCreatedOnColumn();
			column.ModifiedInSchemaUId = new Guid("bcc8d07b-aed8-400b-9bee-a8415c9c81a0");
			column.CreatedInPackageId = new Guid("b827f319-d8b8-41a8-9645-da32137f000d");
			return column;
		}

		protected override EntitySchemaColumn CreateCreatedByColumn() {
			EntitySchemaColumn column = base.CreateCreatedByColumn();
			column.ModifiedInSchemaUId = new Guid("bcc8d07b-aed8-400b-9bee-a8415c9c81a0");
			column.CreatedInPackageId = new Guid("b827f319-d8b8-41a8-9645-da32137f000d");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedOnColumn() {
			EntitySchemaColumn column = base.CreateModifiedOnColumn();
			column.ModifiedInSchemaUId = new Guid("bcc8d07b-aed8-400b-9bee-a8415c9c81a0");
			column.CreatedInPackageId = new Guid("b827f319-d8b8-41a8-9645-da32137f000d");
			return column;
		}

		protected override EntitySchemaColumn CreateModifiedByColumn() {
			EntitySchemaColumn column = base.CreateModifiedByColumn();
			column.ModifiedInSchemaUId = new Guid("bcc8d07b-aed8-400b-9bee-a8415c9c81a0");
			column.CreatedInPackageId = new Guid("b827f319-d8b8-41a8-9645-da32137f000d");
			return column;
		}

		protected override EntitySchemaColumn CreateProcessListenersColumn() {
			EntitySchemaColumn column = base.CreateProcessListenersColumn();
			column.ModifiedInSchemaUId = new Guid("bcc8d07b-aed8-400b-9bee-a8415c9c81a0");
			column.CreatedInPackageId = new Guid("b827f319-d8b8-41a8-9645-da32137f000d");
			return column;
		}

		protected virtual EntitySchemaColumn CreateBulkEmailColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("c0c04f91-bec0-4c97-a3e3-341610a1ae2f"),
				Name = @"BulkEmail",
				ReferenceSchemaUId = new Guid("95fbcf9c-e36d-4acd-8b5a-d657de6e30a8"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				IsIndexed = true,
				IsCascade = true,
				CreatedInSchemaUId = new Guid("bcc8d07b-aed8-400b-9bee-a8415c9c81a0"),
				ModifiedInSchemaUId = new Guid("bcc8d07b-aed8-400b-9bee-a8415c9c81a0"),
				CreatedInPackageId = new Guid("b827f319-d8b8-41a8-9645-da32137f000d")
			};
		}

		protected virtual EntitySchemaColumn CreateContactColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("8b85ee02-7cd9-4f86-a938-d44f8fc1d41a"),
				Name = @"Contact",
				ReferenceSchemaUId = new Guid("16be3651-8fe2-4159-8dd0-a803d4683dd3"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("bcc8d07b-aed8-400b-9bee-a8415c9c81a0"),
				ModifiedInSchemaUId = new Guid("bcc8d07b-aed8-400b-9bee-a8415c9c81a0"),
				CreatedInPackageId = new Guid("06c5e2cb-107e-4211-a5bd-01241dc3944b")
			};
		}

		protected virtual EntitySchemaColumn CreateEmailAddressColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("MediumText")) {
				UId = new Guid("b7bd7279-4f36-41f7-8b24-d0db933828ee"),
				Name = @"EmailAddress",
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("bcc8d07b-aed8-400b-9bee-a8415c9c81a0"),
				ModifiedInSchemaUId = new Guid("bcc8d07b-aed8-400b-9bee-a8415c9c81a0"),
				CreatedInPackageId = new Guid("b827f319-d8b8-41a8-9645-da32137f000d")
			};
		}

		protected virtual EntitySchemaColumn CreateBulkEmailResponseColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Lookup")) {
				UId = new Guid("91b87361-603a-4602-b7dc-09b46423343e"),
				Name = @"BulkEmailResponse",
				ReferenceSchemaUId = new Guid("2ff5127a-ca8a-4515-aeb0-d2ded9168aed"),
				RequirementType = EntitySchemaColumnRequirementType.ApplicationLevel,
				CreatedInSchemaUId = new Guid("bcc8d07b-aed8-400b-9bee-a8415c9c81a0"),
				ModifiedInSchemaUId = new Guid("bcc8d07b-aed8-400b-9bee-a8415c9c81a0"),
				CreatedInPackageId = new Guid("b827f319-d8b8-41a8-9645-da32137f000d"),
				DefValue = new EntitySchemaColumnDef() {
					Source = EntitySchemaColumnDefSource.Const,
					ValueSource = @"14769602-ebda-40b1-91d5-ea9d623e2400"
				}
			};
		}

		protected virtual EntitySchemaColumn CreateOpensColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("78e6abd9-ae00-45df-9a15-89e0319c58c8"),
				Name = @"Opens",
				CreatedInSchemaUId = new Guid("bcc8d07b-aed8-400b-9bee-a8415c9c81a0"),
				ModifiedInSchemaUId = new Guid("bcc8d07b-aed8-400b-9bee-a8415c9c81a0"),
				CreatedInPackageId = new Guid("b827f319-d8b8-41a8-9645-da32137f000d")
			};
		}

		protected virtual EntitySchemaColumn CreateClicksColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Integer")) {
				UId = new Guid("d49bd700-f47a-4b08-9922-cd4f490b6489"),
				Name = @"Clicks",
				CreatedInSchemaUId = new Guid("bcc8d07b-aed8-400b-9bee-a8415c9c81a0"),
				ModifiedInSchemaUId = new Guid("bcc8d07b-aed8-400b-9bee-a8415c9c81a0"),
				CreatedInPackageId = new Guid("b827f319-d8b8-41a8-9645-da32137f000d")
			};
		}

		protected virtual EntitySchemaColumn CreateMandrillIdColumn() {
			return new EntitySchemaColumn(this, DataValueTypeManager.GetInstanceByName("Guid")) {
				UId = new Guid("357bfa16-8ce0-4384-9903-8a654a337c88"),
				Name = @"MandrillId",
				UsageType = EntitySchemaColumnUsageType.None,
				CreatedInSchemaUId = new Guid("bcc8d07b-aed8-400b-9bee-a8415c9c81a0"),
				ModifiedInSchemaUId = new Guid("bcc8d07b-aed8-400b-9bee-a8415c9c81a0"),
				CreatedInPackageId = new Guid("b827f319-d8b8-41a8-9645-da32137f000d")
			};
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeIndexes() {
			base.InitializeIndexes();
			Indexes.Add(CreateIz3ZNsqNDC7R9KMZoEDNjjOoX60Index());
			Indexes.Add(CreateIbUkCjRUBPrSECidIkGlST9IQkIndex());
			Indexes.Add(CreateIZfLXi755xdiFC1HcgmoZE6bRiA0Index());
			Indexes.Add(CreateIQrPp4zTyUVLdnbTxS6T92jDf4kIndex());
		}

		protected override void InitializeEventsProcessSchema() {
			EventsProcessSchema = CreateBulkEmailTargetEventsProcessSchema();
		}

		protected virtual ProcessSchema CreateBulkEmailTargetEventsProcessSchema() {
			var schema = new BulkEmailTargetEventsProcessSchema(ProcessSchemaManager, this);
			schema.InitializePrimaryInfo();
			return schema;
		}

		#endregion

		#region Methods: Public

		public override Entity CreateEntity(UserConnection userConnection) {
			return new BulkEmailTarget(userConnection){Schema = this};
		}

		public override EmbeddedProcess CreateEventsProcess(UserConnection userConnnection) {
			return 
			new BulkEmailTarget_MarketingCampaignEventsProcess(userConnnection);
		}

		public override object Clone() {
			return new BulkEmailTargetSchema(this);
		}

		public override EntitySchema CloneShallow() {
			return new BulkEmailTargetSchema(this, true);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("bcc8d07b-aed8-400b-9bee-a8415c9c81a0"));
		}

		#endregion

	}

	#endregion

	#region Class: BulkEmailTarget

	/// <summary>
	/// Response in Email.
	/// </summary>
	public class BulkEmailTarget : Terrasoft.Configuration.BaseEntity
	{

		#region Constructors: Public

		public BulkEmailTarget(UserConnection userConnection)
			: base(userConnection) {
			SchemaName = "BulkEmailTarget";
		}

		public BulkEmailTarget(BulkEmailTarget source)
			: base(source) {
		}

		#endregion

		#region Properties: Public

		/// <exclude/>
		public Guid BulkEmailId {
			get {
				return GetTypedColumnValue<Guid>("BulkEmailId");
			}
			set {
				SetColumnValue("BulkEmailId", value);
				_bulkEmail = null;
			}
		}

		/// <exclude/>
		public string BulkEmailName {
			get {
				return GetTypedColumnValue<string>("BulkEmailName");
			}
			set {
				SetColumnValue("BulkEmailName", value);
				if (_bulkEmail != null) {
					_bulkEmail.Name = value;
				}
			}
		}

		private BulkEmail _bulkEmail;
		/// <summary>
		/// Bulk email.
		/// </summary>
		public BulkEmail BulkEmail {
			get {
				return _bulkEmail ??
					(_bulkEmail = LookupColumnEntities.GetEntity("BulkEmail") as BulkEmail);
			}
		}

		/// <exclude/>
		public Guid ContactId {
			get {
				return GetTypedColumnValue<Guid>("ContactId");
			}
			set {
				SetColumnValue("ContactId", value);
				_contact = null;
			}
		}

		/// <exclude/>
		public string ContactName {
			get {
				return GetTypedColumnValue<string>("ContactName");
			}
			set {
				SetColumnValue("ContactName", value);
				if (_contact != null) {
					_contact.Name = value;
				}
			}
		}

		private Contact _contact;
		/// <summary>
		/// Contact.
		/// </summary>
		public Contact Contact {
			get {
				return _contact ??
					(_contact = LookupColumnEntities.GetEntity("Contact") as Contact);
			}
		}

		/// <summary>
		/// Email address.
		/// </summary>
		public string EmailAddress {
			get {
				return GetTypedColumnValue<string>("EmailAddress");
			}
			set {
				SetColumnValue("EmailAddress", value);
			}
		}

		/// <exclude/>
		public Guid BulkEmailResponseId {
			get {
				return GetTypedColumnValue<Guid>("BulkEmailResponseId");
			}
			set {
				SetColumnValue("BulkEmailResponseId", value);
				_bulkEmailResponse = null;
			}
		}

		/// <exclude/>
		public string BulkEmailResponseName {
			get {
				return GetTypedColumnValue<string>("BulkEmailResponseName");
			}
			set {
				SetColumnValue("BulkEmailResponseName", value);
				if (_bulkEmailResponse != null) {
					_bulkEmailResponse.Name = value;
				}
			}
		}

		private BulkEmailResponse _bulkEmailResponse;
		/// <summary>
		/// Response.
		/// </summary>
		public BulkEmailResponse BulkEmailResponse {
			get {
				return _bulkEmailResponse ??
					(_bulkEmailResponse = LookupColumnEntities.GetEntity("BulkEmailResponse") as BulkEmailResponse);
			}
		}

		/// <summary>
		/// Opens.
		/// </summary>
		public int Opens {
			get {
				return GetTypedColumnValue<int>("Opens");
			}
			set {
				SetColumnValue("Opens", value);
			}
		}

		/// <summary>
		/// Clicks.
		/// </summary>
		public int Clicks {
			get {
				return GetTypedColumnValue<int>("Clicks");
			}
			set {
				SetColumnValue("Clicks", value);
			}
		}

		/// <summary>
		/// MandrillId.
		/// </summary>
		public Guid MandrillId {
			get {
				return GetTypedColumnValue<Guid>("MandrillId");
			}
			set {
				SetColumnValue("MandrillId", value);
			}
		}

		#endregion

		#region Methods: Protected

		protected override Process InitializeEmbeddedProcess() {
			var process = new BulkEmailTarget_MarketingCampaignEventsProcess(UserConnection);
			process.Entity = this;
			return process;
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeThrowEvents() {
			Deleted += (s, e) => ThrowEvent("BulkEmailTargetDeleted", e);
			Inserting += (s, e) => ThrowEvent("BulkEmailTargetInserting", e);
			Validating += (s, e) => ThrowEvent("BulkEmailTargetValidating", e);
			base.InitializeThrowEvents();
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new BulkEmailTarget(this);
		}

		#endregion

	}

	#endregion

	#region Class: BulkEmailTarget_MarketingCampaignEventsProcess

	/// <exclude/>
	public class BulkEmailTarget_MarketingCampaignEventsProcess<TEntity> : Terrasoft.Configuration.BaseEntity_LocalMessageEventsProcess<TEntity> where TEntity : BulkEmailTarget
	{

		public BulkEmailTarget_MarketingCampaignEventsProcess(UserConnection userConnection)
			: base(userConnection) {
			InitializeMetaPathParameterValues();
			UId = Guid.NewGuid();
			Name = "BulkEmailTarget_MarketingCampaignEventsProcess";
			SchemaUId = new Guid("bcc8d07b-aed8-400b-9bee-a8415c9c81a0");
			SchemaManagerName = "EntitySchemaManager";
			SerializeToDB = false;
			IsLogging = false;
			InitializeFlowElements();
		}

		#region Properties: Private

		private Guid InternalSchemaUId {
			get {
				return new Guid("bcc8d07b-aed8-400b-9bee-a8415c9c81a0");
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

	#region Class: BulkEmailTarget_MarketingCampaignEventsProcess

	/// <exclude/>
	public class BulkEmailTarget_MarketingCampaignEventsProcess : BulkEmailTarget_MarketingCampaignEventsProcess<BulkEmailTarget>
	{

		public BulkEmailTarget_MarketingCampaignEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

	#region Class: BulkEmailTargetEventsProcessSchema

	/// <exclude/>
	public class BulkEmailTargetEventsProcessSchema : Terrasoft.Configuration.BaseEntityEventsProcessSchema
	{

		#region Constructors: Public

		public BulkEmailTargetEventsProcessSchema(ProcessSchemaManager processSchemaManager, ProcessBasedSchema ownerSchema)
			: base(processSchemaManager, ownerSchema) {
		}

		public BulkEmailTargetEventsProcessSchema(BulkEmailTargetEventsProcessSchema source)
			: base(source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			Name = "BulkEmailTarget_MarketingCampaignEventsProcess";
			UId = new Guid("b3fd66fe-fe55-4553-8dcf-a3c0fac99f18");
			CreatedInPackageId = new Guid("b827f319-d8b8-41a8-9645-da32137f000d");
			CreatedInSchemaUId = Guid.Empty;
			CultureName = null;
			EntitySchemaUId = Guid.Empty;
			IsCreatedInSvg = true;
			IsInterpretable = true;
			ModifiedInSchemaUId = Guid.Empty;
			ParametersEditPageSchemaUId = Guid.Empty;
			ParentSchemaUId = new Guid("7bb7d6a5-e7a3-4837-83bc-7f785d688165");
			SequenceFlowStrokeDefColor = Color.FromArgb(-4473925);
			TaskFillDefColor = Color.FromArgb(-1);
			UsageType = ProcessSchemaUsageType.Advanced;
		}

		protected override void InitializeParameters() {
			base.InitializeParameters();
		}

		protected override void InitializeBaseElements() {
			base.InitializeBaseElements();
		}

		protected override void InitializeMethods() {
			base.InitializeMethods();
			SetMethodsDefInheritance();
		}

		protected override void InitializeUsings() {
			Usings.Add(new SchemaUsing() {
				UId = new Guid("fb7b81ba-7c3c-45a5-ae9e-c6c03dceb812"),
				Name = "Terrasoft.UI.WebControls.Controls",
				Alias = "",
				CreatedInPackageId = new Guid("b827f319-d8b8-41a8-9645-da32137f000d")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("cde525cf-d220-4d2a-b963-e55254c639fc"),
				Name = "Terrasoft.UI.WebControls.Utilities.Json.Converters",
				Alias = "",
				CreatedInPackageId = new Guid("b827f319-d8b8-41a8-9645-da32137f000d")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("5c9c82c6-ba6d-4a57-9a14-87fe8faa4ebb"),
				Name = "Terrasoft.Core.DB",
				Alias = "",
				CreatedInPackageId = new Guid("b827f319-d8b8-41a8-9645-da32137f000d")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("7821de68-c82b-4917-a6cd-add2adfbe400"),
				Name = "Terrasoft.Common",
				Alias = "",
				CreatedInPackageId = new Guid("b827f319-d8b8-41a8-9645-da32137f000d")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("d67de76f-9cbc-4bfc-babb-6f65cb89b973"),
				Name = "System.Data",
				Alias = "",
				CreatedInPackageId = new Guid("b827f319-d8b8-41a8-9645-da32137f000d")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("74160d3b-65e3-4694-b554-089f2d980e54"),
				Name = "Newtonsoft.Json",
				Alias = "",
				CreatedInPackageId = new Guid("b827f319-d8b8-41a8-9645-da32137f000d")
			});
			Usings.Add(new SchemaUsing() {
				UId = new Guid("e401300a-9f16-40c2-9788-cf310ae9d1c5"),
				Name = "Terrasoft.Common.Json",
				Alias = "",
				CreatedInPackageId = new Guid("b827f319-d8b8-41a8-9645-da32137f000d")
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
		}

		#endregion

		#region Methods: Public

		public override object Clone() {
			return new BulkEmailTargetEventsProcessSchema(this);
		}

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b3fd66fe-fe55-4553-8dcf-a3c0fac99f18"));
		}

		#endregion

	}

	#endregion


	#region Class: BulkEmailTargetEventsProcess

	/// <exclude/>
	public class BulkEmailTargetEventsProcess : BulkEmailTarget_MarketingCampaignEventsProcess
	{

		public BulkEmailTargetEventsProcess(UserConnection userConnection)
			: base(userConnection) {
		}

	}

	#endregion

}

