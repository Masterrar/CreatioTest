namespace Terrasoft.Configuration
{
	using Terrasoft.Common;
	using Terrasoft.Core.Factories;
	using Terrasoft.Tools.DevExpressReport;
	using Terrasoft.Tools.DevExpressReport.Cache.ReportTypeCache;
	using Terrasoft.Tools.DevExpressReport.Localization;
	using Terrasoft.Web.Common;

	#region Class: DevExpressAppEventListener

	public class DevExpressAppEventListener : AppEventListenerBase
	{

		#region Methods: Public

		public override void OnAppStart(AppEventContext context) {
			base.OnAppStart(context);
			ClassFactory.Bind<IReportProvider, CachingDevExpressReportProvider>();
			ClassFactory.Bind<INodeIdGenerator, NodeIdGenerator>();
			ClassFactory.Bind<IReportTypeCache, ReportTypeCache>();
			ClassFactory.Bind<IDevExpressReportLocalizationReader, DevExpressConfReportLocalizationReader>();
		}

		#endregion

	}

	#endregion

}

