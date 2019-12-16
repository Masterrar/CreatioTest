 namespace Terrasoft.Configuration
 {
	using global::Common.Logging;
	using System;
	using System.Collections.Generic;
	using Terrasoft.Core;
	using Terrasoft.Core.Campaign;
	using Terrasoft.Core.Campaign.StartSignal;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;

	#region Class: CampaignSignalEntityHandler

	/// <summary>
	/// Class to handle on campaign signal entity events.
	/// </summary>
	public class CampaignSignalEntityHandler : ICampaignSignalEntityHandler
	{

		#region Constructors: Public

		/// <summary>
		/// Constructor for <see cref="CampaignSignalEntityHandler" />.
		/// </summary>
		/// <param name="userConnection">User connection.</param>
		public CampaignSignalEntityHandler(UserConnection userConnection) {
			UserConnection = userConnection;
		}

		#endregion

		#region Properties: Private

		private UserConnection UserConnection {
			get;
		}

		#endregion

		#region Properties: Protected

		private ILog _logger;

		/// <summary>
		/// Instance of campaign logger.
		/// </summary>
		protected ILog CampaignLogger {
			get => _logger ?? (_logger = LogManager.GetLogger(CampaignConstants.CampaignLoggerName));
			set => _logger = value;
		}

		private ICampaignQueueManager _campaignQueueManager;

		/// <summary>
		/// Instance of <see cref="CampaignQueueManager" />.
		/// </summary>
		protected ICampaignQueueManager CampaignQueueManager {
			get => _campaignQueueManager ?? (_campaignQueueManager = new CampaignQueueManager(UserConnection));
			set => _campaignQueueManager = value;
		}

		/// <summary>
		/// Time (in minutes) that tells, how long signal queue items are actual.
		/// </summary>
		private int _signalQueueItemLifeTime = int.MinValue;
		public int SignalQueueItemLifeTime {
			get {
				if (_signalQueueItemLifeTime < 0) {
					var value = Core.Configuration.SysSettings.GetValue(UserConnection,
						"CampaignTriggeredQueueTimeout", 60);
					_signalQueueItemLifeTime = Math.Max(value, 0);
				}
				return _signalQueueItemLifeTime;
			}
			set {
				_signalQueueItemLifeTime = value;
			}
		}

		#endregion

		#region Methods: Private

		private string GetContactColumnPath(Guid campaignItemId) {
			var select = new Select(UserConnection)
				.Column("cse", "ContactColumnPath")
				.From("CampaignItem", "ci")
				.LeftOuterJoin("CampaignSignalEntity").As("cse").On("ci", "RecordId").IsEqual("cse", "Id")
				.Where("ci", "Id").IsEqual(Column.Parameter(campaignItemId, "Guid")) as Select;
			select.SpecifyNoLockHints();
			return select.ExecuteScalar<string>();
		}

		private List<CampaignQueueItem> GetQueueItemsByEntityId(Guid entityId, Guid entitySchemaUId, 
				Guid campaignItemId, string contactColumnPath) {
			var result = new List<CampaignQueueItem>();
			var entitySchema = UserConnection.EntitySchemaManager.GetInstanceByUId(entitySchemaUId);
			var esQuery = new EntitySchemaQuery(entitySchema);
			var contactColumn = esQuery.AddColumn(contactColumnPath);
			esQuery.IsDistinct = true;
			var filter = esQuery.CreateFilterWithParameters(FilterComparisonType.Equal, "Id", entityId);
			esQuery.Filters.Add(filter);
			var isNotNullContactFilter = esQuery.CreateIsNotNullFilter(contactColumnPath);
			esQuery.Filters.Add(isNotNullContactFilter);
			var contacts = esQuery.GetEntityCollection(UserConnection);
			foreach (var contact in contacts) {
				var contactId = contact.GetTypedColumnValue<Guid>(contactColumn.Name);
				result.Add(new CampaignQueueItem {
					ContactId = contactId,
					CampaignItemId = campaignItemId,
					ExpirationPeriod = SignalQueueItemLifeTime
				});
			}
			return result;
		}

		#endregion

		#region Methods: Public

		/// <summary>
		/// Gets ContactId from entity that triggered event and adds to campaign queue.
		/// </summary>
		/// <param name="entitySchemaUId">Unique identifier of entity schema that has triggered event.</param>
		/// <param name="entityId">Id of entity that has triggered event.</param>
		/// <param name="campaignItemId">Unique identifier of triggered campaign start signal element.</param>
		public void Handle(Guid entitySchemaUId, Guid entityId, Guid campaignItemId) {
			var contactColumnPath = GetContactColumnPath(campaignItemId);
			if (!string.IsNullOrWhiteSpace(contactColumnPath)) {
				 var queueItems = GetQueueItemsByEntityId(entityId, entitySchemaUId, campaignItemId,
					 contactColumnPath);
				CampaignQueueManager.Enqueue(queueItems);
			} else {
				var message = string.Format("Contact column path is not found for campaign item: {0}.",
					campaignItemId);
				CampaignLogger.Error(message);
			}
		}

		#endregion

	}

#endregion

}

