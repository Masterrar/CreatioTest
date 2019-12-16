namespace Terrasoft.Configuration.ForecastV2
{
	using global::Common.Logging;
	using System;
	using System.Collections.Generic;
	using System.Data;
	using System.Linq;
	using Terrasoft.Common.Json;
	using Newtonsoft.Json;
	using Terrasoft.Common;

	#region Enum: FormulaItemType

	/// <summary>
	/// Formula item type.
	/// </summary>
	public enum FormulaItemType
	{
		Number,
		Column,
		Operand
	}

	#endregion

	#region Class: FormulaSetting 

	/// <summary>
	/// Formula settings.
	/// </summary>
	public class FormulaSetting
	{

		/// <summary>
		/// Gets or sets the value.
		/// </summary>
		/// <value>
		/// The value.
		/// </value>
		[JsonProperty("value")]
		public IEnumerable<FormulaItem> Value { get; set; }
		
		/// <summary>
		/// Gets or sets the use formula in summary flag.
		/// </summary>
		[JsonProperty("useInSummary")]
		public bool UseInSummary { get; set; }
	}

	#endregion

	#region Class: FormulaItem 

	/// <summary>
	/// Formula item.
	/// </summary>
	public class FormulaItem : IEquatable<FormulaItem>
	{

		/// <summary>
		/// Gets or sets the type.
		/// </summary>
		/// <value>
		/// The type.
		/// </value>
		[JsonProperty("type")]
		public FormulaItemType Type { get; set; }

		/// <summary>
		/// Gets or sets the caption.
		/// </summary>
		/// <value>
		/// The caption.
		/// </value>
		[JsonProperty("caption")]
		public string Caption { get; set; }

		/// <summary>
		/// Gets or sets the value.
		/// </summary>
		/// <value>
		/// The value.
		/// </value>
		[JsonProperty("value")]
		public string Value { get; set; }

		/// <summary>
		/// Indicates whether the current object is equal to another object of the same type.
		/// </summary>
		/// <param name="other">An object to compare with this object.</param>
		/// <returns>
		///   <see langword="true" /> if the current object is equal to the <paramref name="other" />
		///   parameter; otherwise, <see langword="false" />.
		/// </returns>
		public bool Equals(FormulaItem other) {
			if (Object.ReferenceEquals(other, null)) return false;
			if (Object.ReferenceEquals(this, other)) return true;
			return Value.Equals(other.Value) && Type.Equals(other.Type);
		}

		public override int GetHashCode() {
			return Type.GetHashCode() ^ Value.GetHashCode();
		}
	}

	#endregion

	#region Class: FormulaUtilities

	/// <summary>
	/// Provides methods of formula working.
	/// </summary>
	public class FormulaUtilities
	{

		#region Fields: Private

		private static readonly ILog _log = LogManager.GetLogger<FormulaUtilities>();

		#endregion

		#region Methods: Private

		private bool HasReference(ForecastColumn formulaColumn, ForecastColumn parentColumn) {
			var formulaItems = GetFormulaItems(formulaColumn);
			return formulaItems
				.Where(item => item.Type.Equals(FormulaItemType.Column))
				.Any(item => item.Value.Equals(parentColumn.Id.ToString()));
		}

		private IEnumerable<FormulaItem> GetFormulaItems(ForecastColumn column) {
			return column.GetColumnSettings<FormulaSetting>().Value ?? new FormulaItem[0];
		}

		private decimal GetCalculatedFormulaValue(string formula, bool safe = true) {
			var dt = new DataTable();
			decimal result = 0;
			try {
				var value = dt.Compute(formula, string.Empty);
				result = Convert.ToDecimal(value);
			}
			catch (Exception ex) {
				if (!safe) {
					throw;
				}
				_log.Error(ex);
			}
			return Convert.ToDecimal(result);
		}

		private string GetFormula(IEnumerable<FormulaItem> formulaItems, IDictionary<string, string> injectedValues) {
			string formula = string.Empty;
			foreach (var formulaItem in formulaItems) {
				switch (formulaItem.Type) {
					case FormulaItemType.Column: {
						var injectValue = injectedValues[formulaItem.Value];
						formula += string.IsNullOrEmpty(injectValue) ? "0" : injectValue;
						break;
					}
					case FormulaItemType.Number:
					case FormulaItemType.Operand:
					formula += formulaItem.Value;
					break;
					default:
					throw new Exception(string.Format("Formula type {0} not supported", formulaItem.Type.ToString()));
				}
			}
			return formula;
		}

		private bool HasCorrectOrder(IEnumerable<FormulaItem> formulaItems) {
			FormulaItem previousItem = null;
			foreach (var formulaItem in formulaItems) {
				if (previousItem == null) {
					previousItem = formulaItem;
					continue;
				}
				switch (previousItem.Type) {
					case FormulaItemType.Number: {
						if (formulaItem.Type.Equals(FormulaItemType.Column)) {
								return false;
						}
						break;
					}
					case FormulaItemType.Column: {
						if (formulaItem.Type.Equals(FormulaItemType.Column) ||
							formulaItem.Type.Equals(FormulaItemType.Number)) {
							return false;
						}
						break;
					}
				}
				previousItem = formulaItem;
			}
			return true;
		}

		private IDictionary<string, string> GetTestInjectableColumnValues(IEnumerable<FormulaItem> formulaItems) {
			return formulaItems
					.Where(item => item.Type.Equals(FormulaItemType.Column))
					.Distinct()
					.ToDictionary(key => key.Value, value => "1");
		}
		
		private bool CheckCanCalculate(IEnumerable<ForecastColumn> allColumns, ForecastColumn formulaColumn,
			IEnumerable<Guid> calculatedColumns) {
			var result = true;
			var referenceColumns = GetReferenceColumns(allColumns, formulaColumn);
			foreach (var referenceColumn in referenceColumns) {
				if (referenceColumn.TypeId.Equals(ForecastConsts.FormulaColumnTypeId) ) {
					if (calculatedColumns.Contains(referenceColumn.Id)) {
						continue;
					}
					result = false;
				}
				break;
			}
			return result;
		}

		private ForecastColumn NextCalculationColumn(IEnumerable<ForecastColumn> formulaColumns, 
			IEnumerable<Guid> calculatedColumns, ForecastColumn lastColumn = null) {
			return formulaColumns.FirstOrDefault(column =>
				!calculatedColumns.Contains(column.Id) && !column.Id.Equals(lastColumn?.Id));
		}
		
		private IEnumerable<ForecastColumn> GetFormulaColumns(IEnumerable<ForecastColumn> columns) {
			return columns.Where(column => column.TypeId == ForecastConsts.FormulaColumnTypeId);
		}

		#endregion

		#region Methods: Public

		/// <summary>
		/// Iterates formula columns in their dependency order.
		/// </summary>
		/// <param name="columns">All columns collection.</param>
		/// <param name="iterateFn">Iterate function.</param>
		public void IterateFormulaColumns(IEnumerable<ForecastColumn> columns, Action<ForecastColumn> iterateFn) {
			List<Guid> calculatedColumns = new List<Guid>();
			var formulaColumns = GetFormulaColumns(columns);
			ForecastColumn calculationColumn = NextCalculationColumn(formulaColumns, calculatedColumns);
			while (calculationColumn != null) {
				if (CheckCanCalculate(columns, calculationColumn, calculatedColumns)) {
					iterateFn?.Invoke(calculationColumn);
					calculatedColumns.Add(calculationColumn.Id);
				}
				calculationColumn = NextCalculationColumn(formulaColumns, calculatedColumns,
					calculationColumn);
			}
		}

		/// <summary>
		/// Returns the depend columns.
		/// </summary>
		/// <param name="columns">The columns.</param>
		/// <param name="parentColumn">The parent column.</param>
		/// <returns>
		/// Collection of depend columns.
		/// </returns>
		public virtual IEnumerable<ForecastColumn> GetDependColumns(IEnumerable<ForecastColumn> columns, ForecastColumn parentColumn) {
			var result = new List<ForecastColumn>();
			var formulaColumns = columns.Where(item => item.TypeId.Equals(ForecastConsts.FormulaColumnTypeId));
			foreach (var formulaColumn in formulaColumns) {
				if (HasReference(formulaColumn, parentColumn)) {
					result.Add(formulaColumn);
				}
			}
			return result;
		}

		/// <summary>
		/// Returns the reference columns.
		/// </summary>
		/// <param name="columns">The columns.</param>
		/// <param name="targetColumn">The target column.</param>
		/// <returns>
		/// Collection of reference columns.
		/// </returns>
		public IEnumerable<ForecastColumn> GetReferenceColumns(IEnumerable<ForecastColumn> columns, 
				ForecastColumn targetColumn) {
			if (!targetColumn.TypeId.Equals(ForecastConsts.FormulaColumnTypeId)) {
				return Enumerable.Empty<ForecastColumn>();
			}
			var formulaItems = GetFormulaItems(targetColumn);
			var columnItems = formulaItems?.Where(item => item.Type.Equals(FormulaItemType.Column));
			return columns.Where(column =>
				columnItems.Any(a =>
					a.Value.Equals(column.Id.ToString())
				)
			);
		}

		/// <summary>
		/// Deserializes the formula.
		/// </summary>
		/// <param name="column">The formula column.</param>
		/// <returns>
		/// Collection of <see cref="FormulaItem" />
		/// </returns>
		public IEnumerable<FormulaItem> DeserializeFormula(ForecastColumn column) {
			return GetFormulaItems(column);
		}

		/// <summary>
		/// Calculates the specified formula items.
		/// </summary>
		/// <param name="formulaItems">The formula items.</param>
		/// <param name="injectedValues">The injected values.</param>
		/// <returns>
		/// Calculated value.
		/// </returns>
		public decimal Calculate(IEnumerable<FormulaItem> formulaItems, IDictionary<string, string> injectedValues) {
			var formula = GetFormula(formulaItems, injectedValues);
			return GetCalculatedFormulaValue(formula);
		}

		/// <summary>
		/// Validates the specified formula items.
		/// </summary>
		/// <param name="formulaItems">The formula items.</param>
		/// <returns>
		/// It is valid formula.
		/// </returns>
		public bool Validate(IEnumerable<FormulaItem> formulaItems) {
			if (formulaItems == null) {
				return false;
			}
			if (!HasCorrectOrder(formulaItems)) {
				return false;
			}
			var testInjectableValues = GetTestInjectableColumnValues(formulaItems);
			var formula = GetFormula(formulaItems, testInjectableValues);
			try {
				var value = GetCalculatedFormulaValue(formula, false);
			}
			catch (Exception) {
				return false;
			}
			return true;
		}

		#endregion

	}

	#endregion

}
