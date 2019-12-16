namespace Terrasoft.Configuration.FileImport
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Factories;

	#region Class: PersistentLookupColumnProcessor

	/// <inheritdoc />
	[DefaultBinding(typeof(IPersistentColumnProcessor), Name = nameof(PersistentLookupColumnProcessor))]
	public class PersistentLookupColumnProcessor : BaseColumnProcessor, IPersistentColumnProcessor
	{
		#region Properties: Protected

		/// <summary>
		/// Data value type unique identifier.
		/// </summary>
		protected override Guid DataValueTypeUId => DataValueType.LookupDataValueTypeUId;

		#endregion

		#region Fields: Private

		private readonly ImportLookupChunksDataProvider _importDataProvider;
		private readonly ImportParametersRepository _importParametersRepository;
		private LookupProcessedValues _lookupProcessedValues;

		#endregion

		#region Constructors: Public

		public PersistentLookupColumnProcessor(UserConnection userConnection) : base(userConnection) {
			_importDataProvider = ClassFactory.Get<ImportLookupChunksDataProvider>(
				new ConstructorArgument("userConnection", UserConnection)
			);
			_importParametersRepository = ClassFactory.Get<ImportParametersRepository>(new ConstructorArgument("userConnection", UserConnection));
		}

		#endregion

		#region Methods: Private

		private ImportDataChunk<LookupChunkData> GetImportDataChunk(Guid importSessionId, LookupValuesToProcessMemento values) {
			return new ImportDataChunk<LookupChunkData>() {
				ImportSessionId = importSessionId,
				ChunkId = Guid.NewGuid(),
				State = ImportChunkState.ToProcess,
				Type = ImportChunkType.Lookup,
				Data = new LookupChunkData() {
					ValuesToProcessState = values
				}
			};
		}

		private IEnumerable<ImportDataChunk<LookupChunkData>> GetLookupChunkData(ImportParameters importParameters) {
			var importColumns = importParameters.Columns.Where(c => c.Destinations.Any(d => d.FindColumnTypeUId() == DataValueTypeUId));
			var entitiesChunks = importParameters.Entities.SplitOnChunks(importParameters.ChunkSize);
			var result = new List<ImportDataChunk<LookupChunkData>>();

			if(!importColumns.Any()) {
				return result;
			}

			foreach(var entities in entitiesChunks) {
				var processor = new LookupValuesToProcess(UserConnection);
				foreach(var entity in entities) {
					foreach(var column in importColumns) {
						var columnValue = entity.FindColumnValue(column);
						if(columnValue == null) {
							continue;
						}
						foreach(var destination in column.Destinations) {
							processor.Add(entity, column, columnValue, destination);
						}
					}
				}
				result.Add(GetImportDataChunk(importParameters.ImportSessionId,
					processor.SaveState()));
			}

			return result;
		}

		private void SaveLookupChunksData(IEnumerable<ImportDataChunk<LookupChunkData>> lookupChunksData) {
			_importDataProvider.Add(lookupChunksData);
		}

		private LookupProcessedValuesMemento JoinLookupProcessedValues(List<LookupProcessedValuesMemento> list) {
			var result = new LookupProcessedValuesMemento {
				Results = new Dictionary<string, Dictionary<string, Guid>>()
			};
			foreach(var item in list) {
				AddMemento(result.Results, item.Results);
			}
			return result;
		}

		private void AddMemento(Dictionary<string, Dictionary<string, Guid>> results, Dictionary<string, Dictionary<string, Guid>> collection) {
			foreach(var item in collection) {
				if(!results.TryGetValue(item.Key, out Dictionary<string, Guid> value)) {
					results.Add(item.Key, item.Value);
				} else {
					item.Value.ForEach(i => value[i.Key] = i.Value);
				}
			}
		}

		#endregion

		#region Methods: Protected

		/// <summary>
		/// Gets column destination default properties.
		/// </summary>
		/// <param name="entitySchemaColumn">Entity schema column.</param>
		/// <param name="columnValue">Column value information.</param>
		/// <returns>Column destination default properties.</returns>
		protected override Dictionary<string, object> GetColumnDestinationProperties(
			EntitySchemaColumn entitySchemaColumn, ImportColumnValue columnValue) {
			Dictionary<string, object> destinationProperties = base.GetColumnDestinationProperties(entitySchemaColumn,
				columnValue);
			destinationProperties.Add(ReferenceSchemaUIdPropertyName, entitySchemaColumn.ReferenceSchemaUId);
			return destinationProperties;
		}

		#endregion

		#region Methods: Public

		/// <inheritdoc />
		public object FindValueForSave(ImportColumnDestination destination, ImportColumnValue columnValue) {
			return _lookupProcessedValues.FindValueForSave(destination, columnValue);
		}

		/// <inheritdoc />
		public void Process(ImportParameters importParameters) {
			var lookupChunksData = _importDataProvider.Get(importParameters.ImportSessionId);
			if(!lookupChunksData.Any()) {
				lookupChunksData = GetLookupChunkData(importParameters);
				SaveLookupChunksData(lookupChunksData);
			}

			var handler = new ChunkLookupValuesHandler(UserConnection);
			handler.ProcessError += SendProcessError;
			try {
				foreach(var item in lookupChunksData.Where(l => l.State == ImportChunkState.ToProcess)) {
					if(_importParametersRepository.GetIsImportSessionCanceled(importParameters.ImportSessionId)) {
						break;
					}
					handler.Execute(item);
				}
			} finally {
				handler.ProcessError -= SendProcessError;
			}
			_lookupProcessedValues = new LookupProcessedValues(UserConnection);
			_lookupProcessedValues.RestoreState(JoinLookupProcessedValues(lookupChunksData.Select(c => c.Data.ProcessedValuesState).ToList()));
		}

		#endregion

	}

	#endregion
}


