namespace Terrasoft.Mail
{
	using System;
	using System.Globalization;
	using MailBee.ImapMail;
	using MailBee.Mime;
	using Terrasoft.Configuration.Imap;

	#region Interface: ISyncStrategy

	/// <summary>
	/// Provides methods for not synced messages search.
	/// Used in <see cref="ImapClient"/> class, as any synchronization strategy base type.
	/// Note that when implementing your own strategy you must expend <see cref="SyncStrategy"/> class,
	/// this interface implementation is forbidden.
	/// </summary>
	public interface ISyncStrategy
	{
		#region Methods: Public

		/// <summary>
		/// Returns <see cref="MailBee.ImapMail.MessageIndexCollection"/> for messages, resolved as not synced 
		/// in current folder.
		/// </summary>
		/// <param name="client"><see cref="MailBee.ImapMail.Imap"/> instance.</param>
		/// <returns>
		/// Not synced messages <see cref="MailBee.ImapMail.MessageIndexCollection"/>.
		/// </returns>
		MessageIndexCollection GetUnsyncedMsgIndexes(Imap client);

		/// <summary>
		/// Returns <see cref="MailBee.ImapMail.MessageIndexCollection"/> for messages, resolved as not synced
		/// in <paramref name="folderPath"/> folder.
		/// </summary>
		/// <param name="client"><see cref="MailBee.ImapMail.Imap"/> instance.</param>
		/// <param name="folderPath">Imap folder full path.</param>
		/// <returns>
		/// Not synced messages <see cref="MailBee.ImapMail.MessageIndexCollection"/>.
		/// </returns>
		MessageIndexCollection GetUnsyncedMsgIndexes(Imap client, string folderPath);

		/// <summary>
		/// Marks message as synchronized.
		/// </summary>
		/// <param name="client"><see cref="MailBee.ImapMail.Imap"/> instance.</param>
		/// <param name="header"><see cref="MailBee.ImapMail.MailMessage"/> instance.</param>
		void SetMessageSynchronized(Imap client, MailMessage header);
		
		/// <summary>
		/// Creates search expression in IMAP4 language.
		/// </summary>
		/// <returns>
		/// Search expression.
		/// </returns>
		string GetUnsyncMsgSearchQuery();
		
		#endregion
	}

	#endregion

}
