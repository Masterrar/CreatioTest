namespace Terrasoft.Configuration
{
	using System;
	using Terrasoft.Core.DB;

	#region Class: CampaignAddLandingAudienceFlowElement

	/// <summary>
	/// Executable add Landing audience element.
	/// </summary>
	public class CampaignAddLandingAudienceFlowElement : BaseCampaignAudienceFlowElement
	{

		#region Properties: Protected

		/// <summary>
		/// ContactId column name alias at original select to add audience in campaign.
		/// </summary>
		protected override string SourceSelectContactIdColumnName { get; set; }

		#endregion

		#region Properties: Public

		/// <summary>
		/// Unique identifier of Landing.
		/// </summary>
		public Guid LandingId { get; set; }

		#endregion

		#region Methods: Protected

		/// <summary>
		/// Defines <see cref="AudienceQuery"/> for add new participants in campaign.
		/// </summary>
		/// <returns><see cref="Select"/> query which returns contacts for add in campaign.</returns>
		protected override Select GetContactsSelect() {
			var selectModel = LandingContactQueryProvider.GetSelectModel(LandingId, UserConnection);
			SourceSelectContactIdColumnName = selectModel.ContactIdColumnName;
			return selectModel.ContactSelect;
		}

		#endregion

	}

	#endregion

}

