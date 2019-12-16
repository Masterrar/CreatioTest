namespace Terrasoft.Configuration
{
	using System;
	using Terrasoft.Core;
	using Terrasoft.Core.Factories;
	using Terrasoft.Tools.DevExpressReport.Cache.ReportTypeCache;

	#region Class: ReportTypeCacheItemProvider

	[DefaultBinding(typeof(IReportTypeCacheItemProvider))]
	public class ReportTypeCacheItemProvider : IReportTypeCacheItemProvider
	{

		#region Constructors: Public

		public ReportTypeCacheItemProvider(UserConnection userConnection) {
			UserConnection = userConnection;
		}

		#endregion

		#region Properties: Private

		private UserConnection UserConnection { get; }

		#endregion

		#region Methods: Public

		public IReportTypeCacheItem Create(string key, Type value) {
			return new ReportTypeCacheItem(UserConnection, key) {
				Value = value
			};
		}

		#endregion

	}

	#endregion

}

