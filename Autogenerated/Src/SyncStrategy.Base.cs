namespace Terrasoft.Mail
{
	using System;
	using System.Globalization;
	using MailBee.ImapMail;
	using MailBee.Mime;
	using Terrasoft.Configuration.Imap;
	using Terrasoft.Core.Entities;

	#region Class: SyncStrategy

	/// <summary><see cref="ISyncStrategy"/> implementaiton.</summary>
	public abstract class SyncStrategy: ISyncStrategy
	{

		#region Constants: Internal
		
		/// <summary>
		/// Imap search query date format.
		/// </summary>
		internal const string _imapDateFormat = "dd-MMM-yyyy";
		
		#endregion

		#region Proporties: public

		/// <summary>
		/// Synchronization settings <see cref="Entity"/> instance.
		/// </summary>
		public Entity SyncSettings {
			get;
			set;
		}

		#endregion

		#region Methods: Public

		/// <summary><see cref="ISyncStrategy.GetUnsyncedMsgIndexes(Imap)"/></summary>
		public virtual MessageIndexCollection GetUnsyncedMsgIndexes(Imap client) {
			return client.Search(true, GetUnsyncMsgSearchQuery(), null);
		}

		/// <summary><see cref="ISyncStrategy.GetUnsyncedMsgIndexes(Imap, string)"/></summary>
		public virtual MessageIndexCollection GetUnsyncedMsgIndexes(Imap client, string folderPath) {
			return GetUnsyncedMsgIndexes(client);
		}
		
		/// <summary><see cref="ISyncStrategy.SetMessageSynchronized"/></summary>
		public virtual void SetMessageSynchronized(Imap client, MailMessage header) {
		}
		
		/// <summary><see cref="ISyncStrategy.GetUnsyncMsgSearchQuery"/></summary>
		public abstract string GetUnsyncMsgSearchQuery();

		#endregion

	}

	#endregion

}
