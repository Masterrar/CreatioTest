namespace Terrasoft.Configuration
{
	using System.Collections.Generic;
	using System.Data;
	using System.IO;
	using System.Linq;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Factories;
	using Terrasoft.Tools.DevExpressReport;

	#region Class: DevExpressConfReportCompiler

	/// <summary>
	/// Provides report compilation functionality.
	/// </summary>
	[DefaultBinding(typeof(IReportCompiler))]
	public class DevExpressConfReportCompiler : BaseReportCompiler
	{

		#region Fields: Private

		private static readonly object _lock = new object();

		#endregion

		#region Constructors: Public

		public DevExpressConfReportCompiler(UserConnection userConnection, string temporaryFolder) {
			UserConnection = userConnection;
			Directory.CreateDirectory(temporaryFolder);
			TemporaryFolder = temporaryFolder;
		}

		#endregion

		#region Properties: Public

		public UserConnection UserConnection { get; }

		public string TemporaryFolder { get; }

		#endregion

		#region Methods: Private

		private Select GetRefAssemblyDataSelect(UserConnection userConnection, IEnumerable<string> assemlyNames) {
			var parameters = assemlyNames.Select(name => new QueryParameter(name));
			var refAssemblyDataSelect =
				new Select(userConnection)
					.Column("SysPackageReferenceAssembly", "Name")
					.Column("SysPackageReferenceAssembly", "Data")
				.From("SysPackageReferenceAssembly")
				.InnerJoin("SysPackage").On("SysPackageReferenceAssembly", "SysPackageId")
					.IsEqual("SysPackage", "Id")
				.Where("SysPackageReferenceAssembly", "Name").In(parameters)
					.And("SysPackage", "SysWorkspaceId")
						.IsEqual(Column.Parameter(userConnection.Workspace.Id));
			refAssemblyDataSelect.InitializeParameters();
			return refAssemblyDataSelect as Select;
		}

		private void DownloadAssemblyToFileSystem(IDataReader dataReader, string directoryPath) {
			var assemblyPath = Path.Combine(directoryPath, dataReader.GetColumnValue<string>("Name"));
			using (Stream stream = dataReader.GetStreamValue("Data")) {
				stream.SaveToFile(assemblyPath);
			}
		}

		private void DownloadDevExpressReportAssemblies(UserConnection userConnection,
				string directoryPath, IEnumerable<string> assemblyNames) {
			var refAssemblyDataSelect = GetRefAssemblyDataSelect(userConnection, assemblyNames);
			using (DBExecutor dbExecutor = userConnection.EnsureDBConnection()) {
				using (IDataReader dataReader = refAssemblyDataSelect.ExecuteReader(dbExecutor)) {
					while (dataReader.Read()) {
						DownloadAssemblyToFileSystem(dataReader, directoryPath);
					}
				}
			}
		}

		private bool AreAssembliesDownloaded(string directoryPath, IEnumerable<string> requiredAssemblyNames) {
			IEnumerable<string> existingAssemblyNames = Directory.GetFiles(directoryPath).Select(x => Path.GetFileName(x));
			IEnumerable<string> absentAssemblyNames = requiredAssemblyNames.Except(existingAssemblyNames);
			return !absentAssemblyNames.Any();
		}

		private IEnumerable<string> GetDownloadedAssemblyPaths(string directoryPath, IEnumerable<string> assemblyNames) {
			return assemblyNames.Select(assemblyName => Path.Combine(directoryPath, assemblyName));
		}

		#endregion

		#region Methods: Protected

		protected override IEnumerable<string> GetAssemblyPathes(IEnumerable<string> assemblyNames) {
			lock (_lock) {
				if (!AreAssembliesDownloaded(TemporaryFolder, assemblyNames)) {
					DownloadDevExpressReportAssemblies(UserConnection, TemporaryFolder, assemblyNames);
				}
				return GetDownloadedAssemblyPaths(TemporaryFolder, assemblyNames);
			}
		}

		#endregion

	}

	#endregion

}

