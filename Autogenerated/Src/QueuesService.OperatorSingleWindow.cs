namespace Terrasoft.Configuration.QueuesService
{
	using System;
	using System.Collections.Generic;
	using System.ServiceModel;
	using System.ServiceModel.Web;
	using System.ServiceModel.Activation;
	using System.Text;
	using System.Web;
	using Terrasoft.Common;
	using Terrasoft.Common.Json;
	using Terrasoft.Core;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Process;
	using Terrasoft.Nui.ServiceModel.DataContract;
	using Terrasoft.Nui.ServiceModel.Extensions;

	#region Class: QueuesService

	/// <summary>
	/// ###### ######## ####### ####.
	/// </summary>
	[ServiceContract]
	[AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Required)]
	public class QueuesService : System.Web.SessionState.IReadOnlySessionState
	{

		#region Constants: Private

		/// <summary>
		/// ############# #### ###### "############".
		/// </summary>
		private readonly Guid SearchFolderTypeId = new Guid("{65CA0946-0084-4874-B117-C13199AF3B95}");

		/// <summary>
		/// ############# #### ###### "###########".
		/// </summary>
		private readonly Guid GeneralFolderTypeId = new Guid("{9DC5F6E6-2A61-4DE8-A059-DE30F4E74F24}");

		/// <summary>
		/// ############# ######### ######## # ####### ####### #### "## #########".
		/// </summary>
		private readonly Guid NewQueueItemStatusId = new Guid("{2B341A1D-6FA1-4960-9C85-FEF60D1BBCC4}");

		#endregion

		#region Methods: Private

		/// <summary>
		/// ######## ############# ######## ####### ## ############## ########## ########### ########.
		/// </summary>
		/// <param name="userConnection">################ ###########.</param>
		/// <param name="processUId">############# ########### ######## ######### ######## #######.</param>
		/// <returns></returns>
		private static Guid GetProcessQueueItemId(UserConnection userConnection, string processUId) {
			Process process = userConnection.ProcessEngine.GetProcessByUId(processUId, true);
			return (Guid)process.GetPropertyValue("queueItemId");
		}

		/// <summary>
		/// ########## ######## ######### ######.
		/// </summary>
		/// <param name="userConnection">################ ###########.</param>
		/// <param name="resourceName">############ #######.</param>
		/// <returns></returns>
		private string GetResourceValue(UserConnection userConnection, string resourceName) {
			if (userConnection == null) {
				return string.Empty;
			}
			var resourceStorage = userConnection.Workspace.ResourceStorage;
			var resource = new LocalizableString(resourceStorage, "QueuesService",
				string.Format("LocalizableStrings.{0}.Value", resourceName));
			return (resource == null) ? string.Empty : resource.Value;
		}

		/// <summary>
		/// ######### ######## ####### ## ###### #######.
		/// </summary>
		/// <param name="userConnection">################ ###########.</param>
		/// <param name="folderEntity">###### #######.</param>
		/// <param name="entitySchemaName">######## ##### ####### #######.</param>
		/// <param name="queueId">############# #######.</param>
		/// <returns></returns>
		private int AddFolderEntityQueueItems(UserConnection userConnection, Entity folderEntity,
			string entitySchemaName, Guid queueId) {
			try {
				EntitySchemaManager entitySchemaManager = userConnection.EntitySchemaManager;
				var esq = new EntitySchemaQuery(entitySchemaManager, entitySchemaName);
				esq.PrimaryQueryColumn.IsVisible = true;
				Guid folderTypeId = folderEntity.GetTypedColumnValue<Guid>("FolderTypeId");
				Guid folderId = folderEntity.PrimaryColumnValue;
				if (folderTypeId == SearchFolderTypeId) {
					byte[] searchData = folderEntity.GetBytesValue("SearchData");
					string serializedFilter = Encoding.UTF8.GetString(searchData, 0, searchData.Length);
					if (serializedFilter.IsNullOrEmpty()) {
						return 0;
					}
					// TODO #CC-678 ########### # ######### ############## ######## ServiceStackTextHelper.
					Filters filters = Json.Deserialize<Filters>(serializedFilter);
					IEntitySchemaQueryFilterItem esqFilters = filters.BuildEsqFilter(entitySchemaName, userConnection);
					var queryFilterCollection = esqFilters as EntitySchemaQueryFilterCollection;
					if (queryFilterCollection.Count == 0) {
						return 0;
					}
					if (queryFilterCollection != null) {
						esq.Filters.LogicalOperation = queryFilterCollection.LogicalOperation;
						esq.Filters.IsNot = queryFilterCollection.IsNot;
						foreach (IEntitySchemaQueryFilterItem filter in queryFilterCollection) {
							esq.Filters.Add(filter);
						}
					} else {
						esq.Filters.Add(esqFilters);
					}
				} else if (folderTypeId == GeneralFolderTypeId) {
					esq.Filters.Add(esq.CreateFilterWithParameters(FilterComparisonType.Equal,
						string.Format("[{0}InFolder:{0}:Id].Folder", entitySchemaName), folderId));
				}
				Select select = esq.GetSelectQuery(userConnection);
				select = select
					.Column(new QueryParameter("QueueId", queueId))
					.Column(new QueryParameter("StatusId", NewQueueItemStatusId))
					.And().Not().Exists(new Select(userConnection)
						.Column("Id")
					.From("QueueItem")
						.Where(entitySchemaName, "Id").IsEqual("QueueItem", "EntityRecordId")
						.And("QueueItem", "QueueId").IsEqual(Column.Parameter(queueId))) as Select;
				var insertSelect = new InsertSelect(userConnection)
					.Into("QueueItem")
					.Set("EntityRecordId", "QueueId", "StatusId")
					.FromSelect(select);
				return insertSelect.Execute();
			} catch (Exception e) {
				QueuesUtilities.LogError(string.Format(GetResourceValue(userConnection, "InvokeMethodErrorMessage"),
					"AddFolderEntityQueueItems", e.Message), e);
				throw;
			}
		}

		#endregion

		#region Methods: Public

		/// <summary>
		/// ########### ######## ############ ## ######### ########### ########## ######## ####### ####.
		/// </summary>
		[OperationContract]
		[WebInvoke(Method = "POST", UriTemplate = "SubscribeForQueuesNotifications",
			BodyStyle = WebMessageBodyStyle.Wrapped,RequestFormat = WebMessageFormat.Json,
			ResponseFormat = WebMessageFormat.Json)]
		public void SubscribeForQueuesNotifications() {
			var userConnection = HttpContext.Current.Session["UserConnection"] as UserConnection;
			if (userConnection == null) {
				throw new ArgumentNullException("UserConnection");
			}
			var userId = userConnection.CurrentUser.Id;
			if (!QueuesUtilities.QueuesNotificationsSubscribers.Contains(userId)) {
				string message = string.Format(
					GetResourceValue(userConnection, "AddingUserToQueuesNotificationsSubscribersMessage"), userId);
				QueuesUtilities.LogDebug(message);
				QueuesUtilities.QueuesNotificationsSubscribers.Add(userId);
			}
		}

		/// <summary>
		/// ######### ####### ############ ########## ######## ####### ####.
		/// </summary>
		[OperationContract]
		[WebInvoke(Method = "POST", UriTemplate = "UpdateQueuesTrigger", BodyStyle = WebMessageBodyStyle.Wrapped,
			RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
		public void UpdateQueuesTrigger() {
			var appConnection = HttpContext.Current.Application["AppConnection"] as AppConnection;
			if (appConnection == null) {
				throw new ArgumentNullException("AppConnection");
			}
			QueuesUtilities.UpdateQueuesTrigger(appConnection.SystemUserConnection);
		}

		/// <summary>
		/// ######### #### ######### ######### ######## #######, ## ######## ####### ####### #########.
		/// </summary>
		/// <param name="processUId">############# ########### ######## ######### ######## #######.</param>
		/// <param name="nextProcessingDateMilliseconds">#### ######### ######### ######## #######.<remarks>
		/// ########## # #### ########## ########### # 1 ###### 1970 ####.</remarks></param>
		[OperationContract]
		[WebInvoke(Method = "POST", UriTemplate = "ChangeQueueItemDate", BodyStyle = WebMessageBodyStyle.Wrapped,
			RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
		public void ChangeQueueItemDate(string processUId, long nextProcessingDateMilliseconds) {
			DateTime nextProcessingDate = new DateTime(1970, 01, 01).AddMilliseconds(nextProcessingDateMilliseconds);
			nextProcessingDate = DateTime.SpecifyKind(nextProcessingDate, DateTimeKind.Utc);
			var userConnection = HttpContext.Current.Session["UserConnection"] as UserConnection;
			string message = string.Empty;
			try {
				if (userConnection == null) {
					throw new ArgumentNullException("UserConnection");
				}
				Guid queueItemId = GetProcessQueueItemId(userConnection, processUId);
				var update =
					new Update(userConnection, "QueueItem")
						.Set("NextProcessingDate", new QueryParameter("NextProcessingDate", nextProcessingDate))
					.Where("Id").IsEqual(new QueryParameter("QueueItemId", queueItemId));
				update.Execute();
				message = string.Format(GetResourceValue(userConnection, "QueueItemDateUpdatedMessage"), queueItemId,
					nextProcessingDate.ToString());
				QueuesUtilities.LogDebug(message);
			} catch (Exception e) {
				message = string.Format(GetResourceValue(userConnection, "InvokeMethodErrorMessage"),
					"ChangeQueueItemDate", e.Message);
				QueuesUtilities.LogError(message, e);
				throw;
			}
		}

		/// <summary>
		/// ########### (########## # #######) ####### #######.
		/// </summary>
		/// <param name="queueItemId">############# ######## #######.</param>
		/// <returns>########## ############ ######### #######.</returns>
		[OperationContract]
		[WebInvoke(Method = "POST", UriTemplate = "PostponeQueueItem", BodyStyle = WebMessageBodyStyle.WrappedRequest,
			RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
		public int PostponeQueueItem(Guid queueItemId) {
			var userConnection = HttpContext.Current.Session["UserConnection"] as UserConnection;
			int updateCount = 0;
			string message = string.Empty;
			try {
				if (userConnection == null) {
					throw new ArgumentNullException("UserConnection");
				}
				var update =
					new Update(userConnection, "QueueItem")
						.Set("PostponesCount", new QueryColumnExpression(ArithmeticOperation.Addition,
							new QueryColumnExpression("PostponesCount"), new QueryColumnExpression(Column.Const(1))))
						.Set("OperatorId", Column.Parameter(null, "Guid"))
						.Set("NextProcessingDate", Column.Const(null))
					.Where("Id").IsEqual(new QueryParameter("QueueItemId", queueItemId));
				updateCount = update.Execute();
				message = string.Format(GetResourceValue(userConnection, "QueueItemPostponeUpdatedMessage"),
					queueItemId);
				QueuesUtilities.LogDebug(message);
			} catch (Exception e) {
				message = string.Format(GetResourceValue(userConnection, "InvokeMethodErrorMessage"),
					"PostponeQueueItem", e.Message);
				QueuesUtilities.LogError(message, e);
				throw;
			}
			return updateCount;
		}

		/// <summary>
		/// ######### ######## ####### ## ######### ####.
		/// </summary>
		/// <param name="folderIds">###### ############### ######### ####.</param>
		/// <param name="entitySchemaName">######## ##### ####### #######.</param>
		/// <param name="queueId">############# #######.</param>
		/// <returns>############### ###### # ########### # ########## ########### ####### # ########### ######.</returns>
		[OperationContract]
		[WebInvoke(Method = "POST", UriTemplate = "AddFoldersQueueItems",
			BodyStyle = WebMessageBodyStyle.WrappedRequest, RequestFormat = WebMessageFormat.Json,
			ResponseFormat = WebMessageFormat.Json)]
		public string AddFoldersQueueItems(List<object> folderIds, string entitySchemaName, Guid queueId) {
			List<String> emptyParameters = new List<String>();
			if (folderIds.IsNullOrEmpty()) {
				emptyParameters.Add("folderIds");
			}
			if (entitySchemaName.IsNullOrEmpty()) {
				emptyParameters.Add("entitySchemaName");
			}
			if (queueId.IsEmpty()) {
				emptyParameters.Add("queueId");
			}
			if (!emptyParameters.IsNullOrEmpty()) {
				string message = string.Format(new LocalizableString("Terrasoft.Common",
				"Exception.ArgumentNullOrEmpty"),
					StringUtilities.Concat(emptyParameters));
				var emptyParametersResult = new {
					addedEntitiesCount = 0,
					errorMessages = message
				};
				return ServiceStackTextHelper.Serialize(emptyParametersResult);
			}
			UserConnection userConnection = (UserConnection)HttpContext.Current.Session["UserConnection"];
			EntitySchemaManager entitySchemaManager = userConnection.EntitySchemaManager;
			var esq = new EntitySchemaQuery(entitySchemaManager, entitySchemaName + "Folder");
			esq.PrimaryQueryColumn.IsVisible = true;
			esq.AddColumn("SearchData");
			esq.AddColumn("FolderType");
			esq.Filters.Add(esq.CreateFilterWithParameters(FilterComparisonType.Equal, "Id", folderIds));
			Terrasoft.Core.Entities.EntityCollection entities = esq.GetEntityCollection(userConnection);
			var addedEntitiesCount = 0;
			StringBuilder errorMessages = new StringBuilder();
			foreach (Entity entity in entities) {
				try {
					addedEntitiesCount = addedEntitiesCount + AddFolderEntityQueueItems(userConnection, entity,
						entitySchemaName, queueId);
				} catch (Exception e) {
					errorMessages.AppendLine(e.Message);
				}
			}
			var result = new {
				addedEntitiesCount = addedEntitiesCount,
				errorMessages = errorMessages.ToString()
			};
			return ServiceStackTextHelper.Serialize(result);
		}

		#endregion

	}

	#endregion

}

