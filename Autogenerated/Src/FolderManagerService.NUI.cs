namespace Terrasoft.Configuration.FolderManagerService {
	using System;
	using System.Runtime.Serialization;
	using System.ServiceModel.Activation;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Factories;
	using Terrasoft.Web.Common;

	#region Class: FolderManagerService

	/// <summary>
	/// Service for work with groups
	/// </summary>
	[AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Required)]
	public class FolderManagerService : BaseService, IFolderManagerService, System.Web.SessionState.IReadOnlySessionState
	{
		#region Fields: Private

		private FolderConverter _folderConverter;
		private GridUtilitiesServiceHandler _gridUtilitiesHandler;

		#endregion

		#region Constructor: Public

		public FolderManagerService(): base() {	}

		public FolderManagerService(UserConnection userConnection): base(userConnection) { }

		#endregion

		#region Properties: Private

		private ConstructorArgument UserConnectionConstructorArg => new ConstructorArgument("userConnection", UserConnection);

		#endregion

		#region Properties: Protected

		protected FolderConverter FolderConverter => _folderConverter  ?? (_folderConverter = ClassFactory.Get<FolderConverter>(UserConnectionConstructorArg));
		protected GridUtilitiesServiceHandler GridUtilitiesHandler => _gridUtilitiesHandler  ?? (_gridUtilitiesHandler = ClassFactory.Get<GridUtilitiesServiceHandler>(UserConnectionConstructorArg));

		#endregion

		#region Methods: Private 

		private IIncludeEntitiesInFolderExecutor CreateIncludeExecutor(FolderActionParameters parameters) =>
			ClassFactory.Get<IIncludeEntitiesInFolderExecutor>(UserConnectionConstructorArg, new ConstructorArgument("parameters", parameters));

		#endregion

		#region Methods: Public

		/// <summary>
		/// Fill static group by dynamic group filter
		/// </summary>
		/// <param name="newFolderId">New folder id</param>
		/// <param name="parentFolderId">Parent folder id</param>
		/// <param name="entitySchemaName">Entity schema name</param>
		public void ConvertFolder(Guid newFolderId, Guid parentFolderId, string entitySchemaName) {
			FolderConverter.Convert(newFolderId, parentFolderId, entitySchemaName);
		}

		/// <summary>
		/// Add selected entities to folder.
		/// </summary>
		/// <param name="sourceSchemaName"></param>
		/// <param name="destinationSchemaName"></param>
		/// <param name="folderId"></param>
		/// <param name="filtersConfig"></param>
		public ConfigurationServiceResponse IncludeEntitiesInFolder(string sourceSchemaName, string destinationSchemaName, 
			string entityColumnNameInFolderEntity, Guid folderId, string filtersConfig) {
			destinationSchemaName.CheckArgumentNullOrEmpty(nameof(destinationSchemaName));
			sourceSchemaName.CheckArgumentNullOrEmpty(nameof(sourceSchemaName));
			entityColumnNameInFolderEntity.CheckArgumentNullOrEmpty(nameof(entityColumnNameInFolderEntity));
			folderId.CheckArgumentEmpty(nameof(folderId));
			filtersConfig.CheckArgumentNullOrEmpty(nameof(filtersConfig));

			var response = new ConfigurationServiceResponse();
			var primaryColumnValues = GridUtilitiesHandler.GetPrimaryColumnValuesFromFilters(sourceSchemaName, filtersConfig);
			var includeParameters = new FolderActionParameters() {
				EntitySchemaName = destinationSchemaName,
				EntityColumnNameInFolderEntity = entityColumnNameInFolderEntity,
				FolderId = folderId
			};

			var handler = CreateIncludeExecutor(includeParameters);
			response.RowsAffected = handler.Execute(primaryColumnValues);
			return response;
		}

		#endregion

	}

	#endregion
}

