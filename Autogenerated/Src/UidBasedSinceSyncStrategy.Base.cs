namespace Terrasoft.Mail
{
	using System;
	using System.Globalization;
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities;

	#region Class: UidBasedSinceSyncStrategy

	/// <summary>
	/// <see cref="ISyncStrategy"/> implementatiton, delivered from <see cref="UidBasedSyncStrategy"/>.
	/// </summary>
	public class UidBasedSinceSyncStrategy : UidBasedSyncStrategy
	{

		#region Properties: Protected

		/// <summary>
		/// Search expression template.
		/// </summary>
		protected override string UnsyncMsgSearchQuery {
			get {
				return "UNDRAFT UNDELETED SINCE {0}";
			}
		}

		#endregion

		#region Constructors: Public

		/// <summary>
		/// Creates new <see cref="UidBasedSinceSyncStrategy"/> instance.
		/// </summary>
		/// <param name="userConnection">User connection.</param>
		/// <param name="syncSettings"><see cref="MailboxSyncSettings"/> instance.</param>
		public UidBasedSinceSyncStrategy(UserConnection userConnection, Entity syncSettings)
			: base(userConnection, syncSettings) {
		}

		#endregion

		#region Methods: Public

		/// <summary><see cref="ISyncStrategy.GetUnsyncMsgSearchQuery"/></summary>
		public override string GetUnsyncMsgSearchQuery() {
			if (string.IsNullOrEmpty(CurrentMessageUidInFolder) || CurrentMessageUidInFolder == "0") {
				DateTime loadEmailsFromDate = LoadFromDateType.GetInstance(UserConnection).GetLoadFromDate(SyncSettings);
				return string.Format(UnsyncMsgSearchQuery, loadEmailsFromDate.ToString(_imapDateFormat, CultureInfo.InvariantCulture));
			}
			return string.Format(base.UnsyncMsgSearchQuery, CurrentMessageUidInFolder);
		}

		#endregion

	}

	#endregion
}

