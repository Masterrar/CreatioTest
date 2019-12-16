namespace Terrasoft.Configuration
{
	using System;
	using System.Linq;
	using System.Globalization;
	using System.IO;
	using System.CodeDom.Compiler;
	using System.ServiceModel;
	using System.ServiceModel.Web;
	using System.ServiceModel.Activation;
	using System.Security;
	using System.Net;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Packages;
	using Terrasoft.Core.Entities;
	using Terrasoft.Web.Common;

	#region Class: InstallPackageService

	[ServiceContract]
	[AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Required)]
	public class InstallPackageService : BaseService
	{
		#region Interface: IWebClient

		/// <summary>
		/// Describes Web client operations.
		/// </summary>
		/// <seealso cref="System.IDisposable" />
		public interface IWebClient : IDisposable
		{
			#region Methods: Public

			void DownloadFile(Uri uri, string str);

			#endregion
		}

		#endregion

		#region Class: WebClientWrapper

		/// <summary>
		/// WebClient wrapper.
		/// </summary>
		/// <seealso cref="System.Net.WebClient" />
		/// <seealso cref="Terrasoft.Configuration.InstallPackageService.IWebClient" />
		public class WebClientWrapper : WebClient, IWebClient
		{ }

		#endregion

		#region Constants: Private

		private const string TempPath = @"%TEMP%\%APPLICATION%\%WORKSPACE%\InstallPackages";
		private const string TempPackageDownloadPath = @"%TEMP%\%APPLICATION%\%WORKSPACE%\PackagesTemp";
		private const string PackagesFileName = @"Packages.gz";

		#endregion

		#region Fields: Private

		private readonly string[] _licensingPackages = { "pharma" };

		#endregion

		#region Constructors: Public

		public InstallPackageService() {
		}

		public InstallPackageService(UserConnection userConnection) {
			UserConnection = userConnection;
		}

		#endregion

		#region Properties: Public

		private PackageDBStorage _packageDbStorage;

		/// <summary>
		/// Gets or sets the package database storage.
		/// </summary>
		/// <value>
		/// The package database storage.
		/// </value>
		public PackageDBStorage PackageDBStorage {
			get {
				return _packageDbStorage ?? (_packageDbStorage =
					new PackageDBStorage(UserConnection.AppConnection, UserConnection.Workspace.Id));
			}
			set {
				_packageDbStorage = value;
			}
		}

		private PackageStorageComposer _packageStorageComposer;

		/// <summary>
		/// Gets the package storage composer.
		/// </summary>
		/// <value>
		/// The package storage composer.
		/// </value>
		public PackageStorageComposer PackageStorageComposer {
			get {
				if (_packageStorageComposer == null) {
					IDescriptorComparer comparer =
						SourceControlUtilities.CreateDescriptorComparer(UserConnection.AppConnection);
					_packageStorageComposer = new PackageStorageComposer(comparer);
				}
				return _packageStorageComposer;
			}
			set {
				_packageStorageComposer = value;
			}
		}

		private IWebClient _webClient;

		/// <summary>
		/// Gets the web client.
		/// </summary>
		/// <value>
		/// The web client.
		/// </value>
		public IWebClient WebClient {
			get {
				return _webClient ?? (_webClient = new WebClientWrapper());
			}
			set {
				_webClient = value;
			}
		}

		/// <summary>
		/// Gets or sets the client unit utilities.
		/// </summary>
		/// <value>
		/// The client unit utilities.
		/// </value>
		public PackageFileStorage PackageFileStorage { get; protected set; }


		#endregion

		#region Methods: Private

		private bool GetInstallPackageRights() {
			return UserConnection.DBSecurityEngine.GetCanExecuteOperation("CanManageSolution");
		}

		private bool GetIsError(CompilerErrorCollection compilerErrors) {
			return compilerErrors.Cast<CompilerError>().Any(error => !error.IsWarning);
		}

		private void InstallStorage(string source) {
			string destinationInstallPath = GetDestinationPath(TempPath);
			string tempDownloadPath = GetDestinationPath(TempPackageDownloadPath);
			bool useZipFileStorage = UserConnection.GetIsFeatureEnabled("UsePackageZipFileStorage");
			if (useZipFileStorage) {
				DownloadPackages(source, tempDownloadPath, PackagesFileName);
				PackageFileStorage = new PackageZipFileStorage(destinationInstallPath,
					new Uri(Path.Combine(tempDownloadPath, Path.GetFileNameWithoutExtension(PackagesFileName))));
			} else {
				PackageFileStorage = new PackageRepositoryStorage(destinationInstallPath, new Uri(source));
			}
			PackageStorageComposer.Compose(PackageFileStorage, PackageDBStorage);
			PackageDBStorage.SetPackageStateByCondition(PackageStorageObjectState.NotChanged,
					package => package.State == PackageStorageObjectState.Deleted);
			IPackageContentProvider contentProvider = PackageFileStorage.GetPackageContentProvider();
			PackageDBStorage.PackageInstallOptions = GetPackageInstallOptions();
			PackageDBStorage.Save(contentProvider);
		}

		private void DownloadPackages(string source, string tempDownloadPath, string fileName) {
			var fullPackagePath = Path.Combine(tempDownloadPath, fileName);
			Directory.CreateDirectory(tempDownloadPath);
			string sourceFilePath = Path.Combine(source, fileName);
			using (WebClient) {
				WebClient.DownloadFile(new Uri(sourceFilePath), fullPackagePath);
			}
			CompressionUtilities.UnzipDirectory(fullPackagePath, true);
		}

		private string GetDestinationPath(string path) {
			string correctWorkspaceName = UserConnection.Workspace.Name.Replace(Path.GetInvalidPathChars(), '_');
			int siteId = new AspNetAppDomainInfo(AppDomain.CurrentDomain.FriendlyName).SiteId;
			string destination = Environment.ExpandEnvironmentVariables(path);
			destination = destination.Replace("%WORKSPACE%", correctWorkspaceName, StringComparison.InvariantCultureIgnoreCase);
			destination = destination.Replace("%APPLICATION%", siteId.ToString(CultureInfo.InvariantCulture),
				StringComparison.InvariantCultureIgnoreCase);
			return destination;
		}

		private PackageInstallOptions GetPackageInstallOptions() {
			var installOptions = new PackageInstallOptions(installEnabled: true) {
				ContinueIfError = true,
				SkipConstraints = false,
				SkipValidateActions = true
			};
			return installOptions;
		}

		private bool CheckLicense(string source) {
			string packageName = _licensingPackages.Where(source.ToLower().Contains).FirstOrDefault();
			if (string.IsNullOrEmpty(packageName)) {
				return true;
			}
			EntityCollection availablePackages = UserConnection.LicHelper.GetAvailablePackages();
			bool findLicense = availablePackages.Where(
				item =>
						item.GetTypedColumnValue<string>("SysPackageName").Contains(packageName) &&
						item.GetTypedColumnValue<int>("PersonalLicCount") > 0
			).Any();
			return findLicense;
		}

		#endregion

		#region Methods: Public

		[OperationContract]
		[WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Wrapped, UriTemplate = "Install",
			RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
		[Obsolete("7.9.0 | Use InstallFromStorage(string source)")]
		public string Install(string name, string source) {
			ConfigurationServiceResponse response = InstallFromStorage(source);
			if (!response.Success) {
				string errorCode = response.ErrorInfo.ErrorCode;
				if (errorCode.Equals(typeof(SecurityException).Name)) {
					return "denied";
				}
				return "failed";
			}
			return "success";
		}

		[OperationContract]
		[WebInvoke(Method = "POST", BodyStyle = WebMessageBodyStyle.Wrapped, UriTemplate = "InstallFromStorage",
			RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
		public ConfigurationServiceResponse InstallFromStorage(string source) {
			var response = new ConfigurationServiceResponse();
			try {
				if (!CheckLicense(source)) {
					throw new LicException();
				}
				bool canExecuteOperation = GetInstallPackageRights();
				if (!canExecuteOperation) {
					throw new SecurityException(
						string.Format(
							new LocalizableString("Terrasoft.Core", "DBSecurityEngine.Exception.Admin.UnitCannotExecuteAdminOperation"),
							"CanManageSolution"));
				}
				InstallStorage(source);
				WorkspaceBuilder workspaceBuilder = WorkspaceBuilderUtility.CreateWorkspaceBuilder(UserConnection.AppConnection);
				CompilerErrorCollection compilerErrors = workspaceBuilder.Build(UserConnection.Workspace);
				if (GetIsError(compilerErrors)) {
					throw new Exception(new LocalizableString("Terrasoft.WebApp", "CompilationErrors.Caption"));
				}
				WorkspaceUtilities.ForceGetCustomPackageUId(UserConnection);
			} catch (Exception exception) {
				response.Exception = exception;
			}
			return response;
		}

		#endregion

	}

	#endregion


}

