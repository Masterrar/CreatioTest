namespace Terrasoft.Configuration.FileImport
{
	using System;
	using System.Collections.Generic;
	using Terrasoft.Core;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Factories;

	#region Class: ImportEntitiesChunksDataProvider

	/// <inheritdoc />
	[DefaultBinding(typeof(IImportEntitiesChunksDataProvider))]
	public class ImportEntitiesChunksDataProvider : ImportChunkDataProvider<EntityChunkData>, IImportEntitiesChunksDataProvider
	{

		#region Fields: Private

		private readonly string _chunkProcessResultTableName = "ChunkProcessResult";

		#endregion

		#region Constructors: Public

		public ImportEntitiesChunksDataProvider(UserConnection userConnection) : base(userConnection) {
		}

		#endregion

		#region Methods: Protected

		/// <inheritdoc />
		protected override ImportChunkType GetImportChunkType() {
			return ImportChunkType.Entity;
		}

		#endregion

		#region Methods: Public

		/// <inheritdoc />
		public void SaveProcessedRow(Guid chunkId, int rowIndex, bool success = true) {
			new Insert(UserConnection)
				.Set("ImportSessionChunkId", Column.Parameter(chunkId))
				.Set("RowIndex", Column.Parameter(rowIndex))
				.Set("Success", Column.Parameter(success))
				.Set("CreatedOn", Column.Parameter(DateTime.UtcNow))
				.Set("ModifiedOn", Column.Parameter(DateTime.UtcNow))
				.Set("ModifiedById", Column.Parameter(UserConnection.CurrentUser.ContactId))
				.Set("CreatedById", Column.Parameter(UserConnection.CurrentUser.ContactId))
				.Into(_chunkProcessResultTableName)
				.Execute();
		}

		/// <inheritdoc />
		public IEnumerable<ProcessedRowResult> GetProcessedRows(Guid chunkId) {
			var select = new Select(UserConnection)
					.Column("RowIndex")
					.Column("Success")
				.From(_chunkProcessResultTableName)
				.Where("ImportSessionChunkId").IsEqual(Column.Parameter(chunkId)) as Select;
			return select.ExecuteEnumerable(reader => {
				return new ProcessedRowResult {
					RowIndex = (int)reader["RowIndex"],
					Success = (bool)reader["Success"]
				};
			});
		}

		/// <inheritdoc />
		public void RemoveProcessedRows(Guid chunkId) {
			new Delete(UserConnection)
				.From(_chunkProcessResultTableName)
				.Where("ImportSessionChunkId").IsEqual(Column.Parameter(chunkId))
				.Execute();
		}

		#endregion

	}

	#endregion

	#region Class: ProcessedRowResult

	public class ProcessedRowResult
	{
		#region Properties: Public

		public int RowIndex { get; set; }
		public bool Success { get; set; }

		#endregion
	}

	#endregion

}
