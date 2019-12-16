 namespace Terrasoft.Configuration.ForecastV2
{
	using System;
	using System.Collections.Generic;
	using System.Collections.Immutable;
	using System.Globalization;
	using System.Linq;
	using Terrasoft.Common;
	using Terrasoft.Core.Factories;

	#region Class: FormulaSummaryParams

	public partial class FormulaSummaryParams
	{

		#region Properties: Public

		/// <summary>
		/// Forecast identifier.
		/// </summary>
		public Guid ForecastId { get; set; }

		/// <summary>
		/// Summary dictionary.
		/// Key: column id + period code. "column1_2020"
		/// Value: column value.
		/// </summary>
		public IEnumerable<TableCell> Cells { get; set; }

		#endregion

	}
	
	#endregion
	
	#region Interface: IFormulaSummaryCalculator
	
	/// <summary>
	/// Contract for formula summary calculator.
	/// </summary>
	public interface IFormulaSummaryCalculator
	{
		
		#region Methods: Public

		/// <summary>
		/// Calculates formula columns summary values;
		/// </summary>
		/// <param name="parameters">Forecast summary parameters.</param>
		/// <returns></returns>
		IEnumerable<TableCell> CalcFormulaSummary(FormulaSummaryParams parameters);
		
		#endregion

	}
	
	#endregion
	
	#region Class: FormulaSummaryCalculator

	/// <summary>
	/// Calculates summary formula columns.
	/// </summary>
	[DefaultBinding(typeof(IFormulaSummaryCalculator))]
	public class FormulaSummaryCalculator : IFormulaSummaryCalculator {

		#region Fields: Private

		private FormulaUtilities _formulaUtilities;

		#endregion

		#region Constructors: Public

		public FormulaSummaryCalculator(IForecastColumnRepository columnRepository) {
			columnRepository.CheckArgumentNull(nameof(columnRepository));
			ColumnRepository = columnRepository;
		}

		#endregion

		#region Properties: Protected

		protected IForecastColumnRepository ColumnRepository { get; }

		protected FormulaUtilities FormulaUtilities =>
			_formulaUtilities ?? (_formulaUtilities = ClassFactory.Get<FormulaUtilities>());

		protected IEnumerable<string> Periods { get; set; }

		protected IEnumerable<ForecastColumn> ForecastColumns { get; set; }

		#endregion

		#region Methods: Private

		private IEnumerable<TableCell> CalculateValuesForColumn(ForecastColumn calculationColumn, 
				IEnumerable<TableCell> cells, Guid recordId) {
			var calculatedCells = new List<TableCell>();
			var formula = FormulaUtilities.DeserializeFormula(calculationColumn);
			foreach (var period in Periods) {
				var values = GetFormulaValues(formula, period, cells);
				decimal value = FormulaUtilities.Calculate(formula, values);
				calculatedCells.Add(new TableCell {
					GroupCode = period,
					ColumnCode = calculationColumn.Code,
					Value = (double)value,
					RecordId = recordId,
					Id = calculationColumn.Id
				});
			}
			return calculatedCells;
		}

		private Dictionary<string, string> GetFormulaValues(IEnumerable<FormulaItem> formula, 
				string period, IEnumerable<TableCell> cells) {
			var periodCells = cells.Where(c => c.GroupCode == period);
			var values = new Dictionary<string, string>();
			foreach (var formulaItem in formula) {
				if (formulaItem.Type.Equals(FormulaItemType.Column)) {
					if (values.ContainsKey(formulaItem.Value)) {
						continue;
					}
					var cell = periodCells.FirstOrDefault(item => item.ColumnCode.StartsWith(formulaItem.Value));
					double value = cell?.Value ?? 0;
					values.Add(formulaItem.Value, value.ToString(CultureInfo.InvariantCulture));
				}
			}
			return values;
		}

		private IEnumerable<TableCell> InnerCalculate(IEnumerable<TableCell> cells, Guid recordId) {
			var calculatedCells = new List<TableCell>(cells);
			var formulaSummaryCells = new List<TableCell>();
			IEnumerable<ForecastColumn> notFormulaColumns =
				ForecastColumns.Where(column => !column.GetColumnSettings<FormulaSetting>().UseInSummary);
			FormulaUtilities.IterateFormulaColumns(ForecastColumns,
				(formulaColumn) => {
					if (notFormulaColumns.Contains(formulaColumn)) {
						return;
					}
					IEnumerable<TableCell> newCells = CalculateValuesForColumn(formulaColumn, calculatedCells, recordId);
					formulaSummaryCells.AddRange(newCells);
					calculatedCells.AddRange(newCells);
				});
			return formulaSummaryCells;
		}

		private void SetupPeriods(IEnumerable<TableCell> cells) {
			Periods = cells.Select(cell => cell.GroupCode).Distinct().ToList();
		}
		
		private List<TableCell> FilterTableCells(List<TableCell> cells) {
			var formulaColumns = ForecastColumns.Where(c => c.GetColumnSettings<FormulaSetting>().UseInSummary);
			cells = cells.Where(c => !formulaColumns.Any(fc => c.ColumnCode.StartsWith(fc.Code))).ToList();
			return cells;
		}

		#endregion

		#region Methods: Public

		/// <inheritdoc/>
		public IEnumerable<TableCell> CalcFormulaSummary(FormulaSummaryParams parameters) {
			parameters.CheckArgumentNull(nameof(parameters));
			Guid forecastId = parameters.ForecastId;
			ForecastColumns = ColumnRepository.GetColumns(forecastId);
			var cells = new List<TableCell>(parameters.Cells);
			cells = FilterTableCells(cells);
			SetupPeriods(cells);
			var resultCells = new List<TableCell>();
			var records = cells.Select(cell => cell.RecordId).Distinct().ToImmutableArray();
			records.ForEach((recordId) => {
				var filteredCells = cells.Where(cell => cell.RecordId == recordId);
				resultCells.AddRange(InnerCalculate(filteredCells, recordId));
			});
			return resultCells;
		}

		#endregion

	}
	
	#endregion

}
