namespace Terrasoft.Mail
{
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities;

	#region Class: SentSinceAndDraftsSyncStrategy

	/// <summary>
	/// <see cref="ISyncStrategy"/> implementaiton, delivered from <see cref="DateBasedSentSinceSyncStrategy"/>.
	/// </summary>
	/// <remarks>
	/// SentSinceAndDraftsSyncStrategy used to select all not-deleted messages,
	/// since sent date.
	/// </remarks>
	public class SentSinceAndDraftsSyncStrategy : DateBasedSentSinceSyncStrategy
	{

		#region Property: Protected

		/// <summary>
		/// Search expression template.
		/// </summary>
		protected override string UnsyncMsgSearchQuery => "UNDELETED SENTSINCE {0}";

		#endregion

		#region Constructors: Public

		/// <summary>
		/// Creates <see cref="SentSinceAndDraftsSyncStrategy"/> instance.
		/// </summary>
		/// <param name="userConnection">User connection.</param>
		/// <param name="syncSettings"><see cref="MailboxSyncSettings"/> instance.</param>
		public SentSinceAndDraftsSyncStrategy(UserConnection userConnection, Entity syncSettings)
			: base(userConnection, syncSettings) {
		}

		#endregion

	}

	#endregion
}
