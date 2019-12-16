namespace Terrasoft.Configuration.FileImport
{
	using System;
	using System.Collections.Generic;
	using System.Diagnostics;
	using System.Runtime.Serialization;

	#region  Class: ImportColumn

	[DataContract]
	[DebuggerDisplay("Index={Index}; Source={Source}")]
	[Serializable]
	public class ImportColumn
	{
		#region  Fields: Private

		private List<ImportColumnDestination> _destinations;

		#endregion

		#region  Fields: Public

		[DataMember(Name = "index")]
		public string Index;

		[DataMember(Name = "source")]
		public string Source;

		#endregion

		#region Properties: Public

		[DataMember(Name = "destinations")]
		public List<ImportColumnDestination> Destinations {
			get => _destinations ?? (_destinations = new List<ImportColumnDestination>());
			set => _destinations = value;
		}

		#endregion

		#region Methods: Private

		private int ExcelColumnNameToNumber(string columnName) {
			if (string.IsNullOrEmpty(columnName)) {
				throw new ArgumentNullException(nameof(columnName));
			}
			columnName = columnName.ToUpperInvariant();
			var sum = 0;
			foreach (var t in columnName) {
				sum *= 26;
				sum += t - 'A' + 1;
			}
			return sum;
		}

		#endregion

		#region Methods: Public

		public int GetNumberedIndex() => ExcelColumnNameToNumber(Index);

		#endregion
	}

	#endregion
}

