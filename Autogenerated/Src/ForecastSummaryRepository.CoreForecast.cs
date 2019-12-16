namespace Terrasoft.Configuration.ForecastV2
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using Terrasoft.Common;
	using Terrasoft.Common.Json;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Factories;

	#region Interface: IForecastSummaryRepository

	/// <summary>Provides methods for forecast summary</summary>
	public interface IForecastSummaryRepository
	{
		/// <summary>Gets the summary.</summary>
		/// <param name="sheetId">The sheet identifier.</param>
		/// <param name="periodIds">The period ids.</param>
		/// <returns>Dictionary of summary.</returns>
		IEnumerable<TableCell> GetSummary(Guid sheetId, IEnumerable<Guid> periodIds);
	}

	#endregion

	#region Class: ForecastSummaryRepository

	[DefaultBinding(typeof(IForecastSummaryRepository))]
	public class ForecastSummaryRepository : IForecastSummaryRepository
	{

		#region Fields: Private {}

		private string _aggregationColumnName;
		private IForecastSheetRepository _sheetRepository;
		private IPeriodRepository _periodRepository;

		#endregion

		#region Constructors: Public

		public ForecastSummaryRepository(
					UserConnection userConnection,
					IForecastSheetRepository sheetRepository, 
					IPeriodRepository periodRepository, 
					IForecastColumnRepository columnRepository) {
			userConnection.CheckArgumentNull(nameof(userConnection));
			sheetRepository.CheckArgumentNull(nameof(sheetRepository));
			periodRepository.CheckArgumentNull(nameof(periodRepository));
			columnRepository.CheckArgumentNull(nameof(columnRepository));
			UserConnection = userConnection;
			SheetRepository = sheetRepository;
			PeriodRepository = periodRepository;
			ColumnRepository = columnRepository;
		}

		#endregion

		#region Properties: Propected

		/// <summary>Gets the forecast sheet repository.</summary>
		/// <value>The forecast sheet repository.</value>
		protected IForecastSheetRepository SheetRepository { get; }

		/// <summary>Gets the period repository.</summary>
		/// <value>The period repository.</value>
		protected IPeriodRepository PeriodRepository { get; }
		
		private IForecastColumnRepository _columnRepository;
		protected IForecastColumnRepository ColumnRepository { get; }

		/// <summary>Gets the user connection.</summary>
		/// <value>The user connection.</value>
		protected UserConnection UserConnection { get; }

		#endregion

		#region Methods: Private

		private EntitySchemaQuery GetSummaryEsq(Sheet sheet, IEnumerable<Period> periodsInfo, 
				IEnumerable<ForecastColumn> filterColumns) {
			var periodIds = periodsInfo.Select(a => a.Id);
			var columnsIds = filterColumns.Select(c => c.Id);
			var schemaName = UserConnection.EntitySchemaManager.FindItemByUId(sheet.ForecastEntityInCellUId).Name;
			var esq = new EntitySchemaQuery(UserConnection.EntitySchemaManager, schemaName);
			_aggregationColumnName = esq.AddColumn(esq.CreateAggregationFunction(AggregationTypeStrict.Sum, "Value")).Name;
			esq.AddColumn("Period");
			esq.AddColumn("ForecastColumn");
			esq.Filters.Add(esq.CreateFilterWithParameters(FilterComparisonType.Equal, "Sheet", sheet.Id));
			if (periodIds.IsNotEmpty()) {
				esq.Filters.Add(esq.CreateFilterWithParameters(FilterComparisonType.Equal, "Period", 
					periodIds.Cast<object>().ToArray()));
			}
			if (columnsIds.IsNotEmpty()) {
				esq.Filters.Add(esq.CreateFilterWithParameters(FilterComparisonType.Equal, "ForecastColumn", 
					columnsIds.Cast<object>().ToArray()));
			}
			return esq;
		}
		
		private IEnumerable<ForecastColumn> GetColumnsToCalculate(Guid sheetId) {
			var useFormulaColumn = UserConnection.GetIsFeatureEnabled("CalcTotalByFormula");
			var columnsToCalculate = ColumnRepository.GetColumns(sheetId).Where(column => {
				if (!useFormulaColumn) {
					return column.TypeId != ForecastConsts.FormulaColumnTypeId;
				}
				FormulaSetting setting = column.GetColumnSettings<FormulaSetting>();
				return !setting.UseInSummary;
			});
			return columnsToCalculate;
		}
		
		#endregion

		/// <summary>
		/// Gets the summary.
		/// </summary>
		/// <param name="sheetId">The sheet identifier.</param>
		/// <param name="periodIds">The period ids.</param>
		/// <returns>
		/// Collection of calculated summary cells.
		/// </returns>
		public IEnumerable<TableCell> GetSummary(Guid sheetId, IEnumerable<Guid> periodIds) {
			var sheet = SheetRepository.GetSheet(sheetId);
			var cellValues = new List<TableCell>();
			var columnsToCalculate = GetColumnsToCalculate(sheetId);
			if (columnsToCalculate.IsEmpty()) {
				return cellValues;
			}
			IEnumerable<Period> periodsInfo = PeriodRepository.GetForecastPeriods(periodIds, sheet.PeriodTypeId);
			EntitySchemaQuery esq = GetSummaryEsq(sheet, periodsInfo, columnsToCalculate);
			EntityCollection collection = esq.GetEntityCollection(UserConnection);
			foreach (var item in collection) {
				var periodName = item.GetTypedColumnValue<string>("PeriodName");
				var columnId = item.GetTypedColumnValue<string>("ForecastColumnId");
				var summary = item.GetTypedColumnValue<double>(_aggregationColumnName);
				cellValues.Add(new TableCell {
					ColumnCode = columnId,
					GroupCode = periodName,
					Value = summary
				});
			}
			return cellValues;
		}

	}

	#endregion

}

