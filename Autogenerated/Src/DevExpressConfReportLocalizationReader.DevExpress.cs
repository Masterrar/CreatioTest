namespace Terrasoft.Configuration
{
	using System;
	using System.Linq;
	using System.Collections.Generic;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities;
	using Terrasoft.Tools.DevExpressReport.Localization;

	#region Class: DevExpressConfReportLocalizationReader

	public class DevExpressConfReportLocalizationReader : IDevExpressReportLocalizationReader
	{

		#region Constructors: Public

		public DevExpressConfReportLocalizationReader(UserConnection userConnection) {
			UserConnection = userConnection;
		}

		#endregion

		#region Properties: Private

		private UserConnection UserConnection { get; }

		#endregion

		#region Methods: Public

		public Dictionary<string, string> ReadLocalization(Guid reportTemplateId) {
			var esq = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "ReportResources");
			esq.AddColumn("Name");
			esq.AddColumn("Value");
			esq.Filters.Add(esq.CreateFilterWithParameters(FilterComparisonType.Equal, "DevExpressReport", reportTemplateId));
			EntityCollection collection = esq.GetEntityCollection(UserConnection);
			return collection.ToDictionary(x => x.GetTypedColumnValue<string>("Name"), x => x.GetTypedColumnValue<string>("Value"));
		}

		#endregion

	}

	#endregion

}

