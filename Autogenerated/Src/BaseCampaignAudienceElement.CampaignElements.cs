namespace Terrasoft.Configuration
{
	using System;
	using System.Collections.Generic;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Campaign;
	using Terrasoft.Core.Process;

	#region Class: BaseCampaignAudienceElement

	/// <summary>
	/// Element that appends participants to campaign.
	/// </summary>
	[DesignModeProperty(Name = "FolderId",
		UsageType = DesignModeUsageType.NotVisible, MetaPropertyName = FolderPropertyName)]
	public class BaseCampaignAudienceElement : CampaignSchemaElement
	{

		#region Constants: Protected

		/// <summary>
		/// Folder identifier property name.
		/// </summary>
		protected const string FolderPropertyName = "FolderId";

		#endregion

		#region Constructors: Protected

		/// <summary>
		/// Default constructor for <see cref="BaseCampaignAudienceElement"/>.
		/// </summary>
		protected BaseCampaignAudienceElement() {
		}

		/// <summary>
		/// Constructor for <see cref="BaseCampaignAudienceElement"/>.
		/// </summary>
		/// <param name="source">Instance of <see cref="BaseCampaignAudienceElement"/>.</param>
		protected BaseCampaignAudienceElement(BaseCampaignAudienceElement source)
				: this(source, null, null) {
		}

		/// <summary>
		/// Constructor for <see cref="BaseCampaignAudienceElement"/>.
		/// </summary>
		/// <param name="source">Instance of <see cref="BaseCampaignAudienceElement"/>.</param>
		/// <param name="dictToRebind">Dictionary to rebind schema elements' ids.</param>
		/// <param name="parentSchema">Parent campaign schema.</param>
		protected BaseCampaignAudienceElement(BaseCampaignAudienceElement source,
				Dictionary<Guid, Guid> dictToRebind, Core.Campaign.CampaignSchema parentSchema)
					: base(source, dictToRebind, parentSchema) {
			FolderId = source.FolderId;
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Unique identifier of binded contact folder.
		/// </summary>
		[MetaTypeProperty("{7A6D4FAC-C43A-4036-AC1F-520A1D39DDBE}")]
		public Guid FolderId {
			get;
			set;
		}

		#endregion

		#region Methods: Protected

		/// <summary>
		/// Reads MetaData values to properties.
		/// </summary>
		protected override void ApplyMetaDataValue(DataReader reader) {
			base.ApplyMetaDataValue(reader);
			switch (reader.CurrentName) {
				case FolderPropertyName:
					FolderId = reader.GetGuidValue();
					break;
				default:
					break;
			}
		}

		#endregion

		#region Methods: Public

		/// <summary>
		/// Writes meta data values.
		/// </summary>
		/// <param name="writer">Instance of the <see cref="DataWriter"/> type.</param>
		public override void WriteMetaData(DataWriter writer) {
			base.WriteMetaData(writer);
			writer.WriteValue(FolderPropertyName, FolderId, Guid.Empty);
		}

		#endregion

	}

	#endregion

}

