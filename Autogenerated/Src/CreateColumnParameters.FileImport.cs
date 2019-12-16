namespace Terrasoft.Configuration.FileImport
{
	using System;
	using Terrasoft.Core.Entities;

	public class CreateColumnParameters
	{
		#region Properties: Public

		public EntitySchema EntitySchema { get; set; }
		public EntitySchemaColumn EntitySchemaColumn { get; set; }
		public ImportColumnValue ColumnValue { get; set; }
		
		/// <summary>
		/// Data value type unique identifier.
		/// </summary>
		public Guid DataValueTypeUId { get; set; }

		#endregion
	}
}

