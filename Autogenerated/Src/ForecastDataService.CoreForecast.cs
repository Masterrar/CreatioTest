namespace Terrasoft.Configuration.ForecastV2
{
	using System;
	using System.Collections.Generic;
	using System.Globalization;
	using System.Linq;
	using System.Runtime.Serialization;
	using System.Security;
	using System.ServiceModel;
	using System.ServiceModel.Activation;
	using System.ServiceModel.Web;
	using System.Web;
	using Terrasoft.Common;
	using Terrasoft.Core.Factories;
	using Terrasoft.Core.Scheduler;
	using Terrasoft.Core.ServiceModelContract;
	using Terrasoft.Web.Common;

	#region Class: ForecastDataService

	[ServiceContract(Name = "forecast.api")]
	[AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Required)]
	public class ForecastDataService : BaseService
	{

		#region Class: ForecastDataResponse

		/// <summary>
		/// Provides properties of forecast data.
		/// </summary>
		[DataContract]
		public class ForecastDataResponse : ConfigurationServiceResponse
		{

			[DataMember(Name = "dataSource")]
			public ICollection<TreeTableDataItem> DataSource { get; set; }

			[DataMember(Name = "columns")]
			public ICollection<TableColumn> Columns { get; set; }

		}

		#endregion

		#region Class: ForecastSummaryResponse

		/// <summary>
		/// Provides properties of forecast summary.
		/// </summary>
		[DataContract]
		public class ForecastSummaryResponse : ConfigurationServiceResponse
		{

			[DataMember(Name = "summary")]
			public IDictionary<string, double> Summary { get; set; }

		}
		
		/// <summary>
		/// Provides properties of forecast formula cells summary.
		/// </summary>
		[DataContract]
		public class ForecastFormulaCellsSummaryResponse : ConfigurationServiceResponse
		{
			[DataMember(Name = "summary")]
			public IEnumerable<TableCell> Summary { get; set; }
		}

		#endregion

		#region Class: ForecastColumnsResponse

		/// <summary>
		/// Provides properties of forecast columns.
		/// </summary>
		[DataContract]
		public class ForecastColumnsResponse : ConfigurationServiceResponse
		{

			[DataContract]
			public class Column
			{

				[DataMember(Name = "name")]
				public string Name { get; set; }

				[DataMember(Name = "code")]
				public string Code { get; set; }

				[DataMember(Name = "typeId")]
				public Guid TypeId { get; set; }

				[DataMember(Name = "isHide")]
				public bool IsHide { get; set; }
				
				[DataMember(Name = "useInSummary")]
				public bool UseInSummary { get; set; }

			}

			[DataMember(Name = "columns")]
			public ICollection<Column> Columns { get; set; }

		}

		#endregion
		
		#region Constants: Private

		private const int MaxPeriodsCount = 24;
		
		#endregion

		#region Properties: Protected

		private IForecastProviderV2 _forecastProvider;

		/// <summary>Gets the forecast provider.</summary>
		/// <value>The forecast provider.</value>
		protected IForecastProviderV2 ForecastProvider =>
			_forecastProvider ?? (_forecastProvider = ClassFactory.Get<IForecastProviderV2>());

		private ForecastDataMapper _forecastDataMapper;

		/// <summary>Gets the forecast data mapper.</summary>
		/// <value>The forecast data mapper.</value>
		protected ForecastDataMapper ForecastDataMapper =>
			_forecastDataMapper ?? (_forecastDataMapper = ClassFactory.Get<ForecastDataMapper>());

		private IForecastSheetRepository _sheetRepository;

		/// <summary>Gets the forecast sheet repository.</summary>
		/// <value>The forecast sheet repository.</value>
		protected IForecastSheetRepository SheetRepository =>
			_sheetRepository ?? (_sheetRepository = ClassFactory.Get<IForecastSheetRepository>());

		private IForecastCellRepository _cellRepository;

		/// <summary>Gets the forecast cell repository.</summary>
		/// <value>The forecast cell repository.</value>
		protected IForecastCellRepository CellRepository =>
			_cellRepository ?? (_cellRepository = ClassFactory.Get<IForecastCellRepository>());

		private IForecastSummaryRepository _forecastSummary;

		/// <summary> Gets the forecast summary. </summary>
		/// <value> The forecast summary. </value>
		protected IForecastSummaryRepository ForecastSummary =>
			_forecastSummary ?? (_forecastSummary = ClassFactory.Get<IForecastSummaryRepository>());

		private IForecastColumnRepository _columnRepository;

		/// <summary> Gets the forecast columns repository. </summary>
		/// <value> The columns repository. </value>
		protected IForecastColumnRepository ColumnRepository =>
			_columnRepository ?? (_columnRepository = ClassFactory.Get<IForecastColumnRepository>());
		
		private IFormulaSummaryCalculator _formulaSummaryCalculator;

		/// <summary> Gets the forecast formula summary calculator. </summary>
		/// <value> The formula summary calculator. </value>
		protected IFormulaSummaryCalculator FormulaSummaryCalculator =>
			_formulaSummaryCalculator ?? (_formulaSummaryCalculator = ClassFactory.Get<IFormulaSummaryCalculator>());

		/// <summary> Gets the formula utilities. </summary>
		/// <value> The formula utilities. </value>
		protected FormulaUtilities FormulaUtilities => ClassFactory.Get<FormulaUtilities>();
		
		private IPeriodRepository _periodRepository;
		protected IPeriodRepository PeriodRepository =>
			_periodRepository ?? (_periodRepository = ClassFactory.Get<IPeriodRepository>());

		#region Methods: Private

		private void RecalculateColumns(Guid forecastId, IEnumerable<Guid> periodIds) {
			IDictionary<string, object> parameters = new Dictionary<string, object> {
				{ "ForecastId", forecastId },
				{ "PeriodIds", periodIds },
				{ "IsUseSystemUser", true }
			};
			var jobGroup = $"{typeof(ForecastCalculatorExecutor).Name}_{forecastId}";
			AppScheduler.RemoveJob(typeof(ForecastCalculatorExecutor).AssemblyQualifiedName, jobGroup);
			AppScheduler.TriggerJob<ForecastCalculatorExecutor>(jobGroup, UserConnection.Workspace.Name,
				UserConnection.CurrentUser.Name, parameters);
		}
		
		private IDictionary<string, double> ConvertCellsToSummary(IEnumerable<TableCell> summaryCells) {
			IDictionary<string, double> summary = new Dictionary<string, double>();
			summaryCells.ForEach(cell => {
				string code = cell.FormColumnCode();
				summary[code] = cell.Value;
			});
			return summary;
		}

		#endregion

		#endregion

		#region Methods: Private

		private IEnumerable<Guid> ConvertStringIdentifiersToGuidList(string str) {
			var ids = string.IsNullOrEmpty(str) ? new Guid[] { } : str.Split(',').Select(e => new Guid(e));
			return ids;
		}
		
		private List<TableCell> GetCellsToCalc(List<TableCell> summaryCells, IEnumerable<Period> periods) {
			var cellsToCalc = new List<TableCell>(summaryCells);
			periods.ForEach(p => {
				if (summaryCells.All(cell => cell.GroupCode != p.Name)) {
					cellsToCalc.Add(new TableCell {
						GroupCode = p.Name,
						ColumnCode = ""
					});
				}
			});
			return cellsToCalc;
		}

		#endregion

		#region Methods: Public

		/// <summary>
		/// Returns forecast data.
		/// </summary>
		/// <param name="forecastId">Forecast identifier.</param>
		/// <param name="periods">Collection of periods identifier. Values separated by comma.</param>
		/// <returns><see cref="ForecastDataResponse"/></returns>
		[OperationContract]
		[WebInvoke(Method = "GET",
			UriTemplate = "/forecast/{forecastId}" +
				"?periods={periods}&offset={offset}&count={count}&lastRow={lastRow}&hierarchyRows={hierarchyRows}&filterValue={filterValue}",
			BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json,
			ResponseFormat = WebMessageFormat.Json)]
		public ForecastDataResponse GetForecastData(string forecastId, string periods, string offset, string count,
			string lastRow, string hierarchyRows, string filterValue) {
			var response = new ForecastDataResponse();
			try {
				var periodIds = ConvertStringIdentifiersToGuidList(periods);
				var hierarchyRowsId = ConvertStringIdentifiersToGuidList(hierarchyRows);
				int rowCount = int.TryParse(count, out rowCount) ? rowCount : -1;
				int rowOffset = int.TryParse(offset, out rowOffset) ? rowOffset : 0;
				int hierarchyLevel = hierarchyRowsId.Count();
				var pageableConfig = new PageableConfig() {
					RowCount = rowCount,
					RowsOffset = rowOffset,
					LastValue = lastRow,
					HierarchyRowsId = hierarchyRowsId,
					HierarchyLevel = hierarchyLevel,
					PrimaryFilterValue = HttpUtility.UrlDecode(filterValue)
				};
				var data = ForecastProvider.GetData(new Guid(forecastId), periodIds, pageableConfig);
				response.Columns = ForecastDataMapper.GetMapTableColumns(data);
				response.DataSource = ForecastDataMapper.GetMapTreeTableDataItems(data, response.Columns);
			} catch (Exception ex) {
				response.Exception = ex;
			}
			return response;
		}

		[OperationContract]
		[WebInvoke(Method = "GET", UriTemplate = "/forecast/{forecastId}/summary?periods={periods}",
			BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json,
			ResponseFormat = WebMessageFormat.Json)]
		public ForecastSummaryResponse GetSummary(string forecastId, string periods) {
			var response = new ForecastSummaryResponse();
			try {
				var sheetId = new Guid(forecastId);
				var sheet = SheetRepository.GetSheet(sheetId);
				var periodInfos = PeriodRepository.GetForecastPeriods(
					ConvertStringIdentifiersToGuidList(periods), 
					sheet.PeriodTypeId);
				var summaryCells = ForecastSummary.GetSummary(sheetId, periodInfos.Select(p => p.Id)).ToList();
				var cellsToCalc = GetCellsToCalc(summaryCells, periodInfos);
				if (UserConnection.GetIsFeatureEnabled("CalcTotalByFormula")) {
					var formulaSummaryCells = FormulaSummaryCalculator.CalcFormulaSummary(
						new FormulaSummaryParams {
							ForecastId = sheetId,
							Cells = cellsToCalc
						});
					summaryCells.AddRange(formulaSummaryCells);
				}
				response.Summary = ConvertCellsToSummary(summaryCells);
			} catch (Exception ex) {
				response.Exception = ex;
			}
			return response;
		}
		
		
		/// <summary>
		/// Calculates formulas summary according to formulas dependent cells values.
		/// </summary>
		/// <param name="forecastId">Forecast sheet identifier.</param>
		/// <param name="summaryData">Cell values used in formulas.</param>
		/// <returns>Calculated formula summary cells.</returns>
		[OperationContract]
		[WebInvoke(Method = "POST", UriTemplate = "/forecast/formula/summary",
			BodyStyle = WebMessageBodyStyle.Wrapped, RequestFormat = WebMessageFormat.Json,
			ResponseFormat = WebMessageFormat.Json)]
		public ForecastFormulaCellsSummaryResponse GetFormulaSummary(Guid forecastId, 
				TableCell[] summaryData) {
			var response = new ForecastFormulaCellsSummaryResponse();
			try {
				response.Summary = FormulaSummaryCalculator.CalcFormulaSummary(
					new FormulaSummaryParams {
						ForecastId = forecastId,
						Cells = summaryData
					});
			} catch (Exception ex) {
				response.Exception = ex;
			}
			return response;
		}

		[OperationContract]
		[WebInvoke(Method = "POST", UriTemplate = "/forecast/calc", BodyStyle = WebMessageBodyStyle.Wrapped,
			RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
		public ConfigurationServiceResponse RecalculateFact(Guid forecastId, string[] periods) {
			var response = new ConfigurationServiceResponse();
			try {
				var userAdminUnitCollection = UserConnection.DBSecurityEngine.GetUserAdminUnitCollection();
				if (userAdminUnitCollection.Any(id =>
					id.Equals(ForecastConsts.FinanceRoleId) ||
					id.Equals(BaseConsts.SystemAdministratorsSysAdminUnitId))) {
					IEnumerable<Guid> periodIds = periods.Select(p => new Guid(p)).Take(MaxPeriodsCount);
					RecalculateColumns(forecastId, periodIds.ToList());
				} else {
					throw new SecurityException(new LocalizableString("Terrasoft.Core",
						"ProcessSchemaManager.Exception.NoRightForModify"));
				}
			} catch (Exception ex) {
				response.Exception = ex;
			}
			return response;
		}

		[OperationContract]
		[WebInvoke(Method = "POST", UriTemplate = "/forecast/cell", BodyStyle = WebMessageBodyStyle.Wrapped,
			RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
		public ConfigurationServiceResponse SaveCell(Guid forecastId, Guid recordId, Guid periodId, Guid columnId,
			string value) {
			var response = new ConfigurationServiceResponse();
			var sheet = SheetRepository.GetSheet(forecastId);
			try {
				CellRepository.SaveCell(sheet, new Cell {
					EntityId = recordId,
					PeriodId = periodId,
					ColumnId = columnId,
					Value = Convert.ToDecimal(value, CultureInfo.InvariantCulture)
				});
			} catch (Exception ex) {
				response.Exception = ex;
			}
			return response;
		}

		/// <summary>
		/// Deletes forecast cells.
		/// </summary>
		/// <param name="forecastId">Forecast identifier.</param>
		/// <param name="columnId">Forecast column identifier.</param>
		/// <param name="periods">Collection of periods identifiers</param>
		/// <returns><see cref="ConfigurationServiceResponse"/></returns>
		[OperationContract]
		[WebInvoke(Method = "POST", UriTemplate = "/forecast/cells/delete", BodyStyle = WebMessageBodyStyle.Wrapped,
			RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
		public ConfigurationServiceResponse DeleteCells(Guid forecastId, Guid columnId, Guid[] periods) {
			periods = periods ?? new Guid[0];
			var periodCollection = periods.Select(id => new Period {
				Id = id
			});
			var response = new ConfigurationServiceResponse();
			try {
				var sheet = SheetRepository.GetSheet(forecastId);
				CellRepository.DeleteCells(sheet, periodCollection, new[] {
					new ForecastColumn() {
						Id = columnId
					}
				});
			} catch (Exception ex) {
				response.Exception = ex;
			}
			return response;
		}

		/// <summary>
		/// Returns localizable data.
		/// </summary>
		/// <param name="keys">Resources keys. Values separated by comma.</param>
		/// <returns>Dictionary of localizable strings.</returns>
		[OperationContract]
		[WebInvoke(Method = "GET", UriTemplate = "/forecast/lcz/{keysStr}", BodyStyle = WebMessageBodyStyle.Bare,
			RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
		public Dictionary<string, string> GetLczData(string keysStr) {
			string[] keys = keysStr.Split(',');
			var resources = new Dictionary<string, string>();
			foreach (string key in keys) {
				resources[key] = UserConnection.GetLocalizableString("ForecastResources", key);
			}
			return resources;
		}

		/// <summary>
		/// Returns <c>true</c>, if valid, <c>false</c> otherwise.
		/// </summary>
		/// <param name="columnTypeId">The column type identifier.</param>
		/// <param name="settings">The settings.</param>
		/// <returns>Returns <c>true</c>, if valid, <c>false</c> otherwise.</returns>
		[OperationContract]
		[WebInvoke(Method = "POST", UriTemplate = "/forecast/column/validate", BodyStyle = WebMessageBodyStyle.Wrapped,
			RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
		public ConfigurationServiceResponse GetIsValidColumn(Guid columnTypeId, string settings) {
			var response = new ConfigurationServiceResponse();
			if (columnTypeId.Equals(ForecastConsts.FormulaColumnTypeId)) {
				var formulaItems = FormulaUtilities.DeserializeFormula(new ForecastColumn {
					Settings = settings
				});
				var isValid = FormulaUtilities.Validate(formulaItems);
				response.Success = isValid;
				if (!isValid) {
					var message = UserConnection.GetLocalizableString("ForecastResources", "FormulaNotValidMessage");
					response.ErrorInfo = new ErrorInfo {
						Message = message
					};
				}
			}
			return response;
		}

		/// <summary>
		/// Deletes column.
		/// </summary>
		/// <param name="columnId">The column identifier.</param>
		/// <param name="sheetId">The forecast sheet identifier.</param>
		/// <returns>Returns <c>true</c>, if valid, <c>false</c> otherwise.</returns>
		[OperationContract]
		[WebInvoke(Method = "POST", UriTemplate = "/forecast/column/delete", BodyStyle = WebMessageBodyStyle.Wrapped,
			RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
		public ConfigurationServiceResponse DeleteColumn(Guid columnId, Guid sheetId) {
			var response = new ConfigurationServiceResponse();
			var isSuccess = false;
			IEnumerable<ForecastColumn> columns = ColumnRepository.GetColumns(sheetId);
			ForecastColumn column = columns.FirstOrDefault(c => c.Id == columnId);
			if (column != null) {
				try {
					var formulaColumns = FormulaUtilities.GetDependColumns(columns, column);
					if (!formulaColumns.Any()) {
						var sheet = SheetRepository.GetSheet(sheetId);
						isSuccess = ColumnRepository.Delete(sheet, columnId);
					} else {
						var messageTemplate =
							UserConnection.GetLocalizableString("ForecastResources", "ColumnUsedInFormula");
						var message = string.Format(messageTemplate, formulaColumns.First().Name);
						response.ErrorInfo = new ErrorInfo {
							Message = message
						};
					}
				} catch (Exception ex) {
					response.Exception = ex;
				}
			} else {
				response.Exception = new KeyNotFoundException(columnId.ToString());
			}
			response.Success = isSuccess;
			return response;
		}

		/// <summary>
		/// Gets forecast columns of sheet.
		/// </summary>
		/// <param name="forecastId">Forecast identifier.</param>
		/// <returns><see cref="ForecastColumnsResponse"/></returns>
		[OperationContract]
		[WebInvoke(Method = "GET", UriTemplate = "/forecast/{forecastId}/columns", BodyStyle = WebMessageBodyStyle.Bare,
			RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
		public ForecastColumnsResponse GetColumns(string forecastId) {
			var response = new ForecastColumnsResponse();
			try {
				var sheetId = new Guid(forecastId);
				ICollection<ForecastColumnsResponse.Column> columns = ColumnRepository.GetColumns(sheetId).Select(c =>
					new ForecastColumnsResponse.Column {
						Name = c.Name,
						Code = c.Code,
						TypeId = c.TypeId,
						UseInSummary = c.GetColumnSettings<FormulaSetting>().UseInSummary
					}).ToList();
				response.Columns = columns;
			} catch (Exception ex) {
				response.Exception = ex;
			}
			return response;
		}
		/// <summary>
		/// Get forecast cell values for specified records.
		/// </summary>
		/// <param name="forecastId">Forecast identifier.</param>
		/// <param name="periods">Periods identifiers.</param>
		/// <param name="records">Records identifiers.</param>
		/// <returns></returns>

		[OperationContract]
		[WebInvoke(Method = "POST", UriTemplate = "/forecast/cell/records",
			BodyStyle = WebMessageBodyStyle.WrappedRequest,
			RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
		public ForecastDataResponse GetCellValuesByRecords(Guid forecastId, Guid[] periods, Guid[] records) {
			var response = new ForecastDataResponse();
			var data = ForecastProvider.GetData(forecastId, new FilterConfig {
				PeriodIds = periods,
				RecordIds = records
			});
			response.Columns = ForecastDataMapper.GetMapTableColumns(data);
			response.DataSource = ForecastDataMapper.GetMapTreeTableDataItems(data, response.Columns);
			return response;
		}

		#endregion

	}
	
	#endregion
	
	#region Classes: POCO

	[DataContract]
	public class TreeTableDataItem
	{
		[DataMember(Name = "id")]
		public Guid Id { get; set; }

		[DataMember(Name = "caption")]
		public string Caption { get; set; }

		[DataMember(Name = "columnValues")]
		public ICollection<TableCell> ColumnValues { get; set; }

	}

	[DataContract]
	public class TableCell
	{
		[DataMember(Name = "id")]
		public Guid Id { get; set; }

		[DataMember(Name = "columnCode")]
		public string ColumnCode { get; set; }

		[DataMember(Name = "recordId")]
		public Guid RecordId { get; set; }

		[DataMember(Name = "groupCode")]
		public string GroupCode { get; set; }

		[DataMember(Name = "value")]
		public double Value { get; set; }

		/// <summary>
		/// Forms column code from column code and group code.
		/// </summary>
		/// <returns></returns>
		public string FormColumnCode() {
			return string.Join("_", ColumnCode, GroupCode.Replace(" ", "_"));
		}

	}

	[DataContract]
	public class TableColumn
	{
		[DataMember(Name = "id")]
		public Guid Id { get; set; }

		[DataMember(Name = "code")]
		public string Code { get; set; }

		[DataMember(Name = "caption")]
		public string Caption { get; set; }

		[DataMember(Name = "children")]
		public ICollection<TableColumn> Children { get; set; }

		[DataMember(Name = "isEditable")]
		public bool IsEditable { get; set; }

		[DataMember(Name = "isHide")]
		public bool IsHide { get; set; }

	}

	#endregion

}

