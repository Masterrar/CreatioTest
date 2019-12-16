namespace Terrasoft.Configuration
{
	using Terrasoft.Common.Json;
	using Terrasoft.Core;
	using Terrasoft.Core.Factories;
	using Terrasoft.Nui.ServiceModel.DataContract;
	using Terrasoft.Nui.ServiceModel.Extensions;

	#region Interface: IDevExpressReportParametersConfigurator

	public interface IDevExpressReportParametersConfigurator
	{

		#region Methods: Public

		void ConfigureParameters(UserConnection userConnection,
			Tools.DevExpressReport.DevExpressReport report, ReportGeneratorConfiguration configuration);

		#endregion

	}

	#endregion

	#region Class: DevExpressReportParametersConfigurator

	[DefaultBinding(typeof(IDevExpressReportParametersConfigurator), Name = "DevExpressReportParametersConfigurator")]
	public class DevExpressReportParametersConfigurator : IDevExpressReportParametersConfigurator
	{

		#region Methods: Public

		public void ConfigureParameters(UserConnection userConnection,
			Tools.DevExpressReport.DevExpressReport report, ReportGeneratorConfiguration configuration) {
			if (report.Parameters.Count == 0 || configuration.ReportParameters == null) {
				return;
			}
			foreach (var parameter in configuration.ReportParameters) {
				if (report.Parameters[parameter.Key] != null && parameter.Key != "Filters") {
					report.Parameters[parameter.Key].Value = parameter.Value;
				} else {
					if (parameter.Value != null) {
						var filters = Json.Deserialize<Filters>(parameter.Value.ToString());
						var esqFilters = filters.BuildEsqFilter(configuration.EntitySchemaUId, userConnection);
						if (report.Parameters[parameter.Key] != null) {
							report.Parameters[parameter.Key].Value = esqFilters;
						}
					}
				}
			}
		}

		#endregion

	}

	#endregion

}

