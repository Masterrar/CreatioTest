namespace Terrasoft.Configuration.FolderManagerService
{
	using System;
	using System.ServiceModel;
	using System.ServiceModel.Web;

	#region Interface: IFolderManagerService
	
	[ServiceContract(Name = "FolderManagerService")]
	public interface IFolderManagerService
	{
		#region Methods: Public

		[OperationContract]
		[WebInvoke(Method = "POST", UriTemplate = "ConvertFolder", BodyStyle = WebMessageBodyStyle.Wrapped, 
			RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
		void ConvertFolder(Guid newFolderId, Guid parentFolderId, string entitySchemaName);

		[OperationContract]
		[WebInvoke(Method = "POST", UriTemplate = "IncludeEntitiesInFolder", BodyStyle = WebMessageBodyStyle.WrappedRequest,
			RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
		ConfigurationServiceResponse IncludeEntitiesInFolder(string sourceSchemaName, string destinationSchemaName,
			string entityColumnNameInFolderEntity, Guid folderId, string filtersConfig);

		#endregion
	}

	#endregion 
}
