namespace Terrasoft.Configuration {
	using System;
	using System.Data;
	using System.Collections.Generic;
	using Terrasoft.Core;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Common;
	using Mandrill;
	using Mandrill.Models;
	using System.Linq;
	using Terrasoft.Configuration.Marketing.Utilities;
	using Terrasoft.Configuration.MandrillService;
	using global::Common.Logging;

	#region Class: EmailStatisticHandler

	public class EmailStatisticHandler {

		#region Fields: Private

		private readonly UserConnection _userConnection;

		private MandrillApi _mandrillApi;

		private static readonly ILog _log = LogManager.GetLogger("EmailStatisticHandler");

		private string _primaryColumnName;

		#endregion

		#region Constants: Private

		/// <summary>
		/// ###### ####/####### # Mandrill ### ####### TimeSeries.
		/// </summary>
		private const string MandrillTimeSeriesDateTimeFormat = "yyyy-MM-dd HH:mm:ss";

		private readonly Guid MandrillProviderId = new Guid("2FC77174-C912-4F8D-AD56-8D7FBF9D70F1");

		#endregion

		#region Properties: Private

		private MandrillApi ServiceApi {
			get {
				return _mandrillApi ?? (_mandrillApi = new MandrillApi(MandrillApiKey));
			}
		}

		private string MandrillApiKey {
			get {
				return (string)Terrasoft.Core.Configuration.SysSettings.GetValue(_userConnection, "mandrillApiKey");
			}
		}

		/// <summary>
		/// ######.
		/// </summary>
		public static ILog Log {
			get {
				return _log;
			}
		}

		#endregion

		#region Constructors

		public EmailStatisticHandler(UserConnection userConnection) {
			_userConnection = userConnection;
		}

		#endregion

		#region Methods: Private

		protected EntityCollection GetBulkEmailsForUpdate(Guid? bulkEmailId = null) {
			int period = (int)Terrasoft.Core.Configuration.SysSettings.GetValue(
				_userConnection, "MandrillStatisticUpdatePeriodDays");
			DateTime limitDate = DateTime.Now.AddDays(-period);
			var esq = new EntitySchemaQuery(_userConnection.EntitySchemaManager, "BulkEmail");
			esq.JoinRightState = Terrasoft.Core.DB.QueryJoinRightLevel.Disabled;
			_primaryColumnName = esq.AddColumn("Id").Name;
			esq.AddColumn("RecipientCount");
			esq.AddColumn("StartDate");
			esq.AddColumn("SendStartDate");
			esq.AddColumn("SendDueDate");
			esq.AddColumn("Category");
			if (bulkEmailId.HasValue && bulkEmailId != Guid.Empty) {
				esq.Filters.Add(
					esq.CreateFilterWithParameters(FilterComparisonType.Equal, "Id", bulkEmailId)
				);
			}
			esq.Filters.Add(
				esq.CreateFilterWithParameters(FilterComparisonType.GreaterOrEqual, "SendStartDate", limitDate)
			);
			esq.Filters.Add(
				esq.CreateFilterWithParameters(FilterComparisonType.NotEqual, "Status", new object[] {
					MarketingConsts.BulkEmailStatusPlannedId,
					MarketingConsts.BulkEmailStatusStartPlanedId
				})
			);
			return esq.GetEntityCollection(_userConnection);
		}

		protected void ProcessStatistic(Entity bulkEmail) {
			Guid recordId = bulkEmail.GetTypedColumnValue<Guid>(_primaryColumnName);
			Guid categoryId = bulkEmail.GetTypedColumnValue<Guid>("CategoryId");
			var results = new List<SearchTimeSeriesResult>();
			try {
				results = GetMandrillStatistic(bulkEmail, categoryId);
			} catch (Exception ex) {
				Log.Error(
					string.Format("Failed to receive response from Mandrill service. BulkEmailId: {0}", recordId),
					ex);
			}
			if (!results.Any()) {
				return;
			}
			if (categoryId == MarketingConsts.TriggeredEmailBulkEmailCategoryId) {
				int rId = GetBulkEmailRId(recordId);
				foreach (SearchTimeSeriesResult result in results) {
					ActualizeTimeSeriesResult(rId, result);
				}
				UpdateBulkEmailTimeStatistic(rId);
			} else {
				int sent = 0;
				int hard_bounces = 0;
				int soft_bounces = 0;
				int rejects = 0;
				int unique_opens = 0;
				int complaints = 0;
				int unique_clicks = 0;
				int unsubs = 0;
				foreach (SearchTimeSeriesResult result in results) {
					sent += result.sent;
					hard_bounces += result.hard_bounces;
					soft_bounces += result.soft_bounces;
					rejects += result.rejects;
					unique_opens += result.unique_opens;
					complaints += result.complaints;
					unique_clicks += result.unique_clicks;
					unsubs += result.unsubs;
				}
				var send = sent + hard_bounces + soft_bounces + complaints + unsubs;
				new Update(_userConnection, "BulkEmail")
					.Set("SendCount", Column.Parameter(send))
					.Set("HardBounceCount", Column.Parameter(hard_bounces))
					.Set("SoftBounceCount", Column.Parameter(soft_bounces))
					.Set("RejectedCount", Column.Parameter(rejects))
					.Set("SpamCount", Column.Parameter(complaints))
					.Set("ModifiedById", Column.Parameter(MarketingConsts.MandrillUserId))
					.Set("ModifiedOn", Column.Parameter(DateTime.UtcNow))
					.Set("StatisticDate", Column.Parameter(DateTime.UtcNow))
					.Where("Id").IsEqual(Column.Parameter(recordId))
					.Execute();
			}
		}

		protected List<SearchTimeSeriesResult> GetMandrillStatistic(Entity bulkEmail, Guid categoryId) {
			const int maxDefaultMandrillStatisticPeriod = 30;
			int mandrillStatisticUpdatePeriodDays = (int)Terrasoft.Core.Configuration.SysSettings.GetValue(
				_userConnection, "MandrillStatisticUpdatePeriodDays");
			DateTime sendStartDate = bulkEmail.GetTypedColumnValue<DateTime>("SendStartDate");
			DateTime minMandrillDate = DateTime.UtcNow.AddDays(-maxDefaultMandrillStatisticPeriod);
			if(categoryId == MarketingConsts.TriggeredEmailBulkEmailCategoryId) {
				sendStartDate = DateTime.UtcNow.AddDays(-mandrillStatisticUpdatePeriodDays);
			}
			if(minMandrillDate > sendStartDate) {
				sendStartDate = minMandrillDate;
			}
			var search = new SearchTimeSeries();
			search.date_from = sendStartDate.ToString("yyyy-MM-dd");
			search.date_to = DateTime.UtcNow.ToString("yyyy-MM-dd");
			search.query = "u_bulk_email_id:" + bulkEmail.GetTypedColumnValue<Guid>(_primaryColumnName).ToString("N");
			return ServiceApi.SearchTimeSeries(search);
		}

		protected void ActualizeTimeSeriesResult(int bulkEmailRId, SearchTimeSeriesResult timeSeriesResult) {
			DateTime dateTime = DateTime.ParseExact(timeSeriesResult.time, MandrillTimeSeriesDateTimeFormat,
				System.Globalization.CultureInfo.InvariantCulture);
			int timeStamp = Utilities.ConvertDateTimeToTimestamp(dateTime);
			try {
				MandrillUtilities.ExecuteStoredProcedure(_userConnection, "tsp_ActualizeTimeSeriesResult",
					new KeyValuePair<string, object>("BulkEmailRId", bulkEmailRId),
					new KeyValuePair<string, object>("Timestamp", timeStamp),
					new KeyValuePair<string, object>("Sent", timeSeriesResult.sent),
					new KeyValuePair<string, object>("HardBounces", timeSeriesResult.hard_bounces),
					new KeyValuePair<string, object>("SoftBounces", timeSeriesResult.soft_bounces),
					new KeyValuePair<string, object>("Rejects", timeSeriesResult.rejects),
					new KeyValuePair<string, object>("Complaints", timeSeriesResult.complaints),
					new KeyValuePair<string, object>("UniqueOpens", timeSeriesResult.unique_opens),
					new KeyValuePair<string, object>("UniqueClicks", timeSeriesResult.unique_clicks)
				);
			} catch (Exception e) {
				Log.Error("[ActualizeTimeSeriesResult]", e);
			}
		}

		protected void UpdateBulkEmailTimeStatistic(int bulkEmailRId) {
			try {
				MandrillUtilities.ExecuteStoredProcedure(_userConnection, "tsp_UpdateBulkEmailTimeStatistic",
					new KeyValuePair<string, object>("BulkEmailRId", bulkEmailRId)
				);
			} catch (Exception e) {
				Log.Error("[UpdateBulkEmailTimeStatistic]", e);
			}
		}

		protected int GetBulkEmailRId(Guid bulkEmailId) {
			var select = new Select(_userConnection)
				.Column("RId")
				.From("BulkEmail")
				.Where("Id").IsEqual(Column.Parameter(bulkEmailId)) as Select;
			return select.ExecuteScalar<int>();
		}

		protected bool IsMandrillProviderActive() {
			return (MandrillProviderId == MailingUtilities.GetActiveProviderId(_userConnection));
		}
		#endregion

		#region Methods: Public

		/// <summary>
		/// ######## ########## ## #### ######## ### #### ########## ########.
		/// </summary>
		/// <param name="bulkEmailId">########## ############# ########.</param>
		public void UpdateBulkEamilStatistic(Guid bulkEmailId) {
			if (!IsMandrillProviderActive()) {
				return;
			}
			EntityCollection bulkEmails = GetBulkEmailsForUpdate(bulkEmailId);
			foreach (Entity bulkEmail in bulkEmails) {
				try {
					ProcessStatistic(bulkEmail);
				} catch (Exception e) {
					Log.Error("[UpdateBulkEamilStatistic]", e);
				}
			}
		}

		#endregion

	}

	#endregion
}
