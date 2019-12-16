namespace Terrasoft.Configuration.FileUpload
{
	using System;
	using Terrasoft.Core;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using TSConfiguration = Terrasoft.Core.Configuration;

	#region Class: FileUploader

	public class FileUploader
	{
		#region Constants: Private

		private const string MaxFileSizeSysSettingName = "MaxFileSize";

		#endregion

		#region Constructors: Public

		/// <summary>
		/// Creates instance of type <see cref="FileUploader"/>.
		/// </summary>
		/// <param name="userConnection">User connection.</param>
		public FileUploader(UserConnection userConnection) {
			UserConnection = userConnection;
		}

		#endregion

		#region Properties: Protected

		/// <summary>
		/// User connection.
		/// </summary>
		protected UserConnection UserConnection { get; }

		#endregion

		#region Methods: Private

		/// <summary>
		/// Appends file content into database.
		/// </summary>
		/// <param name="fileUploadInfo">File upload information.</param>
		private void AppendData(IFileUploadInfo fileUploadInfo) {
			DBLobUtilities.AppendBlob(UserConnection, fileUploadInfo.EntitySchemaName, fileUploadInfo.ColumnName,
				fileUploadInfo.FileId, fileUploadInfo.Content);
		}

		/// <summary>
		/// Returns file entity.
		/// </summary>
		/// <param name="fileUploadInfo">File upload info.</param>
		/// <returns>File entity.</returns>
		private Entity GetFileEntity(IFileUploadInfo fileUploadInfo) {
			EntitySchema entitySchema = UserConnection.EntitySchemaManager.GetInstanceByName(fileUploadInfo.EntitySchemaName);
			Entity entity = entitySchema.CreateEntity(UserConnection);
			entity.UseAdminRights = false;
			if (!entity.FetchFromDB(fileUploadInfo.FileId)) {
				entity.SetDefColumnValues();
				EntitySchemaColumn column = entitySchema.Columns.FindByName(fileUploadInfo.ParentColumnName);
				entity.SetColumnValue(column.ColumnValueName, fileUploadInfo.ParentColumnValue);
			}
			entity.SetStreamValue(fileUploadInfo.ColumnName, fileUploadInfo.Content);
			entity.SetColumnValue("Size", fileUploadInfo.TotalFileLength);
			return entity;
		}

		#endregion

		#region Methods: Protected

		/// <summary>
		/// Gets maximum file size system setting value in bytes.
		/// </summary>
		/// <returns>File size system setting value in bytes.</returns>
		protected decimal GetMaxFileSize() {
			int value = TSConfiguration.SysSettings.GetValue(UserConnection, MaxFileSizeSysSettingName, 0);
			return (decimal)value * 1024 * 1024;
		}

		/// <summary>
		/// Saves file content into database.
		/// </summary>
		/// <param name="fileUploadInfo">File upload information.</param>
		/// <param name="isSetCustomColumns">Is set custom culumns.</param>
		protected void Save(IFileUploadInfo fileUploadInfo, bool isSetCustomColumns = true) {
			Entity entity = GetFileEntity(fileUploadInfo);
			if (isSetCustomColumns) {
				SetCustomColumns(entity, fileUploadInfo);
			}
			entity.Save();
		}

		/// <summary>
		/// Sets custom columns to <paramref name="entity"/> according to <paramref name="fileUploadInfo"/>.
		/// </summary>
		/// <param name="entity">File entity.</param>
		/// <param name="fileUploadInfo">File upload information.</param>
		protected virtual void SetCustomColumns(Entity entity, IFileUploadInfo fileUploadInfo) {
			entity.SetColumnValue("Id", fileUploadInfo.FileId);
			entity.SetColumnValue("Name", fileUploadInfo.FileName);
			entity.SetColumnValue("TypeId", fileUploadInfo.TypeId);
			entity.SetColumnValue("Version", fileUploadInfo.Version);
		}

		/// <summary>
		/// Checks validity of file size.
		/// </summary>
		/// <param name="totalFileLength"></param>
		/// <returns>Is file size valid.</returns>
		protected bool CheckMaxFileSize(decimal totalFileLength) {
			decimal maxFileSize = GetMaxFileSize();
			return maxFileSize != 0 && totalFileLength > maxFileSize;
		}

		#endregion

		#region Methods: Public

		/// <summary>
		/// Uploads file content.
		/// </summary>
		/// <param name="fileUploadInfo">File upload information.</param>
		/// <returns>File upload result.</returns>
		[Obsolete("Deprecated since 7.11.2. Use UploadFile instead")]
		public virtual string Upload(IFileUploadInfo fileUploadInfo) {
			UploadFile(fileUploadInfo);
			return "Ok";
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
			if (CheckMaxFileSize(fileUploadInfo.TotalFileLength)) {
				throw new MaxFileSizeExceededException(UserConnection.Workspace.ResourceStorage);
			}
			if (!fileUploadInfo.IsChunkedUpload || fileUploadInfo.IsFirstChunk) {
				Save(fileUploadInfo, isSetCustomColumns);
			} else {
				AppendData(fileUploadInfo);
			}
			return true;
		}

		#endregion
	}

	#endregion
}
