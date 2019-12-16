namespace Terrasoft.Configuration
{
	using System;
	using System.Collections.Generic;
	using System.Data;
	using System.Linq;
	using Terrasoft.Common;
	using Terrasoft.Core.Attributes;
	using Terrasoft.Core.Campaign.EventHandler;
	using CoreCampaignSchema = Core.Campaign.CampaignSchema;

	/// <summary>
	/// Contains methods for maintaining event elements in campaign.
	/// </summary>
	public sealed class EventElementHandler : CampaignEventHandlerBase, IOnCampaignCopy, IOnCampaignAfterSave
	{

		#region Constants: Private

		private const string ElementHandlerName = nameof(EventElementHandler);

		#endregion

		#region Fields: Private

		private Guid _eventSchemaUId = new Guid("5B4FDFC7-12B6-4B4F-A9BD-B6F1B6E4447F");

		#endregion

		#region Methods: Private

		private IEnumerable<CampaignEventElement> GetEventElements(CoreCampaignSchema schema) {
			return schema.FlowElements.OfType<CampaignEventElement>();
		}

		private IEnumerable<CampaignEventElement> GetModifiedEventElements() {
			var currentElements = GetEventElements(CampaignSchema);
			if (CampaignSchema.InitialSchema == null) {
				return currentElements;
			}
			var initialElements = GetEventElements(CampaignSchema.InitialSchema);
			var sameElements = initialElements.Join(currentElements,
					initial => initial.UId,
					current => current.UId,
					(initial, current) => (initial.EventId == current.EventId, current))
				.Where(x => x.Item1)
				.Select(x => x.Item2);
			return currentElements.Except(sameElements);
		}

		private void UpdateConnectedEventInfo(IEnumerable<CampaignEventElement> elements) {
			foreach (var element in elements) {
				var eventId = element.EventId.IsEmpty() ? null as Guid? : element.EventId;
				UpdateCampaignItemConnectedRecordInfo(element.UId, _eventSchemaUId, eventId);
			}
		}

		#endregion

		#region Methods: Public

		/// <summary>
		/// Updates connected records info (RecordId and SchemaUId fields) after campaign has been copied.
		/// </summary>
		[Order(2)]
		public void OnCopy() {
			try {
				var allElements = GetEventElements(CampaignSchema);
				UpdateConnectedEventInfo(allElements);
			} catch (Exception ex) {
				CampaignLogger.ErrorFormat(ElementHandlerName, ex, CampaignSchema.EntityId);
				throw;
			}
		}

		/// <summary>
		/// Updates connected records info (RecordId and SchemaUId fields) after campaign has been saved.
		/// </summary>
		public void OnAfterSave() {
			try {
				var modifiedElements = GetModifiedEventElements();
				UpdateConnectedEventInfo(modifiedElements);
			} catch (Exception ex) {
				CampaignLogger.ErrorFormat(ElementHandlerName, ex, CampaignSchema.EntityId);
				throw;
			}
		}

		#endregion

	}

}
