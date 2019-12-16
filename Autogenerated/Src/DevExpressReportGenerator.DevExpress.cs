namespace Terrasoft.Configuration
{
	using System;
	using System.IO;
	using System.Linq;
	using Terrasoft.Common;
	using Terrasoft.Configuration.ReportService;
	using Terrasoft.Core;
	using Terrasoft.Core.Factories;
	using Terrasoft.Core.ServiceModelContract;
	using Terrasoft.Tools.DevExpressReport;
	using Terrasoft.Tools.DevExpressReport.Cache.ReportTypeCache;
	using DevExpressReportMetadata = DevExpressReport;
	using DevExpressReportTemplate = Terrasoft.Tools.DevExpressReport.DevExpressReport;

	#region Class: DevExpressReportGenerator

	/// <summary>
	/// Provides report generating functionality.
	/// </summary>
	[DefaultBinding(typeof(IReportGenerator), Name = "DevExpress")]
	public class DevExpressReportGenerator : IReportGenerator
	{

		#region Constants: Protected

		protected const string DevExpressTempParentFolder = "DevExpressReferences";

		#endregion

		#region Constructors: Public

		/// <summary>
		/// Initializes a new instance of the <see cref="DevExpressReportGenerator"/> class.
		/// </summary>
		public DevExpressReportGenerator() {
			NodeIdGenerator = ClassFactory.Get<INodeIdGenerator>();
		}

		#endregion

		#region Properties: Private

		private INodeIdGenerator NodeIdGenerator { get; }

		#endregion

		#region Methods: Private

		private void CheckReportGeneratorConfiguration(ReportGeneratorConfiguration configuration) {
			if (configuration.ReportTemplateId == Guid.Empty) {
				throw new ArgumentEmptyException(nameof(configuration.ReportTemplateId));
			}
			if (configuration.EntitySchemaUId == Guid.Empty) {
				throw new ArgumentEmptyException(nameof(configuration.EntitySchemaUId));
			}
		}

		private DevExpressReportMetadata GetTemplateMetadata(UserConnection userConnection, Guid reportTemplateId) {
			var entity = new DevExpressReportMetadata(userConnection);
			if (entity.FetchFromDB(reportTemplateId)) {
				return entity;
			}
			throw new ItemNotFoundException(userConnection, reportTemplateId.ToString(),
				nameof(DevExpressReportMetadata));
		}

		private string DecodeTemplateSourceCode(DevExpressReportMetadata templateMetadata) {
			ReportMessage reportMessage = ReportMessage.FromStream(templateMetadata.GetStreamValue("Data"));
			return reportMessage.Body;
		}

		private IReportProvider GetReportProvider(UserConnection userConnection) {
			var reportCompiler =
				ClassFactory.Get<IReportCompiler>(
					new ConstructorArgument("userConnection", userConnection),
					new ConstructorArgument("temporaryFolder", GetDevExpressTempFolder())
				);
			var cacheItemProvider =
				ClassFactory.Get<IReportTypeCacheItemProvider>(
					new ConstructorArgument("userConnection", userConnection));
			var reportTypeCache =
				ClassFactory.Get<IReportTypeCache>(new ConstructorArgument("cacheItemProvider", cacheItemProvider));
			return ClassFactory.Get<IReportProvider>(new ConstructorArgument("reportCompiler", reportCompiler),
				new ConstructorArgument("cache", reportTypeCache));
		}

		private IDevExpressReportParametersConfigurator GetReportParametersConfigurator() {
			return ClassFactory.Get<IDevExpressReportParametersConfigurator>();
		}

		private string GetDevExpressTempFolder() {
			string nodeId = GetNodeId();
			return Path.Combine(Path.GetTempPath(), DevExpressTempParentFolder, nodeId);
		}

		private string GetNodeId() {
			string rawNodeId = NodeIdGenerator.GenerateNodeUniqueId();
			var validNodeId = new string(rawNodeId.Where(char.IsLetterOrDigit).ToArray());
			return validNodeId;
		}

		#endregion

		#region Methods: Public

		/// <summary>
		/// Generates DevExpress report.
		/// </summary>
		/// <param name="userConnection">User connection.</param>
		/// <param name="configuration">Provides configuration for report generator.</param>
		/// <returns>Returns prepared report.</returns>
		public ReportData Generate(UserConnection userConnection, ReportGeneratorConfiguration configuration) {
			CheckReportGeneratorConfiguration(configuration);
			DevExpressReportMetadata templateMetadata =
				GetTemplateMetadata(userConnection, configuration.ReportTemplateId);
			string templateSourceCode = DecodeTemplateSourceCode(templateMetadata);
			var reportProvider = GetReportProvider(userConnection);
			DevExpressReportTemplate report = reportProvider.CreateReport(templateSourceCode, templateMetadata.Name);
			report.UserConnection = userConnection;
			var reportParametersConfigurator = GetReportParametersConfigurator();
			reportParametersConfigurator.ConfigureParameters(userConnection, report, configuration);
			using (var reportStream = new MemoryStream()) {
				report.ExportToPdf(reportStream);
				return new ReportData {
					Caption = templateMetadata.Caption,
					Data = reportStream.ToArray(),
					Format = "pdf"
				};
			}
		}

		#endregion

	}

	#endregion

}

