namespace Terrasoft.Configuration
{
	using System;
	using System.Text.RegularExpressions;
	using Terrasoft.Configuration.CES;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities;

	#region Class: ValidationMailingState

	public class ValidationMailingState : MailingState
	{

		#region Properties: Protected

		protected UserConnection UserConnection { get; set; }

		#endregion

		#region Properties: Public

		public BpmonlineCloudEngine CloudEngine { get; set; }

		public BulkEmailEventLogger BulkEmailEventLogger { get; set; }

		public ICESApi ServiceApi { get; private set; }

		#endregion

		#region Methods: Private

		private bool PingProvider() {
			try {
				ServiceApi.Ping();
				return true;
			} catch {
				return false;
			}
		}

		private void RegisterSenderDomain(string senderEmail) {
			try {
				var domain = new Regex("^.*@").Replace(senderEmail, "");
				CloudEngine.RegisterSenderDomain(domain);
			} catch (Exception e) {
				MailingUtilities.Log.ErrorFormat(
					"[CESMaillingProvider.RegisterSenderDomain]: Error while registering domain for email: {0}", e,
					senderEmail);
			}
		}

		private bool ValidateBulkEmail(Entity bulkEmail) {
			if (bulkEmail.GetTypedColumnValue<Guid>("SegmentsStatusId") != MailingConsts.SegmentStatusUpdatingId) {
				return true;
			}
			MailingUtilities.Log.InfoFormat("BulkEmail with Id: {0} can't get started. Segment status is 'Updating'.",
				bulkEmail.PrimaryColumnValue);
			return false;
		}

		#endregion

		#region Methods: Public

		public override MailingResponse ExecuteState() {
			var response = new MailingResponse {
				Success = false,
				StatusId = MailingConsts.BulkEmailStatusErrorId
			};
			var bulkEmailId = Context.BulkEmailEntity.PrimaryColumnValue;
			if (!ValidateBulkEmail(Context.BulkEmailEntity)) {
				return response;
			}
			var validationResult = ActiveContactsHelper.ValidatePermissionEditBulkEmail(UserConnection);
			if (validationResult.Code == ActiveContactsValidationResult.Error) {
				MailingUtilities.Log.ErrorFormat(
					"[CESMaillingProvider.ExecuteSendMessage]: License check failed. SessionId: {0}.",
					Context.SessionId);
				BulkEmailEventLogger.LogError(bulkEmailId, DateTime.UtcNow, GetLczStringValue("BatchSendEvent"),
					GetLczStringValue("LicenceErrorMsg"), UserConnection.CurrentUser.ContactId);
				return new MailingResponse {
					Success = false,
					StatusId = MailingConsts.BulkEmailStatusErrorId,
					RemindingLczStringCode = validationResult.Message
				};
			}
			if (!PingProvider()) {
				MailingUtilities.Log.ErrorFormat(
					"[CESMaillingProvider.ExecuteSendMessage]: CESApi.Ping Fails. SessionId: {0}.", Context.SessionId);
				BulkEmailEventLogger.LogError(bulkEmailId, DateTime.UtcNow, GetLczStringValue("BatchSendEvent"),
					GetLczStringValue("CloudUnreachableMsg"), UserConnection.CurrentUser.ContactId);
				return new MailingResponse {
					Success = false,
					StatusId = MailingConsts.BulkEmailStatusErrorId,
					RemindingLczStringCode = "CESPingFailsMsg"
				};
			}
			RegisterSenderDomain(Context.BulkEmailEntity.GetTypedColumnValue<string>("SenderEmail"));
			response.Success = true;
			response.StatusId = MailingConsts.BulkEmailStatusWaitingBeforeSendId;
			return response;
		}

		public override void Initialize() {
			base.Initialize();
			UserConnection = Context.UserConnection;
			ServiceApi = Context.ServiceApi;
			BulkEmailEventLogger = new BulkEmailEventLogger(UserConnection);
		}

		#endregion

	}

	#endregion

}

