namespace Terrasoft.Configuration
{
	using System;
	using System.Collections.Generic;
	using System.Runtime.Serialization;
	using System.ServiceModel;
	using System.ServiceModel.Activation;
	using System.ServiceModel.Web;
	using Web.Common;

	#region Class: SenderObtainingService

	/// <summary>
	/// Service for sender mailbox obtaining.
	/// </summary>
	[ServiceContract]
	[AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Required)]
	public class SenderObtainingService : BaseService
	{

		#region Class: SenderObtainingServiceResponse

		/// <summary>
		/// Represents sender mailbox data container.
		/// </summary>
		[DataContract]
		public class SenderObtainingServiceResponse : ConfigurationServiceResponse
		{
			/// <summary>
			/// Sender mailbox name.
			/// </summary>
			[DataMember(Name = "MailboxName")]
			public string MailboxName { get; set; }
		}

		#endregion

		#region Methods: Public

		/// <summary>
		/// Obtains sender mailbox by activity recipients, case contact and category.
		/// Uses <seealso cref="EmailSenderObtainerWrapper"/>.
		/// </summary>
		/// <param name="recipients">Email recipients, separated with semicolon.</param>
		/// <param name="contactId">Case contact entity identifier.</param>
		/// <param name="categoryId">Case category entity identifier.</param>
		/// <returns>Response with sender mailbox data.</returns>
		[OperationContract]
		[WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Wrapped,
			ResponseFormat = WebMessageFormat.Json)]
		public SenderObtainingServiceResponse ObtainSenderMailbox(string recipients, Guid contactId, Guid categoryId) {
			var wrapper = new EmailSenderObtainerWrapper(UserConnection);
			var mailbox = new MailboxSyncSettings(UserConnection);
			try {
				var mailboxName = wrapper.GetSupportMailBox(recipients, contactId, categoryId);
				return new SenderObtainingServiceResponse {
					Success = !string.IsNullOrEmpty(mailboxName),
					MailboxName = mailboxName,
				};
			} catch (Exception e) {
				return new SenderObtainingServiceResponse { Success = false, Exception = e };
			}
		}

		#endregion

	}

	#endregion

}
