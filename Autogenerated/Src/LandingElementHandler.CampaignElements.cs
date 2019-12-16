namespace Terrasoft.Configuration
{
	using System;
	using System.Collections.Generic;
	using System.Data;
	using System.Linq;
	using Terrasoft.Common;
	using Terrasoft.Core.Attributes;
	using Terrasoft.Core.Campaign;
	using Terrasoft.Core.Campaign.EventHandler;
	using Terrasoft.Core.DB;
	using CoreCampaignSchema = Core.Campaign.CampaignSchema;

	/// <summary>
	/// Contains methods for maintaining landing elements in campaign.
	/// </summary>
	public sealed class LandingElementHandler : CampaignEventHandlerBase, IOnCampaignValidate, IOnCampaignCopy,
		IOnCampaignAfterSave
	{

		#region Constants: Private

		private const string ElementHandlerName = nameof(LandingElementHandler);

		#endregion

		#region Fields: Private

		private Guid _landingSchemaUId = new Guid("41AE7D8D-BEC3-41DF-A6F0-2AB0D08B3967");

		#endregion

		#region Methods: Private

		private IEnumerable<CampaignLandingElement> GetLandingElements(CoreCampaignSchema schema) {
			return schema.FlowElements.OfType<CampaignLandingElement>();
		}

		private IEnumerable<Guid> GetLandingIds(IEnumerable<CampaignLandingElement> landingElements) {
			return landingElements.Select(x => x.LandingId).ToList();
		}

		private Dictionary<Guid, string> GetInactiveLandings(
				IEnumerable<CampaignLandingElement> landingSchemaElements) {
			var inactiveLandings = new Dictionary<Guid, string>();
			var landingIds = GetLandingIds(landingSchemaElements);
			var landingsStatusSelect = new Select(UserConnection)
				.Column("Id")
				.Column("Name")
				.Column("StateId")
				.From("GeneratedWebForm")
				.Where("Id").In(Column.Parameters(landingIds))
				.And("StateId").IsEqual(Column.Parameter(LendingConsts.NoactiveLendingStateId)) as Select;
			landingsStatusSelect.WithHints(new NoLockHint());
			using (DBExecutor dbExecutor = UserConnection.EnsureDBConnection()) {
				using (IDataReader dataReader = landingsStatusSelect.ExecuteReader(dbExecutor)) {
					while (dataReader.Read()) {
						var landingId = dataReader.GetColumnValue<Guid>("Id");
						var name = dataReader.GetColumnValue<string>("Name");
						inactiveLandings.Add(landingId, name);
					}
				}
			}
			return inactiveLandings;
		}

		private void WriteValidationInfo(IEnumerable<CampaignLandingElement> landingSchemaElements,
				Dictionary<Guid, string> inactiveLandings) {
			foreach (var landing in inactiveLandings) {
				var inactiveLanding = landingSchemaElements.FirstOrDefault(x => x.LandingId == landing.Key);
				if (inactiveLanding == null) {
					continue;
				}
				string message = GetLczStringValue(ElementHandlerName, "InactiveLandingWarning");
				string validationInfoMessage = string.Format(message, inactiveLanding.Caption, landing.Value);
				CampaignSchema.AddValidationInfo(validationInfoMessage, CampaignValidationInfoLevel.Warning);
			}
		}

		private IEnumerable<CampaignLandingElement> GetModifiedLandingElements() {
			var currentElements = GetLandingElements(CampaignSchema);
			if (CampaignSchema.InitialSchema == null) {
				return currentElements;
			}
			var initialElements = GetLandingElements(CampaignSchema.InitialSchema);
			var sameElements = initialElements.Join(currentElements,
					initial => initial.UId,
					current => current.UId,
					(initial, current) => (initial.LandingId == current.LandingId, current))
				.Where(x => x.Item1)
				.Select(x => x.Item2);
			return currentElements.Except(sameElements);
		}

		private void UpdateConnectedLandingInfo(IEnumerable<CampaignLandingElement> elements) {
			foreach (var element in elements) {
				var landingId = element.LandingId.IsEmpty() ? null as Guid? : element.LandingId;
				UpdateCampaignItemConnectedRecordInfo(element.UId, _landingSchemaUId, landingId);
			}
		}

		#endregion

		#region Methods: Public

		/// <summary>
		/// Validates landing elements on campaign validation. Searches inactive landing and adds to the schema.
		/// </summary>
		public void OnValidate() {
			var landingSchemaElements = GetLandingElements(CampaignSchema);
			if (!landingSchemaElements.Any()) {
				return;
			}
			var inactiveLandings = GetInactiveLandings(landingSchemaElements);
			WriteValidationInfo(landingSchemaElements, inactiveLandings);
		}

		/// <summary>
		/// Updates connected records info (RecordId and SchemaUId fields) after campaign has been copied.
		/// </summary>
		[Order(2)]
		public void OnCopy() {
			try {
				var allElements = GetLandingElements(CampaignSchema);
				UpdateConnectedLandingInfo(allElements);
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
				var modifiedElements = GetModifiedLandingElements();
				UpdateConnectedLandingInfo(modifiedElements);
			} catch (Exception ex) {
				CampaignLogger.ErrorFormat(ElementHandlerName, ex, CampaignSchema.EntityId);
				throw;
			}
		}

		#endregion

	}

}
