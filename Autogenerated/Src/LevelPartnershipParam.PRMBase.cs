﻿namespace Terrasoft.Configuration
{
	using System;
	using System.Data;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;

	#region Class: LevelPartnershipParam_PRMBaseEventsProcess

	public partial class LevelPartnershipParam_PRMBaseEventsProcess<TEntity>
	{

		#region Methods: Protected
		

		protected virtual void CheckIsDuplicated(Entity entity) {
			Select select = new Select(UserConnection).Top(1).Column(Column.Const(1)).As("item").From("LevelPartnershipParam");
			ApplyConditions(select, entity);
			using (var dbExecutor = UserConnection.EnsureDBConnection()) {
				using (IDataReader dataReader = select.ExecuteReader(dbExecutor)) {
					if (dataReader.Read()) {
						throw new ValidateException(new LocalizableString(UserConnection.ResourceStorage, "LevelPartnershipParam",
								"EventsProcessSchema.LocalizableStrings.DuplicatesValidationExceptionMessage.Value").ToString());
					}
				}
			}
		}

		protected virtual void ApplyConditions(Select select, Entity entity) {
			ApplyLookupColumnsConditions(select, Entity);
			ApplyPeriodColumnsConditions(select, Entity);
			ApplyDeactivatedRecordsConditions(select, Entity.Schema);
		}

		protected virtual void ApplyLookupColumnsConditions(Select select, Entity entity) {
			select
				.Where("ParameterTypeId").IsEqual(Column.Parameter(entity.GetTypedColumnValue<Guid>("ParameterTypeId")))
				.And("PartnerParamCategoryId").IsEqual(Column.Parameter(entity.GetTypedColumnValue<Guid>("PartnerParamCategoryId")))
				.And("PartnerLevelId").IsEqual(Column.Parameter(entity.GetTypedColumnValue<Guid>("PartnerLevelId")));
		}

		protected virtual void ApplyPeriodColumnsConditions(Select select, Entity entity) {
			DateTime startDate = entity.GetTypedColumnValue<DateTime>("StartDate");
			DateTime dueDate = entity.GetTypedColumnValue<DateTime>("DueDate");
			if (dueDate == default(DateTime)) {
				ApplyOpenPeriodColumnsConditions(select, startDate);
			} else {
				ApplyClosedPeriodColumnsConditions(select, startDate, dueDate);
			}
		}

		protected virtual void ApplyClosedPeriodColumnsConditions(Select select, DateTime startDate, DateTime dueDate) {
			select.AddCondition(LogicalOperation.And)
				.OpenBlock("DueDate").IsGreaterOrEqual(Column.Parameter(startDate))
					.And("StartDate").IsLessOrEqual(Column.Parameter(dueDate))
				.Or("StartDate").IsLessOrEqual(Column.Parameter(dueDate))
					.And("DueDate").IsNull()
				.CloseBlock();
		}

		protected virtual void ApplyOpenPeriodColumnsConditions(Select select, DateTime startDate) {
			select.AddCondition(LogicalOperation.And)
				.OpenBlock("DueDate").IsNull()
				.Or("StartDate").IsLessOrEqual(Column.Parameter(startDate))
					.And("DueDate").IsGreaterOrEqual(Column.Parameter(startDate))
				.CloseBlock();
		}

		protected void ApplyDeactivatedRecordsConditions(Select select, EntitySchema schema) {
			if (schema.UseRecordDeactivation) {
				string inactiveColumnName = schema.GetInactiveColumn().Name;
				select.AddCondition(inactiveColumnName, LogicalOperation.And)
					.IsEqual(Column.Const(false));
			}
		}

		#endregion

	}

	#endregion

}

