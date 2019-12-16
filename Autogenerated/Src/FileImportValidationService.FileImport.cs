namespace Terrasoft.Configuration.FileImport
{
	using System;
	using System.ServiceModel.Activation;
	using System.Web.SessionState;
	using Core.Factories;
	using Web.Common;

	#region  Class: FileImportValidationResponse

	public class FileImportValidationResponse : ConfigurationServiceResponse
	{
		#region  Fields: Public

		public bool CanUseImportEntitiesStorage;

		#endregion
	}

	#endregion

	#region  Class: FileImportValidationService

	[AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Required)]
	public class FileImportValidationService : BaseService, IFileImportValidationService, IReadOnlySessionState
	{
		#region  Fields: Private

		private FileImporter _fileImporter;

		#endregion

		#region Properties: Protected

		/// <summary>
		/// File importer.
		/// </summary>
		protected FileImporter FileImporter => _fileImporter ?? (_fileImporter = ClassFactory.Get<FileImporter>(
				new ConstructorArgument("userConnection", UserConnection)));

		#endregion

		#region Methods: Public

		/// <summary>
		/// Validate imports settings.
		/// </summary>
		/// <param name="request">File import service request.</param>
		/// <returns>Operation result.</returns>
		public FileImportValidationResponse Validate(FileImportServiceRequest request) {
			var response = new FileImportValidationResponse();
			try {
				response.CanUseImportEntitiesStorage = FileImporter.Validate(request.ImportSessionId);
			} catch (Exception e) {
				response.Exception = e;
			}
			return response;
		}

		#endregion
	}

	#endregion
}

