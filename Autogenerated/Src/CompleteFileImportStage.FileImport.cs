namespace Terrasoft.Configuration.FileImport
{
	using System;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Factories;

	#region  Class: CompleteFileImportStage

	/// <inheritdoc cref="BaseFileImportStage"/>
	/// <summary>
	/// Execute complete file import
	/// </summary>
	[DefaultBinding(typeof(IBaseFileImportStage), Name = nameof(CompleteFileImportStage))]
	public class CompleteFileImportStage : BaseFileImportStage
	{
		#region Fields: Private

		private IImportParametersRepository _importParametersRepository;
		private readonly string CompleteRemindingDescriptionTemplate = "{0} of {1} records imported from the source file \"{2}\".";
		private readonly string NotImportedRowsCountMessageTemplate = "{0} record(s) not imported.";
		private readonly object CompleteRemindingSubject = "Import complete.";

		#endregion

		#region Properties: Private 

		private IImportParametersRepository ImportParametersRepository => _importParametersRepository ??
				(_importParametersRepository = ClassFactory.Get<IImportParametersRepository>(new ConstructorArgument("userConnection", UserConnection)));

		#endregion

		#region Constructors: Public

		public CompleteFileImportStage(UserConnection userConnection,
				IColumnsAggregatorAdapter columnsProcessor)
				: base(userConnection, columnsProcessor) { }

		#endregion

		#region Properties: Public

		/// <inheritdoc cref="BaseFileImportStage"/>
		public override FileImportStagesEnum StageId => FileImportStagesEnum.CompleteFileImportStage;

		#endregion

		#region Methods: Private

		private void CreateReminding(ImportParameters parameters) {
			Guid contactId = parameters.AuthorId;
			DateTime dateTime = TimeZoneInfo.ConvertTimeFromUtc(new DateTimeProvider().UtcNow, parameters.AuthorTimeZone);
			uint notImportedRowsCount = parameters.NotImportedRowsCount;
			string description = string.Format(CompleteRemindingDescriptionTemplate, parameters.ImportedRowsCount,
				parameters.TotalRowsCount, parameters.FileName);
			if (notImportedRowsCount > 0) {
				description += string.Format(NotImportedRowsCountMessageTemplate, notImportedRowsCount);
			}
			string caption = string.Format("{0} {1}", CompleteRemindingSubject, description);
			ISchemaManagerItem<EntitySchema> importSessionItem =
				UserConnection.EntitySchemaManager.GetItemByName("ImportSession");
			ISchemaManagerItem<EntitySchema> sysProcessLogItem =
				UserConnection.EntitySchemaManager.GetItemByName("VwSysProcessLog");
			
			EntitySchema remindingSchema = UserConnection.EntitySchemaManager.GetInstanceByName("Reminding");
			Entity reminding = remindingSchema.CreateEntity(UserConnection);
			reminding.SetDefColumnValues();
			reminding.SetColumnValue("AuthorId", contactId);
			reminding.SetColumnValue("ContactId", contactId);
			reminding.SetColumnValue("SourceId", RemindingConsts.RemindingSourceAuthorId);
			reminding.SetColumnValue("RemindTime", dateTime);
			reminding.SetColumnValue("Description", description);
			reminding.SetColumnValue("SubjectId", parameters.ImportSessionId);
			reminding.SetColumnValue("SysEntitySchemaId", sysProcessLogItem.UId);
			reminding.SetColumnValue("SubjectCaption", caption);
			reminding.SetColumnValue("LoaderId", importSessionItem.UId);
			reminding.Save();
		}

		private void SendNotificationMessage(ImportParameters parameters) {
			var importNotifier = ClassFactory.Get<IImportNotifier>(
					new ConstructorArgument("userConnection", UserConnection),
					new ConstructorArgument("importParameters", parameters));
			importNotifier.NotifyEnd();

		}

		private void CompleteImport(ImportParameters parameters) {
			ImportParametersRepository.Delete(parameters.ImportSessionId);
			SendNotificationMessage(parameters);
			CreateReminding(parameters);
		}

		#endregion

		#region Methods: Protected

		/// <inheritdoc cref="BaseFileImportStage"/>
		protected override FileImportStagesEnum? InternalProcess(ImportParameters parameters) {
			CompleteImport(parameters);
			return null;
		}

		#endregion
	}

	#endregion

}

