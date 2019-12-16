namespace Terrasoft.Configuration.DynamicContent
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using Terrasoft.Common;
	using Terrasoft.Configuration.DynamicContent.Models;
	using Terrasoft.Core.DB;

	#region Class: DCCombiningStrategy

	/// <summary>
	/// Represents combining strategy for an audience segmentation.
	/// It is optimized to be used for a huge audience size with more than 50k recipients.
	/// </summary>
	public class DCCombiningStrategy : DCSegmentationStrategyBase
	{

		#region Constants

		private const string TargetTableAlias = "TargetTableAlias";

		#endregion

		#region Constructors: Public

		/// <summary>
		/// Creates resolver strategy instance with a predefined context.
		/// </summary>
		/// <param name="segmentationContext">A set of predefined parameters, which are using by strategies.</param>
		public DCCombiningStrategy(DCSegmentationContext segmentationContext) : base(segmentationContext) {
			SelectBuilder = new DCSelectBuilder();
		}

		#endregion

		#region Properties: Private

		private DCSelectBuilder SelectBuilder { get; }

		#endregion

		#region Methods: Private

		private List<DCReplicaModel> GetReplicasForProcessing() {
			var allReplicas = SegmentationContext.Template.GetSortedReplicasByPriority();
			if (allReplicas.Count == 1) {
				return allReplicas;
			}
			return allReplicas.Where(r => r.Mask != 0).ToList();
		}

		private IEnumerable<Select> GetReplicaFilters(DCReplicaModel replica) {
			var blockAttributes = SegmentationContext.Template.Blocks
				.Where(b => replica.BlockIndexes.Contains(b.Index))
				.Select(s =>s.AttributeIndexes);
			foreach (var attributes in blockAttributes) {
				if (attributes == null || attributes.Length == 0) {
					continue;
				}
				var filterAttribute = SegmentationContext.Template.Attributes
					.FirstOrDefault(a => attributes.Contains(a.Index) && a.IsFilter());
				if (filterAttribute != null) {
					yield return filterAttribute.ToFilter(SegmentationContext.UserConnection);
				}
			}
		}

		private InsertSelect BuildTargetInsertSelect(Select replicaRecipientsSelect) {
			return new InsertSelect(SegmentationContext.UserConnection)
				.Into(SegmentationContext.TargetTable)
				.Set(SegmentationContext.EntityIdTargetColumn, SegmentationContext.ReplicaIdTargetColumn,
					SegmentationContext.RecordIdTargetColumn)
				.FromSelect(replicaRecipientsSelect);
		}

		private void ExtendRecipientsSelectWithFilters(ref Select recipientsSelect, List<Select> filters) {
			if (!filters.Any()) {
				return;
			}
			var filtersSelect = SelectBuilder.Append(filters);
			if (filtersSelect != null) {
				if (recipientsSelect.HasCondition) {
					recipientsSelect
						.And(SegmentationContext.SourceAliasForFilter, SegmentationContext.SourceColumnForFilter)
						.In(filtersSelect);
				} else {
					recipientsSelect
						.Where(SegmentationContext.SourceAliasForFilter, SegmentationContext.SourceColumnForFilter)
						.In(filtersSelect);
				}
				recipientsSelect.SpecifyNoLockHints();
			}
		}

		private Select BuildRecipientsSelect(DCReplicaModel replica) {
			var recipientsSelect = new Select(SegmentationContext.UserConnection)
				.Column(SegmentationContext.SourceAliasForFilter, SegmentationContext.EntityIdSourceColumn)
				.Column(Column.Parameter(replica.Id))
				.Column(Column.Parameter(SegmentationContext.Template.RecordId))
					.As(SegmentationContext.RecordIdTargetColumn)
				.From(SegmentationContext.SourceAudience).As(SegmentationContext.SourceAliasForFilter);
			recipientsSelect.SpecifyNoLockHints();
			return recipientsSelect;
		}

		private void ExtendRecipientsSelectWithExcludeExisting(ref Select recipientsSelect,
				List<DCReplicaModel> processedReplicas) {
			if (processedReplicas.Any()) {
				recipientsSelect = recipientsSelect
					.Join(JoinType.LeftOuter, SegmentationContext.TargetTable).As(TargetTableAlias)
						.On(TargetTableAlias, SegmentationContext.EntityIdTargetColumn)
						.IsEqual(SegmentationContext.SourceAliasForFilter, SegmentationContext.EntityIdSourceColumn)
					.And(TargetTableAlias, SegmentationContext.RecordIdTargetColumn)
						.IsEqual(Column.Parameter(SegmentationContext.Template.RecordId))
					.Where(TargetTableAlias, SegmentationContext.EntityIdTargetColumn).IsNull()
				as Select;
				recipientsSelect.SpecifyNoLockHints();
			}
		}

		private void ExtendConditionsWithEntityIdFilter(ref Select entityFilterSelect, Guid entityId) {
			entityFilterSelect = (entityFilterSelect.HasCondition
				? entityFilterSelect.And(entityFilterSelect.Columns.First()).IsEqual(Column.Parameter(entityId))
				: entityFilterSelect.Where(entityFilterSelect.Columns.First()).IsEqual(Column.Parameter(entityId))) as Select;
			entityFilterSelect.SpecifyNoLockHints();
		}

		private void SegmentAudienceByReplicas() {
			var processedReplicas = new List<DCReplicaModel>();
			foreach (var replica in GetReplicasForProcessing()) {
				var filters = GetReplicaFilters(replica).ToList();
				var replicaRecipientsSelect = BuildRecipientsSelect(replica);
				ExtendRecipientsSelectWithExcludeExisting(ref replicaRecipientsSelect, processedReplicas);
				ExtendRecipientsSelectWithFilters(ref replicaRecipientsSelect, filters);
				var insertSelect = BuildTargetInsertSelect(replicaRecipientsSelect);
				insertSelect.Execute();
				processedReplicas.Add(replica);
			}
		}

		private Guid SegmentBySingleEntityId() {
			foreach (var replica in GetReplicasForProcessing()) {
				var filters = GetReplicaFilters(replica).ToList();
				if (!filters.Any()) {
					continue;
				}
				var filtersSelect = SelectBuilder.Append(filters);
				ExtendConditionsWithEntityIdFilter(ref filtersSelect, SegmentationContext.SourceEntityId);
				var entityIdFromDb = filtersSelect.ExecuteScalar<Guid>();
				if (entityIdFromDb.IsNotEmpty()) {
					return replica.Id;
				}
			}
			return Guid.Empty;
		}

		#endregion

		#region Methods: Public

		/// <summary>
		/// Defines which replica should be sent to recipient.
		/// </summary>
		public override void SegmentAudience() {
			SegmentAudienceByReplicas();
		}

		/// <summary>
		/// Defines which replica should be sent to recipient.
		/// </summary>
		public override Guid SegmentSingleEntity() {
			return SegmentBySingleEntityId();
		}

		/// <summary>
		/// Should remove all operational data.
		/// </summary>
		public override void ClearOpData() {
		}

		#endregion

	}

	#endregion

}

