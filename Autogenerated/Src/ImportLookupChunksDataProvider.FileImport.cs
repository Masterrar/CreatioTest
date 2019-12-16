namespace Terrasoft.Configuration.FileImport
{
	using Terrasoft.Core;
	using Terrasoft.Core.Factories;

	#region Class: ImportLookupChunksDataProvider

	/// <inheritdoc />
	[DefaultBinding(typeof(IImportChunkDataProvider<LookupChunkData>))]
	public class ImportLookupChunksDataProvider : ImportChunkDataProvider<LookupChunkData>
	{

		#region Constructors: Public

		public ImportLookupChunksDataProvider(UserConnection userConnection) : base(userConnection) {
		}

		#endregion

		#region Methods: Protected

		/// <inheritdoc />
		protected override ImportChunkType GetImportChunkType() {
			return ImportChunkType.Lookup;
		}

		#endregion

	}

	#endregion

}
