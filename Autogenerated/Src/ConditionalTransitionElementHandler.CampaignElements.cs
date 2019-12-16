namespace Terrasoft.Configuration
{
	using System;
	using System.Collections.Generic;
	using System.Data;
	using System.Linq;
	using System.Text;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Attributes;
	using Terrasoft.Core.Campaign;
	using Terrasoft.Core.Campaign.EventHandler;
	using Terrasoft.Core.DB;

	#region Class: ConditionalTransitionElementHandler

	/// <summary>
	/// Class to handle campaign events on all conditional transition elements of campaign schema.
	/// </summary>
	public sealed class ConditionalTransitionElementHandler : CampaignEventHandlerBase, IOnCampaignBeforeSave, IOnCampaignCopy
	{

		#region Constants: Public

		/// <summary>
		/// Name of current transition element handler.
		/// </summary>
		public const string TransitionElementHandlerName = "TransitionElementHandler";

		#endregion

		#region Methods: Private

		private IEnumerable<Guid> GetExistingFolderIds(IEnumerable<Guid> folderIds) {
			var existingItems = new List<Guid>();
			if (folderIds == null || folderIds.IsEmpty()) {
				return existingItems;
			}
			var exisitingItemsSelect = new Select(UserConnection)
				.Column("Id")
				.From("ContactFolder")
				.Where("ContactFolder", "Id")
					.In(Column.Parameters(folderIds)) as Select;
			exisitingItemsSelect.SpecifyNoLockHints();
			exisitingItemsSelect.ExecuteReader(reader => existingItems.Add(reader.GetColumnValue<Guid>("Id")));
			return existingItems;
		}

		private void InsertContactFolders(IEnumerable<Tuple<Guid, byte[]>> dataToInsert, Guid campaignId) {
			foreach (var data in dataToInsert) {
				InsertContactFolder(data, campaignId);
			}
		}

		private void InsertContactFolder(Tuple<Guid, byte[]> data, Guid campaignId) {
			var folderName = string.Format("{0}_{1}", campaignId, data.Item1);
			new Insert(UserConnection)
				.Into("ContactFolder")
				.Set("Id", Column.Parameter(data.Item1))
				.Set("Name", Column.Parameter(folderName))
				.Set("CreatedById", Column.Parameter(UserConnection.CurrentUser.ContactId))
				.Set("ModifiedById", Column.Parameter(UserConnection.CurrentUser.ContactId))
				.Set("FolderTypeId", Column.Parameter(MarketingConsts.FolderTypeDynamicId))
				.Set("ParentId", Column.Parameter(MarketingConsts.CampaignFiltersContactFolderId))
				.Set("SearchData", Column.Parameter(data.Item2))
				.Execute();
		}

		private void DeleteContactFolders(IEnumerable<Guid> folderIds) {
			new Delete(UserConnection)
				.From("ContactFolder")
				.Where("ContactFolder", "Id")
					.In(Column.Parameters(folderIds))
				.Execute();
		}

		private void UpdateContactFolders(IEnumerable<Tuple<Guid, byte[]>> dataToUpdate) {
			foreach (var data in dataToUpdate) {
				new Update(UserConnection, "ContactFolder")
					.WithHints(new RowLockHint())
					.Set("ModifiedById", Column.Parameter(UserConnection.CurrentUser.ContactId))
					.Set("ModifiedOn", Column.Parameter(DateTime.UtcNow))
					.Set("SearchData", Column.Parameter(data.Item2))
					.Where("ContactFolder", "Id").IsEqual(Column.Parameter(data.Item1))
					.Execute();
			}
		}

		private void ActualizeContactFolders() {
			if (CampaignSchema == null) {
				return;
			}
			var transitionsFromSchema = CampaignSchema.FlowElements
				.Where(x => x.ElementType.HasFlag(CampaignSchemaElementType.Transition)
					&& x is ConditionalSequenceFlowElement
					&& (x as ConditionalSequenceFlowElement).FilterId != Guid.Empty
					&& (x as ConditionalSequenceFlowElement).HasFilter
					&& (x as ConditionalSequenceFlowElement).IsFilterChanged)
				.Select(x => x as ConditionalSequenceFlowElement);
			IEnumerable<Guid> idsFromSchema = transitionsFromSchema.Select(x => x.FilterId);
			IEnumerable<Guid> idsToUpdate = GetExistingFolderIds(idsFromSchema);
			IEnumerable<Guid> idsToInsert = idsFromSchema.Except(idsToUpdate);
			var dataToInsert = transitionsFromSchema
				.Where(x => idsToInsert.Contains(x.FilterId))
				.Select(x => new Tuple<Guid, byte[]>(x.FilterId, Encoding.UTF8.GetBytes(x.Filter ?? "")));
			var dataToUpdate = transitionsFromSchema
				.Where(x => idsToUpdate.Contains(x.FilterId))
				.Select(x => new Tuple<Guid, byte[]>(x.FilterId, Encoding.UTF8.GetBytes(x.Filter ?? "")));
			UpdateContactFolders(dataToUpdate);
			InsertContactFolders(dataToInsert, CampaignSchema.EntityId);
		}

		private void RemoveUnusedContactFolders() {
			if (CampaignSchema == null
					|| CampaignSchema.InitialSchema == null
					|| CampaignSchema.InitialSchema.FlowElements == null) {
				return;
			}
			IEnumerable<Guid> actualFolderIds =
				CampaignSchema.FlowElements
					.Where(x => x.ElementType.HasFlag(CampaignSchemaElementType.Transition)
						&& x is ConditionalSequenceFlowElement)
					.Select(x => (x as ConditionalSequenceFlowElement).FilterId);
			IEnumerable<Guid> folderIdsToDelete =
				CampaignSchema.InitialSchema.FlowElements
					.Where(x => x.ElementType.HasFlag(CampaignSchemaElementType.Transition)
						&& x is ConditionalSequenceFlowElement
						&& (x as ConditionalSequenceFlowElement).FilterId.IsNotEmpty())
					.Select(x => (x as ConditionalSequenceFlowElement).FilterId)
					.Except(actualFolderIds);
			if (folderIdsToDelete.Any()) {
				DeleteContactFolders(folderIdsToDelete);
			}
		}

		private Dictionary<Guid, byte[]> GetExistingSearchData(IEnumerable<Guid> folderIds) {
			var existingItems = new Dictionary<Guid, byte[]>();
			if (folderIds == null || folderIds.IsEmpty()) {
				return existingItems;
			}
			var exisitngItemsSelect = new Select(UserConnection)
				.Column("Id")
				.Column("SearchData")
				.From("ContactFolder")
				.Where("ContactFolder", "Id")
					.In(Column.Parameters(folderIds)) as Select;
			exisitngItemsSelect.SpecifyNoLockHints();
			exisitngItemsSelect.ExecuteReader(
				reader => {
					Guid id = reader.GetColumnValue<Guid>("Id");
					byte[] searchData = reader.GetColumnValue("SearchData") as byte[];
					existingItems.Add(id, searchData);
				});
			return existingItems;
		}

		private Guid CreateContactFolder(byte[] searchData) {
			var folderId = Guid.NewGuid();
			var dataToInsert = new Tuple<Guid, byte[]>(folderId, searchData);
			InsertContactFolder(dataToInsert, CampaignSchema.EntityId);
			return folderId;
		}

		private void CreateAndBindContactFolders() {
			if (CampaignSchema == null) {
				return;
			}
			IEnumerable<ConditionalSequenceFlowElement> transitions = CampaignSchema.FlowElements
				.Where(x => x.ElementType.HasFlag(CampaignSchemaElementType.Transition)
					&& x is ConditionalSequenceFlowElement
					&& (x as ConditionalSequenceFlowElement).FilterId != Guid.Empty
					&& (x as ConditionalSequenceFlowElement).HasFilter)
				.Select(x => x as ConditionalSequenceFlowElement);
			IEnumerable<Guid> folderIds = transitions.Select(x => x.FilterId);
			Dictionary<Guid, byte[]> existingFolders = GetExistingSearchData(folderIds);
			foreach (var transition in transitions.Where(x => existingFolders.Keys.Contains(x.FilterId))) {
				byte[] searchData = existingFolders[transition.FilterId];
				Guid folderCopyId = CreateContactFolder(searchData);
				transition.FilterId = folderCopyId;
				transition.IsFilterChanged = false;
			}
		}

		#endregion

		#region Methods: Public

		/// <summary>
		/// Actualizes transition's data before saving campaign schema.
		/// </summary>
		[Order(1)]
		public void OnBeforeSave() {
			try {
				ActualizeContactFolders();
				RemoveUnusedContactFolders();
			} catch (Exception ex) {
				string message = GetLczStringValue(TransitionElementHandlerName, "OnBeforeSaveException");
				CampaignLogger.ErrorFormat(message, ex, CampaignSchema.EntityId);
				throw;
			}
		}

		/// <summary>
		/// Creates copy of transitions' data and links it to transitions.
		/// </summary>
		[Order(2)]
		public void OnCopy() {
			try {
				CreateAndBindContactFolders();
			} catch (Exception ex) {
				string message = GetLczStringValue(TransitionElementHandlerName, "OnCopyException");
				CampaignLogger.ErrorFormat(message, ex, CampaignSchema.EntityId);
				throw;
			}
		}

		#endregion

	}

	#endregion

}

