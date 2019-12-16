namespace Terrasoft.Core.Process.Configuration
{
	using System;
	using System.Collections.Generic;
	using MailBee.Mime;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Factories;
	using Terrasoft.Core.Process;
	using Terrasoft.Mail;
	using Terrasoft.Mail.Sender;
	using global::Common.Logging;
	using Terrasoft.Configuration.ProcessDesigner;
	using SysSettings = Core.Configuration.SysSettings;

	#region Class: AutoEmailUserTaskSender

	public class AutoEmailUserTaskSender : IEmailUserTaskSender
	{

		#region Fields: Private

		private static readonly ILog _log = LogManager.GetLogger("Process");

		#endregion

		#region Properties: Public

		public UserConnection UserConnection {
			get;
			set;
		}

		#endregion

		#region Methods: Public

		protected EmailAddressCollection GetEmailAddressCollection(IEnumerable<string> emailAddresses) {
			var emailAddressCollection = new EmailAddressCollection();
			foreach (var emailAddress in emailAddresses) {
				emailAddressCollection.Add(emailAddress);
			}
			return emailAddressCollection;
		}

		#endregion

		#region Methods: Public

		public virtual void SendEmailWithDefaultSender(EmailMessage emailMessage, bool ignoreErrors) {
			MailCredentials credentials = new MailCredentials {
				Host = (string)SysSettings.GetValue(UserConnection, "SmtpHost"),
				Port = int.Parse(SysSettings.GetValue(UserConnection, "SmtpPort").ToString()),
				UseSsl = (bool)SysSettings.GetValue(UserConnection, "SmtpEnableSsl"),
				UserName = (string)SysSettings.GetValue(UserConnection, "SmtpUserName"),
				UserPassword = (string)SysSettings.GetValue(UserConnection, "SmtpUserPassword")
			};
			string[] to = emailMessage.To.ToArray();
			EmailAddressCollection cc = GetEmailAddressCollection(emailMessage.Cc);
			EmailAddressCollection bcc = GetEmailAddressCollection(emailMessage.Bcc);
			var smtpClient = new SmtpClient(UserConnection);
			MailMessage mailBeeMessage = smtpClient.CreateMessage(emailMessage.Body, emailMessage.Subject, to,
				credentials.UserName, true, new Dictionary<Guid, Tuple<byte[], string>>(0));
			mailBeeMessage.Cc = cc;
			mailBeeMessage.Bcc = bcc;
			mailBeeMessage.Priority = (MailPriority)emailMessage.Priority;
			try {
				smtpClient.SendMessage(mailBeeMessage, credentials);
			} catch (Exception e) {
				_log.Error(e);
				if (!ignoreErrors) {
					throw;
				}
			}
		}

		public bool Execute(IEmailUserTaskMessageProvider messageProvider, ProcessExecutingContext context) {
			EmailTemplateUserTask userTask = messageProvider.EmailUserTask;
			EmailMessage message = messageProvider.GetEmailMessage();
			if (message.To.IsNullOrEmpty()) {
				return true;
			}
			if (message.From.IsEmpty()) {
				SendEmailWithDefaultSender(message, userTask.IgnoreErrors);
				return true;
			}
			var constructorArguments = new ConstructorArgument("userConnection", UserConnection);
			var emailClientFactory = ClassFactory.Get<EmailClientFactory>(constructorArguments);
			var emailSender = new HtmlEmailMessageSender(emailClientFactory, UserConnection);
			try {
				bool ignoreRights = (SendEmailType)userTask.SendEmailType == SendEmailType.Auto;
				emailSender.Send(message, ignoreRights);
			} catch (Exception e) {
				_log.Error(e);
				if (!userTask.IgnoreErrors) {
					throw;
				}
			}
			return true;
		}

		public bool CompleteExecuting(EmailTemplateUserTask userTask,
				Func<object[], bool> callBase, params object[] parameters) {
			return callBase(parameters);
		}

		public void CancelExecuting(EmailTemplateUserTask userTask,
				Action<object[]> callBase, params object[] parameters) {
			callBase(parameters);
		}

		public string GetExecutionData(EmailTemplateUserTask userTask) {
			return string.Empty;
		}

		/// <summary>
		/// Returns instance that implements the <see cref="IProcessNotifier"/> interface.
		/// </summary>
		/// <param name="baseProcessNotifier">Delegate to get base process notifier.</param>
		/// <returns></returns>
		public IProcessNotifier GetProcessNotifier(Func<IProcessNotifier> baseProcessNotifier) {
			return new EmptyProcessNotifier();
		}

		#endregion

	}

	#endregion

}
