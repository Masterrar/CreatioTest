namespace Terrasoft.Mail
{
	using System;
	using System.Globalization;
	using MailBee.ImapMail;
	using MailBee.Mime;
	using Terrasoft.Common;
	using Terrasoft.Configuration;
	using Terrasoft.Configuration.Imap;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities;

	#region Class: FlagBasedSinceDateSyncStrategy

	/// <summary>
	/// <see cref="ISyncStrategy"/> implementaiton, delivered from <see cref="FlagBasedSyncStrategy"/>.
	/// </summary>
	/// <remarks>
	/// FlagBasedSinceDateSyncStrategy used to select all not-draft, not-deleted messages,
	/// not marked by <see cref="FlagBasedSyncStrategy.SyncFlag"/> keyword
	/// since <see cref="DateBasedSyncStrategy._sinceDate"/>.
	/// </remarks>
	public class FlagBasedSinceDateSyncStrategy : FlagBasedSyncStrategy
	{

		#region Constants: Private

		/// <summary>
		/// Search expression template.
		/// </summary>
		private const string _searchQueryTpl = "UNDRAFT UNDELETED UNKEYWORD {0} SINCE {1}";

		#endregion

		#region Fields: Private

		/// <summary>
		/// <see cref="System.DateTime"/> value, used in serch query as since parameter.
		/// </summary>
		private DateTime _sinceDate;

		#endregion

		#region Constructors: Public

		public FlagBasedSinceDateSyncStrategy(UserConnection userConnection, Entity syncSettings) :
			base(userConnection) {
			_sinceDate = LoadFromDateType.GetInstance(userConnection).GetLoadFromDate(syncSettings);
		}

		#endregion

		#region Methods: Public

		/// <summary><see cref="ISyncStrategy.GetUnsyncMsgSearchQuery"/></summary>
		public override string GetUnsyncMsgSearchQuery() {
			if (_sinceDate != DateTimeUtilities.JavascriptMinDateTime && _sinceDate != DateTime.MinValue) {
				return string.Format(_searchQueryTpl, _syncFlag, _sinceDate.ToString(_imapDateFormat,
						CultureInfo.InvariantCulture));
			}
			return base.GetUnsyncMsgSearchQuery();
		}

		#endregion
	}

	#endregion

}
