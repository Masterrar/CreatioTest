namespace Terrasoft.Configuration
{
	using System.Collections.Generic;
	using System.Linq;
	using Terrasoft.Core.Attributes;
	using Terrasoft.Core.Campaign;
	using Terrasoft.Core.Campaign.EventHandler;
	using CoreCampaignSchema = Core.Campaign.CampaignSchema;

	/// <summary>
	/// Contains methods for maintaining Add Audience elements in campaign.
	/// </summary>
	public sealed class AddCampaignAudienceElementHandler : BaseCampaignAudienceElementHandler, IOnCampaignValidate
	{

		#region Constructors: Public

		public AddCampaignAudienceElementHandler() {
			elementHandlerName = GetType().Name;
		}

		#endregion

		#region Methods: Protected

		/// <summary>
		/// Returns the list of <see cref="AddCampaignParticipantElement"/> campaign audience elements.
		/// </summary>
		/// <param name="schema">Campaign schema instance.</param>
		/// <returns>List of concrete campaign audience elements.</returns>
		protected override IEnumerable<BaseCampaignAudienceElement> GetAudienceElements(CoreCampaignSchema schema) {
			return schema.FlowElements.OfType<AddCampaignParticipantElement>();
		}

		#endregion

		#region Methods: Public

		/// <summary>
		/// Validates Add Audience elements on campaign validation. Searches folders with no conditions.
		/// </summary>
		[Order(1)]
		public void OnValidate() {
			var elements = GetAudienceElements(CampaignSchema);
			if (!elements.Any()) {
				return;
			}
			var folders = LoadFoldersInfo(elements);
			CheckFoldersExistense(elements, folders);
			var foldersWithNoFilter = FindFoldersWithNoFilter(folders);
			string message = GetLczStringValue(elementHandlerName, "FolderWithNoConditionWarning");
			WriteValidationInfo(elements, foldersWithNoFilter, message, CampaignValidationInfoLevel.Warning);
		}

		#endregion

	}
}

