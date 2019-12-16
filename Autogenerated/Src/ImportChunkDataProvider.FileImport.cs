namespace Terrasoft.Configuration.FileImport
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using Newtonsoft.Json;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.DB;

	#region Class: ImportDataProvider

	/// <inheritdoc />
	public abstract class ImportChunkDataProvider<T> : IImportChunkDataProvider<ImportDataChunk<T>>
	{
		#region Fields: Private

		private readonly string _importSessionChunk = "ImportSessionChunk";

		#endregion

		#region Fields: Protected

		/// <summary>
		/// Rows count part for inserting.
		/// </summary>
		protected int ImportDataPartSize = 349;

		protected readonly UserConnection UserConnection;

		#endregion

		#region Constructors: Public

		public ImportChunkDataProvider(UserConnection userConnection) {
			UserConnection = userConnection;
		}

		#endregion

		#region Methods: Private

		private IEnumerable<IEnumerable<ImportDataChunk<T>>> GetImportDataParts(IEnumerable<ImportDataChunk<T>> importData) {
			return importData.SplitOnChunks(ImportDataPartSize);
		}

		private byte[] GetSerialize(T chunkData) {
			return Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(chunkData));
		}

		private T GetDeserialize(byte[] chunkData) {
			return JsonConvert.DeserializeObject<T>(Encoding.UTF8.GetString(chunkData));
		}

		#endregion

		#region Methods: Protected

		/// <summary>
		/// Type import chunk.
		/// </summary>
		/// <returns>Type import chunk.</returns>
		protected abstract ImportChunkType GetImportChunkType();

		#endregion

		#region Methods: Public

		/// <inheritdoc />
		public IEnumerable<ImportDataChunk<T>> Get(Guid importSessionId) {
			var importChunkType = GetImportChunkType();
			var select = new Select(UserConnection).
				Column("ImportParametersId").
				Column("Id").
				Column("Type").
				Column("State").
				Column("Data").
				From(_importSessionChunk).
				Where("ImportParametersId").IsEqual(Column.Parameter(importSessionId)).
				And("Type").IsEqual(Column.Parameter((int)importChunkType)) as Select;
			using(DBExecutor executor = UserConnection.EnsureDBConnection()) {
				using(var reader = select.ExecuteReader(executor)) {
					while(reader.Read()) {
						yield return new ImportDataChunk<T>() {
							ImportSessionId = (Guid)reader["ImportParametersId"],
							ChunkId = (Guid)reader["Id"],
							Type = (ImportChunkType)reader["Type"],
							State = (ImportChunkState)reader["State"],
							Data = GetDeserialize((byte[])reader["Data"])
						};
					}
				}
			}
		}

		/// <inheritdoc />
		public int Add(IEnumerable<ImportDataChunk<T>> importDataChunk) {
			var insertRowsCount = 0;
			var importDataPart = GetImportDataParts(importDataChunk);
			importDataPart.AsParallel().ForEach(
				importDataPartsPart => {
					var insert = new Insert(UserConnection).Into(_importSessionChunk);
					foreach(var importData in importDataPartsPart) {
						insert.Values();
						insert.Set("Id", Column.Parameter(importData.ChunkId));
						insert.Set("Type", Column.Parameter((int)importData.Type));
						insert.Set("State", Column.Parameter((int)importData.State));
						insert.Set("Data", Column.Parameter(GetSerialize(importData.Data)));
						insert.Set("ImportParametersId", Column.Parameter(importData.ImportSessionId));
					}
					insertRowsCount += insert.Execute();
				}
			);
			return insertRowsCount;
		}

		/// <inheritdoc />
		public bool Update(ImportDataChunk<T> importData) {
			var update = new Update(UserConnection, "ImportSessionChunk").
				Set("State", Column.Parameter((int)importData.State)).
				Set("Data", Column.Parameter(GetSerialize(importData.Data))).
				Where("ImportParametersId").IsEqual(Column.Parameter(importData.ImportSessionId)).
				And("Id").IsEqual(Column.Parameter(importData.ChunkId)).
				And("Type").IsEqual(Column.Parameter((int)importData.Type)) as Update;
			return update.Execute() > 0;
		}



		#endregion
	}

	#endregion

}
