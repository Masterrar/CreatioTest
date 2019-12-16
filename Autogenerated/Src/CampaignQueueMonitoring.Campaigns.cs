namespace Terrasoft.Configuration
{
	using System;
	using System.Collections.Generic;
	using System.Data;
	using System.Linq;
	using System.Timers;
	using Terrasoft.Core;
	using Terrasoft.Core.Campaign;
	using Terrasoft.Core.DB;
	using global::Common.Logging;
	using CoreCampaignConsts = Core.Campaign.CampaignConstants;

	#region Class: CampaignQueueMonitoring

	/// <summary>
	/// Encapsulates logic to work with campaign queue, operational table and campaign engine.
	/// </summary>
	public class CampaignQueueMonitoring
	{

		#region Fields: Private

		private bool _timerElapsed = false;

		#endregion

		#region Fields: Protected

		protected int runTime = 50000;

		#endregion

		#region Constructors: Public

		public CampaignQueueMonitoring(UserConnection userConnection) {
			UserConnection = userConnection;
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// An instance of the <see cref="UserConnection"/> class.
		/// </summary>
		public UserConnection UserConnection { get; set; }

		/// <summary>
		/// An instance of <see cref="ICampaignQueueManager"/>.
		/// </summary>
		private ICampaignQueueManager _campaignQueueManager;
		public ICampaignQueueManager CampaignQueueManager {
			get => _campaignQueueManager ?? (_campaignQueueManager = new CampaignQueueManager(UserConnection));
			set => _campaignQueueManager = value;
		}

		/// <summary>
		/// Gets or sets campaign engine to run campaigns created with new designer.
		/// Instance of <see cref="ICampaignEngine"/>.
		/// </summary>
		private ICampaignEngine _campaignEngine;
		public ICampaignEngine CampaignEngine {
			get => _campaignEngine ?? (_campaignEngine = new CampaignEngine(UserConnection));
			set => _campaignEngine = value;
		}

		/// <summary>
		/// Gets or sets the campaign helper. Instance of <see cref="CampaignHelper"/>.
		/// </summary>
		private CampaignHelper _campaignHelper;
		public CampaignHelper CampaignHelper {
			get => _campaignHelper ?? (_campaignHelper = new CampaignHelper(UserConnection));
			set => _campaignHelper = value;
		}

		/// <summary>
		/// Gets or sets the campaign logger. Instance of <see cref="ILog"/>.
		/// </summary>
		private ILog _logger;
		public ILog Logger {
			get => _logger ?? (_logger = LogManager.GetLogger(CoreCampaignConsts.CampaignLoggerName));
			set => _logger = value;
		}

		#endregion

		#region Methods: Private

		private CampaignInfo GetCampaignInfoByItem(Guid campaignItemId) {
			var select = new Select(UserConnection)
				.Column("C", "Id")
				.Column("C", "CampaignStatusId")
				.From("CampaignItem", "CI")
				.InnerJoin("Campaign").As("C").On("C", "Id").IsEqual("CI", "CampaignId")
				.Where("CI", "Id").IsEqual(Column.Parameter(campaignItemId)) as Select;
			select.SpecifyNoLockHints();
			var campaignInfo = new CampaignInfo();
			select.ExecuteReader(x => {
				campaignInfo.CampaignId = x.GetGuid(0);
				campaignInfo.CampaignStatusId = x.GetGuid(1);
			});
			return campaignInfo;
		}

		private string AggregateQueueItems(IEnumerable<CampaignQueueItem> queueItems) =>
			queueItems.Select(x => x.ToString()).Aggregate((x, y) => $"{x}{Environment.NewLine}{y}");

		private string GetCampaignParticipantTableName(Guid campaignId, Guid sessionId) {
			var audienceConfig = new CampaignAudienceConfig(UserConnection, campaignId, sessionId);
			var campaignAudience = CampaignAudienceFactory.Instance.GetCampaignAudience(audienceConfig);
			return ((BaseCampaignAudience)campaignAudience)?.CampaignParticipantTableName;
		}

		private void InsertParticipants(IEnumerable<CampaignQueueItem> queueItems,
				string campaignParticipantTableName, Guid campaignId, Guid sessionId) {
			foreach (var queueItem in queueItems) {
				var campaignParticipantIdParam = queueItem.CampaignParticipantId.Equals(default(Guid))
					? Column.Const(null)
					: Column.Parameter(queueItem.CampaignParticipantId);
				var insert = new Insert(UserConnection)
					.Into(campaignParticipantTableName)
					.Set("ContactId", Column.Parameter(queueItem.ContactId))
					.Set("CampaignParticipantId", campaignParticipantIdParam)
					.Set("CampaignId", Column.Parameter(campaignId))
					.Set("CampaignItemId", Column.Parameter(queueItem.CampaignItemId))
					.Set("StepModifiedOn", Column.Parameter(DateTime.UtcNow))
					.Set("StatusId", Column.Parameter(CoreCampaignConsts.CampaignParticipantParticipatingStatusId))
					.Set("StepCompleted", Column.Const(false))
					.Set("SessionId", Column.Parameter(sessionId))
					.Set("IsReadyToSync", Column.Const(false))
					.Set("InitialCampaignItemId", Column.Parameter(queueItem.CampaignItemId));
				insert.Execute();
			}
		}

		private void AddOperationalParticipants(Guid campaignId, Guid campaignItemId,
				IEnumerable<CampaignQueueItem> queueItems, Guid sessionId) {
			var tableName = GetCampaignParticipantTableName(campaignId, sessionId);
			var relevantContacts = queueItems.Where(x => x.IsRelevantNow());
			InsertParticipants(relevantContacts, tableName, campaignId, sessionId);
		}

		private void RunCampaign(Guid campaignId, Guid campaignItemId, Guid sessionId) {
			var executionConfig = new CampaignExecutionConfig(DateTime.UtcNow, sessionId, campaignItemId);
			var schema = CampaignHelper.GetCampaignSchema(campaignId);
			CampaignEngine.Run(schema, executionConfig);
		}

		private bool ProcessItemsToSkip(IEnumerable<CampaignQueueItem> queueItems, CampaignInfo campaignInfo) {
			if (campaignInfo.CampaignStatusId != CampaignConsts.RunCampaignStatusId) {
				var skippedQueueItems = AggregateQueueItems(queueItems);
				Logger.Debug($"Following items have been skipped due to campaign status changing: [" +
					$"{Environment.NewLine}{skippedQueueItems}{Environment.NewLine}]");
				return true;
			}
			var itemsToSkip = queueItems.Where(x => !x.IsRelevantNow());
			if (itemsToSkip.Any()) {
				var skippedItems = AggregateQueueItems(itemsToSkip);
				Logger.Debug($"Following items have been skipped due to overdue: [" +
					$"{Environment.NewLine}{skippedItems}{Environment.NewLine}]");
				if (itemsToSkip.Count() == queueItems.Count()) {
					return true;
				}
			}
			return false;
		}

		/// <summary>
		/// Starts processing the batch in a transaction.
		/// </summary>
		private int ProcessSingleBatch(out bool isProcessingSkipped) {
			isProcessingSkipped = true;
			using (var dbExecutor = UserConnection.EnsureDBConnection()) {
				dbExecutor.StartTransaction(IsolationLevel.ReadCommitted);
				var queueItems = CampaignQueueManager.Dequeue();
				if (!queueItems.Any()) {
					isProcessingSkipped = false;
					dbExecutor.RollbackTransaction();
					return 0;
				}
				var campaignItemId = queueItems.First().CampaignItemId;
				var campaignInfo = GetCampaignInfoByItem(campaignItemId);
				if (ProcessItemsToSkip(queueItems, campaignInfo)) {
					dbExecutor.CommitTransaction();
					return queueItems.Count();
				}
				var sessionId = Guid.NewGuid();
				AddOperationalParticipants(campaignInfo.CampaignId, campaignItemId, queueItems, sessionId);
				dbExecutor.CommitTransaction();
				RunCampaign(campaignInfo.CampaignId, campaignItemId, sessionId);
				isProcessingSkipped = false;
				return queueItems.Count();
			}
		}

		private void OnTimerElapsed(object source, ElapsedEventArgs e) {
			_timerElapsed = true;
		}

		#endregion

		#region Methods: Public

		/// <summary>
		/// Does <see cref="CampaignQueueManager"/> processing.
		/// </summary>
		/// <remarks>
		/// Use this method only in a single thread.
		/// In case of cluster mode, be aware that using of few instances simultaneously is forbidden.
		/// </remarks>
		public virtual void Run() {
			Timer timer = new Timer(runTime);
			timer.Elapsed += new ElapsedEventHandler(OnTimerElapsed);
			timer.Enabled = true;
			while (!_timerElapsed) {
				var itemsProcessed = ProcessSingleBatch(out var isBatchProcessingSkipped);
				if (isBatchProcessingSkipped) {
					continue;
				}
				if (itemsProcessed == 0) {
					break;
				}
			}
		}

		#endregion

	}
	
	#endregion
	
}

