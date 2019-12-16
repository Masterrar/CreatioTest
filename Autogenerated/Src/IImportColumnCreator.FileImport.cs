namespace Terrasoft.Configuration.FileImport
{
	public interface IImportColumnCreator
	{
		/// <summary>
		/// Create import column.
		/// </summary>
		/// <param name="createColumnParameters"> <see cref="CreateColumnParameters"/></param>
		/// <returns><see cref="ImportColumn"/></returns>
		ImportColumn CreateImportColumn(CreateColumnParameters createColumnParameters);

		/// <summary>
		/// Create import column.
		/// </summary>
		/// <param name="columnValue"><see cref="ImportColumnValue"/></param>
		/// <returns><see cref="ImportColumn"/></returns>
		ImportColumn CreateColumn(ImportColumnValue columnValue);
	}
}

