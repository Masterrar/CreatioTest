namespace Terrasoft.Configuration.MandrillService {
	using Mandrill;
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.IO;
	using Terrasoft.Core;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Configuration.Marketing.Utilities;
	using global::Common.Logging;

	#region Class: MandrillWebHookEventRouter

	/// <summary>
	/// ############ ##### ########### <see cref="Mandrill.WebHookEvent"/>.
	/// </summary>
	public class MandrillWebHookEventRouter {

		#region Fields: Private

		private static readonly ILog _log = LogManager.GetLogger("MandrillWebHookEventRouter");

		private static readonly int _defaultCountReadRow = 1;

		private static readonly int _maxTimelimit = 30000;

		private static readonly int _defMultiplier = 200;

		/// <summary>
		/// Custom metadata field for bulk email Mandrill.
		/// </summary>
		private const string BulkEmailMetadataValue = "bulk_email_id";

		#endregion

		#region Constructors: Public

		/// <summary>
		/// ############## ##### ######### ###### ################ ############.
		/// </summary>
		/// <param name="userConnection">######### ################# ########### <see cref="UserConnection"/>.</param>
		public MandrillWebHookEventRouter(UserConnection userConnection) {
			UserConnection = userConnection;
		}

		#endregion

		#region Properties: Private

		private UserConnection UserConnection;

		#endregion

		#region Methods: Private

		private int ProcessWebHooks(IEnumerable<Mandrill.WebHookEvent> webHookEvents, DBExecutor dbExecutor) {
			int processedRows = 0;
			foreach (Mandrill.WebHookEvent webHookEvent in webHookEvents) {
				var insert = GetWebHookInsert(webHookEvent);
				if (insert != null)	{
					insert.Execute(dbExecutor);
					processedRows++;
				}
			}
			return processedRows;
		}

		private Insert GetWebHookInsert(WebHookEvent webHookEvent) {
			var insertWebHook = new Insert(UserConnection).Into("MandrillWebHookEvent");
			int allClicks = 0;
			int allOpens = 0;
			string email = String.Empty;
			if (webHookEvent.Reject != null) {
				return null;
			}
			int responseCode = 0;
			BulkEmailResponseCode eventResponseCode;
			try {
				eventResponseCode = webHookEvent.Event.GetBulkEmailResponseCode();
				responseCode = (int)eventResponseCode;
			} catch (InvalidCastException e) {
				_log.ErrorFormat("[HandleWebHooks]: Error parsing response Code:", e);
				return null;
			}

			Guid mandrillId = Guid.Empty;
			if (!Guid.TryParse(webHookEvent.Id, out mandrillId)) {
				_log.ErrorFormat("[HandleWebHooks]: Error parsing message Id: {0}.", webHookEvent.Id);
				return null;
			}
			insertWebHook.Set("MandrillId", Column.Parameter(mandrillId));
			insertWebHook.Set("TimeStamp", Column.Parameter((int)webHookEvent.TS));
			insertWebHook.Set("ResponseCode", Column.Parameter(responseCode));
			var webHookMessage = webHookEvent.Msg;
			if (webHookMessage != null) {
				var webHookClicks = webHookMessage.Clicks;
				var webHookOpens = webHookMessage.Opens;
				if (webHookClicks != null) {
					allClicks = webHookClicks.Count;
				}
				if (webHookOpens != null) {
					allOpens = webHookOpens.Count;
				}
				email = webHookMessage.Email;
				if (!string.IsNullOrEmpty(email)) {
					insertWebHook.Set("Email", Column.Parameter(email));
				}
				var metadata = webHookMessage.Metadata;
				if (metadata != null) {
					var bulkEmailMetadata = metadata.FirstOrDefault(key => key.Key == BulkEmailMetadataValue);
					if (bulkEmailMetadata != null) {
						Guid bulkEmailId = Guid.Empty;
						Guid.TryParse(bulkEmailMetadata.Value, out bulkEmailId);
						insertWebHook.Set("Metadata", Column.Parameter(bulkEmailId));
					}
				}
			}
			insertWebHook.Set("AllClicks", Column.Parameter(allClicks));
			insertWebHook.Set("AllOpens", Column.Parameter(allOpens));
			if (eventResponseCode == BulkEmailResponseCode.Opened) {
				insertWebHook.Set("Opens", Column.Const(1));
			} else if (eventResponseCode == BulkEmailResponseCode.Clicked) {
				string url = UtmHelper.RemoveUtmFromUri(webHookEvent.Url);
				Guid hyperlinkHash = MandrillUtilities.GetMD5HashGuid(url.ToLower());
				insertWebHook.Set("Clicks", Column.Const(1));
				insertWebHook.Set("HyperlinkHash", Column.Parameter(hyperlinkHash));
			}
			return insertWebHook;
		}

		private List<Mandrill.WebHookEvent> CompressedJsonToEmailTargetStatuses(MemoryStream compressedJson) {
			string json = MandrillUtilities.DecompressToString(compressedJson);
			return Mandrill.JSON.Parse<List<Mandrill.WebHookEvent>>(json);
		}

		#endregion

		#region Methods: Public

		/// <summary>
		/// ############ ######## WebHookEvent.
		/// </summary>
		/// <param name="webHookEvents">######### ######### #### WebHookEvent</param>
		public void ProcessRawMandrillEvents() {
			var countReadRow =
				(Int32)Terrasoft.Core.Configuration.SysSettings.GetValue(UserConnection, "MandrillWebHookProcessingPackageCount");
			if (countReadRow < 1) {
				countReadRow = _defaultCountReadRow;
			}
			int batchLimit = countReadRow*_defMultiplier;
			int tc = System.Environment.TickCount;
			int insertedRows = 1;
			while (insertedRows > 0) {
				if (System.Environment.TickCount - tc > _maxTimelimit ) {
					break;
				}
				insertedRows = 0;
				var esq = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "RawMandrillEvent");
				esq.JoinRightState = Terrasoft.Core.DB.QueryJoinRightLevel.Disabled;
				string idColumnName = esq.AddColumn(esq.RootSchema.GetPrimaryColumnName()).Name;
				string JsonDataColumnName = esq.AddColumn("JsonData").Name;
				esq.RowCount = countReadRow;
				EntityCollection rawEvents = esq.GetEntityCollection(UserConnection);
				if (rawEvents.Any()) {
					foreach (Entity rawEvent in rawEvents) {
						Guid id = rawEvent.GetTypedColumnValue<Guid>(idColumnName);
						using (MemoryStream jsonDataCompressed = rawEvent.GetStreamValue(JsonDataColumnName)) {
							using (DBExecutor dbExecutor = UserConnection.EnsureDBConnection()) {
								dbExecutor.StartTransaction();
								try {
									List<Mandrill.WebHookEvent> responses = CompressedJsonToEmailTargetStatuses(jsonDataCompressed);
									insertedRows = ProcessWebHooks(responses, dbExecutor);
									Delete delete = new Delete(UserConnection).From("RawMandrillEvent")
										.Where("Id").IsEqual(Column.Parameter(id)) as Delete;
									delete.Execute(dbExecutor);
									dbExecutor.CommitTransaction();
								} catch (Exception e) {
									dbExecutor.RollbackTransaction();
									_log.ErrorFormat(string.Format("[HandleWebHooks] Error while processing record: {0}", id), e);
								}
							}
						}
					}
				}
			}
		}
		#endregion

	}

	#endregion

}

