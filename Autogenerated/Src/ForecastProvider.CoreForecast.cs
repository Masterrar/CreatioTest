namespace Terrasoft.Configuration.ForecastV2
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Runtime.Serialization;
	using Core;
	using Terrasoft.Common;
	using Terrasoft.Core.Factories;

	#region Interface: IForecastProvider

	/// <summary>
	/// Provides method of select forecast data.
	/// </summary>
	public interface IForecastProvider
	{

		/// <summary>
		/// Gets the forecast data with pagination options.
		/// </summary>
		/// <param name="forecastId">The forecast identifier.</param>
		/// <param name="periodIds">The period ids.</param>
		/// <param name="pageableConfig">The pageable configuration.</param>
		/// <returns>
		///   <see cref="ForecastData" />
		/// </returns>
		ForecastData GetData(Guid forecastId, IEnumerable<Guid> periodIds, PageableConfig pageableConfig);

		/// <summary>
		/// Gets the forecast data.
		/// </summary>
		/// <param name="forecastId">The forecast identifier.</param>
		/// <param name="periodIds">The period ids.</param>
		/// <returns>
		///   <see cref="ForecastData" />
		/// </returns>
		ForecastData GetData(Guid forecastId, IEnumerable<Guid> periodIds);
	}

	#endregion

	#region Interface: ForecastProviderV2

	///<inheritdoc />
	public interface IForecastProviderV2 : IForecastProvider
	{
		/// <summary>
		/// Gets the forecast data with filter options.
		/// </summary>
		/// <param name="forecastId">The forecast identifier.</param>
		/// <param name="filterConfig">Filter configuration.</param>
		/// <returns>
		///   <see cref="ForecastData" />
		/// </returns>
		ForecastData GetData(Guid forecastId, FilterConfig filterConfig);
	}

	#endregion

	#region Classes: Data Transfer Objects

	/// <summary>
	/// The pageable configuration.
	/// </summary>
	public class PageableConfig
	{
		/// <summary>
		/// Gets or sets the row count.
		/// </summary>
		/// <value>
		/// The row count.
		/// </value>
		public int RowCount { get; set; }
		/// <summary>
		/// Gets or sets the rows offset.
		/// </summary>
		/// <value>
		/// The rows offset.
		/// </value>
		public int RowsOffset { get; set; }

		/// <summary>
		/// Gets or sets the hierarchy level.
		/// </summary>
		/// <value>
		/// The hierarchy level.
		/// </value>
		public int HierarchyLevel { get; set; }

		/// <summary>
		/// Gets or sets the last value.
		/// </summary>
		/// <value>
		/// The last value.
		/// </value>
		public string LastValue { get; set; }

		/// <summary>
		/// Gets or sets the primary filter value.
		/// </summary>
		/// <value>
		/// The primary filter value.
		/// </value>
		public string PrimaryFilterValue { get; set; }

		/// <summary>
		/// Gets or sets the hierarchy rows identifier.
		/// </summary>
		/// <value>
		/// The hierarchy rows identifier.
		/// </value>
		public IEnumerable<Guid> HierarchyRowsId { get; set; }
	}

	/// <summary>
	/// The forecast data.
	/// </summary>
	[DataContract]
	public class ForecastData
	{
		/// <summary>
		/// Gets or sets the columns.
		/// </summary>
		/// <value>
		/// The columns.
		/// </value>
		[DataMember(Name = "columns")]
		public IEnumerable<ColumnInfo> Columns { get; set; }
		/// <summary>
		/// Gets or sets the rows.
		/// </summary>
		/// <value>
		/// The rows.
		/// </value>
		[DataMember(Name = "rows")]
		public IEnumerable<Row> Rows { get; set; }
	}

	/// <summary>
	/// The column information.
	/// </summary>
	[DataContract]
	public class ColumnInfo
	{
		/// <summary>
		/// Gets or sets the period.
		/// </summary>
		/// <value>
		/// The period.
		/// </value>
		[DataMember(Name = "period")]
		public Item Period { get; set; }
		/// <summary>
		/// Gets or sets the indicator.
		/// </summary>
		/// <value>
		/// The indicator.
		/// </value>
		[DataMember(Name = "indicator")]
		public Item Indicator { get; set; }

		/// <summary>
		/// Gets or sets the identifier.
		/// </summary>
		/// <value>
		/// The identifier.
		/// </value>
		public Guid Id { get; set; }

		/// <summary>
		/// Gets or sets the title.
		/// </summary>
		/// <value>
		/// The title.
		/// </value>
		public string Title { get; set; }

		/// <summary>
		/// Gets or sets the type identifier.
		/// </summary>
		/// <value>
		/// The type identifier.
		/// </value>
		public Guid TypeId { get; set; }

		/// <summary>
		/// Gets or sets sign of hiding column.
		/// </summary>
		/// <value>
		/// Sign of hiding.	
		/// </value>
		public bool IsHide { get; set; }
	}

	/// <summary>
	/// The item of column information.
	/// </summary>
	[DataContract]
	public class Item
	{
		/// <summary>
		/// Gets or sets the identifier.
		/// </summary>
		/// <value>
		/// The identifier.
		/// </value>
		[DataMember(Name = "id")]
		public Guid Id { get; set; }
		/// <summary>
		/// Gets or sets the name.
		/// </summary>
		/// <value>
		/// The name.
		/// </value>
		[DataMember(Name = "name")]
		public string Name { get; set; }
		/// <summary>
		/// Gets or sets the code.
		/// </summary>
		/// /// <value>
		/// Item unique text code.
		/// </value>
		[DataMember(Name = "code")]
		public string Code { get; set; }
	}

	/// <summary>
	/// The forecast row.
	/// </summary>
	[DataContract]
	public class Row
	{
		[DataMember(Name = "id")]
		public Guid Id { get; set; }

		[DataMember(Name = "value")]
		public string Value { get; set; }

		/// <summary>
		/// Gets or sets the hierarchy.
		/// </summary>
		/// <value>
		/// The hierarchy.
		/// </value>
		[DataMember(Name = "hierarchy")]
		public IEnumerable<HierarchyItem> Hierarchy { get; set; }

		/// <summary>
		/// Gets or sets the cells.
		/// </summary>
		/// <value>
		/// The cells.
		/// </value>
		[DataMember(Name = "cells")]
		public IEnumerable<Cell> Cells { get; set; }
	}

	/// <summary>
	/// The item of forecast hierarchy.
	/// </summary>
	[DataContract]
	public class HierarchyItem
	{
		/// <summary>
		/// Gets or sets the value.
		/// </summary>
		/// <value>
		/// The value.
		/// </value>
		[DataMember(Name = "value")]
		public string Value { get; set; }

		/// <summary>
		/// Gets or sets the identifier.
		/// </summary>
		/// <value>
		/// The value.
		/// </value>
		[DataMember(Name = "id")]
		public Guid Id { get; set; }

		/// <summary>
		/// Gets or sets the level.
		/// </summary>
		/// <value>
		/// The level.
		/// </value>
		[DataMember(Name = "level")]
		public int Level { get; set; }

	}

	/// <summary>
	/// The forecast cell.
	/// </summary>
	[DataContract]
	public class Cell
	{
		/// <summary>
		/// Gets or sets cell identifier.
		/// </summary>
		/// <value>
		/// Cell identifier.
		/// </value>
		[DataMember(Name = "id")]
		public Guid Id { get; set; }
		/// <summary>
		/// Gets or sets the period identifier.
		/// </summary>
		/// <value>
		/// The period identifier.
		/// </value>
		[DataMember(Name = "periodId")]
		public Guid PeriodId { get; set; }
		/// <summary>
		/// Gets or sets the entity identifier.
		/// </summary>
		/// <value>
		/// The entity identifier.
		/// </value>
		[DataMember(Name = "entityId")]
		public Guid EntityId { get; set; }
		/// <summary>
		/// Gets or sets the indicator identifier.
		/// </summary>
		/// <value>
		/// The indicator identifier.
		/// </value>
		[DataMember(Name = "indicatorId")]
		public Guid IndicatorId { get; set; }
		/// <summary>
		/// Gets or sets the indicator code.
		/// </summary>
		/// <value>
		/// Indicator unique text code.
		/// </value>
		[DataMember(Name = "indicatorCode")]
		public string IndicatorCode { get; set; }
		/// <summary>
		/// Gets or sets the value.
		/// </summary>
		/// <value>
		/// The value.
		/// </value>
		[DataMember(Name = "value")]
		public decimal Value { get; set; }
		/// <summary>
		/// Gets or sets the row identifier.
		/// </summary>
		/// <value>
		/// Connected forecast row identifier.
		/// </value>
		[DataMember(Name = "rowId")]
		public Guid RowId { get; set; }

		/// <summary>
		/// Gets or sets the column identifier.
		/// </summary>
		/// <value>
		/// Connected forecast row identifier.
		/// </value>
		[DataMember(Name = "columnId")]
		public Guid ColumnId { get; set; }
	}
	
	/// <summary>
	/// Filter data configuration.
	/// </summary>
	public partial class FilterConfig
	{
		/// <summary>
		/// Identifiers of periods.
		/// </summary>
		public IEnumerable<Guid> PeriodIds { get; set; }
		
		/// <summary>
		/// Identifiers of records.
		/// </summary>
		public IEnumerable<Guid> RecordIds { get; set; }
	}	

	#endregion

	#region Class: ForecastProvider

	/// <summary>
	/// Provides method of select forecast data.
	/// </summary>
	/// <seealso cref="Terrasoft.Configuration.ForecastV2.IForecastProviderV2" />
	[DefaultBinding(typeof(IForecastProvider))]
	[DefaultBinding(typeof(IForecastProviderV2))]
	public class ForecastProvider : IForecastProviderV2
	{

		#region Constructor: Public

		public ForecastProvider(IForecastSheetRepository sheetRepository, IForecastColumnRepository columnRepository,
				IPeriodRepository periodRepository, IEntityInForecastCellRepository entityInForecastCellRepository,
				IForecastHierarchyRowDataRepository hierarchyRowDataRepository) {
			sheetRepository.CheckArgumentNull(nameof(sheetRepository));
			columnRepository.CheckArgumentNull(nameof(columnRepository));
			periodRepository.CheckArgumentNull(nameof(periodRepository));
			entityInForecastCellRepository.CheckArgumentNull(nameof(entityInForecastCellRepository));
			hierarchyRowDataRepository.CheckArgumentNull(nameof(hierarchyRowDataRepository));
			SheetRepository = sheetRepository;
			ColumnRepository = columnRepository;
			PeriodRepository = periodRepository;
			EntityInForecastCellRepository = entityInForecastCellRepository;
			ForecastHierarchyRowDataRepository = hierarchyRowDataRepository;
		}

		#endregion

		#region Properties: Protected

		protected IForecastSheetRepository SheetRepository { get; }
		protected IForecastColumnRepository ColumnRepository { get; }
		protected IPeriodRepository PeriodRepository { get; }
		protected IEntityInForecastCellRepository EntityInForecastCellRepository { get; }
		public IForecastHierarchyRowDataRepository ForecastHierarchyRowDataRepository { get; }

		#endregion

		#region Methods: Private

		private IEnumerable<ColumnInfo> FillColumns(IEnumerable<ForecastColumn> forecastColumns,
				IEnumerable<Period> periods) {
			var columns = new List<ColumnInfo>();
			foreach (var period in periods) {
				foreach (var column in forecastColumns) {
					columns.Add(new ColumnInfo {
						Period = new Item {
							Id = period.Id,
							Name = period.Name
						},
						Indicator = new Item {
							Id = column.Id,
							Name = column.Name,
							Code = column.Code
						},
						Id = column.Id,
						Title = column.Name,
						TypeId = column.TypeId,
						IsHide = column.IsHide
					});
				}
			}

			return columns;
		}

		private ForecastData InnerGetData(Guid forecastId, IEnumerable<Guid> periodIds,
				PageableConfig pageableConfig) {
			forecastId.CheckArgumentEmpty(nameof(forecastId));
			Sheet sheet = SheetRepository.GetSheet(forecastId);
			IEnumerable<Period> periods = PeriodRepository.GetForecastPeriods(periodIds, sheet.PeriodTypeId);
			IEnumerable<ColumnInfo> columns = GetColumnInfos(forecastId, periods);
			IEnumerable<HierarchyRow> hierarchyRows = ForecastHierarchyRowDataRepository
				.GetHierarchyRows(sheet, sheet.Setting?.Hierarchy, pageableConfig);
			List<Row> rows = new List<Row>();
			var maxLevel = sheet.Setting?.Hierarchy?.Count() ?? 0;
			IEnumerable<Cell> allCells = new List<Cell>();
			var hierarchy = new List<HierarchyItem>();
			if ((pageableConfig.HierarchyLevel == maxLevel) && (hierarchyRows.Any())) {
				allCells = EntityInForecastCellRepository.GetCellsByRecords(sheet,
								periods.Select(e => e.Id),
								hierarchyRows.Select(r => r.RecordId));
				hierarchy.Add(new HierarchyItem {
					Id = Guid.NewGuid(),
					Level = maxLevel
				});
			}
			hierarchyRows.ForEach(hr => {
				IEnumerable<Cell> cells = allCells.Where(c => c.EntityId == hr.RecordId);
				rows.Add(new Row {
					Id = hr.RecordId,
					Value = hr.Value,
					Hierarchy = hierarchy,
					Cells = cells
				});
			});
			return new ForecastData {
				Columns = columns,
				Rows = rows
			};
		}
		
		private IEnumerable<ColumnInfo> GetColumnInfos(Guid forecastId, IEnumerable<Period> periods) {
			IEnumerable<ForecastColumn> forecastColumns = ColumnRepository.GetColumns(forecastId);
			return FillColumns(forecastColumns, periods);
		}

		#endregion

		#region Methods: Public

		///<inheritdoc />
		public ForecastData GetData(Guid forecastId, IEnumerable<Guid> periodIds) {
			return InnerGetData(forecastId, periodIds, new PageableConfig() {
				HierarchyLevel = 0,
				RowCount = -1
			});
		}

		///<inheritdoc />
		public ForecastData GetData(Guid forecastId, IEnumerable<Guid> periodIds,
				PageableConfig pageableConfig) {
			pageableConfig.CheckArgumentNull(nameof(pageableConfig));
			return InnerGetData(forecastId, periodIds, pageableConfig);
		}

		///<inheritdoc />
		public ForecastData GetData(Guid forecastId, FilterConfig filterConfig) {
			filterConfig.CheckArgumentNull(nameof(filterConfig));
			filterConfig.RecordIds.CheckArgumentNull(nameof(filterConfig.RecordIds));
			var sheet = SheetRepository.GetSheet(forecastId);
			var recordIds = filterConfig.RecordIds;
			IEnumerable<Period> periods = PeriodRepository.GetForecastPeriods(filterConfig.PeriodIds, sheet.PeriodTypeId);
			var periodIds = periods.Select(p => p.Id);
			var allCells = EntityInForecastCellRepository.GetCellsByRecords(sheet, periodIds, recordIds);
			var columns = GetColumnInfos(forecastId, periods);
			List<Row> rows = new List<Row>();
			recordIds.ForEach(recordId => {
				IEnumerable<Cell> cells = allCells.Where(c => c.EntityId == recordId);
				rows.Add(new Row {
					Id = recordId,
					Hierarchy = new [] { new HierarchyItem() },
					Cells = cells
				});
			});
			return new ForecastData() { Rows = rows, Columns = columns };
		}

		#endregion

	}

	#endregion

}


