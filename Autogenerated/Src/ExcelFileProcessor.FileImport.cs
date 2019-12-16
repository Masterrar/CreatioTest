namespace Terrasoft.Configuration.FileImport
{
	using DocumentFormat.OpenXml.Packaging;
	using DocumentFormat.OpenXml.Spreadsheet;
	using System;
	using System.Collections.Generic;
	using System.IO;
	using System.Linq;
	using System.Text.RegularExpressions;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Factories;
	using Terrasoft.Web.Http.Abstractions;

	#region Class: ExcelFileProcessor

	/// <summary>
	/// An instance of this class is responsible for processing an Excel file.
	/// </summary>
	public class ExcelFileProcessor : IFileProcessor
	{

		#region Constructors: Public

		/// <summary>
		/// Creates instance of type <see cref="ExcelFileProcessor"/>.
		/// </summary>
		/// <param name="userConnection">User connection.</param>
		public ExcelFileProcessor(UserConnection userConnection) => UserConnection = userConnection;

		/// <summary>
		/// Creates instance of type <see cref="ExcelFileProcessor"/>.
		/// </summary>
		/// <param name="userConnection">User connection.</param>
		/// <param name="parameters">File import parameters.</param>
		public ExcelFileProcessor(UserConnection userConnection, ImportParameters parameters): this(userConnection) => Parameters = parameters;

		#endregion

		#region Fields: Private

		private readonly Regex _cellColumnIndexRegex = new Regex("[A-Za-z]+");
		private readonly Regex _cellRowIndexRegex = new Regex("[0-9]+");
		private IColumnsAggregatorFactory _columnsAggregatorFactory;

		#endregion

		#region Fields: Protected

		protected readonly string replaceableSymbol = "_x000D_";

		#endregion

		#region Properties: Private

		private IColumnsAggregatorFactory ColumnsAggregatorFactory => _columnsAggregatorFactory ??
				(_columnsAggregatorFactory = ClassFactory.Get<IColumnsAggregatorFactory>());

		#endregion

		#region Properties: Protected

		/// <summary>
		/// User connection.
		/// </summary>
		protected UserConnection UserConnection { get; }

		private bool _sharedStringItemsValuesInitialized;
		private List<string> _sharedStringItemsValues;

		/// <summary>
		/// Shared string items values.
		/// </summary>
		protected List<string> SharedStringItemsValues {
			get {
				if (!_sharedStringItemsValuesInitialized) {
					IEnumerable<SharedStringItem> sharedStringItems = GetSharedStringItems(WorkbookPart);
					_sharedStringItemsValues = GetSharedStringItemsValues(sharedStringItems);
					_sharedStringItemsValuesInitialized = true;
				}
				return _sharedStringItemsValues;
			}
		}

		private Guid _rootSchemaUId;
		private EntitySchema _rootSchema;

		/// <summary>
		/// Root schema.
		/// </summary>
		protected EntitySchema RootSchema {
			get {
				if (_rootSchema != null) {
					return _rootSchema;
				}
				return _rootSchema = UserConnection.EntitySchemaManager.GetInstanceByUId(_rootSchemaUId);
			}
		}

		private INonPersistentColumnsAggregator _columnsProcessor;

		/// <summary>
		/// Columns processor.
		/// </summary>
		protected INonPersistentColumnsAggregator ColumnsProcessor => _columnsProcessor ??
				(_columnsProcessor = ColumnsAggregatorFactory?.GetColumnsAggregator(UserConnection));

		/// <summary>
		/// File import parameters.
		/// </summary>
		protected ImportParameters Parameters { get; set; }

		private ImportObject _importObject;

		/// <summary>
		/// Import object.
		/// </summary>
		protected ImportObject ImportObject {
			get => _importObject ?? (_importObject = new ImportObject());
			set => _importObject = value;
		}

		private WorkbookPart _workbookPart;

		/// <summary>
		/// Workbook part.
		/// </summary>
		protected WorkbookPart WorkbookPart {
			get => _workbookPart;
			set {
				_sharedStringItemsValuesInitialized = false;
				_workbookPart = value;
			}
		}

		#endregion

		#region Methods: Private

		/// <summary>
		/// Gets the first child sheet part.
		/// </summary>
		/// <param name="workbookPart">Workbook part.</param>
		/// <returns>The first child sheet part.</returns>
		private WorksheetPart GetWorksheetPart(WorkbookPart workbookPart) {
			IEnumerable<Sheet> sheets = workbookPart.Workbook.Descendants<Sheet>();
			Sheet firstSheet = sheets.First();
			WorksheetPart worksheetPart = (WorksheetPart)WorkbookPart.GetPartById(firstSheet.Id);
			return worksheetPart;
		}

		/// <summary>
		/// Gets a collection of shared string table items.
		/// </summary>
		/// <param name="workbookPart">Workbook part.</param>
		/// <returns>A collection of shared string table items.</returns>
		private IEnumerable<SharedStringItem> GetSharedStringItems(WorkbookPart workbookPart) {
			SharedStringTablePart sharedStringTablePart = workbookPart.SharedStringTablePart;
			SharedStringTable sharedStringTable = sharedStringTablePart.SharedStringTable;
			return sharedStringTable.Elements<SharedStringItem>();
		}

		/// <summary>
		/// Gets shared string items values.
		/// </summary>
		/// <param name="sharedStringItems">Shared string items.</param>
		/// <returns>Shared string items values.</returns>
		private List<string> GetSharedStringItemsValues(IEnumerable<SharedStringItem> sharedStringItems) {
			List<string> sharedStringItemValues = new List<string>();
			foreach (SharedStringItem item in sharedStringItems) {
				sharedStringItemValues.Add(item.InnerText);
			}
			return sharedStringItemValues;
		}

		/// <summary>
		/// Processes given spreadsheet document.
		/// </summary>
		/// <param name="spreadsheetDocument">Spreadsheet document.</param>
		private void ProcessSpreadsheetDocument(SpreadsheetDocument spreadsheetDocument) {
			WorkbookPart = spreadsheetDocument.WorkbookPart;
			WorksheetPart worksheetPart = GetWorksheetPart(WorkbookPart);
			ProcessWorksheetPart(worksheetPart);
		}

		/// <summary>
		/// Processes given worksheet part.
		/// </summary>
		/// <param name="worksheetPart">Worksheet part.</param>
		private void ProcessWorksheetPart(WorksheetPart worksheetPart) {
			Worksheet worksheet = worksheetPart.Worksheet;
			SheetData sheetData = worksheet.GetFirstChild<SheetData>();
			ProcessSheetData(sheetData);
		}

		/// <summary>
		/// Processes given sheet data.
		/// </summary>
		/// <param name="sheetData">Sheet data.</param>
		private void ProcessSheetData(SheetData sheetData) {
			IEnumerable<Row> rows = sheetData.Elements<Row>();
			IEnumerable<Cell> header = GetHeader(rows);
			Parameters.HeaderColumnsValues = ProcessCells(header);
			IEnumerable<Row> table = GetTable(rows);
			List<ImportEntity> entities = ProcessTable(table);
			Parameters.SetEntities(entities);
		}

		/// <summary>
		/// Gets header cells.
		/// </summary>
		/// <param name="rows">Rows.</param>
		/// <returns>A collection of header cells.</returns>
		private IEnumerable<Cell> GetHeader(IEnumerable<Row> rows) {
			Row header = rows.FirstOrDefault();
			if (header == null) {
				throw new EmptyHeaderException(UserConnection.Workspace.ResourceStorage);
			}
			IEnumerable<Cell> headerCells = header.Elements<Cell>();
			if (!headerCells.Any()) {
				throw new EmptyHeaderException(UserConnection.Workspace.ResourceStorage);
			}
			return headerCells;
		}

		/// <summary>
		/// Processes data header.
		/// </summary>
		/// <returns>A collection of import columns.</returns>
		private IEnumerable<ImportColumn> ProcessHeader() {
			List<ImportColumn> columns = new List<ImportColumn>();
			foreach (ImportColumnValue columnValue in Parameters.HeaderColumnsValues) {
				ImportColumn column = CreateImportEntityColumn(columnValue);
				columns.Add(column);
			}
			return columns;
		}

		/// <summary>
		/// Gets table cells.
		/// </summary>
		/// <param name="rows">Rows.</param>
		/// <returns>A collection of import entities.</returns>
		private IEnumerable<Row> GetTable(IEnumerable<Row> rows) {
			IEnumerable<Row> table = rows.Skip(1);
			var firstRow = table.FirstOrDefault();
			if (firstRow == null) {
				throw new EmptyDataException(UserConnection.Workspace.ResourceStorage);
			}
			return table;
		}

		/// <summary>
		/// Processes data table.
		/// </summary>
		/// <param name="table">Table cells.</param>
		/// <returns>A collection of import entities.</returns>
		private List<ImportEntity> ProcessTable(IEnumerable<Row> table) {
			List<ImportEntity> entities = new List<ImportEntity>();
			foreach (Row row in table) {
				IEnumerable<ImportColumnValue> columnsValues = ProcessRow(row);
				bool isColumnsValuesEmpty = IsColumnsValuesEmpty(columnsValues);
				if (isColumnsValuesEmpty) {
					continue;
				}
				ImportEntity entity = new ImportEntity {
					RowIndex = row.RowIndex.Value
				};
				entity.ColumnValues = columnsValues;
				entities.Add(entity);
			}
			if (entities.Count == 0) {
				throw new EmptyDataException(UserConnection.Workspace.ResourceStorage);
			}
			return entities;
		}

		/// <summary>
		/// Processes data row.
		/// </summary>
		/// <param name="row">Row.</param>
		/// <returns>A collection of row columns.</returns>
		private IEnumerable<ImportColumnValue> ProcessRow(Row row) {
			IEnumerable<Cell> cells = row.Elements<Cell>();
			return ProcessCells(cells);
		}

		/// <summary>
		/// Processes data cells.
		/// </summary>
		/// <param name="cells">Cells.</param>
		/// <returns>A collection of cells values.</returns>
		private IEnumerable<ImportColumnValue> ProcessCells(IEnumerable<Cell> cells) {
			List<ImportColumnValue> columnValues = new List<ImportColumnValue>();
			foreach (Cell cell in cells) {
				var columnValue = ProcessCell(cell);
				if (columnValue.Value.IsNotNullOrEmpty()) {
					columnValue.Value = columnValue.Value.Replace(replaceableSymbol, String.Empty);
					columnValues.Add(columnValue);
				}
			}
			return columnValues;
		}

		/// <summary>
		/// Processes data cell.
		/// </summary>
		/// <param name="cell">Cell.</param>
		/// <returns>Cell information.</returns>
		private ImportColumnValue ProcessCell(Cell cell) {
			string cellValue = GetCellValue(cell);
			string cellColumnIndex = GetCellIndex(_cellColumnIndexRegex, cell);
			string rowIndex = GetCellIndex(_cellRowIndexRegex, cell);
			return new ImportColumnValue(cellValue, cellColumnIndex, rowIndex);
		}

		/// <summary>
		/// Gets cell vallue.
		/// </summary>
		/// <param name="cell">Cell.</param>
		/// <returns>Cell value.</returns>
		private string GetCellValue(Cell cell) {
			if (cell.DataType != null && cell.DataType.Value == CellValues.SharedString) {
				return GetSharedCellValue(cell);
			}
			return (cell.CellValue != null) ? ProcessCellValue(cell.CellValue.Text) : null;
		}

		/// <summary>
		/// Processes cell value.
		/// </summary>
		/// <param name="value">Text value.</param>
		/// <returns>Processed value.</returns>
		private string ProcessCellValue(string value) {
			bool success = double.TryParse(value, System.Globalization.NumberStyles.AllowDecimalPoint
				| System.Globalization.NumberStyles.AllowExponent,
				System.Globalization.CultureInfo.InvariantCulture, out double doubleValue);
			return (success) ? doubleValue.ToString() : value;
		}

		/// <summary>
		/// Gets cell column index.
		/// </summary>
		/// <param name="regexExpression"></param>
		/// <param name="cell">Cell.</param>
		/// <returns>Cell column index.</returns>
		private string GetCellIndex(Regex regexExpression, Cell cell) {
			Match match = regexExpression.Match(cell.CellReference.Value);
			return match.Value;
		}

		/// <summary>
		/// Gets shared cell value.
		/// </summary>
		/// <param name="cell">Cell.</param>
		/// <returns>Shared cell value.</returns>
		private string GetSharedCellValue(Cell cell) {
			int itemIndex = int.Parse(cell.CellValue.Text);
			return SharedStringItemsValues[itemIndex];
		}

		/// <summary>
		/// Performs case-insensitive column search by its caption.
		/// </summary>
		/// <param name="columnCaption">Caption.</param>
		/// <returns>Entity schema column.</returns>
		private EntitySchemaColumn FindColumn(string columnCaption) {
			foreach (EntitySchemaColumn column in RootSchema.Columns) {
				if (string.Equals(column.Caption, columnCaption, StringComparison.OrdinalIgnoreCase)) {
					return column;
				}
			}
			return null;
		}

		/// <summary>
		/// Creates import entity column.
		/// </summary>
		/// <param name="columnValue">Import column value.</param>
		/// <returns>Import entity column.</returns>
		private ImportColumn CreateImportEntityColumn(ImportColumnValue columnValue) {
			EntitySchemaColumn entitySchemaColumn = FindColumn(columnValue.Value);
			return ColumnsProcessor.CreateColumn(RootSchema, entitySchemaColumn, columnValue);
		}

		/// <summary>
		/// Determines if columns values collection is empty.
		/// </summary>
		/// <param name="columnsValues">A collection of column values.</param>
		/// <returns>
		/// <c>true</c> if collection <paramref name="columnsValues"/> is empty.
		/// </returns>
		private bool IsColumnsValuesEmpty(IEnumerable<ImportColumnValue> columnsValues) {
			return columnsValues
				.All(columnValue => columnValue.Value.IsNullOrEmpty());
		}

		#endregion

		#region Methods: Public

		/// <summary>
		/// Processes given file.
		/// </summary>
		/// <param name="file">File.</param>
		public void ProcessFile(HttpPostedFile file) {
			file.CheckArgumentNull(nameof(file));

			Stream stream = file.InputStream;
			bool isEditable = false;
			using (SpreadsheetDocument spreadsheetDocument = SpreadsheetDocument.Open(stream, isEditable)) {
				ProcessSpreadsheetDocument(spreadsheetDocument);
			}
			Parameters.FileName = file.FileName;
		}

		/// <summary>
		/// Processes given object, considering it contains data of entity schema
		/// with unique identifier <paramref name="rootSchemaUId"/>.
		/// </summary>
		/// <param name="rootSchemaUId">Root schema unique identifier.</param>
		/// <returns>File import parameters.</returns>
		public void ProcessObject(Guid rootSchemaUId) {
			rootSchemaUId.CheckArgumentEmpty(nameof(rootSchemaUId));

			_rootSchemaUId = rootSchemaUId;
			Parameters.RootSchemaUId = rootSchemaUId;
			Parameters.Columns = ProcessHeader();
		}

		#endregion

	}

	#endregion

}

