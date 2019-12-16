namespace Terrasoft.Configuration.FileImport
{
	using System;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.Factories;

	/// <inheritdoc cref="BaseFileImporter"/>
	[DefaultBinding(typeof(IBaseFileImporter), Name = nameof(PersistentFileImporter))]
	public class PersistentFileImporter : BaseFileImporter
	{
		#region Fields: Private

		IImportParametersRepository _importParametersRepository;
		private IBaseFileImportStage _currentImportStage;
		private IImportStageFactory _importStageFactory;


		#endregion

		#region Properties: Private

		private IImportParametersRepository ImportParametersRepository => _importParametersRepository ??
			(_importParametersRepository = ClassFactory.Get<IImportParametersRepository>(new ConstructorArgument("userConnection", UserConnection)));

		private IImportStageFactory ImportStageFactory =>
				_importStageFactory ?? (_importStageFactory = ClassFactory.Get<IImportStageFactory>());

		#endregion

		#region Constructor: Public

		/// <summary>
		/// Creates instance of type <see cref="PersistentFileImporter" />.
		/// </summary>
		/// <param name="userConnection">User connection.</param>
		public PersistentFileImporter(UserConnection userConnection)
				: base(userConnection) { }

		#endregion

		#region Methods: Private

		private void DeleteImportParameters(Guid importSessionId) {
			ImportParametersRepository.Delete(importSessionId);
		}

		private void SaveCurrentStage(ImportParameters parameters) {
			parameters.ImportStage = _currentImportStage.StageId;
			ImportParametersRepository.UpdateImportStage(parameters.ImportSessionId, _currentImportStage.StageId);
		}

		private void SaveParametersToCache(ImportParameters parameters) {
			CacheStore[parameters.ImportSessionId.ToString()] = parameters;
		}

		#endregion

		#region Methods: Protected

		/// <inheritdoc cref="BaseFileImporter"/>
		protected override IColumnsAggregatorAdapter CreateColumnsAggregator() =>
				new PersistentColumnsAggregatorAdapter(UserConnection);

		/// <inheritdoc cref="BaseFileImporter"/>
		protected override void Import(ImportParameters parameters) {
			_currentImportStage = ImportStageFactory.CreateImportStage(parameters.ImportStage, UserConnection, ColumnsProcessor);
			while((_currentImportStage = _currentImportStage?.ProcessStage(parameters)) != null) {
				if(ImportParametersRepository.GetIsImportSessionCanceled(parameters.ImportSessionId)) {
					DeleteImportParameters(parameters.ImportSessionId);
					throw new OperationCanceledException();
				} else {
					SaveCurrentStage(parameters);
				}
			}
			SaveParametersToCache(parameters);
		}

		/// <inheritdoc cref="BaseFileImporter"/>
		protected override void ImportInternal(Guid importSessionId) {
			base.ImportInternal(importSessionId);
			var parameters = GetImportParameters(importSessionId);
			parameters.ImportStage = FileImportStagesEnum.PrepareFileImportStage;
			parameters.ChunkSize = SysSettings.GetValue(UserConnection, "FileImportEntitySaveChunksCount", 500);
			SysUserInfo currentUser = UserConnection.CurrentUser;
			parameters.AuthorTimeZone = currentUser.TimeZone;
			parameters.AuthorId = currentUser.ContactId;
			ImportParametersRepository.Add(parameters);
			Import(parameters);
		}

		#endregion

	}
}
