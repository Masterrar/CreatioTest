namespace Terrasoft.Configuration.FileImport
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Factories;

	#region  Class: PrepareFileImportStage

	/// <inheritdoc cref="BaseFileImportStage"/>
	/// <summary>
	/// Execute prepare file import
	/// </summary>
	[DefaultBinding(typeof(IBaseFileImportStage), Name = nameof(PrepareFileImportStage))]
	public class PrepareFileImportStage : BaseFileImportStage
	{

		#region Constructors: Public

		public PrepareFileImportStage(UserConnection userConnection,
				IColumnsAggregatorAdapter columnsProcessor)
				: base(userConnection, columnsProcessor) { }

		#endregion

		#region Properties: Public

		/// <inheritdoc cref="BaseFileImportStage"/>
		public override FileImportStagesEnum StageId => FileImportStagesEnum.PrepareFileImportStage;

		#endregion

		#region Methods: Private

		private List<ImportEntity> GetMergedImportEntities(IEnumerable<ImportEntity> entities,
				IEnumerable<ImportColumn> keyColumns) {
			return entities.GroupBy(importEntity => importEntity.GetRawKey(keyColumns))
				.Select(entityGroup => entityGroup.First()).ToList();
		}

		private string GetMergedImportEntitiesInfoMessage(uint mergedRowsCount) {
			string messageTemplate = new LocalizableString(UserConnection.Workspace.ResourceStorage, "FileImporter",
					"LocalizableStrings.MergedImportEntitiesInfoMessageTemplate.Value");
			return string.Format(messageTemplate, mergedRowsCount);
		}

		private void MergeImportEntities(ImportParameters parameters) {
			var keyColumns = GetKeyColumns(parameters).ToList();
			if (keyColumns.Any()) {
				parameters.Entities = GetMergedImportEntities(parameters.Entities, keyColumns);
				var mergedRowsCount = (uint)(parameters.TotalRowsCount - parameters.Entities.Count);
				if (mergedRowsCount > 0) {
					parameters.NotImportedRowsCount += mergedRowsCount;
					var eventArgs = new InfoMessageEventArgs {
							Message = GetMergedImportEntitiesInfoMessage(mergedRowsCount)
					};
					ImportLogger.HandleInfoMessage(this, eventArgs);
				}
			}
		}

		private void ValidateColumnsMapping(ImportParameters parameters) {
			Guid rootSchemaUId = parameters.RootSchemaUId;
			var columns = parameters.Columns;
			EntitySchema entitySchema = UserConnection.EntitySchemaManager.GetInstanceByUId(rootSchemaUId);
			var schemaColumns = entitySchema.Columns.Where(column =>
					column.RequirementType.Equals(EntitySchemaColumnRequirementType.ApplicationLevel) &&
					column.UsageType.Equals(EntitySchemaColumnUsageType.General) && !column.HasDefValue &&
					!column.HasConstDefValue);
			var destinations = columns.SelectMany(parameterColumn => parameterColumn.Destinations)
				.Where(destination => destination.SchemaUId.Equals(rootSchemaUId));
			var notFilledColumns = schemaColumns.Where(schemaColumn =>
					!destinations.Any(destination => destination.ColumnName.Equals(schemaColumn.Name)));
			var entitySchemaColumns = notFilledColumns.ToList();
			if (entitySchemaColumns.Any()) {
				throw new RequiredColumnsEmptyValuesException(entitySchemaColumns);
			}
		}

		#endregion

		#region Methods: Protected

		/// <inheritdoc cref="BaseFileImportStage"/>
		protected override FileImportStagesEnum? InternalProcess(ImportParameters parameters) {
			ValidateColumnsMapping(parameters);
			MergeImportEntities(parameters);
			return FileImportStagesEnum.ProcessColumnsFileImportStage;
		}

		#endregion

	}
	
	#endregion

}

