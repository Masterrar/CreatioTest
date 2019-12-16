namespace Terrasoft.Configuration
{
	using System;
	using Terrasoft.Core;
	using Terrasoft.Core.Factories;
	using Terrasoft.Tools.DevExpressReport.Cache.ReportTypeCache;

	#region Class: ReportTypeCacheItem

	[DefaultBinding(typeof(IReportTypeCacheItem))]
	public class ReportTypeCacheItem : IReportTypeCacheItem
	{

		#region Constructors: Public

		public ReportTypeCacheItem(UserConnection userConnection, string key) {
			UserConnection = userConnection;
			Key = key;
			CreatedOn = DateTime.UtcNow;
		}

		#endregion

		#region Properties: Private

		private UserConnection UserConnection { get; }

		private string Key { get; }

		private DateTime CreatedOn { get; }

		#endregion

		#region Properties: Public

		public Type Value { get; set; }

		#endregion

		#region Methods: Private

		private DateTime GetReportModifiedOn(string reportName) {
			var reportEntitySchema = UserConnection.EntitySchemaManager.GetInstanceByName("DevExpressReport");
			var reportEntity = reportEntitySchema.CreateEntity(UserConnection);
			const string columnToLoad = "ModifiedOn";
			if (reportEntity.FetchFromDB("Name", reportName, new[] { columnToLoad })) {
				return reportEntity.GetTypedColumnValue<DateTime>(columnToLoad).ToUniversalTime();
			}
			return DateTime.MaxValue;
		}

		#endregion

		#region Methods: Public

		public bool GetIsExpired() {
			var modifiedTime = GetReportModifiedOn(Key);
			return modifiedTime > CreatedOn;
		}

		#endregion

	}

	#endregion

}

