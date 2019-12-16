﻿namespace Terrasoft.Configuration.FileUpload
{
	using System;
	using System.IO;

	#region Interface: IFileUploadInfo

	public interface IFileUploadInfo
	{
		#region Properties: Public

		/// <summary>
		/// File entity schema name.
		/// </summary>
		string EntitySchemaName
		{
			get;
		}

		/// <summary>
		/// Data entity schema column name.
		/// </summary>
		string ColumnName
		{
			get;
		}

		/// <summary>
		/// File name.
		/// </summary>
		string FileName
		{
			get;
		}

		/// <summary>
		/// File identifier.
		/// </summary>
		Guid FileId
		{
			get;
		}

		/// <summary>
		/// File type identifier.
		/// </summary>
		Guid TypeId
		{
			get;
		}

		/// <summary>
		/// Total file length.
		/// </summary>
		decimal TotalFileLength
		{
			get;
		}

		/// <summary>
		/// Parent column name.
		/// </summary>
		string ParentColumnName
		{
			get;
		}

		/// <summary>
		/// Parent column value.
		/// </summary>
		Guid ParentColumnValue
		{
			get;
		}

		/// <summary>
		/// File content.
		/// </summary>
		Stream Content
		{
			get;
		}

		/// <summary>
		/// Determines if it is chunked upload.
		/// </summary>
		bool IsChunkedUpload
		{
			get;
		}

		/// <summary>
		/// Byte range.
		/// </summary>
		string ByteRange
		{
			get;
		}

		/// <summary>
		/// File version.
		/// </summary>
		int Version
		{
			get;
		}

		/// <summary>
		/// Determines if it is first chunk.
		/// </summary>
		bool IsFirstChunk
		{
			get;
		}

		#endregion
	}

	#endregion
}
