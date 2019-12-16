namespace Terrasoft.Configuration
{
	using System;
	using System.Collections.Generic;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Campaign;
	using Terrasoft.Core.Campaign.Interfaces;
	using Terrasoft.Core.Process;

	#region Class: CampaignEventElement

	/// <summary>
	/// Event schema element in campaign.
	/// </summary>
	[DesignModeProperty(Name = "EventId",
		UsageType = DesignModeUsageType.NotVisible, MetaPropertyName = EventPropertyName)]
	public class CampaignEventElement : CampaignSchemaElement, IExtendableElement
	{

		#region Constants: Private

		private const string EventPropertyName = "EventId";
		private const string AddAudienceExtensionSuffix = "AddAudience";

		#endregion

		#region Constructors: Public

		/// <summary>
		/// Default constructor for <see cref="CampaignEventElement"/>.
		/// </summary>
		public CampaignEventElement() {
			ElementType = CampaignSchemaElementType.AsyncTask;
		}

		/// <summary>
		/// Constructor for <see cref="CampaignEventElement"/>.
		/// </summary>
		/// <param name="source">Instance of <see cref="CampaignEventElement"/>.</param>
		public CampaignEventElement(CampaignEventElement source)
				: this(source, null, null) {
		}

		/// <summary>
		/// Constructor for <see cref="CampaignEventElement"/>.
		/// </summary>
		/// <param name="source">Instance of <see cref="CampaignEventElement"/>.</param>
		/// <param name="dictToRebind">Dictionary to rebind schema elements' ids.</param>
		/// <param name="parentSchema">Parent campaign schema.</param>
		public CampaignEventElement(CampaignEventElement source, Dictionary<Guid, Guid> dictToRebind,
				Core.Campaign.CampaignSchema parentSchema) : base(source, dictToRebind, parentSchema) {
			EventId = source.EventId;
		}

		#endregion

		#region Properties: Protected

		/// <summary>
		/// Identifier of element action.
		/// </summary>
		protected override Guid Action {
			get {
				return CampaignConsts.CampaignLogTypeEvent;
			}
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Unique identifier of the event.
		/// </summary>
		[MetaTypeProperty("{4E0452E5-2B1E-4A95-98CA-858CEEE6F8C9}")]
		public Guid EventId { get; set; }

		#endregion

		#region Methods: Protected

		protected override void ApplyMetaDataValue(DataReader reader) {
			base.ApplyMetaDataValue(reader);
			switch (reader.CurrentName) {
				case EventPropertyName:
					EventId = reader.GetGuidValue();
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
			writer.WriteValue(EventPropertyName, EventId, Guid.Empty);
		}

		/// <summary>
		/// Creates a new instance that is a clone of the current instance.
		/// </summary>
		/// <returns>Cloned instance of the CampaignEventElement.</returns>
		public override object Clone() {
			return new CampaignEventElement(this);
		}

		/// <summary>
		/// Creates a new instance that is a copy of the current instance.
		/// </summary>
		/// <param name="dictToRebind">Dictionary to rebind schema elements' ids.</param>
		/// <param name="parentSchema">Parent campaign schema.</param>
		/// <returns>Copied instance of the CampaignEventElement.</returns>
		public override object Copy(Dictionary<Guid, Guid> dictToRebind, Core.Campaign.CampaignSchema parentSchema) {
			return new CampaignEventElement(this, dictToRebind, parentSchema);
		}

		/// <summary>
		/// Creates specific ProcessFlowElement instance.
		/// </summary>
		/// <param name="userConnection">Instance of <see cref="UserConnection"/>.</param>
		/// <returns>Instance of <see cref="ProcessFlowElement"/>.</returns>
		public override ProcessFlowElement CreateProcessFlowElement(UserConnection userConnection) {
			var executableElement = new CampaignEventFlowElement() {
				UserConnection = userConnection,
				EventId = this.EventId
			};
			InitializeCampaignProcessFlowElement(executableElement);
			return executableElement;
		}

		/// <summary>
		/// Returns extends for <see cref="CampaignEventElement"/>.
		/// </summary>
		public IEnumerable<CampaignSchemaElement> CreateElementExtensions() {
			var addAudienceElement = new CampaignAddEventAudienceElement(this);
			addAudienceElement.UId = Guid.NewGuid();
			addAudienceElement.ParentUId = this.UId;
			addAudienceElement.ParentSchema = this.ParentSchema;
			addAudienceElement.Name = this.Name + AddAudienceExtensionSuffix;
			yield return addAudienceElement;
		}

		#endregion

	}

	#endregion

}

