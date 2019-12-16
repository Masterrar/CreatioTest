namespace Terrasoft.Configuration.Deduplication
{
	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Linq;
	using System.Net;
	using DeduplicationElastic.Domain.Deduplication.Task;
	using DeduplicationElastic.WebApi.Contracts.Requests;
	using DeduplicationElastic.WebApi.Contracts.Response;
	using RestSharp;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Factories;
	using Terrasoft.Nui.ServiceModel.Extensions;
	using Terrasoft.Web.Http.Abstractions;
	using EntityCollection = Terrasoft.Nui.ServiceModel.DataContract.EntityCollection;

	#region Class: BulkDeduplicationManager

	/// <summary>
	/// Bulk deduplication manager.
	/// </summary>
	[DefaultBinding(typeof(IBulkDeduplicationManager))]
	public class BulkDeduplicationManager : BaseDeduplicationManager, IBulkDeduplicationManager
	{

		#region Fields: Private

		private readonly IStartDeduplicationRequestFactory _startDeduplicationRequestFactory;
		private readonly IBulkDeduplicationTaskClient _bulkDeduplicationTaskClient;
		private readonly IAppSchedulerWraper _appSchedulerWraper;
		private const string IsUniqueAttributeName = "IsUnique";
		private const int MaxFetchPages = 100;

		#endregion

		#region Properties: Protected

		protected virtual int CheckDeduplicationTaskStatusInterval => 1;

		#endregion

		#region Contructors: Public

		public BulkDeduplicationManager(UserConnection userConnection,
				IAppSchedulerWraper appSchedulerWraper) : base(userConnection) {
			if (string.IsNullOrEmpty(DeduplicationWebApiUrl)) {
				Log.Error("DeduplicationWebApiUrl is empty.");
			}
			var userConnectionConstructorArgument = new ConstructorArgument("userConnection", userConnection);
			_startDeduplicationRequestFactory = ClassFactory.Get<IStartDeduplicationRequestFactory>(
				userConnectionConstructorArgument);
			_bulkDeduplicationTaskClient = ClassFactory.Get<IBulkDeduplicationTaskClient>(
				userConnectionConstructorArgument);
			_appSchedulerWraper = appSchedulerWraper;
		}

		#endregion

		#region Methods: Private
		
		private EntitySchemaQuery GetDuplicateEntitiesEsq(string entityName) {
			var esq = new EntitySchemaQuery(UserConnection.EntitySchemaManager, entityName);
			esq.PrimaryQueryColumn.IsAlwaysSelect = true;
			esq.UseAdminRights = true;
			return esq;
		}

		private Dictionary<string, string> GetServerToClientColumnNameMap(string[] columns, EntitySchemaQuery esq) {
			var serverToClientColumnNameMap = new Dictionary<string, string>();
			var primaryColumnName = esq.PrimaryQueryColumn.Name;
			foreach (var column in columns) {
				serverToClientColumnNameMap[esq.AddColumn(column).Name] = column;
			}
			if (!serverToClientColumnNameMap.Any(x => x.Key == primaryColumnName || x.Value == primaryColumnName)) {
				serverToClientColumnNameMap[esq.PrimaryQueryColumn.Name] = esq.PrimaryQueryColumn.Name;
			}
			serverToClientColumnNameMap.Add(IsUniqueAttributeName, IsUniqueAttributeName);
			return serverToClientColumnNameMap;
		}

		private Guid GetRowRecordId(Dictionary<string, object> row, EntitySchemaQuery esq) {
			var primaryColumnName = esq.PrimaryQueryColumn.Name;
			var primaryColumnStringValue = row[primaryColumnName].ToString();
			return Guid.Parse(primaryColumnStringValue);
		}

		private EntityCollection GetDuplicateEntities(EntitySchemaQuery esq, 
			Dictionary<string, string> serverToClientColumnNameMap, IList<DuplicateInfo> entities) {
			esq.ResetSelectQuery();
			esq.Filters.Clear();
			esq.Filters.Add(esq.CreateFilterWithParameters(FilterComparisonType.Equal, esq.PrimaryQueryColumn.Path,
				entities.Select(entity => entity.RecordId.ToString()).Distinct()));
			var duplicatesCollection = QueryExtension.GetEntityCollection(esq.GetEntityCollection(UserConnection), serverToClientColumnNameMap);
			foreach (var item in duplicatesCollection) {
				item.Add(IsUniqueAttributeName, entities.First(x => x.RecordId == GetRowRecordId(item, esq)).IsUnique);
			}
			return duplicatesCollection;
		}

		private BulkEntityClientDuplicatesGroup GetDuplicateGroup(EntitySchemaQuery esq, 
			Dictionary<string, string> serverToClientColumnNameMap, List<DuplicateInfo> entities, Guid groupId) {
			esq.ResetSelectQuery();
			esq.Filters.Clear();
			esq.Filters.Add(esq.CreateFilterWithParameters(FilterComparisonType.Equal, esq.PrimaryQueryColumn.Path,
				entities.Select(entity => entity.RecordId.ToString()).Distinct()));
			var duplicatesCollection = QueryExtension.GetEntityCollection(esq.GetEntityCollection(UserConnection), serverToClientColumnNameMap);
			foreach (var item in duplicatesCollection) {
				item.Add(IsUniqueAttributeName, entities.First(x => x.RecordId == GetRowRecordId(item, esq)).IsUnique);
			}
			return new BulkEntityClientDuplicatesGroup {
				GroupId = groupId,
				Rows = duplicatesCollection
			};
		}

		private void AddIsUniqueColumn(EntitySchemaQuery esq) {
			esq.Columns.Add(new EntitySchemaQueryColumn {
				ValueExpression = new EntitySchemaQueryExpression(EntitySchemaQueryExpressionType.Parameter) {
					ParameterValue = default(bool)
				},
				Name = IsUniqueAttributeName,
				UId = Guid.NewGuid()
			});
		}

		private void ScheduleDeduplicationTaskStatusCheckingJob(string sectionName) {
			var checkDeduplicationTaskParameters = new Dictionary<string, object> {
				{CheckDeduplicationTaskStatusJobExecutor.EntityNameParamName, sectionName},
				{CheckDeduplicationTaskStatusJobExecutor.IndexNameParamName, IndexName}
			};
			var checkDeduplicationStatusJobGroupName =
				CheckDeduplicationTaskStatusJobExecutor.GetCheckDeduplicationStatusJobGroupName(sectionName);
			_appSchedulerWraper.RemoveGroupJobs(checkDeduplicationStatusJobGroupName);
			_appSchedulerWraper.ScheduleMinutelyJob<CheckDeduplicationTaskStatusJobExecutor>(
				checkDeduplicationStatusJobGroupName,
				UserConnection.Workspace.Name, UserConnection.CurrentUser.Name,
				CheckDeduplicationTaskStatusInterval, checkDeduplicationTaskParameters, false);
		}

		private IList<IGrouping<Guid, DuplicateInfo>> FetchDuplicatesFromService(string entityName, int offset, int count) {
			var request = new RestRequest(DuplicationControllerPath, Method.GET);
			request.RequestFormat = DataFormat.Json;
			request.AddParameter("sourceEntityName", entityName, ParameterType.QueryString);
			request.AddParameter("elasticIndexName", IndexName, ParameterType.QueryString);
			request.AddParameter("offset", offset, ParameterType.QueryString);
			request.AddParameter("count", count, ParameterType.QueryString);
			var response = RestClient.Execute<DuplicateResponse>(request);
			if (response.StatusCode != HttpStatusCode.OK) {
				Log.Error($"GetDuplicateEntities for '{entityName}'({offset}, {count}) failed. StatusCode: {response.StatusCode}");
				return null;
			}
			var duplicatesResponse = response.Data;
			if (duplicatesResponse == null) {
				Log.Error($"DuplicateEntitiesResponse for '{entityName}'({offset}, {count}) is invalid. {response.Content}");
				return null;
			}
			return duplicatesResponse.Duplicates?.GroupBy(x => x.GroupId).ToList();
		}
		
		#endregion

		#region Methods: Public

		/// <inheritdoc cref="IBulkDeduplicationManager.GetDeduplicationInfo"/>
		public BulkDeduplicationInfo GetDeduplicationInfo(string entityName) {
			try {
				var deduplicationTaskStatus =
					_bulkDeduplicationTaskClient.GetDeduplicationTaskStatus(entityName, IndexName);
				if (deduplicationTaskStatus == null) {
					return new BulkDeduplicationInfo {
						IsFirstRun = true,
						IsRunning = false
					};
				}
				return new BulkDeduplicationInfo {
					IsFirstRun = false,
					IsRunning = deduplicationTaskStatus == DeduplicationTaskStatus.Pending ||
						deduplicationTaskStatus == DeduplicationTaskStatus.Running
				};
			}
			catch (HttpException)
			{
				return null;
			}
		}

		/// <inheritdoc cref="IBulkDeduplicationManager.GetDuplicateEntitiesGroups"/>
		public BulkDuplicatesGroupResponse GetDuplicateEntitiesGroups(string entityName, string[] columns,
				int clientOffset, int clientCount) {
			var response = new BulkDuplicatesGroupResponse {Groups = new Collection<BulkEntityClientDuplicatesGroup>()};
			int totalCountFromBpm = 0;
			var offset = clientOffset;
			var esq = GetDuplicateEntitiesEsq(entityName);
			var serverToClientColumnNameMap = GetServerToClientColumnNameMap(columns, esq);
			for (int i = 0; i < MaxFetchPages; i++) {
				var duplicateRecordGroups = FetchDuplicatesFromService(entityName, offset, clientCount);
				if (duplicateRecordGroups == null) {
					break;
				}
				var duplicatesCount = duplicateRecordGroups.Sum(x => x.Count());
				offset += duplicatesCount;
				foreach (var duplicateRecords in duplicateRecordGroups) {
					Guid groupId = duplicateRecords.Key;
					var duplicateEntities = GetDuplicateEntities(esq, serverToClientColumnNameMap, duplicateRecords.ToList());
					var group = response.Groups.Find(x => x.GroupId == groupId);
					if (group == null) {
						group = new BulkEntityClientDuplicatesGroup {
							GroupId = groupId, 
							Rows = new EntityCollection()
						};
						response.Groups.Add(group);
					}
					int missingRecords = clientCount - totalCountFromBpm;
					int skippedRecords = duplicateEntities.Count - missingRecords;
					totalCountFromBpm += duplicateEntities.Count;
					response.NextOffset = offset - skippedRecords;
					group.Rows.AddRange(duplicateEntities.Take(missingRecords));
				}
				if (duplicatesCount < clientCount || totalCountFromBpm >= clientCount) {
					break;
				}
			}
			if (response.Groups.IsEmpty()) {
				return null;
			}
			AddIsUniqueColumn(esq);
			response.RowConfig = QueryExtension.GetColumnConfig(esq, serverToClientColumnNameMap);
			response.TotalCountRecords = response.Groups.Sum(x => x.Rows.Count);
			return response;
		}

		/// <inheritdoc cref="IBulkDeduplicationManager.StartDeduplicationTask"/>
		public bool StartDeduplicationTask(string sectionName) {
			try {
				var startDeduplicationRequest = _startDeduplicationRequestFactory
					.CreateStartDeduplicationRequest(sectionName, IndexName);
				var request = new RestRequest($"{DeduplicationTaskControllerPath}start", Method.POST);
				request.RequestFormat = DataFormat.Json;
				request.AddBody(startDeduplicationRequest);
				var response = RestClient.Execute<DeduplicationTaskResponse>(request);
				if (response.Data?.TaskStatus != null) {
					var taskStatus = response.Data.TaskStatus;
					if (taskStatus != DeduplicationTaskStatus.Pending) {
						return false;
					}
					ScheduleDeduplicationTaskStatusCheckingJob(sectionName);
					return true;
				}
				Log.Error($"StartDeduplicationTask for '{sectionName}' is invalid. {response.Content}");
				return false;
			} catch (Exception exception) {
				Log.Error($"StartDeduplicationTask for '{sectionName}' is invalid", exception);
				return false;
			}
		}

		/// <inheritdoc cref="IBulkDeduplicationManager.AddToUniqueList"/>
		public bool AddToUniqueList(string entityName, Guid[] uniqueRecordIds) {
			var addToUniqueListRequest = new AddUniqueRecordsRequest {
				IndexName = IndexName,
				SourceEntityName = entityName,
				UniqueRecordIds = new Collection<Guid>(uniqueRecordIds.ToList())
			};
			var request = new RestRequest(UniqueControllerPath, Method.POST) {
				RequestFormat = DataFormat.Json
			};
			request.AddBody(addToUniqueListRequest);
			var response = RestClient.Execute(request);
			if (response.StatusCode != HttpStatusCode.OK) {
				Log.ErrorFormat("Cannot add unique records for section {0} and index {1}. The message is {2}",
					entityName, IndexName, response.Content);
			}
			return response.StatusCode == HttpStatusCode.OK;
		}

		#endregion
	}

	#endregion

}
