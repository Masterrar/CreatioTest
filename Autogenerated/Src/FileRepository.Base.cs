namespace Terrasoft.Configuration
{
	using System;
	using System.IO;
	using Terrasoft.Configuration.FileLoad;
	using Terrasoft.Configuration.FileUpload;
	using Terrasoft.Core;
	using Terrasoft.Core.Factories;

	#region Class: FileRepository

	public class FileRepository
	{
		#region Constructors: Public

		/// <summary>
		/// Creates instance of type <see cref="FileRepository"/>.
		/// </summary>
		/// <param name="userConnection">User connection.</param>
		public FileRepository(UserConnection userConnection) {
			UserConnection = userConnection;
		}

		#endregion

		#region Properties: Protected

		/// <summary>
		/// User connection.
		/// </summary>
		protected UserConnection UserConnection { get; }

		#endregion

		#region Methods: Public

		/// <summary>
		/// Loads file.
		/// </summary>
		/// <param name="entitySchemaUId">EntitySchema UId.</param>
		/// <param name="fileId">File Id.</param>
		/// <param name="binaryWriter">File content binary writer.</param>
		/// <returns>Loaded file information.</returns>
		public virtual IFileUploadInfo LoadFile(Guid entitySchemaUId, Guid fileId, BinaryWriter binaryWriter) {
			var loader = ClassFactory.Get<FileLoader>(new ConstructorArgument("userConnection", UserConnection));
			return loader.LoadFile(entitySchemaUId, fileId, binaryWriter);
		}

		/// <summary>
		/// Uploads file.
		/// </summary>
		/// <param name="fileUploadInfo">File upload information.</param>
		/// <returns>Is operation successful.</returns>
		public virtual bool UploadFile(IFileUploadInfo fileUploadInfo) {
			return UploadFile(fileUploadInfo, true);
		}

		/// <summary>
		/// Uploads file.
		/// </summary>
		/// <param name="fileUploadInfo">File upload information.</param>
		/// <param name="isSetCustomColumns">Is set custom culumns.</param>
		/// <returns>Is operation successful.</returns>
		public virtual bool UploadFile(IFileUploadInfo fileUploadInfo, bool isSetCustomColumns) {
			var uploader = ClassFactory.Get<FileUploader>(new ConstructorArgument("userConnection", UserConnection));
			return uploader.UploadFile(fileUploadInfo, isSetCustomColumns);
		}

		#endregion
	}

	#endregion
}
