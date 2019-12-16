namespace Terrasoft.Configuration.FileImport
{
	using Common;
	using Core;
	using Core.DB;
	using Core.Factories;
	using System;
	using System.Collections.Generic;
	using System.Data;
	using System.Linq;
	using System.Text;
	using Newtonsoft.Json;

	#region  Class: ImportParametersRepository

	/// <inheritdoc />
	[DefaultBinding(typeof(IImportParametersRepository))]
	public class ImportParametersRepository : IImportParametersRepository
	{
		#region Constants: Private

		private readonly UserConnection _userConnection;
		private readonly string _importParametersSchemaName = "FileImportParameters";

		#endregion

		#region Constructors: Public

		public ImportParametersRepository(UserConnection userConnection) => _userConnection = userConnection;

		#endregion

		#region Methods: Private

		private T ConvertToObject<T>(byte[] value) where T : class =>
			JsonConvert.DeserializeObject<T>(Encoding.UTF8.GetString(value));

		private ImportParameters GetImportParameters(IDataReader record) {
			var parameters = ConvertToObject<ImportParameters>(record.GetColumnValue<byte[]>("ImportParameters"));
			parameters.ImportSessionId = record.GetColumnValue<Guid>("Id");
			parameters.ImportStage = record.GetColumnValue<FileImportStagesEnum>("Stage");
			parameters.Entities = ConvertToObject<List<ImportEntity>>(record.GetColumnValue<byte[]>("ImportEntities"));
			return parameters;
		}

		private (Guid processId, ImportParameters ImportParameters) GetImportParametersWithProcessId(IDataReader record) {
			var parameters = ConvertToObject<ImportParameters>(record.GetColumnValue<byte[]>("ImportParameters"));
			parameters.ImportSessionId = record.GetColumnValue<Guid>("Id");
			parameters.ImportStage = record.GetColumnValue<FileImportStagesEnum>("Stage");
			parameters.Entities = ConvertToObject<List<ImportEntity>>(record.GetColumnValue<byte[]>("ImportEntities"));
			return (record.GetColumnValue<Guid>("ProcessId"), parameters);
		}

		private QueryColumnExpression SerializeAndConvertToQueryColumnExpression<T>(T value) where T : class =>
			Column.Parameter(Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(value)));

		private Update CreateUpdateQuery(Guid id) {
			var currentContactId = _userConnection.CurrentUser.ContactId;
			var currentDateTime = _userConnection.CurrentUser.GetCurrentDateTime();
			return new Update(_userConnection, _importParametersSchemaName)
				.Set("ModifiedOn", Column.Parameter(currentDateTime))
				.Set("ModifiedById", Column.Parameter(currentContactId))
				.Where("Id").IsEqual(Column.Parameter(id)) as Update;

		}

		private Select GetSelectQuery() => new Select(_userConnection)
			.Column("Id")
			.Column("ImportParameters")
			.Column("ImportEntities")
			.Column("Stage")
			.From(_importParametersSchemaName);

		private void DeleteCanceledSessionId(Guid importSessionId) {
			var delete = new Delete(_userConnection)
				.From("ImportSession")
				.Where("Id").IsEqual(Column.Parameter(importSessionId));
			delete.Execute();
		}

		private Insert GetInsertImportSession(Guid importSessionId) => new Insert(_userConnection)
			.Into("ImportSession").Values().Set("Id", Column.Parameter(importSessionId));

		private Update GetUpdateImportSession(Guid importSessionId) => new Update(_userConnection, "ImportSession")
			.Where("Id").IsEqual(Column.Parameter(importSessionId)) as Update;

		#endregion

		#region Methods: Public

		/// <inheritdoc />
		public void Add(ImportParameters importParameters) {
			var currentContactId = _userConnection.CurrentUser.ContactId;
			var currentDateTime = _userConnection.CurrentUser.GetCurrentDateTime();
			var insert = new Insert(_userConnection)
				.Into(_importParametersSchemaName)
				.Set("Id", Column.Parameter(importParameters.ImportSessionId))
				.Set("CreatedOn", Column.Parameter(currentDateTime))
				.Set("ModifiedOn", Column.Parameter(currentDateTime))
				.Set("CreatedById", Column.Parameter(currentContactId))
				.Set("ModifiedById", Column.Parameter(currentContactId))
				.Set("Stage", Column.Parameter(importParameters.ImportStage))
				.Set("ImportParameters", SerializeAndConvertToQueryColumnExpression(importParameters))
				.Set("ImportEntities", SerializeAndConvertToQueryColumnExpression(importParameters.Entities));
			insert.Execute();
		}

		/// <inheritdoc />
		public void Delete(Guid ImportSessionId) {
			var delete = new Delete(_userConnection)
				.From(_importParametersSchemaName)
				.Where("Id").IsEqual(Column.Parameter(ImportSessionId));
			delete.Execute();
			DeleteCanceledSessionId(ImportSessionId);
		}

		/// <inheritdoc />
		public ImportParameters Get(Guid ImportSessionId) {
			var selectQuery = GetSelectQuery();
			selectQuery.Where("Id")
				.IsEqual(new QueryParameter("importSessionId", ImportSessionId));
			var importParametersExists = selectQuery.ExecuteSingleRecord(GetImportParameters, out var importParameters);
			if(importParametersExists) {
				return importParameters;
			}
			throw new ItemNotFoundException($"{_importParametersSchemaName} with ImportSessionId {ImportSessionId}");
		}

		/// <inheritdoc />
		public void Update(ImportParameters importParameters) {
			var update = CreateUpdateQuery(importParameters.ImportSessionId)
				.Set("Stage", Column.Parameter(importParameters.ImportStage))
				.Set("ImportParameters", SerializeAndConvertToQueryColumnExpression(importParameters))
				.Set("ImportEntities", SerializeAndConvertToQueryColumnExpression(importParameters.Entities)) as Update;
			update.Execute();
		}

		/// <inheritdoc />
		public void UpdateImportStage(Guid id, FileImportStagesEnum newImportStage) {
			var update = CreateUpdateQuery(id);
			update = update.Set("Stage", Column.Parameter(newImportStage)) as Update;
			update.Execute();
		}

		/// <inheritdoc />
		public void Update(Guid id, IDictionary<string, object> changedValues) {
			throw new NotImplementedException();
		}

		public void BulkUpdate(IEnumerable<Guid> keyCollection, IDictionary<string, object> changedValues) {
			throw new NotImplementedException();
		}

		/// <inheritdoc />
		public IEnumerable<ImportParameters> GetAll() {
			var select = GetSelectQuery();
			return select.ExecuteEnumerable(GetImportParameters).ToList();
		}

		/// <inheritdoc />
		public Dictionary<Guid, ImportParameters> GetWithProcessIncomplete() {
			var select = new Select(_userConnection)
				.Column(_importParametersSchemaName, "Id")
				.Column(_importParametersSchemaName, "ImportParameters")
				.Column(_importParametersSchemaName, "ImportEntities")
				.Column(_importParametersSchemaName, "Stage")
				.Column("ImportSession", "ProcessId")
				.From(_importParametersSchemaName).As(_importParametersSchemaName)
				.InnerJoin("ImportSession").As("ImportSession")
				.On("ImportSession", "Id").IsEqual(_importParametersSchemaName, "Id")
				.Where("ImportSession", "ProcessId").Not().IsNull() as Select;
			return select.ExecuteEnumerable(GetImportParametersWithProcessId).
				ToDictionary(t => t.processId, t => t.ImportParameters);
		}

		/// <inheritdoc />
		public bool GetIsImportSessionCanceled(Guid importSessionId) {
			var select = new Select(_userConnection).
				Top(1).
				Column("session", "IsCanceled").
				From("ImportSession").As("session").
				InnerJoin("FileImportParameters").As("param").
				On("param", "Id").
				IsEqual("session", "Id").
				Where("session", "Id").
				IsEqual(Column.Parameter(importSessionId)) as Select;
			return select.ExecuteScalar<bool>();
		}

		/// <inheritdoc />
		public void CancelImportSession(Guid importSessionId) {
			var update = GetUpdateImportSession(importSessionId);
			update.Set("IsCanceled", Column.Parameter(true));
			if(update.Execute() == 0) {
				var insert = GetInsertImportSession(importSessionId);
				insert.Set("IsCanceled", Column.Parameter(true));
				insert.Execute();
			}
		}

		/// <inheritdoc />
		public void UpdateImportProcessId(Guid importSessionId, Guid processId) {
			var update = GetUpdateImportSession(importSessionId);
			update.Set("ProcessId", Column.Parameter(processId));
			if(update.Execute() == 0) {
				var insert = GetInsertImportSession(importSessionId);
				insert.Set("ProcessId", Column.Parameter(processId));
				insert.Execute();
			}
		}

		#endregion
	}

	#endregion
}

