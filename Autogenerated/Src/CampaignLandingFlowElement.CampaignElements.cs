namespace Terrasoft.Configuration
{
	using System;
	using Terrasoft.Core.Campaign;
	using Terrasoft.Core.DB;

	#region Class: CampaignLandingFlowElement

	/// <summary>
	/// Executable landing page element that filters audience due to landing entities.
	/// </summary>
	public class CampaignLandingFlowElement : CampaignFlowElement
	{

		#region Properties: Public

		/// <summary>
		/// The unique identifier of a current web form.
		/// </summary>
		public Guid LandingId { get; set; }

		#endregion

		#region Methods: Protecteds

		/// <summary>
		/// Contains custom logic for <see cref="AudieceQuery"/> initialization.
		/// </summary>
		/// <returns>Initialized <see cref="Query"/> to use as campaign audience.</returns>
		protected override Query GetAudienceQuery() {
			var selectModel = LandingContactQueryProvider.GetSelectModel(LandingId, UserConnection);
			var participantsSelect = base.GetAudienceQuery();
			participantsSelect.And(CampaignParticipantTable, "ContactId").In(selectModel.ContactSelect);
			return participantsSelect;
		}

		#endregion

	}

	#endregion

}

