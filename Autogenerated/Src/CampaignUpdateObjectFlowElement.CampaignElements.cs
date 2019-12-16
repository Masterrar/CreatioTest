﻿namespace Terrasoft.Configuration
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Campaign;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;

	#region Class: CampaignUpdateObjectFlowElement

	/// <summary>
	/// Executable modify entity element at campaign.
	/// </summary>
	public class CampaignUpdateObjectFlowElement : CampaignBaseCrudObjectFlowElement
	{

		#region Methods: Private

		private bool UpdateEntity(Entity entity, Guid contactId, Guid participantId,
				CmpgnUpdObjElEntity entitySettings) {
			try {
				FillEntityColumns(entity, contactId, entitySettings.Columns, entitySettings.RestrictedColumns);
				entity.UseAdminRights = false;
				return entity.Save(false);
			} catch (Exception ex) {
				CampaignLogger.ErrorFormat(nameof(CampaignAddObjectFlowElement), ex, entity.SchemaName,
					$"Id = {entity.PrimaryColumnValue} ParticipantId = {participantId}");
				return false;
			}
		}

		private CmpgnUpdObjElEntity GetEntitySettingsFromLookup() {
			var lookupEsq = new EntitySchemaQuery(UserConnection.EntitySchemaManager, nameof(CmpgnUpdObjElEntity)) {
				UseAdminRights = false,
				IgnoreDisplayValues = true
			};
			lookupEsq.AddAllSchemaColumns(true);
			var filter = lookupEsq.CreateFilterWithParameters(FilterComparisonType.Equal,
				nameof(CmpgnUpdObjElEntity.EntityName), EntityName);
			lookupEsq.Filters.Add(filter);
			var entities = lookupEsq.GetEntityCollection(UserConnection);
			if (entities.Count == 0) {
				var message = string.Format(EntitySettingsNotFoundExceptionMessage, EntityName);
				throw new Exception(message);
			}
			return new CmpgnUpdObjElEntity(UserConnection) {
				EntityName = entities[0].GetTypedColumnValue<string>(nameof(CmpgnUpdObjElEntity.EntityName)),
				ContactColumnPath = entities[0]
					.GetTypedColumnValue<string>(nameof(CmpgnUpdObjElEntity.ContactColumnPath)),
				Columns = entities[0].GetTypedColumnValue<string>(nameof(CmpgnUpdObjElEntity.Columns)),
				RestrictedColumns = entities[0]
					.GetTypedColumnValue<string>(nameof(CmpgnUpdObjElEntity.RestrictedColumns))
			};
		}

		private EntityCollection GetEntitiesCollectionByContactList(IEnumerable<Guid> contacts,
				EntitySchema entitySchema, CmpgnUpdObjElEntity entitySettings, out string contactColumnAlias) {
			var esq = new EntitySchemaQuery(UserConnection.EntitySchemaManager, EntityName) {
				UseAdminRights = false,
				IgnoreDisplayValues = GlobalAppSettings.FeatureIgnoreDisplayValuesInDataUserTasks
			};
			esq.AddAllSchemaColumns();
			var contactColumnName = entitySettings.ContactColumnPath;
			if (string.IsNullOrEmpty(contactColumnName)) {
				contactColumnAlias = null;
				return default(EntityCollection);
			}
			if (!esq.Columns.Any(x => x.Name == contactColumnName)) {
				contactColumnAlias = esq.AddColumn(contactColumnName).Name;
			} else {
				contactColumnAlias = contactColumnName;
			}
			var filterGroup = new EntitySchemaQueryFilterCollection(esq, LogicalOperationStrict.Or);
			foreach (var contactId in contacts) {
				var filter = esq.CreateFilterWithParameters(FilterComparisonType.Equal, contactColumnName, contactId);
				filterGroup.Add(filter);
			}
			esq.Filters.Add(filterGroup);
			return esq.GetEntityCollection(UserConnection);
		}

		#endregion

		#region Methods: Protected

		/// <summary>
		/// Executes current flow element in fragment.
		/// </summary>
		/// <returns>Count of participants which has been processed.</returns>
		protected override int FragmentExecute() {
			var columnValues = ColumnValues?.ToList();
			if (columnValues == null || columnValues.Count == 0) {
				return SetItemCompleted((Select)GetAudienceQuery());
			}
			var audienceByContact = GetAudienceContacts();
			var entitySchema = UserConnection.EntitySchemaManager.GetInstanceByName(EntityName);
			var entitySettings = GetEntitySettingsFromLookup();
			var entityCollection = GetEntitiesCollectionByContactList(audienceByContact.Values, entitySchema,
				entitySettings, out var contactColumnAlias);
			foreach (var entity in entityCollection) {
				var contactId = entity.GetTypedColumnValue<Guid>(contactColumnAlias);
				var participantId = audienceByContact.FirstOrDefault(x => x.Value == contactId).Key;
				var isEntityUpdated = UpdateEntity(entity, contactId, participantId, entitySettings);
				if (!isEntityUpdated) {
					UpdateParicipantStatus(participantId, CampaignConstants.CampaignParticipantErrorStatusId);
					continue;
				}
			}
			return SetItemCompleted((Select)GetAudienceQuery());
		}

		#endregion

	}

	#endregion

}