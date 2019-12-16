namespace Terrasoft.Configuration.ForecastV2
{
	using System;
	using System.Collections.Generic;
	using System.Linq;

	/// <summary>
	/// Provides methods to map forecast data.
	/// </summary>
	public class ForecastDataMapper
	{

		#region Methods: Private

		private void FillColumnValues(ICollection<TableColumn> columns, Row row, TreeTableDataItem item) {
			foreach (TableColumn column in columns) {
				foreach (TableColumn child in column.Children) {
					var cell = row.Cells
						.FirstOrDefault(a => a.PeriodId.Equals(column.Id) &&
							a.ColumnId.Equals(child.Id));
					var tableCell = new TableCell {
						ColumnCode = child.Code + "_" + column.Code,
						GroupCode = column.Id.ToString(),
						Id = child.Id,
						RecordId = row.Id
					};
					if (cell != null) {
						tableCell.Value = (double)cell.Value;
					}
					item.ColumnValues.Add(tableCell);
				}
			}
		}

		private TreeTableDataItem GetTreeTableDataItem(Guid id, string caption) {
			return new TreeTableDataItem {
				Id = id,
				Caption = caption,
				ColumnValues = new List<TableCell>()
			};
		}

		#endregion

		#region Methods: Public

		/// <summary>Gets the map table columns.</summary>
		/// <param name="data">The forecast data.</param>
		/// <returns>Collection of <see cref="TableColumn"/></returns>
		public ICollection<TableColumn> GetMapTableColumns(ForecastData data) {
			var mapColumns = new List<TableColumn>();
			foreach (ColumnInfo column in data.Columns) {
				var periodCode = column.Period.Name.Replace(" ", "_");
				var item = mapColumns.FirstOrDefault(a => a.Code.Equals(periodCode));
				if (item == null) {
					item = new TableColumn {
						Id = column.Period.Id,
						Code = periodCode,
						Caption = column.Period.Name,
						Children = new List<TableColumn>()
					};
					mapColumns.Add(item);
				}
				if (!column.IsHide) {
					item.Children.Add(new TableColumn {
						Id = column.Id,
						Code = column.Id.ToString(),
						Caption = column.Title,
						IsEditable = column.TypeId == ForecastConsts.EditableColumnTypeId
					});
				}
			}
			return mapColumns;
		}

		/// <summary>Gets the map tree table data items.</summary>
		/// <param name="data">The forecast data.</param>
		/// <param name="columns">The forecast columns.</param>
		/// <returns>Collection of <see cref="TreeTableDataItem"/></returns>
		public ICollection<TreeTableDataItem> GetMapTreeTableDataItems(ForecastData data,
			   ICollection<TableColumn> columns) {
			var mapSourceData = new List<TreeTableDataItem>();
			foreach (Row row in data.Rows) {
				var item = GetTreeTableDataItem(row.Id, row.Value);
				if (row.Hierarchy.Any()) {
					FillColumnValues(columns, row, item);
				}
				mapSourceData.Add(item);
			}
			return mapSourceData;
		}

		#endregion
	}

}

