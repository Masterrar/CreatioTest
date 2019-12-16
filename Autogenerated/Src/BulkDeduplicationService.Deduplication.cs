namespace Terrasoft.Configuration.Deduplication
{
	using System;
	using System.ServiceModel;
	using System.ServiceModel.Activation;
	using System.ServiceModel.Web;
	using Newtonsoft.Json;
	using Terrasoft.Core.Factories;

	#region Class: BulkDeduplicationService

	/// <summary>
	/// Represent class for bulk deduplication service.
	/// </summary>
	[ServiceContract]
	[AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Required)]
	public class BulkDeduplicationService
	{

		#region Properties: Protected

		private IBulkDeduplicationManager _deduplicationManager;
		protected IBulkDeduplicationManager DeduplicationManager {
			get {
				if (_deduplicationManager == null) {
					_deduplicationManager = ClassFactory.Get<IBulkDeduplicationManager>();
				}
				return _deduplicationManager;
			}
		}

		#endregion

		#region Methods: Public

		[OperationContract]
		[WebInvoke(Method = "POST", UriTemplate = "GetDeduplicationInfo", BodyStyle = WebMessageBodyStyle.Wrapped,
			RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
		[return: MessageParameter(Name = "deduplicationInfo")]
		public BulkDeduplicationInfo GetDeduplicationInfo(string entityName) {
			return DeduplicationManager.GetDeduplicationInfo(entityName);
		}

		[OperationContract]
		[WebInvoke(Method = "POST", UriTemplate = "FindDuplicateEntities", BodyStyle = WebMessageBodyStyle.Wrapped,
			RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
		[return: MessageParameter(Name = "success")]
		public bool FindDuplicateEntities(string entityName) {
			return DeduplicationManager.StartDeduplicationTask(entityName);
		}

		[OperationContract]
		[WebInvoke(Method = "POST", UriTemplate = "GetDuplicateEntities", BodyStyle = WebMessageBodyStyle.Wrapped,
			RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
		[return: MessageParameter(Name = "result")]
		public string GetDuplicateEntities(string entityName, string[] columns, int offset, int count) {
			var result = DeduplicationManager.GetDuplicateEntitiesGroups(entityName, columns, offset, count);
			return JsonConvert.SerializeObject(result);
		}

		[OperationContract]
		[WebInvoke(Method = "POST", UriTemplate = "AddToUniqueList", BodyStyle = WebMessageBodyStyle.Wrapped,
			RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
		[return: MessageParameter(Name = "success")]
		public bool AddToUniqueList(string schemaName, Guid[] uniqueRecordIds) {
			return DeduplicationManager.AddToUniqueList(schemaName, uniqueRecordIds);
		}

		#endregion
	}

	#endregion

}
