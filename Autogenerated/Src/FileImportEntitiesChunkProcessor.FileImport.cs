namespace Terrasoft.Configuration.FileImport
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Factories;

	#region  Class: FileImportEntitiesChunkProcessor

	///<inheritdoc cref="IFileImportEntitiesChunkProcessor"/>
	/// <summary>
	/// Execute import entities by passed parameters.
	/// </summary>
	[DefaultBinding(typeof(IFileImportEntitiesChunkProcessor), Name = nameof(FileImportEntitiesChunkProcessor))]
	public class FileImportEntitiesChunkProcessor : IFileImportEntitiesChunkProcessor
	{

		#region Fields: Private

		private readonly UserConnection UserConnection;
		private readonly IColumnsAggregatorAdapter ColumnsProcessor;
		private IChildImportEntitiesGetter _childImportEntitiesGetter;
		private IChildImportEntitiesSetter _childImportEntitiesSetter;
		private IPrimaryImportEntitiesGetter _primaryImportEntitiesGetter;
		private IPrimaryImportEntitiesSetter _primaryImportEntitiesSetter;

		#endregion

		#region Constructors: Public

		/// <summary>
		/// Create instance of <see cref="FileImportEntitiesChunkProcessor"/>
		/// </summary>
		/// <param name="userConnection"></param>
		/// <param name="columnsProcessor"></param>
		public FileImportEntitiesChunkProcessor(UserConnection userConnection, IColumnsAggregatorAdapter columnsProcessor) {
			UserConnection = userConnection;
			ColumnsProcessor = columnsProcessor;
		}

		#endregion

		#region Properties: Private

		private IPrimaryImportEntitiesGetter PrimaryImportEntitiesGetter => _primaryImportEntitiesGetter ??
				(_primaryImportEntitiesGetter =
						ClassFactory.Get<IPrimaryImportEntitiesGetter>(GetConstructorArguments()));

		private IChildImportEntitiesGetter ChildImportEntitiesGetter => _childImportEntitiesGetter ??
				(_childImportEntitiesGetter = ClassFactory.Get<IChildImportEntitiesGetter>(GetConstructorArguments()));

		private IPrimaryImportEntitiesSetter PrimaryImportEntitiesSetter => _primaryImportEntitiesSetter ??
				(_primaryImportEntitiesSetter =
						ClassFactory.Get<IPrimaryImportEntitiesSetter>(GetConstructorArguments()));

		private IChildImportEntitiesSetter ChildImportEntitiesSetter => _childImportEntitiesSetter ??
				(_childImportEntitiesSetter = ClassFactory.Get<IChildImportEntitiesSetter>(GetConstructorArguments()));

		#endregion

		#region Events: Public

		public event EventHandler<ImportEntitySavedEventArgs> ImportEntitySaved;

		public event EventHandler<ImportEntitySaveErrorEventArgs> ImportEntitySaveError;

		#endregion

		#region Methods: Private

		private ConstructorArgument[] GetConstructorArguments() => new[] {
			GetUserConnectionArgument(),
			new ConstructorArgument("columnsProcessor", ColumnsProcessor)
		};

		private IEnumerable<ImportColumn> GetKeyColumns(ImportParameters parameters) => parameters.GetKeyColumns();

		private ConstructorArgument GetUserConnectionArgument() =>
			new ConstructorArgument("userConnection", UserConnection);

		private void InitEntityForSave(ImportParameters parameters, ImportEntity importEntity) {
			importEntity.InitPrimaryEntity(UserConnection, parameters);
			foreach (ImportColumn column in parameters.Columns) {
				ImportColumnValue columnValue = importEntity.FindColumnValue(column);
				if (columnValue == null) {
					continue;
				}
				SetEntityColumnValue(importEntity, column, columnValue);
			}
		}

		private void SetEntityColumnValue(ImportEntity importEntity, ImportColumn column, ImportColumnValue columnValue) {
			foreach (ImportColumnDestination destination in column.Destinations) {
				Entity entity = importEntity.GetEntityForSave(UserConnection, destination);
				string columnValueName = destination.ColumnValueName;
				object valueForSave = ColumnsProcessor.FindValueForSave(destination, columnValue);
				if (valueForSave == null) {
					continue;
				}
				if (entity.StoringState != StoringObjectState.New) {
					object entityValue = entity.GetColumnValue(columnValueName);
					if (valueForSave.Equals(entityValue) || destination.IsKey) {
						continue;
					}
				}
				if (entity.Schema.Columns.GetByName(destination.ColumnName).DataValueType is TextDataValueType) {
					valueForSave = valueForSave.ToString().Trim();
				}
				entity.SetColumnValue(columnValueName, valueForSave);
			}
		}

		private void InitImportEntities(ImportParameters parameters) {
			var keyColumns = GetKeyColumns(parameters);
			var importColumns = keyColumns.ToList();
			var primaryEntities = PrimaryImportEntitiesGetter.Get(parameters, importColumns);
			PrimaryImportEntitiesSetter.Set(parameters, primaryEntities, importColumns);
			var childEntities = ChildImportEntitiesGetter.Get(parameters);
			ChildImportEntitiesSetter.Set(parameters, childEntities);
		}

		private void OnImportEntitySaved(Entity primaryEntity, ImportParameters parameters, uint rowIndex) {
			var args = new ImportEntitySavedEventArgs {
				PrimaryEntity = primaryEntity,
				RootSchemaUId = parameters.RootSchemaUId,
				ImportSessionId = parameters.ImportSessionId,
				ChunkId = parameters.ChunkId,
				RowIndex = rowIndex
			};
			ImportEntitySaved?.Invoke(this, args);
		}

		private void OnImportEntitySaveError(Exception e, ImportEntity importEntity, Guid importSessionId) {
			var eventArgs = new ImportEntitySaveErrorEventArgs {
				Exception = e,
				ImportEntity = importEntity,
				ImportSessionId = importSessionId
			};
			ImportEntitySaveError?.Invoke(this, eventArgs);
		}

		private void SaveImportEntities(ImportParameters parameters) {
			Guid sessionId = parameters.ImportSessionId;
			var entities = parameters.Entities;
			ImportEntity importEntity;
			while ((importEntity = entities.FirstOrDefault()) != null) {
				try {
					InitEntityForSave(parameters, importEntity);
					importEntity.Save();
					OnImportEntitySaved(importEntity.PrimaryEntity, parameters, importEntity.RowIndex);
				} catch (OutOfMemoryException) {
					throw;
				} catch (Exception e) {
					OnImportEntitySaveError(e, importEntity, sessionId);
				} finally {
					entities.Remove(importEntity);
				}
			}
		}

		private bool GetIsImportSessionCanceled(Guid importSessionId) {
			var importParametersRepository = ClassFactory.Get<IImportParametersRepository>(new ConstructorArgument("userConnection", UserConnection));
			return importParametersRepository.GetIsImportSessionCanceled(importSessionId);
		}

		#endregion

		#region Methods: Public

		///<inheritdoc cref="IFileImportEntitiesChunkProcessor"/>
		public void ProcessChunk(ImportParameters importParameters) {
			if(GetIsImportSessionCanceled(importParameters.ImportSessionId)) {
				return;
			}
			InitImportEntities(importParameters);
			SaveImportEntities(importParameters);
		}

		#endregion
	}

	#endregion
}
