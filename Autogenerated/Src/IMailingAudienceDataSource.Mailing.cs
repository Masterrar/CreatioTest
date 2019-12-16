namespace Terrasoft.Configuration
{
	using System;
	using System.Collections.Generic;
	using Core.DB;

	#region Interface: IMailingAudienceDataSource

	/// <summary>
	/// Provides method to get audience of the bulk email.
	/// </summary>
	public interface IMailingAudienceDataSource
	{

		#region Properties: Public

		/// <summary>
		/// Gets or sets the number of the current page.
		/// </summary>
		int PageNumber { get; set; }

		/// <summary>
		/// Get size of last recieved batch.
		/// </summary>
		int LastBatchSize { get; }

		#endregion

		#region Methods: Public

		/// <summary>
		/// Get actual Select query object for fetching of batch of recipints (after calling of GetAudience method).
		/// </summary>
		/// <returns>Instance of <see cref="Select"/>.</returns>
		Select GetRecipientsSelectQuery();

		/// <summary>
		/// Get the audience of the bulk email to send.
		/// </summary>
		/// <returns>List of <see cref="IMessageRecipientInfo"/>.</returns>
		List<IMessageRecipientInfo> GetAudience();

		/// <summary>
		/// Check if audience is empty.
		/// </summary>
		/// <returns>True if audience is empty.</returns>
		bool IsEmpty();

		#endregion

	}

	#endregion

	#region Interface: IDCAudienceDataSource

	/// <summary>
	/// Provides methods for dynamic content recipients.
	/// </summary>
	public interface IDCAudienceDataSource
	{

		#region Properties: Public

		/// <summary>
		/// Gets or sets a value indicating whether this instance works with bulk email containing dynamic template.
		/// </summary>
		bool IsDCBulkEmail { get; set; }

		#endregion

		#region Methods: Public

		/// <summary>
		/// Gets the recipients ids select query.
		/// </summary>
		/// <param name="replicaId">The replica identifier.</param>
		/// <returns>Select query.</returns>
		Select GetRecipientsIdsSelectQuery(Guid replicaId);

		/// <summary>
		/// Gets the recipients ids select query.
		/// </summary>
		/// <param name="replicaId">The replica identifier.</param>
		/// <returns>Select query.</returns>
		Select GetContactsIdsSelectQuery(Guid replicaId);

		/// <summary>
		/// Gets the audience identifiers.
		/// </summary>
		/// <param name="replicaId">The replica identifier.</param>
		/// <returns>Dictionary with RecipientUId and ContactId key-value pair.</returns>
		Dictionary<Guid, Guid> GetAudienceIdentifiers(Guid replicaId);

		#endregion

	}

	#endregion

}
