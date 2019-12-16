namespace Terrasoft.Mail
{
	using System;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Configuration;
#if !NETSTANDARD2_0 // TODO CRM-42546
	using Configuration.Imap;
#endif
	using Terrasoft.Core;
	using Terrasoft.Core.Entities;

	#region Class: DateBasedSyncStrategy

	/// <summary>
	/// <see cref="ISyncStrategy"/> implementaiton, delivered from <see cref="SyncStrategy"/>.
	/// </summary>
	/// <remarks>
	/// DateBasedSyncStrategy used to select all not-draft, not-deleted messages,
	/// since <see cref="DateBasedSyncStrategy._lastSyncDate"/>.
	/// </remarks>
	public class DateBasedSyncStrategy : SyncStrategy
	{

		#region Fields: Private

		/// <summary>
		/// <see cref="System.DateTime"/> value, used in serch query as since parameter.
		/// </summary>
		private DateTime _lastSyncDate;

		#endregion

		#region Property: Protected

		/// <summary>
		/// Search expression template.
		/// </summary>
		protected virtual string UnsyncMsgSearchQuery
		{
			get {
				return "UNDRAFT UNDELETED SINCE {0}";
			}
		}

		#endregion

		#region Constructors: Public

		public DateBasedSyncStrategy(UserConnection userConnection, Entity syncSettings) {
			if (syncSettings == null) {
#if !NETSTANDARD2_0 // TODO CRM-42546
				throw new ImapException(new LocalizableString(userConnection.ResourceStorage, "DateBasedSyncStrategy",
					"LocalizableStrings.LocNoSettings.Value").ToString());
#else
				throw new NotImplementedException();
#endif
			}
			DateTime loadEmailsFromDate = LoadFromDateType.GetInstance(userConnection).GetLoadFromDate(syncSettings);
			DateTime lastSyncDate = syncSettings.GetTypedColumnValue<DateTime>("LastSyncDate");
			_lastSyncDate = loadEmailsFromDate > lastSyncDate ? loadEmailsFromDate : lastSyncDate;
		}

		#endregion

		#region Methods: Public

		/// <summary><see cref="ISyncStrategy.GetUnsyncMsgSearchQuery"/></summary>
		public override string GetUnsyncMsgSearchQuery() {
			return string.Format(UnsyncMsgSearchQuery,
				_lastSyncDate.ToString(_imapDateFormat, CultureInfo.InvariantCulture));
		}

		#endregion

	}

	#endregion
}
